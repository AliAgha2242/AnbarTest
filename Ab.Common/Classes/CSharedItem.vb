' DB OK 84/07/27
'  OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/06/1
'ModifiedDate::
'Description::  کلاس عمومي براي مؤلفه  عمومي سيستم انبار 
'System ::انبار
Public Class CSharedItem

  Friend mFrmUseChideman As New FrmFilterKalaChideman

  Public Shared gEnumButtonOptionsReports As Integer = EnumButtonOptions.boCmdFilter _
                          Or EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint _
                          Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdFind

  Public Shared gAnbarSelectForm As Minoo.Applications.Anbar.Common.FrmTreeSelectAnbar
  Public Shared gAnbarSelected As String

  '   متغييرهاي سراسري سال مالي
  Public Shared gSelectHesabdariSal As Minoo.Applications.Anbar.Common.frmSelectHesabdariSal
  Public Shared gHesabdariSal As Short
  Public Shared gHesabdariSalFDate As String
  Public Shared gHesabdariSalTDate As String
  Public Shared gHesabdariSalISClosed As Boolean

  '   متغييرهاي سراسري  انبار
  Public Shared gAnbarSN As Decimal ' کليد اصلي انبار جاري
  Public Shared gAnbarDS As String ' نام انبار جاري
  Public Shared gAnbarNO As Decimal ' شماره انبار جاري 
  Public Shared gNoeAnbarSN As Decimal '  کليد اصلي نوع انبار جاري
  Public Shared gVahedeTejariNO As Decimal '  کد واحد تجاري انبار
    Public Shared gNoeVoroodeAsnadSN As Decimal '  کليد اصلي نوع انبار جاري

    Public Shared IsVahedTejariTolidi As Boolean


    '1	كارت شناسايي
    '2	سري ساخت
    'Public Shared gKalaPhizikiStatusSN As Short  '  چگونگي رهگيري کالا در انبار

    'Public Shared gRahgiriAuto As Short ' آيا شماره رهگيري اتوماتيک ثبت گردد
    'Public Shared gRahgiriMeghdar As Integer '  در صورت اتوماتيک بودن مقدار آن چيست

    '1	تجميع
    '2	انبار
    '3	انبار پاي کار

    Public Shared gIsTajmie As Short

    Private mFilterSelectedChidemanSN As String

  Public ReadOnly Property FilterSelectedChidemanSN() As String
    Get
      FilterSelectedChidemanSN = mFilterSelectedChidemanSN
    End Get
  End Property

    Private mFilterWhereCondition As String

  Public ReadOnly Property FilterWhereCondition() As String
    Get
      FilterWhereCondition = mFilterWhereCondition
    End Get
  End Property

