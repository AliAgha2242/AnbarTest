Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptKardexA
    Inherits ActiveReport3

    Dim mandeh As Decimal
    Dim vNew_Mandeh As Boolean

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        vNew_Mandeh = True
        Me.Document.Name = "گزارش کاردکس"
        Me.PageSettings.Orientation = PageOrientation.Portrait
        'gh    Me.PageSettings.PaperKind = Printing.PaperKind.Standard10x11
        'Me.PageSettings.PaperKind = Printing.PaperKind.Custom
        'Me.PageSettings.PaperWidth = 10
        'Me.PageSettings.PaperHeight = 11
        lblCompany.Text = gSM.CompanyName
        txtRadif.Text = 0
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GrpHedAnbarNO_NoeAnbarNO As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents GrpHedKalaSN As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GrpFtKalaSN As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents GrpFtAnbarNO_NoeAnbarNO As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private lblCompany As DataDynamics.ActiveReports.Label = Nothing
    Private lblTitle As DataDynamics.ActiveReports.Label = Nothing
    Private lbl6 As DataDynamics.ActiveReports.Label = Nothing
    Private lblDate As DataDynamics.ActiveReports.Label = Nothing
    Private lbl7 As DataDynamics.ActiveReports.Label = Nothing
    Private lblTime As DataDynamics.ActiveReports.Label = Nothing
    Private txtNoeAnbarNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblNoeAnbarNO As DataDynamics.ActiveReports.Label = Nothing
    Private txtAnbarNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblAnbarNo As DataDynamics.ActiveReports.Label = Nothing
    Private lblMojoodiBefor As DataDynamics.ActiveReports.Label = Nothing
    Private txtMojoodiBefor As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblVahedeSanjeshDs As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDs As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblTedadAjza As DataDynamics.ActiveReports.Label = Nothing
    Private txtTedadAjza As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblCode As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblDesc As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblMandeh As DataDynamics.ActiveReports.Label = Nothing
    Private lblTafsiliNO As DataDynamics.ActiveReports.Label = Nothing
    Private lblMeghdareSadereh As DataDynamics.ActiveReports.Label = Nothing
    Private lblMeghdareVaredeh As DataDynamics.ActiveReports.Label = Nothing
    Private lblSanadStatusDS As DataDynamics.ActiveReports.Label = Nothing
    Private lblTarakoneshDs As DataDynamics.ActiveReports.Label = Nothing
    Private lblSanadNO As DataDynamics.ActiveReports.Label = Nothing
    Private lblShomarehSefaresh As DataDynamics.ActiveReports.Label = Nothing
    Private lblMoaserDate As DataDynamics.ActiveReports.Label = Nothing
    Private lblShomarehRahgiri As DataDynamics.ActiveReports.Label = Nothing
    Private lblRadif As DataDynamics.ActiveReports.Label = Nothing
    Private txtMandeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTafsiliNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtMeghdareSadereh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtMeghdareVaredeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSanadStatusDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTarakoneshDs As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSanadNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtShomarehSefaresh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtMoaserDate As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSumMandeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtNone As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSumMeghdareSadereh As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSumMeghdareVaredeh As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label36 As DataDynamics.ActiveReports.Label = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private txtpageNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtUser As DataDynamics.ActiveReports.TextBox = Nothing
    Private lbl3 As DataDynamics.ActiveReports.Label = Nothing
    Private txtPageTotal As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label44 As DataDynamics.ActiveReports.Label = Nothing

    Private Sub InitializeComponent()
        Dim _
            resources As System.ComponentModel.ComponentResourceManager = _
                New System.ComponentModel.ComponentResourceManager (GetType (RptKardexA))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.GrpHedAnbarNO_NoeAnbarNO = New DataDynamics.ActiveReports.GroupHeader
        Me.GrpFtAnbarNO_NoeAnbarNO = New DataDynamics.ActiveReports.GroupFooter
        Me.GrpHedKalaSN = New DataDynamics.ActiveReports.GroupHeader
        Me.GrpFtKalaSN = New DataDynamics.ActiveReports.GroupFooter
        Me.lblCompany = New DataDynamics.ActiveReports.Label
        Me.lblTitle = New DataDynamics.ActiveReports.Label
        Me.lbl6 = New DataDynamics.ActiveReports.Label
        Me.lblDate = New DataDynamics.ActiveReports.Label
        Me.lbl7 = New DataDynamics.ActiveReports.Label
        Me.lblTime = New DataDynamics.ActiveReports.Label
        Me.txtNoeAnbarNO = New DataDynamics.ActiveReports.TextBox
        Me.lblNoeAnbarNO = New DataDynamics.ActiveReports.Label
        Me.txtAnbarNo = New DataDynamics.ActiveReports.TextBox
        Me.lblAnbarNo = New DataDynamics.ActiveReports.Label
        Me.lblMojoodiBefor = New DataDynamics.ActiveReports.Label
        Me.txtMojoodiBefor = New DataDynamics.ActiveReports.TextBox
        Me.lblVahedeSanjeshDs = New DataDynamics.ActiveReports.Label
        Me.txtVahedeSanjeshDs = New DataDynamics.ActiveReports.TextBox
        Me.lblTedadAjza = New DataDynamics.ActiveReports.Label
        Me.txtTedadAjza = New DataDynamics.ActiveReports.TextBox
        Me.lblCode = New DataDynamics.ActiveReports.Label
        Me.txtKalaNO = New DataDynamics.ActiveReports.TextBox
        Me.lblDesc = New DataDynamics.ActiveReports.Label
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox
        Me.lblMandeh = New DataDynamics.ActiveReports.Label
        Me.lblTafsiliNO = New DataDynamics.ActiveReports.Label
        Me.lblMeghdareSadereh = New DataDynamics.ActiveReports.Label
        Me.lblMeghdareVaredeh = New DataDynamics.ActiveReports.Label
        Me.lblSanadStatusDS = New DataDynamics.ActiveReports.Label
        Me.lblTarakoneshDs = New DataDynamics.ActiveReports.Label
        Me.lblSanadNO = New DataDynamics.ActiveReports.Label
        Me.lblShomarehSefaresh = New DataDynamics.ActiveReports.Label
        Me.lblMoaserDate = New DataDynamics.ActiveReports.Label
        Me.lblShomarehRahgiri = New DataDynamics.ActiveReports.Label
        Me.lblRadif = New DataDynamics.ActiveReports.Label
        Me.txtMandeh = New DataDynamics.ActiveReports.TextBox
        Me.txtTafsiliNO = New DataDynamics.ActiveReports.TextBox
        Me.txtMeghdareSadereh = New DataDynamics.ActiveReports.TextBox
        Me.txtMeghdareVaredeh = New DataDynamics.ActiveReports.TextBox
        Me.txtSanadStatusDS = New DataDynamics.ActiveReports.TextBox
        Me.txtTarakoneshDs = New DataDynamics.ActiveReports.TextBox
        Me.txtSanadNO = New DataDynamics.ActiveReports.TextBox
        Me.txtShomarehSefaresh = New DataDynamics.ActiveReports.TextBox
        Me.txtMoaserDate = New DataDynamics.ActiveReports.TextBox
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox
        Me.txtSumMandeh = New DataDynamics.ActiveReports.TextBox
        Me.txtNone = New DataDynamics.ActiveReports.TextBox
        Me.txtSumMeghdareSadereh = New DataDynamics.ActiveReports.TextBox
        Me.txtSumMeghdareVaredeh = New DataDynamics.ActiveReports.TextBox
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.txtpageNo = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.lbl3 = New DataDynamics.ActiveReports.Label
        Me.txtPageTotal = New DataDynamics.ActiveReports.TextBox
        Me.Label44 = New DataDynamics.ActiveReports.Label
        CType (Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lbl6, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lbl7, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtNoeAnbarNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblNoeAnbarNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtAnbarNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblAnbarNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMojoodiBefor, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMojoodiBefor, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKalaNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMandeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblTafsiliNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMeghdareSadereh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMeghdareVaredeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblSanadStatusDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblTarakoneshDs, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblSanadNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblShomarehSefaresh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMoaserDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblRadif, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMandeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtTafsiliNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMeghdareSadereh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMeghdareVaredeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSanadStatusDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtTarakoneshDs, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSanadNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtShomarehSefaresh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMoaserDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSumMandeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtNone, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSumMeghdareSadereh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSumMeghdareVaredeh, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtpageNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lbl3, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtPageTotal, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange ( _
                                     New DataDynamics.ActiveReports.ARControl() _
                                        {Me.txtMandeh, Me.txtTafsiliNO, Me.txtMeghdareSadereh, Me.txtMeghdareVaredeh, _
                                         Me.txtSanadStatusDS, Me.txtTarakoneshDs, Me.txtSanadNO, Me.txtShomarehSefaresh, _
                                         Me.txtMoaserDate, Me.txtShomarehRahgiri, Me.txtRadif})
        Me.Detail.Height = 0.4847222!
        Me.Detail.Name = "Detail"
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
        Me.PageHeader.CanGrow = false
        Me.PageHeader.Controls.AddRange ( _
                                         New DataDynamics.ActiveReports.ARControl() _
                                            {Me.lblCompany, Me.lblTitle, Me.lbl6, Me.lblDate, Me.lbl7, Me.lblTime})
        Me.PageHeader.Height = 1.083333!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange ( _
                                         New DataDynamics.ActiveReports.ARControl() _
                                            {Me.Label43, Me.txtpageNo, Me.txtUser, Me.lbl3, Me.txtPageTotal, Me.Label44})
        Me.PageFooter.Height = 0.2277778!
        Me.PageFooter.Name = "PageFooter"
        '
        'GrpHedAnbarNO_NoeAnbarNO
        '
        Me.GrpHedAnbarNO_NoeAnbarNO.CanGrow = false
        Me.GrpHedAnbarNO_NoeAnbarNO.Controls.AddRange ( _
                                                       New DataDynamics.ActiveReports.ARControl() _
                                                          {Me.txtNoeAnbarNO, Me.lblNoeAnbarNO, Me.txtAnbarNo, _
                                                           Me.lblAnbarNo})
        Me.GrpHedAnbarNO_NoeAnbarNO.Height = 0.2708333!
        Me.GrpHedAnbarNO_NoeAnbarNO.Name = "GrpHedAnbarNO_NoeAnbarNO"
        Me.GrpHedAnbarNO_NoeAnbarNO.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.All
        '
        'GrpFtAnbarNO_NoeAnbarNO
        '
        Me.GrpFtAnbarNO_NoeAnbarNO.Height = 0!
        Me.GrpFtAnbarNO_NoeAnbarNO.Name = "GrpFtAnbarNO_NoeAnbarNO"
        '
        'GrpHedKalaSN
        '
        Me.GrpHedKalaSN.CanGrow = false
        Me.GrpHedKalaSN.Controls.AddRange ( _
                                           New DataDynamics.ActiveReports.ARControl() _
                                              {Me.lblMojoodiBefor, Me.txtMojoodiBefor, Me.lblVahedeSanjeshDs, _
                                               Me.txtVahedeSanjeshDs, Me.lblTedadAjza, Me.txtTedadAjza, Me.lblCode, _
                                               Me.txtKalaNO, Me.lblDesc, Me.txtKalaDS, Me.lblMandeh, Me.lblTafsiliNO, _
                                               Me.lblMeghdareSadereh, Me.lblMeghdareVaredeh, Me.lblSanadStatusDS, _
                                               Me.lblTarakoneshDs, Me.lblSanadNO, Me.lblShomarehSefaresh, _
                                               Me.lblMoaserDate, Me.lblShomarehRahgiri, Me.lblRadif})
        Me.GrpHedKalaSN.Height = 1.134722!
        Me.GrpHedKalaSN.Name = "GrpHedKalaSN"
        Me.GrpHedKalaSN.NewPage = DataDynamics.ActiveReports.NewPage.Before
        Me.GrpHedKalaSN.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.All
        '
        'GrpFtKalaSN
        '
        Me.GrpFtKalaSN.Controls.AddRange ( _
                                          New DataDynamics.ActiveReports.ARControl() _
                                             {Me.txtSumMandeh, Me.txtNone, Me.txtSumMeghdareSadereh, _
                                              Me.txtSumMeghdareVaredeh, Me.Label36})
        Me.GrpFtKalaSN.Height = 0.2909722!
        Me.GrpFtKalaSN.Name = "GrpFtKalaSN"
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
        Me.lblCompany.Height = 0.3152778!
        Me.lblCompany.HyperLink = Nothing
        Me.lblCompany.Left = 0.3237917!
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 12pt; font-f" & _
                              "amily: B Jadid; vertical-align: middle; "
        Me.lblCompany.Text = "شركت"
        Me.lblCompany.Top = 0.1163878!
        Me.lblCompany.Width = 7.716375!
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
        Me.lblTitle.Height = 0.275!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 0.3237917!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 12pt; font-f" & _
                            "amily: B Jadid; vertical-align: middle; "
        Me.lblTitle.Text = "گزارش کاردکس"
        Me.lblTitle.Top = 0.4316657!
        Me.lblTitle.Width = 7.716375!
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
        Me.lbl6.Left = 0.9536528!
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" & _
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
        Me.lblDate.Left = 0.2647637!
        Me.lblDate.MultiLine = false
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" & _
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
        Me.lbl7.Left = 0.9536528!
        Me.lbl7.MultiLine = false
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" & _
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
        Me.lblTime.Left = 0.2647637!
        Me.lblTime.MultiLine = false
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" & _
                           "ily: Tahoma; vertical-align: middle; "
        Me.lblTime.Text = "lbl8"
        Me.lblTime.Top = 0.4115267!
        Me.lblTime.Width = 0.6888889!
        '
        'txtNoeAnbarNO
        '
        Me.txtNoeAnbarNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNoeAnbarNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoeAnbarNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtNoeAnbarNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNoeAnbarNO.CanGrow = false
        Me.txtNoeAnbarNO.Height = 0.246063!
        Me.txtNoeAnbarNO.Left = 2.034142!
        Me.txtNoeAnbarNO.Name = "txtNoeAnbarNO"
        Me.txtNoeAnbarNO.Style = "text-align: center; background-color: White; vertical-align: middle; "
        Me.txtNoeAnbarNO.Text = "txtNoeAnbarNO"
        Me.txtNoeAnbarNO.Top = 0.02263847!
        Me.txtNoeAnbarNO.Width = 1.13189!
        '
        'lblNoeAnbarNO
        '
        Me.lblNoeAnbarNO.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoeAnbarNO.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNoeAnbarNO.Border.RightColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNoeAnbarNO.Border.TopColor = System.Drawing.Color.Black
        Me.lblNoeAnbarNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNoeAnbarNO.Height = 0.246063!
        Me.lblNoeAnbarNO.HyperLink = Nothing
        Me.lblNoeAnbarNO.Left = 3.166031!
        Me.lblNoeAnbarNO.Name = "lblNoeAnbarNO"
        Me.lblNoeAnbarNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                                 "; font-size: 7pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblNoeAnbarNO.Text = "نوع انبار"
        Me.lblNoeAnbarNO.Top = 0.02263847!
        Me.lblNoeAnbarNO.Width = 0.6427994!
        '
        'txtAnbarNo
        '
        Me.txtAnbarNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAnbarNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnbarNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtAnbarNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAnbarNo.CanGrow = false
        Me.txtAnbarNo.Height = 0.246063!
        Me.txtAnbarNo.Left = 3.80883!
        Me.txtAnbarNo.Name = "txtAnbarNo"
        Me.txtAnbarNo.Style = "text-align: center; background-color: White; white-space: inherit; vertical-align" & _
                              ": middle; "
        Me.txtAnbarNo.Text = "txtAnbarNo"
        Me.txtAnbarNo.Top = 0.02263847!
        Me.txtAnbarNo.Width = 3.901202!
        '
        'lblAnbarNo
        '
        Me.lblAnbarNo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnbarNo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblAnbarNo.Border.RightColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblAnbarNo.Border.TopColor = System.Drawing.Color.Black
        Me.lblAnbarNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblAnbarNo.Height = 0.246063!
        Me.lblAnbarNo.HyperLink = Nothing
        Me.lblAnbarNo.Left = 7.710035!
        Me.lblAnbarNo.Name = "lblAnbarNo"
        Me.lblAnbarNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                              "; font-size: 7pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblAnbarNo.Text = "انبار"
        Me.lblAnbarNo.Top = 0.02263847!
        Me.lblAnbarNo.Width = 0.495935!
        '
        'lblMojoodiBefor
        '
        Me.lblMojoodiBefor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMojoodiBefor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMojoodiBefor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMojoodiBefor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMojoodiBefor.Border.RightColor = System.Drawing.Color.Black
        Me.lblMojoodiBefor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMojoodiBefor.Border.TopColor = System.Drawing.Color.Black
        Me.lblMojoodiBefor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMojoodiBefor.Height = 0.3444882!
        Me.lblMojoodiBefor.HyperLink = Nothing
        Me.lblMojoodiBefor.Left = 1.049869!
        Me.lblMojoodiBefor.Name = "lblMojoodiBefor"
        Me.lblMojoodiBefor.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                                   "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblMojoodiBefor.Text = "قبل دوره"
        Me.lblMojoodiBefor.Top = 0.005454369!
        Me.lblMojoodiBefor.Width = 0.6413233!
        '
        'txtMojoodiBefor
        '
        Me.txtMojoodiBefor.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMojoodiBefor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMojoodiBefor.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMojoodiBefor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMojoodiBefor.Border.RightColor = System.Drawing.Color.Black
        Me.txtMojoodiBefor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMojoodiBefor.Border.TopColor = System.Drawing.Color.Black
        Me.txtMojoodiBefor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMojoodiBefor.Height = 0.3444882!
        Me.txtMojoodiBefor.Left = 0.2132547!
        Me.txtMojoodiBefor.Name = "txtMojoodiBefor"
        Me.txtMojoodiBefor.Style = "text-align: right; background-color: White; vertical-align: middle; "
        Me.txtMojoodiBefor.Text = "txtMojoodiBefor"
        Me.txtMojoodiBefor.Top = 0.005454369!
        Me.txtMojoodiBefor.Width = 0.8366139!
        '
        'lblVahedeSanjeshDs
        '
        Me.lblVahedeSanjeshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVahedeSanjeshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVahedeSanjeshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVahedeSanjeshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVahedeSanjeshDs.Border.RightColor = System.Drawing.Color.Black
        Me.lblVahedeSanjeshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblVahedeSanjeshDs.Border.TopColor = System.Drawing.Color.Black
        Me.lblVahedeSanjeshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeSanjeshDs.Height = 0.2951389!
        Me.lblVahedeSanjeshDs.HyperLink = Nothing
        Me.lblVahedeSanjeshDs.Left = 7.267063!
        Me.lblVahedeSanjeshDs.Name = "lblVahedeSanjeshDs"
        Me.lblVahedeSanjeshDs.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblVahedeSanjeshDs.Text = "واحد سنجش"
        Me.lblVahedeSanjeshDs.Top = 0.3499426!
        Me.lblVahedeSanjeshDs.Width = 0.9389048!
        '
        'txtVahedeSanjeshDs
        '
        Me.txtVahedeSanjeshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtVahedeSanjeshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtVahedeSanjeshDs.Border.RightColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.Border.TopColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.Height = 0.3444882!
        Me.txtVahedeSanjeshDs.Left = 6.232817!
        Me.txtVahedeSanjeshDs.Name = "txtVahedeSanjeshDs"
        Me.txtVahedeSanjeshDs.Style = "text-align: center; background-color: White; vertical-align: middle; "
        Me.txtVahedeSanjeshDs.Text = "txtVahedeSanjeshDs"
        Me.txtVahedeSanjeshDs.Top = 0.3005933!
        Me.txtVahedeSanjeshDs.Width = 1.034248!
        '
        'lblTedadAjza
        '
        Me.lblTedadAjza.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTedadAjza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTedadAjza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Border.RightColor = System.Drawing.Color.Black
        Me.lblTedadAjza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTedadAjza.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTedadAjza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTedadAjza.Height = 0.3444882!
        Me.lblTedadAjza.HyperLink = Nothing
        Me.lblTedadAjza.Left = 5.23294!
        Me.lblTedadAjza.Name = "lblTedadAjza"
        Me.lblTedadAjza.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                                "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblTedadAjza.Text = "تعداد در کاتن"
        Me.lblTedadAjza.Top = 0.3005933!
        Me.lblTedadAjza.Width = 0.9842521!
        '
        'txtTedadAjza
        '
        Me.txtTedadAjza.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadAjza.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadAjza.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadAjza.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.Height = 0.3444882!
        Me.txtTedadAjza.Left = 4.593175!
        Me.txtTedadAjza.Name = "txtTedadAjza"
        Me.txtTedadAjza.Style = "text-align: center; background-color: White; vertical-align: middle; "
        Me.txtTedadAjza.Text = "txtTedadAjza"
        Me.txtTedadAjza.Top = 0.3005933!
        Me.txtTedadAjza.Width = 0.6397638!
        '
        'lblCode
        '
        Me.lblCode.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.RightColor = System.Drawing.Color.Black
        Me.lblCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblCode.Height = 0.3444882!
        Me.lblCode.HyperLink = Nothing
        Me.lblCode.Left = 7.267063!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                           "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblCode.Text = "کد کالا"
        Me.lblCode.Top = 0.005454369!
        Me.lblCode.Width = 0.9389048!
        '
        'txtKalaNO
        '
        Me.txtKalaNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNO.Height = 0.3444882!
        Me.txtKalaNO.Left = 6.217192!
        Me.txtKalaNO.Name = "txtKalaNO"
        Me.txtKalaNO.Style = "text-align: center; background-color: White; vertical-align: middle; "
        Me.txtKalaNO.Text = "txtKalaNO"
        Me.txtKalaNO.Top = 0.005454369!
        Me.txtKalaNO.Width = 1.034248!
        '
        'lblDesc
        '
        Me.lblDesc.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Border.RightColor = System.Drawing.Color.Black
        Me.lblDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesc.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblDesc.Height = 0.3444882!
        Me.lblDesc.HyperLink = Nothing
        Me.lblDesc.Left = 5.54462!
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                           "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblDesc.Text = "نام کالا"
        Me.lblDesc.Top = 0.005454369!
        Me.lblDesc.Width = 0.6725712!
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
        Me.txtKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.CanGrow = false
        Me.txtKalaDS.Height = 0.3444882!
        Me.txtKalaDS.Left = 1.706817!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "text-align: right; background-color: White; vertical-align: top; "
        Me.txtKalaDS.Text = "txtKalaDS"
        Me.txtKalaDS.Top = 0.005454369!
        Me.txtKalaDS.Width = 3.822178!
        '
        'lblMandeh
        '
        Me.lblMandeh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMandeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMandeh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMandeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMandeh.Border.RightColor = System.Drawing.Color.Black
        Me.lblMandeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMandeh.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblMandeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMandeh.Height = 0.4826389!
        Me.lblMandeh.HyperLink = Nothing
        Me.lblMandeh.Left = 0.2132547!
        Me.lblMandeh.Name = "lblMandeh"
        Me.lblMandeh.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                             "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblMandeh.Text = "مانده"
        Me.lblMandeh.Top = 0.6467764!
        Me.lblMandeh.Width = 0.8202097!
        '
        'lblTafsiliNO
        '
        Me.lblTafsiliNO.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTafsiliNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliNO.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTafsiliNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTafsiliNO.Border.RightColor = System.Drawing.Color.Black
        Me.lblTafsiliNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTafsiliNO.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTafsiliNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTafsiliNO.Height = 0.4826389!
        Me.lblTafsiliNO.HyperLink = Nothing
        Me.lblTafsiliNO.Left = 1.049869!
        Me.lblTafsiliNO.Name = "lblTafsiliNO"
        Me.lblTafsiliNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                                "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblTafsiliNO.Text = "طرف حساب"
        Me.lblTafsiliNO.Top = 0.6467764!
        Me.lblTafsiliNO.Width = 1.295931!
        '
        'lblMeghdareSadereh
        '
        Me.lblMeghdareSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMeghdareSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMeghdareSadereh.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblMeghdareSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMeghdareSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.lblMeghdareSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMeghdareSadereh.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblMeghdareSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMeghdareSadereh.Height = 0.4826389!
        Me.lblMeghdareSadereh.HyperLink = Nothing
        Me.lblMeghdareSadereh.Left = 2.350312!
        Me.lblMeghdareSadereh.Name = "lblMeghdareSadereh"
        Me.lblMeghdareSadereh.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblMeghdareSadereh.Text = "صادره"
        Me.lblMeghdareSadereh.Top = 0.6491139!
        Me.lblMeghdareSadereh.Width = 0.8202097!
        '
        'lblMeghdareVaredeh
        '
        Me.lblMeghdareVaredeh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMeghdareVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMeghdareVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMeghdareVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMeghdareVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.lblMeghdareVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMeghdareVaredeh.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblMeghdareVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMeghdareVaredeh.Height = 0.4826389!
        Me.lblMeghdareVaredeh.HyperLink = Nothing
        Me.lblMeghdareVaredeh.Left = 3.170521!
        Me.lblMeghdareVaredeh.Name = "lblMeghdareVaredeh"
        Me.lblMeghdareVaredeh.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblMeghdareVaredeh.Text = "وارده"
        Me.lblMeghdareVaredeh.Top = 0.6491139!
        Me.lblMeghdareVaredeh.Width = 0.8202097!
        '
        'lblSanadStatusDS
        '
        Me.lblSanadStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSanadStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSanadStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.lblSanadStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadStatusDS.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSanadStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSanadStatusDS.Height = 0.4826389!
        Me.lblSanadStatusDS.HyperLink = Nothing
        Me.lblSanadStatusDS.Left = 3.990732!
        Me.lblSanadStatusDS.Name = "lblSanadStatusDS"
        Me.lblSanadStatusDS.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblSanadStatusDS.Text = "وضعيت"
        Me.lblSanadStatusDS.Top = 0.6491139!
        Me.lblSanadStatusDS.Width = 0.4868765!
        '
        'lblTarakoneshDs
        '
        Me.lblTarakoneshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTarakoneshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTarakoneshDs.Border.RightColor = System.Drawing.Color.Black
        Me.lblTarakoneshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTarakoneshDs.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblTarakoneshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTarakoneshDs.Height = 0.4826389!
        Me.lblTarakoneshDs.HyperLink = Nothing
        Me.lblTarakoneshDs.Left = 4.477608!
        Me.lblTarakoneshDs.Name = "lblTarakoneshDs"
        Me.lblTarakoneshDs.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; background-color: #E0E0" & _
                                   "E0; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblTarakoneshDs.Text = "عنوان سند"
        Me.lblTarakoneshDs.Top = 0.6491139!
        Me.lblTarakoneshDs.Width = 1.650591!
        '
        'lblSanadNO
        '
        Me.lblSanadNO.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSanadNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSanadNO.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSanadNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSanadNO.Border.RightColor = System.Drawing.Color.Black
        Me.lblSanadNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSanadNO.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSanadNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSanadNO.Height = 0.2326389!
        Me.lblSanadNO.HyperLink = Nothing
        Me.lblSanadNO.Left = 6.135171!
        Me.lblSanadNO.Name = "lblSanadNO"
        Me.lblSanadNO.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                              "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblSanadNO.Text = "شماره سند"
        Me.lblSanadNO.Top = 0.6491139!
        Me.lblSanadNO.Width = 0.9842521!
        '
        'lblShomarehSefaresh
        '
        Me.lblShomarehSefaresh.Border.BottomColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblShomarehSefaresh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblShomarehSefaresh.Border.RightColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Border.TopColor = System.Drawing.Color.Black
        Me.lblShomarehSefaresh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehSefaresh.Height = 0.2326389!
        Me.lblShomarehSefaresh.HyperLink = Nothing
        Me.lblShomarehSefaresh.Left = 6.135171!
        Me.lblShomarehSefaresh.Name = "lblShomarehSefaresh"
        Me.lblShomarehSefaresh.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblShomarehSefaresh.Text = "شماره ارجاع"
        Me.lblShomarehSefaresh.Top = 0.8991139!
        Me.lblShomarehSefaresh.Width = 0.9842521!
        '
        'lblMoaserDate
        '
        Me.lblMoaserDate.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMoaserDate.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMoaserDate.Border.RightColor = System.Drawing.Color.Black
        Me.lblMoaserDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMoaserDate.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblMoaserDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblMoaserDate.Height = 0.2326389!
        Me.lblMoaserDate.HyperLink = Nothing
        Me.lblMoaserDate.Left = 7.119423!
        Me.lblMoaserDate.Name = "lblMoaserDate"
        Me.lblMoaserDate.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                                 "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblMoaserDate.Text = "تاريخ"
        Me.lblMoaserDate.Top = 0.6491139!
        Me.lblMoaserDate.Width = 0.6960299!
        '
        'lblShomarehRahgiri
        '
        Me.lblShomarehRahgiri.Border.BottomColor = System.Drawing.Color.Black
        Me.lblShomarehRahgiri.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehRahgiri.Border.LeftColor = System.Drawing.Color.Black
        Me.lblShomarehRahgiri.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblShomarehRahgiri.Border.RightColor = System.Drawing.Color.Black
        Me.lblShomarehRahgiri.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehRahgiri.Border.TopColor = System.Drawing.Color.Black
        Me.lblShomarehRahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblShomarehRahgiri.Height = 0.2326389!
        Me.lblShomarehRahgiri.HyperLink = Nothing
        Me.lblShomarehRahgiri.Left = 7.119423!
        Me.lblShomarehRahgiri.Name = "lblShomarehRahgiri"
        Me.lblShomarehRahgiri.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblShomarehRahgiri.Text = "رهگيري"
        Me.lblShomarehRahgiri.Top = 0.8991139!
        Me.lblShomarehRahgiri.Width = 0.6960299!
        '
        'lblRadif
        '
        Me.lblRadif.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRadif.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRadif.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRadif.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRadif.Border.RightColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblRadif.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRadif.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblRadif.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRadif.Height = 0.4826389!
        Me.lblRadif.HyperLink = Nothing
        Me.lblRadif.Left = 7.815452!
        Me.lblRadif.Name = "lblRadif"
        Me.lblRadif.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                            "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.lblRadif.Text = "رديف"
        Me.lblRadif.Top = 0.6491139!
        Me.lblRadif.Width = 0.39375!
        '
        'txtMandeh
        '
        Me.txtMandeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMandeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMandeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMandeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMandeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtMandeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMandeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtMandeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMandeh.CanGrow = false
        Me.txtMandeh.Height = 0.4826389!
        Me.txtMandeh.Left = 0.2132547!
        Me.txtMandeh.Name = "txtMandeh"
        Me.txtMandeh.OutputFormat = resources.GetString ("txtMandeh.OutputFormat")
        Me.txtMandeh.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 8.25pt; font-" & _
                             "family: Koodak; vertical-align: middle; "
        Me.txtMandeh.Text = "txtMandeh"
        Me.txtMandeh.Top = 0!
        Me.txtMandeh.Width = 0.8202097!
        '
        'txtTafsiliNO
        '
        Me.txtTafsiliNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTafsiliNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTafsiliNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTafsiliNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTafsiliNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtTafsiliNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTafsiliNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtTafsiliNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTafsiliNO.CanGrow = false
        Me.txtTafsiliNO.Height = 0.4826389!
        Me.txtTafsiliNO.Left = 1.049869!
        Me.txtTafsiliNO.Name = "txtTafsiliNO"
        Me.txtTafsiliNO.OutputFormat = resources.GetString ("txtTafsiliNO.OutputFormat")
        Me.txtTafsiliNO.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" & _
                                "y: Koodak; vertical-align: top; "
        Me.txtTafsiliNO.Text = "txtTafsiliNO"
        Me.txtTafsiliNO.Top = 0.002337694!
        Me.txtTafsiliNO.Width = 1.295931!
        '
        'txtMeghdareSadereh
        '
        Me.txtMeghdareSadereh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMeghdareSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMeghdareSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.txtMeghdareSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMeghdareSadereh.Border.TopColor = System.Drawing.Color.Black
        Me.txtMeghdareSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareSadereh.CanGrow = false
        Me.txtMeghdareSadereh.Height = 0.4826389!
        Me.txtMeghdareSadereh.Left = 2.350312!
        Me.txtMeghdareSadereh.Name = "txtMeghdareSadereh"
        Me.txtMeghdareSadereh.OutputFormat = resources.GetString ("txtMeghdareSadereh.OutputFormat")
        Me.txtMeghdareSadereh.Style = _
            "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 8.25pt; font-" & _
            "family: Koodak; vertical-align: middle; "
        Me.txtMeghdareSadereh.Text = "txtMeghdareSadereh"
        Me.txtMeghdareSadereh.Top = 0.002337575!
        Me.txtMeghdareSadereh.Width = 0.8202097!
        '
        'txtMeghdareVaredeh
        '
        Me.txtMeghdareVaredeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMeghdareVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMeghdareVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtMeghdareVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMeghdareVaredeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtMeghdareVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMeghdareVaredeh.CanGrow = false
        Me.txtMeghdareVaredeh.Height = 0.4826389!
        Me.txtMeghdareVaredeh.Left = 3.149606!
        Me.txtMeghdareVaredeh.Name = "txtMeghdareVaredeh"
        Me.txtMeghdareVaredeh.OutputFormat = resources.GetString ("txtMeghdareVaredeh.OutputFormat")
        Me.txtMeghdareVaredeh.Style = _
            "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 8.25pt; font-" & _
            "family: Koodak; vertical-align: middle; "
        Me.txtMeghdareVaredeh.Text = "txtMeghdareVaredeh"
        Me.txtMeghdareVaredeh.Top = 0!
        Me.txtMeghdareVaredeh.Width = 0.8202097!
        '
        'txtSanadStatusDS
        '
        Me.txtSanadStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSanadStatusDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSanadStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadStatusDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtSanadStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSanadStatusDS.CanGrow = false
        Me.txtSanadStatusDS.Height = 0.4826389!
        Me.txtSanadStatusDS.Left = 3.990732!
        Me.txtSanadStatusDS.Name = "txtSanadStatusDS"
        Me.txtSanadStatusDS.OutputFormat = resources.GetString ("txtSanadStatusDS.OutputFormat")
        Me.txtSanadStatusDS.Style = _
            "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" & _
            "y: Koodak; vertical-align: middle; "
        Me.txtSanadStatusDS.Text = "txtSanadStatusDS"
        Me.txtSanadStatusDS.Top = 0.002337575!
        Me.txtSanadStatusDS.Width = 0.4868765!
        '
        'txtTarakoneshDs
        '
        Me.txtTarakoneshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTarakoneshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTarakoneshDs.Border.RightColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTarakoneshDs.Border.TopColor = System.Drawing.Color.Black
        Me.txtTarakoneshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTarakoneshDs.CanGrow = false
        Me.txtTarakoneshDs.Height = 0.4826389!
        Me.txtTarakoneshDs.Left = 4.477608!
        Me.txtTarakoneshDs.Name = "txtTarakoneshDs"
        Me.txtTarakoneshDs.OutputFormat = resources.GetString ("txtTarakoneshDs.OutputFormat")
        Me.txtTarakoneshDs.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" & _
                                   "y: Koodak; vertical-align: top; "
        Me.txtTarakoneshDs.Text = "txtTarakoneshDs"
        Me.txtTarakoneshDs.Top = 0.002337635!
        Me.txtTarakoneshDs.Width = 1.650591!
        '
        'txtSanadNO
        '
        Me.txtSanadNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSanadNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSanadNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtSanadNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSanadNO.CanGrow = false
        Me.txtSanadNO.Height = 0.2326389!
        Me.txtSanadNO.Left = 6.135171!
        Me.txtSanadNO.Name = "txtSanadNO"
        Me.txtSanadNO.OutputFormat = resources.GetString ("txtSanadNO.OutputFormat")
        Me.txtSanadNO.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 8.25pt; font-" & _
                              "family: Koodak; vertical-align: middle; "
        Me.txtSanadNO.Text = "txtSanadNO"
        Me.txtSanadNO.Top = 0.002337635!
        Me.txtSanadNO.Width = 0.9842521!
        '
        'txtShomarehSefaresh
        '
        Me.txtShomarehSefaresh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehSefaresh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehSefaresh.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehSefaresh.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehSefaresh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehSefaresh.CanGrow = false
        Me.txtShomarehSefaresh.Height = 0.2326389!
        Me.txtShomarehSefaresh.Left = 6.135171!
        Me.txtShomarehSefaresh.Name = "txtShomarehSefaresh"
        Me.txtShomarehSefaresh.OutputFormat = resources.GetString ("txtShomarehSefaresh.OutputFormat")
        Me.txtShomarehSefaresh.Style = _
            "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 8.25pt; font-" & _
            "family: Koodak; vertical-align: middle; "
        Me.txtShomarehSefaresh.Text = "txtBox_inGabli"
        Me.txtShomarehSefaresh.Top = 0.2523376!
        Me.txtShomarehSefaresh.Width = 0.9842521!
        '
        'txtMoaserDate
        '
        Me.txtMoaserDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMoaserDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMoaserDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtMoaserDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtMoaserDate.CanGrow = false
        Me.txtMoaserDate.Height = 0.2326389!
        Me.txtMoaserDate.Left = 7.119423!
        Me.txtMoaserDate.Name = "txtMoaserDate"
        Me.txtMoaserDate.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" & _
                                 "ly: Koodak; vertical-align: middle; "
        Me.txtMoaserDate.Text = "txtMoaserDate"
        Me.txtMoaserDate.Top = 0.002337619!
        Me.txtMoaserDate.Width = 0.6960299!
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
        Me.txtShomarehRahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Height = 0.2326389!
        Me.txtShomarehRahgiri.Left = 7.119423!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = ""
        Me.txtShomarehRahgiri.Text = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Top = 0.2523376!
        Me.txtShomarehRahgiri.Width = 0.6960299!
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
        Me.txtRadif.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRadif.CanGrow = false
        Me.txtRadif.Height = 0.4826389!
        Me.txtRadif.Left = 7.815452!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 9pt; font-fa" & _
                            "mily: Koodak; vertical-align: middle; "
        Me.txtRadif.Text = "Radif"
        Me.txtRadif.Top = 0.002337619!
        Me.txtRadif.Width = 0.39375!
        '
        'txtSumMandeh
        '
        Me.txtSumMandeh.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSumMandeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMandeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumMandeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMandeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumMandeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumMandeh.Border.TopColor = System.Drawing.Color.Black
        Me.txtSumMandeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMandeh.CanGrow = false
        Me.txtSumMandeh.Height = 0.2916667!
        Me.txtSumMandeh.Left = 0.2132547!
        Me.txtSumMandeh.Name = "txtSumMandeh"
        Me.txtSumMandeh.OutputFormat = resources.GetString ("txtSumMandeh.OutputFormat")
        Me.txtSumMandeh.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; background-color: White;" & _
                                " font-size: 8.25pt; font-family: Koodak; vertical-align: middle; "
        Me.txtSumMandeh.Top = 0.003116801!
        Me.txtSumMandeh.Width = 1.25771!
        '
        'txtNone
        '
        Me.txtNone.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNone.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNone.Border.RightColor = System.Drawing.Color.Black
        Me.txtNone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNone.Border.TopColor = System.Drawing.Color.Black
        Me.txtNone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNone.CanGrow = false
        Me.txtNone.Height = 0.2916667!
        Me.txtNone.Left = 1.470965!
        Me.txtNone.Name = "txtNone"
        Me.txtNone.OutputFormat = resources.GetString ("txtNone.OutputFormat")
        Me.txtNone.Style = "text-align: right; background-color: White; vertical-align: middle; "
        Me.txtNone.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtNone.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtNone.Top = 0.003116801!
        Me.txtNone.Width = 0.9616139!
        '
        'txtSumMeghdareSadereh
        '
        Me.txtSumMeghdareSadereh.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.txtSumMeghdareSadereh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareSadereh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumMeghdareSadereh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareSadereh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumMeghdareSadereh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumMeghdareSadereh.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.txtSumMeghdareSadereh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareSadereh.CanGrow = false
        Me.txtSumMeghdareSadereh.Height = 0.2916667!
        Me.txtSumMeghdareSadereh.Left = 2.350312!
        Me.txtSumMeghdareSadereh.Name = "txtSumMeghdareSadereh"
        Me.txtSumMeghdareSadereh.OutputFormat = resources.GetString ("txtSumMeghdareSadereh.OutputFormat")
        Me.txtSumMeghdareSadereh.Style = _
            "ddo-char-set: 178; text-align: right; font-weight: bold; background-color: White;" & _
            " font-size: 8.25pt; font-family: Koodak; vertical-align: middle; "
        Me.txtSumMeghdareSadereh.SummaryGroup = "GrpHedKalaSN"
        Me.txtSumMeghdareSadereh.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSumMeghdareSadereh.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSumMeghdareSadereh.Text = "txtSumCan_in"
        Me.txtSumMeghdareSadereh.Top = 0!
        Me.txtSumMeghdareSadereh.Width = 0.8202097!
        '
        'txtSumMeghdareVaredeh
        '
        Me.txtSumMeghdareVaredeh.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.txtSumMeghdareVaredeh.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareVaredeh.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumMeghdareVaredeh.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareVaredeh.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumMeghdareVaredeh.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSumMeghdareVaredeh.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.txtSumMeghdareVaredeh.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumMeghdareVaredeh.CanGrow = false
        Me.txtSumMeghdareVaredeh.Height = 0.2916667!
        Me.txtSumMeghdareVaredeh.Left = 3.170521!
        Me.txtSumMeghdareVaredeh.Name = "txtSumMeghdareVaredeh"
        Me.txtSumMeghdareVaredeh.OutputFormat = resources.GetString ("txtSumMeghdareVaredeh.OutputFormat")
        Me.txtSumMeghdareVaredeh.Style = _
            "ddo-char-set: 178; text-align: right; font-weight: bold; background-color: White;" & _
            " font-size: 8.25pt; font-family: Koodak; vertical-align: middle; "
        Me.txtSumMeghdareVaredeh.SummaryGroup = "GrpHedKalaSN"
        Me.txtSumMeghdareVaredeh.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSumMeghdareVaredeh.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSumMeghdareVaredeh.Text = "txtSumBox_in"
        Me.txtSumMeghdareVaredeh.Top = 0!
        Me.txtSumMeghdareVaredeh.Width = 0.8202097!
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
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Height = 0.2951389!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 4.002625!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: #E0E0E0" & _
                           "; font-size: 11.25pt; font-family: B Koodak; vertical-align: middle; "
        Me.Label36.Text = "مجموع"
        Me.Label36.Top = 0!
        Me.Label36.Width = 4.206577!
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
        Me.Label43.Left = 1.965278!
        Me.Label43.MultiLine = false
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" & _
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
        Me.txtpageNo.CanGrow = false
        Me.txtpageNo.Height = 0.1965278!
        Me.txtpageNo.Left = 1.375!
        Me.txtpageNo.MultiLine = false
        Me.txtpageNo.Name = "txtpageNo"
        Me.txtpageNo.Style = "ddo-char-set: 178; text-align: left; font-weight: normal; font-size: 8.25pt; font" & _
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
        Me.txtUser.CanGrow = false
        Me.txtUser.Height = 0.1965278!
        Me.txtUser.Left = 3.202778!
        Me.txtUser.MultiLine = false
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" & _
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
        Me.lbl3.MultiLine = false
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" & _
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
        Me.txtPageTotal.Left = 0.4375!
        Me.txtPageTotal.Name = "txtPageTotal"
        Me.txtPageTotal.Style = "ddo-char-set: 178; text-align: right; font-size: 8.25pt; vertical-align: middle; " & _
                                ""
        Me.txtPageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
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
        Me.Label44.Left = 1.1875!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "ddo-char-set: 178; text-align: center; font-size: 8.25pt; vertical-align: middle;" & _
                           " "
        Me.Label44.Text = "از"
        Me.Label44.Top = 0.03125!
        Me.Label44.Width = 0.1875!
        '
        'ActiveReport31
        '
        Me.MasterReport = false
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.375!
        Me.Sections.Add (Me.ReportHeader)
        Me.Sections.Add (Me.PageHeader)
        Me.Sections.Add (Me.GrpHedAnbarNO_NoeAnbarNO)
        Me.Sections.Add (Me.GrpHedKalaSN)
        Me.Sections.Add (Me.Detail)
        Me.Sections.Add (Me.GrpFtKalaSN)
        Me.Sections.Add (Me.GrpFtAnbarNO_NoeAnbarNO)
        Me.Sections.Add (Me.PageFooter)
        Me.Sections.Add (Me.ReportFooter)
        Me.StyleSheet.Add (New DDCssLib.StyleSheetRule (resources.GetString ("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add ( _
                           New DDCssLib.StyleSheetRule ( _
                                                        "font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                                                        "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", _
                                                        "Heading1", "Normal"))
        Me.StyleSheet.Add ( _
                           New DDCssLib.StyleSheetRule ( _
                                                        "font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                                                        "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", _
                                                        "Heading2", "Normal"))
        Me.StyleSheet.Add ( _
                           New DDCssLib.StyleSheetRule ( _
                                                        "font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                                                        "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", _
                                                        "Heading3", "Normal"))
        CType (Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lbl6, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lbl7, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtNoeAnbarNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblNoeAnbarNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtAnbarNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblAnbarNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMojoodiBefor, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMojoodiBefor, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKalaNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMandeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblTafsiliNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMeghdareSadereh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMeghdareVaredeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblSanadStatusDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblTarakoneshDs, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblSanadNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblShomarehSefaresh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMoaserDate, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblRadif, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMandeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtTafsiliNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMeghdareSadereh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMeghdareVaredeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSanadStatusDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtTarakoneshDs, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSanadNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtShomarehSefaresh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMoaserDate, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSumMandeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtNone, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSumMeghdareSadereh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSumMeghdareVaredeh, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtpageNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtPageTotal, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي
        GrpHedAnbarNO_NoeAnbarNO.DataField = "AnbarNONoeAnbarNO"
        GrpHedKalaSN.DataField = "KalaSN"

        txtAnbarNo.DataField = "AnbarNo"
        txtNoeAnbarNO.DataField = "NoeAnbarNO"

        txtKalaNO.DataField = "KalaNO"
        txtKalaDS.DataField = "KalaDS"
        txtVahedeSanjeshDs.DataField = "VahedeSanjeshDs"
        txtTedadAjza.DataField = "TedadAjza"
        txtMojoodiBefor.DataField = "MojoodiBefor"

        txtMoaserDate.DataField = "MoaserDate"
        txtSanadNO.DataField = "SanadNO"
        txtShomarehSefaresh.DataField = "ShomarehSefaresh"
        txtTarakoneshDs.DataField = "TarakoneshDs"
        txtSanadStatusDS.DataField = "SanadStatusDS"
        txtMeghdareVaredeh.DataField = "MeghdareVaredeh"
        txtMeghdareSadereh.DataField = "MeghdareSadereh"
        txtTafsiliNO.DataField = "TafsiliNO"
        txtShomarehRahgiri.DataField = "ShomarehRahgiri"

        txtSumMeghdareVaredeh.DataField = "MeghdareVaredeh"
        txtSumMeghdareSadereh.DataField = "MeghdareSadereh"

        If (gNoeAnbarSN = 2 Or gNoeAnbarSN = 5 Or gNoeAnbarSN = 10) Then
            With txtMeghdareVaredeh
                .OutputFormat = "#,##0"
            End With
            With txtMeghdareSadereh
                .OutputFormat = "#,##0"
            End With
            With txtMandeh
                .OutputFormat = "#,##0"
            End With
            With txtSumMeghdareVaredeh
                .OutputFormat = "#,##0"
            End With
            With txtSumMeghdareSadereh
                .OutputFormat = "#,##0"
            End With
            With txtSumMandeh
                .OutputFormat = "#,##0"
            End With
            With txtMojoodiBefor
                .OutputFormat = "#,##0"
            End With
        Else
            With txtMeghdareVaredeh
                .OutputFormat = "#,##0.000"
            End With
            With txtMeghdareSadereh
                .OutputFormat = "#,##0.000"
            End With
            With txtMandeh
                .OutputFormat = "#,##0.000"
            End With
            With txtSumMeghdareVaredeh
                .OutputFormat = "#,##0.000"
            End With
            With txtSumMeghdareSadereh
                .OutputFormat = "#,##0.000"
            End With
            With txtSumMandeh
                .OutputFormat = "#,##0.000"
            End With
            With txtMojoodiBefor
                .OutputFormat = "#,##0.000"
            End With
        End If
    End Sub

    Private Sub Detail_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtRadif.Text = Val (txtRadif.Text) + 1
    End Sub

    Private Sub PageHeader_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        ' تهيه تاريخ از سرور
        lblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                   cn, _
                                                                                   Functions.FTDBCommonFunctions. _
                                                                                      enmDateFormat.FullYearWithSlash)
        lblTime.Text = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server ( _
                                                                            cn, _
                                                                            Functions.FTDBCommonFunctions.enmTimeFormat. _
                                                                               HHmm)
    End Sub

    Private Sub GrpHedKalaSN_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles GrpHedKalaSN.Format
        txtRadif.Text = 0
        If vNew_Mandeh = True Then
            mandeh = Val (Me.txtMojoodiBefor.Value)
            vNew_Mandeh = False
        End If
    End Sub

    Private Sub GrpFtKalaSN_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles GrpFtKalaSN.Format
        vNew_Mandeh = True
    End Sub

    Private Sub Detail_BeforePrint (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
        mandeh = mandeh + Val (txtMeghdareVaredeh.Value) - Val (txtMeghdareSadereh.Value)
        txtMandeh.Text = mandeh.ToString
        If Val (txtMandeh.Text) < 0 Then
            txtMandeh.ForeColor = System.Drawing.Color.Magenta
            txtTafsiliNO.ForeColor = System.Drawing.Color.Magenta
            txtMeghdareSadereh.ForeColor = System.Drawing.Color.Magenta
            txtMeghdareVaredeh.ForeColor = System.Drawing.Color.Magenta
            txtSanadStatusDS.ForeColor = System.Drawing.Color.Magenta
            txtTarakoneshDs.ForeColor = System.Drawing.Color.Magenta
            txtSanadNO.ForeColor = System.Drawing.Color.Magenta
            txtShomarehSefaresh.ForeColor = System.Drawing.Color.Magenta
            txtMoaserDate.ForeColor = System.Drawing.Color.Magenta
            txtRadif.ForeColor = System.Drawing.Color.Magenta
        Else
            txtMandeh.ForeColor = System.Drawing.Color.Black
            txtTafsiliNO.ForeColor = System.Drawing.Color.Black
            txtMeghdareSadereh.ForeColor = System.Drawing.Color.Black
            txtMeghdareVaredeh.ForeColor = System.Drawing.Color.Black
            txtSanadStatusDS.ForeColor = System.Drawing.Color.Black
            txtTarakoneshDs.ForeColor = System.Drawing.Color.Black
            txtSanadNO.ForeColor = System.Drawing.Color.Black
            txtShomarehSefaresh.ForeColor = System.Drawing.Color.Black
            txtMoaserDate.ForeColor = System.Drawing.Color.Black
            txtRadif.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub GrpFtKalaSN_BeforePrint (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles GrpFtKalaSN.BeforePrint
        txtSumMandeh.Text = mandeh
    End Sub


    Private Sub PageFooter_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtUser.Text = gSM.UserName
    End Sub
End Class
