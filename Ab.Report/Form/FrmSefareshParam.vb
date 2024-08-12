'Author ::زهره ايزدپناه
'CreateDate :: 1388/09/03
'ModifiedDate::
'Description:: گزارش نقطه سفارش
'System ::انبار

Option Strict Off
Option Explicit On



Public Class FrmSefareshParam
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
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents btnChideman As System.Windows.Forms.Button
    Public WithEvents dcbNoeAnbarSN As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkOnlyKalaWithHavaleh As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSefareshParam))
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.btnChideman = New System.Windows.Forms.Button()
        Me.dcbNoeAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkOnlyKalaWithHavaleh = New System.Windows.Forms.CheckBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.chkOnlyKalaWithHavaleh)
        Me.pnlF.Controls.Add(Me.dcbNoeAnbarSN)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.btnChideman)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 67)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChideman, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbNoeAnbarSN, 0)
        Me.pnlF.Controls.SetChildIndex(Me.chkOnlyKalaWithHavaleh, 0)
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
        Me.btnChart.Location = New System.Drawing.Point(279, 32)
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
        'btnChideman
        '
        Me.btnChideman.BackColor = System.Drawing.Color.Transparent
        Me.btnChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChideman.Enabled = False
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
        'dcbNoeAnbarSN
        '
        Me.dcbNoeAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeAnbarSN.AutoSelectFirst = True
        Me.dcbNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dcbNoeAnbarSN.BoundText = Nothing
        Me.dcbNoeAnbarSN.BypassChangeEvent = False
        Me.dcbNoeAnbarSN.DisplayText = ""
        Me.dcbNoeAnbarSN.LateBindingTop = "100"
        Me.dcbNoeAnbarSN.Location = New System.Drawing.Point(780, 15)
        Me.dcbNoeAnbarSN.MemFilter = ""
        Me.dcbNoeAnbarSN.Name = "dcbNoeAnbarSN"
        Me.dcbNoeAnbarSN.SeparatedData = Nothing
        Me.dcbNoeAnbarSN.Size = New System.Drawing.Size(188, 21)
        Me.dcbNoeAnbarSN.Source = Nothing
        Me.dcbNoeAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeAnbarSN.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(971, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "نوع انبار "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkOnlyKalaWithHavaleh
        '
        Me.chkOnlyKalaWithHavaleh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOnlyKalaWithHavaleh.Location = New System.Drawing.Point(500, 15)
        Me.chkOnlyKalaWithHavaleh.Name = "chkOnlyKalaWithHavaleh"
        Me.chkOnlyKalaWithHavaleh.Size = New System.Drawing.Size(258, 24)
        Me.chkOnlyKalaWithHavaleh.TabIndex = 11
        Me.chkOnlyKalaWithHavaleh.Text = "کالاهاي داراي حواله در محدوده تاريخ انتخابي"
        '
        'FrmSefareshParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmSefareshParam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش موجودي انبار"
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

    Private Shared m_vb6FormDefInstance As FrmSefareshParam
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSefareshParam
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSefareshParam
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmSefareshParam)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region

    Private Sub FrmRptSefareshParam_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSql As String
        'Dim i, vli_counter As Short
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

        setColumnProperties()

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
            .VisibleTaghazaKonandeh = True
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .WhereConditionColumnChidemanKala = " abSanadHa.KalaPhizikiSN "
            .SetProperty()
        End With


    End Sub

    Private Sub btnViewReport_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN, vStrFilterSelectedChidemanSN, vStrFilterSelectedTaghazaKonandehSN As String
        Dim strAnbars, strNoeAnbars As Object
        Dim strTarakoneshs As String
        'Dim vFKalaCode As Object
        'Dim vTKalaCode As Object
        Dim vSanadStatus, vNoeTarakoneshKalaNO As String
        Dim vRezerv, vIsMahaleChideman As Short

        Dim vKalaGardeshDar, vKalaMandehDar As Decimal
        Dim vKalaGardeshAll As Decimal
        Dim vOnlyKalaWithHavaleh As Decimal

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
            If Trim (VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala
            End If
            If Trim (VFilterAsnadAnbar.SelectedRezerv) <> "" Then
                vRezerv = VFilterAsnadAnbar.SelectedRezerv
            End If
            If Trim (VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN) <> "" Then
                vStrFilterSelectedChidemanSN = VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedTaghazaKonandeh) <> "" Then
                vStrFilterSelectedTaghazaKonandehSN = VFilterAsnadAnbar.SelectedTaghazaKonandeh
            End If
            If Trim (VFilterAsnadAnbar.SelectedMahaleChideman) <> "" Then
                vIsMahaleChideman = VFilterAsnadAnbar.SelectedMahaleChideman
            End If

            'شروط کالا
            vKalaGardeshDar = 0
            vKalaMandehDar = 0
            vKalaGardeshAll = 0
            If VFilterAsnadAnbar.SelectedKalaGardeshDar = 1 Then
                vKalaGardeshDar = 1
            ElseIf VFilterAsnadAnbar.SelectedKalaMandehDar = 1 Then
                vKalaMandehDar = 1
            ElseIf Trim (VFilterAsnadAnbar.SelectedKalaGardeshAll) <> "" Then
                vKalaGardeshAll = 1
            End If
            'شروط کالا

            vOnlyKalaWithHavaleh = 0
            If chkOnlyKalaWithHavaleh.Checked Then
                vOnlyKalaWithHavaleh = 1
            End If

            Me.Cursor = Cursors.WaitCursor
            GridEX1.DataSource = cn.SPQuery("_abSpr_RptSefareshParam", System.DBNull.Value, strAnbars, strNoeAnbars _
                                             , vFromDate, vToDate, vStrKalaSN, vSanadStatus _
                                             , System.DBNull.Value, vNoeTarakoneshKalaNO, vRezerv, strTarakoneshs, _
                                             vStrFilterSelectedGoroohSN _
                                             , vKalaGardeshDar, vKalaMandehDar, vKalaGardeshAll, vOnlyKalaWithHavaleh, _
                                             vStrFilterSelectedChidemanSN, vIsMahaleChideman, vStrFilterSelectedTaghazaKonandehSN)

            btnChideman.Enabled = True
            If _
                Not CType (GridEX1.DataSource, DataView).Table.Columns.Contains ("TedadAjza") AndAlso _
                GridEX1.RootTable.Columns.Contains ("TedadAjza") Then
                GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("TedadAjza"))
                GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("Box_Mojoodi"))
                GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("Can_Mojoodi"))
            End If

            If vIsMahaleChideman <> 1 AndAlso GridEX1.RootTable.Columns.Contains ("ChidemanDS") Then
                GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("ChidemanDS"))
            End If

            RefreshDataSet()
            Me.Cursor = Cursors.Default

            Dim vstrNoeAnbars As Object

            If Trim (dcbNoeAnbarSN.BoundText) <> "" Then
                vstrNoeAnbars = dcbNoeAnbarSN.BoundText
            End If

            If Not GridEX1.RootTable.Columns.Contains ("TedadAjza") Then
                If (vstrNoeAnbars = 1 Or vstrNoeAnbars = 4 Or vstrNoeAnbars = 6) Then
                    GridEX1.RootTable.Columns ("Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                    GridEX1.RootTable.Columns ("Mojoodi").FormatString = "#,#.###"
                    GridEX1.RootTable.Columns ("Mojoodi").TotalFormatString = "#,#.###"


                Else
                    GridEX1.RootTable.Columns ("Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                    GridEX1.RootTable.Columns ("Mojoodi").FormatString = "#,#"
                    GridEX1.RootTable.Columns ("Mojoodi").TotalFormatString = "#,#"
                End If
            Else
                GridEX1.RootTable.Columns ("Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                GridEX1.RootTable.Columns ("Mojoodi").FormatString = "#,#"
                GridEX1.RootTable.Columns ("Mojoodi").TotalFormatString = "#,#"

                GridEX1.RootTable.Columns ("Box_Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                GridEX1.RootTable.Columns ("Box_Mojoodi").FormatString = "#,#"
                GridEX1.RootTable.Columns ("Box_Mojoodi").TotalFormatString = "#,#"

                GridEX1.RootTable.Columns ("Can_Mojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                GridEX1.RootTable.Columns ("Can_Mojoodi").FormatString = "#,#"
                GridEX1.RootTable.Columns ("Can_Mojoodi").TotalFormatString = "#,#"
            End If

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery ( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_SefareshParam' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add (dvTableFooter.Item (i).Item ("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item (i).Item ("ObjectHaFDS")

                End With

            End With
        Next

    End Sub

    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            '850607
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleRezerv = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleNoeTarakoneshKala = True
            .VisibleKalaWhere = True
            .VisibleChidemanKala = True
            .VisibleAnbar = True
            If Trim (dcbNoeAnbarSN.BoundText) <> "" Then
                .FilterNoeAnbarSN = dcbNoeAnbarSN.BoundText
            End If
            .ShowDialog (Me)
        End With
    End Sub

    Private Sub btnChideman_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChideman.Click

        Dim vKalaSN As Object
        Dim i As Short
        Dim vSN As Decimal
        Dim V_ar_KalaSN() As Decimal
        Dim VCount_KalaSN As Short

        Me.Cursor = Cursors.WaitCursor

        With GridEX1
            VCount_KalaSN = .SelectedItems.Count
            ReDim V_ar_KalaSN(VCount_KalaSN)
            For i = 0 To VCount_KalaSN - 1
                V_ar_KalaSN (i) = Val (.SelectedItems.Item (i).GetRow.Cells ("kalaSN").Value)
            Next
        End With
        ' حذف تک تک رکوردهاي انتخاب شده 
        For i = 0 To VCount_KalaSN - 1
            vSN = Val (V_ar_KalaSN (i))
            If vSN <> 0 Then
                vKalaSN = vKalaSN & IIf (vKalaSN Is Nothing, "", ",") & vSN.ToString
            End If
        Next
        Me.Cursor = Cursors.Default

        Dim VShowChideman As New Minoo.Applications.Anbar.Common.FrmShowChideman
        VShowChideman.vKalaSn = vKalaSN
        VShowChideman.ShowDialog (Me)

    End Sub
End Class

