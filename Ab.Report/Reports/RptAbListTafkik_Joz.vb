''Add By Dehghani <930807>
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptAbListTafkik_Joz
    Inherits ActiveReport3

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "لیست تفکیک جزء"
        txtRadif.Text = 0
        Me.PageSettings.PaperKind = Printing.PaperKind.A4
        Me.PageSettings.Margins.Left = 0
        Me.PageSettings.Margins.Right = 0
        Me.PageSettings.Margins.Top = 0
        Me.PageSettings.Margins.Bottom = 0.5
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GrpFtVahedShobe As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private lbl6 As DataDynamics.ActiveReports.Label = Nothing
    Private lblDate As DataDynamics.ActiveReports.Label = Nothing
    Private lbl7 As DataDynamics.ActiveReports.Label = Nothing
    Private lblTime As DataDynamics.ActiveReports.Label = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private txtpageNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtUser As DataDynamics.ActiveReports.TextBox = Nothing
    Private lbl3 As DataDynamics.ActiveReports.Label = Nothing
    Private txtPageTotal As DataDynamics.ActiveReports.TextBox = Nothing
    Friend WithEvents LabelShobe As DataDynamics.ActiveReports.Label
    Private Label44 As DataDynamics.ActiveReports.Label = Nothing
    Private WithEvents GrpHedVahedTejariSN As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblTedadAjza As DataDynamics.ActiveReports.Label
    Friend WithEvents Label45 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDesc As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCode As DataDynamics.ActiveReports.Label
    Friend WithEvents Label23 As DataDynamics.ActiveReports.Label
    Friend WithEvents LabelKarton As DataDynamics.ActiveReports.Label
    Friend WithEvents LabelAdad As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtTedadDarKarton As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtKalaDS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtKalaNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRadif As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdad As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtKarton As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TxtRial As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TxtVazn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TotalKarton As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TotalAdad As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TotalVazn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TxtTotalRial As DataDynamics.ActiveReports.TextBox
    Private WithEvents GrpFtVahedTejariSN As DataDynamics.ActiveReports.GroupFooter

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptAbListTafkik_Joz))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtTedadDarKarton = New DataDynamics.ActiveReports.TextBox()
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox()
        Me.txtAdad = New DataDynamics.ActiveReports.TextBox()
        Me.txtKarton = New DataDynamics.ActiveReports.TextBox()
        Me.TxtRial = New DataDynamics.ActiveReports.TextBox()
        Me.TxtVazn = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.lbl6 = New DataDynamics.ActiveReports.Label()
        Me.lblDate = New DataDynamics.ActiveReports.Label()
        Me.lbl7 = New DataDynamics.ActiveReports.Label()
        Me.lblTime = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label43 = New DataDynamics.ActiveReports.Label()
        Me.txtpageNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtUser = New DataDynamics.ActiveReports.TextBox()
        Me.lbl3 = New DataDynamics.ActiveReports.Label()
        Me.txtPageTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label44 = New DataDynamics.ActiveReports.Label()
        Me.LabelShobe = New DataDynamics.ActiveReports.Label()
        Me.GrpHedVahedTejariSN = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblTedadAjza = New DataDynamics.ActiveReports.Label()
        Me.Label45 = New DataDynamics.ActiveReports.Label()
        Me.lblDesc = New DataDynamics.ActiveReports.Label()
        Me.lblCode = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.LabelKarton = New DataDynamics.ActiveReports.Label()
        Me.LabelAdad = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.GrpFtVahedTejariSN = New DataDynamics.ActiveReports.GroupFooter()
        Me.TotalKarton = New DataDynamics.ActiveReports.TextBox()
        Me.TotalAdad = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TotalVazn = New DataDynamics.ActiveReports.TextBox()
        Me.TxtTotalRial = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txtTedadDarKarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVazn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelShobe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelKarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelAdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalKarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalVazn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalRial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTedadDarKarton, Me.txtShomarehRahgiri, Me.txtKalaDS, Me.txtKalaNo, Me.txtRadif, Me.txtAdad, Me.txtKarton, Me.TxtRial, Me.TxtVazn})
        Me.Detail.Height = 0.3149606!
        Me.Detail.Name = "Detail"
        '
        'txtTedadDarKarton
        '
        Me.txtTedadDarKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadDarKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadDarKarton.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadDarKarton.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTedadDarKarton.CanGrow = False
        Me.txtTedadDarKarton.Height = 0.3125!
        Me.txtTedadDarKarton.Left = 2.25!
        Me.txtTedadDarKarton.Name = "txtTedadDarKarton"
        Me.txtTedadDarKarton.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.txtTedadDarKarton.Text = "TedadDarKarton"
        Me.txtTedadDarKarton.Top = 0!
        Me.txtTedadDarKarton.Width = 0.5!
        '
        'txtShomarehRahgiri
        '
        Me.txtShomarehRahgiri.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtShomarehRahgiri.Height = 0.3125!
        Me.txtShomarehRahgiri.Left = 6.6875!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.txtShomarehRahgiri.Text = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Top = 0!
        Me.txtShomarehRahgiri.Width = 1.0!
        '
        'txtKalaDS
        '
        Me.txtKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaDS.Height = 0.3125!
        Me.txtKalaDS.Left = 2.75!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" &
    "y: Times New Roman; vertical-align: middle; "
        Me.txtKalaDS.Text = "KalaDS"
        Me.txtKalaDS.Top = 0!
        Me.txtKalaDS.Width = 3.125!
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
        Me.txtKalaNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKalaNo.CanGrow = False
        Me.txtKalaNo.Height = 0.3125!
        Me.txtKalaNo.Left = 5.875!
        Me.txtKalaNo.Name = "txtKalaNo"
        Me.txtKalaNo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.txtKalaNo.Text = "KalaNo"
        Me.txtKalaNo.Top = 0!
        Me.txtKalaNo.Width = 0.8125!
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
        Me.txtRadif.CanGrow = False
        Me.txtRadif.Height = 0.3149606!
        Me.txtRadif.Left = 7.6875!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.txtRadif.Text = "Radif"
        Me.txtRadif.Top = 0!
        Me.txtRadif.Width = 0.39375!
        '
        'txtAdad
        '
        Me.txtAdad.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdad.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdad.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdad.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdad.CanGrow = False
        Me.txtAdad.Height = 0.3125!
        Me.txtAdad.Left = 1.375!
        Me.txtAdad.Name = "txtAdad"
        Me.txtAdad.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.txtAdad.Text = "Adad"
        Me.txtAdad.Top = 0!
        Me.txtAdad.Width = 0.4375!
        '
        'txtKarton
        '
        Me.txtKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKarton.Border.RightColor = System.Drawing.Color.Black
        Me.txtKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKarton.Border.TopColor = System.Drawing.Color.Black
        Me.txtKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKarton.CanGrow = False
        Me.txtKarton.Height = 0.3125!
        Me.txtKarton.Left = 1.8125!
        Me.txtKarton.Name = "txtKarton"
        Me.txtKarton.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 10pt; font-fam" &
    "ily: Times New Roman; vertical-align: middle; "
        Me.txtKarton.Text = "Karton"
        Me.txtKarton.Top = 0!
        Me.txtKarton.Width = 0.4375!
        '
        'TxtRial
        '
        Me.TxtRial.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtRial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtRial.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtRial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtRial.Border.RightColor = System.Drawing.Color.Black
        Me.TxtRial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtRial.Border.TopColor = System.Drawing.Color.Black
        Me.TxtRial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtRial.CanGrow = False
        Me.TxtRial.Height = 0.3125!
        Me.TxtRial.Left = 0.25!
        Me.TxtRial.Name = "TxtRial"
        Me.TxtRial.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.TxtRial.Text = "Rial"
        Me.TxtRial.Top = 0!
        Me.TxtRial.Width = 0.5625!
        '
        'TxtVazn
        '
        Me.TxtVazn.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtVazn.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVazn.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtVazn.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVazn.Border.RightColor = System.Drawing.Color.Black
        Me.TxtVazn.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVazn.Border.TopColor = System.Drawing.Color.Black
        Me.TxtVazn.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtVazn.CanGrow = False
        Me.TxtVazn.Height = 0.3125!
        Me.TxtVazn.Left = 0.8125!
        Me.TxtVazn.Name = "TxtVazn"
        Me.TxtVazn.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" &
    "ly: Times New Roman; vertical-align: middle; "
        Me.TxtVazn.Text = "Vazn"
        Me.TxtVazn.Top = 0!
        Me.TxtVazn.Width = 0.5625!
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
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl6, Me.lblDate, Me.lbl7, Me.lblTime})
        Me.PageHeader.Height = 0.7083333!
        Me.PageHeader.Name = "PageHeader"
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
        Me.lbl6.Left = 0.9375!
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl6.Text = " : تاريـخ گزارش"
        Me.lbl6.Top = 0.1875!
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
        Me.lblDate.Left = 0.25!
        Me.lblDate.MultiLine = False
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblDate.Text = "lbl7"
        Me.lblDate.Top = 0.1875!
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
        Me.lbl7.Left = 0.9375!
        Me.lbl7.MultiLine = False
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Style = "ddo-char-set: 178; text-align: left; font-weight: bold; font-size: 7pt; font-fami" &
    "ly: Tahoma; vertical-align: middle; "
        Me.lbl7.Text = ": ساعت "
        Me.lbl7.Top = 0.4375!
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
        Me.lblTime.Left = 0.25!
        Me.lblTime.MultiLine = False
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 7pt; font-fam" &
    "ily: Tahoma; vertical-align: middle; "
        Me.lblTime.Text = "lbl8"
        Me.lblTime.Top = 0.4375!
        Me.lblTime.Width = 0.6888889!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label43, Me.txtpageNo, Me.txtUser, Me.lbl3, Me.txtPageTotal, Me.Label44})
        Me.PageFooter.Height = 0.5208333!
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
        Me.Label43.Left = 1.75!
        Me.Label43.MultiLine = False
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-f" &
    "amily: Times New Roman; vertical-align: bottom; "
        Me.Label43.Text = ":صفحه "
        Me.Label43.Top = 0.0625!
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
        Me.txtpageNo.Left = 1.1875!
        Me.txtpageNo.MultiLine = False
        Me.txtpageNo.Name = "txtpageNo"
        Me.txtpageNo.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9.75pt; font-fam" &
    "ily: Times New Roman; white-space: nowrap; vertical-align: middle; "
        Me.txtpageNo.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtpageNo.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtpageNo.Text = Nothing
        Me.txtpageNo.Top = 0.0625!
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
        Me.txtUser.Height = 0.25!
        Me.txtUser.Left = 3.3125!
        Me.txtUser.MultiLine = False
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; font-fa" &
    "mily: Times New Roman; white-space: nowrap; vertical-align: middle; "
        Me.txtUser.Text = Nothing
        Me.txtUser.Top = 0.0625!
        Me.txtUser.Width = 3.6875!
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
        Me.lbl3.Height = 0.25!
        Me.lbl3.HyperLink = Nothing
        Me.lbl3.Left = 7.0!
        Me.lbl3.MultiLine = False
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-f" &
    "amily: Times New Roman; vertical-align: middle; "
        Me.lbl3.Text = " :گزارش گيرنده"
        Me.lbl3.Top = 0.0625!
        Me.lbl3.Width = 0.875!
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
        Me.txtPageTotal.Left = 0.25!
        Me.txtPageTotal.Name = "txtPageTotal"
        Me.txtPageTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; font-fa" &
    "mily: Times New Roman; vertical-align: middle; "
        Me.txtPageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtPageTotal.Text = Nothing
        Me.txtPageTotal.Top = 0.0625!
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
        Me.Label44.Left = 1.0!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-f" &
    "amily: Times New Roman; vertical-align: bottom; "
        Me.Label44.Text = "از"
        Me.Label44.Top = 0.0625!
        Me.Label44.Width = 0.1875!
        '
        'LabelShobe
        '
        Me.LabelShobe.Border.BottomColor = System.Drawing.Color.Black
        Me.LabelShobe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelShobe.Border.LeftColor = System.Drawing.Color.Black
        Me.LabelShobe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelShobe.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelShobe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelShobe.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelShobe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelShobe.Height = 0.5!
        Me.LabelShobe.HyperLink = Nothing
        Me.LabelShobe.Left = 6.6875!
        Me.LabelShobe.Name = "LabelShobe"
        Me.LabelShobe.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: WhiteSm" &
    "oke; font-size: 13pt; font-family: B Titr; vertical-align: middle; "
        Me.LabelShobe.Text = "شعبه"
        Me.LabelShobe.Top = 0!
        Me.LabelShobe.Width = 1.387!
        '
        'GrpHedVahedTejariSN
        '
        Me.GrpHedVahedTejariSN.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.LabelShobe, Me.lblTedadAjza, Me.Label45, Me.lblDesc, Me.lblCode, Me.Label23, Me.LabelKarton, Me.LabelAdad, Me.Label1, Me.Label2})
        Me.GrpHedVahedTejariSN.Height = 1.0!
        Me.GrpHedVahedTejariSN.KeepTogether = True
        Me.GrpHedVahedTejariSN.Name = "GrpHedVahedTejariSN"
        Me.GrpHedVahedTejariSN.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.All
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
        Me.lblTedadAjza.Height = 0.5!
        Me.lblTedadAjza.HyperLink = Nothing
        Me.lblTedadAjza.Left = 2.25!
        Me.lblTedadAjza.Name = "lblTedadAjza"
        Me.lblTedadAjza.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblTedadAjza.Text = "تعداد در کارتن"
        Me.lblTedadAjza.Top = 0.5!
        Me.lblTedadAjza.Width = 0.5!
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
        Me.Label45.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label45.Text = "شماره رهگيري"
        Me.Label45.Top = 0.5!
        Me.Label45.Width = 1.0!
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
        Me.lblDesc.Left = 2.75!
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblDesc.Text = "نام کالا"
        Me.lblDesc.Top = 0.5!
        Me.lblDesc.Width = 3.125!
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
        Me.lblCode.Left = 5.875!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.lblCode.Text = "کد کالا"
        Me.lblCode.Top = 0.5!
        Me.lblCode.Width = 0.8125!
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
        Me.Label23.Height = 0.5!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 7.6875!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label23.Text = "رديف"
        Me.Label23.Top = 0.5!
        Me.Label23.Width = 0.39375!
        '
        'LabelKarton
        '
        Me.LabelKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.LabelKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.LabelKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelKarton.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelKarton.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelKarton.Height = 0.5!
        Me.LabelKarton.HyperLink = Nothing
        Me.LabelKarton.Left = 1.8125!
        Me.LabelKarton.Name = "LabelKarton"
        Me.LabelKarton.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.LabelKarton.Text = "کارتن"
        Me.LabelKarton.Top = 0.5!
        Me.LabelKarton.Width = 0.4375!
        '
        'LabelAdad
        '
        Me.LabelAdad.Border.BottomColor = System.Drawing.Color.Black
        Me.LabelAdad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelAdad.Border.LeftColor = System.Drawing.Color.Black
        Me.LabelAdad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelAdad.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelAdad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelAdad.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelAdad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.LabelAdad.Height = 0.5!
        Me.LabelAdad.HyperLink = Nothing
        Me.LabelAdad.Left = 1.375!
        Me.LabelAdad.Name = "LabelAdad"
        Me.LabelAdad.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.LabelAdad.Text = "عدد"
        Me.LabelAdad.Top = 0.5!
        Me.LabelAdad.Width = 0.4375!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.5!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.8125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label1.Text = "وزن (کیلو)"
        Me.Label1.Top = 0.5!
        Me.Label1.Width = 0.5625!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.5!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: White; " &
    "font-size: 11.25pt; font-family: B Nazanin; vertical-align: middle; "
        Me.Label2.Text = " میلیون ریال"
        Me.Label2.Top = 0.5!
        Me.Label2.Width = 0.5625!
        '
        'GrpFtVahedTejariSN
        '
        Me.GrpFtVahedTejariSN.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TotalKarton, Me.TotalAdad, Me.TextBox3, Me.TotalVazn, Me.TxtTotalRial})
        Me.GrpFtVahedTejariSN.Height = 0.3125!
        Me.GrpFtVahedTejariSN.Name = "GrpFtVahedTejariSN"
        '
        'TotalKarton
        '
        Me.TotalKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.TotalKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.TotalKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalKarton.Border.RightColor = System.Drawing.Color.Black
        Me.TotalKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalKarton.Border.TopColor = System.Drawing.Color.Black
        Me.TotalKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalKarton.Height = 0.3125!
        Me.TotalKarton.Left = 1.8125!
        Me.TotalKarton.Name = "TotalKarton"
        Me.TotalKarton.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 10pt; font-fam" &
    "ily: Times New Roman; vertical-align: middle; "
        Me.TotalKarton.Text = "TKarton"
        Me.TotalKarton.Top = 0!
        Me.TotalKarton.Width = 0.4375!
        '
        'TotalAdad
        '
        Me.TotalAdad.Border.BottomColor = System.Drawing.Color.Black
        Me.TotalAdad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalAdad.Border.LeftColor = System.Drawing.Color.Black
        Me.TotalAdad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalAdad.Border.RightColor = System.Drawing.Color.Black
        Me.TotalAdad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalAdad.Border.TopColor = System.Drawing.Color.Black
        Me.TotalAdad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalAdad.Height = 0.3125!
        Me.TotalAdad.Left = 1.375!
        Me.TotalAdad.Name = "TotalAdad"
        Me.TotalAdad.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 10pt; font-fam" &
    "ily: Times New Roman; vertical-align: middle; "
        Me.TotalAdad.Text = "TAdad"
        Me.TotalAdad.Top = 0!
        Me.TotalAdad.Width = 0.4375!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox3.Height = 0.3125!
        Me.TextBox3.Left = 2.25!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 12pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox3.Text = "جمع"
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.9!
        '
        'TotalVazn
        '
        Me.TotalVazn.Border.BottomColor = System.Drawing.Color.Black
        Me.TotalVazn.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalVazn.Border.LeftColor = System.Drawing.Color.Black
        Me.TotalVazn.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalVazn.Border.RightColor = System.Drawing.Color.Black
        Me.TotalVazn.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalVazn.Border.TopColor = System.Drawing.Color.Black
        Me.TotalVazn.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TotalVazn.Height = 0.3125!
        Me.TotalVazn.Left = 0.8125!
        Me.TotalVazn.Name = "TotalVazn"
        Me.TotalVazn.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 10pt; font-fam" &
    "ily: Times New Roman; vertical-align: middle; "
        Me.TotalVazn.Text = "TVazn"
        Me.TotalVazn.Top = 0!
        Me.TotalVazn.Width = 0.5625!
        '
        'TxtTotalRial
        '
        Me.TxtTotalRial.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtTotalRial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TxtTotalRial.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtTotalRial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TxtTotalRial.Border.RightColor = System.Drawing.Color.Black
        Me.TxtTotalRial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TxtTotalRial.Border.TopColor = System.Drawing.Color.Black
        Me.TxtTotalRial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TxtTotalRial.Height = 0.3125!
        Me.TxtTotalRial.Left = 0.25!
        Me.TxtTotalRial.Name = "TxtTotalRial"
        Me.TxtTotalRial.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 10pt; font-fam" &
    "ily: Times New Roman; vertical-align: middle; "
        Me.TxtTotalRial.Text = "tRial"
        Me.TxtTotalRial.Top = 0!
        Me.TxtTotalRial.Width = 0.5625!
        '
        'RptAbListTafkik_Joz
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.260417!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GrpHedVahedTejariSN)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GrpFtVahedTejariSN)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.txtTedadDarKarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVazn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelShobe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelKarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelAdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalKarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalVazn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalRial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public TKarton As Integer = 0
    Public TAdad As Integer = 0
    Public tVazn As Decimal = 0
    Public TRial As Decimal = 0
    Public TxtFont1 As System.Drawing.Font
    Public TxtFont2 As System.Drawing.Font
    Public ShobeName As String
    Public TaminKonandeName As String

    Public Sub DefField()
        GrpHedVahedTejariSN.DataField = "VahedeTejariSN"
        txtKalaNo.DataField = "KalaNo"
        txtKalaDS.DataField = "KalaDS"
        txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        txtTedadDarKarton.DataField = "tedadDarKarton"
        txtKarton.DataField = "Karton"
        txtAdad.DataField = "Adad"
        TxtRial.DataField = "RialeSadereh"
        TxtVazn.DataField = "Vazn"
        txtRadif.Font = TxtFont1
        txtKalaNo.Font = TxtFont1
        txtKalaDS.Font = TxtFont1
        txtShomarehRahgiri.Font = TxtFont1
        txtTedadDarKarton.Font = TxtFont2
        txtKarton.Font = TxtFont1
        TotalKarton.Font = TxtFont1
        txtAdad.Font = TxtFont2
        TotalAdad.Font = TxtFont2
        TxtRial.Font = TxtFont2
        TxtTotalRial.Font = TxtFont2
        TxtVazn.Font = TxtFont2
        TotalVazn.Font = TxtFont2
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash)
        lblTime.Text = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn, Functions.FTDBCommonFunctions.enmTimeFormat.HHmm)
    End Sub

    Private Sub GrpHedVahedTejariSN_Format(sender As System.Object, e As System.EventArgs) Handles GrpHedVahedTejariSN.Format
        If Not GrpHedVahedTejariSN.IsRepeating Then
            txtRadif.Text = 0
        End If
        LabelShobe.Text = If(GrpHedVahedTejariSN.IsRepeating, ShobeName, Me.Fields("VahedeTejariDS").Value.ToString)
        ShobeName = Me.Fields("VahedeTejariDS").Value.ToString
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtRadif.Text = CStr(Val(txtRadif.Text) + 1)
        TKarton += CInt(Me.Fields("Karton").Value)
        TAdad += CInt(Me.Fields("Adad").Value)
        tVazn += CDec(Me.Fields("Vazn").Value)
        TRial += CDec(Me.Fields("RialeSadereh").Value)
    End Sub

    Private Sub GrpFtVahedTejariSN_Format(sender As System.Object, e As System.EventArgs) Handles GrpFtVahedShobe.Format, GrpFtVahedTejariSN.Format
        TotalKarton.Text = CStr(TKarton)
        TotalAdad.Text = CStr(TAdad)
        TotalVazn.Text = CStr(tVazn)
        TxtTotalRial.Text = CStr(TRial)
        TKarton = 0
        TAdad = 0
        tVazn = 0
        TRial = 0
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtUser.Text = "       " + gSM.UserName
    End Sub

End Class
