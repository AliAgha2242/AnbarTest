' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  
'ModifiedDate::
'Description::  
'System ::انبار

Option Strict Off
Option Explicit On

Imports System.IO

Public Class CAppAnbar
    Inherits Minoo.Base.CBaseApplication

    '  جهت استفاده در سيستم انبار 
    Friend Shared gSanadAnbar As Minoo.Applications.Anbar.CSanad

    Private pCountHesabdariSal As Integer

    Public Sub New()
        MyBase.New (5, "سيستم انبار", New mdiMainAnbar)
    End Sub

    Public Shared Sub Main()
        Dim vAppAnbar As New CAppAnbar
        vAppAnbar.Run()
        vAppAnbar = Nothing
    End Sub

    Protected Overrides Function DetectInfoVahedeTejari() As Boolean
        Dim vNoeAnbarSN, vIdentifier, vAnbarSN, vVahedeTejariSN As Decimal
        Dim vAnbarDS As String, vAnbarNO As String, vVahedeTejariNO As String
        Dim vIsTajmie As Integer, _
            vNoeVoroodeAsnadSN As Integer
        'vKalaPhizikiStatusSN As Decimal, _
        '   vRahgiriAuto As Integer, _
        '   vRahgiriMeghdar As Integer, _

        If gSM.Identifier <> 0 Then
            vIdentifier = gSM.Identifier
            ' بدست آوردن اطلاعات جانبي انبار 
            'cn.CallSP("_abSpGAnbarSN2", vAnbarSN, vIdentifier, vAnbarDS, vVahedeTejariSN, vNoeAnbarSN, vAnbarNO _
            '                              , vVahedeTejariNO, vKalaPhizikiStatusSN, vRahgiriAuto, vRahgiriMeghdar, vIsTajmie, vNoeVoroodeAsnadSN)
            cn.CallSP ("_abSpGAnbarSN2", vAnbarSN, vIdentifier, vAnbarDS, vVahedeTejariSN, vNoeAnbarSN, vAnbarNO _
                       , vVahedeTejariNO, vIsTajmie, vNoeVoroodeAsnadSN)

            If Val (vAnbarSN) = 0 Then
                NetSql.Common.CSystem.MsgBox(" انبار مورد نظر تعريف نشده است . با مدير سيستم تماس حاصل فرماييد", MsgBoxStyle.Critical, _
                           "سيستم انبار")
            ElseIf Val(vVahedeTejariSN) = 0 Then
                NetSql.Common.CSystem.MsgBox("مالكيت انبار مورد نظر مشخص نشده است . با مدير سيستم تماس حاصل فرماييد", MsgBoxStyle.Critical, _
                           "سيستم انبار")
            End If

            gAnbarSN = vAnbarSN
            gNoeAnbarSN = vNoeAnbarSN
            gAnbarDS = vAnbarDS
            gVahedeTejariSN = vVahedeTejariSN
            gAnbarNO = vAnbarNO
            gVahedeTejariNO = vVahedeTejariNO
            'gKalaPhizikiStatusSN = vKalaPhizikiStatusSN
            'gRahgiriAuto = vRahgiriAuto
            'gRahgiriMeghdar = vRahgiriMeghdar
            gIsTajmie = vIsTajmie
            gNoeVoroodeAsnadSN = vNoeVoroodeAsnadSN
            Dim vAnbarSNStr As String
            ' يک رشته از کليد اصلي انبارها
            '  بدست آوردن انبارهاي زير اين انبار   درخت انبار متناظر با درخت واحدهاي تجاري ساخته ميشود
            If gIsTajmie = 1 Then
                cn.CallSP("_abSPG_GetStrAnbarSN_Childs", gAnbarSN, vAnbarSNStr)
                gAnbarSelected = vAnbarSNStr
            Else
                gAnbarSelected = gAnbarSN
            End If
            ' بدست آوردن اطلاعات سال مالي با توجه به واحد تجاري
            cn.CallSP("_abSPG_GetHesabdariSalInfo", gVahedeTejariSN, gAnbarSN, 0 _
                       , gHesabdariSal, gHesabdariSalFDate, gHesabdariSalTDate _
                       , gHesabdariSalISClosed, pCountHesabdariSal)
            'If gIsTajmie <> 1 And gKalaPhizikiStatusSN = 0 Then
            '  NetSql.Common.CSystem.MsgBox("رويه رهگيري کالاها در انبار مورد نظر تعريف نشده است.با مدير سيستم تماس حاصل فرماييد", MsgBoxStyle.Critical, "سيستم انبار")
            '  End
            'End If
            'gHesabdariSalFDate = Functions.FTCommonFunctions.
        End If
        DetectInfoVahedeTejari = True

    End Function

    Private Sub CAppAnbar_AfterLogin() Handles MyBase.AfterLogin

        '    Me.AppMDIMainForm.SystemName = "AB"

        cn.AutoHandleError = False
        gSelectHesabdariSal = New Minoo.Applications.Anbar.Common.frmSelectHesabdariSal
        gAnbarSelectForm = New Minoo.Applications.Anbar.Common.FrmTreeSelectAnbar
        If gVahedeTejariSN = 0 Then
            NetSql.Common.CSystem.MsgBox("مشکل در تهيه gVahedeTejariSN   لطفا با مدير سيستم تماس بگيريد")
        End If
        gSanadAnbar = New Minoo.Applications.Anbar.CSanad(tp, cn, gSM, gSNFieldOption _
                                                           , gVahedeTejariSN, gVahedeTejariDs, gVahedeTejariNO _
                                                           , gAnbarSN, gAnbarDS, gAnbarNO, gNoeAnbarSN _
                                                           , gIsTajmie, Me.AppMDIMainForm)

        ' نمايش هشدار کالاهاي بدون نرخ براي دسترسي تعريف شده
        ' جهت کالاهاي بدون نرخ
        If gSM.TableAccessRight("FrmAlertNerkhStandardAsnad") And EnumAccessRight.arView <> 0 Then _
            ' And SystemInformation.ComputerName <> "SMGhasemi"
            Minoo.Applications.Anbar.Hesabdari.CHesabdari.ShowAlertNerkhStandardAsnad(Me.AppMDIMainForm)
        End If
        ' جهت کالاهاي بدون نرخ

        Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, 3)
        IsVahedTejariTolidi = IIf(CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi"))



        '  در حالتي که بيش از يک سال مالي بدست آيد فرم انتخاب براي کاربر نمايش داده ميشود
        If pCountHesabdariSal > 1 Then
            SelectHesabdariSal(Me.AppMDIMainForm)
            Me.AppMDIMainForm.RefreshStatusBar()
        End If


        'پیغام هشدار در مورد وجود اسناد در کارتابل ضایعات یوزر - Dehghani - 14001030

        Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
        Dim GVahedeTejariUsesKartablZayeat As Boolean = If(CApp.GetAppConfig("GVahedeTejariUsesKartablZayeat") Is System.DBNull.Value, False, True)

        If GVahedeTejariUsesKartablZayeat AndAlso Not gSM.IsProgrammer Then
            Dim Dv As DataView = cn.ExecuteQuery("Select * from abVw_ZayeatGardeshRole  Where UserId=" & gSM.UserID.ToString)
            If Dv.Count <> 0 Then
                Dim DtMaster As DataView
                Dim Today As String = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                        cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                DtMaster = cn.ExecuteQuery("_abSPG_GetZayeatGardeshKartabl_Master " & gSM.UserID.ToString & ",'" & Today.Substring(0, 4) + "0101" & "','" & Today & "'")
                If Not DtMaster Is Nothing Then
                    If DtMaster.Count > 0 Then
                        If CSystem.MsgBox("< " + DtMaster.Count.ToString + " >" + " سند در کارتابل ضایعات شما جهت تایید وجود دارد.آیا مایل به مشاهده کارتابل ضایعات می باشید؟", MsgBoxStyle.YesNo, "نمایش کارتابل ضایعات") = MsgBoxResult.No Then
                            Exit Sub
                        Else
                            Dim Frm As New FrmabZayeatKartabl
                            With Frm
                                .DtMasTer = DtMaster
                                .ShowDialog()
                                .Dispose()
                            End With
                        End If
                    End If
                End If
            End If

        End If
        'پیغام هشدار در مورد وجود اسناد در کارتابل ضایعات یوزر - Dehghani - 14001030

    End Sub

    Protected Overrides Function GetPanelTextSal() As String
        Return "سال مالي: " & gHesabdariSal
    End Function

    Protected Overrides Function GetPanelTextVahedeTejariDS() As String
        Return "نام انبار: " & gAnbarDS
    End Function

    Private Sub CAppAnbar_AfterLogout() Handles MyBase.AfterLogout
        gAnbarSelected = ""
        gHesabdariSal = 0
        gHesabdariSalFDate = ""
        gHesabdariSalTDate = ""
        gHesabdariSalISClosed = False

        gAnbarSN = 0
        gAnbarDS = ""
        gAnbarNO = 0
        gNoeAnbarSN = 0
        gVahedeTejariNO = 0
        'gKalaPhizikiStatusSN = 0
        'gRahgiriAuto = 0
        'gRahgiriMeghdar = 0
        gIsTajmie = 0
        With gAnbarSelectForm
            If Not gAnbarSelectForm Is Nothing Then
                .Close()
                .Dispose()
            End If
        End With
        With gSelectHesabdariSal
            If Not gSelectHesabdariSal Is Nothing Then
                .Close()
                .Dispose()
            End If
        End With
        With gSanadAnbar
            If Not gSanadAnbar Is Nothing Then
                gSanadAnbar = Nothing
            End If
        End With
    End Sub

#Region " Anbar Methods"

    Public Shared Sub ErsalFile(ByVal ErsalType As String, ByVal vpath As String, ByVal Vin_ToDate As String)
        ' جهت ذخيره فايل اسناد روزانه انبار 
        Dim vFileName As String
        Dim vline_70 As String
        Dim i As Int16, vcounti As Int16

        'vpath
        If Trim(vpath) = "" Then
            vpath = "D:\spool.ocr\Inv"
        End If
        vFileName = vpath & gVahedeTejariNO & ".dta"
        If ErsalType = "ErsalForMahsoul" Then
            If Trim(vFileName) <> "" Then
                ' _abSPG_GetErsalFile
                Dim DV As System.Data.DataView
                ' جهت تهيه فايل با توجه به پارامترهاي مورد نياز 
                ' اس پي  اجرا ميگردد و خروجي در اختيار ديتا ويو قرار ميگيرد
                DV = cn.SPQuery("_abSPG_GetErsalFile", Vin_ToDate)
                vcounti = DV.Count
                ' _abSPG_GetErsalFile
                ' Write File
                Dim sr As StreamWriter = New StreamWriter(vFileName)
                For i = 0 To vcounti - 1
                    vline_70 = DV.Table.Rows(i)("Line").ToString
                    sr.WriteLine(vline_70)
                Next
                sr.Close()
                DV.Dispose() : DV = Nothing
                File.Copy(vFileName, "D:\Inv\Backup\Inv" & gVahedeTejariNO & Vin_ToDate & ".dta", True)
                NetSql.Common.CSystem.MsgBox("  فايل خروجي با " + i.ToString + " رکورد ساخته شد .")
                ' Write File
            End If
        End If

    End Sub

    Public Shared Function DarjSanadAsAnbarBeAnbar(ByVal IN_VahedeTejariSN As Decimal _
                                                    , ByVal From_AnbarSN As Decimal, ByVal To_AnbarSN As Decimal _
                                                    , ByVal From_NoeAnbarSN As Decimal, ByVal To_NoeAnbarSN As Decimal _
                                                    , ByVal From_TarakoneshSN As Decimal, _
                                                    ByVal To_TarakoneshSN As Decimal _
                                                    , ByVal InUserID_Name As String) As String
        ' ارسال حواله ضايعات به انبار ضايعات
        ' عمومي ديده شده است براي استفاده در موارد مشابه
        Dim vErrorMsg As String
        cn.CallSP("_abSP_DarjSanadAsAnbarBeAnbar", IN_VahedeTejariSN _
                   , From_AnbarSN, To_AnbarSN _
                   , From_NoeAnbarSN, To_NoeAnbarSN _
                   , From_TarakoneshSN, To_TarakoneshSN, System.DBNull.Value _
                   , InUserID_Name, vErrorMsg)
        DarjSanadAsAnbarBeAnbar = vErrorMsg
    End Function

    Public Shared Function SodorSanadAsMojodiBeAnbar10(ByVal vVahedeTejariSN As Decimal _
                                                        , ByVal vAnbarSN As Decimal, ByVal vNoeAnbarSN As Decimal _
                                                        , ByVal InUserID_Name As String, ByRef ErrMsg As String) _
        As String
        ' ثبت موجودي اول دوره 
        Dim vErrMsg, vNoeMarjooeiType As String
        ' vNoeMarjooeiType = 0 : سالم
        ' = 1 : غيرسالم
        Dim vSanadDate, vTozih As String
        Dim vFromDate, vToDate As String

        vSanadDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                 cn, _
                                                                                 Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        vFromDate = Trim(Str(Int(Val(gHesabdariSalFDate)) - 10000))
        'dclFDate.Value
        vToDate = Trim(Str(Int(Val(gHesabdariSalTDate)) - 10000))
        'dclFDate.Value
        If Trim(vSanadDate) = "" Then
            NetSql.Common.CSystem.MsgBox("تاريخ سند مشخص نشده است")
            Return ""
        End If
        vTozih = "صدور حواله انبار به انبار با توجه به مانده موجودي به تفکيک نوع مرجوعي توسط سيستم انبار"

        ' فراخواني اس پي براي انتقال مانده موجودي به تفکيک نوع مرجوعي سالم
        vNoeMarjooeiType = 0
        cn.CallSP("_abSP_Ins_SanadAsMojodiBeAnbar10", vVahedeTejariSN, vAnbarSN, vNoeAnbarSN _
                   , vFromDate, vToDate _
                   , gSM.Identifier _
                   , vSanadDate, vTozih _
                   , vNoeMarjooeiType _
                   , InUserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading _
                                + MsgBoxStyle.MsgBoxRight, _
                       "صدور حواله انبار به انبار با توجه به مانده موجودي به تفکيک نوع مرجوعي")
            ErrMsg = vErrMsg
        End If

        ' فراخواني اس پي براي انتقال مانده موجودي به تفکيک نوع مرجوعي فاسد
        vNoeMarjooeiType = 1
        cn.CallSP("_abSP_Ins_SanadAsMojodiBeAnbar10", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN _
                   , vFromDate, vToDate _
                   , gSM.Identifier _
                   , vSanadDate, vTozih _
                   , vNoeMarjooeiType _
                   , gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading _
                                + MsgBoxStyle.MsgBoxRight, _
                       "صدور حواله انبار به انبار با توجه به مانده موجودي به تفکيک نوع مرجوعي")
            ErrMsg = vErrMsg
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Return ""
    End Function

#End Region

End Class
