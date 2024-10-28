Imports C1.Win.C1FlexGrid.Classic
Imports Janus.Windows.GridEX

Public Class FrmabAnbarGardaniEnghezaDate
    Inherits Minoo.Base.FTBaseForm


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
    Private Shared m_vb6formdefinstance As FrmabAnbarGardaniEnghezaDate
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelMasterCom As Panel
    Friend WithEvents PanelMasterNav As Panel
    Friend WithEvents PanelMaster As Panel
    Friend WithEvents BtnTaeedRayeesShobe As Button
    Friend WithEvents BtnAnbarGardaniEnghezaDateTaeedHesabdari As Button
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents btnEbtal As Button
    Friend WithEvents BtnPayanShomaresh As Button
    Friend WithEvents BtnUpdateMojoudiSystem As Button
    Friend WithEvents BtnKalaNErkh As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageKala As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnFormatEXcel As Button
    Friend WithEvents TxtDrive As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGetExcel As Button
    Friend WithEvents PanelDetailCom As Panel
    Friend WithEvents PanelDetailNav As Panel
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents TabPageKasriEzafi As TabPage
    Friend WithEvents TabPageShowReportKalaRahgiri As TabPage
    Public WithEvents GridReport As GridEX
    Friend WithEvents TabPageShowReportKala As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExport2Excel As Button

    Public Shared Property DefInstance() As FrmabAnbarGardaniEnghezaDate

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabAnbarGardaniEnghezaDate
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabAnbarGardaniEnghezaDate)
            m_vb6formdefinstance = Value

        End Set

    End Property

#Region "Property"

    Private _AnbarGardaniTypeSN As Int16
    Friend Property AnbarGardaniTypeSN() As Int16
        Get
            AnbarGardaniTypeSN = _AnbarGardaniTypeSN
        End Get
        Set(ByVal Value As Int16)
            _AnbarGardaniTypeSN = Value
        End Set
    End Property
