''Add By Dehghani <930710>
Imports System
Imports DataDynamics.ActiveReports

Public Class RptLabLabel
    Inherits ActiveReport3

    Friend WithEvents NfuPicture As DataDynamics.ActiveReports.Picture
    Friend WithEvents NfuKalaDS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuBatchNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuSupplier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuMfgDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuExpDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuMeghdar As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuDateOfReceipt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NfuTracingNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents UtPicture As DataDynamics.ActiveReports.Picture
    Friend WithEvents UtKalaDS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents UtBatchNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents UtDateOfSampling As DataDynamics.ActiveReports.TextBox
    Friend WithEvents UtNameOfSampler As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvPicture As DataDynamics.ActiveReports.Picture
    Friend WithEvents AprvExpDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents UtTracingNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvKalaDS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvBatchNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvTracingNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvLabNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents AprvSupplier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents RejPicture As DataDynamics.ActiveReports.Picture
    Friend WithEvents RejKalaDS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents RejBatchNO As DataDynamics.ActiveReports.TextBox
    Friend WithEvents RejLabNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents RejSupplier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "لیبل آزمایشگاه"
        'Me.PageSettings.PaperKind = Printing.PaperKind.Custom
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
    End Sub

#Region "ActiveReports Designer generated code"

    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private Page1 As DataDynamics.ActiveReports.Document.Page = Nothing

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptLabLabel))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.NfuPicture = New DataDynamics.ActiveReports.Picture()
        Me.NfuKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.NfuBatchNO = New DataDynamics.ActiveReports.TextBox()
        Me.NfuSupplier = New DataDynamics.ActiveReports.TextBox()
        Me.NfuMfgDate = New DataDynamics.ActiveReports.TextBox()
        Me.NfuExpDate = New DataDynamics.ActiveReports.TextBox()
        Me.NfuMeghdar = New DataDynamics.ActiveReports.TextBox()
        Me.NfuDateOfReceipt = New DataDynamics.ActiveReports.TextBox()
        Me.NfuTracingNo = New DataDynamics.ActiveReports.TextBox()
        Me.UtPicture = New DataDynamics.ActiveReports.Picture()
        Me.UtKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.UtBatchNO = New DataDynamics.ActiveReports.TextBox()
        Me.UtDateOfSampling = New DataDynamics.ActiveReports.TextBox()
        Me.UtNameOfSampler = New DataDynamics.ActiveReports.TextBox()
        Me.AprvPicture = New DataDynamics.ActiveReports.Picture()
        Me.AprvExpDate = New DataDynamics.ActiveReports.TextBox()
        Me.UtTracingNO = New DataDynamics.ActiveReports.TextBox()
        Me.AprvKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.AprvBatchNO = New DataDynamics.ActiveReports.TextBox()
        Me.AprvTracingNO = New DataDynamics.ActiveReports.TextBox()
        Me.AprvLabNo = New DataDynamics.ActiveReports.TextBox()
        Me.AprvSupplier = New DataDynamics.ActiveReports.TextBox()
        Me.RejPicture = New DataDynamics.ActiveReports.Picture()
        Me.RejKalaDS = New DataDynamics.ActiveReports.TextBox()
        Me.RejBatchNO = New DataDynamics.ActiveReports.TextBox()
        Me.RejLabNo = New DataDynamics.ActiveReports.TextBox()
        Me.RejSupplier = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.NfuPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuBatchNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuMfgDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuExpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuMeghdar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuDateOfReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NfuTracingNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtBatchNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtDateOfSampling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtNameOfSampler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvExpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtTracingNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvBatchNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvTracingNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvLabNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AprvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejKalaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejBatchNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejLabNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.NfuPicture, Me.NfuKalaDS, Me.NfuBatchNO, Me.NfuSupplier, Me.NfuMfgDate, Me.NfuExpDate, Me.NfuMeghdar, Me.NfuDateOfReceipt, Me.NfuTracingNo, Me.UtPicture, Me.UtKalaDS, Me.UtBatchNO, Me.UtDateOfSampling, Me.UtNameOfSampler, Me.AprvPicture, Me.AprvExpDate, Me.UtTracingNO, Me.AprvKalaDS, Me.AprvBatchNO, Me.AprvTracingNO, Me.AprvLabNo, Me.AprvSupplier, Me.RejPicture, Me.RejKalaDS, Me.RejBatchNO, Me.RejLabNo, Me.RejSupplier})
        Me.Detail.Height = 3.541667!
        Me.Detail.Name = "Detail"
        '
        'NfuPicture
        '
        Me.NfuPicture.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuPicture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuPicture.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuPicture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuPicture.Border.RightColor = System.Drawing.Color.Black
        Me.NfuPicture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuPicture.Border.TopColor = System.Drawing.Color.Black
        Me.NfuPicture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuPicture.Height = 3.35!
        Me.NfuPicture.Image = CType(resources.GetObject("NfuPicture.Image"), System.Drawing.Image)
        Me.NfuPicture.ImageData = CType(resources.GetObject("NfuPicture.ImageData"), System.IO.Stream)
        Me.NfuPicture.Left = 0.4375!
        Me.NfuPicture.LineWeight = 0.0!
        Me.NfuPicture.Name = "NfuPicture"
        Me.NfuPicture.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.NfuPicture.Top = 0.125!
        Me.NfuPicture.Width = 5.512!
        '
        'NfuKalaDS
        '
        Me.NfuKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.NfuKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.NfuKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuKalaDS.Height = 0.1875!
        Me.NfuKalaDS.Left = 0.5625!
        Me.NfuKalaDS.Name = "NfuKalaDS"
        Me.NfuKalaDS.Style = "text-align: right; vertical-align: middle; "
        Me.NfuKalaDS.Text = "NfuKalaDS"
        Me.NfuKalaDS.Top = 0.98!
        Me.NfuKalaDS.Width = 3.0!
        '
        'NfuBatchNO
        '
        Me.NfuBatchNO.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuBatchNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuBatchNO.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuBatchNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuBatchNO.Border.RightColor = System.Drawing.Color.Black
        Me.NfuBatchNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuBatchNO.Border.TopColor = System.Drawing.Color.Black
        Me.NfuBatchNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuBatchNO.Height = 0.1875!
        Me.NfuBatchNO.Left = 0.5625!
        Me.NfuBatchNO.Name = "NfuBatchNO"
        Me.NfuBatchNO.Style = "text-align: right; vertical-align: middle; "
        Me.NfuBatchNO.Text = "NfuBatchNO"
        Me.NfuBatchNO.Top = 1.25!
        Me.NfuBatchNO.Width = 3.0!
        '
        'NfuSupplier
        '
        Me.NfuSupplier.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuSupplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuSupplier.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuSupplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuSupplier.Border.RightColor = System.Drawing.Color.Black
        Me.NfuSupplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuSupplier.Border.TopColor = System.Drawing.Color.Black
        Me.NfuSupplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuSupplier.Height = 0.1875!
        Me.NfuSupplier.Left = 0.5625!
        Me.NfuSupplier.Name = "NfuSupplier"
        Me.NfuSupplier.Style = "text-align: right; vertical-align: middle; "
        Me.NfuSupplier.Text = "NfuSupplier"
        Me.NfuSupplier.Top = 1.52!
        Me.NfuSupplier.Width = 3.0!
        '
        'NfuMfgDate
        '
        Me.NfuMfgDate.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuMfgDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMfgDate.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuMfgDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMfgDate.Border.RightColor = System.Drawing.Color.Black
        Me.NfuMfgDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMfgDate.Border.TopColor = System.Drawing.Color.Black
        Me.NfuMfgDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMfgDate.Height = 0.1875!
        Me.NfuMfgDate.Left = 0.5625!
        Me.NfuMfgDate.Name = "NfuMfgDate"
        Me.NfuMfgDate.Style = "text-align: right; vertical-align: middle; "
        Me.NfuMfgDate.Text = "NfuMfgDate"
        Me.NfuMfgDate.Top = 1.78!
        Me.NfuMfgDate.Width = 3.0!
        '
        'NfuExpDate
        '
        Me.NfuExpDate.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuExpDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuExpDate.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuExpDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuExpDate.Border.RightColor = System.Drawing.Color.Black
        Me.NfuExpDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuExpDate.Border.TopColor = System.Drawing.Color.Black
        Me.NfuExpDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuExpDate.Height = 0.1875!
        Me.NfuExpDate.Left = 0.5625!
        Me.NfuExpDate.Name = "NfuExpDate"
        Me.NfuExpDate.Style = "text-align: right; vertical-align: middle; "
        Me.NfuExpDate.Text = "NfuExpDate"
        Me.NfuExpDate.Top = 2.05!
        Me.NfuExpDate.Width = 3.0!
        '
        'NfuMeghdar
        '
        Me.NfuMeghdar.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuMeghdar.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMeghdar.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuMeghdar.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMeghdar.Border.RightColor = System.Drawing.Color.Black
        Me.NfuMeghdar.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMeghdar.Border.TopColor = System.Drawing.Color.Black
        Me.NfuMeghdar.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuMeghdar.Height = 0.1875!
        Me.NfuMeghdar.Left = 0.5625!
        Me.NfuMeghdar.Name = "NfuMeghdar"
        Me.NfuMeghdar.Style = "text-align: right; vertical-align: middle; "
        Me.NfuMeghdar.Text = "NfuMeghdar"
        Me.NfuMeghdar.Top = 2.32!
        Me.NfuMeghdar.Width = 3.0!
        '
        'NfuDateOfReceipt
        '
        Me.NfuDateOfReceipt.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuDateOfReceipt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuDateOfReceipt.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuDateOfReceipt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuDateOfReceipt.Border.RightColor = System.Drawing.Color.Black
        Me.NfuDateOfReceipt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuDateOfReceipt.Border.TopColor = System.Drawing.Color.Black
        Me.NfuDateOfReceipt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuDateOfReceipt.Height = 0.1875!
        Me.NfuDateOfReceipt.Left = 0.5625!
        Me.NfuDateOfReceipt.Name = "NfuDateOfReceipt"
        Me.NfuDateOfReceipt.Style = "text-align: right; vertical-align: middle; "
        Me.NfuDateOfReceipt.Text = "NfuDateOfReceipt"
        Me.NfuDateOfReceipt.Top = 2.57!
        Me.NfuDateOfReceipt.Width = 3.0!
        '
        'NfuTracingNo
        '
        Me.NfuTracingNo.Border.BottomColor = System.Drawing.Color.Black
        Me.NfuTracingNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuTracingNo.Border.LeftColor = System.Drawing.Color.Black
        Me.NfuTracingNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuTracingNo.Border.RightColor = System.Drawing.Color.Black
        Me.NfuTracingNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuTracingNo.Border.TopColor = System.Drawing.Color.Black
        Me.NfuTracingNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NfuTracingNo.Height = 0.1875!
        Me.NfuTracingNo.Left = 0.5625!
        Me.NfuTracingNo.Name = "NfuTracingNo"
        Me.NfuTracingNo.Style = "text-align: right; vertical-align: middle; "
        Me.NfuTracingNo.Text = "NfuTracingNo"
        Me.NfuTracingNo.Top = 2.84!
        Me.NfuTracingNo.Width = 3.0!
        '
        'UtPicture
        '
        Me.UtPicture.Border.BottomColor = System.Drawing.Color.Black
        Me.UtPicture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtPicture.Border.LeftColor = System.Drawing.Color.Black
        Me.UtPicture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtPicture.Border.RightColor = System.Drawing.Color.Black
        Me.UtPicture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtPicture.Border.TopColor = System.Drawing.Color.Black
        Me.UtPicture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtPicture.Height = 3.35!
        Me.UtPicture.Image = CType(resources.GetObject("UtPicture.Image"), System.Drawing.Image)
        Me.UtPicture.ImageData = CType(resources.GetObject("UtPicture.ImageData"), System.IO.Stream)
        Me.UtPicture.Left = 6.125!
        Me.UtPicture.LineWeight = 0.0!
        Me.UtPicture.Name = "UtPicture"
        Me.UtPicture.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.UtPicture.Top = 0.0625!
        Me.UtPicture.Width = 5.512!
        '
        'UtKalaDS
        '
        Me.UtKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.UtKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.UtKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.UtKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.UtKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtKalaDS.Height = 0.1875!
        Me.UtKalaDS.Left = 6.25!
        Me.UtKalaDS.MultiLine = False
        Me.UtKalaDS.Name = "UtKalaDS"
        Me.UtKalaDS.Style = "text-align: right; vertical-align: middle; "
        Me.UtKalaDS.Text = "UtKalaDS"
        Me.UtKalaDS.Top = 1.17!
        Me.UtKalaDS.Width = 3.1875!
        '
        'UtBatchNO
        '
        Me.UtBatchNO.Border.BottomColor = System.Drawing.Color.Black
        Me.UtBatchNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtBatchNO.Border.LeftColor = System.Drawing.Color.Black
        Me.UtBatchNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtBatchNO.Border.RightColor = System.Drawing.Color.Black
        Me.UtBatchNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtBatchNO.Border.TopColor = System.Drawing.Color.Black
        Me.UtBatchNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtBatchNO.Height = 0.1875!
        Me.UtBatchNO.Left = 6.25!
        Me.UtBatchNO.MultiLine = False
        Me.UtBatchNO.Name = "UtBatchNO"
        Me.UtBatchNO.Style = "text-align: right; vertical-align: middle; "
        Me.UtBatchNO.Text = "UtBatchNO"
        Me.UtBatchNO.Top = 1.54!
        Me.UtBatchNO.Width = 3.1875!
        '
        'UtDateOfSampling
        '
        Me.UtDateOfSampling.Border.BottomColor = System.Drawing.Color.Black
        Me.UtDateOfSampling.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtDateOfSampling.Border.LeftColor = System.Drawing.Color.Black
        Me.UtDateOfSampling.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtDateOfSampling.Border.RightColor = System.Drawing.Color.Black
        Me.UtDateOfSampling.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtDateOfSampling.Border.TopColor = System.Drawing.Color.Black
        Me.UtDateOfSampling.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtDateOfSampling.Height = 0.1875!
        Me.UtDateOfSampling.Left = 6.25!
        Me.UtDateOfSampling.MultiLine = False
        Me.UtDateOfSampling.Name = "UtDateOfSampling"
        Me.UtDateOfSampling.Style = "text-align: right; vertical-align: middle; "
        Me.UtDateOfSampling.Text = "UtDateOfSampling"
        Me.UtDateOfSampling.Top = 2.28!
        Me.UtDateOfSampling.Width = 3.0625!
        '
        'UtNameOfSampler
        '
        Me.UtNameOfSampler.Border.BottomColor = System.Drawing.Color.Black
        Me.UtNameOfSampler.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtNameOfSampler.Border.LeftColor = System.Drawing.Color.Black
        Me.UtNameOfSampler.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtNameOfSampler.Border.RightColor = System.Drawing.Color.Black
        Me.UtNameOfSampler.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtNameOfSampler.Border.TopColor = System.Drawing.Color.Black
        Me.UtNameOfSampler.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtNameOfSampler.Height = 0.1875!
        Me.UtNameOfSampler.Left = 6.25!
        Me.UtNameOfSampler.MultiLine = False
        Me.UtNameOfSampler.Name = "UtNameOfSampler"
        Me.UtNameOfSampler.Style = "text-align: right; vertical-align: middle; "
        Me.UtNameOfSampler.Text = "UtNameOfSampler"
        Me.UtNameOfSampler.Top = 2.66!
        Me.UtNameOfSampler.Width = 2.4375!
        '
        'AprvPicture
        '
        Me.AprvPicture.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvPicture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvPicture.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvPicture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvPicture.Border.RightColor = System.Drawing.Color.Black
        Me.AprvPicture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvPicture.Border.TopColor = System.Drawing.Color.Black
        Me.AprvPicture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvPicture.Height = 3.35!
        Me.AprvPicture.Image = CType(resources.GetObject("AprvPicture.Image"), System.Drawing.Image)
        Me.AprvPicture.ImageData = CType(resources.GetObject("AprvPicture.ImageData"), System.IO.Stream)
        Me.AprvPicture.Left = 0.5!
        Me.AprvPicture.LineWeight = 0.0!
        Me.AprvPicture.Name = "AprvPicture"
        Me.AprvPicture.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.AprvPicture.Top = 3.625!
        Me.AprvPicture.Width = 5.512!
        '
        'AprvExpDate
        '
        Me.AprvExpDate.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvExpDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvExpDate.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvExpDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvExpDate.Border.RightColor = System.Drawing.Color.Black
        Me.AprvExpDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvExpDate.Border.TopColor = System.Drawing.Color.Black
        Me.AprvExpDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvExpDate.Height = 0.1875!
        Me.AprvExpDate.Left = 0.625!
        Me.AprvExpDate.Name = "AprvExpDate"
        Me.AprvExpDate.Style = "text-align: right; vertical-align: middle; "
        Me.AprvExpDate.Text = "AprvExpDate"
        Me.AprvExpDate.Top = 6.35!
        Me.AprvExpDate.Width = 2.375!
        '
        'UtTracingNO
        '
        Me.UtTracingNO.Border.BottomColor = System.Drawing.Color.Black
        Me.UtTracingNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtTracingNO.Border.LeftColor = System.Drawing.Color.Black
        Me.UtTracingNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtTracingNO.Border.RightColor = System.Drawing.Color.Black
        Me.UtTracingNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtTracingNO.Border.TopColor = System.Drawing.Color.Black
        Me.UtTracingNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.UtTracingNO.Height = 0.1875!
        Me.UtTracingNO.Left = 6.25!
        Me.UtTracingNO.MultiLine = False
        Me.UtTracingNO.Name = "UtTracingNO"
        Me.UtTracingNO.Style = "text-align: right; vertical-align: middle; "
        Me.UtTracingNO.Text = "UtTracingNO"
        Me.UtTracingNO.Top = 1.92!
        Me.UtTracingNO.Width = 3.1875!
        '
        'AprvKalaDS
        '
        Me.AprvKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.AprvKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.AprvKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvKalaDS.Height = 0.1875!
        Me.AprvKalaDS.Left = 0.625!
        Me.AprvKalaDS.Name = "AprvKalaDS"
        Me.AprvKalaDS.Style = "text-align: right; vertical-align: middle; "
        Me.AprvKalaDS.Text = "AprvKalaDS"
        Me.AprvKalaDS.Top = 4.58!
        Me.AprvKalaDS.Width = 3.0625!
        '
        'AprvBatchNO
        '
        Me.AprvBatchNO.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvBatchNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvBatchNO.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvBatchNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvBatchNO.Border.RightColor = System.Drawing.Color.Black
        Me.AprvBatchNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvBatchNO.Border.TopColor = System.Drawing.Color.Black
        Me.AprvBatchNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvBatchNO.Height = 0.1875!
        Me.AprvBatchNO.Left = 0.625!
        Me.AprvBatchNO.Name = "AprvBatchNO"
        Me.AprvBatchNO.Style = "text-align: right; vertical-align: middle; "
        Me.AprvBatchNO.Text = "AprvBatchNO"
        Me.AprvBatchNO.Top = 4.93!
        Me.AprvBatchNO.Width = 3.0625!
        '
        'AprvTracingNO
        '
        Me.AprvTracingNO.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvTracingNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvTracingNO.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvTracingNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvTracingNO.Border.RightColor = System.Drawing.Color.Black
        Me.AprvTracingNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvTracingNO.Border.TopColor = System.Drawing.Color.Black
        Me.AprvTracingNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvTracingNO.Height = 0.1875!
        Me.AprvTracingNO.Left = 0.625!
        Me.AprvTracingNO.Name = "AprvTracingNO"
        Me.AprvTracingNO.Style = "text-align: right; vertical-align: middle; "
        Me.AprvTracingNO.Text = "AprvTracingNO"
        Me.AprvTracingNO.Top = 5.25!
        Me.AprvTracingNO.Width = 3.0625!
        '
        'AprvLabNo
        '
        Me.AprvLabNo.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvLabNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvLabNo.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvLabNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvLabNo.Border.RightColor = System.Drawing.Color.Black
        Me.AprvLabNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvLabNo.Border.TopColor = System.Drawing.Color.Black
        Me.AprvLabNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvLabNo.Height = 0.1875!
        Me.AprvLabNo.Left = 0.625!
        Me.AprvLabNo.Name = "AprvLabNo"
        Me.AprvLabNo.Style = "text-align: right; vertical-align: middle; "
        Me.AprvLabNo.Text = "AprvLabNo"
        Me.AprvLabNo.Top = 5.58!
        Me.AprvLabNo.Width = 3.0625!
        '
        'AprvSupplier
        '
        Me.AprvSupplier.Border.BottomColor = System.Drawing.Color.Black
        Me.AprvSupplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvSupplier.Border.LeftColor = System.Drawing.Color.Black
        Me.AprvSupplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvSupplier.Border.RightColor = System.Drawing.Color.Black
        Me.AprvSupplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvSupplier.Border.TopColor = System.Drawing.Color.Black
        Me.AprvSupplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.AprvSupplier.Height = 0.1875!
        Me.AprvSupplier.Left = 0.625!
        Me.AprvSupplier.Name = "AprvSupplier"
        Me.AprvSupplier.Style = "text-align: right; vertical-align: middle; "
        Me.AprvSupplier.Text = "AprvSupplier"
        Me.AprvSupplier.Top = 5.95!
        Me.AprvSupplier.Width = 3.0625!
        '
        'RejPicture
        '
        Me.RejPicture.Border.BottomColor = System.Drawing.Color.Black
        Me.RejPicture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejPicture.Border.LeftColor = System.Drawing.Color.Black
        Me.RejPicture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejPicture.Border.RightColor = System.Drawing.Color.Black
        Me.RejPicture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejPicture.Border.TopColor = System.Drawing.Color.Black
        Me.RejPicture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejPicture.Height = 3.35!
        Me.RejPicture.Image = CType(resources.GetObject("RejPicture.Image"), System.Drawing.Image)
        Me.RejPicture.ImageData = CType(resources.GetObject("RejPicture.ImageData"), System.IO.Stream)
        Me.RejPicture.Left = 6.125!
        Me.RejPicture.LineWeight = 0.0!
        Me.RejPicture.Name = "RejPicture"
        Me.RejPicture.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.RejPicture.Top = 3.5625!
        Me.RejPicture.Width = 5.512!
        '
        'RejKalaDS
        '
        Me.RejKalaDS.Border.BottomColor = System.Drawing.Color.Black
        Me.RejKalaDS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejKalaDS.Border.LeftColor = System.Drawing.Color.Black
        Me.RejKalaDS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejKalaDS.Border.RightColor = System.Drawing.Color.Black
        Me.RejKalaDS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejKalaDS.Border.TopColor = System.Drawing.Color.Black
        Me.RejKalaDS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejKalaDS.Height = 0.1875!
        Me.RejKalaDS.Left = 6.25!
        Me.RejKalaDS.MultiLine = False
        Me.RejKalaDS.Name = "RejKalaDS"
        Me.RejKalaDS.Style = "text-align: right; vertical-align: middle; "
        Me.RejKalaDS.Text = "RejKalaDS"
        Me.RejKalaDS.Top = 4.83!
        Me.RejKalaDS.Width = 3.5625!
        '
        'RejBatchNO
        '
        Me.RejBatchNO.Border.BottomColor = System.Drawing.Color.Black
        Me.RejBatchNO.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejBatchNO.Border.LeftColor = System.Drawing.Color.Black
        Me.RejBatchNO.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejBatchNO.Border.RightColor = System.Drawing.Color.Black
        Me.RejBatchNO.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejBatchNO.Border.TopColor = System.Drawing.Color.Black
        Me.RejBatchNO.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejBatchNO.Height = 0.1875!
        Me.RejBatchNO.Left = 6.25!
        Me.RejBatchNO.MultiLine = False
        Me.RejBatchNO.Name = "RejBatchNO"
        Me.RejBatchNO.Style = "text-align: right; vertical-align: middle; "
        Me.RejBatchNO.Text = "RejBatchNO"
        Me.RejBatchNO.Top = 5.28!
        Me.RejBatchNO.Width = 3.5625!
        '
        'RejLabNo
        '
        Me.RejLabNo.Border.BottomColor = System.Drawing.Color.Black
        Me.RejLabNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejLabNo.Border.LeftColor = System.Drawing.Color.Black
        Me.RejLabNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejLabNo.Border.RightColor = System.Drawing.Color.Black
        Me.RejLabNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejLabNo.Border.TopColor = System.Drawing.Color.Black
        Me.RejLabNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejLabNo.Height = 0.1875!
        Me.RejLabNo.Left = 6.25!
        Me.RejLabNo.MultiLine = False
        Me.RejLabNo.Name = "RejLabNo"
        Me.RejLabNo.Style = "text-align: right; vertical-align: middle; "
        Me.RejLabNo.Text = "RejLabNo"
        Me.RejLabNo.Top = 5.72!
        Me.RejLabNo.Width = 3.5625!
        '
        'RejSupplier
        '
        Me.RejSupplier.Border.BottomColor = System.Drawing.Color.Black
        Me.RejSupplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejSupplier.Border.LeftColor = System.Drawing.Color.Black
        Me.RejSupplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejSupplier.Border.RightColor = System.Drawing.Color.Black
        Me.RejSupplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejSupplier.Border.TopColor = System.Drawing.Color.Black
        Me.RejSupplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RejSupplier.Height = 0.1875!
        Me.RejSupplier.Left = 6.25!
        Me.RejSupplier.MultiLine = False
        Me.RejSupplier.Name = "RejSupplier"
        Me.RejSupplier.Style = "text-align: right; vertical-align: middle; "
        Me.RejSupplier.Text = "RejSupplier"
        Me.RejSupplier.Top = 6.22!
        Me.RejSupplier.Width = 3.5625!
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
        Me.PageHeader.CanGrow = False
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.01041667!
        Me.PageFooter.Name = "PageFooter"
        '
        'RptLabLabel
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.147417!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.NfuPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuBatchNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuMfgDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuExpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuMeghdar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuDateOfReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NfuTracingNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtBatchNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtDateOfSampling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtNameOfSampler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvExpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtTracingNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvBatchNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvTracingNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvLabNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AprvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejKalaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejBatchNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejLabNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Sub HiddenFields()
        AprvPicture.Visible = False
        AprvBatchNo.Visible = False
        AprvExpDate.Visible = False
        AprvKalaDS.Visible = False
        AprvLabNo.Visible = False
        AprvSupplier.Visible = False
        RejBatchNO.Visible = False
        RejKalaDS.Visible = False
        RejLabNo.Visible = False
        RejPicture.Visible = False
        RejSupplier.Visible = False
        NfuPicture.Visible = False
        NfuKalaDS.Visible = False
        NfuBatchNO.Visible = False
        NfuMfgDate.Visible = False
        NfuExpDate.Visible = False
        NfuDateOfReceipt.Visible = False
        NfuMeghdar.Visible = False
        NfuSupplier.Visible = False
        NfuTracingNo.Visible = False
        UtBatchNO.Visible = False
        UtDateOfSampling.Visible = False
        UtKalaDS.Visible = False
        UtNameOfSampler.Visible = False
        UtPicture.Visible = False
        UtTracingNO.Visible = False
        AprvTracingNO.Visible = False
    End Sub

End Class
