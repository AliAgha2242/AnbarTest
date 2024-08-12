Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptTagAnbarGardaniGhasem
    Inherits ActiveReport3
    Dim vRadif As Integer
    Public txtSal As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSal2 As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSal3 As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSherkat2 As DataDynamics.ActiveReports.TextBox = Nothing
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label

    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label

    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Public txtSherkat3 As DataDynamics.ActiveReports.TextBox = Nothing
    'Public txtShomareshNO As DataDynamics.ActiveReports.TextBox = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
    Private txtKalaNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTedadAjza As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVahedeSanjeshDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNO2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVahedeSanjeshDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNO3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtChidemanNo As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtChidemanNo2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtChidemanNo3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private TxtEnghezaDate1 As DataDynamics.ActiveReports.TextBox = Nothing
    Private TxtEnghezaDate2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private TxtEnghezaDate3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label4 As DataDynamics.ActiveReports.Label = Nothing
    Private Label7 As DataDynamics.ActiveReports.Label = Nothing
    Private Label8 As DataDynamics.ActiveReports.Label = Nothing
    Private Label9 As DataDynamics.ActiveReports.Label = Nothing
    Private Label10 As DataDynamics.ActiveReports.Label = Nothing
    Private Label11 As DataDynamics.ActiveReports.Label = Nothing
    Private Label12 As DataDynamics.ActiveReports.Label = Nothing
    Private Label15 As DataDynamics.ActiveReports.Label = Nothing
    Private Label16 As DataDynamics.ActiveReports.Label = Nothing
    Private Label17 As DataDynamics.ActiveReports.Label = Nothing
    Private Label18 As DataDynamics.ActiveReports.Label = Nothing
    Private Label19 As DataDynamics.ActiveReports.Label = Nothing
    Private Label20 As DataDynamics.ActiveReports.Label = Nothing
    Private Label21 As DataDynamics.ActiveReports.Label = Nothing
    Private Label22 As DataDynamics.ActiveReports.Label = Nothing
    Private Label23 As DataDynamics.ActiveReports.Label = Nothing
    Private Label24 As DataDynamics.ActiveReports.Label = Nothing
    Private Label25 As DataDynamics.ActiveReports.Label = Nothing
    Private Label26 As DataDynamics.ActiveReports.Label = Nothing
    Private Label27 As DataDynamics.ActiveReports.Label = Nothing
    Private Label28 As DataDynamics.ActiveReports.Label = Nothing
    Private Label29 As DataDynamics.ActiveReports.Label = Nothing
    Private Label30 As DataDynamics.ActiveReports.Label = Nothing
    Private Label31 As DataDynamics.ActiveReports.Label = Nothing
    Private Label32 As DataDynamics.ActiveReports.Label = Nothing
    Private Label33 As DataDynamics.ActiveReports.Label = Nothing
    Private Label34 As DataDynamics.ActiveReports.Label = Nothing
    'Private txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing
    'Private txtSal As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label36 As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDS As DataDynamics.ActiveReports.TextBox = Nothing
    'Private txtSherkat2 As DataDynamics.ActiveReports.TextBox = Nothing
    'Private txtSal2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label37 As DataDynamics.ActiveReports.Label = Nothing
    'Private txtSherkat3 As DataDynamics.ActiveReports.TextBox = Nothing
    'Private txtSal3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label38 As DataDynamics.ActiveReports.Label = Nothing
    Private txtTedadAjza2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTedadAjza3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label39 As DataDynamics.ActiveReports.Label = Nothing
    Private txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label40 As DataDynamics.ActiveReports.Label = Nothing
    Private txtShomarehRahgiri2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label41 As DataDynamics.ActiveReports.Label = Nothing
    Private txtShomarehRahgiri3 As DataDynamics.ActiveReports.TextBox = Nothing

    Private Sub InitializeComponent()
        Dim SqlDBDataSource1 As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = New DataDynamics.ActiveReports.DataSources.SqlDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptTagAnbarGardaniGhasem))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtKalaNO = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox()
        Me.txtTedadAjza = New DataDynamics.ActiveReports.TextBox()
        Me.txtVahedeSanjeshDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNO2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtVahedeSanjeshDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNO3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtChidemanNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtChidemanNo2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtChidemanNo3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.Label27 = New DataDynamics.ActiveReports.Label()
        Me.Label28 = New DataDynamics.ActiveReports.Label()
        Me.Label29 = New DataDynamics.ActiveReports.Label()
        Me.Label30 = New DataDynamics.ActiveReports.Label()
        Me.Label31 = New DataDynamics.ActiveReports.Label()
        Me.Label32 = New DataDynamics.ActiveReports.Label()
        Me.Label33 = New DataDynamics.ActiveReports.Label()
        Me.Label34 = New DataDynamics.ActiveReports.Label()
        Me.txtSherkat = New DataDynamics.ActiveReports.TextBox()
        Me.txtSal = New DataDynamics.ActiveReports.TextBox()
        Me.Label36 = New DataDynamics.ActiveReports.Label()
        Me.txtVahedeSanjeshDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtSherkat2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSal2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label37 = New DataDynamics.ActiveReports.Label()
        Me.txtSherkat3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSal3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label38 = New DataDynamics.ActiveReports.Label()
        Me.txtTedadAjza2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTedadAjza3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label39 = New DataDynamics.ActiveReports.Label()
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox()
        Me.Label40 = New DataDynamics.ActiveReports.Label()
        Me.txtShomarehRahgiri2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label41 = New DataDynamics.ActiveReports.Label()
        Me.txtShomarehRahgiri3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.TxtEnghezaDate1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TxtEnghezaDate2 = New DataDynamics.ActiveReports.TextBox()
        Me.TxtEnghezaDate3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.txtKalaNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChidemanNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChidemanNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChidemanNo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadAjza2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadAjza3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShomarehRahgiri3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEnghezaDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEnghezaDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEnghezaDate3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.CanGrow = False
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtKalaNO, Me.txtKalaDS, Me.txtRadif, Me.txtTedadAjza, Me.txtVahedeSanjeshDS2, Me.txtKalaDS2, Me.txtRadif2, Me.txtKalaNO2, Me.txtVahedeSanjeshDS3, Me.txtKalaDS3, Me.txtRadif3, Me.txtKalaNO3, Me.txtChidemanNo, Me.txtChidemanNo2, Me.txtChidemanNo3, Me.Label4, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.txtSherkat, Me.txtSal, Me.Label36, Me.txtVahedeSanjeshDS, Me.txtSherkat2, Me.txtSal2, Me.Label37, Me.txtSherkat3, Me.txtSal3, Me.Label38, Me.txtTedadAjza2, Me.txtTedadAjza3, Me.Label39, Me.txtShomarehRahgiri, Me.Label40, Me.txtShomarehRahgiri2, Me.Label41, Me.txtShomarehRahgiri3, Me.Label1, Me.TxtEnghezaDate1, Me.Label2, Me.TxtEnghezaDate2, Me.TxtEnghezaDate3, Me.Label3})
        Me.Detail.Height = 11.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txtKalaNO
        '
        Me.txtKalaNO.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO.DataField = "paKala.KalaNO"
        Me.txtKalaNO.Height = 0.2952756!
        Me.txtKalaNO.Left = 4.0!
        Me.txtKalaNO.Name = "txtKalaNO"
        Me.txtKalaNO.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaNO.Text = Nothing
        Me.txtKalaNO.Top = 1.3125!
        Me.txtKalaNO.Width = 2.031742!
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
        Me.txtKalaDS.DataField = "paKala.KalaDS"
        Me.txtKalaDS.Height = 0.2952756!
        Me.txtKalaDS.Left = 0.6535423!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaDS.Text = Nothing
        Me.txtKalaDS.Top = 1.831816!
        Me.txtKalaDS.Width = 7.086611!
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
        Me.txtRadif.Height = 0.2952756!
        Me.txtRadif.Left = 6.5625!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif.Text = Nothing
        Me.txtRadif.Top = 1.3125!
        Me.txtRadif.Width = 1.181102!
        '
        'txtTedadAjza
        '
        Me.txtTedadAjza.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadAjza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza.CanGrow = False
        Me.txtTedadAjza.DataField = "TedadAjza"
        Me.txtTedadAjza.Height = 0.2952756!
        Me.txtTedadAjza.Left = 7.105313!
        Me.txtTedadAjza.Name = "txtTedadAjza"
        Me.txtTedadAjza.Style = "ddo-char-set: 178; text-align: center; font-size: 15.75pt; "
        Me.txtTedadAjza.Text = Nothing
        Me.txtTedadAjza.Top = 2.26378!
        Me.txtTedadAjza.Width = 0.634842!
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
        Me.txtVahedeSanjeshDS2.DataField = "paVw_VahedeSanjesh"
        Me.txtVahedeSanjeshDS2.Height = 0.2952756!
        Me.txtVahedeSanjeshDS2.Left = 5.3125!
        Me.txtVahedeSanjeshDS2.Name = "txtVahedeSanjeshDS2"
        Me.txtVahedeSanjeshDS2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS2.Text = Nothing
        Me.txtVahedeSanjeshDS2.Top = 5.4375!
        Me.txtVahedeSanjeshDS2.Width = 1.697342!
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
        Me.txtKalaDS2.Left = 0.625!
        Me.txtKalaDS2.Name = "txtKalaDS2"
        Me.txtKalaDS2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaDS2.Text = Nothing
        Me.txtKalaDS2.Top = 5.0625!
        Me.txtKalaDS2.Width = 7.0625!
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
        Me.txtRadif2.Height = 0.2952756!
        Me.txtRadif2.Left = 6.5625!
        Me.txtRadif2.Name = "txtRadif2"
        Me.txtRadif2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif2.Text = Nothing
        Me.txtRadif2.Top = 4.6875!
        Me.txtRadif2.Width = 1.181102!
        '
        'txtKalaNO2
        '
        Me.txtKalaNO2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtKalaNO2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtKalaNO2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO2.Border.RightColor = System.Drawing.Color.Black
        Me.txtKalaNO2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO2.Border.TopColor = System.Drawing.Color.Black
        Me.txtKalaNO2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtKalaNO2.DataField = "paKala.KalaNO"
        Me.txtKalaNO2.Height = 0.2952756!
        Me.txtKalaNO2.Left = 3.6875!
        Me.txtKalaNO2.Name = "txtKalaNO2"
        Me.txtKalaNO2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaNO2.Text = Nothing
        Me.txtKalaNO2.Top = 4.6875!
        Me.txtKalaNO2.Width = 2.016117!
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
        Me.txtVahedeSanjeshDS3.DataField = "paVw_VahedeSanjesh"
        Me.txtVahedeSanjeshDS3.Height = 0.2952756!
        Me.txtVahedeSanjeshDS3.Left = 5.317913!
        Me.txtVahedeSanjeshDS3.Name = "txtVahedeSanjeshDS3"
        Me.txtVahedeSanjeshDS3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS3.Text = Nothing
        Me.txtVahedeSanjeshDS3.Top = 8.909125!
        Me.txtVahedeSanjeshDS3.Width = 1.697342!
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
        Me.txtKalaDS3.Height = 0.3125!
        Me.txtKalaDS3.Left = 0.6875!
        Me.txtKalaDS3.Name = "txtKalaDS3"
        Me.txtKalaDS3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaDS3.Text = Nothing
        Me.txtKalaDS3.Top = 8.5625!
        Me.txtKalaDS3.Width = 7.0!
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
        Me.txtRadif3.Height = 0.2952756!
        Me.txtRadif3.Left = 6.5625!
        Me.txtRadif3.Name = "txtRadif3"
        Me.txtRadif3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif3.Text = Nothing
        Me.txtRadif3.Top = 8.229167!
        Me.txtRadif3.Width = 1.181102!
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
        Me.txtKalaNO3.Left = 4.0!
        Me.txtKalaNO3.Name = "txtKalaNO3"
        Me.txtKalaNO3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtKalaNO3.Text = Nothing
        Me.txtKalaNO3.Top = 8.25!
        Me.txtKalaNO3.Width = 2.031742!
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
        Me.txtChidemanNo.DataField = "paKala.KalaNO"
        Me.txtChidemanNo.Height = 0.2952756!
        Me.txtChidemanNo.Left = 0.7076771!
        Me.txtChidemanNo.Name = "txtChidemanNo"
        Me.txtChidemanNo.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtChidemanNo.Text = Nothing
        Me.txtChidemanNo.Top = 2.26378!
        Me.txtChidemanNo.Width = 3.937008!
        '
        'txtChidemanNo2
        '
        Me.txtChidemanNo2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChidemanNo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChidemanNo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo2.Border.RightColor = System.Drawing.Color.Black
        Me.txtChidemanNo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo2.Border.TopColor = System.Drawing.Color.Black
        Me.txtChidemanNo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo2.DataField = "paKala.KalaNO"
        Me.txtChidemanNo2.Height = 0.2952756!
        Me.txtChidemanNo2.Left = 0.625!
        Me.txtChidemanNo2.Name = "txtChidemanNo2"
        Me.txtChidemanNo2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtChidemanNo2.Text = Nothing
        Me.txtChidemanNo2.Top = 5.4375!
        Me.txtChidemanNo2.Width = 3.937008!
        '
        'txtChidemanNo3
        '
        Me.txtChidemanNo3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChidemanNo3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChidemanNo3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo3.Border.RightColor = System.Drawing.Color.Black
        Me.txtChidemanNo3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo3.Border.TopColor = System.Drawing.Color.Black
        Me.txtChidemanNo3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChidemanNo3.DataField = "paKala.KalaNO"
        Me.txtChidemanNo3.Height = 0.25!
        Me.txtChidemanNo3.Left = 0.6875!
        Me.txtChidemanNo3.Name = "txtChidemanNo3"
        Me.txtChidemanNo3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtChidemanNo3.Text = Nothing
        Me.txtChidemanNo3.Top = 8.9375!
        Me.txtChidemanNo3.Width = 3.9375!
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
        Me.Label4.Height = 0.4702264!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.714075!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 24pt; font-f" & _
            "amily: Koodak; "
        Me.Label4.Text = "3"
        Me.Label4.Top = 0.2843258!
        Me.Label4.Width = 0.4429135!
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
        Me.Label7.Height = 0.3577756!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 7.543306!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 14pt; font-fami" & _
            "ly: Koodak; "
        Me.Label7.Text = "برگ روي جنس"
        Me.Label7.Top = 0.2843258!
        Me.Label7.Width = 1.476379!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.2952756!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 7.8125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label8.Text = ": شماره رديف "
        Me.Label8.Top = 1.3125!
        Me.Label8.Width = 1.181102!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.3125!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 7.838583!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label9.Text = ": کالا"
        Me.Label9.Top = 1.831816!
        Me.Label9.Width = 1.181102!
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
        Me.Label10.Height = 0.2952756!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.0625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label10.Text = ": کد"
        Me.Label10.Top = 1.3125!
        Me.Label10.Width = 0.4429135!
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
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 7.889271!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label11.Text = ":تعداد در کارتن "
        Me.Label11.Top = 2.26378!
        Me.Label11.Width = 1.130414!
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
        Me.Label12.Left = 4.733391!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label12.Text = ": محل"
        Me.Label12.Top = 2.26378!
        Me.Label12.Width = 0.4429135!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.4702264!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.6875!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 24pt; font-fam" & _
            "ily: Koodak; "
        Me.Label15.Text = "2"
        Me.Label15.Top = 3.625!
        Me.Label15.Width = 0.4429135!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.3125!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 5.875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label16.Text = ": کد"
        Me.Label16.Top = 4.6875!
        Me.Label16.Width = 0.3444879!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.3125!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 7.822958!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 14pt; font-fami" & _
            "ly: Koodak; "
        Me.Label17.Text = "شمارش دوم"
        Me.Label17.Top = 3.888165!
        Me.Label17.Width = 1.181102!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.3125!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 7.8125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label18.Text = ": شماره رديف "
        Me.Label18.Top = 4.6875!
        Me.Label18.Width = 1.181102!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.3125!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 7.8125!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label19.Text = ": کالا"
        Me.Label19.Top = 5.0625!
        Me.Label19.Width = 1.181102!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.2952756!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 7.875!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label20.Text = ":تعداد در کارتن "
        Me.Label20.Top = 5.4375!
        Me.Label20.Width = 1.130414!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.2952756!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 4.6875!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label21.Text = ": محل"
        Me.Label21.Top = 5.4375!
        Me.Label21.Width = 0.5!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Height = 0.3125!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4.619341!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label22.Text = ": امضا"
        Me.Label22.Top = 5.769562!
        Me.Label22.Width = 0.5413384!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.RightColor = System.Drawing.Color.Black
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.TopColor = System.Drawing.Color.Black
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Height = 0.3125!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 7.873646!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label23.Text = ": شمارشگر"
        Me.Label23.Top = 5.769562!
        Me.Label23.Width = 1.130414!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Height = 0.4702264!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 1.6875!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 24pt; font-fam" & _
            "ily: Koodak; "
        Me.Label24.Text = "1"
        Me.Label24.Top = 7.3125!
        Me.Label24.Width = 0.4429135!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.Black
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.LeftColor = System.Drawing.Color.Black
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.RightColor = System.Drawing.Color.Black
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.TopColor = System.Drawing.Color.Black
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Height = 0.2952756!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 6.125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label25.Text = ": کد"
        Me.Label25.Top = 8.25!
        Me.Label25.Width = 0.3444879!
        '
        'Label26
        '
        Me.Label26.Border.BottomColor = System.Drawing.Color.Black
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.LeftColor = System.Drawing.Color.Black
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.RightColor = System.Drawing.Color.Black
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.TopColor = System.Drawing.Color.Black
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Height = 0.3125!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 7.838583!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 14pt; font-fami" & _
            "ly: Koodak; "
        Me.Label26.Text = "شمارش اول"
        Me.Label26.Top = 7.3125!
        Me.Label26.Width = 1.181102!
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
        Me.Label27.Height = 0.2952756!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 7.8125!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label27.Text = ": شماره رديف "
        Me.Label27.Top = 8.229167!
        Me.Label27.Width = 1.181102!
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
        Me.Label28.Height = 0.3125!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 7.8125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label28.Text = ": کالا"
        Me.Label28.Top = 8.5625!
        Me.Label28.Width = 1.181102!
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
        Me.Label29.Height = 0.2952756!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 7.889271!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label29.Text = ":تعداد در کارتن "
        Me.Label29.Top = 8.909125!
        Me.Label29.Width = 1.130414!
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
        Me.Label30.Height = 0.2952756!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 4.733391!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label30.Text = ": محل"
        Me.Label30.Top = 8.909125!
        Me.Label30.Width = 0.4429135!
        '
        'Label31
        '
        Me.Label31.Border.BottomColor = System.Drawing.Color.Black
        Me.Label31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.LeftColor = System.Drawing.Color.Black
        Me.Label31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.RightColor = System.Drawing.Color.Black
        Me.Label31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.TopColor = System.Drawing.Color.Black
        Me.Label31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Height = 0.3125!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 4.634966!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label31.Text = ": امضا"
        Me.Label31.Top = 9.245694!
        Me.Label31.Width = 0.5413384!
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
        Me.Label32.Height = 0.3125!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 7.889271!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label32.Text = ": شمارشگر"
        Me.Label32.Top = 9.245694!
        Me.Label32.Width = 1.130414!
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
        Me.Label33.Height = 0.3125!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 7.873646!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label33.Text = ": تعداد شمارش"
        Me.Label33.Top = 6.117987!
        Me.Label33.Width = 1.130414!
        '
        'Label34
        '
        Me.Label34.Border.BottomColor = System.Drawing.Color.Black
        Me.Label34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.LeftColor = System.Drawing.Color.Black
        Me.Label34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.RightColor = System.Drawing.Color.Black
        Me.Label34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.TopColor = System.Drawing.Color.Black
        Me.Label34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Height = 0.3125!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 7.889271!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label34.Text = ": تعداد شمارش"
        Me.Label34.Top = 9.648869!
        Me.Label34.Width = 1.130414!
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
        Me.txtSherkat.Height = 0.3132382!
        Me.txtSherkat.Left = 3.061372!
        Me.txtSherkat.Name = "txtSherkat"
        Me.txtSherkat.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; font-fam" & _
            "ily: Tahoma; "
        Me.txtSherkat.Text = Nothing
        Me.txtSherkat.Top = 0.1742126!
        Me.txtSherkat.Width = 4.221006!
        '
        'txtSal
        '
        Me.txtSal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal.Border.RightColor = System.Drawing.Color.Black
        Me.txtSal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal.Border.TopColor = System.Drawing.Color.Black
        Me.txtSal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal.Height = 0.3366142!
        Me.txtSal.Left = 3.27436!
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.txtSal.Text = Nothing
        Me.txtSal.Top = 0.5492126!
        Me.txtSal.Width = 0.9610395!
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
        Me.Label36.Height = 0.3218504!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 4.235359!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.Label36.Text = "انبار گرداني پايان سال مالي "
        Me.Label36.Top = 0.5492126!
        Me.Label36.Width = 2.297859!
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
        Me.txtVahedeSanjeshDS.DataField = "paVw_VahedeSanjesh"
        Me.txtVahedeSanjeshDS.Height = 0.2952756!
        Me.txtVahedeSanjeshDS.Left = 5.317913!
        Me.txtVahedeSanjeshDS.Name = "txtVahedeSanjeshDS"
        Me.txtVahedeSanjeshDS.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS.Text = Nothing
        Me.txtVahedeSanjeshDS.Top = 2.26378!
        Me.txtVahedeSanjeshDS.Width = 1.697342!
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
        Me.txtSherkat2.Height = 0.3132382!
        Me.txtSherkat2.Left = 3.061372!
        Me.txtSherkat2.Name = "txtSherkat2"
        Me.txtSherkat2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; font-fam" & _
            "ily: Tahoma; "
        Me.txtSherkat2.Text = Nothing
        Me.txtSherkat2.Top = 3.657357!
        Me.txtSherkat2.Width = 4.221006!
        '
        'txtSal2
        '
        Me.txtSal2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSal2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSal2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal2.Border.RightColor = System.Drawing.Color.Black
        Me.txtSal2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal2.Border.TopColor = System.Drawing.Color.Black
        Me.txtSal2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal2.Height = 0.3366142!
        Me.txtSal2.Left = 3.27436!
        Me.txtSal2.Name = "txtSal2"
        Me.txtSal2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.txtSal2.Text = Nothing
        Me.txtSal2.Top = 4.044857!
        Me.txtSal2.Width = 0.9610395!
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
        Me.Label37.Height = 0.3218504!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 4.235359!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.Label37.Text = "انبار گرداني پايان سال مالي "
        Me.Label37.Top = 4.044857!
        Me.Label37.Width = 2.297859!
        '
        'txtSherkat3
        '
        Me.txtSherkat3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSherkat3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSherkat3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat3.Border.RightColor = System.Drawing.Color.Black
        Me.txtSherkat3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat3.Border.TopColor = System.Drawing.Color.Black
        Me.txtSherkat3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSherkat3.CanGrow = False
        Me.txtSherkat3.Height = 0.3132382!
        Me.txtSherkat3.Left = 3.061372!
        Me.txtSherkat3.Name = "txtSherkat3"
        Me.txtSherkat3.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; font-fam" & _
            "ily: Tahoma; "
        Me.txtSherkat3.Text = Nothing
        Me.txtSherkat3.Top = 7.3125!
        Me.txtSherkat3.Width = 4.221006!
        '
        'txtSal3
        '
        Me.txtSal3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSal3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSal3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal3.Border.RightColor = System.Drawing.Color.Black
        Me.txtSal3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal3.Border.TopColor = System.Drawing.Color.Black
        Me.txtSal3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSal3.Height = 0.3366142!
        Me.txtSal3.Left = 3.6875!
        Me.txtSal3.Name = "txtSal3"
        Me.txtSal3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.txtSal3.Text = Nothing
        Me.txtSal3.Top = 7.6875!
        Me.txtSal3.Width = 0.9610395!
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
        Me.Label38.Height = 0.3218504!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 4.6875!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 12pt; font-fami" & _
            "ly: Tahoma; "
        Me.Label38.Text = "انبار گرداني پايان سال مالي "
        Me.Label38.Top = 7.6875!
        Me.Label38.Width = 2.297859!
        '
        'txtTedadAjza2
        '
        Me.txtTedadAjza2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadAjza2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadAjza2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza2.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadAjza2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza2.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadAjza2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza2.CanGrow = False
        Me.txtTedadAjza2.DataField = "TedadAjza"
        Me.txtTedadAjza2.Height = 0.2952756!
        Me.txtTedadAjza2.Left = 7.0625!
        Me.txtTedadAjza2.Name = "txtTedadAjza2"
        Me.txtTedadAjza2.Style = "ddo-char-set: 178; text-align: center; font-size: 15.75pt; "
        Me.txtTedadAjza2.Text = Nothing
        Me.txtTedadAjza2.Top = 5.4375!
        Me.txtTedadAjza2.Width = 0.634842!
        '
        'txtTedadAjza3
        '
        Me.txtTedadAjza3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadAjza3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadAjza3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza3.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadAjza3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza3.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadAjza3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadAjza3.CanGrow = False
        Me.txtTedadAjza3.DataField = "TedadAjza"
        Me.txtTedadAjza3.Height = 0.2952756!
        Me.txtTedadAjza3.Left = 7.105313!
        Me.txtTedadAjza3.Name = "txtTedadAjza3"
        Me.txtTedadAjza3.Style = "ddo-char-set: 178; text-align: center; font-size: 15.75pt; "
        Me.txtTedadAjza3.Text = Nothing
        Me.txtTedadAjza3.Top = 8.909125!
        Me.txtTedadAjza3.Width = 0.634842!
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
        Me.Label39.Left = 2.625!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label39.Text = ": رهگیری"
        Me.Label39.Top = 1.0625!
        Me.Label39.Width = 1.3125!
        '
        'txtShomarehRahgiri
        '
        Me.txtShomarehRahgiri.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri.DataField = "paKala.KalaNO"
        Me.txtShomarehRahgiri.Height = 0.3125!
        Me.txtShomarehRahgiri.Left = 0.75!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtShomarehRahgiri.Text = Nothing
        Me.txtShomarehRahgiri.Top = 1.0625!
        Me.txtShomarehRahgiri.Width = 1.8125!
        '
        'Label40
        '
        Me.Label40.Border.BottomColor = System.Drawing.Color.Black
        Me.Label40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.LeftColor = System.Drawing.Color.Black
        Me.Label40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.RightColor = System.Drawing.Color.Black
        Me.Label40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.TopColor = System.Drawing.Color.Black
        Me.Label40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Height = 0.3125!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 2.25!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label40.Text = ": رهگیری"
        Me.Label40.Top = 4.3125!
        Me.Label40.Width = 0.9798229!
        '
        'txtShomarehRahgiri2
        '
        Me.txtShomarehRahgiri2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri2.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri2.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri2.DataField = "paKala.KalaNO"
        Me.txtShomarehRahgiri2.Height = 0.3125!
        Me.txtShomarehRahgiri2.Left = 0.625!
        Me.txtShomarehRahgiri2.Name = "txtShomarehRahgiri2"
        Me.txtShomarehRahgiri2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtShomarehRahgiri2.Text = Nothing
        Me.txtShomarehRahgiri2.Top = 4.3125!
        Me.txtShomarehRahgiri2.Width = 1.5625!
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
        Me.Label41.Height = 0.2952756!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 2.625!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label41.Text = ": رهگیری"
        Me.Label41.Top = 7.875!
        Me.Label41.Width = 0.9798229!
        '
        'txtShomarehRahgiri3
        '
        Me.txtShomarehRahgiri3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri3.Border.RightColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri3.Border.TopColor = System.Drawing.Color.Black
        Me.txtShomarehRahgiri3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtShomarehRahgiri3.DataField = "paKala.KalaNO"
        Me.txtShomarehRahgiri3.Height = 0.2952756!
        Me.txtShomarehRahgiri3.Left = 0.6875!
        Me.txtShomarehRahgiri3.Name = "txtShomarehRahgiri3"
        Me.txtShomarehRahgiri3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.txtShomarehRahgiri3.Text = Nothing
        Me.txtShomarehRahgiri3.Top = 7.875!
        Me.txtShomarehRahgiri3.Width = 1.870079!
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
        Me.Label1.Left = 2.625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label1.Text = " : تاریخ انقضاء"
        Me.Label1.Top = 1.5!
        Me.Label1.Width = 1.3125!
        '
        'TxtEnghezaDate1
        '
        Me.TxtEnghezaDate1.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate1.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate1.Border.RightColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate1.Border.TopColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate1.DataField = "paKala.KalaNO"
        Me.TxtEnghezaDate1.Height = 0.3125!
        Me.TxtEnghezaDate1.Left = 0.75!
        Me.TxtEnghezaDate1.Name = "TxtEnghezaDate1"
        Me.TxtEnghezaDate1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.TxtEnghezaDate1.Text = Nothing
        Me.TxtEnghezaDate1.Top = 1.5!
        Me.TxtEnghezaDate1.Width = 1.8125!
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
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label2.Text = " : تاریخ انقضاء"
        Me.Label2.Top = 4.6875!
        Me.Label2.Width = 1.3125!
        '
        'TxtEnghezaDate2
        '
        Me.TxtEnghezaDate2.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate2.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate2.Border.RightColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate2.Border.TopColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate2.DataField = "paKala.KalaNO"
        Me.TxtEnghezaDate2.Height = 0.3125!
        Me.TxtEnghezaDate2.Left = 0.625!
        Me.TxtEnghezaDate2.Name = "TxtEnghezaDate2"
        Me.TxtEnghezaDate2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.TxtEnghezaDate2.Text = Nothing
        Me.TxtEnghezaDate2.Top = 4.6875!
        Me.TxtEnghezaDate2.Width = 1.5625!
        '
        'TxtEnghezaDate3
        '
        Me.TxtEnghezaDate3.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate3.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate3.Border.RightColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate3.Border.TopColor = System.Drawing.Color.Black
        Me.TxtEnghezaDate3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtEnghezaDate3.DataField = "paKala.KalaNO"
        Me.TxtEnghezaDate3.Height = 0.2952756!
        Me.TxtEnghezaDate3.Left = 0.6875!
        Me.TxtEnghezaDate3.Name = "TxtEnghezaDate3"
        Me.TxtEnghezaDate3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 20pt; "
        Me.TxtEnghezaDate3.Text = Nothing
        Me.TxtEnghezaDate3.Top = 8.232776!
        Me.TxtEnghezaDate3.Width = 1.870079!
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
        Me.Label3.Height = 0.25!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label3.Text = " : تاریخ انقضاء"
        Me.Label3.Top = 8.25!
        Me.Label3.Width = 1.25!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = False
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = False
        '
        'RptTagAnbarGardaniGhasem
        '
        Me.MasterReport = False
        SqlDBDataSource1.ConnectionString = "data source=sgserver;persist security info=False"
        SqlDBDataSource1.SQL = "Select KalaDS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from paKala"
        Me.DataSource = SqlDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.34375!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.txtKalaNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadAjza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChidemanNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChidemanNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChidemanNo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadAjza2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadAjza3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShomarehRahgiri3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEnghezaDate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEnghezaDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEnghezaDate3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
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
        txtTedadAjza.DataField = "TedadAjza"
        txtTedadAjza2.DataField = "TedadAjza"
        txtTedadAjza3.DataField = "TedadAjza"
        txtVahedeSanjeshDS.DataField = "VahedeSanjeshDS"
        txtVahedeSanjeshDS2.DataField = "VahedeSanjeshDS"
        txtVahedeSanjeshDS3.DataField = "VahedeSanjeshDS"
        txtChidemanNo.DataField = "ChidemanNo"
        txtChidemanNo2.DataField = "ChidemanNo"
        txtChidemanNo3.DataField = "ChidemanNo"
        txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        txtShomarehRahgiri2.DataField = "ShomarehRahgiri"
        txtShomarehRahgiri3.DataField = "ShomarehRahgiri"
        TxtEnghezaDate1.DataField = "EnghezaDate"
        TxtEnghezaDate2.DataField = "EnghezaDate"
        TxtEnghezaDate3.DataField = "EnghezaDate"

        ' .DataField = ""
        vRadif = 0
    End Sub

    Private Sub Detail_BeforePrint (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
        vRadif = vRadif + 1
        txtRadif.Text = vRadif
        txtRadif2.Text = vRadif
        txtRadif3.Text = vRadif
    End Sub

    Private Sub RptTagAnbarGardaniGhasem_ReportStart (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.ReportStart
        vRadif = 0
    End Sub
End Class
