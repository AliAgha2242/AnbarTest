
' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/02/21
'ModifiedDate::
'Description::  ‌ثبت وبروزآوري اسناد انبار
' کليه اسناد انبار از هر نوع بوسيله اين فرم ثبت و بروزآوري ميگردد
' کليه اسناد مقداري خواه وارده يا صادره 
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports VB = Microsoft.VisualBasic
Imports Minoo.Applications.Anbar.WebServiceCaller
Imports Anbar.BRL
Imports System.Data.SqlClient
Imports System
Imports System.Net




Friend Class FrmSanad
    Inherits Minoo.Base.FTBaseForm

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'If m_vb6FormDefInstance Is Nothing Then
        '  If m_InitializingDefInstance Then
        '    m_vb6FormDefInstance = Me
        '  Else
        '    Try
        '      If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
        '        m_vb6FormDefInstance = Me
        '      End If
        '    Catch
        '    End Try
        '  End If
        'End If
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnStatus1_4 As System.Windows.Forms.Button
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Public WithEvents lblFromDate As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents btnStatus4_8 As System.Windows.Forms.Button
    Public WithEvents pnlN1 As System.Windows.Forms.Panel
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents txtVazneBaskool As System.Windows.Forms.TextBox
    Public WithEvents txtNameRanandeh As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehMashin As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehBarnameh As System.Windows.Forms.TextBox
    Public WithEvents txtTozih As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehSefaresh As System.Windows.Forms.TextBox
    Public WithEvents txtSanadNO As System.Windows.Forms.TextBox
    Public WithEvents txtSanadDate As System.Windows.Forms.TextBox
    Public WithEvents txtSanadSN As System.Windows.Forms.TextBox
    Public WithEvents dbcAnbarSN As NetSql.Components.DataCombo
    Public WithEvents dbcTarakoneshSN As NetSql.Components.DataCombo
    Public WithEvents dbcNoeAnbarSN As NetSql.Components.DataCombo
    Public WithEvents dbcTarafHesabSN As NetSql.Components.DataCombo
    Public WithEvents dbcSanadStatus As NetSql.Components.DataCombo
    Public WithEvents txtMoaserDate As System.Windows.Forms.TextBox
    Public WithEvents dbcTafsiliSN1 As NetSql.Components.DataCombo
    Public WithEvents lblTafsiliSN1 As System.Windows.Forms.Label
    Public WithEvents lblVazneBaskool As System.Windows.Forms.Label
    Public WithEvents lblNameRanandeh As System.Windows.Forms.Label
    Public WithEvents lblShomarehMashin As System.Windows.Forms.Label
    Public WithEvents lblShomarehBarnameh As System.Windows.Forms.Label
    Public WithEvents lblSanadStatus As System.Windows.Forms.Label
    Public WithEvents lblTarafHesabSN As System.Windows.Forms.Label
    Public WithEvents lblNoeAnbarSN As System.Windows.Forms.Label
    Public WithEvents lblAnbarSN As System.Windows.Forms.Label
    Public WithEvents lblTozih As System.Windows.Forms.Label
    Public WithEvents lblShomarehSefaresh As System.Windows.Forms.Label
    Public WithEvents lblSanadNO As System.Windows.Forms.Label
    Public WithEvents lblSanadDate As System.Windows.Forms.Label
    Public WithEvents lblTarakoneshSN As System.Windows.Forms.Label

    Public WithEvents lblMoaserDate As System.Windows.Forms.Label
    Public WithEvents pnlD As System.Windows.Forms.Panel
    Public WithEvents _sstParent_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents _sstParent_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents sstParent As Minoo.Controls.FTTabControl
    Public WithEvents pnlG1 As System.Windows.Forms.Panel
    Public WithEvents pnlC1 As System.Windows.Forms.Panel
    Public WithEvents _sstChild_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents sstChild As Minoo.Controls.FTTabControl
    Friend WithEvents lblTarafHesab As System.Windows.Forms.Label
    Public WithEvents txtTarafHesab As System.Windows.Forms.TextBox
    Friend WithEvents tmrF8 As System.Windows.Forms.Timer
    Public WithEvents lblNoeMarjooei As System.Windows.Forms.Label
    Friend WithEvents pnlNoeMarjooei As System.Windows.Forms.Panel
    Public WithEvents dbcNoeMarjooeiSNB As NetSql.Components.DataCombo
    Public WithEvents btnUpdateMarjooei As System.Windows.Forms.Button
    Public WithEvents btnExcel As System.Windows.Forms.Button
    Public WithEvents btnDelSelected As System.Windows.Forms.Button
    Friend WithEvents dcbMarjaSanadSN As NetSql.Components.DataCombo
    Public WithEvents btnEslahie As System.Windows.Forms.Button
    Public WithEvents txtSabtDate As System.Windows.Forms.TextBox
    Public WithEvents btnSpecifications As System.Windows.Forms.Button
    Friend WithEvents tmrF9 As System.Windows.Forms.Timer
    Public WithEvents btnEslahRahgiri As System.Windows.Forms.Button
    Friend WithEvents tmrF10 As System.Windows.Forms.Timer
    Friend WithEvents tmrF11 As System.Windows.Forms.Timer
    Public WithEvents btnDarjAghlamFactor As System.Windows.Forms.Button
    Friend WithEvents btnRahgiri As System.Windows.Forms.Button
    Public WithEvents tabBarnameh As System.Windows.Forms.TabPage
    Public WithEvents btnPrintBargeKhorooj As System.Windows.Forms.Button
    Public WithEvents btnListBarnameh As System.Windows.Forms.Button
    Public WithEvents btnErsalBeDP As System.Windows.Forms.Button
    Friend WithEvents pnlcBarnameh As System.Windows.Forms.Panel
    Friend WithEvents pnlgBarnameh As System.Windows.Forms.Panel
    Friend WithEvents btnDarkhstView As System.Windows.Forms.Button
    Friend WithEvents TabDarkhast As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents pnlN2 As System.Windows.Forms.Panel
    Public WithEvents pnlG2 As System.Windows.Forms.Panel
    Public WithEvents pnlC2 As System.Windows.Forms.Panel
    Friend WithEvents TabChideman As System.Windows.Forms.TabPage
    Public WithEvents pnlN3 As System.Windows.Forms.Panel
    Public WithEvents pnlG3 As System.Windows.Forms.Panel
    Public WithEvents pnlC3 As System.Windows.Forms.Panel
    Public WithEvents BtnPrintLabel As System.Windows.Forms.Button
    Friend WithEvents GrpPrintLabel As System.Windows.Forms.GroupBox
    Friend WithEvents PrintLabelUD As System.Windows.Forms.NumericUpDown
    Public WithEvents lblPrintLabel As System.Windows.Forms.Label
    Public WithEvents BtnEnteghalMojoodi As Button
    Public WithEvents BtnPrintHavalehTolid As Button
    Public WithEvents dbcRezSN2 As NetSql.Components.DataCombo
    Public WithEvents lblRezSN2 As Label
    Friend WithEvents TabDaftar As TabPage
    Public WithEvents PnlNDaftar As Panel
    Public WithEvents PnlGdaftar As Panel
    Public WithEvents PnlCDaftar As Panel
    Public WithEvents BtnUpdateBatchNoeEngheza As Button
    Public WithEvents btnSabtSanaddarSamaneh As Button
    Friend WithEvents ChkAutoTransferToKartablZayeat As CheckBox
    Public WithEvents BtnSabtUID As Button
    Public WithEvents Label1 As Label
    Friend WithEvents ChkIsFakorEbtal As CheckBox
    Public WithEvents DcbForooshDarkhast As NetSql.Components.DataCombo
    Friend WithEvents LblForooshDarkhast As Label
    Friend WithEvents TabProductCatalogue As TabPage
    Public WithEvents PnlGProductCatalogue As Panel
    Friend WithEvents TabSanadHaFactor As TabPage
    Public WithEvents PnlGSanadHaFactor As Panel
    Friend WithEvents dcbMarjaSanadSN2 As NetSql.Components.DataCombo
    Public WithEvents lblMarjaSanadSN As Label
    Public WithEvents btnEslahSanad As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSanad))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEnteghalMojoodi = New System.Windows.Forms.Button()
        Me.btnStatus1_4 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.btnSpecifications = New System.Windows.Forms.Button()
        Me.btnEslahie = New System.Windows.Forms.Button()
        Me.txtMinDate = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnStatus4_8 = New System.Windows.Forms.Button()
        Me.pnlN1 = New System.Windows.Forms.Panel()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.sstParent = New Minoo.Controls.FTTabControl()
        Me._sstParent_TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me._sstParent_TabPage0 = New System.Windows.Forms.TabPage()
        Me.pnlD = New System.Windows.Forms.Panel()
        Me.lblMarjaSanadSN = New System.Windows.Forms.Label()
        Me.dcbMarjaSanadSN2 = New NetSql.Components.DataCombo(Me.components)
        Me.DcbForooshDarkhast = New NetSql.Components.DataCombo(Me.components)
        Me.LblForooshDarkhast = New System.Windows.Forms.Label()
        Me.ChkIsFakorEbtal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkAutoTransferToKartablZayeat = New System.Windows.Forms.CheckBox()
        Me.dbcRezSN2 = New NetSql.Components.DataCombo(Me.components)
        Me.lblRezSN2 = New System.Windows.Forms.Label()
        Me.lblTarafHesab = New System.Windows.Forms.Label()
        Me.txtTarafHesab = New System.Windows.Forms.TextBox()
        Me.txtVazneBaskool = New System.Windows.Forms.TextBox()
        Me.txtNameRanandeh = New System.Windows.Forms.TextBox()
        Me.txtShomarehMashin = New System.Windows.Forms.TextBox()
        Me.txtShomarehBarnameh = New System.Windows.Forms.TextBox()
        Me.txtTozih = New System.Windows.Forms.TextBox()
        Me.txtShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.txtSanadNO = New System.Windows.Forms.TextBox()
        Me.txtSanadSN = New System.Windows.Forms.TextBox()
        Me.dbcAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTarakoneshSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcNoeAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTarafHesabSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcSanadStatus = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTafsiliSN1 = New NetSql.Components.DataCombo(Me.components)
        Me.lblTafsiliSN1 = New System.Windows.Forms.Label()
        Me.lblVazneBaskool = New System.Windows.Forms.Label()
        Me.lblNameRanandeh = New System.Windows.Forms.Label()
        Me.lblShomarehMashin = New System.Windows.Forms.Label()
        Me.lblShomarehBarnameh = New System.Windows.Forms.Label()
        Me.lblSanadStatus = New System.Windows.Forms.Label()
        Me.lblTarafHesabSN = New System.Windows.Forms.Label()
        Me.lblNoeAnbarSN = New System.Windows.Forms.Label()
        Me.lblAnbarSN = New System.Windows.Forms.Label()
        Me.lblTozih = New System.Windows.Forms.Label()
        Me.lblShomarehSefaresh = New System.Windows.Forms.Label()
        Me.lblSanadNO = New System.Windows.Forms.Label()
        Me.lblSanadDate = New System.Windows.Forms.Label()
        Me.lblTarakoneshSN = New System.Windows.Forms.Label()
        Me.lblMoaserDate = New System.Windows.Forms.Label()
        Me.dcbMarjaSanadSN = New NetSql.Components.DataCombo(Me.components)
        Me.txtSanadDate = New System.Windows.Forms.TextBox()
        Me.txtSabtDate = New System.Windows.Forms.TextBox()
        Me.txtMoaserDate = New System.Windows.Forms.TextBox()
        Me.sstChild = New Minoo.Controls.FTTabControl()
        Me._sstChild_TabPage1 = New System.Windows.Forms.TabPage()
        Me.GrpPrintLabel = New System.Windows.Forms.GroupBox()
        Me.BtnPrintLabel = New System.Windows.Forms.Button()
        Me.PrintLabelUD = New System.Windows.Forms.NumericUpDown()
        Me.lblPrintLabel = New System.Windows.Forms.Label()
        Me.pnlG1 = New System.Windows.Forms.Panel()
        Me.btnDarkhstView = New System.Windows.Forms.Button()
        Me.pnlC1 = New System.Windows.Forms.Panel()
        Me.btnDelSelected = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnRahgiri = New System.Windows.Forms.Button()
        Me.tabBarnameh = New System.Windows.Forms.TabPage()
        Me.btnPrintBargeKhorooj = New System.Windows.Forms.Button()
        Me.pnlcBarnameh = New System.Windows.Forms.Panel()
        Me.btnListBarnameh = New System.Windows.Forms.Button()
        Me.pnlgBarnameh = New System.Windows.Forms.Panel()
        Me.btnErsalBeDP = New System.Windows.Forms.Button()
        Me.TabDarkhast = New System.Windows.Forms.TabPage()
        Me.pnlN2 = New System.Windows.Forms.Panel()
        Me.pnlG2 = New System.Windows.Forms.Panel()
        Me.pnlC2 = New System.Windows.Forms.Panel()
        Me.TabChideman = New System.Windows.Forms.TabPage()
        Me.pnlN3 = New System.Windows.Forms.Panel()
        Me.pnlG3 = New System.Windows.Forms.Panel()
        Me.pnlC3 = New System.Windows.Forms.Panel()
        Me.TabDaftar = New System.Windows.Forms.TabPage()
        Me.PnlNDaftar = New System.Windows.Forms.Panel()
        Me.PnlGdaftar = New System.Windows.Forms.Panel()
        Me.PnlCDaftar = New System.Windows.Forms.Panel()
        Me.TabProductCatalogue = New System.Windows.Forms.TabPage()
        Me.PnlGProductCatalogue = New System.Windows.Forms.Panel()
        Me.TabSanadHaFactor = New System.Windows.Forms.TabPage()
        Me.PnlGSanadHaFactor = New System.Windows.Forms.Panel()
        Me.tmrF8 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlNoeMarjooei = New System.Windows.Forms.Panel()
        Me.lblNoeMarjooei = New System.Windows.Forms.Label()
        Me.btnUpdateMarjooei = New System.Windows.Forms.Button()
        Me.dbcNoeMarjooeiSNB = New NetSql.Components.DataCombo(Me.components)
        Me.tmrF9 = New System.Windows.Forms.Timer(Me.components)
        Me.btnEslahRahgiri = New System.Windows.Forms.Button()
        Me.tmrF10 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrF11 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDarjAghlamFactor = New System.Windows.Forms.Button()
        Me.btnEslahSanad = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSabtUID = New System.Windows.Forms.Button()
        Me.BtnUpdateBatchNoeEngheza = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSabtSanaddarSamaneh = New System.Windows.Forms.Button()
        Me.BtnPrintHavalehTolid = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.sstParent.SuspendLayout()
        Me._sstParent_TabPage1.SuspendLayout()
        Me._sstParent_TabPage0.SuspendLayout()
        Me.pnlD.SuspendLayout()
        Me.sstChild.SuspendLayout()
        Me._sstChild_TabPage1.SuspendLayout()
        Me.GrpPrintLabel.SuspendLayout()
        CType(Me.PrintLabelUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBarnameh.SuspendLayout()
        Me.TabDarkhast.SuspendLayout()
        Me.TabChideman.SuspendLayout()
        Me.TabDaftar.SuspendLayout()
        Me.TabProductCatalogue.SuspendLayout()
        Me.TabSanadHaFactor.SuspendLayout()
        Me.pnlNoeMarjooei.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEnteghalMojoodi
        '
        Me.BtnEnteghalMojoodi.BackColor = System.Drawing.Color.Transparent
        Me.BtnEnteghalMojoodi.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEnteghalMojoodi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEnteghalMojoodi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnEnteghalMojoodi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEnteghalMojoodi.Location = New System.Drawing.Point(265, 291)
        Me.BtnEnteghalMojoodi.Name = "BtnEnteghalMojoodi"
        Me.BtnEnteghalMojoodi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnEnteghalMojoodi.Size = New System.Drawing.Size(123, 21)
        Me.BtnEnteghalMojoodi.TabIndex = 0
        Me.BtnEnteghalMojoodi.TabStop = False
        Me.BtnEnteghalMojoodi.Text = "انتقال موجودی رهگیری"
        Me.ToolTip1.SetToolTip(Me.BtnEnteghalMojoodi, "از طریق این فرآیند می توانید موجودی را از یک رهگیری به رهگیری دیگر در سطح یک محصو" &
        "ل انجام دهید")
        Me.BtnEnteghalMojoodi.UseVisualStyleBackColor = False
        '
        'btnStatus1_4
        '
        Me.btnStatus1_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus1_4.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus1_4.Enabled = False
        Me.btnStatus1_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus1_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus1_4.Location = New System.Drawing.Point(927, 5)
        Me.btnStatus1_4.Name = "btnStatus1_4"
        Me.btnStatus1_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus1_4.Size = New System.Drawing.Size(40, 32)
        Me.btnStatus1_4.TabIndex = 1
        Me.btnStatus1_4.Text = "موقت"
        Me.btnStatus1_4.UseVisualStyleBackColor = False
        Me.btnStatus1_4.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.btnSpecifications)
        Me.Frame1.Controls.Add(Me.btnEslahie)
        Me.Frame1.Controls.Add(Me.txtMinDate)
        Me.Frame1.Controls.Add(Me.btnFilter)
        Me.Frame1.Controls.Add(Me.lblFromDate)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(75, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(516, 25)
        Me.Frame1.TabIndex = 6
        '
        'btnSpecifications
        '
        Me.btnSpecifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpecifications.BackColor = System.Drawing.Color.Transparent
        Me.btnSpecifications.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSpecifications.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSpecifications.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSpecifications.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSpecifications.Location = New System.Drawing.Point(6, 3)
        Me.btnSpecifications.Name = "btnSpecifications"
        Me.btnSpecifications.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSpecifications.Size = New System.Drawing.Size(100, 21)
        Me.btnSpecifications.TabIndex = 10
        Me.btnSpecifications.Text = "مشخصات سند"
        Me.btnSpecifications.UseVisualStyleBackColor = False
        '
        'btnEslahie
        '
        Me.btnEslahie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEslahie.BackColor = System.Drawing.Color.Transparent
        Me.btnEslahie.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEslahie.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEslahie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnEslahie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEslahie.Location = New System.Drawing.Point(116, 3)
        Me.btnEslahie.Name = "btnEslahie"
        Me.btnEslahie.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnEslahie.Size = New System.Drawing.Size(150, 21)
        Me.btnEslahie.TabIndex = 9
        Me.btnEslahie.Text = "مشاهده اسناد اصلاحي"
        Me.btnEslahie.UseVisualStyleBackColor = False
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point(325, 2)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size(115, 21)
        Me.txtMinDate.TabIndex = 1
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(269, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size(50, 21)
        Me.btnFilter.TabIndex = 0
        Me.btnFilter.Tag = ""
        Me.btnFilter.Text = "انتخاب"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFromDate.Location = New System.Drawing.Point(446, 6)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFromDate.Size = New System.Drawing.Size(38, 13)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "از تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnStatus4_8
        '
        Me.btnStatus4_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus4_8.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus4_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus4_8.Enabled = False
        Me.btnStatus4_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus4_8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus4_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus4_8.Location = New System.Drawing.Point(885, 5)
        Me.btnStatus4_8.Name = "btnStatus4_8"
        Me.btnStatus4_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus4_8.Size = New System.Drawing.Size(40, 32)
        Me.btnStatus4_8.TabIndex = 2
        Me.btnStatus4_8.Text = "قطعي"
        Me.btnStatus4_8.UseVisualStyleBackColor = False
        Me.btnStatus4_8.Visible = False
        '
        'pnlN1
        '
        Me.pnlN1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN1.Location = New System.Drawing.Point(4, 283)
        Me.pnlN1.Name = "pnlN1"
        Me.pnlN1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN1.Size = New System.Drawing.Size(320, 37)
        Me.pnlN1.TabIndex = 4
        '
        'pnlN
        '
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 4)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(298, 37)
        Me.pnlN.TabIndex = 3
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(969, 2)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(405, 37)
        Me.pnlC.TabIndex = 0
        '
        'sstParent
        '
        Me.sstParent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstParent.Controls.Add(Me._sstParent_TabPage1)
        Me.sstParent.Controls.Add(Me._sstParent_TabPage0)
        Me.sstParent.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstParent.ItemSize = New System.Drawing.Size(42, 23)
        Me.sstParent.Location = New System.Drawing.Point(2, 0)
        Me.sstParent.Mirrored = True
        Me.sstParent.Name = "sstParent"
        Me.sstParent.SelectedIndex = 0
        Me.sstParent.Size = New System.Drawing.Size(1381, 241)
        Me.sstParent.TabIndex = 7
        '
        '_sstParent_TabPage1
        '
        Me._sstParent_TabPage1.Controls.Add(Me.pnlG)
        Me._sstParent_TabPage1.Location = New System.Drawing.Point(4, 27)
        Me._sstParent_TabPage1.Name = "_sstParent_TabPage1"
        Me._sstParent_TabPage1.Size = New System.Drawing.Size(1176, 210)
        Me._sstParent_TabPage1.TabIndex = 1
        Me._sstParent_TabPage1.Text = "مشاهده كليه اسناد"
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(3, 6)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(1172, 207)
        Me.pnlG.TabIndex = 8
        '
        '_sstParent_TabPage0
        '
        Me._sstParent_TabPage0.Controls.Add(Me.pnlD)
        Me._sstParent_TabPage0.Location = New System.Drawing.Point(4, 27)
        Me._sstParent_TabPage0.Name = "_sstParent_TabPage0"
        Me._sstParent_TabPage0.Size = New System.Drawing.Size(1373, 210)
        Me._sstParent_TabPage0.TabIndex = 0
        Me._sstParent_TabPage0.Text = "مشاهده سند خاص"
        '
        'pnlD
        '
        Me.pnlD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlD.BackColor = System.Drawing.SystemColors.Control
        Me.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlD.Controls.Add(Me.lblMarjaSanadSN)
        Me.pnlD.Controls.Add(Me.dcbMarjaSanadSN2)
        Me.pnlD.Controls.Add(Me.DcbForooshDarkhast)
        Me.pnlD.Controls.Add(Me.LblForooshDarkhast)
        Me.pnlD.Controls.Add(Me.ChkIsFakorEbtal)
        Me.pnlD.Controls.Add(Me.Label1)
        Me.pnlD.Controls.Add(Me.ChkAutoTransferToKartablZayeat)
        Me.pnlD.Controls.Add(Me.dbcRezSN2)
        Me.pnlD.Controls.Add(Me.lblRezSN2)
        Me.pnlD.Controls.Add(Me.lblTarafHesab)
        Me.pnlD.Controls.Add(Me.txtTarafHesab)
        Me.pnlD.Controls.Add(Me.txtVazneBaskool)
        Me.pnlD.Controls.Add(Me.txtNameRanandeh)
        Me.pnlD.Controls.Add(Me.txtShomarehMashin)
        Me.pnlD.Controls.Add(Me.txtShomarehBarnameh)
        Me.pnlD.Controls.Add(Me.txtTozih)
        Me.pnlD.Controls.Add(Me.txtShomarehSefaresh)
        Me.pnlD.Controls.Add(Me.txtSanadNO)
        Me.pnlD.Controls.Add(Me.txtSanadSN)
        Me.pnlD.Controls.Add(Me.dbcAnbarSN)
        Me.pnlD.Controls.Add(Me.dbcTarakoneshSN)
        Me.pnlD.Controls.Add(Me.dbcNoeAnbarSN)
        Me.pnlD.Controls.Add(Me.dbcTarafHesabSN)
        Me.pnlD.Controls.Add(Me.dbcSanadStatus)
        Me.pnlD.Controls.Add(Me.dbcTafsiliSN1)
        Me.pnlD.Controls.Add(Me.lblTafsiliSN1)
        Me.pnlD.Controls.Add(Me.lblVazneBaskool)
        Me.pnlD.Controls.Add(Me.lblNameRanandeh)
        Me.pnlD.Controls.Add(Me.lblShomarehMashin)
        Me.pnlD.Controls.Add(Me.lblShomarehBarnameh)
        Me.pnlD.Controls.Add(Me.lblSanadStatus)
        Me.pnlD.Controls.Add(Me.lblTarafHesabSN)
        Me.pnlD.Controls.Add(Me.lblNoeAnbarSN)
        Me.pnlD.Controls.Add(Me.lblAnbarSN)
        Me.pnlD.Controls.Add(Me.lblTozih)
        Me.pnlD.Controls.Add(Me.lblShomarehSefaresh)
        Me.pnlD.Controls.Add(Me.lblSanadNO)
        Me.pnlD.Controls.Add(Me.lblSanadDate)
        Me.pnlD.Controls.Add(Me.lblTarakoneshSN)
        Me.pnlD.Controls.Add(Me.lblMoaserDate)
        Me.pnlD.Controls.Add(Me.dcbMarjaSanadSN)
        Me.pnlD.Controls.Add(Me.txtSanadDate)
        Me.pnlD.Controls.Add(Me.txtSabtDate)
        Me.pnlD.Controls.Add(Me.txtMoaserDate)
        Me.pnlD.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlD.Location = New System.Drawing.Point(2, 2)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlD.Size = New System.Drawing.Size(1368, 208)
        Me.pnlD.TabIndex = 0
        Me.pnlD.TabStop = True
        '
        'lblMarjaSanadSN
        '
        Me.lblMarjaSanadSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarjaSanadSN.AutoSize = True
        Me.lblMarjaSanadSN.BackColor = System.Drawing.Color.Transparent
        Me.lblMarjaSanadSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMarjaSanadSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarjaSanadSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMarjaSanadSN.Location = New System.Drawing.Point(1270, 90)
        Me.lblMarjaSanadSN.Name = "lblMarjaSanadSN"
        Me.lblMarjaSanadSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMarjaSanadSN.Size = New System.Drawing.Size(55, 13)
        Me.lblMarjaSanadSN.TabIndex = 89
        Me.lblMarjaSanadSN.Text = "سند مرجع"
        Me.lblMarjaSanadSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMarjaSanadSN.Visible = False
        '
        'dcbMarjaSanadSN2
        '
        Me.dcbMarjaSanadSN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbMarjaSanadSN2.AutoSelectFirst = False
        Me.dcbMarjaSanadSN2.BackColor = System.Drawing.Color.White
        Me.dcbMarjaSanadSN2.BoundText = Nothing
        Me.dcbMarjaSanadSN2.BypassChangeEvent = False
        Me.dcbMarjaSanadSN2.DisplayText = ""
        Me.dcbMarjaSanadSN2.LateBindingTop = "500"
        Me.dcbMarjaSanadSN2.Location = New System.Drawing.Point(990, 108)
        Me.dcbMarjaSanadSN2.MemFilter = ""
        Me.dcbMarjaSanadSN2.Name = "dcbMarjaSanadSN2"
        Me.dcbMarjaSanadSN2.SeparatedData = Nothing
        Me.dcbMarjaSanadSN2.Size = New System.Drawing.Size(333, 21)
        Me.dcbMarjaSanadSN2.Source = Nothing
        Me.dcbMarjaSanadSN2.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbMarjaSanadSN2.TabIndex = 88
        Me.dcbMarjaSanadSN2.Visible = False
        '
        'DcbForooshDarkhast
        '
        Me.DcbForooshDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DcbForooshDarkhast.AutoSelectFirst = False
        Me.DcbForooshDarkhast.BackColor = System.Drawing.Color.White
        Me.DcbForooshDarkhast.BoundText = Nothing
        Me.DcbForooshDarkhast.BypassChangeEvent = False
        Me.DcbForooshDarkhast.DisplayText = ""
        Me.DcbForooshDarkhast.LateBindingTop = "100"
        Me.DcbForooshDarkhast.Location = New System.Drawing.Point(387, 26)
        Me.DcbForooshDarkhast.MemFilter = ""
        Me.DcbForooshDarkhast.Name = "DcbForooshDarkhast"
        Me.DcbForooshDarkhast.SeparatedData = Nothing
        Me.DcbForooshDarkhast.Size = New System.Drawing.Size(645, 21)
        Me.DcbForooshDarkhast.Source = Nothing
        Me.DcbForooshDarkhast.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.DcbForooshDarkhast.TabIndex = 87
        '
        'LblForooshDarkhast
        '
        Me.LblForooshDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblForooshDarkhast.Location = New System.Drawing.Point(899, 6)
        Me.LblForooshDarkhast.Name = "LblForooshDarkhast"
        Me.LblForooshDarkhast.Size = New System.Drawing.Size(130, 17)
        Me.LblForooshDarkhast.TabIndex = 86
        Me.LblForooshDarkhast.Text = "شماره درخواست فروش"
        '
        'ChkIsFakorEbtal
        '
        Me.ChkIsFakorEbtal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIsFakorEbtal.AutoSize = True
        Me.ChkIsFakorEbtal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkIsFakorEbtal.Location = New System.Drawing.Point(377, 175)
        Me.ChkIsFakorEbtal.Name = "ChkIsFakorEbtal"
        Me.ChkIsFakorEbtal.Size = New System.Drawing.Size(135, 18)
        Me.ChkIsFakorEbtal.TabIndex = 85
        Me.ChkIsFakorEbtal.Text = "کل فاکتور مرجوع شود"
        Me.ChkIsFakorEbtal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(288, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "سریال سند"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ChkAutoTransferToKartablZayeat
        '
        Me.ChkAutoTransferToKartablZayeat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAutoTransferToKartablZayeat.AutoSize = True
        Me.ChkAutoTransferToKartablZayeat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkAutoTransferToKartablZayeat.Location = New System.Drawing.Point(556, 175)
        Me.ChkAutoTransferToKartablZayeat.Name = "ChkAutoTransferToKartablZayeat"
        Me.ChkAutoTransferToKartablZayeat.Size = New System.Drawing.Size(172, 18)
        Me.ChkAutoTransferToKartablZayeat.TabIndex = 83
        Me.ChkAutoTransferToKartablZayeat.Text = "انتقال سند به کارتابل ضایعات"
        Me.ChkAutoTransferToKartablZayeat.UseVisualStyleBackColor = True
        '
        'dbcRezSN2
        '
        Me.dbcRezSN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcRezSN2.AutoSelectFirst = False
        Me.dbcRezSN2.BackColor = System.Drawing.Color.White
        Me.dbcRezSN2.BoundText = Nothing
        Me.dbcRezSN2.BypassChangeEvent = False
        Me.dbcRezSN2.DisplayText = ""
        Me.dbcRezSN2.LateBindingTop = "100"
        Me.dbcRezSN2.Location = New System.Drawing.Point(387, 108)
        Me.dbcRezSN2.MemFilter = ""
        Me.dbcRezSN2.Name = "dbcRezSN2"
        Me.dbcRezSN2.SeparatedData = Nothing
        Me.dbcRezSN2.Size = New System.Drawing.Size(253, 21)
        Me.dbcRezSN2.Source = Nothing
        Me.dbcRezSN2.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcRezSN2.TabIndex = 82
        Me.dbcRezSN2.Visible = False
        '
        'lblRezSN2
        '
        Me.lblRezSN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRezSN2.AutoSize = True
        Me.lblRezSN2.BackColor = System.Drawing.Color.Transparent
        Me.lblRezSN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRezSN2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRezSN2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRezSN2.Location = New System.Drawing.Point(580, 90)
        Me.lblRezSN2.Name = "lblRezSN2"
        Me.lblRezSN2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRezSN2.Size = New System.Drawing.Size(57, 13)
        Me.lblRezSN2.TabIndex = 81
        Me.lblRezSN2.Text = "دفتر فروش"
        Me.lblRezSN2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblRezSN2.Visible = False
        '
        'lblTarafHesab
        '
        Me.lblTarafHesab.Location = New System.Drawing.Point(545, 132)
        Me.lblTarafHesab.Name = "lblTarafHesab"
        Me.lblTarafHesab.Size = New System.Drawing.Size(87, 15)
        Me.lblTarafHesab.TabIndex = 19
        Me.lblTarafHesab.Text = "طرف حساب"
        Me.lblTarafHesab.Visible = False
        '
        'txtTarafHesab
        '
        Me.txtTarafHesab.AcceptsReturn = True
        Me.txtTarafHesab.BackColor = System.Drawing.SystemColors.Window
        Me.txtTarafHesab.Location = New System.Drawing.Point(497, 149)
        Me.txtTarafHesab.Name = "txtTarafHesab"
        Me.txtTarafHesab.Size = New System.Drawing.Size(138, 21)
        Me.txtTarafHesab.TabIndex = 20
        Me.txtTarafHesab.Visible = False
        '
        'txtVazneBaskool
        '
        Me.txtVazneBaskool.AcceptsReturn = True
        Me.txtVazneBaskool.BackColor = System.Drawing.SystemColors.Window
        Me.txtVazneBaskool.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtVazneBaskool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVazneBaskool.Location = New System.Drawing.Point(185, 149)
        Me.txtVazneBaskool.MaxLength = 0
        Me.txtVazneBaskool.Name = "txtVazneBaskool"
        Me.txtVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVazneBaskool.Size = New System.Drawing.Size(151, 21)
        Me.txtVazneBaskool.TabIndex = 28
        Me.txtVazneBaskool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVazneBaskool.Visible = False
        '
        'txtNameRanandeh
        '
        Me.txtNameRanandeh.AcceptsReturn = True
        Me.txtNameRanandeh.BackColor = System.Drawing.SystemColors.Window
        Me.txtNameRanandeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNameRanandeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNameRanandeh.Location = New System.Drawing.Point(27, 148)
        Me.txtNameRanandeh.MaxLength = 0
        Me.txtNameRanandeh.Name = "txtNameRanandeh"
        Me.txtNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNameRanandeh.Size = New System.Drawing.Size(149, 21)
        Me.txtNameRanandeh.TabIndex = 26
        Me.txtNameRanandeh.Visible = False
        '
        'txtShomarehMashin
        '
        Me.txtShomarehMashin.AcceptsReturn = True
        Me.txtShomarehMashin.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehMashin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehMashin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehMashin.Location = New System.Drawing.Point(27, 106)
        Me.txtShomarehMashin.MaxLength = 0
        Me.txtShomarehMashin.Name = "txtShomarehMashin"
        Me.txtShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehMashin.Size = New System.Drawing.Size(149, 21)
        Me.txtShomarehMashin.TabIndex = 24
        Me.txtShomarehMashin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShomarehMashin.Visible = False
        '
        'txtShomarehBarnameh
        '
        Me.txtShomarehBarnameh.AcceptsReturn = True
        Me.txtShomarehBarnameh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehBarnameh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehBarnameh.Location = New System.Drawing.Point(185, 106)
        Me.txtShomarehBarnameh.MaxLength = 0
        Me.txtShomarehBarnameh.Name = "txtShomarehBarnameh"
        Me.txtShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehBarnameh.Size = New System.Drawing.Size(151, 21)
        Me.txtShomarehBarnameh.TabIndex = 22
        Me.txtShomarehBarnameh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShomarehBarnameh.Visible = False
        '
        'txtTozih
        '
        Me.txtTozih.AcceptsReturn = True
        Me.txtTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTozih.BackColor = System.Drawing.SystemColors.Window
        Me.txtTozih.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTozih.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTozih.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTozih.Location = New System.Drawing.Point(745, 176)
        Me.txtTozih.MaxLength = 0
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTozih.Size = New System.Drawing.Size(577, 20)
        Me.txtTozih.TabIndex = 30
        '
        'txtShomarehSefaresh
        '
        Me.txtShomarehSefaresh.AcceptsReturn = True
        Me.txtShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehSefaresh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehSefaresh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehSefaresh.Location = New System.Drawing.Point(1102, 150)
        Me.txtShomarehSefaresh.MaxLength = 0
        Me.txtShomarehSefaresh.Name = "txtShomarehSefaresh"
        Me.txtShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehSefaresh.Size = New System.Drawing.Size(220, 21)
        Me.txtShomarehSefaresh.TabIndex = 15
        Me.txtShomarehSefaresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShomarehSefaresh.Visible = False
        '
        'txtSanadNO
        '
        Me.txtSanadNO.AcceptsReturn = True
        Me.txtSanadNO.BackColor = System.Drawing.SystemColors.Window
        Me.txtSanadNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSanadNO.Enabled = False
        Me.txtSanadNO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSanadNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSanadNO.Location = New System.Drawing.Point(153, 2)
        Me.txtSanadNO.MaxLength = 0
        Me.txtSanadNO.Name = "txtSanadNO"
        Me.txtSanadNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSanadNO.Size = New System.Drawing.Size(131, 21)
        Me.txtSanadNO.TabIndex = 3
        Me.txtSanadNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSanadSN
        '
        Me.txtSanadSN.AcceptsReturn = True
        Me.txtSanadSN.BackColor = System.Drawing.SystemColors.Window
        Me.txtSanadSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSanadSN.Enabled = False
        Me.txtSanadSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSanadSN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSanadSN.Location = New System.Drawing.Point(153, 26)
        Me.txtSanadSN.MaxLength = 0
        Me.txtSanadSN.Name = "txtSanadSN"
        Me.txtSanadSN.ReadOnly = True
        Me.txtSanadSN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSanadSN.Size = New System.Drawing.Size(131, 21)
        Me.txtSanadSN.TabIndex = 8
        '
        'dbcAnbarSN
        '
        Me.dbcAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcAnbarSN.AutoSelectFirst = False
        Me.dbcAnbarSN.BackColor = System.Drawing.Color.White
        Me.dbcAnbarSN.BoundText = Nothing
        Me.dbcAnbarSN.BypassChangeEvent = False
        Me.dbcAnbarSN.DisplayText = ""
        Me.dbcAnbarSN.Enabled = False
        Me.dbcAnbarSN.LateBindingTop = "100"
        Me.dbcAnbarSN.Location = New System.Drawing.Point(1038, 26)
        Me.dbcAnbarSN.MemFilter = ""
        Me.dbcAnbarSN.Name = "dbcAnbarSN"
        Me.dbcAnbarSN.SeparatedData = Nothing
        Me.dbcAnbarSN.Size = New System.Drawing.Size(285, 21)
        Me.dbcAnbarSN.Source = Nothing
        Me.dbcAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcAnbarSN.TabIndex = 5
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
        Me.dbcTarakoneshSN.Location = New System.Drawing.Point(1038, 2)
        Me.dbcTarakoneshSN.MemFilter = ""
        Me.dbcTarakoneshSN.Name = "dbcTarakoneshSN"
        Me.dbcTarakoneshSN.SeparatedData = Nothing
        Me.dbcTarakoneshSN.Size = New System.Drawing.Size(285, 21)
        Me.dbcTarakoneshSN.Source = Nothing
        Me.dbcTarakoneshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarakoneshSN.TabIndex = 1
        '
        'dbcNoeAnbarSN
        '
        Me.dbcNoeAnbarSN.AutoSelectFirst = False
        Me.dbcNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dbcNoeAnbarSN.BoundText = Nothing
        Me.dbcNoeAnbarSN.BypassChangeEvent = False
        Me.dbcNoeAnbarSN.DisplayText = ""
        Me.dbcNoeAnbarSN.LateBindingTop = "100"
        Me.dbcNoeAnbarSN.Location = New System.Drawing.Point(27, 26)
        Me.dbcNoeAnbarSN.MemFilter = ""
        Me.dbcNoeAnbarSN.Name = "dbcNoeAnbarSN"
        Me.dbcNoeAnbarSN.SeparatedData = Nothing
        Me.dbcNoeAnbarSN.Size = New System.Drawing.Size(120, 21)
        Me.dbcNoeAnbarSN.Source = Nothing
        Me.dbcNoeAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcNoeAnbarSN.TabIndex = 7
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
        Me.dbcTarafHesabSN.Location = New System.Drawing.Point(387, 66)
        Me.dbcTarafHesabSN.MemFilter = ""
        Me.dbcTarafHesabSN.Name = "dbcTarafHesabSN"
        Me.dbcTarafHesabSN.SeparatedData = Nothing
        Me.dbcTarafHesabSN.Size = New System.Drawing.Size(834, 21)
        Me.dbcTarafHesabSN.Source = Nothing
        Me.dbcTarafHesabSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarafHesabSN.TabIndex = 13
        Me.dbcTarafHesabSN.Visible = False
        '
        'dbcSanadStatus
        '
        Me.dbcSanadStatus.AutoSelectFirst = False
        Me.dbcSanadStatus.BackColor = System.Drawing.Color.White
        Me.dbcSanadStatus.BoundText = Nothing
        Me.dbcSanadStatus.BypassChangeEvent = False
        Me.dbcSanadStatus.DisplayText = ""
        Me.dbcSanadStatus.LateBindingTop = "100"
        Me.dbcSanadStatus.Location = New System.Drawing.Point(39, 174)
        Me.dbcSanadStatus.MemFilter = ""
        Me.dbcSanadStatus.Name = "dbcSanadStatus"
        Me.dbcSanadStatus.SeparatedData = Nothing
        Me.dbcSanadStatus.Size = New System.Drawing.Size(99, 21)
        Me.dbcSanadStatus.Source = Nothing
        Me.dbcSanadStatus.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcSanadStatus.TabIndex = 32
        Me.dbcSanadStatus.Visible = False
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
        Me.dbcTafsiliSN1.Location = New System.Drawing.Point(646, 108)
        Me.dbcTafsiliSN1.MemFilter = ""
        Me.dbcTafsiliSN1.Name = "dbcTafsiliSN1"
        Me.dbcTafsiliSN1.SeparatedData = Nothing
        Me.dbcTafsiliSN1.Size = New System.Drawing.Size(338, 21)
        Me.dbcTafsiliSN1.Source = Nothing
        Me.dbcTafsiliSN1.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTafsiliSN1.TabIndex = 18
        Me.dbcTafsiliSN1.Visible = False
        '
        'lblTafsiliSN1
        '
        Me.lblTafsiliSN1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTafsiliSN1.AutoSize = True
        Me.lblTafsiliSN1.BackColor = System.Drawing.Color.Transparent
        Me.lblTafsiliSN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTafsiliSN1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTafsiliSN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTafsiliSN1.Location = New System.Drawing.Point(912, 90)
        Me.lblTafsiliSN1.Name = "lblTafsiliSN1"
        Me.lblTafsiliSN1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTafsiliSN1.Size = New System.Drawing.Size(73, 13)
        Me.lblTafsiliSN1.TabIndex = 17
        Me.lblTafsiliSN1.Text = "طرف حساب-2"
        Me.lblTafsiliSN1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTafsiliSN1.Visible = False
        '
        'lblVazneBaskool
        '
        Me.lblVazneBaskool.AutoSize = True
        Me.lblVazneBaskool.BackColor = System.Drawing.Color.Transparent
        Me.lblVazneBaskool.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVazneBaskool.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVazneBaskool.Location = New System.Drawing.Point(232, 132)
        Me.lblVazneBaskool.Name = "lblVazneBaskool"
        Me.lblVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVazneBaskool.Size = New System.Drawing.Size(104, 13)
        Me.lblVazneBaskool.TabIndex = 27
        Me.lblVazneBaskool.Text = "وزن باسکول فرستنده"
        Me.lblVazneBaskool.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblVazneBaskool.Visible = False
        '
        'lblNameRanandeh
        '
        Me.lblNameRanandeh.AutoSize = True
        Me.lblNameRanandeh.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRanandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNameRanandeh.Location = New System.Drawing.Point(131, 130)
        Me.lblNameRanandeh.Name = "lblNameRanandeh"
        Me.lblNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNameRanandeh.Size = New System.Drawing.Size(48, 13)
        Me.lblNameRanandeh.TabIndex = 25
        Me.lblNameRanandeh.Text = "نام راننده"
        Me.lblNameRanandeh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblNameRanandeh.Visible = False
        '
        'lblShomarehMashin
        '
        Me.lblShomarehMashin.AutoSize = True
        Me.lblShomarehMashin.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehMashin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehMashin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehMashin.Location = New System.Drawing.Point(107, 90)
        Me.lblShomarehMashin.Name = "lblShomarehMashin"
        Me.lblShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehMashin.Size = New System.Drawing.Size(72, 13)
        Me.lblShomarehMashin.TabIndex = 23
        Me.lblShomarehMashin.Text = "شماره ماشين"
        Me.lblShomarehMashin.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblShomarehMashin.Visible = False
        '
        'lblShomarehBarnameh
        '
        Me.lblShomarehBarnameh.AutoSize = True
        Me.lblShomarehBarnameh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehBarnameh.Location = New System.Drawing.Point(268, 90)
        Me.lblShomarehBarnameh.Name = "lblShomarehBarnameh"
        Me.lblShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehBarnameh.Size = New System.Drawing.Size(68, 13)
        Me.lblShomarehBarnameh.TabIndex = 21
        Me.lblShomarehBarnameh.Text = "شماره بارنامه"
        Me.lblShomarehBarnameh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblShomarehBarnameh.Visible = False
        '
        'lblSanadStatus
        '
        Me.lblSanadStatus.AutoSize = True
        Me.lblSanadStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadStatus.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanadStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadStatus.Location = New System.Drawing.Point(144, 177)
        Me.lblSanadStatus.Name = "lblSanadStatus"
        Me.lblSanadStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadStatus.Size = New System.Drawing.Size(41, 13)
        Me.lblSanadStatus.TabIndex = 31
        Me.lblSanadStatus.Text = "وضعيت"
        Me.lblSanadStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSanadStatus.Visible = False
        '
        'lblTarafHesabSN
        '
        Me.lblTarafHesabSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarafHesabSN.AutoSize = True
        Me.lblTarafHesabSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarafHesabSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarafHesabSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarafHesabSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarafHesabSN.Location = New System.Drawing.Point(1167, 50)
        Me.lblTarafHesabSN.Name = "lblTarafHesabSN"
        Me.lblTarafHesabSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarafHesabSN.Size = New System.Drawing.Size(63, 13)
        Me.lblTarafHesabSN.TabIndex = 12
        Me.lblTarafHesabSN.Text = "طرف حساب"
        Me.lblTarafHesabSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTarafHesabSN.Visible = False
        '
        'lblNoeAnbarSN
        '
        Me.lblNoeAnbarSN.AutoSize = True
        Me.lblNoeAnbarSN.BackColor = System.Drawing.Color.Transparent
        Me.lblNoeAnbarSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoeAnbarSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoeAnbarSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoeAnbarSN.Location = New System.Drawing.Point(99, 5)
        Me.lblNoeAnbarSN.Name = "lblNoeAnbarSN"
        Me.lblNoeAnbarSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNoeAnbarSN.Size = New System.Drawing.Size(42, 13)
        Me.lblNoeAnbarSN.TabIndex = 6
        Me.lblNoeAnbarSN.Text = "نوع انبار"
        Me.lblNoeAnbarSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAnbarSN
        '
        Me.lblAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnbarSN.AutoSize = True
        Me.lblAnbarSN.BackColor = System.Drawing.Color.Transparent
        Me.lblAnbarSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnbarSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnbarSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAnbarSN.Location = New System.Drawing.Point(1326, 30)
        Me.lblAnbarSN.Name = "lblAnbarSN"
        Me.lblAnbarSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAnbarSN.Size = New System.Drawing.Size(24, 13)
        Me.lblAnbarSN.TabIndex = 4
        Me.lblAnbarSN.Text = "انبار"
        Me.lblAnbarSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTozih
        '
        Me.lblTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTozih.AutoSize = True
        Me.lblTozih.BackColor = System.Drawing.Color.Transparent
        Me.lblTozih.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTozih.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTozih.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTozih.Location = New System.Drawing.Point(1324, 180)
        Me.lblTozih.Name = "lblTozih"
        Me.lblTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTozih.Size = New System.Drawing.Size(36, 13)
        Me.lblTozih.TabIndex = 29
        Me.lblTozih.Text = "توضيح"
        Me.lblTozih.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShomarehSefaresh
        '
        Me.lblShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehSefaresh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehSefaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehSefaresh.Location = New System.Drawing.Point(990, 131)
        Me.lblShomarehSefaresh.Name = "lblShomarehSefaresh"
        Me.lblShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehSefaresh.Size = New System.Drawing.Size(335, 16)
        Me.lblShomarehSefaresh.TabIndex = 14
        Me.lblShomarehSefaresh.Text = "شماره ارجاع"
        Me.lblShomarehSefaresh.Visible = False
        '
        'lblSanadNO
        '
        Me.lblSanadNO.AutoSize = True
        Me.lblSanadNO.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadNO.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanadNO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadNO.Location = New System.Drawing.Point(288, 6)
        Me.lblSanadNO.Name = "lblSanadNO"
        Me.lblSanadNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadNO.Size = New System.Drawing.Size(61, 13)
        Me.lblSanadNO.TabIndex = 2
        Me.lblSanadNO.Text = "شماره سند"
        Me.lblSanadNO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSanadDate
        '
        Me.lblSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSanadDate.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadDate.Location = New System.Drawing.Point(1293, 51)
        Me.lblSanadDate.Name = "lblSanadDate"
        Me.lblSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadDate.Size = New System.Drawing.Size(29, 13)
        Me.lblSanadDate.TabIndex = 9
        Me.lblSanadDate.Text = "تاريخ"
        Me.lblSanadDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTarakoneshSN
        '
        Me.lblTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarakoneshSN.AutoSize = True
        Me.lblTarakoneshSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarakoneshSN.Location = New System.Drawing.Point(1323, 8)
        Me.lblTarakoneshSN.Name = "lblTarakoneshSN"
        Me.lblTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarakoneshSN.Size = New System.Drawing.Size(41, 13)
        Me.lblTarakoneshSN.TabIndex = 0
        Me.lblTarakoneshSN.Text = "تراكنش"
        Me.lblTarakoneshSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMoaserDate
        '
        Me.lblMoaserDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoaserDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMoaserDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMoaserDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoaserDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMoaserDate.Location = New System.Drawing.Point(1293, 51)
        Me.lblMoaserDate.Name = "lblMoaserDate"
        Me.lblMoaserDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMoaserDate.Size = New System.Drawing.Size(29, 13)
        Me.lblMoaserDate.TabIndex = 10
        Me.lblMoaserDate.Text = "تاريخ موثر"
        Me.lblMoaserDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMoaserDate.Visible = False
        '
        'dcbMarjaSanadSN
        '
        Me.dcbMarjaSanadSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbMarjaSanadSN.AutoSelectFirst = False
        Me.dcbMarjaSanadSN.BackColor = System.Drawing.Color.White
        Me.dcbMarjaSanadSN.BoundText = Nothing
        Me.dcbMarjaSanadSN.BypassChangeEvent = False
        Me.dcbMarjaSanadSN.DisplayText = ""
        Me.dcbMarjaSanadSN.LateBindingTop = "500"
        Me.dcbMarjaSanadSN.Location = New System.Drawing.Point(989, 151)
        Me.dcbMarjaSanadSN.MemFilter = ""
        Me.dcbMarjaSanadSN.Name = "dcbMarjaSanadSN"
        Me.dcbMarjaSanadSN.SeparatedData = Nothing
        Me.dcbMarjaSanadSN.Size = New System.Drawing.Size(333, 21)
        Me.dcbMarjaSanadSN.Source = Nothing
        Me.dcbMarjaSanadSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbMarjaSanadSN.TabIndex = 16
        '
        'txtSanadDate
        '
        Me.txtSanadDate.AcceptsReturn = True
        Me.txtSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSanadDate.Location = New System.Drawing.Point(1233, 66)
        Me.txtSanadDate.MaxLength = 0
        Me.txtSanadDate.Name = "txtSanadDate"
        Me.txtSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSanadDate.Size = New System.Drawing.Size(89, 21)
        Me.txtSanadDate.TabIndex = 11
        Me.txtSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSabtDate
        '
        Me.txtSabtDate.AcceptsReturn = True
        Me.txtSabtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSabtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSabtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSabtDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSabtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSabtDate.Location = New System.Drawing.Point(1233, 66)
        Me.txtSabtDate.MaxLength = 0
        Me.txtSabtDate.Name = "txtSabtDate"
        Me.txtSabtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSabtDate.Size = New System.Drawing.Size(89, 21)
        Me.txtSabtDate.TabIndex = 80
        Me.txtSabtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSabtDate.Visible = False
        '
        'txtMoaserDate
        '
        Me.txtMoaserDate.AcceptsReturn = True
        Me.txtMoaserDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoaserDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMoaserDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMoaserDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMoaserDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMoaserDate.Location = New System.Drawing.Point(1233, 66)
        Me.txtMoaserDate.MaxLength = 0
        Me.txtMoaserDate.Name = "txtMoaserDate"
        Me.txtMoaserDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMoaserDate.Size = New System.Drawing.Size(89, 21)
        Me.txtMoaserDate.TabIndex = 79
        Me.txtMoaserDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMoaserDate.Visible = False
        '
        'sstChild
        '
        Me.sstChild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstChild.Controls.Add(Me._sstChild_TabPage1)
        Me.sstChild.Controls.Add(Me.tabBarnameh)
        Me.sstChild.Controls.Add(Me.TabDarkhast)
        Me.sstChild.Controls.Add(Me.TabChideman)
        Me.sstChild.Controls.Add(Me.TabDaftar)
        Me.sstChild.Controls.Add(Me.TabProductCatalogue)
        Me.sstChild.Controls.Add(Me.TabSanadHaFactor)
        Me.sstChild.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstChild.ItemSize = New System.Drawing.Size(42, 20)
        Me.sstChild.Location = New System.Drawing.Point(4, 296)
        Me.sstChild.Mirrored = True
        Me.sstChild.Name = "sstChild"
        Me.sstChild.SelectedIndex = 0
        Me.sstChild.Size = New System.Drawing.Size(1379, 355)
        Me.sstChild.TabIndex = 5
        Me.sstChild.TabStop = False
        '
        '_sstChild_TabPage1
        '
        Me._sstChild_TabPage1.Controls.Add(Me.GrpPrintLabel)
        Me._sstChild_TabPage1.Controls.Add(Me.pnlG1)
        Me._sstChild_TabPage1.Controls.Add(Me.btnDarkhstView)
        Me._sstChild_TabPage1.Controls.Add(Me.pnlC1)
        Me._sstChild_TabPage1.Controls.Add(Me.btnDelSelected)
        Me._sstChild_TabPage1.Controls.Add(Me.btnExcel)
        Me._sstChild_TabPage1.Controls.Add(Me.btnRahgiri)
        Me._sstChild_TabPage1.Controls.Add(Me.pnlN1)
        Me._sstChild_TabPage1.Location = New System.Drawing.Point(4, 24)
        Me._sstChild_TabPage1.Name = "_sstChild_TabPage1"
        Me._sstChild_TabPage1.Size = New System.Drawing.Size(1371, 327)
        Me._sstChild_TabPage1.TabIndex = 1
        Me._sstChild_TabPage1.Text = "مشاهده"
        '
        'GrpPrintLabel
        '
        Me.GrpPrintLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPrintLabel.Controls.Add(Me.BtnPrintLabel)
        Me.GrpPrintLabel.Controls.Add(Me.PrintLabelUD)
        Me.GrpPrintLabel.Controls.Add(Me.lblPrintLabel)
        Me.GrpPrintLabel.Location = New System.Drawing.Point(528, 284)
        Me.GrpPrintLabel.Name = "GrpPrintLabel"
        Me.GrpPrintLabel.Size = New System.Drawing.Size(226, 37)
        Me.GrpPrintLabel.TabIndex = 16
        Me.GrpPrintLabel.TabStop = False
        '
        'BtnPrintLabel
        '
        Me.BtnPrintLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintLabel.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrintLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnPrintLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPrintLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPrintLabel.Location = New System.Drawing.Point(6, 7)
        Me.BtnPrintLabel.Name = "BtnPrintLabel"
        Me.BtnPrintLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintLabel.Size = New System.Drawing.Size(99, 26)
        Me.BtnPrintLabel.TabIndex = 15
        Me.BtnPrintLabel.Text = "چاپ لیبل"
        Me.BtnPrintLabel.UseVisualStyleBackColor = False
        '
        'PrintLabelUD
        '
        Me.PrintLabelUD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintLabelUD.DecimalPlaces = 1
        Me.PrintLabelUD.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.PrintLabelUD.Location = New System.Drawing.Point(111, 10)
        Me.PrintLabelUD.Name = "PrintLabelUD"
        Me.PrintLabelUD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrintLabelUD.Size = New System.Drawing.Size(51, 20)
        Me.PrintLabelUD.TabIndex = 7
        Me.PrintLabelUD.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'lblPrintLabel
        '
        Me.lblPrintLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrintLabel.AutoSize = True
        Me.lblPrintLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblPrintLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrintLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrintLabel.Location = New System.Drawing.Point(163, 13)
        Me.lblPrintLabel.Name = "lblPrintLabel"
        Me.lblPrintLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPrintLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblPrintLabel.TabIndex = 3
        Me.lblPrintLabel.Text = "سایز چاپ :"
        Me.lblPrintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlG1
        '
        Me.pnlG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG1.Location = New System.Drawing.Point(4, 3)
        Me.pnlG1.Name = "pnlG1"
        Me.pnlG1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG1.Size = New System.Drawing.Size(1358, 274)
        Me.pnlG1.TabIndex = 0
        '
        'btnDarkhstView
        '
        Me.btnDarkhstView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarkhstView.Location = New System.Drawing.Point(760, 284)
        Me.btnDarkhstView.Name = "btnDarkhstView"
        Me.btnDarkhstView.Size = New System.Drawing.Size(64, 35)
        Me.btnDarkhstView.TabIndex = 6
        Me.btnDarkhstView.Text = "مشاهده درخواستها"
        Me.btnDarkhstView.UseVisualStyleBackColor = True
        '
        'pnlC1
        '
        Me.pnlC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlC1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC1.Location = New System.Drawing.Point(988, 283)
        Me.pnlC1.Name = "pnlC1"
        Me.pnlC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC1.Size = New System.Drawing.Size(374, 37)
        Me.pnlC1.TabIndex = 1
        '
        'btnDelSelected
        '
        Me.btnDelSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelSelected.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelSelected.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelSelected.Enabled = False
        Me.btnDelSelected.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelSelected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDelSelected.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelSelected.Location = New System.Drawing.Point(935, 285)
        Me.btnDelSelected.Name = "btnDelSelected"
        Me.btnDelSelected.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelSelected.Size = New System.Drawing.Size(51, 35)
        Me.btnDelSelected.TabIndex = 2
        Me.btnDelSelected.Text = "حذف انتخابي"
        Me.btnDelSelected.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point(883, 285)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size(51, 35)
        Me.btnExcel.TabIndex = 3
        Me.btnExcel.Text = "EXCEL"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnRahgiri
        '
        Me.btnRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRahgiri.Location = New System.Drawing.Point(824, 285)
        Me.btnRahgiri.Name = "btnRahgiri"
        Me.btnRahgiri.Size = New System.Drawing.Size(59, 35)
        Me.btnRahgiri.TabIndex = 5
        Me.btnRahgiri.Text = "وضعیت رهگیری"
        Me.btnRahgiri.UseVisualStyleBackColor = True
        '
        'tabBarnameh
        '
        Me.tabBarnameh.BackColor = System.Drawing.SystemColors.Control
        Me.tabBarnameh.Controls.Add(Me.btnPrintBargeKhorooj)
        Me.tabBarnameh.Controls.Add(Me.pnlcBarnameh)
        Me.tabBarnameh.Controls.Add(Me.btnListBarnameh)
        Me.tabBarnameh.Controls.Add(Me.pnlgBarnameh)
        Me.tabBarnameh.Controls.Add(Me.btnErsalBeDP)
        Me.tabBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabBarnameh.Location = New System.Drawing.Point(4, 24)
        Me.tabBarnameh.Name = "tabBarnameh"
        Me.tabBarnameh.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBarnameh.Size = New System.Drawing.Size(1457, 327)
        Me.tabBarnameh.TabIndex = 2
        Me.tabBarnameh.Text = "بـارنـامـه"
        '
        'btnPrintBargeKhorooj
        '
        Me.btnPrintBargeKhorooj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBargeKhorooj.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrintBargeKhorooj.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrintBargeKhorooj.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrintBargeKhorooj.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPrintBargeKhorooj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintBargeKhorooj.Location = New System.Drawing.Point(780, 288)
        Me.btnPrintBargeKhorooj.Name = "btnPrintBargeKhorooj"
        Me.btnPrintBargeKhorooj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPrintBargeKhorooj.Size = New System.Drawing.Size(90, 34)
        Me.btnPrintBargeKhorooj.TabIndex = 13
        Me.btnPrintBargeKhorooj.Text = "بـرگ خـروج"
        Me.btnPrintBargeKhorooj.UseVisualStyleBackColor = False
        '
        'pnlcBarnameh
        '
        Me.pnlcBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcBarnameh.Location = New System.Drawing.Point(1041, 288)
        Me.pnlcBarnameh.Name = "pnlcBarnameh"
        Me.pnlcBarnameh.Size = New System.Drawing.Size(410, 35)
        Me.pnlcBarnameh.TabIndex = 7
        '
        'btnListBarnameh
        '
        Me.btnListBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListBarnameh.BackColor = System.Drawing.SystemColors.Control
        Me.btnListBarnameh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnListBarnameh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnListBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnListBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnListBarnameh.Location = New System.Drawing.Point(947, 288)
        Me.btnListBarnameh.Name = "btnListBarnameh"
        Me.btnListBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnListBarnameh.Size = New System.Drawing.Size(90, 34)
        Me.btnListBarnameh.TabIndex = 11
        Me.btnListBarnameh.Text = "انتخاب از لیست"
        Me.btnListBarnameh.UseVisualStyleBackColor = False
        '
        'pnlgBarnameh
        '
        Me.pnlgBarnameh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlgBarnameh.Location = New System.Drawing.Point(5, 6)
        Me.pnlgBarnameh.Name = "pnlgBarnameh"
        Me.pnlgBarnameh.Size = New System.Drawing.Size(1446, 279)
        Me.pnlgBarnameh.TabIndex = 1
        '
        'btnErsalBeDP
        '
        Me.btnErsalBeDP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnErsalBeDP.BackColor = System.Drawing.SystemColors.Control
        Me.btnErsalBeDP.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnErsalBeDP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnErsalBeDP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnErsalBeDP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnErsalBeDP.Location = New System.Drawing.Point(870, 288)
        Me.btnErsalBeDP.Name = "btnErsalBeDP"
        Me.btnErsalBeDP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnErsalBeDP.Size = New System.Drawing.Size(77, 34)
        Me.btnErsalBeDP.TabIndex = 12
        Me.btnErsalBeDP.Text = "ارسال جهت پرداخت"
        Me.btnErsalBeDP.UseVisualStyleBackColor = False
        '
        'TabDarkhast
        '
        Me.TabDarkhast.Controls.Add(Me.pnlN2)
        Me.TabDarkhast.Controls.Add(Me.pnlG2)
        Me.TabDarkhast.Controls.Add(Me.pnlC2)
        Me.TabDarkhast.Location = New System.Drawing.Point(4, 24)
        Me.TabDarkhast.Name = "TabDarkhast"
        Me.TabDarkhast.Size = New System.Drawing.Size(1457, 327)
        Me.TabDarkhast.TabIndex = 3
        Me.TabDarkhast.Text = "درخواست"
        Me.TabDarkhast.UseVisualStyleBackColor = True
        '
        'pnlN2
        '
        Me.pnlN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlN2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN2.Location = New System.Drawing.Point(4, 285)
        Me.pnlN2.Name = "pnlN2"
        Me.pnlN2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN2.Size = New System.Drawing.Size(294, 37)
        Me.pnlN2.TabIndex = 15
        '
        'pnlG2
        '
        Me.pnlG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG2.Location = New System.Drawing.Point(4, 6)
        Me.pnlG2.Name = "pnlG2"
        Me.pnlG2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG2.Size = New System.Drawing.Size(1448, 273)
        Me.pnlG2.TabIndex = 14
        '
        'pnlC2
        '
        Me.pnlC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC2.Location = New System.Drawing.Point(1068, 285)
        Me.pnlC2.Name = "pnlC2"
        Me.pnlC2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC2.Size = New System.Drawing.Size(384, 37)
        Me.pnlC2.TabIndex = 13
        '
        'TabChideman
        '
        Me.TabChideman.Controls.Add(Me.pnlN3)
        Me.TabChideman.Controls.Add(Me.pnlG3)
        Me.TabChideman.Controls.Add(Me.pnlC3)
        Me.TabChideman.Location = New System.Drawing.Point(4, 24)
        Me.TabChideman.Name = "TabChideman"
        Me.TabChideman.Size = New System.Drawing.Size(1457, 327)
        Me.TabChideman.TabIndex = 4
        Me.TabChideman.Text = "چیدمان"
        Me.TabChideman.UseVisualStyleBackColor = True
        '
        'pnlN3
        '
        Me.pnlN3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlN3.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN3.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN3.Location = New System.Drawing.Point(4, 284)
        Me.pnlN3.Name = "pnlN3"
        Me.pnlN3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN3.Size = New System.Drawing.Size(294, 37)
        Me.pnlN3.TabIndex = 18
        '
        'pnlG3
        '
        Me.pnlG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG3.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG3.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG3.Location = New System.Drawing.Point(4, 5)
        Me.pnlG3.Name = "pnlG3"
        Me.pnlG3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG3.Size = New System.Drawing.Size(1448, 274)
        Me.pnlG3.TabIndex = 17
        '
        'pnlC3
        '
        Me.pnlC3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC3.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC3.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC3.Location = New System.Drawing.Point(1068, 284)
        Me.pnlC3.Name = "pnlC3"
        Me.pnlC3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC3.Size = New System.Drawing.Size(384, 37)
        Me.pnlC3.TabIndex = 16
        '
        'TabDaftar
        '
        Me.TabDaftar.Controls.Add(Me.PnlNDaftar)
        Me.TabDaftar.Controls.Add(Me.PnlGdaftar)
        Me.TabDaftar.Controls.Add(Me.PnlCDaftar)
        Me.TabDaftar.Location = New System.Drawing.Point(4, 24)
        Me.TabDaftar.Name = "TabDaftar"
        Me.TabDaftar.Size = New System.Drawing.Size(1457, 327)
        Me.TabDaftar.TabIndex = 5
        Me.TabDaftar.Text = "دفتر فروش"
        Me.TabDaftar.UseVisualStyleBackColor = True
        '
        'PnlNDaftar
        '
        Me.PnlNDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlNDaftar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlNDaftar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlNDaftar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlNDaftar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlNDaftar.Location = New System.Drawing.Point(4, 284)
        Me.PnlNDaftar.Name = "PnlNDaftar"
        Me.PnlNDaftar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlNDaftar.Size = New System.Drawing.Size(294, 37)
        Me.PnlNDaftar.TabIndex = 21
        '
        'PnlGdaftar
        '
        Me.PnlGdaftar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlGdaftar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGdaftar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlGdaftar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlGdaftar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGdaftar.Location = New System.Drawing.Point(4, 5)
        Me.PnlGdaftar.Name = "PnlGdaftar"
        Me.PnlGdaftar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlGdaftar.Size = New System.Drawing.Size(1448, 274)
        Me.PnlGdaftar.TabIndex = 20
        '
        'PnlCDaftar
        '
        Me.PnlCDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCDaftar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlCDaftar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlCDaftar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlCDaftar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlCDaftar.Location = New System.Drawing.Point(1068, 284)
        Me.PnlCDaftar.Name = "PnlCDaftar"
        Me.PnlCDaftar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlCDaftar.Size = New System.Drawing.Size(384, 37)
        Me.PnlCDaftar.TabIndex = 19
        '
        'TabProductCatalogue
        '
        Me.TabProductCatalogue.Controls.Add(Me.PnlGProductCatalogue)
        Me.TabProductCatalogue.Location = New System.Drawing.Point(4, 24)
        Me.TabProductCatalogue.Name = "TabProductCatalogue"
        Me.TabProductCatalogue.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductCatalogue.Size = New System.Drawing.Size(1457, 327)
        Me.TabProductCatalogue.TabIndex = 6
        Me.TabProductCatalogue.Text = "ثبت های بارکدخوان"
        Me.TabProductCatalogue.UseVisualStyleBackColor = True
        '
        'PnlGProductCatalogue
        '
        Me.PnlGProductCatalogue.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGProductCatalogue.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlGProductCatalogue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGProductCatalogue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlGProductCatalogue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGProductCatalogue.Location = New System.Drawing.Point(3, 3)
        Me.PnlGProductCatalogue.Name = "PnlGProductCatalogue"
        Me.PnlGProductCatalogue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlGProductCatalogue.Size = New System.Drawing.Size(1451, 321)
        Me.PnlGProductCatalogue.TabIndex = 21
        '
        'TabSanadHaFactor
        '
        Me.TabSanadHaFactor.Controls.Add(Me.PnlGSanadHaFactor)
        Me.TabSanadHaFactor.Location = New System.Drawing.Point(4, 24)
        Me.TabSanadHaFactor.Name = "TabSanadHaFactor"
        Me.TabSanadHaFactor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSanadHaFactor.Size = New System.Drawing.Size(1457, 327)
        Me.TabSanadHaFactor.TabIndex = 7
        Me.TabSanadHaFactor.Text = "ردیف فاکتور"
        Me.TabSanadHaFactor.UseVisualStyleBackColor = True
        '
        'PnlGSanadHaFactor
        '
        Me.PnlGSanadHaFactor.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGSanadHaFactor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlGSanadHaFactor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGSanadHaFactor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlGSanadHaFactor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGSanadHaFactor.Location = New System.Drawing.Point(3, 3)
        Me.PnlGSanadHaFactor.Name = "PnlGSanadHaFactor"
        Me.PnlGSanadHaFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlGSanadHaFactor.Size = New System.Drawing.Size(1451, 321)
        Me.PnlGSanadHaFactor.TabIndex = 22
        '
        'tmrF8
        '
        Me.tmrF8.Interval = 1
        '
        'pnlNoeMarjooei
        '
        Me.pnlNoeMarjooei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNoeMarjooei.Controls.Add(Me.lblNoeMarjooei)
        Me.pnlNoeMarjooei.Controls.Add(Me.btnUpdateMarjooei)
        Me.pnlNoeMarjooei.Controls.Add(Me.dbcNoeMarjooeiSNB)
        Me.pnlNoeMarjooei.Enabled = False
        Me.pnlNoeMarjooei.Location = New System.Drawing.Point(652, 293)
        Me.pnlNoeMarjooei.Name = "pnlNoeMarjooei"
        Me.pnlNoeMarjooei.Size = New System.Drawing.Size(366, 24)
        Me.pnlNoeMarjooei.TabIndex = 4
        Me.pnlNoeMarjooei.Visible = False
        '
        'lblNoeMarjooei
        '
        Me.lblNoeMarjooei.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoeMarjooei.AutoSize = True
        Me.lblNoeMarjooei.BackColor = System.Drawing.Color.Transparent
        Me.lblNoeMarjooei.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoeMarjooei.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoeMarjooei.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoeMarjooei.Location = New System.Drawing.Point(295, 3)
        Me.lblNoeMarjooei.Name = "lblNoeMarjooei"
        Me.lblNoeMarjooei.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNoeMarjooei.Size = New System.Drawing.Size(66, 13)
        Me.lblNoeMarjooei.TabIndex = 0
        Me.lblNoeMarjooei.Text = "نوع مرجوعي"
        Me.lblNoeMarjooei.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnUpdateMarjooei
        '
        Me.btnUpdateMarjooei.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateMarjooei.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateMarjooei.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdateMarjooei.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateMarjooei.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnUpdateMarjooei.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateMarjooei.Location = New System.Drawing.Point(3, 1)
        Me.btnUpdateMarjooei.Name = "btnUpdateMarjooei"
        Me.btnUpdateMarjooei.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdateMarjooei.Size = New System.Drawing.Size(45, 20)
        Me.btnUpdateMarjooei.TabIndex = 2
        Me.btnUpdateMarjooei.Text = "تاييد"
        Me.btnUpdateMarjooei.UseVisualStyleBackColor = False
        '
        'dbcNoeMarjooeiSNB
        '
        Me.dbcNoeMarjooeiSNB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcNoeMarjooeiSNB.AutoSelectFirst = False
        Me.dbcNoeMarjooeiSNB.BackColor = System.Drawing.Color.White
        Me.dbcNoeMarjooeiSNB.BoundText = Nothing
        Me.dbcNoeMarjooeiSNB.BypassChangeEvent = False
        Me.dbcNoeMarjooeiSNB.DisplayText = ""
        Me.dbcNoeMarjooeiSNB.LateBindingTop = "100"
        Me.dbcNoeMarjooeiSNB.Location = New System.Drawing.Point(51, 1)
        Me.dbcNoeMarjooeiSNB.MemFilter = ""
        Me.dbcNoeMarjooeiSNB.Name = "dbcNoeMarjooeiSNB"
        Me.dbcNoeMarjooeiSNB.SeparatedData = Nothing
        Me.dbcNoeMarjooeiSNB.Size = New System.Drawing.Size(242, 21)
        Me.dbcNoeMarjooeiSNB.Source = Nothing
        Me.dbcNoeMarjooeiSNB.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcNoeMarjooeiSNB.TabIndex = 1
        '
        'tmrF9
        '
        Me.tmrF9.Interval = 1
        '
        'btnEslahRahgiri
        '
        Me.btnEslahRahgiri.BackColor = System.Drawing.Color.Transparent
        Me.btnEslahRahgiri.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEslahRahgiri.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEslahRahgiri.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnEslahRahgiri.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEslahRahgiri.Location = New System.Drawing.Point(136, 291)
        Me.btnEslahRahgiri.Name = "btnEslahRahgiri"
        Me.btnEslahRahgiri.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnEslahRahgiri.Size = New System.Drawing.Size(123, 21)
        Me.btnEslahRahgiri.TabIndex = 11
        Me.btnEslahRahgiri.Text = "اصلاح شماره رهگيري"
        Me.btnEslahRahgiri.UseVisualStyleBackColor = False
        '
        'tmrF10
        '
        Me.tmrF10.Interval = 1
        '
        'tmrF11
        '
        Me.tmrF11.Interval = 1
        '
        'btnDarjAghlamFactor
        '
        Me.btnDarjAghlamFactor.BackColor = System.Drawing.Color.Transparent
        Me.btnDarjAghlamFactor.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAghlamFactor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAghlamFactor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjAghlamFactor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAghlamFactor.Location = New System.Drawing.Point(8, 291)
        Me.btnDarjAghlamFactor.Name = "btnDarjAghlamFactor"
        Me.btnDarjAghlamFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAghlamFactor.Size = New System.Drawing.Size(123, 21)
        Me.btnDarjAghlamFactor.TabIndex = 12
        Me.btnDarjAghlamFactor.Text = "درج اقلام فاکتور"
        Me.btnDarjAghlamFactor.UseVisualStyleBackColor = False
        Me.btnDarjAghlamFactor.Visible = False
        '
        'btnEslahSanad
        '
        Me.btnEslahSanad.BackColor = System.Drawing.Color.Transparent
        Me.btnEslahSanad.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEslahSanad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEslahSanad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnEslahSanad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEslahSanad.Location = New System.Drawing.Point(6, 4)
        Me.btnEslahSanad.Name = "btnEslahSanad"
        Me.btnEslahSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnEslahSanad.Size = New System.Drawing.Size(63, 21)
        Me.btnEslahSanad.TabIndex = 13
        Me.btnEslahSanad.Text = "اصلاح سند"
        Me.btnEslahSanad.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSabtUID)
        Me.Panel1.Controls.Add(Me.BtnUpdateBatchNoeEngheza)
        Me.Panel1.Controls.Add(Me.BtnEnteghalMojoodi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnEslahSanad)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Controls.Add(Me.btnEslahRahgiri)
        Me.Panel1.Controls.Add(Me.pnlNoeMarjooei)
        Me.Panel1.Controls.Add(Me.sstParent)
        Me.Panel1.Controls.Add(Me.btnDarjAghlamFactor)
        Me.Panel1.Controls.Add(Me.sstChild)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1386, 654)
        Me.Panel1.TabIndex = 14
        '
        'BtnSabtUID
        '
        Me.BtnSabtUID.BackColor = System.Drawing.Color.Transparent
        Me.BtnSabtUID.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSabtUID.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSabtUID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabtUID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSabtUID.Location = New System.Drawing.Point(523, 291)
        Me.BtnSabtUID.Name = "BtnSabtUID"
        Me.BtnSabtUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSabtUID.Size = New System.Drawing.Size(123, 21)
        Me.BtnSabtUID.TabIndex = 16
        Me.BtnSabtUID.TabStop = False
        Me.BtnSabtUID.Text = " ثبت UID"
        Me.BtnSabtUID.UseVisualStyleBackColor = False
        '
        'BtnUpdateBatchNoeEngheza
        '
        Me.BtnUpdateBatchNoeEngheza.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateBatchNoeEngheza.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnUpdateBatchNoeEngheza.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnUpdateBatchNoeEngheza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnUpdateBatchNoeEngheza.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUpdateBatchNoeEngheza.Location = New System.Drawing.Point(394, 291)
        Me.BtnUpdateBatchNoeEngheza.Name = "BtnUpdateBatchNoeEngheza"
        Me.BtnUpdateBatchNoeEngheza.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdateBatchNoeEngheza.Size = New System.Drawing.Size(123, 21)
        Me.BtnUpdateBatchNoeEngheza.TabIndex = 15
        Me.BtnUpdateBatchNoeEngheza.TabStop = False
        Me.BtnUpdateBatchNoeEngheza.Text = "اصلاح بچ و نوع انقضاء"
        Me.BtnUpdateBatchNoeEngheza.UseVisualStyleBackColor = False
        Me.BtnUpdateBatchNoeEngheza.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnSabtSanaddarSamaneh)
        Me.Panel2.Controls.Add(Me.BtnPrintHavalehTolid)
        Me.Panel2.Controls.Add(Me.btnStatus4_8)
        Me.Panel2.Controls.Add(Me.pnlC)
        Me.Panel2.Controls.Add(Me.pnlN)
        Me.Panel2.Controls.Add(Me.btnStatus1_4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(6, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(1375, 43)
        Me.Panel2.TabIndex = 14
        '
        'btnSabtSanaddarSamaneh
        '
        Me.btnSabtSanaddarSamaneh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSabtSanaddarSamaneh.BackColor = System.Drawing.Color.Transparent
        Me.btnSabtSanaddarSamaneh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSabtSanaddarSamaneh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSabtSanaddarSamaneh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSabtSanaddarSamaneh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSabtSanaddarSamaneh.Location = New System.Drawing.Point(613, 5)
        Me.btnSabtSanaddarSamaneh.Name = "btnSabtSanaddarSamaneh"
        Me.btnSabtSanaddarSamaneh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSabtSanaddarSamaneh.Size = New System.Drawing.Size(130, 32)
        Me.btnSabtSanaddarSamaneh.TabIndex = 17
        Me.btnSabtSanaddarSamaneh.Text = "ثبت سند در سامانه"
        Me.btnSabtSanaddarSamaneh.UseVisualStyleBackColor = False
        Me.btnSabtSanaddarSamaneh.Visible = False
        '
        'BtnPrintHavalehTolid
        '
        Me.BtnPrintHavalehTolid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintHavalehTolid.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrintHavalehTolid.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPrintHavalehTolid.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnPrintHavalehTolid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPrintHavalehTolid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPrintHavalehTolid.Location = New System.Drawing.Point(749, 5)
        Me.BtnPrintHavalehTolid.Name = "BtnPrintHavalehTolid"
        Me.BtnPrintHavalehTolid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintHavalehTolid.Size = New System.Drawing.Size(130, 32)
        Me.BtnPrintHavalehTolid.TabIndex = 15
        Me.BtnPrintHavalehTolid.Text = "چاپ حواله درخواست تولید"
        Me.BtnPrintHavalehTolid.UseVisualStyleBackColor = False
        '
        'FrmSanad
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1386, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "FrmSanad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "سند"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.sstParent.ResumeLayout(False)
        Me._sstParent_TabPage1.ResumeLayout(False)
        Me._sstParent_TabPage0.ResumeLayout(False)
        Me.pnlD.ResumeLayout(False)
        Me.pnlD.PerformLayout()
        Me.sstChild.ResumeLayout(False)
        Me._sstChild_TabPage1.ResumeLayout(False)
        Me.GrpPrintLabel.ResumeLayout(False)
        Me.GrpPrintLabel.PerformLayout()
        CType(Me.PrintLabelUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBarnameh.ResumeLayout(False)
        Me.TabDarkhast.ResumeLayout(False)
        Me.TabChideman.ResumeLayout(False)
        Me.TabDaftar.ResumeLayout(False)
        Me.TabProductCatalogue.ResumeLayout(False)
        Me.TabSanadHaFactor.ResumeLayout(False)
        Me.pnlNoeMarjooei.ResumeLayout(False)
        Me.pnlNoeMarjooei.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance() As FrmSanad
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance(ByVal aNoeTarakoneshSN As EnumNoeTarakoneshSN) As FrmSanad
        Get
            Dim tmp As FrmSanad = Nothing
            If m_vb6FormDefInstance Is Nothing Then
                ReDim Preserve m_vb6FormDefInstance(0)
                m_InitializingDefInstance = True
                m_vb6FormDefInstance(0) = New FrmSanad
                m_InitializingDefInstance = False
                tmp = m_vb6FormDefInstance(0)

            Else
                For i As Integer = 0 To m_vb6FormDefInstance.Length - 1
                    If m_vb6FormDefInstance(i).NoeTarakoneshSN = aNoeTarakoneshSN Then
                        If m_vb6FormDefInstance(i).IsDisposed Then
                            m_vb6FormDefInstance(i) = New FrmSanad
                        End If
                        tmp = m_vb6FormDefInstance(i)
                        Exit For
                    End If
                Next
                If tmp Is Nothing Then
                    ReDim Preserve m_vb6FormDefInstance(m_vb6FormDefInstance.Length)
                    m_InitializingDefInstance = True
                    m_vb6FormDefInstance(m_vb6FormDefInstance.Length - 1) = New FrmSanad
                    m_InitializingDefInstance = False
                    tmp = m_vb6FormDefInstance(m_vb6FormDefInstance.Length - 1)
                End If

            End If
            DefInstance = tmp
        End Get
        Set(ByVal Value As FrmSanad)
            m_vb6FormDefInstance(m_vb6FormDefInstance.Length - 1) = Value
        End Set
    End Property
#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  سند انبار تعريف شده است
    Private WithEvents DVabSanad As CDataView
    Private WithEvents DV As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش اقلام سند انبار تعريف شده است
    Private WithEvents DVabSanadHa As CDataView

    Private WithEvents DVabBarnameh As CDataView

    Private WithEvents DVabSanadHaDarkhast As CDataView

    Private WithEvents DVabSanadHaChideman As CDataView   '-----add by yekta 940319

    Private WithEvents DVabSanadHaDaftar As CDataView
    Private WithEvents DVabSanadHaProductCatalogue As CDataView
    Private WithEvents DVabSanadHaFactor As CDataView


    Private WithEvents txtSanadMaliDate As NetSql.Components.TextBox

    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    '  Private WithEvents pFLX_abSanad As AxVSFlexGrid '850622

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد

    Private WithEvents dcbKalaDS As NetSql.Components.DataCombo
    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dcbKalaPhizikiSN As NetSql.Components.DataCombo
    'يك تکس باکس تعريف مي شود كه بتوان با مطابقت با تکس باکس ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dcbShomarehRahgiriText As NetSql.Components.TextBox


    '--------------- add by yekta 940319 ----------
    Private WithEvents dcbChidemanText As NetSql.Components.TextBox
    '--------------- add by yekta 940319 ----------

    Private WithEvents dcbMojavezErsalHa As NetSql.Components.DataCombo
    Private WithEvents dcbDarkhastHa As NetSql.Components.DataCombo
    Private WithEvents dcbSanadhaDarkhast As NetSql.Components.DataCombo

    ' جهت مشخص شدن نوع ورود اطلاعات در سطح فرم براي انبارجاري     واحدسنجش    تعداد درکارتن
    Private VNoeVoroodeAsnad As EnumNoeVoroodeAsnad

    ' شرط پيش فرض کالا را در عمليات نگهداري ميکند
    Private pdbcKalaDSComboWhereCondition As String
    Private pdbcTarakoneshSNComboWhereCondition As String
    Private pdbcTarakoneshSNInsertComboWhereCondition As String

    Public Shared KalaPhizikiStatusSN As Short  '  چگونگي رهگيري کالا در انبار
    Public Shared RahgiriAuto As Short ' آيا شماره رهگيري اتوماتيک ثبت گردد
    Public Shared RahgiriMeghdar As Integer '  در صورت اتوماتيک بودن مقدار آن چيست

    '//اين متغيرها جهت فرم اصلاح اطلاعات سند استفاده شده است
    Public vVisibleShomarehBarnameh As Boolean
    Public vVisibleShomarehMashin As Boolean
    Public vVisibleNameRanandeh As Boolean
    Public vVisibleVazneBaskool As Boolean
    Public vVisibleShomarehSefaresh As Boolean
    Public dvTarakonesh, dvTarakoneshGorooh, dvTarakoneshGorooh88, dvTarakoneshGorooh93, dvKalaUseUID As New DataView

    Private gPrintHavaleh As Integer = 0
    Private gTaminkonandehOzvegoroohForHamleMostaghim As String ' By Yekta 910431 - Add ---------- change by yekta 920603
    Private gAshkhaseHaghighiOzvegoroohForKharidDakheli As Decimal ' By Yekta 910729 - Add
    Private gNoeAnbarForNamayesheBatchNoAndTozih As String ' By Yekta 920814 - Add   -- change yekta 920826
    Private gIsNamayesheBatchNoAndTozih As Boolean = False 'By yekta 920826

    Private gNoeBarnamehIsVisible As Boolean = False
    Public gIsF8InTabDarkhast As Boolean = False 'Add By Yekta 920228
    Private OldBarnamehSN As Decimal = 0  'Add By Yekta 920722
    Public KeepTarakoneshForCombo, SelectedTarakonesh As Object
    Public QuickActionOnAbSanadHa As Boolean = False
    Public DoMovaghatSanadGhatee As Boolean = False
    Public IsCompanyUseQcApp As Boolean = False
    Public IsVahedeTejariSabtUIDonSanad As Boolean = False
    Public IsVahedeTejariUseFodarkhastonSanad As Boolean = False

    Public VahedeTejariMohlatMarjooeiForoosh As Integer = 0
    Public VahedeTejariMohlatMarjooeiTozie As Integer = 0

    Dim MohlatMarjooeiDate As String = ""
    Public IsTolidi As Boolean = True
    Public IsStandard As Boolean = True  ''ghasemi
    Public ShowDaftarForoosh As Boolean = False
    Public ShowTabChideman As Boolean = False
    Public ShowTabSanadHaDarkhast As Boolean = False
    Public ShowTabProductCatalogue As Boolean = False
    Public ShowTabSanadHaFactor As Boolean = False


    Public CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)



#Region "EnumUISanad"
    ' براي کنترل نمايش فيلدهاي سند در تراکنش هاي مختلف
    Private Enum EnumAddField_abSanad
        afAddsMarjaSanadSN = &H1S
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
        afAddTafsiliSN1 = &H2000S ' تعداد ظرف
        'log

        'log
    End Enum
#End Region

#Region "Property"
    Private mTarakoneshSN As EnumTarakoneshSN
    Friend Property TarakoneshSN() As EnumTarakoneshSN
        Get
            TarakoneshSN = mTarakoneshSN
        End Get
        Set(ByVal Value As EnumTarakoneshSN)
            mTarakoneshSN = Value
            Call EnableFields()
        End Set
    End Property

    Private mNoeAccessRight As String
    Friend Property NoeAccessRight() As String
        Get
            NoeAccessRight = mNoeAccessRight
        End Get
        Set(ByVal Value As String)
            mNoeAccessRight = Value
        End Set
    End Property

    Private mNoeTarakoneshSN As EnumNoeTarakoneshSN
    Friend Property NoeTarakoneshSN() As EnumNoeTarakoneshSN
        Get
            NoeTarakoneshSN = mNoeTarakoneshSN
        End Get
        Set(ByVal Value As EnumNoeTarakoneshSN)
            mNoeTarakoneshSN = Value
        End Set
    End Property

    Private mSanadSN As Decimal
    Friend Property SanadSN() As Decimal
        Get
            SanadSN = mSanadSN
        End Get
        Set(ByVal Value As Decimal)
            mSanadSN = Value
        End Set
    End Property

    Private mDvGorohTafsiliAccess As DataView
    Friend Property DvGorohTafsiliAccess() As DataView
        Get
            DvGorohTafsiliAccess = mDvGorohTafsiliAccess
        End Get
        Set(ByVal Value As DataView)
            mDvGorohTafsiliAccess = Value
            '''''Call EnableFields()
        End Set
    End Property

    Private QCPairAnbarSN As Decimal
    Private GVahedeTejariUsesKartablZayeat As Boolean
#End Region

#Region "Button"

    Private Sub btnFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnFilter.Click
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات سند بروز رساني ميگردد
        Dim vMinDate As String
        Dim vMaxDate As String
        Dim vFilterDate As String
        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
             cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting(VB6.GetEXEName(), "Setting", "MinDateabSanad" & NoeTarakoneshSN, MinFilterDateCtrl.Value)
        End If
        MakeFilter(vMinDate, vMaxDate)
        ''ghasemi
        DVabSanad.Refresh()
    End Sub

    Private Sub btnStatus1_4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnStatus1_4.Click
        ' تبديل رکورد از حالت پيشنويس به موقت
        Dim Vli_NewVaziat As Short
        Dim vErrMsg As String
        Dim vSanadSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_SanadSN(,) As Decimal
        Dim VCount_SanadSN As Short
        Dim vEnabled_Status1_4 As Boolean

        ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
        ' البته با توجه به نوع فرم فراخواني شده
        Select Case NoeTarakoneshSN
            Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                vEnabled_Status1_4 = (gSM.TableAccessRight("AvalDoreh_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDHA
                vEnabled_Status1_4 = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                vEnabled_Status1_4 = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHHA
                vEnabled_Status1_4 = (gSM.TableAccessRight("Havaleh_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                vEnabled_Status1_4 = (gSM.TableAccessRight("EzafiMojoodiAnbar_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                vEnabled_Status1_4 = (gSM.TableAccessRight("KasriMojoodiAnbar_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                vEnabled_Status1_4 = (gSM.TableAccessRight("ResideBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)

                '910309
            Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehKahandehKharid_1_4") = EnumAccessRight.arAll)

            Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)

            Case Else
                vEnabled_Status1_4 = False
        End Select

        'old     If Not ((gSM.TableAccessRight("Status1_4") And EnumAccessRight.arAll) <> 0) _
        If Not (vEnabled_Status1_4) _
         Or (DVabSanad.State = EnumDataViewState.bsEdit) _
         Or (DVabSanad.State = EnumDataViewState.bsAdd) Then
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا سند/اسناد موقت گردد ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabSanad.FlexGrid
                VCount_SanadSN = .SelectedRows
                ReDim V_ar_SanadSN(VCount_SanadSN, 2)
                For i = 0 To VCount_SanadSN - 1
                    If .TextMatrix(.SelectedRow(i), .ColIndex("SanadStatus")) = "1" Then
                        V_ar_SanadSN(i, 1) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadSN")))
                        V_ar_SanadSN(i, 2) = .TextMatrix(.SelectedRow(i), .ColIndex("SanadStatus"))
                    End If
                Next
            End With
            ' براي تمامي اسناد انتخاب شده   فراخواني اس پي تغيير وضعيت سند
            For i = 0 To VCount_SanadSN - 1
                vSN = Val(V_ar_SanadSN(i, 1))
                Vli_NewVaziat = 4
                If vSN <> 0 Then

                    '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي
                    Try
                        If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()

                        cn.BeginTrans(cn.Connection.BeginTransaction)
                        cn.CallSP("_abSPC_Change_SanadStatus", vSN, Vli_NewVaziat, gSM.UserID, gSM.UserID_Name, vErrMsg, System.DBNull.Value)
                        cn.CommitTrans()
                    Catch ex As Exception
                        cn.RollbackTrans()
                        NetSql.Common.CSystem.MsgBox(ex.Message)
                    End Try
                    '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي

                End If
                If vErrMsg <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + IIf(Vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                End If
            Next
            For i = 0 To VCount_SanadSN - 1
                vSN = Val(V_ar_SanadSN(i, 1))
                If vSN <> 0 Then
                    DVabSanad.CurrentKey = CStr(vSN)
                    DVabSanad.FetchCurRecord()
                End If
            Next
        End If

        'Dim key As Decimal = DVabSanad.CurrentKey
        'DVabSanad.Refresh()
        'DVabSanad.CurrentKey = key

        'DVabSanad.AutoFetchCurrentRow = True
        'DVabSanad.FetchCurRecord()
        'DVabSanad.AutoFetchCurrentRow = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnStatus4_8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnStatus4_8.Click
        ' تبديل رکورد از حالت موقت به قطعي
        Dim V_li_NewVaziat As Short
        Dim vErrMsg As String
        Dim vSanadSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_SanadSN(,) As Decimal
        Dim VCount_SanadSN As Short
        Dim vEnabled_Status4_8 As Boolean

        ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
        ' البته با توجه به نوع فرم فراخواني شده
        Select Case NoeTarakoneshSN
            Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                vEnabled_Status4_8 = (gSM.TableAccessRight("AvalDoreh_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDHA
                vEnabled_Status4_8 = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                vEnabled_Status4_8 = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHHA
                vEnabled_Status4_8 = (gSM.TableAccessRight("Havaleh_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                vEnabled_Status4_8 = (gSM.TableAccessRight("EzafiMojoodiAnbar_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                vEnabled_Status4_8 = (gSM.TableAccessRight("KasriMojoodiAnbar_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                vEnabled_Status4_8 = (gSM.TableAccessRight("ResideBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)

                '910309
            Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehKahandehKharid_4_8") = EnumAccessRight.arAll)

            Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case Else
                vEnabled_Status4_8 = False
        End Select

        ' old    If Not ((gSM.TableAccessRight("Status4_8") And EnumAccessRight.arAll) <> 0) _
        If Not (vEnabled_Status4_8) _
         Or (DVabSanad.State = EnumDataViewState.bsEdit) _
         Or (DVabSanad.State = EnumDataViewState.bsAdd) Then

            Exit Sub
        End If

        Dim CountSanadKartablZayeat As Integer = 0
        Dim IsSanad91ToTehDaroo As Boolean = False

        With DVabSanad.FlexGrid
            VCount_SanadSN = .SelectedRows
            If VCount_SanadSN = 0 Then
                NetSql.Common.CSystem.MsgBox("سندی برای قطعی شدن انتخاب نشده است.", MsgBoxStyle.MsgBoxRtlReading, "")
                Exit Sub
            End If
            ReDim V_ar_SanadSN(VCount_SanadSN, 2)
            For i = 0 To VCount_SanadSN - 1
                If .TextMatrix(.SelectedRow(i), .ColIndex("RezSN4")) = "1" Or .TextMatrix(.SelectedRow(i), .ColIndex("RezSN4")).ToUpper = "TRUE" Then
                    CountSanadKartablZayeat += 1
                End If
                If .TextMatrix(.SelectedRow(i), .ColIndex("TarakoneshSN")) = "91" Then
                    If IsNumeric(.TextMatrix(.SelectedRow(i), .ColIndex("TafsiliSN"))) Then
                        If CDec(.TextMatrix(.SelectedRow(i), .ColIndex("TafsiliSN"))) = 391729.101 Then ''جهت پیغام برای حواله تحویل های ارسالی به شعبه تهران دارویی
                            IsSanad91ToTehDaroo = True
                        End If
                    End If
                End If
                If .TextMatrix(.SelectedRow(i), .ColIndex("SanadStatus")) = "4" _
                             Or .TextMatrix(.SelectedRow(i), .ColIndex("SanadStatus")) = "1" Then
                    V_ar_SanadSN(i, 1) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadSN")))
                    V_ar_SanadSN(i, 2) = .TextMatrix(.SelectedRow(i), .ColIndex("SanadStatus"))
                End If
            Next
        End With

        If IsSanad91ToTehDaroo Then
            If CSystem.MsgBox("در صورتی که حواله مورد نظر جهت دفتر فروش مشخصی از شعبه تهران دارویی ارسال میگردد لطفا در توضیحات سند نام دفتر فروش مورد نظر ذکر شود" + vbNewLine + "آیا مایل به ادامه عملیات قطعی سازی سند هستید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ذخیره سند") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        If NetSql.Common.CSystem.MsgBox("آيا سند/اسناد قطعي گردد ؟" + vbNewLine +
                                        If(CountSanadKartablZayeat > 0, vbNewLine + vbNewLine + " < " + CountSanadKartablZayeat.ToString + " >" + "سند جهت انتقال به کارتابل ضایعات انتخاب شده است", ""),
                                        MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.No Then
            Exit Sub
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' براي تمامي اسناد انتخاب شده   فراخواني اس پي تغيير وضعيت سند
        For i = 0 To VCount_SanadSN - 1
            vSN = Val(V_ar_SanadSN(i, 1))
            V_li_NewVaziat = 8

            If vSN <> 0 Then

                '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي
                Try
                    If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()

                    cn.BeginTrans(cn.Connection.BeginTransaction)
                    cn.CallSP("_abSPC_Change_SanadStatus", vSN, V_li_NewVaziat, gSM.UserID, gSM.UserID_Name, vErrMsg, System.DBNull.Value)
                    If Len(vErrMsg) = 0 Then
                        If V_li_NewVaziat = 8 Then CSanad.ErsaleHavaleBeShoab(vSN)
                        If V_li_NewVaziat = 8 Then CSanad.UpdatedarkhastTadarokat(vSN) 'بروزرساني مقدار درخواست در سيستم تدارکات
                        If V_li_NewVaziat = 8 Then CSanad.ErsaleHavaleBeSherkateGorooh(vSN)
                    End If
                    cn.CommitTrans()

                Catch ex As Exception
                    vErrMsg = ex.Message
                    cn.RollbackTrans()
                    'CSystem.MsgBox("عملیات قطعی سازی انجام نشد " + vbCrLf + ex.Message)
                End Try

                '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي

            End If
            If vErrMsg <> "" Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + IIf(V_li_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            End If
        Next
        For i = 0 To VCount_SanadSN - 1
            vSN = Val(V_ar_SanadSN(i, 1))
            If vSN <> 0 Then
                DVabSanad.CurrentKey = CStr(vSN)
                DVabSanad.FetchCurRecord()
            End If
        Next

        If vErrMsg = "" AndAlso GVahedeTejariUsesKartablZayeat AndAlso IsNumeric(DVabSanad.FieldValue("RezSN4")) Then
            If CDec(DVabSanad.FieldValue("RezSN4")) >= 1 Then
                Dim Frm As New FrmabZayeatKartabl

                With Frm
                    .ShowDialog()
                    .Dispose()
                End With
            End If

        End If



        'Dim key As Decimal = DVabSanad.CurrentKey
        'DVabSanad.Refresh()
        'DVabSanad.CurrentKey = key


        'DVabSanad.AutoFetchCurrentRow = True
        'DVabSanad.FetchCurRecord()
        'DVabSanad.AutoFetchCurrentRow = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default




    End Sub

    Private Sub btnUpdateMarjooei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnUpdateMarjooei.Click
        ' امکاني براي بروزآوري گروهي اقلام سند در حالتي که بخواهند نوع مرجوعي را بصورت گروهي بروزآوري کنند
        Dim vSanadHaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_SanadHaSN(,) As Decimal
        Dim VCount_SanadHaSN As Short
        Dim VNoeMarjooeiSN As Decimal

        If (Not DVabSanadHa.CommandEnabled(EnumCommands.cmEdit)) _
          Or (DVabSanadHa.State = EnumDataViewState.bsEdit) Or (DVabSanadHa.State = EnumDataViewState.bsAdd) Then
            Exit Sub
        End If
        If NetSql.Common.CSystem.MsgBox(" آيا نوع مرجوعي اقلام سند انتخاب شده اصلاح گردد ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            VNoeMarjooeiSN = dbcNoeMarjooeiSNB.BoundText
            With DVabSanadHa.FlexGrid
                VCount_SanadHaSN = .SelectedRows
                ReDim V_ar_SanadHaSN(VCount_SanadHaSN, 1)
                For i = 0 To VCount_SanadHaSN - 1
                    V_ar_SanadHaSN(i, 1) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadHaSN")))
                Next
            End With
            For i = 0 To VCount_SanadHaSN - 1
                vSN = Val(V_ar_SanadHaSN(i, 1))
                If vSN <> 0 And VNoeMarjooeiSN <> 0 Then
                    cn.ExecuteNoneQuery(" UPDATE abSanadHa SET NoeMarjooeiSN  = " + CStr(VNoeMarjooeiSN) &
                          " Where  SanadHaSN = " + CStr(vSN))
                End If
            Next
            For i = 0 To VCount_SanadHaSN - 1
                vSN = Val(V_ar_SanadHaSN(i, 1))
                If vSN <> 0 Then
                    DVabSanadHa.CurrentKey = CStr(vSN)
                    DVabSanadHa.FetchCurRecord()
                End If
            Next
        End If

        'Dim key As Decimal = DVabSanad.CurrentKey
        'DVabSanad.Refresh()
        'DVabSanad.CurrentKey = key

        'DVabSanadHa.AutoFetchCurrentRow = True
        'DVabSanadHa.FetchCurRecord()
        'DVabSanadHa.AutoFetchCurrentRow = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnExcel.Click
        ' براي انتقال اطلاعات گريد اقلام سند در اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DVabSanadHa.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub btnDelSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDelSelected.Click
        ' امکاني براي حذف گروهي اقلام سند
        Dim vSanadHaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_abSanadHaSN() As Decimal
        Dim VCount_SanadHaSN As Short
        With DVabSanadHa
            If (Not .CommandEnabled(EnumCommands.cmEdit)) Or (.State = EnumDataViewState.bsEdit) _
               Or (.State = EnumDataViewState.bsAdd) Then
                Exit Sub
            End If

            ''Add by Dehghani
            Dim Dv As DataView = cn.ExecuteQuery("Select SanadStatus From abSanad Where SanadSn = " & DVabSanad.FieldValue("SanadSn") & "")

            If CByte(Dv(0)(0)) = 8 Then
                NetSql.Common.CSystem.MsgBox("وضعیت سند قطعی می باشد لذا رکورد قابل حذف نیست.", MsgBoxStyle.MsgBoxRtlReading, "")
                DVabSanad.Refresh()
                Exit Sub
            End If
            ''''''''''''''''
            If ChkIsFakorEbtal.Checked Then
                NetSql.Common.CSystem.MsgBox("سند فاکتور ابطالی را نمي توان تغيير داد" + vbNewLine + "در صورت تمایل به ویرایش یا حذف اقلام سند فاکتور ابطالی ، سند می بایست به صورت کلی حذف گردد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If

            If NetSql.Common.CSystem.MsgBox(" آيا رکوردهاي انتخاب شده حذف گردد ؟ ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                With DVabSanad
                    If Val(.Fields("NoeSanadID").Value) <> 0 AndAlso Val(.Fields("NoeSanadID").Value) = 2 AndAlso Val(.Fields("BarcodeReaderSanad").Value) = 0 Then
                        NetSql.Common.CSystem.MsgBox("سند انبار از نوع ماشيني را نمي توان تغيير داد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                        Exit Sub
                    End If
                End With
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVabSanadHa.FlexGrid
                    VCount_SanadHaSN = .SelectedRows
                    ReDim V_ar_abSanadHaSN(VCount_SanadHaSN)
                    For i = 0 To VCount_SanadHaSN - 1
                        V_ar_abSanadHaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadHaSN")))
                    Next
                End With
                ' فراخواني اس پي براي تک تک اقلام سند انتخاب شده جهت حذف رکورد
                For i = 0 To VCount_SanadHaSN - 1
                    vSN = Val(V_ar_abSanadHaSN(i))
                    If vSN <> 0 Then
                        cn.CallSP("_abSanadHa_DeleteX", vSN)
                    End If
                Next
                DVabSanadHa.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With
    End Sub

    Private Sub btnEslahie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnEslahie.Click
        Dim vSanadSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_SanadSN() As Decimal
        Dim VCount_SanadSN As Short

        With DVabSanad
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabSanad.FlexGrid
                VCount_SanadSN = .SelectedRows
                ReDim V_ar_SanadSN(VCount_SanadSN)
                For i = 0 To VCount_SanadSN - 1
                    V_ar_SanadSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadSN")))
                Next
            End With
            ' انتخاب تک تک رکوردهاي انتخاب شده 
            For i = 0 To VCount_SanadSN - 1
                vSN = Val(V_ar_SanadSN(i))
                If vSN <> 0 Then
                    vSanadSN = vSanadSN & IIf(vSanadSN Is Nothing, "", ",") & vSN.ToString
                End If
            Next
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With

        Dim VShowEslahie As New Minoo.Applications.Anbar.Common.FrmShowEslahie
        With DVabSanad.FlexGrid
            VShowEslahie.vSanadSn = vSanadSN
            VShowEslahie.ShowDialog(Me)
        End With

    End Sub

    Private Sub btnSpecifications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSpecifications.Click

        Dim vSanadSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_SanadSN() As Decimal
        Dim VCount_SanadSN As Short

        With DVabSanad
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabSanad.FlexGrid
                VCount_SanadSN = .SelectedRows
                ReDim V_ar_SanadSN(VCount_SanadSN)
                For i = 0 To VCount_SanadSN - 1
                    V_ar_SanadSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadSN")))
                Next
            End With
            ' انتخاب تک تک رکوردهاي انتخاب شده 
            For i = 0 To VCount_SanadSN - 1
                vSN = Val(V_ar_SanadSN(i))
                If vSN <> 0 Then
                    vSanadSN = vSanadSN & IIf(vSanadSN Is Nothing, "", ",") & vSN.ToString
                End If
            Next
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With

        Dim VShowSpecifications As New Minoo.Applications.Anbar.Common.FrmShowSpecifications
        With DVabSanad.FlexGrid
            VShowSpecifications.vSanadSn = vSanadSN
            VShowSpecifications.ShowDialog(Me)
        End With

    End Sub

    ''Add By Dehghani 981010
    Private Sub BtnEnteghalMojoodi_Click(sender As Object, e As EventArgs) Handles BtnEnteghalMojoodi.Click

        Dim Frm As New FrmEnteghalMojoodiKalaPhiziki

        With Frm
            .KalaSN = DVabSanadHa.FieldValue("KalaSN")
            .dbcKala.ReadOnly = True
            .KalaPhizikiSN = DVabSanadHa.FieldValue("ShomarehRahgiriText")
            .dbcToRahgiri.ReadOnly = True
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnEslahRahgiri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnEslahRahgiri.Click
        Dim VEslahRahgiri As New FrmEslahRahgiri

        'VEslahRahgiri.VIsRahgiriAuto = Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 1 Or
        '  (Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 2 AndAlso Val(DVabSanadHa.FieldValue("Auto")) = 1)
        'If Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 1 Or _
        '                             (Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 2 AndAlso Val(DVabSanadHa.FieldValue("Auto")) = 1) Then
        '    Netsql.common.csystem.MsgBox("کد رهگيري اتوماتيک ساخته مي شود و قابل تغيير نمي باشد.", MsgBoxStyle.Critical, "اصلاح کد رهگيري")
        '    Exit Sub
        'End If

        With DVabSanadHa.FlexGrid
            VEslahRahgiri.vSanadHaSN = CStr(DVabSanadHa.Fields("SanadHaSN").Text)
            VEslahRahgiri.vKala = Val(DVabSanadHa.Fields("KalaDS").Text)
            VEslahRahgiri.VBox_In = Val(DVabSanadHa.Fields("Box_in").Text)
            VEslahRahgiri.VCan_In = Val(DVabSanadHa.Fields("can_in").Text)
            VEslahRahgiri.VTedadAjza = Val(DVabSanadHa.Fields("TedadAjza").Text)
            VEslahRahgiri.VNoeVoroodeAsnad = VNoeVoroodeAsnad
            VEslahRahgiri.vShomarehRahgiri = CStr(DVabSanadHa.Fields("ShomarehRahgiriText").Text)
            VEslahRahgiri.vEnghezaDate = CStr(DVabSanadHa.Fields("EnghezaDate").Text)
            VEslahRahgiri.VEnghezaDateFlag = CStr(DVabSanadHa.Fields("EnghezaDateFlag").Value)
            VEslahRahgiri.VToolidDateFlag = CStr(DVabSanadHa.Fields("ToolidDateFlag").Value)
            VEslahRahgiri.VTarakoneshsn = Val(DVabSanad.Fields("TarakoneshSN").Value)
            VEslahRahgiri.vToolidDate = CStr(DVabSanadHa.Fields("ToolidDate").Text)
            VEslahRahgiri.ShowDialog(Me)
            DVabSanadHa.Refresh()
        End With

    End Sub

    Private Sub btnEslahSanad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnEslahSanad.Click
        Dim VEslahSanadInfo As New FrmEslahSanadInfo

        Dim DvEslahSefaresh As DataView = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(86) Where TaraKoneshSN=" & CStr(DVabSanad.Fields("TaraKoneshSN").Value))

        With VEslahSanadInfo
            .vSanadSN = CStr(DVabSanad.Fields("SanadSN").Text)

            .vNameRanandeh = txtNameRanandeh.Text
            .vShomarehBarnameh = txtShomarehBarnameh.Text
            .vShomarehMashin = txtShomarehMashin.Text
            .vVazneBaskool = txtVazneBaskool.Text
            .vShomarehSefaresh = txtShomarehSefaresh.Text
            .vTozih = txtTozih.Text

            .vVisibleShomarehBarnameh = vVisibleShomarehBarnameh
            .vVisibleShomarehMashin = vVisibleShomarehMashin
            .vVisibleNameRanandeh = vVisibleNameRanandeh
            .vVisibleVazneBaskool = vVisibleVazneBaskool
            .vVisibleShomrehSefaresh = If(DvEslahSefaresh.Count > 0, False, vVisibleShomarehSefaresh)
            .BarcodeReaderSanad = DVabSanad.Fields("BarcodeReaderSanad").Value = 1
            .ShowDialog(Me)

            DVabSanad.FetchCurRecord()

            'Dim key As Decimal = DVabSanad.CurrentKey
            'DVabSanad.Refresh()
            'DVabSanad.CurrentKey = key

            'DVabSanad.AutoFetchCurrentRow = True
            'DVabSanad.FetchCurRecord()
            'DVabSanad.AutoFetchCurrentRow = False

        End With

    End Sub

    Private Sub btnDarjAghlamFactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDarjAghlamFactor.Click
        Dim VSelectAghlameFactor As New FrmSelectAghlameFactor

        With DVabSanadHa.FlexGrid
            VSelectAghlameFactor.FactorSN = Val(DVabSanad.FieldValue("TafsiliSN2"))
            VSelectAghlameFactor.HavalehForooshSN = If(IsNumeric(DVabSanad.FieldValue("HavalehForooshSN")), DVabSanad.FieldValue("HavalehForooshSN"), 0)
            'Dim dvDaroo As DataView = cn.ExecuteQuery("Select  Top 1 NoeVahedeTejariSN from foFactorHa join paVw_paKalaTaminFull pk on pk.KalaSN=foFactorHa.KalaSN " &
            '                                        "where FactorSN=" & DVabSanad.FieldValue("TafsiliSN2").ToString & " and NoeVahedeTejariSN in (14.935 , 16.935)")

            'VSelectAghlameFactor.IsSanadDaroo = If(dvDaroo.Count > 0, True, False)

            Dim dv As DataView = cn.ExecuteQuery("Select * from absanad where sanadsn = " & DVabSanad.Fields("SanadSn").Value)
            If dv.Count > 0 Then
                VSelectAghlameFactor.SanadRow = dv.Table.Rows(0)
                VSelectAghlameFactor.ShowDialog(Me)
                DVabSanadHa.Refresh()
                DVabSanad.FetchCurRecord()
            End If

        End With
    End Sub

    Private Sub btnRahgiri_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnRahgiri.Click
        Dim vFrmSelectRahgiri As New FrmSelectRahgiri
        With vFrmSelectRahgiri
            .KalaSN = DVabSanadHa.Fields("KalaSN").Value
            .MoaserDate = DVabSanad.Fields("MoaserDate").Value

            Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
            If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                If mTarakoneshSN < 50 Then
                    DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)
                Else
                    DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_out").Value)
                End If
                VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
            End If
            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

            If VMeghdareSadereh <> 0 Then
                .Meghdar = VMeghdareSadereh
            ElseIf VMeghdareVaredeh <> 0 Then
                .Meghdar = VMeghdareVaredeh
            Else
                .Meghdar = 0
            End If

            .NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
            .NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
            .NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
            '.DarkhastHaSN = Val(DVabSanadHa.Fields("DarkhastHaSN").Value)

            '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
            '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)

            .SanadRow = cn.ExecuteQuery("Select *,abanbar.anbarsn ToAnbarSN from absanad left join abanbar on absanad.tafsilisn=abanbar.payesn where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)

            .btnDarjAsan.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btnErsalBeDP_Click(sender As System.Object, e As System.EventArgs) Handles btnErsalBeDP.Click
        ' برای یک سری از تراکنش ها فقط وضعیت ارسال تغییر می کند و برای یک سری دیگر پس از ارسال به مقصد آنگاه وضعیت ارسال تغییر می کند
        If CheckTarakoneshErsaleBarnamehBeMaghsad(Val(DVabSanad.Fields("TarakoneshSN").Value)) Then
            '' send barnameh info   change yekta 920722
            If Val(DVabBarnameh.Fields("BarnamehSN").Value) > 0 Then
                If OldBarnamehSN <> Val(DVabBarnameh.Fields("BarnamehSN").Value) Then
                    OldBarnamehSN = Val(DVabBarnameh.Fields("BarnamehSN").Value)
                    CSanad.ErsaleBarnamehBeDP(Val(DVabBarnameh.Fields("BarnamehSN").Value))
                End If
                btnErsalBeDP.Enabled = False
            End If
        Else
            '' just update ErsalBeDP = 1
            If Val(DVabBarnameh.Fields("BarnamehSN").Value) > 0 Then
                cn.ExecuteQuery("UPDATE abBarnameh SET ErsalBeDP = 1 where BarnamehSN = " & Val(DVabBarnameh.Fields("BarnamehSN").Value) & " and ErsalBeDP = 0")
                DVabBarnameh.FetchCurRecord()
            End If
        End If
    End Sub

    Private Sub btnDarkhstView_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnDarkhstView.Click

        Dim vFrmShowDarkhast As New FrmShowDarkhast
        With vFrmShowDarkhast
            .SanadhaSN = DVabSanadHa.Fields("SanadHaSN").Value
            .ShowDialog()
        End With

    End Sub

    Private Sub btnPrintBargeKhorooj_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintBargeKhorooj.Click
        If Not DVabBarnameh Is Nothing AndAlso Val(DVabBarnameh.FieldValue("BarnamehSN")) > 0 Then
            Dim DVabBarnamehHa, DVBoxOut As New DataView
            Dim strBoxOut As String = ""
            DVabBarnamehHa = cn.ExecuteQuery("select replace(replace(replace((select cast(isnull(abVw_abSanad.SanadNO,'') as varchar) as SanadDS from abBarnamehHa inner join abVw_abSanad on abBarnamehHa.SanadSN = abVw_abSanad.SanadSN where BarnamehSN = " & DVabBarnameh.FieldValue("BarnamehSN") & " FOR XML PATH ('')), '</SanadDS><SanadDS>', ' , '), '<SanadDS>' , ''), '</SanadDS>', '') as SanadDS")

            DVBoxOut = cn.ExecuteQuery("select sum(floor(MeghdareSadereh / TedadAjza)) as BoxOut from abVw_abSanadHa where sanadsn in (select sanadsn from abBarnamehHa where BarnamehSN = " & DVabBarnameh.FieldValue("BarnamehSN") & ")")
            If DVBoxOut.Count > 0 Then
                strBoxOut = DVBoxOut(0)("BoxOut")
            End If

            Dim vrptBargeKhorooj As New Anbar.Report.rptBargeKhorooj
            With vrptBargeKhorooj
                .strMobileRanandeh = DVabBarnameh.FieldValue("MobileRanandeh")
                .strMaghsad = DVabBarnameh.FieldValue("Maghsad")
                .strNameRanandeh = DVabBarnameh.FieldValue("NameRanandeh")
                .strShomarehMashin = DVabBarnameh.FieldValue("ShomarehMashin")
                .strBarbariDS = DVabBarnameh.FieldText("BarbariDS")
                .strBarnamehNo = DVabBarnameh.FieldValue("BarnamehNo")
                .strMablagh = Format(Val(DVabBarnameh.FieldValue("GheymateBarnameh")) - Val(DVabBarnameh.FieldValue("Kasri")), "#,#")
                .strBarnamehDS = DVabBarnameh.FieldValue("BarnamehDS")
                .strBoxOut = strBoxOut
                .strShomarehGavahiNameh = DVabBarnameh.FieldValue("ShomarehGavahiNameh")
                .strNoeKhodro = DVabBarnameh.FieldValue("NoeKhodro")

                .DataSource = DVabBarnamehHa

                Minoo.Reports.FTReportViewer.ShowReport(vrptBargeKhorooj, Me.MdiParent)
            End With
        End If
    End Sub

    Private Sub btnListBarnameh_Click(sender As System.Object, e As System.EventArgs) Handles btnListBarnameh.Click
        Dim i As Integer
        With DVabSanad.FlexGrid
            For i = 0 To .SelectedRows - 1

                If Not CheckTarakoneshBarnameh(.ValueMatrix(.SelectedRow(i), .ColIndex("TarakoneshSN"))) Then
                    NetSql.Common.CSystem.MsgBox("ثبت بارنامه برای تراکنش انتخاب شده مجاز نیست", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                    Exit Sub
                End If

                If CheckTarakoneshErsaleBarnamehBeMaghsad(.ValueMatrix(.SelectedRow(i), .ColIndex("TarakoneshSN"))) _
                        And .ValueMatrix(.SelectedRow(i), .ColIndex("SanadStatus")) <> 8 Then
                    NetSql.Common.CSystem.MsgBox("برای این تراکنش، قبل از ثبت بارنامه باید سند قطعی شده باشد")
                    Exit Sub
                End If

            Next

            If .SelectedRows > 0 Then
                Dim FrmBarnameh As New Minoo.Application.DaryaftPardakht.UI.FrmBarnameh
                FrmBarnameh.gAnbarSN = gAnbarSN
                If FrmBarnameh.ShowDialog = DialogResult.OK Then

                    For i = 0 To .SelectedRows - 1

                        If ExistBarnameh(.ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN"))) Then
                            NetSql.Common.CSystem.MsgBox("قبلا بارنامه برای این سند ثبت شده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                            Exit Sub
                        End If
                        Dim StrMsg As String = controlBarnameh(FrmBarnameh.BarnamehSN, CDec(.ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN"))))
                        If StrMsg <> "" Then
                            NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "خطا")
                            StrMsg = ""
                            Exit Sub
                        End If
                        cn.ExecuteQuery("abBarnamehHa_Insert " & gSM.Identifier & "," & FrmBarnameh.BarnamehSN & "," & .ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN")) & ",0,0,'" & gSM.UserID_Name & "','" & System.Environment.MachineName & "',NULL,'" & Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal) & "'")
                        DVabBarnameh.Refresh()
                    Next

                End If
            Else
                NetSql.Common.CSystem.MsgBox("حداقل یک سند را انتخاب نمایید", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
            End If


        End With
    End Sub

    Private Sub BtnPrintLabel_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintLabel.Click

        ''Add By dehghani - 941006
        Dim NotforUseLabel As New Anbar.QC.NotForUseLabel
        Dim _rule As New ClsDataAccessRule

        Dim DvPrint As New DataView
        DvPrint = _rule.GetDatasourceForPrintLabel(DVabSanadHa.FieldValue("SanadHaSN"), cn)

        If DvPrint.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("اطلاعات چاپ یافت نشد.", MsgBoxStyle.Exclamation, "چاپ لیبل")
        End If

        DvPrint(0)("Tozih") = "توضیحات : " + DvPrint(0)("Tozih").ToString
        Dim DtPrint As DataTable = DvPrint.ToTable.Copy()
        DtPrint.ImportRow(DvPrint.ToTable.Rows(0))

        With NotforUseLabel
            .FontName = "Times New Roman"
            .FontSize = Decimal.ToSingle(PrintLabelUD.Value)
            .DefineField()
            .DataSource = DtPrint
            .PageSettings.Margins.Left = 0.4
            .PageSettings.Margins.Top = 0.4
        End With

        Try
            Minoo.Reports.FTReportViewer.ShowReport(NotforUseLabel, Me.MdiParent)

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در نمایش گزارش چاپ لیبل" + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "چاپ لیبل")
        End Try

    End Sub

#End Region

#Region "Combo"

    Private Sub dbcTafsiliSN1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcTafsiliSN1.Enter
        ' با توجه به تراکنش سند و ارتباط تراکنش انبار با گروه هاي تفصيلي اطلاعات کامبو تفصيلي نمايش داده ميشود 
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal
        Dim vGoroohTafsiliSN2 As Decimal
        If (Val(DVabSanad.Fields("TafsiliSN1").Value) = 0) Then
            If (Val(DVabSanad.Fields("TafsiliSN").Value) <> 0) Then
                vGoroohTafsiliSN2 = Val(DVabSanad.Fields("TafsiliSN").Value)
                If Val(DVabSanad.Fields("NoeAnbarSN").Value) = 0 Then
                    vNoeAnbarSN = gNoeAnbarSN
                Else
                    vNoeAnbarSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)
                End If

                If Not (DVabSanad.Fields("TarakoneshSN").IsEmpty) Then
                    vTarakoneshSN = Val(DVabSanad.Fields("TarakoneshSN").Value)
                    DVabSanad.Fields("TafsiliSN1").ComboWhereCondition = " maTafsili2.GoroohTafsiliSN IN " &
                      "(select GoroohTafsiliSN FROM dbo.abFnt_SelectLevel2GoroohTafsili( " &
                      CStr(vTarakoneshSN) & "," & CStr(vNoeAnbarSN) & "," & CStr(vGoroohTafsiliSN2) & " )) "
                Else
                    DVabSanad.Fields("TafsiliSN1").ComboWhereCondition = " 1 = 2 "
                End If
            Else
                DVabSanad.Fields("TafsiliSN1").ComboWhereCondition = " 1 = 2 "
            End If
            DVabSanad.Fields("TafsiliSN1").RefreshCombo()
        End If
    End Sub

    Private Sub dbcTarafHesabSN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcTarafHesabSN.Enter
        '  با توجه به تراکنش انتخاب شده سند حال با توجه به ارتباط تراکنش انبار و گروه هاي تفصيلي مالي تفصيلي هاي مرتبط نمايش داده ميگردد
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal, vTafsiliSN As Decimal
        Dim VComboWhereB As String

        Dim vGetTaraKoneshGoroohTafsiliSN As String

        VComboWhereB = ""
        ' با توجه به تراکنش سند رکورد جاري
        ' Property -> TarakoneshSN
        Select Case TarakoneshSN
            Case EnumTarakoneshSN.RESIDE_12_ENTEGHAL_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.RESIDE_37_DARYAFTE_MAHSOOL_AZ_KARGAH _
                , EnumTarakoneshSN.RESIDE_21_DARYAFTE_MAHSOOL_AZ_KARGAH_ARD _
                , EnumTarakoneshSN.RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP _
                , EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR _
                , EnumTarakoneshSN.RESIDE_17_BARGASHTE_BASTEBANDI_AZ_PAYEKAR _
                , EnumTarakoneshSN.HAVALEH_83_BARGASHTE_MAHSOOL_AZ_PAYEKAR _
                , EnumTarakoneshSN.HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD _
                , EnumTarakoneshSN.RESIDE_42_DARYAFTE_ZAYEAT_AVALIE_AZ_KARGAH _
                , EnumTarakoneshSN.RESIDE_32_DARYAFTE_ZAYEAT_BASTEBANDI_AZ_KARGAH _
                , EnumTarakoneshSN.RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP _
                , EnumTarakoneshSN.RESIDE_10_DARYAFTE_MAVADE_NIMSAKHTE_AS_PAYEKAR

                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                  " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                  " AND (abAnbar.IsTajmie = 3) " &
                  " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
               , EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR

                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                   " AND (abAnbar.IsTajmie <> 1) " &
                   " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                'EnumTarakoneshSN.RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB _
                ' , EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                   " AND (abAnbar.IsTajmie = 2) " &
                 " AND abAnbar.VahedeTejariSN  IN (3.935,4.935,7.935))) "

            Case EnumTarakoneshSN.HAVALEH_81_ZAYEAT
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar T1 INNER JOIN abAnbarTarakonesh T2 ON T1.AnbarSN = T2.AnbarSN " &
                   " Where ( ISNULL(T1.AnbarStatus,0) = 1 ) " &
                   " AND (T1.IsTajmie <> 1) AND T2.NoeAnbarSN in (5,6) " &
                   " AND T1.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.RESIDE_11_HAMLE_MOSTAGHIM
                VComboWhereB = " And (((TafsiliSN not in (  " &
                               " Select TafsiliSN from matafsili where VahedeTejariSN in (select VahedeTejariSN from paVahedeTejari where OzveGorooh=1))  " &
                               " OR " & CStr(gVahedeTejariSN) & " Not in (Select VahedeTejariSN from paVahedeTejari where PedarVahedeTejariSN=9.935 ))) " &
                               " OR (TafsiliSN in (" & gTaminkonandehOzvegoroohForHamleMostaghim & ")))"
                'by yekta 910431 - modify0
                'by yekta 920603 - modify
            Case EnumTarakoneshSN.RESIDE_01_KHARIDE_DAKHELI _
                , EnumTarakoneshSN.RESIDE_02_KHARIDE_KHAREJI

                VComboWhereB = "And (TafsiliSN not in (select TafsiliSN from maTafsili where TafsiliSN in ( select PayeSN from paVahedeTejari where PedarVahedeTejariSN =9.935)))"
                'By Yekta 910920 - new case create 

                '----by yekta 920416------------
            Case EnumTarakoneshSN.HAVALEH_111_KahandehKharid
                'EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI _    comment by yekta '920502'
                ', EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI _  comment by yekta '920502'

                Dim shomarehsefaresh As String
                shomarehsefaresh = DVabSanad.Fields("ShomarehSefaresh").Value
                If (shomarehsefaresh = "") Then
                    shomarehsefaresh = "null"
                End If


                VComboWhereB = "And (TafsiliSN IN (SELECT TafsiliSN FROM absanad WHERE anbarsn=" & gAnbarSN & " and ShomarehSefaresh='" & shomarehsefaresh & "' AND TarakoneshSN in (1,2)))"
                '----by yekta 920416------------
        End Select

        If Val(DVabSanad.Fields("TafsiliSN").Value) = 0 Then
            If Val(DVabSanad.Fields("NoeAnbarSN").Value) = 0 Then
                vNoeAnbarSN = gNoeAnbarSN
            Else
                vNoeAnbarSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)
            End If
            If Trim(DVabSanad.Fields("TarakoneshSN").Value) <> "" Then
                vTarakoneshSN = Val(DVabSanad.Fields("TarakoneshSN").Value)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN = CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVabSanad.Fields("TafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN + VComboWhereB
            Else
                DVabSanad.Fields("TafsiliSN").ComboWhereCondition = " 1 = 2 "
            End If
            DVabSanad.Fields("TafsiliSN").RefreshCombo()
        Else ' If Val(DVabSanad.Fields("TafsiliSN").Value) = 0 Then 
            vTafsiliSN = DVabSanad.Fields("TafsiliSN").Value
            If Val(DVabSanad.Fields("NoeAnbarSN").Value) = 0 Then
                vNoeAnbarSN = gNoeAnbarSN
            Else
                vNoeAnbarSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)
            End If
            If Trim(DVabSanad.Fields("TarakoneshSN").Value) <> "" Then
                vTarakoneshSN = Val(DVabSanad.Fields("TarakoneshSN").Value)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN = CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVabSanad.Fields("TafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN + VComboWhereB
            Else
                DVabSanad.Fields("TafsiliSN").ComboWhereCondition = " 1 = 2 "
            End If
            DVabSanad.Fields("TafsiliSN").RefreshCombo()
            DVabSanad.Fields("TafsiliSN").Value = vTafsiliSN
        End If ' If Val(DVabSanad.Fields("TafsiliSN").Value) = 0 Then


    End Sub

    Private Sub dbcTarakoneshSN_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles dbcTarakoneshSN.SelectionChangeCommitted
        Dim Vli_TarakoneshSN As Short
        dbcNoeAnbarSN.BoundText = 0.0
        lblShomarehSefaresh.Text = "شماره ارجاع"
        If dbcTarakoneshSN.BoundText <> "" Then
            Vli_TarakoneshSN = CShort(dbcTarakoneshSN.BoundText)
            TarakoneshSN = Vli_TarakoneshSN
            If TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Then
                lblShomarehSefaresh.Text += If(MohlatMarjooeiDate.Length = 8, "(فاکتورهای " + MohlatMarjooeiDate + "به بعد)", "")
            End If
            If GVahedeTejariUsesKartablZayeat Then
                dvTarakoneshGorooh88.RowFilter = "TarakoneshSN=" & Vli_TarakoneshSN.ToString
                If dvTarakoneshGorooh88.Count > 0 Then
                    ChkAutoTransferToKartablZayeat.Enabled = If(TarakoneshSN = EnumTarakoneshSN.HAVALEH_81_ZAYEAT, False, True)
                    ChkAutoTransferToKartablZayeat.Checked = If(TarakoneshSN = EnumTarakoneshSN.HAVALEH_81_ZAYEAT, True, False)
                Else
                    ChkAutoTransferToKartablZayeat.Enabled = False
                    ChkAutoTransferToKartablZayeat.Checked = False
                End If
                dvTarakoneshGorooh88.RowFilter = "0=0"


                'ChkIsFakorEbtal.Enabled = If(TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE, True, False)

            End If
        End If

        If gNoeAnbarSN <> 0 Then
            dbcNoeAnbarSN.BoundText = CStr(gNoeAnbarSN * 1.0)
        End If


    End Sub

    Private Sub dbcTarakoneshSN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcTarakoneshSN.Enter
        If gNoeAnbarSN <> 0 Then
            dbcNoeAnbarSN.BoundText = CStr(gNoeAnbarSN * 1.0)
        End If
    End Sub

    Private Sub dbcNoeAnbarSN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcNoeAnbarSN.Enter
        ' با توجه به تراکنشهاي هر انبار نوع انبار اجازه ميدهد که نوع انبار را انتخاب نمايد
        With DVabSanad.Fields("NoeAnbarSN")
            If Val(dbcTarakoneshSN.BoundText) <> 0 Then
                If Len(dbcNoeAnbarSN.Tag) = 0 Then
                    dbcNoeAnbarSN.Tag = .ComboWhereCondition
                End If
                .ComboWhereCondition = "  abNoeAnbar.NoeAnbarSN IN (SELECT abAnbarTarakonesh.NoeAnbarSN " &
                   " FROM abAnbarTarakonesh " &
                  " WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) &
                   " AND TarakoneshSN = " & CStr(DVabSanad.Fields("TarakoneshSN").Value) &
                   " ) "
                ' " AND abAnbarTarakonesh.AnbarTarakoneshStatus = 1   " & _ 850122
            Else
                If Len(dbcNoeAnbarSN.Tag) = 0 Then
                    dbcNoeAnbarSN.Tag = .ComboWhereCondition
                End If
                .ComboWhereCondition = " 1 > 1   "
            End If
            .RefreshCombo()
        End With

        If dbcNoeAnbarSN.DataBindings.Count > 1 Then
            System.Windows.Forms.SendKeys.Send("{RIGHT}")
        End If
    End Sub

    'Private Sub dbcTarafHesabSN_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles dbcTarafHesabSN.SelectedValueChanged
    '    Dim vTafsiliSN As Decimal

    '    If (TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) And Val(DVabSanad.Fields("TafsiliSN").Value) <> 0 Then
    '        vTafsiliSN = Val(DVabSanad.Fields("TafsiliSN").Value)

    '        Try
    '            DVabSanad.Fields("TafsiliSN2").ComboWhereCondition = " foFactor.FactorSN in (" & _
    '                "select foFactor.FactorSN " & _
    '                "from foFactor " & _
    '                "join foMoshtariInfo ON foMoshtariInfo.MoshtariInfoSN = foFactor.MoshtariInfoSN " & _
    '                "join foMoshtari ON foMoshtariInfo.MoshtariSN = foMoshtari.MoshtariSN " & _
    '                "join maTafsili ON maTafsili.TafsiliSN = foMoshtari.TafsiliSN " & _
    '                "where foFactor.Res2 in (1.101,2.101) and foMoshtari.TafsiliSN = " & vTafsiliSN & ")"
    '            DVabSanad.Fields("TafsiliSN2").RefreshCombo()
    '        Catch ex As Exception
    '            MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
    '        End Try

    '    End If
    'End Sub

    Private Sub dbcTarafHesabSN_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbcTarafHesabSN.VisibleChanged
        With dbcTarafHesabSN
            If Not DVabSanad Is Nothing AndAlso .Enabled = True AndAlso
               DVabSanad.Fields("TarafHesabSN").Value.ToString = "" Then
                .SelectedIndex = -1
            End If
        End With
    End Sub

    Private Sub dbcTafsiliSN1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbcTafsiliSN1.VisibleChanged
        With dbcTafsiliSN1
            If Not DVabSanad Is Nothing AndAlso .Enabled = True AndAlso
               DVabSanad.Fields("TafsiliSN1").Value.ToString = "" Then
                .SelectedIndex = -1
            End If
        End With

    End Sub

    Private Sub dcbShomarehRahgiriText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dcbShomarehRahgiriText.KeyUp
        ' در مورد کنترل کليد اف 8 و انجام عمليات مربوطه
        ' نمايش کالاهاي فيزيکي يک کالا در انبار مربوطه
        '850722
        'If (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA _
        '            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar _
        '            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI) _
        '                                        And e.KeyCode = System.Windows.Forms.Keys.F8 Then



        ''//by Ghafari 900225
        'If e.KeyCode = System.Windows.Forms.Keys.Enter Then
        '    If Not DVabSanadHa Is Nothing Then
        '        If DVabSanadHa.Fields("KalaSN").Value <> "" Then
        '            tmrEnter.Enabled = True
        '        End If
        '    End If
        'End If
        ''//by Ghafari 900225

        If e.KeyCode = System.Windows.Forms.Keys.F8 Then
            If Not DVabSanadHa Is Nothing Then
                If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                    If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso
                        (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or
                         NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar Or
                         TarakoneshSN = EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR Or
                         TarakoneshSN = EnumTarakoneshSN.HAVALEH_116_EzafehErsal Or
                         TarakoneshSN = EnumTarakoneshSN.HAVALEH_117_KasriDryaft
                         ) Then   'محدود کردن عملکرد اف 8 به فرم حواله-860320-ايزدپناه
                        '  بعلت خطايي که در محيط وجود داشت مجبور به استفاده از تايمر شدم 
                        '                                     VB.Net
                        tmrF8.Enabled = True
                    End If
                End If
            End If
        End If

        '//ByIzadpanah -860319 -F9
        If e.KeyCode = System.Windows.Forms.Keys.F9 Then
            If Not DVabSanadHa Is Nothing Then
                If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                    If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso
                        (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or
                         NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar Or
                         TarakoneshSN = EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR Or
                         TarakoneshSN = EnumTarakoneshSN.HAVALEH_116_EzafehErsal Or
                         TarakoneshSN = EnumTarakoneshSN.HAVALEH_117_KasriDryaft
                         ) Then 'محدود کردن عملکرد اف 9 به فرم حواله-860320-ايزدپناه
                        '  بعلت خطايي که در محيط وجود داشت مجبور به استفاده از تايمر شدم 
                        '                                     VB.Net
                        tmrF9.Enabled = True
                    End If
                End If
            End If
        End If
        '//ByIzadpanah -860319 -F9

        '//ByIzadpanah -860606 -F10
        If e.KeyCode = System.Windows.Forms.Keys.F10 Then
            If Not DVabSanadHa Is Nothing Then
                If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                    If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar) Then  'محدود کردن عملکرد اف 10 به فرم حواله-860606-ايزدپناه
                        tmrF10.Enabled = True
                    End If
                End If
            End If
        End If
        '//ByIzadpanah -860606 -F10

        '//ByIzadpanah -860606 -F11
        If e.KeyCode = System.Windows.Forms.Keys.F11 Then
            If Not DVabSanadHa Is Nothing Then
                If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                    If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar) Then  'محدود کردن عملکرد اف 11 به فرم حواله-860606-ايزدپناه
                        tmrF10.Enabled = True
                    End If
                End If
            End If
        End If
        '//ByIzadpanah -860606 -F11

        ' 840609 ‌براي دور زدن ابزار در مورد فيلدي که کليد است ولي ميخواهيم درون آن مقدار بگذاريم

        If e.KeyCode = System.Windows.Forms.Keys.Enter And Trim(dcbShomarehRahgiriText.Text) <> "" Then
            If Not DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("EnghezaDate_Text")) Then
                ' DVabSanadHa.Fields("ShomarehRahgiriText").Value = dcbShomarehRahgiriText.Text
                dcbShomarehRahgiriText.Visible = False
                System.Windows.Forms.SendKeys.Send("{LEFT}")
                System.Windows.Forms.SendKeys.Send("{ENTER}")
            Else
                dcbShomarehRahgiriText.Visible = False
                System.Windows.Forms.SendKeys.Send("{LEFT}")
                DVabSanadHa.Save()
                System.Windows.Forms.SendKeys.Send("{HOME}")
                System.Windows.Forms.SendKeys.Send("{PGDN}")

            End If
        Else
            'dcbShomarehRahgiriText.Visible = False
            'System.Windows.Forms.SendKeys.Send("{LEFT}")
            'DVabSanadHa.Save()
            'System.Windows.Forms.SendKeys.Send("{HOME}")
            'System.Windows.Forms.SendKeys.Send("{PGDN}")
        End If

        ' 840609 ‌براي دور زدن ابزار در مورد فيلدي که کليد است ولي ميخواهيم درون آن مقدار بگذاريم

    End Sub

    '---------------add by yekta 940319-------------------------------
    Private Sub dcbChidemanText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dcbChidemanText.KeyUp
        ' در مورد کنترل کليد اف 8 و انجام عمليات مربوطه
        ' نمايش کالاهاي فيزيکي يک کالا در انبار مربوطه
        '850722
        'If (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA _
        '            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar _
        '            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI) _
        '                                        And e.KeyCode = System.Windows.Forms.Keys.F8 Then



        ''//by Ghafari 900225
        'If e.KeyCode = System.Windows.Forms.Keys.Enter Then
        '    If Not DVabSanadHa Is Nothing Then
        '        If DVabSanadHa.Fields("KalaSN").Value <> "" Then
        '            tmrEnter.Enabled = True
        '        End If
        '    End If
        'End If
        ''//by Ghafari 900225

        If e.KeyCode = System.Windows.Forms.Keys.F8 Then
            If Not DVabSanadHaChideman Is Nothing Then
                If DVabSanadHaChideman.State = EnumDataViewState.bsAdd Or DVabSanadHaChideman.State = EnumDataViewState.bsEdit Then
                    tmrF8.Enabled = True
                End If
            End If
        End If

        '//ByIzadpanah -860319 -F9
        ''''''If e.KeyCode = System.Windows.Forms.Keys.F9 Then
        ''''''    If Not DVabSanadHa Is Nothing Then
        ''''''        If DVabSanadHa.State = EnumDataViewState.bsAdd Then
        ''''''            If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso _
        ''''''                (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or _
        ''''''                 NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar Or _
        ''''''                 TarakoneshSN = EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR Or _
        ''''''                 TarakoneshSN = EnumTarakoneshSN.HAVALEH_116_EzafehErsal Or _
        ''''''                 TarakoneshSN = EnumTarakoneshSN.HAVALEH_117_KasriDryaft _
        ''''''                 ) Then 'محدود کردن عملکرد اف 9 به فرم حواله-860320-ايزدپناه
        ''''''                '  بعلت خطايي که در محيط وجود داشت مجبور به استفاده از تايمر شدم 
        ''''''                '                                     VB.Net
        ''''''                tmrF9.Enabled = True
        ''''''            End If
        ''''''        End If
        ''''''    End If
        ''''''End If
        '//ByIzadpanah -860319 -F9

        '//ByIzadpanah -860606 -F10
        ''''''If e.KeyCode = System.Windows.Forms.Keys.F10 Then
        ''''''    If Not DVabSanadHa Is Nothing Then
        ''''''        If DVabSanadHa.State = EnumDataViewState.bsAdd Then
        ''''''            If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar) Then  'محدود کردن عملکرد اف 10 به فرم حواله-860606-ايزدپناه
        ''''''                tmrF10.Enabled = True
        ''''''            End If
        ''''''        End If
        ''''''    End If
        ''''''End If
        '//ByIzadpanah -860606 -F10

        '//ByIzadpanah -860606 -F11
        '''''''If e.KeyCode = System.Windows.Forms.Keys.F11 Then
        '''''''    If Not DVabSanadHa Is Nothing Then
        '''''''        If DVabSanadHa.State = EnumDataViewState.bsAdd Then
        '''''''            If DVabSanadHa.Fields("KalaSN").Value <> "" AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar) Then  'محدود کردن عملکرد اف 11 به فرم حواله-860606-ايزدپناه
        '''''''                tmrF10.Enabled = True
        '''''''            End If
        '''''''        End If
        '''''''    End If
        '''''''End If
        '//ByIzadpanah -860606 -F11

        ' 840609 ‌براي دور زدن ابزار در مورد فيلدي که کليد است ولي ميخواهيم درون آن مقدار بگذاريم

        If e.KeyCode = System.Windows.Forms.Keys.Enter And Trim(dcbChidemanText.Text) <> "" Then
            If Not DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("EnghezaDate_Text")) Then
                ' DVabSanadHa.Fields("ShomarehRahgiriText").Value = dcbShomarehRahgiriText.Text
                dcbShomarehRahgiriText.Visible = False
                System.Windows.Forms.SendKeys.Send("{LEFT}")
                System.Windows.Forms.SendKeys.Send("{ENTER}")
            Else
                dcbShomarehRahgiriText.Visible = False
                System.Windows.Forms.SendKeys.Send("{LEFT}")
                DVabSanadHa.Save()
                System.Windows.Forms.SendKeys.Send("{HOME}")
                System.Windows.Forms.SendKeys.Send("{PGDN}")

            End If
        Else
            'dcbShomarehRahgiriText.Visible = False
            'System.Windows.Forms.SendKeys.Send("{LEFT}")
            'DVabSanadHa.Save()
            'System.Windows.Forms.SendKeys.Send("{HOME}")
            'System.Windows.Forms.SendKeys.Send("{PGDN}")
        End If

        ' 840609 ‌براي دور زدن ابزار در مورد فيلدي که کليد است ولي ميخواهيم درون آن مقدار بگذاريم

    End Sub
    '---------------add by yekta 940319-------------------------------

    Private Sub dcbKalaDS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbKalaDS.Validated
        ' هنگاميکه کالا در اقلام سند انتخاب ميگردد در قسمت تعداد در کارتن و واحد سنجش اطلاعات نمايش داده ميشود
        Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer
        Dim vKalaSN As Decimal
        Dim vResult As Short
        If Val(DVabSanadHa.Fields("KalaSN").Value) <> 0 Then
            vKalaSN = Val(DVabSanadHa.Fields("KalaSN").Value)
            ' بدست آوردن اطلاعات جانبي کالا
            vResult = cn.CallSP("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value,
               System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo,
               VinVahedeSanjeshDs, VinTedadAjza)
            DVabSanadHa.Fields("VahedeSanjeshDs").Text = VinVahedeSanjeshDs
            DVabSanadHa.Fields("TedadAjza").Text = VinTedadAjza
            DVabSanadHa.Fields("KalaSN").Text = VinKalano
        End If

        Dim dv As DataView

        dv = New DataView

        Try

            With DVabSanadHa

                If Not dcbKalaDS.SelectedValue Is Nothing Then
                    dv = cn.ExecuteQuery("Select KalaPhizikiStatusSN,Auto,Meghdar,ISNULL(ToolidDate ,0) AS ToolidDate,ISNULL(EnghezaDate,0) AS EnghezaDate From abAnbarKala Where KalaSN =" & dcbKalaDS.SelectedValue & " and AnbarSn =" & gAnbarSN)
                    If dv.Count > 0 Then
                        .Fields("KalaPhizikiStatusSN").Value = dv.Table.Rows(0).Item("KalaPhizikiStatusSN")
                        .Fields("Auto").Value = dv.Table.Rows(0).Item("Auto")
                        .Fields("Meghdar").Value = dv.Table.Rows(0).Item("Meghdar")
                        .Fields("ToolidDateFlag").Value = dv.Table.Rows(0).Item("ToolidDate")
                        .Fields("EnghezaDateFlag").Value = dv.Table.Rows(0).Item("EnghezaDate")

                    End If
                End If

            End With

            '//
            With DVabSanadHa
                With .Fields("ShomarehRahgiriText")
                    If (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) And
                    (Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 1 Or
                       (Val(DVabSanadHa.FieldValue("KalaPhizikiStatusSN")) = 2 AndAlso Val(DVabSanadHa.FieldValue("Auto")) = 1)) Then
                        .LockInsert = True
                    Else
                        .LockInsert = False
                    End If
                End With
            End With


            'With DVabSanadHa
            '  With .Fields("ToolidDate")
            '    If Val(DVabSanadHa.FieldValue("ToolidDateFlag")) <> 1 Then
            '      .LockInsert = True
            '    Else
            '      .LockInsert = False
            '    End If
            '  End With
            'End With

            'With DVabSanadHa
            '  With .Fields("EnghezaDate")
            '    If Val(DVabSanadHa.FieldValue("EnghezaDateFlag")) <> 1 Then
            '      .LockInsert = True
            '    Else
            '      .LockInsert = False
            '    End If
            '  End With
            'End With


        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        Finally

            If Not dv Is Nothing Then
                dv.Dispose()
            End If
            dv = Nothing

        End Try


    End Sub

    Private Sub dcbMarjaSanadSN2_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbMarjaSanadSN2.Enter

        lblShomarehSefaresh.Text = "شماره ارجاع"

        With DVabSanad.Fields("MarjaSanadSN")
            Select Case mTarakoneshSN
                Case EnumTarakoneshSN.HAVALEH_117_KasriDryaft
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (41)"
                Case EnumTarakoneshSN.HAVALEH_116_EzafehErsal
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (91)"
                Case EnumTarakoneshSN.HAVALEH_111_KahandehKharid
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (SELECT TarakoneshSN FROM dbo.abFnt_GetTarakoneshSN(20))"
                Case EnumTarakoneshSN.RESIDE_BARGASHT_KALAE_AMANI
                    .ComboWhereCondition = .ComboWhereCondition.Replace(gHesabdariSalFDate.ToString, "13900101") + " And abSanad2.TarakoneshSN IN (51)"
                Case EnumTarakoneshSN.HAVALEH_BARGASHTE_KALAE_AMANI
                    .ComboWhereCondition = .ComboWhereCondition.Replace(gHesabdariSalFDate.ToString, "13900101") + " And abSanad2.TarakoneshSN IN (14)"
            End Select
            .RefreshCombo()

        End With


    End Sub

    Private Sub dcbMarjaSanadSN2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbMarjaSanadSN2.Validated

        Dim vResult As DataView

        If (TarakoneshSN = EnumTarakoneshSN.RESIDE_BARGASHT_KALAE_AMANI OrElse TarakoneshSN = EnumTarakoneshSN.HAVALEH_BARGASHTE_KALAE_AMANI) AndAlso IsNumeric(dcbMarjaSanadSN2.SelectedValue) Then

            Try
                vResult = cn.ExecuteQuery("	Select TafsiliSn from abSanad Where SanadSN=" & dcbMarjaSanadSN2.SelectedValue.ToString)
                DVabSanad.Fields("TafsiliSN").Value = vResult.Item(0)("TafsiliSN")
            Catch ex As Exception
                MsgBox("اطلاعات سند مرجع قابل تشخیص نمي باشد")
            End Try

        End If

    End Sub

    Private Sub dcbMarjaSanadSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbMarjaSanadSN.Enter

        lblShomarehSefaresh.Text = "شماره ارجاع"
        If TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Then
            lblShomarehSefaresh.Text += If(MohlatMarjooeiDate.Length = 8, "(فاکتورهای " + MohlatMarjooeiDate + "به بعد)", "")
        End If

        With DVabSanad.Fields("MarjaSanadSN")
            Select Case mTarakoneshSN
                Case EnumTarakoneshSN.HAVALEH_117_KasriDryaft
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (41)"
                Case EnumTarakoneshSN.HAVALEH_116_EzafehErsal
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (91)"
                Case EnumTarakoneshSN.HAVALEH_111_KahandehKharid
                    .ComboWhereCondition = .ComboWhereCondition + " And abSanad2.TarakoneshSN IN (SELECT TarakoneshSN FROM dbo.abFnt_GetTarakoneshSN(20))"
                Case EnumTarakoneshSN.RESIDE_BARGASHT_KALAE_AMANI
                    .ComboWhereCondition = .ComboWhereCondition.Replace(gHesabdariSalFDate.ToString, "13900101") + " And abSanad2.TarakoneshSN IN (51)"
                Case EnumTarakoneshSN.HAVALEH_BARGASHTE_KALAE_AMANI
                    .ComboWhereCondition = .ComboWhereCondition.Replace(gHesabdariSalFDate.ToString, "13900101") + " And abSanad2.TarakoneshSN IN (14)"
            End Select
            .RefreshCombo()
        End With

    End Sub

    Private Sub dcbMarjaSanadSN_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbMarjaSanadSN.Validated

        Dim vResult As DataView

        If (TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) AndAlso
          Val(DVabSanad.Fields("TafsiliSN2").Value) <> 0 Then
            Dim vTafsiliSN2 As Decimal

            vTafsiliSN2 = Val(DVabSanad.Fields("TafsiliSN2").Value)

            Try
                vResult = cn.ExecuteQuery("	Select foMoshtari.TafsiliSn AS TafsiliSN, maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS  AS TafsiliDS " &
                  " FROM foFactor " &
                  " join foMoshtariInfo ON foMoshtariInfo.MoshtariInfoSN = foFactor.MoshtariInfoSN " &
                  " join foMoshtari ON foMoshtariInfo.MoshtariSN = foMoshtari.MoshtariSN " &
                  " join maTafsili ON maTafsili.TafsiliSN = foMoshtari.TafsiliSN " &
                  " WHERE FactorSN = " & vTafsiliSN2)

                DVabSanad.Fields("TafsiliSN").Value = vResult.Item(0)("TafsiliSN")

            Catch ex As Exception
                MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
            End Try

        ElseIf TarakoneshSN = EnumTarakoneshSN.HAVALEH_BARGASHTE_KALAE_AMANI AndAlso Val(DVabSanad.Fields("MarjaSanadSN").Value) <> 0 Then
            Dim vMarjaSanadSN As Decimal

            vMarjaSanadSN = Val(DVabSanad.Fields("MarjaSanadSN").Value)

            Try
                vResult = cn.ExecuteQuery("	Select TafsiliSN from abSanad where SanadSN= " & vMarjaSanadSN)

                DVabSanad.Fields("TafsiliSN").Value = vResult.Item(0)("TafsiliSN")

            Catch ex As Exception
                MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
            End Try

        End If

    End Sub

    Private Sub dcbMojavezErsalHa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbMojavezErsalHa.Enter
        'Change By Yekta 910920  TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid
        If (TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid) Then
            DVabSanadHa.Fields("MojavezErsalHaSN").ComboWhereCondition = "KalaSN = " & CStr(Val(DVabSanadHa.FieldValue("KalaSN"))) & " AND DarkhastKalaState IN(2,3) AND " & IIf(Val(DVabSanad.FieldValue("TarakoneshSN")) < 50, "isnull(darkhastkalamount,0) >= isnull(meghdaredaryafti,0) + " & Val(DVabSanadHa.FieldValue("MeghdareVaredeh")) & " And (IsnUll(AkharinMohlatTahvil,'')='' OR (AkharinMohlatTahvil<= '" & MiladiToShamsi(Today()) & "'))", "isnull(meghdaredaryafti,0)>0")
        Else
            DVabSanadHa.Fields("MojavezErsalHaSN").ComboWhereCondition = "1=0"
        End If

        DVabSanadHa.Fields("MojavezErsalHaSN").RefreshCombo()
    End Sub

    '---------- yekta 920416--------------------------------------
    Private Sub dcbSanadhaDarkhast_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbSanadhaDarkhast.Enter
        'Change By Yekta 910920  TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid
        If (TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI) Then   'add Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI by yekta  931121
            'DVabSanadHaDarkhast.Fields("DarkhastKalaNO").ComboWhereCondition = "tddarkhastkala.KalaSN = " & CStr(Val(DVabSanadHa.FieldValue("KalaSN"))) & " AND DarkhastKalaState IN(2,3) AND " & IIf(Val(DVabSanad.FieldValue("TarakoneshSN")) < 50, "isnull(darkhastkalamount,0) >= isnull(meghdaredaryafti,0) + " & Val(DVabSanadHa.FieldValue("MeghdareVaredeh")) & " And (IsnUll(AkharinMohlatTahvil,'')='' OR (AkharinMohlatTahvil<= '" & MiladiToShamsi(Today()) & "'))", "isnull(meghdaredaryafti,0)>0")
            DVabSanadHaDarkhast.Fields("DarkhastKalaNO").ComboWhereCondition = "tddarkhastkala.KalaSN = " & CStr(Val(DVabSanadHa.FieldValue("KalaSN"))) & " AND tddarkhastkala.DarkhastKalaState IN(2,3,5)"
        Else
            DVabSanadHaDarkhast.Fields("DarkhastKalaNO").ComboWhereCondition = "1=0"
        End If

        DVabSanadHaDarkhast.Fields("DarkhastKalaNO").RefreshCombo()
    End Sub
    '---------- yekta 920416--------------------------------------

    Private Sub dcbDarkhastHa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dcbDarkhastHa.Enter
        DVabSanadHa.Fields("DarkhastHaSN").ComboWhereCondition = "KalaSN = " & Val(DVabSanadHa.FieldValue("KalaSN"))
        DVabSanadHa.Fields("DarkhastHaSN").RefreshCombo()
    End Sub

    'Private Sub dcbMojavezErsalHa_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dcbMojavezErsalHa.KeyUp  comment by yekta 920415
    '    ' در مورد کنترل کليد اف 8 و انجام عمليات مربوطه
    '    ' نمايش درخواستهای يک کالا 
    '    '890914 غفاری

    '    If e.KeyCode = System.Windows.Forms.Keys.F8 Then
    '        If Not DVabSanadHa Is Nothing Then
    '            If DVabSanadHa.State = EnumDataViewState.bsAdd Or DVabSanadHa.State = EnumDataViewState.bsEdit Then
    '                If Val(DVabSanadHa.Fields("KalaSN").Value) <> 0 AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI) Then   'محدود کردن عملکرد اف 8 به فرم رسید -غفاری - 890914
    '                    tmrF8.Enabled = True
    '                End If
    '            End If
    '        End If
    '    End If

    'End Sub
    '---------------- Add By Yekta 920228
    Private Sub dcbSanadhaDarkhast_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dcbSanadhaDarkhast.KeyUp
        ' در مورد کنترل کليد اف 8 و انجام عمليات مربوطه
        ' نمايش درخواستهای يک کالا 
        '890914 غفاری

        If e.KeyCode = System.Windows.Forms.Keys.F8 Then
            If Not DVabSanadHaDarkhast Is Nothing Then
                If DVabSanadHaDarkhast.State = EnumDataViewState.bsAdd Or DVabSanadHaDarkhast.State = EnumDataViewState.bsEdit Then
                    If Val(DVabSanadHa.Fields("KalaSN").Value) <> 0 AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI) Then   'محدود کردن عملکرد اف 8 به فرم رسید -غفاری - 890914
                        tmrF8.Enabled = True
                        gIsF8InTabDarkhast = True
                    End If
                End If
            End If
        End If

    End Sub
    '---------------- Add By Yekta 920228
#End Region

#Region "DataView"

    Private Sub DVabSanad_GetGridProperties() _
        Handles DVabSanad.GetGridProperties
        ' امکان انتخاب گروهي فعال گردد
        With DVabSanad.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Function DVabSanad_DataValidation() As String
        ' کنترل برخي از موارد که نيازي به بانک اطلاعات ندارد
        Dim vShomarehSefaresh As String
        DVabSanad_DataValidation = ""
        vShomarehSefaresh = DVabSanad.Fields("ShomarehSefaresh").Value
        If Trim(vShomarehSefaresh) <> "" And (Not IsNumeric(vShomarehSefaresh) _
         Or InStr(vShomarehSefaresh, ".") <> 0 Or InStr(vShomarehSefaresh, ",") <> 0) Then
            DVabSanad_DataValidation = "شماره نمي تواند غير عددي باشد"
        End If
    End Function

    Private Sub DVabSanad_AfterCommandClick(ByVal aCommand As EnumCommands) _
        Handles DVabSanad.AfterCommandClick
        ' براي آنکه بعد از ثبت عنوان سند کنترل برود روي اقلام سند    حتي در حالتي که کاربر سريع اين کار را انجام ميدهد
        Select Case aCommand
            Case EnumCommands.cmAdd
                dbcTarakoneshSN.Enabled = True
                dbcTarakoneshSN.SelectedValue = KeepTarakoneshForCombo
                'dbcTarakoneshSN.SelectedValue = DVabSanad.FieldValue("TarakoneshSN")
                'System.Windows.Forms.Application.DoEvents()
            Case EnumCommands.cmSave
                DVabSanad.FetchCurRecord()
                DVabSanad.FlexGrid.Select(DVabSanad.DataRows, 1, Nothing, Nothing)

            Case EnumCommands.cmEdit
                dbcTarakoneshSN.Enabled = False
                'Case EnumCommands.cmEdit
                '    DVabSanad.AutoFetchCurrentRow = True
        End Select
        ' از آنجا که عمليات اطلاعاتي انجام نمي شود از اين روش براي رفع خطا استفاده شده است 
        ' '' '' '' '' ''On Error Resume Next
        ' '' '' '' '' ''If aCommand = EnumCommands.cmSave Then
        ' '' '' '' '' ''    DVabSanadHa.FlexGrid.Row = 1
        ' '' '' '' '' ''    DVabSanadHa.FlexGrid.Col = 1
        ' '' '' '' '' ''    DVabSanadHa.FlexGrid.SetFocus()
        ' '' '' '' '' ''    System.Windows.Forms.SendKeys.Send("{Home}{Left}")
        ' '' '' '' '' ''End If
    End Sub

    Private Sub DVabSanad_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSanad.CommandClick
        Dim vErrMsg As String
        Dim vResult As Short
        Dim vVahedeTejariSN, vAnbarSN, vWorkOrederSN, vSanadSN, vNoeAnbarSN, vSanadDate, vshomarehbarnameh As Object
        Dim vSanadStatus, vSanadStatusMali, vTarafHesabSN, vTarakoneshSN, vTafsiliSN1, vTafsiliSN2, vMarjaSanadSN As Object
        Dim vEDAnbarSN, vEDNoeAnbarSN As Object
        Dim vShomarehSefaresh, vTarafHesab As Object
        Dim vState As Short
        Dim vNoeSanadID As Short

        Dim DV As DataView

        lblShomarehSefaresh.Text = "شماره ارجاع"


        If (aCommand = EnumCommands.cmEdit) Then
            With DVabSanad
                If Not (
                 Val(DVabSanad.Fields("TarakoneshSN").Value) = 41 _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 41 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 45) _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 41 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 95) _
                 Or Val(DVabSanad.Fields("TarakoneshSN").Value) = 22 _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 22 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 45) _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 22 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 95) _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 91 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 45) _
                 Or (Val(DVabSanad.Fields("MarjaTarakoneshSN").Value) = 91 And Val(DVabSanad.Fields("TarakoneshSN").Value) = 95) _
                 Or Val(.Fields("BarcodeReaderSanad").Value) = 1
                 ) And Val(DVabSanad.Fields("NoeSanadID").Value) = 2 Then
                    aCancel = True
                    vErrMsg = "سند انبار از نوع ماشيني را نمي توان تغيير داد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
            End With
        End If

        If (aCommand = EnumCommands.cmDelete) Then
            With DVabSanad
                If Val(.Fields("NoeSanadID").Value) = 2 AndAlso Val(.Fields("BarcodeReaderSanad").Value) = 0 Then
                    aCancel = True
                    vErrMsg = "سند انبار از نوع ماشيني را نمي توان تغيير داد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
            End With
        End If


        If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh Or
         aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint Or
         aCommand = EnumCommands.cmFilter) Then


            If (TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH Or TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) Then
                If Val(DVabSanad.Fields("TafsiliSN2").Value) <> 0 Then
                    vTafsiliSN2 = Val(DVabSanad.Fields("TafsiliSN2").Value)

                    Try
                        DV = cn.ExecuteQuery("	Select Distinct foMoshtari.TafsiliSn AS TafsiliSN, maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS  AS TafsiliDS " &
                          " FROM foFactor with (nolock)" &
                          " join foMoshtariInfo with (nolock) ON foMoshtariInfo.MoshtariInfoSN = foFactor.MoshtariInfoSN " &
                          " join foMoshtari with (nolock) ON foMoshtariInfo.MoshtariSN = foMoshtari.MoshtariSN " &
                          " join maTafsili with (nolock) ON maTafsili.TafsiliSN = foMoshtari.TafsiliSN " &
                          " WHERE FactorSN = " & vTafsiliSN2)

                        DVabSanad.Fields("TafsiliSN").Value = DV.Item(0)("TafsiliSN")
                    Catch ex As Exception
                        MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
                    End Try
                End If


            End If

            'If aCommand = EnumCommands.cmSave AndAlso TarakoneshSN = EnumTarakoneshSN.RESIDE_11_HAMLE_MOSTAGHIM Then
            '    If CSystem.MsgBox("توجه داشته باشید در صورتی که سند مربوطه <حمل مستقیم به مشتری> می باشد کد مشتری می بایست در بخش طرف حساب2 درج گردد" + vbNewLine + "آیا مایل به ادامه عملیات ذخیره سازی هستید؟", MsgBoxStyle.YesNo, "حمل مستقیم") = MsgBoxResult.No Then
            '        aCancel = True
            '        Exit Sub
            '    End If

            'End If

            'If TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE And _
            '  Val(DVabSanad.Fields("ShomarehSefaresh").Value) <> 0 Then
            '  vShomarehSefaresh = Val(DVabSanad.Fields("ShomarehSefaresh").Value)

            '  Try
            '    DV = cn.ExecuteQuery("	Select Distinct foMoshtari.TafsiliSn AS TafsiliSN, maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS  AS TafsiliDS " & _
            '                              " FROM toVw_toBargeMarjooei " & _
            '                              " join foFactor ON toVw_toBargeMarjooei.FactorSN = foFactor.FactorSN  " & _
            '                              " join foMoshtariInfo ON foMoshtariInfo.MoshtariInfoSN = foFactor.MoshtariInfoSN " & _
            '                              " join foMoshtari ON foMoshtariInfo.MoshtariSN = foMoshtari.MoshtariSN " & _
            '                              " join maTafsili ON maTafsili.TafsiliSN = foMoshtari.TafsiliSN " & _
            '                              " Where BargeMarjooeiStatus = 8  " & _
            '                              "	AND BargeMarjooeiNo is not null  " & _
            '                              "	AND BargeMarjooeiNo = " & vShomarehSefaresh)
            '    DVabSanad.Fields("TafsiliSN").Value = DV.Item(0)("TafsiliSN")
            '  Catch ex As Exception
            '    MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
            '  End Try
            'End If
        End If

        If aCommand = EnumCommands.cmPrint Then
            ' چاپ داراي فرمت رسمي سند
            DVabSanad.IgnoreDefaultAction()
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            If gPrintHavaleh = 1 Then
                Dim vRptabSanad1 As New Minoo.Applications.Anbar.Report.RptHavalehForooshDaroee
                With vRptabSanad1
                    Dim vbNoeAnbarSN As Decimal
                    vbNoeAnbarSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)
                    If vbNoeAnbarSN = 0 Then
                        .gRptabSanadNoeAnbar = gNoeAnbarSN
                    Else
                        .gRptabSanadNoeAnbar = vbNoeAnbarSN
                    End If
                    .DefField()

                    .PageSettings.PaperKind = Printing.PaperKind.A4
                    .PageSettings.Margins.Left = 0
                    .PageSettings.Margins.Right = 0
                    .PageSettings.Margins.Top = 0
                    .PageSettings.Margins.Bottom = 0
                    ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                    ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                    .DataSource = cn.SPQuery("_abSpr_ChapeSanad", DVabSanad.Fields("sanadSN").Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                         , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                       , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                       , System.DBNull.Value, System.DBNull.Value, 0)

                    Minoo.Reports.FTReportViewer.ShowReport(vRptabSanad1, CSanad.gMDIParent)

                End With
            Else
                Dim vRptabSanad As New Object

                If gVahedeTejariSN = 230004.935 Or gAnbarSN = 380.101 Then
                    vRptabSanad = New Report.RptHavalehForooshMinooCaspian
                Else
                    vRptabSanad = New Report.RptabSanad

                End If
                With vRptabSanad
                    Dim vbNoeAnbarSN As Decimal
                    Dim TarakoneshSN As Double
                    TarakoneshSN = Val(DVabSanad.Fields("TarakoneshSN").Value)
                    vbNoeAnbarSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)

                    If vbNoeAnbarSN = 0 Then
                        .gRptabSanadNoeAnbar = gNoeAnbarSN
                    Else
                        .gRptabSanadNoeAnbar = vbNoeAnbarSN
                    End If
                    .vbNoeTarakonesh = TarakoneshSN
                    .DefField()
                    .PageSettings.PaperKind = Printing.PaperKind.A4
                    .PageSettings.Margins.Left = 0
                    .PageSettings.Margins.Right = 0
                    .PageSettings.Margins.Top = 0
                    .PageSettings.Margins.Bottom = 0
                    ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                    ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                    Dim DvSource As DataView = cn.SPQuery("_abSpr_ChapeSanad", DVabSanad.Fields("sanadSN").Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                         , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                       , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value _
                       , System.DBNull.Value, System.DBNull.Value, 0)
                    DvSource.Sort = "KalaNo"
                    .DataSource = DvSource

                    Minoo.Reports.FTReportViewer.ShowReport(vRptabSanad, CSanad.gMDIParent)

                End With
            End If


            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

        If Not (aCommand = EnumCommands.cmAdd Or aCommand = EnumCommands.cmDelete Or aCommand = EnumCommands.cmAbort Or aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh Or aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint Or aCommand = EnumCommands.cmFilter) Then
            aCancel = True
            vVahedeTejariSN = gVahedeTejariSN
            vAnbarSN = gAnbarSN
            vNoeAnbarSN = IIf(Val(DVabSanad.Fields("NoeAnbarSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("NoeAnbarSN").Value)
            vSanadSN = IIf(Val(DVabSanad.Fields("SanadSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("SanadSN").Value)
            vSanadDate = IIf(Trim(DVabSanad.Fields("SanadDate").Value) = "", "", DVabSanad.Fields("SanadDate").Value)
            vSanadStatus = IIf(Val(DVabSanad.Fields("SanadStatus").Value) = 0, System.DBNull.Value, DVabSanad.Fields("SanadStatus").Value)
            vSanadStatusMali = IIf(Val(DVabSanad.Fields("SanadStatusMali").Value) = 0, System.DBNull.Value, DVabSanad.Fields("SanadStatusMali").Value)
            vTarakoneshSN = IIf(Val(DVabSanad.Fields("TarakoneshSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("TarakoneshSN").Value)
            vTarafHesabSN = IIf(Val(DVabSanad.Fields("TafsiliSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("TafsiliSN").Value)
            vTafsiliSN1 = IIf(Val(DVabSanad.Fields("TafsiliSN1").Value) = 0, System.DBNull.Value, DVabSanad.Fields("TafsiliSN1").Value)
            vTafsiliSN2 = IIf(Val(DVabSanad.Fields("TafsiliSN2").Value) = 0, System.DBNull.Value, DVabSanad.Fields("TafsiliSN2").Value)
            vEDAnbarSN = IIf(Val(DVabSanad.Fields("EDAnbarSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("EDAnbarSN").Value)
            vEDNoeAnbarSN = IIf(Val(DVabSanad.Fields("EDNoeAnbarSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("EDNoeAnbarSN").Value)
            vWorkOrederSN = IIf(Val(DVabSanad.Fields("WorkOrederSN").Value) = 0, System.DBNull.Value, DVabSanad.Fields("WorkOrederSN").Value)
            vShomarehSefaresh = IIf(Val(DVabSanad.Fields("ShomarehSefaresh").Value) = 0, System.DBNull.Value, DVabSanad.Fields("ShomarehSefaresh").Value)
            vTarafHesab = IIf(Val(DVabSanad.Fields("TarafHesab").Value) = 0, System.DBNull.Value, DVabSanad.Fields("TarafHesab").Value)
            vNoeSanadID = Val(DVabSanad.Fields("NoeSanadID").Value)
            vMarjaSanadSN = Val(DVabSanad.Fields("MarjaSanadSN").Value)
            vshomarehbarnameh = Val(DVabSanad.Fields("ShomarehBarnameh").Value)

            vState = DVabSanad.State


            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
            vResult = cn.CallSP("_abSPC_abSanadEnter", gVahedeTejariSN, gAnbarSN, vNoeAnbarSN, vSanadSN _
               , vSanadDate, vSanadStatus, vSanadStatusMali, vTarakoneshSN, vTarafHesabSN _
               , vTafsiliSN1, vTafsiliSN2, vEDAnbarSN, vEDNoeAnbarSN, vWorkOrederSN, vShomarehSefaresh, vTarafHesab _
               , aCommand, vState, vErrMsg, vMarjaSanadSN) ', vNoeSanadID
            If Trim(vErrMsg) <> "" Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            Else
                aCancel = False
            End If
        End If


        If dbcNoeAnbarSN.BoundText = "" Then DVabSanad.Fields("NoeAnbarSN").Value = ""

        Select Case aCommand
            Case EnumCommands.cmRefresh
            Case EnumCommands.cmSave
                txtMoaserDate.Text = txtSanadDate.Text
                If DVabSanad_DataValidation() <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox(DVabSanad_DataValidation, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                End If
                DVabSanad.Fields("TarakoneshSN").ComboWhereCondition = pdbcTarakoneshSNComboWhereCondition
                DVabSanad.Fields("TarakoneshSN").RefreshCombo()

                '910227
                'تراکنش هايي که نبايد طرف حسابشان تفصيلي خودش نباشد - تفصيلي شعبه يا تفصيلي انبار
                Dim dvTarakonesh As New DataView
                dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(18) where TarakoneshSN = " & Val(DVabSanad.Fields("TarakoneshSN").Value))
                If dvTarakonesh.Count = 1 Then
                    Dim dvAnbarTafsili As New DataView
                    dvAnbarTafsili = cn.ExecuteQuery("select payesn as AnbarTafsiliSN from abanbar where anbarsn = " & Val(DVabSanad.Fields("AnbarSN").Value))
                    If dvAnbarTafsili.Count = 1 Then
                        If Val(dvAnbarTafsili(0)("AnbarTafsiliSN")) = Val(DVabSanad.Fields("TafsiliSN").Value) Then
                            NetSql.Common.CSystem.MsgBox("طرف حساب براي اين تراکنش نمي تواند انبار فعلي باشد", MsgBoxStyle.Information, "توجه")
                            aCancel = True
                        End If
                    End If
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '' کنترل اینکه فاکتور مربوط به همان مشتری باشد
                If (TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) Then
                    If Val(DVabSanad.Fields("TafsiliSN").Value) <> 0 Then
                        Dim v_abSanad_TafsiliSN As Decimal = Val(DVabSanad.Fields("TafsiliSN").Value)
                        Dim v_abSanad_TafsiliSN2 As Decimal = Val(DVabSanad.Fields("TafsiliSN2").Value)
                        Dim istoolidi As Boolean = IsVahedTejariTolidi

                        Try
                            Dim _DV As New DataView
                            _DV = cn.ExecuteQuery("select foFactor.FactorSN " &
                                "from foFactor " &
                                "join foMoshtariInfo ON foMoshtariInfo.MoshtariInfoSN = foFactor.MoshtariInfoSN " &
                                "join foMoshtari ON foMoshtariInfo.MoshtariSN = foMoshtari.MoshtariSN " &
                                "join maTafsili ON maTafsili.TafsiliSN = foMoshtari.TafsiliSN " &
                                "where " &
                                 IIf(istoolidi, "foFactor.Res2 NOT IN (3.101 , 4.101,5.101,20.101)", " foFactor.Res2 in (1.101,2.101) ") &
                                 " and foMoshtari.TafsiliSN = " & v_abSanad_TafsiliSN &
                                 " and foFactor.FactorSN = " & v_abSanad_TafsiliSN2)
                            If _DV.Count <> 1 Then
                                MsgBox("فاکتور برای مشتری انتخاب شده نمی باشد")
                                aCancel = True
                            End If
                        Catch ex As Exception
                            MsgBox("اطلاعات مشتري قابل دسترسي نمي باشد")
                        End Try
                    End If
                    If ChkIsFakorEbtal.Checked Then
                        If CSystem.MsgBox("با ادامه عملیات کل اقلام فاکتور به صورت اتوماتیک در این سند ثبت خواهد شد.آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "مرجوعی کل فاکتور") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    End If

                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


            Case EnumCommands.cmAbort
                DVabSanad.Fields("TarakoneshSN").ComboWhereCondition = pdbcTarakoneshSNComboWhereCondition
                DVabSanad.Fields("TarakoneshSN").RefreshCombo()

            Case EnumCommands.cmEdit
                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
                With DVabSanad
                    '910309
                    ' هنگام اصلاح سند شماره ارجاع اين تراکنش ها نبايد اصلاح گردد
                    If .Fields("TarakoneshSN").Value = 45 Or .Fields("TarakoneshSN").Value = 95 _
                        Or .Fields("TarakoneshSN").Value = 111 _
                       Or .Fields("TarakoneshSN").Value = 38 Or .Fields("TarakoneshSN").Value = 39 Then
                        .Fields("MarjaSanadSN").ReadOnly = True
                    End If
                    .Fields("HavalehForooshSN").ReadOnly = True
                    .Fields("NoeAnbarSN").ReadOnly = True
                    dbcNoeAnbarSN.Enabled = False
                    .Fields("VahedeTejariSN").ReadOnly = True
                    .Fields("TarakoneshSN").ReadOnly = True
                    dbcTarakoneshSN.Enabled = False

                End With
                DVabSanad.Fields("TarakoneshSN").ComboWhereCondition = pdbcTarakoneshSNComboWhereCondition
                DVabSanad.Fields("TarakoneshSN").RefreshCombo()
            Case EnumCommands.cmAdd
                DVabSanad.Fields("TarakoneshSN").ComboWhereCondition = pdbcTarakoneshSNInsertComboWhereCondition
                DVabSanad.Fields("TarakoneshSN").RefreshCombo()
                KeepTarakoneshForCombo = DVabSanad.Fields("TarakoneshSN").Value

                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
                With DVabSanad
                    .Fields("ShomarehSefaresh").ReadOnly = False
                    txtShomarehSefaresh.Enabled = True
                    .Fields("HavalehForooshSN").ReadOnly = False
                    .Fields("MarjaSanadSN").ReadOnly = False
                    .Fields("TarakoneshSN").ReadOnly = False
                    dbcTarakoneshSN.Enabled = True
                    .Fields("NoeAnbarSN").ReadOnly = False
                    dbcNoeAnbarSN.Enabled = True
                    .Fields("VahedeTejariSN").ReadOnly = False
                End With
            Case EnumCommands.cmDelete
                DVabSanad.DeleteQuestion = "آيا اطلاعات حذف شوند ؟" + vbNewLine + If(ChkIsFakorEbtal.Checked, "با توجه به اینکه سند مذکور از نوع فاکتور ابطالی است کلیه اقلام سند با ادامه عملیات حذف خواهد شد", "")
        End Select
        Select Case TarakoneshSN
            Case EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH
                dbcTarakoneshSN.Enabled = False
                DVabSanad.Fields("TarakoneshSN").ReadOnly = True

                '910309
            Case EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH,
                EnumTarakoneshSN.HAVALEH_111_KahandehKharid,
                EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH,
                EnumTarakoneshSN.HAVALEH_116_EzafehErsal,
                EnumTarakoneshSN.HAVALEH_117_KasriDryaft,
                EnumTarakoneshSN.RESIDE_06_EzafehDryaft,
                EnumTarakoneshSN.RESIDE_07_KasriErsal
                dbcTarakoneshSN.Enabled = False
                DVabSanad.Fields("TarakoneshSN").ReadOnly = True
            Case EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE
                dbcTarakoneshSN.Enabled = False
                DVabSanad.Fields("TarakoneshSN").ReadOnly = True
                If aCommand = EnumCommands.cmAdd Then
                    ChkIsFakorEbtal.Enabled = True
                Else
                    ChkIsFakorEbtal.Enabled = False
                End If
        End Select

    End Sub

    Private Sub DVabSanad_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabSanad.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        Dim vSanadStatus As String
        Dim vEnabled_Status1_4 As Boolean
        Dim vEnabled_Status4_8 As Boolean
        Dim vBarnamehID As String
        Dim vMarjaSanadID As String

        btnStatus4_8.Enabled = False
        btnStatus1_4.Enabled = False
        pnlNoeMarjooei.Enabled = False
        btnDelSelected.Enabled = False
        btnEslahRahgiri.Enabled = False
        btnEslahSanad.Enabled = False

        ' در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DVabSanad.FlexGrid.Rows = 1 Then Exit Sub
        If aClip("TarakoneshSN") = Nothing Then Exit Sub

        TarakoneshSN = aClip("TarakoneshSN")
        vSanadStatus = aClip("SanadStatus")

        ' کنترل هاي لازم براي پيشنويس به موقت
        vEnabled_Status1_4 = (vSanadStatus = "1")
        If vEnabled_Status1_4 Then
            ' با توجه به کليد دسترسي دسترسي کنترل ميگردد
            ' البته با توجه به نوع فرم فراخواني شده
            Select Case NoeTarakoneshSN
                Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                    vEnabled_Status1_4 = (gSM.TableAccessRight("AvalDoreh_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntRESIDHA
                    vEnabled_Status1_4 = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                    vEnabled_Status1_4 = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntHAVALEHHA
                    vEnabled_Status1_4 = (gSM.TableAccessRight("Havaleh_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                    vEnabled_Status1_4 = (gSM.TableAccessRight("EzafiMojoodiAnbar_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                    vEnabled_Status1_4 = (gSM.TableAccessRight("KasriMojoodiAnbar_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                    vEnabled_Status1_4 = (gSM.TableAccessRight("ResideBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                    vEnabled_Status1_4 = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                Case Else
                    vEnabled_Status1_4 = False
            End Select
        End If
        With DVabSanad
            .CommandEnabled(EnumCommands.cmEdit) = (vSanadStatus = "1") And (.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) = (vSanadStatus = "1") And (.AccessRight And EnumAccessRight.arDelete) <> 0
            btnStatus1_4.Enabled = vEnabled_Status1_4
            pnlNoeMarjooei.Enabled = vEnabled_Status1_4
            btnDelSelected.Enabled = vEnabled_Status1_4
        End With
        With DVabSanadHa
            .AccessRight = DVabSanad.AccessRight
            .CommandEnabled(EnumCommands.cmAdd) = (vSanadStatus = "1") And (DVabSanad.AccessRight And EnumAccessRight.arInsert) <> 0
            .CommandEnabled(EnumCommands.cmEdit) = (vSanadStatus = "1") And (DVabSanad.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) = (vSanadStatus = "1") And (DVabSanad.AccessRight And EnumAccessRight.arDelete) <> 0
        End With
        ' کنترل هاي لازم براي پيشنويس به موقت

        ' کنترل هاي لازم براي موقت به نهايي
        Select Case NoeTarakoneshSN
            Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                vEnabled_Status4_8 = (gSM.TableAccessRight("AvalDoreh_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDHA
                vEnabled_Status4_8 = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                vEnabled_Status4_8 = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHHA
                vEnabled_Status4_8 = (gSM.TableAccessRight("Havaleh_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                vEnabled_Status4_8 = (gSM.TableAccessRight("EzafiMojoodiAnbar_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                vEnabled_Status4_8 = (gSM.TableAccessRight("KasriMojoodiAnbar_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                vEnabled_Status4_8 = (gSM.TableAccessRight("ResideBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehKahandehKharid_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                vEnabled_Status4_8 = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
            Case Else
                vEnabled_Status4_8 = False
        End Select
        If vEnabled_Status4_8 And (vSanadStatus = "1" Or vSanadStatus = "4") Then
            With DVabSanad
                .CommandEnabled(EnumCommands.cmEdit) = vEnabled_Status4_8 And (.AccessRight And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled(EnumCommands.cmDelete) = vEnabled_Status4_8 And (.AccessRight And EnumAccessRight.arDelete) <> 0
                btnStatus4_8.Enabled = vEnabled_Status4_8
                pnlNoeMarjooei.Enabled = vEnabled_Status4_8
                btnDelSelected.Enabled = vEnabled_Status4_8
            End With
            With DVabSanadHa
                .AccessRight = DVabSanad.AccessRight
                .CommandEnabled(EnumCommands.cmAdd) = vEnabled_Status4_8 And (DVabSanad.AccessRight And EnumAccessRight.arInsert) <> 0
                .CommandEnabled(EnumCommands.cmEdit) = vEnabled_Status4_8 And (DVabSanad.AccessRight And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled(EnumCommands.cmDelete) = vEnabled_Status4_8 And (DVabSanad.AccessRight And EnumAccessRight.arDelete) <> 0
            End With
        End If
        ' کنترل هاي لازم براي موقت به نهايي

        'TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH Or _ 850303
        If TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Or TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH Then
            With DVabSanadHa
                .CommandEnabled(EnumCommands.cmAdd) = False
                '.CommandEnabled(EnumCommands.cmDelete) = False
            End With
        End If

        '910309
        'Or DVabSanad.Fields("MarjaTarakoneshSN").Value = "38" _ 850303
        If (TarakoneshSN = EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH _
          Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH _
          Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid) _
          And (DVabSanad.Fields("MarjaTarakoneshSN").Value = "39") _
          And vSanadStatus <> 1 Then
            With DVabSanadHa
                .CommandEnabled(EnumCommands.cmAdd) = False
                .CommandEnabled(EnumCommands.cmDelete) = False
            End With
        End If

        If aFetched Then
            VNoeVoroodeAsnad = Val(DVabSanad.FlexGrid.TextMatrix(DVabSanad.FlexGrid.Row,
                DVabSanad.FlexGrid.ColIndex("NoeVoroodeAsnadSN") + 1))
            btnStatus1_4.Enabled = aClip("SanadStatus") = 1
            btnStatus4_8.Enabled = (aClip("SanadStatus") = 1) Or (aClip("SanadStatus") = 4)
            If DVabSanad.AccessRight = EnumAccessRight.arView Then
                pnlNoeMarjooei.Enabled = False
                btnDelSelected.Enabled = False
            End If
            If Not vEnabled_Status4_8 Then
                btnStatus4_8.Enabled = False
            End If
            If Not vEnabled_Status1_4 Then
                btnStatus1_4.Enabled = False
            End If
            EnableFields()
        End If

        btnDarjAghlamFactor.Enabled = (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH) And vSanadStatus = 1 And Not ChkIsFakorEbtal.Checked
        btnDarjAghlamFactor.Visible = (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH) And vSanadStatus = 1 And Not ChkIsFakorEbtal.Checked
        'Yekta 910425  EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
        'yekta 910426
        btnEslahRahgiri.Enabled = (TarakoneshSN <> EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH And ((NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Or (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDKASRIERSAL) Or (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar))) And (gSM.TableAccessRight("EslahRahgiri") = EnumAccessRight.arAll) And vSanadStatus = 8 'And Val(DVabSanad.FieldValue("NOeSanadID")) <> 2
        btnEslahRahgiri.Visible = ((NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Or (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDKASRIERSAL) Or (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar)) And (gSM.TableAccessRight("EslahRahgiri") = EnumAccessRight.arAll) 'And Val(DVabSanad.FieldValue("NOeSanadID")) <> 2
        'DVabSanad.FlexGrid.Cell( CellPropertySettings.flexcpForeColor, DVabSanad.FlexGrid.Row, 0, DVabSanad.FlexGrid.Row, DVabSanad.FlexGrid.Cols - 1) = RGB(0, 255, 0)

        If aFetched AndAlso DVabSanad.FieldValue("SanadSN") <> "" Then
            Dim TarakoneshIncluded As Boolean = False
            Dim dvTarakonesh As New DataView
            dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(23) where TarakoneshSN = " & Val(DVabSanad.Fields("TarakoneshSN").Value))
            If dvTarakonesh.Count = 1 Then
                TarakoneshIncluded = True
            End If

            If TarakoneshIncluded Then
                DVabBarnameh.CommandEnabled(EnumCommands.cmAdd) = True
                btnListBarnameh.Enabled = True
                DVabBarnameh.SQLWhere = "abBarnameh.BarnamehSN = (select abBarnameh.BarnamehSN from abBarnameh inner join abBarnamehHa on abBarnameh.BarnamehSN = abBarnamehHa.BarnamehSN where SanadSN = " & DVabSanad.FieldValue("SanadSN") & " and BarnamehStatus <> 2)"
                DVabBarnameh.Refresh()
            Else
                DVabBarnameh.CommandEnabled(EnumCommands.cmAdd) = False
                btnListBarnameh.Enabled = False
                DVabBarnameh.SQLWhere = "1<>1"
                DVabBarnameh.Refresh()
            End If
        End If

        dbcTarafHesabSN.SelectedValue = DVabSanad.FieldValue("TafsiliSN")

        Dim GVahedeTejariUsesKartablZayeat As Boolean = If(CApp.GetAppConfig("GVahedeTejariUsesKartablZayeat") Is System.DBNull.Value, False, True)

        If GVahedeTejariUsesKartablZayeat _
            AndAlso DVabSanad.FieldValue("SanadStatus") <> "8" _
            AndAlso (DVabSanad.FieldValue("RezSN4") >= "1" OrElse TarakoneshSN = EnumTarakoneshSN.HAVALEH_81_ZAYEAT) _
            AndAlso (DVabSanad.FieldValue("NoeAnbarSN") = "2" Or DVabSanad.FieldValue("NoeAnbarSN") = "10") Then
            dvTarakoneshGorooh88.RowFilter = "TarakoneshSN=" & CInt(TarakoneshSN).ToString
            If dvTarakoneshGorooh88.Count > 0 Then
                DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("paNoeZayeat_NoeZayeatSN")) = False
                DVabSanadHa.FlexGrid.AutoSizeCol(DVabSanadHa.FlexGrid.ColIndex("paNoeZayeat_NoeZayeatSN"))
            End If
            dvTarakoneshGorooh88.RowFilter = "0=0"
        End If

        ''ghasemi14010121
        ''نمایش دکمه ثبت در سامانه در گروه تراکنش های مجاز
        If aFetched AndAlso DVabSanad.FieldValue("SanadSN") <> "" Then
            Dim TarakoneshIncluded As Boolean = False
            Dim dvTarakonesh As New DataView
            dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(87) where TarakoneshSN = " & Val(DVabSanad.Fields("TarakoneshSN").Value))

            If dvTarakonesh.Count = 1 Then
                btnSabtSanaddarSamaneh.Enabled = (gSM.ActionEnabled(btnSabtSanaddarSamaneh.Name) = True) And Val(DVabSanad.FieldValue("SanadStatus")) = 8
            Else
                btnSabtSanaddarSamaneh.Enabled = False
            End If
        End If
        ''ghasemi14010121

        If DVabSanadHa.DataRows > 0 Then
            For i As Integer = 0 To DVabSanadHa.FlexGrid.ColumnCollection.Count - 1
                DVabSanadHa.FlexGrid.AutoSizeCol(i)
            Next
        End If

        If IsNumeric(DVabSanad.FieldValue("BarcodeReaderSanad")) AndAlso DVabSanad.FieldValue("BarcodeReaderSanad") = 1 Then
            DVabSanad.CommandEnabled(EnumCommands.cmEdit) = False
        End If

        lblShomarehSefaresh.Text = "شماره ارجاع"
        If TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH OrElse TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Then
            lblShomarehSefaresh.Text += If(MohlatMarjooeiDate.Length = 8, "(فاکتورهای " + MohlatMarjooeiDate + "به بعد)", "")
        End If


    End Sub

    Private Sub DVabSanadHa_AfterCommandClick(ByVal aCommand As EnumCommands) _
        Handles DVabSanadHa.AfterCommandClick

    End Sub

    Private Sub DVabSanadHa_AfterSPExecute(ByVal aSPKind As EnumSPKind, ByVal aCommand As Object) _
        Handles DVabSanadHa.AfterSPExecute
        If Trim(DVabSanadHa.InsertSPUserParam) <> "" Then
            NetSql.Common.CSystem.MsgBox(DVabSanadHa.InsertSPUserParam)
        End If
    End Sub

    Private Sub DVabSanadHa_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSanadHa.CommandClick
        Static vcmAdd As Boolean
        Dim vKalaPhizikiSN As Object
        'Dim vKalaPhizikiUID As Object
        Dim vShomarehRahgiri As String
        Dim vErrMsg As String
        Dim vResult As Short
        Dim vNoeAsnadSN As Decimal
        Dim vVahedeTejariSN, vAnbarSN As Object
        Dim vSanadDate, vNoeAnbarSN, vSanadSN, vSanadHaSN As Object
        Dim vSanadStatus, vSanadStatusMali As Object
        Dim vTarakoneshSN, vTarafHesabSN, vTafsiliSN2 As Object
        Dim vEDAnbarSN, vEDNoeAnbarSN As Object
        Dim vState As Short
        Dim vKalaSN As Object
        Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
        Dim VNoeMarjooeiSN, VNoeZayeatSN, VNoeMadomiSN As Object
        Dim vKalaPhizikiStatusSN As Object
        Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer
        Dim vDarkhastHaSN, vMojavezErsalHaSN As Object
        Dim vMandeDarkhast As Decimal 'yekta 920228
        Dim vBatchNO As String 'yekta 920814
        Dim vTozih As String 'yekta 920814
        Dim vNoeEngheza As String 'dehghani 981102


        If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh Or
          aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint Or
          aCommand = EnumCommands.cmFilter) Then
            If Val(DVabSanadHa.Fields("KalaSN").Value) <> 0 Then
                ' با توجه به کالا اطلاعات جانبي نمايش داده شود 
                vKalaSN = Val(DVabSanadHa.Fields("KalaSN").Value)
                vResult = cn.CallSP("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value,
                   System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo,
                   VinVahedeSanjeshDs, VinTedadAjza)
            End If
        End If





        If (aCommand = EnumCommands.cmAdd) Then
            With DVabSanad
                If Val(.Fields("NoeSanadID").Value) <> 0 AndAlso Val(.Fields("NoeSanadID").Value) = 2 Then
                    aCancel = True
                    vErrMsg = "سند انبار از نوع ماشيني را نمي توان تغيير داد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
                '910309
                If Val(.Fields("Tarakoneshsn").Value) = 45 Or Val(.Fields("Tarakoneshsn").Value) = 95 Or Val(.Fields("Tarakoneshsn").Value) = 111 Then
                    aCancel = True
                    vErrMsg = "اقلام سند اصلاحی می بایست در سند مرجع وجود داشته باشند" + vbCrLf + "لذا اقلام سند اصلاحی بصورت اتوماتیک از سند مرجع ثبت می شوند"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
                If ChkIsFakorEbtal.Checked Then
                    aCancel = True
                    vErrMsg = "سند فاکتور ابطالی را نمي توان تغيير داد" + vbNewLine + "در صورت تمایل به ویرایش یا حذف اقلام سند فاکتور ابطالی ، سند می بایست به صورت کلی حذف گردد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
            End With
        End If

        If (aCommand = EnumCommands.cmEdit Or aCommand = EnumCommands.cmDelete) Then
            With DVabSanad
                If aCommand = EnumCommands.cmDelete And Val(DVabSanad.Fields("TarakoneshSN").Value) = 46 Then
                    aCancel = True
                    vErrMsg = "حذف ردیف از رسید اضافی جابجایی کالا امکان پذیر نمی باشد "
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
                If Val(DVabSanad.Fields("TarakoneshSN").Value <> 46) And Val(DVabSanad.Fields("DarkhastSN").Value) = 0 And Val(DVabSanad.Fields("NoeSanadID").Value) = 2 AndAlso (Val(.Fields("BarcodeReaderSanad").Value) = 0 Or (Val(.Fields("BarcodeReaderSanad").Value) = 1 AndAlso aCommand = EnumCommands.cmEdit)) Then
                    'If Val(DVabSanad.Fields("DarkhastSN").Value) = 0 And Val(DVabSanad.Fields("NoeSanadID").Value) = 2 AndAlso (Val(.Fields("BarcodeReaderSanad").Value) = 0 Or (Val(.Fields("BarcodeReaderSanad").Value) = 1 AndAlso aCommand = EnumCommands.cmEdit)) Then
                    aCancel = True
                    vErrMsg = "سند انبار از نوع ماشيني را نمي توان تغيير داد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
                If ChkIsFakorEbtal.Checked Then
                    aCancel = True
                    vErrMsg = "سند فاکتور ابطالی را نمي توان تغيير داد" + vbNewLine + "در صورت تمایل به ویرایش یا حذف اقلام سند فاکتور ابطالی ، سند می بایست به صورت کلی حذف گردد"
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If
            End With
        End If

        '--------------------------- yekta 920814 -------------------------
        If (aCommand = EnumCommands.cmEdit) Then
            DVabSanadHa.Fields("BatchNO").ReadOnly = True
            DVabSanadHa.Fields("Tozih").ReadOnly = True
            DVabSanadHa.Fields("NoeEngheza").ReadOnly = True
        Else
            DVabSanadHa.Fields("BatchNO").ReadOnly = False
            DVabSanadHa.Fields("Tozih").ReadOnly = False
            DVabSanadHa.Fields("NoeEngheza").ReadOnly = False

        End If
        '--------------------------- yekta 920814 -------------------------
        'With DVabSanad
        'kouhdar 14030513
        If aCommand = EnumCommands.cmEdit And Val(DVabSanad.Fields("TarakoneshSN").Value = 46) Then
            For Each item As CField In DVabSanadHa.Fields
                If item.FieldName = "KalaDS" Then
                    Continue For
                Else
                    item.ReadOnly = True
                End If
            Next
        End If
        'End With





        If aCommand = EnumCommands.cmSave Then

            ' با توجه به کالا در صورتيکه کالا فاقد واحد سنجش يا تعداد در کارتن است رديف سند ثبت نمي گردد
            If (gNoeAnbarSN = 2 Or gNoeAnbarSN = 5 Or gNoeAnbarSN = 10) And Val(VinTedadAjza) = 0 Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox("تعداد در كارتن مشخص نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            ElseIf Val(VinVahedeSanjeshSN) = 0 Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox("واحد سنجش كالا مشخص نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If


            '//
            With DVabSanadHa

                If .FieldValue("KalaPhizikiStatusSN") = "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("براي کالاي انتخابي در اين انبار رويه رهگيري مشخص نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                'If Trim(.Fields("ShomarehRahgiriText").Text) = "0" Then
                '    aCancel = True
                '    Netsql.common.csystem.MsgBox("شماره رهگيري انتخابي نامعتبر است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                '    Exit Sub
                'End If

                If .FieldValue("ToolidDateFlag") = "1" AndAlso .FieldValue("ToolidDate") = "" AndAlso Not .FlexGrid.ColHidden(.FlexGrid.ColIndex("ToolidDate_Text")) Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("تاريخ توليد مشخص نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If .FieldValue("ToolidDate") <> "" AndAlso .FieldValue("ToolidDate") < "13800101" AndAlso Not IsDate(.FieldText("ToolidDate")) Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("تاريخ توليد معتبر نمي باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If .FieldValue("EnghezaDateFlag") = "1" AndAlso .FieldValue("EnghezaDate") = "" AndAlso Not .FlexGrid.ColHidden(.FlexGrid.ColIndex("EnghezaDate_Text")) Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("تاريخ انقضا مشخص نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If .FieldValue("EnghezaDate") <> "" AndAlso .FieldValue("EnghezaDate") < "13800101" AndAlso Not IsDate(.FieldText("EnghezaDate")) Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("تاريخ انقضا معتبر نمي باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If .FieldValue("ToolidDate") > "20000101" AndAlso .FieldValue("ToolidDate") <> "" Then
                    .FieldValue("ToolidDate") = CShamsiDate.MiladiToShamsi(Date.Parse(.FieldText("ToolidDate")), EnumDateFormat.dfFullYear)
                End If

                If .FieldValue("EnghezaDate") > "20000101" AndAlso .FieldValue("EnghezaDate") <> "" Then
                    .FieldValue("EnghezaDate") = CShamsiDate.MiladiToShamsi(Date.Parse(.FieldText("EnghezaDate")), EnumDateFormat.dfFullYear)
                End If

                'ToDo : Romove For More Run SPeed
                If QuickActionOnAbSanadHa Then
                    If Val(.FieldValue("DarkhastHaSN")) <= 0 AndAlso DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("abvw_darkhast_DarkhastHaSN")) = False AndAlso Val(DVabSanad.FieldValue("DarkhastSN")) > 0 Then
                        aCancel = True
                        NetSql.Common.CSystem.MsgBox("شماره درخواست انبار انتخاب نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                        Exit Sub
                    End If
                End If


                '-------------yekta 920814 -------------------------------- comment yekta 920826
                'If .Fields("BatchNo").Text = "" AndAlso DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("abKalaPhizikiControl_BatchNO")) = False Then
                'aCancel = True
                'Netsql.common.csystem.MsgBox("شماره بچ وارد نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                'Exit Sub
                'End If
                'If .Fields("Tozih").Text = "" AndAlso DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("abKalaPhizikiControl_Tozih")) = False Then
                'aCancel = True
                'Netsql.common.csystem.MsgBox("توضیحات کالا وارد نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                'Exit Sub
                'End If
                '-------------yekta 920814 -------------------------------- comment yekta 920826


                'If Val(.FieldValue("MojavezErsalHaSN")) <= 0 AndAlso DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("tdDarkhastKala_MojavezErsalHaSN")) = False Then
                '    aCancel = True
                '    Netsql.common.csystem.MsgBox("شماره درخواست خريد انتخاب نشده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                '    Exit Sub
                'End If

            End With
            '//

        End If

        'If Val(DVabSanadHa.FieldValue("Meghdar")) <> 0 And aCommand = EnumCommands.cmAdd Then
        '    ' با توجه به رويه رهگيري کالا شماره رهگيري کالا مقدار دهي ميگردد
        '    With DVabSanadHa
        '        .Fields("ShomarehRahgiriText").Component.Text = DVabSanadHa.FieldValue("Meghdar")
        '        .FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText") + 1) = DVabSanadHa.FieldValue("Meghdar")
        '    End With

        'End If



        If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh _
           Or aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint _
              Or aCommand = EnumCommands.cmFilter) Then
            aCancel = True
            vVahedeTejariSN = gVahedeTejariSN
            vAnbarSN = gAnbarSN
            With DVabSanad
                vNoeAnbarSN = IIf(Val(.Fields("NoeAnbarSN").Value) = 0, System.DBNull.Value, .Fields("NoeAnbarSN").Value)
                vSanadSN = IIf(Val(.Fields("SanadSN").Value) = 0, System.DBNull.Value, .Fields("SanadSN").Value)
                vSanadDate = IIf(Trim(.Fields("SanadDate").Value) = "", "", .Fields("SanadDate").Value)
                vSanadStatus = IIf(Val(.Fields("SanadStatus").Value) = 0, System.DBNull.Value, .Fields("SanadStatus").Value)
                vSanadStatusMali = IIf(Val(.Fields("SanadStatusMali").Value) = 0, System.DBNull.Value, .Fields("SanadStatusMali").Value)
                vTarakoneshSN = IIf(Val(.Fields("TarakoneshSN").Value) = 0, System.DBNull.Value, .Fields("TarakoneshSN").Value)
                vTarafHesabSN = IIf(Val(.Fields("TafsiliSN").Value) = 0, System.DBNull.Value, .Fields("TafsiliSN").Value)
                vEDAnbarSN = IIf(Val(.Fields("EDAnbarSN").Value) = 0, System.DBNull.Value, .Fields("EDAnbarSN").Value)
                vEDNoeAnbarSN = IIf(Val(.Fields("EDNoeAnbarSN").Value) = 0, System.DBNull.Value, .Fields("EDNoeAnbarSN").Value)
                vTafsiliSN2 = IIf(Val(.Fields("TafsiliSN2").Value) = 0, System.DBNull.Value, .Fields("TafsiliSN2").Value)
            End With

            With DVabSanadHa
                vSanadHaSN = IIf(Val(.Fields("SanadHaSN").Value) = 0, System.DBNull.Value, .Fields("SanadHaSN").Value)
                vKalaSN = IIf(Val(.Fields("KalaSN").Value) = 0, System.DBNull.Value, .Fields("KalaSN").Value)
                vKalaPhizikiStatusSN = IIf(Val(DVabSanadHa.Fields("KalaPhizikiStatusSN").Value) = 0, System.DBNull.Value, DVabSanadHa.Fields("KalaPhizikiStatusSN").Value)
                If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                    If mTarakoneshSN < 50 Then
                        .Fields("MeghdareVaredeh").Value = Val(.Fields("Box_in").Value) * Val(VinTedadAjza) + Val(.Fields("Can_in").Value)
                    Else
                        .Fields("MeghdareSadereh").Value = Val(.Fields("Box_out").Value) * Val(VinTedadAjza) + Val(.Fields("Can_out").Value)
                    End If
                    VMeghdareVaredeh = IIf(Val(.Fields("MeghdareVaredeh").Value) = 0, 0, .Fields("MeghdareVaredeh").Value)
                    VMeghdareSadereh = IIf(Val(.Fields("MeghdareSadereh").Value) = 0, 0, .Fields("MeghdareSadereh").Value)
                End If
                VMeghdareVaredeh = IIf(Val(.Fields("MeghdareVaredeh").Value) = 0, 0, .Fields("MeghdareVaredeh").Value)
                VMeghdareSadereh = IIf(Val(.Fields("MeghdareSadereh").Value) = 0, 0, .Fields("MeghdareSadereh").Value)
                VNoeZayeatSN = IIf(Val(.Fields("NoeZayeatSN").Value) = 0, System.DBNull.Value, .Fields("NoeZayeatSN").Value)
                VNoeMarjooeiSN = IIf(Val(.Fields("NoeMarjooeiSN").Value) = 0, System.DBNull.Value, .Fields("NoeMarjooeiSN").Value)
                VNoeMadomiSN = IIf(Val(.Fields("NoeMadomiSN").Value) = 0, System.DBNull.Value, .Fields("NoeMadomiSN").Value)
                'vDarkhastHaSN = IIf(Val(.Fields("DarkhastHaSN").Value) = 0, System.DBNull.Value, .Fields("DarkhastHaSN").Value)
                'vMojavezErsalHaSN = IIf(Val(.Fields("MojavezErsalHaSN").Value) = 0, System.DBNull.Value, .Fields("MojavezErsalHaSN").Value)

                If QuickActionOnAbSanadHa Then
                    'ToDo : Romove For More Run SPeed
                    vDarkhastHaSN = IIf(Val(.Fields("DarkhastHaSN").Value) = 0, System.DBNull.Value, .Fields("DarkhastHaSN").Value)
                    'ToDo : Romove For More Run SPeed
                    vMojavezErsalHaSN = IIf(Val(.Fields("MojavezErsalHaSN").Value) = 0, System.DBNull.Value, .Fields("MojavezErsalHaSN").Value)
                End If

                vKalaPhizikiSN = IIf(Val(.Fields("ShomarehRahgiriText").Value) = 0, System.DBNull.Value, Val(.Fields("ShomarehRahgiriText").Value))
                vBatchNO = IIf(.Fields("BatchNo").Text = "", "NULL", .Fields("BatchNo").Text) ' yekta 920814
                vTozih = IIf(.Fields("Tozih").Text = "", "", .Fields("Tozih").Text) ' yekta 920814

                vShomarehRahgiri = IIf(
                 Len(LTrim(RTrim(.FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText") + 1)))) = 0,
                 "1",
                 .FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText") + 1)) ' 850705
                'vShomarehRahgiri = IIf( _
                '          Val(.FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText") + 1) = 0), _
                '          "1", _
                '          .FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText") + 1)) ' 850705
                'vShomarehRahgiri = IIf(Len(.FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText")) = 0), "1", .FlexGrid.TextMatrix(.FlexGrid.Row, .FlexGrid.ColIndex("ShomarehRahgiriText")))
                vState = DVabSanadHa.State
            End With
            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
            vResult = cn.CallSP("_abSPC_abSanadHaEnter", gVahedeTejariSN, gAnbarSN, vNoeAnbarSN, vSanadSN,
                vSanadDate, vSanadStatus, vSanadStatusMali, vTarakoneshSN, vTarafHesabSN _
                , vEDAnbarSN, vEDNoeAnbarSN, aCommand, vState, vErrMsg, vKalaSN _
                , VMeghdareVaredeh, VMeghdareSadereh, VNoeZayeatSN, VNoeMarjooeiSN _
                , VNoeMadomiSN, vKalaPhizikiSN, vShomarehRahgiri, vSanadHaSN, vKalaPhizikiStatusSN, System.DBNull.Value, vTafsiliSN2, vDarkhastHaSN, vMojavezErsalHaSN)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                If vResult = 1 Then
                    aCancel = True
                    Exit Sub
                Else
                    aCancel = False
                End If
            Else
                aCancel = False
            End If
        End If

        Dim VKalaDSComboWhereCondition As String
        ' ساختن شرط براي کامبو کالا
        'kouhdar 14030513
        If aCommand = EnumCommands.cmEdit And Val(DVabSanad.Fields("TarakoneshSN").Value) = 46 Then
            VKalaDSComboWhereCondition = "paKala.KalaSN IN (Select KalaSN From abVw_pakalaCode Where SubKalaSN =" & CStr(DVabSanadHa.Fields("KalaSN").Value) & " Union Select " & CStr(DVabSanadHa.Fields("KalaSN").Value) & ")"

            With DVabSanadHa
                .Fields("KalaDS").ReadOnly = False
                .Fields("KalaDS").ComboWhereCondition = VKalaDSComboWhereCondition
                .Fields("KalaDS").RefreshCombo()
            End With
        Else
            VKalaDSComboWhereCondition = " AND paKala.KalaSN  IN (SELECT KalaSN " &
                " FROM abAnbarKala WHERE AnbarKalaStatus = 1 AND AnbarSN = " &
                 gAnbarSN & " AND NoeAnbarSN = " & CStr(DVabSanad.Fields("NoeAnbarSN").Value) & ")"
            If Val(DVabSanad.Fields("DarkhastSN").Value) <> 0 Then
                VKalaDSComboWhereCondition += " AND paKala.KalaSN  IN (SELECT KalaSN " &
                                " FROM abDarkhastKala WHERE DarkhastSn =" & CDec(DVabSanad.Fields("DarkhastSN").Value) & ")"
            End If
        End If




        '------------------------------ By yekta 911027 -----------------------------------
        'If ((Val(DVabSanad.Fields("TarakoneshSN").Value) = EnumTarakoneshSN.RESIDE_01_KHARIDE_DAKHELI) Or (Val(DVabSanad.Fields("TarakoneshSN").Value) = EnumTarakoneshSN.RESIDE_11_HAMLE_MOSTAGHIM) Or (Val(DVabSanad.Fields("TarakoneshSN").Value) = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI) Or (Val(DVabSanad.Fields("TarakoneshSN").Value) = EnumTarakoneshSN.HAVALEH_111_KahandehKharid)) Then
        'If IsTarakoneshInGorooh(Val(DVabSanad.Fields("TarakoneshSN").Value), 42) Then
        '    VKalaDSComboWhereCondition += "AND paKala.KalaSN  IN (select kalasn from pakalatamin where vahedetejarisn=(select vahedetejarisn from paVahedeTejari where payesn=" & CDec(DVabSanad.Fields("TafsiliSN").Value) & "))"
        'End If
        '------------------------------ By yekta 911027 -----------------------------------
        Select Case aCommand
            Case EnumCommands.cmSave
                ' کنترل هاي عادي براي ثبت رکورد
                Select Case NoeTarakoneshSN
                    Case EnumNoeTarakoneshSN.ntHAVALEHHA, EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI, EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                        If Trim(DVabSanadHa.Fields("ShomarehRahgiriText").Component.Text) = "" Then
                            aCancel = True
                            NetSql.Common.CSystem.MsgBox("شماره رهگيري را پر نماييد")
                        End If
                End Select
                If Not aCancel And (DVabSanadHa.State = 1) Then
                    vKalaPhizikiSN = Val(DVabSanadHa.Fields("ShomarehRahgiriText").Value)
                    If vKalaPhizikiSN = 0 Then vKalaPhizikiSN = gSM.Identifier
                    vShomarehRahgiri = DVabSanadHa.Fields("ShomarehRahgiriText").Component.Text
                    If IsNumeric(DVabSanadHa.FieldText("KalaPhizikiStatusSN")) AndAlso IsNumeric(DVabSanadHa.FieldText("Meghdar")) AndAlso Trim(vShomarehRahgiri) = "" Then
                        vShomarehRahgiri = IIf(DVabSanadHa.FieldText("KalaPhizikiStatusSN") = 1, DVabSanadHa.FieldText("Meghdar"), vShomarehRahgiri)
                    End If
                    vShomarehRahgiri = IIf(Trim(vShomarehRahgiri) = "", 0, vShomarehRahgiri)
                    vNoeAsnadSN = Val(DVabSanad.Fields("NoeAnbarSN").Value)
                    DVabSanadHa.InsertSPUserParam = vKalaPhizikiSN & ";" & vShomarehRahgiri & ";" &
                           CStr(IIf(Val(DVabSanadHa.Fields("KalaPhizikiStatusSN").Value) = 0,
                           1, Val(DVabSanadHa.Fields("KalaPhizikiStatusSN").Value))) &
                         ";" & CStr(gVahedeTejariSN) & ";" & CStr(gAnbarSN) & ";" & CStr(vNoeAsnadSN) & ";" & vBatchNO & ";" & vTozih
                End If
                ' ‌در مورد نوع ورود اطلاعات تعداد در کارتن پردازش زير براي پر کردن مقادير وارده و صادره بايد انجام گردد
                If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                    If mTarakoneshSN < 50 Then
                        DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(VinTedadAjza) + Val(DVabSanadHa.Fields("Can_in").Value)
                    Else
                        DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(VinTedadAjza) + Val(DVabSanadHa.Fields("Can_out").Value)
                    End If
                End If
                If DVabSanadHa.State <> EnumDataViewState.bsAdd Then
                    vcmAdd = False
                End If
            Case EnumCommands.cmAdd
                ' فيلتر شدن کالاها براي ثبت رديف سند انبار
                With DVabSanadHa
                    .Fields("KalaDS").ComboWhereCondition = pdbcKalaDSComboWhereCondition & VKalaDSComboWhereCondition
                    .Fields("KalaDS").RefreshCombo()
                    .Fields("KalaDS").ReadOnly = False
                End With


                vcmAdd = True

            Case EnumCommands.cmEdit
                ' به علت ارتباط رديف سند با کالافيزيکي دسترسي اصلاح کالا گرفته ميشود
                'kouhdar 14030513
                With DVabSanadHa
                    If Val(DVabSanad.Fields("TarakoneshSN").Value) = 46 Then
                        .Fields("KalaDS").ReadOnly = False
                        .Fields("MeghdareVaredeh").ReadOnly = True
                    Else

                        .Fields("KalaDS").ReadOnly = True
                        .Fields("ShomarehRahgiriText").ReadOnly = True
                    End If



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

                vcmAdd = False
            Case EnumCommands.cmAbort
                vcmAdd = False
            Case EnumCommands.cmDelete
                vcmAdd = False
        End Select
    End Sub

    Private Sub DVabSanadHa_GetGridProperties() _
        Handles DVabSanadHa.GetGridProperties
        '  فعال سازي کنترل نمايش ستونها
        Call EnableFields()
        ' فعال شدن امکان انتخاب گروهي
        With DVabSanadHa.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With

        '910309
        ' روشن کردن امکان بروزآوري نوع مرجوعي
        If TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Or
           TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH Or
           TarakoneshSN = EnumTarakoneshSN.RESIDE_28_MARJOOEI_AZ_FOROOSH_TOLIDI Or
           (TarakoneshSN = EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH _
           Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH _
           Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_111_KahandehKharid) _
           And (DVabSanad.Fields("MarjaTarakoneshSN").Value = "39" Or DVabSanad.Fields("MarjaTarakoneshSN").Value = "38") Then
            pnlNoeMarjooei.Visible = True
        Else
            pnlNoeMarjooei.Visible = False
        End If

    End Sub

    Private Sub DVabSanadHaDarkhast_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSanadHaDarkhast.CommandClick

        If aCommand = EnumCommands.cmSave Then

        End If
    End Sub

    Private Sub DVabBarnameh_AfterCommandClick(aCommand As NetSql.View.CEnum.EnumCommands) Handles DVabBarnameh.AfterCommandClick
        If aCommand = EnumCommands.cmDelete Then
            If DVabBarnameh.DeleteYesNo = MsgBoxResult.Yes Then
                cn.ExecuteQuery("_abBarnameh_DeleteX " & DVabBarnameh.Fields("BarnamehSN").Value & "," & DVabSanad.Fields("SanadSN").Value)
                DVabBarnameh.Refresh()
            End If
        End If
    End Sub

    Private Sub DVabBarnameh_AfterSPExecute(aSPKind As NetSql.DB.CConnection.EnumSPKind, aCommand As Object) Handles DVabBarnameh.AfterSPExecute
        Dim BarnamehSN As Decimal = 0
        BarnamehSN = DirectCast(aCommand, System.Data.SqlClient.SqlCommand).Parameters("@BarnamehSN").Value
        If aSPKind = EnumSPKind.spInsert AndAlso BarnamehSN > 1 Then
            Try
                Dim i As Integer
                With DVabSanad.FlexGrid
                    For i = 0 To .SelectedRows - 1
                        If ExistBarnameh(.ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN"))) Then
                            NetSql.Common.CSystem.MsgBox("قبلا بارنامه برای این سند ثبت شده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                            cn.ExecuteQuery("abBarnameh_Delete " & BarnamehSN)
                            DVabBarnameh.Refresh()
                            Exit Sub
                        End If
                        Dim StrMsg As String = controlBarnameh(BarnamehSN, CDec(.ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN"))))
                        If StrMsg <> "" Then
                            NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "خطا")
                            cn.ExecuteQuery("abBarnameh_Delete " & BarnamehSN)
                            DVabBarnameh.Refresh()
                            StrMsg = ""
                            Exit Sub
                        End If
                        cn.ExecuteQuery("abBarnamehHa_Insert " & gSM.Identifier & "," & BarnamehSN & "," & .ValueMatrix(.SelectedRow(i), .ColIndex("SanadSN")) & ",0,0,'" & gSM.UserID_Name & "','" & System.Environment.MachineName & "',NULL,'" & Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal) & "'")
                    Next
                End With
                'cn.ExecuteQuery("abBarnamehHa_Insert " & gSM.Identifier & "," & BarnamehSN & "," & DVabSanad.FieldValue("SanadSN") & ",0,0,'" & gSM.UserID_Name & "','" & System.Environment.MachineName & "',NULL,'" & Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal) & "'")
                DVabBarnameh.Refresh()
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("خطا در ثبت بارنامه رخ داده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                cn.ExecuteQuery("abBarnameh_Delete " & BarnamehSN)
                DVabBarnameh.Refresh()
            End Try
        End If
    End Sub



    Private Sub DVabBarnameh_CommandClick(aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles DVabBarnameh.CommandClick

        If aCommand = EnumCommands.cmSave Then

            Dim gBarnameh_PasKerayeh As Decimal = 4.101
            If Val(DVabBarnameh.FieldValue("NoeBarnamehDS")) = gBarnameh_PasKerayeh Then
                Dim StrMsg As String = "پس کرایه، قبض انبار ندارد"
                aCancel = True
                NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                Exit Sub
            End If

            If Val(DVabBarnameh.FieldValue("NoeKhodrooDs")) = 0 Then
                Dim StrMsg As String = "نوع خودرو را مشخص نمایید"
                aCancel = True
                NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                Exit Sub
            End If

            Dim i As Integer
            With DVabSanad.FlexGrid
                For i = 0 To .SelectedRows - 1

                    'کنترل اینکه تراکنش های غیر مجاز امکان ثبت بارنامه نداشته باشند
                    'If Not CheckTarakoneshBarnameh(Val(DVabSanad.Fields("TarakoneshSN").Value)) Then
                    If Not CheckTarakoneshBarnameh(.ValueMatrix(.SelectedRow(i), .ColIndex("TarakoneshSN"))) Then
                        aCancel = True
                        NetSql.Common.CSystem.MsgBox("ثبت بارنامه برای تراکنش انتخاب شده مجاز نیست", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                        Exit Sub
                    End If

                    ''کنترل اینکه برای تراکنش، قبل از ثبت بارنامه باید سند قطعی شده باشد
                    '            If CheckTarakoneshErsaleBarnamehBeMaghsad(Val(DVabSanad.Fields("TarakoneshSN").Value)) _
                    'And Val(DVabSanad.Fields("SanadStatus").Value) <> 8 Then
                    If CheckTarakoneshErsaleBarnamehBeMaghsad(.ValueMatrix(.SelectedRow(i), .ColIndex("TarakoneshSN"))) _
                            And .ValueMatrix(.SelectedRow(i), .ColIndex("SanadStatus")) <> 8 Then
                        aCancel = True
                        NetSql.Common.CSystem.MsgBox("برای این تراکنش، قبل از ثبت بارنامه باید سند قطعی شده باشد")
                        Exit Sub
                    End If

                Next
            End With

            If Val(DVabBarnameh.FieldValue("GheymateBarnameh")) <= Val(DVabBarnameh.FieldValue("Kasri")) Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox("کسری بارنامه باید کمتر از مبلغ بارنامه باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                Exit Sub
            End If

            'cn.CallSP("_abBarnameh_InsertX", gSM.Identifier, DVabBarnameh.Fields("BarnamehNo").Value, DVabBarnameh.Fields("BarnamehDS").Value, _
            '          DVabBarnameh.Fields("BarnamehDate").Value, gAnbarSN, gVahedeTejariSN, DVabBarnameh.Fields("ShomarehMashin").Value, _
            '          DVabBarnameh.Fields("NameRanandeh").Value, DVabBarnameh.Fields("SabtDate").Value, 0, DBNull.Value, DBNull.Value, _
            '          DVabBarnameh.Fields("SanadMaliDate").Value, DBNull.Value, DVabBarnameh.Fields("GheymateBarnameh").Value, 0, _
            '          gSM.UserID_Name, System.Environment.MachineName, DBNull.Value, DBNull.Value, IIf(DVabBarnameh.Fields("BarbariDS").Value <> "", DVabBarnameh.Fields("BarbariDS").Value, DBNull.Value), _
            '          DVabBarnameh.Fields("ArzesheBimeh").Value, DVabSanad.Fields("SanadSN").Value)
            'DVabBarnameh.FetchCurRecord()

            ''ghasemi14010922

            Dim gControlCharBarnamehDS As Boolean = If(CApp.GetAppConfig("gControlCharBarnamehDS") Is System.DBNull.Value, False, True)
            If gControlCharBarnamehDS Then

                If (Len(DVabBarnameh.FieldValue("BarnamehDS")) <> 26) Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("تعداد کاراکتر شرح بارنامه باید 26 کاراکتر باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                    Exit Sub
                End If

            End If
            ''ghasemi14010922

        End If

        If aCommand = EnumCommands.cmAdd Then
            'کنترل اینکه به ازای هر سند انبار فقط یک سطر بارنامه ثبت شود
            If ExistBarnameh(Val(DVabSanad.Fields("SanadSN").Value)) Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox("قبلا بارنامه برای این سند ثبت شده است", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "توجه")
                Exit Sub
            End If

        End If

        'If aCommand = EnumCommands.cmDelete Then
        '    If CheckTarakoneshBarnamehGhablAzGhatiSanadAnbar(Val(DVabSanad.Fields("TarakoneshSN").Value)) _
        '            And DVabSanad.Fields("SanadStatusDS").Value = 8 Then
        '        aCancel = True
        '        Netsql.common.csystem.MsgBox("بارنامه این تراکنش برای قبض انبار قطعی شده غیر قابل حذف است")
        '        Exit Sub
        '    End If

        'End If

    End Sub

    Private Sub DVabBarnameh_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVabBarnameh.FillDetailsWithData
        If aFetched Then
            DVabBarnameh.CommandEnabled(EnumCommands.cmDelete) = Val(DVabBarnameh.Fields("BarnamehStatus").Value) = 0 And Val(DVabBarnameh.Fields("ErsalBeDP").Value) = 0
            DVabBarnameh.CommandEnabled(EnumCommands.cmEdit) = Val(DVabBarnameh.Fields("BarnamehStatus").Value) = 0 And Val(DVabBarnameh.Fields("ErsalBeDP").Value) = 0
            btnErsalBeDP.Enabled = Val(DVabBarnameh.Fields("ErsalBeDP").Value) = 0
        Else
            DVabBarnameh.CommandEnabled(EnumCommands.cmAdd) = DVabBarnameh.DataSource.Count <> 1
            'btnListBarnameh.Enabled = DVabBarnameh.DataSource.Count <> 1
        End If

    End Sub

    '--------------- add by yekta 940319 ----------
    Private Sub DVabSanadHaChideman_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSanadHaChideman.CommandClick

        If aCommand = EnumCommands.cmSave Then
            If Not IsNumeric(DVabSanadHaChideman.Fields("KalaPhizikiSN").Value) Then
                DVabSanadHaChideman.Fields("KalaPhizikiSN").Value = DVabSanadHa.Fields("ShomarehRahgiriText").Value
            End If

        End If
    End Sub
    '--------------- add by yekta 940319 ----------
#End Region

#Region "Utilities"

    Private Sub MakeFilter(ByRef aMinDate As String, ByRef aMaxDate As String)
        ' با توجه به فيلتر فرم شرط ديتا ويو بروز رساني ميگردد
        With DVabSanad
            '          " AND  abTarakonesh.TarakoneshStatus = 1  " & _ 850122

            'If (NoeAccessRight = "mnuResidDarAnbarQC") Then
            '    .SQLWhere = " abSanad.AnbarSN = " & QCPairAnbarSN & _
            '" AND abSanad.SanadDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate & _
            '"' AND  abSanad.SanadDate >= '" & aMinDate & "'" & _
            '" AND ( ( CONVERT(VARCHAR(18),abAnbar.AnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abNoeAnbar.NoeAnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abTarakonesh.TarakoneshSN)  " & _
            '" + CONVERT(VARCHAR(18),paVahedeTejari.VahedeTejariSN))  IN " & _
            '"       ( SELECT CONVERT(VARCHAR(18),abAnbarTarakonesh.AnbarSN) + " & _
            '" CONVERT(VARCHAR(18),abAnbarTarakonesh.NoeAnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abAnbarTarakonesh.TarakoneshSN)  " & _
            '" + CONVERT(VARCHAR(18),abAnbarTarakonesh.VahedeTejariSN) " & _
            '"  FROM abAnbarTarakonesh " & _
            '" WHERE abAnbarTarakonesh.AnbarSN = " & CStr(QCPairAnbarSN) & _
            '" ))"
            'Else
            '    .SQLWhere = " abSanad.AnbarSN = " & gAnbarSN & _
            '" AND abSanad.SanadDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate & _
            '"' AND  abSanad.SanadDate >= '" & aMinDate & "'" & _
            '" AND ( ( CONVERT(VARCHAR(18),abAnbar.AnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abNoeAnbar.NoeAnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abTarakonesh.TarakoneshSN)  " & _
            '" + CONVERT(VARCHAR(18),paVahedeTejari.VahedeTejariSN))  IN " & _
            '"       ( SELECT CONVERT(VARCHAR(18),abAnbarTarakonesh.AnbarSN) + " & _
            '" CONVERT(VARCHAR(18),abAnbarTarakonesh.NoeAnbarSN) " & _
            '" + CONVERT(VARCHAR(18),abAnbarTarakonesh.TarakoneshSN)  " & _
            '" + CONVERT(VARCHAR(18),abAnbarTarakonesh.VahedeTejariSN) " & _
            '"  FROM abAnbarTarakonesh " & _
            '" WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) & _
            '" ))"
            'End If


            .SQLWhere = " abSanad.AnbarSN = " & gAnbarSN &
             " AND abSanad.SanadDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate &
             "' AND  abSanad.SanadDate >= '" & aMinDate & "'" &
             " AND ( ( CONVERT(VARCHAR(18),abAnbar.AnbarSN) " &
             " + CONVERT(VARCHAR(18),abNoeAnbar.NoeAnbarSN) " &
             " + CONVERT(VARCHAR(18),abTarakonesh.TarakoneshSN)  " &
             " + CONVERT(VARCHAR(18),paVahedeTejari.VahedeTejariSN))  IN " &
             "       ( SELECT CONVERT(VARCHAR(18),abAnbarTarakonesh.AnbarSN) + " &
             " CONVERT(VARCHAR(18),abAnbarTarakonesh.NoeAnbarSN) " &
             " + CONVERT(VARCHAR(18),abAnbarTarakonesh.TarakoneshSN)  " &
             " + CONVERT(VARCHAR(18),abAnbarTarakonesh.VahedeTejariSN) " &
             "  FROM abAnbarTarakonesh " &
             " WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) &
             " ))"
            '                        " AND abAnbarTarakonesh.AnbarTarakoneshStatus = 1 ))" 850122

            Select Case NoeTarakoneshSN
                Case EnumNoeTarakoneshSN.ntRESIDHA
                    .SQLWhere = .SQLWhere & " AND abTarakonesh.TarakoneshSN BETWEEN 0 AND 49   AND " & " abTarakonesh.TarakoneshSN  NOT IN ( " & CStr(EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH) & "," &
                       CStr(EnumTarakoneshSN.MOJOODIE_20_AVALE_DOREH_Paikar) & "," &
                       CStr(EnumTarakoneshSN.EZAFI_MOJOODI_ANBAR_RESID) & "," &
                       CStr(EnumTarakoneshSN.RESIDE_46_Kazeb) & "," &
                       CStr(EnumTarakoneshSN.RESIDE_06_EzafehDryaft) & "," &
                       CStr(EnumTarakoneshSN.RESIDE_07_KasriErsal) & "," &
                        CStr(EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH) & "," & CStr(EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) & " ) "

                    '910309
                Case EnumNoeTarakoneshSN.ntHAVALEHHA
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN >= 51  AND " &
                       " abTarakonesh.TarakoneshSN  NOT IN ( " &
                        CStr(EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE) & "," &
                        CStr(EnumTarakoneshSN.HAVALEH_93_HavalehKazeb) & "," &
                        CStr(EnumTarakoneshSN.HAVALEH_116_EzafehErsal) & "," &
                        CStr(EnumTarakoneshSN.HAVALEH_117_KasriDryaft) & "," &
                        CStr(EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH) & "," &
                        CStr(EnumTarakoneshSN.HAVALEH_111_KahandehKharid) & " ) "
                Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH) & " ," & CStr(EnumTarakoneshSN.MOJOODIE_20_AVALE_DOREH_Paikar) & ") "
                Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) & " ) "
                Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.EZAFI_MOJOODI_ANBAR_RESID) & ",  " & CStr(EnumTarakoneshSN.RESIDE_46_Kazeb) & " ) "
                Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE) & ",  " & CStr(EnumTarakoneshSN.HAVALEH_93_HavalehKazeb) & ") "
                Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH) & " ) "
                Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_06_EzafehDryaft) & " ) "
                Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_07_KasriErsal) & " ) "
                Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH) & " ) "

                    '910309
                Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_111_KahandehKharid) & " ) "

                Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_116_EzafehErsal) & " ) "
                Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_117_KasriDryaft) & " ) "
                Case Else
                    .SQLWhere = .SQLWhere & " AND  abTarakonesh.TarakoneshSN = " & mTarakoneshSN
            End Select
            If SanadSN <> 0 Then
                .SQLWhere = .SQLWhere & " AND  abSanad.SanadSN = " & SanadSN
            End If
        End With
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vMinDateSetting, vMaxDateSetting As String
        Dim vMaxDate, vMinDate As String
        Dim vSysDate As String
        Dim Param(3) As String

        ' تهيه تاريخ از سرور
        vSysDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
            cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        vMaxDate = gHesabdariSalTDate

        Dim Mah As Integer = CInt(vSysDate.Substring(4, 2))
        Dim ThisMah As String = If(Mah < 10, "0", "") + If(Mah = 1, "1", Mah.ToString)

        vMinDate = gHesabdariSal.ToString + ThisMah + "01"

        'vMinDate = VB.Left(vSysDate, 6) + "01"
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabSanad" & NoeTarakoneshSN, vMinDate)

        If vMinDateSetting < vMinDate Then
            vMinDateSetting = vMinDate
        End If

        MinFilterDateCtrl.Value = vMinDateSetting


        If MinFilterDateCtrl.IsValid Then
            vMinDate = vMinDateSetting
        End If

        Dim NamayeshAshar As Boolean = If(CApp.GetAppConfig("gNamayeshAshar") Is System.DBNull.Value, False, True)
        Dim IsTolidi As Boolean = IsVahedTejariTolidi

        gNoeBarnamehIsVisible = IIf(CApp.GetAppConfig("gNoeBarnamehIsVisible") Is System.DBNull.Value, False, CApp.GetAppConfig("gNoeBarnamehIsVisible"))

        DVabSanad = New CDataView(cn)
        With DVabSanad
            .Init(pnlG, pnlD, pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
              Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdPrint)
            .TableName = "abSanad"
            .InsertSPName = "_abSanad_InsertX"
            .DeleteSPName = "_abSanad_DeleteX"
            .SettingID = CStr(NoeTarakoneshSN)
            .AddJoin("abSanad", EnumTableJoin.tjLeftJoin, "abSanadStatus", "SanadStatus", "SanadStatusSN")
            .AddJoin("abSanad", EnumTableJoin.tjLeftJoin, "paDaftarforoosh", "RezSN2", "DaftarForooshSN")
            If IsVahedeTejariUseFodarkhastonSanad Then
                .AddJoin("abSanad", EnumTableJoin.tjLeftJoin, "fovw_Darkhast_abSanad", "RezSN1", "DarkhastSN")
            End If



            Param(0) = "NoeAnbarSN"
            Param(1) = "NoeAnbarSN"
            Param(2) = "TarakoneshSN"
            Param(3) = "TarakoneshSN"

            .AddJoin("abSanad", EnumTableJoin.tjLeftJoin, "abAnbarTarakonesh", "AnbarSN", "AnbarSN", Param)
            .AddJoin("abSanad2", EnumTableJoin.tjLeftJoin, "abAnbarTarakonesh", "AnbarSN", "AnbarSN", Param)
            .EditInGrid = False
            .AutoFetchCurrentRow = True
            ' ‌تنظيم دسترسي برابر چگونگي درخواست نمايش و دسترسي درخواست کنند
            ' Property -> NoeTarakoneshSN
            If Trim(NoeAccessRight) <> "" Then
                Select Case NoeTarakoneshSN
                    Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntRESIDHA
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntHAVALEHHA
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)

                        '910309
                    Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)

                    Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                        .AccessRight = gSM.TableAccessRight(NoeAccessRight)
                    Case Else
                        .AccessRight = EnumAccessRight.arView
                End Select
            Else
                .AccessRight = EnumAccessRight.arView
            End If

            Call MakeFilter(vMinDate, vMaxDate)

            .SQLOrderBy = "abSanad.SanadStatus, abTarakonesh.TartibA , abSanad.SanadNO "
            ''' ----------------------------------------------------------------------------------------------
            With .Fields
                With .Add("SanadSN", txtSanadSN, gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("SanadNO", txtSanadNO)
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("TarakoneshSN->abTarakonesh.TarakoneshNo AS TarakoneshNo", "DataCombo <Disabled>")
                    .Component.Visible = False
                End With
                With .Add("TarakoneshSN->abTarakonesh.TarakoneshDs", dbcTarakoneshSN)
                    .DefaultValue = TarakoneshSN
                    pdbcTarakoneshSNComboWhereCondition = " abTarakonesh.TarakoneshSN IN (SELECT abAnbarTarakonesh.TarakoneshSN FROM abAnbarTarakonesh " &
                       " WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) & ")"
                    pdbcTarakoneshSNInsertComboWhereCondition = " abTarakonesh.TarakoneshSN IN (SELECT abAnbarTarakonesh.TarakoneshSN FROM abAnbarTarakonesh " &
                       " WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) &
                       " AND abAnbarTarakonesh.AnbarTarakoneshStatus = 1  AND ISNULL(RezDB,0) = 1) " &
                       " AND abTarakonesh.TarakoneshStatus = 1  "  ' به درخواست آقاي اشعري 84/07/24 
                    ' با توجه به نوع درخواست نمايش فرم تراکنش هاي مجاز استفاده مشخص ميگردد
                    ' Property -> NoeTarakoneshSN
                    Dim vstrComboWhereCondition As String
                    Select Case NoeTarakoneshSN
                        Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN (  " & CStr(EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH) & "  )"
                            .DefaultValue = Val(CStr(EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH))
                        Case EnumNoeTarakoneshSN.ntRESIDHA
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND abTarakonesh.TarakoneshSN BETWEEN 0 AND 49   AND " & " abTarakonesh.TarakoneshSN  NOT IN ( " & CStr(EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH) & "," &
                              CStr(EnumTarakoneshSN.EZAFI_MOJOODI_ANBAR_RESID) & "," &
                              CStr(EnumTarakoneshSN.RESIDE_46_Kazeb) & "," &
                               CStr(EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH) & "," & CStr(EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) & "," &
                                CStr(EnumTarakoneshSN.RESIDE_06_EzafehDryaft) & "," & CStr(EnumTarakoneshSN.RESIDE_07_KasriErsal) & ") "

                            '910309
                        Case EnumNoeTarakoneshSN.ntHAVALEHHA
                            vstrComboWhereCondition = vstrComboWhereCondition &
                             " AND  abTarakonesh.TarakoneshSN >= 51   AND " _
                               & " abTarakonesh.TarakoneshSN  NOT IN ( " &
                               CStr(EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE) & "," &
                               CStr(EnumTarakoneshSN.HAVALEH_93_HavalehKazeb) & "," &
                               CStr(EnumTarakoneshSN.HAVALEH_116_EzafehErsal) & "," &
                               CStr(EnumTarakoneshSN.HAVALEH_117_KasriDryaft) & "," &
                               CStr(EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH) & "," &
                               CStr(EnumTarakoneshSN.HAVALEH_111_KahandehKharid) & " ) "

                        Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.EZAFI_MOJOODI_ANBAR_RESID) & ", " & CStr(EnumTarakoneshSN.RESIDE_46_Kazeb) & " ) "
                        Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE) & ", " & CStr(EnumTarakoneshSN.HAVALEH_93_HavalehKazeb) & " ) "
                        Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE) & " ) "
                        Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_45_BARGASHTI_ESLAHIEH) & " ) "
                        Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_95_BARGASHTI_ESLAHIEH) & " ) "
                        Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_111_KahandehKharid) & " ) "
                        Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_06_EzafehDryaft) & " ) "
                        Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.RESIDE_07_KasriErsal) & " ) "
                        Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_116_EzafehErsal) & " ) "
                        Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                            vstrComboWhereCondition = vstrComboWhereCondition & " AND  abTarakonesh.TarakoneshSN IN ( " & CStr(EnumTarakoneshSN.HAVALEH_117_KasriDryaft) & " ) "
                            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Case Else
                            vstrComboWhereCondition = " 1 > 1 "
                            dbcTarakoneshSN.Enabled = False
                            .ReadOnly = True
                    End Select
                    pdbcTarakoneshSNComboWhereCondition = pdbcTarakoneshSNComboWhereCondition & vstrComboWhereCondition
                    pdbcTarakoneshSNInsertComboWhereCondition = pdbcTarakoneshSNInsertComboWhereCondition & vstrComboWhereCondition
                    .ComboWhereCondition = pdbcTarakoneshSNComboWhereCondition
                    '          .ComboWhereCondition = .ComboWhereCondition & " AND TarakoneshStatus = 1" 850122
                    .ComboOrderBy = " TartibA "
                End With
                With .Add("AnbarSN->abAnbar.AnbarDs", dbcAnbarSN, EnumFieldOptions.foHidden)
                    ' اعمال شرط براي نمايش اطلاعات انبار جاريd
                    .ComboWhereCondition = " abAnbar.AnbarSN = " & gAnbarSN
                    dbcAnbarSN.LateBinding = True
                    .DefaultValue = gAnbarSN
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("NoeAnbarSN", dbcNoeAnbarSN, EnumFieldOptions.foHidden)
                    .ComboWhereCondition = " abNoeAnbar.NoeAnbarSN IN (SELECT abAnbarTarakonesh.NoeAnbarSN FROM abAnbarTarakonesh " &
                      " WHERE abAnbarTarakonesh.AnbarSN = " & CStr(gAnbarSN) & ")" '& _
                    '                                    " AND abAnbarTarakonesh.AnbarTarakoneshStatus = 1  ) " 850122
                    If gNoeAnbarSN <> 0 Then .DefaultValue = gNoeAnbarSN * 1.0
                End With

                With .Add("NoeAnbarSN->abNoeAnbar.NoeVoroodeAsnadSN AS NoeVoroodeAsnadSN", "DataCombo", EnumFieldOptions.foHidden)
                    .Component.Enabled = False
                    .ReadOnly = True
                    .Component.Visible = False
                End With
                With .Add("VahedeTejariSN->paVahedeTejari.VahedeTejariDs As VahedeTejariSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
                End With
                With .Add("abSanad2.TarakoneshSN As MarjaTarakoneshSN", , EnumFieldOptions.foHidden)
                End With
                With .Add("SanadDate", txtSanadDate, EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                       cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                    If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
                        .MinValue = gHesabdariSalFDate
                        .MaxValue = gHesabdariSalTDate
                        .DateFormat = EnumDateFormat.dfFullYear
                    End If

                End With

                With .Add("MoaserDate", txtMoaserDate, EnumFieldOptions.foDate Or EnumFieldOptions.foHidden)
                    .Component.Enabled = False
                    .ReadOnly = True
                    .Component.Visible = False
                    .DateFormat = EnumDateFormat.dfFullYear

                End With
                With .Add("SabtDate", txtSabtDate, EnumFieldOptions.foDate)
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                       cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                    .Component.Enabled = False
                    .ReadOnly = True
                    .Component.Visible = True
                    .DateFormat = EnumDateFormat.dfFullYear
                End With

                With .Add("{Case When not absanad.SanadNo is null then Substring(absanad.TaeedDate,1,4)+'/'+Substring(absanad.TaeedDate,5,2)+'/'+Substring(absanad.TaeedDate,7,2) else '' end } As TaeedDate ")
                    .ReadOnly = True
                    .DateFormat = EnumDateFormat.dfFullYear
                End With

                Select Case NoeTarakoneshSN
                    Case EnumNoeTarakoneshSN.ntRESIDHA  ' " عمليات رسيد ها "

                        If VahedeTejariMohlatMarjooeiForoosh > 0 Then
                            Dim btCalendarFunction As New Minoo.Applications.ProductionPlanning.Calender.CCalender
                            MohlatMarjooeiDate = btCalendarFunction.AddTedadRoozToDate(DVabSanad.Fields("SabtDate").DefaultValue, -VahedeTejariMohlatMarjooeiForoosh, ProductionPlanning.Calender.CCalender.CalendarType.Shamsi)
                            If MohlatMarjooeiDate.Length = 10 Then
                                MohlatMarjooeiDate = MohlatMarjooeiDate.Replace("/", "")
                            End If
                        End If

                        With .Add("TafsiliSN2->{Convert(Varchar(7), ISNULL(foFactor.FactorNO,0)) + ' _ ' +  foFactor.SodoorDate } As TafsiliSN2" _
                            , dcbMarjaSanadSN, EnumFieldOptions.foHidden)
                            .Caption = cn.FieldCaption("abSanad.TafsiliSN2")
                            .ComboLateBinding = True
                            .ComboWhereCondition = If(MohlatMarjooeiDate.Length = 8 AndAlso MohlatMarjooeiDate.Substring(0, 2) = "14", "foFactor.SodoorDate>='" & MohlatMarjooeiDate & "' And ", "") & " foFactor.FactorNO IS NOT NULL AND foFactor.Status = 2  AND foFactor.Res2 IN (1.101 , 2.101 ) And FactorSN in (Select Distinct FactorSn from foFactorHa where DarkhastTypeSN =2.101)"
                            .ComboOrderBy = " Convert(Bigint,foFactor.SodoorDate) DESC "
                        End With

                        With .Add("MarjaSanadSN->{Convert(Varchar(14), ISNULL(abSanad2.SanadNO,0)) + ' _ ' +  abSanad2.SanadDate } As MarjaSanadSN", dcbMarjaSanadSN2, EnumFieldOptions.foHidden)
                            Dim _wss As String = " abSanad2.SanadStatus = 8 " &
                                                          " AND abSanad2.AnbarSN =  " & CStr(gAnbarSN) &
                                                          " AND abSanad2.NoeAnbarSN =  " & CStr(gNoeAnbarSN) &
                                                          " AND abSanad2.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate
                            .ComboWhereCondition = _wss
                        End With

                    Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE

                        If VahedeTejariMohlatMarjooeiTozie > 0 Then
                            Dim btCalendarFunction As New Minoo.Applications.ProductionPlanning.Calender.CCalender
                            MohlatMarjooeiDate = btCalendarFunction.AddTedadRoozToDate(DVabSanad.Fields("SabtDate").DefaultValue, -VahedeTejariMohlatMarjooeiTozie, ProductionPlanning.Calender.CCalender.CalendarType.Shamsi)
                            If MohlatMarjooeiDate.Length = 10 Then
                                MohlatMarjooeiDate = MohlatMarjooeiDate.Replace("/", "")
                            End If
                        End If

                        With .Add("TafsiliSN2->{Convert(Varchar(7), ISNULL(foFactor.FactorNO,0)) + ' _ ' +  foFactor.SodoorDate } As TafsiliSN2" _
                           , dcbMarjaSanadSN, EnumFieldOptions.foHidden)
                            .Caption = cn.FieldCaption("abSanad.TafsiliSN2")
                            .ComboLateBinding = Not IsTolidi
                            .ComboWhereCondition = If(MohlatMarjooeiDate.Length = 8 AndAlso MohlatMarjooeiDate.Substring(0, 2) = "14" AndAlso Not IsTolidi, "foFactor.SodoorDate>='" & MohlatMarjooeiDate & "' And ", "") & " foFactor.FactorNO IS NOT NULL AND foFactor.Status = 2  AND foFactor.Res2 NOT IN (3.101 , 4.101,5.101,20.101) "
                            .ComboOrderBy = " Convert(Bigint,foFactor.SodoorDate) DESC "
                        End With

                        ''''''''''''ghasemi 14010117
                        With .Add("MarjaSanadSN->{Convert(Varchar(14), ISNULL(abSanad2.SanadNO,0)) + ' _ ' +  abSanad2.SanadDate } As MarjaSanadSN", dcbMarjaSanadSN2, EnumFieldOptions.foHidden)
                            Dim _wss As String = " abSanad2.SanadStatus = 8 " &
                               " AND abSanad2.AnbarSN =  " & CStr(gAnbarSN) &
                               " AND abSanad2.NoeAnbarSN =  " & CStr(gNoeAnbarSN) &
                               " AND abSanad2.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate
                            .ComboWhereCondition = _wss
                        End With
                        ''''''''''''ghasemi 14010117
                    Case Else  ' Other Case Same as EnumNoeTarakoneshSN.ntRESIDEBARGASHTI, EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                        With .Add("MarjaSanadSN->{Convert(Varchar(14), ISNULL(abSanad2.SanadNO,0)) + ' _ ' +  abSanad2.SanadDate } As MarjaSanadSN" _
                            , dcbMarjaSanadSN2, EnumFieldOptions.foDefault)
                            .Caption = cn.FieldCaption("abSanad.MarjaSanadSN")
                            dcbMarjaSanadSN2.LateBinding = True
                            Dim _wss As String = " abSanad2.SanadStatus = 8 " &
                               " AND abSanad2.AnbarSN =  " & CStr(gAnbarSN) &
                               " AND abSanad2.NoeAnbarSN =  " & CStr(gNoeAnbarSN) &
                               " AND abSanad2.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate

                            .ComboWhereCondition = _wss
                            If NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEBARGASHTI _
                            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI _
                            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID _
                            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL _
                            Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT Then
                                .AllowNulls = False
                                .FieldOptions = EnumFieldOptions.foDefault
                            End If

                        End With

                        .Add("TafsiliSN2->{Convert(Varchar(7), ISNULL(foFactor.FactorNO,0)) + ' _ ' +  foFactor.SodoorDate } As TafsiliSN2", , EnumFieldOptions.foHidden)

                End Select

                With .Add("TarafHesabSN", , EnumFieldOptions.foHidden)
                    .ComboWhereCondition = "  1 = 2 "
                End With
                With .Add("TafsiliSN->{ maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS} AS TafsiliSN ", dbcTarafHesabSN)
                    .Caption = lblTarafHesabSN.Text
                    dbcTarafHesabSN.LateBinding = True
                    .ComboWhereCondition = "  1 = 2 "
                End With

                With .Add("TafsiliSN1->{ maTafsili2.TafsiliNO + ' _ ' + maTafsili2.TafsiliDS} AS TafsiliSN1 ", dbcTafsiliSN1)
                    .Caption = "طرف حساب 2"
                    dbcTafsiliSN1.LateBinding = True
                    .ComboWhereCondition = "  1 = 2 "
                End With

                With .Add("EDAnbarSN->abAnbar2.AnbarDs", , EnumFieldOptions.foHidden)
                    .ComboWhereCondition = "  1 = 2 "
                End With
                With .Add("EDNoeAnbarSN->abNoeAnbar2.NoeAnbarDs", , EnumFieldOptions.foHidden)
                    .ComboWhereCondition = "  1 = 2 "
                End With
                With .Add("SanadStatus->SanadStatusDS", dbcSanadStatus)
                    .DefaultValue = 1
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("SanadStatusMali", , EnumFieldOptions.foHidden)
                End With
                With .Add("EditionNo", , EnumFieldOptions.foHidden)
                End With
                .Add("ESSanadSN", , EnumFieldOptions.foHidden)
                .Add("DarkhastSN", , EnumFieldOptions.foHidden)
                .Add("MojavezErsalSN", , EnumFieldOptions.foHidden)
                .Add("WorkOrederSN", , EnumFieldOptions.foHidden)
                With .Add("HavalehForooshSN", , EnumFieldOptions.foHidden)
                End With

                'Select Case NoeTarakoneshSN
                '    Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT, EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                '        With .Add("MarjaSanadSN->{Convert(Varchar(14), ISNULL(abSanad2.SanadNO,0))} As MarjaSanadNO", , EnumFieldOptions.foDefault)
                '            .Caption = "شماره ارجاع"
                '            Dim _wss As String = " abSanad2.SanadStatus = 8 " &
                '               " AND abSanad2.AnbarSN =  " & CStr(gAnbarSN) &
                '               " AND abSanad2.NoeAnbarSN =  " & CStr(gNoeAnbarSN) &
                '               " AND abSanad2.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate
                '            .ComboWhereCondition = _wss
                '        End With
                'End Select

                With .Add("ShomarehSefaresh", txtShomarehSefaresh, EnumFieldOptions.foDefault)
                    .DataType = "BIGINT"
                    .ComboLateBinding = True
                End With
                .Add("TarafHesab", , EnumFieldOptions.foHidden)
                With .Add("ShomarehBarnameh", txtShomarehBarnameh, EnumFieldOptions.foHidden)
                    .DataType = "INT"
                End With
                With .Add("ShomarehMashin", txtShomarehMashin, EnumFieldOptions.foHidden)
                End With
                .Add("NameRanandeh", txtNameRanandeh, EnumFieldOptions.foHidden)
                With .Add("VazneBaskool", txtVazneBaskool, EnumFieldOptions.foHidden)
                    .DataType = "INT"
                End With
                .Add("Shomareh1", , EnumFieldOptions.foHidden)
                .Add("Shomareh2", , EnumFieldOptions.foHidden)

                If IsVahedeTejariUseFodarkhastonSanad Then
                    With .Add("RezSN1->fovw_Darkhast_abSanad.{DarkhastDS} As RezSN1", DcbForooshDarkhast, EnumFieldOptions.foHidden)
                        .Caption = "شماره درخواست فروش"
                        DcbForooshDarkhast.LateBinding = True
                        .ComboWhereCondition = "fovw_Darkhast_abSanad.DarkhastSN In (Select DarkhastSN from fovw_DarkhastHamlMostaghim)"
                        .RefreshCombo()
                    End With

                End If

                With .Add("RezSN2->{paDaftarforoosh.DaftarForooshDS } As RezSN2", dbcRezSN2, If(ShowDaftarForoosh, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                    .Caption = "دفتر فروش"
                    dbcRezSN2.LateBinding = True
                    .ComboWhereCondition = "paDaftarforoosh.DaftarForooshSN In (Select DaftarforooshSN from paDaftarforoosh Where VahedeTejariSN=" & gVahedeTejariSN.ToString & ")"
                    ''  .RefreshCombo()
                End With


                'With .Add("{dbo.abFn_GetZayeatGardeshNo(abSanad.RezSN4)} As ZayeatGardeshNo", "textbox", If(GVahedeTejariUsesKartablZayeat, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                '    .Caption = "شماره درخواست ضایعات"
                '    .ReadOnly = True
                'End With

                If VahedeTejariMohlatMarjooeiForoosh > 0 And (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Then
                    Dim dv As DataView = cn.ExecuteQuery("select  1 from abAnbarTarakonesh where AnbarTarakoneshStatus=1 and TarakoneshSN=38 and left(MaxDateDoreh,4)>=" & gHesabdariSal.ToString & " And AnbarSN=" & gAnbarSN.ToString)
                    If dv.Count > 0 Then
                        With .Add("{dbo.abFn_GetFactorNoForSanadSN(abSanad.HavalehForooshSN)} As FactorNo", "", EnumFieldOptions.foDefault)
                            .Caption = "شماره فاکتور اصلی"
                            .ReadOnly = True
                        End With
                    End If
                End If


                .Add("Tozih", txtTozih)
                With .Add("UserIDSabt", , EnumFieldOptions.foHidden)
                End With
                With .Add("UserNameSabt", , EnumFieldOptions.foHidden)
                End With
                With .Add("UserIDTaeed", , EnumFieldOptions.foHidden)
                End With
                With .Add("UserNameTaeed", , EnumFieldOptions.foHidden)
                End With
                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
                With .Add("NoeSanadID->abVw_NoeSanad.NoeSanadDS", "DataCombo <Disabled>", EnumFieldOptions.foHidden) '850919
                    .Caption = cn.FieldCaption("abSanad.NoeSanadID")
                    .DefaultValue = 1
                    .Component.Visible = False
                End With

                .Add("abAnbarTarakonesh.RezDC AS AbAnbarTarakonesh_RezDC", , EnumFieldOptions.foHidden)
                .Add("abAnbarTarakonesh2.RezDC AS AbAnbarTarakonesh2_RezDC", , EnumFieldOptions.foHidden)

                .Add("RezSN4", ChkAutoTransferToKartablZayeat, EnumFieldOptions.foHidden).Caption = "انتقال به کارتابل ضایعات"
                .Add("RezStatus2", ChkIsFakorEbtal, EnumFieldOptions.foHidden).Caption = "مرجوعی کل فاکتور؟"

                .Add("{Case when CHARINDEX('اسناد بارکدخوان',abSanad.Tozih,0)>0 Then 1 Else 0 End} As BarcodeReaderSanad", , EnumFieldOptions.foHidden)


                '''Log ghasemi 14001028
                Dim gNamyeshSabtDarSamaneh As Boolean = If(CApp.GetAppConfig("gNamyeshSabtDarSamaneh") Is System.DBNull.Value, False, True)
                If gNamyeshSabtDarSamaneh Then
                    With .Add("{dbo.btFn_GetVaziateSabtDarSamaneh(abSanad.sanadsn)} as RezStatus", "checkbox", EnumFieldOptions.foDefault)
                        .Caption = "ثبت در سامانه"
                        .ReadOnly = True
                        .DefaultValue = 0
                        .Component.Visible = False
                    End With
                End If
                '' Log ghasemi 14001028
            End With
        End With

        '    pFLX_abSanad = DVabSanad.FlexGrid '850622



        ''' ----------------------------------------------------------------------------------------------
        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        DVabSanadHa = New CDataView(cn)

        With DVabSanadHa

            .Init(pnlG1, , pnlC1, pnlN1, EnumButtonOptions.boCmdModify + EnumButtonOptions.boCmdPrint)
            .TableName = "abSanadHa"
            .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")
            .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "AbAnbarKala", "KalaSN", "KalaSN")
            .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "abKalaPhizikiControl", "KalaPhizikiSN", "KalaPhizikiSN") ' Add By Yekta 920814
            If QuickActionOnAbSanadHa Then
                .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "abVw_DarkhastHayeTadarokat", "mojavezErsalHaSN", "DarkhastKalaSN")
                .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "abVw_abResidWithoutDarkhast", "SanadHaSN", "SanadHaSN") ' Add By Yekta 920228
                .AddJoin("abSanadHa", EnumTableJoin.tjLeftJoin, "abvw_darkhast", "DarkhastHaSN", "DarkhastKalaSN")
            End If

            .SettingID = CStr(NoeTarakoneshSN)
            .SQLOrderBy = " abSanadHa.SanadHaSN "
            .EditInGrid = True
            .AccessRight = DVabSanad.AccessRight
            .DeleteSPName = "_abSanadHa_DeleteX"
            .InsertSPName = "_abSanadHa_InsertX"
            .UpdateSPName = "_abSanadHa_UpdateX"
            .InsertSPUserParam = " "
            .SQLWhere = "abAnbarKala.AnbarSN = " & gAnbarSN & " And abAnbarKala.noeAnbarSN=" & gNoeAnbarSN
            .AutoFetchCurrentRow = True

            With .Fields
                With .Add("SanadHaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("SanadSN", , EnumFieldOptions.foHidden)
                .Add("MarjaSanadHaSN", , EnumFieldOptions.foHidden)
                .Add("GorooheKalaSN", "DataCombo <Disabled>", EnumFieldOptions.foHidden)
                With .Add("KalaSN->KalaNO", "TextBox", EnumFieldOptions.foDefault)
                    .ReadOnly = True
                End With
                With .Add("KalaSN->pakala.{pakala.KalaNO + ' _ ' + pakala.KalaDS} AS KalaDS", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paKala.KalaDs")
                    dcbKalaDS = .Component
                    pdbcKalaDSComboWhereCondition = .ComboWhereCondition
                    If Len(Trim(pdbcKalaDSComboWhereCondition)) = 0 Then pdbcKalaDSComboWhereCondition = " 1 = 1 "
                    dcbKalaDS.LateBinding = True
                    dcbKalaDS.LateBindingTop = 200
                    .LockUpdate = True

                End With
                With .Add("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDs AS VahedeSanjeshDs", "TextBox <Disabled>", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVahedeSanjesh.VahedeSanjeshDs")
                End With
                With .Add("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza", "TextBox <Disabled>", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.TedadAjza")
                End With

                '//
                With .Add("AbAnbarKala.KalaPhizikiStatusSN AS KalaPhizikiStatusSN ", "TextBox <Disabled>", EnumFieldOptions.foHidden)
                    '.Caption = cn.FieldCaption("abKalaPhizikiStatus.KalaPhizikiStatusDs")
                End With

                With .Add("AbAnbarKala.Auto AS Auto", "TextBox <Disabled>", EnumFieldOptions.foHidden)
                    '.Caption = cn.FieldCaption("abAnbarNoeRahgiri.Auto")
                End With

                With .Add("AbAnbarKala.Meghdar AS Meghdar", "TextBox <Disabled>", EnumFieldOptions.foHidden)
                    .Caption = cn.FieldCaption("abAnbarNoeRahgiri.Meghdar")
                End With

                With .Add("AbAnbarKala.ToolidDate AS ToolidDateFlag", "TextBox <Disabled>", EnumFieldOptions.foHidden)

                End With

                With .Add("AbAnbarKala.EnghezaDate AS EnghezaDateFlag", "TextBox <Disabled>", EnumFieldOptions.foHidden)

                End With

                '//

                With .Add("{Convert(BIGINT,abSanadHa.MeghdareVaredeh/paVw_VahedeSanjesh.TedadAjza)} As Box_in", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abSanadHa.Box")
                    .DataType = "INT"
                    .Format = "#.#"
                End With
                If NamayeshAshar Then
                    With .Add("{abSanadHa.MeghdareVaredeh%paVw_VahedeSanjesh.TedadAjza} As Can_in", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = cn.FieldCaption("abSanadHa.Can")
                        .Format = "#.###"
                    End With
                Else
                    With .Add("{Convert(BIGINT,abSanadHa.MeghdareVaredeh%paVw_VahedeSanjesh.TedadAjza)} As Can_in", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = cn.FieldCaption("abSanadHa.Can")
                        .DataType = "INT"
                    End With
                End If

                With .Add("{Convert(BIGINT, abSanadHa.MeghdareSadereh/paVw_VahedeSanjesh.TedadAjza)} As Box_out", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abSanadHa.Box")
                    .DataType = "INT"
                    .Format = "#.#"
                End With
                If NamayeshAshar Then
                    With .Add("{abSanadHa.MeghdareSadereh%paVw_VahedeSanjesh.TedadAjza} As Can_out", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = cn.FieldCaption("abSanadHa.Can")
                        .Format = "#.###"
                    End With
                Else
                    With .Add("{Convert(BIGINT, abSanadHa.MeghdareSadereh%paVw_VahedeSanjesh.TedadAjza)} As Can_out", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = cn.FieldCaption("abSanadHa.Can")
                        .DataType = "INT"
                    End With
                End If
                .Add("Tartib", "TextBox", EnumFieldOptions.foHidden)
                If NamayeshAshar Then
                    ''ToDO : Romove For More Run Speed
                    If QuickActionOnAbSanadHa Then
                        With .Add("{abvw_darkhast.MeghdareDarkhasti%paVw_VahedeSanjesh.TedadAjza} As MeghdareDarkhasti ", "TextBox", EnumFieldOptions.foHidden)
                            .Format = "#.###"
                        End With
                    End If
                    With .Add("MeghdareVaredeh", "TextBox", EnumFieldOptions.foDefault)
                        .DigitGroupSymbol = ","
                        .Format = "#.###"
                    End With
                Else
                    ''ToDO : Romove For More Run Speed
                    If QuickActionOnAbSanadHa Then
                        With .Add("{Convert(BIGINT, abvw_darkhast.MeghdareDarkhasti%paVw_VahedeSanjesh.TedadAjza)} As MeghdareDarkhasti", "TextBox", EnumFieldOptions.foHidden)
                            .MaxLength = 7
                            .DataType = "INT"
                        End With
                    End If
                    With .Add("MeghdareVaredeh", "TextBox", EnumFieldOptions.foDefault)
                        .MaxLength = 12
                        .DataType = "INT"
                    End With
                End If

                With .Add("GheymateVaredeh", "TextBox", EnumFieldOptions.foHidden)
                    .MaxLength = 3
                    .DataType = "INT"
                    .Format = "#.#"
                End With
                If NamayeshAshar Then
                    With .Add("MeghdareSadereh", "TextBox", EnumFieldOptions.foDefault)
                        .DigitGroupSymbol = ","
                        .Format = "#.###"
                    End With
                Else
                    With .Add("MeghdareSadereh", "TextBox", EnumFieldOptions.foDefault)
                        .MaxLength = 12
                        .DataType = "INT"
                    End With
                End If

                With .Add("GheymateSadereh", "TextBox", EnumFieldOptions.foHidden)
                    .MaxLength = 1
                    .DataType = "INT"
                    .Format = "#.#"
                End With
                .Add("MeghdareNakhales", "TextBox", EnumFieldOptions.foDefault)
                .Add("TafsiliSN1", "TextBox", EnumFieldOptions.foDefault)
                'With .Add("abKalaPhiziki.KalaPhizikiStatus->KalaPhizikiStatusDS AS KalaPhizikiStatusDS", "DataCombo", EnumFieldOptions.foHidden)
                '  dcbKalaPhizikiSN = .Component
                '  '.DefaultValue = gKalaPhizikiStatusSN
                '  .ReadOnly = True
                'End With


                With .Add("KalaPhizikiSN->ShomarehRahgiri AS ShomarehRahgiriText", "TextBox")
                    dcbShomarehRahgiriText = .Component
                    .ComboWhereCondition = " 1 = 2 "
                    .AllowNulls = True
                    .Caption = cn.FieldCaption("abkalaphiziki.shomarehrahgiri") & IIf(IsTolidi, "", "(نرخ مصرف کننده)")
                End With

                ''ghasemi 14021201
                If IsTolidi And IsStandard Then
                    With .Add("{CASE when abkalaphiziki.MeghdareFaktor = 0 THEN 0 ELSE  Convert(BIGINT,abkalaphiziki.GheymateFaktor / abkalaphiziki.MeghdareFaktor) End} As NerkhVaghey", "TextBox", EnumFieldOptions.foDefault)
                        .DataType = "INT"
                        .DigitGroupSymbol = ","
                        .Format = "#.###"
                        .Caption = "نرخ واقعی"
                        .ReadOnly = True
                    End With
                End If
                ''ghasemi 14021201

                With .Add("ToolidDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .Caption = cn.FieldCaption("abKalaPhiziki.ToolidDate")
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("EnghezaDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .Caption = cn.FieldCaption("abKalaPhiziki.EnghezaDate")
                    .DateFormat = EnumDateFormat.dfFullYear
                End With

                .Add("NoeZayeatSN", "DataCombo", EnumFieldOptions.foDefault)
                .Add("NoeMarjooeiSN", "DataCombo", EnumFieldOptions.foDefault)
                .Add("NoeMadomiSN", "DataCombo", EnumFieldOptions.foDefault)
                ''.Add("ESStatus", , EnumFieldOptions.foHidden)
                '.Add("DarkhastHaSN", , EnumFieldOptions.foHidden)
                'With .Add("DarkhastHaSN->abvw_darkhast.DarkhastNo ", "DataCombo")
                'ToDO : Romove For More Run Speed
                If QuickActionOnAbSanadHa Then
                    With .Add("DarkhastHaSN->abvw_darkhast.DarkhastNo ", "DataCombo")
                        dcbDarkhastHa = .Component
                        .Caption = cn.FieldCaption("abSanadHa.DarkhastHaSN")
                        .Text = "درخواست"
                        .ReadOnly = True
                    End With
                End If
                '.Add("MojavezErsalHaSN", , EnumFieldOptions.foHidden)
                ''ToDO : Romove For More Run Speed
                If QuickActionOnAbSanadHa Then
                    With .Add("mojavezErsalHaSN->abVw_DarkhastHayeTadarokat.DarkhastKalaNo ") ', "DataCombo") comment by yekta 920415
                        dcbMojavezErsalHa = .Component
                        .Caption = cn.FieldCaption("abSanadHa.mojavezErsalHaSN")
                        '.ComboWhereCondition = "darkhastkalamount > meghdaredaryafti"
                    End With
                End If

                ''ToDO : Romove For More Run Speed
                If QuickActionOnAbSanadHa Then
                    'With .Add("{dbo.abFn_MandehDarkhastSanadHa(SanadHaSN," & gVahedeTejariSN.ToString & ")} AS abVw_abResidWithoutDarkhast_MandehResid", "TextBOX")
                    '    .Caption = "مقدار رسيد بدون درخواست"
                    '    .ReadOnly = True
                    'End With

                    With .Add("SanadHaSN->abVw_abResidWithoutDarkhast.MandehResid AS MandehResid", "TextBOX")
                        .Caption = "مقدار رسيد بدون درخواست"
                        .ReadOnly = True
                    End With
                End If

                '----- yekta 920814
                With .Add("KalaPhizikiSN->abKalaPhizikiControl.BatchNO AS BatchNO", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "شماره بچ"
                End With
                With .Add("KalaPhizikiSN->abKalaPhizikiControl.Tozih AS Tozih", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "توضیحات"
                End With
                With .Add("{Case isnull(abKalaPhizikiControl.NoeEngheza,0) When 0 Then 'تاریخ انقضاء' Else 'تاریخ ReTest' End} AS NoeEngheza", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "نوع انقضاء"
                    .DefaultValue = 0
                    .ReadOnly = True
                End With
                With .Add("{isnull(abKalaPhizikiControl.IsNewSource,0)} AS IsNewSource", "CheckBox", EnumFieldOptions.foDefault)
                    .Caption = "سورس جدید؟"
                    .ReadOnly = True
                End With



                .Add("WorkOrederHaSN", , EnumFieldOptions.foHidden)
                .Add("HavalehForooshHaSN", , EnumFieldOptions.foHidden)
                .Add("TafsiliSN", , EnumFieldOptions.foHidden)
                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)

                'ghasemi 14001028
                Dim gNamyeshSabtDarSamaneh As Boolean = If(CApp.GetAppConfig("gNamyeshSabtDarSamaneh") Is System.DBNull.Value, False, True)
                If gNamyeshSabtDarSamaneh Then
                    With .Add("ESStatus", "checkbox", EnumFieldOptions.foDefault)
                        .Caption = "ثبت در سامانه"
                        .DefaultValue = 0
                        .ReadOnly = True
                    End With
                End If
                'ghasemi 14001028

                If IsVahedeTejariSabtUIDonSanad Then
                    With .Add("{dbo.abFn_GetNumberOfUIDSabtShodeSanadHaSN(abSanadHa.SanadHaSN)} As NumberOfUIDs", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "تعداد UID ثبت شده"
                        .DataType = "INT"
                        .ReadOnly = True
                    End With
                End If

                With .Add("{dbo.[abFn_GetKalaPhizikiToolidEnghezaDate](abSanadHa.KalaPhizikiSN)} As KalaPhizikiToolidEnghezaDate", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "تاریخ تولید/انقضاء"
                    .ReadOnly = True
                End With

                If ShowTabChideman Then
                    With .Add("{dbo.abFn_GetChidemanDSOfSanadHaSN(abSanadHa.SanadHaSN)} AS ChidemanText", "TextBox")
                        .Caption = "چیدمان"
                        .ReadOnly = True
                    End With
                End If


            End With
            .Parent = DVabSanad
        End With
        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        DVabBarnameh = New CDataView(cn)
        With DVabBarnameh
            .Init(pnlgBarnameh, , pnlcBarnameh, , EnumButtonOptions.boCmdModify + EnumButtonOptions.boCmdFilter)
            .TableName = "abBarnameh"
            '.InsertSPName = "" '_abBarnameh_InsertX
            .DeleteSPName = ""
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            .SQLWhere = "1<>1"

            With .Fields
                DVabBarnameh.SettingID = "Barnameh"

                With .Add("BarnamehSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("BarnamehNo", "Textbox")
                    .Caption = "شماره بارنامه"
                    .DataType = "INT"
                End With

                With .Add("NoeBarnamehSN->{abNoeBarnameh.NoeBarnamehDS} as NoeBarnamehDS", "DataCombo", IIf(gNoeBarnamehIsVisible, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                    .Caption = "نوع بارنامه"
                    .ComboLateBinding = True
                    .DefaultValue = 1.101 ' بارنامه معمولی
                    .ReadOnly = Not gNoeBarnamehIsVisible
                End With

                'With .Add("AnbarSN", , EnumFieldOptions.foHidden)
                '    .DefaultValue = gAnbarSN
                'End With

                With .Add("VahedeTejariSn", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With

                With .Add("NameRanandeh", "Textbox")
                    .Caption = "نام راننده"
                    .MinComponentWidth = 100
                End With
                With .Add("MobileRanandeh", "Textbox")
                    .Caption = "موبایل راننده"
                    .MinComponentWidth = 100
                End With

                With .Add("BarbariSN->{paBarbari.BarbariDS} as BarbariDS", "DataCombo")
                    .Caption = "شرکت حمل و نقل"
                    .ComboLateBinding = True
                End With

                With .Add("ShomarehMashin", "Textbox")
                    .Caption = "شماره ماشین"
                    .MinComponentWidth = 100
                End With

                With .Add("BarnamehDate", "Textbox", EnumFieldOptions.foDate)
                    .Caption = "تاريخ بارنامه"
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("SanadMaliDate", "Textbox", EnumFieldOptions.foDate)
                    .Caption = "تاريخ پرداخت"
                    txtSanadMaliDate = .Component
                    .DateFormat = EnumDateFormat.dfFullYear
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("SabtDate", , EnumFieldOptions.foDefault)
                    .Caption = "تاريخ ثبت"
                    .DateFormat = EnumDateFormat.dfFullYear
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("EbtalDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ ابطال"
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("EbtalSanadMaliDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ سند مالی ابطال"
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("GhatiDate", , EnumFieldOptions.foHidden)
                    .Caption = "تاريخ قطعی سازی"
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("VahedeTashim", , EnumFieldOptions.foHidden)
                    .Caption = "نحوه تسهیم"
                    .DateFormat = EnumDateFormat.dfFullYear
                    .DefaultValue = 0
                End With


                '.Add("dpVwj_PardakhtBarnameh.TalabBedehiSN", , EnumFieldOptions.foHidden)
                'With .Add("TalabBedehiSN->{dpVwj_PardakhtBarnameh.Pardakht} as PardakhtNo", "DataCombo", EnumFieldOptions.foDefault)
                '    .Caption = "پرداخت"
                '    cboPardakhtBarnameh = .Component
                '    .ComboLateBinding = True
                'End With

                With .Add("GheymateBarnameh", "Textbox")
                    .Caption = "مبلغ بارنامه"
                    .Format = "#,###"
                    .DigitGroupSymbol = ","
                End With
                With .Add("Kasri", "Textbox")
                    .Caption = "کسری بارنامه"
                    .Format = "#,###"
                    .DigitGroupSymbol = ","
                    .DefaultValue = 0
                End With

                With .Add("ArzesheBimeh", "Textbox")
                    .Caption = "ارزش بیمه ای"
                    .Format = "#,###"
                    .DigitGroupSymbol = ","
                End With

                With .Add("Avarez", "Textbox")
                    .Caption = "عوارض"
                    .Format = "#,###"
                    .DigitGroupSymbol = ","
                    .DefaultValue = 0
                End With
                With .Add("Maliat", "Textbox")
                    .Caption = "مالیات"
                    .Format = "#,###"
                    .DigitGroupSymbol = ","
                    .DefaultValue = 0
                End With

                'With .Add("MarkazHazinehTafsiliSN->{maTafsili.TafsiliNo + ' - ' + maTafsili.TafsiliDS} as MarkazHazinehTafsiliSN", "DataCombo")
                '    .Caption = "دریافت از"
                '    .ComboLateBinding = True
                '    .ComboWhereCondition = "GoroohTafsiliSN = 79.101" 'مرکز هزینه
                'End With
                With .Add("Maghsad", "Textbox")
                    .Caption = "آدرس مقصد"
                    .MinComponentWidth = 100
                End With
                With .Add("BarnamehDS", "Textbox")
                    .Caption = "شرح بارنامه"
                    .MinComponentWidth = 100
                End With

                With .Add("ShomarehGavahiNameh", "Textbox")
                    .Caption = "شماره گواهینامه"
                    .MinComponentWidth = 100
                End With
                'With .Add("NoeKhodro", "Textbox")
                '    .Caption = "نوع خودرو"
                '    .MinComponentWidth = 100
                'End With
                With .Add("NoeKhodrooSN->{paNoeKhodroo.NoeKhodrooDs} as NoeKhodrooDs", "DataCombo")
                    .Caption = "نوع خودرو"
                    .ComboLateBinding = True
                End With

                With .Add("BarnamehStatus", , EnumFieldOptions.foHidden)
                    .DefaultValue = 0
                End With

                With _
                    .Add(
                          "{CASE WHEN BarnamehStatus = 0 THEN 'موقت' WHEN BarnamehStatus = 1 THEN 'قطعی'  ELSE 'ابطال' END} AS  BarnamehStatusDS", ,
                          EnumFieldOptions.foDefault)
                    .DefaultValue = 0
                    .Caption = "وضعیت"
                End With

                With .Add("ErsalBeDP")
                    .Caption = "ارسال شده؟"
                    .ReadOnly = True
                    .DefaultValue = 0
                End With

                With .Add("UserID_Name")
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "ثبت کننده"
                End With

                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With


        ''''''''''''''''''''''''''''
        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        DVabSanadHaDarkhast = New CDataView(cn)
        With DVabSanadHaDarkhast
            .Init(pnlG2, , pnlC2, pnlN2, EnumButtonOptions.boCmdDelete + EnumButtonOptions.boCmdInsert + EnumButtonOptions.boCmdUpdate)
            .TableName = "abSanadHaDarkhast"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "tdDarkhastKala", "DarkhastKalaSN", "DarkhastKalaSN")

            .AccessRight = gSM.TableAccessRight(.TableName)

            .EditInGrid = True
            .DeleteSPName = "_abSanadHaDarkhast_DeleteX"
            .InsertSPName = "_abSanadHaDarkhast_InsertX"
            .UpdateSPName = "_abSanadHaDarkhast_UpdateX"
            .InsertSPUserParam = " "
            .AutoFetchCurrentRow = True

            With .Fields
                With .Add("SanadHaDarkhastSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("SanadhaSN", , EnumFieldOptions.foHidden)

                With .Add("DarkhastKalaSN->tdDarkhastKala.DarkhastKalaNo AS DarkhastKalaNO ", "DataCombo")
                    dcbSanadhaDarkhast = .Component
                    .Caption = cn.FieldCaption("abSanadHa.DarkhastHaSN")
                    .Text = "درخواست"
                End With

                'With .Add("DarkhastKalaSN->tdDarkhastKala.DarkhastKalaDate ", , EnumFieldOptions.foDefault)
                '    .Caption = "تاریخ درخواست"
                'End With
                With .Add("Tedad", "Textbox")
                    .Caption = "مقدار درخواست"


                End With

                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With
            If ShowTabSanadHaDarkhast Then
                .Parent = DVabSanadHa
            End If

        End With

        '----------------------------add by yekta 940319-----------------------
        DVabSanadHaChideman = New CDataView(cn)
        With DVabSanadHaChideman
            .Init(pnlG3, , pnlC3, pnlN3, EnumButtonOptions.boCmdDelete + EnumButtonOptions.boCmdInsert + EnumButtonOptions.boCmdUpdate + EnumButtonOptions.boCmdRefresh)
            .TableName = "abSanadHaChideman"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abChideman", "ChidemanSN", "ChidemanSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_abSanadHa", "SanadhaSn", "SanadhaSn")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abKalaPhiziki", "KalaPhizikiSN", "KalaPhizikiSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAmaliat", "AmaliatSN", "AmaliatSN")

            .AccessRight = gSM.TableAccessRight(.TableName)

            .EditInGrid = True
            .DeleteSPName = "abSanadHaChideman_Delete"
            .InsertSPName = "abSanadHaChideman_Insert"
            .UpdateSPName = "abSanadHaChideman_Update"
            .InsertSPUserParam = " "
            .AutoFetchCurrentRow = True

            With .Fields
                With .Add("SanadHaChidemanSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("SanadhaSN", , EnumFieldOptions.foHidden)
                .Add("KalaPhizikiSN", , EnumFieldOptions.foHidden)
                .Add("AmaliatSN", , EnumFieldOptions.foHidden)
                .Add("AnbarSN", , EnumFieldOptions.foHidden)
                .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                .Add("SabtDate", , EnumFieldOptions.foHidden)
                With .Add("SanadhaSN->abVw_abSanadHa.{abVw_abSanadHa.KalaNO + ' - ' + abVw_abSanadHa.KalaDS} AS KalaDS ", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paKala.KalaDs")
                    .ReadOnly = True
                End With

                With .Add("KalaPhizikiSN->abKalaPhiziki.{abKalaPhiziki.ShomarehRahgiri} AS ShomarehRahgiri ", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "شماره رهگیری"
                    .ReadOnly = True
                End With
                With .Add("ChidemanSN AS ChidemanSN", "TextBox", EnumFieldOptions.foHidden)
                    dcbChidemanText = .Component
                    .ComboWhereCondition = " 1 = 2 "
                    .AllowNulls = True
                    .Caption = "چیدمان"
                End With

                With .Add("{dbo.abFn_GetChidemanDS(abSanadHaChideman.ChidemanSN)} as SortField", "TextBox", EnumFieldOptions.foDefault)

                    dcbChidemanText = .Component
                    .ComboWhereCondition = " 1 = 2 "
                    .AllowNulls = True
                    .Caption = "چیدمان"

                End With
                With .Add("MeghdareVaredeh", "Textbox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار وارده"
                End With
                With .Add("MeghdareSadereh", "Textbox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار صادره"
                End With
                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With
            If ShowTabChideman Then
                .Parent = DVabSanadHa
            End If

        End With
        '----------------------------add by yekta 940319-----------------------


        If ShowDaftarForoosh AndAlso sstChild.TabPages.IndexOf(TabDaftar) >= 0 Then
            DVabSanadHaDaftar = New CDataView(cn)
            With DVabSanadHaDaftar
                .Init(PnlGdaftar, , PnlCDaftar, PnlNDaftar, EnumButtonOptions.boCmdRefresh)
                .TableName = "abSanadHaDaftar"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadHa", "SanadhaSN", "SanadhaSN")
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "PaDaftarForoosh", "DaftarForooshSN", "DaftarForooshSN")
                .AccessRight = gSM.TableAccessRight(.TableName)

                .EditInGrid = True
                .InsertSPUserParam = " "
                .AutoFetchCurrentRow = True

                With .Fields
                    With .Add("SanadHaDaftarSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("SanadhaSN", , EnumFieldOptions.foHidden)

                    With .Add("DaftarForooshSN->PaDaftarForoosh.DaftarForooshDS AS DaftarForooshDS ", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "دفترفروش"
                    End With
                    With .Add("MeghdareVaredeh", "Textbox")
                        .Caption = "مقدار وارده"
                    End With
                    With .Add("MeghdareSadereh", "Textbox")
                        .Caption = "مقدار صادره"
                    End With
                    With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = gSM.UserID_Name
                    End With
                    With .Add("Host_Name", , EnumFieldOptions.foHidden)
                        .DefaultValue = System.Environment.MachineName
                    End With
                    .Add("RecChksum", , EnumFieldOptions.foHidden)
                End With
                .Parent = DVabSanadHa
            End With
        End If

        If ShowTabProductCatalogue Then
            DVabSanadHaProductCatalogue = New CDataView(cn)
            With DVabSanadHaProductCatalogue
                .Init(PnlGProductCatalogue, , , , EnumButtonOptions.boCmdRefresh + EnumButtonOptions.boCmdFilter)
                .TableName = "abvw_SanadHaProductCatalogue"
                .AccessRight = EnumAccessRight.arAll
                .EditInGrid = False
                With .Fields
                    .Add("SanadhaSN", , If(gSM.IsProgrammer, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                    .Add("RegisterNumber", , EnumFieldOptions.foDefault).Caption = "شماره ثبت بارکدخوان"
                    .Add("KalaDS", , EnumFieldOptions.foDefault).Caption = "محصول"
                    .Add("ShomarehRahgiri", , EnumFieldOptions.foDefault).Caption = "بچ"
                    .Add("UID", , EnumFieldOptions.foDefault)
                    .Add("IRC", , EnumFieldOptions.foDefault)
                    .Add("GTIN", , EnumFieldOptions.foDefault)
                    .Add("Tozih", , EnumFieldOptions.foDefault).Caption = "توضیحات"
                    .Add("DeviceRegisterTime", , EnumFieldOptions.foDefault).Caption = "زمان اسکن بارکدخوان"
                    .Add("TransferToDbTime", , EnumFieldOptions.foDefault).Caption = "زمان انتقال ثبت بارکدخوان به سیستم انبار"
                    .Add("TransferToAnbarTime", , EnumFieldOptions.foDefault).Caption = "زمان ثبت رسید انبار"
                End With

            End With
        Else
            sstChild.TabPages.Remove(TabProductCatalogue)
        End If

        If ShowTabSanadHaFactor Then
            DVabSanadHaFactor = New CDataView(cn)
            With DVabSanadHaFactor
                .Init(PnlGSanadHaFactor, , , , EnumButtonOptions.boCmdRefresh + EnumButtonOptions.boCmdFilter)
                .TableName = "abvw_SanadHaFactor"
                .AccessRight = EnumAccessRight.arAll
                .EditInGrid = False
                .SQLOrderBy = "Tartib"
                With .Fields
                    .Add("SanadhaSN", , If(gSM.IsProgrammer, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                    .Add("FactorHaSN", , If(gSM.IsProgrammer, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                    .Add("ErrorMessage", , EnumFieldOptions.foDefault).Caption = "خطا"
                    .Add("Tartib", , EnumFieldOptions.foDefault).Caption = "ترتیب"
                    .Add("KalaDS", , EnumFieldOptions.foDefault).Caption = "محصول"
                    .Add("ShomarehRahgiri", , EnumFieldOptions.foDefault).Caption = "رهگیری"
                    .Add("TedadAjza", , EnumFieldOptions.foDefault).Caption = "تعداد در کارتن"
                    '.Add("SanadType", , EnumFieldOptions.foDefault)
                    .Add("SanadTypeDS", , EnumFieldOptions.foDefault).Caption = "نوع سند"
                    .Add("MoshtariFullName", , EnumFieldOptions.foDefault).Caption = "مشتری"
                    .Add("FactorNo", , EnumFieldOptions.foDefault).Caption = "شماره فاکتور"
                    .Add("SodoorDate", , EnumFieldOptions.foDefault).Caption = "تاریخ فاکتور"
                    .Add("TedadKol", , EnumFieldOptions.foDefault).Caption = "تعداد کل"
                    .Add("Karton", , EnumFieldOptions.foDefault).Caption = "کارتن"
                    .Add("Adad", , EnumFieldOptions.foDefault).Caption = "عدد"

                End With

            End With
        Else
            sstChild.TabPages.Remove(TabSanadHaFactor)
        End If


    End Sub

    Private Sub InitForm()
        ' بر اساس نوع درخواست نمايش فرم نام فرم تنظيم ميگردد
        ' property -> NoeTarakoneshSN
        sstParent.SelectedIndex = 0
        Select Case NoeTarakoneshSN
            Case EnumNoeTarakoneshSN.ntRESIDHA
                Me.Text = " عمليات رسيد ها "
            Case EnumNoeTarakoneshSN.ntHAVALEHHA
                Me.Text = " عمليات حواله ها "
            Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                Me.Text = " عمليات موجودي اول دوره "
            Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                Me.Text = If(IsVahedTejariTolidi, "رسید مرجوعی فاکتور", "رسيد مرجوعي از توزيع")
            Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                Me.Text = "کسري موجودي انبار"
            Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                Me.Text = "اضافي موجودي انبار"
            Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                Me.Text = "اصلاحي افزاينده"
            Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                Me.Text = "اصلاحي کاهنده"
            Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                Me.Text = "حواله کاهنده خرید"
            Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                Me.Text = "حواله کسری دریافت از شرکتهای گروه"
            Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                Me.Text = "حواله اضافه ارسال به شرکتهای گروه"
            Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                Me.Text = "رسید کسری ارسال به شرکتهای گروه"
            Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                Me.Text = "رسید اضافه دریافت از شرکتهای گروه"
            Case EnumNoeTarakoneshSN.ntHAVALEHFOROOSHMAVADVABASTEHBANDI
                Me.Text = "حواله فروش مواد اولیه و بسته بندی"
            Case Else
                Me.Text = "????"
        End Select
        DVabSanad.Text = Me.Text
        DVabSanadHa.Text = Me.Text
        pnlG1.SetBounds(0, 0, sstChild.Width, pnlC1.Top)

        Dim _ClsDataAccessRule As New ClsDataAccessRule

        DvGorohTafsiliAccess = _ClsDataAccessRule.GetGoroohTafsiliTarakonesh(gNoeAnbarSN, cn, tp)

    End Sub

    Public Function GetTafsilisnAccess(Tarakonesh As Integer) As Boolean
        Try
            'Dim i As Integer
            Dim dv As DataView = DvGorohTafsiliAccess
            dv.RowFilter = "TarakoneshSN=" & Tarakonesh & "And GoroohTafsiliSn2 <> 0"

            GetTafsilisnAccess = False
            If dv.Count <> 0 Then
                GetTafsilisnAccess = True
            End If
            'For i = 0 To dv.Count - 1
            '    If dv(i)("Tarakoneshsn") = Tarakonesh And dv(i)("GoroohTafsiliSn2") <> 0 Then
            '        GetTafsilisnAccess = True
            '        Exit For
            '    End If
            'Next

            'Return GetTafsilisnAccess

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Private Sub EnableFields()
        ' با توجه به تراکنش رکورد فعال ستونهاي گريد سند و اقلام سند را تنظيم ميکند
        ' Property -> TarakoneshSN
        Dim vAddField_abSanad As EnumAddField_abSanad
        Dim vAddField_abSanadHa As EnumAddField_abSanadHa
        Dim vMarja_TarakoneshSN As EnumTarakoneshSN

        DVabSanad.Fields("TafsiliSn2").AllowNulls = True


        If gNoeAnbarSN = 0 Then
            dbcNoeAnbarSN.Visible = True : lblNoeAnbarSN.Visible = True
        Else
            dbcNoeAnbarSN.Visible = False : lblNoeAnbarSN.Visible = False
        End If


        Call ReadFieldsProperties(CInt(TarakoneshSN))

        With DVabSanadHa
            With .FlexGrid
                ' کنترل نمايش ستونها در مورد انبار با ماهيت واحد سنجش و انبار با ماهيت تعداد در کارتن
                If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Or VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh Then
                    dvTarakonesh.RowFilter = "0=0"
                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareVaredeh'"
                        .ColHidden(.ColIndex("Box_in")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("Can_in")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        If ShowTabChideman Then
                            DVabSanadHaChideman.FlexGrid.ColHidden(DVabSanadHaChideman.FlexGrid.ColIndex("MeghdareVaredeh")) = DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("Box_in"))
                        End If

                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار وارده مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                   + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                   MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار وارده")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try

                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareSadereh'"
                        .ColHidden(.ColIndex("Box_out")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("Can_out")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        If ShowTabChideman Then
                            DVabSanadHaChideman.FlexGrid.ColHidden(DVabSanadHaChideman.FlexGrid.ColIndex("MeghdareSadereh")) = DVabSanadHa.FlexGrid.ColHidden(DVabSanadHa.FlexGrid.ColIndex("Box_out"))
                        End If
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار صادره مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                  + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                  MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار وارده")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try
                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_TedadAjza")) = VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_VahedeSanjeshDs")) = VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton
                Else
                    .ColHidden(.ColIndex("Box_in")) = True
                    .ColHidden(.ColIndex("Can_in")) = True
                    .ColHidden(.ColIndex("Box_out")) = True
                    .ColHidden(.ColIndex("Can_out")) = True
                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_TedadAjza")) = True
                    .ColHidden(.ColIndex("paVw_VahedeSanjesh_VahedeSanjeshDs")) = True
                End If

                Try
                    dvTarakonesh.RowFilter = "0=0"
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaGorooheKalaSN'"
                    .ColHidden(.ColIndex("GorooheKalaSN")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون GorooheKalaSN مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                  + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                  MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون GorooheKalaSN")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaTartib'"
                    .ColHidden(.ColIndex("Tartib")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون ترتیب مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                 + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                 MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون ترتیب")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try
                'ToDo : Romove For More Run SPeed
                If QuickActionOnAbSanadHa Then
                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareDarkhasti'"
                        .ColHidden(.ColIndex("MeghdareDarkhasti")) = Not CBool(dvTarakonesh(0)("Visible"))
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار درخواستی مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                     + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                     MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار درخواستی")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try
                End If

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareVaredeh'"
                    .ColHidden(.ColIndex("MeghdareVaredeh")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton)
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار وارده مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                               + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                               MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار وارده")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaGheymateVaredeh'"
                    .ColHidden(.ColIndex("GheymateVaredeh")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون قیمت وارده مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                               + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                               MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون قیمت وارده")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareSadereh'"
                    .ColHidden(.ColIndex("MeghdareSadereh")) = If(Not CBool(dvTarakonesh(0)("Visible")), True, VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton)
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار صادره مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                           + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار صادره")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaGheymateSadereh'"
                    .ColHidden(.ColIndex("GheymateSadereh")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون قیمت صادره مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                          + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                          MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون قیمت صادره")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaNoeZayeatSN'"
                    .ColHidden(.ColIndex("paNoeZayeat_NoeZayeatSN")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون نوع ضایعات مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                          + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                          MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون نوع ضایعات")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaNoeMarjooeiSN'"
                    .ColHidden(.ColIndex("paNoeMarjooei_NoeMarjooeiSN")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون نوع مرجوعی مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                         + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                         MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون نوع مرجوعی")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaNoeMadomiSN'"
                    .ColHidden(.ColIndex("paNoeMadomi_NoeMadomiSN")) = Not CBool(dvTarakonesh(0)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون نوع معدومی مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                         + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                         MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون نوع معدومی")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try


                If (gNoeAnbarSN = 1 Or gNoeAnbarSN = 4) Then

                    '' If gNoeAnbarSN = 1 Then
                    dvTarakonesh.RowFilter = "0=0"
                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaMeghdareNakhales'"
                        .ColHidden(.ColIndex("MeghdareNakhales")) = Not CBool(dvTarakonesh(0)("Visible"))
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار ناخالص مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                         + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                         MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار ناخالص")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try

                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaTafsiliSN1'"
                        .ColHidden(.ColIndex("TafsiliSN1")) = Not CBool(dvTarakonesh(0)("Visible"))
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون tafsiliSN1 مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون tafsiliSN1")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try

                Else
                    .ColHidden(.ColIndex("MeghdareNakhales")) = True
                    .ColHidden(.ColIndex("TafsiliSN1")) = True
                End If


                '//
                If CInt(TarakoneshSN) < 50 Then
                    .ColHidden(.ColIndex("ToolidDate_Text")) = 0
                    .ColHidden(.ColIndex("EnghezaDate_Text")) = 0
                    '.ColHidden(.ColIndex("KalaPhizikiToolidEnghezaDate")) = 1
                Else
                    .ColHidden(.ColIndex("ToolidDate_Text")) = 1
                    .ColHidden(.ColIndex("EnghezaDate_Text")) = 1
                    '.ColHidden(.ColIndex("KalaPhizikiToolidEnghezaDate")) = 0
                End If
                '//
                'ToDo : Romove For More Run SPeed
                If QuickActionOnAbSanadHa Then
                    '-------------------Add by yekta 920228
                    If (Val(DVabSanad.FieldValue("AbAnbarTarakonesh_RezDC")) = 1 Or Val(DVabSanad.FieldValue("AbAnbarTarakonesh2_RezDC")) = 1) And (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Then
                        .ColHidden(.ColIndex("abVw_abResidWithoutDarkhast_MandehResid")) = False
                    Else
                        .ColHidden(.ColIndex("abVw_abResidWithoutDarkhast_MandehResid")) = True
                    End If
                End If

                '-------------------Add by yekta 920228

                '-------------------Add by yekta 920814
                Try
                    gNoeAnbarForNamayesheBatchNoAndTozih = IIf(CApp.GetAppConfig("gIsNamayesheBatchNoAndTozih") Is System.DBNull.Value, 0, CApp.GetAppConfig("gIsNamayesheBatchNoAndTozih"))
                Catch ex As Exception
                End Try
                '------Add by yekta 920826----
                Try
                    Dim dvNoeAnbar As New DataView
                    Dim i As Integer
                    dvNoeAnbar = cn.ExecuteQuery("select NoeAnbarSN  from abNoeAnbar where NoeAnbarSN in (" & gNoeAnbarForNamayesheBatchNoAndTozih & ")")
                    For i = 0 To dvNoeAnbar.Count - 1
                        If (DVabSanad.Fields("NoeAnbarSN").Value) = Val(dvNoeAnbar.Item(i).Item(0)).ToString() Then
                            gIsNamayesheBatchNoAndTozih = True
                        End If
                    Next
                Catch ex As Exception

                End Try
                '------Add by yekta 920826---- change by yekta 921108
                ''ghasemi 14020127  --- 14020908  add RESIDE_BARGASHT_KALAE_AMANI 
                If (gIsNamayesheBatchNoAndTozih = True _
                    And (TarakoneshSN = EnumTarakoneshSN.RESIDE_01_KHARIDE_DAKHELI Or TarakoneshSN = EnumTarakoneshSN.RESIDE_02_KHARIDE_KHAREJI Or TarakoneshSN = EnumTarakoneshSN.RESIDE_35_Kalae_Nemooneh Or TarakoneshSN = EnumTarakoneshSN.RESIDE_DARYAFTE_KALAE_AMANI _
                     Or TarakoneshSN = EnumTarakoneshSN.MOJOODIE_44_AVALE_DOREH Or TarakoneshSN = EnumTarakoneshSN.RESIDE_BARGASHT_KALAE_AMANI)) Then

                    .ColHidden(.ColIndex("abKalaPhizikiControl_BatchNO")) = False
                    .ColHidden(.ColIndex("abKalaPhizikiControl_Tozih")) = False
                    .ColHidden(.ColIndex("NoeEngheza")) = False
                    BtnUpdateBatchNoeEngheza.Visible = True
                Else
                    .ColHidden(.ColIndex("abKalaPhizikiControl_BatchNO")) = True
                    .ColHidden(.ColIndex("abKalaPhizikiControl_Tozih")) = True
                    .ColHidden(.ColIndex("NoeEngheza")) = True
                    .ColHidden(.ColIndex("IsNewSource")) = True
                    BtnUpdateBatchNoeEngheza.Visible = False
                End If
                '-------------------Add by yekta 920814---  change by yekta 921108


                ''Add By Dehghani - 14000122 - ست کردن تنظیمات برای نمایش ستون سورس جدید روی دیتیل فرم اسناد
                If IsCompanyUseQcApp Then
                    .ColHidden(.ColIndex("IsNewSource")) = False
                Else
                    .ColHidden(.ColIndex("IsNewSource")) = True
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'ToDo : Romove For More Run SPeed
                If QuickActionOnAbSanadHa Then
                    If (Val(DVabSanad.FieldValue("AbAnbarTarakonesh_RezDC")) = 1 Or Val(DVabSanad.FieldValue("AbAnbarTarakonesh2_RezDC")) = 1) Then '(NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or EnumNoeTarakoneshSN.ntRESIDHA Or _
                        '(NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEBARGASHTI And Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) < 50) Or _
                        '(NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI And Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) < 50)) And _
                        .ColHidden(.ColIndex("abVw_DarkhastHayeTadarokat_mojavezErsalHaSN")) = False
                    Else
                        .ColHidden(.ColIndex("abVw_DarkhastHayeTadarokat_mojavezErsalHaSN")) = True
                    End If
                End If


                'If (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA Or _
                '  (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEBARGASHTI And Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) > 50) Or _
                '  (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI And Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) > 50)) And _
                '  (Val(DVabSanad.FieldValue("AbAnbarTarakonesh_RezDC")) = 1 Or Val(DVabSanad.FieldValue("AbAnbarTarakonesh2_RezDC")) = 1) Then
                '.ColHidden(.ColIndex("abvw_darkhast_DarkhastHaSN")) = False
                'Else
                'ToDo : Romove For More Run SPeed
                If QuickActionOnAbSanadHa Then
                    dvTarakonesh.RowFilter = "0=0"
                    Try
                        dvTarakonesh.RowFilter = "ObjectDS = 'abSanadHaDarkhastHaSN'"
                        .ColHidden(.ColIndex("abvw_darkhast_DarkhastHaSN")) = Not CBool(dvTarakonesh(0)("Visible"))
                    Catch ex As Exception
                        NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن ستون مقدار ناخالص مرتبط با تراکنش " & TarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                         + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                         MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش ستون مقدار ناخالص")
                    Finally
                        dvTarakonesh.RowFilter = "0=0"
                    End Try
                End If
                'End If

                ''تراکنش هایی که اجازه ورود ماهیت کالا دارند
                '.ColHidden(.ColIndex("paMahiatKala_MahiatKala")) = Not IsTarakoneshInGorooh(TarakoneshSN, 21)
                '.ColWidth(.ColIndex("paMahiatKala_MahiatKala")) = 200

                '''فعال کردن دکمه ثبت سند در سامانه  ghasemi 14001028

                'btnSabtSanaddarSamaneh.Enabled = (gSM.ActionEnabled(btnSabtSanaddarSamaneh.Name) = True) And Val(DVabSanad.FieldValue("SanadStatus")) = 8
                'btnSabtSanaddarSamaneh.Visible = (gSM.ActionVisible(btnSabtSanaddarSamaneh.Name) = True) And Val(DVabSanad.FieldValue("SanadStatus")) = 8
                '''ghasemi
                '''

            End With
        End With

        ' شرط پيش فرض براي حالتهاي خاص مورد نياز
        ' ComboWhereCondition
        Select Case TarakoneshSN
            Case EnumTarakoneshSN.RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
                ', EnumTarakoneshSN.RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB
                DVabSanad.Fields("EDAnbarSN").ComboWhereCondition = " ( ISNULL(abAnbar2.AnbarStatus,0) = 1 )" &
                    " AND ( ISNULL(abAnbar2.IsTajmie,0) <> 1  )" &
                    " AND abAnbar2.VahedeTejariSN  = " & CStr(gVahedeTejariSN)

            Case EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
            , EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA _
                ', EnumTarakoneshSN.HAVALEH_83_BARGASHTE_AZ_ANBAR_BE_ANBAR
                DVabSanad.Fields("EDAnbarSN").ComboWhereCondition = " ( ISNULL(abAnbar2.AnbarStatus,0) = 1 ) " &
                     " AND ( ISNULL(abAnbar2.IsTajmie,0) <> 1  ) " &
                     " AND abAnbar2.VahedeTejariSN  = " & CStr(gVahedeTejariSN)

        End Select
        ' ComboWhereCondition

        'ashari 850224
        'If TarakoneshSN = EnumTarakoneshSN.RESIDE_38_MARJOOEI_AZ_FOROOSH Or _
        '   TarakoneshSN = EnumTarakoneshSN.RESIDE_39_MARJOOEI_AZ_TOZIE Then
        '    dbcTarafHesabSN.Enabled = False
        'Else
        '    dbcTarafHesabSN.Enabled = True
        'End If


        If (TarakoneshSN = EnumTarakoneshSN.RESIDE_41_DARYAFT_AS_Co_GOROOH _
         Or Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) = EnumTarakoneshSN.RESIDE_41_DARYAFT_AS_Co_GOROOH _
         Or Val(DVabSanad.FieldValue("MarjaTarakoneshSN")) = EnumTarakoneshSN.HAVALEH_91_TAHVIL_BE_Co_GOROOH) _
         And Val(DVabSanad.FieldValue("NoeSanadID")) = 2 And Val(DVabSanad.FieldValue("SanadSN")) > 0 Then
            dbcTarafHesabSN.Enabled = False
            txtShomarehSefaresh.ReadOnly = True
        Else
            dbcTarafHesabSN.Enabled = True
            txtShomarehSefaresh.ReadOnly = False
        End If

        'Dim btnEslahSanadInfoVisible As Boolean = (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehBarnameh) Or (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehMashin) Or (vAddField_abSanad And EnumAddField_abSanad.afAddsVazneBaskool) Or (vAddField_abSanad And EnumAddField_abSanad.afAddsNameRanandeh) Or (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehSefaresh)
        Dim btnEslahSanadInfoVisible As Boolean = vVisibleNameRanandeh Or vVisibleShomarehBarnameh Or vVisibleShomarehMashin Or vVisibleShomarehSefaresh Or vVisibleVazneBaskool

        btnEslahSanad.Enabled = btnEslahSanadInfoVisible And (gSM.TableAccessRight("EslahSanadInfo") = EnumAccessRight.arAll) And Val(DVabSanad.FieldValue("SanadStatus")) = 8
        btnEslahSanad.Visible = btnEslahSanadInfoVisible And (gSM.TableAccessRight("EslahSanadInfo") = EnumAccessRight.arAll) And Val(DVabSanad.FieldValue("SanadStatus")) = 8


        'vVisibleNameRanandeh = (vAddField_abSanad And EnumAddField_abSanad.afAddsNameRanandeh)
        'vVisibleShomarehBarnameh = (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehBarnameh)
        'vVisibleShomarehMashin = (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehMashin)
        'vVisibleVazneBaskool = (vAddField_abSanad And EnumAddField_abSanad.afAddsVazneBaskool)
        'vVisibleShomarehSefaresh = (vAddField_abSanad And EnumAddField_abSanad.afAddsShomarehSefaresh)



    End Sub

    Private Sub ReadFieldsProperties(ByVal tarakoneshSN As Integer)

        ''Add By Dehghani - 930423

        Dim flag As Boolean = False

        If SelectedTarakonesh <> tarakoneshSN Then
            Dim _ClsDataAccessRule As New ClsDataAccessRule

            dvTarakonesh = _ClsDataAccessRule.ReadFieldsProperties(tarakoneshSN, gAnbarSN, gVahedeTejariSN, cn)

            If Not dvTarakonesh Is Nothing AndAlso dvTarakonesh.Count > 0 Then

                For j As Integer = 0 To dvTarakonesh.Count - 1

                    If dvTarakonesh(j)("ObjectDS").ToString.ToUpper.StartsWith("abSanadHa".ToUpper) Then

                        If Not DVabSanadHa.FlexGrid.ColumnCollection.Item(dvTarakonesh(j)("ObjectDS").ToString.Substring(9)) Is Nothing Then
                            If dvTarakonesh(j)("ObjectDS").ToString.ToUpper = "abSanadHaSanadHaSN".ToUpper Then
                                DVabSanadHa.FlexGrid.ColumnCollection.Item(dvTarakonesh(j)("ObjectDS").ToString.Substring(9)).Visible = gSM.IsAppSSAdmin OrElse gSM.IsProgrammer OrElse gSM.IsSupervisor
                            Else
                                DVabSanadHa.FlexGrid.ColumnCollection.Item(dvTarakonesh(j)("ObjectDS").ToString.Substring(9)).Visible = CBool(dvTarakonesh(j)("Visible"))
                            End If
                        End If

                    Else

                        For Each FormControls As System.Windows.Forms.Control In Me.ControlsArray

                            If FormControls.Name.ToUpper = dvTarakonesh(j)("ObjectDS").ToString.ToUpper Then
                                FormControls.Visible = CBool(dvTarakonesh(j)("Visible"))
                                FormControls.Enabled = CBool(dvTarakonesh(j)("Enable"))
                            End If
                        Next

                    End If

                Next

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('txtNameRanandeh','lblNameRanandeh')"
                    vVisibleNameRanandeh = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت نام راننده مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت نام راننده")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('LblForooshDarkhast','DcbForooshDarkhast')"
                    LblForooshDarkhast.Visible = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                    DcbForooshDarkhast.Visible = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                    DcbForooshDarkhast.Enabled = CBool(dvTarakonesh(0)("Enable")) Or CBool(dvTarakonesh(1)("Enable"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت شماره درخواست فروش مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت دفتر فروش")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('lblRezSN2','dbcRezSN2')"
                    lblRezSN2.Visible = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                    dbcRezSN2.Visible = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                    dbcRezSN2.Enabled = CBool(dvTarakonesh(0)("Enable")) Or CBool(dvTarakonesh(1)("Enable"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت دفتر فروش مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت دفتر فروش")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try


                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('txtShomarehBarnameh','lblShomarehBarnameh')"
                    vVisibleShomarehBarnameh = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت شماره بارنامه مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت شماره بارنامه")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('txtShomarehMashin','lblShomarehMashin')"
                    vVisibleShomarehMashin = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت شماره ماشین مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت شماره ماشین")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('txtVazneBaskool','lblVazneBaskool')"
                    vVisibleVazneBaskool = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت وزن باسکول مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت وزن باسکول")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try

                Try
                    dvTarakonesh.RowFilter = "ObjectDS in ('txtShomarehSefaresh','lblShomarehSefaresh')"
                    vVisibleShomarehSefaresh = CBool(dvTarakonesh(0)("Visible")) Or CBool(dvTarakonesh(1)("Visible"))
                Catch ex As Exception
                    NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن آبجکت شماره سفارش مرتبط با تراکنش " & tarakoneshSN & " در " & gAnbarDS & "  تعریف نشده است." _
                                        + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                        MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت شماره سفارش")
                Finally
                    dvTarakonesh.RowFilter = "0=0"
                End Try


            Else
                NetSql.Common.CSystem.MsgBox("نمایش/فعال بودن کلیه آبجکت های مرتبط با تراکنش " & tarakoneshSN & " در  " & gAnbarDS & " تعریف نشده است." _
                                             + vbCr + "لطفا با پشتیبان سیستم تماس بگیرید.",
                                             MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "نمایش آبجکت ها")
            End If

            SelectedTarakonesh = tarakoneshSN
            ''Add By Dehghani - 930423
        End If

    End Sub

    Private Sub DarjeAsanDArkhast(_ArrSel As Object, SanadSN As Decimal, KalaPhizikiStatusSN As Int16, vKalaSN As Decimal, vRahgiri As String, vNakhales As Decimal, vZarf As Decimal, vToolidDate As String, vEnghezaDate As String, vSanadHaSN As Decimal)

        Dim _Darkhast As Decimal = 0
        Dim _Meghdar As Decimal = 0

        Dim i, k As Integer
        k = _ArrSel.length / 2

        If gIsF8InTabDarkhast Then
            'For i = 0 To k - 1
            '    _Darkhast = _ArrSel(i, 0)
            '    _Meghdar = _ArrSel(i, 1)
            '    If _Darkhast <> 0 Or _Meghdar <> 0 Then
            '        InsertSanadhaDarkhast(_Darkhast, _Meghdar, vSanadHaSN)   ' change by yekta 920214
            '    End If
            'Next

        End If


        '------------By Yekta 920214 ------------------------------------------------
        'Dim vSanadHaSN As Decimal = 0
        Dim _AllMeghdar As Decimal = 0
        For i = 0 To k - 1
            _Darkhast = _ArrSel(i, 0)
            _Meghdar = _ArrSel(i, 1)
            If _Darkhast <> 0 Or _Meghdar <> 0 Then
                _AllMeghdar = _AllMeghdar + _ArrSel(i, 1)
            End If
        Next
        '---comment by yekta 920416-----
        'vSanadHaSN = InsertDarkhastBI(_Darkhast, _AllMeghdar, SanadSN, KalaPhizikiStatusSN, vKalaSN, vRahgiri, vNakhales, vZarf, vToolidDate, vEnghezaDate)

        '------------By Yekta 920214 ------------------------------------------------
        For i = 0 To k - 1
            _Darkhast = _ArrSel(i, 0)
            _Meghdar = _ArrSel(i, 1)
            If _Darkhast <> 0 Or _Meghdar <> 0 Then
                InsertSanadhaDarkhast(_Darkhast, _Meghdar, vSanadHaSN)   ' change by yekta 920214 
            End If
        Next

    End Sub

    Private Sub InsertSanadhaDarkhast(_Darkhast As Decimal, _Meghdar As Decimal, SanadHaSN As Decimal)  ' create by yekta 920214
        Try

            'Dim InsertSPUserParam As String = ""
            'InsertSPUserParam = gSM.Identifier & ";" & vRahgiri & ";" & CStr(KalaPhizikiStatusSN) & _
            ' ";" & CStr(gVahedeTejariSN) & ";" & CStr(gAnbarSN) & ";" & CStr(gNoeAnbarSN)
            Dim i As Integer = 1
            Dim vSanadHaDarkhastSN As Decimal = gSM.Identifier
            cn.CallSP("_abSanadHaDarkhast_Insertx", vSanadHaDarkhastSN,
            SanadHaSN, _Darkhast, _Meghdar,
            gSM.UserID_Name, System.Environment.MachineName, DBNull.Value)

        Catch ex As Exception

        End Try
    End Sub

    Private Function InsertDarkhastBI(_Darkhast As Decimal, _Meghdar As Decimal, SanadSN As Decimal, KalaPhizikiStatusSN As Int16, vKalaSN As Decimal, vRahgiri As String, vNakhales As Decimal, vZarf As Decimal, vToolidDate As String, vEnghezaDate As String) As Decimal  ' change by yekta 920214

        Try

            Dim InsertSPUserParam As String = ""
            Dim vSanadHaSN As Decimal = gSM.Identifier

            InsertSPUserParam = gSM.Identifier & ";" & vRahgiri & ";" & CStr(KalaPhizikiStatusSN) &
             ";" & CStr(gVahedeTejariSN) & ";" & CStr(gAnbarSN) & ";" & CStr(gNoeAnbarSN)

            cn.CallSP("_absanadha_InsertX", vSanadHaSN,
            SanadSN, DBNull.Value, DBNull.Value, vKalaSN, DBNull.Value, DBNull.Value,
            _Meghdar, DBNull.Value, DBNull.Value, DBNull.Value, vNakhales, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            gSM.UserID_Name, System.Environment.MachineName, DBNull.Value, vToolidDate, vEnghezaDate, DBNull.Value, InsertSPUserParam)
            Return vSanadHaSN

        Catch ex As Exception

        End Try
    End Function

    Public Shared Function GetKalaMojoodiKoli(ByRef cn As NetSql.DB.CConnection, ByVal VahrdetejariSN As Double, ByVal AnbarSN As Double, ByVal KalaSN As Double, ByVal TDate As String) As Double
        Dim DVServer As DataView
        Dim Result As String = ""
        Dim params(3) As Object
        Try


            params(0) = VahrdetejariSN
            params(1) = AnbarSN
            params(2) = KalaSN
            params(3) = TDate

            'DVServer = cn.ExecuteQuery("_mwSPG_GetServer " & CStr(VahrdetejariSN))
            'If DVServer Is Nothing Or DVServer.Count <= 0 Then
            '    Throw New Exception("سرور مقصد يافت نشد")
            'End If

            Dim WS As New WebService
            'Dim WebServiceResult As New DataSet

            Dim _mojoodi As Double = WS.CallWebMetod("STD", "MinooAnbarWebService", "AnbarWebService", "GetKalaMojoodiKoli", params)

            Return _mojoodi ''' WebServiceResult.Tables(0).Rows(0).Item(1)


        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

#Region "Forms"

    Private Sub FrmSanad_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        Dim vSelect As String
        sstParent.Mirrored = True
        sstChild.Mirrored = True
        mTarakoneshSN = NoeTarakoneshSN
        MinFilterDateCtrl = New NetSql.Components.CDateCtrl(tp)
        MinFilterDateCtrl.TextBox = txtMinDate


        If (NoeAccessRight = "mnuResidDarAnbarQC") Then
            Dim dv As DataView = cn.ExecuteQuery("Select  Top (1) ISnull(QCPairAnbarSN,0) QCPairAnbarSN from abAnbar Where AnbarSN =" & gAnbarSN)
            Dim query = "Select  Top (1) ISnull(QCPairAnbarSN,0) QCPairAnbarSN from abAnbar Where AnbarSN =" & gAnbarSN
            If dv.Count <> 0 And Not dv(0)("QCPairAnbarSN") Is Nothing And dv(0)("QCPairAnbarSN") <> 0 Then
                gAnbarSN = dv(0)("QCPairAnbarSN")
                'gNoeAnbarSN = 1
            Else
                NetSql.Common.CSystem.MsgBox("انبار قرنطینه متناظر با این انبار تعریف نشده است.", MsgBoxStyle.Exclamation, "خطای تعریف اطلاعات انبار")
                Exit Sub
            End If
        End If

        IsTolidi = IsVahedTejariTolidi

        IsStandard = IIf(CApp.GetAppConfig("gCountNerkhGhati") Is System.DBNull.Value, False, True)

        Dim MarjooeiObject As Object = CApp.GetAppConfig("gMohlateSabteResideMarjooeiAzForooshAzTarikheFactor")
        If IsNumeric(MarjooeiObject) Then
            VahedeTejariMohlatMarjooeiForoosh = CInt(MarjooeiObject)
        End If
        MarjooeiObject = CApp.GetAppConfig("gMohlateSabteResideMarjooeiAzToziAzTarikheFactor")
        If IsNumeric(MarjooeiObject) Then
            VahedeTejariMohlatMarjooeiTozie = CInt(MarjooeiObject)
        End If

        GVahedeTejariUsesKartablZayeat = If(CApp.GetAppConfig("GVahedeTejariUsesKartablZayeat") Is System.DBNull.Value, False, True)
        IsVahedeTejariUseFodarkhastonSanad = If(CApp.GetAppConfig("gVahedeTejariUsefoDarkhastOnabSanad") Is System.DBNull.Value, False, CApp.GetAppConfig("gVahedeTejariUsefoDarkhastOnabSanad"))
        ChkAutoTransferToKartablZayeat.Visible = GVahedeTejariUsesKartablZayeat
        ChkIsFakorEbtal.Visible = GVahedeTejariUsesKartablZayeat And NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
        IsVahedeTejariSabtUIDonSanad = If(CApp.GetAppConfig("gVahedeTejariUseUIDForSabtHavaleh") Is System.DBNull.Value, False, CApp.GetAppConfig("gVahedeTejariUseUIDForSabtHavaleh"))
        BtnSabtUID.Visible = IsVahedeTejariSabtUIDonSanad
        If IsVahedeTejariSabtUIDonSanad Then
            dvKalaUseUID = cn.ExecuteQuery("select Distinct KalaSN from abKalaParameter Where isnull(IsUID_UsedInSanad,0)=1")
        End If

        ''ghasemi14020216
        Dim gAnbarDarkhast1 As String = (CApp.GetAppConfig("gAnbarDarkhast").ToString())
        Dim gAnbarDarkhast2 As Boolean = If(gAnbarDarkhast1 Is System.DBNull.Value, False, gAnbarDarkhast1.Contains(gAnbarSN))
        ''Dehghani - 960221 - تعریف Config برای اقزایش سرعت درج اقلام سند 
        QuickActionOnAbSanadHa = IsTolidi Or (gAnbarDarkhast2 And Not gSM.ActionEnabled("QuickInsUpdOnAbSanadHa"))
        ShowDaftarForoosh = IIf(CApp.GetAppConfig("gTafkikByDaftarForoosh") Is System.DBNull.Value, False, CApp.GetAppConfig("gTafkikByDaftarForoosh"))
        sstChild.TabPages.Remove(TabDaftar)
        ShowTabChideman = IIf(CApp.GetAppConfig("UseChidemanAnbar") Is System.DBNull.Value, False, CApp.GetAppConfig("UseChidemanAnbar"))
        ShowTabSanadHaDarkhast = IIf(CApp.GetAppConfig("gUseAbSanadHaDarkhast") Is System.DBNull.Value, False, CApp.GetAppConfig("gUseAbSanadHaDarkhast"))
        ShowTabProductCatalogue = IIf(CApp.GetAppConfig("gVahedeTejariUseBarcodeReaderForSabtResid") Is System.DBNull.Value, False, CApp.GetAppConfig("gVahedeTejariUseBarcodeReaderForSabtResid"))
        ShowTabSanadHaFactor = IIf(NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA, True, False) And Not IsTolidi

        Call InitDataView()
        Call InitForm()
        DVabSanad.Refresh()

        If gNoeAnbarSN = 0 Then
            dbcNoeAnbarSN.Visible = True : lblNoeAnbarSN.Visible = True
        Else
            dbcNoeAnbarSN.Visible = False : lblNoeAnbarSN.Visible = False
        End If


        Select Case NoeTarakoneshSN
            Case EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH
                btnStatus4_8.Visible = (gSM.TableAccessRight("AvalDoreh_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("AvalDoreh_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDHA
                btnStatus4_8.Visible = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE
                btnStatus4_8.Visible = (gSM.TableAccessRight("Resid_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("Resid_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHHA
                btnStatus4_8.Visible = (gSM.TableAccessRight("Havaleh_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("Havaleh_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar
                btnStatus4_8.Visible = (gSM.TableAccessRight("EzafiMojoodiAnbar_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("EzafiMojoodiAnbar_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntKasriMojoodiAnbar
                btnStatus4_8.Visible = (gSM.TableAccessRight("KasriMojoodiAnbar_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("KasriMojoodiAnbar_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDEBARGASHTI
                btnStatus4_8.Visible = (gSM.TableAccessRight("ResideBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("ResideBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI
                btnStatus4_8.Visible = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)

            Case EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID
                btnStatus4_8.Visible = (gSM.TableAccessRight("HavalehKahandehKharid_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("HavalehKahandehKharid_1_4") = EnumAccessRight.arAll)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT
                btnStatus4_8.Visible = (gSM.TableAccessRight("ResideBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("ResideBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntRESIDKASRIERSAL
                btnStatus4_8.Visible = (gSM.TableAccessRight("ResideBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("ResideBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                btnStatus4_8.Visible = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
            Case EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL
                btnStatus4_8.Visible = (gSM.TableAccessRight("HavalehBargashti_4_8") = EnumAccessRight.arAll)
                btnStatus1_4.Visible = (gSM.TableAccessRight("HavalehBargashti_1_4") = EnumAccessRight.arAll)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Case Else
                btnStatus4_8.Visible = False
                btnStatus1_4.Visible = False
        End Select

        If DVabSanad.DataRows >= 1 Then
            DVabSanad.FlexGrid.Row = 1
        End If


        vSelect = " SELECT NoeMarjooeiSN , NoeMarjooeiNO , NoeMarjooeiNO + '-' + NoeMarjooeiDS AS NoeMarjooeiDS From paNoeMarjooei "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dbcNoeMarjooeiSNB.Bind(cn, vSelect, "NoeMarjooeiSN", "NoeMarjooeiDS")

        Try
            gPrintHavaleh = IIf(CApp.GetAppConfig("gPrintHavaleh") Is System.DBNull.Value, 0, CApp.GetAppConfig("gPrintHavaleh"))
        Catch ex As Exception
        End Try


        Try   'By Yekta 910431 - ADD  - بابت مجوز حمل مستقیم به تامین کنندگاه عضو گروه در مواقع استثنا
            gTaminkonandehOzvegoroohForHamleMostaghim = IIf(CApp.GetAppConfig("gTaminkonandehOzvegoroohForHamleMostaghim") Is System.DBNull.Value, 0, CApp.GetAppConfig("gTaminkonandehOzvegoroohForHamleMostaghim"))
        Catch ex As Exception
        End Try 'By Yekta 910431 - ADD
        'Call ReadFieldsProperties(CInt(NoeTarakoneshSN))


        Try ''Add By Dehghani - 14000122 - ست کردن تنظیمات برای نمایش ستون سورس جدید روی دیتیل فرم اسناد
            Dim CAppSet2 As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, 23)
            IsCompanyUseQcApp = IIf(CAppSet2.GetAppConfig("gUseQcApplication") Is System.DBNull.Value, 0, CAppSet2.GetAppConfig("gUseQcApplication"))
        Catch ex As Exception
        End Try

        GrpPrintLabel.Visible = gSM.ActionVisible("BtnPrintLable")
        BtnPrintHavalehTolid.Visible = gSM.ActionVisible(BtnPrintHavalehTolid.Name) And NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA
        BtnEnteghalMojoodi.Visible = gSM.ActionVisible(BtnEnteghalMojoodi.Name)

        DoMovaghatSanadGhatee = gSM.ActionVisible("Status_8_4")

        Me.ChkAutoTransferToKartablZayeat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkIsFakorEbtal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        ''ghasemi نمایش دکمه ثبت سند در سامانه
        Dim gNamyeshSabtDarSamaneh As Boolean = If(CApp.GetAppConfig("gNamyeshSabtDarSamaneh") Is System.DBNull.Value, False, True)

        btnSabtSanaddarSamaneh.Enabled = False
        btnSabtSanaddarSamaneh.Visible = (gSM.ActionVisible(btnSabtSanaddarSamaneh.Name) = True And gNamyeshSabtDarSamaneh = True)
        ''ghasemi

        dvTarakoneshGorooh88 = cn.ExecuteQuery("Select TarakoneshSN,TarakoneshGoroohSN from abTarakoneshGoroohHa Where TarakoneshGoroohSN IN (88)")



    End Sub

    Private Sub FrmSanad_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        MinFilterDateCtrl.Done()
        MinFilterDateCtrl = Nothing
        DVabSanadHa.Done()
        DVabSanadHa = Nothing
        DVabSanad.Done()
        DVabSanad = Nothing

        If (NoeAccessRight = "mnuResidDarAnbarQC") Then
            Dim dv As DataView = cn.ExecuteQuery("Select  Top (1) AnbarSN from abAnbar Where QCPairAnbarSN =" & gAnbarSN)
            If dv.Count <> 0 Then
                gAnbarSN = dv(0)("AnbarSN")
            End If
        End If
    End Sub

#End Region

#Region "Timer"

    Private Sub tmrF8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tmrF8.Tick
        ' فعال سازي کليد اف 8 در ثبت اقلام سند
        Dim vSelected As Object
        tmrF8.Enabled = False

        Dim vKalaSN As Decimal
        Dim vRahgiri As String
        Dim vToolidDate As String
        Dim vEnghezaDate As String
        Dim vZarf As Decimal
        Dim vNakhales As Decimal
        Dim _sanadhasn As Decimal = 0
        Dim vChidemanSN As Decimal  '-----add by yekta 940319

        '850722
        'If NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA _
        '          Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar _
        '          Or NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI Then

        '----Add by yekta 920228
        'add this condition to blew if statement
        'DVabSanadHaDarkhast.State = EnumDataViewState.bsAdd Or _
        '(DVabSanadHaDarkhast.State = EnumDataViewState.bsEdit And _
        'NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Or _
        '----Add by yekta 920228

        'TarakoneshSN = EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR Or _   '----Add this condition to blew if statement by yekta 920229

        If Not DVabSanadHa Is Nothing Then
            If DVabSanadHa.State = EnumDataViewState.bsAdd Or
                DVabSanadHaChideman.State = EnumDataViewState.bsAdd Or
                DVabSanadHaChideman.State = EnumDataViewState.bsEdit Or
                DVabSanadHaDarkhast.State = EnumDataViewState.bsAdd Or
                (DVabSanadHaDarkhast.State = EnumDataViewState.bsEdit And
                        NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Or
                (DVabSanadHa.State = EnumDataViewState.bsEdit And
                        NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA) Then
                If DVabSanadHa.Fields("KalaSN").Value <> 0 Then
                    If DVabSanadHa.Fields("KalaSN").Value <> 0 AndAlso
                        ((NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHHA And DVabSanadHa.State <> EnumDataViewState.bsNormal) Or
                         NoeTarakoneshSN = EnumNoeTarakoneshSN.ntKasriMojoodiAnbar Or
                         NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL Or
                         TarakoneshSN = EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR Or
                         NoeTarakoneshSN = EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT
                         ) Then
                        Dim vFrmSelectRahgiri As New FrmSelectRahgiri
                        With vFrmSelectRahgiri
                            .KalaSN = DVabSanadHa.Fields("KalaSN").Value
                            .MoaserDate = DVabSanad.Fields("MoaserDate").Value
                            If IsNumeric(DVabSanad.FieldValue("RezSN2")) Then
                                .DaftarForoshSN = CDec(DVabSanad.FieldValue("RezSN2"))
                            End If


                            Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
                            If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                                If mTarakoneshSN < 50 Then
                                    DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)
                                Else
                                    DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_out").Value)
                                End If
                                VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                                VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
                            End If
                            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

                            If VMeghdareSadereh <> 0 Then
                                .Meghdar = VMeghdareSadereh
                            ElseIf VMeghdareVaredeh <> 0 Then
                                .Meghdar = VMeghdareVaredeh
                            Else
                                .Meghdar = 0
                            End If

                            'If VMeghdareSadereh <> 0 Then
                            '    Dim mojoodinorez As Decimal
                            '    cn.CallSP("_abSPG_GetMojoodiWithoutRezervKala", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, DVabSanadHa.Fields("KalaSN").Value, MiladiToShamsi(Today()), mojoodinorez)
                            '    .MojoodiNorez = mojoodinorez
                            'End If

                            '//
                            .NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
                            .NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
                            .NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
                            If QuickActionOnAbSanadHa Then
                                .DarkhastHaSN = Val(DVabSanadHa.Fields("DarkhastHaSN").Value)
                                If (Val(DVabSanad.FieldValue("AbAnbarTarakonesh_RezDC")) = 1 Or Val(DVabSanad.FieldValue("AbAnbarTarakonesh2_RezDC")) = 1) Then  'by yekta 911012
                                    .MojavezErsalHaSN = Val(DVabSanadHa.Fields("MojavezErsalHaSN").Value) ' by yekta 911010
                                End If
                            End If
                            '//

                            '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
                            '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)
                            .SanadRow = cn.ExecuteQuery("Select *,abanbar.anbarsn ToAnbarSN from absanad left join abanbar on absanad.tafsilisn=abanbar.payesn where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)
                            '.SanadRow = New DataView(dv.DataSource.Table, "SanadSn = " & DVabSanad.Fields("SanadSn").Value, "", DataViewRowState.CurrentRows).Table.Rows(0)
                            '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری

                            .ShowDialog()

                            Select Case .Mode
                                Case 0 ' Cancel

                                Case 1 ' Single selection
                                    vSelected = .Selected
                                    dcbShomarehRahgiriText.Text = vSelected
                                    DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1

                                Case 2 ' Multi selection
                                    DVabSanadHa.Abort()
                                    DVabSanadHa.Refresh()
                                    DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1
                            End Select

                            .Close()
                            .Dispose()

                        End With
                        '----change by yekta 920416----
                    ElseIf DVabSanadHa.Fields("KalaSN").Value <> 0 AndAlso (NoeTarakoneshSN = EnumNoeTarakoneshSN.ntRESIDHA Or ((TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI) And DVabSanadHaDarkhast.State <> EnumDataViewState.bsNormal)) AndAlso (DVabSanadHa.State = EnumDataViewState.bsNormal) AndAlso (DVabSanadHaDarkhast.State <> EnumDataViewState.bsNormal) Then  '--- add bye yekta 940319 AndAlso (DVabSanadHa.State = EnumDataViewState.bsNormal)
                        Dim vFrmSelectDarkhast As New FrmSelectDarkhast
                        With vFrmSelectDarkhast
                            .KalaSN = DVabSanadHa.Fields("KalaSN").Value
                            .IsF8InTabDarkhast = gIsF8InTabDarkhast  ' Add By Yekta 920228
                            Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
                            If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then

                                DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)

                                VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                                VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
                            End If
                            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

                            If VMeghdareSadereh <> 0 Then
                                .Meghdar = VMeghdareSadereh
                            ElseIf VMeghdareVaredeh <> 0 Then
                                .Meghdar = VMeghdareVaredeh
                            Else
                                .Meghdar = 0
                            End If

                            '//
                            '.NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
                            '.NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
                            '.NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
                            '.DarkhastHaSN = Val(DVabSanadHa.Fields("DarkhastHaSN").Value)
                            '//

                            '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
                            '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)
                            '.SanadRow = New DataView(DVabSanad.DataSource.Table, "SanadSn = " & DVabSanad.Fields("SanadSn").Value, "", DataViewRowState.CurrentRows).Table.Rows(0)
                            .SanadRow = cn.ExecuteQuery("Select * from absanad where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)
                            '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری

                            _sanadhasn = Val(DVabSanadHa.Fields("SanadhaSn").Value)
                            .SanadhaSN = _sanadhasn
                            .TarakoneshSN = TarakoneshSN

                            .ShowDialog()

                            Select Case .Mode
                                Case 0 ' Cancel

                                Case 1 ' Single selection
                                    vSelected = .Selected
                                    'dcbMojavezErsalHa.BoundText = vSelected
                                    'DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1
                                    vRahgiri = dcbShomarehRahgiriText.Text
                                    vRahgiri = IIf(Trim(vRahgiri) = "", 0, vRahgiri)   ' Yekta 910425
                                    vKalaSN = CDec(DVabSanadHa.Fields("KalaSN").Value)

                                    vZarf = Val(DVabSanadHa.Fields("Tafsilisn1").Value)


                                    With DVabSanadHa  ' Yekta 910425

                                        If .FieldValue("ToolidDate") > "20000101" AndAlso .FieldValue("ToolidDate") <> "" Then
                                            .FieldValue("ToolidDate") = CShamsiDate.MiladiToShamsi(Date.Parse(.FieldText("ToolidDate")), EnumDateFormat.dfDefault)
                                        End If
                                        If .FieldValue("EnghezaDate") > "20000101" AndAlso .FieldValue("EnghezaDate") <> "" Then
                                            .FieldValue("EnghezaDate") = CShamsiDate.MiladiToShamsi(Date.Parse(.FieldText("EnghezaDate")), EnumDateFormat.dfDefault)
                                        End If

                                    End With    ' Yekta 910425


                                    vToolidDate = CStr(DVabSanadHa.Fields("Tooliddate").Value)
                                    vEnghezaDate = CStr(DVabSanadHa.Fields("EnghezaDate").Value)
                                    vNakhales = Val(DVabSanadHa.Fields("MeghdareNakhales").Value)

                                    If DVabSanadHa.State = EnumDataViewState.bsEdit Then
                                        cn.ExecuteQuery("delete absanadha where sanadhasn =" & _sanadhasn)
                                    End If

                                    KalaPhizikiStatusSN = IIf(Val(DVabSanadHa.Fields("KalaPhizikiStatusSN").Value) = 0, 1, Val(DVabSanadHa.Fields("KalaPhizikiStatusSN").Value))
                                    DarjeAsanDArkhast(vSelected, CDec(DVabSanad.Fields("SanadSN").Value), KalaPhizikiStatusSN, vKalaSN, vRahgiri, vNakhales, vZarf, vToolidDate, vEnghezaDate, _sanadhasn)
                                    DVabSanadHa.Abort()
                                    DVabSanadHa.Refresh()
                                    DVabSanadHaDarkhast.Abort()
                                    DVabSanadHaDarkhast.Refresh()
                                    DVabSanadHa.Refresh()
                                    'DVabSanad.Refresh()


                                Case 2 ' Multi selection
                                    DVabSanadHa.Abort()
                                    DVabSanadHa.Refresh()
                                    DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1


                            End Select
                            .Close()
                            .Dispose()

                        End With

                        '---------------Add by yekta 940319----------------------------------------------
                    ElseIf DVabSanadHa.Fields("KalaSN").Value <> 0 AndAlso (DVabSanadHaChideman.State <> EnumDataViewState.bsNormal) Then
                        Dim vFrmSelectChideman As New FrmSelectChideman
                        With vFrmSelectChideman
                            If CInt(DVabSanad.Fields("TarakoneshSN").Value) > 50 Then
                                .IsChiemanOutput = True
                            End If
                            .KalaPhizikiSN = DVabSanadHa.Fields("ShomarehRahgiriText").Value
                            .KalaPhizikiDS = DVabSanadHa.FieldText("KalaDS") + "( رهگیری : " + DVabSanadHa.Fields("ShomarehRahgiriText").Text + ")"
                            .ShowDialog()

                            vChidemanSN = .ChidemanSN
                            DVabSanadHaChideman.Fields("ChidemanSN").Value = vChidemanSN
                            dcbChidemanText.Text = .ChidemanDS
                            .Close()
                            .Dispose()

                        End With
                        '---------------Add by yekta 940319----------------------------------------------
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tmrF9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tmrF9.Tick '//ByIzadpanah -860319
        '  فعال سازي کليد اف 9 در ثبت اقلام سند بر اساس تاريخ ورود
        Dim vSelected As String
        tmrF9.Enabled = False

        If Not DVabSanadHa Is Nothing Then
            If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                If DVabSanadHa.Fields("KalaSN").Value <> "" Then
                    Dim vFrmSelectRahgiri As New FrmSelectRahgiri
                    With vFrmSelectRahgiri
                        .KalaSN = DVabSanadHa.Fields("KalaSN").Value
                        .MoaserDate = DVabSanad.Fields("MoaserDate").Value


                        Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
                        If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                            If mTarakoneshSN < 50 Then
                                DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)
                            Else
                                DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_out").Value)
                            End If
                            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
                        End If
                        VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                        VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

                        If VMeghdareSadereh <> 0 Then
                            .Meghdar = VMeghdareSadereh
                        ElseIf VMeghdareVaredeh <> 0 Then
                            .Meghdar = VMeghdareVaredeh
                        Else
                            .Meghdar = 0
                        End If

                        '//
                        .NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
                        .NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
                        .NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
                        '//


                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
                        '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)
                        '.SanadRow = New DataView(DVabSanad.DataSource.Table, "SanadSn = " & DVabSanad.Fields("SanadSn").Value, "", DataViewRowState.CurrentRows).Table.Rows(0)
                        '.SanadRow = cn.ExecuteQuery("Select * from absanad where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)
                        .SanadRow = cn.ExecuteQuery("Select *,abanbar.anbarsn ToAnbarSN from absanad left join abanbar on absanad.tafsilisn=abanbar.payesn where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)

                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری


                        .LoadForm()
                        .Hide()
                        .opnVoroodBeAnbar.Checked = True
                        .DarjeAutomatic()

                        Select Case .Mode
                            Case 0 ' Cancel

                            Case 1 ' Single selection
                                vSelected = .Selected
                                dcbShomarehRahgiriText.Text = vSelected
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1

                            Case 2 ' Multi selection
                                DVabSanadHa.Abort()
                                DVabSanadHa.Refresh()
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1
                        End Select

                        .Close()
                        .Dispose()

                    End With
                End If
            End If
        End If
        'End If
    End Sub

    Private Sub tmrF10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tmrF10.Tick
        '  فعال سازي کليد اف 10 در ثبت اقلام سند بر اساس تاريخ توليد
        Dim vSelected As String
        tmrF10.Enabled = False

        If Not DVabSanadHa Is Nothing Then
            If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                If DVabSanadHa.Fields("KalaSN").Value <> "" Then
                    Dim vFrmSelectRahgiri As New FrmSelectRahgiri
                    With vFrmSelectRahgiri
                        .KalaSN = DVabSanadHa.Fields("KalaSN").Value
                        .MoaserDate = DVabSanad.Fields("MoaserDate").Value


                        Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
                        If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                            If mTarakoneshSN < 50 Then
                                DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)
                            Else
                                DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_out").Value)
                            End If
                            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
                        End If
                        VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                        VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

                        If VMeghdareSadereh <> 0 Then
                            .Meghdar = VMeghdareSadereh
                        ElseIf VMeghdareVaredeh <> 0 Then
                            .Meghdar = VMeghdareVaredeh
                        Else
                            .Meghdar = 0
                        End If

                        '//
                        .NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
                        .NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
                        .NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
                        '//

                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
                        '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)
                        '.SanadRow = New DataView(DVabSanad.DataSource.Table, "SanadSn = " & DVabSanad.Fields("SanadSn").Value, "", DataViewRowState.CurrentRows).Table.Rows(0)
                        .SanadRow = cn.ExecuteQuery("Select * from absanad where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)
                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری

                        .LoadForm()
                        .Hide()
                        .opnToolid.Checked = True
                        .DarjeAutomatic()

                        Select Case .Mode
                            Case 0 ' Cancel

                            Case 1 ' Single selection
                                vSelected = .Selected
                                dcbShomarehRahgiriText.Text = vSelected
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1

                            Case 2 ' Multi selection
                                DVabSanadHa.Abort()
                                DVabSanadHa.Refresh()
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1
                        End Select

                        .Close()
                        .Dispose()

                    End With
                End If
            End If
        End If
        'End If
    End Sub

    Private Sub tmrF11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tmrF11.Tick
        '  فعال سازي کليد اف 11 در ثبت اقلام سند بر اساس تاريخ انقضا
        Dim vSelected As String
        tmrF11.Enabled = False

        If Not DVabSanadHa Is Nothing Then
            If DVabSanadHa.State = EnumDataViewState.bsAdd Then
                If DVabSanadHa.Fields("KalaSN").Value <> "" Then
                    Dim vFrmSelectRahgiri As New FrmSelectRahgiri
                    With vFrmSelectRahgiri
                        .KalaSN = DVabSanadHa.Fields("KalaSN").Value
                        .MoaserDate = DVabSanad.Fields("MoaserDate").Value


                        Dim VMeghdareVaredeh, VMeghdareSadereh As Decimal
                        If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Then
                            If mTarakoneshSN < 50 Then
                                DVabSanadHa.Fields("MeghdareVaredeh").Value = Val(DVabSanadHa.Fields("Box_in").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_in").Value)
                            Else
                                DVabSanadHa.Fields("MeghdareSadereh").Value = Val(DVabSanadHa.Fields("Box_out").Value) * Val(DVabSanadHa.Fields("TedadAjza").Text) + Val(DVabSanadHa.Fields("Can_out").Value)
                            End If
                            VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                            VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)
                        End If
                        VMeghdareVaredeh = IIf(Val(DVabSanadHa.Fields("MeghdareVaredeh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareVaredeh").Value)
                        VMeghdareSadereh = IIf(Val(DVabSanadHa.Fields("MeghdareSadereh").Value) = 0, 0, DVabSanadHa.Fields("MeghdareSadereh").Value)

                        If VMeghdareSadereh <> 0 Then
                            .Meghdar = VMeghdareSadereh
                        ElseIf VMeghdareVaredeh <> 0 Then
                            .Meghdar = VMeghdareVaredeh
                        Else
                            .Meghdar = 0
                        End If


                        '//
                        .NoeMadomiSN = Val(DVabSanadHa.Fields("NoeMadomiSN").Value)
                        .NoeMarjooeiSN = Val(DVabSanadHa.Fields("NoeMarjooeiSN").Value)
                        .NoeZayeatSN = Val(DVabSanadHa.Fields("NoeZayeatSN").Value)
                        '//

                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری
                        '.SanadRow = DVabSanad.DataSource.Table.Select("SanadSn = " & DVabSanad.Fields("SanadSn").Value)(0)
                        '.SanadRow = New DataView(DVabSanad.DataSource.Table, "SanadSn = " & DVabSanad.Fields("SanadSn").Value, "", DataViewRowState.CurrentRows).Table.Rows(0)
                        .SanadRow = cn.ExecuteQuery("Select * from absanad where sanadsn = " & DVabSanad.Fields("SanadSn").Value).Table.Rows(0)
                        '//890917 غفاری - جایگزینی کد ابزار با کد دات نت بعلت خطای ابزاری


                        .LoadForm()
                        .Hide()
                        .opnEngheza.Checked = True
                        .DarjeAutomatic()

                        Select Case .Mode
                            Case 0 ' Cancel

                            Case 1 ' Single selection
                                vSelected = .Selected
                                dcbShomarehRahgiriText.Text = vSelected
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1

                            Case 2 ' Multi selection
                                DVabSanadHa.Abort()
                                DVabSanadHa.Refresh()
                                DVabSanadHa.FlexGrid.Row = DVabSanadHa.DataRows + 1
                        End Select

                        .Close()
                        .Dispose()

                    End With
                End If
            End If
        End If
        'End If
    End Sub

#End Region

    Private Sub txtSanadMaliDate_Enter(sender As Object, e As System.EventArgs) Handles txtSanadMaliDate.Enter
        With DVabBarnameh
            If .FieldValue("SanadMaliDate") = "" Then
                .Fields("SanadMaliDate").Value = .Fields("BarnamehDate").Value
            End If
        End With
    End Sub

    'تابع کنترل اینکه به ازای هر سند انبار فقط یک سطر بارنامه ثبت شود
    Private Function ExistBarnameh(ByVal SanadSN As Decimal) As Boolean
        Dim result As Boolean = False
        Dim _dv As New DataView
        _dv = cn.ExecuteQuery("select abBarnamehHa.BarnamehSN from abBarnameh inner join abBarnamehHa on abBarnameh.BarnamehSN = abBarnamehHa.BarnamehSN where abBarnamehHa.SanadSN = " & Convert.ToString(SanadSN) & " and BarnamehStatus <> 2")
        If _dv.Count > 0 Then
            result = True
        End If
        Return result
    End Function

    'تابع کنترل اینکه تراکنش های غیر مجاز امکان ثبت بارنامه نداشته باشند
    Private Function CheckTarakoneshBarnameh(ByVal TarakoneshSN As Decimal) As Boolean
        Dim TarakoneshIncluded As Boolean = False
        Dim dvTarakonesh As New DataView
        dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(23) where TarakoneshSN = " & TarakoneshSN)
        If dvTarakonesh.Count = 1 Then
            TarakoneshIncluded = True
        End If
        Return TarakoneshIncluded
    End Function

    ''تابع کنترل اینکه تراکنش هايي که بارنامه آنها بايد قبل از قطعي سازي قبض انبار ثبت شوند
    'Private Function CheckTarakoneshBarnamehGhablAzGhatiSanadAnbar(ByVal TarakoneshSN As Decimal) As Boolean
    '    Dim TarakoneshIncluded As Boolean = False
    '    Dim dvTarakonesh As New DataView
    '    dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(26) where TarakoneshSN = " & TarakoneshSN)
    '    If dvTarakonesh.Count = 1 Then
    '        TarakoneshIncluded = True
    '    End If
    '    Return TarakoneshIncluded
    'End Function

    Private Function controlBarnameh(ByVal aBarnamehSN As Decimal, ByVal aSanadSN As Decimal) As String
        Dim StrMsg As String = ""

        cn.CallSP("_dpSPC_ControlBarnameh", aBarnamehSN, aSanadSN, StrMsg)

        Return StrMsg
    End Function

    Private Sub BtnPrintHavalehTolid_Click(sender As Object, e As EventArgs) Handles BtnPrintHavalehTolid.Click

        ''Add By dehghani - 981114
        Dim HavalehTolid As New Anbar.Report.RptHavalehDarkhastTolid
        Dim _rule As New ClsDataAccessRule

        Dim DvPrint As New DataView
        DvPrint = _rule.GetDatasourceForPrintHavalehTolid(DVabSanad.FieldValue("SanadSN"), cn)

        If DvPrint.Count = 0 Then
            NetSql.Common.CSystem.MsgBox("اطلاعات چاپ یافت نشد.", MsgBoxStyle.Exclamation, "چاپ حواله")
            Exit Sub
        End If

        With HavalehTolid
            .DefField()
            .DataSource = DvPrint
        End With

        Try
            Minoo.Reports.FTReportViewer.ShowReport(HavalehTolid, Me.MdiParent)

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در نمایش گزارش چاپ " + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "چاپ ")
        End Try

    End Sub

    ''Add By Dehghani 14000128
    Private Sub BtnUpdateBatchNoeEngheza_Click(sender As Object, e As EventArgs) Handles BtnUpdateBatchNoeEngheza.Click
        Dim Frm As New FrmEditBatchNoAndEnghezaInSanad
        If IsNumeric(DVabSanadHa.FieldValue("KalaSN")) Then
            With Frm
                .KalaSN = DVabSanadHa.FieldValue("KalaSN")
                .KalaDS = DVabSanadHa.FieldText("KalaDS") + vbNewLine + "شماره رهگیری : " + DVabSanadHa.FieldText("ShomarehRahgiriText")
                .BatchNo = DVabSanadHa.FieldText("BatchNo")
                .Tozih = DVabSanadHa.FieldText("Tozih")
                .NoeEngheza = DVabSanadHa.FieldValue("NoeEngheza")
                .KalaPhizikiSN = DVabSanadHa.FieldValue("ShomarehRahgiriText")
                .ShowDialog()
                .Dispose()
            End With
            DVabSanadHa.FetchCurRecord()
        End If
    End Sub



    Private Sub BtnSabtUID_Click(sender As Object, e As EventArgs) Handles BtnSabtUID.Click
        If Not IsNumeric(DVabSanadHa.FieldValue("MeghdareVaredeh")) AndAlso Not IsNumeric(DVabSanadHa.FieldValue("MeghdareSadereh")) Then
            CSystem.MsgBox("ابتدا مقدار ردیف سند را ثبت نمایید", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        Dim frmUID As New FrmSabtUIDforSanad
        With frmUID
            .KalaRahgiri = "محصول : " + DVabSanadHa.FieldText("KalaDS") + vbNewLine + "شماره رهگیری : " + DVabSanadHa.FieldText("ShomarehRahgiriText")
            .SanadHaSN = CDec(DVabSanadHa.FieldValue("SanadHaSN"))
            If CInt(DVabSanad.FieldValue("TarakoneshSN")) < 50 Then
                .MeghdarSanadHa = CDec(DVabSanadHa.FieldValue("MeghdareVaredeh"))
            Else
                .MeghdarSanadHa = CDec(DVabSanadHa.FieldValue("MeghdareSadereh"))
            End If
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub sstChild_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sstChild.SelectedIndexChanged
        'If sstChild.SelectedTab Is TabSanadHaFactor Then
        '    If ShowTabSanadHaFactor Then
        '        With DVabSanadHaFactor
        '            .SQLWhere = "SanadHASN=0"
        '            If IsNumeric(DVabSanadHa.FieldValue("SanadHASN")) Then
        '                .SQLWhere = "SanadHASN=" & DVabSanadHa.FieldValue("SanadHASN").ToString
        '            End If
        '            .Refresh()
        '        End With
        '    End If
        'ElseIf sstChild.SelectedTab Is TabProductCatalogue Then

        '    If ShowTabProductCatalogue Then
        '        With DVabSanadHaProductCatalogue
        '            .SQLWhere = "SanadHASN=0"
        '            If IsNumeric(DVabSanadHa.FieldValue("SanadHASN")) Then
        '                .SQLWhere = "SanadHASN=" & DVabSanadHa.FieldValue("SanadHASN").ToString
        '            End If
        '            .Refresh()
        '        End With
        '        If (IsNumeric(DVabSanad.Fields("BarcodeReaderSanad").Value) AndAlso DVabSanad.Fields("BarcodeReaderSanad").Value = 1) OrElse DVabSanadHaProductCatalogue.DataRows > 0 Then
        '            'DVabSanadHa.CommandEnabled(EnumCommands.cmEdit) = False
        '            DVabSanadHa.CommandEnabled(EnumCommands.cmAdd) = False

        '        End If
        '    End If
        'End If
    End Sub
    ''ghasemi
    Private Sub btnSabtSanaddarSamaneh_Click(sender As Object, e As EventArgs) Handles btnSabtSanaddarSamaneh.Click
        ' انتخاب یک یا چند رکورد برای ثبت سند در سامانه
        Dim i As Short
        Dim V_ar_abSanadHaSN() As String
        Dim VCount_SanadHaSN As Short
        Dim SanadHaSNString As String = ""

        With DVabSanadHa

            If NetSql.Common.CSystem.MsgBox(" آيا رکوردهاي انتخاب شده در سامانه ثبت گردد ؟ ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                With DVabSanad
                    If Val(.Fields("NoeSanadID").Value) <> 0 AndAlso Val(.Fields("NoeSanadID").Value) = 2 Then
                        NetSql.Common.CSystem.MsgBox("سند انبار از نوع ماشيني را نمي توان تغيير داد", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                        Exit Sub
                    End If
                End With
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                ''''''ایجاد یک رشته از دریف های سند انتخاب شده 
                With DVabSanadHa.FlexGrid
                    VCount_SanadHaSN = .SelectedRows
                    ReDim V_ar_abSanadHaSN(VCount_SanadHaSN)
                    For i = 0 To VCount_SanadHaSN - 1
                        V_ar_abSanadHaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("SanadHaSN")))
                        SanadHaSNString = V_ar_abSanadHaSN(i) + ", " + SanadHaSNString
                    Next
                End With

                If VCount_SanadHaSN = 0 Then
                    DVabSanad.Fields("RezStatus").Value = False
                Else
                    If VCount_SanadHaSN <> 0 Then
                        ''''''' فراخواني اس پي براي اقلام سند انتخاب شده جهت ثبت در سامانه
                        cn.CallSP("_absanadha_SabtDarSamane", SanadHaSNString)
                    End If
                End If

                ''ghasemi 14020906
                'Try
                '    If VCount_SanadHaSN = 0 Then
                '        DVabSanad.Fields("RezStatus").Value = False
                '    Else
                '        If VCount_SanadHaSN <> 0 And DVabSanad.Fields("RezStatus").Value = False Then
                '            ''''''' فراخواني اس پي براي اقلام سند انتخاب شده جهت ثبت در سامانه
                '            cn.CallSP("_absanadha_SabtDarSamane", SanadHaSNString)
                '        End If
                '    End If

                'Catch ex As Exception
                '    NetSql.Common.CSystem.MsgBox("خطا در ثبت سامانه " + ex.Message, MsgBoxStyle.MsgBoxRtlReading, "خطا ")
                'End Try
                ''ghasemi 14020906
                DVabSanadHa.Refresh()
                DVabSanad.FetchCurRecord()

            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With
    End Sub
    ''ghasemi


    'کنترل اینکه تراکنش هايي که در بارنامه منجر به ارسال بارنامه به شعب ديگر مي شود
    Private Function CheckTarakoneshErsaleBarnamehBeMaghsad(ByVal TarakoneshSN As Decimal) As Boolean
        Dim TarakoneshIncluded As Boolean = False
        Dim dvTarakonesh As New DataView
        dvTarakonesh = cn.ExecuteQuery("select TarakoneshSN from dbo.abFnt_GetTarakoneshSN(26) where TarakoneshSN = " & TarakoneshSN)
        If dvTarakonesh.Count = 1 Then
            TarakoneshIncluded = True
        End If
        Return TarakoneshIncluded
    End Function

    Private Sub DVabSanadHa_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DVabSanadHa.FillDetailsWithData
        If IsVahedeTejariSabtUIDonSanad Then
            If IsNumeric(DVabSanadHa.FieldValue("KalaSN")) Then
                'dvTarakoneshGorooh89.RowFilter = "0=0"
                'dvTarakoneshGorooh89.RowFilter = "TarakoneshSN=" & DVabSanad.FieldValue("TarakoneshSN").ToString
                'If dvTarakoneshGorooh89.Count > 0 Then
                dvKalaUseUID.RowFilter = "0=0"
                dvKalaUseUID.RowFilter = "KalaSN=" & DVabSanadHa.FieldValue("KalaSN").ToString
                BtnSabtUID.Enabled = If(dvKalaUseUID.Count > 0 AndAlso (DVabSanad.FieldValue("SanadStatus").ToString = "1" Or DVabSanad.FieldValue("SanadStatus").ToString = "4"), True, False)
                'Else
                '    BtnSabtUID.Enabled = False
                'End If
            Else
                'test
                BtnSabtUID.Enabled = False
            End If
        End If

        If ShowTabChideman Then
            For i As Integer = 0 To DVabSanadHaChideman.FlexGrid.ColumnCollection.Count - 1
                DVabSanadHaChideman.FlexGrid.AutoSizeCol(i)
            Next
        End If

        If ShowTabProductCatalogue Then
            With DVabSanadHaProductCatalogue
                .SQLWhere = "SanadHASN=0"
                If IsNumeric(DVabSanadHa.FieldValue("SanadHASN")) Then
                    .SQLWhere = "SanadHASN=" & DVabSanadHa.FieldValue("SanadHASN").ToString
                End If
                .Refresh()
            End With
            If (IsNumeric(DVabSanad.Fields("BarcodeReaderSanad").Value) AndAlso DVabSanad.Fields("BarcodeReaderSanad").Value = 1) OrElse DVabSanadHaProductCatalogue.DataRows > 0 Then
                'DVabSanadHa.CommandEnabled(EnumCommands.cmEdit) = False
                DVabSanadHa.CommandEnabled(EnumCommands.cmAdd) = False

            End If
        End If

        If ShowTabSanadHaFactor Then
            With DVabSanadHaFactor
                .SQLWhere = "SanadHASN=0"
                If IsNumeric(DVabSanadHa.FieldValue("SanadHASN")) Then
                    .SQLWhere = "SanadHASN=" & DVabSanadHa.FieldValue("SanadHASN").ToString
                End If
                .Refresh()
            End With
            If DVabSanadHaFactor.DataRows > 0 Then
                With DVabSanadHaFactor
                    With .FlexGrid
                        .Tree.Column = .ColIndex("TedadKol") - 1
                        .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
                        With .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0)
                            .DataType = GetType(Integer)
                            .Format = "N0"
                            .BackColor = Color.LightGoldenrodYellow
                            .ForeColor = Color.Black
                            .Font = New Font(DVabSanadHaFactor.FlexGrid.Font, FontStyle.Bold)
                        End With
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, .ColIndex("TedadKol"), "N0", (System.Drawing.Color.LightYellow), , True, "جمع", 0, True)
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, .ColIndex("Karton"), "N0", (System.Drawing.Color.LightYellow), , True, "جمع", 0, True)
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, .ColIndex("Adad"), "N0", (System.Drawing.Color.LightYellow), , True, "جمع", 0, True)
                    End With
                End With
            End If
        End If



        'BtnSabtUID.Enabled = True

    End Sub

    Private Sub dcbKalaDS_KeyUp(sender As Object, e As KeyEventArgs) Handles dcbKalaDS.KeyUp

    End Sub
End Class