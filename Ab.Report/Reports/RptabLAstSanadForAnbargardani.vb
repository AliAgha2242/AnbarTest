Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptabLAstSanadForAnbargardani
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
        Dim Tdate As String = gHesabdariSal.ToString + "/12/" + gHesabdariSalTDate.Substring(6, 2)
        Label2.Text = "آخرین اسناد انبار مربوط به سال منتهی به " + Tdate + " بشرح ذیل می باشد: "
    End Sub
End Class
