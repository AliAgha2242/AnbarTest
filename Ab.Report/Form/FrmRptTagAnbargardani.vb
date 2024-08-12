'Author ::زهره ايزدپناه
'CreateDate :: 88/01/31
'ModifiedDate::
'Description:: 
'System ::انبار

Enum NOE_REPORT
    'TagPars = 0
    'TagPars2 = 1
    'TagGhasem = 2
    'tagKhoram = 3
    'tagWithoutRahgiri = 4

    TagGhasemWithRahgiri = 0
    tagGhasemWithoutRahgiri = 1
    TagPars = 2
    TagParsWithChideman = 3
    tagKhoram = 4

End Enum

Friend Class FrmRptTagAnbargardani
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
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dcbNoeReport As NetSql.Components.DataCombo
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dcbNoeReport = New NetSql.Components.DataCombo(Me.components)
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add(Me.txtDesc)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.TextBox1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.dcbNoeReport)
        Me.Frame1.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.Frame1.Controls.Add(Me.btnOk)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(633, 106)
        Me.Frame1.TabIndex = 0
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.Location = New System.Drawing.Point(327, 51)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(186, 21)
        Me.txtDesc.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(558, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(29, 14)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "گروه"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(525, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(27, 21)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = "1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(558, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(63, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "نوع گزارش "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dcbNoeReport
        '
        Me.dcbNoeReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeReport.AutoSelectFirst = False
        Me.dcbNoeReport.BackColor = System.Drawing.Color.White
        Me.dcbNoeReport.BoundText = Nothing
        Me.dcbNoeReport.BypassChangeEvent = False
        Me.dcbNoeReport.DisplayText = ""
        Me.dcbNoeReport.Items.AddRange(New Object() {"تگ قاسم با رهگیری", "تگ قاسم بدون رهگیری", "تگ پارس", "تگ پارس با چيدمان", "تگ خرمدره"})
        Me.dcbNoeReport.LateBindingTop = "100"
        Me.dcbNoeReport.Location = New System.Drawing.Point(228, 21)
        Me.dcbNoeReport.MemFilter = ""
        Me.dcbNoeReport.Name = "dcbNoeReport"
        Me.dcbNoeReport.SeparatedData = Nothing
        Me.dcbNoeReport.Size = New System.Drawing.Size(324, 21)
        Me.dcbNoeReport.Source = Nothing
        Me.dcbNoeReport.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeReport.TabIndex = 37
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(99, 9)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 3
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(6, 9)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "مشاهده گزارش"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'FrmRptTagAnbargardani
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(633, 106)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "FrmRptTagAnbargardani"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش چاپ تگ انبارگرداني"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptTagAnbargardani
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptTagAnbargardani
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptTagAnbargardani
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmRptTagAnbargardani)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variables"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region

    Private Sub btnOk_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnOk.Click
        'Dim vFromDate As String
        'Dim vToDate As String
        Dim vErrMsg As String
        Dim strAnbars As String
        Dim vKalaPhizikiMode As Short
        Dim vStrKalaSN As String

        If dcbNoeReport.SelectedIndex = - 1 Then
            dcbNoeReport.SelectedIndex = NOE_REPORT.TagGhasemWithRahgiri
        End If

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr (gAnbarSN)
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            If Trim (gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If

            With VFilterAsnadAnbar
                If .SelectedKalaGardeshDar = 1 Then
                    vKalaPhizikiMode = 1
                ElseIf .SelectedKalaMandehDar = 1 Then
                    vKalaPhizikiMode = 2
                ElseIf Trim (.SelectedKalaGardeshAll) <> "" Then
                    vKalaPhizikiMode = 3
                End If

                If Trim (.SelectedKalaSN) <> "" Then
                    vStrKalaSN = .SelectedKalaSN
                End If

            End With

            Me.Cursor = Cursors.WaitCursor

            Select Case dcbNoeReport.SelectedIndex
                Case NOE_REPORT.TagPars

                    Dim vRptTagAnbarGardaniPars As New Minoo.Applications.Anbar.report.RptTagAnbarGardaniPars
                    With vRptTagAnbarGardaniPars
                        .DefField()
                        .DataSource = _
                            cn.SPQuery ("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars, _
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)

                        .txtSherkat.Text = gAnbarDS
                        .lblVahedeTejariDS.Text = gVahedeTejariDs
                        .txtSherkat1.Text = gAnbarDS
                        .lblVahedeTejariDS1.Text = gVahedeTejariDs
                        .txtSherkat2.Text = gAnbarDS
                        .lblVahedeTejariDS2.Text = gVahedeTejariDs

                        Minoo.Reports.FTReportViewer.ShowReport (vRptTagAnbarGardaniPars, Me.MdiParent)

                    End With

                Case NOE_REPORT.TagParsWithChideman

                    Dim vRptTagAnbarGardaniPars2 As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniPars2
                    With vRptTagAnbarGardaniPars2
                        .DefField()
                        .DataSource = _
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars, _
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)

                        .txtSherkat.Text = gAnbarDS
                        .lblVahedeTejariDS.Text = gVahedeTejariDs
                        .txtSherkat1.Text = gAnbarDS
                        .lblVahedeTejariDS1.Text = gVahedeTejariDs
                        .txtSherkat2.Text = gAnbarDS
                        .lblVahedeTejariDS2.Text = gVahedeTejariDs
                        .txtDesc.Text = txtDesc.Text
                        .txtdesc1.Text = txtDesc.Text
                        .txtDesc2.Text = txtDesc.Text

                        Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniPars2, Me.MdiParent)

                    End With

                Case NOE_REPORT.TagGhasemWithRahgiri

                    Dim vRptTagAnbarGardaniGhasem As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniGhasem
                    With vRptTagAnbarGardaniGhasem
                        .DefField()
                        .DataSource = _
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars, _
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS
                        .txtSherkat3.Text = gAnbarDS
                        .txtSal.Text = gHesabdariSal
                        .txtSal2.Text = gHesabdariSal
                        .txtSal3.Text = gHesabdariSal
                        Try
                            Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniGhasem, Me.MdiParent)
                        Catch ex As Exception
                        End Try
                    End With
                Case NOE_REPORT.tagGhasemWithoutRahgiri
                    Dim vRptTagAnbarGardaniGhasem As New Minoo.Applications.Anbar.Report.RptTagAnbarGardaniGhasem
                    With vRptTagAnbarGardaniGhasem
                        .DefField()
                        .DataSource = _
                            cn.SPQuery("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars, _
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS
                        .txtSherkat3.Text = gAnbarDS
                        .txtSal.Text = gHesabdariSal
                        .txtSal2.Text = gHesabdariSal
                        .txtSal3.Text = gHesabdariSal
                        Try
                            Minoo.Reports.FTReportViewer.ShowReport(vRptTagAnbarGardaniGhasem, Me.MdiParent)
                        Catch ex As Exception
                        End Try
                    End With

                Case NOE_REPORT.tagKhoram
                    Dim vRptTagAnbarGardaniPars As New Minoo.Applications.Anbar.Report.RptTagAnbarGardanikhoram
                    With vRptTagAnbarGardaniPars
                        .DefField()
                        .DataSource = _
                            cn.SPQuery ("_abSpr_TagAnbargardani", gHesabdariSalFDate, gHesabdariSalTDate, strAnbars, _
                                        gVahedeTejariSN, vStrKalaSN, vKalaPhizikiMode, dcbNoeReport.SelectedIndex)
                        .txtSherkat.Text = gAnbarDS
                        .txtSherkat1.Text = gAnbarDS
                        .txtSherkat2.Text = gAnbarDS

                        Minoo.Reports.FTReportViewer.ShowReport (vRptTagAnbarGardaniPars, Me.MdiParent)

                    End With

                    Me.Cursor = Cursors.Default

                Case Else
                    NetSql.Common.CSystem.MsgBox("نوع گزارش نامشخص است", _
                               MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                               MsgBoxStyle.MsgBoxRight, Me.Text)
            End Select

        End If

    End Sub

    Private Sub FrmRptTagAnbargardani_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        dcbNoeReport.SelectedIndex = NOE_REPORT.TagGhasemWithRahgiri

        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = True
            .init()
            .SetProperty()
        End With

    End Sub

    Private Sub CmdSelectAnbars_Click (ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowSelectAnbar (Me)
    End Sub

    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        With VFilterAsnadAnbar
            .VisibleKala = True
            .VisibleKalaWhere = True
            .VisibleAnbar = True
            .ShowDialog (Me)
        End With
    End Sub

    Private Sub dcbNoeReport_SelectedIndexChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles dcbNoeReport.SelectedIndexChanged
        If dcbNoeReport.SelectedIndex = NOE_REPORT.TagParsWithChideman Then
            txtDesc.Visible = True
            txtDesc.Text = ""
        Else
            txtDesc.Visible = False
            txtDesc.Text = ""
        End If
    End Sub

End Class
