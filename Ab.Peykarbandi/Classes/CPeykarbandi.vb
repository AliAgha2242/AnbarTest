' DB OK 84/07/27
' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس پيکربندي براي مؤلفه  پيکربندي  سيستم انبار 
'System ::انبار

Public Class CPeykarbandi
    Public Shared Sub ShowAnbarTarakonesh (ByVal aMDIParent As Form)
        ' نمايش فرم تراکنش هاي هر انبار 
        With FrmAnbarTarakonesh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub


    Public Shared Sub ShowTarakoneshGoroohTafsili (ByVal aMDIParent As Form)
        ' نمايش فرم ارتباط تراکنش هاي انبار با گروه هاي تفصيلي 
        With FrmTarakoneshGoroohTafsili.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub


    Public Shared Sub ShowAnbarNoeRahgiri (ByVal aMDIParent As Form)
        ' نمايش فرم رويه رهگيري هر انبار 
        With frmAnbarNoeRahgiri.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With

    End Sub

    Public Shared Sub ShowAnbar(ByVal aMDIParent As Form)
        ' نمايش فرم تعريف انبار 
        With FrmAnbar.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowTarakoneshConstraint(ByVal aMDIParent As Form)
        ' نمايش فرم تعريف انبار 
        With FrmabTarakoneshContraint.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub AnbarAccessControl(ByVal aMDIParent As Form)
        With FrmAccessControl.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub



    Public Shared Sub ShowAnbarConfig(ByVal aMDIParent As Form)
        ' نمايش فرم تنظیم اسناد متقابل انبار 
        With FrmabAnbarConfig.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowAnbarKalaParameter(ByVal aMDIParent As Form)
        ' نمايش فرم تنظیم اسناد متقابل انبار 
        With FrmabKalaParameter.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowTashimPattern (ByVal aMDIParent As Form)
        ' نمايش فرم تعريف انبار 
        With FrmTashimPattern.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG ("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowTarakoneshGorooh(ByVal aMDIParent As Form)
        ' نمايش فرم گروه بندي تراکنش ها 
        With FrmabTarakoneshGorooh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowNoeBarnameh(ByVal aMDIParent As Form)
        ' نمايش فرم انواع بارنامه
        With FrmabNoeBarnameh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
End Class