#Region " Anbar EnumTarakoneshSN "

    Public Enum EnumTarakoneshSN
        ' متناظر با تک تک تراکنشهاي انبار براي استفاده در برنامه 
        MOJOODIE_44_AVALE_DOREH = 44
        MOJOODIE_20_AVALE_DOREH_Paikar = 20

        RESIDE_01_KHARIDE_DAKHELI = 1
        RESIDE_02_KHARIDE_KHAREJI = 2
        RESIDE_03_AMANIE_DIGARAN_NAZDE_MA = 3
        RESIDE_04_BARGASHTE_AMANIE_MA_NAZDE_DIGARAN = 4
        RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR = 5

        RESIDE_06_EzafehDryaft = 6
        RESIDE_07_KasriErsal = 7

        RESIDE_08_AZ_Komak_TOLID_Kharej = 8
        RESIDE_09_BARGASHT_AZ_MASRAFE_VAHEDHAYE_GHEYRETOLIDI = 9
        RESIDE_10_DARYAFTE_MAVADE_NIMSAKHTE_AS_PAYEKAR = 10
        RESIDE_11_HAMLE_MOSTAGHIM = 11
        RESIDE_12_ENTEGHAL_AZ_ANBAR_BE_KARGAH = 12
        RESIDE_BARGASHT_KALAE_AMANI = 13
        RESIDE_DARYAFTE_KALAE_AMANI = 14
        RESIDE_MARJOIE_AS_KOMAK_TOLID = 15
        RESIDE_DARYAFT_AS_SEFARESHKAR = 16
        RESIDE_17_BARGASHTE_BASTEBANDI_AZ_PAYEKAR = 17
        EZAFI_MOJOODI_ANBAR_RESID = 18
        RESIDE_21_DARYAFTE_MAHSOOL_AZ_KARGAH_ARD = 21
        RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP = 23
        RESIDE_24_KHARIDE_DAKHELIMALZOOMAT = 24
        RESIDE_25_MARJOOEI_AZ_FOROOSHBEDOONEERJA = 25
        RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB = 26 '870325
        'RESIDE_26_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA = 26
        RESIDE_27_BARGASHT_AZ_DARAEI_SABETE_MASHHOOD = 27 ' yekta 921113
        RESIDE_28_MARJOOEI_AZ_FOROOSH_TOLIDI = 28
        RESIDE_31_Daryafte_ZAYEAT_Az_Anbar = 31
        RESIDE_32_DARYAFTE_ZAYEAT_BASTEBANDI_AZ_KARGAH = 32
        RESIDE_33_Daryaft_Az_Shoab = 33
        'RESIDE_34_Bargasht_Az_Shoab = 34
        RESIDE_34_RESID_DARYAFT_MAVAD_KARMOZDFALEE = 34
        RESIDE_35_Kalae_Nemooneh = 35
        RESIDE_36_Bargasht_Kalae_Nemooneh = 36
        RESIDE_37_DARYAFTE_MAHSOOL_AZ_KARGAH = 37
        RESIDE_38_MARJOOEI_AZ_FOROOSH = 38
        RESIDE_39_MARJOOEI_AZ_TOZIE = 39
        RESIDE_41_DARYAFT_AS_Co_GOROOH = 41
        RESIDE_42_DARYAFTE_ZAYEAT_AVALIE_AZ_KARGAH = 42
        RESIDE_45_BARGASHTI_ESLAHIEH = 45
        RESIDE_46_Kazeb = 46
        RESID_47_ZAYEATEMOTAFAREGHE = 47
        RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR = 48
        RESIDE_49_RESIDE_DARYAFEKALA_AZ_VahedeNoSazi = 49


        HAVALEH_ERSAL_KALAE_AMANI = 51
        HAVALEH_BARGASHTE_KALAE_AMANI = 52
        HAVALEH_FOROOSH_ZAYEAT = 53
        HAVALEH_FOROOSH_MAVAD_GHATEAT_MALZOMAT = 54
        HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH = 56
        KASRI_MOJOODI_ANBAR_HAVALE = 58
        HAVALEH_60_FOROOSHFAREE = 60
        HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI = 61
        HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI = 62
        HAVALEH_63_ODATE_AMANIE_DIGARAN_NAZDE_MA = 63
        HAVALEH_64_TAHVILE_AMANI_BE_DIGARAN = 64
        HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR = 65
        HAVALEH_66_TAHVIL_BE_VAHEDHAYE_TOLIDI = 66
        HAVALEH_67_TAHVIL_BE_Komak_TOLID_Dakhel = 67
        HAVALEH_68_TAHVIL_BE_Komak_TOLID_Kharej = 68
        HAVALEH_69_TAHVIL_BE_VAHEDHAYE_GHEYRETOLIDI = 69
        HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA = 70
        HAVALEH_71_FOROOSH = 71
        HAVALEH_72_Barai_Tozi = 72
        HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD = 73
        HAVALEH_74_Masrafe_LAVAZEME_YADAKI = 74
        HAVALEH_75_Ersal_Be_Shoab = 75
        HAVALEH_76_ERSALE_LVAZEME_TAMIRE_MASHIN = 76
        HAVALEH_77_Kalae_Nemooneh = 77
        HAVALEH_78_Bargasht_Kalae_Nemooneh = 78
        HAVALEH_79_Ersal_Mahsool_Be_TozieKonandeh = 79
        HAVALEH_81_ZAYEAT = 81
        HAVALEH_82_MADOOMI = 82
        HAVALEH_83_BARGASHTE_MAHSOOL_AZ_PAYEKAR = 83
        HAVALEH_84_Hazinehae_Omoomi = 84
        HAVALEH_85_Mahsoolat_Raigan = 85
        HAVALEH_86_ERSALE_LAVAZEME_TAMIRE_TASISAT = 86
        HAVALEH_87_ERSALE_ALBASE = 87
        HAVALEH_88_ERSALE_BEHDASHTI = 88
        HAVALEH_104_ERSALE_AGHLAME_ABDARKHANE = 104
        HAVALEH_90_ERSALE_MASALEH_SAKHTEMANI = 90
        HAVALEH_55_ERSALE_LAVAZEME_COPY = 55
        HAVALEH_100_ERSALE_KALAYE_FARHANGI = 100
        HAVALEH_101_ERSALE_MALZOOMAT_NEVESHTAFZAR = 101
        HAVALEH_102_ERSALE_ABZARE_MASRAFI = 102
        HAVALEH_103_ERSALE_TANZIFAT_MASRAFI = 103


        HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH = 89
        HAVALEH_91_TAHVIL_BE_Co_GOROOH = 91
        HAVALEH_92_HADAYA_BE_PERSONEL = 92
        HAVALEH_93_HavalehKazeb = 93
        HAVALEH_94_DARAE_SABET_MASHHOD = 94
        HAVALEH_95_BARGASHTI_ESLAHIEH = 95
        HAVALEH_96_MASRAFE_Co_GOROOH = 96
        HAVALEH_97_Barai_Tozi_MOSTAGIEM = 97
        HAVALEH_98_ERSAL_BE_PROJEH = 98
        HAVALEH_99_SADERAT_RAZEGHI = 99


        HAVALEH_109_HAVALEH_FOROOSH_AZ_PAYEKAR = 109
        HAVALEH_105_HAVALEH_ERSALEMAHSOOL_AZ_PAYEKAR = 105
        HAVALEH_106_LAVAZEME_TAMIR_NEGAHDARI_ASASIE = 106
        HAVALEH_107_LAVAZEME_TAMIR_NEGAHDARI_NAGHLIE = 107
        HAVALEH_108_ERSALE_SOOKHT = 108

        HAVALEH_110_ForooshMozayedeh_Transport = 110

        HAVALEH_116_EzafehErsal = 116
        HAVALEH_117_KasriDryaft = 117

        HAVALEH_111_KahandehKharid = 111
        HAVALEH_123_ForooshMavadVaBastehBandi = 123
        HAVALEH_124_ErsalGhataateMasrafiBeSherkathjayeGorooh = 124
        RESIDE_19_MARJOOEI_AZ_FOROOSH_MAVAD_MALZOOMAT_ZAYEAT = 19 ' add by yekta 920509

    End Enum

    Public Enum EnumNoeTarakoneshSN
        '  متناظر با انواع نمايش فرم سند انبار
        ntMOJOODIE_AVALE_DOREH = 1
        ntRESIDHA = 2
        ntHAVALEHHA = 3

        ntEzafiMojoodiAnbar = 12
        ntKasriMojoodiAnbar = 13

        ntRESIDEBARGASHTI = 45
        ntHAVALEHBARGASHTI = 95

        ntHAVALEHKASRIDARYAFT = 117
        ntRESIDKASRIERSAL = 7

        ntHAVALEHEZAFEHERSAL = 116
        ntRESIDEZAFEHDARYAFT = 6

        ntRESIDEMARJOOEIAZTOZIE = 39

        '910309
        ntHAVALEHKAHANDEHKHARID = 111
        ntHAVALEHFOROOSHMAVADVABASTEHBANDI = 123

        ntRESIDEKHARIDVAHAMLEMOSTAGHIM = 11  'yekta 940302
    End Enum

    Public Enum EnumNoeVoroodeAsnad
        ' انواع ورود اطلاعات اسناد انبار    واحدسنجش   تعداد در کارتن
        nvaVahedeSanjesh = 1
        nvaTedadDarKarton = 2
    End Enum

