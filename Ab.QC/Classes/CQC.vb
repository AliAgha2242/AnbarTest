Public Class CQC
    Public Shared Sub ShowQC(ByVal aMDIParent As Form)
        ' ‌نمايش فرم کنترل کيفيت
        With FrmQC.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub DarkhastRepair(ByVal aMDIParent As Form)
        With FrmDarkhastRepair.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub PriodicService(ByVal aMDIParent As Form)
        With FrmPriodicService.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

End Class
