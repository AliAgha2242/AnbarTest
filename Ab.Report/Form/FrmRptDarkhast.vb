'Author ::زهره ايزدپناه
'CreateDate :: 1387/11/19
'ModifiedDate::
'Description:: گزارش مرورتفصیلی اسناد انبار
'System ::انبار

Imports VB = Microsoft.VisualBasic

Public Class FrmRptDarkhast
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
  Public WithEvents dcbKala As NetSql.Components.DataCombo
  Public WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents FraSanadStaus As System.Windows.Forms.GroupBox
  Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents pnlSanadNO As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents lbl1 As System.Windows.Forms.Label
  Friend WithEvents chkDarkhastStatus_1 As System.Windows.Forms.CheckBox
  Friend WithEvents chkDarkhastStatus_8 As System.Windows.Forms.CheckBox
  Friend WithEvents chkDarkhastStatus_16 As System.Windows.Forms.CheckBox
  Friend WithEvents chkDarkhastStatus_12 As System.Windows.Forms.CheckBox
  Friend WithEvents txtFromDarkhastDate As System.Windows.Forms.TextBox
  Friend WithEvents txtToDarkhastDate As System.Windows.Forms.TextBox
  Friend WithEvents txtToDarkhastNO As System.Windows.Forms.TextBox
    Friend WithEvents txtFromDarkhastNO As System.Windows.Forms.TextBox
    Friend WithEvents chkFormat As System.Windows.Forms.CheckBox
    Friend WithEvents chkDarkhastStatus_4 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraSanadStaus = New System.Windows.Forms.GroupBox()
        Me.chkDarkhastStatus_1 = New System.Windows.Forms.CheckBox()
        Me.chkDarkhastStatus_4 = New System.Windows.Forms.CheckBox()
        Me.chkDarkhastStatus_8 = New System.Windows.Forms.CheckBox()
        Me.chkDarkhastStatus_16 = New System.Windows.Forms.CheckBox()
        Me.chkDarkhastStatus_12 = New System.Windows.Forms.CheckBox()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromDarkhastDate = New System.Windows.Forms.TextBox()
        Me.txtToDarkhastDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlSanadNO = New System.Windows.Forms.Panel()
        Me.txtToDarkhastNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromDarkhastNO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.chkFormat = New System.Windows.Forms.CheckBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.FraSanadStaus.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.pnlSanadNO.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.chkFormat)
        Me.pnlF.Controls.Add(Me.pnlSanadNO)
        Me.pnlF.Controls.Add(Me.FraSanadStaus)
        Me.pnlF.Controls.Add(Me.FraSanadDate)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadStaus, 0)
        Me.pnlF.Controls.SetChildIndex(Me.pnlSanadNO, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.chkFormat, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(7, 30)
        Me.btnViewReport.Size = New System.Drawing.Size(73, 30)
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(189, 6)
        Me.btnFilter.Size = New System.Drawing.Size(60, 25)
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(6, 6)
        Me.btnReturn.Size = New System.Drawing.Size(60, 25)
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 426)
        '
        'pnlCommand
        '
        Me.pnlCommand.Size = New System.Drawing.Size(312, 36)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
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
        Me.btnExcelList.Location = New System.Drawing.Point(66, 6)
        Me.btnExcelList.Size = New System.Drawing.Size(60, 25)
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(80, 30)
        Me.btnChart.Size = New System.Drawing.Size(73, 30)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(249, 6)
        Me.btnPrint.Size = New System.Drawing.Size(60, 25)
        '
        'btnSettingList
        '
        Me.btnSettingList.Location = New System.Drawing.Point(128, 6)
        Me.btnSettingList.Size = New System.Drawing.Size(60, 25)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(7, 7)
        Me.btnCancel.Size = New System.Drawing.Size(60, 26)
        '
        'btnExcell
        '
        Me.btnExcell.Location = New System.Drawing.Point(767, 470)
        Me.btnExcell.Size = New System.Drawing.Size(6, 23)
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(318, 3)
        Me.btnModify.Size = New System.Drawing.Size(61, 27)
        '
        'dcbKala
        '
        Me.dcbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala.AutoSelectFirst = False
        Me.dcbKala.BackColor = System.Drawing.Color.White
        Me.dcbKala.BoundText = Nothing
        Me.dcbKala.BypassChangeEvent = False
        Me.dcbKala.DisplayText = ""
        Me.dcbKala.LateBindingTop = "100"
        Me.dcbKala.Location = New System.Drawing.Point(656, 7)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(327, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(993, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadStaus
        '
        Me.FraSanadStaus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadStaus.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadStaus.Controls.Add(Me.chkDarkhastStatus_1)
        Me.FraSanadStaus.Controls.Add(Me.chkDarkhastStatus_4)
        Me.FraSanadStaus.Controls.Add(Me.chkDarkhastStatus_8)
        Me.FraSanadStaus.Controls.Add(Me.chkDarkhastStatus_16)
        Me.FraSanadStaus.Controls.Add(Me.chkDarkhastStatus_12)
        Me.FraSanadStaus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadStaus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadStaus.Location = New System.Drawing.Point(411, 32)
        Me.FraSanadStaus.Name = "FraSanadStaus"
        Me.FraSanadStaus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadStaus.Size = New System.Drawing.Size(390, 39)
        Me.FraSanadStaus.TabIndex = 51
        Me.FraSanadStaus.TabStop = False
        Me.FraSanadStaus.Text = "وضعيت"
        '
        'chkDarkhastStatus_1
        '
        Me.chkDarkhastStatus_1.BackColor = System.Drawing.SystemColors.Control
        Me.chkDarkhastStatus_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDarkhastStatus_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDarkhastStatus_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkDarkhastStatus_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDarkhastStatus_1.Location = New System.Drawing.Point(322, 16)
        Me.chkDarkhastStatus_1.Name = "chkDarkhastStatus_1"
        Me.chkDarkhastStatus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDarkhastStatus_1.Size = New System.Drawing.Size(56, 21)
        Me.chkDarkhastStatus_1.TabIndex = 2
        Me.chkDarkhastStatus_1.Text = "موقت"
        Me.chkDarkhastStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_1.UseVisualStyleBackColor = False
        '
        'chkDarkhastStatus_4
        '
        Me.chkDarkhastStatus_4.BackColor = System.Drawing.SystemColors.Control
        Me.chkDarkhastStatus_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_4.Checked = True
        Me.chkDarkhastStatus_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDarkhastStatus_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDarkhastStatus_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDarkhastStatus_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkDarkhastStatus_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDarkhastStatus_4.Location = New System.Drawing.Point(271, 16)
        Me.chkDarkhastStatus_4.Name = "chkDarkhastStatus_4"
        Me.chkDarkhastStatus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDarkhastStatus_4.Size = New System.Drawing.Size(46, 21)
        Me.chkDarkhastStatus_4.TabIndex = 3
        Me.chkDarkhastStatus_4.Text = "تاييد"
        Me.chkDarkhastStatus_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_4.UseVisualStyleBackColor = False
        '
        'chkDarkhastStatus_8
        '
        Me.chkDarkhastStatus_8.BackColor = System.Drawing.SystemColors.Control
        Me.chkDarkhastStatus_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_8.Checked = True
        Me.chkDarkhastStatus_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDarkhastStatus_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDarkhastStatus_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDarkhastStatus_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkDarkhastStatus_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDarkhastStatus_8.Location = New System.Drawing.Point(168, 16)
        Me.chkDarkhastStatus_8.Name = "chkDarkhastStatus_8"
        Me.chkDarkhastStatus_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDarkhastStatus_8.Size = New System.Drawing.Size(91, 21)
        Me.chkDarkhastStatus_8.TabIndex = 4
        Me.chkDarkhastStatus_8.Text = "در حال ارسال"
        Me.chkDarkhastStatus_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_8.UseVisualStyleBackColor = False
        '
        'chkDarkhastStatus_16
        '
        Me.chkDarkhastStatus_16.BackColor = System.Drawing.SystemColors.Control
        Me.chkDarkhastStatus_16.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDarkhastStatus_16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDarkhastStatus_16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkDarkhastStatus_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDarkhastStatus_16.Location = New System.Drawing.Point(68, 16)
        Me.chkDarkhastStatus_16.Name = "chkDarkhastStatus_16"
        Me.chkDarkhastStatus_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDarkhastStatus_16.Size = New System.Drawing.Size(91, 21)
        Me.chkDarkhastStatus_16.TabIndex = 4
        Me.chkDarkhastStatus_16.Text = "ارسال شده"
        Me.chkDarkhastStatus_16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_16.UseVisualStyleBackColor = False
        '
        'chkDarkhastStatus_12
        '
        Me.chkDarkhastStatus_12.BackColor = System.Drawing.SystemColors.Control
        Me.chkDarkhastStatus_12.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_12.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDarkhastStatus_12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDarkhastStatus_12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkDarkhastStatus_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDarkhastStatus_12.Location = New System.Drawing.Point(8, 16)
        Me.chkDarkhastStatus_12.Name = "chkDarkhastStatus_12"
        Me.chkDarkhastStatus_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDarkhastStatus_12.Size = New System.Drawing.Size(56, 21)
        Me.chkDarkhastStatus_12.TabIndex = 4
        Me.chkDarkhastStatus_12.Text = "بايگاني"
        Me.chkDarkhastStatus_12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDarkhastStatus_12.UseVisualStyleBackColor = False
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromDarkhastDate)
        Me.FraSanadDate.Controls.Add(Me.txtToDarkhastDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(171, 32)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(232, 39)
        Me.FraSanadDate.TabIndex = 50
        Me.FraSanadDate.TabStop = False
        '
        'txtFromDarkhastDate
        '
        Me.txtFromDarkhastDate.AcceptsReturn = True
        Me.txtFromDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromDarkhastDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromDarkhastDate.MaxLength = 0
        Me.txtFromDarkhastDate.Name = "txtFromDarkhastDate"
        Me.txtFromDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromDarkhastDate.TabIndex = 5
        Me.txtFromDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToDarkhastDate
        '
        Me.txtToDarkhastDate.AcceptsReturn = True
        Me.txtToDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDarkhastDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToDarkhastDate.MaxLength = 0
        Me.txtToDarkhastDate.Name = "txtToDarkhastDate"
        Me.txtToDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToDarkhastDate.TabIndex = 6
        Me.txtToDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label10.Location = New System.Drawing.Point(188, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlSanadNO
        '
        Me.pnlSanadNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSanadNO.Controls.Add(Me.txtToDarkhastNO)
        Me.pnlSanadNO.Controls.Add(Me.Label2)
        Me.pnlSanadNO.Controls.Add(Me.txtFromDarkhastNO)
        Me.pnlSanadNO.Controls.Add(Me.Label9)
        Me.pnlSanadNO.Controls.Add(Me.lbl1)
        Me.pnlSanadNO.Location = New System.Drawing.Point(165, 4)
        Me.pnlSanadNO.Name = "pnlSanadNO"
        Me.pnlSanadNO.Size = New System.Drawing.Size(488, 29)
        Me.pnlSanadNO.TabIndex = 52
        '
        'txtToDarkhastNO
        '
        Me.txtToDarkhastNO.Location = New System.Drawing.Point(7, 5)
        Me.txtToDarkhastNO.MaxLength = 15
        Me.txtToDarkhastNO.Name = "txtToDarkhastNO"
        Me.txtToDarkhastNO.Size = New System.Drawing.Size(165, 21)
        Me.txtToDarkhastNO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(172, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "تا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFromDarkhastNO
        '
        Me.txtFromDarkhastNO.Location = New System.Drawing.Point(209, 5)
        Me.txtFromDarkhastNO.MaxLength = 15
        Me.txtFromDarkhastNO.Name = "txtFromDarkhastNO"
        Me.txtFromDarkhastNO.Size = New System.Drawing.Size(165, 21)
        Me.txtFromDarkhastNO.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(374, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "از"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(399, 7)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(81, 13)
        Me.lbl1.TabIndex = 27
        Me.lbl1.Text = "شماره درخواست"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFormat
        '
        Me.chkFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFormat.BackColor = System.Drawing.SystemColors.Control
        Me.chkFormat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFormat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkFormat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFormat.Location = New System.Drawing.Point(808, 42)
        Me.chkFormat.Name = "chkFormat"
        Me.chkFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFormat.Size = New System.Drawing.Size(208, 21)
        Me.chkFormat.TabIndex = 53
        Me.chkFormat.Text = "خلاصه در سطح تعداد درخواست"
        Me.chkFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFormat.UseVisualStyleBackColor = False
        '
        'FrmRptDarkhast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmRptDarkhast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش درخواست کالا از انبار"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.FraSanadStaus.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.pnlSanadNO.ResumeLayout(False)
        Me.pnlSanadNO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmRptDarkhast
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmRptDarkhast
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptDarkhast
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptDarkhast)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Private Variable"
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region

    Private Sub FrmTafsiliRialiA_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        '' Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = "SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION  SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        setColumnProperties(0)
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        End If

    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnViewReport.Click
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String
        Dim strAnbars As String
        Dim strTarakoneshs As String
        Dim vStrKalaSN As String
        Dim vDarkhastStatus As String = ""
        Dim vFromDarkhastNo, vToDarkhastNo As String
        Dim vFormat As Integer = 0


        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr(gAnbarSN)
        End If

        If (txtFromDarkhastNO.Text.Trim.Length > 0 AndAlso txtToDarkhastNO.Text.Trim.Length = 0) Then
            vErrMsg = vErrMsg & "تا شماره درخواست مشخص نشده است " & vbCrLf
        End If

        If (txtFromDarkhastNO.Text.Trim.Length = 0 AndAlso txtToDarkhastNO.Text.Trim.Length > 0) Then
            vErrMsg = vErrMsg & "از شماره درخواست مشخص نشده است " & vbCrLf
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then

            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If

            If chkDarkhastStatus_1.Checked Then
                vDarkhastStatus += IIf(vDarkhastStatus.Length > 0, ",", "") & " 1 "
            End If
            If chkDarkhastStatus_4.Checked Then
                vDarkhastStatus += IIf(vDarkhastStatus.Length > 0, ",", "") & " 4 "
            End If
            If chkDarkhastStatus_8.Checked Then
                vDarkhastStatus += IIf(vDarkhastStatus.Length > 0, ",", "") & " 8 "
            End If
            If chkDarkhastStatus_12.Checked Then
                vDarkhastStatus += IIf(vDarkhastStatus.Length > 0, ",", "") & " 12 "
            End If
            If chkDarkhastStatus_16.Checked Then
                vDarkhastStatus += IIf(vDarkhastStatus.Length > 0, ",", "") & " 16 "
            End If

            vFromDarkhastNo = txtFromDarkhastNO.Text.Trim
            vToDarkhastNo = txtToDarkhastNO.Text.Trim

            If Trim(dcbKala.BoundText) <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If vStrKalaSN <> "" Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If

            End If

            If chkFormat.Checked = True Then
                vFormat = 1
            End If

            Me.Cursor = Cursors.WaitCursor

            GridEX1.DataSource = cn.SPQuery("_abSpr_Darkhast", gVahedeTejariSN, strAnbars _
                                                , vFromDate, vToDate, vStrKalaSN, vDarkhastStatus _
                                                      , strTarakoneshs, vFromDarkhastNo, vToDarkhastNo, DBNull.Value, vFormat)

            'RefreshDataSet()
            Me.Cursor = Cursors.Default
            GridEX1.RootTable.Columns.Clear()
            setColumnProperties(vFormat)

        Else
            Netsql.common.csystem.MsgBox(vErrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub setColumnProperties(ByVal vFormat As Integer)
        Dim dvTableFooter As DataView
        Dim i As Integer
        If vFormat = 0 Then
            dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Darkhast' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
            For i = 0 To dvTableFooter.Count - 1
                With GridEX1.RootTable.Columns()
                    With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

                    End With

                End With
            Next
            GridEX1.RootTable.Columns("MeghdareDarkhasti").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("MeghdareDarkhasti").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("MeghdareDarkhasti").TotalFormatString = "#,#.###"

            GridEX1.RootTable.Columns("MeghdareErsalShode").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("MeghdareErsalShode").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("MeghdareErsalShode").TotalFormatString = "#,#.###"

            GridEX1.RootTable.Columns("Darkhasti_Box").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("Darkhasti_Box").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("Darkhasti_Box").TotalFormatString = "#,#.###"

            GridEX1.RootTable.Columns("Darkhasti_Can").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("Darkhasti_Can").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("Darkhasti_Can").TotalFormatString = "#,#.###"

            GridEX1.RootTable.Columns("ErsalShode_Box").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("ErsalShode_Box").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("ErsalShode_Box").TotalFormatString = "#,#.###"

            GridEX1.RootTable.Columns("ErsalShode_Can").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            GridEX1.RootTable.Columns("ErsalShode_Can").FormatString = "#,#.###"
            GridEX1.RootTable.Columns("ErsalShode_Can").TotalFormatString = "#,#.###"
        Else
            With GridEX1.RootTable.Columns
                With .Add("VahedetejariNo")
                    .Caption = "کد واحد تجاری"
                    .Visible = False
                End With
                With .Add("VahedetejariDS")
                    .Caption = "واحد تجاری"
                End With
                With .Add("AnbarNo")
                    .Caption = "کد انبار"
                    .Visible = False
                End With
                With .Add("AnbarDS")
                    .Caption = "انبار"
                End With
                With .Add("TafsiliDS")
                    .Caption = "طرف حساب"
                End With
                With .Add("TarakoneshDS")
                    .Caption = "تراکنش"
                End With
                With .Add("DarkhastStatusDS")
                    .Caption = "وضعیت درخواست"
                End With
                With .Add("CountDarkhast")
                    .Caption = "تعداد درخواست"
                End With
            End With

        End If

    End Sub

End Class


