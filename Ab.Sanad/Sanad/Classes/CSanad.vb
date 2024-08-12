'  OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/03/07
'ModifiedDate::
'Description::  کلاس سند براي مؤلفه  سند سيستم انبار 
'System ::انبار

Option Strict Off
Option Explicit On

Imports Minoo.Services.Middleware
Imports Minoo.Models.Middleware
Imports Anbar.BRL
Imports System.Data.SqlClient

Public Class CSanad
    Friend Shared gMDIParent As Form

#Region "Class_Sanad"

    Public Sub New(ByVal atp As NetSql.Common.CSystem _
                    , ByVal acn As NetSql.DB.CConnection _
                    , ByVal agSM As Minoo.SecurityManager.FTSecurityManager _
                    , ByVal aSNFieldOption As EnumFieldOptions _
                    , ByVal aVahedeTejariSN As Decimal _
                    , ByVal aVahedeTejariDS As String _
                    , ByVal aVahedeTejariNO As Decimal _
                    , ByVal aAnbarSN As Decimal _
                    , ByVal aAnbarDS As String _
                    , ByVal aAnbarNO As Decimal _
                    , ByVal aNoeAnbarSN As Decimal _
                    , ByVal aIsTajmie As Short _
                    , ByVal aMDIParent As Form)

        tp = atp
        cn = acn
        gSM = agSM
        gSNFieldOption = aSNFieldOption
        gMDIParent = aMDIParent

        gAnbarSN = aAnbarSN
        gAnbarDS = aAnbarDS
        gAnbarNO = aAnbarNO
        gNoeAnbarSN = aNoeAnbarSN
        gVahedeTejariSN = aVahedeTejariSN
        gVahedeTejariDs = aVahedeTejariDS
        gVahedeTejariNO = aVahedeTejariNO
        'gKalaPhizikiStatusSN = aKalaPhizikiStatusSN
        'gRahgiriAuto = aRahgiriAuto
        'gRahgiriMeghdar = aRahgiriMeghdar
        gIsTajmie = aIsTajmie

    End Sub

    Public Sub New(ByVal atp As NetSql.Common.CSystem _
                    , ByVal acn As NetSql.DB.CConnection _
                    , ByVal agSM As Minoo.SecurityManager.FTSecurityManager _
                    , ByVal aSNFieldOption As EnumFieldOptions _
                    , ByVal aVahedeTejariSN As Decimal _
                    , ByVal aMDIParent As Form)

        tp = atp
        cn = acn
        gSM = agSM
        gSNFieldOption = aSNFieldOption
        gMDIParent = aMDIParent
        gVahedeTejariSN = aVahedeTejariSN
        If gVahedeTejariSN = 0 Then
            NetSql.Common.CSystem.MsgBox("مشکل در نمايش سند  با مدير سيستم تماس بگيريد")
            Finalize()
        End If
    End Sub


    Protected Overrides Sub Finalize()
        'gSNFieldOption = Nothing
        'gVahedeTejariSN = Nothing
        'gVahedeTejariDs = Nothing
        MyBase.Finalize()
    End Sub

#End Region

