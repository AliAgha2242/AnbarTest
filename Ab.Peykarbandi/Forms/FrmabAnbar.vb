' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/02/06 Start 16:45
'ModifiedDate::
'Description:: تعريف انبارها
' ثبت و بروزآوري انبارهاي هر واحد تجاري 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmAnbar
    Inherits Minoo.Base.FTFormBaseSingleTable

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    If Not System.Reflection.Assembly.GetExecutingAssembly.EntryPoint Is Nothing Then
                        If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                            m_vb6FormDefInstance = Me
                        End If
                    End If
                Catch
                End Try
            End If
        End If
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose (ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        '
        'FrmAnbar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (664, 482)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Location = New System.Drawing.Point (3, 29)
        Me.Name = "FrmAnbar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "انبار"

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmAnbar
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmAnbar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAnbar
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmAnbar)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Private WithEvents DVabAnbar As CDataView

    Private Sub DVabAnbar_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabAnbar.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
            Case EnumCommands.cmSave
                ' مقدار فيلد به صورت منحصربفرد تهيه شده و در فيلد مربوطه ذخيره ميگردد
                DVabAnbar.Fields ("UnqStr").Value = _
                    Minoo.Functions.FTDBCommonFunctions.UnqStr (cn, (DVabAnbar.Fields ("AnbarDs").Value))
            Case EnumCommands.cmAbort
            Case EnumCommands.cmDelete
        End Select

    End Sub

    Private Sub FrmAnbar_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabAnbar = New CDataView (cn)
        With DVabAnbar
            .Init (pnlG, , pnlc, pnln, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                       Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter Or _
                                       EnumButtonOptions.boCmdFind)
            .TableName = "abAnbar"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "AnbarStatus", "GeneralStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abVw_Tajmie", "IsTajmie", "TajmieNO")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abVw_Control_Kardex_Mojodi", "TedadGhafase", "ControlNO")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_Control_Nerkh_Standard", "IsRes1", "ControlNO")
            .SQLOrderBy = " CONVERT(INT,AnbarNO) "
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            .SQLWhere = If(gVahedeTejariSN = 1.935, "", " abanbar.VahedeTejariSN=" & gVahedeTejariSN)
            With .Fields
                With .Add ("AnbarSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add ("AnbarNo", "TextBox", EnumFieldOptions.foDefault)
                    .MaxLength = 4
                End With
                .Add ("AnbarDs", "TextBox", EnumFieldOptions.foDefault)
                With .Add ("VahedeTejariSN", "DataCombo", EnumFieldOptions.foDefault)
                    .ComboWhereCondition = " (paVahedeTejari.OzveGorooh = 1)  "
                    .ComboLateBinding = True
                End With
                With .Add ("AnbarStatus->paGeneralStatus.GeneralStatusDs", "DataCombo")
                    .Caption = cn.FieldCaption ("abAnbar.AnbarStatus")
                    .DefaultValue = 1
                End With
                With .Add ("IsTajmie->abVw_Tajmie.TajmieDS", "DataCombo")
                    .Caption = cn.FieldCaption ("abAnbar.IsTajmie")
                    .DefaultValue = 2
                End With
                With .Add ("Identifier", "TextBox", EnumFieldOptions.foDefault)
                End With
                ' جهت عدم کنترل کاردکس از اين فيلد استفاده شده است 
                With .Add ("TedadGhafase->abVw_Control_Kardex_Mojodi.ControlDS", "DataCombo")
                    .Caption = cn.FieldCaption ("abAnbar.TedadGhafase")
                    .DefaultValue = 2
                End With
                'With .Add("TedadGhafase", "CheckBox")
                '  .DefaultValue = 1
                '  .LockInsert = True
                'End With
                .Add ("Zarfiyat", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Address", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Tel", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Fax", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Tozih", "TextBox", EnumFieldOptions.foDefault)
                .Add ("PayeSN", "TextBox", EnumFieldOptions.foHidden)
                .Add ("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add ("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add ("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
                With .Add ("IsSodoorSanadMali->paGeneralStatus.GeneralStatusDs", "CheckBox") ' صدور اسناد مالي
                    .Caption = cn.FieldCaption ("abAnbar.IsSodoorSanadMali")
                    .DefaultValue = 1
                End With
                With .Add ("IsNerkhGozari->paGeneralStatus.GeneralStatusDs", "CheckBox") ' نرخ گذاري استاندارد اسناد
                    .Caption = cn.FieldCaption ("abAnbar.IsNerkhGozari")
                    .DefaultValue = 1
                End With
                With .Add ("IsRes1->abVw_Control_Nerkh_Standard.ControlDS", "CheckBox") ' کنترل وجود نرخ استاندارد
                    .Caption = cn.FieldCaption ("abAnbar.IsRes1")
                    .DefaultValue = 1
                    '0 = بدون کنترل
                    '1 = هنگام صدور اسناد
                    '2 = هنگام قطعي سازي اسناد
                End With
                With .Add ("IsTavaliGhateisazi->paGeneralStatus.GeneralStatusDs", "CheckBox") ' توالي قطعي سازي اسناد
                    .Caption = cn.FieldCaption ("abAnbar.IsTavaliGhateisazi")
                    .DefaultValue = 1
                    '0 = بدون کنترل
                    '1 = رعايت توالي قطعي سازي
                End With
                With .Add ("IsRes2", "CheckBox") 'محاسبه بهاي تمام شده
                    .Caption = cn.FieldCaption ("abAnbar.IsRes2")
                    .DefaultValue = 0
                    '0 = عدم محاسبه بهاي تمام شده
                    '1 =محاسبه بهاي تمام شده
                End With

                With .Add ("IsRes3", ) 'صدور اتوماتيک فاکتور فروش

                End With

                With .Add ("IsRes4", "CheckBox")
                    .Caption = cn.FieldCaption ("abAnbar.IsRes4")
                    'صدور شماره سند بصورت سريالي
                    .DefaultValue = 0
                    '0 = عدم صدور سريالي
                    '1 =صدور سريالي
                End With

                With .Add ("IsRes5", "CheckBox")
                    .Caption = cn.FieldCaption ("abAnbar.IsRes5")
                    'صدور اسناد مالي واقعي
                    .DefaultValue = 0
                End With
                With .Add("SerRes1", "CheckBox")
                    .Caption = "عدم توالی قطعی سازی روی رسیدها"
                    'صدور اسناد مالي واقعي
                    .DefaultValue = 0
                End With
                With .Add("SerRes2", "CheckBox")
                    .Caption = "ماهیت مالی"
                    .DefaultValue = 0
                End With
                With .Add("SerRes3", "Textbox", EnumFieldOptions.foDefault)
                    .DefaultValue = 1
                    .Caption = "نوع انبار غیر محصول (1) / محصول (2)"
                End With
                With .Add("KhoroojRahgiriSN->{abKhoroojRahgiri.KhoroojRahgiriDS + ' _ ' + abKhoroojRahgiri.Tozih} as KhoroojRahgiriSN", "DataCombo")
                    .Caption = "روال خروج رهگیری"
                    .ComboOrderBy = "KhoroojRahgiriSN"
                End With

                With .Add("IsKartonKhorooj", "CheckBox")
                    .Caption = "خروج به صورت پکیج های کامل باشد؟"
                    .DefaultValue = 0
                End With

                With .Add("IsControlMojoodiKala", "CheckBox")
                    .Caption = "کنترل موجودی کالا"
                    .DefaultValue = 0
                End With

                With .Add("IsControlMojoodiKalaphiziki", "CheckBox")
                    .Caption = "کنترل موجودی کالافیزیکی"
                    .DefaultValue = 0
                End With

                With .Add("IsControlKardexKala", "CheckBox")
                    .Caption = "کنترل کاردکس کالا"
                    .DefaultValue = 0
                End With

                With .Add("IsControlKardexKalaphiziki", "CheckBox")
                    .Caption = "کنترل کاردکس کالافیزیکی"
                    .DefaultValue = 0
                End With

                With .Add("IsControlTavaliBeBad", "CheckBox")
                    .Caption = "کنترل توالی به بعد"
                    .DefaultValue = 0
                End With

                With .Add("IsControlTavaliBeGhabl", "CheckBox")
                    .Caption = "کنترل توالی به قبل"
                    .DefaultValue = 0
                End With


            End With
        End With
        DVabAnbar.Refresh()
    End Sub

    Private Sub FrmAnbar_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabAnbar.Done()
        DVabAnbar = Nothing
    End Sub

End Class
