
'''''''Author ::سيد محمود قاسمي 
'''''''CreateDate :: 1384/08/26
'ModifiedDate::1390/12/17   غفاری انبار گردانی جدید
'Description:: عملیات انبارگرداني
'System ::انبار

Option Strict Off
Option Explicit On

#Region "Imports"

Imports VB = Microsoft.VisualBasic
Imports C1.Win.C1FlexGrid.Classic
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports Anbar.BRL
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum
Imports Anbar.WebService.ClsWebServises
#End Region

Friend Class FrmabAnbarGardani
    Inherits Minoo.Base.FTBaseForm

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    If Not System.Reflection.Assembly.GetExecutingAssembly.EntryPoint Is Nothing Then
                        If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                            m_vb6FormDefInstance = Me
                        End If
                    End If
                Catch
                End Try
            End If
        End If
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
    Public WithEvents pnlNavigationKala As System.Windows.Forms.Panel
    Public WithEvents pnlCommandKala As System.Windows.Forms.Panel
    Public WithEvents pnlGridKala As System.Windows.Forms.Panel
    Public WithEvents _sstChild_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents sstChild As Minoo.Controls.FTTabControl
    Public WithEvents btnDelSelected As System.Windows.Forms.Button
    Public WithEvents btnDarjKalaPhiziki As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabShomaresh As System.Windows.Forms.TabPage
    Friend WithEvents TabGozaresh As System.Windows.Forms.TabPage
    Friend WithEvents TabSanadKasriEzafeh As System.Windows.Forms.TabPage
    Friend WithEvents TabEnteghalMjoodi As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Public WithEvents btnDelNoCounter As System.Windows.Forms.Button
    Public WithEvents btnDelSelectedshomaresh As System.Windows.Forms.Button
    Public WithEvents picNavigationDet2 As System.Windows.Forms.Panel
    Public WithEvents picCommandDet2 As System.Windows.Forms.Panel
    Public WithEvents picGridDet2 As System.Windows.Forms.Panel
    Public WithEvents btnDarjAsanShomaresh As System.Windows.Forms.Button
    Public WithEvents PnlGridDet1 As System.Windows.Forms.Panel
    Public WithEvents PnlNavigationDet1 As System.Windows.Forms.Panel
    Public WithEvents btnDarjkalaphizikiSHomaresh As System.Windows.Forms.Button
    Public WithEvents PnlCommandDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents btnStatus1_4_Easy As System.Windows.Forms.Button
    Public WithEvents btnStatus1_4 As System.Windows.Forms.Button
    Public WithEvents btnStatus4_8 As System.Windows.Forms.Button
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As Minoo.Controls.FTTabControl
    Friend WithEvents TabAnbargardani As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents txtTozih As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btnDarjSanad_KE As System.Windows.Forms.Button
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Public WithEvents btnDarjSanadAvalDoreh As System.Windows.Forms.Button
    Public WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents dcbFShomareshKhas As NetSql.Components.DataCombo
    Public WithEvents dcbTShomareshSN As NetSql.Components.DataCombo
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents dcbFShomareshSN As NetSql.Components.DataCombo
    Public WithEvents btnViewReport As System.Windows.Forms.Button
    Friend WithEvents GrpRptMoghMoj As System.Windows.Forms.GroupBox
    Friend WithEvents OptMoghBetSho As System.Windows.Forms.RadioButton
    Friend WithEvents OptMoghMojWSho As System.Windows.Forms.RadioButton
    Friend WithEvents optMoghKoli As System.Windows.Forms.RadioButton
    Public WithEvents pnlc As System.Windows.Forms.Panel
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents btnShowSanad_KE As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dcbNoeReport As NetSql.Components.DataCombo
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Public WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Tabtag As System.Windows.Forms.TabPage
    Friend WithEvents Tabfirstamaliyat As System.Windows.Forms.TabPage
    Friend WithEvents Tabstart As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents btnTagGhasem As System.Windows.Forms.Button
    Public WithEvents btnTagPars2 As System.Windows.Forms.Button
    Public WithEvents btnTagPars As System.Windows.Forms.Button
    Public WithEvents btnTag As System.Windows.Forms.Button
    Public WithEvents btnTagElsagh As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnTools As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents optKasrEzafeh As System.Windows.Forms.RadioButton
    Friend WithEvents ChkAll As System.Windows.Forms.CheckBox
    Public WithEvents btnExcelshomaresh As System.Windows.Forms.Button
    Public WithEvents btnExcelKalaha As System.Windows.Forms.Button
    Public WithEvents btnExcelreport As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSumTedad As NetSql.Components.TextBox
    Friend WithEvents pnln1 As System.Windows.Forms.Panel
    Public WithEvents btnExcel As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnln0 As System.Windows.Forms.Panel
    Friend WithEvents pnlg0 As System.Windows.Forms.Panel
    Friend WithEvents pnlc0 As System.Windows.Forms.Panel
    Friend WithEvents pnlc1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnlg1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Public WithEvents Panel6 As System.Windows.Forms.Panel
    Public WithEvents btnPrintSanad As System.Windows.Forms.Button
    Public WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ChkNotShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIsKE As System.Windows.Forms.CheckBox
    Public WithEvents Pnlg As System.Windows.Forms.Panel
    Friend WithEvents chkPYear As System.Windows.Forms.CheckBox
    Public WithEvents btnChapLastSanad As System.Windows.Forms.Button
    Friend WithEvents chkprintPyear As System.Windows.Forms.CheckBox
    Public WithEvents btnTabdilVaziat As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RdbShomareshNull As RadioButton
    Friend WithEvents RdbShomareshZero As RadioButton
    Friend WithEvents RdbShomareshAll As RadioButton
    Public WithEvents BtnInsertUpdateMojoudiInShomaresh As Button
    Friend WithEvents ChkInsertUpdateAllRadif As CheckBox
    Public WithEvents btnGhateeShomaresh As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.sstChild = New Minoo.Controls.FTTabControl()
        Me.Tabtag = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTagGhasem = New System.Windows.Forms.Button()
        Me.btnTagPars2 = New System.Windows.Forms.Button()
        Me.btnTagPars = New System.Windows.Forms.Button()
        Me.btnTag = New System.Windows.Forms.Button()
        Me.btnTagElsagh = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPYear = New System.Windows.Forms.CheckBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.dcbNoeReport = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tabfirstamaliyat = New System.Windows.Forms.TabPage()
        Me.btnStatus1_4_Easy = New System.Windows.Forms.Button()
        Me.Tabstart = New System.Windows.Forms.TabPage()
        Me.btnStatus1_4 = New System.Windows.Forms.Button()
        Me._sstChild_TabPage0 = New System.Windows.Forms.TabPage()
        Me.btnExcelKalaha = New System.Windows.Forms.Button()
        Me.btnDarjKalaPhiziki = New System.Windows.Forms.Button()
        Me.pnlNavigationKala = New System.Windows.Forms.Panel()
        Me.pnlCommandKala = New System.Windows.Forms.Panel()
        Me.pnlGridKala = New System.Windows.Forms.Panel()
        Me.btnDelSelected = New System.Windows.Forms.Button()
        Me.TabShomaresh = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChkInsertUpdateAllRadif = New System.Windows.Forms.CheckBox()
        Me.BtnInsertUpdateMojoudiInShomaresh = New System.Windows.Forms.Button()
        Me.PnlGridDet1 = New System.Windows.Forms.Panel()
        Me.btnDarjAsanShomaresh = New System.Windows.Forms.Button()
        Me.btnGhateeShomaresh = New System.Windows.Forms.Button()
        Me.PnlNavigationDet1 = New System.Windows.Forms.Panel()
        Me.PnlCommandDet1 = New System.Windows.Forms.Panel()
        Me.btnDarjkalaphizikiSHomaresh = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RdbShomareshAll = New System.Windows.Forms.RadioButton()
        Me.RdbShomareshNull = New System.Windows.Forms.RadioButton()
        Me.RdbShomareshZero = New System.Windows.Forms.RadioButton()
        Me.btnExcelshomaresh = New System.Windows.Forms.Button()
        Me.btnDelNoCounter = New System.Windows.Forms.Button()
        Me.btnDelSelectedshomaresh = New System.Windows.Forms.Button()
        Me.picNavigationDet2 = New System.Windows.Forms.Panel()
        Me.picCommandDet2 = New System.Windows.Forms.Panel()
        Me.picGridDet2 = New System.Windows.Forms.Panel()
        Me.TabGozaresh = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.GrpRptMoghMoj = New System.Windows.Forms.GroupBox()
        Me.ChkIsKE = New System.Windows.Forms.CheckBox()
        Me.ChkNotShowAll = New System.Windows.Forms.CheckBox()
        Me.optKasrEzafeh = New System.Windows.Forms.RadioButton()
        Me.optMoghKoli = New System.Windows.Forms.RadioButton()
        Me.OptMoghBetSho = New System.Windows.Forms.RadioButton()
        Me.dcbTShomareshSN = New NetSql.Components.DataCombo(Me.components)
        Me.OptMoghMojWSho = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dcbFShomareshKhas = New NetSql.Components.DataCombo(Me.components)
        Me.dcbFShomareshSN = New NetSql.Components.DataCombo(Me.components)
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Pnlg = New System.Windows.Forms.Panel()
        Me.btnExcelreport = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlc = New System.Windows.Forms.Panel()
        Me.TabSanadKasriEzafeh = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTozih = New System.Windows.Forms.TextBox()
        Me.btnDarjSanad_KE = New System.Windows.Forms.Button()
        Me.btnShowSanad_KE = New System.Windows.Forms.Button()
        Me.TabEnteghalMjoodi = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDarjSanadAvalDoreh = New System.Windows.Forms.Button()
        Me.pnln0 = New System.Windows.Forms.Panel()
        Me.pnlc0 = New System.Windows.Forms.Panel()
        Me.pnlg0 = New System.Windows.Forms.Panel()
        Me.pnlg1 = New System.Windows.Forms.Panel()
        Me.pnlc1 = New System.Windows.Forms.Panel()
        Me.txtSumTedad = New NetSql.Components.TextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnln1 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnChapLastSanad = New System.Windows.Forms.Button()
        Me.chkprintPyear = New System.Windows.Forms.CheckBox()
        Me.btnPrintSanad = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New Minoo.Controls.FTTabControl()
        Me.TabAnbargardani = New System.Windows.Forms.TabPage()
        Me.btnTabdilVaziat = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.btnStatus4_8 = New System.Windows.Forms.Button()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sstChild.SuspendLayout()
        Me.Tabtag.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tabfirstamaliyat.SuspendLayout()
        Me.Tabstart.SuspendLayout()
        Me._sstChild_TabPage0.SuspendLayout()
        Me.TabShomaresh.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabGozaresh.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GrpRptMoghMoj.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TabSanadKasriEzafeh.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabEnteghalMjoodi.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlg1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabAnbargardani.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkAll
        '
        Me.ChkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAll.AutoSize = True
        Me.ChkAll.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChkAll.Location = New System.Drawing.Point(985, 83)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(83, 17)
        Me.ChkAll.TabIndex = 60
        Me.ChkAll.Text = "همه فایل ها"
        Me.ToolTip1.SetToolTip(Me.ChkAll, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "با زدن این تیک تمام فایل های انبار گردانی این دوره نمایش داده می شود در غیر این" &
        "صورت فقط فایل های با وضعیت غیر ابطالی نمایش داده می شود." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'sstChild
        '
        Me.sstChild.Controls.Add(Me.Tabtag)
        Me.sstChild.Controls.Add(Me.Tabfirstamaliyat)
        Me.sstChild.Controls.Add(Me.Tabstart)
        Me.sstChild.Controls.Add(Me._sstChild_TabPage0)
        Me.sstChild.Controls.Add(Me.TabShomaresh)
        Me.sstChild.Controls.Add(Me.TabGozaresh)
        Me.sstChild.Controls.Add(Me.TabSanadKasriEzafeh)
        Me.sstChild.Controls.Add(Me.TabEnteghalMjoodi)
        Me.sstChild.Controls.Add(Me.TabPage1)
        Me.sstChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sstChild.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.sstChild.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sstChild.ItemSize = New System.Drawing.Size(84, 25)
        Me.sstChild.Location = New System.Drawing.Point(0, 0)
        Me.sstChild.Mirrored = True
        Me.sstChild.Multiline = True
        Me.sstChild.Name = "sstChild"
        Me.sstChild.SelectedIndex = 0
        Me.sstChild.Size = New System.Drawing.Size(1280, 515)
        Me.sstChild.TabIndex = 2
        Me.sstChild.TabStop = False
        '
        'Tabtag
        '
        Me.Tabtag.BackColor = System.Drawing.SystemColors.Control
        Me.Tabtag.Controls.Add(Me.GroupBox2)
        Me.Tabtag.Controls.Add(Me.GroupBox1)
        Me.Tabtag.Location = New System.Drawing.Point(4, 29)
        Me.Tabtag.Name = "Tabtag"
        Me.Tabtag.Size = New System.Drawing.Size(1272, 482)
        Me.Tabtag.TabIndex = 10
        Me.Tabtag.Text = "مرحله1)-چاپ تگ"
        Me.Tabtag.ToolTipText = "چاپ تگ از روی موجودی سیستم انجام می شود"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnTagGhasem)
        Me.GroupBox2.Controls.Add(Me.btnTagPars2)
        Me.GroupBox2.Controls.Add(Me.btnTagPars)
        Me.GroupBox2.Controls.Add(Me.btnTag)
        Me.GroupBox2.Controls.Add(Me.btnTagElsagh)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 81)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "چاپ تگ از روی فایل انبارگردانی - از این قسمت می توانید بعد از تشکیل فایل انبارگرد" &
    "انی چاپ تگها را انجام دهید"
        '
        'btnTagGhasem
        '
        Me.btnTagGhasem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTagGhasem.BackColor = System.Drawing.SystemColors.Control
        Me.btnTagGhasem.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTagGhasem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTagGhasem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTagGhasem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTagGhasem.Location = New System.Drawing.Point(107, 32)
        Me.btnTagGhasem.Name = "btnTagGhasem"
        Me.btnTagGhasem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTagGhasem.Size = New System.Drawing.Size(112, 38)
        Me.btnTagGhasem.TabIndex = 69
        Me.btnTagGhasem.Text = "تگ قاسم"
        Me.btnTagGhasem.UseVisualStyleBackColor = False
        '
        'btnTagPars2
        '
        Me.btnTagPars2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTagPars2.BackColor = System.Drawing.SystemColors.Control
        Me.btnTagPars2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTagPars2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTagPars2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTagPars2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTagPars2.Location = New System.Drawing.Point(225, 32)
        Me.btnTagPars2.Name = "btnTagPars2"
        Me.btnTagPars2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTagPars2.Size = New System.Drawing.Size(112, 38)
        Me.btnTagPars2.TabIndex = 68
        Me.btnTagPars2.Text = "تگ پارس2"
        Me.btnTagPars2.UseVisualStyleBackColor = False
        '
        'btnTagPars
        '
        Me.btnTagPars.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTagPars.BackColor = System.Drawing.SystemColors.Control
        Me.btnTagPars.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTagPars.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTagPars.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTagPars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTagPars.Location = New System.Drawing.Point(343, 32)
        Me.btnTagPars.Name = "btnTagPars"
        Me.btnTagPars.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTagPars.Size = New System.Drawing.Size(112, 38)
        Me.btnTagPars.TabIndex = 67
        Me.btnTagPars.Text = "تگ پارس"
        Me.btnTagPars.UseVisualStyleBackColor = False
        '
        'btnTag
        '
        Me.btnTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTag.BackColor = System.Drawing.SystemColors.Control
        Me.btnTag.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTag.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTag.Location = New System.Drawing.Point(461, 32)
        Me.btnTag.Name = "btnTag"
        Me.btnTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTag.Size = New System.Drawing.Size(120, 38)
        Me.btnTag.TabIndex = 66
        Me.btnTag.Text = "تگ انبارگرداني"
        Me.btnTag.UseVisualStyleBackColor = False
        '
        'btnTagElsagh
        '
        Me.btnTagElsagh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTagElsagh.BackColor = System.Drawing.SystemColors.Control
        Me.btnTagElsagh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTagElsagh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTagElsagh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTagElsagh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTagElsagh.Location = New System.Drawing.Point(587, 32)
        Me.btnTagElsagh.Name = "btnTagElsagh"
        Me.btnTagElsagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTagElsagh.Size = New System.Drawing.Size(112, 38)
        Me.btnTagElsagh.TabIndex = 65
        Me.btnTagElsagh.Text = "تگ الصاق"
        Me.btnTagElsagh.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkPYear)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.dcbNoeReport)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 147)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "چاپ تگ از روی موجودی سیستم - از این قسمت می توانید قبل از تشکیل فایل انبارگردانی " &
    "چاپ تگها را انجام دهید"
        '
        'chkPYear
        '
        Me.chkPYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPYear.AutoSize = True
        Me.chkPYear.Location = New System.Drawing.Point(429, 34)
        Me.chkPYear.Name = "chkPYear"
        Me.chkPYear.Size = New System.Drawing.Size(243, 20)
        Me.chkPYear.TabIndex = 66
        Me.chkPYear.Text = "آیا انبارگردانی پایان سال قبل می باشد؟"
        Me.chkPYear.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.Location = New System.Drawing.Point(73, 60)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(186, 23)
        Me.txtDesc.TabIndex = 48
        '
        'dcbNoeReport
        '
        Me.dcbNoeReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeReport.AutoSelectFirst = False
        Me.dcbNoeReport.BackColor = System.Drawing.Color.White
        Me.dcbNoeReport.BoundText = Nothing
        Me.dcbNoeReport.BypassChangeEvent = False
        Me.dcbNoeReport.DisplayText = ""
        Me.dcbNoeReport.Items.AddRange(New Object() {"تگ قاسم با رهگیری", "تگ قاسم بدون رهگیری", "تگ پارس", "تگ پارس با چيدمان مانده دار", "تگ خرمدره"})
        Me.dcbNoeReport.LateBindingTop = "100"
        Me.dcbNoeReport.Location = New System.Drawing.Point(348, 60)
        Me.dcbNoeReport.MemFilter = ""
        Me.dcbNoeReport.Name = "dcbNoeReport"
        Me.dcbNoeReport.SeparatedData = Nothing
        Me.dcbNoeReport.Size = New System.Drawing.Size(324, 24)
        Me.dcbNoeReport.Source = Nothing
        Me.dcbNoeReport.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeReport.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "گروه"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(73, 95)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 43
        Me.btnOk.Text = "مشاهده گزارش"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(271, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(27, 23)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Text = "1"
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(166, 95)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 42
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(678, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "نوع گزارش "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Tabfirstamaliyat
        '
        Me.Tabfirstamaliyat.BackColor = System.Drawing.SystemColors.Control
        Me.Tabfirstamaliyat.Controls.Add(Me.btnStatus1_4_Easy)
        Me.Tabfirstamaliyat.Location = New System.Drawing.Point(4, 29)
        Me.Tabfirstamaliyat.Name = "Tabfirstamaliyat"
        Me.Tabfirstamaliyat.Size = New System.Drawing.Size(1272, 482)
        Me.Tabfirstamaliyat.TabIndex = 11
        Me.Tabfirstamaliyat.Text = "مرحله2)-اقدامات اولیه"
        '
        'btnStatus1_4_Easy
        '
        Me.btnStatus1_4_Easy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus1_4_Easy.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus1_4_Easy.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus1_4_Easy.Enabled = False
        Me.btnStatus1_4_Easy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus1_4_Easy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus1_4_Easy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus1_4_Easy.Location = New System.Drawing.Point(527, 126)
        Me.btnStatus1_4_Easy.Name = "btnStatus1_4_Easy"
        Me.btnStatus1_4_Easy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus1_4_Easy.Size = New System.Drawing.Size(250, 100)
        Me.btnStatus1_4_Easy.TabIndex = 59
        Me.btnStatus1_4_Easy.Text = "اقدامات مقدماتی"
        Me.btnStatus1_4_Easy.UseVisualStyleBackColor = False
        '
        'Tabstart
        '
        Me.Tabstart.BackColor = System.Drawing.SystemColors.Control
        Me.Tabstart.Controls.Add(Me.btnStatus1_4)
        Me.Tabstart.Location = New System.Drawing.Point(4, 29)
        Me.Tabstart.Name = "Tabstart"
        Me.Tabstart.Size = New System.Drawing.Size(1272, 482)
        Me.Tabstart.TabIndex = 12
        Me.Tabstart.Text = "مرحله3)- شروع"
        '
        'btnStatus1_4
        '
        Me.btnStatus1_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus1_4.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus1_4.Enabled = False
        Me.btnStatus1_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus1_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus1_4.Location = New System.Drawing.Point(527, 126)
        Me.btnStatus1_4.Name = "btnStatus1_4"
        Me.btnStatus1_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus1_4.Size = New System.Drawing.Size(250, 100)
        Me.btnStatus1_4.TabIndex = 58
        Me.btnStatus1_4.Text = "شروع  انبارگردانی"
        Me.btnStatus1_4.UseVisualStyleBackColor = False
        '
        '_sstChild_TabPage0
        '
        Me._sstChild_TabPage0.Controls.Add(Me.btnExcelKalaha)
        Me._sstChild_TabPage0.Controls.Add(Me.btnDarjKalaPhiziki)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlNavigationKala)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlCommandKala)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlGridKala)
        Me._sstChild_TabPage0.Controls.Add(Me.btnDelSelected)
        Me._sstChild_TabPage0.Location = New System.Drawing.Point(4, 29)
        Me._sstChild_TabPage0.Name = "_sstChild_TabPage0"
        Me._sstChild_TabPage0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._sstChild_TabPage0.Size = New System.Drawing.Size(1272, 482)
        Me._sstChild_TabPage0.TabIndex = 0
        Me._sstChild_TabPage0.Text = "مرحله4) - کالاهای انبارگردانی"
        '
        'btnExcelKalaha
        '
        Me.btnExcelKalaha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelKalaha.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelKalaha.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcelKalaha.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcelKalaha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcelKalaha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcelKalaha.Location = New System.Drawing.Point(837, 442)
        Me.btnExcelKalaha.Name = "btnExcelKalaha"
        Me.btnExcelKalaha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcelKalaha.Size = New System.Drawing.Size(51, 35)
        Me.btnExcelKalaha.TabIndex = 69
        Me.btnExcelKalaha.Text = "EXCEL"
        Me.btnExcelKalaha.UseVisualStyleBackColor = False
        '
        'btnDarjKalaPhiziki
        '
        Me.btnDarjKalaPhiziki.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjKalaPhiziki.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjKalaPhiziki.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjKalaPhiziki.Enabled = False
        Me.btnDarjKalaPhiziki.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjKalaPhiziki.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjKalaPhiziki.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjKalaPhiziki.Location = New System.Drawing.Point(528, 441)
        Me.btnDarjKalaPhiziki.Name = "btnDarjKalaPhiziki"
        Me.btnDarjKalaPhiziki.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjKalaPhiziki.Size = New System.Drawing.Size(99, 38)
        Me.btnDarjKalaPhiziki.TabIndex = 59
        Me.btnDarjKalaPhiziki.Text = "درج کالا"
        Me.btnDarjKalaPhiziki.UseVisualStyleBackColor = False
        Me.btnDarjKalaPhiziki.Visible = False
        '
        'pnlNavigationKala
        '
        Me.pnlNavigationKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationKala.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationKala.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationKala.Location = New System.Drawing.Point(4, 443)
        Me.pnlNavigationKala.Name = "pnlNavigationKala"
        Me.pnlNavigationKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationKala.Size = New System.Drawing.Size(338, 33)
        Me.pnlNavigationKala.TabIndex = 8
        '
        'pnlCommandKala
        '
        Me.pnlCommandKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandKala.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandKala.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandKala.Location = New System.Drawing.Point(948, 440)
        Me.pnlCommandKala.Name = "pnlCommandKala"
        Me.pnlCommandKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandKala.Size = New System.Drawing.Size(316, 36)
        Me.pnlCommandKala.TabIndex = 9
        '
        'pnlGridKala
        '
        Me.pnlGridKala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridKala.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridKala.Location = New System.Drawing.Point(4, 5)
        Me.pnlGridKala.Name = "pnlGridKala"
        Me.pnlGridKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridKala.Size = New System.Drawing.Size(1260, 429)
        Me.pnlGridKala.TabIndex = 10
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
        Me.btnDelSelected.Location = New System.Drawing.Point(891, 440)
        Me.btnDelSelected.Name = "btnDelSelected"
        Me.btnDelSelected.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelSelected.Size = New System.Drawing.Size(53, 38)
        Me.btnDelSelected.TabIndex = 59
        Me.btnDelSelected.Text = "حذف انتخابي"
        Me.btnDelSelected.UseVisualStyleBackColor = False
        '
        'TabShomaresh
        '
        Me.TabShomaresh.Controls.Add(Me.SplitContainer2)
        Me.TabShomaresh.Location = New System.Drawing.Point(4, 29)
        Me.TabShomaresh.Name = "TabShomaresh"
        Me.TabShomaresh.Size = New System.Drawing.Size(1272, 482)
        Me.TabShomaresh.TabIndex = 3
        Me.TabShomaresh.Text = "مرحله5) -ثبت شمارش ها"
        Me.TabShomaresh.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel7)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel9)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(1272, 482)
        Me.SplitContainer2.SplitterDistance = 139
        Me.SplitContainer2.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.ChkInsertUpdateAllRadif)
        Me.Panel7.Controls.Add(Me.BtnInsertUpdateMojoudiInShomaresh)
        Me.Panel7.Controls.Add(Me.PnlGridDet1)
        Me.Panel7.Controls.Add(Me.btnDarjAsanShomaresh)
        Me.Panel7.Controls.Add(Me.btnGhateeShomaresh)
        Me.Panel7.Controls.Add(Me.PnlNavigationDet1)
        Me.Panel7.Controls.Add(Me.PnlCommandDet1)
        Me.Panel7.Controls.Add(Me.btnDarjkalaphizikiSHomaresh)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1272, 139)
        Me.Panel7.TabIndex = 0
        '
        'ChkInsertUpdateAllRadif
        '
        Me.ChkInsertUpdateAllRadif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkInsertUpdateAllRadif.AutoSize = True
        Me.ChkInsertUpdateAllRadif.Location = New System.Drawing.Point(460, 111)
        Me.ChkInsertUpdateAllRadif.Name = "ChkInsertUpdateAllRadif"
        Me.ChkInsertUpdateAllRadif.Size = New System.Drawing.Size(368, 20)
        Me.ChkInsertUpdateAllRadif.TabIndex = 87
        Me.ChkInsertUpdateAllRadif.Text = "اعمال آخرین موجودی سیستم برای تمامی ردیف های شمارش"
        Me.ChkInsertUpdateAllRadif.UseVisualStyleBackColor = True
        '
        'BtnInsertUpdateMojoudiInShomaresh
        '
        Me.BtnInsertUpdateMojoudiInShomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnInsertUpdateMojoudiInShomaresh.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInsertUpdateMojoudiInShomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnInsertUpdateMojoudiInShomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnInsertUpdateMojoudiInShomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnInsertUpdateMojoudiInShomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnInsertUpdateMojoudiInShomaresh.Location = New System.Drawing.Point(220, 106)
        Me.BtnInsertUpdateMojoudiInShomaresh.Name = "BtnInsertUpdateMojoudiInShomaresh"
        Me.BtnInsertUpdateMojoudiInShomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnInsertUpdateMojoudiInShomaresh.Size = New System.Drawing.Size(234, 28)
        Me.BtnInsertUpdateMojoudiInShomaresh.TabIndex = 86
        Me.BtnInsertUpdateMojoudiInShomaresh.Text = " درج موجودی سیستم در شمارش"
        Me.BtnInsertUpdateMojoudiInShomaresh.UseVisualStyleBackColor = False
        '
        'PnlGridDet1
        '
        Me.PnlGridDet1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlGridDet1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGridDet1.Location = New System.Drawing.Point(4, 3)
        Me.PnlGridDet1.Name = "PnlGridDet1"
        Me.PnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlGridDet1.Size = New System.Drawing.Size(1263, 100)
        Me.PnlGridDet1.TabIndex = 80
        '
        'btnDarjAsanShomaresh
        '
        Me.btnDarjAsanShomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjAsanShomaresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjAsanShomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAsanShomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAsanShomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjAsanShomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAsanShomaresh.Location = New System.Drawing.Point(985, 106)
        Me.btnDarjAsanShomaresh.Name = "btnDarjAsanShomaresh"
        Me.btnDarjAsanShomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAsanShomaresh.Size = New System.Drawing.Size(72, 28)
        Me.btnDarjAsanShomaresh.TabIndex = 84
        Me.btnDarjAsanShomaresh.Text = "درج آسان"
        Me.btnDarjAsanShomaresh.UseVisualStyleBackColor = False
        '
        'btnGhateeShomaresh
        '
        Me.btnGhateeShomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGhateeShomaresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnGhateeShomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGhateeShomaresh.Enabled = False
        Me.btnGhateeShomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGhateeShomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnGhateeShomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGhateeShomaresh.Location = New System.Drawing.Point(1192, 106)
        Me.btnGhateeShomaresh.Name = "btnGhateeShomaresh"
        Me.btnGhateeShomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnGhateeShomaresh.Size = New System.Drawing.Size(75, 28)
        Me.btnGhateeShomaresh.TabIndex = 81
        Me.btnGhateeShomaresh.Text = "قطعي"
        Me.btnGhateeShomaresh.UseVisualStyleBackColor = False
        '
        'PnlNavigationDet1
        '
        Me.PnlNavigationDet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.PnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlNavigationDet1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlNavigationDet1.Location = New System.Drawing.Point(4, 104)
        Me.PnlNavigationDet1.Name = "PnlNavigationDet1"
        Me.PnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlNavigationDet1.Size = New System.Drawing.Size(210, 33)
        Me.PnlNavigationDet1.TabIndex = 79
        '
        'PnlCommandDet1
        '
        Me.PnlCommandDet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.PnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlCommandDet1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlCommandDet1.Location = New System.Drawing.Point(881, 110)
        Me.PnlCommandDet1.Name = "PnlCommandDet1"
        Me.PnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlCommandDet1.Size = New System.Drawing.Size(79, 21)
        Me.PnlCommandDet1.TabIndex = 78
        '
        'btnDarjkalaphizikiSHomaresh
        '
        Me.btnDarjkalaphizikiSHomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjkalaphizikiSHomaresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjkalaphizikiSHomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjkalaphizikiSHomaresh.Enabled = False
        Me.btnDarjkalaphizikiSHomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjkalaphizikiSHomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjkalaphizikiSHomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjkalaphizikiSHomaresh.Location = New System.Drawing.Point(814, 108)
        Me.btnDarjkalaphizikiSHomaresh.Name = "btnDarjkalaphizikiSHomaresh"
        Me.btnDarjkalaphizikiSHomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjkalaphizikiSHomaresh.Size = New System.Drawing.Size(37, 23)
        Me.btnDarjkalaphizikiSHomaresh.TabIndex = 82
        Me.btnDarjkalaphizikiSHomaresh.Text = "درج کالا"
        Me.btnDarjkalaphizikiSHomaresh.UseVisualStyleBackColor = False
        Me.btnDarjkalaphizikiSHomaresh.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.GroupBox3)
        Me.Panel9.Controls.Add(Me.btnExcelshomaresh)
        Me.Panel9.Controls.Add(Me.btnDelNoCounter)
        Me.Panel9.Controls.Add(Me.btnDelSelectedshomaresh)
        Me.Panel9.Controls.Add(Me.picNavigationDet2)
        Me.Panel9.Controls.Add(Me.picCommandDet2)
        Me.Panel9.Controls.Add(Me.picGridDet2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1272, 339)
        Me.Panel9.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RdbShomareshAll)
        Me.GroupBox3.Controls.Add(Me.RdbShomareshNull)
        Me.GroupBox3.Controls.Add(Me.RdbShomareshZero)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(10, 41)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "نمایش ردیف های "
        Me.GroupBox3.Visible = False
        '
        'RdbShomareshAll
        '
        Me.RdbShomareshAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RdbShomareshAll.AutoSize = True
        Me.RdbShomareshAll.Location = New System.Drawing.Point(5, 15)
        Me.RdbShomareshAll.Name = "RdbShomareshAll"
        Me.RdbShomareshAll.Size = New System.Drawing.Size(98, 20)
        Me.RdbShomareshAll.TabIndex = 2
        Me.RdbShomareshAll.TabStop = True
        Me.RdbShomareshAll.Text = "همه ردیف ها"
        Me.RdbShomareshAll.UseVisualStyleBackColor = True
        '
        'RdbShomareshNull
        '
        Me.RdbShomareshNull.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RdbShomareshNull.AutoSize = True
        Me.RdbShomareshNull.Location = New System.Drawing.Point(109, 15)
        Me.RdbShomareshNull.Name = "RdbShomareshNull"
        Me.RdbShomareshNull.Size = New System.Drawing.Size(101, 20)
        Me.RdbShomareshNull.TabIndex = 1
        Me.RdbShomareshNull.TabStop = True
        Me.RdbShomareshNull.Text = "بدون شمارش"
        Me.RdbShomareshNull.UseVisualStyleBackColor = True
        '
        'RdbShomareshZero
        '
        Me.RdbShomareshZero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RdbShomareshZero.AutoSize = True
        Me.RdbShomareshZero.Location = New System.Drawing.Point(216, 15)
        Me.RdbShomareshZero.Name = "RdbShomareshZero"
        Me.RdbShomareshZero.Size = New System.Drawing.Size(93, 20)
        Me.RdbShomareshZero.TabIndex = 0
        Me.RdbShomareshZero.TabStop = True
        Me.RdbShomareshZero.Text = "با مقدار صفر"
        Me.RdbShomareshZero.UseVisualStyleBackColor = True
        '
        'btnExcelshomaresh
        '
        Me.btnExcelshomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelshomaresh.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelshomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcelshomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcelshomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcelshomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcelshomaresh.Location = New System.Drawing.Point(622, 293)
        Me.btnExcelshomaresh.Name = "btnExcelshomaresh"
        Me.btnExcelshomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcelshomaresh.Size = New System.Drawing.Size(51, 41)
        Me.btnExcelshomaresh.TabIndex = 68
        Me.btnExcelshomaresh.Text = "EXCEL"
        Me.btnExcelshomaresh.UseVisualStyleBackColor = False
        '
        'btnDelNoCounter
        '
        Me.btnDelNoCounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelNoCounter.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelNoCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelNoCounter.Enabled = False
        Me.btnDelNoCounter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelNoCounter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDelNoCounter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelNoCounter.Location = New System.Drawing.Point(679, 293)
        Me.btnDelNoCounter.Name = "btnDelNoCounter"
        Me.btnDelNoCounter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelNoCounter.Size = New System.Drawing.Size(146, 41)
        Me.btnDelNoCounter.TabIndex = 67
        Me.btnDelNoCounter.Text = "حذف ردیفهای شمارش نشده"
        Me.btnDelNoCounter.UseVisualStyleBackColor = False
        '
        'btnDelSelectedshomaresh
        '
        Me.btnDelSelectedshomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelSelectedshomaresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelSelectedshomaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelSelectedshomaresh.Enabled = False
        Me.btnDelSelectedshomaresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelSelectedshomaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDelSelectedshomaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelSelectedshomaresh.Location = New System.Drawing.Point(827, 293)
        Me.btnDelSelectedshomaresh.Name = "btnDelSelectedshomaresh"
        Me.btnDelSelectedshomaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelSelectedshomaresh.Size = New System.Drawing.Size(69, 41)
        Me.btnDelSelectedshomaresh.TabIndex = 66
        Me.btnDelSelectedshomaresh.Text = "حذف انتخابي"
        Me.btnDelSelectedshomaresh.UseVisualStyleBackColor = False
        '
        'picNavigationDet2
        '
        Me.picNavigationDet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picNavigationDet2.BackColor = System.Drawing.SystemColors.Control
        Me.picNavigationDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picNavigationDet2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.picNavigationDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picNavigationDet2.Location = New System.Drawing.Point(3, 293)
        Me.picNavigationDet2.Name = "picNavigationDet2"
        Me.picNavigationDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picNavigationDet2.Size = New System.Drawing.Size(276, 43)
        Me.picNavigationDet2.TabIndex = 63
        '
        'picCommandDet2
        '
        Me.picCommandDet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCommandDet2.BackColor = System.Drawing.SystemColors.Control
        Me.picCommandDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCommandDet2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.picCommandDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picCommandDet2.Location = New System.Drawing.Point(902, 295)
        Me.picCommandDet2.Name = "picCommandDet2"
        Me.picCommandDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picCommandDet2.Size = New System.Drawing.Size(362, 38)
        Me.picCommandDet2.TabIndex = 62
        '
        'picGridDet2
        '
        Me.picGridDet2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGridDet2.BackColor = System.Drawing.SystemColors.Control
        Me.picGridDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picGridDet2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picGridDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picGridDet2.Location = New System.Drawing.Point(3, 3)
        Me.picGridDet2.Name = "picGridDet2"
        Me.picGridDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picGridDet2.Size = New System.Drawing.Size(1261, 286)
        Me.picGridDet2.TabIndex = 64
        '
        'TabGozaresh
        '
        Me.TabGozaresh.BackColor = System.Drawing.SystemColors.Control
        Me.TabGozaresh.Controls.Add(Me.SplitContainer5)
        Me.TabGozaresh.Location = New System.Drawing.Point(4, 29)
        Me.TabGozaresh.Name = "TabGozaresh"
        Me.TabGozaresh.Size = New System.Drawing.Size(1272, 482)
        Me.TabGozaresh.TabIndex = 6
        Me.TabGozaresh.Text = "مرحله6) - گزارش"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer5.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.Panel14)
        Me.SplitContainer5.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer5.Size = New System.Drawing.Size(1272, 482)
        Me.SplitContainer5.SplitterDistance = 101
        Me.SplitContainer5.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.btnViewReport)
        Me.Panel4.Controls.Add(Me.GrpRptMoghMoj)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel4.Size = New System.Drawing.Size(1272, 101)
        Me.Panel4.TabIndex = 2
        '
        'btnViewReport
        '
        Me.btnViewReport.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnViewReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnViewReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnViewReport.Location = New System.Drawing.Point(4, 38)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnViewReport.Size = New System.Drawing.Size(97, 36)
        Me.btnViewReport.TabIndex = 59
        Me.btnViewReport.Text = "مشاهده گزارش"
        Me.btnViewReport.UseVisualStyleBackColor = False
        '
        'GrpRptMoghMoj
        '
        Me.GrpRptMoghMoj.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpRptMoghMoj.BackColor = System.Drawing.SystemColors.Control
        Me.GrpRptMoghMoj.Controls.Add(Me.ChkIsKE)
        Me.GrpRptMoghMoj.Controls.Add(Me.ChkNotShowAll)
        Me.GrpRptMoghMoj.Controls.Add(Me.optKasrEzafeh)
        Me.GrpRptMoghMoj.Controls.Add(Me.optMoghKoli)
        Me.GrpRptMoghMoj.Controls.Add(Me.OptMoghBetSho)
        Me.GrpRptMoghMoj.Controls.Add(Me.dcbTShomareshSN)
        Me.GrpRptMoghMoj.Controls.Add(Me.OptMoghMojWSho)
        Me.GrpRptMoghMoj.Controls.Add(Me.Label12)
        Me.GrpRptMoghMoj.Controls.Add(Me.dcbFShomareshKhas)
        Me.GrpRptMoghMoj.Controls.Add(Me.dcbFShomareshSN)
        Me.GrpRptMoghMoj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpRptMoghMoj.Location = New System.Drawing.Point(480, 2)
        Me.GrpRptMoghMoj.Name = "GrpRptMoghMoj"
        Me.GrpRptMoghMoj.Size = New System.Drawing.Size(783, 81)
        Me.GrpRptMoghMoj.TabIndex = 60
        Me.GrpRptMoghMoj.TabStop = False
        '
        'ChkIsKE
        '
        Me.ChkIsKE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIsKE.AutoSize = True
        Me.ChkIsKE.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChkIsKE.Location = New System.Drawing.Point(17, 12)
        Me.ChkIsKE.Name = "ChkIsKE"
        Me.ChkIsKE.Size = New System.Drawing.Size(317, 17)
        Me.ChkIsKE.TabIndex = 66
        Me.ChkIsKE.Text = "آیا اسناد کسری و اضافه در محاسبه موجودی در نظر گرفته شود؟"
        Me.ChkIsKE.UseVisualStyleBackColor = True
        '
        'ChkNotShowAll
        '
        Me.ChkNotShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNotShowAll.AutoSize = True
        Me.ChkNotShowAll.Location = New System.Drawing.Point(141, 62)
        Me.ChkNotShowAll.Name = "ChkNotShowAll"
        Me.ChkNotShowAll.Size = New System.Drawing.Size(153, 17)
        Me.ChkNotShowAll.TabIndex = 65
        Me.ChkNotShowAll.Text = "عدم نمایش رکوردهای خالی"
        Me.ChkNotShowAll.UseVisualStyleBackColor = True
        '
        'optKasrEzafeh
        '
        Me.optKasrEzafeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optKasrEzafeh.AutoSize = True
        Me.optKasrEzafeh.Location = New System.Drawing.Point(320, 59)
        Me.optKasrEzafeh.Name = "optKasrEzafeh"
        Me.optKasrEzafeh.Size = New System.Drawing.Size(132, 17)
        Me.optKasrEzafeh.TabIndex = 64
        Me.optKasrEzafeh.Text = "گزارش کسری و اضافی"
        Me.optKasrEzafeh.UseVisualStyleBackColor = True
        '
        'optMoghKoli
        '
        Me.optMoghKoli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optMoghKoli.AutoSize = True
        Me.optMoghKoli.Location = New System.Drawing.Point(501, 59)
        Me.optMoghKoli.Name = "optMoghKoli"
        Me.optMoghKoli.Size = New System.Drawing.Size(267, 17)
        Me.optMoghKoli.TabIndex = 63
        Me.optMoghKoli.Text = "مغایرت کلی انبار گردانی با مقایسه آخرین شمارش ها"
        Me.optMoghKoli.UseVisualStyleBackColor = True
        '
        'OptMoghBetSho
        '
        Me.OptMoghBetSho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptMoghBetSho.AutoSize = True
        Me.OptMoghBetSho.Location = New System.Drawing.Point(649, 36)
        Me.OptMoghBetSho.Name = "OptMoghBetSho"
        Me.OptMoghBetSho.Size = New System.Drawing.Size(119, 17)
        Me.OptMoghBetSho.TabIndex = 62
        Me.OptMoghBetSho.Text = "مغایرت بین شمارش "
        Me.OptMoghBetSho.UseVisualStyleBackColor = True
        '
        'dcbTShomareshSN
        '
        Me.dcbTShomareshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbTShomareshSN.AutoSelectFirst = False
        Me.dcbTShomareshSN.BackColor = System.Drawing.Color.White
        Me.dcbTShomareshSN.BoundText = Nothing
        Me.dcbTShomareshSN.BypassChangeEvent = False
        Me.dcbTShomareshSN.DisplayText = ""
        Me.dcbTShomareshSN.LateBindingTop = "100"
        Me.dcbTShomareshSN.Location = New System.Drawing.Point(102, 35)
        Me.dcbTShomareshSN.MemFilter = ""
        Me.dcbTShomareshSN.Name = "dcbTShomareshSN"
        Me.dcbTShomareshSN.SeparatedData = Nothing
        Me.dcbTShomareshSN.Size = New System.Drawing.Size(192, 21)
        Me.dcbTShomareshSN.Source = Nothing
        Me.dcbTShomareshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbTShomareshSN.TabIndex = 47
        '
        'OptMoghMojWSho
        '
        Me.OptMoghMojWSho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptMoghMojWSho.AutoSize = True
        Me.OptMoghMojWSho.Checked = True
        Me.OptMoghMojWSho.Location = New System.Drawing.Point(578, 12)
        Me.OptMoghMojWSho.Name = "OptMoghMojWSho"
        Me.OptMoghMojWSho.Size = New System.Drawing.Size(190, 17)
        Me.OptMoghMojWSho.TabIndex = 61
        Me.OptMoghMojWSho.TabStop = True
        Me.OptMoghMojWSho.Text = "مغايرت موجودي سيستم با شمارش"
        Me.OptMoghMojWSho.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Location = New System.Drawing.Point(300, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "و شمارش"
        '
        'dcbFShomareshKhas
        '
        Me.dcbFShomareshKhas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbFShomareshKhas.AutoSelectFirst = False
        Me.dcbFShomareshKhas.BackColor = System.Drawing.Color.White
        Me.dcbFShomareshKhas.BoundText = Nothing
        Me.dcbFShomareshKhas.BypassChangeEvent = False
        Me.dcbFShomareshKhas.DisplayText = ""
        Me.dcbFShomareshKhas.LateBindingTop = "100"
        Me.dcbFShomareshKhas.Location = New System.Drawing.Point(367, 10)
        Me.dcbFShomareshKhas.MemFilter = ""
        Me.dcbFShomareshKhas.Name = "dcbFShomareshKhas"
        Me.dcbFShomareshKhas.SeparatedData = Nothing
        Me.dcbFShomareshKhas.Size = New System.Drawing.Size(192, 21)
        Me.dcbFShomareshKhas.Source = Nothing
        Me.dcbFShomareshKhas.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbFShomareshKhas.TabIndex = 39
        '
        'dcbFShomareshSN
        '
        Me.dcbFShomareshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbFShomareshSN.AutoSelectFirst = False
        Me.dcbFShomareshSN.BackColor = System.Drawing.Color.White
        Me.dcbFShomareshSN.BoundText = Nothing
        Me.dcbFShomareshSN.BypassChangeEvent = False
        Me.dcbFShomareshSN.DisplayText = ""
        Me.dcbFShomareshSN.LateBindingTop = "100"
        Me.dcbFShomareshSN.Location = New System.Drawing.Point(367, 35)
        Me.dcbFShomareshSN.MemFilter = ""
        Me.dcbFShomareshSN.Name = "dcbFShomareshSN"
        Me.dcbFShomareshSN.SeparatedData = Nothing
        Me.dcbFShomareshSN.Size = New System.Drawing.Size(192, 21)
        Me.dcbFShomareshSN.Source = Nothing
        Me.dcbFShomareshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbFShomareshSN.TabIndex = 44
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.Control
        Me.Panel14.Controls.Add(Me.Pnlg)
        Me.Panel14.Controls.Add(Me.btnExcelreport)
        Me.Panel14.Controls.Add(Me.pnlN)
        Me.Panel14.Controls.Add(Me.pnlc)
        Me.Panel14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel14.Size = New System.Drawing.Size(1272, 377)
        Me.Panel14.TabIndex = 7
        '
        'Pnlg
        '
        Me.Pnlg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnlg.BackColor = System.Drawing.SystemColors.Control
        Me.Pnlg.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pnlg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pnlg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pnlg.Location = New System.Drawing.Point(4, 3)
        Me.Pnlg.Name = "Pnlg"
        Me.Pnlg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Pnlg.Size = New System.Drawing.Size(1263, 329)
        Me.Pnlg.TabIndex = 71
        '
        'btnExcelreport
        '
        Me.btnExcelreport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelreport.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelreport.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcelreport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcelreport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcelreport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcelreport.Location = New System.Drawing.Point(1029, 338)
        Me.btnExcelreport.Name = "btnExcelreport"
        Me.btnExcelreport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcelreport.Size = New System.Drawing.Size(51, 35)
        Me.btnExcelreport.TabIndex = 70
        Me.btnExcelreport.Text = "EXCEL"
        Me.btnExcelreport.UseVisualStyleBackColor = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 338)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(224, 33)
        Me.pnlN.TabIndex = 5
        '
        'pnlc
        '
        Me.pnlc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlc.BackColor = System.Drawing.SystemColors.Control
        Me.pnlc.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlc.Location = New System.Drawing.Point(1084, 338)
        Me.pnlc.Name = "pnlc"
        Me.pnlc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlc.Size = New System.Drawing.Size(183, 33)
        Me.pnlc.TabIndex = 6
        '
        'TabSanadKasriEzafeh
        '
        Me.TabSanadKasriEzafeh.BackColor = System.Drawing.SystemColors.Control
        Me.TabSanadKasriEzafeh.Controls.Add(Me.Panel3)
        Me.TabSanadKasriEzafeh.Location = New System.Drawing.Point(4, 29)
        Me.TabSanadKasriEzafeh.Name = "TabSanadKasriEzafeh"
        Me.TabSanadKasriEzafeh.Size = New System.Drawing.Size(1272, 482)
        Me.TabSanadKasriEzafeh.TabIndex = 7
        Me.TabSanadKasriEzafeh.Text = "مرحله7) - سند کسری و اضافه"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtTozih)
        Me.Panel3.Controls.Add(Me.btnDarjSanad_KE)
        Me.Panel3.Controls.Add(Me.btnShowSanad_KE)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1272, 482)
        Me.Panel3.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(1041, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "توضيحات اسناد"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'txtTozih
        '
        Me.txtTozih.AcceptsReturn = True
        Me.txtTozih.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTozih.BackColor = System.Drawing.SystemColors.Window
        Me.txtTozih.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTozih.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtTozih.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTozih.Location = New System.Drawing.Point(242, 23)
        Me.txtTozih.MaxLength = 0
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTozih.Size = New System.Drawing.Size(784, 21)
        Me.txtTozih.TabIndex = 19
        Me.txtTozih.Tag = ""
        Me.txtTozih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTozih.Visible = False
        '
        'btnDarjSanad_KE
        '
        Me.btnDarjSanad_KE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjSanad_KE.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjSanad_KE.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjSanad_KE.Enabled = False
        Me.btnDarjSanad_KE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjSanad_KE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjSanad_KE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjSanad_KE.Location = New System.Drawing.Point(527, 126)
        Me.btnDarjSanad_KE.Name = "btnDarjSanad_KE"
        Me.btnDarjSanad_KE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjSanad_KE.Size = New System.Drawing.Size(250, 100)
        Me.btnDarjSanad_KE.TabIndex = 58
        Me.btnDarjSanad_KE.Text = "ثبت اسناد کسری و اضافی"
        Me.btnDarjSanad_KE.UseVisualStyleBackColor = False
        '
        'btnShowSanad_KE
        '
        Me.btnShowSanad_KE.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowSanad_KE.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowSanad_KE.Enabled = False
        Me.btnShowSanad_KE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowSanad_KE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnShowSanad_KE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowSanad_KE.Location = New System.Drawing.Point(48, 16)
        Me.btnShowSanad_KE.Name = "btnShowSanad_KE"
        Me.btnShowSanad_KE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowSanad_KE.Size = New System.Drawing.Size(162, 33)
        Me.btnShowSanad_KE.TabIndex = 59
        Me.btnShowSanad_KE.Text = "نمایش اسناد کسری و اضافی"
        Me.btnShowSanad_KE.UseVisualStyleBackColor = False
        Me.btnShowSanad_KE.Visible = False
        '
        'TabEnteghalMjoodi
        '
        Me.TabEnteghalMjoodi.BackColor = System.Drawing.SystemColors.Control
        Me.TabEnteghalMjoodi.Controls.Add(Me.SplitContainer3)
        Me.TabEnteghalMjoodi.Controls.Add(Me.Splitter1)
        Me.TabEnteghalMjoodi.Location = New System.Drawing.Point(4, 29)
        Me.TabEnteghalMjoodi.Name = "TabEnteghalMjoodi"
        Me.TabEnteghalMjoodi.Size = New System.Drawing.Size(1272, 482)
        Me.TabEnteghalMjoodi.TabIndex = 8
        Me.TabEnteghalMjoodi.Text = "مرحله8) - انتقال موجودی"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 4)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.pnlg1)
        Me.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer3.Size = New System.Drawing.Size(1272, 478)
        Me.SplitContainer3.SplitterDistance = 290
        Me.SplitContainer3.TabIndex = 42
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.btnExcel)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.btnDarjSanadAvalDoreh)
        Me.Panel5.Controls.Add(Me.pnln0)
        Me.Panel5.Controls.Add(Me.pnlc0)
        Me.Panel5.Controls.Add(Me.pnlg0)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1272, 290)
        Me.Panel5.TabIndex = 34
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point(755, 244)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size(72, 40)
        Me.btnExcel.TabIndex = 10
        Me.btnExcel.Text = "EXCEL"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(833, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "قطعي"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnDarjSanadAvalDoreh
        '
        Me.btnDarjSanadAvalDoreh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjSanadAvalDoreh.BackColor = System.Drawing.Color.Transparent
        Me.btnDarjSanadAvalDoreh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjSanadAvalDoreh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjSanadAvalDoreh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjSanadAvalDoreh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjSanadAvalDoreh.Location = New System.Drawing.Point(527, 48)
        Me.btnDarjSanadAvalDoreh.Name = "btnDarjSanadAvalDoreh"
        Me.btnDarjSanadAvalDoreh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjSanadAvalDoreh.Size = New System.Drawing.Size(250, 100)
        Me.btnDarjSanadAvalDoreh.TabIndex = 31
        Me.btnDarjSanadAvalDoreh.Text = "ثبت سند موجودی اول دوره سال بعد"
        Me.btnDarjSanadAvalDoreh.UseVisualStyleBackColor = False
        '
        'pnln0
        '
        Me.pnln0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnln0.Location = New System.Drawing.Point(3, 246)
        Me.pnln0.Name = "pnln0"
        Me.pnln0.Size = New System.Drawing.Size(331, 41)
        Me.pnln0.TabIndex = 2
        Me.pnln0.Visible = False
        '
        'pnlc0
        '
        Me.pnlc0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlc0.Location = New System.Drawing.Point(930, 240)
        Me.pnlc0.Name = "pnlc0"
        Me.pnlc0.Size = New System.Drawing.Size(336, 41)
        Me.pnlc0.TabIndex = 1
        Me.pnlc0.Visible = False
        '
        'pnlg0
        '
        Me.pnlg0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlg0.Location = New System.Drawing.Point(6, 170)
        Me.pnlg0.Name = "pnlg0"
        Me.pnlg0.Size = New System.Drawing.Size(1258, 61)
        Me.pnlg0.TabIndex = 0
        Me.pnlg0.Visible = False
        '
        'pnlg1
        '
        Me.pnlg1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlg1.Controls.Add(Me.pnlc1)
        Me.pnlg1.Controls.Add(Me.txtSumTedad)
        Me.pnlg1.Controls.Add(Me.Label1)
        Me.pnlg1.Controls.Add(Me.pnln1)
        Me.pnlg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlg1.Location = New System.Drawing.Point(0, 0)
        Me.pnlg1.Name = "pnlg1"
        Me.pnlg1.Size = New System.Drawing.Size(1272, 184)
        Me.pnlg1.TabIndex = 42
        '
        'pnlc1
        '
        Me.pnlc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlc1.Location = New System.Drawing.Point(945, 135)
        Me.pnlc1.Name = "pnlc1"
        Me.pnlc1.Size = New System.Drawing.Size(322, 41)
        Me.pnlc1.TabIndex = 4
        Me.pnlc1.Visible = False
        '
        'txtSumTedad
        '
        Me.txtSumTedad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSumTedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSumTedad.ForeColor = System.Drawing.Color.Navy
        Me.txtSumTedad.Location = New System.Drawing.Point(433, 153)
        Me.txtSumTedad.Name = "txtSumTedad"
        Me.txtSumTedad.ReadOnly = True
        Me.txtSumTedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSumTedad.Size = New System.Drawing.Size(104, 23)
        Me.txtSumTedad.TabIndex = 40
        Me.txtSumTedad.TabStop = False
        Me.txtSumTedad.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "جمع کل :"
        Me.Label1.Visible = False
        '
        'pnln1
        '
        Me.pnln1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnln1.Location = New System.Drawing.Point(3, 140)
        Me.pnln1.Name = "pnln1"
        Me.pnln1.Size = New System.Drawing.Size(313, 41)
        Me.pnln1.TabIndex = 5
        Me.pnln1.Visible = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Maroon
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1272, 4)
        Me.Splitter1.TabIndex = 32
        Me.Splitter1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.SplitContainer4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1272, 482)
        Me.TabPage1.TabIndex = 13
        Me.TabPage1.Text = "مرحله9)-چاپ سند"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel6)
        Me.SplitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer4.Size = New System.Drawing.Size(1272, 482)
        Me.SplitContainer4.SplitterDistance = 311
        Me.SplitContainer4.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.btnChapLastSanad)
        Me.Panel6.Controls.Add(Me.chkprintPyear)
        Me.Panel6.Controls.Add(Me.btnPrintSanad)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel6.Size = New System.Drawing.Size(1272, 311)
        Me.Panel6.TabIndex = 2
        '
        'btnChapLastSanad
        '
        Me.btnChapLastSanad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChapLastSanad.BackColor = System.Drawing.SystemColors.Control
        Me.btnChapLastSanad.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChapLastSanad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChapLastSanad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnChapLastSanad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChapLastSanad.Location = New System.Drawing.Point(345, 154)
        Me.btnChapLastSanad.Name = "btnChapLastSanad"
        Me.btnChapLastSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnChapLastSanad.Size = New System.Drawing.Size(695, 68)
        Me.btnChapLastSanad.TabIndex = 65
        Me.btnChapLastSanad.Text = "چاپ آخرین شماره اسناد"
        Me.btnChapLastSanad.UseVisualStyleBackColor = False
        '
        'chkprintPyear
        '
        Me.chkprintPyear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkprintPyear.AutoSize = True
        Me.chkprintPyear.Location = New System.Drawing.Point(836, 63)
        Me.chkprintPyear.Name = "chkprintPyear"
        Me.chkprintPyear.Size = New System.Drawing.Size(204, 17)
        Me.chkprintPyear.TabIndex = 74
        Me.chkprintPyear.Text = "آیا انبارگردانی پایان سال قبل می باشد؟"
        Me.chkprintPyear.UseVisualStyleBackColor = True
        '
        'btnPrintSanad
        '
        Me.btnPrintSanad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSanad.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintSanad.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrintSanad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrintSanad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPrintSanad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintSanad.Location = New System.Drawing.Point(345, 86)
        Me.btnPrintSanad.Name = "btnPrintSanad"
        Me.btnPrintSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPrintSanad.Size = New System.Drawing.Size(695, 62)
        Me.btnPrintSanad.TabIndex = 32
        Me.btnPrintSanad.Text = "چاپ سند نهایی انبارگردانی"
        Me.btnPrintSanad.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel8.Size = New System.Drawing.Size(1272, 167)
        Me.Panel8.TabIndex = 2
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1280, 656)
        Me.SplitContainer1.SplitterDistance = 137
        Me.SplitContainer1.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(1280, 137)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAnbargardani)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Mirrored = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1280, 137)
        Me.TabControl1.TabIndex = 60
        '
        'TabAnbargardani
        '
        Me.TabAnbargardani.BackColor = System.Drawing.SystemColors.Control
        Me.TabAnbargardani.Controls.Add(Me.btnTabdilVaziat)
        Me.TabAnbargardani.Controls.Add(Me.ChkAll)
        Me.TabAnbargardani.Controls.Add(Me.btnTools)
        Me.TabAnbargardani.Controls.Add(Me.pnlGridMaster)
        Me.TabAnbargardani.Controls.Add(Me.pnlCommandMaster)
        Me.TabAnbargardani.Controls.Add(Me.btnStatus4_8)
        Me.TabAnbargardani.Controls.Add(Me.pnlNavigationMaster)
        Me.TabAnbargardani.Location = New System.Drawing.Point(4, 22)
        Me.TabAnbargardani.Name = "TabAnbargardani"
        Me.TabAnbargardani.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAnbargardani.Size = New System.Drawing.Size(1272, 111)
        Me.TabAnbargardani.TabIndex = 0
        Me.TabAnbargardani.Text = "تعریف انبارگردانی"
        '
        'btnTabdilVaziat
        '
        Me.btnTabdilVaziat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTabdilVaziat.BackColor = System.Drawing.SystemColors.Control
        Me.btnTabdilVaziat.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTabdilVaziat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTabdilVaziat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTabdilVaziat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTabdilVaziat.Location = New System.Drawing.Point(343, 71)
        Me.btnTabdilVaziat.Name = "btnTabdilVaziat"
        Me.btnTabdilVaziat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTabdilVaziat.Size = New System.Drawing.Size(139, 36)
        Me.btnTabdilVaziat.TabIndex = 61
        Me.btnTabdilVaziat.Text = "تبدیل وضعیت به پیش نویس"
        Me.btnTabdilVaziat.UseVisualStyleBackColor = False
        Me.btnTabdilVaziat.Visible = False
        '
        'btnTools
        '
        Me.btnTools.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTools.BackColor = System.Drawing.SystemColors.Control
        Me.btnTools.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTools.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTools.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTools.Location = New System.Drawing.Point(679, 72)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTools.Size = New System.Drawing.Size(76, 36)
        Me.btnTools.TabIndex = 59
        Me.btnTools.Text = "كمك سريع"
        Me.btnTools.UseVisualStyleBackColor = False
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(4, 4)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(1264, 65)
        Me.pnlGridMaster.TabIndex = 2
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(1084, 74)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(183, 33)
        Me.pnlCommandMaster.TabIndex = 0
        '
        'btnStatus4_8
        '
        Me.btnStatus4_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus4_8.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus4_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus4_8.Enabled = False
        Me.btnStatus4_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus4_8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus4_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus4_8.Location = New System.Drawing.Point(597, 72)
        Me.btnStatus4_8.Name = "btnStatus4_8"
        Me.btnStatus4_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus4_8.Size = New System.Drawing.Size(76, 36)
        Me.btnStatus4_8.TabIndex = 58
        Me.btnStatus4_8.Text = "ابطال انبارگردانی"
        Me.btnStatus4_8.UseVisualStyleBackColor = False
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(4, 74)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(298, 33)
        Me.pnlNavigationMaster.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.sstChild)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(1280, 515)
        Me.Panel2.TabIndex = 2
        '
        'FrmabAnbarGardani
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 656)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmabAnbarGardani"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "عملیات انبارگرداني"
        Me.sstChild.ResumeLayout(False)
        Me.Tabtag.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tabfirstamaliyat.ResumeLayout(False)
        Me.Tabstart.ResumeLayout(False)
        Me._sstChild_TabPage0.ResumeLayout(False)
        Me.TabShomaresh.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabGozaresh.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GrpRptMoghMoj.ResumeLayout(False)
        Me.GrpRptMoghMoj.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.TabSanadKasriEzafeh.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabEnteghalMjoodi.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnlg1.ResumeLayout(False)
        Me.pnlg1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabAnbargardani.ResumeLayout(False)
        Me.TabAnbargardani.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabAnbarGardani
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabAnbarGardani
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabAnbarGardani
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabAnbarGardani)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Enum NOE_REPORT
        TagGhasemWithRahgiri = 0
        tagGhasemWithoutRahgiri = 1
        TagPars = 2
        TagParsWithChideman = 3
        tagKhoram = 4
    End Enum

