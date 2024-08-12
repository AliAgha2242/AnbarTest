''Dehghani 14000128

Public Class FrmEditBatchNoAndEnghezaInSanad

    Public KalaPhizikiSN, KalaSN As Decimal
    Public KalaDS, BatchNo, Tozih, NoeEngheza As String

    Private Sub btNupdate_Click(sender As Object, e As EventArgs) Handles btNupdate.Click
        If NetSql.Common.CSystem.MsgBox(" آيا رکورد انتخاب شده اصلاح گردد ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
            Try
                Dim VNoeEnghezaSN As String
                VNoeEnghezaSN = dbcNoeEnghezaSNB.BoundText
                cn.ExecuteNoneQuery("abSpC_UpdateNoeEnghezaKalaPhiziki " & KalaPhizikiSN & "," & VNoeEnghezaSN & ",'" & TxtBatchNo.Text & "','" & TxtTozih.Text & "','" & gSM.UserID_Name & "','" & System.Windows.Forms.SystemInformation.ComputerName & "'")

            Catch ex As Exception
                CSystem.MsgBox(ex.Message)
            End Try

        End If
        Me.Close()
    End Sub

    Private Sub FrmEditBatchNoAndEnghezaInSanad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcNoeEnghezaSNB.Bind(cn, "Select 0 As NoeEngheza,'تاریخ انقضاء' as NoeEnghezaDS Union Select 1 As NoeEngheza,'تاریخ ReTest' as NoeEnghezaDS", "NoeEngheza", "NoeEnghezaDS")
        dbcNoeEnghezaSNB.Text = NoeEngheza
        TxtTozih.Text = If(IsDBNull(Tozih) Or IsNothing(Tozih), "", Tozih)
        TxtBatchNo.Text = If(IsDBNull(BatchNo) Or IsNothing(BatchNo), "", BatchNo)
        LblKala.Text = If(IsDBNull(KalaDS) Or IsNothing(KalaDS), "", KalaDS)
    End Sub
End Class