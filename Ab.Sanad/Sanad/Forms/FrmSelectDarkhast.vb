' OK
'Author ::سعید غفاری 
'CreateDate :: 1389/09/09
'ModifiedDate::
'Description::  انتخاب درخواست کالا و نمایش رسید های ثبت شده با درخواست ها

'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports C1.Win.C1FlexGrid

Friend Class FrmSelectDarkhast
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
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkState0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMandeh As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState4 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState2 As System.Windows.Forms.CheckBox
    Public WithEvents BtnOK As System.Windows.Forms.Button
    Public WithEvents btnBITakhsis As System.Windows.Forms.Button
    Public WithEvents btnTakhsis As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBITakhsis = New System.Windows.Forms.Button()
        Me.btnTakhsis = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.CheckMandeh = New System.Windows.Forms.CheckBox()
        Me.ChkState4 = New System.Windows.Forms.CheckBox()
        Me.ChkState3 = New System.Windows.Forms.CheckBox()
        Me.ChkState2 = New System.Windows.Forms.CheckBox()
        Me.ChkState0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnBITakhsis)
        Me.GroupBox1.Controls.Add(Me.btnTakhsis)
        Me.GroupBox1.Controls.Add(Me.btnSelectAll)
        Me.GroupBox1.Controls.Add(Me.btnDeselectAll)
        Me.GroupBox1.Controls.Add(Me.pnlN)
        Me.GroupBox1.Controls.Add(Me.pnlG)
        Me.GroupBox1.Controls.Add(Me.pnlC)
        Me.GroupBox1.Controls.Add(Me.BtnOK)
        Me.GroupBox1.Controls.Add(Me.CheckMandeh)
        Me.GroupBox1.Controls.Add(Me.ChkState4)
        Me.GroupBox1.Controls.Add(Me.ChkState3)
        Me.GroupBox1.Controls.Add(Me.ChkState2)
        Me.GroupBox1.Controls.Add(Me.ChkState0)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(779, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "لیست درخواستهای این کالا"
        '
        'btnBITakhsis
        '
        Me.btnBITakhsis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBITakhsis.BackColor = System.Drawing.SystemColors.Control
        Me.btnBITakhsis.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBITakhsis.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBITakhsis.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBITakhsis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBITakhsis.Location = New System.Drawing.Point(375, 312)
        Me.btnBITakhsis.Name = "btnBITakhsis"
        Me.btnBITakhsis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnBITakhsis.Size = New System.Drawing.Size(97, 37)
        Me.btnBITakhsis.TabIndex = 14
        Me.btnBITakhsis.Tag = ""
        Me.btnBITakhsis.Text = "تخصیص هوشمند"
        Me.btnBITakhsis.UseVisualStyleBackColor = False
        '
        'btnTakhsis
        '
        Me.btnTakhsis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTakhsis.BackColor = System.Drawing.SystemColors.Control
        Me.btnTakhsis.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTakhsis.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTakhsis.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakhsis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTakhsis.Location = New System.Drawing.Point(473, 312)
        Me.btnTakhsis.Name = "btnTakhsis"
        Me.btnTakhsis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTakhsis.Size = New System.Drawing.Size(97, 37)
        Me.btnTakhsis.TabIndex = 7
        Me.btnTakhsis.Tag = ""
        Me.btnTakhsis.Text = "تخصیص انتخابی"
        Me.btnTakhsis.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Location = New System.Drawing.Point(333, 312)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size(41, 37)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Location = New System.Drawing.Point(291, 312)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size(41, 37)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        Me.btnDeselectAll.UseVisualStyleBackColor = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 312)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(210, 36)
        Me.pnlN.TabIndex = 3
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(2, 19)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(773, 289)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(573, 313)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(199, 36)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOK.Location = New System.Drawing.Point(6, 8)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(53, 29)
        Me.BtnOK.TabIndex = 13
        Me.BtnOK.Tag = ""
        Me.BtnOK.Text = "انتخاب"
        Me.BtnOK.UseVisualStyleBackColor = False
        Me.BtnOK.Visible = False
        '
        'CheckMandeh
        '
        Me.CheckMandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckMandeh.AutoSize = True
        Me.CheckMandeh.Checked = True
        Me.CheckMandeh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckMandeh.Location = New System.Drawing.Point(184, 15)
        Me.CheckMandeh.Name = "CheckMandeh"
        Me.CheckMandeh.Size = New System.Drawing.Size(119, 17)
        Me.CheckMandeh.TabIndex = 12
        Me.CheckMandeh.Text = "فقط درخواستهای باز"
        Me.CheckMandeh.UseVisualStyleBackColor = True
        Me.CheckMandeh.Visible = False
        '
        'ChkState4
        '
        Me.ChkState4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState4.AutoSize = True
        Me.ChkState4.Location = New System.Drawing.Point(327, 15)
        Me.ChkState4.Name = "ChkState4"
        Me.ChkState4.Size = New System.Drawing.Size(50, 17)
        Me.ChkState4.TabIndex = 11
        Me.ChkState4.Text = "ابطال"
        Me.ChkState4.UseVisualStyleBackColor = True
        Me.ChkState4.Visible = False
        '
        'ChkState3
        '
        Me.ChkState3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState3.AutoSize = True
        Me.ChkState3.Location = New System.Drawing.Point(406, 16)
        Me.ChkState3.Name = "ChkState3"
        Me.ChkState3.Size = New System.Drawing.Size(56, 17)
        Me.ChkState3.TabIndex = 10
        Me.ChkState3.Text = "تصویب"
        Me.ChkState3.UseVisualStyleBackColor = True
        Me.ChkState3.Visible = False
        '
        'ChkState2
        '
        Me.ChkState2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState2.AutoSize = True
        Me.ChkState2.Location = New System.Drawing.Point(491, 15)
        Me.ChkState2.Name = "ChkState2"
        Me.ChkState2.Size = New System.Drawing.Size(56, 17)
        Me.ChkState2.TabIndex = 9
        Me.ChkState2.Text = "قطعی"
        Me.ChkState2.UseVisualStyleBackColor = True
        Me.ChkState2.Visible = False
        '
        'ChkState0
        '
        Me.ChkState0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState0.AutoSize = True
        Me.ChkState0.Location = New System.Drawing.Point(561, 15)
        Me.ChkState0.Name = "ChkState0"
        Me.ChkState0.Size = New System.Drawing.Size(71, 17)
        Me.ChkState0.TabIndex = 8
        Me.ChkState0.Text = "پیشنویس"
        Me.ChkState0.UseVisualStyleBackColor = True
        Me.ChkState0.Visible = False
        '
        'FrmSelectDarkhast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmSelectDarkhast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب درخواست"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmSelectDarkhast
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSelectDarkhast
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSelectDarkhast
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmSelectDarkhast)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي فيزيکي تعريف شده است
    Private WithEvents DvabDarkhastkala As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFlex_abDarkhastkala As AxVSFlexGrid

    ' کالا فيزيکي انتخاب شده
    Private mSelected As Object
    ' کالاي مورد نظر جهت نمايش کالافيزيکي ها 
    Private mKalaSN, mSanadhaSN As Decimal
    Private mIsF8InTabDarkhast As Boolean  'Add By Yekta 920228
    Private mMeghdar As Decimal
    Private mMoaserDate As String
    Private mKalaDs As String
    Private mSanadRow As DataRow
    Private mMode As Byte
    Private mNoeMadomiSN As Decimal
    Private mNoeMarjooeiSN As Decimal
    Private mNoeZayeatSN As Decimal
    Private mDarkhstHaSN As Decimal
    'Private mdvSanadHa As DataView

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

    Public Property SanadhaSN() As Decimal
        Get
            SanadhaSN = mSanadhaSN
        End Get
        Set(ByVal Value As Decimal)
            mSanadhaSN = Value
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

    Public Property Selected() As Object
        Get
            Selected = mSelected
        End Get
        Set(ByVal Value As Object)
            mSelected = Value
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
    '------------ Add By Yekta 920228
    Public Property IsF8InTabDarkhast() As Decimal
        Get
            IsF8InTabDarkhast = mIsF8InTabDarkhast
        End Get
        Set(ByVal Value As Decimal)
            mIsF8InTabDarkhast = Value
        End Set
    End Property
    '------------ Add By Yekta 920228
    '------------ Add By Yekta 920415
    Private mTarakoneshSN As EnumTarakoneshSN
    Friend Property TarakoneshSN() As EnumTarakoneshSN
        Get
            TarakoneshSN = mTarakoneshSN
        End Get
        Set(ByVal Value As EnumTarakoneshSN)
            mTarakoneshSN = Value
        End Set
    End Property
    '------------ Add By Yekta 920415
