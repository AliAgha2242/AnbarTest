' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  Start 1383/04/08
'ModifiedDate::
'Description:: 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmSanadMali
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
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnChangeStatusMali As System.Windows.Forms.Button
    Public WithEvents btnFilter As System.Windows.Forms.Button
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents pnlCommandDet2 As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet2 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationDet2 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnTashimSanad As System.Windows.Forms.Button
    Public WithEvents dbcAnbarSN As NetSql.Components.DataCombo
    Public WithEvents btnSelectAnbar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbWithTasvieh As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNoTasvieh As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.btnChangeStatusMali = New System.Windows.Forms.Button
        Me.btnFilter = New System.Windows.Forms.Button
        Me.txtMinDate = New System.Windows.Forms.TextBox
        Me.pnlCommandDet2 = New System.Windows.Forms.Panel
        Me.pnlGridDet2 = New System.Windows.Forms.Panel
        Me.pnlNavigationDet2 = New System.Windows.Forms.Panel
        Me.pnlCommandMaster = New System.Windows.Forms.Panel
        Me.pnlGridMaster = New System.Windows.Forms.Panel
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTashimSanad = New System.Windows.Forms.Button
        Me.dbcAnbarSN = New NetSql.Components.DataCombo (Me.components)
        Me.btnSelectAnbar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbWithTasvieh = New System.Windows.Forms.RadioButton
        Me.rdbNoTasvieh = New System.Windows.Forms.RadioButton
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChangeStatusMali
        '
        Me.btnChangeStatusMali.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnChangeStatusMali.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangeStatusMali.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChangeStatusMali.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChangeStatusMali.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.btnChangeStatusMali.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangeStatusMali.Location = New System.Drawing.Point (261, 210)
        Me.btnChangeStatusMali.Name = "btnChangeStatusMali"
        Me.btnChangeStatusMali.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnChangeStatusMali.Size = New System.Drawing.Size (57, 34)
        Me.btnChangeStatusMali.TabIndex = 14
        Me.btnChangeStatusMali.Text = "تاييد"
        Me.ToolTip1.SetToolTip (Me.btnChangeStatusMali, "قيمت گذاري واقعي")
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFilter.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFilter.Location = New System.Drawing.Point (645, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFilter.Size = New System.Drawing.Size (51, 21)
        Me.btnFilter.TabIndex = 12
        Me.btnFilter.Text = "انتخاب"
        Me.btnFilter.Visible = False
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.txtMinDate.AutoSize = False
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point (702, 4)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size (65, 23)
        Me.txtMinDate.TabIndex = 11
        Me.txtMinDate.Text = ""
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlCommandDet2
        '
        Me.pnlCommandDet2.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet2.Location = New System.Drawing.Point (399, 495)
        Me.pnlCommandDet2.Name = "pnlCommandDet2"
        Me.pnlCommandDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet2.Size = New System.Drawing.Size (420, 37)
        Me.pnlCommandDet2.TabIndex = 10
        '
        'pnlGridDet2
        '
        Me.pnlGridDet2.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet2.Location = New System.Drawing.Point (4, 279)
        Me.pnlGridDet2.Name = "pnlGridDet2"
        Me.pnlGridDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet2.Size = New System.Drawing.Size (815, 216)
        Me.pnlGridDet2.TabIndex = 8
        '
        'pnlNavigationDet2
        '
        Me.pnlNavigationDet2.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationDet2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet2.Location = New System.Drawing.Point (3, 495)
        Me.pnlNavigationDet2.Name = "pnlNavigationDet2"
        Me.pnlNavigationDet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet2.Size = New System.Drawing.Size (249, 36)
        Me.pnlNavigationDet2.TabIndex = 7
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point (399, 206)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size (420, 37)
        Me.pnlCommandMaster.TabIndex = 3
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point (4, 55)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size (815, 141)
        Me.pnlGridMaster.TabIndex = 1
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point (3, 205)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size (249, 36)
        Me.pnlNavigationMaster.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb (CType (224, Byte), CType (224, Byte), CType (224, Byte))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point (770, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size (42, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "از تاريخ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb (CType (224, Byte), CType (224, Byte), CType (224, Byte))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point (4, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size (815, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "اقلام سند انبار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb (CType (224, Byte), CType (224, Byte), CType (224, Byte))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point (540, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size (99, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = ""
        Me.Label1.Text = "اسناد انبار :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTashimSanad
        '
        Me.btnTashimSanad.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnTashimSanad.BackColor = System.Drawing.SystemColors.Control
        Me.btnTashimSanad.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTashimSanad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTashimSanad.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.btnTashimSanad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTashimSanad.Location = New System.Drawing.Point (330, 210)
        Me.btnTashimSanad.Name = "btnTashimSanad"
        Me.btnTashimSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTashimSanad.Size = New System.Drawing.Size (57, 34)
        Me.btnTashimSanad.TabIndex = 14
        Me.btnTashimSanad.Text = "تسهيم"
        '
        'dbcAnbarSN
        '
        Me.dbcAnbarSN.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.dbcAnbarSN.AutoSelectFirst = False
        Me.dbcAnbarSN.BackColor = System.Drawing.Color.White
        Me.dbcAnbarSN.BoundText = Nothing
        Me.dbcAnbarSN.BypassChangeEvent = False
        Me.dbcAnbarSN.DisplayText = ""
        Me.dbcAnbarSN.LateBindingTop = "100"
        Me.dbcAnbarSN.Location = New System.Drawing.Point (132, 3)
        Me.dbcAnbarSN.MemFilter = ""
        Me.dbcAnbarSN.Name = "dbcAnbarSN"
        Me.dbcAnbarSN.SeparatedData = Nothing
        Me.dbcAnbarSN.Size = New System.Drawing.Size (402, 24)
        Me.dbcAnbarSN.Source = Nothing
        Me.dbcAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcAnbarSN.TabIndex = 17
        Me.dbcAnbarSN.Tag = ""
        '
        'btnSelectAnbar
        '
        Me.btnSelectAnbar.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelectAnbar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAnbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAnbar.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnSelectAnbar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAnbar.Location = New System.Drawing.Point (63, 3)
        Me.btnSelectAnbar.Name = "btnSelectAnbar"
        Me.btnSelectAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAnbar.Size = New System.Drawing.Size (63, 24)
        Me.btnSelectAnbar.TabIndex = 12
        Me.btnSelectAnbar.Text = "تاييد"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add (Me.rdbWithTasvieh)
        Me.GroupBox1.Controls.Add (Me.rdbNoTasvieh)
        Me.GroupBox1.Controls.Add (Me.rdbAll)
        Me.GroupBox1.Location = New System.Drawing.Point (531, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size (285, 31)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'rdbWithTasvieh
        '
        Me.rdbWithTasvieh.Font = New System.Drawing.Font ("Tahoma", 8.0!)
        Me.rdbWithTasvieh.Location = New System.Drawing.Point (8, 9)
        Me.rdbWithTasvieh.Name = "rdbWithTasvieh"
        Me.rdbWithTasvieh.Size = New System.Drawing.Size (91, 18)
        Me.rdbWithTasvieh.TabIndex = 2
        Me.rdbWithTasvieh.Text = "تسويه شده"
        '
        'rdbNoTasvieh
        '
        Me.rdbNoTasvieh.Font = New System.Drawing.Font ("Tahoma", 8.0!)
        Me.rdbNoTasvieh.Location = New System.Drawing.Point (104, 9)
        Me.rdbNoTasvieh.Name = "rdbNoTasvieh"
        Me.rdbNoTasvieh.Size = New System.Drawing.Size (95, 18)
        Me.rdbNoTasvieh.TabIndex = 1
        Me.rdbNoTasvieh.Text = "تسويه نشده"
        '
        'rdbAll
        '
        Me.rdbAll.Checked = True
        Me.rdbAll.Font = New System.Drawing.Font ("Tahoma", 8.0!)
        Me.rdbAll.Location = New System.Drawing.Point (208, 9)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size (55, 18)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "همه"
        '
        'FrmSanadMali
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (823, 538)
        Me.Controls.Add (Me.pnlGridMaster)
        Me.Controls.Add (Me.dbcAnbarSN)
        Me.Controls.Add (Me.btnChangeStatusMali)
        Me.Controls.Add (Me.btnFilter)
        Me.Controls.Add (Me.txtMinDate)
        Me.Controls.Add (Me.Label4)
        Me.Controls.Add (Me.pnlCommandDet2)
        Me.Controls.Add (Me.pnlGridDet2)
        Me.Controls.Add (Me.pnlNavigationDet2)
        Me.Controls.Add (Me.pnlCommandMaster)
        Me.Controls.Add (Me.pnlNavigationMaster)
        Me.Controls.Add (Me.Label2)
        Me.Controls.Add (Me.Label1)
        Me.Controls.Add (Me.btnTashimSanad)
        Me.Controls.Add (Me.btnSelectAnbar)
        Me.Controls.Add (Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Location = New System.Drawing.Point (3, 24)
        Me.Name = "FrmSanadMali"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ريال اسناد"
        Me.GroupBox1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmSanadMali
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSanadMali
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSanadMali
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmSanadMali)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  عناوين اسناد تعريف شده است
    Private WithEvents DVabSanadMali As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  اقلام اسناد تعريف شده است
    Private WithEvents DVabRialeSanad As CDataView

    ' شرط پيش فرض سند مالي را در عمليات نگهداري ميکند
    Private pDVabSanadMaliWhere As String

    '   براي نمايش تاريخ در فيلتر 
    Private MinFilterDateCtrl As NetSql.Components.CDateCtrl


#Region "Property"

    Private mNoeAccessRight As String

    Friend Property NoeAccessRight() As String
        Get
            NoeAccessRight = mNoeAccessRight
        End Get
        Set (ByVal Value As String)
            mNoeAccessRight = Value
        End Set
    End Property

    Private mSanadSN As Decimal

    Friend Property SanadSN() As Decimal
        Get
            SanadSN = mSanadSN
        End Get
        Set (ByVal Value As Decimal)
            mSanadSN = Value
        End Set
    End Property

#End Region


    Private Sub btnChangeStatusMali_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnChangeStatusMali.Click
        '  وضعيت قيمت گذاري واقعي قطعي ميگردد 
        Dim li_NewVaziat As Short
        Dim vErrMsg As String
        'Dim vSanadSN As Object

        If DVabSanadMali.Fields ("GeymatStatus").Value = "2" Then
            li_NewVaziat = 6
        Else
            Exit Sub
        End If

        If NetSql.Common.CSystem.MsgBox("آيا قيمت گذاري واقعي تكميل گردد؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                          + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + _
                                                          MsgBoxStyle.MsgBoxRight, Me.Text) <> MsgBoxResult.Yes Then _
            Exit Sub
        ' Yes
        cn.CallSP("_abSPC_Change_SanadGeymatStatus", DVabSanadMali.Fields("SanadSN").Value _
                   , li_NewVaziat, gSM.UserID, gSM.UserID_Name, vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.OKOnly + IIf(li_NewVaziat <> 1, MsgBoxStyle.Critical, _
                                                          MsgBoxStyle.Exclamation) + MsgBoxStyle.MsgBoxRtlReading + _
                                MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            DVabSanadMali.FetchCurRecord()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub DVabRialeSanad_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabRialeSanad.CommandClick
        Select Case aCommand
            Case EnumCommands.cmSave
                With DVabRialeSanad
                    If Val(.Fields("GheymateTadarokat").Value) < 0 Then
                        aCancel = True
                        NetSql.Common.CSystem.MsgBox("قيمت  واقعي اشتباه است")
                        Exit Sub
                    End If
                    ' تهيه تاريخ و زمان از سرور
                    .Fields("LastTimeTadarokat").Value = Minoo.Functions.FTDBCommonFunctions.Get_Time_Server( _
                                                                                                               cn, _
                                                                                                               Functions _
                                                                                                                  . _
                                                                                                                  FTDBCommonFunctions _
                                                                                                                  . _
                                                                                                                  enmTimeFormat _
                                                                                                                  . _
                                                                                                                  HHmmss)
                    .Fields("LastDateTadarokat").Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                                      cn, _
                                                                                                                      Functions _
                                                                                                                         . _
                                                                                                                         FTDBCommonFunctions _
                                                                                                                         . _
                                                                                                                         enmDateFormat _
                                                                                                                         . _
                                                                                                                         Normal)

                    .Fields("GheymateTadarokat").Value = CInt(Fix(.Fields("GheymateTadarokat").Value))
                End With

        End Select


    End Sub

    Private Sub DVabSanadMali_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabSanadMali.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        Dim vGeymatStatus As String
        Dim vGeymatStatus2_6 As Boolean

        ' در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DVabSanadMali.FlexGrid.Rows = 1 Then Exit Sub

        vGeymatStatus = aClip("GeymatStatus")
        vGeymatStatus2_6 = (vGeymatStatus = "2")
        If vGeymatStatus2_6 Then
            ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
            vGeymatStatus2_6 = (gSM.TableAccessRight("GeymatStatus2-6") And EnumAccessRight.arAll) <> 0
        End If

        With DVabRialeSanad
            .CommandEnabled(EnumCommands.cmAdd) = False
            ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
            .CommandEnabled(EnumCommands.cmEdit) = vGeymatStatus2_6 And (gSM.TableAccessRight("abRialeSanad") _
                                                                          And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) = False
        End With
        btnChangeStatusMali.Enabled = vGeymatStatus2_6
        btnTashimSanad.Enabled = vGeymatStatus2_6
        If aFetched Then
            btnChangeStatusMali.Enabled = aClip("GeymatStatus") = 2
            btnTashimSanad.Enabled = aClip("GeymatStatus") = 2
        End If
        If gSM.ActionUpdate("abRialeSanad") <> True Then
            btnChangeStatusMali.Enabled = False
            btnTashimSanad.Enabled = False
        End If

    End Sub

    Private Sub FrmSanadMali_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSysDate, vMinDateSetting As String
        Dim vSql As String

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT AnbarSN, AnbarDS From abAnbar "
        vSql = vSql + " Where  ISNULL(IsTajmie,0) <> 1 AND abAnbar.VahedeTejariSN = " & CStr(gVahedeTejariSN)

        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dbcAnbarSN.Bind(cn, vSql, "AnbarSN", "AnbarDS")
        With dbcAnbarSN
            If gIsTajmie = 1 Then
                .Enabled = True
            Else
                .BoundText = CStr(gAnbarSN)
                .Enabled = False
            End If
        End With

        MinFilterDateCtrl = New NetSql.Components.CDateCtrl(tp)
        MinFilterDateCtrl.TextBox = txtMinDate
        ' تهيه تاريخ از سرور
        vSysDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabRialeSanad" & "Varedeh", vSysDate)
        MinFilterDateCtrl.Value = vMinDateSetting

        Call InitDataView()

        btnTashimSanad.Enabled = False
        btnChangeStatusMali.Enabled = False

    End Sub

    Private Sub FrmSanadMali_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        MinFilterDateCtrl.Done()
        MinFilterDateCtrl = Nothing
        DVabSanadMali.Done()
        DVabSanadMali = Nothing
        DVabRialeSanad.Done()
        DVabRialeSanad = Nothing
    End Sub

    Private Sub btnFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnFilter.Click
        ' در صورتيکه فيلتر تاريخ اصلاح گردد و تاييد گردد گريد نمايش اطلاعات اسناد بروز رساني ميگردد
        Dim vMinDate As String
        Dim vMaxDate As String
        'Dim vFilterDate As String
        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting(VB6.GetEXEName(), "Setting", "MinDateabRialeSanad" & "Varedeh", MinFilterDateCtrl.Value)
        End If
        MakeFilter(vMinDate, vMaxDate)
        DVabSanadMali.Refresh()
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vMinDateSetting As String
        Dim vMaxDate, vMinDate As String
        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        vMinDate = vMaxDate
        ' خواندن تاريخ تنظيمي کاربر
        vMinDateSetting = GetSetting(VB6.GetEXEName(), "Setting", "MinDateabRialeSanad" & "Varedeh", vMinDate)
        MinFilterDateCtrl.Value = vMinDateSetting
        If MinFilterDateCtrl.IsValid Then
            vMinDate = vMinDateSetting
        End If
        DVabSanadMali = New CDataView(cn)
        With DVabSanadMali
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, _
                   EnumButtonOptions.boCmdUpdate Or EnumButtonOptions.boCmdFilter _
                   Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdFind)

            .TableName = "abSanadMali"
            .Text = Me.Text
            .FlexGrid.FontSize = 9
            .AddJoin(.TableName, EnumTableJoin.tjRightJoin, "abVw_abSanad", "SanadSN", "SanadSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadGeymatStatus", "GeymatStatus", "SanadGeymatStatusSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadMaliStatus", "SanadMaliStatus", "SanadMaliStatusSN")
            .AccessRight = gSM.TableAccessRight(.TableName)
            MakeFilter(vMinDate, vMaxDate)
            .CommandEnabled(EnumCommands.cmAdd) = False
            .CommandEnabled(EnumCommands.cmDelete) = False
            .EditInGrid = True
            With .Fields
                With .Add("SanadMaliSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("SanadSN", , gSNFieldOption)
                .Add("abVw_abSanad.AnbarDs")
                .Add("abVw_abSanad.NoeAnbarDs")
                With .Add("HazineSanadA", "TextBox")

                End With
                With .Add("abVw_abSanad.TarakoneshDs")
                    .Caption = "کد - تراکنش "
                End With
                .Add("abVw_abSanad.SanadNO")
                .Add("abVw_abSanad.SanadDate", , EnumFieldOptions.foDate)
                With .Add("GeymatStatus->SanadGeymatStatusDS", "DataCombo")
                    .Caption = cn.FieldCaption("abSanadMali.GeymatStatus")
                    .ReadOnly = True
                End With
                With .Add("SanadMaliStatus->SanadMaliStatusDS", "DataCombo")
                    .Caption = cn.FieldCaption("abSanadMali.SanadMaliStatus")
                    .ReadOnly = True
                End With
                .Add("abVw_abSanad.TafsiliDs")
                .Add("abVw_abSanad.SanadStatusDS")
                .Add("abVw_abSanad.ShomarehSefaresh")
                .Add("TarakoneshSN", , EnumFieldOptions.foHidden)
                .Add("TarafHesabSN", , EnumFieldOptions.foHidden)
                .Add("TafsiliSN", , EnumFieldOptions.foHidden)
                .Add("HazineSanadB", , EnumFieldOptions.foHidden)
                .Add("HazineSanadC", , EnumFieldOptions.foHidden)
                .Add("RezDA", , EnumFieldOptions.foHidden)
                .Add("RezDB", , EnumFieldOptions.foHidden)
                .Add("RezSA", , EnumFieldOptions.foHidden)
                .Add("RezSB", , EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        DVabRialeSanad = New CDataView(cn)
        With DVabRialeSanad
            .Init(pnlGridDet2, , pnlCommandDet2, pnlNavigationDet2, _
                   EnumButtonOptions.boCmdUpdate Or EnumButtonOptions.boCmdFilter _
                   Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdExit)
            .TableName = "abRialeSanad"
            .Text = Me.Text
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abVw_abSanadHa", "SanadHaSN", "SanadHaSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadMali", "SanadSN", "SanadSN")
            .AccessRight = gSM.TableAccessRight(.TableName)
            .CommandEnabled(EnumCommands.cmAdd) = False
            .CommandEnabled(EnumCommands.cmDelete) = False
            .EditInGrid = True
            .FlexGrid.FontSize = 9
            With .Fields
                With .Add("RialeSanadSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("SanadSN", , EnumFieldOptions.foHidden)
                .Add("SanadHaSN", , EnumFieldOptions.foHidden)
                .Add("NoeRialeSanadSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add("abVw_abSanadHa.KalaNo")
                .Add("abVw_abSanadHa.KalaDs")
                .Add("abVw_abSanadHa.VahedeSanjeshDs")
                .Add("abVw_abSanadHa.TedadAjza")
                With .Add("abVw_abSanadHa.MeghdareVaredeh")
                    .Format = "#,#.###"
                End With
                With .Add("abVw_abSanadHa.MeghdareSadereh")
                    .Format = "#,#.###"
                End With
                With .Add("GheymateStandard", "TextBox")
                    '          .Format = "#,#.###"
                    .Format = "#,#"
                    .DigitGroupSymbol = ","
                    .LockUpdate = True
                    .LockInsert = True
                End With
                With .Add("SahmHazineSanadB", "TextBox")
                    '         .Format = "#,#.###"
                    .Format = "#,#"
                    .DigitGroupSymbol = ","
                    .ReadOnly = True
                End With
                With .Add("LastDateStandard", "TextBox", EnumFieldOptions.foDate)
                    .LockUpdate = True
                    .LockInsert = True
                End With
                With .Add("LastTimeStandard", "TextBox", EnumFieldOptions.foTime)
                    .TimeFormat = EnumTimeFormat.tfHour Or EnumTimeFormat.tfMinute Or EnumTimeFormat.tfSecond
                    .LockUpdate = True
                    .LockInsert = True
                End With
                With .Add("GheymateTadarokat", "TextBox")
                    '        .Format = "#,#.###"
                    .Format = "#,#"
                    '.NumericPrecision = 0
                    '.DataType = "int"
                    .NumericScale = 0
                    .DigitGroupSymbol = ","
                    .MaxLength = 22
                End With
                With .Add("LastDateTadarokat", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                cn, _
                                                                                                Functions. _
                                                                                                   FTDBCommonFunctions. _
                                                                                                   enmDateFormat.Normal)
                    .LockUpdate = True
                    .LockInsert = True
                End With
                With .Add("LastTimeTadarokat", "TextBox", EnumFieldOptions.foTime)
                    .TimeFormat = EnumTimeFormat.tfHour Or EnumTimeFormat.tfMinute Or EnumTimeFormat.tfSecond
                    .LockUpdate = True
                    .LockInsert = True
                End With
                With .Add("SahmHazineSanadA", "TextBox")
                    '          .Format = "#,#.###"
                    .Format = "#,#"
                    .DigitGroupSymbol = ","
                    .ReadOnly = True
                End With
                With .Add("Tozih", "TextBox")
                    .LockInsert = True
                End With
                With .Add("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                End With
                .Add("GheymateL", , EnumFieldOptions.foHidden)
                .Add("GheymateF", , EnumFieldOptions.foHidden)
                .Add("SahmHazineSanadC", , EnumFieldOptions.foHidden)
                .Add("RezDA", , EnumFieldOptions.foHidden)
                .Add("RezDB", , EnumFieldOptions.foHidden)
                .Add("RezSA", , EnumFieldOptions.foHidden)
                .Add("RezSB", , EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabSanadMali
        End With
    End Sub

    Private Sub MakeFilter(ByRef aMinDate As String, ByRef aMaxDate As String)
        ' با توجه به فيلتر فرم شرط ديتا ويو بروز رساني ميگردد
        With DVabSanadMali
            .SQLWhere = "  abVw_abSanad.SanadDate >= '" & aMinDate & _
                        "' AND abVw_abSanad.SanadDate <= '" & aMaxDate & "'" & _
                        " AND abVw_abSanad.SanadStatus = 8  " & _
                        " And abVw_abSanad.GeyMatStatus >= 2  "
            If SanadSN <> 0 Then
                .SQLWhere = .SQLWhere & " AND abVw_abSanad.SanadSN = " & SanadSN
            End If
            pDVabSanadMaliWhere = DVabSanadMali.SQLWhere
        End With
    End Sub

    Private Sub btnTashimSanad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTashimSanad.Click
        ' بر اساس هزينه واقعي سهم هزينه هر کالا محاسبه مي گردد
        Dim li_NewVaziat As Short
        Dim vErrMsg As String
        'Dim vSanadSN As Object

        If DVabSanadMali.Fields("GeymatStatus").Value <> "2" Then
            Exit Sub
        End If

        If _
            NetSql.Common.CSystem.MsgBox("آيا بر اساس هزينه واقعي سهم هزينه هر کالا محاسبه گردد؟", _
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + _
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) <> MsgBoxResult.Yes Then _
            Exit Sub
        ' Yes
        cn.CallSP("_abSP_TashimSanad", _
                   System.DBNull.Value, System.DBNull.Value, DVabSanadMali.Fields("SanadSN").Value _
                   , vErrMsg)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vErrMsg <> "" Then
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.OKOnly + IIf(li_NewVaziat <> 1, MsgBoxStyle.Critical, MsgBoxStyle.Exclamation) + _
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
        Else
            DVabRialeSanad.Refresh()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub DVabSanadMali_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabSanadMali.CommandClick
        Select Case aCommand
            Case EnumCommands.cmSave
                With DVabSanadMali
                    If Val(.Fields("HazineSanadA").Value) <= 0 Then
                        aCancel = True
                        NetSql.Common.CSystem.MsgBox("هزينه واقعي اشتباه است")
                        Exit Sub
                    End If
                End With
        End Select

    End Sub

    Private Sub btnSelectAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSelectAnbar.Click
        ' با توجه به تاريخ فيلتر و انبار مشخص شده اسناد نمايش داده ميشود
        'Dim vErrMsg As String
        Dim vAnbarSN As String
        Dim vMinDate As String
        Dim vMaxDate As String
        'Dim vFilterDate As String

        If Trim(dbcAnbarSN.BoundText) = "" Then
            NetSql.Common.CSystem.MsgBox("انبار مشخص نشده است")
            Exit Sub
        Else
            vAnbarSN = dbcAnbarSN.BoundText
        End If

        ' تهيه تاريخ از سرور
        vMaxDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                               cn, _
                                                                               Functions.FTDBCommonFunctions. _
                                                                                  enmDateFormat.Normal)
        If MinFilterDateCtrl.IsValid Then
            If MinFilterDateCtrl.Text <> "" Then
                vMinDate = MinFilterDateCtrl.Value
            End If
            ' ذخيره تاريخ تنظيمي کاربر
            SaveSetting(VB6.GetEXEName(), "Setting", "MinDateabRialeSanad" & "Varedeh", MinFilterDateCtrl.Value)
        End If
        MakeFilter(vMinDate, vMaxDate)

        With DVabSanadMali
            pDVabSanadMaliWhere = pDVabSanadMaliWhere + " AND AnbarSN =  " & vAnbarSN
            pDVabSanadMaliWhere = pDVabSanadMaliWhere & _
                                  "  AND abVw_abSanad.TarakoneshSN IN ( SELECT     abAnbarTarakonesh.TarakoneshSN " & _
                                  " FROM  abAnbarTarakonesh " & _
                                  " WHERE   (ISNULL(abAnbarTarakonesh.SabteRialVaghei,0) = 1) AND " & _
                                  " abAnbarTarakonesh.AnbarSN = " & vAnbarSN & " ) "

            .SQLWhere = pDVabSanadMaliWhere
            Dim vSQLWhereOR As String
            ' حا به شرط ديتا ويو شرط -يا- زير اضافه ميگردد تا اسناد اصلاحيه را نيز کاربر مشاهده کند
            vSQLWhereOR = " OR  " & _
                          " ( abVw_abSanad.TarakoneshSN IN (45,95) AND abVw_abSanad.MarjaSanadSN IN (  " & _
                          " Select SanadSN from abVw_abSanad Where  " & pDVabSanadMaliWhere & " )) "
            .SQLWhere = .SQLWhere & vSQLWhereOR

            .Refresh()
        End With

    End Sub

    Private Sub rdbAll_CheckedChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbAll.CheckedChanged
        ' همه کالاها
        ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
        If Not DVabSanadMali Is Nothing Then
            With DVabSanadMali
                .SQLWhere = pDVabSanadMaliWhere
                .Refresh()
            End With
        End If

    End Sub

    Private Sub rdbNoTasvieh_CheckedChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbNoTasvieh.CheckedChanged
        ' کالاهاي بررسي نشده
        ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
        If Not DVabSanadMali Is Nothing Then
            DVabRialeSanad.SQLWhere = " 1 = 2 "
            DVabRialeSanad.Refresh()
            DVabRialeSanad.SQLWhere = ""
            With DVabSanadMali
                .SQLWhere = pDVabSanadMaliWhere & "  AND abSanadMali.GeymatStatus <> 6 "
                .Refresh()
            End With
        End If
    End Sub

    Private Sub rdbWithTasvieh_CheckedChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rdbWithTasvieh.CheckedChanged
        ' کالاهاي بررسي شده
        ' ساختن و لحاظ کردن شرط لازم براي نمايش اطلاعات با توجه به اين رويداد
        If Not DVabSanadMali Is Nothing Then
            DVabRialeSanad.SQLWhere = " 1 = 2 "
            DVabRialeSanad.Refresh()
            DVabRialeSanad.SQLWhere = ""
            With DVabSanadMali
                .SQLWhere = pDVabSanadMaliWhere & "  AND abSanadMali.GeymatStatus = 6 "
                .Refresh()
            End With
        End If
    End Sub
End Class
