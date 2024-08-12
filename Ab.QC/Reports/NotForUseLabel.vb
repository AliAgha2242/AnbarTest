''Add By Dehghani - 940609
Imports System
Imports DataDynamics.ActiveReports

Public Class NotForUseLabel
    Inherits ActiveReport3

    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents CheckBox1 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents CheckBox2 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents TxtCertificate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TxtCompany As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TxtCertificate2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TxtTozih As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents MaterialName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents BatchNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Supplier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents MfgDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ExpDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Meghdar As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReceiptDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TraceNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Public FontSize As Single
    Friend WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox35 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Tozih2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox38 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox39 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox42 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox46 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents KalaDS2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Batchno2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Supplier2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents MfgDate2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ExpDate2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Meghdar2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReceiptDate2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TraceNo2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox55 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox56 As DataDynamics.ActiveReports.TextBox
    Public FontName As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "Labratory Label"
        Me.PageSettings.PaperKind = Printing.PaperKind.A4
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
    End Sub

    Friend WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents Detail As DataDynamics.ActiveReports.Detail
    Friend WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Friend WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter

#Region "ActiveReports Designer generated code"

    Private Page1 As DataDynamics.ActiveReports.Document.Page = Nothing

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotForUseLabel))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TxtCertificate = New DataDynamics.ActiveReports.TextBox()
        Me.TxtCompany = New DataDynamics.ActiveReports.TextBox()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.TxtCertificate2 = New DataDynamics.ActiveReports.TextBox()
        Me.TxtTozih = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.MaterialName = New DataDynamics.ActiveReports.TextBox()
        Me.BatchNo = New DataDynamics.ActiveReports.TextBox()
        Me.Supplier = New DataDynamics.ActiveReports.TextBox()
        Me.MfgDate = New DataDynamics.ActiveReports.TextBox()
        Me.ExpDate = New DataDynamics.ActiveReports.TextBox()
        Me.Meghdar = New DataDynamics.ActiveReports.TextBox()
        Me.ReceiptDate = New DataDynamics.ActiveReports.TextBox()
        Me.TraceNo = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        Me.TextBox35 = New DataDynamics.ActiveReports.TextBox()
        Me.Tozih2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox38 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox39 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox42 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox46 = New DataDynamics.ActiveReports.TextBox()
        Me.KalaDS2 = New DataDynamics.ActiveReports.TextBox()
        Me.Batchno2 = New DataDynamics.ActiveReports.TextBox()
        Me.Supplier2 = New DataDynamics.ActiveReports.TextBox()
        Me.MfgDate2 = New DataDynamics.ActiveReports.TextBox()
        Me.ExpDate2 = New DataDynamics.ActiveReports.TextBox()
        Me.Meghdar2 = New DataDynamics.ActiveReports.TextBox()
        Me.ReceiptDate2 = New DataDynamics.ActiveReports.TextBox()
        Me.TraceNo2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox55 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox56 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.TxtCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCertificate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTozih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MfgDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meghdar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tozih2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalaDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Batchno2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MfgDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meghdar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraceNo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TxtCertificate, Me.TxtCompany, Me.Picture1, Me.TxtCertificate2, Me.TxtTozih, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.MaterialName, Me.BatchNo, Me.Supplier, Me.MfgDate, Me.ExpDate, Me.Meghdar, Me.ReceiptDate, Me.TraceNo, Me.TextBox17, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.Picture2, Me.TextBox35, Me.Tozih2, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.KalaDS2, Me.Batchno2, Me.Supplier2, Me.MfgDate2, Me.ExpDate2, Me.Meghdar2, Me.ReceiptDate2, Me.TraceNo2, Me.TextBox55, Me.TextBox56})
        Me.Detail.Height = 3.552083!
        Me.Detail.Name = "Detail"
        '
        'TxtCertificate
        '
        Me.TxtCertificate.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtCertificate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtCertificate.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtCertificate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtCertificate.Border.RightColor = System.Drawing.Color.Black
        Me.TxtCertificate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtCertificate.Border.TopColor = System.Drawing.Color.Black
        Me.TxtCertificate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCertificate.Height = 0.375!
        Me.TxtCertificate.Left = 1.375!
        Me.TxtCertificate.Name = "TxtCertificate"
        Me.TxtCertificate.Style = "color: Black; text-align: center; font-weight: bold; font-size: 11pt; font-family" & _
    ": Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TxtCertificate.Text = "بررسی نشده"
        Me.TxtCertificate.Top = 0.1875!
        Me.TxtCertificate.Width = 2.375!
        '
        'TxtCompany
        '
        Me.TxtCompany.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtCompany.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCompany.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtCompany.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCompany.Border.RightColor = System.Drawing.Color.Black
        Me.TxtCompany.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCompany.Border.TopColor = System.Drawing.Color.Black
        Me.TxtCompany.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCompany.Height = 0.813!
        Me.TxtCompany.Left = 3.75!
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Style = "color: Black; ddo-char-set: 0; text-align: center; font-weight: bold; font-size: " & _
    "7pt; font-family: Times New Roman; vertical-align: bottom; "
        Me.TxtCompany.Text = "شرکت دارویی ، آرایشی و بهداشتی مینو"
        Me.TxtCompany.Top = 0.1875!
        Me.TxtCompany.Width = 1.5!
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.4375!
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 4.1875!
        Me.Picture1.LineWeight = 0.0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Top = 0.3125!
        Me.Picture1.Width = 0.6875!
        '
        'TxtCertificate2
        '
        Me.TxtCertificate2.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtCertificate2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCertificate2.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtCertificate2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtCertificate2.Border.RightColor = System.Drawing.Color.Black
        Me.TxtCertificate2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtCertificate2.Border.TopColor = System.Drawing.Color.Black
        Me.TxtCertificate2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtCertificate2.Height = 0.438!
        Me.TxtCertificate2.Left = 1.375!
        Me.TxtCertificate2.Name = "TxtCertificate2"
        Me.TxtCertificate2.Style = "color: Black; text-align: center; font-weight: bold; font-size: 11pt; font-family" & _
    ": Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TxtCertificate2.Text = "Not For Use"
        Me.TxtCertificate2.Top = 0.5625!
        Me.TxtCertificate2.Width = 2.375!
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
        Me.TxtTozih.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TxtTozih.Height = 0.375!
        Me.TxtTozih.Left = 0.0!
        Me.TxtTozih.Name = "TxtTozih"
        Me.TxtTozih.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 1" & _
    "1pt; font-family: Times New Roman; vertical-align: top; "
        Me.TxtTozih.Text = "توضیحات :"
        Me.TxtTozih.Top = 3.125!
        Me.TxtTozih.Width = 5.25!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.25!
        Me.TextBox18.Left = 0.0!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: normal; font-size:" & _
    " 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox18.Text = "شماره مدرک"
        Me.TextBox18.Top = 0.1875!
        Me.TextBox18.Width = 1.375!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 2.125!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9" & _
    "pt; font-family: Times New Roman; vertical-align: top; "
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 1.0!
        Me.TextBox19.Width = 5.25!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 3.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox20.Text = "(Material Name) نام ماده "
        Me.TextBox20.Top = 1.125!
        Me.TextBox20.Width = 2.16!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 3.0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox25.Text = "(Batch No.) شماره بچ سازنده"
        Me.TextBox25.Top = 1.375!
        Me.TextBox25.Width = 2.16!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Height = 0.1875!
        Me.TextBox26.Left = 3.0!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox26.Text = "(Supplier) نام فروشنده"
        Me.TextBox26.Top = 1.625!
        Me.TextBox26.Width = 2.16!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 3.0!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox27.Text = "(Mfg Date) تاریخ ساخت سازنده"
        Me.TextBox27.Top = 1.875!
        Me.TextBox27.Width = 2.16!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Height = 0.1875!
        Me.TextBox28.Left = 3.0!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox28.Text = "(Exp Date) تاریخ انقضاء سازنده"
        Me.TextBox28.Top = 2.125!
        Me.TextBox28.Width = 2.16!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Height = 0.1875!
        Me.TextBox29.Left = 3.0!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox29.Text = "مقدار/تعداد    ...........واحد"
        Me.TextBox29.Top = 2.375!
        Me.TextBox29.Width = 2.16!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Height = 0.1875!
        Me.TextBox30.Left = 3.0!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox30.Text = "(Date Of Receipt) تاریخ وارده به انبار"
        Me.TextBox30.Top = 2.625!
        Me.TextBox30.Width = 2.16!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Height = 0.1875!
        Me.TextBox31.Left = 3.0!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox31.Text = "(Tracing No) شماره/کد رهگیری"
        Me.TextBox31.Top = 2.875!
        Me.TextBox31.Width = 2.16!
        '
        'MaterialName
        '
        Me.MaterialName.Border.BottomColor = System.Drawing.Color.Black
        Me.MaterialName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MaterialName.Border.LeftColor = System.Drawing.Color.Black
        Me.MaterialName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MaterialName.Border.RightColor = System.Drawing.Color.Black
        Me.MaterialName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MaterialName.Border.TopColor = System.Drawing.Color.Black
        Me.MaterialName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MaterialName.Height = 0.1875!
        Me.MaterialName.Left = 0.0625!
        Me.MaterialName.Name = "MaterialName"
        Me.MaterialName.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.MaterialName.Text = Nothing
        Me.MaterialName.Top = 1.125!
        Me.MaterialName.Width = 2.84!
        '
        'BatchNo
        '
        Me.BatchNo.Border.BottomColor = System.Drawing.Color.Black
        Me.BatchNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.BatchNo.Border.LeftColor = System.Drawing.Color.Black
        Me.BatchNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.BatchNo.Border.RightColor = System.Drawing.Color.Black
        Me.BatchNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.BatchNo.Border.TopColor = System.Drawing.Color.Black
        Me.BatchNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.BatchNo.Height = 0.1875!
        Me.BatchNo.Left = 0.0625!
        Me.BatchNo.Name = "BatchNo"
        Me.BatchNo.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.BatchNo.Text = Nothing
        Me.BatchNo.Top = 1.375!
        Me.BatchNo.Width = 2.84!
        '
        'Supplier
        '
        Me.Supplier.Border.BottomColor = System.Drawing.Color.Black
        Me.Supplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier.Border.LeftColor = System.Drawing.Color.Black
        Me.Supplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier.Border.RightColor = System.Drawing.Color.Black
        Me.Supplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier.Border.TopColor = System.Drawing.Color.Black
        Me.Supplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier.Height = 0.1875!
        Me.Supplier.Left = 0.0625!
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.Supplier.Text = Nothing
        Me.Supplier.Top = 1.625!
        Me.Supplier.Width = 2.84!
        '
        'MfgDate
        '
        Me.MfgDate.Border.BottomColor = System.Drawing.Color.Black
        Me.MfgDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate.Border.LeftColor = System.Drawing.Color.Black
        Me.MfgDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate.Border.RightColor = System.Drawing.Color.Black
        Me.MfgDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate.Border.TopColor = System.Drawing.Color.Black
        Me.MfgDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate.Height = 0.1875!
        Me.MfgDate.Left = 0.0625!
        Me.MfgDate.Name = "MfgDate"
        Me.MfgDate.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.MfgDate.Text = Nothing
        Me.MfgDate.Top = 1.875!
        Me.MfgDate.Width = 2.84!
        '
        'ExpDate
        '
        Me.ExpDate.Border.BottomColor = System.Drawing.Color.Black
        Me.ExpDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate.Border.LeftColor = System.Drawing.Color.Black
        Me.ExpDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate.Border.RightColor = System.Drawing.Color.Black
        Me.ExpDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate.Border.TopColor = System.Drawing.Color.Black
        Me.ExpDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate.Height = 0.1875!
        Me.ExpDate.Left = 0.0625!
        Me.ExpDate.Name = "ExpDate"
        Me.ExpDate.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.ExpDate.Text = Nothing
        Me.ExpDate.Top = 2.125!
        Me.ExpDate.Width = 2.84!
        '
        'Meghdar
        '
        Me.Meghdar.Border.BottomColor = System.Drawing.Color.Black
        Me.Meghdar.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar.Border.LeftColor = System.Drawing.Color.Black
        Me.Meghdar.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar.Border.RightColor = System.Drawing.Color.Black
        Me.Meghdar.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar.Border.TopColor = System.Drawing.Color.Black
        Me.Meghdar.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar.Height = 0.1875!
        Me.Meghdar.Left = 0.0625!
        Me.Meghdar.Name = "Meghdar"
        Me.Meghdar.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.Meghdar.Text = Nothing
        Me.Meghdar.Top = 2.375!
        Me.Meghdar.Width = 2.84!
        '
        'ReceiptDate
        '
        Me.ReceiptDate.Border.BottomColor = System.Drawing.Color.Black
        Me.ReceiptDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate.Border.LeftColor = System.Drawing.Color.Black
        Me.ReceiptDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate.Border.RightColor = System.Drawing.Color.Black
        Me.ReceiptDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate.Border.TopColor = System.Drawing.Color.Black
        Me.ReceiptDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate.Height = 0.1875!
        Me.ReceiptDate.Left = 0.0625!
        Me.ReceiptDate.Name = "ReceiptDate"
        Me.ReceiptDate.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.ReceiptDate.Text = Nothing
        Me.ReceiptDate.Top = 2.625!
        Me.ReceiptDate.Width = 2.84!
        '
        'TraceNo
        '
        Me.TraceNo.Border.BottomColor = System.Drawing.Color.Black
        Me.TraceNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo.Border.LeftColor = System.Drawing.Color.Black
        Me.TraceNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo.Border.RightColor = System.Drawing.Color.Black
        Me.TraceNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo.Border.TopColor = System.Drawing.Color.Black
        Me.TraceNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo.Height = 0.1875!
        Me.TraceNo.Left = 0.0625!
        Me.TraceNo.Name = "TraceNo"
        Me.TraceNo.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TraceNo.Text = Nothing
        Me.TraceNo.Top = 2.875!
        Me.TraceNo.Width = 2.84!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.25!
        Me.TextBox17.Left = 0.0!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "color: Black; ddo-char-set: 0; text-align: center; font-weight: normal; font-size" & _
    ": 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox17.Text = "QC01-000101"
        Me.TextBox17.Top = 0.4375!
        Me.TextBox17.Width = 1.375!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.3125!
        Me.TextBox32.Left = 0.0!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: normal; font-size:" & _
    " 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox32.Text = "شماره ویرایش :      01"
        Me.TextBox32.Top = 0.6875!
        Me.TextBox32.Width = 1.375!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.375!
        Me.TextBox33.Left = 6.9375!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "color: Black; text-align: center; font-weight: bold; font-size: 11pt; font-family" & _
    ": Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox33.Text = "بررسی نشده"
        Me.TextBox33.Top = 0.1875!
        Me.TextBox33.Width = 2.375!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Height = 0.813!
        Me.TextBox34.Left = 9.3125!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "color: Black; ddo-char-set: 0; text-align: center; font-weight: bold; font-size: " & _
    "7pt; font-family: Times New Roman; vertical-align: bottom; "
        Me.TextBox34.Text = "شرکت دارویی ، آرایشی و بهداشتی مینو"
        Me.TextBox34.Top = 0.1875!
        Me.TextBox34.Width = 1.5!
        '
        'Picture2
        '
        Me.Picture2.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.RightColor = System.Drawing.Color.Black
        Me.Picture2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.TopColor = System.Drawing.Color.Black
        Me.Picture2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Height = 0.4375!
        Me.Picture2.Image = CType(resources.GetObject("Picture2.Image"), System.Drawing.Image)
        Me.Picture2.ImageData = CType(resources.GetObject("Picture2.ImageData"), System.IO.Stream)
        Me.Picture2.Left = 9.75!
        Me.Picture2.LineWeight = 0.0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.Top = 0.3125!
        Me.Picture2.Width = 0.6875!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.Height = 0.438!
        Me.TextBox35.Left = 6.9375!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Style = "color: Black; text-align: center; font-weight: bold; font-size: 11pt; font-family" & _
    ": Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox35.Text = "Not For Use"
        Me.TextBox35.Top = 0.5625!
        Me.TextBox35.Width = 2.375!
        '
        'Tozih2
        '
        Me.Tozih2.Border.BottomColor = System.Drawing.Color.Black
        Me.Tozih2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Tozih2.Border.LeftColor = System.Drawing.Color.Black
        Me.Tozih2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Tozih2.Border.RightColor = System.Drawing.Color.Black
        Me.Tozih2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Tozih2.Border.TopColor = System.Drawing.Color.Black
        Me.Tozih2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Tozih2.Height = 0.375!
        Me.Tozih2.Left = 5.5625!
        Me.Tozih2.Name = "Tozih2"
        Me.Tozih2.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 1" & _
    "1pt; font-family: Times New Roman; vertical-align: top; "
        Me.Tozih2.Text = "توضیحات :"
        Me.Tozih2.Top = 3.125!
        Me.Tozih2.Width = 5.25!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Height = 0.25!
        Me.TextBox37.Left = 5.5625!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: normal; font-size:" & _
    " 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox37.Text = "شماره مدرک"
        Me.TextBox37.Top = 0.1875!
        Me.TextBox37.Width = 1.375!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Height = 2.125!
        Me.TextBox38.Left = 5.5625!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9" & _
    "pt; font-family: Times New Roman; vertical-align: top; "
        Me.TextBox38.Text = Nothing
        Me.TextBox38.Top = 1.0!
        Me.TextBox38.Width = 5.25!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Height = 0.1875!
        Me.TextBox39.Left = 8.5625!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox39.Text = "(Material Name) نام ماده "
        Me.TextBox39.Top = 1.125!
        Me.TextBox39.Width = 2.16!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Height = 0.1875!
        Me.TextBox40.Left = 8.5625!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox40.Text = "(Batch No.) شماره بچ سازنده"
        Me.TextBox40.Top = 1.375!
        Me.TextBox40.Width = 2.16!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Height = 0.1875!
        Me.TextBox41.Left = 8.5625!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox41.Text = "(Supplier) نام فروشنده"
        Me.TextBox41.Top = 1.625!
        Me.TextBox41.Width = 2.16!
        '
        'TextBox42
        '
        Me.TextBox42.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Height = 0.1875!
        Me.TextBox42.Left = 8.5625!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox42.Text = "(Mfg Date) تاریخ ساخت سازنده"
        Me.TextBox42.Top = 1.875!
        Me.TextBox42.Width = 2.16!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Height = 0.1875!
        Me.TextBox43.Left = 8.5625!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox43.Text = "(Exp Date) تاریخ انقضاء سازنده"
        Me.TextBox43.Top = 2.125!
        Me.TextBox43.Width = 2.16!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Height = 0.1875!
        Me.TextBox44.Left = 8.5625!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox44.Text = "مقدار/تعداد    ...........واحد"
        Me.TextBox44.Top = 2.375!
        Me.TextBox44.Width = 2.16!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Height = 0.1875!
        Me.TextBox45.Left = 8.5625!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox45.Text = "(Date Of Receipt) تاریخ وارده به انبار"
        Me.TextBox45.Top = 2.625!
        Me.TextBox45.Width = 2.16!
        '
        'TextBox46
        '
        Me.TextBox46.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox46.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox46.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox46.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox46.Height = 0.1875!
        Me.TextBox46.Left = 8.5625!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TextBox46.Text = "(Tracing No) شماره/کد رهگیری"
        Me.TextBox46.Top = 2.875!
        Me.TextBox46.Width = 2.16!
        '
        'KalaDS2
        '
        Me.KalaDS2.Border.BottomColor = System.Drawing.Color.Black
        Me.KalaDS2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.KalaDS2.Border.LeftColor = System.Drawing.Color.Black
        Me.KalaDS2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.KalaDS2.Border.RightColor = System.Drawing.Color.Black
        Me.KalaDS2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.KalaDS2.Border.TopColor = System.Drawing.Color.Black
        Me.KalaDS2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.KalaDS2.Height = 0.1875!
        Me.KalaDS2.Left = 5.625!
        Me.KalaDS2.Name = "KalaDS2"
        Me.KalaDS2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.KalaDS2.Text = Nothing
        Me.KalaDS2.Top = 1.125!
        Me.KalaDS2.Width = 2.84!
        '
        'Batchno2
        '
        Me.Batchno2.Border.BottomColor = System.Drawing.Color.Black
        Me.Batchno2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Batchno2.Border.LeftColor = System.Drawing.Color.Black
        Me.Batchno2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Batchno2.Border.RightColor = System.Drawing.Color.Black
        Me.Batchno2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Batchno2.Border.TopColor = System.Drawing.Color.Black
        Me.Batchno2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Batchno2.Height = 0.1875!
        Me.Batchno2.Left = 5.625!
        Me.Batchno2.Name = "Batchno2"
        Me.Batchno2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.Batchno2.Text = Nothing
        Me.Batchno2.Top = 1.375!
        Me.Batchno2.Width = 2.84!
        '
        'Supplier2
        '
        Me.Supplier2.Border.BottomColor = System.Drawing.Color.Black
        Me.Supplier2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier2.Border.LeftColor = System.Drawing.Color.Black
        Me.Supplier2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier2.Border.RightColor = System.Drawing.Color.Black
        Me.Supplier2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier2.Border.TopColor = System.Drawing.Color.Black
        Me.Supplier2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Supplier2.Height = 0.1875!
        Me.Supplier2.Left = 5.625!
        Me.Supplier2.Name = "Supplier2"
        Me.Supplier2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.Supplier2.Text = Nothing
        Me.Supplier2.Top = 1.625!
        Me.Supplier2.Width = 2.84!
        '
        'MfgDate2
        '
        Me.MfgDate2.Border.BottomColor = System.Drawing.Color.Black
        Me.MfgDate2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate2.Border.LeftColor = System.Drawing.Color.Black
        Me.MfgDate2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate2.Border.RightColor = System.Drawing.Color.Black
        Me.MfgDate2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate2.Border.TopColor = System.Drawing.Color.Black
        Me.MfgDate2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.MfgDate2.Height = 0.1875!
        Me.MfgDate2.Left = 5.625!
        Me.MfgDate2.Name = "MfgDate2"
        Me.MfgDate2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.MfgDate2.Text = Nothing
        Me.MfgDate2.Top = 1.875!
        Me.MfgDate2.Width = 2.84!
        '
        'ExpDate2
        '
        Me.ExpDate2.Border.BottomColor = System.Drawing.Color.Black
        Me.ExpDate2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate2.Border.LeftColor = System.Drawing.Color.Black
        Me.ExpDate2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate2.Border.RightColor = System.Drawing.Color.Black
        Me.ExpDate2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate2.Border.TopColor = System.Drawing.Color.Black
        Me.ExpDate2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ExpDate2.Height = 0.1875!
        Me.ExpDate2.Left = 5.625!
        Me.ExpDate2.Name = "ExpDate2"
        Me.ExpDate2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.ExpDate2.Text = Nothing
        Me.ExpDate2.Top = 2.125!
        Me.ExpDate2.Width = 2.84!
        '
        'Meghdar2
        '
        Me.Meghdar2.Border.BottomColor = System.Drawing.Color.Black
        Me.Meghdar2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar2.Border.LeftColor = System.Drawing.Color.Black
        Me.Meghdar2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar2.Border.RightColor = System.Drawing.Color.Black
        Me.Meghdar2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar2.Border.TopColor = System.Drawing.Color.Black
        Me.Meghdar2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Meghdar2.Height = 0.1875!
        Me.Meghdar2.Left = 5.625!
        Me.Meghdar2.Name = "Meghdar2"
        Me.Meghdar2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.Meghdar2.Text = Nothing
        Me.Meghdar2.Top = 2.375!
        Me.Meghdar2.Width = 2.84!
        '
        'ReceiptDate2
        '
        Me.ReceiptDate2.Border.BottomColor = System.Drawing.Color.Black
        Me.ReceiptDate2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate2.Border.LeftColor = System.Drawing.Color.Black
        Me.ReceiptDate2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate2.Border.RightColor = System.Drawing.Color.Black
        Me.ReceiptDate2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate2.Border.TopColor = System.Drawing.Color.Black
        Me.ReceiptDate2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReceiptDate2.Height = 0.1875!
        Me.ReceiptDate2.Left = 5.625!
        Me.ReceiptDate2.Name = "ReceiptDate2"
        Me.ReceiptDate2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.ReceiptDate2.Text = Nothing
        Me.ReceiptDate2.Top = 2.625!
        Me.ReceiptDate2.Width = 2.84!
        '
        'TraceNo2
        '
        Me.TraceNo2.Border.BottomColor = System.Drawing.Color.Black
        Me.TraceNo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo2.Border.LeftColor = System.Drawing.Color.Black
        Me.TraceNo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo2.Border.RightColor = System.Drawing.Color.Black
        Me.TraceNo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo2.Border.TopColor = System.Drawing.Color.Black
        Me.TraceNo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TraceNo2.Height = 0.1875!
        Me.TraceNo2.Left = 5.625!
        Me.TraceNo2.Name = "TraceNo2"
        Me.TraceNo2.Style = "color: Black; text-align: right; font-weight: bold; font-size: 10.5pt; font-famil" & _
    "y: Times New Roman; white-space: inherit; vertical-align: middle; "
        Me.TraceNo2.Text = Nothing
        Me.TraceNo2.Top = 2.875!
        Me.TraceNo2.Width = 2.84!
        '
        'TextBox55
        '
        Me.TextBox55.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Height = 0.25!
        Me.TextBox55.Left = 5.5625!
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Style = "color: Black; ddo-char-set: 0; text-align: center; font-weight: normal; font-size" & _
    ": 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox55.Text = "QC01-000101"
        Me.TextBox55.Top = 0.4375!
        Me.TextBox55.Width = 1.375!
        '
        'TextBox56
        '
        Me.TextBox56.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Height = 0.3125!
        Me.TextBox56.Left = 5.5625!
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Style = "color: Black; ddo-char-set: 0; text-align: right; font-weight: normal; font-size:" & _
    " 11pt; font-family: Times New Roman; vertical-align: middle; "
        Me.TextBox56.Text = "شماره ویرایش :      01"
        Me.TextBox56.Top = 0.6875!
        Me.TextBox56.Width = 1.375!
        '
        'ReportHeader
        '
        Me.ReportHeader.Height = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.01041667!
        Me.PageFooter.Name = "PageFooter"
        '
        'NotForUseLabel
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.9375!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.TxtCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCertificate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTozih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MfgDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meghdar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tozih2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalaDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Batchno2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MfgDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meghdar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraceNo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Sub DefineField()

        Dim PrintFontByUser As Font = New System.Drawing.Font(FontName, FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Dim PrintFont10 As Font = New System.Drawing.Font(FontName, 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Dim PrintFont13 As Font = New System.Drawing.Font(FontName, 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Dim PrintFont6 As Font = New System.Drawing.Font(FontName, 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        With Me.PageSettings.Margins
            .Bottom = 0
            .Left = 0.05
            .Right = 0
            .Top = 0
        End With

        MaterialName.DataField = "KalaDs"
        BatchNo.DataField = "BatchNo"
        Supplier.DataField = "Supplier"
        MfgDate.DataField = "ToolidDate"
        ExpDate.DataField = "EnghezaDate"
        Meghdar.DataField = "MeghdareVaredeh"
        TraceNo.DataField = "ShomarehRahgiri"
        ReceiptDate.DataField = "SanadDate"
        TxtTozih.DataField = "Tozih"

        KalaDS2.DataField = "KalaDs"
        Batchno2.DataField = "BatchNo"
        Supplier2.DataField = "Supplier"
        MfgDate2.DataField = "ToolidDate"
        ExpDate2.DataField = "EnghezaDate"
        Meghdar2.DataField = "MeghdareVaredeh"
        TraceNo2.DataField = "ShomarehRahgiri"
        ReceiptDate2.DataField = "SanadDate"
        Tozih2.DataField = "Tozih"

        TxtCertificate.Font = PrintFont13
        TxtCertificate2.Font = PrintFont13
        TextBox33.Font = PrintFont13
        TextBox35.Font = PrintFont13
        MaterialName.Font = PrintFontByUser
        BatchNo.Font = PrintFontByUser
        TraceNo.Font = PrintFontByUser
        ExpDate.Font = PrintFontByUser
        Supplier.Font = PrintFontByUser
        MfgDate.Font = PrintFontByUser
        ReceiptDate.Font = PrintFontByUser
        Meghdar.Font = PrintFontByUser
        TxtTozih.Font = PrintFont10
        KalaDS2.Font = PrintFontByUser
        Batchno2.Font = PrintFontByUser
        Supplier2.Font = PrintFontByUser
        MfgDate2.Font = PrintFontByUser
        ExpDate2.Font = PrintFontByUser
        Meghdar2.Font = PrintFontByUser
        TraceNo2.Font = PrintFontByUser
        ReceiptDate2.Font = PrintFontByUser
        Tozih2.Font = PrintFont10
        TextBox20.Font = PrintFont10
        TextBox25.Font = PrintFont10
        TextBox31.Font = PrintFont10
        TextBox26.Font = PrintFont10
        TextBox27.Font = PrintFont10
        TextBox29.Font = PrintFont10
        TextBox28.Font = PrintFont10
        TextBox30.Font = PrintFont10
        TextBox18.Font = PrintFont10
        TextBox17.Font = PrintFont10
        TextBox32.Font = PrintFont10
        TextBox37.Font = PrintFont10
        TextBox55.Font = PrintFont10
        TextBox56.Font = PrintFont10
        TextBox39.Font = PrintFont10
        TextBox40.Font = PrintFont10
        TextBox41.Font = PrintFont10
        TextBox42.Font = PrintFont10
        TextBox43.Font = PrintFont10
        TextBox44.Font = PrintFont10
        TextBox45.Font = PrintFont10
        TextBox46.Font = PrintFont10
        TxtCompany.Font = PrintFont6

    End Sub

End Class
