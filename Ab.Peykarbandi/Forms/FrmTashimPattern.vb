'Programmer :: Zohreh Izadpanah     
'CreateDate :: 1386/06/28
'ModifiedDate::
'Description:: فرم الگوي تسهيم 
'System :: سيستم انبار

Public Class FrmTashimPattern
    Inherits Minoo.base.FTBaseForm


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents FtTabControl2 As Minoo.Controls.FTTabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pnln0 As System.Windows.Forms.Panel
    Friend WithEvents pnlg0 As System.Windows.Forms.Panel
    Friend WithEvents pnlc0 As System.Windows.Forms.Panel
    Friend WithEvents FtTabControl1 As Minoo.Controls.FTTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnln1 As System.Windows.Forms.Panel
    Friend WithEvents pnlg1 As System.Windows.Forms.Panel
    Friend WithEvents pnlc1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FtTabControl2 = New Minoo.Controls.FTTabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.pnln0 = New System.Windows.Forms.Panel
        Me.pnlg0 = New System.Windows.Forms.Panel
        Me.pnlc0 = New System.Windows.Forms.Panel
        Me.FtTabControl1 = New Minoo.Controls.FTTabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.pnln1 = New System.Windows.Forms.Panel
        Me.pnlg1 = New System.Windows.Forms.Panel
        Me.pnlc1 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.FtTabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FtTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FtTabControl2
        '
        Me.FtTabControl2.Controls.Add (Me.TabPage2)
        Me.FtTabControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FtTabControl2.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.FtTabControl2.ItemSize = New System.Drawing.Size (97, 19)
        Me.FtTabControl2.Location = New System.Drawing.Point (0, 0)
        Me.FtTabControl2.Mirrored = True
        Me.FtTabControl2.Name = "FtTabControl2"
        Me.FtTabControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FtTabControl2.SelectedIndex = 0
        Me.FtTabControl2.Size = New System.Drawing.Size (848, 280)
        Me.FtTabControl2.TabIndex = 27
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add (Me.pnln0)
        Me.TabPage2.Controls.Add (Me.pnlg0)
        Me.TabPage2.Controls.Add (Me.pnlc0)
        Me.TabPage2.Location = New System.Drawing.Point (4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size (840, 253)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "الگو"
        '
        'pnln0
        '
        Me.pnln0.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnln0.Location = New System.Drawing.Point (5, 210)
        Me.pnln0.Name = "pnln0"
        Me.pnln0.Size = New System.Drawing.Size (211, 41)
        Me.pnln0.TabIndex = 2
        '
        'pnlg0
        '
        Me.pnlg0.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                   Or System.Windows.Forms.AnchorStyles.Left) _
                                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlg0.Location = New System.Drawing.Point (5, 6)
        Me.pnlg0.Name = "pnlg0"
        Me.pnlg0.Size = New System.Drawing.Size (830, 199)
        Me.pnlg0.TabIndex = 0
        '
        'pnlc0
        '
        Me.pnlc0.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlc0.Location = New System.Drawing.Point (499, 210)
        Me.pnlc0.Name = "pnlc0"
        Me.pnlc0.Size = New System.Drawing.Size (336, 41)
        Me.pnlc0.TabIndex = 1
        '
        'FtTabControl1
        '
        Me.FtTabControl1.Controls.Add (Me.TabPage1)
        Me.FtTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FtTabControl1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.FtTabControl1.ItemSize = New System.Drawing.Size (97, 19)
        Me.FtTabControl1.Location = New System.Drawing.Point (0, 280)
        Me.FtTabControl1.Mirrored = True
        Me.FtTabControl1.Name = "FtTabControl1"
        Me.FtTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FtTabControl1.SelectedIndex = 0
        Me.FtTabControl1.Size = New System.Drawing.Size (848, 286)
        Me.FtTabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add (Me.pnln1)
        Me.TabPage1.Controls.Add (Me.pnlg1)
        Me.TabPage1.Controls.Add (Me.pnlc1)
        Me.TabPage1.Location = New System.Drawing.Point (4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size (840, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "تراکنش"
        '
        'pnln1
        '
        Me.pnln1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnln1.Location = New System.Drawing.Point (4, 214)
        Me.pnln1.Name = "pnln1"
        Me.pnln1.Size = New System.Drawing.Size (209, 41)
        Me.pnln1.TabIndex = 5
        '
        'pnlg1
        '
        Me.pnlg1.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                   Or System.Windows.Forms.AnchorStyles.Left) _
                                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlg1.Location = New System.Drawing.Point (4, 4)
        Me.pnlg1.Name = "pnlg1"
        Me.pnlg1.Size = New System.Drawing.Size (832, 206)
        Me.pnlg1.TabIndex = 3
        '
        'pnlc1
        '
        Me.pnlc1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlc1.Location = New System.Drawing.Point (500, 214)
        Me.pnlc1.Name = "pnlc1"
        Me.pnlc1.Size = New System.Drawing.Size (336, 41)
        Me.pnlc1.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Maroon
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point (0, 280)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size (848, 3)
        Me.Splitter1.TabIndex = 30
        Me.Splitter1.TabStop = False
        '
        'FrmTashimPattern
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 15)
        Me.ClientSize = New System.Drawing.Size (848, 566)
        Me.Controls.Add (Me.Splitter1)
        Me.Controls.Add (Me.FtTabControl1)
        Me.Controls.Add (Me.FtTabControl2)
        Me.Name = "FrmTashimPattern"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الگوي تسهيم نرخ خريد"
        Me.FtTabControl2.ResumeLayout (False)
        Me.TabPage2.ResumeLayout (False)
        Me.FtTabControl1.ResumeLayout (False)
        Me.TabPage1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmTashimPattern
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmTashimPattern

    Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmTashimPattern
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

    End Get

        Set(ByVal Value As FrmTashimPattern)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

