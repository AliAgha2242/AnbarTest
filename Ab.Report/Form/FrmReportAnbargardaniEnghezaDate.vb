Imports System.Data.SqlClient

Public Class FrmReportAnbargardaniEnghezaDate
    Private Sub FrmReportAnbargardaniEnghezaDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbKardexReport.Checked = True

        BindDataTocbxs()

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Dim sql As String = ""
    Dim anbarSN As String = ""
    Dim shobehSN As String = ""
    Dim vGozareshBakardex As Short = 2

    Private dclToDate As NetSql.Components.CDateCtrl
    Private dclFromDate As NetSql.Components.CDateCtrl
    Private Sub BindDataTocbxs()
        SetDate()
        FillShobe()
        FillAnbar("")
    End Sub
    Private Sub FillShobe()
        cbxShobeh.ShowSelectAll = True
        sql =
            " Select   VahedeTejariSN , VahedeTejariDs from paVahedeTejari " &
                " Join Company On paVahedeTejari.CompanyID = Company.CompanyID " &
                " Where PedarVahedeTejariSN = 9.935 And VahedeTejariStatus = 1 "
        cbxShobeh.Bind(cn, sql, "VahedeTejariSN", "VahedeTejariDs")
    End Sub


    Private Sub SetDate()
        dclFromDate = New NetSql.Components.CDateCtrl(tp)
        dclFromDate.TextBox = txtFromDate
        dclFromDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        dclToDate = New NetSql.Components.CDateCtrl()
        dclToDate.TextBox = txtToDate
        dclToDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
    End Sub
    Private Sub FillAnbar(ByVal _vahedtejari As String)
        cbxAnbar.ShowSelectAll = True
        Dim condition As String = " where 1=1 "
        If Not String.IsNullOrEmpty(_vahedtejari) And (_vahedtejari <> "0.000" And _vahedtejari <> "0") Then
            condition = " AND VahedeTejariSN IN ( " & _vahedtejari & ")"
        End If
        sql = " SELECT distinct  abanbar.AnbarSN SN , AnbarDs Ds " &
                " FROM abAnbar JOIN abAnbarGardaniEnghezaDate Ed ON Ed.AnbarSN = abAnbar.AnbarSN  " &
                 condition

        cbxAnbar.Bind(cn, sql, "SN", "DS")


    End Sub


    Private Sub cbxShobeh_CheckedValuesChanged(sender As Object, e As EventArgs) Handles cbxShobeh.CheckedValuesChanged

        If cbxShobeh.getStringValues = shobehSN Then
            Exit Sub
        End If
        If Not cbxShobeh.CheckedItems Is Nothing Then
            If cbxShobeh.CheckedItems.Length <> 0 Then
                shobehSN = cbxShobeh.getStringValues
                FillAnbar(shobehSN)
            End If
        Else
            FillAnbar("")
        End If
    End Sub

    Private Sub cbxAnbar_CheckedValuesChanged(sender As Object, e As EventArgs) Handles cbxAnbar.CheckedValuesChanged
        Dim _anbars As String = ""
        _anbars = cbxAnbar.getStringValues()
        If _anbars = anbarSN Then
            Exit Sub
        End If



    End Sub
    Private Sub getReport(ByVal vahedetejariSN As String, ByVal anbarSN As String, ByVal fromDate As String, ByVal toDate As String)

        If String.IsNullOrEmpty(vahedetejariSN) Then

            vahedetejariSN = "0"

        End If
        If String.IsNullOrEmpty(anbarSN) Then
            anbarSN = "0"
        End If
        If rdbKardexReport.Checked Then
            vGozareshBakardex = 2
        Else
            vGozareshBakardex = 1
        End If

        Dim _ds As New DataSet
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim mcn As New SqlClient.SqlConnection

        mcn.ConnectionString = cn.ConnectionString + "; password=" & cn.SQLPassword

        If mcn.State = ConnectionState.Closed Then
            mcn.Open()
        End If

        cmd.CommandText = "abSpR_AnbarGardaniEnghezaDateReport"
        cmd.Parameters.AddWithValue("@VahedeTejariSN", vahedetejariSN)
        cmd.Parameters.AddWithValue("@AnbarSN", anbarSN)
        cmd.Parameters.AddWithValue("@AnbarGardaniFromDate", fromDate)
        cmd.Parameters.AddWithValue("@AnbarGardaniToDate", toDate)
        cmd.Parameters.AddWithValue("@Mode", vGozareshBakardex)

        cmd.Connection = mcn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = mcn.ConnectionTimeout
        da.SelectCommand = cmd


        Dim WFrm As New Anbar.Common.Frmwait
        Try
            WFrm.Show()
            WFrm.Refresh()
            da.Fill(_ds)
            GridEX1.DataSource = _ds.Tables(0).DefaultView
            GridEX1.RetrieveStructure()
            RefreshDataSet()

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطای سیستمی" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "خطا")
        Finally
            WFrm.Close()
        End Try


    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click

        If Trim(dclToDate.Text) <> "" Then
            If dclToDate.Text.Length <> 10 Then
                MsgBox("مقدار تا تاریخ باید درست مشخص شود", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "هشدار")
                Exit Sub
            End If
        Else
            MsgBox("مقدار تا تاریخ باید درست مشخص شود", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "هشدار")
            Exit Sub
        End If
        If Trim(dclFromDate.Text) <> "" Then
            If dclFromDate.Text.Length <> 10 Then
                MsgBox("مقدار از تاریخ باید درست مشخص شود", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "هشدار")
                Exit Sub
            End If
        Else
            MsgBox("مقدار از تاریخ باید درست مشخص شود", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "هشدار")
            Exit Sub
        End If
        shobehSN = cbxShobeh.getStringValues()
        anbarSN = cbxAnbar.getStringValues()
        If anbarSN = "0.000" Then
            anbarSN = "0"
        End If
        If shobehSN = "0.000" Then
            shobehSN = "0"
        End If

        getReport(shobehSN, anbarSN, dclFromDate.Text.Replace("/", ""), dclToDate.Text.Replace("/", ""))

        SetColumns()
    End Sub
    Private Sub SetColumns()

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
            ElseIf Col.Caption.EndsWith("؟") OrElse Col.Caption.EndsWith("?") Then
                Col.ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
                Col.CheckBoxTrueValue = 1
                Col.CheckBoxFalseValue = 0
            End If
        Next
        If vGozareshBakardex = 2 Then
            GridEX1.AutomaticSort = False
        Else
            GridEX1.AutomaticSort = True
        End If

        GridEX1.Refresh()

    End Sub
End Class