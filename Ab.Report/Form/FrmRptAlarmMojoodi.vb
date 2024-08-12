
Imports VB = Microsoft.VisualBasic

Public Class FrmRptAlarmMojoodi

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptAlarmMojoodi
    Private Shared m_InitializingDefInstance As Boolean
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl


    Public Shared Property DefInstance() As FrmRptAlarmMojoodi
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptAlarmMojoodi
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptAlarmMojoodi)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub InitControls()


        dbcKala.LateBinding = True
        dbcKala.ShowSelectAll = True
        dbcKala.Bind(cn, "Select Top 100 pakala.kalasn , kalano+'.'+kalads kalads from pakala Inner join abanbarkala on pakala.Kalasn=abanbarkala.kalasn Where AnbarSn =" & gAnbarSN, "KalaSN", "KalaDS")


        Dim arrList As New Collections.ArrayList
        arrList.Add(0.0)
        With dbcKala
            .CheckedValues = arrList.ToArray()
            .DroppedDown = True
            .Enabled = True
        End With



    End Sub

    Private Sub InitJanus()

        With GridEX1.RootTable.Columns
            With .Add("KalaNO", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شرح کالا"
            End With
            With .Add("MojoodiMax", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "حداکثر موجودی "
            End With
            With .Add("MojoodiAnbar", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "موجودی انبار"
            End With
            With .Add("Enheraf", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انحراف موجودی"
            End With
            
        End With

    End Sub

    Private Sub FrmRTarakoneshGorooh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim vErrMsg As String
        Dim _Vkala As String = ""

        If Trim(dbcKala.Text) <> "" Then
            _Vkala = Trim(dbcKala.getStringValues)
        Else
            vErrMsg = vErrMsg & Chr(13) & "کالا مشخص نشده است"
        End If

        If _Vkala = "0.000" Then
            _Vkala = "0"
        End If
        Dim _str As String = "_abSpG_GetMojoodiAbarAndMojoodiMaxForAlarm " & gAnbarSN & "," & _Vkala

        GridEX1.DataSource = cn.ExecuteQuery(_str)

        RefreshDataSet()

        SettingColor()

        Me.Cursor = System.Windows.Forms.Cursors.Default()
    End Sub

    Private Sub btnShowSanad_Click(sender As System.Object, e As System.EventArgs) Handles btnShowSanad.Click
        Dim dgrow As Janus.Windows.GridEX.GridEXRow
        If GridEX1.GetRow() Is Nothing Then Exit Sub

        dgrow = GridEX1.GetRow()

        Dim _Sanadno As Long = dgrow.Cells("Sanadno").Value
        'Dim frm As New Minoo.Applications

    End Sub

    Public Sub SettingColor()
        Try

            Dim i As Integer

            For i = 0 To GridEX1.RowCount - 1
                Dim dgrow As Janus.Windows.GridEX.GridEXRow
                dgrow = GridEX1.GetRow(i)

                Dim jsstyle As New Janus.Windows.GridEX.GridEXFormatStyle

                If CDec(dgrow.Cells("Enheraf").Value) > 0 Then
                    jsstyle.BackColor = Color.OrangeRed
                End If

                dgrow.RowStyle = jsstyle

            Next

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try

    End Sub


    '    Private Sub GridEX1_CurrentCellChanged(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) _
    '    Handles GridEX1.CurrentCellChanged
    '        SettingColor()
    '    End Sub

    '    Private Sub GridEX1_CurrentCellChanging(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) _
    'Handles GridEX1.CurrentLayoutChanged
    '        SettingColor()
    '    End Sub

    'Private Sub GridEX1_Scroll(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.Scroll
    '    SettingColor()
    'End Sub
End Class
