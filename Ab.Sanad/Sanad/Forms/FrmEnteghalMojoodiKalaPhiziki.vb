''Add By Dehghani 981010
Imports Anbar.BRL

Public Class FrmEnteghalMojoodiKalaPhiziki
    Inherits Minoo.Base.FTBaseForm


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

#Region "Upgrade Support_For2Instance"

    Private Shared m_vb6formdefinstance As FrmEnteghalMojoodiKalaPhiziki
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl

    Friend WithEvents TabPage2 As TabPage

    Friend WithEvents Button1 As Button

    Friend WithEvents Label3 As Label

    Friend WithEvents TxtMojoodiAzRahgiri As TextBox

    Public WithEvents dbcAzRahgiri As NetSql.Components.DataCombo

    Friend WithEvents Label2 As Label

    Friend WithEvents Label1 As Label

    Public WithEvents dbcKala As NetSql.Components.DataCombo
    Friend WithEvents Label5 As Label

    Friend WithEvents TxtMojoodiToRahgiri As TextBox

    Public WithEvents dbcToRahgiri As NetSql.Components.DataCombo

    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label

    Friend WithEvents TxtTedadDarKarton As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ChkAutoBySysytem As CheckBox

    Friend WithEvents Label7 As Label

    Friend WithEvents TxtMeghdarKarton As TextBox
    Friend WithEvents LbVahedsanjesh As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents TxtMeghdarAdad As TextBox
    Friend WithEvents Label9 As Label

    Friend WithEvents TxtTozih As TextBox

    Public Shared Property DefInstance() As FrmEnteghalMojoodiKalaPhiziki

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmEnteghalMojoodiKalaPhiziki
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmEnteghalMojoodiKalaPhiziki)
            m_vb6formdefinstance = Value

        End Set

    End Property

