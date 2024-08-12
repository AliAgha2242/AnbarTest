Imports Anbar.BRL
Imports Anbar.DAL

Public Class FrmReportAsnadBarcodeKhanAghlamNazdik

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl
    Private sql As String = ""
    Private taminKonandehsNs As String = ""
    Private roozTaEngheza As Integer = 365
    Private parameterToClose As Decimal = 0.33D
    Private vahedetejariSN As Decimal = 0.000D
    Dim accessToData As ClsDataAccessRule
    Private Sub InitControls()
        Me.WindowState = FormWindowState.Maximized
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        ' تهيه تاريخ از سرور
        dclFDate.Value =
            Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal).Substring(0, 4) + "0101"
        dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        vahedetejariSN = gSM.vVahedetejariSN


    End Sub

    Private Sub FrmReportAsnadBarcodeKhanAghlamNazdik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        InitControls()
        FillCombo()
        FillKala("")

    End Sub
    Private Sub FillCombo()
        FillTaminkonandeh()
        FillShobe()

    End Sub
    Private Sub FillShobe()
        Dim VahedeteJari_Where As String = String.Empty
        IIf(vahedetejariSN = 9.935, "", " AND VahedeTejariSN = " + CStr(vahedetejariSN))


        sql =
            " Select   VahedeTejariSN , VahedeTejariDs from paVahedeTejari " &
                " Join Company On paVahedeTejari.CompanyID = Company.CompanyID " &
                " Where PedarVahedeTejariSN = 9.935 And VahedeTejariStatus = 1 " &
                  VahedeteJari_Where
        cmbShobeh.LateBinding = True
        cmbShobeh.Bind(cn, sql, "VahedeTejariSN", "VahedeTejariDs")


        cmbShobeh.ShowSelectAll = True





    End Sub
    Private Sub FillTaminkonandeh()
        sql = "  Select distinct paVahedeTejari.VahedeTejariSN , VahedeTejariDs   From paVahedeTejari " &
                " Join paKalaTamin ON paKalaTamin.VahedeTejariSN = paVahedeTejari.VahedeTejariSN " &
                " Where  VahedeTejariStatus =  1 " &
                " AND NoeVahedeTejariSN IN(9.935,14.935,16.935) "

        cmbTaminKonandeh.Bind(cn, sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbTaminKonandeh.ShowSelectAll = True
    End Sub
    Private Sub FillKala(ByVal taminKonandehSN As String)
        sql = "SELECT K.KalaSN , K.KalaDs +' '+ K.KalaNo KalaDS " &
                " FROM paKala K JOIN paKalaTamin T ON T.KalaSN = K.KalaSN " &
                " JOIN paVahedeTejari V ON V.VahedeTejariSN = T.VahedeTejariSN "

        If Not String.IsNullOrEmpty(taminKonandehSN) And taminKonandehSN <> "0" Then
            sql = sql & " Where T.VahedeTejariSN IN (" & taminKonandehSN & ")"
        End If
        cmbKala.LateBinding = True
        cmbKala.Bind(cn, sql, "KalaSN", "KalaDS")
        cmbKala.ShowSelectAll = True
        'cmbKala.DroppedDown = True


        'End If
    End Sub
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
            col.AutoSize()
            If col.Caption.Contains(".") Then

                col.FormatString = "N0"
            ElseIf col.Caption.Contains("درصد") Then
                col.FormatString = "#,#.##"
            End If
        Next
    End Sub
    Private Sub getReport()
        Dim shoabSNs As String = cmbShobeh.getStringValues
        taminKonandehsNs = cmbTaminKonandeh.getStringValues
        Dim kalaSns As String = cmbKala.getStringValues

        If String.IsNullOrEmpty(shoabSNs) Or shoabSNs = "0.000" Or shoabSNs = "0" Then
            shoabSNs = ""
        End If
        If String.IsNullOrEmpty(taminKonandehsNs) Or taminKonandehsNs = "0.000" Or taminKonandehsNs = "0" Then
            taminKonandehsNs = ""
        End If
        If String.IsNullOrEmpty(kalaSns) Or kalaSns = "0.000" Or kalaSns = "0" Then
            kalaSns = ""
        End If

        If Integer.Parse(dclFDate.Value) > Integer.Parse(dclTDate.Value) Then
            MsgBox("مقدار [از تاریخ]  باید از مقدار [تا تاریخ]  کوچکتر باشد", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "هشدار")
            Exit Sub
        End If
        roozTaEngheza = CInt(adadRoozTaEngheza.Value)
        parameterToClose = CDec(adadParameteClose.Value / 100)

        accessToData = New ClsDataAccessRule()
        Dim WaitFrm As New Anbar.Common.Frmwait
        WaitFrm.Show()
        WaitFrm.Refresh()
        Dim dataTable As DataTable = accessToData.ReportAghlamTarikhNazdikeAsnadBarcodKhan(dclFDate.Value, dclTDate.Value, shoabSNs, taminKonandehsNs, kalaSns, roozTaEngheza, parameterToClose, cn)

        GridEX1.DataSource = dataTable.AsDataView()
        GridEX1.RetrieveStructure()
        RefreshDataSet()
        setColumns()

        WaitFrm.Close()
    End Sub
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click

        getReport()

    End Sub

End Class