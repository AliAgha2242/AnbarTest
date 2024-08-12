
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

Public Class FrmabDarkhast
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnln0 As System.Windows.Forms.Panel
    Friend WithEvents pnlc0 As System.Windows.Forms.Panel
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Public WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Tab2 As Minoo.Controls.FTTabControl
    Friend WithEvents tabp2 As System.Windows.Forms.TabPage
    Friend WithEvents pnlnKala As System.Windows.Forms.Panel
    Friend WithEvents pnlGKala As System.Windows.Forms.Panel
    Friend WithEvents pnlcKala As System.Windows.Forms.Panel
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoTaeed As System.Windows.Forms.RadioButton
    Friend WithEvents RdoBaygani As System.Windows.Forms.RadioButton
    Friend WithEvents RdoErsalShode As System.Windows.Forms.RadioButton
    Friend WithEvents PnlNBatch As System.Windows.Forms.Panel
    Friend WithEvents PnlGBatch As System.Windows.Forms.Panel
    Friend WithEvents PnlCBatch As System.Windows.Forms.Panel
    Friend WithEvents btnDarkhastBaygani As System.Windows.Forms.Button
    Friend WithEvents btnDarkhastTaeed As System.Windows.Forms.Button
    Friend WithEvents btnDarkhastErsalAll As System.Windows.Forms.Button
    Public WithEvents sstParent As Minoo.Controls.FTTabControl
    Public WithEvents m_sstParent_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents m_sstParent_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents pnlD As System.Windows.Forms.Panel
    Public WithEvents txtDarkhastNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtVazneBaskool As System.Windows.Forms.TextBox
    Public WithEvents txtNameRanandeh As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehMashin As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehBarnameh As System.Windows.Forms.TextBox
    Public WithEvents lblVazneBaskool As System.Windows.Forms.Label
    Public WithEvents lblNameRanandeh As System.Windows.Forms.Label
    Public WithEvents lblShomarehMashin As System.Windows.Forms.Label
    Public WithEvents lblShomarehBarnameh As System.Windows.Forms.Label
    Public WithEvents txtShomarehSefaresh As System.Windows.Forms.TextBox
    Public WithEvents lblShomarehSefaresh As System.Windows.Forms.Label
    Public WithEvents dbcTarakoneshSN As NetSql.Components.DataCombo
    Public WithEvents lblTarakoneshSN As System.Windows.Forms.Label
    Public WithEvents txtDarkhastDS As System.Windows.Forms.TextBox
    Public WithEvents lblSanadDate As System.Windows.Forms.Label
    Public WithEvents txtToDate As System.Windows.Forms.TextBox
    Public WithEvents dbcTarafHesabSN As NetSql.Components.DataCombo
    Public WithEvents lblTarafHesabSN As System.Windows.Forms.Label
    Friend WithEvents lblTarafHesab As System.Windows.Forms.Label
    Public WithEvents txtTarafHesab As System.Windows.Forms.TextBox
    Public WithEvents dbcTafsiliSN1 As NetSql.Components.DataCombo
    Public WithEvents lblTafsiliSN1 As System.Windows.Forms.Label
    Friend WithEvents RdoMovaghat As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrintDarkhast As System.Windows.Forms.Button
    Friend WithEvents btndarjasan As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtMojoodi_GhabeleErsal As System.Windows.Forms.TextBox
    Friend WithEvents lblMojoodi_GhabeleErsal As System.Windows.Forms.Label
    Friend WithEvents txtMojoodi_TahteBarrasi As System.Windows.Forms.TextBox
    Friend WithEvents lblMojoodi_TahteBarrasi As System.Windows.Forms.Label
    Friend WithEvents txtMojoodi_TahteBarrasiePayekar As System.Windows.Forms.TextBox
    Friend WithEvents lblMojoodi_TahteBarrasiePayekar As System.Windows.Forms.Label
    Friend WithEvents txtMojoodi_GhabeleErsalePayekar As System.Windows.Forms.TextBox
    Friend WithEvents lblMojoodi_GhabeleErsalePayekar As System.Windows.Forms.Label
    Friend WithEvents btnTafkik As System.Windows.Forms.Button
    Friend WithEvents RdoTafkikMovaghat As RadioButton
    Friend WithEvents btnHazfDarkhastErsalnashodeh As Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnHazfDarkhastErsalnashodeh = New System.Windows.Forms.Button()
        Me.btnTafkik = New System.Windows.Forms.Button()
        Me.btndarjasan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoTafkikMovaghat = New System.Windows.Forms.RadioButton()
        Me.RdoMovaghat = New System.Windows.Forms.RadioButton()
        Me.RdoTaeed = New System.Windows.Forms.RadioButton()
        Me.RdoBaygani = New System.Windows.Forms.RadioButton()
        Me.RdoErsalShode = New System.Windows.Forms.RadioButton()
        Me.btnPrintDarkhast = New System.Windows.Forms.Button()
        Me.btnDarkhastBaygani = New System.Windows.Forms.Button()
        Me.pnln0 = New System.Windows.Forms.Panel()
        Me.pnlc0 = New System.Windows.Forms.Panel()
        Me.btnDarkhastTaeed = New System.Windows.Forms.Button()
        Me.btnDarkhastErsalAll = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.txtMinDate = New System.Windows.Forms.TextBox()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.sstParent = New Minoo.Controls.FTTabControl()
        Me.m_sstParent_TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.m_sstParent_TabPage0 = New System.Windows.Forms.TabPage()
        Me.pnlD = New System.Windows.Forms.Panel()
        Me.txtDarkhastDS = New System.Windows.Forms.TextBox()
        Me.lblTarafHesab = New System.Windows.Forms.Label()
        Me.txtTarafHesab = New System.Windows.Forms.TextBox()
        Me.dbcTafsiliSN1 = New NetSql.Components.DataCombo(Me.components)
        Me.lblTafsiliSN1 = New System.Windows.Forms.Label()
        Me.dbcTarafHesabSN = New NetSql.Components.DataCombo(Me.components)
        Me.lblTarafHesabSN = New System.Windows.Forms.Label()
        Me.lblSanadDate = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.TextBox()
        Me.dbcTarakoneshSN = New NetSql.Components.DataCombo(Me.components)
        Me.lblTarakoneshSN = New System.Windows.Forms.Label()
        Me.txtShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.lblShomarehSefaresh = New System.Windows.Forms.Label()
        Me.txtVazneBaskool = New System.Windows.Forms.TextBox()
        Me.txtNameRanandeh = New System.Windows.Forms.TextBox()
        Me.txtShomarehMashin = New System.Windows.Forms.TextBox()
        Me.txtShomarehBarnameh = New System.Windows.Forms.TextBox()
        Me.lblVazneBaskool = New System.Windows.Forms.Label()
        Me.lblNameRanandeh = New System.Windows.Forms.Label()
        Me.lblShomarehMashin = New System.Windows.Forms.Label()
        Me.lblShomarehBarnameh = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDarkhastNo = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Tab2 = New Minoo.Controls.FTTabControl()
        Me.tabp2 = New System.Windows.Forms.TabPage()
        Me.txtMojoodi_TahteBarrasiePayekar = New System.Windows.Forms.TextBox()
        Me.lblMojoodi_TahteBarrasiePayekar = New System.Windows.Forms.Label()
        Me.txtMojoodi_GhabeleErsalePayekar = New System.Windows.Forms.TextBox()
        Me.lblMojoodi_GhabeleErsalePayekar = New System.Windows.Forms.Label()
        Me.txtMojoodi_TahteBarrasi = New System.Windows.Forms.TextBox()
        Me.lblMojoodi_TahteBarrasi = New System.Windows.Forms.Label()
        Me.txtMojoodi_GhabeleErsal = New System.Windows.Forms.TextBox()
        Me.lblMojoodi_GhabeleErsal = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlnKala = New System.Windows.Forms.Panel()
        Me.pnlGKala = New System.Windows.Forms.Panel()
        Me.pnlcKala = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnlNBatch = New System.Windows.Forms.Panel()
        Me.PnlGBatch = New System.Windows.Forms.Panel()
        Me.PnlCBatch = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.sstParent.SuspendLayout()
        Me.m_sstParent_TabPage1.SuspendLayout()
        Me.m_sstParent_TabPage0.SuspendLayout()
        Me.pnlD.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.tabp2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnHazfDarkhastErsalnashodeh)
        Me.Panel4.Controls.Add(Me.btnTafkik)
        Me.Panel4.Controls.Add(Me.btndarjasan)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnPrintDarkhast)
        Me.Panel4.Controls.Add(Me.btnDarkhastBaygani)
        Me.Panel4.Controls.Add(Me.pnln0)
        Me.Panel4.Controls.Add(Me.pnlc0)
        Me.Panel4.Controls.Add(Me.btnDarkhastTaeed)
        Me.Panel4.Controls.Add(Me.btnDarkhastErsalAll)
        Me.Panel4.Controls.Add(Me.Frame1)
        Me.Panel4.Controls.Add(Me.btnFilter)
        Me.Panel4.Controls.Add(Me.sstParent)
        Me.Panel4.Controls.Add(Me.lblInfo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1140, 325)
        Me.Panel4.TabIndex = 47
        '
        'btnHazfDarkhastErsalnashodeh
        '
        Me.btnHazfDarkhastErsalnashodeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHazfDarkhastErsalnashodeh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHazfDarkhastErsalnashodeh.Location = New System.Drawing.Point(334, 282)
        Me.btnHazfDarkhastErsalnashodeh.Name = "btnHazfDarkhastErsalnashodeh"
        Me.btnHazfDarkhastErsalnashodeh.Size = New System.Drawing.Size(88, 37)
        Me.btnHazfDarkhastErsalnashodeh.TabIndex = 24
        Me.btnHazfDarkhastErsalnashodeh.Text = "برگرداندن به حالت موقت"
        Me.btnHazfDarkhastErsalnashodeh.Visible = False
        '
        'btnTafkik
        '
        Me.btnTafkik.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTafkik.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTafkik.Location = New System.Drawing.Point(496, 282)
        Me.btnTafkik.Name = "btnTafkik"
        Me.btnTafkik.Size = New System.Drawing.Size(72, 37)
        Me.btnTafkik.TabIndex = 23
        Me.btnTafkik.Text = "تفکیک"
        '
        'btndarjasan
        '
        Me.btndarjasan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndarjasan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndarjasan.Location = New System.Drawing.Point(569, 282)
        Me.btndarjasan.Name = "btndarjasan"
        Me.btndarjasan.Size = New System.Drawing.Size(72, 37)
        Me.btndarjasan.TabIndex = 22
        Me.btndarjasan.Text = "درج آسان مواد"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RdoTafkikMovaghat)
        Me.GroupBox1.Controls.Add(Me.RdoMovaghat)
        Me.GroupBox1.Controls.Add(Me.RdoTaeed)
        Me.GroupBox1.Controls.Add(Me.RdoBaygani)
        Me.GroupBox1.Controls.Add(Me.RdoErsalShode)
        Me.GroupBox1.Location = New System.Drawing.Point(164, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 32)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'RdoTafkikMovaghat
        '
        Me.RdoTafkikMovaghat.Location = New System.Drawing.Point(9, 12)
        Me.RdoTafkikMovaghat.Name = "RdoTafkikMovaghat"
        Me.RdoTafkikMovaghat.Size = New System.Drawing.Size(114, 18)
        Me.RdoTafkikMovaghat.TabIndex = 7
        Me.RdoTafkikMovaghat.Text = "تفکیک موقت"
        '
        'RdoMovaghat
        '
        Me.RdoMovaghat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RdoMovaghat.Location = New System.Drawing.Point(473, 11)
        Me.RdoMovaghat.Name = "RdoMovaghat"
        Me.RdoMovaghat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdoMovaghat.Size = New System.Drawing.Size(56, 19)
        Me.RdoMovaghat.TabIndex = 2
        Me.RdoMovaghat.Text = "موقت"
        '
        'RdoTaeed
        '
        Me.RdoTaeed.Checked = True
        Me.RdoTaeed.Location = New System.Drawing.Point(313, 11)
        Me.RdoTaeed.Name = "RdoTaeed"
        Me.RdoTaeed.Size = New System.Drawing.Size(144, 19)
        Me.RdoTaeed.TabIndex = 3
        Me.RdoTaeed.TabStop = True
        Me.RdoTaeed.Text = "تاييد شده-درحال ارسال"
        '
        'RdoBaygani
        '
        Me.RdoBaygani.Location = New System.Drawing.Point(233, 11)
        Me.RdoBaygani.Name = "RdoBaygani"
        Me.RdoBaygani.Size = New System.Drawing.Size(64, 19)
        Me.RdoBaygani.TabIndex = 4
        Me.RdoBaygani.Text = "بايگاني"
        '
        'RdoErsalShode
        '
        Me.RdoErsalShode.Location = New System.Drawing.Point(129, 11)
        Me.RdoErsalShode.Name = "RdoErsalShode"
        Me.RdoErsalShode.Size = New System.Drawing.Size(88, 18)
        Me.RdoErsalShode.TabIndex = 6
        Me.RdoErsalShode.Text = "ارسال شده"
        '
        'btnPrintDarkhast
        '
        Me.btnPrintDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintDarkhast.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrintDarkhast.Location = New System.Drawing.Point(642, 282)
        Me.btnPrintDarkhast.Name = "btnPrintDarkhast"
        Me.btnPrintDarkhast.Size = New System.Drawing.Size(72, 37)
        Me.btnPrintDarkhast.TabIndex = 14
        Me.btnPrintDarkhast.Text = "چاپ درخواست"
        '
        'btnDarkhastBaygani
        '
        Me.btnDarkhastBaygani.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarkhastBaygani.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarkhastBaygani.Location = New System.Drawing.Point(423, 282)
        Me.btnDarkhastBaygani.Name = "btnDarkhastBaygani"
        Me.btnDarkhastBaygani.Size = New System.Drawing.Size(72, 37)
        Me.btnDarkhastBaygani.TabIndex = 14
        Me.btnDarkhastBaygani.Text = "بايگاني درخواست"
        '
        'pnln0
        '
        Me.pnln0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnln0.Location = New System.Drawing.Point(4, 285)
        Me.pnln0.Name = "pnln0"
        Me.pnln0.Size = New System.Drawing.Size(165, 37)
        Me.pnln0.TabIndex = 12
        '
        'pnlc0
        '
        Me.pnlc0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlc0.Location = New System.Drawing.Point(866, 285)
        Me.pnlc0.Name = "pnlc0"
        Me.pnlc0.Size = New System.Drawing.Size(269, 37)
        Me.pnlc0.TabIndex = 12
        '
        'btnDarkhastTaeed
        '
        Me.btnDarkhastTaeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarkhastTaeed.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarkhastTaeed.Location = New System.Drawing.Point(790, 282)
        Me.btnDarkhastTaeed.Name = "btnDarkhastTaeed"
        Me.btnDarkhastTaeed.Size = New System.Drawing.Size(72, 37)
        Me.btnDarkhastTaeed.TabIndex = 13
        Me.btnDarkhastTaeed.Text = "تاييد"
        '
        'btnDarkhastErsalAll
        '
        Me.btnDarkhastErsalAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarkhastErsalAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarkhastErsalAll.Location = New System.Drawing.Point(716, 282)
        Me.btnDarkhastErsalAll.Name = "btnDarkhastErsalAll"
        Me.btnDarkhastErsalAll.Size = New System.Drawing.Size(72, 37)
        Me.btnDarkhastErsalAll.TabIndex = 15
        Me.btnDarkhastErsalAll.Text = "ارسال"
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtMinDate)
        Me.Frame1.Controls.Add(Me.lblFromDate)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(720, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(231, 27)
        Me.Frame1.TabIndex = 19
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point(17, 2)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size(78, 21)
        Me.txtMinDate.TabIndex = 0
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFromDate.Location = New System.Drawing.Point(100, 7)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFromDate.Size = New System.Drawing.Size(114, 13)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "تاريخ شروع درخواست :"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(92, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size(48, 24)
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
        Me.sstParent.Controls.Add(Me.m_sstParent_TabPage0)
        Me.sstParent.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstParent.ItemSize = New System.Drawing.Size(42, 23)
        Me.sstParent.Location = New System.Drawing.Point(3, 2)
        Me.sstParent.Mirrored = True
        Me.sstParent.Name = "sstParent"
        Me.sstParent.SelectedIndex = 0
        Me.sstParent.Size = New System.Drawing.Size(1132, 277)
        Me.sstParent.TabIndex = 7
        '
        'm_sstParent_TabPage1
        '
        Me.m_sstParent_TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.m_sstParent_TabPage1.Controls.Add(Me.pnlG)
        Me.m_sstParent_TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.m_sstParent_TabPage1.Name = "m_sstParent_TabPage1"
        Me.m_sstParent_TabPage1.Size = New System.Drawing.Size(1124, 246)
        Me.m_sstParent_TabPage1.TabIndex = 1
        Me.m_sstParent_TabPage1.Text = "درخواستها"
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
        Me.pnlG.Size = New System.Drawing.Size(1124, 246)
        Me.pnlG.TabIndex = 8
        '
        'm_sstParent_TabPage0
        '
        Me.m_sstParent_TabPage0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.m_sstParent_TabPage0.Controls.Add(Me.pnlD)
        Me.m_sstParent_TabPage0.Location = New System.Drawing.Point(4, 27)
        Me.m_sstParent_TabPage0.Name = "m_sstParent_TabPage0"
        Me.m_sstParent_TabPage0.Size = New System.Drawing.Size(1124, 225)
        Me.m_sstParent_TabPage0.TabIndex = 0
        Me.m_sstParent_TabPage0.Text = "درخواست خاص"
        Me.m_sstParent_TabPage0.Visible = False
        '
        'pnlD
        '
        Me.pnlD.BackColor = System.Drawing.SystemColors.Control
        Me.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlD.Controls.Add(Me.txtDarkhastDS)
        Me.pnlD.Controls.Add(Me.lblTarafHesab)
        Me.pnlD.Controls.Add(Me.txtTarafHesab)
        Me.pnlD.Controls.Add(Me.dbcTafsiliSN1)
        Me.pnlD.Controls.Add(Me.lblTafsiliSN1)
        Me.pnlD.Controls.Add(Me.dbcTarafHesabSN)
        Me.pnlD.Controls.Add(Me.lblTarafHesabSN)
        Me.pnlD.Controls.Add(Me.lblSanadDate)
        Me.pnlD.Controls.Add(Me.txtToDate)
        Me.pnlD.Controls.Add(Me.dbcTarakoneshSN)
        Me.pnlD.Controls.Add(Me.lblTarakoneshSN)
        Me.pnlD.Controls.Add(Me.txtShomarehSefaresh)
        Me.pnlD.Controls.Add(Me.lblShomarehSefaresh)
        Me.pnlD.Controls.Add(Me.txtVazneBaskool)
        Me.pnlD.Controls.Add(Me.txtNameRanandeh)
        Me.pnlD.Controls.Add(Me.txtShomarehMashin)
        Me.pnlD.Controls.Add(Me.txtShomarehBarnameh)
        Me.pnlD.Controls.Add(Me.lblVazneBaskool)
        Me.pnlD.Controls.Add(Me.lblNameRanandeh)
        Me.pnlD.Controls.Add(Me.lblShomarehMashin)
        Me.pnlD.Controls.Add(Me.lblShomarehBarnameh)
        Me.pnlD.Controls.Add(Me.Label2)
        Me.pnlD.Controls.Add(Me.Label1)
        Me.pnlD.Controls.Add(Me.txtDarkhastNo)
        Me.pnlD.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlD.Location = New System.Drawing.Point(0, 0)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlD.Size = New System.Drawing.Size(1124, 225)
        Me.pnlD.TabIndex = 0
        Me.pnlD.TabStop = True
        '
        'txtDarkhastDS
        '
        Me.txtDarkhastDS.AcceptsReturn = True
        Me.txtDarkhastDS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDarkhastDS.BackColor = System.Drawing.SystemColors.Window
        Me.txtDarkhastDS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDarkhastDS.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDarkhastDS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDarkhastDS.Location = New System.Drawing.Point(3, 30)
        Me.txtDarkhastDS.MaxLength = 0
        Me.txtDarkhastDS.Name = "txtDarkhastDS"
        Me.txtDarkhastDS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDarkhastDS.Size = New System.Drawing.Size(770, 20)
        Me.txtDarkhastDS.TabIndex = 2
        '
        'lblTarafHesab
        '
        Me.lblTarafHesab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarafHesab.Location = New System.Drawing.Point(436, 107)
        Me.lblTarafHesab.Name = "lblTarafHesab"
        Me.lblTarafHesab.Size = New System.Drawing.Size(87, 18)
        Me.lblTarafHesab.TabIndex = 52
        Me.lblTarafHesab.Text = "طرف حساب"
        '
        'txtTarafHesab
        '
        Me.txtTarafHesab.AcceptsReturn = True
        Me.txtTarafHesab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTarafHesab.BackColor = System.Drawing.SystemColors.Window
        Me.txtTarafHesab.Location = New System.Drawing.Point(295, 126)
        Me.txtTarafHesab.Name = "txtTarafHesab"
        Me.txtTarafHesab.Size = New System.Drawing.Size(231, 21)
        Me.txtTarafHesab.TabIndex = 7
        '
        'dbcTafsiliSN1
        '
        Me.dbcTafsiliSN1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTafsiliSN1.AutoSelectFirst = False
        Me.dbcTafsiliSN1.BackColor = System.Drawing.Color.White
        Me.dbcTafsiliSN1.BoundText = Nothing
        Me.dbcTafsiliSN1.BypassChangeEvent = False
        Me.dbcTafsiliSN1.DisplayText = ""
        Me.dbcTafsiliSN1.LateBindingTop = "100"
        Me.dbcTafsiliSN1.Location = New System.Drawing.Point(552, 126)
        Me.dbcTafsiliSN1.MemFilter = ""
        Me.dbcTafsiliSN1.Name = "dbcTafsiliSN1"
        Me.dbcTafsiliSN1.SeparatedData = Nothing
        Me.dbcTafsiliSN1.Size = New System.Drawing.Size(221, 21)
        Me.dbcTafsiliSN1.Source = Nothing
        Me.dbcTafsiliSN1.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTafsiliSN1.TabIndex = 6
        '
        'lblTafsiliSN1
        '
        Me.lblTafsiliSN1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTafsiliSN1.AutoSize = True
        Me.lblTafsiliSN1.BackColor = System.Drawing.Color.Transparent
        Me.lblTafsiliSN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTafsiliSN1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTafsiliSN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTafsiliSN1.Location = New System.Drawing.Point(695, 108)
        Me.lblTafsiliSN1.Name = "lblTafsiliSN1"
        Me.lblTafsiliSN1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTafsiliSN1.Size = New System.Drawing.Size(73, 13)
        Me.lblTafsiliSN1.TabIndex = 50
        Me.lblTafsiliSN1.Text = "طرف حساب-2"
        Me.lblTafsiliSN1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dbcTarafHesabSN
        '
        Me.dbcTarafHesabSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTarafHesabSN.AutoSelectFirst = False
        Me.dbcTarafHesabSN.BackColor = System.Drawing.Color.White
        Me.dbcTarafHesabSN.BoundText = Nothing
        Me.dbcTarafHesabSN.BypassChangeEvent = False
        Me.dbcTarafHesabSN.DisplayText = ""
        Me.dbcTarafHesabSN.LateBindingTop = "100"
        Me.dbcTarafHesabSN.Location = New System.Drawing.Point(3, 75)
        Me.dbcTarafHesabSN.MemFilter = ""
        Me.dbcTarafHesabSN.Name = "dbcTarafHesabSN"
        Me.dbcTarafHesabSN.SeparatedData = Nothing
        Me.dbcTarafHesabSN.Size = New System.Drawing.Size(770, 21)
        Me.dbcTarafHesabSN.Source = Nothing
        Me.dbcTarafHesabSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarafHesabSN.TabIndex = 4
        '
        'lblTarafHesabSN
        '
        Me.lblTarafHesabSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarafHesabSN.AutoSize = True
        Me.lblTarafHesabSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarafHesabSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarafHesabSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarafHesabSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarafHesabSN.Location = New System.Drawing.Point(705, 60)
        Me.lblTarafHesabSN.Name = "lblTarafHesabSN"
        Me.lblTarafHesabSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarafHesabSN.Size = New System.Drawing.Size(63, 13)
        Me.lblTarafHesabSN.TabIndex = 47
        Me.lblTarafHesabSN.Text = "طرف حساب"
        Me.lblTarafHesabSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSanadDate
        '
        Me.lblSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSanadDate.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadDate.Location = New System.Drawing.Point(804, 9)
        Me.lblSanadDate.Name = "lblSanadDate"
        Me.lblSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadDate.Size = New System.Drawing.Size(154, 18)
        Me.lblSanadDate.TabIndex = 45
        Me.lblSanadDate.Text = "تاريخ پايان درخواست"
        '
        'txtToDate
        '
        Me.txtToDate.AcceptsReturn = True
        Me.txtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDate.Location = New System.Drawing.Point(804, 30)
        Me.txtToDate.MaxLength = 0
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDate.Size = New System.Drawing.Size(154, 21)
        Me.txtToDate.TabIndex = 1
        Me.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dbcTarakoneshSN
        '
        Me.dbcTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTarakoneshSN.AutoSelectFirst = False
        Me.dbcTarakoneshSN.BackColor = System.Drawing.Color.White
        Me.dbcTarakoneshSN.BoundText = Nothing
        Me.dbcTarakoneshSN.BypassChangeEvent = False
        Me.dbcTarakoneshSN.DisplayText = ""
        Me.dbcTarakoneshSN.LateBindingTop = "100"
        Me.dbcTarakoneshSN.Location = New System.Drawing.Point(828, 75)
        Me.dbcTarakoneshSN.MemFilter = ""
        Me.dbcTarakoneshSN.Name = "dbcTarakoneshSN"
        Me.dbcTarakoneshSN.SeparatedData = Nothing
        Me.dbcTarakoneshSN.Size = New System.Drawing.Size(285, 21)
        Me.dbcTarakoneshSN.Source = Nothing
        Me.dbcTarakoneshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarakoneshSN.TabIndex = 3
        '
        'lblTarakoneshSN
        '
        Me.lblTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarakoneshSN.AutoSize = True
        Me.lblTarakoneshSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarakoneshSN.Location = New System.Drawing.Point(1043, 60)
        Me.lblTarakoneshSN.Name = "lblTarakoneshSN"
        Me.lblTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarakoneshSN.Size = New System.Drawing.Size(70, 13)
        Me.lblTarakoneshSN.TabIndex = 43
        Me.lblTarakoneshSN.Text = "نوع درخواست"
        Me.lblTarakoneshSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtShomarehSefaresh
        '
        Me.txtShomarehSefaresh.AcceptsReturn = True
        Me.txtShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehSefaresh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehSefaresh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehSefaresh.Location = New System.Drawing.Point(960, 123)
        Me.txtShomarehSefaresh.MaxLength = 0
        Me.txtShomarehSefaresh.Name = "txtShomarehSefaresh"
        Me.txtShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehSefaresh.Size = New System.Drawing.Size(153, 21)
        Me.txtShomarehSefaresh.TabIndex = 5
        Me.txtShomarehSefaresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShomarehSefaresh
        '
        Me.lblShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehSefaresh.AutoSize = True
        Me.lblShomarehSefaresh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehSefaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehSefaresh.Location = New System.Drawing.Point(1049, 105)
        Me.lblShomarehSefaresh.Name = "lblShomarehSefaresh"
        Me.lblShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehSefaresh.Size = New System.Drawing.Size(64, 13)
        Me.lblShomarehSefaresh.TabIndex = 41
        Me.lblShomarehSefaresh.Text = "شماره ارجاع"
        Me.lblShomarehSefaresh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtVazneBaskool
        '
        Me.txtVazneBaskool.AcceptsReturn = True
        Me.txtVazneBaskool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVazneBaskool.BackColor = System.Drawing.SystemColors.Window
        Me.txtVazneBaskool.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtVazneBaskool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVazneBaskool.Location = New System.Drawing.Point(295, 171)
        Me.txtVazneBaskool.MaxLength = 0
        Me.txtVazneBaskool.Name = "txtVazneBaskool"
        Me.txtVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVazneBaskool.Size = New System.Drawing.Size(230, 21)
        Me.txtVazneBaskool.TabIndex = 11
        Me.txtVazneBaskool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNameRanandeh
        '
        Me.txtNameRanandeh.AcceptsReturn = True
        Me.txtNameRanandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameRanandeh.BackColor = System.Drawing.SystemColors.Window
        Me.txtNameRanandeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNameRanandeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNameRanandeh.Location = New System.Drawing.Point(552, 171)
        Me.txtNameRanandeh.MaxLength = 0
        Me.txtNameRanandeh.Name = "txtNameRanandeh"
        Me.txtNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNameRanandeh.Size = New System.Drawing.Size(221, 21)
        Me.txtNameRanandeh.TabIndex = 10
        Me.txtNameRanandeh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShomarehMashin
        '
        Me.txtShomarehMashin.AcceptsReturn = True
        Me.txtShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehMashin.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehMashin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehMashin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehMashin.Location = New System.Drawing.Point(804, 171)
        Me.txtShomarehMashin.MaxLength = 0
        Me.txtShomarehMashin.Name = "txtShomarehMashin"
        Me.txtShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehMashin.Size = New System.Drawing.Size(154, 21)
        Me.txtShomarehMashin.TabIndex = 9
        Me.txtShomarehMashin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShomarehBarnameh
        '
        Me.txtShomarehBarnameh.AcceptsReturn = True
        Me.txtShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehBarnameh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehBarnameh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehBarnameh.Location = New System.Drawing.Point(976, 171)
        Me.txtShomarehBarnameh.MaxLength = 0
        Me.txtShomarehBarnameh.Name = "txtShomarehBarnameh"
        Me.txtShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehBarnameh.Size = New System.Drawing.Size(137, 21)
        Me.txtShomarehBarnameh.TabIndex = 8
        Me.txtShomarehBarnameh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVazneBaskool
        '
        Me.lblVazneBaskool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVazneBaskool.AutoSize = True
        Me.lblVazneBaskool.BackColor = System.Drawing.Color.Transparent
        Me.lblVazneBaskool.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVazneBaskool.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVazneBaskool.Location = New System.Drawing.Point(424, 153)
        Me.lblVazneBaskool.Name = "lblVazneBaskool"
        Me.lblVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVazneBaskool.Size = New System.Drawing.Size(104, 13)
        Me.lblVazneBaskool.TabIndex = 39
        Me.lblVazneBaskool.Text = "وزن باسکول فرستنده"
        Me.lblVazneBaskool.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNameRanandeh
        '
        Me.lblNameRanandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNameRanandeh.AutoSize = True
        Me.lblNameRanandeh.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRanandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNameRanandeh.Location = New System.Drawing.Point(720, 153)
        Me.lblNameRanandeh.Name = "lblNameRanandeh"
        Me.lblNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNameRanandeh.Size = New System.Drawing.Size(48, 13)
        Me.lblNameRanandeh.TabIndex = 37
        Me.lblNameRanandeh.Text = "نام راننده"
        Me.lblNameRanandeh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShomarehMashin
        '
        Me.lblShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehMashin.AutoSize = True
        Me.lblShomarehMashin.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehMashin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehMashin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehMashin.Location = New System.Drawing.Point(864, 153)
        Me.lblShomarehMashin.Name = "lblShomarehMashin"
        Me.lblShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehMashin.Size = New System.Drawing.Size(72, 13)
        Me.lblShomarehMashin.TabIndex = 35
        Me.lblShomarehMashin.Text = "شماره ماشين"
        Me.lblShomarehMashin.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShomarehBarnameh
        '
        Me.lblShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehBarnameh.AutoSize = True
        Me.lblShomarehBarnameh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehBarnameh.Location = New System.Drawing.Point(1045, 153)
        Me.lblShomarehBarnameh.Name = "lblShomarehBarnameh"
        Me.lblShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehBarnameh.Size = New System.Drawing.Size(68, 13)
        Me.lblShomarehBarnameh.TabIndex = 33
        Me.lblShomarehBarnameh.Text = "شماره بارنامه"
        Me.lblShomarehBarnameh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(681, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "شرح درخواست"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(1008, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "شماره درخواست"
        '
        'txtDarkhastNo
        '
        Me.txtDarkhastNo.AcceptsReturn = True
        Me.txtDarkhastNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDarkhastNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtDarkhastNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDarkhastNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtDarkhastNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDarkhastNo.Location = New System.Drawing.Point(982, 30)
        Me.txtDarkhastNo.MaxLength = 0
        Me.txtDarkhastNo.Name = "txtDarkhastNo"
        Me.txtDarkhastNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDarkhastNo.Size = New System.Drawing.Size(131, 21)
        Me.txtDarkhastNo.TabIndex = 0
        Me.txtDarkhastNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(173, 266)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(155, 32)
        Me.lblInfo.TabIndex = 21
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Maroon
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 325)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1140, 4)
        Me.Splitter1.TabIndex = 48
        Me.Splitter1.TabStop = False
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.tabp2)
        Me.Tab2.Controls.Add(Me.TabPage1)
        Me.Tab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab2.Location = New System.Drawing.Point(0, 329)
        Me.Tab2.Mirrored = True
        Me.Tab2.Name = "Tab2"
        Me.Tab2.SelectedIndex = 0
        Me.Tab2.Size = New System.Drawing.Size(1140, 213)
        Me.Tab2.TabIndex = 49
        '
        'tabp2
        '
        Me.tabp2.Controls.Add(Me.txtMojoodi_TahteBarrasiePayekar)
        Me.tabp2.Controls.Add(Me.lblMojoodi_TahteBarrasiePayekar)
        Me.tabp2.Controls.Add(Me.txtMojoodi_GhabeleErsalePayekar)
        Me.tabp2.Controls.Add(Me.lblMojoodi_GhabeleErsalePayekar)
        Me.tabp2.Controls.Add(Me.txtMojoodi_TahteBarrasi)
        Me.tabp2.Controls.Add(Me.lblMojoodi_TahteBarrasi)
        Me.tabp2.Controls.Add(Me.txtMojoodi_GhabeleErsal)
        Me.tabp2.Controls.Add(Me.lblMojoodi_GhabeleErsal)
        Me.tabp2.Controls.Add(Me.btnDelete)
        Me.tabp2.Controls.Add(Me.pnlnKala)
        Me.tabp2.Controls.Add(Me.pnlGKala)
        Me.tabp2.Controls.Add(Me.pnlcKala)
        Me.tabp2.Location = New System.Drawing.Point(4, 23)
        Me.tabp2.Name = "tabp2"
        Me.tabp2.Size = New System.Drawing.Size(1132, 186)
        Me.tabp2.TabIndex = 0
        Me.tabp2.Text = "اقلام"
        '
        'txtMojoodi_TahteBarrasiePayekar
        '
        Me.txtMojoodi_TahteBarrasiePayekar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMojoodi_TahteBarrasiePayekar.BackColor = System.Drawing.SystemColors.Control
        Me.txtMojoodi_TahteBarrasiePayekar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMojoodi_TahteBarrasiePayekar.Location = New System.Drawing.Point(355, 157)
        Me.txtMojoodi_TahteBarrasiePayekar.Name = "txtMojoodi_TahteBarrasiePayekar"
        Me.txtMojoodi_TahteBarrasiePayekar.ReadOnly = True
        Me.txtMojoodi_TahteBarrasiePayekar.Size = New System.Drawing.Size(110, 22)
        Me.txtMojoodi_TahteBarrasiePayekar.TabIndex = 31
        '
        'lblMojoodi_TahteBarrasiePayekar
        '
        Me.lblMojoodi_TahteBarrasiePayekar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMojoodi_TahteBarrasiePayekar.AutoSize = True
        Me.lblMojoodi_TahteBarrasiePayekar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblMojoodi_TahteBarrasiePayekar.Location = New System.Drawing.Point(468, 151)
        Me.lblMojoodi_TahteBarrasiePayekar.Name = "lblMojoodi_TahteBarrasiePayekar"
        Me.lblMojoodi_TahteBarrasiePayekar.Size = New System.Drawing.Size(113, 28)
        Me.lblMojoodi_TahteBarrasiePayekar.TabIndex = 30
        Me.lblMojoodi_TahteBarrasiePayekar.Text = "موجودی تحت بررسی" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " انبار پای کار:"
        '
        'txtMojoodi_GhabeleErsalePayekar
        '
        Me.txtMojoodi_GhabeleErsalePayekar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMojoodi_GhabeleErsalePayekar.BackColor = System.Drawing.SystemColors.Control
        Me.txtMojoodi_GhabeleErsalePayekar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMojoodi_GhabeleErsalePayekar.Location = New System.Drawing.Point(590, 157)
        Me.txtMojoodi_GhabeleErsalePayekar.Name = "txtMojoodi_GhabeleErsalePayekar"
        Me.txtMojoodi_GhabeleErsalePayekar.ReadOnly = True
        Me.txtMojoodi_GhabeleErsalePayekar.Size = New System.Drawing.Size(110, 22)
        Me.txtMojoodi_GhabeleErsalePayekar.TabIndex = 29
        '
        'lblMojoodi_GhabeleErsalePayekar
        '
        Me.lblMojoodi_GhabeleErsalePayekar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMojoodi_GhabeleErsalePayekar.AutoSize = True
        Me.lblMojoodi_GhabeleErsalePayekar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblMojoodi_GhabeleErsalePayekar.Location = New System.Drawing.Point(703, 151)
        Me.lblMojoodi_GhabeleErsalePayekar.Name = "lblMojoodi_GhabeleErsalePayekar"
        Me.lblMojoodi_GhabeleErsalePayekar.Size = New System.Drawing.Size(107, 28)
        Me.lblMojoodi_GhabeleErsalePayekar.TabIndex = 28
        Me.lblMojoodi_GhabeleErsalePayekar.Text = "موجودی قابل ارسال" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " انبار پای کار:"
        '
        'txtMojoodi_TahteBarrasi
        '
        Me.txtMojoodi_TahteBarrasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMojoodi_TahteBarrasi.BackColor = System.Drawing.SystemColors.Control
        Me.txtMojoodi_TahteBarrasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMojoodi_TahteBarrasi.Location = New System.Drawing.Point(355, 129)
        Me.txtMojoodi_TahteBarrasi.Name = "txtMojoodi_TahteBarrasi"
        Me.txtMojoodi_TahteBarrasi.ReadOnly = True
        Me.txtMojoodi_TahteBarrasi.Size = New System.Drawing.Size(110, 22)
        Me.txtMojoodi_TahteBarrasi.TabIndex = 27
        '
        'lblMojoodi_TahteBarrasi
        '
        Me.lblMojoodi_TahteBarrasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMojoodi_TahteBarrasi.AutoSize = True
        Me.lblMojoodi_TahteBarrasi.Location = New System.Drawing.Point(469, 134)
        Me.lblMojoodi_TahteBarrasi.Name = "lblMojoodi_TahteBarrasi"
        Me.lblMojoodi_TahteBarrasi.Size = New System.Drawing.Size(117, 14)
        Me.lblMojoodi_TahteBarrasi.TabIndex = 26
        Me.lblMojoodi_TahteBarrasi.Text = "موجودی تحت بررسی:"
        '
        'txtMojoodi_GhabeleErsal
        '
        Me.txtMojoodi_GhabeleErsal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMojoodi_GhabeleErsal.BackColor = System.Drawing.SystemColors.Control
        Me.txtMojoodi_GhabeleErsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMojoodi_GhabeleErsal.Location = New System.Drawing.Point(590, 129)
        Me.txtMojoodi_GhabeleErsal.Name = "txtMojoodi_GhabeleErsal"
        Me.txtMojoodi_GhabeleErsal.ReadOnly = True
        Me.txtMojoodi_GhabeleErsal.Size = New System.Drawing.Size(110, 22)
        Me.txtMojoodi_GhabeleErsal.TabIndex = 25
        '
        'lblMojoodi_GhabeleErsal
        '
        Me.lblMojoodi_GhabeleErsal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMojoodi_GhabeleErsal.AutoSize = True
        Me.lblMojoodi_GhabeleErsal.Location = New System.Drawing.Point(703, 134)
        Me.lblMojoodi_GhabeleErsal.Name = "lblMojoodi_GhabeleErsal"
        Me.lblMojoodi_GhabeleErsal.Size = New System.Drawing.Size(111, 14)
        Me.lblMojoodi_GhabeleErsal.TabIndex = 24
        Me.lblMojoodi_GhabeleErsal.Text = "موجودی قابل ارسال:"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelete.Location = New System.Drawing.Point(823, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 37)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "حذف انتخابی"
        '
        'pnlnKala
        '
        Me.pnlnKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlnKala.Location = New System.Drawing.Point(4, 139)
        Me.pnlnKala.Name = "pnlnKala"
        Me.pnlnKala.Size = New System.Drawing.Size(180, 37)
        Me.pnlnKala.TabIndex = 18
        '
        'pnlGKala
        '
        Me.pnlGKala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGKala.Location = New System.Drawing.Point(4, 3)
        Me.pnlGKala.Name = "pnlGKala"
        Me.pnlGKala.Size = New System.Drawing.Size(1125, 124)
        Me.pnlGKala.TabIndex = 16
        '
        'pnlcKala
        '
        Me.pnlcKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcKala.Location = New System.Drawing.Point(900, 139)
        Me.pnlcKala.Name = "pnlcKala"
        Me.pnlcKala.Size = New System.Drawing.Size(229, 37)
        Me.pnlcKala.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PnlNBatch)
        Me.TabPage1.Controls.Add(Me.PnlGBatch)
        Me.TabPage1.Controls.Add(Me.PnlCBatch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1132, 207)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "شماره رهگيري محصول"
        '
        'PnlNBatch
        '
        Me.PnlNBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlNBatch.Location = New System.Drawing.Point(3, 165)
        Me.PnlNBatch.Name = "PnlNBatch"
        Me.PnlNBatch.Size = New System.Drawing.Size(180, 37)
        Me.PnlNBatch.TabIndex = 21
        '
        'PnlGBatch
        '
        Me.PnlGBatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlGBatch.Location = New System.Drawing.Point(3, 2)
        Me.PnlGBatch.Name = "PnlGBatch"
        Me.PnlGBatch.Size = New System.Drawing.Size(1119, 159)
        Me.PnlGBatch.TabIndex = 19
        '
        'PnlCBatch
        '
        Me.PnlCBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCBatch.Location = New System.Drawing.Point(769, 165)
        Me.PnlCBatch.Name = "PnlCBatch"
        Me.PnlCBatch.Size = New System.Drawing.Size(353, 37)
        Me.PnlCBatch.TabIndex = 20
        '
        'FrmabDarkhast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1140, 542)
        Me.Controls.Add(Me.Tab2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmabDarkhast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "درخواست کالا"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.sstParent.ResumeLayout(False)
        Me.m_sstParent_TabPage1.ResumeLayout(False)
        Me.m_sstParent_TabPage0.ResumeLayout(False)
        Me.pnlD.ResumeLayout(False)
        Me.pnlD.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.tabp2.ResumeLayout(False)
        Me.tabp2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmabDarkhast
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmabDarkhast

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabDarkhast
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabDarkhast)
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

    Private WithEvents DVDarkhast As CDataView
    Private WithEvents DVKala As CDataView
    Private WithEvents DVBatch As CDataView
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

