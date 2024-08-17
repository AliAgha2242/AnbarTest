' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description:: 
'System ::انبار


Imports Minoo.Applications.Anbar.Report

Public Class mdiMainAnbar
    Inherits Minoo.Base.CBaseMDIMainForm


#Region "Windows Form Designer generated code "

    Private components As System.ComponentModel.IContainer
    Friend WithEvents mnuSep77 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSep75 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSep78 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSep79 As System.Windows.Forms.ToolStripSeparator


    Friend WithEvents mnuEzafiMojoodiAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuKasriMojoodiAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuEslaheTarafHesab As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuEslaheTarafHesabKharid As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSelectAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSelectCurrentSal As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep84 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFrmResideMamoorPakhsh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuMojoodiB As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuChideman As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSepKasriEzafeShoab As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSepDarkhastha As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSepEslahiha As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuMojoodiha As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuSep97 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuabNoeChideman As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuabChideman As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep98 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuabSharayeteMohiti As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuabChidemanSharayet As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuabKalaChideman As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuabSharayeteKala As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep103 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSep102 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuAnbarGardani As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuAnbarGardaniMain As Minoo.Controls.FTMenuItem

    Friend WithEvents MnuAnbarGardaniMianDoreh As Minoo.Controls.FTMenuItem

    Friend WithEvents MnuAnbarGardaniEnghezaDate As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuAnbarGardaniSemat As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuShomarandeh As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuShomareshHa As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSarakKasri As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuDarjAvalDoreh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep101 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRptAnbarGardani As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptAsnadBarcodeKhan As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptSooratjalaseAnbarGardani As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRTarakoneshGorooh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptMoghayratAnbarGardani As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRepAnbarGardaniEnghezaDate As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptMoghayratBienShomaresh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnurptAlertNerkhStandardAsnad As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptNegasht As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuDarjSanadAsAnbarBeAnbar65_5_2 As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuDarjSanadAsAnbarBeAnbar65_5_5 As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSefareshParam As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptTagAnbarGardani As Minoo.Controls.FTMenuItem
    ''Friend WithEvents mnuRptTagAnbarGardani As Minoo.Controls.FTMenuItem  ''---ghasemi 140001
    Friend WithEvents mnuSodorSanadAsMojodiBeAnbar10 As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuKardexList As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuUpdateSanadDate As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptTadil As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuTafkikRahgiri As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep74 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuTashimPattern As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep38 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuResideMarjooeAzTozie As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptTashim As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuBeinAnbarControlReport As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuTahvilBeGoroohReport As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptMTS As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptRaked As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptMoghayeratSanadMaliStandard As Minoo.Controls.FTMenuItem

    Friend WithEvents MnuAlarmMojoodi As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep40 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDarkhast As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuTafkik_Ghaza As Minoo.Controls.FTMenuItem      '--- yekta 930722
    Friend WithEvents mnuTafkik_Daroo As Minoo.Controls.FTMenuItem      '--- Dehghani 951128

    Friend WithEvents mnurptDarkhast As Minoo.Controls.FTMenuItem
    Friend WithEvents mnurptDarkhastKharid As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuBarnameh As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuAsnadAnbar As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuEnteghalMojoodiKalaPhiziki As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuErsalMojoodiBeAvalDoreh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSefrKardaneMojoodiAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSanadObjectChideman As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSep100 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuSep10 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents mnuGozareshhaHesabdari As Minoo.Controls.FTMenuItem

    Public WithEvents mnuabAnbarTarakonesh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuabTarakoneshGorooh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuabNoeBarnameh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuabTarakoneshGoroohTafsili As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep792 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuabAnbarKala As Minoo.Controls.FTMenuItem
    Public WithEvents mnuabAnbarConfig As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep73 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuabAnbarKalaRezerv As Minoo.Controls.FTMenuItem
    Public WithEvents mnu_AvalDoreh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep72 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuResid As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep35 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuQC As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep36 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuabAnbarNoeRahgiri As Minoo.Controls.FTMenuItem

    Public WithEvents mnu__abSpr_Mojoodi As Minoo.Controls.FTMenuItem
    Public WithEvents mnuMojudiWithIRC_GTIN As Minoo.Controls.FTMenuItem
    Public WithEvents mnu__MoghayerateCatalogueMahsoolatBaSystemMap As Minoo.Controls.FTMenuItem
    Public WithEvents mnu__ListMahsulateBarcodkhan As Minoo.Controls.FTMenuItem
    Public WithEvents mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan As Minoo.Controls.FTMenuItem
    Public WithEvents mnu__ShomarehBachhayeSabtNashodehHamlMostaghim As Minoo.Controls.FTMenuItem

    Public WithEvents mnuTafsiliA As Minoo.Controls.FTMenuItem
    Public WithEvents mnuMasrafeMavad As Minoo.Controls.FTMenuItem
    Public WithEvents mnuKardex As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep69 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents mnuSep62 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuErsalFile As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuResideBargashti As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuHavalehBargashti As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuHavalehKahandehKharid As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuResidDarAnbarQC As Minoo.Controls.FTMenuItem    'yekta 940302

    Public WithEvents mnuSep39 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents mnuSepKasriEzafeShoab As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuHavalehKasriDryaft As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuResideKasriErsal As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuHavalehEzafehErsal As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuResideEzafehDryaft As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuChapeSanad As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptAmalKard As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptVaredehMojaz As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuGetSanadAnbar As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuRptRezerv As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuCheckBarcode As Minoo.Controls.FTMenuItem  'yekta 941030
    Friend WithEvents mnuDarjSanadAsAnbarBeAnbar81_31 As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents mnu_RialeVaredeh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuHavaleh As Minoo.Controls.FTMenuItem
    Public WithEvents mnuSep350 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDarkhastKharidDakheli As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuDarkhastKharidKhareji As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuGozareshMoghayerat As Minoo.Controls.FTMenuItem
    Friend WithEvents mnuSep85 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuUpdateEnghezaDate As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuMohlateForoosh As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSep99 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuTafsiliA2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMoroorTafsiliNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoroorTafsiliTaadil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVardehSamaneJameAnbar As System.Windows.Forms.ToolStripMenuItem '' add by Rezania990506
    Friend WithEvents MnuImportFromExcel As Minoo.Controls.FTMenuItem

    Friend WithEvents MnuRptVaznRialiHavalehha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuRptMoghayeratShoab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControlKardex As Minoo.Controls.FTMenuItem
    Public WithEvents mnuRptChideman As Minoo.Controls.FTMenuItem
    Public WithEvents mnuRptQCIntervals As Minoo.Controls.FTMenuItem    'add by yekta 920913
    Public WithEvents mnuEslaheSanad As Minoo.Controls.FTMenuItem    'add by yekta 920924
    Public WithEvents mnuRptHavalehMovaghat As Minoo.Controls.FTMenuItem
    Public WithEvents MnuRptRialiAsnadKAsriEzafeh As Minoo.Controls.FTMenuItem

    Friend WithEvents mnuSahmeKala As Minoo.Controls.FTMenuItem    'add by Ghafari 940513
    Public WithEvents mnu__abSpr_MojoodiKalaSahmiye As Minoo.Controls.FTMenuItem  ' yekta 940513
    Friend WithEvents MnuTaeedeDaryafteHavalehayeArayeshi As Minoo.Controls.FTMenuItem    'yekta 940506

    Friend WithEvents MnuDoMovaghatSanadGhatee As Minoo.Controls.FTMenuItem    'Dehghani 990311

    Friend WithEvents MnuCopySanadAnbar As Minoo.Controls.FTMenuItem    'Dehghani 990601

    Friend WithEvents MnuEnteghlaMojoudiDaftarbeDaftar As Minoo.Controls.FTMenuItem    'Dehghani 990601
    Friend WithEvents MnuZayeatKartabl As Minoo.Controls.FTMenuItem    'Dehghani 14000922
    Friend WithEvents MnuZayeatKartablRole As Minoo.Controls.FTMenuItem    'Dehghani 14000922
    Friend WithEvents MnuZayeatKartablReport As Minoo.Controls.FTMenuItem    'Dehghani 14000922

    Friend WithEvents MnuSanadBarcodeReader As Minoo.Controls.FTMenuItem    'Dehghani 14010220
    Friend WithEvents MnuAnbarKalaParameter As Minoo.Controls.FTMenuItem    'Dehghani 14010518
    Friend WithEvents MnuTaghirNerkhAvaldore As Minoo.Controls.FTMenuItem 'ghasemi
    Friend WithEvents mnuFaseleDarkhastTaHavaleh As Minoo.Controls.FTMenuItem 'ghasemi14010512
    Friend WithEvents mnuRptDarkhastRepair As Minoo.Controls.FTMenuItem 'ghasemi14021010
    Friend WithEvents mnuRptPriodicService As Minoo.Controls.FTMenuItem 'ghasemi14021010

    Friend WithEvents mnuRptUIDtracking As Minoo.Controls.FTMenuItem 'Dehghani 14010714
    Friend WithEvents MnuSep108 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents MnuAccessControl As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSep109 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents MnuabTarakoneshConstraint As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSep110 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents MnuPm As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuDarkhastRepair As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuDarkhastPriodicService As Minoo.Controls.FTMenuItem
    Friend WithEvents MnuSep111 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents mnuReportAnbargardaniEnghezaDate As Minoo.Controls.FTMenuItem




    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Me.mnuBaseInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAnbar, Me.mnuabAnbarTarakonesh, Me.mnuabTarakoneshGorooh, Me.mnuabNoeBarnameh, Me.mnuabTarakoneshGoroohTafsili, MnuabTarakoneshConstraint, Me.mnuabAnbarNoeRahgiri, MnuSep109, MnuAccessControl, mnuSep78, MnuZayeatKartablRole, mnuSep35, Me.mnuSep792, Me.MnuAnbarKalaParameter, Me.mnuabAnbarKala, Me.mnuSep73, Me.mnuabAnbarKalaRezerv, Me.mnuSep74, Me.MnuTashimPattern, Me.mnuabAnbarConfig, Me.MnuSanadObjectChideman, Me.mnuSahmeKala})
        Me.mnuAmaliat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSepDarkhastha, Me.mnuSep40, Me.MnuSanadBarcodeReader, Me.mnuAsnadAnbar, Me.MnuDoMovaghatSanadGhatee, Me.mnuSep77, MnuZayeatKartabl, mnuSep75, Me.mnuQC, Me.mnuEslaheSanad, Me.mnuSep36, Me.mnuChideman, Me.mnuSep97, Me.MnuAnbarGardaniMain, Me.MnuSep99, Me.mnuGetSanadAnbar, Me.mnuErsalFile, Me.mnuSep62, Me.mnuDarjSanadAsAnbarBeAnbar65_5_2, Me.mnuDarjSanadAsAnbarBeAnbar65_5_5, Me.mnuDarjSanadAsAnbarBeAnbar81_31, Me.mnuSodorSanadAsMojodiBeAnbar10, Me.mnuUpdateSanadDate, Me.mnuSep34, Me.mnu_RialeVaredeh, Me.mnuSep84, Me.mnuSelectAnbar, Me.mnuSelectCurrentSal, Me.mnuSep85, Me.MnuUpdateEnghezaDate, Me.MnuMohlateForoosh, Me.MnuImportFromExcel, Me.mnuErsalMojoodiBeAvalDoreh, Me.mnuSefrKardaneMojoodiAnbar, Me.MnuSep10, Me.mnuEnteghalMojoodiKalaPhiziki, Me.MnuCopySanadAnbar, Me.MnuEnteghlaMojoudiDaftarbeDaftar, Me.MnuSep111, Me.MnuPm})
        Me.mnuAsnadAnbar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMojoodiha, Me.mnuResid, Me.mnuResidDarAnbarQC, Me.mnuHavaleh, MnuTaeedeDaryafteHavalehayeArayeshi, Me.mnuBarnameh, Me.mnuSep350, Me.MnuResideMarjooeAzTozie, Me.mnuSep38, Me.mnuSepKasriEzafeShoab, Me.mnuSep39, Me.mnuHavalehKahandehKharid, Me.mnuSepEslahiha, Me.mnuSep35, Me.mnuEzafiMojoodiAnbar, Me.mnuKasriMojoodiAnbar}) 'yekta 940302
        Me.mnuGozareshha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGozareshhaHesabdari, Me.mnuRTarakoneshGorooh, Me.mnu__abSpr_Mojoodi, Me.mnuRptAsnadBarcodeKhan, Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim, Me.mnu__abSpr_MojoodiKalaSahmiye, Me.mnuTafsiliA, MnuMoroorTafsiliNew, Me.mnuVardehSamaneJameAnbar, Me.mnuMasrafeMavad, Me.mnuRptAmalKard, Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh, Me.mnuKardexList, Me.mnuRptQCIntervals, Me.mnuChapeSanad, Me.mnuRptRezerv, Me.mnuCheckBarcode, Me.mnuMojoodiB, Me.mnurptDarkhast, Me.mnurptDarkhastKharid, Me.mnuSep69, Me.mnuRptVaredehMojaz, Me.mnuRptMTS, Me.mnuRptRaked, Me.MnuAlarmMojoodi, Me.mnuSep101, Me.mnuRptAnbarGardani, Me.mnuGozareshMoghayerat, Me.mnuRptNegasht, Me.mnuSefareshParam, Me.mnuBeinAnbarControlReport, Me.MnuRptVaznRialiHavalehha, Me.MnuRptMoghayeratShoab, Me.mnuRptChideman, Me.mnuRptHavalehMovaghat, Me.MnuRptRialiAsnadKAsriEzafeh, Me.MnuSep100, Me.MnuZayeatKartablReport, Me.mnuFaseleDarkhastTaHavaleh, Me.mnuRptPriodicService, Me.mnuRptDarkhastRepair, MnuSep108})
        Me.mnuGozareshhaHesabdari.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFrmResideMamoorPakhsh, Me.mnurptAlertNerkhStandardAsnad, Me.mnuRptTadil, Me.mnuRptTashim, Me.mnuRptMoghayeratSanadMaliStandard})
        Me.mnuChideman.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuabNoeChideman, Me.mnuabSharayeteMohiti, Me.mnuSep98, Me.mnuabChideman, Me.mnuSep102, Me.mnuabChidemanSharayet, Me.mnuabSharayeteKala, Me.mnuSep103, Me.mnuabKalaChideman})
        Me.MnuAnbarGardaniMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAnbarGardani, Me.MnuAnbarGardaniMianDoreh, Me.MnuAnbarGardaniEnghezaDate})
        Me.mnuRptAnbarGardani.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRptSooratjalaseAnbarGardani, Me.mnuRptTagAnbarGardani, Me.mnuRptMoghayratBienShomaresh, Me.mnuRptMoghayratAnbarGardani, Me.mnuRepAnbarGardaniEnghezaDate})

        Me.mnuRptAsnadBarcodeKhan.DropDownItems.AddRange(New ToolStripItem() {Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan, Me.mnuMojudiWithIRC_GTIN, Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap, Me.mnu__ListMahsulateBarcodkhan, mnuRptUIDtracking})

        Me.mnuBeinAnbarControlReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTahvilBeGoroohReport, Me.mnuKardex, Me.mnuControlKardex})
        Me.mnuSepKasriEzafeShoab.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHavalehKasriDryaft, Me.mnuResideKasriErsal, Me.mnuHavalehEzafehErsal, Me.mnuResideEzafehDryaft})
        Me.mnuSepDarkhastha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDarkhast, Me.mnuDarkhastKharidDakheli, Me.mnuDarkhastKharidKhareji, Me.mnuTafkik_Ghaza, Me.mnuTafkik_Daroo}) '------ yekta 930722
        Me.mnuSepEslahiha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResideBargashti, Me.mnuHavalehBargashti, Me.mnuEslaheTarafHesab, Me.mnuEslaheTarafHesabKharid})
        Me.mnuMojoodiha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_AvalDoreh, Me.MnuTaghirNerkhAvaldore})
        Me.MnuPm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuDarkhastRepair, Me.MnuDarkhastPriodicService})
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then

            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub








    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMainAnbar))
        Me.mnuEnteghalMojoodiKalaPhiziki = New Minoo.Controls.FTMenuItem()
        Me.MnuDoMovaghatSanadGhatee = New Minoo.Controls.FTMenuItem()
        Me.MnuCopySanadAnbar = New Minoo.Controls.FTMenuItem()
        Me.MnuEnteghlaMojoudiDaftarbeDaftar = New Minoo.Controls.FTMenuItem()
        Me.mnuGozareshhaHesabdari = New Minoo.Controls.FTMenuItem()
        Me.mnuFrmResideMamoorPakhsh = New Minoo.Controls.FTMenuItem()
        Me.mnurptAlertNerkhStandardAsnad = New Minoo.Controls.FTMenuItem()
        Me.mnuRptTadil = New Minoo.Controls.FTMenuItem()
        Me.mnuRptTashim = New Minoo.Controls.FTMenuItem()
        Me.mnuabAnbarTarakonesh = New Minoo.Controls.FTMenuItem()
        Me.MnuabTarakoneshConstraint = New Minoo.Controls.FTMenuItem()
        Me.MnuPm = New Minoo.Controls.FTMenuItem()
        Me.MnuDarkhastPriodicService = New Minoo.Controls.FTMenuItem()
        Me.MnuDarkhastRepair = New Minoo.Controls.FTMenuItem()
        Me.mnuabTarakoneshGorooh = New Minoo.Controls.FTMenuItem()
        Me.mnuabNoeBarnameh = New Minoo.Controls.FTMenuItem()
        Me.mnuabTarakoneshGoroohTafsili = New Minoo.Controls.FTMenuItem()
        Me.mnuabAnbarNoeRahgiri = New Minoo.Controls.FTMenuItem()
        Me.mnuSep792 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabAnbarKala = New Minoo.Controls.FTMenuItem()
        Me.MnuAnbarKalaParameter = New Minoo.Controls.FTMenuItem()
        Me.MnuAccessControl = New Minoo.Controls.FTMenuItem()
        Me.MnuSep109 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabAnbarConfig = New Minoo.Controls.FTMenuItem()
        Me.mnuSep73 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSep110 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSep111 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSep10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabAnbarKalaRezerv = New Minoo.Controls.FTMenuItem()
        Me.mnu_AvalDoreh = New Minoo.Controls.FTMenuItem()
        Me.mnuSep72 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuResid = New Minoo.Controls.FTMenuItem()
        Me.mnuResideBargashti = New Minoo.Controls.FTMenuItem()
        Me.mnuHavalehBargashti = New Minoo.Controls.FTMenuItem()
        Me.mnuHavalehKahandehKharid = New Minoo.Controls.FTMenuItem()
        Me.mnuResidDarAnbarQC = New Minoo.Controls.FTMenuItem()
        Me.mnuSepKasriEzafeShoab = New Minoo.Controls.FTMenuItem()
        Me.mnuHavalehKasriDryaft = New Minoo.Controls.FTMenuItem()
        Me.mnuResideKasriErsal = New Minoo.Controls.FTMenuItem()
        Me.mnuHavalehEzafehErsal = New Minoo.Controls.FTMenuItem()
        Me.mnuResideEzafehDryaft = New Minoo.Controls.FTMenuItem()
        Me.mnuSepDarkhastha = New Minoo.Controls.FTMenuItem()
        Me.mnuDarkhast = New Minoo.Controls.FTMenuItem()
        Me.mnuDarkhastKharidDakheli = New Minoo.Controls.FTMenuItem()
        Me.mnuDarkhastKharidKhareji = New Minoo.Controls.FTMenuItem()
        Me.mnuTafkik_Ghaza = New Minoo.Controls.FTMenuItem()
        Me.mnuTafkik_Daroo = New Minoo.Controls.FTMenuItem()
        Me.mnurptDarkhastKharid = New Minoo.Controls.FTMenuItem()
        Me.mnuSepEslahiha = New Minoo.Controls.FTMenuItem()
        Me.mnuEslaheTarafHesab = New Minoo.Controls.FTMenuItem()
        Me.mnuMojoodiha = New Minoo.Controls.FTMenuItem()
        Me.mnuEslaheTarafHesabKharid = New Minoo.Controls.FTMenuItem()
        Me.mnuSep35 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuZayeatKartabl = New Minoo.Controls.FTMenuItem()
        Me.MnuZayeatKartablRole = New Minoo.Controls.FTMenuItem()
        Me.MnuZayeatKartablReport = New Minoo.Controls.FTMenuItem()
        Me.MnuSanadBarcodeReader = New Minoo.Controls.FTMenuItem()
        Me.mnuQC = New Minoo.Controls.FTMenuItem()
        Me.mnuSep36 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGetSanadAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuErsalFile = New Minoo.Controls.FTMenuItem()
        Me.mnuSep62 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDarjSanadAsAnbarBeAnbar81_31 = New Minoo.Controls.FTMenuItem()
        Me.mnuSep34 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_RialeVaredeh = New Minoo.Controls.FTMenuItem()
        Me.mnu__abSpr_Mojoodi = New Minoo.Controls.FTMenuItem()
        Me.mnuMojudiWithIRC_GTIN = New Minoo.Controls.FTMenuItem()
        Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap = New Minoo.Controls.FTMenuItem()
        Me.mnu__ListMahsulateBarcodkhan = New Minoo.Controls.FTMenuItem()
        Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan = New Controls.FTMenuItem()
        Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim = New Minoo.Controls.FTMenuItem()
        Me.mnuTafsiliA = New Minoo.Controls.FTMenuItem()
        Me.mnuMasrafeMavad = New Minoo.Controls.FTMenuItem()
        Me.mnuKardex = New Minoo.Controls.FTMenuItem()
        Me.mnuControlKardex = New Minoo.Controls.FTMenuItem()
        Me.mnuRptQCIntervals = New Minoo.Controls.FTMenuItem()
        Me.mnuEslaheSanad = New Minoo.Controls.FTMenuItem()
        Me.mnuChapeSanad = New Minoo.Controls.FTMenuItem()
        Me.mnuSep69 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRptAmalKard = New Minoo.Controls.FTMenuItem()
        Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh = New Minoo.Controls.FTMenuItem()
        Me.mnuRptVaredehMojaz = New Minoo.Controls.FTMenuItem()
        Me.mnuRptRezerv = New Minoo.Controls.FTMenuItem()
        Me.mnuCheckBarcode = New Minoo.Controls.FTMenuItem()
        Me.mnuSep77 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSep78 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSep79 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSep75 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEzafiMojoodiAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuKasriMojoodiAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuSep84 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuSelectCurrentSal = New Minoo.Controls.FTMenuItem()
        Me.mnuMojoodiB = New Minoo.Controls.FTMenuItem()
        Me.mnuChideman = New Minoo.Controls.FTMenuItem()
        Me.mnuabNoeChideman = New Minoo.Controls.FTMenuItem()
        Me.mnuabSharayeteMohiti = New Minoo.Controls.FTMenuItem()
        Me.mnuSep98 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabChideman = New Minoo.Controls.FTMenuItem()
        Me.mnuSep102 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabChidemanSharayet = New Minoo.Controls.FTMenuItem()
        Me.mnuabSharayeteKala = New Minoo.Controls.FTMenuItem()
        Me.mnuSep103 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuabKalaChideman = New Minoo.Controls.FTMenuItem()
        Me.mnuSep97 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuAnbarGardaniMain = New Minoo.Controls.FTMenuItem()
        Me.MnuAnbarGardani = New Minoo.Controls.FTMenuItem()
        Me.MnuAnbarGardaniEnghezaDate = New Minoo.Controls.FTMenuItem()
        Me.MnuAnbarGardaniMianDoreh = New Minoo.Controls.FTMenuItem()
        Me.MnuAnbarGardaniSemat = New Minoo.Controls.FTMenuItem()
        Me.MnuShomarandeh = New Minoo.Controls.FTMenuItem()
        Me.MnuShomareshHa = New Minoo.Controls.FTMenuItem()
        Me.MnuSarakKasri = New Minoo.Controls.FTMenuItem()
        Me.MnuDarjAvalDoreh = New Minoo.Controls.FTMenuItem()
        Me.MnuTafkikRahgiri = New Minoo.Controls.FTMenuItem()
        Me.mnuSep101 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRptAnbarGardani = New Minoo.Controls.FTMenuItem()
        Me.mnuRptAsnadBarcodeKhan = New Controls.FTMenuItem()
        Me.mnuRptSooratjalaseAnbarGardani = New Minoo.Controls.FTMenuItem()
        Me.mnuRptTagAnbarGardani = New Minoo.Controls.FTMenuItem()
        Me.mnuRptMoghayratBienShomaresh = New Minoo.Controls.FTMenuItem()
        Me.mnuRptMoghayratAnbarGardani = New Minoo.Controls.FTMenuItem()
        Me.mnuRepAnbarGardaniEnghezaDate = New Minoo.Controls.FTMenuItem()
        Me.mnuRTarakoneshGorooh = New Minoo.Controls.FTMenuItem()
        Me.mnuRptNegasht = New Minoo.Controls.FTMenuItem()
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_2 = New Minoo.Controls.FTMenuItem()
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_5 = New Minoo.Controls.FTMenuItem()
        Me.mnuSefareshParam = New Minoo.Controls.FTMenuItem()
        Me.mnuSodorSanadAsMojodiBeAnbar10 = New Minoo.Controls.FTMenuItem()
        Me.mnuKardexList = New Minoo.Controls.FTMenuItem()
        Me.mnuUpdateSanadDate = New Minoo.Controls.FTMenuItem()
        Me.mnuSep74 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuTashimPattern = New Minoo.Controls.FTMenuItem()
        Me.MnuResideMarjooeAzTozie = New Minoo.Controls.FTMenuItem()
        Me.mnuSep38 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSep39 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBeinAnbarControlReport = New Minoo.Controls.FTMenuItem()
        Me.mnuTahvilBeGoroohReport = New Minoo.Controls.FTMenuItem()
        Me.mnuRptMTS = New Minoo.Controls.FTMenuItem()
        Me.mnuRptRaked = New Minoo.Controls.FTMenuItem()
        Me.mnuRptMoghayeratSanadMaliStandard = New Minoo.Controls.FTMenuItem()
        Me.MnuAlarmMojoodi = New Minoo.Controls.FTMenuItem()
        Me.mnuBarnameh = New Minoo.Controls.FTMenuItem()
        Me.mnuSep40 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnurptDarkhast = New Minoo.Controls.FTMenuItem()
        Me.mnuHavaleh = New Minoo.Controls.FTMenuItem()
        Me.mnuSep350 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGozareshMoghayerat = New Minoo.Controls.FTMenuItem()
        Me.mnuSep85 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuUpdateEnghezaDate = New Minoo.Controls.FTMenuItem()
        Me.MnuMohlateForoosh = New Minoo.Controls.FTMenuItem()
        Me.MnuSep99 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSep108 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuTafsiliA2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMoroorTafsiliNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoroorTafsiliTaadil = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVardehSamaneJameAnbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRptVaznRialiHavalehha = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRptMoghayeratShoab = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuImportFromExcel = New Minoo.Controls.FTMenuItem()
        Me.mnuRptChideman = New Minoo.Controls.FTMenuItem()
        Me.mnuRptHavalehMovaghat = New Minoo.Controls.FTMenuItem()
        Me.mnuAsnadAnbar = New Minoo.Controls.FTMenuItem()
        Me.mnuErsalMojoodiBeAvalDoreh = New Minoo.Controls.FTMenuItem()
        Me.mnuSefrKardaneMojoodiAnbar = New Minoo.Controls.FTMenuItem()
        Me.MnuSanadObjectChideman = New Minoo.Controls.FTMenuItem()
        Me.MnuSep100 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu__abSpr_MojoodiKalaSahmiye = New Minoo.Controls.FTMenuItem()
        Me.MnuTaeedeDaryafteHavalehayeArayeshi = New Minoo.Controls.FTMenuItem()
        Me.MnuRptRialiAsnadKAsriEzafeh = New Minoo.Controls.FTMenuItem()
        Me.mnuSahmeKala = New Minoo.Controls.FTMenuItem()
        Me.MnuTaghirNerkhAvaldore = New Minoo.Controls.FTMenuItem()
        Me.mnuFaseleDarkhastTaHavaleh = New Minoo.Controls.FTMenuItem()
        Me.mnuRptDarkhastRepair = New Minoo.Controls.FTMenuItem()
        Me.mnuRptPriodicService = New Minoo.Controls.FTMenuItem()
        Me.mnuRptUIDtracking = New Minoo.Controls.FTMenuItem()
        CType(Me.sbpVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpComputerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpDateShamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainToolbar.SuspendLayout()
        CType(Me.sbpVahedeTejariName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpSal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpDataBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbbUsers
        '
        Me.ToolTipMain.SetToolTip(Me.tbbUsers, "تغيير كاربر")
        '
        'sbMain
        '
        Me.sbMain.Location = New System.Drawing.Point(0, 494)
        Me.sbMain.Size = New System.Drawing.Size(736, 23)
        Me.MainToolbar.Controls.SetChildIndex(Me.tbbUsers, 0)
        '
        'mnuEnteghalMojoodiKalaPhiziki
        '
        Me.mnuEnteghalMojoodiKalaPhiziki.AppName = "mnuEnteghalMojoodiKalaPhiziki"
        Me.mnuEnteghalMojoodiKalaPhiziki.Name = "mnuEnteghalMojoodiKalaPhiziki"
        Me.mnuEnteghalMojoodiKalaPhiziki.Size = New System.Drawing.Size(32, 19)
        Me.mnuEnteghalMojoodiKalaPhiziki.Text = "انتقال موجودی بین رهگیری های یک کالا"
        '
        'MnuDoMovaghatSanadGhatee
        '
        Me.MnuDoMovaghatSanadGhatee.AppName = "MnuDoMovaghatSanadGhatee"
        Me.MnuDoMovaghatSanadGhatee.Name = "MnuDoMovaghatSanadGhatee"
        Me.MnuDoMovaghatSanadGhatee.Size = New System.Drawing.Size(32, 19)
        Me.MnuDoMovaghatSanadGhatee.Text = "موقت نمودن اسناد قطعی"
        '
        'MnuCopySanadAnbar
        '
        Me.MnuCopySanadAnbar.AppName = "MnuCopySanadAnbar"
        Me.MnuCopySanadAnbar.Name = "MnuCopySanadAnbar"
        Me.MnuCopySanadAnbar.Size = New System.Drawing.Size(32, 19)
        Me.MnuCopySanadAnbar.Text = "کپی سند انبار"
        '
        'MnuEnteghlaMojoudiDaftarbeDaftar
        '
        Me.MnuEnteghlaMojoudiDaftarbeDaftar.AppName = "MnuEnteghlaMojoudiDaftarbeDaftar"
        Me.MnuEnteghlaMojoudiDaftarbeDaftar.Name = "MnuEnteghlaMojoudiDaftarbeDaftar"
        Me.MnuEnteghlaMojoudiDaftarbeDaftar.Size = New System.Drawing.Size(32, 19)
        Me.MnuEnteghlaMojoudiDaftarbeDaftar.Text = "انتقال موجودی دفتر به دفتر"
        '
        'mnuGozareshhaHesabdari
        '
        Me.mnuGozareshhaHesabdari.AppName = "mnuGozareshhaHesabdari"
        Me.mnuGozareshhaHesabdari.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFrmResideMamoorPakhsh, Me.mnurptAlertNerkhStandardAsnad, Me.mnuRptTadil, Me.mnuRptTashim})
        Me.mnuGozareshhaHesabdari.Name = "mnuGozareshhaHesabdari"
        Me.mnuGozareshhaHesabdari.Size = New System.Drawing.Size(259, 22)
        Me.mnuGozareshhaHesabdari.Text = "گزارش هاي حسابداري"
        '
        'mnuFrmResideMamoorPakhsh
        '
        Me.mnuFrmResideMamoorPakhsh.AppName = "mnuFrmResideMamoorPakhsh"
        Me.mnuFrmResideMamoorPakhsh.Name = "mnuFrmResideMamoorPakhsh"
        Me.mnuFrmResideMamoorPakhsh.Size = New System.Drawing.Size(328, 22)
        Me.mnuFrmResideMamoorPakhsh.Text = "گزارش رسيد مامور پخش"
        '
        'mnurptAlertNerkhStandardAsnad
        '
        Me.mnurptAlertNerkhStandardAsnad.AppName = "mnurptAlertNerkhStandardAsnad"
        Me.mnurptAlertNerkhStandardAsnad.Name = "mnurptAlertNerkhStandardAsnad"
        Me.mnurptAlertNerkhStandardAsnad.Size = New System.Drawing.Size(328, 22)
        Me.mnurptAlertNerkhStandardAsnad.Text = "گزارش کالاهاي بدون نرخ"
        '
        'mnuRptTadil
        '
        Me.mnuRptTadil.AppName = "mnuRptTadil"
        Me.mnuRptTadil.Name = "mnuRptTadil"
        Me.mnuRptTadil.Size = New System.Drawing.Size(328, 22)
        Me.mnuRptTadil.Text = "گزارش اسناد تعديل انحراف نرخ استاندارد  ابتداي دوره"
        '
        'mnuRptTashim
        '
        Me.mnuRptTashim.AppName = "mnuRptTashim"
        Me.mnuRptTashim.Name = "mnuRptTashim"
        Me.mnuRptTashim.Size = New System.Drawing.Size(328, 22)
        Me.mnuRptTashim.Text = "گزارش اسناد تسهيم انحراف"
        '
        'mnuabAnbarTarakonesh
        '
        Me.mnuabAnbarTarakonesh.AppName = "mnuabAnbarTarakonesh"
        Me.mnuabAnbarTarakonesh.Name = "mnuabAnbarTarakonesh"
        Me.mnuabAnbarTarakonesh.Size = New System.Drawing.Size(251, 22)
        Me.mnuabAnbarTarakonesh.Text = "تراكنشهاي هر انبار"
        '
        'MnuabTarakoneshConstraint
        '
        Me.MnuabTarakoneshConstraint.AppName = "MnuabTarakoneshConstraint"
        Me.MnuabTarakoneshConstraint.Name = "MnuabTarakoneshConstraint"
        Me.MnuabTarakoneshConstraint.Size = New System.Drawing.Size(251, 22)
        Me.MnuabTarakoneshConstraint.Text = "تنظیمات محدود سازی تراکنش"
        '
        'MnuPm
        '
        Me.MnuPm.AppName = "MnuPm"
        Me.MnuPm.Name = "MnuPm"
        Me.MnuPm.Size = New System.Drawing.Size(251, 22)
        Me.MnuPm.Text = "تعمیر و نگهداری"
        '
        'MnuDarkhastPriodicService
        '
        Me.MnuDarkhastPriodicService.AppName = "MnuDarkhastPriodicService"
        Me.MnuDarkhastPriodicService.Name = "MnuDarkhastPriodicService"
        Me.MnuDarkhastPriodicService.Size = New System.Drawing.Size(251, 22)
        Me.MnuDarkhastPriodicService.Text = "سرویس های دوره ای"
        '
        'MnuDarkhastRepair
        '
        Me.MnuDarkhastRepair.AppName = "MnuDarkhastRepair"
        Me.MnuDarkhastRepair.Name = "MnuDarkhastRepair"
        Me.MnuDarkhastRepair.Size = New System.Drawing.Size(251, 22)
        Me.MnuDarkhastRepair.Text = "درخواست تعمیرات(ثبت توقفات)"
        '
        'mnuabTarakoneshGorooh
        '
        Me.mnuabTarakoneshGorooh.AppName = "mnuabTarakoneshGorooh"
        Me.mnuabTarakoneshGorooh.Name = "mnuabTarakoneshGorooh"
        Me.mnuabTarakoneshGorooh.Size = New System.Drawing.Size(251, 22)
        Me.mnuabTarakoneshGorooh.Text = "گروه بندي تراکنش ها"
        '
        'mnuabNoeBarnameh
        '
        Me.mnuabNoeBarnameh.AppName = "mnuabNoeBarnameh"
        Me.mnuabNoeBarnameh.Name = "mnuabNoeBarnameh"
        Me.mnuabNoeBarnameh.Size = New System.Drawing.Size(251, 22)
        Me.mnuabNoeBarnameh.Text = "انواع بارنامه"
        '
        'mnuabTarakoneshGoroohTafsili
        '
        Me.mnuabTarakoneshGoroohTafsili.AppName = "mnuabTarakoneshGoroohTafsili"
        Me.mnuabTarakoneshGoroohTafsili.Name = "mnuabTarakoneshGoroohTafsili"
        Me.mnuabTarakoneshGoroohTafsili.Size = New System.Drawing.Size(251, 22)
        Me.mnuabTarakoneshGoroohTafsili.Text = "ارتباط تراكنش انبار با گروه هاي تفصيلي"
        '
        'mnuabAnbarNoeRahgiri
        '
        Me.mnuabAnbarNoeRahgiri.AppName = "mnuabAnbarNoeRahgiri"
        Me.mnuabAnbarNoeRahgiri.Name = "mnuabAnbarNoeRahgiri"
        Me.mnuabAnbarNoeRahgiri.Size = New System.Drawing.Size(251, 22)
        Me.mnuabAnbarNoeRahgiri.Text = "رويه رهگيري کالاها در انبار"
        '
        'mnuSep792
        '
        Me.mnuSep792.Name = "mnuSep792"
        Me.mnuSep792.Size = New System.Drawing.Size(248, 6)
        '
        'mnuabAnbarKala
        '
        Me.mnuabAnbarKala.AppName = "mnuabAnbarKala"
        Me.mnuabAnbarKala.Name = "mnuabAnbarKala"
        Me.mnuabAnbarKala.Size = New System.Drawing.Size(251, 22)
        Me.mnuabAnbarKala.Text = "كالاهاي هر انبار"
        '
        'MnuAnbarKalaParameter
        '
        Me.MnuAnbarKalaParameter.AppName = "MnuAnbarKalaParameter"
        Me.MnuAnbarKalaParameter.Name = "MnuAnbarKalaParameter"
        Me.MnuAnbarKalaParameter.Size = New System.Drawing.Size(251, 22)
        Me.MnuAnbarKalaParameter.Text = "تعریف پارامترهای محصول"
        '
        'MnuAccessControl
        '
        Me.MnuAccessControl.AppName = "MnuAccessControl"
        Me.MnuAccessControl.Name = "MnuAccessControl"
        Me.MnuAccessControl.Size = New System.Drawing.Size(267, 22)
        Me.MnuAccessControl.Text = "تعریف تنظیمات کنترلی سیستم انبار"
        '
        'MnuSep109
        '
        Me.MnuSep109.Name = "MnuSep109"
        Me.MnuSep109.Size = New System.Drawing.Size(195, 6)
        '
        'mnuabAnbarConfig
        '
        Me.mnuabAnbarConfig.AppName = "mnuabAnbarConfig"
        Me.mnuabAnbarConfig.Name = "mnuabAnbarConfig"
        Me.mnuabAnbarConfig.Size = New System.Drawing.Size(251, 22)
        Me.mnuabAnbarConfig.Text = "تنظیمات اسناد متقابل "
        '
        'mnuSep73
        '
        Me.mnuSep73.Name = "mnuSep73"
        Me.mnuSep73.Size = New System.Drawing.Size(248, 6)
        '
        'MnuSep110
        '
        Me.MnuSep110.Name = "MnuSep110"
        Me.MnuSep110.Size = New System.Drawing.Size(6, 6)
        '
        'MnuSep111
        '
        Me.MnuSep111.Name = "MnuSep111"
        Me.MnuSep111.Size = New System.Drawing.Size(6, 6)
        '
        'MnuSep10
        '
        Me.MnuSep10.Name = "MnuSep10"
        Me.MnuSep10.Size = New System.Drawing.Size(6, 6)
        '
        'mnuabAnbarKalaRezerv
        '
        Me.mnuabAnbarKalaRezerv.AppName = "mnuabAnbarKalaRezerv"
        Me.mnuabAnbarKalaRezerv.Name = "mnuabAnbarKalaRezerv"
        Me.mnuabAnbarKalaRezerv.Size = New System.Drawing.Size(251, 22)
        Me.mnuabAnbarKalaRezerv.Text = "رزرو كالا"
        '
        'mnu_AvalDoreh
        '
        Me.mnu_AvalDoreh.AppName = "mnu_AvalDoreh"
        Me.mnu_AvalDoreh.Name = "mnu_AvalDoreh"
        Me.mnu_AvalDoreh.Size = New System.Drawing.Size(198, 22)
        Me.mnu_AvalDoreh.Text = "موجودي اول دوره"
        '
        'mnuSep72
        '
        Me.mnuSep72.Name = "mnuSep72"
        Me.mnuSep72.Size = New System.Drawing.Size(195, 6)
        '
        'mnuResid
        '
        Me.mnuResid.AppName = "mnuResid"
        Me.mnuResid.Name = "mnuResid"
        Me.mnuResid.Size = New System.Drawing.Size(198, 22)
        Me.mnuResid.Text = "رسيد"
        '
        'mnuResideBargashti
        '
        Me.mnuResideBargashti.AppName = "mnuResideBargashti"
        Me.mnuResideBargashti.Name = "mnuResideBargashti"
        Me.mnuResideBargashti.Size = New System.Drawing.Size(166, 22)
        Me.mnuResideBargashti.Text = "اصلاحي افزاينده"
        '
        'mnuHavalehBargashti
        '
        Me.mnuHavalehBargashti.AppName = "mnuHavalehBargashti"
        Me.mnuHavalehBargashti.Name = "mnuHavalehBargashti"
        Me.mnuHavalehBargashti.Size = New System.Drawing.Size(166, 22)
        Me.mnuHavalehBargashti.Text = "اصلاحي کاهنده"
        '
        'mnuHavalehKahandehKharid
        '
        Me.mnuHavalehKahandehKharid.AppName = "mnuHavalehKahandehKharid"
        Me.mnuHavalehKahandehKharid.Name = "mnuHavalehKahandehKharid"
        Me.mnuHavalehKahandehKharid.Size = New System.Drawing.Size(198, 22)
        Me.mnuHavalehKahandehKharid.Text = "حواله کاهنده خرید"
        '
        'mnuResidDarAnbarQC
        '
        Me.mnuResidDarAnbarQC.AppName = "mnuResidDarAnbarQC"
        Me.mnuResidDarAnbarQC.Name = "mnuResidDarAnbarQC"
        Me.mnuResidDarAnbarQC.Size = New System.Drawing.Size(198, 22)
        Me.mnuResidDarAnbarQC.Text = "رسید در انبار کنترل کیفیت"
        '
        'mnuSepKasriEzafeShoab
        '
        Me.mnuSepKasriEzafeShoab.AppName = "mnuSepKasriEzafeShoab"
        Me.mnuSepKasriEzafeShoab.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHavalehKasriDryaft, Me.mnuResideKasriErsal, Me.mnuHavalehEzafehErsal, Me.mnuResideEzafehDryaft})
        Me.mnuSepKasriEzafeShoab.Name = "mnuSepKasriEzafeShoab"
        Me.mnuSepKasriEzafeShoab.Size = New System.Drawing.Size(198, 22)
        Me.mnuSepKasriEzafeShoab.Text = "کسری و اضافه بین شعب"
        '
        'mnuHavalehKasriDryaft
        '
        Me.mnuHavalehKasriDryaft.AppName = "mnuHavalehKasriDryaft"
        Me.mnuHavalehKasriDryaft.Name = "mnuHavalehKasriDryaft"
        Me.mnuHavalehKasriDryaft.Size = New System.Drawing.Size(250, 22)
        Me.mnuHavalehKasriDryaft.Text = "حواله کسری دریافت از شرکتهای گروه"
        Me.mnuHavalehKasriDryaft.ToolTipText = "این تراکنش هنگامی که کالای ارسال شده از سند ثبت شده کمتر است توسط واحد دریافت کنن" &
    "ده ثبت می شود _ اصلاحی کاهنده"
        '
        'mnuResideKasriErsal
        '
        Me.mnuResideKasriErsal.AppName = "mnuResideKasriErsal"
        Me.mnuResideKasriErsal.Name = "mnuResideKasriErsal"
        Me.mnuResideKasriErsal.Size = New System.Drawing.Size(250, 22)
        Me.mnuResideKasriErsal.Text = "رسید کسری ارسال به شرکتهای گروه"
        Me.mnuResideKasriErsal.ToolTipText = "این تراکنش سند مقابل حواله کسری دریافت می باشد و بصورت ماشینی ثبت می شود _ اصلاحی" &
    " افزاینده"
        '
        'mnuHavalehEzafehErsal
        '
        Me.mnuHavalehEzafehErsal.AppName = "mnuHavalehEzafehErsal"
        Me.mnuHavalehEzafehErsal.Name = "mnuHavalehEzafehErsal"
        Me.mnuHavalehEzafehErsal.Size = New System.Drawing.Size(250, 22)
        Me.mnuHavalehEzafehErsal.Text = "حواله اضافه ارسال به شرکتهای گروه"
        Me.mnuHavalehEzafehErsal.ToolTipText = "این تراکنش هنگامی که کالای ارسال شده از سند ثبت شده بیشتر است توسط واحد ارسال کنن" &
    "ده ثبت می شود _ اصلاحی کاهنده"
        '
        'mnuResideEzafehDryaft
        '
        Me.mnuResideEzafehDryaft.AppName = "mnuResideEzafehDryaft"
        Me.mnuResideEzafehDryaft.Name = "mnuResideEzafehDryaft"
        Me.mnuResideEzafehDryaft.Size = New System.Drawing.Size(250, 22)
        Me.mnuResideEzafehDryaft.Text = "رسید اضافه دریافت از شرکتهای گروه"
        Me.mnuResideEzafehDryaft.ToolTipText = "این تراکنش سند مقابل حواله اضافه ارسال می باشد و بصورت ماشینی ثبت می شود _ اصلاحی" &
    " افزاینده"
        '
        'mnuSepDarkhastha
        '
        Me.mnuSepDarkhastha.AppName = "mnuSepDarkhastha"
        Me.mnuSepDarkhastha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDarkhast, Me.mnuDarkhastKharidDakheli, Me.mnuDarkhastKharidKhareji, Me.mnuTafkik_Ghaza, Me.mnuTafkik_Daroo})
        Me.mnuSepDarkhastha.Name = "mnuSepDarkhastha"
        Me.mnuSepDarkhastha.Size = New System.Drawing.Size(267, 22)
        Me.mnuSepDarkhastha.Text = "درخواستها"
        '
        'mnuDarkhast
        '
        Me.mnuDarkhast.AppName = "mnuDarkhast"
        Me.mnuDarkhast.Name = "mnuDarkhast"
        Me.mnuDarkhast.Size = New System.Drawing.Size(183, 22)
        Me.mnuDarkhast.Text = "درخواست کالا از انبار"
        '
        'mnuDarkhastKharidDakheli
        '
        Me.mnuDarkhastKharidDakheli.AppName = "mnuDarkhastKharidDakheli"
        Me.mnuDarkhastKharidDakheli.Name = "mnuDarkhastKharidDakheli"
        Me.mnuDarkhastKharidDakheli.Size = New System.Drawing.Size(183, 22)
        Me.mnuDarkhastKharidDakheli.Text = "درخواست خرید داخلی"
        '
        'mnuDarkhastKharidKhareji
        '
        Me.mnuDarkhastKharidKhareji.AppName = "mnuDarkhastKharidKhareji"
        Me.mnuDarkhastKharidKhareji.Name = "mnuDarkhastKharidKhareji"
        Me.mnuDarkhastKharidKhareji.Size = New System.Drawing.Size(183, 22)
        Me.mnuDarkhastKharidKhareji.Text = "درخواست خرید خارجی"
        '
        'mnuTafkik_Ghaza
        '
        Me.mnuTafkik_Ghaza.AppName = "mnuTafkik_Ghaza"
        Me.mnuTafkik_Ghaza.Name = "mnuTafkik_Ghaza"
        Me.mnuTafkik_Ghaza.Size = New System.Drawing.Size(183, 22)
        Me.mnuTafkik_Ghaza.Text = "لیست تفکیک غذایی"
        '
        'mnuTafkik_Daroo
        '
        Me.mnuTafkik_Daroo.AppName = "mnuTafkik_Daroo"
        Me.mnuTafkik_Daroo.Name = "mnuTafkik_Daroo"
        Me.mnuTafkik_Daroo.Size = New System.Drawing.Size(183, 22)
        Me.mnuTafkik_Daroo.Text = "برنامه ریزی ارسال کالا"
        '
        'mnurptDarkhastKharid
        '
        Me.mnurptDarkhastKharid.AppName = "mnurptDarkhastKharid"
        Me.mnurptDarkhastKharid.Name = "mnurptDarkhastKharid"
        Me.mnurptDarkhastKharid.Size = New System.Drawing.Size(32, 19)
        Me.mnurptDarkhastKharid.Text = "درخواست خرید کالا"
        '
        'mnuSepEslahiha
        '
        Me.mnuSepEslahiha.AppName = "mnuSepEslahiha"
        Me.mnuSepEslahiha.Name = "mnuSepEslahiha"
        Me.mnuSepEslahiha.Size = New System.Drawing.Size(198, 22)
        Me.mnuSepEslahiha.Text = "اسناد اصلاحي"
        '
        'mnuEslaheTarafHesab
        '
        Me.mnuEslaheTarafHesab.AppName = "mnuEslaheTarafHesab"
        Me.mnuEslaheTarafHesab.Name = "mnuEslaheTarafHesab"
        Me.mnuEslaheTarafHesab.Size = New System.Drawing.Size(166, 22)
        Me.mnuEslaheTarafHesab.Text = "اصلاح طرف حساب"
        '
        'mnuMojoodiha
        '
        Me.mnuMojoodiha.AppName = "mnuMojoodiha"
        Me.mnuMojoodiha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResideBargashti, Me.mnuHavalehBargashti, Me.mnuEslaheTarafHesab})
        Me.mnuMojoodiha.Name = "mnuMojoodiha"
        Me.mnuMojoodiha.Size = New System.Drawing.Size(198, 22)
        Me.mnuMojoodiha.Text = "موجودی اول دوره"
        '
        'mnuEslaheTarafHesabKharid
        '
        Me.mnuEslaheTarafHesabKharid.AppName = "mnuEslaheTarafHesabKharid"
        Me.mnuEslaheTarafHesabKharid.Name = "mnuEslaheTarafHesabKharid"
        Me.mnuEslaheTarafHesabKharid.Size = New System.Drawing.Size(157, 22)
        Me.mnuEslaheTarafHesabKharid.Text = "اصلاح طرف حساب خرید"
        '
        'mnuSep35
        '
        Me.mnuSep35.Name = "mnuSep35"
        Me.mnuSep35.Size = New System.Drawing.Size(195, 6)
        '
        'MnuZayeatKartabl
        '
        Me.MnuZayeatKartabl.AppName = "MnuZayeatKartabl"
        Me.MnuZayeatKartabl.Name = "MnuZayeatKartabl"
        Me.MnuZayeatKartabl.Size = New System.Drawing.Size(267, 22)
        Me.MnuZayeatKartabl.Text = "کارتابل ضایعات"
        '
        'MnuZayeatKartablRole
        '
        Me.MnuZayeatKartablRole.AppName = "MnuZayeatKartablRole"
        Me.MnuZayeatKartablRole.Name = "MnuZayeatKartablRole"
        Me.MnuZayeatKartablRole.Size = New System.Drawing.Size(267, 22)
        Me.MnuZayeatKartablRole.Text = "تعریف دسترسی های کارتابل ضایعات"
        '
        'MnuZayeatKartablReport
        '
        Me.MnuZayeatKartablReport.AppName = "MnuZayeatKartablReport"
        Me.MnuZayeatKartablReport.Name = "MnuZayeatKartablReport"
        Me.MnuZayeatKartablReport.Size = New System.Drawing.Size(267, 22)
        Me.MnuZayeatKartablReport.Text = "گزارش اسناد ضایعات"
        '
        'MnuSanadBarcodeReader
        '
        Me.MnuSanadBarcodeReader.AppName = "MnuSanadBarcodeReader"
        Me.MnuSanadBarcodeReader.Name = "MnuSanadBarcodeReader"
        Me.MnuSanadBarcodeReader.Size = New System.Drawing.Size(32, 19)
        Me.MnuSanadBarcodeReader.Text = "اسناد بارکد خوان"
        '
        'mnuQC
        '
        Me.mnuQC.AppName = "mnuQC"
        Me.mnuQC.Name = "mnuQC"
        Me.mnuQC.Size = New System.Drawing.Size(267, 22)
        Me.mnuQC.Text = "كنترل كيفيت"
        '
        'mnuSep36
        '
        Me.mnuSep36.Name = "mnuSep36"
        Me.mnuSep36.Size = New System.Drawing.Size(264, 6)
        '
        'mnuGetSanadAnbar
        '
        Me.mnuGetSanadAnbar.AppName = "mnuGetSanadAnbar"
        Me.mnuGetSanadAnbar.Name = "mnuGetSanadAnbar"
        Me.mnuGetSanadAnbar.Size = New System.Drawing.Size(267, 22)
        Me.mnuGetSanadAnbar.Text = "دريافت فايل اسناد انبار"
        '
        'mnuErsalFile
        '
        Me.mnuErsalFile.AppName = "mnuErsalFile"
        Me.mnuErsalFile.Name = "mnuErsalFile"
        Me.mnuErsalFile.Size = New System.Drawing.Size(267, 22)
        Me.mnuErsalFile.Text = "تهيه فايل جهت ارسال به مرکز"
        '
        'mnuSep62
        '
        Me.mnuSep62.Name = "mnuSep62"
        Me.mnuSep62.Size = New System.Drawing.Size(264, 6)
        '
        'mnuDarjSanadAsAnbarBeAnbar81_31
        '
        Me.mnuDarjSanadAsAnbarBeAnbar81_31.AppName = "mnuDarjSanadAsAnbarBeAnbar81_31"
        Me.mnuDarjSanadAsAnbarBeAnbar81_31.Name = "mnuDarjSanadAsAnbarBeAnbar81_31"
        Me.mnuDarjSanadAsAnbarBeAnbar81_31.Size = New System.Drawing.Size(267, 22)
        Me.mnuDarjSanadAsAnbarBeAnbar81_31.Text = "ارسال حواله ضايعات به انبار ضايعات"
        '
        'mnuSep34
        '
        Me.mnuSep34.Name = "mnuSep34"
        Me.mnuSep34.Size = New System.Drawing.Size(264, 6)
        '
        'mnu_RialeVaredeh
        '
        Me.mnu_RialeVaredeh.AppName = "mnu_RialeVaredeh"
        Me.mnu_RialeVaredeh.Name = "mnu_RialeVaredeh"
        Me.mnu_RialeVaredeh.Size = New System.Drawing.Size(267, 22)
        Me.mnu_RialeVaredeh.Text = "ريال واقعي اسناد وارده"
        '
        'mnu__abSpr_Mojoodi
        '
        Me.mnu__abSpr_Mojoodi.AppName = "mnu__abSpr_Mojoodi"
        Me.mnu__abSpr_Mojoodi.Name = "mnu__abSpr_Mojoodi"
        Me.mnu__abSpr_Mojoodi.Size = New System.Drawing.Size(259, 22)
        Me.mnu__abSpr_Mojoodi.Text = "موجودي انبار"
        '
        'mnuMojudiWithIRC_GTIN
        '
        Me.mnuMojudiWithIRC_GTIN.AppName = "mnuMojudiWithIRC_GTIN"
        Me.mnuMojudiWithIRC_GTIN.Name = "mnuMojudiWithIRC_GTIN"
        Me.mnuMojudiWithIRC_GTIN.Size = New System.Drawing.Size(259, 22)
        Me.mnuMojudiWithIRC_GTIN.Text = "موجودی دارو بر اساس IRC و GTIN"
        '
        'mnu__MoghayerateCatalogueMahsoolatBaSystemMap
        '
        Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap.AppName = "mnu__MoghayerateCatalogueMahsoolatBaSystemMap"
        Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap.Name = "mnu__MoghayerateCatalogueMahsoolatBaSystemMap"
        Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap.Size = New System.Drawing.Size(259, 22)
        Me.mnu__MoghayerateCatalogueMahsoolatBaSystemMap.Text = "گزارش مغایرت کاتالوگ محصولات با سیستم مپ"
        '
        'mnu__ListMahsulateBarcodkhan
        '
        Me.mnu__ListMahsulateBarcodkhan.AppName = "mnu__ListMahsulateBarcodkhan"
        Me.mnu__ListMahsulateBarcodkhan.Name = "mnu__ListMahsulateBarcodkhan"
        Me.mnu__ListMahsulateBarcodkhan.Size = New System.Drawing.Size(259, 22)
        Me.mnu__ListMahsulateBarcodkhan.Text = "لیست محصولات بارکد خوان(تخصیص محصول)؛"

        '
        'mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan
        '14030324 کوه دار
        Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan.AppName = "mnu_ReportAghlamTarikhNazdikeAsnadBarcodKhan"
        Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan.Name = "mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan"
        Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan.Size = New Size(256, 22)
        Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan.Text = "گزارش اقلام تاریخ نزدیک دارو"
        '14030324 کوه دار

        '
        'mnu__ShomarehBachhayeSabtNashodehHamlMostaghim
        '
        Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.AppName = "mnu__ShomarehBachhayeSabtNashodehHamlMostaghim"
        Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.Name = "mnu__ShomarehBachhayeSabtNashodehHamlMostaghim"
        Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.Size = New System.Drawing.Size(259, 22)
        Me.mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.Text = "گزارش شماره بچ های ثبت نشده رسیدهای حمل مستقیم مشتری"
        '
        'mnuTafsiliA
        '
        Me.mnuTafsiliA.AppName = "mnuTafsiliA"
        Me.mnuTafsiliA.Name = "mnuTafsiliA"
        Me.mnuTafsiliA.Size = New System.Drawing.Size(259, 22)
        Me.mnuTafsiliA.Text = "مرور تفصيلي اسناد"
        '
        'mnuMasrafeMavad
        '
        Me.mnuMasrafeMavad.AppName = "mnuMasrafeMavad"
        Me.mnuMasrafeMavad.Name = "mnuMasrafeMavad"
        Me.mnuMasrafeMavad.Size = New System.Drawing.Size(259, 22)
        Me.mnuMasrafeMavad.Text = "مصرف مواد"
        '
        'mnuKardex
        '
        Me.mnuKardex.AppName = "mnuKardex"
        Me.mnuKardex.Name = "mnuKardex"
        Me.mnuKardex.Size = New System.Drawing.Size(238, 22)
        Me.mnuKardex.Text = "گزارش چاپ كاردكس كالا"
        '
        'mnuControlKardex
        '
        Me.mnuControlKardex.AppName = "mnuControlKardex"
        Me.mnuControlKardex.Name = "mnuControlKardex"
        Me.mnuControlKardex.Size = New System.Drawing.Size(238, 22)
        Me.mnuControlKardex.Text = "گزارش کنترل کاردکس"
        '
        'mnuRptQCIntervals
        '
        Me.mnuRptQCIntervals.AppName = "mnuRptQCIntervals"
        Me.mnuRptQCIntervals.Name = "mnuRptQCIntervals"
        Me.mnuRptQCIntervals.Size = New System.Drawing.Size(236, 22)
        Me.mnuRptQCIntervals.Text = "گزارش فاصله زمانی کنترل کیفیت"
        '
        'mnuEslaheSanad
        '
        Me.mnuEslaheSanad.AppName = "mnuEslaheSanad"
        Me.mnuEslaheSanad.Name = "mnuEslaheSanad"
        Me.mnuEslaheSanad.Size = New System.Drawing.Size(236, 22)
        Me.mnuEslaheSanad.Text = "اصلاح سند"
        '
        'mnuChapeSanad
        '
        Me.mnuChapeSanad.AppName = "mnuChapeSanad"
        Me.mnuChapeSanad.Name = "mnuChapeSanad"
        Me.mnuChapeSanad.Size = New System.Drawing.Size(259, 22)
        Me.mnuChapeSanad.Text = "چاپ اسناد"
        '
        'mnuSep69
        '
        Me.mnuSep69.Name = "mnuSep69"
        Me.mnuSep69.Size = New System.Drawing.Size(256, 6)
        '
        'mnuRptAmalKard
        '
        Me.mnuRptAmalKard.AppName = "mnuRptAmalKard"
        Me.mnuRptAmalKard.Name = "mnuRptAmalKard"
        Me.mnuRptAmalKard.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptAmalKard.Text = "عملکرد انبار"
        '
        'mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh
        '
        Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.AppName = "ReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh"
        Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.Name = "mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh"
        Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.Size = New System.Drawing.Size(259, 40)
        Me.mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.Text = "گزارش عدم رعایت اولویت بندی تاریخ انقضا در صدور حواله"
        '
        'mnuRptVaredehMojaz
        '
        Me.mnuRptVaredehMojaz.AppName = "mnuRptVaredehMojaz"
        Me.mnuRptVaredehMojaz.Name = "mnuRptVaredehMojaz"
        Me.mnuRptVaredehMojaz.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptVaredehMojaz.Text = "مقدار وارده مجاز"
        '
        'mnuRptRezerv
        '
        Me.mnuRptRezerv.AppName = "mnuRptRezerv"
        Me.mnuRptRezerv.Name = "mnuRptRezerv"
        Me.mnuRptRezerv.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptRezerv.Text = " رزرو"
        '
        'mnuCheckBarcode
        '
        Me.mnuCheckBarcode.AppName = "mnuCheckBarcode"
        Me.mnuCheckBarcode.Name = "mnuCheckBarcode"
        Me.mnuCheckBarcode.Size = New System.Drawing.Size(259, 22)
        Me.mnuCheckBarcode.Text = " چک بارکد"
        '
        'mnuSep77
        '
        Me.mnuSep77.Name = "mnuSep77"
        Me.mnuSep77.Size = New System.Drawing.Size(195, 6)
        '
        'mnuSep78
        '
        Me.mnuSep78.Name = "mnuSep78"
        Me.mnuSep78.Size = New System.Drawing.Size(6, 6)
        '
        'mnuSep79
        '
        Me.mnuSep79.Name = "mnuSep79"
        Me.mnuSep79.Size = New System.Drawing.Size(6, 6)
        '
        'mnuSep75
        '
        Me.mnuSep75.Name = "mnuSep75"
        Me.mnuSep75.Size = New System.Drawing.Size(6, 6)
        '
        'mnuEzafiMojoodiAnbar
        '
        Me.mnuEzafiMojoodiAnbar.AppName = "mnuEzafiMojoodiAnbar"
        Me.mnuEzafiMojoodiAnbar.Name = "mnuEzafiMojoodiAnbar"
        Me.mnuEzafiMojoodiAnbar.Size = New System.Drawing.Size(198, 22)
        Me.mnuEzafiMojoodiAnbar.Text = "اضافي موجودي انبار"
        '
        'mnuKasriMojoodiAnbar
        '
        Me.mnuKasriMojoodiAnbar.AppName = "mnuKasriMojoodiAnbar"
        Me.mnuKasriMojoodiAnbar.Name = "mnuKasriMojoodiAnbar"
        Me.mnuKasriMojoodiAnbar.Size = New System.Drawing.Size(198, 22)
        Me.mnuKasriMojoodiAnbar.Text = "کسری موجودي انبار"
        '
        'mnuAnbar
        '
        Me.mnuAnbar.AppName = "mnuAnbar"
        Me.mnuAnbar.Name = "mnuAnbar"
        Me.mnuAnbar.Size = New System.Drawing.Size(251, 22)
        Me.mnuAnbar.Text = "تعريف انبار"
        '
        'mnuSep84
        '
        Me.mnuSep84.Name = "mnuSep84"
        Me.mnuSep84.Size = New System.Drawing.Size(264, 6)
        '
        'mnuSelectAnbar
        '
        Me.mnuSelectAnbar.AppName = "mnuSelectAnbar"
        Me.mnuSelectAnbar.Name = "mnuSelectAnbar"
        Me.mnuSelectAnbar.Size = New System.Drawing.Size(267, 22)
        Me.mnuSelectAnbar.Text = "انتخاب انبار"
        '
        'mnuSelectCurrentSal
        '
        Me.mnuSelectCurrentSal.AppName = "mnuSelectCurrentSal"
        Me.mnuSelectCurrentSal.Name = "mnuSelectCurrentSal"
        Me.mnuSelectCurrentSal.Size = New System.Drawing.Size(267, 22)
        Me.mnuSelectCurrentSal.Text = "انتخاب سال مالي"
        '
        'mnuMojoodiB
        '
        Me.mnuMojoodiB.AppName = "mnuMojoodiB"
        Me.mnuMojoodiB.Name = "mnuMojoodiB"
        Me.mnuMojoodiB.Size = New System.Drawing.Size(259, 22)
        Me.mnuMojoodiB.Text = "موجودي  به تفکيک نوع مرجوعي"
        '
        'mnuChideman
        '
        Me.mnuChideman.AppName = "mnuChideman"
        Me.mnuChideman.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuabNoeChideman, Me.mnuabSharayeteMohiti, Me.mnuSep98, Me.mnuabChideman, Me.mnuSep102, Me.mnuabChidemanSharayet, Me.mnuabSharayeteKala, Me.mnuSep103, Me.mnuabKalaChideman})
        Me.mnuChideman.Name = "mnuChideman"
        Me.mnuChideman.Size = New System.Drawing.Size(267, 22)
        Me.mnuChideman.Text = "چيدمان"
        '
        'mnuabNoeChideman
        '
        Me.mnuabNoeChideman.AppName = "mnuabNoeChideman"
        Me.mnuabNoeChideman.Name = "mnuabNoeChideman"
        Me.mnuabNoeChideman.Size = New System.Drawing.Size(319, 22)
        Me.mnuabNoeChideman.Text = "تعريف انواع جايگاه ها ي نگهداري"
        '
        'mnuabSharayeteMohiti
        '
        Me.mnuabSharayeteMohiti.AppName = "mnuabSharayeteMohiti"
        Me.mnuabSharayeteMohiti.Name = "mnuabSharayeteMohiti"
        Me.mnuabSharayeteMohiti.Size = New System.Drawing.Size(319, 22)
        Me.mnuabSharayeteMohiti.Text = "تعريف شرايط محيطي"
        '
        'mnuSep98
        '
        Me.mnuSep98.Name = "mnuSep98"
        Me.mnuSep98.Size = New System.Drawing.Size(316, 6)
        '
        'mnuabChideman
        '
        Me.mnuabChideman.AppName = "mnuabChideman"
        Me.mnuabChideman.Name = "mnuabChideman"
        Me.mnuabChideman.Size = New System.Drawing.Size(319, 22)
        Me.mnuabChideman.Text = "تعريف جايگاه هاي نگهداري کالا"
        '
        'mnuSep102
        '
        Me.mnuSep102.Name = "mnuSep102"
        Me.mnuSep102.Size = New System.Drawing.Size(316, 6)
        '
        'mnuabChidemanSharayet
        '
        Me.mnuabChidemanSharayet.AppName = "mnuabChidemanSharayet"
        Me.mnuabChidemanSharayet.Name = "mnuabChidemanSharayet"
        Me.mnuabChidemanSharayet.Size = New System.Drawing.Size(319, 22)
        Me.mnuabChidemanSharayet.Text = "تعريف شرايط محيطي جايگاههاي نگهداري"
        '
        'mnuabSharayeteKala
        '
        Me.mnuabSharayeteKala.AppName = "mnuabSharayeteKala"
        Me.mnuabSharayeteKala.Name = "mnuabSharayeteKala"
        Me.mnuabSharayeteKala.Size = New System.Drawing.Size(319, 22)
        Me.mnuabSharayeteKala.Text = "محدوديت هاي نگهداشت کالا در جايگاههاي نگهداري"
        '
        'mnuSep103
        '
        Me.mnuSep103.Name = "mnuSep103"
        Me.mnuSep103.Size = New System.Drawing.Size(316, 6)
        '
        'mnuabKalaChideman
        '
        Me.mnuabKalaChideman.AppName = "mnuabKalaChideman"
        Me.mnuabKalaChideman.Name = "mnuabKalaChideman"
        Me.mnuabKalaChideman.Size = New System.Drawing.Size(319, 22)
        Me.mnuabKalaChideman.Text = "تخصيص کالافيزيکي به جايگاههاي نگهداري"
        '
        'mnuSep97
        '
        Me.mnuSep97.Name = "mnuSep97"
        Me.mnuSep97.Size = New System.Drawing.Size(264, 6)
        '
        'MnuAnbarGardaniMain
        '
        Me.MnuAnbarGardaniMain.AppName = "MnuAnbarGardaniMain"
        Me.MnuAnbarGardaniMain.Name = "MnuAnbarGardaniMain"
        Me.MnuAnbarGardaniMain.Size = New System.Drawing.Size(267, 22)
        Me.MnuAnbarGardaniMain.Text = "عملیات انبارگردانی"
        '
        'MnuAnbarGardani
        '
        Me.MnuAnbarGardani.AppName = "MnuAnbarGardani"
        Me.MnuAnbarGardani.Name = "MnuAnbarGardani"
        Me.MnuAnbarGardani.Size = New System.Drawing.Size(267, 22)
        Me.MnuAnbarGardani.Text = "انبارگردانی پایان دوره"
        '
        'MnuAnbarGardaniEnghezaDate
        '
        Me.MnuAnbarGardaniEnghezaDate.AppName = "MnuAnbarGardaniEnghezaDate"
        Me.MnuAnbarGardaniEnghezaDate.Name = "MnuAnbarGardaniEnghezaDate"
        Me.MnuAnbarGardaniEnghezaDate.Size = New System.Drawing.Size(291, 22)
        Me.MnuAnbarGardaniEnghezaDate.Text = "انبارگردانی بر اساس تاریخ انقضا"
        '
        'MnuAnbarGardaniMianDoreh
        '
        Me.MnuAnbarGardaniMianDoreh.AppName = "MnuAnbarGardaniMianDoreh"
        Me.MnuAnbarGardaniMianDoreh.Name = "MnuAnbarGardaniMianDoreh"
        Me.MnuAnbarGardaniMianDoreh.Size = New System.Drawing.Size(291, 22)
        Me.MnuAnbarGardaniMianDoreh.Text = "انبارگردانی میان دوره"
        '
        'MnuAnbarGardaniSemat
        '
        Me.MnuAnbarGardaniSemat.AppName = "MnuAnbarGardaniSemat"
        Me.MnuAnbarGardaniSemat.Name = "MnuAnbarGardaniSemat"
        Me.MnuAnbarGardaniSemat.Size = New System.Drawing.Size(291, 22)
        Me.MnuAnbarGardaniSemat.Text = "تعريف سمت هاي انبارگرداني"
        '
        'MnuShomarandeh
        '
        Me.MnuShomarandeh.AppName = "MnuShomarandeh"
        Me.MnuShomarandeh.Name = "MnuShomarandeh"
        Me.MnuShomarandeh.Size = New System.Drawing.Size(291, 22)
        Me.MnuShomarandeh.Text = "تعريف شمارندگان"
        '
        'MnuShomareshHa
        '
        Me.MnuShomareshHa.AppName = "MnuShomareshHa"
        Me.MnuShomareshHa.Name = "MnuShomareshHa"
        Me.MnuShomareshHa.Size = New System.Drawing.Size(291, 22)
        Me.MnuShomareshHa.Text = "ثبت شمارش ها"
        '
        'MnuSarakKasri
        '
        Me.MnuSarakKasri.AppName = "MnuSarakKasri"
        Me.MnuSarakKasri.Name = "MnuSarakKasri"
        Me.MnuSarakKasri.Size = New System.Drawing.Size(291, 22)
        Me.MnuSarakKasri.Text = "ثبت اسناد کسري و اضافي انبارگرداني"
        '
        'MnuDarjAvalDoreh
        '
        Me.MnuDarjAvalDoreh.AppName = "MnuDarjAvalDoreh"
        Me.MnuDarjAvalDoreh.Name = "MnuDarjAvalDoreh"
        Me.MnuDarjAvalDoreh.Size = New System.Drawing.Size(291, 22)
        Me.MnuDarjAvalDoreh.Text = "انتقال موجودي اول دوره"
        '
        'MnuTafkikRahgiri
        '
        Me.MnuTafkikRahgiri.AppName = "MnuTafkikRahgiri"
        Me.MnuTafkikRahgiri.Name = "MnuTafkikRahgiri"
        Me.MnuTafkikRahgiri.Size = New System.Drawing.Size(291, 22)
        Me.MnuTafkikRahgiri.Text = "تفکيک کد رهگيري موجودي اول دوره و ثبت سند"
        '
        'mnuSep101
        '
        Me.mnuSep101.Name = "mnuSep101"
        Me.mnuSep101.Size = New System.Drawing.Size(256, 6)
        '
        'mnuRptAnbarGardani
        '
        Me.mnuRptAnbarGardani.AppName = "mnuRptAnbarGardani"
        Me.mnuRptAnbarGardani.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRptSooratjalaseAnbarGardani, Me.mnuRptTagAnbarGardani, Me.mnuRptMoghayratBienShomaresh, Me.mnuRptMoghayratAnbarGardani, Me.mnuRepAnbarGardaniEnghezaDate})
        Me.mnuRptAnbarGardani.Name = "mnuRptAnbarGardani"
        Me.mnuRptAnbarGardani.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptAnbarGardani.Text = "گزارش هاي انبارگرداني"

        '
        'mnuRptAsnadBarcodeKhan
        '
        Me.mnuRptAsnadBarcodeKhan.AppName = "mnuRptAsnadBarcodeKhan"
        Me.mnuRptAsnadBarcodeKhan.DropDownItems.AddRange(New ToolStripItem() {Me.mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan})
        Me.mnuRptAsnadBarcodeKhan.Name = "mnuRptAsnadBarcodeKhan"
        Me.mnuRptAsnadBarcodeKhan.Size = New Drawing.Size(259, 22)
        Me.mnuRptAsnadBarcodeKhan.Text = "گزارش های اسناد بارکد خوان"

        '
        'mnuRptSooratjalaseAnbarGardani
        '
        Me.mnuRptSooratjalaseAnbarGardani.AppName = "mnuRptSooratjalaseAnbarGardani"
        Me.mnuRptSooratjalaseAnbarGardani.Name = "mnuRptSooratjalaseAnbarGardani"
        Me.mnuRptSooratjalaseAnbarGardani.Size = New System.Drawing.Size(269, 22)
        Me.mnuRptSooratjalaseAnbarGardani.Text = "آخرين اسناد"
        '
        'mnuRptTagAnbarGardani
        '
        Me.mnuRptTagAnbarGardani.AppName = "mnuRptTagAnbarGardani"
        Me.mnuRptTagAnbarGardani.Name = "mnuRptTagAnbarGardani"
        Me.mnuRptTagAnbarGardani.Size = New System.Drawing.Size(269, 22)
        Me.mnuRptTagAnbarGardani.Text = "چاپ تگ انبارگرداني"
        '
        'mnuRptMoghayratBienShomaresh
        '
        Me.mnuRptMoghayratBienShomaresh.AppName = "mnuRptMoghayratBienShomaresh"
        Me.mnuRptMoghayratBienShomaresh.Name = "mnuRptMoghayratBienShomaresh"
        Me.mnuRptMoghayratBienShomaresh.Size = New System.Drawing.Size(269, 22)
        Me.mnuRptMoghayratBienShomaresh.Text = "مغايرت مابين شمارش ها"
        '
        'mnuRptMoghayratAnbarGardani
        '
        Me.mnuRptMoghayratAnbarGardani.AppName = "mnuRptMoghayratAnbarGardani"
        Me.mnuRptMoghayratAnbarGardani.Name = "mnuRptMoghayratAnbarGardani"
        Me.mnuRptMoghayratAnbarGardani.Size = New System.Drawing.Size(269, 22)
        Me.mnuRptMoghayratAnbarGardani.Text = "مغايرت انبارگرداني اول دوره با پایان دوره"
        '
        'mnuRepAnbarGardaniEnghezaDate
        '
        Me.mnuRepAnbarGardaniEnghezaDate.AppName = "mnuRepAnbarGardaniEnghezaDate"
        Me.mnuRepAnbarGardaniEnghezaDate.Name = "mnuRepAnbarGardaniEnghezaDate"
        Me.mnuRepAnbarGardaniEnghezaDate.Size = New System.Drawing.Size(269, 22)
        Me.mnuRepAnbarGardaniEnghezaDate.Text = "گزارش انبارگردانی تاریخ انقضا"
        '
        'mnuRTarakoneshGorooh
        '
        Me.mnuRTarakoneshGorooh.AppName = "mnuRTarakoneshGorooh"
        Me.mnuRTarakoneshGorooh.Name = "mnuRTarakoneshGorooh"
        Me.mnuRTarakoneshGorooh.Size = New System.Drawing.Size(188, 22)
        Me.mnuRTarakoneshGorooh.Text = "گروه بندي تراکنش ها"
        '
        'mnuRptNegasht
        '
        Me.mnuRptNegasht.AppName = "mnuRptNegasht"
        Me.mnuRptNegasht.Name = "mnuRptNegasht"
        Me.mnuRptNegasht.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptNegasht.Text = "کنترل اسناد انبار"
        '
        'mnuDarjSanadAsAnbarBeAnbar65_5_2
        '
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_2.AppName = "mnuDarjSanadAsAnbarBeAnbar65_5_2"
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_2.Name = "mnuDarjSanadAsAnbarBeAnbar65_5_2"
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_2.Size = New System.Drawing.Size(267, 22)
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_2.Text = "ارسال حواله انبار به انبار به انبار محصول"
        '
        'mnuDarjSanadAsAnbarBeAnbar65_5_5
        '
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_5.AppName = "mnuDarjSanadAsAnbarBeAnbar65_5_5"
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_5.Name = "mnuDarjSanadAsAnbarBeAnbar65_5_5"
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_5.Size = New System.Drawing.Size(267, 22)
        Me.mnuDarjSanadAsAnbarBeAnbar65_5_5.Text = "ارسال حواله انبار به انبار به انبار ضايعات"
        '
        'mnuSefareshParam
        '
        Me.mnuSefareshParam.AppName = "mnuSefareshParam"
        Me.mnuSefareshParam.Name = "mnuSefareshParam"
        Me.mnuSefareshParam.Size = New System.Drawing.Size(259, 22)
        Me.mnuSefareshParam.Text = "گزارش نقطه سفارش"
        '
        'mnuSodorSanadAsMojodiBeAnbar10
        '
        Me.mnuSodorSanadAsMojodiBeAnbar10.AppName = "mnuSodorSanadAsMojodiBeAnbar10"
        Me.mnuSodorSanadAsMojodiBeAnbar10.Name = "mnuSodorSanadAsMojodiBeAnbar10"
        Me.mnuSodorSanadAsMojodiBeAnbar10.Size = New System.Drawing.Size(267, 22)
        Me.mnuSodorSanadAsMojodiBeAnbar10.Text = "صدور حواله با مانده به تفکيک نوع مرجوعي"
        '
        'mnuKardexList
        '
        Me.mnuKardexList.AppName = "mnuKardexList"
        Me.mnuKardexList.Name = "mnuKardexList"
        Me.mnuKardexList.Size = New System.Drawing.Size(259, 22)
        Me.mnuKardexList.Text = " کاردکس کالا"
        '
        'mnuUpdateSanadDate
        '
        Me.mnuUpdateSanadDate.AppName = "mnuUpdateSanadDate"
        Me.mnuUpdateSanadDate.Name = "mnuUpdateSanadDate"
        Me.mnuUpdateSanadDate.Size = New System.Drawing.Size(267, 22)
        Me.mnuUpdateSanadDate.Text = "بروزآوري تاريخ اسناد پيشنويس و موقت"
        '
        'mnuSep74
        '
        Me.mnuSep74.Name = "mnuSep74"
        Me.mnuSep74.Size = New System.Drawing.Size(248, 6)
        '
        'MnuTashimPattern
        '
        Me.MnuTashimPattern.AppName = "MnuTashimPattern"
        Me.MnuTashimPattern.Name = "MnuTashimPattern"
        Me.MnuTashimPattern.Size = New System.Drawing.Size(251, 22)
        Me.MnuTashimPattern.Text = "الگوي تسهيم نرخ خريد"
        '
        'MnuResideMarjooeAzTozie
        '
        Me.MnuResideMarjooeAzTozie.AppName = "MnuResideMarjooeAzTozie"
        Me.MnuResideMarjooeAzTozie.Name = "MnuResideMarjooeAzTozie"
        Me.MnuResideMarjooeAzTozie.Size = New System.Drawing.Size(198, 22)
        Me.MnuResideMarjooeAzTozie.Text = "رسيد مرجوعي از توزيع"
        '
        'mnuSep38
        '
        Me.mnuSep38.Name = "mnuSep38"
        Me.mnuSep38.Size = New System.Drawing.Size(195, 6)
        '
        'mnuSep39
        '
        Me.mnuSep39.Name = "mnuSep39"
        Me.mnuSep39.Size = New System.Drawing.Size(195, 6)
        '
        'mnuBeinAnbarControlReport
        '
        Me.mnuBeinAnbarControlReport.AppName = "mnuBeinAnbarControlReport"
        Me.mnuBeinAnbarControlReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTahvilBeGoroohReport, Me.mnuKardex, Me.mnuControlKardex})
        Me.mnuBeinAnbarControlReport.Name = "mnuBeinAnbarControlReport"
        Me.mnuBeinAnbarControlReport.Size = New System.Drawing.Size(259, 22)
        Me.mnuBeinAnbarControlReport.Text = "گزارش هاي کنترلي بين انبارها"
        '
        'mnuTahvilBeGoroohReport
        '
        Me.mnuTahvilBeGoroohReport.AppName = "mnuTahvilBeGoroohReport"
        Me.mnuTahvilBeGoroohReport.Name = "mnuTahvilBeGoroohReport"
        Me.mnuTahvilBeGoroohReport.Size = New System.Drawing.Size(238, 22)
        Me.mnuTahvilBeGoroohReport.Text = "حواله هاي تحويل به شرکتهاي گروه"
        '
        'mnuRptMTS
        '
        Me.mnuRptMTS.AppName = "mnuRptMTS"
        Me.mnuRptMTS.Name = "mnuRptMTS"
        Me.mnuRptMTS.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptMTS.Text = "گزارش کالاهاي با موجودي کمتر از حداقل"
        '
        'mnuRptRaked
        '
        Me.mnuRptRaked.AppName = "mnuRptRaked"
        Me.mnuRptRaked.Name = "mnuRptRaked"
        Me.mnuRptRaked.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptRaked.Text = "کالاهای راکد"
        '
        'mnuRptMoghayeratSanadMaliStandard
        '
        Me.mnuRptMoghayeratSanadMaliStandard.AppName = "mnuRptMoghayeratSanadMaliStandard"
        Me.mnuRptMoghayeratSanadMaliStandard.Name = "mnuRptMoghayeratSanadMaliStandard"
        Me.mnuRptMoghayeratSanadMaliStandard.Size = New System.Drawing.Size(32, 19)
        Me.mnuRptMoghayeratSanadMaliStandard.Text = "مغایرت سند استاندارد مالی و انبار"
        '
        'MnuAlarmMojoodi
        '
        Me.MnuAlarmMojoodi.AppName = "MnuAlarmMojoodi"
        Me.MnuAlarmMojoodi.Name = "MnuAlarmMojoodi"
        Me.MnuAlarmMojoodi.Size = New System.Drawing.Size(259, 22)
        Me.MnuAlarmMojoodi.Text = "گزارش مقایسه ای موجودی با حداکثر مجاز"
        '
        'mnuBarnameh
        '
        Me.mnuBarnameh.AppName = "mnuBarnameh"
        Me.mnuBarnameh.Name = "mnuBarnameh"
        Me.mnuBarnameh.Size = New System.Drawing.Size(198, 22)
        Me.mnuBarnameh.Text = "بارنامه"
        '
        'mnuSep40
        '
        Me.mnuSep40.Name = "mnuSep40"
        Me.mnuSep40.Size = New System.Drawing.Size(264, 6)
        '
        'mnurptDarkhast
        '
        Me.mnurptDarkhast.AppName = "mnurptDarkhast"
        Me.mnurptDarkhast.Name = "mnurptDarkhast"
        Me.mnurptDarkhast.Size = New System.Drawing.Size(259, 22)
        Me.mnurptDarkhast.Text = "درخواست کالا"
        '
        'mnuHavaleh
        '
        Me.mnuHavaleh.AppName = "mnuHavaleh"
        Me.mnuHavaleh.Name = "mnuHavaleh"
        Me.mnuHavaleh.Size = New System.Drawing.Size(198, 22)
        Me.mnuHavaleh.Text = "حواله"
        '
        'mnuSep350
        '
        Me.mnuSep350.Name = "mnuSep350"
        Me.mnuSep350.Size = New System.Drawing.Size(195, 6)
        '
        'mnuGozareshMoghayerat
        '
        Me.mnuGozareshMoghayerat.AppName = "mnuGozareshMoghayerat"
        Me.mnuGozareshMoghayerat.Name = "mnuGozareshMoghayerat"
        Me.mnuGozareshMoghayerat.Size = New System.Drawing.Size(259, 22)
        Me.mnuGozareshMoghayerat.Text = "گزارش مقایسه انبارها"
        '
        'mnuSep85
        '
        Me.mnuSep85.Name = "mnuSep85"
        Me.mnuSep85.Size = New System.Drawing.Size(264, 6)
        '
        'MnuUpdateEnghezaDate
        '
        Me.MnuUpdateEnghezaDate.AppName = "MnuUpdateEnghezaDate"
        Me.MnuUpdateEnghezaDate.Name = "MnuUpdateEnghezaDate"
        Me.MnuUpdateEnghezaDate.Size = New System.Drawing.Size(267, 22)
        Me.MnuUpdateEnghezaDate.Text = "ثبت و بروزآوري تاريخ انقضاء كد رهگيري"
        '
        'MnuMohlateForoosh
        '
        Me.MnuMohlateForoosh.AppName = "MnuMohlateForoosh"
        Me.MnuMohlateForoosh.Name = "MnuMohlateForoosh"
        Me.MnuMohlateForoosh.Size = New System.Drawing.Size(267, 22)
        Me.MnuMohlateForoosh.Text = "مهلت فروش"
        '
        'MnuSep99
        '
        Me.MnuSep99.Name = "MnuSep99"
        Me.MnuSep99.Size = New System.Drawing.Size(264, 6)
        '
        'MnuSep108
        '
        Me.MnuSep108.Name = "MnuSep108"
        Me.MnuSep108.Size = New System.Drawing.Size(264, 6)
        '
        'MnuTafsiliA2
        '
        Me.MnuTafsiliA2.Name = "MnuTafsiliA2"
        Me.MnuTafsiliA2.Size = New System.Drawing.Size(259, 22)
        Me.MnuTafsiliA2.Text = "مرور تفصيلي اسناد 2"
        '
        'MnuMoroorTafsiliNew
        '
        Me.MnuMoroorTafsiliNew.Name = "MnuMoroorTafsiliNew"
        Me.MnuMoroorTafsiliNew.Size = New System.Drawing.Size(259, 22)
        Me.MnuMoroorTafsiliNew.Text = "مرور تفصيلي اسناد با ریال"
        '
        'mnuMoroorTafsiliTaadil
        '
        Me.mnuMoroorTafsiliTaadil.Name = "mnuMoroorTafsiliTaadil"
        Me.mnuMoroorTafsiliTaadil.Size = New System.Drawing.Size(259, 22)
        Me.mnuMoroorTafsiliTaadil.Text = "مرور تفصيلي تعديل"
        '
        'mnuVardehSamaneJameAnbar
        '
        Me.mnuVardehSamaneJameAnbar.Name = "mnuVardehSamaneJameAnbar"
        Me.mnuVardehSamaneJameAnbar.Size = New System.Drawing.Size(259, 22)
        Me.mnuVardehSamaneJameAnbar.Text = "گزارش وارد سامانه جامع انبار"
        '
        'MnuRptVaznRialiHavalehha
        '
        Me.MnuRptVaznRialiHavalehha.Name = "MnuRptVaznRialiHavalehha"
        Me.MnuRptVaznRialiHavalehha.Size = New System.Drawing.Size(259, 22)
        Me.MnuRptVaznRialiHavalehha.Text = "گزارش ریال کلی حواله ها"
        '
        'MnuRptMoghayeratShoab
        '
        Me.MnuRptMoghayeratShoab.Name = "MnuRptMoghayeratShoab"
        Me.MnuRptMoghayeratShoab.Size = New System.Drawing.Size(259, 22)
        Me.MnuRptMoghayeratShoab.Text = "گزارش مقایسه اسناد بین شعب"
        '
        'MnuImportFromExcel
        '
        Me.MnuImportFromExcel.AppName = "MnuImportFromExcel"
        Me.MnuImportFromExcel.Name = "MnuImportFromExcel"
        Me.MnuImportFromExcel.Size = New System.Drawing.Size(267, 22)
        Me.MnuImportFromExcel.Text = "ثبت سند انبار از طریق فایل اکسل"
        '
        'mnuRptChideman
        '
        Me.mnuRptChideman.AppName = "mnuRptChideman"
        Me.mnuRptChideman.Name = "mnuRptChideman"
        Me.mnuRptChideman.Size = New System.Drawing.Size(259, 22)
        Me.mnuRptChideman.Text = "گزارش چیدمان کالا"
        '
        'mnuRptHavalehMovaghat
        '
        Me.mnuRptHavalehMovaghat.AppName = "mnuRptHavalehMovaghat"
        Me.mnuRptHavalehMovaghat.Name = "mnuRptHavalehMovaghat"
        Me.mnuRptHavalehMovaghat.Size = New System.Drawing.Size(32, 19)
        Me.mnuRptHavalehMovaghat.Text = "حواله های موقت"
        '
        'mnuAsnadAnbar
        '
        Me.mnuAsnadAnbar.AppName = "mnuAsnadAnbar"
        Me.mnuAsnadAnbar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMojoodiha, Me.mnuSep72, Me.mnuResid, Me.mnuHavaleh, Me.mnuBarnameh, Me.mnuSep350, Me.MnuResideMarjooeAzTozie, Me.mnuSep38, Me.mnuSepKasriEzafeShoab, Me.mnuSep39, Me.mnuHavalehKahandehKharid, Me.mnuResidDarAnbarQC, Me.mnuSepEslahiha, Me.mnuSep35, Me.mnuEzafiMojoodiAnbar, Me.mnuKasriMojoodiAnbar, Me.mnuSep77})
        Me.mnuAsnadAnbar.Name = "mnuAsnadAnbar"
        Me.mnuAsnadAnbar.Size = New System.Drawing.Size(267, 22)
        Me.mnuAsnadAnbar.Text = "اسناد انبار"
        '
        'mnuErsalMojoodiBeAvalDoreh
        '
        Me.mnuErsalMojoodiBeAvalDoreh.AppName = "mnuErsalMojoodiBeAvalDoreh"
        Me.mnuErsalMojoodiBeAvalDoreh.Name = "mnuErsalMojoodiBeAvalDoreh"
        Me.mnuErsalMojoodiBeAvalDoreh.Size = New System.Drawing.Size(267, 22)
        Me.mnuErsalMojoodiBeAvalDoreh.Text = "انتقال مستقیم موجودی به اول دوره سال بعد"
        '
        'mnuSefrKardaneMojoodiAnbar
        '
        Me.mnuSefrKardaneMojoodiAnbar.AppName = "mnuSefrKardaneMojoodiAnbar"
        Me.mnuSefrKardaneMojoodiAnbar.Name = "mnuSefrKardaneMojoodiAnbar"
        Me.mnuSefrKardaneMojoodiAnbar.Size = New System.Drawing.Size(267, 22)
        Me.mnuSefrKardaneMojoodiAnbar.Text = "صفر کردن موجودی انبار با تراکنش کسری از انبار"
        '
        'MnuSanadObjectChideman
        '
        Me.MnuSanadObjectChideman.AppName = "MnuSanadObjectChideman"
        Me.MnuSanadObjectChideman.Name = "MnuSanadObjectChideman"
        Me.MnuSanadObjectChideman.Size = New System.Drawing.Size(259, 22)
        Me.MnuSanadObjectChideman.Text = "چیدمان آبجکت های اسناد انبار"
        '
        'MnuSep100
        '
        Me.MnuSep100.Name = "MnuSep100"
        Me.MnuSep100.Size = New System.Drawing.Size(6, 6)
        '
        'mnu__abSpr_MojoodiKalaSahmiye
        '
        Me.mnu__abSpr_MojoodiKalaSahmiye.AppName = "mnu__abSpr_MojoodiKalaSahmiye"
        Me.mnu__abSpr_MojoodiKalaSahmiye.Name = "mnu__abSpr_MojoodiKalaSahmiye"
        Me.mnu__abSpr_MojoodiKalaSahmiye.Size = New System.Drawing.Size(259, 22)
        Me.mnu__abSpr_MojoodiKalaSahmiye.Text = "موجودي انبار برای کالاهای سهمیه ای"
        '
        'MnuTaeedeDaryafteHavalehayeArayeshi
        '
        Me.MnuTaeedeDaryafteHavalehayeArayeshi.AppName = "MnuTaeedeDaryafteHavalehayeArayeshi"
        Me.MnuTaeedeDaryafteHavalehayeArayeshi.Name = "MnuTaeedeDaryafteHavalehayeArayeshi"
        Me.MnuTaeedeDaryafteHavalehayeArayeshi.Size = New System.Drawing.Size(259, 22)
        Me.MnuTaeedeDaryafteHavalehayeArayeshi.Text = "تایید دریافت حواله های آرایشی"
        '
        'MnuRptRialiAsnadKAsriEzafeh
        '
        Me.MnuRptRialiAsnadKAsriEzafeh.AppName = "MnuRptRialiAsnadKAsriEzafeh"
        Me.MnuRptRialiAsnadKAsriEzafeh.Name = "MnuRptRialiAsnadKAsriEzafeh"
        Me.MnuRptRialiAsnadKAsriEzafeh.Size = New System.Drawing.Size(267, 22)
        Me.MnuRptRialiAsnadKAsriEzafeh.Text = "گزارش ریالی اسناد کسری و اضافه انبارگردانی"
        '
        'mnuSahmeKala
        '
        Me.mnuSahmeKala.AppName = "mnuSahmeKala"
        Me.mnuSahmeKala.Name = "mnuSahmeKala"
        Me.mnuSahmeKala.Size = New System.Drawing.Size(259, 22)
        Me.mnuSahmeKala.Text = "تسهیم کالاهای سهمیه ای"
        '
        'MnuTaghirNerkhAvaldore
        '
        Me.MnuTaghirNerkhAvaldore.AppName = "MnuTaghirNerkhAvaldore"
        Me.MnuTaghirNerkhAvaldore.Name = "MnuTaghirNerkhAvaldore"
        Me.MnuTaghirNerkhAvaldore.Size = New System.Drawing.Size(198, 22)
        Me.MnuTaghirNerkhAvaldore.Text = "تغییر نرخ اول دوره"
        '
        'mnuFaseleDarkhastTaHavaleh
        '
        Me.mnuFaseleDarkhastTaHavaleh.AppName = "mnuFaseleDarkhastTaHavaleh"
        Me.mnuFaseleDarkhastTaHavaleh.Name = "mnuFaseleDarkhastTaHavaleh"
        Me.mnuFaseleDarkhastTaHavaleh.Size = New System.Drawing.Size(267, 22)
        Me.mnuFaseleDarkhastTaHavaleh.Text = "گزارش فاصله زمانی درخواست تا حواله"
        '
        'mnuRptDarkhastRepair
        '
        Me.mnuRptDarkhastRepair.AppName = "mnuRptDarkhastRepair"
        Me.mnuRptDarkhastRepair.Name = "mnuRptDarkhastRepair"
        Me.mnuRptDarkhastRepair.Size = New System.Drawing.Size(267, 22)
        Me.mnuRptDarkhastRepair.Text = "گزارش درخواست تعمیرات"
        '
        'mnuRptPriodicService
        '
        Me.mnuRptPriodicService.AppName = "mnuRptPriodicService"
        Me.mnuRptPriodicService.Name = "mnuRptPriodicService"
        Me.mnuRptPriodicService.Size = New System.Drawing.Size(267, 22)
        Me.mnuRptPriodicService.Text = "گزارش سرویس دوره ای"
        '
        'mnuRptUIDtracking
        '
        Me.mnuRptUIDtracking.AppName = "mnuRptUIDtracking"
        Me.mnuRptUIDtracking.Name = "mnuRptUIDtracking"
        Me.mnuRptUIDtracking.Size = New System.Drawing.Size(267, 22)
        Me.mnuRptUIDtracking.Text = "گزارش گردش UID دارو در انبار"
        '
        'mdiMainAnbar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 517)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "mdiMainAnbar"
        CType(Me.sbpVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpComputerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpDateShamsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainToolbar.ResumeLayout(False)
        CType(Me.sbpVahedeTejariName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpSal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpDataBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Menu Item Click"

    Public Sub mnuabAnbarKala_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarKala.Popup
        mnuabAnbarKala_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabAnbarKala_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarKala.Click
        Minoo.Applications.Anbar.Hesabdari.CHesabdari.ShowAnbarKala(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarKala.AppName, mnuabAnbarKala.Text)
    End Sub

    Public Sub mnuabAnbarConfig_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarConfig.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowAnbarConfig(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarConfig.AppName, mnuabAnbarConfig.Text)
    End Sub

    Public Sub mnuabAnbarConfig_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
 Handles mnuabAnbarConfig.Popup
        mnuabAnbarConfig_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabAnbarKalaRezerv_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarKalaRezerv.Popup
        mnuabAnbarKalaRezerv_Click(eventSender, eventArgs)
    End Sub

    Public Sub MnuTashimPattern_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles MnuTashimPattern.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowTashimPattern(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarTarakonesh.AppName, mnuabAnbarTarakonesh.Text)
    End Sub

    Public Sub mnuabAnbarKalaRezerv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarKalaRezerv.Click
        Minoo.Applications.Anbar.RezervKala.CRezervKala.ShoAnbarKalaRezerv(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarKalaRezerv.AppName, mnuabAnbarKalaRezerv.Text)
    End Sub

    Public Sub mnuabAnbarTarakonesh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarTarakonesh.Popup
        mnuabAnbarTarakonesh_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabAnbarTarakonesh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabAnbarTarakonesh.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowAnbarTarakonesh(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarTarakonesh.AppName, mnuabAnbarTarakonesh.Text)
    End Sub

    Public Sub mnuabTarakoneshGorooh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabTarakoneshGorooh.Popup
        mnuabTarakoneshGorooh_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabTarakoneshGorooh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuabTarakoneshGorooh.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowTarakoneshGorooh(Me)
        DBLog.WriteLOG("Form", 0, , mnuabTarakoneshGorooh.AppName, mnuabTarakoneshGorooh.Text)
    End Sub

    Public Sub MnuSanadObjectChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MnuSanadObjectChideman.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowSanadObjectChideman(Me)
        DBLog.WriteLOG("Form", 0, , MnuSanadObjectChideman.AppName, MnuSanadObjectChideman.Text)
    End Sub

    Public Sub mnuabNoeBarnameh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
      Handles mnuabNoeBarnameh.Popup
        mnuabNoeBarnameh_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabNoeBarnameh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
      Handles mnuabNoeBarnameh.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowNoeBarnameh(Me)
        DBLog.WriteLOG("Form", 0, , mnuabNoeBarnameh.AppName, mnuabNoeBarnameh.Text)
    End Sub

    Public Sub mnuabTarakoneshGoroohTafsili_Popup(ByVal eventSender As System.Object,
         ByVal eventArgs As System.EventArgs) _
     Handles mnuabTarakoneshGoroohTafsili.Popup
        mnuabTarakoneshGoroohTafsili_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuabTarakoneshGoroohTafsili_Click(ByVal eventSender As System.Object,
         ByVal eventArgs As System.EventArgs) _
     Handles mnuabTarakoneshGoroohTafsili.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowTarakoneshGoroohTafsili(Me)
        DBLog.WriteLOG("Form", 0, , mnuabTarakoneshGoroohTafsili.AppName, mnuabTarakoneshGoroohTafsili.Text)
    End Sub

    Public Sub mnuHavaleh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuHavaleh.Popup
        mnuHavaleh_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHavaleh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuHavaleh.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntHAVALEHHA, "mnuHavaleh")
        ' , Me)
    End Sub

    Public Sub mnuKardex_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuKardex.Popup
        mnuKardex_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuKardex_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuKardex.Click
        Minoo.Applications.Anbar.Report.CReport.ShowKardex(Me)
        DBLog.WriteLOG("Form", 0, , mnuKardex.AppName, mnuKardex.Text)

    End Sub

    Private Sub MnuZayeatKartablReport_Click(sender As Object, e As EventArgs) Handles MnuZayeatKartablReport.Click
        Minoo.Applications.Anbar.Report.CReport.ShowReportKartablZayeat(Me)
        DBLog.WriteLOG("Form", 0, , MnuZayeatKartablReport.AppName, MnuZayeatKartablReport.Text)
    End Sub

    Private Sub MnuAccessControl_Click(sender As Object, e As EventArgs) Handles MnuAccessControl.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.AnbarAccessControl(Me)
        DBLog.WriteLOG("Form", 0, , MnuAccessControl.AppName, MnuAccessControl.Text)
    End Sub

    Private Sub MnuDarkhastRepair_Click(sender As Object, e As EventArgs) Handles MnuDarkhastRepair.Click
        Minoo.Applications.Anbar.QC.CQC.DarkhastRepair(Me)
        DBLog.WriteLOG("Form", 0, , MnuDarkhastRepair.AppName, MnuDarkhastRepair.Text)
    End Sub

    Private Sub MnuDarkhastPriodicService_Click(sender As Object, e As EventArgs) Handles MnuDarkhastPriodicService.Click
        Minoo.Applications.Anbar.QC.CQC.PriodicService(Me)
        DBLog.WriteLOG("Form", 0, , MnuDarkhastPriodicService.AppName, MnuDarkhastPriodicService.Text)
    End Sub

    Private Sub MnuZayeatKartablRole_Click(sender As Object, e As EventArgs) Handles MnuZayeatKartablRole.Click
        With FrmabZayeatKartablRole.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Private Sub MnuZayeatKartabl_Click(sender As Object, e As EventArgs) Handles MnuZayeatKartabl.Click
        With FrmabZayeatKartabl.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Sub mnuQC_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQC.Popup
        mnuQC_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuQC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQC.Click
        Minoo.Applications.Anbar.QC.CQC.ShowQC(Me)
        DBLog.WriteLOG("Form", 0, , mnuQC.AppName, mnuQC.Text)
    End Sub

    Public Sub mnuResid_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuResid.Popup
        mnuResid_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuResid_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuResid.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDHA, "mnuResid")
        ' , Me)

    End Sub

    Public Sub mnuTafsiliA_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuTafsiliA.Popup
        mnuTafsiliA_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuTafsiliA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
     Handles mnuTafsiliA.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMoroorTafsili(Me)
        DBLog.WriteLOG("Form", 0, , mnuTafsiliA.AppName, mnuTafsiliA.Text)
    End Sub

    Public Sub mnuMasrafeMavad_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMasrafeMavad.Popup
        mnuMasrafeMavad_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuMasrafeMavad_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMasrafeMavad.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptMasrafeMavad(Me)
        DBLog.WriteLOG("Form", 0, , mnuMasrafeMavad.AppName, mnuMasrafeMavad.Text)
    End Sub

    Private Sub MnuTafsiliA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MnuTafsiliA2.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMoroorTafsili2(Me)
        DBLog.WriteLOG("Form", 0, , "MnuTafsiliA2", MnuTafsiliA2.Text)
    End Sub

    Private Sub MnuMoroorTafsiliNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MnuMoroorTafsiliNew.Click

        '''Minoo.Applications.Anbar.Report.CReport.ShowMoroorTafsiliNEW(Me)

        Dim _ReportFacade As New NerkhGozari.Report.ReportFacade
        _ReportFacade.KardexReialByNerkhKalaphiziki(Me)


        DBLog.WriteLOG("Form", 0, , "MnuMoroorTafsiliNew", MnuMoroorTafsiliNew.Text)
    End Sub

    Private Sub mnuMoroorTafsiliTaadil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuMoroorTafsiliTaadil.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMoroorTafsiliTaadil(Me)
        DBLog.WriteLOG("Form", 0, , "mnuMoroorTafsiliTaadil", mnuMoroorTafsiliTaadil.Text)
    End Sub
    Private Sub mnuVardehSamaneJameAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
 Handles mnuVardehSamaneJameAnbar.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowVardehSamaneJameAnbar(Me)
        DBLog.WriteLOG("Form", 0, , "mnuVardehSamaneJameAnbar", mnuVardehSamaneJameAnbar.Text)
    End Sub


    Private Sub MnuRPTVAznRialiHavalehha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MnuRptVaznRialiHavalehha.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowRptVAznRialiHavaleha(Me)
        DBLog.WriteLOG("REport", 0, , "MnuRPTVAznRialiHavalehha", MnuRptVaznRialiHavalehha.Text)
    End Sub
    Private Sub MnuRptMoghayeratShoab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MnuRptMoghayeratShoab.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowTafsiliA(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowRptMoghayeratShoab(Me)
        DBLog.WriteLOG("REport", 0, , "MnuRptMoghayeratShoab", MnuRptMoghayeratShoab.Text)
    End Sub

    Private Sub mnu__abSpr_Mojoodi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnu__abSpr_Mojoodi.Click
        'Minoo.Applications.Anbar.Report.CReport.ShowMojoodi(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMojoodi(Me)
        DBLog.WriteLOG("Form", 0, , mnu__abSpr_Mojoodi.AppName, mnu__abSpr_Mojoodi.Text)
    End Sub

    Private Sub mnuMojudiWithIRC_GTIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuMojudiWithIRC_GTIN.Click
        Minoo.Applications.Anbar.Report.CReport.ShowReportMojudiWithIRC_GTIN(Me)
        DBLog.WriteLOG("Form", 0, , mnuMojudiWithIRC_GTIN.AppName, mnuMojudiWithIRC_GTIN.Text)
    End Sub

    ''abSanadBarcodeReaderReport

    Private Sub mnu__MoghayerateKatalogeMahsoolatBaSystemMaprReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnu__MoghayerateCatalogueMahsoolatBaSystemMap.Click
        'Minoo.Applications.Anbar.Report.CReport.ShowMojoodi(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMoghayerateKatalogeMahsoolatBaSystemMap(Me)

        DBLog.WriteLOG("Form", 0, , mnu__MoghayerateCatalogueMahsoolatBaSystemMap.AppName, mnu__MoghayerateCatalogueMahsoolatBaSystemMap.Text)
    End Sub
    'mnu__ListMahsulateBarcodkhan
    Private Sub mnu__ListMahsulateBarcodkhan_Click(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles mnu__ListMahsulateBarcodkhan.Click
        Report.CReport.ShowListMahsulateBarocdeKhan(Me)

    End Sub
    'mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan
    Private Sub mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan_Click(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles mnu__ReportAghlamTarikhNazdikeAsnadBarcodKhan.Click
        Report.CReport.ShowReportAghlamTarikhNazdikeAsnadBarcodKhan(Me)
    End Sub

    ''shomarebach 

    Private Sub mnu__ShomarehBachhayeSabtNashodehAnbarMostaghim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.Click
        'Minoo.Applications.Anbar.Report.CReport.ShowMojoodi(Me)
        Minoo.Applications.Anbar.Report.CReport.showShomarehBachhayeSabtNashodehHamlMostaghim(Me)

        DBLog.WriteLOG("Form", 0, , mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.AppName, mnu__ShomarehBachhayeSabtNashodehHamlMostaghim.Text)
    End Sub

    Private Sub mnuRTarakoneshGorooh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRTarakoneshGorooh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowTarakoneshGorooh(Me)
        DBLog.WriteLOG("Form", 0, , mnuRTarakoneshGorooh.AppName, mnuRTarakoneshGorooh.Text)
    End Sub

    Private Sub mnuDarkhast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDarkhast.Click
        Minoo.Applications.Anbar.CSanad.ShowDarkhast(Me)
        DBLog.WriteLOG("Form", 0, , mnuDarkhast.AppName, mnuDarkhast.Text)
    End Sub

    '----------------------- yekta 930722 ---------------------------------------------------------------------------------
    Private Sub mnuTafkik_ghaza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTafkik_Ghaza.Click

        Minoo.Applications.Anbar.CSanad.ShowTafkik(Me, 0)
        DBLog.WriteLOG("Form", 0, , mnuTafkik_Ghaza.AppName, mnuTafkik_Ghaza.Text)

    End Sub

    Private Sub mnuTafkik_Daroo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTafkik_Daroo.Click

        Minoo.Applications.Anbar.CSanad.ShowTafkikDarooei(Me)
        'Minoo.Applications.Anbar.CSanad.ShowTafkik(Me, 1)
        DBLog.WriteLOG("Form", 0, , mnuTafkik_Daroo.AppName, mnuTafkik_Daroo.Text)

    End Sub

    Private Sub mnuBarnameh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBarnameh.Click
        Minoo.Applications.Anbar.CSanad.ShowBarnameh(Me)
        DBLog.WriteLOG("Form", 0, , mnuBarnameh.AppName, mnuBarnameh.Text)
    End Sub

    Private Sub mnu_AvalDoreh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnu_AvalDoreh.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntMOJOODIE_AVALE_DOREH, "mnu_AvalDoreh")
        DBLog.WriteLOG("Form", 0, , mnu_AvalDoreh.AppName, mnu_AvalDoreh.Text)
    End Sub

    ''ghasemi
    'Private Sub MnuTaghirNerkhAvaldore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    ' Handles MnuTaghirNerkhAvaldore_Click
    '    CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntMnuTaghirNerkhAvaldore, "MnuTaghirNerkhAvaldore")
    '    DBLog.WriteLOG("Form", 0, , MnuTaghirNerkhAvaldore.AppName, MnuTaghirNerkhAvaldore.Text)
    'End Sub
    ''ghasemi



    Private Sub mnuErsalFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuErsalFile.Click
        Dim frmDarkhastFile1 As New frmDarkhastFile
        With frmDarkhastFile1
            .MdiParent = Me
            .Show()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub mnuabAnbarNoeRahgiri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabAnbarNoeRahgiri.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowAnbarNoeRahgiri(Me)
        DBLog.WriteLOG("Form", 0, , mnuabAnbarNoeRahgiri.AppName, mnuabAnbarNoeRahgiri.Text)
    End Sub

    Private Sub MnuResideMarjooeAzTozi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MnuResideMarjooeAzTozie.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDEMARJOOEIAZTOZIE, "MnuResideMarjooeAzTozie")
    End Sub

    Private Sub mnuResideBargashti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuResideBargashti.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDEBARGASHTI, "mnuResideBargashti")

    End Sub

    Private Sub mnuHavalehBargashti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuHavalehBargashti.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntHAVALEHBARGASHTI, "mnuHavalehBargashti")

    End Sub

    Private Sub mnuHavalehKahandehKharid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles mnuHavalehKahandehKharid.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntHAVALEHKAHANDEHKHARID, "mnuHavalehKahandehKharid")

    End Sub

    'yekta 940302
    Private Sub mnuResidDarAnbarQC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles mnuResidDarAnbarQC.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDHA, "mnuResidDarAnbarQC")

    End Sub

    Private Sub mnuResideEzafehDryaft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
         Handles mnuResideEzafehDryaft.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDEZAFEHDARYAFT, "mnuResideEzafehDryaft")

    End Sub

    Private Sub mnuResideKasriErsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles mnuResideKasriErsal.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntRESIDKASRIERSAL, "mnuResideKasriErsal")

    End Sub

    Private Sub mnuHavalehEzafehErsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuHavalehEzafehErsal.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntHAVALEHEZAFEHERSAL, "mnuHavalehEzafehErsal")

    End Sub

    Private Sub mnuHavalehKasriDryaft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuHavalehKasriDryaft.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntHAVALEHKASRIDARYAFT, "mnuHavalehKasriDryaft")

    End Sub

    Private Sub mnuChapeSanad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuChapeSanad.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowChapeSanad(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowChapeSanad(Me)
        DBLog.WriteLOG("Form", 0, , mnuChapeSanad.AppName, mnuChapeSanad.Text)
    End Sub

    Private Sub mnuRptMoghayeratSanadMaliStandard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRptMoghayeratSanadMaliStandard.Click
        Minoo.Applications.Anbar.Report.CReport.ShowReportMoghayeratSanadMaliStandard(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptMoghayeratSanadMaliStandard.AppName, mnuRptMoghayeratSanadMaliStandard.Text)
    End Sub
    Private Sub mnuRptAmalKard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptAmalKard.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowAmalkard(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowAmalkard(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptAmalKard.AppName, mnuRptAmalKard.Text)
    End Sub

    Private Sub mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowAdamOlaviatEnghezaDarHavaleh(Me)
        DBLog.WriteLOG("Form", 0, , mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.AppName, mnuReportAdamRayateOlaviatBandiTarikhEnghezaDarHavaleh.Text)
    End Sub



    Private Sub mnuRptVaredehMojaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptVaredehMojaz.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowAmalkard(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowVaredehMojaz(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptVaredehMojaz.AppName, mnuRptVaredehMojaz.Text)
    End Sub

    Private Sub mnuGetSanadAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuGetSanadAnbar.Click
        With FrmGetSanadAnbar.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub mnuRptRezerv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptRezerv.Click
        '    Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowRezerv(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowRezerv(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptRezerv.AppName, mnuRptRezerv.Text)
    End Sub

    'yekta 941030
    Private Sub mnuCheckBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCheckBarcode.Click
        '    Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowRezerv(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowCheckBarcode(Me)
        DBLog.WriteLOG("Form", 0, , mnuCheckBarcode.AppName, mnuCheckBarcode.Text)
    End Sub

    Private Sub mnuDarjSanadAsAnbarBeAnbar81_31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuDarjSanadAsAnbarBeAnbar81_31.Click
        Dim vErrMsg As String
        If NetSql.Common.CSystem.MsgBox("آيا ارسال حواله هاي ضايعات به انبار ضايعات انجام گردد ؟", MsgBoxStyle.Question _
               + MsgBoxStyle.YesNo +
               MsgBoxStyle.DefaultButton2 +
               MsgBoxStyle.MsgBoxRtlReading _
               + MsgBoxStyle.MsgBoxRight, Me.Text) =
           MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vErrMsg =
             CAppAnbar.DarjSanadAsAnbarBeAnbar(gVahedeTejariSN, gAnbarSN, 0, gNoeAnbarSN, 5, 81, 31, gSM.UserID_Name)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg)
            Else
                NetSql.Common.CSystem.MsgBox(" عمليات با موفقيت انجام شد ")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub mnu_RialeVaredeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnu_RialeVaredeh.Click
        Minoo.Applications.Anbar.Hesabdari.CHesabdari.ShowSanadMali(Me)
    End Sub

    Private Sub mnuControlKardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuControlKardex.Click
        Minoo.Applications.Anbar.Report.CReport.ShowControlKardex(Me)
        DBLog.WriteLOG("Form", 0, , mnuControlKardex.AppName, mnuControlKardex.Text)
    End Sub
    ' add by yekta 920913
    Private Sub mnuRptQCIntervals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuRptQCIntervals.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptQCIntervals(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptQCIntervals.AppName, mnuRptQCIntervals.Text)
    End Sub
    ' add by yekta 920924
    Private Sub mnuEslaheSanad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuEslaheSanad.Click
        CAppAnbar.gSanadAnbar.EslaheAsnad(EnumNoeTarakoneshSN.ntRESIDHA, "mnuResid")
        ' , Me)
    End Sub

    Private Sub mnuEzafiMojoodiAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuEzafiMojoodiAnbar.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntEzafiMojoodiAnbar, "mnuEzafiMojoodiAnbar")
    End Sub

    Private Sub mnuKasriMojoodiAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuKasriMojoodiAnbar.Click
        CAppAnbar.gSanadAnbar.ShowAsnad(EnumNoeTarakoneshSN.ntKasriMojoodiAnbar, "mnuKasriMojoodiAnbar")
    End Sub

    Private Sub mnuEslaheTarafHesab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuEslaheTarafHesab.Click
        Minoo.Applications.Anbar.CSanad.ShowEslahSanad(Me)
    End Sub

    Private Sub mnuEslaheTarafHesabKharid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuEslaheTarafHesabKharid.Click
        Minoo.Applications.Anbar.CSanad.ShowEslahSanadKharid(Me)
    End Sub

    Private Sub mnuAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnbar.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowAnbar(Me)
        DBLog.WriteLOG("Form", 0, , mnuAnbar.AppName, mnuAnbar.Text)
    End Sub

    Private Sub mnuSelectAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuSelectAnbar.Click
        ShowSelectAnbar(Me)
    End Sub

    Private Sub mnuSelectCurrentSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuSelectCurrentSal.Click
        SelectHesabdariSal(Me)
        Me.RefreshStatusBar()
    End Sub

    Private Sub mnuFrmResideMamoorPakhsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuFrmResideMamoorPakhsh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowResideMamoorPakhsh(Me)
    End Sub

    Private Sub mnuMojoodiB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMojoodiB.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowMojoodiB(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowMojoodiBeTafkikNoeMarjooee(Me)
        DBLog.WriteLOG("Form", 0, , mnuMojoodiB.AppName, mnuMojoodiB.Text)
    End Sub

    Private Sub mnurptDarkhast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnurptDarkhast.Click
        Minoo.Applications.Anbar.Report.CReport.ShowDarkhast(Me)
        DBLog.WriteLOG("Form", 0, , mnuMojoodiB.AppName, mnurptDarkhast.Text)

    End Sub

    Private Sub mnurptDarkhastKharid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptDarkhastKharid.Click
        Minoo.Applications.Anbar.Report.CReport.ShowDarkhastKharid(Me)
        DBLog.WriteLOG("Form", 0, , mnurptDarkhastKharid.AppName, mnurptDarkhastKharid.Text)
    End Sub

    Private Sub mnuabNoeChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabNoeChideman.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowNoeChideman(Me)
        DBLog.WriteLOG("Form", 0, , mnuabNoeChideman.AppName, mnuabNoeChideman.Text)
    End Sub

    Private Sub mnuabChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabChideman.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowChideman(Me)
        DBLog.WriteLOG("Form", 0, , mnuabChideman.AppName, mnuabChideman.Text)
    End Sub

    Private Sub mnuabSharayeteMohiti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabSharayeteMohiti.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowSharayeteMohiti(Me)
        DBLog.WriteLOG("Form", 0, , mnuabSharayeteMohiti.AppName, mnuabSharayeteMohiti.Text)
    End Sub

    Private Sub mnuabChidemanSharayet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabChidemanSharayet.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowChidemanSharayet(Me)
        DBLog.WriteLOG("Form", 0, , mnuabChidemanSharayet.AppName, mnuabChidemanSharayet.Text)
    End Sub

    Private Sub mnuabKalaChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabKalaChideman.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowKalaChideman(Me)
        DBLog.WriteLOG("Form", 0, , mnuabKalaChideman.AppName, mnuabKalaChideman.Text)
    End Sub

    Private Sub mnuabSharayeteKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuabSharayeteKala.Click
        Minoo.Applications.Anbar.Chideman.CChideman.ShowSharayeteKala(Me)
        DBLog.WriteLOG("Form", 0, , mnuabSharayeteKala.AppName, mnuabSharayeteKala.Text)
    End Sub


#End Region

    Private Sub MnuAnbarGardani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MnuAnbarGardani.Click
        Minoo.Applications.Anbar.AnbarGardani.CAnbarGardani.ShowAnbarGardani(Me, 1)
        DBLog.WriteLOG("Form", 0, , MnuAnbarGardani.AppName, MnuAnbarGardani.Text)
    End Sub

    Private Sub MnuAnbarGardaniMianDoreh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MnuAnbarGardaniMianDoreh.Click
        Minoo.Applications.Anbar.AnbarGardani.CAnbarGardani.ShowAnbarGardani(Me, 2)
        DBLog.WriteLOG("Form", 0, , MnuAnbarGardaniMianDoreh.AppName, MnuAnbarGardaniMianDoreh.Text)

    End Sub
    Private Sub MnuAnbarGardaniEnghezaDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MnuAnbarGardaniEnghezaDate.Click
        Minoo.Applications.Anbar.AnbarGardani.CAnbarGardani.ShowAnbarGardaniByEnghezaDate(Me, 3)
        DBLog.WriteLOG("Form", 0, , MnuAnbarGardaniEnghezaDate.AppName, MnuAnbarGardaniEnghezaDate.Text)

    End Sub





    Private Sub mnurptAlertNerkhStandardAsnad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnurptAlertNerkhStandardAsnad.Click
        Minoo.Applications.Anbar.Hesabdari.CHesabdari.ShowAlertNerkhStandardAsnad(Me, 1)
        DBLog.WriteLOG("Form", 0, , mnurptAlertNerkhStandardAsnad.AppName, mnurptAlertNerkhStandardAsnad.Text)
    End Sub

    Private Sub mnuRptNegasht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptNegasht.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowNegasht(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowNegasht(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptNegasht.AppName, mnuRptNegasht.Text)
    End Sub

    Private Sub mnuDarjSanadAsAnbarBeAnbar65_5_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuDarjSanadAsAnbarBeAnbar65_5_2.Click
        Dim vErrMsg As String
        If NetSql.Common.CSystem.MsgBox("آيا ارسال حواله هاي انبار به انبار به انبار محصول انجام گردد ؟", MsgBoxStyle.Question _
             + MsgBoxStyle.YesNo +
             MsgBoxStyle.DefaultButton2 +
             MsgBoxStyle.MsgBoxRtlReading _
             + MsgBoxStyle.MsgBoxRight,
          Me.Text) = MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vErrMsg =
             CAppAnbar.DarjSanadAsAnbarBeAnbar(gVahedeTejariSN, gAnbarSN, 0, gNoeAnbarSN, 2, 65, 5, gSM.UserID_Name)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg)
            Else
                NetSql.Common.CSystem.MsgBox(" عمليات با موفقيت انجام شد ")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub mnuDarjSanadAsAnbarBeAnbar65_5_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuDarjSanadAsAnbarBeAnbar65_5_5.Click
        Dim vErrMsg As String
        If NetSql.Common.CSystem.MsgBox("آيا ارسال حواله هاي انبار به انبار به انبار ضايعات انجام گردد ؟", MsgBoxStyle.Question _
              + MsgBoxStyle.YesNo +
              MsgBoxStyle.DefaultButton2 +
              MsgBoxStyle.MsgBoxRtlReading _
              + MsgBoxStyle.MsgBoxRight,
          Me.Text) = MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vErrMsg =
             CAppAnbar.DarjSanadAsAnbarBeAnbar(gVahedeTejariSN, gAnbarSN, 0, gNoeAnbarSN, 5, 65, 5, gSM.UserID_Name)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg)
            Else
                NetSql.Common.CSystem.MsgBox(" عمليات با موفقيت انجام شد ")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub mnuSefareshParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuSefareshParam.Click
        Minoo.Applications.Anbar.Report.CReport.ShowSefareshParam(Me)
        DBLog.WriteLOG("Form", 0, , mnuSefareshParam.AppName, mnuSefareshParam.Text)
    End Sub

    Private Sub mnuRptTagAnbarGardani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptTagAnbarGardani.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptTagAnbargardani(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptTagAnbarGardani.AppName, mnuRptTagAnbarGardani.Text)
    End Sub
    'ghasemi 14000114
    Private Sub mnuRptMoghayratAnbarGardani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptMoghayratAnbarGardani.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptMoghayratAnbarGardani(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptMoghayratAnbarGardani.AppName, mnuRptMoghayratAnbarGardani.Text)
    End Sub
    ''ghasemi 14000114

    Private Sub mnuRptUIDtracking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptUIDtracking.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptUIDtracking(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptUIDtracking.AppName, mnuRptUIDtracking.Text)
    End Sub


    ''koohdar 14020320
    Private Sub MnurepAnbarGardaniEnghezaDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRepAnbarGardaniEnghezaDate.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptAnbargardaniDateEngheza(Me)
        DBLog.WriteLOG("Form", 0, , mnuRepAnbarGardaniEnghezaDate.AppName, mnuRepAnbarGardaniEnghezaDate.Text)
    End Sub


    ''ghasemi
    Private Sub mnuFaseleDarkhastTaHavaleh_Click(sender As Object, e As EventArgs) Handles mnuFaseleDarkhastTaHavaleh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptFaseleDarkhastTaHavaleh(Me)
        DBLog.WriteLOG("Form", 0, , mnuFaseleDarkhastTaHavaleh.AppName, mnuFaseleDarkhastTaHavaleh.Text)
    End Sub
    ''ghasemi

    ''ghasemi 14021010
    Private Sub mnuRptDarkhastRepair_Click(sender As Object, e As EventArgs) Handles mnuRptDarkhastRepair.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptDarkhastRepair(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptDarkhastRepair.AppName, mnuRptDarkhastRepair.Text)
    End Sub
    Private Sub mnuRptPriodicService_Click(sender As Object, e As EventArgs) Handles mnuRptPriodicService.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptPriodicService(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptPriodicService.AppName, mnuRptPriodicService.Text)
    End Sub
    ''ghasemi 14021010
    Private Sub MnuTaghirNerkhAvaldore_Click(sender As Object, e As EventArgs) Handles MnuTaghirNerkhAvaldore.Click
        With FrmTaghirNerkhAvaldore.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub mnuSodorSanadAsMojodiBeAnbar10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuSodorSanadAsMojodiBeAnbar10.Click
        Dim vErrMsg As String
        If NetSql.Common.CSystem.MsgBox("آيا صدور حواله با مانده به تفکيک نوع مرجوعي انجام گردد ؟", MsgBoxStyle.Question _
             + MsgBoxStyle.YesNo +
             MsgBoxStyle.DefaultButton2 +
             MsgBoxStyle.MsgBoxRtlReading _
             + MsgBoxStyle.MsgBoxRight, Me.Text) =
           MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vErrMsg =
             CAppAnbar.SodorSanadAsMojodiBeAnbar10(gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, gSM.UserID_Name, vErrMsg)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg)
            Else
                NetSql.Common.CSystem.MsgBox(" عمليات با موفقيت انجام شد ")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Sub mnuRptTadil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptTadil.Click
        Minoo.Applications.Anbar.Report.CReport.ShowTadil(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptTadil.AppName, mnuRptTadil.Text)
    End Sub

    Private Sub mnuRptTashim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptTashim.Click
        Minoo.Applications.Anbar.Report.CReport.ShowTashim(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptTashim.AppName, mnuRptTashim.Text)

    End Sub

    Private Sub mnuKardexList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuKardexList.Click
        'Minoo.Applications.Anbar.MeghdariReport.CMeghdariReport.ShowKardexList(Me)
        Minoo.Applications.Anbar.Report.CReport.ShowKardex(Me)
        DBLog.WriteLOG("Form", 0, , mnuKardexList.AppName, mnuKardexList.Text)
    End Sub

    Private Sub mnuUpdateSanadDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuUpdateSanadDate.Click
        With FrmUpdateSanadDate.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

    Private Sub MnuKalaParameter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MnuAnbarKalaParameter.Click
        Minoo.Applications.Anbar.Peykarbandi.CPeykarbandi.ShowAnbarKalaParameter(Me)
        DBLog.WriteLOG("Form", 0, , MnuAnbarKalaParameter.AppName, MnuAnbarKalaParameter.Text)
    End Sub

    Private Sub mnuTahvilBeGoroohReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuTahvilBeGoroohReport.Click
        Minoo.Applications.Anbar.Report.CReport.ShowControlAsnadBeinShoab(Me)
        DBLog.WriteLOG("Form", 0, , mnuTahvilBeGoroohReport.AppName, mnuTahvilBeGoroohReport.Text)
    End Sub

    Private Sub mnuRptMTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptMTS.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptMTS(Me)
        DBLog.WriteLOG("Form", 0, , mnuChapeSanad.AppName, mnuRptMTS.Text)

    End Sub

    Private Sub mnuRptRaked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptRaked.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptRaked(Me)
        DBLog.WriteLOG("Form", 0, , mnuChapeSanad.AppName, mnuRptMTS.Text)

    End Sub

    Private Sub MnuAlarmMojoodi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAlarmMojoodi.Click
        Minoo.Applications.Anbar.Report.CReport.ShowAlarmMojoodi(Me)
        DBLog.WriteLOG("Form", 0, , mnuChapeSanad.AppName, mnuRptMTS.Text)

    End Sub

    Private Sub mnuDarkhastKharidDakheli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuDarkhastKharidDakheli.Click
        CSanad.ShowDarkhastKharidDakheli(Me)
        DBLog.WriteLOG("Form", 0, , mnuDarkhast.AppName, mnuDarkhastKharidDakheli.Text)
    End Sub

    Private Sub mnuDarkhastKharidKhareji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles mnuDarkhastKharidKhareji.Click
        CSanad.ShowDarkhastKharidkhareji(Me)
        DBLog.WriteLOG("Form", 0, , mnuDarkhast.AppName, mnuDarkhastKharidKhareji.Text)
    End Sub

    Private Sub mnuGozareshMoghayerat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuGozareshMoghayerat.Click

        'Dim frm As New Minoo.Anbar.Moghayerat.ReportForm
        'With frm
        '    .MdiParent = Me
        '    .DbUserName = cn.SQLUserId
        '    .DbPassword = cn.SQLPassword
        '    .DbServer = cn.SQLServerName
        '    .DbDatabase = cn.SQLDatabaseName
        '    .Show()
        '    .Activate()
        '    .WindowState = System.Windows.Forms.FormWindowState.Normal
        '    DBLog.WriteLOG("Form", 0, , .Name, .Text)
        'End With

    End Sub

    Private Sub MnuUpdateEnghezaDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuUpdateEnghezaDate.Click
        Minoo.Applications.Anbar.Report.CReport.ShowUpdareEnghezaDate(Me)
        DBLog.WriteLOG("Form", 0, , mnuDarkhast.AppName, MnuUpdateEnghezaDate.Text)
    End Sub

    Private Sub MnuMohlateForoosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MnuMohlateForoosh.Click

        Minoo.Applications.Anbar.RezervKala.CRezervKala.ShowFrmMohlateForoosh(Me)
        DBLog.WriteLOG("Form", 0, , MnuMohlateForoosh.AppName, MnuMohlateForoosh.Text)

    End Sub

    Private Sub MnuImportFromExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MnuImportFromExcel.Click

        Minoo.Applications.Anbar.CSanad.ShowImportFromExcel(Me)
        DBLog.WriteLOG("Form", 0, , MnuImportFromExcel.AppName, MnuImportFromExcel.Text)

    End Sub

    Private Sub mnuRptChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles mnuRptChideman.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptChidemanKala(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptTagAnbarGardani.AppName, mnuRptTagAnbarGardani.Text)
    End Sub

    Private Sub mnuRptHavalehMovaghat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptHavalehMovaghat.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptHavalehMovaghat(Me)
        DBLog.WriteLOG("Form", 0, , mnuRptHavalehMovaghat.AppName, mnuRptHavalehMovaghat.Text)
    End Sub

    Private Sub mnuErsalMojoodiBeAvalDoreh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles mnuErsalMojoodiBeAvalDoreh.Click

        ' ثبت موجودي اول دوره 
        Dim vErrMsg As String = ""
        Dim vFromDate, vToDate, NextyearDate As String
        If MsgBox("آيا موجودي اول دوره انتقال گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        If _
            MsgBox(" با درج اين سند امکان هيچ گونه تغييري در اسناد سال " & gHesabdariSal & " وجود نخواهد داشت(ثبت ، بروزآوري) . در ضمن کليه رزروهاي موجود انبار نيز از رزرو خارج خواهند شد.آيا با این شرائط موجودي اول دوره انتقال گردد؟",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Try

            vFromDate = gHesabdariSalFDate
            vToDate = gHesabdariSalTDate
            NextyearDate = CStr(gHesabdariSal + 1) + "0101"
            ' فراخواني اس پي براي انتقال مانده کاردکس در سند موجودي اول دوره
            cn.CallSP("_abSP_Ins_SanadAvalDorehWithOutAnbarGardani", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, gHesabdariSal + 1 _
                       , vFromDate, vToDate, gSM.Identifier, gSM.UserID_Name, vErrMsg)

            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)

            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            NetSql.Common.CSystem.MsgBox("انتقال اطلاعات با موفقیت انجام شد", , "پایان")

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub mnuSefrKardaneMojoodiAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles mnuSefrKardaneMojoodiAnbar.Click

        ' صفر کردن موجودی انبار با تراکنش کسری انبار 
        Dim vErrMsg As String = ""
        Dim vFromDate, vToDate As String
        If MsgBox("آيا مایل به صفر کردن موجودی انبار با تراکنش کسری انبار هستید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Try
            vFromDate = gHesabdariSalFDate
            vToDate = gHesabdariSalTDate

            cn.CallSP("_abSP_Ins_SefrKardaneMojoodiWithSanadKasri", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, vFromDate, vToDate, gSM.UserID_Name, vErrMsg)

            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)

            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            NetSql.Common.CSystem.MsgBox("صفر کردن موجودی انبار با تراکنش کسری انبار با موفقیت انجام شد", , "پایان")

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub mnuSahmeKala_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSahmeKala.Click
        'Minoo.Applications.Anbar.Report.CReport.ShowRptMasrafeMavad(Me)
        'DBLog.WriteLOG("Form", 0, , mnuSahmeKala.AppName, mnuSahmeKala.Text)

        With FrmSahmeKala.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

    Public Sub mnu__abSpr_MojoodiKalaSahmiye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
 Handles mnu__abSpr_MojoodiKalaSahmiye.Click

        Minoo.Applications.Anbar.Report.CReport.ShowMojoodiKalaSahmiye(Me)
        DBLog.WriteLOG("Form", 0, , mnu__abSpr_MojoodiKalaSahmiye.AppName, mnu__abSpr_MojoodiKalaSahmiye.Text)
    End Sub

    '---------------------------yekta 940506--------------------------------------------
    Public Sub MnuTaeedeDaryafteHavalehayeArayeshi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MnuTaeedeDaryafteHavalehayeArayeshi.Click

        'Dim _c As New Tozie.BarnameRiziPakhsh.CBarnameRiziPakhsh
        '_c.ShowFactorDaryaftAzMarkazFromAnbar(Me)

        Tozie.BarnameRiziPakhsh.CBarnameRiziPakhsh.ShowFactorDaryaftAzMarkazFromAnbar(Me)

        DBLog.WriteLOG("Form", 0, , "MnuTaeedeDaryafteHavalehayeArayeshi", MnuTaeedeDaryafteHavalehayeArayeshi.Text)

    End Sub
    '---------------------------yekta 940506--------------------------------------------

    Private Sub MnuRptRialiAsnadKAsriEzafeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MnuRptRialiAsnadKAsriEzafeh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptRialiAsnadKAsriEzafeh(Me)
        DBLog.WriteLOG("Form", 0, , MnuRptRialiAsnadKAsriEzafeh.AppName, MnuRptRialiAsnadKAsriEzafeh.Text)
    End Sub


    Private Sub mnuEnteghalMojoodiKalaPhiziki_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuEnteghalMojoodiKalaPhiziki.Click
        With FrmEnteghalMojoodiKalaPhiziki.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub MnuDoMovaghatSanadGhatee_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MnuDoMovaghatSanadGhatee.Click
        With FrmabMovaghatSanadGhatee.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub MnuCopySanadAnbar_Click(sender As Object, e As EventArgs) Handles MnuCopySanadAnbar.Click
        With FrmCopySanad.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub MnuEnteghlaMojoudiDaftarbeDaftar_Click(sender As Object, e As EventArgs) Handles MnuEnteghlaMojoudiDaftarbeDaftar.Click
        With FrmDafterBeDaftar.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub MnuSanadBarcodeReader_Click(sender As Object, e As EventArgs) Handles MnuSanadBarcodeReader.Click
        With FrmabSanadBarcodeReader.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub mnuRptMoghayratBienShomaresh_Click(sender As Object, e As EventArgs) Handles mnuRptMoghayratBienShomaresh.Click
        Minoo.Applications.Anbar.Report.CReport.ShowRptMoghayeratShomareshAnbargardani(Me)
    End Sub

    Private Sub mnuReportAnbargardaniEnghezaDate_Click(sender As Object, e As EventArgs) Handles mnuRepAnbarGardaniEnghezaDate.Click
        With FrmReportAnbargardaniEnghezaDate.DefInstance
            .MdiParent = Me
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Private Sub mnuAsnadAnbar_MouseEnter(sender As Object, e As EventArgs) Handles mnuAsnadAnbar.MouseEnter
        If IsVahedTejariTolidi Then
            MnuResideMarjooeAzTozie.Text = "رسيد مرجوعي فاکتور"
        Else
            MnuResideMarjooeAzTozie.Text = "رسيد مرجوعي از توزیع"
        End If
    End Sub
End Class
