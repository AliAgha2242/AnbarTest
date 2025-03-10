' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1384/03/26
'ModifiedDate::
'Description::  فيلتر اسناد انبار
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports VB = Microsoft.VisualBasic

Public Class FrmFilterAsnadAnbar
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        ' For FrmFilterAsnadAnbar
        Dim vSql As String
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromSanadDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToSanadDate

        '//By Izadpanah-851208
        dclFSDate = New NetSql.Components.CDateCtrl(tp)
        dclFSDate.TextBox = txtFromSabtDate
        dclTSDate = New NetSql.Components.CDateCtrl(tp)
        dclTSDate.TextBox = txtToSabtDate
        '//By Izadpanah-851208

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

            'dclFSDate.Value = gHesabdariSalFDate
            'dclTSDate.Value = gHesabdariSalTDate
        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                                  cn,
                                                                                                  Functions.
                                                                                                     FTDBCommonFunctions _
                                                                                                     .enmDateFormat.
                                                                                                     Normal), 4) &
                             "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                         cn,
                                                                                         Functions.FTDBCommonFunctions.
                                                                                            enmDateFormat.Normal)

            'dclFSDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
            '                                                                      cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
            'dclTSDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
            '                                                                       cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        End If

        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvKala
        DvKala = New CDataView(cn)
        With DvKala
            .Init(pnlGridKalaSN, , pnlCmdKalaSN, pnlNKalaSN, EnumButtonOptions.boCmdFilter _
                                                              Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paKala"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgKala = .FlexGrid
            vfgKala.Editable = EditableSettings.flexEDKbdMouse
            If FilterNoeAnbarSN <> 0 Then
                .SQLWhere = " paKala.KalaSN IN ( Select kalaSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
            Else
                .SQLWhere = " paKala.KalaSN IN ( Select kalaSn From abSanadHa ) "
            End If
            .SQLOrderBy = " paKala.KalaNO "
            With .Fields
                With .Add("KalaSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("KalaNO", "TextBox")
                End With
                With .Add("KalaDS", "TextBox")
                End With
            End With
        End With
        'DvKala
        'DvNoeKala
        'Added By Nooshin Alipour in 14031206
        vSql = " select NoeKalaSN, NoeKalaDs,NoeKalaNO from PaNoeKala"
        DvNoeKala = New CDataView(cn)
        With DvNoeKala
            .Init(PnlGridNoeKala, , PnlCmdNoeKala, PnlNavNoeKala, EnumButtonOptions.boCmdFilter _
                                                              Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paNoeKala"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgNoeKala = .FlexGrid
            vfgNoeKala.Editable = EditableSettings.flexEDKbdMouse
            .SQLOrderBy = "paNoeKala.NoeKalaNO "
            .SQLWhere = " paNoeKala.NoeKalaSN IN ( Select NoekalaSN From paKala ) "
            'If FilterNoeAnbarSN <> 0 Then
            '    .SQLWhere = " paNoeKala.NoeKalaSN IN ( Select NoekalaSN  " &
            '                " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
            '                " INNER JOIN paKala ON paKala.KalaSN = abSanadHa.KalaSN  " &
            '                " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
            'Else
            '    .SQLWhere = " paNoeKala.NoeKalaSN IN ( Select NoekalaSN From paKala ) "
            'End If
            With .Fields
                With .Add("NoeKalaSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("NoeKalaNO", "TextBox")
                    .Caption = "کد نوع کالا"
                End With
                With .Add("NoeKalaDS", "TextBox")
                    .Caption = "نام نوع کالا"
                End With
            End With
            .Refresh()
        End With
        'NoeDvKala
        'Added By Nooshin Alipour in 14031206
        'DvNoeKala
        'DvTaminKonandeh
        DvTaminKonandeh = New CDataView(cn)
        With DvTaminKonandeh
            .Init(PanelTamin, , PanelTaminCom, PanelTaminNav, EnumButtonOptions.boCmdFilter _
                                                              Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paVw_TaminKonandeh"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgTaminKonandeh = .FlexGrid
            vfgTaminKonandeh.Editable = EditableSettings.flexEDKbdMouse

            With .Fields
                With .Add("TaminVahedeTejariSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("TaminVahedeTejariNo", "TextBox")
                    .Caption = "کد تامین کننده"
                End With
                With .Add("TaminVahedeTejariDs", "TextBox")
                    .Caption = "نام تامین کننده"
                End With
            End With
        End With
        'DvTaminKonandeh
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvNoeZayeat
        DvNoeZayeat = New CDataView(cn)
        With DvNoeZayeat
            .Init(pnlGridNoeZayeatSN, , pnlCmdNoeZayeatSN, pnlNNoeZayeatSN, EnumButtonOptions.boCmdFilter _
                                                                             Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paNoeZayeat"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgNoeZayeat = .FlexGrid
            vfgNoeZayeat.Editable = EditableSettings.flexEDKbdMouse
            If FilterNoeAnbarSN <> 0 Then
                .SQLWhere = " paNoeZayeat.NoeZayeatSN IN ( Select NoeZayeatSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
            Else
                .SQLWhere = " paNoeZayeat.NoeZayeatSN IN ( Select NoeZayeatSn From abSanadHa ) "
            End If
            .SQLOrderBy = " paNoeZayeat.NoeZayeatNO "
            With .Fields
                With .Add("NoeZayeatSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("NoeZayeatNO", "TextBox")
                End With
                With .Add("NoeZayeatDS", "TextBox")
                End With
            End With
        End With
        'DvNoeZayeat
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvNoeMarjooei
        DvNoeMarjooei = New CDataView(cn)
        With DvNoeMarjooei
            .Init(pnlGridNoeMarjooeiSN, , pnlCmdNoeMarjooeiSN, pnlNNoeMarjooeiSN, EnumButtonOptions.boCmdFilter _
                                                                                   Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paNoeMarjooei"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgNoeMarjooei = .FlexGrid
            vfgNoeMarjooei.Editable = EditableSettings.flexEDKbdMouse
            If FilterNoeAnbarSN <> 0 Then
                .SQLWhere = " paNoeMarjooei.NoeMarjooeiSN IN ( Select NoeMarjooeiSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
            Else
                .SQLWhere = " paNoeMarjooei.NoeMarjooeiSN IN ( Select NoeMarjooeiSn From abSanadHa ) "
            End If
            .SQLOrderBy = " paNoeMarjooei.NoeMarjooeiNO "
            With .Fields
                With .Add("NoeMarjooeiSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("NoeMarjooeiNO", "TextBox")
                End With
                With .Add("NoeMarjooeiDS", "TextBox")
                End With
            End With
        End With
        'DvNoeMarjooei
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvKalaStatusAmval
        DvKalaStatusAmval = New CDataView(cn)
        With DvKalaStatusAmval
            .Init(pnlGridKalaStatusAmvalSN, , pnlCmdKalaStatusAmvalSN, pnlNKalaStatusAmvalSN,
                   EnumButtonOptions.boCmdFilter _
                   Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "paKalaStatusAmval"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgKalaStatusAmval = .FlexGrid
            vfgKalaStatusAmval.Editable = EditableSettings.flexEDKbdMouse
            If FilterNoeAnbarSN <> 0 Then
                .SQLWhere = " paKalaStatusAmval.KalaStatusAmvalSN IN ( Select KalaStatusAmvalSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            "      INNER JOIN paKala ON abSanadHa.KalaSN = paKala.KalaSN  " &
                            " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
            Else
                .SQLWhere = " paKalaStatusAmval.KalaStatusAmvalSN IN ( Select KalaStatusAmvalSn From abSanadHa  " &
                            "      INNER JOIN paKala ON abSanadHa.KalaSN = paKala.KalaSN ) "
            End If
            .SQLOrderBy = " paKalaStatusAmval.KalaStatusAmvalDS "
            With .Fields
                With .Add("KalaStatusAmvalSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("KalaStatusAmvalDS", "TextBox")
                End With
            End With
        End With
        'DvKalaStatusAmval
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvTafsili
        vSql = " SELECT TOP 100 Percent TafsiliSN, CONVERT(BIGINT,TafsiliNO) AS TafsiliNO " &
               " ,  TafsiliNO  + ' - ' + TafsiliDS AS TafsiliDS From maTafsili " &
               " Where TafsiliSN IN ( Select TafsiliSN From abSanad where TafsiliSN IS NOT NULL ) "
        DvTafsili = New CDataView(cn)
        With DvTafsili
            .Init(pnlGridTafsiliSN, , pnlCmdTafsiliSN, pnlNTafsiliSN, EnumButtonOptions.boCmdFilter _
                                                                       Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "maTafsili"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgTafsili = .FlexGrid
            vfgTafsili.Editable = EditableSettings.flexEDKbdMouse
            .SQLWhere = " maTafsili.TafsiliSN IN ( Select TafsiliSN From abSanad where TafsiliSN IS NOT NULL ) And Status=1 "
            .SQLOrderBy = " maTafsili.TafsiliNO "
            With .Fields
                With .Add("TafsiliSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("TafsiliNO", "TextBox")
                End With
                With .Add("TafsiliDS", "TextBox")
                End With
            End With
            ' .Refresh()
        End With
        'DvTafsili
        'DvTaghazaKonandeh
        vSql = " select ChartSazemaniSN, ChartSazemaniNoDs from PaVWChartSazemani "
        DvTaghazaKonandeh = New CDataView(cn)
        With DvTaghazaKonandeh
            .Init(pnlGTaghazaKonandeh, , pnlCTaghazaKonandeh, pnlNTaghazaKonandeh, EnumButtonOptions.boCmdFilter _
                                                                       Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "PaVWChartSazemani"
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgTaghazaKonandeh = .FlexGrid
            vfgTaghazaKonandeh.Editable = EditableSettings.flexEDKbdMouse
            With .Fields
                With .Add("ChartSazemaniSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                    .Caption = "انتخاب"
                End With
                With .Add("ChartSazemaniNoDs", "TextBox")
                    .Caption = "واحد تقاضا کننده"
                End With
            End With
            ' .Refresh()
        End With
        'DvTaghazaKonandeh
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'DvTarakonesh
        DvTarakonesh = New CDataView(cn)
        With DvTarakonesh
            .Init(pnlGridTarakoneshSN, , pnlCmdTarakoneshSN, pnlNTarakoneshSN, EnumButtonOptions.boCmdFilter _
                                                                                Or EnumButtonOptions.boCmdFind)
            .AccessRight = EnumAccessRight.arView
            .TableName = "abTarakonesh"
            .SQLOrderBy = " CONVERT(INT,TarakoneshNO) "
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            vfgTarakonesh = .FlexGrid
            vfgTarakonesh.Editable = EditableSettings.flexEDKbdMouse

            With .Fields
                With .Add("TarakoneshSN", , gSNFieldOption)
                End With
                With .Add("{0} AS Selected", "CheckBox")
                End With
                With .Add("TarakoneshNO", "TextBox")
                End With
                With .Add("TarakoneshDS", "TextBox")
                End With
            End With
        End With
        'DvTarakonesh
        DvAnbarTree = New CDataView(cn)
        With DvAnbarTree
            .Init(PicG, , PicC, PicN, EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint _
                                       Or EnumButtonOptions.boCmdFilter)
            .CommandVisible(EnumCommands.cmExit) = False
            .TableName = "abVw_TreeAnbar"
            .Text = Me.Text
            .Text = FTDD.GetCaption("abVw_TreeAnbar")
            .EditInGrid = False
            .SQLWhere = " AnbarSN in (Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs ( " & gAnbarSN & "))"
            .SQLOrderBy = "SortField"
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            vfgTree = .FlexGrid
            vfgTree.Editable = EditableSettings.flexEDKbdMouse
            With .Fields
                With .Add("AnbarSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("Selected", "CheckBox")
                End With
                With .Add("AnbarDs", "TextBox")
                End With
                With .Add("VahedeTejariDs", "TextBox", EnumFieldOptions.foHidden)
                End With
                With .Add("AnbarSNParent", "TextBox", EnumFieldOptions.foHidden)
                End With
                With .Add("VahedeTejariSN", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With
                .Add("{dbo.abFn_GetTreeAnbarNodeLevel(AnbarSN)} as Level", , EnumFieldOptions.foHidden)
                .Add("{dbo.abFn_GetTreeAnbarSortField(AnbarSN)} as SortField", , EnumFieldOptions.foHidden)
            End With
        End With
        pKala_GoroohBandi =
            New Minoo.Applications.Paye.GoroohBandi(tp, cn, gSM, gSNFieldOption, gVahedeTejariSN, gVahedeTejariDs)
        pTarakoneshGoroohBandi =
            New Minoo.Applications.Paye.GoroohBandi(tp, cn, gSM, gSNFieldOption, gVahedeTejariSN, gVahedeTejariDs)
        ' For FrmFilterAsnadAnbar
        ' تنظيم پيش فرض خصوصيات
        SetProperty()
        ' تنظيم پيش فرض خصوصيات
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private WithEvents FtTabFilterSanad As Minoo.Controls.FTTabControl
    Private WithEvents tabpSanadDate As System.Windows.Forms.TabPage
    Private WithEvents btnFilterOK As System.Windows.Forms.Button
    Private WithEvents btnFilterCancel As System.Windows.Forms.Button
    Private WithEvents lblTozih As System.Windows.Forms.Label
    Private WithEvents tabpSanadStatus As System.Windows.Forms.TabPage
    Private WithEvents TabPNoeTarakoneshKalaSN As System.Windows.Forms.TabPage
    Private WithEvents TabPRezerv As System.Windows.Forms.TabPage
    Private WithEvents FraQC As System.Windows.Forms.GroupBox
    Private WithEvents chkNoeTarakoneshKalaNO1 As System.Windows.Forms.CheckBox
    Private WithEvents chkNoeTarakoneshKalaNO2 As System.Windows.Forms.CheckBox
    Private WithEvents chkNoeTarakoneshKalaNO3 As System.Windows.Forms.CheckBox
    Private WithEvents chkNoeTarakoneshKalaNO4 As System.Windows.Forms.CheckBox
    Private WithEvents FraSanadStaus As System.Windows.Forms.GroupBox
    Private WithEvents chkSanadStatus_1 As System.Windows.Forms.CheckBox
    Private WithEvents chkSanadStatus_4 As System.Windows.Forms.CheckBox
    Private WithEvents chkSanadStatus_8 As System.Windows.Forms.CheckBox
    Private WithEvents FraMohasebeRezerv As System.Windows.Forms.GroupBox
    Private WithEvents opnRezervNo As System.Windows.Forms.RadioButton
    Private WithEvents opnRezervYes As System.Windows.Forms.RadioButton
    Private WithEvents tabpSanadNO As System.Windows.Forms.TabPage
    Private WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Private WithEvents txtFromSanadDate As System.Windows.Forms.TextBox
    Private WithEvents txtToSanadDate As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents TabPKalaSN As System.Windows.Forms.TabPage
    Private WithEvents TabPGoroohBandiTarakonesh As System.Windows.Forms.TabPage
    Private WithEvents TabPTafsiliSN As System.Windows.Forms.TabPage
    Private WithEvents pnlSanadNO As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents lbl1 As System.Windows.Forms.Label
    Private WithEvents tabpShomarehSefaresh As System.Windows.Forms.TabPage
    Private WithEvents tabpTozih As System.Windows.Forms.TabPage
    Private WithEvents pnlShomarehSefaresh As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnGorooheTarakonesh As System.Windows.Forms.Button
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents btnDelWhere As System.Windows.Forms.Button
    Private WithEvents txtTozih As NetSql.Components.TextBox
    Private WithEvents txtToShomarehSefaresh As System.Windows.Forms.TextBox
    Private WithEvents txtFromShomarehSefaresh As System.Windows.Forms.TextBox
    Private WithEvents txtToSanadNO As System.Windows.Forms.TextBox
    Private WithEvents txtFromSanadNO As System.Windows.Forms.TextBox
    Public WithEvents grpboxTafsiliSN As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectAll As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll As System.Windows.Forms.Button
    Public WithEvents pnlNTafsiliSN As System.Windows.Forms.Panel
    Public WithEvents pnlGridTafsiliSN As System.Windows.Forms.Panel
    Public WithEvents pnlCmdTafsiliSN As System.Windows.Forms.Panel
    Friend WithEvents TabPGoroohBandiKalaSN As System.Windows.Forms.TabPage
    Friend WithEvents btnGorooheKala As System.Windows.Forms.Button
    Public WithEvents grpboxKalaSN As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectAll_KalaSN As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll_KalaSN As System.Windows.Forms.Button
    Public WithEvents pnlNKalaSN As System.Windows.Forms.Panel
    Public WithEvents pnlGridKalaSN As System.Windows.Forms.Panel
    Public WithEvents pnlCmdKalaSN As System.Windows.Forms.Panel
    Friend WithEvents tabpShomarehRahgiri As System.Windows.Forms.TabPage
    Friend WithEvents pnlKalaPhiziki As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtToShomarehRahgiri As System.Windows.Forms.TextBox
    Friend WithEvents txtFromShomarehRahgiri As System.Windows.Forms.TextBox
    Friend WithEvents TabpTarakoneshSN As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents pnlGridTarakoneshSN As System.Windows.Forms.Panel
    Public WithEvents btnSelectAll_TarakoneshSN As System.Windows.Forms.Button
    Public WithEvents BtnDeselectAll_TarakoneshSN As System.Windows.Forms.Button
    Public WithEvents pnlCmdTarakoneshSN As System.Windows.Forms.Panel
    Public WithEvents pnlNTarakoneshSN As System.Windows.Forms.Panel
    Private WithEvents tpShomarehRahgiri As System.Windows.Forms.TabPage
    Private WithEvents tabpKalaWhere As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GrpKalaWhere As System.Windows.Forms.GroupBox
    Friend WithEvents optGardeshDar As System.Windows.Forms.RadioButton
    Friend WithEvents optMandehDar As System.Windows.Forms.RadioButton
    Private WithEvents tabpDarjKalaPhizikiFor As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optAllKalaPhiziki As System.Windows.Forms.RadioButton
    Friend WithEvents optAllKalaPhizikiMojoodiMoghayer As System.Windows.Forms.RadioButton
    Friend WithEvents optAllKalaPhizikiLastMoghayer As System.Windows.Forms.RadioButton
    Friend WithEvents optGardeshAll As System.Windows.Forms.RadioButton
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents dcbabShomareshMoghayer As NetSql.Components.DataCombo
    Public WithEvents dcbFabShomareshLast As NetSql.Components.DataCombo
    Public WithEvents dcbTabShomareshLast As NetSql.Components.DataCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkCopyShomaresh As System.Windows.Forms.CheckBox
    Public WithEvents dbcCopyTShomareshSN As NetSql.Components.DataCombo
    Public WithEvents dbcCopyFShomareshSN As NetSql.Components.DataCombo
    Friend WithEvents opnKalaGardeshDar As System.Windows.Forms.RadioButton
    Friend WithEvents opnKalaAnbar As System.Windows.Forms.RadioButton
    Friend WithEvents TabPNoeZayeatSN As System.Windows.Forms.TabPage
    Public WithEvents grpboxNoeZayeatSN As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectAll_NoeZayeatSN As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll_NoeZayeatSN As System.Windows.Forms.Button
    Public WithEvents pnlNNoeZayeatSN As System.Windows.Forms.Panel
    Public WithEvents pnlGridNoeZayeatSN As System.Windows.Forms.Panel
    Public WithEvents pnlCmdNoeZayeatSN As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents opnKalaRaked As System.Windows.Forms.RadioButton
    Friend WithEvents opnKalaMandehdar As System.Windows.Forms.RadioButton
    Friend WithEvents opnKalaWithCount As System.Windows.Forms.RadioButton
    Friend WithEvents txtKalaSaderehCount As System.Windows.Forms.TextBox
    Friend WithEvents txtKalaVaredehCount As System.Windows.Forms.TextBox
    Friend WithEvents chkAvalDoreh As System.Windows.Forms.CheckBox
    Public WithEvents btnRefresh_KalaSN As System.Windows.Forms.Button
    Friend WithEvents TabPNoeMarjooeiSN As System.Windows.Forms.TabPage
    Public WithEvents grpboxNoeMarjooeiSN As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectAll_NoeMarjooeiSN As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll_NoeMarjooeiSN As System.Windows.Forms.Button
    Public WithEvents pnlNNoeMarjooeiSN As System.Windows.Forms.Panel
    Public WithEvents pnlGridNoeMarjooeiSN As System.Windows.Forms.Panel
    Public WithEvents pnlCmdNoeMarjooeiSN As System.Windows.Forms.Panel
    Friend WithEvents chkDarjKalaPhiziki As System.Windows.Forms.CheckBox
    Friend WithEvents TabpKalaStatusAmvalSN As System.Windows.Forms.TabPage
    Public WithEvents grpboxKalaStatusAmvalSN As System.Windows.Forms.GroupBox
    Public WithEvents btnDeselectAll_KalaStatusAmvalSN As System.Windows.Forms.Button
    Public WithEvents pnlNKalaStatusAmvalSN As System.Windows.Forms.Panel
    Public WithEvents pnlGridKalaStatusAmvalSN As System.Windows.Forms.Panel
    Public WithEvents pnlCmdKalaStatusAmvalSN As System.Windows.Forms.Panel
    Public WithEvents btnSelectAll_KalaStatusAmvalSN As System.Windows.Forms.Button
    Friend WithEvents chkNoeTarakoneshKalaNO0 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoeTarakoneshKalaNO5 As System.Windows.Forms.CheckBox
    Friend WithEvents TabChideman As System.Windows.Forms.TabPage
    Friend WithEvents btnChidemanKala As System.Windows.Forms.Button
    Friend WithEvents chkMahaleChideman As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFromSabtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToSabtDate As System.Windows.Forms.TextBox
    Friend WithEvents TabpSabtDate As System.Windows.Forms.TabPage
    Friend WithEvents TabMashinNo As System.Windows.Forms.TabPage
    Public WithEvents lblShomarehMashin As System.Windows.Forms.Label
    Public WithEvents lblShomarehBarnameh As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents txtFromShomarehMashin As System.Windows.Forms.TextBox
    Public WithEvents txtFromShomarehBarnameh As System.Windows.Forms.TextBox
    Public WithEvents txtToShomarehBarnameh As System.Windows.Forms.TextBox
    Public WithEvents txtToShomarehMashin As System.Windows.Forms.TextBox
    Public WithEvents label As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TabAnbar As System.Windows.Forms.TabPage
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents PicN As System.Windows.Forms.Panel
    Public WithEvents PicG As System.Windows.Forms.Panel
    Public WithEvents PicC As System.Windows.Forms.Panel
    Public WithEvents btnSelectAllAnbar As System.Windows.Forms.Button
    Public WithEvents btnDeselectAllAnbar As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmbNoeMahsool As cmpCheckedComboBox
    Private WithEvents TabTaghazaKonandeh As System.Windows.Forms.TabPage
    Public WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectAll_TaghazaKonandeh As System.Windows.Forms.Button
    Public WithEvents btnDeSelectAll_TaghazaKonandeh As System.Windows.Forms.Button
    Public WithEvents pnlNTaghazaKonandeh As System.Windows.Forms.Panel
    Public WithEvents pnlGTaghazaKonandeh As System.Windows.Forms.Panel
    Public WithEvents pnlCTaghazaKonandeh As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbMahiateKala As cmpCheckedComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbNoeAnbar As cmpCheckedComboBox
    Public WithEvents btnRefresh_AnbarSN As System.Windows.Forms.Button
    Friend WithEvents chkNoeTarakoneshKalaNO6 As System.Windows.Forms.CheckBox
    Friend WithEvents TabTaminKonandeh As TabPage
    Public WithEvents BtnDeselectTaminkonandeh As Button
    Public WithEvents PanelTaminNav As Panel
    Public WithEvents PanelTamin As Panel
    Public WithEvents PanelTaminCom As Panel
    Public WithEvents tmrResort As System.Windows.Forms.Timer
    'Added By Nooshin Alipour in 14031206
    Friend WithEvents CmbNoeKala As cmpCheckedComboBox
    Private WithEvents TabPNoeKala As System.Windows.Forms.TabPage
    Public WithEvents GrpBoxNoeKala As System.Windows.Forms.GroupBox
    Public WithEvents PnlGridNoeKala As System.Windows.Forms.Panel
    Public WithEvents PnlNavNoeKala As System.Windows.Forms.Panel
    Public WithEvents PnlCmdNoeKala As System.Windows.Forms.Panel
    Public WithEvents btnSelectAll_NoeKala As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll_NoeKala As System.Windows.Forms.Button
    'Public WithEvents btnRefresh_NoeKala As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CmbMahiateKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilterAsnadAnbar))
        Dim CmbNoeMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbNoeAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbNoeKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.FtTabFilterSanad = New Minoo.Controls.FTTabControl()
        Me.TabPKalaSN = New System.Windows.Forms.TabPage()
        Me.btnSelectAll_KalaSN = New System.Windows.Forms.Button()
        Me.btnDeselectAll_KalaSN = New System.Windows.Forms.Button()
        Me.grpboxKalaSN = New System.Windows.Forms.GroupBox()
        Me.CmbMahiateKala = New cmpCheckedComboBox(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbNoeMahsool = New cmpCheckedComboBox(Me.components)
        Me.btnRefresh_KalaSN = New System.Windows.Forms.Button()
        Me.chkAvalDoreh = New System.Windows.Forms.CheckBox()
        Me.txtKalaSaderehCount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtKalaVaredehCount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.opnKalaWithCount = New System.Windows.Forms.RadioButton()
        Me.opnKalaRaked = New System.Windows.Forms.RadioButton()
        Me.opnKalaGardeshDar = New System.Windows.Forms.RadioButton()
        Me.opnKalaAnbar = New System.Windows.Forms.RadioButton()
        Me.opnKalaMandehdar = New System.Windows.Forms.RadioButton()
        Me.pnlNKalaSN = New System.Windows.Forms.Panel()
        Me.pnlCmdKalaSN = New System.Windows.Forms.Panel()
        Me.pnlGridKalaSN = New System.Windows.Forms.Panel()
        Me.TabTaminKonandeh = New System.Windows.Forms.TabPage()
        Me.BtnDeselectTaminkonandeh = New System.Windows.Forms.Button()
        Me.PanelTaminNav = New System.Windows.Forms.Panel()
        Me.PanelTamin = New System.Windows.Forms.Panel()
        Me.PanelTaminCom = New System.Windows.Forms.Panel()
        Me.TabAnbar = New System.Windows.Forms.TabPage()
        Me.btnRefresh_AnbarSN = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmbNoeAnbar = New cmpCheckedComboBox(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectAllAnbar = New System.Windows.Forms.Button()
        Me.btnDeselectAllAnbar = New System.Windows.Forms.Button()
        Me.PicN = New System.Windows.Forms.Panel()
        Me.PicG = New System.Windows.Forms.Panel()
        Me.PicC = New System.Windows.Forms.Panel()
        Me.tabpSanadDate = New System.Windows.Forms.TabPage()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromSanadDate = New System.Windows.Forms.TextBox()
        Me.txtToSanadDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabChideman = New System.Windows.Forms.TabPage()
        Me.chkMahaleChideman = New System.Windows.Forms.CheckBox()
        Me.btnChidemanKala = New System.Windows.Forms.Button()
        Me.TabpSabtDate = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFromSabtDate = New System.Windows.Forms.TextBox()
        Me.txtToSabtDate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabpShomarehSefaresh = New System.Windows.Forms.TabPage()
        Me.pnlShomarehSefaresh = New System.Windows.Forms.Panel()
        Me.txtToShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabpKalaStatusAmvalSN = New System.Windows.Forms.TabPage()
        Me.grpboxKalaStatusAmvalSN = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll_KalaStatusAmvalSN = New System.Windows.Forms.Button()
        Me.btnDeselectAll_KalaStatusAmvalSN = New System.Windows.Forms.Button()
        Me.pnlNKalaStatusAmvalSN = New System.Windows.Forms.Panel()
        Me.pnlGridKalaStatusAmvalSN = New System.Windows.Forms.Panel()
        Me.pnlCmdKalaStatusAmvalSN = New System.Windows.Forms.Panel()
        Me.tabpKalaWhere = New System.Windows.Forms.TabPage()
        Me.GrpKalaWhere = New System.Windows.Forms.GroupBox()
        Me.optGardeshDar = New System.Windows.Forms.RadioButton()
        Me.optMandehDar = New System.Windows.Forms.RadioButton()
        Me.optGardeshAll = New System.Windows.Forms.RadioButton()
        Me.TabPRezerv = New System.Windows.Forms.TabPage()
        Me.FraMohasebeRezerv = New System.Windows.Forms.GroupBox()
        Me.opnRezervNo = New System.Windows.Forms.RadioButton()
        Me.opnRezervYes = New System.Windows.Forms.RadioButton()
        Me.TabPGoroohBandiTarakonesh = New System.Windows.Forms.TabPage()
        Me.btnGorooheTarakonesh = New System.Windows.Forms.Button()
        Me.tpShomarehRahgiri = New System.Windows.Forms.TabPage()
        Me.pnlKalaPhiziki = New System.Windows.Forms.Panel()
        Me.txtToShomarehRahgiri = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFromShomarehRahgiri = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabpSanadStatus = New System.Windows.Forms.TabPage()
        Me.FraSanadStaus = New System.Windows.Forms.GroupBox()
        Me.chkSanadStatus_1 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_4 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_8 = New System.Windows.Forms.CheckBox()
        Me.TabPGoroohBandiKalaSN = New System.Windows.Forms.TabPage()
        Me.btnGorooheKala = New System.Windows.Forms.Button()
        Me.tabpDarjKalaPhizikiFor = New System.Windows.Forms.TabPage()
        Me.dbcCopyTShomareshSN = New NetSql.Components.DataCombo(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dbcCopyFShomareshSN = New NetSql.Components.DataCombo(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDarjKalaPhiziki = New System.Windows.Forms.CheckBox()
        Me.dcbTabShomareshLast = New NetSql.Components.DataCombo(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dcbFabShomareshLast = New NetSql.Components.DataCombo(Me.components)
        Me.dcbabShomareshMoghayer = New NetSql.Components.DataCombo(Me.components)
        Me.optAllKalaPhiziki = New System.Windows.Forms.RadioButton()
        Me.optAllKalaPhizikiMojoodiMoghayer = New System.Windows.Forms.RadioButton()
        Me.optAllKalaPhizikiLastMoghayer = New System.Windows.Forms.RadioButton()
        Me.chkCopyShomaresh = New System.Windows.Forms.CheckBox()
        Me.TabPNoeTarakoneshKalaSN = New System.Windows.Forms.TabPage()
        Me.FraQC = New System.Windows.Forms.GroupBox()
        Me.chkNoeTarakoneshKalaNO6 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO5 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO0 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO1 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO2 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO3 = New System.Windows.Forms.CheckBox()
        Me.chkNoeTarakoneshKalaNO4 = New System.Windows.Forms.CheckBox()
        Me.tabpSanadNO = New System.Windows.Forms.TabPage()
        Me.pnlSanadNO = New System.Windows.Forms.Panel()
        Me.txtToSanadNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFromSanadNO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.TabPNoeMarjooeiSN = New System.Windows.Forms.TabPage()
        Me.grpboxNoeMarjooeiSN = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll_NoeMarjooeiSN = New System.Windows.Forms.Button()
        Me.btnDeselectAll_NoeMarjooeiSN = New System.Windows.Forms.Button()
        Me.pnlNNoeMarjooeiSN = New System.Windows.Forms.Panel()
        Me.pnlGridNoeMarjooeiSN = New System.Windows.Forms.Panel()
        Me.pnlCmdNoeMarjooeiSN = New System.Windows.Forms.Panel()
        Me.TabPTafsiliSN = New System.Windows.Forms.TabPage()
        Me.grpboxTafsiliSN = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.pnlNTafsiliSN = New System.Windows.Forms.Panel()
        Me.pnlGridTafsiliSN = New System.Windows.Forms.Panel()
        Me.pnlCmdTafsiliSN = New System.Windows.Forms.Panel()
        Me.TabpTarakoneshSN = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll_TarakoneshSN = New System.Windows.Forms.Button()
        Me.BtnDeselectAll_TarakoneshSN = New System.Windows.Forms.Button()
        Me.pnlNTarakoneshSN = New System.Windows.Forms.Panel()
        Me.pnlGridTarakoneshSN = New System.Windows.Forms.Panel()
        Me.pnlCmdTarakoneshSN = New System.Windows.Forms.Panel()
        Me.tabpTozih = New System.Windows.Forms.TabPage()
        Me.lblTozih = New System.Windows.Forms.Label()
        Me.txtTozih = New NetSql.Components.TextBox(Me.components)
        Me.TabPNoeZayeatSN = New System.Windows.Forms.TabPage()
        Me.grpboxNoeZayeatSN = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll_NoeZayeatSN = New System.Windows.Forms.Button()
        Me.btnDeselectAll_NoeZayeatSN = New System.Windows.Forms.Button()
        Me.pnlNNoeZayeatSN = New System.Windows.Forms.Panel()
        Me.pnlGridNoeZayeatSN = New System.Windows.Forms.Panel()
        Me.pnlCmdNoeZayeatSN = New System.Windows.Forms.Panel()
        Me.TabMashinNo = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblShomarehMashin = New System.Windows.Forms.Label()
        Me.txtToShomarehMashin = New System.Windows.Forms.TextBox()
        Me.txtFromShomarehMashin = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFromShomarehBarnameh = New System.Windows.Forms.TextBox()
        Me.lblShomarehBarnameh = New System.Windows.Forms.Label()
        Me.txtToShomarehBarnameh = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabTaghazaKonandeh = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll_TaghazaKonandeh = New System.Windows.Forms.Button()
        Me.btnDeSelectAll_TaghazaKonandeh = New System.Windows.Forms.Button()
        Me.pnlNTaghazaKonandeh = New System.Windows.Forms.Panel()
        Me.pnlGTaghazaKonandeh = New System.Windows.Forms.Panel()
        Me.pnlCTaghazaKonandeh = New System.Windows.Forms.Panel()
        Me.btnFilterOK = New System.Windows.Forms.Button()
        Me.btnFilterCancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelWhere = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.tmrResort = New System.Windows.Forms.Timer(Me.components)
        'Added By Nooshin Alipour in 14031206
        Me.CmbNoeKala = New cmpCheckedComboBox(Me.components)
        Me.TabPNoeKala = New System.Windows.Forms.TabPage()
        Me.GrpBoxNoeKala = New System.Windows.Forms.GroupBox()
        Me.PnlGridNoeKala = New System.Windows.Forms.Panel()
        Me.PnlNavNoeKala = New System.Windows.Forms.Panel()
        Me.PnlCmdNoeKala = New System.Windows.Forms.Panel()
        Me.btnDeselectAll_NoeKala = New System.Windows.Forms.Button()
        Me.btnSelectAll_NoeKala = New System.Windows.Forms.Button()
        'Me.btnRefresh_NoeKala = New System.Windows.Forms.Button()
        Me.FtTabFilterSanad.SuspendLayout()
        Me.TabPKalaSN.SuspendLayout()
        Me.grpboxKalaSN.SuspendLayout()
        Me.TabTaminKonandeh.SuspendLayout()
        Me.TabAnbar.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.tabpSanadDate.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.TabChideman.SuspendLayout()
        Me.TabpSabtDate.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabpShomarehSefaresh.SuspendLayout()
        Me.pnlShomarehSefaresh.SuspendLayout()
        Me.TabpKalaStatusAmvalSN.SuspendLayout()
        Me.grpboxKalaStatusAmvalSN.SuspendLayout()
        Me.tabpKalaWhere.SuspendLayout()
        Me.GrpKalaWhere.SuspendLayout()
        Me.TabPRezerv.SuspendLayout()
        Me.FraMohasebeRezerv.SuspendLayout()
        Me.TabPGoroohBandiTarakonesh.SuspendLayout()
        Me.tpShomarehRahgiri.SuspendLayout()
        Me.pnlKalaPhiziki.SuspendLayout()
        Me.tabpSanadStatus.SuspendLayout()
        Me.FraSanadStaus.SuspendLayout()
        Me.TabPGoroohBandiKalaSN.SuspendLayout()
        Me.tabpDarjKalaPhizikiFor.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPNoeTarakoneshKalaSN.SuspendLayout()
        Me.FraQC.SuspendLayout()
        Me.tabpSanadNO.SuspendLayout()
        Me.pnlSanadNO.SuspendLayout()
        Me.TabPNoeMarjooeiSN.SuspendLayout()
        Me.grpboxNoeMarjooeiSN.SuspendLayout()
        Me.TabPTafsiliSN.SuspendLayout()
        Me.grpboxTafsiliSN.SuspendLayout()
        Me.TabpTarakoneshSN.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabpTozih.SuspendLayout()
        Me.TabPNoeZayeatSN.SuspendLayout()
        Me.grpboxNoeZayeatSN.SuspendLayout()
        Me.TabMashinNo.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabTaghazaKonandeh.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPNoeKala.SuspendLayout()
        Me.GrpBoxNoeKala.SuspendLayout()
        Me.SuspendLayout()
        '
        'FtTabFilterSanad
        '
        Me.FtTabFilterSanad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPKalaSN)
        Me.FtTabFilterSanad.Controls.Add(Me.TabTaminKonandeh)
        Me.FtTabFilterSanad.Controls.Add(Me.TabAnbar)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpSanadDate)
        Me.FtTabFilterSanad.Controls.Add(Me.TabChideman)
        Me.FtTabFilterSanad.Controls.Add(Me.TabpSabtDate)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpShomarehSefaresh)
        Me.FtTabFilterSanad.Controls.Add(Me.TabpKalaStatusAmvalSN)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpKalaWhere)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPRezerv)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPGoroohBandiTarakonesh)
        Me.FtTabFilterSanad.Controls.Add(Me.tpShomarehRahgiri)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpSanadStatus)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPGoroohBandiKalaSN)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpDarjKalaPhizikiFor)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPNoeTarakoneshKalaSN)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpSanadNO)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPNoeMarjooeiSN)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPTafsiliSN)
        Me.FtTabFilterSanad.Controls.Add(Me.TabpTarakoneshSN)
        Me.FtTabFilterSanad.Controls.Add(Me.tabpTozih)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPNoeZayeatSN)
        Me.FtTabFilterSanad.Controls.Add(Me.TabMashinNo)
        Me.FtTabFilterSanad.Controls.Add(Me.TabTaghazaKonandeh)
        Me.FtTabFilterSanad.Controls.Add(Me.TabPNoeKala)
        Me.FtTabFilterSanad.HotTrack = True
        Me.FtTabFilterSanad.ItemSize = New System.Drawing.Size(84, 25)
        Me.FtTabFilterSanad.Location = New System.Drawing.Point(0, 0)
        Me.FtTabFilterSanad.Mirrored = True
        Me.FtTabFilterSanad.Multiline = True
        Me.FtTabFilterSanad.Name = "FtTabFilterSanad"
        Me.FtTabFilterSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FtTabFilterSanad.SelectedIndex = 0
        Me.FtTabFilterSanad.Size = New System.Drawing.Size(671, 394)
        Me.FtTabFilterSanad.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.FtTabFilterSanad.TabIndex = 0
        '
        'TabPKalaSN
        '
        Me.TabPKalaSN.Controls.Add(Me.btnSelectAll_KalaSN)
        Me.TabPKalaSN.Controls.Add(Me.btnDeselectAll_KalaSN)
        Me.TabPKalaSN.Controls.Add(Me.grpboxKalaSN)
        Me.TabPKalaSN.Controls.Add(Me.pnlNKalaSN)
        Me.TabPKalaSN.Controls.Add(Me.pnlCmdKalaSN)
        Me.TabPKalaSN.Controls.Add(Me.pnlGridKalaSN)
        Me.TabPKalaSN.Location = New System.Drawing.Point(4, 104)
        Me.TabPKalaSN.Name = "TabPKalaSN"
        Me.TabPKalaSN.Size = New System.Drawing.Size(663, 286)
        Me.TabPKalaSN.TabIndex = 14
        Me.TabPKalaSN.Text = "کالا"
        '
        'btnSelectAll_KalaSN
        '
        Me.btnSelectAll_KalaSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_KalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_KalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_KalaSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_KalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_KalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_KalaSN.Location = New System.Drawing.Point(337, 201)
        Me.btnSelectAll_KalaSN.Name = "btnSelectAll_KalaSN"
        Me.btnSelectAll_KalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_KalaSN.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_KalaSN.TabIndex = 6
        Me.btnSelectAll_KalaSN.Text = "همه"
        Me.btnSelectAll_KalaSN.UseVisualStyleBackColor = False
        '
        'btnDeselectAll_KalaSN
        '
        Me.btnDeselectAll_KalaSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll_KalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll_KalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll_KalaSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll_KalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll_KalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll_KalaSN.Location = New System.Drawing.Point(293, 201)
        Me.btnDeselectAll_KalaSN.Name = "btnDeselectAll_KalaSN"
        Me.btnDeselectAll_KalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll_KalaSN.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll_KalaSN.TabIndex = 5
        Me.btnDeselectAll_KalaSN.Text = "هيچ "
        Me.btnDeselectAll_KalaSN.UseVisualStyleBackColor = False
        '
        'grpboxKalaSN
        '
        Me.grpboxKalaSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxKalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.grpboxKalaSN.Controls.Add(Me.CmbMahiateKala)
        Me.grpboxKalaSN.Controls.Add(Me.Label21)
        Me.grpboxKalaSN.Controls.Add(Me.Label20)
        Me.grpboxKalaSN.Controls.Add(Me.CmbNoeMahsool)
        Me.grpboxKalaSN.Controls.Add(Me.btnRefresh_KalaSN)
        Me.grpboxKalaSN.Controls.Add(Me.chkAvalDoreh)
        Me.grpboxKalaSN.Controls.Add(Me.txtKalaSaderehCount)
        Me.grpboxKalaSN.Controls.Add(Me.Label14)
        Me.grpboxKalaSN.Controls.Add(Me.txtKalaVaredehCount)
        Me.grpboxKalaSN.Controls.Add(Me.Label15)
        Me.grpboxKalaSN.Controls.Add(Me.opnKalaWithCount)
        Me.grpboxKalaSN.Controls.Add(Me.opnKalaRaked)
        Me.grpboxKalaSN.Controls.Add(Me.opnKalaGardeshDar)
        Me.grpboxKalaSN.Controls.Add(Me.opnKalaAnbar)
        Me.grpboxKalaSN.Controls.Add(Me.opnKalaMandehdar)
        Me.grpboxKalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxKalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpboxKalaSN.Location = New System.Drawing.Point(0, 0)
        Me.grpboxKalaSN.Name = "grpboxKalaSN"
        Me.grpboxKalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpboxKalaSN.Size = New System.Drawing.Size(664, 84)
        Me.grpboxKalaSN.TabIndex = 3
        Me.grpboxKalaSN.TabStop = False
        '
        'CmbMahiateKala
        '
        Me.CmbMahiateKala.BackColor = System.Drawing.Color.White
        CmbMahiateKala_DesignTimeLayout.LayoutString = resources.GetString("CmbMahiateKala_DesignTimeLayout.LayoutString")
        Me.CmbMahiateKala.DesignTimeLayout = CmbMahiateKala_DesignTimeLayout
        Me.CmbMahiateKala.LateBinding = True
        Me.CmbMahiateKala.LateBindingTop = "100"
        Me.CmbMahiateKala.Location = New System.Drawing.Point(60, 55)
        Me.CmbMahiateKala.Name = "CmbMahiateKala"
        Me.CmbMahiateKala.SaveSettings = False
        Me.CmbMahiateKala.Size = New System.Drawing.Size(187, 20)
        Me.CmbMahiateKala.TabIndex = 45
        Me.CmbMahiateKala.ValuesDataMember = Nothing
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(249, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(60, 21)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "ماهیت کالا :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(249, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(45, 21)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "نوع کالا :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbNoeMahsool
        '
        Me.CmbNoeMahsool.BackColor = System.Drawing.Color.White
        CmbNoeMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeMahsool_DesignTimeLayout.LayoutString")
        Me.CmbNoeMahsool.DesignTimeLayout = CmbNoeMahsool_DesignTimeLayout
        Me.CmbNoeMahsool.LateBinding = True
        Me.CmbNoeMahsool.LateBindingTop = "100"
        Me.CmbNoeMahsool.Location = New System.Drawing.Point(60, 31)
        Me.CmbNoeMahsool.Name = "CmbNoeMahsool"
        Me.CmbNoeMahsool.SaveSettings = False
        Me.CmbNoeMahsool.Size = New System.Drawing.Size(187, 20)
        Me.CmbNoeMahsool.TabIndex = 41
        Me.CmbNoeMahsool.ValuesDataMember = Nothing
        '
        'btnRefresh_KalaSN
        '
        Me.btnRefresh_KalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh_KalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRefresh_KalaSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefresh_KalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_KalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefresh_KalaSN.Location = New System.Drawing.Point(5, 40)
        Me.btnRefresh_KalaSN.Name = "btnRefresh_KalaSN"
        Me.btnRefresh_KalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRefresh_KalaSN.Size = New System.Drawing.Size(49, 24)
        Me.btnRefresh_KalaSN.TabIndex = 40
        Me.btnRefresh_KalaSN.Text = "بازخواني"
        Me.btnRefresh_KalaSN.UseVisualStyleBackColor = False
        '
        'chkAvalDoreh
        '
        Me.chkAvalDoreh.Checked = True
        Me.chkAvalDoreh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAvalDoreh.ForeColor = System.Drawing.Color.Navy
        Me.chkAvalDoreh.Location = New System.Drawing.Point(6, 9)
        Me.chkAvalDoreh.Name = "chkAvalDoreh"
        Me.chkAvalDoreh.Size = New System.Drawing.Size(119, 19)
        Me.chkAvalDoreh.TabIndex = 39
        Me.chkAvalDoreh.Text = "با احتساب اول دوره"
        '
        'txtKalaSaderehCount
        '
        Me.txtKalaSaderehCount.Location = New System.Drawing.Point(307, 31)
        Me.txtKalaSaderehCount.MaxLength = 15
        Me.txtKalaSaderehCount.Name = "txtKalaSaderehCount"
        Me.txtKalaSaderehCount.Size = New System.Drawing.Size(35, 20)
        Me.txtKalaSaderehCount.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(345, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(32, 21)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "صادره"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKalaVaredehCount
        '
        Me.txtKalaVaredehCount.Location = New System.Drawing.Point(380, 31)
        Me.txtKalaVaredehCount.MaxLength = 15
        Me.txtKalaVaredehCount.Name = "txtKalaVaredehCount"
        Me.txtKalaVaredehCount.Size = New System.Drawing.Size(35, 20)
        Me.txtKalaVaredehCount.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(418, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(32, 21)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "وارده"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opnKalaWithCount
        '
        Me.opnKalaWithCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnKalaWithCount.ForeColor = System.Drawing.Color.Navy
        Me.opnKalaWithCount.Location = New System.Drawing.Point(438, 31)
        Me.opnKalaWithCount.Name = "opnKalaWithCount"
        Me.opnKalaWithCount.Size = New System.Drawing.Size(222, 21)
        Me.opnKalaWithCount.TabIndex = 11
        Me.opnKalaWithCount.Text = "کالاهاي با تعداد سند بزرگتر يا مساوي  :"
        '
        'opnKalaRaked
        '
        Me.opnKalaRaked.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnKalaRaked.ForeColor = System.Drawing.Color.Navy
        Me.opnKalaRaked.Location = New System.Drawing.Point(293, 9)
        Me.opnKalaRaked.Name = "opnKalaRaked"
        Me.opnKalaRaked.Size = New System.Drawing.Size(147, 18)
        Me.opnKalaRaked.TabIndex = 9
        Me.opnKalaRaked.Text = "کالاهاي راکد (فاقد گردش)"
        '
        'opnKalaGardeshDar
        '
        Me.opnKalaGardeshDar.Checked = True
        Me.opnKalaGardeshDar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnKalaGardeshDar.ForeColor = System.Drawing.Color.Navy
        Me.opnKalaGardeshDar.Location = New System.Drawing.Point(444, 9)
        Me.opnKalaGardeshDar.Name = "opnKalaGardeshDar"
        Me.opnKalaGardeshDar.Size = New System.Drawing.Size(107, 18)
        Me.opnKalaGardeshDar.TabIndex = 8
        Me.opnKalaGardeshDar.TabStop = True
        Me.opnKalaGardeshDar.Text = "کالاهاي گردش‌دار"
        '
        'opnKalaAnbar
        '
        Me.opnKalaAnbar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnKalaAnbar.Location = New System.Drawing.Point(555, 9)
        Me.opnKalaAnbar.Name = "opnKalaAnbar"
        Me.opnKalaAnbar.Size = New System.Drawing.Size(105, 18)
        Me.opnKalaAnbar.TabIndex = 7
        Me.opnKalaAnbar.Text = "همه کالاهاي انبار"
        '
        'opnKalaMandehdar
        '
        Me.opnKalaMandehdar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnKalaMandehdar.Location = New System.Drawing.Point(168, 9)
        Me.opnKalaMandehdar.Name = "opnKalaMandehdar"
        Me.opnKalaMandehdar.Size = New System.Drawing.Size(114, 18)
        Me.opnKalaMandehdar.TabIndex = 10
        Me.opnKalaMandehdar.Text = "کالاهاي مانده‌دار"
        '
        'pnlNKalaSN
        '
        Me.pnlNKalaSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNKalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNKalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNKalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNKalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNKalaSN.Location = New System.Drawing.Point(5, 201)
        Me.pnlNKalaSN.Name = "pnlNKalaSN"
        Me.pnlNKalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNKalaSN.Size = New System.Drawing.Size(280, 29)
        Me.pnlNKalaSN.TabIndex = 3
        '
        'pnlCmdKalaSN
        '
        Me.pnlCmdKalaSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdKalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdKalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdKalaSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdKalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdKalaSN.Location = New System.Drawing.Point(382, 202)
        Me.pnlCmdKalaSN.Name = "pnlCmdKalaSN"
        Me.pnlCmdKalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdKalaSN.Size = New System.Drawing.Size(276, 29)
        Me.pnlCmdKalaSN.TabIndex = 1
        Me.pnlCmdKalaSN.TabStop = True
        '
        'pnlGridKalaSN
        '
        Me.pnlGridKalaSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridKalaSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridKalaSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridKalaSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridKalaSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridKalaSN.Location = New System.Drawing.Point(3, 90)
        Me.pnlGridKalaSN.Name = "pnlGridKalaSN"
        Me.pnlGridKalaSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridKalaSN.Size = New System.Drawing.Size(654, 105)
        Me.pnlGridKalaSN.TabIndex = 2
        '
        'TabTaminKonandeh
        '
        Me.TabTaminKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.TabTaminKonandeh.Controls.Add(Me.BtnDeselectTaminkonandeh)
        Me.TabTaminKonandeh.Controls.Add(Me.PanelTaminNav)
        Me.TabTaminKonandeh.Controls.Add(Me.PanelTamin)
        Me.TabTaminKonandeh.Controls.Add(Me.PanelTaminCom)
        Me.TabTaminKonandeh.Location = New System.Drawing.Point(4, 29)
        Me.TabTaminKonandeh.Name = "TabTaminKonandeh"
        Me.TabTaminKonandeh.Size = New System.Drawing.Size(663, 361)
        Me.TabTaminKonandeh.TabIndex = 30
        Me.TabTaminKonandeh.Text = "تامین کننده"
        '
        'BtnDeselectTaminkonandeh
        '
        Me.BtnDeselectTaminkonandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeselectTaminkonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDeselectTaminkonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDeselectTaminkonandeh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDeselectTaminkonandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeselectTaminkonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDeselectTaminkonandeh.Location = New System.Drawing.Point(310, 349)
        Me.BtnDeselectTaminkonandeh.Name = "BtnDeselectTaminkonandeh"
        Me.BtnDeselectTaminkonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeselectTaminkonandeh.Size = New System.Drawing.Size(41, 29)
        Me.BtnDeselectTaminkonandeh.TabIndex = 30
        Me.BtnDeselectTaminkonandeh.Text = "هيچ "
        Me.BtnDeselectTaminkonandeh.UseVisualStyleBackColor = False
        '
        'PanelTaminNav
        '
        Me.PanelTaminNav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTaminNav.BackColor = System.Drawing.SystemColors.Control
        Me.PanelTaminNav.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelTaminNav.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTaminNav.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelTaminNav.Location = New System.Drawing.Point(8, 349)
        Me.PanelTaminNav.Name = "PanelTaminNav"
        Me.PanelTaminNav.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTaminNav.Size = New System.Drawing.Size(296, 29)
        Me.PanelTaminNav.TabIndex = 29
        '
        'PanelTamin
        '
        Me.PanelTamin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTamin.BackColor = System.Drawing.SystemColors.Control
        Me.PanelTamin.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelTamin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTamin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelTamin.Location = New System.Drawing.Point(4, 6)
        Me.PanelTamin.Name = "PanelTamin"
        Me.PanelTamin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTamin.Size = New System.Drawing.Size(654, 338)
        Me.PanelTamin.TabIndex = 28
        '
        'PanelTaminCom
        '
        Me.PanelTaminCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTaminCom.BackColor = System.Drawing.SystemColors.Control
        Me.PanelTaminCom.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelTaminCom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PanelTaminCom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelTaminCom.Location = New System.Drawing.Point(357, 350)
        Me.PanelTaminCom.Name = "PanelTaminCom"
        Me.PanelTaminCom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelTaminCom.Size = New System.Drawing.Size(301, 29)
        Me.PanelTaminCom.TabIndex = 27
        Me.PanelTaminCom.TabStop = True
        '
        'TabAnbar
        '
        Me.TabAnbar.Controls.Add(Me.btnRefresh_AnbarSN)
        Me.TabAnbar.Controls.Add(Me.Label22)
        Me.TabAnbar.Controls.Add(Me.CmbNoeAnbar)
        Me.TabAnbar.Controls.Add(Me.Frame1)
        Me.TabAnbar.Location = New System.Drawing.Point(4, 104)
        Me.TabAnbar.Name = "TabAnbar"
        Me.TabAnbar.Size = New System.Drawing.Size(663, 286)
        Me.TabAnbar.TabIndex = 28
        Me.TabAnbar.Text = "انبار"
        '
        'btnRefresh_AnbarSN
        '
        Me.btnRefresh_AnbarSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh_AnbarSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRefresh_AnbarSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefresh_AnbarSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_AnbarSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefresh_AnbarSN.Location = New System.Drawing.Point(344, 6)
        Me.btnRefresh_AnbarSN.Name = "btnRefresh_AnbarSN"
        Me.btnRefresh_AnbarSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRefresh_AnbarSN.Size = New System.Drawing.Size(49, 24)
        Me.btnRefresh_AnbarSN.TabIndex = 44
        Me.btnRefresh_AnbarSN.Text = "بازخواني"
        Me.btnRefresh_AnbarSN.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(612, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label22.Size = New System.Drawing.Size(45, 21)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "نوع انبار :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbNoeAnbar
        '
        Me.CmbNoeAnbar.BackColor = System.Drawing.Color.White
        CmbNoeAnbar_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeAnbar_DesignTimeLayout.LayoutString")
        Me.CmbNoeAnbar.DesignTimeLayout = CmbNoeAnbar_DesignTimeLayout
        Me.CmbNoeAnbar.LateBinding = True
        Me.CmbNoeAnbar.LateBindingTop = "100"
        Me.CmbNoeAnbar.Location = New System.Drawing.Point(422, 6)
        Me.CmbNoeAnbar.Name = "CmbNoeAnbar"
        Me.CmbNoeAnbar.SaveSettings = False
        Me.CmbNoeAnbar.Size = New System.Drawing.Size(187, 23)
        Me.CmbNoeAnbar.TabIndex = 42
        Me.CmbNoeAnbar.ValuesDataMember = Nothing
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.btnSelectAllAnbar)
        Me.Frame1.Controls.Add(Me.btnDeselectAllAnbar)
        Me.Frame1.Controls.Add(Me.PicN)
        Me.Frame1.Controls.Add(Me.PicG)
        Me.Frame1.Controls.Add(Me.PicC)
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 33)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(652, 190)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "ليست انبارها"
        '
        'btnSelectAllAnbar
        '
        Me.btnSelectAllAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAllAnbar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAllAnbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAllAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAllAnbar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAllAnbar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAllAnbar.Location = New System.Drawing.Point(343, 157)
        Me.btnSelectAllAnbar.Name = "btnSelectAllAnbar"
        Me.btnSelectAllAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAllAnbar.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAllAnbar.TabIndex = 6
        Me.btnSelectAllAnbar.Text = "همه"
        Me.btnSelectAllAnbar.UseVisualStyleBackColor = False
        '
        'btnDeselectAllAnbar
        '
        Me.btnDeselectAllAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAllAnbar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAllAnbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAllAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAllAnbar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAllAnbar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAllAnbar.Location = New System.Drawing.Point(299, 157)
        Me.btnDeselectAllAnbar.Name = "btnDeselectAllAnbar"
        Me.btnDeselectAllAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAllAnbar.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAllAnbar.TabIndex = 5
        Me.btnDeselectAllAnbar.Text = "هيچ "
        Me.btnDeselectAllAnbar.UseVisualStyleBackColor = False
        '
        'PicN
        '
        Me.PicN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicN.BackColor = System.Drawing.SystemColors.Control
        Me.PicN.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicN.Location = New System.Drawing.Point(4, 157)
        Me.PicN.Name = "PicN"
        Me.PicN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicN.Size = New System.Drawing.Size(268, 29)
        Me.PicN.TabIndex = 3
        '
        'PicG
        '
        Me.PicG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicG.BackColor = System.Drawing.SystemColors.Highlight
        Me.PicG.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicG.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicG.Location = New System.Drawing.Point(2, 19)
        Me.PicG.Name = "PicG"
        Me.PicG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicG.Size = New System.Drawing.Size(644, 133)
        Me.PicG.TabIndex = 2
        '
        'PicC
        '
        Me.PicC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicC.BackColor = System.Drawing.SystemColors.Control
        Me.PicC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PicC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicC.Location = New System.Drawing.Point(416, 158)
        Me.PicC.Name = "PicC"
        Me.PicC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicC.Size = New System.Drawing.Size(225, 29)
        Me.PicC.TabIndex = 1
        Me.PicC.TabStop = True
        '
        'tabpSanadDate
        '
        Me.tabpSanadDate.Controls.Add(Me.FraSanadDate)
        Me.tabpSanadDate.Location = New System.Drawing.Point(4, 29)
        Me.tabpSanadDate.Name = "tabpSanadDate"
        Me.tabpSanadDate.Size = New System.Drawing.Size(663, 361)
        Me.tabpSanadDate.TabIndex = 2
        Me.tabpSanadDate.Text = "تاريخ سند"
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromSanadDate)
        Me.FraSanadDate.Controls.Add(Me.txtToSanadDate)
        Me.FraSanadDate.Controls.Add(Me.Label5)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(285, 12)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(232, 37)
        Me.FraSanadDate.TabIndex = 4
        Me.FraSanadDate.TabStop = False
        '
        'txtFromSanadDate
        '
        Me.txtFromSanadDate.AcceptsReturn = True
        Me.txtFromSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSanadDate.Enabled = False
        Me.txtFromSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSanadDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSanadDate.MaxLength = 0
        Me.txtFromSanadDate.Name = "txtFromSanadDate"
        Me.txtFromSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSanadDate.TabIndex = 0
        Me.txtFromSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSanadDate
        '
        Me.txtToSanadDate.AcceptsReturn = True
        Me.txtToSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSanadDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSanadDate.MaxLength = 0
        Me.txtToSanadDate.Name = "txtToSanadDate"
        Me.txtToSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSanadDate.TabIndex = 1
        Me.txtToSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(175, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "از"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(82, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(188, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabChideman
        '
        Me.TabChideman.Controls.Add(Me.chkMahaleChideman)
        Me.TabChideman.Controls.Add(Me.btnChidemanKala)
        Me.TabChideman.Location = New System.Drawing.Point(4, 29)
        Me.TabChideman.Name = "TabChideman"
        Me.TabChideman.Size = New System.Drawing.Size(663, 361)
        Me.TabChideman.TabIndex = 25
        Me.TabChideman.Text = "فيلتر چيدمان کالا"
        '
        'chkMahaleChideman
        '
        Me.chkMahaleChideman.Location = New System.Drawing.Point(376, 40)
        Me.chkMahaleChideman.Name = "chkMahaleChideman"
        Me.chkMahaleChideman.Size = New System.Drawing.Size(176, 24)
        Me.chkMahaleChideman.TabIndex = 1
        Me.chkMahaleChideman.Text = "با ستون محل چيدمان"
        '
        'btnChidemanKala
        '
        Me.btnChidemanKala.Location = New System.Drawing.Point(576, 24)
        Me.btnChidemanKala.Name = "btnChidemanKala"
        Me.btnChidemanKala.Size = New System.Drawing.Size(75, 56)
        Me.btnChidemanKala.TabIndex = 0
        Me.btnChidemanKala.Text = "چيدمان کالا"
        '
        'TabpSabtDate
        '
        Me.TabpSabtDate.Controls.Add(Me.GroupBox3)
        Me.TabpSabtDate.Location = New System.Drawing.Point(4, 29)
        Me.TabpSabtDate.Name = "TabpSabtDate"
        Me.TabpSabtDate.Size = New System.Drawing.Size(663, 361)
        Me.TabpSabtDate.TabIndex = 26
        Me.TabpSabtDate.Text = "تاريخ ثبت سند"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.txtFromSabtDate)
        Me.GroupBox3.Controls.Add(Me.txtToSabtDate)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(264, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(232, 37)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'txtFromSabtDate
        '
        Me.txtFromSabtDate.AcceptsReturn = True
        Me.txtFromSabtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSabtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSabtDate.Enabled = False
        Me.txtFromSabtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSabtDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSabtDate.MaxLength = 0
        Me.txtFromSabtDate.Name = "txtFromSabtDate"
        Me.txtFromSabtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSabtDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSabtDate.TabIndex = 0
        Me.txtFromSabtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSabtDate
        '
        Me.txtToSabtDate.AcceptsReturn = True
        Me.txtToSabtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSabtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSabtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSabtDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSabtDate.MaxLength = 0
        Me.txtToSabtDate.Name = "txtToSabtDate"
        Me.txtToSabtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSabtDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSabtDate.TabIndex = 1
        Me.txtToSabtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label16.Location = New System.Drawing.Point(175, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "از"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label17.Location = New System.Drawing.Point(82, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "تا"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(188, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "تاريخ :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabpShomarehSefaresh
        '
        Me.tabpShomarehSefaresh.Controls.Add(Me.pnlShomarehSefaresh)
        Me.tabpShomarehSefaresh.Location = New System.Drawing.Point(4, 29)
        Me.tabpShomarehSefaresh.Name = "tabpShomarehSefaresh"
        Me.tabpShomarehSefaresh.Size = New System.Drawing.Size(663, 361)
        Me.tabpShomarehSefaresh.TabIndex = 1
        Me.tabpShomarehSefaresh.Text = "شماره ارجاع"
        '
        'pnlShomarehSefaresh
        '
        Me.pnlShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlShomarehSefaresh.Controls.Add(Me.txtToShomarehSefaresh)
        Me.pnlShomarehSefaresh.Controls.Add(Me.Label2)
        Me.pnlShomarehSefaresh.Controls.Add(Me.txtFromShomarehSefaresh)
        Me.pnlShomarehSefaresh.Controls.Add(Me.Label3)
        Me.pnlShomarehSefaresh.Controls.Add(Me.Label4)
        Me.pnlShomarehSefaresh.Location = New System.Drawing.Point(129, 12)
        Me.pnlShomarehSefaresh.Name = "pnlShomarehSefaresh"
        Me.pnlShomarehSefaresh.Size = New System.Drawing.Size(471, 30)
        Me.pnlShomarehSefaresh.TabIndex = 29
        '
        'txtToShomarehSefaresh
        '
        Me.txtToShomarehSefaresh.Location = New System.Drawing.Point(7, 5)
        Me.txtToShomarehSefaresh.MaxLength = 15
        Me.txtToShomarehSefaresh.Name = "txtToShomarehSefaresh"
        Me.txtToShomarehSefaresh.Size = New System.Drawing.Size(165, 23)
        Me.txtToShomarehSefaresh.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(172, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "تا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFromShomarehSefaresh
        '
        Me.txtFromShomarehSefaresh.Location = New System.Drawing.Point(209, 5)
        Me.txtFromShomarehSefaresh.MaxLength = 15
        Me.txtFromShomarehSefaresh.Name = "txtFromShomarehSefaresh"
        Me.txtFromShomarehSefaresh.Size = New System.Drawing.Size(165, 23)
        Me.txtFromShomarehSefaresh.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(374, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "از"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(399, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "شماره ارجاع"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabpKalaStatusAmvalSN
        '
        Me.TabpKalaStatusAmvalSN.Controls.Add(Me.grpboxKalaStatusAmvalSN)
        Me.TabpKalaStatusAmvalSN.Location = New System.Drawing.Point(4, 29)
        Me.TabpKalaStatusAmvalSN.Name = "TabpKalaStatusAmvalSN"
        Me.TabpKalaStatusAmvalSN.Size = New System.Drawing.Size(663, 361)
        Me.TabpKalaStatusAmvalSN.TabIndex = 24
        Me.TabpKalaStatusAmvalSN.Text = "وضعيت اموالي"
        '
        'grpboxKalaStatusAmvalSN
        '
        Me.grpboxKalaStatusAmvalSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxKalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.grpboxKalaStatusAmvalSN.Controls.Add(Me.btnSelectAll_KalaStatusAmvalSN)
        Me.grpboxKalaStatusAmvalSN.Controls.Add(Me.btnDeselectAll_KalaStatusAmvalSN)
        Me.grpboxKalaStatusAmvalSN.Controls.Add(Me.pnlNKalaStatusAmvalSN)
        Me.grpboxKalaStatusAmvalSN.Controls.Add(Me.pnlGridKalaStatusAmvalSN)
        Me.grpboxKalaStatusAmvalSN.Controls.Add(Me.pnlCmdKalaStatusAmvalSN)
        Me.grpboxKalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxKalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpboxKalaStatusAmvalSN.Location = New System.Drawing.Point(0, 3)
        Me.grpboxKalaStatusAmvalSN.Name = "grpboxKalaStatusAmvalSN"
        Me.grpboxKalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpboxKalaStatusAmvalSN.Size = New System.Drawing.Size(660, 655)
        Me.grpboxKalaStatusAmvalSN.TabIndex = 23
        Me.grpboxKalaStatusAmvalSN.TabStop = False
        '
        'btnSelectAll_KalaStatusAmvalSN
        '
        Me.btnSelectAll_KalaStatusAmvalSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_KalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_KalaStatusAmvalSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_KalaStatusAmvalSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_KalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_KalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_KalaStatusAmvalSN.Location = New System.Drawing.Point(332, 610)
        Me.btnSelectAll_KalaStatusAmvalSN.Name = "btnSelectAll_KalaStatusAmvalSN"
        Me.btnSelectAll_KalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_KalaStatusAmvalSN.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_KalaStatusAmvalSN.TabIndex = 26
        Me.btnSelectAll_KalaStatusAmvalSN.Text = "همه"
        Me.btnSelectAll_KalaStatusAmvalSN.UseVisualStyleBackColor = False
        '
        'btnDeselectAll_KalaStatusAmvalSN
        '
        Me.btnDeselectAll_KalaStatusAmvalSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll_KalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll_KalaStatusAmvalSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll_KalaStatusAmvalSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll_KalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll_KalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll_KalaStatusAmvalSN.Location = New System.Drawing.Point(288, 610)
        Me.btnDeselectAll_KalaStatusAmvalSN.Name = "btnDeselectAll_KalaStatusAmvalSN"
        Me.btnDeselectAll_KalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll_KalaStatusAmvalSN.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll_KalaStatusAmvalSN.TabIndex = 25
        Me.btnDeselectAll_KalaStatusAmvalSN.Text = "هيچ "
        Me.btnDeselectAll_KalaStatusAmvalSN.UseVisualStyleBackColor = False
        '
        'pnlNKalaStatusAmvalSN
        '
        Me.pnlNKalaStatusAmvalSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNKalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNKalaStatusAmvalSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNKalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNKalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNKalaStatusAmvalSN.Location = New System.Drawing.Point(5, 610)
        Me.pnlNKalaStatusAmvalSN.Name = "pnlNKalaStatusAmvalSN"
        Me.pnlNKalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNKalaStatusAmvalSN.Size = New System.Drawing.Size(276, 29)
        Me.pnlNKalaStatusAmvalSN.TabIndex = 24
        '
        'pnlGridKalaStatusAmvalSN
        '
        Me.pnlGridKalaStatusAmvalSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridKalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridKalaStatusAmvalSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridKalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridKalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridKalaStatusAmvalSN.Location = New System.Drawing.Point(3, 15)
        Me.pnlGridKalaStatusAmvalSN.Name = "pnlGridKalaStatusAmvalSN"
        Me.pnlGridKalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridKalaStatusAmvalSN.Size = New System.Drawing.Size(637, 588)
        Me.pnlGridKalaStatusAmvalSN.TabIndex = 23
        '
        'pnlCmdKalaStatusAmvalSN
        '
        Me.pnlCmdKalaStatusAmvalSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdKalaStatusAmvalSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdKalaStatusAmvalSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdKalaStatusAmvalSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdKalaStatusAmvalSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdKalaStatusAmvalSN.Location = New System.Drawing.Point(377, 611)
        Me.pnlCmdKalaStatusAmvalSN.Name = "pnlCmdKalaStatusAmvalSN"
        Me.pnlCmdKalaStatusAmvalSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdKalaStatusAmvalSN.Size = New System.Drawing.Size(263, 29)
        Me.pnlCmdKalaStatusAmvalSN.TabIndex = 22
        Me.pnlCmdKalaStatusAmvalSN.TabStop = True
        '
        'tabpKalaWhere
        '
        Me.tabpKalaWhere.Controls.Add(Me.GrpKalaWhere)
        Me.tabpKalaWhere.Location = New System.Drawing.Point(4, 54)
        Me.tabpKalaWhere.Name = "tabpKalaWhere"
        Me.tabpKalaWhere.Size = New System.Drawing.Size(663, 336)
        Me.tabpKalaWhere.TabIndex = 20
        Me.tabpKalaWhere.Text = "شروط کالا"
        '
        'GrpKalaWhere
        '
        Me.GrpKalaWhere.Controls.Add(Me.optGardeshDar)
        Me.GrpKalaWhere.Controls.Add(Me.optMandehDar)
        Me.GrpKalaWhere.Controls.Add(Me.optGardeshAll)
        Me.GrpKalaWhere.Location = New System.Drawing.Point(18, 12)
        Me.GrpKalaWhere.Name = "GrpKalaWhere"
        Me.GrpKalaWhere.Size = New System.Drawing.Size(642, 192)
        Me.GrpKalaWhere.TabIndex = 0
        Me.GrpKalaWhere.TabStop = False
        Me.GrpKalaWhere.Text = "شروط کالا"
        '
        'optGardeshDar
        '
        Me.optGardeshDar.Checked = True
        Me.optGardeshDar.Location = New System.Drawing.Point(363, 29)
        Me.optGardeshDar.Name = "optGardeshDar"
        Me.optGardeshDar.Size = New System.Drawing.Size(255, 30)
        Me.optGardeshDar.TabIndex = 0
        Me.optGardeshDar.TabStop = True
        Me.optGardeshDar.Text = "کليه کالافيزيکي هاي گردش دار"
        '
        'optMandehDar
        '
        Me.optMandehDar.Location = New System.Drawing.Point(363, 89)
        Me.optMandehDar.Name = "optMandehDar"
        Me.optMandehDar.Size = New System.Drawing.Size(255, 30)
        Me.optMandehDar.TabIndex = 0
        Me.optMandehDar.Text = "کليه کالا فيزيکي هاي مانده دار"
        '
        'optGardeshAll
        '
        Me.optGardeshAll.Location = New System.Drawing.Point(363, 149)
        Me.optGardeshAll.Name = "optGardeshAll"
        Me.optGardeshAll.Size = New System.Drawing.Size(255, 30)
        Me.optGardeshAll.TabIndex = 0
        Me.optGardeshAll.Text = "کليه کالا فيزيکي ها"
        '
        'TabPRezerv
        '
        Me.TabPRezerv.Controls.Add(Me.FraMohasebeRezerv)
        Me.TabPRezerv.Location = New System.Drawing.Point(4, 54)
        Me.TabPRezerv.Name = "TabPRezerv"
        Me.TabPRezerv.Size = New System.Drawing.Size(663, 336)
        Me.TabPRezerv.TabIndex = 13
        Me.TabPRezerv.Text = "محاسبه رزرو"
        '
        'FraMohasebeRezerv
        '
        Me.FraMohasebeRezerv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraMohasebeRezerv.BackColor = System.Drawing.SystemColors.Control
        Me.FraMohasebeRezerv.Controls.Add(Me.opnRezervNo)
        Me.FraMohasebeRezerv.Controls.Add(Me.opnRezervYes)
        Me.FraMohasebeRezerv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraMohasebeRezerv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraMohasebeRezerv.Location = New System.Drawing.Point(429, 9)
        Me.FraMohasebeRezerv.Name = "FraMohasebeRezerv"
        Me.FraMohasebeRezerv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraMohasebeRezerv.Size = New System.Drawing.Size(200, 37)
        Me.FraMohasebeRezerv.TabIndex = 7
        Me.FraMohasebeRezerv.TabStop = False
        Me.FraMohasebeRezerv.Text = "محاسبه رزرو"
        '
        'opnRezervNo
        '
        Me.opnRezervNo.BackColor = System.Drawing.SystemColors.Control
        Me.opnRezervNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opnRezervNo.Checked = True
        Me.opnRezervNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.opnRezervNo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.opnRezervNo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnRezervNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opnRezervNo.Location = New System.Drawing.Point(2, 14)
        Me.opnRezervNo.Name = "opnRezervNo"
        Me.opnRezervNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opnRezervNo.Size = New System.Drawing.Size(47, 19)
        Me.opnRezervNo.TabIndex = 1
        Me.opnRezervNo.TabStop = True
        Me.opnRezervNo.Text = "خير"
        Me.opnRezervNo.UseVisualStyleBackColor = False
        '
        'opnRezervYes
        '
        Me.opnRezervYes.BackColor = System.Drawing.SystemColors.Control
        Me.opnRezervYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opnRezervYes.Cursor = System.Windows.Forms.Cursors.Default
        Me.opnRezervYes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.opnRezervYes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnRezervYes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opnRezervYes.Location = New System.Drawing.Point(52, 14)
        Me.opnRezervYes.Name = "opnRezervYes"
        Me.opnRezervYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opnRezervYes.Size = New System.Drawing.Size(47, 19)
        Me.opnRezervYes.TabIndex = 0
        Me.opnRezervYes.Text = "بله"
        Me.opnRezervYes.UseVisualStyleBackColor = False
        '
        'TabPGoroohBandiTarakonesh
        '
        Me.TabPGoroohBandiTarakonesh.Controls.Add(Me.btnGorooheTarakonesh)
        Me.TabPGoroohBandiTarakonesh.Location = New System.Drawing.Point(4, 54)
        Me.TabPGoroohBandiTarakonesh.Name = "TabPGoroohBandiTarakonesh"
        Me.TabPGoroohBandiTarakonesh.Size = New System.Drawing.Size(663, 336)
        Me.TabPGoroohBandiTarakonesh.TabIndex = 15
        Me.TabPGoroohBandiTarakonesh.Text = "گروه بندي تراکنش انبار"
        '
        'btnGorooheTarakonesh
        '
        Me.btnGorooheTarakonesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGorooheTarakonesh.Location = New System.Drawing.Point(576, 12)
        Me.btnGorooheTarakonesh.Name = "btnGorooheTarakonesh"
        Me.btnGorooheTarakonesh.Size = New System.Drawing.Size(81, 54)
        Me.btnGorooheTarakonesh.TabIndex = 45
        Me.btnGorooheTarakonesh.Text = "فيلتر تراکنش"
        '
        'tpShomarehRahgiri
        '
        Me.tpShomarehRahgiri.Controls.Add(Me.pnlKalaPhiziki)
        Me.tpShomarehRahgiri.Location = New System.Drawing.Point(4, 54)
        Me.tpShomarehRahgiri.Name = "tpShomarehRahgiri"
        Me.tpShomarehRahgiri.Size = New System.Drawing.Size(663, 336)
        Me.tpShomarehRahgiri.TabIndex = 18
        Me.tpShomarehRahgiri.Text = "شماره رهگيري"
        '
        'pnlKalaPhiziki
        '
        Me.pnlKalaPhiziki.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlKalaPhiziki.Controls.Add(Me.txtToShomarehRahgiri)
        Me.pnlKalaPhiziki.Controls.Add(Me.Label7)
        Me.pnlKalaPhiziki.Controls.Add(Me.txtFromShomarehRahgiri)
        Me.pnlKalaPhiziki.Controls.Add(Me.Label8)
        Me.pnlKalaPhiziki.Controls.Add(Me.Label11)
        Me.pnlKalaPhiziki.Location = New System.Drawing.Point(89, 36)
        Me.pnlKalaPhiziki.Name = "pnlKalaPhiziki"
        Me.pnlKalaPhiziki.Size = New System.Drawing.Size(544, 30)
        Me.pnlKalaPhiziki.TabIndex = 30
        '
        'txtToShomarehRahgiri
        '
        Me.txtToShomarehRahgiri.Location = New System.Drawing.Point(7, 5)
        Me.txtToShomarehRahgiri.MaxLength = 15
        Me.txtToShomarehRahgiri.Name = "txtToShomarehRahgiri"
        Me.txtToShomarehRahgiri.Size = New System.Drawing.Size(165, 23)
        Me.txtToShomarehRahgiri.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(172, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "تا"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFromShomarehRahgiri
        '
        Me.txtFromShomarehRahgiri.Location = New System.Drawing.Point(209, 5)
        Me.txtFromShomarehRahgiri.MaxLength = 15
        Me.txtFromShomarehRahgiri.Name = "txtFromShomarehRahgiri"
        Me.txtFromShomarehRahgiri.Size = New System.Drawing.Size(165, 23)
        Me.txtFromShomarehRahgiri.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(374, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(15, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "از"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(402, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "شماره رهگيري"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabpSanadStatus
        '
        Me.tabpSanadStatus.Controls.Add(Me.FraSanadStaus)
        Me.tabpSanadStatus.Location = New System.Drawing.Point(4, 54)
        Me.tabpSanadStatus.Name = "tabpSanadStatus"
        Me.tabpSanadStatus.Size = New System.Drawing.Size(663, 336)
        Me.tabpSanadStatus.TabIndex = 11
        Me.tabpSanadStatus.Text = "وضعيت سند"
        '
        'FraSanadStaus
        '
        Me.FraSanadStaus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadStaus.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_1)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_4)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_8)
        Me.FraSanadStaus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadStaus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadStaus.Location = New System.Drawing.Point(387, 9)
        Me.FraSanadStaus.Name = "FraSanadStaus"
        Me.FraSanadStaus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadStaus.Size = New System.Drawing.Size(276, 39)
        Me.FraSanadStaus.TabIndex = 5
        Me.FraSanadStaus.TabStop = False
        Me.FraSanadStaus.Text = "وضعيت"
        '
        'chkSanadStatus_1
        '
        Me.chkSanadStatus_1.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_1.Location = New System.Drawing.Point(119, 13)
        Me.chkSanadStatus_1.Name = "chkSanadStatus_1"
        Me.chkSanadStatus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_1.Size = New System.Drawing.Size(81, 21)
        Me.chkSanadStatus_1.TabIndex = 0
        Me.chkSanadStatus_1.Text = "پيشنويس"
        Me.chkSanadStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_4
        '
        Me.chkSanadStatus_4.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_4.Location = New System.Drawing.Point(58, 13)
        Me.chkSanadStatus_4.Name = "chkSanadStatus_4"
        Me.chkSanadStatus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_4.Size = New System.Drawing.Size(59, 21)
        Me.chkSanadStatus_4.TabIndex = 1
        Me.chkSanadStatus_4.Text = "موقت"
        Me.chkSanadStatus_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_8
        '
        Me.chkSanadStatus_8.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.Checked = True
        Me.chkSanadStatus_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSanadStatus_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_8.Location = New System.Drawing.Point(1, 13)
        Me.chkSanadStatus_8.Name = "chkSanadStatus_8"
        Me.chkSanadStatus_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_8.Size = New System.Drawing.Size(55, 21)
        Me.chkSanadStatus_8.TabIndex = 2
        Me.chkSanadStatus_8.Text = "قطعي"
        Me.chkSanadStatus_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.UseVisualStyleBackColor = False
        '
        'TabPGoroohBandiKalaSN
        '
        Me.TabPGoroohBandiKalaSN.Controls.Add(Me.btnGorooheKala)
        Me.TabPGoroohBandiKalaSN.Location = New System.Drawing.Point(4, 54)
        Me.TabPGoroohBandiKalaSN.Name = "TabPGoroohBandiKalaSN"
        Me.TabPGoroohBandiKalaSN.Size = New System.Drawing.Size(663, 336)
        Me.TabPGoroohBandiKalaSN.TabIndex = 17
        Me.TabPGoroohBandiKalaSN.Text = "گروه بندي کالا"
        '
        'btnGorooheKala
        '
        Me.btnGorooheKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGorooheKala.Location = New System.Drawing.Point(588, 18)
        Me.btnGorooheKala.Name = "btnGorooheKala"
        Me.btnGorooheKala.Size = New System.Drawing.Size(69, 51)
        Me.btnGorooheKala.TabIndex = 48
        Me.btnGorooheKala.Text = "فيلتر کالا"
        '
        'tabpDarjKalaPhizikiFor
        '
        Me.tabpDarjKalaPhizikiFor.Controls.Add(Me.dbcCopyTShomareshSN)
        Me.tabpDarjKalaPhizikiFor.Controls.Add(Me.Label13)
        Me.tabpDarjKalaPhizikiFor.Controls.Add(Me.dbcCopyFShomareshSN)
        Me.tabpDarjKalaPhizikiFor.Controls.Add(Me.GroupBox2)
        Me.tabpDarjKalaPhizikiFor.Controls.Add(Me.chkCopyShomaresh)
        Me.tabpDarjKalaPhizikiFor.Location = New System.Drawing.Point(4, 79)
        Me.tabpDarjKalaPhizikiFor.Name = "tabpDarjKalaPhizikiFor"
        Me.tabpDarjKalaPhizikiFor.Size = New System.Drawing.Size(663, 311)
        Me.tabpDarjKalaPhizikiFor.TabIndex = 21
        Me.tabpDarjKalaPhizikiFor.Text = "درج شماره رهگيري بر اساس"
        '
        'dbcCopyTShomareshSN
        '
        Me.dbcCopyTShomareshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcCopyTShomareshSN.AutoSelectFirst = False
        Me.dbcCopyTShomareshSN.BackColor = System.Drawing.Color.White
        Me.dbcCopyTShomareshSN.BoundText = Nothing
        Me.dbcCopyTShomareshSN.BypassChangeEvent = False
        Me.dbcCopyTShomareshSN.DisplayText = ""
        Me.dbcCopyTShomareshSN.LateBindingTop = "100"
        Me.dbcCopyTShomareshSN.Location = New System.Drawing.Point(129, 165)
        Me.dbcCopyTShomareshSN.MemFilter = ""
        Me.dbcCopyTShomareshSN.Name = "dbcCopyTShomareshSN"
        Me.dbcCopyTShomareshSN.SeparatedData = Nothing
        Me.dbcCopyTShomareshSN.Size = New System.Drawing.Size(126, 24)
        Me.dbcCopyTShomareshSN.Source = Nothing
        Me.dbcCopyTShomareshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcCopyTShomareshSN.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(260, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 24)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = " به  شمارش"
        '
        'dbcCopyFShomareshSN
        '
        Me.dbcCopyFShomareshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcCopyFShomareshSN.AutoSelectFirst = False
        Me.dbcCopyFShomareshSN.BackColor = System.Drawing.Color.White
        Me.dbcCopyFShomareshSN.BoundText = Nothing
        Me.dbcCopyFShomareshSN.BypassChangeEvent = False
        Me.dbcCopyFShomareshSN.DisplayText = ""
        Me.dbcCopyFShomareshSN.LateBindingTop = "100"
        Me.dbcCopyFShomareshSN.Location = New System.Drawing.Point(339, 165)
        Me.dbcCopyFShomareshSN.MemFilter = ""
        Me.dbcCopyFShomareshSN.Name = "dbcCopyFShomareshSN"
        Me.dbcCopyFShomareshSN.SeparatedData = Nothing
        Me.dbcCopyFShomareshSN.Size = New System.Drawing.Size(126, 24)
        Me.dbcCopyFShomareshSN.Source = Nothing
        Me.dbcCopyFShomareshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcCopyFShomareshSN.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDarjKalaPhiziki)
        Me.GroupBox2.Controls.Add(Me.dcbTabShomareshLast)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dcbFabShomareshLast)
        Me.GroupBox2.Controls.Add(Me.dcbabShomareshMoghayer)
        Me.GroupBox2.Controls.Add(Me.optAllKalaPhiziki)
        Me.GroupBox2.Controls.Add(Me.optAllKalaPhizikiMojoodiMoghayer)
        Me.GroupBox2.Controls.Add(Me.optAllKalaPhizikiLastMoghayer)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 153)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'chkDarjKalaPhiziki
        '
        Me.chkDarjKalaPhiziki.Checked = True
        Me.chkDarjKalaPhiziki.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDarjKalaPhiziki.Location = New System.Drawing.Point(420, 15)
        Me.chkDarjKalaPhiziki.Name = "chkDarjKalaPhiziki"
        Me.chkDarjKalaPhiziki.Size = New System.Drawing.Size(243, 24)
        Me.chkDarjKalaPhiziki.TabIndex = 29
        Me.chkDarjKalaPhiziki.Text = "درج شماره رهگيري بر اساس"
        '
        'dcbTabShomareshLast
        '
        Me.dcbTabShomareshLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbTabShomareshLast.AutoSelectFirst = False
        Me.dcbTabShomareshLast.BackColor = System.Drawing.Color.White
        Me.dcbTabShomareshLast.BoundText = Nothing
        Me.dcbTabShomareshLast.BypassChangeEvent = False
        Me.dcbTabShomareshLast.DisplayText = ""
        Me.dcbTabShomareshLast.LateBindingTop = "100"
        Me.dcbTabShomareshLast.Location = New System.Drawing.Point(24, 122)
        Me.dcbTabShomareshLast.MemFilter = ""
        Me.dcbTabShomareshLast.Name = "dcbTabShomareshLast"
        Me.dcbTabShomareshLast.SeparatedData = Nothing
        Me.dcbTabShomareshLast.Size = New System.Drawing.Size(126, 24)
        Me.dcbTabShomareshLast.Source = Nothing
        Me.dcbTabShomareshLast.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbTabShomareshLast.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(150, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 24)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "و شمارش"
        '
        'dcbFabShomareshLast
        '
        Me.dcbFabShomareshLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbFabShomareshLast.AutoSelectFirst = False
        Me.dcbFabShomareshLast.BackColor = System.Drawing.Color.White
        Me.dcbFabShomareshLast.BoundText = Nothing
        Me.dcbFabShomareshLast.BypassChangeEvent = False
        Me.dcbFabShomareshLast.DisplayText = ""
        Me.dcbFabShomareshLast.LateBindingTop = "100"
        Me.dcbFabShomareshLast.Location = New System.Drawing.Point(228, 122)
        Me.dcbFabShomareshLast.MemFilter = ""
        Me.dcbFabShomareshLast.Name = "dcbFabShomareshLast"
        Me.dcbFabShomareshLast.SeparatedData = Nothing
        Me.dcbFabShomareshLast.Size = New System.Drawing.Size(126, 24)
        Me.dcbFabShomareshLast.Source = Nothing
        Me.dcbFabShomareshLast.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbFabShomareshLast.TabIndex = 26
        '
        'dcbabShomareshMoghayer
        '
        Me.dcbabShomareshMoghayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbabShomareshMoghayer.AutoSelectFirst = False
        Me.dcbabShomareshMoghayer.BackColor = System.Drawing.Color.White
        Me.dcbabShomareshMoghayer.BoundText = Nothing
        Me.dcbabShomareshMoghayer.BypassChangeEvent = False
        Me.dcbabShomareshMoghayer.DisplayText = ""
        Me.dcbabShomareshMoghayer.LateBindingTop = "100"
        Me.dcbabShomareshMoghayer.Location = New System.Drawing.Point(180, 85)
        Me.dcbabShomareshMoghayer.MemFilter = ""
        Me.dcbabShomareshMoghayer.Name = "dcbabShomareshMoghayer"
        Me.dcbabShomareshMoghayer.SeparatedData = Nothing
        Me.dcbabShomareshMoghayer.Size = New System.Drawing.Size(126, 24)
        Me.dcbabShomareshMoghayer.Source = Nothing
        Me.dcbabShomareshMoghayer.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbabShomareshMoghayer.TabIndex = 25
        '
        'optAllKalaPhiziki
        '
        Me.optAllKalaPhiziki.Checked = True
        Me.optAllKalaPhiziki.Location = New System.Drawing.Point(348, 48)
        Me.optAllKalaPhiziki.Name = "optAllKalaPhiziki"
        Me.optAllKalaPhiziki.Size = New System.Drawing.Size(291, 24)
        Me.optAllKalaPhiziki.TabIndex = 0
        Me.optAllKalaPhiziki.TabStop = True
        Me.optAllKalaPhiziki.Text = "کل شماره رهگيري هاي انبارگرداني"
        '
        'optAllKalaPhizikiMojoodiMoghayer
        '
        Me.optAllKalaPhizikiMojoodiMoghayer.Location = New System.Drawing.Point(318, 85)
        Me.optAllKalaPhizikiMojoodiMoghayer.Name = "optAllKalaPhizikiMojoodiMoghayer"
        Me.optAllKalaPhizikiMojoodiMoghayer.Size = New System.Drawing.Size(321, 24)
        Me.optAllKalaPhizikiMojoodiMoghayer.TabIndex = 0
        Me.optAllKalaPhizikiMojoodiMoghayer.Text = "کل شماره رهگيري هاييکه موجودي مغاير با شمارش :"
        '
        'optAllKalaPhizikiLastMoghayer
        '
        Me.optAllKalaPhizikiLastMoghayer.Location = New System.Drawing.Point(369, 122)
        Me.optAllKalaPhizikiLastMoghayer.Name = "optAllKalaPhizikiLastMoghayer"
        Me.optAllKalaPhizikiLastMoghayer.Size = New System.Drawing.Size(270, 24)
        Me.optAllKalaPhizikiLastMoghayer.TabIndex = 0
        Me.optAllKalaPhizikiLastMoghayer.Text = "کل شماره رهگيري هاي مغاير بين شمارش :"
        '
        'chkCopyShomaresh
        '
        Me.chkCopyShomaresh.Location = New System.Drawing.Point(474, 165)
        Me.chkCopyShomaresh.Name = "chkCopyShomaresh"
        Me.chkCopyShomaresh.Size = New System.Drawing.Size(189, 24)
        Me.chkCopyShomaresh.TabIndex = 1
        Me.chkCopyShomaresh.Text = "کپي مقادير از شمارش :"
        '
        'TabPNoeTarakoneshKalaSN
        '
        Me.TabPNoeTarakoneshKalaSN.Controls.Add(Me.FraQC)
        Me.TabPNoeTarakoneshKalaSN.Location = New System.Drawing.Point(4, 79)
        Me.TabPNoeTarakoneshKalaSN.Name = "TabPNoeTarakoneshKalaSN"
        Me.TabPNoeTarakoneshKalaSN.Size = New System.Drawing.Size(663, 311)
        Me.TabPNoeTarakoneshKalaSN.TabIndex = 12
        Me.TabPNoeTarakoneshKalaSN.Text = "کنترل کيفيت"
        '
        'FraQC
        '
        Me.FraQC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraQC.BackColor = System.Drawing.SystemColors.Control
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO6)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO5)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO0)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO1)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO2)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO3)
        Me.FraQC.Controls.Add(Me.chkNoeTarakoneshKalaNO4)
        Me.FraQC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraQC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraQC.Location = New System.Drawing.Point(56, 9)
        Me.FraQC.Name = "FraQC"
        Me.FraQC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraQC.Size = New System.Drawing.Size(487, 72)
        Me.FraQC.TabIndex = 6
        Me.FraQC.TabStop = False
        Me.FraQC.Text = "كنترل كيفيت"
        '
        'chkNoeTarakoneshKalaNO6
        '
        Me.chkNoeTarakoneshKalaNO6.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO6.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO6.Location = New System.Drawing.Point(54, 22)
        Me.chkNoeTarakoneshKalaNO6.Name = "chkNoeTarakoneshKalaNO6"
        Me.chkNoeTarakoneshKalaNO6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO6.Size = New System.Drawing.Size(120, 21)
        Me.chkNoeTarakoneshKalaNO6.TabIndex = 6
        Me.chkNoeTarakoneshKalaNO6.Text = "تحت آزمایش"
        Me.chkNoeTarakoneshKalaNO6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO6.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO5
        '
        Me.chkNoeTarakoneshKalaNO5.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO5.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO5.Location = New System.Drawing.Point(169, 45)
        Me.chkNoeTarakoneshKalaNO5.Name = "chkNoeTarakoneshKalaNO5"
        Me.chkNoeTarakoneshKalaNO5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO5.Size = New System.Drawing.Size(120, 21)
        Me.chkNoeTarakoneshKalaNO5.TabIndex = 5
        Me.chkNoeTarakoneshKalaNO5.Text = "مصرف اضطراري"
        Me.chkNoeTarakoneshKalaNO5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO5.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO0
        '
        Me.chkNoeTarakoneshKalaNO0.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO0.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO0.Location = New System.Drawing.Point(169, 21)
        Me.chkNoeTarakoneshKalaNO0.Name = "chkNoeTarakoneshKalaNO0"
        Me.chkNoeTarakoneshKalaNO0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO0.Size = New System.Drawing.Size(120, 21)
        Me.chkNoeTarakoneshKalaNO0.TabIndex = 4
        Me.chkNoeTarakoneshKalaNO0.Text = "بررسي نشده"
        Me.chkNoeTarakoneshKalaNO0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO0.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO1
        '
        Me.chkNoeTarakoneshKalaNO1.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO1.Location = New System.Drawing.Point(398, 19)
        Me.chkNoeTarakoneshKalaNO1.Name = "chkNoeTarakoneshKalaNO1"
        Me.chkNoeTarakoneshKalaNO1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO1.Size = New System.Drawing.Size(75, 21)
        Me.chkNoeTarakoneshKalaNO1.TabIndex = 0
        Me.chkNoeTarakoneshKalaNO1.Text = "قرنطينه"
        Me.chkNoeTarakoneshKalaNO1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO1.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO2
        '
        Me.chkNoeTarakoneshKalaNO2.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO2.Checked = True
        Me.chkNoeTarakoneshKalaNO2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoeTarakoneshKalaNO2.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO2.Location = New System.Drawing.Point(412, 43)
        Me.chkNoeTarakoneshKalaNO2.Name = "chkNoeTarakoneshKalaNO2"
        Me.chkNoeTarakoneshKalaNO2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO2.Size = New System.Drawing.Size(61, 21)
        Me.chkNoeTarakoneshKalaNO2.TabIndex = 2
        Me.chkNoeTarakoneshKalaNO2.Text = "تاييد"
        Me.chkNoeTarakoneshKalaNO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO2.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO3
        '
        Me.chkNoeTarakoneshKalaNO3.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO3.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO3.Location = New System.Drawing.Point(346, 19)
        Me.chkNoeTarakoneshKalaNO3.Name = "chkNoeTarakoneshKalaNO3"
        Me.chkNoeTarakoneshKalaNO3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO3.Size = New System.Drawing.Size(50, 21)
        Me.chkNoeTarakoneshKalaNO3.TabIndex = 1
        Me.chkNoeTarakoneshKalaNO3.Text = "رد"
        Me.chkNoeTarakoneshKalaNO3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO3.UseVisualStyleBackColor = False
        '
        'chkNoeTarakoneshKalaNO4
        '
        Me.chkNoeTarakoneshKalaNO4.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoeTarakoneshKalaNO4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO4.Checked = True
        Me.chkNoeTarakoneshKalaNO4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoeTarakoneshKalaNO4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoeTarakoneshKalaNO4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkNoeTarakoneshKalaNO4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkNoeTarakoneshKalaNO4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoeTarakoneshKalaNO4.Location = New System.Drawing.Point(296, 43)
        Me.chkNoeTarakoneshKalaNO4.Name = "chkNoeTarakoneshKalaNO4"
        Me.chkNoeTarakoneshKalaNO4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoeTarakoneshKalaNO4.Size = New System.Drawing.Size(100, 21)
        Me.chkNoeTarakoneshKalaNO4.TabIndex = 3
        Me.chkNoeTarakoneshKalaNO4.Text = "مصرف مشروط"
        Me.chkNoeTarakoneshKalaNO4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoeTarakoneshKalaNO4.UseVisualStyleBackColor = False
        '
        'tabpSanadNO
        '
        Me.tabpSanadNO.Controls.Add(Me.pnlSanadNO)
        Me.tabpSanadNO.Location = New System.Drawing.Point(4, 79)
        Me.tabpSanadNO.Name = "tabpSanadNO"
        Me.tabpSanadNO.Size = New System.Drawing.Size(663, 311)
        Me.tabpSanadNO.TabIndex = 0
        Me.tabpSanadNO.Text = "شماره سند"
        '
        'pnlSanadNO
        '
        Me.pnlSanadNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSanadNO.Controls.Add(Me.txtToSanadNO)
        Me.pnlSanadNO.Controls.Add(Me.Label1)
        Me.pnlSanadNO.Controls.Add(Me.txtFromSanadNO)
        Me.pnlSanadNO.Controls.Add(Me.Label9)
        Me.pnlSanadNO.Controls.Add(Me.lbl1)
        Me.pnlSanadNO.Location = New System.Drawing.Point(126, 15)
        Me.pnlSanadNO.Name = "pnlSanadNO"
        Me.pnlSanadNO.Size = New System.Drawing.Size(436, 30)
        Me.pnlSanadNO.TabIndex = 29
        '
        'txtToSanadNO
        '
        Me.txtToSanadNO.Location = New System.Drawing.Point(7, 5)
        Me.txtToSanadNO.MaxLength = 15
        Me.txtToSanadNO.Name = "txtToSanadNO"
        Me.txtToSanadNO.Size = New System.Drawing.Size(165, 23)
        Me.txtToSanadNO.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(172, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "تا"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFromSanadNO
        '
        Me.txtFromSanadNO.Location = New System.Drawing.Point(209, 5)
        Me.txtFromSanadNO.MaxLength = 15
        Me.txtFromSanadNO.Name = "txtFromSanadNO"
        Me.txtFromSanadNO.Size = New System.Drawing.Size(165, 23)
        Me.txtFromSanadNO.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(374, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "از"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(399, 7)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(26, 13)
        Me.lbl1.TabIndex = 27
        Me.lbl1.Text = "سند"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPNoeMarjooeiSN
        '
        Me.TabPNoeMarjooeiSN.Controls.Add(Me.grpboxNoeMarjooeiSN)
        Me.TabPNoeMarjooeiSN.Location = New System.Drawing.Point(4, 79)
        Me.TabPNoeMarjooeiSN.Name = "TabPNoeMarjooeiSN"
        Me.TabPNoeMarjooeiSN.Size = New System.Drawing.Size(663, 311)
        Me.TabPNoeMarjooeiSN.TabIndex = 23
        Me.TabPNoeMarjooeiSN.Text = "نوع مرجوعي"
        '
        'grpboxNoeMarjooeiSN
        '
        Me.grpboxNoeMarjooeiSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxNoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.grpboxNoeMarjooeiSN.Controls.Add(Me.btnSelectAll_NoeMarjooeiSN)
        Me.grpboxNoeMarjooeiSN.Controls.Add(Me.btnDeselectAll_NoeMarjooeiSN)
        Me.grpboxNoeMarjooeiSN.Controls.Add(Me.pnlNNoeMarjooeiSN)
        Me.grpboxNoeMarjooeiSN.Controls.Add(Me.pnlGridNoeMarjooeiSN)
        Me.grpboxNoeMarjooeiSN.Controls.Add(Me.pnlCmdNoeMarjooeiSN)
        Me.grpboxNoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxNoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpboxNoeMarjooeiSN.Location = New System.Drawing.Point(0, 3)
        Me.grpboxNoeMarjooeiSN.Name = "grpboxNoeMarjooeiSN"
        Me.grpboxNoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpboxNoeMarjooeiSN.Size = New System.Drawing.Size(660, 271)
        Me.grpboxNoeMarjooeiSN.TabIndex = 22
        Me.grpboxNoeMarjooeiSN.TabStop = False
        '
        'btnSelectAll_NoeMarjooeiSN
        '
        Me.btnSelectAll_NoeMarjooeiSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_NoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_NoeMarjooeiSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_NoeMarjooeiSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_NoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_NoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_NoeMarjooeiSN.Location = New System.Drawing.Point(332, 226)
        Me.btnSelectAll_NoeMarjooeiSN.Name = "btnSelectAll_NoeMarjooeiSN"
        Me.btnSelectAll_NoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_NoeMarjooeiSN.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_NoeMarjooeiSN.TabIndex = 26
        Me.btnSelectAll_NoeMarjooeiSN.Text = "همه"
        Me.btnSelectAll_NoeMarjooeiSN.UseVisualStyleBackColor = False
        '
        'btnDeselectAll_NoeMarjooeiSN
        '
        Me.btnDeselectAll_NoeMarjooeiSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll_NoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll_NoeMarjooeiSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll_NoeMarjooeiSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll_NoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll_NoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll_NoeMarjooeiSN.Location = New System.Drawing.Point(288, 226)
        Me.btnDeselectAll_NoeMarjooeiSN.Name = "btnDeselectAll_NoeMarjooeiSN"
        Me.btnDeselectAll_NoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll_NoeMarjooeiSN.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll_NoeMarjooeiSN.TabIndex = 25
        Me.btnDeselectAll_NoeMarjooeiSN.Text = "هيچ "
        Me.btnDeselectAll_NoeMarjooeiSN.UseVisualStyleBackColor = False
        '
        'pnlNNoeMarjooeiSN
        '
        Me.pnlNNoeMarjooeiSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNNoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNNoeMarjooeiSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNNoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNNoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNNoeMarjooeiSN.Location = New System.Drawing.Point(5, 226)
        Me.pnlNNoeMarjooeiSN.Name = "pnlNNoeMarjooeiSN"
        Me.pnlNNoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNNoeMarjooeiSN.Size = New System.Drawing.Size(276, 29)
        Me.pnlNNoeMarjooeiSN.TabIndex = 24
        '
        'pnlGridNoeMarjooeiSN
        '
        Me.pnlGridNoeMarjooeiSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridNoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridNoeMarjooeiSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridNoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridNoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridNoeMarjooeiSN.Location = New System.Drawing.Point(3, 15)
        Me.pnlGridNoeMarjooeiSN.Name = "pnlGridNoeMarjooeiSN"
        Me.pnlGridNoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridNoeMarjooeiSN.Size = New System.Drawing.Size(654, 204)
        Me.pnlGridNoeMarjooeiSN.TabIndex = 23
        '
        'pnlCmdNoeMarjooeiSN
        '
        Me.pnlCmdNoeMarjooeiSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdNoeMarjooeiSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdNoeMarjooeiSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdNoeMarjooeiSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdNoeMarjooeiSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdNoeMarjooeiSN.Location = New System.Drawing.Point(377, 227)
        Me.pnlCmdNoeMarjooeiSN.Name = "pnlCmdNoeMarjooeiSN"
        Me.pnlCmdNoeMarjooeiSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdNoeMarjooeiSN.Size = New System.Drawing.Size(273, 29)
        Me.pnlCmdNoeMarjooeiSN.TabIndex = 22
        Me.pnlCmdNoeMarjooeiSN.TabStop = True
        '
        'TabPTafsiliSN
        '
        Me.TabPTafsiliSN.Controls.Add(Me.grpboxTafsiliSN)
        Me.TabPTafsiliSN.Location = New System.Drawing.Point(4, 79)
        Me.TabPTafsiliSN.Name = "TabPTafsiliSN"
        Me.TabPTafsiliSN.Size = New System.Drawing.Size(663, 311)
        Me.TabPTafsiliSN.TabIndex = 16
        Me.TabPTafsiliSN.Text = "طرف حساب"
        '
        'grpboxTafsiliSN
        '
        Me.grpboxTafsiliSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxTafsiliSN.BackColor = System.Drawing.SystemColors.Control
        Me.grpboxTafsiliSN.Controls.Add(Me.btnSelectAll)
        Me.grpboxTafsiliSN.Controls.Add(Me.btnDeselectAll)
        Me.grpboxTafsiliSN.Controls.Add(Me.pnlNTafsiliSN)
        Me.grpboxTafsiliSN.Controls.Add(Me.pnlGridTafsiliSN)
        Me.grpboxTafsiliSN.Controls.Add(Me.pnlCmdTafsiliSN)
        Me.grpboxTafsiliSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxTafsiliSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpboxTafsiliSN.Location = New System.Drawing.Point(1, 0)
        Me.grpboxTafsiliSN.Name = "grpboxTafsiliSN"
        Me.grpboxTafsiliSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpboxTafsiliSN.Size = New System.Drawing.Size(659, 271)
        Me.grpboxTafsiliSN.TabIndex = 1
        Me.grpboxTafsiliSN.TabStop = False
        Me.grpboxTafsiliSN.Text = "طرف حساب هاي داراي گردش در انبار"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Location = New System.Drawing.Point(330, 238)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Location = New System.Drawing.Point(286, 238)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        Me.btnDeselectAll.UseVisualStyleBackColor = False
        '
        'pnlNTafsiliSN
        '
        Me.pnlNTafsiliSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNTafsiliSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNTafsiliSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNTafsiliSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNTafsiliSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNTafsiliSN.Location = New System.Drawing.Point(4, 238)
        Me.pnlNTafsiliSN.Name = "pnlNTafsiliSN"
        Me.pnlNTafsiliSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNTafsiliSN.Size = New System.Drawing.Size(275, 29)
        Me.pnlNTafsiliSN.TabIndex = 3
        '
        'pnlGridTafsiliSN
        '
        Me.pnlGridTafsiliSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridTafsiliSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridTafsiliSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridTafsiliSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridTafsiliSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridTafsiliSN.Location = New System.Drawing.Point(2, 18)
        Me.pnlGridTafsiliSN.Name = "pnlGridTafsiliSN"
        Me.pnlGridTafsiliSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridTafsiliSN.Size = New System.Drawing.Size(653, 215)
        Me.pnlGridTafsiliSN.TabIndex = 2
        '
        'pnlCmdTafsiliSN
        '
        Me.pnlCmdTafsiliSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdTafsiliSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdTafsiliSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdTafsiliSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdTafsiliSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdTafsiliSN.Location = New System.Drawing.Point(375, 239)
        Me.pnlCmdTafsiliSN.Name = "pnlCmdTafsiliSN"
        Me.pnlCmdTafsiliSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdTafsiliSN.Size = New System.Drawing.Size(273, 29)
        Me.pnlCmdTafsiliSN.TabIndex = 1
        Me.pnlCmdTafsiliSN.TabStop = True
        '
        'TabpTarakoneshSN
        '
        Me.TabpTarakoneshSN.Controls.Add(Me.GroupBox1)
        Me.TabpTarakoneshSN.Location = New System.Drawing.Point(4, 79)
        Me.TabpTarakoneshSN.Name = "TabpTarakoneshSN"
        Me.TabpTarakoneshSN.Size = New System.Drawing.Size(663, 311)
        Me.TabpTarakoneshSN.TabIndex = 19
        Me.TabpTarakoneshSN.Text = "تراکنش انبار"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnSelectAll_TarakoneshSN)
        Me.GroupBox1.Controls.Add(Me.BtnDeselectAll_TarakoneshSN)
        Me.GroupBox1.Controls.Add(Me.pnlNTarakoneshSN)
        Me.GroupBox1.Controls.Add(Me.pnlGridTarakoneshSN)
        Me.GroupBox1.Controls.Add(Me.pnlCmdTarakoneshSN)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(660, 266)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تراکنش  انبار"
        '
        'btnSelectAll_TarakoneshSN
        '
        Me.btnSelectAll_TarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_TarakoneshSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_TarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_TarakoneshSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_TarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_TarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_TarakoneshSN.Image = CType(resources.GetObject("btnSelectAll_TarakoneshSN.Image"), System.Drawing.Image)
        Me.btnSelectAll_TarakoneshSN.Location = New System.Drawing.Point(331, 233)
        Me.btnSelectAll_TarakoneshSN.Name = "btnSelectAll_TarakoneshSN"
        Me.btnSelectAll_TarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_TarakoneshSN.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_TarakoneshSN.TabIndex = 6
        Me.btnSelectAll_TarakoneshSN.Text = "همه"
        Me.btnSelectAll_TarakoneshSN.UseVisualStyleBackColor = False
        '
        'BtnDeselectAll_TarakoneshSN
        '
        Me.BtnDeselectAll_TarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeselectAll_TarakoneshSN.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDeselectAll_TarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDeselectAll_TarakoneshSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDeselectAll_TarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeselectAll_TarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDeselectAll_TarakoneshSN.Image = CType(resources.GetObject("BtnDeselectAll_TarakoneshSN.Image"), System.Drawing.Image)
        Me.BtnDeselectAll_TarakoneshSN.Location = New System.Drawing.Point(287, 233)
        Me.BtnDeselectAll_TarakoneshSN.Name = "BtnDeselectAll_TarakoneshSN"
        Me.BtnDeselectAll_TarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeselectAll_TarakoneshSN.Size = New System.Drawing.Size(41, 29)
        Me.BtnDeselectAll_TarakoneshSN.TabIndex = 5
        Me.BtnDeselectAll_TarakoneshSN.Text = "هيچ "
        Me.BtnDeselectAll_TarakoneshSN.UseVisualStyleBackColor = False
        '
        'pnlNTarakoneshSN
        '
        Me.pnlNTarakoneshSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNTarakoneshSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNTarakoneshSN.Location = New System.Drawing.Point(4, 233)
        Me.pnlNTarakoneshSN.Name = "pnlNTarakoneshSN"
        Me.pnlNTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNTarakoneshSN.Size = New System.Drawing.Size(276, 29)
        Me.pnlNTarakoneshSN.TabIndex = 3
        '
        'pnlGridTarakoneshSN
        '
        Me.pnlGridTarakoneshSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridTarakoneshSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridTarakoneshSN.Location = New System.Drawing.Point(2, 18)
        Me.pnlGridTarakoneshSN.Name = "pnlGridTarakoneshSN"
        Me.pnlGridTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridTarakoneshSN.Size = New System.Drawing.Size(654, 210)
        Me.pnlGridTarakoneshSN.TabIndex = 2
        '
        'pnlCmdTarakoneshSN
        '
        Me.pnlCmdTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdTarakoneshSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdTarakoneshSN.Location = New System.Drawing.Point(376, 234)
        Me.pnlCmdTarakoneshSN.Name = "pnlCmdTarakoneshSN"
        Me.pnlCmdTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdTarakoneshSN.Size = New System.Drawing.Size(273, 29)
        Me.pnlCmdTarakoneshSN.TabIndex = 1
        Me.pnlCmdTarakoneshSN.TabStop = True
        '
        'tabpTozih
        '
        Me.tabpTozih.Controls.Add(Me.lblTozih)
        Me.tabpTozih.Controls.Add(Me.txtTozih)
        Me.tabpTozih.Location = New System.Drawing.Point(4, 79)
        Me.tabpTozih.Name = "tabpTozih"
        Me.tabpTozih.Size = New System.Drawing.Size(663, 311)
        Me.tabpTozih.TabIndex = 4
        Me.tabpTozih.Text = "توضيحات سند"
        '
        'lblTozih
        '
        Me.lblTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTozih.Location = New System.Drawing.Point(477, 12)
        Me.lblTozih.Name = "lblTozih"
        Me.lblTozih.Size = New System.Drawing.Size(147, 24)
        Me.lblTozih.TabIndex = 7
        Me.lblTozih.Text = "توضيحات سند شبيه :"
        '
        'txtTozih
        '
        Me.txtTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTozih.Location = New System.Drawing.Point(105, 12)
        Me.txtTozih.MaxLength = 250
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTozih.Size = New System.Drawing.Size(372, 23)
        Me.txtTozih.TabIndex = 6
        '
        'TabPNoeZayeatSN
        '
        Me.TabPNoeZayeatSN.Controls.Add(Me.grpboxNoeZayeatSN)
        Me.TabPNoeZayeatSN.Location = New System.Drawing.Point(4, 104)
        Me.TabPNoeZayeatSN.Name = "TabPNoeZayeatSN"
        Me.TabPNoeZayeatSN.Size = New System.Drawing.Size(663, 286)
        Me.TabPNoeZayeatSN.TabIndex = 22
        Me.TabPNoeZayeatSN.Text = "نوع ضايعات"
        '
        'grpboxNoeZayeatSN
        '
        Me.grpboxNoeZayeatSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxNoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.grpboxNoeZayeatSN.Controls.Add(Me.btnSelectAll_NoeZayeatSN)
        Me.grpboxNoeZayeatSN.Controls.Add(Me.btnDeselectAll_NoeZayeatSN)
        Me.grpboxNoeZayeatSN.Controls.Add(Me.pnlNNoeZayeatSN)
        Me.grpboxNoeZayeatSN.Controls.Add(Me.pnlGridNoeZayeatSN)
        Me.grpboxNoeZayeatSN.Controls.Add(Me.pnlCmdNoeZayeatSN)
        Me.grpboxNoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxNoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpboxNoeZayeatSN.Location = New System.Drawing.Point(0, 3)
        Me.grpboxNoeZayeatSN.Name = "grpboxNoeZayeatSN"
        Me.grpboxNoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpboxNoeZayeatSN.Size = New System.Drawing.Size(660, 218)
        Me.grpboxNoeZayeatSN.TabIndex = 12
        Me.grpboxNoeZayeatSN.TabStop = False
        '
        'btnSelectAll_NoeZayeatSN
        '
        Me.btnSelectAll_NoeZayeatSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_NoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_NoeZayeatSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_NoeZayeatSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_NoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_NoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_NoeZayeatSN.Location = New System.Drawing.Point(332, 175)
        Me.btnSelectAll_NoeZayeatSN.Name = "btnSelectAll_NoeZayeatSN"
        Me.btnSelectAll_NoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_NoeZayeatSN.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_NoeZayeatSN.TabIndex = 16
        Me.btnSelectAll_NoeZayeatSN.Text = "همه"
        Me.btnSelectAll_NoeZayeatSN.UseVisualStyleBackColor = False
        '
        'btnDeselectAll_NoeZayeatSN
        '
        Me.btnDeselectAll_NoeZayeatSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll_NoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll_NoeZayeatSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll_NoeZayeatSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll_NoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll_NoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll_NoeZayeatSN.Location = New System.Drawing.Point(288, 175)
        Me.btnDeselectAll_NoeZayeatSN.Name = "btnDeselectAll_NoeZayeatSN"
        Me.btnDeselectAll_NoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll_NoeZayeatSN.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll_NoeZayeatSN.TabIndex = 15
        Me.btnDeselectAll_NoeZayeatSN.Text = "هيچ "
        Me.btnDeselectAll_NoeZayeatSN.UseVisualStyleBackColor = False
        '
        'pnlNNoeZayeatSN
        '
        Me.pnlNNoeZayeatSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNNoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNNoeZayeatSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNNoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNNoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNNoeZayeatSN.Location = New System.Drawing.Point(5, 175)
        Me.pnlNNoeZayeatSN.Name = "pnlNNoeZayeatSN"
        Me.pnlNNoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNNoeZayeatSN.Size = New System.Drawing.Size(276, 29)
        Me.pnlNNoeZayeatSN.TabIndex = 14
        '
        'pnlGridNoeZayeatSN
        '
        Me.pnlGridNoeZayeatSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridNoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridNoeZayeatSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridNoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridNoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridNoeZayeatSN.Location = New System.Drawing.Point(3, 17)
        Me.pnlGridNoeZayeatSN.Name = "pnlGridNoeZayeatSN"
        Me.pnlGridNoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridNoeZayeatSN.Size = New System.Drawing.Size(654, 151)
        Me.pnlGridNoeZayeatSN.TabIndex = 13
        '
        'pnlCmdNoeZayeatSN
        '
        Me.pnlCmdNoeZayeatSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCmdNoeZayeatSN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmdNoeZayeatSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmdNoeZayeatSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCmdNoeZayeatSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmdNoeZayeatSN.Location = New System.Drawing.Point(377, 176)
        Me.pnlCmdNoeZayeatSN.Name = "pnlCmdNoeZayeatSN"
        Me.pnlCmdNoeZayeatSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmdNoeZayeatSN.Size = New System.Drawing.Size(273, 29)
        Me.pnlCmdNoeZayeatSN.TabIndex = 12
        Me.pnlCmdNoeZayeatSN.TabStop = True
        '
        'TabMashinNo
        '
        Me.TabMashinNo.Controls.Add(Me.GroupBox5)
        Me.TabMashinNo.Controls.Add(Me.GroupBox4)
        Me.TabMashinNo.Location = New System.Drawing.Point(4, 104)
        Me.TabMashinNo.Name = "TabMashinNo"
        Me.TabMashinNo.Size = New System.Drawing.Size(663, 286)
        Me.TabMashinNo.TabIndex = 27
        Me.TabMashinNo.Text = "شماره ماشين/بارنامه"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblShomarehMashin)
        Me.GroupBox5.Controls.Add(Me.txtToShomarehMashin)
        Me.GroupBox5.Controls.Add(Me.txtFromShomarehMashin)
        Me.GroupBox5.Controls.Add(Me.label)
        Me.GroupBox5.Location = New System.Drawing.Point(104, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(544, 56)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "شماره ماشين"
        '
        'lblShomarehMashin
        '
        Me.lblShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehMashin.AutoSize = True
        Me.lblShomarehMashin.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehMashin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehMashin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehMashin.Location = New System.Drawing.Point(464, 38)
        Me.lblShomarehMashin.Name = "lblShomarehMashin"
        Me.lblShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehMashin.Size = New System.Drawing.Size(21, 13)
        Me.lblShomarehMashin.TabIndex = 27
        Me.lblShomarehMashin.Text = "از :"
        Me.lblShomarehMashin.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtToShomarehMashin
        '
        Me.txtToShomarehMashin.AcceptsReturn = True
        Me.txtToShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToShomarehMashin.BackColor = System.Drawing.SystemColors.Window
        Me.txtToShomarehMashin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToShomarehMashin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToShomarehMashin.Location = New System.Drawing.Point(72, 30)
        Me.txtToShomarehMashin.MaxLength = 0
        Me.txtToShomarehMashin.Name = "txtToShomarehMashin"
        Me.txtToShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToShomarehMashin.Size = New System.Drawing.Size(137, 21)
        Me.txtToShomarehMashin.TabIndex = 28
        Me.txtToShomarehMashin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFromShomarehMashin
        '
        Me.txtFromShomarehMashin.AcceptsReturn = True
        Me.txtFromShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromShomarehMashin.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromShomarehMashin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFromShomarehMashin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromShomarehMashin.Location = New System.Drawing.Point(320, 30)
        Me.txtFromShomarehMashin.MaxLength = 0
        Me.txtFromShomarehMashin.Name = "txtFromShomarehMashin"
        Me.txtFromShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromShomarehMashin.Size = New System.Drawing.Size(137, 21)
        Me.txtFromShomarehMashin.TabIndex = 28
        Me.txtFromShomarehMashin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label
        '
        Me.label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Cursor = System.Windows.Forms.Cursors.Default
        Me.label.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label.Location = New System.Drawing.Point(216, 38)
        Me.label.Name = "label"
        Me.label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label.Size = New System.Drawing.Size(20, 13)
        Me.label.TabIndex = 27
        Me.label.Text = "تا :"
        Me.label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFromShomarehBarnameh)
        Me.GroupBox4.Controls.Add(Me.lblShomarehBarnameh)
        Me.GroupBox4.Controls.Add(Me.txtToShomarehBarnameh)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(104, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(544, 56)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "شماره بارنامه"
        '
        'txtFromShomarehBarnameh
        '
        Me.txtFromShomarehBarnameh.AcceptsReturn = True
        Me.txtFromShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromShomarehBarnameh.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFromShomarehBarnameh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromShomarehBarnameh.Location = New System.Drawing.Point(320, 30)
        Me.txtFromShomarehBarnameh.MaxLength = 0
        Me.txtFromShomarehBarnameh.Name = "txtFromShomarehBarnameh"
        Me.txtFromShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromShomarehBarnameh.Size = New System.Drawing.Size(137, 21)
        Me.txtFromShomarehBarnameh.TabIndex = 26
        Me.txtFromShomarehBarnameh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShomarehBarnameh
        '
        Me.lblShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehBarnameh.AutoSize = True
        Me.lblShomarehBarnameh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehBarnameh.Location = New System.Drawing.Point(464, 38)
        Me.lblShomarehBarnameh.Name = "lblShomarehBarnameh"
        Me.lblShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehBarnameh.Size = New System.Drawing.Size(21, 13)
        Me.lblShomarehBarnameh.TabIndex = 25
        Me.lblShomarehBarnameh.Text = "از :"
        Me.lblShomarehBarnameh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtToShomarehBarnameh
        '
        Me.txtToShomarehBarnameh.AcceptsReturn = True
        Me.txtToShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToShomarehBarnameh.BackColor = System.Drawing.SystemColors.Window
        Me.txtToShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToShomarehBarnameh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToShomarehBarnameh.Location = New System.Drawing.Point(72, 30)
        Me.txtToShomarehBarnameh.MaxLength = 0
        Me.txtToShomarehBarnameh.Name = "txtToShomarehBarnameh"
        Me.txtToShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToShomarehBarnameh.Size = New System.Drawing.Size(137, 21)
        Me.txtToShomarehBarnameh.TabIndex = 26
        Me.txtToShomarehBarnameh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(216, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(20, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "تا :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabTaghazaKonandeh
        '
        Me.TabTaghazaKonandeh.Controls.Add(Me.GroupBox6)
        Me.TabTaghazaKonandeh.Location = New System.Drawing.Point(4, 104)
        Me.TabTaghazaKonandeh.Name = "TabTaghazaKonandeh"
        Me.TabTaghazaKonandeh.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTaghazaKonandeh.Size = New System.Drawing.Size(663, 286)
        Me.TabTaghazaKonandeh.TabIndex = 29
        Me.TabTaghazaKonandeh.Text = "واحد تقاضا کننده"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.btnSelectAll_TaghazaKonandeh)
        Me.GroupBox6.Controls.Add(Me.btnDeSelectAll_TaghazaKonandeh)
        Me.GroupBox6.Controls.Add(Me.pnlNTaghazaKonandeh)
        Me.GroupBox6.Controls.Add(Me.pnlGTaghazaKonandeh)
        Me.GroupBox6.Controls.Add(Me.pnlCTaghazaKonandeh)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox6.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox6.Size = New System.Drawing.Size(659, 211)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "واحد تقاضا کننده در تدارکات داخلی"
        '
        'btnSelectAll_TaghazaKonandeh
        '
        Me.btnSelectAll_TaghazaKonandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_TaghazaKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_TaghazaKonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_TaghazaKonandeh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_TaghazaKonandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_TaghazaKonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_TaghazaKonandeh.Location = New System.Drawing.Point(330, 178)
        Me.btnSelectAll_TaghazaKonandeh.Name = "btnSelectAll_TaghazaKonandeh"
        Me.btnSelectAll_TaghazaKonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_TaghazaKonandeh.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_TaghazaKonandeh.TabIndex = 6
        Me.btnSelectAll_TaghazaKonandeh.Text = "همه"
        Me.btnSelectAll_TaghazaKonandeh.UseVisualStyleBackColor = False
        '
        'btnDeSelectAll_TaghazaKonandeh
        '
        Me.btnDeSelectAll_TaghazaKonandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeSelectAll_TaghazaKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeSelectAll_TaghazaKonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeSelectAll_TaghazaKonandeh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeSelectAll_TaghazaKonandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeSelectAll_TaghazaKonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeSelectAll_TaghazaKonandeh.Location = New System.Drawing.Point(286, 178)
        Me.btnDeSelectAll_TaghazaKonandeh.Name = "btnDeSelectAll_TaghazaKonandeh"
        Me.btnDeSelectAll_TaghazaKonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeSelectAll_TaghazaKonandeh.Size = New System.Drawing.Size(41, 29)
        Me.btnDeSelectAll_TaghazaKonandeh.TabIndex = 5
        Me.btnDeSelectAll_TaghazaKonandeh.Text = "هيچ "
        Me.btnDeSelectAll_TaghazaKonandeh.UseVisualStyleBackColor = False
        '
        'pnlNTaghazaKonandeh
        '
        Me.pnlNTaghazaKonandeh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNTaghazaKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNTaghazaKonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNTaghazaKonandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNTaghazaKonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNTaghazaKonandeh.Location = New System.Drawing.Point(4, 178)
        Me.pnlNTaghazaKonandeh.Name = "pnlNTaghazaKonandeh"
        Me.pnlNTaghazaKonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNTaghazaKonandeh.Size = New System.Drawing.Size(275, 29)
        Me.pnlNTaghazaKonandeh.TabIndex = 3
        '
        'pnlGTaghazaKonandeh
        '
        Me.pnlGTaghazaKonandeh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGTaghazaKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGTaghazaKonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGTaghazaKonandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGTaghazaKonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGTaghazaKonandeh.Location = New System.Drawing.Point(2, 18)
        Me.pnlGTaghazaKonandeh.Name = "pnlGTaghazaKonandeh"
        Me.pnlGTaghazaKonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGTaghazaKonandeh.Size = New System.Drawing.Size(653, 155)
        Me.pnlGTaghazaKonandeh.TabIndex = 2
        '
        'pnlCTaghazaKonandeh
        '
        Me.pnlCTaghazaKonandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCTaghazaKonandeh.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCTaghazaKonandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCTaghazaKonandeh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCTaghazaKonandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCTaghazaKonandeh.Location = New System.Drawing.Point(375, 179)
        Me.pnlCTaghazaKonandeh.Name = "pnlCTaghazaKonandeh"
        Me.pnlCTaghazaKonandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCTaghazaKonandeh.Size = New System.Drawing.Size(273, 29)
        Me.pnlCTaghazaKonandeh.TabIndex = 1
        Me.pnlCTaghazaKonandeh.TabStop = True
        '
        'btnFilterOK
        '
        Me.btnFilterOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnFilterOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterOK.Location = New System.Drawing.Point(208, 3)
        Me.btnFilterOK.Name = "btnFilterOK"
        Me.btnFilterOK.Size = New System.Drawing.Size(90, 24)
        Me.btnFilterOK.TabIndex = 0
        Me.btnFilterOK.Text = "تاييد"
        '
        'btnFilterCancel
        '
        Me.btnFilterCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFilterCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterCancel.Location = New System.Drawing.Point(23, 3)
        Me.btnFilterCancel.Name = "btnFilterCancel"
        Me.btnFilterCancel.Size = New System.Drawing.Size(90, 24)
        Me.btnFilterCancel.TabIndex = 2
        Me.btnFilterCancel.Text = "انصراف"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.btnFilterOK)
        Me.Panel3.Controls.Add(Me.btnDelWhere)
        Me.Panel3.Controls.Add(Me.btnFilterCancel)
        Me.Panel3.Location = New System.Drawing.Point(355, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 29)
        Me.Panel3.TabIndex = 35
        '
        'btnDelWhere
        '
        Me.btnDelWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelWhere.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelWhere.Location = New System.Drawing.Point(115, 3)
        Me.btnDelWhere.Name = "btnDelWhere"
        Me.btnDelWhere.Size = New System.Drawing.Size(90, 24)
        Me.btnDelWhere.TabIndex = 0
        Me.btnDelWhere.Text = "حذف شروط"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton1.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 0
        '
        'tmrResort
        '
        Me.tmrResort.Interval = 1
        '
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(402, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "شماره رهگيري"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPNoeKala
        '
        Me.TabPNoeKala.Controls.Add(Me.GrpBoxNoeKala)
        Me.TabPNoeKala.Controls.Add(Me.CmbNoeKala)
        Me.TabPNoeKala.Location = New System.Drawing.Point(4, 79)
        Me.TabPNoeKala.Name = "TabPNoeKala"
        Me.TabPNoeKala.Size = New System.Drawing.Size(663, 311)
        Me.TabPNoeKala.TabIndex = 16
        Me.TabPNoeKala.Text = "نوع کالا"
        '
        'GrpBoxNoeKala
        '
        Me.GrpBoxNoeKala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBoxNoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.GrpBoxNoeKala.Controls.Add(Me.btnDeselectAll_NoeKala)
        Me.GrpBoxNoeKala.Controls.Add(Me.btnSelectAll_NoeKala)
        'Me.GrpBoxNoeKala.Controls.Add(Me.btnRefresh_NoeKala)
        Me.GrpBoxNoeKala.Controls.Add(Me.PnlNavNoeKala)
        Me.GrpBoxNoeKala.Controls.Add(Me.PnlGridNoeKala)
        Me.GrpBoxNoeKala.Controls.Add(Me.PnlCmdNoeKala)
        Me.GrpBoxNoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxNoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpBoxNoeKala.Location = New System.Drawing.Point(1, 0)
        Me.GrpBoxNoeKala.Name = "GrpBoxNoeKala"
        Me.GrpBoxNoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpBoxNoeKala.Size = New System.Drawing.Size(659, 271)
        Me.GrpBoxNoeKala.TabIndex = 1
        Me.GrpBoxNoeKala.TabStop = False
        Me.GrpBoxNoeKala.Text = "نوع کالاها"
        '
        'btnSelectAll_NoeKala
        '
        Me.btnSelectAll_NoeKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll_NoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll_NoeKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll_NoeKala.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll_NoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll_NoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll_NoeKala.Location = New System.Drawing.Point(330, 238)
        Me.btnSelectAll_NoeKala.Name = "btnSelectAll_NoeKala"
        Me.btnSelectAll_NoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll_NoeKala.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll_NoeKala.TabIndex = 6
        Me.btnSelectAll_NoeKala.Text = "همه"
        Me.btnSelectAll_NoeKala.UseVisualStyleBackColor = False
        '
        'btnDeselectAll_NoeKala
        '
        Me.btnDeselectAll_NoeKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll_NoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll_NoeKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll_NoeKala.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll_NoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll_NoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll_NoeKala.Location = New System.Drawing.Point(286, 238)
        Me.btnDeselectAll_NoeKala.Name = "btnDeselectAll_NoeKala"
        Me.btnDeselectAll_NoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll_NoeKala.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll_NoeKala.TabIndex = 5
        Me.btnDeselectAll_NoeKala.Text = "هيچ "
        Me.btnDeselectAll_NoeKala.UseVisualStyleBackColor = False
        '
        'PnlNavNoeKala
        '
        Me.PnlNavNoeKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlNavNoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.PnlNavNoeKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlNavNoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlNavNoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlNavNoeKala.Location = New System.Drawing.Point(4, 238)
        Me.PnlNavNoeKala.Name = "PnlNavNoeKala"
        Me.PnlNavNoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlNavNoeKala.Size = New System.Drawing.Size(275, 29)
        Me.PnlNavNoeKala.TabIndex = 3
        '
        'PnlGridNoeKala
        '
        Me.PnlGridNoeKala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlGridNoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGridNoeKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlGridNoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlGridNoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGridNoeKala.Location = New System.Drawing.Point(2, 18)
        Me.PnlGridNoeKala.Name = "PnlGridNoeKala"
        Me.PnlGridNoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlGridNoeKala.Size = New System.Drawing.Size(653, 215)
        Me.PnlGridNoeKala.TabIndex = 2
        '
        'PnlCmdNoeKala
        '
        Me.PnlCmdNoeKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCmdNoeKala.BackColor = System.Drawing.SystemColors.Control
        Me.PnlCmdNoeKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlCmdNoeKala.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlCmdNoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlCmdNoeKala.Location = New System.Drawing.Point(375, 239)
        Me.PnlCmdNoeKala.Name = "PnlCmdNoeKala"
        Me.PnlCmdNoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlCmdNoeKala.Size = New System.Drawing.Size(273, 29)
        Me.PnlCmdNoeKala.TabIndex = 1
        Me.PnlCmdNoeKala.TabStop = True
        '
        'btnRefresh_NoeKala
        '
        'Me.btnRefresh_NoeKala.BackColor = System.Drawing.SystemColors.Control
        'Me.btnRefresh_NoeKala.Cursor = System.Windows.Forms.Cursors.Default
        'Me.btnRefresh_NoeKala.FlatStyle = System.Windows.Forms.FlatStyle.System
        'Me.btnRefresh_NoeKala.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.btnRefresh_NoeKala.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.btnRefresh_NoeKala.Location = New System.Drawing.Point(344, 6)
        'Me.btnRefresh_NoeKala.Name = "btnRefresh_NoeKala"
        'Me.btnRefresh_NoeKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.btnRefresh_NoeKala.Size = New System.Drawing.Size(49, 24)
        'Me.btnRefresh_NoeKala.TabIndex = 44
        'Me.btnRefresh_NoeKala.Text = "بازخواني"
        'Me.btnRefresh_NoeKala.UseVisualStyleBackColor = False
        '
        'CmbNoeKala
        '
        Me.CmbNoeKala.BackColor = System.Drawing.Color.White
        CmbNoeKala_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeKala_DesignTimeLayout.LayoutString")
        Me.CmbNoeKala.DesignTimeLayout = CmbNoeKala_DesignTimeLayout
        Me.CmbNoeKala.LateBinding = True
        Me.CmbNoeKala.LateBindingTop = "100"
        Me.CmbNoeKala.Location = New System.Drawing.Point(60, 31)
        Me.CmbNoeKala.Name = "CmbNoeKala"
        Me.CmbNoeKala.SaveSettings = False
        Me.CmbNoeKala.Size = New System.Drawing.Size(187, 20)
        Me.CmbNoeKala.TabIndex = 41
        Me.CmbNoeKala.ValuesDataMember = Nothing
        '
        'FrmFilterAsnadAnbar
        '
        Me.AcceptButton = Me.btnFilterOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.btnFilterCancel
        Me.ClientSize = New System.Drawing.Size(670, 429)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FtTabFilterSanad)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(695, 600)
        Me.MinimizeBox = False
        Me.Name = "FrmFilterAsnadAnbar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فيلتر اسناد انبار"
        Me.FtTabFilterSanad.ResumeLayout(False)
        Me.TabPKalaSN.ResumeLayout(False)
        Me.grpboxKalaSN.ResumeLayout(False)
        Me.grpboxKalaSN.PerformLayout()
        Me.TabTaminKonandeh.ResumeLayout(False)
        Me.TabAnbar.ResumeLayout(False)
        Me.TabAnbar.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.tabpSanadDate.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.TabChideman.ResumeLayout(False)
        Me.TabpSabtDate.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabpShomarehSefaresh.ResumeLayout(False)
        Me.pnlShomarehSefaresh.ResumeLayout(False)
        Me.pnlShomarehSefaresh.PerformLayout()
        Me.TabpKalaStatusAmvalSN.ResumeLayout(False)
        Me.grpboxKalaStatusAmvalSN.ResumeLayout(False)
        Me.tabpKalaWhere.ResumeLayout(False)
        Me.GrpKalaWhere.ResumeLayout(False)
        Me.TabPRezerv.ResumeLayout(False)
        Me.FraMohasebeRezerv.ResumeLayout(False)
        Me.TabPGoroohBandiTarakonesh.ResumeLayout(False)
        Me.tpShomarehRahgiri.ResumeLayout(False)
        Me.pnlKalaPhiziki.ResumeLayout(False)
        Me.pnlKalaPhiziki.PerformLayout()
        Me.tabpSanadStatus.ResumeLayout(False)
        Me.FraSanadStaus.ResumeLayout(False)
        Me.TabPGoroohBandiKalaSN.ResumeLayout(False)
        Me.tabpDarjKalaPhizikiFor.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPNoeTarakoneshKalaSN.ResumeLayout(False)
        Me.FraQC.ResumeLayout(False)
        Me.tabpSanadNO.ResumeLayout(False)
        Me.pnlSanadNO.ResumeLayout(False)
        Me.pnlSanadNO.PerformLayout()
        Me.TabPNoeMarjooeiSN.ResumeLayout(False)
        Me.grpboxNoeMarjooeiSN.ResumeLayout(False)
        Me.TabPTafsiliSN.ResumeLayout(False)
        Me.grpboxTafsiliSN.ResumeLayout(False)
        Me.TabpTarakoneshSN.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabpTozih.ResumeLayout(False)
        Me.tabpTozih.PerformLayout()
        Me.TabPNoeZayeatSN.ResumeLayout(False)
        Me.grpboxNoeZayeatSN.ResumeLayout(False)
        Me.TabMashinNo.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabTaghazaKonandeh.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabPNoeKala.ResumeLayout(False)
        Me.GrpBoxNoeKala.ResumeLayout(False)
        Me.GrpBoxNoeKala.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region


    'يك ديتا ويو از نوع ابزار جهت نمايش  طرف حساب ها تعريف شده است
    Public WithEvents DvTafsili As CDataView

    Public WithEvents DvTaghazaKonandeh As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgTafsili As AxVSFlexGrid

    Private WithEvents vfgTaghazaKonandeh As AxVSFlexGrid

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالا ها تعريف شده است
    Public WithEvents DvKala As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgKala As AxVSFlexGrid
    'يك ديتا ويو از نوع ابزار جهت نمايش  کالا ها تعريف شده است
    Public WithEvents DvNoeZayeat As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgNoeZayeat As AxVSFlexGrid
    'يك ديتا ويو از نوع ابزار جهت نمايش  کالا ها تعريف شده است
    Public WithEvents DvNoeMarjooei As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgNoeMarjooei As AxVSFlexGrid

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالا ها تعريف شده است
    Public WithEvents DvKalaStatusAmval As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgKalaStatusAmval As AxVSFlexGrid

    'يك ديتا ويو از نوع ابزار جهت تراکنشهاي انبار تعريف شده است
    Public WithEvents DvTarakonesh As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgTarakonesh As AxVSFlexGrid

    '   براي نمايش تاريخ در فيلتر 
    Private dclFDate As NetSql.Components.CDateCtrl
    '   براي نمايش تاريخ در فيلتر 
    Private dclTDate As NetSql.Components.CDateCtrl

    '//By Izadpanah-851208
    '   براي نمايش تاريخ در فيلتر 
    Private dclFSDate As NetSql.Components.CDateCtrl
    '   براي نمايش تاريخ در فيلتر 
    Private dclTSDate As NetSql.Components.CDateCtrl
    '//By Izadpanah-851208

    ' خروجي فيلتر گروه بندي براساس کليدهاي اوليه
    Private pKala_FilterSelectedGoroohSN As String
    ' خروجي فيلتر گروه بندي بر اساس شرط قابل استفاده در سلکت
    Private pKala_FilterWhereCondition As String

    ' خروجي فيلتر گروه بندي براساس کليدهاي اوليه
    Private pChidemanKala_FilterSelectedChidemanSN As String
    ' خروجي فيلتر گروه بندي بر اساس شرط قابل استفاده در سلکت
    Private pChidemanKala_FilterWhereCondition As String

    ' خروجي فيلتر گروه بندي براساس کليدهاي اوليه
    Private pTarakonesh_FilterSelectedGoroohSN As String
    ' خروجي فيلتر گروه بندي بر اساس شرط قابل استفاده در سلکت
    Private pTarakonesh_FilterWhereCondition As String

    ' يک نمونه از گروه بندي کالا براي فيلتر گزارش
    Private pKala_GoroohBandi As Minoo.Applications.Paye.GoroohBandi
    ' يک نمونه از گروه بندي تراکنش انبار براي فيلتر گزارش
    Private pTarakoneshGoroohBandi As Minoo.Applications.Paye.GoroohBandi
    ' يک نمونه از گروه بندي کالا براي فيلتر گزارش
    Private pChidemanKala As New Minoo.Applications.Anbar.Common.CSharedItem

    ' آيا فرم قبلا در حافظه وارد شده است
    Private pIsLoad As Boolean

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Public WithEvents DvAnbarTree As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgTree As AxVSFlexGrid
    Private mSelected As String

    Public WithEvents DvTaminKonandeh As CDataView
    Private WithEvents vfgTaminKonandeh As AxVSFlexGrid

    'Added By Nooshin Alipour in 14031206
    'يك ديتا ويو از نوع ابزار جهت نمايش  کالا ها تعريف شده است
    Public WithEvents DvNoeKala As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgNoeKala As AxVSFlexGrid
    Public Property Selected() As String
        Get
            Selected = mSelected
        End Get
        Set(ByVal Value As String)
            If Trim(Value) = "" Then
                mSelected = gAnbarSN
            Else
                mSelected = Value
            End If
            SelectByStr(mSelected)
        End Set
    End Property

    Private Sub btnFilterCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterCancel.Click
        Me.Hide()
    End Sub
    Private Sub btnFilterOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterOK.Click
        ' با توجه به اطلاعات کاربر که در فيلترهاي مختلف ثبت کرده است خصوصيات فرم فيلتر پر مي گردد
        SetProperty()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
    Private Sub FrmFilterAsnadAnbar_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Me.Hide()
    End Sub
    Private Sub FrmFilterAsnadAnbar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        If Not pIsLoad Then
            ' Visible
            If Not VisibleSanadNO Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpSanadNO)
            End If
            If Not VisibleGoroohBandiKala Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPGoroohBandiKalaSN)
            End If
            If Not VisibleChidemanKala Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabChideman)
            Else
                If VisibleMahaleChideman Then
                    chkMahaleChideman.Enabled = True
                Else
                    chkMahaleChideman.Enabled = False
                End If
            End If
            If Not VisibleKala Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPKalaSN)
            End If
            If Not VisibleNoeZayeat Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPNoeZayeatSN)
            End If
            If Not VisibleNoeMarjooei Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPNoeMarjooeiSN)
            End If
            If Not VisibleTaminKonandeh Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabTaminKonandeh)
            End If
            If Not VisibleKalaStatusAmval Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabpKalaStatusAmvalSN)
            End If
            If Not VisibleTarakoneshSN Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabpTarakoneshSN)
            End If
            If Not VisibleNoeTarakoneshKala Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPNoeTarakoneshKalaSN)
            End If
            If Not VisibleRezerv Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPRezerv)
            End If
            If Not VisibleSanadDate Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpSanadDate)
            Else
                txtFromSanadDate.Enabled = EnableFromSanadDate
            End If
            '//By Izadpanah -851208
            If Not VisibleSabtDate Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabpSabtDate)
            Else
                txtFromSabtDate.Enabled = EnableFromSabtDate
            End If
            '//By Izadpanah -851208

            '//By Izadpanah 870208
            If Not VisibleShomarehMashinBarnameh Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabMashinNo)
            End If
            '//By Izadpanah 870208

            If Not VisibleSanadStatus Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpSanadStatus)
            End If
            If Not VisibleShomarehSefaresh Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpShomarehSefaresh)
            End If
            If Not VisibleShomarehRahgiri Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tpShomarehRahgiri)
            End If
            If Not VisibleTafsili Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPTafsiliSN)
            End If
            If Not VisibleTaghazaKonandeh Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabTaghazaKonandeh)
            End If
            If Not VisibleTarakonesh Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPGoroohBandiTarakonesh)
            End If
            If Not VisibleTozih Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpTozih)
            End If
            If Not VisibleKalaWhere Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpKalaWhere)
            End If
            If Not VisibleDarjKalaPhizikiFor Then
                Me.FtTabFilterSanad.Controls.Remove(Me.tabpDarjKalaPhizikiFor)
            End If
            If Not VisibleNoeKala Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabPNoeKala)
            End If
            ' Visible
            '' Checked
            chkSanadStatus_1.Checked = CheckedSanadStatus_1
            chkSanadStatus_4.Checked = CheckedSanadStatus_4
            chkSanadStatus_8.Checked = CheckedSanadStatus_8

            chkNoeTarakoneshKalaNO0.Checked = CheckedNoeTarakoneshKala_0
            chkNoeTarakoneshKalaNO1.Checked = CheckedNoeTarakoneshKala_1
            chkNoeTarakoneshKalaNO2.Checked = CheckedNoeTarakoneshKala_2
            chkNoeTarakoneshKalaNO3.Checked = CheckedNoeTarakoneshKala_3
            chkNoeTarakoneshKalaNO4.Checked = CheckedNoeTarakoneshKala_4
            chkNoeTarakoneshKalaNO5.Checked = CheckedNoeTarakoneshKala_5
            chkNoeTarakoneshKalaNO6.Checked = CheckedNoeTarakoneshKala_6

            chkMahaleChideman.Checked = CheckedMahaleChideman

            If Not VisibleAnbar Then
                Me.FtTabFilterSanad.Controls.Remove(Me.TabAnbar)
            End If

            '' Checked
            FtTabFilterSanad.SelectedIndex = 0

            Selected = gAnbarSelected

            With CmbNoeMahsool
                .ShowSelectAll = True
                .Bind(cn, "Select NoemahsoolSN,NoemahsoolDS from Panoemahsool union select 1.001 As NoemahsoolSN,'نا معلوم' As NoemahsoolDS", "NoemahsoolSN", "NoemahsoolDS")
                .BoundText = "0.000"
            End With
            '--------------- add by yekta 921205
            With CmbMahiateKala
                .ShowSelectAll = True
                .Bind(cn, "select MahiatKalaSN,MahiatKalaDs from paMahiatKala union select 1.001 As MahiatKalaSN,'نا معلوم' As MahiatKalaDs", "MahiatKalaSN", "MahiatKalaDs")
                .BoundText = "0.000"
            End With
            '--------------- add by yekta 921205
            '--------------- add by yekta 930217
            With CmbNoeAnbar
                .ShowSelectAll = True
                .Bind(cn, "select NoeAnbarSN,NoeAnbarDs from abNoeanbar union select 0.000 As NoeAnbarSN,'همه انبارها' As NoeAnbarDs union select 0.100 As NoeAnbarSN,'انبارهای تجمیع' As NoeAnbarDs", "NoeAnbarSN", "NoeAnbarDs")
                .BoundText = "0.000"
            End With
            '--------------- add by yekta 930217
            'Added By Nooshin Alipour in 14031206
            With CmbNoeKala
                .ShowSelectAll = True
                .Bind(cn, "Select NoeKalaSN,NoeKalaDS from PaNoeKala union select 1.001 As NoeKalaSN,'نا معلوم' As NoeKalaDS", "NoeKalaSN", "NoeKalaDS")
                .BoundText = "0.000"
            End With
            'Added By Nooshin Alipour in 14031206
            pIsLoad = True
        End If
    End Sub

    Private Sub btnGorooheKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnGorooheKala.Click
        ' استفاده از فيلتر گروه بندي کالا
        Dim vWhereConditionColumn As String
        If Trim(WhereConditionColumnGoroohBandiKala) <> "" Then
            vWhereConditionColumn = WhereConditionColumnGoroohBandiKala
        Else
            vWhereConditionColumn = "KalaSN"
        End If
        pKala_GoroohBandi.ShowFilterGorooh(True, 1.935, 0, vWhereConditionColumn)
        pKala_FilterSelectedGoroohSN = pKala_GoroohBandi.FilterSelectedGoroohSN
        pKala_FilterWhereCondition = pKala_GoroohBandi.FilterWhereCondition
    End Sub

    Private Sub btnGorooheTarakonesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnGorooheTarakonesh.Click
        ' استفاده از فيلتر گروه بندي تراکنش انبار
        Dim vWhereConditionColumn As String
        If Trim(WhereConditionColumnTarakonesh) <> "" Then
            vWhereConditionColumn = WhereConditionColumnTarakonesh
        Else
            vWhereConditionColumn = "TarakoneshSN"
        End If
        pTarakoneshGoroohBandi.ShowFilterGorooh(True, 6.935, 0, vWhereConditionColumn)
        pTarakonesh_FilterSelectedGoroohSN = pTarakoneshGoroohBandi.FilterSelectedGoroohSN
        pTarakonesh_FilterWhereCondition = pTarakoneshGoroohBandi.FilterWhereCondition
    End Sub

