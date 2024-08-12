Imports System.Data.SqlClient

Public Class FrmReportMojudiWithIRC_GTIN
    Dim sql As String = ""
    Dim taminKonandehsN As String = "0"
    Dim vToDate As String = ""
    Dim vErrMsg As String = ""
    Dim vahedetejariSN As String = ""
    Public kalaSN As String = ""
    Dim Showbedoonehmojudi As Boolean = False
    Dim _DV As New DataView
    Public dclToDate As NetSql.Components.CDateCtrl

    Public Sub FrmReportMojudiWithIRC_GTIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        FillCombo()
        SetDate()
        FillKala("", kalaSN)
        If IsNumeric(kalaSN) Then
            Call btnViewReport_Click(sender, e)
        End If

    End Sub
    Public Sub SetDate()
        dclToDate = New NetSql.Components.CDateCtrl(tp)
        dclToDate.TextBox = txtToDate
        dclToDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

    End Sub
    Public Sub FillCombo()
        FillTaminkonandeh()
        FillShobe()
    End Sub
    Public Sub FillShobe()
        sql =
            " Select   VahedeTejariSN , VahedeTejariDs from paVahedeTejari " &
                " Join Company On paVahedeTejari.CompanyID = Company.CompanyID " &
                " Where PedarVahedeTejariSN = 9.935 And VahedeTejariStatus = 1 "
        cmbShobeh.Bind(cn, sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbShobeh.ShowSelectAll = True

    End Sub
    Public Sub FillTaminkonandeh()
        sql = "  Select distinct paVahedeTejari.VahedeTejariSN , VahedeTejariDs   From paVahedeTejari " &
                " Join paKalaTamin ON paKalaTamin.VahedeTejariSN = paVahedeTejari.VahedeTejariSN " &
                " Where  VahedeTejariStatus =  1 AND NoeVahedeTejariSN IN (16.935 , 14.935 ,9.935) "
        cmbTaminKonandeh.Bind(cn, sql, "VahedeTejariSN", "VahedeTejariDs")
        cmbTaminKonandeh.ShowSelectAll = True
    End Sub
    Public Sub FillKala(ByVal taminKonandehSN As String, Optional ByVal KalaSN As String = "")
        sql = "SELECT K.KalaSN , K.KalaDs +' '+ K.KalaNo KalaDS " &
                " FROM paKala K JOIN paKalaTamin T ON T.KalaSN = K.KalaSN " &
                " JOIN paVahedeTejari V ON V.VahedeTejariSN = T.VahedeTejariSN " &
                " Where V.NoeVahedeTejariSN IN ( 16.935 , 14.935)"

        If Not String.IsNullOrEmpty(taminKonandehSN) And taminKonandehSN <> "0" Then
            sql = sql & " AND T.VahedeTejariSN IN (" & taminKonandehSN & ")"
        End If
        cmbKala.Bind(cn, sql, "KalaSN", "KalaDS")


        If IsNumeric(KalaSN) Then
            cmbKala.BoundText = KalaSN
        Else
            cmbKala.ShowSelectAll = True
            cmbKala.DroppedDown = True
        End If


        'End If
    End Sub


    Public Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        If Trim(dclToDate.Text) <> "" Then
            vToDate = Trim(dclToDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.Critical, "توجه")
            Exit Sub
        End If
        getReport()
        SetColumns()
    End Sub

    Public Sub chkShowbedoonehmojudi_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowbedoonehmojudi.CheckedChanged
        Showbedoonehmojudi = chkShowbedoonehmojudi.Checked
    End Sub

    Public Sub validValues()
        vahedetejariSN = cmbShobeh.getStringValues
        If vahedetejariSN Is Nothing Then
            vahedetejariSN = "0"
        End If
        '**************************************************
        taminKonandehsN = cmbTaminKonandeh.getStringValues
        If taminKonandehsN Is Nothing Then
            taminKonandehsN = "0"
        End If
        '**************************************************
        kalaSN = cmbKala.getStringValues
        If kalaSN Is Nothing Then
            kalaSN = "0"
        End If

        If Not isDigit(txtIRC.Text) Then
            txtIRC.Text = txtIRC.Text.Substring(0, txtIRC.Text.Length - 1)
        End If
        If Not isDigit(txtGTIN.Text) Then
            txtGTIN.Text = txtGTIN.Text.Substring(0, txtGTIN.Text.Length - 1)
        End If

    End Sub
    Public Sub getReport()

        validValues()
        Dim _ds As New DataSet
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        cmd.CommandText = "abSpR_ProductCatalogue_MojoudiByIRCGTIN"
        cmd.Parameters.AddWithValue("@Todate", vToDate)
        cmd.Parameters.AddWithValue("@VahedeTejariSN", vahedetejariSN)
        cmd.Parameters.AddWithValue("@TaminKonandehSN", taminKonandehsN)
        cmd.Parameters.AddWithValue("@KalaSN", kalaSN)
        cmd.Parameters.AddWithValue("@ShowMojoudiDar", Not chkShowbedoonehmojudi.Checked)
        cmd.Parameters.AddWithValue("@PartOfGTIN", txtGTIN.Text)
        cmd.Parameters.AddWithValue("@PartOfIRC", txtIRC.Text)
        cmd.Connection = cn.Connection
        cmd.CommandTimeout = 60000
        cmd.CommandType = CommandType.StoredProcedure
        da.SelectCommand = cmd
        Dim WFrm As New Anbar.Common.Frmwait
        Try

            WFrm.Show()
            WFrm.Refresh()
            da.Fill(_ds)
            _DV = _ds.Tables(0).AsDataView()
            GridEX1.DataSource = _DV
            GridEX1.RetrieveStructure()
            RefreshDataSet()

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطای سیستمی" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "خطا")
        Finally
            WFrm.Close()
        End Try


    End Sub

    Public Sub SetColumns()


        'Dim last2Char As String
        For Each Col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If Col.Caption.Contains("..") Then
                Col.FormatString = "F3"
                Col.TotalFormatString = "F3"
                Col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            ElseIf Col.Caption.Contains(".") Then
                Col.FormatString = "N0"
                Col.TotalFormatString = "N0"
                Col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            End If

        Next

    End Sub

    Public Sub cmbTaminKonandeh_CheckedValuesChanged(sender As Object, e As EventArgs) Handles cmbTaminKonandeh.CheckedValuesChanged
        If cmbTaminKonandeh.getStringValues = taminKonandehsN Then
            Exit Sub
        End If
        If Not cmbTaminKonandeh.CheckedItems Is Nothing Then
            If cmbTaminKonandeh.CheckedItems.Length <> 0 Then

                taminKonandehsN = cmbTaminKonandeh.getStringValues
                FillKala(taminKonandehsN)
            End If
        Else
            FillKala("")
        End If


    End Sub

    Public Function isDigit(ByVal num As String) As Boolean
        For Each c As Char In num.ToCharArray()
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub txtIRC_TextChanged(sender As Object, e As EventArgs) Handles txtIRC.TextChanged

        If Not isDigit(txtIRC.Text) Then
            NetSql.Common.CSystem.MsgBox("لطفا فقط از عدد استفاده نمائید", MsgBoxStyle.Critical, "توجه")
            Dim az As Integer = txtIRC.Text.Length - 1
            txtIRC.Select(az, 1)
        End If
    End Sub

    Public Sub txtGTIN_TextChanged(sender As Object, e As EventArgs) Handles txtGTIN.TextChanged
        If Not isDigit(txtGTIN.Text) Then
            NetSql.Common.CSystem.MsgBox("لطفا فقط از عدد استفاده نمائید", MsgBoxStyle.Critical, "توجه")
            Dim az As Integer = txtGTIN.Text.Length - 1
            txtGTIN.Select(az, 1)
        End If
    End Sub


End Class