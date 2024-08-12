
Imports Anbar.BRL
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FrmRptFaseleDarkhastTaHavaleh

    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6FormDefInstance As FrmRptFaseleDarkhastTaHavaleh
    Private Shared m_InitializingDefInstance As Boolean
        Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl



    Public Shared Property DefInstance() As FrmRptFaseleDarkhastTaHavaleh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptFaseleDarkhastTaHavaleh
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptFaseleDarkhastTaHavaleh)
            m_vb6FormDefInstance = Value
        End Set
    End Property

    Private Sub InitControls()

        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        ' تهيه تاريخ از سرور
        dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 6) & "01"
        dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        Me.WindowState = FormWindowState.Maximized

        CmbTamin.Bind(cn, "Select TaminVahedeTejariSN,TaminVahedeTejariNo+'. '+TaminVahedeTejariDs As TaminVahedeTejariDs from paVW_TaminKonandeh", "TaminVahedeTejariSN", "TaminVahedeTejariDs")
        CmbMahsool.Bind(cn, "Select KalaSN,KalaNo+'. ' + KalaDs as KalaDS from paVw_paKalaTaminFull", "KalaSN", "KalaDS")
        dbcVahedeTejari.LateBinding = True
        dbcVahedeTejari.Bind(cn, "select 0 as VahedetejariSN, 'همه موارد' as VahedetejariDS union all select VahedetejariSN, VahedetejariDS from paVahedetejari where OzveGorooh = 1", "VahedetejariSN", "VahedetejariDS")

    End Sub

    Private Sub InitJanus()

    End Sub

    Private Sub FrmRptMoghayratAnbarGardani_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String = ""
        Dim KalaSN, TaminKonandeSn As String
        Dim VahedetejariSN As Decimal

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsj As New DataSet
        Dim i As Integer

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If

        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If CmbTamin.getStringValues Is Nothing Then
            MsgBox("تامین کننده انتخاب نشده است", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If CmbMahsool.getStringValues Is Nothing Then
            MsgBox("کالا انتخاب نشده است", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If Not (dbcVahedeTejari.MatchedWithList AndAlso dbcVahedeTejari.BoundText <> "") Then
            NetSql.Common.CSystem.MsgBox("شعبه انتخاب نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If CmbTamin.getStringValues = "0" Or CmbTamin.getStringValues = "0.000" Then
            TaminKonandeSn = ""
        Else
            TaminKonandeSn = CmbTamin.getStringValues
        End If

        If CmbMahsool.getStringValues = "0" Or CmbMahsool.getStringValues = "0.000" Then
            KalaSN = ""
        Else
            KalaSN = CmbMahsool.getStringValues
        End If

        If Trim(dbcVahedeTejari.BoundText) <> "" AndAlso Trim(dbcVahedeTejari.SelectedValue) <> 0 Then

            VahedetejariSN = CStr(dbcVahedeTejari.SelectedValue)

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
                DvReport = AnbarRule.FaseleDarkhastTaHavaleh_GetReport(vFromDate, vToDate, TaminKonandeSn, KalaSN, VahedetejariSN, gAnbarSN, cn)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            GridEX1.DataSource = DvReport
            GridEX1.RetrieveStructure()

            For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
                If col.Caption.Contains("ریال") Or col.Caption.Contains("تعداد") Then
                    col.FormatString = "#,###"
                End If
            Next
        End If

        frmWait.Close()
        Me.Cursor = Cursors.Default
        GridEX1.AutoSizeColumns()
    End Sub

End Class


