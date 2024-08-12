' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/07
'ModifiedDate::
'Description:: تعريف شرايط محيطي جايگاههاي نگهداري
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmabChidemanSharayet
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
    Public WithEvents btnTreeCollapseAll As System.Windows.Forms.Button
    Public WithEvents btnTreeExpandAll As System.Windows.Forms.Button
    Public WithEvents lblabChidemanSharayet As System.Windows.Forms.Label
    Public WithEvents lblabChideman As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.pnlCommandMaster = New System.Windows.Forms.Panel
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel
        Me.pnlGridMaster = New System.Windows.Forms.Panel
        Me.pnlGridDet1 = New System.Windows.Forms.Panel
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel
        Me.lblabChidemanSharayet = New System.Windows.Forms.Label
        Me.lblabChideman = New System.Windows.Forms.Label
        Me.btnTreeCollapseAll = New System.Windows.Forms.Button
        Me.btnTreeExpandAll = New System.Windows.Forms.Button
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
        Me.pnlCommandMaster.Location = New System.Drawing.Point (484, 316)
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
        Me.pnlCommandDet1.Size = New System.Drawing.Size (420, 33)
        Me.pnlCommandDet1.TabIndex = 5
        '
        'lblabChidemanSharayet
        '
        Me.lblabChidemanSharayet.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.lblabChidemanSharayet.BackColor = System.Drawing.SystemColors.Control
        Me.lblabChidemanSharayet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabChidemanSharayet.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblabChidemanSharayet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabChidemanSharayet.Location = New System.Drawing.Point (- 32, 363)
        Me.lblabChidemanSharayet.Name = "lblabChidemanSharayet"
        Me.lblabChidemanSharayet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabChidemanSharayet.Size = New System.Drawing.Size (891, 17)
        Me.lblabChidemanSharayet.TabIndex = 10
        Me.lblabChidemanSharayet.Text = "شرايط محيطي"
        Me.lblabChidemanSharayet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnTreeCollapseAll
        '
        Me.btnTreeCollapseAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnTreeCollapseAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnTreeCollapseAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTreeCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTreeCollapseAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnTreeCollapseAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTreeCollapseAll.Location = New System.Drawing.Point (385, 320)
        Me.btnTreeCollapseAll.Name = "btnTreeCollapseAll"
        Me.btnTreeCollapseAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTreeCollapseAll.Size = New System.Drawing.Size (90, 29)
        Me.btnTreeCollapseAll.TabIndex = 38
        Me.btnTreeCollapseAll.Text = "بستن همه"
        '
        'btnTreeExpandAll
        '
        Me.btnTreeExpandAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnTreeExpandAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnTreeExpandAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTreeExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTreeExpandAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnTreeExpandAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTreeExpandAll.Location = New System.Drawing.Point (289, 320)
        Me.btnTreeExpandAll.Name = "btnTreeExpandAll"
        Me.btnTreeExpandAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTreeExpandAll.Size = New System.Drawing.Size (90, 29)
        Me.btnTreeExpandAll.TabIndex = 37
        Me.btnTreeExpandAll.Text = "بازکردن همه"
        '
        'FrmabChidemanSharayet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (826, 549)
        Me.Controls.Add (Me.btnTreeCollapseAll)
        Me.Controls.Add (Me.btnTreeExpandAll)
        Me.Controls.Add (Me.lblabChideman)
        Me.Controls.Add (Me.pnlCommandMaster)
        Me.Controls.Add (Me.pnlNavigationMaster)
        Me.Controls.Add (Me.pnlGridMaster)
        Me.Controls.Add (Me.pnlGridDet1)
        Me.Controls.Add (Me.pnlNavigationDet1)
        Me.Controls.Add (Me.pnlCommandDet1)
        Me.Controls.Add (Me.lblabChidemanSharayet)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (11, 65)
        Me.Name = "FrmabChidemanSharayet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعريف شرايط محيطي جايگاه هاي نگهداري"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabChidemanSharayet
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabChidemanSharayet
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabChidemanSharayet
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmabChidemanSharayet)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  چيدمان انبار تعريف شده است
    Private WithEvents DVabChideman As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش شرايط محيطي جايگاههاي نگهداري تعريف شده است
    Private WithEvents DVabChidemanSharayet As CDataView

    Private Sub DVabChideman_GetGridProperties() Handles DVabChideman.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree (DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level")
    End Sub

    Private Sub FrmabChidemanSharayet_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        lblabChideman.Text = FTDD.GetCaption ("abChideman")
        lblabChidemanSharayet.Text = FTDD.GetCaption ("abChidemanSharayet")
    End Sub

    Private Sub FrmabChideman_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabChideman.Done()
        DVabChideman = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabChideman = New CDataView (cn)
        With DVabChideman
            .Init (pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdExit _
                                                                           Or EnumButtonOptions.boCmdPrint)
            .TableName = "abChideman"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abVwj_abChideman", "PedarChidemanSN", "ChidemanSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "ChidemanStatus", "GeneralStatusSN")
            .EditInGrid = True
            .SQLOrderBy = "SortField"
            .NextRowAfterSave = False
            ' اعمال شرط براي نمايش اطلاعات انبار جاري
            .SQLWhere = " abChideman.AnbarSN = " & gAnbarSN.ToString
            .AccessRight = EnumAccessRight.arView
            .Text = FTDD.GetCaption (.TableName)
            With .Fields
                With .Add ("ChidemanSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add ("VahedeTejariSN", "DataCombo <DISABLED>", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
                End With
                With .Add ("AnbarSN", "DataCombo <DISABLED>", EnumFieldOptions.foDefault)
                    .DefaultValue = gAnbarSN
                    .ComboLateBinding = True
                End With
                With .Add ("NoeAnbarSN", "DataCombo <DISABLED>", EnumFieldOptions.foDefault)
                    .DefaultValue = gNoeAnbarSN
                    .ComboLateBinding = True
                End With
                With .Add ("NoeChidemanSN", "DataCombo", EnumFieldOptions.foDefault)
                    .LockUpdate = True
                End With
                With .Add ("ChidemanNo", "TextBox", EnumFieldOptions.foDefault)
                End With
                With .Add ("ChidemanDs", "TextBox", EnumFieldOptions.foDefault)
                End With
                .Add ("MaxVazn", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Hajm", "TextBox", EnumFieldOptions.foDefault)
                .Add ("X", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Y", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Z", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Tool", "TextBox", EnumFieldOptions.foHidden)
                .Add ("Arz", "TextBox", EnumFieldOptions.foHidden)
                .Add ("Ertefa", "TextBox", EnumFieldOptions.foHidden)
                With _
                    .Add ( _
                          "PedarChidemanSN->abVwj_abChideman.{abVwj_abChideman.ChidemanNo + ' - ' + abVwj_abChideman.NoeChideman_ChidemanDS} AS PedarChidemanSN ", _
                          "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = FTDD.GetCaption ("abChideman", "PedarChidemanSN")
                End With
                With .Add ("ChidemanStatus->paGeneralStatus.GeneralStatusDs", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = 1
                End With
                .Add ("Tozih", "TextBox", EnumFieldOptions.foDefault)
                .Add ("RezDA", , EnumFieldOptions.foHidden)
                .Add ("RezDB", , EnumFieldOptions.foHidden)
                .Add ("RezSA", , EnumFieldOptions.foHidden)
                .Add ("RezSB", , EnumFieldOptions.foHidden)
                .Add ("{dbo.abFn_GetTreeabChidemanNodeLevel(abChideman.ChidemanSN)} as Level", , _
                      EnumFieldOptions.foHidden)
                .Add ("{dbo.abFn_GetTreeabChidemanSortField(abChideman.ChidemanSN)} as SortField", , _
                      EnumFieldOptions.foHidden)
                .Add ("PayeSN", "TextBox", EnumFieldOptions.foHidden)
                .Add ("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add ("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add ("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        DVabChidemanSharayet = New CDataView (cn)
        With DVabChidemanSharayet
            .Init (pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdPrint)
            .TableName = "abChidemanSharayet"
            .SQLOrderBy = " abChidemanSharayet.FromDate "
            .EditInGrid = True
            .AccessRight = gSM.TableAccessRight (.TableName)
            .Text = FTDD.GetCaption (.TableName)
            With .Fields
                With .Add ("ChidemanSharayetSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("SharayeteMohitiSN", "DataCombo", EnumFieldOptions.foDefault)
                With .Add ("FromDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add ("ToDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                .Add ("ChidemanSN", , EnumFieldOptions.foHidden)
                .Add ("RezDA", , EnumFieldOptions.foHidden)
                .Add ("RezDB", , EnumFieldOptions.foHidden)
                .Add ("RezSA", , EnumFieldOptions.foHidden)
                .Add ("RezSB", , EnumFieldOptions.foHidden)
                With .Add ("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add ("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabChideman
        End With

        DVabChideman.Refresh()

    End Sub

    Private Sub btnTreeCollapseAll_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTreeCollapseAll.Click
        Minoo.Functions.FTFlexFunctions.TreeCollapseAll (DVabChideman.FlexGrid)
    End Sub

    Private Sub btnTreeExpandAll_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTreeExpandAll.Click
        Minoo.Functions.FTFlexFunctions.TreeExpandAll (DVabChideman.FlexGrid)
    End Sub


    Private Sub DVabChidemanSharayet_CommandClick (ByVal aCommand As NetSql.View.CEnum.EnumCommands, _
                                                   ByRef aCancel As Boolean) Handles DVabChidemanSharayet.CommandClick
        Dim VFromDate As String
        Dim VToDate As String
        Dim VChidemanSN, VChidemanSharayetSN As Decimal
        Dim vState, vResult As Short
        Dim vErrMsg As String

        Select Case aCommand
            Case EnumCommands.cmSave
                ' کنترل هاي لازم 
                With DVabChidemanSharayet
                    VFromDate = .Fields ("FromDate").Value
                    VToDate = .Fields ("ToDate").Value
                    VChidemanSN = DVabChideman.Fields ("ChidemanSN").Value
                    VChidemanSharayetSN = .Fields ("ChidemanSharayetSN").Value
                    vState = .State
                End With
                ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
                ' Yes
                vResult = cn.CallSP ("_abSPC_abChidemanSharayet", VChidemanSharayetSN, VChidemanSN _
                                     , VFromDate, VToDate _
                                     , aCommand, vState, vErrMsg)
                If Trim (vErrMsg) <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, _
                               Me.Text)
                    Exit Sub
                End If

        End Select

    End Sub
End Class
