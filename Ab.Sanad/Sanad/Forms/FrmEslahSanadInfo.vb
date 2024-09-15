' OK
'Author ::Zohreh Izadpanah 
'CreateDate ::  1387/02/28
'ModifiedDate::
'Description::  اصلاح اطلاعات سند
'
'براي اصلاح اطلاعات سند نظير شماره بارنامه-شماره ماشين-نام راننده- وزن باسکول استفاده مي شود
'System ::انبار
Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Public Class FrmEslahSanadInfo
    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents txtVazneBaskool As System.Windows.Forms.TextBox
    Public WithEvents txtNameRanandeh As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehMashin As System.Windows.Forms.TextBox
    Public WithEvents txtShomarehBarnameh As System.Windows.Forms.TextBox
    Public WithEvents lblVazneBaskool As System.Windows.Forms.Label
    Public WithEvents lblNameRanandeh As System.Windows.Forms.Label
    Public WithEvents lblShomarehMashin As System.Windows.Forms.Label
    Public WithEvents lblShomarehBarnameh As System.Windows.Forms.Label
    Public WithEvents txtShomarehSefaresh As System.Windows.Forms.TextBox
    Public WithEvents txtTozih As System.Windows.Forms.TextBox
    Public WithEvents lblTozih As System.Windows.Forms.Label
    Public WithEvents lblShomarehSefaresh As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTozih = New System.Windows.Forms.TextBox()
        Me.lblTozih = New System.Windows.Forms.Label()
        Me.txtShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.lblShomarehSefaresh = New System.Windows.Forms.Label()
        Me.txtVazneBaskool = New System.Windows.Forms.TextBox()
        Me.txtNameRanandeh = New System.Windows.Forms.TextBox()
        Me.txtShomarehMashin = New System.Windows.Forms.TextBox()
        Me.txtShomarehBarnameh = New System.Windows.Forms.TextBox()
        Me.lblVazneBaskool = New System.Windows.Forms.Label()
        Me.lblNameRanandeh = New System.Windows.Forms.Label()
        Me.lblShomarehMashin = New System.Windows.Forms.Label()
        Me.lblShomarehBarnameh = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTozih)
        Me.GroupBox1.Controls.Add(Me.lblTozih)
        Me.GroupBox1.Controls.Add(Me.txtShomarehSefaresh)
        Me.GroupBox1.Controls.Add(Me.lblShomarehSefaresh)
        Me.GroupBox1.Controls.Add(Me.txtVazneBaskool)
        Me.GroupBox1.Controls.Add(Me.txtNameRanandeh)
        Me.GroupBox1.Controls.Add(Me.txtShomarehMashin)
        Me.GroupBox1.Controls.Add(Me.txtShomarehBarnameh)
        Me.GroupBox1.Controls.Add(Me.lblVazneBaskool)
        Me.GroupBox1.Controls.Add(Me.lblNameRanandeh)
        Me.GroupBox1.Controls.Add(Me.lblShomarehMashin)
        Me.GroupBox1.Controls.Add(Me.lblShomarehBarnameh)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 137)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtTozih
        '
        Me.txtTozih.AcceptsReturn = True
        Me.txtTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTozih.BackColor = System.Drawing.SystemColors.Window
        Me.txtTozih.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTozih.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTozih.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTozih.Location = New System.Drawing.Point(6, 97)
        Me.txtTozih.MaxLength = 0
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTozih.Size = New System.Drawing.Size(670, 20)
        Me.txtTozih.TabIndex = 39
        '
        'lblTozih
        '
        Me.lblTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTozih.AutoSize = True
        Me.lblTozih.BackColor = System.Drawing.Color.Transparent
        Me.lblTozih.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTozih.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTozih.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTozih.Location = New System.Drawing.Point(682, 100)
        Me.lblTozih.Name = "lblTozih"
        Me.lblTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTozih.Size = New System.Drawing.Size(46, 13)
        Me.lblTozih.TabIndex = 38
        Me.lblTozih.Text = "توضيح : "
        Me.lblTozih.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtShomarehSefaresh
        '
        Me.txtShomarehSefaresh.AcceptsReturn = True
        Me.txtShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehSefaresh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehSefaresh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehSefaresh.Location = New System.Drawing.Point(397, 66)
        Me.txtShomarehSefaresh.MaxLength = 0
        Me.txtShomarehSefaresh.Name = "txtShomarehSefaresh"
        Me.txtShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehSefaresh.Size = New System.Drawing.Size(197, 21)
        Me.txtShomarehSefaresh.TabIndex = 36
        Me.txtShomarehSefaresh.Visible = False
        '
        'lblShomarehSefaresh
        '
        Me.lblShomarehSefaresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehSefaresh.AutoSize = True
        Me.lblShomarehSefaresh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehSefaresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehSefaresh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehSefaresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehSefaresh.Location = New System.Drawing.Point(601, 68)
        Me.lblShomarehSefaresh.Name = "lblShomarehSefaresh"
        Me.lblShomarehSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehSefaresh.Size = New System.Drawing.Size(71, 13)
        Me.lblShomarehSefaresh.TabIndex = 37
        Me.lblShomarehSefaresh.Text = "شماره ارجاع :"
        Me.lblShomarehSefaresh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblShomarehSefaresh.Visible = False
        '
        'txtVazneBaskool
        '
        Me.txtVazneBaskool.AcceptsReturn = True
        Me.txtVazneBaskool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVazneBaskool.BackColor = System.Drawing.SystemColors.Window
        Me.txtVazneBaskool.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtVazneBaskool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVazneBaskool.Location = New System.Drawing.Point(397, 42)
        Me.txtVazneBaskool.MaxLength = 0
        Me.txtVazneBaskool.Name = "txtVazneBaskool"
        Me.txtVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVazneBaskool.Size = New System.Drawing.Size(197, 21)
        Me.txtVazneBaskool.TabIndex = 2
        Me.txtVazneBaskool.Visible = False
        '
        'txtNameRanandeh
        '
        Me.txtNameRanandeh.AcceptsReturn = True
        Me.txtNameRanandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameRanandeh.BackColor = System.Drawing.SystemColors.Window
        Me.txtNameRanandeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNameRanandeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNameRanandeh.Location = New System.Drawing.Point(108, 42)
        Me.txtNameRanandeh.MaxLength = 0
        Me.txtNameRanandeh.Name = "txtNameRanandeh"
        Me.txtNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNameRanandeh.Size = New System.Drawing.Size(200, 21)
        Me.txtNameRanandeh.TabIndex = 3
        Me.txtNameRanandeh.Visible = False
        '
        'txtShomarehMashin
        '
        Me.txtShomarehMashin.AcceptsReturn = True
        Me.txtShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehMashin.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehMashin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehMashin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehMashin.Location = New System.Drawing.Point(397, 18)
        Me.txtShomarehMashin.MaxLength = 0
        Me.txtShomarehMashin.Name = "txtShomarehMashin"
        Me.txtShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehMashin.Size = New System.Drawing.Size(197, 21)
        Me.txtShomarehMashin.TabIndex = 0
        Me.txtShomarehMashin.Visible = False
        '
        'txtShomarehBarnameh
        '
        Me.txtShomarehBarnameh.AcceptsReturn = True
        Me.txtShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShomarehBarnameh.BackColor = System.Drawing.SystemColors.Window
        Me.txtShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtShomarehBarnameh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShomarehBarnameh.Location = New System.Drawing.Point(108, 18)
        Me.txtShomarehBarnameh.MaxLength = 0
        Me.txtShomarehBarnameh.Name = "txtShomarehBarnameh"
        Me.txtShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomarehBarnameh.Size = New System.Drawing.Size(200, 21)
        Me.txtShomarehBarnameh.TabIndex = 1
        Me.txtShomarehBarnameh.Visible = False
        '
        'lblVazneBaskool
        '
        Me.lblVazneBaskool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVazneBaskool.AutoSize = True
        Me.lblVazneBaskool.BackColor = System.Drawing.Color.Transparent
        Me.lblVazneBaskool.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVazneBaskool.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVazneBaskool.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVazneBaskool.Location = New System.Drawing.Point(601, 42)
        Me.lblVazneBaskool.Name = "lblVazneBaskool"
        Me.lblVazneBaskool.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVazneBaskool.Size = New System.Drawing.Size(111, 13)
        Me.lblVazneBaskool.TabIndex = 35
        Me.lblVazneBaskool.Text = "وزن باسکول فرستنده :"
        Me.lblVazneBaskool.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblVazneBaskool.Visible = False
        '
        'lblNameRanandeh
        '
        Me.lblNameRanandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNameRanandeh.AutoSize = True
        Me.lblNameRanandeh.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRanandeh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNameRanandeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRanandeh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNameRanandeh.Location = New System.Drawing.Point(312, 50)
        Me.lblNameRanandeh.Name = "lblNameRanandeh"
        Me.lblNameRanandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNameRanandeh.Size = New System.Drawing.Size(55, 13)
        Me.lblNameRanandeh.TabIndex = 33
        Me.lblNameRanandeh.Text = "نام راننده :"
        Me.lblNameRanandeh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblNameRanandeh.Visible = False
        '
        'lblShomarehMashin
        '
        Me.lblShomarehMashin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehMashin.AutoSize = True
        Me.lblShomarehMashin.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehMashin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehMashin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehMashin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehMashin.Location = New System.Drawing.Point(601, 18)
        Me.lblShomarehMashin.Name = "lblShomarehMashin"
        Me.lblShomarehMashin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehMashin.Size = New System.Drawing.Size(79, 13)
        Me.lblShomarehMashin.TabIndex = 31
        Me.lblShomarehMashin.Text = "شماره ماشين :"
        Me.lblShomarehMashin.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblShomarehMashin.Visible = False
        '
        'lblShomarehBarnameh
        '
        Me.lblShomarehBarnameh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShomarehBarnameh.AutoSize = True
        Me.lblShomarehBarnameh.BackColor = System.Drawing.Color.Transparent
        Me.lblShomarehBarnameh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShomarehBarnameh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShomarehBarnameh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShomarehBarnameh.Location = New System.Drawing.Point(312, 18)
        Me.lblShomarehBarnameh.Name = "lblShomarehBarnameh"
        Me.lblShomarehBarnameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblShomarehBarnameh.Size = New System.Drawing.Size(75, 13)
        Me.lblShomarehBarnameh.TabIndex = 29
        Me.lblShomarehBarnameh.Text = "شماره بارنامه :"
        Me.lblShomarehBarnameh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblShomarehBarnameh.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOk.Location = New System.Drawing.Point(6, 18)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(84, 66)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "تاييد"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'FrmEslahSanadInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(736, 137)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmEslahSanadInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اصلاح اطلاعات سند"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmEslahSanadInfo
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmEslahSanadInfo
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmEslahSanadInfo
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmEslahSanadInfo)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Public Variables"

    Public vSanadSN As String

    Public vVisibleShomarehBarnameh As Boolean
    Public vVisibleShomarehMashin As Boolean
    Public vVisibleNameRanandeh As Boolean
    Public vVisibleVazneBaskool As Boolean
    Public vVisibleShomrehSefaresh As Boolean

    Public vShomarehBarnameh As String
    Public vShomarehMashin As String
    Public vNameRanandeh As String
    Public vVazneBaskool As String
    Public vShomarehSefaresh As String
    Public vTozih As String
    Public BarcodeReaderSanad As Boolean


