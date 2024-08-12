' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description:: 
'System ::انبار

' Public Class FrmControlKardex
Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum

Imports VB = Microsoft.VisualBasic

Friend Class FrmControlKardex
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
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents CmdSelectAnbars As System.Windows.Forms.Button
    Public WithEvents dcbNoeAnbarSN As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents fraExit As System.Windows.Forms.Panel
    Public WithEvents btnShowHideCols As System.Windows.Forms.Button
    Public WithEvents btnExcel As System.Windows.Forms.Button
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents picDVGrid As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.CmdSelectAnbars = New System.Windows.Forms.Button()
        Me.dcbNoeAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.fraExit = New System.Windows.Forms.Panel()
        Me.btnShowHideCols = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.picDVGrid = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Frame1.SuspendLayout()
        Me.fraExit.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.Frame1.Controls.Add(Me.btnOk)
        Me.Frame1.Controls.Add(Me.CmdSelectAnbars)
        Me.Frame1.Controls.Add(Me.dcbNoeAnbarSN)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(756, 100)
        Me.Frame1.TabIndex = 0
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(217, 11)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(91, 44)
        Me.btnFilterAsnadAnbar.TabIndex = 3
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(12, 11)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(91, 71)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "مشاهده گزارش"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'CmdSelectAnbars
        '
        Me.CmdSelectAnbars.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSelectAnbars.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSelectAnbars.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSelectAnbars.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSelectAnbars.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdSelectAnbars.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmdSelectAnbars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSelectAnbars.Location = New System.Drawing.Point(316, 11)
        Me.CmdSelectAnbars.Name = "CmdSelectAnbars"
        Me.CmdSelectAnbars.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmdSelectAnbars.Size = New System.Drawing.Size(90, 44)
        Me.CmdSelectAnbars.TabIndex = 2
        Me.CmdSelectAnbars.Text = "انتخاب انبار"
        Me.CmdSelectAnbars.UseVisualStyleBackColor = False
        '
        'dcbNoeAnbarSN
        '
        Me.dcbNoeAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeAnbarSN.AutoSelectFirst = True
        Me.dcbNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dcbNoeAnbarSN.BoundText = Nothing
        Me.dcbNoeAnbarSN.BypassChangeEvent = False
        Me.dcbNoeAnbarSN.DisplayText = ""
        Me.dcbNoeAnbarSN.LateBindingTop = "100"
        Me.dcbNoeAnbarSN.Location = New System.Drawing.Point(414, 21)
        Me.dcbNoeAnbarSN.MemFilter = ""
        Me.dcbNoeAnbarSN.Name = "dcbNoeAnbarSN"
        Me.dcbNoeAnbarSN.SeparatedData = Nothing
        Me.dcbNoeAnbarSN.Size = New System.Drawing.Size(252, 25)
        Me.dcbNoeAnbarSN.Source = Nothing
        Me.dcbNoeAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeAnbarSN.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(670, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "نوع انبار "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(170, 449)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(590, 46)
        Me.pnlC.TabIndex = 2
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
        Me.fraExit.Location = New System.Drawing.Point(18, 449)
        Me.fraExit.Name = "fraExit"
        Me.fraExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fraExit.Size = New System.Drawing.Size(148, 46)
        Me.fraExit.TabIndex = 3
        '
        'btnShowHideCols
        '
        Me.btnShowHideCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowHideCols.BackColor = System.Drawing.Color.Transparent
        Me.btnShowHideCols.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowHideCols.Enabled = False
        Me.btnShowHideCols.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowHideCols.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnShowHideCols.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowHideCols.Location = New System.Drawing.Point(4, 0)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size(68, 44)
        Me.btnShowHideCols.TabIndex = 1
        Me.btnShowHideCols.Text = "تنظيم"
        Me.btnShowHideCols.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.Enabled = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point(76, 0)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size(68, 44)
        Me.btnExcel.TabIndex = 0
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
        Me.pnlN.Location = New System.Drawing.Point(4, 449)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(6, 46)
        Me.pnlN.TabIndex = 4
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
        Me.picDVGrid.Location = New System.Drawing.Point(4, 109)
        Me.picDVGrid.Name = "picDVGrid"
        Me.picDVGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picDVGrid.Size = New System.Drawing.Size(756, 334)
        Me.picDVGrid.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlC)
        Me.Panel1.Controls.Add(Me.fraExit)
        Me.Panel1.Controls.Add(Me.pnlN)
        Me.Panel1.Controls.Add(Me.picDVGrid)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 499)
        Me.Panel1.TabIndex = 5
        '
        'FrmControlKardex
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(764, 499)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FirstFocusControl = Me.dcbNoeAnbarSN
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.Name = "FrmControlKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش کنترل کاردکس"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.fraExit.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmControlKardex
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmControlKardex
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmControlKardex
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmControlKardex)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  خروجي گزارش تعريف شده است
    Private WithEvents DViewer As CDataView

  ' يک نمونه از فيلتر گزارشات انبار براي استفاده در فيلتر گزارش
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

    Private Sub CmdSelectAnbars_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles CmdSelectAnbars.Click
        ShowSelectAnbar (Me)
    End Sub

    Private Sub btnOk_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnOk.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String
        Dim strAnbars, strNoeAnbars As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN As String
        Dim vSanadStatus As String

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim (VFilterAsnadAnbar.SelectedFromSanadDate) <> "" Then
            vFromDate = Trim (VFilterAsnadAnbar.SelectedFromSanadDate)
        Else
            vErrMsg = vErrMsg & Chr (13) & "از تاريخ مشخص نشده است"
        End If
        If Trim (VFilterAsnadAnbar.SelectedToSanadDate) <> "" Then
            vToDate = Trim (VFilterAsnadAnbar.SelectedToSanadDate)
        Else
            vErrMsg = vErrMsg & Chr (13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr (gAnbarSN)
        End If
        If Trim (dcbNoeAnbarSN.BoundText) = "" Then
            vErrMsg = vErrMsg & "نوع انبار مشخص نشده است" & vbCrLf
        Else
            strNoeAnbars = dcbNoeAnbarSN.BoundText
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Trim (gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
                If InStr (strAnbars, ",") >= 1 Then
                    NetSql.Common.CSystem.MsgBox("فقط يک انبار قابل انتخاب است")
                    Exit Sub
                End If
            End If
            If Trim(VFilterAsnadAnbar.SelectedSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus
            End If
            If Trim(VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If
            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            With DViewer
                .AccessRight = EnumAccessRight.arView
                .AutoFetchCurrentRow = False
                .QueryName = "abQueryControlKardex"
                ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                ' Yes
                .DataSource = cn.SPQuery("_abSpr_ControlKardex", vFromDate, vToDate, strAnbars, strNoeAnbars _
                                          , CStr(gVahedeTejariSN) _
                                          , vStrKalaSN, vSanadStatus, vStrFilterSelectedGoroohSN)
                Minoo.Grid.LoadColsSetting(DViewer, Me.Name, tp, gSM.UserID, VB6.GetEXEName)
            End With
            picDVGrid.Visible = True
            btnExcel.Enabled = True
            btnShowHideCols.Enabled = True
            Me.Cursor = System.Windows.Forms.Cursors.Default()
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub FrmControlKardex_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSql As String
        Dim i, vli_counter As Short
        Dim vCurMah As Short

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT NoeAnbarSN, NoeAnbarDS From abNoeAnbar "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbNoeAnbarSN.Bind(cn, vSql, "NoeAnbarSN", "NoeAnbarDS")
        With dcbNoeAnbarSN
            If gNoeAnbarSN <> 0 Then
                .BoundText = CStr(gNoeAnbarSN * 1.0)
                .Enabled = False
            Else
                .Enabled = True
            End If
        End With

        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DViewer = New CDataView(cn)
        With DViewer
            .Init(picDVGrid, , pnlC, pnlN, gEnumButtonOptionsReports)
        End With

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = False
            .CheckedSanadStatus_4 = False
            .CheckedSanadStatus_8 = True
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .SetProperty()
        End With


    End Sub

    Private Sub FrmControlKardex_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DViewer.Done()
        DViewer = Nothing
    End Sub

    Private Sub cmdShowHideCols_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnShowHideCols.Click
        ' جهت استفاده از کليد تنظيم نمايش ستون هاي گزارش
        Dim vstrNoeAnbars As Object
        If Trim(dcbNoeAnbarSN.BoundText) <> "" Then
            vstrNoeAnbars = dcbNoeAnbarSN.BoundText
        End If
        Minoo.Grid.ShowFormSelectCols(DViewer, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer, _
                                       Me.Name + "/" + vstrNoeAnbars, Me)
    End Sub

    Private Sub cmdExcel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnExcel.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DViewer.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub DViewer_GetGridProperties() Handles DViewer.GetGridProperties
        Dim vstrNoeAnbars As Object
        ' امکان انتخاب گروهي فعال گردد
        ' جهت استفاده از انتخاب گروهي در خروجي گزارش
        With DViewer.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With

        If Trim (dcbNoeAnbarSN.BoundText) <> "" Then
            vstrNoeAnbars = dcbNoeAnbarSN.BoundText
        End If

        Minoo.Grid.LoadColsSetting (DViewer, Me.Name + "/" + vstrNoeAnbars, tp, gSM.UserID, VB6.GetEXEName)
        '  اضافه نمودن سرجمع ستونها
        With DViewer.FlexGrid
            ' جهت شرح فارسي ستونها           '.FormatString = Replace("|نام شعبه|نام تامين کننده|گروه|صنف|مانده |vahedetejarisn|", "|", vbTab)
            .Subtotal(SubtotalSettings.Clear)
            .SubtotalPosition = SubtotalPositionSettings.BelowData
            If DViewer.Fields.HasField("MeghdareVaredeh") Then _
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("MeghdareVaredeh"), "#,#.###", _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
            If DViewer.Fields.HasField("MeghdareSadereh") Then _
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("MeghdareSadereh"), "#,#.###", _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
            If DViewer.Fields.HasField("Mojoodi") Then _
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("Mojoodi"), "#,#.###", _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
            DViewer.LoadGridUserSettings()
            Minoo.Grid.LoadColsSetting (DViewer, Me.Name, tp, gSM.UserID, VB6.GetEXEName)
        End With

    End Sub

    Private Sub DViewer_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DViewer.CommandClick
        Select Case aCommand
            Case EnumCommands.cmRefresh
                btnOk_Click (Me, New System.EventArgs)
        End Select

    End Sub


    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .VisibleShomarehRahgiri = False
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            If Trim (dcbNoeAnbarSN.BoundText) <> "" Then
                .FilterNoeAnbarSN = dcbNoeAnbarSN.BoundText
            End If
            .ShowDialog (Me)
        End With
    End Sub
End Class
