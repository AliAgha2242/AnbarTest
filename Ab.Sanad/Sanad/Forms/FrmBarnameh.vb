'Programmer :: Zohreh Izadpanah     
'CreateDate :: 1388/12/02
'ModifiedDate::
'Description:: فرم بارنامه 
'System :: سيستم انبار


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Public Class FrmBarnameh
    Inherits Minoo.Base.FTBaseForm


#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmBarnameh
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmBarnameh

    Get

    If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmBarnameh
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

    End Get

        Set(ByVal Value As FrmBarnameh)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

#Region "PrivateVariabledDefinition"

    Private WithEvents dvBarnameh As CDataView
    Private WithEvents dvBarnamehHa As CDataView

    Private WithEvents cboGhabzeAnbar As NetSql.Components.DataCombo
    Private WithEvents cboKala As NetSql.Components.DataCombo

    Private dclFdate As NetSql.Components.CDateCtrl
    Private WithEvents txtSanadMaliDate As NetSql.Components.TextBox

#End Region

    '//ناحيه تعريف متغيرهاي Local

    Private Enum BarnamehStatus
        Movaghat = 0
        Ghati
        Ebtal
    End Enum

    Private Sub frmFactor_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '// براي تاريخ شروع و تاريخ پايان
        dclFdate = New NetSql.Components.CDateCtrl (tp)
        dclFdate.TextBox = txtFromDate
        dclFdate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        dclFdate.Text = gHesabdariSalFDate


        cboGhabzeAnbar = New NetSql.Components.DataCombo

        dvBarnameh = New CDataView (cn)
        dvBarnamehHa = New CDataView (cn)

        InitdvBarnameh()
        InitdvBarnamehHa()
        dvBarnamehHa.Parent = dvBarnameh
        btnOk_Click (sender, e)

    End Sub

    Private Sub frmBarnameh_Closed (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        If Not dvBarnameh Is Nothing Then

            dvBarnameh.Done()
            dvBarnameh = Nothing

        End If
        If Not dvBarnamehHa Is Nothing Then

            dvBarnamehHa.Done()
            dvBarnamehHa = Nothing

        End If

    End Sub

    Private Sub InitdvBarnameh()

        With dvBarnameh

            .Init (pnlg0, , pnlc0, pnln0, _
                   EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit)
            .TableName = "abBarnameh"
            .SQLOrderBy = "BarnamehDate"
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True

            With .Fields
                '// براي فاکتور
                dvBarnameh.SettingID = "Barnameh"

                With .Add ("BarnamehSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add ("{Floor(BarnamehSN*1000)} As BarnamehSerial")
                    .Caption = "سريال بارنامه"
                End With

                With .Add ("BarnamehNo", "Textbox")
                    .Caption = "شماره بارنامه"
                End With

                With .Add ("BarnamehDS", "Textbox")
                    .Caption = "شرح بارنامه"
                    .MinComponentWidth = 100
                End With

                With .Add ("AnbarSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gAnbarSN
                End With

                With .Add ("VahedeTejariSn", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With

                With .Add ("NameRanandeh", "Textbox")
                    .Caption = "نام راننده"
                    .MinComponentWidth = 100
                End With

                With .Add ("ShomarehMashin", "Textbox")
                    .Caption = "شماره ماشین"
                    .MinComponentWidth = 100
                End With

                With .Add ("BarnamehDate", "Textbox", EnumFieldOptions.foDate)
                    .Caption = "تاريخ بارنامه"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi (Today, .DateFormat)
                End With

                With .Add ("SanadMaliDate", "Textbox", EnumFieldOptions.foDate)
                    .Caption = "تاريخ سند مالي"
                    txtSanadMaliDate = .Component
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi (Today, .DateFormat)
                End With

                With .Add("SabtDate", , EnumFieldOptions.foDefault)
                    .Caption = "تاريخ ثبت"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add ("EbtalDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ ابطال"
                End With
                With .Add ("EbtalSanadMaliDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ سند مالی ابطال"
                End With
                With .Add ("GhatiDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ قطعی سازی"
                End With
                With .Add ("VahedeTashim", , EnumFieldOptions.foHidden)
                    .Caption = "نحوه تسهیم"
                    .DefaultValue = 0
                End With

                With .Add ("GheymateBarnameh", "Textbox")
                    .Caption = "مبلخ بارنامه"
                    .Format = "#,#.###"
                    .NumericScale = 0
                    .DigitGroupSymbol = ","
                    .MaxLength = 22
                    .DefaultValue = 0
                End With

                With .Add ("BarnamehStatus", , EnumFieldOptions.foHidden)
                    .DefaultValue = 0
                End With

                With _
                    .Add ( _
                          "{CASE WHEN BarnamehStatus = 0 THEN 'موقت' WHEN BarnamehStatus = 1 THEN 'قطعی'  ELSE 'ابطال' END} AS  BarnamehStatusDS", , _
                          EnumFieldOptions.foDefault)
                    .DefaultValue = 0
                    .Caption = "وضعیت"
                End With

                With .Add ("UserID_Name", )
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "ثبت کننده"
                End With

                With .Add ("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub

    Private Sub InitdvBarnamehHa()
        With dvBarnamehHa
            .Init (pnlg1, , pnlc1, pnln1, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abBarnamehHa"
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            With .Fields
                With .Add ("BarnamehHaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("BarnamehSN", , EnumFieldOptions.foHidden)

                .Add ("abSanad.SanadSN", , EnumFieldOptions.foHidden)
                With _
                    .Add ("abBarnamehHa.SanadSN -> {abSanad.SanadNo+' '+abSanad.SanadDate} as SanadSN  ", cboGhabzeAnbar)
                    .ComboWhereCondition = "1>1"
                    .Caption = "قبض انبار"
                End With

                With .Add ("VazneBaskool ", , EnumFieldOptions.foHidden)
                    .DefaultValue = 0
                End With

                With .Add ("Hajm ", , EnumFieldOptions.foHidden)
                    .DefaultValue = 0
                End With


                With .Add ("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With

                With .Add ("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub

    Private Sub SetButton()

        dvBarnameh.CommandEnabled (EnumCommands.cmAdd) = gSM.ActionInsert (dvBarnameh.TableName)
        dvBarnameh.CommandEnabled (EnumCommands.cmEdit) = dvBarnameh.DataRows > 0 And _
                                                          gSM.ActionUpdate (dvBarnameh.TableName) And _
                                                          Val (dvBarnameh.FieldValue ("BarnamehStatus")) = _
                                                          BarnamehStatus.Movaghat
        dvBarnameh.CommandEnabled (EnumCommands.cmDelete) = dvBarnameh.DataRows > 0 And _
                                                            gSM.ActionDelete (dvBarnameh.TableName) And _
                                                            Val (dvBarnameh.FieldValue ("BarnamehStatus")) = _
                                                            BarnamehStatus.Movaghat
        btnGhati.Enabled = dvBarnameh.DataRows > 0 And dvBarnamehHa.DataRows > 0 And _
                           gSM.ActionEnabled ("btnGhatiBarnameh") And _
                           Val (dvBarnameh.FieldValue ("BarnamehStatus")) = BarnamehStatus.Movaghat
        btnGhati.Visible = btnGhati.Enabled
        btnEbtal.Enabled = dvBarnameh.DataRows > 0 And dvBarnamehHa.DataRows > 0 And _
                           gSM.ActionEnabled ("btnEbtalBarnameh") And _
                           Val (dvBarnameh.FieldValue ("BarnamehStatus")) = BarnamehStatus.Ghati
        btnEbtal.Visible = btnEbtal.Enabled
        dvBarnamehHa.CommandEnabled (EnumCommands.cmAdd) = gSM.ActionInsert (dvBarnamehHa.TableName) And _
                                                           dvBarnameh.DataRows > 0 And _
                                                           Val (dvBarnameh.FieldValue ("BarnamehSN")) > gSM.Identifier And _
                                                           Val (dvBarnameh.FieldValue ("BarnamehStatus")) = _
                                                           BarnamehStatus.Movaghat
        dvBarnamehHa.CommandEnabled (EnumCommands.cmEdit) = gSM.ActionUpdate (dvBarnamehHa.TableName) And _
                                                            dvBarnameh.DataRows > 0 And dvBarnamehHa.DataRows > 0 And _
                                                            Val (dvBarnameh.FieldValue ("BarnamehStatus")) = _
                                                            BarnamehStatus.Movaghat
        dvBarnamehHa.CommandEnabled (EnumCommands.cmDelete) = gSM.ActionDelete (dvBarnamehHa.TableName) And _
                                                              dvBarnameh.DataRows > 0 And dvBarnamehHa.DataRows > 0 And _
                                                              Val (dvBarnameh.FieldValue ("BarnamehStatus")) = _
                                                              BarnamehStatus.Movaghat
    End Sub

    Private Sub dvBarnamehHa_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles dvBarnamehHa.FillDetailsWithData
        SetButton()
    End Sub

    Private Sub btnEbtal_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEbtal.Click
        '//Local Variables Definition
        Dim frm As New frmInputDate
        Dim i As Integer
        Dim strMsg As String = ""
        Dim V_li_NewVaziat As Short
        'Dim vErrMsg As String
        Dim vSN As Decimal
        Dim VCount_SanadSN As Short
        Dim V_ar_BarnamehSN(,) As Decimal
        '//Local Variables Definition

        With dvBarnameh
            If _
                NetSql.Common.CSystem.MsgBox("آيا فاکتور انتخابي ابطال شود؟", _
                           MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or _
                           MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "ابطال") = MsgBoxResult.Yes Then

                If frm.ShowDialog = DialogResult.Cancel Then
                    Exit Sub
                End If

                'چک کردن تاريخ ابطال وارد شده با تاريخ فاكتور
                If frm.EbtalDate < .FieldValue("BarnamehDate") Then
                    NetSql.Common.CSystem.MsgBox("تاريخ ابطال نبايد از تاريخ بارنامه كوچكتر باشد", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                'چک کردن تاريخ ابطال وارد شده با تاريخ فاكتور
                With dvBarnameh.FlexGrid
                    VCount_SanadSN = .SelectedRows
                    ReDim V_ar_BarnamehSN(VCount_SanadSN, 2)
                    For i = 0 To VCount_SanadSN - 1
                        If .TextMatrix(.SelectedRow(i), .ColIndex("BarnamehStatus")) = "1" Then
                            V_ar_BarnamehSN(i, 1) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("BarnamehSN")))
                            V_ar_BarnamehSN(i, 2) = .TextMatrix(.SelectedRow(i), .ColIndex("BarnamehSN"))
                        End If
                    Next
                End With
                ' براي تمامي اسناد انتخاب شده   فراخواني اس پي تغيير وضعيت سند
                For i = 0 To VCount_SanadSN - 1
                    vSN = Val(V_ar_BarnamehSN(i, 1))
                    V_li_NewVaziat = 2
                    If vSN <> 0 Then
                        Try
                            If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()
                            cn.BeginTrans(cn.Connection.BeginTransaction)
                            cn.CallSP("_abSpc_ChangeBarnamehSatatus", vSN, V_li_NewVaziat, gSM.UserID, gSM.UserID_Name, _
                                       strMsg)
                            cn.CommitTrans()
                        Catch ex As Exception
                            cn.RollbackTrans()
                            NetSql.Common.CSystem.MsgBox(ex.Message)
                        End Try

                    End If
                Next

                If strMsg <> "" Then
                    NetSql.Common.CSystem.MsgBox(strMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, _
                               "خطا")
                    strMsg = ""
                End If


                For i = 0 To VCount_SanadSN - 1
                    vSN = Val(V_ar_BarnamehSN(i, 1))
                    If vSN <> 0 Then
                        dvBarnameh.CurrentKey = CStr(vSN)
                        dvBarnameh.FetchCurRecord()
                    End If
                Next

                Me.Cursor = System.Windows.Forms.Cursors.Default

            End If
        End With

    End Sub

    Private Sub btnghati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhati.Click
        Dim strMsg As String = ""
        Dim V_li_NewVaziat As Short
        'Dim vErrMsg As String
        Dim vSN As Decimal
        Dim VCount_SanadSN As Short
        Dim V_ar_BarnamehSN(,) As Decimal
        Dim i As Short

        With dvBarnameh
            If _
                NetSql.Common.CSystem.MsgBox("آيا اطلاعات قطعي شود؟", _
                           MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or _
                           MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "قطعي سازي") = MsgBoxResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                If strMsg = "" Then
                    If dvBarnamehHa.DataRows <= 0 Then
                        strMsg = "بارنامه داراي هيچ سندی نمي باشد"
                    End If

                    If .FieldValue("BarnamehDate") > gHesabdariSalTDate Then
                        strMsg = "تاريخ بارنامه خارج از سال مالي انتخاب شده مي باشد"
                    End If

                    If .FieldValue("SanadMaliDate") > gHesabdariSalTDate Then
                        strMsg = "تاريخ سند مالی بارنامه خارج از سال مالي انتخاب شده مي باشد"
                    End If

                End If
                With dvBarnameh.FlexGrid
                    VCount_SanadSN = .SelectedRows
                    ReDim V_ar_BarnamehSN(VCount_SanadSN, 2)
                    For i = 0 To VCount_SanadSN - 1
                        If .TextMatrix(.SelectedRow(i), .ColIndex("BarnamehStatus")) = "0" Then
                            V_ar_BarnamehSN(i, 1) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("BarnamehSN")))
                            V_ar_BarnamehSN(i, 2) = .TextMatrix(.SelectedRow(i), .ColIndex("BarnamehSN"))
                        End If
                    Next
                End With
                ' براي تمامي اسناد انتخاب شده   فراخواني اس پي تغيير وضعيت سند
                For i = 0 To VCount_SanadSN - 1
                    vSN = Val(V_ar_BarnamehSN(i, 1))
                    V_li_NewVaziat = 1
                    If vSN <> 0 Then
                        Try
                            If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()
                            cn.BeginTrans(cn.Connection.BeginTransaction)
                            cn.CallSP("_abSpc_ChangeBarnamehSatatus", vSN, V_li_NewVaziat, gSM.UserID, gSM.UserID_Name, _
                                       strMsg)
                            cn.CommitTrans()
                        Catch ex As Exception
                            cn.RollbackTrans()
                            NetSql.Common.CSystem.MsgBox(ex.Message)
                        End Try

                    End If
                Next
                If strMsg <> "" Then
                    NetSql.Common.CSystem.MsgBox(strMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, _
                               "خطا")
                    strMsg = ""
                End If

                Me.Cursor = System.Windows.Forms.Cursors.Default

                For i = 0 To VCount_SanadSN - 1
                    vSN = Val(V_ar_BarnamehSN(i, 1))
                    If vSN <> 0 Then
                        dvBarnameh.CurrentKey = CStr(vSN)
                        dvBarnameh.FetchCurRecord()
                    End If
                Next

            End If
        End With

    End Sub

    Private Sub dvBarnamehHa_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles dvBarnamehHa.CommandClick
        Dim StrMsg As String = ""

        Select Case aCommand
            Case EnumCommands.cmSave

                With dvBarnamehHa
                    If .FieldValue("SanadSN") = 0 Then
                        StrMsg = "شماره سند انتخاب نشده است"
                    End If

                End With
        End Select

        If StrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "خطا")
            aCancel = True
            StrMsg = ""
        End If

    End Sub

    Private Sub dvBarnameh_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles dvBarnameh.CommandClick
        Dim StrMsg As String = ""

        Select Case aCommand
            Case EnumCommands.cmAdd
                With dvBarnameh
                    .FlexGrid.Col = .FlexGrid.ColIndex("BarnamehNo")
                End With

            Case EnumCommands.cmSave
                With dvBarnameh
                    If .FieldValue("BarnamehNo") = "" Then
                        StrMsg = "ورود شماره بارنامه الزامي است"
                    End If
                    If StrMsg = "" Then
                        If .FieldValue("BarnamehDate") = "" Then
                            StrMsg = "ورود تاريخ بارنامه الزامي است"
                        ElseIf _
                            .FieldValue("BarnamehDate") < gHesabdariSalFDate Or _
                            .FieldValue("BarnamehDate") > gHesabdariSalTDate Then
                            StrMsg = "تاريخ بارنامه در محدوده سال مالي نمي باشد"
                        ElseIf _
                            .FieldValue("BarnamehDate") > _
                            NetSql.Common.CShamsiDate.MiladiToShamsi(Today, EnumDateFormat.dfDefault) Then
                            StrMsg = "تاريخ بارنامه نمي تواند بزرگتر از تاريخ روز باشد"
                        ElseIf .FieldValue("GheymateBarnameh") <= 0 Then
                            StrMsg = "مبلغ بارنامه صحیح نمی باشد"
                        End If

                    End If
                End With

        End Select

        If StrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "خطا")
            aCancel = True
            StrMsg = ""
        End If

    End Sub

    Private Sub txtSanadMaliDate_Enter (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtSanadMaliDate.Enter
        With dvBarnameh
            If .FieldValue ("SanadMaliDate") = "" Then
                .Fields ("SanadMaliDate").Value = .Fields ("BarnamehDate").Value
            End If
        End With
    End Sub

    Private Sub btnOk_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        dvBarnameh.SQLWhere = " AnbarSN =" & gAnbarSN & " AND BarnamehDate >=" & gHesabdariSalFDate & _
                              " AND  BarnamehDate<=" & gHesabdariSalTDate & " and BarnamehDate>=" & dclFdate.Value
        dvBarnameh.Refresh()
    End Sub

    Private Sub cboGhabzeAnbar_Enter (ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGhabzeAnbar.Enter
        dvBarnamehHa.Fields ("SanadSN").ComboWhereCondition = " AnbarSN = " & gAnbarSN & " and SanadDate BETWEEN " & _
                                                              gHesabdariSalFDate & " AND " & gHesabdariSalTDate & _
                                                              " and SanadStatus = 8 "
        dvBarnamehHa.Fields ("SanadSN").RefreshCombo()
    End Sub

    Private Sub dvBarnameh_GetGridProperties() Handles dvBarnameh.GetGridProperties
        ' امکان انتخاب گروهي فعال گردد
        With dvBarnameh.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub
End Class
