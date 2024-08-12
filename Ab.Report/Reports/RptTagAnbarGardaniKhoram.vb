Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptTagAnbarGardanikhoram
    Inherits ActiveReport3

    'Public txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    'Public txtRadif2 As DataDynamics.ActiveReports.TextBox = Nothing
    'Public txtRadif3 As DataDynamics.ActiveReports.TextBox = Nothing
    'Public txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing

    Dim vRadif As Integer

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
    Public txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label27 As DataDynamics.ActiveReports.Label = Nothing
    Private Label28 As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaNO3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label29 As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label30 As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label32 As DataDynamics.ActiveReports.Label = Nothing
    Private Label33 As DataDynamics.ActiveReports.Label = Nothing
    Private Label4 As DataDynamics.ActiveReports.Label = Nothing
    Private Shape4 As DataDynamics.ActiveReports.Shape = Nothing
    Public txtSherkat2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label35 As DataDynamics.ActiveReports.Label = Nothing
    Private txtRadif2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label36 As DataDynamics.ActiveReports.Label = Nothing
    Private Label37 As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaNo2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label38 As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label39 As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label41 As DataDynamics.ActiveReports.Label = Nothing
    Private Label42 As DataDynamics.ActiveReports.Label = Nothing
    Private Label43 As DataDynamics.ActiveReports.Label = Nothing
    Private Shape5 As DataDynamics.ActiveReports.Shape = Nothing
    Public txtSherkat1 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label46 As DataDynamics.ActiveReports.Label = Nothing
    Private Label47 As DataDynamics.ActiveReports.Label = Nothing
    Private txtkalano As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label48 As DataDynamics.ActiveReports.Label = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label49 As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label51 As DataDynamics.ActiveReports.Label = Nothing
    Private Label52 As DataDynamics.ActiveReports.Label = Nothing
    Private Label53 As DataDynamics.ActiveReports.Label = Nothing
    Private Label54 As DataDynamics.ActiveReports.Label = Nothing
    Private Label55 As DataDynamics.ActiveReports.Label = Nothing
    Private Label56 As DataDynamics.ActiveReports.Label = Nothing
    Private Label57 As DataDynamics.ActiveReports.Label = Nothing
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChidemanNo As TextBox
    Private Label58 As DataDynamics.ActiveReports.Label = Nothing

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptTagAnbarGardanikhoram))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.Shape3 = New DataDynamics.ActiveReports.Shape()
        Me.txtSherkat = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label27 = New DataDynamics.ActiveReports.Label()
        Me.Label28 = New DataDynamics.ActiveReports.Label()
        Me.txtKalaNO3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label29 = New DataDynamics.ActiveReports.Label()
        Me.txtKalaDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label30 = New DataDynamics.ActiveReports.Label()
        Me.txtVahedeSanjeshDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label32 = New DataDynamics.ActiveReports.Label()
        Me.Label33 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Shape4 = New DataDynamics.ActiveReports.Shape()
        Me.txtSherkat2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label35 = New DataDynamics.ActiveReports.Label()
        Me.txtRadif2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label36 = New DataDynamics.ActiveReports.Label()
        Me.Label37 = New DataDynamics.ActiveReports.Label()
        Me.txtKalaNo2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label38 = New DataDynamics.ActiveReports.Label()
        Me.txtKalaDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label39 = New DataDynamics.ActiveReports.Label()
        Me.txtVahedeSanjeshDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label41 = New DataDynamics.ActiveReports.Label()
        Me.Label42 = New DataDynamics.ActiveReports.Label()
        Me.Label43 = New DataDynamics.ActiveReports.Label()
        Me.Shape5 = New DataDynamics.ActiveReports.Shape()
        Me.txtSherkat1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox()
        Me.Label46 = New DataDynamics.ActiveReports.Label()
        Me.Label47 = New DataDynamics.ActiveReports.Label()
        Me.txtkalano = New DataDynamics.ActiveReports.TextBox()
        Me.Label48 = New DataDynamics.ActiveReports.Label()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.Label49 = New DataDynamics.ActiveReports.Label()
        Me.txtVahedeSanjeshDS = New DataDynamics.ActiveReports.TextBox()
        Me.Label51 = New DataDynamics.ActiveReports.Label()
        Me.Label52 = New DataDynamics.ActiveReports.Label()
        Me.Label53 = New DataDynamics.ActiveReports.Label()
        Me.Label54 = New DataDynamics.ActiveReports.Label()
        Me.Label55 = New DataDynamics.ActiveReports.Label()
        Me.Label56 = New DataDynamics.ActiveReports.Label()
        Me.Label57 = New DataDynamics.ActiveReports.Label()
        Me.Label58 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.txtChidemanNo = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txtSherkat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkalano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChidemanNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnCount = 3
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.txtSherkat, Me.txtRadif3, Me.Label27, Me.Label28, Me.txtKalaNO3, Me.Label29, Me.txtKalaDS3, Me.Label30, Me.txtVahedeSanjeshDS3, Me.Label32, Me.Label33, Me.Label4, Me.Shape4, Me.txtSherkat2, Me.Label35, Me.txtRadif2, Me.Label36, Me.Label37, Me.txtKalaNo2, Me.Label38, Me.txtKalaDS2, Me.Label39, Me.txtVahedeSanjeshDS2, Me.Label41, Me.Label42, Me.Label43, Me.Shape5, Me.txtSherkat1, Me.txtRadif, Me.Label46, Me.Label47, Me.txtkalano, Me.Label48, Me.txtKalaDS, Me.Label49, Me.txtVahedeSanjeshDS, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.Label55, Me.Label56, Me.Label57, Me.Label58, Me.Label12, Me.txtChidemanNo})
        Me.Detail.Height = 8.206944!
        Me.Detail.Name = "Detail"
        '
        'Shape3
        '
        Me.Shape3.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.RightColor = System.Drawing.Color.Black
        Me.Shape3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.TopColor = System.Drawing.Color.Black
        Me.Shape3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Height = 2.309055!
        Me.Shape3.Left = 0.1574803!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 0.1674869!
        Me.Shape3.Width = 3.605807!
        '
        'txtSherkat
        '
        Me.txtSherkat.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSherkat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSherkat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat.Border.RightColor = System.Drawing.Color.Black
        Me.txtSherkat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat.Border.TopColor = System.Drawing.Color.Black
        Me.txtSherkat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat.CanGrow = False
        Me.txtSherkat.Height = 0.1934058!
        Me.txtSherkat.Left = 1.221785!
        Me.txtSherkat.Name = "txtSherkat"
        Me.txtSherkat.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" &
    "y: Koodak; "
        Me.txtSherkat.Text = " "
        Me.txtSherkat.Top = 0.2124344!
        Me.txtSherkat.Width = 2.531496!
        '
        'txtRadif3
        '
        Me.txtRadif3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRadif3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRadif3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif3.Border.RightColor = System.Drawing.Color.Black
        Me.txtRadif3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif3.Border.TopColor = System.Drawing.Color.Black
        Me.txtRadif3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif3.Height = 0.2519685!
        Me.txtRadif3.Left = 2.132218!
        Me.txtRadif3.Name = "txtRadif3"
        Me.txtRadif3.Style = "ddo-char-set: 178; text-align: right; font-size: 12pt; "
        Me.txtRadif3.Text = Nothing
        Me.txtRadif3.Top = 0.622375!
        Me.txtRadif3.Width = 0.7624667!
        '
        'Label27
        '
        Me.Label27.Border.BottomColor = System.Drawing.Color.Black
        Me.Label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.LeftColor = System.Drawing.Color.Black
        Me.Label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.RightColor = System.Drawing.Color.Black
        Me.Label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.TopColor = System.Drawing.Color.Black
        Me.Label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Height = 0.25!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 2.914695!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label27.Text = ": شماره رديف "
        Me.Label27.Top = 0.622375!
        Me.Label27.Width = 0.8061021!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.Black
        Me.Label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.LeftColor = System.Drawing.Color.Black
        Me.Label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.RightColor = System.Drawing.Color.Black
        Me.Label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.TopColor = System.Drawing.Color.Black
        Me.Label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Height = 0.25!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 1.73048!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label28.Text = ": کد"
        Me.Label28.Top = 0.6237205!
        Me.Label28.Width = 0.3444879!
        '
        'txtKalaNO3
        '
        Me.txtKalaNO3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNO3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNO3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO3.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNO3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO3.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNO3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO3.DataField = "paKala.KalaNO"
        Me.txtKalaNO3.Height = 0.2952756!
        Me.txtKalaNO3.Left = 0.1968504!
        Me.txtKalaNO3.Name = "txtKalaNO3"
        Me.txtKalaNO3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNO3.Text = Nothing
        Me.txtKalaNO3.Top = 0.6225394!
        Me.txtKalaNO3.Width = 1.533628!
        '
        'Label29
        '
        Me.Label29.Border.BottomColor = System.Drawing.Color.Black
        Me.Label29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.LeftColor = System.Drawing.Color.Black
        Me.Label29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.RightColor = System.Drawing.Color.Black
        Me.Label29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.TopColor = System.Drawing.Color.Black
        Me.Label29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Height = 0.3125!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 2.995899!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label29.Text = ": نوع جنس "
        Me.Label29.Top = 1.05233!
        Me.Label29.Width = 0.7150598!
        '
        'txtKalaDS3
        '
        Me.txtKalaDS3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaDS3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaDS3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS3.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaDS3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS3.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaDS3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS3.CanGrow = False
        Me.txtKalaDS3.DataField = "paKala.KalaDS"
        Me.txtKalaDS3.Height = 0.4827756!
        Me.txtKalaDS3.Left = 0.164042!
        Me.txtKalaDS3.Name = "txtKalaDS3"
        Me.txtKalaDS3.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; "
        Me.txtKalaDS3.Text = Nothing
        Me.txtKalaDS3.Top = 1.051181!
        Me.txtKalaDS3.Width = 2.82185!
        '
        'Label30
        '
        Me.Label30.Border.BottomColor = System.Drawing.Color.Black
        Me.Label30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.LeftColor = System.Drawing.Color.Black
        Me.Label30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.RightColor = System.Drawing.Color.Black
        Me.Label30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.TopColor = System.Drawing.Color.Black
        Me.Label30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Height = 0.3125!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 1.45817!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label30.Text = ": واحد"
        Me.Label30.Top = 1.740158!
        Me.Label30.Width = 0.4429135!
        '
        'txtVahedeSanjeshDS3
        '
        Me.txtVahedeSanjeshDS3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS3.Border.RightColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS3.Border.TopColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS3.CanGrow = False
        Me.txtVahedeSanjeshDS3.Height = 0.2952756!
        Me.txtVahedeSanjeshDS3.Left = 0.1856956!
        Me.txtVahedeSanjeshDS3.Name = "txtVahedeSanjeshDS3"
        Me.txtVahedeSanjeshDS3.Style = "ddo-char-set: 178; text-align: right; font-size: 13pt; "
        Me.txtVahedeSanjeshDS3.Text = Nothing
        Me.txtVahedeSanjeshDS3.Top = 1.740158!
        Me.txtVahedeSanjeshDS3.Width = 1.273946!
        '
        'Label32
        '
        Me.Label32.Border.BottomColor = System.Drawing.Color.Black
        Me.Label32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.LeftColor = System.Drawing.Color.Black
        Me.Label32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.RightColor = System.Drawing.Color.Black
        Me.Label32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.TopColor = System.Drawing.Color.Black
        Me.Label32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Height = 0.25!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 1.115485!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label32.Text = ": تاريخ"
        Me.Label32.Top = 2.208662!
        Me.Label32.Width = 0.5413384!
        '
        'Label33
        '
        Me.Label33.Border.BottomColor = System.Drawing.Color.Black
        Me.Label33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.LeftColor = System.Drawing.Color.Black
        Me.Label33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.RightColor = System.Drawing.Color.Black
        Me.Label33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.TopColor = System.Drawing.Color.Black
        Me.Label33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Height = 0.25!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 2.65748!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label33.Text = ": شمارشگر"
        Me.Label33.Top = 2.207513!
        Me.Label33.Width = 0.8366139!
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
        Me.Label4.Height = 0.3125!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.1968504!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 16pt; font-f" &
    "amily: Koodak; "
        Me.Label4.Text = "3"
        Me.Label4.Top = 0.1968504!
        Me.Label4.Width = 0.2554135!
        '
        'Shape4
        '
        Me.Shape4.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.RightColor = System.Drawing.Color.Black
        Me.Shape4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.TopColor = System.Drawing.Color.Black
        Me.Shape4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Height = 2.309055!
        Me.Shape4.Left = 0.1574802!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = 9.999999!
        Me.Shape4.Top = 2.667159!
        Me.Shape4.Width = 3.605807!
        '
        'txtSherkat2
        '
        Me.txtSherkat2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSherkat2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSherkat2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat2.Border.RightColor = System.Drawing.Color.Black
        Me.txtSherkat2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat2.Border.TopColor = System.Drawing.Color.Black
        Me.txtSherkat2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat2.CanGrow = False
        Me.txtSherkat2.Height = 0.1934058!
        Me.txtSherkat2.Left = 1.216209!
        Me.txtSherkat2.Name = "txtSherkat2"
        Me.txtSherkat2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" &
    "y: Koodak; "
        Me.txtSherkat2.Text = " "
        Me.txtSherkat2.Top = 2.695866!
        Me.txtSherkat2.Width = 2.531496!
        '
        'Label35
        '
        Me.Label35.Border.BottomColor = System.Drawing.Color.Black
        Me.Label35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.LeftColor = System.Drawing.Color.Black
        Me.Label35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.RightColor = System.Drawing.Color.Black
        Me.Label35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.TopColor = System.Drawing.Color.Black
        Me.Label35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Height = 0.2624665!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 0.3999343!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label35.Text = ": شمارش"
        Me.Label35.Top = 2.723097!
        Me.Label35.Width = 0.604!
        '
        'txtRadif2
        '
        Me.txtRadif2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRadif2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRadif2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif2.Border.RightColor = System.Drawing.Color.Black
        Me.txtRadif2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif2.Border.TopColor = System.Drawing.Color.Black
        Me.txtRadif2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRadif2.Height = 0.2519685!
        Me.txtRadif2.Left = 2.132546!
        Me.txtRadif2.Name = "txtRadif2"
        Me.txtRadif2.Style = "ddo-char-set: 178; text-align: right; font-size: 12pt; "
        Me.txtRadif2.Text = Nothing
        Me.txtRadif2.Top = 3.184547!
        Me.txtRadif2.Width = 0.7621389!
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
        Me.Label36.Height = 0.25!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 2.914696!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label36.Text = ": شماره رديف "
        Me.Label36.Top = 3.184547!
        Me.Label36.Width = 0.8061021!
        '
        'Label37
        '
        Me.Label37.Border.BottomColor = System.Drawing.Color.Black
        Me.Label37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.LeftColor = System.Drawing.Color.Black
        Me.Label37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.RightColor = System.Drawing.Color.Black
        Me.Label37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.TopColor = System.Drawing.Color.Black
        Me.Label37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Height = 0.25!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 1.730481!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label37.Text = ": کد"
        Me.Label37.Top = 3.185532!
        Me.Label37.Width = 0.3444879!
        '
        'txtKalaNo2
        '
        Me.txtKalaNo2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo2.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo2.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNo2.Height = 0.2952756!
        Me.txtKalaNo2.Left = 0.1968504!
        Me.txtKalaNo2.Name = "txtKalaNo2"
        Me.txtKalaNo2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNo2.Text = Nothing
        Me.txtKalaNo2.Top = 3.185532!
        Me.txtKalaNo2.Width = 1.533628!
        '
        'Label38
        '
        Me.Label38.Border.BottomColor = System.Drawing.Color.Black
        Me.Label38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.LeftColor = System.Drawing.Color.Black
        Me.Label38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.RightColor = System.Drawing.Color.Black
        Me.Label38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.TopColor = System.Drawing.Color.Black
        Me.Label38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Height = 0.3125!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 3.0!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label38.Text = ": نوع جنس "
        Me.Label38.Top = 3.5625!
        Me.Label38.Width = 0.7150598!
        '
        'txtKalaDS2
        '
        Me.txtKalaDS2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaDS2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaDS2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS2.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaDS2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS2.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaDS2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS2.CanGrow = False
        Me.txtKalaDS2.DataField = "paKala.KalaDS"
        Me.txtKalaDS2.Height = 0.3125!
        Me.txtKalaDS2.Left = 0.25!
        Me.txtKalaDS2.Name = "txtKalaDS2"
        Me.txtKalaDS2.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; "
        Me.txtKalaDS2.Text = Nothing
        Me.txtKalaDS2.Top = 3.5625!
        Me.txtKalaDS2.Width = 2.75!
        '
        'Label39
        '
        Me.Label39.Border.BottomColor = System.Drawing.Color.Black
        Me.Label39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.LeftColor = System.Drawing.Color.Black
        Me.Label39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.RightColor = System.Drawing.Color.Black
        Me.Label39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.TopColor = System.Drawing.Color.Black
        Me.Label39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Height = 0.3125!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 1.5!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label39.Text = ": واحد"
        Me.Label39.Top = 4.3125!
        Me.Label39.Width = 0.4429135!
        '
        'txtVahedeSanjeshDS2
        '
        Me.txtVahedeSanjeshDS2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS2.Border.RightColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS2.Border.TopColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS2.CanGrow = False
        Me.txtVahedeSanjeshDS2.Height = 0.2952756!
        Me.txtVahedeSanjeshDS2.Left = 0.1875!
        Me.txtVahedeSanjeshDS2.Name = "txtVahedeSanjeshDS2"
        Me.txtVahedeSanjeshDS2.Style = "ddo-char-set: 178; text-align: right; font-size: 13pt; "
        Me.txtVahedeSanjeshDS2.Text = Nothing
        Me.txtVahedeSanjeshDS2.Top = 4.3125!
        Me.txtVahedeSanjeshDS2.Width = 1.27559!
        '
        'Label41
        '
        Me.Label41.Border.BottomColor = System.Drawing.Color.Black
        Me.Label41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.LeftColor = System.Drawing.Color.Black
        Me.Label41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.RightColor = System.Drawing.Color.Black
        Me.Label41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.TopColor = System.Drawing.Color.Black
        Me.Label41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Height = 0.2519685!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 1.122376!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label41.Text = ": تاريخ"
        Me.Label41.Top = 4.708662!
        Me.Label41.Width = 0.5413384!
        '
        'Label42
        '
        Me.Label42.Border.BottomColor = System.Drawing.Color.Black
        Me.Label42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.LeftColor = System.Drawing.Color.Black
        Me.Label42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.RightColor = System.Drawing.Color.Black
        Me.Label42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.TopColor = System.Drawing.Color.Black
        Me.Label42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Height = 0.2519685!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 2.65748!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label42.Text = ": شمارشگر"
        Me.Label42.Top = 4.707186!
        Me.Label42.Width = 0.8366139!
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
        Me.Label43.Height = 0.3125!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.1899607!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 16pt; font-f" &
    "amily: Koodak; "
        Me.Label43.Text = "2"
        Me.Label43.Top = 2.703412!
        Me.Label43.Width = 0.2554135!
        '
        'Shape5
        '
        Me.Shape5.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.RightColor = System.Drawing.Color.Black
        Me.Shape5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.TopColor = System.Drawing.Color.Black
        Me.Shape5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Height = 2.309055!
        Me.Shape5.Left = 0.1574802!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = 9.999999!
        Me.Shape5.Top = 5.176837!
        Me.Shape5.Width = 3.605807!
        '
        'txtSherkat1
        '
        Me.txtSherkat1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSherkat1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSherkat1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSherkat1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSherkat1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat1.CanGrow = False
        Me.txtSherkat1.Height = 0.1934058!
        Me.txtSherkat1.Left = 1.21621!
        Me.txtSherkat1.Name = "txtSherkat1"
        Me.txtSherkat1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" &
    "y: Koodak; "
        Me.txtSherkat1.Text = " "
        Me.txtSherkat1.Top = 5.205543!
        Me.txtSherkat1.Width = 2.531496!
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
        Me.txtRadif.Height = 0.2519685!
        Me.txtRadif.Left = 2.125!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: right; font-size: 12pt; "
        Me.txtRadif.Text = Nothing
        Me.txtRadif.Top = 5.625!
        Me.txtRadif.Width = 0.7624667!
        '
        'Label46
        '
        Me.Label46.Border.BottomColor = System.Drawing.Color.Black
        Me.Label46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.LeftColor = System.Drawing.Color.Black
        Me.Label46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.RightColor = System.Drawing.Color.Black
        Me.Label46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.TopColor = System.Drawing.Color.Black
        Me.Label46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Height = 0.25!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 2.9375!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label46.Text = ": شماره رديف "
        Me.Label46.Top = 5.625!
        Me.Label46.Width = 0.8061021!
        '
        'Label47
        '
        Me.Label47.Border.BottomColor = System.Drawing.Color.Black
        Me.Label47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.LeftColor = System.Drawing.Color.Black
        Me.Label47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.RightColor = System.Drawing.Color.Black
        Me.Label47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.TopColor = System.Drawing.Color.Black
        Me.Label47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Height = 0.25!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 1.6875!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label47.Text = ": کد"
        Me.Label47.Top = 5.625!
        Me.Label47.Width = 0.2819879!
        '
        'txtkalano
        '
        Me.txtkalano.Border.BottomColor = System.Drawing.Color.Black
        Me.txtkalano.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtkalano.Border.LeftColor = System.Drawing.Color.Black
        Me.txtkalano.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtkalano.Border.RightColor = System.Drawing.Color.Black
        Me.txtkalano.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtkalano.Border.TopColor = System.Drawing.Color.Black
        Me.txtkalano.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtkalano.DataField = "paKala.KalaNO"
        Me.txtkalano.Height = 0.2952756!
        Me.txtkalano.Left = 0.1875!
        Me.txtkalano.Name = "txtkalano"
        Me.txtkalano.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtkalano.Text = Nothing
        Me.txtkalano.Top = 5.625!
        Me.txtkalano.Width = 1.471125!
        '
        'Label48
        '
        Me.Label48.Border.BottomColor = System.Drawing.Color.Black
        Me.Label48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.LeftColor = System.Drawing.Color.Black
        Me.Label48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.RightColor = System.Drawing.Color.Black
        Me.Label48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.TopColor = System.Drawing.Color.Black
        Me.Label48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Height = 0.3125!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 2.995897!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label48.Text = ": نوع جنس "
        Me.Label48.Top = 6.051263!
        Me.Label48.Width = 0.7150598!
        '
        'txtKalaDS
        '
        Me.txtKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaDS.CanGrow = False
        Me.txtKalaDS.Height = 0.4202756!
        Me.txtKalaDS.Left = 0.25!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; "
        Me.txtKalaDS.Text = Nothing
        Me.txtKalaDS.Top = 6.0!
        Me.txtKalaDS.Width = 2.739665!
        '
        'Label49
        '
        Me.Label49.Border.BottomColor = System.Drawing.Color.Black
        Me.Label49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label49.Border.LeftColor = System.Drawing.Color.Black
        Me.Label49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label49.Border.RightColor = System.Drawing.Color.Black
        Me.Label49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label49.Border.TopColor = System.Drawing.Color.Black
        Me.Label49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label49.Height = 0.3125!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 1.458168!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label49.Text = ": واحد"
        Me.Label49.Top = 6.877871!
        Me.Label49.Width = 0.4429135!
        '
        'txtVahedeSanjeshDS
        '
        Me.txtVahedeSanjeshDS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS.Border.RightColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS.Border.TopColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDS.CanGrow = False
        Me.txtVahedeSanjeshDS.Height = 0.2952756!
        Me.txtVahedeSanjeshDS.Left = 0.1837235!
        Me.txtVahedeSanjeshDS.Name = "txtVahedeSanjeshDS"
        Me.txtVahedeSanjeshDS.Style = "ddo-char-set: 178; text-align: right; font-size: 13pt; "
        Me.txtVahedeSanjeshDS.Text = Nothing
        Me.txtVahedeSanjeshDS.Top = 6.877871!
        Me.txtVahedeSanjeshDS.Width = 1.27559!
        '
        'Label51
        '
        Me.Label51.Border.BottomColor = System.Drawing.Color.Black
        Me.Label51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.LeftColor = System.Drawing.Color.Black
        Me.Label51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.RightColor = System.Drawing.Color.Black
        Me.Label51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.TopColor = System.Drawing.Color.Black
        Me.Label51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Height = 0.2519685!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 1.115485!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label51.Text = ": تاريخ"
        Me.Label51.Top = 7.220472!
        Me.Label51.Width = 0.5413384!
        '
        'Label52
        '
        Me.Label52.Border.BottomColor = System.Drawing.Color.Black
        Me.Label52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.LeftColor = System.Drawing.Color.Black
        Me.Label52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.RightColor = System.Drawing.Color.Black
        Me.Label52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.TopColor = System.Drawing.Color.Black
        Me.Label52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Height = 0.2519685!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 2.683397!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label52.Text = ": شمارشگر"
        Me.Label52.Top = 7.220306!
        Me.Label52.Width = 0.8366139!
        '
        'Label53
        '
        Me.Label53.Border.BottomColor = System.Drawing.Color.Black
        Me.Label53.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.LeftColor = System.Drawing.Color.Black
        Me.Label53.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.RightColor = System.Drawing.Color.Black
        Me.Label53.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.TopColor = System.Drawing.Color.Black
        Me.Label53.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Height = 0.3125!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 0.1937304!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 16pt; font-f" &
    "amily: Koodak; "
        Me.Label53.Text = "1"
        Me.Label53.Top = 5.203084!
        Me.Label53.Width = 0.2554135!
        '
        'Label54
        '
        Me.Label54.Border.BottomColor = System.Drawing.Color.Black
        Me.Label54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.LeftColor = System.Drawing.Color.Black
        Me.Label54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.RightColor = System.Drawing.Color.Black
        Me.Label54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.TopColor = System.Drawing.Color.Black
        Me.Label54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Height = 0.3125!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 2.723097!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label54.Text = ": مقدار شمارش"
        Me.Label54.Top = 6.876232!
        Me.Label54.Width = 0.9678479!
        '
        'Label55
        '
        Me.Label55.Border.BottomColor = System.Drawing.Color.Black
        Me.Label55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.LeftColor = System.Drawing.Color.Black
        Me.Label55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.RightColor = System.Drawing.Color.Black
        Me.Label55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.TopColor = System.Drawing.Color.Black
        Me.Label55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Height = 0.3125!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 2.75!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label55.Text = ": مقدار شمارش"
        Me.Label55.Top = 4.3125!
        Me.Label55.Width = 0.9678479!
        '
        'Label56
        '
        Me.Label56.Border.BottomColor = System.Drawing.Color.Black
        Me.Label56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.LeftColor = System.Drawing.Color.Black
        Me.Label56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.RightColor = System.Drawing.Color.Black
        Me.Label56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.TopColor = System.Drawing.Color.Black
        Me.Label56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Height = 0.3125!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 2.755905!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 13pt; font-fa" &
    "mily: Koodak; "
        Me.Label56.Text = ": مقدار شمارش"
        Me.Label56.Top = 1.741962!
        Me.Label56.Width = 0.9678479!
        '
        'Label57
        '
        Me.Label57.Border.BottomColor = System.Drawing.Color.Black
        Me.Label57.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.LeftColor = System.Drawing.Color.Black
        Me.Label57.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.RightColor = System.Drawing.Color.Black
        Me.Label57.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.TopColor = System.Drawing.Color.Black
        Me.Label57.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Height = 0.2624665!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.3999344!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label57.Text = ": شمارش"
        Me.Label57.Top = 0.2296588!
        Me.Label57.Width = 0.604!
        '
        'Label58
        '
        Me.Label58.Border.BottomColor = System.Drawing.Color.Black
        Me.Label58.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.LeftColor = System.Drawing.Color.Black
        Me.Label58.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.RightColor = System.Drawing.Color.Black
        Me.Label58.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.TopColor = System.Drawing.Color.Black
        Me.Label58.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Height = 0.2624665!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 0.3999344!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 12pt; font-fa" &
    "mily: Koodak; "
        Me.Label58.Text = ": شمارش"
        Me.Label58.Top = 5.219653!
        Me.Label58.Width = 0.604!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.3125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 3.229167!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" &
    "-family: Koodak; "
        Me.Label12.Text = ": محل"
        Me.Label12.Top = 3.927083!
        Me.Label12.Width = 0.4429135!
        '
        'txtChidemanNo
        '
        Me.txtChidemanNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChidemanNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChidemanNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtChidemanNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtChidemanNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo.DataField = "ChidemanNo"
        Me.txtChidemanNo.Height = 0.3125!
        Me.txtChidemanNo.Left = 0.25!
        Me.txtChidemanNo.Name = "txtChidemanNo"
        Me.txtChidemanNo.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtChidemanNo.Text = Nothing
        Me.txtChidemanNo.Top = 3.9375!
        Me.txtChidemanNo.Width = 2.9375!
        '
        'RptTagAnbarGardanikhoram
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0!
        Me.PageSettings.Margins.Left = 0.03958333!
        Me.PageSettings.Margins.Right = 0!
        Me.PageSettings.Margins.Top = 0!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 11.42708!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.txtSherkat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkalano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChidemanNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي
        'txtTedadDarKarton.DataField = "TedadAjza"
        txtKalaNO.DataField = "KalaNO"
        txtKalaDS.DataField = "KalaDS"
        txtKalaNO2.DataField = "KalaNO"
        txtKalaDS2.DataField = "KalaDS"
        txtKalaNO3.DataField = "KalaNO"
        txtKalaDS3.DataField = "KalaDS"
        txtVahedeSanjeshDS.DataField = "VahedeSanjeshDS"
        txtVahedeSanjeshDS2.DataField = "VahedeSanjeshDS"
        txtVahedeSanjeshDS3.DataField = "VahedeSanjeshDS"
        'txtshomarehrahgiri.DataField = "shomarehrahgiri"
        'txtShomarehRahgiri2.DataField = "shomarehrahgiri"
        'txtshomarehrahgiri3.DataField = "shomarehrahgiri"
        ' .DataField = ""
        vRadif = 0
    End Sub

    Private Sub Detail_BeforePrint (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
        vRadif = vRadif + 1
        txtRadif.Text = vRadif
        txtRadif2.Text = vRadif
        txtRadif3.Text = vRadif

    End Sub

    Private Sub RptTagAnbarGardaniKhoram_ReportStart (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.ReportStart
        vRadif = 0
    End Sub
End Class
