
Public Class FrmAnbargardaniMoghayeratBeyneShomaresh
    Inherits JanusSimpleReport.frmRptJanusBase
#Region "UpgradeSupport"
    Private Shared m_vb6FormDefInstance As FrmAnbargardaniMoghayeratBeyneShomaresh
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmAnbargardaniMoghayeratBeyneShomaresh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAnbargardaniMoghayeratBeyneShomaresh
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmAnbargardaniMoghayeratBeyneShomaresh)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
     Dim currentSalMali As Short

    Private Sub initGrid()
        With GridEX1.RootTable.Columns
            .Add("AnbarGardaniDS", Janus.Windows.GridEX.ColumnType.Text).Caption = "عنوان"
            .Add("EndDate", Janus.Windows.GridEX.ColumnType.Text).Caption = "تاریخ پایان"
            .Add("InsDate", Janus.Windows.GridEX.ColumnType.Text).Caption = "تاریخ شروع"
            .Add("AnbarGardaniStatusDS", Janus.Windows.GridEX.ColumnType.Text).Caption = "وضعیت"
            .Add("KalaDs", Janus.Windows.GridEX.ColumnType.Text).Caption = "کالا"
            .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text).Caption = "رهگیری"
            .Add("Shomaresh1ShomareshDS", Janus.Windows.GridEX.ColumnType.Text).Caption = "شمارش"
            .Add("Shomaresh1Date", Janus.Windows.GridEX.ColumnType.Text).Caption = "تاریخ شمارش اول"
            .Add("ShomareshHa1Meghdar", Janus.Windows.GridEX.ColumnType.Text).Caption = "تعداد"
            .Add("RialShomaresh1", Janus.Windows.GridEX.ColumnType.Text).Caption = "ريال"
            .Add("Shomaresh2ShomareshDS", Janus.Windows.GridEX.ColumnType.Text).Caption = "شمارش"
            .Add("Shomaresh2Date", Janus.Windows.GridEX.ColumnType.Text).Caption = "تاریخ شمارش دوم"
            .Add("ShomareshHa2Meghdar", Janus.Windows.GridEX.ColumnType.Text).Caption = "تعداد"
            .Add("RialShomaresh2", Janus.Windows.GridEX.ColumnType.Text).Caption = "ريال"
            .Add("Shomaresh3ShomareshDS", Janus.Windows.GridEX.ColumnType.Text).Caption = "شمارش"
            .Add("Shomaresh3Date", Janus.Windows.GridEX.ColumnType.Text).Caption = "تاریخ شمارش سوم"
            .Add("ShomareshHa3Meghdar", Janus.Windows.GridEX.ColumnType.Text).Caption = "تعداد"
            .Add("RialShomaresh3", Janus.Windows.GridEX.ColumnType.Text).Caption = "ريال"


        End With



    End Sub
    Private Sub fillCombo()
        dbcAnbargardani.LateBinding = True

        Dim sql As String = "Select AnbarGardaniSN " &
                            ", AnbarGardaniDS + '( وضعیت انبار گردانی : ' + AnbarGardaniStatusDS+')'  AS AnbarGardaniDS" &
                            " from abAnbarGardani" &
                            " Join abAnbarGardaniStatus ON abAnbarGardani.AnbarGardaniStatus = abAnbarGardaniStatus.AnbarGardaniStatus" &
                            " Where AnbarSN = " & gAnbarSN & " AND  StartDate Between " & gHesabdariSalFDate & "  And " & gHesabdariSalTDate &
                            " And abAnbarGardani.AnbarGardaniStatus <> 8"

        dbcAnbargardani.Bind(cn, sql, "AnbarGardaniSN", "AnbarGardaniDS")
        lbl_SaleMali.Text = " سال مالی :  " & gHesabdariSal
        lbl_SaleMali.Visible = True

    End Sub
    Private Sub SetColumns()
        Dim captionLength As Int32
        'Dim last2Char As String
        For Each Col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If Col.Caption.Contains("..") Then
                Col.FormatString = "#,#.###"
                Col.TotalFormatString = "#,#.###"
                Col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            ElseIf Col.Caption.Contains(".") Then
                Col.FormatString = "N0"
                Col.TotalFormatString = "N0"
                Col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            End If
        Next

    End Sub
    Private Sub FrmAnbargardaniMoghayeratBeyneShomaresh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentSalMali = gHesabdariSal
        fillCombo()

    End Sub
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Dim anbarGardaniSN As String = ""
        Dim WaitFrm As New Anbar.Common.Frmwait
        If dbcAnbargardani.SelectedValue IsNot Nothing Then
            anbarGardaniSN = Trim(dbcAnbargardani.SelectedValue.ToString())
            Dim query As String = "exec abSpR_MoghayeratShomareshHaAnbarGardani  " & anbarGardaniSN
            Dim _DV As DataView
            Try
                WaitFrm.Show()
                WaitFrm.Refresh()
                _DV = cn.ExecuteQuery(query)
                GridEX1.DataSource = _DV
                GridEX1.RetrieveStructure()
                SetColumns()
                RefreshDataSet()
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox("بروز خطا " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "هشدار")
            Finally
                WaitFrm.Close()
            End Try

        Else
            NetSql.Common.CSystem.MsgBox("شما دوره انبار گردانی را مشخص نکرده اید", MsgBoxStyle.Critical, "هشدار")
            Exit Sub
        End If
    End Sub

    Private Sub dbcAnbargardani_MouseEnter(sender As Object, e As EventArgs) Handles dbcAnbargardani.MouseEnter
        If gHesabdariSal <> currentSalMali Then
            fillCombo()
            currentSalMali = gHesabdariSal

        End If
    End Sub

    Private Sub ChkCustomizeForPrint_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustomizeForPrint.CheckedChanged

        For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If Not col.Caption.Contains("`") Then
                If ChkCustomizeForPrint.Checked Then
                    col.Visible = False
                Else
                    col.Visible = True
                End If
            Else
                col.Visible = True
            End If
        Next
    End Sub
End Class