Public Class FrmabTarakoneshContraint
    Inherits Minoo.Base.FTBaseForm

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

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabTarakoneshContraint
    Friend WithEvents PanelData As Panel
    Friend WithEvents PanelCommand As Panel
    Friend WithEvents PanelNavigation As Panel
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabTarakoneshContraint
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabTarakoneshContraint
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabTarakoneshContraint)
            m_vb6FormDefInstance = Value
        End Set
    End Property

    Private Sub InitializeComponent()
        Me.PanelData = New System.Windows.Forms.Panel()
        Me.PanelCommand = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelData
        '
        Me.PanelData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelData.Location = New System.Drawing.Point(2, 3)
        Me.PanelData.Name = "PanelData"
        Me.PanelData.Size = New System.Drawing.Size(1151, 570)
        Me.PanelData.TabIndex = 0
        '
        'PanelCommand
        '
        Me.PanelCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCommand.Location = New System.Drawing.Point(729, 579)
        Me.PanelCommand.Name = "PanelCommand"
        Me.PanelCommand.Size = New System.Drawing.Size(424, 44)
        Me.PanelCommand.TabIndex = 1
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelNavigation.Location = New System.Drawing.Point(2, 579)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(424, 44)
        Me.PanelNavigation.TabIndex = 2
        '
        'FrmabTarakoneshContraint
        '
        Me.ClientSize = New System.Drawing.Size(1157, 625)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelCommand)
        Me.Controls.Add(Me.PanelData)
        Me.Name = "FrmabTarakoneshContraint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تنظیمات محدود سازی تراکنش"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Private Sub FrmabTarakoneshContraint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
