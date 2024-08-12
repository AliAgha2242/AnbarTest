
Imports Anbar.BRL
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmReportDarkhastService

    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6FormDefInstance As FrmReportDarkhastService
    Private Shared m_InitializingDefInstance As Boolean
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl


    Public Shared Property DefInstance() As FrmReportDarkhastService
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmReportDarkhastService
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmReportDarkhastService)
            m_vb6FormDefInstance = Value
        End Set
    End Property
    Private Sub FrmReportDarkhastService_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        InitControls()

    End Sub
    Private Sub InitControls()
        Me.WindowState = FormWindowState.Maximized
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        ' تهيه تاريخ از سرور
        dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 6) & "01"
        dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        CmbAmval.Bind(cn, "Select AmvalSN, AmvalNo + '.' + KalaDS as AmvalDS from abVw_Amval", "AmvalSN", "AmvalDS")
        CmpVahedeTejari.Bind(cn, "select VahedetejariSN, VahedetejariDS from paVahedetejari where PedarVahedeTejariSN =9.935", "VahedetejariSN", "VahedetejariDS")
        CmpStatus.Bind(cn, "Select Cast(StatusSN As Varchar) StatusSN,StatusDs from btStatus Where StatusSN In (1,2,3,7)", "StatusSN", "StatusDs")
    End Sub
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String = ""
        Dim VAmvalSN, VahedetejariSN, VStatusSN As String

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsj As New DataSet
        Dim i As Integer

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        End If

        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        End If

        If vFromDate = "" Then
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If

        If vToDate = "" Then
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If vErrMsg <> "" Then
            MsgBox(vErrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If CmbAmval.getStringValues Is Nothing Then
            MsgBox("کد اموال انتخاب نشده است", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If CmpVahedeTejari.getStringValues Is Nothing Then
            MsgBox("شعبه انتخاب نشده است", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If CmpStatus.getStringValues Is Nothing Then
            MsgBox("وضعیت انتخاب نشده است", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If CmbAmval.getStringValues = "0" Or CmbAmval.getStringValues = "0.000" Then
            VAmvalSN = ""
        Else
            VAmvalSN = CmbAmval.getStringValues
        End If

        If CmpVahedeTejari.getStringValues = "0" Or CmpVahedeTejari.getStringValues = "0.000" Then
            VahedetejariSN = ""
        Else
            VahedetejariSN = CmpVahedeTejari.getStringValues
        End If

        If CmpStatus.getStringValues = "0" Or CmbAmval.getStringValues = "0.000" Then
            VStatusSN = ""
        Else
            VStatusSN = CmpStatus.getStringValues
        End If


        Dim frmWait As New Anbar.Common.Frmwait
        frmWait.Show()
        frmWait.Label3.Text = "...سیستم در حال گزارش گیری می باشد..."
        frmWait.Refresh()

        Me.Cursor = Cursors.WaitCursor

        If vErrMsg = "" Then

            Dim AnbarRule As New ClsDataAccessRule
            Dim DvReport As New DataView
            Try

                DvReport = AnbarRule.RptPriodicService_GetReport(vFromDate, vToDate, VAmvalSN, VahedetejariSN, VStatusSN, cn)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            GridEX1.DataSource = DvReport
            GridEX1.RetrieveStructure()


            For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
                If col.Key.Contains(".") Then
                    col.FormatString = "#,###"
                    col.TotalFormatString = "#,###"
                    col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                ElseIf col.Key.Contains("..") Then
                    col.FormatString = "#,###.##"
                    col.TotalFormatString = "#,###.##"
                    col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                End If
            Next

        End If

        frmWait.Close()
        Me.Cursor = Cursors.Default
        GridEX1.AutoSizeColumns()

    End Sub

End Class

