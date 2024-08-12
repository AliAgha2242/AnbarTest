' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/03/05 Start 18:24
'ModifiedDate::
'Description:: كنترل كيفيت  محموله هاي وارده به انبار توسط اين فرم بررسي کنترل کيفيت شده و نتيجه ثيت ميگردد
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic
Imports System.Data
Imports Mail = System.Net.Mail
Imports NetSql.View
Imports NetSql.Common.CShamsiDate

Friend Class FrmQC
    Inherits Minoo.Base.FTBaseForm


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
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents btnToShamsiDate As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtShamsi As System.Windows.Forms.TextBox
    Public WithEvents txtMiladi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbNoeTarakoneshKala As cmpCheckedComboBox
    Public WithEvents BtnVeiw As System.Windows.Forms.Button
    Public WithEvents sstChild As Minoo.Controls.FTTabControl
    Public WithEvents _sstChild_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents pnlNavigationDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet1 As System.Windows.Forms.Panel
    Public WithEvents _sstChild_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents pnlGridDet2 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet2 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationDet2 As System.Windows.Forms.Panel
    Public WithEvents Label10 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CmbNoeTarakoneshKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.btnToShamsiDate = New System.Windows.Forms.Button()
        Me.txtShamsi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMiladi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVeiw = New System.Windows.Forms.Button()
        Me.CmbNoeTarakoneshKala = New cmpCheckedComboBox(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sstChild = New Minoo.Controls.FTTabControl()
        Me._sstChild_TabPage0 = New System.Windows.Forms.TabPage()
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel()
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel()
        Me.pnlGridDet1 = New System.Windows.Forms.Panel()
        Me._sstChild_TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlGridDet2 = New System.Windows.Forms.Panel()
        Me.pnlCommandDet2 = New System.Windows.Forms.Panel()
        Me.pnlNavigationDet2 = New System.Windows.Forms.Panel()
        Me.Frame1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.sstChild.SuspendLayout()
        Me._sstChild_TabPage0.SuspendLayout()
        Me._sstChild_TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(2, 51)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(857, 154)
        Me.pnlGridMaster.TabIndex = 2
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(2, 209)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(440, 32)
        Me.pnlNavigationMaster.TabIndex = 1
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(445, 209)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(412, 32)
        Me.pnlCommandMaster.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(857, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Tag = ""
        Me.Label1.Text = "كالاي فيزيكي"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frame1.Controls.Add(Me.btnToShamsiDate)
        Me.Frame1.Controls.Add(Me.txtShamsi)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.txtMiladi)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(2, 245)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(395, 34)
        Me.Frame1.TabIndex = 36
        '
        'btnToShamsiDate
        '
        Me.btnToShamsiDate.BackColor = System.Drawing.SystemColors.Control
        Me.btnToShamsiDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnToShamsiDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnToShamsiDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnToShamsiDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnToShamsiDate.Location = New System.Drawing.Point(92, 5)
        Me.btnToShamsiDate.Name = "btnToShamsiDate"
        Me.btnToShamsiDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnToShamsiDate.Size = New System.Drawing.Size(97, 23)
        Me.btnToShamsiDate.TabIndex = 2
        Me.btnToShamsiDate.Tag = ""
        Me.btnToShamsiDate.Text = "به تاريخ شمسي"
        Me.btnToShamsiDate.UseVisualStyleBackColor = False
        '
        'txtShamsi
        '
        Me.txtShamsi.AcceptsReturn = True
        Me.txtShamsi.BackColor = System.Drawing.SystemColors.Window
        Me.txtShamsi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShamsi.Enabled = False
        Me.txtShamsi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShamsi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShamsi.Location = New System.Drawing.Point(10, 7)
        Me.txtShamsi.MaxLength = 0
        Me.txtShamsi.Name = "txtShamsi"
        Me.txtShamsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShamsi.Size = New System.Drawing.Size(74, 21)
        Me.txtShamsi.TabIndex = 1
        Me.txtShamsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(275, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "تاريخ ميلادي"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMiladi
        '
        Me.txtMiladi.AcceptsReturn = True
        Me.txtMiladi.BackColor = System.Drawing.SystemColors.Window
        Me.txtMiladi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiladi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMiladi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMiladi.Location = New System.Drawing.Point(194, 7)
        Me.txtMiladi.MaxLength = 0
        Me.txtMiladi.Name = "txtMiladi"
        Me.txtMiladi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMiladi.Size = New System.Drawing.Size(74, 21)
        Me.txtMiladi.TabIndex = 0
        Me.txtMiladi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(344, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "تبديل"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnVeiw)
        Me.GroupBox1.Controls.Add(Me.CmbNoeTarakoneshKala)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 37)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'BtnVeiw
        '
        Me.BtnVeiw.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVeiw.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnVeiw.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnVeiw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVeiw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVeiw.Location = New System.Drawing.Point(17, 11)
        Me.BtnVeiw.Name = "BtnVeiw"
        Me.BtnVeiw.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnVeiw.Size = New System.Drawing.Size(97, 23)
        Me.BtnVeiw.TabIndex = 187
        Me.BtnVeiw.Tag = ""
        Me.BtnVeiw.Text = "مشاهده"
        Me.BtnVeiw.UseVisualStyleBackColor = False
        '
        'CmbNoeTarakoneshKala
        '
        Me.CmbNoeTarakoneshKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbNoeTarakoneshKala_DesignTimeLayout.LayoutString = resources.GetString("CmbNoeTarakoneshKala_DesignTimeLayout.LayoutString")
        Me.CmbNoeTarakoneshKala.DesignTimeLayout = CmbNoeTarakoneshKala_DesignTimeLayout
        Me.CmbNoeTarakoneshKala.LateBinding = True
        Me.CmbNoeTarakoneshKala.LateBindingTop = "100"
        Me.CmbNoeTarakoneshKala.Location = New System.Drawing.Point(150, 11)
        Me.CmbNoeTarakoneshKala.Name = "CmbNoeTarakoneshKala"
        Me.CmbNoeTarakoneshKala.SaveSettings = False
        Me.CmbNoeTarakoneshKala.ShowSelectAll = True
        Me.CmbNoeTarakoneshKala.Size = New System.Drawing.Size(166, 23)
        Me.CmbNoeTarakoneshKala.TabIndex = 186
        Me.CmbNoeTarakoneshKala.ValuesDataMember = Nothing
        Me.CmbNoeTarakoneshKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(322, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(116, 14)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "وضعیت کنترل کیفیت :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Controls.Add(Me.pnlGridMaster)
        Me.Panel1.Controls.Add(Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add(Me.pnlCommandMaster)
        Me.Panel1.Controls.Add(Me.sstChild)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 546)
        Me.Panel1.TabIndex = 38
        '
        'sstChild
        '
        Me.sstChild.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstChild.Controls.Add(Me._sstChild_TabPage0)
        Me.sstChild.Controls.Add(Me._sstChild_TabPage1)
        Me.sstChild.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstChild.ItemSize = New System.Drawing.Size(42, 18)
        Me.sstChild.Location = New System.Drawing.Point(1, 282)
        Me.sstChild.Name = "sstChild"
        Me.sstChild.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sstChild.RightToLeftLayout = True
        Me.sstChild.SelectedIndex = 0
        Me.sstChild.Size = New System.Drawing.Size(860, 263)
        Me.sstChild.TabIndex = 4
        Me.sstChild.TabStop = False
        '
        '_sstChild_TabPage0
        '
        Me._sstChild_TabPage0.Controls.Add(Me.pnlNavigationDet1)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlCommandDet1)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlGridDet1)
        Me._sstChild_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._sstChild_TabPage0.Name = "_sstChild_TabPage0"
        Me._sstChild_TabPage0.Size = New System.Drawing.Size(852, 237)
        Me._sstChild_TabPage0.TabIndex = 0
        Me._sstChild_TabPage0.Text = "تراكنش كالا"
        '
        'pnlNavigationDet1
        '
        Me.pnlNavigationDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet1.Location = New System.Drawing.Point(2, 203)
        Me.pnlNavigationDet1.Name = "pnlNavigationDet1"
        Me.pnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet1.Size = New System.Drawing.Size(438, 32)
        Me.pnlNavigationDet1.TabIndex = 8
        '
        'pnlCommandDet1
        '
        Me.pnlCommandDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet1.Location = New System.Drawing.Point(446, 203)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size(410, 32)
        Me.pnlCommandDet1.TabIndex = 9
        '
        'pnlGridDet1
        '
        Me.pnlGridDet1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet1.Location = New System.Drawing.Point(4, 5)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size(844, 195)
        Me.pnlGridDet1.TabIndex = 10
        '
        '_sstChild_TabPage1
        '
        Me._sstChild_TabPage1.Controls.Add(Me.pnlGridDet2)
        Me._sstChild_TabPage1.Controls.Add(Me.pnlCommandDet2)
        Me._sstChild_TabPage1.Controls.Add(Me.pnlNavigationDet2)
        Me._sstChild_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._sstChild_TabPage1.Name = "_sstChild_TabPage1"
        Me._sstChild_TabPage1.Size = New System.Drawing.Size(852, 237)
        Me._sstChild_TabPage1.TabIndex = 1
        Me._sstChild_TabPage1.Text = "مشاهده اسناد"
        '
        'pnlGridDet2
        '
        Me.pnlGridDet2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet2.Location = New System.Drawing.Point(14, 11)
        Me.pnlGridDet2.Name = "pnlGridDet2"
        Me.pnlGridDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet2.Size = New System.Drawing.Size(833, 168)
        Me.pnlGridDet2.TabIndex = 7
        '
        'pnlCommandDet2
        '
        Me.pnlCommandDet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet2.Location = New System.Drawing.Point(437, 207)
        Me.pnlCommandDet2.Name = "pnlCommandDet2"
        Me.pnlCommandDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet2.Size = New System.Drawing.Size(403, 22)
        Me.pnlCommandDet2.TabIndex = 6
        '
        'pnlNavigationDet2
        '
        Me.pnlNavigationDet2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet2.Location = New System.Drawing.Point(10, 207)
        Me.pnlNavigationDet2.Name = "pnlNavigationDet2"
        Me.pnlNavigationDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet2.Size = New System.Drawing.Size(406, 22)
        Me.pnlNavigationDet2.TabIndex = 5
        '
        'FrmQC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(862, 546)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmQC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "كنترل كيفيت"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.sstChild.ResumeLayout(False)
        Me._sstChild_TabPage0.ResumeLayout(False)
        Me._sstChild_TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmQC
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmQC
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmQC
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmQC)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region


    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي فيزيکي تعريف شده است
    Private WithEvents DVabKalaPhiziki As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  تراکنش کالا تعريف شده است
    Private WithEvents DVabTarakoneshKala As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  اسناد انبار مرتبط تعريف شده است
    Private WithEvents DVabVw_SanadAnbar As CDataView

    '   براي نمايش تاريخ در فيلتر 
    Private pDateCtrlMiladi As NetSql.Components.CDateCtrl
    '   براي نمايش تاريخ در فيلتر 
    Private pDateCtrlShamsi As NetSql.Components.CDateCtrl

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dbcNoeTarakoneshKalaSN As NetSql.Components.DataCombo
    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dbcKalaSN As NetSql.Components.DataCombo

    ' جهت مشخص شدن نوع ورود اطلاعات در سطح فرم براي انبارجاري     واحدسنجش    تعداد درکارتن
    Private pNoeVoroodeAsnad As EnumNoeVoroodeAsnad

    ' شرط پيش فرض کالا فيزيکي را در عمليات نگهداري ميکند
    Private pDVabKalaPhiziki_SQLWhere As String


    Private Sub DVabKalaPhiziki_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabKalaPhiziki.FillDetailsWithData
        ' هنگام پر شدن رکورد در کالافيزيکي شرط اطلاعات در گريد پايين تنظيم ميگردد  گريد اسناد انبار
        If aFetched Then
            pNoeVoroodeAsnad = gNoeVoroodeAsnadSN
            'Val(DVabKalaPhiziki.Fields("NoeVoroodeAsnadSN").Value)'Izadpanah***860708
            With DVabVw_SanadAnbar
                .SQLWhere = " AnbarSN = " & gAnbarSN & " AND KalaPhizikiSN = " & _
                            DVabKalaPhiziki.Fields("KalaPhizikiSN").Value
                .Refresh()
            End With
        End If
    End Sub

    Private Sub DVabTarakoneshKala_AfterCommandClick(ByVal aCommand As EnumCommands) _
        Handles DVabTarakoneshKala.AfterCommandClick
        Static vcmAdd As Boolean
        DVabTarakoneshKala.Fields("NoeTarakoneshKalaSN").ReadOnly = False
        Select Case aCommand
            Case EnumCommands.cmEdit
                vcmAdd = False
                DVabTarakoneshKala.Fields("NoeTarakoneshKalaSN").ReadOnly = True
                DVabTarakoneshKala.Fields("NoeGharantinehSN").ReadOnly = True
                ' select * from paNoeTarakoneshKala
                '1.935	قرنطينه
                '2.935	تاييد
                '3.935	رد
                '4.935	مصرف مشروط
                ' در صورت اينکه نوع تراکنش کالا قرنطينه بود کاربر بتواند نوع قرنطينه را انتخاب نمايد
                If DVabTarakoneshKala.Fields("NoeTarakoneshKalaSN").Value.ToString = "1.935" Then
                    DVabTarakoneshKala.Fields("NoeGharantinehSN").ReadOnly = False
                End If

            Case EnumCommands.cmAdd
                vcmAdd = True
            Case EnumCommands.cmSave

                '''Add By Dehghani 921219 - ارسال ایمیل اتوماتیک تغییر تراکنش کنترل کیفیت به افراد تعریف شده در مدیریت اطلاعات

                Dim gSendEmailQcStatus As String
                Try
                    Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
                    gSendEmailQcStatus = IIf(CAppSet.GetAppConfig("gSendEmailQcStatus") Is System.DBNull.Value, "", CAppSet.GetAppConfig("gSendEmailQcStatus"))
                Catch ex As Exception
                End Try

                Dim _QcSN As String = DVabTarakoneshKala.FieldText("NoeTarakoneshKalaNO", DVabTarakoneshKala.DataRows).ToString


                If gSendEmailQcStatus.Contains(_QcSN) Then

                    Dim _QC As String = DVabTarakoneshKala.FieldText("NoeTarakoneshKalaDS", DVabTarakoneshKala.DataRows).ToString

                    Dim gSendEmailQCWho As String
                    Try
                        Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
                        gSendEmailQCWho = IIf(CAppSet.GetAppConfig("gSendEmailQCWho") Is System.DBNull.Value, "", CAppSet.GetAppConfig("gSendEmailQCWho"))
                    Catch ex As Exception

                    End Try

                    If gSendEmailQCWho <> "" Then

                        Dim _tolidDate, _EnghezaDate, _QCStr As String
                        If DVabKalaPhiziki.Fields("ToolidDate").Text = "____/__/__" Then
                            _tolidDate = "---"
                        Else
                            _tolidDate = "20" + DVabKalaPhiziki.Fields("ToolidDate").Text
                        End If
                        If DVabKalaPhiziki.Fields("EnghezaDate").Text = "____/__/__" Then
                            _EnghezaDate = "---"
                        Else
                            _EnghezaDate = "20" + DVabKalaPhiziki.Fields("EnghezaDate").Text
                        End If
                        If DVabTarakoneshKala.DataRows = 1 Then
                            _QCStr = "تراکنش کنترل کیفیت به حالت   < " & _QC & " >  تغییر یافت."
                        Else
                            _QCStr = "تراکنش کنترل کیفیت از حالت  < " & DVabTarakoneshKala.FieldText("NoeTarakoneshKalaDS", 1).ToString & " >   به حالت   < " & _QC & " >  تغییر یافت."
                        End If

                        Dim dv As DataView = cn.ExecuteQuery("_abSpc_GetTadarokatInfoForQC " & DVabKalaPhiziki.Fields("KalaPhizikiSN").Text & "," & DVabTarakoneshKala.Fields("TarakoneshKalaSN").Text & "")
                        Dim FactorNo As String = ""
                        Dim DarkhastNo As String = ""

                        If dv.Count >= 1 Then

                            FactorNo = dv(0)(1)
                            DarkhastNo = dv(0)(0)
                            For i As Integer = 1 To dv.Count - 1

                                If dv(i - 1)(1) <> dv(i)(1) Then
                                    FactorNo += " , " + dv(i)(1)
                                End If
                                If dv(i - 1)(0) <> dv(i)(0) Then
                                    DarkhastNo += " , " + dv(i)(0)
                                End If

                            Next

                        End If


                        Dim _subject As String = "نام کالا : " & DVabKalaPhiziki.Fields("KalaSN").Text & "   "
                        _subject += vbNewLine + vbNewLine + "شماره رهگیری : " & DVabKalaPhiziki.Fields("ShomarehRahgiri").Value & "   "
                        _subject += If(FactorNo <> "", vbNewLine + vbNewLine + "شماره فاکتور : " & FactorNo & "", "")
                        _subject += If(DarkhastNo <> "", vbNewLine + vbNewLine + "شماره درخواست : " & DarkhastNo & "", "")
                        _subject += vbNewLine + vbNewLine + "تاریخ تولید (میلادی) : " & _tolidDate & "   "
                        _subject += vbNewLine + vbNewLine + "تاریخ انقضا (میلادی) : " & _EnghezaDate & "   "
                        _subject += vbNewLine + vbNewLine + _QCStr
                        _subject += If(DVabTarakoneshKala.FieldText("Tozih") <> "", vbNewLine + vbNewLine + "توضیحات : " + DVabTarakoneshKala.FieldText("Tozih"), "")
                        _subject += vbNewLine + vbNewLine + "زمان تغییر : 13" & DVabTarakoneshKala.FieldText("LastDate", DVabTarakoneshKala.DataRows).ToString & " - "
                        _subject += DVabTarakoneshKala.FieldText("LastTime", DVabTarakoneshKala.DataRows).ToString & "  "
                        _subject += vbNewLine + vbNewLine + "نام کاربر تغییر دهنده : " & gSM.UserName & " "
                        _subject += vbNewLine + vbNewLine + "نام کامپیوتر : " & System.Windows.Forms.SystemInformation.ComputerName & ""

                        Try
                            Minoo.Email.Mail.SendMail(gSendEmailQCWho, "", "", "تغییر تراکنش کنترل کیفیت", _subject, "Anbar@MinooGroup.com")
                        Catch ex As Exception
                            NetSql.Common.CSystem.MsgBox("خطا در ارسال ایمیل تغییر تراکنش کنترل کیفیت", MsgBoxStyle.MsgBoxRtlReading, "خطای ارسال ایمیل")
                        End Try

                    End If

                    '''Add By Dehghani 921219

                End If

                DVabTarakoneshKala.Refresh()
                If DVabTarakoneshKala.State <> EnumDataViewState.bsAdd Then
                    vcmAdd = False
                End If

            Case EnumCommands.cmAbort
                vcmAdd = False
            Case EnumCommands.cmDelete
                vcmAdd = False
            Case EnumCommands.cmPrint

        End Select

    End Sub

    Private Sub DVabVw_SanadAnbar_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabVw_SanadAnbar.FillDetailsWithData
        ' کنترل نمايش ستونها در مورد انبار با ماهيت واحد سنجش و انبار با ماهيت تعداد در کارتن
        If aFetched Then
            With DVabVw_SanadAnbar
                With .FlexGrid
                    If _
                        pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Or _
                        pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh Then
                        .ColHidden(.ColIndex("BoxIn")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("CanIn")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("BoxOut")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("CanOut")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("TedadAjza")) = pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                        .ColHidden(.ColIndex("VahedeSanjeshDs")) = pNoeVoroodeAsnad = _
                                                                     EnumNoeVoroodeAsnad.nvaTedadDarKarton
                        .ColHidden(.ColIndex("MeghdareVaredeh")) = pNoeVoroodeAsnad = _
                                                                     EnumNoeVoroodeAsnad.nvaTedadDarKarton
                        .ColHidden(.ColIndex("MeghdareSadereh")) = pNoeVoroodeAsnad = _
                                                                     EnumNoeVoroodeAsnad.nvaTedadDarKarton
                    Else
                        .ColHidden(.ColIndex("BoxIn")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("CanIn")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("BoxOut")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("CanOut")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden(.ColIndex("TedadAjza")) = True
                        .ColHidden(.ColIndex("VahedeSanjeshDs")) = True
                        .ColHidden(.ColIndex("MeghdareVaredeh")) = True
                        .ColHidden(.ColIndex("MeghdareSadereh")) = True
                    End If
                End With
            End With
        End If
    End Sub

    Private Sub FrmQC_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Call InitDataView()

        sstChild.SelectedIndex = 0
        sstChild.Mirrored = True

        Dim _FarsiDate As String = MiladiToShamsi(Today())

        pDateCtrlMiladi = New NetSql.Components.CDateCtrl(tp)
        With pDateCtrlMiladi
            .TextBox = txtMiladi
            '.Value = Format(Today(), "yyyy/mm/dd")
            .Value = Today()
        End With
        pDateCtrlShamsi = New NetSql.Components.CDateCtrl(tp)
        With pDateCtrlShamsi
            .TextBox = txtShamsi
            .DateFormat = EnumDateFormat.dfFullYear
            .Value = _FarsiDate '''''MiladiToShamsi (pDateCtrlMiladi.Text, EnumDateFormat.dfFullYear)
        End With

        ' نام فرم برابر شناسنامه اطلاعات ميباشد ولي در محصول قرار بر عنوان زير شد
        If gNoeAnbarSN = 2 Or gNoeAnbarSN = 5 Or gNoeAnbarSN = 10 Then
            Me.Text = "قرنطينه"
        End If

        'With dcbNoeTarakoneshKala
        '    .Bind(cn, "Select NoeTarakoneshKalaSN,NoeTarakoneshKalaDS From paNoeTarakoneshKala union select 0.935 , 'همه کالاها'", "NoeTarakoneshKalaSN", "NoeTarakoneshKalaDS")
        '    .Enabled = True
        '    .DroppedDown = True
        'End With

        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)
        With CmbNoeTarakoneshKala
            .Bind(cn, "Select NoeTarakoneshKalaSN,NoeTarakoneshKalaDS From paNoeTarakoneshKala", "NoeTarakoneshKalaSN", "NoeTarakoneshKalaDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

    End Sub

    Private Sub FrmQC_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabKalaPhiziki.Done()
        DVabKalaPhiziki = Nothing
        DVabTarakoneshKala.Done()
        DVabTarakoneshKala = Nothing
        DVabVw_SanadAnbar.Done()
        DVabVw_SanadAnbar = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabKalaPhiziki = New CDataView(cn)
        With DVabKalaPhiziki
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdModify _
                                                                           Or EnumButtonOptions.boCmdExit Or _
                                                                           EnumButtonOptions.boCmdFilter Or _
                                                                           EnumButtonOptions.boCmdPrint)
            .TableName = "abKalaPhiziki"
            .AddJoin("abKalaPhiziki", EnumTableJoin.tjLeftJoin, "abKalaPhizikiControl", "KalaPhizikiSN", "KalaPhizikiSN") ' Add By Yekta 920814
            .Text = Me.Text
            .UpdateSPName = "_abKalaPhiziki_Updatex"
            ' شرط لازم براي انبار جاري و واحد تجاري انبار
            .SQLWhere = " abKalaPhiziki.VahedeTejariSN = " & CStr(gVahedeTejariSN) '&
            ''" and MoaserDate BETWEEN " & gHesabdariSalFDate & " And " & gHesabdariSalTDate

            '& _
            '" AND abKalaPhiziki.AnbarSN = " & CStr(gAnbarSN)'Izadpanah***860708
            '" WHERE (LEFT(abSanad.SanadDate,2) >= " & _
            'VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
            '                                                           cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & _

            .SQLWhere = .SQLWhere & " AND  abKalaPhiziki.KalaPhizikiSN IN ( SELECT abSanadHa.KalaPhizikiSN " &
                        " FROM  abSanad INNER JOIN abSanadHa ON abSanad.SanadSN = abSanadHa.SanadSN " &
                        " WHERE (abSanad.SanadDate BETWEEN " & gHesabdariSalFDate & " And " & gHesabdariSalTDate &
                        ") AND ( abSanad.AnbarSN = " & CStr(gAnbarSN) & " ) " &
                        " AND ( abSanad.VahedeTejariSN = " & CStr(gVahedeTejariSN) & " ) " &
                        "  AND ( abSanad.SanadStatus >= 8 )   ) "
            ''test

            ''test
            pDVabKalaPhiziki_SQLWhere = .SQLWhere
            .SQLOrderBy = " KalaNO "
            '" AnbarSN , NoeAnbarSN , KalaNO "'Izadpanah***860708
            .EditInGrid = True
            .AccessRight = gSM.TableAccessRight(.TableName)
            With .Fields
                With .Add("KalaPhizikiSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                'Izadpanah***860708
                '.Add("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                '.Add("NoeAnbarSN", "DataCombo <Disabled>", IIf(gNoeAnbarSN = 0, EnumFieldOptions.foDefault, EnumFieldOptions.foHidden))
                'With .Add("NoeAnbarSN->abNoeVoroodeAsnad.NoeVoroodeAsnadSN AS NoeVoroodeAsnadSN", "DataCombo", EnumFieldOptions.foHidden)
                '  .Component.Enabled = False
                '  .Component.Visible = False
                'End With

                With .Add("KalaSN->{KalaNO + ' _ ' + KalaDS} AS KalaSN", "DataCombo")
                    dbcKalaSN = .Component
                    .Caption = cn.FieldCaption("paKala.KalaDS")
                    dbcKalaSN.LateBinding = True
                    .ReadOnly = True
                End With
                With .Add("ShomarehRahgiri", "TextBox <Disabled>")
                End With
                With .Add("{(dbo.GregorianDate(ToolidDate,'long'))} AS ToolidDate", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .Caption = "تاریخ تولید (میلادی)"
                    .DefaultValue = Functions.FTDBCommonFunctions.enmDateFormat.Normal
                    .DateFormat = EnumDateFormat.dfFullYear

                End With
                With .Add("{(dbo.GregorianDate(EnghezaDate,'long'))} AS EnghezaDate", "TextBox", EnumFieldOptions.foDate)
                    .Caption = "تاریخ انقضا (میلادی)"
                    .DefaultValue = Functions.FTDBCommonFunctions.enmDateFormat.Normal
                    .DateFormat = EnumDateFormat.dfFullYear

                End With
                'With .Add("KalaPhizikiStatus", "DataCombo <Disabled>")
                'End With
                .Add("PayeSN", , EnumFieldOptions.foHidden)
                '.Add ("Tozih", "TextBox", EnumFieldOptions.foHidden)
                .Add("Sazandeh", "TextBox", EnumFieldOptions.foHidden)
                .Add("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)

                '----------------- yekta 920814 -------------------------
                With .Add("KalaPhizikiSN->abKalaPhizikiControl.BatchNO AS BatchNO", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "شماره بچ"
                End With
                With .Add("KalaPhizikiSN->abKalaPhizikiControl.Tozih AS Tozih ", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "توضیحات"
                End With
                '----------------- yekta 920814 -------------------------
            End With
        End With

        DVabTarakoneshKala = New CDataView(cn)
        With DVabTarakoneshKala
            .Init(pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdPrint)
            .TableName = "abTarakoneshKala"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paNoeTarakoneshKala", "NoeTarakoneshKalaSN", "NoeTarakoneshKalaSN") ' Add By Dehghani 921219
            .Text = Me.Text
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            .SQLOrderBy = "  LastDate DESC , LastTime DESC "
            With .Fields
                With .Add("TarakoneshKalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("NoeTarakoneshKalaSN", "DataCombo")
                    dbcNoeTarakoneshKalaSN = .Component
                End With

                .Add("NoeTarakoneshKalaSN->{NoeTarakoneshKalaNO} As NoeTarakoneshKalaNO ", "DataCombo", EnumFieldOptions.foHidden)
                .Add("NoeTarakoneshKalaSN->{NoeTarakoneshKalaDS} As NoeTarakoneshKalaDS ", "DataCombo", EnumFieldOptions.foHidden)
                .Add("NoeGharantinehSN", "DataCombo", EnumFieldOptions.foDefault)
                .Add("KalaPhizikiSN", "TextBox", EnumFieldOptions.foHidden)
                With .Add("LastDate", "TextBox <DISABLED>", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add("LastTime", "TextBox <DISABLED>", EnumFieldOptions.foTime)
                    .TimeFormat = EnumTimeFormat.tfHour Or EnumTimeFormat.tfMinute Or EnumTimeFormat.tfSecond
                End With
                .Add("Tozih", "TextBox", EnumFieldOptions.foDefault)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabKalaPhiziki
        End With

        DVabVw_SanadAnbar = New CDataView(cn)
        With DVabVw_SanadAnbar
            .Init(pnlGridDet2, , pnlCommandDet2, pnlNavigationDet2, EnumButtonOptions.boCmdPrint _
                                                                     Or EnumButtonOptions.boCmdFind)
            .TableName = "abVw_SanadAnbar"
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            .EditInGrid = False
            .SQLWhere = " 1 = 2 "
            With .Fields
                .Add("VahedeTejariSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("VahedeTejariDs", "TextBox", EnumFieldOptions.foHidden)
                '.Add("AnbarSN", "TextBox", EnumFieldOptions.foHidden)'Izadpanah***860708
                .Add("AnbarDs", "TextBox", EnumFieldOptions.foDefault)
                '.Add("NoeAnbarSN", "TextBox", EnumFieldOptions.foHidden)'Izadpanah***860708
                .Add("NoeAnbarDs", "TextBox", EnumFieldOptions.foDefault)
                .Add("TarakoneshSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("TarakoneshDs", "TextBox", EnumFieldOptions.foDefault)
                .Add("TafsiliSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("TafsiliDS", , EnumFieldOptions.foDefault)
                .Add("SanadSN", , EnumFieldOptions.foHidden)
                .Add("SanadNO", , EnumFieldOptions.foDefault)
                .Add("SanadDate", , EnumFieldOptions.foDate)
                .Add("MoaserDate", , EnumFieldOptions.foHidden)
                .Add("SanadStatusDS", , EnumFieldOptions.foDefault)
                .Add("GeymatStatus", , EnumFieldOptions.foHidden)
                .Add("SanadGeymatStatusDS", , EnumFieldOptions.foHidden)
                .Add("SanadMaliStatusDS", , EnumFieldOptions.foHidden)
                .Add("SanadHaSN", , EnumFieldOptions.foHidden)
                .Add("ShomarehSefaresh")
                .Add("KalaSN", , EnumFieldOptions.foHidden)
                .Add("KalaNo", , EnumFieldOptions.foDefault)
                .Add("KalaDs", , EnumFieldOptions.foDefault)
                .Add("VahedeSanjeshDs", , EnumFieldOptions.foDefault)
                .Add("TedadAjza", , EnumFieldOptions.foDefault)
                .Add("BoxIn", , EnumFieldOptions.foDefault)
                .Add("CanIn", , EnumFieldOptions.foDefault)
                .Add("BoxOut", , EnumFieldOptions.foDefault)
                .Add("CanOut", , EnumFieldOptions.foDefault)
                .Add("MeghdareVaredeh", , EnumFieldOptions.foDefault)
                .Add("MeghdareSadereh", , EnumFieldOptions.foDefault)
                .Add("NoeZayeatSN", , EnumFieldOptions.foHidden)
                .Add("NoeZayeatDs", , EnumFieldOptions.foDefault)
                .Add("NoeMarjooeiSN", , EnumFieldOptions.foHidden)
                .Add("NoeMarjooeiDs", , EnumFieldOptions.foDefault)
                .Add("NoeMadomiSN", , EnumFieldOptions.foHidden)
                .Add("NoeMadomiDs", , EnumFieldOptions.foDefault)
                .Add("KalaPhizikiSN", , EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
        DVabKalaPhiziki.Refresh()

    End Sub

    Private Sub DVabTarakoneshKala_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabTarakoneshKala.CommandClick
        dbcNoeTarakoneshKalaSN.Visible = False
        Static vcmAdd As Boolean
        Select Case aCommand
            Case EnumCommands.cmEdit
                vcmAdd = False
            Case EnumCommands.cmAdd
                vcmAdd = True
            Case EnumCommands.cmSave
                If vcmAdd Then
                    ' تهيه تاريخ از سرور
                    DVabTarakoneshKala.Fields("LastTime").Value = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server( _
                                                                                                                        cn, _
                                                                                                                        Functions _
                                                                                                                           . _
                                                                                                                           FTDBCommonFunctions _
                                                                                                                           . _
                                                                                                                           enmTimeFormat _
                                                                                                                           . _
                                                                                                                           HHmmss)
                    DVabTarakoneshKala.Fields("LastDate").Value = _
                        Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                    cn, _
                                                                                    Functions.FTDBCommonFunctions. _
                                                                                       enmDateFormat.Normal)
                End If
                If DVabTarakoneshKala.State <> EnumDataViewState.bsAdd Then
                    vcmAdd = False
                End If
            Case EnumCommands.cmAbort
                vcmAdd = False
            Case EnumCommands.cmDelete
                vcmAdd = False
        End Select

    End Sub

    Private Sub dbcNoeTarakoneshKalaSN_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles dbcNoeTarakoneshKalaSN.SelectedValueChanged
        ' NoeTarakoneshKalaSN	NoeTarakoneshKalaDS
        ' 1.935					      قرنطينه
        ' 2.935					      تاييد
        ' 3.935					      رد
        ' 4.935					      مصرف مشروط
        ' در صورتيکه تراکنش کالا قرنطينه است نوع ان مشخص گردد
        DVabTarakoneshKala.Fields("NoeGharantinehSN").ReadOnly = True
        If dbcNoeTarakoneshKalaSN.Text <> "" Then
            If dbcNoeTarakoneshKalaSN.BoundText = CStr(1.935) Then
                DVabTarakoneshKala.Fields("NoeGharantinehSN").ReadOnly = False
            End If
        End If
    End Sub

    Private Sub btnToShamsiDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnToShamsiDate.Click
        ' تبديل تاريخ ميلادي به شمسي
        With pDateCtrlShamsi
            .Value = MiladiToShamsi(pDateCtrlMiladi.Text, EnumDateFormat.dfFullYear)
        End With
    End Sub

    '----comment by yekta 930318---------------
    'Private Sub rdbNoTaied_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles rdbNoTaied.CheckedChanged
    '    ' کالاهاي بررسي نشده
    '    ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
    '    If Not DVabKalaPhiziki Is Nothing Then
    '        DVabVw_SanadAnbar.SQLWhere = " 1 = 2 "
    '        DVabVw_SanadAnbar.Refresh()
    '        With DVabKalaPhiziki
    '            'change SQLWhere by yekta 921025
    '            .SQLWhere = pDVabKalaPhiziki_SQLWhere & _
    '                        "   AND abKalaPhiziki.KalaPhizikiSN IN  ( SELECT abKalaPhiziki.KalaPhizikiSN " & _
    '                        " FROM   abKalaPhiziki LEFT OUTER JOIN " & _
    '                        "        abTarakoneshKala ON abKalaPhiziki.KalaPhizikiSN = abTarakoneshKala.KalaPhizikiSN " & _
    '                        " WHERE  (((select top 1 NoeTarakoneshKalaSN from abTarakoneshKala where abTarakoneshKala.KalaPhizikiSN=abKalaPhiziki.KalaPhizikiSN order by abTarakoneshKala.LastDate desc, abTarakoneshKala.LastTime desc) = cast(( Select dbo.imFng_GetConfiguration(" & gVahedeTejariSN & ",5,'gPishfarzNoeTarakoneshKala')) as Decimal(18,3))))) " & _
    '                        " AND  abKalaPhiziki.KalaPhizikiSN IN ( SELECT KalaPhizikiSN " & _
    '                        " FROM  abSanad INNER JOIN abSanadHa ON abSanad.SanadSN = abSanadHa.SanadSN " & _
    '                        " WHERE (abSanad.SanadDate BETWEEN " & gHesabdariSalFDate & " And " & gHesabdariSalTDate & _
    '                        ") AND ( abSanad.AnbarSN = " & CStr(gAnbarSN) & " ) " & _
    '                        " AND ( abSanad.VahedeTejariSN = " & CStr(gVahedeTejariSN) & " ) " & _
    '                        "  AND ( abSanad.SanadStatus >= 8 ) group by KalaPhizikiSN having sum(isnull(meghdarevaredeh,0))-sum(isnull(meghdaresadereh,0)) >0   ) "
    '            .Refresh()
    '        End With
    '    End If
    'End Sub

    'Private Sub rdbAllKala_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles rdbAllKala.CheckedChanged
    '    ' همه کالاها
    '    ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
    '    If Not DVabKalaPhiziki Is Nothing Then
    '        With DVabKalaPhiziki
    '            .SQLWhere = pDVabKalaPhiziki_SQLWhere
    '            .Refresh()
    '        End With
    '    End If

    'End Sub

    'Private Sub rdbTaied_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles rdbTaied.CheckedChanged
    '    ' کالاهاي بررسي شده
    '    ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
    '    If Not DVabKalaPhiziki Is Nothing Then
    '        DVabVw_SanadAnbar.SQLWhere = " 1 = 2 "
    '        DVabVw_SanadAnbar.Refresh()
    '        With DVabKalaPhiziki
    '            .SQLWhere = pDVabKalaPhiziki_SQLWhere & _
    '                        "   AND abKalaPhiziki.KalaPhizikiSN IN  ( SELECT abKalaPhiziki.KalaPhizikiSN " & _
    '                        " FROM   abKalaPhiziki LEFT OUTER JOIN " & _
    '                        "        abTarakoneshKala ON abKalaPhiziki.KalaPhizikiSN = abTarakoneshKala.KalaPhizikiSN " & _
    '                        " WHERE  (((select top 1 NoeTarakoneshKalaSN from abTarakoneshKala where abTarakoneshKala.KalaPhizikiSN=abKalaPhiziki.KalaPhizikiSN order by abTarakoneshKala.LastDate desc, abTarakoneshKala.LastTime desc) not in ( Select dbo.imFng_GetConfiguration(" & gVahedeTejariSN & ",5,'gPishfarzNoeTarakoneshKala') union select 7.935)))) "
    '            .Refresh()
    '        End With
    '    End If

    'End Sub

    Private Sub rdbTahteAzmayesh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' کالاهاي تحت آزمایش
        ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
        If Not DVabKalaPhiziki Is Nothing Then
            DVabVw_SanadAnbar.SQLWhere = " 1 = 2 "
            DVabVw_SanadAnbar.Refresh()
            With DVabKalaPhiziki
                .SQLWhere = pDVabKalaPhiziki_SQLWhere & _
                            "   AND abKalaPhiziki.KalaPhizikiSN IN  ( SELECT abKalaPhiziki.KalaPhizikiSN " & _
                            " FROM   abKalaPhiziki LEFT OUTER JOIN " & _
                            "        abTarakoneshKala ON abKalaPhiziki.KalaPhizikiSN = abTarakoneshKala.KalaPhizikiSN " & _
                            " WHERE  (((select top 1 NoeTarakoneshKalaSN from abTarakoneshKala where abTarakoneshKala.KalaPhizikiSN=abKalaPhiziki.KalaPhizikiSN order by abTarakoneshKala.LastDate desc, abTarakoneshKala.LastTime desc)  in (7.935)))) "
                .Refresh()
            End With
        End If

    End Sub

    '---------Add by yekta 930327------------------

    Private Sub BtnVeiw_Click(sender As System.Object, e As System.EventArgs) Handles BtnVeiw.Click
        Dim vNoeTarakoneshKala As String
        If Trim(CmbNoeTarakoneshKala.getStringValues) <> "" Then
            vNoeTarakoneshKala = CmbNoeTarakoneshKala.getStringValues
            If vNoeTarakoneshKala = "0.000" Then
                vNoeTarakoneshKala = "0"
                If Not DVabKalaPhiziki Is Nothing Then
                    DVabVw_SanadAnbar.SQLWhere = " 1 = 2 "
                    DVabVw_SanadAnbar.Refresh()
                    With DVabKalaPhiziki
                        .SQLWhere = pDVabKalaPhiziki_SQLWhere
                        .Refresh()
                    End With
                End If
            Else
                If Not DVabKalaPhiziki Is Nothing Then
                    DVabVw_SanadAnbar.SQLWhere = " 1 = 2 "
                    DVabVw_SanadAnbar.Refresh()
                    With DVabKalaPhiziki
                        .SQLWhere = pDVabKalaPhiziki_SQLWhere & _
                                    "   AND abKalaPhiziki.KalaPhizikiSN IN  ( SELECT abKalaPhiziki.KalaPhizikiSN " & _
                                    " FROM   abKalaPhiziki LEFT OUTER JOIN " & _
                                    "        abTarakoneshKala ON abKalaPhiziki.KalaPhizikiSN = abTarakoneshKala.KalaPhizikiSN " & _
                                    " WHERE  (((select top 1 NoeTarakoneshKalaSN from abTarakoneshKala where abTarakoneshKala.KalaPhizikiSN=abKalaPhiziki.KalaPhizikiSN order by abTarakoneshKala.LastDate desc, abTarakoneshKala.LastTime desc) in (" & vNoeTarakoneshKala & ")))) "
                        .Refresh()
                    End With
                End If
            End If
        End If

    End Sub

End Class
