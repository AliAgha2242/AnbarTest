' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/04/22
'ModifiedDate::
'Description::   جهت اصلاح طرف حساب يک سند انبار
' اسناد قطعي شده که نياز به اصلاح طرف حساب داشته باشند بوشيله اين فرم اصلاح خواهند شد
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmabEslahSanadKharid
    Inherits System.Windows.Forms.Form

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
    Public WithEvents btnStatus4_8 As System.Windows.Forms.Button
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigation As System.Windows.Forms.Panel
    Public WithEvents btnCommands As System.Windows.Forms.Panel
    Public WithEvents dbcSanadNo As NetSql.Components.DataCombo
    Public WithEvents txtEslahSanadNo As System.Windows.Forms.TextBox
    Public WithEvents txtNewSanadDate As System.Windows.Forms.TextBox
    Public WithEvents txtSanadDate As System.Windows.Forms.TextBox
    Public WithEvents txtEslahSanadSN As System.Windows.Forms.TextBox
    Public WithEvents dcbNewTarakoneshSN As NetSql.Components.DataCombo
    Public WithEvents dbcNewTafsiliSN As NetSql.Components.DataCombo
    Public WithEvents lblEslahSanadNo As System.Windows.Forms.Label
    Public WithEvents lblSanadStatus As System.Windows.Forms.Label
    Public WithEvents lblNewTafsiliSN As System.Windows.Forms.Label
    Public WithEvents lblSanadNO As System.Windows.Forms.Label
    Public WithEvents lblEslahSanadDate As System.Windows.Forms.Label
    Public WithEvents lblNewTarakoneshSN As System.Windows.Forms.Label
    Public WithEvents lblNewSanadDate As System.Windows.Forms.Label
    Public WithEvents pnlDetails As System.Windows.Forms.Panel
    Public WithEvents m_sstParent_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents pnlGrid As System.Windows.Forms.Panel
    Public WithEvents m_sstParent_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents sstParent As Minoo.Controls.FTTabControl
    Public WithEvents dbcEslahSanadStatus As NetSql.Components.DataCombo
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dbcNewTafsiliSN1 As NetSql.Components.DataCombo

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmabEslahSanadKharid))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnStatus4_8 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.txtMinDate = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.btnCommands = New System.Windows.Forms.Panel()
        Me.sstParent = New Minoo.Controls.FTTabControl()
        Me.m_sstParent_TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.m_sstParent_TabPage0 = New System.Windows.Forms.TabPage()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.dbcNewTafsiliSN1 = New NetSql.Components.DataCombo(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dbcSanadNo = New NetSql.Components.DataCombo(Me.components)
        Me.txtEslahSanadNo = New System.Windows.Forms.TextBox()
        Me.txtNewSanadDate = New System.Windows.Forms.TextBox()
        Me.txtSanadDate = New System.Windows.Forms.TextBox()
        Me.txtEslahSanadSN = New System.Windows.Forms.TextBox()
        Me.dbcEslahSanadStatus = New NetSql.Components.DataCombo(Me.components)
        Me.dcbNewTarakoneshSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcNewTafsiliSN = New NetSql.Components.DataCombo(Me.components)
        Me.lblEslahSanadNo = New System.Windows.Forms.Label()
        Me.lblSanadStatus = New System.Windows.Forms.Label()
        Me.lblNewTafsiliSN = New System.Windows.Forms.Label()
        Me.lblSanadNO = New System.Windows.Forms.Label()
        Me.lblEslahSanadDate = New System.Windows.Forms.Label()
        Me.lblNewTarakoneshSN = New System.Windows.Forms.Label()
        Me.lblNewSanadDate = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.sstParent.SuspendLayout()
        Me.m_sstParent_TabPage1.SuspendLayout()
        Me.m_sstParent_TabPage0.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStatus4_8
        '
        Me.btnStatus4_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus4_8.BackColor = System.Drawing.SystemColors.Control
        Me.btnStatus4_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStatus4_8.Enabled = False
        Me.btnStatus4_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStatus4_8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStatus4_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatus4_8.Location = New System.Drawing.Point(213, 234)
        Me.btnStatus4_8.Name = "btnStatus4_8"
        Me.btnStatus4_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStatus4_8.Size = New System.Drawing.Size(57, 37)
        Me.btnStatus4_8.TabIndex = 28
        Me.btnStatus4_8.Text = "قطعي"
        Me.btnStatus4_8.UseVisualStyleBackColor = False
        Me.btnStatus4_8.Visible = False
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtMinDate)
        Me.Frame1.Controls.Add(Me.btnFilter)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(240, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(192, 25)
        Me.Frame1.TabIndex = 15
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point(63, 2)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size(65, 23)
        Me.txtMinDate.TabIndex = 17
        Me.txtMinDate.Tag = ""
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(6, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size(51, 21)
        Me.btnFilter.TabIndex = 18
        Me.btnFilter.Text = "انتخاب"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(135, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "از تاريخ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlNavigation
        '
        Me.pnlNavigation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigation.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigation.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigation.Location = New System.Drawing.Point(9, 234)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigation.Size = New System.Drawing.Size(198, 37)
        Me.pnlNavigation.TabIndex = 7
        '
        'btnCommands
        '
        Me.btnCommands.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommands.BackColor = System.Drawing.SystemColors.Control
        Me.btnCommands.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCommands.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCommands.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCommands.Location = New System.Drawing.Point(273, 234)
        Me.btnCommands.Name = "btnCommands"
        Me.btnCommands.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCommands.Size = New System.Drawing.Size(399, 37)
        Me.btnCommands.TabIndex = 6
        '
        'sstParent
        '
        Me.sstParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstParent.Controls.Add(Me.m_sstParent_TabPage1)
        Me.sstParent.Controls.Add(Me.m_sstParent_TabPage0)
        Me.sstParent.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstParent.ItemSize = New System.Drawing.Size(42, 23)
        Me.sstParent.Location = New System.Drawing.Point(2, 0)
        Me.sstParent.Mirrored = True
        Me.sstParent.Name = "sstParent"
        Me.sstParent.SelectedIndex = 0
        Me.sstParent.Size = New System.Drawing.Size(676, 234)
        Me.sstParent.TabIndex = 1
        '
        'm_sstParent_TabPage1
        '
        Me.m_sstParent_TabPage1.Controls.Add(Me.pnlGrid)
        Me.m_sstParent_TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.m_sstParent_TabPage1.Name = "m_sstParent_TabPage1"
        Me.m_sstParent_TabPage1.Size = New System.Drawing.Size(668, 203)
        Me.m_sstParent_TabPage1.TabIndex = 1
        Me.m_sstParent_TabPage1.Text = "مشاهده كليه اصلاحات"
        '
        'pnlGrid
        '
        Me.pnlGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGrid.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrid.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGrid.Location = New System.Drawing.Point(3, 3)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGrid.Size = New System.Drawing.Size(663, 203)
        Me.pnlGrid.TabIndex = 2
        '
        'm_sstParent_TabPage0
        '
        Me.m_sstParent_TabPage0.Controls.Add(Me.pnlDetails)
        Me.m_sstParent_TabPage0.Location = New System.Drawing.Point(4, 27)
        Me.m_sstParent_TabPage0.Name = "m_sstParent_TabPage0"
        Me.m_sstParent_TabPage0.Size = New System.Drawing.Size(668, 203)
        Me.m_sstParent_TabPage0.TabIndex = 0
        Me.m_sstParent_TabPage0.Text = "مشاهده اصلاح خاص"
        '
        'pnlDetails
        '
        Me.pnlDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetails.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.dbcNewTafsiliSN1)
        Me.pnlDetails.Controls.Add(Me.Label2)
        Me.pnlDetails.Controls.Add(Me.dbcSanadNo)
        Me.pnlDetails.Controls.Add(Me.txtEslahSanadNo)
        Me.pnlDetails.Controls.Add(Me.txtNewSanadDate)
        Me.pnlDetails.Controls.Add(Me.txtSanadDate)
        Me.pnlDetails.Controls.Add(Me.txtEslahSanadSN)
        Me.pnlDetails.Controls.Add(Me.dbcEslahSanadStatus)
        Me.pnlDetails.Controls.Add(Me.dcbNewTarakoneshSN)
        Me.pnlDetails.Controls.Add(Me.dbcNewTafsiliSN)
        Me.pnlDetails.Controls.Add(Me.lblEslahSanadNo)
        Me.pnlDetails.Controls.Add(Me.lblSanadStatus)
        Me.pnlDetails.Controls.Add(Me.lblNewTafsiliSN)
        Me.pnlDetails.Controls.Add(Me.lblSanadNO)
        Me.pnlDetails.Controls.Add(Me.lblEslahSanadDate)
        Me.pnlDetails.Controls.Add(Me.lblNewTarakoneshSN)
        Me.pnlDetails.Controls.Add(Me.lblNewSanadDate)
        Me.pnlDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlDetails.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDetails.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlDetails.Size = New System.Drawing.Size(663, 203)
        Me.pnlDetails.TabIndex = 9
        Me.pnlDetails.TabStop = True
        '
        'dbcNewTafsiliSN1
        '
        Me.dbcNewTafsiliSN1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcNewTafsiliSN1.AutoSelectFirst = False
        Me.dbcNewTafsiliSN1.BackColor = System.Drawing.Color.White
        Me.dbcNewTafsiliSN1.BoundText = Nothing
        Me.dbcNewTafsiliSN1.BypassChangeEvent = False
        Me.dbcNewTafsiliSN1.DisplayText = ""
        Me.dbcNewTafsiliSN1.LateBindingTop = "100"
        Me.dbcNewTafsiliSN1.Location = New System.Drawing.Point(135, 91)
        Me.dbcNewTafsiliSN1.MemFilter = ""
        Me.dbcNewTafsiliSN1.Name = "dbcNewTafsiliSN1"
        Me.dbcNewTafsiliSN1.SeparatedData = Nothing
        Me.dbcNewTafsiliSN1.Size = New System.Drawing.Size(408, 21)
        Me.dbcNewTafsiliSN1.Source = Nothing
        Me.dbcNewTafsiliSN1.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcNewTafsiliSN1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(546, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "طرف حساب 2"
        '
        'dbcSanadNo
        '
        Me.dbcSanadNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcSanadNo.AutoSelectFirst = False
        Me.dbcSanadNo.BackColor = System.Drawing.SystemColors.Window
        Me.dbcSanadNo.BoundText = Nothing
        Me.dbcSanadNo.BypassChangeEvent = False
        Me.dbcSanadNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbcSanadNo.DisplayText = ""
        Me.dbcSanadNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dbcSanadNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dbcSanadNo.LateBindingTop = "100"
        Me.dbcSanadNo.Location = New System.Drawing.Point(255, 37)
        Me.dbcSanadNo.MemFilter = ""
        Me.dbcSanadNo.Name = "dbcSanadNo"
        Me.dbcSanadNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dbcSanadNo.SeparatedData = Nothing
        Me.dbcSanadNo.Size = New System.Drawing.Size(288, 21)
        Me.dbcSanadNo.Source = Nothing
        Me.dbcSanadNo.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcSanadNo.TabIndex = 39
        '
        'txtEslahSanadNo
        '
        Me.txtEslahSanadNo.AcceptsReturn = True
        Me.txtEslahSanadNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtEslahSanadNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEslahSanadNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtEslahSanadNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEslahSanadNo.Location = New System.Drawing.Point(6, 12)
        Me.txtEslahSanadNo.MaxLength = 0
        Me.txtEslahSanadNo.Name = "txtEslahSanadNo"
        Me.txtEslahSanadNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEslahSanadNo.Size = New System.Drawing.Size(143, 21)
        Me.txtEslahSanadNo.TabIndex = 37
        Me.txtEslahSanadNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewSanadDate
        '
        Me.txtNewSanadDate.AcceptsReturn = True
        Me.txtNewSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNewSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNewSanadDate.Location = New System.Drawing.Point(414, 150)
        Me.txtNewSanadDate.MaxLength = 0
        Me.txtNewSanadDate.Name = "txtNewSanadDate"
        Me.txtNewSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNewSanadDate.Size = New System.Drawing.Size(89, 21)
        Me.txtNewSanadDate.TabIndex = 34
        Me.txtNewSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSanadDate
        '
        Me.txtSanadDate.AcceptsReturn = True
        Me.txtSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSanadDate.Location = New System.Drawing.Point(453, 6)
        Me.txtSanadDate.MaxLength = 0
        Me.txtSanadDate.Name = "txtSanadDate"
        Me.txtSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSanadDate.Size = New System.Drawing.Size(89, 21)
        Me.txtSanadDate.TabIndex = 0
        Me.txtSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEslahSanadSN
        '
        Me.txtEslahSanadSN.AcceptsReturn = True
        Me.txtEslahSanadSN.BackColor = System.Drawing.SystemColors.Window
        Me.txtEslahSanadSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEslahSanadSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtEslahSanadSN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEslahSanadSN.Location = New System.Drawing.Point(548, 176)
        Me.txtEslahSanadSN.MaxLength = 0
        Me.txtEslahSanadSN.Name = "txtEslahSanadSN"
        Me.txtEslahSanadSN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEslahSanadSN.Size = New System.Drawing.Size(101, 21)
        Me.txtEslahSanadSN.TabIndex = 10
        Me.txtEslahSanadSN.Visible = False
        '
        'dbcEslahSanadStatus
        '
        Me.dbcEslahSanadStatus.AutoSelectFirst = False
        Me.dbcEslahSanadStatus.BackColor = System.Drawing.Color.White
        Me.dbcEslahSanadStatus.BoundText = Nothing
        Me.dbcEslahSanadStatus.BypassChangeEvent = False
        Me.dbcEslahSanadStatus.DisplayText = ""
        Me.dbcEslahSanadStatus.LateBindingTop = "100"
        Me.dbcEslahSanadStatus.Location = New System.Drawing.Point(50, 150)
        Me.dbcEslahSanadStatus.MemFilter = ""
        Me.dbcEslahSanadStatus.Name = "dbcEslahSanadStatus"
        Me.dbcEslahSanadStatus.SeparatedData = Nothing
        Me.dbcEslahSanadStatus.Size = New System.Drawing.Size(99, 21)
        Me.dbcEslahSanadStatus.Source = Nothing
        Me.dbcEslahSanadStatus.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcEslahSanadStatus.TabIndex = 29
        '
        'dcbNewTarakoneshSN
        '
        Me.dcbNewTarakoneshSN.AutoSelectFirst = False
        Me.dcbNewTarakoneshSN.BackColor = System.Drawing.Color.White
        Me.dcbNewTarakoneshSN.BoundText = Nothing
        Me.dcbNewTarakoneshSN.BypassChangeEvent = False
        Me.dcbNewTarakoneshSN.DisplayText = ""
        Me.dcbNewTarakoneshSN.LateBindingTop = "100"
        Me.dcbNewTarakoneshSN.Location = New System.Drawing.Point(298, 121)
        Me.dcbNewTarakoneshSN.MemFilter = ""
        Me.dcbNewTarakoneshSN.Name = "dcbNewTarakoneshSN"
        Me.dcbNewTarakoneshSN.SeparatedData = Nothing
        Me.dcbNewTarakoneshSN.Size = New System.Drawing.Size(245, 21)
        Me.dcbNewTarakoneshSN.Source = Nothing
        Me.dcbNewTarakoneshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNewTarakoneshSN.TabIndex = 35
        Me.dcbNewTarakoneshSN.Visible = False
        '
        'dbcNewTafsiliSN
        '
        Me.dbcNewTafsiliSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcNewTafsiliSN.AutoSelectFirst = False
        Me.dbcNewTafsiliSN.BackColor = System.Drawing.Color.White
        Me.dbcNewTafsiliSN.BoundText = Nothing
        Me.dbcNewTafsiliSN.BypassChangeEvent = False
        Me.dbcNewTafsiliSN.DisplayText = ""
        Me.dbcNewTafsiliSN.LateBindingTop = "100"
        Me.dbcNewTafsiliSN.Location = New System.Drawing.Point(135, 64)
        Me.dbcNewTafsiliSN.MemFilter = ""
        Me.dbcNewTafsiliSN.Name = "dbcNewTafsiliSN"
        Me.dbcNewTafsiliSN.SeparatedData = Nothing
        Me.dbcNewTafsiliSN.Size = New System.Drawing.Size(408, 21)
        Me.dbcNewTafsiliSN.Source = Nothing
        Me.dbcNewTafsiliSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcNewTafsiliSN.TabIndex = 36
        '
        'lblEslahSanadNo
        '
        Me.lblEslahSanadNo.BackColor = System.Drawing.Color.Transparent
        Me.lblEslahSanadNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEslahSanadNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblEslahSanadNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEslahSanadNo.Location = New System.Drawing.Point(153, 12)
        Me.lblEslahSanadNo.Name = "lblEslahSanadNo"
        Me.lblEslahSanadNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEslahSanadNo.Size = New System.Drawing.Size(90, 17)
        Me.lblEslahSanadNo.TabIndex = 38
        Me.lblEslahSanadNo.Text = "شماره اصلاح"
        '
        'lblSanadStatus
        '
        Me.lblSanadStatus.AutoSize = True
        Me.lblSanadStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblSanadStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadStatus.Location = New System.Drawing.Point(153, 152)
        Me.lblSanadStatus.Name = "lblSanadStatus"
        Me.lblSanadStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadStatus.Size = New System.Drawing.Size(44, 13)
        Me.lblSanadStatus.TabIndex = 30
        Me.lblSanadStatus.Text = "وضعيت"
        Me.lblSanadStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNewTafsiliSN
        '
        Me.lblNewTafsiliSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNewTafsiliSN.BackColor = System.Drawing.Color.Transparent
        Me.lblNewTafsiliSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewTafsiliSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblNewTafsiliSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewTafsiliSN.Location = New System.Drawing.Point(546, 69)
        Me.lblNewTafsiliSN.Name = "lblNewTafsiliSN"
        Me.lblNewTafsiliSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNewTafsiliSN.Size = New System.Drawing.Size(102, 17)
        Me.lblNewTafsiliSN.TabIndex = 23
        Me.lblNewTafsiliSN.Text = "طرف حساب"
        '
        'lblSanadNO
        '
        Me.lblSanadNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSanadNO.AutoSize = True
        Me.lblSanadNO.BackColor = System.Drawing.Color.Transparent
        Me.lblSanadNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSanadNO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblSanadNO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSanadNO.Location = New System.Drawing.Point(546, 42)
        Me.lblSanadNO.Name = "lblSanadNO"
        Me.lblSanadNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSanadNO.Size = New System.Drawing.Size(97, 13)
        Me.lblSanadNO.TabIndex = 13
        Me.lblSanadNO.Text = "شماره سند مرجع"
        Me.lblSanadNO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEslahSanadDate
        '
        Me.lblEslahSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEslahSanadDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEslahSanadDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEslahSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblEslahSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEslahSanadDate.Location = New System.Drawing.Point(546, 12)
        Me.lblEslahSanadDate.Name = "lblEslahSanadDate"
        Me.lblEslahSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEslahSanadDate.Size = New System.Drawing.Size(90, 15)
        Me.lblEslahSanadDate.TabIndex = 12
        Me.lblEslahSanadDate.Text = "تاريخ"
        '
        'lblNewTarakoneshSN
        '
        Me.lblNewTarakoneshSN.AutoSize = True
        Me.lblNewTarakoneshSN.BackColor = System.Drawing.Color.Transparent
        Me.lblNewTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblNewTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewTarakoneshSN.Location = New System.Drawing.Point(546, 123)
        Me.lblNewTarakoneshSN.Name = "lblNewTarakoneshSN"
        Me.lblNewTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNewTarakoneshSN.Size = New System.Drawing.Size(47, 13)
        Me.lblNewTarakoneshSN.TabIndex = 11
        Me.lblNewTarakoneshSN.Text = "تراكنش"
        Me.lblNewTarakoneshSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblNewTarakoneshSN.Visible = False
        '
        'lblNewSanadDate
        '
        Me.lblNewSanadDate.BackColor = System.Drawing.Color.Transparent
        Me.lblNewSanadDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblNewSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewSanadDate.Location = New System.Drawing.Point(510, 156)
        Me.lblNewSanadDate.Name = "lblNewSanadDate"
        Me.lblNewSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNewSanadDate.Size = New System.Drawing.Size(78, 13)
        Me.lblNewSanadDate.TabIndex = 31
        Me.lblNewSanadDate.Text = "تاريخ موثر"
        Me.lblNewSanadDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmabEslahSanadKharid
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(679, 274)
        Me.Controls.Add(Me.btnStatus4_8)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.btnCommands)
        Me.Controls.Add(Me.sstParent)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "FrmabEslahSanadKharid"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "اصلاح طرف حساب"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.sstParent.ResumeLayout(False)
        Me.m_sstParent_TabPage1.ResumeLayout(False)
        Me.m_sstParent_TabPage0.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabEslahSanadKharid
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabEslahSanadKharid
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabEslahSanadKharid
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabEslahSanadKharid)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  اصلاح سند تعريف شده است
    Private WithEvents DVabEslahSanad As CDataView
    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl

    Private Sub btnFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnFilter.Click
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات اصلاحيه بروز رساني ميگردد
        Dim vMinDate As String
        Dim vMaxDate As String
        'Dim vFilterDate As String
        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)

        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting(VB6.GetEXEName(), "Setting", "MinDateabEslahSanad", MinFilterDateCtrl.Value)
        End If
        MakeFilter(vMinDate, vMaxDate)
        DVabEslahSanad.Refresh()
    End Sub

    Private Sub DVabEslahSanad_BindDBComponent(ByRef aComponent As Object) _
        Handles DVabEslahSanad.BindDBComponent
        ' براي آنکه در ديتا کامبو از ستون هاي غير استاندارد ابزار ميخواهيم استفاده کنيم
        Dim vSql As String
        With dbcSanadNo
            If aComponent Is DVabEslahSanad.Fields("SanadNo").Component Then
                ' تهيه سلکت براي مقدار دهي کامبو
                vSql = " SELECT SanadSN , TarakoneshSN ,Sanaddate " & _
                       " , CONVERT(varchar(20),abSanad.SanadNo) + ' - ' + dbo.fdate(abSanad.SanadDate) AS SanadNo " & _
                       "  From abSanad " & _
                       "  Where abSanad.SanadStatus = 8 " & _
                       " AND abSanad.TafsiliSN IS NOT NULL " & _
                       " AND abSanad.TarakoneshSN Not IN ( 45 , 95 )  " & _
                       " AND abSanad.VahedeTejariSN =  " + CStr(gVahedeTejariSN) & _
                       " AND abSanad.AnbarSN =  " + CStr(gAnbarSN) & _
                       " AND abSanad.NoeAnbarSN =  " + CStr(gNoeAnbarSN) & _
                       " AND abSanad.SanadSN NOT IN ( SELECT  abEslahSanad.SanadSN From abEslahSanad  )  " & _
                       " AND abSanad.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate

                .LateBinding = True
                ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
                .Bind(cn, vSql, "SanadSN", "SanadNo")
                ' سلکت مورد نظر لحاظ ميگردد و رويه پيش فرض ابزار غير فعال ميگردد 
                DVabEslahSanad.IgnoreDefaultAction()
            End If
        End With

    End Sub

    Private Sub DVabEslahSanad_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabEslahSanad.CommandClick
        Static vcmAdd As Boolean
        Select Case aCommand
            Case EnumCommands.cmRefresh
            Case EnumCommands.cmSave
                If DVabEslahSanad.State <> EnumDataViewState.bsAdd Then
                    vcmAdd = False
                End If
            Case EnumCommands.cmAbort
                vcmAdd = False
            Case EnumCommands.cmEdit
                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
                vcmAdd = False
            Case EnumCommands.cmAdd
                If sstParent.SelectedIndex <> 1 Then
                    sstParent.SelectedIndex = 1
                    System.Windows.Forms.Application.DoEvents()
                End If
                vcmAdd = True
            Case EnumCommands.cmDelete
                vcmAdd = False
        End Select
    End Sub

    Private Sub DVabEslahSanad_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabEslahSanad.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        Dim vEslahSanadStatus As String
        Dim vEnabled_Status4_8 As Boolean

        ' در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DVabEslahSanad.FlexGrid.Rows = 1 Then
            Exit Sub
        End If
        vEslahSanadStatus = aClip("EslahSanadStatus")
        vEnabled_Status4_8 = (vEslahSanadStatus = "4")
        If vEnabled_Status4_8 Then
            ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
            vEnabled_Status4_8 = (gSM.TableAccessRight("abEslaheSanad4_8") And EnumAccessRight.arAll) <> 0
        End If
        With DVabEslahSanad
            .CommandEnabled(EnumCommands.cmEdit) = (.AccessRight And EnumAccessRight.arUpdate) <> 0 _
                                                    And vEnabled_Status4_8
            .CommandEnabled(EnumCommands.cmDelete) = vEnabled_Status4_8 _
                                                      And (.AccessRight And EnumAccessRight.arDelete) <> 0
        End With
        If aFetched Then
            btnStatus4_8.Enabled = aClip("EslahSanadStatus") = 4
            If DVabEslahSanad.AccessRight <> EnumAccessRight.arAll Then
                btnStatus4_8.Enabled = False
            End If
        End If
    End Sub

    Private Sub FrmabEslahSanadKharid_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        'Dim vSelect As String
        MinFilterDateCtrl = New NetSql.Components.CDateCtrl(tp)
        MinFilterDateCtrl.TextBox = txtMinDate
        Call InitDataView()
        Call InitForm()
        DVabEslahSanad.Refresh()
        btnStatus4_8.Visible = gSM.ActionVisible("abEslaheSanad4_8")
        Me.Text = "اصلاح طرف حساب خرید"
    End Sub

    Private Sub FrmabEslahSanadKharid_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        MinFilterDateCtrl.Done() : MinFilterDateCtrl = Nothing
        DVabEslahSanad.Done() : DVabEslahSanad = Nothing
    End Sub

    Private Sub MakeFilter(ByRef aMinDate As String, ByRef aMaxDate As String)
        ' با توجه به فيلتر فرم شرط ديتا ويو بروز رساني ميگردد
        With DVabEslahSanad
            .SQLWhere = " abEslahSanad.AnbarSN = " & gAnbarSN & _
                        " AND  abEslahSanad.EslahSanadDate >= '" & aMinDate & _
                        "' AND abEslahSanad.EslahSanadDate <= '" & aMaxDate & "'"
        End With
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vMinDateSetting As String ', vMaxDateSetting
        Dim vMaxDate, vMinDate As String
        Dim vSysDate As String

        ' تهيه تاريخ از سرور
        vSysDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        vMaxDate = vSysDate
        vMinDate = vSysDate
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabEslahSanad", vMinDate)
        MinFilterDateCtrl.Value = vMinDateSetting
        If MinFilterDateCtrl.IsValid Then
            vMinDate = vMinDateSetting
        End If

        DVabEslahSanad = New CDataView(cn)
        With DVabEslahSanad
            .Init(pnlGrid, pnlDetails, btnCommands, pnlNavigation, EnumButtonOptions.boCmdModify _
                                                                    Or EnumButtonOptions.boCmdExit Or _
                                                                    EnumButtonOptions.boCmdFind)
            .TableName = "abEslahSanad"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadStatus", "EslahSanadStatus", "SanadStatusSN")

            .Text = Me.Text
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = False
            .SQLWhere = "EslahSanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate
            Call MakeFilter(vMinDate, vMaxDate)
            With .Fields
                With .Add("EslahSanadSN", txtEslahSanadSN, gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("EslahSanadNo", txtEslahSanadNo)
                    .Component.Enabled = False
                    .ReadOnly = True
                    lblEslahSanadNo.Text = .Caption
                End With
                With .Add("EslahSanadDate", txtSanadDate, EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                    lblEslahSanadDate.Text = .Caption
                    If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
                        .MinValue = gHesabdariSalFDate
                        .MaxValue = gHesabdariSalTDate
                    End If
                End With
                With _
                    .Add( _
                          "SanadSN->{ CONVERT(varchar(20),abSanad.SanadNo) + ' - ' + dbo.fdate(abSanad.SanadDate) } AS SanadNo", _
                          dbcSanadNo)
                    .Caption = cn.FieldCaption("abEslahSanad.SanadSN")
                    .LockUpdate = True
                    dbcSanadNo.LateBinding = True
                End With
                With .Add("EslahSanadStatus->SanadStatusDS", dbcEslahSanadStatus)
                    .Caption = cn.FieldCaption("abEslahSanad.EslahSanadStatus")
                    .DefaultValue = 4
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                With .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .AllowNulls = True
                End With
                With .Add("AnbarSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gAnbarSN
                End With
                With .Add("NoeAnbarSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gNoeAnbarSN
                End With
                .Add("NewSanadDate", txtNewSanadDate, EnumFieldOptions.foHidden)
                .Add("NewTarakoneshSN", , EnumFieldOptions.foHidden)
                .Add("NewTarafHesabSN", , EnumFieldOptions.foHidden)
                With .Add("abSanad.TafsiliSN->{ maTafsili4.TafsiliNO + ' _ ' + maTafsili4.TafsiliDS} AS OldTafsiliSN ")
                    .Caption = cn.FieldCaption("abEslahSanad.OldTafsiliSN")
                End With
                With .Add("NewTafsiliSN->{ maTafsili.TafsiliNO + ' _ ' + maTafsili.TafsiliDS } AS NewTafsiliSN ", dbcNewTafsiliSN)
                    .Caption = cn.FieldCaption("abEslahSanad.NewTafsiliSN")
                    dbcNewTafsiliSN.LateBinding = True
                    .LockUpdate = True
                End With
                With .Add("NewTafsiliSN1->{maTafsili2.TafsiliNO + ' _ ' + maTafsili2.TafsiliDS} AS NewTafsiliSN1 ", dbcNewTafsiliSN1)
                    .Caption = cn.FieldCaption("abEslahSanad.NewTafsiliSN1")
                    dbcNewTafsiliSN1.LateBinding = True
                    .LockUpdate = True
                End With

                .Add("NewTafsiliSN2", , EnumFieldOptions.foHidden)
                .Add("NewEDAnbarSN", , EnumFieldOptions.foHidden)
                .Add("NewEDNoeAnbarSN", , EnumFieldOptions.foHidden)
                .Add("NewShomarehBarnameh", , EnumFieldOptions.foHidden)
                .Add("NewShomarehMashin", , EnumFieldOptions.foHidden)
                .Add("NewNameRanandeh", , EnumFieldOptions.foHidden)
                .Add("NewShomarehSefaresh", , EnumFieldOptions.foHidden)
                .Add("NewTarafHesab", , EnumFieldOptions.foHidden)
                .Add("NewVazneBaskool", , EnumFieldOptions.foHidden)
                .Add("NewShomareh1", , EnumFieldOptions.foHidden)
                .Add("NewShomareh2", , EnumFieldOptions.foHidden)
                .Add("NewTozih", , EnumFieldOptions.foHidden)
                With .Add("UserID_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With
        End With
    End Sub

    Private Sub InitForm()
        sstParent.SelectedIndex = 0
    End Sub

    Private Sub dbcNewTafsiliSN_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcNewTafsiliSN.Enter
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal, vTafsiliSN As Decimal
        Dim VComboWhereB As String
        Dim vGetTaraKoneshGoroohTafsiliSN As String

        vNoeAnbarSN = gNoeAnbarSN
        VComboWhereB = ""
        Dim TafsiliTable As String = If(gVahedeTejariSN <> 8.935, "maTafsili", "maTafsili")
        If Val(DVabEslahSanad.Fields("SanadNo").Value) <> 0 Then
            vTarakoneshSN = dbcSanadNo.CurrentDataRow.Item("TarakoneshSN")
            Select Case vTarakoneshSN
                Case EnumTarakoneshSN.RESIDE_12_ENTEGHAL_AZ_ANBAR_BE_KARGAH _
                    , EnumTarakoneshSN.HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH _
                    , EnumTarakoneshSN.HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH _
                    , EnumTarakoneshSN.RESIDE_37_DARYAFTE_MAHSOOL_AZ_KARGAH _
                    , EnumTarakoneshSN.RESIDE_21_DARYAFTE_MAHSOOL_AZ_KARGAH_ARD _
                    , EnumTarakoneshSN.RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP _
                    , EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR _
                    , EnumTarakoneshSN.RESIDE_17_BARGASHTE_BASTEBANDI_AZ_PAYEKAR _
                    , EnumTarakoneshSN.HAVALEH_83_BARGASHTE_MAHSOOL_AZ_PAYEKAR _
                    , EnumTarakoneshSN.HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD _
                    , EnumTarakoneshSN.RESIDE_42_DARYAFTE_ZAYEAT_AVALIE_AZ_KARGAH _
                    , EnumTarakoneshSN.RESIDE_32_DARYAFTE_ZAYEAT_BASTEBANDI_AZ_KARGAH _
                    , EnumTarakoneshSN.RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP _
                    , EnumTarakoneshSN.RESIDE_10_DARYAFTE_MAVADE_NIMSAKHTE_AS_PAYEKAR

                    VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                                   " AND (abAnbar.IsTajmie = 3) AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) &
                                   " )) "

                Case EnumTarakoneshSN.RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
                    , EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR
                    VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                                   " AND (abAnbar.IsTajmie = 2) AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) &
                                   " )) "
                Case EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                    'EnumTarakoneshSN.RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB _

                    VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " &
                                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " &
                                   " AND (abAnbar.IsTajmie = 2) " &
                                   " AND abAnbar.VahedeTejariSN  IN (3.935,4.935,7.935))) "

                Case EnumTarakoneshSN.HAVALEH_81_ZAYEAT
                    VComboWhereB =
                        " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar T1 INNER JOIN abAnbarTarakonesh T2 ON T1.AnbarSN = T2.AnbarSN " &
                        " Where ( ISNULL(T1.AnbarStatus,0) = 1 ) " &
                        " AND (T1.IsTajmie <> 1) AND T2.NoeAnbarSN = 5 " &
                        " AND T1.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            End Select

            If Val(DVabEslahSanad.Fields("NewTafsiliSN").Value) = 0 Then
                vGetTaraKoneshGoroohTafsiliSN =
                    CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVabEslahSanad.Fields("NewTafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN
                DVabEslahSanad.Fields("NewTafsiliSN").RefreshCombo()
            Else
                vTafsiliSN = DVabEslahSanad.Fields("NewTafsiliSN").Value
                vGetTaraKoneshGoroohTafsiliSN =
                    CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, vNoeAnbarSN, "maTafsili")
                DVabEslahSanad.Fields("NewTafsiliSN").ComboWhereCondition = vGetTaraKoneshGoroohTafsiliSN
                DVabEslahSanad.Fields("NewTafsiliSN").RefreshCombo()
                DVabEslahSanad.Fields("NewTafsiliSN").Value = vTafsiliSN
            End If
        Else
            DVabEslahSanad.Fields("NewTafsiliSN").ComboWhereCondition = " 1 = 3 "
            DVabEslahSanad.Fields("NewTafsiliSN").RefreshCombo()
        End If
    End Sub

    Private Sub btnStatus4_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStatus4_8.Click
        ' تبديل رکورد از حالت موقت به قطعي
        Dim vli_NewVaziat As Short
        Dim vErrMsg As String
        'Dim vSanadSN As Object
        Dim dvSanad As DataView
        Dim i As Integer

        If Not DVabEslahSanad.CommandEnabled(EnumCommands.cmEdit) Then Exit Sub
        If DVabEslahSanad.Fields("EslahSanadStatus").Value = "4" Then
            vli_NewVaziat = 8
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا اصلاحيه مورد نظر قطعي گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                         + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + _
                                                         MsgBoxStyle.MsgBoxRight _
                      , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        ' فراخواني اس پي براي تغيير وضعيت اصلاحيه 
        '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي
        Try
            If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()

            cn.BeginTrans(cn.Connection.BeginTransaction)
            cn.CallSP("_abSPC_Change_EslahSanadStatusKharid", DVabEslahSanad.Fields("EslahSanadSN").Value _
                       , vli_NewVaziat, gSM.UserID_Name, vErrMsg)
            If vli_NewVaziat = 8 Then
                dvSanad = _
                    cn.ExecuteQuery( _
                                     "SELECT T2.SanadSN FROM abEslahsanad T1 INNER JOIN abSanad T2 ON T1.SanadSN = T2.MarjaSanadSN WHERE T1.EslahSanadSN =" & _
                                     DVabEslahSanad.Fields("EslahSanadSN").Value)
                For i = 0 To dvSanad.Count - 1
                    CSanad.ErsaleHavaleBeShoab(dvSanad.Item(i).Item("SanadSN").ToString)
                    CSanad.ErsaleHavaleBeSherkateGorooh(dvSanad.Item(i).Item("SanadSN").ToString)
                Next
            End If

            cn.CommitTrans()
        Catch ex As Exception
            cn.RollbackTrans()
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
        '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.OkOnly + IIf(vli_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) + _
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            DVabEslahSanad.FetchCurRecord()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        DVabEslahSanad.Refresh()


    End Sub

    Private Sub dbcSanadNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcSanadNo.Enter
        ' با توجه به اطلاعات قبلي حالا شرط نمايش اطلاعات اين کامبو بروزآوري ميگردد
        Dim vSql As String
        Dim vEslahSanadDate As String
        With dbcSanadNo
            vEslahSanadDate = DVabEslahSanad.Fields("EslahSanadDate").Value
            ' تهيه سلکت براي مقدار دهي کامبو
            vSql = " SELECT SanadSN , TarakoneshSN ,Sanaddate " &
                   " , CONVERT(varchar(20),abSanad.SanadNo) + ' - ' + dbo.fdate(abSanad.SanadDate) AS SanadNo " &
                   "  From abSanad " &
                   "  Where abSanad.SanadStatus = 8 " &
                   " AND ( abSanad.SanadDate between  (select fdate from dbo.abFnt_HesabdariDateInfo( " &
                   CStr(gVahedeTejariSN) & " , " & vEslahSanadDate & " ) ) " &
                   "	and (select tdate from dbo.abFnt_HesabdariDateInfo( " &
                   CStr(gVahedeTejariSN) & " , " & vEslahSanadDate & " ) )) " &
                   " AND abSanad.TafsiliSN IS NOT NULL " &
                   " AND abSanad.TarakoneshSN Not IN ( 45 , 95 )  " &
                   " AND abSanad.VahedeTejariSN =  " + CStr(gVahedeTejariSN) &
                   " AND abSanad.AnbarSN =  " + CStr(gAnbarSN) &
                   " AND abSanad.NoeAnbarSN =  " + CStr(gNoeAnbarSN) &
                   " AND abSanad.SanadSN NOT IN ( SELECT  abEslahSanad.SanadSN From abEslahSanad  )  " &
                   " AND abSanad.SanadDate Between " & gHesabdariSalFDate & " AND " & gHesabdariSalTDate &
                   " AND (NoeSanadID <> 2 OR (NoeSanadID = 2 AND TarakoneshSN = 91 ) OR (NoeSanadID = 2 AND TarakoneshSN = 41))" &
                   " AND (abSanad.TarakoneshSN IN (1,2,11,24))"
            If Trim(vEslahSanadDate) = "" Then
                vSql = vSql & " AND 1 = 2  "
            End If
            .LateBinding = True
            ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
            .Bind(cn, vSql, "SanadSN", "SanadNo")
        End With
    End Sub

    Private Sub dbcNewTafsiliSN1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcNewTafsiliSN1.Enter
        ' با توجه به تراکنش سند و ارتباط تراکنش انبار با گروه هاي تفصيلي اطلاعات کامبو تفصيلي نمايش داده ميشود 
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal
        Dim vGoroohTafsiliSN2 As Decimal


        If Val(DVabEslahSanad.Fields("SanadNo").Value) <> 0 Then
            vTarakoneshSN = dbcSanadNo.CurrentDataRow.Item("TarakoneshSN")
            vGoroohTafsiliSN2 = Val(DVabEslahSanad.Fields("NewTafsiliSN1").Value)
            vNoeAnbarSN = gNoeAnbarSN

            DVabEslahSanad.Fields("NewTafsiliSN1").ComboWhereCondition = " maTafsili.GoroohTafsiliSN IN " &
                                                                          "(select GoroohTafsiliSN FROM dbo.abFnt_SelectLevel2GoroohTafsili( " &
                                                                          CStr(vTarakoneshSN) & "," &
                                                                          CStr(vNoeAnbarSN) & "," &
                                                                          CStr(vGoroohTafsiliSN2) & " )) "
        Else
            DVabEslahSanad.Fields("NewTafsiliSN1").ComboWhereCondition = " 1 = 2 "
        End If

        DVabEslahSanad.Fields("NewTafsiliSN1").RefreshCombo()
    End Sub

    Private Sub dbcSanadNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dbcSanadNo.SelectedValueChanged
        Dim vTarakoneshSN As Decimal
        Dim vSanaddate As String

        If dbcSanadNo.CurrentDataRow Is Nothing Then Exit Sub
        vTarakoneshSN = dbcSanadNo.CurrentDataRow.Item("TarakoneshSN")
        vSanaddate = CStr(dbcSanadNo.CurrentDataRow.Item("Sanaddate"))
        txtNewSanadDate.Text = vSanaddate
        Select Case vTarakoneshSN
            Case EnumTarakoneshSN.RESIDE_10_DARYAFTE_MAVADE_NIMSAKHTE_AS_PAYEKAR _
                , EnumTarakoneshSN.RESIDE_21_DARYAFTE_MAHSOOL_AZ_KARGAH_ARD _
                , EnumTarakoneshSN.RESIDE_23_DARYAFTE_MAVAD_AZ_KARGAHCHAP _
                , EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR _
                , EnumTarakoneshSN.RESIDE_17_BARGASHTE_BASTEBANDI_AZ_PAYEKAR _
                , EnumTarakoneshSN.RESIDE_42_DARYAFTE_ZAYEAT_AVALIE_AZ_KARGAH _
                , EnumTarakoneshSN.RESIDE_32_DARYAFTE_ZAYEAT_BASTEBANDI_AZ_KARGAH _
                , EnumTarakoneshSN.HAVALEH_109_HAVALEH_FOROOSH_AZ_PAYEKAR _
                , EnumTarakoneshSN.HAVALEH_105_HAVALEH_ERSALEMAHSOOL_AZ_PAYEKAR _
                , EnumTarakoneshSN.HAVALEH_89_ENTEGHAL_AVALIEH_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_56_ENTEGHAL_BASTEBANDI_AZ_ANBAR_BE_KARGAH _
                , EnumTarakoneshSN.HAVALEH_73_BARGASHTE_MAHSOOL_AZ_PAYEKAR_ARD

                dbcNewTafsiliSN1.Enabled = True
            Case Else
                dbcNewTafsiliSN1.Enabled = False
        End Select


        dbcNewTafsiliSN.SelectedIndex = -1
        dbcNewTafsiliSN1.SelectedIndex = -1
    End Sub

End Class
