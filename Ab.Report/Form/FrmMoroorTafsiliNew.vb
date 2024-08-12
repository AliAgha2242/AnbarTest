'Author ::زهره ايزدپناه
'CreateDate :: 1387/11/19
'ModifiedDate::
'Description:: گزارش مرورتفصیلی اسناد انبار
'System ::انبار
Public Class FrmMoroorTafsiliNew
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
    Friend WithEvents btnShowRialiColumn As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.btnShowRialiColumn = New System.Windows.Forms.Button()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.btnShowRialiColumn)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 87)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnShowRialiColumn, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(11, 39)
        Me.btnViewReport.Size = New System.Drawing.Size(123, 39)
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(316, 5)
        Me.btnFilter.Size = New System.Drawing.Size(101, 33)
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(8, 5)
        Me.btnReturn.Size = New System.Drawing.Size(101, 33)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 87)
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 404)
        '
        'pnlCommand
        '
        Me.pnlCommand.Size = New System.Drawing.Size(553, 43)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
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
        Me.GridEX1.Size = New System.Drawing.Size(1028, 404)
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.TotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.TotalRowFormatStyle.Key = "سرجمع"
        Me.GridEX1.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        Me.GridEX1.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'btnExcelList
        '
        Me.btnExcelList.Location = New System.Drawing.Point(111, 5)
        Me.btnExcelList.Size = New System.Drawing.Size(100, 33)
        Me.btnExcelList.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Transparent
        Me.btnExcelList.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Solid
        Me.btnExcelList.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.btnExcelList.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(393, 40)
        Me.btnChart.Size = New System.Drawing.Size(124, 39)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(423, 5)
        Me.btnPrint.Size = New System.Drawing.Size(101, 33)
        '
        'btnSettingList
        '
        Me.btnSettingList.Location = New System.Drawing.Point(214, 5)
        Me.btnSettingList.Size = New System.Drawing.Size(101, 33)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 491)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 43)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(11, 10)
        Me.btnCancel.Size = New System.Drawing.Size(101, 33)
        '
        'btnExcell
        '
        Me.btnExcell.Location = New System.Drawing.Point(1196, 81)
        Me.btnExcell.Size = New System.Drawing.Size(37, 30)
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(665, 74)
        Me.btnModify.Size = New System.Drawing.Size(102, 34)
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(139, 39)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(123, 39)
        Me.btnFilterAsnadAnbar.TabIndex = 5
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnShowRialiColumn
        '
        Me.btnShowRialiColumn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowRialiColumn.Location = New System.Drawing.Point(266, 39)
        Me.btnShowRialiColumn.Name = "btnShowRialiColumn"
        Me.btnShowRialiColumn.Size = New System.Drawing.Size(123, 39)
        Me.btnShowRialiColumn.TabIndex = 5
        Me.btnShowRialiColumn.Text = "نمايش ستونهاي ريالي"
        '
        'FrmMoroorTafsiliNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmMoroorTafsiliNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش مرور تفصیلی"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmMoroorTafsiliNew
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmMoroorTafsiliNew
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMoroorTafsiliNew
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMoroorTafsiliNew)
            m_vb6FormDefInstance = Value
        End Set

    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
    Dim _Mode As Int16
