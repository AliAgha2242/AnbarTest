Imports System.Data.Metadata
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks
Imports Excel = Microsoft.Office.Interop.Excel
Public Interface IClsDataAccess

    Function GetGoroohTafsiliTarakonesh(_NoeAnbarSN As Integer, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView
    Sub ImportFromExcel(dt As DataTable, VahedeTejariSN As Decimal, AnbarSN As Decimal, Tarakoneshsn As Integer, TafsiliSn As Decimal, ShomarehSefaresh As String, Host_Name As String, UserID_Name As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem)
    Function GetVahedeSanjeshKala(_KalaNo As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView
    Function GetListASnadErsaliBeShoabDasti(AnbarSn As Decimal, Tarakoneshsn As Integer, Fromdate As String, ToDate As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView
    Function GetMAvadbariKarteStandard(_vSN As Decimal, _vToolideRooz As Decimal, _vTRooz As Integer, _vAzTarikh As String, cn As NetSql.DB.CConnection) As DataSet
    Sub InsertDarkhastKaladetail(DarkhastSN As Decimal, AnbarSN As Decimal, Ds As DataSet, cn As NetSql.DB.CConnection, UserID_Name As String)
    Function GetMojoodikalaphiziki(ByVal VahedetejariSn As Decimal, ByVal AnbarSn As Decimal, ByVal KalaSn As Decimal, ByVal fdate As String, ByVal tdate As String, cn As NetSql.DB.CConnection) As DataView
    Function IsTarakoneshInTarakoneshGorooh(ByVal _TarakoneshGorooh As Int16, ByVal _TarakoneshSN As Int16, cn As NetSql.DB.CConnection) As Boolean
    Function ExistKalaInasnadButNotInabAnbarKala(ByVal AnbarSn As Decimal, ByVal FromDate As String, ByVal ToDate As String, cn As NetSql.DB.CConnection) As (String, DataTable)
    Function GetMojoodiWithEnghezaDate(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
    Function GetMojoodiWithEnghezaDate_Tarakonesh(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView

    'Add by Dehghani 981010
    Function EnteghalMojoodiKalaPhiziki(ByVal Cn As NetSql.DB.CConnection, ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal,
                                        ByVal NoeanbarSN As Decimal, ByVal TarakoneshSNResid As Decimal, ByVal TarakoneshSNHavaleh As Decimal,
                                        ByVal KalaSN As Decimal, ByVal FromKalaPhizikiSN As Decimal, ByVal ToKalaPhizikiSN As Decimal,
                                        ByVal Meghdar As Decimal, ByVal Tozih As String,
                                        ByVal SelectRahgiriBySystem As Boolean, ByVal UserID_Name As String, ByVal Host_Name As String, ByVal UserId As Integer) As String

    Function GetVaredehMojaz(VahedeTejariSN As Decimal, KalaSN As String, FromDate As String, ToDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
    'Add by Yekta 970226
    Function GetMojoodiAndEnghezaDate(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As String, _IsRooz As Integer, _Type As Integer, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
    'Add by Yekta 920913
    Function GetQCIntervals(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, KalaSN As String, FVoroodDate As String, TVoroodDate As String, LastNoeTarakoneshkalano As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView
    'Add by yekta 920616
    Function GetGozareshKardexKalaphiziki(FromDate As String, ToDate As String, AnbarSN As Decimal, VahedeTejariSN As Decimal, KalaSN As Decimal, ShomarehRahgiri As String, SanadStatus As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView

    Function ReadFieldsProperties(TarakoneshSN As Integer, anbarSN As Decimal, VahedTejariSn As Decimal, cn As NetSql.DB.CConnection) As DataView

    Sub InsertKalaSahmInDatabase(KalaSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
    Sub DeleteKalaSahmInDatabase(KalaSahmSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
    Sub InsertKalaShoabSahmInDatabase(KalaSahmSN As Decimal, VahedeTejariSN As Decimal, Tarikh As String, Darsad As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
    Function GetDatasourceForPrintLabel(ByVal SanadHaSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
    Function GetDatasourceForPrintHavalehTolid(ByVal SanadSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
    Function GetTafkikByAnbar(ByVal Cn As NetSql.DB.CConnection, ByVal AnbarSn As Decimal) As DataSet
    Function BayganiDarkhastTafkikShode(ByVal Cn As NetSql.DB.CConnection, ByVal DarKhastSN As Decimal) As String

    Function GetRptMoghyeratEstandardMaliVaAnbar(ByVal Shobe As String, ByVal Tarakonesh As String, ByVal Fromdate As String, ByVal Todate As String,
                                                    ByVal Cn As NetSql.DB.CConnection) As DataView
    'Sub InsertKalaShoabTarikhSahmInDatabase(KalaSahmSoabSN As Decimal, VahedeTejariSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String)
    Function GetMojoudiKalaHayeDaftarForoosh(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal NoeAnbarSN As Decimal, ByVal KalaSN As String, ByVal DafTarSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView

    Function KartablZayeat_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                             ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

    Function KartablZayeat_TaeedDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                               NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

    Function KartablZayeat_TaeedDarkhast_xml(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshXML As String,
                                               NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

    Function KartablZayeat_EbtalRadif(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                           ByVal ZayeatGardeshHaSN As Decimal, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String

    Function KartablZayeat_ReportRavandErja(ByVal ZayeatGardeshSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView

    Function KartablZayeat_GetMaster(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView

    Function KartablZayeat_GetDetail(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView

    Function KartablZayeat_GetNerKhSanadZayeat(ByVal ZayeatGardeshSN As String, ByVal NerkhType As Short, ByVal AccessForDarjNerkh As Boolean, ByVal Cn As NetSql.DB.CConnection) As DataView

    Function KartablZayeat_GetReport(ByVal VahedeTejariSN As String, ByVal FromDate As String, ByVal ToDate As String, ByVal ZayeatGardeshSN As String, ByVal TaminKonandehSN As String, ByVal KalaSN As String, ByVal ReportType As Short, ByVal Cn As NetSql.DB.CConnection) As DataView

    ''ghasemi
    Function MoghayratAvaldoreVaPayandore_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal Kala1Rahgiri0 As Boolean, ByVal Cn As NetSql.DB.CConnection) As DataView
    ''ghasemi

    Function GetBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal Fromdate As String, ByVal Todate As String, ByVal State As Integer,
                                                ByVal Cn As NetSql.DB.CConnection, Optional ByVal SpName As String = "abSPG_ProductCatalogueGetData") As DataSet

    Function SabteSanadByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal,
                                            ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String

    Function SabteSanadKasriEzafiByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal,
                                                   ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String
    Function GetBarcodeScannerDataFromMainServer(ByVal Cn As NetSql.DB.CConnection) As String

    Sub GetLastProductCatalogue(ByVal Cn As NetSql.DB.CConnection, ByVal UserName As String, ByVal HostName As String)
    Function GetLastProductCatalogue_BIS(ByVal Cn As NetSql.DB.CConnection, ByVal ProductCatalogueSN As Decimal, ByVal ProductCatalogueKalaIRcSN As Decimal, ByVal UserName As String, ByVal HostName As String) As DataSet
    Function GetLastProductCatalogue_STD(ByVal Cn As NetSql.DB.CConnection, ByVal ProductCatalogueSN As Decimal, ByVal ProductCatalogueKalaIRcSN As Decimal, ByVal UserName As String, ByVal HostName As String) As DataSet
    Function GetListTaminKonandegan(ByVal Cn As NetSql.DB.CConnection) As DataView

    ''ghasemi14010512 
    Function FaseleDarkhastTaHavaleh_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal TaminKonandeSn As String, ByVal KalaSN As String, ByVal VahedetejariSN As Decimal, ByVal gAnbarSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
    ''ghasemi14010512

    ''ghasemi14021010 
    Function RptDarkhastRepair_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal VAmvalSN As String, ByVal VahedetejariSN As String, ByVal VStatusSN As String, ByVal Cn As NetSql.DB.CConnection) As DataView
    Function RptPriodicService_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal VAmvalSN As String, ByVal VahedetejariSN As String, ByVal VStatusSN As String, ByVal Cn As NetSql.DB.CConnection) As DataView
    ''ghasemi14021010
    Function RptUIDtracking(ByVal TaminSN As Decimal, ByVal KalaSN As Decimal, ByVal KalaPhizikiSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView
    Function RptAdamRayatOlaviatBandiTarikhEngheza(ByVal FromDate As String,
                                                   ByVal ToDate As String,
                                                   ByVal VahedeTejariSN As String,
                                                   ByVal TarakoneshSN As String,
                                                   ByVal TaminKonandehSN As String,
                                                   ByVal KalaSN As String,
                                                   ByVal Cn As NetSql.DB.CConnection) As DataSet
    Sub EbtalSabtBarcodeReader(ByVal CatalogueSN_Str As String, ByVal Cn As NetSql.DB.CConnection)
    Sub SyncProductCatalogueData_ShoabToGBID(ByVal CatalogueSN_Str As String, ByVal Cn As NetSql.DB.CConnection)

    Function DarkhastRepair_NahayeeDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                                    ByVal DarkhastRepairSN As Decimal,
                                                    ByVal DarkhastRepairTozih As String,
                                                    ByVal dvDarkhastRepairAccessories As DataView,
                                                    ByVal dvDarkhastRepairOperator As DataView, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String


    Function DarkhastRepair_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                                   ByVal DarkhastRepairSN As Decimal,
                                                   ByVal DarkhastRepairTozih As String, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String
    Function ReportAghlamTarikhNazdikeAsnadBarcodKhan(ByVal fromDate As String,
                                                      ByVal toDate As String,
                                                      ByVal vahedeTejariSns As String,
                                                      ByVal taminKonande As String,
                                                      ByVal kalaSns As String, ByVal roozTaEngheza As Integer, ByVal parameterClos As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataTable

    ''Add Form By Bagheri (HB) 14030618 
    Function MoghayesehSanadRialiMaliVaAnbar_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AnbarSN As String, ByVal TarakoneshSN As String, ByVal SanadNo As String, ByVal Cn As NetSql.DB.CConnection) As DataView


End Interface

Public Class ClsDataAccess : Implements IClsDataAccess

    Public Function GetGoroohTafsiliTarakonesh(_NoeAnbarSN As Integer, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView _
        Implements IClsDataAccess.GetGoroohTafsiliTarakonesh

        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsmj As New DataSet
        Try
            Cmnd.CommandText = "Select Isnull(AnbarSN,0) AnbarSN,Isnull(NoeAnbarSN,0) NoeAnbarSN,Isnull(Tarakoneshsn,0) Tarakoneshsn," &
                " Isnull(GoroohTafsiliSN,0)GoroohTafsiliSN,Isnull(GoroohTafsiliSN2,0)GoroohTafsiliSN2,Isnull(GoroohTafsiliSN3,0)GoroohTafsiliSN3" &
                " From abTarakoneshGoroohTafsili where NoeAnbarSn=" & _NoeAnbarSN
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsmj)

            Return dsmj.Tables(0).DefaultView

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت گروه تفصیلی تراکنش")
        Finally
            mcn.Close()
        End Try

    End Function

    Public Sub ImportFromExcel(dt As DataTable, VahedeTejariSN As Decimal, AnbarSN As Decimal, Tarakoneshsn As Integer, TafsiliSn As Decimal, ShomarehSefaresh As String,
    Host_Name As String, UserID_Name As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) _
    Implements IClsDataAccess.ImportFromExcel

        Dim _XmlStr As String = "<DsSanad>"
        Dim mcn As New SqlClient.SqlConnection

        Try
            For Each dr As DataRow In dt.Rows
                dr.BeginEdit()
                If dr("KalaNO") Is DBNull.Value Then dr("KalaNO") = 0
                If dr("Rahgiri") Is DBNull.Value Then dr("Rahgiri") = ""
                If dr("Tedad") Is DBNull.Value Then dr("Tedad") = 0
                If dr("EnghezaDate") Is DBNull.Value Then dr("EnghezaDate") = ""
                If dr("ToolidDate") Is DBNull.Value Then dr("ToolidDate") = ""
                dr.EndEdit()
            Next
            For Each dr As DataRow In dt.Rows
                _XmlStr = _XmlStr &
                  "<Table1><KalaNO>" + CStr(dr("KalaNO")) + "</KalaNO>" &
                  "<ShomarehRahgiri>" + CStr(dr("Rahgiri")) + "</ShomarehRahgiri>"
                If Tarakoneshsn <= 59 Then
                    _XmlStr = _XmlStr + "<MeghdareVaredeh>" + CStr(dr("Tedad")) + "</MeghdareVaredeh>" &
                 "<MeghdareSadereh>" + "</MeghdareSadereh>"
                Else
                    _XmlStr = _XmlStr + "<MeghdareVaredeh>" + "</MeghdareVaredeh>" &
                        "<MeghdareSadereh>" + CStr(dr("Tedad")) + "</MeghdareSadereh>"
                End If
                _XmlStr = _XmlStr &
                  "<EnghezaDate>" + CStr(dr("EnghezaDate")) + "</EnghezaDate>" &
                  "<ToolidDate>" + CStr(dr("ToolidDate")) + "</ToolidDate></Table1>-"
            Next
            _XmlStr = _XmlStr.Substring(0, Len(_XmlStr) - 1)
            _XmlStr = _XmlStr + "</DsSanad>"
        Catch ex As Exception
            Exit Sub
        End Try

        Try
            If mcn.State = ConnectionState.Closed Then
                mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
                mcn.Open()
            End If

            Dim da As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim dsj As New DataSet
            Dim i As Integer
            Dim _ErrMsg As String = ""

            'mcn.CallSP("_btSP_BarnamehHaml_InsertByXml", _XmlStr, gSM.Identifier, _ErrMsg)

            Cmnd.CommandText = "_abSP_SanadAnbar_InsertByXml"
            Cmnd.Parameters.AddWithValue("@XmlStr", _XmlStr)
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@TaraKoneShSN", Tarakoneshsn)
            Cmnd.Parameters.AddWithValue("@TafsiliSn", TafsiliSn)
            Cmnd.Parameters.AddWithValue("@ShomarehSefaresh", ShomarehSefaresh)
            Cmnd.Parameters.AddWithValue("@Host_Name", Host_Name)
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserID_Name)
            Cmnd.Parameters.AddWithValue("@ErrMsg", _ErrMsg).Direction = ParameterDirection.Output

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            i = Cmnd.ExecuteNonQuery()

            If i <= 0 Then
                Throw New System.Exception("اشکال در ثبت سند انبار  - " + _ErrMsg)
            End If

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        Finally
            mcn.Close()

        End Try
    End Sub

    Public Function GetVahedeSanjeshKala(_KalaNo As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView _
        Implements IClsDataAccess.GetVahedeSanjeshKala

        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.Open()
        End If

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim ds As New DataSet
        Try
            Cmnd.CommandText = "Select * from paVw_VahedeSanjeshHa Where KalaNO=" & _KalaNo
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            da.SelectCommand = Cmnd
            da.Fill(ds)

            Return ds.Tables.Item(0).DefaultView

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت گروه تفصیلی تراکنش")
        Finally
            mcn.Close()
        End Try
    End Function

    Public Function GetListASnadErsaliBeShoabDasti(AnbarSn As Decimal, Tarakoneshsn As Integer, Fromdate As String, ToDate As String, cn As NetSql.DB.CConnection, tp As NetSql.Common.CSystem) As DataView _
    Implements IClsDataAccess.GetListASnadErsaliBeShoabDasti
        'Return Nothing

        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsmj As New DataSet
        Try
            Cmnd.CommandText = "select * from absanad where sanadno in ('164001353')" ''''''','311034366','311034369','311034367','311034371','311034370','311034372','311034373','311034500','442008249','311034775','369006253','442008358','442008359','311034645','442008347','901000692','311034868')" ''''AnbarSn= " & AnbarSn & " And Tarakoneshsn=" & Tarakoneshsn & " And Taeeddate>='" & Fromdate & "' And Taeeddate<='" & ToDate & "' And SanadStatus=8"
            'Cmnd.CommandText = "Select * from absanad where Sanadno  between '311034418' and '311034443'"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsmj)

            Return dsmj.Tables(0).DefaultView

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت لیست اسناد ارسال به شعب جهت ارسال دستی")
        Finally
            mcn.Close()
        End Try

    End Function

    Public Function GetMAvadbariKarteStandard(_vSN As Decimal, _vToolideRooz As Decimal, _vTRooz As Integer, _vAzTarikh As String, cn As NetSql.DB.CConnection) As DataSet Implements IClsDataAccess.GetMAvadbariKarteStandard
        Dim FunbtMavad As New Minoo.Applications.ProductionPlanning.MavadBari.CMavad

        'Dim ds As DataSet = FunbtMavad.getm(_vSN, _vToolideRooz, _vTRooz, _vAzTarikh)

        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim ds As New DataSet
        Try
            Cmnd.CommandText = "Select * from btVw_MavadBariDataView where KartEstandardSN=" & _vSN
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)

            If Not (ds Is Nothing) AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim myrow As DataRow
                    myrow = ds.Tables(0).Rows(i)
                    myrow.BeginEdit()

                    If _vToolideRooz > 0 Then
                        myrow("MeghdareMasrafVahed") = Math.Round((myrow("MeghdareMasrafVahed") * _vToolideRooz))
                    Else
                        myrow("MeghdareMasrafVahed") = Math.Round(myrow("MeghdareMasrafVahed") * myrow("MeghdareTolid"))
                    End If

                    myrow.EndEdit()
                Next
            End If

            Return ds

        Catch ex As System.Exception
            Throw New System.Exception("اشکال در دریافت اطلاعات موادبری")
        Finally
            mcn.Close()
        End Try

    End Function

    Public Sub InsertDarkhastKaladetail(DarkhastSN As Decimal, AnbarSN As Decimal, Ds As DataSet, cn As NetSql.DB.CConnection, UserID_Name As String) Implements IClsDataAccess.InsertDarkhastKaladetail

        Dim i, j As Integer
        Dim _KalaNO As String = ""

        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If


        For i = 0 To Ds.Tables(0).Rows.Count - 1
            _KalaNO = Ds.Tables(0).Rows(i).Item("Kalano")
            Try
                Dim Cmnd As New SqlCommand
                Cmnd.CommandText = "abDarkhastKala_Insert"
                Cmnd.Parameters.AddWithValue("@DarkhastKalaSN", DarkhastSN - Math.Floor(DarkhastSN))
                Cmnd.Parameters.AddWithValue("@DarkhastSN", DarkhastSN)
                Cmnd.Parameters.AddWithValue("@KalaSN", Ds.Tables(0).Rows(i).Item("KalaSn_IN"))
                Cmnd.Parameters.AddWithValue("@MeghdareDarkhasti", Ds.Tables(0).Rows(i).Item("MeghdareMasrafVahed"))
                Cmnd.Parameters.AddWithValue("@MeghdareErsalShode", 0)
                Cmnd.Parameters.AddWithValue("@MeghdareErsali", Ds.Tables(0).Rows(i).Item("MeghdareMasrafVahed"))
                Cmnd.Parameters.AddWithValue("@UserID_Name", UserID_Name)
                Cmnd.Parameters.AddWithValue("@Host_Name", System.Environment.MachineName)
                Cmnd.Parameters.AddWithValue("@RecChksum", System.DBNull.Value)
                Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)

                Cmnd.Connection = mcn
                Cmnd.CommandType = CommandType.StoredProcedure
                Cmnd.CommandTimeout = mcn.ConnectionTimeout
                j = Cmnd.ExecuteNonQuery()

                If j <= 0 Then
                    MsgBox("اشکال در ثبت اقلام درخواست کالا از انبار" + vbCrLf + " کالا: " + _KalaNO)
                End If

            Catch ex As System.Exception
                MsgBox("اشکال در ثبت اقلام درخواست کالا از انبار" + vbCrLf + " کالا: " + _KalaNO)
            End Try
        Next

    End Sub

    Public Function GetMojoodikalaphiziki(ByVal VahedetejariSn As Decimal, ByVal AnbarSn As Decimal, ByVal KalaSn As Decimal, ByVal fdate As String, ByVal tdate As String, cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetMojoodikalaphiziki
        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim ds As New DataSet
        Try
            'Dim _Cstr As String = "Select  kalasn,kalaphizikiSn,Sum(isnull(Meghdarevaredeh,0))-Sum(Isnull(MeghdareSadereh,0)) Mojoodi from absanad " & _
            '"Inner join absanadha on absanad.sanadsn=absanadha.sanadsn Where (sanaddate between '" & fdate & "' and '" & tdate & "') And " & _
            '" AnbarSn = " & AnbarSn & " And Vahedetejarisn=" & VahedetejariSn & " and (" & KalaSn & "=0 Or KalaSN=" & KalaSn & ")" & _
            '" group by kalasn,kalaphizikiSn  Having(Sum(Meghdarevaredeh) - Sum(MeghdareSadereh) > 0) order by kalasn asc,mojoodi desc"

            Cmnd.CommandText = "_abSPG_GetMojoodiKalaPhiziki_Anbargardani"
            Cmnd.Parameters.AddWithValue("@VahedetejariSn0", VahedetejariSn)
            Cmnd.Parameters.AddWithValue("@AnbarSN0", AnbarSn)
            Cmnd.Parameters.AddWithValue("@KalaSN0", KalaSn)
            Cmnd.Parameters.AddWithValue("@FDate0", fdate)
            Cmnd.Parameters.AddWithValue("@TDate0", tdate)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)

            Return ds.Tables(0).DefaultView

        Catch ex As System.Exception
            Throw New System.Exception("اشکال در دریافت اطلاعات موجودی کالا ها ")
        Finally
            mcn.Close()
        End Try
    End Function

    Public Function IsTarakoneshInTarakoneshGorooh(ByVal _TarakoneshGorooh As Int16, ByVal _TarakoneshSN As Int16, cn As NetSql.DB.CConnection) As Boolean _
        Implements IClsDataAccess.IsTarakoneshInTarakoneshGorooh
        ''''' developed by ghafari 911028
        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim ds As New DataSet
        Try
            Dim _Cstr As String = "Select TarakoneshSN From abTarakoneshGorooh" &
            " left join abTarakoneshGoroohHa on abTarakoneshGorooh.TarakoneshGoroohSN = abTarakoneshGoroohHa.TarakoneshGoroohSN" &
            " Where abTarakoneshGorooh.TarakoneshGoroohSN =" & _TarakoneshGorooh & " And tarakoneshsn =" & _TarakoneshSN

            Cmnd.CommandText = _Cstr
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As System.Exception
            Throw New System.Exception("اشکال در دریافت اطلاعات گروه تراکنش ها ")
        Finally
            mcn.Close()
        End Try

    End Function


    'Edited by AliAsghar Tavakoli
    Public Function ExistKalaInasnadButNotInabAnbarKala(ByVal _AnbarSn As Decimal, ByVal _FromDate As String, ByVal _ToDate As String, cn As NetSql.DB.CConnection) As (String, DataTable) _
    Implements IClsDataAccess.ExistKalaInasnadButNotInabAnbarKala
        ''''' developed by ghafari 911102
        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim ds As New DataSet
        Try

            Cmnd.CommandText = "abSpc_GetKalaInAsnadButThatsNotInAnbarKala"
            Cmnd.Parameters.AddWithValue("@Anbarsn", _AnbarSn)
            Cmnd.Parameters.AddWithValue("@FromDate", _FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", _ToDate)
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Connection = mcn
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim kaladss As String = ""
                For index = 0 To ds.Tables(0).Rows.Count - 1
                    If (index >= 10) Then
                        Exit For
                    End If
                    kaladss = kaladss & vbCrLf & ds.Tables(0).Rows(index).Item("KalaDS").ToString
                Next
                If (ds.Tables(0).Rows.Count > 10) Then
                    Return (kaladss, ds.Tables(0))
                Else
                    Return (kaladss, Nothing)
                End If
            Else
                Return ("", Nothing)
            End If

        Catch ex As System.Exception
            Throw New System.Exception("اشکال در کنترل وجود تمام کالاهای گردش دار در انبار ")
        Finally
            mcn.Close()
        End Try

    End Function
    '' Made by AliAsghar Tavakoli
    Function GetExcelKalaNotInAnbar(ByVal table As DataTable, ByVal FolderPath As String)
        Try
            Dim xlApp As New Excel.Application
            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets("sheet1"), Excel.Worksheet)

            For index = 0 To table.Rows.Count - 1
                xlWorksheet.Cells(index + 1, 1) = table.Rows(index)("KALADS")
            Next
            Dim path = FolderPath & "\" & "Kala.xlsx"
            If (File.Exists(path)) Then
                Dim rand As Random = New Random()
                path = FolderPath & "\Kala_" & rand.Next(10, 1000) & ".xlsx"
            End If
            xlWorksheet.SaveAs(path)
            xlWorkbook.Close()
            xlApp.Quit()
            xlApp.Application.Quit()
            xlApp = Nothing
            xlWorkbook = Nothing
            xlWorksheet = Nothing
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("اشکال در ذخیره فایل")
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try


    End Function

    Public Function GetMojoodiWithEnghezaDate(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
    Implements IClsDataAccess.GetMojoodiWithEnghezaDate

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_GetKalahaMojoodiEnghezaDate"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ShoabSN", vVahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@NoeTaminKonandehSN", NoeTaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@NoeMahsoolSN", NoeMahsoolSN)
            Cmnd.Parameters.AddWithValue("@IsRooz", _IsRooz)
            Cmnd.Parameters.AddWithValue("@TRooz", _TRooz)
            Cmnd.Parameters.AddWithValue("@TaEnghezaDate", TaEnghezaDate)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        ''''Dim DT As New DataTable
        ''''Dim objresult As DataSet

        ''''Using client As New MiddlewareHelper(cn.SQLServerName, gSM.ServiceUserID, gSM.ServiceUserPassword)

        ''''    Dim Body As ServiceRequestBody = client.Add(False, "ASP", "Minoo.Services.Anbar/AnbarWebService.svc", "GetMojoodiWithEnghezaDate", VahedeTejariSN, vVahedeTejariSN, TaminKonandehSN, NoeTaminKonandehSN, KalaSN, NoeMahsoolSN, _IsRooz, _TRooz, TaEnghezaDate)

        ''''    Try
        ''''        client.Transmit()

        ''''        Dim Result As String = Body.ServiceResult  '''  خروجی sp

        ''''        objresult = New DataSet
        ''''        objresult.FromXml(Result)

        ''''        If objresult Is Nothing OrElse objresult.Tables.Count = 0 Then
        ''''            NetSql.Common.CSystem.MsgBox("خطای سرویس هنگام دریافت اطلاعات گزارش : " + vbCrLf + Result)
        ''''        End If

        ''''        If objresult.Tables.Count <> 0 Then
        ''''            Return objresult.Tables(0).DefaultView
        ''''        Else
        ''''            Return Nothing
        ''''        End If

        ''''    Catch ex As Exception
        ''''        NetSql.Common.CSystem.MsgBox("خطای سرویس هنگام دریافت اطلاعات گزارش" + ex.Message)
        ''''    End Try

        ''''End Using

    End Function

    Public Function GetMojoodiWithEnghezaDate_Tarakonesh(VahedeTejariSN As Decimal, vVahedeTejariSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _IsRooz As Integer, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
    Implements IClsDataAccess.GetMojoodiWithEnghezaDate_Tarakonesh

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_GetKalahaMojoodiEnghezaDate_Tarakonesh"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ShoabSN", vVahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@NoeTaminKonandehSN", NoeTaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@NoeMahsoolSN", NoeMahsoolSN)
            Cmnd.Parameters.AddWithValue("@IsRooz", _IsRooz)
            Cmnd.Parameters.AddWithValue("@TRooz", _TRooz)
            Cmnd.Parameters.AddWithValue("@TaEnghezaDate", TaEnghezaDate)
            Cmnd.Parameters.AddWithValue("@TarakoneshSN", TarakoneshSN)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function

    'Add yekta 970226
    Public Function GetVaredehMojaz(VahedeTejariSN As Decimal, KalaSN As String, FromDate As String, ToDate As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
Implements IClsDataAccess.GetVaredehMojaz

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_VaredehMojaz"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@FDate", FromDate)
            Cmnd.Parameters.AddWithValue("@TDate", ToDate)
            Cmnd.Parameters.AddWithValue("@StrKalaSN", KalaSN)


            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function
    Public Function GetMojoodiAndEnghezaDate(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, NoeTaminKonandehSN As String, KalaSN As String, NoeMahsoolSN As String, _TRooz As Integer, TaEnghezaDate As String, TarakoneshSN As String, _IsRooz As Integer, _Type As Integer, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
Implements IClsDataAccess.GetMojoodiAndEnghezaDate

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_GetMojoodiAndEnghezaDate"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", vAnbarSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@NoeTaminKonandehSN", NoeTaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@NoeMahsoolSN", NoeMahsoolSN)
            Cmnd.Parameters.AddWithValue("@TRooz", _TRooz)
            Cmnd.Parameters.AddWithValue("@TaEnghezaDate", TaEnghezaDate)
            Cmnd.Parameters.AddWithValue("@TarakoneshSN", TarakoneshSN)
            Cmnd.Parameters.AddWithValue("@IsRooz", _IsRooz)
            Cmnd.Parameters.AddWithValue("@Type", _Type)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function
    ' add by Yekta 920913
    Public Function GetQCIntervals(VahedeTejariSN As Decimal, vAnbarSN As String, TaminKonandehSN As String, KalaSN As String, FVoroodDate As String, TVoroodDate As String, LastNoeTarakoneshkalano As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
    Implements IClsDataAccess.GetQCIntervals

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_GetQCIntervals"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", vAnbarSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@FVoroodDate", FVoroodDate)
            Cmnd.Parameters.AddWithValue("@TVoroodDate", TVoroodDate)
            Cmnd.Parameters.AddWithValue("@LastNoeTarakoneshkalano", LastNoeTarakoneshkalano)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function
    ' Add by yekta 920616
    Public Function GetGozareshKardexKalaphiziki(FromDate As String, ToDate As String, AnbarSN As Decimal, VahedeTejariSN As Decimal, KalaSN As Decimal, ShomarehRahgiri As String, SanadStatus As String, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As DataView _
Implements IClsDataAccess.GetGozareshKardexKalaphiziki

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_KardexKalaPhiziki"
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate ", ToDate)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@Shomarehrahgiri", ShomarehRahgiri)
            Cmnd.Parameters.AddWithValue("@SanadStatus", SanadStatus)


            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

        '''''''''''''''''''' Direct Connection ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Function

    'Add by Dehghani 930423
    Public Function ReadFieldsProperties(TarakoneshSN As Integer, anbarSN As Decimal, VahedTejariSn As Decimal, cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.ReadFieldsProperties

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        Dim StrTarakonesh As String =
            "Select ObjectDS,Visible,Enable from abVw_abSanadObjectDetail " &
            " Where TarakoneshSN = " & TarakoneshSN & " And " &
            " (AnbarSN = " & anbarSN & " Or AnbarSN Is Null ) And " &
            " (VahedeTejariSN = " & VahedTejariSn & " Or VahedeTejariSN Is Null )"


        _Cstr = cn.ConnectionString + "; password=" & cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = StrTarakonesh
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.Text
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    Public Sub InsertKalaSahmInDatabase(KalaSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String) Implements IClsDataAccess.InsertKalaSahmInDatabase

        Dim j As Integer


        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Try
            Dim Cmnd As New SqlCommand
            Cmnd.CommandText = "abKalaSahm_Insert"
            Cmnd.Parameters.AddWithValue("@KalaSahmSN", cn.Identifier)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@UnqStr", "")
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserID_Name)
            Cmnd.Parameters.AddWithValue("@Host_Name", System.Environment.MachineName)
            Cmnd.Parameters.AddWithValue("@RecChksum", System.DBNull.Value)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            j = Cmnd.ExecuteNonQuery()

            If j <= 0 Then
                MsgBox("اشکال در ثبت  کالا" + vbCrLf + " کالا: ")
            End If

        Catch ex As System.Exception
            MsgBox("اشکال در ثبت  کالا" + vbCrLf + " کالا: ")
        End Try


    End Sub

    Public Sub DeleteKalaSahmInDatabase(KalaSahmSN As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String) Implements IClsDataAccess.DeleteKalaSahmInDatabase

        Dim j As Integer


        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If

        Try
            Dim Cmnd As New SqlCommand
            Cmnd.CommandText = "abKalaSahm_Delete"
            Cmnd.Parameters.AddWithValue("@KalaSahmSN", KalaSahmSN)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            j = Cmnd.ExecuteNonQuery()

            If j <= 0 Then
                MsgBox("اشکال در حذف  کالا" + vbCrLf + "وجود اطلاعات وابسته")
            End If

        Catch ex As System.Exception
            MsgBox("اشکال در حذف  کالا" + vbCrLf + "وجود اطلاعات وابسته")
        End Try


    End Sub

    Public Sub InsertKalaShoabSahmInDatabase(KalaSahmSN As Decimal, VahedeTejariSN As Decimal, Tarikh As String, Darsad As Decimal, cn As NetSql.DB.CConnection, UserID_Name As String) Implements IClsDataAccess.InsertKalaShoabSahmInDatabase
        Dim j As Integer
        Dim mcn As New SqlClient.SqlConnection

        If mcn.State = ConnectionState.Closed Then
            mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            mcn.Open()
        End If
        Try
            Dim Cmnd As New SqlCommand
            Cmnd.CommandText = "[_abKalaShoabSahm_Insertx]"
            Cmnd.Parameters.AddWithValue("@KalaShoabSahmSN", cn.Identifier)
            Cmnd.Parameters.AddWithValue("@KalaSahmSN", KalaSahmSN)
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@Tarikh", Tarikh)
            Cmnd.Parameters.AddWithValue("@Darsad", Darsad)
            Cmnd.Parameters.AddWithValue("@UnqStr", "")
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserID_Name)
            Cmnd.Parameters.AddWithValue("@Host_Name", System.Environment.MachineName)
            Cmnd.Parameters.AddWithValue("@RecChksum", System.DBNull.Value)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            j = Cmnd.ExecuteNonQuery()

            If j <= 0 Then
                MsgBox("اشکال در ثبت  شعب" + vbCrLf + " کالا: ")
            End If

        Catch ex As System.Exception
            MsgBox("اشکال در ثبت  شعب" + vbCrLf + " کالا: ")
        End Try

    End Sub

    Public Function GetDatasourceForPrintLabel(ByVal SanadHaSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetDatasourceForPrintLabel
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "qcSPG_PrintLabelForAnbar"
            Cmnd.Parameters.AddWithValue("SanadHaSN", SanadHaSn)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function GetDatasourceForPrintHavalehTolid(ByVal SanadSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetDatasourceForPrintHavalehTolid
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSPG_PrintHavalehTolid"
            Cmnd.Parameters.AddWithValue("SanadSN", SanadSn)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function GetTafkikByAnbar(ByVal Cn As NetSql.DB.CConnection, ByVal AnbarSN As Decimal) As DataSet Implements IClsDataAccess.GetTafkikByAnbar

        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSPG_GetTafkikByAnbar"
            Cmnd.Parameters.AddWithValue("AnbarSN", AnbarSN)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 Then
                Return dsdr
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function EnteghalMojoodiKalaPhiziki(ByVal Cn As NetSql.DB.CConnection, ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal,
                                               ByVal NoeanbarSN As Decimal, ByVal TarakoneshSNResid As Decimal, ByVal TarakoneshSNHavaleh As Decimal,
                                                ByVal KalaSN As Decimal, ByVal FromKalaPhizikiSN As Decimal, ByVal ToKalaPhizikiSN As Decimal,
                                               ByVal Meghdar As Decimal, ByVal Tozih As String,
                                               ByVal SelectRahgiriBySystem As Boolean, ByVal UserID_Name As String, ByVal Host_Name As String, ByVal UserID As Integer) _
                                               As String Implements IClsDataAccess.EnteghalMojoodiKalaPhiziki
        Dim _Cstr As String = ""
        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim i As Integer
        Dim _ErrMsg As String = ""
        Dim _SuccessMsg As String = ""
        Dim mcn As New SqlClient.SqlConnection

        Try

            _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSP_EnteghalMojoodiKalaPhiziki"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@NoeAnbarSN", NoeanbarSN)
            Cmnd.Parameters.AddWithValue("@TaraKoneShSNResid", TarakoneshSNResid)
            Cmnd.Parameters.AddWithValue("@TaraKoneShSNHavaleh", TarakoneshSNHavaleh)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@FromKalaPhizikiSN", FromKalaPhizikiSN)
            Cmnd.Parameters.AddWithValue("@ToKalaPhizikiSN", ToKalaPhizikiSN)
            Cmnd.Parameters.AddWithValue("@Meghdar", Meghdar)
            Cmnd.Parameters.AddWithValue("@Tozih", Tozih)
            Cmnd.Parameters.AddWithValue("@SelectRahgiriBySystem", SelectRahgiriBySystem)
            Cmnd.Parameters.AddWithValue("@Host_Name", Host_Name)
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserID_Name)
            Cmnd.Parameters.AddWithValue("@UserID", UserID)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)

            Dim parameter3 As New SqlClient.SqlParameter
            parameter3.ParameterName = "@SuccessMsg"
            parameter3.SqlDbType = SqlDbType.NVarChar
            parameter3.Size = 500
            parameter3.Direction = ParameterDirection.Output
            parameter3.SourceColumn = "SuccessMsg"
            Cmnd.Parameters.Add(parameter3)



            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            i = Cmnd.ExecuteNonQuery()

            _ErrMsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)
            _SuccessMsg = If(parameter3.Value Is Nothing OrElse parameter3.Value Is DBNull.Value, "", parameter3.Value)


        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        Finally
            mcn.Close()
            EnteghalMojoodiKalaPhiziki = If(_ErrMsg <> "", _ErrMsg, _SuccessMsg)
        End Try

    End Function

    Public Function BayganiDarkhastTafkikShode(ByVal Cn As NetSql.DB.CConnection, ByVal DarKhastSN As Decimal) As String Implements IClsDataAccess.BayganiDarkhastTafkikShode
        BayganiDarkhastTafkikShode = ""
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSPC_BayganiDarkhastTafkikShodeh"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.Parameters.AddWithValue("@DarKhastSN", DarKhastSN)
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.ExecuteNonQuery()
            BayganiDarkhastTafkikShode = "SUCCESS"
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function GetRptMoghyeratEstandardMaliVaAnbar(ByVal Shobe As String, ByVal Tarakonesh As String, ByVal Fromdate As String, ByVal Todate As String,
                                                        ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetRptMoghyeratEstandardMaliVaAnbar
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSPR_MoghyeratSanadEstandardMaliVaAnbar"
            Cmnd.Parameters.AddWithValue("@vahedetejariSn", Shobe)
            Cmnd.Parameters.AddWithValue("@TarakoneshSN", Tarakonesh)
            Cmnd.Parameters.AddWithValue("@AsDate", Fromdate)
            Cmnd.Parameters.AddWithValue("@TaDate", Todate)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count >= 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function GetMojoudiKalaHayeDaftarForoosh(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal NoeAnbarSN As Decimal, ByVal KalaSN As String, ByVal DafTarSn As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetMojoudiKalaHayeDaftarForoosh
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSPG_GetMojoudiKalaHayeDaftarForoosh"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@NoeAnbarSN", NoeAnbarSN)
            Cmnd.Parameters.AddWithValue("@DaftarForooshSN", DafTarSn)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function KartablZayeat_TaeedDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                              NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.KartablZayeat_TaeedDarkhast
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"

        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.CommandText = "_abSpC_ZayeatGardesh_TaeedDarkhast"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserId_Name", UserIdName)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Cmnd.Parameters.AddWithValue("@NoeDarjNerkh", NoeDarjNerkh)





            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.ExecuteNonQuery()

            _ErrMsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function KartablZayeat_TaeedDarkhast_xml(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshXML As String,
                                              NoeDarjNerkh As Integer, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.KartablZayeat_TaeedDarkhast_xml
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.CommandText = "_abSpC_ZayeatGardesh_TaeedDarkhast_xml"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshXML", ZayeatGardeshXML)
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserId_Name", UserIdName)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)
            Cmnd.Parameters.AddWithValue("@NoeDarjNerkh", NoeDarjNerkh)


            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.ExecuteNonQuery()

            _ErrMsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function KartablZayeat_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                              ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.KartablZayeat_EbtalDarkhast
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.CommandText = "_abSpC_ZayeatGardesh_EbtalDarkhast"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserId_Name", UserIdName)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)



            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.ExecuteNonQuery()

            _ErrMsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function KartablZayeat_EbtalRadif(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal ZayeatGardeshSN As Decimal,
                                             ByVal ZayeatGardeshHaSN As Decimal, ByVal UserId As Integer, ByVal UserIdName As String,
                                             ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.KartablZayeat_EbtalRadif
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.CommandText = "_abSpC_ZayeatGardesh_EbtalRadif"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshHaSN", ZayeatGardeshHaSN)
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserId_Name", UserIdName)


            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)




            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.ExecuteNonQuery()

            _ErrMsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function KartablZayeat_ReportRavandErja(ByVal ZayeatGardeshSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.KartablZayeat_ReportRavandErja
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpR_ZayeatGardesh_RavandErja"
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function

    Public Function KartablZayeat_GetMaster(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.KartablZayeat_GetMaster
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSPG_GetZayeatGardeshKartabl_Master"
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@Fdate", Fdate)
            Cmnd.Parameters.AddWithValue("@Tdate", Tdate)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات Master کارتابل " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function

    Public Function KartablZayeat_GetDetail(ByVal UserId As Integer, ByVal Fdate As String, ByVal Tdate As String, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.KartablZayeat_GetDetail
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSPG_GetZayeatGardeshKartabl_Detail"
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@Fdate", Fdate)
            Cmnd.Parameters.AddWithValue("@Tdate", Tdate)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات Detail کارتابل " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function

    Public Function KartablZayeat_GetNerKhSanadZayeat(ByVal ZayeatGardeshSN As String, ByVal NerkhType As Short, ByVal AccessForDarjNerkh As Boolean, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.KartablZayeat_GetNerKhSanadZayeat
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpR_ZayeatGardesh_GetNerkhSanad"
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Parameters.AddWithValue("@NerkhType", NerkhType)
            Cmnd.Parameters.AddWithValue("@AccessForDarjNerkh", AccessForDarjNerkh)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
                Return dsdr.Tables(0).DefaultView
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function

    Public Function KartablZayeat_GetReport(ByVal VahedeTejariSN As String, ByVal FromDate As String, ByVal ToDate As String, ByVal ZayeatGardeshSN As String,
                                            ByVal TaminKonandehSN As String, ByVal KalaSN As String, ByVal ReportType As Short,
                                            ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.KartablZayeat_GetReport
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; Server=ASP;DataBase=GOD;User ID=ServiceAnbar;password=1"

        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpR_ZayeatGardesh_GetReport"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@ZayeatGardeshSN", ZayeatGardeshSN)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandehSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@ReportType", ReportType)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            'If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
            Return dsdr.Tables(0).DefaultView
            'End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    ''ghasemi
    Public Function MoghayratAvaldoreVaPayandore_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal Kala1Rahgiri0 As Boolean,
                                                           ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.MoghayratAvaldoreVaPayandore_GetReport
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "_abSpr_RptMoghayratAvaldoreVaPayandore "
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@Kala1Rahgiri0", Kala1Rahgiri0)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr.Tables(0).DefaultView
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function
    ''ghasemi

    Public Function GetBarcodeScannerDataFromMainServer(ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.GetBarcodeScannerDataFromMainServer
        Dim _Cstr As String = ""
        Dim errmsg As String = ""
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = "Server=BSDDB;DataBase=ServiceCatalog_DB;User ID=mrs_dts;password=dtsofmrs;Integrated Security = SSPI;"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "SSIS_ExecutePackage"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)

            Try
                errmsg = Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try

            errmsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return errmsg

        Catch ex As System.Exception
            Throw ex
        Finally
            mcn.Close()
        End Try


    End Function

    Public Sub GetLastProductCatalogue(ByVal Cn As NetSql.DB.CConnection, ByVal UserName As String, ByVal HostName As String) Implements IClsDataAccess.GetLastProductCatalogue
        Dim dsdr As New DataSet
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection

        Dim _Cstr As String = ""

        Dim ProductCatalogueSN As Decimal
        Dim ProductCatalogueKalaIRcSN As Decimal

        ProductCatalogueSN = CDec(Cn.ExecuteQuery("Select  max(ProductCatalogueSN) from abProductCatalogue")(0)(0))
        ProductCatalogueKalaIRcSN = CDec(Cn.ExecuteQuery("Select  max(ProductCatalogueNewIRCSN) from abProductCatalogueKalaIRC")(0)(0))

        Try
            dsdr = GetLastProductCatalogue_BIS(Cn, ProductCatalogueSN, ProductCatalogueKalaIRcSN, UserName, HostName)
        Catch ex As System.Exception
            Throw New System.Exception("خطا در ساخت دیتاست GBID " + vbCrLf + ex.ToString)
        End Try

        If dsdr IsNot Nothing Then
            If dsdr.Tables.Count = 3 Then
                dsdr.Tables(0).TableName = "ProductCatalogue"
                dsdr.Tables(1).TableName = "ProductCatalogueDetail"
                dsdr.Tables(2).TableName = "ProductCatalogueKalaIRC"

                For Each col As DataColumn In dsdr.Tables(0).Columns
                    If col.DataType = System.Type.GetType("System.DateTime") Then
                        col.DateTimeMode = DataSetDateTime.Unspecified
                    End If
                Next

                Dim XmlCatalogue As String = dsdr.GetXml


                _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
                Try
                    mcn.ConnectionString = _Cstr

                    If mcn.State = ConnectionState.Closed Then
                        mcn.Open()
                    End If

                    Cmnd.CommandText = "abSpC_InsertProductCatalogueTablesByLastID_XML"
                    Cmnd.Connection = mcn
                    Cmnd.CommandType = CommandType.StoredProcedure
                    Cmnd.Parameters.AddWithValue("@CatalogueXML", XmlCatalogue)
                    Cmnd.CommandTimeout = mcn.ConnectionTimeout
                    Try
                        Cmnd.ExecuteNonQuery()
                    Catch ex As Exception
                        Throw ex
                    End Try
                Catch ex As System.Exception
                    Throw New System.Exception("خطا در درج XML اطلاعات " + vbCrLf + ex.ToString)
                Finally
                    mcn.Close()
                End Try



            End If
        End If


    End Sub

    Public Function GetLastProductCatalogue_BIS(ByVal Cn As NetSql.DB.CConnection, ByVal ProductCatalogueSN As Decimal, ByVal ProductCatalogueKalaIRcSN As Decimal, ByVal UserName As String, ByVal HostName As String) As DataSet Implements IClsDataAccess.GetLastProductCatalogue_BIS
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; Server=BIS;DataBase=GBID;User ID=ServiceAnbar;password=1"

        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpG_GetLastProductCatalogue"
            Cmnd.Parameters.AddWithValue("@LastProductCatalogueSN", ProductCatalogueSN)
            Cmnd.Parameters.AddWithValue("@LastProductCatalogueKalaIRcSN", ProductCatalogueKalaIRcSN)
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserName)
            Cmnd.Parameters.AddWithValue("@HostName", HostName)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function

    Public Function GetLastProductCatalogue_STD(ByVal Cn As NetSql.DB.CConnection, ByVal ProductCatalogueSN As Decimal, ByVal ProductCatalogueKalaIRcSN As Decimal, ByVal UserName As String, ByVal HostName As String) As DataSet Implements IClsDataAccess.GetLastProductCatalogue_STD
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + ";Server=STD;DataBase=MIS;User ID=ServiceAnbar;password=1;"

        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpG_GetLastProductCatalogue"
            Cmnd.Parameters.AddWithValue("@LastProductCatalogueSN", ProductCatalogueSN)
            Cmnd.Parameters.AddWithValue("@LastProductCatalogueKalaIRcSN", ProductCatalogueKalaIRcSN)
            Cmnd.Parameters.AddWithValue("@UserID_Name", UserName)
            Cmnd.Parameters.AddWithValue("@HostName", HostName)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Function
    '------------Tavakoli------------------
    Public Function GetBarcodeThatsNotHaveProduct(ByVal Cn As NetSql.DB.CConnection _
                                                  , ByVal Sp As String)
        Dim _Cstr As String = ""
        'Dim _Errmsg As String = ""
        Dim SqlCommand As New SqlCommand
        Dim SqlConn As New SqlClient.SqlConnection
        Dim SqlAdaptor As New SqlDataAdapter
        Dim dataSet As New DataSet



        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            SqlConn.ConnectionString = _Cstr

            If SqlConn.State = ConnectionState.Closed Then
                SqlConn.Open()
            End If

            SqlCommand.CommandText = Sp
            SqlCommand.Connection = SqlConn
            SqlCommand.CommandType = CommandType.StoredProcedure
            SqlCommand.CommandTimeout = SqlConn.ConnectionTimeout
            SqlAdaptor.SelectCommand = SqlCommand
            SqlAdaptor.Fill(dataSet)

            Return dataSet.Tables(0).AsDataView()

        Catch ex As Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            SqlConn.Close()
        End Try
    End Function
    Public Function GetBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal Fromdate As String, ByVal Todate As String, ByVal State As Integer,
                                                    ByVal Cn As NetSql.DB.CConnection, Optional ByVal SpName As String = "abSPG_ProductCatalogueGetData") As DataSet Implements IClsDataAccess.GetBarcodeScannerData
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = SpName
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@FromDate", Fromdate)
            Cmnd.Parameters.AddWithValue("@ToDate", Todate)
            Cmnd.Parameters.AddWithValue("@State", State)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            If dsdr.Tables.Count = 3 Then
                Return dsdr
            End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function SabteSanadByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal,
                                                   ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.SabteSanadByBarcodeScannerData
        Dim _Cstr As String = ""
        Dim _Errmsg As String = ""
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpC_InsertSanad_ProductCatalogue"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@ProductCatalogueXml", XmlStr).DbType = DbType.Xml
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserName", UserName)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout

            Try
                Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try

            _Errmsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _Errmsg


        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Public Function SabteSanadKasriEzafiByBarcodeScannerData(ByVal VahedeTejariSN As Decimal, ByVal AnbarSN As Decimal, ByVal XmlStr As String, ByVal UserId As Decimal,
                                                   ByVal UserName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.SabteSanadKasriEzafiByBarcodeScannerData
        Dim _Cstr As String = ""
        Dim _Errmsg As String = ""
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpC_InsertSanadKasriEzafi_ProductCatalogue"
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", VahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@ProductCatalogueXml", XmlStr).DbType = DbType.Xml
            Cmnd.Parameters.AddWithValue("@UserId", UserId)
            Cmnd.Parameters.AddWithValue("@UserName", UserName)

            Dim parameter2 As New SqlClient.SqlParameter
            parameter2.ParameterName = "@ErrMsg"
            parameter2.SqlDbType = SqlDbType.NVarChar
            parameter2.Size = 500
            parameter2.Direction = ParameterDirection.Output
            parameter2.SourceColumn = "ErrMsg"
            Cmnd.Parameters.Add(parameter2)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout

            Try
                Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try

            _Errmsg = If(parameter2.Value Is Nothing OrElse parameter2.Value Is DBNull.Value, "", parameter2.Value)

            Return _Errmsg


        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try


    End Function

    Function GetListTaminKonandegan(ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.GetListTaminKonandegan
        Dim sda As New SqlDataAdapter
        Dim ds As New DataSet
        Dim Cmnd As New SqlCommand

        Try
            Cmnd.CommandText = "btSpG_GetListTaminKonandegan"
            Cmnd.Connection = Cn.Connection
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = Cn.CommandTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0).DefaultView
            End If
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        Finally

        End Try
        Return ds.Tables(0).DefaultView
    End Function

    ''ghasemi14010512
    Public Function FaseleDarkhastTaHavaleh_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal TaminKonandeSn As String, ByVal KalaSN As String, ByVal VahedetejariSN As Decimal, ByVal gAnbarSN As Decimal,
                                                           ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.FaseleDarkhastTaHavaleh_GetReport
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpR_TimeIntervalDarkhastTaHavaleh"
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminKonandeSn)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@VahedetejariSN", VahedetejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", gAnbarSN)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr.Tables(0).DefaultView
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function
    ''ghasemi14010512

    ''ghasemi14021010    
    Public Function RptDarkhastRepair_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AmvalSN As String, ByVal VahedetejariSN As String, ByVal StatusSN As String,
                                                           ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.RptDarkhastRepair_GetReport
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpR_RptDarkhastRepair"
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@AmvalSN", AmvalSN)
            Cmnd.Parameters.AddWithValue("@VahedetejariSN", VahedetejariSN)
            Cmnd.Parameters.AddWithValue("@StatusSN", StatusSN)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr.Tables(0).DefaultView
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    Public Function RptPriodicService_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AmvalSN As String, ByVal VahedetejariSN As String, ByVal StatusSN As String,
                                                           ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.RptPriodicService_GetReport
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpR_RptPriodicService"
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@AmvalSN", AmvalSN)
            Cmnd.Parameters.AddWithValue("@VahedetejariSN", VahedetejariSN)
            Cmnd.Parameters.AddWithValue("@StatusSN", StatusSN)

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr.Tables(0).DefaultView
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function
    ''ghasemi14021010



    Function RptUIDtracking(ByVal TaminSN As Decimal, ByVal KalaSN As Decimal, ByVal KalaPhizikiSN As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.RptUIDtracking
        Dim _Cstr As String = ""
        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection

        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpR_ProductCatalogue_UIDtracking"
            Cmnd.Parameters.AddWithValue("@TaminKonandehSN", TaminSN)
            Cmnd.Parameters.AddWithValue("@KalaSN", KalaSN)
            Cmnd.Parameters.AddWithValue("@KalaPhizikiSN", KalaPhizikiSN)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            Return dsdr.Tables(0).DefaultView
        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    Public Function RptAdamRayatOlaviatBandiTarikhEngheza(FromDate As String, ToDate As String, VahedeTejariSN As String, TarakoneshSN As String, TaminKonandehSN As String, KalaSN As String, ByVal Cn As NetSql.DB.CConnection) As DataSet Implements IClsDataAccess.RptAdamRayatOlaviatBandiTarikhEngheza

        Dim Cmnd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim dataSet As New DataSet
        Dim _cn As New SqlClient.SqlConnection
        Dim _Cstr As String = ""
        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        _cn.ConnectionString = _Cstr

        Cmnd.CommandText = "abSpC_ControlTarikhEnghezaInSodoorHavaleh"
        Cmnd.CommandType = CommandType.StoredProcedure
        Cmnd.Connection = Cn.Connection
        Cmnd.CommandTimeout = Cn.CommandTimeout
        Cmnd.Parameters.AddWithValue("FromDate", FromDate)
        Cmnd.Parameters.AddWithValue("Todate", ToDate)
        Cmnd.Parameters.AddWithValue("VahedeTejariSN", VahedeTejariSN)
        Cmnd.Parameters.AddWithValue("TarakoneshSN", TarakoneshSN)
        Cmnd.Parameters.AddWithValue("TaminKonandehSN", TaminKonandehSN)
        Cmnd.Parameters.AddWithValue("KalaSN", KalaSN)
        da.SelectCommand = Cmnd
        Try
            If _cn.State = ConnectionState.Closed Then
                _cn.Open()
            End If
            da.Fill(dataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا")
        Finally
            If _cn.State = ConnectionState.Open Then
                _cn.Close()
            End If
        End Try
        Return dataSet
    End Function

    Public Sub EbtalSabtBarcodeReader(ByVal CatalogueSN_Str As String, ByVal Cn As NetSql.DB.CConnection) Implements IClsDataAccess.EbtalSabtBarcodeReader
        Dim _Cstr As String = ""
        Dim _Errmsg As String = ""
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection


        Try
            Cn.ExecuteNoneQuery("update abProductCatalogue set Status=3,TransferToAnbarTime=dbo.JalaliNowDateTime() where ProductCatalogueSN in (" & CatalogueSN_Str & ")")


        Catch ex As Exception
            Throw New System.Exception("خطا در ابطال ثبت " + vbCrLf + ex.ToString)
            Exit Sub
        End Try


        'Try
        '    _Cstr = Cn.ConnectionString + "; Server=BIS;DataBase=GBID;User ID=ServiceAnbar;password=1"
        '    mcn.ConnectionString = _Cstr

        '    If mcn.State = ConnectionState.Closed Then
        '        mcn.Open()
        '    End If

        '    Cmnd.CommandText = "update abProductCatalogue set Status=3,TransferToAnbarTime=dbo.JalaliNowDateTime() where ProductCatalogueSN in (" & CatalogueSN_Str & ")"
        '    Cmnd.Connection = mcn
        '    Cmnd.CommandType = CommandType.Text
        '    Cmnd.CommandTimeout = mcn.ConnectionTimeout

        '    Try
        '        Cmnd.ExecuteNonQuery()
        '    Catch ex As Exception
        '        Throw ex
        '    End Try

        'Catch ex As System.Exception
        '    Throw New System.Exception("خطا در ابطال ثبت BIS.GBID" + vbCrLf + ex.ToString)
        'Finally
        '    mcn.Close()
        'End Try



    End Sub

    Public Sub SyncProductCatalogueData_ShoabToGBID(ByVal Xmlstr As String, ByVal Cn As NetSql.DB.CConnection) Implements IClsDataAccess.SyncProductCatalogueData_ShoabToGBID
        Dim _Cstr As String = ""
        Dim Cmnd As New SqlCommand
        Dim mcn As New SqlClient.SqlConnection


        Try
            _Cstr = Cn.ConnectionString + "; Server=BIS;DataBase=GBID;User ID=ServiceAnbar;password=1"
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpC_UpdateProductCatalogueDataOnGBID"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.Parameters.AddWithValue("@ProductCatalogueXml", Xmlstr).DbType = DbType.Xml

            Try
                Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As System.Exception
            Throw New System.Exception("خطا در بروزرسانی داده های بارکدخوان  BIS.GBID" + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try



    End Sub

    Public Function DarkhastRepair_NahayeeDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                                   ByVal DarkhastRepairSN As Decimal,
                                                   ByVal DarkhastRepairTozih As String,
                                                   ByVal dvDarkhastRepairAccessories As DataView,
                                                    dvDarkhastRepairOperator As DataView, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.DarkhastRepair_NahayeeDarkhast
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.CommandText = "ctDarkhastRepairAccessories_InsertX"
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout

            Cmnd.Parameters.Clear()

            For Each Rowv As DataRowView In dvDarkhastRepairAccessories
                Cmnd.Parameters.Clear()
                Cmnd.Parameters.AddWithValue("@DarkhastRepairAccessoriesSN", Rowv("DarkhastRepairAccessoriesSN"))
                Cmnd.Parameters.AddWithValue("@DarkhastRepairSN", Rowv("DarkhastRepairSN"))
                Cmnd.Parameters.AddWithValue("@KalaSN", Rowv("KalaSN"))
                Cmnd.Parameters.AddWithValue("@VahedeSanjeshSN", Rowv("VahedeSanjeshSN"))
                Cmnd.Parameters.AddWithValue("@Meghdar", Rowv("Meghdar"))
                Cmnd.Parameters.AddWithValue("@Status", Rowv("Status"))
                Cmnd.Parameters.AddWithValue("@SabtDate", Rowv("SabtDate"))
                Cmnd.Parameters.AddWithValue("@Rez3", Rowv("Rez3"))
                Cmnd.Parameters.AddWithValue("@UserID_Name", Rowv("UserID_Name"))
                Cmnd.Parameters.AddWithValue("@Host_Name", Rowv("Host_Name"))
                Cmnd.Parameters.AddWithValue("@RecChksum", Rowv("RecChksum"))
                Cmnd.Parameters.AddWithValue("@Cost", Rowv("Cost"))
                Cmnd.Parameters.AddWithValue("@Tozih", Rowv("Tozih"))
                Cmnd.Parameters.AddWithValue("@GhateeKonandeh", Rowv("GhateeKonandeh"))
                Cmnd.Parameters.AddWithValue("@GhateeDate", Rowv("GhateeDate"))
                Cmnd.Parameters.AddWithValue("@Res2", Rowv("Res2"))


                Try
                    Cmnd.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New System.Exception(ex.Message + vbCrLf + "خطای درج لوازم مصرفی " + vbCrLf + "DarkhastRepairAccessoriesSN : " + Rowv("DarkhastRepairAccessoriesSN").ToString)
                End Try
            Next

            Cmnd.Parameters.Clear()

            Cmnd.CommandText = "ctDarkhastRepairOperator_InsertX"

            For Each Rowv As DataRowView In dvDarkhastRepairOperator
                Cmnd.Parameters.Clear()
                Cmnd.Parameters.AddWithValue("@DarkhastRepairOperatorSN", Rowv("DarkhastRepairOperatorSN"))
                Cmnd.Parameters.AddWithValue("@DarkhastRepairSN", Rowv("DarkhastRepairSN"))
                Cmnd.Parameters.AddWithValue("@OperatorSN", Rowv("OperatorSN"))
                Cmnd.Parameters.AddWithValue("@JobStopDate", Rowv("JobStopDate"))
                Cmnd.Parameters.AddWithValue("@JobStopTime", Rowv("JobStopTime"))
                Cmnd.Parameters.AddWithValue("@JobStartDate", Rowv("JobStartDate"))
                Cmnd.Parameters.AddWithValue("@JobStartTime", Rowv("JobStartTime"))
                Cmnd.Parameters.AddWithValue("@Tozih", Rowv("Tozih"))
                Cmnd.Parameters.AddWithValue("@Status", Rowv("Status"))
                Cmnd.Parameters.AddWithValue("@SabtDate", Rowv("SabtDate"))
                Cmnd.Parameters.AddWithValue("@Rez3", Rowv("Rez3"))
                Cmnd.Parameters.AddWithValue("@UserID_Name", Rowv("UserID_Name"))
                Cmnd.Parameters.AddWithValue("@Host_Name", Rowv("Host_Name"))
                Cmnd.Parameters.AddWithValue("@RecChksum", Rowv("RecChksum"))
                Cmnd.Parameters.AddWithValue("@UserID", Rowv("UserID"))
                Cmnd.Parameters.AddWithValue("@Cost", Rowv("Cost"))
                Cmnd.Parameters.AddWithValue("@GhateeKonandeh", Rowv("GhateeKonandeh"))
                Cmnd.Parameters.AddWithValue("@GhateeDate", Rowv("GhateeDate"))
                Cmnd.Parameters.AddWithValue("@Res2", Rowv("Res2"))
                Try
                    Cmnd.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New System.Exception(ex.Message + vbCrLf + "خطای درج نیروی انسانی " + vbCrLf + "DarkhastRepairOperatorSN : " + Rowv("DarkhastRepairOperatorSN").ToString)
                End Try
            Next

            Cmnd.Parameters.Clear()
            Cmnd.CommandText = "_ctSpG_ChangeDarkhastRepairStatus"
            Cmnd.Parameters.AddWithValue("@SN", DarkhastRepairSN)
            Cmnd.Parameters.AddWithValue("@ChangeState", "finish")
            Cmnd.Parameters.AddWithValue("@Tozih", DarkhastRepairTozih)
            Cmnd.Parameters.AddWithValue("@UserName", UserName)


            Try
                Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New System.Exception(ex.Message + vbCrLf + "خطای بروزرسانی وضعیت درخواست " + vbCrLf + "DarkhastRepairSN : " + DarkhastRepairSN.ToString)
            End Try

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    Public Function DarkhastRepair_EbtalDarkhast(ByVal VahedeTejariSN As Decimal, ServerName As String, DbName As String, ByVal UserName As String,
                                                   ByVal DarkhastRepairSN As Decimal,
                                                   ByVal DarkhastRepairTozih As String, ByVal UserId As Integer, ByVal UserIdName As String, ByVal Cn As NetSql.DB.CConnection) As String Implements IClsDataAccess.DarkhastRepair_EbtalDarkhast
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; Server=" & ServerName & ";DataBase=" & DbName & ";User ID=ServiceAnbar;password=1"
        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                Try
                    mcn.Open()
                Catch ex As Exception
                    Throw New System.Exception("خطا در ایجاد اتصال به سرور " + vbNewLine + ServerName + " : " + DbName + vbCrLf + ex.ToString)
                End Try

            End If

            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            Cmnd.CommandText = "_ctSpG_ChangeDarkhastRepairStatus"
            Cmnd.Parameters.AddWithValue("@SN", DarkhastRepairSN)
            Cmnd.Parameters.AddWithValue("@ChangeState", "Ebtal")
            Cmnd.Parameters.AddWithValue("@Tozih", DarkhastRepairTozih)
            Cmnd.Parameters.AddWithValue("@UserName", UserName)


            Try
                Cmnd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New System.Exception(ex.Message + vbCrLf + "خطای ابطال درخواست " + vbCrLf + "DarkhastRepairSN : " + DarkhastRepairSN.ToString)
            End Try

            Return _ErrMsg

        Catch ex As System.Exception
            Throw New System.Exception("خطا در انجام عملیات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    Public Function ReportAghlamTarikhNazdikeAsnadBarcodKhan(fromDate As String, toDate As String, vahedeTejariSns As String, taminKonande As String, kalaSns As String, ByVal roozTaEngheza As Integer, ByVal parameterClos As Decimal, ByVal Cn As NetSql.DB.CConnection) As DataTable Implements IClsDataAccess.ReportAghlamTarikhNazdikeAsnadBarcodKhan
        Dim Cmnd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter
        Dim dataSet As New DataSet
        Dim _cn As New SqlClient.SqlConnection
        Dim _Cstr As String = ""
        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword
        _cn.ConnectionString = _Cstr
        Cmnd.CommandText = "abSpR_ProductCatalogue_ListOfProductsCloseToExpire"
        Cmnd.CommandType = CommandType.StoredProcedure
        Cmnd.Connection = Cn.Connection
        Cmnd.CommandTimeout = Cn.CommandTimeout
        Cmnd.Parameters.AddWithValue("FromDate", fromDate)
        Cmnd.Parameters.AddWithValue("ToDate", toDate)
        Cmnd.Parameters.AddWithValue("VahedeTejariSN", vahedeTejariSns)
        Cmnd.Parameters.AddWithValue("TaminKonandehSN", taminKonande)
        Cmnd.Parameters.AddWithValue("KalaSN", kalaSns)
        Cmnd.Parameters.AddWithValue("CloseToExpireParamter", parameterClos)
        Cmnd.Parameters.AddWithValue("DayToExpire", roozTaEngheza)
        da.SelectCommand = Cmnd
        Try
            If _cn.State = ConnectionState.Closed Then
                _cn.Open()
            End If
            da.Fill(dataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا")

        Finally
            If _cn.State = ConnectionState.Open Then
                _cn.Close()

            End If
        End Try
        Return dataSet.Tables(0)
    End Function



    ''Add Form By Bagheri (HB) 14030618 _Begin
    Public Function MoghayesehSanadRialiMaliVaAnbar_GetReport(ByVal FromDate As String, ByVal ToDate As String, ByVal AnbarSN As String, ByVal TarakoneshSN As String, ByVal SanadNo As String,
                                                              ByVal Cn As NetSql.DB.CConnection) As DataView Implements IClsDataAccess.MoghayesehSanadRialiMaliVaAnbar_GetReport
        Dim _Cstr As String = ""
        Dim _ErrMsg As String = ""

        Dim sda As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsdr As New DataSet
        Dim mcn As New SqlClient.SqlConnection


        _Cstr = Cn.ConnectionString + "; password=" & Cn.SQLPassword

        Try
            mcn.ConnectionString = _Cstr

            If mcn.State = ConnectionState.Closed Then
                mcn.Open()
            End If

            Cmnd.CommandText = "abSpr_MoghayeseMaliVaAnbar"
            Cmnd.Parameters.AddWithValue("@FromDate", FromDate)
            Cmnd.Parameters.AddWithValue("@ToDate", ToDate)
            Cmnd.Parameters.AddWithValue("@AnbarSN", AnbarSN)
            Cmnd.Parameters.AddWithValue("@TarakoneshSN", TarakoneshSN)
            Cmnd.Parameters.AddWithValue("@SanadNo", SanadNo)
            Cmnd.Connection = mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = mcn.ConnectionTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(dsdr)

            'If dsdr.Tables.Count > 0 AndAlso dsdr.Tables(0).Rows.Count > 0 Then
            Return dsdr.Tables(0).DefaultView
            'End If

        Catch ex As System.Exception
            Throw New System.Exception("خطا در دریافت اطلاعات " + vbCrLf + ex.ToString)
        Finally
            mcn.Close()
        End Try

    End Function

    ''Add Form By Bagheri (HB) 14030618 _End


End Class

