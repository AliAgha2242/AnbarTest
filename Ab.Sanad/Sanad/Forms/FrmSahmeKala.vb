
' OK
'Author ::Ghafari Saeed 
'CreateDate ::  1394/05/13
'ModifiedDate::
'Description::  ثبت سهمیه کالاهای سهمیه ای در انبار
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports VB = Microsoft.VisualBasic
Imports Anbar.BRL
Imports Minoo.Services.Middleware
Imports Minoo.Models.Middleware


Public Class FrmSahmeKala

    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmSahmeKala
    Friend WithEvents PnlN1 As System.Windows.Forms.Panel
    Friend WithEvents btnAddShoab As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDarsad As System.Windows.Forms.TextBox
    Friend WithEvents TxtTarikh As System.Windows.Forms.TextBox
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmSahmeKala
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSahmeKala()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As FrmSahmeKala)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnAddkala As System.Windows.Forms.Button
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PnlG1 As System.Windows.Forms.Panel
    Friend WithEvents PnlC3 As System.Windows.Forms.Panel
    Friend WithEvents PnlN3 As System.Windows.Forms.Panel
    Friend WithEvents PnlG3 As System.Windows.Forms.Panel
    Friend WithEvents PnlC4 As System.Windows.Forms.Panel
    Friend WithEvents PnlN4 As System.Windows.Forms.Panel
    Friend WithEvents PnlG4 As System.Windows.Forms.Panel
    Friend WithEvents PnlC2 As System.Windows.Forms.Panel
    Friend WithEvents PnlN2 As System.Windows.Forms.Panel
    Friend WithEvents PnlG2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelkala As System.Windows.Forms.Button
    Friend WithEvents cmbTaminKonadeh As cmpCheckedComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cmbTaminKonadeh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSahmeKala))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddShoab = New System.Windows.Forms.Button()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PnlC3 = New System.Windows.Forms.Panel()
        Me.PnlN3 = New System.Windows.Forms.Panel()
        Me.PnlG3 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PnlC4 = New System.Windows.Forms.Panel()
        Me.PnlN4 = New System.Windows.Forms.Panel()
        Me.PnlG4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmbTaminKonadeh = New cmpCheckedComboBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelkala = New System.Windows.Forms.Button()
        Me.btnAddkala = New System.Windows.Forms.Button()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PnlN1 = New System.Windows.Forms.Panel()
        Me.PnlG1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnlC2 = New System.Windows.Forms.Panel()
        Me.PnlN2 = New System.Windows.Forms.Panel()
        Me.PnlG2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TxtTarikh = New System.Windows.Forms.TextBox()
        Me.TxtDarsad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.SplitContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1166, 239)
        Me.Panel2.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(1166, 239)
        Me.SplitContainer2.SplitterDistance = 688
        Me.SplitContainer2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtDarsad)
        Me.Panel4.Controls.Add(Me.TxtTarikh)
        Me.Panel4.Controls.Add(Me.btnAddShoab)
        Me.Panel4.Controls.Add(Me.TabControl3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(688, 239)
        Me.Panel4.TabIndex = 2
        '
        'btnAddShoab
        '
        Me.btnAddShoab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnAddShoab.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAddShoab.Location = New System.Drawing.Point(236, 5)
        Me.btnAddShoab.Name = "btnAddShoab"
        Me.btnAddShoab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddShoab.Size = New System.Drawing.Size(148, 29)
        Me.btnAddShoab.TabIndex = 2
        Me.btnAddShoab.Text = "اضافه کردن شعب"
        Me.btnAddShoab.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(0, 16)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.RightToLeftLayout = True
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(684, 218)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PnlC3)
        Me.TabPage3.Controls.Add(Me.PnlN3)
        Me.TabPage3.Controls.Add(Me.PnlG3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(676, 191)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "شعبه"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PnlC3
        '
        Me.PnlC3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlC3.Location = New System.Drawing.Point(244, 158)
        Me.PnlC3.Name = "PnlC3"
        Me.PnlC3.Size = New System.Drawing.Size(427, 34)
        Me.PnlC3.TabIndex = 6
        '
        'PnlN3
        '
        Me.PnlN3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlN3.Location = New System.Drawing.Point(6, 158)
        Me.PnlN3.Name = "PnlN3"
        Me.PnlN3.Size = New System.Drawing.Size(185, 34)
        Me.PnlN3.TabIndex = 5
        '
        'PnlG3
        '
        Me.PnlG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG3.Location = New System.Drawing.Point(6, 6)
        Me.PnlG3.Name = "PnlG3"
        Me.PnlG3.Size = New System.Drawing.Size(665, 149)
        Me.PnlG3.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TabControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 239)
        Me.Panel3.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(474, 239)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PnlC4)
        Me.TabPage2.Controls.Add(Me.PnlN4)
        Me.TabPage2.Controls.Add(Me.PnlG4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(466, 212)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "تاریخ - سهم"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PnlC4
        '
        Me.PnlC4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlC4.Location = New System.Drawing.Point(219, 179)
        Me.PnlC4.Name = "PnlC4"
        Me.PnlC4.Size = New System.Drawing.Size(241, 34)
        Me.PnlC4.TabIndex = 6
        '
        'PnlN4
        '
        Me.PnlN4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlN4.Location = New System.Drawing.Point(8, 179)
        Me.PnlN4.Name = "PnlN4"
        Me.PnlN4.Size = New System.Drawing.Size(185, 34)
        Me.PnlN4.TabIndex = 5
        '
        'PnlG4
        '
        Me.PnlG4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG4.Location = New System.Drawing.Point(8, 6)
        Me.PnlG4.Name = "PnlG4"
        Me.PnlG4.Size = New System.Drawing.Size(452, 170)
        Me.PnlG4.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.SplitContainer3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 248)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel6)
        Me.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer3.Size = New System.Drawing.Size(1166, 248)
        Me.SplitContainer3.SplitterDistance = 580
        Me.SplitContainer3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.cmbTaminKonadeh)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.btnDelkala)
        Me.Panel6.Controls.Add(Me.btnAddkala)
        Me.Panel6.Controls.Add(Me.TabControl4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(580, 248)
        Me.Panel6.TabIndex = 2
        '
        'cmbTaminKonadeh
        '
        Me.cmbTaminKonadeh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbTaminKonadeh_DesignTimeLayout.LayoutString = resources.GetString("cmbTaminKonadeh_DesignTimeLayout.LayoutString")
        Me.cmbTaminKonadeh.DesignTimeLayout = cmbTaminKonadeh_DesignTimeLayout
        Me.cmbTaminKonadeh.LateBinding = True
        Me.cmbTaminKonadeh.LateBindingTop = "100"
        Me.cmbTaminKonadeh.Location = New System.Drawing.Point(42, 14)
        Me.cmbTaminKonadeh.Name = "cmbTaminKonadeh"
        Me.cmbTaminKonadeh.SaveSettings = False
        Me.cmbTaminKonadeh.ShowSelectAll = True
        Me.cmbTaminKonadeh.Size = New System.Drawing.Size(349, 22)
        Me.cmbTaminKonadeh.TabIndex = 124
        Me.cmbTaminKonadeh.ValuesDataMember = Nothing
        Me.cmbTaminKonadeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 14)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "تامین كننده:"
        '
        'btnDelkala
        '
        Me.btnDelkala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelkala.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDelkala.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDelkala.Location = New System.Drawing.Point(4, 128)
        Me.btnDelkala.Name = "btnDelkala"
        Me.btnDelkala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDelkala.Size = New System.Drawing.Size(34, 116)
        Me.btnDelkala.TabIndex = 2
        Me.btnDelkala.Text = "<<"
        Me.btnDelkala.UseVisualStyleBackColor = True
        '
        'btnAddkala
        '
        Me.btnAddkala.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnAddkala.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAddkala.Location = New System.Drawing.Point(4, 24)
        Me.btnAddkala.Name = "btnAddkala"
        Me.btnAddkala.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddkala.Size = New System.Drawing.Size(34, 97)
        Me.btnAddkala.TabIndex = 1
        Me.btnAddkala.Text = ">>"
        Me.btnAddkala.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage4)
        Me.TabControl4.Location = New System.Drawing.Point(39, 23)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.RightToLeftLayout = True
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(537, 221)
        Me.TabControl4.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PnlN1)
        Me.TabPage4.Controls.Add(Me.PnlG1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(529, 194)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "لیست کالاها"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PnlN1
        '
        Me.PnlN1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlN1.Location = New System.Drawing.Point(3, 157)
        Me.PnlN1.Name = "PnlN1"
        Me.PnlN1.Size = New System.Drawing.Size(523, 34)
        Me.PnlN1.TabIndex = 4
        '
        'PnlG1
        '
        Me.PnlG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG1.Location = New System.Drawing.Point(3, 3)
        Me.PnlG1.Name = "PnlG1"
        Me.PnlG1.Size = New System.Drawing.Size(523, 153)
        Me.PnlG1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(582, 248)
        Me.Panel5.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(582, 248)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PnlC2)
        Me.TabPage1.Controls.Add(Me.PnlN2)
        Me.TabPage1.Controls.Add(Me.PnlG2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(574, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "کالا"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PnlC2
        '
        Me.PnlC2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlC2.Location = New System.Drawing.Point(231, 182)
        Me.PnlC2.Name = "PnlC2"
        Me.PnlC2.Size = New System.Drawing.Size(339, 34)
        Me.PnlC2.TabIndex = 3
        '
        'PnlN2
        '
        Me.PnlN2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlN2.Location = New System.Drawing.Point(6, 182)
        Me.PnlN2.Name = "PnlN2"
        Me.PnlN2.Size = New System.Drawing.Size(185, 34)
        Me.PnlN2.TabIndex = 2
        '
        'PnlG2
        '
        Me.PnlG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG2.Location = New System.Drawing.Point(4, 6)
        Me.PnlG2.Name = "PnlG2"
        Me.PnlG2.Size = New System.Drawing.Size(566, 173)
        Me.PnlG2.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1166, 491)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 0
        '
        'TxtTarikh
        '
        Me.TxtTarikh.BackColor = System.Drawing.Color.Bisque
        Me.TxtTarikh.Location = New System.Drawing.Point(97, 8)
        Me.TxtTarikh.Name = "TxtTarikh"
        Me.TxtTarikh.Size = New System.Drawing.Size(89, 22)
        Me.TxtTarikh.TabIndex = 3
        '
        'TxtDarsad
        '
        Me.TxtDarsad.BackColor = System.Drawing.Color.Bisque
        Me.TxtDarsad.Location = New System.Drawing.Point(7, 6)
        Me.TxtDarsad.Name = "TxtDarsad"
        Me.TxtDarsad.Size = New System.Drawing.Size(43, 22)
        Me.TxtDarsad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "تاریخ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "درصد:"
        '
        'FrmSahmeKala
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1166, 491)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmSahmeKala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فرم تسهیم کالاهای  سهمیه های آرایشی"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support_For2Instance"

    'Private Shared m_vb6formdefinstance As FrmSahmeKala
    'Private Shared m_initializingdefinstance As Boolean

    'Public Shared Property DefInstance() As FrmSahmeKala

    '    Get

    '        If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
    '            m_initializingdefinstance = True
    '            m_vb6formdefinstance = New FrmSahmeKala
    '            m_initializingdefinstance = False
    '        End If
    '        DefInstance = m_vb6formdefinstance

    '    End Get

    '    Set(ByVal Value As FrmSahmeKala)
    '        m_vb6formdefinstance = Value

    '    End Set

    'End Property

