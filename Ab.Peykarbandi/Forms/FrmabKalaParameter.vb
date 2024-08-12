
Imports System.Data
Imports Anbar.BRL
Imports Janus.Windows.GridEX

Public Class FrmabKalaParameter
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

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabKalaParameter
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabKalaParameter

        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabKalaParameter
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get

        Set(ByVal Value As FrmabKalaParameter)
            m_vb6FormDefInstance = Value
        End Set

    End Property

#End Region

    Private components As System.ComponentModel.IContainer
    Friend WithEvents SplitContainerKala As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainerDarkhastParamter As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GridTamin As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PnlErsalKalaParamCom As Panel
    Friend WithEvents PnlErsalKalaParamNav As Panel
    Friend WithEvents PnlErsalKalaParam As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PnlabKalaParamVahedTejariCom As Panel
    Friend WithEvents PnlabKalaParamVahedTejari As Panel
    Friend WithEvents BtnInsertZaribDaftar As Button
    Friend WithEvents BtnGHatee As Button
    Friend WithEvents SplitContainerKOl As SplitContainer

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabKalaParameter))
        Me.SplitContainerKOl = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridTamin = New Janus.Windows.GridEX.GridEX()
        Me.SplitContainerKala = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerDarkhastParamter = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PnlErsalKalaParamCom = New System.Windows.Forms.Panel()
        Me.PnlErsalKalaParamNav = New System.Windows.Forms.Panel()
        Me.PnlErsalKalaParam = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnGHatee = New System.Windows.Forms.Button()
        Me.BtnInsertZaribDaftar = New System.Windows.Forms.Button()
        Me.PnlabKalaParamVahedTejariCom = New System.Windows.Forms.Panel()
        Me.PnlabKalaParamVahedTejari = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainerKOl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerKOl.Panel1.SuspendLayout()
        Me.SplitContainerKOl.Panel2.SuspendLayout()
        Me.SplitContainerKOl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridTamin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerKala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerKala.Panel2.SuspendLayout()
        Me.SplitContainerKala.SuspendLayout()
        CType(Me.SplitContainerDarkhastParamter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerDarkhastParamter.Panel1.SuspendLayout()
        Me.SplitContainerDarkhastParamter.Panel2.SuspendLayout()
        Me.SplitContainerDarkhastParamter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerKOl
        '
        Me.SplitContainerKOl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerKOl.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerKOl.Name = "SplitContainerKOl"
        Me.SplitContainerKOl.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerKOl.Panel1
        '
        Me.SplitContainerKOl.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerKOl.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainerKOl.Panel2
        '
        Me.SplitContainerKOl.Panel2.Controls.Add(Me.SplitContainerKala)
        Me.SplitContainerKOl.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainerKOl.Size = New System.Drawing.Size(1258, 570)
        Me.SplitContainerKOl.SplitterDistance = 165
        Me.SplitContainerKOl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 165)
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
        Me.TabControl1.Size = New System.Drawing.Size(1258, 165)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridTamin)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1250, 138)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "تامین کننده"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridTamin
        '
        Me.GridTamin.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>برای گ" &
    "روه بندی ستون مورد نظر را در اینجا قرار دهید</GroupByBoxInfo></LocalizableData>"
        GridTamin_DesignTimeLayout.LayoutString = resources.GetString("GridTamin_DesignTimeLayout.LayoutString")
        Me.GridTamin.DesignTimeLayout = GridTamin_DesignTimeLayout
        Me.GridTamin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTamin.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridTamin.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridTamin.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridTamin.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridTamin.GroupByBoxVisible = False
        Me.GridTamin.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.GridTamin.HeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTamin.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTamin.Location = New System.Drawing.Point(3, 3)
        Me.GridTamin.Name = "GridTamin"
        Me.GridTamin.RecordNavigator = True
        Me.GridTamin.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridTamin.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridTamin.Size = New System.Drawing.Size(1244, 132)
        Me.GridTamin.TabIndex = 3
        Me.GridTamin.TotalRowFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTamin.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainerKala
        '
        Me.SplitContainerKala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerKala.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerKala.Name = "SplitContainerKala"
        '
        'SplitContainerKala.Panel1
        '
        Me.SplitContainerKala.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainerKala.Panel1Collapsed = True
        '
        'SplitContainerKala.Panel2
        '
        Me.SplitContainerKala.Panel2.Controls.Add(Me.SplitContainerDarkhastParamter)
        Me.SplitContainerKala.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainerKala.Size = New System.Drawing.Size(1258, 401)
        Me.SplitContainerKala.SplitterDistance = 362
        Me.SplitContainerKala.TabIndex = 0
        '
        'SplitContainerDarkhastParamter
        '
        Me.SplitContainerDarkhastParamter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerDarkhastParamter.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerDarkhastParamter.Name = "SplitContainerDarkhastParamter"
        '
        'SplitContainerDarkhastParamter.Panel1
        '
        Me.SplitContainerDarkhastParamter.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainerDarkhastParamter.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainerDarkhastParamter.Panel2
        '
        Me.SplitContainerDarkhastParamter.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainerDarkhastParamter.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainerDarkhastParamter.Panel2Collapsed = True
        Me.SplitContainerDarkhastParamter.Size = New System.Drawing.Size(1258, 401)
        Me.SplitContainerDarkhastParamter.SplitterDistance = 475
        Me.SplitContainerDarkhastParamter.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1258, 401)
        Me.Panel3.TabIndex = 1
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1258, 401)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.TabControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1258, 215)
        Me.Panel2.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.RightToLeftLayout = True
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1258, 215)
        Me.TabControl3.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1250, 188)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "پارامتر "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.PnlErsalKalaParamCom)
        Me.Panel7.Controls.Add(Me.PnlErsalKalaParamNav)
        Me.Panel7.Controls.Add(Me.PnlErsalKalaParam)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1244, 182)
        Me.Panel7.TabIndex = 0
        '
        'PnlErsalKalaParamCom
        '
        Me.PnlErsalKalaParamCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlErsalKalaParamCom.Location = New System.Drawing.Point(908, 137)
        Me.PnlErsalKalaParamCom.Name = "PnlErsalKalaParamCom"
        Me.PnlErsalKalaParamCom.Size = New System.Drawing.Size(331, 40)
        Me.PnlErsalKalaParamCom.TabIndex = 3
        '
        'PnlErsalKalaParamNav
        '
        Me.PnlErsalKalaParamNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlErsalKalaParamNav.Location = New System.Drawing.Point(5, 137)
        Me.PnlErsalKalaParamNav.Name = "PnlErsalKalaParamNav"
        Me.PnlErsalKalaParamNav.Size = New System.Drawing.Size(239, 40)
        Me.PnlErsalKalaParamNav.TabIndex = 4
        '
        'PnlErsalKalaParam
        '
        Me.PnlErsalKalaParam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlErsalKalaParam.Location = New System.Drawing.Point(3, 4)
        Me.PnlErsalKalaParam.Name = "PnlErsalKalaParam"
        Me.PnlErsalKalaParam.Size = New System.Drawing.Size(1238, 130)
        Me.PnlErsalKalaParam.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.TabControl2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1258, 182)
        Me.Panel5.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1258, 182)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1250, 155)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "تنظیمات شعبه و دفتر فروش"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.BtnGHatee)
        Me.Panel6.Controls.Add(Me.BtnInsertZaribDaftar)
        Me.Panel6.Controls.Add(Me.PnlabKalaParamVahedTejariCom)
        Me.Panel6.Controls.Add(Me.PnlabKalaParamVahedTejari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1244, 149)
        Me.Panel6.TabIndex = 0
        '
        'BtnGHatee
        '
        Me.BtnGHatee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGHatee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGHatee.Location = New System.Drawing.Point(510, 104)
        Me.BtnGHatee.Name = "BtnGHatee"
        Me.BtnGHatee.Size = New System.Drawing.Size(177, 39)
        Me.BtnGHatee.TabIndex = 239
        Me.BtnGHatee.Text = "قطعی"
        Me.BtnGHatee.UseVisualStyleBackColor = False
        '
        'BtnInsertZaribDaftar
        '
        Me.BtnInsertZaribDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInsertZaribDaftar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnInsertZaribDaftar.Location = New System.Drawing.Point(693, 104)
        Me.BtnInsertZaribDaftar.Name = "BtnInsertZaribDaftar"
        Me.BtnInsertZaribDaftar.Size = New System.Drawing.Size(177, 39)
        Me.BtnInsertZaribDaftar.TabIndex = 238
        Me.BtnInsertZaribDaftar.Text = "درج اولیه ضرایب دفاتر فروش"
        Me.BtnInsertZaribDaftar.UseVisualStyleBackColor = False
        Me.BtnInsertZaribDaftar.Visible = False
        '
        'PnlabKalaParamVahedTejariCom
        '
        Me.PnlabKalaParamVahedTejariCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlabKalaParamVahedTejariCom.Location = New System.Drawing.Point(876, 104)
        Me.PnlabKalaParamVahedTejariCom.Name = "PnlabKalaParamVahedTejariCom"
        Me.PnlabKalaParamVahedTejariCom.Size = New System.Drawing.Size(363, 40)
        Me.PnlabKalaParamVahedTejariCom.TabIndex = 3
        '
        'PnlabKalaParamVahedTejari
        '
        Me.PnlabKalaParamVahedTejari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlabKalaParamVahedTejari.Location = New System.Drawing.Point(3, 4)
        Me.PnlabKalaParamVahedTejari.Name = "PnlabKalaParamVahedTejari"
        Me.PnlabKalaParamVahedTejari.Size = New System.Drawing.Size(1238, 97)
        Me.PnlabKalaParamVahedTejari.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(96, 100)
        Me.Panel4.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 50
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 5
        '
        'FrmabKalaParameter
        '
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1258, 570)
        Me.Controls.Add(Me.SplitContainerKOl)
        Me.Name = "FrmabKalaParameter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "پارامترهای محصول"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainerKOl.Panel1.ResumeLayout(False)
        Me.SplitContainerKOl.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerKOl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerKOl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridTamin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerKala.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerKala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerKala.ResumeLayout(False)
        Me.SplitContainerDarkhastParamter.Panel1.ResumeLayout(False)
        Me.SplitContainerDarkhastParamter.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerDarkhastParamter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerDarkhastParamter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DvKalaParameter As NetSql.View.CDataView
    Private WithEvents DvKalaParameterVahedTejari As NetSql.View.CDataView
    Dim Frule As New ClsDataAccessRule
    Private WithEvents dbcDaftarForoosh As NetSql.Components.DataCombo



    Private Sub FrmbtDarkhastKalaParamter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            Dim AccessabKalaParameter As String = If(gSM.ActionEnabled("AccessabKalaParameterDaroo"), "NoeVahedeTejariSN In (14.935,16.935)", "")
            AccessabKalaParameter = If(gSM.ActionEnabled("AccessabKalaParameterGhaza"), "NoeVahedeTejariSN Not In (14.935,16.935)", AccessabKalaParameter)
            AccessabKalaParameter = If(gSM.ActionEnabled("AccessabKalaParameterGhaza") And gSM.ActionEnabled("AccessabKalaParameterDaroo"), "", AccessabKalaParameter)


            Dim Dv As DataView = New DataView(Frule.GetListTaminKonandegan(cn).ToTable, AccessabKalaParameter, "", DataViewRowState.CurrentRows).ToTable.DefaultView



            If Dv Is Nothing OrElse Dv.Count = 0 Then
                CSystem.MsgBox("خطا در دریافت اطلاعات تامین کنندگان", MsgBoxStyle.Exclamation, "")
                SplitContainerKOl.Enabled = False
                Exit Sub
            Else
                GridTamin.DataSource = Dv
                'GridTamin.AutoSizeColumns()
                GridTamin.Refresh()
            End If

            SplitContainer1.Panel2Collapsed = Not gSM.ActionEnabled("AccessForTashimKalaOnDaftarforoosh")

            Try
                DvKalaParameter = New NetSql.View.CDataView(cn)

                With DvKalaParameter
                    .Init(PnlErsalKalaParam, , PnlErsalKalaParamCom, PnlErsalKalaParamNav, CType(EnumButtonOptions.boCmdInsert + EnumButtonOptions.boCmdUpdate _
                          + EnumButtonOptions.boCmdFilter + EnumButtonOptions.boCmdRefresh, EnumButtonOptions))
                    .TableName = "abKalaParameter"
                    .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paKala", "KalaSN", "KalaSN")
                    .AccessRight = EnumAccessRight.arAll
                    .EditInGrid = True
                    If gVahedeTejariSN <> 1.935 Then
                        .CommandEnabled(EnumCommands.cmAdd) = False
                        .CommandEnabled(EnumCommands.cmEdit) = False
                        .CommandEnabled(EnumCommands.cmDelete) = False
                    End If
                    With .Fields
                        With .Add("KalaParameterSN", , gSNFieldOption)
                            .DefaultValue = gSM.Identifier
                        End With
                        With .Add("KalaSN->{KalaNo + '. ' + KalaDS} As KalaSN", "DataCombo")
                            .Caption = "نام کالا"
                            .ComboWhereCondition = "1=0"
                            .RefreshCombo()
                        End With
                        With .Add("IsUID_UsedInSanad", "CheckBox", If(gSM.ActionEnabled("AccessabKalaParameterDaroo"), EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                            .Caption = "لزوم ثبت  UID در سند انبار"
                            .DataType = "boolean"
                            .DefaultValue = 0
                        End With
                        With .Add("RezB1", "CheckBox", If(gSM.ActionEnabled("AccessabKalaParameterDaroo"), EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                            .Caption = "مغایرت تعداد در بسته چک نشود"
                            .DataType = "boolean"
                            .DefaultValue = 0
                        End With
                        With .Add("RezInt1", "CheckBox", If(gSM.ActionEnabled("AccessabKalaParameterGhaza"), EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                            .Caption = "مجوز ثبت رسید روی کد 2 محصولات"
                            .DataType = "boolean"
                            .DefaultValue = 0
                        End With
                        With .Add("RezInt2", "CheckBox", If(gSM.ActionEnabled("AccessabKalaParameterDaroo"), EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                            .Caption = "محصولات دارویی بدون نیاز به ثبت بارکدخوان"
                            .DataType = "boolean"
                            .DefaultValue = 0
                        End With
                        With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                            .DefaultValue = gSM.UserName
                        End With
                        With .Add("Host_Name", , EnumFieldOptions.foHidden)
                            .DefaultValue = System.Windows.Forms.SystemInformation.ComputerName
                        End With
                        With .Add("RecChksum", , EnumFieldOptions.foHidden)
                        End With
                    End With
                End With

            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در لود پنل پارامترهای کالا", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
            End Try

            Try
                DvKalaParameterVahedTejari = New NetSql.View.CDataView(cn)

                With DvKalaParameterVahedTejari
                    .Init(PnlabKalaParamVahedTejari, , PnlabKalaParamVahedTejariCom, , CType(EnumButtonOptions.boCmdInsert + EnumButtonOptions.boCmdDelete + EnumButtonOptions.boCmdUpdate _
                          + EnumButtonOptions.boCmdFilter + EnumButtonOptions.boCmdRefresh, EnumButtonOptions))
                    .TableName = "abKalaParameterVahedeTejari"
                    .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeTejari", "VahedeTejariSN", "VahedeTejariSN")
                    .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paDaftarForoosh", "DaftarForooshSN", "DaftarForooshSN")
                    .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "btStatus", "Status", "StatusSN")

                    .AccessRight = EnumAccessRight.arAll
                    .EditInGrid = True
                    If gVahedeTejariSN <> 1.935 Then
                        .CommandEnabled(EnumCommands.cmAdd) = False
                        .CommandEnabled(EnumCommands.cmEdit) = False
                        .CommandEnabled(EnumCommands.cmDelete) = False
                    End If
                    .SQLWhere = "1=0"
                    .SQLOrderBy = "KalaParameterSN,DateSabt Desc,Status"
                    '.AutoFetchCurrentRow = True
                    With .Fields
                        With .Add("KalaParameterVahedeTejariSN", , gSNFieldOption)
                            .DefaultValue = gSM.Identifier
                        End With
                        With .Add("KalaParameterSN", , EnumFieldOptions.foHidden)
                        End With

                        With .Add("VahedeTejariSN->{VahedeTejariDS} As VahedeTejariSN", "DataCombo", EnumFieldOptions.foDefault)
                            .Caption = "شعبه"
                            .ComboWhereCondition = "paVahedeTejari.VahedeTejariSN In (Select VahedeTejariSN from imAppSetting where AppParamSN=209.935 and Value='1')"
                            .RefreshCombo()
                        End With
                        With .Add("DaftarForooshSN->{DaftarForooshDS} As DaftarForooshSN", "DataCombo", EnumFieldOptions.foDefault)
                            .Caption = "دفتر فروش"
                            dbcDaftarForoosh = .Component
                            dbcDaftarForoosh.LateBinding = True
                            .RefreshCombo()
                        End With

                        With .Add("ZaribTakhsisKala", "Textbox", EnumFieldOptions.foDefault)
                            .Caption = "ضریب تخصیص"
                            .DataType = "double"
                        End With
                        With .Add("DateSabt", "Textbox", EnumFieldOptions.foDate)
                            .Caption = "تاریخ ثبت"
                            .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                            .ReadOnly = True
                        End With
                        With .Add("Status->{StatusDS} As Status", "Datacombo", EnumFieldOptions.foDefault)
                            .Caption = "وضعیت"
                            .ReadOnly = True
                            .DefaultValue = 1
                        End With
                        With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                            .DefaultValue = gSM.UserName
                        End With
                        With .Add("Host_Name", , EnumFieldOptions.foHidden)
                            .DefaultValue = System.Windows.Forms.SystemInformation.ComputerName
                        End With
                        With .Add("RecChksum", , EnumFieldOptions.foHidden)
                        End With
                    End With
                End With

            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در لود پنل پارامترهای کالا شعبه", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
            End Try
        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
        End Try

        DvKalaParameter.Refresh()
    End Sub


    Private Sub DvDarkhastKalaParameter_GetGridProperties() Handles DvKalaParameter.GetGridProperties
        With DvKalaParameter.FlexGrid
            .SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub DvKalaVarehMojaz_GetGridProperties() Handles DvKalaParameterVahedTejari.GetGridProperties
        With DvKalaParameterVahedTejari.FlexGrid
            .SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub GridTamin_SelectionChanged(sender As Object, e As EventArgs) Handles GridTamin.SelectionChanged
        If Not IsNothing(GridTamin.CurrentRow) AndAlso IsNumeric(GridTamin.CurrentRow.Cells("TaminKonandehSN").Value) AndAlso Not DvKalaParameter Is Nothing Then
            DvKalaParameter.SQLWhere = "abKalaParameter.KalaSN IN (Select KalaSN From PakalaTamin Where VahedeTejariSN=" & GridTamin.CurrentRow.Cells("TaminKonandehSN").Text & ")"
            DvKalaParameter.Refresh()
        End If
    End Sub

    Private Sub DvDarkhastKalaParameter_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DvKalaParameter.CommandClick
        If aCommand = EnumCommands.cmAdd Or aCommand = EnumCommands.cmEdit Then
            DvKalaParameter.Fields("KalaSN").ComboWhereCondition = "KalaSN IN (Select KalaSn From PakalaTamin Where VahedeTejariSN = " & GridTamin.CurrentRow.Cells("TaminKonandehSN").Text & ") " &
                "And KalaSN Not In (Select KalaSn from abKalaParameter)"
            DvKalaParameter.Fields("KalaSN").RefreshCombo()
        End If
    End Sub


    Private Sub GridTamin_LinkClicked(sender As Object, e As ColumnActionEventArgs) Handles GridTamin.LinkClicked

        'If GridTamin.CurrentColumn.Key = "DoTashim" Then
        '    If CSystem.MsgBox("آیا مایلید درصد تسهیم تمامی کالاهای " + vbCr + "< " + GridTamin.CurrentRow.Cells("TaminKonandehDS").Text + ">" + vbCr +
        '                  "به " + GridTamin.CurrentRow.Cells("DarsadTashim").Text + " درصد تبدیل شود؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    cn.ExecuteNoneQuery("Update btKalaDarkhastParameter Set DarsadMojazAzVaredeh = " & CDec(GridTamin.CurrentRow.Cells("DarsadTashim").Value) & " From btKalaDarkhastParameter Join pakalaTamin On PakalaTamin.KalaSN = btKalaDarkhastParameter.KalaSN Where VahedeTejariSN = " & GridTamin.CurrentRow.Cells("TaminKonandehSN").Text)
        '    DvKalaParameter.Refresh()
        'ElseIf GridTamin.CurrentColumn.Key = "doMinMojoodi" Then
        '    If CSystem.MsgBox("آیا مایلید پارامتر ماندگاری تمامی کالاهای شرکت " + vbCr + "< " + GridTamin.CurrentRow.Cells("TaminKonandehDS").Text + ">" + vbCr +
        '                  "به " + GridTamin.CurrentRow.Cells("MinMojoodi").Text + " روز تبدیل شود؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    cn.ExecuteNoneQuery("Update btKalaDarkhastParameter Set Rez1 = " & CDec(GridTamin.CurrentRow.Cells("MinMojoodi").Value) & " From btKalaDarkhastParameter Join pakalaTamin On PakalaTamin.KalaSN = btKalaDarkhastParameter.KalaSN Where VahedeTejariSN = " & GridTamin.CurrentRow.Cells("TaminKonandehSN").Text)
        '    DvKalaParameter.Refresh()
        'ElseIf GridTamin.CurrentColumn.Key = "DoMojazForSefareshGozariShoab" Then
        '    Dim IsSefareshMojazForTaminkonandeh As Integer = GridTamin.CurrentRow.Cells("IsMojazForSefareshGozariShoab").Value
        '    If CSystem.MsgBox("آیا مایلید قابلیت سفارش گذاری شعب به واحد تامین کالا روی تمامی کالاهای شرکت " + vbCr + "< " + GridTamin.CurrentRow.Cells("TaminKonandehDS").Text + ">" + If(IsSefareshMojazForTaminkonandeh, "فعال", "غیر فعال") + " گردد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    cn.ExecuteNoneQuery("Update btKalaDarkhastParameter Set Rez2 = " & IsSefareshMojazForTaminkonandeh.ToString & " From btKalaDarkhastParameter Join pakalaTamin On PakalaTamin.KalaSN = btKalaDarkhastParameter.KalaSN Where VahedeTejariSN = " & GridTamin.CurrentRow.Cells("TaminKonandehSN").Text)
        '    DvKalaParameter.Refresh()
        'End If
    End Sub

    Private Sub GridTamin_MouseClick(sender As Object, e As MouseEventArgs) Handles GridTamin.MouseClick
        'If IsNothing(GridTamin.CurrentColumn) Then
        '    Exit Sub
        'End If
        'If GridTamin.CurrentRow.RowType = RowType.Record AndAlso "TAMINKONANDEHDS,NOEVAHEDETEJARIDS".Contains(GridTamin.CurrentColumn.Key.ToUpper) Then
        '    GridTamin.CurrentColumn.EditType = EditType.NoEdit
        'ElseIf GridTamin.CurrentColumn.Key.ToUpper = "IsMojazForSefareshGozariShoab".ToUpper Then
        '    GridTamin.CurrentColumn.EditType = EditType.CheckBox

        'Else

        '    GridTamin.CurrentColumn.EditType = EditType.TextBox
        'End If
    End Sub

    Private Sub DvKalaParamterVahedTejari_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DvKalaParameterVahedTejari.CommandClick
        DvKalaParameterVahedTejari.Fields("VahedeTejariSN").ReadOnly = False
        If aCommand = EnumCommands.cmAdd Then
            DvKalaParameterVahedTejari.Fields("KalaParameterSN").DefaultValue = DvKalaParameter.FieldValue("KalaParameterSN")
        ElseIf aCommand = EnumCommands.cmEdit Then
            DvKalaParameterVahedTejari.Fields("VahedeTejariSN").ReadOnly = True

        End If
    End Sub

    Private Sub DvKalaParameter_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DvKalaParameter.FillDetailsWithData
        DvKalaParameterVahedTejari.SQLWhere = "1=0"
        If aFetched Then
            DvKalaParameterVahedTejari.SQLWhere = "abKalaParameterVahedeTejari.KalaParameterSN=" & DvKalaParameter.FieldValue("KalaParameterSN").ToString
        End If
        DvKalaParameterVahedTejari.Refresh()
    End Sub

    Private Sub dbcDaftarForoosh_GotFocus(sender As Object, e As EventArgs) Handles dbcDaftarForoosh.GotFocus
        If DvKalaParameterVahedTejari.EditStarted Then
            If IsNumeric(DvKalaParameterVahedTejari.FieldValue("VahedeTejariSN")) Then
                DvKalaParameterVahedTejari.Fields("DaftarForooshSN").ComboWhereCondition = "DaftarForooshSN In (Select DaftarForooshSN from paDaftarForoosh Where VahedeTejariSN=" & DvKalaParameterVahedTejari.FieldValue("VahedeTejariSN") & ")"
                DvKalaParameterVahedTejari.Fields("DaftarForooshSN").RefreshCombo()
            End If
        End If
    End Sub

    Private Sub BtnInsertZaribDaftar_Click(sender As Object, e As EventArgs) Handles BtnInsertZaribDaftar.Click
        Dim FrmDarjZarib As New Common.FrmAbKalaParamterAssistant
        With FrmDarjZarib
            .DvSource = cn.ExecuteQuery("select KalaParameterSN,paDaftarforoosh.VahedeTejariSN,DaftarForooshSN,VahedeTejariDs,DaftarForooshDS,0 ZaribTakhsis,0 SumZaribTakhsis " &
                                     "from abKalaParameter cross join (Select VahedeTejariSN from imAppSetting where AppParamSN=209.935 and Value='1') Shobe " &
                                    "Join paDaftarforoosh on paDaftarforoosh.VahedeTejariSN = Shobe.VahedeTejariSN " &
                                    "Join paVahedeTejari on paVahedeTejari.VahedeTejariSN=Shobe.VahedeTejariSN " &
                                        "where KalaParameterSN=" & DvKalaParameter.FieldValue("KalaParameterSN"))
            .HideSNColumns = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub BtnGHatee_Click(sender As Object, e As EventArgs) Handles BtnGHatee.Click
        If CSystem.MsgBox("توجه داشته باشید با قطعی سازی ردیف های انتخابی  ، اسناد انبار در سطح " + vbNewLine +
                          DvKalaParameterVahedTejari.FieldText("VahedeTejariSN") + vbNewLine +
                          "برای محصول" + vbNewLine +
                          DvKalaParameter.FieldText("KalaSN") + vbNewLine +
                          "بر اساس درصد تخصیص یافته تقسیم خواهد شد.آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "") = MsgBoxResult.No Then
            Exit Sub
        End If


        With DvKalaParameterVahedTejari.FlexGrid
            Dim Sumdarsad As Decimal = 0
            Dim DuplicateDaftar As New ArrayList
            Dim KalaParamterStr As String = ""
            For i As Integer = 0 To .SelectedRows - 1
                If IsNumeric(.TextMatrix(.SelectedRow(i), .ColIndex("KalaParameterVahedeTejariSN"))) Then
                    If .TextMatrix(.SelectedRow(i), .ColIndex("Status")) <> "1" Then
                        CSystem.MsgBox("فقط ردیف های موقت قابلیت قطعی شدن دارند", MsgBoxStyle.Exclamation, "")
                        Exit Sub
                    End If

                    For j As Integer = 0 To DuplicateDaftar.Count - 1
                        If DuplicateDaftar.Item(j).ToString = .TextMatrix(.SelectedRow(i), .ColIndex("DaftarForooshSN")) Then
                            CSystem.MsgBox(.TextMatrix(.SelectedRow(i), .ColIndex("paDaftarForoosh_DaftarForooshSN")).ToString + " بیش از یک بار در ردیف های انتخابی موقت تکرار شده است", MsgBoxStyle.Exclamation, "")
                            Exit Sub
                        End If
                    Next
                    DuplicateDaftar.Add(.TextMatrix(.SelectedRow(i), .ColIndex("DaftarForooshSN")))
                    Sumdarsad += CDec(.TextMatrix(.SelectedRow(i), .ColIndex("ZaribTakhsisKala")))
                    KalaParamterStr += .TextMatrix(.SelectedRow(i), .ColIndex("KalaParameterVahedeTejariSN")) + ","
                End If
            Next
            If Sumdarsad <> 100 Then
                CSystem.MsgBox("مجموع ضرایب تخصیص یافته ردیف های موقت انتخابی می بایست 100 باشد", MsgBoxStyle.Critical, "")
                Exit Sub
            End If

            If KalaParamterStr.EndsWith(",") Then
                KalaParamterStr = KalaParamterStr.Substring(0, KalaParamterStr.Length - 1)
            End If

            Try
                cn.ExecuteNoneQuery("Update abKalaParameterVahedeTejari Set Status=2 Where KalaParameterVahedeTejariSN In (" & KalaParamterStr & ")")
            Catch ex As Exception
                CSystem.MsgBox("خطا در بروزرسانی وضعیت ردیف های انتخابی" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "")
            End Try
            DvKalaParameterVahedTejari.Refresh()

        End With



    End Sub

    Private Sub DvKalaParamterVahedTejari_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DvKalaParameterVahedTejari.FillDetailsWithData
        If aFetched Then
            DvKalaParameterVahedTejari.CommandEnabled(EnumCommands.cmDelete) = DvKalaParameterVahedTejari.Fields("Status").Value = 1
            DvKalaParameterVahedTejari.CommandEnabled(EnumCommands.cmEdit) = DvKalaParameterVahedTejari.Fields("Status").Value = 1
        End If


    End Sub

    Private Sub DvKalaParameterVahedTejari_AfterCommandClick(aCommand As EnumCommands) Handles DvKalaParameterVahedTejari.AfterCommandClick
        If aCommand = EnumCommands.cmSave Then
            DvKalaParameterVahedTejari.Refresh()
        End If
    End Sub
End Class

