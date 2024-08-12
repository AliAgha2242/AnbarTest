
Imports Anbar.BRL
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FrmRptMoghayratAnbarGardani
    Inherits JanusSimpleReport.frmRptJanusBase

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptMoghayratAnbarGardani
    Private Shared m_InitializingDefInstance As Boolean
    'Private dclFDate As NetSql.Components.CDateCtrl
    'Private dclTDate As NetSql.Components.CDateCtrl


    Public Shared Property DefInstance() As FrmRptMoghayratAnbarGardani
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptMoghayratAnbarGardani
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptMoghayratAnbarGardani)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub InitControls()

        Dim sql As String = "Select HesabdariSal , FDate +'#'+ TDate AS HesabdariSalValue from maHesabdari " &
                              "join maHesabdariSal On maHesabdari.HesabdariSN = maHesabdariSal.HesabdariSN" &
                              " Where  HesabdariSal<1500 and VahedeTejariSN = " & CStr(gVahedeTejariSN) &
                              " Order By HesabdariSal Desc"
        dcSalemali.Bind(cn, sql, "HesabdariSalValue", "HesabdariSal")
        ' If dcSalemali.Items.Count > 0 Then
        '     dcSalemali.SelectedIndex = 0
        ' End If
        'dclFDate = New NetSql.Components.CDateCtrl(tp)
        'dclFDate.TextBox = txtFromDarkhastDate
        'dclTDate = New NetSql.Components.CDateCtrl(tp)
        'dclTDate.TextBox = txtToDarkhastDate
        '
        'If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
        '    dclFDate.Value = gHesabdariSalFDate
        '    dclTDate.Value = gHesabdariSalTDate
        '
        'Else
        '    ' تهيه تاريخ از سرور
        '    dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
        '                                                                               cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
        '    dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
        '                                                                               cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        'End If

    End Sub

    Private Sub InitJanus()

        With GridEX1.RootTable.Columns
            With .Add("anbarno", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد انبار"
            End With
            With .Add("AnbarDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام انبار"
            End With
            With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام کالا"
            End With
            With .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شماره رهگیری"
            End With
            'With .Add("sanadnoAvaldoreh", Janus.Windows.GridEX.ColumnType.Text)
            '    .Caption = "شماره سند اول دوره"
            'End With
            With .Add("kalaphizikisnAvalDoreh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کالافیزیکی_اول دوره"
            End With
            With .Add("TedadAvalDoreh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تعداد اول دوره"
            End With
            With .Add("TedadPayanDoreh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تعداد پایان دوره"
            End With
        End With

    End Sub

    Private Sub FrmRptMoghayratAnbarGardani_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click

        If dcSalemali.SelectedValue Is Nothing Then
            NetSql.Common.CSystem.MsgBox("لطفا سال مالی مورد نظر را مشخص نمائید", MsgBoxStyle.Critical, "هشدار")
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim selectedSal As String = dcSalemali.SelectedValue.ToString()

        Dim vFromDate As String = selectedSal.Split("#".ToCharArray())(0)
        Dim vToDate As String = selectedSal.Split("#".ToCharArray())(1)


        Dim vErrMsg As String = ""

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsj As New DataSet
        Dim i As Integer

        Dim frmWait As New Anbar.Common.Frmwait
        frmWait.Show()
        frmWait.Label3.Text = "...سیستم در حال گزارش گیری می باشد..."
        frmWait.Refresh()

        'Try
        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        'If Trim(dclFDate.Text) <> "" Then
        '    vFromDate = Trim(dclFDate.Value)
        'Else
        'vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        'End If
        'If Trim(dclTDate.Text) <> "" Then
        '    vToDate = Trim(dclTDate.Value)
        'Else
        '    vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        'End If

        Me.Cursor = Cursors.WaitCursor

        If vErrMsg = "" Then

            Dim AnbarRule As New ClsDataAccessRule
            Dim DvReport As New DataView
            Try
                DvReport = AnbarRule.MoghayratAvaldoreVaPayandore_GetReport(vFromDate, vToDate, RdbKala.Checked, cn)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            GridEX1.DataSource = DvReport
            'GridEX1.RetrieveStructure()
        End If

        frmWait.Close()
        Me.Cursor = Cursors.Default
        GridEX1.AutoSizeColumns()
    End Sub

End Class
