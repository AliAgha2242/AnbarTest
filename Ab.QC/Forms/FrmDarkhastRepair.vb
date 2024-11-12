''Add By Dehghani 14020915

Imports NetSql.View
Imports System.Data
Imports C1.Win.C1FlexGrid.Classic
Imports Minoo.Applications.Common.SharedItems
Imports Minoo.Applications.ProductionPlanning.Common
Imports NetSql.View.CEnum
Imports NetSql.DB.CConnection
Imports NetSql.Common
Imports Anbar.BRL


Public Class FrmDarkhastRepair
    Inherits Minoo.Base.FTBaseForm

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmDarkhastRepair
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnNahayeeRepairDarkhast As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonGhateeDarkhast As System.Windows.Forms.Button
    Friend WithEvents ButtonGhateeKhadamat As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PanelOperator As System.Windows.Forms.Panel
    Friend WithEvents PanelOperatorNavigation As System.Windows.Forms.Panel
    Friend WithEvents PanelOperatorcommand As System.Windows.Forms.Panel
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PanelLavazemNavigation As System.Windows.Forms.Panel
    Friend WithEvents PanelLavazem As System.Windows.Forms.Panel
    Friend WithEvents PanelLavazemCommand As System.Windows.Forms.Panel
    Friend WithEvents BtnEbtalDarkhastRepair As Button
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFilterTarikh As Button
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmDarkhastRepair
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmDarkhastRepair
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmDarkhastRepair)
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
        Me.ButtonGhateeDarkhast = New System.Windows.Forms.Button()
        Me.ButtonGhateeKhadamat = New System.Windows.Forms.Button()
        Me.PanelMasterNavigation = New System.Windows.Forms.Panel()
        Me.PanelMasterCommand = New System.Windows.Forms.Panel()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelOperator = New System.Windows.Forms.Panel()
        Me.PanelOperatorNavigation = New System.Windows.Forms.Panel()
        Me.PanelOperatorcommand = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelLavazemNavigation = New System.Windows.Forms.Panel()
        Me.PanelLavazem = New System.Windows.Forms.Panel()
        Me.PanelLavazemCommand = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnEbtalDarkhastRepair = New System.Windows.Forms.Button()
        Me.BtnNahayeeRepairDarkhast = New System.Windows.Forms.Button()
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
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.Panel2.Controls.Add(Me.ButtonGhateeDarkhast)
        Me.Panel2.Controls.Add(Me.ButtonGhateeKhadamat)
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
        Me.GroupBox1.Location = New System.Drawing.Point(657, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 42)
        Me.GroupBox1.TabIndex = 0
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
        'ButtonGhateeDarkhast
        '
        Me.ButtonGhateeDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGhateeDarkhast.Location = New System.Drawing.Point(556, 215)
        Me.ButtonGhateeDarkhast.Name = "ButtonGhateeDarkhast"
        Me.ButtonGhateeDarkhast.Size = New System.Drawing.Size(95, 37)
        Me.ButtonGhateeDarkhast.TabIndex = 4
        Me.ButtonGhateeDarkhast.Text = "قطعی سازی درخواست"
        Me.ButtonGhateeDarkhast.UseVisualStyleBackColor = True
        '
        'ButtonGhateeKhadamat
        '
        Me.ButtonGhateeKhadamat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGhateeKhadamat.Location = New System.Drawing.Point(457, 215)
        Me.ButtonGhateeKhadamat.Name = "ButtonGhateeKhadamat"
        Me.ButtonGhateeKhadamat.Size = New System.Drawing.Size(93, 37)
        Me.ButtonGhateeKhadamat.TabIndex = 3
        Me.ButtonGhateeKhadamat.Text = "قطعی سازی خدمات"
        Me.ButtonGhateeKhadamat.UseVisualStyleBackColor = True
        '
        'PanelMasterNavigation
        '
        Me.PanelMasterNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterNavigation.Location = New System.Drawing.Point(3, 215)
        Me.PanelMasterNavigation.Name = "PanelMasterNavigation"
        Me.PanelMasterNavigation.Size = New System.Drawing.Size(258, 37)
        Me.PanelMasterNavigation.TabIndex = 2
        '
        'PanelMasterCommand
        '
        Me.PanelMasterCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterCommand.Location = New System.Drawing.Point(829, 215)
        Me.PanelMasterCommand.Name = "PanelMasterCommand"
        Me.PanelMasterCommand.Size = New System.Drawing.Size(242, 37)
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
        Me.Panel15.Size = New System.Drawing.Size(827, 329)
        Me.Panel15.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(827, 329)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(819, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "نیروی انسانی"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.PanelOperator)
        Me.Panel6.Controls.Add(Me.PanelOperatorNavigation)
        Me.Panel6.Controls.Add(Me.PanelOperatorcommand)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(813, 296)
        Me.Panel6.TabIndex = 4
        '
        'PanelOperator
        '
        Me.PanelOperator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOperator.Location = New System.Drawing.Point(3, 3)
        Me.PanelOperator.Name = "PanelOperator"
        Me.PanelOperator.Size = New System.Drawing.Size(807, 249)
        Me.PanelOperator.TabIndex = 6
        '
        'PanelOperatorNavigation
        '
        Me.PanelOperatorNavigation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOperatorNavigation.Location = New System.Drawing.Point(3, 256)
        Me.PanelOperatorNavigation.Name = "PanelOperatorNavigation"
        Me.PanelOperatorNavigation.Size = New System.Drawing.Size(225, 37)
        Me.PanelOperatorNavigation.TabIndex = 5
        '
        'PanelOperatorcommand
        '
        Me.PanelOperatorcommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOperatorcommand.Location = New System.Drawing.Point(573, 256)
        Me.PanelOperatorcommand.Name = "PanelOperatorcommand"
        Me.PanelOperatorcommand.Size = New System.Drawing.Size(237, 37)
        Me.PanelOperatorcommand.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(819, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "لوازم مصرف شده"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.PanelLavazemNavigation)
        Me.Panel5.Controls.Add(Me.PanelLavazem)
        Me.Panel5.Controls.Add(Me.PanelLavazemCommand)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(813, 297)
        Me.Panel5.TabIndex = 4
        '
        'PanelLavazemNavigation
        '
        Me.PanelLavazemNavigation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLavazemNavigation.Location = New System.Drawing.Point(3, 257)
        Me.PanelLavazemNavigation.Name = "PanelLavazemNavigation"
        Me.PanelLavazemNavigation.Size = New System.Drawing.Size(211, 37)
        Me.PanelLavazemNavigation.TabIndex = 6
        '
        'PanelLavazem
        '
        Me.PanelLavazem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLavazem.Location = New System.Drawing.Point(3, 0)
        Me.PanelLavazem.Name = "PanelLavazem"
        Me.PanelLavazem.Size = New System.Drawing.Size(807, 253)
        Me.PanelLavazem.TabIndex = 8
        '
        'PanelLavazemCommand
        '
        Me.PanelLavazemCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLavazemCommand.Location = New System.Drawing.Point(573, 257)
        Me.PanelLavazemCommand.Name = "PanelLavazemCommand"
        Me.PanelLavazemCommand.Size = New System.Drawing.Size(237, 37)
        Me.PanelLavazemCommand.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.BtnEbtalDarkhastRepair)
        Me.Panel4.Controls.Add(Me.BtnNahayeeRepairDarkhast)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 329)
        Me.Panel4.TabIndex = 0
        '
        'BtnEbtalDarkhastRepair
        '
        Me.BtnEbtalDarkhastRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEbtalDarkhastRepair.Location = New System.Drawing.Point(12, 294)
        Me.BtnEbtalDarkhastRepair.Name = "BtnEbtalDarkhastRepair"
        Me.BtnEbtalDarkhastRepair.Size = New System.Drawing.Size(100, 27)
        Me.BtnEbtalDarkhastRepair.TabIndex = 3
        Me.BtnEbtalDarkhastRepair.Text = "ابطال درخواست"
        Me.BtnEbtalDarkhastRepair.UseVisualStyleBackColor = True
        '
        'BtnNahayeeRepairDarkhast
        '
        Me.BtnNahayeeRepairDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNahayeeRepairDarkhast.Location = New System.Drawing.Point(118, 294)
        Me.BtnNahayeeRepairDarkhast.Name = "BtnNahayeeRepairDarkhast"
        Me.BtnNahayeeRepairDarkhast.Size = New System.Drawing.Size(118, 27)
        Me.BtnNahayeeRepairDarkhast.TabIndex = 2
        Me.BtnNahayeeRepairDarkhast.Text = "ثبت گزارش عملیات"
        Me.BtnNahayeeRepairDarkhast.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 7)
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
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(239, 260)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'FrmDarkhastRepair
        '
        Me.ClientSize = New System.Drawing.Size(1076, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDarkhastRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت درخواست تعمیرات"
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
        Me.TabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#Region "Declaration"
    Private WithEvents MasterDataview As CDataView
    Private WithEvents LavazemDataview As CDataView
    Private WithEvents OperatorDataview As CDataView
    Private WithEvents ComboOperator As NetSql.Components.DataCombo
    Private WithEvents ComboKargah As NetSql.Components.DataCombo
    Private WithEvents ComboKhatTolid As NetSql.Components.DataCombo
    Private WithEvents ComboKalaSN As NetSql.Components.DataCombo
    Private WithEvents ComboAmvalSN As NetSql.Components.DataCombo
    Private WithEvents ComboLavazemSN As NetSql.Components.DataCombo
    Private WithEvents txtVahedSanjesh As NetSql.Components.DataCombo
    Private WithEvents dcbUser As NetSql.Components.DataCombo
    Dim funbtCommon As New CPublicFunctions
    Dim btCalendarFunction As New Minoo.Applications.ProductionPlanning.Calender.CCalender
    'Public AccessGhateeKhadamat As Boolean = gSM.ActionDelete("TaasisatRepairServiceAccess") Or gSM.ActionDelete("MechanicRepairServiceAccess") Or gSM.ActionDelete("ElectricRepairServiceAccess")
    Public AccessGhateeKhadamat As Boolean = gSM.ActionDelete("RepairServiceAccess")
    Public AccessGhateeDarkhast As Boolean = gSM.ActionDelete("RepairServiceGhatee")
    Public PedarVahedTejariSN As Decimal = 0

    Dim IsToolidi As Boolean = IsVahedTejariTolidi

#End Region

#Region "ComboProperties"

    Private Sub ComboKalaSN_GotFocus(sender As Object, e As EventArgs) Handles ComboKalaSN.GotFocus
        If Not MasterDataview.Fields("KhateTolidSN").Value Is Nothing And MasterDataview.Fields("KhateTolidSN").Value.ToString <> "" Then
            With MasterDataview.Fields("KalaSN")
                .ComboWhereCondition = "KalaSN In (Select Distinct MashinSN from qcVw_RelationKargahKhatMashin Where KhateTolidSN=" & MasterDataview.Fields("KhateTolidSN").Value.ToString & ")"
                .RefreshCombo()
            End With
        End If
    End Sub


    Private Sub ComboLavazemSN_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboLavazemSN.Leave

        If Not LavazemDataview.FieldValue("KalaSN") Is Nothing And LavazemDataview.FieldValue("KalaSN") <> "" Then
            Try
                Dim dv As DataView = cn.ExecuteQuery("Select VahedeSanjeshSN from paVahedeSanjeshKala Where kalaSn =  " & LavazemDataview.FieldValue("KalaSN") & "")
                txtVahedSanjesh.SelectedValue = If(dv.Count > 0, dv(0)(0), DBNull.Value)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در تشخیص واحد سنجش کالای مورد نظر", MsgBoxStyle.Exclamation, "")
            End Try

        End If

    End Sub

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
            MasterDataview.Fields("DarkhastRepairNo").DefaultValue = funbtCommon.MaxNoInTable("ctDarkhastRepair", "DarkhastRepairNo", "") + 1
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

    Private Sub OperatorDataview_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) Handles OperatorDataview.AfterCommandClick
        'If aCommand = EnumCommands.cmSave Or aCommand = EnumCommands.cmDelete Then
        '    Dim _Key As Object = MasterDataview.FlexGrid.Row
        '    MasterDataview.Refresh()
        '    MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
        'End If
    End Sub

    Private Sub OperatorDataview_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles OperatorDataview.CommandClick

        If aCommand = EnumCommands.cmSave Then

            OperatorDataview.Fields("DarkhastRepairSN").Value = MasterDataview.Fields("DarkhastRepairSN").Value

            If Val(OperatorDataview.Fields("JobStartDate").Value) > Val(OperatorDataview.Fields("JobStopDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ شروع تعمیر نمی تواند بعد از تاریخ پایان تعمیر باشد.")
                aCancel = True
            ElseIf Val(OperatorDataview.Fields("JobStartDate").Value) < Val(MasterDataview.Fields("MachineStopDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ شروع تعمیر نمی تواند قبل از تاریخ توقف دستگاه باشد.")
                aCancel = True
            ElseIf Val(MasterDataview.Fields("MachineStartDate").Value) > 0 AndAlso Val(OperatorDataview.Fields("JobStartDate").Value) > Val(MasterDataview.Fields("MachineStartDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ شروع تعمیر نمی تواند بعد از تاریخ شروع به کار دستگاه باشد.")
                aCancel = True
            ElseIf Val(OperatorDataview.Fields("JobStopDate").Value) < Val(MasterDataview.Fields("MachineStopDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ پایان تعمیر نمی تواند قبل از تاریخ توقف دستگاه باشد.")
                aCancel = True
            ElseIf Val(MasterDataview.Fields("MachineStartDate").Value) > 0 AndAlso Val(OperatorDataview.Fields("JobStopDate").Value) > Val(MasterDataview.Fields("MachineStartDate").Value) Then
                NetSql.Common.CSystem.MsgBox("تاریخ پایان تعمیر نمی تواند بعد از تاریخ شروع به کار دستگاه باشد.")
                aCancel = True
            ElseIf Val(OperatorDataview.Fields("JobStartDate").Value) = Val(MasterDataview.Fields("MachineStartDate").Value) Then
                Dim MachineStartTime As Integer = btCalendarFunction.TimeCharToInt(MasterDataview.Fields("MachineStartTime").Value)
                Dim MachineStopTime As Integer = btCalendarFunction.TimeCharToInt(MasterDataview.Fields("MachineStopTime").Value)
                Dim JobStartTime As Integer = btCalendarFunction.TimeCharToInt(OperatorDataview.Fields("JobStartTime").Value)
                Dim JobStopTime As Integer = btCalendarFunction.TimeCharToInt(OperatorDataview.Fields("JobStopTime").Value)

                If JobStartTime < btCalendarFunction.TimeCharToInt(MasterDataview.Fields("MachineStopTime").Value) Then
                    NetSql.Common.CSystem.MsgBox("زمان شروع تعمیر نمی تواند قبل از زمان توقف دستگاه باشد.")
                    aCancel = True
                ElseIf MachineStartTime > 0 AndAlso JobStartTime > MachineStartTime Then
                    NetSql.Common.CSystem.MsgBox("زمان شروع تعمیر نمی تواند بعد از زمان شروع به کار دستگاه باشد.")
                    aCancel = True
                ElseIf JobStopTime < MachineStopTime Then
                    NetSql.Common.CSystem.MsgBox("زمان پایان تعمیر نمی تواند قبل از زمان توقف دستگاه باشد.")
                    aCancel = True
                ElseIf JobStopTime > MachineStartTime Then
                    NetSql.Common.CSystem.MsgBox("زمان پایان تعمیر نمی تواند بعد از زمان شروع به کار دستگاه باشد.")
                    aCancel = True
                ElseIf JobStartTime > JobStopTime Then
                    NetSql.Common.CSystem.MsgBox("زمان شروع تعمیر نمی تواند بعد از زمان پایان تعمیر باشد.")
                    aCancel = True
                End If
            End If

        End If



    End Sub

    Private Sub LavazemDataview_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) Handles LavazemDataview.AfterCommandClick
        'If aCommand = EnumCommands.cmSave Then
        '    Dim _Key As Object = MasterDataview.FlexGrid.Row
        '    MasterDataview.Refresh()
        '    MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
        'End If
    End Sub

    Private Sub LavazemDataview_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles LavazemDataview.CommandClick
        If aCommand = EnumCommands.cmSave Then
            LavazemDataview.Fields("DarkhastRepairSN").Value = MasterDataview.Fields("DarkhastRepairSN").Value
        End If
    End Sub

#End Region

#Region "DataViewGridProperties"

    Private Sub LavazemDataview_GetGridProperties() Handles LavazemDataview.GetGridProperties
        With LavazemDataview.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub MasterDataview_GetGridProperties() Handles MasterDataview.GetGridProperties
        With MasterDataview.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub OperatorDataview_GetGridProperties() Handles OperatorDataview.GetGridProperties
        With OperatorDataview.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

#End Region

    Private Sub FrmDarkhastRepair_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ButtonGhateeDarkhast.Visible = AccessGhateeDarkhast
        ButtonGhateeKhadamat.Visible = AccessGhateeKhadamat
        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 6) + "01"
        Call InitDataView()
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        BtnNahayeeRepairDarkhast.Visible = gSM.ActionVisible("BtnNahayeeRepairDarkhast")
        BtnEbtalDarkhastRepair.Visible = gSM.ActionVisible("BtnEbtalDarkhastRepair")

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
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "ctDarkhastRepairService", "DarkhastRepairServiceSN", "DarkhastRepairServiceSN")
                '.AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "ctVw_DakhastRepair_PeigiriUser", "PeigiriUser", "PeigiriUserID")


                .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)
                .EditInGrid = True
                .AutoFetchCurrentRow = True
                .SQLWhere = If(gVahedeTejariSN = 9.935, "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.Status<>1 And ctDarkhastRepair.DarkhastRepairServiceTypeSN=1.935", "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.DarkhastRepairServiceTypeSN=1.935")
                .SQLOrderBy = "ctDarkhastRepair.Status,DarkhastRepairDate Desc,ctDarkhastRepair.VahedeTejariSN"
                .CommandVisible(EnumCommands.cmAdd) = gVahedeTejariSN <> 9.935
                .CommandVisible(EnumCommands.cmDelete) = gVahedeTejariSN <> 9.935

                With .Fields
                    With .Add("DarkhastRepairSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("KargahSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    .Add("KhateTolidSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    .Add("KalaSN", , EnumFieldOptions.foHidden).DefaultValue = 0

                    ''ghasemi 14021223
                    'If IsToolidi Then
                    '    With .Add("KargahSN->{KargahDS} As kargahSN", "DataCombo", EnumFieldOptions.foDefault)
                    '        .Caption = "کارگاه"
                    '        .ComboLateBinding = True
                    '        ComboKargah = .Component
                    '    End With
                    'Else
                    '    .Add("KargahSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    'End If

                    'If IsToolidi Then
                    '    With .Add("KhateTolidSN->{KhateTolidDS} As KhateTolidSN", "DataCombo", EnumFieldOptions.foDefault)
                    '        .Caption = "خط تولید"
                    '        .ComboLateBinding = True
                    '        ComboKhatTolid = .Component
                    '    End With
                    'Else
                    '    .Add("KhateTolidSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    'End If

                    'If IsToolidi Then
                    '    With .Add("KalaSN->paKala.{KalaNO + '- ' + KalaDS}  As KalaSN", "DataCombo", EnumFieldOptions.foDefault)
                    '        .Caption = "کد و نام دستگاه"
                    '        ComboKalaSN = .Component
                    '    End With
                    'Else
                    '    .Add("KalaSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    'End If
                    '.Add("KalaSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    'If IsToolidi Then
                    '    .Add("AmvalSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    'Else
                    '    With .Add("AmvalSN->abVw_Amval.{AmvalNo + '.' + KalaDS}  As AmvalSN", "DataCombo", EnumFieldOptions.foDefault)
                    '        .Caption = "کد و شرح اموال"
                    '        ComboAmvalSN = .Component
                    '        .ComboLateBinding = True
                    '        .MinComponentWidth = 200
                    '        .ReadOnly = gVahedeTejariSN = 9.935
                    '    End With
                    'End If

                    'With .Add("AmvalSN->abVw_Amval.{AmvalNo + '.' + KalaDS}  As AmvalSN", "DataCombo", EnumFieldOptions.foDefault)
                    '    .Caption = "کد و شرح اموال"
                    '    ComboAmvalSN = .Component
                    '    .ComboLateBinding = True
                    '    .MinComponentWidth = 200
                    '    .ReadOnly = gVahedeTejariSN = 9.935
                    'End With
                    ''ghasemi 14021223


                    With .Add("VahedeTejariSN->{paVahedeTejari.VahedeTejariDS} AS VahedeTejariSN", "DataCombo", EnumFieldOptions.foDefault)
                        .DefaultValue = gVahedeTejariSN
                        .ReadOnly = True
                        .Caption = "واحد تجاری"
                    End With

                    With .Add("AmvalSN->abVw_Amval.{AmvalNo + '.' + KalaDS}  As AmvalSN", "DataCombo", EnumFieldOptions.foDefault)
                        .Caption = "کد و شرح اموال"
                        ComboAmvalSN = .Component
                        .ComboLateBinding = True
                        .MinComponentWidth = 200
                        .ReadOnly = gVahedeTejariSN = 9.935
                    End With

                    With .Add("DarkhastRepairNo", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "شماره درخواست"
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastRepairDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ درخواست"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastRepairDS", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "شرح درخواست"
                        .MinComponentWidth = 100
                        .ReadOnly = gVahedeTejariSN = 9.935

                    End With
                    With .Add("DarkhastRepairTypeSN->{DarkhastRepairTypeDS} AS DarkhastRepairTypeSN", "DataCombo", EnumFieldOptions.foHidden)
                        .Caption = "نوع درخواست"
                        .DefaultValue = 1.935
                        .ReadOnly = gVahedeTejariSN = 9.935

                    End With
                    With .Add("DarkhastRepairServiceSN->{DarkhastRepairServiceDS} AS DarkhastRepairServiceSN", "DataCombo", EnumFieldOptions.foHidden)
                        .Caption = "بخش سرویس دهنده"
                        .ComboWhereCondition = "DarkhastRepairServiceSN In (Select DarkhastRepairServiceSN from [ctDarkhastRepairService] where [DarkhastRepairServiceTypeSN]=1.935)"
                        .RefreshCombo()
                        .ReadOnly = gVahedeTejariSN = 9.935

                    End With

                    With .Add("MachineStopDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ توقف"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .ReadOnly = gVahedeTejariSN = 9.935

                    End With
                    With .Add("MachineStopTime", "TextBox", EnumFieldOptions.foTime)
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .Caption = " زمان توقف"
                        .DataType = "TimeSpan"
                        .ReadOnly = gVahedeTejariSN = 9.935

                    End With
                    'If gVahedeTejariSN = 9.935 Then

                    With .Add("MachineStartDate", "TextBox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foDate, EnumFieldOptions.foHidden))
                        .Caption = "تاریخ شروع به کار"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .ReadOnly = IIf(gVahedeTejariSN <> 9.935, True, False)
                        '.DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    With .Add("MachineStartTime", "TextBox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foTime, EnumFieldOptions.foHidden))
                        .Caption = "زمان شروع به کار"
                        '.DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .DataType = "TimeSpan"
                    End With
                    With .Add("Cost", "Textbox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                        .Caption = "هزینه(ریال)"
                        .DataType = "Bigint"
                        .Format = "##,###"

                    End With
                    With .Add("PeigiriUser->{ctVw_DakhastRepair_PeigiriUser.PeigiriUser} As PeigiriUser", "DataCombo", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                        .Caption = "مسئول پیگیری"
                    End With
                    With .Add("FactorNo", "TextBox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                        .Caption = "شماره فاکتور"
                        .ReadOnly = IIf(gVahedeTejariSN = 9.935, False, True)
                    End With
                    'End If


                    With .Add("{[dbo].[ctFn_DarkhastRepairStatus](DarkhastRepairSN)} As StatusDS", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With

                    With .Add("Status", "TextBox", EnumFieldOptions.foHidden)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastKonande", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "درخواست کننده"
                        .DefaultValue = gSM.UserID_Name
                        .ReadOnly = True
                    End With
                    With .Add("GhateeKonandeh", "TextBox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foHidden, EnumFieldOptions.foDefault))
                        .Caption = "قطعی کننده"
                        .ReadOnly = True
                    End With
                    With .Add("GhateeDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ قطعی سازی"
                        .ReadOnly = True
                    End With
                    With .Add("NahayeeKonandeh", "TextBox", IIf(gVahedeTejariSN = 9.935, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                        .Caption = "ثبت کننده نهایی "
                        .ReadOnly = True
                    End With
                    With .Add("NahayeeDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ نهایی سازی"
                        .ReadOnly = True
                    End With
                    With .Add("DarkhastRepairServiceTypeSN", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = 1.935
                    End With
                    .Add("Tozih", "TextBox", EnumFieldOptions.foHidden).Caption = "توضیح"

                    .Add("Res1", , EnumFieldOptions.foHidden)
                    .Add("Res2", , EnumFieldOptions.foHidden)
                    .Add("Res3", , EnumFieldOptions.foHidden)

                    With .Add("UserId_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = gSM.UserID_Name
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
            OperatorDataview = New CDataView(cn)
            With OperatorDataview
                .Init(PanelOperator, , PanelOperatorcommand, PanelOperatorNavigation, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdInsert _
                                                                                Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdUpdate)

                .TableName = "ctDarkhastRepairOperator"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "ctVw_DakhastRepair_TechnicalUser", "UserID", "TechincalUserID")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")

                .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)
                .EditInGrid = True

                With .Fields
                    With .Add("DarkhastRepairOperatorSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("DarkhastRepairSN", , EnumFieldOptions.foHidden)
                    'With .Add("OperatorSN->PrVwPayPersonelForPersoneli.{PersonelCode + '- ' + Name + ' ' + Famili} As OperatorSN", "DataCombo", EnumFieldOptions.foDefault)
                    '    .Caption = "اقدام کننده"
                    '    .ComboLateBinding = True
                    '    ComboOperator = .Component
                    '    .MinComponentWidth = 200
                    'End With
                    With .Add("UserID->TechincalUser  As TechincalUserID", "DataCombo", EnumFieldOptions.foDefault)
                        '.ComboLateBinding = True
                        'dcbUser = .Component
                        .Caption = "تعمیرکار"
                    End With
                    With .Add("jobStartDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ شروع تعمیر"
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                        .ReadOnly = False
                    End With
                    With .Add("jobStartTime", "TextBox", EnumFieldOptions.foTime)
                        .Caption = "زمان شروع تعمیر"
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .DataType = "TimeSpan"
                    End With
                    With .Add("jobStopDate", "TextBox", EnumFieldOptions.foDate)
                        .Caption = "تاریخ اتمام تعمیر"
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    With .Add("jobStopTime", "TextBox", EnumFieldOptions.foTime)
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn)
                        .Caption = "زمان اتمام تعمیر"
                        .DataType = "TimeSpan"
                    End With
                    With .Add("Cost", "Textbox", EnumFieldOptions.foHidden)
                        .Caption = "هزینه(ریال)"
                        .DataType = "int"
                        .Format = "##,###"
                    End With
                    .Add("Tozih", "TextBox", EnumFieldOptions.foDefault).Caption = "توضیح"
                    With .Add("Status->{StatusDS} As Status", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With
                    .Add("OperatorSN", , EnumFieldOptions.foHidden).DefaultValue = 0
                    With .Add("SabtDate", "", EnumFieldOptions.foDate)
                        .ReadOnly = True
                        .Caption = "تاریخ ثبت"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    .Add("Rez3", , EnumFieldOptions.foHidden)
                    .Add("GhateeDate", , EnumFieldOptions.foHidden)
                    .Add("Res2", , EnumFieldOptions.foHidden)
                    With .Add("UserId_Name", , EnumFieldOptions.foDefault)
                        .DefaultValue = gSM.UserID_Name
                        .ReadOnly = True
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
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Operator", MsgBoxStyle.MsgBoxRtlReading, "")
        End Try

        Try
            LavazemDataview = New CDataView(cn)
            With LavazemDataview
                .Init(PanelLavazem, , PanelLavazemCommand, PanelLavazemNavigation, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdInsert _
                                                                                Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdUpdate)
                .TableName = "ctDarkhastRepairAccessories"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paKala", "KalaSN", "KalaSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeSanjesh", "VahedeSanjeshSN", "VahedeSanjeshSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")

                .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)
                .EditInGrid = True


                With .Fields
                    With .Add("DarkhastRepairAccessoriesSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("DarkhastRepairSN", , EnumFieldOptions.foHidden)
                    With .Add("KalaSN->paKala.{KalaNO + '- ' + KalaDS} As KalaSN", "DataCombo", EnumFieldOptions.foDefault)
                        .Caption = "کد و نام کالای مصرف شده"
                        .ComboLateBinding = True
                        .MinComponentWidth = 200
                        ComboLavazemSN = .Component
                        .ComboWhereCondition = "kalaSN In (Select KalaSN From Pakala Where mahiatKalaSn = 5.935)"
                        .RefreshCombo()
                    End With
                    With .Add("VahedeSanjeshSN->{pavahedeSanjesh.vahedesanjeshDS} As VahedeSanjeshSN", "DataCombo", EnumFieldOptions.foDefault)
                        .Caption = "واحد سنجش"
                        txtVahedSanjesh = .Component
                        .ComboLateBinding = True
                        .ReadOnly = True
                    End With
                    With .Add("Meghdar", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "مقدار"
                        .DigitGroupSymbol = ","
                        .Format = "##,###.###"
                    End With
                    With .Add("Cost", "Textbox", EnumFieldOptions.foDefault)
                        .Caption = "هزینه(ریال)"
                        .DataType = "int"
                        .Format = "##,###"
                    End With
                    With .Add("Status->{StatusDS} As Status", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "وضعیت"
                        .DefaultValue = 1
                        .ReadOnly = True
                    End With
                    .Add("Tozih", "Textbox", EnumFieldOptions.foDefault).Caption = "توضیح"
                    With .Add("SabtDate", "", EnumFieldOptions.foDate)
                        .ReadOnly = True
                        .Caption = "تاریخ ثبت"
                        .DateFormat = CShamsiDate.EnumDateFormat.dfFullYear
                        .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, CShamsiDate.EnumDateFormat.dfFullYear)
                    End With
                    .Add("Rez3", , EnumFieldOptions.foHidden)
                    .Add("GhateeDate", , EnumFieldOptions.foHidden)
                    .Add("Res2", , EnumFieldOptions.foHidden)
                    With .Add("UserId_Name", , EnumFieldOptions.foDefault)
                        .DefaultValue = gSM.UserID_Name
                        .ReadOnly = True
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
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Lavazem", MsgBoxStyle.MsgBoxRtlReading, "")
        End Try

        MasterDataview.Refresh()
    End Sub

    Private Sub MasterDataview_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) Handles MasterDataview.FillDetailsWithData

        Panel4.Enabled = True

        If aFetched Then
            Dim DarkhastSn As Decimal = CDec(MasterDataview.FieldValue("DarkhastRepairSN"))

            With OperatorDataview
                .SQLWhere = "ctDarkhastRepairOperator.DarkhastRepairSN = " & MasterDataview.FieldValue("DarkhastRepairSN")
                .Refresh()
            End With
            With LavazemDataview
                .SQLWhere = "ctDarkhastRepairAccessories.DarkhastRepairSN = " & MasterDataview.FieldValue("DarkhastRepairSN")
                .Refresh()
            End With
            ButtonGhateeKhadamat.Enabled = OperatorDataview.DataRows <> 0 AndAlso Val(OperatorDataview.FieldValue("Status")) = 1 _
                                            AndAlso Val(MasterDataview.FieldValue("Status")) = 2 AndAlso AccessGhateeKhadamat
            ButtonGhateeDarkhast.Enabled = Val(MasterDataview.FieldValue("Status")) = 1 AndAlso AccessGhateeDarkhast
            SplitContainer4.Panel2Collapsed = Val(MasterDataview.FieldValue("Status")) = 1
            If gVahedeTejariSN = 9.935 Then

                OperatorDataview.CommandEnabled(EnumCommands.cmAdd) = (OperatorDataview.DataRows = 0 Or Val(OperatorDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
                OperatorDataview.CommandEnabled(EnumCommands.cmDelete) = (OperatorDataview.DataRows = 0 Or Val(OperatorDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
                OperatorDataview.CommandEnabled(EnumCommands.cmEdit) = (OperatorDataview.DataRows = 0 Or Val(OperatorDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
                LavazemDataview.CommandEnabled(EnumCommands.cmAdd) = (LavazemDataview.DataRows = 0 Or Val(LavazemDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
                LavazemDataview.CommandEnabled(EnumCommands.cmDelete) = (LavazemDataview.DataRows = 0 Or Val(LavazemDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
                LavazemDataview.CommandEnabled(EnumCommands.cmEdit) = (LavazemDataview.DataRows = 0 Or Val(LavazemDataview.FieldValue("Status")) = 1) AndAlso Val(MasterDataview.FieldValue("Status")) = 2
            Else
                OperatorDataview.CommandEnabled(EnumCommands.cmAdd) = False
                OperatorDataview.CommandEnabled(EnumCommands.cmDelete) = False
                OperatorDataview.CommandEnabled(EnumCommands.cmEdit) = False
                LavazemDataview.CommandEnabled(EnumCommands.cmAdd) = False
                LavazemDataview.CommandEnabled(EnumCommands.cmDelete) = False
                LavazemDataview.CommandEnabled(EnumCommands.cmEdit) = False
                Panel4.Enabled = False
            End If

                MasterDataview.CommandEnabled(EnumCommands.cmEdit) = Val(MasterDataview.FieldValue("Status")) <> 7 AndAlso (Val(MasterDataview.FieldValue("Status")) = 1 OrElse gVahedeTejariSN = 9.935)
                MasterDataview.CommandEnabled(EnumCommands.cmDelete) = Val(MasterDataview.FieldValue("Status")) = 1
                BtnNahayeeRepairDarkhast.Enabled = AccessGhateeKhadamat AndAlso Not ButtonGhateeDarkhast.Enabled _
                AndAlso Val(MasterDataview.FieldValue("Status")) <> 7 AndAlso Val(MasterDataview.FieldValue("Status")) <> 3 _
               AndAlso (Val(OperatorDataview.FieldValue("Status")) = 2 OrElse OperatorDataview.DataRows = 0) _
              AndAlso (Val(LavazemDataview.FieldValue("Status")) = 2 OrElse LavazemDataview.DataRows = 0)


                BtnEbtalDarkhastRepair.Enabled = BtnNahayeeRepairDarkhast.Enabled
                RichTextBox1.ReadOnly = Val(MasterDataview.FieldValue("Status")) = 7 Or Not AccessGhateeKhadamat
                RichTextBox1.Text = MasterDataview.FieldText("Tozih")
            Else
                With OperatorDataview
                .SQLWhere = "ctDarkhastRepairOperator.DarkhastRepairSN = 0"
                .Refresh()
            End With
            With LavazemDataview
                .SQLWhere = "ctDarkhastRepairAccessories.DarkhastRepairSN =0 "
                .Refresh()
            End With
            Panel4.Enabled = False

        End If

    End Sub

    Private Sub ButtonGhateeDarkhast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGhateeDarkhast.Click

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
                NetSql.Common.CSystem.MsgBox("خطا در قطعی سازی درخواست : " + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "")
            End Try
        End If

    End Sub

    Private Sub ButtonGhateeKhadamat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGhateeKhadamat.Click

        If LavazemDataview.DataRows = 0 Then
            If NetSql.Common.CSystem.MsgBox("لوازم مصرفی برای درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " ثبت نشده است" + vbCr +
                                            "آیا مایل به قطعی سازی خدمات (نیروی انسانی و لوازم مصرفی) ثبت شده می باشید ؟ ", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If NetSql.Common.CSystem.MsgBox("آیا مایل به قطعی سازی خدمات (نیروی انسانی و لوازم مصرفی) ثبت شده برای درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " می باشید ؟ ", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Object = MasterDataview.FlexGrid.Row
            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "GhateeKhadamat", DBNull.Value, gSM.UserID_Name)
                MasterDataview.Refresh()
                MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در قطعی سازی خدمات" + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "")
            End Try
        End If

    End Sub

    Private Sub ButtonTozih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNahayeeRepairDarkhast.Click

        If RichTextBox1.Text.Trim = "" Then
            If NetSql.Common.CSystem.MsgBox("گزارش عملیات برای درخواست شماره  " & MasterDataview.FieldText("DarkhastRepairNO") & " ثبت نشده است.آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If NetSql.Common.CSystem.MsgBox("توجه داشته باشید با ثبت گزارش عملیات درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " نهایی خواهد شد و شما مجوز ویرایش آن را نخواهید داشت." _
                                            + vbCr + "آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim wfrm As New Common.Frmwait
        wfrm.Label3.Text = "...سیستم در حال نهایی سازی و انتقال اطلاعات به <" + MasterDataview.FieldText("VahedeTejariSN") + "> می باشد..."
        wfrm.Show()
        wfrm.Refresh()


        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Integer = MasterDataview.FlexGrid.Row

            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "finish", RichTextBox1.Text.ToString, gSM.UserID_Name)
                If gVahedeTejariSN = 9.935 Then
                    Dim DvServer As New DataView
                    Dim ServerName As String = cn.SQLServerName
                    Dim DatabaseName As String = cn.SQLDatabaseName
                    Dim VahedeTejariSN As Decimal = gVahedeTejariSN

                    DvServer = cn.ExecuteQuery("Select Top 1 * from [abFn_getServerDbOfApplication](" & CDec(MasterDataview.FieldValue("VahedeTejariSN")) & ")  Order by Tartib")
                    If DvServer.Count = 1 Then
                        ServerName = DvServer(0)("ServerName").ToString
                        DatabaseName = DvServer(0)("DatabaseName").ToString
                        VahedeTejariSN = CDec(MasterDataview.FieldValue("VahedeTejariSN"))
                    Else
                        CSystem.MsgBox("مشخصه سرور برای شعبه مقصد یافت نشد", MsgBoxStyle.Exclamation, "")
                        Exit Try
                    End If

                    Dim Str As String = ""
                    Dim AnbarRule As New ClsDataAccessRule

                    Try
                        Dim DvAccessories As DataView = cn.ExecuteQuery("Select  *from ctDarkhastRepairAccessories  where DarkhastRepairSN=" & MasterDataview.FieldValue("DarkhastRepairSN").ToString)
                        Dim DvOperator As DataView = cn.ExecuteQuery("Select  * from ctDarkhastRepairOperator  where DarkhastRepairSN=" & MasterDataview.FieldValue("DarkhastRepairSN").ToString)

                        Str = AnbarRule.DarkhastRepair_NahayeeDarkhast(VahedeTejariSN, ServerName, DatabaseName, gSM.UserID_Name, CDec(MasterDataview.FieldValue("DarkhastRepairSN")), RichTextBox1.Text.Trim, DvAccessories, DvOperator, gSM.UserID, gSM.UserID_Name, cn)
                        MasterDataview.Refresh()
                        MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
                        NetSql.Common.CSystem.MsgBox(" عملیات نهایی سازی درخواست با موفقیت انجام گردید.", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Information, "نهایی سازی درخواست")

                    Catch ex As Exception
                        CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "نهایی سازی درخواست")
                        cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "GhateeDarkhast", DBNull.Value, gSM.UserID_Name)

                    End Try
                End If

            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در ثبت گزارش عملیات" + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "")
            Finally
                wfrm.Close()
            End Try
            MasterDataview.Refresh()
        End If

    End Sub


    Private Sub BynEbtalDarkhast_Click(sender As Object, e As EventArgs) Handles BtnEbtalDarkhastRepair.Click
        If MasterDataview.Fields("Status").Value = 3 Then
            CSystem.MsgBox("وضعیت درخواست ابطال است و ابطال مجدد امکان پذیر نیست", MsgBoxStyle.Exclamation, "")
            Exit Sub
        ElseIf MasterDataview.Fields("Status").Value = 7 Then
            CSystem.MsgBox("وضعیت درخواست نهایی است و ابطال امکان پذیر نیست", MsgBoxStyle.Exclamation, "")
            Exit Sub
        ElseIf RichTextBox1.Text.Trim = "" Then
            CSystem.MsgBox("علت ابطال می بایست ثبت شود", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("توجه داشته باشید با ادامه عملیات درخواست شماره " & MasterDataview.FieldText("DarkhastRepairNo") & " ابطال خواهد شد " _
                                                + vbCr + "آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
            Exit Sub
        End If


        If Not MasterDataview.FieldValue("DarkhastRepairSN") Is Nothing AndAlso MasterDataview.FieldValue("DarkhastRepairSN") <> "" Then
            Dim _Key As Integer = MasterDataview.FlexGrid.Row
            Try
                cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "Ebtal", RichTextBox1.Text.ToString, gSM.UserID_Name)
                Try
                    If gVahedeTejariSN = 9.935 Then
                        Dim DvServer As New DataView
                        Dim ServerName As String = cn.SQLServerName
                        Dim DatabaseName As String = cn.SQLDatabaseName
                        Dim VahedeTejariSN As Decimal = gVahedeTejariSN

                        DvServer = cn.ExecuteQuery("Select Top 1 * from [abFn_getServerDbOfApplication](" & CDec(MasterDataview.FieldValue("VahedeTejariSN")) & ")  Order by Tartib")
                        If DvServer.Count = 1 Then
                            ServerName = DvServer(0)("ServerName").ToString
                            DatabaseName = DvServer(0)("DatabaseName").ToString
                            VahedeTejariSN = CDec(MasterDataview.FieldValue("VahedeTejariSN"))
                        Else
                            CSystem.MsgBox("مشخصه سرور برای شعبه مقصد یافت نشد", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "")
                            Exit Try
                        End If

                        Dim Str As String = ""
                        Dim AnbarRule As New ClsDataAccessRule

                        Try
                            Str = AnbarRule.DarkhastRepair_EbtalDarkhast(VahedeTejariSN, ServerName, DatabaseName, gSM.UserID_Name, CDec(MasterDataview.FieldValue("DarkhastRepairSN")), RichTextBox1.Text.Trim, gSM.UserID, gSM.UserID_Name, cn)
                            MasterDataview.Refresh()
                            MasterDataview.FlexGrid.Select(_Key, 1, Nothing, Nothing)
                            NetSql.Common.CSystem.MsgBox(" عملیات ابطال درخواست با موفقیت انجام گردید.", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Information, "ابطال درخواست")
                        Catch ex As Exception
                            CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ابطال درخواست")
                            cn.CallSP("_ctSpG_ChangeDarkhastRepairStatus", CDec(MasterDataview.FieldValue("DarkhastRepairSN")), "GhateeDarkhast", DBNull.Value, gSM.UserID_Name)
                        End Try
                    End If

                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("خطا در ابطال درخواست" + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "")
                End Try

            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در ابطال درخواست" + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "")
            End Try

        End If
    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        Dim sql As String = "delete ctDarkhastRepair; " &
    '            vbNewLine &
    '"insert into ctDarkhastRepair(" &
    '"[DarkhastRepairSN],[KargahSN],[KhateTolidSN]" &
    '",[KalaSN],[DarkhastRepairNo],[DarkhastRepairDate],[DarkhastRepairDS],[DarkhastRepairTypeSN],[DarkhastRepairServiceSN]" &
    '",[MachineStopDate],[MachineStopTime],[MachineStartDate],[MachineStartTime],[DarkhastKonande]" &
    '",[Tozih],[Status],[GhateeKonandeh],[NahayeeKonandeh],[UserID_Name],[Host_Name],[RecChksum]" &
    '",[AmvalSN],[VahedeTejariSN],[Cost],[Res1],[Res2],[Res3],[DarkhastRepairServiceTypeSN],[GhateeDate])" &
    ' vbNewLine &
    '"select [DarkhastRepairSN],[KargahSN],[KhateTolidSN],[KalaSN],[DarkhastRepairNo],[DarkhastRepairDate]" &
    '",[DarkhastRepairDS],[DarkhastRepairTypeSN],[DarkhastRepairServiceSN],[MachineStopDate],[MachineStopTime],[MachineStartDate],[MachineStartTime]" &
    '",[DarkhastKonande],[Tozih],[Status],[GhateeKonandeh],[NahayeeKonandeh],[UserID_Name],[Host_Name]" &
    '",[RecChksum],[AmvalSN],[VahedeTejariSN],[Cost],[Res1],[Res2],[Res3]" &
    '",[DarkhastRepairServiceTypeSN] ,[GhateeDate] from tehdaroo.mis.dbo.ctdarkhastrepair"

    '        cn.ExecuteNoneQuery(sql)
    '        MasterDataview.Refresh()
    '    End Sub

    Private Sub BtnFilterTarikh_Click(sender As Object, e As EventArgs) Handles BtnFilterTarikh.Click
        With MasterDataview
            .SQLWhere = If(gVahedeTejariSN = 9.935, "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.Status<>1 And ctDarkhastRepair.DarkhastRepairServiceTypeSN=1.935", "ctDarkhastRepair.DarkhastRepairDate>=" & TxtFromDate.Text.Replace("/", "") & " And ctDarkhastRepair.DarkhastRepairServiceTypeSN=1.935")
            .Refresh()
        End With
    End Sub
End Class