#End Region

    Private Sub DvabVw_KalaKalaPhiziki_GetGridProperties() Handles DvabDarkhastkala.GetGridProperties
        With DvabDarkhastkala
            .Refresh()
            With .Fields
                With .Item("selected")
                    .Caption = "انتخاب"
                    .FieldOptions = EnumFieldOptions.foDefault
                    .DataType = "CheckBox"
                End With
                .Item("DarkhastKalaSN").FieldOptions = EnumFieldOptions.foHidden
                .Item("KalaSN").FieldOptions = EnumFieldOptions.foHidden
                With .Item("DarkhastKalaNO")
                    .Caption = "شماره درخواست"
                End With
                With .Item("DarkhastKalaMount")
                    .Caption = "مقدار درخواست"
                    .Format = "#.#"
                End With
                With .Item("MeghdareDaryafti")
                    .Caption = "مقدار رسید شده"
                    .Format = "#.#"
                End With
                With .Item("MAndehDarkhast")
                    .Caption = "مانده درخواست"
                    .Format = "#.#"
                End With
                .Item("NoeDarkhastSN").FieldOptions = EnumFieldOptions.foHidden
                .Item("DarkhastKalaState").FieldOptions = EnumFieldOptions.foHidden

                With .Item("DarkhastKalaDate")
                    .Caption = "تاریخ درخواست"
                End With

                With .Item("AkharinMohlatTahvil")
                    .Caption = "آخرین مهلت تحویل"
                End With
                With .Item("Userid_Name")
                    .Caption = "ثبت کننده درخواست"
                End With
                With .Item("SabtDate")
                    .Caption = "تاریخ ثبت"
                End With
                With .Item("NoeDarkhastDS")
                    .Caption = "نوع درخواست"
                End With
                With .Item("DarkhastKalaStateDS")
                    .Caption = "وضعیت درخواست"
                End With
            End With
        End With
    End Sub

    Private Sub FrmSelectDarkhast_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        If pISLoaded Then
            Exit Sub
        End If
        pISLoaded = True
        mMode = 0
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvabDarkhastkala = New CDataView(cn)
        With DvabDarkhastkala
            ''''''''''''''''''''''''''''
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdExit)

            '.TableName = "abVw_DarkhastHayeTadarokat"
            If (TarakoneshSN = EnumTarakoneshSN.HAVALEH_61_BARGASHT_AZ_KHARIDE_DAKHELI Or TarakoneshSN = EnumTarakoneshSN.HAVALEH_62_BARGASHT_AZ_KHARIDE_KHAREJI) Then
                .DataSource = cn.ExecuteQuery("exec abspG_GetDarkhastHayeTadarokatAll " & KalaSN & "," & SanadhaSN & "")
            Else
                .DataSource = cn.ExecuteQuery("exec abspG_GetDarkhastHayeTadarokat " & KalaSN & "," & SanadhaSN & "")
            End If
            '.DataSource = cn.ExecuteQuery("exec abspG_GetDarkhastHayeTadarokat " & KalaSN & "," & SanadhaSN & "")
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            .Refresh()
            '.SQLWhere = "KalaSN = " & CStr(KalaSN) & "And DarkhastKalaState in (2,3) "
            .SQLWhere = "KalaSN = " & CStr(KalaSN) & " And DarkhastKalaState Not in ( 0,4 ) And ((DarkhastKalaMount-MeghdareDaryafti)<>0) And (IsnUll(AkharinMohlatTahvil,'')='' OR (AkharinMohlatTahvil<= '" & MiladiToShamsi(Today()) & "'))"

            .SQLOrderBy = "kalaSN,DarkhastKalaDate"

            pFlex_abDarkhastkala = .FlexGrid
            pFlex_abDarkhastkala.Editable = EditableSettings.flexEDKbdMouse
            .FlexGrid.ColDataType(1) = GetType(Boolean)

        End With


        '------------ Add By Yekta 920228
        If IsF8InTabDarkhast Then
            btnTakhsis.Visible = True
            btnBITakhsis.Visible = True
            btnDeselectAll.Visible = True
            btnSelectAll.Visible = True

        End If
        '------------ Add By Yekta 920228


        DvabDarkhastkala.Refresh()

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

        'txtMeghdar.Text = IIf(Meghdar = 0, "", Meghdar)
        GroupBox1.Text = "ليست درخواستهای کالای  : " & VinKalano & " - " & VinKalaDs & "  -  " & _
                         VinVahedeSanjeshDs & " - " & "تعداد در کارتن  =  " + CStr(VinTedadAjza)

    End Sub

    Private Sub FrmSelectDarkhast_Closing(ByVal eventSender As System.Object, _
                                          ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub FrmSelectDarkhast_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvabDarkhastkala.Done()
        DvabDarkhastkala = Nothing
    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Public Sub btnDarjAsan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTakhsis.Click

        Dim IsChecked As Boolean
        Dim I As Short
        Dim Meghdarselect As Decimal = 0
        Dim Mandeh As Decimal = 0
        Dim _ArrSel(,) As Decimal
        Dim IsSel As Boolean = False

        With pFlex_abDarkhastkala
            ReDim _ArrSel(.Rows - 1, 1)

            For I = .FixedRows To .Rows - 1
                If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                    IsSel = True
                    Mandeh = Val(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaMount"))) - Val(.get_ValueMatrix(I, .get_ColIndex("MeghdareDaryafti")))
                    If Meghdarselect < Meghdar And Mandeh > 0 Then
                        If Meghdar - Meghdarselect > Mandeh Then
                            Meghdarselect = Meghdarselect + Mandeh
                            _ArrSel(I - 1, 0) = CDec(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaSN")))
                            _ArrSel(I - 1, 1) = Mandeh
                        Else
                            _ArrSel(I - 1, 0) = Val(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaSN")))
                            _ArrSel(I - 1, 1) = Meghdar - Meghdarselect
                            Meghdarselect = Meghdar
                        End If
                    End If
                End If
            Next

        End With

        If Not IsSel Then
            CSystem.MsgBox("هیچ درخواستی انتخاب نشده است", MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        If Meghdar > Meghdarselect Then
            If MsgBox("از مقدار درخواست شده به مقدار زیر کسری وجود دارد آیا مایل به ثبت این مقدار بصورت رسید بدون درخواست می باشید؟" + vbCrLf + CStr(Meghdar - Meghdarselect), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                _ArrSel(I - 1, 0) = 0
                _ArrSel(I - 1, 1) = Meghdar - Meghdarselect
            End If
        End If

        Selected = _ArrSel
        Mode = 1
        Close()

        'If Me.Visible Then
        '    If Val(DvabDarkhastkala.Fields("DarkhastkalaSN").Value) <> 0 Then
        '        If Val(DvabDarkhastkala.Fields("DarkhastkalaMount").Value) - Val(DvabDarkhastkala.Fields("MeghdareDaryafti").Value) < Meghdar Then
        '            MsgBox("مقدار رسید از مقدار مانده درخواست انتخاب شده بیشتر می باشد")
        '            Exit Sub
        '        End If
        '        Selected = DvabDarkhastkala.Fields("DarkhastkalaSN").Value
        '        Mode = 1
        '        Close()
        '    End If
        'End If
    End Sub

    'Using deb As  Global.Anbar.DAL.EntitiesAnbar(cn.SQLServerName, cn.SQLDatabaseName, cn.SQLUserId, cn.SQLPassword)

    'End Using
    'Dim asd As New Global.Anbar.DAL.EntitiesAnbar

    'asd.Connection.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
    'asd.Connection.Open()
    'asd.f_abSanadHa_DeleteX(5552.433)
    'asd.SaveChanges()

    'Dim result As ObjectResult(Of Minoo.Anbar.NerkhGozari.DAL.f_tdSPG_GetFaktorPacket_Result) = db.Context.f_tdSPG_GetFaktorPacket(GhatiFaktorSN, FaktorEbtalstatus)
    'End Using                                                                                                                                                              

    'Dim entity As Object = ctx.CreateObject(Of Department)()
    'Assert.IsInstanceOfType(entity, GetType(IEntityWithChangeTracker), "Department did not get proxied.")

    'aa.f_abSanadHa_InsertX.loadproperty("sanadhasn", gSM.Identifier)

    'aa.f_abSanadHa_InsertX.sanadhasn = gSM.Identifier
    'aa.LoadProperty(f_abSanadHa_InsertX) = gSM.Identifier
    '    sanadSN:=0,
    '    marjaSanadHaSN:=0,
    '    gorooheKalaSN:=0,
    '    kalaSN:=0,
    '    tartib:=0,
    '    meghdareDarkhasti:=0,
    '    meghdareVaredeh:=0,
    '    gheymateVaredeh:=0,
    '    meghdareSadereh:=0,
    '    gheymateSadereh:=0,
    '    meghdareNakhales:=0,
    '    noeZayeatSN:=0,
    '    noeMarjooeiSN:=0,
    '    noeMadomiSN:=0,
    '    eSStatus:=0,
    '    darkhastHaSN:=0,
    '    mojavezErsalHaSN:=0,
    '    workOrederHaSN:=0,
    '    havalehForooshHaSN:=0,
    '    tafsiliSN:=0,
    '    tafsiliSN1:=0,
    '    kalaPhizikiSN:=0,
    '    unqStr:=0,
    '    userID_Name:="",
    '    host_Name:="",
    '    enghezaDate:="",
    '    p_UserParam:="",
    '    recChksum:=0,
    '    toolidDate:="")
    'aa.SaveChanges()

    Private Sub btnBITakhsis_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnBITakhsis.Click
        Dim IsChecked As Boolean
        Dim I As Short
        Dim Meghdarselect As Decimal = 0
        Dim Mandeh As Decimal = 0
        Dim _ArrSel(,) As Decimal

        With pFlex_abDarkhastkala
            ReDim _ArrSel(.Rows - 1, 1)
            For I = .FixedRows To .Rows - 1
                'If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                'Mandeh = Val(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaMount"))) - Val(.get_ValueMatrix(I, .get_ColIndex("MeghdareDaryafti")))
                Mandeh = Val(pFlex_abDarkhastkala.get_ValueMatrix(I, pFlex_abDarkhastkala.get_ColIndex("MAndehDarkhast")))
                If Meghdarselect < Meghdar And Mandeh > 0 Then
                    If Meghdar - Meghdarselect > Mandeh Then
                        Meghdarselect = Meghdarselect + Mandeh
                        _ArrSel(I - 1, 0) = CDec(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaSN")))
                        _ArrSel(I - 1, 1) = Mandeh
                    Else
                        _ArrSel(I - 1, 0) = Val(.get_ValueMatrix(I, .get_ColIndex("DarkhastkalaSN")))
                        _ArrSel(I - 1, 1) = Meghdar - Meghdarselect
                        Meghdarselect = Meghdar
                    End If
                End If
                'End If
            Next

        End With

        If Meghdar > Meghdarselect Then
            If MsgBox("از مقدار درخواست شده به مقدار زیر کسری وجود دارد آیا مایل به ثبت این مقدار بصورت رسید بدون درخواست می باشید؟" + vbCrLf + CStr(Meghdar - Meghdarselect), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                _ArrSel(I - 1, 0) = 0
                _ArrSel(I - 1, 1) = Meghdar - Meghdarselect
            End If
        End If

        Selected = _ArrSel
        Mode = 1
        Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles BtnOK.Click
        Try
            Dim _State As String = ""
            If ChkState0.Checked = False Then _State = _State + "0,"
            If ChkState2.Checked = False Then _State = _State + "2,"
            If ChkState3.Checked = False Then _State = _State + "3,"
            If ChkState4.Checked = False Then _State = _State + "4,"
            If Len(_State) > 0 Then _State = _State.Substring(0, Len(_State) - 1)

            With DvabDarkhastkala
                If Len(_State) > 0 Then
                    If CheckMandeh.Checked = True Then
                        .SQLWhere = "KalaSN = " & CStr(KalaSN) & " And DarkhastKalaState Not in ( " & _State & " ) And ((DarkhastKalaMount-MeghdareDaryafti)<>0)"
                    Else
                        .SQLWhere = "KalaSN = " & CStr(KalaSN) & " And DarkhastKalaState Not in ( " & _State & " )"
                    End If
                Else
                    If CheckMandeh.Checked = True Then
                        .SQLWhere = "KalaSN = " & CStr(KalaSN) & " And ((DarkhastKalaMount-MeghdareDaryafti)<>0)"
                    Else
                        .SQLWhere = "KalaSN = " & CStr(KalaSN)
                    End If
                End If

                .Refresh()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With pFlex_abDarkhastkala
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub btnDeselectAll_Click(sender As System.Object, e As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With pFlex_abDarkhastkala
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

   
End Class
