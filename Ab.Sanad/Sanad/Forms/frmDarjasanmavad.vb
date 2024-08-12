'Programmer :: Ghafari saeed   
'CreateDate :: 1390/11/23
'ModifiedDate::
'Description:: فرم درج آسان مواد برای شرکتهای تولیدی 
'System :: سيستم انبار

Imports Anbar.BRL

Public Class frmDarjasanmavad

    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LabelMahsul As System.Windows.Forms.Label
    Friend WithEvents CmbMhsul As NetSql.Components.DataCombo
    Public WithEvents txtMeghdar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.LabelMahsul = New System.Windows.Forms.Label()
        Me.CmbMhsul = New NetSql.Components.DataCombo(Me.components)
        Me.txtMeghdar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(141, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "انصراف"
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Location = New System.Drawing.Point(211, 64)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(64, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "درج"
        '
        'LabelMahsul
        '
        Me.LabelMahsul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMahsul.AutoSize = True
        Me.LabelMahsul.BackColor = System.Drawing.Color.Transparent
        Me.LabelMahsul.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMahsul.Location = New System.Drawing.Point(304, 15)
        Me.LabelMahsul.Name = "LabelMahsul"
        Me.LabelMahsul.Size = New System.Drawing.Size(103, 13)
        Me.LabelMahsul.TabIndex = 135
        Me.LabelMahsul.Text = "محصول/نیمه ساخته:"
        '
        'CmbMhsul
        '
        Me.CmbMhsul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMhsul.AutoSelectFirst = False
        Me.CmbMhsul.BackColor = System.Drawing.Color.White
        Me.CmbMhsul.BoundText = Nothing
        Me.CmbMhsul.BypassChangeEvent = False
        Me.CmbMhsul.DisplayText = ""
        Me.CmbMhsul.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMhsul.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.CmbMhsul.LateBindingTop = "100"
        Me.CmbMhsul.Location = New System.Drawing.Point(14, 12)
        Me.CmbMhsul.MemFilter = ""
        Me.CmbMhsul.Name = "CmbMhsul"
        Me.CmbMhsul.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbMhsul.SeparatedData = Nothing
        Me.CmbMhsul.Size = New System.Drawing.Size(286, 21)
        Me.CmbMhsul.Source = Nothing
        Me.CmbMhsul.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbMhsul.TabIndex = 134
        '
        'txtMeghdar
        '
        Me.txtMeghdar.AcceptsReturn = True
        Me.txtMeghdar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMeghdar.BackColor = System.Drawing.SystemColors.Window
        Me.txtMeghdar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMeghdar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMeghdar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMeghdar.Location = New System.Drawing.Point(141, 37)
        Me.txtMeghdar.MaxLength = 0
        Me.txtMeghdar.Name = "txtMeghdar"
        Me.txtMeghdar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMeghdar.Size = New System.Drawing.Size(159, 21)
        Me.txtMeghdar.TabIndex = 136
        Me.txtMeghdar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "تعداد:"
        '
        'frmDarjasanmavad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(416, 104)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMeghdar)
        Me.Controls.Add(Me.LabelMahsul)
        Me.Controls.Add(Me.CmbMhsul)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDarjasanmavad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "درج آسان مواد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _DarkhastSN As Decimal
    Friend Property DarkhastSN() As Decimal
        Get
            DarkhastSN = _DarkhastSN
        End Get
        Set(ByVal Value As Decimal)
            _DarkhastSN = Value
        End Set
    End Property

#Region "PublicVariablesDefinition"

    Public EbtalDate As String

#End Region

#Region "PrivateVariabledDefinition"

    Private dcldate As NetSql.Components.CDateCtrl

#End Region

    '//ناحيه تعريف متغيرهاي Local

    Private Sub frmDarjasanmavad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim vMahsulSql As String
        'vMahsulSql = "SELECT DISTINCT KalaNo+'-'+KalaDS AS KalaDS ,T1.KalaSN From Pakala T1 " & _
        '             " inner join hstolidekala t2 ON T1.KalaSN = T2.KalaSN " & _
        '             " inner join hsMasrafeKala t3 ON T2.KartEstandardSN = T3.KartEstandardSN"
        vMahsulSql = "Select KartEstandardSN,KalaNoFaaliyatDS from btVw_KarteStandard where KartEstandardStatus=1 And Status=4"
        CmbMhsul.Bind(cn, vMahsulSql, "KartEstandardSN", "KalaNoFaaliyatDS")

        'dcldate = New NetSql.Components.CDateCtrl(tp)
        'dcldate.TextBox = txtDate
        'dcldate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        'dcldate.Text = gHesabdariSalFDate

        'Me.FirstFocusControl = txtDate

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim ds As New DataSet
        Dim _Meghdar As Decimal = 0

        _Meghdar = Val(txtMeghdar.Text)

        Dim _Cls As New ClsDataAccessRule

        If Val(CmbMhsul.BoundText) <> 0 Then
            ds = _Cls.GetMAvadbariKarteStandard(CDec(CmbMhsul.BoundText), _Meghdar, 1, MiladiToShamsi(Today), cn)
        End If

        If Not (ds Is Nothing) AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            _Cls.InsertDarkhastKaladetail(DarkhastSN, gAnbarSN, ds, cn, gSM.UserID_Name)
        End If

        DialogResult = DialogResult.OK

    End Sub

End Class
