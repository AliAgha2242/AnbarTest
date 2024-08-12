' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description:: 
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Friend Class FrmKardexA
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents CmdSelectAnbars As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents dcbNoeAnbarSN As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Frame1 = New System.Windows.Forms.Panel
        Me.dcbNoeAnbarSN = New NetSql.Components.DataCombo (Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.CmdSelectAnbars = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add (Me.dcbNoeAnbarSN)
        Me.Frame1.Controls.Add (Me.Label5)
        Me.Frame1.Controls.Add (Me.btnFilterAsnadAnbar)
        Me.Frame1.Controls.Add (Me.btnOk)
        Me.Frame1.Controls.Add (Me.CmdSelectAnbars)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point (0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size (766, 148)
        Me.Frame1.TabIndex = 0
        '
        'dcbNoeAnbarSN
        '
        Me.dcbNoeAnbarSN.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.dcbNoeAnbarSN.AutoSelectFirst = True
        Me.dcbNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dcbNoeAnbarSN.BoundText = Nothing
        Me.dcbNoeAnbarSN.BypassChangeEvent = False
        Me.dcbNoeAnbarSN.DisplayText = ""
        Me.dcbNoeAnbarSN.LateBindingTop = "100"
        Me.dcbNoeAnbarSN.Location = New System.Drawing.Point (516, 12)
        Me.dcbNoeAnbarSN.MemFilter = ""
        Me.dcbNoeAnbarSN.Name = "dcbNoeAnbarSN"
        Me.dcbNoeAnbarSN.SeparatedData = Nothing
        Me.dcbNoeAnbarSN.Size = New System.Drawing.Size (189, 21)
        Me.dcbNoeAnbarSN.Source = Nothing
        Me.dcbNoeAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeAnbarSN.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point (708, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size (48, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "نوع انبار "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point (347, 6)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size (68, 35)
        Me.btnFilterAsnadAnbar.TabIndex = 3
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point (6, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size (68, 57)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "مشاهده گزارش"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'CmdSelectAnbars
        '
        Me.CmdSelectAnbars.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSelectAnbars.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSelectAnbars.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSelectAnbars.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdSelectAnbars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSelectAnbars.Location = New System.Drawing.Point (437, 6)
        Me.CmdSelectAnbars.Name = "CmdSelectAnbars"
        Me.CmdSelectAnbars.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmdSelectAnbars.Size = New System.Drawing.Size (68, 35)
        Me.CmdSelectAnbars.TabIndex = 2
        Me.CmdSelectAnbars.Text = "انتخاب انبار"
        Me.CmdSelectAnbars.UseVisualStyleBackColor = False
        '
        'FrmKardexA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (766, 148)
        Me.Controls.Add (Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FirstFocusControl = Me.dcbNoeAnbarSN
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (3, 22)
        Me.MaximizeBox = False
        Me.Name = "FrmKardexA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش كاردكس كالا"
        Me.Frame1.ResumeLayout (False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As FrmKardexA
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As FrmKardexA
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New FrmKardexA()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
    ' يک نمونه از فيلتر گزارشات انبار براي استفاده در فيلتر گزارش
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

    Private Sub btnOk_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnOk.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vRptKardexA As New RptKardexA
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String = ""
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
            End If
            If Trim (VFilterAsnadAnbar.SelectedSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus
            End If
            If Trim (VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If
            If Trim (VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If
            With vRptKardexA
                .DefField()
                Try
                    .PageSettings.PaperKind = Printing.PaperKind.Custom
                    .PageSettings.PaperWidth = 10
                    .PageSettings.PaperHeight = 11
                Catch ex As Exception
                    tp.LogStr (" خطا در تنظيم کاغذ " + ex.Message)
                End Try
                ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                ' Yes
                .DataSource = cn.SPQuery ("_abSpr_Kardex", vFromDate, vToDate, strAnbars, strNoeAnbars _
                                          , CStr (gVahedeTejariSN) _
                                          , vStrKalaSN, vSanadStatus, vStrFilterSelectedGoroohSN)
                Try
                    Minoo.Reports.FTReportViewer.ShowReport (vRptKardexA, Me.MdiParent)
                Catch ex As Exception
                    .PageSettings.PaperKind = Printing.PaperKind.A4
                    Minoo.Reports.FTReportViewer.ShowReport (vRptKardexA, Me.MdiParent)
                End Try
            End With
            Me.Cursor = Cursors.Default
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub FrmKardexA_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSql As String
        'Dim i, li_counter As Short
        'Dim vCurMah As Short

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT NoeAnbarSN, NoeAnbarDS From abNoeAnbar "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbNoeAnbarSN.Bind (cn, vSql, "NoeAnbarSN", "NoeAnbarDS")
        With dcbNoeAnbarSN
            If gNoeAnbarSN <> 0 Then
                .BoundText = CStr (gNoeAnbarSN*1.0)
                .Enabled = False
            Else
                .Enabled = True
            End If
        End With

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = True
            .init()
            .SetProperty()
        End With
    End Sub

    Private Sub CmdSelectAnbars_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CmdSelectAnbars.Click
        ShowSelectAnbar (Me)
    End Sub

    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
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
