Public Class frmMasrafeMavad

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmMasrafeMavad
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMasrafeMavad
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmMasrafeMavad
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmMasrafeMavad)
            m_vb6FormDefInstance = Value
        End Set

    End Property

#End Region

    Private dclFromDate As NetSql.Components.CDateCtrl
    Private dclToDate As NetSql.Components.CDateCtrl
    Private mFromDate As Object
    Private mToDate As Object

    Private Sub frmMasrafeMavad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        InitControls()
        InitJanus()
    End Sub

    Private Sub InitControls()
        dclFromDate = New NetSql.Components.CDateCtrl(tp)
        dclFromDate.TextBox = txtFromDate
        dclFromDate.Value = NetSql.Common.CShamsiDate.MiladiToShamsi(Today)

        dclToDate = New NetSql.Components.CDateCtrl(tp)
        dclToDate.TextBox = txtToDate
        dclToDate.Value = NetSql.Common.CShamsiDate.MiladiToShamsi(Today)

        dbcAnbarSN.LateBinding = True
        dbcAnbarSN.ShowSelectAll = True
        dbcAnbarSN.Bind(cn, "SELECT Top 100 Percent AnbarSN, AnbarDS " & _
                "From abAnbar where VahedeTejariSN = " & CStr(gVahedeTejariSN) & " order by AnbarDS", "AnbarSN", "AnbarDS")
    End Sub

    Private Sub InitJanus()
        With GridEX1.RootTable.Columns
            With .Add("VahedetejariDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شعبـه"
                .Visible = False
            End With
            With .Add("AnbarDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انبـار"
            End With
            With .Add("TafsiliDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "طـرف حسـاب"
            End With
            With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کـد کـالا"
            End With
            With .Add("KalaDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کـالا"
            End With
            With .Add("VahedeSanjeshDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "واحـد سنجـش"
            End With
            With .Add("Meghdar", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "مقـدار"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###.###"
                .TotalFormatString = "#,###.###"
            End With
            With .Add("RialeVagheyee", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "ریـال واقعـی"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###.###"
                .TotalFormatString = "#,###.###"
            End With
        End With
        ' keep focus
        GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Dim vAnbarSN As String

        If Trim(dclFromDate.Value) <> "" Then
            mFromDate = Trim(dclFromDate.Value)
        Else
            Netsql.common.csystem.MsgBox("از تاريخ مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If
        If Trim(dclToDate.Value) <> "" Then
            mToDate = Trim(dclToDate.Value)
        Else
            Netsql.common.csystem.MsgBox("تا تاريخ مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If dbcAnbarSN.MatchedWithList Then
            vAnbarSN = dbcAnbarSN.getXMLValues
        Else
            Netsql.common.csystem.MsgBox("انبار مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        GridEX1.DataSource = cn.ExecuteQuery("_abSpr_MasrafeMavad '" & _
              mFromDate.ToString() & "','" & _
              mToDate.ToString() & "','" & _
              vAnbarSN & "'")
        RefreshDataSet()

    End Sub
End Class
