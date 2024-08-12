Public Class FrmListMahsulateBarcodKhan
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        'getReport()
    End Sub
    Private Sub SetColumns()

        For Each Col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            Col.AutoSize()
        Next

    End Sub
    Private Sub getReport()
        Dim _Dv As DataView
        Dim waitForm As New Anbar.Common.Frmwait
        Try
            waitForm.Show()
            waitForm.Refresh()
            _Dv = cn.ExecuteQuery("Exec abSPr_ProductCatalogueListTakhsisMahsul")
            GridEX1.DataSource = _Dv
            GridEX1.RetrieveStructure()
            SetColumns()
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("بروز خطا " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "هشدار")
        Finally
            waitForm.Close()
        End Try
    End Sub
    Private Sub FrmListMahsulateBarcodKhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnViewReport.Visible = False
        Me.WindowState = FormWindowState.Maximized
        getReport()
    End Sub
End Class