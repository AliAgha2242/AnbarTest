' DB OK 84/07/27
' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس حسابداري براي مؤلفه  حسابداري سيستم انبار 
'System ::انبار

Public Class CHesabdari
    Public Shared Sub ShowAnbarKala(ByVal aMDIParent As Form)
        ' نمايش فرم كالاهاي انبار
        With frmKalaAnbar.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub


    Public Shared Sub ShowAlertNerkhStandardAsnad(ByVal aMDIParent As Form, Optional ByVal aCallFromMenu As Integer = 0)
        ' نمايش هشدار كالاهاي بدون نرخ استاندارد
        With FrmAlertNerkhStandardAsnad.DefInstance
            .DataLoad()
            .MdiParent = aMDIParent
            .Visible = False
            If aCallFromMenu = 0 Then
                If .DVrpt.DataRows >= 1 Then
                    .Show()
                Else
                    .ExitSub()
                End If
            Else
                .Show()
            End If
        End With

    End Sub


    Public Shared Sub ShowSanadMali (ByVal aMDIParent As Form _
                                     , Optional ByVal aSanadSN As Decimal = 0 _
                                     , Optional ByVal aNoeAccessRight As String = "")
        ' نمايش فرم ثبت ريال واقعي اسناد
        With FrmSanadMali.DefInstance
            If aSanadSN <> 0 Then
                .SanadSN = aSanadSN
            End If
            If aMDIParent Is Nothing Then
                .ShowDialog()
            ElseIf aMDIParent.IsMdiContainer Then
                .MdiParent = aMDIParent
                .Show()
            Else
                .ShowDialog (aMDIParent)
            End If
            .Activate()
        End With
    End Sub
End Class