#End Region

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTozih = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMeghdarAdad = New System.Windows.Forms.TextBox()
        Me.LbVahedsanjesh = New System.Windows.Forms.Label()
        Me.ChkAutoBySysytem = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMeghdarKarton = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTedadDarKarton = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMojoodiToRahgiri = New System.Windows.Forms.TextBox()
        Me.dbcToRahgiri = New NetSql.Components.DataCombo(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMojoodiAzRahgiri = New System.Windows.Forms.TextBox()
        Me.dbcAzRahgiri = New NetSql.Components.DataCombo(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dbcKala = New NetSql.Components.DataCombo(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(696, 225)
        Me.SplitContainer1.SplitterDistance = 115
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(696, 225)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtTozih)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TxtMeghdarAdad)
        Me.TabPage2.Controls.Add(Me.LbVahedsanjesh)
        Me.TabPage2.Controls.Add(Me.ChkAutoBySysytem)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtMeghdarKarton)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TxtTedadDarKarton)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TxtMojoodiToRahgiri)
        Me.TabPage2.Controls.Add(Me.dbcToRahgiri)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtMojoodiAzRahgiri)
        Me.TabPage2.Controls.Add(Me.dbcAzRahgiri)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dbcKala)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(688, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "انتقال موجودی"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(559, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 14)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "توضیحات سند انتقال : "
        '
        'TxtTozih
        '
        Me.TxtTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTozih.BackColor = System.Drawing.Color.White
        Me.TxtTozih.Location = New System.Drawing.Point(8, 164)
        Me.TxtTozih.Name = "TxtTozih"
        Me.TxtTozih.Size = New System.Drawing.Size(545, 22)
        Me.TxtTozih.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 14)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "عدد"
        '
        'TxtMeghdarAdad
        '
        Me.TxtMeghdarAdad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMeghdarAdad.BackColor = System.Drawing.Color.MintCream
        Me.TxtMeghdarAdad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMeghdarAdad.Location = New System.Drawing.Point(427, 126)
        Me.TxtMeghdarAdad.Name = "TxtMeghdarAdad"
        Me.TxtMeghdarAdad.Size = New System.Drawing.Size(60, 22)
        Me.TxtMeghdarAdad.TabIndex = 20
        '
        'LbVahedsanjesh
        '
        Me.LbVahedsanjesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbVahedsanjesh.AutoSize = True
        Me.LbVahedsanjesh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbVahedsanjesh.Location = New System.Drawing.Point(496, 129)
        Me.LbVahedsanjesh.Name = "LbVahedsanjesh"
        Me.LbVahedsanjesh.Size = New System.Drawing.Size(38, 14)
        Me.LbVahedsanjesh.TabIndex = 19
        Me.LbVahedsanjesh.Text = "کارتن"
        '
        'ChkAutoBySysytem
        '
        Me.ChkAutoBySysytem.AutoSize = True
        Me.ChkAutoBySysytem.Location = New System.Drawing.Point(8, 128)
        Me.ChkAutoBySysytem.Name = "ChkAutoBySysytem"
        Me.ChkAutoBySysytem.Size = New System.Drawing.Size(293, 18)
        Me.ChkAutoBySysytem.TabIndex = 18
        Me.ChkAutoBySysytem.Text = "رهگیری به صورت اتوماتیک توسط سیستم انتحاب شود"
        Me.ChkAutoBySysytem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 14)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "مفدار انتقال :"
        Me.ToolTip1.SetToolTip(Me.Label7, "(مقدار کارتن * تعداد در کارتن)  + مقدار عدد")
        '
        'TxtMeghdarKarton
        '
        Me.TxtMeghdarKarton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMeghdarKarton.BackColor = System.Drawing.Color.MintCream
        Me.TxtMeghdarKarton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMeghdarKarton.Location = New System.Drawing.Point(540, 126)
        Me.TxtMeghdarKarton.Name = "TxtMeghdarKarton"
        Me.TxtMeghdarKarton.Size = New System.Drawing.Size(60, 22)
        Me.TxtMeghdarKarton.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "تعداد در کارتن :"
        '
        'TxtTedadDarKarton
        '
        Me.TxtTedadDarKarton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTedadDarKarton.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTedadDarKarton.Location = New System.Drawing.Point(9, 6)
        Me.TxtTedadDarKarton.Name = "TxtTedadDarKarton"
        Me.TxtTedadDarKarton.ReadOnly = True
        Me.TxtTedadDarKarton.Size = New System.Drawing.Size(74, 22)
        Me.TxtTedadDarKarton.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "موجودی :"
        '
        'TxtMojoodiToRahgiri
        '
        Me.TxtMojoodiToRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMojoodiToRahgiri.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMojoodiToRahgiri.Location = New System.Drawing.Point(152, 43)
        Me.TxtMojoodiToRahgiri.Name = "TxtMojoodiToRahgiri"
        Me.TxtMojoodiToRahgiri.ReadOnly = True
        Me.TxtMojoodiToRahgiri.Size = New System.Drawing.Size(143, 22)
        Me.TxtMojoodiToRahgiri.TabIndex = 12
        '
        'dbcToRahgiri
        '
        Me.dbcToRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcToRahgiri.AutoSelectFirst = False
        Me.dbcToRahgiri.BackColor = System.Drawing.Color.White
        Me.dbcToRahgiri.BoundText = Nothing
        Me.dbcToRahgiri.BypassChangeEvent = False
        Me.dbcToRahgiri.DisplayText = ""
        Me.dbcToRahgiri.LateBindingTop = "100"
        Me.dbcToRahgiri.Location = New System.Drawing.Point(366, 43)
        Me.dbcToRahgiri.MemFilter = ""
        Me.dbcToRahgiri.Name = "dbcToRahgiri"
        Me.dbcToRahgiri.SeparatedData = Nothing
        Me.dbcToRahgiri.Size = New System.Drawing.Size(180, 22)
        Me.dbcToRahgiri.Source = Nothing
        Me.dbcToRahgiri.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcToRahgiri.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.dbcToRahgiri, "رهگیری که موجودی می بایست به آن منتقل شود")
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(552, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "به رهگیری (تاریخ انقضا) :"
        Me.ToolTip1.SetToolTip(Me.Label4, "رهگیری که موجودی می بایست به آن منتقل شود")
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(6, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "انتقال موجودی"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "موجودی :"
        '
        'TxtMojoodiAzRahgiri
        '
        Me.TxtMojoodiAzRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMojoodiAzRahgiri.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMojoodiAzRahgiri.Location = New System.Drawing.Point(151, 82)
        Me.TxtMojoodiAzRahgiri.Name = "TxtMojoodiAzRahgiri"
        Me.TxtMojoodiAzRahgiri.ReadOnly = True
        Me.TxtMojoodiAzRahgiri.Size = New System.Drawing.Size(144, 22)
        Me.TxtMojoodiAzRahgiri.TabIndex = 7
        '
        'dbcAzRahgiri
        '
        Me.dbcAzRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcAzRahgiri.AutoSelectFirst = False
        Me.dbcAzRahgiri.BackColor = System.Drawing.Color.White
        Me.dbcAzRahgiri.BoundText = Nothing
        Me.dbcAzRahgiri.BypassChangeEvent = False
        Me.dbcAzRahgiri.DisplayText = ""
        Me.dbcAzRahgiri.LateBindingTop = "100"
        Me.dbcAzRahgiri.Location = New System.Drawing.Point(366, 82)
        Me.dbcAzRahgiri.MemFilter = ""
        Me.dbcAzRahgiri.Name = "dbcAzRahgiri"
        Me.dbcAzRahgiri.SeparatedData = Nothing
        Me.dbcAzRahgiri.Size = New System.Drawing.Size(180, 22)
        Me.dbcAzRahgiri.Source = Nothing
        Me.dbcAzRahgiri.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcAzRahgiri.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.dbcAzRahgiri, "رهگیری های دارای موجودی")
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(552, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "از رهگیری (تاریخ انقضا) :"
        Me.ToolTip1.SetToolTip(Me.Label2, "رهگیری های دارای موجودی")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(649, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "کالا :"
        '
        'dbcKala
        '
        Me.dbcKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcKala.AutoSelectFirst = False
        Me.dbcKala.BackColor = System.Drawing.Color.White
        Me.dbcKala.BoundText = Nothing
        Me.dbcKala.BypassChangeEvent = False
        Me.dbcKala.DisplayText = ""
        Me.dbcKala.LateBindingTop = "100"
        Me.dbcKala.Location = New System.Drawing.Point(180, 6)
        Me.dbcKala.MemFilter = ""
        Me.dbcKala.Name = "dbcKala"
        Me.dbcKala.SeparatedData = Nothing
        Me.dbcKala.Size = New System.Drawing.Size(463, 22)
        Me.dbcKala.Source = Nothing
        Me.dbcKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcKala.TabIndex = 2
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.ReshowDelay = 100
        '
        'FrmEnteghalMojoodiKalaPhiziki
        '
        Me.ClientSize = New System.Drawing.Size(696, 225)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmEnteghalMojoodiKalaPhiziki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتقال موجودی رهگیری کالا"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
    Dim TarakoneshResid As Integer = IIf(CApp.GetAppConfig("gTarakoneshResidForEnteghlaMojoodi") Is System.DBNull.Value, 0, CApp.GetAppConfig("gTarakoneshResidForEnteghlaMojoodi"))
    Dim TarakoneshHavaleh As Integer = IIf(CApp.GetAppConfig("gTarakoneshHavalehForEnteghlaMojoodi") Is System.DBNull.Value, 0, CApp.GetAppConfig("gTarakoneshHavalehForEnteghlaMojoodi"))
    Dim _today As String = MiladiToShamsi(Today())
    Public KalaSN, KalaPhizikiSN As String



    Private Sub FrmEnteghalMojoodiKalaPhiziki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TarakoneshResid = 0 Or TarakoneshResid > 50 Then
            CSystem.MsgBox("تراکنش رسید " & TarakoneshResid.ToString & " صحیح نمی باشد")
            Exit Sub
        End If
        If TarakoneshHavaleh < 50 Then
            CSystem.MsgBox("تراکنش حواله " & TarakoneshHavaleh.ToString & " صحیح نمی باشد")
            Exit Sub
        End If
        ToolTip1.AutoPopDelay = 1000
        Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        LbVahedsanjesh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TxtMeghdarAdad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TxtMeghdarKarton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))



        dbcKala.Bind(cn, "Select Distinct Pakala.KalaSN,KalaNo+'.'+ KalaDS KalaDS " &
                            "From Pakala Join abSanadHa On abSanadHa.KalaSN=paKala.KalaSN  " &
                            "Join abSanad On abSanad.SanadSN=abSanadHa.SanadSN " &
                            "Where AnbarSN=" & gAnbarSN.ToString & " And SanadDate Between '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "'", "KalaSN", "KalaDS")
        If IsNumeric(KalaSN) Then
            dbcKala.BoundText = KalaSN
            dbcKala_SelectionChangeCommitted(sender, e)
        End If


        'If IsNumeric(KalaPhizikiSN) Then
        '    dbcToRahgiri.Bind(cn, "Select Distinct KalaPhizikiSN, ShomarehRahgiri From Pakala  " &
        '                            "Join abKalaPhiziki On abKalaPhiziki.KalaSn=paKala.KalaSN " &
        '                            "Where MoaserDate Between '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "' And paKala.KalaSN=" & dbcKala.BoundText, "KalaPhizikiSN", "ShomarehRahgiri")
        ''''ghasemi 14020504

        If IsNumeric(KalaPhizikiSN) Then
            dbcToRahgiri.Bind(cn, "Select Distinct KalaPhizikiSN,  ShomarehRahgiri+' ('+isnull(EnghezaDate,'')+')'  as ShomarehRahgiri From Pakala  " &
                                    "Join abKalaPhiziki On abKalaPhiziki.KalaSn=paKala.KalaSN " &
                                    "Where MoaserDate Between '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "' And paKala.KalaSN=" & dbcKala.BoundText, "KalaPhizikiSN", "ShomarehRahgiri")

            ''''ghasemi 14020504

            dbcToRahgiri.BoundText = KalaPhizikiSN
            dbcToRahgiri_GotFocus(sender, e)
        End If


    End Sub

    Private Sub dbcKala_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dbcKala.SelectionChangeCommitted

        If dbcKala.BoundText Is Nothing Then
            Exit Sub
        End If
        If IsNumeric(dbcKala.BoundText) Then

            Dim Dv As DataView = cn.ExecuteQuery("Select Isnull(TedadAjza,1) TedadAjza,VahedeSanjeshSN from paVw_VahedeSanjesh Where  KalaSN=" & dbcKala.BoundText)

            If Dv.Count > 0 Then
                TxtTedadDarKarton.Text = Dv(0)("TedadAjza").ToString
            Else
                TxtTedadDarKarton.Text = ""
            End If

            'dbcToRahgiri.Bind(cn, "Select Distinct KalaPhizikiSN, ShomarehRahgiri From Pakala  " &
            '                        "Join abKalaPhiziki On abKalaPhiziki.KalaSn=paKala.KalaSN " &
            '                        "Where MoaserDate Between '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "' And paKala.KalaSN=" & dbcKala.BoundText, "KalaPhizikiSN", "ShomarehRahgiri")
            ''''ghasemi 14020504

            dbcToRahgiri.Bind(cn, "Select Distinct KalaPhizikiSN,  ShomarehRahgiri +' ('+isnull(EnghezaDate,'')+')'  as ShomarehRahgiri From Pakala  " &
                                    "Join abKalaPhiziki On abKalaPhiziki.KalaSn=paKala.KalaSN " &
                                    "Where MoaserDate Between '" & gHesabdariSalFDate & "' And '" & gHesabdariSalTDate & "' And paKala.KalaSN=" & dbcKala.BoundText, "KalaPhizikiSN", "ShomarehRahgiri")
            ''''ghasemi 14020504
            '''
            If IsNumeric(KalaPhizikiSN) Then
                dbcToRahgiri.BoundText = KalaPhizikiSN
            End If
            ''shahabi
            Dim query As String
            query = "_abSPG_SelectRahgiri_ForEnteghalMojoudi " + CStr(gVahedeTejariSN) + "," + CStr(gAnbarSN) + "," +
                    CStr(gNoeAnbarSN) + "," + dbcKala.BoundText + ",'" + gHesabdariSalFDate + "','" + _today + "'," + CStr(TarakoneshHavaleh)
            'Dim diiv As DataView = cn.ExecuteQuery(query)

            dbcAzRahgiri.Bind(cn, query, "KalaPhizikiSN", "ShomarehRahgiri")

            TxtMojoodiAzRahgiri.Text = ""
            TxtMojoodiToRahgiri.Text = ""


            If CType(dbcAzRahgiri.DataSource, DataView).Count > 0 Then
                ChkAutoBySysytem.Visible = True
                Button1.Enabled = True
            Else
                ChkAutoBySysytem.Visible = False
                Button1.Enabled = False
            End If

        End If
    End Sub

    Private Sub dbcAzRahgiri_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dbcAzRahgiri.SelectionChangeCommitted
        If dbcAzRahgiri.BoundText Is Nothing Then
            Exit Sub
        End If

        If IsNumeric(dbcAzRahgiri.BoundText) Then


            Dim DvMojoodi As DataView = cn.ExecuteQuery("SELECT [dbo].[abFn_GetMojoodiKalaPhiziki] (" & gVahedeTejariSN.ToString & "  " &
                                                        "," & gAnbarSN.ToString & "  " &
                                                        "," & gNoeAnbarSN.ToString & "  " &
                                                        "," & dbcKala.BoundText & "  " &
                                                        "," & _today & "  " &
                                                        "," & dbcAzRahgiri.BoundText & ")")

            If DvMojoodi.Count > 0 Then
                TxtMojoodiAzRahgiri.Text = CInt(DvMojoodi(0)(0)).ToString + " عدد " + If(IsNumeric(TxtTedadDarKarton.Text), "- " + CInt(CDec(DvMojoodi(0)(0)) / CInt(TxtTedadDarKarton.Text)).ToString + " کارتن", "")
            Else
                TxtMojoodiAzRahgiri.Text = "0"
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If dbcAzRahgiri.BoundText Is Nothing Then
            CSystem.MsgBox("از رهگیری به درستی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            dbcAzRahgiri.BackColor = Color.OrangeRed
            Exit Sub
        End If

        If TxtMeghdarAdad.Text <> "" Then
            If Not IsNumeric(TxtMeghdarAdad.Text) Then
                CSystem.MsgBox("فرمت مقدار انتقال (عدد) صحیح نمی باشد ", MsgBoxStyle.Exclamation, "فرمت غیر عددی")
                Exit Sub
            End If
        End If

        If TxtMeghdarKarton.Text <> "" Then
            If Not IsNumeric(TxtMeghdarKarton.Text) Then
                CSystem.MsgBox("فرمت مقدار انتقال (کارتن) صحیح نمی باشد ", MsgBoxStyle.Exclamation, "فرمت غیر عددی")
                Exit Sub
            End If
            If Not IsNumeric(TxtTedadDarKarton.Text) Then
                CSystem.MsgBox("فرمت تعداد در کارتن عددی نیست ", MsgBoxStyle.Exclamation, "فرمت غیر عددی")
                Exit Sub
            End If
        End If

        If Not ChkAutoBySysytem.Checked Then
            If dbcToRahgiri.BoundText Is Nothing Then
                CSystem.MsgBox("به رهگیری به درستی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
                dbcToRahgiri.BackColor = Color.OrangeRed
                Exit Sub
            End If

            If dbcToRahgiri.BoundText = dbcAzRahgiri.BoundText Then
                CSystem.MsgBox("رهگیری یکسان انتخاب شده است", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        End If


        Dim Meghdar As Integer = (If(Not IsNumeric(TxtMeghdarKarton.Text), 0, CInt(TxtMeghdarKarton.Text)) * If(Not IsNumeric(TxtTedadDarKarton.Text), 0, CInt(TxtTedadDarKarton.Text))) + If(Not IsNumeric(TxtMeghdarAdad.Text), 0, CInt(TxtMeghdarAdad.Text))

        If Meghdar = 0 Then
            CSystem.MsgBox("مقدار انتقال مشخص نشده است ", MsgBoxStyle.Exclamation, "مقدار انتقال")
            Exit Sub
        End If

        If CSystem.MsgBox("آیا از انتقال موجودی از رهگیری " + If(ChkAutoBySysytem.Checked, "انتخابی سیستم", dbcAzRahgiri.Text) + " به رهگیری " + dbcToRahgiri.Text + " اطمینان دارید؟" +
                          vbNewLine + "مقدار انتقال : " +
                          If(Not IsNumeric(TxtMeghdarKarton.Text), "", CStr(TxtMeghdarKarton.Text) + " کارتن ") +
                          If(IsNumeric(TxtMeghdarAdad.Text) AndAlso IsNumeric(TxtMeghdarKarton.Text), "و ", "") +
                          If(Not IsNumeric(TxtMeghdarAdad.Text), "", CStr(TxtMeghdarAdad.Text) + " عدد") +
                          vbNewLine + If(TxtTozih.Text.Trim <> "", "توضیحات سند انتقال : " + TxtTozih.Text, ""), MsgBoxStyle.YesNo, dbcKala.Text) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim BRL As New ClsDataAccessRule
        Dim DoEneteghalMojoodi As String = ""
        Try


            DoEneteghalMojoodi = BRL.EnteghalMojoodiKalaPhiziki(cn, gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, TarakoneshResid, TarakoneshHavaleh,
                                                                CDec(dbcKala.BoundText), CDec(dbcAzRahgiri.BoundText), CDec(dbcToRahgiri.BoundText), Meghdar, TxtTozih.Text,
                                                                 ChkAutoBySysytem.Checked, gSM.UserID_Name, System.Windows.Forms.SystemInformation.ComputerName, gSM.UserID)

            CSystem.MsgBox(DoEneteghalMojoodi, If(DoEneteghalMojoodi.Contains("شماره حواله انتقال"), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "انتقال موجودی")

        Catch ex As Exception
            CSystem.MsgBox(DoEneteghalMojoodi + vbNewLine + ex.Message)
        End Try


    End Sub

    Private Sub dbcToRahgiri_GotFocus(sender As Object, e As EventArgs) Handles dbcToRahgiri.SelectionChangeCommitted

        If dbcToRahgiri.BoundText Is Nothing Then
            Exit Sub
        End If

        If IsNumeric(dbcToRahgiri.BoundText) Then

            Dim DvMojoodi As DataView = cn.ExecuteQuery("SELECT [dbo].[abFn_GetMojoodiKalaPhiziki] (" & gVahedeTejariSN.ToString & "  " &
                                                        "," & gAnbarSN.ToString & "  " &
                                                        "," & gNoeAnbarSN.ToString & "  " &
                                                        "," & dbcKala.BoundText & "  " &
                                                        "," & _today & "  " &
                                                        "," & dbcToRahgiri.BoundText & ")")


            If DvMojoodi.Count > 0 Then
                TxtMojoodiToRahgiri.Text = CInt(DvMojoodi(0)(0)).ToString + " عدد " + If(IsNumeric(TxtTedadDarKarton.Text), "- " + CInt(CDec(DvMojoodi(0)(0)) / CInt(TxtTedadDarKarton.Text)).ToString + " کارتن", "")
            Else
                TxtMojoodiToRahgiri.Text = "0"
            End If

        End If
    End Sub
End Class

