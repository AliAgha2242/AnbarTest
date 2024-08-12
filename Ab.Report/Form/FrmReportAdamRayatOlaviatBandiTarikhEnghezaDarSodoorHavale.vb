Imports Anbar.DAL

Public Class FrmReportAdamRayatOlaviatBandiTarikhEnghezaDarSodoorHavale
    Dim Sql As String = String.Empty
    Dim taminKonandehsNs As String = ""
    Dim shoabSNs As String = ""
    Dim tarakoneshSN As String = ""
    Dim kalaSns As String = ""
    Dim accessToData As IClsDataAccess
    Private dclToDate As NetSql.Components.CDateCtrl
    Private dclFromDate As NetSql.Components.CDateCtrl

    Private Sub FrmReportAdamRayatOlaviatBandiTarikhEnghezaDarSodoorHavale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        FillCombo()
        FillKala("")
        SetDate()
    End Sub
    Private Sub getReport()
        shoabSNs = cmbShobeh.getStringValues
        taminKonandehsNs = cmbTaminKonandeh.getStringValues
        kalaSns = cmbKala.getStringValues
        tarakoneshSN = cmbTarakonesh.getStringValues

        If String.IsNullOrEmpty(shoabSNs) Or shoabSNs = "0.000" Or shoabSNs = "0" Then
            shoabSNs = ""
        End If
        If String.IsNullOrEmpty(taminKonandehsNs) Or taminKonandehsNs = "0.000" Or taminKonandehsNs = "0" Then
            taminKonandehsNs = ""
        End If
        If String.IsNullOrEmpty(kalaSns) Or kalaSns = "0.000" Or kalaSns = "0" Then
            kalaSns = ""
        End If
        If String.IsNullOrEmpty(tarakoneshSN) Or tarakoneshSN = "0.000" Or tarakoneshSN = "0" Then
            tarakoneshSN = ""
        End If
        If Not isValidFromTo(dclFromDate.Value, dclToDate.Value) Then
            MsgBox("بازه زمانی باید در یک سال باشد ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "بازه زمانی")
            Exit Sub
        End If
        If Integer.Parse(dclFromDate.Value) > Integer.Parse(dclToDate.Value) Then
            MsgBox("مقدار [از تاریخ]  باید از مقدار [تا تاریخ]  کوچکتر باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "هشدار")
            Exit Sub
        End If
        accessToData = New ClsDataAccess()
        Dim WaitFrm As New Anbar.Common.Frmwait
        WaitFrm.Show()
        WaitFrm.Refresh()
        Dim dataSet As DataSet = accessToData.RptAdamRayatOlaviatBandiTarikhEngheza(dclFromDate.Value, dclToDate.Value, shoabSNs, tarakoneshSN, taminKonandehsNs, kalaSns, cn)
        If dataSet.Tables.Count = 0 Then
            WaitFrm.Close()
        Else
            GridEX1.DataSource = dataSet.Tables(0).AsDataView()
            GridEX1.RetrieveStructure()
            setColumns()
            RefreshDataSet()
            WaitFrm.Close()
        End If




    End Sub
    Private Sub FillCombo()
        FillTaminkonandeh()
        FillShobe()
        FillTarakonesh()
    End Sub
    Private Sub SetDate()
        dclToDate = New NetSql.Components.CDateCtrl(tp)
        dclToDate.TextBox = txtToDate
        dclToDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        dclFromDate = New NetSql.Components.CDateCtrl(tp)
        dclFromDate.TextBox = txtFromDate
        dclFromDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

    End Sub
    Private Sub FillShobe()
        Sql =
            " Select   VahedeTejariSN , VahedeTejariDs from paVahedeTejari " &
                " Join Company On paVahedeTejari.CompanyID = Company.CompanyID " &
                " Where PedarVahedeTejariSN = 9.935 And VahedeTejariStatus = 1 "
        cmbShobeh.Bind(cn, Sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbShobeh.ShowSelectAll = True

    End Sub
    Private Sub FillTarakonesh()
        Sql =
            "Select TarakoneshSN , TarakoneshDs From abTarakonesh Where TarakoneshSN > 50 "
        cmbTarakonesh.Bind(cn, Sql, "TarakoneshSN", "TarakoneshDs")
        cmbTarakonesh.ShowSelectAll = True

    End Sub
    Private Sub FillTaminkonandeh()
        Sql = "  Select distinct paVahedeTejari.VahedeTejariSN , VahedeTejariDs   From paVahedeTejari " &
                " Join paKalaTamin ON paKalaTamin.VahedeTejariSN = paVahedeTejari.VahedeTejariSN " &
                " Where  VahedeTejariStatus =  1 "
        cmbTaminKonandeh.Bind(cn, Sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbTaminKonandeh.ShowSelectAll = True
    End Sub
    Private Sub FillKala(ByVal taminKonandehSN As String)
        Sql = "SELECT K.KalaSN , K.KalaDs +' '+ K.KalaNo KalaDS " &
                " FROM paKala K JOIN paKalaTamin T ON T.KalaSN = K.KalaSN " &
                " JOIN paVahedeTejari V ON V.VahedeTejariSN = T.VahedeTejariSN "

        If Not String.IsNullOrEmpty(taminKonandehSN) And taminKonandehSN <> "0" Then
            Sql = Sql & " Where T.VahedeTejariSN IN (" & taminKonandehSN & ")"
        End If
        cmbKala.Bind(cn, Sql, "KalaSN", "KalaDS")
        cmbKala.ShowSelectAll = True
        cmbKala.DroppedDown = True


        'End If
    End Sub
    Private Function isValidFromTo(ByVal FromDate As String, ByVal ToDate As String) As Boolean


        If (FromDate.Substring(0, 4) = ToDate.Substring(0, 4)) Then
            Return True
        End If
        Return False
    End Function
    Private Sub cmbTaminKonandeh_CheckedValuesChanged(sender As Object, e As EventArgs) Handles cmbTaminKonandeh.CheckedValuesChanged
        If cmbTaminKonandeh.getStringValues = taminKonandehsNs Then
            Exit Sub
        End If
        If Not cmbTaminKonandeh.CheckedItems Is Nothing Then
            If cmbTaminKonandeh.CheckedItems.Length <> 0 Then

                taminKonandehsNs = cmbTaminKonandeh.getStringValues
                FillKala(taminKonandehsNs)
            End If
        Else
            FillKala("")
        End If
    End Sub
    Private Sub setColumns()
        For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If col.Caption.Contains(".") Then
                col.FormatString = "N0"
            ElseIf col.Caption.Contains("..") Then
                col.FormatString = "#,#.###"
            End If
        Next
    End Sub
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        getReport()

    End Sub

End Class