#End Region

    Private WithEvents DataView1 As NetSql.View.CDataView
    Private WithEvents DataView2 As NetSql.View.CDataView
    Private WithEvents DataView3 As NetSql.View.CDataView
    Private WithEvents DataView4 As NetSql.View.CDataView

    Private WithEvents dcbKalaDS As NetSql.Components.DataCombo
    Private WithEvents dcbVahedeTejariDS As NetSql.Components.DataCombo
    Private WithEvents pFlex_abKalaSahm As AxVSFlexGrid



    Private Sub FrmSahmeKala_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim vTaminKonadehSql As String
        vTaminKonadehSql = SetTaminKonandeganComboCMP(cmbTaminKonadeh, True, True, False)

        Initlistkala()
        InitSahmKala()
        InitSahmkalaShoab()
        InitSahmKalaShoabTarikh()

        DataView2.Refresh()

        'Me.WindowState = FormWindowState.Maximized
        Me.Refresh()

    End Sub

    Friend Function SetTaminKonandeganComboCMP(ByRef cmbTaminKonadeh As cmpCheckedComboBox, ByVal withAllItems As Boolean, ByVal preSelected As Boolean, ByVal onlypreSelected As Boolean)
        Dim vTaminKonadehSql As String


        vTaminKonadehSql = "Select distinct TaminVahedeTejariSN TaminkonanehSN,TaminVahedeTejariNo +'.'+ TaminVahedeTejariDs TaminkonanehDS from paVw_paKalaTaminFull"
        cmbTaminKonadeh.Enabled = True


        cmbTaminKonadeh.ShowSelectAll = withAllItems

        cmbTaminKonadeh.Bind(cn, vTaminKonadehSql, "TaminkonanehSN", "TaminkonanehDS")

        'If NoeConnection = Connection.Sherkati Then
        '    CMP_SetDef_CheckedValues(cmbTaminKonadeh, gVahedeTejariSN)
        '    cmbTaminKonadeh.Enabled = False
        'Else
        '    If preSelected Then CMP_SetDef_CheckedValues(cmbTaminKonadeh)

        'End If

    End Function

    Private Sub Initlistkala()

        DataView1 = New NetSql.View.CDataView(cn)
        With DataView1

            .Init(PnlG1, , , PnlN1, )
            .TableName = "paVw_paKalaTaminFull"

            .EditInGrid = True
            .NextRowAfterSave = True
            .SQLOrderBy = "TaminVahedeTejariNo +'.'+ TaminVahedeTejariDs,KalaNO"
            .SQLWhere = "1<>1"
            .AutoFetchCurrentRow = True

            With .Fields()

                With .Add("KalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaNO", "textbox", EnumFieldOptions.foDefault)
                    .Caption = "کد کالا"
                    .ReadOnly = True
                End With
                With .Add("KalaDS", "textbox", EnumFieldOptions.foDefault)
                    .Caption = "شرح کالا"
                    .ReadOnly = True
                End With
                With .Add("TaminVahedeTejariDs", "TextBox")
                    .Caption = "تامین کننده"
                End With

            End With

            .Refresh()
        End With
    End Sub

    Private Sub InitSahmKala()

        DataView2 = New NetSql.View.CDataView(cn)
        With DataView2

            .Init(PnlG2, , PnlC2, PnlN2, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdUpdate)

            .TableName = "abKalaSahm"
            .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)

            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "Pakala", "KalaSN", "KalaSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVw_paKalaTaminFull", "KalaSN", "KalaSN")

            .EditInGrid = True
            .NextRowAfterSave = True
            .SQLOrderBy = "KalaDS"
            .AutoFetchCurrentRow = True
            .SQLWhere = "1=0"

            With .Fields()
                With .Add("KalaSahmSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaSN->pakala.{pakala.KalaNO + ' _ ' + pakala.KalaDS} AS KalaDS", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paKala.KalaDs")
                    .ComboWhereCondition = " MahiatKalaSN =3.935"
                End With
                With .Add("KalaSN->paVw_paKalaTaminFull.TaminVahedeTejariDs AS TaminkonanehDS", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "تامین کننده"
                    .ReadOnly = True
                End With

            End With

        End With
    End Sub

    Private Sub InitSahmkalaShoab()

        DataView3 = New NetSql.View.CDataView(cn)
        With DataView3

            .Init(PnlG3, , PnlC3, PnlN3, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdUpdate)

            .TableName = "abKalaShoabSahm"
            .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)

            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "PaVahedeTejari", "VahedeTejariSN", "VahedeTejariSN")

            .EditInGrid = True
            .NextRowAfterSave = True
            .SQLOrderBy = "VahedeTejariDS"
            .AutoFetchCurrentRow = True

            With .Fields()
                With .Add("KalaShoabSahmSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaSahmSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("VahedeTejariSN->PaVahedeTejari.VahedeTejariDS As VahedeTejariDS", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "شعبه"
                    .ComboWhereCondition = " PedarVahedeTejariSN =9.935 And VahedeTejariStatus =1"
                End With
            End With
            .Parent = DataView2
        End With
    End Sub

    Private Sub InitSahmkalaShoabTarikh()

        DataView4 = New NetSql.View.CDataView(cn)
        With DataView4

            .Init(PnlG4, , PnlC4, PnlN4, EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdUpdate)

            .TableName = "abKalaShoabTarikhSahm"
            .AccessRight = CType(gSM.TableAccessRight(.TableName), EnumAccessRight)

            .EditInGrid = True
            .NextRowAfterSave = True
            .SQLOrderBy = "Tarikh"
            .AutoFetchCurrentRow = True

            With .Fields()
                With .Add("KalaShoabTarikhSahmSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("KalaShoabSahmSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("Tarikh", "textbox", EnumFieldOptions.foDefault)
                    .Caption = "تاریخ"
                    .ReadOnly = False
                End With
                With .Add("Darsad", "textbox", EnumFieldOptions.foDefault)
                    .Caption = "درصد تسهیم"
                    .ReadOnly = False
                End With
            End With
            .Parent = DataView3
        End With
    End Sub

    Private Sub cmbTaminKonadeh_TextChanged(sender As Object, e As System.EventArgs) Handles cmbTaminKonadeh.TextChanged

        Dim _Str As String = cmbTaminKonadeh.getStringValues()
        If Not _Str Is Nothing And _Str <> "0.000" Then
            With DataView1
                .SQLWhere = "TaminVahedeTejariSN in (" & _Str & ") And Not KalaSn In (Select KalaSn from abKalaSahm) "
                .Refresh()
            End With
            With DataView2
                .SQLWhere = "abKalaSahm.KalaSn in (Select  KalaSn from paVw_paKalaTaminFull Where TaminVahedeTejariSN in (" & _Str & "))"
                .Refresh()
            End With
        ElseIf _Str = "0.000" Then
            With DataView1
                .SQLWhere = "Not KalaSn In (Select KalaSn from abKalaSahm) "
                .Refresh()
            End With
            With DataView2
                .SQLWhere = "1=1"
                .Refresh()
            End With
        Else
            With DataView1
                .SQLWhere = "1=0"
                .Refresh()
            End With
            With DataView2
                .SQLWhere = "1=0"
                .Refresh()
            End With
        End If

    End Sub

    Private Sub DataView1_GetGridProperties() Handles DataView1.GetGridProperties
        With DataView1.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub DataView2_GetGridProperties() Handles DataView2.GetGridProperties
        With DataView2.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub btnAddkala_Click(sender As System.Object, e As System.EventArgs) Handles btnAddkala.Click

        Dim StrKalaSN As String = ""
        Dim i As Int16
        Dim vCount_SeletedKala As Short
        Dim _Cls As New ClsDataAccessRule

        With DataView1.FlexGrid
            vCount_SeletedKala = .SelectedRows
            For i = 0 To vCount_SeletedKala - 1
                StrKalaSN = .TextMatrix(.SelectedRow(i), .ColIndex("KalaSN"))
                _Cls.InsertKalaSahmInDatabase(StrKalaSN, cn, gSM.UserID_Name)
            Next
        End With

        Call cmbTaminKonadeh_TextChanged(sender, e)

    End Sub

    Private Sub btnDelkala_Click(sender As System.Object, e As System.EventArgs) Handles btnDelkala.Click

        Dim StrKalaSahmSN As String = ""
        Dim i As Int16
        Dim vCount_SeletedKala As Short
        Dim _Cls As New ClsDataAccessRule

        With DataView2.FlexGrid
            vCount_SeletedKala = .SelectedRows
            For i = 0 To vCount_SeletedKala - 1
                StrKalaSahmSN = .TextMatrix(.SelectedRow(i), .ColIndex("KalaSahmSN"))
                _Cls.DeleteKalaSahmInDatabase(StrKalaSahmSN, cn, gSM.UserID_Name)
            Next
        End With

        Call cmbTaminKonadeh_TextChanged(sender, e)

    End Sub

    Private Sub btnAddShoab_Click(sender As System.Object, e As System.EventArgs) Handles btnAddShoab.Click

        Dim StrKalaSN As String = ""
        Dim i As Int16
        Dim vCount_SeletedKala As Short
        Dim _Cls As New ClsDataAccessRule

        With DataView2.FlexGrid
            vCount_SeletedKala = .SelectedRows
            For i = 0 To vCount_SeletedKala - 1
                StrKalaSN = .TextMatrix(.SelectedRow(i), .ColIndex("KalaSahmSN"))
                If TxtDarsad.Text <> "" Then
                    _Cls.InsertKalaShoabSahmInDatabase(StrKalaSN, TxtTarikh.Text, CDec(TxtDarsad.Text), cn, gSM.UserID_Name)
                End If
            Next
        End With

        DataView3.Refresh()

    End Sub

End Class

