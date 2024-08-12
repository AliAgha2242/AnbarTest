Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptResideMamoorPakhsh
    Inherits ActiveReport3

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "برگ رسيد مامور پخش"
        lblCompany.Text = gSM.CompanyName
        txtRadif.Text = 0
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GrpHedHavaleMamoorPakhshSN As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GrpFtHedHavaleMamoorPakhshSN As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private lblCompany As DataDynamics.ActiveReports.Label = Nothing
    Private lblTitle As DataDynamics.ActiveReports.Label = Nothing
    Private lbl6 As DataDynamics.ActiveReports.Label = Nothing
    Private lblDate As DataDynamics.ActiveReports.Label = Nothing
    Private lbl7 As DataDynamics.ActiveReports.Label = Nothing
    Private lblTime As DataDynamics.ActiveReports.Label = Nothing
    Private lblHavaleMamoorPakhshDateErsal As DataDynamics.ActiveReports.Label = Nothing
    Private txtHavaleMamoorPakhshDateErsal As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblMamoorPakhshDS As DataDynamics.ActiveReports.Label = Nothing
    Private txtMamoorPakhshDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private lblHavalePakhshStatusDS As DataDynamics.ActiveReports.Label = Nothing
    Private txtHavalePakhshStatusDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label23 As DataDynamics.ActiveReports.Label = Nothing
    Private lblKarton As DataDynamics.ActiveReports.Label = Nothing
    Private lblKolFee As DataDynamics.ActiveReports.Label = Nothing
    Private lblFullName As DataDynamics.ActiveReports.Label = Nothing
    Private lblSodoorDate As DataDynamics.ActiveReports.Label = Nothing
    Private lblFactorNo As DataDynamics.ActiveReports.Label = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtFactorNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtSodoorDate As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtFullName As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKolFee As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKarton As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label36 As DataDynamics.ActiveReports.Label = Nothing
    Private txtSumKolFee As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private txtpageNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtUser As DataDynamics.ActiveReports.TextBox = Nothing
    Private lbl3 As DataDynamics.ActiveReports.Label = Nothing
    Private txtPageTotal As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label44 As DataDynamics.ActiveReports.Label = Nothing

    Private Sub InitializeComponent()
        Dim _
            resources As System.ComponentModel.ComponentResourceManager = _
                New System.ComponentModel.ComponentResourceManager (GetType (RptResideMamoorPakhsh))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.GrpHedHavaleMamoorPakhshSN = New DataDynamics.ActiveReports.GroupHeader
        Me.GrpFtHedHavaleMamoorPakhshSN = New DataDynamics.ActiveReports.GroupFooter
        Me.lblCompany = New DataDynamics.ActiveReports.Label
        Me.lblTitle = New DataDynamics.ActiveReports.Label
        Me.lbl6 = New DataDynamics.ActiveReports.Label
        Me.lblDate = New DataDynamics.ActiveReports.Label
        Me.lbl7 = New DataDynamics.ActiveReports.Label
        Me.lblTime = New DataDynamics.ActiveReports.Label
        Me.lblHavaleMamoorPakhshDateErsal = New DataDynamics.ActiveReports.Label
        Me.txtHavaleMamoorPakhshDateErsal = New DataDynamics.ActiveReports.TextBox
        Me.lblMamoorPakhshDS = New DataDynamics.ActiveReports.Label
        Me.txtMamoorPakhshDS = New DataDynamics.ActiveReports.TextBox
        Me.lblHavalePakhshStatusDS = New DataDynamics.ActiveReports.Label
        Me.txtHavalePakhshStatusDS = New DataDynamics.ActiveReports.TextBox
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.lblKarton = New DataDynamics.ActiveReports.Label
        Me.lblKolFee = New DataDynamics.ActiveReports.Label
        Me.lblFullName = New DataDynamics.ActiveReports.Label
        Me.lblSodoorDate = New DataDynamics.ActiveReports.Label
        Me.lblFactorNo = New DataDynamics.ActiveReports.Label
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox
        Me.txtFactorNo = New DataDynamics.ActiveReports.TextBox
        Me.txtSodoorDate = New DataDynamics.ActiveReports.TextBox
        Me.txtFullName = New DataDynamics.ActiveReports.TextBox
        Me.txtKolFee = New DataDynamics.ActiveReports.TextBox
        Me.txtKarton = New DataDynamics.ActiveReports.TextBox
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.txtSumKolFee = New DataDynamics.ActiveReports.TextBox
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
        CType (Me.lblHavaleMamoorPakhshDateErsal, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtHavaleMamoorPakhshDateErsal, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblMamoorPakhshDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtMamoorPakhshDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblHavalePakhshStatusDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtHavalePakhshStatusDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblKarton, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblKolFee, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblFullName, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblSodoorDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblFactorNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtFactorNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSodoorDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtFullName, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKolFee, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKarton, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSumKolFee, System.ComponentModel.ISupportInitialize).BeginInit
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
                                        {Me.txtRadif, Me.txtFactorNo, Me.txtSodoorDate, Me.txtFullName, Me.txtKolFee, _
                                         Me.txtKarton})
        Me.Detail.Height = 0.3131945!
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
        Me.PageHeader.Controls.AddRange ( _
                                         New DataDynamics.ActiveReports.ARControl() _
                                            {Me.lblCompany, Me.lblTitle, Me.lbl6, Me.lblDate, Me.lbl7, Me.lblTime})
        Me.PageHeader.Height = 0.8402778!
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
        'GrpHedHavaleMamoorPakhshSN
        '
        Me.GrpHedHavaleMamoorPakhshSN.Controls.AddRange ( _
                                                         New DataDynamics.ActiveReports.ARControl() _
                                                            {Me.lblHavaleMamoorPakhshDateErsal, _
                                                             Me.txtHavaleMamoorPakhshDateErsal, Me.lblMamoorPakhshDS, _
                                                             Me.txtMamoorPakhshDS, Me.lblHavalePakhshStatusDS, _
                                                             Me.txtHavalePakhshStatusDS, Me.Label23, Me.lblKarton, _
                                                             Me.lblKolFee, Me.lblFullName, Me.lblSodoorDate, _
                                                             Me.lblFactorNo})
        Me.GrpHedHavaleMamoorPakhshSN.Height = 0.7263889!
        Me.GrpHedHavaleMamoorPakhshSN.Name = "GrpHedHavaleMamoorPakhshSN"
        Me.GrpHedHavaleMamoorPakhshSN.NewPage = DataDynamics.ActiveReports.NewPage.Before
        Me.GrpHedHavaleMamoorPakhshSN.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.All
        '
        'GrpFtHedHavaleMamoorPakhshSN
        '
        Me.GrpFtHedHavaleMamoorPakhshSN.Controls.AddRange ( _
                                                           New DataDynamics.ActiveReports.ARControl() _
                                                              {Me.Label36, Me.txtSumKolFee})
        Me.GrpFtHedHavaleMamoorPakhshSN.Height = 0.2951389!
        Me.GrpFtHedHavaleMamoorPakhshSN.Name = "GrpFtHedHavaleMamoorPakhshSN"
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
        Me.lblCompany.Left = 1.142014!
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 12pt; font-f" & _
                              "amily: Tahoma; vertical-align: middle; "
        Me.lblCompany.Text = "شركت"
        Me.lblCompany.Top = 0.21875!
        Me.lblCompany.Width = 7.357986!
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
        Me.lblTitle.Left = 2.4375!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 12pt; font-f" & _
                            "amily: Tahoma; vertical-align: middle; "
        Me.lblTitle.Text = "برگ رسيد مامور پخش"
        Me.lblTitle.Top = 0.5340279!
        Me.lblTitle.Width = 5.125!
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
        Me.lbl6.Left = 0.896875!
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 6.75pt; font-f" & _
                        "amily: Tahoma; vertical-align: middle; "
        Me.lbl6.Text = " : تاريـخ گزارش"
        Me.lbl6.Top = 0.3173611!
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
        Me.lblDate.Left = 0.2079861!
        Me.lblDate.MultiLine = false
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 6.75pt; font-" & _
                           "family: Tahoma; vertical-align: middle; "
        Me.lblDate.Text = "lbl7"
        Me.lblDate.Top = 0.3173611!
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
        Me.lbl7.Left = 0.896875!
        Me.lbl7.MultiLine = false
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 6.75pt; font-f" & _
                        "amily: Tahoma; vertical-align: middle; "
        Me.lbl7.Text = ": ساعت "
        Me.lbl7.Top = 0.5138889!
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
        Me.lblTime.Left = 0.2079861!
        Me.lblTime.MultiLine = false
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 6.75pt; font-" & _
                           "family: Tahoma; vertical-align: middle; "
        Me.lblTime.Text = "lbl8"
        Me.lblTime.Top = 0.5138889!
        Me.lblTime.Width = 0.6888889!
        '
        'lblHavaleMamoorPakhshDateErsal
        '
        Me.lblHavaleMamoorPakhshDateErsal.Border.BottomColor = System.Drawing.Color.Black
        Me.lblHavaleMamoorPakhshDateErsal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavaleMamoorPakhshDateErsal.Border.LeftColor = System.Drawing.Color.Black
        Me.lblHavaleMamoorPakhshDateErsal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavaleMamoorPakhshDateErsal.Border.RightColor = System.Drawing.Color.Black
        Me.lblHavaleMamoorPakhshDateErsal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavaleMamoorPakhshDateErsal.Border.TopColor = System.Drawing.Color.Black
        Me.lblHavaleMamoorPakhshDateErsal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavaleMamoorPakhshDateErsal.Height = 0.246063!
        Me.lblHavaleMamoorPakhshDateErsal.HyperLink = Nothing
        Me.lblHavaleMamoorPakhshDateErsal.Left = 4.410392!
        Me.lblHavaleMamoorPakhshDateErsal.Name = "lblHavaleMamoorPakhshDateErsal"
        Me.lblHavaleMamoorPakhshDateErsal.Style = "ddo-char-set: 1; font-size: 9pt; font-family: Tahoma; "
        Me.lblHavaleMamoorPakhshDateErsal.Text = "تاريخ ارسال"
        Me.lblHavaleMamoorPakhshDateErsal.Top = 0.0218586!
        Me.lblHavaleMamoorPakhshDateErsal.Visible = false
        Me.lblHavaleMamoorPakhshDateErsal.Width = 0.7105889!
        '
        'txtHavaleMamoorPakhshDateErsal
        '
        Me.txtHavaleMamoorPakhshDateErsal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtHavaleMamoorPakhshDateErsal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavaleMamoorPakhshDateErsal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtHavaleMamoorPakhshDateErsal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavaleMamoorPakhshDateErsal.Border.RightColor = System.Drawing.Color.Black
        Me.txtHavaleMamoorPakhshDateErsal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavaleMamoorPakhshDateErsal.Border.TopColor = System.Drawing.Color.Black
        Me.txtHavaleMamoorPakhshDateErsal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavaleMamoorPakhshDateErsal.CanGrow = false
        Me.txtHavaleMamoorPakhshDateErsal.Height = 0.246063!
        Me.txtHavaleMamoorPakhshDateErsal.Left = 3.247252!
        Me.txtHavaleMamoorPakhshDateErsal.Name = "txtHavaleMamoorPakhshDateErsal"
        Me.txtHavaleMamoorPakhshDateErsal.OutputFormat = _
            resources.GetString ("txtHavaleMamoorPakhshDateErsal.OutputFormat")
        Me.txtHavaleMamoorPakhshDateErsal.Style = "ddo-char-set: 1; font-size: 9pt; font-family: Tahoma; "
        Me.txtHavaleMamoorPakhshDateErsal.Text = "txtHavaleMamoorPakhshDateErsal"
        Me.txtHavaleMamoorPakhshDateErsal.Top = 0.0218586!
        Me.txtHavaleMamoorPakhshDateErsal.Visible = false
        Me.txtHavaleMamoorPakhshDateErsal.Width = 1.13189!
        '
        'lblMamoorPakhshDS
        '
        Me.lblMamoorPakhshDS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMamoorPakhshDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMamoorPakhshDS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMamoorPakhshDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMamoorPakhshDS.Border.RightColor = System.Drawing.Color.Black
        Me.lblMamoorPakhshDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMamoorPakhshDS.Border.TopColor = System.Drawing.Color.Black
        Me.lblMamoorPakhshDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMamoorPakhshDS.Height = 0.246063!
        Me.lblMamoorPakhshDS.HyperLink = Nothing
        Me.lblMamoorPakhshDS.Left = 7.438854!
        Me.lblMamoorPakhshDS.Name = "lblMamoorPakhshDS"
        Me.lblMamoorPakhshDS.Style = "ddo-char-set: 1; font-size: 9pt; font-family: Tahoma; "
        Me.lblMamoorPakhshDS.Text = "نام مامور پخش"
        Me.lblMamoorPakhshDS.Top = 0.0625!
        Me.lblMamoorPakhshDS.Width = 0.8675368!
        '
        'txtMamoorPakhshDS
        '
        Me.txtMamoorPakhshDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMamoorPakhshDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMamoorPakhshDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMamoorPakhshDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMamoorPakhshDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtMamoorPakhshDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMamoorPakhshDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtMamoorPakhshDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMamoorPakhshDS.Height = 0.246063!
        Me.txtMamoorPakhshDS.Left = 5.25!
        Me.txtMamoorPakhshDS.Name = "txtMamoorPakhshDS"
        Me.txtMamoorPakhshDS.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; font-family: Tahoma; "
        Me.txtMamoorPakhshDS.Text = "txtMamoorPakhshDS"
        Me.txtMamoorPakhshDS.Top = 0.0625!
        Me.txtMamoorPakhshDS.Width = 2.066929!
        '
        'lblHavalePakhshStatusDS
        '
        Me.lblHavalePakhshStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblHavalePakhshStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavalePakhshStatusDS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblHavalePakhshStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavalePakhshStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.lblHavalePakhshStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavalePakhshStatusDS.Border.TopColor = System.Drawing.Color.Black
        Me.lblHavalePakhshStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHavalePakhshStatusDS.Height = 0.246063!
        Me.lblHavalePakhshStatusDS.HyperLink = Nothing
        Me.lblHavalePakhshStatusDS.Left = 1.519521!
        Me.lblHavalePakhshStatusDS.Name = "lblHavalePakhshStatusDS"
        Me.lblHavalePakhshStatusDS.Style = "ddo-char-set: 1; font-size: 9pt; font-family: Tahoma; "
        Me.lblHavalePakhshStatusDS.Text = "وضعيت"
        Me.lblHavalePakhshStatusDS.Top = 0.015625!
        Me.lblHavalePakhshStatusDS.Visible = false
        Me.lblHavalePakhshStatusDS.Width = 0.4912646!
        '
        'txtHavalePakhshStatusDS
        '
        Me.txtHavalePakhshStatusDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtHavalePakhshStatusDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavalePakhshStatusDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtHavalePakhshStatusDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavalePakhshStatusDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtHavalePakhshStatusDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavalePakhshStatusDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtHavalePakhshStatusDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHavalePakhshStatusDS.CanGrow = false
        Me.txtHavalePakhshStatusDS.Height = 0.246063!
        Me.txtHavalePakhshStatusDS.Left = 0.5344077!
        Me.txtHavalePakhshStatusDS.Name = "txtHavalePakhshStatusDS"
        Me.txtHavalePakhshStatusDS.Style = "ddo-char-set: 1; font-size: 9pt; font-family: Tahoma; "
        Me.txtHavalePakhshStatusDS.Text = "txtHavalePakhshStatusDS"
        Me.txtHavalePakhshStatusDS.Top = 0.015625!
        Me.txtHavalePakhshStatusDS.Visible = false
        Me.txtHavalePakhshStatusDS.Width = 0.9851125!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.RightColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Height = 0.2951389!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 8.180215!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                           "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.Label23.Text = "رديف"
        Me.Label23.Top = 0.4375!
        Me.Label23.Width = 0.3468952!
        '
        'lblKarton
        '
        Me.lblKarton.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.lblKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKarton.Border.RightColor = System.Drawing.Color.Black
        Me.lblKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblKarton.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKarton.Height = 0.2951389!
        Me.lblKarton.HyperLink = Nothing
        Me.lblKarton.Left = 0.5!
        Me.lblKarton.Name = "lblKarton"
        Me.lblKarton.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                             "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblKarton.Text = "نوع مرجوعي"
        Me.lblKarton.Top = 0.4427027!
        Me.lblKarton.Width = 1.850681!
        '
        'lblKolFee
        '
        Me.lblKolFee.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblKolFee.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKolFee.Border.LeftColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblKolFee.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKolFee.Border.RightColor = System.Drawing.Color.Black
        Me.lblKolFee.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblKolFee.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblKolFee.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblKolFee.Height = 0.2951389!
        Me.lblKolFee.HyperLink = Nothing
        Me.lblKolFee.Left = 2.350681!
        Me.lblKolFee.Name = "lblKolFee"
        Me.lblKolFee.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                             "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblKolFee.Text = "ريال مرجوعي"
        Me.lblKolFee.Top = 0.4427027!
        Me.lblKolFee.Width = 1.274319!
        '
        'lblFullName
        '
        Me.lblFullName.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblFullName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFullName.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFullName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFullName.Border.RightColor = System.Drawing.Color.Black
        Me.lblFullName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFullName.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblFullName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFullName.Height = 0.2951389!
        Me.lblFullName.HyperLink = Nothing
        Me.lblFullName.Left = 3.625!
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                               "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblFullName.Text = "مشتري"
        Me.lblFullName.Top = 0.4375!
        Me.lblFullName.Width = 2.711778!
        '
        'lblSodoorDate
        '
        Me.lblSodoorDate.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSodoorDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSodoorDate.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSodoorDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSodoorDate.Border.RightColor = System.Drawing.Color.Black
        Me.lblSodoorDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSodoorDate.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblSodoorDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblSodoorDate.Height = 0.2951389!
        Me.lblSodoorDate.HyperLink = Nothing
        Me.lblSodoorDate.Left = 6.336776!
        Me.lblSodoorDate.Name = "lblSodoorDate"
        Me.lblSodoorDate.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                                 "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblSodoorDate.Text = "تاريخ فاکتور"
        Me.lblSodoorDate.Top = 0.4375!
        Me.lblSodoorDate.Width = 0.9094076!
        '
        'lblFactorNo
        '
        Me.lblFactorNo.Border.BottomColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblFactorNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFactorNo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFactorNo.Border.RightColor = System.Drawing.Color.Black
        Me.lblFactorNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFactorNo.Border.TopColor = _
            System.Drawing.Color.FromArgb (CType (CType (0, Byte), Integer), CType (CType (0, Byte), Integer), _
                                           CType (CType (0, Byte), Integer))
        Me.lblFactorNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblFactorNo.Height = 0.2951389!
        Me.lblFactorNo.HyperLink = Nothing
        Me.lblFactorNo.Left = 7.246187!
        Me.lblFactorNo.Name = "lblFactorNo"
        Me.lblFactorNo.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; background-color: White" & _
                               "; font-size: 11.25pt; font-family: Tahoma; vertical-align: middle; "
        Me.lblFactorNo.Text = "شماره فاکتور"
        Me.lblFactorNo.Top = 0.4375!
        Me.lblFactorNo.Width = 0.9311!
        '
        'txtRadif
        '
        Me.txtRadif.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRadif.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRadif.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif.Border.RightColor = System.Drawing.Color.Black
        Me.txtRadif.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif.Border.TopColor = System.Drawing.Color.Black
        Me.txtRadif.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif.Height = 0.3149606!
        Me.txtRadif.Left = 8.239555!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: center; font-weight: normal; font-size: 9pt; font-" & _
                            "family: Tahoma; vertical-align: middle; "
        Me.txtRadif.Text = "Radif"
        Me.txtRadif.Top = 0!
        Me.txtRadif.Width = 0.3468952!
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
        Me.txtFactorNo.CanGrow = false
        Me.txtFactorNo.Height = 0.3149606!
        Me.txtFactorNo.Left = 7.305528!
        Me.txtFactorNo.Name = "txtFactorNo"
        Me.txtFactorNo.Style = "ddo-char-set: 178; text-align: center; font-weight: normal; font-size: 11.25pt; f" & _
                               "ont-family: Tahoma; vertical-align: middle; "
        Me.txtFactorNo.Text = "txtFactorNo"
        Me.txtFactorNo.Top = 0!
        Me.txtFactorNo.Width = 0.9311!
        '
        'txtSodoorDate
        '
        Me.txtSodoorDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSodoorDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSodoorDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSodoorDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSodoorDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtSodoorDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSodoorDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtSodoorDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSodoorDate.CanGrow = false
        Me.txtSodoorDate.Height = 0.3149606!
        Me.txtSodoorDate.Left = 6.396118!
        Me.txtSodoorDate.Name = "txtSodoorDate"
        Me.txtSodoorDate.OutputFormat = resources.GetString ("txtSodoorDate.OutputFormat")
        Me.txtSodoorDate.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 9pt; font-f" & _
                                 "amily: Tahoma; vertical-align: middle; "
        Me.txtSodoorDate.Text = "SodoorDate"
        Me.txtSodoorDate.Top = 0!
        Me.txtSodoorDate.Width = 0.9094076!
        '
        'txtFullName
        '
        Me.txtFullName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFullName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFullName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFullName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFullName.Border.RightColor = System.Drawing.Color.Black
        Me.txtFullName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFullName.Border.TopColor = System.Drawing.Color.Black
        Me.txtFullName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFullName.CanGrow = false
        Me.txtFullName.Height = 0.3149606!
        Me.txtFullName.Left = 3.65625!
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Tahoma; verti" & _
                               "cal-align: top; "
        Me.txtFullName.Text = "FullName"
        Me.txtFullName.Top = 0!
        Me.txtFullName.Width = 2.711778!
        '
        'txtKolFee
        '
        Me.txtKolFee.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKolFee.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKolFee.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKolFee.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKolFee.Border.RightColor = System.Drawing.Color.Black
        Me.txtKolFee.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKolFee.Border.TopColor = System.Drawing.Color.Black
        Me.txtKolFee.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKolFee.Height = 0.3149606!
        Me.txtKolFee.Left = 2.375!
        Me.txtKolFee.Name = "txtKolFee"
        Me.txtKolFee.OutputFormat = resources.GetString ("txtKolFee.OutputFormat")
        Me.txtKolFee.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 9.75pt; font-" & _
                             "family: Koodak; vertical-align: middle; "
        Me.txtKolFee.Text = "KolFee"
        Me.txtKolFee.Top = 0!
        Me.txtKolFee.Width = 1.274319!
        '
        'txtKarton
        '
        Me.txtKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKarton.Border.RightColor = System.Drawing.Color.Black
        Me.txtKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKarton.Border.TopColor = System.Drawing.Color.Black
        Me.txtKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKarton.Height = 0.3149606!
        Me.txtKarton.Left = 0.53125!
        Me.txtKarton.Name = "txtKarton"
        Me.txtKarton.OutputFormat = resources.GetString ("txtKarton.OutputFormat")
        Me.txtKarton.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 9.75pt; font-" & _
                             "family: Koodak; vertical-align: middle; "
        Me.txtKarton.Text = "Karton"
        Me.txtKarton.Top = 0!
        Me.txtKarton.Width = 1.850681!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.Black
        Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.LeftColor = System.Drawing.Color.Black
        Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.RightColor = System.Drawing.Color.Black
        Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.TopColor = System.Drawing.Color.Black
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Height = 0.2951389!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 3.625!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 1; font-weight: bold; background-color: White; font-size: 11pt; fon" & _
                           "t-family: Koodak; "
        Me.Label36.Text = " : جمع "
        Me.Label36.Top = 0!
        Me.Label36.Width = 1.312335!
        '
        'txtSumKolFee
        '
        Me.txtSumKolFee.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSumKolFee.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumKolFee.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSumKolFee.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumKolFee.Border.RightColor = System.Drawing.Color.Black
        Me.txtSumKolFee.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumKolFee.Border.TopColor = System.Drawing.Color.Black
        Me.txtSumKolFee.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSumKolFee.Height = 0.2916667!
        Me.txtSumKolFee.Left = 2.3125!
        Me.txtSumKolFee.Name = "txtSumKolFee"
        Me.txtSumKolFee.OutputFormat = resources.GetString ("txtSumKolFee.OutputFormat")
        Me.txtSumKolFee.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" & _
                                " font-size: 9.75pt; font-family: Tahoma; vertical-align: middle; "
        Me.txtSumKolFee.SummaryGroup = "GrpHedHavaleMamoorPakhshSN"
        Me.txtSumKolFee.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSumKolFee.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSumKolFee.Text = "KolFee"
        Me.txtSumKolFee.Top = 0!
        Me.txtSumKolFee.Width = 1.25!
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
        Me.Label43.Left = 2.246528!
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
        Me.txtpageNo.Left = 1.65625!
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
        Me.txtUser.Left = 3.625!
        Me.txtUser.MultiLine = false
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" & _
                           "t-family: Tahoma; white-space: nowrap; vertical-align: middle; "
        Me.txtUser.Text = Nothing
        Me.txtUser.Top = 0.0625!
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
        Me.lbl3.Left = 7.297222!
        Me.lbl3.MultiLine = false
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "ddo-char-set: 178; text-align: right; font-weight: normal; font-size: 8.25pt; fon" & _
                        "t-family: Tahoma; vertical-align: middle; "
        Me.lbl3.Text = " :گزارش گيرنده"
        Me.lbl3.Top = 0.0625!
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
        Me.txtPageTotal.Left = 0.71875!
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
        Me.Label44.Left = 1.46875!
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
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.84375!
        Me.Sections.Add (Me.ReportHeader)
        Me.Sections.Add (Me.PageHeader)
        Me.Sections.Add (Me.GrpHedHavaleMamoorPakhshSN)
        Me.Sections.Add (Me.Detail)
        Me.Sections.Add (Me.GrpFtHedHavaleMamoorPakhshSN)
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
        CType (Me.lblHavaleMamoorPakhshDateErsal, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtHavaleMamoorPakhshDateErsal, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblMamoorPakhshDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtMamoorPakhshDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblHavalePakhshStatusDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtHavalePakhshStatusDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblKarton, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblKolFee, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblFullName, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblSodoorDate, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblFactorNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtFactorNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSodoorDate, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtFullName, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKolFee, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKarton, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSumKolFee, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtpageNo, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtPageTotal, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Sub PageFooter_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtUser.Text = gSM.UserName
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

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي
        GrpHedHavaleMamoorPakhshSN.DataField = "MamoorPakhshSN"

        txtMamoorPakhshDS.DataField = "MamoorPakhshNO_DS"

        txtFactorNo.DataField = "FactorNo"
        txtSodoorDate.DataField = "SodoorDate"
        txtFullName.DataField = "FullName"
        txtKolFee.DataField = "Sum_KalaFee"
        txtSumKolFee.DataField = "Sum_KalaFee"
        '    txtTarakoneshDs.DataField = "TarakoneshDs"

    End Sub

    Private Sub Detail_Format (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtRadif.Text = Val (txtRadif.Text) + 1
    End Sub


    Private Sub GrpFtHedHavaleMamoorPakhshSN_Format (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles GrpFtHedHavaleMamoorPakhshSN.Format
        txtRadif.Text = 0
    End Sub
End Class
