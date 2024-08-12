Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Public Class RptHavalehDarkhastTolid
    Inherits ActiveReport3

    Public gRptabSanadNoeAnbar As Decimal

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "چاپ حواله درخواست تولید"

        Me.PageSettings.Orientation = PageOrientation.Landscape
        Me.PageSettings.Margins.Left = 0.2
        Me.PageSettings.Margins.Right = 0.4
        Me.PageSettings.Margins.Top = 0.3
        Me.PageSettings.Margins.Bottom = 0.5

    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private lblTitle As DataDynamics.ActiveReports.Label = Nothing
    Private lbl6 As DataDynamics.ActiveReports.Label = Nothing
    Private lblDate As DataDynamics.ActiveReports.Label = Nothing
    Private lbl7 As DataDynamics.ActiveReports.Label = Nothing
    Private lblTime As DataDynamics.ActiveReports.Label = Nothing
    Private lblCompany As DataDynamics.ActiveReports.Label = Nothing
    Private txtSadereh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVaredeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTedadAjza As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label As DataDynamics.ActiveReports.Label = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private txtpageNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtUser As DataDynamics.ActiveReports.TextBox = Nothing
    Private lbl3 As DataDynamics.ActiveReports.Label = Nothing
    Private txtPageTotal As DataDynamics.ActiveReports.TextBox = Nothing
    Private WithEvents lblSadereh As DataDynamics.ActiveReports.Label
    Private WithEvents lblTedadAjza As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents lblDesc As DataDynamics.ActiveReports.Label
    Private WithEvents lblCode As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEnghezaDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label10 As Label
    Private WithEvents TxtTozih As TextBox
    Friend WithEvents TxtVahedeSanjeshDs As TextBox
    Friend WithEvents TxtMojoodi As TextBox
    Friend WithEvents txtLabNo As TextBox
    Friend WithEvents chkNoeEngheza As CheckBox
    Friend WithEvents chkIsNewSource As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtqcStatus As TextBox
    Private Label44 As DataDynamics.ActiveReports.Label = Nothing
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptHavalehDarkhastTolid))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtSadereh = New DataDynamics.ActiveReports.TextBox()
        Me.TxtTozih = New DataDynamics.ActiveReports.TextBox()
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNo = New DataDynamics.ActiveReports.TextBox()
        Me.TxtEnghezaDate = New DataDynamics.ActiveReports.TextBox()
        Me.TxtVahedeSanjeshDs = New DataDynamics.ActiveReports.TextBox()
        Me.TxtMojoodi = New DataDynamics.ActiveReports.TextBox()
        Me.txtLabNo = New DataDynamics.ActiveReports.TextBox()
        Me.chkNoeEngheza = New DataDynamics.ActiveReports.CheckBox()
        Me.chkIsNewSource = New DataDynamics.ActiveReports.CheckBox()
        Me.txtqcStatus = New DataDynamics.ActiveReports.TextBox()
        Me.txtTedadAjza = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl6 = New DataDynamics.ActiveReports.Label()
        Me.lblDate = New DataDynamics.ActiveReports.Label()
        Me.lbl7 = New DataDynamics.ActiveReports.Label()
        Me.lblTime = New DataDynamics.ActiveReports.Label()
        Me.lblCompany = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.lblTedadAjza = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label45 = New DataDynamics.ActiveReports.Label()
        Me.lblDesc = New DataDynamics.ActiveReports.Label()
        Me.lblCode = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.lblSadereh = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label43 = New DataDynamics.ActiveReports.Label()
        Me.txtpageNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtUser = New DataDynamics.ActiveReports.TextBox()
        Me.lbl3 = New DataDynamics.ActiveReports.Label()
        Me.txtPageTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label44 = New DataDynamics.ActiveReports.Label()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        CType(Me.txtSadereh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTozih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEnghezaDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMojoodi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLabNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNoeEngheza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsNewSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqcStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSadereh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSadereh, Me.TxtTozih, Me.txtShomarehRahgiri, Me.txtKalaDS, Me.txtKalaNo, Me.TxtEnghezaDate, Me.TxtVahedeSanjeshDs, Me.TxtMojoodi, Me.txtLabNo, Me.chkNoeEngheza, Me.chkIsNewSource, Me.txtqcStatus})
        Me.Detail.Height = 0.2916667!
        Me.Detail.Name = "Detail"
        '
        'txtSadereh
        '
        Me.txtSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSadereh.Border.TopColor = System.Drawing.Color.Black
        Me.txtSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSadereh.CanGrow = False
        Me.txtSadereh.DataField = "Meghdar"
        Me.txtSadereh.Height = 0.3125!
        Me.txtSadereh.Left = 4.125!
        Me.txtSadereh.Name = "txtSadereh"
        Me.txtSadereh.OutputFormat = resources.GetString("txtSadereh.OutputFormat")
        Me.txtSadereh.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtSadereh.Text = "Meghdar"
        Me.txtSadereh.Top = 0!
        Me.txtSadereh.Width = 0.625!
        '
        'TxtTozih
        '
        Me.TxtTozih.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtTozih.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtTozih.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtTozih.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtTozih.Border.RightColor = System.Drawing.Color.Black
        Me.TxtTozih.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtTozih.Border.TopColor = System.Drawing.Color.Black
        Me.TxtTozih.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtTozih.Height = 0.3125!
        Me.TxtTozih.Left = 0.125!
        Me.TxtTozih.Name = "TxtTozih"
        Me.TxtTozih.OutputFormat = resources.GetString("TxtTozih.OutputFormat")
        Me.TxtTozih.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.TxtTozih.Text = "TxtTozih"
        Me.TxtTozih.Top = 0!
        Me.TxtTozih.Width = 1.5!
        '
        'txtShomarehRahgiri
        '
        Me.txtShomarehRahgiri.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        Me.txtShomarehRahgiri.Height = 0.3125!
        Me.txtShomarehRahgiri.Left = 6.6875!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtShomarehRahgiri.Text = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Top = 0!
        Me.txtShomarehRahgiri.Width = 0.8125!
        '
        'txtKalaDS
        '
        Me.txtKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.CanGrow = False
        Me.txtKalaDS.Height = 0.3125!
        Me.txtKalaDS.Left = 7.5!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 11pt; font-fami" &
    "ly: Calibri; vertical-align: middle; "
        Me.txtKalaDS.Text = "KalaDS"
        Me.txtKalaDS.Top = 0!
        Me.txtKalaDS.Width = 2.75!
        '
        'txtKalaNo
        '
        Me.txtKalaNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo.CanGrow = False
        Me.txtKalaNo.Height = 0.3125!
        Me.txtKalaNo.Left = 10.25!
        Me.txtKalaNo.Name = "txtKalaNo"
        Me.txtKalaNo.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtKalaNo.Text = "KalaNo"
        Me.txtKalaNo.Top = 0!
        Me.txtKalaNo.Width = 0.6875!
        '
        'TxtEnghezaDate
        '
        Me.TxtEnghezaDate.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtEnghezaDate.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtEnghezaDate.Border.RightColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtEnghezaDate.Border.TopColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate.DataField = "EnghezaDate"
        Me.TxtEnghezaDate.Height = 0.3125!
        Me.TxtEnghezaDate.Left = 5.875!
        Me.TxtEnghezaDate.Name = "TxtEnghezaDate"
        Me.TxtEnghezaDate.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.TxtEnghezaDate.Text = "txtEnghezaDate"
        Me.TxtEnghezaDate.Top = 0!
        Me.TxtEnghezaDate.Width = 0.8125!
        '
        'TxtVahedeSanjeshDs
        '
        Me.TxtVahedeSanjeshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtVahedeSanjeshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVahedeSanjeshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtVahedeSanjeshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVahedeSanjeshDs.Border.RightColor = System.Drawing.Color.Black
        Me.TxtVahedeSanjeshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVahedeSanjeshDs.Border.TopColor = System.Drawing.Color.Black
        Me.TxtVahedeSanjeshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtVahedeSanjeshDs.DataField = "VahedeSanjeshDs"
        Me.TxtVahedeSanjeshDs.Height = 0.3125!
        Me.TxtVahedeSanjeshDs.Left = 4.75!
        Me.TxtVahedeSanjeshDs.Name = "TxtVahedeSanjeshDs"
        Me.TxtVahedeSanjeshDs.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.TxtVahedeSanjeshDs.Text = "txtVahedeSanjeshDs"
        Me.TxtVahedeSanjeshDs.Top = 0!
        Me.TxtVahedeSanjeshDs.Width = 0.5625!
        '
        'TxtMojoodi
        '
        Me.TxtMojoodi.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtMojoodi.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtMojoodi.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtMojoodi.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtMojoodi.Border.RightColor = System.Drawing.Color.Black
        Me.TxtMojoodi.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtMojoodi.Border.TopColor = System.Drawing.Color.Black
        Me.TxtMojoodi.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtMojoodi.CanGrow = False
        Me.TxtMojoodi.DataField = "Mojoodi"
        Me.TxtMojoodi.Height = 0.3125!
        Me.TxtMojoodi.Left = 3.375!
        Me.TxtMojoodi.Name = "TxtMojoodi"
        Me.TxtMojoodi.OutputFormat = resources.GetString("TxtMojoodi.OutputFormat")
        Me.TxtMojoodi.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.TxtMojoodi.Text = "TxtMojoodi"
        Me.TxtMojoodi.Top = 0!
        Me.TxtMojoodi.Width = 0.75!
        '
        'txtLabNo
        '
        Me.txtLabNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtLabNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtLabNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtLabNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtLabNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtLabNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtLabNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtLabNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtLabNo.CanGrow = False
        Me.txtLabNo.DataField = "LabNo"
        Me.txtLabNo.Height = 0.3125!
        Me.txtLabNo.Left = 2.5625!
        Me.txtLabNo.Name = "txtLabNo"
        Me.txtLabNo.OutputFormat = resources.GetString("txtLabNo.OutputFormat")
        Me.txtLabNo.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtLabNo.Text = "txtLabNo"
        Me.txtLabNo.Top = 0!
        Me.txtLabNo.Width = 0.8125!
        '
        'chkNoeEngheza
        '
        Me.chkNoeEngheza.Border.BottomColor = System.Drawing.Color.Black
        Me.chkNoeEngheza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkNoeEngheza.Border.LeftColor = System.Drawing.Color.Black
        Me.chkNoeEngheza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkNoeEngheza.Border.RightColor = System.Drawing.Color.Black
        Me.chkNoeEngheza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkNoeEngheza.Border.TopColor = System.Drawing.Color.Black
        Me.chkNoeEngheza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkNoeEngheza.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkNoeEngheza.DataField = "NoeEngheza"
        Me.chkNoeEngheza.Height = 0.3125!
        Me.chkNoeEngheza.Left = 2.0625!
        Me.chkNoeEngheza.Name = "chkNoeEngheza"
        Me.chkNoeEngheza.Style = "font-weight: bold; font-size: 14.25pt; "
        Me.chkNoeEngheza.Text = ""
        Me.chkNoeEngheza.Top = 0!
        Me.chkNoeEngheza.Width = 0.5!
        '
        'chkIsNewSource
        '
        Me.chkIsNewSource.Border.BottomColor = System.Drawing.Color.Black
        Me.chkIsNewSource.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkIsNewSource.Border.LeftColor = System.Drawing.Color.Black
        Me.chkIsNewSource.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkIsNewSource.Border.RightColor = System.Drawing.Color.Black
        Me.chkIsNewSource.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.chkIsNewSource.Border.TopColor = System.Drawing.Color.Black
        Me.chkIsNewSource.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkIsNewSource.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkIsNewSource.DataField = "IsNewSource"
        Me.chkIsNewSource.Height = 0.3125!
        Me.chkIsNewSource.Left = 1.625!
        Me.chkIsNewSource.Name = "chkIsNewSource"
        Me.chkIsNewSource.Style = "font-weight: bold; font-size: 14.25pt; "
        Me.chkIsNewSource.Text = ""
        Me.chkIsNewSource.Top = 0!
        Me.chkIsNewSource.Width = 0.4375!
        '
        'txtqcStatus
        '
        Me.txtqcStatus.Border.BottomColor = System.Drawing.Color.Black
        Me.txtqcStatus.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtqcStatus.Border.LeftColor = System.Drawing.Color.Black
        Me.txtqcStatus.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtqcStatus.Border.RightColor = System.Drawing.Color.Black
        Me.txtqcStatus.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtqcStatus.Border.TopColor = System.Drawing.Color.Black
        Me.txtqcStatus.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtqcStatus.DataField = "NoeTarakoneshKalaDS"
        Me.txtqcStatus.Height = 0.3125!
        Me.txtqcStatus.Left = 5.3125!
        Me.txtqcStatus.Name = "txtqcStatus"
        Me.txtqcStatus.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtqcStatus.Text = "txtqcStatus"
        Me.txtqcStatus.Top = 0!
        Me.txtqcStatus.Width = 0.5625!
        '
        'txtTedadAjza
        '
        Me.txtTedadAjza.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadAjza.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadAjza.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.DataField = "TedadAjza"
        Me.txtTedadAjza.Height = 0.3125!
        Me.txtTedadAjza.Left = 4.75!
        Me.txtTedadAjza.Name = "txtTedadAjza"
        Me.txtTedadAjza.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.txtTedadAjza.Text = "txtTedadAjza"
        Me.txtTedadAjza.Top = 1.3125!
        Me.txtTedadAjza.Visible = False
        Me.txtTedadAjza.Width = 0.5!
        '
        'ReportHeader
        '
        Me.ReportHeader.Height = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl6, Me.lblDate, Me.lbl7, Me.lblTime, Me.lblCompany, Me.Label11, Me.lblTedadAjza, Me.txtTedadAjza, Me.Label4, Me.Label45, Me.lblDesc, Me.lblCode, Me.Label2, Me.Label3, Me.lblSadereh, Me.Label5, Me.Label6, Me.Label8, Me.Label9, Me.Label12})
        Me.PageHeader.Height = 2.541667!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblTitle
        '
        Me.lblTitle.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
        Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
        Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitle.DataField = "DarkhastDS"
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 0.25!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.lblTitle.Text = "توضیحات درخواست"
        Me.lblTitle.Top = 1.0!
        Me.lblTitle.Width = 10.625!
        '
        'lbl6
        '
        Me.lbl6.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl6.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl6.Border.RightColor = System.Drawing.Color.Black
        Me.lbl6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl6.Border.TopColor = System.Drawing.Color.Black
        Me.lbl6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl6.Height = 0.1965278!
        Me.lbl6.HyperLink = Nothing
        Me.lbl6.Left = 1.1875!
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl6.Text = " : تاريـخ گزارش"
        Me.lbl6.Top = 1.375!
        Me.lbl6.Width = 1.082639!
        '
        'lblDate
        '
        Me.lblDate.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDate.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDate.Border.RightColor = System.Drawing.Color.Black
        Me.lblDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDate.Border.TopColor = System.Drawing.Color.Black
        Me.lblDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDate.Height = 0.1965278!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 0.5!
        Me.lblDate.MultiLine = False
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblDate.Text = "lbl7"
        Me.lblDate.Top = 1.375!
        Me.lblDate.Width = 0.6888889!
        '
        'lbl7
        '
        Me.lbl7.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl7.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl7.Border.RightColor = System.Drawing.Color.Black
        Me.lbl7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl7.Border.TopColor = System.Drawing.Color.Black
        Me.lbl7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl7.Height = 0.1875!
        Me.lbl7.HyperLink = Nothing
        Me.lbl7.Left = 1.125!
        Me.lbl7.MultiLine = False
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl7.Text = ": ساعت "
        Me.lbl7.Top = 1.625!
        Me.lbl7.Width = 1.125!
        '
        'lblTime
        '
        Me.lblTime.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTime.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTime.Border.RightColor = System.Drawing.Color.Black
        Me.lblTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTime.Border.TopColor = System.Drawing.Color.Black
        Me.lblTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTime.Height = 0.1972222!
        Me.lblTime.HyperLink = Nothing
        Me.lblTime.Left = 0.5!
        Me.lblTime.MultiLine = False
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblTime.Text = "lbl8"
        Me.lblTime.Top = 1.625!
        Me.lblTime.Width = 0.6888889!
        '
        'lblCompany
        '
        Me.lblCompany.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCompany.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCompany.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCompany.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCompany.Border.RightColor = System.Drawing.Color.Black
        Me.lblCompany.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCompany.Border.TopColor = System.Drawing.Color.Black
        Me.lblCompany.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCompany.DataField = "DarkhastNo"
        Me.lblCompany.Height = 0.3125!
        Me.lblCompany.HyperLink = Nothing
        Me.lblCompany.Left = 0.25!
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.lblCompany.Text = "شماره درخواست"
        Me.lblCompany.Top = 0.625!
        Me.lblCompany.Width = 10.625!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.DataField = "DarkhastNo"
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.25!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.Label11.Text = "حواله درخواست تولید"
        Me.Label11.Top = 0.125!
        Me.Label11.Width = 10.625!
        '
        'lblTedadAjza
        '
        Me.lblTedadAjza.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTedadAjza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTedadAjza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Border.RightColor = System.Drawing.Color.Black
        Me.lblTedadAjza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTedadAjza.Border.TopColor = System.Drawing.Color.Black
        Me.lblTedadAjza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Height = 0.3125!
        Me.lblTedadAjza.HyperLink = Nothing
        Me.lblTedadAjza.Left = 4.125!
        Me.lblTedadAjza.Name = "lblTedadAjza"
        Me.lblTedadAjza.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.lblTedadAjza.Text = "تعداد در کارتن"
        Me.lblTedadAjza.Top = 1.3125!
        Me.lblTedadAjza.Visible = False
        Me.lblTedadAjza.Width = 0.5!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.5!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label4.Text = "موجودی"
        Me.Label4.Top = 2.0625!
        Me.Label4.Width = 0.75!
        '
        'Label45
        '
        Me.Label45.Border.BottomColor = System.Drawing.Color.Black
        Me.Label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.LeftColor = System.Drawing.Color.Black
        Me.Label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.RightColor = System.Drawing.Color.Black
        Me.Label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.TopColor = System.Drawing.Color.Black
        Me.Label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Height = 0.5!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 6.6875!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label45.Text = "شماره رهگيري"
        Me.Label45.Top = 2.0625!
        Me.Label45.Width = 0.8179263!
        '
        'lblDesc
        '
        Me.lblDesc.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Border.RightColor = System.Drawing.Color.Black
        Me.lblDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesc.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Height = 0.5!
        Me.lblDesc.HyperLink = Nothing
        Me.lblDesc.Left = 7.5!
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.lblDesc.Text = "نام کالا"
        Me.lblDesc.Top = 2.0625!
        Me.lblDesc.Width = 2.75!
        '
        'lblCode
        '
        Me.lblCode.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.RightColor = System.Drawing.Color.Black
        Me.lblCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Height = 0.5!
        Me.lblCode.HyperLink = Nothing
        Me.lblCode.Left = 10.25!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.lblCode.Text = "کد کالا"
        Me.lblCode.Top = 2.0625!
        Me.lblCode.Width = 0.6875!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.5!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label2.Text = "تاریخ انقضاء"
        Me.Label2.Top = 2.0625!
        Me.Label2.Width = 0.8125!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.5!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.75!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label3.Text = "واحد سنجش"
        Me.Label3.Top = 2.0625!
        Me.Label3.Width = 0.5625!
        '
        'lblSadereh
        '
        Me.lblSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Border.TopColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Height = 0.5!
        Me.lblSadereh.HyperLink = Nothing
        Me.lblSadereh.Left = 4.125!
        Me.lblSadereh.Name = "lblSadereh"
        Me.lblSadereh.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; background-color: White" &
    "; font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.lblSadereh.Text = "مقدار حواله"
        Me.lblSadereh.Top = 2.0625!
        Me.lblSadereh.Width = 0.625!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.5!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.5625!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label5.Text = "Lab No."
        Me.Label5.Top = 2.0625!
        Me.Label5.Width = 0.8125!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.5!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.0625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label6.Text = "Retest"
        Me.Label6.Top = 2.0625!
        Me.Label6.Width = 0.5!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Height = 0.5!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label8.Text = "سورس جدید"
        Me.Label8.Top = 2.0625!
        Me.Label8.Width = 0.4375!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Height = 0.5!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label9.Text = "توضیحات"
        Me.Label9.Top = 2.0625!
        Me.Label9.Width = 1.5!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Height = 0.5!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 5.3125!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label12.Text = "وضعیت رهگیری"
        Me.Label12.Top = 2.0625!
        Me.Label12.Width = 0.5625!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label43, Me.txtpageNo, Me.txtUser, Me.lbl3, Me.txtPageTotal, Me.Label44, Me.Label, Me.Label1, Me.Label7, Me.Label10})
        Me.PageFooter.Height = 1.697917!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label43
        '
        Me.Label43.Border.BottomColor = System.Drawing.Color.Black
        Me.Label43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.LeftColor = System.Drawing.Color.Black
        Me.Label43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.RightColor = System.Drawing.Color.Black
        Me.Label43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.TopColor = System.Drawing.Color.Black
        Me.Label43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Height = 0.1965278!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 2.0!
        Me.Label43.MultiLine = False
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; vertical-align: middle; "
        Me.Label43.Text = ":صفحه "
        Me.Label43.Top = 1.25!
        Me.Label43.Width = 0.4722222!
        '
        'txtpageNo
        '
        Me.txtpageNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtpageNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtpageNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtpageNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtpageNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtpageNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtpageNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtpageNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtpageNo.CanGrow = False
        Me.txtpageNo.Height = 0.1965278!
        Me.txtpageNo.Left = 1.4375!
        Me.txtpageNo.MultiLine = False
        Me.txtpageNo.Name = "txtpageNo"
        Me.txtpageNo.Style = "ddo-char-set: 178; text-align: left; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Tahoma; white-space: nowrap; vertical-align: middle; "
        Me.txtpageNo.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtpageNo.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtpageNo.Text = Nothing
        Me.txtpageNo.Top = 1.25!
        Me.txtpageNo.Width = 0.5902778!
        '
        'txtUser
        '
        Me.txtUser.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUser.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUser.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.RightColor = System.Drawing.Color.Black
        Me.txtUser.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.TopColor = System.Drawing.Color.Black
        Me.txtUser.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.CanGrow = False
        Me.txtUser.Height = 0.1965278!
        Me.txtUser.Left = 2.875!
        Me.txtUser.MultiLine = False
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; white-space: nowrap; vertical-align: middle; "
        Me.txtUser.Text = Nothing
        Me.txtUser.Top = 1.25!
        Me.txtUser.Width = 3.672222!
        '
        'lbl3
        '
        Me.lbl3.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl3.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl3.Border.RightColor = System.Drawing.Color.Black
        Me.lbl3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl3.Border.TopColor = System.Drawing.Color.Black
        Me.lbl3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl3.Height = 0.1965278!
        Me.lbl3.HyperLink = Nothing
        Me.lbl3.Left = 6.5625!
        Me.lbl3.MultiLine = False
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; vertical-align: middle; "
        Me.lbl3.Text = " :گزارش گيرنده"
        Me.lbl3.Top = 1.25!
        Me.lbl3.Width = 0.8555555!
        '
        'txtPageTotal
        '
        Me.txtPageTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPageTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPageTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPageTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPageTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtPageTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPageTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtPageTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPageTotal.Height = 0.1965278!
        Me.txtPageTotal.Left = 0.5!
        Me.txtPageTotal.Name = "txtPageTotal"
        Me.txtPageTotal.Style = "ddo-char-set: 178; text-align: right; font-size: 8.25pt; vertical-align: middle; " &
    ""
        Me.txtPageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtPageTotal.Text = Nothing
        Me.txtPageTotal.Top = 1.25!
        Me.txtPageTotal.Width = 0.75!
        '
        'Label44
        '
        Me.Label44.Border.BottomColor = System.Drawing.Color.Black
        Me.Label44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.LeftColor = System.Drawing.Color.Black
        Me.Label44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.RightColor = System.Drawing.Color.Black
        Me.Label44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.TopColor = System.Drawing.Color.Black
        Me.Label44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Height = 0.1965278!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 1.25!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "ddo-char-set: 178; text-align: center; font-size: 8.25pt; vertical-align: middle;" &
    " "
        Me.Label44.Text = "از"
        Me.Label44.Top = 1.25!
        Me.Label44.Width = 0.1875!
        '
        'Label
        '
        Me.Label.Border.BottomColor = System.Drawing.Color.Black
        Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.LeftColor = System.Drawing.Color.Black
        Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.RightColor = System.Drawing.Color.Black
        Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.TopColor = System.Drawing.Color.Black
        Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Height = 0.3125!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 8.8125!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.Label.Text = "برنامه ریزی"
        Me.Label.Top = 0.3125!
        Me.Label.Width = 0.875!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.Label1.Text = "کنترل کیفیت"
        Me.Label1.Top = 0.3125!
        Me.Label1.Width = 0.875!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.1875!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.Label7.Text = "مسئول فنی"
        Me.Label7.Top = 0.3125!
        Me.Label7.Width = 0.875!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 1.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" &
    "ily: Calibri; vertical-align: middle; "
        Me.Label10.Text = "تولید"
        Me.Label10.Top = 0.3125!
        Me.Label10.Width = 0.875!
        '
        'RptHavalehDarkhastTolid
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.08125!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.txtSadereh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTozih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEnghezaDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMojoodi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLabNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNoeEngheza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsNewSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqcStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSadereh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي

        Label11.DataField = ""

        lblCompany.DataField = "DarkhastNo"
        lblTitle.DataField = "DarkhastDS"

        txtShomarehRahgiri.DataField = "ShomarehRahgiri"

        txtKalaNo.DataField = "KalaNo"
        txtKalaDS.DataField = "KalaDS"

        TxtEnghezaDate.DataField = "EnghezaDate"

        txtSadereh.DataField = "Meghdar"
        TxtVahedeSanjeshDs.DataField = "VahedeSanjeshDs"
        TxtMojoodi.DataField = "Mojoodi"
        txtLabNo.DataField = "LabNo"

        txtTedadAjza.DataField = "TedadAjza"

        chkNoeEngheza.DataField = "NoeEngheza"
        chkIsNewSource.DataField = "IsNewSource"

        TxtTozih.DataField = "Tozih"

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        ' تهيه تاريخ از سرور
        lblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                 cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash)
        lblTime.Text = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server( _
                                                                                 cn, Functions.FTDBCommonFunctions.enmTimeFormat.HHmm)
    End Sub


    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtUser.Text = gSM.UserName
    End Sub


End Class
