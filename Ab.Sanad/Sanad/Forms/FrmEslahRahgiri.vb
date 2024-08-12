' OK
'Author ::Zohreh Izadpanah 
'CreateDate ::  1386/06/21
'ModifiedDate::
'Description::  اصلاح رهگيري رسيد قطعي
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Public Class FrmEslahRahgiri
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRahgiri As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKalaDS As System.Windows.Forms.TextBox
    Friend WithEvents txtBox_in As System.Windows.Forms.TextBox
    Friend WithEvents txtCan_in As System.Windows.Forms.TextBox
    Friend WithEvents txtCan_inNew As System.Windows.Forms.TextBox
    Friend WithEvents txtBox_inNew As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblCan_new As System.Windows.Forms.Label
    Friend WithEvents lblBox_New As System.Windows.Forms.Label
    Friend WithEvents lblCan As System.Windows.Forms.Label
    Friend WithEvents lblbox As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtEnghezaDate As System.Windows.Forms.TextBox
    Public WithEvents txtToolidDateNew As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents txtToolidDate As TextBox
    Public WithEvents txtEnghezaDateNew As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEnghezaDateNew = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnghezaDate = New System.Windows.Forms.TextBox()
        Me.txtCan_inNew = New System.Windows.Forms.TextBox()
        Me.lblCan_new = New System.Windows.Forms.Label()
        Me.txtBox_inNew = New System.Windows.Forms.TextBox()
        Me.lblBox_New = New System.Windows.Forms.Label()
        Me.txtCan_in = New System.Windows.Forms.TextBox()
        Me.lblCan = New System.Windows.Forms.Label()
        Me.txtBox_in = New System.Windows.Forms.TextBox()
        Me.lblbox = New System.Windows.Forms.Label()
        Me.txtKalaDS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtRahgiri = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtToolidDateNew = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtToolidDate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtToolidDateNew)
        Me.GroupBox1.Controls.Add(Me.txtEnghezaDateNew)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtToolidDate)
        Me.GroupBox1.Controls.Add(Me.txtEnghezaDate)
        Me.GroupBox1.Controls.Add(Me.txtCan_inNew)
        Me.GroupBox1.Controls.Add(Me.lblCan_new)
        Me.GroupBox1.Controls.Add(Me.txtBox_inNew)
        Me.GroupBox1.Controls.Add(Me.lblBox_New)
        Me.GroupBox1.Controls.Add(Me.txtCan_in)
        Me.GroupBox1.Controls.Add(Me.lblCan)
        Me.GroupBox1.Controls.Add(Me.txtBox_in)
        Me.GroupBox1.Controls.Add(Me.lblbox)
        Me.GroupBox1.Controls.Add(Me.txtKalaDS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.txtRahgiri)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 176)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtEnghezaDateNew
        '
        Me.txtEnghezaDateNew.AcceptsReturn = True
        Me.txtEnghezaDateNew.BackColor = System.Drawing.Color.White
        Me.txtEnghezaDateNew.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnghezaDateNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtEnghezaDateNew.ForeColor = System.Drawing.Color.Black
        Me.txtEnghezaDateNew.Location = New System.Drawing.Point(376, 136)
        Me.txtEnghezaDateNew.MaxLength = 0
        Me.txtEnghezaDateNew.Name = "txtEnghezaDateNew"
        Me.txtEnghezaDateNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEnghezaDateNew.Size = New System.Drawing.Size(88, 24)
        Me.txtEnghezaDateNew.TabIndex = 26
        Me.txtEnghezaDateNew.Tag = ""
        Me.txtEnghezaDateNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(464, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "تاريخ انقضا:"
        '
        'txtEnghezaDate
        '
        Me.txtEnghezaDate.AcceptsReturn = True
        Me.txtEnghezaDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnghezaDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnghezaDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtEnghezaDate.ForeColor = System.Drawing.Color.Blue
        Me.txtEnghezaDate.Location = New System.Drawing.Point(213, 47)
        Me.txtEnghezaDate.MaxLength = 0
        Me.txtEnghezaDate.Name = "txtEnghezaDate"
        Me.txtEnghezaDate.ReadOnly = True
        Me.txtEnghezaDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEnghezaDate.Size = New System.Drawing.Size(88, 24)
        Me.txtEnghezaDate.TabIndex = 24
        Me.txtEnghezaDate.Tag = ""
        Me.txtEnghezaDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCan_inNew
        '
        Me.txtCan_inNew.Location = New System.Drawing.Point(104, 104)
        Me.txtCan_inNew.MaxLength = 50
        Me.txtCan_inNew.Name = "txtCan_inNew"
        Me.txtCan_inNew.Size = New System.Drawing.Size(69, 22)
        Me.txtCan_inNew.TabIndex = 2
        '
        'lblCan_new
        '
        Me.lblCan_new.Location = New System.Drawing.Point(176, 104)
        Me.lblCan_new.Name = "lblCan_new"
        Me.lblCan_new.Size = New System.Drawing.Size(32, 22)
        Me.lblCan_new.TabIndex = 23
        Me.lblCan_new.Text = "عدد:"
        '
        'txtBox_inNew
        '
        Me.txtBox_inNew.Location = New System.Drawing.Point(216, 104)
        Me.txtBox_inNew.MaxLength = 50
        Me.txtBox_inNew.Name = "txtBox_inNew"
        Me.txtBox_inNew.Size = New System.Drawing.Size(69, 22)
        Me.txtBox_inNew.TabIndex = 1
        '
        'lblBox_New
        '
        Me.lblBox_New.Location = New System.Drawing.Point(288, 104)
        Me.lblBox_New.Name = "lblBox_New"
        Me.lblBox_New.Size = New System.Drawing.Size(40, 22)
        Me.lblBox_New.TabIndex = 21
        Me.lblBox_New.Text = "کارتن:"
        '
        'txtCan_in
        '
        Me.txtCan_in.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCan_in.ForeColor = System.Drawing.Color.Blue
        Me.txtCan_in.Location = New System.Drawing.Point(381, 48)
        Me.txtCan_in.MaxLength = 50
        Me.txtCan_in.Name = "txtCan_in"
        Me.txtCan_in.ReadOnly = True
        Me.txtCan_in.Size = New System.Drawing.Size(69, 22)
        Me.txtCan_in.TabIndex = 20
        Me.txtCan_in.TabStop = False
        '
        'lblCan
        '
        Me.lblCan.Location = New System.Drawing.Point(453, 48)
        Me.lblCan.Name = "lblCan"
        Me.lblCan.Size = New System.Drawing.Size(32, 22)
        Me.lblCan.TabIndex = 19
        Me.lblCan.Text = "عدد:"
        '
        'txtBox_in
        '
        Me.txtBox_in.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBox_in.ForeColor = System.Drawing.Color.Blue
        Me.txtBox_in.Location = New System.Drawing.Point(504, 48)
        Me.txtBox_in.MaxLength = 50
        Me.txtBox_in.Name = "txtBox_in"
        Me.txtBox_in.ReadOnly = True
        Me.txtBox_in.Size = New System.Drawing.Size(69, 22)
        Me.txtBox_in.TabIndex = 18
        Me.txtBox_in.TabStop = False
        '
        'lblbox
        '
        Me.lblbox.Location = New System.Drawing.Point(573, 48)
        Me.lblbox.Name = "lblbox"
        Me.lblbox.Size = New System.Drawing.Size(40, 22)
        Me.lblbox.TabIndex = 17
        Me.lblbox.Text = "کارتن:"
        '
        'txtKalaDS
        '
        Me.txtKalaDS.BackColor = System.Drawing.Color.Gainsboro
        Me.txtKalaDS.ForeColor = System.Drawing.Color.Blue
        Me.txtKalaDS.Location = New System.Drawing.Point(213, 18)
        Me.txtKalaDS.MaxLength = 50
        Me.txtKalaDS.Name = "txtKalaDS"
        Me.txtKalaDS.ReadOnly = True
        Me.txtKalaDS.Size = New System.Drawing.Size(360, 22)
        Me.txtKalaDS.TabIndex = 16
        Me.txtKalaDS.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(573, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "کالا:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(8, 144)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(64, 24)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "تاييد"
        '
        'txtRahgiri
        '
        Me.txtRahgiri.Location = New System.Drawing.Point(336, 104)
        Me.txtRahgiri.MaxLength = 50
        Me.txtRahgiri.Name = "txtRahgiri"
        Me.txtRahgiri.Size = New System.Drawing.Size(128, 22)
        Me.txtRahgiri.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(464, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "کد رهگيري :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(301, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "تاريخ انقضا:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(288, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "تاريخ تولید:"
        '
        'txtToolidDateNew
        '
        Me.txtToolidDateNew.AcceptsReturn = True
        Me.txtToolidDateNew.BackColor = System.Drawing.Color.White
        Me.txtToolidDateNew.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToolidDateNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToolidDateNew.ForeColor = System.Drawing.Color.Black
        Me.txtToolidDateNew.Location = New System.Drawing.Point(197, 136)
        Me.txtToolidDateNew.MaxLength = 0
        Me.txtToolidDateNew.Name = "txtToolidDateNew"
        Me.txtToolidDateNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToolidDateNew.Size = New System.Drawing.Size(88, 21)
        Me.txtToolidDateNew.TabIndex = 26
        Me.txtToolidDateNew.Tag = ""
        Me.txtToolidDateNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(144, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "تاريخ تولید:"
        '
        'txtToolidDate
        '
        Me.txtToolidDate.AcceptsReturn = True
        Me.txtToolidDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtToolidDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToolidDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToolidDate.ForeColor = System.Drawing.Color.Blue
        Me.txtToolidDate.Location = New System.Drawing.Point(50, 49)
        Me.txtToolidDate.MaxLength = 0
        Me.txtToolidDate.Name = "txtToolidDate"
        Me.txtToolidDate.ReadOnly = True
        Me.txtToolidDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToolidDate.Size = New System.Drawing.Size(88, 21)
        Me.txtToolidDate.TabIndex = 24
        Me.txtToolidDate.Tag = ""
        Me.txtToolidDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmEslahRahgiri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(634, 178)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MaximizeBox = False
        Me.Name = "FrmEslahRahgiri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اصلاح شماره رهگيري"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmEslahRahgiri
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmEslahRahgiri
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmEslahRahgiri
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmEslahRahgiri)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Public Variables"

    Public vSanadHaSN As String
    Public vKala As String
    Public VCan_In As Decimal
    Public VTarakoneshsn As Decimal
    Public VBox_In As Integer
    Public VTedadAjza As Decimal
    Public VNoeVoroodeAsnad As EnumNoeVoroodeAsnad
    Public vShomarehRahgiri As String

    Public vEnghezaDate As String
    Public VEnghezaDateFlag As String

    Public vToolidDate As String
    Public VToolidDateFlag As String
    Public VIsRahgiriAuto As Boolean

#End Region

    Private dclEnghezaDate As NetSql.Components.CDateCtrl
    Private dclEnghezaDateNew As NetSql.Components.CDateCtrl

    Private dclToolidDateNew As NetSql.Components.CDateCtrl
    Private dclToolidDate As NetSql.Components.CDateCtrl

    Private Sub FrmEslahRahgiri_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dclEnghezaDate = New NetSql.Components.CDateCtrl(tp)
        dclEnghezaDate.DateFormat = EnumDateFormat.dfFullYear
        dclEnghezaDate.TextBox = txtEnghezaDate

        dclToolidDate = New NetSql.Components.CDateCtrl(tp)
        dclToolidDate.DateFormat = EnumDateFormat.dfFullYear
        dclToolidDate.TextBox = txtToolidDate




        dclEnghezaDateNew = New NetSql.Components.CDateCtrl(tp)
        dclEnghezaDateNew.DateFormat = EnumDateFormat.dfFullYear
        dclEnghezaDateNew.TextBox = txtEnghezaDateNew

        dclToolidDateNew = New NetSql.Components.CDateCtrl(tp)
        dclToolidDateNew.DateFormat = EnumDateFormat.dfFullYear
        dclToolidDateNew.TextBox = txtToolidDateNew


        txtKalaDS.Text = vKala
        dclEnghezaDate.Text = vEnghezaDate
        dclEnghezaDateNew.Text = vEnghezaDate
        txtRahgiri.Text = vShomarehRahgiri

        dclToolidDate.Text = vToolidDate
        dclToolidDateNew.Text = vToolidDate

        SetTextBoxReadOnly(txtRahgiri, VIsRahgiriAuto)
        SetTextBoxReadOnly(txtBox_inNew, VIsRahgiriAuto)
        SetTextBoxReadOnly(txtCan_inNew, VIsRahgiriAuto)

        If VTarakoneshsn = EnumTarakoneshSN.RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR Then
            SetTextBoxReadOnly(txtRahgiri, True)
            SetTextBoxReadOnly(txtBox_inNew, True)
            SetTextBoxReadOnly(txtCan_inNew, True)
        End If

        If VNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh Then
            txtCan_inNew.Visible = False
            lblCan_new.Visible = False
            txtCan_in.Visible = False
            lblCan.Visible = False

            lblBox_New.Text = "مقدار"
            lblbox.Text = "مقدار"

            txtBox_in.Text = VBox_In
            txtBox_inNew.Text = VBox_In

        Else
            txtBox_in.Text = VBox_In
            txtCan_in.Text = VCan_In

            txtBox_inNew.Text = VBox_In
            txtCan_inNew.Text = VCan_In
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Box_inNew As Integer
        Dim Can_inNew As Integer
        Dim Meghdar As Decimal
        Dim vErrMsg As String

        If Val(txtBox_inNew.Text) = 0 AndAlso Val(txtCan_inNew.Text) = 0 Then
            NetSql.Common.CSystem.MsgBox("لطفا کارتن و عدد صحيح را وراد نماييد.", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If

        Box_inNew = Val(txtBox_inNew.Text)
        Can_inNew = Val(txtCan_inNew.Text)
        Meghdar = Box_inNew * VTedadAjza + Can_inNew

        If Meghdar > VBox_In * VTedadAjza + VCan_In Then
            NetSql.Common.CSystem.MsgBox("مقدار وارده بيشتر از مقدار اوليه مي باشد.", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If

        If vShomarehRahgiri = Trim(txtRahgiri.Text) And Meghdar <> VBox_In * VTedadAjza + VCan_In Then
            NetSql.Common.CSystem.MsgBox("شماره رهگيري با مقدار قبلي آن يکي مي باشد.در اين حالت بايد مقدار برابر مقدار قبلي باشد.",
                       MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If

        If Trim(txtRahgiri.Text) = "0" Or Trim(txtRahgiri.Text) = "" Then
            NetSql.Common.CSystem.MsgBox("شماره رهگيري انتخابي نامعتبر است", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        If VEnghezaDateFlag = "1" AndAlso dclEnghezaDateNew.Value = "" Then
            NetSql.Common.CSystem.MsgBox("تاريخ انقضاي جديد مشخص نشده است",
                       MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
            Exit Sub
        End If
        If VToolidDateFlag = "1" AndAlso dclToolidDateNew.Value = "" Then
            NetSql.Common.CSystem.MsgBox("تاريخ تولید جديد مشخص نشده است",
                       MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
            Exit Sub
        End If

        If Not String.IsNullOrEmpty(dclToolidDateNew.Value) AndAlso Not String.IsNullOrEmpty(dclEnghezaDateNew.Value) Then
            If dclToolidDateNew.Value >= dclEnghezaDateNew.Value Then
                NetSql.Common.CSystem.MsgBox("تاريخ تولید جديد نباید از تاریخ انقضاء جدید بزرگتر باشد ",
                       MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If
        End If


        If dclEnghezaDateNew.Value > "20000101" AndAlso dclEnghezaDateNew.Value <> "" Then
            dclEnghezaDateNew.Value =
                CShamsiDate.MiladiToShamsi(Date.Parse(dclEnghezaDateNew.Text), EnumDateFormat.dfDefault)
        End If

        If dclToolidDateNew.Value > "20000101" AndAlso dclToolidDateNew.Value <> "" Then
            dclToolidDateNew.Value =
                CShamsiDate.MiladiToShamsi(Date.Parse(dclToolidDateNew.Text), EnumDateFormat.dfDefault)
        End If


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        cn.CallSP("_abSp_EslaheShomrehRahgiri", vSanadHaSN, Trim(txtRahgiri.Text), Meghdar, dclEnghezaDateNew.Value,
                   gSM.UserID_Name _
                   , vErrMsg)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading +
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        Else

            NetSql.Common.CSystem.MsgBox("عمليات با موفقيت انجام شد", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

    Private Sub SetTextBoxReadOnly(ByVal ctrl As TextBox, ByVal State As Boolean)
        ctrl.ReadOnly = State
        If State = True Then
            ctrl.BackColor = System.Drawing.Color.Gainsboro
            ctrl.ForeColor = System.Drawing.Color.Blue
        Else
            ctrl.BackColor = System.Drawing.Color.White
            ctrl.ForeColor = System.Drawing.Color.Black
        End If

    End Sub
End Class
