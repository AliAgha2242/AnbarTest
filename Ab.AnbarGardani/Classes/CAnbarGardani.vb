' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس انبارگرداني براي مؤلفه  انبارگرداني سيستم انبار 
'System ::انبار

Public Class CAnbarGardani
    Public Shared Sub ShowAnbarGardani(ByVal aMDIParent As Form, ByVal AnbarGardaniTypeSn As Int16)

        ' نمايش فرم تعريف انبارگرداني 
        With FrmabAnbarGardani.DefInstance
            .MdiParent = aMDIParent
            .AnbarGardaniTypeSN = AnbarGardaniTypeSn
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

    Public Shared Sub ShowAnbarGardaniByEnghezaDate(ByVal aMDIParent As Form, ByVal AnbarGardaniTypeSn As Int16)

        ' نمايش فرم تعريف انبارگرداني 
        With FrmabAnbarGardaniEnghezaDate.DefInstance
            .MdiParent = aMDIParent
            .AnbarGardaniTypeSN = AnbarGardaniTypeSn
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

End Class
