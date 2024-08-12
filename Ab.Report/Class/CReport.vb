Public Class CReport
    Public Shared Sub ShowMojoodi(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش موجودي انبار
        With FrmMojoodi.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub


    Public Shared Sub ShowMoghayerateKatalogeMahsoolatBaSystemMap(ByVal aMDIParent As Form)

        With FrmMoghayerateKatalogeMahsoolatBaSystemMaprReport.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowReportMojudiWithIRC_GTIN(ByVal aMDIParent As Form)

        With FrmReportMojudiWithIRC_GTIN.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub


    'نمایش لیست محصولات بارکد خوان
    Public Shared Sub ShowListMahsulateBarocdeKhan(ByVal aMDIParent As Form)

        With FrmListMahsulateBarcodKhan.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowReportAghlamTarikhNazdikeAsnadBarcodKhan(ByVal aMDIParent As Form)

        With FrmReportAsnadBarcodeKhanAghlamNazdik.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub showShomarehBachhayeSabtNashodehHamlMostaghim(ByVal aMDIParent As Form)

        With FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    '---------- yekta 940513 -------------------------
    Public Shared Sub ShowMojoodiKalaSahmiye(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش موجودي انبار
        With FrmMojoodiKalaSahmiye.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    '---------- yekta 940513 -------------------------

    Public Shared Sub ShowMoroorTafsili(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش مرور تفصیلی انبار
        With FrmMoroorTafsili.DefInstance
            .Mode = 1
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowMoroorTafsili2(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش مرور تفصیلی انبار با نرخ جدید
        With FrmMoroorTafsili2.DefInstance
            .Mode = 2
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowMoroorTafsiliNEW(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش مرور تفصیلی انبار جدید
        With FrmMoroorTafsiliNew.DefInstance
            .Mode = 2
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowMoroorTafsiliTaadil(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش مرور تفصیلی تعديل
        With FrmMoroorTafsiliTaadil.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowVardehSamaneJameAnbar(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش سامانه جامع انبار
        With FrmVardehSamaneJameAnbar.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowAmalkard(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش عملکرد انبار
        With FrmAmalkard.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowAdamOlaviatEnghezaDarHavaleh(ByVal aMDIParent As Form)
        'گزارش عدم اولویت بندی تاریخ انقضا در صدور حواله ها
        With FrmReportAdamRayatOlaviatBandiTarikhEnghezaDarSodoorHavale.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowReportMoghayeratSanadMaliStandard(ByVal aMDIParent As Form)
        ' نمايش فرم مقدار وارده مجاز
        With FrmRptMoghayeratSanadMaliStandard.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowVaredehMojaz(ByVal aMDIParent As Form)
        ' نمايش فرم مقدار وارده مجاز
        With FrmVaredehMojaz.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowReportKartablZayeat(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش کاردکس کالا
        With FrmZayeatKartablReport.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptFaseleDarkhastTaHavaleh(ByVal aMDIParent As Form)
        'نمایش گزارش فاصله زمانی درخواست تا حواله
        With FrmRptFaseleDarkhastTaHavaleh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    ''ghasemi 14021010
    Public Shared Sub ShowRptDarkhastRepair(ByVal aMDIParent As Form)
        'نمایش گزارش درخواست تعمیرات
        With FrmReportDarkhastRepair.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptPriodicService(ByVal aMDIParent As Form)
        'نمایش گزارش سرویس دوره ای
        With FrmReportDarkhastService.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    ''ghasemi 14021010
    Public Shared Sub ShowKardex(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش کاردکس کالا
        With FrmKardex.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowChapeSanad(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش چاپ اسناد
        With FrmChapeSanad.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRezerv(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش رزرو
        With FrmRezerv.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    'yekta 941030
    Public Shared Sub ShowCheckBarcode(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش رزرو
        With FrmCheckBarcode.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowMojoodiBeTafkikNoeMarjooee(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش موجودي به تفکيک نوع مرجوعي
        With FrmMojoodiBeTafkikNoeMarjoee.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowDarkhast(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش درخواست کالا از انبار
        With FrmRptDarkhast.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowDarkhastKharid(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش درخواست کالا از انبار
        With FrmRptDarkhastKharid.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowNegasht(ByVal aMDIParent As Form)
        ' نمايش گزارش نگاشت اسناد انبار
        With FrmNegasht.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptVAznRialiHavaleha(ByVal aMDIParent As Form)
        ' گزارش ریال وزنی حواله ها
        With FrmVaznRialiHavaleha.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptMoghayeratShoab(ByVal aMDIParent As Form)
        ' گزارش مقایسه اسناد بین شعب
        With FrmRptMoghayeratShoab.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptTagAnbargardani(ByVal aMDIParent As Form, Optional ByVal aAnbarGardaniSN As Decimal = 0)
        ' گزارش چاپ تگ انبارگرداني
        With FrmRptTagAnbargardani.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    ''ghasemi 14000114
    Public Shared Sub ShowRptMoghayratAnbarGardani(ByVal aMDIParent As Form, Optional ByVal aAnbarGardaniSN As Decimal = 0)
        ' گزارش مغایرت انبارگرداني اول دوره با پایان دوره
        With FrmRptMoghayratAnbarGardani.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    'ghasemi 14000114

    Public Shared Sub ShowRptUIDtracking(ByVal aMDIParent As Form)
        With FrmUIDtrackingReport.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptAnbargardaniDateEngheza(ByVal aMDIParent As Form)
        With FrmReportAnbargardaniEnghezaDate.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    'Public Shared Sub ShowSefareshParam(ByVal aMDIParent As Form)
    '    ' نمايش فرم گزارش نقطه سفارش
    '    With FrmSefareshParam.DefInstance
    '        .MdiParent = aMDIParent
    '        .Show()
    '        .Activate()
    '        DBLog.WriteLOG("Form", 0, , .Name, .Text)
    '    End With
    'End Sub

    Public Shared Sub ShowResideMamoorPakhsh(ByVal aMDIParent As Form)
        'نمايش گزارش رسيد مامورپخش
        With FrmResideMamoorPakhsh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub


    Public Shared Sub ShowTadil(ByVal aMDIParent As Form)
        ' نمايش گزارش اسناد تعديل  موجودي اول دوره
        With FrmTadil.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

    Public Shared Sub ShowTashim(ByVal aMDIParent As Form)
        ' نمايش گزارش اسناد تسهيم سالانه
        With FrmRptTashim.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With

    End Sub

    Public Shared Sub ShowKardexC(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش كاردكس كالا
        With FrmKardexA.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowSefareshParam(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش سرجمع موجودي کالا
        With FrmRptSefareshParam.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    'Public Shared Sub ShowChapeSanad(ByVal aMDIParent As Form)
    '  ' نمايش فرم گزارش چاپ اسناد
    '  With FrmChapeSanad.DefInstance
    '    .MdiParent = aMDIParent
    '    .Show()
    '    .Activate()
    '    DBLog.WriteLOG("Form", 0, , .Name, .Text)
    '  End With
    'End Sub

    Public Shared Sub ShowRptMTS(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش کالاهاي با موجودي کمتر از حداقل
        With FrmRptMTS.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptRaked(ByVal aMDIParent As Form)
        ' نمایش فرم گزارش کالاهای راکد
        With FrmRaked.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowAlarmMojoodi(ByVal aMDIParent As Form)
        ' نمایش فرم گزارش آلارم موجودی
        With FrmRptAlarmMojoodi.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    'add by yekta 920913
    Public Shared Sub ShowRptQCIntervals(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش فاصله زمانی کنترل کیفیت
        With FrmRptQCIntervals.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowControlKardex(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش کنترل کاردکس
        With FrmControlKardex.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub


    Public Shared Sub ShowKardexList(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش كاردكس كالا
        With FrmKardexB.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowControlAsnadBeinShoab(ByVal aMDIParent As Form)
        ' نمايش فرم گزارش کنترل اسناد بين انبار
        With FrmRptControlAsnadBeinShoab.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowUpdareEnghezaDate(ByVal aMDIParent As Form)
        ' نمايش فرم درخواست از انبار
        'With FrmUpdateEnghezaDate.DefInstance
        With FrmRptMojoodWithEnghezadate.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowTarakoneshGorooh(ByVal aMDIParent As Form)
        ' نمايش فرم درخواست از انبار
        With FrmRTarakoneshGorooh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptChidemanKala(ByVal aMDIParent As Form)
        ' نمايش گزارش چیدمان کالا
        With FrmRptChideman.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptHavalehMovaghat(ByVal aMDIParent As Form)
        'نمایش حواله های موقت
        With FrmRptHavalehMovaghat.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptMasrafeMavad(ByVal aMDIParent As Form)
        ' گزارش مصرف مواد
        With frmMasrafeMavad.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

    Public Shared Sub ShowRptRialiAsnadKAsriEzafeh(ByVal aMDIParent As Form)
        With FrmRptRialiAsnadKAsriEzafeh.DefInstance
            .MdiParent = aMDIParent
            .Show()
            .Activate()
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub
    Public Shared Sub ShowRptMoghayeratShomareshAnbargardani(ByVal aMDIParent As Form, Optional ByVal aAnbarGardaniSN As Decimal = 0)
        ' گزازش مغایرت شمارش ها در انبار گردانی ها
        With FrmAnbargardaniMoghayeratBeyneShomaresh.DefInstance
            .MdiParent = aMDIParent
            .WindowState = FormWindowState.Maximized
            .Show()
            .Activate()
            DBLog.WriteLOG("Form", 0, , .Name, .Text)
        End With
    End Sub

End Class
