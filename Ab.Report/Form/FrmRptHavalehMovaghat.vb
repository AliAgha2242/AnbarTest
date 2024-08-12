Imports VB = Microsoft.VisualBasic

Public Class FrmRptHavalehMovaghat

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptHavalehMovaghat
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptHavalehMovaghat
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptHavalehMovaghat
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptHavalehMovaghat)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

    Private Sub FrmRptHavalehMovaghat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        setColumnProperties()

        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate
        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        End If
    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter =
            cn.ExecuteQuery(
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='_abSpr_HavalehMovaghat' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

                End With

            End With
        Next

    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String = ""

        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        Else
            vErrMsg = "از تاريخ مشخص نشده است"
        End If
        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Environment.NewLine & "تا تاريخ مشخص نشده است"
        End If

        Try
            GridEX1.DataSource = cn.ExecuteQuery("_abSpr_HavalehMovaghat '" &
                                                 vFromDate & "','" & vToDate & "'," &
                                                 CStr(gAnbarSN))
            RefreshDataSet()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default()
    End Sub
End Class
