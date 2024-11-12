Public Class FrmListMahsulateBarcodKhan
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        getReport()
    End Sub
    Private Sub SetColumns()

        For Each Col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            Col.AutoSize()
        Next

    End Sub
    Private Sub getReport()
        Dim _Dv As DataView
        Dim KalaSN As String = ""
        Dim TaminSN As String = ""

        If Not (cmbKala.getStringValues Is Nothing OrElse cmbKala.getStringValues = "0.000") Then
            KalaSN = cmbKala.getStringValues
        End If
        If Not (cmbTaminKonandeh.getStringValues Is Nothing OrElse cmbTaminKonandeh.getStringValues = "0.000") Then
            TaminSN = cmbTaminKonandeh.getStringValues
        End If

        If Not IsNumeric(txtIRC.Text) AndAlso txtIRC.Text <> "" Then
            MsgBox("IRC می بایست عددی باشد", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf Not IsNumeric(txtGTIN.Text) AndAlso txtGTIN.Text <> "" Then
            MsgBox("GTIN می بایست عددی باشد", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim waitForm As New Anbar.Common.Frmwait
        Try
            waitForm.Show()
            waitForm.Refresh()
            _Dv = cn.ExecuteQuery("Exec abSPr_ProductCatalogue_GetIRCGTIN_KalaBatch '" & TaminSN & "','" & KalaSN & "','" & txtIRC.Text & "','" & txtGTIN.Text & "'")
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
        Me.WindowState = FormWindowState.Maximized

        Dim Sql As String
        Sql = "SELECT K.KalaSN , K.KalaDs +' '+ K.KalaNo KalaDS " &
                " FROM paKala K JOIN paKalaTamin T ON T.KalaSN = K.KalaSN " &
                " JOIN paVahedeTejari V ON V.VahedeTejariSN = T.VahedeTejariSN " &
                " Where V.NoeVahedeTejariSN IN ( 16.935 , 14.935)"

        cmbKala.Bind(cn, Sql, "KalaSN", "KalaDS")

        cmbKala.ShowSelectAll = True

        Sql = "  Select distinct paVahedeTejari.VahedeTejariSN , VahedeTejariDs   From paVahedeTejari " &
        " Join paKalaTamin ON paKalaTamin.VahedeTejariSN = paVahedeTejari.VahedeTejariSN " &
        " Where  VahedeTejariStatus =  1 AND NoeVahedeTejariSN IN (16.935 , 14.935) "
        cmbTaminKonandeh.Bind(cn, Sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbTaminKonandeh.ShowSelectAll = True


    End Sub
End Class