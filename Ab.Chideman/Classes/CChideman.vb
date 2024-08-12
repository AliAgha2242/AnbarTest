' DB OK 84/07/27
' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس چيدمان براي مؤلفه  چيدمان سيستم انبار 
'System ::انبار

Public Class CChideman
    Public Shared Sub ShowNoeChideman (ByVal aMDIParent As Form)
        ' نمايش فرم انواع چيدمان
        With FrmabNoeChideman.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowChideman (ByVal aMDIParent As Form)
        ' نمايش فرم چيدمان
        With FrmabChideman.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowSanadObjectChideman(ByVal aMDIParent As Form)
        ' نمايش فرم گروه بندي تراکنش ها 
        With FrmabSanadObjectChideman.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowSharayeteMohiti (ByVal aMDIParent As Form)
        ' نمايش فرم شرايط محيطي
        With FrmabSharayeteMohiti.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowChidemanSharayet (ByVal aMDIParent As Form)
        ' نمايش فرم شرايط محيطي جايگاههاي نگهداري
        With FrmabChidemanSharayet.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowSharayeteKala (ByVal aMDIParent As Form)
        '  نمايش فرم محدوديت هاي نگهداشت کالا در جايگاههاي نگهداري 
        With FrmabSharayeteKala.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowKalaChideman (ByVal aMDIParent As Form)
        ' نمايش فرم تخصيص کالافيزيکي به جايگاههاي نگهداري
        With FrmabKalaChideman.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowChidemanTekrari (ByVal aMDIParent As Form)
        ' نمايش فرم تخصيص کالافيزيکي به جايگاههاي نگهداري
        With FrmChidemanTekrari.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub
End Class
