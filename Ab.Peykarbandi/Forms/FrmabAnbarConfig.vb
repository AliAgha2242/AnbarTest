' OK
'Author ::سعید غفاری
'CreateDate :: 1390/05/26 Start 17:21
'ModifiedDate::
'Description:: تعريف تنظیمات انبارها
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmabAnbarConfig
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

    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tab1.SuspendLayout()
        Me.TabP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlG
        '
        Me.pnlG.Size = New System.Drawing.Size(651, 416)
        '
        'pnlN
        '
        Me.pnlN.Location = New System.Drawing.Point(5, 420)
        Me.pnlN.Size = New System.Drawing.Size(227, 35)
        '
        'pnlC
        '
        Me.pnlC.Location = New System.Drawing.Point(232, 420)
        '
        'Tab1
        '
        Me.Tab1.Size = New System.Drawing.Size(664, 482)
        '
        'TabP1
        '
        Me.TabP1.Size = New System.Drawing.Size(656, 456)
        '
        'FrmabAnbarConfig
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(664, 482)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.Name = "FrmabAnbarConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تنظیمات اسناد متقابل "
        Me.Tab1.ResumeLayout(False)
        Me.TabP1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabAnbarConfig
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabAnbarConfig
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabAnbarConfig
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabAnbarConfig)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Private WithEvents DVabAnbarConfig As CDataView
    Private WithEvents dcbSenderVahedetejariSN As NetSql.Components.DataCombo
    Private WithEvents dcbReceiverVahedetejariSN As NetSql.Components.DataCombo
    Private WithEvents dcbSenderAnbarSN As NetSql.Components.DataCombo
    Private WithEvents dcbReceiverAnbarSN As NetSql.Components.DataCombo
    Private WithEvents dcbSenderTarakoneshSN As NetSql.Components.DataCombo
    Private WithEvents dcbReceiverTarakoneshSN As NetSql.Components.DataCombo
    Private WithEvents dcbSenderTafsiliSN As NetSql.Components.DataCombo
    Private WithEvents dcbReceiverTafsiliSN As NetSql.Components.DataCombo



    Private Sub FrmAnbarConfig_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        Call InitDataView()

    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabAnbarConfig = New CDataView(cn)
        With DVabAnbarConfig
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
              Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter Or _
              EnumButtonOptions.boCmdFind)

            .TableName = "abAnbarConfig"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abanbar", "SenderanbarSN", "anbarSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abanbar", "ReceiveranbarSN", "anbarSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "PaVahedetejari", "SenderVahedetejariSN", "VahedetejariSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "PaVahedetejari", "ReceiverVahedetejariSN", "VahedetejariSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "Matafsili", "SendertafsiliSN", "tafsiliSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "Matafsili", "ReceivertafsiliSN", "tafsiliSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abtarakonesh", "SendertarakoneshSN", "tarakoneshSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abtarakonesh", "ReceivertarakoneshSN", "tarakoneshSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadStatus", "ReceiverSanadStatus", "SanadStatusSN")

            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            With .Fields
                With .Add("AnbarConfigSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("AnbarConfigDS", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "شرح انتقال"
                End With
                With .Add("SenderVahedetejariSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbSenderVahedetejariSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مبداء"
                End With
                With .Add("ReceiverVahedetejariSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbReceiverVahedetejariSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مقصد"
                End With
                With .Add("SenderanbarSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbSenderAnbarSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مبداء"
                End With
                With .Add("ReceiveranbarSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbReceiverAnbarSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مقصد"
                End With
                With .Add("SendertarakoneshSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbSenderTarakoneshSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مبداء"
                End With
                With .Add("ReceivertarakoneshSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbReceiverTarakoneshSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مقصد"
                End With
                With .Add("SenderTafsiliSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbSenderTafsiliSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مبداء"
                End With
                With .Add("ReceiverTafsiliSN", "DataCombo", EnumFieldOptions.foDefault)
                    dcbReceiverTafsiliSN = .Component
                    .ComboLateBinding = True
                    .Caption += " مقصد"
                End With
                With .Add("ReceiverSanadStatus->abSanadStatus.SanadStatusDs", "DataCombo")
                    .Caption = cn.FieldCaption("abAnbar.AnbarStatus")
                    .DefaultValue = 1
                    .Caption += " مقصد"
                End With
            End With
        End With

        DVabAnbarConfig.Refresh()

    End Sub

    Private Sub FrmAnbar_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabAnbarConfig.Done()
        DVabAnbarConfig = Nothing
    End Sub

    Private Sub dcbReceiverVahedetejariSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbReceiverVahedetejariSN.Enter
        DVabAnbarConfig.Fields("ReceiverVahedetejariSN").ComboWhereCondition = "(OzveGorooh = 1)"     ''''' "VahedetejariSN=" & gVahedeTejariSN
        DVabAnbarConfig.Fields("ReceiverVahedetejariSN").RefreshCombo()
    End Sub
    Private Sub dcbSenderVahedetejariSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbSenderVahedetejariSN.Enter
        DVabAnbarConfig.Fields("SenderVahedetejariSN").ComboWhereCondition = "(OzveGorooh = 1)"      ''''' "VahedetejariSN=" & gVahedeTejariSN
        DVabAnbarConfig.Fields("SenderVahedetejariSN").RefreshCombo()
    End Sub

    Private Sub dcbReceiverAnbarSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbReceiverAnbarSN.Enter
        If Not (DVabAnbarConfig.Fields("ReceiverVahedetejariSN").IsEmpty) Then
            DVabAnbarConfig.Fields("ReceiverAnbarSN").ComboWhereCondition = "AnbarSN in (Select AnbarSN From AbAnbar Where VahedetejariSN=" & DVabAnbarConfig.Fields("ReceiverVahedetejariSN").Value & ")"
        Else
            DVabAnbarConfig.Fields("ReceiverAnbarSN").ComboWhereCondition = "1=2"
        End If
        DVabAnbarConfig.Fields("ReceiverAnbarSN").RefreshCombo()
    End Sub
    Private Sub dcbSenderAnbarSN_Enter(sender As Object, e As System.EventArgs) Handles dcbSenderAnbarSN.Enter
        If Not (DVabAnbarConfig.Fields("SenderVahedetejariSN").IsEmpty) Then
            DVabAnbarConfig.Fields("SenderAnbarSN").ComboWhereCondition = "AnbarSN in (Select AnbarSN From AbAnbar Where VahedetejariSN=" & DVabAnbarConfig.Fields("SenderVahedetejariSN").Value & ")"
        Else
            DVabAnbarConfig.Fields("SenderAnbarSN").ComboWhereCondition = "1=2"
        End If
        DVabAnbarConfig.Fields("SenderAnbarSN").RefreshCombo()
    End Sub

    Private Sub dcbReceiverTarakoneshSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbReceiverTarakoneshSN.Enter
        If Not (DVabAnbarConfig.Fields("ReceiverAnbarSN").IsEmpty) Then
            DVabAnbarConfig.Fields("ReceiverTarakoneshSN").ComboWhereCondition = "TarakoneshSN in (Select TarakoneshSN From AbAnbarTarakonesh Where AnbarSN=" & DVabAnbarConfig.Fields("ReceiverAnbarSN").Value & ")"
        Else
            DVabAnbarConfig.Fields("ReceiverTarakoneshSN").ComboWhereCondition = "1=2"
        End If
        DVabAnbarConfig.Fields("ReceiverTarakoneshSN").RefreshCombo()
    End Sub
    Private Sub dcbSenderTarakoneshSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbSenderTarakoneshSN.Enter
        If Not (DVabAnbarConfig.Fields("SenderAnbarSN").IsEmpty) Then
            DVabAnbarConfig.Fields("SenderTarakoneshSN").ComboWhereCondition = "TarakoneshSN in (Select TarakoneshSN From AbAnbarTarakonesh Where AnbarSN=" & DVabAnbarConfig.Fields("SenderAnbarSN").Value & ")"
        Else
            DVabAnbarConfig.Fields("SenderTarakoneshSN").ComboWhereCondition = "1=2"
        End If
        DVabAnbarConfig.Fields("SenderTarakoneshSN").RefreshCombo()
    End Sub

    Private Sub dcbReceiverTafsiliSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbReceiverTafsiliSN.Enter
        DVabAnbarConfig.Fields("ReceiverTafsiliSN").RefreshCombo()
    End Sub
    Private Sub dcbSenderTafsiliSN_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbSenderTafsiliSN.Enter
        DVabAnbarConfig.Fields("SenderTafsiliSN").RefreshCombo()
    End Sub


End Class