#Region "Property"

    Private mFilterNoeAnbarSN As Decimal
    Private mPervFilterNoeAnbarSN As Decimal
    ' Friend
    Public Property FilterNoeAnbarSN() As Decimal
        Get
            FilterNoeAnbarSN = mFilterNoeAnbarSN
        End Get
        Set(ByVal Value As Decimal)
            If mFilterNoeAnbarSN <> Value And mFilterNoeAnbarSN <> 0 Then
                mPervFilterNoeAnbarSN = mFilterNoeAnbarSN
                FtTabFilterSanad.SelectedIndex = 0
            End If
            mFilterNoeAnbarSN = Value
        End Set
    End Property

    Public mAnbarGardaniSN As Decimal

    Public Property AnbarGardaniSN() As Decimal
        Get
            AnbarGardaniSN = mAnbarGardaniSN
        End Get
        Set(ByVal Value As Decimal)
            Dim vSql As String
            If mAnbarGardaniSN <> Value Then
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                       " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(Value)
                '               " FROM abShomaresh WHERE  ShomareshStatus = 1 AND AnbarGardaniSN =  " + CStr(Value)
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                dcbabShomareshMoghayer.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                       " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(Value)
                '               " FROM abShomaresh WHERE  ShomareshStatus = 1 AND AnbarGardaniSN =  " + CStr(Value)
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                dcbFabShomareshLast.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                       " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(Value)
                '               " FROM abShomaresh WHERE  ShomareshStatus = 1 AND AnbarGardaniSN =  " + CStr(Value)
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                dcbTabShomareshLast.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                       " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(Value)
                '               " FROM abShomaresh WHERE  ShomareshStatus = 1 AND AnbarGardaniSN =  " + CStr(Value)
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                dbcCopyFShomareshSN.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " &
                       " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(Value)
                '               " FROM abShomaresh WHERE  ShomareshStatus = 1 AND AnbarGardaniSN =  " + CStr(Value)
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                dbcCopyTShomareshSN.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
            End If
            mAnbarGardaniSN = Value
        End Set
    End Property

    Public VisibleSanadDate As Boolean
    ' آيا اين سريرگ نمايش داده شود ؟

    Public VisibleSabtDate As Boolean = False
    ' آيا اين سريرگ نمايش داده شود ؟-ByIzadpanah-851207

    Public WhereConditionColumnSanadDate As String
    '  براي ساختن رشته شرط که مستقيم در سلکت استفاده شود نام ستون چيست
    Public WhereConditionColumnSabtDate As String
    '  براي ساختن رشته شرط که مستقيم در سلکت استفاده شود نام ستون چيست
    Public SelectedFromSanadDate As String
    ' ‌از تاريخ
    Public EnableFromSanadDate As Boolean
    Public SelectedToSanadDate As String
    ' ‌تا تاريخ

    '//By Izadpanah-For SabtDate Filter-851208
    Public SelectedFromSabtDate As String
    ' ‌از تاريخ
    Public EnableFromSabtDate As Boolean
    Public SelectedToSabtDate As String
    ' ‌تا تاريخ
    '//By Izadpanah-For SabtDate Filter-851208

    '//ByIzadpanah-870208
    Public VisibleShomarehMashinBarnameh As Boolean = False
    ' آيا اين سريرگ نمايش داده شود ؟-ByIzadpanah-870208

    Public WhereConditionColumnShomarehBarnameh As String
    Public SelectedFromShomarehBarnameh As String
    Public SelectedToShomarehBarnameh As String

    Public WhereConditionColumnShomarehMashin As String
    Public SelectedToShomarehMashin As String
    Public SelectedFromShomarehMashin As String
    '//ByIzadpanah-870208

    Public WhereConditionSanadDate As String
    ' رشته شرط که مستقيم ميتوان در سلکت آنرا استفاده کرد
    Public WhereConditionSabtDate As String
    ' رشته شرط که مستقيم ميتوان در سلکت آنرا استفاده کرد

    Public VisibleKala As Boolean
    Public WhereConditionColumnKalaSN As String
    Public SelectedKalaSN As String
    Public WhereConditionKalaSN As String
    Public SelectedopnKalaRaked As String
    Public SelectedopnKalaWithCount As String
    Public SelectedopnKalaMandehdar As String
    Public SelectedopnKalaAnbar As String
    Public SelectedopnKalaGardeshDar As String
    'Public EnableopnKalaRaked As Boolean
    'Public EnableopnKalaWithCount As Boolean
    'Public EnableopnKalaMandehdar As Boolean
    'Public EnableopnKalaAnbar As Boolean
    'Public EnableopnKalaGardeshDar As Boolean
    Public SelectedVaredehCount As String
    Public SelectedSaderehCount As String

    Public VisibleNoeZayeat As Boolean
    Public WhereConditionColumnNoeZayeatSN As String
    Public SelectedNoeZayeatSN As String
    Public WhereConditionNoeZayeatSN As String

    Public VisibleNoeMarjooei As Boolean
    Public WhereConditionColumnNoeMarjooeiSN As String
    Public SelectedNoeMarjooeiSN As String
    Public WhereConditionNoeMarjooeiSN As String

    Public VisibleTaminKonandeh As Boolean
    Public WhereConditionColumnTaminKonandehSN As String
    Public SelectedTaminKonandehSN As String
    Public WhereConditionTaminKonandehSN As String

    Public VisibleKalaStatusAmval As Boolean
    Public WhereConditionColumnKalaStatusAmvalSN As String
    Public SelectedKalaStatusAmvalSN As String
    Public WhereConditionKalaStatusAmvalSN As String

    Public VisibleGoroohBandiKala As Boolean
    Public WhereConditionColumnGoroohBandiKala As String
    Public GoroohBandi_Kala_FilterSelectedGoroohSN As String
    Public GoroohBandi_Kala_FilterWhereCondition As String

    Public VisibleChidemanKala As Boolean
    Public WhereConditionColumnChidemanKala As String
    Public Chideman_Kala_FilterSelectedChidemanSN As String
    Public Chideman_Kala_FilterWhereCondition As String
    Public VisibleMahaleChideman As Boolean
    Public CheckedMahaleChideman As Boolean
    Public SelectedMahaleChideman As String

    Public VisibleTarakoneshSN As Boolean
    Public WhereConditionColumnTarakoneshSN As String
    Public SelectedTarakoneshSN As String
    Public WhereConditionTarakoneshSN As String

    Public VisibleTarakonesh As Boolean
    Public WhereConditionColumnTarakonesh As String
    Public GoroohBandi_Tarakonesh_FilterSelectedGoroohSN As String
    Public GoroohBandi_Tarakonesh_FilterWhereCondition As String
    Public WhereConditionTarakonesh As String

    Public VisibleTafsili As Boolean
    Public WhereConditionColumnTafsiliSN As String
    Public SelectedTafsiliSN As String
    Public WhereConditionTafsiliSN As String

    Public VisibleTaghazaKonandeh As Boolean
    Public WhereConditionColumnTaghazaKonandeh As String
    Public SelectedTaghazaKonandeh As String
    Public WhereConditionTaghazaKonandeh As String

    Public VisibleSanadNO As Boolean
    Public WhereConditionColumnSanadNO As String
    Public SelectedFromSanadNo As String
    Public SelectedToSanadNo As String
    Public WhereConditionSanadNO As String

    Public VisibleSanadStatus As Boolean
    Public WhereConditionColumnSanadStatus As String
    Public SelectedSanadStatus As String
    Public WhereConditionSanadStatus As String
    Public CheckedSanadStatus_1 As Boolean
    Public CheckedSanadStatus_4 As Boolean
    Public CheckedSanadStatus_8 As Boolean

    Public VisibleShomarehSefaresh As Boolean
    Public WhereConditionColumnShomarehSefaresh As String
    Public SelectedFromShomarehSefaresh As String
    Public SelectedToShomarehSefaresh As String
    Public WhereConditionShomarehSefaresh As String

    Public VisibleShomarehRahgiri As Boolean
    Public WhereConditionColumnShomarehRahgiri As String
    Public SelectedFromShomarehRahgiri As String
    Public SelectedToShomarehRahgiri As String
    Public WhereConditionShomarehRahgiri As String

    Public VisibleTozih, VisibleDarjKalaPhizikiFor As Boolean
    Public WhereConditionColumnTozih As String
    Public SelectedTozih As String
    Public WhereConditionTozih As String

    Public VisibleNoeTarakoneshKala As Boolean
    Public WhereConditionColumnNoeTarakoneshKala As String
    Public SelectedNoeTarakoneshKala As String
    Public WhereConditionNoeTarakoneshKala As String
    Public CheckedNoeTarakoneshKala_0 As Boolean
    Public CheckedNoeTarakoneshKala_1 As Boolean
    Public CheckedNoeTarakoneshKala_2 As Boolean
    Public CheckedNoeTarakoneshKala_3 As Boolean
    Public CheckedNoeTarakoneshKala_4 As Boolean
    Public CheckedNoeTarakoneshKala_5 As Boolean
    Public CheckedNoeTarakoneshKala_6 As Boolean

    Public VisibleRezerv As Boolean
    Public WhereConditionColumnRezerv As String
    Public SelectedRezerv As String
    Public WhereConditionRezerv As String

    Public VisibleKalaWhere As Boolean
    Public SelectedKalaGardeshDar As String
    Public SelectedKalaMandehDar As String
    Public SelectedKalaGardeshAll As String
    'Public EnableKalaGardeshDar As Boolean
    'Public EnableKalaMandehDar As Boolean
    'Public EnableKalaGardeshAll As Boolean
    Public WhereConditionColumnKalaWhere As String
    Public WhereConditionKalaWhere As String

    Public SelectedAllKalaPhiziki As String
    Public SelectedAllKalaPhizikiMojoodiMoghayer As String
    Public ShomareshSNMoghayer As Decimal
    Public SelectedAllKalaPhizikiLastMoghayer As String
    Public FabShomareshSNLast, TabShomareshSNLast As Decimal

    Public SelectedCopyShomaresh As String, SelectedDarjKalaPhiziki As String
    Public CopyFShomareshSN, CopyTShomareshSN As Decimal

    '//BY Izadpanah -870208
    Public WhereConditionShomarehMashin As String
    Public WhereConditionShomarehBarnameh As String

    '//BY Izadpanah -870208

    Public VisibleAnbar As Boolean = False
    ' آيا اين سريرگ نمايش داده شود ؟-ByIzadpanah-870208
    Public WhereConditionColumnAnbar As String
    Public SelectedAnbarSN As String
    'Added By Nooshin Alipour in 14031206
    Public VisibleNoeKala As Boolean
    Public WhereConditionColumnNoeKala As String
    Public SelectedNoeKala As String
    Public WhereConditionNoeKala As String
    'Added By Nooshin Alipour in 14031206