#Region "Methods"

    Public Shared Sub ShowDarkhast(ByVal aMDIParent As Form)
        ' نمايش فرم درخواست از انبار
        With FrmabDarkhast.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub


    '--------------------- yekta 930722 ---------------------------------------------
    Public Shared Sub ShowTafkik(ByVal aMDIParent As Form, ByVal _typeghazaDaroo As Integer)
        ' نمايش فرم لیست تفکیک
        With FrmabTafkik.DefInstance
            .MdiParent = aMDIParent
            .TypeghazaDaroo = _typeghazaDaroo
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    'Dehghani 960211
    Public Shared Sub ShowTafkikDarooei(ByVal aMDIParent As Form)
        ' نمايش فرم لیست تفکیک
        With FrmabTafkik_New.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    '--------------------- yekta 930722 ---------------------------------------------

    Public Shared Sub ShowDarkhastKharidDakheli(ByVal aMDIParent As Form)
        ' نمايش فرم درخواست خرید داخلی
        'With 
        '.gAnbarSn = gAnbarSN
        '.MdiParent = aMDIParent
        TadarekatDakheli.Common.COFacade.FormatedgHesabdariSalFDate = _
            NetSql.Common.CShamsiDate.FormatDate(gHesabdariSalFDate, EnumDateFormat.dfWithSlash)
        TadarekatDakheli.Common.COFacade.FormatedgHesabdariSalTDate = _
            NetSql.Common.CShamsiDate.FormatDate(gHesabdariSalTDate, EnumDateFormat.dfWithSlash)
        TadarekatDakheli.Common.COFacade.HesabdariSalFDate = gHesabdariSalFDate
        TadarekatDakheli.Common.COFacade.HesabdariSalTDate = gHesabdariSalTDate

        TadarekatDakheli.Forms.UIFacade.OpenDarkhastDakheli(gAnbarSN, aMDIParent)


        '.Show()
        '.Activate()
        '.WindowState = System.Windows.Forms.FormWindowState.Normal
        DBLog.WriteLOG("Form", 0, , "frmarkhastDakheli", "فرم درخواست داخلی")
        'End With
    End Sub

    Public Shared Sub ShowDarkhastKharidkhareji(ByVal aMDIParent As Form)
        ' نمايش فرم درخواست خرید داخلی
        'With 
        '.gAnbarSn = gAnbarSN
        '.MdiParent = aMDIParent
        TadarekatDakheli.Common.COFacade.FormatedgHesabdariSalFDate = _
            NetSql.Common.CShamsiDate.FormatDate(gHesabdariSalFDate, EnumDateFormat.dfWithSlash)
        TadarekatDakheli.Common.COFacade.FormatedgHesabdariSalTDate = _
            NetSql.Common.CShamsiDate.FormatDate(gHesabdariSalTDate, EnumDateFormat.dfWithSlash)
        TadarekatDakheli.Common.COFacade.HesabdariSalFDate = gHesabdariSalFDate
        TadarekatDakheli.Common.COFacade.HesabdariSalTDate = gHesabdariSalTDate

        TadarekatDakheli.Forms.UIFacade.OpenDarkhastKhareji(gAnbarSN, aMDIParent)


        '.Show()
        '.Activate()
        '.WindowState = System.Windows.Forms.FormWindowState.Normal
        DBLog.WriteLOG("Form", 0, , "frmarkhastDakheli", "فرم درخواست خارجی")
        'End With
    End Sub

    Public Shared Sub ShowBarnameh(ByVal aMDIParent As Form)
        ' نمايش فرم بارنامه
        With FrmBarnameh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    ''ghasemi
    Public Shared Sub ShowTaghirNerkhAvaldore(ByVal aMDIParent As Form)
        ' نمايش فرم تغییر نرخ اول دوره
        With FrmTaghirNerkhAvaldore.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    ''ghasemi

    Public Shared Sub ShowEslahSanad(ByVal aMDIParent As Form)
        ' نمايش فرم اصلاحيه طرف حساب
        With FrmEslahSanad.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowEslahSanadKharid(ByVal aMDIParent As Form)
        '  نمايش فرم اصلاحيه طرف حساب خرید
        With FrmabEslahSanadKharid.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowImportFromExcel(ByVal aMDIParent As Form)
        ' نمايش فرم ثبت سند از طریق فایل اکسل
        With FrmImportFromExcel.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Sub ShowAsnadOld(ByVal aNoeTarakoneshSN As EnumNoeTarakoneshSN, ByVal aNoeAccessRight As String _
                             , Optional ByVal aSanadSN As Decimal = 0)
        ' aNoeTarakoneshSN    نوع نمايش فرم برابر انواع تعريف شده
        ' aNoeAccessRight کليد دسترسي ارسال ميگردد که در اي پي پي اس اس تعريف شده است
        ' aSanadSN اگر پر باشد فقط سند مورد نظر نمايش داده ميشود
        ' با توجه به پارامترهاي ارسالي فرم مورد نظر نمايش داده ميشود جهت نمايش اسناد
        Dim vForm As System.Windows.Forms.Form
        Dim vfrmAsnad As New FrmSanad
        ' آيا قبلا در حافظه فعال است    اگر بلي آنرا نمايش دهد
        For Each vForm In gMDIParent.MdiChildren
            If vForm.Name = vfrmAsnad.Name Then
                If CType(vForm, FrmSanad).NoeTarakoneshSN = aNoeTarakoneshSN Then
                    vForm.Activate()
                    Exit Sub
                End If
            End If
        Next vForm
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ' در صورتيکه سيستم ديگري غير از انبار نمايش فرم را خواست دسترسي رويت گردد
        If gSM.ApplicationID <> 5 Then
            aNoeAccessRight = ""
        End If
        With vfrmAsnad
            .MdiParent = gMDIParent
            .NoeAccessRight = aNoeAccessRight
            .NoeTarakoneshSN = aNoeTarakoneshSN
            .SanadSN = aSanadSN
            .StartPosition = FormStartPosition.CenterParent
            .Show()
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub ShowAsnad(ByVal aNoeTarakoneshSN As EnumNoeTarakoneshSN, ByVal aNoeAccessRight As String _
                          , Optional ByVal aSanadSN As Decimal = 0)
        ' aNoeTarakoneshSN    نوع نمايش فرم برابر انواع تعريف شده
        ' aNoeAccessRight کليد دسترسي ارسال ميگردد که در اي پي پي اس اس تعريف شده است
        ' aSanadSN اگر پر باشد فقط سند مورد نظر نمايش داده ميشود
        ' با توجه به پارامترهاي ارسالي فرم مورد نظر نمايش داده ميشود جهت نمايش اسناد
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ' در صورتيکه سيستم ديگري غير از انبار نمايش فرم را خواست دسترسي رويت گردد
        If gSM.ApplicationID <> 5 Then
            aNoeAccessRight = ""
        End If
        With FrmSanad.DefInstance(aNoeTarakoneshSN)
            .MdiParent = gMDIParent
            .NoeAccessRight = aNoeAccessRight
            .NoeTarakoneshSN = aNoeTarakoneshSN
            .SanadSN = aSanadSN
            .StartPosition = FormStartPosition.CenterParent
            .Show()
            .Focus()
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
    ''ghasemi 14010307
    Public Sub ShowTaghirNerkhAvaldore(ByVal aNoeTarakoneshSN As EnumNoeTarakoneshSN, ByVal aNoeAccessRight As String _
                          , Optional ByVal aSanadSN As Decimal = 0)
        ' aNoeTarakoneshSN    نوع نمايش فرم برابر انواع تعريف شده
        ' aNoeAccessRight کليد دسترسي ارسال ميگردد که در اي پي پي اس اس تعريف شده است
        ' aSanadSN اگر پر باشد فقط سند مورد نظر نمايش داده ميشود
        ' با توجه به پارامترهاي ارسالي فرم مورد نظر نمايش داده ميشود جهت نمايش اسناد
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ' در صورتيکه سيستم ديگري غير از انبار نمايش فرم را خواست دسترسي رويت گردد
        If gSM.ApplicationID <> 5 Then
            aNoeAccessRight = ""
        End If
        With FrmSanad.DefInstance(aNoeTarakoneshSN)
            .MdiParent = gMDIParent
            .NoeAccessRight = aNoeAccessRight
            .NoeTarakoneshSN = aNoeTarakoneshSN
            .SanadSN = aSanadSN
            .StartPosition = FormStartPosition.CenterParent
            .Show()
            .Focus()
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
    ''ghasemi 14010307

    'Add By Yekta 920924
    Public Sub EslaheAsnad(ByVal aNoeTarakoneshSN As EnumNoeTarakoneshSN, ByVal aNoeAccessRight As String _
                          , Optional ByVal aSanadSN As Decimal = 0)
        ' aNoeTarakoneshSN    نوع نمايش فرم برابر انواع تعريف شده
        ' aNoeAccessRight کليد دسترسي ارسال ميگردد که در اي پي پي اس اس تعريف شده است
        ' aSanadSN اگر پر باشد فقط سند مورد نظر نمايش داده ميشود
        ' با توجه به پارامترهاي ارسالي فرم مورد نظر نمايش داده ميشود جهت نمايش اسناد
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ' در صورتيکه سيستم ديگري غير از انبار نمايش فرم را خواست دسترسي رويت گردد
        If gSM.ApplicationID <> 5 Then
            aNoeAccessRight = ""
        End If
        With FrmEslaheSanad.DefInstance(aNoeTarakoneshSN)
            .MdiParent = gMDIParent
            .NoeAccessRight = aNoeAccessRight
            .NoeTarakoneshSN = aNoeTarakoneshSN
            .SanadSN = aSanadSN
            .StartPosition = FormStartPosition.CenterParent
            .Show()
            .Focus()
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub ShowSanad(ByVal aSanadSN As Decimal, Optional ByVal aNoeAccessRight As String = "")
        ' با توجه به پارامترهاي ارسالي سند مورد نظر نمايش داده ميشود جهت نمايش سند خاص

        ' aSanadSN اگر پر باشد فقط سند مورد نظر نمايش داده ميشود
        ' aNoeAccessRight کليد دسترسي ارسال ميگردد که در اي پي پي اس اس تعريف شده است

        Dim vAnbarSN As Decimal
        Dim vAnbarNO As String
        Dim vAnbarDS As String
        Dim vNoeAnbarSN As Decimal
        Dim vIdentifier As Decimal
        Dim vVahedeTejariSN As Decimal
        Dim vVahedeTejariNO As String
        'Dim vKalaPhizikiStatusSN As Decimal
        'Dim vAuto As Integer
        'Dim vMeghdar As Integer
        Dim vIsTajmie As Integer
        Dim vTarakoneshSN As EnumTarakoneshSN

        Dim aNoeTarakoneshSN As EnumNoeTarakoneshSN

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ' بدست آوردن اطلاعات سند
        cn.CallSP("_abSpGSanadInfo", aSanadSN, vAnbarSN, vAnbarNO, vAnbarDS, vNoeAnbarSN _
                   , vIdentifier, vVahedeTejariSN, vVahedeTejariNO _
                   , vIsTajmie, vTarakoneshSN)
        gAnbarSN = vAnbarSN
        gAnbarDS = vAnbarDS
        gAnbarNO = vAnbarNO
        gNoeAnbarSN = vNoeAnbarSN
        gVahedeTejariSN = vVahedeTejariSN
        gVahedeTejariNO = vVahedeTejariNO
        'gKalaPhizikiStatusSN = vKalaPhizikiStatusSN
        'gRahgiriAuto = vAuto
        'gRahgiriMeghdar = vMeghdar
        gIsTajmie = vIsTajmie
        ' بدست آوردن نوع نمايش سند
        If vTarakoneshSN = EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH Then
            aNoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
        ElseIf vTarakoneshSN = EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH Then
            aNoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
        ElseIf vTarakoneshSN = EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH Then
            aNoeTarakoneshSN = EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
        ElseIf vTarakoneshSN >= 1 And vTarakoneshSN < 60 Then
            aNoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA
        ElseIf vTarakoneshSN >= 61 Then
            aNoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA
        Else
            aNoeTarakoneshSN = 0
        End If

        If gSM.ApplicationID <> 5 Then
            aNoeAccessRight = ""
        End If

        Dim vForm As System.Windows.Forms.Form
        Dim vfrmAsnad As New FrmSanad
        ' آيا قبلا در حافظه فعال است    اگر بلي آنرا نمايش دهد
        For Each vForm In gMDIParent.MdiChildren
            If vForm.Name = vfrmAsnad.Name Then
                If CType(vForm, FrmSanad).NoeTarakoneshSN = aNoeTarakoneshSN Then
                    vForm.Activate()
                    Exit Sub
                End If
            End If
        Next vForm
        With vfrmAsnad
            .NoeAccessRight = aNoeAccessRight
            .NoeTarakoneshSN = aNoeTarakoneshSN
            .SanadSN = aSanadSN
            .StartPosition = FormStartPosition.CenterParent
            If gMDIParent Is Nothing Then
                .ShowDialog()
            ElseIf gMDIParent.IsMdiContainer Then
                .MdiParent = gMDIParent
                .Show()
            Else
                .ShowDialog(gMDIParent)
            End If
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Public Shared Function GetTaraKoneshGoroohTafsiliSN(ByVal aTarakoneshSN As Decimal _
                                                         , ByVal aNoeAnbarSN As Decimal _
                                                         , ByVal atblWhereCol As String) As String
        '                     از آنجا که هر کدام از تراکنشهاي انبار نوعي   
        '  ارتباط با گروه هاي تفصيلي مالي دارند و در کامبو طرف حساب انبار بايد تفصيلي هاي  مالي را نمايش داد
        ' براي بدست آوردن شرط کامبو در مورد طرف حساب اسناد انبار از اين فانکشن استفاده ميشود
        Dim DV As System.Data.DataView
        Dim i As Integer, counti As Integer
        Dim vGoroohTafsiliSN As Decimal
        Dim vWhereGoroohTafsiliSN As String
        Dim vtblWhereCol As String

        If Trim(atblWhereCol) <> "" Then
            vtblWhereCol = atblWhereCol & "."
        End If

        vWhereGoroohTafsiliSN = ""
        DV = cn.ExecuteQuery(" SELECT GoroohTafsiliSN FROM dbo.abFnt_GetGoroohTafsiliNoeAnbar ( " &
                              CStr(aTarakoneshSN) &
                              " , " & CStr(aNoeAnbarSN) & " ) ")
        counti = DV.Count
        If counti > 0 Then
            For i = 0 To counti - 1
                With DV.Table
                    vGoroohTafsiliSN = .Rows(i)("GoroohTafsiliSN")
                    If vGoroohTafsiliSN <> 0 Then
                        If i = 0 Then
                            vWhereGoroohTafsiliSN = GetTafsiliWhereCondition_Gorooh(vGoroohTafsiliSN)
                        Else
                            vWhereGoroohTafsiliSN = vWhereGoroohTafsiliSN & " UNION " &
                                                    GetTafsiliWhereCondition_Gorooh(vGoroohTafsiliSN)
                        End If
                    End If
                End With
            Next
            GetTaraKoneshGoroohTafsiliSN = "( Status = 1  AND " & vtblWhereCol & "TafsiliSN IN (" &
                                           vWhereGoroohTafsiliSN & " ) )"
            DV.Dispose() : DV = Nothing
        ElseIf aTarakoneshSN = EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA Then _
            ' aTarakoneshSN = EnumTarakoneshSN.RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB Or

            'براي تراکنش انتقال بين انبارهاي شرکتهاي مختلف پارس اضافه شده است-870325
            GetTaraKoneshGoroohTafsiliSN = "(1=1)"
        Else
            GetTaraKoneshGoroohTafsiliSN = " ( 1 = 2 ) "
        End If
    End Function

    Public Shared Sub ErsaleHavaleBeShoab(ByVal GhatiSanadSN As Double)

        Dim dvsend As DataView

        dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeShoabInfo " & GhatiSanadSN.ToString)
        If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
            Using client As New MiddlewareHelper(cn.SQLServerName, CStr(gSM.ServiceUserID), gSM.ServiceUserPassword)

                Dim Body As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Receiver")), "Minoo.Services.Anbar/AnbarWebService.svc", "DO_ErsaleHavleBeShoab", dvsend.Item(0).Item("Packet").ToString(), CDec(dvsend.Item(0).Item("Sender")), CDec(dvsend.Item(0).Item("Receiver")))

                Try
                    client.Transmit()

                    Dim Result As String = Body.ServiceResult

                    If Body.IsSuccessfull <> True Then
                        Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & Result)
                    End If

                Catch ex As System.Exception
                    Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & ex.Message)
                Finally
                End Try

            End Using
        End If

        '''Dim dvsend As DataView
        '''Dim result As String

        '''dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeShoabInfo " & GhatiSanadSN.ToString)
        '''If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
        '''    result = _
        '''        MinooMiddleWareCaller.MinooMiddleWareCaller.SendPacket(cn, dvsend.Item(0).Item("Packet").ToString, _
        '''                                                                    dvsend.Item(0).Item("Sender").ToString, _
        '''                                                                    dvsend.Item(0).Item("Receiver").ToString, _
        '''                                                                    1)
        '''    If result.ToUpper <> "TRUE" Then
        '''        Throw New Exception("خطای سرویس انتقال اطلاعات : " + vbCrLf + result)
        '''    End If

        '''End If
    End Sub

    Public Shared Sub ErsaleHavaleBeSherkateGorooh(ByVal GhatiSanadSN As Double)

        Dim dvsend As DataView
        Dim Result As String

        '''ثبت سند مقابل در واحد تجاری دیگر
        dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeSherkateGoroohInfo " & GhatiSanadSN.ToString)
        If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
            Using client As New MiddlewareHelper(cn.SQLServerName, CStr(gSM.ServiceUserID), gSM.ServiceUserPassword)

                Dim Body As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Receiver")), "Minoo.Services.Anbar/AnbarWebService.svc", "DO_ErsaleHavaleBeSherkateGorooh", dvsend.Item(0).Item("Packet").ToString, CDec(dvsend.Item(0).Item("Sender")), CDec(dvsend.Item(0).Item("Receiver")))

                Try
                    client.Transmit()

                    Dim Result2 As String = Body.ServiceResult

                    If Body.IsSuccessfull <> True Then
                        Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & Result2)
                    End If

                Catch ex As System.Exception
                    Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & ex.Message)
                Finally
                End Try

            End Using
            ''''result = _
            ''''    MinooMiddleWareCaller.MinooMiddleWareCaller.SendPacket(cn, dvsend.Item(0).Item("Packet").ToString, _
            ''''                                                                dvsend.Item(0).Item("Sender").ToString, _
            ''''                                                                dvsend.Item(0).Item("Receiver").ToString, _
            ''''                                                                6)

            ''''If result.ToUpper <> "TRUE" Then
            ''''    Throw New Exception("خطای سرویس انتقال اطلاعات : " + vbCrLf + result)
            ''''End If

        Else
            '''ثبت سند مقابل در همین واحد تجاری
            cn.CallSP("_abSP_SabtAsnadeMoGhabelAnbar", GhatiSanadSN, Result)

        End If
    End Sub


    Public Shared Function ChangeSanadStatusServiceMethod(SanadSN As Decimal, ReceiverVahedeTejariSN As Decimal, SanadStatus As Short, ByVal UserIdSabtKonandeh As Integer, ByVal UserNameSabtKonandeh As String, ByVal ConnectionString As String) As String

        Dim mcn As New SqlConnection(ConnectionString)
        mcn.Open()
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand

        Dim ERr As String = ""

        Using client As New MiddlewareHelper("ASP", "9005", "06D80C6623D1984029")

            Dim Body As ServiceRequestBody = client.Add(True, ReceiverVahedeTejariSN, "Minoo.Services.Anbar/AnbarWebService.svc", "GhateeSaziSanad",
                                                        SanadSN, SanadStatus, UserIdSabtKonandeh, UserNameSabtKonandeh)

            Try
                client.Transmit()

                Dim Result2 As String = Body.ServiceResult

                If Body.IsSuccessfull <> True Then
                    Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & Result2)
                End If

            Catch ex As System.Exception
                Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & ex.Message)
            Finally
            End Try

        End Using

        mcn.Close()


    End Function
    '''''''''''''''''''رسید تامین کنندگانRezania970823
    Public Shared Sub SabtResidTaminkonandegan(ByVal ConnectionString As String)

        Dim dvsend As DataView
        Dim dt As DataTable
        Dim DS As DataSet = New DataSet
        Dim XmlStrSanad As String = ""
        '''ثبت سند مقابل در واحد تجاری دیگر
        Dim mcn As New SqlConnection(ConnectionString)
        mcn.Open()
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand

        Dim _txt As String = "_abSPG_GetResidTaminKonandegan"
        Cmnd.CommandText = _txt
        Cmnd.Connection = mcn
        Cmnd.CommandType = CommandType.StoredProcedure
        Cmnd.CommandTimeout = "300000"
        sda.SelectCommand = Cmnd
        sda.Fill(DS)

        If DS IsNot Nothing AndAlso DS.Tables.Count > 0 Then
            dvsend = DS.Tables("table").DefaultView

            Dim ERr As String = ""
            If dvsend.Count > 0 Then
                For Each _R As DataRowView In dvsend
                    XmlStrSanad = "<abSanad><TafsiliSN>" & _R("TafsiliSn").ToString & "</TafsiliSN><Tozih>" & _R("Tozih").ToString & "</Tozih><BarnameheHamlNo>" & _R("BarnameheHamlNo").ToString & "</BarnameheHamlNo>"
                    XmlStrSanad += "<abSanadha><KalaSN>" & _R("KalaSN").ToString & "</KalaSN><MeghdareVaredeh>" & _R("MeghdareVaredeh").ToString & "</MeghdareVaredeh></abSanadha></abSanad>"

                    Using client As New MiddlewareHelper("ASP", "9005", "06D80C6623D1984029")

                        Dim Body As ServiceRequestBody = client.Add(True, _R("Receiver"), "Minoo.Services.Anbar/AnbarWebService.svc", "DO_SabteResidDarShoab", XmlStrSanad, CDec(_R("Sender").ToString), CDec(_R("Receiver").ToString))

                        Try
                            client.Transmit()

                            Dim Result2 As String = Body.ServiceResult

                            If Body.IsSuccessfull <> True Then
                                Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & Result2)

                            Else
                                Dim sqlcommand As String = " update abBarnamehamlTamin set issend=1 where BarnameHamlSN=@BarnameHamlSN"
                                Dim com As New SqlCommand(sqlcommand, mcn)
                                com.Parameters.AddWithValue("@BarnameHamlSN", _R("BarnameHamlSN").ToString())
                                com.ExecuteNonQuery()

                            End If

                        Catch ex As System.Exception
                            Throw New Exception("عدم موفقیت سرویس هنگام ارسال سند" & vbCrLf & ex.Message)
                        Finally
                        End Try

                    End Using
                Next

            End If
        End If

        mcn.Close()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''

    Public Shared Sub ErsaleBarnamehBeDP(ByVal BarnamehSN As Double)
        Dim dvsend As DataView

        dvsend = cn.ExecuteQuery("_abSPG_GetBarnamehPacketInfo " & BarnamehSN.ToString)
        If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
            Dim Result1 As String = "ERROR"
            Dim Result2 As String = "ERROR"
            Try
                Using client As New MiddlewareHelper(cn.SQLServerName, CStr(gSM.ServiceUserID), gSM.ServiceUserPassword)
                    '#If CONFIG = "Debug" Then
                    '                    client.Log = New Minoo.Common.LogEngineHelper(Minoo.Common.Shared.ApplicationLogFilename)
                    '#End If
                    client.StartNewCorresponds(True)
                    Dim Body1 As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Receiver")), "Minoo.Services.Anbar/AnbarWebService.svc", "ErsalBeDP", dvsend.Item(0).Item("Packet").ToString(), CDec(dvsend.Item(0).Item("Sender")), CDec(dvsend.Item(0).Item("Receiver")))
                    Dim Body2 As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Sender")), "Minoo.Services.Anbar/AnbarWebService.svc", "ErsalBeDP_Taeed", BarnamehSN.ToString(), gSM.UserID_Name)

                    Try
                        'Body1.RequestResponse = True
                        client.Transmit()
                        Result1 = Body1.ServiceResult
                        Result2 = Body2.ServiceResult
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("خطا در ارسال بارنامه", MsgBoxStyle.OkOnly, "توجه")
                        MsgBox(ex.Message)
                    End Try

                End Using

            Catch ex As System.Exception
                NetSql.Common.CSystem.MsgBox("عدم موفقیت سرویس هنگام ارسال بارنامه", MsgBoxStyle.OkOnly, "توجه")
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Public Shared Sub UpdatedarkhastTadarokat(ByVal GhatiSanadSN As Double)
        Dim dvSanadHa As DataView
        Dim i As Integer
        Dim ErrMsg As String = ""

        dvSanadHa = _
            cn.ExecuteQuery( _
                             "SELECT MojavezErsalHaSN , KalaSN ,MeghdareVaredeh = CASE WHEN TarakoneshSN >50 THEN -1 * Meghdaresadereh ELSE MeghdareVaredeh END FROM abSanad T1 INNER JOIN abSanadHa T2 ON T1.SanadSN = T2.SanadSN WHERE ISNULL(T2.MojavezErsalHaSN,0)>0 AND T1.SanadSN = " & _
                             GhatiSanadSN.ToString)
        If Not dvSanadHa Is Nothing AndAlso dvSanadHa.Count > 0 Then

            For i = 0 To dvSanadHa.Count - 1
                cn.CallSP("_tdspc_UpdatedarkhastByAnbar", dvSanadHa.Item(i).Item("MojavezErsalHaSN"), _
                           dvSanadHa.Item(i).Item("MeghdareVaredeh"), ErrMsg)
                If ErrMsg <> "" Then
                    Throw New Exception("خطای بروزرسانی در سیستم تدارکات : " + vbCrLf + ErrMsg)
                End If
            Next
        End If
    End Sub

    Public Shared Sub ErsaleHavaleBeShoabDasti(ByVal AnbarSN As Decimal, ByVal Tarakoneshsn As Decimal, ByVal fromdate As String, ByVal Todate As String)
        Dim _Cl As New ClsDataAccessRule
        Dim i As Integer
        Dim ErrMsg As String = ""
        Dim dvs As DataView = _Cl.GetListASnadErsaliBeShoabDasti(AnbarSN, Tarakoneshsn, fromdate, Todate, cn, tp)
        If dvs.Count <> 0 Then
            For i = 0 To dvs.Count - 1
                Dim dvsend As DataView
                'dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeShoabInfo " & dvs(i)("SanadSn"))
                dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeSherkateGoroohInfo " & dvs(i)("SanadSn"))

                If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
                    Using client As New MiddlewareHelper(cn.SQLServerName, CStr(gSM.ServiceUserID), gSM.ServiceUserPassword)

                        'Dim Body As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Receiver")), "Minoo.Services.Anbar/AnbarWebService.svc", "DO_ErsaleHavleBeShoab", dvsend.Item(0).Item("Packet").ToString(), CDec(dvsend.Item(0).Item("Sender")), CDec(dvsend.Item(0).Item("Receiver")))
                        Dim Body As ServiceRequestBody = client.Add(True, CDec(dvsend.Item(0).Item("Receiver")), "Minoo.Services.Anbar/AnbarWebService.svc", "DO_ErsaleHavaleBeSherkateGorooh", dvsend.Item(0).Item("Packet").ToString, CDec(dvsend.Item(0).Item("Sender")), CDec(dvsend.Item(0).Item("Receiver")))

                        Try
                            client.Transmit()

                            Dim Result As String = Body.ServiceResult

                            If Body.IsSuccessfull <> True Then
                                ErrMsg += "سند شماره " + dvs(i)("SanadNO") + " با موفقیت ارسال نشد"
                            Else
                                ErrMsg += vbCrLf + "سند شماره " + dvs(i)("SanadNO").ToString + " با موفقیت ارسال شد"
                            End If

                        Catch ex As System.Exception
                            ErrMsg += "سند شماره " + dvs(i)("SanadNO").ToString + " با موفقیت ارسال نشد"
                        Finally
                        End Try

                    End Using
                End If
                dvsend.Dispose()
            Next
        End If
        CSystem.MsgBox(ErrMsg)
        '''Dim dvsend As DataView
        '''Dim result As String

        '''dvsend = cn.ExecuteQuery("_abSPG_GetHavleErsalBeShoabInfo " & GhatiSanadSN.ToString)
        '''If Not dvsend Is Nothing AndAlso dvsend.Count > 0 Then
        '''    result = _
        '''        MinooMiddleWareCaller.MinooMiddleWareCaller.SendPacket(cn, dvsend.Item(0).Item("Packet").ToString, _
        '''                                                                    dvsend.Item(0).Item("Sender").ToString, _
        '''                                                                    dvsend.Item(0).Item("Receiver").ToString, _
        '''                                                                    1)
        '''    If result.ToUpper <> "TRUE" Then
        '''        Throw New Exception("خطای سرویس انتقال اطلاعات : " + vbCrLf + result)
        '''    End If

        '''End If
    End Sub

#End Region

End Class
