
' OK
'Author ::Zohreh Izadpanah 
'CreateDate ::  1387/02/15
'ModifiedDate::
'Description::  ثبت درخواستهاي انبار
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports VB = Microsoft.VisualBasic
Imports Anbar.BRL
Imports Minoo.Services.Middleware
Imports Minoo.Models.Middleware
Imports NetSql.View

Public Class FrmabTafkik
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
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Public WithEvents sstParent As Minoo.Controls.FTTabControl
    Public WithEvents m_sstParent_TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents FtTabControl3 As Minoo.Controls.FTTabControl
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents FtTabControl1 As Minoo.Controls.FTTabControl
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents FtTabControl2 As Minoo.Controls.FTTabControl
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents Panel7 As System.Windows.Forms.Panel
    Public WithEvents Panel6 As System.Windows.Forms.Panel
    Public WithEvents Panel8 As System.Windows.Forms.Panel
    Public WithEvents BtnPrintListJoz As System.Windows.Forms.Button
    Public WithEvents BtnPrintListKol As System.Windows.Forms.Button
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioDesc As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAsc As System.Windows.Forms.RadioButton
    Friend WithEvents ChkRahgiri As System.Windows.Forms.CheckBox
    Friend WithEvents ChkKalaNO As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMeghdarErsali As System.Windows.Forms.CheckBox
    Friend WithEvents ChkShobe As System.Windows.Forms.CheckBox
    Public WithEvents Panel9 As System.Windows.Forms.Panel
    Public WithEvents Panel12 As System.Windows.Forms.Panel
    Public WithEvents Panel13 As System.Windows.Forms.Panel
    Public WithEvents Panel14 As System.Windows.Forms.Panel
    Public WithEvents Panel15 As System.Windows.Forms.Panel
    Public WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents FontNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbShobe As cmpCheckedComboBox
    Friend WithEvents cmbStatus As cmpCheckedComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents BtnErsal As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cmbShobe_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabTafkik))
        Dim cmbStatus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.sstParent = New Minoo.Controls.FTTabControl()
        Me.m_sstParent_TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.BtnPrintListJoz = New System.Windows.Forms.Button()
        Me.BtnPrintListKol = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbShobe = New cmpCheckedComboBox(Me.components)
        Me.cmbStatus = New cmpCheckedComboBox(Me.components)
        Me.FontNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkShobe = New System.Windows.Forms.CheckBox()
        Me.RadioDesc = New System.Windows.Forms.RadioButton()
        Me.RadioAsc = New System.Windows.Forms.RadioButton()
        Me.ChkRahgiri = New System.Windows.Forms.CheckBox()
        Me.ChkKalaNO = New System.Windows.Forms.CheckBox()
        Me.ChkMeghdarErsali = New System.Windows.Forms.CheckBox()
        Me.BtnErsal = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FtTabControl3 = New Minoo.Controls.FTTabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FtTabControl1 = New Minoo.Controls.FTTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FtTabControl2 = New Minoo.Controls.FTTabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.sstParent.SuspendLayout()
        Me.m_sstParent_TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.FtTabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FtTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FtTabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(7, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size(88, 24)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Tag = ""
        Me.btnFilter.Text = "انتخاب"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'sstParent
        '
        Me.sstParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstParent.Controls.Add(Me.m_sstParent_TabPage1)
        Me.sstParent.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstParent.ItemSize = New System.Drawing.Size(42, 23)
        Me.sstParent.Location = New System.Drawing.Point(3, 4)
        Me.sstParent.Mirrored = True
        Me.sstParent.Name = "sstParent"
        Me.sstParent.SelectedIndex = 0
        Me.sstParent.Size = New System.Drawing.Size(627, 180)
        Me.sstParent.TabIndex = 7
        '
        'm_sstParent_TabPage1
        '
        Me.m_sstParent_TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.m_sstParent_TabPage1.Controls.Add(Me.pnlG)
        Me.m_sstParent_TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.m_sstParent_TabPage1.Name = "m_sstParent_TabPage1"
        Me.m_sstParent_TabPage1.Size = New System.Drawing.Size(619, 149)
        Me.m_sstParent_TabPage1.TabIndex = 1
        Me.m_sstParent_TabPage1.Text = "لیست تفکیک"
        '
        'pnlG
        '
        Me.pnlG.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(0, 0)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(619, 149)
        Me.pnlG.TabIndex = 8
        '
        'BtnPrintListJoz
        '
        Me.BtnPrintListJoz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintListJoz.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrintListJoz.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPrintListJoz.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnPrintListJoz.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPrintListJoz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPrintListJoz.Location = New System.Drawing.Point(170, 219)
        Me.BtnPrintListJoz.Name = "BtnPrintListJoz"
        Me.BtnPrintListJoz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintListJoz.Size = New System.Drawing.Size(128, 33)
        Me.BtnPrintListJoz.TabIndex = 9
        Me.BtnPrintListJoz.Tag = ""
        Me.BtnPrintListJoz.Text = "چاپ لیست تفکیک جزء"
        Me.BtnPrintListJoz.UseVisualStyleBackColor = False
        '
        'BtnPrintListKol
        '
        Me.BtnPrintListKol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintListKol.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrintListKol.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPrintListKol.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnPrintListKol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPrintListKol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPrintListKol.Location = New System.Drawing.Point(170, 185)
        Me.BtnPrintListKol.Name = "BtnPrintListKol"
        Me.BtnPrintListKol.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintListKol.Size = New System.Drawing.Size(128, 33)
        Me.BtnPrintListKol.TabIndex = 8
        Me.BtnPrintListKol.Tag = ""
        Me.BtnPrintListKol.Text = "چاپ لیست تفکیک کل"
        Me.BtnPrintListKol.UseVisualStyleBackColor = False
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
        Me.SplitContainer1.SplitterDistance = 256
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
        Me.SplitContainer4.Size = New System.Drawing.Size(1159, 256)
        Me.SplitContainer4.SplitterDistance = 633
        Me.SplitContainer4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbShobe)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.FontNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnErsal)
        Me.Panel1.Controls.Add(Me.BtnPrintListKol)
        Me.Panel1.Controls.Add(Me.BtnPrintListJoz)
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.sstParent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 256)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "وضعیت:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 14)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "شعبه:"
        '
        'cmbShobe
        '
        Me.cmbShobe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbShobe_DesignTimeLayout.LayoutString = resources.GetString("cmbShobe_DesignTimeLayout.LayoutString")
        Me.cmbShobe.DesignTimeLayout = cmbShobe_DesignTimeLayout
        Me.cmbShobe.LateBinding = True
        Me.cmbShobe.LateBindingTop = "100"
        Me.cmbShobe.Location = New System.Drawing.Point(262, 5)
        Me.cmbShobe.Name = "cmbShobe"
        Me.cmbShobe.SaveSettings = False
        Me.cmbShobe.ShowSelectAll = True
        Me.cmbShobe.Size = New System.Drawing.Size(241, 22)
        Me.cmbShobe.TabIndex = 125
        Me.cmbShobe.ValuesDataMember = Nothing
        Me.cmbShobe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cmbStatus
        '
        cmbStatus_DesignTimeLayout.LayoutString = resources.GetString("cmbStatus_DesignTimeLayout.LayoutString")
        Me.cmbStatus.DesignTimeLayout = cmbStatus_DesignTimeLayout
        Me.cmbStatus.LateBinding = True
        Me.cmbStatus.LateBindingTop = "100"
        Me.cmbStatus.Location = New System.Drawing.Point(100, 5)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.SaveSettings = False
        Me.cmbStatus.ShowSelectAll = True
        Me.cmbStatus.Size = New System.Drawing.Size(97, 22)
        Me.cmbStatus.TabIndex = 126
        Me.cmbStatus.ValuesDataMember = Nothing
        Me.cmbStatus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FontNum
        '
        Me.FontNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontNum.DecimalPlaces = 1
        Me.FontNum.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.FontNum.Location = New System.Drawing.Point(311, 215)
        Me.FontNum.Name = "FontNum"
        Me.FontNum.Size = New System.Drawing.Size(56, 22)
        Me.FontNum.TabIndex = 30
        Me.FontNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FontNum.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "سایز چاپ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ChkShobe)
        Me.GroupBox1.Controls.Add(Me.RadioDesc)
        Me.GroupBox1.Controls.Add(Me.RadioAsc)
        Me.GroupBox1.Controls.Add(Me.ChkRahgiri)
        Me.GroupBox1.Controls.Add(Me.ChkKalaNO)
        Me.GroupBox1.Controls.Add(Me.ChkMeghdarErsali)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(379, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 69)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مرتب سازی چاپ"
        '
        'ChkShobe
        '
        Me.ChkShobe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkShobe.AutoSize = True
        Me.ChkShobe.Checked = True
        Me.ChkShobe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkShobe.Location = New System.Drawing.Point(180, 41)
        Me.ChkShobe.Name = "ChkShobe"
        Me.ChkShobe.Size = New System.Drawing.Size(55, 18)
        Me.ChkShobe.TabIndex = 26
        Me.ChkShobe.Text = "شعبه"
        Me.ChkShobe.UseVisualStyleBackColor = True
        '
        'RadioDesc
        '
        Me.RadioDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioDesc.AutoSize = True
        Me.RadioDesc.Location = New System.Drawing.Point(9, 41)
        Me.RadioDesc.Name = "RadioDesc"
        Me.RadioDesc.Size = New System.Drawing.Size(53, 18)
        Me.RadioDesc.TabIndex = 25
        Me.RadioDesc.Text = "نزولی"
        Me.RadioDesc.UseVisualStyleBackColor = True
        '
        'RadioAsc
        '
        Me.RadioAsc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioAsc.AutoSize = True
        Me.RadioAsc.Checked = True
        Me.RadioAsc.Location = New System.Drawing.Point(1, 17)
        Me.RadioAsc.Name = "RadioAsc"
        Me.RadioAsc.Size = New System.Drawing.Size(61, 18)
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
        Me.ChkRahgiri.Location = New System.Drawing.Point(66, 18)
        Me.ChkRahgiri.Name = "ChkRahgiri"
        Me.ChkRahgiri.Size = New System.Drawing.Size(100, 18)
        Me.ChkRahgiri.TabIndex = 23
        Me.ChkRahgiri.Text = "شماره رهگیری"
        Me.ChkRahgiri.UseVisualStyleBackColor = True
        '
        'ChkKalaNO
        '
        Me.ChkKalaNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkKalaNO.AutoSize = True
        Me.ChkKalaNO.Checked = True
        Me.ChkKalaNO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkKalaNO.Location = New System.Drawing.Point(175, 18)
        Me.ChkKalaNO.Name = "ChkKalaNO"
        Me.ChkKalaNO.Size = New System.Drawing.Size(60, 18)
        Me.ChkKalaNO.TabIndex = 22
        Me.ChkKalaNO.Text = "کد کالا"
        Me.ChkKalaNO.UseVisualStyleBackColor = True
        '
        'ChkMeghdarErsali
        '
        Me.ChkMeghdarErsali.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMeghdarErsali.AutoSize = True
        Me.ChkMeghdarErsali.Checked = True
        Me.ChkMeghdarErsali.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMeghdarErsali.Location = New System.Drawing.Point(72, 41)
        Me.ChkMeghdarErsali.Name = "ChkMeghdarErsali"
        Me.ChkMeghdarErsali.Size = New System.Drawing.Size(94, 18)
        Me.ChkMeghdarErsali.TabIndex = 21
        Me.ChkMeghdarErsali.Text = "مقدار ارسالی"
        Me.ChkMeghdarErsali.UseVisualStyleBackColor = True
        '
        'BtnErsal
        '
        Me.BtnErsal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnErsal.BackColor = System.Drawing.SystemColors.Control
        Me.BtnErsal.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnErsal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnErsal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnErsal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnErsal.Location = New System.Drawing.Point(10, 186)
        Me.BtnErsal.Name = "BtnErsal"
        Me.BtnErsal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnErsal.Size = New System.Drawing.Size(154, 66)
        Me.BtnErsal.TabIndex = 10
        Me.BtnErsal.Tag = ""
        Me.BtnErsal.Text = "تبدیل به حواله (ارسال به انبار شهرستان)"
        Me.BtnErsal.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Controls.Add(Me.FtTabControl3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(522, 256)
        Me.Panel10.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Tag = ""
        Me.Button1.Text = "انتخاب"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FtTabControl3
        '
        Me.FtTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FtTabControl3.Controls.Add(Me.TabPage3)
        Me.FtTabControl3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FtTabControl3.ItemSize = New System.Drawing.Size(42, 23)
        Me.FtTabControl3.Location = New System.Drawing.Point(3, 3)
        Me.FtTabControl3.Mirrored = True
        Me.FtTabControl3.Name = "FtTabControl3"
        Me.FtTabControl3.SelectedIndex = 0
        Me.FtTabControl3.Size = New System.Drawing.Size(516, 238)
        Me.FtTabControl3.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Panel11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(508, 207)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "لیست شعب"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Controls.Add(Me.Panel9)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel11.Size = New System.Drawing.Size(508, 207)
        Me.Panel11.TabIndex = 8
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.SystemColors.Control
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel15.Location = New System.Drawing.Point(213, 161)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel15.Size = New System.Drawing.Size(287, 39)
        Me.Panel15.TabIndex = 14
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel9.Location = New System.Drawing.Point(3, 162)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel9.Size = New System.Drawing.Size(196, 39)
        Me.Panel9.TabIndex = 13
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel12.Size = New System.Drawing.Size(504, 152)
        Me.Panel12.TabIndex = 12
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1159, 279)
        Me.SplitContainer2.SplitterDistance = 633
        Me.SplitContainer2.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.FtTabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 279)
        Me.Panel2.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(6, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Tag = ""
        Me.Button2.Text = "انتخاب"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FtTabControl1
        '
        Me.FtTabControl1.Controls.Add(Me.TabPage1)
        Me.FtTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FtTabControl1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FtTabControl1.ItemSize = New System.Drawing.Size(42, 23)
        Me.FtTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.FtTabControl1.Mirrored = True
        Me.FtTabControl1.Name = "FtTabControl1"
        Me.FtTabControl1.SelectedIndex = 0
        Me.FtTabControl1.Size = New System.Drawing.Size(633, 279)
        Me.FtTabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(625, 248)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "لیست کالا"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel16)
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Panel14)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel3.Size = New System.Drawing.Size(625, 248)
        Me.Panel3.TabIndex = 8
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.SystemColors.Control
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel16.Location = New System.Drawing.Point(329, 204)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel16.Size = New System.Drawing.Size(287, 39)
        Me.Panel16.TabIndex = 16
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.SystemColors.Control
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel13.Location = New System.Drawing.Point(3, 204)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel13.Size = New System.Drawing.Size(196, 39)
        Me.Panel13.TabIndex = 15
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.Control
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel14.Size = New System.Drawing.Size(621, 198)
        Me.Panel14.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.FtTabControl2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(522, 279)
        Me.Panel4.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(6, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button3.Size = New System.Drawing.Size(48, 24)
        Me.Button3.TabIndex = 1
        Me.Button3.Tag = ""
        Me.Button3.Text = "انتخاب"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FtTabControl2
        '
        Me.FtTabControl2.Controls.Add(Me.TabPage2)
        Me.FtTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FtTabControl2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FtTabControl2.ItemSize = New System.Drawing.Size(42, 23)
        Me.FtTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.FtTabControl2.Mirrored = True
        Me.FtTabControl2.Name = "FtTabControl2"
        Me.FtTabControl2.SelectedIndex = 0
        Me.FtTabControl2.Size = New System.Drawing.Size(522, 279)
        Me.FtTabControl2.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(514, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "لیست رهگیری"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel5.Size = New System.Drawing.Size(514, 248)
        Me.Panel5.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.Location = New System.Drawing.Point(3, 204)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel8.Size = New System.Drawing.Size(196, 39)
        Me.Panel8.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.Location = New System.Drawing.Point(194, 204)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel7.Size = New System.Drawing.Size(313, 39)
        Me.Panel7.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel6.Size = New System.Drawing.Size(510, 198)
        Me.Panel6.TabIndex = 9
        '
        'FrmabTafkik
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1159, 539)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmabTafkik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "لیست تفکیک"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sstParent.ResumeLayout(False)
        Me.m_sstParent_TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.FtTabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FtTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FtTabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmabTafkik
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmabTafkik

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabTafkik
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabTafkik)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

