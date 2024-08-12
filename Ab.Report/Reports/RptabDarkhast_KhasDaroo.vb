Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class RptabDarkhast_KhasDaroo
    Private i As Integer = 0

    Public Sub DefField()
        ' تعريف فيلدهاي گزارش با توجه به ستون هاي فراخواني شده از بانک اطلاعاتي
        'lblBarnameh.DataField = "ShomarehBarnameh"
        'lblKamiun.DataField = "ShomarehKamiun"
        'lblRanandeh.DataField = "NameRanandeh"

    End Sub


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Detail1.Format
        i = i + 1
        txtRadif.Text = i.ToString
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles PageHeader1.Format
        ' تهيه تاريخ از سرور
        LblDate.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                 cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash).Substring(2, 8)
    End Sub

End Class
