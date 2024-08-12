'Author ::زهره ايزدپناه
'CreateDate :: 1387/10/01
'ModifiedDate::
'Description:: گزارش ريالي و تعدادي انبار
'System ::انبار

Public Class FrmMojoodiKalaSahmiye
    Inherits JanusSimpleReport.frmRptJanusBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnChideman As System.Windows.Forms.Button
    Friend WithEvents txtTimeReport As System.Windows.Forms.TextBox
    Friend WithEvents btnShowRialiColumn As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMojoodiKalaSahmiye))
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChideman = New System.Windows.Forms.Button()
        Me.btnShowRialiColumn = New System.Windows.Forms.Button()
        Me.txtTimeReport = New System.Windows.Forms.TextBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.txtTimeReport)
        Me.pnlF.Controls.Add(Me.btnShowRialiColumn)
        Me.pnlF.Controls.Add(Me.btnChideman)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 67)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChideman, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnShowRialiColumn, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtTimeReport, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(7, 32)
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(225, 7)
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(3, 7)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 67)
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 431)
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
        Me.GridEX1.Size = New System.Drawing.Size(1028, 431)
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.TotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.TotalRowFormatStyle.Key = "سرجمع"
        Me.GridEX1.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        Me.GridEX1.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'btnExcelList
        '
        Me.btnExcelList.Location = New System.Drawing.Point(77, 6)
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(372, 32)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(299, 6)
        '
        'btnSettingList
        '
        Me.btnSettingList.Location = New System.Drawing.Point(151, 6)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'btnExcell
        '
        Me.btnExcell.Location = New System.Drawing.Point(67, 6)
        Me.btnExcell.Size = New System.Drawing.Size(60, 25)
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(141, 7)
        Me.btnModify.Size = New System.Drawing.Size(60, 25)
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(97, 32)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 4
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
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
        Me.dcbKala.Location = New System.Drawing.Point(650, 12)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(328, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(980, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnChideman
        '
        Me.btnChideman.BackColor = System.Drawing.Color.Transparent
        Me.btnChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChideman.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChideman.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnChideman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChideman.Location = New System.Drawing.Point(187, 32)
        Me.btnChideman.Name = "btnChideman"
        Me.btnChideman.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnChideman.Size = New System.Drawing.Size(88, 32)
        Me.btnChideman.TabIndex = 7
        Me.btnChideman.Text = "مشاهده چيدمان کالا"
        Me.btnChideman.UseVisualStyleBackColor = False
        '
        'btnShowRialiColumn
        '
        Me.btnShowRialiColumn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowRialiColumn.Location = New System.Drawing.Point(279, 32)
        Me.btnShowRialiColumn.Name = "btnShowRialiColumn"
        Me.btnShowRialiColumn.Size = New System.Drawing.Size(88, 32)
        Me.btnShowRialiColumn.TabIndex = 8
        Me.btnShowRialiColumn.Text = "نمايش ستونهاي ريالي"
        '
        'txtTimeReport
        '
        Me.txtTimeReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeReport.Location = New System.Drawing.Point(466, 42)
        Me.txtTimeReport.Name = "txtTimeReport"
        Me.txtTimeReport.ReadOnly = True
        Me.txtTimeReport.Size = New System.Drawing.Size(63, 14)
        Me.txtTimeReport.TabIndex = 127
        '
        'FrmMojoodiKalaSahmiye
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmMojoodiKalaSahmiye"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش موجودي برای کالاهای سهمیه ای"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmMojoodiKalaSahmiye
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmMojoodiKalaSahmiye
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMojoodiKalaSahmiye
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMojoodiKalaSahmiye)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

#End Region

    Private Sub FrmMojoodiKalaSahmiyeA_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String
        'Dim i, vli_counter As Short
        'Dim vCurMah As Short

        btnShowRialiColumn.Enabled = gSM.ActionVisible("mnu__abSpr_MojoodiRiali") And
                                     gSM.ActionEnabled("mnu__abSpr_MojoodiRiali")

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql =
            "SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION  SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1"

        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        SetColumnProperties()

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = False
            .CheckedSanadStatus_4 = False
            .CheckedSanadStatus_8 = True
            .CheckedNoeTarakoneshKala_1 = False
            .CheckedNoeTarakoneshKala_2 = True
            .CheckedNoeTarakoneshKala_3 = False
            .CheckedNoeTarakoneshKala_4 = True
            .VisibleMahaleChideman = True
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .WhereConditionColumnChidemanKala = " abSanadHa.KalaPhizikiSN "
            .SetProperty()

        End With

    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click

        txtTimeReport.Text = ""
        Dim _st As TimeSpan = Now.TimeOfDay
        txtTimeReport.Refresh()

        ' '' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' '' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN, vStrFilterSelectedChidemanSN As String
        Dim strAnbars As Object
        Dim strTarakoneshs As String
        'Dim vFKalaCode As Object
        'Dim vTKalaCode As Object
        Dim vSanadStatus, vNoeTarakoneshKalaNO As String
        Dim vRezerv, vIsMahaleChideman As Short
        Dim vFromShomarehRahgiri, vToShomarehRahgiri As String
        Dim vFromSabtDate, vToSabtDate As String
        Dim vFromShomarehSefaresh, vToShomarehSefaresh As String
        Dim vTozih, vTafsiiSN, vNoeZayeatSN, vNoeMarjooeiSN As String

        vErrMsg = ""
        vStrKalaSN = ""
        strAnbars = ""
        vFromDate = ""
        vToDate = ""
        vStrFilterSelectedGoroohSN = ""
        vStrFilterSelectedChidemanSN = ""
        strTarakoneshs = ""
        vSanadStatus = ""
        vNoeTarakoneshKalaNO = ""
        vFromShomarehRahgiri = ""
        vToShomarehRahgiri = ""
        vFromSabtDate = ""
        vToSabtDate = ""
        vFromShomarehSefaresh = ""
        vToShomarehSefaresh = ""
        vTozih = ""
        vTafsiiSN = ""
        vNoeZayeatSN = ""
        vNoeMarjooeiSN = ""


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

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If
            If Trim(VFilterAsnadAnbar.SelectedSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus
            End If
            If Trim(VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedTarakoneshSN) <> "" Then
                strTarakoneshs = VFilterAsnadAnbar.SelectedTarakoneshSN
            End If
            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If
            If Trim(VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN) <> "" Then
                vStrFilterSelectedChidemanSN = VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedMahaleChideman) <> "" Then
                vIsMahaleChideman = Convert.ToInt16(VFilterAsnadAnbar.SelectedMahaleChideman)
            End If
            If Trim(VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala
            End If
            If Trim(VFilterAsnadAnbar.SelectedRezerv) <> "" Then
                vRezerv = Convert.ToInt16(VFilterAsnadAnbar.SelectedRezerv)
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromSabtDate) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToSabtDate) <> "" Then
                vFromSabtDate = Trim(VFilterAsnadAnbar.SelectedFromSabtDate)
                vToSabtDate = Trim(VFilterAsnadAnbar.SelectedToSabtDate)
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromShomarehSefaresh) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToShomarehSefaresh) <> "" Then
                vFromShomarehSefaresh = Trim(VFilterAsnadAnbar.SelectedFromShomarehSefaresh)
                vToShomarehSefaresh = Trim(VFilterAsnadAnbar.SelectedToShomarehSefaresh)
            End If

            If _
                Trim(VFilterAsnadAnbar.SelectedFromShomarehRahgiri) <> "" AndAlso _
                Trim(VFilterAsnadAnbar.SelectedToShomarehRahgiri) <> "" Then
                vFromShomarehRahgiri = Trim(VFilterAsnadAnbar.SelectedFromShomarehRahgiri)
                vToShomarehRahgiri = Trim(VFilterAsnadAnbar.SelectedToShomarehRahgiri)
            End If

            If Trim(VFilterAsnadAnbar.SelectedTozih) <> "" Then
                vTozih = Trim(VFilterAsnadAnbar.SelectedTozih)
            End If

            If Trim(VFilterAsnadAnbar.SelectedTafsiliSN) <> "" Then
                vTafsiiSN = Trim(VFilterAsnadAnbar.SelectedTafsiliSN)
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeZayeatSN) <> "" Then
                vNoeZayeatSN = Trim(VFilterAsnadAnbar.SelectedNoeZayeatSN)
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN) <> "" Then
                vNoeMarjooeiSN = Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN)
            End If

            Me.Cursor = Cursors.WaitCursor

            If Trim(dcbKala.BoundText) <> "" AndAlso Convert.ToDecimal(dcbKala.SelectedValue) <> 0 Then
                If vStrKalaSN <> "" Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If

            End If
            GridEX1.DataSource = cn.SPQuery("_abSpr_MojoodiKalaSahmiye", gVahedeTejariSN, strAnbars _
                                             , CStr(vFromDate), vToDate, vStrKalaSN, vSanadStatus _
                                             , vNoeTarakoneshKalaNO, vRezerv, strTarakoneshs, vStrFilterSelectedGoroohSN _
                                             , vStrFilterSelectedChidemanSN, vIsMahaleChideman, vFromSabtDate, _
                                             vToSabtDate, vFromShomarehSefaresh, vToShomarehSefaresh _
                                             , vFromShomarehRahgiri, vToShomarehRahgiri, vTozih, vTafsiiSN, vNoeZayeatSN, _
                                             vNoeMarjooeiSN)

            If vIsMahaleChideman = 1 Then
                GridEX1.RootTable.Columns("ChidemanDS").Visible = True
            Else
                GridEX1.RootTable.Columns("ChidemanDS").Visible = False
            End If

            If vRezerv = 1 Then
                GridEX1.RootTable.Columns("ShomarehRahgiri").Visible = False
                GridEX1.RootTable.Columns("NoeTarakoneshkalaDS").Visible = False
                GridEX1.RootTable.Columns("EnghezaDate").Visible = False
                GridEX1.RootTable.Columns("MojoodiVazni").Visible = True
                GridEX1.RootTable.Columns("MojoodiVazni").MaxLength = 100
            Else
                GridEX1.RootTable.Columns("ShomarehRahgiri").Visible = True
                GridEX1.RootTable.Columns("NoeTarakoneshkalaDS").Visible = True
                GridEX1.RootTable.Columns("EnghezaDate").Visible = True
                GridEX1.RootTable.Columns("MojoodiVazni").Visible = False
                GridEX1.RootTable.Columns("MojoodiVazni").MaxLength = 0
            End If

            RefreshDataSet()
            Me.Cursor = Cursors.Default
            GridEX1.RootTable.Columns("KalaSN").Visible = False

            Dim _et As TimeSpan = Now.TimeOfDay
            txtTimeReport.Text = (_et - _st).ToString.Substring(0, 8)
            txtTimeReport.Refresh()

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub SetColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_MojoodiKalaSahmiye' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS").ToString(), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS").ToString()
                End With

            End With
        Next

        GridEX1.RootTable.Columns("Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Mojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Mojoodi").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("Mojoodi").CellStyle.BackColor = Color.LemonChiffon

        GridEX1.RootTable.Columns("MojoodiVagheiForKalaSahmiye").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodiVagheiForKalaSahmiye").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiVagheiForKalaSahmiye").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiVagheiForKalaSahmiye").CellStyle.BackColor = Color.LemonChiffon

        GridEX1.RootTable.Columns("MojoodieHaghighieShobe").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodieHaghighieShobe").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodieHaghighieShobe").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodieHaghighieShobe").CellStyle.BackColor = Color.LemonChiffon

        GridEX1.RootTable.Columns("MojoodieMajazieShobe").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodieMajazieShobe").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodieMajazieShobe").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodieMajazieShobe").CellStyle.BackColor = Color.LemonChiffon

        GridEX1.RootTable.Columns("Box_Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_Mojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_Mojoodi").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_Mojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_Mojoodi").TotalFormatString = "#,#.###"


        GridEX1.RootTable.Columns("SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_in").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_in").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_in").FormatString = "#,#.###"

        GridEX1.RootTable.Columns("SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("SumSaderehVagheiForKalaSahmiye").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SumSaderehVagheiForKalaSahmiye").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SumSaderehVagheiForKalaSahmiye").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("NerkhStandard").FormatString = "#,#.###"

        GridEX1.RootTable.Columns("MojoodiRiali").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodiRiali").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiRiali").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("MojoodiVazni").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodiVazni").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiVazni").TotalFormatString = "#,#.###"
        'GridEX1.RootTable.Columns("KalaSN").Visible = False
        If Not (gSM.ActionVisible("mnu__abSpr_MojoodiRiali") And gSM.ActionEnabled("mnu__abSpr_MojoodiRiali")) Then
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("NerkhStandard"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("MojoodiRiali"))

        Else
            GridEX1.RootTable.Columns("NerkhStandard").Visible = False
            GridEX1.RootTable.Columns("MojoodiRiali").Visible = False
        End If


    End Sub

    Private Sub btnFilterAsnadAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود

        With VFilterAsnadAnbar
            .EnableFromSanadDate = False
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleRezerv = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleNoeTarakoneshKala = True
            .VisibleChidemanKala = True
            .VisibleAnbar = True

            .VisibleSabtDate = True
            .EnableFromSabtDate = True
            .VisibleShomarehSefaresh = True
            .VisibleShomarehRahgiri = True
            .VisibleTarakonesh = True
            .VisibleTozih = True
            .VisibleTafsili = True
            .VisibleNoeZayeat = True
            .VisibleNoeMarjooei = True

            .ShowDialog(Me)

        End With
    End Sub

    Private Sub btnChideman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChideman.Click

        Dim vKalaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_KalaSN() As Decimal
        Dim VCount_KalaSN As Short
        Me.Cursor = Cursors.WaitCursor
        With GridEX1
            VCount_KalaSN = Convert.ToInt16(.SelectedItems.Count)
            ReDim V_ar_KalaSN(VCount_KalaSN)
            For i = 0 To Convert.ToInt16(VCount_KalaSN - 1)
                V_ar_KalaSN(i) = Convert.ToDecimal(Val(.SelectedItems.Item(i).GetRow.Cells("kalaSN").Value))
            Next
        End With
        ' حذف تک تک رکوردهاي انتخاب شده 
        For i = 0 To Convert.ToInt16(VCount_KalaSN - 1)
            vSN = Convert.ToDecimal(Val(V_ar_KalaSN(i)))
            If vSN <> 0 Then
                vKalaSN = vKalaSN & IIf(vKalaSN Is Nothing, "", ",") & vSN.ToString
            End If
        Next
        Me.Cursor = Cursors.Default

        Dim VShowChideman As New Minoo.Applications.Anbar.Common.FrmShowChideman
        VShowChideman.vKalaSn = vKalaSN.ToString()
        VShowChideman.ShowDialog(Me)

    End Sub

    Private Sub btnShowRialiColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnShowRialiColumn.Click

        GridEX1.RootTable.Columns("NerkhStandard").Visible = True
        GridEX1.RootTable.Columns("MojoodiRiali").Visible = True

    End Sub

End Class