#Region "EnumUISanad"

    ' براي کنترل نمايش فيلدهاي سند در تراکنش هاي مختلف
    Private Enum EnumAddField_abSanad
        'afAddsMarjaSanadSN = &H1S
        afAddsTarafHesabSN = &H2S
        afAddsEDAnbarSN = &H4S
        afAddsEDNoeAnbarSN = &H8S
        afAddsEditionNo = &H10S
        afAddsEtelaiSN = &H20S
        afAddsDarkhastSN = &H40S
        afAddsMojavezErsalSN = &H80S
        afAddsWorkOrederSN = &H100S
        afAddsHavalehForooshSN = &H200S
        afAddsNoeMarjooeiSN = &H400S
        afAddsNoeMadomiSN = &H800S
        afAddsShomarehBarnameh = &H1000S
        afAddsShomarehMashin = &H2000S
        afAddsNameRanandeh = &H4000S
        afAddsShomarehSefaresh = &H10000
        afAddsTarafHesab = &H20000
        afAddsVazneBaskool = &H40000
        afAddsShomareh1 = &H80000
        afAddsShomareh2 = &H100000
        afAddsTafsiliSN1 = &H200000
    End Enum

    ' براي کنترل نمايش فيلدهاي اقلام سند
    Private Enum EnumAddField_abSanadHa
        afAddsGorooheKalaSN = &H1S
        afAddsKalaSN = &H2S
        afAddsTartib = &H4S
        afAddsMeghdareDarkhasti = &H8S
        afAddsMeghdareVaredeh = &H10S
        afAddsGheymateVaredeh = &H20S
        afAddsMeghdareSadereh = &H40S
        afAddsGheymateSadereh = &H80S
        afAddsSeriSakht = &H100S
        afAddsNoeZayeatSN = &H200S
        afAddsNoeMarjooeiSN2 = &H400S
        afAddsNoeMadomiSN2 = &H800S
        afAddsMeghdareNakhales = &H1000S
        afAddTafsiliSN1 = &H2000S
        ' تعداد ظرف
    End Enum

