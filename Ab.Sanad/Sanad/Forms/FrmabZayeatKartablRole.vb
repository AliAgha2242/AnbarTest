Public Class FrmabZayeatKartablRole
    Inherits Minoo.Base.FTBaseForm


    Private components As System.ComponentModel.IContainer
    Private Shared m_vb6formdefinstance As FrmabZayeatKartablRole
    Private Shared m_initializingdefinstance As Boolean

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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

    Public Shared Property DefInstance() As FrmabZayeatKartablRole

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmabZayeatKartablRole
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmabZayeatKartablRole)
            m_vb6formdefinstance = Value

        End Set

    End Property

    Public WithEvents pnlC As Panel
    Public WithEvents pnlN As Panel
    Public WithEvents pnlG As Panel
    Friend WithEvents Panel1 As Panel

    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlC)
        Me.Panel1.Controls.Add(Me.pnlN)
        Me.Panel1.Controls.Add(Me.pnlG)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 453)
        Me.Panel1.TabIndex = 0
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(661, 413)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(405, 37)
        Me.pnlC.TabIndex = 9
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(6, 413)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(280, 37)
        Me.pnlN.TabIndex = 10
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Control
        Me.pnlG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(3, 3)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(1063, 404)
        Me.pnlG.TabIndex = 11
        '
        'FrmabZayeatKartablRole
        '
        Me.ClientSize = New System.Drawing.Size(1069, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmabZayeatKartablRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف دسترسی های کارتابل ضایعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DvM As CDataView
    Private WithEvents dcbVahedeTejari As NetSql.Components.DataCombo
    Private WithEvents dcbZayeatGardeshState As NetSql.Components.DataCombo



    Private Sub FrmabZayeatKartablRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DvM = New CDataView(cn)

        With DvM
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdUpdate Or EnumButtonOptions.boCmdModify _
                                        Or EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdFilter)
            .TableName = "abZayeatGardeshRole"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_User", "UserId", "UserId")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_ZayeatGardeshStateType", "ZayeatGardeshStateSN", "ZayeatGardeshStateSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeTejari", "vahedetejariSn", "VahedeTejariSn")
            .AccessRight = EnumAccessRight.arAll
            .EditInGrid = True
            .SQLWhere = "ZayeatGardeshStateNo<>0 And Isnull(IsFinal,0)<>1 And isnull(IsActive,0)=1"
            .AutoFetchCurrentRow = True

            With .Fields

                With .Add("ZayeatGardeshRoleSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("ZayeatGardeshRoleNo", "TextBox", EnumFieldOptions.foDefault)
                    .ReadOnly = True
                    .DefaultValue = 1
                    .Caption = "شماره"
                End With
                'With .Add("VahedeTejariSN", "textbox", EnumFieldOptions.foHidden)
                '    .DefaultValue = gVahedeTejariSN
                'End With
                With .Add("vahedeTejariSn-> vahedeTejarids as vahedeTejarisn", "DataCombo", EnumFieldOptions.foDefault)
                    .ComboLateBinding = True
                    .Caption = "واحد تجاری"
                    .ComboWhereCondition = "VahedeTejariStatus = 1 and (PedarVahedeTejariSN = 9.935 OR VahedeTejariSN = 9.935)"
                    dcbVahedeTejari = .Component
                End With

                With .Add("UserId->UserCompany  As UserID", "DataCombo", EnumFieldOptions.foDefault)
                    .ComboLateBinding = True
                    .Caption = "کد کاربری"
                    .ComboWhereCondition = "InActive = 0"
                    .RefreshCombo()
                End With
                With .Add("ZayeatGardeshStateSN->abVw_ZayeatGardeshStateType.{ZayeatGardeshStateDS+'('+StateTypeDS+')'} As ZayeatGardeshStateSN", "DataCombo")
                    .Caption = "سطح دسترسی(نقش)"
                    .ComboLateBinding = True
                    .ComboWhereCondition = "isnull(IsActive,0)=1 And ZayeatGardeshStateNo<>0 And Isnull(IsFinal,0)<>1 "
                    dcbZayeatGardeshState = .Component
                    .RefreshCombo()
                End With
                .Add("Res0", "TextBox", EnumFieldOptions.foHidden)
                .Add("Res1", "TextBox", EnumFieldOptions.foHidden)
                .Add("Res2", "TextBox", EnumFieldOptions.foHidden)
                .Add("Res3", "TextBox", EnumFieldOptions.foHidden)
                .Add("Res4", "TextBox", EnumFieldOptions.foHidden)


                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChkSum", "TextBox", EnumFieldOptions.foHidden)

            End With
        End With
        DvM.Refresh()

    End Sub


    Private Sub dcbZayeatGardeshState_GotFocus(sender As Object, e As EventArgs) Handles dcbZayeatGardeshState.GotFocus

        If (Not String.IsNullOrEmpty(DvM.Fields("VahedeTejariSn").Value.ToString())) AndAlso CDec(DvM.Fields("VahedeTejariSn").Value) <> 9.935 Then
            DvM.Fields("ZayeatGardeshStateSN").ComboWhereCondition = DvM.Fields("ZayeatGardeshStateSN").ComboWhereCondition + " And isnull(IsAccessOfShobe,0) = 1"
            DvM.Fields("ZayeatGardeshStateSN").RefreshCombo()
        Else
            DvM.Fields("ZayeatGardeshStateSN").ComboWhereCondition = "isnull(IsActive,0)=1 And ZayeatGardeshStateNo<>0 And Isnull(IsFinal,0)<>1 "
            DvM.Fields("ZayeatGardeshStateSN").RefreshCombo()
        End If

    End Sub

    Private Sub DvM_CommandClick(aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DvM.CommandClick

        If aCommand = EnumCommands.cmSave Then

            If DvM.Fields("UserId").Value Is Nothing OrElse String.IsNullOrWhiteSpace(DvM.Fields("UserId").Value.ToString()) Then
                MsgBox("کاربر انتخاب نشده است ")
                Exit Sub
            End If
            Dim Dv As DataView = cn.ExecuteQuery("Select * from [abZayeatGardeshRole] Where  UserId=" & DvM.Fields("UserId").Value.ToString)
            Dv.RowFilter = "ZayeatGardeshStateSN=" & DvM.Fields("ZayeatGardeshStateSN").Value.ToString
            If Dv.Count > 0 Then
                CSystem.MsgBox("برای این کاربر <" & DvM.FieldText("UserId") & "> دسترسی مشابه تعریف شده است!" + vbNewLine + "لذا تعریف مجدد همان دسترسی امکان پذیر نمی باشد", MsgBoxStyle.Exclamation, "")
                aCancel = True
                Exit Sub
            End If
            Dv.RowFilter = "0=0"
            If Dv.Count >= 1 Then
                If CSystem.MsgBox("برای این کاربر <" & DvM.FieldText("UserId") & "> از قبل دسترسی تعریف شده است.آیا مایل به تعریف دسترسی جدید نیز هستید؟", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "دسترسی جدید") = MsgBoxResult.No Then
                    aCancel = True
                End If
            End If

        End If
    End Sub

    Private Sub DvM_AfterCommandClick(aCommand As EnumCommands) Handles DvM.AfterCommandClick

    End Sub

    Private Sub DvM_AfterSPExecute(aSPKind As EnumSPKind, aCommand As Object) Handles DvM.AfterSPExecute

    End Sub

    ' برای بودن تابع در سیستم انبار برای مواقع لزوم
    'Public Function MaxNoInTable(ByVal TableName As String, ColumnName As String, Optional ByVal WhereCondition As String = "") As Integer
    '    Dim Where As String = If(WhereCondition Is Nothing Or WhereCondition = "", "", "Where " + WhereCondition)
    '    Dim dv As DataView = cn.ExecuteQuery("Select Isnull(Max(Cast (" & ColumnName & " as bigint)),0) From " & TableName & " " & Where )
    '    MaxNoInTable = CInt(dv(0)(0))
    'End Function

End Class
