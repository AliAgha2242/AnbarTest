'Author ::زهره ايزدپناه
'CreateDate :: 1389/02/22
'ModifiedDate::
'Description:: گزارش کالاهای راکد
'System ::انبار

Public Class FrmRaked
    Inherits JanusSimpleReport.frmRptJanusBase

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRaked
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRaked
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRaked
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmRaked)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region


    Private Sub FrmMojoodiA_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromSanadDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToSanadDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate
        End If

        cmbAnbar.DropDownDataSource =
            cn.ExecuteQuery(
                             "Select AnbarSN,AnbarNo+'-'+AnbarDS AS AnbarName FROM abAnbar WHERE VahedeTejariSN = " &
                             gVahedeTejariSN.ToString & " AND " &
                             IIf(gIsTajmie = 1, " IsTajmie=2", " AnbarSN =" & gAnbarSN.ToString))
        cmbAnbar.DropDownDataMember = "AnbarName"
        cmbAnbar.DropDownValueMember = "AnbarSN"
        cmbAnbar.DropDownDisplayMember = "AnbarName"

        setColumnProperties()

    End Sub

    Dim darSatheRahgiri As Boolean = False
    Dim taDarsad As Int16 = 0
    Dim strAnbars As String = ""
    Dim vFromDate, vToDate As String
    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click


        vFromDate = dclFDate.Value
        vToDate = dclTDate.Value
        If (cmbAnbar.CheckedItems Is Nothing OrElse cmbAnbar.CheckedItems.Length = 0) And gIsTajmie = True Then
            NetSql.Common.CSystem.MsgBox("انبار مشخص نشده است",
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.MsgBoxRight, Me.Text)
            Exit Sub
        End If
        darSatheRahgiri = cbxByRahgiri.Checked
        If txtBxDarsad.Text = String.Empty Then
            taDarsad = 0
        End If
        If Not cmbAnbar.CheckedItems Is Nothing Then
            For i As Integer = 0 To cmbAnbar.CheckedItems.Length - 1
                strAnbars = strAnbars + IIf(strAnbars.Length > 0, ",", "") +
                            CType(cmbAnbar.CheckedItems(i), DataRowView).Item("AnbarSN").ToString
            Next
        End If
        GridEX1.DataSource = Me.GenerateReport()
        RefreshDataSet()
        If darSatheRahgiri Then
            With GridEX1.RootTable.Columns()
                With .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = "شماره رهگیری"
                End With
            End With
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery ( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Raked' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add (dvTableFooter.Item (i).Item ("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item (i).Item ("ObjectHaFDS")

                End With

            End With
        Next
    End Sub

    Private Sub txtBxDarsad_TextChanged(sender As Object, e As EventArgs) Handles txtBxDarsad.TextChanged
        Dim digit As Int16 = 0

        Int16.TryParse(txtBxDarsad.Text, digit)
        If digit = 0 Then
            txtBxDarsad.ResetText()
        Else
            taDarsad = digit
        End If

    End Sub
    Private Function GenerateReport() As DataView
        Dim ds As DataSet = New DataSet
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand
        Dim sda As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter

        cmd.CommandText = "_abSpr_Raked"
        'cmd.CommandText = "_abSpr_Raked22"

        cmd.Parameters.AddWithValue("@Command", "")
        cmd.Parameters.AddWithValue("@VahedeTejariSN", gVahedeTejariSN)
        cmd.Parameters.AddWithValue("@StrAnbarSN", strAnbars)
        cmd.Parameters.AddWithValue("@FromDate", vFromDate)
        cmd.Parameters.AddWithValue("@ToDate", vToDate)
        cmd.Parameters.AddWithValue("@Percent", taDarsad)
        cmd.Parameters.AddWithValue("@ByRahgiri", darSatheRahgiri)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn.Connection
        sda.SelectCommand = cmd
        sda.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function

End Class