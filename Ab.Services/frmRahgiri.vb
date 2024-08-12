' OK
'Author ::zohrehizadpanah 
'CreateDate :: 1386/09/27
'ModifiedDate::
'Description::  انتخاب کالاي فيزيکي
'  در ثبت اقلام سند لازم ميشود که کالاي فيزيکي مورد استفاده قرار گيرد 
' بوسيله اين فرم با توجه به کالاي انتخاب شده کليه کالافيزيکي هاي آن براي کاربر به همراه موجودي و ساير اطلاعات ليست ميگردد
' و کاربر ميتواند مورد دلخواه را انتخاب نمايد
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid


Public Class frmRahgiri
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

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
    Friend WithEvents txtMeghdar As System.Windows.Forms.TextBox
    Public WithEvents opnEngheza As System.Windows.Forms.RadioButton
    Public WithEvents opnToolid As System.Windows.Forms.RadioButton
    Public WithEvents opnVoroodBeAnbar As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnRefreshMeghdar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnDarjAsan As System.Windows.Forms.Button
    Public WithEvents btnSelectAll As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll As System.Windows.Forms.Button
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtMeghdar = New System.Windows.Forms.TextBox
        Me.opnEngheza = New System.Windows.Forms.RadioButton
        Me.opnToolid = New System.Windows.Forms.RadioButton
        Me.opnVoroodBeAnbar = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRefreshMeghdar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDarjAsan = New System.Windows.Forms.Button
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.btnDeselectAll = New System.Windows.Forms.Button
        Me.pnlN = New System.Windows.Forms.Panel
        Me.pnlG = New System.Windows.Forms.Panel
        Me.pnlC = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMeghdar
        '
        Me.txtMeghdar.Location = New System.Drawing.Point (503, 44)
        Me.txtMeghdar.Name = "txtMeghdar"
        Me.txtMeghdar.ReadOnly = True
        Me.txtMeghdar.TabIndex = 47
        Me.txtMeghdar.Text = ""
        '
        'opnEngheza
        '
        Me.opnEngheza.Location = New System.Drawing.Point (245, 10)
        Me.opnEngheza.Name = "opnEngheza"
        Me.opnEngheza.TabIndex = 46
        Me.opnEngheza.Text = "تاريخ انقضاء"
        Me.opnEngheza.Visible = False
        '
        'opnToolid
        '
        Me.opnToolid.Location = New System.Drawing.Point (362, 10)
        Me.opnToolid.Name = "opnToolid"
        Me.opnToolid.TabIndex = 45
        Me.opnToolid.Text = "تاريخ توليد"
        Me.opnToolid.Visible = False
        '
        'opnVoroodBeAnbar
        '
        Me.opnVoroodBeAnbar.Checked = True
        Me.opnVoroodBeAnbar.Location = New System.Drawing.Point (479, 10)
        Me.opnVoroodBeAnbar.Name = "opnVoroodBeAnbar"
        Me.opnVoroodBeAnbar.Size = New System.Drawing.Size (126, 24)
        Me.opnVoroodBeAnbar.TabIndex = 44
        Me.opnVoroodBeAnbar.TabStop = True
        Me.opnVoroodBeAnbar.Text = "تاريخ ورود به انبار"
        Me.opnVoroodBeAnbar.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Label1.Location = New System.Drawing.Point (611, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size (165, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "انتخاب کالا فيزيکي بر اساس :"
        Me.Label1.Visible = False
        '
        'btnRefreshMeghdar
        '
        Me.btnRefreshMeghdar.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefreshMeghdar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRefreshMeghdar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefreshMeghdar.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnRefreshMeghdar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefreshMeghdar.Location = New System.Drawing.Point (266, 42)
        Me.btnRefreshMeghdar.Name = "btnRefreshMeghdar"
        Me.btnRefreshMeghdar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRefreshMeghdar.Size = New System.Drawing.Size (201, 24)
        Me.btnRefreshMeghdar.TabIndex = 49
        Me.btnRefreshMeghdar.Text = "انتخاب کالا فيزيکي ها با توجه شرايط"
        Me.btnRefreshMeghdar.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Label2.Location = New System.Drawing.Point (615, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size (161, 23)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "تعداد در خواستي :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add (Me.btnDarjAsan)
        Me.GroupBox1.Controls.Add (Me.btnSelectAll)
        Me.GroupBox1.Controls.Add (Me.btnDeselectAll)
        Me.GroupBox1.Controls.Add (Me.pnlN)
        Me.GroupBox1.Controls.Add (Me.pnlG)
        Me.GroupBox1.Controls.Add (Me.pnlC)
        Me.GroupBox1.Controls.Add (Me.btnSelect)
        Me.GroupBox1.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point (4, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size (773, 276)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ليست موجودي کالا فيزيکي‌هاي کالاي : "
        '
        'btnDarjAsan
        '
        Me.btnDarjAsan.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnDarjAsan.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjAsan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAsan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAsan.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnDarjAsan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAsan.Location = New System.Drawing.Point (432, 243)
        Me.btnDarjAsan.Name = "btnDarjAsan"
        Me.btnDarjAsan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAsan.Size = New System.Drawing.Size (75, 29)
        Me.btnDarjAsan.TabIndex = 7
        Me.btnDarjAsan.Tag = ""
        Me.btnDarjAsan.Text = "درج آسان"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Location = New System.Drawing.Point (386, 243)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size (41, 29)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        Me.btnSelectAll.Visible = False
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Location = New System.Drawing.Point (342, 243)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size (41, 29)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        Me.btnDeselectAll.Visible = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point (4, 243)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size (329, 29)
        Me.pnlN.TabIndex = 3
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                  Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point (2, 18)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size (767, 220)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point (567, 244)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size (195, 29)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point (509, 243)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size (53, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Tag = ""
        Me.btnSelect.Text = "انتخاب"
        Me.btnSelect.Visible = False
        '
        'frmRahgiri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.ClientSize = New System.Drawing.Size (781, 362)
        Me.Controls.Add (Me.opnEngheza)
        Me.Controls.Add (Me.opnToolid)
        Me.Controls.Add (Me.opnVoroodBeAnbar)
        Me.Controls.Add (Me.Label1)
        Me.Controls.Add (Me.btnRefreshMeghdar)
        Me.Controls.Add (Me.Label2)
        Me.Controls.Add (Me.GroupBox1)
        Me.Controls.Add (Me.txtMeghdar)
        Me.Font = New System.Drawing.Font ("Tahoma", 9.75!)
        Me.Name = "frmRahgiri"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "انتخاب کد رهگيري"
        Me.GroupBox1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region


#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmRahgiri
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmRahgiri
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmRahgiri
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As frmRahgiri)
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
    Private mMoaserDate As String
    Private mKalaDs As String
    Private mMode As Byte
    Private mAnbarSN As Decimal
    Private mNoeAnbarSN As Decimal
    Private mHesabdariSalFDate As String
    Private mHesabdariSalTDate As String

    Private DV As DataView

#End Region

#Region "PropertyDefinition"

    Public Property KalaSN() As Decimal
        Get
            KalaSN = mKalaSN
        End Get
        Set (ByVal Value As Decimal)
            mKalaSN = Value
        End Set
    End Property

    Public Property Meghdar() As Decimal
        Get
            Meghdar = mMeghdar
        End Get
        Set (ByVal Value As Decimal)
            mMeghdar = Value
        End Set
    End Property

    Public Property MoaserDate() As String
        Get
            MoaserDate = mMoaserDate
        End Get
        Set (ByVal Value As String)
            mMoaserDate = Value
        End Set
    End Property

    Public Property Selected() As String
        Get
            Selected = mSelected
        End Get
        Set (ByVal Value As String)
            mSelected = Value
            SelectByStr (mSelected)
        End Set
    End Property

    Public Property Mode() As Byte
        Get
            Mode = mMode
        End Get
        Set (ByVal Value As Byte)
            mMode = Value
        End Set
    End Property

    Public Property AnbarSN() As Decimal
        Get
            AnbarSN = mAnbarSN
        End Get
        Set (ByVal Value As Decimal)
            mAnbarSN = Value
        End Set
    End Property

    Public Property NoeAnbarSN() As Decimal
        Get
            NoeAnbarSN = mNoeAnbarSN
        End Get
        Set (ByVal Value As Decimal)
            mNoeAnbarSN = Value
        End Set
    End Property

    Public Property HesabdariSalFDate() As String
        Get
            HesabdariSalFDate = mHesabdariSalFDate
        End Get
        Set (ByVal Value As String)
            mHesabdariSalFDate = Value
        End Set
    End Property

    Public Property HesabdariSalTDate() As String
        Get
            HesabdariSalTDate = mHesabdariSalTDate
        End Get
        Set (ByVal Value As String)
            mHesabdariSalTDate = Value
        End Set
    End Property

    Public SelectedTable As DataTable

#End Region

    Private Sub btnDeselectAll_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
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
            .AccessRight = CConnection.EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
            ' سلکت  گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد

            DV = _
                cn.ExecuteQuery( _
                                 "_abSPG_SelectRahgiri  " + CStr(gVahedeTejariSN) + "," + CStr(mAnbarSN) + "," + _
                                 CStr(mNoeAnbarSN) + "," + CStr(KalaSN) + "," + mHesabdariSalFDate + "," + _
                                 mHesabdariSalTDate)

            .DataSource = DV

            pFlex_abVw_KalaKalaPhiziki = .FlexGrid
            pFlex_abVw_KalaKalaPhiziki.Editable = EditableSettings.flexEDKbdMouse
            '''''''''''''''''''''''''''
            .FlexGrid.ColDataType(1) = GetType(Boolean)

        End With

        DvabVw_KalaKalaPhiziki.Refresh()

        Dim vKalaSN As Object
        Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
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
        GroupBox1.Text = "ليست موجودي کالا فيزيکي هاي کالاي : " & VinKalano & " - " & VinKalaDs & " - " & _
                         VinVahedeSanjeshDs

        SelectedTable = New DataTable
        SelectedTable.Columns.Add("KalaPhizikiSN")
        SelectedTable.Columns.Add("Meghdar")

    End Sub

    Private Sub FrmSelectRahgiri_Closing(ByVal eventSender As System.Object, _
                                          ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
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
        If eventArgs.row < pFlex_abVw_KalaKalaPhiziki.FixedRows Then Exit Sub
        If eventArgs.col <> pFlex_abVw_KalaKalaPhiziki.get_ColIndex("Selected") Then Exit Sub
    End Sub

    Private Sub pFlex_abVw_KalaKalaPhiziki_BeforeEdit(ByVal eventSender As System.Object, _
                                                       ByVal eventArgs As RowColEventArgs) _
        Handles pFlex_abVw_KalaKalaPhiziki.BeforeEdit
        If eventArgs.row < pFlex_abVw_KalaKalaPhiziki.FixedRows Then eventArgs.cancel = True : Exit Sub
        If eventArgs.col <> pFlex_abVw_KalaKalaPhiziki.get_ColIndex("Selected") Then eventArgs.cancel = True : Exit Sub
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

        Dim i As Short
        Dim vMeghdar As Decimal
        vMeghdar = Val(txtMeghdar.Text)

        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                If .GetCellCheck(i, .get_ColIndex("Selected")) = CheckEnum.Checked AndAlso vMeghdar > 0 Then
                    vMeghdar = vMeghdar - Val(CStr(.get_TextMatrix(i, .get_ColIndex("Mojoodi"))))
                    .set_TextMatrix(i, .get_ColIndex("Meghdar"), _
                                     Val(CStr(.get_TextMatrix(i, .get_ColIndex("Mojoodi")))) + _
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

        With DvabVw_KalaKalaPhiziki
            If opnVoroodBeAnbar.Checked Then
                '  Me.opnVoroodBeAnbar_CheckedChanged(Me, New System.EventArgs)
                DV.Sort = "VoroodAnbarDate"
                .DataSource = DV

            ElseIf opnToolid.Checked Then
                '  Me.opnToolid_CheckedChanged(Me, New System.EventArgs)
                DV.Sort = "ToolidDate"
                .DataSource = DV
            ElseIf opnEngheza.Checked Then
                '  Me.opnEngheza_CheckedChanged(Me, New System.EventArgs)
                DV.Sort = "EnghezaDate"
                .DataSource = DV
            End If

            pFlex_abVw_KalaKalaPhiziki = .FlexGrid
            pFlex_abVw_KalaKalaPhiziki.Editable = EditableSettings.flexEDKbdMouse
            '''''''''''''''''''''''''''
            .FlexGrid.ColDataType(1) = GetType(Boolean)

            .Refresh()
        End With

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
        Dim dr As DataRow
        ' انتخاب کليد اوليه کالافيزيکي انتخاب شده توسط کاربر
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        If NetSql.Common.CSystem.MsgBox("آيا کالا فيزيکي هاي انتخاب شده با مقادير مربوطه درج گردند ؟", MsgBoxStyle.Question _
                                                                                     + MsgBoxStyle.YesNo + _
                                                                                     MsgBoxStyle.DefaultButton2 + _
                                                                                     MsgBoxStyle.MsgBoxRtlReading _
                                                                                     + MsgBoxStyle.MsgBoxRight, Me.Text) = _
           MsgBoxResult.Yes Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


            With pFlex_abVw_KalaKalaPhiziki
                For I = .FixedRows To .Rows - 1
                    If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                        dr = SelectedTable.NewRow
                        dr.Item(0) = .get_TextMatrix(I, .get_ColIndex("KalaPhizikiSN"))
                        dr.Item(1) = .get_TextMatrix(I, .get_ColIndex("Meghdar"))
                        SelectedTable.Rows.Add(dr)
                        dr = Nothing
                    End If
                Next
            End With

            Try

            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox(ex.Message)
            Finally

            End Try


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            mMode = 2
            Me.Hide()

        Else
            MsgBox("اطلاعات سند در دسترس نيست")
        End If

    End Function

    Public Sub DarjeAutomatic()

        If SelectKalaPhizikiAutomatic() Then
            DarjeAsan()
        End If

    End Sub
End Class
