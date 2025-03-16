Imports Janus.Windows.GridEX
Imports Anbar.BRL
Imports Janus.Windows.GridEX.Export

Public Class FrmabSanadBarcodeReader
    Inherits Minoo.Base.FTBaseForm
    Private components As System.ComponentModel.IContainer
    Private Shared m_vb6formdefinstance As FrmabSanadBarcodeReader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnSabtResid As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnRefreshData As Janus.Windows.EditControls.UIButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageAggregateScan As TabPage
    Friend WithEvents TabPageScanRecords As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridBarcodeMaster As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GridBarcodeDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridBarcodeTajmie As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As Label
    Public WithEvents dcbanbarStatus As NetSql.Components.DataCombo
    Friend WithEvents GrpDate As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtToDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents LinkRemoveFilter As LinkLabel
    Friend WithEvents ChkGetLastData As CheckBox
    Friend WithEvents LinkSaveLayout As LinkLabel
    Friend WithEvents LinkLoadLayout As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbUseColumnSets As RadioButton
    Friend WithEvents RdbUseColumns As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAnbarGardaniCatalogue As Janus.Windows.EditControls.UIButton
    Friend WithEvents TabPageKasriEzafi As TabPage
    Friend WithEvents GridBarcodeRptKasriEzafi As GridEX
    Friend WithEvents ChkTikWithoutMoghayerat As CheckBox
    Friend WithEvents LinkExcelReportAnbargardani As LinkLabel
    Friend WithEvents LinkLabelEbtalSabt As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents LinkExportExcelBarcodeTajmie As LinkLabel
    Friend WithEvents LinkExportExcelBarcodeMaster As LinkLabel
    Private WithEvents dataView As CDataView
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

    Public Shared Property DefInstance() As FrmabSanadBarcodeReader

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabSanadBarcodeReader
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabSanadBarcodeReader)
            m_vb6formdefinstance = Value

        End Set

    End Property


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridBarcodeTajmie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabSanadBarcodeReader))
        Dim GridBarcodeMaster_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridBarcodeDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridBarcodeRptKasriEzafi_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkTikWithoutMoghayerat = New System.Windows.Forms.CheckBox()
        Me.BtnAnbarGardaniCatalogue = New Janus.Windows.EditControls.UIButton()
        Me.ChkGetLastData = New System.Windows.Forms.CheckBox()
        Me.GrpDate = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dcbanbarStatus = New NetSql.Components.DataCombo(Me.components)
        Me.BtnSabtResid = New Janus.Windows.EditControls.UIButton()
        Me.BtnRefreshData = New Janus.Windows.EditControls.UIButton()
        Me.LinkLoadLayout = New System.Windows.Forms.LinkLabel()
        Me.LinkSaveLayout = New System.Windows.Forms.LinkLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageAggregateScan = New System.Windows.Forms.TabPage()
        Me.LinkExportExcelBarcodeTajmie = New System.Windows.Forms.LinkLabel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbUseColumnSets = New System.Windows.Forms.RadioButton()
        Me.RdbUseColumns = New System.Windows.Forms.RadioButton()
        Me.GridBarcodeTajmie = New Janus.Windows.GridEX.GridEX()
        Me.TabPageScanRecords = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkExportExcelBarcodeMaster = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelEbtalSabt = New System.Windows.Forms.LinkLabel()
        Me.LinkRemoveFilter = New System.Windows.Forms.LinkLabel()
        Me.GridBarcodeMaster = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GridBarcodeDetail = New Janus.Windows.GridEX.GridEX()
        Me.TabPageKasriEzafi = New System.Windows.Forms.TabPage()
        Me.LinkExcelReportAnbargardani = New System.Windows.Forms.LinkLabel()
        Me.GridBarcodeRptKasriEzafi = New Janus.Windows.GridEX.GridEX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.GrpDate.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageAggregateScan.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridBarcodeTajmie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageScanRecords.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridBarcodeDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageKasriEzafi.SuspendLayout()
        CType(Me.GridBarcodeRptKasriEzafi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ChkTikWithoutMoghayerat)
        Me.Panel3.Controls.Add(Me.BtnAnbarGardaniCatalogue)
        Me.Panel3.Controls.Add(Me.ChkGetLastData)
        Me.Panel3.Controls.Add(Me.GrpDate)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dcbanbarStatus)
        Me.Panel3.Controls.Add(Me.BtnSabtResid)
        Me.Panel3.Controls.Add(Me.BtnRefreshData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1368, 65)
        Me.Panel3.TabIndex = 2
        '
        'ChkTikWithoutMoghayerat
        '
        Me.ChkTikWithoutMoghayerat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ChkTikWithoutMoghayerat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkTikWithoutMoghayerat.Location = New System.Drawing.Point(239, 3)
        Me.ChkTikWithoutMoghayerat.Name = "ChkTikWithoutMoghayerat"
        Me.ChkTikWithoutMoghayerat.Size = New System.Drawing.Size(193, 52)
        Me.ChkTikWithoutMoghayerat.TabIndex = 217
        Me.ChkTikWithoutMoghayerat.Text = "موارد بدون مغایرت و بدون کسری اضافی تیک زده شود"
        Me.ChkTikWithoutMoghayerat.UseVisualStyleBackColor = False
        Me.ChkTikWithoutMoghayerat.Visible = False
        '
        'BtnAnbarGardaniCatalogue
        '
        Me.BtnAnbarGardaniCatalogue.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnAnbarGardaniCatalogue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnAnbarGardaniCatalogue.Location = New System.Drawing.Point(111, 3)
        Me.BtnAnbarGardaniCatalogue.Name = "BtnAnbarGardaniCatalogue"
        Me.BtnAnbarGardaniCatalogue.Office2007CustomColor = System.Drawing.Color.PaleGreen
        Me.BtnAnbarGardaniCatalogue.Size = New System.Drawing.Size(119, 55)
        Me.BtnAnbarGardaniCatalogue.TabIndex = 216
        Me.BtnAnbarGardaniCatalogue.Text = "تایید ردیف "
        Me.BtnAnbarGardaniCatalogue.Visible = False
        Me.BtnAnbarGardaniCatalogue.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'ChkGetLastData
        '
        Me.ChkGetLastData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkGetLastData.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ChkGetLastData.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkGetLastData.ForeColor = System.Drawing.Color.Black
        Me.ChkGetLastData.Location = New System.Drawing.Point(545, 3)
        Me.ChkGetLastData.Name = "ChkGetLastData"
        Me.ChkGetLastData.Size = New System.Drawing.Size(181, 55)
        Me.ChkGetLastData.TabIndex = 215
        Me.ChkGetLastData.Text = "آخرین اطلاعات از سرور مرکزی دریافت گردد"
        Me.ChkGetLastData.UseVisualStyleBackColor = False
        Me.ChkGetLastData.Visible = False
        '
        'GrpDate
        '
        Me.GrpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpDate.Controls.Add(Me.Label2)
        Me.GrpDate.Controls.Add(Me.Label1)
        Me.GrpDate.Controls.Add(Me.TxtToDate)
        Me.GrpDate.Controls.Add(Me.TxtFromDate)
        Me.GrpDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GrpDate.Location = New System.Drawing.Point(1047, 3)
        Me.GrpDate.Name = "GrpDate"
        Me.GrpDate.Size = New System.Drawing.Size(313, 52)
        Me.GrpDate.TabIndex = 214
        Me.GrpDate.TabStop = False
        Me.GrpDate.Text = "تاریخ اسکن محصول"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "تا تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "از تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtToDate
        '
        Me.TxtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtToDate.Location = New System.Drawing.Point(7, 17)
        Me.TxtToDate.Mask = "9900/90/90"
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 177
        Me.TxtToDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.IsDefault = True
        Me.TxtFromDate.Location = New System.Drawing.Point(159, 17)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(92, 20)
        Me.TxtFromDate.TabIndex = 176
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(965, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "وضعیت انبار : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dcbanbarStatus
        '
        Me.dcbanbarStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbanbarStatus.AutoSelectFirst = True
        Me.dcbanbarStatus.BackColor = System.Drawing.Color.White
        Me.dcbanbarStatus.BoundText = Nothing
        Me.dcbanbarStatus.BypassChangeEvent = False
        Me.dcbanbarStatus.DisplayText = ""
        Me.dcbanbarStatus.Items.AddRange(New Object() {"1. آخرین نرخ خرید به تاریخ امروز", "2. آخرین نرخ فروش به تاریخ امروز", "3. آخرین نرخ خرید به تاریخ سند", "4. آخرین نرخ فروش به تاریخ سند"})
        Me.dcbanbarStatus.LateBindingTop = "100"
        Me.dcbanbarStatus.Location = New System.Drawing.Point(828, 25)
        Me.dcbanbarStatus.MemFilter = ""
        Me.dcbanbarStatus.Name = "dcbanbarStatus"
        Me.dcbanbarStatus.SeparatedData = Nothing
        Me.dcbanbarStatus.Size = New System.Drawing.Size(213, 22)
        Me.dcbanbarStatus.Source = Nothing
        Me.dcbanbarStatus.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbanbarStatus.TabIndex = 212
        '
        'BtnSabtResid
        '
        Me.BtnSabtResid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnSabtResid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabtResid.Location = New System.Drawing.Point(6, 3)
        Me.BtnSabtResid.Name = "BtnSabtResid"
        Me.BtnSabtResid.Office2007CustomColor = System.Drawing.Color.PaleGreen
        Me.BtnSabtResid.Size = New System.Drawing.Size(99, 55)
        Me.BtnSabtResid.TabIndex = 208
        Me.BtnSabtResid.Text = "تایید و ثبت رسید در انبار"
        Me.BtnSabtResid.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnRefreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshData.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRefreshData.Location = New System.Drawing.Point(732, 3)
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Blue
        Me.BtnRefreshData.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.BtnRefreshData.Size = New System.Drawing.Size(90, 55)
        Me.BtnRefreshData.TabIndex = 207
        Me.BtnRefreshData.Text = "بروزرسانی اطلاعات"
        Me.BtnRefreshData.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'LinkLoadLayout
        '
        Me.LinkLoadLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLoadLayout.AutoSize = True
        Me.LinkLoadLayout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkLoadLayout.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkLoadLayout.LinkColor = System.Drawing.Color.Red
        Me.LinkLoadLayout.Location = New System.Drawing.Point(498, 13)
        Me.LinkLoadLayout.Name = "LinkLoadLayout"
        Me.LinkLoadLayout.Size = New System.Drawing.Size(84, 14)
        Me.LinkLoadLayout.TabIndex = 219
        Me.LinkLoadLayout.TabStop = True
        Me.LinkLoadLayout.Text = "بازیابی تنظیمات"
        '
        'LinkSaveLayout
        '
        Me.LinkSaveLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkSaveLayout.AutoSize = True
        Me.LinkSaveLayout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkSaveLayout.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkSaveLayout.LinkColor = System.Drawing.Color.Red
        Me.LinkSaveLayout.Location = New System.Drawing.Point(634, 13)
        Me.LinkSaveLayout.Name = "LinkSaveLayout"
        Me.LinkSaveLayout.Size = New System.Drawing.Size(80, 14)
        Me.LinkSaveLayout.TabIndex = 217
        Me.LinkSaveLayout.TabStop = True
        Me.LinkSaveLayout.Text = "ذخیره تنظیمات"
        Me.LinkSaveLayout.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageAggregateScan)
        Me.TabControl1.Controls.Add(Me.TabPageScanRecords)
        Me.TabControl1.Controls.Add(Me.TabPageKasriEzafi)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1368, 569)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageAggregateScan
        '
        Me.TabPageAggregateScan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPageAggregateScan.Controls.Add(Me.LinkExportExcelBarcodeTajmie)
        Me.TabPageAggregateScan.Controls.Add(Me.LinkLoadLayout)
        Me.TabPageAggregateScan.Controls.Add(Me.NumericUpDown1)
        Me.TabPageAggregateScan.Controls.Add(Me.LinkSaveLayout)
        Me.TabPageAggregateScan.Controls.Add(Me.Label4)
        Me.TabPageAggregateScan.Controls.Add(Me.GroupBox1)
        Me.TabPageAggregateScan.Controls.Add(Me.GridBarcodeTajmie)
        Me.TabPageAggregateScan.Location = New System.Drawing.Point(4, 23)
        Me.TabPageAggregateScan.Name = "TabPageAggregateScan"
        Me.TabPageAggregateScan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAggregateScan.Size = New System.Drawing.Size(1360, 542)
        Me.TabPageAggregateScan.TabIndex = 0
        Me.TabPageAggregateScan.Text = "تجمیع محصولات اسکن شده موفق(ثبت رسید انبار)"
        '
        'LinkExportExcelBarcodeTajmie
        '
        Me.LinkExportExcelBarcodeTajmie.AutoSize = True
        Me.LinkExportExcelBarcodeTajmie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkExportExcelBarcodeTajmie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkExportExcelBarcodeTajmie.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkExportExcelBarcodeTajmie.LinkColor = System.Drawing.Color.Red
        Me.LinkExportExcelBarcodeTajmie.Location = New System.Drawing.Point(6, 13)
        Me.LinkExportExcelBarcodeTajmie.Name = "LinkExportExcelBarcodeTajmie"
        Me.LinkExportExcelBarcodeTajmie.Size = New System.Drawing.Size(86, 14)
        Me.LinkExportExcelBarcodeTajmie.TabIndex = 222
        Me.LinkExportExcelBarcodeTajmie.TabStop = True
        Me.LinkExportExcelBarcodeTajmie.Text = "دریافت اکسل"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(761, 9)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 22)
        Me.NumericUpDown1.TabIndex = 221
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(813, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 14)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "قفل کردن ستون های اول : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.RdbUseColumnSets)
        Me.GroupBox1.Controls.Add(Me.RdbUseColumns)
        Me.GroupBox1.Location = New System.Drawing.Point(984, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 34)
        Me.GroupBox1.TabIndex = 219
        Me.GroupBox1.TabStop = False
        '
        'RdbUseColumnSets
        '
        Me.RdbUseColumnSets.AutoSize = True
        Me.RdbUseColumnSets.Checked = True
        Me.RdbUseColumnSets.Location = New System.Drawing.Point(180, 11)
        Me.RdbUseColumnSets.Name = "RdbUseColumnSets"
        Me.RdbUseColumnSets.Size = New System.Drawing.Size(185, 18)
        Me.RdbUseColumnSets.TabIndex = 1
        Me.RdbUseColumnSets.TabStop = True
        Me.RdbUseColumnSets.Text = "نمایش بر اساس مجموعه ستون"
        Me.RdbUseColumnSets.UseVisualStyleBackColor = True
        '
        'RdbUseColumns
        '
        Me.RdbUseColumns.AutoSize = True
        Me.RdbUseColumns.Location = New System.Drawing.Point(22, 11)
        Me.RdbUseColumns.Name = "RdbUseColumns"
        Me.RdbUseColumns.Size = New System.Drawing.Size(141, 18)
        Me.RdbUseColumns.TabIndex = 0
        Me.RdbUseColumns.Text = "نمایش بر اساس ستون"
        Me.RdbUseColumns.UseVisualStyleBackColor = True
        '
        'GridBarcodeTajmie
        '
        Me.GridBarcodeTajmie.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeTajmie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridBarcodeTajmie_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeTajmie_DesignTimeLayout.LayoutString")
        Me.GridBarcodeTajmie.DesignTimeLayout = GridBarcodeTajmie_DesignTimeLayout
        Me.GridBarcodeTajmie.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridBarcodeTajmie.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridBarcodeTajmie.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeTajmie.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeTajmie.GroupByBoxVisible = False
        Me.GridBarcodeTajmie.Location = New System.Drawing.Point(3, 36)
        Me.GridBarcodeTajmie.Name = "GridBarcodeTajmie"
        Me.GridBarcodeTajmie.RecordNavigator = True
        Me.GridBarcodeTajmie.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeTajmie.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeTajmie.Size = New System.Drawing.Size(1354, 503)
        Me.GridBarcodeTajmie.TabIndex = 15
        Me.GridBarcodeTajmie.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabPageScanRecords
        '
        Me.TabPageScanRecords.Controls.Add(Me.SplitContainer1)
        Me.TabPageScanRecords.Location = New System.Drawing.Point(4, 23)
        Me.TabPageScanRecords.Name = "TabPageScanRecords"
        Me.TabPageScanRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageScanRecords.Size = New System.Drawing.Size(1360, 542)
        Me.TabPageScanRecords.TabIndex = 1
        Me.TabPageScanRecords.Text = "ثبت های اسکن محصولات بارکدخوان"
        Me.TabPageScanRecords.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1354, 536)
        Me.SplitContainer1.SplitterDistance = 388
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.LinkExportExcelBarcodeMaster)
        Me.Panel1.Controls.Add(Me.LinkLabelEbtalSabt)
        Me.Panel1.Controls.Add(Me.LinkRemoveFilter)
        Me.Panel1.Controls.Add(Me.GridBarcodeMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 388)
        Me.Panel1.TabIndex = 0
        '
        'LinkExportExcelBarcodeMaster
        '
        Me.LinkExportExcelBarcodeMaster.AutoSize = True
        Me.LinkExportExcelBarcodeMaster.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkExportExcelBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkExportExcelBarcodeMaster.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkExportExcelBarcodeMaster.LinkColor = System.Drawing.Color.Red
        Me.LinkExportExcelBarcodeMaster.Location = New System.Drawing.Point(222, 9)
        Me.LinkExportExcelBarcodeMaster.Name = "LinkExportExcelBarcodeMaster"
        Me.LinkExportExcelBarcodeMaster.Size = New System.Drawing.Size(86, 14)
        Me.LinkExportExcelBarcodeMaster.TabIndex = 17
        Me.LinkExportExcelBarcodeMaster.TabStop = True
        Me.LinkExportExcelBarcodeMaster.Text = "دریافت اکسل"
        '
        'LinkLabelEbtalSabt
        '
        Me.LinkLabelEbtalSabt.AutoSize = True
        Me.LinkLabelEbtalSabt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkLabelEbtalSabt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkLabelEbtalSabt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkLabelEbtalSabt.LinkColor = System.Drawing.Color.Red
        Me.LinkLabelEbtalSabt.Location = New System.Drawing.Point(17, 9)
        Me.LinkLabelEbtalSabt.Name = "LinkLabelEbtalSabt"
        Me.LinkLabelEbtalSabt.Size = New System.Drawing.Size(126, 14)
        Me.LinkLabelEbtalSabt.TabIndex = 16
        Me.LinkLabelEbtalSabt.TabStop = True
        Me.LinkLabelEbtalSabt.Text = "ابطال گروهی ثبت ها"
        '
        'LinkRemoveFilter
        '
        Me.LinkRemoveFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkRemoveFilter.AutoSize = True
        Me.LinkRemoveFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkRemoveFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkRemoveFilter.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkRemoveFilter.LinkColor = System.Drawing.Color.Red
        Me.LinkRemoveFilter.Location = New System.Drawing.Point(1250, 9)
        Me.LinkRemoveFilter.Name = "LinkRemoveFilter"
        Me.LinkRemoveFilter.Size = New System.Drawing.Size(67, 14)
        Me.LinkRemoveFilter.TabIndex = 15
        Me.LinkRemoveFilter.TabStop = True
        Me.LinkRemoveFilter.Text = "حذف فیلتر"
        '
        'GridBarcodeMaster
        '
        GridBarcodeMaster_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeMaster_DesignTimeLayout.LayoutString")
        Me.GridBarcodeMaster.DesignTimeLayout = GridBarcodeMaster_DesignTimeLayout
        Me.GridBarcodeMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcodeMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridBarcodeMaster.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeMaster.GroupByBoxVisible = False
        Me.GridBarcodeMaster.Location = New System.Drawing.Point(0, 0)
        Me.GridBarcodeMaster.Name = "GridBarcodeMaster"
        Me.GridBarcodeMaster.RecordNavigator = True
        Me.GridBarcodeMaster.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeMaster.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeMaster.Size = New System.Drawing.Size(1354, 388)
        Me.GridBarcodeMaster.TabIndex = 14
        Me.GridBarcodeMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.TabControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1354, 144)
        Me.Panel2.TabIndex = 1
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.RightToLeftLayout = True
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1354, 144)
        Me.TabControl3.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GridBarcodeDetail)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1346, 117)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "تفکیک وضعیت اسکن"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GridBarcodeDetail
        '
        GridBarcodeDetail_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeDetail_DesignTimeLayout.LayoutString")
        Me.GridBarcodeDetail.DesignTimeLayout = GridBarcodeDetail_DesignTimeLayout
        Me.GridBarcodeDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcodeDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridBarcodeDetail.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeDetail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeDetail.GroupByBoxVisible = False
        Me.GridBarcodeDetail.Location = New System.Drawing.Point(3, 3)
        Me.GridBarcodeDetail.Name = "GridBarcodeDetail"
        Me.GridBarcodeDetail.RecordNavigator = True
        Me.GridBarcodeDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridBarcodeDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeDetail.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeDetail.Size = New System.Drawing.Size(1340, 111)
        Me.GridBarcodeDetail.TabIndex = 14
        Me.GridBarcodeDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabPageKasriEzafi
        '
        Me.TabPageKasriEzafi.Controls.Add(Me.LinkExcelReportAnbargardani)
        Me.TabPageKasriEzafi.Controls.Add(Me.GridBarcodeRptKasriEzafi)
        Me.TabPageKasriEzafi.Location = New System.Drawing.Point(4, 23)
        Me.TabPageKasriEzafi.Name = "TabPageKasriEzafi"
        Me.TabPageKasriEzafi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKasriEzafi.Size = New System.Drawing.Size(1360, 542)
        Me.TabPageKasriEzafi.TabIndex = 2
        Me.TabPageKasriEzafi.Text = "کسری اضافات انبار بر اساس موجودی بارکدخوان(انبارگردانی)"
        Me.TabPageKasriEzafi.UseVisualStyleBackColor = True
        '
        'LinkExcelReportAnbargardani
        '
        Me.LinkExcelReportAnbargardani.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkExcelReportAnbargardani.AutoSize = True
        Me.LinkExcelReportAnbargardani.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkExcelReportAnbargardani.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkExcelReportAnbargardani.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkExcelReportAnbargardani.LinkColor = System.Drawing.Color.Red
        Me.LinkExcelReportAnbargardani.Location = New System.Drawing.Point(1243, 22)
        Me.LinkExcelReportAnbargardani.Name = "LinkExcelReportAnbargardani"
        Me.LinkExcelReportAnbargardani.Size = New System.Drawing.Size(90, 14)
        Me.LinkExcelReportAnbargardani.TabIndex = 218
        Me.LinkExcelReportAnbargardani.TabStop = True
        Me.LinkExcelReportAnbargardani.Text = "خروجی اکسل"
        '
        'GridBarcodeRptKasriEzafi
        '
        Me.GridBarcodeRptKasriEzafi.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.[True]
        GridBarcodeRptKasriEzafi_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeRptKasriEzafi_DesignTimeLayout.LayoutString")
        Me.GridBarcodeRptKasriEzafi.DesignTimeLayout = GridBarcodeRptKasriEzafi_DesignTimeLayout
        Me.GridBarcodeRptKasriEzafi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcodeRptKasriEzafi.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridBarcodeRptKasriEzafi.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridBarcodeRptKasriEzafi.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeRptKasriEzafi.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeRptKasriEzafi.GroupByBoxVisible = False
        Me.GridBarcodeRptKasriEzafi.Location = New System.Drawing.Point(3, 3)
        Me.GridBarcodeRptKasriEzafi.Name = "GridBarcodeRptKasriEzafi"
        Me.GridBarcodeRptKasriEzafi.RecordNavigator = True
        Me.GridBarcodeRptKasriEzafi.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeRptKasriEzafi.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeRptKasriEzafi.Size = New System.Drawing.Size(1354, 536)
        Me.GridBarcodeRptKasriEzafi.TabIndex = 16
        Me.GridBarcodeRptKasriEzafi.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeRptKasriEzafi.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000000
        '
        'FrmabSanadBarcodeReader
        '
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1368, 634)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmabSanadBarcodeReader"
        Me.Text = "اسناد بارکدخوان"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GrpDate.ResumeLayout(False)
        Me.GrpDate.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageAggregateScan.ResumeLayout(False)
        Me.TabPageAggregateScan.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridBarcodeTajmie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageScanRecords.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GridBarcodeDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageKasriEzafi.ResumeLayout(False)
        Me.TabPageKasriEzafi.PerformLayout()
        CType(Me.GridBarcodeRptKasriEzafi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Dim abRule As New ClsDataAccessRule
    Dim DSCatalogue As New DataSet
    Dim DvSourceKala As DataView
    Dim DvSourceDarkhast As DataView
    Dim DvSourceDarkhastHa As DataView
    Dim DvSourceFactor As DataView
    Dim DvSourceFactorHa As DataView
    Public TarakoneshMojaz As String = ""
    Public IsAnbarGardaniActive As Boolean = False
    Public IsSabtResidActive As Boolean = True
    Public NoControlBatchFactorAndMarjooei As Boolean = True
    Dim DtTableBeforeChange As New DataTable


    Private Sub FrmabSanadBarcodeReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.LinkRemoveFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.LinkLabelEbtalSabt.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.BtnRefreshData.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.BtnSabtResid.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.ChkGetLastData.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
        Me.ChkTikWithoutMoghayerat.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.BtnAnbarGardaniCatalogue.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.LinkExcelReportAnbargardani.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold)

        Me.LinkExportExcelBarcodeTajmie.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold) 'HB_14030410
        Me.LinkExportExcelBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold) 'HB_14030410


        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)
        TxtFromDate.Text = TxtToDate.Text.Substring(0, 8) + "01"


        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")



        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeDetail.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeMaster.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeRptKasriEzafi.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next
        'fghdbfhbffg


        'Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
        'TarakoneshMojaz = IIf(CAppSet.GetAppConfig("gVahedeTejariUseBarcodeReaderForSabtResid") Is System.DBNull.Value, "", CAppSet.GetAppConfig("gVahedeTejariUseBarcodeReaderForSabtResid").ToString)
        'BtnSabtResid.Visible = TarakoneshMojaz <> "0"

        'IsAnbarGardaniActive = CBool(IIf(CAppSet.GetAppConfig("gVahedeTejariUseBarcodeReaderForAnbarGardani") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gVahedeTejariUseBarcodeReaderForAnbarGardani")))


        dcbanbarStatus.Bind(cn, "Select * from abVw_productCatalogueAnbarStaus", "Status", "StatusDS")
        dcbanbarStatus.BoundText = "1"

        Call BtnRefreshData_Click(sender, e)


        DvSourceKala =
                     cn.ExecuteQuery("select  Distinct Top 100 Percent paKalaTamin.VahedeTejariSN TaminVahedeTejariSN,VahedeTejariNo TaminVahedeTejariNo,VahedeTejariDs TaminVahedeTejariDs,  " &
                    "paKala.KalaSN  ,paKala.KalaNo, Case when isnull(KalaStatus,0)<>1 Then '<غیر فعال>' Else '' End + KalaDs KalaDS, Azmayesh GenericCodeMap,KalaStatus, " &
                    "(Select Top 1 TedadAjza  from paVahedeSanjeshKala Where KalaSN=paKala.KalaSN And  VahedeSanjeshSN=9.935 And Pishfarz=1) TedadDarKarton, " &
                    "(Select Top 1 TedadAjza  from paVahedeSanjeshKala Where KalaSN=paKala.KalaSN And  VahedeSanjeshSN=10.935 ) TedadDarBasteh " &
                    "from  paKalaTamin Join paVahedeTejari Tamin On Tamin.VahedeTejariSN=paKalaTamin.VahedeTejariSN " &
                    "Join paKala on pakala.KalaSN=paKalaTamin.KalaSN " &
                    "Where len(isnull(paKala.IRC,''))>10 And len(isnull(paKala.GTIN,''))>10  And Tamin.NoeVahedeTejariSN in (14.935,16.935) Order by paKalaTamin.VahedeTejariSN Desc")

        If gVahedeTejariSN <> 44.935 Then
            ChkGetLastData.Visible = True
            Dim dvDaftarForoosh As DataView = cn.ExecuteQuery("Select DaftarForooshSN,DaftarForooshDS from paDaftarForoosh where VahedeTejariSN=" & gVahedeTejariSN.ToString)
            With GridBarcodeTajmie.RootTable.Columns.Item("DaftarForooshSN")
                .HasValueList = True
                .ValueList.PopulateValueList(dvDaftarForoosh, "DaftarForooshSN", "DaftarForooshDS")
            End With
        Else
            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDarkhast").Visible = False
            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisFactor").Visible = False
            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDaftarForoosh").Visible = False
            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisSanad").Visible = False
            ChkGetLastData.Visible = True
        End If

        Timer1.Enabled = True
        Call SyncCatalogueDataToGBID()


    End Sub

    Private Sub BtnRefreshData_Click(sender As Object, e As EventArgs) Handles BtnRefreshData.Click


        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")

        If IsSabtResidActive Then

            Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
            NoControlBatchFactorAndMarjooei = IIf(CApp.GetAppConfig("gVahedeTejariNoControlBatchBetweenFactorAndMarjooei") Is System.DBNull.Value, False, CApp.GetAppConfig("gVahedeTejariNoControlBatchBetweenFactorAndMarjooei"))

            Dim wfrm As New Anbar.Common.Frmwait
            wfrm.Show()


            Try
                If ChkGetLastData.Checked Then
                    wfrm.Label3.Text = "...سیستم در حال دریافت اطلاعات از سرور مرکزی بارکدخوان می باشد..."
                    wfrm.Refresh()
                    If gVahedeTejariSN = 44.935 Then
                        Try
                            Dim Errmsg As String = abRule.GetBarcodeScannerDataFromMainServer(cn)
                            If Errmsg.Length > 0 Then
                                CSystem.MsgBox("خطا : " + vbNewLine + Errmsg, MsgBoxStyle.Critical, "")
                                Exit Sub
                            End If
                            Threading.Thread.Sleep(10000)
                        Catch ex As Exception
                            CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, "")
                        End Try
                    End If
                    Try
                        abRule.GetLastProductCatalogue(cn, gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName)
                    Catch ex As Exception
                        CSystem.MsgBox("خطا در دریافت اطلاعات از سرور مرکزی" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "")
                    End Try
                End If

                wfrm.Label3.Text = "...سیستم در حال بروزرسانی آخرین اطلاعات می باشد..."
                wfrm.Refresh()


                Try
                    DSCatalogue = abRule.GetBarcodeScannerData(gVahedeTejariSN, gAnbarSN, Fdate, Tdate, CInt(dcbanbarStatus.BoundText), cn)

                    If DSCatalogue Is Nothing Then
                        CSystem.MsgBox("خطا در دریافت اطلاعات", MsgBoxStyle.Critical, "خطا!")
                        Exit Sub
                    Else
                        GridBarcodeMaster.DataSource = DSCatalogue.Tables(0)
                        GridBarcodeDetail.DataSource = DSCatalogue.Tables(1)
                        Call FillTakhsisFieldsByLastValuesBeforeRefresh()

                        GridBarcodeTajmie.DataSource = DSCatalogue.Tables(2)

                        GridBarcodeTajmie.AutoSizeColumns()
                        GridBarcodeDetail.AutoSizeColumns()
                        GridBarcodeMaster.AutoSizeColumns()

                    End If
                Catch ex As Exception
                    CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا!")
                End Try

                Call GridBarcodeMaster_SelectionChanged(sender, e)

                GridBarcodeMaster.AutoSizeColumns()


                GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDarkhast").Visible = False
                GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisFactor").Visible = False
                GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDaftarForoosh").Visible = False
                GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisSanad").Visible = False


                ''تنظیمات با توجه به تراکنش های دریافتی 
                Dim tblTarakonesh As DataView = New DataView(DSCatalogue.Tables(2).Copy, "Status=1", "", DataViewRowState.CurrentRows).ToTable(True, "CatalogueTarakoneshSN").DefaultView

                If tblTarakonesh.Count > 0 Then

                    tblTarakonesh.RowFilter = "CatalogueTarakoneshSN In (12)"

                    If tblTarakonesh.Count > 0 Then
                        DvSourceDarkhast = cn.ExecuteQuery("Select * from fovw_DarkhastHamlMostaghim")
                        With GridBarcodeTajmie.RootTable.Columns.Item("DarkhastSN")
                            .HasValueList = True
                            .ValueList.PopulateValueList(DvSourceDarkhast, "DarkhastSN", "DarkhastDS")
                        End With
                        DvSourceDarkhastHa = cn.ExecuteQuery("Select DarkhastSN,KalaSN,Tedad from foDarkhastHa Where DarkhastSN In (Select DarkhastSN from fovw_DarkhastHamlMostaghim)")
                        GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDarkhast").Visible = True
                    End If

                    tblTarakonesh.RowFilter = "0=0"
                    tblTarakonesh.RowFilter = "CatalogueTarakoneshSN In (38,39,45)"

                    If tblTarakonesh.Count > 0 Then

                        Dim WhereClauseStr As String = ""

                        Dim KalaSNStr As String = ""
                        Dim TarakoneshSNStr As String = ""

                        For Each row As DataRowView In tblTarakonesh
                            TarakoneshSNStr = row("CatalogueTarakoneshSN").ToString
                            KalaSNStr = ""
                            Dim tblKala As DataTable = New DataView(DSCatalogue.Tables(2).Copy, "Status=1 And CatalogueTarakoneshSN=" & row("CatalogueTarakoneshSN").ToString, "CatalogueTarakoneshSN", DataViewRowState.CurrentRows).ToTable(True, {"SimilarKalaByIRCGTIN"})
                            For Each rowKala As DataRow In tblKala.Rows
                                KalaSNStr += rowKala("SimilarKalaByIRCGTIN").ToString + ","
                            Next
                            If KalaSNStr.EndsWith(",") Then
                                KalaSNStr = KalaSNStr.Substring(0, KalaSNStr.Length - 1)
                            End If
                            WhereClauseStr += "(TarakoneshSN=" + TarakoneshSNStr.ToString + " And KalaSN In (" & KalaSNStr & ")) Or "

                        Next

                        If WhereClauseStr.EndsWith("Or ") Then
                            WhereClauseStr = WhereClauseStr.Substring(0, WhereClauseStr.Length - 3)
                        End If


                        Dim StrFactor As String = "Select * from abVw_ProductCatalogue_Factor_Marjooei where " & WhereClauseStr & " Order by SodoorDate desc"


                        DvSourceFactor = cn.ExecuteQuery(StrFactor)

                        tblTarakonesh.RowFilter = "CatalogueTarakoneshSN In (38,39)"
                        If tblTarakonesh.Count > 0 Then
                            With GridBarcodeTajmie.RootTable.Columns.Item("FactorSN")
                                .HasValueList = True
                                .ValueList.PopulateValueList(DvSourceFactor, "FactorSN", "FactorDS")
                            End With
                            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisFactor").Visible = True
                        End If

                        tblTarakonesh.RowFilter = "CatalogueTarakoneshSN In (45)"
                        If tblTarakonesh.Count > 0 Then
                            With GridBarcodeTajmie.RootTable.Columns.Item("SanadSN")
                                .HasValueList = True
                                .ValueList.PopulateValueList(DvSourceFactor, "SanadSN", "FactorDS")
                            End With
                            GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisSanad").Visible = True

                        End If

                    End If

                    tblTarakonesh.RowFilter = "0=0"
                    tblTarakonesh.RowFilter = "CatalogueTarakoneshSN In (11,18)"

                    If tblTarakonesh.Count > 0 AndAlso gVahedeTejariSN = 23000.935 Then ''فقط برای شعب دارای دفتر فروش
                        GridBarcodeTajmie.RootTable.ColumnSets.Item("ColumnSetTakhsisDaftarForoosh").Visible = True
                    End If


                End If

            Catch ex As Exception
            Finally
                wfrm.Close()
                ChkGetLastData.Checked = False
            End Try

        End If

        Dim dv As DataView = cn.ExecuteQuery("select Top 1 1 from abProductCatalogue join abProductCatalogueDetail on abProductCatalogue.ProductCatalogueSN=abProductCatalogueDetail.ProductCatalogueSN where (Status=1 Or ((Status=" & dcbanbarStatus.BoundText & " Or 0=" & dcbanbarStatus.BoundText & ") And TransferToDbDate between '" & Fdate & "' And '" & Tdate & "' ) ) and abProductCatalogue.ResInt1=50 and ScanResultNo=0 and Amount>0 and VahedeTejariSN=" & gVahedeTejariSN.ToString & " and AnbarSN=" & gAnbarSN.ToString)
        IsAnbarGardaniActive = dv.Count > 0

        If IsAnbarGardaniActive Then
            Dim Wfrm As New Anbar.Common.Frmwait
            Wfrm.Show()
            Wfrm.Label3.Text = "...سیستم در حال پردازش موجودی سیستم و مقایسه با موجودی اسکن شده جهت انبارگردانی می باشد...."
            Wfrm.Refresh()

            Try
                DSCatalogue = Nothing
                DSCatalogue = abRule.GetBarcodeScannerData(gVahedeTejariSN, gAnbarSN, Fdate, Tdate, CInt(dcbanbarStatus.BoundText), cn, "abSPG_ProductCatalogueGetDataForAnbarGardani")

                If DSCatalogue Is Nothing Then
                    CSystem.MsgBox("خطا در دریافت اطلاعات", MsgBoxStyle.Critical, "خطا!")
                    Exit Sub
                Else
                    If CType(GridBarcodeMaster.DataSource, DataTable).Rows.Count > 0 Then
                        Dim DtSource As DataTable = CType(GridBarcodeMaster.DataSource, DataTable)
                        DtSource.Merge(DSCatalogue.Tables(0))
                        GridBarcodeMaster.DataSource = DtSource
                    Else
                        GridBarcodeMaster.DataSource = DSCatalogue.Tables(0)
                    End If

                    If CType(GridBarcodeDetail.DataSource, DataTable).Rows.Count > 0 Then
                        Dim DtSource As DataTable = CType(GridBarcodeDetail.DataSource, DataTable)
                        DtSource.Merge(DSCatalogue.Tables(1))
                        GridBarcodeDetail.DataSource = DtSource
                    Else
                        GridBarcodeDetail.DataSource = DSCatalogue.Tables(1)
                    End If

                    GridBarcodeRptKasriEzafi.DataSource = DSCatalogue.Tables(2)

                    GridBarcodeRptKasriEzafi.AutoSizeColumns()
                    GridBarcodeDetail.AutoSizeColumns()
                    GridBarcodeMaster.AutoSizeColumns()

                    Call GridBarcodeMaster_SelectionChanged(sender, e)

                    GridBarcodeMaster.AutoSizeColumns()

                End If
            Catch ex As Exception
                CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا!")
            Finally
                Wfrm.Close()
            End Try

        End If

        If IsSabtResidActive Then
            If TabControl1.TabPages.IndexOf(TabPageAggregateScan) >= 0 Then
                TabControl1.SelectTab(TabPageAggregateScan)
            Else
                TabControl1.TabPages.Add(TabPageAggregateScan)
            End If
        Else
            If TabControl1.TabPages.IndexOf(TabPageAggregateScan) >= 0 Then
                TabControl1.TabPages.Remove(TabPageAggregateScan)
            End If
        End If

        If IsAnbarGardaniActive Then
            If TabControl1.TabPages.IndexOf(TabPageKasriEzafi) >= 0 Then
                TabControl1.SelectTab(TabPageKasriEzafi)
            Else
                TabControl1.TabPages.Add(TabPageKasriEzafi)
            End If

        Else
            If TabControl1.TabPages.IndexOf(TabPageKasriEzafi) >= 0 Then
                TabControl1.TabPages.Remove(TabPageKasriEzafi)
            End If
        End If

    End Sub

    Private Sub BtnTaeed_Click(sender As Object, e As EventArgs) Handles BtnSabtResid.Click

        Dim wfrm As New Anbar.Common.Frmwait

        Try
            If GridBarcodeTajmie.GetCheckedRows.Length = 0 Then
                CSystem.MsgBox("موردی برای ارسال به انبار انتخاب نشده است!", MsgBoxStyle.Exclamation, "خطا")
                Exit Sub
            End If

            Dim CntTakhsis As Integer = 0
            For Each Row As Janus.Windows.GridEX.GridEXRow In GridBarcodeTajmie.GetCheckedRows
                If CDec(Row.Cells("FlagInsert_IRC_GTIN").Value) = 1 Then
                    CntTakhsis += 1
                End If
            Next

            If CSystem.MsgBox(GridBarcodeTajmie.GetCheckedRows.Length.ToString + " ردیف جهت ثبت رسید انتخاب شده است" + vbNewLine +
                                "آیا مایل به ثبت رسید  برای محصولات انتخاب شده می باشید؟" + vbNewLine +
                               If(CntTakhsis > 0, "همچنین " + CntTakhsis.ToString + " ردیف محصول تخصیص یافته در موارد انتخاب شده وجود دارد", ""), MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ثبت رسید") = MsgBoxResult.No Then
                Exit Sub
            End If

            wfrm.Show()
            wfrm.Label3.Text = "...سیستم در حال ثبت سند موارد انتخابی می باشد..."
            wfrm.Refresh()
            Dim XmlStr As String = ""

            Dim DsCatalogueForInsertInDB As New DataSet
            Dim DtCatalogueForInsertInDB As New DataTable
            DtCatalogueForInsertInDB.TableName = "ProductCatalogue"

            'Dim _Col1 As New System.Data.DataColumn
            '_Col1.ColumnName = "ProductCatalogueSN"
            '_Col1.DataType = System.Type.GetType("System.Decimal")
            'DtCatalogueForInsertInDB.Columns.Add(_Col1)

            Dim _Col2 As New System.Data.DataColumn
            _Col2.ColumnName = "KalaSN"
            _Col2.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col2)

            Dim _Col22 As New System.Data.DataColumn
            _Col22.ColumnName = "TaminVahedeTejariSN"
            _Col22.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col22)

            Dim _Col3 As New System.Data.DataColumn
            _Col3.ColumnName = "BatchCode"
            DtCatalogueForInsertInDB.Columns.Add(_Col3)

            Dim _Col4 As New System.Data.DataColumn
            _Col4.ColumnName = "Manufacturing"
            DtCatalogueForInsertInDB.Columns.Add(_Col4)

            Dim _Col5 As New System.Data.DataColumn
            _Col5.ColumnName = "Expiration"
            DtCatalogueForInsertInDB.Columns.Add(_Col5)

            Dim _Col6 As New System.Data.DataColumn
            _Col6.ColumnName = "Amount"
            _Col6.DataType = System.Type.GetType("System.Int32")
            DtCatalogueForInsertInDB.Columns.Add(_Col6)

            Dim _Col66 As New System.Data.DataColumn
            _Col66.ColumnName = "Tozih"
            DtCatalogueForInsertInDB.Columns.Add(_Col66)

            Dim _Col7 As New System.Data.DataColumn
            _Col7.ColumnName = "FlagInsert_IRC_GTIN"
            DtCatalogueForInsertInDB.Columns.Add(_Col7)

            Dim _Col8 As New System.Data.DataColumn
            _Col8.ColumnName = "IRC"
            DtCatalogueForInsertInDB.Columns.Add(_Col8)

            Dim _Col9 As New System.Data.DataColumn
            _Col9.ColumnName = "GTIN"
            DtCatalogueForInsertInDB.Columns.Add(_Col9)

            Dim _Col10 As New System.Data.DataColumn
            _Col10.ColumnName = "RegisterNumber"
            DtCatalogueForInsertInDB.Columns.Add(_Col10)

            Dim _Col11 As New System.Data.DataColumn
            _Col11.ColumnName = "TarakoneshSN"
            DtCatalogueForInsertInDB.Columns.Add(_Col11)

            Dim _Col12 As New System.Data.DataColumn
            _Col12.ColumnName = "DarkhastSN"
            DtCatalogueForInsertInDB.Columns.Add(_Col12)

            Dim _Col13 As New System.Data.DataColumn
            _Col13.ColumnName = "FactorSN"
            DtCatalogueForInsertInDB.Columns.Add(_Col13)

            Dim _Col14 As New System.Data.DataColumn
            _Col14.ColumnName = "FactorAsliSN"
            DtCatalogueForInsertInDB.Columns.Add(_Col14)

            Dim _Col15 As New System.Data.DataColumn
            _Col15.ColumnName = "CatalogueTarakoneshSN"
            DtCatalogueForInsertInDB.Columns.Add(_Col15)

            Dim _Col16 As New System.Data.DataColumn
            _Col16.ColumnName = "UID"
            DtCatalogueForInsertInDB.Columns.Add(_Col16)

            Dim _Col17 As New System.Data.DataColumn
            _Col17.ColumnName = "DaftarForooshSN"
            _Col17.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col17)

            Dim _Col18 As New System.Data.DataColumn
            _Col18.ColumnName = "SanadSN"
            _Col18.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col18)

            For Each Tajmieitem As Janus.Windows.GridEX.GridEXRow In GridBarcodeTajmie.GetCheckedRows

                'If CDec(Tajmieitem.Cells("KalaSN").Value) = 0 Then
                '    CSystem.MsgBox("ردیف های انتخابی حاوی محصول نامشخص می باشد!", MsgBoxStyle.Exclamation, "خطا")
                '    Exit Sub
                'End If
                'If CDec(Tajmieitem.Cells("TaminVahedeTejariSN").Value) = 0 Then
                '    CSystem.MsgBox("ردیف های انتخابی حاوی تامین کننده نامشخص می باشد!", MsgBoxStyle.Exclamation, "خطا")
                '    Exit Sub
                'End If


                'If IsNumeric(Tajmieitem.Cells("AnbarTarakoneshSN").Value) Then
                '    If Not TarakoneshMojaz.Contains(Tajmieitem.Cells("AnbarTarakoneshSN").Value.ToString) Then
                '        CSystem.MsgBox("برای ردیف های انتخابی تراکنش صحیح انتخاب نشده است !", MsgBoxStyle.Exclamation, "خطا")
                '        Exit Sub
                '    End If
                'Else
                If Not IsNumeric(Tajmieitem.Cells("AnbarTarakoneshSN").Value) Then
                    CSystem.MsgBox("برای ردیف های انتخابی تراکنش انتخاب نشده است !", MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If



                If IsNumeric(Tajmieitem.Cells("MoghayeratNo").Value) Then
                    If CDec(Tajmieitem.Cells("MoghayeratNo").Value) >= 1 AndAlso CDec(Tajmieitem.Cells("MoghayeratNo").Value) <= 10 Then
                        CSystem.MsgBox("ردیف های انتخابی حاوی مغایرت (" & Tajmieitem.Cells("Moghayerat").Text & ") می باشد!", MsgBoxStyle.Exclamation, "خطا")
                        Exit Sub
                    End If
                End If

                If IsNumeric(Tajmieitem.Cells("AnbarTarakoneshSN").Value) Then
                    If CDec(Tajmieitem.Cells("AnbarTarakoneshSN").Value) >= 50 AndAlso CDec(Tajmieitem.Cells("AnbarTarakoneshSN").Value) <= 0 Then
                        CSystem.MsgBox("یکی از ردیف های انتخابی حاوی تراکنش عددی غیرمجاز می باشد", MsgBoxStyle.Exclamation, "خطا")
                        Exit Sub
                    End If
                Else
                    CSystem.MsgBox("یکی از ردیف های انتخابی حاوی تراکنش غیرعددی می باشد", MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If


                If CDec(Tajmieitem.Cells("Status").Value) = 2 AndAlso CDec(Tajmieitem.Cells("FlagInsert_IRC_GTIN").Value) = 1 Then
                    CSystem.MsgBox("ردیف های انتخابی حاوی محصولات ارسال شده می باشد!" +
                                   vbNewLine + vbNewLine + "تامین کننده : " + Tajmieitem.Cells("TaminVahedeTejariDS").Text + vbNewLine + "محصول : " +
                                   Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If

                If CDec(Tajmieitem.Cells("Status").Value) <> 1 AndAlso CDec(Tajmieitem.Cells("FlagInsert_IRC_GTIN").Value) = 0 Then
                    CSystem.MsgBox("ردیف های انتخابی حاوی محصولات " & Tajmieitem.Cells("StatusDS").Text & " می باشد!" +
                                   vbNewLine + vbNewLine + "تامین کننده : " + Tajmieitem.Cells("TaminVahedeTejariDS").Text + vbNewLine + "محصول : " +
                                   Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If

                'If IsNumeric(Tajmieitem.Cells("SanadSN").Value) Then
                '    If CDec(Tajmieitem.Cells("SanadSN").Value) > 0 Then
                '        If IsNumeric(Tajmieitem.Cells("TedadSanadAnbar").Value) Then
                '            If CDec(Tajmieitem.Cells("TedadSanadAnbar").Value) > 0 AndAlso CDec(Tajmieitem.Cells("TedadSanadAnbar").Value) > CDec(Tajmieitem.Cells("Amount").Value) Then
                '                CSystem.MsgBox("تعداد مرجوعی جایزه از تعداد اسکن بیشتر است!" + vbNewLine + "محصول : " + Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "")
                '                Exit Sub
                '            End If
                '            If CDec(Tajmieitem.Cells("TedadSanadAnbar").Value) = 0 Then
                '                CSystem.MsgBox("تعداد مرجوعی جایزه وارد نشده است!" + vbNewLine + "محصول : " + Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "")
                '                Exit Sub
                '            End If

                '        End If
                '    End If
                'End If

                'If IsNumeric(Tajmieitem.Cells("TedadSanadAnbar").Value) Then
                '    If CDec(Tajmieitem.Cells("TedadSanadAnbar").Value) > 0 Then
                '        If IsNumeric(Tajmieitem.Cells("SanadSN").Value) Then
                '            If CDec(Tajmieitem.Cells("SanadSN").Value) = 0 Then
                '                CSystem.MsgBox("مقدار مرجوعی وارد شده اما سند انبار برای ردیف ذیل انتخاب نشده است!" + vbNewLine + "محصول : " + Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "")
                '                Exit Sub
                '            End If
                '        Else
                '            CSystem.MsgBox("مقدار مرجوعی وارد شده اما سند انبار برای ردیف ذیل انتخاب نشده است!" + vbNewLine + "محصول : " + Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "")
                '            Exit Sub
                '        End If
                '    End If
                'End If




                Dim NewRow As DataRow = DtCatalogueForInsertInDB.NewRow
                NewRow("UID") = Tajmieitem.Cells("UID").Text
                NewRow("KalaSN") = Tajmieitem.Cells("KalaSN").Value
                NewRow("TaminVahedeTejariSN") = Tajmieitem.Cells("TaminVahedeTejariSN").Value
                NewRow("BatchCode") = Tajmieitem.Cells("BatchCode").Value
                NewRow("Manufacturing") = Tajmieitem.Cells("Manufacturing").Value
                NewRow("Expiration") = Tajmieitem.Cells("Expiration").Value
                NewRow("Amount") = Tajmieitem.Cells("Amount").Value
                NewRow("Tozih") = Tajmieitem.Cells("Tozih").Text
                NewRow("FlagInsert_IRC_GTIN") = Tajmieitem.Cells("FlagInsert_IRC_GTIN").Text
                NewRow("IRC") = Tajmieitem.Cells("IRC").Text
                NewRow("GTIN") = Tajmieitem.Cells("GTIN").Text
                NewRow("RegisterNumber") = ""
                NewRow("TarakoneshSN") = Tajmieitem.Cells("AnbarTarakoneshSN").Value
                NewRow("CatalogueTarakoneshSN") = Tajmieitem.Cells("CatalogueTarakoneshSN").Value
                NewRow("DarkhastSN") = Tajmieitem.Cells("DarkhastSN").Value
                NewRow("FactorSN") = Tajmieitem.Cells("FactorSN").Value
                NewRow("FactorAsliSN") = Tajmieitem.Cells("FactorAsliSN").Value
                NewRow("DaftarForooshSN") = Tajmieitem.Cells("DaftarForooshSN").Value
                NewRow("SanadSN") = Tajmieitem.Cells("SanadSN").Value

                If CInt(NewRow("FlagInsert_IRC_GTIN")) = 1 Then
                    Dim RegNumbers As String = ""
                    GridBarcodeMaster.RemoveFilters()
                    For Each item As DataRow In CType(GridBarcodeMaster.DataSource, DataTable).Rows
                        If item("IRC").ToString = NewRow("IRC").ToString AndAlso item("GTIN").ToString = NewRow("GTIN").ToString AndAlso item("BatchCode").ToString = NewRow("BatchCode").ToString Then
                            RegNumbers += item("RegisterNumber").ToString + ","
                        End If
                    Next
                    If RegNumbers.EndsWith(",") Then
                        RegNumbers = RegNumbers.Substring(0, RegNumbers.Length - 1)
                    End If
                    NewRow("RegisterNumber") = RegNumbers
                End If

                DtCatalogueForInsertInDB.Rows.Add(NewRow)


            Next

            If DtCatalogueForInsertInDB.Rows.Count > 0 Then
                DsCatalogueForInsertInDB.Tables.Add(DtCatalogueForInsertInDB)
                XmlStr = DsCatalogueForInsertInDB.GetXml
            End If


            Try
                Dim Errmsg As String = abRule.SabteSanadByBarcodeScannerData(gVahedeTejariSN, gAnbarSN, XmlStr, gSM.UserID, gSM.UserName, cn)
                If Errmsg <> "" Then
                    CSystem.MsgBox("خطا در ثبت سند " + vbNewLine + Errmsg, MsgBoxStyle.Exclamation, "خطا!")
                Else
                    Call BtnRefreshData_Click(sender, e)

                    CSystem.MsgBox("ثبت سند با موفقیت انجام گردید", MsgBoxStyle.Information, "ثبت سند")
                End If
            Catch ex As Exception
                CSystem.MsgBox("خطا در ثبت سند " + vbNewLine + ex.Message, MsgBoxStyle.Critical, "خطا!")
            End Try

        Catch ex As Exception
        Finally
            wfrm.Close()
            ChkGetLastData.Checked = False
        End Try

        'test 14030523

    End Sub

    Private Sub GridBarcodeMaster_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeMaster.DoubleClick
        GridBarcodeMaster.AutoSizeColumns()
    End Sub

    Private Sub GridBarcodeDetail_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeDetail.DoubleClick
        GridBarcodeDetail.AutoSizeColumns()
    End Sub

    Private Sub GridBarcodeTajmie_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeTajmie.DoubleClick
        GridBarcodeTajmie.AutoSizeColumns()
    End Sub
    Private Sub GridBarcodeRptKasriEzafi_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeRptKasriEzafi.DoubleClick
        GridBarcodeRptKasriEzafi.AutoSizeColumns()
    End Sub

    Private Sub GridBarcodeMaster_SelectionChanged(sender As Object, e As EventArgs) Handles GridBarcodeMaster.SelectionChanged

        TabPage4.Text = "تفکیک وضعیت شمارش ها"
        If GridBarcodeMaster.CurrentRow Is Nothing Then
            If Not GridBarcodeDetail.DataSource Is Nothing Then
                CType(GridBarcodeDetail.DataSource, DataTable).DefaultView.RowFilter = "1=0"
            End If
            Exit Sub
        End If

        If Not IsNothing(GridBarcodeDetail.DataSource) Then
            If IsNumeric(GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value) Then
                CType(GridBarcodeDetail.DataSource, DataTable).DefaultView.RowFilter = "ProductCatalogueSN=" & GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value.ToString
                GridBarcodeDetail.Refresh()
                TabPage4.Text = "تفکیک وضعیت شمارش ها" + " - شماره ثبت " + GridBarcodeMaster.CurrentRow.Cells("RegisterNumber").Text

            Else
                CType(GridBarcodeDetail.DataSource, DataTable).DefaultView.RowFilter = "1=0"
                GridBarcodeDetail.Refresh()
            End If
        End If

        GridBarcodeDetail.AutoSizeColumns()

    End Sub

    Private Sub GridBarcodeTajmie_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridBarcodeTajmie.LinkClicked

        If GridBarcodeTajmie.CurrentRow Is Nothing Then
            Exit Sub
        End If

        If GridBarcodeTajmie.CurrentColumn.Key.ToUpper = "TAKHSISMAHSUL" Then
            If CDec(GridBarcodeTajmie.CurrentRow.Cells("FlagInsert_IRC_GTIN").Value) = 1 Then
                If GridBarcodeTajmie.CurrentRow.Cells("TakhsisMahsul").Text Is Nothing OrElse GridBarcodeTajmie.CurrentRow.Cells("TakhsisMahsul").Text <> "تخصيص محصول" Then
                    Exit Sub
                End If
                Dim TakhsisKalaForm As New Common.FrmProductCatalogueAsistant
                Dim KalaSN As Decimal = 0

                With TakhsisKalaForm
                    DvSourceKala.RowFilter = "0=0"
                    .DvSource = DvSourceKala
                    .Text = "محصولات دارویی دارای GTIN و IRC در لیست نمایش داده میشوند - برای انتخاب محصول روی سطر محصول فعال انتخاب شده دابل کلیک کنید"
                    .HideSNColumns = True
                    .ArrayOfHideColumns = {"KalaStatus"}

                    Dim FormatCondition1 As Janus.Windows.GridEX.GridEXFormatCondition = New Janus.Windows.GridEX.GridEXFormatCondition(New Janus.Windows.GridEX.GridEXColumn("KalaStatus"), ConditionOperator.Equal, 0)
                    FormatCondition1.FormatStyle.BackColor = Color.OrangeRed
                    .FormatCondition1 = FormatCondition1

                    .ShowDialog()

                    KalaSN = .SelectedKalaSN
                    Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow
                    Dim DvForUpdate As DataView = New DataView(DvSourceKala.ToTable, "KalaStatus=1 And KalaSN=" & KalaSN.ToString, "", DataViewRowState.CurrentRows).ToTable.DefaultView
                    If DvForUpdate.Count = 1 Then
                        Grow.BeginEdit()
                        For Each col1 As DataColumn In DvForUpdate.ToTable.Columns
                            For Each col2 As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
                                If col1.ColumnName = col2.Key Then
                                    Grow.Cells(col2.Key).Value = DvForUpdate(0)(col1.ColumnName)
                                End If
                            Next
                        Next
                        If IsNumeric(DvForUpdate(0)("TedadDarKarton")) Then
                            Grow.Cells("AmountKarton").Value = Math.Floor(Grow.Cells("Amount").Value / DvForUpdate(0)("TedadDarKarton"))
                            Grow.Cells("AmountMandehAzKarton").Value = (Grow.Cells("Amount").Value Mod DvForUpdate(0)("TedadDarKarton"))
                        Else
                            CSystem.MsgBox("توجه داشته باشید تعداد در کارتن محصول انتخابی در سیستم تعریف نشده است!")
                        End If
                        Grow.Cells("Moghayerat").Value = DBNull.Value
                        Grow.Cells("MoghayeratNo").Value = DBNull.Value
                        Grow.EndEdit()
                    End If
                    .Dispose()
                End With


            Else
                If GridBarcodeTajmie.CurrentRow.Cells("TakhsisMahsul").Text Is Nothing OrElse GridBarcodeTajmie.CurrentRow.Cells("TakhsisMahsul").Text <> "تخصيص محصول" Then
                    Exit Sub
                End If
                If IsNumeric(GridBarcodeTajmie.CurrentRow.Cells("MoghayeratNo").Value) AndAlso CInt(GridBarcodeTajmie.CurrentRow.Cells("MoghayeratNo").Value) <> 13 Then
                    Exit Sub
                End If
                Dim TakhsisKalaForm As New Common.FrmProductCatalogueAsistant
                Dim KalaSN As Decimal = 0
                Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow


                With TakhsisKalaForm
                    DvSourceKala.RowFilter = "0=0"
                    .DvSource = New DataView(DvSourceKala.ToTable, "KalaSN <> " & Grow.Cells("KalaSN").Text & " And KalaSN IN (" & If(Grow.Cells("SimilarKalaByIRCGTIN").Text <> "", Grow.Cells("SimilarKalaByIRCGTIN").Text, "0") & ")", "", DataViewRowState.CurrentRows).ToTable.DefaultView
                    .Text = "محصولات  دارای GTIN و IRC مشابه محصول انتخابی در لیست نمایش داده میشوند -  برای انتخاب محصول روی سطر محصول انتخاب شده دابل کلیک کنید"

                    '.GridReport.FilterMode = FilterMode.Automatic
                    '.GridReport.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                    '.GridReport.DefaultFilterRowComparison = FilterConditionOperator.Contains
                    '.GridReport.DynamicFiltering = True
                    .HideSNColumns = True
                    .ArrayOfHideColumns = {"KalaStatus"}

                    Dim FormatCondition1 As Janus.Windows.GridEX.GridEXFormatCondition = New Janus.Windows.GridEX.GridEXFormatCondition(New Janus.Windows.GridEX.GridEXColumn("KalaStatus"), ConditionOperator.Equal, 0)
                    FormatCondition1.FormatStyle.BackColor = Color.OrangeRed
                    .FormatCondition1 = FormatCondition1

                    .ShowDialog()
                    KalaSN = .SelectedKalaSN
                    Dim DvForUpdate As DataView = New DataView(DvSourceKala.ToTable, "KalaStatus=1 And KalaSN=" & KalaSN.ToString, "", DataViewRowState.CurrentRows).ToTable.DefaultView
                    If DvForUpdate.Count = 1 Then
                        Grow.BeginEdit()
                        For Each col1 As DataColumn In DvForUpdate.ToTable.Columns
                            For Each col2 As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
                                If col1.ColumnName = col2.Key Then
                                    Grow.Cells(col2.Key).Value = DvForUpdate(0)(col1.ColumnName)
                                End If
                            Next
                        Next
                        If IsNumeric(DvForUpdate(0)("TedadDarKarton")) Then
                            Grow.Cells("AmountKarton").Value = Math.Floor(Grow.Cells("Amount").Value / DvForUpdate(0)("TedadDarKarton"))
                            Grow.Cells("AmountMandehAzKarton").Value = (Grow.Cells("Amount").Value Mod DvForUpdate(0)("TedadDarKarton"))
                        Else
                            CSystem.MsgBox("توجه داشته باشید تعداد در کارتن محصول انتخابی در سیستم تعریف نشده است!")
                        End If
                        Grow.Cells("Moghayerat").Value = DBNull.Value
                        Grow.Cells("MoghayeratNo").Value = DBNull.Value
                        Grow.EndEdit()
                    End If
                    .Dispose()
                End With
            End If

        ElseIf GridBarcodeTajmie.CurrentColumn.Key.ToUpper = "TAKHSISDARKHASTFOROOSH" Then
            If GridBarcodeTajmie.CurrentRow.Cells("TakhsisDarkhastForoosh").Text Is Nothing OrElse Not GridBarcodeTajmie.CurrentRow.Cells("TakhsisDarkhastForoosh").Text.Contains("تخصيص") Then
                Exit Sub
            End If
            Dim TakhsisDarkhastForm As New Common.FrmProductCatalogueAsistant
            Dim DarkhastSN As Decimal = 0
            With TakhsisDarkhastForm
                .DvSource = DvSourceDarkhast
                .Text = "درخواست های حمل مستقیم پیش فاکتور شده سیستم فروش در لیست نمایش داده میشوند - برای انتخاب درخواست روی آن دابل کلیک کنید"
                .HideSNColumns = True
                .ShowDialog()
                DarkhastSN = .SelectedDarkhastSN

                Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow
                If DarkhastSN > 0 Then
                    DvSourceDarkhastHa.RowFilter = "0=0"
                    DvSourceDarkhastHa.RowFilter = "DarkhastSN=" & DarkhastSN.ToString & " And KalaSN=" & Grow.Cells("KalaSN").Text
                    If DvSourceDarkhastHa.Count = 0 Then
                        CSystem.MsgBox("محصول " + vbNewLine + Grow.Cells("KalaDS").Text + vbNewLine + " در اقلام درخواست انتخابی وجود ندارد! ", MsgBoxStyle.Exclamation, "")
                    Else
                        If CDec(DvSourceDarkhastHa(0)("Tedad")) <> CDec(Grow.Cells("Amount").Value) Then
                            CSystem.MsgBox("تعداد اسکن محصول " + vbNewLine + Grow.Cells("KalaDS").Text + vbNewLine + " با تعداد آن در درخواست مغایرت دارد! " + vbNewLine +
                                           "تعداد اسکن : " + Grow.Cells("Amount").Text + vbNewLine +
                                           "تعداد درخواست : " + DvSourceDarkhastHa(0)("Tedad").ToString, MsgBoxStyle.Exclamation, "")
                        Else
                            Grow.BeginEdit()
                            Grow.Cells("DarkhastSN").Value = DarkhastSN
                            Grow.EndEdit()
                        End If
                    End If
                End If


                .Dispose()
                GridBarcodeTajmie.AutoSizeColumns()
            End With
        ElseIf GridBarcodeTajmie.CurrentColumn.Key.ToUpper = "TAKHSISSANAD" Then
            If GridBarcodeTajmie.CurrentRow.Cells("TakhsisSanad").Text Is Nothing OrElse Not GridBarcodeTajmie.CurrentRow.Cells("TakhsisSanad").Text.Contains("تخصيص") Then
                Exit Sub
            End If
            Dim TakhsisSanadForm As New Common.FrmProductCatalogueAsistant
            Dim DarkhastSN As Decimal = 0
            Dim SanadSN As Decimal = 0
            Dim SelectedBatchCode As String = ""
            Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow
            Dim TarakoneshSn As Integer = CInt(Grow.Cells("AnbarTarakoneshSN").Value)

            With TakhsisSanadForm
                'Dim dvSource As DataView = New DataView(DvSourceFactor.ToTable.Copy, "KalaSN=" & Grow.Cells("KalaSN").Text & " And TarakoneshSN=45" & If(NoControlBatchFactorAndMarjooei, "", " And ShomarehRahgiri='" & Grow.Cells("BatchCode").Text & "'"), "SodoorDate Desc", DataViewRowState.CurrentRows).ToTable.Copy.DefaultView
                Dim dvSource As DataView = New DataView(DvSourceFactor.ToTable.Copy, "KalaSN=" & Grow.Cells("KalaSN").Text & " And TarakoneshSN=45", "SodoorDate Desc", DataViewRowState.CurrentRows).ToTable.Copy.DefaultView
                For Each Drow As DataRowView In dvSource
                    If Drow("ShomarehRahgiri").ToString = Grow.Cells("BatchCode").Text Then
                        Drow("MatchBatchCode") = 1
                    End If
                Next

                dvSource.Sort = "MatchBatchCode Desc,SodoorDate DESc"

                .DvSource = dvSource
                .Text = "اسناد حواله نمونه در لیست نمایش داده میشوند - برای انتخاب حواله مورد نظر روی آن دابل کلیک کنید " + " - محصول : " + Grow.Cells("KalaDS").Text + If(NoControlBatchFactorAndMarjooei, "", " - بچ : " + Grow.Cells("BatchCode").Text) + " - ردیف هایی که بچ آنها با بچ اسکن شده یکسان باشد با رنگ سبز نمایش داده میشوند"
                .HideSNColumns = True
                If NoControlBatchFactorAndMarjooei = False Then
                    '.ArrayOfHideColumns = {"ShomarehRahgiri", "MatchBatchCode"}
                    .ArrayOfHideColumns = {"MatchBatchCode"}

                Else
                    .ArrayOfHideColumns = {"MatchBatchCode"}
                End If

                Dim FormatCondition1 As Janus.Windows.GridEX.GridEXFormatCondition = New Janus.Windows.GridEX.GridEXFormatCondition(New Janus.Windows.GridEX.GridEXColumn("MatchBatchCode"), ConditionOperator.Equal, 1)
                FormatCondition1.FormatStyle.BackColor = Color.FromArgb(192, 255, 192)
                .FormatCondition1 = FormatCondition1

                .ShowDialog()
                DarkhastSN = .SelectedDarkhastSN
                SanadSN = .SelectedSanadSN
                SelectedBatchCode = .SelectedBatchNo


                If SanadSN > 0 Then
                    If Grow.Cells("BatchCode").Text <> SelectedBatchCode Then
                        If CSystem.MsgBox("توجه داشته باشید بچ اسکن شده با بچ موجود در اقلام سند متفاوت است .آیا مایل به ادامه عملیات تخصیص سند هستید؟" + vbNewLine +
                                          "محصول : " + Grow.Cells("KalaDS").Text + vbNewLine +
                                          "بچ اسکن شده : " + Grow.Cells("BatchCode").Text + vbNewLine +
                                          "بچ سند : " + SelectedBatchCode, MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                            Grow.BeginEdit()
                            Grow.Cells("SanadSN").Value = SanadSN
                            Grow.Cells("DarkhastSN").Value = DarkhastSN
                            Grow.EndEdit()
                        End If
                    Else
                        Grow.BeginEdit()
                        Grow.Cells("SanadSN").Value = SanadSN
                        Grow.Cells("DarkhastSN").Value = DarkhastSN
                        Grow.EndEdit()
                    End If
                End If

                .Dispose()
                GridBarcodeTajmie.AutoSizeColumns()
            End With
        ElseIf GridBarcodeTajmie.CurrentColumn.Key.ToUpper = "TAKHSISFACTOR" Then
            If GridBarcodeTajmie.CurrentRow.Cells("TakhsisFactor").Text Is Nothing OrElse Not GridBarcodeTajmie.CurrentRow.Cells("TakhsisFactor").Text.Contains("تخصيص") Then
                Exit Sub
            End If
            Dim TakhsisFactorForm As New Common.FrmProductCatalogueAsistant
            Dim FactorSN As Decimal = 0
            Dim FactorAsliSN As Decimal = 0
            Dim SelectedBatchCode As String = ""
            Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow
            Dim TarakoneshSn As Integer = CInt(Grow.Cells("AnbarTarakoneshSN").Value)
            With TakhsisFactorForm
                'Dim dvSource As DataView = New DataView(DvSourceFactor.ToTable.Copy, "KalaSN=" & Grow.Cells("KalaSN").Text & " And TarakoneshSN=" & TarakoneshSn.ToString & If(NoControlBatchFactorAndMarjooei, "", " And ShomarehRahgiri='" & Grow.Cells("BatchCode").Text & "'"), "SodoorDate Desc", DataViewRowState.CurrentRows).ToTable.Copy.DefaultView
                Dim dvSource As DataView = New DataView(DvSourceFactor.ToTable.Copy, "KalaSN=" & Grow.Cells("KalaSN").Text & " And TarakoneshSN=" & TarakoneshSn.ToString, "SodoorDate Desc", DataViewRowState.CurrentRows).ToTable.Copy.DefaultView
                For Each Drow As DataRowView In dvSource
                    If Drow("ShomarehRahgiri").ToString = Grow.Cells("BatchCode").Text Then
                        Drow("MatchBatchCode") = 1
                    End If
                Next

                dvSource.Sort = "MatchBatchCode Desc,SodoorDate DESc"

                .DvSource = dvSource
                .Text = "برای انتخاب فاکتور روی آن دابل کلیک کنید - " + If(TarakoneshSn = 38, "لیست زیر فاکتوری های ", "لیست فاکتورهای ") + "محصول : " + Grow.Cells("KalaDS").Text + If(NoControlBatchFactorAndMarjooei, "", " - بچ : " + Grow.Cells("BatchCode").Text) + " - ردیف هایی که بچ آنها با بچ اسکن شده یکسان باشد با رنگ سبز نمایش داده میشوند"
                .HideSNColumns = True
                If NoControlBatchFactorAndMarjooei = False Then
                    '.ArrayOfHideColumns = {"ShomarehRahgiri", "MatchBatchCode"}
                    .ArrayOfHideColumns = {"MatchBatchCode"}

                Else
                    .ArrayOfHideColumns = {"MatchBatchCode"}
                End If

                Dim FormatCondition1 As Janus.Windows.GridEX.GridEXFormatCondition = New Janus.Windows.GridEX.GridEXFormatCondition(New Janus.Windows.GridEX.GridEXColumn("MatchBatchCode"), ConditionOperator.Equal, 1)
                FormatCondition1.FormatStyle.BackColor = Color.FromArgb(192, 255, 192)
                .FormatCondition1 = FormatCondition1

                .ShowDialog()
                FactorSN = .SelectedFactorSN
                FactorAsliSN = .SelectedFactorAsliSN
                SelectedBatchCode = .SelectedBatchNo

                If FactorSN > 0 Then
                    If Grow.Cells("BatchCode").Text <> SelectedBatchCode Then
                        If CSystem.MsgBox("توجه داشته باشید بچ اسکن شده با بچ موجود در اقلام فاکتور اصلی متفاوت است .آیا مایل به ادامه عملیات تخصیص فاکتور هستید؟" + vbNewLine +
                                      "محصول : " + Grow.Cells("KalaDS").Text + vbNewLine +
                                      "بچ اسکن شده : " + Grow.Cells("BatchCode").Text + vbNewLine +
                                      "بچ فاکتور : " + SelectedBatchCode, MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                            Grow.BeginEdit()
                            Grow.Cells("FactorSN").Value = FactorSN
                            Grow.Cells("FactorAsliSN").Value = IIf(FactorAsliSN = 0, DBNull.Value, FactorAsliSN)
                            Grow.EndEdit()
                        End If
                    Else
                        Grow.BeginEdit()
                        Grow.Cells("FactorSN").Value = FactorSN
                        Grow.Cells("FactorAsliSN").Value = IIf(FactorAsliSN = 0, DBNull.Value, FactorAsliSN)
                        Grow.EndEdit()
                    End If
                End If
                .Dispose()
                GridBarcodeTajmie.AutoSizeColumns()
            End With
        ElseIf GridBarcodeTajmie.CurrentColumn.Key.ToUpper = "DETAILRECORDS" Then

            Dim _GRow As Janus.Windows.GridEX.GridEXRow = GridBarcodeTajmie.CurrentRow

            CType(GridBarcodeMaster.DataSource, DataTable).DefaultView.RowFilter = "GTIN='" & _GRow.Cells("GTIN").Text & "' " &
            "And IRC='" & _GRow.Cells("IRC").Text & "' " &
            "And BatchCode='" & _GRow.Cells("BatchCode").Text & "' " &
            "And Status=" & _GRow.Cells("Status").Text & " " &
            "And CatalogueTarakoneshSN=" & _GRow.Cells("CatalogueTarakoneshSN").Value.ToString

            TabControl1.SelectTab(TabPageScanRecords)
            GridBarcodeMaster.AutoSizeColumns()

        End If
    End Sub

    Private Sub LinkRemoveFilter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRemoveFilter.LinkClicked
        CType(GridBarcodeMaster.DataSource, DataTable).DefaultView.RowFilter = "0=0"
    End Sub

    Private Sub dcbanbarStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dcbanbarStatus.SelectedIndexChanged
        If dcbanbarStatus.BoundText Is Nothing Then
            Exit Sub
        ElseIf dcbanbarStatus.BoundText = "1" AndAlso Not TabControl1.TabPages.Contains(TabPageKasriEzafi) Then
            GrpDate.Enabled = False
        Else
            GrpDate.Enabled = True
        End If
    End Sub

    Private Sub GridBarcodeMaster_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridBarcodeMaster.LinkClicked
        If GridBarcodeMaster.CurrentRow Is Nothing OrElse GridBarcodeMaster.CurrentColumn Is Nothing Then
            Exit Sub
        End If

        If GridBarcodeMaster.CurrentColumn.Key.ToUpper = "EBTALSABT" Then
            If CDec(GridBarcodeMaster.CurrentRow.Cells("Status").Value) <> 1 Then
                CSystem.MsgBox("فقط موارد ارسال نشده به انبار قابلیت ابطال دارند", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            If CBool(GridBarcodeMaster.CurrentRow.Cells("ForceUseUIDforSanad").Value) = True Then
                CSystem.MsgBox("محصول <" + GridBarcodeMaster.CurrentRow.Cells("KalaDS").Text + "> جز دسته محصولاتی است که ثبت سند بر اساس UID برای آن الزامیست لذا ابطال ثبت آن امکانپذیر نمی باشد ", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            If CSystem.MsgBox("آیا مایل به ابطال شماره ثبت " + GridBarcodeMaster.CurrentRow.Cells("RegisterNumber").Text + "می باشید؟", MsgBoxStyle.YesNo, "ابطال شماره ثبت") = MsgBoxResult.No Then
                Exit Sub
            End If
            cn.ExecuteNoneQuery("update abProductCatalogue set Status=3 where ProductCatalogueSN=" & GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Text)
            ChkGetLastData.Checked = False
            Call BtnRefreshData_Click(sender, e)
        End If
    End Sub

    Private Sub LinkSaveLayout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSaveLayout.LinkClicked
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(System.Windows.Forms.Application.StartupPath + "\GridBarcodeTajmie.gxl", IO.FileMode.Create)
            GridBarcodeTajmie.SaveLayoutFile(stream)
            stream.Close()
            CSystem.MsgBox("تنطیمات با موفقیت ذخیره شد")
        Catch ex As Exception
            CSystem.MsgBox("خطا : " + ex.Message, MsgBoxStyle.Exclamation, "")
        End Try

    End Sub

    Private Sub LinkLoadLayout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLoadLayout.LinkClicked
        Try
            Dim fi As System.IO.FileInfo = New System.IO.FileInfo(System.Windows.Forms.Application.StartupPath + "\GridBarcodeTajmie.gxl")
            Dim stream As System.IO.FileStream = New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
            GridBarcodeTajmie.LoadLayoutFile(stream)
            stream.Close()
        Catch ex As Exception
            CSystem.MsgBox("خطا : " + ex.Message, MsgBoxStyle.Exclamation, "")
        End Try
    End Sub

    Private Sub RdbUseColumns_CheckedChanged(sender As Object, e As EventArgs) Handles RdbUseColumns.CheckedChanged
        If RdbUseColumns.Checked Then
            GridBarcodeTajmie.RootTable.CellLayoutMode = CellLayoutMode.UseColumns
            For Each col As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
                If Not col.ColumnSet Is Nothing Then
                    If col.ColumnSet.Key = "ColumnSetMap" Then
                        col.Caption = col.Caption + If(col.Caption.Contains("(مپ)"), "", "(مپ)")
                    ElseIf col.ColumnSet.Key = "ColumnSetCatalogueSystem" Then
                        col.Caption = col.Caption + If(col.Caption.Contains("(سامانه)"), "", "(سامانه)")
                    End If
                End If
            Next
            NumericUpDown1.Enabled = True
            LinkSaveLayout.Visible = True
        Else
            GridBarcodeTajmie.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets
            For Each col As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
                If Not col.ColumnSet Is Nothing Then
                    If col.ColumnSet.Key = "ColumnSetMap" Then
                        col.Caption = col.Caption.Replace("(مپ)", "")
                    End If
                    If col.ColumnSet.Key = "ColumnSetCatalogueSystem" Then
                        col.Caption = col.Caption.Replace("(سامانه)", "")
                    End If
                End If
            Next
            NumericUpDown1.Value = 0
            NumericUpDown1.Enabled = False
            LinkSaveLayout.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If GridBarcodeTajmie.RootTable.CellLayoutMode = CellLayoutMode.UseColumns Then
            GridBarcodeTajmie.FrozenColumns = CInt(NumericUpDown1.Value)
        ElseIf GridBarcodeTajmie.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets Then
            GridBarcodeTajmie.FrozenColumns = 0
        End If
    End Sub

    Private Sub BtnAnbarGardaniCatalogue_Click(sender As Object, e As EventArgs) Handles BtnAnbarGardaniCatalogue.Click
        Dim wfrm As New Anbar.Common.Frmwait

        Try
            If GridBarcodeRptKasriEzafi.GetCheckedRows.Length = 0 Then
                CSystem.MsgBox("موردی برای ارسال به انبار انتخاب نشده است!", MsgBoxStyle.Exclamation, "خطا")
                Exit Sub
            End If

            Dim CntTakhsis As Integer = 0
            Dim CntKasriEzafi As Integer = 0
            Dim CntWithoutMoghayerat As Integer = 0
            Dim CntWithMoghayerat As Integer = 0

            For Each Row As Janus.Windows.GridEX.GridEXRow In GridBarcodeRptKasriEzafi.GetCheckedRows

                If IsNumeric(Row.Cells("KasriEzafi").Value) Then
                    If CDec(Row.Cells("KasriEzafi").Value <> 0) Then
                        CntKasriEzafi += 1
                    End If
                End If
                If Not IsNumeric(Row.Cells("MoghayeratNo").Value) Then
                    CntWithoutMoghayerat += 1
                Else
                    CntWithMoghayerat += 1
                End If
            Next

            CntKasriEzafi = 0

            If CSystem.MsgBox(GridBarcodeRptKasriEzafi.GetCheckedRows.Length.ToString + " ردیف جهت تایید انتخاب شده است" + vbNewLine + vbNewLine +
                               If(CntWithoutMoghayerat > 0, " تعداد ردیف بدون مغایرت جهت تایید : " + CntWithoutMoghayerat.ToString + vbNewLine, "") +
                               If(CntWithMoghayerat > 0, " تعداد ردیف با مغایرت جهت تایید : " + CntWithMoghayerat.ToString + vbNewLine, "") +
                               If(CntKasriEzafi > 0, " تعداد ردیف با مغایرت کسری اضافی : " + CntKasriEzafi.ToString + vbNewLine, "") +
                               If(CntTakhsis > 0, " تعداد ردیف محصول تخصیصی : " + CntTakhsis.ToString + vbNewLine, "") +
                              "آیا مایل به تایید محصولات انتخاب شده می باشید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ثبت رسید") = MsgBoxResult.No Then
                Exit Sub
            End If

            wfrm.Show()
            wfrm.Label3.Text = "...سیستم در حال تایید " + If(CntKasriEzafi > 0, "و ثبت سند کسری اضافی برای", "") + " موارد انتخابی می باشد..."
            wfrm.Refresh()
            Dim XmlStr As String = ""

            Dim DsCatalogueForInsertInDB As New DataSet
            Dim DtCatalogueForInsertInDB As New DataTable
            DtCatalogueForInsertInDB.TableName = "ProductCatalogue"

            Dim _Col1 As New System.Data.DataColumn
            _Col1.ColumnName = "KalaPhizikiSN"
            _Col1.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col1)

            Dim _Col2 As New System.Data.DataColumn
            _Col2.ColumnName = "KalaSN"
            _Col2.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col2)


            Dim _Col3 As New System.Data.DataColumn
            _Col3.ColumnName = "BatchCode"
            DtCatalogueForInsertInDB.Columns.Add(_Col3)

            Dim _Col4 As New System.Data.DataColumn
            _Col4.ColumnName = "Manufacturing"
            DtCatalogueForInsertInDB.Columns.Add(_Col4)

            Dim _Col5 As New System.Data.DataColumn
            _Col5.ColumnName = "Expiration"
            DtCatalogueForInsertInDB.Columns.Add(_Col5)

            Dim _Col6 As New System.Data.DataColumn
            _Col6.ColumnName = "Amount"
            _Col6.DataType = System.Type.GetType("System.Int32")
            DtCatalogueForInsertInDB.Columns.Add(_Col6)

            Dim _Col8 As New System.Data.DataColumn
            _Col8.ColumnName = "IRC"
            DtCatalogueForInsertInDB.Columns.Add(_Col8)

            Dim _Col9 As New System.Data.DataColumn
            _Col9.ColumnName = "GTIN"
            DtCatalogueForInsertInDB.Columns.Add(_Col9)

            Dim _Col10 As New System.Data.DataColumn
            _Col10.ColumnName = "RegisterNumber"
            DtCatalogueForInsertInDB.Columns.Add(_Col10)

            Dim _Col11 As New System.Data.DataColumn
            _Col11.ColumnName = "KasriEzafi"
            _Col11.DataType = System.Type.GetType("System.Decimal")
            DtCatalogueForInsertInDB.Columns.Add(_Col11)

            For Each Tajmieitem As Janus.Windows.GridEX.GridEXRow In GridBarcodeRptKasriEzafi.GetCheckedRows

                If IsNumeric(Tajmieitem.Cells("MoghayeratNo").Value) Then
                    If CDec(Tajmieitem.Cells("MoghayeratNo").Value) <= 3 Then
                        CSystem.MsgBox("ردیف های انتخابی حاوی مغایرت (" & Tajmieitem.Cells("Moghayerat").Text & ") می باشد!", MsgBoxStyle.Exclamation, "خطا")
                        Exit Sub
                    End If
                End If


                If CDec(Tajmieitem.Cells("Status").Value) <> 1 Then
                    CSystem.MsgBox("ردیف های انتخابی حاوی محصولات " & Tajmieitem.Cells("StatusDS").Text & " می باشد!" +
                                   vbNewLine + vbNewLine + "تامین کننده : " + Tajmieitem.Cells("TaminVahedeTejariDS").Text + vbNewLine + "محصول : " +
                                   Tajmieitem.Cells("KalaDS").Text + vbNewLine + "بچ : " + Tajmieitem.Cells("BatchCode").Text, MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If


                Dim NewRow As DataRow = DtCatalogueForInsertInDB.NewRow
                NewRow("KalaPhizikiSN") = Tajmieitem.Cells("KalaPhizikiSN").Value
                NewRow("KalaSN") = Tajmieitem.Cells("KalaSN").Value
                NewRow("BatchCode") = Tajmieitem.Cells("BatchCode").Value
                NewRow("Manufacturing") = Tajmieitem.Cells("Manufacturing").Value
                NewRow("Expiration") = Tajmieitem.Cells("Expiration").Value
                NewRow("Amount") = Tajmieitem.Cells("Amount").Value
                NewRow("IRC") = Tajmieitem.Cells("IRC").Text
                NewRow("GTIN") = Tajmieitem.Cells("GTIN").Text

                Dim RegNumbers As String = ""
                'GridBarcodeMaster.RemoveFilters()
                'For Each item As DataRow In CType(GridBarcodeMaster.DataSource, DataTable).Rows
                '    If item("IRC").ToString = NewRow("IRC").ToString AndAlso item("GTIN").ToString = NewRow("GTIN").ToString AndAlso item("BatchCode").ToString = NewRow("BatchCode").ToString AndAlso item("Expiration").ToString = NewRow("Expiration").ToString Then
                '        RegNumbers += item("RegisterNumber").ToString + ","
                '    End If
                'Next
                'If RegNumbers.EndsWith(",") Then
                '    RegNumbers = RegNumbers.Substring(0, RegNumbers.Length - 1)
                'End If
                NewRow("RegisterNumber") = RegNumbers
                NewRow("KasriEzafi") = Tajmieitem.Cells("KasriEzafi").Value


                DtCatalogueForInsertInDB.Rows.Add(NewRow)


            Next

            If DtCatalogueForInsertInDB.Rows.Count > 0 Then
                DsCatalogueForInsertInDB.Tables.Add(DtCatalogueForInsertInDB)
                XmlStr = DsCatalogueForInsertInDB.GetXml
            End If


            Try
                Dim Errmsg As String = abRule.SabteSanadKasriEzafiByBarcodeScannerData(gVahedeTejariSN, gAnbarSN, XmlStr, gSM.UserID, gSM.UserName, cn)
                If Errmsg <> "" Then
                    CSystem.MsgBox("خطا در ثبت سند " + vbNewLine + Errmsg, MsgBoxStyle.Exclamation, "خطا!")
                Else
                    Call BtnRefreshData_Click(sender, e)
                    CSystem.MsgBox("تایید ردیف(ها) با موفقیت انجام گردید", MsgBoxStyle.Information, "ثبت سند")
                End If
            Catch ex As Exception
                CSystem.MsgBox("خطا در ثبت سند " + vbNewLine + ex.Message, MsgBoxStyle.Critical, "خطا!")
            End Try

        Catch ex As Exception
        Finally
            wfrm.Close()
            ChkTikWithoutMoghayerat.Checked = False
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ChkTikWithoutMoghayerat.Visible = TabControl1.SelectedTab Is TabPageKasriEzafi
        BtnAnbarGardaniCatalogue.Visible = TabControl1.SelectedTab Is TabPageKasriEzafi
        BtnSabtResid.Visible = TabControl1.SelectedTab Is TabPageAggregateScan
        'btnExportExcel.Visible = TabControl1.SelectedTab Is TabPageScanRecords
    End Sub

    Private Sub GridRptKasriEzafi_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridBarcodeRptKasriEzafi.LinkClicked

        If GridBarcodeRptKasriEzafi.CurrentRow Is Nothing Then
            Exit Sub
        End If

        If GridBarcodeRptKasriEzafi.CurrentColumn.Key.ToUpper = "DETAILRECORDS" Then

            Dim _GRow As Janus.Windows.GridEX.GridEXRow = GridBarcodeRptKasriEzafi.CurrentRow

            CType(GridBarcodeMaster.DataSource, DataTable).DefaultView.RowFilter = "GTIN='" & _GRow.Cells("GTIN").Text & "' " &
            "And IRC='" & _GRow.Cells("IRC").Text & "' " &
            "And BatchCode='" & _GRow.Cells("BatchCode").Text & "' " &
            "And Status=" & _GRow.Cells("Status").Text & " " &
            "And CatalogueTarakoneshSN=" & _GRow.Cells("CatalogueTarakoneshSN").Value.ToString


            TabControl1.SelectTab(TabPageScanRecords)
            GridBarcodeMaster.AutoSizeColumns()

        ElseIf GridBarcodeRptKasriEzafi.CurrentColumn.Key.ToUpper = "MOJOUDIREPORT" Then
            Dim RPT As New Report.FrmReportMojudiWithIRC_GTIN
            With RPT
                .cmbKala.Enabled = False
                .kalaSN = CStr(GridBarcodeRptKasriEzafi.CurrentRow.Cells("KalaSN").Value)
                .cmbTaminKonandeh.Enabled = False
                .cmbShobeh.Enabled = False
                .txtIRC.Enabled = False
                .txtGTIN.Enabled = False
                .chkShowbedoonehmojudi.Checked = True
                .ShowDialog()
                .Dispose()
            End With
        ElseIf GridBarcodeRptKasriEzafi.CurrentColumn.Key.ToUpper = "BATCHEDIT" Then
            If GridBarcodeRptKasriEzafi.CurrentRow.Cells("BATCHEDIT").Text Is Nothing OrElse GridBarcodeRptKasriEzafi.CurrentRow.Cells("BATCHEDIT").Text <> "اصلاح بچ" Then
                Exit Sub
            End If
            Dim frmEditBatch As New Common.FrmProductCatalogueAsistant

            With frmEditBatch
                Dim Grow As Janus.Windows.GridEX.GridEXRow = GridBarcodeRptKasriEzafi.CurrentRow
                Dim DvSourceForEditBatch As DataView = New DataView(CType(GridBarcodeRptKasriEzafi.DataSource, DataTable), "isnull(MoghayeratNo,0)<>5 And KalaSN=" & Grow.Cells("KalaSN").Value.ToString, "", DataViewRowState.CurrentRows).ToTable.Copy.DefaultView
                If DvSourceForEditBatch.Count > 0 Then
                    .DvSource = DvSourceForEditBatch
                    .Text = "اصلاح بچ : <" + Grow.Cells("KalaDS").Text + " - بچ : " + Grow.Cells("ShomarehRahgiri").Text + " > - " + "برای اصلاح بچ ردیف مربوطه را انتخاب و روی آن دابل کلیک کنید"
                    .HideSNColumns = True
                    For Each rowv As DataRowView In DvSourceForEditBatch
                        rowv("ShomarehRahgiri") = Grow.Cells("ShomarehRahgiri").Text
                        rowv("EnghezaDate") = Grow.Cells("EnghezaDate").Text
                        rowv("ToolidDate") = Grow.Cells("ToolidDate").Text
                        rowv("Mojoudi") = Grow.Cells("Mojoudi").Value
                    Next
                    .NoeForm = 4
                    .ArrayOfShowColumns = {"KalaNo", "KalaDS", "BatchCode", "JalaliExpireDate", "JalaliManufacturingDate"}
                    .ShowDialog()
                    .Dispose()
                    If .NoeForm = 1000 Then
                        Call BtnRefreshData_Click(sender, e)

                    End If

                Else
                    CSystem.MsgBox("ردیف اسکن شده(فیزیکی) دیگری برای این محصول یافت نشد", MsgBoxStyle.Exclamation, "")
                End If

            End With
        End If


        'End If
    End Sub

    Private Sub ChkTikWithoutMoghayerat_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTikWithoutMoghayerat.CheckedChanged
        If ChkTikWithoutMoghayerat.Checked Then
            For Each grow As Janus.Windows.GridEX.GridEXRow In GridBarcodeRptKasriEzafi.GetRows
                If Not IsNumeric(grow.Cells("MoghayeratNo").Value) AndAlso CDec(grow.Cells("KasriEzafi").Value) = 0 Then
                    grow.CheckState = RowCheckState.Checked
                End If
            Next
        Else
            GridBarcodeRptKasriEzafi.UnCheckAllRecords()
        End If

    End Sub

    Private Sub LinkExcelReportAnbargardani_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkExcelReportAnbargardani.LinkClicked

        Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems

        Dim dtReport As DataTable = New DataView(CType(GridBarcodeRptKasriEzafi.DataSource, DataTable), "", "", DataViewRowState.CurrentRows).ToTable.Copy

        If dtReport.Rows.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("رکوردی جهت دریافت گزارش یافت نشد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim SnColumns As New ArrayList
        For Each colj As Janus.Windows.GridEX.GridEXColumn In GridBarcodeRptKasriEzafi.RootTable.Columns
            If colj.Key.ToUpper.EndsWith("SN") Then
                SnColumns.Add(colj.Key)
            End If
        Next

        For Each item As String In SnColumns
            dtReport.Columns.Remove(item.ToString)
        Next

        For Each col As DataColumn In dtReport.Columns
            For Each colj As Janus.Windows.GridEX.GridEXColumn In GridBarcodeRptKasriEzafi.RootTable.Columns
                If col.ColumnName.ToUpper = colj.Key.ToUpper Then
                    Dim Caption2 As String = ""
                    If Not colj.ColumnSet Is Nothing Then
                        Select Case colj.ColumnSet.Key
                            Case "ColumnSetMap"
                                Caption2 = "(مپ)"
                            Case "ColumnSetSystem"
                                Caption2 = "(سامانه)"
                            Case "ColumnSetScanAmount"
                                Caption2 = "(اسکن بارکدخوان)"
                            Case "ColumnSetMapMojoudi"
                                Caption2 = "(موجودی مپ)"
                            Case "ColumnSetKasriEzafi"
                                Caption2 = "(کسری اضافی)"
                        End Select
                    End If
                    col.ColumnName = colj.Caption + Caption2
                End If
            Next
        Next


        Try
            _SharedItems.ExcellExport("انبارگردانی بارکدخوان", dtReport)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکالی در ساخت فایل اکسل به وجود آمده است.", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
        End Try


    End Sub

    Private Sub GridBarcodeMaster_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles GridBarcodeMaster.RowCheckStateChanged
        LinkLabelEbtalSabt.Text = If(GridBarcodeMaster.GetCheckedRows.Length = 0, "ابطال گروهی ثبت ها", "ابطال <" + GridBarcodeMaster.GetCheckedRows.Length.ToString + "> ثبت انتخاب شده")
    End Sub

    Private Sub LinkLabelEbtalSabt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEbtalSabt.LinkClicked
        If GridBarcodeMaster.GetCheckedRows.Length = 0 Then
            CSystem.MsgBox("ثبتی جهت ابطال انتخاب نشده است.ابتدا ثبت های مورد نظر را تیک بزنید", MsgBoxStyle.Critical, "ابطال گروهی ثبت ها")
            Exit Sub
        End If
        Dim CatalogueSN_Str As String = ""
        For Each grow As Janus.Windows.GridEX.GridEXRow In GridBarcodeMaster.GetCheckedRows
            If CDec(grow.Cells("Status").Value) <> 1 Then
                CSystem.MsgBox("فقط موارد ارسال نشده به انبار قابلیت ابطال دارند" + vbNewLine +
                               "محصول : " + grow.Cells("KalaDS").Text + vbNewLine +
                               "بچ : " + grow.Cells("BatchCode").Text, MsgBoxStyle.Critical, "")
                Exit Sub
            End If
            If CBool(grow.Cells("ForceUseUIDforSanad").Value) = True Then
                CSystem.MsgBox("محصول <" + GridBarcodeMaster.CurrentRow.Cells("KalaDS").Text + "> جز دسته محصولاتی است که ثبت سند بر اساس UID برای آن الزامیست لذا ابطال ثبت آن امکانپذیر نمی باشد ", MsgBoxStyle.Critical, "")
                Exit Sub
            End If
            CatalogueSN_Str += grow.Cells("ProductCatalogueSN").Text + ","
        Next

        If CSystem.MsgBox("آیا مایل به ابطال <" + GridBarcodeMaster.GetCheckedRows.Length.ToString + "> ثبت انتخاب شده می باشید؟", MsgBoxStyle.YesNo, "ابطال گروهی ثبت ها") = MsgBoxResult.No Then
            Exit Sub
        End If

        If CatalogueSN_Str.EndsWith(",") Then
            CatalogueSN_Str = CatalogueSN_Str.Substring(0, CatalogueSN_Str.Length - 1)
        End If

        Try
            abRule.EbtalSabtBarcodeReader(CatalogueSN_Str, cn)
        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
        Finally
            ChkGetLastData.Checked = False
            LinkLabelEbtalSabt.Text = "ابطال گروهی ثبت ها"
            Call BtnRefreshData_Click(sender, e)
        End Try



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call SyncCatalogueDataToGBID()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not BackgroundWorker1.IsBusy Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub FrmabSanadBarcodeReader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        While BackgroundWorker1.IsBusy
            Threading.Thread.Sleep(3000)

        End While
    End Sub

    Sub SyncCatalogueDataToGBID()
        Dim Dv As DataView = cn.ExecuteQuery("select ProductCatalogueSN,TransferToAnbarTime,Status,Tozih,ResC1,ResC2,ResC3,ResC4,ResC5,ResInt1,ResInt2,ResInt3,ResDesc1, " &
                                            "ResDesc2,ResDesc3,isnull(UserID_Name,'" & gSM.UserID_Name & "') UserID_Name,isnull(Host_Name,'" & System.Windows.Forms.SystemInformation.ComputerName & "') Host_Name " &
                                         "from abProductCatalogue where Status<>1 And VahedeTejariSN=" & gVahedeTejariSN.ToString & " And AnbarSN=" & gAnbarSN.ToString & " And right(isnull(UserID_Name,''),1)<>'T' ")
        If Dv.Count > 0 Then
            Dim DtCatalogueForUpdateDB As DataTable = New DataView(Dv.ToTable, "", "", DataViewRowState.CurrentRows).ToTable
            DtCatalogueForUpdateDB.TableName = "ProductCatalogue"
            Dim DsCatalogueForUpdateDB As New DataSet
            DsCatalogueForUpdateDB.Tables.Add(DtCatalogueForUpdateDB)

            Dim Xmlstr As String = DsCatalogueForUpdateDB.GetXml

            Try
                abRule.SyncProductCatalogueData_ShoabToGBID(Xmlstr, cn)
            Catch ex As Exception
                CSystem.MsgBox("BackgroundWorker1_DoWork" + vbNewLine + ex.Message)

            End Try

        End If


    End Sub

    Private Sub GridBarcodeTajmie_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles GridBarcodeTajmie.CellValueChanged
        'If GridBarcodeTajmie.CurrentRow IsNot Nothing Then
        '    If GridBarcodeTajmie.CurrentRow.RowType = RowType.Record Then
        '        If GridBarcodeTajmie.CurrentColumn.Key = "DaftarForooshSN" Then
        '            GridBarcodeTajmie.AutoSizeColumns()
        '            GridBarcodeTajmie.Refresh()
        '        End If
        '    End If
        'End If

    End Sub

    Sub FillTakhsisFieldsByLastValuesBeforeRefresh()

        ''آخرین اطلاعات تخصیص ها(سند،فاکتور،درخواست) بر اساس آخرین داده موجود قبل از بروزرسانی تکمیل میشود
        If GridBarcodeTajmie.DataSource IsNot Nothing AndAlso CType(GridBarcodeTajmie.DataSource, DataTable).Rows.Count > 0 Then
            DtTableBeforeChange = CType(GridBarcodeTajmie.DataSource, DataTable).Copy

            If DtTableBeforeChange.Rows.Count > 0 Then
                For Each NowTableRow As DataRow In DSCatalogue.Tables(2).Rows
                    If NowTableRow("Status") = 1 Then
                        For Each LastTablerow As DataRow In DtTableBeforeChange.Rows

                            If IsNumeric(LastTablerow("DarkhastSN")) OrElse
                                            IsNumeric(LastTablerow("FactorSN")) OrElse
                                            IsNumeric(LastTablerow("FactorAsliSN")) OrElse
                                            IsNumeric(LastTablerow("SanadSN")) Then

                                If (Not IsDBNull(LastTablerow("UID")) AndAlso
                                                        LastTablerow("UID").ToString.Length = 20 AndAlso
                                                        LastTablerow("UID") = NowTableRow("UID") AndAlso
                                                        LastTablerow("CatalogueTarakoneshSN") = NowTableRow("CatalogueTarakoneshSN")) Then

                                    NowTableRow("DarkhastSN") = LastTablerow("DarkhastSN")
                                    NowTableRow("FactorSN") = LastTablerow("FactorSN")
                                    NowTableRow("FactorAsliSN") = LastTablerow("FactorAsliSN")
                                    NowTableRow("SanadSN") = LastTablerow("SanadSN")
                                    NowTableRow("KalaSN") = LastTablerow("KalaSN")
                                    NowTableRow("KalaNo") = LastTablerow("KalaNo")
                                    NowTableRow("KalaDS") = LastTablerow("KalaDS")
                                    NowTableRow("TaminVahedeTejariSN") = LastTablerow("TaminVahedeTejariSN")
                                    NowTableRow("TaminVahedeTejariNo") = LastTablerow("TaminVahedeTejariNo")
                                    NowTableRow("TaminVahedeTejariDS") = LastTablerow("TaminVahedeTejariDS")
                                    NowTableRow("TedadDarKarton") = LastTablerow("TedadDarKarton")
                                    NowTableRow("TedadDarBasteh") = LastTablerow("TedadDarBasteh")
                                    NowTableRow("GenericCodeMap") = LastTablerow("GenericCodeMap")

                                    If IsNumeric(NowTableRow("TedadDarKarton")) Then
                                        NowTableRow("AmountKarton") = Math.Floor(NowTableRow("Amount") / NowTableRow("TedadDarKarton"))
                                        NowTableRow("AmountMandehAzKarton") = (NowTableRow("Amount") Mod NowTableRow("TedadDarKarton"))
                                    End If

                                ElseIf (IsDBNull(LastTablerow("UID")) OrElse
                                                    LastTablerow("UID").ToString.Length <> 20) Then

                                    If LastTablerow("GTIN") = NowTableRow("GTIN") AndAlso
                                                        LastTablerow("IRC") = NowTableRow("IRC") AndAlso
                                                        LastTablerow("BatchCode") = NowTableRow("BatchCode") AndAlso
                                                        LastTablerow("CatalogueTarakoneshSN") = NowTableRow("CatalogueTarakoneshSN") Then

                                        NowTableRow("DarkhastSN") = LastTablerow("DarkhastSN")
                                        NowTableRow("FactorSN") = LastTablerow("FactorSN")
                                        NowTableRow("FactorAsliSN") = LastTablerow("FactorAsliSN")
                                        NowTableRow("SanadSN") = LastTablerow("SanadSN")
                                        NowTableRow("KalaSN") = LastTablerow("KalaSN")
                                        NowTableRow("KalaNo") = LastTablerow("KalaNo")
                                        NowTableRow("KalaDS") = LastTablerow("KalaDS")
                                        NowTableRow("TaminVahedeTejariSN") = LastTablerow("TaminVahedeTejariSN")
                                        NowTableRow("TaminVahedeTejariNo") = LastTablerow("TaminVahedeTejariNo")
                                        NowTableRow("TaminVahedeTejariDS") = LastTablerow("TaminVahedeTejariDS")
                                        NowTableRow("TedadDarKarton") = LastTablerow("TedadDarKarton")
                                        NowTableRow("TedadDarBasteh") = LastTablerow("TedadDarBasteh")
                                        NowTableRow("GenericCodeMap") = LastTablerow("GenericCodeMap")

                                        If IsNumeric(NowTableRow("TedadDarKarton")) Then
                                            NowTableRow("AmountKarton") = Math.Floor(NowTableRow("Amount") / NowTableRow("TedadDarKarton"))
                                            NowTableRow("AmountMandehAzKarton") = (NowTableRow("Amount") Mod NowTableRow("TedadDarKarton"))
                                        End If

                                    End If

                                End If

                            End If

                        Next

                    End If

                Next
            End If
        End If
        ''آخرین اطلاعات تخصیص ها(سند،فاکتور،درخواست) مجددا بر اساس آخرین داده موجود تکمیل میشود

    End Sub

    Private Sub LinkExportExcelBarcodeTajmie_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkExportExcelBarcodeTajmie.LinkClicked

        '---------- HB_14030409_ Export Excel _Begin

        Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems

        Dim DtExportExcel As DataTable = New DataView(DSCatalogue.Tables(2), "", "", DataViewRowState.CurrentRows).ToTable()


        Dim _ArrayRemoveColumn As New ArrayList
        If DtExportExcel.Rows.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست خالی می باشد!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        Else
            For Each _ExcelColumns As DataColumn In DtExportExcel.Columns
                For Each _ColumnsGrid As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
                    If _ExcelColumns.ColumnName = _ColumnsGrid.Key Then
                        If _ColumnsGrid.Visible = False Then
                            _ArrayRemoveColumn.Add(_ExcelColumns.ColumnName)
                        Else
                            Dim ColumnName As String = _ColumnsGrid.Caption
                            If RdbUseColumnSets.Checked AndAlso _ColumnsGrid.ColumnSet IsNot Nothing Then
                                If _ColumnsGrid.ColumnSet.Key = "ColumnSetMap" Then
                                    ColumnName = _ColumnsGrid.Caption + If(_ColumnsGrid.Caption.Contains("-مپ"), "", "-مپ")
                                ElseIf _ColumnsGrid.ColumnSet.Key = "ColumnSetCatalogueSystem" Then
                                    ColumnName = _ColumnsGrid.Caption + If(_ColumnsGrid.Caption.Contains("-سامانه"), "", "-سامانه")
                                End If
                                _ExcelColumns.ColumnName = ColumnName
                            End If
                        End If
                    End If
                Next
            Next
            If _ArrayRemoveColumn.Count > 0 Then
                For Each RemoveItems As String In _ArrayRemoveColumn
                    DtExportExcel.Columns.Remove(RemoveItems)
                Next
            End If
        End If

        If DtExportExcel.Rows.Count > 0 Then
            For Each colt As DataColumn In DtExportExcel.Columns
                For Each rowt As DataRow In DtExportExcel.Rows
                    If Not IsDBNull(rowt(colt)) Then
                        rowt(colt) = rowt(colt).ToString.Replace("<", "").Replace(">", "")
                    End If
                Next
            Next

        End If

        Try
            _SharedItems.ExcellExport("لیست اکسل تجمیع محصولات اسکن شده موفق(ثبت رسید انبار)", DtExportExcel)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکالی در ساخت فایل اکسل به وجود آمده است.", MsgBoxStyle.Exclamation, "خطا")

        End Try

        '---------- HB_14030409_ Export Excel _End

    End Sub

    Private Sub LinkExportExcelBarcodeMaster_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkExportExcelBarcodeMaster.LinkClicked


        '---------- HB_14030410_ Export Excel _Begin

        Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems

        Dim DtExportExcel As DataTable = New DataView(DSCatalogue.Tables(0), "", "", DataViewRowState.CurrentRows).ToTable()

        Dim _ArrayRemoveColumn As New ArrayList
        If DtExportExcel.Rows.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست خالی می باشد!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        Else
            For Each _ExcelColumns As DataColumn In DtExportExcel.Columns
                For Each _ColumnsGrid As Janus.Windows.GridEX.GridEXColumn In GridBarcodeMaster.RootTable.Columns
                    If _ExcelColumns.ColumnName = _ColumnsGrid.Key Then
                        If _ColumnsGrid.Visible = False Then
                            _ArrayRemoveColumn.Add(_ExcelColumns.ColumnName)
                        Else
                            Dim ColumnName As String = _ColumnsGrid.Caption
                            If RdbUseColumnSets.Checked AndAlso _ColumnsGrid.ColumnSet IsNot Nothing Then
                                If _ColumnsGrid.ColumnSet.Key = "ColumnSetMap" Then
                                    ColumnName = _ColumnsGrid.Caption + If(_ColumnsGrid.Caption.Contains("-مپ"), "", "-مپ")
                                ElseIf _ColumnsGrid.ColumnSet.Key = "ColumnSetCatalogueSystem" Then
                                    ColumnName = _ColumnsGrid.Caption + If(_ColumnsGrid.Caption.Contains("-سامانه"), "", "-سامانه")
                                End If
                                _ExcelColumns.ColumnName = ColumnName
                            End If
                        End If
                    End If
                Next
            Next
            If _ArrayRemoveColumn.Count > 0 Then
                For Each RemoveItems As String In _ArrayRemoveColumn
                    DtExportExcel.Columns.Remove(RemoveItems)
                Next
            End If
        End If



        If DtExportExcel.Rows.Count > 0 Then
            For Each colt As DataColumn In DtExportExcel.Columns
                For Each rowt As DataRow In DtExportExcel.Rows
                    If Not IsDBNull(rowt(colt)) Then
                        rowt(colt) = rowt(colt).ToString.Replace("<", "").Replace(">", "")
                    End If
                Next
            Next

        End If


        Try
            _SharedItems.ExcellExport("لیست اکسل ثبت های اسکن محصولات بارکد خوان", DtExportExcel)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکالی در ساخت فایل اکسل به وجود آمده است.", MsgBoxStyle.Exclamation, "خطا")
        End Try

        '---------- HB_14030410_ Export Excel _End


    End Sub
End Class
