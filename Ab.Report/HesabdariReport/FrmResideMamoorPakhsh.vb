'Author ::سيد محمود قاسمي 
'CreateDate :: 1384/06/02
'ModifiedDate::
'Description:: گزارش برگه رسيد مامور پخش
'System ::انبار
Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum

Imports VB = Microsoft.VisualBasic

Friend Class FrmResideMamoorPakhsh
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
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents dcbMamoorPakhsh As NetSql.Components.DataCombo
    Public WithEvents btnPrint1 As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.dcbMamoorPakhsh = New NetSql.Components.DataCombo(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.CmdSelectAnbars = New System.Windows.Forms.Button()
        Me.dcbNoeAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.fraExit = New System.Windows.Forms.Panel()
        Me.btnPrint1 = New System.Windows.Forms.Button()
        Me.btnShowHideCols = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.picDVGrid = New System.Windows.Forms.Panel()
        Me.Frame1.SuspendLayout()
        Me.fraExit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add(Me.dcbMamoorPakhsh)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.btnOk)
        Me.Frame1.Controls.Add(Me.CmdSelectAnbars)
        Me.Frame1.Controls.Add(Me.dcbNoeAnbarSN)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(762, 100)
        Me.Frame1.TabIndex = 16
        '
        'dcbMamoorPakhsh
        '
        Me.dcbMamoorPakhsh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbMamoorPakhsh.AutoSelectFirst = False
        Me.dcbMamoorPakhsh.BackColor = System.Drawing.Color.White
        Me.dcbMamoorPakhsh.BoundText = Nothing
        Me.dcbMamoorPakhsh.BypassChangeEvent = False
        Me.dcbMamoorPakhsh.DisplayText = ""
        Me.dcbMamoorPakhsh.LateBindingTop = "100"
        Me.dcbMamoorPakhsh.Location = New System.Drawing.Point(310, 50)
        Me.dcbMamoorPakhsh.MemFilter = ""
        Me.dcbMamoorPakhsh.Name = "dcbMamoorPakhsh"
        Me.dcbMamoorPakhsh.SeparatedData = Nothing
        Me.dcbMamoorPakhsh.Size = New System.Drawing.Size(320, 25)
        Me.dcbMamoorPakhsh.Source = Nothing
        Me.dcbMamoorPakhsh.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbMamoorPakhsh.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(641, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "مامور پخش"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(12, 8)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(91, 71)
        Me.btnOk.TabIndex = 41
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
        Me.CmdSelectAnbars.Location = New System.Drawing.Point(182, 8)
        Me.CmdSelectAnbars.Name = "CmdSelectAnbars"
        Me.CmdSelectAnbars.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmdSelectAnbars.Size = New System.Drawing.Size(91, 43)
        Me.CmdSelectAnbars.TabIndex = 40
        Me.CmdSelectAnbars.Text = "انتخاب انبار"
        Me.CmdSelectAnbars.UseVisualStyleBackColor = False
        '
        'dcbNoeAnbarSN
        '
        Me.dcbNoeAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeAnbarSN.AutoSelectFirst = False
        Me.dcbNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dcbNoeAnbarSN.BoundText = Nothing
        Me.dcbNoeAnbarSN.BypassChangeEvent = False
        Me.dcbNoeAnbarSN.DisplayText = ""
        Me.dcbNoeAnbarSN.LateBindingTop = "100"
        Me.dcbNoeAnbarSN.Location = New System.Drawing.Point(385, 9)
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
        Me.Label5.Location = New System.Drawing.Point(641, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "نوع انبار "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(86, 8)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(91, 43)
        Me.btnFilterAsnadAnbar.TabIndex = 44
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(332, 451)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(437, 46)
        Me.pnlC.TabIndex = 22
        '
        'fraExit
        '
        Me.fraExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraExit.BackColor = System.Drawing.SystemColors.Control
        Me.fraExit.Controls.Add(Me.btnPrint1)
        Me.fraExit.Controls.Add(Me.btnShowHideCols)
        Me.fraExit.Controls.Add(Me.btnExcel)
        Me.fraExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.fraExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.fraExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraExit.Location = New System.Drawing.Point(93, 451)
        Me.fraExit.Name = "fraExit"
        Me.fraExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fraExit.Size = New System.Drawing.Size(228, 46)
        Me.fraExit.TabIndex = 23
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint1.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrint1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPrint1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint1.Location = New System.Drawing.Point(161, 1)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPrint1.Size = New System.Drawing.Size(68, 44)
        Me.btnPrint1.TabIndex = 14
        Me.btnPrint1.Text = "چاپ کامل"
        Me.btnPrint1.UseVisualStyleBackColor = False
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
        Me.btnShowHideCols.Location = New System.Drawing.Point(4, 1)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size(68, 44)
        Me.btnShowHideCols.TabIndex = 10
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
        Me.btnExcel.Location = New System.Drawing.Point(83, 1)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size(68, 44)
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
        Me.pnlN.Location = New System.Drawing.Point(0, 451)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(89, 46)
        Me.pnlN.TabIndex = 24
        '
        'picDVGrid
        '
        Me.picDVGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDVGrid.AutoSize = True
        Me.picDVGrid.BackColor = System.Drawing.SystemColors.Control
        Me.picDVGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDVGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDVGrid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.picDVGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picDVGrid.Location = New System.Drawing.Point(0, 105)
        Me.picDVGrid.Name = "picDVGrid"
        Me.picDVGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picDVGrid.Size = New System.Drawing.Size(778, 340)
        Me.picDVGrid.TabIndex = 21
        '
        'FrmResideMamoorPakhsh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(766, 499)
        Me.Controls.Add(Me.pnlC)
        Me.Controls.Add(Me.fraExit)
        Me.Controls.Add(Me.pnlN)
        Me.Controls.Add(Me.picDVGrid)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.Name = "FrmResideMamoorPakhsh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش رسيد مامور پخش"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.fraExit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmResideMamoorPakhsh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmResideMamoorPakhsh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmResideMamoorPakhsh
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmResideMamoorPakhsh)
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
        Dim vSql As String
        Dim vFromSql As String
        Dim vWhereSql As String
        Dim vGroupSql As String
        Dim vOrderSql As String

        Dim vErrMsg As String
        Dim strAnbars, strNoeAnbars, vFromDate, vToDate As Object
        Dim vMamoorPakhshSN As Decimal

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

        If Trim (dcbMamoorPakhsh.BoundText) <> "" Then
            vMamoorPakhshSN = dcbMamoorPakhsh.BoundText
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            vWhereSql = " ( abVw_rptResideMamoorPakhsh.NoeAnbarSN = " + strNoeAnbars + " ) "
            If Trim (gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If
            If vMamoorPakhshSN <> 0 Then
                vWhereSql = vWhereSql + " AND abVw_rptResideMamoorPakhsh.MamoorPakhshSN = " & vMamoorPakhshSN
            End If
            If Trim (strAnbars) <> "" Then
                vWhereSql = vWhereSql + " AND (abVw_rptResideMamoorPakhsh.AnbarSN IN ( " + strAnbars + " )) "
            End If

            If Trim (VFilterAsnadAnbar.WhereConditionSanadDate) <> "" Then
                vWhereSql = vWhereSql + " AND  " & VFilterAsnadAnbar.WhereConditionSanadDate
            End If
            If Trim (VFilterAsnadAnbar.WhereConditionSanadStatus) <> "" Then
                vWhereSql = vWhereSql + " AND  " & VFilterAsnadAnbar.WhereConditionSanadStatus
            End If

            vOrderSql = "  VahedeTejariDs, AnbarDs, NoeAnbarDs , MamoorPakhshNO , FactorNO "

            With DViewer
                .AutoFetchCurrentRow = False
                .TableName = "abVw_rptResideMamoorPakhsh"
                .AccessRight = EnumAccessRight.arView
                .SQLWhere = vWhereSql
                '        InputBox("dd", "t", vWhereSql)
                .SQLOrderBy = vOrderSql
            End With
            picDVGrid.Visible = False
            DViewer.Refresh()
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

    Private Sub FrmResideMamoorPakhsh_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSql As String
        Dim i, li_counter As Short
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

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT MamoorPakhshSN, MamoorPakhshNo + ' _ ' +  MamoorPakhshDS AS MamoorPakhshDS " & _
               " From toMamoorPakhsh "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbMamoorPakhsh.Bind(cn, vSql, "MamoorPakhshSN", "MamoorPakhshDS")

        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DViewer = New CDataView(cn)
        With DViewer
            .Init(picDVGrid, , pnlC, pnlN, gEnumButtonOptionsReports)
        End With

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = False
            ' تهيه تاريخ از سرور
            .SelectedFromSanadDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                                 cn, _
                                                                                                 Functions. _
                                                                                                    FTDBCommonFunctions. _
                                                                                                    enmDateFormat.Normal)
            .SelectedToSanadDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                               cn, _
                                                                                               Functions. _
                                                                                                  FTDBCommonFunctions. _
                                                                                                  enmDateFormat.Normal)
            .init()
        End With


        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .WhereConditionColumnSanadStatus = " abVw_rptResideMamoorPakhsh.SanadStatus "
            .WhereConditionColumnSanadDate = " abVw_rptResideMamoorPakhsh.MoaserDate "
            '      .WhereConditionColumnSanadNO = " abVw_rptResideMamoorPakhsh.SanadNO "
            '      .WhereConditionColumnTarakonesh = " CONVERT(VARCHAR(10),abVw_rptResideMamoorPakhsh.TarakoneshSN) "
            .SetProperty()
        End With
        'VFilterAsnadAnbar 
    End Sub

    Private Sub FrmResideMamoorPakhsh_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DViewer.Done()
        DViewer = Nothing
    End Sub

    Private Sub cmdShowHideCols_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnShowHideCols.Click
        ' جهت استفاده از کليد تنظيم نمايش ستون هاي گريد اطلاعات
        Dim strNoeAnbars As Object
        If Trim(dcbNoeAnbarSN.BoundText) <> "" Then
            strNoeAnbars = dcbNoeAnbarSN.BoundText
        End If
        Minoo.Grid.ShowFormSelectCols(DViewer, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer, _
                                       Me.Name + "/" + strNoeAnbars, Me)
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

    Private Sub DViewer_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DViewer.CommandClick
        Select Case aCommand
            Case EnumCommands.cmRefresh
                btnOk_Click(Me, New System.EventArgs)
        End Select

    End Sub


    Private Sub btnFilterAsnadAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            If Trim(dcbNoeAnbarSN.BoundText) <> "" Then
                .FilterNoeAnbarSN = dcbNoeAnbarSN.BoundText
            End If
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub DViewer_GetGridProperties() Handles DViewer.GetGridProperties
        Dim strNoeAnbars As Object

        ' امکان انتخاب گروهي فعال گردد
        ' جهت استفاده از انتخاب گروهي در خروجي گزارش
        With DViewer.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With


        If Trim(dcbNoeAnbarSN.BoundText) <> "" Then
            strNoeAnbars = dcbNoeAnbarSN.BoundText
        End If
        Minoo.Grid.LoadColsSetting(DViewer, Me.Name + "/" + strNoeAnbars, tp, gSM.UserID, VB6.GetEXEName)
        With DViewer
            .Fields("VahedeTejariSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("AnbarSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("NoeAnbarSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("SanadSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("TarakoneshSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("MamoorPakhshSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("FactorSN").FieldOptions = EnumFieldOptions.foHidden
            .Fields("KalaSN").FieldOptions = EnumFieldOptions.foHidden
        End With

        '  اضافه نمودن سرجمع ستونها
        With DViewer.FlexGrid
            ' جهت شرح فارسي ستونها           '.FormatString = Replace("|نام شعبه|نام تامين کننده|گروه|صنف|مانده |vahedetejarisn|", "|", vbTab)
            .Subtotal(SubtotalSettings.Clear)
            .SubtotalPosition = SubtotalPositionSettings.BelowData
            If DViewer.Fields.HasField("MeghdareVaredeh") Then _
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("MeghdareVaredeh"), "#,#", _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
            If DViewer.Fields.HasField("KalaFee") Then _
                .Subtotal(SubtotalSettings.Sum, -1, .ColIndex("KalaFee"), "#,#", _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), _
                           System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), False, "مجموع", 0, True)
            DViewer.LoadGridUserSettings()
            Minoo.Grid.LoadColsSetting(DViewer, Me.Name, tp, gSM.UserID, VB6.GetEXEName)
        End With

    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        Dim vRptResideMamoorPakhsh As New RptResideMamoorPakhsh

        Dim vSql As String
        Dim vFromSql As String
        Dim vWhereSql As String
        Dim vGroupSql As String
        Dim vOrderSql As String

        Dim vErrMsg As String
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim strAnbars, strNoeAnbars
        Dim vMamoorPakhshSN As Decimal

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(VFilterAsnadAnbar.SelectedFromSanadDate) <> "" Then
            vFromDate = Trim(VFilterAsnadAnbar.SelectedFromSanadDate)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(VFilterAsnadAnbar.SelectedToSanadDate) <> "" Then
            vToDate = Trim(VFilterAsnadAnbar.SelectedToSanadDate)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr(gAnbarSN)
        End If

        If Trim(dcbNoeAnbarSN.BoundText) = "" Then
            vErrMsg = vErrMsg & "نوع انبار مشخص نشده است" & vbCrLf
        Else
            strNoeAnbars = dcbNoeAnbarSN.BoundText
        End If

        If Trim(dcbMamoorPakhsh.BoundText) <> "" Then
            vMamoorPakhshSN = dcbMamoorPakhsh.BoundText
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            vWhereSql = " Where ( abVw_rptResideMamoorPakhsh.NoeAnbarSN = " + strNoeAnbars + " ) "
            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If
            If vMamoorPakhshSN <> 0 Then
                vWhereSql = vWhereSql + " AND abVw_rptResideMamoorPakhsh.MamoorPakhshSN = " & vMamoorPakhshSN
            End If
            If Trim(strAnbars) <> "" Then
                vWhereSql = vWhereSql + " AND (abVw_rptResideMamoorPakhsh.AnbarSN IN ( " + strAnbars + " )) "
            End If
            If Trim(VFilterAsnadAnbar.WhereConditionSanadStatus) <> "" Then
                vWhereSql = vWhereSql + " AND  " & VFilterAsnadAnbar.WhereConditionSanadStatus
            End If
            If Trim(VFilterAsnadAnbar.WhereConditionSanadDate) <> "" Then
                vWhereSql = vWhereSql + " AND  " & VFilterAsnadAnbar.WhereConditionSanadDate
            End If

            vSql = " SELECT Top 100 Percent " & _
                   " VahedeTejariDs , AnbarDs, NoeAnbarDs , MamoorPakhshSN  " & _
                   " , MamoorPakhshNO + ' _ ' +  MamoorPakhshDS AS  MamoorPakhshNO_DS  , MoaserDate " & _
                   " ,FactorNO  ,SodoorDate ,MoshtariNo + ' _ ' + MoshtariName + ' _ ' + MoshtariFamily  AS FullName  " & _
                   " , Sum(ISNULL(KalaFee,0)) AS  Sum_KalaFee ,TarakoneshDs "

            vFromSql = " From abVw_rptResideMamoorPakhsh   "
            vGroupSql = " Group by  VahedeTejariDs , AnbarDs, NoeAnbarDs " & _
                        " , MamoorPakhshSN , MamoorPakhshNO , MamoorPakhshDS , MoaserDate " & _
                        " , FactorNO  ,SodoorDate ,MoshtariNo , MoshtariName , MoshtariFamily  ,TarakoneshDs "
            vOrderSql = "  Order by VahedeTejariDs, AnbarDs, NoeAnbarDs , MamoorPakhshSN , FactorNO  "

            vSql = vSql & vFromSql & vWhereSql & vGroupSql & vOrderSql
            With vRptResideMamoorPakhsh
                .DefField()
                If gVahedeTejariSN = 18.935 Or gVahedeTejariSN = 17.935 Then
                    .PageSettings.PaperKind = Printing.PaperKind.Custom
                    .PageSettings.PaperHeight = .CmToInch(28)
                    .PageSettings.PaperWidth = .CmToInch(28)
                    .PageSettings.Margins.Top = 0
                    .PageSettings.Margins.Left = 0
                    .PageSettings.Margins.Right = 0
                Else
                    .PageSettings.PaperKind = Printing.PaperKind.Custom
                    .PageSettings.PaperWidth = .CmToInch(25.5)
                    ' 10
                    .PageSettings.PaperHeight = .CmToInch(27.5)
                    ' 11
                    .PageSettings.Margins.Top = 0
                    .PageSettings.Margins.Left = 0
                    .PageSettings.Margins.Right = 0
                    .PageSettings.Margins.Bottom = 0.5
                End If
                .DataSource = cn.ExecuteQuery(vSql)
                Try
                    Minoo.Reports.FTReportViewer.ShowReport(vRptResideMamoorPakhsh, Me.MdiParent)
                Catch ex As Exception
                    .PageSettings.PaperKind = Printing.PaperKind.A4
                    Minoo.Reports.FTReportViewer.ShowReport(vRptResideMamoorPakhsh, Me.MdiParent)
                End Try
            End With
            ' -----------
            Me.Cursor = System.Windows.Forms.Cursors.Default()
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub
End Class
