Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Public Class RptabSanad
    Inherits ActiveReport3

    Public gRptabSanadNoeAnbar As Decimal

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "گزارش چاپ اسناد"
        lblCompany.Text = gSM.CompanyName
        txtRadif.Text = 0
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GrpHedSanadSN As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GrpFtSanadSN As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private lblTitle As DataDynamics.ActiveReports.Label = Nothing
    Private lbl6 As DataDynamics.ActiveReports.Label = Nothing
    Private lblDate As DataDynamics.ActiveReports.Label = Nothing
    Private lbl7 As DataDynamics.ActiveReports.Label = Nothing
    Private lblTime As DataDynamics.ActiveReports.Label = Nothing
    Private lblCompany As DataDynamics.ActiveReports.Label = Nothing
    Private lblMoaserDate As DataDynamics.ActiveReports.Label = Nothing
    Private txtMoaserDate As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblSanadStatusDS As DataDynamics.ActiveReports.Label = Nothing
    Private txtSanadStatusDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSanadNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblSanadNO As DataDynamics.ActiveReports.Label = Nothing
    Private lblTarakoneshDs As DataDynamics.ActiveReports.Label = Nothing
    Private txtTarakoneshDs As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblAnbarNo As DataDynamics.ActiveReports.Label = Nothing
    Private txtAnbarNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblNoeAnbarNO As DataDynamics.ActiveReports.Label = Nothing
    Private txtNoeAnbarNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblTafsiliDs As DataDynamics.ActiveReports.Label = Nothing
    Private txtTafsiliDs As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblShomarehSefaresh As DataDynamics.ActiveReports.Label = Nothing
    Private txtShomarehSefaresh As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblTozih As DataDynamics.ActiveReports.Label = Nothing
    Private txtTozih As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblFactorNo As DataDynamics.ActiveReports.Label = Nothing
    Private txtFactorNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSadereh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVaredeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTedadAjza As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSumSadereh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSumVaredeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label36 As DataDynamics.ActiveReports.Label = Nothing
    Private Label As DataDynamics.ActiveReports.Label = Nothing
    Private Label1 As DataDynamics.ActiveReports.Label = Nothing
    Private Label2 As DataDynamics.ActiveReports.Label = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private txtpageNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtUser As DataDynamics.ActiveReports.TextBox = Nothing
    Private lbl3 As DataDynamics.ActiveReports.Label = Nothing
    Private txtPageTotal As DataDynamics.ActiveReports.TextBox = Nothing
    Private WithEvents lblSadereh As DataDynamics.ActiveReports.Label
    Private WithEvents lblVaredeh As DataDynamics.ActiveReports.Label
    Private WithEvents lblTedadAjza As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents lblDesc As DataDynamics.ActiveReports.Label
    Private WithEvents lblCode As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txtShomarehBarnameh As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents txtNameRanandeh As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents txtVazneBakool As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Logo As DataDynamics.ActiveReports.Picture
    Private WithEvents txtShomarehMashin As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private Label44 As DataDynamics.ActiveReports.Label = Nothing
    Public CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)  ''ghasemi 14030309
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptabSanad))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtSadereh = New DataDynamics.ActiveReports.TextBox()
        Me.txtVaredeh = New DataDynamics.ActiveReports.TextBox()
        Me.txtTedadAjza = New DataDynamics.ActiveReports.TextBox()
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl6 = New DataDynamics.ActiveReports.Label()
        Me.lblDate = New DataDynamics.ActiveReports.Label()
        Me.lbl7 = New DataDynamics.ActiveReports.Label()
        Me.lblTime = New DataDynamics.ActiveReports.Label()
        Me.lblCompany = New DataDynamics.ActiveReports.Label()
        Me.Logo = New DataDynamics.ActiveReports.Picture()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label43 = New DataDynamics.ActiveReports.Label()
        Me.txtpageNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtUser = New DataDynamics.ActiveReports.TextBox()
        Me.lbl3 = New DataDynamics.ActiveReports.Label()
        Me.txtPageTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label44 = New DataDynamics.ActiveReports.Label()
        Me.GrpHedSanadSN = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblMoaserDate = New DataDynamics.ActiveReports.Label()
        Me.txtMoaserDate = New DataDynamics.ActiveReports.TextBox()
        Me.lblSanadStatusDS = New DataDynamics.ActiveReports.Label()
        Me.txtSanadStatusDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtSanadNO = New DataDynamics.ActiveReports.TextBox()
        Me.lblSanadNO = New DataDynamics.ActiveReports.Label()
        Me.lblTarakoneshDs = New DataDynamics.ActiveReports.Label()
        Me.txtTarakoneshDs = New DataDynamics.ActiveReports.TextBox()
        Me.lblAnbarNo = New DataDynamics.ActiveReports.Label()
        Me.txtAnbarNo = New DataDynamics.ActiveReports.TextBox()
        Me.lblNoeAnbarNO = New DataDynamics.ActiveReports.Label()
        Me.txtNoeAnbarNO = New DataDynamics.ActiveReports.TextBox()
        Me.lblTafsiliDs = New DataDynamics.ActiveReports.Label()
        Me.txtTafsiliDs = New DataDynamics.ActiveReports.TextBox()
        Me.lblShomarehSefaresh = New DataDynamics.ActiveReports.Label()
        Me.txtShomarehSefaresh = New DataDynamics.ActiveReports.TextBox()
        Me.lblTozih = New DataDynamics.ActiveReports.Label()
        Me.txtTozih = New DataDynamics.ActiveReports.TextBox()
        Me.lblFactorNo = New DataDynamics.ActiveReports.Label()
        Me.txtFactorNo = New DataDynamics.ActiveReports.TextBox()
        Me.lblSadereh = New DataDynamics.ActiveReports.Label()
        Me.lblVaredeh = New DataDynamics.ActiveReports.Label()
        Me.lblTedadAjza = New DataDynamics.ActiveReports.Label()
        Me.Label45 = New DataDynamics.ActiveReports.Label()
        Me.lblDesc = New DataDynamics.ActiveReports.Label()
        Me.lblCode = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txtShomarehBarnameh = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.txtNameRanandeh = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.txtVazneBakool = New DataDynamics.ActiveReports.TextBox()
        Me.txtShomarehMashin = New DataDynamics.ActiveReports.TextBox()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.GrpFtSanadSN = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtSumSadereh = New DataDynamics.ActiveReports.TextBox()
        Me.txtSumVaredeh = New DataDynamics.ActiveReports.TextBox()
        Me.Label36 = New DataDynamics.ActiveReports.Label()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        CType(Me.txtSadereh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVaredeh, System.ComponentModel.ISupportInitialize).BeginInit() ''asli

        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMoaserDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoaserDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSanadStatusDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSanadStatusDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSanadNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSanadNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTarakoneshDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarakoneshDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAnbarNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnbarNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoeAnbarNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoeAnbarNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTafsiliDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTafsiliDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblShomarehSefaresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehSefaresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTozih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTozih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFactorNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactorNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSadereh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVaredeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehBarnameh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameRanandeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVazneBakool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehMashin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumSadereh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumVaredeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSadereh, Me.txtVaredeh, Me.txtTedadAjza, Me.txtShomarehRahgiri, Me.txtKalaDS, Me.txtKalaNo, Me.txtRadif})
        Me.Detail.Height = 0.3125!
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
        Me.txtSadereh.Height = 0.3125!
        Me.txtSadereh.Left = 0.1875!
        Me.txtSadereh.Name = "txtSadereh"
        ''Me.txtSadereh.OutputFormat = resources.GetString("txtSadereh.OutputFormat") 




        Me.txtSadereh.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtSadereh.Text = "txtSadereh"
        Me.txtSadereh.Top = 0!
        Me.txtSadereh.Width = 1.0!
        '
        'txtVaredeh
        '
        Me.txtVaredeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVaredeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVaredeh.Height = 0.3125!
        Me.txtVaredeh.Left = 1.1875!
        Me.txtVaredeh.Name = "txtVaredeh"

        ''Me.txtVaredeh.OutputFormat = resources.GetString("txtVaredeh.OutputFormat") 

        ''
        Me.txtVaredeh.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtVaredeh.Text = "txtVaredeh"
        Me.txtVaredeh.Top = 0!
        Me.txtVaredeh.Width = 1.0!


        '    ''test
        '    Me.txtSumSadereh.Style = "text-align: center; font-weight: bold; background-color: White; font-size: 12pt; " &
        '"vertical-align: middle; "
        '    Me.txtSumSadereh.SummaryGroup = "GrpHedSanadSN"
        '    Me.txtSumSadereh.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        '    Me.txtSumSadereh.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        '    Me.txtSumSadereh.Text = "txtSumSadereh"
        '    Me.txtSumSadereh.Top = 0!
        '    Me.txtSumSadereh.Width = 1.0!
        '    ''test



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
        Me.txtTedadAjza.Height = 0.3125!
        Me.txtTedadAjza.Left = 2.1875!
        Me.txtTedadAjza.Name = "txtTedadAjza"
        Me.txtTedadAjza.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtTedadAjza.Text = "txtTedadAjza"
        Me.txtTedadAjza.Top = 0!
        Me.txtTedadAjza.Width = 0.5!
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
        Me.txtShomarehRahgiri.Height = 0.3125!
        Me.txtShomarehRahgiri.Left = 2.6875!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtShomarehRahgiri.Text = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Top = 0!
        Me.txtShomarehRahgiri.Width = 0.875!
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
        Me.txtKalaDS.Left = 3.5!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtKalaDS.Text = "KalaDS"
        Me.txtKalaDS.Top = 0!
        Me.txtKalaDS.Width = 3.1875!
        '
        'txtKalaNo
        '
        Me.txtKalaNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo.CanGrow = False
        Me.txtKalaNo.Height = 0.3125!
        Me.txtKalaNo.Left = 6.6875!
        Me.txtKalaNo.Name = "txtKalaNo"
        Me.txtKalaNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Koodak; vertical-align: middle; "
        Me.txtKalaNo.Text = "KalaNo"
        Me.txtKalaNo.Top = 0!
        Me.txtKalaNo.Width = 1.0!
        '
        'txtRadif
        '
        Me.txtRadif.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRadif.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRadif.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRadif.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRadif.Border.RightColor = System.Drawing.Color.Black
        Me.txtRadif.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRadif.Border.TopColor = System.Drawing.Color.Black
        Me.txtRadif.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif.Height = 0.3149606!
        Me.txtRadif.Left = 7.6875!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 9pt; font-fa" &
    "mily: Koodak; vertical-align: middle; "
        Me.txtRadif.Text = "Radif"
        Me.txtRadif.Top = 0!
        Me.txtRadif.Width = 0.39375!
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
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl6, Me.lblDate, Me.lbl7, Me.lblTime, Me.lblCompany, Me.Logo})
        Me.PageHeader.Height = 0.9583333!
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
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 0.6875!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 12pt; font-f" &
    "amily: B Jadid; vertical-align: middle; "
        Me.lblTitle.Text = "چاپ اسناد"
        Me.lblTitle.Top = 0.4375!
        Me.lblTitle.Width = 6.4375!
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
        Me.lbl6.Left = 1.328653!
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl6.Text = " : تاريـخ گزارش"
        Me.lbl6.Top = 0.2149989!
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
        Me.lblDate.Left = 0.6397638!
        Me.lblDate.MultiLine = False
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblDate.Text = "lbl7"
        Me.lblDate.Top = 0.2149989!
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
        Me.lbl7.Height = 0.1972222!
        Me.lbl7.HyperLink = Nothing
        Me.lbl7.Left = 1.328653!
        Me.lbl7.MultiLine = False
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl7.Text = ": ساعت "
        Me.lbl7.Top = 0.4115267!
        Me.lbl7.Width = 1.082639!
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
        Me.lblTime.Left = 0.6397638!
        Me.lblTime.MultiLine = False
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblTime.Text = "lbl8"
        Me.lblTime.Top = 0.4115267!
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
        Me.lblCompany.Height = 0.3125!
        Me.lblCompany.HyperLink = Nothing
        Me.lblCompany.Left = 0.25!
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 12pt; font-f" &
    "amily: B Jadid; vertical-align: middle; "
        Me.lblCompany.Text = "شركت"
        Me.lblCompany.Top = 0.0625!
        Me.lblCompany.Width = 6.875!
        '
        'Logo
        '
        Me.Logo.Border.BottomColor = System.Drawing.Color.Black
        Me.Logo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Logo.Border.LeftColor = System.Drawing.Color.Black
        Me.Logo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Logo.Border.RightColor = System.Drawing.Color.Black
        Me.Logo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Logo.Border.TopColor = System.Drawing.Color.Black
        Me.Logo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Logo.Height = 0.75!
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.ImageData = CType(resources.GetObject("Logo.ImageData"), System.IO.Stream)
        Me.Logo.Left = 7.25!
        Me.Logo.LineWeight = 0!
        Me.Logo.Name = "Logo"
        Me.Logo.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Logo.Top = 0.1875!
        Me.Logo.Width = 0.8125!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label43, Me.txtpageNo, Me.txtUser, Me.lbl3, Me.txtPageTotal, Me.Label44})
        Me.PageFooter.Height = 0.2277778!
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
        Me.Label43.Left = 2.324653!
        Me.Label43.MultiLine = False
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; vertical-align: middle; "
        Me.Label43.Text = ":صفحه "
        Me.Label43.Top = 0.03125!
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
        Me.txtpageNo.Left = 1.734375!
        Me.txtpageNo.MultiLine = False
        Me.txtpageNo.Name = "txtpageNo"
        Me.txtpageNo.Style = "ddo-char-set: 178; text-align: left; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Tahoma; white-space: nowrap; vertical-align: middle; "
        Me.txtpageNo.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtpageNo.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtpageNo.Text = Nothing
        Me.txtpageNo.Top = 0.03125!
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
        Me.txtUser.Left = 3.202778!
        Me.txtUser.MultiLine = False
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; white-space: nowrap; vertical-align: middle; "
        Me.txtUser.Text = Nothing
        Me.txtUser.Top = 0.03125!
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
        Me.lbl3.Left = 6.875!
        Me.lbl3.MultiLine = False
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" &
    "t-family: Tahoma; vertical-align: middle; "
        Me.lbl3.Text = " :گزارش گيرنده"
        Me.lbl3.Top = 0.03125!
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
        Me.txtPageTotal.Left = 0.796875!
        Me.txtPageTotal.Name = "txtPageTotal"
        Me.txtPageTotal.Style = "ddo-char-set: 178; text-align: right; font-size: 8.25pt; vertical-align: middle; " &
    ""
        Me.txtPageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtPageTotal.Text = Nothing
        Me.txtPageTotal.Top = 0.03125!
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
        Me.Label44.Left = 1.546875!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "ddo-char-set: 178; text-align: center; font-size: 8.25pt; vertical-align: middle;" &
    " "
        Me.Label44.Text = "از"
        Me.Label44.Top = 0.03125!
        Me.Label44.Width = 0.1875!
        '
        'GrpHedSanadSN
        '
        Me.GrpHedSanadSN.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblMoaserDate, Me.txtMoaserDate, Me.lblSanadStatusDS, Me.txtSanadStatusDS, Me.txtSanadNO, Me.lblSanadNO, Me.lblTarakoneshDs, Me.txtTarakoneshDs, Me.lblAnbarNo, Me.txtAnbarNo, Me.lblNoeAnbarNO, Me.txtNoeAnbarNO, Me.lblTafsiliDs, Me.txtTafsiliDs, Me.lblShomarehSefaresh, Me.txtShomarehSefaresh, Me.lblTozih, Me.txtTozih, Me.lblFactorNo, Me.txtFactorNo, Me.lblSadereh, Me.lblVaredeh, Me.lblTedadAjza, Me.Label45, Me.lblDesc, Me.lblCode, Me.Label23, Me.Label3, Me.txtShomarehBarnameh, Me.Label4, Me.txtNameRanandeh, Me.Label5, Me.txtVazneBakool, Me.txtShomarehMashin, Me.Label6})
        Me.GrpHedSanadSN.Height = 2.302083!
        Me.GrpHedSanadSN.Name = "GrpHedSanadSN"
        Me.GrpHedSanadSN.NewPage = DataDynamics.ActiveReports.NewPage.Before
        '
        'lblMoaserDate
        '
        Me.lblMoaserDate.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMoaserDate.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMoaserDate.Border.RightColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMoaserDate.Border.TopColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMoaserDate.Height = 0.246063!
        Me.lblMoaserDate.HyperLink = Nothing
        Me.lblMoaserDate.Left = 4.2945!
        Me.lblMoaserDate.Name = "lblMoaserDate"
        Me.lblMoaserDate.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblMoaserDate.Text = "تاريخ"
        Me.lblMoaserDate.Top = 0.7538556!
        Me.lblMoaserDate.Width = 0.65904!
        '
        'txtMoaserDate
        '
        Me.txtMoaserDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.CanGrow = False
        Me.txtMoaserDate.Height = 0.246063!
        Me.txtMoaserDate.Left = 3.162611!
        Me.txtMoaserDate.Name = "txtMoaserDate"
        Me.txtMoaserDate.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtMoaserDate.Text = "txtMoaserDate"
        Me.txtMoaserDate.Top = 0.7538556!
        Me.txtMoaserDate.Width = 1.13189!
        '
        'lblSanadStatusDS
        '
        Me.lblSanadStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Border.TopColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Height = 0.2358924!
        Me.lblSanadStatusDS.HyperLink = Nothing
        Me.lblSanadStatusDS.Left = 1.875!
        Me.lblSanadStatusDS.Name = "lblSanadStatusDS"
        Me.lblSanadStatusDS.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblSanadStatusDS.Text = "وضعيت"
        Me.lblSanadStatusDS.Top = 0.75!
        Me.lblSanadStatusDS.Width = 0.7381903!
        '
        'txtSanadStatusDS
        '
        Me.txtSanadStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadStatusDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadStatusDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadStatusDS.CanGrow = False
        Me.txtSanadStatusDS.Height = 0.2358924!
        Me.txtSanadStatusDS.Left = 0.5!
        Me.txtSanadStatusDS.Name = "txtSanadStatusDS"
        Me.txtSanadStatusDS.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtSanadStatusDS.Text = "txtSanadStatusDS"
        Me.txtSanadStatusDS.Top = 0.75!
        Me.txtSanadStatusDS.Width = 1.13574!
        '
        'txtSanadNO
        '
        Me.txtSanadNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.CanGrow = False
        Me.txtSanadNO.Height = 0.2358924!
        Me.txtSanadNO.Left = 5.653169!
        Me.txtSanadNO.Name = "txtSanadNO"
        Me.txtSanadNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtSanadNO.Text = "txtSanadNO"
        Me.txtSanadNO.Top = 0.7538556!
        Me.txtSanadNO.Width = 1.427165!
        '
        'lblSanadNO
        '
        Me.lblSanadNO.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSanadNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadNO.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSanadNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadNO.Border.RightColor = System.Drawing.Color.Black
        Me.lblSanadNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadNO.Border.TopColor = System.Drawing.Color.Black
        Me.lblSanadNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadNO.Height = 0.2358924!
        Me.lblSanadNO.HyperLink = Nothing
        Me.lblSanadNO.Left = 7.080333!
        Me.lblSanadNO.Name = "lblSanadNO"
        Me.lblSanadNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblSanadNO.Text = "شماره سند"
        Me.lblSanadNO.Top = 0.7538556!
        Me.lblSanadNO.Width = 0.9022306!
        '
        'lblTarakoneshDs
        '
        Me.lblTarakoneshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Border.RightColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Border.TopColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Height = 0.2358924!
        Me.lblTarakoneshDs.HyperLink = Nothing
        Me.lblTarakoneshDs.Left = 7.080333!
        Me.lblTarakoneshDs.Name = "lblTarakoneshDs"
        Me.lblTarakoneshDs.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblTarakoneshDs.Text = "نوع سند"
        Me.lblTarakoneshDs.Top = 0.282071!
        Me.lblTarakoneshDs.Visible = False
        Me.lblTarakoneshDs.Width = 0.9022306!
        '
        'txtTarakoneshDs
        '
        Me.txtTarakoneshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTarakoneshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTarakoneshDs.Border.RightColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTarakoneshDs.Border.TopColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTarakoneshDs.CanGrow = False
        Me.txtTarakoneshDs.Height = 0.21!
        Me.txtTarakoneshDs.Left = 3.125!
        Me.txtTarakoneshDs.Name = "txtTarakoneshDs"
        Me.txtTarakoneshDs.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtTarakoneshDs.Text = "txtTarakoneshDs"
        Me.txtTarakoneshDs.Top = 0.3!
        Me.txtTarakoneshDs.Visible = False
        Me.txtTarakoneshDs.Width = 3.9375!
        '
        'lblAnbarNo
        '
        Me.lblAnbarNo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnbarNo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnbarNo.Border.RightColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnbarNo.Border.TopColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnbarNo.Height = 0.2358924!
        Me.lblAnbarNo.HyperLink = Nothing
        Me.lblAnbarNo.Left = 7.080333!
        Me.lblAnbarNo.Name = "lblAnbarNo"
        Me.lblAnbarNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblAnbarNo.Text = "انبار"
        Me.lblAnbarNo.Top = 0.04617855!
        Me.lblAnbarNo.Width = 0.9022306!
        '
        'txtAnbarNo
        '
        Me.txtAnbarNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.CanGrow = False
        Me.txtAnbarNo.Height = 0.24!
        Me.txtAnbarNo.Left = 3.125!
        Me.txtAnbarNo.Name = "txtAnbarNo"
        Me.txtAnbarNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtAnbarNo.Text = "txtAnbarNo"
        Me.txtAnbarNo.Top = 0.04!
        Me.txtAnbarNo.Width = 3.94!
        '
        'lblNoeAnbarNO
        '
        Me.lblNoeAnbarNO.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoeAnbarNO.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoeAnbarNO.Border.RightColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoeAnbarNO.Border.TopColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoeAnbarNO.Height = 0.2358924!
        Me.lblNoeAnbarNO.HyperLink = Nothing
        Me.lblNoeAnbarNO.Left = 2.0!
        Me.lblNoeAnbarNO.Name = "lblNoeAnbarNO"
        Me.lblNoeAnbarNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblNoeAnbarNO.Text = "نوع انبار"
        Me.lblNoeAnbarNO.Top = 0.0625!
        Me.lblNoeAnbarNO.Width = 0.6427994!
        '
        'txtNoeAnbarNO
        '
        Me.txtNoeAnbarNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.CanGrow = False
        Me.txtNoeAnbarNO.Height = 0.2358924!
        Me.txtNoeAnbarNO.Left = 0.5!
        Me.txtNoeAnbarNO.Name = "txtNoeAnbarNO"
        Me.txtNoeAnbarNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtNoeAnbarNO.Text = "txtNoeAnbarNO"
        Me.txtNoeAnbarNO.Top = 0.0625!
        Me.txtNoeAnbarNO.Width = 1.411538!
        '
        'lblTafsiliDs
        '
        Me.lblTafsiliDs.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTafsiliDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliDs.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTafsiliDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliDs.Border.RightColor = System.Drawing.Color.Black
        Me.lblTafsiliDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliDs.Border.TopColor = System.Drawing.Color.Black
        Me.lblTafsiliDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliDs.Height = 0.2358924!
        Me.lblTafsiliDs.HyperLink = Nothing
        Me.lblTafsiliDs.Left = 7.080333!
        Me.lblTafsiliDs.Name = "lblTafsiliDs"
        Me.lblTafsiliDs.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblTafsiliDs.Text = "طرف حساب"
        Me.lblTafsiliDs.Top = 0.5179631!
        Me.lblTafsiliDs.Width = 0.9022306!
        '
        'txtTafsiliDs
        '
        Me.txtTafsiliDs.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTafsiliDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTafsiliDs.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTafsiliDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTafsiliDs.Border.RightColor = System.Drawing.Color.Black
        Me.txtTafsiliDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTafsiliDs.Border.TopColor = System.Drawing.Color.Black
        Me.txtTafsiliDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTafsiliDs.CanGrow = False
        Me.txtTafsiliDs.Height = 0.25!
        Me.txtTafsiliDs.Left = 3.125!
        Me.txtTafsiliDs.Name = "txtTafsiliDs"
        Me.txtTafsiliDs.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtTafsiliDs.Text = "txtTafsiliDs"
        Me.txtTafsiliDs.Top = 0.5!
        Me.txtTafsiliDs.Width = 3.9375!
        '
        'lblShomarehSefaresh
        '
        Me.lblShomarehSefaresh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Border.RightColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Border.TopColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Height = 0.375!
        Me.lblShomarehSefaresh.HyperLink = Nothing
        Me.lblShomarehSefaresh.Left = 1.625!
        Me.lblShomarehSefaresh.Name = "lblShomarehSefaresh"
        Me.lblShomarehSefaresh.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblShomarehSefaresh.Text = "شماره ارجاع (رسید/حواله)"
        Me.lblShomarehSefaresh.Top = 0.375!
        Me.lblShomarehSefaresh.Width = 1.25!
        '
        'txtShomarehSefaresh
        '
        Me.txtShomarehSefaresh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehSefaresh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehSefaresh.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehSefaresh.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehSefaresh.Height = 0.375!
        Me.txtShomarehSefaresh.Left = 0.5!
        Me.txtShomarehSefaresh.Name = "txtShomarehSefaresh"
        Me.txtShomarehSefaresh.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtShomarehSefaresh.Text = "12"
        Me.txtShomarehSefaresh.Top = 0.375!
        Me.txtShomarehSefaresh.Width = 1.125!
        '
        'lblTozih
        '
        Me.lblTozih.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTozih.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTozih.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTozih.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTozih.Border.RightColor = System.Drawing.Color.Black
        Me.lblTozih.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTozih.Border.TopColor = System.Drawing.Color.Black
        Me.lblTozih.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTozih.Height = 0.2358924!
        Me.lblTozih.HyperLink = Nothing
        Me.lblTozih.Left = 7.080333!
        Me.lblTozih.Name = "lblTozih"
        Me.lblTozih.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblTozih.Text = "توضيحات"
        Me.lblTozih.Top = 1.0!
        Me.lblTozih.Width = 0.9022306!
        '
        'txtTozih
        '
        Me.txtTozih.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTozih.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTozih.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTozih.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTozih.Border.RightColor = System.Drawing.Color.Black
        Me.txtTozih.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTozih.Border.TopColor = System.Drawing.Color.Black
        Me.txtTozih.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTozih.CanGrow = False
        Me.txtTozih.Height = 0.2358924!
        Me.txtTozih.Left = 2.8125!
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtTozih.Text = "TextBox"
        Me.txtTozih.Top = 1.0!
        Me.txtTozih.Width = 4.222189!
        '
        'lblFactorNo
        '
        Me.lblFactorNo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFactorNo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFactorNo.Border.RightColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFactorNo.Border.TopColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFactorNo.Height = 0.2358924!
        Me.lblFactorNo.HyperLink = Nothing
        Me.lblFactorNo.Left = 1.875!
        Me.lblFactorNo.Name = "lblFactorNo"
        Me.lblFactorNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lblFactorNo.Text = "شماره فاکتور"
        Me.lblFactorNo.Top = 1.0!
        Me.lblFactorNo.Visible = False
        Me.lblFactorNo.Width = 0.7381903!
        '
        'txtFactorNo
        '
        Me.txtFactorNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFactorNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFactorNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFactorNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFactorNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtFactorNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFactorNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtFactorNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFactorNo.Height = 0.2358924!
        Me.txtFactorNo.Left = 0.5!
        Me.txtFactorNo.Name = "txtFactorNo"
        Me.txtFactorNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.txtFactorNo.Text = "txtFactorNo"
        Me.txtFactorNo.Top = 1.0!
        Me.txtFactorNo.Visible = False
        Me.txtFactorNo.Width = 1.13574!
        '
        'lblSadereh
        '
        Me.lblSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSadereh.Border.TopColor = System.Drawing.Color.Black
        Me.lblSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSadereh.Height = 0.51!
        Me.lblSadereh.HyperLink = Nothing
        Me.lblSadereh.Left = 0.1875!
        Me.lblSadereh.Name = "lblSadereh"
        Me.lblSadereh.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; background-color: White" &
    "; font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblSadereh.Text = "صادره"
        Me.lblSadereh.Top = 1.8125!
        Me.lblSadereh.Width = 1.0!
        '
        'lblVaredeh
        '
        Me.lblVaredeh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.lblVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVaredeh.Border.TopColor = System.Drawing.Color.Black
        Me.lblVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVaredeh.Height = 0.51!
        Me.lblVaredeh.HyperLink = Nothing
        Me.lblVaredeh.Left = 1.1875!
        Me.lblVaredeh.Name = "lblVaredeh"
        Me.lblVaredeh.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblVaredeh.Text = "وارده"
        Me.lblVaredeh.Top = 1.8125!
        Me.lblVaredeh.Width = 1.0!
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
        Me.lblTedadAjza.Height = 0.51!
        Me.lblTedadAjza.HyperLink = Nothing
        Me.lblTedadAjza.Left = 2.1875!
        Me.lblTedadAjza.Name = "lblTedadAjza"
        Me.lblTedadAjza.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblTedadAjza.Text = "تعداد در کارتن"
        Me.lblTedadAjza.Top = 1.8125!
        Me.lblTedadAjza.Width = 0.5!
        '
        'Label45
        '
        Me.Label45.Border.BottomColor = System.Drawing.Color.Black
        Me.Label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.LeftColor = System.Drawing.Color.Black
        Me.Label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.RightColor = System.Drawing.Color.Black
        Me.Label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.TopColor = System.Drawing.Color.Black
        Me.Label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Height = 0.511811!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 2.6875!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label45.Text = "شماره رهگيري"
        Me.Label45.Top = 1.8125!
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
        Me.lblDesc.Height = 0.51!
        Me.lblDesc.HyperLink = Nothing
        Me.lblDesc.Left = 3.5!
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblDesc.Text = "نام کالا"
        Me.lblDesc.Top = 1.8125!
        Me.lblDesc.Width = 3.1875!
        '
        'lblCode
        '
        Me.lblCode.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.RightColor = System.Drawing.Color.Black
        Me.lblCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCode.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Height = 0.51!
        Me.lblCode.HyperLink = Nothing
        Me.lblCode.Left = 6.6875!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblCode.Text = "کد کالا"
        Me.lblCode.Top = 1.8125!
        Me.lblCode.Width = 1.0!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Height = 0.511811!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 7.6875!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label23.Text = "رديف"
        Me.Label23.Top = 1.8125!
        Me.Label23.Width = 0.39375!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.2358924!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 7.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label3.Text = "شماره بارنامه"
        Me.Label3.Top = 1.25!
        Me.Label3.Width = 0.9022306!
        '
        'txtShomarehBarnameh
        '
        Me.txtShomarehBarnameh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehBarnameh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehBarnameh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehBarnameh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehBarnameh.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehBarnameh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehBarnameh.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehBarnameh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehBarnameh.CanGrow = False
        Me.txtShomarehBarnameh.Height = 0.2358924!
        Me.txtShomarehBarnameh.Left = 5.653169!
        Me.txtShomarehBarnameh.Name = "txtShomarehBarnameh"
        Me.txtShomarehBarnameh.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtShomarehBarnameh.Text = Nothing
        Me.txtShomarehBarnameh.Top = 1.25!
        Me.txtShomarehBarnameh.Width = 1.427165!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.2358924!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.6875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label4.Text = "نام راننده"
        Me.Label4.Top = 1.25!
        Me.Label4.Width = 0.9022306!
        '
        'txtNameRanandeh
        '
        Me.txtNameRanandeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNameRanandeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNameRanandeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNameRanandeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNameRanandeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtNameRanandeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNameRanandeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtNameRanandeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNameRanandeh.CanGrow = False
        Me.txtNameRanandeh.Height = 0.25!
        Me.txtNameRanandeh.Left = 2.8125!
        Me.txtNameRanandeh.Name = "txtNameRanandeh"
        Me.txtNameRanandeh.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" &
    "y: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtNameRanandeh.Text = Nothing
        Me.txtNameRanandeh.Top = 1.25!
        Me.txtNameRanandeh.Width = 1.875!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.2358924!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label5.Text = "وزن باسکول"
        Me.Label5.Top = 1.25!
        Me.Label5.Width = 0.7381903!
        '
        'txtVazneBakool
        '
        Me.txtVazneBakool.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVazneBakool.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVazneBakool.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVazneBakool.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVazneBakool.Border.RightColor = System.Drawing.Color.Black
        Me.txtVazneBakool.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVazneBakool.Border.TopColor = System.Drawing.Color.Black
        Me.txtVazneBakool.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVazneBakool.CanGrow = False
        Me.txtVazneBakool.Height = 0.2358924!
        Me.txtVazneBakool.Left = 0.5!
        Me.txtVazneBakool.Name = "txtVazneBakool"
        Me.txtVazneBakool.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtVazneBakool.Text = Nothing
        Me.txtVazneBakool.Top = 1.25!
        Me.txtVazneBakool.Width = 1.13574!
        '
        'txtShomarehMashin
        '
        Me.txtShomarehMashin.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehMashin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehMashin.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehMashin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehMashin.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehMashin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehMashin.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehMashin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehMashin.CanGrow = False
        Me.txtShomarehMashin.Height = 0.2358924!
        Me.txtShomarehMashin.Left = 5.625!
        Me.txtShomarehMashin.Name = "txtShomarehMashin"
        Me.txtShomarehMashin.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; white-space: inherit; vertical-align: middle; "
        Me.txtShomarehMashin.Text = Nothing
        Me.txtShomarehMashin.Top = 1.5!
        Me.txtShomarehMashin.Width = 1.427165!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.2358924!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 7.125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label6.Text = "شماره ماشین"
        Me.Label6.Top = 1.5!
        Me.Label6.Width = 0.9022306!
        '
        'GrpFtSanadSN
        '
        Me.GrpFtSanadSN.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSumSadereh, Me.txtSumVaredeh, Me.Label36, Me.Label, Me.Label1, Me.Label2})
        Me.GrpFtSanadSN.Height = 0.8125!
        Me.GrpFtSanadSN.Name = "GrpFtSanadSN"
        '
        'txtSumSadereh
        '
        Me.txtSumSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSumSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumSadereh.Border.TopColor = System.Drawing.Color.Black
        Me.txtSumSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumSadereh.CanGrow = False
        Me.txtSumSadereh.Height = 0.3125!
        Me.txtSumSadereh.Left = 0.1875!
        Me.txtSumSadereh.Name = "txtSumSadereh"
        '' Me.txtSumSadereh.OutputFormat = resources.GetString("txtSumSadereh.OutputFormat") --ghasemi14021213
        ''''ghasemi14021213


        Me.txtSumSadereh.Style = "text-align: center; font-weight: bold; background-color: White; font-size: 12pt; " &
    "vertical-align: middle; "
        Me.txtSumSadereh.SummaryGroup = "GrpHedSanadSN"
        Me.txtSumSadereh.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSumSadereh.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSumSadereh.Text = "txtSumSadereh"
        Me.txtSumSadereh.Top = 0!
        Me.txtSumSadereh.Width = 1.0!
        '
        'txtSumVaredeh
        '
        Me.txtSumVaredeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSumVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumVaredeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtSumVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumVaredeh.CanGrow = False
        Me.txtSumVaredeh.Height = 0.3125!
        Me.txtSumVaredeh.Left = 1.1875!
        Me.txtSumVaredeh.Name = "txtSumVaredeh"
        '' Me.txtSumVaredeh.OutputFormat = resources.GetString("txtSumVaredeh.OutputFormat") 


        Me.txtSumVaredeh.Style = "text-align: center; font-weight: bold; background-color: White; font-size: 12pt; " &
    "vertical-align: middle; "
        Me.txtSumVaredeh.SummaryGroup = "GrpHedSanadSN"
        Me.txtSumVaredeh.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSumVaredeh.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSumVaredeh.Text = "txtVaredeh"
        Me.txtSumVaredeh.Top = 0!
        Me.txtSumVaredeh.Width = 1.0!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.Black
        Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.LeftColor = System.Drawing.Color.Black
        Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.RightColor = System.Drawing.Color.Black
        Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.TopColor = System.Drawing.Color.Black
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Height = 0.31!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 2.1875!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label36.Text = " : جمع "
        Me.Label36.Top = 0!
        Me.Label36.Width = 0.9350396!
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
        Me.Label.Height = 0.2358924!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 6.625!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label.Text = "انباردار"
        Me.Label.Top = 0.515625!
        Me.Label.Width = 0.9022306!
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
        Me.Label1.Height = 0.2358924!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label1.Text = "رئيس حسابداري"
        Me.Label1.Top = 0.515625!
        Me.Label1.Width = 0.9022306!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.2358924!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.Label2.Text = "مديريت"
        Me.Label2.Top = 0.515625!
        Me.Label2.Width = 0.9022306!
        '
        'RptabSanad
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.15625!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GrpHedSanadSN)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GrpFtSanadSN)
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
        CType(Me.txtVaredeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMoaserDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoaserDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSanadStatusDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSanadStatusDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSanadNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSanadNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTarakoneshDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarakoneshDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAnbarNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnbarNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoeAnbarNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoeAnbarNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTafsiliDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTafsiliDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblShomarehSefaresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehSefaresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTozih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTozih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFactorNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactorNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSadereh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVaredeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehBarnameh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameRanandeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVazneBakool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehMashin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumSadereh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumVaredeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Sub DefField()


        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي
        GrpHedSanadSN.DataField = "SanadSN"

        txtTarakoneshDs.DataField = "TarakoneshDs"
        txtSanadNO.DataField = "SanadNO"
        txtMoaserDate.DataField = "MoaserDate"
        txtSanadStatusDS.DataField = "SanadStatusDS"
        txtAnbarNo.DataField = "AnbarDS"
        txtNoeAnbarNO.DataField = "NoeAnbarDS"
        txtTafsiliDs.DataField = "TafsiliDs"
        txtShomarehSefaresh.DataField = "ShomarehSefaresh"
        txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        txtTozih.DataField = "Tozih"

        txtKalaNo.DataField = "KalaNo"
        txtKalaDS.DataField = "KalaDS"

        txtFactorNo.DataField = "FactorNo" '850301
        txtVazneBakool.DataField = "VazneBaskool"
        txtNameRanandeh.DataField = "NameRanandeh"
        txtShomarehBarnameh.DataField = "ShomarehBarnameh"
        txtShomarehMashin.DataField = "ShomarehMashin"

        If gVahedeTejariSN = 22865.935 Then
            lblShomarehSefaresh.DataField = "Tittle"
            Logo.Visible = True
        Else
            lblShomarehSefaresh.DataField = ""
            Logo.Visible = False
        End If



        If gRptabSanadNoeAnbar = 2 Or gRptabSanadNoeAnbar = 5 Or gRptabSanadNoeAnbar = 10 Then
            lblTedadAjza.Text = "تعداد در کارتن"
            lblVaredeh.Text = "کارتن"
            lblSadereh.Text = "عدد"
            txtTedadAjza.DataField = "TedadAjza"
            txtVaredeh.DataField = "Box"
            txtSadereh.DataField = "Can"
            txtSumVaredeh.DataField = "Box"
            txtSumSadereh.DataField = "Can"
        Else
            lblTedadAjza.Text = "واحد سنجش"
            lblVaredeh.Text = "وارده"
            lblSadereh.Text = "صادره"
            txtTedadAjza.DataField = "VahedeSanjeshDs"
            txtVaredeh.DataField = "MeghdareVaredeh"
            txtSadereh.DataField = "MeghdareSadereh"
            txtSumVaredeh.DataField = "MeghdareVaredeh"
            txtSumSadereh.DataField = "MeghdareSadereh"
        End If

        Dim NamayeshAshar As Boolean = If(CApp.GetAppConfig("gNamayeshAsharInPrintAsnad") Is System.DBNull.Value, False, True) ''ghasemi 14030309

        ''ghasemi14021213
        If Not NamayeshAshar Then
            Me.txtSadereh.OutputFormat = "#.###"
            Me.txtSumVaredeh.OutputFormat = "#.###"
            Me.txtVaredeh.OutputFormat = "#.#"
            Me.txtSumSadereh.OutputFormat = "#.###"
        End If
        ''ghasemi14021213

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtRadif.Text = Val(txtRadif.Text) + 1
        lblCompany.Text = Me.Fields("VahedeTejariDs").Value
        lblTitle.Text = Me.Fields("TarakoneshDs").Value
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        ' تهيه تاريخ از سرور
        lblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                 cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash)
        lblTime.Text = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server( _
                                                                                 cn, Functions.FTDBCommonFunctions.enmTimeFormat.HHmm)
    End Sub

    Private Sub GrpHedSanadSN_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrpHedSanadSN.Format
        txtRadif.Text = 0
    End Sub
    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtUser.Text = gSM.UserName
    End Sub

    Private Sub GrpHedSanadSN_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrpHedSanadSN.BeforePrint
        If txtFactorNo.Value <> "" Then
            txtFactorNo.Visible = True
            lblFactorNo.Visible = True
        Else
            txtFactorNo.Visible = False
            lblFactorNo.Visible = False
        End If

    End Sub
End Class
