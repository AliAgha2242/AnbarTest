Public Class FrmabMovaghatSanadGhatee
    Inherits Minoo.Base.FTBaseForm

    Public WithEvents dbcSanad As NetSql.Components.DataCombo
    Friend WithEvents GroupBox1 As GroupBox
    Private components As System.ComponentModel.IContainer
    Friend WithEvents BtnMovaghat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label


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


#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabMovaghatSanadGhatee
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabMovaghatSanadGhatee
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabMovaghatSanadGhatee
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabMovaghatSanadGhatee)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dbcSanad = New NetSql.Components.DataCombo(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMovaghat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(583, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره و تاریخ سند :"
        '
        'dbcSanad
        '
        Me.dbcSanad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcSanad.AutoSelectFirst = False
        Me.dbcSanad.BackColor = System.Drawing.SystemColors.Info
        Me.dbcSanad.BoundText = Nothing
        Me.dbcSanad.BypassChangeEvent = False
        Me.dbcSanad.DisplayText = ""
        Me.dbcSanad.LateBindingTop = "100"
        Me.dbcSanad.Location = New System.Drawing.Point(136, 15)
        Me.dbcSanad.MemFilter = ""
        Me.dbcSanad.Name = "dbcSanad"
        Me.dbcSanad.SeparatedData = Nothing
        Me.dbcSanad.Size = New System.Drawing.Size(441, 22)
        Me.dbcSanad.Source = Nothing
        Me.dbcSanad.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcSanad.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(136, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 224)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات سند"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(542, 198)
        Me.Label2.TabIndex = 0
        '
        'BtnMovaghat
        '
        Me.BtnMovaghat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMovaghat.Location = New System.Drawing.Point(11, 2)
        Me.BtnMovaghat.Name = "BtnMovaghat"
        Me.BtnMovaghat.Size = New System.Drawing.Size(112, 52)
        Me.BtnMovaghat.TabIndex = 4
        Me.BtnMovaghat.Text = "موقت نمودن سند"
        Me.BtnMovaghat.UseVisualStyleBackColor = True
        '
        'FrmabMovaghatSanadGhatee
        '
        Me.ClientSize = New System.Drawing.Size(701, 287)
        Me.Controls.Add(Me.BtnMovaghat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dbcSanad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmabMovaghatSanadGhatee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "موقت نمودن اسناد قطعی"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Dim Dv As New DataView

    Private Sub FrmabMovaghatSanadGhatee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Str As String = "Select SanadSN, Cast(SanadNo as varchar) + '.' + tarakoneshds + '  ( '+SanadDate+' )' SanadNo From absanad " &
            " Join abtarakonesh on abtarakonesh.tarakoneshsn=absanad.tarakoneshsn " &
        "where Sanaddate>='" & gHesabdariSalFDate & "' And anbarsn=" & gAnbarSN.ToString & " And SanadStatus=8"
        dbcSanad.Bind(cn, Str, "SanadSN", "SanadNo")
    End Sub

    Private Sub dbcSanad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dbcSanad.SelectionChangeCommitted
        If dbcSanad.BoundText Is Nothing OrElse Not IsNumeric(dbcSanad.BoundText) Then
            Exit Sub
        End If


        Dv = cn.ExecuteQuery("Select * from absanad Join abtarakonesh On absanad.tarakoneshsn=abtarakonesh.tarakoneshsn " &
                                             "Where SanadSn=" & dbcSanad.BoundText)

        If Dv.Count > 0 Then
            Label2.Text = "تاریخ سند : " + Dv(0)("SanadDate").ToString + vbNewLine + vbNewLine +
            "تاریخ ثبت سند : " + Dv(0)("SabtDate").ToString + vbNewLine + vbNewLine +
            "ثبت کننده سند : " + Dv(0)("UserNameSabt").ToString + vbNewLine + vbNewLine +
            "تاریخ قطعی سازی سند : " + Dv(0)("TaeedDate").ToString + vbNewLine + vbNewLine +
            "قطعی کننده سند : " + Dv(0)("UserNameTaeed").ToString + vbNewLine + vbNewLine +
            "تراکنش : " + Dv(0)("TarakoneshDS").ToString
        Else
            Label2.Text = ""
        End If




    End Sub

    Private Sub BtnMovaghat_Click(sender As Object, e As EventArgs) Handles BtnMovaghat.Click

        If Not IsNumeric(dbcSanad.BoundText) Then
            CSystem.MsgBox("سندی انتخاب نشده است ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CSystem.MsgBox("آیا مایل به موقت نمودن سند شماره " + dbcSanad.Text + " می باشید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "موقت نمودن سند؟") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Dv.Count = 0 Then
            Dv = cn.ExecuteQuery("Select * from absanad Join abtarakonesh On absanad.tarakoneshsn=abtarakonesh.tarakoneshsn " &
                                             "Where SanadSn=" & dbcSanad.BoundText)
        End If

        If Dv.Count > 0 Then
            Dim Errmsg As String = ""
            Try
                cn.CallSP("_abSPC_Change_SanadStatus_GhateeToMovaghat", Dv(0)("SanadSN"), Dv(0)("TarakoneshSN"), Dv(0)("VahedeTejariSN"), Dv(0)("SanadDate").ToString.Trim, Errmsg)
            Catch ex As Exception
                Errmsg = Errmsg + vbNewLine + ex.Message
            End Try
            If Errmsg.Length > 0 Then
                CSystem.MsgBox("خطا در عملیات موقت سازی " + vbNewLine + vbNewLine + Errmsg, MsgBoxStyle.Exclamation, "موقت سازی سند")
            Else
                CSystem.MsgBox("عملیات موقت سازی با موفقیت انجام گردید", MsgBoxStyle.Information, "موقت سازی سند")
            End If
        Else
            CSystem.MsgBox("سندی انتخاب نشده است", MsgBoxStyle.Exclamation, "موقت سازی سند")
        End If


    End Sub
End Class
