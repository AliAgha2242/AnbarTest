
Imports VB = Microsoft.VisualBasic

Public Class FrmRptRialiAsnadKAsriEzafeh

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptRialiAsnadKAsriEzafeh
    Private Shared m_InitializingDefInstance As Boolean
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl


    Public Shared Property DefInstance() As FrmRptRialiAsnadKAsriEzafeh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptRialiAsnadKAsriEzafeh
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptRialiAsnadKAsriEzafeh)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub CMP_SetDef_CheckedValues(ByRef aCmp As cmpCheckedComboBox, Optional ByVal aDefults As Decimal = 0.0)
        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(aDefults)
        aCmp.CheckedValues = ArrayLst.ToArray
        aCmp.DroppedDown = True
    End Sub

    Private Sub InitControls()

        Me.WindowState = FormWindowState.Maximized

        Dim onlypreSelected As Boolean
        Dim vVahedeTejariSql As String
        cmbVahedeTejari.LateBinding = True

        cmbVahedeTejari.ShowSelectAll = True
        If onlypreSelected = True Then
            cmbVahedeTejari.Enabled = False
        Else
            cmbVahedeTejari.Enabled = True
        End If

        vVahedeTejariSql = "SELECT top 100 percent  paVahedeTejari.VahedeTejariSN,paVahedeTejari.VahedeTejariDs " & _
          "from paVahedeTejari " & _
          " WHERE OzveGorooh=1 and PedarVahedeTejariSN = 9.935 Order by VahedeTejariDs  "


        cmbVahedeTejari.Bind(cn, vVahedeTejariSql, "VahedeTejariSN", "VahedeTejariDS")

        CMP_SetDef_CheckedValues(cmbVahedeTejari)


        'dclFDate = New NetSql.Components.CDateCtrl(tp)
        'dclFDate.TextBox = txtFromDarkhastDate
        'dclTDate = New NetSql.Components.CDateCtrl(tp)
        'dclTDate.TextBox = txtToDarkhastDate

        'If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
        '    dclFDate.Value = gHesabdariSalFDate
        '    dclTDate.Value = gHesabdariSalTDate

        'Else
        '    ' تهيه تاريخ از سرور
        'dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
        '                                                                       cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
        'dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
        'cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        'End If


        dclFDate = New NetSql.Components.CDateCtrl(tp)
        CmpFarsiDatePickerFrom.IsNull = True
        CmpFarsiDatePickerFrom.SelectedDateTime = Date.Today()
        'NowDate = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, NetSql.Common.CShamsiDate.EnumDateFormat.dfWithSlash) 'gFromDate

        dclTDate = New NetSql.Components.CDateCtrl(tp)
        CmpFarsiDatePickerTO.IsNull = True
        CmpFarsiDatePickerTO.SelectedDateTime = Date.Today()

    End Sub

    Private Sub InitJanus()
        With GridEX1.RootTable.Columns
            With .Add("VahedeTejariDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "واحد تجاری"
            End With
            With .Add("Anbards", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انبار"
            End With
            With .Add("Sanadno", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شماره سند"
            End With
            With .Add("Sanaddate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تاریخ"
            End With
            With .Add("TarakoneshDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش"
            End With
            With .Add("Sanadstatus", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وضعیت سند"
            End With
            With .Add("KalaNO", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شرح کالا"
            End With
            With .Add("MeghdareSadereh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تعداد کسری"
                .FormatString = "#,#.###"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .TotalFormatString = "#,#.###"
            End With
            With .Add("MeghdareVaredeh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تعداد اضافه"
                .FormatString = "#,#.###"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .TotalFormatString = "#,#.###"
            End With
            With .Add("RialeKasri", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "ریال کسری با آخرین نرخ خرید"
                .FormatString = "#,#.###"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .TotalFormatString = "#,#.###"
            End With
            With .Add("RialeSarak", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "ریال اضافه با آخرین نرخ خرید"
                .FormatString = "#,#.###"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .TotalFormatString = "#,#.###"
            End With
            With .Add("Mandeh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "مانده"
                .FormatString = "#,#.###"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .TotalFormatString = "#,#.###"
            End With

        End With

    End Sub

    Private Sub FrmRTarakoneshGorooh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click


        Dim WaitFrm As New Anbar.Common.Frmwait

        Try
            WaitFrm.Show()
            WaitFrm.Refresh()


            If cmbVahedeTejari.getStringValues = "" Then
                NetSql.Common.CSystem.MsgBox("واحد تجاری مشخص نشده است", _
                           MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                           MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim vFromDate As String = ""
            Dim vToDate As String = ""
            Dim vErrMsg As String
            Dim _VahedeTejari As String
            'Dim _Anbar As String

            If Trim(CmpFarsiDatePickerFrom.Text) <> "" Then
                vFromDate = GetDateValue(CmpFarsiDatePickerFrom.Text)
            Else
                vErrMsg = vErrMsg & Chr(13) & " تاريخ ابتدا مشخص نشده است"
            End If

            If Trim(CmpFarsiDatePickerTO.Text) <> "" Then
                vToDate = GetDateValue(CmpFarsiDatePickerTO.Text)
            Else
                vErrMsg = vErrMsg & Chr(13) & " تاريخ انتها مشخص نشده است"
            End If

            _VahedeTejari = cmbVahedeTejari.getStringValues()

            GridEX1.DataSource = cn.SPQuery("_abSPR_RialiAsnadKasriEzafehAbarGardani", _VahedeTejari, "0", vFromDate, vToDate)

            RefreshDataSet()

            Me.Cursor = System.Windows.Forms.Cursors.Default()

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            WaitFrm.Close()
        End Try


    End Sub

    Private Sub dbcAnbar_Enter(sender As Object, e As System.EventArgs)
        '    Dim _str As String = ""
        '    If Not dbcVahedeTejariNo.CheckedItems Is Nothing Then
        '        For i As Integer = 0 To dbcVahedeTejariNo.CheckedItems.Length - 1
        '            _str = _str + CType(dbcVahedeTejariNo.CheckedItems(i), DataRowView).Item("VahedeTejariSN").ToString + ","
        '        Next
        '        If _str.Length > 1 Then
        '            _str = _str.Substring(0, Len(_str) - 1)
        '        End If
        '    End If

        '    dbcAnbar.DropDownDataSource = _
        'cn.ExecuteQuery("Select AnbarSN,AnbarDS AS AnbarName FROM abAnbar WHERE VahedeTejariSN in (" & _str & ")")

        '    dbcAnbar.DropDownDataMember = "AnbarDS"
        '    dbcAnbar.DropDownValueMember = "AnbarSN"
        '    dbcAnbar.DropDownDisplayMember = "AnbarDS"

    End Sub

End Class
