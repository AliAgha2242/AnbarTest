'Author ::زهره ايزدپناه
'CreateDate :: 1387/10/20
'ModifiedDate::
'Description:: گزارش ليست کاردکس انبار
'System ::انبار

Imports VB = Microsoft.VisualBasic

Public Class FrmKardex
    Inherits JanusSimpleReport.frmRptJanusBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromSanadDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToSanadDate As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FraSanadStaus As System.Windows.Forms.GroupBox
    Friend WithEvents chkSanadStatus_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanadStatus_8 As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKardex))
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromSanadDate = New System.Windows.Forms.TextBox()
        Me.txtToSanadDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FraSanadStaus = New System.Windows.Forms.GroupBox()
        Me.chkSanadStatus_1 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_4 = New System.Windows.Forms.CheckBox()
        Me.chkSanadStatus_8 = New System.Windows.Forms.CheckBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.FraSanadStaus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.FraSanadStaus)
        Me.pnlF.Controls.Add(Me.FraSanadDate)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadStaus, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.TabIndex = 10
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 426)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.GroupTotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(1028, 426)
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.TotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.TotalRowFormatStyle.Key = "سرجمع"
        Me.GridEX1.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        Me.GridEX1.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'btnExcelList
        '
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.TabStop = False
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'dcbKala
        '
        Me.dcbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala.AutoSelectFirst = False
        Me.dcbKala.BackColor = System.Drawing.Color.White
        Me.dcbKala.BoundText = Nothing
        Me.dcbKala.BypassChangeEvent = False
        Me.dcbKala.DisplayText = ""
        Me.dcbKala.LateBindingTop = "100"
        Me.dcbKala.Location = New System.Drawing.Point(618, 3)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(327, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(950, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromSanadDate)
        Me.FraSanadDate.Controls.Add(Me.txtToSanadDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(458, 28)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(232, 39)
        Me.FraSanadDate.TabIndex = 11
        Me.FraSanadDate.TabStop = False
        '
        'txtFromSanadDate
        '
        Me.txtFromSanadDate.AcceptsReturn = True
        Me.txtFromSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSanadDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSanadDate.MaxLength = 0
        Me.txtFromSanadDate.Name = "txtFromSanadDate"
        Me.txtFromSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSanadDate.TabIndex = 0
        Me.txtFromSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSanadDate
        '
        Me.txtToSanadDate.AcceptsReturn = True
        Me.txtToSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSanadDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSanadDate.MaxLength = 0
        Me.txtToSanadDate.Name = "txtToSanadDate"
        Me.txtToSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSanadDate.TabIndex = 1
        Me.txtToSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(175, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "از"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(82, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(187, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadStaus
        '
        Me.FraSanadStaus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadStaus.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_1)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_4)
        Me.FraSanadStaus.Controls.Add(Me.chkSanadStatus_8)
        Me.FraSanadStaus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadStaus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadStaus.Location = New System.Drawing.Point(710, 26)
        Me.FraSanadStaus.Name = "FraSanadStaus"
        Me.FraSanadStaus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadStaus.Size = New System.Drawing.Size(276, 39)
        Me.FraSanadStaus.TabIndex = 12
        Me.FraSanadStaus.TabStop = False
        Me.FraSanadStaus.Text = "وضعيت"
        '
        'chkSanadStatus_1
        '
        Me.chkSanadStatus_1.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_1.Location = New System.Drawing.Point(119, 13)
        Me.chkSanadStatus_1.Name = "chkSanadStatus_1"
        Me.chkSanadStatus_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_1.Size = New System.Drawing.Size(81, 21)
        Me.chkSanadStatus_1.TabIndex = 0
        Me.chkSanadStatus_1.Text = "پيشنويس"
        Me.chkSanadStatus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_1.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_4
        '
        Me.chkSanadStatus_4.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_4.Location = New System.Drawing.Point(58, 13)
        Me.chkSanadStatus_4.Name = "chkSanadStatus_4"
        Me.chkSanadStatus_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_4.Size = New System.Drawing.Size(59, 21)
        Me.chkSanadStatus_4.TabIndex = 1
        Me.chkSanadStatus_4.Text = "موقت"
        Me.chkSanadStatus_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_4.UseVisualStyleBackColor = False
        '
        'chkSanadStatus_8
        '
        Me.chkSanadStatus_8.BackColor = System.Drawing.SystemColors.Control
        Me.chkSanadStatus_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.Checked = True
        Me.chkSanadStatus_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSanadStatus_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSanadStatus_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSanadStatus_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSanadStatus_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSanadStatus_8.Location = New System.Drawing.Point(1, 13)
        Me.chkSanadStatus_8.Name = "chkSanadStatus_8"
        Me.chkSanadStatus_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSanadStatus_8.Size = New System.Drawing.Size(55, 21)
        Me.chkSanadStatus_8.TabIndex = 2
        Me.chkSanadStatus_8.Text = "قطعي"
        Me.chkSanadStatus_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSanadStatus_8.UseVisualStyleBackColor = False
        '
        'FrmKardex
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ليست کاردکس کالا"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.FraSanadStaus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmKardex
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmKardex
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmKardex
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmKardex)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region

    Private Sub FrmKardexB_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        ''Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromSanadDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToSanadDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                                  cn,
                                                                                                  Functions.
                                                                                                     FTDBCommonFunctions _
                                                                                                     .enmDateFormat.
                                                                                                     Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                                                                         cn,
                                                                                         Functions.FTDBCommonFunctions.
                                                                                            enmDateFormat.Normal)

        End If

        ' تهيه سلکت براي مقدار دهي کامبو
        If gVahedeTejariSN = 9.935 Then
            vSql =
            "  SELECT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 "

        Else
            vSql =
            " SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " &
            gAnbarSelected.ToString & "  )  "

            'vSql =
            '    "  SELECT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " &
            '    gAnbarSelected.ToString & "  )  "
        End If
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")

        setColumnProperties()
        RefreshDataSet()


    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String
        Dim strAnbars As String
        Dim vKalaSN As String
        Dim vSanadStatus As String

        Dim frmWait As New Anbar.Common.Frmwait
        frmWait.Show()
        frmWait.Label3.Text = "...سیستم در حال گزارش گیری می باشد..."
        frmWait.Refresh()

        Try
            ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
            If Trim(dclFDate.Text) <> "" Then
                vFromDate = Trim(dclFDate.Value)
            Else
                vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
            End If

            If Trim(dclTDate.Text) <> "" Then
                vToDate = Trim(dclTDate.Value)
            Else
                vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
            End If

            If Trim(vFromDate) < Trim(gHesabdariSalFDate) Or Trim(vToDate) > Trim(gHesabdariSalTDate) Then
                vErrMsg = vErrMsg & Chr(13) & "تاريخ انتخابي خارج از سال مالي مي باشد"
            End If

            If gAnbarSN = 0 Then
                vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
            Else
                strAnbars = CStr(gAnbarSN)
            End If

            'If Trim(dcbKala.BoundText) <> "" OrElse Not dcbKala.BoundText Is Nothing Then
            '    vKalaSN = CStr(dcbKala.BoundText)
            'Else
            '    vErrMsg = vErrMsg & "کالا مشخص نشده است" & vbCrLf
            'End If
            ''ghasemi 14010720

            If dcbKala.BoundText <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If Not vKalaSN Is Nothing AndAlso vKalaSN.Length > 0 Then
                    vKalaSN = CStr(dcbKala.SelectedValue)
                Else
                    vKalaSN = CStr(dcbKala.SelectedValue)
                End If
            End If
            ''ghasemi 14010720

            ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
            If vErrMsg = "" Then

                vSanadStatus = ""
                If chkSanadStatus_1.CheckState = 1 Then _
                    vSanadStatus = vSanadStatus & IIf(vSanadStatus.Length > 0, ",1", "1")
                If chkSanadStatus_4.CheckState = 1 Then _
                    vSanadStatus = vSanadStatus & IIf(vSanadStatus.Length > 0, ",4", "4")
                If chkSanadStatus_8.CheckState = 1 Then _
                    vSanadStatus = vSanadStatus & IIf(vSanadStatus.Length > 0, ",8", "8")
                If Trim(vSanadStatus) = "" Then vSanadStatus = "1,4,8"

                Me.Cursor = Cursors.WaitCursor

                GridEX1.DataSource = cn.SPQuery("_abSpr_Kardex", vFromDate, vToDate, strAnbars, CStr(gVahedeTejariSN) _
                                                 , vKalaSN, vSanadStatus)
                'GridEX1.DataSource = cn.ExecuteQuery("Exec _abSpr_Kardex '', '" & vFromDate & "','" & vToDate & "','" & strAnbars & "','" & CStr(gVahedeTejariSN) & "'   ,'" & vKalaSN & "','" & vSanadStatus & "'")

                '      .ForeColor = IIf(vMandehKala < 0, Color.Red, Color.Black)

                'RefreshDataSet()
                Me.Cursor = Cursors.Default
            Else
                NetSql.Common.CSystem.MsgBox(vErrMsg,
                           MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                           MsgBoxStyle.MsgBoxRight, Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        Finally
            frmWait.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter =
            cn.ExecuteQuery(
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Kardex' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")
                    .AllowSort = False
                End With

            End With
        Next
        GridEX1.RootTable.Columns("MeghdareVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MeghdareVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("MeghdareSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MeghdareSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_in").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_in").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_in").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_in").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_Mandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Mandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_Mandeh").FormatString = "#,#.###"

        Dim _
            FC As _
                New Janus.Windows.GridEX.GridEXFormatCondition(GridEX1.RootTable.Columns("Mandeh"),
                                                                Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
        FC.FormatStyle.ForeColor = Color.Red
        GridEX1.RootTable.FormatConditions.Add(FC)

    End Sub


End Class
