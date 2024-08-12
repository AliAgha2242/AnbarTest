' DB OK 84/07/27
' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس رزرو کالا براي مؤلفه  رزرو کالا  سيستم انبار 
'System ::انبار

Public Class CRezervKala
    Public Shared Sub ShoAnbarKalaRezerv (ByVal aMDIParent As Form)
        ' نمايش فرم رزرو کالا
        With frmAnbarKalaRezerv.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowFrmMohlateForoosh(ByVal aMDIParent As Form)
        ' نمايش فرم رزرو کالا
        With frmMohlateForoosh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

End Class