#End Region

    Public Property Mode() As Int16
        Get
            Mode = _Mode
        End Get
        Set(ByVal Value As Int16)
            _Mode = Value
        End Set
    End Property

    Private Sub FrmTafsiliRialiA_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        setColumnProperties()
        btnShowRialiColumn.Enabled = gSM.ActionVisible("mnuTafsiliRialiA") And gSM.ActionEnabled("mnuTafsiliRialiA")
        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = True
            .CheckedNoeTarakoneshKala_1 = False
            .CheckedNoeTarakoneshKala_2 = False
            .CheckedNoeTarakoneshKala_3 = False
            .CheckedNoeTarakoneshKala_4 = False
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnSanadNO = " abSanad.SanadNO "
            .WhereConditionColumnTarakonesh = " CONVERT(VARCHAR(10),abSanad.TarakoneshSN) "
            .WhereConditionColumnTarakoneshSN = " abSanad.TarakoneshSN "
            .WhereConditionColumnShomarehSefaresh = " dbo.Trim(abSanad.ShomarehSefaresh) "
            .WhereConditionColumnTozih = " abSanad.Tozih "
            .WhereConditionColumnTafsiliSN = " abSanad.TafsiliSN "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .WhereConditionColumnShomarehBarnameh = " abSanad.ShomarehBarnameh "
            .WhereConditionColumnShomarehMashin = " abSanad.Shomarehmashin "
            .SetProperty()
        End With

    End Sub

    Private Sub btnbtnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        'Dim vSql, vMainSql As String
        'Dim vFromSql As String
        'Dim vWhereSql, vWhereSqlAll As String
        'Dim vGroupSql As String
        'Dim vOrderSql As String

        Dim vFromDate As Object
        Dim vToDate As Object

        Dim vErrMsg As String
        Dim strAnbars As Object ', strNoeAnbars
        Dim strTarakoneshs As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN As String
        Dim vSanadStatus As String
        Dim vNoeTarakoneshKalaNO As String
        Dim vGoroohBandiTarakonesh As String
        Dim _
            vFromShomarehSefaresh, _
            vToShomarehSefaresh, _
            vtozih, _
            vFromSanadNo, _
            vToSanadNo, _
            vTafsiliSN, _
            vToShomarehBarnameh, _
            vFromShomarehBarnameh, _
            vFromShomarehMashin, _
            vToShomarehMashin As String
        Dim _
            vFromShomarehRahgiri, _
            vToShomarehRahgiri, _
            vStrFilterSelectedChidemanSN, _
            vStrFilterSelectedNoeZayeatSN, _
            vStrFilterSelectedNoeMarjooeiSN As String
        Dim vIsMahaleChideman As Short
        Dim vFromSabtDate As Object
        Dim vToSabtDate As Object

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

            If Trim(VFilterAsnadAnbar.WhereConditionSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus
            End If

            If Trim(VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN) <> "" Then
                vGoroohBandiTarakonesh = VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedTarakoneshSN) <> "" Then
                strTarakoneshs = VFilterAsnadAnbar.SelectedTarakoneshSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedFromShomarehSefaresh) <> "" Then
                vFromShomarehSefaresh = VFilterAsnadAnbar.SelectedFromShomarehSefaresh
            End If
            If Trim(VFilterAsnadAnbar.SelectedToShomarehSefaresh) <> "" Then
                vToShomarehSefaresh = VFilterAsnadAnbar.SelectedToShomarehSefaresh
            End If
            If Trim(VFilterAsnadAnbar.SelectedTozih) <> "" Then
                vtozih = VFilterAsnadAnbar.SelectedTozih
            End If
            If Trim(VFilterAsnadAnbar.SelectedFromSanadNo) <> "" Then
                vFromSanadNo = VFilterAsnadAnbar.SelectedFromSanadNo
            End If
            If Trim(VFilterAsnadAnbar.SelectedToSanadNo) <> "" Then
                vToSanadNo = VFilterAsnadAnbar.SelectedToSanadNo
            End If

            If Trim(VFilterAsnadAnbar.SelectedTafsiliSN) <> "" Then
                vTafsiliSN = VFilterAsnadAnbar.SelectedTafsiliSN
            End If

            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If

            If Trim(VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN) <> "" Then
                vGoroohBandiTarakonesh = VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN
            End If

            If Trim(VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala
            End If

            If Trim(VFilterAsnadAnbar.SelectedFromShomarehMashin) <> "" Then
                vFromShomarehMashin = VFilterAsnadAnbar.SelectedFromShomarehMashin
            End If
            If Trim(VFilterAsnadAnbar.SelectedToShomarehMashin) <> "" Then
                vToShomarehMashin = VFilterAsnadAnbar.SelectedToShomarehMashin
            End If

            If Trim(VFilterAsnadAnbar.SelectedFromShomarehBarnameh) <> "" Then
                vFromShomarehBarnameh = VFilterAsnadAnbar.SelectedFromShomarehBarnameh
            End If
            If Trim(VFilterAsnadAnbar.SelectedToShomarehBarnameh) <> "" Then
                vToShomarehBarnameh = VFilterAsnadAnbar.SelectedToShomarehBarnameh
            End If

            If Trim(VFilterAsnadAnbar.SelectedFromShomarehRahgiri) <> "" Then
                vFromShomarehRahgiri = VFilterAsnadAnbar.SelectedFromShomarehRahgiri
            End If

            If Trim(VFilterAsnadAnbar.SelectedToShomarehRahgiri) <> "" Then
                vToShomarehRahgiri = VFilterAsnadAnbar.SelectedToShomarehRahgiri
            End If

            If Trim(VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN) <> "" Then
                vStrFilterSelectedChidemanSN = VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN) <> "" Then
                vStrFilterSelectedNoeMarjooeiSN = VFilterAsnadAnbar.SelectedNoeMarjooeiSN
            End If

            If Trim(VFilterAsnadAnbar.SelectedNoeMarjooeiSN) <> "" Then
                vStrFilterSelectedNoeZayeatSN = VFilterAsnadAnbar.SelectedNoeZayeatSN
            End If

            If Trim(VFilterAsnadAnbar.SelectedFromSabtDate) <> "" Then
                vFromSabtDate = Trim(VFilterAsnadAnbar.SelectedFromSabtDate)
            End If
            If Trim(VFilterAsnadAnbar.SelectedToSabtDate) <> "" Then
                vToSabtDate = Trim(VFilterAsnadAnbar.SelectedToSabtDate)
            End If

            Me.Cursor = Cursors.WaitCursor

            GridEX1.DataSource = cn.SPQuery("_abSpr_MoroorTafsiliNew", gVahedeTejariSN, strAnbars _
                                             , vFromDate, vToDate, vStrKalaSN, vSanadStatus _
                                             , vNoeTarakoneshKalaNO, strTarakoneshs, vStrFilterSelectedGoroohSN, _
                                             vGoroohBandiTarakonesh _
                                             , vFromShomarehSefaresh, vToShomarehSefaresh, vtozih, vFromSanadNo, _
                                             vToSanadNo, vTafsiliSN, vFromShomarehMashin, vToShomarehMashin, _
                                             vFromShomarehBarnameh, vToShomarehBarnameh _
                                             , vFromShomarehRahgiri, vToShomarehRahgiri, vStrFilterSelectedChidemanSN, _
                                             vIsMahaleChideman, vStrFilterSelectedNoeZayeatSN, _
                                             vStrFilterSelectedNoeMarjooeiSN, vFromSabtDate, vToSabtDate)
            RefreshDataSet()
            Me.Cursor = Cursors.Default

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_TafsiliA' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

                End With

            End With
        Next


        GridEX1.RootTable.Columns("MeghdareVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MeghdareVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareVaredeh").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareVaredeh").Visible = gSM.ActionEnabled(Me.Name + "_MeghdareVaredeh")

        GridEX1.RootTable.Columns("MeghdareSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MeghdareSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareSadereh").TotalFormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareSadereh").Visible = gSM.ActionEnabled(Me.Name + "_MeghdareSadereh")

        GridEX1.RootTable.Columns("Box_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_in").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_in").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_in").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_in").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_in").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_Out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_Out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_Out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_Out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_Out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_Out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateStandardVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateStandardVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateStandardVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateStandardSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateStandardSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateStandardSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").TotalFormatString = "#,#.###"

        If Not (gSM.ActionVisible("mnuTafsiliRialiA") And gSM.ActionEnabled("mnuTafsiliRialiA")) Then
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("NerkhST"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("GheymateStandardVaredeh"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("GheymateStandardSadereh"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("SahmHazineSanadBSadereh"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("NerkhFaktor"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("GheymateTadarokatVaredeh"))
            GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("GheymateTadarokatSadereh"))
        Else
            GridEX1.RootTable.Columns("NerkhST").Visible = False
            'gSM.ActionVisible("mnuTafsiliRialiA") And gSM.ActionEnabled("mnuTafsiliRialiA")
            GridEX1.RootTable.Columns("GheymateStandardVaredeh").Visible = False
            GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").Visible = False
            GridEX1.RootTable.Columns("GheymateStandardSadereh").Visible = False
            GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").Visible = False
            GridEX1.RootTable.Columns("NerkhFaktor").Visible = False
            GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").Visible = False
            GridEX1.RootTable.Columns("GheymateTadarokatSadereh").Visible = False
        End If

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .VisibleSanadNO = True
            .EnableFromSanadDate = True
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleShomarehSefaresh = True
            .VisibleTarakonesh = True
            .VisibleTarakoneshSN = True
            .VisibleTozih = True
            .VisibleTafsili = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleNoeTarakoneshKala = True
            .VisibleAnbar = True
            .VisibleShomarehMashinBarnameh = True
            .VisibleChidemanKala = True
            .VisibleMahaleChideman = True
            .VisibleNoeZayeat = True
            .VisibleNoeMarjooei = True
            .VisibleShomarehRahgiri = True
            .VisibleSabtDate = True
            '//By Izadpanah-851208
            .EnableFromSabtDate = True
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub btnShowRialiColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnShowRialiColumn.Click

        GridEX1.RootTable.Columns("NerkhST").Visible = True
        GridEX1.RootTable.Columns("GheymateStandardVaredeh").Visible = True
        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").Visible = True
        GridEX1.RootTable.Columns("GheymateStandardSadereh").Visible = True
        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").Visible = True
        GridEX1.RootTable.Columns("NerkhFaktor").Visible = True
        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").Visible = True
        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").Visible = True

    End Sub

End Class
