''Add By Dehghani 14020915

Imports NetSql.View
Imports System.Data
Imports C1.Win.C1FlexGrid.Classic
Imports Minoo.Applications.Common.SharedItems
Imports Minoo.Applications.ProductionPlanning.Common
Imports NetSql.View.CEnum
Imports NetSql.DB.CConnection
Imports NetSql.Common


Public Class FrmPriodicService
    Inherits Minoo.Base.FTBaseForm

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmPriodicService
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ButtonTozih As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonGhateeKhadamat As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PanelServiceNavigation As System.Windows.Forms.Panel
    Friend WithEvents PanelService As System.Windows.Forms.Panel
    Friend WithEvents PanelServiceCommand As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFilterTarikh As Button
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmPriodicService
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmPriodicService
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmPriodicService)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
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

    Private components As System.ComponentModel.IContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelMaster As System.Windows.Forms.Panel
    Friend WithEvents PanelMasterNavigation As System.Windows.Forms.Panel
    Friend WithEvents PanelMasterCommand As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFilterTarikh = New System.Windows.Forms.Button()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.PanelMasterNavigation = New System.Windows.Forms.Panel()
        Me.PanelMasterCommand = New System.Windows.Forms.Panel()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelServiceNavigation = New System.Windows.Forms.Panel()
        Me.PanelService = New System.Windows.Forms.Panel()
        Me.ButtonGhateeKhadamat = New System.Windows.Forms.Button()
        Me.PanelServiceCommand = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtonTozih = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 593)
        Me.Panel1.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 593)
        Me.SplitContainer1.SplitterDistance = 260
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.PanelMasterNavigation)
        Me.Panel2.Controls.Add(Me.PanelMasterCommand)
        Me.Panel2.Controls.Add(Me.PanelMaster)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 260)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnFilterTarikh)
        Me.GroupBox1.Controls.Add(Me.TxtFromDate)
        Me.GroupBox1.Location = New System.Drawing.Point(621, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 42)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نمایش از تاریخ ... به بعد"
        '
        'BtnFilterTarikh
        '
        Me.BtnFilterTarikh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFilterTarikh.Location = New System.Drawing.Point(7, 14)
        Me.BtnFilterTarikh.Name = "BtnFilterTarikh"
        Me.BtnFilterTarikh.Size = New System.Drawing.Size(52, 24)
        Me.BtnFilterTarikh.TabIndex = 6
        Me.BtnFilterTarikh.Text = "نمایش"
        Me.BtnFilterTarikh.UseVisualStyleBackColor = True
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.Location = New System.Drawing.Point(65, 18)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 175
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'PanelMasterNavigation
        '
        Me.PanelMasterNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterNavigation.Location = New System.Drawing.Point(12, 215)
        Me.PanelMasterNavigation.Name = "PanelMasterNavigation"
        Me.PanelMasterNavigation.Size = New System.Drawing.Size(266, 37)
        Me.PanelMasterNavigation.TabIndex = 2
        '
        'PanelMasterCommand
        '
        Me.PanelMasterCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterCommand.Location = New System.Drawing.Point(793, 215)
        Me.PanelMasterCommand.Name = "PanelMasterCommand"
        Me.PanelMasterCommand.Size = New System.Drawing.Size(277, 37)
        Me.PanelMasterCommand.TabIndex = 1
        '
        'PanelMaster
        '
        Me.PanelMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMaster.Location = New System.Drawing.Point(3, 3)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(1070, 201)
        Me.PanelMaster.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.SplitContainer2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1076, 329)
        Me.Panel3.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Panel1Collapsed = True
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(1076, 329)
        Me.SplitContainer2.SplitterDistance = 146
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer3.Panel1Collapsed = True
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer3.Size = New System.Drawing.Size(1076, 329)
        Me.SplitContainer3.SplitterDistance = 462
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel15)
        Me.SplitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer4.Panel2Collapsed = True
        Me.SplitContainer4.Size = New System.Drawing.Size(1076, 329)
        Me.SplitContainer4.SplitterDistance = 827
        Me.SplitContainer4.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.Control
        Me.Panel15.Controls.Add(Me.TabControl1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1076, 329)
        Me.Panel15.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1076, 329)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1068, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "سرویس های دوره ای"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.PanelServiceNavigation)
        Me.Panel5.Controls.Add(Me.PanelService)
        Me.Panel5.Controls.Add(Me.ButtonGhateeKhadamat)
        Me.Panel5.Controls.Add(Me.PanelServiceCommand)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1062, 296)
        Me.Panel5.TabIndex = 4
        '
        'PanelServiceNavigation
        '
        Me.PanelServiceNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelServiceNavigation.Location = New System.Drawing.Point(3, 256)
        Me.PanelServiceNavigation.Name = "PanelServiceNavigation"
        Me.PanelServiceNavigation.Size = New System.Drawing.Size(268, 37)
        Me.PanelServiceNavigation.TabIndex = 6
        '
        'PanelService
        '
        Me.PanelService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelService.Location = New System.Drawing.Point(3, 0)
        Me.PanelService.Name = "PanelService"
        Me.PanelService.Size = New System.Drawing.Size(1056, 252)
        Me.PanelService.TabIndex = 8
        '
        'ButtonGhateeKhadamat
        '
        Me.ButtonGhateeKhadamat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGhateeKhadamat.Location = New System.Drawing.Point(666, 255)
        Me.ButtonGhateeKhadamat.Name = "ButtonGhateeKhadamat"
        Me.ButtonGhateeKhadamat.Size = New System.Drawing.Size(108, 37)
        Me.ButtonGhateeKhadamat.TabIndex = 3
        Me.ButtonGhateeKhadamat.Text = "قطعی سازی سرویس"
        Me.ButtonGhateeKhadamat.UseVisualStyleBackColor = True
        '
        'PanelServiceCommand
        '
        Me.PanelServiceCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelServiceCommand.Location = New System.Drawing.Point(786, 256)
        Me.PanelServiceCommand.Name = "PanelServiceCommand"
        Me.PanelServiceCommand.Size = New System.Drawing.Size(273, 37)
        Me.PanelServiceCommand.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.ButtonTozih)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(96, 100)
        Me.Panel4.TabIndex = 0
        '
        'ButtonTozih
        '
        Me.ButtonTozih.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTozih.Location = New System.Drawing.Point(32, 65)
        Me.ButtonTozih.Name = "ButtonTozih"
        Me.ButtonTozih.Size = New System.Drawing.Size(27, 27)
        Me.ButtonTozih.TabIndex = 2
        Me.ButtonTozih.Text = "ثبت گزارش عملیات"
        Me.ButtonTozih.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-31, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "گزارش عملیات"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(90, 31)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'FrmPriodicService
        '
        Me.ClientSize = New System.Drawing.Size(1076, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPriodicService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "سرویس های دوره ای"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#Region "Declaration"
    Private WithEvents MasterDataview As CDataView
    Private WithEvents ServiceDataview As CDataView
    Private WithEvents ComboAmvalSN As NetSql.Components.DataCombo
    Private WithEvents ComboServiceSN As NetSql.Components.DataCombo
    Dim funbtCommon As New CPublicFunctions
    Dim btCalendarFunction As New Minoo.Applications.ProductionPlanning.Calender.CCalender
    Public AccessGhateeKhadamat As Boolean = gSM.ActionEnabled("GhateePriodicService")
    Public AccessGhateeDarkhast As Boolean = gSM.ActionDelete("ctDarkhastRepair")
    Public PedarVahedTejariSN As Decimal = 0

#End Region

#Region "ComboProperties"


#End Region

#Region "DataViewCommandClick"

    Private Sub MasterDataview_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) Handles MasterDataview.AfterCommandClick
        If aCommand = EnumCommands.cmSave Then
            MasterDataview.Refresh()
            MasterDataview.FlexGrid.Select(MasterDataview.DataRows, 1, Nothing, Nothing)
        End If
    End Sub

    Private Sub MasterDataview_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles MasterDataview.CommandClick
        If aCommand = EnumCommands.cmAdd Then
            'MasterDataview.Fields("DarkhastRepairNo").DefaultValue = funbtCommon.MaxNoInTable("ctDarkhastRepair", "DarkhastRepairNo", "VahedeTejariSN=" & gVahedeTejariSN.ToString) + 1
        ElseIf aCommand = EnumCommands.cmSave Then
            If Val(MasterDataview.Fields("DarkhastRepairDate").Value) < Val(MasterDataview.Fields("MachineStopDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ توقف نمی تواند از تاریخ درخواست (امروز) بزرگتر باشد.")
                aCancel = True
            ElseIf MasterDataview.Fields("MachineStopDate").Value.ToString.Length <> 8 Then
                NetSql.Common.CSystem.MsgBox("تاریخ توقف ثبت شده خارج از محدوده مجاز می باشد.")
                aCancel = True
            ElseIf MasterDataview.Fields("MachineStartDate").Value.ToString.Length = 8 AndAlso Val(MasterDataview.Fields("MachineStopDate").Value) > Val(MasterDataview.Fields("MachineStartDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ توقف نمی تواند از تاریخ شروع به کار دستگاه بزرگتر باشد.")
                aCancel = True
            End If

            Dim StartTime As Integer = btCalendarFunction.TimeCharToInt(MasterDataview.Fields("MachineStartTime").Value.ToString)
            Dim StopTime As Integer = btCalendarFunction.TimeCharToInt(MasterDataview.Fields("MachineStopTime").Value.ToString)

            If Val(MasterDataview.Fields("MachineStopDate").Value) = Val(MasterDataview.Fields("MachineStartDate").Value) Then
                If StartTime > 0 Then
                    If StopTime > StartTime Then
                        NetSql.Common.CSystem.MsgBox("زمان توقف نمی تواند از زمان شروع به کار دستگاه بزرگتر باشد.")
                        aCancel = True
                    End If
                End If
            ElseIf StopTime <= 0 OrElse StopTime > 86340 Then
                NetSql.Common.CSystem.MsgBox("زمان توقف ثبت شده خارج از محدوده مجاز می باشد.")
                aCancel = True
            End If

        End If
    End Sub


    Private Sub ServiceDataview_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles ServiceDataview.CommandClick


        If aCommand = EnumCommands.cmSave Then
            ServiceDataview.Fields("DarkhastRepairSN").Value = MasterDataview.Fields("DarkhastRepairSN").Value
            Dim StartTime As Integer = btCalendarFunction.TimeCharToInt(ServiceDataview.Fields("StartTime").Value)
            Dim StopTime As Integer = btCalendarFunction.TimeCharToInt(ServiceDataview.Fields("StopTime").Value)
            If Val(ServiceDataview.Fields("StartDate").Value) > Val(ServiceDataview.Fields("StopDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ شروع  نمی تواند بعد از تاریخ پایان  باشد.")
                aCancel = True

            ElseIf Val(ServiceDataview.Fields("StartDate").Value) = Val(ServiceDataview.Fields("StopDate").Value) AndAlso StartTime > StopTime Then
                NetSql.Common.CSystem.MsgBox("زمان شروع  نمی تواند بعد از زمان پایان  باشد.")
                aCancel = True
            End If
        End If



    End Sub

    Private Sub ServiceDataview_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) Handles ServiceDataview.AfterCommandClick
        'If aCommand = EnumCommands.cmSave Then
        '    Dim _Key As Object = MasterDataview.FlexGrid.Row
        '    MasterDataview.Refresh()
        '    MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
        'End If
    End Sub



#End Region

#Region "DataViewGridProperties"


    Private Sub MasterDataview_GetGridProperties() Handles MasterDataview.GetGridProperties
        With MasterDataview.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub ServiceDataview_GetGridProperties() Handles ServiceDataview.GetGridProperties
        With ServiceDataview.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

#End Region

    Private Sub FrmPriodicService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ButtonGhateeKhadamat.Visible = AccessGhateeKhadamat
        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 6) + "01"
        Call InitDataView()
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

    End Sub

    Sub InitDataView()

        Try
            MasterDataview = New CDataView(cn)
            With MasterDataview
                .Init(PanelMaster, , PanelMasterCommand, PanelMasterNavigation, EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdDelete _
                                                                                Or EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdUpdate)
                .TableName = "ctDarkhastRepair"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_Amval", "AmvalSN", "AmvalSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeTejari", "VahedeTejariSN", "VahedeTejariSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")

                .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)
                .EditInGrid = True
                .AutoFetchCurrentRow = True
                .SQLWhere = "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.DarkhastRepairServiceSN Is null "
                .SQLOrderBy = "ctDarkhastRepair.Status,DarkhastRepairDate Desc,ctDarkhastRepair.VahedeTejariSN"

                With .Fields
                    With .Add("DarkhastRepairSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("KargahSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    .Add("KhateTolidSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    .Add("KalaSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    .Add("VahedeTejariSN", , EnumFieldOptions.foHidden).DefaultValue = gVahedeTejariSN

                    With .Add("{abVw_Amval.VahedeTejariDS} AS VahedeTejariDS", "DataCombo", EnumFieldOptions.foDefault)
                        .ReadOnly = True
                        .Caption = "شعبه"
                    End With
                    With .Add("AmvalSN->abVw_Amval.{'('+VahedeTejariDS+')'+AmvalNo + '.' + KalaDS}  As AmvalSN", "DataCombo", EnumFieldOptions.foDefault)
                        .Caption = "کد و شرح اموال"
                        ComboAmvalSN = .Component
                        .ComboLateBinding = True
                        '.RefreshCombo()
                        .MinComponentWidth = 100
                    End With
                    With .Add("DarkhastRepairNo", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "شماره درخواست"
                        .ReadOnly = True
                        .DefaultValue = 1
                    End With
                    With .Add("DarkhastRepairDate", "TextBox", EnumFieldOptions.foHidden)
                        .Caption = "تاریخ درخواست"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastRepairDS", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "شرح درخواست"
                        .MinComponentWidth = 100
                    End With
                    With .Add("DarkhastRepairTypeSN->{DarkhastRepairTypeDS} AS DarkhastRepairTypeSN", "DataCombo", EnumFieldOptions.foHidden)
                        .Caption = "نوع درخواست"
                        .DefaultValue = 1.935
                    End With
                    With .Add("DarkhastRepairServiceSN", "DataCombo", EnumFieldOptions.foHidden)
                        .Caption = "بخش سرویس دهنده"

                    End With
                    With .Add("Cost", "Textbox", EnumFieldOptions.foHidden)
                        .Caption = "هزینه"
                        .DataType = "int"
                        .Format = "##,###"
                    End With
                    With .Add("MachineStopDate", "TextBox", EnumFieldOptions.foHidden)
                        .Caption = "تاریخ توقف"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .Component.Visible = False

                    End With
                    With .Add("MachineStopTime", "TextBox", EnumFieldOptions.foTime)
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .Caption = " زمان توقف"
                        .DataType = "TimeSpan"
                        .Component.Visible = False
                    End With
                    With .Add("MachineStartDate", "TextBox", EnumFieldOptions.foHidden)
                        .Caption = "تاریخ شروع به کار"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .Component.Visible = False

                    End With
                    With .Add("MachineStartTime", "TextBox", EnumFieldOptions.foTime)
                        .Caption = "زمان شروع به کار"
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .DataType = "TimeSpan"
                        .Component.Visible = False

                    End With
                    With .Add("Status->{StatusDS} As Status", "TextBox", EnumFieldOptions.foHidden)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastKonande", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "درخواست کننده"
                        .DefaultValue = gSM.UserName
                        .ReadOnly = True
                    End With
                    With .Add("GhateeKonandeh", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "قطعی کننده"
                        .ReadOnly = True
                    End With
                    With .Add("NahayeeKonandeh", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "ثبت کننده نهایی "
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastRepairServiceTypeSN", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = 2.935
                    End With
                    .Add("Tozih", "TextBox", EnumFieldOptions.foDefault).Caption = "توضیح"

                    .Add("Res1", , EnumFieldOptions.foHidden)
                    .Add("Res2", , EnumFieldOptions.foHidden)
                    .Add("Res3", , EnumFieldOptions.foHidden)
                    With .Add("UserId_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = gSM.UserName
                    End With
                    With .Add("Host_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = System.Windows.Forms.SystemInformation.ComputerName
                    End With

                    .Add("RecChkSum", , EnumFieldOptions.foHidden)
                    .Add("TimeStamp", , EnumFieldOptions.foHidden)
                End With
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Master", MsgBoxStyle.MsgBoxRtlReading, "")
        End Try


        Try
            ServiceDataview = New CDataView(cn)
            With ServiceDataview
                .Init(PanelService, , PanelServiceCommand, PanelServiceNavigation, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdInsert _
                                                                                Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdUpdate)

                .TableName = "ctDarkhastRepairPriodicService"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "ctDarkhastRepairService", "DarkhastRepairServiceSN", "DarkhastRepairServiceSN")

                .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)
                .EditInGrid = True

                With .Fields
                    With .Add("DarkhastRepairPriodicServiceSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("DarkhastRepairSN", , EnumFieldOptions.foHidden)
                    With .Add("DarkhastRepairServiceSN->{DarkhastRepairServiceDS} AS DarkhastRepairServiceSN", "DataCombo", EnumFieldOptions.foDefault)
                        .Caption = "سرویس دوره ای"
                        .ComboWhereCondition = "DarkhastRepairServiceSN In (Select DarkhastRepairServiceSN from [ctDarkhastRepairService] where [DarkhastRepairServiceTypeSN]=2.935)"
                        .RefreshCombo()
                    End With

                    With .Add("StartDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ شروع"
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .ReadOnly = False
                    End With
                    With .Add("StartTime", "TextBox", EnumFieldOptions.foTime)
                        .Caption = "زمان شروع"
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .DataType = "TimeSpan"
                    End With
                    With .Add("StopDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ اتمام"
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    With .Add("StopTime", "TextBox", EnumFieldOptions.foTime)
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .Caption = "زمان اتمام"
                        .DataType = "TimeSpan"
                    End With

                    .Add("Tozih", "TextBox", EnumFieldOptions.foDefault).Caption = "توضیح"
                    With .Add("Status->{StatusDS} As Status", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With
                    With .Add("Cost", "Textbox", EnumFieldOptions.foDefault)
                        .Caption = "هزینه(ریال)"
                        .DataType = "int"
                        .Format = "##,###"
                    End With
                    With .Add("SabtDate", "", EnumFieldOptions.foDate)
                        .ReadOnly = True
                        .Caption = "تاریخ ثبت"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    .Add("Rez3", , EnumFieldOptions.foHidden)
                    .Add("Rez4", , EnumFieldOptions.foHidden)
                    .Add("Rez5", , EnumFieldOptions.foHidden)
                    .Add("Rez6", , EnumFieldOptions.foHidden)

                    With .Add("UserId_Name", , EnumFieldOptions.foDefault)
                        .DefaultValue = gSM.UserName
                        .Caption = "ثبت کننده"
                    End With
                    With .Add("GhateeKonandeh", , EnumFieldOptions.foDefault)
                        .ReadOnly = True
                        .Caption = "قطعی کننده"
                    End With
                    With .Add("Host_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = System.Windows.Forms.SystemInformation.ComputerName
                    End With
                    .Add("RecChkSum", , EnumFieldOptions.foHidden)
                    .Add("TimeStamp", , EnumFieldOptions.foHidden)
                End With
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Service", MsgBoxStyle.MsgBoxRtlReading, "")
        End Try

        MasterDataview.Refresh()
        MasterDataview.FlexGrid.ColHidden(MasterDataview.FlexGrid.ColIndex("MachineStopDate")) = True
        MasterDataview.FlexGrid.ColHidden(MasterDataview.FlexGrid.ColIndex("MachineStopTime")) = True
        MasterDataview.FlexGrid.ColHidden(MasterDataview.FlexGrid.ColIndex("MachineStartDate")) = True
        MasterDataview.FlexGrid.ColHidden(MasterDataview.FlexGrid.ColIndex("MachineStartTime")) = True

    End Sub

    Private Sub MasterDataview_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) Handles MasterDataview.FillDetailsWithData

        If aFetched Then
            Dim DarkhastSn As Decimal = CDec(MasterDataview.FieldValue("DarkhastRepairSN"))

            With ServiceDataview
                .SQLWhere = "ctDarkhastRepairPriodicService.DarkhastRepairSN = " & MasterDataview.FieldValue("DarkhastRepairSN")
                .Refresh()
            End With

            MasterDataview.CommandEnabled(EnumCommands.cmEdit) = gVahedeTejariSN = 9.935
            MasterDataview.CommandEnabled(EnumCommands.cmDelete) = gVahedeTejariSN = 9.935
            ButtonTozih.Enabled = AccessGhateeKhadamat AndAlso Not ButtonGhateeKhadamat.Enabled AndAlso Val(MasterDataview.FieldValue("Status")) <> 7

            RichTextBox1.ReadOnly = Val(MasterDataview.FieldValue("Status")) = 7 Or Not AccessGhateeKhadamat
            RichTextBox1.Text = MasterDataview.FieldText("Tozih")
        End If

    End Sub

    Private Sub ButtonGhateeDarkhast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MasterDataview.DataRows = 0 Then
            NetSql.Common.CSystem.MsgBox("درخواستی ثبت نشده است.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آیا مایل به قطعی سازی درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " می باشید ؟ ", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Object = MasterDataview.FlexGrid.Row
            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "GhateeDarkhast", DBNull.Value, gSM.UserID_Name)
                MasterDataview.Refresh()
                MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در قطعی سازی درخواست" + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "")
            End Try
        End If

    End Sub

    Private Sub ButtonGhateeKhadamat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGhateeKhadamat.Click

        If ServiceDataview.DataRows = 0 Then
            MsgBox("سرویس دوره ای برای درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " ثبت نشده است", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "")
            Exit Sub
        Else
            If NetSql.Common.CSystem.MsgBox("آیا مایل به قطعی سازی سرویس دوره ای ثبت شده برای درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " می باشید ؟ ", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Object = ServiceDataview.FlexGrid.Row
            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(ServiceDataview.FieldValue("DarkhastRepairPriodicServiceSN")), "GhateeService", DBNull.Value, gSM.UserID_Name)
                ServiceDataview.Refresh()
                ServiceDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در قطعی سازی سرویس دوره ای" + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "")
            End Try
        End If

    End Sub

    Private Sub ButtonTozih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTozih.Click

        If RichTextBox1.Text = "" Then
            If NetSql.Common.CSystem.MsgBox("گزارشی برای درخواست شماره  " & MasterDataview.FieldText("DarkhastRepairNO") & " ثبت نشده است.آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If NetSql.Common.CSystem.MsgBox("توجه داشته باشید با ثبت گزارش درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " نهایی خواهد شد و شما مجوز ویرایش آن را نخواهید داشت." _
                                            + vbCr + "آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Integer = MasterDataview.FlexGrid.Row
            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "finish", RichTextBox1.Text.ToString, gSM.UserID_Name)
                MasterDataview.Refresh()
                MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
                NetSql.Common.CSystem.MsgBox("گزارش عملیات با موفقیت ثبت گردید.", MsgBoxStyle.MsgBoxRtlReading, "")
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در ثبت گزارش عملیات" + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "")
            End Try

        End If

    End Sub

    Private Sub BtnFilterTarikh_Click(sender As Object, e As EventArgs) Handles BtnFilterTarikh.Click
        With MasterDataview
            .SQLWhere = "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.DarkhastRepairServiceSN Is null "
            .Refresh()
        End With
    End Sub

    Private Sub ServiceDataview_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles ServiceDataview.FillDetailsWithData
        If aFetched Then
            ButtonGhateeKhadamat.Enabled = ServiceDataview.DataRows <> 0 AndAlso Val(ServiceDataview.FieldValue("Status")) = 1 AndAlso AccessGhateeKhadamat
            ServiceDataview.CommandEnabled(EnumCommands.cmEdit) = Val(ServiceDataview.FieldValue("Status")) = 1
            ServiceDataview.CommandEnabled(EnumCommands.cmDelete) = Val(ServiceDataview.FieldValue("Status")) = 1
        End If

    End Sub
End Class
