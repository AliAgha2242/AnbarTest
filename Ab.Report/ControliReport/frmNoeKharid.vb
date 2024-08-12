Public Class frmNoeKharid

    Public NoeKharid As Double
    Public TaghazaKonandeh As Double

    Private Sub frmNoeKharid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbcTaghazaKonandeh.Bind(cn, "select ChartSazemaniSN, ChartSazemaniNoDs from PaVWChartSazemani", "ChartSazemaniSN", "ChartSazemaniNoDs")
        dbcTaghazaKonandeh.LateBinding = True
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If rdoDakheli.Checked Then
            NoeKharid = 1.101
        ElseIf rdoKhareji.Checked Then
            NoeKharid = 2.101
        End If

        If (dbcTaghazaKonandeh.MatchedWithList AndAlso Val(dbcTaghazaKonandeh.SelectedValue) > 0) Then
            TaghazaKonandeh = dbcTaghazaKonandeh.SelectedValue
            DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("واحد تقاضا کننده الزامی است")
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class