#End Region

#Region "PrivateVariabledDefinition"

    Private WithEvents DVTafkik As CDataView
    Private WithEvents DVTafkikShobe As CDataView
    Private WithEvents DVTafkikKala As CDataView
    Private WithEvents DVTafkikRahgiri As CDataView
    Private VNoeVoroodeAsnad As EnumNoeVoroodeAsnad
    Private WithEvents dbcSefaresheKarBatch As NetSql.Components.DataCombo
    Private WithEvents vfgDarkhast As AxVSFlexGrid
    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl
    Private WithEvents dbcKala As NetSql.Components.DataCombo

    Private Karton As Integer
    Private Tedad As Integer
    Private CurKarton As Integer
    Private CurTedad As Integer
    Private SelectedChanged As Boolean
    Private gDarkhastkala As Integer

    Public TypeghazaDaroo As Integer


#End Region

    '//ناحيه تعريف متغيرهاي Local

    Private Enum DarkhastStatus
        movaghat = 1
        Taeed = 4
        darhaleersal = 8
        Ersal = 16
        Baigani = 12
    End Enum

    Private Sub CMP_SetDef_CheckedValues(ByRef aCmp As cmpCheckedComboBox, Optional ByVal aDefults As Decimal = 0.0)
        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(aDefults)
        aCmp.CheckedValues = ArrayLst.ToArray
        aCmp.DroppedDown = True
    End Sub


    Private Sub FrmabTafkik_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim vShobeSql As String
        vShobeSql = SetShobeComboCMP(cmbShobe, True, True, False)
        If TypeghazaDaroo = 0 Then
            cmbShobe.Visible = False
            Label6.Visible = False
        Else
            cmbShobe.Visible = True
            Label6.Visible = True
        End If

        Dim vStatusSql As String
        vStatusSql = SetStatusComboCMP(cmbStatus, True, True, False)
        'If TypeghazaDaroo = 0 Then
        '    cmbStatus.Enabled = False
        'Else
        '    cmbStatus.Enabled = True
        'End If

        DVTafkik = New CDataView(cn)
        DVTafkikShobe = New CDataView(cn)
        DVTafkikKala = New CDataView(cn)
        DVTafkikRahgiri = New CDataView(cn)

        InitDVTafkik()
        InitDVTafkikShobe()
        InitDVTafkikKala()
        InitDVTafkikRahgiri()

        DVTafkikShobe.Parent = DVTafkik
        DVTafkikKala.Parent = DVTafkikShobe
        DVTafkikRahgiri.Parent = DVTafkikKala

        FillDVTafkik()
        FillDVTafkikShobe()
        FillDVTafkikKala()
        FillDVTafkikRahgiri()

        FontNum.ThousandsSeparator = True

    End Sub

    Friend Function SetShobeComboCMP(ByRef cmbShobe As cmpCheckedComboBox, ByVal withAllItems As Boolean, ByVal preSelected As Boolean, ByVal onlypreSelected As Boolean)

        Dim vShobeSql As String

        If TypeghazaDaroo = 0 Then
            vShobeSql = "select ShoabSN , VahedeTejariDs from ablistTafkik join ablistTafkikha on ablistTafkik.listTafkikSN =ablistTafkikha.listTafkikSN  join paVahedeTejari on paVahedeTejari.VahedeTejariSN =ablistTafkikha.ShoabSN  where AnbarSN <> 344.101  group by ShoabSN , VahedeTejariDs "
        Else
            vShobeSql = "select ShoabSN , VahedeTejariDs from ablistTafkik join ablistTafkikha on ablistTafkik.listTafkikSN =ablistTafkikha.listTafkikSN  join paVahedeTejari on paVahedeTejari.VahedeTejariSN =ablistTafkikha.ShoabSN  where AnbarSN = 344.101  group by ShoabSN , VahedeTejariDs "
        End If

        cmbShobe.Enabled = True


        cmbShobe.ShowSelectAll = withAllItems

        cmbShobe.Bind(cn, vShobeSql, "ShoabSN", "VahedeTejariDs")

        If preSelected Then CMP_SetDef_CheckedValues(cmbShobe)

        'If NoeConnection = Connection.Sherkati Then
        '    CMP_SetDef_CheckedValues(cmbTaminKonadeh, gVahedeTejariSN)
        '    cmbTaminKonadeh.Enabled = False
        'Else
        '    If preSelected Then CMP_SetDef_CheckedValues(cmbTaminKonadeh)

        'End If

    End Function

    Friend Function SetStatusComboCMP(ByRef cmbStatus As cmpCheckedComboBox, ByVal withAllItems As Boolean, ByVal preSelected As Boolean, ByVal onlypreSelected As Boolean)

        Dim vStatusSql As String

        'If TypeghazaDaroo = 0 Then
        '    vShobeSql = "select ShoabSN , VahedeTejariDs from ablistTafkik join ablistTafkikha on ablistTafkik.listTafkikSN =ablistTafkikha.listTafkikSN  join paVahedeTejari on paVahedeTejari.VahedeTejariSN =ablistTafkikha.ShoabSN  where AnbarSN <> 344.101  group by ShoabSN , VahedeTejariDs "
        'Else
        vStatusSql = "select SanadStatusSN,SanadStatusDS from abSanadStatus where SanadStatusSN in (4,8)  "
        'End If

        cmbStatus.Enabled = True


        cmbStatus.ShowSelectAll = withAllItems

        cmbStatus.Bind(cn, vStatusSql, "SanadStatusSN", "SanadStatusDS")

        If preSelected Then CMP_SetDef_CheckedValues(cmbStatus)


    End Function

    Private Sub InitDVTafkik()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vMinDateSetting As String ', vMaxDateSetting
        Dim vMaxDate, vMinDate As String
        Dim vSysDate As String

        ' تهيه تاريخ از سرور
        vSysDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        vMaxDate = gHesabdariSalTDate
        vMinDate = VB.Left(vSysDate, 2) + "0101"
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabDarkhast", vMinDate)

        With DVTafkik

            .Init(pnlG, , , , _
                   EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit)
            .TableName = "ablistTafkik"

            .AddJoin("ablistTafkik", EnumTableJoin.tjLeftJoin, "paVahedeTejari", "TaminkonandehSN", "VahedeTejariSN")
            .AddJoin("ablistTafkik", EnumTableJoin.tjLeftJoin, "abSanadStatus", "Status", "SanadStatusSN")
            vfgDarkhast = .FlexGrid
            .AccessRight = gSM.TableAccessRight("ablistTafkik")
            .EditInGrid = False
            If TypeghazaDaroo = 0 Then
                .SQLWhere = " AnbarSn<>344.101"
            Else
                .SQLWhere = " AnbarSn=344.101"
            End If

            .SQLOrderBy = "ListTafkikNO Desc"
            DVTafkik.FlexGrid.Editable = EditableSettings.flexEDKbdMouse

            With .Fields

                With .Add("listTafkikSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With

                With .Add("ListTafkikNO", , EnumFieldOptions.foDefault)
                    .Caption = "شماره لیست تفکیک"
                    .MinComponentWidth = 50
                End With

                With .Add("SabtDate", , EnumFieldOptions.foDate)
                    .Caption = "تاريخ تفکیک"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("TaminkonandehSN->paVahedeTejari.VahedeTejariDs AS VahedeTejariDs", , EnumFieldOptions.foDefault)
                    .Caption = "تامین کننده"
                End With

                With .Add("Status->abSanadStatus.SanadStatusDS AS Status", , EnumFieldOptions.foDefault)
                    .Caption = "وضعیت"
                End With

                With .Add("EndDate", , EnumFieldOptions.foDefault)
                    .Caption = "تاريخ قطعی"
                    '.MinComponentWidth = 80
                End With

            End With

        End With

    End Sub

    Private Sub InitDVTafkikShobe()
        Dim Param(2) As String

        With DVTafkikShobe

            .Init(Panel12, , Panel15, Panel9, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abVw_abListTafkikShobe"
            '.AccessRight = gSM.TableAccessRight("ablistTafkikha")
            .EditInGrid = True
            .SQLWhere = "1=1"
            .AddJoin("abVw_abListTafkikShobe", EnumTableJoin.tjLeftJoin, "paVahedeTejari", "ShoabSN", "VahedeTejariSN")
            With .Fields

                With .Add("listTafkikSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("ShoabSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With _
                    .Add("ShoabSN ->{paVahedeTejari.VahedeTejariDS} AS VahedeTejariDS", , EnumFieldOptions.foDefault)
                    .Caption = "شعبه"
                    dbcKala = .Component
                End With

            End With

        End With

    End Sub

    Private Sub InitDVTafkikKala()
        Dim Param(2) As String

        With DVTafkikKala

            .Init(Panel14, , Panel16, Panel13, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abVw_abListTafkikShobeKala"
            '.AccessRight = gSM.TableAccessRight("ablistTafkikha")
            .EditInGrid = True
            .SQLWhere = "1=1"
            .AddJoin("abVw_abListTafkikShobeKala", EnumTableJoin.tjLeftJoin, "Pakala", "KalaSN", "KalaSN")
            With .Fields

                With .Add("listTafkikSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("ShoabSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("KalaSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With _
                    .Add("KalaSN ->{Pakala.KalaNO} AS KalaNO", , EnumFieldOptions.foDefault)
                    .Caption = "کد کالا"
                    dbcKala = .Component
                End With

                With _
                    .Add("KalaSN ->{Pakala.KalaDS} AS KalaDS", , EnumFieldOptions.foDefault)
                    .Caption = "نام کالا"
                    dbcKala = .Component
                End With

            End With

        End With

    End Sub

    Private Sub InitDVTafkikRahgiri()
        Dim Param(2) As String

        With DVTafkikRahgiri

            .Init(Panel6, , Panel7, Panel8, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
              Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdPrint)
            .TableName = "ablistTafkikha"
            .AccessRight = gSM.TableAccessRight("ablistTafkikha")
            .EditInGrid = True
            .DeleteSPName = "_ablistTafkikha_DeleteX"
            .InsertSPName = "_ablistTafkikha_InsertX"
            .UpdateSPName = "_ablistTafkikha_UpdateX"
            .InsertSPUserParam = " "
            .SQLWhere = "1=1"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abKalaphiziki", "KalaphizikiSN", "KalaphizikiSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_Darkhast", "DarkhastKalaSN", "DarkhastKalaSN")

            With .Fields

                With .Add("listTafkikhaSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("listTafkikSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("ShoabSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("KalaSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With

                With _
                    .Add("KalaphizikiSN ->{abKalaphiziki.ShomarehRahgiri} AS ShomarehRahgiri", , EnumFieldOptions.foDefault)
                    .Caption = "رهگیری"
                    'dbcKala = .Component
                End With

                With .Add("MeghdareDarkhasti", , EnumFieldOptions.foDefault)
                    .Caption = "مقدار درخواستی"
                End With

                With .Add("MeghdareErsali", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار ارسالی"
                End With

                With .Add("abVw_Darkhast.DarkhastNO", , EnumFieldOptions.foDefault)
                    .Caption = "شماره درخواست"
                End With

            End With

        End With

    End Sub

    Private Sub DVTafkik_AfterCommandClick(aCommand As NetSql.View.CEnum.EnumCommands) Handles DVTafkik.AfterCommandClick

    End Sub

    Private Sub DVTafkik_CommandClick(aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles DVTafkik.CommandClick

    End Sub

    Private Sub DVTafkik_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVTafkik.FillDetailsWithData

        'DVTafkikShobe.SQLWhere = "listTafkikSN =" & DVTafkik.Fields("listTafkikSN").Value

        'DVTafkikShobe.Refresh()
        FillDVTafkikShobe()
    End Sub

    Private Sub DVTafkikShobe_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVTafkikShobe.FillDetailsWithData

        'DVTafkikKala.SQLWhere = "listTafkikSN =" & DVTafkikShobe.Fields("listTafkikSN").Value & " AND ShoabSN =" & DVTafkikShobe.Fields("ShoabSN").Value

        'DVTafkikKala.Refresh()
        FillDVTafkikKala()
    End Sub

    Private Sub DVTafkikKala_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVTafkikKala.FillDetailsWithData
        FillDVTafkikRahgiri()
        'DVTafkikKala.SQLWhere = "listTafkikSN =" & DVTafkikShobe.Fields("listTafkikSN").Value & " AND ShoabSN =" & DVTafkikShobe.Fields("ShoabSN").Value
    End Sub

    Private Sub DVTafkikRahgiri_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVTafkikRahgiri.FillDetailsWithData

        'DVTafkikRahgiri.SQLWhere = "listTafkikSN =" & DVTafkikKala.Fields("listTafkikSN").Value & " AND ShoabSN =" & DVTafkikKala.Fields("ShoabSN").Value & " AND KalaSN =" & DVTafkikKala.Fields("KalaSN").Value
    End Sub

    Private Sub FrmabTafkik_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed



        If Not DVTafkik Is Nothing Then

            DVTafkik.Done()
            DVTafkik = Nothing

        End If

        If Not DVTafkikShobe Is Nothing Then

            DVTafkikShobe.Done()
            DVTafkikShobe = Nothing

        End If

        If Not DVTafkikRahgiri Is Nothing Then

            DVTafkikRahgiri.Done()
            DVTafkikRahgiri = Nothing

        End If

    End Sub

    Private Sub FillDVTafkik()
        DVTafkik.Refresh()
    End Sub

    Private Sub FillDVTafkikShobe()
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات سند بروز رساني ميگردد
        'If DVTafkik.Fields("listTafkikSN").Value is Not 
        If Val(DVTafkik.Fields("listTafkikSN").Value) <> 0 Then
            DVTafkikShobe.SQLWhere = "listTafkikSN =" & DVTafkik.Fields("listTafkikSN").Value
            DVTafkikShobe.Refresh()
        End If

    End Sub

    Private Sub FillDVTafkikKala()
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات سند بروز رساني ميگردد
        If Val(DVTafkikShobe.Fields("listTafkikSN").Value) <> 0 And Val(DVTafkikShobe.Fields("ShoabSN").Value) <> 0 Then
            DVTafkikKala.SQLWhere = "listTafkikSN =" & DVTafkikShobe.Fields("listTafkikSN").Value & " AND ShoabSN =" & DVTafkikShobe.Fields("ShoabSN").Value
            DVTafkikKala.Refresh()
        End If

    End Sub

    Private Sub FillDVTafkikRahgiri()
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات سند بروز رساني ميگردد
        If Val(DVTafkikKala.Fields("listTafkikSN").Value) <> 0 And Val(DVTafkikKala.Fields("ShoabSN").Value) <> 0 And Val(DVTafkikKala.Fields("KalaSN").Value) <> 0 Then
            DVTafkikRahgiri.SQLWhere = "listTafkikSN =" & DVTafkikKala.Fields("listTafkikSN").Value & " AND ShoabSN =" & DVTafkikKala.Fields("ShoabSN").Value & " AND ablistTafkikha.KalaSN =" & DVTafkikKala.Fields("KalaSN").Value
            DVTafkikRahgiri.Refresh()
        End If

    End Sub

    ''Add By Dehghani 930808
    Private Sub BtnPrintListKol_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintListKol.Click

        Dim OrderByString As String = "Cast(vahedetejariNO as int) " + If(RadioAsc.Checked, "ASC,", "DESC,")

        If ChkKalaNO.Checked Then
            OrderByString += " KalaNo " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        If ChkRahgiri.Checked Then
            OrderByString += " ShomarehRahgiri " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        'If ChkMeghdarErsali.Checked Then
        '    OrderByString += " Karton * TedadDarKarton + Adad " + If(RadioAsc.Checked, "ASC,", "DESC,")
        'End If

        OrderByString = OrderByString.Substring(0, OrderByString.Length - 1)
        Dim TafkikValues As String = ""
        For i As Integer = 0 To DVTafkik.FlexGrid.SelectedRows - 1
            TafkikValues += DVTafkik.FlexGrid.ValueMatrix(DVTafkik.FlexGrid.SelectedRow(i), DVTafkik.FlexGrid.ColIndex("ListTafkikSN")).ToString + ","
        Next
        If TafkikValues.EndsWith(",") Then
            TafkikValues = TafkikValues.Substring(0, Len(TafkikValues) - 1)
        End If

        Dim Dv As New DataView
        Dv = cn.ExecuteQuery("abSPG_GetDataForPrintListTafkik '" & TafkikValues & "','" & OrderByString & "',0")
        If Dv.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست تفکیک کل برای تامین کننده انتخاب شده وجود ندارد", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            Exit Sub
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
            .DataSource = Dv

            Try
                Minoo.Reports.FTReportViewer.ShowReport(ListTafkikKol, CSanad.gMDIParent)
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در نمایش گزارش لیست تفکیک کل", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
            End Try

        End With

    End Sub

    ''Add By Dehghani 930808
    Private Sub BtnPrintListJoz_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintListJoz.Click

        Dim OrderByString As String = "VahedeTejariDS  " + If(RadioAsc.Checked, "ASC,", "DESC,")

        If ChkKalaNO.Checked Then
            OrderByString += " KalaNo " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        If ChkRahgiri.Checked Then
            OrderByString += " ShomarehRahgiri " + If(RadioAsc.Checked, "ASC,", "DESC,")
        End If
        'If ChkMeghdarErsali.Checked Then
        '    OrderByString += " Karton * TedadDarKarton + Adad " + If(RadioAsc.Checked, "ASC,", "DESC,")
        'End If

        OrderByString = OrderByString.Substring(0, OrderByString.Length - 1)
        Dim TafkikValues As String = ""
        For i As Integer = 0 To DVTafkik.FlexGrid.SelectedRows - 1
            TafkikValues += DVTafkik.FlexGrid.ValueMatrix(DVTafkik.FlexGrid.SelectedRow(i), DVTafkik.FlexGrid.ColIndex("ListTafkikSN")).ToString + ","
        Next
        If TafkikValues.EndsWith(",") Then
            TafkikValues = TafkikValues.Substring(0, Len(TafkikValues) - 1)
        End If
        Dim str As String = "abSPG_GetDataForPrintListTafkik '" & TafkikValues & "','" & OrderByString & "',1"
        Dim Dv As New DataView
        Dv = cn.ExecuteQuery(str)

        If Dv.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("لیست تفکیک جزء برای تامین کننده انتخاب شده وجود ندارد", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, " ")
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

    Private Sub RadioAsc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioAsc.CheckedChanged
        If RadioAsc.Checked = True Then
            RadioDesc.Checked = False
        End If
    End Sub

    Private Sub RadioDesc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioDesc.CheckedChanged
        If RadioDesc.Checked = True Then
            RadioAsc.Checked = False
        End If
    End Sub

    Private Sub BtnErsal_Click(sender As System.Object, e As System.EventArgs) Handles BtnErsal.Click
        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer

        If _
            NetSql.Common.CSystem.MsgBox("آيا براي ارسال درخواست به انبار شهرستان مطمئن هستيد؟", _
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or _
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "ارسال به انبار شهرستان") = MsgBoxResult.Yes Then

            Try
                If cn.Connection.State = ConnectionState.Closed Then
                    cn.Connection.Open()
                End If
                cn.BeginTrans(cn.Connection.BeginTransaction)
                cn.CallSP("_abSPC_ChangeListTafkikStatus", Val(DVTafkik.Fields("listTafkikSN").Value), gSM.Identifier, _
                           gSM.UserID_Name, System.Environment.MachineName, ErrMsg)

                cn.CallSP("_abSPC_UpdateSanadHaSNInabListTafkikHa", Val(DVTafkik.Fields("listTafkikSN").Value), "", gSM.Identifier, _
                           gSM.UserID_Name, System.Environment.MachineName, ErrMsg)

                cn.CommitTrans()

                If cn.Connection.State = ConnectionState.Open Then
                    cn.Connection.Close()
                End If
                cn.RollbackTrans()
            Catch ex As Exception
                cn.RollbackTrans()
                NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            End Try


            'btnDarkhastErsalAll.Enabled = gSM.TableAccessRight("btnDarkhastErsalAll") = EnumAccessRight.arAll

            Key = DVTafkik.CurrentKey
            DVTafkik.Refresh()
            DVTafkik.CurrentKey = Key
        End If
    End Sub

    Private Sub DVTafkik_GetGridProperties() Handles DVTafkik.GetGridProperties
        With DVTafkik.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub cmbShobe_TextChanged(sender As Object, e As System.EventArgs) Handles cmbShobe.TextChanged

        'Dim _StrShoab As String = cmbShobe.getStringValues()
        'Dim ShoabSN As DataView
        'Dim StrlistTafkikSN As String = ""

        'If TypeghazaDaroo = 1 Then
        '    DVTafkik.SQLWhere = "AnbarSN=344.101 "
        'Else
        '    DVTafkik.SQLWhere = "AnbarSN<>344.101 "
        'End If

        'Dim _StatusStr As String = cmbStatus.getStringValues()
        'If Not _StatusStr Is Nothing And _StatusStr <> "0.000" Then
        '    DVTafkik.SQLWhere = DVTafkik.SQLWhere + " And Status in (" & _StatusStr & ")"
        'End If

        'If Not _StrShoab Is Nothing And _StrShoab <> "0.000" Then
        '    With DVTafkik
        '        Try
        '            ShoabSN = cn.ExecuteQuery("select ablistTafkik.listTafkikSN from ablistTafkik join ablistTafkikha on ablistTafkik.listTafkikSN =ablistTafkikha.listTafkikSN where ablistTafkik.AnbarSN=344.101 and ShoabSN in (" + _Str + ")")
        '            For i As Integer = 0 To ShoabSN.Count - 1
        '                If i = ShoabSN.Count - 1 Then
        '                    StrlistTafkikSN = StrlistTafkikSN + ShoabSN.Table.Rows(i).Item(0).ToString
        '                Else
        '                    StrlistTafkikSN = StrlistTafkikSN + ShoabSN.Table.Rows(i).Item(0).ToString + ","
        '                End If
        '            Next

        '        Catch ex As Exception
        '            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        '            Exit Sub
        '        End Try
        '        .SQLWhere = .SQLWhere + " and listTafkikSN in (" & StrlistTafkikSN & ")"
        '        .Refresh()
        '    End With
        'ElseIf _StrShoab = "0.000" Then
        '    With DVTafkik
        '        .Refresh()
        '    End With
        'Else
        '    With DVTafkik
        '        .Refresh()
        '    End With
        'End If

    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click
        Dim _StrShoab As String = cmbShobe.getStringValues()
        Dim ShoabSN As DataView
        Dim StrlistTafkikSN As String = ""

        If TypeghazaDaroo = 1 Then
            DVTafkik.SQLWhere = "AnbarSN=344.101 "
        Else
            DVTafkik.SQLWhere = "AnbarSN<>344.101 "
        End If

        Dim _StatusStr As String = cmbStatus.getStringValues()
        If Not _StatusStr Is Nothing And _StatusStr <> "0.000" And _StatusStr <> "0" Then
            DVTafkik.SQLWhere = DVTafkik.SQLWhere + " And Status in (" & _StatusStr & ")"
        End If

        If TypeghazaDaroo = 1 And Not _StrShoab Is Nothing And _StrShoab <> "0.000" And _StrShoab <> "0" Then
            With DVTafkik
                Try
                    ShoabSN = cn.ExecuteQuery("select distinct ablistTafkik.listTafkikSN from ablistTafkik join ablistTafkikha on ablistTafkik.listTafkikSN =ablistTafkikha.listTafkikSN where ablistTafkik.AnbarSN=344.101 and ShoabSN in (" + _StrShoab + ")")
                    For i As Integer = 0 To ShoabSN.Count - 1
                        If i = ShoabSN.Count - 1 Then
                            StrlistTafkikSN = StrlistTafkikSN + ShoabSN.Table.Rows(i).Item(0).ToString
                        Else
                            StrlistTafkikSN = StrlistTafkikSN + ShoabSN.Table.Rows(i).Item(0).ToString + ","
                        End If
                    Next

                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End Try
                .SQLWhere = .SQLWhere + " and listTafkikSN in (" & StrlistTafkikSN & ")"
                .Refresh()
            End With
        ElseIf _StrShoab = "0.000" Then
            With DVTafkik
                .Refresh()
            End With
        Else
            With DVTafkik
                .Refresh()
            End With
        End If
    End Sub

End Class

