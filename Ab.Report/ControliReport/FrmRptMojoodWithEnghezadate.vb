Option Strict Off
Option Explicit On

Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Anbar.BRL

Friend Class FrmRptMojoodWithEnghezadate
    Inherits JanusSimpleReport.frmRptJanusBase

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTamin As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTrooz As System.Windows.Forms.TextBox
    Friend WithEvents RdoDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RdoRooz As System.Windows.Forms.RadioButton
    Friend WithEvents CmbNoeTamin As cmpCheckedComboBox
    Friend WithEvents CmbTamin As cmpCheckedComboBox
    Friend WithEvents CmbMahsul As cmpCheckedComboBox
    Friend WithEvents CmbNoeMahsool As cmpCheckedComboBox
    Friend WithEvents AzTarikh As System.Windows.Forms.TextBox
    Friend WithEvents RdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents TxtTaEnghezaDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents CmbTarakonesh As cmpCheckedComboBox
    Friend WithEvents CmbAnbar As cmpCheckedComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoKala As System.Windows.Forms.RadioButton
    Friend WithEvents Rdotarakonesh As System.Windows.Forms.RadioButton
    Friend WithEvents btnEslahEnghezaDate As System.Windows.Forms.Button
    Public WithEvents TxtEnDate As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents TxtFaDate As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoSetRetestDate As System.Windows.Forms.RadioButton
    Friend WithEvents RdoChangeEnghezaDate As System.Windows.Forms.RadioButton
    Public WithEvents TxtBatchNO As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents dcbNoeTarakoneshKala As NetSql.Components.DataCombo

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbNoeMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbMahsul_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbNoeTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbTarakonesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptMojoodWithEnghezadate))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTamin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTrooz = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTaEnghezaDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.RdoAll = New System.Windows.Forms.RadioButton()
        Me.RdoDate = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RdoRooz = New System.Windows.Forms.RadioButton()
        Me.CmbNoeMahsool = New cmpCheckedComboBox(Me.components)
        Me.CmbMahsul = New cmpCheckedComboBox(Me.components)
        Me.CmbTamin = New cmpCheckedComboBox(Me.components)
        Me.CmbNoeTamin = New cmpCheckedComboBox(Me.components)
        Me.AzTarikh = New System.Windows.Forms.TextBox()
        Me.CmbTarakonesh = New cmpCheckedComboBox(Me.components)
        Me.CmbAnbar = New cmpCheckedComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rdotarakonesh = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RdoKala = New System.Windows.Forms.RadioButton()
        Me.btnEslahEnghezaDate = New System.Windows.Forms.Button()
        Me.TxtEnDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFaDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RdoSetRetestDate = New System.Windows.Forms.RadioButton()
        Me.RdoChangeEnghezaDate = New System.Windows.Forms.RadioButton()
        Me.TxtBatchNO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dcbNoeTarakoneshKala = New NetSql.Components.DataCombo(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.CmbAnbar)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.CmbTarakonesh)
        Me.pnlF.Controls.Add(Me.CmbNoeMahsool)
        Me.pnlF.Controls.Add(Me.CmbMahsul)
        Me.pnlF.Controls.Add(Me.CmbNoeTamin)
        Me.pnlF.Controls.Add(Me.AzTarikh)
        Me.pnlF.Controls.Add(Me.CmbTamin)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.lblTamin)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.GroupBox2)
        Me.pnlF.Controls.Add(Me.GroupBox1)
        Me.pnlF.Size = New System.Drawing.Size(1164, 124)
        Me.pnlF.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lblTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.AzTarikh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbNoeTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsul, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbNoeMahsool, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTarakonesh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(8, 74)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 124)
        Me.pnlGrid.Size = New System.Drawing.Size(1164, 305)
        '
        'pnlCommand
        '
        Me.pnlCommand.Size = New System.Drawing.Size(395, 62)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.GroupTotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(1164, 305)
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.TotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.TotalRowFormatStyle.Key = "سرجمع"
        Me.GridEX1.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        Me.GridEX1.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'btnExcelList
        '
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(96, 74)
        Me.btnChart.Visible = True
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Controls.Add(Me.dcbNoeTarakoneshKala)
        Me.pnlDownJanus.Controls.Add(Me.Label10)
        Me.pnlDownJanus.Controls.Add(Me.TxtBatchNO)
        Me.pnlDownJanus.Controls.Add(Me.Label9)
        Me.pnlDownJanus.Controls.Add(Me.GroupBox3)
        Me.pnlDownJanus.Controls.Add(Me.btnEslahEnghezaDate)
        Me.pnlDownJanus.Controls.Add(Me.TxtEnDate)
        Me.pnlDownJanus.Controls.Add(Me.Label6)
        Me.pnlDownJanus.Controls.Add(Me.TxtFaDate)
        Me.pnlDownJanus.Controls.Add(Me.Label8)
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 429)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1164, 62)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnModify, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.pnlCommand, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnExcell, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.Label8, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.TxtFaDate, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.TxtEnDate, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnEslahEnghezaDate, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.Label9, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.TxtBatchNO, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.Label10, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.dcbNoeTarakoneshKala, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(4, 7)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(1019, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 18)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "نوع کالا:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(1019, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "کالا:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTamin
        '
        Me.lblTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTamin.Location = New System.Drawing.Point(1019, 51)
        Me.lblTamin.Name = "lblTamin"
        Me.lblTamin.Size = New System.Drawing.Size(140, 19)
        Me.lblTamin.TabIndex = 152
        Me.lblTamin.Text = "تامين کننده :"
        Me.lblTamin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(1019, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 19)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "نوع تامین کننده :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTrooz
        '
        Me.TxtTrooz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTrooz.Location = New System.Drawing.Point(96, 10)
        Me.TxtTrooz.Name = "TxtTrooz"
        Me.TxtTrooz.Size = New System.Drawing.Size(34, 21)
        Me.TxtTrooz.TabIndex = 160
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTaEnghezaDate)
        Me.GroupBox1.Controls.Add(Me.RdoAll)
        Me.GroupBox1.Controls.Add(Me.RdoDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RdoRooz)
        Me.GroupBox1.Controls.Add(Me.TxtTrooz)
        Me.GroupBox1.Location = New System.Drawing.Point(370, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 86)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'TxtTaEnghezaDate
        '
        Me.TxtTaEnghezaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTaEnghezaDate.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.ShortDate
        Me.TxtTaEnghezaDate.Location = New System.Drawing.Point(3, 37)
        Me.TxtTaEnghezaDate.Mask = "9900/90/90"
        Me.TxtTaEnghezaDate.Name = "TxtTaEnghezaDate"
        Me.TxtTaEnghezaDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtTaEnghezaDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtTaEnghezaDate.TabIndex = 167
        Me.TxtTaEnghezaDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'RdoAll
        '
        Me.RdoAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoAll.AutoSize = True
        Me.RdoAll.Checked = True
        Me.RdoAll.Location = New System.Drawing.Point(181, 63)
        Me.RdoAll.Name = "RdoAll"
        Me.RdoAll.Size = New System.Drawing.Size(46, 17)
        Me.RdoAll.TabIndex = 166
        Me.RdoAll.TabStop = True
        Me.RdoAll.Text = "همه"
        Me.RdoAll.UseVisualStyleBackColor = True
        '
        'RdoDate
        '
        Me.RdoDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoDate.AutoSize = True
        Me.RdoDate.Location = New System.Drawing.Point(103, 37)
        Me.RdoDate.Name = "RdoDate"
        Me.RdoDate.Size = New System.Drawing.Size(124, 17)
        Me.RdoDate.TabIndex = 165
        Me.RdoDate.Text = "انقضای کمتر از تاریخ :"
        Me.RdoDate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(70, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 19)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "روز"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoRooz
        '
        Me.RdoRooz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoRooz.AutoSize = True
        Me.RdoRooz.Location = New System.Drawing.Point(134, 10)
        Me.RdoRooz.Name = "RdoRooz"
        Me.RdoRooz.Size = New System.Drawing.Size(93, 17)
        Me.RdoRooz.TabIndex = 162
        Me.RdoRooz.Text = "انقضای کمتر از"
        Me.RdoRooz.UseVisualStyleBackColor = True
        '
        'CmbNoeMahsool
        '
        Me.CmbNoeMahsool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbNoeMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeMahsool_DesignTimeLayout.LayoutString")
        Me.CmbNoeMahsool.DesignTimeLayout = CmbNoeMahsool_DesignTimeLayout
        Me.CmbNoeMahsool.LateBinding = True
        Me.CmbNoeMahsool.LateBindingTop = "100"
        Me.CmbNoeMahsool.Location = New System.Drawing.Point(727, 77)
        Me.CmbNoeMahsool.Name = "CmbNoeMahsool"
        Me.CmbNoeMahsool.SaveSettings = False
        Me.CmbNoeMahsool.ShowSelectAll = True
        Me.CmbNoeMahsool.Size = New System.Drawing.Size(293, 21)
        Me.CmbNoeMahsool.TabIndex = 167
        Me.CmbNoeMahsool.ValuesDataMember = Nothing
        Me.CmbNoeMahsool.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbMahsul
        '
        Me.CmbMahsul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbMahsul_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsul_DesignTimeLayout.LayoutString")
        Me.CmbMahsul.DesignTimeLayout = CmbMahsul_DesignTimeLayout
        Me.CmbMahsul.LateBinding = True
        Me.CmbMahsul.LateBindingTop = "100"
        Me.CmbMahsul.Location = New System.Drawing.Point(727, 100)
        Me.CmbMahsul.Name = "CmbMahsul"
        Me.CmbMahsul.SaveSettings = False
        Me.CmbMahsul.ShowSelectAll = True
        Me.CmbMahsul.Size = New System.Drawing.Size(293, 21)
        Me.CmbMahsul.TabIndex = 168
        Me.CmbMahsul.ValuesDataMember = Nothing
        Me.CmbMahsul.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbTamin
        '
        Me.CmbTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTamin_DesignTimeLayout.LayoutString = resources.GetString("CmbTamin_DesignTimeLayout.LayoutString")
        Me.CmbTamin.DesignTimeLayout = CmbTamin_DesignTimeLayout
        Me.CmbTamin.LateBinding = True
        Me.CmbTamin.LateBindingTop = "100"
        Me.CmbTamin.Location = New System.Drawing.Point(727, 54)
        Me.CmbTamin.Name = "CmbTamin"
        Me.CmbTamin.SaveSettings = False
        Me.CmbTamin.ShowSelectAll = True
        Me.CmbTamin.Size = New System.Drawing.Size(293, 21)
        Me.CmbTamin.TabIndex = 169
        Me.CmbTamin.ValuesDataMember = Nothing
        Me.CmbTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbNoeTamin
        '
        Me.CmbNoeTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbNoeTamin_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeTamin_DesignTimeLayout.LayoutString")
        Me.CmbNoeTamin.DesignTimeLayout = CmbNoeTamin_DesignTimeLayout
        Me.CmbNoeTamin.LateBinding = True
        Me.CmbNoeTamin.LateBindingTop = "100"
        Me.CmbNoeTamin.Location = New System.Drawing.Point(727, 30)
        Me.CmbNoeTamin.Name = "CmbNoeTamin"
        Me.CmbNoeTamin.SaveSettings = False
        Me.CmbNoeTamin.ShowSelectAll = True
        Me.CmbNoeTamin.Size = New System.Drawing.Size(293, 21)
        Me.CmbNoeTamin.TabIndex = 170
        Me.CmbNoeTamin.ValuesDataMember = Nothing
        Me.CmbNoeTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'AzTarikh
        '
        Me.AzTarikh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AzTarikh.Location = New System.Drawing.Point(12, 12)
        Me.AzTarikh.Name = "AzTarikh"
        Me.AzTarikh.Size = New System.Drawing.Size(19, 21)
        Me.AzTarikh.TabIndex = 154
        Me.AzTarikh.Visible = False
        '
        'CmbTarakonesh
        '
        Me.CmbTarakonesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTarakonesh_DesignTimeLayout.LayoutString = resources.GetString("CmbTarakonesh_DesignTimeLayout.LayoutString")
        Me.CmbTarakonesh.DesignTimeLayout = CmbTarakonesh_DesignTimeLayout
        Me.CmbTarakonesh.LateBinding = True
        Me.CmbTarakonesh.LateBindingTop = "100"
        Me.CmbTarakonesh.Location = New System.Drawing.Point(370, 6)
        Me.CmbTarakonesh.Name = "CmbTarakonesh"
        Me.CmbTarakonesh.SaveSettings = False
        Me.CmbTarakonesh.ShowSelectAll = True
        Me.CmbTarakonesh.Size = New System.Drawing.Size(287, 21)
        Me.CmbTarakonesh.TabIndex = 172
        Me.CmbTarakonesh.ValuesDataMember = Nothing
        Me.CmbTarakonesh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbAnbar
        '
        Me.CmbAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbAnbar_DesignTimeLayout.LayoutString = resources.GetString("CmbAnbar_DesignTimeLayout.LayoutString")
        Me.CmbAnbar.DesignTimeLayout = CmbAnbar_DesignTimeLayout
        Me.CmbAnbar.LateBinding = True
        Me.CmbAnbar.LateBindingTop = "100"
        Me.CmbAnbar.Location = New System.Drawing.Point(727, 7)
        Me.CmbAnbar.Name = "CmbAnbar"
        Me.CmbAnbar.SaveSettings = False
        Me.CmbAnbar.ShowSelectAll = True
        Me.CmbAnbar.Size = New System.Drawing.Size(293, 21)
        Me.CmbAnbar.TabIndex = 175
        Me.CmbAnbar.ValuesDataMember = Nothing
        Me.CmbAnbar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(1022, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "انبار :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(661, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "تراکنش:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Rdotarakonesh
        '
        Me.Rdotarakonesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rdotarakonesh.AutoSize = True
        Me.Rdotarakonesh.Location = New System.Drawing.Point(13, 12)
        Me.Rdotarakonesh.Name = "Rdotarakonesh"
        Me.Rdotarakonesh.Size = New System.Drawing.Size(96, 17)
        Me.Rdotarakonesh.TabIndex = 177
        Me.Rdotarakonesh.Text = "بتفکیک تراکنش"
        Me.Rdotarakonesh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RdoKala)
        Me.GroupBox2.Controls.Add(Me.Rdotarakonesh)
        Me.GroupBox2.Location = New System.Drawing.Point(605, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 57)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        '
        'RdoKala
        '
        Me.RdoKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoKala.AutoSize = True
        Me.RdoKala.Checked = True
        Me.RdoKala.Location = New System.Drawing.Point(32, 35)
        Me.RdoKala.Name = "RdoKala"
        Me.RdoKala.Size = New System.Drawing.Size(77, 17)
        Me.RdoKala.TabIndex = 178
        Me.RdoKala.TabStop = True
        Me.RdoKala.Text = "بتفکیک کالا"
        Me.RdoKala.UseVisualStyleBackColor = True
        '
        'btnEslahEnghezaDate
        '
        Me.btnEslahEnghezaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEslahEnghezaDate.Location = New System.Drawing.Point(401, 23)
        Me.btnEslahEnghezaDate.Name = "btnEslahEnghezaDate"
        Me.btnEslahEnghezaDate.Size = New System.Drawing.Size(130, 27)
        Me.btnEslahEnghezaDate.TabIndex = 23
        Me.btnEslahEnghezaDate.Text = "انجام عملیات"
        Me.btnEslahEnghezaDate.UseVisualStyleBackColor = True
        '
        'TxtEnDate
        '
        Me.TxtEnDate.AcceptsReturn = True
        Me.TxtEnDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEnDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEnDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtEnDate.Location = New System.Drawing.Point(859, 6)
        Me.TxtEnDate.MaxLength = 0
        Me.TxtEnDate.Name = "TxtEnDate"
        Me.TxtEnDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEnDate.Size = New System.Drawing.Size(86, 21)
        Me.TxtEnDate.TabIndex = 25
        Me.TxtEnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(946, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(60, 14)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "انگليسي :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtFaDate
        '
        Me.TxtFaDate.AcceptsReturn = True
        Me.TxtFaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFaDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFaDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFaDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFaDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFaDate.Location = New System.Drawing.Point(1012, 6)
        Me.TxtFaDate.MaxLength = 0
        Me.TxtFaDate.Name = "TxtFaDate"
        Me.TxtFaDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFaDate.Size = New System.Drawing.Size(88, 21)
        Me.TxtFaDate.TabIndex = 24
        Me.TxtFaDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1099, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(52, 14)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "فارسي :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RdoSetRetestDate)
        Me.GroupBox3.Controls.Add(Me.RdoChangeEnghezaDate)
        Me.GroupBox3.Location = New System.Drawing.Point(565, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(273, 32)
        Me.GroupBox3.TabIndex = 179
        Me.GroupBox3.TabStop = False
        '
        'RdoSetRetestDate
        '
        Me.RdoSetRetestDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoSetRetestDate.AutoSize = True
        Me.RdoSetRetestDate.Location = New System.Drawing.Point(7, 11)
        Me.RdoSetRetestDate.Name = "RdoSetRetestDate"
        Me.RdoSetRetestDate.Size = New System.Drawing.Size(141, 17)
        Me.RdoSetRetestDate.TabIndex = 178
        Me.RdoSetRetestDate.Text = "تمدید تاریخ انقضا(Retest)"
        Me.RdoSetRetestDate.UseVisualStyleBackColor = True
        '
        'RdoChangeEnghezaDate
        '
        Me.RdoChangeEnghezaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdoChangeEnghezaDate.AutoSize = True
        Me.RdoChangeEnghezaDate.Checked = True
        Me.RdoChangeEnghezaDate.Location = New System.Drawing.Point(157, 11)
        Me.RdoChangeEnghezaDate.Name = "RdoChangeEnghezaDate"
        Me.RdoChangeEnghezaDate.Size = New System.Drawing.Size(107, 17)
        Me.RdoChangeEnghezaDate.TabIndex = 177
        Me.RdoChangeEnghezaDate.TabStop = True
        Me.RdoChangeEnghezaDate.Text = "اصلاح تاریخ انقضاء"
        Me.RdoChangeEnghezaDate.UseVisualStyleBackColor = True
        '
        'TxtBatchNO
        '
        Me.TxtBatchNO.AcceptsReturn = True
        Me.TxtBatchNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBatchNO.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBatchNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBatchNO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBatchNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBatchNO.Location = New System.Drawing.Point(878, 38)
        Me.TxtBatchNO.MaxLength = 0
        Me.TxtBatchNO.Name = "TxtBatchNO"
        Me.TxtBatchNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBatchNO.Size = New System.Drawing.Size(217, 21)
        Me.TxtBatchNO.TabIndex = 180
        Me.TxtBatchNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(1099, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(63, 14)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "شماره بچ :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(755, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(116, 14)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "وضعیت کنترل کیفیت :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dcbNoeTarakoneshKala
        '
        Me.dcbNoeTarakoneshKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeTarakoneshKala.AutoSelectFirst = True
        Me.dcbNoeTarakoneshKala.BackColor = System.Drawing.Color.White
        Me.dcbNoeTarakoneshKala.BoundText = Nothing
        Me.dcbNoeTarakoneshKala.BypassChangeEvent = False
        Me.dcbNoeTarakoneshKala.DisplayText = ""
        Me.dcbNoeTarakoneshKala.LateBindingTop = "100"
        Me.dcbNoeTarakoneshKala.Location = New System.Drawing.Point(560, 38)
        Me.dcbNoeTarakoneshKala.MemFilter = ""
        Me.dcbNoeTarakoneshKala.Name = "dcbNoeTarakoneshKala"
        Me.dcbNoeTarakoneshKala.SeparatedData = Nothing
        Me.dcbNoeTarakoneshKala.Size = New System.Drawing.Size(189, 21)
        Me.dcbNoeTarakoneshKala.Source = Nothing
        Me.dcbNoeTarakoneshKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeTarakoneshKala.TabIndex = 183
        '
        'FrmRptMojoodWithEnghezadate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1164, 491)
        Me.Name = "FrmRptMojoodWithEnghezadate"
        Me.Text = "گزارش موجودي و تاریخ انقضای محصول"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.pnlDownJanus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptMojoodWithEnghezadate
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmRptMojoodWithEnghezadate
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptMojoodWithEnghezadate
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptMojoodWithEnghezadate)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub SetCaptions()
        Try
            With GridEX1
                With .RootTable.Columns

                    With .Add("KalaSN", Janus.Windows.GridEX.ColumnType.Text)
                        .Visible = False
                    End With
                    With .Add("KalaPhizikiSN", Janus.Windows.GridEX.ColumnType.Text)
                        .Visible = False
                    End With

                    With .Add("VahedeTejariDs", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "واحد تجاری"
                    End With
                    With .Add("NoeTaminKonandehDS", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "نوع تامین کننده"
                    End With
                    '------ add by Dehghani 921213----------
                    With .Add("TaminKonandehDS", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تامین کننده"
                    End With

                    With .Add("NoeMahsoolDS", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "نوع کالا"
                    End With
                    With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "کد کالا"
                    End With
                    With .Add("KalaDs", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "شرح کالا"
                    End With
                    '------ add by yekta 920910----------
                    With .Add("KalaLatinDs", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "شرح لاتین کالا"
                    End With
                    '------ add by yekta 920910----------
                    With .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "رهگیری"
                    End With
                    '------ add by yekta 920910----------
                    With .Add("BatchNO", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "شماره بچ"
                    End With
                    '------ add by yekta 920910----------
                    With .Add("NoeTarakoneshKalaDS", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "کنترل کیفیت"
                    End With
                    '-------------add by yekta 921114------------
                    With .Add("MoaserDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ ورود"
                        .CellStyle.ForeColor = Color.DarkBlue
                    End With
                    With .Add("MoaserDateMiladi", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ ورود میلادی"
                        .CellStyle.ForeColor = Color.Navy
                    End With
                    With .Add("ToolidDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ تولید"
                        .CellStyle.ForeColor = Color.DarkBlue
                    End With
                    With .Add("ToolidDateMiladi", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ تولید میلادی"
                        .CellStyle.ForeColor = Color.DarkBlue
                    End With
                    '-------------add by yekta 921114------------
                    With .Add("EnghezaDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ انقضاء"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    End With
                    '-------------add by yekta 920910------------
                    With .Add("EnghezaDateMiladi", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ انقضای میلادی"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    End With
                    '-------------add by yekta 920910------------
                    With .Add("RoozTaEngheza", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "روز تا انقضاء"
                        .FormatString = "0,0"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    End With
                    With .Add("Mojoodi", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "موجودی"
                        .FormatString = "0,0"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    End With
                    '-------------add by yekta 950620------------
                    With .Add("MojoodiRialiForoosh", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "موجودی ریالی با آخرین نرخ فروش"
                        .FormatString = "0,0"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                        .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                        .TotalFormatString = "0,0"
                    End With
                    '-------------add by yekta 950620------------
                    '-------------add by ghafari 950628------------
                    With .Add("MojoodiRialiKharid", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "موجودی ریالی با آخرین نرخ خرید"
                        .FormatString = "0,0"
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                        .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                        .TotalFormatString = "0,0"
                    End With
                    '-------------add by ghafari 950628------------
                    With .Add("Tozih", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "توضیحات"
                    End With
                    '-------------add by yekta 921114------------
                    With .Add("Tozih2", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = " توضیحات تغییرات"
                    End With
                    '-------------add by yekta 921114------------
                End With
                GridEX1.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private dclTDate1 As NetSql.Components.CDateCtrl
    Private dclTDate2 As NetSql.Components.CDateCtrl
    Private dclFDate As NetSql.Components.CDateCtrl

    Enum diagramFieldType
        Key = 0
        Riali = 1
        Tedadi = 2
        Darsadi = 3
        Ineffect = 4
        none = 5
    End Enum

    Sub SetVaziat()
        For index As Integer = 0 To GridEX1.DataSource.Table.Columns.Count - 1
            GridEX1.DataSource.Table.Columns(index).Namespace = diagramFieldType.none
        Next

        If Rdotarakonesh.Checked = True Then
            With GridEX1.RootTable.Columns
                If GridEX1.RootTable.Columns.Item("TarakoneshDS") Is Nothing Then
                    With .Add("TarakoneshDS", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تراکنش"
                    End With
                End If
                If GridEX1.RootTable.Columns.Item("SanadDate") Is Nothing Then
                    With .Add("SanadDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ سند"
                    End With
                End If

            End With
        Else
            If Not GridEX1.RootTable.Columns.Item("TarakoneshDS") Is Nothing Then
                GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns.Item("TarakoneshDS"))
            End If
            If Not GridEX1.RootTable.Columns.Item("SanadDate") Is Nothing Then
                GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns.Item("SanadDate"))
            End If
        End If

        With GridEX1.DataSource.Table
            .Columns("RoozTaEngheza").Namespace = diagramFieldType.Tedadi
            .Columns("Mojoodi").Namespace = diagramFieldType.Tedadi
        End With

    End Sub

    Private Sub FrmRptTafrigheBoodjehForoosh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load


        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = TxtFaDate
        dclFDate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfFullYear
        TxtFaDate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, NetSql.Common.CShamsiDate.EnumDateFormat.dfWithSlash) 'gFromDate

        TxtEnDate.Text = Now.Date.ToString("yyyy/MM/dd")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnEslahEnghezaDate.Enabled = gSM.TableAccessRight("btnEslahEnghezaDate")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)

        Dim _vtSql As String = "Select AnbarSN,AnbarDS from abAnbar Where VahedetejariSn=" & gVahedeTejariSN
        With CmbAnbar
            .Bind(cn, _vtSql, "AnbarSN", "AnbarDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        With CmbNoeTamin
            .Bind(cn, "Select NoeVahedeTejariSN,NoeVahedeTejariDS from PaNoeVahedeTejari", "NoeVahedeTejariSN", "NoeVahedeTejariDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        Dim _vtkSql As String = "select distinct pakalaTamin.VahedetejariSN TaminKonandehSN,VahedetejariDS TaminKonandehDS from pakalaTamin" &
        " inner join paVahedetejari on pakalaTamin.VahedetejariSN=paVahedetejari.VahedetejariSN"
        With CmbTamin
            .Bind(cn, _vtkSql, "TaminKonandehSN", "TaminKonandehDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        With CmbNoeMahsool
            .Bind(cn, "Select NoeMahsoolSN,NoeMahsoolDS from PaNoeMahsool", "NoeMahsoolSN", "NoeMahsoolDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        Dim _vtmSql As String = "select  KalaSN,KalaNo+'.'+KalaDS KalaDS from pakala"
        With CmbMahsul
            .Bind(cn, _vtmSql, "KalaSN", "KalaDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        With CmbTarakonesh
            .Bind(cn, "Select TarakoneshSN,TarakoneshDs From abTarakonesh", "TarakoneshSN", "TarakoneshDs")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        With dcbNoeTarakoneshKala
            .Bind(cn, "Select NoeTarakoneshKalaSN,NoeTarakoneshKalaDS From paNoeTarakoneshKala", "NoeTarakoneshKalaSN", "NoeTarakoneshKalaDS")
            .Enabled = True
            .DroppedDown = True
        End With

        AzTarikh.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        TxtTaEnghezaDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)

        SetCaptions()

    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click

        Dim vErrMsg As String
        Dim vTaminKonandehSN, vNoeTaminSN, vAnbarSN, vNoeMahsoolSN, vMahsulSN, vTaEnghazadate, vTarakoneshSN As String
        Dim _TRooz, _IsRooz, _type As Integer

        _type = 0
        If RdoAll.Checked = True Then
            _IsRooz = 0
        ElseIf RdoRooz.Checked = True Then
            _IsRooz = 1
        ElseIf RdoDate.Checked = True Then
            _IsRooz = 2
        End If
        If RdoRooz.Checked = True Then
            _TRooz = TxtTrooz.Text
        Else
            _TRooz = 0
        End If

        If RdoDate.Checked = True Then
            'vTaEnghazadate = (TxtTaEnghezaDate.Text).Substring(2, 6)
            vTaEnghazadate = (TxtTaEnghezaDate.Text)
        Else
            vTaEnghazadate = "0"
        End If

        If Trim(CmbTamin.getStringValues) <> "" Then
            vTaminKonandehSN = CmbTamin.getStringValues
            If vTaminKonandehSN = "0.000" Then
                vTaminKonandehSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "تامین کننده مشخص نشده است"
        End If
        If Trim(CmbAnbar.getStringValues) <> "" Then
            vAnbarSN = CmbAnbar.getStringValues
            If vAnbarSN = "0.000" Then
                vAnbarSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "انبار مشخص نشده است"
        End If

        If Trim(CmbNoeTamin.getStringValues) <> "" Then
            vNoeTaminSN = CmbNoeTamin.getStringValues
            If vNoeTaminSN = "0.000" Then
                vNoeTaminSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "نوع تامین کننده مشخص نشده است"
        End If

        If Trim(CmbNoeMahsool.getStringValues) <> "" Then
            vNoeMahsoolSN = CmbNoeMahsool.getStringValues
            If vNoeMahsoolSN = "0.000" Then
                vNoeMahsoolSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "نوع محصول مشخص نشده است"
        End If

        If Trim(CmbMahsul.getStringValues) <> "" Then
            vMahsulSN = CmbMahsul.getStringValues
            If vMahsulSN = "0.000" Then
                vMahsulSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "محصول مشخص نشده است"
        End If

        If Trim(CmbTarakonesh.getStringValues) <> "" Then
            vTarakoneshSN = CmbTarakonesh.getStringValues
            If vTarakoneshSN = "0.000" Then
                vTarakoneshSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "تراکنش مشخص نشده است"
        End If

        If Rdotarakonesh.Checked = True Then
            _type = 1
        End If

        If vErrMsg = "" Then
            Me.Cursor = Cursors.WaitCursor
            Dim thisWaitFrm As New Anbar.Common.Frmwait
            thisWaitFrm.Show()
            thisWaitFrm.Refresh()
            Try
                Dim _d As New ClsDataAccessRule
                Dim dv As DataView
                GridEX1.DataSource = Nothing
                dv = _d.GetMojoodiAndEnghezaDate(gVahedeTejariSN, vAnbarSN, vTaminKonandehSN, vNoeTaminSN, vMahsulSN, vNoeMahsoolSN, _TRooz, vTaEnghazadate, vTarakoneshSN, _IsRooz, _type, cn, tp)

                If dv Is Nothing Then
                    'MsgBox("اطلاعات مورد نظر دريافت نشد", MsgBoxStyle.OkOnly, "پيغام")
                    thisWaitFrm.Close()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                '---------add by yekta 920910-------------change by yekta 921114
                dv.Table.Columns.Add("EnghezaDateMiladi", GetType(System.String))
                dv.Table.Columns.Add("ToolidDateMiladi", GetType(System.String))
                dv.Table.Columns.Add("MoaserDateMiladi", GetType(System.String))
                Dim EnghezaDateMiladi As String
                For i As Integer = 0 To dv.Table.Rows.Count - 1

                    If dv.Item(i).Item("EnghezaDate").ToString = "" Then
                        dv.Item(i).Item("EnghezaDateMiladi") = ""
                        dv.Item(i).Item("RoozTaEngheza") = DBNull.Value

                    Else
                        dv.Item(i).Item("EnghezaDateMiladi") = NetSql.Common.CShamsiDate.ShamsiToMiladi(dv.Item(i).Item("EnghezaDate").ToString).ToString.Substring(0, 10)
                        '------ add by Dehghani 921213----------
                        Dim arr As String() = dv.Item(i).Item("EnghezaDateMiladi").ToString.Split("/")
                        dv.Item(i).Item("EnghezaDateMiladi") = arr(1) + "/" + arr(0) + "/" + arr(2)
                        dv.Item(i).Item("EnghezaDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("EnghezaDate").ToString, EnumDateFormat.dfFullYear)
                        Dim EnghezaDateSal = dv.Item(i).Item("EnghezaDate").Substring(0, 4)
                        Dim EnghezaDateMah = dv.Item(i).Item("EnghezaDate").Substring(4, 2)
                        Dim EnghezaDateRooz = dv.Item(i).Item("EnghezaDate").Substring(6, 2)
                        dv.Item(i).Item("EnghezaDate") = EnghezaDateSal + "/" + EnghezaDateMah + "/" + EnghezaDateRooz
                    End If

                    If dv.Item(i).Item("ToolidDate").ToString = "" Then
                        dv.Item(i).Item("ToolidDateMiladi") = ""
                    Else
                        dv.Item(i).Item("ToolidDateMiladi") = NetSql.Common.CShamsiDate.ShamsiToMiladi(dv.Item(i).Item("ToolidDate").ToString).ToString.Substring(0, 10)
                        '------ add by Dehghani 921213----------
                        Dim arr As String() = dv.Item(i).Item("ToolidDateMiladi").ToString.Split("/")
                        dv.Item(i).Item("ToolidDateMiladi") = arr(1) + "/" + arr(0) + "/" + arr(2)
                        dv.Item(i).Item("ToolidDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("ToolidDate").ToString, EnumDateFormat.dfFullYear)
                    End If

                    If dv.Item(i).Item("MoaserDate").ToString = "" Then
                        dv.Item(i).Item("MoaserDateMiladi") = ""
                    Else
                        dv.Item(i).Item("MoaserDateMiladi") = NetSql.Common.CShamsiDate.ShamsiToMiladi(dv.Item(i).Item("MoaserDate").ToString).ToString.Substring(0, 10)
                        '------ add by Dehghani 921213----------
                        Dim arr As String() = dv.Item(i).Item("MoaserDateMiladi").ToString.Split("/")
                        dv.Item(i).Item("MoaserDateMiladi") = arr(1) + "/" + arr(0) + "/" + arr(2)
                        dv.Item(i).Item("MoaserDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("MoaserDate").ToString, EnumDateFormat.dfFullYear)
                    End If
                Next
                '---------add by yekta 920910-------------change by yekta 921114

                GridEX1.DataSource = dv

                'SetCaptions()

                SetVaziat()

                RefreshDataSet()

                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default

            Catch ex As Exception
                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default
                NetSql.Common.CSystem.MsgBox("اشكالي در تهيه ي اين گزارش بوجود آمده است. ", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
            End Try


        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub CmbTamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim _Anbar As Decimal = CDec(CmbNoeMahsool.Text)
            Dim _Tamin As Decimal = CDec(CmbTamin.Text)
            If _Anbar <> 0 Then
                Dim _str As String = "SELECT DISTINCT TOP (100) PERCENT dbo.paKala.KalaSN," &
                " dbo.paKala.KalaNo + ' _ ' + dbo.paKala.KalaDs AS KalaNoDs" &
                " FROM         dbo.abAnbarKala RIGHT OUTER JOIN  " &
                " dbo.paKala ON dbo.abAnbarKala.KalaSN = dbo.paKala.KalaSN LEFT OUTER JOIN  " &
                " dbo.paKalaTamin ON dbo.paKala.KalaSN = dbo.paKalaTamin.KalaSN  " &
                " GROUP BY dbo.paKala.KalaSN, dbo.paKala.KalaNo + ' _ ' + dbo.paKala.KalaDs, " &
                " dbo.paKalaTamin.VahedeTejariSN, dbo.abAnbarKala.AnbarSN HAVINg" &
                " (dbo.paKalaTamin.VahedeTejariSN = " & _Tamin & " Or " & _Tamin & "=0)   " &
                " ORDER BY KalaNoDs  "

                'Cmbmhsul.Bind(cn, _str, "KalaSN", "KalaNODs").Sort = "KalaSN"

            End If

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RdoDate_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles RdoDate.CheckedChanged
        If RdoDate.Checked = True Then
            TxtTrooz.Enabled = False
            TxtTaEnghezaDate.Enabled = True
        End If
    End Sub

    Private Sub RdoRooz_CheckedChanged(sender As System.Object, e As System.EventArgs) _
         Handles RdoRooz.CheckedChanged
        If RdoRooz.Checked = True Then
            TxtTrooz.Enabled = True
            TxtTaEnghezaDate.Enabled = False
        End If
    End Sub

    Private Sub RdoAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoAll.CheckedChanged
        TxtTrooz.Enabled = False
        TxtTaEnghezaDate.Enabled = False
    End Sub

    Private Sub CmbNoeTamin_CheckedValuesChanged(sender As System.Object, e As System.EventArgs)

        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)

        Dim _NoeVahedetejarisn As String = CmbNoeTamin.getStringValues
        If _NoeVahedetejarisn = "" Or _NoeVahedetejarisn = "0.000" Or _NoeVahedetejarisn = "0" Then
            CmbTamin.Clear()
        Else
            Dim _vtkSql As String = "select distinct pakalaTamin.VahedetejariSN TaminKonandehSN,VahedetejariDS TaminKonandehDS from pakalaTamin" &
            " inner join paVahedetejari on pakalaTamin.VahedetejariSN=paVahedetejari.VahedetejariSN Where NoeVahedetejariSN in (" & _NoeVahedetejarisn & ")"
            With CmbTamin
                .Bind(cn, _vtkSql, "TaminKonandehSN", "TaminKonandehDS")
                .Enabled = True
                .ShowSelectAll = True
                .CheckedValues = ArrayLst.ToArray
                .DroppedDown = True
            End With
        End If
    End Sub

    Private Sub CmbNoeMahsool_CheckedValuesChanged(sender As System.Object, e As System.EventArgs)

        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)

        Dim _NoeMahsool As String = CmbNoeMahsool.getStringValues
        If _NoeMahsool = "" Or _NoeMahsool = "0.000" Or _NoeMahsool = "0" Then
            CmbMahsul.Clear()
        Else
            Dim _vtmSql As String = "select  KalaSN,KalaNo+'.'+KalaDS KalaDS from pakala Where NoeMahsoolSn in (" & _NoeMahsool & ")"
            With CmbMahsul
                .Bind(cn, _vtmSql, "KalaSN", "KalaDS")
                .Enabled = True
                .ShowSelectAll = True
                .CheckedValues = ArrayLst.ToArray
                .DroppedDown = True
            End With
        End If
    End Sub

    Private Sub rdoTrakonesh_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles Rdotarakonesh.CheckedChanged

        'If Rdotarakonesh.Checked = True Then
        '    CmbTarakonesh.Enabled = True
        'Else
        '    CmbTarakonesh.Enabled = False
        'End If

    End Sub

    Private Sub btnEslahEnghezaDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles btnEslahEnghezaDate.Click
        Try
            If GridEX1.RowCount <= 0 Then
                NetSql.Common.CSystem.MsgBox("ركوردي جهت انجام عمليات وجود ندارد", MsgBoxStyle.OkOnly, "")
                Exit Sub
            End If
            Dim dgrow As Janus.Windows.GridEX.GridEXRow
            dgrow = GridEX1.GetRow()
            If Not dgrow.Cells("EnghezaDate").Value Is DBNull.Value AndAlso Len(dgrow.Cells("EnghezaDate").Value) = 0 AndAlso dgrow.Cells("EnghezaDate").Value = "//" Then
                If NetSql.Common.CSystem.MsgBox("تاريخ انقضاء وجود دارد ،آيا مايل به ويرايش آن مي باشيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            If Not dgrow.Cells("BatchNO").Value.ToString = "" AndAlso Len(dgrow.Cells("BatchNO").Value) = 0 Then
                If NetSql.Common.CSystem.MsgBox("شماره بچ وجود دارد ،آيا مايل به ويرايش آن مي باشيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Dim _kalasn As Decimal = dgrow.Cells("KalaSN").Value
            Dim _KalaphizikiSN As String = dgrow.Cells("KalaphizikiSN").Value
            Dim _NewEnghezaDate As String = NetSql.Common.CShamsiDate.FormatDate(TxtFaDate.Text, EnumDateFormat.dfFullYear)
            Dim _NewBatchNO As String = TxtBatchNO.Text
            Dim _NewNoeTarakoneshKalaSN As Decimal = dcbNoeTarakoneshKala.SelectedValue
            Dim _OperationType As String

            If RdoChangeEnghezaDate.Checked = True Then
                _OperationType = RdoChangeEnghezaDate.Text
            Else
                _OperationType = "Retest"
            End If
            If _kalasn <> 0 And _KalaphizikiSN <> 0 And (IIf(dgrow.Cells("EnghezaDateMiladi").Value Is System.DBNull.Value, "", dgrow.Cells("EnghezaDateMiladi").Value) <> NetSql.Common.CShamsiDate.FormatDate(_NewEnghezaDate, EnumDateFormat.dfWithSlash) Or dgrow.Cells("BatchNO").Value.ToString <> _NewBatchNO) Then
                cn.CallSP("_abSpC_UpdateEnghezaDatekalaphiziki", _KalaphizikiSN, _NewEnghezaDate, _NewBatchNO, _NewNoeTarakoneshKalaSN, _OperationType, gSM.UserID_Name, System.Environment.MachineName)
            End If

            btnViewReport_Click(sender, e)

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub TxtFaDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TxtFaDate.Validated
        Try
            If TxtFaDate.Text <> "____/__/__" Then
                TxtEnDate.Text = NetSql.Common.CShamsiDate.ShamsiToMiladi(TxtFaDate.Text).ToString("yyyy/MM/dd") 'gFromDate
                TxtEnDate.BackColor = Color.White
            End If
        Catch ex As Exception
            TxtEnDate.BackColor = Color.Red
        End Try


    End Sub

    Private Sub TxtEnDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TxtEnDate.Validated

        Try
            If Len(TxtEnDate.Text) = 10 Then
                TxtFaDate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi(TxtEnDate.Text, NetSql.Common.CShamsiDate.EnumDateFormat.dfWithSlash) 'gFromDate
                TxtFaDate.BackColor = Color.White
            End If
        Catch ex As Exception
            TxtFaDate.BackColor = Color.Red
        End Try

    End Sub

    Private Sub GridEX1_RowCheckStateChanged(sender As System.Object, e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEX1.RowCheckStateChanged

    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        Dim dgrow As Janus.Windows.GridEX.GridEXRow
        dgrow = GridEX1.GetRow()
        TxtEnDate.Text = IIf(dgrow.Cells("EnghezaDateMiladi").Value Is System.DBNull.Value OrElse dgrow.Cells("EnghezaDateMiladi").Value = "", Now.Date.ToString("yyyy/MM/dd"), dgrow.Cells("EnghezaDateMiladi").Value)
        TxtFaDate.Text = IIf(dgrow.Cells("EnghezaDate").Value Is System.DBNull.Value OrElse dgrow.Cells("EnghezaDateMiladi").Value = "", NetSql.Common.CShamsiDate.MiladiToShamsi(DateTime.Now.Date, EnumDateFormat.dfWithSlash), dgrow.Cells("EnghezaDate").Value)
        TxtBatchNO.Text = IIf(dgrow.Cells("BatchNO").Value Is System.DBNull.Value, "", dgrow.Cells("BatchNO").Value)
        dcbNoeTarakoneshKala.SelectedItem = IIf(dgrow.Cells("NoeTarakoneshKalaDS").Value Is System.DBNull.Value, "", dgrow.Cells("NoeTarakoneshKalaDS").Value)


        If Not dgrow.Cells("EnghezaDateMiladi").Value Is System.DBNull.Value OrElse dgrow.Cells("EnghezaDateMiladi").Value = "" Then
            TxtEnDate.Text = Regex.Replace(TxtEnDate.Text, "^(\d{2})/(\d{2})/(\d{4})$", "$3/$2/$1") 'برای تیدیل     04/11/2022 به 2022/11/04
        End If


    End Sub


End Class
