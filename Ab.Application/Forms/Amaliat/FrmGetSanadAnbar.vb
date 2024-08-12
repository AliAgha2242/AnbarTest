'  OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/10/26
'ModifiedDate::
'Description:: 
'System ::انبار

Imports System.IO

Public Class FrmGetSanadAnbar
    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

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

    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public WithEvents pnlGrid As System.Windows.Forms.Panel
    Public WithEvents pnlCmd As System.Windows.Forms.Panel
    Public WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDaryafteSanad As System.Windows.Forms.TextBox
    Public WithEvents dbcTarakoneshSN As NetSql.Components.DataCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents txtMinDate As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents pgbDelay As System.Windows.Forms.ProgressBar
    Public WithEvents Frame32 As System.Windows.Forms.GroupBox
    Public WithEvents opn9Raghami As System.Windows.Forms.RadioButton
    Public WithEvents opn8Raghami As System.Windows.Forms.RadioButton
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveSanadInDB As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAsnad As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.pnlCmd = New System.Windows.Forms.Panel
        Me.pnlNav = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDeleteAsnad = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Frame32 = New System.Windows.Forms.GroupBox
        Me.opn9Raghami = New System.Windows.Forms.RadioButton
        Me.opn8Raghami = New System.Windows.Forms.RadioButton
        Me.pgbDelay = New System.Windows.Forms.ProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtMinDate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnReadFile = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dbcTarakoneshSN = New NetSql.Components.DataCombo (Me.components)
        Me.txtDaryafteSanad = New System.Windows.Forms.TextBox
        Me.btnSaveSanadInDB = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Frame32.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGrid
        '
        Me.pnlGrid.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                     Or System.Windows.Forms.AnchorStyles.Left) _
                                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGrid.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrid.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.pnlGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGrid.Location = New System.Drawing.Point (1, 218)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGrid.Size = New System.Drawing.Size (997, 235)
        Me.pnlGrid.TabIndex = 15
        '
        'pnlCmd
        '
        Me.pnlCmd.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCmd.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCmd.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCmd.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCmd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCmd.Location = New System.Drawing.Point (500, 455)
        Me.pnlCmd.Name = "pnlCmd"
        Me.pnlCmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCmd.Size = New System.Drawing.Size (497, 41)
        Me.pnlCmd.TabIndex = 17
        '
        'pnlNav
        '
        Me.pnlNav.Anchor = CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNav.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNav.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNav.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNav.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNav.Location = New System.Drawing.Point (7, 455)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNav.Size = New System.Drawing.Size (328, 41)
        Me.pnlNav.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                      Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add (Me.btnDeleteAsnad)
        Me.GroupBox1.Controls.Add (Me.Label1)
        Me.GroupBox1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point (1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size (997, 56)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "حذف اسناد"
        '
        'btnDeleteAsnad
        '
        Me.btnDeleteAsnad.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAsnad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteAsnad.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnDeleteAsnad.Location = New System.Drawing.Point (576, 21)
        Me.btnDeleteAsnad.Name = "btnDeleteAsnad"
        Me.btnDeleteAsnad.Size = New System.Drawing.Size (122, 27)
        Me.btnDeleteAsnad.TabIndex = 23
        Me.btnDeleteAsnad.Text = "تاييد"
        '
        'Label1
        '
        Me.Label1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb (CType (255, Byte), CType (192, Byte), CType (192, Byte))
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label1.Location = New System.Drawing.Point (706, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size (266, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "حذف کليه اسناد انبار  مقداري و ريالي"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                      Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add (Me.Frame32)
        Me.GroupBox2.Controls.Add (Me.pgbDelay)
        Me.GroupBox2.Controls.Add (Me.Panel1)
        Me.GroupBox2.Controls.Add (Me.btnReadFile)
        Me.GroupBox2.Controls.Add (Me.Label2)
        Me.GroupBox2.Controls.Add (Me.dbcTarakoneshSN)
        Me.GroupBox2.Controls.Add (Me.txtDaryafteSanad)
        Me.GroupBox2.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point (1, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size (997, 156)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "دريافت اسناد"
        '
        'Frame32
        '
        Me.Frame32.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Frame32.BackColor = System.Drawing.SystemColors.Control
        Me.Frame32.Controls.Add (Me.opn9Raghami)
        Me.Frame32.Controls.Add (Me.opn8Raghami)
        Me.Frame32.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Frame32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame32.Location = New System.Drawing.Point (263, 6)
        Me.Frame32.Name = "Frame32"
        Me.Frame32.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame32.Size = New System.Drawing.Size (198, 42)
        Me.Frame32.TabIndex = 37
        Me.Frame32.TabStop = False
        Me.Frame32.Text = "کد کالا"
        '
        'opn9Raghami
        '
        Me.opn9Raghami.BackColor = System.Drawing.SystemColors.Control
        Me.opn9Raghami.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opn9Raghami.Cursor = System.Windows.Forms.Cursors.Default
        Me.opn9Raghami.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.opn9Raghami.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.opn9Raghami.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opn9Raghami.Location = New System.Drawing.Point (2, 16)
        Me.opn9Raghami.Name = "opn9Raghami"
        Me.opn9Raghami.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opn9Raghami.Size = New System.Drawing.Size (74, 22)
        Me.opn9Raghami.TabIndex = 1
        Me.opn9Raghami.TabStop = True
        Me.opn9Raghami.Text = "9 رقمي"
        '
        'opn8Raghami
        '
        Me.opn8Raghami.BackColor = System.Drawing.SystemColors.Control
        Me.opn8Raghami.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opn8Raghami.Checked = True
        Me.opn8Raghami.Cursor = System.Windows.Forms.Cursors.Default
        Me.opn8Raghami.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.opn8Raghami.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.opn8Raghami.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opn8Raghami.Location = New System.Drawing.Point (104, 17)
        Me.opn8Raghami.Name = "opn8Raghami"
        Me.opn8Raghami.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.opn8Raghami.Size = New System.Drawing.Size (78, 22)
        Me.opn8Raghami.TabIndex = 0
        Me.opn8Raghami.TabStop = True
        Me.opn8Raghami.Text = "8 رقمي"
        '
        'pgbDelay
        '
        Me.pgbDelay.Location = New System.Drawing.Point (11, 123)
        Me.pgbDelay.Name = "pgbDelay"
        Me.pgbDelay.Size = New System.Drawing.Size (569, 25)
        Me.pgbDelay.Step = 1
        Me.pgbDelay.TabIndex = 36
        Me.pgbDelay.Value = 10
        Me.pgbDelay.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add (Me.txtMinDate)
        Me.Panel1.Controls.Add (Me.Label3)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point (518, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size (155, 29)
        Me.Panel1.TabIndex = 35
        '
        'txtMinDate
        '
        Me.txtMinDate.AcceptsReturn = True
        Me.txtMinDate.AutoSize = False
        Me.txtMinDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinDate.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.txtMinDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinDate.Location = New System.Drawing.Point (14, 2)
        Me.txtMinDate.MaxLength = 0
        Me.txtMinDate.Name = "txtMinDate"
        Me.txtMinDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinDate.Size = New System.Drawing.Size (78, 27)
        Me.txtMinDate.TabIndex = 35
        Me.txtMinDate.Text = ""
        Me.txtMinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point (101, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size (29, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = " تاريخ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnReadFile
        '
        Me.btnReadFile.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnReadFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReadFile.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnReadFile.Location = New System.Drawing.Point (583, 110)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size (83, 38)
        Me.btnReadFile.TabIndex = 27
        Me.btnReadFile.Text = "خواندن فايل"
        '
        'Label2
        '
        Me.Label2.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point (601, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size (72, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "نوع سند"
        '
        'dbcTarakoneshSN
        '
        Me.dbcTarakoneshSN.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.dbcTarakoneshSN.AutoSelectFirst = False
        Me.dbcTarakoneshSN.BackColor = System.Drawing.Color.White
        Me.dbcTarakoneshSN.BoundText = Nothing
        Me.dbcTarakoneshSN.BypassChangeEvent = False
        Me.dbcTarakoneshSN.DisplayText = ""
        Me.dbcTarakoneshSN.LateBindingTop = "100"
        Me.dbcTarakoneshSN.Location = New System.Drawing.Point (76, 46)
        Me.dbcTarakoneshSN.MemFilter = ""
        Me.dbcTarakoneshSN.Name = "dbcTarakoneshSN"
        Me.dbcTarakoneshSN.SeparatedData = Nothing
        Me.dbcTarakoneshSN.Size = New System.Drawing.Size (600, 22)
        Me.dbcTarakoneshSN.Source = Nothing
        Me.dbcTarakoneshSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTarakoneshSN.TabIndex = 25
        '
        'txtDaryafteSanad
        '
        Me.txtDaryafteSanad.AcceptsReturn = True
        Me.txtDaryafteSanad.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.txtDaryafteSanad.AutoSize = False
        Me.txtDaryafteSanad.BackColor = _
            System.Drawing.Color.FromArgb (CType (255, Byte), CType (192, Byte), CType (192, Byte))
        Me.txtDaryafteSanad.Location = New System.Drawing.Point (688, 21)
        Me.txtDaryafteSanad.Multiline = True
        Me.txtDaryafteSanad.Name = "txtDaryafteSanad"
        Me.txtDaryafteSanad.Size = New System.Drawing.Size (306, 128)
        Me.txtDaryafteSanad.TabIndex = 24
        Me.txtDaryafteSanad.Text = ""
        '
        'btnSaveSanadInDB
        '
        Me.btnSaveSanadInDB.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSaveSanadInDB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveSanadInDB.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnSaveSanadInDB.Location = New System.Drawing.Point (338, 455)
        Me.btnSaveSanadInDB.Name = "btnSaveSanadInDB"
        Me.btnSaveSanadInDB.Size = New System.Drawing.Size (159, 41)
        Me.btnSaveSanadInDB.TabIndex = 24
        Me.btnSaveSanadInDB.Text = "ثبت سند انبار"
        '
        'FrmGetSanadAnbar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 15)
        Me.ClientSize = New System.Drawing.Size (1000, 499)
        Me.Controls.Add (Me.btnSaveSanadInDB)
        Me.Controls.Add (Me.GroupBox2)
        Me.Controls.Add (Me.GroupBox1)
        Me.Controls.Add (Me.pnlCmd)
        Me.Controls.Add (Me.pnlNav)
        Me.Controls.Add (Me.pnlGrid)
        Me.Name = "FrmGetSanadAnbar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "دريافت فايل براي ساخت سند انبار"
        Me.GroupBox1.ResumeLayout (False)
        Me.GroupBox2.ResumeLayout (False)
        Me.Frame32.ResumeLayout (False)
        Me.Panel1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmGetSanadAnbar
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmGetSanadAnbar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmGetSanadAnbar
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmGetSanadAnbar)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  اسناد دريافتي از فايل  تعريف شده است
    Private WithEvents DVabGetAsnadAnbar As CDataView

    '   براي نمايش تاريخ در فيلتر 
    Private pMinFilterDateCtrl As NetSql.Components.CDateCtrl

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dbcKalaSN As NetSql.Components.DataCombo

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVabGetAsnadAnbar = New CDataView (cn)
        With DVabGetAsnadAnbar
            .Init (pnlGrid, , pnlCmd, pnlNav, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                              Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter)
            .TableName = "abGetAsnadAnbar"
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paKAla", "KalaNO", "kalaNO")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abAnbar", "AnbarSN", "AnbarSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abTarakonesh", "TarakoneshSN", "TarakoneshSN")
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            .EditInGrid = False
            .SQLWhere = " GetAsnadAnbarStatus = 1  "
            With .Fields
                With .Add ("GetAsnadAnbarSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("abAnbar.AnbarDS")
                .Add ("AnbarSN")
                .Add ("NoeAnbarSN")
                .Add ("TafsiliSN", , EnumFieldOptions.foHidden)
                .Add ("abTarakonesh.TarakoneshDS")
                .Add ("TarakoneshSN", , EnumFieldOptions.foHidden)
                .Add ("SanadNO", , EnumFieldOptions.foHidden)
                .Add ("SanadDate", , EnumFieldOptions.foDate)
                .Add ("KalaNO")
                .Add ("paKAla.KalaDS")
                .Add ("Meghdar")
                .Add ("S")
                .Add ("GetAsnadAnbarStatus")
                .Add ("RezDA", , EnumFieldOptions.foHidden)
                .Add ("RezDB", , EnumFieldOptions.foHidden)
                .Add ("RezSA", , EnumFieldOptions.foHidden)
                .Add ("RezSB", , EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
    End Sub

    Private Sub FrmGetSanadAnbar_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pMinFilterDateCtrl = New NetSql.Components.CDateCtrl (tp)
        pMinFilterDateCtrl.TextBox = txtMinDate
        ' تهيه تاريخ از سرور
        pMinFilterDateCtrl.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali ( _
                                                                                               cn, _
                                                                                               Functions. _
                                                                                                  FTDBCommonFunctions. _
                                                                                                  enmDateFormat.Normal)

        With txtDaryafteSanad
            .Text = "فايل ورودي بايستي از چپ براست داراي : " + vbCrLf & _
                    "  8 بايت براي کد کالا " + vbCrLf & _
                    "  9 بايت براي مقدار " + vbCrLf & _
                    "  1 بايت براي علامت " + vbCrLf & _
                    " باشد ."
            .ReadOnly = True
        End With
        Call InitDataView()
        dbcTarakoneshSN.LateBinding = True
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dbcTarakoneshSN.Bind (cn, " Select TOP 100 PERCENT TarakoneshSN , TarakoneshNo , TarakoneshDs " & _
                                  "From abTarakonesh  Where  TarakoneshSN IN (44)   order by TartibA ", "TarakoneshSN", _
                              "TarakoneshDs")


    End Sub

    Private Sub Button1_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        Dim vFileName As String
        Dim V_AnbarSN As Decimal
        Dim V_NoeAnbarSN As Integer
        Dim V_TafsiliSN As Decimal
        Dim V_TarakoneshSN As Integer
        Dim V_SanadNO As Integer
        Dim V_SanadDate As String
        Dim V_KalaNO As String
        Dim V_Meghdar As Decimal
        Dim V_S As Integer
        Dim V_GetAsnadAnbarStatus As Integer
        'Dim V_RezDA As Decimal
        'Dim V_RezDB As Decimal
        'Dim V_RezSA As String
        'Dim V_RezSB As String
        Dim vlenRecord As Integer

        vFileName = Minoo.Functions.FTCommonFunctions.GetFileName ("Text Format (*.txt)|*.txt", ".txt", True)
        System.Windows.Forms.Application.DoEvents()
        If opn9Raghami.Checked = True Then
            vlenRecord = 19
        Else
            vlenRecord = 18
        End If

        If Trim (vFileName) <> "" Then
            Dim sr As StreamReader = New StreamReader (vFileName)
            Dim line As String, vIdentifier As Decimal
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim fileDetails As System.IO.FileInfo = New System.IO.FileInfo (vFileName)
            With pgbDelay
                .Visible = True
                .Minimum = 0
                .Maximum = fileDetails.Length/vlenRecord
                ' 18
            End With


            cn.ExecuteNoneQuery (" Update abGetAsnadAnbar Set GetAsnadAnbarStatus = 2  ")
            Do
                line = sr.ReadLine()
                If Trim (line) <> "" And Len (Trim (line)) >= vlenRecord Then
                    If opn9Raghami.Checked = True Then
                        V_KalaNO = Val (Mid (line, 1, 9))
                        ' 9
                    Else
                        V_KalaNO = Val (Mid (line, 1, 8))
                        ' 8
                    End If
                    If Trim (V_KalaNO) <> "" Then
                        V_AnbarSN = gAnbarSN
                        V_NoeAnbarSN = gNoeAnbarSN
                        If opn9Raghami.Checked = True Then
                            V_Meghdar = Mid (line, 10, 9)
                            ' 9
                            V_S = Mid (line, 19, 1)
                            ' 1
                        Else
                            V_Meghdar = Mid (line, 9, 9)
                            ' 9
                            V_S = Mid (line, 18, 1)
                            ' 1
                        End If
                        V_SanadDate = pMinFilterDateCtrl.Value
                        V_TarakoneshSN = dbcTarakoneshSN.BoundText
                        V_GetAsnadAnbarStatus = 1
                        '  ثبت اسناد خوانده شده از فايل در يک جدول موقتي

                        ' Insert into  abGetAsnadAnbar_Insert
                        cn.CallSP ("abGetAsnadAnbar_Insert", vIdentifier, V_AnbarSN, V_NoeAnbarSN, V_TafsiliSN, _
                                   V_TarakoneshSN, V_SanadNO, V_SanadDate _
                                   , V_KalaNO, V_Meghdar, V_S, V_GetAsnadAnbarStatus _
                                   , System.DBNull.Value, System.DBNull.Value, System.DBNull.Value, System.DBNull.Value)
                        ' Insert into  _dpOldVosoolEtebar_InsertX
                        If pgbDelay.Maximum < Val (pgbDelay.Value) + 1 Then
                            pgbDelay.Value = pgbDelay.Maximum
                        Else
                            pgbDelay.Value = Val (pgbDelay.Value) + 1
                        End If
                    End If
                End If
            Loop Until line Is Nothing
            sr.Close()
            DVabGetAsnadAnbar.Refresh()
            pgbDelay.Value = Val (pgbDelay.Maximum)
            pgbDelay.Visible = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ' Read File
        End If
    End Sub

    Private Sub cmdFilter_Click (ByVal sender As System.Object, ByVal e As System.EventArgs)
        With DVabGetAsnadAnbar
            .SQLWhere = " dpOldVosoolEtebar.SanadDate  = " & pMinFilterDateCtrl.Value
            .Refresh()
        End With

    End Sub

    Private Sub pnlDeleteAsnad_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDeleteAsnad.Click
        ' حذف اسناد انبار
        Dim vReturn As Integer
        Dim vmsg As String, vIdentifier As Decimal
        vIdentifier = gSM.Identifier

        vmsg = vbCrLf + "لازم بذکر است که " + vbCrLf & _
               "- کليه اطلاعات مقداري انبار حذف ميگردد" + vbCrLf & _
               "- کليه اطلاعات ريالي انبار حذف ميگردد" + vbCrLf & _
               "- کالاهاي رزرو شده انبار حذف ميگردد" + vbCrLf & _
               " نکته قابل ذکر آن است که اين اطلاعات قابل بازگرداندن نيست "

        If _
            NetSql.Common.CSystem.MsgBox("آيا کليه اطلاعات سيستم انبار حذف گردد ؟", _
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + _
                       MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
            If _
                NetSql.Common.CSystem.MsgBox("آيا کليه اطلاعات سيستم انبار حذف گردد ؟" + vmsg, _
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + _
                           MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
                vReturn = cn.CallSP("_abDelete_All_Asnad_Anbar", "YesYesIAm", vIdentifier)
                If vReturn = 1 Then
                    MsgBox("کليه اطلاعات حذف شد ")
                Else
                    MsgBox("اطلاعات حذف نشد.به مشکل برخورد")
                End If
            End If
        End If
    End Sub

    Private Sub btnSaveSanadInDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSaveSanadInDB.Click
        ' ثبت موجودي اول دوره از جدول موقتي به جداول واقعي
        Dim vVahedeTejariSN, vAnbarSN, vIdentifier As Decimal, vUserID_Name As String, vReturn As Integer
        vVahedeTejariSN = gVahedeTejariSN
        vAnbarSN = gAnbarSN
        vIdentifier = gSM.Identifier
        vUserID_Name = gSM.UserID_Name
        Dim vmsg As String
        vmsg = "لازم بذکر است که اقلامي ثبت خواهد شد که : " + vbCrLf & _
               "- نام کالا در گريد نمايش داده شده باشد" + vbCrLf & _
               "- مقدار بزرگتر از صفر داشته باشد  " + vbCrLf & _
               "- ستون علامت آن صفر باشد S " + vbCrLf + vbCrLf
        If _
            NetSql.Common.CSystem.MsgBox(vmsg + " با توجه به اطلاعات گريد بالا آيا سند انبار ايجاد گردد ؟ ", _
                       MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + _
                       MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            vReturn = cn.CallSP("_abSP_DarjOldSanadAnbar", vVahedeTejariSN, vAnbarSN, vIdentifier, vUserID_Name)
            If vReturn = 0 Then
                vmsg = vbCrLf + "آن دسته از اطلاعات که در گريد بالا باقي مانده است در سند ثبت نشده است " + vbCrLf + _
                       vbCrLf
                vmsg = vmsg + "لازم بذکر است که اقلامي ثبت خواهد شد که : " + vbCrLf & _
                       "- نام کالا در گريد نمايش داده شده باشد" + vbCrLf & _
                       "- مقدار بزرگتر از صفر داشته باشد  " + vbCrLf & _
                       "- ستون علامت آن صفر باشد S " + vbCrLf + vbCrLf
                MsgBox("سند انبار بصورت پيشنويس ساخته شد " + vmsg, _
                        MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + _
                        MsgBoxStyle.MsgBoxRight, Me.Text)
            Else
                MsgBox("ثبت سند به مشکل برخورده است ")
            End If
            DVabGetAsnadAnbar.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub opn9Raghami_CheckedChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles opn9Raghami.CheckedChanged
        If opn9Raghami.Checked = True Then
            With txtDaryafteSanad
                .Text = "فايل ورودي بايستي از چپ براست داراي : " + vbCrLf & _
                        "  9 بايت براي کد کالا " + vbCrLf & _
                        "  9 بايت براي مقدار " + vbCrLf & _
                        "  1 بايت براي علامت " + vbCrLf & _
                        " باشد ."

                .ReadOnly = True
            End With
        Else
            With txtDaryafteSanad
                .Text = "فايل ورودي بايستي از چپ براست داراي : " + vbCrLf & _
                        "  8 بايت براي کد کالا " + vbCrLf & _
                        "  9 بايت براي مقدار " + vbCrLf & _
                        "  1 بايت براي علامت " + vbCrLf & _
                        " باشد ."

                .ReadOnly = True
            End With

        End If
    End Sub
End Class