#End Region

    ' Friend
    Public Sub init()
        chkSanadStatus_1.Checked = CheckedSanadStatus_1
        chkSanadStatus_4.Checked = CheckedSanadStatus_4
        chkSanadStatus_8.Checked = CheckedSanadStatus_8

        chkNoeTarakoneshKalaNO0.Checked = CheckedNoeTarakoneshKala_0
        chkNoeTarakoneshKalaNO1.Checked = CheckedNoeTarakoneshKala_1
        chkNoeTarakoneshKalaNO2.Checked = CheckedNoeTarakoneshKala_2
        chkNoeTarakoneshKalaNO3.Checked = CheckedNoeTarakoneshKala_3
        chkNoeTarakoneshKalaNO4.Checked = CheckedNoeTarakoneshKala_4
        chkNoeTarakoneshKalaNO5.Checked = CheckedNoeTarakoneshKala_5
        chkNoeTarakoneshKalaNO6.Checked = CheckedNoeTarakoneshKala_6

        chkMahaleChideman.Checked = CheckedMahaleChideman

        If Trim(SelectedFromSanadDate) <> "" Then
            dclFDate.Value = SelectedFromSanadDate
        End If
        If Trim(SelectedToSanadDate) <> "" Then
            dclTDate.Value = SelectedToSanadDate
        End If

        '//By Izadpanah-851208
        If Trim(SelectedFromSanadDate) <> "" Then
            dclFSDate.Value = SelectedFromSabtDate
        End If
        If Trim(SelectedToSanadDate) <> "" Then
            dclTSDate.Value = SelectedToSabtDate
        End If
        '//By Izadpanah-851208

    End Sub

    Public Sub SetProperty()
        ' تنظيم خصوصيات فرم فيلتر
        If Trim(dclFDate.Value) <> "" Then
            SelectedFromSanadDate = Trim(dclFDate.Value)
        Else
            SelectedFromSanadDate = ""
        End If
        If Trim(dclTDate.Value) <> "" Then
            SelectedToSanadDate = Trim(dclTDate.Value)
        Else
            SelectedToSanadDate = ""
        End If

        '//By Izadpanah-851208
        If Trim(dclFSDate.Value) <> "" Then
            SelectedFromSabtDate = Trim(dclFSDate.Value)
        Else
            SelectedFromSabtDate = ""
        End If
        If Trim(dclTSDate.Value) <> "" Then
            SelectedToSabtDate = Trim(dclTSDate.Value)
        Else
            SelectedToSabtDate = ""
        End If
        '//By Izadpanah-851208

        If Trim(SelectedToSanadDate) <> "" And Trim(SelectedFromSanadDate) <> "" _
           And Trim(WhereConditionColumnSanadDate) <> "" Then
            WhereConditionSanadDate = WhereConditionColumnSanadDate & " BETWEEN  '" & SelectedFromSanadDate & "'" &
                                      "  AND '" & SelectedToSanadDate & "'"
        End If

        '//By Izadpanah-851208
        If Trim(SelectedToSabtDate) <> "" And Trim(SelectedFromSabtDate) <> "" _
           And Trim(WhereConditionColumnSabtDate) <> "" Then
            WhereConditionSabtDate = WhereConditionColumnSabtDate & " BETWEEN  '" & SelectedFromSabtDate & "'" &
                                     "  AND '" & SelectedToSabtDate & "'"
        Else
            WhereConditionSabtDate = ""
        End If
        '//By Izadpanah-851208

        WhereConditionKalaSN = ""
        SelectedKalaSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgKala, "KalaSN", "Selected")
        If Len(Trim(SelectedKalaSN)) > 8000 Then
            NetSql.Common.CSystem.MsgBox(
                       "گزينه انتخاب کالاها براي موارد محدود پيش بيني شده است. ممکن است برخي از کالاهاي انتخابي  در گزارش مشاهده نگردند ")
        End If

        WhereConditionColumnTaminKonandehSN = ""
        SelectedTaminKonandehSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTaminKonandeh, "TaminVahedeTejariSN", "Selected")
        If Len(Trim(SelectedTaminKonandehSN)) > 8000 Then
            NetSql.Common.CSystem.MsgBox(
                       "گزينه انتخاب تامین کننده براي موارد محدود پيش بيني شده است. ممکن است برخي از تامین کننده انتخابي  در گزارش مشاهده نگردند ")
        End If

        If Trim(SelectedKalaSN) <> "" And Trim(WhereConditionColumnKalaSN) <> "" Then
            WhereConditionKalaSN = WhereConditionColumnKalaSN & " IN ( " + SelectedKalaSN + " ) "
        End If

        WhereConditionNoeZayeatSN = ""
        SelectedNoeZayeatSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgNoeZayeat, "NoeZayeatSN",
                                                                                   "Selected")
        If Trim(SelectedNoeZayeatSN) <> "" And Trim(WhereConditionColumnNoeZayeatSN) <> "" Then
            WhereConditionNoeZayeatSN = WhereConditionColumnNoeZayeatSN & " IN ( " + SelectedNoeZayeatSN + " ) "
        End If

        WhereConditionNoeMarjooeiSN = ""
        SelectedNoeMarjooeiSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgNoeMarjooei, "NoeMarjooeiSN",
                                                                                   "Selected")
        If Trim(SelectedNoeMarjooeiSN) <> "" And Trim(WhereConditionColumnNoeMarjooeiSN) <> "" Then
            WhereConditionNoeMarjooeiSN = WhereConditionColumnNoeMarjooeiSN & " IN ( " + SelectedNoeMarjooeiSN + " ) "
        End If

        WhereConditionTaminKonandehSN = ""
        SelectedTaminKonandehSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTaminKonandeh, "TaminVahedeTejariSN",
                                                                                   "Selected")
        If Trim(SelectedTaminKonandehSN) <> "" And Trim(WhereConditionColumnTaminKonandehSN) <> "" Then
            WhereConditionTaminKonandehSN = WhereConditionColumnTaminKonandehSN & " IN ( " + SelectedTaminKonandehSN + " ) "
        End If

        WhereConditionKalaStatusAmvalSN = ""
        SelectedKalaStatusAmvalSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgKalaStatusAmval,
                                                                                   "KalaStatusAmvalSN", "Selected")
        If Trim(SelectedKalaStatusAmvalSN) <> "" And Trim(WhereConditionColumnKalaStatusAmvalSN) <> "" Then
            WhereConditionKalaStatusAmvalSN = WhereConditionColumnKalaStatusAmvalSN &
                                              " IN ( " + SelectedKalaStatusAmvalSN + " ) "
        End If

        GoroohBandi_Kala_FilterSelectedGoroohSN = ""
        GoroohBandi_Kala_FilterWhereCondition = ""
        GoroohBandi_Kala_FilterSelectedGoroohSN = pKala_FilterSelectedGoroohSN
        GoroohBandi_Kala_FilterWhereCondition = pKala_FilterWhereCondition

        Chideman_Kala_FilterSelectedChidemanSN = ""
        Chideman_Kala_FilterWhereCondition = ""
        Chideman_Kala_FilterSelectedChidemanSN = pChidemanKala_FilterSelectedChidemanSN
        Chideman_Kala_FilterWhereCondition = pChidemanKala_FilterWhereCondition
        SelectedMahaleChideman = 0
        If chkMahaleChideman.Checked = True Then SelectedMahaleChideman = 1

        WhereConditionTarakoneshSN = ""
        SelectedTarakoneshSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTarakonesh, "TarakoneshSN",
                                                                                   "Selected")
        If Trim(SelectedTarakoneshSN) <> "" And Trim(WhereConditionColumnTarakoneshSN) <> "" Then
            WhereConditionTarakoneshSN = WhereConditionColumnTarakoneshSN & " IN ( " + SelectedTarakoneshSN + " ) "
        End If

        GoroohBandi_Tarakonesh_FilterSelectedGoroohSN = pTarakonesh_FilterSelectedGoroohSN
        GoroohBandi_Tarakonesh_FilterWhereCondition = pTarakonesh_FilterWhereCondition
        WhereConditionTarakonesh = ""

        WhereConditionTafsiliSN = ""
        SelectedTafsiliSN =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTafsili, "TafsiliSN", "Selected")
        If Trim(SelectedTafsiliSN) <> "" And Trim(WhereConditionColumnTafsiliSN) <> "" Then
            WhereConditionTafsiliSN = WhereConditionColumnTafsiliSN & " IN ( " + SelectedTafsiliSN + " ) "
        End If

        WhereConditionTaghazaKonandeh = ""
        SelectedTaghazaKonandeh =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTaghazaKonandeh, "ChartSazemaniSN", "Selected")
        If Trim(SelectedTaghazaKonandeh) <> "" And Trim(WhereConditionColumnTaghazaKonandeh) <> "" Then
            WhereConditionTaghazaKonandeh = WhereConditionColumnTaghazaKonandeh & " IN ( " + SelectedTaghazaKonandeh + " ) "
        End If

        SelectedSanadStatus = ""
        If chkSanadStatus_1.CheckState = 1 Then SelectedSanadStatus = SelectedSanadStatus & ", 1"
        If chkSanadStatus_4.CheckState = 1 Then SelectedSanadStatus = SelectedSanadStatus & ", 4"
        If chkSanadStatus_8.CheckState = 1 Then SelectedSanadStatus = SelectedSanadStatus & ", 8"
        If Trim(SelectedSanadStatus) = "" Then SelectedSanadStatus = ",1,4,8"
        SelectedSanadStatus = Mid(SelectedSanadStatus, 2, Len(SelectedSanadStatus))
        If WhereConditionColumnSanadStatus <> "" And SelectedSanadStatus <> "" Then
            WhereConditionSanadStatus = WhereConditionColumnSanadStatus & " IN ( " + SelectedSanadStatus + " ) "
        End If

        WhereConditionSanadNO = ""
        SelectedFromSanadNo = Trim(txtFromSanadNO.Text)
        SelectedToSanadNo = Trim(txtToSanadNO.Text)
        If Trim(SelectedFromSanadNo) <> "" And Trim(SelectedToSanadNo) <> "" _
           And Trim(WhereConditionColumnSanadNO) <> "" Then
            WhereConditionSanadNO = WhereConditionColumnSanadNO &
                                    " BETWEEN  '" & SelectedFromSanadNo & "'" &
                                    "  AND '" & SelectedToSanadNo & "'"
        End If

        WhereConditionShomarehSefaresh = ""
        SelectedFromShomarehSefaresh = Trim(txtFromShomarehSefaresh.Text)
        SelectedToShomarehSefaresh = Trim(txtToShomarehSefaresh.Text)
        If Trim(SelectedFromShomarehSefaresh) <> "" And Trim(SelectedToShomarehSefaresh) <> "" _
           And Trim(WhereConditionColumnShomarehSefaresh) <> "" Then
            WhereConditionShomarehSefaresh = WhereConditionColumnShomarehSefaresh &
                                             " BETWEEN  '" & SelectedFromShomarehSefaresh & "'" &
                                             "  AND '" & SelectedToShomarehSefaresh & "'"
        End If


        WhereConditionShomarehRahgiri = ""
        SelectedFromShomarehRahgiri = Trim(txtFromShomarehRahgiri.Text)
        SelectedToShomarehRahgiri = Trim(txtToShomarehRahgiri.Text)
        If Trim(SelectedFromShomarehRahgiri) <> "" And Trim(SelectedToShomarehRahgiri) <> "" _
           And Trim(WhereConditionColumnShomarehRahgiri) <> "" Then
            WhereConditionShomarehRahgiri = WhereConditionColumnShomarehRahgiri &
                                            " BETWEEN  '" & SelectedFromShomarehRahgiri & "'" &
                                            "  AND '" & SelectedToShomarehRahgiri & "'"
        End If


        WhereConditionTozih = ""
        SelectedTozih = Trim(txtTozih.Text)
        If Trim(SelectedTozih) <> "" And Trim(WhereConditionColumnTozih) <> "" Then
            WhereConditionTozih = WhereConditionColumnTozih &
                                  " LIKE '%" & SelectedTozih & "%'"
        End If
        'Added By Nooshin Alipour in 14031206
        WhereConditionNoeKala = ""
        SelectedNoeKala =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgNoeKala, "NoeKalaSN", "Selected")
        If Trim(SelectedNoeKala) <> "" And Trim(WhereConditionColumnNoeKala) <> "" Then
            WhereConditionNoeKala = WhereConditionColumnNoeKala & " IN ( " + SelectedNoeKala + " ) "
        End If
        'Added By Nooshin Alipour in 14031206
        SelectedNoeTarakoneshKala = ""
        If chkNoeTarakoneshKalaNO0.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 6"
        If chkNoeTarakoneshKalaNO1.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 1"
        If chkNoeTarakoneshKalaNO2.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 2"
        If chkNoeTarakoneshKalaNO3.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 3"
        If chkNoeTarakoneshKalaNO4.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 4"
        If chkNoeTarakoneshKalaNO5.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 5"
        If chkNoeTarakoneshKalaNO6.CheckState = 1 Then SelectedNoeTarakoneshKala = SelectedNoeTarakoneshKala & ", 7"
        If Trim(SelectedNoeTarakoneshKala) <> "" Then
            SelectedNoeTarakoneshKala = Mid(SelectedNoeTarakoneshKala, 2, Len(SelectedNoeTarakoneshKala))
        End If
        WhereConditionNoeTarakoneshKala = ""

        SelectedRezerv = 0
        If opnRezervYes.Checked = True Then SelectedRezerv = 1
        WhereConditionRezerv = ""

        ' شروط کالا
        WhereConditionKalaWhere = ""

        SelectedKalaGardeshDar = 0
        'If optGardeshDar.Checked = True Then   comment by yekta 931210
        If opnKalaGardeshDar.Checked = True Then
            SelectedKalaGardeshDar = 1
            'WhereConditionKalaWhere = WhereConditionColumnKalaWhere & _
            '    " IN ( SELECT KalaPhizikiSN FROM abSanadHa JOIN abSanad ON abSanad.SanadSN = abSanadHa.SanadSN " & _
            '    " WHERE abSanad.AnbarSN IN ( " & gAnbarSelected.ToString & " ) "
            'If Trim(SelectedFromWhereKala) <> "" And Trim(SelectedToWhereKala) <> "" Then
            '  WhereConditionKalaWhere = WhereConditionKalaWhere & _
            '  " AND abSanad.MoaserDate BETWEEN '" & SelectedFromWhereKala & "' AND '" & SelectedToWhereKala & "' "
            'End If
            'WhereConditionKalaWhere = WhereConditionKalaWhere & " )"
        End If

        SelectedKalaMandehDar = 0
        'If optMandehDar.Checked = True Then  comment by yekta 931210
        If opnKalaMandehdar.Checked = True Then
            SelectedKalaMandehDar = 1
            'WhereConditionKalaWhere = WhereConditionColumnKalaWhere & _
            '    " IN ( SELECT KalaPhizikiSN FROM abSanadHa JOIN abSanad ON abSanad.SanadSN = abSanadHa.SanadSN " & _
            '    " WHERE abSanad.AnbarSN IN ( " & gAnbarSelected.ToString & " ) "
            'If Trim(SelectedFromWhereKala) <> "" And Trim(SelectedToWhereKala) <> "" Then
            '  WhereConditionKalaWhere = WhereConditionKalaWhere & _
            '  " AND abSanad.MoaserDate BETWEEN '" & SelectedFromWhereKala & "' AND '" & SelectedToWhereKala & "' "
            'End If
            'WhereConditionKalaWhere = WhereConditionKalaWhere & " GROUP BY KalaPhizikiSN " & _
            '" HAVING SUM(abSanadHa.MeghdareVaredeh) - SUM(abSanadHa.MeghdareSadereh) > 0 )"
        End If

        SelectedKalaGardeshAll = 0
        'If optGardeshAll.Checked = True Then   comment by yekta 931210
        If opnKalaAnbar.Checked = True Then
            SelectedKalaGardeshAll = 1
            'WhereConditionKalaWhere = WhereConditionColumnKalaWhere & _
            '    " IN ( SELECT KalaPhizikiSN FROM abKalaPhiziki WHERE AnbarSN IN ( " & gAnbarSelected.ToString & " ) AND KalaPhizikiStatus = 2 )"
        End If


        'درج کالا فيزيکي بر اساس
        SelectedAllKalaPhiziki = 0
        If optAllKalaPhiziki.Checked = True Then SelectedAllKalaPhiziki = 1

        SelectedAllKalaPhizikiMojoodiMoghayer = 0
        ShomareshSNMoghayer = 0
        If optAllKalaPhizikiMojoodiMoghayer.Checked = True Then
            SelectedAllKalaPhizikiMojoodiMoghayer = 1
            If Trim(dcbabShomareshMoghayer.BoundText) <> "" Then
                ShomareshSNMoghayer = dcbabShomareshMoghayer.BoundText
            End If
        End If

        SelectedAllKalaPhizikiLastMoghayer = 0
        FabShomareshSNLast = 0
        TabShomareshSNLast = 0
        If optAllKalaPhizikiLastMoghayer.Checked = True Then
            SelectedAllKalaPhizikiLastMoghayer = 1
            If Trim(dcbFabShomareshLast.BoundText) <> "" Then
                FabShomareshSNLast = dcbFabShomareshLast.BoundText
            End If
            If Trim(dcbTabShomareshLast.BoundText) <> "" Then
                TabShomareshSNLast = dcbTabShomareshLast.BoundText
            End If
        End If

        SelectedCopyShomaresh = 0
        SelectedDarjKalaPhiziki = 0
        CopyFShomareshSN = 0
        CopyTShomareshSN = 0

        If chkDarjKalaPhiziki.Checked = True Then
            SelectedDarjKalaPhiziki = 1
        End If

        If chkCopyShomaresh.Checked = True Then
            SelectedCopyShomaresh = 1
            If Trim(dbcCopyFShomareshSN.BoundText) <> "" Then
                CopyFShomareshSN = dbcCopyFShomareshSN.BoundText
            End If
            If Trim(dbcCopyTShomareshSN.BoundText) <> "" Then
                CopyTShomareshSN = dbcCopyTShomareshSN.BoundText
            End If
        End If

        '//BY Izadpanah -870208 -Filter shomareh mashin va barnameh
        WhereConditionShomarehMashin = ""
        SelectedFromShomarehMashin = Trim(txtFromShomarehMashin.Text)
        SelectedToShomarehMashin = Trim(txtToShomarehMashin.Text)

        If _
            Trim(SelectedFromShomarehMashin) <> "" And Trim(SelectedToShomarehMashin) <> "" And
            Trim(WhereConditionColumnShomarehMashin) <> "" Then
            WhereConditionShomarehMashin = WhereConditionColumnShomarehMashin &
                                           " BETWEEN  '" & SelectedFromShomarehMashin & "'" &
                                           " AND  '" & SelectedToShomarehMashin & "'"
        End If

        WhereConditionShomarehBarnameh = ""
        SelectedFromShomarehBarnameh = Trim(txtFromShomarehBarnameh.Text)
        SelectedToShomarehBarnameh = Trim(txtToShomarehBarnameh.Text)
        If _
            Trim(SelectedFromShomarehBarnameh) <> "" And Trim(SelectedToShomarehBarnameh) <> "" And
            Trim(WhereConditionColumnShomarehBarnameh) <> "" Then
            WhereConditionShomarehBarnameh = WhereConditionColumnShomarehBarnameh &
                                             "BETWEEN '" & SelectedFromShomarehBarnameh & "'" &
                                             "AND '" & SelectedToShomarehBarnameh & "'"
        End If
        '//BY Izadpanah -870208 -Filter shomareh mashin va barnameh

        mSelected =
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTree, "AnbarSN", "Selected")
        If mSelected <> "" Then
            gAnbarSelected = Selected
            Dim DvAnbarSelected As DataView = cn.ExecuteQuery("Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs_Str ('" & gAnbarSelected.Replace(" ", "") & "')")
            Dim strAnbars As String = ""
            For Each item As DataRowView In DvAnbarSelected
                strAnbars += item(0).ToString + ","
            Next
            If strAnbars.EndsWith(",") Then
                strAnbars = strAnbars.Substring(0, strAnbars.Length - 1)
            End If
            gAnbarSelected = strAnbars
        End If

    End Sub

    Private Sub btnDelWhere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelWhere.Click
        ' خالي شدن مقادير فيلتر
        txtTozih.Text = ""

        txtFromShomarehSefaresh.Text = ""
        txtToShomarehSefaresh.Text = ""

        txtFromShomarehRahgiri.Text = ""
        txtToShomarehRahgiri.Text = ""

        txtFromSanadNO.Text = ""
        txtToSanadNO.Text = ""

        txtFromShomarehBarnameh.Text = ""
        txtToShomarehBarnameh.Text = ""

        txtFromShomarehMashin.Text = ""
        txtToShomarehMashin.Text = ""

        SetProperty()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With DvTafsili.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With

    End Sub

    Private Sub btnDeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With DvTafsili.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub vfgTafsili_AfterEdit(ByVal eventSender As System.Object,
                                      ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgTafsili.AfterEdit
        If e.Row < vfgTafsili.FixedRows Then Exit Sub
        If e.Col <> vfgTafsili.get_ColIndex("Selected") Then Exit Sub
        SelectSubTafsili(e.Row,
                          vfgTafsili.GetCellCheck(e.Row, vfgTafsili.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTafsili_BeforeEdit(ByVal eventSender As System.Object,
                                       ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgTafsili.BeforeEdit
        If e.Row < vfgTafsili.FixedRows Then e.Cancel = True : Exit Sub
        If e.Col <> vfgTafsili.get_ColIndex("Selected") Then e.Cancel = True : Exit Sub
    End Sub

    Private Sub SelectSubTafsili(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTafsili.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTafsili.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTafsili.SetCellCheck(i, vfgTafsili.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub btnSelectAll_KalaSN_click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll_KalaSN.Click
        Dim i As Short
        With DvKala.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With

    End Sub

    Private Sub btnDeselectAll_KalaSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeselectAll_KalaSN.Click
        Dim i As Short
        With DvKala.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub BtnDeselectTaminkonandeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles BtnDeselectTaminkonandeh.Click
        Dim i As Short
        With DvTaminKonandeh.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub vfgKala_AfterEdit(ByVal eventSender As System.Object,
                                   ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgKala.AfterEdit
        If e.Row < vfgKala.FixedRows Then Exit Sub
        If e.Col <> vfgKala.get_ColIndex("Selected") Then Exit Sub
        SelectSubKala(e.Row, vfgKala.GetCellCheck(e.Row, vfgKala.get_ColIndex("Selected")))
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub vfgKala_BeforeEdit(ByVal eventSender As System.Object,
                                    ByVal eventArgs As RowColEventArgs) _
        Handles vfgKala.BeforeEdit
        If eventArgs.Row < vfgKala.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgKala.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub btnSelectAllNoeKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With DvNoeKala.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With

    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub btnDeselectAllNoeKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With DvNoeKala.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub vfgNoeKala_AfterEdit(ByVal eventSender As System.Object,
                                      ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgNoeKala.AfterEdit
        If e.Row < vfgNoeKala.FixedRows Then Exit Sub
        If e.Col <> vfgNoeKala.get_ColIndex("Selected") Then Exit Sub
        SelectSubNoeKala(e.Row,
                          vfgNoeKala.GetCellCheck(e.Row, vfgNoeKala.get_ColIndex("Selected")))
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub vfgNoeKala_BeforeEdit(ByVal eventSender As System.Object,
                                       ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgNoeKala.BeforeEdit
        If e.Row < vfgNoeKala.FixedRows Then e.Cancel = True : Exit Sub
        If e.Col <> vfgNoeKala.get_ColIndex("Selected") Then e.Cancel = True : Exit Sub
    End Sub
    'Added By Nooshin Alipour in 14031206
    'Added By Nooshin Alipour in 14031206
    Private Sub SelectSubNoeKala(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgNoeKala.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgNoeKala.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgNoeKala.SetCellCheck(i, vfgNoeKala.get_ColIndex("Selected"), aSelect)
        Next
    End Sub
    'Added By Nooshin Alipour in 14031206

    Private Sub vfgTaminKonandeh_AfterEdit(ByVal eventSender As System.Object,
                                   ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgTaminKonandeh.AfterEdit
        If e.Row < vfgTaminKonandeh.FixedRows Then Exit Sub
        If e.Col <> vfgTaminKonandeh.get_ColIndex("Selected") Then Exit Sub
        SelectSubTaminKonandeh(e.Row, vfgTaminKonandeh.GetCellCheck(e.Row, vfgTaminKonandeh.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTaminKonandeh_BeforeEdit(ByVal eventSender As System.Object,
                                    ByVal eventArgs As RowColEventArgs) _
        Handles vfgTaminKonandeh.BeforeEdit
        If eventArgs.Row < vfgTaminKonandeh.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgTaminKonandeh.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub vfgTarakonesh_AfterEdit(ByVal eventSender As System.Object,
                                         ByVal eventArgs As RowColEventArgs) _
        Handles vfgTarakonesh.AfterEdit
        If eventArgs.Row < vfgTarakonesh.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgTarakonesh.get_ColIndex("Selected") Then Exit Sub
        SelectSubTarakonesh(eventArgs.Row,
                       vfgTarakonesh.GetCellCheck(eventArgs.Row, vfgTarakonesh.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTarakonesh_BeforeEdit(ByVal eventSender As System.Object,
                                          ByVal eventArgs As RowColEventArgs) _
        Handles vfgTarakonesh.BeforeEdit
        If eventArgs.Row < vfgTarakonesh.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgTarakonesh.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub SelectSubKala(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgKala.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgKala.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgKala.SetCellCheck(i, vfgKala.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub SelectSubTaminKonandeh(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTaminKonandeh.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTaminKonandeh.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTaminKonandeh.SetCellCheck(i, vfgTaminKonandeh.get_ColIndex("Selected"), aSelect)
        Next
    End Sub


    Private Sub SelectSubTarakonesh(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTarakonesh.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTarakonesh.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTarakonesh.SetCellCheck(i, vfgTarakonesh.get_ColIndex("Selected"), aSelect)
        Next
    End Sub


    Private Sub SelectSubNoeZayeat(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgNoeZayeat.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgNoeZayeat.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgNoeZayeat.SetCellCheck(i, vfgNoeZayeat.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub SelectSubNoeMarjooei(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgNoeMarjooei.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgNoeMarjooei.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgNoeMarjooei.SetCellCheck(i, vfgNoeMarjooei.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub SelectSubKalaStatusAmval(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgKalaStatusAmval.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgKalaStatusAmval.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgKalaStatusAmval.SetCellCheck(i, vfgKalaStatusAmval.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub FtTabFilterSanad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles FtTabFilterSanad.SelectedIndexChanged
        Dim vTabPSelected As String
        vTabPSelected = UCase(FtTabFilterSanad.SelectedTab.Name)

        Select Case vTabPSelected
            Case "TABPTAFSILISN"
                If Not DvTafsili.Refreshed Then
                    DvTafsili.Refresh()
                End If
            Case "TABPNOEKALA"
                If Not DvNoeKala.Refreshed Then
                    DvNoeKala.Refresh()
                End If
            Case "TABTAGHAZAKONANDEH"
                If Not DvTaghazaKonandeh.Refreshed Then
                    DvTaghazaKonandeh.Refresh()
                End If
            Case "TABPTARAKONESHSN"
                If Not DvTarakonesh.Refreshed Then
                    DvTarakonesh.Refresh()
                End If
            Case "TABTAMINKONANDEH"
                If Not DvTaminKonandeh.Refreshed Then
                    DvTaminKonandeh.Refresh()
                End If
            Case "TABPKALASN"
                If (Not DvKala.Refreshed) Or mPervFilterNoeAnbarSN <> mFilterNoeAnbarSN Then
                    mPervFilterNoeAnbarSN = mFilterNoeAnbarSN
                    With DvKala
                        .SQLWhere = " paKala.KalaSN IN ( " &
                                    " Select kalaSn  " &
                                    " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                                    " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" &
                                    gHesabdariSalTDate & "'"
                        If FilterNoeAnbarSN <> 0 Then
                            .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN)
                            ' & " ) "
                            'Else   '//By Izadpanah-851215-Changed To Comment
                            '  .SQLWhere = .SQLWhere & " ) " '//By Izadpanah-851215-Changed To Comment
                        End If

                        '//By Izadpanah-851215
                        If gAnbarSelected.ToString <> "" Then
                            .SQLWhere = .SQLWhere & " And  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  )"
                        Else
                            .SQLWhere = .SQLWhere & " ) "
                        End If
                        '//By Izadpanah-851215

                        .SQLOrderBy = " paKala.KalaNO "
                        .Refresh()
                    End With
                End If
            Case "TABPNOEZAYEATSN"
                If (Not DvNoeZayeat.Refreshed) Or mPervFilterNoeAnbarSN <> mFilterNoeAnbarSN Then
                    mPervFilterNoeAnbarSN = mFilterNoeAnbarSN
                    With DvNoeZayeat
                        If FilterNoeAnbarSN <> 0 Then
                            .SQLWhere = " paNoeZayeat.NoeZayeatSN IN ( Select NoeZayeatSn  " &
                                        " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                                        " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                        Else
                            .SQLWhere = " paNoeZayeat.NoeZayeatSN IN ( Select NoeZayeatSn From abSanadHa ) "
                        End If
                        .Refresh()
                    End With
                End If
            Case "TABPNOEMARJOOEISN"
                If (Not DvNoeMarjooei.Refreshed) Or mPervFilterNoeAnbarSN <> mFilterNoeAnbarSN Then
                    mPervFilterNoeAnbarSN = mFilterNoeAnbarSN
                    With DvNoeMarjooei
                        If FilterNoeAnbarSN <> 0 Then
                            .SQLWhere = " paNoeMarjooei.NoeMarjooeiSN IN ( Select NoeMarjooeiSn  " &
                                        " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                                        " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                        Else
                            .SQLWhere = " paNoeMarjooei.NoeMarjooeiSN IN ( Select NoeMarjooeiSn From abSanadHa ) "
                        End If
                        .Refresh()
                    End With
                End If
            Case "TABPKALASTATUSAMVALSN"
                If (Not DvKalaStatusAmval.Refreshed) Or mPervFilterNoeAnbarSN <> mFilterNoeAnbarSN Then
                    mPervFilterNoeAnbarSN = mFilterNoeAnbarSN
                    With DvKalaStatusAmval
                        If FilterNoeAnbarSN <> 0 Then
                            .SQLWhere = " paKalaStatusAmval.KalaStatusAmvalSN IN ( Select AmvalStatus   " &
                                        " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                                        "      INNER JOIN paKala ON abSanadHa.KalaSN = paKala.KalaSN  " &
                                        " Where NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                        Else
                            .SQLWhere =
                                " paKalaStatusAmval.KalaStatusAmvalSN IN ( Select AmvalStatus  From abSanadHa  " &
                                "      INNER JOIN paKala ON abSanadHa.KalaSN = paKala.KalaSN ) "
                        End If
                        .Refresh()
                    End With
                End If
            Case "TABPDARJKALAPHIZIKIFOR"
                dcbabShomareshMoghayer.Refresh()
                dcbFabShomareshLast.Refresh()
                dcbTabShomareshLast.Refresh()
                dbcCopyFShomareshSN.Refresh()
                dbcCopyTShomareshSN.Refresh()
            Case "TABANBAR"

                If (Not DvKalaStatusAmval.Refreshed) Then DvAnbarTree.Refresh()
        End Select
    End Sub

    Private Sub btnSelectAll_TarakoneshSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll_TarakoneshSN.Click
        Dim i As Short
        With DvTarakonesh.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With

    End Sub

    Private Sub BtnDeselectAll_TarakoneshSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles BtnDeselectAll_TarakoneshSN.Click
        Dim i As Short
        With DvTarakonesh.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With

    End Sub

    Private Sub opnKalaGardeshDar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnKalaGardeshDar.CheckedChanged
        If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
            SelectedopnKalaGardeshDar = 1

            Dim _SelText As String = ""
            If CmbNoeMahsool.IsAllItems = False Then
                _SelText = CmbNoeMahsool.getStringValues
            Else
                _SelText = ""
            End If
            If _SelText Is Nothing Then _SelText = ""

            '-----------add by yekta 921205
            Dim _SelTextMahiateKala As String = ""
            If CmbMahiateKala.IsAllItems = False Then
                _SelTextMahiateKala = CmbMahiateKala.getStringValues
            Else
                _SelTextMahiateKala = ""
            End If
            If _SelTextMahiateKala Is Nothing Then _SelTextMahiateKala = ""
            '-----------add by yekta 921205

            With DvKala
                .SQLWhere = " paKala.KalaSN IN ( " &
                            " Select kalaSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate &
                            "'" &
                            " AND abSanad.AnbarSN in( " & gAnbarSelected.ToString & ")"

                .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                '-------------add by yekta 921205
                .SQLWhere = .SQLWhere & " AND ('" & _SelTextMahiateKala & "'='' OR ISNULL(Pakala.MahiatKalaSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelTextMahiateKala & "')))"

                If Not chkAvalDoreh.Checked Then
                    .SQLWhere = .SQLWhere & " AND abSanad.TarakoneshSn <> 44 "
                End If
                If FilterNoeAnbarSN <> 0 Then
                    .SQLWhere = .SQLWhere & " AND  NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                Else
                    .SQLWhere = .SQLWhere & " ) "
                End If
                .SQLOrderBy = " paKala.KalaNO "
                .Refresh()
                Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
            End With
        End If

    End Sub

    Private Sub opnKalaAnbar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnKalaAnbar.CheckedChanged
        If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
            SelectedopnKalaAnbar = 1

            Dim _SelText As String = ""
            If CmbNoeMahsool.IsAllItems = False Then
                _SelText = CmbNoeMahsool.getStringValues
            Else
                _SelText = ""
            End If
            If _SelText Is Nothing Then _SelText = ""

            '-----------add by yekta 921205
            Dim _SelTextMahiateKala As String = ""
            If CmbMahiateKala.IsAllItems = False Then
                _SelTextMahiateKala = CmbMahiateKala.getStringValues
            Else
                _SelTextMahiateKala = ""
            End If
            If _SelTextMahiateKala Is Nothing Then _SelTextMahiateKala = ""
            '-----------add by yekta 921205

            With DvKala
                .SQLWhere = " paKala.KalaSN IN ( Select kalaSn  " &
                            " From abAnbarKala " &
                            " Where  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  "

                .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                '-------------add by yekta 921205
                .SQLWhere = .SQLWhere & " AND ('" & _SelTextMahiateKala & "'='' OR ISNULL(Pakala.MahiatKalaSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelTextMahiateKala & "')))"

                If FilterNoeAnbarSN <> 0 Then
                    .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                Else
                    .SQLWhere = .SQLWhere & " ) "
                End If
                .SQLOrderBy = " paKala.KalaNO "
                .Refresh()
                Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
            End With
        End If
    End Sub

    Private Sub opnKalaRaked_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnKalaRaked.CheckedChanged
        If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
            SelectedopnKalaRaked = 1

            Dim _SelText As String = ""
            If CmbNoeMahsool.IsAllItems = False Then
                _SelText = CmbNoeMahsool.getStringValues
            Else
                _SelText = ""
            End If
            If _SelText Is Nothing Then _SelText = ""

            '-----------add by yekta 921205
            Dim _SelTextMahiateKala As String = ""
            If CmbMahiateKala.IsAllItems = False Then
                _SelTextMahiateKala = CmbMahiateKala.getStringValues
            Else
                _SelTextMahiateKala = ""
            End If
            If _SelTextMahiateKala Is Nothing Then _SelTextMahiateKala = ""
            '-----------add by yekta 921205

            With DvKala
                .SQLWhere = " paKala.KalaSN IN ( Select kalaSn  " &
                            " From abAnbarKala " &
                            " Where  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  "

                .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                '-------------add by yekta 921205
                .SQLWhere = .SQLWhere & " AND ('" & _SelTextMahiateKala & "'='' OR ISNULL(Pakala.MahiatKalaSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelTextMahiateKala & "')))"

                If FilterNoeAnbarSN <> 0 Then
                    .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                Else
                    .SQLWhere = .SQLWhere & " ) "
                End If

                .SQLWhere = .SQLWhere & " AND "

                .SQLWhere = .SQLWhere & " paKala.KalaSN Not IN ( " &
                            " Select kalaSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate &
                            "'" &
                            " AND abSanad.AnbarSN = " & gAnbarSN
                If Not chkAvalDoreh.Checked Then
                    .SQLWhere = .SQLWhere & " AND abSanad.TarakoneshSn <> 44 "
                End If
                If FilterNoeAnbarSN <> 0 Then
                    .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
                Else
                    .SQLWhere = .SQLWhere & " ) "
                End If
                .SQLOrderBy = " paKala.KalaNO "
                .Refresh()
                Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
            End With
        End If

    End Sub

    Private Sub opnKalaMandehdar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnKalaMandehdar.CheckedChanged
        If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
            SelectedopnKalaMandehdar = 1

            Dim _SelText As String = ""
            If CmbNoeMahsool.IsAllItems = False Then
                _SelText = CmbNoeMahsool.getStringValues
            Else
                _SelText = ""
            End If
            If _SelText Is Nothing Then _SelText = ""

            '-----------add by yekta 921205
            Dim _SelTextMahiateKala As String = ""
            If CmbMahiateKala.IsAllItems = False Then
                _SelTextMahiateKala = CmbMahiateKala.getStringValues
            Else
                _SelTextMahiateKala = ""
            End If
            If _SelTextMahiateKala Is Nothing Then _SelTextMahiateKala = ""
            '-----------add by yekta 921205

            With DvKala
                .SQLWhere = " paKala.KalaSN IN ( " &
                            " Select kalaSn  " &
                            " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN  " &
                            " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" & gHesabdariSalTDate &
                            "'" &
                            " AND abSanad.SanadStatus = 8 " &
                            " AND abSanad.AnbarSN = " & gAnbarSN

                .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                '-------------add by yekta 921205
                .SQLWhere = .SQLWhere & " AND ('" & _SelTextMahiateKala & "'='' OR ISNULL(Pakala.MahiatKalaSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelTextMahiateKala & "')))"

                If FilterNoeAnbarSN <> 0 Then
                    .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN)
                End If
                .SQLWhere = .SQLWhere & " GROUP BY KalaSN " &
                            " HAVING SUM(ISNULL(abSanadHa.MeghdareVaredeh,0)) - SUM(ISNULL(abSanadHa.MeghdareSadereh,0)) > 0 )"
                .SQLOrderBy = " paKala.KalaNO "
                .Refresh()
                Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
            End With
        End If
    End Sub

    Private Sub opnKalaWithCount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnKalaWithCount.CheckedChanged

        If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
            SelectedopnKalaWithCount = 1
            SelectedVaredehCount = Trim(txtKalaVaredehCount.Text)
            SelectedSaderehCount = Trim(txtKalaSaderehCount.Text)

            Dim _SelText As String = ""
            If CmbNoeMahsool.IsAllItems = False Then
                _SelText = CmbNoeMahsool.getStringValues
            Else
                _SelText = ""
            End If
            If _SelText Is Nothing Then _SelText = ""

            '-----------add by yekta 921205
            Dim _SelTextMahiateKala As String = ""
            If CmbMahiateKala.IsAllItems = False Then
                _SelTextMahiateKala = CmbMahiateKala.getStringValues
            Else
                _SelTextMahiateKala = ""
            End If
            If _SelTextMahiateKala Is Nothing Then _SelTextMahiateKala = ""
            '-----------add by yekta 921205

            'If SelectedVaredehCount = "" And SelectedSaderehCount = "" Then
            '  Exit Sub
            'End If

            With DvKala

                .SQLWhere = ""

                If SelectedVaredehCount <> "" And Val(SelectedVaredehCount) >= 1 Then
                    .SQLWhere = " paKala.KalaSN IN ( " &
                                " Select kalaSn  " &
                                " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN join abTarakonesh on abSanad.TarakoneshSN = abTarakonesh.TarakoneshSN  " &
                                " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" &
                                gHesabdariSalTDate & "'" &
                                " AND abSanad.AnbarSN = " & gAnbarSN

                    .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                    '-------------add by yekta 921205
                    .SQLWhere = .SQLWhere & " AND ('" & _SelTextMahiateKala & "'='' OR ISNULL(Pakala.MahiatKalaSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelTextMahiateKala & "')))"

                    If Not chkAvalDoreh.Checked Then
                        .SQLWhere = .SQLWhere & " AND abSanad.TarakoneshSn <> 44 "
                    End If
                    If FilterNoeAnbarSN <> 0 Then
                        .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN)
                    End If
                    .SQLWhere = .SQLWhere & " GROUP BY KalaSN, abTarakonesh.Input " &
                                " HAVING abTarakonesh.Input = 1 AND Count(*) >= " & SelectedVaredehCount & " )"
                End If

                If SelectedSaderehCount <> "" And Val(SelectedSaderehCount) >= 1 Then

                    If .SQLWhere <> "" Then
                        .SQLWhere = .SQLWhere & " AND "
                    End If

                    .SQLWhere = .SQLWhere & " paKala.KalaSN IN ( " &
                                " Select kalaSn  " &
                                " From abSanad INNER JOIN abSanadHa ON abSanadHa.SanadSN = abSanad.SanadSN join abTarakonesh on abSanad.TarakoneshSN = abTarakonesh.TarakoneshSN  " &
                                " Where abSanad.MoaserDate BETWEEN '" & gHesabdariSalFDate & "' AND '" &
                                gHesabdariSalTDate & "'" &
                                " AND abSanad.AnbarSN = " & gAnbarSN

                    .SQLWhere = .SQLWhere & " AND ('" & _SelText & "'='' OR ISNULL(Pakala.NoeMahsoolSN,1.001) in ( SELECT CAST(col1 AS DECIMAL(18,3)) FROM StrToTable('" & _SelText & "')))"

                    If FilterNoeAnbarSN <> 0 Then
                        .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN)
                    End If
                    .SQLWhere = .SQLWhere & " GROUP BY KalaSN, abTarakonesh.[OutPut] " &
                                " HAVING abTarakonesh.[OutPut] = 1 AND Count(*) >= " & SelectedSaderehCount & " )"
                End If

                If .SQLWhere = "" Then
                    .SQLWhere = " 1 <> 1 "
                End If

                .SQLOrderBy = " paKala.KalaNO "
                .Refresh()
                Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
            End With
        End If
    End Sub

    Private Sub btnSelectAll_NoeZayeatSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Short
        With DvNoeZayeat.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With

    End Sub

    Private Sub btnDeselectAll_NoeZayeatSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Short
        With DvNoeZayeat.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub vfgNoeZayeat_AfterEdit(ByVal eventSender As System.Object,
                                        ByVal eventArgs As RowColEventArgs) _
        Handles vfgNoeZayeat.AfterEdit
        If eventArgs.Row < vfgNoeZayeat.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgNoeZayeat.get_ColIndex("Selected") Then Exit Sub
        SelectSubNoeZayeat(eventArgs.Row,
                            vfgNoeZayeat.GetCellCheck(eventArgs.Row, vfgNoeZayeat.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgNoeZayeat_BeforeEdit(ByVal eventSender As System.Object,
                                         ByVal eventArgs As RowColEventArgs) _
        Handles vfgNoeZayeat.BeforeEdit
        If eventArgs.Row < vfgNoeZayeat.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgNoeZayeat.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub btnRefresh_KalaSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRefresh_KalaSN.Click
        If opnKalaAnbar.Checked Then
            Me.opnKalaAnbar_CheckedChanged(Me, New System.EventArgs)
        ElseIf opnKalaGardeshDar.Checked Then
            Me.opnKalaGardeshDar_CheckedChanged(Me, New System.EventArgs)
        ElseIf opnKalaRaked.Checked Then
            Me.opnKalaRaked_CheckedChanged(Me, New System.EventArgs)
        ElseIf opnKalaMandehdar.Checked Then
            Me.opnKalaMandehdar_CheckedChanged(Me, New System.EventArgs)
        ElseIf opnKalaWithCount.Checked Then
            Me.opnKalaWithCount_CheckedChanged(Me, New System.EventArgs)
        End If
    End Sub

    Private Sub btnSelectAll_NoeMarjooeiSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll_NoeMarjooeiSN.Click

        Dim i As Short
        With DvNoeMarjooei.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub btnDeselectAll_NoeMarjooeiSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeselectAll_NoeMarjooeiSN.Click
        Dim i As Short
        With DvNoeMarjooei.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With

    End Sub

    Private Sub vfgNoeMarjooei_AfterEdit(ByVal eventSender As System.Object,
                                          ByVal eventArgs As RowColEventArgs) _
        Handles vfgNoeMarjooei.AfterEdit
        If eventArgs.Row < vfgNoeMarjooei.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgNoeMarjooei.get_ColIndex("Selected") Then Exit Sub
        SelectSubNoeMarjooei(eventArgs.Row,
                              vfgNoeMarjooei.GetCellCheck(eventArgs.Row, vfgNoeMarjooei.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgNoeMarjooei_BeforeEdit(ByVal eventSender As System.Object,
                                           ByVal eventArgs As RowColEventArgs) _
        Handles vfgNoeMarjooei.BeforeEdit
        If eventArgs.Row < vfgNoeMarjooei.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgNoeMarjooei.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub btnSelectAll_KalaStatusAmvalSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAll_KalaStatusAmvalSN.Click

        Dim i As Short
        With DvKalaStatusAmval.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub btnDeselectAll_KalaStatusAmvalSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeselectAll_KalaStatusAmvalSN.Click
        Dim i As Short
        With DvKalaStatusAmval.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With

    End Sub

    Private Sub vfgKalaStatusAmval_AfterEdit(ByVal eventSender As System.Object,
                                              ByVal eventArgs As RowColEventArgs) _
        Handles vfgKalaStatusAmval.AfterEdit
        If eventArgs.Row < vfgKalaStatusAmval.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgKalaStatusAmval.get_ColIndex("Selected") Then Exit Sub
        SelectSubKalaStatusAmval(eventArgs.Row,
                                  vfgKalaStatusAmval.GetCellCheck(eventArgs.Row,
                                                                      vfgKalaStatusAmval.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgKalaStatusAmval_BeforeEdit(ByVal eventSender As System.Object,
                                               ByVal eventArgs As RowColEventArgs) _
        Handles vfgKalaStatusAmval.BeforeEdit
        If eventArgs.Row < vfgKalaStatusAmval.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgKalaStatusAmval.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub btnChidemanKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnChidemanKala.Click
        ' استفاده از فيلتر چيدمان کالا
        Dim vWhereConditionColumn As String
        If Trim(WhereConditionColumnChidemanKala) <> "" Then
            vWhereConditionColumn = WhereConditionColumnChidemanKala
        Else
            vWhereConditionColumn = "KalaPhizikiSN"
        End If
        pChidemanKala.ShowFilterChideman(vWhereConditionColumn)
        pChidemanKala_FilterSelectedChidemanSN = pChidemanKala.FilterSelectedChidemanSN
        pChidemanKala_FilterWhereCondition = pChidemanKala.FilterWhereCondition
    End Sub

    Private Sub btnDeselectAllAnbar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnDeselectAllAnbar.Click
        Dim i As Short
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    'Private Sub btnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSelect.Click
    '  mSelected = Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTree, "AnbarSN", "Selected")
    '  Me.Hide()
    'End Sub

    Private Sub btnSelectAllAnbar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelectAllAnbar.Click
        Dim i As Short
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub DvTree_GetGridProperties() Handles DvAnbarTree.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree(DvAnbarTree.FlexGrid, True, "AnbarDs", "AnbarSN" _
                                                  , "SortField", "level")
        DvAnbarTree.FlexGrid.FontSize = 10
    End Sub

    Private Sub SelectSubTree(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTree.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTree.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTree.SetCellCheck(i, vfgTree.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub SelectByStr(ByRef aStr As String)
        Dim i As Short
        Dim J As Short
        Dim vArr() As String
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
        vArr = Split(aStr, ",")
        With vfgTree
            For i = .FixedRows To .Rows - 1
                For J = LBound(vArr) To UBound(vArr)
                    If Trim(vArr(J)) = Trim(.get_TextMatrix(i, .get_ColIndex("AnbarSN"))) Then
                        .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
                    End If
                Next J
            Next i
        End With
    End Sub

    'Private Sub tmrResort_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrResort.Tick
    '  tmrResort.Enabled = False
    '  Minoo.Functions.FTFlexFunctions.MakeTree(DvAnbarTree.FlexGrid, True, "AnbarDs", "AnbarSN" _
    '                                                                            , "SortField", "level", True)
    'End Sub

    Private Sub vfgTree_AfterEdit(ByVal eventSender As System.Object,
                                   ByVal eventArgs As RowColEventArgs) _
        Handles vfgTree.AfterEdit
        If eventArgs.Row < vfgTree.FixedRows Then Exit Sub
        If eventArgs.Col <> vfgTree.get_ColIndex("Selected") Then Exit Sub
        SelectSubTree(eventArgs.Row, vfgTree.GetCellCheck(eventArgs.Row, vfgTree.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTree_BeforeEdit(ByVal eventSender As System.Object,
                                    ByVal eventArgs As RowColEventArgs) _
        Handles vfgTree.BeforeEdit
        If eventArgs.Row < vfgTree.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> vfgTree.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub tmrResort_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles tmrResort.Tick
        tmrResort.Enabled = False
        Minoo.Functions.FTFlexFunctions.MakeTree(DvAnbarTree.FlexGrid, True, "AnbarDs", "AnbarSN" _
                                                  , "SortField", "level", True)
    End Sub

    Private Sub CmbNoeMahsool_CheckedValuesChanged(sender As System.Object, e As System.EventArgs) _
        Handles CmbNoeMahsool.CheckedValuesChanged

        If opnKalaGardeshDar.Checked Then
            opnKalaGardeshDar_CheckedChanged(sender, e)
        ElseIf opnKalaAnbar.Checked Then
            opnKalaAnbar_CheckedChanged(sender, e)
        ElseIf opnKalaRaked.Checked Then
            opnKalaRaked_CheckedChanged(sender, e)
        ElseIf opnKalaMandehdar.Checked Then
            opnKalaMandehdar_CheckedChanged(sender, e)
        ElseIf opnKalaWithCount.Checked Then
            opnKalaWithCount_CheckedChanged(sender, e)
        End If

    End Sub

    Private Sub btnSelectAll_TaghazaKonandeh_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll_TaghazaKonandeh.Click
        Dim i As Short
        With DvTaghazaKonandeh.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub btnDeSelectAll_TaghazaKonandeh_Click(sender As System.Object, e As System.EventArgs) Handles btnDeSelectAll_TaghazaKonandeh.Click
        Dim i As Short
        With DvTaghazaKonandeh.FlexGrid
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub vfgTaghazaKonandeh_AfterEdit(ByVal eventSender As System.Object,
                                  ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
    Handles vfgTaghazaKonandeh.AfterEdit
        If e.Row < vfgTaghazaKonandeh.FixedRows Then Exit Sub
        If e.Col <> vfgTaghazaKonandeh.get_ColIndex("Selected") Then Exit Sub
        SelectSubTaghazaKonandeh(e.Row,
                          vfgTaghazaKonandeh.GetCellCheck(e.Row, vfgTaghazaKonandeh.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTaghazaKonandeh_BeforeEdit(ByVal eventSender As System.Object,
                                       ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles vfgTaghazaKonandeh.BeforeEdit
        If e.Row < vfgTaghazaKonandeh.FixedRows Then e.Cancel = True : Exit Sub
        If e.Col <> vfgTaghazaKonandeh.get_ColIndex("Selected") Then e.Cancel = True : Exit Sub
    End Sub

    Private Sub SelectSubTaghazaKonandeh(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTaghazaKonandeh.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTaghazaKonandeh.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTaghazaKonandeh.SetCellCheck(i, vfgTaghazaKonandeh.get_ColIndex("Selected"), aSelect)
        Next
    End Sub


    Private Sub TabPKalaSN_Click(sender As System.Object, e As System.EventArgs) Handles TabPKalaSN.Click

    End Sub


    Private Sub CmbMahiateKala_CheckedValuesChanged(sender As System.Object, e As System.EventArgs) Handles CmbMahiateKala.CheckedValuesChanged
        If opnKalaGardeshDar.Checked Then
            opnKalaGardeshDar_CheckedChanged(sender, e)
        ElseIf opnKalaAnbar.Checked Then
            opnKalaAnbar_CheckedChanged(sender, e)
        ElseIf opnKalaRaked.Checked Then
            opnKalaRaked_CheckedChanged(sender, e)
        ElseIf opnKalaMandehdar.Checked Then
            opnKalaMandehdar_CheckedChanged(sender, e)
        ElseIf opnKalaWithCount.Checked Then
            opnKalaWithCount_CheckedChanged(sender, e)
        End If
    End Sub


    Private Sub btnRefresh_AnbarSN_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh_AnbarSN.Click
        '-----------add by yekta 921205
        Dim _SelTextNoeAnbar As String = ""
        If CmbNoeAnbar.IsAllItems = False Then
            _SelTextNoeAnbar = CmbNoeAnbar.getStringValues
        Else
            _SelTextNoeAnbar = ""
        End If
        If _SelTextNoeAnbar Is Nothing Then _SelTextNoeAnbar = ""
        '-----------add by yekta 921205
        If (_SelTextNoeAnbar = "") Then
            With DvAnbarTree
                .SQLWhere = " AnbarSN in (Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs ( " & gAnbarSN & "))"
                .Refresh()
                Me.btnSelectAllAnbar_Click(Me, New System.EventArgs)
            End With
        ElseIf (_SelTextNoeAnbar = "0.100") Then
            With DvAnbarTree
                .SQLWhere = " AnbarSN in (Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs ( " & gAnbarSN & ")) AND ( AnbarSN IN (select anbarsn from abanbar where IsTajmie=1))"
                .Refresh()
                Me.btnSelectAllAnbar_Click(Me, New System.EventArgs)
            End With
        Else
            With DvAnbarTree
                .SQLWhere = " AnbarSN in (Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs ( " & gAnbarSN & ")) AND ( AnbarSN IN (select distinct anbarsn from abanbartarakonesh where noeanbarsn in ( " & _SelTextNoeAnbar & ")))"
                .Refresh()
                Me.btnSelectAllAnbar_Click(Me, New System.EventArgs)
            End With
        End If


    End Sub
End Class

