
' OK
'Author ::Dehghani

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports VB = Microsoft.VisualBasic
Imports Anbar.BRL
Imports Minoo.Services.Middleware
Imports Minoo.Models.Middleware
Imports System.Collections.Generic


Public Class FrmabTafkikDarooei
    Inherits Minoo.Base.FTBaseForm

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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Public WithEvents TcShobe As Minoo.Controls.FTTabControl
    Public WithEvents TpDarkhast As System.Windows.Forms.TabPage
    Public WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents TcKala As Minoo.Controls.FTTabControl
    Public WithEvents TpKala As System.Windows.Forms.TabPage
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents tcKalaForSend As Minoo.Controls.FTTabControl
    Public WithEvents TpKalaForSend As System.Windows.Forms.TabPage
    Public WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GridEXDarkhast As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridKala As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridKalaForSend As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents UbuttonSend As Janus.Windows.EditControls.UIButton
    Public WithEvents TcListTafkik As Minoo.Controls.FTTabControl
    Public WithEvents TpShobe As System.Windows.Forms.TabPage
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Friend WithEvents GridShobe As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiCMSave As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents ListTafkikJoz As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ListTafkikKol As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiContextMenu2 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents ListTafkikJoz1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ListTafkikKol1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents FontNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioDesc As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAsc As System.Windows.Forms.RadioButton
    Friend WithEvents ChkRahgiri As System.Windows.Forms.CheckBox
    Friend WithEvents ChkKalaNO As System.Windows.Forms.CheckBox
    Friend WithEvents UBtnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents UButtonBack As Janus.Windows.EditControls.UIButton
    Friend WithEvents UButtonUpdate As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnErsalHavaleh As Janus.Windows.EditControls.UIButton


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridShobe_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabTafkikDarooei))
        Dim GridEXDarkhast_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXDarkhast_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim GridKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridKala_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim GridKalaForSend_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TcListTafkik = New Minoo.Controls.FTTabControl()
        Me.TpShobe = New System.Windows.Forms.TabPage()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.GridShobe = New Janus.Windows.GridEX.GridEX()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TcShobe = New Minoo.Controls.FTTabControl()
        Me.TpDarkhast = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GridEXDarkhast = New Janus.Windows.GridEX.GridEX()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TcKala = New Minoo.Controls.FTTabControl()
        Me.TpKala = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.UButtonUpdate = New Janus.Windows.EditControls.UIButton()
        Me.UbuttonSend = New Janus.Windows.EditControls.UIButton()
        Me.GridKala = New Janus.Windows.GridEX.GridEX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tcKalaForSend = New Minoo.Controls.FTTabControl()
        Me.TpKalaForSend = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UButtonBack = New Janus.Windows.EditControls.UIButton()
        Me.BtnErsalHavaleh = New Janus.Windows.EditControls.UIButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UBtnExcel = New Janus.Windows.EditControls.UIButton()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton()
        Me.UiContextMenu2 = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.UiCMSave = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.ListTafkikJoz = New Janus.Windows.UI.CommandBars.UICommand("ListTafkikJoz")
        Me.ListTafkikKol = New Janus.Windows.UI.CommandBars.UICommand("ListTafkikKol")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.ListTafkikJoz1 = New Janus.Windows.UI.CommandBars.UICommand("ListTafkikJoz")
        Me.ListTafkikKol1 = New Janus.Windows.UI.CommandBars.UICommand("ListTafkikKol")
        Me.FontNum = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioAsc = New System.Windows.Forms.RadioButton()
        Me.ChkRahgiri = New System.Windows.Forms.CheckBox()
        Me.RadioDesc = New System.Windows.Forms.RadioButton()
        Me.ChkKalaNO = New System.Windows.Forms.CheckBox()
        Me.GridKalaForSend = New Janus.Windows.GridEX.GridEX()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TcListTafkik.SuspendLayout()
        Me.TpShobe.SuspendLayout()
        Me.pnlG.SuspendLayout()
        CType(Me.GridShobe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.TcShobe.SuspendLayout()
        Me.TpDarkhast.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GridEXDarkhast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TcKala.SuspendLayout()
        Me.TpKala.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GridKala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tcKalaForSend.SuspendLayout()
        Me.TpKalaForSend.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UiContextMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCMSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKalaForSend, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1159, 539)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 50
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel10)
        Me.SplitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer4.Size = New System.Drawing.Size(1159, 217)
        Me.SplitContainer4.SplitterDistance = 596
        Me.SplitContainer4.SplitterWidth = 7
        Me.SplitContainer4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 217)
        Me.Panel1.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TcListTafkik)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(596, 217)
        Me.Panel6.TabIndex = 31
        '
        'TcListTafkik
        '
        Me.TcListTafkik.Controls.Add(Me.TpShobe)
        Me.TcListTafkik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcListTafkik.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcListTafkik.ItemSize = New System.Drawing.Size(42, 23)
        Me.TcListTafkik.Location = New System.Drawing.Point(0, 0)
        Me.TcListTafkik.Mirrored = True
        Me.TcListTafkik.Name = "TcListTafkik"
        Me.TcListTafkik.SelectedIndex = 0
        Me.TcListTafkik.Size = New System.Drawing.Size(596, 217)
        Me.TcListTafkik.TabIndex = 9
        '
        'TpShobe
        '
        Me.TpShobe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TpShobe.Controls.Add(Me.pnlG)
        Me.TpShobe.Location = New System.Drawing.Point(4, 27)
        Me.TpShobe.Name = "TpShobe"
        Me.TpShobe.Size = New System.Drawing.Size(588, 186)
        Me.TpShobe.TabIndex = 1
        Me.TpShobe.Text = "شعب"
        '
        'pnlG
        '
        Me.pnlG.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlG.Controls.Add(Me.GridShobe)
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(0, 0)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(588, 186)
        Me.pnlG.TabIndex = 8
        '
        'GridShobe
        '
        Me.GridShobe.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridShobe_DesignTimeLayout.LayoutString = resources.GetString("GridShobe_DesignTimeLayout.LayoutString")
        Me.GridShobe.DesignTimeLayout = GridShobe_DesignTimeLayout
        Me.GridShobe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridShobe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GridShobe.GroupByBoxVisible = False
        Me.GridShobe.Location = New System.Drawing.Point(0, 0)
        Me.GridShobe.Name = "GridShobe"
        Me.GridShobe.RecordNavigator = True
        Me.GridShobe.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridShobe.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridShobe.Size = New System.Drawing.Size(584, 182)
        Me.GridShobe.TabIndex = 8
        Me.GridShobe.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridShobe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.TcShobe)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(556, 217)
        Me.Panel10.TabIndex = 14
        '
        'TcShobe
        '
        Me.TcShobe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TcShobe.Controls.Add(Me.TpDarkhast)
        Me.TcShobe.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcShobe.ItemSize = New System.Drawing.Size(42, 23)
        Me.TcShobe.Location = New System.Drawing.Point(3, 3)
        Me.TcShobe.Mirrored = True
        Me.TcShobe.Name = "TcShobe"
        Me.TcShobe.SelectedIndex = 0
        Me.TcShobe.Size = New System.Drawing.Size(550, 199)
        Me.TcShobe.TabIndex = 7
        '
        'TpDarkhast
        '
        Me.TpDarkhast.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TpDarkhast.Controls.Add(Me.Panel11)
        Me.TpDarkhast.Location = New System.Drawing.Point(4, 27)
        Me.TpDarkhast.Name = "TpDarkhast"
        Me.TpDarkhast.Size = New System.Drawing.Size(542, 168)
        Me.TpDarkhast.TabIndex = 1
        Me.TpDarkhast.Text = "درخواست ها"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.GridEXDarkhast)
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel11.Size = New System.Drawing.Size(542, 168)
        Me.Panel11.TabIndex = 8
        '
        'GridEXDarkhast
        '
        Me.GridEXDarkhast.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEXDarkhast_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEXDarkhast_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEXDarkhast_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEXDarkhast_DesignTimeLayout_Reference_0})
        GridEXDarkhast_DesignTimeLayout.LayoutString = resources.GetString("GridEXDarkhast_DesignTimeLayout.LayoutString")
        Me.GridEXDarkhast.DesignTimeLayout = GridEXDarkhast_DesignTimeLayout
        Me.GridEXDarkhast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXDarkhast.GroupByBoxVisible = False
        Me.GridEXDarkhast.Location = New System.Drawing.Point(0, 0)
        Me.GridEXDarkhast.Name = "GridEXDarkhast"
        Me.GridEXDarkhast.RecordNavigator = True
        Me.GridEXDarkhast.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridEXDarkhast.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXDarkhast.Size = New System.Drawing.Size(538, 164)
        Me.GridEXDarkhast.TabIndex = 6
        Me.GridEXDarkhast.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(1159, 318)
        Me.SplitContainer2.SplitterDistance = 596
        Me.SplitContainer2.SplitterWidth = 7
        Me.SplitContainer2.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.TcKala)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(596, 318)
        Me.Panel2.TabIndex = 13
        '
        'TcKala
        '
        Me.TcKala.Controls.Add(Me.TpKala)
        Me.TcKala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcKala.ItemSize = New System.Drawing.Size(42, 23)
        Me.TcKala.Location = New System.Drawing.Point(0, 0)
        Me.TcKala.Mirrored = True
        Me.TcKala.Name = "TcKala"
        Me.TcKala.SelectedIndex = 0
        Me.TcKala.Size = New System.Drawing.Size(596, 318)
        Me.TcKala.TabIndex = 7
        '
        'TpKala
        '
        Me.TpKala.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TpKala.Controls.Add(Me.Panel3)
        Me.TpKala.Location = New System.Drawing.Point(4, 27)
        Me.TpKala.Name = "TpKala"
        Me.TpKala.Size = New System.Drawing.Size(588, 287)
        Me.TpKala.TabIndex = 1
        Me.TpKala.Text = "لیست کالا"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.GridKala)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel3.Size = New System.Drawing.Size(588, 287)
        Me.Panel3.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.Controls.Add(Me.UButtonUpdate)
        Me.Panel8.Controls.Add(Me.UbuttonSend)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 237)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(584, 46)
        Me.Panel8.TabIndex = 208
        '
        'UButtonUpdate
        '
        Me.UButtonUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UButtonUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UButtonUpdate.Location = New System.Drawing.Point(419, 5)
        Me.UButtonUpdate.Name = "UButtonUpdate"
        Me.UButtonUpdate.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UButtonUpdate.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.UButtonUpdate.Size = New System.Drawing.Size(159, 35)
        Me.UButtonUpdate.TabIndex = 208
        Me.UButtonUpdate.Text = "بروز رسانی اطلاعات"
        Me.UButtonUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'UbuttonSend
        '
        Me.UbuttonSend.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UbuttonSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UbuttonSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UbuttonSend.Image = Global.Minoo.Applications.Anbar.My.Resources.Resources.images12
        Me.UbuttonSend.ImageSize = New System.Drawing.Size(70, 30)
        Me.UbuttonSend.Location = New System.Drawing.Point(3, 4)
        Me.UbuttonSend.Name = "UbuttonSend"
        Me.UbuttonSend.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UbuttonSend.Office2007CustomColor = System.Drawing.Color.LimeGreen
        Me.UbuttonSend.Size = New System.Drawing.Size(72, 37)
        Me.UbuttonSend.TabIndex = 207
        Me.UbuttonSend.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.UbuttonSend.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'GridKala
        '
        Me.GridKala.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridKala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridKala_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridKala_DesignTimeLayout_Reference_0.Instance"), Object)
        GridKala_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridKala_DesignTimeLayout_Reference_0})
        GridKala_DesignTimeLayout.LayoutString = resources.GetString("GridKala_DesignTimeLayout.LayoutString")
        Me.GridKala.DesignTimeLayout = GridKala_DesignTimeLayout
        Me.GridKala.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GridKala.GroupByBoxVisible = False
        Me.GridKala.Location = New System.Drawing.Point(0, 0)
        Me.GridKala.Name = "GridKala"
        Me.GridKala.RecordNavigator = True
        Me.GridKala.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridKala.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKala.Size = New System.Drawing.Size(584, 234)
        Me.GridKala.TabIndex = 8
        Me.GridKala.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.tcKalaForSend)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(556, 318)
        Me.Panel4.TabIndex = 14
        '
        'tcKalaForSend
        '
        Me.tcKalaForSend.Controls.Add(Me.TpKalaForSend)
        Me.tcKalaForSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcKalaForSend.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcKalaForSend.ItemSize = New System.Drawing.Size(42, 40)
        Me.tcKalaForSend.Location = New System.Drawing.Point(0, 0)
        Me.tcKalaForSend.Mirrored = True
        Me.tcKalaForSend.Name = "tcKalaForSend"
        Me.tcKalaForSend.SelectedIndex = 0
        Me.tcKalaForSend.Size = New System.Drawing.Size(556, 318)
        Me.tcKalaForSend.TabIndex = 7
        '
        'TpKalaForSend
        '
        Me.TpKalaForSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TpKalaForSend.Controls.Add(Me.Panel5)
        Me.TpKalaForSend.Location = New System.Drawing.Point(4, 44)
        Me.TpKalaForSend.Name = "TpKalaForSend"
        Me.TpKalaForSend.Size = New System.Drawing.Size(548, 270)
        Me.TpKalaForSend.TabIndex = 1
        Me.TpKalaForSend.Text = "کالاهای آماده ارسال"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.GridKalaForSend)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel5.Size = New System.Drawing.Size(548, 270)
        Me.Panel5.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.Controls.Add(Me.UButtonBack)
        Me.Panel7.Controls.Add(Me.BtnErsalHavaleh)
        Me.Panel7.Controls.Add(Me.GroupBox2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 199)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(544, 67)
        Me.Panel7.TabIndex = 207
        '
        'UButtonBack
        '
        Me.UButtonBack.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UButtonBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UButtonBack.Image = Global.Minoo.Applications.Anbar.My.Resources.Resources.images122
        Me.UButtonBack.ImageSize = New System.Drawing.Size(70, 30)
        Me.UButtonBack.Location = New System.Drawing.Point(469, 25)
        Me.UButtonBack.Name = "UButtonBack"
        Me.UButtonBack.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UButtonBack.Office2007CustomColor = System.Drawing.Color.LimeGreen
        Me.UButtonBack.Size = New System.Drawing.Size(72, 37)
        Me.UButtonBack.TabIndex = 208
        Me.UButtonBack.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.UButtonBack.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnErsalHavaleh
        '
        Me.BtnErsalHavaleh.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnErsalHavaleh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnErsalHavaleh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnErsalHavaleh.Location = New System.Drawing.Point(4, 8)
        Me.BtnErsalHavaleh.Name = "BtnErsalHavaleh"
        Me.BtnErsalHavaleh.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.BtnErsalHavaleh.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.BtnErsalHavaleh.Size = New System.Drawing.Size(100, 55)
        Me.BtnErsalHavaleh.TabIndex = 206
        Me.BtnErsalHavaleh.Text = "ارسال به انبار"
        Me.BtnErsalHavaleh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.UBtnExcel)
        Me.GroupBox2.Controls.Add(Me.UiButton1)
        Me.GroupBox2.Controls.Add(Me.FontNum)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RadioAsc)
        Me.GroupBox2.Controls.Add(Me.ChkRahgiri)
        Me.GroupBox2.Controls.Add(Me.RadioDesc)
        Me.GroupBox2.Controls.Add(Me.ChkKalaNO)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(98, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 62)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'UBtnExcel
        '
        Me.UBtnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UBtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UBtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UBtnExcel.Location = New System.Drawing.Point(7, 21)
        Me.UBtnExcel.Name = "UBtnExcel"
        Me.UBtnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UBtnExcel.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.UBtnExcel.Size = New System.Drawing.Size(68, 35)
        Me.UBtnExcel.TabIndex = 207
        Me.UBtnExcel.Text = "Excel"
        Me.UBtnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'UiButton1
        '
        Me.UiButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiCMSave.SetContextMenu(Me.UiButton1, Me.UiContextMenu2)
        Me.UiButton1.DropDownContextMenu = Me.UiContextMenu2
        Me.UiButton1.FlatBorderColor = System.Drawing.SystemColors.ControlDark
        Me.UiButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UiButton1.Location = New System.Drawing.Point(87, 21)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UiButton1.Office2007CustomColor = System.Drawing.Color.LightSlateGray
        Me.UiButton1.Size = New System.Drawing.Size(68, 35)
        Me.UiButton1.TabIndex = 208
        Me.UiButton1.Text = "چاپ"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'UiContextMenu2
        '
        Me.UiContextMenu2.CommandManager = Me.UiCMSave
        Me.UiContextMenu2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ListTafkikJoz1, Me.ListTafkikKol1})
        Me.UiContextMenu2.Key = "ContextMenu1"
        Me.UiContextMenu2.UseThemes = Janus.Windows.UI.InheritableBoolean.[True]
        Me.UiContextMenu2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'UiCMSave
        '
        Me.UiCMSave.BottomRebar = Me.BottomRebar1
        Me.UiCMSave.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ListTafkikJoz, Me.ListTafkikKol})
        Me.UiCMSave.ContainerControl = Me
        Me.UiCMSave.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu2})
        Me.UiCMSave.Id = New System.Guid("1b6c95cf-1cec-4ade-8623-84e73a387ece")
        Me.UiCMSave.LeftRebar = Me.LeftRebar1
        Me.UiCMSave.RightRebar = Me.RightRebar1
        Me.UiCMSave.Tag = Nothing
        Me.UiCMSave.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCMSave
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'ListTafkikJoz
        '
        Me.ListTafkikJoz.Key = "ListTafkikJoz"
        Me.ListTafkikJoz.Name = "ListTafkikJoz"
        Me.ListTafkikJoz.Text = "لیست تفکیک جزء"
        '
        'ListTafkikKol
        '
        Me.ListTafkikKol.Key = "ListTafkikKol"
        Me.ListTafkikKol.Name = "ListTafkikKol"
        Me.ListTafkikKol.Text = "لیست تفکیک کل"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCMSave
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCMSave
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UiCMSave
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1159, 0)
        '
        'ListTafkikJoz1
        '
        Me.ListTafkikJoz1.Key = "ListTafkikJoz"
        Me.ListTafkikJoz1.Name = "ListTafkikJoz1"
        '
        'ListTafkikKol1
        '
        Me.ListTafkikKol1.Key = "ListTafkikKol"
        Me.ListTafkikKol1.Name = "ListTafkikKol1"
        '
        'FontNum
        '
        Me.FontNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontNum.DecimalPlaces = 1
        Me.FontNum.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.FontNum.Location = New System.Drawing.Point(165, 35)
        Me.FontNum.Name = "FontNum"
        Me.FontNum.Size = New System.Drawing.Size(56, 21)
        Me.FontNum.TabIndex = 30
        Me.FontNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FontNum.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "سایز چاپ :"
        '
        'RadioAsc
        '
        Me.RadioAsc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioAsc.AutoSize = True
        Me.RadioAsc.Checked = True
        Me.RadioAsc.Location = New System.Drawing.Point(227, 38)
        Me.RadioAsc.Name = "RadioAsc"
        Me.RadioAsc.Size = New System.Drawing.Size(60, 17)
        Me.RadioAsc.TabIndex = 24
        Me.RadioAsc.TabStop = True
        Me.RadioAsc.Text = "صعودی"
        Me.RadioAsc.UseVisualStyleBackColor = True
        '
        'ChkRahgiri
        '
        Me.ChkRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkRahgiri.AutoSize = True
        Me.ChkRahgiri.Checked = True
        Me.ChkRahgiri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRahgiri.Location = New System.Drawing.Point(293, 39)
        Me.ChkRahgiri.Name = "ChkRahgiri"
        Me.ChkRahgiri.Size = New System.Drawing.Size(63, 17)
        Me.ChkRahgiri.TabIndex = 23
        Me.ChkRahgiri.Text = "رهگیری"
        Me.ChkRahgiri.UseVisualStyleBackColor = True
        '
        'RadioDesc
        '
        Me.RadioDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioDesc.AutoSize = True
        Me.RadioDesc.Location = New System.Drawing.Point(235, 15)
        Me.RadioDesc.Name = "RadioDesc"
        Me.RadioDesc.Size = New System.Drawing.Size(52, 17)
        Me.RadioDesc.TabIndex = 25
        Me.RadioDesc.Text = "نزولی"
        Me.RadioDesc.UseVisualStyleBackColor = True
        '
        'ChkKalaNO
        '
        Me.ChkKalaNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkKalaNO.AutoSize = True
        Me.ChkKalaNO.Checked = True
        Me.ChkKalaNO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkKalaNO.Location = New System.Drawing.Point(301, 16)
        Me.ChkKalaNO.Name = "ChkKalaNO"
        Me.ChkKalaNO.Size = New System.Drawing.Size(55, 17)
        Me.ChkKalaNO.TabIndex = 22
        Me.ChkKalaNO.Text = "کد کالا"
        Me.ChkKalaNO.UseVisualStyleBackColor = True
        '
        'GridKalaForSend
        '
        Me.GridKalaForSend.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridKalaForSend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridKalaForSend_DesignTimeLayout.LayoutString = resources.GetString("GridKalaForSend_DesignTimeLayout.LayoutString")
        Me.GridKalaForSend.DesignTimeLayout = GridKalaForSend_DesignTimeLayout
        Me.GridKalaForSend.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GridKalaForSend.GroupByBoxVisible = False
        Me.GridKalaForSend.Location = New System.Drawing.Point(0, 0)
        Me.GridKalaForSend.Name = "GridKalaForSend"
        Me.GridKalaForSend.RecordNavigator = True
        Me.GridKalaForSend.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridKalaForSend.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKalaForSend.Size = New System.Drawing.Size(543, 197)
        Me.GridKalaForSend.TabIndex = 9
        Me.GridKalaForSend.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "images12.jpg")
        Me.ImageList1.Images.SetKeyName(1, "images122.jpg")
        '
        'FrmabTafkikDarooei
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1159, 539)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "FrmabTafkikDarooei"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی ارسال کالا"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TcListTafkik.ResumeLayout(False)
        Me.TpShobe.ResumeLayout(False)
        Me.pnlG.ResumeLayout(False)
        CType(Me.GridShobe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.TcShobe.ResumeLayout(False)
        Me.TpDarkhast.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.GridEXDarkhast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TcKala.ResumeLayout(False)
        Me.TpKala.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GridKala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.tcKalaForSend.ResumeLayout(False)
        Me.TpKalaForSend.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UiContextMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCMSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKalaForSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmabTafkikDarooei
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmabTafkikDarooei

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabTafkikDarooei
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabTafkikDarooei)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

    Dim _rule As New ClsDataAccessRule
    Dim DvTafkik As New DataView
    Dim DvKalaForSend As New DataTable
    Dim DvKala As New DataTable

    Private Sub FrmabTafkik_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DvTafkik = _rule.GetTafkikDarooei(cn).Tables(0).DefaultView
        DvKalaForSend = DvTafkik.ToTable()
        DvKalaForSend.Clear()
        DvKala = DvTafkik.ToTable()
        GridKala.RootTable.Columns("Ersal").Image = ImageList1.Images(0)

        If Not IsNothing(DvTafkik) AndAlso DvTafkik.Count > 0 Then

            Dim dtShobe As DataTable = DvTafkik.ToTable(True, {"ShobeSN", "ShobeDS", "CountKala", "SumTedadAdad", "SumTedadKarton", "SumVazn", "SumRial"})

            For Each _row As DataRow In dtShobe.Rows
                Dim dvCalc As DataView = New DataView(DvTafkik.ToTable, "ShobeSN=" & _row("ShobeSN").ToString, "KalaSN", DataViewRowState.CurrentRows)
                Dim Cnt As Integer = 1
                For i As Integer = 1 To dvCalc.Count - 1
                    If dvCalc(i)("KalaSN") <> dvCalc(i - 1)("KalaSN") Then
                        Cnt += 1
                    End If
                Next

                _row.BeginEdit()
                _row("CountKala") = Cnt
                _row("SumTedadAdad") = Math.Round(If(IsDBNull(dvCalc.ToTable.Compute("Sum(TedadAdad)", "")), 0, dvCalc.ToTable.Compute("Sum(TedadAdad)", "")))
                _row("SumTedadKarton") = Math.Round(If(IsDBNull(dvCalc.ToTable.Compute("Sum(TedadKarton)", "")), 0, dvCalc.ToTable.Compute("Sum(TedadKarton)", "")))
                _row("SumVazn") = If(IsDBNull(dvCalc.ToTable.Compute("Sum(Vazn)", "")), 0, dvCalc.ToTable.Compute("Sum(Vazn)", ""))
                _row("SumRial") = If(IsDBNull(dvCalc.ToTable.Compute("Sum(Rial)", "")), 0, dvCalc.ToTable.Compute("Sum(Rial)", ""))
                _row.EndEdit()

            Next
            dtShobe.DefaultView.Sort = "ShobeDS"
            GridShobe.DataSource = dtShobe.DefaultView
            GridShobe.AutoSizeColumns()
            GridShobe.Refresh()
        End If

    End Sub

    Private Sub GridShobe_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridShobe.SelectionChanged
        If GridShobe.RowCount > 0 AndAlso GridShobe.CurrentRow.Cells("ShobeDS").Text <> "" Then
            TpDarkhast.Text = "درخواست های " + GridShobe.CurrentRow.Cells("ShobeDS").Text
            TpKalaForSend.Text = "کالاهای آماده ارسال " + GridShobe.CurrentRow.Cells("ShobeDS").Text
            DvKalaForSend.DefaultView.RowFilter = "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Value.ToString
            Dim DarkhastHa As DataView = New DataView(DvTafkik.ToTable, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Value, "DarkhastNo", DataViewRowState.CurrentRows)
            DarkhastHa = DarkhastHa.ToTable(True, {"DarkhastSN", "DarkhastNo", "DarkhastDate", "DarkhastKonandeh"}).DefaultView()
            GridEXDarkhast.DataSource = DarkhastHa
            GridEXDarkhast.AutoSizeColumns()
            GridEXDarkhast.Refresh()
        Else
            TpDarkhast.Text = "درخواست "
            TpKalaForSend.Text = "کالاهای آماده ارسال "
        End If
    End Sub

    Private Sub GridEXDarkhast_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEXDarkhast.SelectionChanged

        Dim DArkhastSN As String = ""
        Dim DArkhastNo As String = ""
        For Each Grow As Janus.Windows.GridEX.GridEXRow In GridEXDarkhast.GetRows
            If Grow.IsChecked Then
                DArkhastSN += Grow.Cells("DarkhastSN").Text + ","
                DArkhastNo += Grow.Cells("DArkhastNo").Text + ","
            End If
        Next

        If DArkhastSN.EndsWith(",") Then
            DArkhastSN = DArkhastSN.Substring(0, DArkhastSN.Length - 1)
            DArkhastNo = DArkhastNo.Substring(0, DArkhastNo.Length - 1)
        ElseIf GridEXDarkhast.RowCount > 0 AndAlso GridEXDarkhast.CurrentRow.Cells("DarkhastSN").Text <> "" Then
            DArkhastSN = GridEXDarkhast.CurrentRow.Cells("DarkhastSN").Value
            DArkhastNo = GridEXDarkhast.CurrentRow.Cells("DArkhastNo").Text
        Else
            TpKala.Text = "لیست کالا "
            Exit Sub
        End If

        TpKala.Text = "لیست کالاهای درخواست شماره " + DArkhastNo
        Dim DvKalaDarkhast As DataView = New DataView(DvKala, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Value.ToString + "And DarkhastSN IN (" & DArkhastSN & ")", "", DataViewRowState.CurrentRows)
        GridKala.DataSource = DvKalaDarkhast
        GridKala.AutoSizeColumns()
        GridKala.RootTable.Columns("Ersal").Width = 50
        GridKala.Refresh()

    End Sub

    Private Sub UbuttonSend_Click(sender As System.Object, e As System.EventArgs) Handles UbuttonSend.Click

        If GridKala.GetCheckedRows.Length = 0 Then
            NetSql.Common.CSystem.MsgBox("موردی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        For Each GRow As Janus.Windows.GridEX.GridEXRow In GridKala.GetRows
            If GRow.IsChecked And GRow.Cells("DarkhastStatus").Value = 1 Then
                Dim _row As DataRowView = GRow.DataRow
                DvKalaForSend.DefaultView.RowFilter = "KalaPhizikiSN=" & _row("KalaPhizikiSN").ToString & " And ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Text
                If DvKalaForSend.DefaultView.Count = 0 Then
                    DvKalaForSend.ImportRow(_row.Row)
                    GRow.Delete()
                Else
                    Dim StrTozih As String = " , " + _row("DarkhastNo").ToString
                    For Each RowForUpdate As DataRow In DvKalaForSend.Rows
                        If RowForUpdate("KalaPhizikiSN") = _row("KalaPhizikiSN") AndAlso RowForUpdate("ShobeSN") = _row("ShobeSN") Then
                            RowForUpdate.BeginEdit()
                            If Not RowForUpdate("Tozih").ToString.Contains(_row("DarkhastNo").ToString) Then
                                RowForUpdate("Tozih") = If(RowForUpdate("Tozih").ToString <> "", RowForUpdate("Tozih").ToString, "تجمیعی درخواست های " + RowForUpdate("DarkhastNo").ToString) + StrTozih
                            End If
                            If Not RowForUpdate("ListTafkikHaSN").ToString.Contains(_row("ListTafkikHaSN").ToString) Then
                                RowForUpdate("ListTafkikHaSN") = RowForUpdate("ListTafkikHaSN").ToString + "," + _row("ListTafkikHaSN").ToString
                            End If
                            RowForUpdate("TedadAdad") += _row("TedadAdad")
                            RowForUpdate("TedadKarton") += _row("TedadKarton")
                            RowForUpdate("Vazn") += _row("Vazn")
                            RowForUpdate.EndEdit()
                        End If
                    Next
                    GRow.Delete()
                End If
            End If
        Next
        DvKalaForSend.DefaultView.RowFilter = "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Text
        GridKalaForSend.DataSource = DvKalaForSend
        GridKalaForSend.AutoSizeColumns()
        GridKalaForSend.Refresh()

    End Sub

    Private Sub ListTafkikJoz_Click(sender As System.Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ListTafkikJoz.Click

        Dim OrderByString As String = "VahedeTejariDS  " + If(RadioAsc.Checked, "ASC,", "DESC,")

        If ChkKalaNO.Checked Then
            OrderByString += " KalaNo " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        If ChkRahgiri.Checked Then
            OrderByString += " ShomarehRahgiri " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If

        OrderByString = OrderByString.Substring(0, OrderByString.Length - 1)

        Dim TafkikValues As String = ""

        For Each Grow As Janus.Windows.GridEX.GridEXRow In GridShobe.GetRows
            If Grow.IsChecked Then
                Dim DvFilterListTafkik As DataTable = New DataView(DvKalaForSend, "ShobeSN=" & Grow.Cells("ShobeSN").Text, "", DataViewRowState.CurrentRows).ToTable(True, "ListTafkikHaSN")
                For Each _row As DataRow In DvFilterListTafkik.Rows
                    If Not TafkikValues.Contains(_row("ListTafkikHaSN").ToString) Then
                        TafkikValues += _row("ListTafkikHaSN").ToString + ","
                    End If
                Next
            End If
        Next

        If TafkikValues = "" AndAlso GridShobe.RowCount > 0 AndAlso GridShobe.CurrentRow.Cells("ShobeSN").Text <> "" Then
            Dim DvFilterListTafkik As DataTable = New DataView(DvKalaForSend, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Text, "", DataViewRowState.CurrentRows).ToTable(True, "ListTafkikHaSN")
            For Each _row As DataRow In DvFilterListTafkik.Rows
                If Not TafkikValues.Contains(_row("ListTafkikHaSN").ToString) Then
                    TafkikValues += _row("ListTafkikHaSN").ToString + ","
                End If
            Next
        End If

        If TafkikValues.EndsWith(",") Then
            TafkikValues = TafkikValues.Substring(0, Len(TafkikValues) - 1)
        Else
            NetSql.Common.CSystem.MsgBox("موردی برای چاپ یافت نشد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim str As String = "abSPG_GetDataForPrintListTafkikDarooei '" & TafkikValues & "','" & OrderByString & "',1"
        Dim Dv As New DataView
        Dv = cn.ExecuteQuery(str)

        If Dv.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست تفکیک جزء به علت عدم وجود داده قابل چاپ نمی باشد", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            Exit Sub
        End If

        Dim Font1Size As Single = Decimal.ToSingle(FontNum.Value)
        Dim Font2Size As Single = Decimal.ToSingle(FontNum.Value) - 2

        Dim _Font1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", Font1Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Dim _Font2 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", Font2Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        Dim ListTafkikJoz As New Minoo.Applications.Anbar.Report.RptAbListTafkik_Joz
        With ListTafkikJoz
            .TxtFont1 = _Font1
            .TxtFont2 = _Font2
            .DefField()
            .DataSource = Dv

            Try
                Minoo.Reports.FTReportViewer.ShowReport(ListTafkikJoz, CSanad.gMDIParent)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در نمایش گزارش لیست تفکیک جزء", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            End Try

        End With

    End Sub

    Private Sub ListTafkikKol_Click(sender As System.Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ListTafkikKol.Click

        If GridShobe.RowCount <= 1 Then
            NetSql.Common.CSystem.MsgBox("موردی برای چاپ یافت نشد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim OrderByString As String = "Cast(vahedetejariNO as int) " + If(RadioAsc.Checked, "ASC,", "DESC,")

        If ChkKalaNO.Checked Then
            OrderByString += " KalaNo " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        If ChkRahgiri.Checked Then
            OrderByString += " ShomarehRahgiri " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If

        OrderByString = OrderByString.Substring(0, OrderByString.Length - 1)

        Dim TafkikValues As String = ""

        For Each Grow As Janus.Windows.GridEX.GridEXRow In GridShobe.GetRows
            If Grow.IsChecked Then
                Dim DvFilterListTafkik As DataTable = New DataView(DvKalaForSend, "ShobeSN=" & Grow.Cells("ShobeSN").Text, "", DataViewRowState.CurrentRows).ToTable(True, "ListTafkikHaSN")
                For Each _row As DataRow In DvFilterListTafkik.Rows
                    If Not TafkikValues.Contains(_row("ListTafkikHaSN").ToString) Then
                        TafkikValues += _row("ListTafkikHaSN").ToString + ","
                    End If
                Next
            End If
        Next

        If TafkikValues = "" AndAlso GridShobe.RowCount > 0 AndAlso GridShobe.CurrentRow.Cells("ShobeSN").Text <> "" Then
            Dim DvFilterListTafkik As DataTable = New DataView(DvKalaForSend, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Text, "", DataViewRowState.CurrentRows).ToTable(True, "ListTafkikHaSN")
            For Each _row As DataRow In DvFilterListTafkik.Rows
                If Not TafkikValues.Contains(_row("ListTafkikHaSN").ToString) Then
                    TafkikValues += _row("ListTafkikHaSN").ToString + ","
                End If
            Next
        End If

        If TafkikValues.EndsWith(",") Then
            TafkikValues = TafkikValues.Substring(0, Len(TafkikValues) - 1)
        Else
            NetSql.Common.CSystem.MsgBox("موردی برای چاپ یافت نشد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim Dv As New DataView
        Dv = cn.ExecuteQuery("abSPG_GetDataForPrintListTafkikDarooei '" & TafkikValues & "','" & OrderByString & "',0")
        If Dv.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست تفکیک کل به علت عدم وجود داده قابل چاپ نمی باشد", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            Exit Sub
        End If

        Dim DtSource As New DataTable
        DtSource = Dv.ToTable

        Dim DvJoz As New DataView
        DvJoz = cn.ExecuteQuery("abSPG_GetDataForPrintListTafkikDarooei '" & TafkikValues & "','" & OrderByString & "',1")
        Dim DtJoz As DataTable = DvJoz.ToTable(True, "VahedeTejariDS")

        If DtJoz.Rows.Count = 1 Then
            For Each _row As DataRow In DtSource.Rows
                _row.BeginEdit()
                _row("VahedeTejariDS") += " - " + DtJoz.Rows(0)(0).ToString
                _row.EndEdit()
            Next
        End If

        Dim Font1Size As Single = Decimal.ToSingle(FontNum.Value)
        Dim Font2Size As Single = Decimal.ToSingle(FontNum.Value) - 2

        Dim _Font1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", Font1Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Dim _Font2 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", Font2Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        Dim ListTafkikKol As New Minoo.Applications.Anbar.Report.RptAbListTafkik_Kol

        With ListTafkikKol
            .TxtFont1 = _Font1
            .TxtFont2 = _Font2
            .DefField()
            .DataSource = DtSource.DefaultView

            Try
                Minoo.Reports.FTReportViewer.ShowReport(ListTafkikKol, CSanad.gMDIParent)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در نمایش گزارش لیست تفکیک کل", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            End Try

        End With
    End Sub

    Private Sub UBtnExcel_Click(sender As System.Object, e As System.EventArgs) Handles UBtnExcel.Click

        Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems

        If GridShobe.RowCount = 0 Then
            NetSql.Common.CSystem.MsgBox("موردی یافت نشد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim StrShobe As String = ""
        Dim StrShobeDS As String = "شعب"

        For Each Grow As Janus.Windows.GridEX.GridEXRow In GridShobe.GetRows
            If Grow.IsChecked Then
                StrShobe += Grow.Cells("ShobeSN").Text + ","
                StrShobeDS += Grow.Cells("ShobeDS").Text + ","
            End If
        Next
        If StrShobe = "" Then
            StrShobe = GridShobe.CurrentRow.Cells("ShobeSN").Text + ","
            StrShobeDS = GridShobe.CurrentRow.Cells("ShobeDS").Text + ","
        End If

        If StrShobe.EndsWith(",") Then
            StrShobe = StrShobe.Substring(0, Len(StrShobe) - 1)
            StrShobeDS = StrShobeDS.Substring(0, Len(StrShobeDS) - 1)
        End If

        Dim DvFilterListTafkik As DataTable = New DataView(DvKalaForSend, "ShobeSN In (" & StrShobe & ")", "", DataViewRowState.CurrentRows).
                                                                                        ToTable(True, {"ShobeDS", "DarkhastNo", "KalaNo", "KalaDS", "ShomarehRahgiri", "TedadAdad", "TedadKarton", "Vazn", "Rial"})

        If DvFilterListTafkik.Rows.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("کالاهای آماده ارسال " + GridShobe.CurrentRow.Cells("ShobeDS").Text + " مشخص نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        DvFilterListTafkik.Columns("ShobeDS").ColumnName = "نام شعبه"
        DvFilterListTafkik.Columns("DarkhastNo").ColumnName = "شماره درخواست."
        DvFilterListTafkik.Columns("KalaNo").ColumnName = "کد کالا."
        DvFilterListTafkik.Columns("KalaDS").ColumnName = "نام کالا."
        DvFilterListTafkik.Columns("ShomarehRahgiri").ColumnName = ".شماره رهگیری."
        DvFilterListTafkik.Columns("TedadAdad").ColumnName = "تعداد عددی."
        DvFilterListTafkik.Columns("TedadKarton").ColumnName = "تعداد (کارتن)."
        DvFilterListTafkik.Columns("Vazn").ColumnName = "وزن (کیلو)."
        DvFilterListTafkik.Columns("Rial").ColumnName = "ارزش (ریال)."

        Try
            _SharedItems.ExcellExport("لیست تفکیک " + StrShobeDS, DvFilterListTafkik)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکالی در ساخت فایل اکسل به وجود آمده است.", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
        End Try


    End Sub

    Private Sub UButtonBack_Click(sender As System.Object, e As System.EventArgs) Handles UButtonBack.Click

        If GridKalaForSend.GetCheckedRows.Length = 0 Then
            NetSql.Common.CSystem.MsgBox("موردی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim DvKalaForSend2 As DataTable = GridKalaForSend.DataSource

        For Each GRow As Janus.Windows.GridEX.GridEXRow In GridKalaForSend.GetCheckedRows
            Dim NewView As DataView = New DataView(DvTafkik.ToTable, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Text & " And KalaPhizikiSN = " & GRow.Cells("KalaPhizikiSN").Text, "", DataViewRowState.CurrentRows)
            If NewView.Count > 1 AndAlso GRow.Cells("Tozih").Text.Contains(",") Then
                For Each _row As DataRow In NewView.ToTable.Rows
                    DvKala.ImportRow(_row)
                Next
                DvKalaForSend2.Rows.Remove(GRow.DataRow.Row)
            Else
                DvKala.ImportRow(GRow.DataRow.Row)
                DvKalaForSend2.Rows.Remove(GRow.DataRow.Row)
            End If
        Next
        DvKalaForSend = DvKalaForSend2
        GridKalaForSend.DataSource = DvKalaForSend
        GridKalaForSend.UnCheckAllRecords()
        GridKalaForSend.Refresh()
        Dim DvKalaDarkhast As DataView = New DataView(DvKala, "ShobeSN=" & GridShobe.CurrentRow.Cells("ShobeSN").Value.ToString + "And DarkhastSN IN (" & GridEXDarkhast.CurrentRow.Cells("DarkhastSN").Text & ")", "", DataViewRowState.CurrentRows)
        GridKala.DataSource = DvKalaDarkhast
        GridKala.Refresh()

    End Sub

    Private Sub UButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles UButtonUpdate.Click
        Dim Frmwait As New Anbar.Common.Frmwait
        Try
            Frmwait.Label3.Text = "...سیستم درحال بروز رسانی اطلاعات می باشد..."
            Frmwait.Show()
            Frmwait.Refresh()
            Call UpdateListTafkikInformation()
        Catch ex As Exception
        Finally
            Frmwait.Close()
        End Try

    End Sub

    Private Sub BtnErsalForHavaleh_Click(sender As System.Object, e As System.EventArgs) Handles BtnErsalHavaleh.Click
        Dim ErrMsg As String = ""

        If GridKalaForSend.RowCount <= 1 Then
            NetSql.Common.CSystem.MsgBox("موردی برای ارسال وجود ندارد", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If _
            NetSql.Common.CSystem.MsgBox((GridKalaForSend.RowCount - 1).ToString + " مورد کالا برای ارسال به " + GridShobe.CurrentRow.Cells("ShobeDS").Text + " انتخاب شده است." + vbCr +
                                         "آیا از ادامه عملیات ارسال اطمینان دارید؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "ارسال به " + GridShobe.CurrentRow.Cells("ShobeDS").Text) = MsgBoxResult.Yes Then


            Dim TozihTitrSanad As String = ""
            Dim DarkhastNoTbl As DataTable = New DataView(GridKalaForSend.DataSource, "", "", DataViewRowState.CurrentRows).ToTable(True, {"DarkhastNo", "Tozih"})
            If DarkhastNoTbl.Rows.Count = 1 AndAlso IsNumeric(DarkhastNoTbl.DefaultView(0)(0).ToString) Then
                TozihTitrSanad += "  بابت درخواست  " + DarkhastNoTbl.DefaultView(0)(0).ToString
            Else
                Dim StrDarkhast As String = ""
                For Each _row As DataRow In DarkhastNoTbl.Rows
                    StrDarkhast += If(_row("Tozih").ToString <> "", _row("Tozih").ToString.Replace("تجمیعی درخواست های ", ""), _row("DarkhastNo").ToString) + ","
                Next
                StrDarkhast = StrDarkhast.Substring(0, StrDarkhast.Length - 1)
                Dim Strdarkhast1() As String = StrDarkhast.Split(",")
                For i As Integer = 0 To Strdarkhast1.Length - 1
                    Dim CntDarkhast As Integer = CType(GridKalaForSend.DataSource, DataTable).Compute("Count(DarkhastNo)", "DarkhastNo='" & Strdarkhast1(i).ToString & "'")
                    TozihTitrSanad += Strdarkhast1(i) + " : " + CntDarkhast.ToString + " مورد" + " , "
                Next
                If TozihTitrSanad.EndsWith(", ") Then
                    TozihTitrSanad = "بابت درخواست های " + TozihTitrSanad.Substring(0, TozihTitrSanad.Length - 2)
                End If
            End If

            TozihTitrSanad = "ارزش ریالی حواله : " + CLng(GridKalaForSend.GetTotal(GridKalaForSend.RootTable.Columns("Rial"), Janus.Windows.GridEX.AggregateFunction.Sum)).ToString + "  ریال - " + TozihTitrSanad

            Dim ListTafkikSnStr As String = ""
            Dim ListTafkikSNs As DataTable = New DataView(GridKalaForSend.DataSource, "", "", DataViewRowState.CurrentRows).ToTable(True, "ListTafkikSN")
            For Each _row As DataRow In ListTafkikSNs.Rows
                ListTafkikSnStr += _row("ListTafkikSN").ToString + ","
            Next
            ListTafkikSnStr = ListTafkikSnStr.Substring(0, ListTafkikSnStr.Length - 1)

            Dim ListTafkikHaSNTbl As DataTable = New DataView(GridKalaForSend.DataSource, "", "", DataViewRowState.CurrentRows).ToTable(True, {"ListTafkikSN", "ListTafkikHaSN"})
            Dim l As DataView = New DataView(ListTafkikHaSNTbl, "", "ListTafkikHaSN", DataViewRowState.CurrentRows)

            Dim DarkhastSnTbl As DataTable = New DataView(GridKalaForSend.DataSource, "", "", DataViewRowState.CurrentRows).ToTable(True, "DarkhastSn")
            Dim DarkhastSn As String = ""
            For Each _row As DataRow In DarkhastSnTbl.Rows
                DarkhastSn += _row("DarkhastSn").ToString + ","
            Next
            DarkhastSn = DarkhastSn.Substring(0, DarkhastSn.Length - 1)

            If DarkhastSn = "" Then
                NetSql.Common.CSystem.MsgBox("درخواست متناظر ردیف های موردنظر یافت نشد", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            If ListTafkikSnStr = "" Then
                NetSql.Common.CSystem.MsgBox("لیست تفکیک متناظر  ردیف های موردنظر یافت نشد", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If ListTafkikHaSNTbl.Rows.Count = 0 Then
                NetSql.Common.CSystem.MsgBox("ردیفهای لیست تفکیک متناظر با  ردیف های موردنظر یافت نشد", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            Dim Cntr As String = ""
            Dim waitFRm As New Anbar.Common.Frmwait
            waitFRm.Opacity = 1
            waitFRm.Show()

            Try
                If cn.Connection.State = ConnectionState.Closed Then
                    cn.Connection.Open()
                End If
                cn.BeginTrans(cn.Connection.BeginTransaction)

                Dim SanadSn As Decimal = 0

                cn.CallSP("_abSPC_InsertTitrSandForTafkikDarooei", SanadSn, gSM.Identifier,
                           DarkhastSn, ListTafkikSnStr, TozihTitrSanad, System.Environment.MachineName, gSM.UserName)

                For Counter As Integer = 0 To ListTafkikHaSNTbl.Rows.Count - 1
                    Cntr = (Counter + 1).ToString
                    waitFRm.Label3.Text = "...سیستم در حال ثبت حواله برای " + GridShobe.CurrentRow.Cells("ShobeDS").Text + " می باشد..." _
                                                            + "ثبت " + Cntr + " مورد کالا از " + ListTafkikHaSNTbl.Rows.Count.ToString + " مورد"
                    waitFRm.Refresh()
                    cn.CallSP("_abSPC_InsertDetailSandForTafkikDarooei", gSM.Identifier, SanadSn, ListTafkikHaSNTbl.Rows(Counter)("ListTafkikHaSN"),
                                               gSM.UserID_Name, System.Environment.MachineName, ErrMsg)
                    cn.CallSP("_abSPC_UpdateSanadHaSNInabListTafkikHa", CDec(ListTafkikHaSNTbl.Rows(Counter)("ListTafkikSN")),
                                    ListTafkikHaSNTbl.Rows(Counter)("ListTafkikHaSN").ToString, gSM.Identifier, gSM.UserID_Name, System.Environment.MachineName, ErrMsg)
                Next

                cn.CommitTrans()

                If cn.Connection.State = ConnectionState.Open Then
                    cn.Connection.Close()
                End If
                cn.RollbackTrans()
            Catch ex As Exception
                cn.RollbackTrans()
                NetSql.Common.CSystem.MsgBox(If(Cntr <> "" AndAlso IsNumeric(Cntr),
                                                                "خطا در ردیف " + Cntr + " : ListTafkikHaSN : " + ListTafkikHaSNTbl.Rows(CInt(Cntr) - 1)("ListTafkikHaSN").ToString + vbCr, "") + ex.Message,
                                                                 MsgBoxStyle.Critical, Me.Text)
            Finally
                UpdateListTafkikInformation()
                waitFRm.Close()
            End Try

        End If

    End Sub

    Sub UpdateListTafkikInformation()

        'DvTafkik = _rule.GetTafkikDarooei(cn).Tables(0).DefaultView
        DvKala = DvTafkik.ToTable()

        If Not IsNothing(DvTafkik) AndAlso DvTafkik.Count > 0 Then

            Dim RowIndex As Integer = If(GridShobe.CurrentRow Is Nothing, 0, GridShobe.CurrentRow.RowIndex)

            Dim dtShobe As DataTable = DvTafkik.ToTable(True, {"ShobeSN", "ShobeDS", "CountKala", "SumTedadAdad", "SumTedadKarton", "SumVazn", "SumRial"})

            For Each _row As DataRow In dtShobe.Rows
                Dim dvCalc As DataView = New DataView(DvTafkik.ToTable, "ShobeSN=" & _row("ShobeSN").ToString, "KalaSN", DataViewRowState.CurrentRows)
                Dim Cnt As Integer = 1
                For i As Integer = 1 To dvCalc.Count - 1
                    If dvCalc(i)("KalaSN") <> dvCalc(i - 1)("KalaSN") Then
                        Cnt += 1
                    End If
                Next

                _row.BeginEdit()
                _row("CountKala") = Cnt
                _row("SumTedadAdad") = Math.Round(If(IsDBNull(dvCalc.ToTable.Compute("Sum(TedadAdad)", "")), 0, dvCalc.ToTable.Compute("Sum(TedadAdad)", "")))
                _row("SumTedadKarton") = Math.Round(If(IsDBNull(dvCalc.ToTable.Compute("Sum(TedadKarton)", "")), 0, dvCalc.ToTable.Compute("Sum(TedadKarton)", "")))
                _row("SumVazn") = If(IsDBNull(dvCalc.ToTable.Compute("Sum(Vazn)", "")), 0, dvCalc.ToTable.Compute("Sum(Vazn)", ""))
                _row("SumRial") = If(IsDBNull(dvCalc.ToTable.Compute("Sum(Rial)", "")), 0, dvCalc.ToTable.Compute("Sum(Rial)", ""))
                _row.EndEdit()

            Next
            dtShobe.DefaultView.Sort = "ShobeDS"
            GridShobe.DataSource = dtShobe.DefaultView
            GridShobe.AutoSizeColumns()

            Dim DvKalaForSend2 As DataTable = New DataView(DvKalaForSend).ToTable()
            DvKalaForSend2.Clear()
            Dim ListTafkikHaSNForSend As String = ""

            For Each _row As DataRow In DvKalaForSend.Rows
                DvTafkik.RowFilter = "ListTafkikHaSN In (" & _row("ListTafkikHaSN").ToString & ")"
                If DvTafkik.Count >= 1 Then
                    DvKalaForSend2.ImportRow(_row)
                    ListTafkikHaSNForSend += _row("ListTafkikHaSN").ToString + ","
                End If
                DvTafkik.RowFilter = "0=0"
            Next

            If ListTafkikHaSNForSend.EndsWith(",") Then
                ListTafkikHaSNForSend = ListTafkikHaSNForSend.Substring(0, Len(ListTafkikHaSNForSend) - 1)
                DvKala = New DataView(DvKala, "ListTafkikHaSN Not In (" & ListTafkikHaSNForSend & ")", "", DataViewRowState.CurrentRows).ToTable()
            End If

            DvKalaForSend = DvKalaForSend2
            GridKalaForSend.DataSource = DvKalaForSend
            GridKalaForSend.AutoSizeColumns()
            GridKalaForSend.Refresh()

            GridKala.DataSource = DvKala
            GridKala.AutoSizeColumns()
            GridKala.Refresh()

            If RowIndex <= GridShobe.LastVisibleRow(False) Then
                GridShobe.MoveToRowIndex(RowIndex)
            End If
            GridShobe.Refresh()

        Else
            GridShobe.DataSource = DvTafkik
            GridShobe.AutoSizeColumns()
            GridShobe.Refresh()
            GridKala.DataSource = DvKala
            GridKala.AutoSizeColumns()
            GridKala.Refresh()
            GridEXDarkhast.DataSource = DvKala
            GridEXDarkhast.AutoSizeColumns()
            GridEXDarkhast.Refresh()
            GridKalaForSend.DataSource = DvKala
            GridKalaForSend.AutoSizeColumns()
            GridKalaForSend.Refresh()
        End If

    End Sub

    Private Sub GridKala_LinkClicked(sender As System.Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridKala.LinkClicked
        cn.ExecuteNoneQuery("Update ablistTafkikHa Set DarkhastStatus = " & If(GridKala.CurrentRow.Cells("DarkhastStatus").Value = 2, 1, 2) & " Where ListTafkikHaSN =" & GridKala.CurrentRow.Cells("ListTafkikHaSN").Text)
        GridKala.CurrentRow.BeginEdit()
        GridKala.CurrentRow.Cells("DarkhastStatus").Value = If(GridKala.CurrentRow.Cells("DarkhastStatus").Value = 2, 1, 2)
        GridKala.CurrentRow.Cells("abilityForPlanning").Value = If(GridKala.CurrentRow.Cells("DarkhastStatus").Value = 2, "قابل برنامه ریزی", "عدم برنامه ریزی")
        GridKala.CurrentRow.EndEdit()
        GridKala.AutoSizeColumns()
        GridKala.Refresh()
    End Sub

    Private Sub GridEXDarkhast_LinkClicked(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXDarkhast.LinkClicked
        If GridEXDarkhast.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim DarkhastSN As Decimal = GridEXDarkhast.CurrentRow.Cells("DarkhastSN").Value
        Dim DarkhastnO As String = GridEXDarkhast.CurrentRow.Cells("DarkhastNo").Text
        If CSystem.MsgBox("آیا مایل به بایگانی درخواست شماره " + DarkhastnO + " می باشید؟", MsgBoxStyle.YesNo, "بایگانی درخواست") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Frmwait As New Anbar.Common.Frmwait
        Try
            Frmwait.Label3.Text = "...سیستم درحال بایگانی درخواست و بروز رسانی مجدد اطلاعات می باشد..."
            Frmwait.Show()
            Frmwait.Refresh()
            Dim ExecSpBaygani As String = _rule.BayganiDarkhastTafkikShode(cn, DarkhastSN)
            If ExecSpBaygani = "SUCCESS" Then
                Call UpdateListTafkikInformation()
            End If
        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
        Finally
            Frmwait.Close()
        End Try

    End Sub
End Class

