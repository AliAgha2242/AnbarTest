Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptBargeKhorooj 

    Public strMobileRanandeh As String
    Public strMaghsad As String
    Public strNameRanandeh As String
    Public strShomarehMashin As String
    Public strBarbariDS As String
    Public strBarnamehNo As String
    Public strMablagh As String
    Public strSanadDS As String
    Public strBarnamehDS As String
    Public strBoxOut As String
    Public strShomarehGavahiNameh As String
    Public strNoeKhodro As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.Document.Name = "»—ê Œ—ÊÃ"
        Me.Label33.Text = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash)
        Me.Label34.Text = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server(cn, Functions.FTDBCommonFunctions.enmTimeFormat.HHmm)
    End Sub

    Private Sub rptBargeKhorooj_ReportStart(sender As Object, e As System.EventArgs) Handles Me.ReportStart
        Me.txtMobileRanandeh.Text = strMobileRanandeh
        Me.txtMaghsad.Text = strMaghsad
        Me.txtNameRanandeh.Text = strNameRanandeh
        Me.txtShomarehMashin.Text = strShomarehMashin
        Me.txtBarbariDS.Text = strBarbariDS
        Me.txtBarnamehNo.Text = strBarnamehNo
        Me.txtMablagh.Text = strMablagh
        Me.txtSanadDS.Text = strSanadDS
        Me.txtBarnamehDS.Text = strBarnamehDS
        Me.txtBoxOut.Text = strBoxOut
        Me.txtShomarehGavahiNameh.Text = strShomarehGavahiNameh
        Me.txtNoeKhodro.Text = strNoeKhodro
    End Sub
End Class
