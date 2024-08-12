' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/07
'ModifiedDate::
'Description:: تعريف جايگاه هاي نگهداري کالا در  انبار
'System ::انبار


Option Strict Off
Option Explicit On


Friend Class FrmabChideman
    Inherits Minoo.Base.FTBaseForm

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
    Public WithEvents tmrResort As System.Windows.Forms.Timer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents picGridMaster As System.Windows.Forms.Panel
    Public WithEvents picCommandMaster As System.Windows.Forms.Panel
    Public WithEvents picNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmdTreeCollapseAll As System.Windows.Forms.Button
    Public WithEvents cmdTreeExpandAll As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.tmrResort = New System.Windows.Forms.Timer (Me.components)
        Me.picGridMaster = New System.Windows.Forms.Panel
        Me.picCommandMaster = New System.Windows.Forms.Panel
        Me.picNavigationMaster = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdTreeCollapseAll = New System.Windows.Forms.Button
        Me.cmdTreeExpandAll = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tmrResort
        '
        Me.tmrResort.Interval = 1
        '
        'picGridMaster
        '
        Me.picGridMaster.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.picGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.picGridMaster.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.picGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picGridMaster.Location = New System.Drawing.Point (3, 42)
        Me.picGridMaster.Name = "picGridMaster"
        Me.picGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picGridMaster.Size = New System.Drawing.Size (891, 402)
        Me.picGridMaster.TabIndex = 33
        '
        'picCommandMaster
        '
        Me.picCommandMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.picCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.picCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCommandMaster.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.picCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picCommandMaster.Location = New System.Drawing.Point (423, 447)
        Me.picCommandMaster.Name = "picCommandMaster"
        Me.picCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picCommandMaster.Size = New System.Drawing.Size (471, 33)
        Me.picCommandMaster.TabIndex = 32
        '
        'picNavigationMaster
        '
        Me.picNavigationMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.picNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.picNavigationMaster.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.picNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picNavigationMaster.Location = New System.Drawing.Point (0, 447)
        Me.picNavigationMaster.Name = "picNavigationMaster"
        Me.picNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picNavigationMaster.Size = New System.Drawing.Size (234, 33)
        Me.picNavigationMaster.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point (3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size (891, 33)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "جايگاه هاي نگهداري کالا"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdTreeCollapseAll
        '
        Me.cmdTreeCollapseAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.cmdTreeCollapseAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTreeCollapseAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTreeCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdTreeCollapseAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.cmdTreeCollapseAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTreeCollapseAll.Location = New System.Drawing.Point (331, 450)
        Me.cmdTreeCollapseAll.Name = "cmdTreeCollapseAll"
        Me.cmdTreeCollapseAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdTreeCollapseAll.Size = New System.Drawing.Size (90, 29)
        Me.cmdTreeCollapseAll.TabIndex = 36
        Me.cmdTreeCollapseAll.Text = "بستن همه"
        '
        'cmdTreeExpandAll
        '
        Me.cmdTreeExpandAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.cmdTreeExpandAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTreeExpandAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTreeExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdTreeExpandAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.cmdTreeExpandAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTreeExpandAll.Location = New System.Drawing.Point (238, 450)
        Me.cmdTreeExpandAll.Name = "cmdTreeExpandAll"
        Me.cmdTreeExpandAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdTreeExpandAll.Size = New System.Drawing.Size (90, 29)
        Me.cmdTreeExpandAll.TabIndex = 35
        Me.cmdTreeExpandAll.Text = "بازکردن همه"
        '
        'FrmabChideman
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (895, 481)
        Me.Controls.Add (Me.cmdTreeCollapseAll)
        Me.Controls.Add (Me.cmdTreeExpandAll)
        Me.Controls.Add (Me.picGridMaster)
        Me.Controls.Add (Me.picCommandMaster)
        Me.Controls.Add (Me.picNavigationMaster)
        Me.Controls.Add (Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Location = New System.Drawing.Point (4, 30)
        Me.Name = "FrmabChideman"
        Me.Text = "تعريف جايگاه هاي نگهداري کالا"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabChideman
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabChideman
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabChideman
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmabChideman)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  جايگاه هاي نگهداري کالا در انبار تعريف شده است
    Private WithEvents DVabChideman As CDataView
    Private WithEvents CmbPedarChideman As NetSql.Components.DataCombo


    Private Sub DVabChideman_AfterCommandClick (ByVal aCommand As EnumCommands) Handles DVabChideman.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                If DVabChideman.FlexGrid.Col <> DVabChideman.FlexGrid.ColIndex ("NoeChidemanSN") Then
                    DVabChideman.FlexGrid.Col = DVabChideman.FlexGrid.ColIndex ("NoeChidemanSN") + 1
                    Application.DoEvents()
                End If
            Case EnumCommands.cmEdit
            Case EnumCommands.cmSave
                tmrResort.Enabled = True
            Case EnumCommands.cmAbort
            Case EnumCommands.cmDelete
        End Select
    End Sub


    Private Sub DVabChideman_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabChideman.CommandClick
        Dim vBcmAdd As Boolean
        Dim vSmsgError As String

        Select Case aCommand
            Case EnumCommands.cmAdd
                DVabChideman.Fields ("PedarChidemanSN").RefreshCombo()
                vBcmAdd = True
                DVabChideman.FlexGrid.Col = DVabChideman.FlexGrid.ColIndex ("ChidemanNO")
            Case EnumCommands.cmEdit
                DVabChideman.Fields ("PedarChidemanSN").RefreshCombo()
                vBcmAdd = False
            Case EnumCommands.cmSave
                ' کنترل هاي لازم براي ثبت هر کدام از لايه هاي چيدمان براي مثال کنترل پدر فرزندي هر کدام از لايه ها 
                vSmsgError = CStr (Val (DVabChideman.Fields ("NoeChidemanSN").Value))
                ' Yes
                cn.CallSP ("_abSpcUpdatePedarChidemanSN", DVabChideman.Fields ("ChidemanSN").Value _
                           , Val (DVabChideman.Fields ("PedarChidemanSN").Value), vSmsgError)
                If Trim (vSmsgError) <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox(vSmsgError)
                End If
                ' مقدار فيلد به صورت منحصربفرد تهيه شده و در فيلد مربوطه ذخيره ميگردد
                DVabChideman.Fields ("UnqStr").Value = _
                    Minoo.Functions.FTDBCommonFunctions.UnqStr (cn, (DVabChideman.Fields ("ChidemanDs").Value))
                vBcmAdd = False
            Case EnumCommands.cmAbort
                vBcmAdd = False
            Case EnumCommands.cmDelete
                vBcmAdd = False
        End Select

    End Sub


    Private Sub DVabChideman_GetGridProperties() Handles DVabChideman.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree(DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level",)
    End Sub


    Private Sub FrmabChideman_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load



        Call InitDataView()
    End Sub


    Private Sub FrmabChideman_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabChideman.Done()
        DVabChideman = Nothing
    End Sub

    Private Sub tmrResort_Tick (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles tmrResort.Tick
        tmrResort.Enabled = False
        Minoo.Functions.FTFlexFunctions.MakeTree (DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level", True)
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabChideman = New CDataView (cn)
        With DVabChideman
            .Init (picGridMaster, , picCommandMaster, picNavigationMaster, EnumButtonOptions.boCmdModify _
                                                                           Or EnumButtonOptions.boCmdExit Or _
                                                                           EnumButtonOptions.boCmdPrint)
            .TableName = "abChideman"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abVwj_abChideman", "PedarChidemanSN", "ChidemanSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "ChidemanStatus", "GeneralStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatusYN", "IsKalaIn", "GeneralStatusYNSN")
            .EditInGrid = True
            .SQLOrderBy = "Convert(varbinary(8000), dbo.abFn_GetTreeabChidemanSortField(abChideman.ChidemanSN))"
            .NextRowAfterSave = False
            ' اعمال شرط براي نمايش اطلاعات انبار جاري
            .SQLWhere = " abChideman.AnbarSN = " & gAnbarSN.ToString
            .AccessRight = gSM.TableAccessRight (.TableName)
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
                With .Add("NoeChidemanSN->{Replace(cast(abNoeChideman.OlaviatNo as varchar),'.000','')+'.'+abNoeChideman.NoeChidemanDS} As NoeChidemanSN", "DataCombo", EnumFieldOptions.foDefault)
                    .LockUpdate = True
                    .ComboOrderBy = "abNoeChideman.OlaviatNo"
                    .ComboWhereCondition = "abNoeChideman.AnbarSN=" & gAnbarSN.ToString
                    .Caption = "نوع چیدمان"
                End With
                With .Add ("ChidemanNo", "TextBox", EnumFieldOptions.foDefault)
                End With
                With .Add("ChidemanDs", "TextBox", EnumFieldOptions.foDefault)
                End With

                .Add ("MaxVazn", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Hajm", "TextBox", EnumFieldOptions.foDefault)
                .Add ("X", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Y", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Z", "TextBox", EnumFieldOptions.foDefault)
                With .Add ("IsKalaIn->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abChideman.IsKalaIn")
                    .DefaultValue = 1
                End With
                .Add ("Tool", "TextBox", EnumFieldOptions.foHidden)
                .Add ("Arz", "TextBox", EnumFieldOptions.foHidden)
                .Add ("Ertefa", "TextBox", EnumFieldOptions.foHidden)
                With _
                    .Add(
                          "PedarChidemanSN->abVwj_abChideman.{NoeChideman_ChidemanDS} AS PedarChidemanSN ",
                          "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = FTDD.GetCaption("abChideman", "PedarChidemanSN")
                    .ComboWhereCondition = "abVwj_abChideman.AnbarSN=" & gAnbarSN.ToString
                    .ComboOrderBy = "abVwj_abChideman.OlaviatNo"
                    CmbPedarChideman = .Component
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
        DVabChideman.Refresh()
    End Sub

    Private Sub cmdTreeCollapseAll_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles cmdTreeCollapseAll.Click
        Minoo.Functions.FTFlexFunctions.TreeCollapseAll (DVabChideman.FlexGrid)
    End Sub

    Private Sub cmdTreeExpandAll_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles cmdTreeExpandAll.Click
        Minoo.Functions.FTFlexFunctions.TreeExpandAll (DVabChideman.FlexGrid)
    End Sub

    Private Sub CmbPedarChideman_GotFocus(sender As Object, e As EventArgs) Handles CmbPedarChideman.GotFocus
        If IsNumeric(DVabChideman.Fields("NoeChidemanSN").Value) Then
            DVabChideman.Fields("PedarChidemanSN").ComboWhereCondition = "abVwj_abChideman.AnbarSN=" & gAnbarSN.ToString & " And abVwj_abChideman.OlaviatNo < (Select Top 1 OlaviatNo from abNoeChideman where NoeChidemanSN=" & DVabChideman.Fields("NoeChidemanSN").Value.ToString & ")"
            DVabChideman.Fields("PedarChidemanSN").RefreshCombo()
        End If
    End Sub
End Class
