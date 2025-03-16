Imports System
Imports System.Data
'Imports Minoo.Applications.Anbar.Common
'Imports NetSql.DB
'Imports NetSql.Common
Imports Anbar.DAL

Public Class ClsDataAccessRule

    Dim _ClsDataAccess As New Anbar.DAL.ClsDataAccess

    Public Sub ImportFromExcel(dt As DataTable, VahedeTejariSN As Decimal, AnbarSN As Decimal, Tarakoneshsn As Integer, TafsiliSn As Decimal, ShomarehSefaresh As String, Host_Name As String, UserID_Name As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem)
        Try

            _ClsDataAccess.ImportFromExcel(dt, VahedeTejariSN, AnbarSN, Tarakoneshsn, TafsiliSn, ShomarehSefaresh, Host_Name, UserID_Name, cn, tp)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function GetGoroohTafsiliTarakonesh(_NoeAnbarSN As Integer, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView
        Try

            Return _ClsDataAccess.GetGoroohTafsiliTarakonesh(_NoeAnbarSN, cn, tp)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetListASnadErsaliBeShoabDasti(AnbarSn As Decimal, Tarakoneshsn As Integer, Fromdate As String, ToDate As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView
        Try

            Return _ClsDataAccess.GetListASnadErsaliBeShoabDasti(AnbarSn, Tarakoneshsn, Fromdate, ToDate, cn, tp)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Public Function GetMAvadbariKarteStandard(_vSN As Decimal, _vToolideRooz As Decimal, _vTRooz As Integer, _vAzTarikh As String, cn As NetSql.DB.CConnection) As DataSet
        Try

            Return _ClsDataAccess.GetMAvadbariKarteStandard(_vSN, _vToolideRooz, _vTRooz, _vAzTarikh, cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Public Sub InsertDarkhastKaladetail(DarkhastSN As Decimal, AnbarSN As Decimal, Ds As DataSet, cn As NetSql.DB.CConnection, UserID_Name As String)
        Try

            _ClsDataAccess.InsertDarkhastKaladetail(DarkhastSN, AnbarSN, Ds, cn, UserID_Name)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function GetMojoodikalaphiziki(ByVal VahedetejariSn As Decimal, ByVal AnbarSn As Decimal, ByVal KalaSn As Decimal, ByVal fdate As String, ByVal tdate As String, cn As NetSql.DB.CConnection) As DataView
        Try

            Return _ClsDataAccess.GetMojoodikalaphiziki(VahedetejariSn, AnbarSn, KalaSn, fdate, tdate, cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function IsTarakoneshInTarakoneshGorooh(ByVal _TarakoneshGorooh As Int16, ByVal _TarakoneshSN As Int16, cn As NetSql.DB.CConnection) As Boolean
        Try

            Return _ClsDataAccess.IsTarakoneshInTarakoneshGorooh(_TarakoneshGorooh, _TarakoneshSN, cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function ExistKalaInasnadButNotInabAnbarKala(ByVal _AnbarSn As Decimal, ByVal _FromDate As String, ByVal _ToDate As String, cn As NetSql.DB.CConnection) As (String, DataTable)
        Try

            Return _ClsDataAccess.ExistKalaInasnadButNotInabAnbarKala(_AnbarSn, _FromDate, _ToDate, cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    Public Function SaveKalaThatsNotInAnbarKala(ByVal Table As DataTable, ByVal FolderPath As String)
        Return _ClsDataAccess.GetExcelKalaNotInAnbar(Table, FolderPath)
    End Function

    Public Function GetMojoodiWithEnghezaDate(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetMojoodiWithEnghezaDate(VahedeTejariSN, vVahedeTejariSN, TaminKonandehSN, NoeTaminKonandehSN, KalaSN, NoeMahsoolSN, _IsRooz, _TRooz, TaEnghezaDate, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function

    Public Function GetMojoodiWithEnghezaDate_Tarakonesh(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, vTarakoneshSN As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetMojoodiWithEnghezaDate_Tarakonesh(VahedeTejariSN, vVahedeTejariSN, TaminKonandehSN, NoeTaminKonandehSN, KalaSN, NoeMahsoolSN, _IsRooz, _TRooz, TaEnghezaDate, vTarakoneshSN, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function
    Public Function GetVaredehMojaz(VahedeTejariSN As Decimal, KalaSN As String, FromDate As String, ToDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetVaredehMojaz(VahedeTejariSN, KalaSN, FromDate, ToDate, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function
    'Add by yekta 970226
    Public Function GetMojoodiAndEnghezaDate(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As String, _IsRooz As Integer, _Type As Integer, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetMojoodiAndEnghezaDate(VahedeTejariSN, vAnbarSN, TaminKonandehSN, NoeTaminKonandehSN, KalaSN, NoeMahsoolSN, _TRooz, TaEnghezaDate, TarakoneshSN, _IsRooz, _Type, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function
    'Add by yekta 920913
    Public Function GetQCIntervals(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, KalaSN As String, FVoroodDate As String, TVoroodDate As String, LastNoeTarakoneshkalano As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetQCIntervals(VahedeTejariSN, vAnbarSN, TaminKonandehSN, KalaSN, FVoroodDate, TVoroodDate, LastNoeTarakoneshkalano, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function
    'Add by yekta 920616
    Public Function GetGozareshKardexKalaphiziki(FromDate As String, ToDate As String, AnbarSN As Decimal, VahedeTejariSN As Decimal, KalaSN As Decimal, ShomarehRahgiri As String, SanadStatus As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
        Try
            Return _ClsDataAccess.GetGozareshKardexKalaphiziki(FromDate, ToDate, AnbarSN, VahedeTejariSN, KalaSN, ShomarehRahgiri, SanadStatus, cn, tp)
        Catch ex As System.Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function
    'Add by Dehghani 930423
    Public Function ReadFieldsProperties(TarakoneshSN As Integer, anbarSN As Decimal, VahedTejariSn As Decimal, cn As NetSql.DB.CConnection) As DataView
        Try
            Return _ClsDataAccess.ReadFieldsProperties(TarakoneshSN, anbarSN, VahedTejariSn, cn)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Function

    Public Sub InsertKalaSahmInDatabase(KalaSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
        Try

            _ClsDataAccess.InsertKalaSahmInDatabase(KalaSN, cn, UserID_Name)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub DeleteKalaSahmInDatabase(KalaSahmSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
        Try

            _ClsDataAccess.DeleteKalaSahmInDatabase(KalaSahmSN, cn, UserID_Name)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub InsertKalaShoabSahmInDatabase(KalaSahmSN As Decimal, Tarikh As String, Darsad As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
        Try
            Dim dv As DataView = cn.ExecuteQuery("Select VahedeTejariSN from paVahedeTejari where PedarVahedeTejariSN =9.935 And VahedeTejariStatus =1 And Not VahedeTejariSN  in (Select VahedeTejariSN from abKalaShoabSahm Where KalaSahmSN=" & KalaSahmSN & ")")
            If dv.Count > 0 Then
                For i = 0 To dv.Count - 1
                    Dim _VahedeTejariSN As Decimal = dv(i)(0)

                    _ClsDataAccess.InsertKalaShoabSahmInDatabase(KalaSahmSN, _VahedeTejariSN, Tarikh, Darsad, cn, UserID_Name)

                Next

            End If

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function GetDatasourceForPrintLabel(ByVal SanadHaSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            GetDatasourceForPrintLabel = _ClsDataAccess.GetDatasourceForPrintLabel(SanadHaSn, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetDatasourceForPrintHavalehTolid(ByVal SanadSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            GetDatasourceForPrintHavalehTolid = _ClsDataAccess.GetDatasourceForPrintHavalehTolid(SanadSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function GetTafkikByAnbar(ByVal Cn As NetSql.DB.CConnection, ByVal AnbarSN As Decimal) As DataSet
        Try
            GetTafkikByAnbar = _ClsDataAccess.GetTafkikByAnbar(Cn, AnbarSN)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function BayganiDarkhastTafkikShode(ByVal Cn As NetSql.DB.CConnection, ByVal DarKhastSN As Decimal) As String
        Try
            BayganiDarkhastTafkikShode = _ClsDataAccess.BayganiDarkhastTafkikShode(Cn, DarKhastSN)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function EnteghalMojoodiKalaPhiziki(ByVal Cn As NetSql.DB.CConnection, ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal,
                                               ByVal NoeanbarSN As Decimal, ByVal TarakoneshSNResid As Decimal, ByVal TarakoneshSNHavaleh As Decimal,
                                                ByVal KalaSN As Decimal, ByVal FromKalaPhizikiSN As Decimal, ByVal ToKalaPhizikiSN As Decimal,
                                               ByVal Meghdar As Decimal, ByVal Tozih As String,
                                               ByVal SelectRahgiriBySystem As Boolean, ByVal UserID_Name As String, ByVal Host_Name As String,
                                               ByVal UserId As Integer) As String
        Try
            EnteghalMojoodiKalaPhiziki = _ClsDataAccess.EnteghalMojoodiKalaPhiziki(Cn, VahedeTejariSN, AnbarSN, NoeanbarSN, TarakoneshSNResid,
                                                                                   TarakoneshSNHavaleh, KalaSN, FromKalaPhizikiSN, ToKalaPhizikiSN,
                                                                                   Meghdar, Tozih, SelectRahgiriBySystem, UserID_Name, Host_Name, UserId)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetRptMoghyeratEstandardMaliVaAnbar(ByVal Shobe As String, ByVal Tarakonesh As String, ByVal Fromdate As String, ByVal Todate As String,
                                                    ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            GetRptMoghyeratEstandardMaliVaAnbar = _ClsDataAccess.GetRptMoghyeratEstandardMaliVaAnbar(Shobe, Tarakonesh, Fromdate, Todate, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetMojoudiKalaHayeDaftarForoosh(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal NoeAnbarSN As Decimal, ByVal KalaSN As String, ByVal DafTarSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            GetMojoudiKalaHayeDaftarForoosh = _ClsDataAccess.GetMojoudiKalaHayeDaftarForoosh(VahedeTejariSN, AnbarSN, NoeAnbarSN, KalaSN, DafTarSn, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                             ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            KartablZayeat_EbtalDarkhast = _ClsDataAccess.KartablZayeat_EbtalDarkhast(VahedeTejariSN, ServerName, DbName, ZayeatGardeshSN, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    Public Function KartablZayeat_TaeedDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                              NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            KartablZayeat_TaeedDarkhast = _ClsDataAccess.KartablZayeat_TaeedDarkhast(VahedeTejariSN, ServerName, DbName, ZayeatGardeshSN, NoeDarjNerkh, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_TaeedDarkhast_xml(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshXml As String,
                                              NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            KartablZayeat_TaeedDarkhast_xml = _ClsDataAccess.KartablZayeat_TaeedDarkhast_xml(VahedeTejariSN, ServerName, DbName, ZayeatGardeshXml, NoeDarjNerkh, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function KartablZayeat_EbtalRadif(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                            ByVal ZayeatGardeshHaSN As Decimal, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            KartablZayeat_EbtalRadif = _ClsDataAccess.KartablZayeat_EbtalRadif(VahedeTejariSN, ServerName, DbName, ZayeatGardeshSN, ZayeatGardeshHaSN, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_ReprtRavandErja(ByVal ZayeatGardeshSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            KartablZayeat_ReprtRavandErja = _ClsDataAccess.KartablZayeat_ReportRavandErja(ZayeatGardeshSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_GetMaster(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            KartablZayeat_GetMaster = _ClsDataAccess.KartablZayeat_GetMaster(UserId, Fdate, Tdate, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function KartablZayeat_GetDetail(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            KartablZayeat_GetDetail = _ClsDataAccess.KartablZayeat_GetDetail(UserId, Fdate, Tdate, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_GetNerKhSanadZayeat(ByVal ZayeatGardeshSN As String, ByVal NerkhType As Short, ByVal AccessForDarjNerkh As Boolean, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            KartablZayeat_GetNerKhSanadZayeat = _ClsDataAccess.KartablZayeat_GetNerKhSanadZayeat(ZayeatGardeshSN, NerkhType, AccessForDarjNerkh, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function KartablZayeat_GetReport(ByVal VahedeTejariSN As String, ByVal FromDate As String, ByVal ToDate As String, ByVal ZayeatGardeshSN As String, ByVal TaminKonandehSN As String, ByVal KalaSN As String, ByVal ReportType As Short, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            KartablZayeat_GetReport = _ClsDataAccess.KartablZayeat_GetReport(VahedeTejariSN, FromDate, ToDate, ZayeatGardeshSN, TaminKonandehSN, KalaSN, ReportType, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''ghasemi
    Public Function MoghayratAvaldoreVaPayandore_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal Kala1Rahgiri0 As Boolean, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            MoghayratAvaldoreVaPayandore_GetReport = _ClsDataAccess.MoghayratAvaldoreVaPayandore_GetReport(FromDate, ToDate, Kala1Rahgiri0, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    ''ghasemi

    Function GetBarcodeScannerDataFromMainServer(ByVal Cn As NetSql.DB.CConnection) As String
        Try
            GetBarcodeScannerDataFromMainServer = _ClsDataAccess.GetBarcodeScannerDataFromMainServer(Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function



    Sub GetLastProductCatalogue(ByVal Cn As NetSql.DB.CConnection, ByVal UserName As String, ByVal HostName As String)
        Try
            _ClsDataAccess.GetLastProductCatalogue(Cn, UserName, HostName)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub


    Public Function GetBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal Fromdate As String, ByVal Todate As String, ByVal State As Integer,
                                                ByVal Cn As NetSql.DB.CConnection, Optional ByVal SpName As String = "abSPG_ProductCatalogueGetData") As DataSet
        Try
            GetBarcodeScannerData = _ClsDataAccess.GetBarcodeScannerData(VahedeTejariSN, AnbarSN, Fromdate, Todate, State, Cn, SpName)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    '-------------Tavakoli---Alipour -------------
    Public Function GetBarcodeThatsNotHaveProduct(ByVal Cn As NetSql.DB.CConnection _
            , Optional ByVal Sp As String = "abSpC_abProductCatalogueKalaIRC") As DataView
        Try
            GetBarcodeThatsNotHaveProduct = _ClsDataAccess.GetBarcodeThatsNotHaveProduct(Cn, Sp)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Function SabteSanadByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal, ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            SabteSanadByBarcodeScannerData = _ClsDataAccess.SabteSanadByBarcodeScannerData(VahedeTejariSN, AnbarSN, XmlStr, UserId, UserName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Function SabteSanadKasriEzafiByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal, ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String
        Try
            SabteSanadKasriEzafiByBarcodeScannerData = _ClsDataAccess.SabteSanadKasriEzafiByBarcodeScannerData(VahedeTejariSN, AnbarSN, XmlStr, UserId, UserName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Function GetListTaminKonandegan(ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            GetListTaminKonandegan = _ClsDataAccess.GetListTaminKonandegan(Cn)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''ghasemi14010512
    Public Function FaseleDarkhastTaHavaleh_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal TaminKonandeSn As String, ByVal KalaSN As String, ByVal VahedetejariSN As Decimal, ByVal gAnbarSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            FaseleDarkhastTaHavaleh_GetReport = _ClsDataAccess.FaseleDarkhastTaHavaleh_GetReport(FromDate, ToDate, TaminKonandeSn, KalaSN, VahedetejariSN, gAnbarSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    ''ghasemi14010512

    ''ghasemi14021010
    Public Function RptDarkhastRepair_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AmvalSN As String, ByVal VahedetejariSN As String, ByVal StatusSN As String, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            RptDarkhastRepair_GetReport = _ClsDataAccess.RptDarkhastRepair_GetReport(FromDate, ToDate, AmvalSN, VahedetejariSN, StatusSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function RptPriodicService_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AmvalSN As String, ByVal VahedetejariSN As String, ByVal StatusSN As String, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            RptPriodicService_GetReport = _ClsDataAccess.RptPriodicService_GetReport(FromDate, ToDate, AmvalSN, VahedetejariSN, StatusSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    ''ghasemi14021010

    Function RptUIDtracking(ByVal TaminSN As Decimal, ByVal KalaSN As Decimal, ByVal KalaPhizikiSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            RptUIDtracking = _ClsDataAccess.RptUIDtracking(TaminSN, KalaSN, KalaPhizikiSN, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Public Sub EbtalSabtBarcodeReader(ByVal CatalogueSN_Str As String, ByVal Cn As NetSql.DB.CConnection)
        Try

            _ClsDataAccess.EbtalSabtBarcodeReader(CatalogueSN_Str, Cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub SyncProductCatalogueData_ShoabToGBID(ByVal Xmlstr As String, ByVal Cn As NetSql.DB.CConnection)
        Try

            _ClsDataAccess.SyncProductCatalogueData_ShoabToGBID(Xmlstr, Cn)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub


    Public Function DarkhastRepair_NahayeeDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                                   ByVal DarkhastRepairSN As Decimal,
                                                    ByVal DarkhastRepairTozih As String,
                                                   ByVal dvDarkhastRepairAccessories As DataView,
                                          dvDarkhastRepairOperator As DataView, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

        Try
            DarkhastRepair_NahayeeDarkhast = _ClsDataAccess.DarkhastRepair_NahayeeDarkhast(VahedeTejariSN, ServerName, DbName, UserName, DarkhastRepairSN, DarkhastRepairTozih, dvDarkhastRepairAccessories, dvDarkhastRepairOperator, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function DarkhastRepair_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                               ByVal DarkhastRepairSN As Decimal,
                                                ByVal DarkhastRepairTozih As String, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

        Try
            DarkhastRepair_EbtalDarkhast = _ClsDataAccess.DarkhastRepair_EbtalDarkhast(VahedeTejariSN, ServerName, DbName, UserName, DarkhastRepairSN, DarkhastRepairTozih, UserId, UserIdName, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function ReportAghlamTarikhNazdikeAsnadBarcodKhan(fromDate As String, toDate As String, vahedeTejariSns As String, taminKonande As String, kalaSns As String, ByVal roozTaEngheza As Integer, ByVal parameterClos As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataTable
        Try
            ReportAghlamTarikhNazdikeAsnadBarcodKhan = _ClsDataAccess.ReportAghlamTarikhNazdikeAsnadBarcodKhan(fromDate, toDate, vahedeTejariSns, taminKonande, kalaSns, roozTaEngheza, parameterClos, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function


    ''Add Form By Bagheri (HB) 14030618 _Begin
    Public Function MoghayesehSanadRialiMaliVaAnbar_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AnbarSN As String, ByVal TarakoneshSN As String, ByVal SanadNo As String, ByVal Cn As NetSql.DB.CConnection) As DataView
        Try
            MoghayesehSanadRialiMaliVaAnbar_GetReport = _ClsDataAccess.MoghayesehSanadRialiMaliVaAnbar_GetReport(FromDate, ToDate, AnbarSN, TarakoneshSN, SanadNo, Cn)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    ''Add Form By Bagheri (HB) 14030618 _End


End Class