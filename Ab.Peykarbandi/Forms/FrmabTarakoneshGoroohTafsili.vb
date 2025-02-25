' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/04/03 Start 14:25
'ModifiedDate::
'Description::  ارتباط تراكنش انبار  با گروه هاي تفصيلي
' ثبت و بروزآوري ارتباط تراکنش هاي انبار با گروه هاي تفصيلي 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmTarakoneshGoroohTafsili
    Inherits Minoo.Base.FTFormBaseMasterDetail

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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tab2.SuspendLayout()
        Me.Tabp2.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tabp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab2
        '
        Me.Tab2.Location = New System.Drawing.Point(0, 294)
        Me.Tab2.Size = New System.Drawing.Size(895, 252)
        '
        'Tabp2
        '
        Me.Tabp2.Location = New System.Drawing.Point(4, 22)
        Me.Tabp2.Size = New System.Drawing.Size(887, 226)
        Me.Tabp2.Text = "گروه تفصيلي"
        '
        'pnlN2
        '
        Me.pnlN2.Location = New System.Drawing.Point(0, 189)
        Me.pnlN2.Size = New System.Drawing.Size(463, 35)
        '
        'pnlC2
        '
        Me.pnlC2.Location = New System.Drawing.Point(467, 189)
        '
        'pnlG2
        '
        Me.pnlG2.Size = New System.Drawing.Size(887, 188)
        '
        'Tab1
        '
        Me.Tab1.Size = New System.Drawing.Size(895, 289)
        '
        'Tabp1
        '
        Me.Tabp1.Location = New System.Drawing.Point(4, 22)
        Me.Tabp1.Size = New System.Drawing.Size(887, 263)
        Me.Tabp1.Text = "تراكنش انبار"
        '
        'pnlN1
        '
        Me.pnlN1.Location = New System.Drawing.Point(0, 226)
        Me.pnlN1.Size = New System.Drawing.Size(463, 35)
        '
        'pnlC1
        '
        Me.pnlC1.Location = New System.Drawing.Point(467, 226)
        '
        'pnlG1
        '
        Me.pnlG1.Size = New System.Drawing.Size(887, 225)
        '
        'FrmTarakoneshGoroohTafsili
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(895, 546)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmTarakoneshGoroohTafsili"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ارتباط تراكنش انبار  با گروه هاي تفصيلي"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tab2.ResumeLayout(False)
        Me.Tabp2.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tabp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmTarakoneshGoroohTafsili
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmTarakoneshGoroohTafsili
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmTarakoneshGoroohTafsili
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmTarakoneshGoroohTafsili)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  تراکنشها تعريف شده است
    Private WithEvents DVabTarakonesh As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  ارتباط تراکنشها با گروه هاي تفصيلي مالي تعريف شده است
    Private WithEvents DVabTarakoneshGoroohTafsili As CDataView


    Private Sub FrmTarakoneshGoroohTafsili_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
    End Sub

    Private Sub FrmTarakoneshGoroohTafsili_Closed (ByVal eventSender As System.Object, _
                                                   ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        DVabTarakonesh.Done()
        DVabTarakonesh = Nothing
        DVabTarakoneshGoroohTafsili.Done()
        DVabTarakoneshGoroohTafsili = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabTarakonesh = New CDataView (cn)
        With DVabTarakonesh
            .Init (pnlG1, , pnlC1, pnlN1, EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter _
                                          Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abTarakonesh"
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            .EditInGrid = False
            With .Fields
                With .Add ("TarakoneshSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("TarakoneshNo", "TextBox", EnumFieldOptions.foDefault)
                .Add ("TarakoneshDs", "TextBox", EnumFieldOptions.foDefault)
                .Add ("Input", "CheckBox", EnumFieldOptions.foDefault)
                .Add ("Output", "CheckBox", EnumFieldOptions.foDefault)
            End With
        End With

        DVabTarakoneshGoroohTafsili = New CDataView (cn)
        With DVabTarakoneshGoroohTafsili
            .Init (pnlG2, , pnlC2, pnlN2, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdPrint _
                                          Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdExit)
            .TableName = "abTarakoneshGoroohTafsili"
            .Text = Me.Text
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            With .Fields
                With .Add ("TarakoneshGoroohTafsilisn", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("TarakoneshSN", "DataCombo", EnumFieldOptions.foHidden)
                With _
                    .Add ( _
                          "GoroohTafsiliSN->{ maGoroohTafsili.GoroohTafsiliNO + ' _ ' + maGoroohTafsili.GoroohTafsiliDS} AS GoroohTafsiliSN ", _
                          "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("maGoroohTafsili.GoroohTafsiliDS")
                End With
                With _
                    .Add ( _
                          "GoroohTafsiliSN2->{ maGoroohTafsili2.GoroohTafsiliNO + ' _ ' + maGoroohTafsili2.GoroohTafsiliDS} AS GoroohTafsiliSN2 ", _
                          "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("maGoroohTafsili.GoroohTafsiliDS") & "_2"
                End With
                With _
                    .Add ( _
                          "GoroohTafsiliSN3->{ maGoroohTafsili3.GoroohTafsiliNO + ' _ ' + maGoroohTafsili3.GoroohTafsiliDS} AS GoroohTafsiliSN3 ", _
                          "DataCombo", EnumFieldOptions.foHidden)
                    .Caption = cn.FieldCaption ("maGoroohTafsili.GoroohTafsiliDS") & "_3"
                End With
                .Add ("PayeSN", "TextBox", EnumFieldOptions.foHidden)
                .Add ("VahedeTejariSN", "TextBox", EnumFieldOptions.foHidden)
                .Add ("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add ("NoeAnbarSN", "DataCombo")
                With .Add ("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add ("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabTarakonesh
        End With

        DVabTarakonesh.Refresh()

    End Sub
End Class
