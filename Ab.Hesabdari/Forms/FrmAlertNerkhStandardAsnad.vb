' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/04/14 Start 14:06
'ModifiedDate::
'Description:: 
'System ::انبار

Option Strict Off
Option Explicit On


Friend Class FrmAlertNerkhStandardAsnad
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
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents fraExit As System.Windows.Forms.Panel
    Public WithEvents btnShowHideCols As System.Windows.Forms.Button
    Public WithEvents btnExcel As System.Windows.Forms.Button
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents picDVGrid As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.fraExit = New System.Windows.Forms.Panel()
        Me.btnShowHideCols = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.picDVGrid = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fraExit.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(200, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(347, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "هشدار كالاهاي بدون نرخ استاندارد"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(327, 330)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(454, 37)
        Me.pnlC.TabIndex = 30
        '
        'fraExit
        '
        Me.fraExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraExit.BackColor = System.Drawing.SystemColors.Control
        Me.fraExit.Controls.Add(Me.btnShowHideCols)
        Me.fraExit.Controls.Add(Me.btnExcel)
        Me.fraExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.fraExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.fraExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraExit.Location = New System.Drawing.Point(218, 330)
        Me.fraExit.Name = "fraExit"
        Me.fraExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fraExit.Size = New System.Drawing.Size(107, 37)
        Me.fraExit.TabIndex = 31
        '
        'btnShowHideCols
        '
        Me.btnShowHideCols.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShowHideCols.BackColor = System.Drawing.Color.Transparent
        Me.btnShowHideCols.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowHideCols.Enabled = False
        Me.btnShowHideCols.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowHideCols.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnShowHideCols.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowHideCols.Location = New System.Drawing.Point(1, 0)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size(51, 35)
        Me.btnShowHideCols.TabIndex = 10
        Me.btnShowHideCols.Text = "تنظيم"
        Me.btnShowHideCols.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.Enabled = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point(55, 0)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size(51, 35)
        Me.btnExcel.TabIndex = 9
        Me.btnExcel.Text = "EXCEL"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(1, 330)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(214, 37)
        Me.pnlN.TabIndex = 32
        '
        'picDVGrid
        '
        Me.picDVGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDVGrid.BackColor = System.Drawing.SystemColors.Control
        Me.picDVGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDVGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDVGrid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.picDVGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picDVGrid.Location = New System.Drawing.Point(3, 49)
        Me.picDVGrid.Name = "picDVGrid"
        Me.picDVGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picDVGrid.Size = New System.Drawing.Size(778, 277)
        Me.picDVGrid.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlC)
        Me.Panel1.Controls.Add(Me.fraExit)
        Me.Panel1.Controls.Add(Me.pnlN)
        Me.Panel1.Controls.Add(Me.picDVGrid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 370)
        Me.Panel1.TabIndex = 33
        '
        'FrmAlertNerkhStandardAsnad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 370)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 24)
        Me.Name = "FrmAlertNerkhStandardAsnad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "هشدار كالاهاي بدون نرخ استاندارد"
        Me.fraExit.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmAlertNerkhStandardAsnad
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmAlertNerkhStandardAsnad
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAlertNerkhStandardAsnad()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region


    'يك ديتا ويو از نوع ابزار جهت نمايش  خروجي گزارش هشدار تعريف شده است
    Public WithEvents DVrpt As CDataView

    Public Sub ExitSub()
        Me.Close()
    End Sub

    Private Sub FrmAlertNerkhStandardAsnad_Closed(ByVal eventSender As System.Object,
                                                   ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        DVrpt.Done()
        DVrpt = Nothing
    End Sub

    Public Sub DataLoad()
        'Dim vSql As String
        'Dim i, li_counter As Short
        'Dim vCurMah As Short
        'By Izadpanah -تغيير از ويو به اس پي براي افزودن فيلتر تاريخ و انبار-860125
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVrpt = New CDataView(cn)
        With DVrpt
            .Init(picDVGrid, , pnlC, pnlN, gEnumButtonOptionsReports)
            '.TableName = "abVw_abAlertNerkhStandard"
            .QueryName = "abVw_abAlertNerkhStandard"
            .DataSource =
                cn.ExecuteQuery(
                                 "_abSpr_AlterNerkhEstandard " & "'" & Trim(gHesabdariSalFDate) & "','" &
                                 Trim(gHesabdariSalTDate) & "'," & gAnbarSN)
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            '.SQLOrderBy = " KalaNO "
            'With .Fields
            '  .Add("KalaNo")
            '  .Add("KalaDs")
            '  .Add("VahedeSanjeshDs")
            'End With
            '.Refresh()
            picDVGrid.Visible = True
            btnExcel.Enabled = True
            btnShowHideCols.Enabled = True
        End With

    End Sub

    Private Sub cmdShowHideCols_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnShowHideCols.Click
        ' جهت استفاده از کليد تنظيم نمايش ستون هاي گريد اطلاعات
        Minoo.Grid.ShowFormSelectCols(DVrpt, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer,
                                       Me.Name + "/" + CStr(gNoeAnbarSN), Me)
    End Sub

    Private Sub cmdExcel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnExcel.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DVrpt.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub DVrpt_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) Handles DVrpt.CommandClick
        Select Case aCommand
            Case EnumCommands.cmRefresh
                DataLoad()
        End Select
    End Sub

    Private Sub DVrpt_GetGridProperties() Handles DVrpt.GetGridProperties
        Minoo.Grid.LoadColsSetting(DVrpt, Me.Name + "/" + CStr(gNoeAnbarSN), tp, gSM.UserID, VB6.GetEXEName)

    End Sub


End Class
