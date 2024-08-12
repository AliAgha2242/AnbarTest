' OK
'Author ::غفاری 
'CreateDate ::  1389/12/08
'ModifiedDate::
'Description::  کپی چیدمان رهگیری ها 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmCopyChideman
    Inherits Minoo.base.FTFormBaseSingleTable

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
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

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1.SuspendLayout()
        Me.TabP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlG
        '
        Me.pnlG.Size = New System.Drawing.Size(718, 416)
        '
        'pnlN
        '
        Me.pnlN.Location = New System.Drawing.Point(5, 420)
        Me.pnlN.Size = New System.Drawing.Size(294, 35)
        '
        'pnlC
        '
        Me.pnlC.Location = New System.Drawing.Point(299, 420)
        '
        'Tab1
        '
        Me.Tab1.Size = New System.Drawing.Size(731, 482)
        '
        'TabP1
        '
        Me.TabP1.Size = New System.Drawing.Size(723, 456)
        '
        'FrmabNoeChideman
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(731, 482)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.Name = "FrmabNoeChideman"
        Me.Text = "رهگیری های فاقد چیدمان"
        Me.Tab1.ResumeLayout(False)
        Me.TabP1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmCopyChideman
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmCopyChideman
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmCopyChideman
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmCopyChideman)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش انواع جايگاه ها ي نگهداري تعريف شده است
    Private WithEvents DVabCopyChideman As CDataView
    Private WithEvents dbcKalaPhizikiSN As New NetSql.Components.DataCombo

    Private Sub DVabCopyChideman_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabCopyChideman.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
            Case EnumCommands.cmSave
                ' مقدار فيلد به صورت منحصربفرد تهيه شده و در فيلد مربوطه ذخيره ميگردد
                DVabCopyChideman.Fields("UnqStr").Value = _
                    Minoo.Functions.FTDBCommonFunctions.UnqStr(cn, (DVabCopyChideman.Fields("NoeChidemanDs").Value))
            Case EnumCommands.cmAbort
            Case EnumCommands.cmDelete
        End Select

    End Sub

    Private Sub FrmabCopyChideman_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        Me.Tab1.TabPages(0).Text = FTDD.GetCaption("abNoeChideman")
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabCopyChideman = New CDataView(cn)
        With DVabCopyChideman
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                       Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter Or _
                                       EnumButtonOptions.boCmdFind)
            .TableName = "abKalaPhiziki"
            'Dim dv As DataView = cn.ExecuteQuery("Select abKalaPhiziki.* from abkalaphiziki LEFT JOIN abkalachideman" & _
            '  " ON abKalaPhiziki.KalaPhizikiSN = abkalachideman.KalaPhizikiSN Where ChidemanSN is null")
            '.DataSource = dv
            '.SQLOrderBy = " NoeChidemanNo "

            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abkalachideman", "KalaPhizikiSN", "KalaPhizikiSN")

            '.AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = False
            .SQLWhere = "abkalachideman.ChidemanSN is null"

            With .Fields
                With .Add("abkalachideman.KalaChidemanSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaSN", "DateCombo <DISABLED>", EnumFieldOptions.foHidden)
                    .ComboLateBinding = True
                    .ReadOnly = True
                End With
                With _
                    .Add( _
                          "KalaPhizikiSN->abVw_abKalaPhiziki_Full.{CONVERT(varchar(20),abVw_abKalaPhiziki_Full.KalaNo) " & _
                          " + ' - ' + abVw_abKalaPhiziki_Full.KalaDS + ' - ' + abVw_abKalaPhiziki_Full.ShomarehRahgiri} AS KalaPhizikiSN " _
                          , "DataCombo", EnumFieldOptions.foDefault)
                    dbcKalaPhizikiSN = .Component
                    .ComboLateBinding = True
                    dbcKalaPhizikiSN.LateBinding = True
                    .Caption = cn.FieldCaption("abKalaChideman.KalaPhizikiSN")
                End With
                With .Add("abkalachideman.FromDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add("abkalachideman.ToDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                .Add("abkalachideman.KalaChidemanTartib", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.ChidemanSN", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.PayeSN", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.RezDA", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.RezDB", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.RezSA", , EnumFieldOptions.foHidden)
                .Add("abkalachideman.RezSB", , EnumFieldOptions.foHidden)
                With .Add("abkalachideman.UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("abkalachideman.Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("abkalachideman.RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With
        DVabCopyChideman.Refresh()
    End Sub

    Private Sub FrmabNoeChideman_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabCopyChideman.Done()
        DVabCopyChideman = Nothing
    End Sub

End Class