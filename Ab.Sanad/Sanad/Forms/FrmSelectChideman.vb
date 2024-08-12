' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/07
'ModifiedDate::
'Description:: تخصيص کالافيزيکي به جايگاههاي نگهداري
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Friend Class FrmSelectChideman
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents lblabChideman As System.Windows.Forms.Label
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents btnTreeCollapseAll As System.Windows.Forms.Button
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents btnTreeExpandAll As System.Windows.Forms.Button
    Public ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblabChideman = New System.Windows.Forms.Label()
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.btnTreeCollapseAll = New System.Windows.Forms.Button()
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.btnTreeExpandAll = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lblabChideman)
        Me.Panel1.Controls.Add(Me.pnlGridMaster)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add(Me.btnTreeCollapseAll)
        Me.Panel1.Controls.Add(Me.pnlCommandMaster)
        Me.Panel1.Controls.Add(Me.btnTreeExpandAll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 456)
        Me.Panel1.TabIndex = 1
        '
        'lblabChideman
        '
        Me.lblabChideman.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblabChideman.BackColor = System.Drawing.SystemColors.Control
        Me.lblabChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabChideman.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblabChideman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabChideman.Location = New System.Drawing.Point(226, 7)
        Me.lblabChideman.Name = "lblabChideman"
        Me.lblabChideman.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabChideman.Size = New System.Drawing.Size(686, 25)
        Me.lblabChideman.TabIndex = 35
        Me.lblabChideman.Text = "چيدمان انبار"
        Me.lblabChideman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(6, 38)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(910, 343)
        Me.pnlGridMaster.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(448, 417)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(165, 30)
        Me.btnSelect.TabIndex = 39
        Me.btnSelect.Text = "انتخاب"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(5, 416)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(388, 33)
        Me.pnlNavigationMaster.TabIndex = 8
        '
        'btnTreeCollapseAll
        '
        Me.btnTreeCollapseAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnTreeCollapseAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTreeCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTreeCollapseAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeCollapseAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTreeCollapseAll.Location = New System.Drawing.Point(118, 5)
        Me.btnTreeCollapseAll.Name = "btnTreeCollapseAll"
        Me.btnTreeCollapseAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTreeCollapseAll.Size = New System.Drawing.Size(90, 30)
        Me.btnTreeCollapseAll.TabIndex = 38
        Me.btnTreeCollapseAll.Text = "بستن همه"
        Me.btnTreeCollapseAll.UseVisualStyleBackColor = False
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(669, 416)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(247, 33)
        Me.pnlCommandMaster.TabIndex = 9
        Me.pnlCommandMaster.Tag = ""
        '
        'btnTreeExpandAll
        '
        Me.btnTreeExpandAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnTreeExpandAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTreeExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTreeExpandAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeExpandAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTreeExpandAll.Location = New System.Drawing.Point(5, 5)
        Me.btnTreeExpandAll.Name = "btnTreeExpandAll"
        Me.btnTreeExpandAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTreeExpandAll.Size = New System.Drawing.Size(90, 30)
        Me.btnTreeExpandAll.TabIndex = 37
        Me.btnTreeExpandAll.Text = "بازکردن همه"
        Me.btnTreeExpandAll.UseVisualStyleBackColor = False
        '
        'FrmSelectChideman
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(923, 456)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "FrmSelectChideman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تخصيص رهگیری ها به جايگاههاي نگهداري"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmSelectChideman
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSelectChideman
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSelectChideman
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmSelectChideman)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    Private mChidemanSN As Decimal, mChidemanDS As String

#End Region