#Region "Variable"

    'يك ديتا ويو از نوع ابزار جهت نمايش  تعاريف انبارگرداني تعريف شده است
    Private WithEvents DVabAnbarGardani As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  تعاريف انبارگرداني تعريف شده است
    Private WithEvents DVabAnbarGardaniHA As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  تعداد شمارش تعريف شده است
    Private WithEvents DVabShomaresh As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  ثبت شمارش تعريف شده است
    Private WithEvents DVabShomareshHa As CDataView

    ' يک نمونه از فيلتر گزارشات انبار براي استفاده در فيلتر گزارش
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

    Private dclSanadDate As NetSql.Components.CDateCtrl

    '   براي نمايش تاريخ در فيلتر 
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

    Private WithEvents DvabVwreport As CDataView
    Private RptType As Integer

    Private WithEvents DvabVwreport_ke As CDataView

    Dim BRL As New ClsDataAccessRule
    Public IsTolidi As Boolean

#End Region


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


#Region "Form"

    Private Sub FrmabAnbarGardani_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load


        Dim _frmsal As New Minoo.Applications.Anbar.Common.frmSelectHesabdariSal
        _frmsal.ShowDialog()

        Me.Text = Me.Text + "         سال مالی انتخاب شده     :  " + gHesabdariSal.ToString

        'Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, 3)
        'IsTolidi = IIf(CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi"))
        IsTolidi = IsVahedTejariTolidi

        Call InitDataView()

        sstChild.SelectedIndex = 1
        sstChild.Mirrored = True

        If btnStatus1_4_Easy.Enabled = False Then
            sstChild.SelectedIndex += 1
        End If
        If btnStatus1_4.Enabled = False Then
            sstChild.SelectedIndex += 1
        End If

        ''Ghafari 950119''کنترل دسترسی نمایش دکمه های چاپ اسناد انبارگردانی
        Me.btnChapLastSanad.Enabled = gSM.ActionEnabled("btnChapLastSanad")
        Me.btnChapLastSanad.Visible = gSM.ActionVisible("btnChapLastSanad")

        Me.btnPrintSanad.Enabled = gSM.ActionEnabled("btnPrintSanad")
        Me.btnPrintSanad.Visible = gSM.ActionVisible("btnPrintSanad")
        ''Ghafari 950119''کنترل دسترسی نمایش دکمه های چاپ اسناد انبارگردانی

        ''ghasemi 14010116
        'btnTabdilVaziat.Enabled = (gSM.ActionEnabled(btnChangeStatusAnbargardani.Name) = True)
        'btnTabdilVaziat.Visible = (gSM.ActionVisible(btnChangeStatusAnbargardani.Name) = True)

        Me.btnTabdilVaziat.Enabled = gSM.ActionEnabled("btnChangeStatusAnbargardani")
        Me.btnTabdilVaziat.Visible = gSM.ActionEnabled("btnChangeStatusAnbargardani")
        ''ghasemi 14010116

        Me.WindowState = FormWindowState.Maximized

        BtnInsertUpdateMojoudiInShomaresh.Visible = gSM.ActionVisible(BtnInsertUpdateMojoudiInShomaresh.Name)
        ChkInsertUpdateAllRadif.Visible = gSM.ActionVisible(BtnInsertUpdateMojoudiInShomaresh.Name)


    End Sub

    Private Sub FrmabAnbarGardani_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.FormClosed
        Try
            DVabAnbarGardani.Done()
            DVabAnbarGardani = Nothing
            DVabAnbarGardaniHA.Done()
            DVabAnbarGardaniHA = Nothing
            DVabShomaresh.Done()
            DVabShomaresh = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Utilities"

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabAnbarGardani = New CDataView(cn)
        With DVabAnbarGardani
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abAnbarGardani"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbarGardaniStatus", "AnbarGardaniStatus",
                      "AnbarGardaniStatus")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbarGardaniType", "AnbarGardaniTypeSN",
                      "AnbarGardaniTypeSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abAnbar", "AnbarSN", "AnbarSN")
            .Text = Me.Text

            '.SQLWhere = "1=3"

            .SQLWhere = " abAnbarGardani.AnbarSN = " & CStr(gAnbarSN) & " and StartDate BETWEEN " & gHesabdariSalFDate &
            " And  " & gHesabdariSalTDate & " and EndDate BETWEEN " & gHesabdariSalFDate & " and  " & gHesabdariSalTDate &
            " And abAnbarGardani.AnbarGArdaniTypeSN=" & AnbarGardaniTypeSN

            If ChkAll.CheckState = CheckState.Unchecked Then
                .SQLWhere = .SQLWhere + " And abAnbarGardani.AnbarGardaniStatus<>8"
            End If
            .SQLOrderBy = " abAnbarGardani.AnbarSN , StartDate "
            .EditInGrid = True
            .AccessRight = gSM.TableAccessRight(.TableName)
            .AutoFetchCurrentRow = True
            With .Fields
                With .Add("AnbarGardaniSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("AnbarSN->abAnbar.AnbarDs", "DataCombo")
                    ' اعمال شرط براي نمايش اطلاعات انبار جاري
                    .ComboWhereCondition = " abAnbar.AnbarSN = " & gAnbarSN
                    .ComboLateBinding = True
                    .DefaultValue = gAnbarSN
                    .Component.Enabled = False
                    .ReadOnly = True
                End With

                With .Add("AnbarGardaniTypeSN->abAnbarGardaniType.AnbarGardaniTypeDS", "DataCombo")
                    .Caption = "نوع انبارگردانی"
                    .DefaultValue = AnbarGardaniTypeSN
                    .Component.Enabled = True
                    .ReadOnly = True
                End With

                With .Add("AnbarGardaniNO", "TextBox")
                End With
                With .Add("AnbarGardaniDS", "TextBox")
                End With
                With .Add("StartDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                                cn,
                                                                                                Functions.
                                                                                                   FTDBCommonFunctions.
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add("EndDate", "TextBox", EnumFieldOptions.foDate)
                    .DefaultValue = gHesabdariSalTDate
                    '.ReadOnly = True
                End With
                With .Add("InsDate", "TextBox", EnumFieldOptions.foHidden)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                                cn,
                                                                                                Functions.
                                                                                                   FTDBCommonFunctions.
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add("ErjaNO", "TextBox")
                End With
                With .Add("AnbarGardaniStatus->abAnbarGardani.AnbarGardaniStatusDS", "DataCombo")
                    .Caption = cn.FieldCaption("abAnbarGardani.AnbarGardaniStatus")
                    .DefaultValue = 1
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("KasriSanadSN->SanadNo")
                    .Caption = cn.FieldCaption("abAnbarGardani.KasriSanadSN")
                    .ReadOnly = True
                End With
                With .Add("SarakSanadSN->SanadNo")
                    .Caption = cn.FieldCaption("abAnbarGardani.SarakSanadSN")
                    .ReadOnly = True
                End With

                .Add("{IsRes5} As NerkhVaghee", "TextBox", EnumFieldOptions.foHidden)
                .Add("Tozih", "TextBox", EnumFieldOptions.foDefault)
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
            .Init(pnlGridKala, , pnlCommandKala, pnlNavigationKala, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdFilter _
                                                                     Or EnumButtonOptions.boCmdInsert _
                                                                     Or EnumButtonOptions.boCmdDelete _
                                                                     Or EnumButtonOptions.boCmdUpdate)
            .TableName = "abAnbarGardaniHa"
            'Dim vAddJoinKalaPhizikiSN As String
            'vAddJoinKalaPhizikiSN =
            '.AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abKalaKalaPhiziki_Anbargardani", "KalaPhizikiSN", "KalaPhizikiSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abKalaPhiziki_AnbarGArdani", "KalaPhizikiSN", "KalaPhizikiSN")
            .Text = Me.Text
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            '.SQLWhere = "1=3"
            '.SQLWhere = "abVw_KalaKalaPhiziki_Anbargardani.AnbarSN=" & gAnbarSN

            With .Fields
                With .Add("AnbarGardaniHaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("AnbarGardaniSN", , EnumFieldOptions.foHidden)
                End With
                '    With _
                '    .Add( _
                'String.Format( _
                '                "KalaPhizikiSN->{0}.{{{0}.KalaNO + ' - ' + {0}.KalaDS + ' - ' + {0}.ShomarehRahgiri  }} " & _
                '                " AS KalaPhizikiSN", vAddJoinKalaPhizikiSN), "DataCombo")
                '        .Caption = "کالا" '''''cn.FieldCaption("abAnbarGardaniHa.KalaPhizikiSN")
                '        .ComboWhereCondition = "AnbarSN=" & gAnbarSN & " AND KalaPhizikiMoaserDate BETWEEN '" & _
                '                                gHesabdariSalFDate & "' AND  '" & gHesabdariSalTDate & "'"
                '        '//Izadpanah-851215-فقط کالاي همين انبار را نمايش دهد
                '    End With

                With .Add("KalaPhizikiSN->abKalaPhiziki_AnbarGArdani.KalaRahgiri AS KalaDS", "DataCombo")
                    .Caption = "نام کالا"
                    .ComboWhereCondition = "abKalaPhiziki_AnbarGArdani.MoaserDate Between  '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "'"
                    '.RefreshCombo()
                End With

                With .Add("KalaPhizikiSN->abKalaPhiziki_AnbarGArdani.ShomarehRahgiri AS ShomarehRahgiri", "DataCombo")
                    .Caption = "کد رهگیری"
                    .ReadOnly = True
                    '.ComboWhereCondition = "abKalaPhiziki_AnbarGArdani.MoaserDate Between  '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "'"
                End With

                With .Add("RecChksum", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "رتبه گردش"
                    .ReadOnly = True
                End With

                If IsTolidi Then
                    With .Add("{Cast(abKalaPhiziki_AnbarGArdani.Nerkh AS Bigint)} As Nerkh", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "نرخ واقعی"
                        .ReadOnly = True
                        .Format = "#,###"
                    End With

                End If



                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                '.Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabAnbarGardani
        End With

        DVabShomaresh = New CDataView(cn)
        With DVabShomaresh
            .Init(PnlGridDet1, , PnlCommandDet1, PnlNavigationDet1, EnumButtonOptions.boNone)
            .TableName = "abShomaresh"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abShomareshStatus", "ShomareshStatus", "ShomareshStatus")
            .AccessRight = EnumAccessRight.arView
            .Text = FTDD.GetCaption(.TableName)
            .SQLOrderBy = " ISNULL(ShomareshSN,StartDate)"
            .EditInGrid = True
            .AutoFetchCurrentRow = True
            With .Fields
                With .Add("ShomareshSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("AnbarGardaniSN", , EnumFieldOptions.foHidden)
                End With
                With .Add("ShomareshNO", "TextBox", EnumFieldOptions.foDefault)
                End With
                With .Add("ShomareshDS", "TextBox", EnumFieldOptions.foDefault)
                End With
                With .Add("StartDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("EndDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("InsDate", "TextBox", EnumFieldOptions.foHidden)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                    .DateFormat = EnumDateFormat.dfFullYear
                End With
                With .Add("ShomareshStatus->abShomareshStatus.ShomareshStatusDS", "DataCombo")
                    .Caption = cn.FieldCaption("abShomaresh.ShomareshStatus")
                    .DefaultValue = 1
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabAnbarGardani
        End With

        DVabShomareshHa = New CDataView(cn)
        With DVabShomareshHa
            .Init(picGridDet2, , picCommandDet2, picNavigationDet2, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdFilter _
                                                                     Or EnumButtonOptions.boCmdInsert _
                                                                     Or EnumButtonOptions.boCmdDelete _
                                                                     Or EnumButtonOptions.boCmdUpdate)
            .TableName = "abShomareshHa"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVwj_abAnbarGardaniHa", "AnbarGardaniHaSN",
                      "AnbarGardaniHaSN")
            .AccessRight = gSM.TableAccessRight(.TableName)
            .Text = FTDD.GetCaption(.TableName)
            '.SQLWhere = "1=1" '' "abVwj_abAnbarGardaniHa.AnbarGardaniSN = " & Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            .SQLOrderBy = " abVwj_abAnbarGardaniHa.KalaShomarehRahgiri ,abVwj_abAnbarGardaniHa.ShomarehRahgiri"
            .EditInGrid = True

            With .Fields
                With .Add("ShomareshHaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("ShomareshSN", "DataCombo", EnumFieldOptions.foHidden)

                With .Add("ShomarandehSN", "TextBox")
                    .Caption = "رتبه گردش"
                    .Format = "#.#"
                    .ReadOnly = True
                End With

                With .Add("AnbarGardaniHaSN->abVwj_abAnbarGardaniHa.KalaShomarehRahgiri", "DataCombo") ' <Disabled>")
                    .Caption = "کالا"
                    .ComboLateBinding = True
                    .ComboWhereCondition = "abVwj_abAnbarGardaniHa.AnbarGardaniSN=" & Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
                End With

                With .Add("abVwj_abAnbarGardaniHa.ShomarehRahgiri", "") ' <Disabled>")
                    .Caption = "شماره رهگيري"
                    .ComboLateBinding = True
                    .ReadOnly = True
                End With
                With .Add("Meghdar", "TextBox", EnumFieldOptions.foDefault)
                    .Format = "#,#.##"
                    .DataType = "double"
                End With
                With .Add("{Case when Meghdar = 0 then 'مقدار صفر' when Meghdar is null then 'بدون مقدار' else '' end} As MeghdarText", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "مقدار صفر / بدون مقدار"
                    .ReadOnly = True
                End With

                If IsTolidi Then
                    With .Add("{Cast(abVwj_abAnbarGardaniHa.Nerkh AS BigInt)} As Nerkh", "TextBox", EnumFieldOptions.foDefault)
                        .Caption = "نرخ واقعی"
                        .ReadOnly = True
                        .Format = "#,###"
                    End With
                End If

                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabShomaresh
        End With

        DVabAnbarGardani.Refresh()

    End Sub

    Private Sub InitDataViewshomaresh()
        If DVabShomaresh Is Nothing Then
            DVabShomaresh = New CDataView(cn)
            With DVabShomaresh
                .Init(PnlGridDet1, , PnlCommandDet1, PnlNavigationDet1, EnumButtonOptions.boNone)
                .TableName = "abShomaresh"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abShomareshStatus", "ShomareshStatus", "ShomareshStatus")
                .AccessRight = EnumAccessRight.arView
                .Text = FTDD.GetCaption(.TableName)
                .SQLWhere = "AnbarGardaniSN = " & Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
                .SQLOrderBy = " ISNULL(ShomareshNO,StartDate)"
                .EditInGrid = True
                With .Fields
                    With .Add("ShomareshSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    With .Add("AnbarGardaniSN", , EnumFieldOptions.foHidden)
                    End With
                    With .Add("ShomareshNO", "TextBox", EnumFieldOptions.foDefault)
                    End With
                    With .Add("ShomareshDS", "TextBox", EnumFieldOptions.foDefault)
                    End With
                    With .Add("StartDate", "TextBox", EnumFieldOptions.foDate)
                        ' تهيه تاريخ از سرور
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                        .DateFormat = EnumDateFormat.dfFullYear
                    End With
                    With .Add("EndDate", "TextBox", EnumFieldOptions.foDate)
                        ' تهيه تاريخ از سرور
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                        .DateFormat = EnumDateFormat.dfFullYear
                    End With
                    With .Add("InsDate", "TextBox", EnumFieldOptions.foHidden)
                        ' تهيه تاريخ از سرور
                        .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                        .DateFormat = EnumDateFormat.dfFullYear
                    End With
                    With .Add("ShomareshStatus->abShomareshStatus.ShomareshStatusDS", "DataCombo")
                        .Caption = cn.FieldCaption("abShomaresh.ShomareshStatus")
                        .DefaultValue = 1
                        .Component.Enabled = False
                        .ReadOnly = True
                    End With
                    With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = gSM.UserID_Name
                    End With
                    With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = System.Environment.MachineName
                    End With
                    .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
                End With
                .Parent = DVabAnbarGardani
            End With
            DVabShomareshHa = New CDataView(cn)
            With DVabShomareshHa
                .Init(picGridDet2, , picCommandDet2, picNavigationDet2, EnumButtonOptions.boCmdModify _
                                                                         Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter)
                .TableName = "abShomareshHa"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVwj_abAnbarGardaniHa", "AnbarGardaniHaSN",
                          "AnbarGardaniHaSN")
                .AccessRight = gSM.TableAccessRight(.TableName)
                .Text = FTDD.GetCaption(.TableName)
                .SQLWhere = "abVwj_abAnbarGardaniHa.AnbarGardaniSN = " & Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
                .SQLOrderBy = " abVwj_abAnbarGardaniHa.KalaShomarehRahgiri ,abVwj_abAnbarGardaniHa.ShomarehRahgiri"
                .EditInGrid = True

                With .Fields
                    With .Add("ShomareshHaSN", , gSNFieldOption)
                        .DefaultValue = gSM.Identifier
                    End With
                    .Add("ShomareshSN", "DataCombo", EnumFieldOptions.foHidden)
                    With .Add("AnbarGardaniHaSN->abVwj_abAnbarGardaniHa.KalaShomarehRahgiri", "DataCombo") ' <Disabled>")
                        .Caption = "کالا"
                        .ComboLateBinding = True
                        .ComboWhereCondition = "abVwj_abAnbarGardaniHa.AnbarGardaniSN=" & Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
                    End With

                    With .Add("abVwj_abAnbarGardaniHa.ShomarehRahgiri", "") ' <Disabled>")
                        .Caption = "شماره رهگيري"
                        .ComboLateBinding = True
                        .ReadOnly = True
                    End With

                    'With _
                    '    .Add("ChidemanSN->abChideman.{ChidemanNo + ' - ' +  ChidemanDs} AS ChidemanSN ", "DataCombo", _
                    '          EnumFieldOptions.foHidden)
                    '    .ComboLateBinding = True
                    'End With
                    'With _
                    '    .Add("ShomarandehSN->abShomarandeh.{ShomarandehNO + ' _ ' + ShomarandehDS} AS ShomarandehSN", _
                    '          "DataCombo", EnumFieldOptions.foHidden)
                    'End With
                    With .Add("Meghdar", "TextBox")
                        .Format = "#.#"
                    End With
                    With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = gSM.UserID_Name
                    End With
                    With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                        .DefaultValue = System.Environment.MachineName
                    End With
                    .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
                    '.Add("abVwj_abAnbarGardaniHa.KalaSN AS KalaSN", , EnumFieldOptions.foHidden)
                End With
                .Parent = DVabShomaresh
            End With
            DVabAnbarGardani.AutoFetchCurrentRow = True
            DVabAnbarGardani.FetchCurRecord()
        End If
    End Sub

    Private Sub Avaldoreh()

        dclFDate = New NetSql.Components.CDateCtrl(tp)
        'dclFDate.TextBox = txtFDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        'dclTDate.TextBox = txtTDate
        dclFDate.Value = gHesabdariSalFDate
        dclTDate.Value = gHesabdariSalTDate
    End Sub

    Private Sub MoghayeratAnbarGArdani()
        If OptMoghBetSho.Checked = True Then
            dcbFShomareshKhas.Enabled = True
        Else
            dcbFShomareshKhas.Enabled = False
        End If
    End Sub

    Private Sub InitReport(dv As DataView)

        'If pISLoaded Then
        '    Exit Sub
        'End If
        'pISLoaded = True
        If DvabVwreport Is Nothing Then
            DvabVwreport = New CDataView(cn)
            With DvabVwreport
                ''''''''''''''''''''''''''''
                .Init(Pnlg, , pnlc, pnlN, EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdPrint)
                .Text = Me.Text
                .EditInGrid = False
                .NextRowAfterSave = False
                .FlexGrid.SelectionMode = SelModeSettings.flexSelectionListBox
            End With
        End If

        DvabVwreport.DataSource = dv
        DvabVwreport.Refresh()
        If RptType = 2 Or RptType = 3 Then
            DvabVwreport.FlexGrid.ColHidden(4) = True
            DvabVwreport.FlexGrid.ColHidden(5) = True
        Else ''If RptType = 1 Or RptType = 4 Then
            DvabVwreport.FlexGrid.ColHidden(1) = True
            DvabVwreport.FlexGrid.ColHidden(5) = True
            DvabVwreport.FlexGrid.ColHidden(6) = True
            DvabVwreport.FlexGrid.ColHidden(14) = True
            DvabVwreport.FlexGrid.ColHidden(15) = True
        End If
        DvabVwreport.FlexGrid.ColDataType(6) = GetType(Decimal)
        DvabVwreport.FlexGrid.ColDataType(7) = GetType(Decimal)
        DvabVwreport.FlexGrid.ColFormat(7) = "#,###.###"
        DvabVwreport.FlexGrid.ColDataType(8) = GetType(Decimal)
        DvabVwreport.FlexGrid.ColFormat(8) = "#,###.###"

        DvabVwreport.FlexGrid.ColFormat(DvabVwreport.FlexGrid.ColIndex("Meghdar1")) = "#,###.###"
        DvabVwreport.FlexGrid.ColFormat(DvabVwreport.FlexGrid.ColIndex("Moghayerat")) = "#,###.###"


        If RptType = 1 Or RptType = 4 Then
            DvabVwreport.FlexGrid.ColDataType(9) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(9) = "#,###.###"

            DvabVwreport.FlexGrid.ColDataType(10) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(10) = "#,###.###"

            DvabVwreport.FlexGrid.ColDataType(11) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(11) = "#,###.###"

            DvabVwreport.FlexGrid.ColDataType(16) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(16) = "#,###.###"

            DvabVwreport.FlexGrid.ColDataType(17) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(17) = "#,###.###"

            DvabVwreport.FlexGrid.ColDataType(18) = GetType(Decimal)
            DvabVwreport.FlexGrid.ColFormat(18) = "#,###.###"
            DvabVwreport.FlexGrid.ColFormat(DvabVwreport.FlexGrid.ColIndex("Kasri")) = "#,###.###"
            DvabVwreport.FlexGrid.ColFormat(DvabVwreport.FlexGrid.ColIndex("Ezafeh")) = "#,###.###"
        End If


        DvabVwreport.FlexGrid.AutoSizeMode = AutoSizeSettings.flexAutoSizeColWidth
        DvabVwreport.FlexGrid.Refresh()
    End Sub

    Private Sub InitSanadKasriEzafeh()
        btnDarjSanad_KE.Enabled = True
    End Sub

    Private Sub Sabtsanadkasriezafeh(dv As DataView, vAnbarGardaniSN As Decimal, Iskasri As Boolean, SanadDate As String)
        Try
            Dim i, j As Integer
            Dim _msg As String = ""
            Dim Ds As New DsAnbargardani
            Dim cls As New ClsDataAccessRule
            Dim dvmojoodi As DataView
            If Iskasri = True Then
                dvmojoodi = cls.GetMojoodikalaphiziki(gVahedeTejariSN, gAnbarSN, 0, gHesabdariSalFDate, gHesabdariSalTDate, cn)
            End If
            For i = 0 To dv.Count - 1
                '''''If dv(i)("KalaSN") = "42164.935" Then
                '''''    dv(i)("KalaSN") = "42164.935"
                '''''End If
                If IIf(dv(i)("Auto") Is DBNull.Value, 0, dv(i)("Auto")) = 2 Or
                    IIf(dv(i)("Ezafeh") Is DBNull.Value, 0, dv(i)("Ezafeh")) > 0 Then
                    Dim MyRow As DataRow = Ds.Tables("tblKasriezafeh").NewRow
                    MyRow("KalaSN") = dv.Item(i).Item("KalaSN")
                    MyRow("KalaPhizikiSN") = dv.Item(i).Item("KalaPhizikiSN")
                    MyRow("Shomarehrahgiri") = dv.Item(i).Item("Shomarehrahgiri")
                    MyRow("Ezafeh") = IIf(dv.Item(i).Item("Ezafeh") Is DBNull.Value, 0, dv.Item(i).Item("Ezafeh"))
                    MyRow("Kasri") = IIf(dv.Item(i).Item("Kasri") Is DBNull.Value, 0, dv.Item(i).Item("Kasri"))
                    Ds.Tables("tblKasriezafeh").Rows.Add(MyRow)
                Else
                    Dim _KalaSn As Decimal = dv.Item(i).Item("KalaSN")
                    Dim _Kasri As Decimal = dv.Item(i).Item("Kasri")
                    Dim _Kasri2 As Decimal = 0
                    Dim dv2 As DataView = New DataView(dvmojoodi.Table, "KalaSn=" & _KalaSn, "", DataViewRowState.CurrentRows)
                    For j = 0 To dv2.Count - 1
                        If _Kasri <= dv2.Item(j).Item("Mojoodi") Then
                            Dim MyRow As DataRow = Ds.Tables("tblKasriezafeh").NewRow
                            MyRow("KalaSN") = dv.Item(i).Item("KalaSN")
                            MyRow("KalaPhizikiSN") = dv2.Item(j).Item("KalaPhizikiSN")
                            MyRow("Shomarehrahgiri") = dv.Item(i).Item("Shomarehrahgiri")
                            MyRow("Ezafeh") = 0
                            MyRow("Kasri") = _Kasri
                            Ds.Tables("tblKasriezafeh").Rows.Add(MyRow)
                            Exit For
                        Else
                            Dim MyRow As DataRow = Ds.Tables("tblKasriezafeh").NewRow
                            MyRow("KalaSN") = dv.Item(i).Item("KalaSN")
                            MyRow("KalaPhizikiSN") = dv2.Item(j).Item("KalaPhizikiSN")
                            MyRow("Shomarehrahgiri") = dv.Item(i).Item("Shomarehrahgiri")
                            MyRow("Ezafeh") = 0
                            MyRow("Kasri") = dv2.Item(j).Item("Mojoodi")
                            Ds.Tables("tblKasriezafeh").Rows.Add(MyRow)
                            _Kasri = _Kasri - dv2.Item(j).Item("Mojoodi")
                        End If
                    Next
                End If
            Next

            _msg = SaveKasriEzafehToDatabase(Ds, vAnbarGardaniSN, SanadDate)
            If _msg <> "0" Then
                MsgBox("اشکال در ثبت اسناد کسری و اضافه انبارگردنی" + vbCrLf + _msg, MsgBoxStyle.OkOnly, "پیغام")
            Else
                MsgBox(" ثبت اسناد کسری و اضافه انبارگردنی با موفقیت انجام شد", MsgBoxStyle.OkOnly, "پیغام")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function SaveKasriEzafehToDatabase(ds As DsAnbargardani, vAnbarGardaniSN As Decimal, SanadDate As String) As String
        Dim _ErrMsg As String = ""
        Try
            If ds.Tables("tblKasriezafeh").Rows.Count <> 0 Then
                Dim _XmlKasri As String = "<DsAnbargardani>"
                Dim _XmlEzafeh As String = "<DsAnbargardani>"
                Dim i As Integer = 1
                Dim j As Integer = 1
                For Each dr As DataRow In ds.Tables("tblKasriezafeh").Rows
                    If dr("Ezafeh") <> 0 Then
                        _XmlEzafeh = _XmlEzafeh &
                        "<tblKasriezafeh><ID>" + CStr(i) + "</ID>" &
                        "<KalaSn>" + CStr(dr("KalaSn")) + "</KalaSn>" &
                        "<KalaPhizikiSn>" + CStr(dr("KalaPhizikiSn")) + "</KalaPhizikiSn>" &
                        "<Meghdar>" + CStr(dr("Ezafeh")) + "</Meghdar></tblKasriezafeh>-"
                        i += 1
                    Else
                        _XmlKasri = _XmlKasri &
                        "<tblKasriezafeh><ID>" + CStr(j) + "</ID>" &
                        "<KalaSn>" + CStr(dr("KalaSn")) + "</KalaSn>" &
                        "<KalaPhizikiSn>" + CStr(dr("KalaPhizikiSn")) + "</KalaPhizikiSn>" &
                        "<Meghdar>" + CStr(dr("Kasri")) + "</Meghdar></tblKasriezafeh>-"
                        j += 1
                    End If
                Next


                If i > 1 Then
                    _XmlEzafeh = _XmlEzafeh.Substring(0, Len(_XmlEzafeh) - 1)
                    _XmlEzafeh = _XmlEzafeh + "</DsAnbargardani>"

                    cn.CallSP("_abSp_AnbargardaniKasriEzafeh_InsertByXml", gVahedeTejariSN, vAnbarGardaniSN,
                               gAnbarSN, SanadDate, EnumTarakoneshSN.EZAFI_MOJOODI_ANBAR_RESID, _XmlEzafeh,
                               gSM.Identifier, gSM.UserID_Name, System.Environment.MachineName, _ErrMsg)
                End If
                If j > 1 Then
                    _XmlKasri = _XmlKasri.Substring(0, Len(_XmlKasri) - 1)
                    _XmlKasri = _XmlKasri + "</DsAnbargardani>"

                    cn.CallSP("_abSp_AnbargardaniKasriEzafeh_InsertByXml", gVahedeTejariSN, vAnbarGardaniSN,
                               gAnbarSN, SanadDate, EnumTarakoneshSN.KASRI_MOJOODI_ANBAR_HAVALE, _XmlKasri,
                               gSM.Identifier, gSM.UserID_Name, System.Environment.MachineName, _ErrMsg)
                End If
            Else
                cn.CallSP("_abSp_AnbargardaniKasriEzafeh_InsertByXml", gVahedeTejariSN, vAnbarGardaniSN,
                gAnbarSN, SanadDate, 0, "",
                gSM.Identifier, gSM.UserID_Name, System.Environment.MachineName, _ErrMsg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return _ErrMsg

    End Function
    '' Made by AliAsghar Tavakoli
    Function GetExcelKalaNotInAnbar(ByVal table As DataTable)
        Try
            Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems
            _SharedItems.ExcellExport("کالاهای گردش دار ", table)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکالی در ساخت فایل اکسل به وجود آمده است.", MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
        End Try
    End Function

#End Region

#Region "Button"

    Private Sub btnDarjKalaPhiziki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDarjKalaPhiziki.Click

        ' درج کالافيزيکي در انبارگرداني مورد نظر
        Dim vAnbarGardaniSN, vKalaGardeshDar, vKalaMandehDar As Decimal
        Dim vKalaGardeshAll As Decimal
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN As String

        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleKalaWhere = True
            .FilterNoeAnbarSN = gNoeAnbarSN
            .ShowDialog(Me)
        End With

        ' use filter
        If VFilterAsnadAnbar.DialogResult = DialogResult.OK Then

            vKalaGardeshDar = 0
            vKalaMandehDar = 0
            vKalaGardeshAll = 0
            With VFilterAsnadAnbar
                If .SelectedKalaGardeshDar = 1 Then
                    vKalaGardeshDar = 1
                ElseIf .SelectedKalaMandehDar = 1 Then
                    vKalaMandehDar = 1
                ElseIf Trim(.SelectedKalaGardeshAll) <> "" Then
                    vKalaGardeshAll = 1
                End If

                vStrKalaSN = ""
                If Trim(.SelectedKalaSN) <> "" Then
                    vStrKalaSN = .SelectedKalaSN
                End If

                vStrFilterSelectedGoroohSN = ""
                If Trim(.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                    vStrFilterSelectedGoroohSN = .GoroohBandi_Kala_FilterSelectedGoroohSN
                End If

            End With
            ' use filter

            vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            If vAnbarGardaniSN <> 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                ' درج کالافيزيکي با توجه به انتخاب هاي انجام شده در بالا
                cn.CallSP("_abSP_Ins_abAnbarGardaniHa", gAnbarSN, gNoeAnbarSN, vAnbarGardaniSN _
                           , gHesabdariSalFDate, gHesabdariSalTDate _
                           , vKalaGardeshDar, vKalaMandehDar, vKalaGardeshAll _
                           , gSM.Identifier, gSM.UserID_Name _
                           , vStrKalaSN, vStrFilterSelectedGoroohSN)
                DVabAnbarGardaniHA.Refresh()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            End If
        End If
    End Sub

    Private Sub btnDelSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDelSelected.Click

        ' امکاني براي حذف گروهي اقلام 
        'Dim vAnbarGardaniHaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_abAnbarGardaniHaSN() As Decimal
        Dim VCount_AnbarGardaniHaSN As Short
        If DVabAnbarGardaniHA.DataRows <= 0 Then
            Exit Sub
        End If
        With DVabAnbarGardaniHA
            If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) <> 1 And
                Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) <> 4 Then
                Exit Sub
            End If

            If _
                NetSql.Common.CSystem.MsgBox(" آيا رکوردهاي انتخاب شده حذف گردد ؟ ",
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVabAnbarGardaniHA.FlexGrid
                    VCount_AnbarGardaniHaSN = .SelectedRows
                    ReDim V_ar_abAnbarGardaniHaSN(VCount_AnbarGardaniHaSN)
                    For i = 0 To VCount_AnbarGardaniHaSN - 1
                        V_ar_abAnbarGardaniHaSN(i) =
                            Val(.TextMatrix(.SelectedRow(i), .ColIndex("AnbarGardaniHaSN")))
                    Next
                End With
                ' حذف تک تک رکوردهاي انتخاب شده 
                For i = 0 To VCount_AnbarGardaniHaSN - 1
                    vSN = Val(V_ar_abAnbarGardaniHaSN(i))
                    If vSN <> 0 Then
                        Try
                            cn.CallSP("abAnbarGardaniHa_Delete", vSN)
                        Catch ex As Exception
                            MsgBox("اشکال در حذف کالای انتخابی" + vbCrLf + "لطفا از عدم وجود کالای انتخابی در ثبت شمارش ها مطمئن شوید", MsgBoxStyle.OkOnly, "توجه")
                            Exit For
                        End Try

                    End If
                Next
                DVabAnbarGardaniHA.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With

    End Sub

    Private Sub btnStatus1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStatus1_4.Click
        ' شروع انبار گردانی و 
        ' تبديل رکورد از حالت پيشنويس به در حين اجرا
        Dim vli_NewVaziat As Short
        Dim vErrMsg As String = ""
        'Dim vSanadSN As Object

        If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 1 Then
            vli_NewVaziat = 4
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا انبارگرداني مورد نظر شروع گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                             + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading +
                                                             MsgBoxStyle.MsgBoxRight _
                      , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        ' فراخواني اس پي براي تغيير وضعيت رکورد انبارگرداني
        cn.CallSP("_abSPC_Change_AnbarGardaniStatus", gAnbarSN, DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
                   , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            MsgBox("عملیات شروع انبارگردانی انجام شد", MsgBoxStyle.OkOnly, "پیغام")
            DVabAnbarGardani.AutoFetchCurrentRow = True
            DVabAnbarGardani.FetchCurRecord()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnStatus4_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStatus4_8.Click

        ' تبديل رکورد از حالت حين اجرا به ابطال 
        Dim vli_NewVaziat As Short
        Dim vErrMsg As String
        'Dim vSanadSN As Object
        If Not (DVabAnbarGardani.AccessRight And EnumAccessRight.arUpdate) <> 0 Then Exit Sub
        If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 4 Then
            vli_NewVaziat = 8
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا انبارگرداني مورد نظر ابطال گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                              + MsgBoxStyle.DefaultButton2 +
                                                              MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                      , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        ' فراخواني اس پي براي تغيير وضعيت رکورد انبارگرداني
        cn.CallSP("_abSPC_Change_AnbarGardaniStatus", gAnbarSN, DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
                   , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            MsgBox("عملیات ابطال انبارگردانی انجام شد", MsgBoxStyle.OkOnly, "پیغام")
            DVabAnbarGardani.AutoFetchCurrentRow = True
            DVabAnbarGardani.FetchCurRecord()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    'Private Sub btnStatus4_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    '    ' تبديل رکورد از حالت از در حين اجرا  به  پايان شمارش انبارگرداني
    '    Dim vli_NewVaziat As Short
    '    Dim vErrMsg As String
    '    'Dim vSanadSN As Object
    '    If Not DVabAnbarGardani.CommandEnabled(EnumCommands.cmAdd) Then Exit Sub
    '    If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 4 Then
    '        vli_NewVaziat = 12
    '    Else
    '        Exit Sub
    '    End If

    '    If _
    '        NetSql.Common.CSystem.MsgBox("آيا انبارگرداني مورد نظر به وضعيت پايان شمارش تبديل گردد؟", _
    '                   MsgBoxStyle.Question + MsgBoxStyle.YesNo _
    '                   + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
    '                   , Me.Text) <> MsgBoxResult.Yes Then
    '        Exit Sub
    '    End If

    '    ' فراخواني اس پي براي تغيير وضعيت رکورد انبارگرداني
    '    cn.CallSP("_abSPC_Change_AnbarGardaniStatus", gAnbarSN, DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
    '               , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '    If vErrMsg <> "" Then
    '        NetSql.Common.CSystem.MsgBox(vErrMsg, _
    '                   MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) + _
    '                   MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
    '    Else
    '        DVabAnbarGardani.FetchCurRecord()
    '    End If
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    'End Sub

    Private Sub btnTagElsagh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTagElsagh.Click

        ' چاپ تگ انبارگرداني بر اساس تگ الصاق
        Dim vRptTagElsaghAnbarGardani As New Minoo.Applications.Anbar.Report.RptTagElsaghAnbarGardani
        Dim vSelected As String
        If DVabAnbarGardani.Fields("AnbarGardaniSN").Value <> 0 Then
            vSelected = " SELECT      " &
                        "   KalaNo, KalaDs, TedadAjza , ShomarehRahgiri , VahedeSanjeshDs  , ChidemanNo" &
                        " FROM abVw_TagAnbarGardani " &
                        " WHERE  AnbarGardaniSN = " + CStr(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            With vRptTagElsaghAnbarGardani
                .PageSettings.PaperKind = Printing.PaperKind.Custom
                .PageSettings.PaperHeight = Minoo.Applications.Anbar.Report.RptTagElsaghAnbarGardani.CmToInch(27)
                .PageSettings.PaperWidth = Minoo.Applications.Anbar.Report.RptTagElsaghAnbarGardani.CmToInch(27)
                .PageSettings.Margins.Top = 0
                .PageSettings.Margins.Left = 0
                .PageSettings.Margins.Right = 0
                .DefField()
                .DataSource = cn.ExecuteQuery(vSelected)
                .txtSherkat.Text = gAnbarDS
                .txtSal.Text = gHesabdariSalFDate + " _ " + gHesabdariSalTDate
                Minoo.Reports.FTReportViewer.ShowReport(vRptTagElsaghAnbarGardani, Me.MdiParent)
            End With
        End If

    End Sub

    Private Sub btnTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTag.Click

        ' چاپ تگ انبارگرداني بر اساس تگ انبار
        Dim vRptTagAnbarGardani As New Minoo.Applications.Anbar.Report.RptTagAnbarGardani
        Dim vSelected As String
        If DVabAnbarGardani.Fields("AnbarGardaniSN").Value <> 0 Then
            vSelected = " SELECT      " &
                        "   KalaNo, KalaDs, TedadAjza , ShomarehRahgiri , VahedeSanjeshDs  , ChidemanNo" &
                        " FROM abVw_TagAnbarGardani " &
                        " WHERE  AnbarGardaniSN = " + CStr(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)

            With vRptTagAnbarGardani
                .PageSettings.PaperKind = Printing.PaperKind.Custom
                .PageSettings.PaperHeight = Minoo.Applications.Anbar.Report.RptTagAnbarGardani.CmToInch(27)
                .PageSettings.PaperWidth = Minoo.Applications.Anbar.Report.RptTagAnbarGardani.CmToInch(27)
                .PageSettings.Margins.Top = 0
                .PageSettings.Margins.Left = 0
                .PageSettings.Margins.Right = 0
                .DefField()
                .DataSource = cn.ExecuteQuery(vSelected)
                .txtSherkat.Text = gAnbarDS
                .txtSal.Text = gHesabdariSalFDate + " _ " + gHesabdariSalTDate
                Try
                    Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardani, Me.MdiParent)
                Catch ex As Exception
                    .PageSettings.PaperKind = Printing.PaperKind.A4
                    Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardani, Me.MdiParent)
                End Try
            End With
        End If

    End Sub

    Private Sub btnTagPars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTagPars.Click

        ' چاپ تگ انبارگرداني بر اساس تگ پارس
        Dim vRptTagAnbarGardaniPars As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniPars

        Dim vSelected As String
        If DVabAnbarGardani.Fields("AnbarGardaniSN").Value <> 0 Then
            vSelected = " SELECT      " &
                        "   KalaNo, KalaDs, TedadAjza , ShomarehRahgiri , VahedeSanjeshDs , ChidemanNo " &
                        " FROM abVw_TagAnbarGardani " &
                        " WHERE  AnbarGardaniSN = " + CStr(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) &
                        " ORDER BY ChidemanNo , KalaNo, ShomarehRahgiri "

            With vRptTagAnbarGardaniPars
                '.PageSettings.PaperKind = Printing.PaperKind.Custom
                '.PageSettings.PaperWidth = .CmToInch(18.77)
                '.PageSettings.PaperHeight = .CmToInch(27.81)
                '.PageSettings.Margins.Top = .CmToInch(0.6)
                '.PageSettings.Margins.Bottom = .CmToInch(0.7)
                '.PageSettings.Margins.Left = .CmToInch(3.6)
                '.PageSettings.Margins.Right = .CmToInch(3.7)
                .DefField()
                .DataSource = cn.ExecuteQuery(vSelected)

                Dim _
                    vahedeTejariDs As String =
                        cn.ExecuteQuery(
                                         "Select isnull(VahedeTejariDS,'') From PavahedeTejari Where VahedeTejariSN= " &
                                         gVahedeTejariSN).Table.Rows(0).Item(0)
                '//By Izadpanah-851208
                '//By Izadpanah-851208
                .txtSherkat.Text = gAnbarDS
                .lblVahedeTejariDS.Text = vahedeTejariDs
                .txtSherkat1.Text = gAnbarDS
                .lblVahedeTejariDS1.Text = vahedeTejariDs
                .txtSherkat2.Text = gAnbarDS
                .lblVahedeTejariDS2.Text = vahedeTejariDs
                '//By Izadpanah-851208

                Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars, Me.MdiParent)

            End With

        End If
    End Sub

    Private Sub btnTagPars2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTagPars2.Click

        ' چاپ تگ انبارگرداني بر اساس تگ پارس
        Dim vRptTagAnbarGardaniPars2 As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniPars2
        Dim vSelected As String
        If DVabAnbarGardani.Fields("AnbarGardaniSN").Value <> 0 Then
            vSelected = " SELECT      " &
                        "   KalaNo, KalaDs, TedadAjza , ShomarehRahgiri , VahedeSanjeshDs , ChidemanNo " &
                        " FROM abVw_TagAnbarGardani " &
                        " WHERE  AnbarGardaniSN = " + CStr(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) &
                        " ORDER BY ChidemanNo , KalaNo, ShomarehRahgiri "

            With vRptTagAnbarGardaniPars2
                '.PageSettings.PaperKind = Printing.PaperKind.Custom
                '.PageSettings.PaperWidth = .CmToInch(18.77)
                '.PageSettings.PaperHeight = .CmToInch(27.81)
                '.PageSettings.Margins.Top = .CmToInch(0.6)
                '.PageSettings.Margins.Bottom = .CmToInch(0.7)
                '.PageSettings.Margins.Left = .CmToInch(3.6)
                '.PageSettings.Margins.Right = .CmToInch(3.7)
                .DefField()
                .DataSource = cn.ExecuteQuery(vSelected)

                Dim _
                    vahedeTejariDs As String =
                        cn.ExecuteQuery(
                                         "Select isnull(VahedeTejariDS,'') From PavahedeTejari Where VahedeTejariSN= " &
                                         gVahedeTejariSN).Table.Rows(0).Item(0)
                '//By Izadpanah-851208
                '//By Izadpanah-851208
                .txtSherkat.Text = gAnbarDS
                .lblVahedeTejariDS.Text = vahedeTejariDs
                .txtSherkat1.Text = gAnbarDS
                .lblVahedeTejariDS1.Text = vahedeTejariDs
                .txtSherkat2.Text = gAnbarDS
                .lblVahedeTejariDS2.Text = vahedeTejariDs
                '//By Izadpanah-851208

                Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars2, Me.MdiParent)

            End With

        End If

    End Sub

    Private Sub btnTagGhasem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTagGhasem.Click

        ' چاپ تگ انبارگرداني بر اساس تگ پارس
        Dim vRptTagAnbarGardaniGhasem As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniGhasem
        Dim vSelected As String
        If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) <> 0 Then
            vSelected = " SELECT      " &
                        "   KalaNo, KalaDs, TedadAjza , ShomarehRahgiri , VahedeSanjeshDs , ChidemanNo" &
                        " FROM abVw_TagAnbarGardani " &
                        " WHERE  AnbarGardaniSN = " + CStr(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) &
                        " ORDER BY ChidemanNo , KalaNo, ShomarehRahgiri "

            With vRptTagAnbarGardaniGhasem
                '.PageSettings.PaperKind = Printing.PaperKind.Custom
                '.PageSettings.PaperWidth = .CmToInch(18.77)
                '.PageSettings.PaperHeight = .CmToInch(27.81)
                '.PageSettings.Margins.Top = .CmToInch(0.6)
                '.PageSettings.Margins.Bottom = .CmToInch(0.7)
                '.PageSettings.Margins.Left = .CmToInch(3.6)
                '.PageSettings.Margins.Right = .CmToInch(3.7)
                .DefField()
                .DataSource = cn.ExecuteQuery(vSelected)
                Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniGhasem, Me.MdiParent)
            End With
        End If


    End Sub

    Private Sub btnStatus1_4_Easy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStatus1_4_Easy.Click
        Try

            ' اقدامات مقدماتی انبار گردانی

            Dim vli_NewVaziat As Short
            Dim vErrMsg As String = ""
            Dim vDataTableKalaNotInAnbarKala As DataTable
            If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 1 Then
                vli_NewVaziat = 4
            Else
                Exit Sub
            End If

            If _
                NetSql.Common.CSystem.MsgBox("آيا انبارگرداني مورد نظر با حذف هرگونه اطلاعات قبلي و درج اطلاعات پيش فرض شروع گردد؟",
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                           + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                           , Me.Text) <> MsgBoxResult.Yes Then
                Exit Sub
            End If
            Dim i As Integer
            'SaveKalaInExcel Fixes
            vDataTableKalaNotInAnbarKala = BRL.ExistKalaInasnadButNotInabAnbarKala(gAnbarSN, gHesabdariSalFDate, gHesabdariSalTDate, cn)
            If vDataTableKalaNotInAnbarKala IsNot Nothing Then
                Dim kaladss As String = ""
                For i = 0 To vDataTableKalaNotInAnbarKala.Rows.Count - 1
                    If (i >= 10) Then
                        Exit For
                    End If
                    kaladss = kaladss & vbCrLf & vDataTableKalaNotInAnbarKala.Rows(i).Item("KalaDS").ToString
                Next
                NetSql.Common.CSystem.MsgBox("کالاهای" + kaladss + vbCrLf + "درسال جاری انبار گردش دارند ولی در لیست کالاهای انبار ثبت نشده اند",
                           MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)

                If vDataTableKalaNotInAnbarKala.Rows.Count > 10 Then
                    If NetSql.Common.CSystem.MsgBox("تعداد کالاها بیشتر از 10 عدد میباشد آیا مایل به ذخیره سازی هستید ؟",
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                           + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                           , Me.Text) = MsgBoxResult.Yes Then
                        vDataTableKalaNotInAnbarKala.Columns(0).ColumnName = "نام کالا"
                        GetExcelKalaNotInAnbar(vDataTableKalaNotInAnbarKala)
                    End If
                End If
                Exit Sub
            End If


            ' فراخواني اس پي براي درج آسان انبارگرداني
            cn.ConnectionTimeout = 1000
            cn.CallSP("_abSPC_AnbarGardani_EasyStart", gAnbarSN, gNoeAnbarSN,
                       DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
                       , gHesabdariSalFDate, gHesabdariSalTDate, gSM.Identifier, gSM.UserID_Name, vErrMsg)

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg,
                           MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
            Else
                MsgBox("اقدامات اولیه انجام شد", MsgBoxStyle.OkOnly, "پیغام")
                DVabAnbarGardani.AutoFetchCurrentRow = True
                DVabAnbarGardani.FetchCurRecord()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDarjkalaphizikiSHomaresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
          Handles btnDarjkalaphizikiSHomaresh.Click
        ' درج کالافيزيکي هاي شرکت کننده در انبارگرداني در اقلام شمارش
        Dim vSelectedAllKalaPhiziki As String
        Dim vSelectedAllKalaPhizikiMojoodiMoghayer As String
        Dim vSelectedAllKalaPhizikiLastMoghayer, vSelectedCopyShomaresh As String, vSelectedDarjKalaPhiziki As String
        Dim vAnbarGardaniSN, vShomareshSN As Decimal
        Dim vShomareshSNMoghayer, vFabShomareshSNLast, vTabShomareshSNLast As Decimal
        Dim vCopyFShomareshSN, vCopyTShomareshSN As Decimal
        Dim vErrMsg As String ', vDialogResult As Integer

        Dim vKalaGardeshDar, vKalaMandehDar As Decimal
        Dim vKalaGardeshAll As Decimal
        Dim vStrKalaSN As String ', vStrFilterSelectedGoroohSN 

        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .VisibleDarjKalaPhizikiFor = True
            .VisibleKala = False
            .VisibleKalaWhere = True
            vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            .AnbarGardaniSN = vAnbarGardaniSN
            .FilterNoeAnbarSN = gNoeAnbarSN
            .ShowDialog(Me)
        End With

        If VFilterAsnadAnbar.DialogResult = DialogResult.OK Then
            ' use filter
            With VFilterAsnadAnbar

                'درج کالا فيزيکي بر اساس
                vSelectedDarjKalaPhiziki = 0
                vSelectedAllKalaPhiziki = 0
                vSelectedAllKalaPhizikiMojoodiMoghayer = 0
                vSelectedAllKalaPhizikiLastMoghayer = 0
                If .SelectedDarjKalaPhiziki Then
                    vSelectedDarjKalaPhiziki = 1
                    If .SelectedAllKalaPhiziki = 1 Then
                        vSelectedAllKalaPhiziki = 1
                    ElseIf .SelectedAllKalaPhizikiMojoodiMoghayer = 1 Then
                        vSelectedAllKalaPhizikiMojoodiMoghayer = 1
                        If .ShomareshSNMoghayer = 0 Then
                            NetSql.Common.CSystem.MsgBox("شمارش مشخص نشده است")
                            Exit Sub
                        Else
                            vShomareshSNMoghayer = .ShomareshSNMoghayer
                        End If
                    ElseIf .SelectedAllKalaPhizikiLastMoghayer = 1 Then
                        vSelectedAllKalaPhizikiLastMoghayer = 1
                        If .FabShomareshSNLast = 0 Or .TabShomareshSNLast = 0 Then
                            NetSql.Common.CSystem.MsgBox("شمارش مشخص نشده است")
                            Exit Sub
                        Else
                            vFabShomareshSNLast = .FabShomareshSNLast
                            vTabShomareshSNLast = .TabShomareshSNLast
                        End If
                    End If
                End If

                vSelectedCopyShomaresh = 0
                If .SelectedCopyShomaresh = 1 Then
                    vSelectedCopyShomaresh = 1
                    If .CopyFShomareshSN = 0 Or .CopyTShomareshSN = 0 Then
                        NetSql.Common.CSystem.MsgBox(" کپي شمارش مشخص نشده است")
                        Exit Sub
                    Else
                        If NetSql.Common.CSystem.MsgBox("آيا مقادير شمارش نيز کپي گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                                        + MsgBoxStyle.DefaultButton2 +
                                                                        MsgBoxStyle.MsgBoxRtlReading +
                                                                        MsgBoxStyle.MsgBoxRight _
                                      , Me.Text) <> MsgBoxResult.Yes Then
                            vSelectedCopyShomaresh = 0
                        Else
                            vCopyFShomareshSN = .CopyFShomareshSN
                            vCopyTShomareshSN = .CopyTShomareshSN
                        End If
                    End If
                End If
                'درج کالا فيزيکي بر اساس

                'شروط کالا
                vKalaGardeshDar = 0
                vKalaMandehDar = 0
                vKalaGardeshAll = 0
                If .SelectedKalaGardeshDar = 1 Then
                    vKalaGardeshDar = 1
                ElseIf .SelectedKalaMandehDar = 1 Then
                    vKalaMandehDar = 1
                ElseIf Trim(.SelectedKalaGardeshAll) <> "" Then
                    vKalaGardeshAll = 1
                End If

                If vKalaGardeshDar = 1 Then
                    If NetSql.Common.CSystem.MsgBox("آيا مایل به کپی کل کالا های گردش دار می باشید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                            + MsgBoxStyle.DefaultButton2 +
                            MsgBoxStyle.MsgBoxRtlReading +
                            MsgBoxStyle.MsgBoxRight _
                            , Me.Text) <> MsgBoxResult.Yes Then
                        vKalaGardeshDar = 0

                    End If
                End If
                If vKalaMandehDar = 1 Then
                    If NetSql.Common.CSystem.MsgBox("آيا مایل به کپی کل کالا های مانده دار می باشید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                            + MsgBoxStyle.DefaultButton2 +
                            MsgBoxStyle.MsgBoxRtlReading +
                            MsgBoxStyle.MsgBoxRight _
                            , Me.Text) <> MsgBoxResult.Yes Then
                        vKalaMandehDar = 0

                    End If
                End If
                If vKalaGardeshAll = 1 Then
                    If NetSql.Common.CSystem.MsgBox("آيا مایل به کپی کل کالا رهگیری ها می باشید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                            + MsgBoxStyle.DefaultButton2 +
                            MsgBoxStyle.MsgBoxRtlReading +
                            MsgBoxStyle.MsgBoxRight _
                            , Me.Text) <> MsgBoxResult.Yes Then
                        vKalaGardeshAll = 0

                    End If
                End If
                'شروط کالا

                'کالا
                vStrKalaSN = ""
                If Trim(.SelectedKalaSN) <> "" Then
                    vStrKalaSN = .SelectedKalaSN
                End If
                'کالا

            End With

            ' use filter

            ' با توجه به فيلتر انتخاب شده توسط کاربر کالافيزيکي ها درج ميگردد
            ' Call sp For Darj ShomareshHa
            vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            vShomareshSN = Val(DVabShomaresh.Fields("ShomareshSN").Value)
            If vAnbarGardaniSN <> 0 And vShomareshSN <> 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                cn.CallSP("_abSP_Ins_abShomareshHa", gAnbarSN, vAnbarGardaniSN, vShomareshSN _
                           , gHesabdariSalFDate, gHesabdariSalTDate, vSelectedDarjKalaPhiziki _
                           , vSelectedAllKalaPhiziki, vSelectedAllKalaPhizikiMojoodiMoghayer _
                           , vSelectedAllKalaPhizikiLastMoghayer _
                           , vShomareshSNMoghayer, vFabShomareshSNLast, vTabShomareshSNLast _
                           , vSelectedCopyShomaresh, vCopyFShomareshSN, vCopyTShomareshSN _
                           , gSM.Identifier, gSM.UserID_Name, vErrMsg _
                           , vKalaGardeshDar, vKalaMandehDar, vKalaGardeshAll, vStrKalaSN)
                If vErrMsg <> "" Then
                    NetSql.Common.CSystem.MsgBox(vErrMsg,
                               MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading +
                               MsgBoxStyle.MsgBoxRight, Me.Text)
                Else
                    DVabShomareshHa.Refresh()
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

            ' Call sp For Darj ShomareshHa
        End If

    End Sub

    Private Sub btnDarjKalaPhizikiSevom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ' درج کالافيزيکي هاي شرکت کننده در انبارگرداني در اقلام شمارش
        Dim vSelectedAllKalaPhiziki As String
        Dim vSelectedAllKalaPhizikiMojoodiMoghayer As String
        Dim vSelectedAllKalaPhizikiLastMoghayer, vSelectedCopyShomaresh As String, vSelectedDarjKalaPhiziki As String
        Dim vAnbarGardaniSN, vShomareshSN As Decimal
        Dim vShomareshSNMoghayer, vFabShomareshSNLast, vTabShomareshSNLast As Decimal
        Dim vCopyFShomareshSN, vCopyTShomareshSN As Decimal
        Dim vErrMsg As String ', vDialogResult As Integer

        Dim vKalaGardeshDar, vKalaMandehDar As Decimal
        Dim vKalaGardeshAll As Decimal
        Dim vStrKalaSN As String ', vStrFilterSelectedGoroohSN

        'درج کالا فيزيکي بر اساس
        vSelectedDarjKalaPhiziki = 1
        vSelectedAllKalaPhiziki = 0
        vSelectedAllKalaPhizikiMojoodiMoghayer = 0
        vSelectedAllKalaPhizikiLastMoghayer = 1
        vFabShomareshSNLast = 0
        '.FabShomareshSNLast
        vTabShomareshSNLast = 0
        '.TabShomareshSNLast
        vSelectedCopyShomaresh = 0
        'درج کالا فيزيکي بر اساس

        'شروط کالا
        vKalaGardeshDar = 0
        vKalaMandehDar = 0
        vKalaGardeshAll = 0
        'شروط کالا

        'کالا
        vStrKalaSN = ""
        'کالا

        ' use filter

        ' با توجه به فيلتر انتخاب شده توسط کاربر کالافيزيکي ها درج ميگردد
        ' Call sp For Darj ShomareshHa
        vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
        vShomareshSN = Val(DVabShomaresh.Fields("ShomareshSN").Value)

        If DVabShomaresh.DataSource.Count <> 3 Then
            MsgBox("تعداد شمارش هاي اين انبارگرداني، سه شمارش نمي باشد")
            Exit Sub
        ElseIf DVabShomaresh.Fields("ShomareshStatus").Value <> "1" Then
            MsgBox("شمارش جاري موقت نمي باشد")
            Exit Sub
        Else
            Dim i, j As Integer
            j = 0
            For i = 0 To DVabShomaresh.DataSource.Count - 1
                If DVabShomaresh.DataSource.Item(i).Item("ShomareshStatus") = "4" Then
                    j = j + 1
                    If j = 1 Then
                        vFabShomareshSNLast = DVabShomaresh.DataSource.Item(i).Item("ShomareshSN")
                    Else
                        vTabShomareshSNLast = DVabShomaresh.DataSource.Item(i).Item("ShomareshSN")
                    End If
                End If
            Next
            If vFabShomareshSNLast = 0 Or vTabShomareshSNLast = 0 Then
                MsgBox("برخي از شمارش هاي ديگر قطعي نمي باشند")
                Exit Sub
            End If
        End If

        If vAnbarGardaniSN <> 0 And vShomareshSN <> 0 Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            cn.CallSP("_abSP_Ins_abShomareshHa", gAnbarSN, vAnbarGardaniSN, vShomareshSN _
                       , gHesabdariSalFDate, gHesabdariSalTDate, vSelectedDarjKalaPhiziki _
                       , vSelectedAllKalaPhiziki, vSelectedAllKalaPhizikiMojoodiMoghayer _
                       , vSelectedAllKalaPhizikiLastMoghayer _
                       , vShomareshSNMoghayer, vFabShomareshSNLast, vTabShomareshSNLast _
                       , vSelectedCopyShomaresh, vCopyFShomareshSN, vCopyTShomareshSN _
                       , gSM.Identifier, gSM.UserID_Name, vErrMsg _
                       , vKalaGardeshDar, vKalaMandehDar, vKalaGardeshAll, vStrKalaSN)
            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg,
                           MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading +
                           MsgBoxStyle.MsgBoxRight, Me.Text)
            Else
                DVabShomareshHa.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If

        ' Call sp For Darj ShomareshHa

    End Sub

    Private Sub btnGhateeShomaresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
         Handles btnGhateeShomaresh.Click
        ' تبديل رکورد از حالت موقت به قطعي
        '1	موقت
        '4	نهايي

        Dim vli_NewVaziat As Short
        Dim vErrMsg As String = ""
        'Dim vShomareshSN As Object
        If Not DVabShomaresh.CommandEnabled(EnumCommands.cmEdit) Then Exit Sub
        If Val(DVabShomaresh.Fields("ShomareshStatus").Value) = 1 Then
            vli_NewVaziat = 4
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا شمارش مورد نظر قطعي گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                       + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading +
                                                       MsgBoxStyle.MsgBoxRight _
                      , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        ' فراخواني اس پي براي تغيير وضعيت رکورد شمارش
        cn.CallSP("_abSPC_Change_ShomareshStatus", DVabShomaresh.Fields("ShomareshSN").Value _
                   , DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
                   , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            With DVabAnbarGardani
                .AutoFetchCurrentRow = True
                .FetchCurRecord()
                .AutoFetchCurrentRow = False
            End With
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnDelNoCounter_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnDelNoCounter.Click
        ' امکاني براي حذف اقلام 
        'Dim vShomareshHaSN As Object
        With DVabShomareshHa
            If (Not .CommandEnabled(EnumCommands.cmEdit)) Or (.State = EnumDataViewState.bsEdit) Or (.State = EnumDataViewState.bsAdd) Then
                Exit Sub
            End If

            If _
                NetSql.Common.CSystem.MsgBox(" آيا رکوردهايی که مقدار شمارش برای آنها ثبت نشده حذف گردد ؟ ",
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Dim _str As String = "Delete  abShomareshHa WHERE ShomareshSN = " & Val(DVabShomaresh.FieldValue("ShomareshSN")) & " And Meghdar IS NULL"
                cn.ExecuteQuery(_str)

                DVabShomareshHa.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With

    End Sub

    Private Sub btnDelSelectedshomaresh_Click(sender As System.Object, e As System.EventArgs) Handles btnDelSelectedshomaresh.Click
        ' امکاني براي حذف گروهي اقلام 
        'Dim vShomareshHaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_abShomareshHaSN() As Decimal
        Dim VCount_ShomareshHaSN As Short
        Try
            If DVabShomareshHa.DataRows <= 1 Then
                Exit Sub
            End If
            With DVabShomareshHa
                If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) <> 1 And
                    Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) <> 4 And
                    Val(DVabShomaresh.Fields("ShomareshStatus").Value) <> 1 Then
                    Exit Sub
                End If

                If _
                    NetSql.Common.CSystem.MsgBox(" آيا رکوردهاي انتخاب شده حذف گردد ؟ ",
                               MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 +
                               MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    With DVabShomareshHa.FlexGrid
                        VCount_ShomareshHaSN = .SelectedRows
                        ReDim V_ar_abShomareshHaSN(VCount_ShomareshHaSN)
                        For i = 0 To VCount_ShomareshHaSN - 1
                            V_ar_abShomareshHaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("ShomareshHaSN")))
                        Next
                    End With
                    ' حذف تک تک رکوردهاي انتخاب شده 
                    For i = 0 To VCount_ShomareshHaSN - 1
                        vSN = Val(V_ar_abShomareshHaSN(i))
                        If vSN <> 0 Then
                            cn.CallSP("abShomareshHa_Delete", vSN)
                        End If
                    Next
                    DVabShomareshHa.Refresh()
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End With
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDarjSanadAvalDoreh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
         Handles btnDarjSanadAvalDoreh.Click
        ' ثبت موجودي اول دوره 
        Dim vErrMsg As String = ""
        Dim vFromDate, vToDate, NextyearDate As String

        If Val(DVabAnbarGardani.Fields("AnbarGardaniTypeSN").Value) = 2 Then
            vErrMsg = vErrMsg & Chr(13) & "ثبت سند اول دوره برای انبارگردانی میان دوره ای مجاز نمی باشد"
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا موجودي اول دوره انتقال گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                          + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading +
                                                          MsgBoxStyle.MsgBoxRight _
                      , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        If _
            NetSql.Common.CSystem.MsgBox(
                       " با درج اين سند امکان هيچ گونه تغييري در اسناد سال " & gHesabdariSal & " وجود نخواهد داشت(ثبت ، بروزآوري) . در ضمن کليه رزروهاي موجود انبار نيز از رزرو خارج خواهند شد. آيا موجودي اول دوره انتقال گردد؟",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                       + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                       , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Try

            vFromDate = gHesabdariSalFDate
            vToDate = gHesabdariSalTDate
            NextyearDate = CStr(gHesabdariSal + 1) + "0101"
            ''cn.ConnectionTimeout = 1000
            ' فراخواني اس پي براي انتقال مانده کاردکس در سند موجودي اول دوره
            cn.CallSP("_abSP_Ins_SanadAvalDoreh", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, gHesabdariSal + 1 _
                       , vFromDate, vToDate, gSM.Identifier, gSM.UserID_Name, vErrMsg)
            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading _
                                    + MsgBoxStyle.MsgBoxRight, Me.Text)
            End If

            DVabAnbarGardani.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnSelectHesabdariSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' انتخاب سال مالي
        SelectHesabdariSal(Me)
        dclFDate.Value = gHesabdariSalFDate
        dclTDate.Value = gHesabdariSalTDate
    End Sub

    Public Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
         Handles btnViewReport.Click

        Dim i As Integer
        Dim vErrMsg As String = ""
        Dim vAnbarGardaniSN As Decimal
        Dim vFShomareshSN, vTShomareshSN As Decimal
        Dim vWithMojoodi As Integer
        Dim Iske As Integer = 0

        If ChkIsKE.Checked = True Then
            Iske = 1
        Else
            Iske = 0
        End If

        If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) = 0 Then
            vErrMsg = vErrMsg & Chr(13) & "انبارگرداني مشخص نشده است"
            Exit Sub
        Else
            vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
        End If

        If optMoghKoli.Checked = True Then '''گزارش مغایرت کلی انبارگردانی
            vWithMojoodi = 1
            RptType = 1
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratShomareshha " & gAnbarSN & "," & vAnbarGardaniSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate & ", " & vWithMojoodi & " , " & Iske)
                If dv.Count <> 0 Then
                    For i = 0 To dv.Count - 1
                        Dim _MLasthomaresh As Double = 0
                        If Not dv(i)("Meghdar3") Is DBNull.Value Then
                            _MLasthomaresh = IIf(dv(i)("Meghdar3") Is DBNull.Value, 0, dv(i)("Meghdar3"))
                        ElseIf Not dv(i)("Meghdar2") Is DBNull.Value Then
                            _MLasthomaresh = IIf(dv(i)("Meghdar2") Is DBNull.Value, 0, dv(i)("Meghdar2"))
                        ElseIf Not dv(i)("Meghdar1") Is DBNull.Value Then
                            _MLasthomaresh = IIf(dv(i)("Meghdar1") Is DBNull.Value, 0, dv(i)("Meghdar1"))
                        Else
                            _MLasthomaresh = 0
                        End If

                        dv(i)("Moghayerat") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))

                        If _MLasthomaresh > IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Ezafeh") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                            If Not dv.ToTable.Columns("RialEzafeh") Is Nothing Then
                                dv(i)("RialEzafeh") = dv(i)("Ezafeh") * dv(i)("GheymateKharid")
                            End If
                        ElseIf _MLasthomaresh < IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Kasri") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh
                            If Not dv.ToTable.Columns("RialKasri") Is Nothing Then
                                dv(i)("RialKasri") = dv(i)("Kasri") * dv(i)("GheymateKharid")
                            End If
                        End If
                        dv(i)("LastMojoodi") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh

                    Next
                    If ChkNotShowAll.Checked = True Then
                        dv = New DataView(dv.Table, "Mojoodi<>0 OR Meghdar1<>0 OR Meghdar2<>0 OR Meghdar3<>0", "", DataViewRowState.CurrentRows)
                    End If
                    InitReport(dv)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        ElseIf OptMoghMojWSho.Checked = True Then '''گزارش مغایرت موجودی با شمارش خاص
            vWithMojoodi = 1
            RptType = 2
            If Trim(dcbFShomareshKhas.BoundText) <> "" Then
                vFShomareshSN = dcbFShomareshKhas.BoundText
            Else
                MsgBox("شمارش مورد نظر برای مقایسه با موجودی سیستم انتخاب نشده است", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratMojoodiWithShomaresh " & gAnbarSN & "," & vAnbarGardaniSN & "," & vFShomareshSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate)

                'dv = New DataView(dv.Table, "Meghdar1<>0", "", DataViewRowState.CurrentRows)

                InitReport(dv)
            Catch ex As Exception
                MsgBox(ex)
            End Try
            Me.Cursor = Cursors.Default
        ElseIf OptMoghBetSho.Checked = True Then ''' گزارش مغایرت بین شمارش ها 
            vWithMojoodi = 0
            RptType = 3
            If Trim(dcbFShomareshSN.BoundText) = "" Then
                vErrMsg = vErrMsg & Chr(13) & "از شمارش مشخص نشده است"
            Else
                vFShomareshSN = dcbFShomareshSN.BoundText
            End If
            If Trim(dcbTShomareshSN.BoundText) = "" Then
                vErrMsg = vErrMsg & Chr(13) & "و شمارش مشخص نشده است"
            Else
                vTShomareshSN = dcbTShomareshSN.BoundText
            End If

            If Len(vErrMsg) > 0 Then
                MsgBox(vErrMsg, MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            End If
            ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratBetweenTwoShomaresh " & vAnbarGardaniSN & "," & vFShomareshSN & "," & vTShomareshSN)

                If ChkNotShowAll.Checked = True Then
                    dv = New DataView(dv.Table, "Meghdar1<>0 OR Meghdar2<>0", "", DataViewRowState.CurrentRows)
                End If

                'If dv.Count <> 0 Then
                InitReport(dv)
                'End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
            Me.Cursor = Cursors.Default
        ElseIf optKasrEzafeh.Checked = True Then ''' گزارش کسری و اضافه 
            vWithMojoodi = 1
            RptType = 4
            ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratShomareshha " & gAnbarSN & "," & vAnbarGardaniSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate & ", " & 1 & " , " & Iske)
                If dv.Count <> 0 Then
                    For i = 0 To dv.Count - 1
                        Dim _MLasthomaresh As Double = 0
                        If Not dv(i)("Meghdar3") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar3")
                        ElseIf Not dv(i)("Meghdar2") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar2")
                        ElseIf Not dv(i)("Meghdar1") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar1")
                        Else
                            _MLasthomaresh = 0
                        End If
                        dv(i)("Moghayerat") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                        If _MLasthomaresh > IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Ezafeh") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                            If Not dv.ToTable.Columns("RialEzafeh") Is Nothing Then
                                dv(i)("RialEzafeh") = dv(i)("Ezafeh") * dv(i)("GheymateKharid")
                            End If
                        ElseIf _MLasthomaresh < IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Kasri") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh
                            If Not dv.ToTable.Columns("RialKasri") Is Nothing Then
                                dv(i)("RialKasri") = dv(i)("Kasri") * dv(i)("GheymateKharid")
                            End If
                        End If

                    Next

                    dv = New DataView(dv.Table, "Kasri<>0 OR Ezafeh<>0", "", DataViewRowState.CurrentRows)
                    'If dv.Count <> 0 Then
                    InitReport(dv)
                    'End If
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try

            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btnShowSanad_KE_Click(sender As System.Object, e As System.EventArgs) Handles btnShowSanad_KE.Click
        Try
            Dim i As Integer
            Dim vAnbarGardaniSN As Decimal
            Try
                vAnbarGardaniSN = DVabAnbarGardani.Fields("AnbarGardaniSN").Value
            Catch ex As Exception
                MsgBox("فایل انبار گردانی معتبر نمی باشد", MsgBoxStyle.OkOnly, "")
                Exit Sub
            End Try

            Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratShomareshha " & gAnbarSN & "," & vAnbarGardaniSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate & ", " & 1 & " , " & 1)
            If dv.Count <> 0 Then
                For i = 0 To dv.Count - 1
                    Dim _MLasthomaresh As Double = 0
                    If Not dv(i)("Meghdar3") Is DBNull.Value Then
                        _MLasthomaresh = dv(i)("Meghdar3")
                    ElseIf Not dv(i)("Meghdar2") Is DBNull.Value Then
                        _MLasthomaresh = dv(i)("Meghdar2")
                    ElseIf Not dv(i)("Meghdar1") Is DBNull.Value Then
                        _MLasthomaresh = dv(i)("Meghdar1")
                    Else
                        _MLasthomaresh = 0
                    End If
                    If _MLasthomaresh > IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                        dv(i)("Ezafeh") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                    ElseIf _MLasthomaresh < IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                        dv(i)("Kasri") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh
                    End If
                Next

                With DvabVwreport_ke
                    dv = New DataView(dv.Table, "Kasri<>0 OR Ezafeh<>0", "", DataViewRowState.CurrentRows)

                    .DataSource = dv
                    .Refresh()
                    .FlexGrid.ColHidden(4) = True
                    .FlexGrid.ColHidden(5) = True
                    .FlexGrid.ColDataType(6) = GetType(Decimal)
                    .FlexGrid.ColDataType(7) = GetType(Decimal)
                    .FlexGrid.ColDataType(8) = GetType(Decimal)
                    .FlexGrid.ColDataType(9) = GetType(Decimal)
                    .FlexGrid.ColDataType(10) = GetType(Decimal)
                    .FlexGrid.ColDataType(11) = GetType(Decimal)
                End With
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnDarjSanad_KE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
          Handles btnDarjSanad_KE.Click
        ' ثبت اسناد اصلاحيه انبارگرداني
        Dim vErrMsg As String = ""
        Dim vSanadDate As String
        Dim vTozih As String
        Dim i As Integer
        Dim vAnbarGardaniSN As Decimal = 0
        Dim Iskasri As Boolean = False
        Dim SanadDate As String
        Try
            If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) = 0 Then
                vErrMsg = vErrMsg & Chr(13) & "فایل انبارگرداني مشخص نشده است"
                Exit Sub
            Else
                vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            End If

            'If Val(DVabAnbarGardani.Fields("AnbarGardaniTypeSN").Value) = 2 Then
            '    vErrMsg = vErrMsg & Chr(13) & "ثبت اسناد کسری و اضافه برای انبارگردانی میان دوره ای مجاز نمی باشد"
            '    Exit Sub
            'End If

            If DVabAnbarGardani.Fields("Enddate").Value = "" Then
                vErrMsg = vErrMsg & Chr(13) & "تاریخ پایان فایل انبارگرداني مشخص نشده است"
                Exit Sub
            Else
                SanadDate = DVabAnbarGardani.Fields("Enddate").Value
            End If

            If vAnbarGardaniSN <> 0 And DVabAnbarGardani.Fields("AnbarGardaniStatus").Value = 12 Then
                If NetSql.Common.CSystem.MsgBox("آيا اسناد انبارگرداني (کسری و اضافه) به تاریخ " & DVabAnbarGardani.FieldText("EndDate") & " ثبت گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                                          + MsgBoxStyle.DefaultButton2 +
                                                                          MsgBoxStyle.MsgBoxRtlReading +
                                                                          MsgBoxStyle.MsgBoxRight _
                              , Me.Text) <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
                '//By Izadpanah-860125
                If _
                    Not _
                    (Replace(DVabAnbarGardani.FieldValue("StartDate"), "/", "") >= Trim(gHesabdariSalFDate) And
                     Replace(DVabAnbarGardani.FieldValue("EndDate"), "/", "") <= Trim(gHesabdariSalTDate)) Then
                    NetSql.Common.CSystem.MsgBox(".سند کسري اضافه بايد در سالي که انبارگرداني انجام گرفته ثبت شود ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                '//By Izadpanah-860125
                vSanadDate = gHesabdariSalTDate
                If Trim(vSanadDate) = "" Then
                    NetSql.Common.CSystem.MsgBox("تاريخ اسناد مشخص نشده است")
                    Exit Sub
                End If
                vTozih = Trim(txtTozih.Text)

                Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratShomareshha " & gAnbarSN & "," & vAnbarGardaniSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate & ", " & 1 & " , " & 1)
                If dv.Count <> 0 Then
                    For i = 0 To dv.Count - 1
                        'If dv(i)("KalaSN") = "939.102" Then
                        '    dv(i)("KalaSN") = "939.102"
                        'End If
                        Dim _MLasthomaresh As Decimal = 0
                        If Not dv(i)("Meghdar3") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar3")
                        ElseIf Not dv(i)("Meghdar2") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar2")
                        ElseIf Not dv(i)("Meghdar1") Is DBNull.Value Then
                            _MLasthomaresh = dv(i)("Meghdar1")
                        Else
                            _MLasthomaresh = 0
                        End If
                        If _MLasthomaresh > IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Ezafeh") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                        ElseIf _MLasthomaresh < IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                            dv(i)("Kasri") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh
                            Iskasri = True
                        End If
                    Next

                    dv = New DataView(dv.Table, "Kasri<>0.000 OR Ezafeh<>0.000", "", DataViewRowState.CurrentRows)
                    'If dv.Count <> 0 Then
                    Sabtsanadkasriezafeh(dv, vAnbarGardaniSN, Iskasri, SanadDate)
                    'End If
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                DVabAnbarGardani.AutoFetchCurrentRow = True
                DVabAnbarGardani.FetchCurRecord()
            Else
                NetSql.Common.CSystem.MsgBox("جهت ثبت اسناد کسری واضافه , وضعیت انبارگرداني می بایست در حالت پایان شمارش باشد", MsgBoxStyle.OkOnly, "توجه")
            End If

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnFilterAsnadAnbar_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        With VFilterAsnadAnbar
            .VisibleKala = True
            .VisibleKalaWhere = True
            .VisibleAnbar = True
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnOk.Click

        Dim vErrMsg As String
        Dim strAnbars As String
        Dim vKalaPhizikiMode As Short
        Dim vStrKalaSN As String

        If dcbNoeReport.SelectedIndex = -1 Then
            dcbNoeReport.SelectedIndex = NOE_REPORT.TagGhasemWithRahgiri
        End If

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr(gAnbarSN)
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If

            With VFilterAsnadAnbar
                If .SelectedKalaGardeshDar = 1 Then
                    vKalaPhizikiMode = 1
                ElseIf .SelectedKalaMandehDar = 1 Then
                    vKalaPhizikiMode = 2
                ElseIf Trim(.SelectedKalaGardeshAll) <> "" Then
                    vKalaPhizikiMode = 3
                End If

                If Trim(.SelectedKalaSN) <> "" Then
                    vStrKalaSN = .SelectedKalaSN
                End If

            End With

            Me.Cursor = Cursors.WaitCursor

            Select Case dcbNoeReport.SelectedIndex
                Case NOE_REPORT.TagPars

                    Dim vRptTagAnbarGardaniPars As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniPars
                    With vRptTagAnbarGardaniPars
                        .DefField()
                        .DataSource =
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars,
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)

                        .txtSherkat.Text = gAnbarDS
                        .lblVahedeTejariDS.Text = gVahedeTejariDs
                        .txtSherkat1.Text = gAnbarDS
                        .lblVahedeTejariDS1.Text = gVahedeTejariDs
                        .txtSherkat2.Text = gAnbarDS
                        .lblVahedeTejariDS2.Text = gVahedeTejariDs

                        Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars, Me.MdiParent)

                    End With

                Case NOE_REPORT.TagParsWithChideman

                    Dim vRptTagAnbarGardaniPars2 As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniPars2
                    With vRptTagAnbarGardaniPars2
                        .DefField()
                        .DataSource =
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars,
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)

                        .txtSherkat.Text = gAnbarDS
                        .lblVahedeTejariDS.Text = gVahedeTejariDs
                        .txtSherkat1.Text = gAnbarDS
                        .lblVahedeTejariDS1.Text = gVahedeTejariDs
                        .txtSherkat2.Text = gAnbarDS
                        .lblVahedeTejariDS2.Text = gVahedeTejariDs
                        .txtDesc.Text = txtDesc.Text
                        .txtdesc1.Text = txtDesc.Text
                        .txtDesc2.Text = txtDesc.Text

                        Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars2, Me.MdiParent)

                    End With

                Case NOE_REPORT.TagGhasemWithRahgiri

                    Dim vRptTagAnbarGardaniGhasem As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniGhasem
                    With vRptTagAnbarGardaniGhasem
                        .DefField()
                        .DataSource =
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars,
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS
                        .txtSherkat3.Text = gAnbarDS

                        If chkPYear.Checked = True Then
                            .txtSal.Text = gHesabdariSal - 1
                            .txtSal2.Text = gHesabdariSal - 1
                            .txtSal3.Text = gHesabdariSal - 1
                        Else
                            .txtSal.Text = gHesabdariSal
                            .txtSal2.Text = gHesabdariSal
                            .txtSal3.Text = gHesabdariSal
                        End If

                        Try
                            Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniGhasem, Me.MdiParent)
                        Catch ex As Exception
                        End Try
                    End With
                Case NOE_REPORT.tagGhasemWithoutRahgiri
                    Dim vRptTagAnbarGardaniGhasem As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniGhasem
                    With vRptTagAnbarGardaniGhasem
                        .DefField()
                        .DataSource =
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars,
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS
                        .txtSherkat3.Text = gAnbarDS

                        If chkPYear.Checked = True Then
                            .txtSal.Text = gHesabdariSal - 1
                            .txtSal2.Text = gHesabdariSal - 1
                            .txtSal3.Text = gHesabdariSal - 1
                        Else
                            .txtSal.Text = gHesabdariSal
                            .txtSal2.Text = gHesabdariSal
                            .txtSal3.Text = gHesabdariSal
                        End If
                        Try
                            Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniGhasem, Me.MdiParent)
                        Catch ex As Exception
                        End Try
                    End With

                Case NOE_REPORT.tagKhoram
                    Dim vRptTagAnbarGardaniPars As New Minoo.Applications.Anbar.Report.RptTagAnbarGardanikhoram
                    With vRptTagAnbarGardaniPars
                        .DefField()
                        .DataSource =
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars,
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat1.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS

                        Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars, Me.MdiParent)

                    End With

                    Me.Cursor = Cursors.Default

                Case Else
                    NetSql.Common.CSystem.MsgBox("نوع گزارش نامشخص است",
                               MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                               MsgBoxStyle.MsgBoxRight, Me.Text)
            End Select

        End If

    End Sub

    Private Sub btnTools_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnTools.Click
        Try

            Dim vErrMsg As String = ""
            Dim vAnbarGardaniSN As Decimal
            Dim frm As New FrmAnbargardaniTools
            If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) = 0 Then
                vErrMsg = "انبارگرداني مشخص نشده است"
                Exit Sub
            Else
                vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            End If
            With frm
                .AnbargardaniSn = vAnbarGardaniSN
                .ShowDialog()
            End With
            DVabAnbarGardani.FetchCurRecord()
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در اضافه کردن کالا به انبارگردانی" + vbNewLine + ex.Message,
           MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
           MsgBoxStyle.MsgBoxRight, Me.Text)
        End Try
    End Sub

    Private Sub btnExcelshomaresh_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnExcelshomaresh.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DVabShomareshHa.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub btnExcelKalaha_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnExcelKalaha.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DVabAnbarGardaniHA.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub btnExcelreport_Click(sender As System.Object, e As System.EventArgs) Handles btnExcelreport.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DvabVwreport.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub btnPrintSanad_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnPrintSanad.Click
        Dim i As Integer
        Dim vAnbarGardaniSN As Decimal
        Me.Cursor = Cursors.WaitCursor
        Try
            If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) = 0 Then
                MsgBox("انبارگرداني مشخص نشده است", MsgBoxStyle.OkCancel, "پیغام")
                Exit Sub
            Else
                vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            End If

            Dim dv As DataView = cn.ExecuteQuery("exec _abSPR_GetMoghayeratShomareshha " & gAnbarSN & "," & vAnbarGardaniSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate & ", " & 1 & ", " & 0)
            'Dim ds As DataSet = New DsAnbargardani
            If dv.Count <> 0 Then
                For i = 0 To dv.Count - 1
                    'Dim MyRow As DataRow = ds.Tables("tblReport").NewRow
                    'MyRow("KalaNO") = dv.Item(i).Item("KalaNO")
                    'MyRow("KalaDS") = dv.Item(i).Item("KalaDS")
                    'MyRow("Shomarehrahgiri") = dv.Item(i).Item("Shomarehrahgiri")
                    'MyRow("Mojoodi") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                    'MyRow("Meghdar1") = IIf(dv(i)("Meghdar1") Is DBNull.Value, 0, dv(i)("Meghdar1"))
                    'MyRow("Meghdar2") = IIf(dv(i)("Meghdar2") Is DBNull.Value, 0, dv(i)("Meghdar2"))
                    'MyRow("Meghdar3") = IIf(dv(i)("Meghdar3") Is DBNull.Value, 0, dv(i)("Meghdar3"))
                    'MyRow("Ezafeh") = IIf(dv(i)("Ezafeh") Is DBNull.Value, 0, dv(i)("Ezafeh"))
                    'MyRow("Kasri") = IIf(dv(i)("Kasri") Is DBNull.Value, 0, dv(i)("Kasri"))
                    'MyRow("LastMojoodi") = IIf(dv(i)("LastMojoodi") Is DBNull.Value, 0, dv(i)("LastMojoodi"))

                    Dim _MLasthomaresh As Double = 0
                    If Not dv(i)("Meghdar3") Is DBNull.Value Then
                        _MLasthomaresh = IIf(dv(i)("Meghdar3") Is DBNull.Value, 0, dv(i)("Meghdar3"))
                    ElseIf Not dv(i)("Meghdar2") Is DBNull.Value Then
                        _MLasthomaresh = IIf(dv(i)("Meghdar2") Is DBNull.Value, 0, dv(i)("Meghdar2"))
                    ElseIf Not dv(i)("Meghdar1") Is DBNull.Value Then
                        _MLasthomaresh = IIf(dv(i)("Meghdar1") Is DBNull.Value, 0, dv(i)("Meghdar1"))
                    Else
                        _MLasthomaresh = 0
                    End If
                    If _MLasthomaresh > IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                        dv(i)("Ezafeh") = _MLasthomaresh - IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi"))
                    ElseIf _MLasthomaresh < IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) Then
                        dv(i)("Kasri") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - _MLasthomaresh
                    End If
                    dv(i)("LastMojoodi") = IIf(dv(i)("Mojoodi") Is DBNull.Value, 0, dv(i)("Mojoodi")) - IIf(dv(i)("Kasri") Is DBNull.Value, 0, dv(i)("Kasri")) + IIf(dv(i)("Ezafeh") Is DBNull.Value, 0, dv(i)("Ezafeh"))
                    'ds.Tables("tblReport").Rows.Add(MyRow)
                Next
                dv = New DataView(dv.Table, "Mojoodi <>0 OR Meghdar1 <>0 OR Meghdar2 <>0 OR Meghdar3 <>0", "", DataViewRowState.CurrentRows)
            End If

            Dim vRptabAnbargardani As New Report.RptabAnbargardani
            With vRptabAnbargardani
                .DefField()

                If chkprintPyear.Checked = True Then
                    .lblSal.Text = gHesabdariSal - 1
                Else
                    .lblSal.Text = gHesabdariSal
                End If

                .LblVahedetejariDS.Text = CStr(gAnbarNO) + " - " + gAnbarDS
                .DataSource = dv
            End With

            Minoo.Reports.FTReportViewer.ShowReport(vRptabAnbargardani, Me.MdiParent)

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub btnChapLastSanad_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnChapLastSanad.Click

        Dim vAnbarGardaniSN As Decimal
        Me.Cursor = Cursors.WaitCursor
        Try
            If Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value) = 0 Then
                MsgBox("انبارگرداني مشخص نشده است", MsgBoxStyle.OkCancel, "پیغام")
                Exit Sub
            Else
                vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)
            End If

            'Dim _Cstr As String = "Select TarakoneShDS,MAx(SanadNO) SanadNO from absanad " & _
            '" Inner join abtarakonesh On absanad.tarakoneshSN=abtarakonesh.tarakoneshSN  " & _
            '" where Len(SanadNO)<=9 And sanadstatus=8 and anbarsn=" & gAnbarSN & " and (sanaddate  between '" & gHesabdariSalFDate & "' and '" & gHesabdariSalTDate & "') " & _
            '" Group by TarakoneShds order by TarakoneShds desc"

            'Dim dv As DataView = cn.ExecuteQuery(_Cstr)

            Dim dv As DataView = cn.ExecuteQuery("exec _abSPg_GetLastSanadNoForAnbargardani " & gVahedeTejariSN & "," & gAnbarSN & "," & gHesabdariSalFDate & ", " & gHesabdariSalTDate)

            If dv.Count <> 0 Then

                Dim vRptabLAstSanadForAnbargardani As New Report.RptabLAstSanadForAnbargardani
                With vRptabLAstSanadForAnbargardani
                    .DefField()
                    .lblSal.Text = gHesabdariSal
                    .LblVahedetejariDS.Text = CStr(gAnbarNO) + " - " + gAnbarDS
                    .DataSource = dv
                End With

                Minoo.Reports.FTReportViewer.ShowReport(vRptabLAstSanadForAnbargardani, Me.MdiParent)
            Else
                MsgBox("اطلاعاتی برای نمایش دریافت نشد", MsgBoxStyle.OkOnly, "توجه")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

#End Region

#Region "DataViewes"

    Private Sub DVabAnbarGardaniHa_GetGridProperties() _
     Handles DVabAnbarGardaniHA.GetGridProperties
        ' فعال شدن امکان انتخاب گروهي
        With DVabAnbarGardaniHA.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With

    End Sub

    Private Sub DVabShomaresh_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
      Handles DVabShomaresh.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        '1	موقت
        '4	نهايي

        Dim vShomareshStatus As String
        Dim vAnbarGardaniStatus As String
        Dim vEnabled_Status1_4 As Boolean
        btnGhateeShomaresh.Enabled = False
        btnDarjkalaphizikiSHomaresh.Enabled = False
        btnDarjAsanShomaresh.Enabled = False
        'btnDarjKalaPhizikiSevom.Enabled = False
        btnDelSelected.Enabled = False
        btnDelNoCounter.Enabled = False
        btnDelSelectedshomaresh.Enabled = False
        BtnInsertUpdateMojoudiInShomaresh.Enabled = False
        ChkInsertUpdateAllRadif.Enabled = False
        ' در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DVabAnbarGardani.FlexGrid.Rows = 1 Then
            Exit Sub
        End If
        vShomareshStatus = aClip("ShomareshStatus")

        If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 0 Then
            vAnbarGardaniStatus = "1"
        Else
            vAnbarGardaniStatus = Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value)
        End If

        vEnabled_Status1_4 = (vShomareshStatus = "1") ''And DVabAnbarGardani.Fields("AnbarGardaniStatus").Value = 4
        With DVabShomareshHa
            vEnabled_Status1_4 = vEnabled_Status1_4 And (.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmAdd) = vEnabled_Status1_4 And
                                                   (DVabShomareshHa.AccessRight And EnumAccessRight.arInsert) <> 0 _
                                                   And (vShomareshStatus = "1") And
                                                   (vAnbarGardaniStatus = "4")
            'False
            .CommandEnabled(EnumCommands.cmEdit) = vEnabled_Status1_4 And
                                                    (DVabShomareshHa.AccessRight And EnumAccessRight.arUpdate) <> 0 _
                                                   And (vShomareshStatus = "1") And
                                                   (vAnbarGardaniStatus = "4")
            .CommandEnabled(EnumCommands.cmDelete) = vEnabled_Status1_4 And
                                                      (DVabShomareshHa.AccessRight And EnumAccessRight.arDelete) <> 0 _
                                                   And (vShomareshStatus = "1") And
                                                   (vAnbarGardaniStatus = "4")
            'False
            btnGhateeShomaresh.Enabled = vEnabled_Status1_4
            btnDarjkalaphizikiSHomaresh.Enabled = vEnabled_Status1_4
            btnDarjAsanShomaresh.Enabled = vEnabled_Status1_4
            'btnDarjKalaPhizikiSevom.Enabled = vEnabled_Status1_4
            btnDelSelected.Enabled = vEnabled_Status1_4
            btnDelNoCounter.Enabled = vEnabled_Status1_4
            btnDelSelectedshomaresh.Enabled = vEnabled_Status1_4
        End With

        If aFetched Then
            btnGhateeShomaresh.Enabled = btnGhateeShomaresh.Enabled
            btnDarjkalaphizikiSHomaresh.Enabled = btnGhateeShomaresh.Enabled
            btnDarjAsanShomaresh.Enabled = btnGhateeShomaresh.Enabled
            'btnDarjKalaPhizikiSevom.Enabled = btnGhateeShomaresh.Enabled
            btnDelSelected.Enabled = btnGhateeShomaresh.Enabled
            btnDelNoCounter.Enabled = btnGhateeShomaresh.Enabled
            btnDelSelectedshomaresh.Enabled = btnGhateeShomaresh.Enabled
            BtnInsertUpdateMojoudiInShomaresh.Enabled = DVabShomaresh.FieldValue("ShomareshStatus") = "1" AndAlso DVabShomareshHa.DataRows > 1
            ChkInsertUpdateAllRadif.Enabled = DVabShomaresh.FieldValue("ShomareshStatus") = "1" AndAlso DVabShomareshHa.DataRows > 1

        End If

    End Sub

    Private Sub DVabAnbarGardani_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
     Handles DVabAnbarGardani.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                DVabAnbarGardani.Fields("AnbarGardaniDS").DefaultValue = If(AnbarGardaniTypeSN = 1, "انبارگردانی پایان دوره ", "انبارگردانی میان دوره ") + gHesabdariSal.ToString + " - " + gAnbarDS
            Case EnumCommands.cmSave
                If _
                    DVabAnbarGardani.FieldValue("StartDate") < gHesabdariSalFDate OrElse
                    DVabAnbarGardani.FieldValue("StartDate") > gHesabdariSalTDate OrElse
                    DVabAnbarGardani.FieldValue("EndDate") < gHesabdariSalFDate OrElse
                    DVabAnbarGardani.FieldValue("EndDate") > gHesabdariSalTDate Then
                    NetSql.Common.CSystem.MsgBox("تاريخ انبارگرداني خارج از محدوده سال مالي انتخابي مي باشد", MsgBoxStyle.Critical,
                               Me.Text)
                    aCancel = True
                End If
        End Select
    End Sub

    Private Sub DVabAnbarGardani_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabAnbarGardani.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        ' کنترل روي حالتهاي مختلف روي انبارگرداني 
        '1	پيشنويس
        '4	در حين اجرا
        '8	ابطال
        '12	پايان شمارش انبارگرداني
        '16	ثبت سند اصلاحيه انبارگرداني
        '20	ثبت موجودي اول دوره

        Dim vAnbarGardaniStatus As String
        Dim vEnabled_Status1_4 As Boolean
        Dim vEnabled_Status4_12 As Boolean
        btnStatus1_4.Enabled = False
        btnStatus1_4_Easy.Enabled = False
        btnStatus4_8.Enabled = False
        'btnStatus4_12.Enabled = False
        btnDelSelected.Enabled = False
        btnDarjKalaPhiziki.Enabled = False
        btnTools.Enabled = False
        btnDarjSanad_KE.Enabled = False
        btnDarjSanadAvalDoreh.Enabled = False

        ' در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DVabAnbarGardani.FlexGrid.Rows = 1 Then
            Exit Sub
        End If

        Try

            vAnbarGardaniStatus = aClip("AnbarGardaniStatus")
            vEnabled_Status1_4 = (vAnbarGardaniStatus = "1")
            vEnabled_Status4_12 = IIf(vAnbarGardaniStatus = "4" Or vAnbarGardaniStatus = "12", "1", "0")

            With DVabAnbarGardani
                vEnabled_Status1_4 = vEnabled_Status1_4 And (.AccessRight And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled(EnumCommands.cmEdit) = (.AccessRight And EnumAccessRight.arUpdate) <> 0 And
                                                        vEnabled_Status1_4 And (vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4")
                .CommandEnabled(EnumCommands.cmDelete) = vEnabled_Status1_4 And
                                                          (.AccessRight And EnumAccessRight.arDelete) <> 0 _
                                                         And (vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4")
            End With
            If aFetched Then
                btnStatus1_4.Enabled = vAnbarGardaniStatus = "1"
                btnStatus1_4_Easy.Enabled = vAnbarGardaniStatus = "1"
                btnStatus4_8.Enabled = vAnbarGardaniStatus = "4"
                btnDelSelected.Enabled = vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4"
                btnTools.Enabled = vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4"
                btnDarjSanad_KE.Enabled = vAnbarGardaniStatus = "12" And gSM.TableAccessRight("btnDarjSanad_KE") = EnumAccessRight.arAll   '941121 yekta
                btnDarjSanadAvalDoreh.Enabled = vAnbarGardaniStatus = "16" And gSM.TableAccessRight("btnDarjSanadAvalDoreh") = EnumAccessRight.arAll  '941121 yekta
                btnStatus1_4.Enabled = vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4"
                If IsTolidi Then
                    DVabAnbarGardaniHA.FlexGrid.ColHidden(DVabAnbarGardaniHA.FlexGrid.ColIndex("Nerkh")) = DVabAnbarGardani.FieldText("NerkhVaghee") <> "1"
                    DVabShomareshHa.FlexGrid.ColHidden(DVabShomareshHa.FlexGrid.ColIndex("Nerkh")) = DVabAnbarGardani.FieldText("NerkhVaghee") <> "1"

                End If

            End If

            btnDelSelected.Enabled = vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4"
            btnDarjKalaPhiziki.Enabled = btnStatus1_4.Enabled
            btnStatus4_8.Enabled = vAnbarGardaniStatus = "4"
            btnTools.Enabled = vAnbarGardaniStatus = "1" Or vAnbarGardaniStatus = "4"
            btnDarjSanad_KE.Enabled = vAnbarGardaniStatus = "12" And gSM.TableAccessRight("btnDarjSanad_KE") = EnumAccessRight.arAll '941121 yekta
            btnDarjSanadAvalDoreh.Enabled = vAnbarGardaniStatus = "16" And gSM.TableAccessRight("btnDarjSanadAvalDoreh") = EnumAccessRight.arAll '941121 yekta

            ''Ghafari 950119''کنترل دسترسی نمایش دکمه های چاپ اسناد انبارگردانی
            If Len(vAnbarGardaniStatus) > 0 Then
                Me.btnChapLastSanad.Enabled = gSM.ActionEnabled("btnChapLastSanad") And CInt(vAnbarGardaniStatus) >= CInt("12")
                Me.btnPrintSanad.Enabled = gSM.ActionEnabled("btnPrintSanad") And CInt(vAnbarGardaniStatus) >= CInt("12")
            Else
                Me.btnChapLastSanad.Enabled = False
                Me.btnPrintSanad.Enabled = False
            End If


            ''Ghafari 950119''کنترل دسترسی نمایش دکمه های چاپ اسناد انبارگردانی

            With DVabAnbarGardaniHA
                .AccessRight = DVabAnbarGardani.AccessRight
                .CommandEnabled(EnumCommands.cmAdd) = (vEnabled_Status1_4 = "1" Or vEnabled_Status4_12 = "1") And (DVabAnbarGardani.AccessRight And EnumAccessRight.arInsert) <> 0
                '850524
                .CommandEnabled(EnumCommands.cmEdit) = (vEnabled_Status1_4 = "1" Or vEnabled_Status4_12 = "1") And
                                                        (DVabAnbarGardani.AccessRight And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled(EnumCommands.cmDelete) = (vEnabled_Status1_4 = "1" Or vEnabled_Status4_12 = "1") And
                                                          (DVabAnbarGardani.AccessRight And EnumAccessRight.arDelete) <> 0
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'btnDarjSanad_KE.Enabled = True
    End Sub

    Private Sub DVabShomareshHa_GetGridProperties() Handles DVabShomareshHa.GetGridProperties
        ' فعال شدن امکان انتخاب گروهي
        With DVabShomareshHa.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With

        With DVabShomareshHa
            If (gNoeAnbarSN = 2 Or gNoeAnbarSN = 5 Or gNoeAnbarSN = 10) Then
                With .Fields("Meghdar")
                    .Format = "#,#"
                End With
            Else
                With .Fields("Meghdar")
                    .Format = "#,#.###"
                End With
            End If
        End With

        With DVabShomareshHa.FlexGrid
            .Subtotal(SubtotalSettings.Clear)
            .SubtotalPosition = SubtotalPositionSettings.BelowData
            .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Meghdar"), "#,#",
           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), True, "مجموع",
           0, False)
        End With

        'If DVabShomareshHa.DataRows > 0 Then
        '    Dim CStyle As C1.Win.C1FlexGrid.CellStyle = DVabShomareshHa.FlexGrid.GetCellStyleDisplay(0, 0)
        '    Dim CStyle2 As C1.Win.C1FlexGrid.CellStyle = DVabShomaresh.FlexGrid.GetCellStyleDisplay(0, 0)

        '    Dim ik, ij As Integer
        '    Try
        '        For ik = 2 To DVabShomareshHa.FlexGrid.RowCollection.Count - 1
        '            If IsNumeric(DVabShomareshHa.FlexGrid.RowCollection(ik).Item("AnbarGardaniHaSN")) Then
        '                If Not DVabShomareshHa.FlexGrid.RowCollection(ik).Item("Meghdar") Is Nothing AndAlso DVabShomareshHa.FlexGrid.RowCollection(ik).Item("Meghdar") = 0 Then
        '                    For ij = 0 To DVabShomareshHa.FlexGrid.ColumnCollection.Count - 1
        '                        CStyle.BackColor = Color.OrangeRed
        '                        DVabShomareshHa.FlexGrid.SetCellStyle(ik, ij, CStyle)
        '                    Next
        '                    'ElseIf DVabShomareshHa.FlexGrid.RowCollection(ik).Item("Meghdar") Is Nothing OrElse DVabShomareshHa.FlexGrid.RowCollection(ik).Item("Meghdar") Is DBNull.Value Then
        '                    '    For ij = 1 To DVabShomareshHa.FlexGrid.ColumnCollection.Count - 1
        '                    '        CStyle2.BackColor = Color.Red
        '                    '        DVabShomareshHa.FlexGrid.SetCellStyle(ik, ij, CStyle2)
        '                    '    Next
        '                End If
        '            End If
        '        Next
        '    Catch ex As Exception
        '        CSystem.MsgBox(ik.ToString + ij.ToString)
        '    End Try
        'End If

    End Sub

    Private Sub DVabShomareshHa_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabShomareshHa.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                With DVabShomareshHa.FlexGrid
                    ' تهيه شرط براي کامبو کالا
                    DVabShomareshHa.Fields("AnbarGardaniHaSN").ReadOnly = False
                    DVabShomareshHa.Fields("AnbarGardaniHaSN").ComboWhereCondition =
                        "AnbarGardaniHaSN IN (SELECT AnbarGardaniHaSN From abAnbarGardaniHa " &
                        " Where AnbarGardaniSN = " &
                        DVabAnbarGardani.FlexGrid.TextMatrix(DVabAnbarGardani.FlexGrid.Row,
                                                              DVabAnbarGardani.FlexGrid.ColIndex("AnbarGardaniSN")) &
                        ")" &
                        " AND AnbarGardaniHaSN NOT IN (SELECT AnbarGardaniHaSN From abShomareshHa " &
                        " Where ShomareshSN = " &
                        DVabShomaresh.FlexGrid.TextMatrix(DVabShomaresh.FlexGrid.Row,
                                                           DVabShomaresh.FlexGrid.ColIndex("ShomareshSN"))
                    'If aCommand = EnumCommands.cmEdit Then
                    '  DVabShomareshHa.Fields("AnbarGardaniHaSN").ComboWhereCondition = DVabShomareshHa.Fields("AnbarGardaniHaSN").ComboWhereCondition & " AND ShomareshHaSN <> " & .TextMatrix(.Row, .ColIndex("ShomareshHaSN"))
                    'End If
                    DVabShomareshHa.Fields("AnbarGardaniHaSN").ComboWhereCondition =
                        DVabShomareshHa.Fields("AnbarGardaniHaSN").ComboWhereCondition & ")"
                End With
                DVabShomareshHa.Fields("AnbarGardaniHaSN").RefreshCombo()
            Case EnumCommands.cmEdit
                DVabShomareshHa.Fields("AnbarGardaniHaSN").ReadOnly = True
            Case EnumCommands.cmSave
                If _
                    Val(DVabShomareshHa.FlexGrid.TextMatrix(DVabShomareshHa.FlexGrid.Row, DVabShomareshHa.FlexGrid.ColIndex("Meghdar"))) < 0 Then
                    MsgBox("مقدار نمي تواند منفي باشد")
                    aCancel = True
                End If
                If _
                    (Val(DVabShomareshHa.FlexGrid.TextMatrix(DVabShomareshHa.FlexGrid.Row, DVabShomareshHa.FlexGrid.ColIndex("Meghdar"))) Mod 1) > 0.0 And
                    DVabShomareshHa.Fields("Meghdar").Format = "#,#" Then
                    MsgBox("مقدار نمي تواند اعشاري باشد")
                    aCancel = True
                End If

                'If _
                '    DVabShomareshHa.FlexGrid.TextMatrix(DVabShomareshHa.FlexGrid.Row, DVabShomareshHa.FlexGrid.ColIndex("EnghezaDate")) <> "" And _
                '    Val(DVabShomareshHa.FlexGrid.TextMatrix(DVabShomareshHa.FlexGrid.Row, DVabShomareshHa.FlexGrid.ColIndex("Meghdar"))) <= 0 Then
                '    MsgBox("برای ثبت تاریخ انقضاء مقدار شمارش الزامی می باشد")
                '    aCancel = True
                'End If
        End Select
    End Sub

    Private Sub DvabVwreport_GetGridProperties() _
        Handles DvabVwreport.GetGridProperties
        With DvabVwreport
            .Fields("KalaNo").Caption = "کد کالا"
            .Fields("KalaDS").Caption = "نام کالا"
            .Fields("Shomarehrahgiri").Caption = "کد رهگیری"
            If RptType = 2 Then
                .Fields("Meghdar1").Caption = "مقدار شمارش"
                .Fields("Mojoodi").Caption = "موجودی"
                .Fields("Moghayerat").Caption = "مغایرت"
            ElseIf RptType = 5 Or RptType = 1 Or RptType = 4 Then
                .Fields("Meghdar1").Caption = "شمارش اول"
                .Fields("Meghdar2").Caption = "شمارش دوم"
                .Fields("Meghdar3").Caption = "شمارش سوم"
                .Fields("Mojoodi").Caption = "موجودی"
                .Fields("Moghayerat").Caption = "مغایرت نهایی"
                .Fields("Kasri").Caption = "کسری"
                .Fields("Ezafeh").Caption = "اضافه"
                .Fields("GheymateKharid").Caption = "قیمت خرید"
                .Fields("RialKasri").Caption = "ریال کسری"
                .Fields("RialEzafeh").Caption = "ریال اضافی"
            ElseIf RptType = 3 Then
                .Fields("Meghdar1").Caption = dcbFShomareshSN.Text
                .Fields("Meghdar2").Caption = dcbTShomareshSN.Text
                .Fields("Moghayerat").Caption = "مغایرت"

            End If
            '''''''''''
            With .FlexGrid
                '.Subtotal(SubtotalSettings.Clear)
                .Tree.Column = DvabVwreport.FlexGrid.ColIndex("KalaNo")
                .SubtotalPosition = SubtotalPositionSettings.BelowData
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Meghdar1"), "#,###.###",
                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
                If RptType = 2 Then
                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Mojoodi"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Moghayerat"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
                ElseIf RptType = 1 Or RptType = 4 Then
                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Mojoodi"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Moghayerat"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Meghdar2"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Meghdar3"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Kasri"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Ezafeh"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("RialKasri"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("RialEzafeh"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                ElseIf RptType = 3 Then
                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Moghayerat"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)

                    .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Meghdar2"), "#,###.###",
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue),
                    System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
                End If


            End With

        End With
    End Sub

#End Region

#Region "TabControl"

    Private Sub sstChild_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles sstChild.SelectedIndexChanged

        'If sstChild.SelectedTab Is TabShomaresh Then
        '    InitDataViewshomaresh()
        'ElseIf sstChild.SelectedTab Is TabSanadKasriEzafeh Then
        '    InitSanadKasriEzafeh()
        'ElseIf sstChild.SelectedTab Is TabEnteghalMjoodi Then
        '    Avaldoreh()
        'End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) _
        Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is Tabtag Then
            dcbNoeReport.SelectedIndex = NOE_REPORT.TagGhasemWithRahgiri

            With VFilterAsnadAnbar
                .EnableFromSanadDate = True
                .CheckedSanadStatus_1 = True
                .CheckedSanadStatus_4 = True
                .CheckedSanadStatus_8 = True
                .init()
                .SetProperty()
            End With
        End If

    End Sub

#End Region

#Region "CheckBox"

    Private Sub OptMoghMojWSho_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles OptMoghMojWSho.CheckedChanged
        If OptMoghMojWSho.Checked = True Then
            OptMoghBetSho.Checked = False
            dcbFShomareshSN.Enabled = False
            dcbTShomareshSN.Enabled = False
            dcbFShomareshKhas.Enabled = True
        End If
    End Sub

    Private Sub OptMoghBetSho_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles OptMoghBetSho.CheckedChanged
        If OptMoghBetSho.Checked = True Then
            OptMoghMojWSho.Checked = False
            dcbFShomareshKhas.Enabled = False
            dcbFShomareshSN.Enabled = True
            dcbTShomareshSN.Enabled = True
        End If
    End Sub

    Private Sub optMoghKoli_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optMoghKoli.CheckedChanged
        If optMoghKoli.Checked = True Then
            OptMoghMojWSho.Checked = False
            dcbFShomareshKhas.Enabled = False
            dcbFShomareshSN.Enabled = False
            dcbTShomareshSN.Enabled = False
            OptMoghBetSho.Checked = False
            dcbFShomareshSN.Enabled = False
            dcbTShomareshSN.Enabled = False
            dcbFShomareshKhas.Enabled = False
        End If
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkAll.CheckedChanged
        If ChkAll.CheckState = CheckState.Checked Then
            DVabAnbarGardani.SQLWhere = " abAnbarGardani.AnbarSN = " & CStr(gAnbarSN) & " and StartDate BETWEEN " & gHesabdariSalFDate &
                        " and  " & gHesabdariSalTDate & " and EndDate BETWEEN " & gHesabdariSalFDate & " and  " &
                        gHesabdariSalTDate

        Else
            DVabAnbarGardani.SQLWhere += " And abAnbarGardani.AnbarGardaniStatus<>8"
        End If
        DVabAnbarGardani.Refresh()

    End Sub

#End Region

#Region "ComboBox"

    Private Sub dcbFShomareshSN_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles dcbFShomareshSN.Enter
        Dim vSql As String
        Dim vAnbarGardaniSN As Decimal
        vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)

        If vAnbarGardaniSN <> 0 And OptMoghBetSho.Checked = True Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(vAnbarGardaniSN)
            dcbFShomareshSN.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If

    End Sub

    Private Sub dcbTShomareshSN_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles dcbTShomareshSN.Enter
        Dim vSql As String
        Dim vAnbarGardaniSN As Decimal
        vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)

        If vAnbarGardaniSN <> 0 And OptMoghBetSho.Checked = True Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(vAnbarGardaniSN)
            dcbTShomareshSN.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If

    End Sub

    Private Sub dcbFShomareshKhas_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles dcbFShomareshKhas.Enter
        Dim vSql As String
        Dim vAnbarGardaniSN As Decimal
        vAnbarGardaniSN = Val(DVabAnbarGardani.Fields("AnbarGardaniSN").Value)

        If vAnbarGardaniSN <> 0 And OptMoghMojWSho.Checked = True Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(vAnbarGardaniSN)
            dcbFShomareshKhas.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If

    End Sub

    Private Sub dcbNoeReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles dcbNoeReport.SelectedIndexChanged
        If dcbNoeReport.SelectedIndex = NOE_REPORT.TagParsWithChideman Then
            txtDesc.Visible = True
            txtDesc.Text = ""
        Else
            txtDesc.Visible = False
            txtDesc.Text = ""
        End If
    End Sub

#End Region

    Private Sub btnDarjAsanShomaresh_Click(sender As System.Object, e As System.EventArgs) Handles btnDarjAsanShomaresh.Click
        Dim vFrmDarjAsanShomareshHa As New FrmDarjAsanShomareshHa

        With vFrmDarjAsanShomareshHa
            .vAnbarGardaniSN = DVabAnbarGardani.FieldValue("AnbargardaniSN")
            .vShomareshSN = DVabShomaresh.FieldValue("ShomareshSN")
            .ShowDialog()
            DVabShomareshHa.Refresh()
            .Dispose()
        End With
    End Sub
    '''''''''ghasemi  14001225
    Private Sub btnTabdilVaziat_Click(sender As Object, e As EventArgs) Handles btnTabdilVaziat.Click
        ' تبديل رکورد از حالت حين اجرا به پیش نویس 
        Dim vli_NewVaziat As Short
        Dim vErrMsg As String
        'Dim vSanadSN As Object
        If Not (DVabAnbarGardani.AccessRight And EnumAccessRight.arUpdate) <> 0 Then Exit Sub
        If Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 4 OrElse Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 12 OrElse Val(DVabAnbarGardani.Fields("AnbarGardaniStatus").Value) = 16 Then
            vli_NewVaziat = 1
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("صدور رسید و حواله در حین انبارگردانی بر موجودی کالاها تاثیر خواهد داشت لذا می بایست در ثبت اسناد دقت لازم بعمل آید و همچنین  موجودی سیستمی و شمارش کالاها پس از ثبت اسناد مذکور مجددا کنترل شوند  " + vbNewLine + vbNewLine + "آيا انبارگرداني مورد نظر پیش نویس گردد؟", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        ' فراخواني اس پي براي تغيير وضعيت رکورد انبارگرداني
        cn.CallSP("_abSPC_Change_AnbarGardaniStatusToPishnevis", gAnbarSN, DVabAnbarGardani.Fields("AnbarGardaniSN").Value _
                   , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) +
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            MsgBox("عملیات تبدیل وضعیت به پیش نویس انجام شد", MsgBoxStyle.OkOnly, "پیغام")
            DVabAnbarGardani.AutoFetchCurrentRow = True
            DVabAnbarGardani.FetchCurRecord()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BtnInsertMojoudiInShomaresh_Click(sender As Object, e As EventArgs) Handles BtnInsertUpdateMojoudiInShomaresh.Click
        If DVabShomareshHa.DataRows <= 1 Then
            CSystem.MsgBox("ردیفی در " + DVabShomaresh.FieldText("ShomareshDS") + " درج نشده است", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If ChkInsertUpdateAllRadif.Checked = False AndAlso DVabShomareshHa.FlexGrid.SelectedRows = 0 Then
            CSystem.MsgBox("ردیفی برای درج در " + DVabShomaresh.FieldText("ShomareshDS") + " انتخاب نشده است", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If CSystem.MsgBox("آیا مایل هستید آخرین موجودی سیستم در مقدار شمارش " + vbNewLine + " < " + If(ChkInsertUpdateAllRadif.Checked, "تمام " + DVabShomareshHa.DataRows.ToString + " ردیف از ", DVabShomareshHa.FlexGrid.SelectedRows.ToString + " ردیف انتخاب شده از ") + " > " + vbNewLine + " کالاهای <" + DVabShomaresh.FieldText("ShomareshDS") + "> درج شود؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "درج موجودی در شمارش") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim _ShomareshHa As String = ""
        If ChkInsertUpdateAllRadif.Checked = False And DVabShomareshHa.FlexGrid.SelectedRows >= 1 Then
            With DVabShomareshHa.FlexGrid
                For i As Integer = 0 To .SelectedRows - 1
                    _ShomareshHa += If(IsNumeric(.TextMatrix(.SelectedRow(i), .ColIndex("ShomareshHaSN"))), .TextMatrix(.SelectedRow(i), .ColIndex("ShomareshHaSN")), "") + ","
                Next
            End With
        End If

        If _ShomareshHa.EndsWith(",") Then
            _ShomareshHa = _ShomareshHa.Substring(0, _ShomareshHa.Length - 1)
        End If
        Try
            cn.CallSP("abSpC_UpdateShomareshAnbarGardaniByMojoudi", CDec(DVabShomaresh.FieldValue("ShomareshSN")), If(ChkInsertUpdateAllRadif.Checked, "", _ShomareshHa))
            DVabShomareshHa.Refresh()

        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DvabVwreport_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DvabVwreport.CommandClick
        If aCommand = EnumCommands.cmPrint Then

        End If
    End Sub

    'Private Sub RdbShomareshZero_CheckedChanged(sender As Object, e As EventArgs) Handles RdbShomareshZero.CheckedChanged
    '    If RdbShomareshZero.Checked Then

    '        DVabShomareshHa.SQLWhere = "  Meghdar=0"
    '        DVabShomareshHa.Refresh()

    '    End If

    'End Sub

    'Private Sub RdbShomareshNull_CheckedChanged(sender As Object, e As EventArgs) Handles RdbShomareshNull.CheckedChanged
    '    If RdbShomareshNull.Checked Then
    '        DVabShomareshHa.SQLWhere = "  Meghdar is null"
    '        DVabShomareshHa.Refresh()

    '    End If

    'End Sub

    'Private Sub RdbShomareshAll_CheckedChanged(sender As Object, e As EventArgs) Handles RdbShomareshAll.CheckedChanged
    '    If IsNumeric(DVabShomaresh.FieldValue("ShomareshSN")) Then
    '        DVabShomareshHa.SQLWhere = "abShomareshHa.ShomareshSN=" & DVabShomaresh.FieldValue("ShomareshSN")
    '        DVabShomareshHa.Refresh()
    '    End If
    'End Sub
    '''''''''ghasemi  14001225
End Class
