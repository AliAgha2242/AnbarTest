'Author ::زهره ايزدپناه
'CreateDate :: 1387/10/20
'ModifiedDate::
'Description:: گزارش ليست کاردکس انبار
'System ::انبار

Imports Janus.Windows.GridEX
Imports VB = Microsoft.VisualBasic

Public Class FrmRptHotSale
    Inherits JanusSimpleReport.frmRptJanusBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents dcbTafsili As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromSanadDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToSanadDate As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    'Friend WithEvents FraSanadStaus As System.Windows.Forms.GroupBox
    Friend WithEvents chkSanadStatus_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_8 As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptHotSale))
        Me.dcbTafsili = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromSanadDate = New System.Windows.Forms.TextBox()
        Me.txtToSanadDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkSanadStatus_1 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_4 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_8 = New System.Windows.Forms.CheckBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.FraSanadDate)
        Me.pnlF.Controls.Add(Me.dcbTafsili)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbTafsili, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadDate, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.TabIndex = 10
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 426)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.GroupTotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(1028, 426)
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.TotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.TotalRowFormatStyle.Key = "سرجمع"
        Me.GridEX1.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        Me.GridEX1.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'btnExcelList
        '
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.TabStop = False
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'dcbTafsili
        '
        Me.dcbTafsili.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbTafsili.AutoSelectFirst = False
        Me.dcbTafsili.BackColor = System.Drawing.Color.White
        Me.dcbTafsili.BoundText = Nothing
        Me.dcbTafsili.BypassChangeEvent = False
        Me.dcbTafsili.DisplayText = ""
        Me.dcbTafsili.LateBindingTop = "100"
        Me.dcbTafsili.Location = New System.Drawing.Point(567, 3)
        Me.dcbTafsili.MemFilter = ""
        Me.dcbTafsili.Name = "dcbTafsili"
        Me.dcbTafsili.SeparatedData = Nothing
        Me.dcbTafsili.Size = New System.Drawing.Size(327, 21)
        Me.dcbTafsili.Source = Nothing
        Me.dcbTafsili.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbTafsili.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(899, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "طرف حساب :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromSanadDate)
        Me.FraSanadDate.Controls.Add(Me.txtToSanadDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(758, 30)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(221, 39)
        Me.FraSanadDate.TabIndex = 11
        Me.FraSanadDate.TabStop = False
        '
        'txtFromSanadDate
        '
        Me.txtFromSanadDate.AcceptsReturn = True
        Me.txtFromSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSanadDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSanadDate.MaxLength = 0
        Me.txtFromSanadDate.Name = "txtFromSanadDate"
        Me.txtFromSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSanadDate.TabIndex = 0
        Me.txtFromSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSanadDate
        '
        Me.txtToSanadDate.AcceptsReturn = True
        Me.txtToSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSanadDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSanadDate.MaxLength = 0
        Me.txtToSanadDate.Name = "txtToSanadDate"
        Me.txtToSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSanadDate.TabIndex = 1
        Me.txtToSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(175, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "از"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(82, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(187, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkSanadStatus_1
        '
        Me.chkSanadStatus_1.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_1.Location = New System.Drawing.Point(119, 13)
        Me.chkSanadStatus_1.Name = "chkSanadStatus_1"
        Me.chkSanadStatus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_1.Size = New System.Drawing.Size(81, 21)
        Me.chkSanadStatus_1.TabIndex = 0
        Me.chkSanadStatus_1.Text = "پيشنويس"
        Me.chkSanadStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_4
        '
        Me.chkSanadStatus_4.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_4.Location = New System.Drawing.Point(58, 13)
        Me.chkSanadStatus_4.Name = "chkSanadStatus_4"
        Me.chkSanadStatus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_4.Size = New System.Drawing.Size(59, 21)
        Me.chkSanadStatus_4.TabIndex = 1
        Me.chkSanadStatus_4.Text = "موقت"
        Me.chkSanadStatus_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_8
        '
        Me.chkSanadStatus_8.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.Checked = True
        Me.chkSanadStatus_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSanadStatus_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_8.Location = New System.Drawing.Point(1, 13)
        Me.chkSanadStatus_8.Name = "chkSanadStatus_8"
        Me.chkSanadStatus_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_8.Size = New System.Drawing.Size(55, 21)
        Me.chkSanadStatus_8.TabIndex = 2
        Me.chkSanadStatus_8.Text = "قطعي"
        Me.chkSanadStatus_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.UseVisualStyleBackColor = False
        '
        'FrmRptHotSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmRptHotSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فروش گرم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptHotSale
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptHotSale
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptHotSale
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptHotSale)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region

    Private Sub FrmRptHotSale_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromSanadDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToSanadDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                                  cn,
                                                                                                  Functions.
                                                                                                     FTDBCommonFunctions _
                                                                                                     .enmDateFormat.
                                                                                                     Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                         cn,
                                                                                         Functions.FTDBCommonFunctions.
                                                                                            enmDateFormat.Normal)

        End If


        vSql =
            $"select 0 as tafsilisn,'همه موارد' as TafsiliDs
            union
            select TafsiliSN,TafsiliDs from matafsili where tafsilisn in (select tafsilisn from abSanad where sanaddate between '{gHesabdariSalFDate}'and  '{gHesabdariSalTDate}' and TarakoneshSN = 79)
            "
        dcbTafsili.LateBinding = True
        dcbTafsili.Bind(cn, vSql, "tafsilisn", "tafsiliDs")

        setColumnProperties()

        RefreshDataSet()


    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click

        Dim FromDate As String
        Dim ToDate As String
        Dim vErrMsg As String
        Dim strAnbars As String
        Dim TafsiliSN As String
        Dim frmWait As New Anbar.Common.Frmwait
        frmWait.Show()
        frmWait.Label3.Text = "...سیستم در حال گزارش گیری می باشد..."
        frmWait.Refresh()

        Try
            If Trim(dclFDate.Text) <> "" Then
                FromDate = Trim(dclFDate.Value)
            Else
                vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
            End If

            If Trim(dclTDate.Text) <> "" Then
                ToDate = Trim(dclTDate.Value)
            Else
                vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
            End If

            If Trim(FromDate) < Trim(gHesabdariSalFDate) Or Trim(ToDate) > Trim(gHesabdariSalTDate) Then
                vErrMsg = vErrMsg & Chr(13) & "تاريخ انتخابي خارج از سال مالي مي باشد"
            End If

            If gAnbarSN = 0 Then
                vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
            Else
                strAnbars = CStr(gAnbarSN)
            End If
            If dcbTafsili.SelectedValue Is Nothing Then
                vErrMsg = "طرف حساب مشخص نشده است"
            End If

            'If dcbTafsili.BoundText <> "" AndAlso Trim(dcbTafsili.SelectedValue) <> 0 Then
            '    If Not TafsiliSN Is Nothing AndAlso TafsiliSN.Length > 0 Then
            '        TafsiliSN = CStr(dcbTafsili.SelectedValue)
            '    Else
            '        TafsiliSN = CStr(dcbTafsili.SelectedValue)
            '    End If
            'End If
            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg,
                          MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                          MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If





            Dim query As String = $"abSpr_GetHotSaleData '{FromDate}' , '{ToDate}' ,{CDec(dcbTafsili.SelectedValue)}"
            GridEX1.DataSource = cn.ExecuteQuery(query)

            Dim i As Integer = 1
            For i = 0 To GridEX1.RootTable.Columns.Count - 1
                GridEX1.RootTable.Columns(i).AutoSize()
            Next

            'grouping by 
            GridEX1.RootTable.Groups.Clear()
            If GridEX1.RootTable.Columns.Contains("sanadNO") Then
                Dim group As New GridEXGroup(GridEX1.RootTable.Columns("SanadNO"))
                GridEX1.RootTable.Groups.Add(group)
                GridEX1.Refresh()
            End If

            'Tartib 
            If GridEX1.RootTable.Columns.Contains("adad") AndAlso GridEX1.RootTable.Columns.Contains("karton") AndAlso GridEX1.RootTable.Columns.Contains("tedadKol") Then
                Dim maxPosition As Integer = GridEX1.RootTable.Columns.Count - 1
                GridEX1.RootTable.Columns("adad").Position = maxPosition
                GridEX1.RootTable.Columns("karton").Position = maxPosition - 1
                GridEX1.RootTable.Columns("tedadKol").Position = maxPosition - 2

            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        Finally
            frmWait.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter =
            cn.ExecuteQuery(
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = 
                             T2.ObjectSN WHERE T1.ObjectSn=448.935 ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")
                    .AllowSort = False
                End With
            End With
        Next
    End Sub



End Class