#End Region

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridReport_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabAnbarGardaniEnghezaDate))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BtnKalaNErkh = New System.Windows.Forms.Button()
        Me.BtnUpdateMojoudiSystem = New System.Windows.Forms.Button()
        Me.btnEbtal = New System.Windows.Forms.Button()
        Me.BtnPayanShomaresh = New System.Windows.Forms.Button()
        Me.BtnTaeedRayeesShobe = New System.Windows.Forms.Button()
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari = New System.Windows.Forms.Button()
        Me.PanelMasterCom = New System.Windows.Forms.Panel()
        Me.PanelMasterNav = New System.Windows.Forms.Panel()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageKala = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnFormatEXcel = New System.Windows.Forms.Button()
        Me.TxtDrive = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGetExcel = New System.Windows.Forms.Button()
        Me.PanelDetailCom = New System.Windows.Forms.Panel()
        Me.PanelDetailNav = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.TabPageKasriEzafi = New System.Windows.Forms.TabPage()
        Me.GridReport = New Janus.Windows.GridEX.GridEX()
        Me.TabPageShowReportKalaRahgiri = New System.Windows.Forms.TabPage()
        Me.TabPageShowReportKala = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExport2Excel = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageKala.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPageKasriEzafi.SuspendLayout()
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnKalaNErkh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnUpdateMojoudiSystem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEbtal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPayanShomaresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnTaeedRayeesShobe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelMasterCom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelMasterNav)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelMaster)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1208, 558)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 0
        '
        'BtnKalaNErkh
        '
        Me.BtnKalaNErkh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnKalaNErkh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnKalaNErkh.Location = New System.Drawing.Point(453, 239)
        Me.BtnKalaNErkh.Name = "BtnKalaNErkh"
        Me.BtnKalaNErkh.Size = New System.Drawing.Size(115, 39)
        Me.BtnKalaNErkh.TabIndex = 7
        Me.BtnKalaNErkh.Text = "لیست نرخ کالاها"
        Me.BtnKalaNErkh.UseVisualStyleBackColor = False
        '
        'BtnUpdateMojoudiSystem
        '
        Me.BtnUpdateMojoudiSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdateMojoudiSystem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnUpdateMojoudiSystem.Location = New System.Drawing.Point(292, 239)
        Me.BtnUpdateMojoudiSystem.Name = "BtnUpdateMojoudiSystem"
        Me.BtnUpdateMojoudiSystem.Size = New System.Drawing.Size(155, 39)
        Me.BtnUpdateMojoudiSystem.TabIndex = 6
        Me.BtnUpdateMojoudiSystem.Text = "بروزرسانی موجودی سیستمی فایل انبارگردانی"
        Me.BtnUpdateMojoudiSystem.UseVisualStyleBackColor = False
        '
        'btnEbtal
        '
        Me.btnEbtal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEbtal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEbtal.Location = New System.Drawing.Point(812, 239)
        Me.btnEbtal.Name = "btnEbtal"
        Me.btnEbtal.Size = New System.Drawing.Size(96, 39)
        Me.btnEbtal.TabIndex = 4
        Me.btnEbtal.Text = "ابطال"
        Me.btnEbtal.UseVisualStyleBackColor = False
        '
        'BtnPayanShomaresh
        '
        Me.BtnPayanShomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPayanShomaresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnPayanShomaresh.Location = New System.Drawing.Point(701, 239)
        Me.BtnPayanShomaresh.Name = "BtnPayanShomaresh"
        Me.BtnPayanShomaresh.Size = New System.Drawing.Size(105, 39)
        Me.BtnPayanShomaresh.TabIndex = 5
        Me.BtnPayanShomaresh.Text = "پایان شمارش"
        Me.BtnPayanShomaresh.UseVisualStyleBackColor = False
        '
        'BtnTaeedRayeesShobe
        '
        Me.BtnTaeedRayeesShobe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTaeedRayeesShobe.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnTaeedRayeesShobe.Location = New System.Drawing.Point(574, 239)
        Me.BtnTaeedRayeesShobe.Name = "BtnTaeedRayeesShobe"
        Me.BtnTaeedRayeesShobe.Size = New System.Drawing.Size(10, 39)
        Me.BtnTaeedRayeesShobe.TabIndex = 3
        Me.BtnTaeedRayeesShobe.Text = "تایید رییس شعبه"
        Me.BtnTaeedRayeesShobe.UseVisualStyleBackColor = False
        Me.BtnTaeedRayeesShobe.Visible = False
        '
        'BtnAnbarGardaniEnghezaDateTaeedHesabdari
        '
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.Location = New System.Drawing.Point(590, 239)
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.Name = "BtnAnbarGardaniEnghezaDateTaeedHesabdari"
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.Size = New System.Drawing.Size(105, 39)
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.TabIndex = 2
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.Text = "تایید حسابداری"
        Me.BtnAnbarGardaniEnghezaDateTaeedHesabdari.UseVisualStyleBackColor = False
        '
        'PanelMasterCom
        '
        Me.PanelMasterCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterCom.Location = New System.Drawing.Point(914, 239)
        Me.PanelMasterCom.Name = "PanelMasterCom"
        Me.PanelMasterCom.Size = New System.Drawing.Size(291, 40)
        Me.PanelMasterCom.TabIndex = 1
        '
        'PanelMasterNav
        '
        Me.PanelMasterNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterNav.Location = New System.Drawing.Point(3, 239)
        Me.PanelMasterNav.Name = "PanelMasterNav"
        Me.PanelMasterNav.Size = New System.Drawing.Size(283, 40)
        Me.PanelMasterNav.TabIndex = 1
        '
        'PanelMaster
        '
        Me.PanelMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMaster.Location = New System.Drawing.Point(3, 3)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(1202, 230)
        Me.PanelMaster.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageKala)
        Me.TabControl1.Controls.Add(Me.TabPageKasriEzafi)
        Me.TabControl1.Controls.Add(Me.TabPageShowReportKalaRahgiri)
        Me.TabControl1.Controls.Add(Me.TabPageShowReportKala)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1208, 272)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageKala
        '
        Me.TabPageKala.Controls.Add(Me.Panel1)
        Me.TabPageKala.Location = New System.Drawing.Point(4, 23)
        Me.TabPageKala.Name = "TabPageKala"
        Me.TabPageKala.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKala.Size = New System.Drawing.Size(1200, 245)
        Me.TabPageKala.TabIndex = 0
        Me.TabPageKala.Text = "اقلام انبارگردانی"
        Me.TabPageKala.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnExport2Excel)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnFormatEXcel)
        Me.Panel1.Controls.Add(Me.TxtDrive)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnGetExcel)
        Me.Panel1.Controls.Add(Me.PanelDetailCom)
        Me.Panel1.Controls.Add(Me.PanelDetailNav)
        Me.Panel1.Controls.Add(Me.PanelDetail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 239)
        Me.Panel1.TabIndex = 0
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnDelete.Location = New System.Drawing.Point(820, 195)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(91, 39)
        Me.BtnDelete.TabIndex = 237
        Me.BtnDelete.Text = "حذف انتخابی"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnFormatEXcel
        '
        Me.BtnFormatEXcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFormatEXcel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnFormatEXcel.Location = New System.Drawing.Point(349, 195)
        Me.BtnFormatEXcel.Name = "BtnFormatEXcel"
        Me.BtnFormatEXcel.Size = New System.Drawing.Size(91, 39)
        Me.BtnFormatEXcel.TabIndex = 236
        Me.BtnFormatEXcel.Text = "فرمت اکسل"
        Me.BtnFormatEXcel.UseVisualStyleBackColor = False
        '
        'TxtDrive
        '
        Me.TxtDrive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDrive.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDrive.Location = New System.Drawing.Point(322, 204)
        Me.TxtDrive.Name = "TxtDrive"
        Me.TxtDrive.Size = New System.Drawing.Size(18, 22)
        Me.TxtDrive.TabIndex = 234
        Me.TxtDrive.Text = "D"
        Me.TxtDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "Drive :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnGetExcel
        '
        Me.BtnGetExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGetExcel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGetExcel.Location = New System.Drawing.Point(446, 195)
        Me.BtnGetExcel.Name = "BtnGetExcel"
        Me.BtnGetExcel.Size = New System.Drawing.Size(91, 39)
        Me.BtnGetExcel.TabIndex = 233
        Me.BtnGetExcel.Text = "دریافت از اکسل"
        Me.BtnGetExcel.UseVisualStyleBackColor = False
        '
        'PanelDetailCom
        '
        Me.PanelDetailCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailCom.Location = New System.Drawing.Point(920, 195)
        Me.PanelDetailCom.Name = "PanelDetailCom"
        Me.PanelDetailCom.Size = New System.Drawing.Size(270, 40)
        Me.PanelDetailCom.TabIndex = 232
        '
        'PanelDetailNav
        '
        Me.PanelDetailNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailNav.Location = New System.Drawing.Point(5, 195)
        Me.PanelDetailNav.Name = "PanelDetailNav"
        Me.PanelDetailNav.Size = New System.Drawing.Size(262, 40)
        Me.PanelDetailNav.TabIndex = 231
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.Location = New System.Drawing.Point(5, 3)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(1186, 186)
        Me.PanelDetail.TabIndex = 230
        '
        'TabPageKasriEzafi
        '
        Me.TabPageKasriEzafi.Controls.Add(Me.GridReport)
        Me.TabPageKasriEzafi.Location = New System.Drawing.Point(4, 23)
        Me.TabPageKasriEzafi.Name = "TabPageKasriEzafi"
        Me.TabPageKasriEzafi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKasriEzafi.Size = New System.Drawing.Size(1200, 245)
        Me.TabPageKasriEzafi.TabIndex = 1
        Me.TabPageKasriEzafi.Text = "گزارش کسری اضافی"
        Me.TabPageKasriEzafi.UseVisualStyleBackColor = True
        '
        'GridReport
        '
        Me.GridReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridReport_DesignTimeLayout.LayoutString = resources.GetString("GridReport_DesignTimeLayout.LayoutString")
        Me.GridReport.DesignTimeLayout = GridReport_DesignTimeLayout
        Me.GridReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridReport.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridReport.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridReport.GroupByBoxVisible = False
        Me.GridReport.Location = New System.Drawing.Point(3, 3)
        Me.GridReport.Name = "GridReport"
        Me.GridReport.RecordNavigator = True
        Me.GridReport.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReport.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.Size = New System.Drawing.Size(1194, 239)
        Me.GridReport.TabIndex = 17
        Me.GridReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TabPageShowReportKalaRahgiri
        '
        Me.TabPageShowReportKalaRahgiri.Location = New System.Drawing.Point(4, 23)
        Me.TabPageShowReportKalaRahgiri.Name = "TabPageShowReportKalaRahgiri"
        Me.TabPageShowReportKalaRahgiri.Size = New System.Drawing.Size(1200, 245)
        Me.TabPageShowReportKalaRahgiri.TabIndex = 2
        Me.TabPageShowReportKalaRahgiri.Text = "مشاهده گزارش کسری اضافی در سطح کالا رهگیری"
        Me.TabPageShowReportKalaRahgiri.UseVisualStyleBackColor = True
        '
        'TabPageShowReportKala
        '
        Me.TabPageShowReportKala.Location = New System.Drawing.Point(4, 23)
        Me.TabPageShowReportKala.Name = "TabPageShowReportKala"
        Me.TabPageShowReportKala.Size = New System.Drawing.Size(1200, 245)
        Me.TabPageShowReportKala.TabIndex = 3
        Me.TabPageShowReportKala.Text = "مشاهده گزارش کسری اضافی در سطح کالا"
        Me.TabPageShowReportKala.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 200000
        '
        'btnExport2Excel
        '
        Me.btnExport2Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport2Excel.Location = New System.Drawing.Point(543, 195)
        Me.btnExport2Excel.Name = "btnExport2Excel"
        Me.btnExport2Excel.Size = New System.Drawing.Size(97, 39)
        Me.btnExport2Excel.TabIndex = 238
        Me.btnExport2Excel.Text = "ذخیره در اکسل"
        Me.btnExport2Excel.UseVisualStyleBackColor = True
        '
        'FrmabAnbarGardaniEnghezaDate
        '
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1208, 558)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmabAnbarGardaniEnghezaDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageKala.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPageKasriEzafi.ResumeLayout(False)
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DVabAnbarGardani As CDataView
    Private WithEvents DVabAnbarGardaniHA As CDataView
    Private WithEvents dbcNerkh As NetSql.Components.DataCombo
    Dim Today As String
    Dim DVKalaNerkh As DataView
    Private Sub FromabAnbarGardaniEnghezaDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Today = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        '----------
        'Edited by Tavakoli
        'taghir function Convert(int,nerkh) be Convert(BigInt,nerkh) be elat error OverFlow .....
        DVKalaNerkh = cn.ExecuteQuery("Select distinct p.KalaSN,KalaNo,KalaDs,Convert(BigInt,Nerkh) Nerkh from ( Select  * from ( " &
                                        "select KalaSN,isnull(MasrafFee,VahedFee) Nerkh, " &
                                        "ROW_NUMBER() Over(partition by KalaSN Order by gdate Desc ) IDR " &
                                        "from foKalaGheymatHa join foKalaGheymat on foKalaGheymat.KalaGheymatSN=foKalaGheymatHa.KalaGheymatSN " &
                                        "where coalesce(MasrafFee,VahedFee,0)>0)p where IDR<=10)p join paKala on pakala.KalaSN=p.KalaSN " &
                                        "Order by p.KalaSN desc,Nerkh Desc")
        'btnEbtal.Visible = If(gVahedeTejariSN < 15.935, False, True)
        'btnExport2Excel.Visible = If(gVahedeTejariSN < 15.935, False, True)
        'BtnAnbarGardaniEnghezaDateTaeedHesabdari.Visible = If(gVahedeTejariSN < 15.935, False, True)
        'BtnDelete.Visible = If(gVahedeTejariSN < 15.935, False, True)

        InitDataView()
        BtnAnbarGardaniEnghezaDateTaeedHesabdari.Visible = gSM.ActionVisible(BtnAnbarGardaniEnghezaDateTaeedHesabdari.Name)

    End Sub

    Private Sub BtnTaeedHesabdari_Click(sender As Object, e As EventArgs) Handles BtnAnbarGardaniEnghezaDateTaeedHesabdari.Click
        Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
        Dim gMoghayeratDarTarikhanbargardaniVaTarikhroozMojaz As Boolean = False

        If CApp.GetAppConfig("gAnbargardaniEnghezaDateTaeedHesabdari") Is System.DBNull.Value Then
            gMoghayeratDarTarikhanbargardaniVaTarikhroozMojaz = False
        Else
            gMoghayeratDarTarikhanbargardaniVaTarikhroozMojaz = CBool(CApp.GetAppConfig("gAnbargardaniEnghezaDateTaeedHesabdari"))
        End If
        Today = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        If DVabAnbarGardani.FieldValue("InsDate") <> Today And Not gMoghayeratDarTarikhanbargardaniVaTarikhroozMojaz Then
            CSystem.MsgBox("تاریخ انبارگردانی می بایست با تاریخ روز جاری برابر باشد ", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If
        If CSystem.MsgBox("آیا مایل به تایید فایل انبارگردانی شماره " + vbNewLine + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNo") + " . " + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS") +
                          vbNewLine + " می باشید؟" + vbNewLine + "با ادامه عملیات در صورت وجود مغایرت بین شمارش واقعی و سیستمی اسناد کسری اضافی در سیستم ثبت خواهد شد!", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "تایید") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Errmsg As String = ""
        Try
            cn.CallSP("_abSPC_Change_AnbarGardaniEnghezaDateStatus", CDec(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), 30,
                      gSM.UserID, gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName, Errmsg)
            If Errmsg = "" Then
                CSystem.MsgBox("عملیات با موفقیت انجام شد", MsgBoxStyle.Information, "")
            Else
                CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + Errmsg, MsgBoxStyle.Critical, "")
            End If
            DVabAnbarGardani.Refresh()
        Catch ex As Exception
            CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub BtnTaeedRayeesShobe_Click(sender As Object, e As EventArgs) Handles BtnTaeedRayeesShobe.Click
        'If CSystem.MsgBox("آیا مایل به تایید فایل انبارگردانی شماره " + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNo") + "." + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS") + " می باشید؟", MsgBoxStyle.YesNo, "تایید") = MsgBoxResult.No Then
        '    Exit Sub
        'End If
        'Try
        '    cn.ExecuteNoneQuery("update abAnbarGardaniEnghezaDate set Status= 12  where [AnbarGardaniEnghezaDateSN]=" & DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN"))
        '    DVabAnbarGardani.Refresh()
        'Catch ex As Exception
        '    CSystem.MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub InitDataView()
        Dim DvMah As DataView = cn.ExecuteQuery("select MahDs + ' ' + cast(SalNo  as varchar) from btMah join btSal on btMah.SalSN=btSal.SalSN where MahCode= dbo.btFn_GetCurrentMahCode()")
        DVabAnbarGardani = New CDataView(cn)
        With DVabAnbarGardani
            .Init(PanelMaster, , PanelMasterCom, PanelMasterNav, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abAnbarGardaniEnghezaDate"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbarGardaniStatus", "Status", "AnbarGardaniStatus")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbarGardaniType", "AnbarGardaniTypeSN", "AnbarGardaniTypeSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbar", "AnbarSN", "AnbarSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanad", "KasriSanadSN", "SanadSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanad", "SarakSanadSN", "SanadSN")


            .Text = Me.Text

            .SQLWhere = " abAnbarGardaniEnghezaDate.AnbarSN = " & CStr(gAnbarSN) & " and StartDate BETWEEN " & gHesabdariSalFDate &
            " And  " & gHesabdariSalTDate & " and EndDate BETWEEN " & gHesabdariSalFDate & " and  " & gHesabdariSalTDate

            .SQLOrderBy = " Status , InsDate DESC "
            .EditInGrid = True
            .AccessRight = If(gVahedeTejariSN < 15.935, EnumAccessRight.arView, gSM.TableAccessRight(.TableName))
            .AutoFetchCurrentRow = True
            With .Fields
                With .Add("AnbarGardaniEnghezaDateSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("AnbarSN->abAnbar.AnbarDs", "DataCombo")
                    .ComboWhereCondition = " abAnbar.AnbarSN = " & gAnbarSN
                    .ComboLateBinding = True
                    .DefaultValue = gAnbarSN
                    .Component.Enabled = False
                    .ReadOnly = True
                    .Caption = "انبار"
                End With
                With .Add("AnbarGardaniEnghezaDateNO", "TextBox")
                    .ReadOnly = True
                    .Caption = "کد"
                End With
                With .Add("AnbarGardaniEnghezaDateDS", "TextBox")
                    .Caption = "شرح"
                    .DefaultValue = gAnbarDS + " - " + If(DvMah.Count > 0, DvMah(0)(0).ToString, gHesabdariSal.ToString)
                End With
                With .Add("AnbarGardaniTypeSN->AnbarGardaniTypeDS", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = 3
                    .ReadOnly = True
                End With
                With .Add("StartDate", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gHesabdariSalFDate
                    .ReadOnly = True
                End With
                With .Add("EndDate", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gHesabdariSalTDate
                    .ReadOnly = True

                End With
                With .Add("InsDate", "TextBox", EnumFieldOptions.foDate)
                    .DefaultValue = Today
                    .Caption = "تاریخ انبارگردانی"
                End With
                With .Add("Status->abAnbarGardani.AnbarGardaniStatusDS", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abAnbarGardani.AnbarGardaniStatus")
                    .DefaultValue = 1
                    .Component.Enabled = False
                    .ReadOnly = True
                    .Caption = "وضعیت"
                End With
                With .Add("KasriSanadSN->SanadNo")
                    .Caption = cn.FieldCaption("abAnbarGardani.KasriSanadSN")
                    .ReadOnly = True
                End With
                With .Add("SarakSanadSN->SanadNo")
                    .Caption = cn.FieldCaption("abAnbarGardani.SarakSanadSN")
                    .ReadOnly = True
                End With

                .Add("Tozih", "TextBox", EnumFieldOptions.foDefault).Caption = "توضیح"
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        DVabAnbarGardaniHA = New CDataView(cn)
        With DVabAnbarGardaniHA
            .Init(PanelDetail, , PanelDetailCom, PanelDetailNav, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdFilter _
                                                                     Or EnumButtonOptions.boCmdInsert _
                                                                     Or EnumButtonOptions.boCmdDelete _
                                                                     Or EnumButtonOptions.boCmdUpdate)
            .TableName = "abAnbarGardaniHaEnghezaDate"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVw_paKalaTaminFull", "KalaSN", "KalaSN")

            .Text = Me.Text
            .AccessRight = If(gVahedeTejariSN < 15.935, EnumAccessRight.arView, gSM.TableAccessRight(.TableName))
            .EditInGrid = True


            With .Fields
                With .Add("AnbarGardaniEnghezaDateHaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("AnbarGardaniEnghezaDateSN", , EnumFieldOptions.foHidden)
                End With

                With .Add("KalaSN->paKala.{Cast(KalaNo as varchar)+ '.'+ KalaDS} AS KalaDS", "DataCombo")
                    .Caption = "نام کالا"
                    .ComboWhereCondition = "KalaSN In (Select paKala.KalaSN from paKala join paKalaTamin on paKalaTamin.KalaSN=paKala.KalaSN " &
                                    "Join paVahedeTejari on paVahedeTejari.VahedeTejariSN=paKalaTamin.VahedeTejariSN " &
                                    "Join abAnbarKala on abAnbarKala.KalaSN=paKala.KalaSN where KalaStatus=1 and NoeVahedeTejariSN not in (14.935,16.935) and AnbarSN=" & gAnbarSN.ToString & ")"
                    .RefreshCombo()
                End With
                With .Add("{isnull((select  Top 1 TedadAjza from paVahedeSanjeshKala where KalaSN=abAnbarGardaniHaEnghezaDate.KalaSN  and Pishfarz=1),1)} TedadAjza ", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "تعداد در کارتن"
                    .ReadOnly = True
                End With
                With .Add("TolidDate", "TextBox", EnumFieldOptions.foDate)
                    .Caption = "تاریخ تولید"
                End With
                With .Add("EnghezaDate", "TextBox", EnumFieldOptions.foDate)
                    .Caption = "تاریخ انقضاء"
                End With
                With .Add("Nerkh", "datacombo", EnumFieldOptions.foDefault)
                    .Caption = "نرخ مصرف کننده"
                    dbcNerkh = .Component
                    .ComboLateBinding = True
                End With

                With .Add("MojoudiReal", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "موجودی واقعی"
                    .DataType = "int"
                End With
                With .Add("{MojoudiReal/isnull((select  Top 1 TedadAjza from paVahedeSanjeshKala where KalaSN=abAnbarGardaniHaEnghezaDate.KalaSN  and Pishfarz=1),1)} MojoudiRealKarton ", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "موجودی واقعی(کارتن)"
                    .DataType = "int"
                    .ReadOnly = True
                End With
                With .Add("MojoudiSystem", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "موجودی سیستم"
                    .DataType = "int"
                    .ReadOnly = True
                    .DefaultValue = 0
                End With
                With .Add("{MojoudiSystem/isnull((select  Top 1 TedadAjza from paVahedeSanjeshKala where KalaSN=abAnbarGardaniHaEnghezaDate.KalaSN  and Pishfarz=1),1)} MojoudiSystem", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "موجودی سیستم(کارتن)"
                    .DataType = "int"
                    .ReadOnly = True
                End With
                'With .Add("{MojoudiReal-MojoudiSystem} AS KasriEzafi", "TextBox", EnumFieldOptions.foDefault)
                '    .Caption = "کسری/اضافی"
                '    .DataType = "int"
                '    .ReadOnly = True
                '    .DefaultValue = 0
                'End With
                'With .Add("{(MojoudiReal-MojoudiSystem)/isnull((select  Top 1 TedadAjza from paVahedeSanjeshKala where KalaSN=abAnbarGardaniHaEnghezaDate.KalaSN  and Pishfarz=1),1)}  AS KasriEzafiKarton", "TextBox", EnumFieldOptions.foDefault)
                '    .Caption = "کسری/اضافی(کارتن)"
                '    .DataType = "int"
                '    .ReadOnly = True
                'End With
                With .Add("Tozih", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "توضیح"
                End With

                With .Add("{TaminVahedeTejariDs} as TaminVahedeTejariDs", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "تامین کننده"
                    .ReadOnly = True
                End With
                With .Add("{NoeVahedeTejariDs} as NoeVahedeTejariDs", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "نوع تامین کننده"
                    .ReadOnly = True
                End With
                With .Add("InsertType", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = 1
                End With
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
            End With
            .Parent = DVabAnbarGardani
        End With
        DVabAnbarGardani.Refresh()

    End Sub

    Private Sub DVabAnbarGardani_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DVabAnbarGardani.CommandClick
        If aCommand = EnumCommands.cmAdd Then
            If Today.Substring(0, 4) <> gHesabdariSal.ToString Then
                CSystem.MsgBox("سال مالی سیستم " + gHesabdariSal.ToString + " انتخاب شده است.لطفا سالی مالی را به سال جاری تغییر داده و عملیات را ادامه دهید", MsgBoxStyle.Exclamation)
                aCancel = True
            End If
        End If
    End Sub

    Private Sub DVabAnbarGardani_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVabAnbarGardani.FillDetailsWithData
        DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmAdd) = False
        DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmEdit) = False
        DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmDelete) = False
        DVabAnbarGardani.CommandEnabled(EnumCommands.cmEdit) = False
        DVabAnbarGardani.CommandEnabled(EnumCommands.cmDelete) = False
        BtnDelete.Enabled = False
        BtnGetExcel.Enabled = False
        BtnAnbarGardaniEnghezaDateTaeedHesabdari.Enabled = False
        BtnTaeedRayeesShobe.Enabled = False
        btnEbtal.Enabled = False
        BtnPayanShomaresh.Enabled = False
        BtnUpdateMojoudiSystem.Enabled = False
        'TabPageShowReportKalaRahgiri.Text = "مشاهده گزارش"
        ''ghasemi 14021107
        If BtnAnbarGardaniEnghezaDateTaeedHesabdari.Visible = True Then


            DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmEdit) = True
            'Select Case aCommand
            '    Case EnumCommands.cmEdit
            ' به علت ارتباط رديف سند با کالافيزيکي دسترسي اصلاح کالا گرفته ميشود

            With DVabAnbarGardaniHA
                        .Fields("TolidDate").ReadOnly = True


                    End With


            'End Select
        End If
        ''ghasemi 14021107

        If aFetched Then
            DVabAnbarGardaniHA.SQLWhere = "AnbarGardaniEnghezaDateSN=" & DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateSN")
            DVabAnbarGardaniHA.Refresh()
            BtnAnbarGardaniEnghezaDateTaeedHesabdari.Enabled = DVabAnbarGardani.FieldValue("Status") = 12
            BtnTaeedRayeesShobe.Enabled = DVabAnbarGardani.FieldValue("Status") = 12
            BtnPayanShomaresh.Enabled = DVabAnbarGardani.FieldValue("Status") = 4
            btnEbtal.Enabled = DVabAnbarGardani.FieldValue("Status") <= 12 AndAlso DVabAnbarGardani.FieldValue("Status") <> 8
            BtnDelete.Enabled = DVabAnbarGardani.FieldValue("Status") <= 4
            BtnGetExcel.Enabled = DVabAnbarGardani.FieldValue("Status") <= 4
            BtnUpdateMojoudiSystem.Enabled = DVabAnbarGardani.FieldValue("Status") = 4
            DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmAdd) = DVabAnbarGardani.FieldValue("Status") <= 4
            DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmEdit) = DVabAnbarGardani.FieldValue("Status") <= 4
            DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmDelete) = DVabAnbarGardani.FieldValue("Status") <= 4
            DVabAnbarGardani.CommandEnabled(EnumCommands.cmEdit) = DVabAnbarGardani.FieldValue("Status") <= 4
            DVabAnbarGardani.CommandEnabled(EnumCommands.cmDelete) = DVabAnbarGardani.FieldValue("Status") <= 4
            'TabPageShowReportKalaRahgiri.Text = "مشاهده گزارش کسری اضافی فایل انبارگردانی شماره  " + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNO") + "." + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS")

        End If
    End Sub

    Private Sub DVabAnbarGardani_GetGridProperties() Handles DVabAnbarGardani.GetGridProperties

    End Sub

    Private Sub DVabAnbarGardaniHA_GetDataValidation(aValues As Object, aErrMsgs As Object) Handles DVabAnbarGardaniHA.GetDataValidation

    End Sub

    Private Sub DVabAnbarGardaniHA_GetGridProperties() Handles DVabAnbarGardaniHA.GetGridProperties
        With DVabAnbarGardaniHA.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
            If DVabAnbarGardaniHA.DataRows > 0 Then
                .ColumnCollection("EnghezaDate").Style.BackColor = Color.Yellow
                .ColumnCollection("Nerkh").Style.BackColor = Color.Yellow
                .ColumnCollection("MojoudiReal").Style.BackColor = Color.Yellow
            End If
            .AutoResize = True
        End With

    End Sub

    Private Sub DVabAnbarGardaniHA_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DVabAnbarGardaniHA.CommandClick
        If aCommand = EnumCommands.cmAdd Then
            DVabAnbarGardaniHA.Fields("AnbarGardaniEnghezaDateSN").DefaultValue = DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")
        ElseIf aCommand = EnumCommands.cmSave Then

            If DVabAnbarGardaniHA.FieldValue("Nerkh") < 0 Then
                    CSystem.MsgBox("موجودی وارد شده نمی تواند منفی باشد", MsgBoxStyle.Critical, "")
                    aCancel = True
                End If
                DVKalaNerkh.RowFilter = "0=0"
                DVKalaNerkh.RowFilter = "KalaSN=" & DVabAnbarGardaniHA.FieldValue("KalaDS").ToString & " And Nerkh=" & DVabAnbarGardaniHA.FieldValue("Nerkh").ToString

                If DVKalaNerkh.Count = 0 Then
                    CSystem.MsgBox("نرخ وارد شده در لیست نرخ مصرف کننده(فروش) این محصول نیست")
                    aCancel = True
                End If

            End If
            ''ghasemi 14021107
            If BtnAnbarGardaniEnghezaDateTaeedHesabdari.Visible = True Then


            DVabAnbarGardaniHA.CommandEnabled(EnumCommands.cmEdit) = True
            Select Case aCommand
                Case EnumCommands.cmEdit
                    ' به علت ارتباط رديف سند با کالافيزيکي دسترسي اصلاح کالا گرفته ميشود

                    With DVabAnbarGardaniHA
                        .Fields("TolidDate").ReadOnly = True
                        ' .Fields("ShomarehRahgiriText").ReadOnly = True

                        '//اگر فلگ تاريخ توليد و انقضا تيک خورده باشد تاريخ توليد و انقضا باز مي شود
                        'With .Fields("ToolidDate")
                        '  If Val(DVabSanadHa.FieldValue("ToolidDateFlag")) <> 1 Then
                        '    .ReadOnly = True
                        '  Else
                        '    .ReadOnly = False
                        '  End If
                        'End With

                        'With .Fields("EnghezaDate")
                        '  If Val(DVabSanadHa.FieldValue("EnghezaDateFlag")) <> 1 Then
                        '    .ReadOnly = True
                        '  Else
                        '    .ReadOnly = False
                        '  End If
                        'End With
                        '//اگر فلگ تاريخ توليد و انقضا تيک خورده باشد تاريخ توليد و انقضا باز مي شود

                    End With

                    '    vcmAdd = False
                    'Case EnumCommands.cmAbort
                    '    vcmAdd = False
                    'Case EnumCommands.cmDelete
                    '    vcmAdd = False

            End Select
        End If
        ''ghasemi 14021107

    End Sub

    Private Sub BtnGetExcel_Click(sender As Object, e As EventArgs) Handles BtnGetExcel.Click
        Dim fdl As New OpenFileDialog
        Dim DS As System.Data.DataSet
        DS = New System.Data.DataSet
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim IsExcel As Int16 = 1
        fdl.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx"
        fdl.Multiselect = False
        fdl.ShowDialog()

        Dim Address As String = fdl.FileName()
        Dim name As String

        name = Address.Replace(".xlsx", "")
        name = "[" + name.Substring(name.LastIndexOf("\") + 1) + "$]"

        Dim Wfrm As New Common.Frmwait
        Wfrm.Label3.Text = "...سیستم در حال آپلود فایل می باشد..."
        Wfrm.Show()
        Wfrm.Refresh()
        Try
            MyConnection = New System.Data.OleDb.OleDbConnection("provider= Microsoft.ACE.OLEDB.12.0; " &
                "data source=" & Address & ";Extended Properties=Excel 12.0;")
            MyConnection.Open()
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("Select * from [AnbarGardaniExpireDate$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "Table1")
            MyCommand.Fill(DS)
            MyConnection.Close()

            If DS.Tables.Count = 0 Then
                CSystem.MsgBox("خطا در تشخیص Dataset Table", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If DS.Tables(0).Rows.Count = 0 Then
                CSystem.MsgBox("رکوردی برای درج یافت نشد", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            Dim dvKala As DataView = cn.ExecuteQuery("select KalaSN,KalaNo from paVw_paKalaTaminFull where NoeVahedeTejariSN not in (14.935,16.935)")

            Dim StrKalaNotInsert As String = ""
            Dim CountErr As Integer = 0



            For Each row As DataRow In DS.Tables(0).Rows
                dvKala.RowFilter = "KalaNO='" & row("KalaNO").ToString & "'"
                If dvKala.Count = 0 Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "کد در اطلاعات پایه محصولات غذایی یافت نشد"
                    CountErr += 1
                End If
                If Not IsNumeric(row("KalaNO")) Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "کد محصول فرمت عددی نیست"
                    CountErr += 1
                End If
                If Not IsNumeric(row("EnghezaDate")) Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "تاریخ انقضا فرمت عددی ندارد"
                    CountErr += 1
                End If
                If row("EnghezaDate").ToString.Length <> 8 Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "تاریخ انقضا فرمت صحیح تاریخ 8 رقمی ندارد"
                    CountErr += 1
                End If
                If row("TolidDate").ToString.Length > 0 Then
                    If row("TolidDate").ToString.Length <> 8 Then
                        StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "تاریخ تولید فرمت صحیح تاریخ 8 رقمی ندارد"
                        CountErr += 1
                    End If
                    If Not IsNumeric(row("TolidDate")) Then
                        StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "تاریخ انقضا فرمت عددی ندارد"
                        CountErr += 1
                    End If
                ElseIf Not IsDBNull(row("TolidDate")) Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "تاریخ تولید فرمت صحیح ندارد"
                    CountErr += 1
                End If
                If Not IsNumeric(row("Nerkh")) Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "نرخ محصول فرمت عددی نیست"
                    CountErr += 1
                Else
                    DVKalaNerkh.RowFilter = "KalaNO='" & row("KalaNO").ToString & "' And Nerkh=" & row("Nerkh").ToString
                    If DVKalaNerkh.Count = 0 Then
                        StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "نرخ <" & row("Nerkh").ToString & "> جز نرخ مصرف(فروش) این محصول نیست"
                        CountErr += 1
                    End If
                End If
                If Not IsNumeric(row("MojoudiReal")) Then
                    StrKalaNotInsert += vbNewLine + "کد محصول " + row("KalaNO").ToString + ": " + "موجودی شمارش شده فرمت عددی نیست"
                    CountErr += 1
                End If

                If CountErr > 10 Then
                    Exit For
                End If
            Next

            If StrKalaNotInsert <> "" Then
                CSystem.MsgBox("خطا در آپلود فایل :" + vbNewLine + StrKalaNotInsert, MsgBoxStyle.Critical, "خطا")
                Exit Sub
            End If

            dvKala.RowFilter = "0=0"

            For Each row As DataRow In DS.Tables(0).Rows
                dvKala.RowFilter = "KalaNO='" & row("KalaNO").ToString & "'"
                Dim KalaSN As Decimal = dvKala(0)("KalaSN")

                Try
                    cn.CallSP("abAnbarGardaniHaEnghezaDate_Insert", gSM.Identifier, CDec(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), KalaSN,
                                                            row("EnghezaDate"), row("TolidDate"), row("Nerkh"), row("MojoudiReal"),
                                                            0, DBNull.Value, 2, DBNull.Value, DBNull.Value,
                                                            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                                                            gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName)
                Catch ex As Exception
                    CSystem.MsgBox("خطا در درج ردیف : " + "کد محصول : " + row("KalaNo").ToString + vbNewLine +
                                 "تاریخ انقضاء : " + row("EnghezaDate").ToString + vbNewLine +
                                 "نرخ(شماره رهگیری) : " + row("Nerkh").ToString + vbNewLine +
                                 "تاریخ تولید : " + row("TolidDate").ToString + vbNewLine + ex.Message)
                    Exit For
                End Try
            Next


            Try
                cn.ExecuteNoneQuery("abSpC_AnbarGardaniEnghezaDate_UpdateMojoudiSystem " & DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN"))

            Catch ex As Exception
                CSystem.MsgBox("خطا در بروزرسانی موجودی سیستمی محصولات" + vbNewLine + ex.Message)
            End Try

            DVabAnbarGardaniHA.Refresh()
            DVabAnbarGardani.FetchCurRecord()

        Catch ex As Exception
            tp.MsgBox(": فايل اکسل قابل بازخواني نمي باشد لطفا موارد زير را بررسي نمائيد" + vbCrLf +
                      "مطمئن شويد نام شيت فايل مورد نظر " + "[AnbarGardaniExpireDate]" + " باشد " + vbCrLf +
                      "مطمئن شويد فايل اکسل خارج از برنامه باز مي شود" + vbCrLf +
                      "در صورت عدم رفع مشکل فايل اکسل را باز نموده و با نام ديگري ذخيره نمائيد")
            Exit Sub
        Finally
            Wfrm.Close()
        End Try

    End Sub

    Private Sub BtnFormatEXcel_Click(sender As Object, e As EventArgs) Handles BtnFormatEXcel.Click
        Try
            Dim _f As New Minoo.Applications.ProductionPlanning.Common.SharedItems
            Dim _DriveName As String = "D"
            If TxtDrive.Text <> "D" Then
                _DriveName = TxtDrive.Text.Trim
            End If
            If _DriveName.Length <> 1 Then
                CSystem.MsgBox("فرمت نام درایو اشتباه است", MsgBoxStyle.Exclamation, "نام درایو")
                Exit Sub
            End If


            Dim ArrayOfColNames As New ArrayList
            ArrayOfColNames.Add("KalaNO")
            ArrayOfColNames.Add("EnghezaDate")
            ArrayOfColNames.Add("TolidDate")
            ArrayOfColNames.Add("Nerkh")
            ArrayOfColNames.Add("MojoudiReal")

            _f.CreateExcelFormat(_DriveName, "AnbarGardaniExpireDate", ArrayOfColNames, "AnbarGardaniExpireDate" + Today)

            CSystem.MsgBox("توجه نمایید ستون های فایل اکسل به شرح ذیل جهت آپلود می بایست تکمیل گردد" + vbNewLine +
                           "KalaNO : کد کالای محصول" + vbNewLine +
                           "EnghezaDate : تاریخ انقضای محصول مانند 14020510" + vbNewLine +
                           "TolidDate : تاریخ تولید محصول مانند 14020510" + vbNewLine +
                           "Nerkh : نرخ فروش محصول (ریال)" + vbNewLine +
                           "MojoudiReal : موجودی شمارش شده", MsgBoxStyle.Information, "توجه!"
                           )


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CSystem.MsgBox("آیا مایل به حذف <" & (DVabAnbarGardaniHA.FlexGrid.SelectedRows).ToString & "> ردیف انتخاب شده می باشید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "حذف ردیف ها") = MsgBoxResult.No Then
            Exit Sub
        End If

        With DVabAnbarGardaniHA.FlexGrid
            For i As Integer = 0 To .SelectedRows - 1
                If IsNumeric(.TextMatrix(.SelectedRow(i), .ColIndex("AnbarGardaniEnghezaDateHaSN"))) Then
                    Try
                        cn.CallSP("abAnbarGardaniHaEnghezaDate_Delete", .TextMatrix(.SelectedRow(i), .ColIndex("AnbarGardaniEnghezaDateHaSN")))
                    Catch ex As Exception
                        Exit For
                    End Try

                End If
            Next
        End With

        DVabAnbarGardaniHA.Refresh()
    End Sub

    Private Sub btnEbtal_Click(sender As Object, e As EventArgs) Handles btnEbtal.Click
        If CSystem.MsgBox("آیا مایل به ابطال فایل انبارگردانی شماره " + vbNewLine + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNo") + "." + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS") + vbNewLine + " می باشید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ابطال") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Errmsg As String = ""
        Try
            cn.CallSP("_abSPC_Change_AnbarGardaniEnghezaDateStatus", CDec(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), 8,
                      gSM.UserID, gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName, Errmsg)
            If Errmsg = "" Then
                CSystem.MsgBox("ابطال فایل با موفقیت انجام شد", MsgBoxStyle.Information, "")
            Else
                CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + Errmsg, MsgBoxStyle.Critical, "")
            End If
            DVabAnbarGardani.Refresh()
        Catch ex As Exception
            CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + ex.Message)
        End Try

    End Sub

    Private Sub DVabAnbarGardaniHA_AfterCommandClick(aCommand As EnumCommands) Handles DVabAnbarGardaniHA.AfterCommandClick
        If aCommand = EnumCommands.cmSave Then
            'Dim Currentrow As Integer = DVabAnbarGardani.FlexGrid.Row
            'DVabAnbarGardani.FlexGrid.Select(Currentrow, 1,,)
            'DVabAnbarGardani.FetchCurRecord()
            If DVabAnbarGardaniHA.DataRows > 0 Then
                DVabAnbarGardani.FetchCurRecord()
            End If
        End If
    End Sub

    Private Sub DVabAnbarGardani_AfterCommandClick(aCommand As EnumCommands) Handles DVabAnbarGardani.AfterCommandClick
        'If aCommand = EnumCommands.cmSave Then
        '    DVabAnbarGardani.Refresh()
        'End If
    End Sub

    Private Sub BtnPayanShomaresh_Click(sender As Object, e As EventArgs) Handles BtnPayanShomaresh.Click
        If CSystem.MsgBox("آیا مایل به اعلام پایان شمارش ها برای تمامی اقلام فایل انبارگردانی شماره " + vbNewLine + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNo") + "." + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS") + vbNewLine + " می باشید؟" +
                          vbNewLine + "توجه داشته باشید با اعلام پایان شمارش تا تایید نهایی فایل انجام هرگونه عملیات ثبت سند روی انبار امکان پذیر نخواهد بود!", MsgBoxStyle.YesNo, "پایان شمارش") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Errmsg As String = ""
        Try
            cn.CallSP("_abSPC_Change_AnbarGardaniEnghezaDateStatus", CDec(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), 12,
                      gSM.UserID, gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName, Errmsg)
            If Errmsg = "" Then
                CSystem.MsgBox("اعلام پایان شمارش فایل با موفقیت انجام شد", MsgBoxStyle.Information, "")
            Else
                CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + Errmsg, MsgBoxStyle.Critical, "")
            End If
            DVabAnbarGardani.Refresh()
        Catch ex As Exception
            CSystem.MsgBox("خطا در انجام عملیات" + vbNewLine + ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUpdateMojoudiSystem.Click
        Try
            cn.ExecuteNoneQuery("abSpC_AnbarGardaniEnghezaDate_UpdateMojoudiSystem " & DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN"))
            CSystem.MsgBox("بروزرسانی موجودی سیستمی تمامی اقلام فایل انبارگردانی " + vbNewLine + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateNo") + "." + DVabAnbarGardani.FieldText("AnbarGardaniEnghezaDateDS") + vbNewLine + " با موفقیت انجام شد", MsgBoxStyle.Information, "")
            DVabAnbarGardaniHA.Refresh()
        Catch ex As Exception
            CSystem.MsgBox("خطا در بروزرسانی موجودی سیستمی محصولات" + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub dbcNerkh_GotFocus(sender As Object, e As EventArgs) Handles dbcNerkh.GotFocus
        'If IsNumeric(DVabAnbarGardaniHA.FieldValue("KalaDS")) Then
        '    With DVabAnbarGardaniHA.Fields("Nerkh")
        '        .ComboWhereCondition = " Nerkh In ( select  Nerkh from abVw_ForooshKalaGHeymat Where kalaSN=" & DVabAnbarGardaniHA.FieldValue("KalaDS").ToString & ")"
        '        .RefreshCombo()
        '    End With
        'End If

        If IsNumeric(DVabAnbarGardaniHA.FieldValue("KalaDS")) Then
            dbcNerkh.Bind(cn, "select Distinct Top 5 Convert(int,isnull(MasrafFee,VahedFee)) Nerkh,Convert(int,isnull(MasrafFee,VahedFee)) NerkhDS from foKalaGheymatHa Where isnull(MasrafFee,VahedFee)>0 and kalaSN=" & DVabAnbarGardaniHA.FieldValue("KalaDS").ToString & " order by Convert(int,isnull(MasrafFee,VahedFee)) desc", "Nerkh", "NerkhDS")

        End If



    End Sub

    Private Sub BtnKalaNErkh_Click(sender As Object, e As EventArgs) Handles BtnKalaNErkh.Click
        Dim Frm As New Common.FrmJanusReport
        With Frm
            DVKalaNerkh.RowFilter = "0=0"
            .HideSNColumns = True
            If DVabAnbarGardaniHA.EditStarted Then
                If IsNumeric(DVabAnbarGardaniHA.FieldValue("KalaDS")) Then
                    DVKalaNerkh.RowFilter = "KalaSN=" & DVabAnbarGardaniHA.FieldValue("KalaDS").ToString
                End If
            End If
            .DvSource = DVKalaNerkh

            .Text = "لیست نرخ " + If(IsNumeric(DVabAnbarGardaniHA.FieldValue("KalaDS")) And DVabAnbarGardaniHA.EditStarted, DVabAnbarGardaniHA.FieldText("KalaDS").ToString, "محصولات") + " - " + "با دابل کلیک بر سطر در صورتیکه نرخ کالا در حالت قابل درج باشد نرخ در آن بخش درج خواهد شد"
            .GridReport.FilterMode = FilterMode.Automatic
            .GridReport.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GridReport.DefaultFilterRowComparison = FilterConditionOperator.Contains
            .GridReport.DynamicFiltering = True
            .HideSNColumns = True
            .ShowDialog()
            .Dispose()
            DVKalaNerkh.RowFilter = "0=0"
            If DVabAnbarGardaniHA.EditStarted Then
                If Frm.SelectedNerkh > 0 Then
                    DVabAnbarGardaniHA.FieldValue("Nerkh") = Frm.SelectedNerkh
                End If
                'DVabAnbarGardaniHA.Save()

            End If

        End With
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedTab Is TabPageShowReportKalaRahgiri OrElse TabControl1.SelectedTab Is TabPageShowReportKala) Then
            Dim wfrm As New Common.Frmwait
            wfrm.Show()
            wfrm.Label3.Text = "...سیستم در حال تهیه گزارش می باشد..."
            wfrm.Refresh()

            Try
                Dim dv As DataView = cn.ExecuteQuery("Exec abSpr_AnbarGardaniEnghezaDateRptKasriEzafi " &
                                                     If(IsNumeric(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), CDec(DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN")), 0) & "," &
                                                     If(TabControl1.SelectedTab Is TabPageShowReportKalaRahgiri, 1, 2)
                                                     )
                GridReport.DataSource = dv
                If TabControl1.SelectedTab Is TabPageShowReportKala Then
                    GridReport.RootTable.ColumnSets.Item("ColumnSetKalaRahgiri").Visible = False
                    GridReport.RootTable.ColumnSets.Item("ColumnSetKala").Visible = True
                    GridReport.RootTable.ColumnSets.Item("ColumnSetDateInformation").Visible = False
                ElseIf TabControl1.SelectedTab Is TabPageShowReportKalaRahgiri Then
                    GridReport.RootTable.ColumnSets.Item("ColumnSetKalaRahgiri").Visible = True
                    GridReport.RootTable.ColumnSets.Item("ColumnSetKala").Visible = False
                    GridReport.RootTable.ColumnSets.Item("ColumnSetDateInformation").Visible = True
                End If
                GridReport.Refresh()
                GridReport.AutoSizeColumns()
            Catch ex As Exception
            Finally
                wfrm.Close()
                TabControl1.SelectTab(TabPageKasriEzafi)
            End Try

        End If
    End Sub

    Private Sub Export2Excel()
        Dim fileName As String = ""
        fileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If String.IsNullOrEmpty(fileName) Then
            Exit Sub
        End If
        Try
            If DVabAnbarGardaniHA IsNot Nothing Then

                If DVabAnbarGardaniHA.DataRows > 0 Then
                    Functions.FTFlexFunctions.ExportExcel(DVabAnbarGardaniHA.FlexGrid, fileName)
                    Dim result As DialogResult = NetSql.Common.CSystem.MsgBox("فايل ذخيره شد / آیا مایل به باز کردن فایل هستید؟",
                         MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                         + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
                    If result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(fileName)
                    End If

                End If
            Else
                Exit Sub
            End If

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در ذخیره سازی فایل ", MsgBoxStyle.Critical, "خطا")
        Finally
            BtnFormatEXcel.Enabled = True
        End Try


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Try
        '    If DVabAnbarGardani.DataRows > 0 AndAlso DVabAnbarGardaniHA.DataRows > 0 Then
        '        If DVabAnbarGardani.FieldValue("Status") = 1 Or DVabAnbarGardani.FieldValue("Status") = 4 Then
        '            cn.ExecuteNoneQuery("abSpC_AnbarGardaniEnghezaDate_UpdateMojoudiSystem " & DVabAnbarGardani.FieldValue("AnbarGardaniEnghezaDateSN"))
        '        End If
        '    End If
        'Catch ex As Exception
        '    CSystem.MsgBox("خطا در بروزرسانی <اتوماتیک> موجودی سیستمی محصولات" + vbNewLine + ex.Message)
        'End Try
    End Sub

    Private Sub btnExport2Excel_Click(sender As Object, e As EventArgs) Handles btnExport2Excel.Click
        Export2Excel()
    End Sub
End Class
