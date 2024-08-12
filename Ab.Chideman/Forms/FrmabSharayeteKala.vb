' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/09
'ModifiedDate::
'Description:: محدوديت هاي نگهداشت کالا در جايگاه ها   تعريف نبايدهاي شرايط نگهداري کالا
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmabSharayeteKala
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
    Public WithEvents lblabSharayeteKala As System.Windows.Forms.Label
    Public WithEvents btnSelectGoroohSN As System.Windows.Forms.Button
    Public WithEvents lblabSharayeteMohiti As System.Windows.Forms.Label

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
        Me.lblabSharayeteKala = New System.Windows.Forms.Label
        Me.lblabSharayeteMohiti = New System.Windows.Forms.Label
        Me.btnSelectGoroohSN = New System.Windows.Forms.Button
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
        Me.pnlCommandMaster.Location = New System.Drawing.Point (375, 243)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size (447, 33)
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
        Me.pnlNavigationMaster.Location = New System.Drawing.Point (1, 243)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size (371, 33)
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
        Me.pnlGridMaster.Size = New System.Drawing.Size (822, 213)
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
        Me.pnlGridDet1.Location = New System.Drawing.Point (1, 299)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size (822, 207)
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
        Me.pnlNavigationDet1.Size = New System.Drawing.Size (266, 33)
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
        Me.pnlCommandDet1.Location = New System.Drawing.Point (432, 508)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size (390, 33)
        Me.pnlCommandDet1.TabIndex = 5
        '
        'lblabSharayeteKala
        '
        Me.lblabSharayeteKala.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.lblabSharayeteKala.BackColor = System.Drawing.SystemColors.Control
        Me.lblabSharayeteKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabSharayeteKala.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblabSharayeteKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabSharayeteKala.Location = New System.Drawing.Point (- 32, 279)
        Me.lblabSharayeteKala.Name = "lblabSharayeteKala"
        Me.lblabSharayeteKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabSharayeteKala.Size = New System.Drawing.Size (891, 17)
        Me.lblabSharayeteKala.TabIndex = 10
        Me.lblabSharayeteKala.Text = "محدوديت هاي نگهداشت کالا در جايگاه ها"
        Me.lblabSharayeteKala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblabSharayeteMohiti
        '
        Me.lblabSharayeteMohiti.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblabSharayeteMohiti.BackColor = System.Drawing.SystemColors.Control
        Me.lblabSharayeteMohiti.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblabSharayeteMohiti.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblabSharayeteMohiti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblabSharayeteMohiti.Location = New System.Drawing.Point (- 32, 0)
        Me.lblabSharayeteMohiti.Name = "lblabSharayeteMohiti"
        Me.lblabSharayeteMohiti.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblabSharayeteMohiti.Size = New System.Drawing.Size (891, 21)
        Me.lblabSharayeteMohiti.TabIndex = 35
        Me.lblabSharayeteMohiti.Text = "شرايط محيطي"
        Me.lblabSharayeteMohiti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelectGoroohSN
        '
        Me.btnSelectGoroohSN.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelectGoroohSN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectGoroohSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectGoroohSN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectGoroohSN.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelectGoroohSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectGoroohSN.Location = New System.Drawing.Point (333, 510)
        Me.btnSelectGoroohSN.Name = "btnSelectGoroohSN"
        Me.btnSelectGoroohSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectGoroohSN.Size = New System.Drawing.Size (90, 29)
        Me.btnSelectGoroohSN.TabIndex = 39
        Me.btnSelectGoroohSN.Text = "انتخاب گروه کالا"
        '
        'FrmabSharayeteKala
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (826, 549)
        Me.Controls.Add (Me.btnSelectGoroohSN)
        Me.Controls.Add (Me.lblabSharayeteMohiti)
        Me.Controls.Add (Me.pnlCommandMaster)
        Me.Controls.Add (Me.pnlNavigationMaster)
        Me.Controls.Add (Me.pnlGridMaster)
        Me.Controls.Add (Me.pnlGridDet1)
        Me.Controls.Add (Me.pnlNavigationDet1)
        Me.Controls.Add (Me.pnlCommandDet1)
        Me.Controls.Add (Me.lblabSharayeteKala)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (11, 65)
        Me.Name = "FrmabSharayeteKala"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "محدوديت هاي نگهداشت کالا در جايگاه ها"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabSharayeteKala
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabSharayeteKala
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabSharayeteKala
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmabSharayeteKala)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش شرايط محيطي تعريف شده است
    Private WithEvents DVabSharayeteMohiti As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش محدوديت هاي نگهداشت کالا در جايگاه ها تعريف شده است
    Private WithEvents DVabSharayeteKala As CDataView

    ' يک نمونه از فيلتر گروه بندي کالا
    Private pKala_GoroohBandi As Minoo.Applications.Paye.GoroohBandi

    Private Sub FrmabSharayeteKala_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        pKala_GoroohBandi = _
            New Minoo.Applications.Paye.GoroohBandi (tp, cn, gSM, gSNFieldOption, gVahedeTejariSN, gVahedeTejariDs)
        lblabSharayeteMohiti.Text = FTDD.GetCaption ("abSharayeteMohiti")
        lblabSharayeteKala.Text = FTDD.GetCaption ("abSharayeteKala")
    End Sub

    Private Sub FrmabChideman_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabSharayeteKala.Done()
        DVabSharayeteKala = Nothing
        DVabSharayeteMohiti.Done()
        DVabSharayeteMohiti = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي

        DVabSharayeteMohiti = New CDataView (cn)
        With DVabSharayeteMohiti
            .Init (pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdModify _
                                                                           Or EnumButtonOptions.boCmdExit Or _
                                                                           EnumButtonOptions.boCmdPrint Or _
                                                                           EnumButtonOptions.boCmdFilter Or _
                                                                           EnumButtonOptions.boCmdFind)
            .TableName = "abSharayeteMohiti"
            .SQLOrderBy = " SharayeteMohitiNo "
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "SharayeteMohitiStatus", _
                      "GeneralStatusSN")
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            With .Fields
                With .Add ("SharayeteMohitiSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add ("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ReadOnly = True
                    .ComboLateBinding = True
                End With
                With .Add ("AnbarSN", "DataCombo")
                    .DefaultValue = gAnbarSN
                    .ReadOnly = True
                    .ComboLateBinding = True
                End With
                .Add ("SharayeteMohitiNo", "TextBox", EnumFieldOptions.foDefault)
                .Add ("SharayeteMohitiDs", "TextBox", EnumFieldOptions.foDefault)
                With _
                    .Add ("SharayeteMohitiStatus->paGeneralStatus.GeneralStatusDs", "DataCombo", _
                          EnumFieldOptions.foHidden)
                    .DefaultValue = 1
                End With
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

        DVabSharayeteKala = New CDataView (cn)
        With DVabSharayeteKala
            .Init (pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdPrint Or _
                                                                     EnumButtonOptions.boCmdFind)
            .TableName = "abSharayeteKala"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "SharayeteKalaStatus", "GeneralStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paVw_paGoroohFull", "GoroohSN", "GoroohSN")
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            With .Fields
                With .Add ("SharayeteKalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With _
                    .Add ("SharayeteKalaStatus->paGeneralStatus.GeneralStatusDs", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = 1
                End With
                .Add ("SharayeteMohitiSN", , EnumFieldOptions.foHidden)
                With _
                    .Add ( _
                          "GoroohSN->paVw_paGoroohFull.{paVw_paGoroohFull.GoroohBandiDS + ' - ' + paVw_paGoroohFull.GoroohDS} AS GoroohSN ", _
                          "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abSharayeteKala.GoroohSN")
                    .ComboWhereCondition = " GoroohMojoodiatSN = 1.935 "
                End With
                .Add ("SharayeteKalaDS", "TextBox", EnumFieldOptions.foDefault)
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
            .Parent = DVabSharayeteMohiti
        End With
        DVabSharayeteMohiti.Refresh()

    End Sub

    Private Sub DVabSharayeteMohiti_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSharayeteMohiti.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
            Case EnumCommands.cmSave
                ' مقدار فيلد به صورت منحصربفرد تهيه شده و در فيلد مربوطه ذخيره ميگردد
                DVabSharayeteMohiti.Fields ("UnqStr").Value = _
                    Minoo.Functions.FTDBCommonFunctions.UnqStr (cn, _
                                                                (DVabSharayeteMohiti.Fields ("SharayeteMohitiDs").Value))
            Case EnumCommands.cmAbort
            Case EnumCommands.cmDelete
        End Select

    End Sub

    Private Sub btnSelectGoroohSN_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectGoroohSN.Click
        ' انتخاب و ثبت گروه هاي مورد نظر در محدوديت هاي نگهداشت کالا
        Dim vSharayeteKalaSN, vSharayeteMohitiSN, vGoroohSN As Decimal
        Dim vKala_FilterSelectedGoroohSN As String

        vSharayeteMohitiSN = Val (DVabSharayeteMohiti.Fields ("SharayeteMohitiSN").Value)
        If vSharayeteMohitiSN <> 0 Then
            pKala_GoroohBandi.ShowFilterGorooh (True, 1.935, 0, "KalaSN")
            vKala_FilterSelectedGoroohSN = pKala_GoroohBandi.FilterSelectedGoroohSN
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim j As Short
            Dim vArr() As String
            If Trim (vKala_FilterSelectedGoroohSN) <> "" Then
                vArr = Split (vKala_FilterSelectedGoroohSN, ",")
                For j = LBound (vArr) To UBound (vArr)
                    If Trim (vArr (j)) <> 0 Then
                        vGoroohSN = Trim (vArr (j))
                        If vGoroohSN <> 0 Then
                            vSharayeteKalaSN = gSM.Identifier
                            ' Yes
                            ' فراخواني اس پي براي درج گروه هاي انتخاب شده
                            cn.CallSP ("abSharayeteKala_Insert", vSharayeteKalaSN, System.DBNull.Value, 1, _
                                       vSharayeteMohitiSN _
                                       , vGoroohSN _
                                       , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, _
                                       System.DBNull.Value _
                                       , gSM.UserID_Name, System.Environment.MachineName, System.DBNull.Value)
                        End If
                    End If
                Next j
            End If
            DVabSharayeteKala.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If

    End Sub
End Class
