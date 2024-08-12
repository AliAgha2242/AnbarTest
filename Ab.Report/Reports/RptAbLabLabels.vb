Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptAbLabLabels
    Inherits ActiveReport3

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Me.Document.Name = "برچسب آزمایشگاه"
        Me.PageSettings.Orientation = PageOrientation.Portrait
        Me.PageSettings.PaperKind = Printing.PaperKind.Standard10x14

    End Sub
End Class
