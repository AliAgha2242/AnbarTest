' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/03/07
'ModifiedDate::
'Description::  رزرو كالا
' در صورت نياز براي رزرو کالا در انبار از اين فرم استفاده ميگردد
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid


Friend Class frmAnbarKalaRezerv
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
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents sstChild As Minoo.Controls.FTTabControl
    Public WithEvents _sstChild_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents pnlNavigationDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRezerv As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNoRezerv As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents lblFromDate As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.sstChild = New Minoo.Controls.FTTabControl()
        Me._sstChild_TabPage0 = New System.Windows.Forms.TabPage()
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel()
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel()
        Me.pnlGridDet1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbRezerv = New System.Windows.Forms.RadioButton()
        Me.rdbNoRezerv = New System.Windows.Forms.RadioButton()
        Me.rdbAll = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.txtMinDate = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sstChild.SuspendLayout()
        Me._sstChild_TabPage0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(3, 3)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(975, 141)
        Me.pnlGridMaster.TabIndex = 40
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
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(4, 146)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(460, 33)
        Me.pnlNavigationMaster.TabIndex = 39
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(468, 146)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(500, 33)
        Me.pnlCommandMaster.TabIndex = 38
        '
        'sstChild
        '
        Me.sstChild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstChild.Controls.Add(Me._sstChild_TabPage0)
        Me.sstChild.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstChild.ItemSize = New System.Drawing.Size(42, 18)
        Me.sstChild.Location = New System.Drawing.Point(3, 228)
        Me.sstChild.Name = "sstChild"
        Me.sstChild.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sstChild.SelectedIndex = 0
        Me.sstChild.Size = New System.Drawing.Size(979, 350)
        Me.sstChild.TabIndex = 42
        Me.sstChild.TabStop = False
        '
        '_sstChild_TabPage0
        '
        Me._sstChild_TabPage0.Controls.Add(Me.pnlNavigationDet1)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlCommandDet1)
        Me._sstChild_TabPage0.Controls.Add(Me.pnlGridDet1)
        Me._sstChild_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._sstChild_TabPage0.Name = "_sstChild_TabPage0"
        Me._sstChild_TabPage0.Size = New System.Drawing.Size(971, 324)
        Me._sstChild_TabPage0.TabIndex = 0
        Me._sstChild_TabPage0.Text = "رزرو کالا"
        '
        'pnlNavigationDet1
        '
        Me.pnlNavigationDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet1.Location = New System.Drawing.Point(4, 289)
        Me.pnlNavigationDet1.Name = "pnlNavigationDet1"
        Me.pnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet1.Size = New System.Drawing.Size(460, 33)
        Me.pnlNavigationDet1.TabIndex = 8
        '
        'pnlCommandDet1
        '
        Me.pnlCommandDet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet1.Location = New System.Drawing.Point(468, 289)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size(500, 33)
        Me.pnlCommandDet1.TabIndex = 9
        '
        'pnlGridDet1
        '
        Me.pnlGridDet1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet1.Location = New System.Drawing.Point(4, 22)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size(969, 266)
        Me.pnlGridDet1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rdbRezerv)
        Me.GroupBox1.Controls.Add(Me.rdbNoRezerv)
        Me.GroupBox1.Controls.Add(Me.rdbAll)
        Me.GroupBox1.Location = New System.Drawing.Point(685, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(293, 39)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "وضعيت رزرو کالا"
        '
        'rdbRezerv
        '
        Me.rdbRezerv.Checked = True
        Me.rdbRezerv.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.rdbRezerv.Location = New System.Drawing.Point(25, 16)
        Me.rdbRezerv.Name = "rdbRezerv"
        Me.rdbRezerv.Size = New System.Drawing.Size(76, 18)
        Me.rdbRezerv.TabIndex = 2
        Me.rdbRezerv.TabStop = True
        Me.rdbRezerv.Text = "رزرو"
        '
        'rdbNoRezerv
        '
        Me.rdbNoRezerv.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.rdbNoRezerv.Location = New System.Drawing.Point(104, 16)
        Me.rdbNoRezerv.Name = "rdbNoRezerv"
        Me.rdbNoRezerv.Size = New System.Drawing.Size(95, 18)
        Me.rdbNoRezerv.TabIndex = 1
        Me.rdbNoRezerv.Text = "خروج از رزرو"
        '
        'rdbAll
        '
        Me.rdbAll.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.rdbAll.Location = New System.Drawing.Point(202, 16)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(95, 18)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.Text = "همه "
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtMinDate)
        Me.Frame1.Controls.Add(Me.btnFilter)
        Me.Frame1.Controls.Add(Me.lblFromDate)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(447, 185)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(232, 39)
        Me.Frame1.TabIndex = 45
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point(67, 8)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size(109, 21)
        Me.txtMinDate.TabIndex = 35
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point(5, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size(58, 29)
        Me.btnFilter.TabIndex = 36
        Me.btnFilter.Tag = ""
        Me.btnFilter.Text = "انتخاب"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFromDate.Location = New System.Drawing.Point(182, 14)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFromDate.Size = New System.Drawing.Size(38, 13)
        Me.lblFromDate.TabIndex = 34
        Me.lblFromDate.Text = "از تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Controls.Add(Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add(Me.pnlCommandMaster)
        Me.Panel1.Controls.Add(Me.sstChild)
        Me.Panel1.Controls.Add(Me.pnlGridMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 578)
        Me.Panel1.TabIndex = 46
        '
        'frmAnbarKalaRezerv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(982, 578)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "frmAnbarKalaRezerv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعريف رزرو کالا"
        Me.sstChild.ResumeLayout(False)
        Me._sstChild_TabPage0.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmAnbarKalaRezerv
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmAnbarKalaRezerv
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmAnbarKalaRezerv()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبار تعريف شده است
    Private WithEvents DVabVw_AnbarNoeAnbar As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي رزرو شده تعريف شده است
    Private WithEvents DVabAnbarKalaRezerv As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcTafsiliSN As NetSql.Components.DataCombo
    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcKalaSN As NetSql.Components.DataCombo

    ' جهت مشخص شدن نوع ورود اطلاعات در سطح فرم براي انبارجاري     واحدسنجش    تعداد درکارتن
    Private pNoeVoroodeAsnad As EnumNoeVoroodeAsnad

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFLX_aAnbaraNoeAnbar As AxVSFlexGrid

    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl

    ' جهت استفاده در عمليات پشتيباني رويدادهاي گريد
    Private pRowNomber As Short


    Private Sub DVabAnbarKalaRezerv_AfterCommandClick (ByVal aCommand As EnumCommands) _
        Handles DVabAnbarKalaRezerv.AfterCommandClick
        ' کنترل فيلدها در هنگام اصلاح
        With DVabAnbarKalaRezerv
            .Fields ("KalaSN").ReadOnly = False
            .Fields ("MeghdarRezerv").ReadOnly = False
            .Fields ("TafsiliSN").ReadOnly = False
            .Fields ("Box").ReadOnly = False
            .Fields ("Can").ReadOnly = False
        End With
        Select Case aCommand
            Case EnumCommands.cmEdit
                With DVabAnbarKalaRezerv
                    .Fields ("KalaSN").ReadOnly = True
                    .Fields ("MeghdarRezerv").ReadOnly = True
                    .Fields ("TafsiliSN").ReadOnly = True
                    .Fields ("Box").ReadOnly = True
                    .Fields ("Can").ReadOnly = True
                End With
            Case EnumCommands.cmAdd
                With DVabVw_AnbarNoeAnbar.FlexGrid
                    DVabAnbarKalaRezerv.Fields ("AnbarSN").Value = .TextMatrix (.Row, .ColIndex ("AnbarSN"))
                    DVabAnbarKalaRezerv.Fields ("NoeAnbarSN").Value = .TextMatrix (.Row, .ColIndex ("NoeAnbarSN"))
                End With
        End Select
    End Sub

    Private Sub DVabAnbarKalaRezerv_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabAnbarKalaRezerv.CommandClick
        Dim V_NoeAnbarSN, V_VahedeTejariSN, V_AnbarSN, V_Mojoodi As Decimal
        Dim V_KalaNO As String
        Dim vResult As Short
        Static vcmAdd As Boolean
        Dim VinKalano As String, VinKalaDs As String, VinVahedeSanjeshSN As Decimal, VinVahedeSanjeshNo As String
        Dim VinVahedeSanjeshDs As String, VinTedadAjza As Integer, vKalaSN As Object

        If Not (aCommand = EnumCommands.cmExit Or aCommand = EnumCommands.cmRefresh Or _
                aCommand = EnumCommands.cmFind Or aCommand = EnumCommands.cmPrint Or _
                aCommand = EnumCommands.cmFilter) Then
            ' بدست آوردن اطلاعات جانبي کالا
            If Val (DVabAnbarKalaRezerv.Fields ("KalaSN").Value) <> 0 Then
                vKalaSN = Val (DVabAnbarKalaRezerv.Fields ("KalaSN").Value)
                vResult = cn.CallSP ("_abSPG_GetKalaDet", vKalaSN, System.DBNull.Value, System.DBNull.Value, _
                                     System.DBNull.Value, VinKalano, VinKalaDs, VinVahedeSanjeshSN, VinVahedeSanjeshNo, _
                                     VinVahedeSanjeshDs, VinTedadAjza)
            End If
        End If

        Select Case aCommand
            Case EnumCommands.cmEdit
                vcmAdd = False
                If Val (DVabAnbarKalaRezerv.Fields ("AnbarKalaRezervStatus").Value) = 0 Then
                    aCancel = True
                End If
            Case EnumCommands.cmAdd
                vcmAdd = True
            Case EnumCommands.cmSave
                If vcmAdd Then
                    If pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton And _
                       Val (DVabAnbarKalaRezerv.Fields ("MeghdarRezerv").Value) = 0 Then
                        DVabAnbarKalaRezerv.Fields ("MeghdarRezerv").Value = Val ( _
                                                                                  DVabAnbarKalaRezerv.Fields ("Box"). _
                                                                                     Value) _
                                                                             *VinTedadAjza _
                                                                             + _
                                                                             Val ( _
                                                                                  DVabAnbarKalaRezerv.Fields ("Can"). _
                                                                                     Value)
                    End If
                    V_VahedeTejariSN = DVabVw_AnbarNoeAnbar.Fields ("VahedeTejariSN").Value
                    V_AnbarSN = DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value
                    V_NoeAnbarSN = DVabVw_AnbarNoeAnbar.Fields ("NoeAnbarSN").Value
                    V_KalaNO = VinKalano
                    If Trim (V_KalaNO) <> "" Then
                        ' گنترل مقدار موجودي کالا براي ثبت رزرو کالا
                        vResult = cn.CallSP ("_abSPG_GetMojoodiKala", V_VahedeTejariSN, V_AnbarSN _
                                             , V_NoeAnbarSN, V_KalaNO, V_Mojoodi)
                        If Val (CStr (V_Mojoodi)) < DVabAnbarKalaRezerv.Fields ("MeghdarRezerv").Value Then
                            aCancel = True
                            NetSql.Common.CSystem.MsgBox("مقدار رزرو بيشتر از موجودي كالا ميباشد", _
                                       MsgBoxStyle.OKOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, _
                                       Me.Text)
                            Exit Sub
                        Else
                            aCancel = False
                        End If
                    End If
                    ' تهيه تاريخ از سرور
                    DVabAnbarKalaRezerv.Fields ("LastTime").Value = _
                        Minoo.Functions.FTDBCommonFunctions.Get_Time_Server ( _
                                                                             cn, _
                                                                             Functions.FTDBCommonFunctions.enmTimeFormat _
                                                                                .HHmmss)
                    DVabAnbarKalaRezerv.Fields ("LastDate").Value = _
                        Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                    cn, _
                                                                                    Functions.FTDBCommonFunctions. _
                                                                                       enmDateFormat.Normal)
                End If
                If DVabAnbarKalaRezerv.State <> EnumDataViewState.bsAdd Then
                    vcmAdd = False
                End If
            Case EnumCommands.cmAbort
                vcmAdd = False
            Case EnumCommands.cmDelete
                vcmAdd = False
        End Select

    End Sub

    Private Sub DVabAnbarKalaRezerv_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabAnbarKalaRezerv.FillDetailsWithData
        With DVabAnbarKalaRezerv
            If aFetched Then
                If Val(DVabAnbarKalaRezerv.Fields("AnbarKalaRezervStatus").Value) = 0 Or _
                   Val(DVabAnbarKalaRezerv.Fields("PayeSN").Value) <> 6 Then
                    .CommandEnabled(EnumCommands.cmEdit) = False
                    .CommandEnabled(EnumCommands.cmDelete) = False
                ElseIf Val(DVabAnbarKalaRezerv.Fields("PayeSN").Value) = 6 Then
                    .CommandEnabled(EnumCommands.cmEdit) = (.AccessRight And EnumAccessRight.arUpdate) <> 0
                    .CommandEnabled(EnumCommands.cmDelete) = False
                End If
            End If
        End With
    End Sub

    Private Sub pFLX_aAnbaraNoeAnbar_RowColChange (ByVal eventSender As System.Object, _
                                                   ByVal eventArgs As System.EventArgs) _
        Handles pFLX_aAnbaraNoeAnbar.RowColChange
        Dim vSql_where As String

        If DVabVw_AnbarNoeAnbar.FlexGrid.Rows < 1 Then
            Exit Sub
        End If
        If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabVw_AnbarNoeAnbar.FlexGrid
                pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                If DVabVw_AnbarNoeAnbar.FlexGrid.Rows > 1 And .TextMatrix(.Row, .ColIndex("AnbarSN")) <> Nothing Then
                    vSql_where = " abAnbarKalaRezerv.AnbarSN = " & .TextMatrix(.Row, .ColIndex("AnbarSN")) &
                                 " AND abAnbarKalaRezerv.NoeAnbarSN =  " & .TextMatrix(.Row, .ColIndex("NoeAnbarSN"))
                ElseIf DVabVw_AnbarNoeAnbar.FlexGrid.Rows < 1 Then
                    vSql_where = " 1 = 1 "
                Else
                    vSql_where = " 1 = 2 "
                End If
            End With
            DVabAnbarKalaRezerv.SQLWhere = vSql_where
            DVabAnbarKalaRezerv.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub frmAnbarKalaRezerv_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        sstChild.Mirrored = True

        MinFilterDateCtrl = New NetSql.Components.CDateCtrl (tp)
        With MinFilterDateCtrl
            MinFilterDateCtrl.TextBox = txtMinDate
        End With

        Call InitDataView()
    End Sub

    Private Sub frmAnbarKalaRezerv_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabVw_AnbarNoeAnbar.Done()
        DVabVw_AnbarNoeAnbar = Nothing
        DVabAnbarKalaRezerv.Done()
        DVabAnbarKalaRezerv = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'Dim vSelect As String
        Dim vSql_where As String
        Dim vMinDateSetting As String
        Dim vMinDate As String
        ' تهيه تاريخ از سرور
        vMinDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting ("Anbar", "Setting", "MinDateabRezerv" & "AnbarKalaRezerv", vMinDate)
        MinFilterDateCtrl.Value = vMinDateSetting
        If MinFilterDateCtrl.IsValid Then
            vMinDate = vMinDateSetting
        End If


        DVabVw_AnbarNoeAnbar = New CDataView (cn)
        With DVabVw_AnbarNoeAnbar
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdPrint _
                                                                           Or EnumButtonOptions.boCmdFilter Or
                                                                           EnumButtonOptions.boCmdFind)
            .TableName = "abVw_AnbarNoeAnbar"
            .Text = Me.Text
            .SQLWhere = " AnbarSN =  " & gAnbarSN
            .AccessRight = EnumAccessRight.arView
            With .Fields
                .Add ("VahedeTejariDS", , EnumFieldOptions.foHidden)
                .Add ("VahedeTejariSN", , EnumFieldOptions.foHidden)
                .Add ("AnbarSN", , EnumFieldOptions.foHidden)
                .Add ("AnbarNO", , EnumFieldOptions.foDefault)
                .Add ("AnbarDS", , EnumFieldOptions.foDefault)
                .Add ("NoeAnbarSN", , EnumFieldOptions.foHidden)
                .Add ("NoeAnbarDS", , EnumFieldOptions.foDefault)
                .Add ("NoeVoroodeAsnadSN", , EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
        pFLX_aAnbaraNoeAnbar = DVabVw_AnbarNoeAnbar.FlexGrid

        With DVabVw_AnbarNoeAnbar.FlexGrid
            If .Rows > 1 Then
                pRowNomber = 1
                vSql_where = " abAnbarKalaRezerv.AnbarSN = " & .TextMatrix (.Row, .ColIndex ("AnbarSN")) & _
                             " AND abAnbarKalaRezerv.NoeAnbarSN =  " & .TextMatrix (.Row, .ColIndex ("NoeAnbarSN"))
            Else
                vSql_where = " 1 = 2 "
            End If
        End With


        DVabAnbarKalaRezerv = New CDataView (cn)
        With DVabAnbarKalaRezerv
            .Init(pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdPrint Or
                                                                     EnumButtonOptions.boCmdFilter Or
                                                                     EnumButtonOptions.boCmdExit)
            .TableName = "abAnbarKalaRezerv"
            .Text = Me.Text
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abAnbarKalaRezervStatus", "AnbarKalaRezervStatus", _
                      "AnbarKalaRezervStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paVw_VahedeSanjesh", "KalaSN", "KalaSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paVw_Application", "PayeSN", "ApplicationKeyID")
            .AccessRight = gSM.TableAccessRight (.TableName)
            .CommandEnabled (EnumCommands.cmDelete) = False
            .EditInGrid = True
            vSql_where = vSql_where & _
                         " AND abAnbarKalaRezerv.LastDate >=  " & vMinDate
            If rdbNoRezerv.Checked Then
                vSql_where = vSql_where & _
                             " AND AnbarKalaRezervStatus =  0 "
            ElseIf rdbRezerv.Checked Then
                vSql_where = vSql_where & _
                             " AND AnbarKalaRezervStatus =  1 "
            End If
            .SQLWhere = vSql_where
            .SQLOrderBy = " paKala.KalaNo , LastDate DESC , LastTime DESC "
            With .Fields
                With .Add ("AnbarKalaRezervSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add ("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .ComboLateBinding = True
                End With
                .Add ("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add ("NoeAnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                With .Add ("KalaSN->KalaNo as KalaSN1")
                    .ComboLateBinding = True
                End With
                With .Add ("KalaSN->pakala.{paKala.KalaNO + ' _ ' + paKala.KalaDS} AS KalaSN", "DataCombo")
                    dbcKalaSN = .Component
                    .Caption = cn.FieldCaption ("paKala.KalaDS")
                    dbcKalaSN.LateBinding = True
                    .ComboLateBinding = True
                End With
                With .Add ("KalaSN->paVw_VahedeSanjesh.VahedeSanjeshDs AS VahedeSanjeshDs")
                    .Caption = cn.FieldCaption ("paVahedeSanjesh.VahedeSanjeshDs")
                    .ComboLateBinding = True
                End With
                With .Add ("KalaSN->paVw_VahedeSanjesh.TedadAjza AS TedadAjza")
                    .Caption = cn.FieldCaption ("paVw_VahedeSanjesh.TedadAjza")
                    .ComboLateBinding = True
                End With
                With _
                    .Add ("AnbarKalaRezervStatus->abAnbarKalaRezervStatus.AnbarKalaRezervStatusDS", "DataCombo", _
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abAnbarKalaRezerv.AnbarKalaRezervStatus")
                    .DefaultValue = 1
                End With
                With .Add ("TarafHesabSN", "DataCombo", EnumFieldOptions.foHidden)
                    .ComboLateBinding = True
                End With
                With .Add ("TafsiliSN->{ TafsiliNO + ' _ ' + TafsiliDS} AS TafsiliSN ", "DataCombo")
                    dbcTafsiliSN = .Component
                    .Caption = cn.FieldCaption ("maGoroohTafsili.GoroohTafsiliDS")
                    .ComboWhereCondition = _
                        " maTafsili.GoroohTafsiliSN IN (select  GoroohTafsiliSN from dbo.abFnt_SelectGoroohTafsiliAll()) "
                    dbcTafsiliSN.LateBinding = True
                    .ComboLateBinding = True
                End With
                With .Add ("MeghdarRezerv", "TextBox", EnumFieldOptions.foDefault)
                    .MaxLength = 10
                    .AllowNulls = False
                End With
                With _
                    .Add ("{Convert(BIGINT,MeghdarRezerv/paVw_VahedeSanjesh.TedadAjza)} As Box", "TextBox", _
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abSanadHa.Box")
                End With
                With _
                    .Add ("{Convert(BIGINT,(Convert(BIGINT,MeghdarRezerv)% paVw_VahedeSanjesh.TedadAjza)) } As Can", _
                          "TextBox", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abSanadHa.Can")
                End With
                With .Add ("PayeSN->paVw_Application.FarsiName AS PayeSN")
                    .ReadOnly = True
                    .DefaultValue = 6
                End With
                With .Add ("LastDate", "TextBox <DISABLED>", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                End With
                With .Add ("LastTime", "TextBox <DISABLED>", EnumFieldOptions.foTime)
                    .TimeFormat = EnumTimeFormat.tfHour Or EnumTimeFormat.tfMinute Or EnumTimeFormat.tfSecond
                End With
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foDefault)
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "كاربر رزرو کننده"
                End With

                With .Add("{Case when abAnbarKalaRezerv.PayeSN = 2 then 'رزرو درخواست'  when abAnbarKalaRezerv.PayeSN = 2.1 then 'رزرو سهمیه ویزیتور' else  'رزرو انبار'  end} AS RezervDS ")
                    .ReadOnly = True
                End With

                With .Add("Host_Name", "TextBox", EnumFieldOptions.foDefault)
                    .DefaultValue = System.Environment.MachineName
                    .Caption = "ماشين"
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With


    End Sub


    Private Sub DVabVw_AnbarNoeAnbar_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabVw_AnbarNoeAnbar.FillDetailsWithData
        Dim vSql_where, vMinDate As String
        If aFetched Then
            If DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value = 0 Then Exit Sub
            If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVabVw_AnbarNoeAnbar.FlexGrid
                    pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                    If DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value <> 0 Then
                        vSql_where = " abAnbarKalaRezerv.AnbarSN = " & DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value & _
                                     " AND abAnbarKalaRezerv.NoeAnbarSN =  " & _
                                     DVabVw_AnbarNoeAnbar.Fields ("NoeAnbarSN").Value
                    Else
                        vSql_where = " 1 = 2 "
                    End If
                End With
                vMinDate = MinFilterDateCtrl.Value
                vSql_where = vSql_where & _
                             " AND abAnbarKalaRezerv.LastDate >=  " & vMinDate
                If rdbNoRezerv.Checked Then
                    vSql_where = vSql_where & _
                                 " AND AnbarKalaRezervStatus =  0 "
                ElseIf rdbRezerv.Checked Then
                    vSql_where = vSql_where & _
                                 " AND AnbarKalaRezervStatus =  1 "
                End If
                DVabAnbarKalaRezerv.SQLWhere = vSql_where
                DVabAnbarKalaRezerv.Refresh()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

            ' کنترل نمايش ستونها در مورد انبار با ماهيت واحد سنجش و انبار با ماهيت تعداد در کارتن
            With DVabAnbarKalaRezerv
                pNoeVoroodeAsnad = Val (DVabVw_AnbarNoeAnbar.Fields ("NoeVoroodeAsnadSN").Value)
                With .FlexGrid
                    If _
                        pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaTedadDarKarton Or _
                        pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh Then
                        .ColHidden (.ColIndex ("Box")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden (.ColIndex ("Can")) = (pNoeVoroodeAsnad = EnumNoeVoroodeAsnad.nvaVahedeSanjesh)
                        .ColHidden (.ColIndex ("paVw_VahedeSanjesh_TedadAjza")) = pNoeVoroodeAsnad = _
                                                                                  EnumNoeVoroodeAsnad.nvaVahedeSanjesh
                        .ColHidden (.ColIndex ("paVw_VahedeSanjesh_VahedeSanjeshDs")) = pNoeVoroodeAsnad = _
                                                                                        EnumNoeVoroodeAsnad. _
                                                                                            nvaTedadDarKarton
                        .ColHidden (.ColIndex ("MeghdarRezerv")) = pNoeVoroodeAsnad = _
                                                                   EnumNoeVoroodeAsnad.nvaTedadDarKarton
                    Else
                        .ColHidden (.ColIndex ("Box")) = True
                        .ColHidden (.ColIndex ("Can")) = True
                        .ColHidden (.ColIndex ("paVw_VahedeSanjesh_TedadAjza")) = True
                        .ColHidden (.ColIndex ("paVw_VahedeSanjesh_VahedeSanjeshDs")) = True
                        .ColHidden (.ColIndex ("MeghdarRezerv")) = True
                    End If
                End With
            End With
        End If
    End Sub

    Private Sub btnFilter_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات  بروز رساني ميگردد
        Dim vMinDate, vSql_where As String ', vFilterDate

        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting ("Anbar", "Setting", "MinDateabRezerv" & "AnbarKalaRezerv", MinFilterDateCtrl.Value)
        End If
        If DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value <> 0 Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vSql_where = " abAnbarKalaRezerv.AnbarSN = " & DVabVw_AnbarNoeAnbar.Fields ("AnbarSN").Value & _
                         " AND abAnbarKalaRezerv.NoeAnbarSN =  " & DVabVw_AnbarNoeAnbar.Fields ("NoeAnbarSN").Value
        Else
            vSql_where = " 1 = 2 "
        End If
        vSql_where = vSql_where & _
                     " AND abAnbarKalaRezerv.LastDate >=  " & vMinDate
        If rdbNoRezerv.Checked Then
            vSql_where = vSql_where & _
                         " AND AnbarKalaRezervStatus =  0 "
        ElseIf rdbRezerv.Checked Then
            vSql_where = vSql_where & _
                         " AND AnbarKalaRezervStatus =  1 "
        End If
        DVabAnbarKalaRezerv.SQLWhere = vSql_where
        DVabAnbarKalaRezerv.Refresh()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub
End Class
