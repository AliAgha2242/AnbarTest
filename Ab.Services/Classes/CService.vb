'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/09/1
'ModifiedDate::
'Description::  سرويس هاي سيستم انبار
'System ::انبار

Public Class CService

    Public Shared Function RezervKala(ByVal acn As NetSql.DB.CConnection _
                                       , ByVal aVahedeTejariSN As Decimal _
                                       , ByVal aAnbarSN As Object _
                                       , ByVal aNoeAnbarSN As Decimal _
                                       , ByVal aIdentifier As Decimal _
                                       , ByVal aPayeSN As Decimal _
                                       , ByVal aTarafHesabSN As Decimal _
                                       , ByVal aTafsiliSN As Object _
                                       , ByVal aKalaSN As Object _
                                       , ByVal aMeghdarRezerv As Object _
                                       , ByVal aAnbarKalaRezervStatus As Integer _
                                       , ByVal aDelStatus As Object _
                                       , ByVal aUserID_Name As String _
                                       ) As String
        Dim vErrorMsg As String
        'Dim ds As Minoo.Applications.Anbar.Common.dsSanad

        ' EXEC _abSp_Darj_RezervKala
        '@VahedeTejariSN 
        ',Null --@AnbarSN  
        ',2 -- @NoeAnbarSN 
        ',2 --@PayeSN	Decimal(19,3) -- System Identifier
        ',@DarkhastSN -- @TarafHesabSN	Decimal(19,3) -- Darkhast Or ... Identifier
        ',Null -- @TafsiliSN	Decimal(19,3)
        ',Null --@KalaSN Decimal(19,3)
        ',Null --@MeghdarRezerv	Decimal(19,3)
        ',0 -- @AnbarKalaRezervStatus Tinyint
        ',Null --@DelStatus Tinyint
        ',@UserID_Name
        '	,@ErrorMsg
        Try
            ' فراخواني اس پي براي انجام عمليات رزرو با توجه به پارامترهاي ارسالي
            acn.CallSP("_abSp_Darj_RezervKala", aVahedeTejariSN _
                        , aAnbarSN _
                        , aNoeAnbarSN _
                        , aPayeSN _
                        , aTarafHesabSN _
                        , aTafsiliSN _
                        , aKalaSN _
                        , aMeghdarRezerv _
                        , aAnbarKalaRezervStatus _
                        , aDelStatus _
                        , aUserID_Name _
                        , vErrorMsg)

        Catch ex As Exception
            vErrorMsg = ex.Message
        End Try
        Return vErrorMsg
    End Function

    Public Shared Function DarjSanad(ByVal acn As NetSql.DB.CConnection _
                                      , ByVal atp As NetSql.Common.CSystem _
                                      , ByVal aVahedeTejariSN As Decimal _
                                      , ByVal aAnbarSN As Decimal _
                                      , ByVal aNoeAnbarSN As Decimal _
                                      , ByVal aIdentifier As Decimal _
                                      , ByVal aDVSanad As DataView _
                                      , ByVal aDVSanadHa As DataView _
                                      , ByVal aUserID As Integer _
                                      , ByVal aUserID_Name As String _
                                      , ByVal aNoCtrlKardex As Integer _
                                      ) As String
        '1  acn :  Connection مورد استفاده در درج سند انبار
        '2 atp : CSystem  سيستم استفاده کنند از سرويس
        '3 aVahedeTejariSN : کليد اوليه واحد تجاري
        '4 aAnbarSN کليد اوليه انبار
        '5 aNoeAnbarSN : کليد اوليه نوع انبار
        '6                               aDVSanad   ديتا ويو عنوان سند
        '  SanadSN , SanadDate, SanadStatus, TarakoneshSN, HavalehForooshSN, TafsiliSN
        ', ShomarehSefaresh , ShomarehBarnameh , ShomarehMashin , NameRanandeh , Tozih , MojavezErsalSN, WorkOrederSN

        '7                               aDVSanadHa  ديتا ويو اقلام سند
        '  SanadSN , KalaSN , MeghdareVaredeh, MeghdareSadereh, MeghdareNakhales, TedadZarf
        ', NoeZayeatSN , NoeMarjooeiSN , NoeMadomiSN , ShomarehRahgiri , WorkOrederHaSN
        '8 aUserID : کد کاربر
        '9 aUserID_Name : کد + نام کاربر
        '10 aNoCtrlKardex در صورت عدد يک کنترل موجودي نميشود 
        'Return  خروجي سرويس پيغام خطاي احتمالي است

        Dim SaveSanadToDataBase, vStayOpen As Boolean
        Dim vErrorMsg As String

        Dim ar_SanadSN(,) As Decimal
        Dim _
            vMarjaSanadSN, _
            vSanadDate, _
            vShomarehSefaresh, _
            vHavalehForooshSN, _
            vShomarehBarnameh, _
            vMojavezErsalSN, _
            vWorkOrederSN As Object
        '850612
        Dim vShomarehMashin, vNameRanandeh, vTozih As Object, vHost_Name As String
        Dim vSanadStatus, vTarakoneshSN, vTafsiliSN As Object, vNoeSanadID As Integer
        Dim vState As Short
        Dim vCommand As EnumCommands = EnumCommands.cmSave
        'Dim vSanadNo As String
        Dim vMarjaSanadHaSN, vKalaSN, vMeghdareVaredeh, vMeghdareSadereh, vMeghdareNakhales As Object
        Dim vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN As Object
        Dim vTedadZarf, vKalaPhizikiSN As Object
        Dim vShomarehRahgiri, vKalaPhizikiStatusDS, vWorkOrederHaSN As Object
        Dim v_UserParam As String
        Dim vSanadHaSN, vSanadSN, vInSanadSN As Decimal
        Dim i, j As Integer
        Dim vMessage As String = ""
        Dim vRetValSP As Integer = 0
        Dim vdv As DataView
        Dim vToolidDate, vEnghezaDate As Object
        Dim vTafsiliSN2 As Object
        Dim vDarkhastHaSN, vMojavezErsalHaSN As Object

        SaveSanadToDataBase = False
        vErrorMsg = ""
        ' 1 براي عدم کنترل موجودي     کاردکس
        If aNoCtrlKardex <> 1 Then
            aNoCtrlKardex = 0
        End If
        ' کنترل اطلاعات ورودي
        If aDVSanad.Count > 0 And aDVSanadHa.Count > 0 And Trim(aUserID_Name) <> "" _
           And aVahedeTejariSN <> 0 And aNoeAnbarSN <> 0 And aAnbarSN <> 0 And aUserID <> 0 Then
            vStayOpen = acn.StayOpen
            acn.StayOpen = True
            If acn.Connection.State <> ConnectionState.Open Then
                vMessage = " DarjSanad : Oppennig ConnectioLn to " & acn.SQLServerName & _
                           " Database " & acn.SQLDatabaseName
                atp.LogStr(vMessage)
                acn.OpenConnection()
            End If
            ReDim ar_SanadSN(aDVSanad.Count, 2)
            vHost_Name = System.Environment.MachineName
            Try
                acn.BeginTrans(acn.Connection.BeginTransaction())
                vMessage = String.Format(" DarjSanad : Saving {0} Sanad . " & vbCrLf, CStr(aDVSanad.Count))
                atp.LogStr(vMessage)
                For i = 0 To aDVSanad.Count - 1
                    If aDVSanad.Table.Rows(i)("SanadDate").ToString() <> "" Then
                        vSanadSN = aIdentifier
                        ' acn.Identifier
                        With aDVSanad.Table
                            vInSanadSN = .Rows(i)("SanadSN")
                            vMarjaSanadSN = .Rows(i)("MarjaSanadSN")
                            vSanadDate = .Rows(i)("SanadDate")
                            vSanadStatus = .Rows(i)("SanadStatus")
                            vTarakoneshSN = .Rows(i)("TarakoneshSN")
                            vHavalehForooshSN = .Rows(i)("HavalehForooshSN")
                            vMojavezErsalSN = .Rows(i)("MojavezErsalSN")
                            vTafsiliSN = .Rows(i)("TafsiliSN")
                            vShomarehSefaresh = .Rows(i)("ShomarehSefaresh")
                            vShomarehBarnameh = .Rows(i)("ShomarehBarnameh")
                            vShomarehMashin = .Rows(i)("ShomarehMashin")
                            vNameRanandeh = .Rows(i)("NameRanandeh")
                            vTozih = .Rows(i)("Tozih")
                            vState = EnumDataViewState.bsAdd
                            vCommand = EnumCommands.cmSave
                            vWorkOrederSN = .Rows(i)("WorkOrederSN")
                            '850612
                            vNoeSanadID = .Rows(i)("NoeSanadID")
                            '850922
                            ' کنترل اطلاعات سند
                            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                            vRetValSP = _
                                acn.CallSP("_abSPC_abSanadEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN _
                                            , vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                            , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, _
                                            System.DBNull.Value _
                                            , vShomarehSefaresh, System.DBNull.Value, vCommand, vState, vErrorMsg, vMarjaSanadSN)
                            If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                Throw New Exception("خطا در کنترل سند انبار" & vbCrLf & vErrorMsg)
                            End If

                            ' کنترل اطلاعات سند

                            ' ثبت اطلاعات سند
                            vRetValSP = _
                                cn.CallSP("_abSanadC_InsertX", vSanadSN, vSanadDate, vSanadDate, aAnbarSN, aNoeAnbarSN, _
                                           vTarakoneshSN, vTafsiliSN _
                                           , 1, vWorkOrederSN, aVahedeTejariSN, vShomarehSefaresh _
                                           , vTozih, aUserID, aUserID_Name, aUserID, aUserID_Name, aUserID_Name, _
                                           vHost_Name, vSanadDate, 2, vSanadDate)
                            ' ثبت اطلاعات سند
                            If vRetValSP <> 0 Or Val(vSanadSN) < 1 Then
                                Throw New Exception("خطا در درج سند انبار")
                            Else
                                ar_SanadSN(i, 1) = vSanadSN
                                ar_SanadSN(i, 2) = vSanadStatus
                            End If
                            vMessage = _
                                String.Format(" DarjSanad : Saving {0} SanadHa ." & vbCrLf, CStr(aDVSanadHa.Count))
                            atp.LogStr(vMessage)
                        End With

                        aDVSanadHa.RowFilter = " SanadSN =  " & vInSanadSN.ToString
                        For j = 0 To aDVSanadHa.Count - 1
                            vSanadHaSN = aIdentifier
                            'acn.Identifier
                            If aDVSanadHa.Table.Rows(j)("KalaSN").ToString() <> "" Then

                                '// بر اساس انبار و کال رويه رهگيري پر شود
                                vdv = _
                                    acn.ExecuteQuery( _
                                                      " SELECT ISNULL(KalaPhizikiStatusSN,0) AS KalaPhizikiStatusSN FROM abAnbarKala " & _
                                                      "  WHERE   AnbarSN = " & aAnbarSN.ToString & _
                                                      " AND  KalaSN = " & _
                                                      aDVSanadHa.Table.Rows(j)("KalaSN").ToString())
                                Dim KalaDS As String
                                KalaDS = _
                                    CStr( _
                                        acn.ExecuteQuery( _
                                                          "SELECT KalaNO+'-'+KalaDS FROM PaKala WHERE KalaSN = " & _
                                                          aDVSanadHa.Table.Rows(j)("KalaSN").ToString())(0).Item(0))

                                If vdv.Count = 0 Then
                                    Throw New Exception("کالاي " & KalaDS & " به کالاهاي هر انبار اضافه نشده است")
                                End If
                                vKalaPhizikiStatusDS = vdv(0)("KalaPhizikiStatusSN")
                                If vKalaPhizikiStatusDS = 0 Then
                                    Throw _
                                        New Exception( _
                                                       "رويه رهگيري کالاي " & KalaDS & _
                                                       "در اين انبار مشخص نشده است سندي نميتواند ثبت گردد")
                                End If
                                vdv.Dispose()
                                '// بر اساس انبار و کال رويه رهگيري پر شود

                                With aDVSanadHa.Table
                                    vMarjaSanadHaSN = .Rows(j)("MarjaSanadHaSN")
                                    vKalaSN = .Rows(j)("KalaSN")
                                    vMeghdareVaredeh = _
                                        IIf(.Rows(j)("MeghdareVaredeh") = 0, DBNull.Value, _
                                             .Rows(j)("MeghdareVaredeh"))
                                    vMeghdareSadereh = _
                                        IIf(.Rows(j)("MeghdareSadereh") = 0, DBNull.Value, _
                                             .Rows(j)("MeghdareSadereh"))
                                    vMeghdareNakhales = .Rows(j)("MeghdareNakhales")
                                    'vTedadZarf = .Rows(i)("TedadZarf")
                                    vNoeZayeatSN = 0
                                    '.Rows(j)("NoeZayeatSN")
                                    vNoeMarjooeiSN = 0
                                    '.Rows(j)("NoeMarjooeiSN")
                                    vNoeMadomiSN = 0
                                    '.Rows(j)("NoeMadomiSN")
                                    vKalaPhizikiSN = .Rows(j)("KalaPhizikiSN")
                                    'acn.Identifier
                                    vShomarehRahgiri = .Rows(j)("ShomarehRahgiri")
                                    vWorkOrederHaSN = .Rows(j)("WorkOrederHaSN")
                                    '850612
                                    vToolidDate = .Rows(j)("ToolidDate")
                                    vEnghezaDate = .Rows(j)("EnghezaDate")

                                    '  پر کردن UserParam از مقادير مربوطه
                                    v_UserParam = IIf(vTarakoneshSN = 39, gSM.Identifier, vKalaPhizikiSN) & ";" & _
                                                  vShomarehRahgiri & ";" & _
                                                  vKalaPhizikiStatusDS & _
                                                  ";" & CStr(aVahedeTejariSN) & ";" & CStr(aAnbarSN) & ";" & _
                                                  CStr(aNoeAnbarSN)
                                End With
                                ' کنترل اطلاعات رديف سند
                                vState = EnumDataViewState.bsAdd
                                vCommand = EnumCommands.cmSave
                                ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                                vRetValSP = _
                                    acn.CallSP("_abSPC_abSanadHaEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, _
                                                vSanadSN, _
                                                vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                , System.DBNull.Value, System.DBNull.Value, vCommand, vState, vErrorMsg, _
                                                vKalaSN _
                                                , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                , vNoeMadomiSN, IIf(vTarakoneshSN = 39, vKalaPhizikiSN, DBNull.Value), _
                                                vShomarehRahgiri, vSanadHaSN, vKalaPhizikiStatusDS, aNoCtrlKardex, _
                                                vTafsiliSN2, vDarkhastHaSN, vMojavezErsalHaSN, System.DBNull.Value, _
                                                System.DBNull.Value)
                                If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                    Throw New Exception("خطا در کنترل رديف سند" & vbCrLf & vErrorMsg)
                                End If
                                ' کنترل اطلاعات رديف سند
                                ' ثبت اطلاعات رديف سند
                                vRetValSP = acn.CallSP("_abSanadHa_InsertX", vSanadHaSN, vSanadSN _
                                                        , vMarjaSanadHaSN, System.DBNull.Value _
                                                        , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vMeghdareVaredeh, System.DBNull.Value _
                                                        , vMeghdareSadereh, System.DBNull.Value _
                                                        , vMeghdareNakhales, _
                                                        IIf(vNoeZayeatSN <= 0, DBNull.Value, vNoeZayeatSN), _
                                                        IIf(vNoeMarjooeiSN <= 0, DBNull.Value, vNoeMarjooeiSN), _
                                                        IIf(vNoeMadomiSN <= 0, DBNull.Value, vNoeMadomiSN) _
                                                        , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , vWorkOrederHaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vTedadZarf, _
                                                        IIf(vTarakoneshSN = 39, gSM.Identifier, vKalaPhizikiSN) _
                                                        , System.DBNull.Value, aUserID_Name, vHost_Name, _
                                                        System.DBNull.Value, vToolidDate, vEnghezaDate _
                                                        , System.DBNull.Value, v_UserParam)
                                ' ثبت اطلاعات رديف سند
                            End If
                            If vRetValSP <> 0 Or Val(vSanadHaSN) < 1 Or Trim(v_UserParam) <> "" Then
                                Throw New Exception("خطا در درج رديف سند" + " " + v_UserParam)
                            End If
                        Next j
                        ' For j = 0 To countSanadHa - 1
                    Else
                        vMessage = " DarjSanad : " & " اسناد ارسال شده خالي است "
                        atp.LogStr(vMessage)
                        vErrorMsg = " اسناد ارسال شده خالي است "
                        Throw New Exception(vErrorMsg)
                    End If
                Next i
                ' For j = 0 To aDVSanadHa.Count - 1

                '  تغيير وضعيت سند 
                For i = 0 To aDVSanad.Count - 1
                    vSanadSN = Val(ar_SanadSN(i, 1))
                    vSanadStatus = ar_SanadSN(i, 2)
                    If vSanadSN <> 0 And vSanadStatus > 1 Then
                        ' فراخواني اس پي براي تغيير وضعيت سند
                        vRetValSP = acn.CallSP("_abSPC_Change_SanadStatus", vSanadSN, vSanadStatus _
                                                , aUserID, aUserID_Name, vErrorMsg, aNoCtrlKardex)
                        If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                            Throw New Exception(" اشکال در تغيير وضعيت سند " & vbCrLf & vErrorMsg)
                        End If
                    ElseIf vSanadSN = 0 Then
                        Throw New Exception(" اشکال در تغيير وضعيت سند ")
                    End If
                Next
                '  تغيير وضعيت سند 
                SaveSanadToDataBase = True
                vMessage = " SaveSanadToDataBase = True . "
                atp.LogStr(vMessage)
            Catch ex As Exception
                vErrorMsg = ex.Message
                vMessage = " DarjSanad : " & vErrorMsg
                atp.LogStr(vMessage)
                acn.RollbackTrans()
            Finally
                acn.StayOpen = vStayOpen
                acn.CommitTrans()
            End Try
        Else
            vMessage = " DarjSanad : " & " بسته ارسالي خالي است"
            atp.LogStr(vMessage)
            vErrorMsg = " بسته ارسالي خالي است"
        End If
        If SaveSanadToDataBase Then
            Return ""
        Else
            Return vErrorMsg
        End If
    End Function

    Public Shared Function DarjSanadWithUnRezervKala(ByVal acn As NetSql.DB.CConnection _
                                                      , ByVal atp As NetSql.Common.CSystem _
                                                      , ByVal aVahedeTejariSN As Decimal _
                                                      , ByVal aAnbarSN As Decimal _
                                                      , ByVal aNoeAnbarSN As Decimal _
                                                      , ByVal aIdentifier As Decimal _
                                                      , ByVal aDVSanad As DataView _
                                                      , ByVal aDVSanadHa As DataView _
                                                      , ByVal aUserID As Integer _
                                                      , ByVal aUserID_Name As String _
                                                      , ByVal aNoCtrlKardex As Integer _
                                                      , ByVal aPayeSN As Decimal _
                                                      , ByVal aTarafHesabSN As Decimal _
                                                      , ByVal aTafsiliSN As Object _
                                                      , ByVal aKalaSN As Object _
                                                      , ByVal aMeghdarRezerv As Object _
                                                      , ByVal aAnbarKalaRezervStatus As Integer _
                                                      , ByVal aDelStatus As Object _
                                                      ) As String
        '1  acn :  Connection مورد استفاده در درج سند انبار
        '2 atp : CSystem  سيستم استفاده کنند از سرويس
        '3 aVahedeTejariSN : کليد اوليه واحد تجاري
        '4 aAnbarSN کليد اوليه انبار
        '5 aNoeAnbarSN : کليد اوليه نوع انبار
        '6                               aDVSanad   ديتا ويو عنوان سند
        '  SanadSN , SanadDate, SanadStatus, TarakoneshSN, HavalehForooshSN, TafsiliSN
        ', ShomarehSefaresh , ShomarehBarnameh , ShomarehMashin , NameRanandeh , Tozih , MojavezErsalSN, WorkOrederSN

        '7                               aDVSanadHa  ديتا ويو اقلام سند
        '  SanadSN , KalaSN , MeghdareVaredeh, MeghdareSadereh, MeghdareNakhales, TedadZarf
        ', NoeZayeatSN , NoeMarjooeiSN , NoeMadomiSN , ShomarehRahgiri , WorkOrederHaSN
        '8 aUserID : کد کاربر
        '9 aUserID_Name : کد + نام کاربر
        '10 aNoCtrlKardex در صورت عدد يک کنترل موجودي نميشود 

        ',2 --@PayeSN	Decimal(19,3) -- System Identifier
        ',@DarkhastSN -- @TarafHesabSN	Decimal(19,3) -- Darkhast Or ... Identifier
        ',Null -- @TafsiliSN	Decimal(19,3)
        ',Null --@KalaSN Decimal(19,3)
        ',Null --@MeghdarRezerv	Decimal(19,3)
        ',0 -- @AnbarKalaRezervStatus Tinyint
        ',Null --@DelStatus Tinyint

        'Return  خروجي سرويس پيغام خطاي احتمالي است

        Dim vErrorMsg As String
        vErrorMsg = ""
        Dim SaveSanadToDataBase, vStayOpen As Boolean
        SaveSanadToDataBase = False

        vStayOpen = acn.StayOpen

        Try
            acn.BeginTrans(acn.Connection.BeginTransaction())
            vErrorMsg = RezervKala(acn _
                                    , aVahedeTejariSN _
                                    , aAnbarSN _
                                    , aNoeAnbarSN _
                                    , aIdentifier _
                                    , aPayeSN _
                                    , aTarafHesabSN _
                                    , aTafsiliSN _
                                    , aKalaSN _
                                    , aMeghdarRezerv _
                                    , aAnbarKalaRezervStatus _
                                    , aDelStatus _
                                    , aUserID_Name _
                                    )
            SaveSanadToDataBase = True
            vErrorMsg = " SaveSanadToDataBase = True . "
            atp.LogStr(vErrorMsg)
        Catch ex As Exception
            vErrorMsg = vErrorMsg & " DarjSanad : " & ex.Message
            atp.LogStr(vErrorMsg)
            acn.RollbackTrans()
            Return vErrorMsg
        End Try

        If SaveSanadToDataBase = True Then
            SaveSanadToDataBase = False
            Try
                vErrorMsg = DarjSanad(acn _
                                       , atp _
                                       , aVahedeTejariSN _
                                       , aAnbarSN _
                                       , aNoeAnbarSN _
                                       , aIdentifier _
                                       , aDVSanad _
                                       , aDVSanadHa _
                                       , aUserID _
                                       , aUserID_Name _
                                       , aNoCtrlKardex _
                                       )

                SaveSanadToDataBase = True
            Catch ex As Exception
                vErrorMsg = vErrorMsg & " DarjSanad : " & ex.Message
                atp.LogStr(vErrorMsg)
                acn.RollbackTrans()
                Return vErrorMsg
            Finally
                acn.StayOpen = vStayOpen
                acn.CommitTrans()
            End Try
            SaveSanadToDataBase = True
        End If

        If SaveSanadToDataBase Then
            Return ""
        Else
            Return vErrorMsg
        End If

    End Function

    Public Shared Function DarjSanadHa(ByVal acn As NetSql.DB.CConnection _
                                        , ByVal atp As NetSql.Common.CSystem _
                                        , ByVal aVahedeTejariSN As Decimal _
                                        , ByVal aAnbarSN As Decimal _
                                        , ByVal aNoeAnbarSN As Decimal _
                                        , ByVal aIdentifier As Decimal _
                                        , ByVal aDVSanad As DataView _
                                        , ByVal aDVSanadHa As DataView _
                                        , ByVal aUserID As Integer _
                                        , ByVal aUserID_Name As String _
                                        , ByVal aNoCtrlKardex As Integer _
                                        ) As String

        Dim SaveSanadToDataBase, vStayOpen As Boolean
        Dim vErrorMsg As String

        Dim ar_SanadSN(,) As Decimal
        Dim vMarjaSanadSN, vSanadDate, vShomarehSefaresh, vHavalehForooshSN, vShomarehBarnameh, vMojavezErsalSN, vWorkOrederSN, HavalehForooshSN As Object
        Dim vShomarehMashin, vNameRanandeh, vTozih As Object, vHost_Name As String
        Dim vSanadStatus, vTarakoneshSN, vTafsiliSN As Object, vNoeSanadID As Integer
        Dim vState As Short
        Dim vCommand As EnumCommands = EnumCommands.cmSave

        Dim vMarjaSanadHaSN, vKalaSN, vMeghdareVaredeh, vMeghdareSadereh, vMeghdareNakhales As Object
        Dim vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN As Object
        Dim vTedadZarf, vKalaPhizikiSN As Object
        Dim vTafsiliSN2 As Object
        Dim vShomarehRahgiri, vKalaPhizikiStatusDS, vWorkOrederHaSN As Object
        Dim v_UserParam As String
        Dim vToolidDate, vEnghezaDate As Object
        Dim vSanadHaSN, vSanadSN, vInSanadSN As Decimal
        Dim i, j As Integer
        Dim vMessage As String = ""
        Dim vRetValSP As Integer = 0
        Dim vdv As DataView
        Dim vDarkhastHaSN, vMojavezErsalHaSN As Object

        SaveSanadToDataBase = False
        vErrorMsg = ""
        ' 1 براي عدم کنترل موجودي     کاردکس
        If aNoCtrlKardex <> 1 Then
            aNoCtrlKardex = 0
        End If
        ' کنترل اطلاعات ورودي
        If aDVSanad.Count > 0 And aDVSanadHa.Count > 0 And Trim(aUserID_Name) <> "" _
           And aVahedeTejariSN <> 0 And aNoeAnbarSN <> 0 And aAnbarSN <> 0 And aUserID <> 0 Then
            vStayOpen = acn.StayOpen
            acn.StayOpen = True
            If acn.Connection.State <> ConnectionState.Open Then
                vMessage = " DarjSanadHa : Oppennig ConnectioLn to " & acn.SQLServerName & _
                           " Database " & acn.SQLDatabaseName
                atp.LogStr(vMessage)
                acn.OpenConnection()
            End If
            ReDim ar_SanadSN(aDVSanad.Count, 2)
            vHost_Name = System.Environment.MachineName
            Try
                acn.BeginTrans(acn.Connection.BeginTransaction())
                vMessage = String.Format(" DarjSanadHa : Check {0} Sanad . " & vbCrLf, CStr(aDVSanad.Count))
                atp.LogStr(vMessage)
                For i = 0 To aDVSanad.Count - 1
                    If aDVSanad.Table.Rows(i)("SanadDate").ToString() <> "" Then
                        With aDVSanad.Table
                            vSanadSN = CDec(.Rows(i)("SanadSN"))
                            vInSanadSN = CDec(.Rows(i)("SanadSN"))
                            vMarjaSanadSN = .Rows(i)("MarjaSanadSN")
                            vSanadDate = .Rows(i)("SanadDate")
                            vSanadStatus = .Rows(i)("SanadStatus")
                            vTarakoneshSN = .Rows(i)("TarakoneshSN")
                            vHavalehForooshSN = .Rows(i)("HavalehForooshSN")
                            vMojavezErsalSN = .Rows(i)("MojavezErsalSN")
                            vTafsiliSN = .Rows(i)("TafsiliSN")
                            vShomarehSefaresh = .Rows(i)("ShomarehSefaresh")
                            vShomarehBarnameh = .Rows(i)("ShomarehBarnameh")
                            vShomarehMashin = .Rows(i)("ShomarehMashin")
                            vNameRanandeh = .Rows(i)("NameRanandeh")
                            'HavalehForooshSN = .Rows(i)("HavalehForooshSN")
                            vTozih = .Rows(i)("Tozih")
                            vState = CShort(EnumDataViewState.bsAdd)
                            vCommand = EnumCommands.cmSave
                            vWorkOrederSN = .Rows(i)("WorkOrederSN")
                            vNoeSanadID = CInt(.Rows(i)("NoeSanadID"))
                            vTafsiliSN2 = .Rows(i)("TafsiliSN2")

                            ' کنترل اطلاعات سند
                            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                            'vRetValSP = acn.CallSP("_abSPC_abSanadEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN _
                            '      , vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                            '      , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '      , vShomarehSefaresh, System.DBNull.Value, vCommand, vState, vErrorMsg)
                            'If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                            '    Throw New Exception("خطا در کنترل سند انبار" & vbCrLf & vErrorMsg)
                            'End If

                            ' کنترل اطلاعات سند

                            ' ثبت اطلاعات سند
                            'acn.SPQuery("_abSanad_InsertX", vSanadSN _
                            '          , vMarjaSanadSN, System.DBNull.Value, vSanadDate, vSanadDate _
                            '          , aAnbarSN, aNoeAnbarSN, vTarakoneshSN, System.DBNull.Value, vTafsiliSN _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , 1, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, vMojavezErsalSN, vWorkOrederSN _
                            '          , vHavalehForooshSN, aVahedeTejariSN, vShomarehBarnameh, vShomarehMashin _
                            '          , vNameRanandeh, vShomarehSefaresh _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , vTozih, aUserID, aUserID_Name, aUserID, aUserID_Name, aUserID_Name _
                            '          , vHost_Name, System.DBNull.Value, vSanadDate, vNoeSanadID, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                            '          , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value)
                            ' ثبت اطلاعات سند
                            'If vRetValSP <> 0 Or Val(vSanadSN) < 1 Then
                            '  Throw New Exception("خطا در درج سند انبار")
                            'Else
                            ar_SanadSN(i, 1) = vSanadSN
                            ar_SanadSN(i, 2) = CDec(vSanadStatus)
                            'End If
                            vMessage = String.Format(" DarjSanad : Saving {0} Sanad ." & vbCrLf, CStr(aDVSanad.Count))
                            atp.LogStr(vMessage)
                        End With

                        aDVSanadHa.RowFilter = " SanadSN =  " & vInSanadSN.ToString
                        For j = 0 To aDVSanadHa.Count - 1
                            vSanadHaSN = aIdentifier
                            'acn.Identifier
                            If aDVSanadHa.Table.Rows(j)("KalaSN").ToString() <> "" Then

                                '// بر اساس انبار و کال رويه رهگيري پر شود
                                'vdv = _
                                '    acn.ExecuteQuery( _
                                '                      " SELECT ISNULL(KalaPhizikiStatusSN,0) AS KalaPhizikiStatusSN FROM abAnbarKala " & _
                                '                      "  WHERE   AnbarSN = " & aAnbarSN.ToString & _
                                '                      " AND  KalaSN = " & _
                                '                      aDVSanadHa.Table.Rows(j)("KalaSN").ToString())

                                Dim KalaDS As String
                                'KalaDS =
                                '    CStr(
                                '        acn.ExecuteQuery(
                                '                          "SELECT KalaNO+'-'+KalaDS FROM PaKala WHERE KalaSN = " &
                                '                          aDVSanadHa.Table.Rows(j)("KalaSN").ToString())(0).Item(0))

                                KalaDS = CStr(aDVSanadHa.Table.Rows(j)("KalaDS").ToString())

                                If Not IsNumeric(aDVSanadHa.Table.Rows(j)("KalaPhizikiStatusSn")) Then
                                    Throw New Exception("کالاي " & KalaDS & " به کالاهاي هر انبار اضافه نشده است")
                                End If

                                'If vdv.Count = 0 Then
                                '    Throw New Exception("کالاي " & KalaDS & " به کالاهاي هر انبار اضافه نشده است")
                                'End If

                                vKalaPhizikiStatusDS = aDVSanadHa.Table.Rows(j)("KalaPhizikiStatusSn")
                                If CDec(aDVSanadHa.Table.Rows(j)("KalaPhizikiStatusSn")) = 0 Then
                                    Throw _
                                        New Exception(
                                                       "رويه رهگيري کالاي " & KalaDS &
                                                       "در اين انبار مشخص نشده است سندي نميتواند ثبت گردد")
                                End If
                                'vdv.Dispose()
                                '// بر اساس انبار و کال رويه رهگيري پر شود

                                With aDVSanadHa.Table
                                    vMarjaSanadHaSN = .Rows(j)("MarjaSanadHaSN")
                                    vKalaSN = .Rows(j)("KalaSN")
                                    vMeghdareVaredeh =
                                        IIf(CDbl(.Rows(j)("MeghdareVaredeh")) = 0, DBNull.Value,
                                             .Rows(j)("MeghdareVaredeh"))
                                    vMeghdareSadereh =
                                        IIf(CDbl(.Rows(j)("MeghdareSadereh")) = 0, DBNull.Value,
                                             .Rows(j)("MeghdareSadereh"))
                                    vMeghdareNakhales = .Rows(j)("MeghdareNakhales")
                                    'vTedadZarf = .Rows(i)("TedadZarf")
                                    vNoeZayeatSN = .Rows(j)("NoeZayeatSN")
                                    vNoeMarjooeiSN = .Rows(j)("NoeMarjooeiSN")
                                    vNoeMadomiSN = .Rows(j)("NoeMadomiSN")
                                    vKalaPhizikiSN = .Rows(j)("KalaPhizikiSN")
                                    'acn.Identifier
                                    vShomarehRahgiri = .Rows(j)("ShomarehRahgiri")
                                    vWorkOrederHaSN = .Rows(j)("WorkOrederHaSN")
                                    '850612
                                    vToolidDate = .Rows(j)("ToolidDate")
                                    vEnghezaDate = .Rows(j)("EnghezaDate")
                                    vDarkhastHaSN = .Rows(i)("DarkhastHaSN")
                                    vMojavezErsalHaSN = .Rows(i)("MojavezErsalHaSN")
                                    '  پر کردن UserParam از مقادير مربوطه
                                    'v_UserParam = IIf(vTarakoneshSN = 39, gSM.Identifier, vKalaPhizikiSN) & "," & vShomarehRahgiri & "," & _
                                    '                vKalaPhizikiStatusDS & _
                                    '                  "," & CStr(aVahedeTejariSN) & "," & CStr(aAnbarSN) & "," & CStr(aNoeAnbarSN)

                                    v_UserParam = vKalaPhizikiSN.ToString & ";" & vShomarehRahgiri.ToString & ";" &
                                                  vKalaPhizikiStatusDS.ToString &
                                                  ";" & CStr(aVahedeTejariSN) & ";" & CStr(aAnbarSN) & ";" &
                                                  CStr(aNoeAnbarSN)


                                End With
                                ' کنترل اطلاعات رديف سند
                                'vState = EnumDataViewState.bsEdit
                                vState = 2
                                vCommand = EnumCommands.cmSave
                                'کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                                'vRetValSP = acn.CallSP("_abSPC_abSanadHaEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN, _
                                '                      vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                '                      , System.DBNull.Value, System.DBNull.Value, vCommand, vState, vErrorMsg, vKalaSN _
                                '                      , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                '                      , vNoeMadomiSN, vKalaPhizikiSN, vShomarehRahgiri, vSanadHaSN, vKalaPhizikiStatusDS, aNoCtrlKardex, vTafsiliSN2, vDarkhastHaSN, vMojavezErsalHaSN)

                                If CDec(vTarakoneshSN) = 39 Then
                                    vRetValSP =
                                        acn.CallSP("_abSPC_abSanadHaEnter_Marjooei", CDec(aVahedeTejariSN), CDec(aAnbarSN), CDec(aNoeAnbarSN),
                                                    CDec(vSanadSN),
                                                    vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                    , System.DBNull.Value, System.DBNull.Value, (vCommand), CInt(vState), vErrorMsg,
                                                    vKalaSN _
                                                    , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                    , vNoeMadomiSN, vKalaPhizikiSN, vShomarehRahgiri, CDec(vSanadHaSN),
                                                    vKalaPhizikiStatusDS, CInt(aNoCtrlKardex), vTafsiliSN2, vDarkhastHaSN,
                                                    vMojavezErsalHaSN)
                                Else
                                    vRetValSP =
                                        acn.CallSP("_abSPC_abSanadHaEnter", CDec(aVahedeTejariSN), CDec(aAnbarSN), CDec(aNoeAnbarSN),
                                                    CDec(vSanadSN),
                                                    vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                    , System.DBNull.Value, System.DBNull.Value, (vCommand), CInt(vState), vErrorMsg,
                                                    vKalaSN _
                                                    , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                    , vNoeMadomiSN, vKalaPhizikiSN, vShomarehRahgiri, CDec(vSanadHaSN),
                                                    vKalaPhizikiStatusDS, CInt(aNoCtrlKardex), vTafsiliSN2, vDarkhastHaSN,
                                                    vMojavezErsalHaSN)
                                End If

                                If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                    Throw New Exception("خطا در کنترل رديف سند" & vbCrLf & vErrorMsg)
                                End If
                                ' کنترل اطلاعات رديف سند
                                ' ثبت اطلاعات رديف سند
                                'by yekta 911010  vMojavezErsalHaSN add 
                                If CDec(vTarakoneshSN) = 39 Then
                                    vRetValSP = acn.CallSP("_abSanadHa_InsertX_Marjooei", vSanadHaSN, CDec(vSanadSN) _
                                                            , vMarjaSanadHaSN, System.DBNull.Value _
                                                            , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                            , vMeghdareVaredeh, System.DBNull.Value _
                                                            , vMeghdareSadereh, System.DBNull.Value _
                                                            , vMeghdareNakhales,
                                                            IIf(CDec(vNoeZayeatSN) <= 0, DBNull.Value, vNoeZayeatSN),
                                                            IIf(CDec(vNoeMarjooeiSN) <= 0, DBNull.Value, vNoeMarjooeiSN),
                                                            IIf(CDec(vNoeMadomiSN) <= 0, DBNull.Value, vNoeMadomiSN) _
                                                            , System.DBNull.Value, System.DBNull.Value, vMojavezErsalHaSN _
                                                            , vWorkOrederHaSN, System.DBNull.Value, System.DBNull.Value _
                                                            , System.DBNull.Value, vKalaPhizikiSN _
                                                            , System.DBNull.Value, aUserID_Name.ToString, vHost_Name.ToString,
                                                            System.DBNull.Value, vToolidDate, vEnghezaDate _
                                                            , System.DBNull.Value, v_UserParam)
                                    ' ثبت اطلاعات رديف سند
                                Else

                                    vRetValSP = acn.CallSP("_abSanadHa_InsertX", vSanadHaSN, CDec(vSanadSN) _
                                                            , vMarjaSanadHaSN, System.DBNull.Value _
                                                            , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                            , vMeghdareVaredeh, System.DBNull.Value _
                                                            , vMeghdareSadereh, System.DBNull.Value _
                                                            , vMeghdareNakhales _
                                                            , IIf(CDec(vNoeZayeatSN) <= 0, DBNull.Value, vNoeZayeatSN) _
                                                            , IIf(CDec(vNoeMarjooeiSN) <= 0, DBNull.Value, vNoeMarjooeiSN) _
                                                            , IIf(CDec(vNoeMadomiSN) <= 0, DBNull.Value, vNoeMadomiSN) _
                                                            , System.DBNull.Value, System.DBNull.Value, vMojavezErsalHaSN _
                                                            , vWorkOrederHaSN _
                                                            , System.DBNull.Value _
                                                            , System.DBNull.Value _
                                                            , System.DBNull.Value, vKalaPhizikiSN _
                                                            , vShomarehSefaresh, aUserID_Name.ToString, vHost_Name.ToString _
                                                            , System.DBNull.Value, vToolidDate, vEnghezaDate _
                                                            , System.DBNull.Value, v_UserParam)
                                    ''If(vTarakoneshSN = 38 AndAlso IsNumeric(HavalehForooshSN), HavalehForooshSN, System.DBNull.Value)
                                    ' ثبت اطلاعات رديف سند
                                End If

                            End If
                            If vRetValSP <> 0 Or Val(vSanadHaSN) < 1 Or Trim(v_UserParam) <> "" Then
                                Throw New Exception("خطا در درج رديف سند" + " " + v_UserParam)
                            End If
                        Next j
                        ' For j = 0 To countSanadHa - 1
                    Else
                        vMessage = " DarjSanad : " & " اسناد ارسال شده خالي است "
                        atp.LogStr(vMessage)
                        vErrorMsg = " اسناد ارسال شده خالي است "
                        Throw New Exception(vErrorMsg)
                    End If
                Next i
                ' For j = 0 To aDVSanadHa.Count - 1

                '  تغيير وضعيت سند 
                'For i = 0 To aDVSanad.Count - 1
                '  vSanadSN = Val(ar_SanadSN(i, 1))
                '  vSanadStatus = ar_SanadSN(i, 2)
                '  If vSanadSN <> 0 And vSanadStatus > 1 Then
                '    ' فراخواني اس پي براي تغيير وضعيت سند
                '    vRetValSP = acn.CallSP("_abSPC_Change_SanadStatus", vSanadSN, vSanadStatus _
                '                                                          , aUserID, aUserID_Name, vErrorMsg, aNoCtrlKardex)
                '    If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                '      Throw New Exception(" اشکال در تغيير وضعيت سند " & vbCrLf & vErrorMsg)
                '    End If
                '  ElseIf vSanadSN = 0 Then
                '    Throw New Exception(" اشکال در تغيير وضعيت سند ")
                '  End If
                'Next
                '  تغيير وضعيت سند 

                SaveSanadToDataBase = True
                vMessage = " SaveSanadToDataBase = True . "
                atp.LogStr(vMessage)
                acn.CommitTrans()
            Catch ex As Exception
                vErrorMsg = ex.Message
                vMessage = " DarjSanad : " & vErrorMsg
                atp.LogStr(vMessage)
                acn.RollbackTrans()
            Finally
                acn.StayOpen = vStayOpen
            End Try
        Else
            vMessage = " DarjSanad : " & " بسته ارسالي خالي است"
            atp.LogStr(vMessage)
            vErrorMsg = " بسته ارسالي خالي است"
        End If

        If SaveSanadToDataBase Then
            Return ""
        Else
            Return vErrorMsg
        End If

    End Function

    Public Shared Function DarjResidHavaleh(ByVal acn As NetSql.DB.CConnection _
                                             , ByVal atp As NetSql.Common.CSystem _
                                             , ByVal aVahedeTejariSN As Decimal _
                                             , ByVal aAnbarSN As Decimal _
                                             , ByVal aNoeAnbarSN As Decimal _
                                             , ByVal aIdentifier As Decimal _
                                             , ByVal aDVSanad As DataView _
                                             , ByVal aDVSanadHa As DataView _
                                             , ByVal aDVSanad1 As DataView _
                                             , ByVal aDVSanadHa1 As DataView _
                                             , ByVal aUserID As Integer _
                                             , ByVal aUserID_Name As String _
                                             , ByVal aNoCtrlKardex As Integer _
                                             , ByRef ctSefaresheKarSn As Decimal) As String

        Dim SaveSanadToDataBase, vStayOpen As Boolean
        Dim vErrorMsg As String

        Dim ar_SanadSN(,) As Decimal
        Dim _
            vMarjaSanadSN, _
            vSanadDate, _
            vShomarehSefaresh, _
            vHavalehForooshSN, _
            vShomarehBarnameh, _
            vMojavezErsalSN, _
            vWorkOrederSN As Object
        '850612
        Dim vShomarehMashin, vNameRanandeh, vTozih As Object, vHost_Name As String
        Dim vSanadStatus, vTarakoneshSN, vTafsiliSN As Object, vNoeSanadID As Integer
        Dim vState As Short
        Dim vCommand As EnumCommands = EnumCommands.cmSave

        Dim vMarjaSanadHaSN, vKalaSN, vMeghdareVaredeh, vMeghdareSadereh, vMeghdareNakhales As Object
        Dim vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN As Object
        Dim vTedadZarf, vKalaPhizikiSN As Object
        Dim vShomarehRahgiri, vKalaPhizikiStatusDS, vWorkOrederHaSN As Object
        Dim v_UserParam As String
        Dim vSanadHaSN, vSanadSN, vInSanadSN As Decimal
        Dim i, j As Integer
        Dim vMessage As String = ""
        Dim vRetValSP As Integer = 0
        Dim vdv As DataView
        Dim vToolidDate, vEnghezaDate As Object
        Dim vTafsiliSN2 As Object

        SaveSanadToDataBase = False
        vErrorMsg = ""
        ' 1 براي عدم کنترل موجودي     کاردکس
        If aNoCtrlKardex <> 1 Then
            aNoCtrlKardex = 0
        End If
        ' کنترل اطلاعات ورودي
        If _
            ((aDVSanad.Count > 0 And aDVSanadHa.Count > 0) Or (aDVSanad1.Count > 0 And aDVSanadHa1.Count > 0)) And _
            Trim(aUserID_Name) <> "" _
            And aVahedeTejariSN <> 0 And aNoeAnbarSN <> 0 And aAnbarSN <> 0 And aUserID <> 0 Then
            vStayOpen = acn.StayOpen
            acn.StayOpen = True
            If acn.Connection.State <> ConnectionState.Open Then
                vMessage = " DarjSanad : Oppennig ConnectioLn to " & acn.SQLServerName & _
                           " Database " & acn.SQLDatabaseName
                atp.LogStr(vMessage)
                acn.OpenConnection()
            End If

            ReDim ar_SanadSN(aDVSanad.Count, 2)
            vHost_Name = System.Environment.MachineName
            Try
                acn.BeginTrans(acn.Connection.BeginTransaction())
                vMessage = String.Format(" DarjSanad : Saving {0} Sanad . " & vbCrLf, CStr(aDVSanad.Count))
                atp.LogStr(vMessage)

                For i = 0 To aDVSanad.Count - 1
                    If aDVSanad.Table.Rows(i)("SanadDate").ToString() <> "" Then
                        vSanadSN = aIdentifier
                        ' acn.Identifier
                        With aDVSanad.Table
                            vInSanadSN = .Rows(i)("SanadSN")
                            vMarjaSanadSN = .Rows(i)("MarjaSanadSN")
                            vSanadDate = .Rows(i)("SanadDate")
                            vSanadStatus = .Rows(i)("SanadStatus")
                            vTarakoneshSN = .Rows(i)("TarakoneshSN")
                            vHavalehForooshSN = .Rows(i)("HavalehForooshSN")
                            vMojavezErsalSN = .Rows(i)("MojavezErsalSN")
                            vTafsiliSN = .Rows(i)("TafsiliSN")
                            vShomarehSefaresh = .Rows(i)("ShomarehSefaresh")
                            vShomarehBarnameh = .Rows(i)("ShomarehBarnameh")
                            vShomarehMashin = .Rows(i)("ShomarehMashin")
                            vNameRanandeh = .Rows(i)("NameRanandeh")
                            vTozih = .Rows(i)("Tozih")
                            vState = EnumDataViewState.bsAdd
                            vCommand = EnumCommands.cmSave
                            vWorkOrederSN = .Rows(i)("WorkOrederSN")
                            '850612
                            vNoeSanadID = .Rows(i)("NoeSanadID")
                            '850922
                            ' کنترل اطلاعات سند
                            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                            vRetValSP = _
                                acn.CallSP("_abSPC_abSanadEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN _
                                            , vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                            , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, _
                                            System.DBNull.Value _
                                            , vShomarehSefaresh, System.DBNull.Value, vCommand, vState, vErrorMsg, vMarjaSanadSN)
                            If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                Throw New Exception("خطا در کنترل سند انبار" & vbCrLf & vErrorMsg)
                            End If

                            ' کنترل اطلاعات سند

                            ' ثبت اطلاعات سند
                            vRetValSP = _
                                cn.CallSP("_abSanadC_InsertX", vSanadSN, vSanadDate, vSanadDate, aAnbarSN, aNoeAnbarSN, _
                                           vTarakoneshSN, vTafsiliSN _
                                           , 1, vWorkOrederSN, aVahedeTejariSN, vShomarehSefaresh _
                                           , vTozih, aUserID, aUserID_Name, aUserID, aUserID_Name, aUserID_Name, _
                                           vHost_Name, vSanadDate, 2, vSanadDate)

                            ' ثبت اطلاعات سند
                            If vRetValSP <> 0 Or Val(vSanadSN) < 1 Then
                                Throw New Exception("خطا در درج سند انبار")
                            Else
                                ar_SanadSN(i, 1) = vSanadSN
                                ar_SanadSN(i, 2) = vSanadStatus
                            End If
                            vMessage = _
                                String.Format(" DarjSanad : Saving {0} SanadHa ." & vbCrLf, CStr(aDVSanadHa.Count))
                            atp.LogStr(vMessage)
                        End With

                        aDVSanadHa.RowFilter = " SanadSN =  " & vInSanadSN.ToString
                        For j = 0 To aDVSanadHa.Count - 1
                            vSanadHaSN = aIdentifier
                            'acn.Identifier
                            If aDVSanadHa.Table.Rows(j)("KalaSN").ToString() <> "" Then

                                '// بر اساس انبار و نوع انبار رويه رهگيري پر شود
                                vdv = _
                                    acn.ExecuteQuery( _
                                                      " SELECT     ISNULL(KalaPhizikiStatusSN,0) AS KalaPhizikiStatusSN FROM abAnbarKala " & _
                                                      " WHERE      AnbarSN = " & aAnbarSN.ToString & _
                                                      " AND  KalaSN = " & _
                                                      aDVSanadHa.Table.Rows(j)("KalaSN").ToString())

                                Dim KalaDS As String
                                KalaDS = _
                                    CStr( _
                                        acn.ExecuteQuery( _
                                                          "SELECT KalaNO+'-'+KalaDS FROM PaKala WHERE KalaSN = " & _
                                                          aDVSanadHa.Table.Rows(j)("KalaSN").ToString())(0).Item(0))

                                If vdv.Count = 0 Then
                                    Throw New Exception("کالاي " & KalaDS & " به کالاهاي هر انبار اضافه نشده است")
                                End If

                                vKalaPhizikiStatusDS = vdv(0)("KalaPhizikiStatusSN")
                                If vKalaPhizikiStatusDS = 0 Then
                                    Throw _
                                        New Exception( _
                                                       "رويه رهگيري کالاي " & KalaDS & _
                                                       "در اين انبار مشخص نشده است سندي نميتواند ثبت گردد")
                                End If
                                vdv.Dispose()
                                '// بر اساس انبار و نوع انبار رويه رهگيري پر شود

                                With aDVSanadHa.Table
                                    vMarjaSanadHaSN = .Rows(i)("MarjaSanadHaSN")
                                    vKalaSN = .Rows(j)("KalaSN")
                                    vMeghdareVaredeh = .Rows(j)("MeghdareVaredeh")
                                    vMeghdareSadereh = .Rows(j)("MeghdareSadereh")
                                    vMeghdareNakhales = .Rows(j)("MeghdareNakhales")
                                    vTedadZarf = .Rows(i)("TedadZarf")
                                    vNoeZayeatSN = 0
                                    '.Rows(j)("NoeZayeatSN")
                                    vNoeMarjooeiSN = 0
                                    '.Rows(j)("NoeMarjooeiSN")
                                    vNoeMadomiSN = 0
                                    '.Rows(j)("NoeMadomiSN")
                                    vKalaPhizikiSN = aIdentifier
                                    'acn.Identifie
                                    vKalaPhizikiSN = aIdentifier
                                    'acn.Identifier
                                    vShomarehRahgiri = .Rows(i)("ShomarehRahgiri")
                                    vWorkOrederHaSN = .Rows(i)("WorkOrederHaSN")
                                    '850612
                                    '  پر کردن UserParam از مقادير مربوطه
                                    v_UserParam = vKalaPhizikiSN & ";" & vShomarehRahgiri & ";" & _
                                                  vKalaPhizikiStatusDS & _
                                                  ";" & CStr(aVahedeTejariSN) & ";" & CStr(aAnbarSN) & ";" & _
                                                  CStr(aNoeAnbarSN)
                                End With
                                ' کنترل اطلاعات رديف سند
                                vState = EnumDataViewState.bsAdd
                                vCommand = EnumCommands.cmSave
                                ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                                vRetValSP = _
                                    acn.CallSP("_abSPC_abSanadHaEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, _
                                                vSanadSN, _
                                                vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                , System.DBNull.Value, System.DBNull.Value, vCommand, vState, vErrorMsg, _
                                                vKalaSN _
                                                , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                , vNoeMadomiSN, System.DBNull.Value, vShomarehRahgiri, vSanadHaSN, _
                                                vKalaPhizikiStatusDS, aNoCtrlKardex, System.DBNull.Value, _
                                                System.DBNull.Value, System.DBNull.Value)
                                If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                    Throw New Exception("خطا در کنترل رديف سند" & vbCrLf & vErrorMsg)
                                End If
                                ' کنترل اطلاعات رديف سند
                                ' ثبت اطلاعات رديف سند
                                vRetValSP = acn.CallSP("_abSanadHa_InsertX", vSanadHaSN, vSanadSN _
                                                        , vMarjaSanadHaSN, System.DBNull.Value _
                                                        , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vMeghdareVaredeh, System.DBNull.Value _
                                                        , vMeghdareSadereh, System.DBNull.Value _
                                                        , vMeghdareNakhales, vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN _
                                                        , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , vWorkOrederHaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vTedadZarf, vKalaPhizikiSN _
                                                        , System.DBNull.Value, aUserID_Name, vHost_Name, _
                                                        System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , System.DBNull.Value, v_UserParam)
                                ' ثبت اطلاعات رديف سند
                            End If
                            If vRetValSP <> 0 Or Val(vSanadHaSN) < 1 Or Trim(v_UserParam) <> "" Then
                                Throw New Exception("خطا در درج رديف سند" + " " + v_UserParam)
                            End If
                        Next j
                        ' For j = 0 To countSanadHa - 1
                    Else
                        vMessage = " DarjSanad : " & " اسناد ارسال شده خالي است "
                        atp.LogStr(vMessage)
                        vErrorMsg = " اسناد ارسال شده خالي است "
                        Throw New Exception(vErrorMsg)
                    End If
                Next i
                ' For j = 0 To aDVSanadHa.Count - 1

                '  تغيير وضعيت سند 
                For i = 0 To aDVSanad.Count - 1
                    vSanadSN = Val(ar_SanadSN(i, 1))
                    vSanadStatus = ar_SanadSN(i, 2)
                    If vSanadSN <> 0 And vSanadStatus > 1 Then
                        ' فراخواني اس پي براي تغيير وضعيت سند
                        vRetValSP = acn.CallSP("_abSPC_Change_SanadStatus", vSanadSN, vSanadStatus _
                                                , aUserID, aUserID_Name, vErrorMsg, aNoCtrlKardex)
                        If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                            Throw New Exception(" اشکال در تغيير وضعيت سند " & vbCrLf & vErrorMsg)
                        End If
                    ElseIf vSanadSN = 0 Then
                        Throw New Exception(" اشکال در تغيير وضعيت سند ")
                    End If
                Next
                '  تغيير وضعيت سند 
                SaveSanadToDataBase = True
                vMessage = " SaveSanadToDataBase = True . "
                atp.LogStr(vMessage)
            Catch ex As Exception
                vErrorMsg = ex.Message
                vMessage = " DarjSanad : " & vErrorMsg
                atp.LogStr(vMessage)
                acn.RollbackTrans()
            Finally
                acn.StayOpen = vStayOpen
                acn.CommitTrans()
            End Try


            ReDim ar_SanadSN(aDVSanad1.Count, 2)
            vHost_Name = System.Environment.MachineName
            Try
                For i = 0 To aDVSanad1.Count - 1
                    If aDVSanad1.Table.Rows(i)("SanadDate").ToString() <> "" Then
                        vSanadSN = aIdentifier
                        ' acn.Identifier
                        With aDVSanad1.Table
                            vInSanadSN = .Rows(i)("SanadSN")
                            vMarjaSanadSN = .Rows(i)("MarjaSanadSN")
                            vSanadDate = .Rows(i)("SanadDate")
                            vSanadStatus = .Rows(i)("SanadStatus")
                            vTarakoneshSN = .Rows(i)("TarakoneshSN")
                            vHavalehForooshSN = .Rows(i)("HavalehForooshSN")
                            vMojavezErsalSN = .Rows(i)("MojavezErsalSN")
                            vTafsiliSN = .Rows(i)("TafsiliSN")
                            vShomarehSefaresh = .Rows(i)("ShomarehSefaresh")
                            vShomarehBarnameh = .Rows(i)("ShomarehBarnameh")
                            vShomarehMashin = .Rows(i)("ShomarehMashin")
                            vNameRanandeh = .Rows(i)("NameRanandeh")
                            vTozih = .Rows(i)("Tozih")
                            vState = EnumDataViewState.bsAdd
                            vCommand = EnumCommands.cmSave
                            vWorkOrederSN = .Rows(i)("WorkOrederSN")
                            '850612
                            vNoeSanadID = .Rows(i)("NoeSanadID")
                            '850922
                            ' کنترل اطلاعات سند
                            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                            vRetValSP = _
                                acn.CallSP("_abSPC_abSanadEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN _
                                            , vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                            , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, _
                                            System.DBNull.Value _
                                            , vShomarehSefaresh, System.DBNull.Value, vCommand, vState, vErrorMsg, vMarjaSanadSN)
                            If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                Throw New Exception("خطا در کنترل سند انبار" & vbCrLf & vErrorMsg)
                            End If

                            ' کنترل اطلاعات سند

                            '// ثبت اطلاعات سند
                            vRetValSP = _
                                cn.CallSP("_abSanadC_InsertX", vSanadSN, vSanadDate, vSanadDate, aAnbarSN, aNoeAnbarSN, _
                                           vTarakoneshSN, vTafsiliSN _
                                           , 1, vWorkOrederSN, aVahedeTejariSN, vShomarehSefaresh _
                                           , vTozih, aUserID, aUserID_Name, aUserID, aUserID_Name, aUserID_Name, _
                                           vHost_Name, vSanadDate, 2, vSanadDate)

                            '// ثبت اطلاعات سند
                            If vRetValSP <> 0 Or Val(vSanadSN) < 1 Then
                                Throw New Exception("خطا در درج سند انبار")
                            Else
                                ar_SanadSN(i, 1) = vSanadSN
                                ar_SanadSN(i, 2) = vSanadStatus
                            End If
                            vMessage = _
                                String.Format(" DarjSanad : Saving {0} SanadHa1 ." & vbCrLf, CStr(aDVSanadHa1.Count))
                            atp.LogStr(vMessage)
                        End With

                        aDVSanadHa1.RowFilter = " SanadSN =  " & vInSanadSN.ToString
                        For j = 0 To aDVSanadHa1.Count - 1
                            vSanadHaSN = aIdentifier
                            'acn.Identifier
                            If aDVSanadHa1.Table.Rows(j)("KalaSN").ToString() <> "" Then

                                '// بر اساس انبار و نوع انبار رويه رهگيري پر شود
                                vdv = _
                                    acn.ExecuteQuery( _
                                                      " SELECT     ISNULL(KalaPhizikiStatusSN,0) AS KalaPhizikiStatusSN FROM abAnbarKala " & _
                                                      " WHERE      AnbarSN = " & aAnbarSN.ToString & _
                                                      " AND  KalaSN = " & _
                                                      aDVSanadHa1.Table.Rows(j)("KalaSN").ToString())

                                Dim KalaDS As String
                                KalaDS = _
                                    CStr( _
                                        acn.ExecuteQuery( _
                                                          "SELECT KalaNO+'-'+KalaDS FROM PaKala WHERE KalaSN = " & _
                                                          aDVSanadHa.Table.Rows(j)("KalaSN").ToString())(0).Item(0))

                                vKalaPhizikiStatusDS = vdv(0)("KalaPhizikiStatusSN")
                                If vKalaPhizikiStatusDS = 0 Then
                                    Throw _
                                        New Exception( _
                                                       "رويه رهگيري کالاي " & KalaDS & _
                                                       "در اين انبار مشخص نشده است سندي نميتواند ثبت گردد")
                                End If
                                vdv.Dispose()
                                '// بر اساس انبار و نوع انبار رويه رهگيري پر شود

                                With aDVSanadHa1.Table
                                    vMarjaSanadHaSN = .Rows(i)("MarjaSanadHaSN")
                                    vKalaSN = .Rows(j)("KalaSN")
                                    vMeghdareVaredeh = .Rows(j)("MeghdareVaredeh")
                                    vMeghdareSadereh = .Rows(j)("MeghdareSadereh")
                                    vMeghdareNakhales = .Rows(j)("MeghdareNakhales")
                                    vTedadZarf = .Rows(i)("TedadZarf")
                                    vNoeZayeatSN = 0
                                    '.Rows(j)("NoeZayeatSN")
                                    vNoeMarjooeiSN = 0
                                    '.Rows(j)("NoeMarjooeiSN")
                                    vNoeMadomiSN = 0
                                    '.Rows(j)("NoeMadomiSN")
                                    vKalaPhizikiSN = aIdentifier
                                    'acn.Identifier
                                    vShomarehRahgiri = .Rows(i)("ShomarehRahgiri")
                                    vWorkOrederHaSN = .Rows(i)("WorkOrederHaSN")
                                    '850612
                                    '  پر کردن UserParam از مقادير مربوطه
                                    v_UserParam = vKalaPhizikiSN & ";" & vShomarehRahgiri & ";" & _
                                                  vKalaPhizikiStatusDS & _
                                                  ";" & CStr(aVahedeTejariSN) & ";" & CStr(aAnbarSN) & ";" & _
                                                  CStr(aNoeAnbarSN)
                                End With
                                ' کنترل اطلاعات رديف سند
                                vState = EnumDataViewState.bsAdd
                                vCommand = EnumCommands.cmSave
                                ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                                vRetValSP = _
                                    acn.CallSP("_abSPC_abSanadHaEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, _
                                                vSanadSN, _
                                                vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                , System.DBNull.Value, System.DBNull.Value, vCommand, vState, vErrorMsg, _
                                                vKalaSN _
                                                , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                , vNoeMadomiSN, System.DBNull.Value, vShomarehRahgiri, vSanadHaSN, _
                                                vKalaPhizikiStatusDS, aNoCtrlKardex, System.DBNull.Value, _
                                                System.DBNull.Value, System.DBNull.Value)
                                If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                    Throw New Exception("خطا در کنترل رديف سند" & vbCrLf & vErrorMsg)
                                End If
                                ' کنترل اطلاعات رديف سند
                                ' ثبت اطلاعات رديف سند
                                vRetValSP = acn.CallSP("_abSanadHa_InsertX", vSanadHaSN, vSanadSN _
                                                        , vMarjaSanadHaSN, System.DBNull.Value _
                                                        , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vMeghdareVaredeh, System.DBNull.Value _
                                                        , vMeghdareSadereh, System.DBNull.Value _
                                                        , vMeghdareNakhales, vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN _
                                                        , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , vWorkOrederHaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vTedadZarf, vKalaPhizikiSN _
                                                        , System.DBNull.Value, aUserID_Name, vHost_Name, _
                                                        System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , System.DBNull.Value, v_UserParam)
                                ' ثبت اطلاعات رديف سند
                            End If
                            If vRetValSP <> 0 Or Val(vSanadHaSN) < 1 Or Trim(v_UserParam) <> "" Then
                                Throw New Exception("خطا در درج رديف سند" + " " + v_UserParam)
                            End If
                        Next j
                        ' For j = 0 To countSanadHa - 1
                    Else
                        vMessage = " DarjSanad : " & " اسناد ارسال شده خالي است "
                        atp.LogStr(vMessage)
                        vErrorMsg = " اسناد ارسال شده خالي است "
                        Throw New Exception(vErrorMsg)
                    End If
                Next i
                ' For j = 0 To aDVSanadHa1.Count - 1

                '  تغيير وضعيت سند 
                For i = 0 To aDVSanad1.Count - 1
                    vSanadSN = Val(ar_SanadSN(i, 1))
                    vSanadStatus = ar_SanadSN(i, 2)
                    If vSanadSN <> 0 And vSanadStatus > 1 Then
                        ' فراخواني اس پي براي تغيير وضعيت سند
                        vRetValSP = acn.CallSP("_abSPC_Change_SanadStatus", vSanadSN, vSanadStatus _
                                                , aUserID, aUserID_Name, vErrorMsg, aNoCtrlKardex)
                        If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                            Throw New Exception(" اشکال در تغيير وضعيت سند " & vbCrLf & vErrorMsg)
                        End If
                    ElseIf vSanadSN = 0 Then
                        Throw New Exception(" اشکال در تغيير وضعيت سند ")
                    End If
                Next
                '  تغيير وضعيت سند 
                vRetValSP = cn.CallSP("ctUpdateGhateeSefareskKar", ctSefaresheKarSn)

                SaveSanadToDataBase = True
                vMessage = " SaveSanadToDataBase = True . "
                atp.LogStr(vMessage)
            Catch ex As Exception
                vErrorMsg = ex.Message
                vMessage = " DarjSanad : " & vErrorMsg
                atp.LogStr(vMessage)
                acn.RollbackTrans()
            Finally
                acn.StayOpen = vStayOpen
                acn.CommitTrans()
            End Try

        Else
            vMessage = " DarjSanad : " & " بسته ارسالي خالي است"
            atp.LogStr(vMessage)
            vErrorMsg = " بسته ارسالي خالي است"
        End If


        If SaveSanadToDataBase Then
            Return ""
        Else
            Return vErrorMsg
        End If
    End Function

    Public Shared Function DarjSanadForMhsoul(ByVal acn As NetSql.DB.CConnection _
                                               , ByVal atp As NetSql.Common.CSystem _
                                               , ByVal aVahedeTejariSN As Decimal _
                                               , ByVal aAnbarSN As Decimal _
                                               , ByVal aNoeAnbarSN As Decimal _
                                               , ByVal aIdentifier As Decimal _
                                               , ByVal aDVSanad As DataView _
                                               , ByVal aDVSanadHa As DataView _
                                               , ByVal aUserID As Integer _
                                               , ByVal aUserID_Name As String _
                                               , ByVal aNoCtrlKardex As Integer _
                                               ) As String
        '1  acn :  Connection مورد استفاده در درج سند انبار
        '2 atp : CSystem  سيستم استفاده کنند از سرويس
        '3 aVahedeTejariSN : کليد اوليه واحد تجاري
        '4 aAnbarSN کليد اوليه انبار
        '5 aNoeAnbarSN : کليد اوليه نوع انبار
        '6                               aDVSanad   ديتا ويو عنوان سند
        '  SanadSN , SanadDate, SanadStatus, TarakoneshSN, HavalehForooshSN, TafsiliSN
        ', ShomarehSefaresh , ShomarehBarnameh , ShomarehMashin , NameRanandeh , Tozih , MojavezErsalSN, WorkOrederSN

        '7                               aDVSanadHa  ديتا ويو اقلام سند
        '  SanadSN , KalaSN , MeghdareVaredeh, MeghdareSadereh, MeghdareNakhales, TedadZarf
        ', NoeZayeatSN , NoeMarjooeiSN , NoeMadomiSN , ShomarehRahgiri , WorkOrederHaSN
        '8 aUserID : کد کاربر
        '9 aUserID_Name : کد + نام کاربر
        '10 aNoCtrlKardex در صورت عدد يک کنترل موجودي نميشود 
        'Return  خروجي سرويس پيغام خطاي احتمالي است

        Dim SaveSanadToDataBase, vStayOpen As Boolean
        Dim vErrorMsg As String

        Dim ar_SanadSN(,) As Decimal
        Dim _
            vMarjaSanadSN, _
            vSanadDate, _
            vShomarehSefaresh, _
            vHavalehForooshSN, _
            vShomarehBarnameh, _
            vMojavezErsalSN, _
            vWorkOrederSN As Object
        '850612
        Dim vShomarehMashin, vNameRanandeh, vTozih As Object, vHost_Name As String
        Dim vSanadStatus, vTarakoneshSN, vTafsiliSN As Object, vNoeSanadID As Integer
        Dim vState As Short
        Dim vCommand As EnumCommands = EnumCommands.cmSave
        Dim vSanadNo As String
        Dim vMarjaSanadHaSN, vKalaSN, vMeghdareVaredeh, vMeghdareSadereh, vMeghdareNakhales As Object
        Dim vNoeZayeatSN, vNoeMarjooeiSN, vNoeMadomiSN As Object
        Dim vTedadZarf, vKalaPhizikiSN As Object
        Dim vShomarehRahgiri, vKalaPhizikiStatusDS, vWorkOrederHaSN As Object
        Dim v_UserParam As String
        Dim vSanadHaSN, vSanadSN, vInSanadSN As Decimal
        Dim i, j As Integer
        Dim vMessage As String = ""
        Dim vRetValSP As Integer = 0
        Dim vdv As DataView
        Dim vToolidDate, vEnghezaDate As Object
        Dim vTafsiliSN2 As Object

        SaveSanadToDataBase = False
        vErrorMsg = ""
        ' 1 براي عدم کنترل موجودي     کاردکس
        If aNoCtrlKardex <> 1 Then
            aNoCtrlKardex = 0
        End If
        ' کنترل اطلاعات ورودي
        If aDVSanad.Count > 0 And aDVSanadHa.Count > 0 And Trim(aUserID_Name) <> "" _
           And aVahedeTejariSN <> 0 And aNoeAnbarSN <> 0 And aAnbarSN <> 0 And aUserID <> 0 Then
            vStayOpen = acn.StayOpen
            acn.StayOpen = True
            If acn.Connection.State <> ConnectionState.Open Then
                vMessage = " DarjSanad : Oppennig ConnectioLn to " & acn.SQLServerName & _
                           " Database " & acn.SQLDatabaseName
                atp.LogStr(vMessage)
                acn.OpenConnection()
            End If
            ReDim ar_SanadSN(aDVSanad.Count, 2)
            vHost_Name = System.Environment.MachineName
            Try
                acn.BeginTrans(acn.Connection.BeginTransaction())
                vMessage = String.Format(" DarjSanad : Saving {0} Sanad . " & vbCrLf, CStr(aDVSanad.Count))
                atp.LogStr(vMessage)
                For i = 0 To aDVSanad.Count - 1
                    If aDVSanad.Table.Rows(i)("SanadDate").ToString() <> "" Then
                        vSanadSN = aIdentifier
                        ' acn.Identifier
                        With aDVSanad.Table
                            vInSanadSN = .Rows(i)("SanadSN")
                            vMarjaSanadSN = .Rows(i)("MarjaSanadSN")
                            vSanadDate = .Rows(i)("SanadDate")
                            vSanadStatus = .Rows(i)("SanadStatus")
                            vTarakoneshSN = .Rows(i)("TarakoneshSN")
                            vHavalehForooshSN = System.DBNull.Value
                            ''.Rows(i)("HavalehForooshSN")
                            vMojavezErsalSN = System.DBNull.Value
                            vTafsiliSN = .Rows(i)("TafsiliSN")
                            vShomarehSefaresh = .Rows(i)("ShomarehSefaresh")
                            vShomarehBarnameh = System.DBNull.Value
                            ''.Rows(i)("ShomarehBarnameh")
                            vShomarehMashin = System.DBNull.Value
                            ''.Rows(i)("ShomarehMashin")
                            vNameRanandeh = System.DBNull.Value
                            ''.Rows(i)("NameRanandeh")
                            vTozih = .Rows(i)("Tozih")
                            vState = EnumDataViewState.bsAdd
                            vCommand = EnumCommands.cmSave
                            'vShomarehRahgiri = .Rows(j)("ShomarehSefaresh")
                            vWorkOrederSN = .Rows(i)("WorkOrederSN")
                            '850612
                            ''vNoeSanadID = .Rows(i)("NoeSanadID") '850922
                            ' کنترل اطلاعات سند
                            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                            vRetValSP = _
                                acn.CallSP("_abSPC_abSanadEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, vSanadSN _
                                            , vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                            , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, _
                                            System.DBNull.Value _
                                            , vShomarehSefaresh, System.DBNull.Value, vCommand, vState, vErrorMsg, vMarjaSanadSN)
                            If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                Throw New Exception("خطا در کنترل سند انبار" & vbCrLf & vErrorMsg)
                            End If

                            ' کنترل اطلاعات سند

                            ' ثبت اطلاعات سند
                            vRetValSP = _
                                cn.CallSP("_abSanadC_InsertX", vSanadSN, vSanadDate, vSanadDate, aAnbarSN, aNoeAnbarSN, _
                                           vTarakoneshSN, vTafsiliSN _
                                           , 1, vWorkOrederSN, aVahedeTejariSN, vShomarehSefaresh _
                                           , vTozih, aUserID, aUserID_Name, aUserID, aUserID_Name, aUserID_Name, _
                                           vHost_Name, vSanadDate, 2, vSanadDate)
                            ' ثبت اطلاعات سند
                            If vRetValSP <> 0 Or Val(vSanadSN) < 1 Then
                                Throw New Exception("خطا در درج سند انبار")
                            Else
                                ar_SanadSN(i, 1) = vSanadSN
                                ar_SanadSN(i, 2) = vSanadStatus
                            End If
                            vMessage = _
                                String.Format(" DarjSanad : Saving {0} SanadHa ." & vbCrLf, CStr(aDVSanadHa.Count))
                            atp.LogStr(vMessage)
                        End With

                        aDVSanadHa.RowFilter = " SanadSN =  " & vInSanadSN.ToString
                        For j = 0 To aDVSanadHa.Count - 1
                            vSanadHaSN = aIdentifier
                            'acn.Identifier
                            If aDVSanadHa.Table.Rows(j)("KalaSN").ToString() <> "" Then

                                '// بر اساس انبار و کال رويه رهگيري پر شود
                                vdv = _
                                    acn.ExecuteQuery( _
                                                      " SELECT ISNULL(KalaPhizikiStatusSN,0) AS KalaPhizikiStatusSN FROM abAnbarKala " & _
                                                      "  WHERE   AnbarSN = " & aAnbarSN.ToString & _
                                                      " AND  KalaSN = " & _
                                                      aDVSanadHa.Table.Rows(j)("KalaSN").ToString())
                                vKalaPhizikiStatusDS = vdv(0)("KalaPhizikiStatusSN")
                                If vKalaPhizikiStatusDS = 0 Then
                                    Throw _
                                        New Exception( _
                                                       "رويه رهگيري کالا در اين انبار مشخص نشده است سندي نميتواند ثبت گردد")
                                End If
                                vdv.Dispose()
                                '// بر اساس انبار و کال رويه رهگيري پر شود

                                With aDVSanadHa.Table
                                    vMarjaSanadHaSN = System.DBNull.Value
                                    '' .Rows(j)("MarjaSanadHaSN")
                                    vKalaSN = .Rows(j)("KalaSN")
                                    vMeghdareVaredeh = _
                                        IIf(.Rows(j)("MeghdareVaredeh") = 0, DBNull.Value, _
                                             .Rows(j)("MeghdareVaredeh"))
                                    vMeghdareSadereh = System.DBNull.Value
                                    ''
                                    vMeghdareNakhales = System.DBNull.Value
                                    ''.Rows(j)("MeghdareNakhales")
                                    'vTedadZarf = .Rows(i)("TedadZarf")
                                    vNoeZayeatSN = System.DBNull.Value
                                    ''.Rows(j)("NoeZayeatSN")
                                    vNoeMarjooeiSN = System.DBNull.Value
                                    ''.Rows(j)("NoeMarjooeiSN")
                                    vNoeMadomiSN = System.DBNull.Value
                                    ''.Rows(j)("NoeMadomiSN")
                                    vKalaPhizikiSN = aIdentifier
                                    'aIdentifier ''
                                    vShomarehRahgiri = .Rows(j)("ShomarehRahgiri")
                                    vWorkOrederHaSN = .Rows(j)("WorkOrederHaSN")
                                    '850612
                                    vToolidDate = System.DBNull.Value
                                    ''.Rows(j)("ToolidDate")
                                    vEnghezaDate = System.DBNull.Value
                                    ''.Rows(j)("EnghezaDate")

                                    '  پر کردن UserParam از مقادير مربوطه
                                    v_UserParam = IIf(vTarakoneshSN = 39, gSM.Identifier, vKalaPhizikiSN) & ";" & _
                                                  vShomarehRahgiri & ";" & _
                                                  vKalaPhizikiStatusDS & _
                                                  ";" & CStr(aVahedeTejariSN) & ";" & CStr(aAnbarSN) & ";" & _
                                                  CStr(aNoeAnbarSN)
                                End With
                                ' کنترل اطلاعات رديف سند
                                vState = EnumDataViewState.bsAdd
                                vCommand = EnumCommands.cmSave
                                ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                                vRetValSP = _
                                    acn.CallSP("_abSPC_abSanadHaEnter", aVahedeTejariSN, aAnbarSN, aNoeAnbarSN, _
                                                vSanadSN, _
                                                vSanadDate, vSanadStatus, System.DBNull.Value, vTarakoneshSN, vTafsiliSN _
                                                , System.DBNull.Value, System.DBNull.Value, vCommand, vState, vErrorMsg, _
                                                vKalaSN _
                                                , vMeghdareVaredeh, vMeghdareSadereh, vNoeZayeatSN, vNoeMarjooeiSN _
                                                , vNoeMadomiSN, IIf(vTarakoneshSN = 39, vKalaPhizikiSN, DBNull.Value), _
                                                vShomarehRahgiri, vSanadHaSN, vKalaPhizikiStatusDS, aNoCtrlKardex, _
                                                vTafsiliSN2, System.DBNull.Value, System.DBNull.Value)
                                If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                                    Throw New Exception("خطا در کنترل رديف سند" & vbCrLf & vErrorMsg)
                                End If
                                ' کنترل اطلاعات رديف سند
                                ' ثبت اطلاعات رديف سند
                                vRetValSP = acn.CallSP("_abSanadHa_InsertX", vSanadHaSN, vSanadSN _
                                                        , System.DBNull.Value, System.DBNull.Value _
                                                        , vKalaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vMeghdareVaredeh, System.DBNull.Value _
                                                        , vMeghdareSadereh, System.DBNull.Value _
                                                        , vMeghdareNakhales, DBNull.Value, DBNull.Value, DBNull.Value _
                                                        , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                                                        , vWorkOrederHaSN, System.DBNull.Value, System.DBNull.Value _
                                                        , vTedadZarf, _
                                                        IIf(vTarakoneshSN = 39, gSM.Identifier, vKalaPhizikiSN) _
                                                        , System.DBNull.Value, aUserID_Name, vHost_Name, _
                                                        System.DBNull.Value, vToolidDate, vEnghezaDate _
                                                        , System.DBNull.Value, v_UserParam)
                                ' ثبت اطلاعات رديف سند
                            End If
                            If vRetValSP <> 0 Or Val(vSanadHaSN) < 1 Or Trim(v_UserParam) <> "" Then
                                Throw New Exception("خطا در درج رديف سند" + " " + v_UserParam)
                            End If
                        Next j
                        ' For j = 0 To countSanadHa - 1
                    Else
                        vMessage = " DarjSanad : " & " اسناد ارسال شده خالي است "
                        atp.LogStr(vMessage)
                        vErrorMsg = " اسناد ارسال شده خالي است "
                        Throw New Exception(vErrorMsg)
                    End If
                Next i
                ' For j = 0 To aDVSanadHa.Count - 1

                '  تغيير وضعيت سند 
                For i = 0 To aDVSanad.Count - 1
                    vSanadSN = Val(ar_SanadSN(i, 1))
                    vSanadStatus = ar_SanadSN(i, 2)
                    If vSanadSN <> 0 And vSanadStatus > 1 Then
                        ' فراخواني اس پي براي تغيير وضعيت سند
                        vRetValSP = acn.CallSP("_abSPC_Change_SanadStatus", vSanadSN, 8 _
                                                , aUserID, aUserID_Name, vErrorMsg, aNoCtrlKardex)
                        If vRetValSP <> 0 And Trim(vErrorMsg) <> "" Then
                            Throw New Exception(" اشکال در تغيير وضعيت سند " & vbCrLf & vErrorMsg)
                        End If
                    ElseIf vSanadSN = 0 Then
                        Throw New Exception(" اشکال در تغيير وضعيت سند ")
                    End If
                Next
                '  تغيير وضعيت سند 
                SaveSanadToDataBase = True
                vMessage = " SaveSanadToDataBase = True . "
                atp.LogStr(vMessage)
            Catch ex As Exception
                vErrorMsg = ex.Message
                vMessage = " DarjSanad : " & vErrorMsg
                atp.LogStr(vMessage)
                acn.RollbackTrans()
            Finally
                acn.StayOpen = vStayOpen
                acn.CommitTrans()
            End Try
        Else
            vMessage = " DarjSanad : " & " بسته ارسالي خالي است"
            atp.LogStr(vMessage)
            vErrorMsg = " بسته ارسالي خالي است"
        End If
        If SaveSanadToDataBase Then
            Return ""
        Else
            Return vErrorMsg
        End If

    End Function

End Class