#Region "PropertyDefinition"

    Public Property ChidemanSN() As Decimal
        Get
            ChidemanSN = mChidemanSN
        End Get
        Set(ByVal Value As Decimal)
            mChidemanSN = Value
        End Set
    End Property

    Public Property ChidemanDS() As String
        Get
            ChidemanDS = mChidemanDS
        End Get
        Set(ByVal Value As String)
            mChidemanDS = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  چيدمان انبار تعريف شده است
    Private WithEvents DVabChideman As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش تخصيص کالا فيزيکي به جايگاههاي نگهداري تعريف شده است
    Private WithEvents DVabSanadHaChideman As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dbcKalaPhizikiSN As New NetSql.Components.DataCombo
    Public IsChiemanOutput As Boolean = False
    Public KalaPhizikiSN As Decimal = 0
    Public KalaPhizikiDS As String = ""



    Private Sub DVabChideman_GetGridProperties() Handles DVabChideman.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree(DVabChideman.FlexGrid, True _
                                                  , "ChidemanDs", "ChidemanSN", "SortField", "level")
    End Sub

    Private Sub FrmabKalaChideman_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        'lblabChideman.Text = FTDD.GetCaption("abChideman")
        lblabChideman.Text = "تخصیص چیدمان به کالا رهگیری" + " - " + KalaPhizikiDS
        btnTreeCollapseAll.Visible = False
        btnTreeExpandAll.Visible = False
    End Sub

    Private Sub FrmabChideman_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabChideman.Done()
        DVabChideman = Nothing
        dbcKalaPhizikiSN.Dispose()
        dbcKalaPhizikiSN = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim Param(1) As String

        Param(0) = "KalaPhizikiSN"
        Param(1) = "KalaPhizikiSN"

        DVabChideman = New CDataView(cn)
        With DVabChideman
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdExit _
                                                                           Or EnumButtonOptions.boCmdPrint)
            .TableName = "abChideman"

            .EditInGrid = True
            .NextRowAfterSave = False
            ' اعمال شرط براي نمايش اطلاعات انبار جاري
            .SQLWhere = " abChideman.AnbarSN = " & gAnbarSN.ToString
            If IsChiemanOutput Then
                .SQLWhere += " And abChideman.ChidemanSN In (SELECT [ChidemanSN] FROM [abVw_MojoudiChidemanKalaPhiziki]		where KalaPhizikiSN=" & KalaPhizikiSN.ToString & " and Mojoudi>0)"
            End If
            .AccessRight = EnumAccessRight.arView
            .Text = FTDD.GetCaption(.TableName)


            '.AutoFetchCurrentRow = True

            With .Fields
                With .Add("ChidemanSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("VahedeTejariSN", "DataCombo <DISABLED>", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
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

                With .Add("ChidemanDs", "TextBox", If(IsChiemanOutput, EnumFieldOptions.foHidden, EnumFieldOptions.foDefault))

                End With

                With .Add("{dbo.abFn_GetChidemanDS(abChideman.ChidemanSN)} as ChidemanDSString", , EnumFieldOptions.foDefault)
                    .Caption = "محل جایگاه"
                End With

                With .Add("{dbo.[abFn_GetMojoudiKalaPhizikiInChideman](abChideman.ChidemanSN," & KalaPhizikiSN.ToString & ")} as Mojoudi", , EnumFieldOptions.foDefault)
                    .ReadOnly = True
                    .Caption = "موجودی کالا فیزیکی در جایگاه"
                End With

                .Add("{dbo.abFn_GetTreeabChidemanNodeLevel(abChideman.ChidemanSN)} as Level", ,
                      EnumFieldOptions.foHidden)
                .Add("{dbo.abFn_GetTreeabChidemanSortField(abChideman.ChidemanSN)} as SortField", ,
                      EnumFieldOptions.foHidden)

                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        'DVabSanadHaChideman = New CDataView(cn)
        'With DVabSanadHaChideman
        '    .Init(pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdModify _
        '                                                             Or EnumButtonOptions.boCmdPrint)
        '    .TableName = "abSanadHaChideman"
        '    '.AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_abKalaPhiziki_Full", "KalaPhizikiSN", "KalaPhizikiSN")
        '    .EditInGrid = True
        '    .AccessRight = gSM.TableAccessRight(.TableName)
        '    .Text = FTDD.GetCaption(.TableName)
        '    With .Fields
        '        With .Add("SanadHaChidemanSN", , gSNFieldOption)
        '            .DefaultValue = gSM.Identifier
        '        End With
        '        .Add("ChidemanSN", , EnumFieldOptions.foHidden)
        '        .Add("SanadHaSN", , EnumFieldOptions.foHidden)
        '        With .Add("{Convert(BIGINT, Meghdar)} As Meghdar", "TextBox", EnumFieldOptions.foDefault)
        '            .Caption = "مقدار"
        '            .DataType = "INT"
        '            .Format = "#.#"
        '        End With
        '        With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
        '            .DefaultValue = gSM.UserID_Name
        '        End With
        '        With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
        '            .DefaultValue = System.Environment.MachineName
        '        End With
        '        .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
        '    End With
        '    .Parent = DVabChideman
        'End With

        DVabChideman.Refresh()

    End Sub

    'Private Sub btnTreeCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Minoo.Functions.FTFlexFunctions.TreeCollapseAll(DVabChideman.FlexGrid)
    'End Sub

    'Private Sub btnTreeExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Minoo.Functions.FTFlexFunctions.TreeExpandAll(DVabChideman.FlexGrid)
    'End Sub

    Private Sub DVabSanadHaChideman_BindDBComponent(ByRef aComponent As Object) Handles DVabSanadHaChideman.BindDBComponent
        ' براي آنکه در ديتا کامبو از ستون هاي غير استاندارد ابزار ميخواهيم استفاده کنيم
        Dim vSql As String
        With dbcKalaPhizikiSN
            If aComponent Is DVabSanadHaChideman.Fields("KalaPhizikiSN").Component Then
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT Top 100 Percent KalaPhizikiSN " & _
                       " , CONVERT(varchar(20),paKala.KalaNo) + ' - ' + paKala.KalaDS + ' - ' " & _
                       " + abKalaPhiziki.ShomarehRahgiri AS ShomarehRahgiri " & _
                       "  From abKalaPhiziki " & _
                       "  INNER JOIN paKala ON  abKalaPhiziki.KalaSN =  paKala.KalaSN " & _
                       " Where  abKalaPhiziki.VahedeTejariSN =  " + CStr(gVahedeTejariSN) & _
                       " AND  abKalaPhiziki.KalaPhizikiSN IN ( SELECT abSanadHa.KalaPhizikiSN " & _
                       " FROM  abSanad INNER JOIN abSanadHa ON abSanad.SanadSN = abSanadHa.SanadSN Where (LEFT(abSanad.SanadDate,2) >= " & _
                       VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                            cn, _
                                                                                            Functions. _
                                                                                               FTDBCommonFunctions. _
                                                                                               enmDateFormat.Normal), 2) & _
                       ") AND ( abSanad.AnbarSN = " & CStr(gAnbarSN) & " ) " & _
                       " AND ( abSanad.VahedeTejariSN = " & CStr(gVahedeTejariSN) & " ) " & _
                       "  AND ( abSanad.SanadStatus >= 4 )   ) "

                '" AND abKalaPhiziki.AnbarSN =  " + CStr(gAnbarSN) & _
                '" AND abKalaPhiziki.NoeAnbarSN =  " + CStr(gNoeAnbarSN)

                .LateBinding = True
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                .Bind(cn, vSql, "KalaPhizikiSN", "ShomarehRahgiri")
                ' سلکت مورد نظر لحاظ ميگردد و رويه پيش فرض ابزار غير فعال ميگردد 
                DVabSanadHaChideman.IgnoreDefaultAction()
            End If
        End With


    End Sub

    Private Sub DVabSanadHaChideman_CommandClick(ByVal aCommand As NetSql.View.CEnum.EnumCommands, _
                                               ByRef aCancel As Boolean) Handles DVabSanadHaChideman.CommandClick
        Dim vKalaSN As Decimal
        Dim VKalaChidemanSN As Decimal
        Dim VFromDate As String
        Dim VToDate As String
        Dim VChidemanSN As Decimal
        Dim VKalaPhizikiSN As Decimal
        Dim vState, vResult As Short
        Dim vErrMsg As String

        If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh _
                Or aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint _
                Or aCommand = EnumCommands.cmFilter) Then
            aCancel = True
            ' کنترل هاي لازم 
            With DVabSanadHaChideman
                VKalaChidemanSN = Val(.Fields("KalaChidemanSN").Value)
                vKalaSN = Val(.Fields("KalaSN").Value)
                VKalaPhizikiSN = Val(.Fields("KalaPhizikiSN").Value)
                VFromDate = .Fields("FromDate").Value
                VToDate = .Fields("ToDate").Value
                vState = .State
            End With
            VChidemanSN = Val(DVabChideman.Fields("ChidemanSN").Value)
            ' کنترل اطلاعات قبل از آنکه روي رکورد بانک تاثير بگذارد
            ' Yes
            vResult = cn.CallSP("_abSPC_abKalaChideman", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, VKalaChidemanSN _
                                 , VFromDate, VToDate, 0, VChidemanSN, vKalaSN _
                                 , VKalaPhizikiSN _
                                 , aCommand, vState, vErrMsg)
            If Trim(vErrMsg) <> "" Then
                aCancel = True
                NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            Else
                aCancel = False
            End If

        End If

    End Sub

    'Private Sub DVabChideman_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
    '    Handles DVabChideman.FillDetailsWithData
    '    If aFetched Then
    '        ' فقط اگر مجاز به تعريف کالا در اين جايگاه است ميتوان در آن کالا قرار داد
    '        If Val(DVabChideman.Fields("IsKalaIn").Value) <> 1 Then
    '            DVabSanadHaChideman.AccessRight = EnumAccessRight.arView
    '        Else
    '            'DVabSanadHaChideman.AccessRight = gSM.TableAccessRight("abSanadHaChideman")
    '            DVabSanadHaChideman.AccessRight = EnumAccessRight.arAll
    '        End If
    '    End If

    'End Sub

    Private Sub btnTekrari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim VChidemanTekrari As New Minoo.Applications.Anbar.Chideman.FrmChidemanTekrari
        'VChidemanTekrari.ShowDialog(Me)

    End Sub

    Private Sub btnCopyChidman_Click(sender As System.Object, e As System.EventArgs)
        'Dim VChidemanCopy As New Minoo.Applications.Anbar.Chideman.FrmCopyChideman
        'VChidemanCopy.ShowDialog(Me)
        If CSystem.MsgBox("آيا چیدمان رهگیری های قبلی کالا به رهگیری هایی که چیدمان ندارند منتقل گردد ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.No Then
            Exit Sub
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim _today As String = MiladiToShamsi(Today()).Substring(0, 2) + "0101"
        Try
            Dim i, j As Integer
            'Dim dv As DataView = cn.ExecuteQuery("Select abKalaPhiziki.* from abkalaphiziki LEFT JOIN abkalachideman" & _
            '" ON abKalaPhiziki.KalaPhizikiSN = abkalachideman.KalaPhizikiSN Where ChidemanSN is null And abKalaPhiziki.Moaserdate>='" & _today & "'")

            Dim dv As DataView = cn.ExecuteQuery("Select abKalaPhiziki.* from abkalaphiziki " & _
            " LEFT JOIN abkalachideman ON abKalaPhiziki.KalaPhizikiSN = abkalachideman.KalaPhizikiSN " & _
            " inner join abanbarkala on abkalaphiziki.kalaSN=abanbarkala.kalaSn " & _
            " Where ChidemanSN is null And abKalaPhiziki.Moaserdate>='" & _today & "' And abanbarkala.AnbarSN =" & gAnbarSN)

            If dv.Count <> 0 Then
                For i = 0 To dv.Count - 1
                    Dim _KalaSN As Decimal = dv(i)("KalaSN")
                    Dim dv2 As DataView = cn.ExecuteQuery("Select  Top (1) abKalaPhiziki.kalasn KalaSN2,abkalachideman.* from abkalaphiziki" & _
                    " LEFT JOIN abkalachideman  ON abKalaPhiziki.KalaPhizikiSN = abkalachideman.KalaPhizikiSN " & _
                    " Where ChidemanSN is not null And abKalaPhiziki.kalasn= " & _KalaSN & " Order by kalachidemanSN desc ")
                    If dv2.Count <> 0 Then
                        'For j = 0 To dv2.Count - 1
                        j = 0
                        cn.CallSP("abKalaChideman_Insert",
                                      gSM.Identifier,
                                       _today,
                                      dv2(j)("ToDate"),
                                      dv2(j)("KalaChidemanTartib"),
                                      dv2(j)("ChidemanSN"),
                                      _KalaSN,
                                      dv(i)("KalaPhizikiSN"),
                                      dv2(j)("PayeSN"),
                                      dv2(j)("RezDA"),
                                      dv2(j)("RezDB"),
                                      dv2(j)("RezSA"),
                                      dv2(j)("RezSB"),
                                      gSM.UserID_Name,
                                      System.Environment.MachineName,
                                      System.DBNull.Value)
                        'Next

                    End If
                Next
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Dim _ChidemanSN As Decimal
        _ChidemanSN = Val(DVabChideman.Fields("ChidemanSN").Value)
        ChidemanSN = _ChidemanSN
        Dim dv As DataView = cn.ExecuteQuery("Select dbo.abFn_GetTreeabChidemanSortField(" & _ChidemanSN & ")")
        If Not dv Is Nothing Then
            ChidemanDS = dv(0)(0)
        End If
        Close()

    End Sub

    Private Sub btnTreeCollapseAll_Click_1(sender As System.Object, e As System.EventArgs) Handles btnTreeCollapseAll.Click
        Minoo.Functions.FTFlexFunctions.TreeCollapseAll(DVabChideman.FlexGrid)
    End Sub

    Private Sub btnTreeExpandAll_Click_1(sender As System.Object, e As System.EventArgs) Handles btnTreeExpandAll.Click
        Minoo.Functions.FTFlexFunctions.TreeExpandAll(DVabChideman.FlexGrid)
    End Sub
End Class