#End Region

    Private Sub FrmEslahSanadInfo_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtShomarehMashin.Visible = vVisibleShomarehMashin
        lblShomarehMashin.Visible = vVisibleShomarehMashin

        txtNameRanandeh.Visible = vVisibleNameRanandeh
        lblNameRanandeh.Visible = vVisibleNameRanandeh

        txtShomarehBarnameh.Visible = vVisibleShomarehBarnameh
        lblShomarehBarnameh.Visible = vVisibleShomarehBarnameh

        txtVazneBaskool.Visible = vVisibleVazneBaskool
        lblVazneBaskool.Visible = vVisibleVazneBaskool

        txtShomarehSefaresh.Visible = vVisibleShomrehSefaresh
        lblShomarehSefaresh.Visible = vVisibleShomrehSefaresh

        txtShomarehMashin.Text = vShomarehMashin
        txtNameRanandeh.Text = vNameRanandeh
        txtShomarehBarnameh.Text = vShomarehBarnameh
        txtVazneBaskool.Text = vVazneBaskool
        txtShomarehSefaresh.Text = vShomarehSefaresh
        txtTozih.Text = vtozih

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If BarcodeReaderSanad AndAlso Not txtTozih.Text.Contains(vTozih) Then
            NetSql.Common.CSystem.MsgBox("توضیحات سیستمی اسناد بارکدخوان قابلیت ویرایش یا حذف ندارد و فقط می توان توضیحات جدید به ابتدا یا انتهای آن اضافه نمود " + vbNewLine +
                                         "توضیحات اولیه سیستمی سند : " + vbNewLine + vTozih, MsgBoxStyle.Information)
            txtTozih.Text = vTozih
            Exit Sub
        End If
        Try
            cn.ExecuteQuery(
                         "Update abSanad Set ShomarehMashin =" &
                         IIf(txtShomarehMashin.Text.Trim = "", "NULL", "'" & txtShomarehMashin.Text & "'") &
                         ",NameRanandeh =" &
                         IIf(txtNameRanandeh.Text.Trim = "", "NULL", "'" & txtNameRanandeh.Text & "'") &
                         ",ShomarehBarnameh=" &
                         IIf(txtShomarehBarnameh.Text.Trim = "", "NULL", "'" & txtShomarehBarnameh.Text & "'") &
                         ",VazneBaskool=" & IIf(txtVazneBaskool.Text.Trim = "", "NULL", txtVazneBaskool.Text.ToString) &
                         ",ShomarehSefaresh =" &
                         IIf(txtShomarehSefaresh.Text.Trim = "", "NULL", "'" & txtShomarehSefaresh.Text & "'") &
                         ",Tozih =" & IIf(txtTozih.Text.Trim = "", "NULL", "'" & txtTozih.Text & "'") &
                         " Where SanadSN = " & vSanadSN.ToString)
            NetSql.Common.CSystem.MsgBox("عمليات با موفقيت انجام شد", MsgBoxStyle.Information)

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Me.Close()

    End Sub
End Class
