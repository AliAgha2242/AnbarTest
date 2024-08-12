' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/02/20
'ModifiedDate::
'Description::  ثبت و بروزآوري كالاهاي انبار
'System ::انبار

Option Strict Off
Option Explicit On


'Imports C1.Win.C1FlexGrid.Classic
' 
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports Minoo.MiddleWare.Common.XmlUtil
Imports Minoo.Configuration

Friend Class frmKalaAnbar
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

    Public WithEvents btnDarjKala_frmaKalaAnbar As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dbcTKala As NetSql.Components.DataCombo
    Public WithEvents opnAzmayeshStatusYes As System.Windows.Forms.RadioButton
    Public WithEvents opnAzmayeshStatusNo As System.Windows.Forms.RadioButton
    Public WithEvents pnlGridDet As System.Windows.Forms.Panel
    Public WithEvents dbcFKala As NetSql.Components.DataCombo
    Public WithEvents pnlNavigationDet As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlFilterKala As System.Windows.Forms.Panel
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents frmQCOK As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents btnSabtPacket As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKalaAnbar))
        Me.btnDarjKala_frmaKalaAnbar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dbcTKala = New NetSql.Components.DataCombo(Me.components)
        Me.opnAzmayeshStatusYes = New System.Windows.Forms.RadioButton()
        Me.opnAzmayeshStatusNo = New System.Windows.Forms.RadioButton()
        Me.pnlGridDet = New System.Windows.Forms.Panel()
        Me.dbcFKala = New NetSql.Components.DataCombo(Me.components)
        Me.pnlNavigationDet = New System.Windows.Forms.Panel()
        Me.pnlCommandDet = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSabtPacket = New System.Windows.Forms.Button()
        Me.pnlFilterKala = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.frmQCOK = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.pnlFilterKala.SuspendLayout()
        Me.frmQCOK.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDarjKala_frmaKalaAnbar
        '
        Me.btnDarjKala_frmaKalaAnbar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjKala_frmaKalaAnbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjKala_frmaKalaAnbar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnDarjKala_frmaKalaAnbar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjKala_frmaKalaAnbar.Location = New System.Drawing.Point(5, 9)
        Me.btnDarjKala_frmaKalaAnbar.Name = "btnDarjKala_frmaKalaAnbar"
        Me.btnDarjKala_frmaKalaAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjKala_frmaKalaAnbar.Size = New System.Drawing.Size(77, 33)
        Me.btnDarjKala_frmaKalaAnbar.TabIndex = 18
        Me.btnDarjKala_frmaKalaAnbar.Text = "درج كالا "
        Me.btnDarjKala_frmaKalaAnbar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(798, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "كالا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dbcTKala
        '
        Me.dbcTKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTKala.AutoSelectFirst = False
        Me.dbcTKala.BackColor = System.Drawing.Color.White
        Me.dbcTKala.BoundText = Nothing
        Me.dbcTKala.BypassChangeEvent = False
        Me.dbcTKala.DisplayText = ""
        Me.dbcTKala.LateBindingTop = "100"
        Me.dbcTKala.Location = New System.Drawing.Point(83, 27)
        Me.dbcTKala.MemFilter = ""
        Me.dbcTKala.Name = "dbcTKala"
        Me.dbcTKala.SeparatedData = Nothing
        Me.dbcTKala.Size = New System.Drawing.Size(320, 21)
        Me.dbcTKala.Source = Nothing
        Me.dbcTKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTKala.TabIndex = 17
        '
        'opnAzmayeshStatusYes
        '
        Me.opnAzmayeshStatusYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.opnAzmayeshStatusYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opnAzmayeshStatusYes.Cursor = System.Windows.Forms.Cursors.Default
        Me.opnAzmayeshStatusYes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnAzmayeshStatusYes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opnAzmayeshStatusYes.Location = New System.Drawing.Point(48, 14)
        Me.opnAzmayeshStatusYes.Name = "opnAzmayeshStatusYes"
        Me.opnAzmayeshStatusYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opnAzmayeshStatusYes.Size = New System.Drawing.Size(47, 19)
        Me.opnAzmayeshStatusYes.TabIndex = 16
        Me.opnAzmayeshStatusYes.TabStop = True
        Me.opnAzmayeshStatusYes.Text = "بله"
        Me.opnAzmayeshStatusYes.UseVisualStyleBackColor = False
        '
        'opnAzmayeshStatusNo
        '
        Me.opnAzmayeshStatusNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.opnAzmayeshStatusNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opnAzmayeshStatusNo.Checked = True
        Me.opnAzmayeshStatusNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.opnAzmayeshStatusNo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opnAzmayeshStatusNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opnAzmayeshStatusNo.Location = New System.Drawing.Point(4, 14)
        Me.opnAzmayeshStatusNo.Name = "opnAzmayeshStatusNo"
        Me.opnAzmayeshStatusNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opnAzmayeshStatusNo.Size = New System.Drawing.Size(41, 19)
        Me.opnAzmayeshStatusNo.TabIndex = 15
        Me.opnAzmayeshStatusNo.TabStop = True
        Me.opnAzmayeshStatusNo.Text = "خير"
        Me.opnAzmayeshStatusNo.UseVisualStyleBackColor = False
        '
        'pnlGridDet
        '
        Me.pnlGridDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlGridDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet.Location = New System.Drawing.Point(3, 3)
        Me.pnlGridDet.Name = "pnlGridDet"
        Me.pnlGridDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet.Size = New System.Drawing.Size(789, 233)
        Me.pnlGridDet.TabIndex = 10
        '
        'dbcFKala
        '
        Me.dbcFKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcFKala.AutoSelectFirst = False
        Me.dbcFKala.BackColor = System.Drawing.Color.White
        Me.dbcFKala.BoundText = Nothing
        Me.dbcFKala.BypassChangeEvent = False
        Me.dbcFKala.DisplayText = ""
        Me.dbcFKala.LateBindingTop = "100"
        Me.dbcFKala.Location = New System.Drawing.Point(83, 3)
        Me.dbcFKala.MemFilter = ""
        Me.dbcFKala.Name = "dbcFKala"
        Me.dbcFKala.SeparatedData = Nothing
        Me.dbcFKala.Size = New System.Drawing.Size(320, 21)
        Me.dbcFKala.Source = Nothing
        Me.dbcFKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcFKala.TabIndex = 16
        '
        'pnlNavigationDet
        '
        Me.pnlNavigationDet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet.Location = New System.Drawing.Point(3, 240)
        Me.pnlNavigationDet.Name = "pnlNavigationDet"
        Me.pnlNavigationDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet.Size = New System.Drawing.Size(366, 33)
        Me.pnlNavigationDet.TabIndex = 9
        '
        'pnlCommandDet
        '
        Me.pnlCommandDet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet.Location = New System.Drawing.Point(372, 240)
        Me.pnlCommandDet.Name = "pnlCommandDet"
        Me.pnlCommandDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet.Size = New System.Drawing.Size(420, 33)
        Me.pnlCommandDet.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSabtPacket)
        Me.Panel2.Controls.Add(Me.pnlFilterKala)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 58)
        Me.Panel2.TabIndex = 2
        '
        'btnSabtPacket
        '
        Me.btnSabtPacket.BackColor = System.Drawing.SystemColors.Control
        Me.btnSabtPacket.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSabtPacket.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSabtPacket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSabtPacket.Location = New System.Drawing.Point(36, 11)
        Me.btnSabtPacket.Name = "btnSabtPacket"
        Me.btnSabtPacket.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSabtPacket.Size = New System.Drawing.Size(172, 33)
        Me.btnSabtPacket.TabIndex = 19
        Me.btnSabtPacket.Text = "ثبت بسته های ارسالی"
        Me.btnSabtPacket.UseVisualStyleBackColor = False
        Me.btnSabtPacket.Visible = False
        '
        'pnlFilterKala
        '
        Me.pnlFilterKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFilterKala.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlFilterKala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilterKala.Controls.Add(Me.btnDarjKala_frmaKalaAnbar)
        Me.pnlFilterKala.Controls.Add(Me.dbcFKala)
        Me.pnlFilterKala.Controls.Add(Me.dbcTKala)
        Me.pnlFilterKala.Controls.Add(Me.Label8)
        Me.pnlFilterKala.Controls.Add(Me.Label7)
        Me.pnlFilterKala.Controls.Add(Me.frmQCOK)
        Me.pnlFilterKala.Location = New System.Drawing.Point(229, 0)
        Me.pnlFilterKala.Name = "pnlFilterKala"
        Me.pnlFilterKala.Size = New System.Drawing.Size(558, 54)
        Me.pnlFilterKala.TabIndex = 18
        Me.pnlFilterKala.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(407, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(35, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "تا كالا"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(407, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "از كالا"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmQCOK
        '
        Me.frmQCOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmQCOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.frmQCOK.Controls.Add(Me.opnAzmayeshStatusYes)
        Me.frmQCOK.Controls.Add(Me.opnAzmayeshStatusNo)
        Me.frmQCOK.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmQCOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmQCOK.Location = New System.Drawing.Point(448, 3)
        Me.frmQCOK.Name = "frmQCOK"
        Me.frmQCOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.frmQCOK.Size = New System.Drawing.Size(98, 49)
        Me.frmQCOK.TabIndex = 15
        Me.frmQCOK.TabStop = False
        Me.frmQCOK.Text = "كنترل كيفيت"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlGridDet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlNavigationDet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCommandDet)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(826, 549)
        Me.SplitContainer1.SplitterDistance = 269
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pnlCommandMaster)
        Me.Panel1.Controls.Add(Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add(Me.pnlGridMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 211)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(795, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "انبار"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(396, 169)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(391, 33)
        Me.pnlCommandMaster.TabIndex = 12
        Me.pnlCommandMaster.Tag = ""
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(3, 169)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(390, 33)
        Me.pnlNavigationMaster.TabIndex = 11
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(3, 0)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(784, 167)
        Me.pnlGridMaster.TabIndex = 10
        '
        'frmKalaAnbar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(826, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "frmKalaAnbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "كالاهاي انبار"
        Me.Panel2.ResumeLayout(False)
        Me.pnlFilterKala.ResumeLayout(False)
        Me.pnlFilterKala.PerformLayout()
        Me.frmQCOK.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmKalaAnbar
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmKalaAnbar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmKalaAnbar
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmKalaAnbar)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Private WithEvents DVabVw_AnbarNoeAnbar As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي هر انبار تعريف شده است
    Private WithEvents DVabAnbarKala As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcKalaSN As NetSql.Components.DataCombo

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFLX_aAnbaraNoeAnbar As AxVSFlexGrid

    Private WithEvents dcbKalaPhizikiStatus As NetSql.Components.DataCombo

    ' شماره رکورد فعال در گريد انبارها براي کنترل رويدادهاي آن
    Private pRowNomber As Short

    Private Sub btnDarjKala_frmaKalaAnbar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        ' با توجه به فيلتر انتخاب شده کالاها در انبار مورد نظر ثبت ميگردد
        Dim vErrMsg As String
        If dbcFKala.MatchedWithList = False Or dbcTKala.MatchedWithList = False Then
            vErrMsg = "كد كالا را مشخص نماييد"
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim vHiddenAnbarSN, vHiddenNoeAnbarSN As Decimal
        Dim VAzmayeshStatus As Short
        If opnAzmayeshStatusYes.Checked = True Then
            VAzmayeshStatus = 1
        Else
            VAzmayeshStatus = 2
        End If

        With DVabVw_AnbarNoeAnbar.FlexGrid
            vHiddenAnbarSN = CDec(.TextMatrix(.Row, .ColIndex("AnbarSN")))
            vHiddenNoeAnbarSN = CDec(.TextMatrix(.Row, .ColIndex("NoeAnbarSN")))
        End With
        Dim vFKala, vTKala As String
        vFKala = dbcFKala.BoundText
        vTKala = dbcTKala.BoundText
        If vFKala Is Nothing Or vTKala Is Nothing Then
            vErrMsg = "از كد كالا و تا کد کالا را مشخص نماييد"
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ' Yes
        ' فراخواني اس پي براي درج کالاهاي انتخاب شده در کالاهاي هر انبار
        cn.CallSP("_abSp_Darj_abAnbarKala", gSM.Identifier, gVahedeTejariSN, vHiddenAnbarSN, vHiddenNoeAnbarSN _
                   , vFKala, vTKala, 1, VAzmayeshStatus, gSM.UserID_Name)

        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If

        DVabAnbarKala.Refresh()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dbcFKala_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Trim(dbcFKala.BoundText) <> "" Then
            dbcTKala.BoundText = dbcFKala.BoundText
        End If
    End Sub

    Private Sub DVabAnbarKala_AfterCommandClick(ByVal aCommand As EnumCommands) Handles DVabAnbarKala.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                With DVabVw_AnbarNoeAnbar.FlexGrid
                    ' مقداردهي کليد اصلي انبار و نوع انبار با مقادير گريد انبارها 
                    DVabAnbarKala.Fields("AnbarSN").Value = .TextMatrix(.Row, .ColIndex("AnbarSN"))
                    DVabAnbarKala.Fields("NoeAnbarSN").Value = .TextMatrix(.Row, .ColIndex("NoeAnbarSN"))
                End With
            Case EnumCommands.cmEdit
        End Select
    End Sub

    Private Sub DVabAnbarKala_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabAnbarKala.CommandClick
        Select Case aCommand
            Case EnumCommands.cmSave
                If _
                    Val(DVabAnbarKala.FieldValue("KalaPhizikiStatusSN")) = 1 And _
                    DVabAnbarKala.FieldValue("Meghdar") = "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("مقدار پيش فرض کد رهگيري مشخص نشده است", _
                               MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If _
                    Val(DVabAnbarKala.FieldValue("KalaPhizikiStatusSN")) = 1 And _
                    Val(DVabAnbarKala.FieldValue("Auto")) = 2 Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("در حالت کد رهگيري ثابت اتوماتيک بايد حتما انتخاب شود", _
                               MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

                If _
                    Val(DVabAnbarKala.FieldValue("KalaPhizikiStatusSN")) = 2 And _
                    DVabAnbarKala.FieldValue("Meghdar") <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox("در حالت کد رهگيري متغير نبايد مقدار پيش فرض کد رهگيري وارد شود", _
                               MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                    Exit Sub
                End If

            Case EnumCommands.cmEdit, EnumCommands.cmAdd
                With DVabVw_AnbarNoeAnbar.FlexGrid
                    ' تهيه شرط براي کامبو کالا
                    DVabAnbarKala.Fields("KalaSN").ComboWhereCondition = "  ISNULL(paKala.KalaStatus,0)  <> 0  " & _
                                                                          " AND KalaSN NOT IN (SELECT KalaSN From abAnbarKala " & _
                                                                          " Where AnbarSN = " & _
                                                                          .TextMatrix(.Row, .ColIndex("AnbarSN")) & _
                                                                          " AND abAnbarKala.NoeAnbarSN =  " & _
                                                                          .TextMatrix(.Row, .ColIndex("NoeAnbarSN")) & _
                                                                          " ) "
                End With
                DVabAnbarKala.Fields("KalaSN").RefreshCombo()
        End Select

    End Sub

    Private Sub pFLX_aAnbaraNoeAnbar_RowColChange(ByVal eventSender As System.Object, _
                                                   ByVal eventArgs As System.EventArgs) _
        Handles pFLX_aAnbaraNoeAnbar.RowColChange

        Dim Sql_where As String

        If DVabVw_AnbarNoeAnbar.FlexGrid.Rows < 2 Then Exit Sub
        If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabVw_AnbarNoeAnbar.FlexGrid
                pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                If DVabVw_AnbarNoeAnbar.FlexGrid.Rows > 1 Then
                    Sql_where = " abAnbarKala.AnbarSN = " & .TextMatrix(.Row, .ColIndex("AnbarSN")) & _
                                " AND abAnbarKala.NoeAnbarSN =  " & .TextMatrix(.Row, .ColIndex("NoeAnbarSN"))
                Else
                    Sql_where = " 1 = 2 "
                End If

            End With
            DVabAnbarKala.SQLWhere = Sql_where
            DVabAnbarKala.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Sub frmKalaAnbar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim ls_Select As String

        Call InitDataView()
        dbcFKala.LateBinding = True
        ls_Select = " SELECT TOP 100 PERCENT KalaSN, CONVERT(BIGINT,KalaNO) AS KalaNO " & _
                    " ,  KalaNo + ' - ' + KalaDS AS KalaDS " & _
                    " From paKala " & _
                    " Where ISNULL(KalaStatus,0)  <> 0  AND ( isnumeric(paKala.kalano) = 1  ) " & _
                    " ORDER BY  paKala.KalaNo "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dbcFKala.Bind(cn, ls_Select, "KalaNo", "KalaDS")

        dbcTKala.LateBinding = True
        ls_Select = " SELECT TOP 100 PERCENT KalaSN, CONVERT(BIGINT,KalaNO) AS KalaNO " & _
                    " , Convert(varchar, KalaNo) + ' - ' + KalaDS AS KalaDS " & _
                    " From paKala  " & _
                    " Where ISNULL(KalaStatus,0)  <> 0  AND ( isnumeric(paKala.kalano) = 1  )  " & _
                    " ORDER BY  paKala.KalaNo "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dbcTKala.Bind(cn, ls_Select, "KalaNo", "KalaDS")
        ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
        btnDarjKala_frmaKalaAnbar.Enabled = (gSM.TableAccessRight("abAnbarKala") = 15)

    End Sub

    Private Sub frmKalaAnbar_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabVw_AnbarNoeAnbar.Done()
        DVabVw_AnbarNoeAnbar = Nothing
        DVabAnbarKala.Done()
        DVabAnbarKala = Nothing
    End Sub

    Private Sub InitDataView()
        'Dim CAppSet As CAppSetting = New CAppSetting(gVahedeTejariSN, 3)
        'Dim IsTolidi As Boolean = IIf(CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi"))
        Dim IsTolidi As Boolean = IsVahedTejariTolidi
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vSql_where As String

        DVabVw_AnbarNoeAnbar = New CDataView(cn)
        With DVabVw_AnbarNoeAnbar
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdPrint _
                                                                           Or EnumButtonOptions.boCmdFilter Or
                                                                           EnumButtonOptions.boCmdFind _
                                                                           Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abVw_AnbarNoeAnbar"
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            With .Fields
                .Add("VahedeTejariDS", , EnumFieldOptions.foHidden)
                .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                .Add("AnbarSN", , EnumFieldOptions.foHidden)
                .Add("AnbarNO", , EnumFieldOptions.foDefault)
                .Add("AnbarDS", , EnumFieldOptions.foDefault)
                .Add("NoeAnbarSN", , EnumFieldOptions.foHidden)
                .Add("NoeAnbarDS", , EnumFieldOptions.foDefault)
                .Add("NoeVoroodeAsnadSN", , EnumFieldOptions.foHidden)
            End With

            .SQLWhere = " VahedeTejariSN =  " & CStr(gVahedeTejariSN) &
                        IIf(gIsTajmie = 1, "", " AND AnbarSN = " & CStr(gAnbarSN))
            .FlexGrid.Font = VB6.FontChangeName(.FlexGrid.Font, "Tahoma")
            .FlexGrid.Font = VB6.FontChangeSize(.FlexGrid.Font, 9)
            .Refresh()
        End With
        pFLX_aAnbaraNoeAnbar = DVabVw_AnbarNoeAnbar.FlexGrid

        With DVabVw_AnbarNoeAnbar.FlexGrid
            If .Rows > 1 Then
                pRowNomber = 1
                vSql_where = " abAnbarKala.AnbarSN = " & .TextMatrix(.Row, .ColIndex("AnbarSN")) &
                             " AND abAnbarKala.NoeAnbarSN =  " & .TextMatrix(.Row, .ColIndex("NoeAnbarSN"))
            Else
                vSql_where = " 1 = 2 "
            End If
        End With

        DVabAnbarKala = New CDataView(cn)
        With DVabAnbarKala
            .Init(pnlGridDet, , pnlCommandDet, pnlNavigationDet, EnumButtonOptions.boCmdModify _
                                                                  Or EnumButtonOptions.boCmdExit Or
                                                                  EnumButtonOptions.boCmdPrint _
                                                                  Or EnumButtonOptions.boCmdFilter)
            .TableName = "abAnbarKala"
            'Ashari 841126
            .AddJoin("abAnbarKala", EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")
            'Ashari 841126

            .Text = Me.Text
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatus", "AnbarKalaStatus", "GeneralStatusSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatusYN", "AzmayeshStatus", "GeneralStatusYNSN")
            .AddJoin("paKala", EnumTableJoin.tjLeftJoin, "paGeneralStatus", "KalaStatus", "GeneralStatusSN")
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            .SQLWhere = vSql_where
            .SQLOrderBy = "paKala.KalaNo"
            With .Fields
                With .Add("AnbarKalaSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add("NoeAnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                With .Add("KalaSN->paKala.KalaNO AS KalaNO")
                    .Caption = cn.FieldCaption("paKala.KalaNO")
                End With
                With .Add("KalaSN->{paKala.KalaNO + ' _ ' + paKala.KalaDS} AS KalaSN", "DataCombo")
                    dbcKalaSN = .Component
                    dbcKalaSN.LateBinding = True
                    .Caption = cn.FieldCaption("paKala.KalaDS")
                End With

                'Ashari 850726
                With _
                    .Add("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDS AS VahedeSanjeshDS", "TextBox <Disabled>",
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.VahedeSanjeshDS")
                End With
                'Ashari 850726

                'Ashari 841126
                With _
                    .Add("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza", "TextBox <Disabled>",
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("paVw_VahedeSanjesh.TedadAjza")
                End With
                'Ashari 841126

                With .Add("pakala.KalaStatus->paGeneralStatus.GeneralStatusDs AS KalaStatus", "DataCombo DISABLED")
                    .ReadOnly = True
                    .Caption = cn.FieldCaption("paKala.KalaStatus")
                End With

                With .Add("AnbarKalaStatus->paGeneralStatus.GeneralStatusDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abAnbarKala.AnbarKalaStatus")
                    .DefaultValue = 1
                End With
                With _
                    .Add("AzmayeshStatus->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abAnbarKala.AzmayeshStatus")
                    .DefaultValue = 2
                End With
                With _
                    .Add("KalaPhizikiStatusSN->abKalaPhizikiStatus.KalaPhizikiStatusDs", "DataCombo",
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abKalaPhizikiStatus.KalaPhizikiStatusDs")
                    dcbKalaPhizikiStatus = .Component
                End With
                With .Add("Auto->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abAnbarKala.Auto")
                End With
                With .Add("Meghdar", "TextBox")
                    .Caption = cn.FieldCaption("abAnbarKala.Meghdar") & IIf(IsTolidi, "", "(آخرین نرخ)")
                End With
                With .Add("RezDA", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarKala.RezDA")
                End With

                With .Add("ToolidDate->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abKalaPhiziki.ToolidDate")
                    .DefaultValue = 2
                End With
                With .Add("EnghezaDate->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abKalaPhiziki.EnghezaDate")
                    .DefaultValue = 2
                End With

                .Add("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
    End Sub

    Private Sub DVabVw_AnbarNoeAnbar_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabVw_AnbarNoeAnbar.FillDetailsWithData
        Dim Sql_where As String
        If aFetched Then
            If DVabVw_AnbarNoeAnbar.FlexGrid.Rows < 2 Then Exit Sub
            If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVabVw_AnbarNoeAnbar.FlexGrid
                    pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                    If DVabVw_AnbarNoeAnbar.FlexGrid.Rows > 1 Then
                        Sql_where = " abAnbarKala.AnbarSN = " & .TextMatrix(.Row, .ColIndex("AnbarSN")) & _
                                    " AND abAnbarKala.NoeAnbarSN =  " & .TextMatrix(.Row, .ColIndex("NoeAnbarSN"))
                    Else
                        Sql_where = " 1 = 2 "
                    End If
                End With
                DVabAnbarKala.SQLWhere = Sql_where
                DVabAnbarKala.Refresh()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        End If
    End Sub


    Private Sub dcbKalaPhizikiStatus_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dcbKalaPhizikiStatus.Validated
        With DVabAnbarKala
            If Val(.FieldValue("KalaPhizikiStatusSN")) = 1 Then
                .FieldValue("Auto") = 1
                .Fields("Auto").LockInsert = True
                .Fields("Auto").LockUpdate = True
                .Fields("Meghdar").LockInsert = False
                .Fields("Meghdar").LockUpdate = False

            End If

            If Val(.FieldValue("KalaPhizikiStatusSN")) = 2 Then
                .FieldValue("Auto") = 2
                .FieldValue("Meghdar") = ""
                .Fields("Auto").LockInsert = False  'True   Change Yekta 910820
                .Fields("Auto").LockUpdate = False  'True   Change Yekta 910820
                .Fields("Meghdar").LockInsert = True
                .Fields("Meghdar").LockUpdate = True
            End If
        End With
    End Sub

    'Private Sub btnSabtPacket_Click(sender As System.Object, e As System.EventArgs) _
    '    Handles btnSabtPacket.Click
    '    Dim ServerName As String = cn.SQLServerName
    '    Dim DBName As String = cn.SQLDatabaseName
    '    If cn.OpenConnection() Then
    '        Dim DVServer As DataView = cn.ExecuteQuery("SELECT * FROM mwServer WHERE ServerDS = '" + ServerName + "' AND DBName = '" + DBName + "' AND Priority=0")
    '        If DVServer Is Nothing OrElse DVServer.Count <= 0 Then
    '            Throw New Exception("سروري جهت دريافت اطلاعات يافت نشد : " + ServerName)
    '        End If
    '        'بانکهای مختلف روی یک سرور :
    '        For i As Integer = 0 To DVServer.Count - 1
    '            Dim mcn As NetSql.DB.CConnection = _
    '            New NetSql.DB.CConnection(tp, DVServer.Item(i).Item("ServerDS").ToString(), _
    '                                       DVServer.Item(i).Item("DBName").ToString(), _
    '                                      tp.DecodeStr(DVServer.Item(i).Item("DBUser").ToString()), _
    '                                     tp.DecodeStr(DVServer.Item(i).Item("DBPass").ToString()))

    '            With mcn
    '                .ConnectionTimeout = CType(DVServer.Item(i).Item("ConnectionTimeout"), Integer)
    '                .CommandTimeout = CType(DVServer.Item(i).Item("CommandTimeout"), Integer)
    '                .AutoHandleError = False '2010-aug-29, Nazarpour
    '                If .OpenConnection() = False Then
    '                    Throw New Exception("خطا در اتصال به بانک اطلاعاتي")
    '                End If
    '            End With
    '            ApplyReceivedPacket(mcn)
    '            SendPacketToReceiver(mcn)
    '            mcn.CloseConnection()
    '            mcn = Nothing
    '        Next
    '    End If
    'End Sub

    'Private Sub ApplyReceivedPacket(ByVal mcn As NetSql.DB.CConnection)

    '    Try
    '        Dim _str As String = " SELECT SendingReceivingSN, sr.PacketTypeSN, Packet, SendingReceivingStateSN,SendingReceivingTypeSN, SenderVahedeTejariSN, " + _
    '        " ReceiverVahedeTejariSN, RefNo, LastServerIndex   FROM   mwSendingReceiving sr  INNER JOIN mwPacketType pt  ON  sr.PacketTypeSN = pt.PacketTypeSN " + _
    '        " WHERE (sr.PacketTypeSN <>3)  AND (SendingReceivingStateSN = 1 ) AND (SendingReceivingTypeSN = 4 ) AND RetryCount < 254   ORDER BY Priority,RetryCount, sr.SendingReceivingSN "

    '        Dim DV As DataView = _
    'mcn.ExecuteQuery(_str)
    '        For i As Integer = 0 To DV.Count - 1
    '            Dim SendingReceivingSN As Double

    '            Try

    '                If mcn.Connection.State = ConnectionState.Closed Then
    '                    mcn.OpenConnection()
    '                End If
    '                mcn.BeginTrans(mcn.Connection.BeginTransaction)

    '                SendingReceivingSN = DV.Table.Rows(i).Item("SendingReceivingSN")
    '                Dim _PacketTypeID As Integer = DV.Table.Rows(i).Item("PacketTypeSN")
    '                Dim _Sender As Double = DV.Table.Rows(i).Item("SenderVahedeTejariSN")
    '                Dim _Receiver As Double = DV.Table.Rows(i).Item("ReceiverVahedeTejariSN")
    '                Dim _Packet As String = DV.Table.Rows(i).Item("Packet")

    '                Dim DVPacketType As DataView = _
    '                    mcn.ExecuteQuery("Select Sp_Name From mwPacketType WHERE PacketTypeSN = " + _PacketTypeID.ToString())
    '                If DVPacketType Is Nothing Then
    '                    Throw New Exception("خطا در خواندن اطلاعات نوع بسته")
    '                End If

    '                Dim XmlForm As Object = SoapTo(_Packet)
    '                If TypeOf XmlForm Is DataSet Then
    '                    _Packet = CType(XmlForm, DataSet).GetXml()
    '                Else
    '                    _Packet = XmlForm
    '                End If
    '                '.code optimized.

    '                Dim ErrMsg As String = ""
    '                If DVPacketType.Count > 0 Then
    '                    Dim sp As String = DVPacketType.Table.Rows(0).Item("SP_Name").ToString()
    '                    If (sp <> Nothing AndAlso sp.Length > 0) Then
    '                        mcn.CallSP(sp, _Sender, _Receiver, _Packet, ErrMsg)
    '                        If ErrMsg <> "0" Then
    '                            Throw New Exception("خطا در اجراي بسته: " + ErrMsg)
    '                        End If
    '                    End If
    '                End If
    '                '--------------------------------تغيير حالت بسته وروردي با جرا شده--------------------------------
    '                ErrMsg = "UnProcess"
    '                mcn.CallSP("_mwSPC_ChangeSendingReceivingStatus", 8, SendingReceivingSN, _
    '                            ErrMsg)
    '                If ErrMsg <> "0" Then
    '                    Throw New Exception("خطا در اجراي بسته: " + ErrMsg)
    '                End If
    '                '------------------------------------------------------------------------------------------------

    '                mcn.CommitTrans()
    '                mcn.CloseConnection()
    '            Catch ex As Exception
    '                mcn.RollbackTrans()
    '                tp.LogStr(ex.Message)
    '                SaveErrorInDB(mcn, SendingReceivingSN, ex.Message)
    '            End Try

    '        Next

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub SendPacketToReceiver(ByVal mcn As NetSql.DB.CConnection)
    '    'فهرست ارسال نشده ها
    '    Dim _str As String = " SELECT SendingReceivingSN, sr.PacketTypeSN, Packet, SendingReceivingStateSN,SendingReceivingTypeSN, SenderVahedeTejariSN, " + _
    '    " ReceiverVahedeTejariSN, RefNo, LastServerIndex   FROM   mwSendingReceiving sr  INNER JOIN mwPacketType pt  ON  sr.PacketTypeSN = pt.PacketTypeSN " + _
    '    " WHERE (sr.PacketTypeSN <>3)  AND (SendingReceivingStateSN = 1 ) AND (SendingReceivingTypeSN = 1 ) AND RetryCount < 254 " + _
    '    " ORDER BY Priority,RetryCount, sr.SendingReceivingSN "


    '    Dim DV As DataView = mcn.ExecuteQuery(_str)
    '    ' = mcn.CallSP( "_mwSPG_SendingReceivingSelect", DBNull.Value, DBNull.Value, 1, 1, DBNull.Value, DBNull.Value, DBNull.Value)
    '    For i As Integer = 0 To DV.Count - 1
    '        Dim SendingReceivingSN As Double
    '        Try
    '            Dim LastServerIndex As Integer = DV.Item(i).Item("LastServerIndex")
    '            SendingReceivingSN = DV.Item(i).Item("SendingReceivingSN")
    '            Dim PacketTypeID As Integer = DV.Item(i).Item("PacketTypeSN")
    '            Dim Sender As Double = CDbl(DV.Item(i).Item("SenderVahedeTejariSN"))
    '            Dim Receiver As Double = DV.Item(i).Item("ReceiverVahedeTejariSN")
    '            Dim Packet As String = DV.Item(i).Item("Packet")

    '            Dim DVServer As DataView = mcn.ExecuteQuery("_mwSPG_GetServer " + Receiver.ToString())
    '            If DVServer Is Nothing OrElse DVServer.Count <= 0 Then
    '                Throw New Exception("سرور مقصد يافت نشد : " + Receiver.ToString())
    '            ElseIf LastServerIndex >= DVServer.Count Then
    '                mcn.ExecuteQuery("UPDATE mwSendingReceiving SET RetryCount=255 WHERE SendingReceivingSN=" + SendingReceivingSN.ToString())
    '                Continue For
    '            End If

    '            Dim mwWebService As New MinooWebServiceCaller.WebServiceCaller.WebService
    '            Dim params(4) As Object
    '            params(0) = PacketTypeID
    '            params(1) = Packet
    '            params(2) = Sender
    '            params(3) = Receiver
    '            params(4) = SendingReceivingSN

    '            Dim WebServiceResult As Object = _
    '                    mwWebService.CallWebMetodByURL( _
    '                                                    "http://" + DVServer.Item(LastServerIndex).Item("ServerName").ToString() + _
    '                                                    "/MinooWebServices", _
    '                                                    DVServer.Item(LastServerIndex).Item("ServiceName").ToString(), _
    '                                                    "ReceivePacket", params)
    '            If WebServiceResult Is Nothing Then
    '                Throw New Exception("خطا در وب سرویس: " + mwWebService.ErrorMessage)
    '            End If
    '            If WebServiceResult = "True" Then
    '                Dim ErrMsg As String = ""
    '                mcn.CallSP("_mwSPC_ChangeSendingReceivingStatus", 4, SendingReceivingSN, _
    '                            ErrMsg)
    '                mcn.ExecuteQuery(" UPDATE mwSendingReceiving SET Userid_Name='Anbar' WHERE SendingReceivingSN =" & SendingReceivingSN)

    '                If ErrMsg <> "0" Then
    '                    Throw New Exception("خطا در تغيير وضعيت ارسال بسته : " + ErrMsg)
    '                End If
    '            Else
    '                Throw New Exception(WebServiceResult.ToString())
    '            End If
    '        Catch ex As Exception
    '            tp.LogStr(ex.Message)
    '            SaveErrorInDB(mcn, SendingReceivingSN, ex.Message)
    '        End Try
    '    Next
    'End Sub

    Private Sub SaveErrorInDB(ByVal mcn As NetSql.DB.CConnection, ByVal SendingReceivingSN As Double, ByVal ErrMsg As String)
        ErrMsg = "UPDATE mwSendingReceiving SET Description='" + ErrMsg.Replace("'", "~") + "'" + _
                ", RetryCount=RetryCount+1  WHERE SendingReceivingSN=" + SendingReceivingSN.ToString() + _
                vbCrLf + _
                "UPDATE mwSendingReceiving SET RetryCount=0, LastServerIndex=LastServerIndex+1 " + _
                "WHERE RetryCount=250 AND SendingReceivingSN=" + SendingReceivingSN.ToString()
        Try
            mcn.ExecuteQuery(ErrMsg)
        Catch ex As Exception
            'Dim _body As String = "SaveErrorInDB caused an unhandled situation:" + vbCrLf + _
            '                        "ExecuteQuery(" + vbCrLf + ErrMsg + vbCrLf + ")"
            'SendEMail("MiddleWare Error", _body)
            'ErrMsg = ""
        End Try
    End Sub

End Class