#End Region

  Public Shared Sub ShowSelectAnbar(ByVal aMDIParent As Form)
    ' نمايش فرم انتخاب انبار
    With gAnbarSelectForm
      .LoadForm()
      .Selected = gAnbarSelected
      .ShowDialog(aMDIParent)
      gAnbarSelected = .Selected
    End With
    End Sub

  Public Shared Sub SelectHesabdariSal(ByVal aMDIParent As Form)
    ' نمايش فرم انتخاب سال مالي
    With gSelectHesabdariSal
      .LoadForm()
      .ShowDialog(aMDIParent)
    End With
  End Sub

    Public Shared Function GetTafsiliWhereCondition_Gorooh(ByVal aGoroohTafsiliSN As Decimal) As String
        ' براي بدست آوردن شرط کامبو در مورد طرف حساب اسناد انبار از اين فانکشن استفاده ميشود
        '  با توجه به اتباط تراکنشهاي هر انبار 
        ' 1- گروه هاي تفصيلي را بدست مي آورد
        ' 2- از آنجا که برخي از گروه هاي تفصيلي مرکب هستند آنها را به اجتماع مي گذارد تا فصيلي هاي مجاز را درون شرط پوشش دهد
        Dim i As Integer
        Dim vSqlWhere As String
        Dim vDataView As DataView

        If aGoroohTafsiliSN <= 0 Then Return "1<>1"
        vDataView = cn.ExecuteQuery(" Select * From maGoroohTafsili " &
                                " Where GoroohTafsiliSN IN (Select GoroohTafsiliSN " &
                                " From dbo.maFnt_Req_SimpleGoroohTafsiliSN ( " & aGoroohTafsiliSN & "))")

        If vDataView.Count <= 0 Then Return "1<>1"

        For i = 0 To vDataView.Count - 1
            Dim vRefView As String = ""
            Dim vSql As String = ""
            If Val(vDataView(i)("HasRefer").ToString) = 1 AndAlso vDataView(i)("ReferView").ToString.Trim <> "" Then
                vRefView = vDataView(i)("ReferView").ToString
                vSql = "Select TafsiliSN From " & vRefView & " Where  VahedeTejariSN = " & gVahedeTejariSN
                vSqlWhere = vSqlWhere & vSql & " UNION "
            Else
                vSql = "Select TafsiliSN From maTafsili Where Status = 1  and GoroohTafsiliSN = " & vDataView(i)("GoroohTafsiliSN").ToString
                vSqlWhere = vSqlWhere & vSql & " UNION "
            End If
        Next
        vSqlWhere = Microsoft.VisualBasic.Left(vSqlWhere, Len(vSqlWhere) - Len(" UNION "))
        Return vSqlWhere

    End Function

    Public Sub ShowFilterChideman(Optional ByVal WhereConditionColumn As String = "")
    '  ByVal ShowGoroohItems As Boolean _
    ', Optional ByVal GoroohMojoodiatSN As Decimal = 0 _
    ', Optional ByVal GoroohBandiSN As Decimal = 0 _
    ', 

    ' نمايش و براي رويت گروه بندي هاي مختلف روي انواع موجوديت ها
    With mFrmUseChideman
      '.GoroohMojoodiatSN = GoroohMojoodiatSN
      '.GoroohBandiSN = GoroohBandiSN
      '.ShowGoroohItems = ShowGoroohItems
      .WhereConditionColumn = WhereConditionColumn
      .ShowDialog()
      mFilterSelectedChidemanSN = .SelectedChidemanSN
      mFilterWhereCondition = .WhereCondition
    End With

  End Sub

  Public Shared Function gSaveToEXCEL(ByVal aDataView As NetSql.View.CDataView) As Boolean '// فرستادن خروجي گريد در يک فايل با فرمت اکسل
    Dim vFileName As String
    vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
    If vFileName <> "" Then
      Functions.FTFlexFunctions.ExportExcel(aDataView.FlexGrid, vFileName)
      'Minoo.Functions.Export.ExportExcel(aDataView)
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
      Return True
    Else
      Return False
    End If
  End Function

  Protected Overrides Sub Finalize()
    'gSNFieldOption = Nothing
    'gVahedeTejariSN = Nothing
    'gVahedeTejariDS = Nothing
    mFrmUseChideman = Nothing
    MyBase.Finalize()
  End Sub

  'Public Sub New(ByVal atp As NetSql.Common.CSystem _
  '          , ByVal acn As NetSql.DB.CConnection _
  '          , ByVal agSM As Minoo.SecurityManager.FTSecurityManager _
  '          , ByVal agSNFieldOption As EnumFieldOptions _
  '          , ByVal agVahedeTejariSN As Decimal _
  '          , ByVal agVahedeTejariDS As String)

  '  tp = atp
  '  cn = acn
  '  gSM = agSM
  '  gSNFieldOption = agSNFieldOption
  '  gVahedeTejariSN = agVahedeTejariSN
  '  gVahedeTejariDs = agVahedeTejariDS

    'End Sub

    Public Function DoFillDatasetSP(ByVal _ds As Object, ByVal _VtblOutObj As Object, ByVal _vSPName As Object, ByVal _ParamAr As Array, ByVal cn As NetSql.DB.CConnection, ByVal tp As NetSql.Common.CSystem) As Object
        Dim SqlCon As New SqlClient.SqlConnection
        SqlCon.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
        Dim Sqlda As New SqlClient.SqlDataAdapter
        Dim Sqlcomm As New SqlClient.SqlCommand
        Dim i As Integer

        With Sqlcomm
            .Connection = SqlCon
            .CommandTimeout = 4000
            .CommandType = CommandType.StoredProcedure
            .CommandText = _vSPName
            If Not (_ParamAr Is Nothing) Then
                For i = 0 To _ParamAr.Length - 1 Step 2
                    .Parameters.Add(_ParamAr(i), _ParamAr(i + 1))
                Next
            End If
        End With
        Sqlda.SelectCommand = Sqlcomm

        Try
            If _VtblOutObj Is Nothing Then
                Sqlda.Fill(_ds)
            Else
                Sqlda.Fill(_ds, _VtblOutObj)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            SqlCon.Close()
        End Try

        Return _ds

    End Function


    Public Shared Function IsTarakoneshInGorooh(TarakoneshSN As Integer, GoroohTarakoneshSN As Integer) As Boolean
        Dim Result As Boolean = False
        Dim dv As New DataView

        dv = cn.ExecuteQuery("select dbo.abFng_ExistTarakonesh(" & GoroohTarakoneshSN & ", " & TarakoneshSN & ")")

        If dv.Count > 0 Then
            Result = CBool(dv(0)(0))
        End If

        Return Result
    End Function

    Public Shared Function GetDateValue(ByVal DateString As String) As String
        Dim DateStringLength As Integer = Trim(DateString.Length)
        If DateStringLength = 6 Then
            GetDateValue = DateString
        ElseIf DateStringLength = 8 Then
            GetDateValue = DateString.Substring(0, 4) & DateString.Substring(3, 2) & DateString.Substring(6, 2)
        ElseIf DateStringLength = 10 Then
            GetDateValue = DateString.Substring(0, 4) & DateString.Substring(6, 2) & DateString.Substring(8, 2)
        Else
            GetDateValue = "False"
        End If
        Return GetDateValue
    End Function

End Class
