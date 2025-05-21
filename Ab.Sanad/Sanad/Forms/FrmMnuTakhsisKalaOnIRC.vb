

' OK
'Author ::نوشین علیپور و علی اصغر توکلی
'CreateDate :: 14030917
'ModifiedDate:: 14031001
'Description:: تخصیص کالا به بارکد
'System ::انبار


Imports Janus.Windows.GridEX
Imports Anbar.BRL
Imports Janus.Windows.GridEX.Export

Public Class FrmTakhsisKalaOnIRC
    Inherits Minoo.Base.FTBaseForm
    Private components As System.ComponentModel.IContainer
    Private Shared m_vb6formdefinstance As FrmTakhsisKalaOnIRC
    Private Shared m_initializingdefinstance As Boolean
    Private WithEvents dataView As CDataView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPageScanRecords As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridBarcodeMaster As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl3 As TabControl
    'Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GridBarcodeDetail As Janus.Windows.GridEX.GridEX
    'Friend WithEvents GridBarcodeTajmie As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As Label
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
    Friend WithEvents ChkTikWithoutMoghayerat As CheckBox
    'Friend WithEvents LinkLabelEbtalSabt As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    '------------------------------------------------------------------------------
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents PanelDetailCom As Panel
    Friend WithEvents PanelDetailNav As Panel
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents Label1 As Label

    Public Sub New()
        MyBase.New()

        InitializeComponent()
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

    Public Shared Property DefInstance() As FrmTakhsisKalaOnIRC

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmTakhsisKalaOnIRC
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmTakhsisKalaOnIRC)
            m_vb6formdefinstance = Value

        End Set

    End Property

    Private Sub InitializeComponent()
        Dim GridBarcodeMaster_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTakhsisKalaOnIRC))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkTikWithoutMoghayerat = New System.Windows.Forms.CheckBox()
        Me.ChkGetLastData = New System.Windows.Forms.CheckBox()
        Me.GrpDate = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSabtResid = New Janus.Windows.EditControls.UIButton()
        Me.BtnRefreshData = New Janus.Windows.EditControls.UIButton()
        Me.LinkLoadLayout = New System.Windows.Forms.LinkLabel()
        Me.LinkSaveLayout = New System.Windows.Forms.LinkLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageScanRecords = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridBarcodeMaster = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelDetailCom = New System.Windows.Forms.Panel()
        Me.PanelDetailNav = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageScanRecords.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDetailCom
        '
        Me.PanelDetailCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailCom.Location = New System.Drawing.Point(1138, 160)
        Me.PanelDetailCom.Name = "MyPanelCommand"
        Me.PanelDetailCom.Size = New System.Drawing.Size(214, 40)
        Me.PanelDetailCom.TabIndex = 3
        '
        'PanelDetailNav
        '
        Me.PanelDetailNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailNav.Location = New System.Drawing.Point(3, 158)
        Me.PanelDetailNav.Name = "MyPanelNav"
        Me.PanelDetailNav.Size = New System.Drawing.Size(214, 38)
        Me.PanelDetailNav.TabIndex = 2
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.Location = New System.Drawing.Point(3, 4)
        Me.PanelDetail.MaximumSize = New System.Drawing.Size(2000, 275)
        Me.PanelDetail.Name = "MyPanel"
        Me.PanelDetail.Size = New System.Drawing.Size(1350, 153)
        Me.PanelDetail.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ChkTikWithoutMoghayerat)
        Me.Panel3.Controls.Add(Me.ChkGetLastData)
        Me.Panel3.Controls.Add(Me.GrpDate)
        Me.Panel3.Controls.Add(Me.Label3)
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
        Me.ChkTikWithoutMoghayerat.Location = New System.Drawing.Point(540, 5)
        Me.ChkTikWithoutMoghayerat.Name = "ChkTikWithoutMoghayerat"
        Me.ChkTikWithoutMoghayerat.Size = New System.Drawing.Size(193, 52)
        Me.ChkTikWithoutMoghayerat.TabIndex = 217
        Me.ChkTikWithoutMoghayerat.Text = "موارد بدون مغایرت و بدون کسری اضافی تیک زده شود"
        Me.ChkTikWithoutMoghayerat.UseVisualStyleBackColor = False
        Me.ChkTikWithoutMoghayerat.Visible = False
        '
        'ChkGetLastData
        '
        Me.ChkGetLastData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkGetLastData.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ChkGetLastData.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkGetLastData.ForeColor = System.Drawing.Color.Black
        Me.ChkGetLastData.Location = New System.Drawing.Point(739, 5)
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
        Me.TxtFromDate.Location = New System.Drawing.Point(159, 18)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 176
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 218
        '
        'BtnSabtResid
        '
        Me.BtnSabtResid.Location = New System.Drawing.Point(0, 0)
        Me.BtnSabtResid.Name = "BtnSabtResid"
        Me.BtnSabtResid.Size = New System.Drawing.Size(75, 23)
        Me.BtnSabtResid.TabIndex = 219
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnRefreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshData.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRefreshData.Location = New System.Drawing.Point(938, 5)
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
        Me.LinkLoadLayout.Location = New System.Drawing.Point(526, 13)
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
        Me.TabControl1.Controls.Add(Me.TabPageScanRecords)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1368, 569)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageScanRecords
        '
        Me.TabPageScanRecords.Controls.Add(Me.SplitContainer1)
        Me.TabPageScanRecords.Location = New System.Drawing.Point(4, 23)
        Me.TabPageScanRecords.Name = "TabPageScanRecords"
        Me.TabPageScanRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageScanRecords.Size = New System.Drawing.Size(1360, 542)
        Me.TabPageScanRecords.TabIndex = 1
        Me.TabPageScanRecords.Text = "تخصیص کالا به بارکد "
        Me.TabPageScanRecords.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
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
        Me.SplitContainer1.SplitterDistance = 339
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GridBarcodeMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(2000, 800)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 339)
        Me.Panel1.TabIndex = 0
        '
        'GridBarcodeMaster
        '
        Me.GridBarcodeMaster.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DisplayedCellsAndHeader
        GridBarcodeMaster_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeMaster_DesignTimeLayout.LayoutString")
        Me.GridBarcodeMaster.DesignTimeLayout = GridBarcodeMaster_DesignTimeLayout
        Me.GridBarcodeMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcodeMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridBarcodeMaster.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeMaster.FlatBorderColor = System.Drawing.SystemColors.WindowText
        Me.GridBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeMaster.GroupByBoxVisible = False
        Me.GridBarcodeMaster.Location = New System.Drawing.Point(0, 0)
        Me.GridBarcodeMaster.MaximumSize = New System.Drawing.Size(0, 500)
        Me.GridBarcodeMaster.Name = "GridBarcodeMaster"
        Me.GridBarcodeMaster.RecordNavigator = True
        Me.GridBarcodeMaster.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeMaster.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeMaster.Size = New System.Drawing.Size(1354, 339)
        Me.GridBarcodeMaster.TabIndex = 14
        Me.GridBarcodeMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.PanelDetailCom)
        Me.Panel2.Controls.Add(Me.PanelDetailNav)
        Me.Panel2.Controls.Add(Me.PanelDetail)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(2000, 600)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1354, 193)
        Me.Panel2.TabIndex = 1
        '
        'PanelDetailCom
        '
        Me.PanelDetailCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailCom.Location = New System.Drawing.Point(1137, 152)
        Me.PanelDetailCom.Name = "PanelDetailCom"
        Me.PanelDetailCom.Size = New System.Drawing.Size(214, 37)
        Me.PanelDetailCom.TabIndex = 6
        '
        'PanelDetailNav
        '
        Me.PanelDetailNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailNav.Location = New System.Drawing.Point(2, 152)
        Me.PanelDetailNav.Name = "PanelDetailNav"
        Me.PanelDetailNav.Size = New System.Drawing.Size(214, 38)
        Me.PanelDetailNav.TabIndex = 5
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.Location = New System.Drawing.Point(0, 3)
        Me.PanelDetail.MaximumSize = New System.Drawing.Size(2000, 275)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(1354, 145)
        Me.PanelDetail.TabIndex = 7
        '
        'FrmTakhsisKalaOnIRC
        '
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1368, 634)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmTakhsisKalaOnIRC"
        Me.Text = "تخصیص محصول به ثبت های بارکدخوان"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.GrpDate.ResumeLayout(False)
        Me.GrpDate.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageScanRecords.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Dim abRule As New ClsDataAccessRule
    Dim DSCatalogue As New DataView
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
    Public WithEvents DVDetail As CDataView


    Private Sub FrmTakhsisKalaOnIRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Me.LinkExportExcelBarcodeTajmie.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold) 'HB_14030410
        'Me.LinkExportExcelBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Bold) 'HB_14030410

        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)
        TxtFromDate.Text = TxtToDate.Text.Substring(0, 8) + "01"

        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")



        'For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeTajmie.RootTable.Columns
        '    colf.HeaderAlignment = TextAlignment.Center
        '    colf.TextAlignment = TextAlignment.Center
        'Next

        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeDetail.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeMaster.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        Call BtnRefreshData_Click(sender, e)
    End Sub
    Private Sub BtnRefreshData_Click(sender As Object, e As EventArgs)



        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")
        If IsSabtResidActive Then
            Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
            NoControlBatchFactorAndMarjooei = IIf(CApp.GetAppConfig("gVahedeTejariNoControlBatchBetweenFactorAndMarjooei") Is System.DBNull.Value, False, CApp.GetAppConfig("gVahedeTejariNoControlBatchBetweenFactorAndMarjooei"))


            Dim wfrm As New Anbar.Common.Frmwait
            wfrm.Show()
            Try


                wfrm.Label3.Text = "...سیستم در حال بروزرسانی آخرین اطلاعات می باشد..."
                wfrm.Refresh()


                Try
                    CInitDetailDataView()
                    Dim Test As DataView = abRule.GetBarcodeThatsNotHaveProduct(cn)

                    DSCatalogue = Test
                    DSCatalogue.AllowEdit = False

                    If Not DSCatalogue Is Nothing Then

                        Dim a As DataGridView = New DataGridView()
                        GridBarcodeMaster.DataSource = DSCatalogue
                        GridBarcodeMaster.Refresh()
                        GridBarcodeMaster.AutoSizeColumns()
                        GridBarcodeMaster.FilterMode = FilterMode.None

                        GridBarcodeMaster.AllowAddNew = InheritableBoolean.False
                        GridBarcodeMaster.AllowEdit = InheritableBoolean.False
                        GridBarcodeMaster.AllowDelete = InheritableBoolean.False
                    Else
                        Exit Sub

                    End If
                Catch ex As Exception
                    CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا!")
                End Try


                GridBarcodeMaster.AutoSizeColumns()



            Catch ex As Exception
            Finally
                wfrm.Close()
            End Try


    End Sub
    Private Sub GridBarcodeMaster_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeMaster.DoubleClick
        GridBarcodeMaster.AutoSizeColumns()
    End Sub
    Private Sub GridBarcodeMaster_SelectionChanged(sender As Object, e As EventArgs) Handles GridBarcodeMaster.SelectionChanged
        Dim SqlWhere As String = "ProductCatalogueSn = "
        Dim productcatalogueSn As Decimal = CDec(GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value)
        If productcatalogueSn = 0 Then
            MsgBox("رکوردی انتخاب نشد", MsgBoxStyle.OkOnly)
        End If
        If DVDetail.DataRows > 0 Then
            DVDetail.Fields("kalaSN").ReadOnly = True
            DVDetail.Fields("kalaSN").Component.Enabled = False
        Else
            DVDetail.Fields("kalaSN").ReadOnly = False
            DVDetail.Fields("kalaSN").Component.Enabled = True
        End If

        SqlWhere = String.Concat(SqlWhere, productcatalogueSn.ToString())
        DVDetail.SQLWhere = SqlWhere
        DVDetail.Refresh()
        If DVDetail.DataRows > 0 Then
            DVDetail.CommandEnabled(EnumCommands.cmAdd) = False
        Else
            DVDetail.CommandEnabled(EnumCommands.cmAdd) = True
        End If
    End Sub


    Private Sub CInitDetailDataView()
        DVDetail = New CDataView(cn)
        With DVDetail
            .TableName = "abProductCatalogueKalaIRC"
            .Init(PanelDetail,, PanelDetailCom, PanelDetailNav, EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdInsert _
                  Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFind)
            .AddJoin("abProductCatalogueKalaIRC", EnumTableJoin.tjInnerJoin, "paKala", "KalaSN", "KalaSN")
            .SQLWhere = "productCatalogueSn = 0"
            .EditInGrid = True
            With .Fields
                With .Add("ProductCatalogueNewIRCSN", "", gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("ProductCatalogueSN", "", EnumFieldOptions.foHidden)
                End With

                With .Add("KalaSN->{paKala.KalaNO + ' _ ' + paKala.KalaDS} AS KalaSN", "DataCombo")
                    .Caption = "نام کالا"
                    .ComboWhereCondition = "Kalasn in (select kalasn from pakala where len(isnull(paKala.IRC,''))>10 And len(isnull(paKala.GTIN,''))>10 )"
                    .RefreshCombo()
                    .ComboLateBinding = True
                End With
                With .Add("abProductCatalogueKalaIRC.NewIRC")
                    .Caption = "جدیدIRC"
                    .ReadOnly = True
                End With
                With .Add("abProductCatalogueKalaIRC.NewGTIN")
                    .Caption = "جدیدGTIN"
                    .ReadOnly = True
                End With
                With .Add("UserID_Name", "", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
            End With
            .Refresh()
        End With
    End Sub
    Private Sub DVDetail_AfterCommandClick(aCommand As EnumCommands) Handles DVDetail.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd

                DVDetail.Fields("NewIRC").Value = GridBarcodeMaster.CurrentRow.Cells("IRC").Value
                DVDetail.Fields("NewGTIN").Value = GridBarcodeMaster.CurrentRow.Cells("GTIN").Value
                DVDetail.Fields("ProductCatalogueSN").Value = GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value
        End Select
    End Sub
End Class