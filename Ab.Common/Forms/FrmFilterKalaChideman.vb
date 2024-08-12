' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/07
'ModifiedDate::
'Description:: تخصيص کالافيزيکي به جايگاههاي نگهداري
'System ::انبار

Option Strict Off
Option Explicit On
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Friend Class FrmFilterKalaChideman
    Inherits Minoo.Base.FTBaseForm

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet1 As System.Windows.Forms.Panel
    Public WithEvents lblabKalaChideman As System.Windows.Forms.Label
    Public WithEvents lblabChideman As System.Windows.Forms.Label
    Public WithEvents tmrResort As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents cmdSelectAll As System.Windows.Forms.Button
    Public WithEvents cmdDeselectAll As System.Windows.Forms.Button
    Public WithEvents cmdSelectB As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim _
            resources As System.Resources.ResourceManager = _
                New System.Resources.ResourceManager (GetType (FrmFilterKalaChideman))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.pnlCommandMaster = New System.Windows.Forms.Panel
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel
        Me.pnlGridMaster = New System.Windows.Forms.Panel
        Me.pnlGridDet1 = New System.Windows.Forms.Panel
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel
        Me.lblabKalaChideman = New System.Windows.Forms.Label
        Me.lblabChideman = New System.Windows.Forms.Label
        Me.tmrResort = New System.Windows.Forms.Timer (Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdSelectAll = New System.Windows.Forms.Button
        Me.cmdDeselectAll = New System.Windows.Forms.Button
        Me.cmdSelectB = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point (483, 316)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size (339, 33)
        Me.pnlCommandMaster.TabIndex = 9
        Me.pnlCommandMaster.Tag = ""
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point (1, 316)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size (276, 33)
        Me.pnlNavigationMaster.TabIndex = 8
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point (1, 27)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size (822, 288)
        Me.pnlGridMaster.TabIndex = 0
        '
        'pnlGridDet1
        '
        Me.pnlGridDet1.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet1.Location = New System.Drawing.Point (1, 381)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size (822, 126)
        Me.pnlGridDet1.TabIndex = 7
        '
        'pnlNavigationDet1
        '
        Me.pnlNavigationDet1.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet1.Location = New System.Drawing.Point (4, 508)
        Me.pnlNavigationDet1.Name = "pnlNavigationDet1"
        Me.pnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet1.Size = New System.Drawing.Size (366, 33)
        Me.pnlNavigationDet1.TabIndex = 6
        '
        'pnlCommandDet1
        '
        Me.pnlCommandDet1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet1.Location = New System.Drawing.Point (402, 508)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size (348, 33)
        Me.pnlCommandDet1.TabIndex = 5
        '
        'lblabKalaChideman
        '
        Me.lblabKalaChideman.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.lblabKalaChideman.BackColor = System.Drawing.SystemColors.Control
        Me.lblabKalaChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabKalaChideman.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblabKalaChideman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabKalaChideman.Location = New System.Drawing.Point (- 32, 363)
        Me.lblabKalaChideman.Name = "lblabKalaChideman"
        Me.lblabKalaChideman.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabKalaChideman.Size = New System.Drawing.Size (891, 17)
        Me.lblabKalaChideman.TabIndex = 10
        Me.lblabKalaChideman.Text = "اعضاء"
        Me.lblabKalaChideman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblabChideman
        '
        Me.lblabChideman.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblabChideman.BackColor = System.Drawing.SystemColors.Control
        Me.lblabChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabChideman.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblabChideman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabChideman.Location = New System.Drawing.Point (- 32, 0)
        Me.lblabChideman.Name = "lblabChideman"
        Me.lblabChideman.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabChideman.Size = New System.Drawing.Size (891, 21)
        Me.lblabChideman.TabIndex = 35
        Me.lblabChideman.Text = "چيدمان انبار"
        Me.lblabChideman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrResort
        '
        Me.tmrResort.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add (Me.cmdSelectAll)
        Me.Panel1.Controls.Add (Me.cmdDeselectAll)
        Me.Panel1.Controls.Add (Me.cmdSelectB)
        Me.Panel1.Location = New System.Drawing.Point (287, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size (186, 31)
        Me.Panel1.TabIndex = 39
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.cmdSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.cmdSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectAll.Image = CType (resources.GetObject ("cmdSelectAll.Image"), System.Drawing.Image)
        Me.cmdSelectAll.Location = New System.Drawing.Point (66, 1)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSelectAll.Size = New System.Drawing.Size (41, 29)
        Me.cmdSelectAll.TabIndex = 9
        Me.cmdSelectAll.Text = "همه"
        '
        'cmdDeselectAll
        '
        Me.cmdDeselectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.cmdDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdDeselectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.cmdDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeselectAll.Image = CType (resources.GetObject ("cmdDeselectAll.Image"), System.Drawing.Image)
        Me.cmdDeselectAll.Location = New System.Drawing.Point (22, 1)
        Me.cmdDeselectAll.Name = "cmdDeselectAll"
        Me.cmdDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDeselectAll.Size = New System.Drawing.Size (41, 29)
        Me.cmdDeselectAll.TabIndex = 8
        Me.cmdDeselectAll.Text = "هيچ "
        '
        'cmdSelectB
        '
        Me.cmdSelectB.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.cmdSelectB.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectB.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelectB.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.cmdSelectB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectB.Location = New System.Drawing.Point (111, 1)
        Me.cmdSelectB.Name = "cmdSelectB"
        Me.cmdSelectB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSelectB.Size = New System.Drawing.Size (53, 29)
        Me.cmdSelectB.TabIndex = 7
        Me.cmdSelectB.Tag = ""
        Me.cmdSelectB.Text = "انتخاب"
        '
        'btnExit
        '
        Me.btnExit.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point (760, 512)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExit.Size = New System.Drawing.Size (53, 29)
        Me.btnExit.TabIndex = 40
        Me.btnExit.Tag = ""
        Me.btnExit.Text = "بازگشت"
        '
        'FrmFilterKalaChideman
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (826, 549)
        Me.Controls.Add (Me.btnExit)
        Me.Controls.Add (Me.Panel1)
        Me.Controls.Add (Me.lblabChideman)
        Me.Controls.Add (Me.pnlCommandMaster)
        Me.Controls.Add (Me.pnlNavigationMaster)
        Me.Controls.Add (Me.pnlGridMaster)
        Me.Controls.Add (Me.pnlGridDet1)
        Me.Controls.Add (Me.pnlNavigationDet1)
        Me.Controls.Add (Me.pnlCommandDet1)
        Me.Controls.Add (Me.lblabKalaChideman)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (11, 65)
        Me.Name = "FrmFilterKalaChideman"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فيلتر چيدمان کالا"
        Me.Panel1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmFilterKalaChideman
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmFilterKalaChideman
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmFilterKalaChideman
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmFilterKalaChideman)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  چيدمان انبار تعريف شده است
    Private WithEvents DVabChideman As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش تخصيص کالا فيزيکي به جايگاههاي نگهداري تعريف شده است
    Private WithEvents DVabKalaChideman As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dbcKalaPhizikiSN As New NetSql.Components.DataCombo

    Private WithEvents pvfgTree As AxVSFlexGrid

    'Private pGoroohMojoodiatSN As Decimal

    'Public Property GoroohMojoodiatSN() As Decimal
    '  Get
    '    GoroohMojoodiatSN = pGoroohMojoodiatSN
    '  End Get
    '  Set(ByVal Value As Decimal)
    '    Dim DV_Value As DataView
    '    If Value <> 0 Then
    '      pGoroohMojoodiatSN = Value
    '      '        _GoroohMojoodiat_ViewName = " Read from server "
    '      ''DV_Value = cn.ExecuteQuery(" SELECT ViewName " & _
    '      ''                           " FROM paGoroohMojoodiat " & _
    '      ''                           " WHERE GoroohMojoodiatSN = " + CStr(pGoroohMojoodiatSN))
    '      ''_GoroohMojoodiat_ViewName = DV_Value(0)(0)
    '    End If

    '  End Set
    'End Property

    'Private _GoroohMojoodiat_ViewName As String
    'Public ReadOnly Property GoroohMojoodiat_ViewName() As String
    '  Get
    '    GoroohMojoodiat_ViewName = _GoroohMojoodiat_ViewName
    '  End Get
    'End Property

    Private _SelectedChidemanSN As String

    Public ReadOnly Property SelectedChidemanSN() As String
        Get
            SelectedChidemanSN = _SelectedChidemanSN
        End Get
    End Property

    Private _WhereConditionColumn As String

    Public Property WhereConditionColumn() As String
        Get
            WhereConditionColumn = _WhereConditionColumn
        End Get
        Set (ByVal Value As String)
            _WhereConditionColumn = Value
        End Set
    End Property

    Private _WhereCondition As String

    Public ReadOnly Property WhereCondition() As String
        Get
            WhereCondition = _WhereCondition
        End Get
    End Property

    'Private _GoroohBandiSN As Decimal
    'Public Property GoroohBandiSN() As Decimal
    '  Get
    '    GoroohBandiSN = _GoroohBandiSN
    '  End Get
    '  Set(ByVal Value As Decimal)
    '    _GoroohBandiSN = Value
    '  End Set
    'End Property

    'Private _ShowGoroohItems As Boolean
    'Public Property ShowGoroohItems() As Boolean
    '  Get
    '    ShowGoroohItems = _ShowGoroohItems
    '  End Get
    '  Set(ByVal Value As Boolean)
    '    _ShowGoroohItems = Value
    '  End Set
    'End Property

    Private Sub DVabChideman_GetGridProperties() Handles DVabChideman.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree (DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level")
    End Sub

    Private Sub FrmFilterKalaChideman_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        lblabChideman.Text = FTDD.GetCaption ("abChideman")
        lblabKalaChideman.Text = FTDD.GetCaption ("abKalaChideman")
    End Sub

    Private Sub FrmabChideman_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabChideman.Done()
        DVabChideman = Nothing
        dbcKalaPhizikiSN.Dispose()
        dbcKalaPhizikiSN = Nothing
        pvfgTree = Nothing

    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabChideman = New CDataView (cn)
        With DVabChideman
            .Init (pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, _
                   EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdPrint)
            .TableName = "abChideman"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abVwj_abChideman", "PedarChidemanSN", "ChidemanSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "ChidemanStatus", "GeneralStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatusYN", "IsKalaIn", "GeneralStatusYNSN")
            pvfgTree = .FlexGrid
            pvfgTree.Editable = EditableSettings.flexEDKbdMouse
            .EditInGrid = False
            .SQLOrderBy = "SortField"
            .NextRowAfterSave = False
            .AutoFetchCurrentRow = False
            ' اعمال شرط براي نمايش اطلاعات انبار جاري
            .SQLWhere = " abChideman.AnbarSN = " & gAnbarSN.ToString
            .AccessRight = EnumAccessRight.arView
            .Text = FTDD.GetCaption(.TableName)
            With .Fields
                With .Add("ChidemanSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("VahedeTejariSN", "DataCombo <DISABLED>", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
                End With
                With .Add("{0} AS Selected", "CheckBox")
                    .Caption = "انتخاب"
                End With
                With .Add("AnbarSN", "DataCombo <DISABLED>", EnumFieldOptions.foDefault)
                    .DefaultValue = gAnbarSN
                    .ComboLateBinding = True
                End With
                With .Add("NoeAnbarSN", "DataCombo <DISABLED>", EnumFieldOptions.foDefault)
                    .DefaultValue = gNoeAnbarSN
                    .ComboLateBinding = True
                End With
                With .Add("NoeChidemanSN", "DataCombo", EnumFieldOptions.foDefault)
                    .LockUpdate = True
                End With
                With .Add("ChidemanNo", "TextBox", EnumFieldOptions.foDefault)
                End With
                With .Add("ChidemanDs", "TextBox", EnumFieldOptions.foDefault)
                End With
                .Add("MaxVazn", "TextBox", EnumFieldOptions.foDefault)
                .Add("Hajm", "TextBox", EnumFieldOptions.foDefault)
                .Add("X", "TextBox", EnumFieldOptions.foDefault)
                .Add("Y", "TextBox", EnumFieldOptions.foDefault)
                .Add("Z", "TextBox", EnumFieldOptions.foDefault)
                .Add("Tool", "TextBox", EnumFieldOptions.foHidden)
                .Add("Arz", "TextBox", EnumFieldOptions.foHidden)
                .Add("Ertefa", "TextBox", EnumFieldOptions.foHidden)
                With .Add("IsKalaIn->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abChideman.IsKalaIn")
                    .DefaultValue = 1
                End With
                With _
                    .Add( _
                          "PedarChidemanSN->abVwj_abChideman.{abVwj_abChideman.ChidemanNo + ' - ' + abVwj_abChideman.NoeChideman_ChidemanDS} " & _
                          " AS PedarChidemanSN " _
                          , "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = FTDD.GetCaption("abChideman", "PedarChidemanSN")
                End With
                With .Add("ChidemanStatus->paGeneralStatus.GeneralStatusDs", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = 1
                End With
                .Add("Tozih", "TextBox", EnumFieldOptions.foDefault)
                .Add("RezDA", , EnumFieldOptions.foHidden)
                .Add("RezDB", , EnumFieldOptions.foHidden)
                .Add("RezSA", , EnumFieldOptions.foHidden)
                .Add("RezSB", , EnumFieldOptions.foHidden)
                .Add("{dbo.abFn_GetTreeabChidemanNodeLevel(abChideman.ChidemanSN)} as Level", , _
                      EnumFieldOptions.foHidden)
                .Add("{dbo.abFn_GetTreeabChidemanSortField(abChideman.ChidemanSN)} as SortField", , _
                      EnumFieldOptions.foHidden)
                .Add("PayeSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        DVabKalaChideman = New CDataView(cn)
        With DVabKalaChideman
            .Init(pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boNone)
            .TableName = "abKalaChideman"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_abKalaPhiziki_Full", "KalaPhizikiSN", "KalaPhizikiSN")
            .AutoFetchCurrentRow = False
            .EditInGrid = False
            .AccessRight = EnumAccessRight.arView
            .Text = "اعضا"
            With .Fields
                With .Add("KalaChidemanSN", , gSNFieldOption)
                    '          .DefaultValue = gSM.Identifier
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
                With .Add("FromDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    '.DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                    '                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                End With
                With .Add("ToDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    '.DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                    '                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
                End With
                .Add("KalaChidemanTartib", , EnumFieldOptions.foHidden)
                .Add("ChidemanSN", , EnumFieldOptions.foHidden)
                .Add("PayeSN", , EnumFieldOptions.foHidden)
                .Add("RezDA", , EnumFieldOptions.foHidden)
                .Add("RezDB", , EnumFieldOptions.foHidden)
                .Add("RezSA", , EnumFieldOptions.foHidden)
                .Add("RezSB", , EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    '.DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    '.DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabChideman
        End With

        DVabChideman.Refresh()

    End Sub

    'Private Sub btnTreeCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTreeCollapseAll.Click
    '  Minoo.Functions.FTFlexFunctions.TreeCollapseAll(DVabChideman.FlexGrid)
    'End Sub

    'Private Sub btnTreeExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTreeExpandAll.Click
    '  Minoo.Functions.FTFlexFunctions.TreeExpandAll(DVabChideman.FlexGrid)
    'End Sub

    'Private Sub DVabKalaChideman_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) Handles DVabKalaChideman.CommandClick
    '  Dim vKalaSN As Decimal
    '  Dim VKalaChidemanSN As Decimal
    '  Dim VFromDate As String
    '  Dim VToDate As String
    '  Dim VChidemanSN As Decimal
    '  Dim VKalaPhizikiSN As Decimal
    '  Dim vState, vResult As Short
    '  Dim vErrMsg As String

    '  If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh _
    '                        Or aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint _
    '                                                            Or aCommand = EnumCommands.cmFilter) Then
    '    aCancel = True
    '    ' کنترل هاي لازم 
    '    With DVabKalaChideman
    '      VKalaChidemanSN = Val(.Fields("KalaChidemanSN").Value)
    '      vKalaSN = Val(.Fields("KalaSN").Value)
    '      VKalaPhizikiSN = Val(.Fields("KalaPhizikiSN").Value)
    '      VFromDate = .Fields("FromDate").Value
    '      VToDate = .Fields("ToDate").Value
    '      vState = .State
    '    End With
    '    VChidemanSN = Val(DVabChideman.Fields("ChidemanSN").Value)
    '    ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
    '    ' Yes
    '    vResult = cn.CallSP("_abSPC_abKalaChideman", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, VKalaChidemanSN _
    '          , VFromDate, VToDate, 0, VChidemanSN, vKalaSN _
    '          , VKalaPhizikiSN _
    '          , aCommand, vState, vErrMsg)
    '    If Trim(vErrMsg) <> "" Then
    '      aCancel = True
    '      NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OKOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
    '      Exit Sub
    '    Else
    '      aCancel = False
    '    End If

    '  End If

    'End Sub


    Private Sub tmrResort_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrResort.Tick
        tmrResort.Enabled = False
        Minoo.Functions.FTFlexFunctions.MakeTree(DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level")
    End Sub

    Private Sub DVabChideman_AfterCommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands) _
        Handles DVabChideman.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
            Case EnumCommands.cmEdit
            Case EnumCommands.cmSave
                tmrResort.Enabled = True
            Case EnumCommands.cmAbort
            Case EnumCommands.cmDelete
        End Select
    End Sub

    Private Sub DVabChideman_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabChideman.CommandClick
        Dim BcmAdd As Boolean
        'Dim SmsgError As String
        Select Case aCommand
            Case EnumCommands.cmAdd
                BcmAdd = True
            Case EnumCommands.cmEdit
                BcmAdd = False
            Case EnumCommands.cmSave
                BcmAdd = False
            Case EnumCommands.cmAbort
                BcmAdd = False
            Case EnumCommands.cmDelete
                BcmAdd = False
        End Select
    End Sub

    Private Sub pvfgTree_AfterEdit(ByVal eventSender As System.Object, _
                                    ByVal eventArgs As RowColEventArgs) _
        Handles pvfgTree.AfterEdit
        If eventArgs.row < pvfgTree.FixedRows Then Exit Sub
        If eventArgs.col <> pvfgTree.get_ColIndex("Selected") Then Exit Sub
        SelectSubTree(eventArgs.row, pvfgTree.GetCellCheck(eventArgs.row, pvfgTree.get_ColIndex("Selected")))
    End Sub

    Private Sub pvfgTree_BeforeEdit(ByVal eventSender As System.Object, _
                                     ByVal eventArgs As RowColEventArgs) _
        Handles pvfgTree.BeforeEdit
        If eventArgs.row < pvfgTree.FixedRows Then eventArgs.cancel = True : Exit Sub
        If eventArgs.col <> pvfgTree.get_ColIndex("Selected") Then eventArgs.cancel = True : Exit Sub
    End Sub

    Private Sub SelectSubTree(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = pvfgTree.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = pvfgTree.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            pvfgTree.SetCellCheck(i, pvfgTree.get_ColIndex("Selected"), aSelect)
        Next
    End Sub

    Private Sub cmdDeselectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles cmdDeselectAll.Click
        Dim i As Short
        With pvfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub cmdSelectB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles cmdSelectB.Click
        Dim vStrWhere As String
        _SelectedChidemanSN = _
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(pvfgTree, "ChidemanSN", "Selected")
        If Trim(SelectedChidemanSN) <> "" Then
            vStrWhere = WhereConditionColumn + " IN  " & _
                        " (Select KalaPhizikiSN  " & _
                        " From  abKalaChideman  " & _
                        " Where  ChidemanSN IN (Select cast(col1 as Decimal(18,3)) from StrToTable( ' " + _
                        SelectedChidemanSN + " ' )))"
            _WhereCondition = vStrWhere
        Else
            _WhereCondition = ""
        End If
        Me.Hide()
    End Sub

    Private Sub cmdSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles cmdSelectAll.Click
        Dim i As Short
        With pvfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub btnExit_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub FrmFilterKalaChideman_Closing (ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub DVabKalaChideman_BindDBComponent (ByRef aComponent As Object) Handles DVabKalaChideman.BindDBComponent
        ' براي آنکه در ديتا کامبو از ستون هاي غير استاندارد ابزار ميخواهيم استفاده کنيم
        Dim vSql As String
        With dbcKalaPhizikiSN
            If aComponent Is DVabKalaChideman.Fields ("KalaPhizikiSN").Component Then
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT Top 100 Percent KalaPhizikiSN " & _
                       " , CONVERT(varchar(20),paKala.KalaNo) + ' - ' + paKala.KalaDS + ' - ' " & _
                       " + abKalaPhiziki.ShomarehRahgiri AS ShomarehRahgiri " & _
                       "  From abKalaPhiziki " & _
                       "  INNER JOIN paKala ON  abKalaPhiziki.KalaSN =  paKala.KalaSN " & _
                       " Where  abKalaPhiziki.VahedeTejariSN =  " + CStr (gVahedeTejariSN) & _
                       " AND abKalaPhiziki.AnbarSN =  " + CStr (gAnbarSN) & _
                       " AND abKalaPhiziki.NoeAnbarSN =  " + CStr (gNoeAnbarSN)

                .LateBinding = True
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                .Bind (cn, vSql, "KalaPhizikiSN", "ShomarehRahgiri")
                ' سلکت مورد نظر لحاظ ميگردد و رويه پيش فرض ابزار غير فعال ميگردد 
                DVabKalaChideman.IgnoreDefaultAction()
            End If
        End With


    End Sub

    'Private Sub DVabChideman_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) Handles DVabChideman.FillDetailsWithData
    '  If aFetched Then
    '    ' فقط اگر مجاز به تعريف کالا در اين جايگاه است ميتوان در آن کالا قرار داد
    '    If Val(DVabChideman.Fields("IsKalaIn").Value) <> 1 Then
    '      DVabKalaChideman.AccessRight = EnumAccessRight.arView
    '    Else
    '      DVabKalaChideman.AccessRight = gSM.TableAccessRight("abKalaChideman")
    '    End If
    '  End If

    'End Sub
End Class
