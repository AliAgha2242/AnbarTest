' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description:: 
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Friend Class FrmChapeSanad
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

    Protected Overloads Overrides Sub Dispose (ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents chkKalaNoOrder As System.Windows.Forms.CheckBox
    Friend WithEvents FraSanadStaus As System.Windows.Forms.GroupBox
    Friend WithEvents chkSanadStatus_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_8 As System.Windows.Forms.CheckBox
    Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromSanadDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToSanadDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlSanadNO As System.Windows.Forms.Panel
    Friend WithEvents txtToSanadNO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromSanadNO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.pnlSanadNO = New System.Windows.Forms.Panel()
        Me.txtToSanadNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromSanadNO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.FraSanadStaus = New System.Windows.Forms.GroupBox()
        Me.chkSanadStatus_1 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_4 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_8 = New System.Windows.Forms.CheckBox()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromSanadDate = New System.Windows.Forms.TextBox()
        Me.txtToSanadDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkKalaNoOrder = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1.SuspendLayout()
        Me.pnlSanadNO.SuspendLayout()
        Me.FraSanadStaus.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add(Me.pnlSanadNO)
        Me.Frame1.Controls.Add(Me.FraSanadStaus)
        Me.Frame1.Controls.Add(Me.FraSanadDate)
        Me.Frame1.Controls.Add(Me.chkKalaNoOrder)
        Me.Frame1.Controls.Add(Me.btnOk)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(546, 145)
        Me.Frame1.TabIndex = 0
        '
        'pnlSanadNO
        '
        Me.pnlSanadNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSanadNO.Controls.Add(Me.txtToSanadNO)
        Me.pnlSanadNO.Controls.Add(Me.Label2)
        Me.pnlSanadNO.Controls.Add(Me.txtFromSanadNO)
        Me.pnlSanadNO.Controls.Add(Me.Label9)
        Me.pnlSanadNO.Controls.Add(Me.lbl1)
        Me.pnlSanadNO.Location = New System.Drawing.Point(101, 18)
        Me.pnlSanadNO.Name = "pnlSanadNO"
        Me.pnlSanadNO.Size = New System.Drawing.Size(435, 33)
        Me.pnlSanadNO.TabIndex = 50
        '
        'txtToSanadNO
        '
        Me.txtToSanadNO.Location = New System.Drawing.Point(7, 5)
        Me.txtToSanadNO.MaxLength = 15
        Me.txtToSanadNO.Name = "txtToSanadNO"
        Me.txtToSanadNO.Size = New System.Drawing.Size(165, 21)
        Me.txtToSanadNO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(172, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "تا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFromSanadNO
        '
        Me.txtFromSanadNO.Location = New System.Drawing.Point(209, 5)
        Me.txtFromSanadNO.MaxLength = 15
        Me.txtFromSanadNO.Name = "txtFromSanadNO"
        Me.txtFromSanadNO.Size = New System.Drawing.Size(165, 21)
        Me.txtFromSanadNO.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(374, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "از"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(399, 7)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(26, 13)
        Me.lbl1.TabIndex = 27
        Me.lbl1.Text = "سند"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FraSanadStaus
        '
        Me.FraSanadStaus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadStaus.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_1)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_4)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_8)
        Me.FraSanadStaus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadStaus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadStaus.Location = New System.Drawing.Point(261, 57)
        Me.FraSanadStaus.Name = "FraSanadStaus"
        Me.FraSanadStaus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadStaus.Size = New System.Drawing.Size(276, 39)
        Me.FraSanadStaus.TabIndex = 49
        Me.FraSanadStaus.TabStop = False
        Me.FraSanadStaus.Text = "وضعيت"
        '
        'chkSanadStatus_1
        '
        Me.chkSanadStatus_1.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_1.Location = New System.Drawing.Point(119, 13)
        Me.chkSanadStatus_1.Name = "chkSanadStatus_1"
        Me.chkSanadStatus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_1.Size = New System.Drawing.Size(81, 21)
        Me.chkSanadStatus_1.TabIndex = 2
        Me.chkSanadStatus_1.Text = "پيشنويس"
        Me.chkSanadStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_4
        '
        Me.chkSanadStatus_4.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_4.Location = New System.Drawing.Point(58, 13)
        Me.chkSanadStatus_4.Name = "chkSanadStatus_4"
        Me.chkSanadStatus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_4.Size = New System.Drawing.Size(59, 21)
        Me.chkSanadStatus_4.TabIndex = 3
        Me.chkSanadStatus_4.Text = "موقت"
        Me.chkSanadStatus_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_8
        '
        Me.chkSanadStatus_8.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.Checked = True
        Me.chkSanadStatus_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSanadStatus_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_8.Location = New System.Drawing.Point(1, 13)
        Me.chkSanadStatus_8.Name = "chkSanadStatus_8"
        Me.chkSanadStatus_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_8.Size = New System.Drawing.Size(55, 21)
        Me.chkSanadStatus_8.TabIndex = 4
        Me.chkSanadStatus_8.Text = "قطعي"
        Me.chkSanadStatus_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.UseVisualStyleBackColor = False
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromSanadDate)
        Me.FraSanadDate.Controls.Add(Me.txtToSanadDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(23, 57)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(231, 39)
        Me.FraSanadDate.TabIndex = 48
        Me.FraSanadDate.TabStop = False
        '
        'txtFromSanadDate
        '
        Me.txtFromSanadDate.AcceptsReturn = True
        Me.txtFromSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSanadDate.Enabled = False
        Me.txtFromSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSanadDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSanadDate.MaxLength = 0
        Me.txtFromSanadDate.Name = "txtFromSanadDate"
        Me.txtFromSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSanadDate.TabIndex = 5
        Me.txtFromSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSanadDate
        '
        Me.txtToSanadDate.AcceptsReturn = True
        Me.txtToSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSanadDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSanadDate.MaxLength = 0
        Me.txtToSanadDate.Name = "txtToSanadDate"
        Me.txtToSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSanadDate.TabIndex = 6
        Me.txtToSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(175, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "از"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(82, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(188, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkKalaNoOrder
        '
        Me.chkKalaNoOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKalaNoOrder.Location = New System.Drawing.Point(321, 102)
        Me.chkKalaNoOrder.Name = "chkKalaNoOrder"
        Me.chkKalaNoOrder.Size = New System.Drawing.Size(213, 24)
        Me.chkKalaNoOrder.TabIndex = 7
        Me.chkKalaNoOrder.Text = "چاپ سند به ترتيب کد کالا"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(6, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "مشاهده گزارش"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'FrmChapeSanad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(546, 145)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "FrmChapeSanad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش چاپ اسناد"
        Me.Frame1.ResumeLayout(False)
        Me.pnlSanadNO.ResumeLayout(False)
        Me.pnlSanadNO.PerformLayout()
        Me.FraSanadStaus.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmChapeSanad
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmChapeSanad
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmChapeSanad
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmChapeSanad)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region

    Private Sub FrmChapeSanad_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dclFDate = New NetSql.Components.CDateCtrl (tp)
        dclFDate.TextBox = txtFromSanadDate
        dclTDate = New NetSql.Components.CDateCtrl (tp)
        dclTDate.TextBox = txtToSanadDate

        If Trim (gHesabdariSalFDate) <> "" And Trim (gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left (Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                                  cn, _
                                                                                                  Functions. _
                                                                                                     FTDBCommonFunctions _
                                                                                                     .enmDateFormat. _
                                                                                                     Normal), 2) & _
                             "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                         cn, _
                                                                                         Functions.FTDBCommonFunctions. _
                                                                                            enmDateFormat.Normal)
        End If
    End Sub

    Private Sub btnOk_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnOk.Click
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim strAnbars, strNoeAnbars As String
        Dim vSanadStatus As String
        Dim vRptabSanad As New RptabSanad
        Dim vKalaNoOrder As Boolean
        Dim vFromSanadNo As String
        Dim vToSanadNo As String

        If Trim (dclFDate.Text) <> "" Then
            vFromDate = Trim (dclFDate.Value)
        Else
            vErrMsg = vErrMsg & Chr (13) & "از تاريخ مشخص نشده است"
        End If
        If Trim (dclTDate.Text) <> "" Then
            vToDate = Trim (dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Chr (13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr (gAnbarSN)
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then

            vSanadStatus = ""
            If chkSanadStatus_1.CheckState = 1 Then _
                vSanadStatus = vSanadStatus & IIf (vSanadStatus.Length > 0, ",1", "1")
            If chkSanadStatus_4.CheckState = 1 Then _
                vSanadStatus = vSanadStatus & IIf (vSanadStatus.Length > 0, ",4", "4")
            If chkSanadStatus_8.CheckState = 1 Then _
                vSanadStatus = vSanadStatus & IIf (vSanadStatus.Length > 0, ",8", "8")
            If Trim (vSanadStatus) = "" Then vSanadStatus = "1,4,8"

            If Trim (txtFromSanadNO.Text) <> "" Then
                vFromSanadNo = Trim (txtFromSanadNO.Text)
            End If

            If Trim (txtToSanadNO.Text) <> "" Then
                vToSanadNo = Trim (txtToSanadNO.Text)
            End If

            If chkKalaNoOrder.Checked Then
                vKalaNoOrder = 1
            Else
                vKalaNoOrder = 0
            End If

            With vRptabSanad
                .gRptabSanadNoeAnbar = gNoeAnbarSN
                .DefField()
                ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                ' Yes
                .DataSource = cn.SPQuery ("_abSpr_ChapeSanad", System.DBNull.Value, vFromDate, vToDate _
                                          , strAnbars, strNoeAnbars _
                                          , CStr (gVahedeTejariSN), System.DBNull.Value, System.DBNull.Value _
                                          , vSanadStatus _
                                          , Val (txtFromSanadNO.Text), Val (txtToSanadNO.Text), System.DBNull.Value _
                                          , System.DBNull.Value, System.DBNull.Value, vKalaNoOrder)
                Minoo.Reports.FTReportViewer.ShowReport (vRptabSanad, Me.MdiParent)
            End With
            Me.Cursor = Cursors.Default
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub
End Class
