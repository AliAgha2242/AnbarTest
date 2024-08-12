Public Class FrmCopySanad
    Inherits Minoo.Base.FTBaseForm

    Public Sub New()
        MyBase.New()
        'If m_vb6FormDefInstance Is Nothing Then
        '  If m_InitializingDefInstance Then
        '    m_vb6FormDefInstance = Me
        '  Else
        '    Try
        '      If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
        '        m_vb6FormDefInstance = Me
        '      End If
        '    Catch
        '    End Try
        '  End If
        'End If
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

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmCopySanad
    Private Shared m_initializingdefinstance As Boolean

    Public Shared Property DefInstance() As FrmCopySanad

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmCopySanad
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmCopySanad)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region



    Friend WithEvents Label1 As Label
    Public WithEvents dbcSanad As NetSql.Components.DataCombo
    Private components As System.ComponentModel.IContainer
    Public WithEvents dbcTarakonesh As NetSql.Components.DataCombo
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCopy As Button

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.dbcSanad = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTarakonesh = New NetSql.Components.DataCombo(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(643, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره سند مرجع جهت اجرای عملیات کپی :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(شماره سند + تراکنش + شماره ارجاع + تاریخ " &
    "سند)"
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(12, 6)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(75, 59)
        Me.BtnCopy.TabIndex = 1
        Me.BtnCopy.Text = "کپی سند"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'dbcSanad
        '
        Me.dbcSanad.AutoSelectFirst = False
        Me.dbcSanad.BackColor = System.Drawing.Color.White
        Me.dbcSanad.BoundText = Nothing
        Me.dbcSanad.BypassChangeEvent = False
        Me.dbcSanad.DisplayText = ""
        Me.dbcSanad.LateBindingTop = "100"
        Me.dbcSanad.Location = New System.Drawing.Point(96, 42)
        Me.dbcSanad.MemFilter = ""
        Me.dbcSanad.Name = "dbcSanad"
        Me.dbcSanad.SeparatedData = Nothing
        Me.dbcSanad.Size = New System.Drawing.Size(562, 22)
        Me.dbcSanad.Source = Nothing
        Me.dbcSanad.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcSanad.TabIndex = 2
        '
        'dbcTarakonesh
        '
        Me.dbcTarakonesh.AutoSelectFirst = False
        Me.dbcTarakonesh.BackColor = System.Drawing.Color.White
        Me.dbcTarakonesh.BoundText = Nothing
        Me.dbcTarakonesh.BypassChangeEvent = False
        Me.dbcTarakonesh.DisplayText = ""
        Me.dbcTarakonesh.LateBindingTop = "100"
        Me.dbcTarakonesh.Location = New System.Drawing.Point(96, 6)
        Me.dbcTarakonesh.MemFilter = ""
        Me.dbcTarakonesh.Name = "dbcTarakonesh"
        Me.dbcTarakonesh.SeparatedData = Nothing
        Me.dbcTarakonesh.Size = New System.Drawing.Size(562, 22)
        Me.dbcTarakonesh.Source = Nothing
        Me.dbcTarakonesh.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarakonesh.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(664, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "تراکنش سند مقصد :"
        '
        'FrmCopySanad
        '
        Me.ClientSize = New System.Drawing.Size(948, 87)
        Me.Controls.Add(Me.dbcTarakonesh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dbcSanad)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCopySanad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "کپی سند"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub FrmCopySanad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcTarakonesh.Bind(cn, "select Distinct  abTarakonesh.TarakoneshSN,TarakoneshNo + '.' + TarakoneshDs As TarakoneshDS from abAnbarTarakonesh " &
                           "join abTarakonesh on abTarakonesh.TarakoneshSN=abAnbarTarakonesh.TarakoneshSN " &
                           "where AnbarTarakoneshStatus=1 And MaxDateDoreh>='" & gHesabdariSalFDate.Trim.Substring(0, 4) & "1229' And AnbarSN=" & gAnbarSN.ToString, "TarakoneshSN", "TarakoneshDS")


        dbcSanad.Bind(cn, "Select Distinct SanadSN,ISNULL(Cast(SanadNo As varchar),'سند پیشنویس یا موقت') +'.' + TarakoneshDS + ISNULL( ' (شماره ارجاع : '+ shomarehSefaresh +')','') + ' (' + SanadDate+ ')' SanadDS " &
                      "from absanad Join abAnbarTarakonesh On abAnbarTarakonesh.TarakoneshSN=abSanad.tarakoneshSN " &
                      "Join abtarakonesh On abtarakonesh.tarakoneshSN=absanad.TarakoneshSN " &
                      "Where SanadDate>='" & gHesabdariSalFDate.Trim & "' And absanad.anbarSN=" & gAnbarSN.ToString & " And AnbarTarakoneshStatus=1 And MaxDateDoreh>='" & gHesabdariSalFDate.Trim.Substring(0, 4) & "1229'", "SanadSN", "SanadDS")
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click

        If Not IsNumeric(dbcSanad.BoundText) Then
            CSystem.MsgBox("فرمت سند مرجع انتخابی صحیح نمی باشد", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If Not IsNumeric(dbcTarakonesh.BoundText) Then
            CSystem.MsgBox("فرمت تراکنش سند مقصد صحیح نمی باشد", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim Dv As DataView = cn.ExecuteQuery("Select  count(*) from abSanadHa where sanadSN=" & dbcSanad.BoundText)

        Dim Cnt As Integer = IIf(Dv Is Nothing, 0, Dv(0)(0))
        If NetSql.Common.CSystem.MsgBox("با ادامه عملیات " + dbcTarakonesh.Text.Substring(dbcTarakonesh.Text.IndexOf(".") + 1, dbcTarakonesh.Text.Length - (dbcTarakonesh.Text.IndexOf(".") + 1)) + " با < " + Cnt.ToString + " > ردیف اقلام در سیستم درج خواهد شد." + vbNewLine +
                                        If(CInt(dbcTarakonesh.BoundText) > 50, "همچنین " + dbcSanad.Text + " قطعی خواهد شد", "") + vbNewLine +
                                        "آیا مایل به ادامه عملیات هستید؟", MsgBoxStyle.YesNo, "درج سند") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            cn.CallSP("abSPC_CopySanadFromSanad", CDec(dbcSanad.BoundText), CDec(dbcTarakonesh.BoundText), gSM.UserID, gSM.UserID_Name)
            CSystem.MsgBox("عملیات با موفقیت انجام شد", MsgBoxStyle.Information, "")
        Catch ex As Exception
            CSystem.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "خطا")
        End Try
    End Sub

    Private Sub dbcTarakonesh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dbcTarakonesh.SelectedIndexChanged
        If IsNumeric(dbcTarakonesh.BoundText) Then
            If CInt(dbcTarakonesh.BoundText) > 50 Then
                dbcSanad.Bind(cn, "Select Distinct SanadSN,ISNULL(Cast(SanadNo As varchar),'رسید پیشنویس یا موقت') +'.' + TarakoneshDS + ISNULL( ' (شماره ارجاع : '+ shomarehSefaresh +')','') + ' (' + SanadDate+ ')' SanadDS " &
                          "from absanad Join abAnbarTarakonesh On abAnbarTarakonesh.TarakoneshSN=abSanad.tarakoneshSN " &
                          "Join abtarakonesh On abtarakonesh.tarakoneshSN=absanad.TarakoneshSN " &
                          "Where SanadDate>='" & gHesabdariSalFDate.Trim & "' And SanadStatus<>8 And abSanad.TarakoneshSN<50 And absanad.anbarSN=" & gAnbarSN.ToString & " And AnbarTarakoneshStatus=1 And MaxDateDoreh>='" & gHesabdariSalFDate.Trim.Substring(0, 4) & "1229'", "SanadSN", "SanadDS")
            Else
                dbcSanad.Bind(cn, "Select Distinct SanadSN,ISNULL(Cast(SanadNo As varchar),'وضعیت سند پیشنویس یا موقت') +'.' + TarakoneshDS + ISNULL( ' (شماره ارجاع : '+ shomarehSefaresh +')','') + ' (' + SanadDate+ ')' SanadDS " &
                      "from absanad Join abAnbarTarakonesh On abAnbarTarakonesh.TarakoneshSN=abSanad.tarakoneshSN " &
                      "Join abtarakonesh On abtarakonesh.tarakoneshSN=absanad.TarakoneshSN " &
                      "Where SanadDate>='" & gHesabdariSalFDate.Trim & "' And  absanad.anbarSN=" & gAnbarSN.ToString & " And AnbarTarakoneshStatus=1 And MaxDateDoreh>='" & gHesabdariSalFDate.Trim.Substring(0, 4) & "1229'", "SanadSN", "SanadDS")
            End If
        End If

    End Sub
End Class
