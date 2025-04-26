''Add by dehghani 14001002
Imports Janus.Windows.GridEX
Imports Anbar.BRL

Public Class FrmabZayeatKartabl
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

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmabZayeatKartabl
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtToDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents BtnRefreshData As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnTaeed As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnNerkh As Janus.Windows.EditControls.UIButton
    Public WithEvents dcbNerkh As NetSql.Components.DataCombo
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GridZayeatTitr As GridEX
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GridZayeatDetail As GridEX
    Friend WithEvents Label3 As Label

    Public Shared Property DefInstance() As FrmabZayeatKartabl

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabZayeatKartabl
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabZayeatKartabl)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridZayeatTitr_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabZayeatKartabl))
        Dim GridZayeatDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dcbNerkh = New NetSql.Components.DataCombo(Me.components)
        Me.BtnNerkh = New Janus.Windows.EditControls.UIButton()
        Me.BtnTaeed = New Janus.Windows.EditControls.UIButton()
        Me.BtnRefreshData = New Janus.Windows.EditControls.UIButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridZayeatTitr = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GridZayeatDetail = New Janus.Windows.GridEX.GridEX()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridZayeatTitr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridZayeatDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1169, 454)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dcbNerkh)
        Me.Panel3.Controls.Add(Me.BtnNerkh)
        Me.Panel3.Controls.Add(Me.BtnTaeed)
        Me.Panel3.Controls.Add(Me.BtnRefreshData)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtToDate)
        Me.Panel3.Controls.Add(Me.TxtFromDate)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 168)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1169, 60)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "نوع محاسبه نرخ : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dcbNerkh
        '
        Me.dcbNerkh.AutoSelectFirst = False
        Me.dcbNerkh.BackColor = System.Drawing.Color.White
        Me.dcbNerkh.BoundText = Nothing
        Me.dcbNerkh.BypassChangeEvent = False
        Me.dcbNerkh.DisplayText = ""
        Me.dcbNerkh.Items.AddRange(New Object() {"1. آخرین نرخ خرید به تاریخ امروز", "2. آخرین نرخ فروش به تاریخ امروز", "3. آخرین نرخ خرید به تاریخ سند", "4. آخرین نرخ فروش به تاریخ سند"})
        Me.dcbNerkh.LateBindingTop = "100"
        Me.dcbNerkh.Location = New System.Drawing.Point(136, 19)
        Me.dcbNerkh.MemFilter = ""
        Me.dcbNerkh.Name = "dcbNerkh"
        Me.dcbNerkh.SeparatedData = Nothing
        Me.dcbNerkh.Size = New System.Drawing.Size(253, 22)
        Me.dcbNerkh.Source = Nothing
        Me.dcbNerkh.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNerkh.TabIndex = 210
        '
        'BtnNerkh
        '
        Me.BtnNerkh.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnNerkh.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnNerkh.Location = New System.Drawing.Point(2, 1)
        Me.BtnNerkh.Name = "BtnNerkh"
        Me.BtnNerkh.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.BtnNerkh.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.BtnNerkh.Size = New System.Drawing.Size(128, 55)
        Me.BtnNerkh.TabIndex = 209
        Me.BtnNerkh.Text = "مشاهده نرخ"
        Me.BtnNerkh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnTaeed
        '
        Me.BtnTaeed.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnTaeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTaeed.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnTaeed.Location = New System.Drawing.Point(553, 2)
        Me.BtnTaeed.Name = "BtnTaeed"
        Me.BtnTaeed.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.BtnTaeed.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.BtnTaeed.Size = New System.Drawing.Size(128, 55)
        Me.BtnTaeed.TabIndex = 208
        Me.BtnTaeed.Text = "تایید"
        Me.BtnTaeed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnRefreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshData.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRefreshData.Location = New System.Drawing.Point(698, 2)
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.BtnRefreshData.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.BtnRefreshData.Size = New System.Drawing.Size(128, 55)
        Me.BtnRefreshData.TabIndex = 207
        Me.BtnRefreshData.Text = "بروزرسانی اطلاعات"
        Me.BtnRefreshData.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(940, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "تا تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1108, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "از تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtToDate
        '
        Me.TxtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtToDate.Location = New System.Drawing.Point(832, 19)
        Me.TxtToDate.Mask = "9900/90/90"
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 173
        Me.TxtToDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.Location = New System.Drawing.Point(1005, 20)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 172
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 168)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1169, 168)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridZayeatTitr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1161, 141)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "سند ضایعات"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridZayeatTitr
        '
        GridZayeatTitr_DesignTimeLayout.LayoutString = resources.GetString("GridZayeatTitr_DesignTimeLayout.LayoutString")
        Me.GridZayeatTitr.DesignTimeLayout = GridZayeatTitr_DesignTimeLayout
        Me.GridZayeatTitr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridZayeatTitr.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridZayeatTitr.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridZayeatTitr.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridZayeatTitr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridZayeatTitr.GroupByBoxVisible = False
        Me.GridZayeatTitr.Location = New System.Drawing.Point(3, 3)
        Me.GridZayeatTitr.Name = "GridZayeatTitr"
        Me.GridZayeatTitr.RecordNavigator = True
        Me.GridZayeatTitr.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridZayeatTitr.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridZayeatTitr.Size = New System.Drawing.Size(1155, 135)
        Me.GridZayeatTitr.TabIndex = 13
        Me.GridZayeatTitr.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridZayeatTitr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.TabControl2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1169, 222)
        Me.Panel2.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1169, 222)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridZayeatDetail)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1161, 195)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "اقلام ضایعات"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridZayeatDetail
        '
        GridZayeatDetail_DesignTimeLayout.LayoutString = resources.GetString("GridZayeatDetail_DesignTimeLayout.LayoutString")
        Me.GridZayeatDetail.DesignTimeLayout = GridZayeatDetail_DesignTimeLayout
        Me.GridZayeatDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridZayeatDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridZayeatDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridZayeatDetail.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridZayeatDetail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridZayeatDetail.GroupByBoxVisible = False
        Me.GridZayeatDetail.Location = New System.Drawing.Point(3, 3)
        Me.GridZayeatDetail.Name = "GridZayeatDetail"
        Me.GridZayeatDetail.RecordNavigator = True
        Me.GridZayeatDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridZayeatDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridZayeatDetail.Size = New System.Drawing.Size(1155, 189)
        Me.GridZayeatDetail.TabIndex = 14
        Me.GridZayeatDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridZayeatDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FrmabZayeatKartabl
        '
        Me.ClientSize = New System.Drawing.Size(1169, 454)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmabZayeatKartabl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "کارتابل ضایعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridZayeatTitr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridZayeatDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    'Dim AccessUser As Integer = 0
    Dim AnbarRule As New ClsDataAccessRule
    Public DtMasTer As DataView
    Dim DtDetail As DataView
    Private Sub FrmabZayeatKartabl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Dv As DataView = cn.ExecuteQuery("Select * from abVw_ZayeatGardeshRole  Where VahedeTejariSN=" & gVahedeTejariSN.ToString & " And UserId=" & gSM.UserID.ToString)

        If Dv.Count = 0 Then
            CSystem.MsgBox(" دسترسی برای شما قعال نیست.با پشتیبان سیستم تماس بگیرید", MsgBoxStyle.Exclamation, "")
            SplitContainer1.Enabled = False
            Exit Sub
        End If

        Dim RoleDS As String = Dv(0)("ZayeatGardeshStateDSType").ToString

        Me.Text += " " + RoleDS

        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)

        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")

        If DtMasTer Is Nothing Then  ''فراخوانی کارتابل از منوی عملیات
            Try
                DtMasTer = AnbarRule.KartablZayeat_GetMaster(gSM.UserID, Fdate, Tdate, cn)
                GridZayeatTitr.DataSource = DtMasTer
                GridZayeatTitr.Refresh()
            Catch ex As Exception
                CSystem.MsgBox("خطا در لود تیتر کارتابل" + vbNewLine + ex.Message)
            End Try
        Else  ''فراخوانی کارتابل بعد از ورود به سیستم
            GridZayeatTitr.DataSource = DtMasTer
            GridZayeatTitr.Refresh()
        End If


        Try

            DtDetail = AnbarRule.KartablZayeat_GetDetail(gSM.UserID, Fdate, Tdate, cn)
            GridZayeatDetail.DataSource = DtDetail
            GridZayeatDetail.Refresh()
        Catch ex As Exception
            CSystem.MsgBox("خطا در لود اقلام کارتابل" + vbNewLine + ex.Message)

        End Try

        'With GridZayeatTitr.RootTable
        '    .Columns("ZayeatCode").HasValueList = True
        '    .Columns("ZayeatCode").ValueList.PopulateValueList(cn.ExecuteQuery("Select * from abVw_ZayeatGardeshCode"), "CodeID", "ZayeatCode")
        'End With

        With GridZayeatDetail.RootTable
            .Columns("ZayeatCodeKala").HasValueList = True
            .Columns("ZayeatCodeKala").ValueList.PopulateValueList(cn.ExecuteQuery("Select * from abVw_ZayeatGardeshCode"), "CodeID", "ZayeatCode")
            .Columns("ZayeatCodeKala").Visible = Not CBool(Dv(0)("IsAccessOfShobe"))
        End With


        GridZayeatTitr.RootTable.Columns("HavalehNo").Caption = "شماره" + vbNewLine + "حواله"
        GridZayeatTitr.RootTable.Columns("ZayeatGardeshNo").Caption = "شماره" + vbNewLine + "درخواست"
        GridZayeatTitr.RootTable.Columns("ZayeatGardeshDS").Caption = "شرح" + vbNewLine + "درخواست"
        GridZayeatTitr.RootTable.Columns("ZayeatGardeshType").Caption = "نوع" + vbNewLine + "ضایعات"

        GridZayeatDetail.RootTable.Columns("Meghdar").Caption = "مقدار" + vbNewLine + "(کارتن*عدد)"
        GridZayeatDetail.RootTable.Columns("TedadAjza").Caption = "تعداد در" + vbNewLine + "کارتن"
        GridZayeatDetail.RootTable.Columns("ZayeatGardeshHaNo").Caption = "شماره" + vbNewLine + "ردیف"


        For Each col As Janus.Windows.GridEX.GridEXColumn In GridZayeatTitr.RootTable.Columns
            col.HeaderAlignment = TextAlignment.Center
            'col.TextAlignment = TextAlignment.Center
        Next

        For Each col As Janus.Windows.GridEX.GridEXColumn In GridZayeatDetail.RootTable.Columns
            col.HeaderAlignment = TextAlignment.Center
            'col.TextAlignment = TextAlignment.Center
        Next

        GridZayeatTitr.AutoSizeColumns()

        GridZayeatTitr_SelectionChanged(sender, e)

        dcbNerkh.SelectedIndex = 0
    End Sub


    Private Sub GridZayeatTitr_SelectionChanged(sender As Object, e As EventArgs) Handles GridZayeatTitr.SelectionChanged

        If GridZayeatTitr.CurrentRow Is Nothing Then
            If Not GridZayeatDetail.DataSource Is Nothing Then
                CType(GridZayeatDetail.DataSource, DataView).RowFilter = "1=0"
            End If
            Exit Sub
        End If

        If IsNumeric(GridZayeatTitr.CurrentRow.Cells("ZayeatGardeshSN").Value) AndAlso Not IsNothing(GridZayeatDetail.DataSource) Then
            CType(GridZayeatDetail.DataSource, DataView).RowFilter = "ZayeatGardeshSN=" & GridZayeatTitr.CurrentRow.Cells("ZayeatGardeshSN").Value.ToString
            If IsNumeric(GridZayeatTitr.CurrentRow.Cells("AccessForDarjNerkh").Value) AndAlso GridZayeatTitr.CurrentRow.Cells("AccessForDarjNerkh").Value <> 0 Then
                BtnNerkh.Text = "درج نرخ"
            End If
            GridZayeatDetail.Refresh()
            If GridZayeatDetail.RowCount = 2 Then
                GridZayeatDetail.RootTable.Columns("EbtalRadif").Visible = False
            Else
                GridZayeatDetail.RootTable.Columns("EbtalRadif").Visible = True
            End If
            'If CInt(GridZayeatTitr.CurrentRow.Cells("IsForceToSelectZayeatCode").Value) = 1 Then
            '    GridZayeatTitr.RootTable.Columns("ZayeatCode").EditType = EditType.DropDownList
            'Else
            '    GridZayeatTitr.RootTable.Columns("ZayeatCode").EditType = EditType.NoEdit
            'End If
            If CInt(GridZayeatTitr.CurrentRow.Cells("IsForceToSelectZayeatCode").Value) = 1 Then
                GridZayeatDetail.RootTable.Columns("ZayeatCodeKala").EditType = EditType.DropDownList
            Else
                GridZayeatDetail.RootTable.Columns("ZayeatCodeKala").EditType = EditType.NoEdit
            End If
        ElseIf Not IsNothing(GridZayeatDetail.DataSource) Then
            CType(GridZayeatDetail.DataSource, DataView).RowFilter = "1=0"
            GridZayeatDetail.Refresh()
        End If

        GridZayeatDetail.AutoSizeColumns()

    End Sub

    Private Sub BtnRefreshData_Click(sender As Object, e As EventArgs) Handles BtnRefreshData.Click

        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")

        Dim wfrm As New Common.Frmwait
        wfrm.Show()
        wfrm.Label3.Text = "...سیستم در حال بروزرسانی کارتابل می باشد..."
        wfrm.Refresh()


        Dim DtMasTer As New DataView
        Dim DtDetail As New DataView

        Try

            Try
                DtMasTer = AnbarRule.KartablZayeat_GetMaster(gSM.UserID, Fdate, Tdate, cn)
                GridZayeatTitr.DataSource = DtMasTer
                GridZayeatTitr.Refresh()
            Catch ex As Exception
                CSystem.MsgBox("خطا در لود تیتر کارتابل" + vbNewLine + ex.Message)
            End Try


            Try

                DtDetail = AnbarRule.KartablZayeat_GetDetail(gSM.UserID, Fdate, Tdate, cn)
                GridZayeatDetail.DataSource = DtDetail
                GridZayeatDetail.Refresh()
            Catch ex As Exception
                CSystem.MsgBox("خطا در لود اقلام کارتابل" + vbNewLine + ex.Message)

            End Try

            GridZayeatTitr_SelectionChanged(sender, e)

        Catch ex As Exception

        Finally
            wfrm.Close()
        End Try





    End Sub

    Private Sub GridZayeatTitr_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridZayeatTitr.LinkClicked

        Dim dgRow As Janus.Windows.GridEX.GridEXRow
        dgRow = GridZayeatTitr.CurrentRow

        If dgRow Is Nothing OrElse dgRow.RowType <> RowType.Record Then
            Exit Sub
        End If

        If GridZayeatTitr.CurrentColumn.Key = "SaveData" Then
            If dgRow.Cells(GridZayeatTitr.CurrentColumn.Key).Text.EndsWith("!") Then
                CSystem.MsgBox("شما دسترسی به عملیات مربوطه را ندارید", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            Try
                'cn.ExecuteNoneQuery(" Update abZayeatGardesh Set ZayeatCode=" & dgRow.Cells("ZayeatCode").Value.ToString & ",ZayeatGardeshDS='" & dgRow.Cells("ZayeatGardeshDS").Text & "' ,Tozih= '" & dgRow.Cells("Tozih").Text & "' where ZayeatGardeshSN=" & dgRow.Cells("ZayeatGardeshSN").Value.ToString)
                cn.ExecuteNoneQuery(" Update abZayeatGardesh Set ZayeatGardeshDS='" & dgRow.Cells("ZayeatGardeshDS").Text & "' ,Tozih= '" & dgRow.Cells("Tozih").Text & "' where ZayeatGardeshSN=" & dgRow.Cells("ZayeatGardeshSN").Value.ToString)

            Catch ex As Exception
                CSystem.MsgBox(ex.Message)
            End Try
            CSystem.MsgBox("ذخیره < شرح > < توضیحات > با موفقیت انجام شد", MsgBoxStyle.Information, "")
        ElseIf GridZayeatTitr.CurrentColumn.Key = "EbtalDarkhast" Then
            If dgRow.Cells(GridZayeatTitr.CurrentColumn.Key).Text.EndsWith("!") Then
                CSystem.MsgBox("شما دسترسی به عملیات مربوطه را ندارید", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If dgRow.Cells("Tozih").Text.Trim = "" Then
                CSystem.MsgBox("ثبت توضیح جهت ابطال درخواست الزامیست", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            cn.ExecuteNoneQuery(" Update abZayeatGardesh Set Tozih= '" & dgRow.Cells("Tozih").Text & "' where ZayeatGardeshSN=" & dgRow.Cells("ZayeatGardeshSN").Value.ToString)


            If CSystem.MsgBox("با عملیات ابطال سند مربوطه از انبار قرنطینه حذف و به انبار محصول بازگردانده می شود " + vbNewLine + "آیا مایل به ابطال درخواست شماره <" + dgRow.Cells("ZayeatGardeshNo").Text + "> می باشید؟", MsgBoxStyle.YesNo, "ابطال درخواست") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim DvServer As New DataView
            Dim ServerName As String = cn.SQLServerName
            Dim DatabaseName As String = cn.SQLDatabaseName
            Dim VahedeTejariSN As Decimal = gVahedeTejariSN


            If gVahedeTejariSN = 9.935 Then
                DvServer = cn.ExecuteQuery("Select Top 1 * from [abFn_getServerDbOfApplication](" & dgRow.Cells("VahedeTejariSN").Text & ")  Order by Tartib")
                If DvServer.Count = 1 Then
                    ServerName = DvServer(0)("ServerName").ToString
                    DatabaseName = DvServer(0)("DatabaseName").ToString
                    VahedeTejariSN = CDec(DvServer(0)("VahedeTejariSN"))
                Else
                    CSystem.MsgBox("مشخصه سرور برای شعبه مقصد یافت نشد", MsgBoxStyle.Exclamation, "")
                    Exit Sub
                End If
            End If


            Dim Str As String = ""
            Try
                Str = AnbarRule.KartablZayeat_EbtalDarkhast(VahedeTejariSN, ServerName, DatabaseName, CDec(dgRow.Cells("ZayeatGardeshSN").Text), gSM.UserID, gSM.UserID_Name, cn)

                If Str = "" Then
                    cn.ExecuteNoneQuery("Update abZayeatGardesh set ZayeatGardeshState=0 where ZayeatGardeshSN=" & dgRow.Cells("ZayeatGardeshSN").Text)
                    CSystem.MsgBox("عملیات ابطال درخواست ضایعات شماره " & dgRow.Cells("ZayeatGardeshNo").Text & " با موفقیت انجام گردید", MsgBoxStyle.Information, "ابطال درخواست")
                Else
                    CSystem.MsgBox(Str, MsgBoxStyle.Exclamation, "ابطال درخواست")
                End If
            Catch ex As Exception
                CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ابطال درخواست")
            End Try

            BtnRefreshData_Click(sender, e)

        ElseIf GridZayeatTitr.CurrentColumn.Key = "RavandErja" Then
            If dgRow.Cells(GridZayeatTitr.CurrentColumn.Key).Text.EndsWith("!") Then
                CSystem.MsgBox("شما دسترسی به عملیات مربوطه را ندارید", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            Dim Rpt As New Anbar.Common.FrmJanusReport
            With Rpt
                .DvSource = AnbarRule.KartablZayeat_ReprtRavandErja(CDec(dgRow.Cells("ZayeatGardeshSN").Value), cn)
                .Text = "روند ارجاع درخواست ضایعات شماره " + dgRow.Cells("ZayeatGardeshNo").Text
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub

    Private Sub GridZayeatDetail_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridZayeatDetail.LinkClicked

        Dim dgRow As Janus.Windows.GridEX.GridEXRow
        dgRow = GridZayeatDetail.CurrentRow
        If dgRow Is Nothing OrElse dgRow.RowType <> RowType.Record Then
            Exit Sub
        End If

        If GridZayeatDetail.CurrentColumn.Key = "SaveData" Then
            If dgRow.Cells(GridZayeatDetail.CurrentColumn.Key).Text.EndsWith("!") Then
                CSystem.MsgBox("شما دسترسی به عملیات مربوطه را ندارید", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            Try
                'cn.ExecuteNoneQuery("  Update abZayeatGardeshHa Set Res1='" & dgRow.Cells("ZayeatCodeKala").Value.ToString & "' , Tozih= '" & dgRow.Cells("Tozih").Text & "' where ZayeatGardeshHaSN=" & dgRow.Cells("ZayeatGardeshHaSN").Value.ToString)
                cn.ExecuteNoneQuery("Exec abZayeatGardeshHa_UpdateX " & dgRow.Cells("ZayeatGardeshHaSN").Value.ToString & "," & dgRow.Cells("ZayeatCodeKala").Value.ToString & ",Null," & GridZayeatTitr.CurrentRow.Cells("ZayeatGardeshState").Text & "" & If(dgRow.Cells("Tozih").Text <> "", "," + dgRow.Cells("Tozih").Text, ""))

                CSystem.MsgBox("ذخیره <کد ضایعات> < توضیحات > با موفقیت روی این ردیف انجام شد", MsgBoxStyle.Information, "")
            Catch ex As Exception
                CSystem.MsgBox(ex.Message)
            End Try

        ElseIf GridZayeatDetail.CurrentColumn.Key = "EbtalRadif" Then
            If dgRow.Cells(GridZayeatDetail.CurrentColumn.Key).Text.EndsWith("!") Then
                CSystem.MsgBox("شما دسترسی به عملیات مربوطه را ندارید", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If dgRow.Cells("Tozih").Text.Trim = "" Then
                CSystem.MsgBox("ثبت توضیح جهت ابطال ردیف الزامیست", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            'cn.ExecuteNoneQuery("  Update abZayeatGardeshHa Set Tozih= '" & dgRow.Cells("Tozih").Text & "' where ZayeatGardeshHaSN=" & dgRow.Cells("ZayeatGardeshHaSN").Value.ToString)
            cn.ExecuteNoneQuery("Exec abZayeatGardeshHa_UpdateX " & dgRow.Cells("ZayeatGardeshHaSN").Value.ToString & ",Null,Null," & GridZayeatTitr.CurrentRow.Cells("ZayeatGardeshState").Text & "" & If(dgRow.Cells("Tozih").Text <> "", ",'" + dgRow.Cells("Tozih").Text, "") + "'")


            Dim Str1 As String = "با ابطال ردیف ، موجودی کالا رهگیری ابطالی از انبار قرنطینه شعبه خارج و به انبار محصول بازخواهد گشت"
            Str1 += vbNewLine + "کد و نام محصول : " + dgRow.Cells("KalaNo").Text + "." + dgRow.Cells("KalaDS").Text + vbNewLine +
                "سری ساخت : " + dgRow.Cells("ShomarehRahgiri").Text + vbNewLine + "موجودی تعدادی : " + dgRow.Cells("Meghdar").Text
            If CSystem.MsgBox(Str1 + vbNewLine + "آیا مایل به ادامه عملیات ابطال شماره ردیف <" + dgRow.Cells("ZayeatGardeshHaNo").Text + "> می باشید؟", MsgBoxStyle.YesNo, "ابطال ردیف") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim DvServer As New DataView
            Dim ServerName As String = cn.SQLServerName
            Dim DatabaseName As String = cn.SQLDatabaseName
            Dim VahedeTejariSN As Decimal = gVahedeTejariSN


            If gVahedeTejariSN = 9.935 Then
                DvServer = cn.ExecuteQuery("Select Top 1 * from [abFn_getServerDbOfApplication](" & GridZayeatTitr.CurrentRow.Cells("VahedeTejariSN").Text & ")  Order by Tartib")
                If DvServer.Count = 1 Then
                    ServerName = DvServer(0)("ServerName").ToString
                    DatabaseName = DvServer(0)("DatabaseName").ToString
                    VahedeTejariSN = CDec(DvServer(0)("VahedeTejariSN"))
                Else
                    CSystem.MsgBox("مشخصه سرور برای شعبه مقصد یافت نشد", MsgBoxStyle.Exclamation, "")
                    Exit Sub
                End If
            End If

            Dim Str As String = ""
            Try
                Str = AnbarRule.KartablZayeat_EbtalRadif(VahedeTejariSN, ServerName, DatabaseName, CDec(dgRow.Cells("ZayeatGardeshSN").Text), CDec(dgRow.Cells("ZayeatGardeshHaSN").Text), gSM.UserID, gSM.UserID_Name, cn)
                If Str = "" Then
                    cn.ExecuteNoneQuery("Exec abZayeatGardeshHa_UpdateX " & dgRow.Cells("ZayeatGardeshHaSN").Text & ",Null,0," & GridZayeatTitr.CurrentRow.Cells("ZayeatGardeshState").Text)

                    'cn.ExecuteNoneQuery("Update abZayeatGardeshHa set ZayeatGardeshState=0 where ZayeatGardeshHaSN=" & dgRow.Cells("ZayeatGardeshHaSN").Text)
                    CSystem.MsgBox("عملیات ابطال با موفقیت انجام گردید", MsgBoxStyle.Information, "ابطال ردیف")
                Else
                    CSystem.MsgBox(Str, MsgBoxStyle.Exclamation, "ابطال ردیف")
                End If
            Catch ex As Exception
                CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ابطال ردیف")
            End Try

            BtnRefreshData_Click(sender, e)
        End If

    End Sub

    Private Sub BtnTaeed_Click(sender As Object, e As EventArgs) Handles BtnTaeed.Click
        If GridZayeatTitr.GetCheckedRows.Length = 0 Then
            CSystem.MsgBox("سطری برای تایید انتخاب نشده است")
            Exit Sub
        End If

        Dim StrNerkh As String = ""
        If CInt(GridZayeatTitr.GetCheckedRows(0).Cells("AccessForDarjNerkh").Value) = 1 Then
            If dcbNerkh.SelectedIndex > 3 Or dcbNerkh.SelectedIndex < 0 Then
                CSystem.MsgBox("نحوه درج نرخ انتخاب نشده است")
                Exit Sub
            End If
            StrNerkh = "درج نرخ بر اساس " + dcbNerkh.Text
        End If

        If CSystem.MsgBox(If(GridZayeatTitr.GetCheckedRows.Length = 1, "درخواست ضایعات شماره " + GridZayeatTitr.GetCheckedRows(0).Cells("ZayeatGardeshNo").Text, GridZayeatTitr.GetCheckedRows.Length.ToString + " ردیف ") +
                          "  برای تایید انتخاب شده است." + vbNewLine + StrNerkh + vbNewLine +
                          "آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.YesNo, "تایید درخواست") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim ZayeatGardeshno As String = ""
        Dim ZayeatGardeshSN As Decimal = 0
        Dim ZayeatGardeshStateSN As Integer = 0
        Dim SuccessMessage As String = ""
        Dim ErrorMessage As String = ""
        Dim IsFinalLevel As Boolean = False
        Dim wfrm As New Common.Frmwait
        wfrm.Show()


        Try
            For Each _row As Janus.Windows.GridEX.GridEXRow In GridZayeatTitr.GetCheckedRows
                Dim Errmsg As String = ""
                cn.CallSP("abSpc_ZayeatGardeshControl", _row.Cells("ZayeatGardeshSN").Value.ToString, _row.Cells("ZayeatGardeshState").Value.ToString, Errmsg)
                If Errmsg <> "" Then
                    CSystem.MsgBox(Errmsg, MsgBoxStyle.Exclamation, "")
                    Exit Try
                End If
                If IsNumeric(_row.Cells("IsForceToSelectZayeatCode").Value) Then
                    If CInt(_row.Cells("IsForceToSelectZayeatCode").Value) = 1 Then
                        For Each RowDetail As Janus.Windows.GridEX.GridEXRow In GridZayeatDetail.GetRows
                            If CDec(_row.Cells("ZayeatGardeshSN").Value) = CDec(RowDetail.Cells("ZayeatGardeshSN").Value) Then
                                If Not IsNumeric(RowDetail.Cells("ZayeatCodeKala").Value) OrElse (IsNumeric(RowDetail.Cells("ZayeatCodeKala").Value) AndAlso CInt(RowDetail.Cells("ZayeatCodeKala").Value) = 0) Then
                                    CSystem.MsgBox("کد ضایعات برای " + vbNewLine + " شماره درخواست : " + _row.Cells("ZayeatGardeshNo").Text + vbNewLine +
                                         "شماره ردیف : " + RowDetail.Cells("ZayeatGardeshHaNo").Text +
                                         vbNewLine + "تامین کننده : " + RowDetail.Cells("TaminKonandehDS").Text +
                                         vbNewLine + "محصول : " + RowDetail.Cells("KalaNo").Text + "." + RowDetail.Cells("KalaDS").Text +
                                         vbNewLine + " انتخاب نشده است!", MsgBoxStyle.Exclamation, "")
                                    Exit Try
                                End If
                            End If
                        Next
                    End If
                End If
            Next

            Dim DvZayeatCode As DataView = cn.ExecuteQuery("select CodeID from abVw_ZayeatGardeshCode where CodeID<>0")


            For Each _row As Janus.Windows.GridEX.GridEXRow In GridZayeatTitr.GetCheckedRows
                ZayeatGardeshSN = CDec(_row.Cells("ZayeatGardeshSN").Value)
                ZayeatGardeshStateSN = CInt(_row.Cells("ZayeatGardeshState").Value)
                ZayeatGardeshno = _row.Cells("ZayeatGardeshNo").Text + " " + _row.Cells("VahedeTejariDS").Text
                wfrm.Label3.Text = "...سیستم در حال تایید درخواست ضایعات شماره " + ZayeatGardeshno + " می باشد..."
                wfrm.Refresh()

                Try
                    'cn.ExecuteNoneQuery(" Update abZayeatGardesh Set ZayeatCode=" & _row.Cells("ZayeatCode").Value.ToString & ",ZayeatGardeshDS='" & _row.Cells("ZayeatGardeshDS").Text & "' ,Tozih= '" & _row.Cells("Tozih").Text & "' where ZayeatGardeshSN=" & ZayeatGardeshSN.ToString)
                    cn.ExecuteNoneQuery(" Update abZayeatGardesh Set ZayeatGardeshDS='" & _row.Cells("ZayeatGardeshDS").Text & "' ,Tozih= '" & _row.Cells("Tozih").Text & "' where ZayeatGardeshSN=" & ZayeatGardeshSN.ToString)

                Catch ex As Exception
                    CSystem.MsgBox("خطا در ذخیره فیلدهای شرح و توضیح تیتر ضایعات" + vbNewLine + "ZayeatGardeshSN : " + ZayeatGardeshSN.ToString + vbNewLine + ex.Message, MsgBoxStyle.Critical, "")
                    Exit For
                End Try

                If CInt(_row.Cells("IsForceToSelectZayeatCode").Value) = 1 Then
                    Dim ZayeatGardeshHaSN As String = ""
                    Try
                        For Each rowDetail As Janus.Windows.GridEX.GridEXRow In GridZayeatDetail.GetRows
                            DvZayeatCode.RowFilter = "0=0"
                            If CDec(rowDetail.Cells("ZayeatGardeshSN").Value) = ZayeatGardeshSN Then
                                DvZayeatCode.RowFilter = "CodeID=" & rowDetail.Cells("ZayeatCodeKala").Value.ToString
                                If DvZayeatCode.Count > 0 Then
                                    ZayeatGardeshHaSN = rowDetail.Cells("ZayeatGardeshHaSN").Value.ToString
                                    cn.ExecuteNoneQuery("Exec abZayeatGardeshHa_UpdateX " & ZayeatGardeshHaSN & "," & rowDetail.Cells("ZayeatCodeKala").Value.ToString & ",Null,Null" & If(rowDetail.Cells("Tozih").Text <> "", "," + rowDetail.Cells("Tozih").Text, ""))
                                    'cn.ExecuteNoneQuery(" Update abZayeatGardeshHa Set Res1='" & rowDetail.Cells("ZayeatCodeKala").Value.ToString & "' ,Tozih= '" & rowDetail.Cells("Tozih").Text & "' where ZayeatGardeshHaSN=" & ZayeatGardeshHaSN)
                                Else
                                    CSystem.MsgBox("عدم تعیین کد نظریه ضایعات : " + vbNewLine +
                                                    "شماره درخواست ضایعات : " + ZayeatGardeshno.ToString + vbNewLine +
                                                   "شماره اقلام ضایعات : " + rowDetail.Cells("ZayeatGardeshHaNo").Text, MsgBoxStyle.Critical, "")
                                    Exit Sub
                                End If
                            End If
                        Next

                    Catch ex As Exception
                        CSystem.MsgBox("خطا در ذخیره فیلدهای شرح و توضیح Detail ضایعات" + vbNewLine + "ZayeatGardeshHaSN : " + ZayeatGardeshHaSN + vbNewLine + ex.Message, MsgBoxStyle.Critical, "")
                        Exit Sub
                    End Try
                End If

                Try
                    cn.CallSP("abSpC_UpdateZayeatGardeshFlow", ZayeatGardeshSN, gSM.UserID.ToString, gSM.UserID_Name, ZayeatGardeshStateSN, IsFinalLevel)
                Catch ex As Exception
                    ErrorMessage += vbNewLine + _row.Cells("ZayeatGardeshNo").Text + ":" + vbNewLine + ex.Message
                    Exit Try
                End Try


                If IsFinalLevel AndAlso gVahedeTejariSN = 9.935 Then
                    Dim DvServer As New DataView
                    Dim ServerName As String = cn.SQLServerName
                    Dim DatabaseName As String = cn.SQLDatabaseName
                    Dim VahedeTejariSN As Decimal = gVahedeTejariSN

                    DvServer = cn.ExecuteQuery("Select Top 1 * from [abFn_getServerDbOfApplication](" & _row.Cells("VahedeTejariSN").Text & ")  Order by Tartib")
                    If DvServer.Count = 1 Then
                        ServerName = DvServer(0)("ServerName").ToString
                        DatabaseName = DvServer(0)("DatabaseName").ToString
                        VahedeTejariSN = CDec(_row.Cells("VahedeTejariSN").Value)
                    Else
                        CSystem.MsgBox("مشخصه سرور برای شعبه مقصد یافت نشد", MsgBoxStyle.Exclamation, "")
                        Exit Try
                    End If

                    Dim DsXml As New DataSet

                    CType(GridZayeatDetail.DataSource, DataView).RowFilter = "0=0"

                    Dim DtXml As DataTable = New DataView(CType(GridZayeatDetail.DataSource, DataView).ToTable, "ZayeatGardeshSN=" & ZayeatGardeshSN.ToString, "", DataViewRowState.CurrentRows).ToTable.Copy
                    DtXml.TableName = "ZayeatGardesh"

                    DtXml.Columns.Remove("SanadDate")
                    DtXml.Columns.Remove("ZayeatGardeshHaNo")
                    DtXml.Columns.Remove("TaminKonandehSN")
                    DtXml.Columns.Remove("TaminKonandehDS")
                    DtXml.Columns.Remove("KalaPhizikiSN")
                    DtXml.Columns.Remove("TolidDate")
                    DtXml.Columns.Remove("EnghezaDate")
                    DtXml.Columns.Remove("KalaNo")
                    DtXml.Columns.Remove("KalaDs")
                    DtXml.Columns.Remove("ShomarehRahgiri")
                    DtXml.Columns.Remove("Meghdar")
                    DtXml.Columns.Remove("Karton")
                    DtXml.Columns.Remove("Adad")
                    DtXml.Columns.Remove("ZayeatType")
                    DtXml.Columns.Remove("ZayeatTypeDS")
                    DtXml.Columns.Remove("SaveData")
                    DtXml.Columns.Remove("EbtalRadif")
                    DtXml.Columns.Remove("UserId")
                    DtXml.Columns.Remove("TedadAjza")
                    DtXml.Columns.Remove("RialZayeat")

                    DsXml.Tables.Add(DtXml)
                        Dim XmlStr As String = DsXml.GetXml()

                        Dim Str As String = ""

                        Try
                            Str = AnbarRule.KartablZayeat_TaeedDarkhast_xml(VahedeTejariSN, ServerName, DatabaseName, XmlStr, dcbNerkh.SelectedIndex + 1, gSM.UserID, gSM.UserID_Name, cn)

                            If Str = "" Then
                                SuccessMessage += _row.Cells("ZayeatGardeshNo").Text + ","
                            Else
                                ErrorMessage += vbNewLine + _row.Cells("ZayeatGardeshNo").Text + ":" + vbNewLine + Str
                            End If
                            If ErrorMessage.Length > 0 Then
                                Exit For
                            End If
                        Catch ex As Exception
                            CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ابطال درخواست")
                        End Try
                    Else
                        SuccessMessage += _row.Cells("ZayeatGardeshNo").Text + ","
                    End If


            Next

            If SuccessMessage.EndsWith(",") Then
                SuccessMessage = SuccessMessage.Substring(0, SuccessMessage.Length - 1)
                CSystem.MsgBox("عملیات تایید روی شماره درخواست (های) زیر با موفقیت انجام گردید" + vbNewLine + SuccessMessage, MsgBoxStyle.Information, "تایید درخواست")
            End If

            If ErrorMessage.Length > 0 Then
                cn.CallSP("abSpC_RollBackZayeatGardeshOperation", ZayeatGardeshSN, ZayeatGardeshStateSN)
                CSystem.MsgBox("عملیات تایید روی شماره درخواست (های) زیر انجام نشد!" + ErrorMessage, MsgBoxStyle.Exclamation, "عدم تایید درخواست")
            End If



        Catch ex As Exception
            cn.CallSP("abSpC_RollBackZayeatGardeshOperation", ZayeatGardeshSN, ZayeatGardeshStateSN)
            CSystem.MsgBox("خطا در تایید ضایعات" + vbNewLine + "درخواست شماره " + ZayeatGardeshno + vbNewLine + ex.Message, MsgBoxStyle.Critical)
        Finally
            wfrm.Close()
        End Try


        BtnRefreshData_Click(sender, e)


    End Sub

    Private Sub GridZayeatTitr_DoubleClick(sender As Object, e As EventArgs) Handles GridZayeatTitr.DoubleClick
        GridZayeatTitr.AutoSizeColumns()
        GridZayeatTitr.Refresh()
    End Sub

    Private Sub GridZayeatDetail_DoubleClick(sender As Object, e As EventArgs) Handles GridZayeatDetail.DoubleClick
        GridZayeatDetail.AutoSizeColumns()
        GridZayeatDetail.Refresh()
    End Sub

    Private Sub BtnNerkh_Click(sender As Object, e As EventArgs) Handles BtnNerkh.Click

        Dim dgRow As Janus.Windows.GridEX.GridEXRow
        dgRow = GridZayeatTitr.CurrentRow

        If dgRow Is Nothing Then
            CSystem.MsgBox("جهت مشاهده نرخ روی رکورد تیتر ضایعات مربوطه کلیک نمایید", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If dgRow.RowType <> RowType.Record Then
            CSystem.MsgBox("جهت مشاهده نرخ روی رکورد تیتر ضایعات مربوطه کلیک نمایید", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        Dim _ZayeatGardeshSN As String = ""

        For Each _row As Janus.Windows.GridEX.GridEXRow In GridZayeatTitr.GetCheckedRows
            _ZayeatGardeshSN += _row.Cells("ZayeatGardeshSN").Text + ","
        Next

        If _ZayeatGardeshSN.EndsWith(",") Then
            _ZayeatGardeshSN = _ZayeatGardeshSN.Substring(0, _ZayeatGardeshSN.Length - 1)
        Else
            _ZayeatGardeshSN = dgRow.Cells("ZayeatGardeshSN").Value.ToString
        End If


        Dim DvNerkh As DataView = AnbarRule.KartablZayeat_GetNerKhSanadZayeat(_ZayeatGardeshSN, CShort(dcbNerkh.Text.Substring(0, 1)), CInt(dgRow.Cells("AccessForDarjNerkh").Value), cn)

        If CInt(dgRow.Cells("AccessForDarjNerkh").Value) = 0 Then
            If DvNerkh.Count > 0 Then
                Dim Nerkh As ULong = 0
                Dim Filter As String = CType(GridZayeatDetail.DataSource, DataView).RowFilter
                CType(GridZayeatDetail.DataSource, DataView).RowFilter = "0=0"
                For Each rovW As DataRowView In DvNerkh
                    Nerkh = CULng(rovW("Nerkh"))
                    For Each Row As Janus.Windows.GridEX.GridEXRow In GridZayeatDetail.GetDataRows
                        If Row.Cells("ZayeatGardeshHaSN").Value = rovW("ZayeatGardeshHaSN") Then
                            Row.BeginEdit()
                            Row.Cells("RialZayeat").Value = Nerkh
                            Row.EndEdit()
                        End If
                    Next
                Next
                CType(GridZayeatDetail.DataSource, DataView).RowFilter = Filter
            End If
        Else
            BtnRefreshData_Click(sender, e)
        End If

        GridZayeatDetail.AutoSizeColumns()

    End Sub


End Class

