Option Strict Off
Option Explicit On

' OK
'Author ::سعید غفاری 
'CreateDate :: 1390/09/27
'ModifiedDate::
'Description:: ثبت سند انبار از طریق فایل اکسل
'System ::انبار

Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports Anbar.BRL

Friend Class FrmImportFromExcel
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
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
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents dbcAnbarSN As NetSql.Components.DataCombo
    Public WithEvents dbcTarakoneshSN As NetSql.Components.DataCombo
    Public WithEvents dbcTarafHesabSN As NetSql.Components.DataCombo
    Public WithEvents lblTarafHesabSN As System.Windows.Forms.Label
    Public WithEvents lblAnbarSN As System.Windows.Forms.Label
    Public WithEvents lblTarakoneshSN As System.Windows.Forms.Label
    Friend WithEvents btnExcelFormat As System.Windows.Forms.Button
    Friend WithEvents btnExcelImport As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtShomarehSefaresh As System.Windows.Forms.TextBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dbcAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTarakoneshSN = New NetSql.Components.DataCombo(Me.components)
        Me.dbcTarafHesabSN = New NetSql.Components.DataCombo(Me.components)
        Me.lblTarafHesabSN = New System.Windows.Forms.Label()
        Me.lblAnbarSN = New System.Windows.Forms.Label()
        Me.lblTarakoneshSN = New System.Windows.Forms.Label()
        Me.btnExcelFormat = New System.Windows.Forms.Button()
        Me.btnExcelImport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtShomarehSefaresh = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GridEX1)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(931, 371)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اقلام سند"
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.Location = New System.Drawing.Point(10, 19)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(910, 315)
        Me.GridEX1.TabIndex = 5
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(371, 340)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(170, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Tag = ""
        Me.btnSelect.Text = "ثبت سند در انبار"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'dbcAnbarSN
        '
        Me.dbcAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcAnbarSN.AutoSelectFirst = False
        Me.dbcAnbarSN.BackColor = System.Drawing.Color.White
        Me.dbcAnbarSN.BoundText = Nothing
        Me.dbcAnbarSN.BypassChangeEvent = False
        Me.dbcAnbarSN.DisplayText = ""
        Me.dbcAnbarSN.Enabled = False
        Me.dbcAnbarSN.LateBindingTop = "100"
        Me.dbcAnbarSN.Location = New System.Drawing.Point(405, 42)
        Me.dbcAnbarSN.MemFilter = ""
        Me.dbcAnbarSN.Name = "dbcAnbarSN"
        Me.dbcAnbarSN.SeparatedData = Nothing
        Me.dbcAnbarSN.Size = New System.Drawing.Size(95, 24)
        Me.dbcAnbarSN.Source = Nothing
        Me.dbcAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcAnbarSN.TabIndex = 15
        '
        'dbcTarakoneshSN
        '
        Me.dbcTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTarakoneshSN.AutoSelectFirst = False
        Me.dbcTarakoneshSN.BackColor = System.Drawing.Color.White
        Me.dbcTarakoneshSN.BoundText = Nothing
        Me.dbcTarakoneshSN.BypassChangeEvent = False
        Me.dbcTarakoneshSN.DisplayText = ""
        Me.dbcTarakoneshSN.LateBindingTop = "100"
        Me.dbcTarakoneshSN.Location = New System.Drawing.Point(580, 5)
        Me.dbcTarakoneshSN.MemFilter = ""
        Me.dbcTarakoneshSN.Name = "dbcTarakoneshSN"
        Me.dbcTarakoneshSN.SeparatedData = Nothing
        Me.dbcTarakoneshSN.Size = New System.Drawing.Size(276, 24)
        Me.dbcTarakoneshSN.Source = Nothing
        Me.dbcTarakoneshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarakoneshSN.TabIndex = 14
        '
        'dbcTarafHesabSN
        '
        Me.dbcTarafHesabSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcTarafHesabSN.AutoSelectFirst = False
        Me.dbcTarafHesabSN.BackColor = System.Drawing.Color.White
        Me.dbcTarafHesabSN.BoundText = Nothing
        Me.dbcTarafHesabSN.BypassChangeEvent = False
        Me.dbcTarafHesabSN.DisplayText = ""
        Me.dbcTarafHesabSN.LateBindingTop = "100"
        Me.dbcTarafHesabSN.Location = New System.Drawing.Point(12, 8)
        Me.dbcTarafHesabSN.MemFilter = ""
        Me.dbcTarafHesabSN.Name = "dbcTarafHesabSN"
        Me.dbcTarafHesabSN.SeparatedData = Nothing
        Me.dbcTarafHesabSN.Size = New System.Drawing.Size(488, 24)
        Me.dbcTarafHesabSN.Source = Nothing
        Me.dbcTarafHesabSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarafHesabSN.TabIndex = 16
        '
        'lblTarafHesabSN
        '
        Me.lblTarafHesabSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarafHesabSN.AutoSize = True
        Me.lblTarafHesabSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarafHesabSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarafHesabSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarafHesabSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarafHesabSN.Location = New System.Drawing.Point(506, 13)
        Me.lblTarafHesabSN.Name = "lblTarafHesabSN"
        Me.lblTarafHesabSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarafHesabSN.Size = New System.Drawing.Size(67, 13)
        Me.lblTarafHesabSN.TabIndex = 19
        Me.lblTarafHesabSN.Text = "طرف حساب:"
        Me.lblTarafHesabSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAnbarSN
        '
        Me.lblAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnbarSN.AutoSize = True
        Me.lblAnbarSN.BackColor = System.Drawing.Color.Transparent
        Me.lblAnbarSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnbarSN.Enabled = False
        Me.lblAnbarSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnbarSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAnbarSN.Location = New System.Drawing.Point(506, 47)
        Me.lblAnbarSN.Name = "lblAnbarSN"
        Me.lblAnbarSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAnbarSN.Size = New System.Drawing.Size(28, 13)
        Me.lblAnbarSN.TabIndex = 18
        Me.lblAnbarSN.Text = "انبار:"
        Me.lblAnbarSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTarakoneshSN
        '
        Me.lblTarakoneshSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTarakoneshSN.AutoSize = True
        Me.lblTarakoneshSN.BackColor = System.Drawing.Color.Transparent
        Me.lblTarakoneshSN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTarakoneshSN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarakoneshSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTarakoneshSN.Location = New System.Drawing.Point(863, 10)
        Me.lblTarakoneshSN.Name = "lblTarakoneshSN"
        Me.lblTarakoneshSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTarakoneshSN.Size = New System.Drawing.Size(45, 13)
        Me.lblTarakoneshSN.TabIndex = 17
        Me.lblTarakoneshSN.Text = "تراكنش:"
        Me.lblTarakoneshSN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnExcelFormat
        '
        Me.btnExcelFormat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcelFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcelFormat.Location = New System.Drawing.Point(12, 38)
        Me.btnExcelFormat.Name = "btnExcelFormat"
        Me.btnExcelFormat.Size = New System.Drawing.Size(93, 32)
        Me.btnExcelFormat.TabIndex = 21
        Me.btnExcelFormat.Text = "فرمت  اكسل"
        '
        'btnExcelImport
        '
        Me.btnExcelImport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcelImport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcelImport.Location = New System.Drawing.Point(111, 38)
        Me.btnExcelImport.Name = "btnExcelImport"
        Me.btnExcelImport.Size = New System.Drawing.Size(93, 32)
        Me.btnExcelImport.TabIndex = 20
        Me.btnExcelImport.Text = "دریافت از اکسل"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(863, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "شماره ارجاع:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtShomarehSefaresh
        '
        Me.TxtShomarehSefaresh.Location = New System.Drawing.Point(691, 35)
        Me.TxtShomarehSefaresh.Name = "TxtShomarehSefaresh"
        Me.TxtShomarehSefaresh.Size = New System.Drawing.Size(165, 23)
        Me.TxtShomarehSefaresh.TabIndex = 23
        '
        'FrmImportFromExcel
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(937, 450)
        Me.Controls.Add(Me.TxtShomarehSefaresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExcelFormat)
        Me.Controls.Add(Me.btnExcelImport)
        Me.Controls.Add(Me.lblTarafHesabSN)
        Me.Controls.Add(Me.lblAnbarSN)
        Me.Controls.Add(Me.lblTarakoneshSN)
        Me.Controls.Add(Me.dbcAnbarSN)
        Me.Controls.Add(Me.dbcTarakoneshSN)
        Me.Controls.Add(Me.dbcTarafHesabSN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmImportFromExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دریافت سند انبار از طریق فایل اکسل"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmImportFromExcel
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmImportFromExcel
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmImportFromExcel
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmImportFromExcel)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"



#End Region

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Private Sub FrmImportFromExcel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim _strT As String = "Select TarakoneshDS,TarakoneshSN from abTarakonesh " & _
                               " Where TarakoneshSN IN ( " & _
                               " SELECT TarakoneshSN FROM abAnbarTarakonesh  " & _
                               " where AnbarSn=" & gAnbarSN & " And AnbarTarakoneshStatus=1  AND ISNULL(RezDB,0) = 1)  " & _
                               " AND abTarakonesh.TarakoneshStatus = 1"

        With dbcAnbarSN
            .Bind(cn, "Select ANbarDS ,AnbarSN from abAnbar where AnbarSN=" & gAnbarSN, "AnbarSN", "AnbarDS")
            .BoundText = gAnbarSN
        End With

        With dbcTarakoneshSN
            .Bind(cn, _strT, "TarakoneshSN", "TarakoneshDS")
            .BoundText = ""
        End With

    End Sub

    Private Sub dbcTarafHesabSN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dbcTarafHesabSN.Enter
        '  با توجه به تراکنش انتخاب شده سند حال با توجه به ارتباط تراکنش انبار و گروه هاي تفصيلي مالي تفصيلي هاي مرتبط نمايش داده ميگردد
        Dim vTarakoneshSN As Decimal
        Dim vNoeAnbarSN As Decimal, vTafsiliSN As Decimal
        Dim VComboWhereB, _StrTH As String
        Dim TarakoneshSN As Integer = CInt(dbcTarakoneshSN.BoundText)
        Dim vGetTaraKoneshGoroohTafsiliSN As String

        VComboWhereB = ""
        _StrTH = "Select TafsiliSn, TafsiliDS from matafsili Where "
        ' با توجه به تراکنش سند رکورد جاري
        ' Property -> TarakoneshSN
        Select Case TarakoneshSN
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

                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " & _
                  " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " & _
                  " AND (abAnbar.IsTajmie = 3) " & _
                  " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.RESIDE_05_ENTEGHAL_AZ_ANBAR_BE_ANBAR _
               , EnumTarakoneshSN.HAVALEH_65_ENTEGHAL_AZ_ANBAR_BE_ANBAR

                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " & _
                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " & _
                   " AND (abAnbar.IsTajmie = 2) " & _
                   " AND abAnbar.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.HAVALEH_70_ENTEGHAL_AZ_ANBAR_BE_ANBAR_BEINEVAHEDHA
                'EnumTarakoneshSN.RESIDE_26_RESID_DARYAFT_MAVAD_KARMOZDHALAB _
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar " & _
                   " Where ( ISNULL(abAnbar.AnbarStatus,0) = 1 ) " & _
                   " AND (abAnbar.IsTajmie = 2) " & _
                 " AND abAnbar.VahedeTejariSN  IN (3.935,4.935,7.935))) "

            Case EnumTarakoneshSN.HAVALEH_81_ZAYEAT
                VComboWhereB = " AND ( maTafsili.TafsiliSN IN ( SELECT PayeSN FROM abAnbar T1 INNER JOIN abAnbarTarakonesh T2 ON T1.AnbarSN = T2.AnbarSN " & _
                   " Where ( ISNULL(T1.AnbarStatus,0) = 1 ) " & _
                   " AND (T1.IsTajmie <> 1) AND T2.NoeAnbarSN = 5 " & _
                   " AND T1.VahedeTejariSN  = " & CStr(gVahedeTejariSN) & " )) "
            Case EnumTarakoneshSN.RESIDE_11_HAMLE_MOSTAGHIM
                VComboWhereB = " And (TafsiliSN not in (  " & _
                               " Select TafsiliSN from matafsili where VahedeTejariSN in (select VahedeTejariSN from paVahedeTejari where OzveGorooh=1))  " & _
                               " OR " & CStr(gVahedeTejariSN) & " Not in (Select VahedeTejariSN from paVahedeTejari where PedarVahedeTejariSN=9.935 ))"
        End Select

        If Val(dbcTarafHesabSN.BoundText) = 0 Then

            If Trim(dbcTarakoneshSN.BoundText) <> "" Then
                vTarakoneshSN = Val(dbcTarakoneshSN.BoundText)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN = CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, gNoeAnbarSN, "maTafsili")
                _StrTH += vGetTaraKoneshGoroohTafsiliSN + VComboWhereB
            Else
                _StrTH += " 1 = 2 "
            End If
            'DVabSanad.Fields("TafsiliSN").RefreshCombo()
        Else ' If Val(DVabSanad.Fields("TafsiliSN").Value) = 0 Then 
            vTafsiliSN = Val(dbcTarafHesabSN.BoundText)
            If Trim(dbcTarakoneshSN.BoundText) <> "" Then
                vTarakoneshSN = Val(dbcTarakoneshSN.BoundText)
                ' بدست آوردن شرط کامبو با توجه به تراکنش سند انبار
                vGetTaraKoneshGoroohTafsiliSN = CSanad.GetTaraKoneshGoroohTafsiliSN(vTarakoneshSN, gNoeAnbarSN, "maTafsili")
                _StrTH += vGetTaraKoneshGoroohTafsiliSN + VComboWhereB
            Else
                _StrTH += " 1 = 2 "
            End If
            'DVabSanad.Fields("TafsiliSN").RefreshCombo()
            'DVabSanad.Fields("TafsiliSN").Value = vTafsiliSN
        End If ' If Val(DVabSanad.Fields("TafsiliSN").Value) = 0 Then
        With dbcTarafHesabSN
            .Bind(cn, _StrTH, "TafsiliSN", "TAfsiliDS")
        End With
    End Sub

    Private Sub btnExcelImport_Click(sender As System.Object, e As System.EventArgs) Handles btnExcelImport.Click
        Dim DS As System.Data.DataSet
        'Dim MyAdapter As System.Data.OleDb.OleDbDataAdapter
        'Dim cmd As System.Data.OleDb.OleDbCommand
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        Dim fdl As New OpenFileDialog

        'If MsgBox("در صورت بازخواني فايل اكسل ، مقادير خوانده شده جايگزين مقادير فعلي مي شوند. ادامه مي دهيد ؟ ", MsgBoxStyle.YesNo, "احتياط") = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        fdl.Filter = "(*.xls)|*.xls"
        fdl.Multiselect = False
        fdl.ShowDialog()
        Try
            Dim Address As String = fdl.FileName()
            Dim name As String = Address.Replace(".xls", "")
            name = "[" + name.Substring(name.LastIndexOf("\") + 1) + "$]"
            Try
                MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; " & _
                "data source=" & Address & ";Extended Properties=Excel 8.0;")

                MyConnection.Open()

                'MyCommand = New System.Data.OleDb.OleDbDataAdapter("Select * from " & name, MyConnection)
                MyCommand = New System.Data.OleDb.OleDbDataAdapter("Select * from [Sheet1$]", MyConnection)

                MyCommand.TableMappings.Add("Table", "Table1")
                DS = New System.Data.DataSet
                MyCommand.Fill(DS)

                MyConnection.Close()
            Catch ex As Exception
                Netsql.common.csystem.MsgBox(": فايل اکسل قابل بازخواني نمي باشد لطفا موارد زير را بررسي نمائيد" + vbCrLf + _
                          "مطمئن شويد نام شيت فايل مورد نظر " + "[Sheet1]" + " باشد " + vbCrLf + _
                          "مطمئن شويد فايل اکسل خارج از برنامه باز مي شود" + vbCrLf + _
                          "در صورت عدم رفع مشکل فايل اکسل را باز نموده و با نام ديگري ذخيره نمائيد")
                Exit Sub
            End Try


            FillTableFromGrid(DS)

        Catch ex As Exception

            CSystem.MsgBox(ex.Message)
            MsgBox("مشكل در بازخواني فايل اكسل", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub FillTableFromGrid(ByVal Ds As System.Data.DataSet)
        Try
            If Ds.Tables("Table1").Rows.Count <> 0 Then

                Dim _Col1 As New System.Data.DataColumn
                _Col1.ColumnName = "VahedeSanjesh"
                Ds.Tables("Table1").Columns.Add(_Col1)

                Dim _Col2 As New System.Data.DataColumn
                _Col2.ColumnName = "Karton"
                Ds.Tables("Table1").Columns.Add(_Col2)

                Dim _Col3 As New System.Data.DataColumn
                _Col3.ColumnName = "Adad"
                Ds.Tables("Table1").Columns.Add(_Col3)

            End If

            ''''''Dim i As Integer

            ''''''For i = 0 To Ds.Tables(0).Rows.Count - 1
            ''''''    Dim myrow As DataRow
            ''''''    Dim _kalaSN As Decimal = 0
            ''''''    Dim _kalaNO As String = ""
            ''''''    myrow = Ds.Tables(0).Rows(i)

            ''''''    _kalaNO = CType(Ds.Tables(0).Rows(i).Item("KalaNO"), String)
            ''''''    'Dim dv As DataView = GetVahedeSanjeshKala(_kalaSN)
            ''''''    myrow.BeginEdit()
            ''''''    myrow.EndEdit()
            ''''''Next

            With GridEX1
                .DataSource = Ds.Tables("Table1")
                .RetrieveStructure()
                .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
                .AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.False
                .ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .GroupByBoxVisible = False
                .RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
                .ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic
                .ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.Row
                .FilterMode = Janus.Windows.GridEX.FilterMode.None
                .AcceptsEscape = True
                .AllowColumnDrag = True
                .AutoEdit = False
                .RightToLeft = RightToLeft.Yes
                .RecordNavigator = True
                .SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
                .AutoSizeColumns()
                With .RootTable.Columns
                    With .Item("KalaNO")
                        .Caption = "کد کالا"
                        .Width = 200
                    End With
                    With .Item("KalaDS")
                        .Caption = "شرح کالا"
                        .AllowSort = True
                        .Width = 100
                        .RightToLeft = RightToLeft.No
                        '.RightToLeft = RightToLeft.Yes
                    End With
                    With .Item("VahedeSanjesh")
                        .Caption = "واحد سنجش"
                        .Width = 200
                    End With
                    With .Item("Rahgiri")
                        .Caption = "رهگیری کالا"
                        .Width = 200
                    End With
                    With .Item("Tedad")
                        .Caption = "تعداد کالا"
                        .Width = 200
                    End With
                    With .Item("Karton")
                        .Caption = "کارتن"
                        .Width = 200
                    End With
                    With .Item("Adad")
                        .Caption = "عدد"
                        .Width = 200
                    End With
                    With .Item("EnghezaDate")
                        .Caption = "تاریخ انقضاء"
                        .Width = 200
                    End With
                    With .Item("ToolidDate")
                        .Caption = "تاریخ تولید"
                        .Width = 200
                    End With
                    '.Item("TarakoneShSN").Visible = False
                    '.Item("TafsiliSN").Visible = False
                    '.Item("ShomarehSefareSh").Visible = False
                End With
                .RightToLeft = RightToLeft.Yes
                .AutoSizeColumns()
            End With

        Catch ex As Exception
            CSystem.MsgBox(ex.Message, MsgBoxStyle.OkOnly, "پيغام")
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Try
            Dim _ClsDataAccessRule As New ClsDataAccessRule

            Dim dt As DataTable = CType(GridEX1.DataSource, DataTable)
            dt.AcceptChanges()

            Dim TarakoneshSN As Integer = CInt(dbcTarakoneshSN.BoundText)
            Dim TarafHesabSN As Decimal = CDec(dbcTarafHesabSN.BoundText)

            If dt.Rows.Count = 0 Then
                CSystem.MsgBox("رکوردی جهت ثبت در گرید مشاهده نمی شود")
                Exit Sub
            End If
            If gVahedeTejariSN = 0 Then
                CSystem.MsgBox("واحد تجاری مشخص نشده است")
                Exit Sub
            End If
            If gAnbarSN = 0 Then
                CSystem.MsgBox("انبار مشخص نشده است")
                Exit Sub
            End If
            If TarakoneshSN <= 0 Then
                CSystem.MsgBox("تراکنش سند مشخص نشده است")
                Exit Sub
            End If
            'If TarafHesabSN <= 0 Then
            '    CSystem.MsgBox("طرف حساب سند مشخص نشده است")
            '    Exit Sub
            'End If

            _ClsDataAccessRule.ImportFromExcel(dt, gVahedeTejariSN, gAnbarSN, TarakoneshSN, TarafHesabSN, TxtShomarehSefaresh.Text, System.Environment.MachineName, gSM.UserID_Name, cn, tp)

        Catch ex As Exception
            CSystem.MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class
