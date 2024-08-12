Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptabAnbargardani
    Private i As Integer = 0

    Public Sub DefField()

    End Sub


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Detail1.Format
        i = i + 1
        txtRadif.Text = i.ToString
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles PageHeader1.Format
        ' تهيه تاريخ از سرور
        LblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                 cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash)
    End Sub

    Private Sub RptabAnbargardani_ReportEnd(sender As Object, e As System.EventArgs) Handles Me.ReportEnd
        i = 0
    End Sub
End Class
