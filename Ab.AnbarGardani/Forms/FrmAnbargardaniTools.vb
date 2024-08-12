
'Author ::غفاری 
'CreateDate ::  1390/12/21
'System ::انبارگردانی

Option Strict Off
Option Explicit On

Friend Class FrmAnbargardaniTools
    Inherits Minoo.Base.FTBaseForm

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
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents dcbShomareshCopy As NetSql.Components.DataCombo
    Public WithEvents dcbShomareshMoghayer As NetSql.Components.DataCombo
    Friend WithEvents optAllKalaMojoodiMoghayer As System.Windows.Forms.RadioButton
    Friend WithEvents optCopyShomaresh As System.Windows.Forms.RadioButton
    Friend WithEvents optAllKalaAnbargardani As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents dcbShomareshMaghsad As NetSql.Components.DataCombo
    Friend WithEvents optMojoodiDar As System.Windows.Forms.RadioButton
    Friend WithEvents optGardeshDar As System.Windows.Forms.RadioButton
    Public WithEvents btnDarj As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optAllKalaAnbargardanimojoodidar As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OPTCopy12To3 As System.Windows.Forms.RadioButton
    Public WithEvents btnDarjKala As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtToolidDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEnghezaDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRahgiri As System.Windows.Forms.TextBox
    Friend WithEvents txtKalaNO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents optMoghayerShomareshbaMojoodi As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents ToolTip3 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.optMoghayerShomareshbaMojoodi = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OPTCopy12To3 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDarj = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.optAllKalaAnbargardanimojoodidar = New System.Windows.Forms.RadioButton()
        Me.optMojoodiDar = New System.Windows.Forms.RadioButton()
        Me.dcbShomareshMaghsad = New NetSql.Components.DataCombo(Me.components)
        Me.optGardeshDar = New System.Windows.Forms.RadioButton()
        Me.dcbShomareshCopy = New NetSql.Components.DataCombo(Me.components)
        Me.dcbShomareshMoghayer = New NetSql.Components.DataCombo(Me.components)
        Me.optAllKalaMojoodiMoghayer = New System.Windows.Forms.RadioButton()
        Me.optCopyShomaresh = New System.Windows.Forms.RadioButton()
        Me.optAllKalaAnbargardani = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDarjKala = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtToolidDate = New System.Windows.Forms.TextBox()
        Me.txtEnghezaDate = New System.Windows.Forms.TextBox()
        Me.txtRahgiri = New System.Windows.Forms.TextBox()
        Me.txtKalaNO = New System.Windows.Forms.TextBox()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel4)
        Me.GroupBox6.Controls.Add(Me.optMoghayerShomareshbaMojoodi)
        Me.GroupBox6.Controls.Add(Me.Panel3)
        Me.GroupBox6.Controls.Add(Me.Panel2)
        Me.GroupBox6.Controls.Add(Me.OPTCopy12To3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.btnDarj)
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.optAllKalaAnbargardanimojoodidar)
        Me.GroupBox6.Controls.Add(Me.optMojoodiDar)
        Me.GroupBox6.Controls.Add(Me.dcbShomareshMaghsad)
        Me.GroupBox6.Controls.Add(Me.optGardeshDar)
        Me.GroupBox6.Controls.Add(Me.dcbShomareshCopy)
        Me.GroupBox6.Controls.Add(Me.dcbShomareshMoghayer)
        Me.GroupBox6.Controls.Add(Me.optAllKalaMojoodiMoghayer)
        Me.GroupBox6.Controls.Add(Me.optCopyShomaresh)
        Me.GroupBox6.Controls.Add(Me.optAllKalaAnbargardani)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(868, 273)
        Me.GroupBox6.TabIndex = 103
        Me.GroupBox6.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel4.Location = New System.Drawing.Point(239, 140)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(624, 6)
        Me.Panel4.TabIndex = 112
        '
        'optMoghayerShomareshbaMojoodi
        '
        Me.optMoghayerShomareshbaMojoodi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optMoghayerShomareshbaMojoodi.Location = New System.Drawing.Point(514, 176)
        Me.optMoghayerShomareshbaMojoodi.Name = "optMoghayerShomareshbaMojoodi"
        Me.optMoghayerShomareshbaMojoodi.Size = New System.Drawing.Size(344, 26)
        Me.optMoghayerShomareshbaMojoodi.TabIndex = 111
        Me.optMoghayerShomareshbaMojoodi.Text = "کپی مغایرت بین داده های شمارش روبرو با موجودی" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.Location = New System.Drawing.Point(233, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 133)
        Me.Panel3.TabIndex = 110
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Location = New System.Drawing.Point(75, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(788, 5)
        Me.Panel2.TabIndex = 109
        '
        'OPTCopy12To3
        '
        Me.OPTCopy12To3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OPTCopy12To3.Location = New System.Drawing.Point(498, 239)
        Me.OPTCopy12To3.Name = "OPTCopy12To3"
        Me.OPTCopy12To3.Size = New System.Drawing.Size(359, 26)
        Me.OPTCopy12To3.TabIndex = 108
        Me.OPTCopy12To3.Text = "کپی مغایرت شمارش اول و دوم در شمارش سوم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "در شمارش مقصد"
        '
        'btnDarj
        '
        Me.btnDarj.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarj.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarj.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarj.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarj.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarj.Location = New System.Drawing.Point(7, 12)
        Me.btnDarj.Name = "btnDarj"
        Me.btnDarj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarj.Size = New System.Drawing.Size(65, 255)
        Me.btnDarj.TabIndex = 100
        Me.btnDarj.Text = "اجرای عملیات کپی"
        Me.btnDarj.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Location = New System.Drawing.Point(75, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 5)
        Me.Panel1.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 16)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "شمارش مقصد جهت کپی"
        '
        'optAllKalaAnbargardanimojoodidar
        '
        Me.optAllKalaAnbargardanimojoodidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAllKalaAnbargardanimojoodidar.Location = New System.Drawing.Point(397, 112)
        Me.optAllKalaAnbargardanimojoodidar.Name = "optAllKalaAnbargardanimojoodidar"
        Me.optAllKalaAnbargardanimojoodidar.Size = New System.Drawing.Size(460, 26)
        Me.optAllKalaAnbargardanimojoodidar.TabIndex = 93
        Me.optAllKalaAnbargardanimojoodidar.Text = "کپی کالاهاي موجودی دار از کالاهای فایل انبارگرداني در شمارش ..."
        '
        'optMojoodiDar
        '
        Me.optMojoodiDar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optMojoodiDar.Location = New System.Drawing.Point(540, 38)
        Me.optMojoodiDar.Name = "optMojoodiDar"
        Me.optMojoodiDar.Size = New System.Drawing.Size(317, 26)
        Me.optMojoodiDar.TabIndex = 86
        Me.optMojoodiDar.Text = "کپی کليه کالاهاي مانده دار در فایل انبارگردانی"
        '
        'dcbShomareshMaghsad
        '
        Me.dcbShomareshMaghsad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbShomareshMaghsad.AutoSelectFirst = False
        Me.dcbShomareshMaghsad.BackColor = System.Drawing.Color.White
        Me.dcbShomareshMaghsad.BoundText = Nothing
        Me.dcbShomareshMaghsad.BypassChangeEvent = False
        Me.dcbShomareshMaghsad.DisplayText = ""
        Me.dcbShomareshMaghsad.LateBindingTop = "100"
        Me.dcbShomareshMaghsad.Location = New System.Drawing.Point(77, 138)
        Me.dcbShomareshMaghsad.MemFilter = ""
        Me.dcbShomareshMaghsad.Name = "dcbShomareshMaghsad"
        Me.dcbShomareshMaghsad.SeparatedData = Nothing
        Me.dcbShomareshMaghsad.Size = New System.Drawing.Size(145, 24)
        Me.dcbShomareshMaghsad.Source = Nothing
        Me.dcbShomareshMaghsad.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbShomareshMaghsad.TabIndex = 95
        '
        'optGardeshDar
        '
        Me.optGardeshDar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optGardeshDar.Checked = True
        Me.optGardeshDar.Location = New System.Drawing.Point(552, 14)
        Me.optGardeshDar.Name = "optGardeshDar"
        Me.optGardeshDar.Size = New System.Drawing.Size(305, 26)
        Me.optGardeshDar.TabIndex = 87
        Me.optGardeshDar.TabStop = True
        Me.optGardeshDar.Text = "کپی کليه کالاهاي گردش دار در فایل انبارگردانی"
        '
        'dcbShomareshCopy
        '
        Me.dcbShomareshCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbShomareshCopy.AutoSelectFirst = False
        Me.dcbShomareshCopy.BackColor = System.Drawing.Color.White
        Me.dcbShomareshCopy.BoundText = Nothing
        Me.dcbShomareshCopy.BypassChangeEvent = False
        Me.dcbShomareshCopy.DisplayText = ""
        Me.dcbShomareshCopy.LateBindingTop = "100"
        Me.dcbShomareshCopy.Location = New System.Drawing.Point(204, 239)
        Me.dcbShomareshCopy.MemFilter = ""
        Me.dcbShomareshCopy.Name = "dcbShomareshCopy"
        Me.dcbShomareshCopy.SeparatedData = Nothing
        Me.dcbShomareshCopy.Size = New System.Drawing.Size(20, 24)
        Me.dcbShomareshCopy.Source = Nothing
        Me.dcbShomareshCopy.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbShomareshCopy.TabIndex = 91
        Me.dcbShomareshCopy.Visible = False
        '
        'dcbShomareshMoghayer
        '
        Me.dcbShomareshMoghayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbShomareshMoghayer.AutoSelectFirst = False
        Me.dcbShomareshMoghayer.BackColor = System.Drawing.Color.White
        Me.dcbShomareshMoghayer.BoundText = Nothing
        Me.dcbShomareshMoghayer.BypassChangeEvent = False
        Me.dcbShomareshMoghayer.DisplayText = ""
        Me.dcbShomareshMoghayer.LateBindingTop = "100"
        Me.dcbShomareshMoghayer.Location = New System.Drawing.Point(354, 165)
        Me.dcbShomareshMoghayer.MemFilter = ""
        Me.dcbShomareshMoghayer.Name = "dcbShomareshMoghayer"
        Me.dcbShomareshMoghayer.SeparatedData = Nothing
        Me.dcbShomareshMoghayer.Size = New System.Drawing.Size(154, 24)
        Me.dcbShomareshMoghayer.Source = Nothing
        Me.dcbShomareshMoghayer.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbShomareshMoghayer.TabIndex = 90
        '
        'optAllKalaMojoodiMoghayer
        '
        Me.optAllKalaMojoodiMoghayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAllKalaMojoodiMoghayer.Location = New System.Drawing.Point(588, 145)
        Me.optAllKalaMojoodiMoghayer.Name = "optAllKalaMojoodiMoghayer"
        Me.optAllKalaMojoodiMoghayer.Size = New System.Drawing.Size(269, 26)
        Me.optAllKalaMojoodiMoghayer.TabIndex = 89
        Me.optAllKalaMojoodiMoghayer.Text = "کپی کالا هاي موجودي دار مغاير با شمارش :"
        '
        'optCopyShomaresh
        '
        Me.optCopyShomaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optCopyShomaresh.Location = New System.Drawing.Point(257, 239)
        Me.optCopyShomaresh.Name = "optCopyShomaresh"
        Me.optCopyShomaresh.Size = New System.Drawing.Size(15, 26)
        Me.optCopyShomaresh.TabIndex = 92
        Me.optCopyShomaresh.Text = "کپی مقادیر شمارش شده در  شمارش  :"
        Me.optCopyShomaresh.Visible = False
        '
        'optAllKalaAnbargardani
        '
        Me.optAllKalaAnbargardani.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAllKalaAnbargardani.Location = New System.Drawing.Point(480, 82)
        Me.optAllKalaAnbargardani.Name = "optAllKalaAnbargardani"
        Me.optAllKalaAnbargardani.Size = New System.Drawing.Size(377, 26)
        Me.optAllKalaAnbargardani.TabIndex = 88
        Me.optAllKalaAnbargardani.Text = "کپی کل کالاهاي فایل انبارگرداني  در شمارش  ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(237, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "توجه !! در عملیات کپی اطلاعات قبلی پاک شده و اطلاعات درخواست شده جایگزین خواهد شد" &
    "."
        '
        'btnDarjKala
        '
        Me.btnDarjKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjKala.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjKala.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjKala.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjKala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjKala.Location = New System.Drawing.Point(6, 18)
        Me.btnDarjKala.Name = "btnDarjKala"
        Me.btnDarjKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjKala.Size = New System.Drawing.Size(119, 56)
        Me.btnDarjKala.TabIndex = 105
        Me.btnDarjKala.Text = "اضافه کردن کالا"
        Me.btnDarjKala.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtToolidDate)
        Me.GroupBox1.Controls.Add(Me.txtEnghezaDate)
        Me.GroupBox1.Controls.Add(Me.txtRahgiri)
        Me.GroupBox1.Controls.Add(Me.txtKalaNO)
        Me.GroupBox1.Controls.Add(Me.btnDarjKala)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Location = New System.Drawing.Point(10, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 80)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافه کردن کالا ی بدون گردش در انبار که در فایل انبار گردانی وجود ندارد به کالاها" &
    "ی انبار گردانی"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(138, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 16)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "مثال : 14001120"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(298, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "مثال :  14001120"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(479, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "مثال :   A1252"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(665, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "مثال :    30632673"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(220, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "تاریخ تولید :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(383, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "تاریخ انقضاء :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(580, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "رهگیری :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(791, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "کد کالا :"
        '
        'txtToolidDate
        '
        Me.txtToolidDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToolidDate.Location = New System.Drawing.Point(140, 44)
        Me.txtToolidDate.Name = "txtToolidDate"
        Me.txtToolidDate.Size = New System.Drawing.Size(79, 23)
        Me.txtToolidDate.TabIndex = 109
        '
        'txtEnghezaDate
        '
        Me.txtEnghezaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnghezaDate.Location = New System.Drawing.Point(304, 44)
        Me.txtEnghezaDate.Name = "txtEnghezaDate"
        Me.txtEnghezaDate.Size = New System.Drawing.Size(79, 23)
        Me.txtEnghezaDate.TabIndex = 108
        '
        'txtRahgiri
        '
        Me.txtRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRahgiri.Location = New System.Drawing.Point(469, 44)
        Me.txtRahgiri.Name = "txtRahgiri"
        Me.txtRahgiri.Size = New System.Drawing.Size(111, 23)
        Me.txtRahgiri.TabIndex = 107
        '
        'txtKalaNO
        '
        Me.txtKalaNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKalaNO.Location = New System.Drawing.Point(645, 44)
        Me.txtKalaNO.Name = "txtKalaNO"
        Me.txtKalaNO.Size = New System.Drawing.Size(145, 23)
        Me.txtKalaNO.TabIndex = 106
        '
        'FrmAnbargardaniTools
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(3, 29)
        Me.Name = "FrmAnbargardaniTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   کمک های سریع در عملیات انبارگردانی"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmAnbargardaniTools
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmAnbargardaniTools

        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAnbargardaniTools
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get

        Set(ByVal Value As FrmAnbargardaniTools)
            m_vb6FormDefInstance = Value
        End Set

    End Property

#End Region

    Private mAnbargardaniSn As Decimal
    Private EnghezaDateCtrl As NetSql.Components.CDateCtrl
    Private ToolidDateCtrl As NetSql.Components.CDateCtrl

    Public Property AnbargardaniSn() As Decimal

        Get
            AnbargardaniSn = mAnbargardaniSn
        End Get

        Set(ByVal Value As Decimal)
            mAnbargardaniSn = Value
        End Set

    End Property

    Private Sub dcbShomareshCopy_Enter(sender As Object, e As System.EventArgs) _
    Handles dcbShomareshCopy.Click

        Dim vSql As String
        If AnbargardaniSn <> 0 Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " & _
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(AnbargardaniSn)
            dcbShomareshCopy.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If
    End Sub

    Private Sub dcbShomareshMoghayer_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbShomareshMoghayer.Click

        Dim vSql As String

        If AnbargardaniSn <> 0 Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " & _
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(AnbargardaniSn)
            dcbShomareshMoghayer.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If
    End Sub

    Private Sub dcbShomareshMaghsad_Enter(sender As Object, e As System.EventArgs) _
        Handles dcbShomareshMaghsad.Enter
        Dim vSql As String
        If AnbargardaniSn <> 0 Then
            vSql = " SELECT ShomareshSN , ISNULL(ShomareshNO,'') + ' - ' + ShomareshDS AS ShomareshDS " & _
                   " FROM abShomaresh WHERE  AnbarGardaniSN =  " + CStr(AnbargardaniSn)
            dcbShomareshMaghsad.Bind(cn, vSql, "ShomareshSN", "ShomareshDS")
        End If

    End Sub

    Private Sub btnDarj_Click(sender As System.Object, e As System.EventArgs) _
      Handles btnDarj.Click
        Dim vErrMsg As String = ""
        Dim vToAnbargardaniOrShomareSh As Integer = 0
        Dim vAllkalaGardesh As Integer = 0
        Dim vAllkalamojoodi As Integer = 0
        Dim vTypeCopyShomaresh As Integer = 0
        Dim vCopyShomareshSN As Decimal = 0
        Dim vAllKalaMojoodiMoghayerSN As Decimal = 0
        Dim _msg As String = ""

        If optGardeshDar.Checked = True Or optMojoodiDar.Checked = True Then
            vToAnbargardaniOrShomareSh = 2
        Else
            vToAnbargardaniOrShomareSh = 1
        End If

        If optMojoodiDar.Checked = True Then
            vAllkalamojoodi = 1
            _msg = "عملیات مورد نظر: کپی کل کالاهای دارای موجودی سیستم به فایل انبار گردانی"
        ElseIf optGardeshDar.Checked = True Then
            vAllkalaGardesh = 1
            _msg = "عملیات مورد نظر: کپی کل کالاهای دارای گردش به فایل انبار گردانی"
        ElseIf optAllKalaAnbargardani.Checked = True Then
            'vAllkalaAnbargardani = 1
            vTypeCopyShomaresh = 1
            _msg = "عملیات مورد نظر: کپی کل کالاهای ثبت شده در فایل انبارگردانی به شمارش " + dcbShomareshMaghsad.Text
        ElseIf optAllKalaAnbargardanimojoodidar.Checked = True Then
            'vAllkalaAnbargardanimojoodi = 1
            vTypeCopyShomaresh = 2
            _msg = "عملیات مورد نظر: کپی کالاهای دارای موجودی از فایل انبارگردانی به شمارش " + dcbShomareshMaghsad.Text
        ElseIf optCopyShomaresh.Checked = True Then
            vTypeCopyShomaresh = 3
            If dcbShomareshCopy.BoundText = "" Then
                MsgBox("شمارش مورد نظر برای کپی انتخاب نشده است", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            Else
                vCopyShomareshSN = dcbShomareshCopy.BoundText
            End If
            _msg = "عملیات مورد نظر: کپی مقادیر ثبت شده در شمارش " + dcbShomareshCopy.Text + "  :به شمارش " + dcbShomareshMaghsad.Text
        ElseIf optAllKalaMojoodiMoghayer.Checked = True Then
            vTypeCopyShomaresh = 4
            If dcbShomareshMoghayer.BoundText = "" Then
                MsgBox("شمارش مورد نظر برای کپی مغایرت انتخاب نشده است", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            Else
                vAllKalaMojoodiMoghayerSN = dcbShomareshMoghayer.BoundText
            End If
            _msg = "عملیات مورد نظر: کپی کالاهای دارای موجودی و مغایر با شمارش " + dcbShomareshMoghayer.Text + "  :در شمارش " + dcbShomareshMaghsad.Text
        ElseIf OPTCopy12To3.Checked = True Then
            vTypeCopyShomaresh = 5
            _msg = "کپی مغایرت شمارش اول و دوم در شمارش سوم"
        ElseIf optMoghayerShomareshbaMojoodi.Checked = True Then
            vTypeCopyShomaresh = 6
            _msg = "عملیات مورد نظر: کپی مغایرت بین داده های وارد شده شمارش " + dcbShomareshMoghayer.Text + "  :با موجودی در شمارش " + dcbShomareshMaghsad.Text
        End If

        vCopyShomareshSN = dcbShomareshMoghayer.BoundText
        '''''''''''''''''''''''''''''''''''
        If NetSql.Common.CSystem.MsgBox(_msg + " آیا مایل به ادامه عملیات می باشید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        If AnbargardaniSn <> 0 Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If vToAnbargardaniOrShomareSh = 1 Then
                Dim vShomareshSN As Decimal = Val(dcbShomareshMaghsad.BoundText)
                If vShomareshSN = 0 And vTypeCopyShomaresh <> 5 Then
                    MsgBox("شمارش مقصد معتبر نمی باشد", MsgBoxStyle.OkOnly, "توجه")
                    Exit Sub
                End If

                cn.CallSP("_abSP_DarjKalaDarShomareshHa", _
                gAnbarSN, _
                AnbargardaniSn, _
                vShomareshSN, _
                gHesabdariSalFDate, _
                gHesabdariSalTDate, _
                vTypeCopyShomaresh, _
                vCopyShomareshSN, _
                vAllKalaMojoodiMoghayerSN, _
                gSM.Identifier, _
                gSM.UserID_Name, _
                vErrMsg)
                If vErrMsg <> "" Then
                    NetSql.Common.CSystem.MsgBox(vErrMsg, _
                               MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + _
                               MsgBoxStyle.MsgBoxRight, Me.Text)
                Else
                    MsgBox("عملیات با موفقیت انجام شد", MsgBoxStyle.OkOnly, "پیغام")
                End If
            ElseIf vToAnbargardaniOrShomareSh = 2 Then
                cn.CallSP("_abSP_Ins_abAnbarGardaniHa", gAnbarSN, gNoeAnbarSN, AnbargardaniSn, gHesabdariSalFDate, gHesabdariSalTDate, _
                        vAllkalaGardesh, vAllkalamojoodi, gSM.Identifier, gSM.UserID_Name, "", "")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub btnDarjKala_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnDarjKala.Click
        Dim vErrMsg As String = ""
        Dim Enghezadate, ToolidDate As String

        If AnbargardaniSn <> 0 Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim vShomareshSN As Decimal = Val(dcbShomareshMaghsad.BoundText)
            If txtKalaNO.Text = "" Then
                MsgBox("کد کالا معتبر نمی باشد", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            End If
            If txtRahgiri.Text = "" Then
                MsgBox("کد رهگیری معتبر نمی باشد", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            End If
            If Len(txtEnghezaDate.Text) > 0 And Len(txtEnghezaDate.Text) <> 10 Then
                MsgBox("تاریخ انقضاء معتبر نمی باشد", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            Else
                Enghezadate = NetSql.Common.CShamsiDate.FormatDate(txtEnghezaDate.Text, EnumDateFormat.dfDefault)
            End If
            If Len(txtToolidDate.Text) > 0 And Len(txtToolidDate.Text) <> 10 Then
                MsgBox("تاریخ تولید معتبر نمی باشد", MsgBoxStyle.OkOnly, "توجه")
                Exit Sub
            Else
                ToolidDate = NetSql.Common.CShamsiDate.FormatDate(txtToolidDate.Text, EnumDateFormat.dfDefault)
            End If

            cn.CallSP("_abSpC_AddKalaRahgiriToAnbargardani", _
                AnbargardaniSn, _
                txtKalaNO.Text, _
                txtRahgiri.Text, _
                Enghezadate, _
                ToolidDate, _
                gHesabdariSalTDate, _
                gSM.UserID_Name, _
                vErrMsg)
            If vErrMsg <> "" Then
                NetSql.Common.CSystem.MsgBox(vErrMsg, _
                           MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + _
                           MsgBoxStyle.MsgBoxRight, Me.Text)
            Else
                MsgBox("عملیات با موفقیت انجام شد", MsgBoxStyle.OkOnly, "پیغام")
            End If
        Else
            MsgBox("فایل انبار گردانی انتخاب شده معتبر نمی باشد", MsgBoxStyle.OkOnly, "پیغام")
        End If

    End Sub

    Private Sub optGardeshDar_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optGardeshDar.CheckedChanged
        If optGardeshDar.Checked = True Then
            dcbShomareshMaghsad.Enabled = False
            dcbShomareshMoghayer.Enabled = False
        End If
    End Sub

    Private Sub optMojoodiDar_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optMojoodiDar.CheckedChanged
        If optMojoodiDar.Checked = True Then
            dcbShomareshMaghsad.Enabled = False
            dcbShomareshMoghayer.Enabled = False
        End If
    End Sub

    Private Sub optAllKalaAnbargardani_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optAllKalaAnbargardani.CheckedChanged
        If optAllKalaAnbargardani.Checked = True Then
            dcbShomareshMaghsad.Enabled = True
            dcbShomareshMoghayer.Enabled = False
        End If
    End Sub

    Private Sub optAllKalaAnbargardanimojoodidar_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optAllKalaAnbargardanimojoodidar.CheckedChanged
        If optAllKalaAnbargardanimojoodidar.Checked = True Then
            dcbShomareshMaghsad.Enabled = True
            dcbShomareshMoghayer.Enabled = False
        End If
    End Sub

    Private Sub optCopyShomaresh_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optCopyShomaresh.CheckedChanged
        If optCopyShomaresh.Checked = True Then
            dcbShomareshMaghsad.Enabled = True
        End If
    End Sub

    Private Sub optAllKalaMojoodiMoghayer_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optAllKalaMojoodiMoghayer.CheckedChanged
        If optAllKalaMojoodiMoghayer.Checked = True Then
            dcbShomareshMaghsad.Enabled = True
            dcbShomareshMoghayer.Enabled = True
        End If
    End Sub

    Private Sub OPTCopy12To3_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles OPTCopy12To3.CheckedChanged
        If OPTCopy12To3.Checked = True Then
            dcbShomareshMaghsad.Enabled = False
            dcbShomareshMoghayer.Enabled = False
        End If

    End Sub

    Private Sub FrmAnbargardaniTools_Load(sender As System.Object, e As System.EventArgs) _
 Handles MyBase.Load
        EnghezaDateCtrl = New NetSql.Components.CDateCtrl(tp)
        EnghezaDateCtrl.TextBox = txtEnghezaDate
        EnghezaDateCtrl.DateFormat = EnumDateFormat.dfFullYear

        ToolidDateCtrl = New NetSql.Components.CDateCtrl(tp)
        ToolidDateCtrl.TextBox = txtToolidDate
        ToolidDateCtrl.DateFormat = EnumDateFormat.dfFullYear


    End Sub

    Private Sub optMoghayerShomareshbaMojoodi_CheckedChanged(sender As System.Object, e As System.EventArgs) _
        Handles optMoghayerShomareshbaMojoodi.CheckedChanged

        If optMoghayerShomareshbaMojoodi.Checked = True Then
            dcbShomareshMaghsad.Enabled = True
            dcbShomareshMoghayer.Enabled = True
        End If

    End Sub
End Class
