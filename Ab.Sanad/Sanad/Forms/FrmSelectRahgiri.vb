Option Strict Off
Option Explicit On

' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/11/13
'ModifiedDate::
'Description::  انتخاب کالاي فيزيکي
'  در ثبت اقلام سند لازم ميشود که کالاي فيزيکي مورد استفاده قرار گيرد 
' بوسيله اين فرم با توجه به کالاي انتخاب شده کليه کالافيزيکي هاي آن براي کاربر به همراه موجودي و ساير اطلاعات ليست ميگردد
' و کاربر ميتواند مورد دلخواه را انتخاب نمايد
'System ::انبار

Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Friend Class FrmSelectRahgiri
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'If m_vb6FormDefInstance Is Nothing Then
        '    If m_InitializingDefInstance Then
        '        m_vb6FormDefInstance = Me
        '    Else
        '        Try
        '            If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
        '                m_vb6FormDefInstance = Me
        '            End If
        '        Catch
        '        End Try
        '    End If
        'End If
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
    Public WithEvents btnSelectAll As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll As System.Windows.Forms.Button
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents opnVoroodBeAnbar As System.Windows.Forms.RadioButton
    Friend WithEvents opnToolid As System.Windows.Forms.RadioButton
    Friend WithEvents opnEngheza As System.Windows.Forms.RadioButton
    Friend WithEvents txtMeghdar As System.Windows.Forms.TextBox
    Public WithEvents btnRefreshMeghdar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMojoodiNorez As System.Windows.Forms.TextBox
    Public WithEvents btnDarjAsan As System.Windows.Forms.Button

    Public IsTolidi As Boolean = True  ''ghasemi
    Public IsStandard As Boolean = True  ''ghasemi

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDarjAsan = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.opnVoroodBeAnbar = New System.Windows.Forms.RadioButton()
        Me.opnToolid = New System.Windows.Forms.RadioButton()
        Me.opnEngheza = New System.Windows.Forms.RadioButton()
        Me.txtMeghdar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefreshMeghdar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMojoodiNorez = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnDarjAsan)
        Me.GroupBox1.Controls.Add(Me.btnSelectAll)
        Me.GroupBox1.Controls.Add(Me.btnDeselectAll)
        Me.GroupBox1.Controls.Add(Me.pnlN)
        Me.GroupBox1.Controls.Add(Me.pnlG)
        Me.GroupBox1.Controls.Add(Me.pnlC)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(773, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ليست موجودي کالا فيزيکي‌هاي کالاي : "
        '
        'btnDarjAsan
        '
        Me.btnDarjAsan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjAsan.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjAsan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAsan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAsan.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarjAsan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAsan.Location = New System.Drawing.Point(432, 243)
        Me.btnDarjAsan.Name = "btnDarjAsan"
        Me.btnDarjAsan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAsan.Size = New System.Drawing.Size(75, 29)
        Me.btnDarjAsan.TabIndex = 7
        Me.btnDarjAsan.Tag = ""
        Me.btnDarjAsan.Text = "درج آسان"
        Me.btnDarjAsan.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Location = New System.Drawing.Point(386, 243)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        Me.btnSelectAll.Visible = False
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Location = New System.Drawing.Point(342, 243)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        Me.btnDeselectAll.UseVisualStyleBackColor = False
        Me.btnDeselectAll.Visible = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 243)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(329, 29)
        Me.pnlN.TabIndex = 3
        '
        'pnlG
        '
        Me.pnlG.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(2, 18)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(767, 220)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(567, 244)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(195, 29)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(509, 243)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(53, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Tag = ""
        Me.btnSelect.Text = "انتخاب"
        Me.btnSelect.UseVisualStyleBackColor = False
        Me.btnSelect.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(609, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "انتخاب کالا فيزيکي بر اساس :"
        Me.Label1.Visible = False
        '
        'opnVoroodBeAnbar
        '
        Me.opnVoroodBeAnbar.Checked = True
        Me.opnVoroodBeAnbar.Location = New System.Drawing.Point(477, 7)
        Me.opnVoroodBeAnbar.Name = "opnVoroodBeAnbar"
        Me.opnVoroodBeAnbar.Size = New System.Drawing.Size(126, 24)
        Me.opnVoroodBeAnbar.TabIndex = 2
        Me.opnVoroodBeAnbar.TabStop = True
        Me.opnVoroodBeAnbar.Text = "تاريخ ورود به انبار"
        Me.opnVoroodBeAnbar.Visible = False
        '
        'opnToolid
        '
        Me.opnToolid.Location = New System.Drawing.Point(325, 6)
        Me.opnToolid.Name = "opnToolid"
        Me.opnToolid.Size = New System.Drawing.Size(104, 24)
        Me.opnToolid.TabIndex = 3
        Me.opnToolid.Text = "تاريخ توليد"
        Me.opnToolid.Visible = False
        '
        'opnEngheza
        '
        Me.opnEngheza.Location = New System.Drawing.Point(173, 7)
        Me.opnEngheza.Name = "opnEngheza"
        Me.opnEngheza.Size = New System.Drawing.Size(104, 24)
        Me.opnEngheza.TabIndex = 4
        Me.opnEngheza.Text = "تاريخ انقضاء"
        Me.opnEngheza.Visible = False
        '
        'txtMeghdar
        '
        Me.txtMeghdar.Location = New System.Drawing.Point(527, 38)
        Me.txtMeghdar.Name = "txtMeghdar"
        Me.txtMeghdar.ReadOnly = True
        Me.txtMeghdar.Size = New System.Drawing.Size(119, 23)
        Me.txtMeghdar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(652, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "تعداد در خواستي :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefreshMeghdar
        '
        Me.btnRefreshMeghdar.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefreshMeghdar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRefreshMeghdar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefreshMeghdar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshMeghdar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefreshMeghdar.Location = New System.Drawing.Point(173, 34)
        Me.btnRefreshMeghdar.Name = "btnRefreshMeghdar"
        Me.btnRefreshMeghdar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRefreshMeghdar.Size = New System.Drawing.Size(212, 31)
        Me.btnRefreshMeghdar.TabIndex = 41
        Me.btnRefreshMeghdar.Text = "انتخاب کالا فيزيکي ها با توجه شرايط"
        Me.btnRefreshMeghdar.UseVisualStyleBackColor = False
        Me.btnRefreshMeghdar.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "موجودی بدون رزرو:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'txtMojoodiNorez
        '
        Me.txtMojoodiNorez.Location = New System.Drawing.Point(396, 36)
        Me.txtMojoodiNorez.Name = "txtMojoodiNorez"
        Me.txtMojoodiNorez.ReadOnly = True
        Me.txtMojoodiNorez.Size = New System.Drawing.Size(67, 23)
        Me.txtMojoodiNorez.TabIndex = 42
        Me.txtMojoodiNorez.Visible = False
        '
        'FrmSelectRahgiri
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(781, 362)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMojoodiNorez)
        Me.Controls.Add(Me.btnRefreshMeghdar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMeghdar)
        Me.Controls.Add(Me.opnEngheza)
        Me.Controls.Add(Me.opnToolid)
        Me.Controls.Add(Me.opnVoroodBeAnbar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmSelectRahgiri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب کالاي فيزيکي"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmSelectRahgiri
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSelectRahgiri
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSelectRahgiri
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmSelectRahgiri)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي فيزيکي تعريف شده است
    Private WithEvents DvabVw_KalaKalaPhiziki As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFlex_abVw_KalaKalaPhiziki As AxVSFlexGrid

    ' کالا فيزيکي انتخاب شده
    Private mSelected As String
    ' کالاي مورد نظر جهت نمايش کالافيزيکي ها 
    Private mKalaSN As Decimal
    Private mMeghdar As Decimal
    Private mMojoodiNorez As Decimal
    Private mMoaserDate As String
    Private mKalaDs As String
    Private mSanadRow As DataRow
    Private mMode As Byte
    Private mNoeMadomiSN As Decimal
    Private mNoeMarjooeiSN As Decimal
    Private mNoeZayeatSN As Decimal
    Private mDarkhstHaSN As Decimal
    Private mMojavezErsalHaSN As Decimal
    Private mDaftarForooshSN As Decimal
    Private VinKalano As String, VinKalaDs As String
    Private DV As DataView

#End Region



#Region "PropertyDefinition"

    Public Property KalaSN() As Decimal
        Get
            KalaSN = mKalaSN
        End Get
        Set(ByVal Value As Decimal)
            mKalaSN = Value
        End Set
    End Property

    Public Property Meghdar() As Decimal
        Get
            Meghdar = mMeghdar
        End Get
        Set(ByVal Value As Decimal)
            mMeghdar = Value
        End Set
    End Property

    Public Property MojoodiNorez() As Decimal
        Get
            MojoodiNorez = mMojoodiNorez
        End Get
        Set(ByVal Value As Decimal)
            mMojoodiNorez = Value
        End Set
    End Property

    Public Property MoaserDate() As String
        Get
            MoaserDate = mMoaserDate
        End Get
        Set(ByVal Value As String)
            mMoaserDate = Value
        End Set
    End Property

    Public Property Selected() As String
        Get
            Selected = mSelected
        End Get
        Set(ByVal Value As String)
            mSelected = Value
            SelectByStr(mSelected)
        End Set
    End Property

    Public Property Mode() As Byte
        Get
            Mode = mMode
        End Get
        Set(ByVal Value As Byte)
            mMode = Value
        End Set
    End Property

    Public Property SanadRow() As DataRow
        Get
            SanadRow = mSanadRow
        End Get
        Set(ByVal Value As DataRow)
            mSanadRow = Value
        End Set
    End Property

    Public Property NoeMarjooeiSN() As Decimal
        Get
            NoeMarjooeiSN = mNoeMarjooeiSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeMarjooeiSN = Value
        End Set
    End Property

    Public Property NoeMadomiSN() As Decimal
        Get
            NoeMadomiSN = mNoeMadomiSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeMadomiSN = Value
        End Set
    End Property

    Public Property NoeZayeatSN() As Decimal
        Get
            NoeZayeatSN = mNoeZayeatSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeZayeatSN = Value
        End Set
    End Property

    Public Property DarkhastHaSN() As Decimal
        Get
            NoeMadomiSN = mDarkhstHaSN
        End Get
        Set(ByVal Value As Decimal)
            mDarkhstHaSN = Value
        End Set
    End Property
    'by yekta 911010  MojavezErsalHaSN()
    Public Property MojavezErsalHaSN() As Decimal
        Get
            MojavezErsalHaSN = mMojavezErsalHaSN
        End Get
        Set(ByVal Value As Decimal)
            mMojavezErsalHaSN = Value
        End Set
    End Property

    Public Property DaftarForoshSN() As Decimal
        Get
            DaftarForoshSN = mDaftarForooshSN
        End Get
        Set(ByVal Value As Decimal)
            mDaftarForooshSN = Value
        End Set
    End Property

#End Region

    Private Sub btnDeselectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub btnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelect.Click
        ' انتخاب کليد اوليه کالافيزيکي انتخاب شده توسط کاربر
        Dim I As Short
        Dim vSanadHaSelected As String
        vSanadHaSelected = ""
        With pFlex_abVw_KalaKalaPhiziki
            For I = .FixedRows To .Rows - 1
                If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                    '850722
                    '          vSanadHaSelected = vSanadHaSelected & " , " & Val(.GetCellCheck(I, .get_ColIndex("ShomarehRahgiri")))
                    vSanadHaSelected = vSanadHaSelected & " , " & .get_TextMatrix(I, .get_ColIndex("ShomarehRahgiri"))
                    Exit For
                End If
            Next
        End With
        If Len(vSanadHaSelected) > 0 Then
            vSanadHaSelected = Mid(vSanadHaSelected, 4, Len(vSanadHaSelected))
        End If
        mSelected = vSanadHaSelected
        mMode = 1
        Me.Hide()
    End Sub

    Private Sub btnSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub DvabVw_KalaKalaPhiziki_GetGridProperties() Handles DvabVw_KalaKalaPhiziki.GetGridProperties
        DvabVw_KalaKalaPhiziki.FlexGrid.FontSize = 10
    End Sub

    Private Sub FrmSelectRahgiri_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        If pISLoaded Then
            Exit Sub
        End If
        pISLoaded = True
        mMode = 0
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvabVw_KalaKalaPhiziki = New CDataView(cn)
        With DvabVw_KalaKalaPhiziki
            ''''''''''''''''''''''''''''
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdExit)
            .CommandVisible(EnumCommands.cmExit) = False
            .QueryName = "abVw_KalaKalaPhiziki"
            .Text = Me.Text
            .Text = FTDD.GetCaption("abVw_KalaKalaPhiziki")
            .EditInGrid = False
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
            ' سلکت  گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
            Dim __AnbarSN As Decimal = gAnbarSN


            ''ghasemi14030118
            If EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR = SanadRow.Item("tarakoneshsn") Then
                __AnbarSN = SanadRow.Item("ToAnbarSN")
            End If
            ''ghasemi14030118

            Dim TarakoneshSN As Integer
            TarakoneshSN = SanadRow.Item("tarakoneshsn")


            'If DaftarForoshSN > 0 Then
            '    DV = cn.ExecuteQuery(
            '         "_abSPG_SelectRahgiri_DaftarForoosh  " + CStr(gVahedeTejariSN) + "," + CStr(__AnbarSN) + "," +
            '         CStr(gNoeAnbarSN) + "," + CStr(KalaSN) + "," + gHesabdariSalFDate + "," +
            '         MoaserDate + "," + CStr(TarakoneshSN) + "," + CStr(DaftarForoshSN))
            'Else
            DV = cn.ExecuteQuery(
                                     "_abSPG_SelectRahgiri  " + CStr(gVahedeTejariSN) + "," + CStr(__AnbarSN) + "," +
                                     CStr(gNoeAnbarSN) + "," + CStr(KalaSN) + "," + gHesabdariSalFDate + "," +
                                     MoaserDate + "," + CStr(TarakoneshSN))
            'End If


            .DataSource = DV

            pFlex_abVw_KalaKalaPhiziki = .FlexGrid
            pFlex_abVw_KalaKalaPhiziki.Editable = EditableSettings.flexEDKbdMouse
            '''''''''''''''''''''''''''
            .FlexGrid.ColDataType(1) = GetType(Boolean)
            .FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("KalaPhizikiStatusSn")) = True
            .FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("NerkhVaghey")) = True  ''ghasemi

            Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
            'Dim CAppSet As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, 3)
            'IsTolidi = IIf(CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi"))
            IsTolidi = IsVahedTejariTolidi

            ''ghasemi 14021201
            Dim CAppStandard As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
            IsStandard = IIf(CAppStandard.GetAppConfig("gCountNerkhGhati") Is System.DBNull.Value, False, True)

            If IsTolidi And IsStandard Then

                .FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("NerkhVaghey")) = False
            End If
            ''ghasemi 14021201
            '.FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("KalaDS")) = True

            '.Fields.Item("KalaphizikiSN").FieldOptions.foHidden()
            'With .Fields
            '    With .Add("KalaphizikiSN", , gSNFieldOption)
            '        .DefaultValue = gSM.Identifier
            '    End With

            'End With
        End With

        DvabVw_KalaKalaPhiziki.Refresh()

        Dim vKalaSN As Object
        Dim VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer
        Dim vResult As Short

        If Val(KalaSN) <> 0 Then
            ' با توجه به کالا اطلاعات جانبي نمايش داده شود 
            vKalaSN = KalaSN
            vResult = cn.CallSP("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value, _
                                 System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo, _
                                 VinVahedeSanjeshDs, VinTedadAjza)
        End If

        txtMeghdar.Text = IIf(Meghdar = 0, "", Meghdar)
        'txtMojoodiNorez.Text = IIf(MojoodiNorez = 0, "", MojoodiNorez)
        GroupBox1.Text = "ليست موجودي کالا فيزيکي هاي کالاي : " & VinKalano & " - " & VinKalaDs & " - " & _
                         VinVahedeSanjeshDs

    End Sub

    Private Sub FrmSelectRahgiri_Closing(ByVal eventSender As System.Object, _
                                          ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        SanadRow = Nothing
        Me.Hide()
    End Sub

    Private Sub FrmSelectRahgiri_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvabVw_KalaKalaPhiziki.Done()
        DvabVw_KalaKalaPhiziki = Nothing

    End Sub

    Private Sub pFlex_abVw_KalaKalaPhiziki_AfterEdit(ByVal eventSender As System.Object, _
                                                      ByVal eventArgs As RowColEventArgs) _
        Handles pFlex_abVw_KalaKalaPhiziki.AfterEdit
        If eventArgs.Row < pFlex_abVw_KalaKalaPhiziki.FixedRows Then Exit Sub
        If eventArgs.Col <> pFlex_abVw_KalaKalaPhiziki.get_ColIndex("Selected") Then Exit Sub
    End Sub

    Private Sub pFlex_abVw_KalaKalaPhiziki_BeforeEdit(ByVal eventSender As System.Object, _
                                                       ByVal eventArgs As RowColEventArgs) _
        Handles pFlex_abVw_KalaKalaPhiziki.BeforeEdit
        If eventArgs.Row < pFlex_abVw_KalaKalaPhiziki.FixedRows Then eventArgs.Cancel = True : Exit Sub
        If eventArgs.Col <> pFlex_abVw_KalaKalaPhiziki.get_ColIndex("Selected") Then eventArgs.Cancel = True : Exit Sub
    End Sub

    Private Sub SelectByStr(ByRef aStr As String)
        '  مورد استفاده قرار نگرفته است
        ' تيک زدن کالافيزيکي مورد نظر در گريد کالافيزيکي ها 
        Dim i As Short
        Dim J As Short
        Dim vArr() As String

        vArr = Split(aStr, ",")
        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                For J = LBound(vArr) To UBound(vArr)
                    If Trim(vArr(J)) = Trim(.get_TextMatrix(i, .get_ColIndex("KalaPhizikiSN"))) Then
                        .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
                    End If
                Next J
            Next i
        End With

    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Public Sub btnRefreshMeghdar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRefreshMeghdar.Click

        SelectKalaPhizikiAutomatic()

    End Sub

    Private Sub opnVoroodBeAnbar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opnVoroodBeAnbar.CheckedChanged
        'If Not DvKala Is Nothing AndAlso DvKala.Refreshed Then
        '  SelectedopnKalaAnbar = 1
        '  With DvKala
        '    .SQLWhere = " paKala.KalaSN IN ( Select kalaSn  " & _
        '                " From abAnbarKala " & _
        '                " Where  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  "
        '    If FilterNoeAnbarSN <> 0 Then
        '      .SQLWhere = .SQLWhere & " AND NoeAnbarSN = " & CStr(FilterNoeAnbarSN) & " ) "
        '    Else
        '      .SQLWhere = .SQLWhere & " ) "
        '    End If
        '    .SQLOrderBy = " paKala.KalaNO "
        '    .Refresh()
        '    Me.btnSelectAll_KalaSN_click(Me, New System.EventArgs)
        '  End With
        'End If
    End Sub

    Public Sub btnDarjAsan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarjAsan.Click

        Dim IsChecked As Boolean
        Dim I As Short

        If Me.Visible Then
            '//Validation
            If txtMeghdar.Text = "" Then
                MsgBox("مقدار درخواستي مشخص نشده است")
                Exit Sub
            End If
            'If Meghdar > MojoodiNorez Then
            '    MsgBox("با توجه به مقدار رزرو مقدار درخواستی شما از مقدار موجودی بیشتر است" + vbCrLf + "تعداد رزور : " + (Meghdar - MojoodiNorez).ToString("#"))
            '    Exit Sub
            'End If

            If Val(txtMeghdar.Text) = 0 Then
                MsgBox("مقدار درخواستي نادرست است")
                Exit Sub
            End If
            '//Validation

            '//اگر کالا فقط يک کد رهگيري داشته باشد همان يک عدد انتخاب مي شود ولي اگر بيشتر از يکي بود کاربر بايد انتخاب کند
            With pFlex_abVw_KalaKalaPhiziki
                If .Rows - 1 = 1 Then
                    .SetCellCheck(.FixedRows, .get_ColIndex("Selected"), CheckEnum.Checked)
                Else

                    For I = .FixedRows To .Rows - 1
                        If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                            IsChecked = True
                            Exit For
                        End If
                    Next

                    If Not IsChecked Then
                        NetSql.Common.CSystem.MsgBox("کالا فيزيکي انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                        Exit Sub
                    End If

                End If
            End With
            '//

            '//بر اساس رکورهاي انتخابي مقدار درخواستي را تقسيم مي کند
            If Not ManageTedad() Then Exit Sub
            '//
        End If

        DarjeAsan()

    End Sub

    Private Function ManageTedad() As Boolean '//براي تقسيم تعداد دخواست بين رکورد هاي انتخابي در حالت F8

        Dim i As Short = 0
        Dim vMeghdar As Decimal
        vMeghdar = Val(txtMeghdar.Text)

        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                If .GetCellCheck(i, .get_ColIndex("Selected")) = CheckEnum.Checked AndAlso vMeghdar > 0 Then
                    vMeghdar = vMeghdar - Val(CStr(.get_ValueMatrix(i, .get_ColIndex("Mojoodi"))))

                    '''' Edit by Ghafari For AnbarGardani And change VAl With DEC
                    ''''.set_TextMatrix(i, .get_ColIndex("Meghdar"), _
                    ''''                 Val(CStr(.get_ValueMatrix(i, .get_ColIndex("Mojoodi")))) + _
                    ''''                 IIf(vMeghdar < 0, vMeghdar, 0))

                    .set_TextMatrix(i, .get_ColIndex("Meghdar"), _
                 CDec(CStr(.get_ValueMatrix(i, .get_ColIndex("Mojoodi")))) + _
                 IIf(vMeghdar < 0, vMeghdar, 0))

                Else
                    .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
                End If
                'If vMeghdar <= 0 Then Exit For
            Next i
        End With
        ManageTedad = True

        If vMeghdar > 0 Then
            MsgBox( _
                    "مقدار درخواستي شما بيش از تعداد انتخابي مي باشد. به تعداد " & vMeghdar.ToString & _
                    " واحد از درخواست شما باقي ماند.")
            ManageTedad = False
        End If

    End Function

    Private Function SelectKalaPhizikiAutomatic() As Boolean

        If txtMeghdar.Text = "" Then
            MsgBox("مقدار درخواستي مشخص نشده است")
            Exit Function
        End If

        If Val(txtMeghdar.Text) = 0 Then
            MsgBox("مقدار درخواستي نادرست است")
            Exit Function
        End If

        '-------------------------------- comment by yekta 931010 دیتاویو بصورت سورت شده از اس پی دیافت می گردد . در صورت سورت مجدد روال خروج رهگیری به هم می خورد .
        'With DvabVw_KalaKalaPhiziki
        '    If opnVoroodBeAnbar.Checked Then
        '        '  Me.opnVoroodBeAnbar_CheckedChanged(Me, New System.EventArgs)
        '        DV.Sort = "VoroodAnbarDate"
        '        .DataSource = DV

        '    ElseIf opnToolid.Checked Then
        '        '  Me.opnToolid_CheckedChanged(Me, New System.EventArgs)
        '        DV.Sort = "ToolidDate"
        '        .DataSource = DV
        '    ElseIf opnEngheza.Checked Then
        '        '  Me.opnEngheza_CheckedChanged(Me, New System.EventArgs)
        '        DV.Sort = "EnghezaDate"
        '        .DataSource = DV
        '    End If

        '    pFlex_abVw_KalaKalaPhiziki = .FlexGrid
        '    pFlex_abVw_KalaKalaPhiziki.Editable = EditableSettings.flexEDKbdMouse
        '    '''''''''''''''''''''''''''
        '    .FlexGrid.ColDataType(1) = GetType(Boolean)

        '    .Refresh()
        'End With

        Dim i As Short
        Dim vMeghdar As Decimal
        vMeghdar = Val(txtMeghdar.Text)

        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                vMeghdar = vMeghdar - Val(CStr(.get_TextMatrix(i, .get_ColIndex("Mojoodi"))))
                .set_TextMatrix(i, .get_ColIndex("Meghdar"), _
                                 Val(CStr(.get_TextMatrix(i, .get_ColIndex("Mojoodi")))) + _
                                 IIf(vMeghdar < 0, vMeghdar, 0))
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
                If vMeghdar <= 0 Then Exit For
            Next i
        End With

        If vMeghdar > 0 Then
            MsgBox( _
                    "مقدار درخواستي شما بيش از موجودي مي باشد. به تعداد " & vMeghdar.ToString & _
                    " واحد از درخواست شما باقي ماند.")
            Exit Function
        End If

        SelectKalaPhizikiAutomatic = True

    End Function

    Private Function DarjeAsan() As Boolean
        Dim I As Short

        ' انتخاب کليد اوليه کالافيزيکي انتخاب شده توسط کاربر
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        If NetSql.Common.CSystem.MsgBox("آيا کالا فيزيکي هاي انتخاب شده با مقادير مربوطه درج گردند ؟", MsgBoxStyle.Question _
                                                                                     + MsgBoxStyle.YesNo + _
                                                                                     MsgBoxStyle.DefaultButton2 + _
                                                                                     MsgBoxStyle.MsgBoxRtlReading _
                                                                                     + MsgBoxStyle.MsgBoxRight, Me.Text) = _
           MsgBoxResult.Yes Then

            Dim VahedeTejariSN As Decimal, _
                AnbarSN As Decimal, _
                NoeAnbarSN As Decimal, _
                UserID As String, _
                UserID_Name As String, _
                Host_Name As String
            VahedeTejariSN = gVahedeTejariSN
            AnbarSN = gAnbarSN
            NoeAnbarSN = gNoeAnbarSN
            UserID = gSM.UserID
            UserID_Name = gSM.UserID_Name
            Host_Name = System.Environment.MachineName

            Dim DVSanadHa As Data.DataView, DVSanad As Data.DataView
            Dim vErrorMsg As String


            Dim vSanadHaSelected As String
            vSanadHaSelected = ""

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim Ds_Sanad As New Minoo.Applications.Anbar.Common.dsSanad
            Dim aSanadHaRow As Minoo.Applications.Anbar.Common.dsSanad.SanadHaRow
            Dim aSanadRow As Minoo.Applications.Anbar.Common.dsSanad.SanadRow

            'CType(DataGrid1.DataSource, DataTable).Rows(DataGrid1.CurrentCell.RowNumber)
            'currRow(1, DataRowVersion.Current).ToString()

            DVSanad = Ds_Sanad.Sanad.DefaultView
            aSanadRow = Ds_Sanad.Sanad.NewRow()
            aSanadRow("SanadSN") = SanadRow.Item("SanadSn")
            aSanadRow("SanadDate") = SanadRow.Item("SanadDate")
            aSanadRow("MoaserDate") = SanadRow.Item("MoaserDate")
            aSanadRow("AnbarSN") = SanadRow.Item("AnbarSN")
            aSanadRow("ShomarehSefaresh") = SanadRow.Item("ShomarehSefaresh")
            aSanadRow("TafsiliSN") = SanadRow.Item("TafsiliSN")
            aSanadRow("TarakoneshSN") = SanadRow.Item("TarakoneshSN")
            aSanadRow("UserID_Name") = SanadRow.Item("UserID_Name")
            aSanadRow("UserNameSabt") = SanadRow.Item("UserNameSabt")
            aSanadRow("VahedeTejariSN") = SanadRow.Item("VahedeTejariSN")
            aSanadRow("Tozih") = SanadRow.Item("Tozih")
            aSanadRow("NoeAnbarSN") = SanadRow.Item("NoeAnbarSN")
            aSanadRow("Host_Name") = SanadRow.Item("Host_Name")
            aSanadRow("SanadStatus") = SanadRow.Item("SanadStatus")
            aSanadRow("NoeSanadID") = SanadRow.Item("NoeSanadID")
            Ds_Sanad.Sanad.Rows.Add(aSanadRow)
            DVSanad = Ds_Sanad.Sanad.DefaultView

            DVSanadHa = Ds_Sanad.SanadHa.DefaultView

            If DVSanad.Count() > 0 Then
                With pFlex_abVw_KalaKalaPhiziki
                    For I = .FixedRows To .Rows - 1
                        If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                            '850722
                            'vSanadHaSelected = vSanadHaSelected & " , " & Val(.GetCellCheck(I, .get_ColIndex("ShomarehRahgiri")))
                            '851101            vSanadHaSelected = vSanadHaSelected & " , " & .GetCellCheck(I, .get_ColIndex("ShomarehRahgiri"))
                            aSanadHaRow = Ds_Sanad.SanadHa.NewRow()
                            aSanadHaRow.SanadHaSN = I
                            '.GetCellCheck(I, .get_ColIndex("ShomarehRahgiri"))
                            aSanadHaRow.SanadSN = Val(DVSanad(0)("SanadSN").ToString)
                            aSanadHaRow.KalaSN = .get_TextMatrix(I, .get_ColIndex("KalaSN"))
                            aSanadHaRow.KalaPhizikiSN = .get_TextMatrix(I, .get_ColIndex("KalaPhizikiSN"))

                            If EnumTarakoneshSN.RESIDE_48_BARGASHTE_AVALIEH_AZ_PAYEKAR = SanadRow.Item("tarakoneshsn") Then
                                aSanadHaRow.MeghdareVaredeh = .get_TextMatrix(I, .get_ColIndex("Meghdar"))
                                aSanadHaRow.MeghdareSadereh = 0
                            Else
                                aSanadHaRow.MeghdareSadereh = .get_TextMatrix(I, .get_ColIndex("Meghdar"))
                                aSanadHaRow.MeghdareVaredeh = 0
                            End If

                            'MeghdareSadereh --By Izadpanah -860319
                            aSanadHaRow.UserID_Name = UserID_Name
                            aSanadHaRow.Host_Name = Host_Name
                            aSanadHaRow.ShomarehRahgiri = .get_TextMatrix(I, .get_ColIndex("ShomarehRahgiri"))

                            '//براي حالتهايي که نوع مرجوعي يا ضايعات يا معدومي بايد وارد شود
                            aSanadHaRow.NoeMadomiSN = mNoeMadomiSN
                            aSanadHaRow.NoeMarjooeiSN = mNoeMarjooeiSN
                            aSanadHaRow.NoeZayeatSN = mNoeZayeatSN
                            '//براي حالتهايي که نوع مرجوعي يا ضايعات يا معدومي بايد وارد شود
                            aSanadHaRow.DarkhastHaSN = mDarkhstHaSN
                            aSanadHaRow.MojavezErsalHaSN = mMojavezErsalHaSN
                            aSanadHaRow.KalaDS = VinKalano + "." + VinKalaDs
                            aSanadHaRow.KalaPhizikiStatusSN = .get_TextMatrix(I, .get_ColIndex("KalaPhizikiStatusSn"))

                            'row.EndEdit()
                            Ds_Sanad.SanadHa.Rows.Add(aSanadHaRow)
                        End If
                    Next
                End With
                DVSanadHa = Ds_Sanad.SanadHa.DefaultView

                'cn.CallSP("_abSP_DarjSanadHaAsSelectedKalaPhiziki", VahedeTejariSN, AnbarSN, NoeAnbarSN, System.DBNull.Value, UserID_Name, vErrorMsg)
                'If Trim(vErrorMsg) <> "" Then
                '  NetSql.Common.CSystem.MsgBox(vErrorMsg)
                'Else
                '  NetSql.Common.CSystem.MsgBox(" عمليات با موفقيت انجام شد ")
                'End If

                '''''''''''''''''''''''''''''''''''''''''''''''''
                Try
                    vErrorMsg = Minoo.Applications.Anbar.CService.DarjSanadHa(cn _
                                                                               , tp _
                                                                               , VahedeTejariSN _
                                                                               , AnbarSN _
                                                                               , NoeAnbarSN _
                                                                               , gSM.Identifier _
                                                                               , DVSanad _
                                                                               , DVSanadHa _
                                                                               , UserID _
                                                                               , UserID_Name _
                                                                               , 0 _
                                                                               )

                    '          SaveSanadToDataBase = True

                    '//By Izadpanah -860320
                    If vErrorMsg <> "" Then
                        NetSql.Common.CSystem.MsgBox(vErrorMsg, MsgBoxStyle.Critical, Me.Text)
                    End If
                    '//By Izadpanah -860320

                Catch ex As Exception
                    vErrorMsg = vErrorMsg & " DarjSanad : " & ex.Message
                    tp.LogStr(vErrorMsg)
                    'cn.RollbackTrans()
                    '         Return vErrorMsg
                Finally
                    '        cn.StayOpen = vStayOpen
                    '       cn.CommitTrans()
                End Try
                '''''''''''''''''''''''''''''''''''''''''''''''''

                'If Len(vSanadHaSelected) > 0 Then
                '  vSanadHaSelected = Mid(vSanadHaSelected, 4, Len(vSanadHaSelected))
                'End If
                '        mSelected = vSanadHaSelected

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

                mMode = 2
                If Not vErrorMsg = String.Empty Then
                Else
                    Me.Hide()
                End If



            Else
                MsgBox("اطلاعات سند در دسترس نيست")
            End If
        End If
    End Function

    Public Sub DarjeAutomatic()

        If SelectKalaPhizikiAutomatic() Then
            DarjeAsan()
        End If

    End Sub

End Class