#End Region

    '//ناحيه تعريف متغيرهاي Local

    Private Enum DarkhastStatus
        movaghat = 1
        Taeed = 4
        darhaleersal = 8
        Ersal = 16
        Baigani = 12
    End Enum

    Private Sub frmabDarkhast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
            gDarkhastkala = IIf(CAppSet.GetAppConfig("gDarkhastkala") Is System.DBNull.Value, 0, CAppSet.GetAppConfig("gDarkhastkala"))
            btnTafkik.Enabled = IIf(CAppSet.GetAppConfig("gEnableTafkikButtonOnFrmabDarkhast") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gEnableTafkikButtonOnFrmabDarkhast"))
            RdoTafkikMovaghat.Visible = btnTafkik.Enabled
        Catch ex As Exception
        End Try


        If gDarkhastkala = 1 Then
            RdoMovaghat.Checked = True
        Else
            RdoTaeed.Checked = True
        End If

        MinFilterDateCtrl = New NetSql.Components.CDateCtrl(tp)
        With MinFilterDateCtrl
            MinFilterDateCtrl.TextBox = txtMinDate
        End With
        txtDarkhastNo.Enabled = False  'by yekta 910426
        btnDarkhastTaeed.Visible = gSM.TableAccessRight("btnDarkhastTaeed") = EnumAccessRight.arAll
        btnDarkhastBaygani.Visible = gSM.TableAccessRight("btnDarkhastBaygani") = EnumAccessRight.arAll
        btnDarkhastErsalAll.Visible = gSM.TableAccessRight("btnDarkhastErsalAll") = EnumAccessRight.arAll
        'ghasemi 14010714
        btnHazfDarkhastErsalnashodeh.Visible = gSM.TableAccessRight("btnHazfDarkhastErsalnashodeh") = EnumAccessRight.arAll
        'ghasemi 14010714
        DVDarkhast = New CDataView(cn)
        DVKala = New CDataView(cn)
        DVBatch = New CDataView(cn)

        InitDVDarkhast()
        InitDVKala()
        InitDVBatch()

        DVKala.Parent = DVDarkhast
        DVBatch.Parent = DVDarkhast

        FillDVDarkhast()

    End Sub

    Private Sub InitDVDarkhast()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vMinDateSetting As String ', vMaxDateSetting
        Dim vMaxDate, vMinDate As String
        Dim vSysDate As String

        ' تهيه تاريخ از سرور
        vSysDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                               cn,
                                                                               Functions.FTDBCommonFunctions.
                                                                                  enmDateFormat.Normal)
        vMaxDate = gHesabdariSalTDate
        vMinDate = VB.Left(vSysDate, 2) + "0101"
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabDarkhast", vMinDate)
        MinFilterDateCtrl.Value = vMinDateSetting
        If MinFilterDateCtrl.IsValid Then
            vMinDate = vMinDateSetting
        End If

        With DVDarkhast

            .Init(pnlG, pnlD, pnlc0, pnln0,
                   EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit)
            .TableName = "abDarkhast"
            .SQLOrderBy = "DarkhastNo"
            vfgDarkhast = .FlexGrid
            .AccessRight = gSM.TableAccessRight("abDarkhast")
            .EditInGrid = False
            .SQLWhere = "FromDate between '" & MinFilterDateCtrl.Value & "' AND  '" & gHesabdariSalTDate & "' "
            DVDarkhast.FlexGrid.Editable = EditableSettings.flexEDKbdMouse

            With .Fields

                With .Add("{0} AS Selected", "CheckBox")
                    .Caption = " "
                    .MinComponentWidth = "50"
                End With

                With .Add("DarkhastSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With

                With .Add("DarkhastNo", "txtDarkhastNo")
                    .Caption = "شماره درخواست"
                    .MinComponentWidth = 50
                End With

                With .Add("DarkhastDS", txtDarkhastDS)
                    .Caption = "شرح درخواست"
                    .MinComponentWidth = 100
                End With

                With .Add("HesabdariSal", , EnumFieldOptions.foHidden)
                    .DefaultValue = gHesabdariSal
                End With

                With .Add("FromDate", , EnumFieldOptions.foDate)
                    .Caption = "تاريخ شروع درخواست"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("ToDate", txtToDate, EnumFieldOptions.foDate)
                    .Caption = "تاريخ پايان درخواست"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("UserID_Name", , EnumFieldOptions.foDefault)
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "درخواست کننده"
                End With

                .Add("TarakoneshSN", , EnumFieldOptions.foHidden)

                With _
                    .Add("TarakoneshSN -> {abTarakonesh.TarakoneshNo+'-'+ abTarakonesh.TarakoneshDS} AS Tarakonesh",
                          dbcTarakoneshSN)
                    .Caption = "نوع درخواست"
                    '.ComboWhereCondition = "TarakoneshSN >50"     change by yekta 920613   rechange by yekta 920701

                    ''test ghasemi14020318
                    '.ComboWhereCondition = "TarakoneshSN IN (SELECT TarakoneshSN From abTarakoneshGoroohha where TarakoneshGoroohSN=56 )"
                    .ComboWhereCondition = "TarakoneshSN IN (SELECT abTarakoneshGoroohha.TarakoneshSN From abTarakoneshGoroohha " &
                                           "inner join abAnbarTarakonesh on abTarakoneshGoroohha.TarakoneshSN =abAnbarTarakonesh.TarakoneshSN " &
                                           "where TarakoneshGoroohSN=56 And abAnbarTarakonesh.AnbarSN =" & gAnbarSN & "And AnbarTarakoneshStatus =1)"
                    ''test ghasemi14020318
                End With

                With _
                    .Add("TafsiliSN->{maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS} AS TafsiliSN ", dbcTarafHesabSN)
                    .Caption = lblTarafHesabSN.Text
                    dbcTarafHesabSN.LateBinding = True
                    .ComboWhereCondition = "  1 = 2 "
                End With

                With _
                    .Add("TafsiliSN1->{ maTafsili2.TafsiliNO + ' _ ' + maTafsili2.TafsiliDS} AS TafsiliSN1 ",
                          dbcTafsiliSN1)
                    .Caption = lblTarafHesabSN.Text
                    dbcTafsiliSN1.LateBinding = True
                    .ComboWhereCondition = "  1 = 2 "
                End With

                With .Add("ShomarehSefaresh", txtShomarehSefaresh, EnumFieldOptions.foDefault)
                    '.DataType = "BIGINT"
                    .Caption = lblShomarehSefaresh.Text
                End With
                .Add("ShomarehBarnameh", txtShomarehBarnameh, EnumFieldOptions.foHidden)

                .Add("ShomarehMashin", txtShomarehMashin, EnumFieldOptions.foHidden)

                .Add("NameRanandeh", txtNameRanandeh, EnumFieldOptions.foHidden)

                With .Add("VazneBaskool", txtVazneBaskool, EnumFieldOptions.foHidden)
                    .DataType = "INT"
                End With

                With .Add("UserID_NameTaeed", , EnumFieldOptions.foDefault)
                    '.DefaultValue = gSM.UserID_Name
                    .Caption = "تاييد کننده"
                End With

                With .Add("DarkhastStatus->abDarkhastStatus.DarkhastStatusDS ")
                    .ReadOnly = True
                    .DefaultValue = DarkhastStatus.movaghat
                    .Caption = "وضعيت درخواست"
                End With

                With .Add("SabtDate", , EnumFieldOptions.foDefault)
                    .Caption = "زمان ثبت"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                    .MinComponentWidth = 80
                End With

                With .Add("TaeedTime", , EnumFieldOptions.foDefault)
                    .Caption = "زمان تایید"
                    .MinComponentWidth = 80
                End With

                With .Add("ErsalTime", , EnumFieldOptions.foDefault)
                    .Caption = "زمان ارسال"
                    .MinComponentWidth = 80
                End With

                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

                With .Add("AnbarSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gAnbarSN
                End With

            End With

        End With

    End Sub

    Private Sub InitDVKala()
        Dim Param(2) As String

        With DVKala

            .Init(pnlGKala, , pnlcKala, pnlnKala, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abDarkhastKala"
            .AddJoin("abDarkhastKala", EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")
            .AccessRight = gSM.TableAccessRight("abDarkhast")
            .EditInGrid = True
            .SQLWhere = IIf(gIsTajmie = 1, "", " abDarkhastKala.AnbarSN = " & gAnbarSN.ToString)

            Param(0) = "AnbarSN"
            Param(1) = "AnbarSN"

            .AddJoin("abDarkhastKala", EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")

            If gIsTajmie <> 1 Then _
                .AddJoin("abDarkhastKala", EnumTableJoin.tjLeftJoin, "AbAnbarKala", "KalaSN", "KalaSN", Param)

            With .Fields

                With .Add("DarkhastKalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("DarkhastSN", , EnumFieldOptions.foHidden)
                End With

                .Add("AnbarSN", , EnumFieldOptions.foHidden)
                With .Add("AnbarSN->{abAnbar.AnbarDS} AS Anbar", "DataCombo")
                    .DefaultValue = gAnbarSN
                    .ComboWhereCondition = "abAnbar.Istajmie= 2 AND VahedeTejariSN =" & gVahedeTejariSN
                    .Caption = "انبار"

                    .FieldOptions = IIf(gIsTajmie = 1, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden)
                End With

                'With .Add("NoeAnbarSN->abNoeAnbar.NoeVoroodeAsnadSN AS NoeVoroodeAsnadSN", "DataCombo", EnumFieldOptions.foHidden)
                '  .Component.Enabled = False
                '  .ReadOnly = True
                '  .Component.Visible = False
                'End With


                With _
                    .Add("KalaSN ->{Pakala.KalaNo+'-'+Pakala.KalaDS} AS Kala", "DataCombo", EnumFieldOptions.foDefault)
                    .ComboWhereCondition = "1>1"
                    .Caption = "کالا"
                    dbcKala = .Component
                End With

                .Add("KalaSN->KalaNO", "TextBox <Disabled>")

                'With _
                '    .Add("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDs AS VahedeSanjeshDs", , EnumFieldOptions.foDefault)
                '    .Caption = cn.FieldCaption("paVahedeSanjesh.VahedeSanjeshDs")
                'End With
                'With .Add("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza", , EnumFieldOptions.foDefault)
                '    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.TedadAjza")
                'End With
                With .Add("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDs AS VahedeSanjeshDs", "TextBox <Disabled>", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVahedeSanjesh.VahedeSanjeshDs")
                End With
                With .Add("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza", "TextBox <Disabled>", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.TedadAjza")
                End With
                With .Add("MeghdareDarkhasti", , EnumFieldOptions.foHidden)
                    .DefaultValue = "0"
                    .Caption = "مقدار درخواستي"
                End With

                With _
                    .Add("{Convert(BIGINT, MeghdareDarkhasti/paVw_VahedeSanjesh.TedadAjza)} As Darkhasti_Box_out",
                          "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار درخواستي -کارتن"
                    .DataType = "INT"
                End With
                With _
                    .Add(
                          "{MeghdareDarkhasti%paVw_VahedeSanjesh.TedadAjza} As Darkhasti_Can_out",
                          "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار درخواستي -عدد"
                    '.DataType = "INT"
                End With

                With .Add("MeghdareErsali", , EnumFieldOptions.foHidden)
                    .Caption = "مقدار ارسالي"
                    .ReadOnly = True
                End With

                With _
                    .Add("{Convert(BIGINT, MeghdareErsali/paVw_VahedeSanjesh.TedadAjza)} As Ersali_Box_out", "TextBox",
                          EnumFieldOptions.foDefault)
                    .Caption = "مقدار ارسالي -کارتن"
                    .DataType = "INT"
                End With
                With _
                    .Add(
                          "{MeghdareErsali%paVw_VahedeSanjesh.TedadAjza} As Ersali_Can_out",
                          "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار ارسالي -عدد"
                    '.DataType = "INT"
                End With

                With .Add("MeghdareErsalShode", , EnumFieldOptions.foHidden)
                    .DefaultValue = "0"
                    .Caption = "مقدار ارسال شده"
                End With

                With _
                    .Add("{Convert(BIGINT, MeghdareErsalShode/paVw_VahedeSanjesh.TedadAjza)} As ErsalShode_Box_out", ,
                          EnumFieldOptions.foDefault)
                    .Caption = "مقدار ارسال شده -کارتن"
                    .DataType = "INT"
                End With
                With _
                    .Add(
                          "{MeghdareErsalShode%paVw_VahedeSanjesh.TedadAjza} As ErsalShode_Can_out", ,
                          EnumFieldOptions.foDefault)
                    .Caption = "مقدار ارسال شده -عدد"
                    '.DataType = "INT"
                End With

                If btnTafkik.Enabled Then
                    With .Add("{dbo.abFn_GetLastDarkhastStatusDS(DarkhastKalaSN)} As LastDarkhastStatusDS", "Textbox", EnumFieldOptions.foDefault)
                        .Caption = "وضعیت"
                    End With
                End If



                If gIsTajmie <> 1 Then .Add("abAnbarKala.Anbarsn", , EnumFieldOptions.foHidden)

                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With

                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub

    Private Sub InitDVBatch()

        With DVBatch

            .Init(PnlGBatch, , PnlCBatch, PnlNBatch, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abDarkhastBatch"
            .AccessRight = gSM.TableAccessRight("abDarkhast")
            .EditInGrid = True

            With .Fields

                With .Add("DarkhastBatchSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("DarkhastSN", , EnumFieldOptions.foHidden)
                End With

                .Add("SefaresheKarSN", , EnumFieldOptions.foHidden)

                With _
                    .Add(
                          "SefaresheKarSN -> {btSefaresheKar.SefaresheKarNo+'-'+ btSefaresheKar.SefaresheKarDS} AS SefaresheKar ",
                          "DataCombo", EnumFieldOptions.foDefault)
                    .ComboWhereCondition = "tarikhetadvin between' " & gHesabdariSalFDate & "' AND '" &
                                           gHesabdariSalTDate & "'"
                    .RefreshCombo()
                    .Caption = "سفارش کار"
                    .MinComponentWidth = "150"
                End With

                With _
                    .Add("SefaresheKarBatchSN -> {btSefaresheKarBatch.BatchNO} AS Batch ", "DataCombo",
                          EnumFieldOptions.foDefault)
                    .ComboWhereCondition = "1>1"
                    dbcSefaresheKarBatch = .Component
                    .RefreshCombo()
                    .Caption = "شمار رهگيري"
                End With

                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With

                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub

    Private Sub EnableKalaFields()
        With DVKala
            .Fields("Kala").ReadOnly =
                Not _
                (((.CommandEnabled(EnumCommands.cmAdd) Or .CommandEnabled(EnumCommands.cmSave)) And
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) Or
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) <> DarkhastStatus.Baigani And
                  DVDarkhast.FieldValue("UserID_Name") <> DVKala.FieldValue("UserID_Name") And
                  Val(DVKala.FieldValue("MeghdareErsalShode")) <= 0))
            .Fields("Anbar").ReadOnly =
                Not _
                ((.CommandEnabled(EnumCommands.cmAdd) Or .CommandEnabled(EnumCommands.cmSave)) And
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal Or
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat))
            'Not (.CommandEnabled(EnumCommands.cmEdit)  And .DataRows > 0
            .Fields("MeghdareDarkhasti").ReadOnly =
                Not _
                (((.CommandEnabled(EnumCommands.cmAdd) Or .CommandEnabled(EnumCommands.cmSave)) And
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) Or
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) <> DarkhastStatus.Baigani And
                  DVDarkhast.FieldValue("UserID_Name") <> DVKala.FieldValue("UserID_Name") And
                  Val(DVKala.FieldValue("MeghdareErsalShode")) <= 0))
            'Not (.CommandEnabled(EnumCommands.cmEdit) And Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And .DataRows > 0
            .Fields("Darkhasti_Can_Out").ReadOnly =
                Not _
                (((.CommandEnabled(EnumCommands.cmAdd) Or .CommandEnabled(EnumCommands.cmSave)) And
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) Or
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) <> DarkhastStatus.Baigani And
                  DVDarkhast.FieldValue("UserID_Name") <> DVKala.FieldValue("UserID_Name") And
                  Val(DVKala.FieldValue("MeghdareErsalShode")) <= 0))
            'Not (.CommandEnabled(EnumCommands.cmEdit) And Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And .DataRows > 0
            .Fields("Darkhasti_Box_Out").ReadOnly =
                Not _
                (((.CommandEnabled(EnumCommands.cmAdd) Or .CommandEnabled(EnumCommands.cmSave)) And
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) Or
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) <> DarkhastStatus.Baigani And
                  DVDarkhast.FieldValue("UserID_Name") <> DVKala.FieldValue("UserID_Name") And
                  Val(DVKala.FieldValue("MeghdareErsalShode")) <= 0))
            'Not (.CommandEnabled(EnumCommands.cmEdit) And Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And .DataRows > 0
            .Fields("MeghdareErsali").ReadOnly =
                Not _
                (.CommandEnabled(EnumCommands.cmEdit) And
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal))
            .Fields("Ersali_Box_Out").ReadOnly =
                Not _
                (.CommandEnabled(EnumCommands.cmEdit) And
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal))
            .Fields("Ersali_Can_Out").ReadOnly =
                Not _
                (.CommandEnabled(EnumCommands.cmEdit) And
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                  Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal))

        End With

        With DVDarkhast
            btnDarkhastErsalAll.Enabled =
                (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                 Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal) And
                Not DVKala.CommandVisible(EnumCommands.cmSave)
            btnDarkhastTaeed.Enabled = Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat And
                                       Not DVKala.CommandVisible(EnumCommands.cmSave)
            btnDarkhastBaygani.Enabled =
                (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal Or
                 Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed) And
                Not DVKala.CommandVisible(EnumCommands.cmSave)

            btndarjasan.Enabled =
                (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                Not DVKala.CommandVisible(EnumCommands.cmSave) And
                gDarkhastkala <> 0

            btnDelete.Enabled =
                (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                Not DVKala.CommandVisible(EnumCommands.cmSave)

            If gDarkhastkala <> 1 Then
                btnPrintDarkhast.Enabled =
                    (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal Or
                     Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed) And
                    Not DVKala.CommandVisible(EnumCommands.cmSave)
            Else
                btnPrintDarkhast.Enabled = Not DVKala.CommandVisible(EnumCommands.cmSave)
            End If


            btnFilter.Enabled = Not DVKala.CommandVisible(EnumCommands.cmSave) And
                                Not .CommandVisible(EnumCommands.cmSave)
        End With


    End Sub

    Private Sub DVDarkhast_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVDarkhast.FillDetailsWithData
        With DVDarkhast
            .CommandEnabled(EnumCommands.cmEdit) = (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                                                    (.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) =
                (Val(.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                (.AccessRight And EnumAccessRight.arDelete) <> 0

            If RdoMovaghat.Checked Then
                .CommandEnabled(EnumCommands.cmAdd) = True
            Else
                .CommandEnabled(EnumCommands.cmAdd) = False
            End If

        End With

        EnableDarkhastFields()

        With DVKala
            .AccessRight = DVDarkhast.AccessRight
            .CommandEnabled(EnumCommands.cmAdd) =
                (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat Or
                 Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                 Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal) And
                (DVDarkhast.AccessRight And EnumAccessRight.arInsert) <> 0
            .CommandEnabled(EnumCommands.cmEdit) =
                (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat Or
                 Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.Taeed Or
                 Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.darhaleersal) And
                (DVDarkhast.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) =
                ((Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) Or
                 (Val(DVDarkhast.FieldValue("DarkhastStatus")) <> DarkhastStatus.Baigani And
                  DVDarkhast.FieldValue("UserID_Name") <> DVKala.FieldValue("UserID_Name") And
                  Val(DVKala.FieldValue("MeghdareErsalShode")) <= 0)) And
                (DVDarkhast.AccessRight And EnumAccessRight.arDelete) <> 0 And .DataRows > 0
            EnableKalaFields()
        End With

        With DVBatch
            .AccessRight = DVDarkhast.AccessRight
            .CommandEnabled(EnumCommands.cmAdd) =
                (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                (DVDarkhast.AccessRight And EnumAccessRight.arInsert) <> 0
            .CommandEnabled(EnumCommands.cmEdit) =
                (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                (DVDarkhast.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) =
                (Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat) And
                (DVDarkhast.AccessRight And EnumAccessRight.arDelete) <> 0
        End With

        '    VNoeVoroodeAsnad = Val(DVDarkhast.FlexGrid.TextMatrix(DVDarkhast.FlexGrid.Row, _
        '                                                  DVDarkhast.FlexGrid.ColIndex("NoeVoroodeAsnadSN") + 1))

        If SelectedChanged AndAlso aFetched Then
            GetKartonTedadInfo(DVDarkhast.FieldText("Selected"))
            SelectedChanged = False
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnFilter.Click
        FillDVDarkhast()
    End Sub

    Private Sub frmabDarkhast_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        MinFilterDateCtrl.Done()
        MinFilterDateCtrl = Nothing

        If Not DVDarkhast Is Nothing Then

            DVDarkhast.Done()
            DVDarkhast = Nothing

        End If

        If Not DVKala Is Nothing Then

            DVKala.Done()
            DVKala = Nothing

        End If

        If Not DVBatch Is Nothing Then

            DVBatch.Done()
            DVBatch = Nothing

        End If

    End Sub

    Private Sub btnDarkhastErsalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDarkhastErsalAll.Click
        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer
        Dim mSelected As String
        Dim Str() As String
        Dim OutputSanadSN As Decimal

        If _
            NetSql.Common.CSystem.MsgBox("آيا براي ارسال درخواست با مقادير انتخاب شده مطمئن هستيد؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "ارسال درخواست") = MsgBoxResult.Yes Then

            mSelected =
                Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(DVDarkhast.FlexGrid, "DarkhastSN",
                                                                                       "Selected")
            If mSelected.Length = 0 Then
                MsgBox("درخواستي جهت ارسال انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If

            btnDarkhastErsalAll.Enabled = False

            Str = mSelected.Split(",")
            For i = 0 To Str.Length - 1
                Try
                    If cn.Connection.State = ConnectionState.Closed Then
                        cn.Connection.Open()
                    End If
                    cn.BeginTrans(cn.Connection.BeginTransaction)
                    cn.CallSP("_abSPC_ChangeDarkhastStatus", Str(i), DarkhastStatus.Ersal, gSM.Identifier,
                               gSM.UserID_Name, System.Environment.MachineName, ErrMsg, 0)
                    cn.CommitTrans()

                    If cn.Connection.State = ConnectionState.Open Then
                        cn.Connection.Close()
                    End If
                    cn.RollbackTrans()
                Catch ex As Exception
                    cn.RollbackTrans()
                    NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                End Try
            Next

            btnDarkhastErsalAll.Enabled = gSM.TableAccessRight("btnDarkhastErsalAll") = EnumAccessRight.arAll

            Key = DVDarkhast.CurrentKey
            DVDarkhast.Refresh()
            DVDarkhast.CurrentKey = Key

        End If

    End Sub

    Private Sub btnDarkhastTaeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDarkhastTaeed.Click
        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer

        If DVKala.DataRows <= 0 Then
            NetSql.Common.CSystem.MsgBox("درخواست انتخابي داراي کالا نمي باشد", MsgBoxStyle.Critical, "تاييد درخواست")
            Exit Sub
        End If

        For i = 1 To DVKala.DataRows
            If Val(DVKala.FieldValue("MeghdareDarkhasti", i)) = 0 Then
                NetSql.Common.CSystem.MsgBox("مقدار درخواستي اقلام درخواست نمي تواند صفر باشد.", MsgBoxStyle.Critical, "تاييد درخواست")
                Exit Sub
            End If
        Next

        If _
            NetSql.Common.CSystem.MsgBox("آيا براي تاييد درخواست مطمئن هستيد؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "تاييد درخواست") = MsgBoxResult.Yes Then
            Try

                If cn.Connection.State = ConnectionState.Closed Then
                    cn.Connection.Open()
                End If
                cn.BeginTrans(cn.Connection.BeginTransaction)
                cn.CallSP("_abSPC_ChangeDarkhastStatus", DVDarkhast.FieldValue("DarkhastSN"), DarkhastStatus.Taeed,
                           gSM.Identifier, gSM.UserID_Name, System.Environment.MachineName, ErrMsg, 0)
                cn.CommitTrans()

                Key = DVDarkhast.CurrentKey
                DVDarkhast.Refresh()
                DVDarkhast.CurrentKey = Key

                If cn.Connection.State = ConnectionState.Open Then
                    cn.Connection.Close()
                End If

            Catch ex As Exception
                cn.RollbackTrans()
                NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            End Try
        End If

    End Sub

    Private Sub btnDarkhastBaygani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDarkhastBaygani.Click

        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer
        Dim mSelected As String
        Dim Str() As String

        If NetSql.Common.CSystem.MsgBox("آيا براي بایگانی درخواست های انتخاب شده مطمئن هستيد؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "بایگانی درخواست") = MsgBoxResult.Yes Then

            mSelected = Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(DVDarkhast.FlexGrid, "DarkhastSN", "Selected")
            If mSelected.Length = 0 Then
                MsgBox("درخواستي جهت بایگانی انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If


            Str = mSelected.Split(",")
            For i = 0 To Str.Length - 1
                Try
                    If cn.Connection.State = ConnectionState.Closed Then
                        cn.Connection.Open()
                    End If
                    cn.BeginTrans(cn.Connection.BeginTransaction)
                    cn.CallSP("_abSPC_ChangeDarkhastStatus", Str(i), DarkhastStatus.Baigani, gSM.Identifier,
                               gSM.UserID_Name, System.Environment.MachineName, ErrMsg, 0)
                    cn.CommitTrans()

                    If cn.Connection.State = ConnectionState.Open Then
                        cn.Connection.Close()
                    End If
                    cn.RollbackTrans()
                Catch ex As Exception
                    cn.RollbackTrans()
                    NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                End Try
            Next


            Key = DVDarkhast.CurrentKey
            DVDarkhast.Refresh()
            DVDarkhast.CurrentKey = Key

        End If

    End Sub

    Private Sub dbcTarafHesabSN_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcTarafHesabSN.Enter
        '  با توجه به تراکنش انتخاب شده سند حال با توجه به ارتباط تراکنش انبار و گروه هاي تفصيلي مالي تفصيلي هاي مرتبط نمايش داده ميگردد
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal, vTafsiliSN As Decimal
        Dim VComboWhereB As String

        Dim vGetTaraKoneshGoroohTafsiliSN As String

        VComboWhereB = ""

        Select Case DVDarkhast.FieldValue("TarakoneshSN")
            Case EnumTarakoneshSN.HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_83_BARGASHTE_MAHSOOL_AZ_PAYEKAR _
                , EnumTarakoneshSN.HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                               " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                               " AND (abAnbar.IsTajmie = 3) " &
                               " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                               " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                               " AND (abAnbar.IsTajmie = 2) " &
                               " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "

            Case EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                               " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                               " AND (abAnbar.IsTajmie = 2) " &
                               " AND abAnbar.VahedeTejariSN  IN (3.935,4.935,7.935))) "

            Case EnumTarakoneshSN.HAVALEH_81_ZAYEAT
                VComboWhereB =
                    " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar T1 INNER JOIN abAnbarTarakonesh T2 ON T1.AnbarSN = T2.AnbarSN " &
                    " Where ( ISNULL(T1.AnbarStatus,0) = 1 ) " &
                    " AND (T1.IsTajmie <> 1) AND T2.NoeAnbarSN = 5 " &
                    " AND T1.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
        End Select
        If Val(DVDarkhast.Fields("TafsiliSN").Value) = 0 Then
            vNoeAnbarSN = gNoeAnbarSN
            If Trim(DVDarkhast.Fields("TarakoneshSN").Value) <> "" Then
                vTarakoneshSN = Val(DVDarkhast.Fields("TarakoneshSN").Value)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN =
                    CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVDarkhast.Fields("TafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN + VComboWhereB
            Else
                DVDarkhast.Fields("TafsiliSN").ComboWhereCondition = " 1 = 2 "
            End If
            DVDarkhast.Fields("TafsiliSN").RefreshCombo()
        Else ' If Val(DVDarkhast.Fields("TafsiliSN").Value) = 0 Then 
            vTafsiliSN = DVDarkhast.Fields("TafsiliSN").Value
            vNoeAnbarSN = gNoeAnbarSN
            If Trim(DVDarkhast.Fields("TarakoneshSN").Value) <> "" Then
                vTarakoneshSN = Val(DVDarkhast.Fields("TarakoneshSN").Value)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN =
                    CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVDarkhast.Fields("TafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN
            Else
                DVDarkhast.Fields("TafsiliSN").ComboWhereCondition = " 1 = 2 "
            End If
            DVDarkhast.Fields("TafsiliSN").RefreshCombo()
            'DVDarkhast.Fields("TafsiliSN").Value = vTafsiliSN
        End If
        ' If Val(DVDarkhast.Fields("TafsiliSN").Value) = 0 Then

    End Sub
    ''ghasemi 14010631
    Private Sub dbcTafsiliSN1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcTafsiliSN1.Enter
        ' با توجه به تراکنش سند و ارتباط تراکنش انبار با گروه هاي تفصيلي اطلاعات کامبو تفصيلي نمايش داده ميشود 
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal
        Dim vGoroohTafsiliSN2 As Decimal
        If (Val(DVDarkhast.Fields("TafsiliSN1").Value) = 0) Then
            If (Val(DVDarkhast.Fields("TafsiliSN").Value) <> 0) Then
                vGoroohTafsiliSN2 = Val(DVDarkhast.Fields("TafsiliSN").Value)
                vNoeAnbarSN = gNoeAnbarSN

                If Not (DVDarkhast.Fields("TarakoneshSN").IsEmpty) Then
                    vTarakoneshSN = Val(DVDarkhast.Fields("TarakoneshSN").Value)

                    DVDarkhast.Fields("TafsiliSN1").ComboWhereCondition = " maTafsili2.GoroohTafsiliSN IN " &
                      "(select GoroohTafsiliSN FROM dbo.abFnt_SelectLevel2GoroohTafsili( " &
                      CStr(vTarakoneshSN) & "," & CStr(vNoeAnbarSN) & "," & CStr(vGoroohTafsiliSN2) & " )) "

                Else
                    DVDarkhast.Fields("TafsiliSN1").ComboWhereCondition = " 1 = 2 "
                End If
            Else
                DVDarkhast.Fields("TafsiliSN1").ComboWhereCondition = " 1 = 2 "
            End If
            DVDarkhast.Fields("TafsiliSN1").RefreshCombo()
        End If
    End Sub
    ''ghasemi 14010631

    Private Sub DVKala_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles DVKala.CommandClick
        Dim i As Integer
        Dim checkFlag As Boolean

        Select Case aCommand

            Case EnumCommands.cmSave
                DVKala.Fields("MeghdareErsali").Value = Val(DVKala.Fields("Ersali_Box_out").Value) *
                                                         Val(DVKala.Fields("TedadAjza").Text) +
                                                         Val(DVKala.Fields("Ersali_Can_Out").Value)
                DVKala.Fields("MeghdareDarkhasti").Value = Val(DVKala.Fields("Darkhasti_Box_out").Value) *
                                                            Val(DVKala.Fields("TedadAjza").Text) +
                                                            Val(DVKala.Fields("Darkhasti_Can_Out").Value)

                If DVDarkhast.Fields("DarkhastStatus").Value <> 1 And
                    Val(DVKala.FieldValue("MeghdareErsali")) >
                    Val(DVKala.FieldValue("MeghdareDarkhasti")) - Val(DVKala.FieldValue("MeghdareErsalShode")) Then
                    NetSql.Common.CSystem.MsgBox("مقدار ارسالي نمي تواند بيشتر از مقدار ارسال نشده باشد", MsgBoxStyle.Critical, Me.Text)
                    aCancel = True
                End If

                If Val(DVKala.FieldValue("MeghdareDarkhasti")) <= 0 Then
                    NetSql.Common.CSystem.MsgBox("مقدار درخواستي معتبر نمي باشد", MsgBoxStyle.Critical, Me.Text)
                    aCancel = True
                End If
                If Val(DVDarkhast.FieldValue("DarkhastStatus")) = DarkhastStatus.movaghat Then
                    DVKala.FieldValue("MeghdareErsali") = Val(DVKala.FieldValue("MeghdareDarkhasti")) -
                                                           Val(DVKala.FieldValue("MeghdareErsalShode"))
                End If

                If _
                    DVDarkhast.FieldValue("DarkhastStatus") = DarkhastStatus.darhaleersal OrElse
                    DVDarkhast.FieldValue("DarkhastStatus") = DarkhastStatus.Taeed Then
                    For i = 0 To DVKala.DataRows
                        If Val(DVKala.FieldValue("MeghdareErsali", i)) <> 0 Then
                            checkFlag = True
                            Exit For
                        End If
                    Next

                    If Not checkFlag Then
                        NetSql.Common.CSystem.MsgBox("مقدار ارسالي اقلام درخواست نادرست مي باشد.", MsgBoxStyle.Critical, "ارسال درخواست")
                        aCancel = True
                    End If

                End If

            Case EnumCommands.cmEdit
                If DVDarkhast.FieldText("Selected") = True Then
                    CurKarton = Val(DVKala.FieldValue("Ersali_Box_Out", DVKala.GetKeyRow(DVKala.CurrentKey)))
                    CurTedad = Val(DVKala.FieldValue("Ersali_Can_Out", DVKala.GetKeyRow(DVKala.CurrentKey)))
                End If



        End Select
    End Sub

    Private Sub DVKala_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) _
        Handles DVKala.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmSave
                Dim Key As String

                Key = DVKala.CurrentKey
                DVKala.Refresh()
                DVKala.CurrentKey = Key
        End Select

        If aCommand = EnumCommands.cmSave Then
            Karton = Karton - CurKarton
            Tedad = Tedad - CurTedad
            If DVDarkhast.FieldText("Selected") = True Then _
                GetKartonTedadInfo(True, DVKala.GetKeyRow(DVKala.CurrentKey))
        End If

        EnableKalaFields()

    End Sub

    Private Sub dbcSefaresheKarBatch_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcSefaresheKarBatch.Enter
        With DVBatch.Fields("Batch")
            .ComboWhereCondition = " SefaresheKarSN = " & Val(DVBatch.Fields("SefaresheKarSN").Value)
            .RefreshCombo()
        End With
    End Sub

    Private Sub EnableDarkhastFields()
        ' با توجه به تراکنش رکورد فعال ستونهاي گريد سند و اقلام سند را تنظيم ميکند
        ' Property -> TarakoneshSN
        Dim vAddField_abSanad As EnumAddField_abSanad

        ' تعريف اوليه براي تراکنش براي چگونگي نمايش ستون ها در سند و اقلام سند
        Select Case Val(DVDarkhast.FieldValue("TarakoneshSN"))
            Case EnumTarakoneshSN.HAVALEH_ERSAL_KALAE_AMANI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_BARGASHTE_KALAE_AMANI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_FOROOSH_ZAYEAT
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin
            Case EnumTarakoneshSN.HAVALEH_FOROOSH_MAVAD_GHATEAT_MALZOMAT
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin
            Case EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_63_ODATE_AMANIE_DIGARAN_NAZDE_MA
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_64_TAHVILE_AMANI_BE_DIGARAN
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_83_BARGASHTE_MAHSOOL_AZ_PAYEKAR
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_66_TAHVIL_BE_VAHEDHAYE_TOLIDI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh
                ''CH_R 33-45 Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_67_TAHVIL_BE_Komak_TOLID_Dakhel
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh
                ''CH_R 33-45 Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_68_TAHVIL_BE_Komak_TOLID_Kharej
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin
                ''CH_R 33-45 Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_69_TAHVIL_BE_VAHEDHAYE_GHEYRETOLIDI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh
                ''CH_R 33-45 Or EnumAddField_abSanad.afAddsTafsiliSN1
            Case EnumTarakoneshSN.HAVALEH_71_FOROOSH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or
                                    EnumAddField_abSanad.afAddsShomarehBarnameh Or
                                    EnumAddField_abSanad.afAddsVazneBaskool Or EnumAddField_abSanad.afAddsNameRanandeh
            Case EnumTarakoneshSN.HAVALEH_60_FOROOSHFAREE
                If gNoeAnbarSN = 2 Or gNoeAnbarSN = 5 Or gNoeAnbarSN = 10 Then
                    vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                        EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                        EnumAddField_abSanad.afAddsShomarehMashin Or
                                        EnumAddField_abSanad.afAddsShomarehBarnameh Or
                                        EnumAddField_abSanad.afAddsVazneBaskool Or
                                        EnumAddField_abSanad.afAddsNameRanandeh
                Else
                    vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                        EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                        EnumAddField_abSanad.afAddsShomarehMashin Or
                                        EnumAddField_abSanad.afAddsShomarehBarnameh Or
                                        EnumAddField_abSanad.afAddsVazneBaskool Or
                                        EnumAddField_abSanad.afAddsNameRanandeh
                End If

            Case EnumTarakoneshSN.HAVALEH_72_Barai_Tozi
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_97_Barai_Tozi_MOSTAGIEM
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_74_Masrafe_LAVAZEME_YADAKI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_76_ERSALE_LVAZEME_TAMIRE_MASHIN
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_86_ERSALE_LAVAZEME_TAMIRE_TASISAT
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_87_ERSALE_ALBASE
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_88_ERSALE_BEHDASHTI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_104_ERSALE_AGHLAME_ABDARKHANE
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_90_ERSALE_MASALEH_SAKHTEMANI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_55_ERSALE_LAVAZEME_COPY
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_100_ERSALE_KALAYE_FARHANGI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_101_ERSALE_MALZOOMAT_NEVESHTAFZAR
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_102_ERSALE_ABZARE_MASRAFI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_103_ERSALE_TANZIFAT_MASRAFI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_105_HAVALEH_ERSALEMAHSOOL_AZ_PAYEKAR
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_109_HAVALEH_FOROOSH_AZ_PAYEKAR
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_106_LAVAZEME_TAMIR_NEGAHDARI_ASASIE
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_107_LAVAZEME_TAMIR_NEGAHDARI_NAGHLIE
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_108_ERSALE_SOOKHT
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN

            Case EnumTarakoneshSN.HAVALEH_84_Hazinehae_Omoomi
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or EnumAddField_abSanad.afAddsTarafHesab Or
                                    EnumAddField_abSanad.afAddsTarafHesabSN Or EnumAddField_abSanad.afAddsTafsiliSN1

            Case EnumTarakoneshSN.HAVALEH_85_Mahsoolat_Raigan
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_91_TAHVIL_BE_Co_GOROOH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or
                                    EnumAddField_abSanad.afAddsNameRanandeh Or
                                    EnumAddField_abSanad.afAddsShomarehBarnameh

            Case EnumTarakoneshSN.HAVALEH_96_MASRAFE_Co_GOROOH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin
            Case EnumTarakoneshSN.HAVALEH_92_HADAYA_BE_PERSONEL
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin
            Case EnumTarakoneshSN.HAVALEH_81_ZAYEAT
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_82_MADOOMI
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin

            Case EnumTarakoneshSN.HAVALEH_75_Ersal_Be_Shoab
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehBarnameh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin Or
                                    EnumAddField_abSanad.afAddsNameRanandeh _
                                    Or EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_77_Kalae_Nemooneh
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_78_Bargasht_Kalae_Nemooneh
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_79_Ersal_Mahsool_Be_TozieKonandeh
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehBarnameh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsNameRanandeh Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsVazneBaskool

            Case EnumTarakoneshSN.HAVALEH_93_HavalehKazeb
                vAddField_abSanad = EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_94_DARAE_SABET_MASHHOD
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh

            Case EnumTarakoneshSN.HAVALEH_98_ERSAL_BE_PROJEH
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehBarnameh Or
                                    EnumAddField_abSanad.afAddsShomarehMashin Or EnumAddField_abSanad.afAddsNameRanandeh Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh Or
                                    EnumAddField_abSanad.afAddsVazneBaskool

            Case EnumTarakoneshSN.HAVALEH_99_SADERAT_RAZEGHI
                vAddField_abSanad = EnumAddField_abSanad.afAddsTarafHesabSN Or
                                    EnumAddField_abSanad.afAddsShomarehSefaresh _
                                    Or EnumAddField_abSanad.afAddsShomarehMashin
            Case Else

                vAddField_abSanad = 0

        End Select

        ' با توجه به مقداردهي بالا نمايش هر کدام از فيلدها که مجاز باشد انجام ميگردد
        ' abSanad
        ' Visible .....
        lblTarafHesabSN.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTarafHesabSN
        dbcTarafHesabSN.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTarafHesabSN

        lblTafsiliSN1.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTafsiliSN1
        dbcTafsiliSN1.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTafsiliSN1

        txtShomarehBarnameh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehBarnameh
        lblShomarehBarnameh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehBarnameh

        txtShomarehMashin.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehMashin
        lblShomarehMashin.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehMashin

        txtNameRanandeh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsNameRanandeh
        lblNameRanandeh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsNameRanandeh

        lblShomarehSefaresh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehSefaresh
        txtShomarehSefaresh.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehSefaresh


        txtVazneBaskool.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsVazneBaskool
        lblVazneBaskool.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsVazneBaskool

        txtTarafHesab.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTarafHesab
        lblTarafHesab.Visible = vAddField_abSanad And EnumAddField_abSanad.afAddsTarafHesab
        ' Visible .....

        ' با توجه به مقداردهي بالا نمايش هر کدام از فيلدها که مجاز باشد انجام ميگردد
        ' abSanadHa
        ' شرط پيش فرض براي حالتهاي خاص مورد نياز
        ' ComboWhereCondition
        Select Case Val(DVDarkhast.FieldValue("TarakoneshSN"))

            Case EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
                , EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA _
                ', EnumTarakoneshSN.HAVALEH_83_BARGASHTE_AZ_ANBAR_BE_ANBAR
                DVDarkhast.Fields("EDAnbarSN").ComboWhereCondition = " ( ISNULL(abAnbar2.AnbarStatus,0) = 1 ) " &
                                                                      " AND ( ISNULL(abAnbar2.IsTajmie,0) <> 1  ) " &
                                                                      " AND abAnbar2.VahedeTejariSN  = " &
                                                                      CStr(gVahedeTejariSN)

                With DVKala.FlexGrid
                    ' کنترل نمايش ستونها در مورد انبار با ماهيت واحد سنجش و انبار با ماهيت تعداد در کارتن
                    .ColHidden(.ColIndex("Darkhasti_Box_out")) = gIsTajmie = 1 Or
                                                                   gNoeVoroodeAsnadSN =
                                                                   EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("Darkhasti_Can_out")) = gIsTajmie = 1 Or
                                                                   gNoeVoroodeAsnadSN =
                                                                   EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("MeghdareDarkhasti")) = gIsTajmie <> 1 And
                                                                   gNoeVoroodeAsnadSN =
                                                                   EnumNoeVoroodeAsnad.nvaTedadDarKarton

                    .ColHidden(.ColIndex("Ersali_Box_out")) = gIsTajmie = 1 Or
                                                                gNoeVoroodeAsnadSN =
                                                                EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("Ersali_Can_out")) = gIsTajmie = 1 Or
                                                                gNoeVoroodeAsnadSN =
                                                                EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("MeghdareErsali")) = gIsTajmie <> 1 And
                                                                gNoeVoroodeAsnadSN =
                                                                EnumNoeVoroodeAsnad.nvaTedadDarKarton


                    .ColHidden(.ColIndex("ErsalShode_Box_out")) = gIsTajmie = 1 Or
                                                                    gNoeVoroodeAsnadSN =
                                                                    EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("ErsalShode_Can_out")) = gIsTajmie = 1 Or
                                                                    gNoeVoroodeAsnadSN =
                                                                    EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("MeghdareErsalshodeh")) = gIsTajmie <> 1 And
                                                                     gNoeVoroodeAsnadSN =
                                                                     EnumNoeVoroodeAsnad.nvaTedadDarKarton

                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_TedadAjza")) = gNoeVoroodeAsnadSN =
                                                                              EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_VahedeSanjeshDs")) = gNoeVoroodeAsnadSN =
                                                                                    EnumNoeVoroodeAsnad.
                                                                                        nvaTedadDarKarton

                End With

                lblInfo.Visible = gIsTajmie <> 1 And gNoeVoroodeAsnadSN = EnumNoeVoroodeAsnad.nvaTedadDarKarton And
                                  Not DVDarkhast.FlexGrid.ColHidden(DVDarkhast.FlexGrid.ColIndex("Selected"))

        End Select
        Refresh()

    End Sub

    'Private Sub dbcTarakoneshSN_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    '    Handles dbcTarakoneshSN.SelectedValueChanged
    '    'Dim Vli_TarakoneshSN As Short
    '    If DVDarkhast.FieldValue("TarakoneshSN") <> "" Then
    '        DVDarkhast.Fields("TafsiliSN").Value = ""
    '        DVDarkhast.Fields("TafsiliSN1").Value = ""
    '    End If

    'End Sub

    ''test ghasemi
    Private Sub dbcTarakoneshSN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dbcTarakoneshSN.SelectionChangeCommitted
        'Dim Vli_TarakoneshSN As Short
        If DVDarkhast.FieldValue("TarakoneshSN") <> "" Then
            DVDarkhast.Fields("TafsiliSN").Value = ""
            DVDarkhast.Fields("TafsiliSN1").Value = ""
        End If

    End Sub
    ''test ghasemi
    Private Sub DVDarkhast_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles DVDarkhast.CommandClick
        'Dim vErrMsg As String
        'Dim vResult As Short
        'Dim vVahedeTejariSN, vAnbarSN, vWorkOrederSN, vSanadSN, vNoeAnbarSN, vSanadDate As Object
        'Dim vSanadStatus, vSanadStatusMali, vTarafHesabSN, vTarakoneshSN, vTafsiliSN1, vTafsiliSN2 As Object
        'Dim vEDAnbarSN, vEDNoeAnbarSN As Object
        'Dim vShomarehSefaresh, vTarafHesab As Object
        'Dim vState As Short

        Dim DV As DataView

        Select Case aCommand
            Case EnumCommands.cmRefresh
            Case EnumCommands.cmSave
                If DVabSanad_DataValidation() <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox(DVabSanad_DataValidation,
                               MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                End If

            Case EnumCommands.cmEdit
                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
            Case EnumCommands.cmAdd

                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
            Case EnumCommands.cmDelete

        End Select

    End Sub

    Private Function DVabSanad_DataValidation() As String
        ' کنترل برخي از موارد که نيازي به بانک اطلاعات ندارد
        Dim vShomarehSefaresh As String
        DVabSanad_DataValidation = ""
        vShomarehSefaresh = DVDarkhast.Fields("ShomarehSefaresh").Value
        If Trim(vShomarehSefaresh) <> "" And gVahedeTejariSN <> 7.935 And (Not IsNumeric(vShomarehSefaresh) _
                                               Or InStr(vShomarehSefaresh, ".") <> 0 Or
                                               InStr(vShomarehSefaresh, ",") <> 0) Then
            DVabSanad_DataValidation = "شماره نمي تواند غير عددي باشد"
        End If
    End Function

    Private Sub dbcTarakoneshSN_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcTarakoneshSN.LostFocus
        EnableDarkhastFields()
    End Sub

    Private Sub dbcKala_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbcKala.Enter
        DVKala.Fields("Kala").ComboWhereCondition = "KalaSN IN (Select KalaSN From AbAnbarKala Where AnbarSN =" &
                                             Val(DVKala.FieldValue("Anbar")).ToString & ")"
        DVKala.Fields("Kala").RefreshCombo()
    End Sub

    Private Sub dbcKala_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbcKala.Validated
        ' هنگاميکه کالا در اقلام سند انتخاب ميگردد در قسمت تعداد در کارتن و واحد سنجش اطلاعات نمايش داده ميشود
        Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer
        Dim vKalaSN As Decimal
        Dim vResult As Short

        Try
            If Val(DVKala.Fields("KalaSN").Value) <> 0 Then
                vKalaSN = Val(DVKala.Fields("KalaSN").Value)
                ' بدست آوردن اطلاعات جانبي کالا
                vResult = cn.CallSP("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value,
                                     System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo,
                                     VinVahedeSanjeshDs, VinTedadAjza)
                DVKala.Fields("VahedeSanjeshDs").Text = VinVahedeSanjeshDs
                DVKala.Fields("TedadAjza").Text = VinTedadAjza
                DVKala.Fields("KalaSN").Text = VinKalano
            End If

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub vfgDarkhast_AfterEdit(ByVal eventSender As System.Object,
                                       ByVal eventArgs As RowColEventArgs) _
        Handles vfgDarkhast.AfterEdit


        If eventArgs.Row < vfgDarkhast.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgDarkhast.get_ColIndex("Selected") Then Exit Sub

        DVDarkhast.FieldText("Selected") = vfgDarkhast.GetCellCheck(eventArgs.Row, eventArgs.Col)
        If DVDarkhast.GetKeyRow(DVDarkhast.CurrentKey) = eventArgs.Row Then
            GetKartonTedadInfo(vfgDarkhast.GetCellCheck(eventArgs.Row, eventArgs.Col))
        Else
            SelectedChanged = True
        End If

    End Sub

    Private Sub vfgDarkhast_BeforeEdit(ByVal eventSender As System.Object,
                                        ByVal eventArgs As RowColEventArgs) _
        Handles vfgDarkhast.BeforeEdit

        If eventArgs.Row < vfgDarkhast.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgDarkhast.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
        If DVKala.CommandVisible(EnumCommands.cmSave) Then eventArgs.Cancel = True : Exit Sub

    End Sub

    Private Sub GetKartonTedadInfo(ByVal Selected As Boolean, Optional ByVal Row As Integer = 0)
        Dim FirstRow As Integer
        Dim LastRow As Integer
        Dim i As Integer

        If Row > 0 Then
            FirstRow = Row
            LastRow = Row
        Else
            FirstRow = 1
            LastRow = DVKala.DataRows
        End If

        With DVKala
            If Selected Then
                For i = FirstRow To LastRow
                    Karton += Val(.FieldValue("Ersali_Box_Out", i))
                    Tedad += Val(.FieldValue("Ersali_Can_Out", i))
                Next

            Else
                For i = FirstRow To LastRow
                    Karton -= Val(.FieldValue("Ersali_Box_Out", i))
                    Tedad -= Val(.FieldValue("Ersali_Can_Out", i))
                Next

            End If

            lblInfo.Text = Karton.ToString + " کارتن و " + Tedad.ToString + " عدد "
        End With

    End Sub

    Private Sub FillDVDarkhast()
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات سند بروز رساني ميگردد
        Dim vMinDate As String
        Dim vMaxDate As String
        'Dim vFilterDate As String
        Dim tmpWhereStr As String

        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                               cn,
                                                                               Functions.FTDBCommonFunctions.
                                                                                  enmDateFormat.Normal)
        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting(VB6.GetEXEName(), "Setting", "MinDateabDarkhast", MinFilterDateCtrl.Value)
        End If

        Karton = 0
        Tedad = 0

        With DVDarkhast.FlexGrid

            If RdoMovaghat.Checked Then
                tmpWhereStr = " AND DarkhastStatus = " & DarkhastStatus.movaghat

                '.ColHidden(.ColIndex("Selected")) = True
                DVDarkhast.AutoFetchCurrentRow = True
            ElseIf RdoBaygani.Checked Then
                tmpWhereStr = " AND DarkhastStatus = " & DarkhastStatus.Baigani
                .ColHidden(.ColIndex("Selected")) = True
                DVDarkhast.AutoFetchCurrentRow = False
            ElseIf RdoTaeed.Checked Then
                tmpWhereStr = " AND (DarkhastStatus = " & DarkhastStatus.Taeed & " or DarkhastStatus = " &
                              DarkhastStatus.darhaleersal & " )"
                '.ColHidden(.ColIndex("Selected")) = False
                DVDarkhast.AutoFetchCurrentRow = False
            ElseIf RdoErsalShode.Checked Then
                tmpWhereStr = " AND DarkhastStatus = " & DarkhastStatus.Ersal
                .ColHidden(.ColIndex("Selected")) = True
                DVDarkhast.AutoFetchCurrentRow = False
            ElseIf RdoTafkikMovaghat.Checked Then
                tmpWhereStr = " And DarkhastSN In (Select DarkhastSn from absanad Where TarakoneshSN=125) "
                .ColHidden(.ColIndex("Selected")) = True
                DVDarkhast.AutoFetchCurrentRow = False
            End If
        End With

        lblInfo.Visible = gIsTajmie <> 1 And gNoeVoroodeAsnadSN = EnumNoeVoroodeAsnad.nvaTedadDarKarton And
                          RdoTaeed.Checked
        DVDarkhast.SQLWhere = "FromDate between '" & MinFilterDateCtrl.Value & "'  AND  '" & gHesabdariSalTDate &
                              "' AND abDarkhast.VahedeTejariSN = " & gVahedeTejariSN & tmpWhereStr &
                              IIf(gIsTajmie = 1, "", " AND AnbarSN = " & gAnbarSN.ToString) &
                              IIf(gSM.ActionVisible("ViewAll_abDarkhast"), "", " and abDarkhast.UserID_Name = '" & gSM.UserID_Name & "'")

        DVDarkhast.Refresh()
        lblInfo.Text = Karton.ToString + " کارتن و " + Tedad.ToString + " عدد "
    End Sub

    Private Sub btnPrintDarkhast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPrintDarkhast.Click

        If gDarkhastkala = 1 Then  ''''' چاپ درخواست خاص داروئی
            Dim vRptabDarkhast As New Report.RptabDarkhast_KhasDaroo
            With vRptabDarkhast
                .DefField()
                Dim _str As String = "_abSpr_Darkhast ''," & gVahedeTejariSN.ToString & ",null," & DVDarkhast.FieldValue("FromDate") & "," & DVDarkhast.FieldValue("ToDate") & " ,null,'" & DVDarkhast.FieldValue("DarkhastStatus") & "',null,null,null," & DVDarkhast.FieldValue("DarkhastSN") & ",0"
                .DataSource = cn.ExecuteQuery(_str)

                Minoo.Reports.FTReportViewer.ShowReport(vRptabDarkhast, Me.MdiParent)
            End With
        Else
            Dim vRptabDarkhast As New Report.RptabDarkhast
            With vRptabDarkhast
                .DefField()
                .lblBarnameh.Text = DVDarkhast.FieldValue("ShomarehBarnameh")
                .lblKamiun.Text = DVDarkhast.FieldValue("ShomarehMashin")
                .lblRanandeh.Text = DVDarkhast.FieldValue("Nameranandeh")
                Dim _str As String = "_abSpr_Darkhast ''," & gVahedeTejariSN.ToString & ",null," & DVDarkhast.FieldValue("FromDate") & "," & DVDarkhast.FieldValue("ToDate") & " ,null,'" & DVDarkhast.FieldValue("DarkhastStatus") & "',null,null,null," & DVDarkhast.FieldValue("DarkhastSN") & ",0"
                .DataSource = cn.ExecuteQuery(_str)

                Minoo.Reports.FTReportViewer.ShowReport(vRptabDarkhast, Me.MdiParent)
            End With
        End If

    End Sub

    Private Sub btndarjasan_Click(sender As System.Object, e As System.EventArgs) Handles btndarjasan.Click

        Dim _frm As New frmDarjasanmavad

        _frm.DarkhastSN = DVDarkhast.Fields("DarkhastSN").Value
        _frm.ShowDialog()

        DVKala.Refresh()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        ' امکاني براي حذف گروهي اقلام سند
        Dim vSanadHaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_abdarkhastkalaSN() As Decimal
        Dim VCount_darkhastkalaSN As Short
        With DVKala
            If (Not .CommandEnabled(EnumCommands.cmEdit)) Or (.State = EnumDataViewState.bsEdit) _
               Or (.State = EnumDataViewState.bsAdd) Then
                Exit Sub
            End If

            If NetSql.Common.CSystem.MsgBox(" آيا رکوردهاي انتخاب شده حذف گردد ؟ ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                With DVDarkhast
                    If Val(.FieldValue("DarkhastStatus")) <> DarkhastStatus.movaghat Then
                        NetSql.Common.CSystem.MsgBox("فقط درخواست از نوع موقت را می توان حذف نمود", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                        Exit Sub
                    End If
                End With
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVKala.FlexGrid
                    VCount_darkhastkalaSN = .SelectedRows
                    ReDim V_ar_abdarkhastkalaSN(VCount_darkhastkalaSN)
                    For i = 0 To VCount_darkhastkalaSN - 1
                        V_ar_abdarkhastkalaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("DarkhastKalaSN")))
                    Next
                End With
                ' فراخواني اس پي براي تک تک اقلام سند انتخاب شده جهت حذف رکورد
                For i = 0 To VCount_darkhastkalaSN - 1
                    vSN = Val(V_ar_abdarkhastkalaSN(i))
                    If vSN <> 0 Then
                        cn.CallSP("abDarkhastKala_Delete", vSN)
                    End If
                Next
                DVKala.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With
    End Sub

    Private Sub DVKala_GetGridProperties() Handles DVKala.GetGridProperties
        ' امکان انتخاب گروهي فعال گردد
        With DVKala.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    'Private Sub RdoMovaghat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoMovaghat.CheckedChanged, RdoErsalShode.CheckedChanged, RdoBaygani.CheckedChanged, RdoTaeed.CheckedChanged
    '    If RdoMovaghat.Checked Or RdoTaeed.Checked Or RdoErsalShode.Checked Or RdoBaygani.Checked Then
    '        btnFilter_Click(sender, New System.EventArgs)
    '    End If
    'End Sub

    Private Sub DVKala_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVKala.FillDetailsWithData
        If Not RdoMovaghat.Checked Then
            DVKala.CommandEnabled(EnumCommands.cmAdd) = False
        End If
        txtMojoodi_GhabeleErsal.Text = ""
        txtMojoodi_TahteBarrasi.Text = ""
        Dim _AnbarsnPayekar As Decimal
        Dim _NoeAnbarsnPayekar As Decimal
        If aFetched And RdoTaeed.Checked Then
            If Val(DVKala.Fields("KalaSN").Value) <> 0 Then
                Try
                    Dim dv As New DataView
                    dv = cn.ExecuteQuery("select dbo.abFn_GetMojoodiKala_NoeTarakoneshKala(" & gVahedeTejariSN & "," & gAnbarSN & "," & gNoeAnbarSN & "," & DVKala.Fields("KalaSN").Value & ",'" & Replace(txtToDate.Text, "/", "") & "','2,4,5')")
                    If dv.Count = 1 Then
                        txtMojoodi_GhabeleErsal.Text = dv(0)(0)
                    End If
                    Dim dv2 As New DataView
                    dv2 = cn.ExecuteQuery("select dbo.abFn_GetMojoodiKala_NoeTarakoneshKala(" & gVahedeTejariSN & "," & gAnbarSN & "," & gNoeAnbarSN & "," & DVKala.Fields("KalaSN").Value & ",'" & Replace(txtToDate.Text, "/", "") & "','1,6')")
                    If dv2.Count = 1 Then
                        txtMojoodi_TahteBarrasi.Text = dv2(0)(0)
                    End If
                    '-------------- yekta 920521 -------------------------
                    Dim dv3 As New DataView
                    dv3 = cn.ExecuteQuery("select anbarsn from abanbar where PayeSN=" & DVDarkhast.Fields.Item("TafsiliSN").Value())
                    If dv3.Count = 1 Then
                        _AnbarsnPayekar = dv3(0)(0)
                    End If
                    Dim dv4 As New DataView
                    dv4 = cn.ExecuteQuery("select TOP 1 NoeAnbarSN from absanad where AnbarSN=" & _AnbarsnPayekar & " order by SanadSN ")
                    If dv4.Count = 1 Then
                        _NoeAnbarsnPayekar = dv4(0)(0)
                    End If
                    Dim dv5 As New DataView
                    dv5 = cn.ExecuteQuery("select dbo.abFn_GetMojoodiKala_NoeTarakoneshKala(" & gVahedeTejariSN & "," & _AnbarsnPayekar & "," & _NoeAnbarsnPayekar & "," & DVKala.Fields("KalaSN").Value & ",'" & Replace(txtToDate.Text, "/", "") & "','2,4,5')")
                    If dv5.Count = 1 Then
                        txtMojoodi_GhabeleErsalePayekar.Text = dv5(0)(0)
                    End If
                    Dim dv6 As New DataView
                    dv6 = cn.ExecuteQuery("select dbo.abFn_GetMojoodiKala_NoeTarakoneshKala(" & gVahedeTejariSN & "," & _AnbarsnPayekar & "," & _NoeAnbarsnPayekar & "," & DVKala.Fields("KalaSN").Value & ",'" & Replace(txtToDate.Text, "/", "") & "','1,6')")
                    If dv6.Count = 1 Then
                        txtMojoodi_TahteBarrasiePayekar.Text = dv6(0)(0)
                    End If
                    '-------------- yekta 920521 -------------------------
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub RdoTaeed_Click(sender As System.Object, e As System.EventArgs) Handles RdoTaeed.Click, RdoBaygani.Click, RdoErsalShode.Click, RdoMovaghat.Click, RdoTafkikMovaghat.Click
        If RdoMovaghat.Checked Or RdoTaeed.Checked Or RdoErsalShode.Checked Or RdoBaygani.Checked Or RdoTafkikMovaghat.Checked Then
            btnFilter_Click(sender, New System.EventArgs)
        End If
        If RdoTaeed.Checked AndAlso gSM.TableAccessRight("btnDarkhastErsalAll") = EnumAccessRight.arAll Then
            lblMojoodi_GhabeleErsal.Visible = True
            txtMojoodi_GhabeleErsal.Visible = True

            lblMojoodi_TahteBarrasi.Visible = True
            txtMojoodi_TahteBarrasi.Visible = True
        Else
            lblMojoodi_GhabeleErsal.Visible = False
            txtMojoodi_GhabeleErsal.Visible = False

            lblMojoodi_TahteBarrasi.Visible = False
            txtMojoodi_TahteBarrasi.Visible = False
        End If
    End Sub

    Private Sub btnTafkik_Click(sender As System.Object, e As System.EventArgs) Handles btnTafkik.Click
        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer
        Dim mSelected As String
        Dim Str() As String
        Dim OutputSanadSN As Decimal
        Dim StrAsnad As String
        'Dim _TypeghazaDaroo As Int16 = 0
        Dim TafsiliCount As DataView

        StrAsnad = ""


        'If gSM.ActionHaveAccess("MnuTafkik_Daroo", SecurityManager.FTSecurityManager.EnumAccess.acVisible) = True Then
        '    _TypeghazaDaroo = 1
        'End If


        If _
            NetSql.Common.CSystem.MsgBox("آيا براي تفکیک درخواست با مقادير انتخاب شده مطمئن هستيد؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "تفکیک درخواست") = MsgBoxResult.Yes Then

            mSelected =
                Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(DVDarkhast.FlexGrid, "DarkhastSN",
                                                                                       "Selected")
            If mSelected.Length = 0 Then
                MsgBox("درخواستي جهت تفکیک انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If

            btnDarkhastErsalAll.Enabled = False

            '------------yekta 951204 کنترل انتخاب درخواست های مربوط به یک شعبه برای کالاهای دارویی ---------------
            'If (_TypeghazaDaroo = 1) Then
            '    Try

            '        TafsiliCount = cn.ExecuteQuery("select distinct(TafsiliSN) from abDarkhast where DarkhastSN in (" + mSelected + ")")
            '        If TafsiliCount.Count > 1 Then
            '            NetSql.Common.CSystem.MsgBox("فقط درخواست های مربوط به یک شعبه را انتخاب کنید", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
            '            Exit Sub
            '        End If
            '    Catch ex As Exception
            '        NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            '        Exit Sub
            '    End Try
            'End If
            '------------------------------------------------------------------------------------------------------------

            Str = mSelected.Split(",")
            For i = 0 To Str.Length - 1
                Try
                    If cn.Connection.State = ConnectionState.Closed Then
                        cn.Connection.Open()
                    End If
                    cn.BeginTrans(cn.Connection.BeginTransaction)
                    cn.CallSP("_abSP_SodoorHavaleTafkikMovaghat", Str(i), DarkhastStatus.Ersal, gSM.Identifier,
                               gSM.UserID_Name, System.Environment.MachineName, ErrMsg, OutputSanadSN)
                    cn.CommitTrans()

                    If i = Str.Length - 1 Then
                        StrAsnad = StrAsnad + OutputSanadSN.ToString()
                    Else
                        StrAsnad = StrAsnad + OutputSanadSN.ToString() + ","
                    End If


                    If cn.Connection.State = ConnectionState.Open Then
                        cn.Connection.Close()
                    End If
                    cn.RollbackTrans()
                Catch ex As Exception
                    cn.RollbackTrans()
                    NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                End Try
            Next


            Try
                If cn.Connection.State = ConnectionState.Closed Then
                    cn.Connection.Open()
                End If
                cn.BeginTrans(cn.Connection.BeginTransaction)
                cn.CallSP("_abSP_SodooreListTafkik", StrAsnad, gSM.Identifier,
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

            btnDarkhastErsalAll.Enabled = gSM.TableAccessRight("btnDarkhastErsalAll") = EnumAccessRight.arAll

            Key = DVDarkhast.CurrentKey
            DVDarkhast.Refresh()
            DVDarkhast.CurrentKey = Key
            'If _TypeghazaDaroo = 1 Then
            Dim vFrmabTafkik As New FrmabTafkik_New
            With vFrmabTafkik
                .ShowDialog()
                .Close()
                .Dispose()
            End With
            'Else
            '    Dim vFrmabTafkik As New FrmabTafkik
            '    With vFrmabTafkik
            '        .TypeghazaDaroo = _TypeghazaDaroo
            '        .ShowDialog()
            '        .Close()
            '        .Dispose()

            '    End With
            'End If

        End If
    End Sub

    Private Sub btnHazfDarkhast_Click(sender As Object, e As EventArgs) Handles btnHazfDarkhastErsalnashodeh.Click

        ''ghasemi  حذف درخواست های ارسال نشده
        'Dim ErrMsg As String = ""
        'Dim Key As String

        'If NetSql.Common.CSystem.MsgBox("آيا رکورد انتخاب شده حذف گردد؟",
        '        MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
        '        MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "حذف درخواست ارسال نشده") = MsgBoxResult.Yes Then
        '    Try

        '        If cn.Connection.State = ConnectionState.Closed Then
        '            cn.Connection.Open()
        '        End If
        '        cn.BeginTrans(cn.Connection.BeginTransaction)
        '        cn.CallSP("_abSPC_HazfDarkhastersalnashode", gAnbarSN, DVDarkhast.FieldValue("DarkhastSN"), ErrMsg)
        '        cn.CommitTrans()

        '        Key = DVDarkhast.CurrentKey
        '        DVDarkhast.Refresh()
        '        DVDarkhast.CurrentKey = Key

        '        If cn.Connection.State = ConnectionState.Open Then
        '            cn.Connection.Close()
        '        End If

        '    Catch ex As Exception
        '        cn.RollbackTrans()
        '        '' ErrMsg = ex.Message
        '        NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        '    End Try
        'End If

        'DVDarkhast.Refresh()
        ''ghasemi

        ''test
        Dim ErrMsg As String = ""
        Dim Key As String
        Dim i As Integer
        Dim mSelected As String
        Dim Str() As String
        Dim OutputSanadSN As Decimal

        If _
            NetSql.Common.CSystem.MsgBox("آيا براي تغییر وضعیت ( برگرداندن) درخواست های ارسال نشده مطمئن هستيد؟",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or
                       MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "تغییر وضعیت(برگرداندن) درخواست ارسال نشده") = MsgBoxResult.Yes Then

            mSelected = Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(DVDarkhast.FlexGrid, "DarkhastSN", "Selected")
            If mSelected.Length = 0 Then
                MsgBox("درخواستي جهت تغییر وضعیت (برگرداندن) انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If


            Str = mSelected.Split(",")
            For i = 0 To Str.Length - 1
                Try
                    If cn.Connection.State = ConnectionState.Closed Then
                        cn.Connection.Open()
                    End If
                    cn.BeginTrans(cn.Connection.BeginTransaction)

                    'cn.CallSP("_abSPC_HazfDarkhastersalnashode", gAnbarSN, DVDarkhast.FieldValue("DarkhastSN"), ErrMsg)
                    cn.CallSP("_abSPC_HazfDarkhastersalnashode", gAnbarSN, Str(i), ErrMsg)
                    cn.CommitTrans()

                    If cn.Connection.State = ConnectionState.Open Then
                        cn.Connection.Close()
                    End If
                    cn.RollbackTrans()
                Catch ex As Exception
                    cn.RollbackTrans()
                    NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
                End Try
            Next

            Key = DVDarkhast.CurrentKey
            DVDarkhast.Refresh()
            DVDarkhast.CurrentKey = Key

        End If
        DVDarkhast.Refresh()
        ''test
    End Sub


End Class

