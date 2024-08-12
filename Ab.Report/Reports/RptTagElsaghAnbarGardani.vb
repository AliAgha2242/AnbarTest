Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptTagElsaghAnbarGardani
    Inherits ActiveReport3


    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
    Private Label1 As DataDynamics.ActiveReports.Label = Nothing
    Private Label2 As DataDynamics.ActiveReports.Label = Nothing
    Private Label3 As DataDynamics.ActiveReports.Label = Nothing
    Private Label4 As DataDynamics.ActiveReports.Label = Nothing
    Private Label5 As DataDynamics.ActiveReports.Label = Nothing
    Private Label6 As DataDynamics.ActiveReports.Label = Nothing
    Private Label7 As DataDynamics.ActiveReports.Label = Nothing
    Private Label10 As DataDynamics.ActiveReports.Label = Nothing
    Private Line1 As DataDynamics.ActiveReports.Line = Nothing
    Private Line2 As DataDynamics.ActiveReports.Line = Nothing
    Private txtKalaNO As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtKalaDS As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSal As DataDynamics.ActiveReports.TextBox = Nothing
    Public txtSherkat As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtTedadDarKarton As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label12 As DataDynamics.ActiveReports.Label = Nothing
    Private Label13 As DataDynamics.ActiveReports.Label = Nothing
    Private txtShomarehRahgiri As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label14 As DataDynamics.ActiveReports.Label = Nothing
    Private txtVahedeSanjeshDs As DataDynamics.ActiveReports.TextBox = Nothing
    Private ChidemanDS As DataDynamics.ActiveReports.TextBox = Nothing
    Public lblVahedeTejariDS As DataDynamics.ActiveReports.Label = Nothing

    Private Sub InitializeComponent()
        Dim _
            SqlDBDataSource1 As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = _
                New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
        Dim _
            resources As System.ComponentModel.ComponentResourceManager = _
                New System.ComponentModel.ComponentResourceManager (GetType (RptTagElsaghAnbarGardani))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.txtKalaNO = New DataDynamics.ActiveReports.TextBox
        Me.txtKalaDS = New DataDynamics.ActiveReports.TextBox
        Me.txtSal = New DataDynamics.ActiveReports.TextBox
        Me.txtSherkat = New DataDynamics.ActiveReports.TextBox
        Me.txtTedadDarKarton = New DataDynamics.ActiveReports.TextBox
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.txtShomarehRahgiri = New DataDynamics.ActiveReports.TextBox
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.txtVahedeSanjeshDs = New DataDynamics.ActiveReports.TextBox
        Me.ChidemanDS = New DataDynamics.ActiveReports.TextBox
        Me.lblVahedeTejariDS = New DataDynamics.ActiveReports.Label
        CType (Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKalaNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSal, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtSherkat, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtTedadDarKarton, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.txtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.ChidemanDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me.lblVahedeTejariDS, System.ComponentModel.ISupportInitialize).BeginInit
        CType (Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanGrow = false
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange ( _
                                     New DataDynamics.ActiveReports.ARControl() _
                                        {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, _
                                         Me.Label10, Me.Line1, Me.Line2, Me.txtKalaNO, Me.txtKalaDS, Me.txtSal, _
                                         Me.txtSherkat, Me.txtTedadDarKarton, Me.Label12, Me.Label13, _
                                         Me.txtShomarehRahgiri, Me.Label14, Me.txtVahedeSanjeshDs, Me.ChidemanDS, _
                                         Me.lblVahedeTejariDS})
        Me.Detail.Height = 3.354167!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
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
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.739501!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" & _
                          "ly: Tahoma; "
        Me.Label1.Text = "مخصوص الصاق به کالا"
        Me.Label1.Top = 0.0492126!
        Me.Label1.Width = 2.03412!
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
        Me.Label2.Height = 0.3218504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.872047!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
                          "mily: Tahoma; "
        Me.Label2.Text = "انبار گرداني پايان سال مالي "
        Me.Label2.Top = 0.3444882!
        Me.Label2.Width = 1.93184!
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
        Me.Label3.Height = 0.3218504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.868849!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                          "y: Tahoma; "
        Me.Label3.Text = ": شماره کالا "
        Me.Label3.Top = 0.9350396!
        Me.Label3.Width = 0.8858263!
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
        Me.Label4.Height = 0.3218504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.889108!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                          "y: Tahoma; "
        Me.Label4.Text = ": شرح کالا "
        Me.Label4.Top = 1.755249!
        Me.Label4.Width = 0.8858263!
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
        Me.Label5.Height = 0.246063!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.244833!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                          "y: Tahoma; "
        Me.Label5.Text = "امضاء گروه شمارشگر 1"
        Me.Label5.Top = 2.277067!
        Me.Label5.Width = 1.820865!
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
        Me.Label6.Height = 0.246063!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.144439!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                          "y: Tahoma; "
        Me.Label6.Text = "امضاء گروه شمارشگر 2"
        Me.Label6.Top = 2.277067!
        Me.Label6.Width = 1.820865!
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
        Me.Label7.Height = 0.246063!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.884596!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                          "y: Tahoma; "
        Me.Label7.Text = "محل استقرار کالا"
        Me.Label7.Top = 2.755906!
        Me.Label7.Width = 1.820865!
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
        Me.Label10.Height = 0.3218504!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 2.325542!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                           "y: Tahoma; "
        Me.Label10.Text = "انبار"
        Me.Label10.Top = 0.3444882!
        Me.Label10.Width = 0.6889763!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.4554626!
        Me.Line1.LineWeight = 3!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.7647639!
        Me.Line1.Width = 6.348425!
        Me.Line1.X1 = 6.803888!
        Me.Line1.X2 = 0.4554626!
        Me.Line1.Y1 = 0.7647639!
        Me.Line1.Y2 = 0.7647639!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.488271!
        Me.Line2.LineWeight = 4!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.28084!
        Me.Line2.Width = 6.348426!
        Me.Line2.X1 = 6.836697!
        Me.Line2.X2 = 0.488271!
        Me.Line2.Y1 = 3.28084!
        Me.Line2.Y2 = 3.28084!
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
        Me.txtKalaNO.DataField = "KalaNO"
        Me.txtKalaNO.Height = 0.2952756!
        Me.txtKalaNO.Left = 3.211368!
        Me.txtKalaNO.Name = "txtKalaNO"
        Me.txtKalaNO.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaNO.Top = 0.9350396!
        Me.txtKalaNO.Width = 2.509842!
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
        Me.txtKalaDS.CanGrow = false
        Me.txtKalaDS.DataField = "KalaDS"
        Me.txtKalaDS.Height = 0.4890092!
        Me.txtKalaDS.Left = 0.5577428!
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtKalaDS.Top = 1.706037!
        Me.txtKalaDS.Width = 5.167323!
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
        Me.txtSal.Height = 0.3608924!
        Me.txtSal.Left = 3.067585!
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Style = "ddo-char-set: 178; text-align: right; font-size: 9.75pt; "
        Me.txtSal.Top = 0.3444882!
        Me.txtSal.Width = 1.755249!
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
        Me.txtSherkat.CanGrow = false
        Me.txtSherkat.Height = 0.3772967!
        Me.txtSherkat.Left = 0.5538878!
        Me.txtSherkat.Name = "txtSherkat"
        Me.txtSherkat.Style = "ddo-char-set: 178; text-align: right; font-size: 9.75pt; "
        Me.txtSherkat.Top = 0.3444882!
        Me.txtSherkat.Width = 1.7427!
        '
        'txtTedadDarKarton
        '
        Me.txtTedadDarKarton.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadDarKarton.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadDarKarton.Border.RightColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadDarKarton.Border.TopColor = System.Drawing.Color.Black
        Me.txtTedadDarKarton.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTedadDarKarton.Height = 0.2952756!
        Me.txtTedadDarKarton.Left = 1.01706!
        Me.txtTedadDarKarton.Name = "txtTedadDarKarton"
        Me.txtTedadDarKarton.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtTedadDarKarton.Top = 0.9514437!
        Me.txtTedadDarKarton.Width = 0.9350396!
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
        Me.Label12.Height = 0.3218504!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 2.066929!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                           "y: Tahoma; "
        Me.Label12.Text = ": تعداد در کارتن"
        Me.Label12.Top = 0.9350396!
        Me.Label12.Width = 0.9475882!
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
        Me.Label13.Height = 0.3218504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.495407!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                           "y: Tahoma; "
        Me.Label13.Text = ": شماره رهگيري"
        Me.Label13.Top = 1.32874!
        Me.Label13.Width = 1.279527!
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
        Me.txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        Me.txtShomarehRahgiri.Height = 0.2952756!
        Me.txtShomarehRahgiri.Left = 3.526903!
        Me.txtShomarehRahgiri.Name = "txtShomarehRahgiri"
        Me.txtShomarehRahgiri.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtShomarehRahgiri.Top = 1.345145!
        Me.txtShomarehRahgiri.Width = 1.919291!
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
        Me.Label14.Height = 0.3218504!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 2.095883!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
                           "y: Tahoma; "
        Me.Label14.Text = ": واحد سنجش"
        Me.Label14.Top = 1.345145!
        Me.Label14.Width = 0.9186341!
        '
        'txtVahedeSanjeshDs
        '
        Me.txtVahedeSanjeshDs.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.Border.RightColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.Border.TopColor = System.Drawing.Color.Black
        Me.txtVahedeSanjeshDs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVahedeSanjeshDs.DataField = "VahedeSanjeshDs"
        Me.txtVahedeSanjeshDs.Height = 0.2952756!
        Me.txtVahedeSanjeshDs.Left = 0.5905511!
        Me.txtVahedeSanjeshDs.Name = "txtVahedeSanjeshDs"
        Me.txtVahedeSanjeshDs.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.txtVahedeSanjeshDs.Top = 1.377953!
        Me.txtVahedeSanjeshDs.Width = 1.492782!
        '
        'ChidemanDS
        '
        Me.ChidemanDS.Border.BottomColor = System.Drawing.Color.Black
        Me.ChidemanDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ChidemanDS.Border.LeftColor = System.Drawing.Color.Black
        Me.ChidemanDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ChidemanDS.Border.RightColor = System.Drawing.Color.Black
        Me.ChidemanDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ChidemanDS.Border.TopColor = System.Drawing.Color.Black
        Me.ChidemanDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ChidemanDS.DataField = "ChidemanDS"
        Me.ChidemanDS.Height = 0.2952756!
        Me.ChidemanDS.Left = 1.230315!
        Me.ChidemanDS.Name = "ChidemanDS"
        Me.ChidemanDS.Style = "ddo-char-set: 178; text-align: right; font-size: 15.75pt; "
        Me.ChidemanDS.Top = 2.706693!
        Me.ChidemanDS.Width = 3.641732!
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
        Me.lblVahedeTejariDS.Height = 0.1968504!
        Me.lblVahedeTejariDS.HyperLink = Nothing
        Me.lblVahedeTejariDS.Left = 0.3937008!
        Me.lblVahedeTejariDS.Name = "lblVahedeTejariDS"
        Me.lblVahedeTejariDS.Style = _
            "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" & _
            "ly: Tahoma; "
        Me.lblVahedeTejariDS.Text = ""
        Me.lblVahedeTejariDS.Top = 0.0492126!
        Me.lblVahedeTejariDS.Width = 2.03412!
        '
        'ActiveReport31
        '
        Me.MasterReport = false
        SqlDBDataSource1.ConnectionString = "data source=sgserver;persist security info=False"
        SqlDBDataSource1.SQL = "Select KalaDS" & Global.Microsoft.VisualBasic.ChrW (13) & _
                               Global.Microsoft.VisualBasic.ChrW (10) & "from paKala"
        Me.DataSource = SqlDBDataSource1
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.39375!
        Me.PageSettings.Margins.Left = 0.39375!
        Me.PageSettings.Margins.Right = 0.39375!
        Me.PageSettings.Margins.Top = 0.39375!
        Me.PageSettings.PaperHeight = 10.98403!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 10.98403!
        Me.PrintWidth = 7.59375!
        Me.Sections.Add (Me.PageHeader)
        Me.Sections.Add (Me.Detail)
        Me.Sections.Add (Me.PageFooter)
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
        CType (Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKalaNO, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtKalaDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSal, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtSherkat, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtTedadDarKarton, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtShomarehRahgiri, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.txtVahedeSanjeshDs, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.ChidemanDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me.lblVahedeTejariDS, System.ComponentModel.ISupportInitialize).EndInit
        CType (Me, System.ComponentModel.ISupportInitialize).EndInit
        Me.ds = CType (Me.DataSource, DataDynamics.ActiveReports.DataSources.SqlDBDataSource)

    End Sub

#End Region

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي


        txtKalaNO.DataField = "KalaNO"
        txtTedadDarKarton.DataField = "TedadAjza"
        txtKalaDS.DataField = "KalaDS"
        txtVahedeSanjeshDs.DataField = "VahedeSanjeshDs"
        txtShomarehRahgiri.DataField = "ShomarehRahgiri"
        ' .DataField = ""
    End Sub
End Class
