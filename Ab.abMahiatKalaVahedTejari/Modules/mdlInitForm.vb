Public Module InitForm
    Friend tp As NetSql.Common.CSystem
    Friend cn As NetSql.DB.CConnection
    Friend gSM As Minoo.SecurityManager.FTSecurityManager
    Friend gHelpFileName As String
    Friend gVahedeTejariSN As Decimal
    Friend gSNFieldOption As EnumFieldOptions
    Friend DBLog As Minoo.Log.FTLogEvents

    Public Sub Init (ByVal atp As NetSql.Common.CSystem, ByVal acn As NetSql.DB.CConnection, _
                     ByVal aSM As Minoo.SecurityManager.FTSecurityManager, _
                     ByVal aHelpFileName As String, ByVal aVahedeTejariSN As Decimal, _
                     ByVal agSNFieldOption As EnumFieldOptions, ByVal aDBLog As Minoo.Log.FTLogEvents)
        tp = atp
        cn = acn
        gSM = aSM
        gHelpFileName = aHelpFileName
        gVahedeTejariSN = aVahedeTejariSN
        gSNFieldOption = agSNFieldOption
        DBLog = aDBLog
    End Sub
End Module
