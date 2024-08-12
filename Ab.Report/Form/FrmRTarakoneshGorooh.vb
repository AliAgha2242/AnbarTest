Public Class FrmRTarakoneshGorooh

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRTarakoneshGorooh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRTarakoneshGorooh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRTarakoneshGorooh
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRTarakoneshGorooh)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub InitControls()
        dbcTarakoneshGorooh.LateBinding = True
        dbcTarakoneshGorooh.ShowSelectAll = True
        dbcTarakoneshGorooh.Bind(cn, "SELECT Top 100 Percent TarakoneshGoroohSN, cast(TarakoneshGoroohNo as varchar(10)) + '-' +  TarakoneshGoroohDS as TarakoneshGorooh" & _
          " From abTarakoneshGorooh  order by TarakoneshGoroohNo", "TafsiliSN", "TarakoneshGorooh")

        dbcTarakonesh.LateBinding = True
        dbcTarakonesh.ShowSelectAll = True
        dbcTarakonesh.Bind(cn, "SELECT Top 100 Percent TarakoneshSN, TarakoneshNo + '-' + TarakoneshDs as Tarakonesh " & _
          " From abTarakonesh  order by TarakoneshNo", "TarakoneshSN", "Tarakonesh")
    End Sub

    Private Sub InitJanus()
        With GridEX1.RootTable.Columns
            With .Add("TarakoneshGoroohNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد گروه تراکنش"
            End With
            With .Add("TarakoneshGoroohDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "گروه تراکنش"
            End With
            With .Add("TarakoneshNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد تراکنش"
            End With
            With .Add("TarakoneshDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش"
            End With
            With .Add("FromDate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "از تاريخ"
            End With
            With .Add("ToDate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تا تاريخ"
            End With
        End With
    End Sub

    Private Sub FrmRTarakoneshGorooh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        GridEX1.DataSource = cn.ExecuteQuery("_abSPR_TarakoneshGorooh " & _
                       IIf(dbcTarakoneshGorooh.getStringValues() <> "" _
                And dbcTarakoneshGorooh.MatchedWithList, _
                dbcTarakoneshGorooh.getStringValues(), "0") & "," & _
                IIf(dbcTarakonesh.getStringValues() <> "" _
                And dbcTarakonesh.MatchedWithList, _
                dbcTarakonesh.getStringValues(), "0"))

        RefreshDataSet()

        Me.Cursor = System.Windows.Forms.Cursors.Default()
    End Sub
End Class
