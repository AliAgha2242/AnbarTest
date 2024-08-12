' OK
'Author ::سعید غفاری 
'CreateDate ::  1389/11/09
'ModifiedDate::
'Description:: 
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports System.Data




Friend Class frmMohlateForoosh
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
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents pnlNavigationDet As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents dcbStatus As NetSql.Components.DataCombo
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents txtSabtDate As System.Windows.Forms.TextBox
    Public WithEvents lblFromDate As System.Windows.Forms.Label
    Public WithEvents dcbKala2 As NetSql.Components.DataCombo
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Public WithEvents txtMohlatDate As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Public WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents Panel6 As System.Windows.Forms.Panel
    Public WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Public WithEvents TxtEnghezaDate As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents pnlGridDet As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlNavigationDet = New System.Windows.Forms.Panel()
        Me.pnlCommandDet = New System.Windows.Forms.Panel()
        Me.pnlGridDet = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtMohlatDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSelect2 = New System.Windows.Forms.Button()
        Me.dcbKala2 = New NetSql.Components.DataCombo(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSabtDate = New System.Windows.Forms.TextBox()
        Me.dcbStatus = New NetSql.Components.DataCombo(Me.components)
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtEnghezaDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNavigationDet
        '
        Me.pnlNavigationDet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet.Location = New System.Drawing.Point(6, 382)
        Me.pnlNavigationDet.Name = "pnlNavigationDet"
        Me.pnlNavigationDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet.Size = New System.Drawing.Size(339, 33)
        Me.pnlNavigationDet.TabIndex = 8
        '
        'pnlCommandDet
        '
        Me.pnlCommandDet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet.Location = New System.Drawing.Point(398, 382)
        Me.pnlCommandDet.Name = "pnlCommandDet"
        Me.pnlCommandDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet.Size = New System.Drawing.Size(296, 33)
        Me.pnlCommandDet.TabIndex = 9
        '
        'pnlGridDet
        '
        Me.pnlGridDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet.Location = New System.Drawing.Point(1, 70)
        Me.pnlGridDet.Name = "pnlGridDet"
        Me.pnlGridDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet.Size = New System.Drawing.Size(693, 306)
        Me.pnlGridDet.TabIndex = 10
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(950, 453)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GridEX1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 453)
        Me.Panel1.TabIndex = 0
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.Location = New System.Drawing.Point(39, 86)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(203, 361)
        Me.GridEX1.TabIndex = 43
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = Global.Minoo.Applications.Anbar.RezervKala.My.Resources.Resources.Return_in
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(3, 86)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 361)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.Panel3.Controls.Add(Me.btnSelect)
        Me.Panel3.Controls.Add(Me.dcbKala)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel3.Size = New System.Drawing.Size(248, 81)
        Me.Panel3.TabIndex = 41
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(117, 41)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 12
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.Location = New System.Drawing.Point(23, 41)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 32)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "انتخاب"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'dcbKala
        '
        Me.dcbKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala.AutoSelectFirst = False
        Me.dcbKala.BackColor = System.Drawing.Color.White
        Me.dcbKala.BoundText = Nothing
        Me.dcbKala.BypassChangeEvent = False
        Me.dcbKala.DisplayText = ""
        Me.dcbKala.LateBindingTop = "100"
        Me.dcbKala.Location = New System.Drawing.Point(6, 14)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(198, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(208, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(698, 453)
        Me.SplitContainer2.SplitterDistance = 424
        Me.SplitContainer2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.pnlNavigationDet)
        Me.Panel2.Controls.Add(Me.pnlCommandDet)
        Me.Panel2.Controls.Add(Me.pnlGridDet)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 424)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.btnSelect2)
        Me.Panel4.Controls.Add(Me.TxtEnghezaDate)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtMohlatDate)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.dcbKala2)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtSabtDate)
        Me.Panel4.Controls.Add(Me.dcbStatus)
        Me.Panel4.Controls.Add(Me.lblFromDate)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel4.Size = New System.Drawing.Size(698, 69)
        Me.Panel4.TabIndex = 11
        '
        'txtMohlatDate
        '
        Me.txtMohlatDate.AcceptsReturn = True
        Me.txtMohlatDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMohlatDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMohlatDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMohlatDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMohlatDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMohlatDate.Location = New System.Drawing.Point(408, 37)
        Me.txtMohlatDate.MaxLength = 0
        Me.txtMohlatDate.Name = "txtMohlatDate"
        Me.txtMohlatDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMohlatDate.Size = New System.Drawing.Size(65, 21)
        Me.txtMohlatDate.TabIndex = 42
        Me.txtMohlatDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(478, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "مهلت فروش :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSelect2
        '
        Me.btnSelect2.Location = New System.Drawing.Point(4, 14)
        Me.btnSelect2.Name = "btnSelect2"
        Me.btnSelect2.Size = New System.Drawing.Size(88, 32)
        Me.btnSelect2.TabIndex = 40
        Me.btnSelect2.Text = "انتخاب"
        Me.btnSelect2.UseVisualStyleBackColor = True
        '
        'dcbKala2
        '
        Me.dcbKala2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala2.AutoSelectFirst = False
        Me.dcbKala2.BackColor = System.Drawing.Color.White
        Me.dcbKala2.BoundText = Nothing
        Me.dcbKala2.BypassChangeEvent = False
        Me.dcbKala2.DisplayText = ""
        Me.dcbKala2.LateBindingTop = "100"
        Me.dcbKala2.Location = New System.Drawing.Point(270, 10)
        Me.dcbKala2.MemFilter = ""
        Me.dcbKala2.Name = "dcbKala2"
        Me.dcbKala2.SeparatedData = Nothing
        Me.dcbKala2.Size = New System.Drawing.Size(352, 21)
        Me.dcbKala2.Source = Nothing
        Me.dcbKala2.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala2.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(628, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "کالا :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSabtDate
        '
        Me.txtSabtDate.AcceptsReturn = True
        Me.txtSabtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSabtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSabtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSabtDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSabtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSabtDate.Location = New System.Drawing.Point(557, 37)
        Me.txtSabtDate.MaxLength = 0
        Me.txtSabtDate.Name = "txtSabtDate"
        Me.txtSabtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSabtDate.Size = New System.Drawing.Size(65, 21)
        Me.txtSabtDate.TabIndex = 37
        Me.txtSabtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dcbStatus
        '
        Me.dcbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbStatus.AutoSelectFirst = False
        Me.dcbStatus.BackColor = System.Drawing.Color.White
        Me.dcbStatus.BoundText = Nothing
        Me.dcbStatus.BypassChangeEvent = False
        Me.dcbStatus.DisplayText = ""
        Me.dcbStatus.LateBindingTop = "100"
        Me.dcbStatus.Location = New System.Drawing.Point(171, 16)
        Me.dcbStatus.MemFilter = ""
        Me.dcbStatus.Name = "dcbStatus"
        Me.dcbStatus.SeparatedData = Nothing
        Me.dcbStatus.Size = New System.Drawing.Size(30, 21)
        Me.dcbStatus.Source = Nothing
        Me.dcbStatus.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbStatus.TabIndex = 10
        Me.dcbStatus.Visible = False
        '
        'lblFromDate
        '
        Me.lblFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFromDate.Location = New System.Drawing.Point(627, 41)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFromDate.Size = New System.Drawing.Size(55, 13)
        Me.lblFromDate.TabIndex = 36
        Me.lblFromDate.Text = "تاریخ ثبت :"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(208, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "وضعیت :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.Panel5)
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(698, 25)
        Me.Panel8.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(6, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel5.Size = New System.Drawing.Size(339, 1)
        Me.Panel5.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Red
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(398, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel6.Size = New System.Drawing.Size(296, 1)
        Me.Panel6.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Red
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.Location = New System.Drawing.Point(26, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel7.Size = New System.Drawing.Size(649, 1)
        Me.Panel7.TabIndex = 10
        '
        'TxtEnghezaDate
        '
        Me.TxtEnghezaDate.AcceptsReturn = True
        Me.TxtEnghezaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnghezaDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEnghezaDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEnghezaDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnghezaDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtEnghezaDate.Location = New System.Drawing.Point(270, 37)
        Me.TxtEnghezaDate.MaxLength = 0
        Me.TxtEnghezaDate.Name = "TxtEnghezaDate"
        Me.TxtEnghezaDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtEnghezaDate.Size = New System.Drawing.Size(65, 21)
        Me.TxtEnghezaDate.TabIndex = 44
        Me.TxtEnghezaDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(340, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "تارخ انقضاء :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMohlateForoosh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(950, 453)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "frmMohlateForoosh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعیین مهلت فروش"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmMohlateForoosh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMohlateForoosh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmMohlateForoosh()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As frmMohlateForoosh)
            m_vb6FormDefInstance = value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي رزرو شده تعريف شده است
    Public WithEvents DVabMohlateForoosh As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcTafsiliSN As NetSql.Components.DataCombo
    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcKalaSN As NetSql.Components.DataCombo

    ' جهت مشخص شدن نوع ورود اطلاعات در سطح فرم براي انبارجاري     واحدسنجش    تعداد درکارتن
    Private pNoeVoroodeAsnad As EnumNoeVoroodeAsnad

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFLX_aAnbaraNoeAnbar As AxVSFlexGrid

    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterSabtDateCtrl As NetSql.Components.CDateCtrl
    Private MinFilterMohlatDateCtrl As NetSql.Components.CDateCtrl
    Private MinFilterEnghezaDateCtrl As NetSql.Components.CDateCtrl
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl

    ' جهت استفاده در عمليات پشتيباني رويدادهاي گريد
    Private pRowNomber As Short

    Dim _KalaSN2, _KalaSN1, _MohlateForooshStatusSN1, _MohlateForooshStatusSN2 As Decimal
    Dim _SabtDate, _MohlatdaTe, _EnghezaDate As String

    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
    Private FunCommon As New Minoo.Applications.Anbar.Common.CSharedItem

    Private Sub frmAnbarKalaRezerv_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        ' تهيه سلکت براي مقدار دهي کامبو
        Dim vSql As String = _
            "SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION  SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " & _
            gAnbarSelected.ToString & "  )  "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        dcbKala2.LateBinding = True
        dcbKala2.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala2.SelectedValue = 0

        ' تهيه سلکت براي مقدار دهي کامبو
        'vSql = _
        '    "SELECT 'همه موارد' AS MohlateForooshStatusDS , 0 AS MohlateForooshStatusSN UNION  SELECT DISTINCT MohlateForooshStatusDS ,MohlateForooshStatusSN From abMohlateForooshStatus"
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        'dcbStatus.LateBinding = True
        'dcbStatus.Bind(cn, vSql, "MohlateForooshStatusSN", "MohlateForooshStatusDS")
        'dcbStatus.SelectedValue = 0

        MinFilterSabtDateCtrl = New NetSql.Components.CDateCtrl(tp)
        With MinFilterSabtDateCtrl
            MinFilterSabtDateCtrl.TextBox = txtSabtDate
        End With
        MinFilterMohlatDateCtrl = New NetSql.Components.CDateCtrl(tp)
        MinFilterMohlatDateCtrl.DateFormat = EnumDateFormat.dfFullYear
        With MinFilterMohlatDateCtrl
            MinFilterMohlatDateCtrl.TextBox = txtMohlatDate
        End With
        MinFilterEnghezaDateCtrl = New NetSql.Components.CDateCtrl(tp)
        MinFilterEnghezaDateCtrl.DateFormat = EnumDateFormat.dfFullYear
        With MinFilterEnghezaDateCtrl
            MinFilterEnghezaDateCtrl.TextBox = TxtEnghezaDate
        End With

        'Dim vMinDateSetting As String
        Dim vSabtDate, vMohlatDate As String
        ' تهيه تاريخ از سرور
        vSabtDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        vMohlatDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        ' خواندن تاريخ تنظيمي کاربر
        'vMinDateSetting = GetSetting("Anbar", "Setting", "MinDateabRezerv" & "AnbarKalaRezerv", vMinDate)
        'MinFilterDateCtrl.Value = vMinDateSetting
        'If MinFilterDateCtrl.IsValid Then
        '    vMinDate = vMinDateSetting
        'End If

        InitDataView_KalaRahgiri()

        InitDataView_Mohlat()

    End Sub

    Private Sub frmAnbarKalaRezerv_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles Me.FormClosed

        'DVabKalaRahgiri.Done()
        'DVabKalaRahgiri = Nothing
        DVabMohlateForoosh.Done()
        DVabMohlateForoosh = Nothing

    End Sub

    Private Sub InitDataView_KalaRahgiri()
        Try
            Dim ds As DataSet = New DSMojoodi

            With GridEX1
                .DataSource = ds.Tables("TblMojoodi")
                .RetrieveStructure()

                .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
                .AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.False
                .AutoSizeColumns()
                .ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .GroupByBoxVisible = False
                .RowHeaders = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                .ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic
                .ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.Row
                .FilterMode = Janus.Windows.GridEX.FilterMode.None
                .AcceptsEscape = True
                .AllowColumnDrag = False
                .AutoEdit = False
                .RightToLeft = RightToLeft.Yes

                With .RootTable.Columns
                    With .Item("KalaNO")
                        .Caption = "کد کالا"
                    End With
                    With .Item("KalaDS")
                        .Caption = "شرح کالا"
                    End With
                    With .Item("ShomarehRahgiri")
                        .Caption = "کد رهگیری"
                        .Visible = False
                    End With
                    With .Item("KalaPhizikiSN")
                        .Visible = False
                    End With
                    With .Item("EnghezaDate")
                        .Caption = "تاریخ انقضاء"
                        '.FormatString = "#/#/#"
                    End With
                    With .Item("VahedeSanjeshDs")
                        .Caption = "واحد سنجش"
                    End With
                    With .Item("TedadAjza")
                        .Caption = "تعداد در کارتن"
                    End With
                    With .Item("Mojoodi")
                        .Caption = "موجودی"
                        .FormatString = "#,#"
                    End With
                    With .Item("Can_Mojoodi")
                        .Caption = "کارتن"
                        .FormatString = "#,#"
                    End With
                    With .Item("Box_Mojoodi")
                        .Caption = "عدد"
                        .FormatString = "#,#"
                    End With
                    .Item("KalaSN").Visible = False

                End With
                .RightToLeft = RightToLeft.Yes
                .AutoSizeColumns()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub InitDataView_Mohlat()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'Dim vSelect As String
        Dim vSql_where As String

        DVabMohlateForoosh = New CDataView(cn)
        With DVabMohlateForoosh
            .Init(pnlGridDet, , pnlCommandDet, pnlNavigationDet, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdPrint Or _
                                                                     EnumButtonOptions.boCmdFilter Or _
                                                                     EnumButtonOptions.boCmdExit)
            .TableName = "abMohlateForoosh"
            .Text = Me.Text
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abMohlateForooshStatus", "MohlateForooshStatusSN", _
                      "MohlateForooshStatusSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "pakala", "KalaSN", "KalaSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")

            '.AccessRight = gSM.TableAccessRight(.TableName)
            '.CommandEnabled(EnumCommands.cmDelete) = False
            .EditInGrid = True
            vSql_where = "1<>1"

            .SQLWhere = vSql_where
            .SQLOrderBy = " paKala.KalaNo , sabtDate DESC "
            With .Fields
                With .Add("MohlateForooshSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("KalaSN->pakala.{paKala.KalaNO + ' _ ' + paKala.KalaDS} AS Kalads", "DataCombo")
                    dbcKalaSN = .Component
                    .Caption = cn.FieldCaption("paKala.KalaDS")
                    dbcKalaSN.LateBinding = True
                    .ComboLateBinding = True
                End With
                With .Add("kalasn", , gSNFieldOption)
                    .Caption = "کد محصول"
                End With
                With .Add("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDs AS VahedeSanjeshDs")
                    .Caption = cn.FieldCaption("paVahedeSanjesh.VahedeSanjeshDs")
                    .ComboLateBinding = True
                End With

                With .Add("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza")
                    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.TedadAjza")
                    .ComboLateBinding = True
                End With

                With .Add("KalaPhizikiSN", "TextBox <Enabled>", EnumFieldOptions.foHidden)
                    .Caption = "شماره رهگیری"
                End With
                With .Add("MohlatDate", "TextBox <Enabled>", EnumFieldOptions.foDate)
                    '.TimeFormat = EnumTimeFormat.tfHour Or EnumTimeFormat.tfMinute Or EnumTimeFormat.tfSecond
                    .Caption = "مهلت تحقق"
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                            cn, _
                                                                            Functions. _
                                                                               FTDBCommonFunctions. _
                                                                               enmDateFormat.Normal)
                End With
                With .Add("SabtDate", "TextBox <Enabled>", EnumFieldOptions.foDefault)
                    .Caption = "تاریخ ثبت"
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                    .ReadOnly = True
                End With
                With .Add("Mojoodi", "TextBox", EnumFieldOptions.foHidden)
                    .Caption = "موجودی"
                    .MaxLength = 10
                    '.ReadOnly = True
                End With

                With .Add("MeghdareForoosh", "TextBox <Enabled>", EnumFieldOptions.foHidden)
                    .Caption = "مقدار انتظار"
                    .MaxLength = 100
                    .AllowNulls = False
                End With

                With .Add("MohlateForooshStatusSN->abMohlateForooshStatus.MohlateForooshStatusDS", "DataCombo", EnumFieldOptions.foHidden)
                    .Caption = "وضعیت"
                    .DefaultValue = 1.935
                End With

                With .Add("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
                End With
                With .Add("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = gAnbarSN
                End With

                With .Add("ToolidDate", "TextBox <Enabled>", EnumFieldOptions.foHidden)
                    .Caption = "تاریخ تولید"
                    .MaxLength = 100
                    '.AllowNulls = False
                    .ReadOnly = True
                End With
                With .Add("EnghezaDate", "TextBox <Enabled>", EnumFieldOptions.foDefault)
                    .Caption = "تاریخ انقضاء"
                    .MaxLength = 100
                    '.AllowNulls = False
                    .ReadOnly = True
                End With
                With .Add("UserID_Name", "TextBox <Enabled>", EnumFieldOptions.foDefault)
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "ثبت کننده"
                    .MaxLength = 100
                    .ReadOnly = True
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                    .Caption = "ماشین"
                End With
                '.Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With

    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnSelect.Click

        ' '' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' '' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate As String = ""
        Dim vToDate As String = ""
        Dim vErrMsg As String = ""
        Dim vStrKalaSN As String = ""
        Dim vStrFilterSelectedGoroohSN As String = ""
        Dim vStrFilterSelectedChidemanSN As String = ""
        Dim strAnbars As Object = ""
        Dim strTarakoneshs As String = ""
        Dim vSanadStatus As String = ""
        Dim vNoeTarakoneshKalaNO As String = ""
        Dim vRezerv As String = ""
        Dim vIsMahaleChideman As Short
        Dim vFromShomarehRahgiri As String = ""
        Dim vToShomarehRahgiri As String = ""
        Dim vFromSabtDate As String = ""
        Dim vToSabtDate As String = ""
        Dim vFromShomarehSefaresh As String = ""
        Dim vToShomarehSefaresh As String = ""
        Dim vTozih As String = ""
        Dim vTafsiiSN As String = ""
        Dim vNoeZayeatSN As String = ""
        Dim vNoeMarjooeiSN As String = ""

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(VFilterAsnadAnbar.SelectedFromSanadDate) <> "" Then
            vFromDate = Trim(VFilterAsnadAnbar.SelectedFromSanadDate.ToString)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(VFilterAsnadAnbar.SelectedToSanadDate) <> "" Then
            vToDate = Trim(VFilterAsnadAnbar.SelectedToSanadDate.ToString)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = gAnbarSN.ToString
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedTarakoneshSN) <> "" Then
                strTarakoneshs = VFilterAsnadAnbar.SelectedTarakoneshSN.ToString
            End If
            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN.ToString
            End If
            If Trim(VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN) <> "" Then
                vStrFilterSelectedChidemanSN = VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedMahaleChideman) <> "" Then
                vIsMahaleChideman = VFilterAsnadAnbar.SelectedMahaleChideman.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala.ToString
            End If
            If Trim(VFilterAsnadAnbar.SelectedRezerv) <> "" Then
                vRezerv = VFilterAsnadAnbar.SelectedRezerv
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromSabtDate) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToSabtDate) <> "" Then
                vFromSabtDate = Trim(VFilterAsnadAnbar.SelectedFromSabtDate)
                vToSabtDate = Trim(VFilterAsnadAnbar.SelectedToSabtDate)
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromShomarehSefaresh) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToShomarehSefaresh) <> "" Then
                vFromShomarehSefaresh = Trim(VFilterAsnadAnbar.SelectedFromShomarehSefaresh)
                vToShomarehSefaresh = Trim(VFilterAsnadAnbar.SelectedToShomarehSefaresh)
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromShomarehRahgiri) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToShomarehRahgiri) <> "" Then
                vFromShomarehRahgiri = Trim(VFilterAsnadAnbar.SelectedFromShomarehRahgiri)
                vToShomarehRahgiri = Trim(VFilterAsnadAnbar.SelectedToShomarehRahgiri)
            End If

            If Trim(VFilterAsnadAnbar.SelectedTozih) <> "" Then
                vTozih = Trim(VFilterAsnadAnbar.SelectedTozih)
            End If

            If Trim(VFilterAsnadAnbar.SelectedTafsiliSN) <> "" Then
                vTafsiiSN = Trim(VFilterAsnadAnbar.SelectedTafsiliSN)
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeZayeatSN) <> "" Then
                vNoeZayeatSN = Trim(VFilterAsnadAnbar.SelectedNoeZayeatSN)
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN) <> "" Then
                vNoeMarjooeiSN = Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN)
            End If

            Me.Cursor = Cursors.WaitCursor

            If Trim(dcbKala.BoundText) <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If vStrKalaSN <> "" Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If

            End If

            Dim ds As DataSet = New DSMojoodi

            Dim _Prr As Object() = {"@Command", "", _
                                    "@VahedeTejariSN", gVahedeTejariSN, _
                                   "@StrAnbarSN", strAnbars, _
                                   "@FromDate", CStr(vFromDate), _
                                   "@ToDate", vToDate, _
                                   "@StrKalaSN", vStrKalaSN, _
                                   "@SanadStatus", vSanadStatus, _
                                   "@NoeTarakoneshKalaNO", vNoeTarakoneshKalaNO, _
                                   "@Rezerv", vRezerv, _
                                   "@StrTarakoneshSN", strTarakoneshs, _
                                   "@StrFilterSelectedGoroohSN", vStrFilterSelectedGoroohSN, _
                                   "@StrFilterSelectedChidemanSN", vStrFilterSelectedChidemanSN, _
                                   "@IsMahaleChideman", vIsMahaleChideman, _
                                   "@FromSabtDate", vFromSabtDate, _
                                   "@ToSabtDate", vToSabtDate, _
                                   "@FromShomarehSefaresh", vFromShomarehSefaresh, _
                                   "@ToShomarehSefaresh", vToShomarehSefaresh, _
                                   "@FromShomarehRahgiri", vFromShomarehRahgiri, _
                                   "@ToShomarehRahgiri", vToShomarehRahgiri, _
                                   "@Tozih", vTozih, _
                                   "@StrTafsiliSN", vTafsiiSN, _
                                   "@StrNoeZayeatSN", vNoeZayeatSN, _
                                   "@StrNoeMarjooeiSN", vNoeMarjooeiSN
                                    }

            FunCommon.DoFillDatasetSP(ds, "tblMojoodi", "_abSpG_MojoodiKalaPhiziki", _Prr, cn, tp)

            GridEX1.DataSource = ds.Tables("tblMojoodi")
            GridEX1.Refresh()

            Me.Cursor = Cursors.Default
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub btnSelect2_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnSelect2.Click

        If Val(dcbKala2.BoundText) <> 0 Then
            _KalaSN2 = dcbKala2.BoundText
        Else
            _KalaSN2 = 0
        End If
        If Val(dcbStatus.BoundText) <> 0 Then
            _MohlateForooshStatusSN2 = dcbStatus.BoundText
        Else
            _MohlateForooshStatusSN2 = 0
        End If


        If MinFilterSabtDateCtrl.IsValid AndAlso MinFilterSabtDateCtrl.Text <> "" Then
            _SabtDate = MinFilterSabtDateCtrl.Value
        Else
            _SabtDate = ""
        End If

        If MinFilterMohlatDateCtrl.IsValid AndAlso MinFilterMohlatDateCtrl.Text <> "" Then
            _MohlatdaTe = MinFilterMohlatDateCtrl.Value
        Else
            _MohlatdaTe = ""
        End If

        If MinFilterEnghezaDateCtrl.IsValid AndAlso MinFilterEnghezaDateCtrl.Text <> "" Then
            _EnghezaDate = MinFilterEnghezaDateCtrl.Value
        Else
            _EnghezaDate = ""
        End If

        With DVabMohlateForoosh

            .SQLWhere = "(" + _KalaSN2.ToString + " = 0 OR abMohlateForoosh.kalaSn = " & _KalaSN2 & "  ) And  " + _
                        "(" + _MohlateForooshStatusSN2.ToString & "  = 0 OR  abMohlateForoosh.MohlateForooshStatusSN = " & _MohlateForooshStatusSN2 & "   ) And " + _
                        "(" + "'" & _SabtDate & "'" + " = '' OR abMohlateForoosh.SabtDate = '" & _SabtDate & "'   ) And " + _
                        "(" + "'" & _EnghezaDate & "'" + " = '' OR abMohlateForoosh.EnghezaDate = '" & _EnghezaDate & "'   ) And " + _
                        "(" + "'" & _MohlatdaTe & "'" + " = '' OR abMohlateForoosh.Mohlatdate = '" & _MohlatdaTe & "'  )  "

            .Refresh()
        End With
    End Sub

    Private Sub btnFilterAsnadAnbar_Click(sender As System.Object, e As System.EventArgs) Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود

        With VFilterAsnadAnbar
            .EnableFromSanadDate = False
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleRezerv = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleNoeTarakoneshKala = True
            .VisibleChidemanKala = True
            .VisibleAnbar = True

            .VisibleSabtDate = True
            .EnableFromSabtDate = True
            .VisibleShomarehSefaresh = True
            .VisibleShomarehRahgiri = True
            .VisibleTarakonesh = True
            .VisibleTozih = True
            .VisibleTafsili = True
            .VisibleNoeZayeat = True
            .VisibleNoeMarjooei = True

            .ShowDialog(Me)

        End With
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
            Dim dgrow As Janus.Windows.GridEX.GridEXRow
        If GridEX1.GetRow() Is Nothing Then Exit Sub
        dgrow = GridEX1.GetRow()

        Dim _KalaSN As Decimal = CDec(dgrow.Cells("KalaSN").Value)
        Dim _KalaphizikiSN As Decimal = dgrow.Cells("KalaphizikiSN").Value
        Dim _SabtDate As String = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        Dim _MohlatDate As String = _SabtDate
        Dim _Mojoodi As Double = dgrow.Cells("Mojoodi").Value
        Dim _EnghezaDate As String = dgrow.Cells("EnghezaDate").Value

        MinFilterSabtDateCtrl.Text = _SabtDate
        _SabtDate = MinFilterSabtDateCtrl.Value
        MinFilterEnghezaDateCtrl.Text = _EnghezaDate
        _EnghezaDate = MinFilterEnghezaDateCtrl.Value

        Dim _Errmsg As String = ""

        If _SabtDate = "" OrElse _MohlatDate = "" Then
            CSystem.MsgBox("تاریخ ثبت معتبر نمی باشد", vbOKOnly, "توجه")
            Exit Sub
        End If

        cn.CallSP("abMohlateForoosh_Insert", gSM.Identifier, _KalaSN,
                    _KalaphizikiSN, _SabtDate, _MohlatDate, CDec(_Mojoodi), CDec(0), _
                    1.935, gVahedeTejariSN, gAnbarSN, System.DBNull.Value, _EnghezaDate, _
                    gSM.UserID_Name, System.Environment.MachineName, System.DBNull.Value)

        If Len(_Errmsg) > 0 Then
            CSystem.MsgBox(_Errmsg, vbOKOnly, "توجه")
            Exit Sub
        End If

        btnSelect2_Click(sender, e)


    End Sub

    Private Sub GridEX1_DoubleClick(sender As Object, e As System.EventArgs) Handles GridEX1.DoubleClick
        btnAdd_Click(sender, e)
    End Sub

    Private Sub DVabMohlateForoosh_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
           Handles DVabMohlateForoosh.CommandClick


        Select Case aCommand
            Case EnumCommands.cmDelete
                If Val(DVabMohlateForoosh.Fields("UserId_NAme").Value) <> gSM.UserID_Name Then
                    CSystem.MsgBox("رکورد انتخاب شده توسط شما ایجاد نشده است لذا مجاز به حذف نمی باشید", vbOKOnly, "توجه")
                    Exit Sub
                End If
        End Select
        '    

        'Dim V_NoeAnbarSN, V_VahedeTejariSN, V_AnbarSN, V_Mojoodi As Decimal
        'Dim V_KalaNO As String
        'Dim vResult As Short
        'Static vcmAdd As Boolean
        'Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        'Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer, vKalaSN As Object

        'If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh Or _
        '        aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint Or _
        '        aCommand = EnumCommands.cmFilter) Then
        '    ' بدست آوردن اطلاعات جانبي کالا
        '    If Val(DVabMohlateForoosh.Fields("KalaSN").Value) <> 0 Then
        '        vKalaSN = Val(DVabMohlateForoosh.Fields("KalaSN").Value)
        '        vResult = cn.CallSP("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value, _
        '                             System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo, _
        '                             VinVahedeSanjeshDs, VinTedadAjza)
        '    End If
        'End If

        'Select Case aCommand
        '    Case EnumCommands.cmEdit
        '        vcmAdd = False
        '        If Val(DVabMohlateForoosh.Fields("AnbarKalaRezervStatus").Value) = 0 Then
        '            aCancel = True
        '        End If
        '    Case EnumCommands.cmAdd
        '        vcmAdd = True
        '    Case EnumCommands.cmSave
        '        If vcmAdd Then
        '            If pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton And _
        '               Val(DVabMohlateForoosh.Fields("MeghdarRezerv").Value) = 0 Then
        '                DVabMohlateForoosh.Fields("MeghdarRezerv").Value = Val( _
        '                                                                          DVabMohlateForoosh.Fields("Box"). _
        '                                                                             Value) _
        '                                                                     * VinTedadAjza _
        '                                                                     + _
        '                                                                     Val( _
        '                                                                          DVabMohlateForoosh.Fields("Can"). _
        '                                                                             Value)
        '            End If
        '            V_VahedeTejariSN = DVabVw_AnbarNoeAnbar.Fields("VahedeTejariSN").Value
        '            V_AnbarSN = DVabVw_AnbarNoeAnbar.Fields("AnbarSN").Value
        '            V_NoeAnbarSN = DVabVw_AnbarNoeAnbar.Fields("NoeAnbarSN").Value
        '            V_KalaNO = VinKalano
        '            If Trim(V_KalaNO) <> "" Then
        '                ' گنترل مقدار موجودي کالا براي ثبت رزرو کالا
        '                vResult = cn.CallSP("_abSPG_GetMojoodiKala", V_VahedeTejariSN, V_AnbarSN _
        '                                     , V_NoeAnbarSN, V_KalaNO, V_Mojoodi)
        '                If Val(CStr(V_Mojoodi)) < DVabMohlateForoosh.Fields("MeghdarRezerv").Value Then
        '                    aCancel = True
        '                    NetSql.Common.CSystem.MsgBox("مقدار رزرو بيشتر از موجودي كالا ميباشد", _
        '                               MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, _
        '                               Me.Text)
        '                    Exit Sub
        '                Else
        '                    aCancel = False
        '                End If
        '            End If
        '            ' تهيه تاريخ از سرور
        '            DVabMohlateForoosh.Fields("LastTime").Value = _
        '                Minoo.Functions.FTDBCommonFunctions.Get_Time_Server( _
        '                                                                     cn, _
        '                                                                     Functions.FTDBCommonFunctions.enmTimeFormat _
        '                                                                        .HHmmss)
        '            DVabMohlateForoosh.Fields("LastDate").Value = _
        '                Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
        '                                                                            cn, _
        '                                                                            Functions.FTDBCommonFunctions. _
        '                                                                               enmDateFormat.Normal)
        '        End If
        '        If DVabMohlateForoosh.State <> EnumDataViewState.bsAdd Then
        '            vcmAdd = False
        '        End If
        '    Case EnumCommands.cmAbort
        '        vcmAdd = False
        '    Case EnumCommands.cmDelete
        '        vcmAdd = False
        'End Select

    End Sub

End Class



