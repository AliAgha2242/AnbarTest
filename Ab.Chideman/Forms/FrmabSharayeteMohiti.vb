' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/07/07
'ModifiedDate::
'Description::  تعريف شرايط محيطي جايگاه هاي نگهداري کالا 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmabSharayeteMohiti
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        'FrmabSharayeteMohiti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (731, 482)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Location = New System.Drawing.Point (3, 29)
        Me.Name = "FrmabSharayeteMohiti"
        Me.Text = "شرايط محيطي"

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabSharayeteMohiti
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabSharayeteMohiti
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabSharayeteMohiti
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmabSharayeteMohiti)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش شرايط محيطي تعريف شده است
    Private WithEvents DVabSharayeteMohiti As CDataView

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

    Private Sub FrmabSharayeteMohiti_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        Me.Tab1.TabPages (0).Text = FTDD.GetCaption ("abSharayeteMohiti")
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabSharayeteMohiti = New CDataView (cn)
        With DVabSharayeteMohiti
            .Init (pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                       Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter Or _
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
        DVabSharayeteMohiti.Refresh()
    End Sub

    Private Sub FrmabSharayeteMohiti_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabSharayeteMohiti.Done()
        DVabSharayeteMohiti = Nothing
    End Sub
End Class