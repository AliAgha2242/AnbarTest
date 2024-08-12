Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptTagAnbarGardaniPars
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
    Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
    Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
    Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
    Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
    Private txtKalaNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVahedeSanjeshDS As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVahedeSanjeshDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNO2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtVahedeSanjeshDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtRadif3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaNO3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtshomarehrahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtshomarehrahgiri2 As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtshomarehrahgiri3 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label4 As DataDynamics.ActiveReports.Label = Nothing
    Private Label7 As DataDynamics.ActiveReports.Label = Nothing
    Private Label8 As DataDynamics.ActiveReports.Label = Nothing
    Private Label9 As DataDynamics.ActiveReports.Label = Nothing
    Private Label10 As DataDynamics.ActiveReports.Label = Nothing
    Private Label11 As DataDynamics.ActiveReports.Label = Nothing
    Private Label12 As DataDynamics.ActiveReports.Label = Nothing
    Private Label13 As DataDynamics.ActiveReports.Label = Nothing
    Private Label14 As DataDynamics.ActiveReports.Label = Nothing
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
    Public txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing
    Public lblVahedeTejariDS As DataDynamics.ActiveReports.Label = Nothing
    Public lblVahedeTejariDS1 As DataDynamics.ActiveReports.Label = Nothing
    Public txtSherkat1 As DataDynamics.ActiveReports.TextBox = Nothing
    Public lblVahedeTejariDS2 As DataDynamics.ActiveReports.Label = Nothing
    Public txtSherkat2 As DataDynamics.ActiveReports.TextBox = Nothing

    Private Sub InitializeComponent()
        Dim SqlDBDataSource1 As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = New DataDynamics.ActiveReports.DataSources.SqlDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptTagAnbarGardaniPars))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.Shape3 = New DataDynamics.ActiveReports.Shape()
        Me.Shape2 = New DataDynamics.ActiveReports.Shape()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.txtKalaNO = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif = New DataDynamics.ActiveReports.TextBox()
        Me.txtVahedeSanjeshDS = New DataDynamics.ActiveReports.TextBox()
        Me.txtVahedeSanjeshDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNO2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtVahedeSanjeshDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaDS3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRadif3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtKalaNO3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtshomarehrahgiri = New DataDynamics.ActiveReports.TextBox()
        Me.txtshomarehrahgiri2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtshomarehrahgiri3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
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
        Me.lblVahedeTejariDS = New DataDynamics.ActiveReports.Label()
        Me.lblVahedeTejariDS1 = New DataDynamics.ActiveReports.Label()
        Me.txtSherkat1 = New DataDynamics.ActiveReports.TextBox()
        Me.lblVahedeTejariDS2 = New DataDynamics.ActiveReports.Label()
        Me.txtSherkat2 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.txtKalaNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtshomarehrahgiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtshomarehrahgiri2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtshomarehrahgiri3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblVahedeTejariDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVahedeTejariDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVahedeTejariDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.CanGrow = False
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Shape2, Me.Shape1, Me.txtKalaNO, Me.txtKalaDS, Me.txtRadif, Me.txtVahedeSanjeshDS, Me.txtVahedeSanjeshDS2, Me.txtKalaDS2, Me.txtRadif2, Me.txtKalaNO2, Me.txtVahedeSanjeshDS3, Me.txtKalaDS3, Me.txtRadif3, Me.txtKalaNO3, Me.txtshomarehrahgiri, Me.txtshomarehrahgiri2, Me.txtshomarehrahgiri3, Me.Label4, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.txtSherkat, Me.lblVahedeTejariDS, Me.lblVahedeTejariDS1, Me.txtSherkat1, Me.lblVahedeTejariDS2, Me.txtSherkat2})
        Me.Detail.Height = 11.375!
        Me.Detail.KeepTogether = True
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
        Me.Shape3.Height = 3.051181!
        Me.Shape3.Left = 0.7303153!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 7.574805!
        Me.Shape3.Width = 6.299212!
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 3.051181!
        Me.Shape2.Left = 0.7303153!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 3.86122!
        Me.Shape2.Width = 6.299212!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 3.051181!
        Me.Shape1.Left = 0.7303153!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.1929134!
        Me.Shape1.Width = 6.299212!
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
        Me.txtKalaNO.Left = 1.652067!
        Me.txtKalaNO.Name = "txtKalaNO"
        Me.txtKalaNO.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNO.Text = Nothing
        Me.txtKalaNO.Top = 1.108267!
        Me.txtKalaNO.Width = 1.771653!
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
        Me.txtKalaDS.Left = 1.714567!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaDS.Text = Nothing
        Me.txtKalaDS.Top = 1.452756!
        Me.txtKalaDS.Width = 3.346457!
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
        Me.txtRadif.Left = 3.879921!
        Me.txtRadif.Name = "txtRadif"
        Me.txtRadif.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif.Text = Nothing
        Me.txtRadif.Top = 1.07874!
        Me.txtRadif.Width = 1.181102!
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
        Me.txtVahedeSanjeshDS.Height = 0.3125!
        Me.txtVahedeSanjeshDS.Left = 1.6875!
        Me.txtVahedeSanjeshDS.Name = "txtVahedeSanjeshDS"
        Me.txtVahedeSanjeshDS.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS.Text = Nothing
        Me.txtVahedeSanjeshDS.Top = 1.75!
        Me.txtVahedeSanjeshDS.Width = 3.875!
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
        Me.txtVahedeSanjeshDS2.Height = 0.3125!
        Me.txtVahedeSanjeshDS2.Left = 3.75!
        Me.txtVahedeSanjeshDS2.Name = "txtVahedeSanjeshDS2"
        Me.txtVahedeSanjeshDS2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS2.Text = Nothing
        Me.txtVahedeSanjeshDS2.Top = 5.375!
        Me.txtVahedeSanjeshDS2.Width = 1.9375!
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
        Me.txtKalaDS2.Height = 0.2952756!
        Me.txtKalaDS2.Left = 1.76378!
        Me.txtKalaDS2.Name = "txtKalaDS2"
        Me.txtKalaDS2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaDS2.Text = Nothing
        Me.txtKalaDS2.Top = 5.062007!
        Me.txtKalaDS2.Width = 3.346457!
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
        Me.txtRadif2.Left = 3.850394!
        Me.txtRadif2.Name = "txtRadif2"
        Me.txtRadif2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif2.Text = Nothing
        Me.txtRadif2.Top = 4.747047!
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
        Me.txtKalaNO2.Left = 1.63878!
        Me.txtKalaNO2.Name = "txtKalaNO2"
        Me.txtKalaNO2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNO2.Text = Nothing
        Me.txtKalaNO2.Top = 4.747047!
        Me.txtKalaNO2.Width = 1.771653!
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
        Me.txtVahedeSanjeshDS3.Left = 3.75!
        Me.txtVahedeSanjeshDS3.Name = "txtVahedeSanjeshDS3"
        Me.txtVahedeSanjeshDS3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDS3.Text = Nothing
        Me.txtVahedeSanjeshDS3.Top = 9.25!
        Me.txtVahedeSanjeshDS3.Width = 1.887303!
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
        Me.txtKalaDS3.Height = 0.2952756!
        Me.txtKalaDS3.Left = 1.714567!
        Me.txtKalaDS3.Name = "txtKalaDS3"
        Me.txtKalaDS3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaDS3.Text = Nothing
        Me.txtKalaDS3.Top = 8.942917!
        Me.txtKalaDS3.Width = 3.346457!
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
        Me.txtRadif3.Left = 3.879921!
        Me.txtRadif3.Name = "txtRadif3"
        Me.txtRadif3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtRadif3.Text = Nothing
        Me.txtRadif3.Top = 8.608271!
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
        Me.txtKalaNO3.Left = 1.652067!
        Me.txtKalaNO3.Name = "txtKalaNO3"
        Me.txtKalaNO3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNO3.Text = Nothing
        Me.txtKalaNO3.Top = 8.608271!
        Me.txtKalaNO3.Width = 1.771653!
        '
        'txtshomarehrahgiri
        '
        Me.txtshomarehrahgiri.Border.BottomColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri.Border.LeftColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri.Border.RightColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri.Border.TopColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri.DataField = "ChidemanNo"
        Me.txtshomarehrahgiri.Height = 0.2952756!
        Me.txtshomarehrahgiri.Left = 1.52231!
        Me.txtshomarehrahgiri.Name = "txtshomarehrahgiri"
        Me.txtshomarehrahgiri.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtshomarehrahgiri.Text = Nothing
        Me.txtshomarehrahgiri.Top = 2.152231!
        Me.txtshomarehrahgiri.Width = 1.771653!
        '
        'txtshomarehrahgiri2
        '
        Me.txtshomarehrahgiri2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri2.Border.RightColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri2.Border.TopColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri2.DataField = "ShomarehRahgiriDS"
        Me.txtshomarehrahgiri2.Height = 0.2952756!
        Me.txtshomarehrahgiri2.Left = 1.51378!
        Me.txtshomarehrahgiri2.Name = "txtshomarehrahgiri2"
        Me.txtshomarehrahgiri2.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtshomarehrahgiri2.Text = Nothing
        Me.txtshomarehrahgiri2.Top = 5.73622!
        Me.txtshomarehrahgiri2.Width = 1.771653!
        '
        'txtshomarehrahgiri3
        '
        Me.txtshomarehrahgiri3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri3.Border.RightColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri3.Border.TopColor = System.Drawing.Color.Black
        Me.txtshomarehrahgiri3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtshomarehrahgiri3.DataField = "shomarehRahgiriDS"
        Me.txtshomarehrahgiri3.Height = 0.2952756!
        Me.txtshomarehrahgiri3.Left = 1.527067!
        Me.txtshomarehrahgiri3.Name = "txtshomarehrahgiri3"
        Me.txtshomarehrahgiri3.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtshomarehrahgiri3.Text = Nothing
        Me.txtshomarehrahgiri3.Top = 9.600396!
        Me.txtshomarehrahgiri3.Width = 1.771653!
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
        Me.Label4.Left = 1.02559!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 18pt; font-f" & _
            "amily: Koodak; "
        Me.Label4.Text = "3"
        Me.Label4.Top = 0.3897638!
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
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.159449!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label7.Text = "برگ روي جنس"
        Me.Label7.Top = 0.6850395!
        Me.Label7.Width = 1.181102!
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
        Me.Label8.Height = 0.3125!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.159449!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label8.Text = ": شماره رديف "
        Me.Label8.Top = 1.07874!
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
        Me.Label9.Left = 5.159449!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label9.Text = ": نوع جنس "
        Me.Label9.Top = 1.423229!
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
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.486222!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label10.Text = ": کد"
        Me.Label10.Top = 1.07874!
        Me.Label10.Width = 0.3444879!
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
        Me.Label11.Left = 5.625!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label11.Text = ": واحد"
        Me.Label11.Top = 1.75!
        Me.Label11.Width = 0.6875!
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
        Me.Label12.Left = 3.375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label12.Text = ": شماره رهگيري"
        Me.Label12.Top = 2.135007!
        Me.Label12.Width = 1.375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.3125!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.503937!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label13.Text = ": شمارشگر"
        Me.Label13.Top = 2.456693!
        Me.Label13.Width = 0.8366139!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.3125!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 3.28937!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label14.Text = ": تاريخ"
        Me.Label14.Top = 2.505905!
        Me.Label14.Width = 0.5413384!
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
        Me.Label15.Height = 0.3125!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.08809!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 18pt; font-f" & _
            "amily: Koodak; "
        Me.Label15.Text = "2"
        Me.Label15.Top = 4.014764!
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
        Me.Label16.Left = 3.486222!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label16.Text = ": کد"
        Me.Label16.Top = 4.703741!
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
        Me.Label17.Left = 5.159449!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label17.Text = "شمارش دوم"
        Me.Label17.Top = 4.31004!
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
        Me.Label18.Left = 5.159449!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label18.Text = ": شماره رديف "
        Me.Label18.Top = 4.703741!
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
        Me.Label19.Left = 5.159449!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label19.Text = ": نوع جنس "
        Me.Label19.Top = 5.048229!
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
        Me.Label20.Height = 0.3125!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 5.75!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label20.Text = ": واحد"
        Me.Label20.Top = 5.375!
        Me.Label20.Width = 0.5625!
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
        Me.Label21.Height = 0.3125!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.375!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label21.Text = ": شماره رهگيري"
        Me.Label21.Top = 5.75!
        Me.Label21.Width = 1.375!
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
        Me.Label22.Left = 3.28937!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label22.Text = ": تاريخ"
        Me.Label22.Top = 6.130906!
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
        Me.Label23.Left = 5.503937!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label23.Text = ": شمارشگر"
        Me.Label23.Top = 6.081693!
        Me.Label23.Width = 0.8366139!
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
        Me.Label24.Height = 0.3125!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 1.02559!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 18pt; font-f" & _
            "amily: Koodak; "
        Me.Label24.Text = "1"
        Me.Label24.Top = 7.889764!
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
        Me.Label25.Height = 0.3125!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 3.486222!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label25.Text = ": کد"
        Me.Label25.Top = 8.559055!
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
        Me.Label26.Left = 5.159449!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label26.Text = "شمارش اول"
        Me.Label26.Top = 8.185041!
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
        Me.Label27.Height = 0.3125!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 5.159449!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label27.Text = ": شماره رديف "
        Me.Label27.Top = 8.578743!
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
        Me.Label28.Left = 5.159449!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label28.Text = ": نوع جنس "
        Me.Label28.Top = 8.923229!
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
        Me.Label29.Height = 0.3125!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.6875!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label29.Text = ": واحد"
        Me.Label29.Top = 9.25!
        Me.Label29.Width = 0.625!
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
        Me.Label30.Left = 3.375!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label30.Text = ": شماره رهگيري"
        Me.Label30.Top = 9.583172!
        Me.Label30.Width = 1.5!
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
        Me.Label31.Left = 3.28937!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label31.Text = ": تاريخ"
        Me.Label31.Top = 9.986222!
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
        Me.Label32.Left = 5.503937!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label32.Text = ": شمارشگر"
        Me.Label32.Top = 9.956695!
        Me.Label32.Width = 0.8366139!
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
        Me.Label33.Left = 3.0625!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label33.Text = ": مقدار"
        Me.Label33.Top = 5.375!
        Me.Label33.Width = 0.6875!
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
        Me.Label34.Left = 3.0!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "ddo-char-set: 178; text-align: right; font-weight: bold; font-size: 14.25pt; font" & _
            "-family: Koodak; "
        Me.Label34.Text = ": مقدار"
        Me.Label34.Top = 9.25!
        Me.Label34.Width = 0.6875!
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
        Me.txtSherkat.Height = 0.3154528!
        Me.txtSherkat.Left = 2.531004!
        Me.txtSherkat.Name = "txtSherkat"
        Me.txtSherkat.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 11.25pt; font-" & _
            "family: Koodak; "
        Me.txtSherkat.Text = Nothing
        Me.txtSherkat.Top = 0.5866139!
        Me.txtSherkat.Width = 2.531496!
        '
        'lblVahedeTejariDS
        '
        Me.lblVahedeTejariDS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS.Border.RightColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS.Border.TopColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS.Height = 0.3218504!
        Me.lblVahedeTejariDS.HyperLink = Nothing
        Me.lblVahedeTejariDS.Left = 1.64042!
        Me.lblVahedeTejariDS.Name = "lblVahedeTejariDS"
        Me.lblVahedeTejariDS.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 11.25pt; fon" & _
            "t-family: Koodak; "
        Me.lblVahedeTejariDS.Text = ""
        Me.lblVahedeTejariDS.Top = 0.2296588!
        Me.lblVahedeTejariDS.Width = 4.724409!
        '
        'lblVahedeTejariDS1
        '
        Me.lblVahedeTejariDS1.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS1.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS1.Border.RightColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS1.Border.TopColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS1.Height = 0.3218504!
        Me.lblVahedeTejariDS1.HyperLink = Nothing
        Me.lblVahedeTejariDS1.Left = 2.787401!
        Me.lblVahedeTejariDS1.Name = "lblVahedeTejariDS1"
        Me.lblVahedeTejariDS1.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 11.25pt; fon" & _
            "t-family: Koodak; "
        Me.lblVahedeTejariDS1.Text = ""
        Me.lblVahedeTejariDS1.Top = 3.87254!
        Me.lblVahedeTejariDS1.Width = 2.03412!
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
        Me.txtSherkat1.Height = 0.3154528!
        Me.txtSherkat1.Left = 2.566929!
        Me.txtSherkat1.Name = "txtSherkat1"
        Me.txtSherkat1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 11.25pt; font-" & _
            "family: Koodak; "
        Me.txtSherkat1.Text = Nothing
        Me.txtSherkat1.Top = 4.228346!
        Me.txtSherkat1.Width = 2.531496!
        '
        'lblVahedeTejariDS2
        '
        Me.lblVahedeTejariDS2.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS2.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS2.Border.RightColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS2.Border.TopColor = System.Drawing.Color.Black
        Me.lblVahedeTejariDS2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVahedeTejariDS2.Height = 0.3218504!
        Me.lblVahedeTejariDS2.HyperLink = Nothing
        Me.lblVahedeTejariDS2.Left = 2.787401!
        Me.lblVahedeTejariDS2.Name = "lblVahedeTejariDS2"
        Me.lblVahedeTejariDS2.Style = "ddo-char-set: 178; text-align: center; font-weight: bold; font-size: 11.25pt; fon" & _
            "t-family: Koodak; "
        Me.lblVahedeTejariDS2.Text = ""
        Me.lblVahedeTejariDS2.Top = 7.612695!
        Me.lblVahedeTejariDS2.Width = 2.03412!
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
        Me.txtSherkat2.Height = 0.3147967!
        Me.txtSherkat2.Left = 2.566929!
        Me.txtSherkat2.Name = "txtSherkat2"
        Me.txtSherkat2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 11.25pt; font-" & _
            "family: Koodak; "
        Me.txtSherkat2.Text = Nothing
        Me.txtSherkat2.Top = 7.928646!
        Me.txtSherkat2.Width = 2.530101!
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
        'RptTagAnbarGardaniPars
        '
        Me.MasterReport = False
        SqlDBDataSource1.ConnectionString = "data source=sgserver;persist security info=False"
        SqlDBDataSource1.SQL = "Select KalaDS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from paKala"
        Me.DataSource = SqlDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.2361111!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 8.15625!
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
        CType(Me.txtVahedeSanjeshDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVahedeSanjeshDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRadif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKalaNO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtshomarehrahgiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtshomarehrahgiri2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtshomarehrahgiri3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblVahedeTejariDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVahedeTejariDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVahedeTejariDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSherkat2, System.ComponentModel.ISupportInitialize).EndInit()
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
        txtshomarehrahgiri.DataField = "shomarehrahgiri"
        txtshomarehrahgiri2.DataField = "shomarehrahgiri"
        txtshomarehrahgiri3.DataField = "shomarehrahgiri"
        ' .DataField = ""
        vRadif = 0
    End Sub

    Private Sub Detail_BeforePrint (ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
        vRadif = vRadif + 1
        txtRadif.Text = vRadif
        txtRadif2.Text = vRadif
        txtRadif3.Text = vRadif
    End Sub

    Private Sub RptTagAnbarGardaniPars_ReportStart (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.ReportStart
        vRadif = 0
    End Sub
End Class