#Region "PrivateVariabledDefinition"

    Private WithEvents MasterDataView As CDataView
    Private WithEvents DetailDataView As CDataView

    Private WithEvents cboNoeFaktoreKharid As NetSql.components.DataCombo
    Private WithEvents cboTahvilGirandeh As NetSql.components.DataCombo
    Private WithEvents cboGhabzeAnbar As NetSql.components.DataCombo
    Private WithEvents cboKala As NetSql.components.DataCombo

    Private dclFdate As NetSql.components.CDateCtrl
    Private dclTdate As NetSql.components.CDateCtrl


#End Region

    '//ناحيه تعريف متغيرهاي Local

    Private Sub frmFactorView_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MasterDataView = New CDataView (cn)
        DetailDataView = New CDataView (cn)

        InitMasterDataView()
        InitDetailDataView()

        DetailDataView.Parent = MasterDataView

        MasterDataView.Refresh()
    End Sub

    Private Sub frmFactorView_Closed (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        If Not MasterDataView Is Nothing Then

            MasterDataView.Done()
            MasterDataView = Nothing

        End If
        If Not DetailDataView Is Nothing Then

            DetailDataView.Done()
            DetailDataView = Nothing

        End If

    End Sub

    Private Sub InitMasterDataView()

        With MasterDataView

            .Init (pnlg0, , pnlc0, pnln0, _
                   EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit)
            .TableName = "abTashimPattern"
            .SQLOrderBy = "TashimPatternNo"
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True

            With .Fields

                With .Add ("TashimPatternSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add ("TashimPatternNo", "Textbox")
                    .Caption = "کد الگو"
                    .MinComponentWidth = 50
                End With

                With .Add ("TashimPatternDS", "Textbox")
                    .Caption = "شرح الگو"
                    .MinComponentWidth = 100
                End With

                With _
                    .Add ( _
                          "MojoodiMoinSN-> {(Select GoroohNo From MaKol T1 Inner Join Magorooh T2 ON T1.GoroohSN = T2.GoroohSN Where KolSN = MaMoin.KolSN)+(Select KolNo From MaKol Where KolSN = MaMoin.KolSN)+MaMoin.MoinNo +'-'+MaMoin.MoinDS} AS MojoodiMoinDS ", _
                          "DataCombo")
                    .MinComponentWidth = 250
                    .ComboLateBinding = True
                    .Caption = "حساب معين موجودي"
                End With

                With _
                    .Add ( _
                          "EnherafMoinSN-> {(Select GoroohNo From MaKol T1 Inner Join Magorooh T2 ON T1.GoroohSN = T2.GoroohSN Where KolSN = MaMoin2.KolSN)+(Select KolNo From MaKol Where KolSN = MaMoin2.KolSN)+MaMoin2.MoinNo +'-'+MaMoin2.MoinDS} AS EnherafMoinDS ", _
                          "DataCombo")
                    .MinComponentWidth = 250
                    .ComboLateBinding = True
                    .Caption = "حساب معين انحراف"
                End With

                With _
                    .Add ( _
                          "KalaMoinSN-> {(Select GoroohNo From MaKol T1 Inner Join Magorooh T2 ON T1.GoroohSN = T2.GoroohSN Where KolSN = MaMoin3.KolSN)+(Select KolNo From MaKol Where KolSN = MaMoin3.KolSN)+MaMoin3.MoinNo +'-'+MaMoin3.MoinDS} AS KalaMoinDS ", _
                          "DataCombo")
                    .MinComponentWidth = 250
                    .ComboLateBinding = True
                    .Caption = "حساب معين کالاهاي بدون گردش"
                End With

                With .Add ("Tozih", "Textbox")
                    .Caption = "توضيحات"
                    .MinComponentWidth = 250
                End With

                .Add ("unqStr", , EnumFieldOptions.foHidden)

                With .Add ("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "ثبت کننده"
                End With

                With .Add ("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub

    Private Sub InitDetailDataView()

        With DetailDataView

            .Init (pnlg1, , pnlc1, pnln1, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter)
            .TableName = "abTashimPatternTarakonesh"
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True

            With .Fields

                With .Add ("TashimPatternTarakoneshSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                .Add ("TashimPatternSN", , EnumFieldOptions.foHidden)

                With _
                    .Add ( _
                          "AfzayandeTarakoneshSN -> {abTarakonesh.TarakoneshNo +'-'+abTarakonesh.TarakoneshDS} AS AfzayandeTarakoneshDS ", _
                          "DataCombo")
                    .ComboWhereCondition = "abTarakonesh.TarakoneshSN >50 "
                    .MinComponentWidth = 250
                    .Caption = "تراکنش افزاينده"
                End With

                With _
                    .Add ( _
                          "KahandeTarakoneshSN1 -> {abTarakonesh2.TarakoneshNo +'-'+abTarakonesh2.TarakoneshDS} AS KahandeTarakoneshDS1 ", _
                          "DataCombo")
                    .ComboWhereCondition = "abTarakonesh2.TarakoneshSN <50 "
                    .MinComponentWidth = 250
                    .Caption = "تراکنش کاهنده اول"
                End With

                With _
                    .Add ( _
                          "KahandeTarakoneshSN2 -> {abTarakonesh3.TarakoneshNo +'-'+abTarakonesh3.TarakoneshDS} AS KahandeTarakoneshDS2 ", _
                          "DataCombo")
                    .ComboWhereCondition = "abTarakonesh3.TarakoneshSN <50 "
                    .MinComponentWidth = 250
                    .Caption = "تراکنش کاهنده دوم"
                End With

                With _
                    .Add ( _
                          "MoinSN-> {(Select GoroohNo From MaKol T1 Inner Join Magorooh T2 ON T1.GoroohSN = T2.GoroohSN Where KolSN = MaMoin.KolSN)+(Select KolNo From MaKol Where KolSN = MaMoin.KolSN)+MaMoin.MoinNo +'-'+MaMoin.MoinDS} AS MoinDS ", _
                          "DataCombo")
                    .MinComponentWidth = 250
                    .ComboLateBinding = True
                    .Caption = "حساب معين "
                End With

                With .Add ("GroupByTarafHesab", "CheckBox")
                    .Caption = "دسته بندي بر اساس طرف حساب"
                    .DefaultValue = 0
                End With

                With .Add ("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With

                With .Add ("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With

            End With

        End With

    End Sub


    Private Sub SetButton()

        MasterDataView.CommandEnabled (EnumCommands.cmAdd) = gSM.ActionInsert (MasterDataView.TableName)
        MasterDataView.CommandEnabled (EnumCommands.cmEdit) = MasterDataView.DataRows > 0 And _
                                                              gSM.ActionUpdate (MasterDataView.TableName)
        MasterDataView.CommandEnabled (EnumCommands.cmDelete) = MasterDataView.DataRows > 0 And _
                                                                gSM.ActionDelete (MasterDataView.TableName)
        DetailDataView.CommandEnabled (EnumCommands.cmAdd) = gSM.ActionInsert (DetailDataView.TableName) And _
                                                             MasterDataView.DataRows > 0 And _
                                                             Val (MasterDataView.FieldValue ("SanadAvalDorehSN")) > _
                                                             gSM.Identifier
        DetailDataView.CommandEnabled (EnumCommands.cmEdit) = gSM.ActionUpdate (DetailDataView.TableName) And _
                                                              MasterDataView.DataRows > 0 And _
                                                              DetailDataView.DataRows > 0
        DetailDataView.CommandEnabled (EnumCommands.cmDelete) = gSM.ActionDelete (DetailDataView.TableName) And _
                                                                MasterDataView.DataRows > 0 And _
                                                                DetailDataView.DataRows > 0

    End Sub


    Private Sub DetailDataView_CommandClick (ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles DetailDataView.CommandClick
        '//Local Vriables Definition
        Dim StrMsg As String

        '//Local Vriables Definition

        If aCommand = EnumCommands.cmAdd Then

        ElseIf aCommand = EnumCommands.cmSave Then

        End If

        If StrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(StrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "خطا")
            aCancel = True
        End If

    End Sub


    Private Sub MasterDataView_CommandClick (ByVal aCommand As NetSql.View.CEnum.EnumCommands, ByRef aCancel As Boolean) _
        Handles MasterDataView.CommandClick
        Select Case aCommand
            Case EnumCommands.cmSave
                MasterDataView.Fields ("UnqStr").Value = _
                    Minoo.Functions.FTDBCommonFunctions.UnqStr (cn, (MasterDataView.Fields ("TashimPatternDS").Value))

        End Select
    End Sub
End Class

