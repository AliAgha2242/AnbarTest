'Author ::زهره ايزدپناه
'CreateDate :: 1387/11/19
'ModifiedDate::
'Description:: گزارش مرورتفصیلی اسناد انبار
'System ::انبار


Public Class FrmMoroorTafsili
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
    Friend WithEvents txtTimeReport As System.Windows.Forms.TextBox
    Friend WithEvents btnShowRialiColumn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMoroorTafsili))
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
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
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnShowRialiColumn, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtTimeReport, 0)
        '
        'btnViewReport
        '
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
        Me.btnChart.Location = New System.Drawing.Point(281, 33)
        '
        'btnSettingList
        '
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(99, 32)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 5
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'btnShowRialiColumn
        '
        Me.btnShowRialiColumn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowRialiColumn.Location = New System.Drawing.Point(190, 32)
        Me.btnShowRialiColumn.Name = "btnShowRialiColumn"
        Me.btnShowRialiColumn.Size = New System.Drawing.Size(88, 32)
        Me.btnShowRialiColumn.TabIndex = 5
        Me.btnShowRialiColumn.Text = "نمايش ستونهاي ريالي"
        '
        'txtTimeReport
        '
        Me.txtTimeReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeReport.Location = New System.Drawing.Point(375, 42)
        Me.txtTimeReport.Name = "txtTimeReport"
        Me.txtTimeReport.ReadOnly = True
        Me.txtTimeReport.Size = New System.Drawing.Size(63, 14)
        Me.txtTimeReport.TabIndex = 128
        '
        'FrmMoroorTafsili
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmMoroorTafsili"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش مرور تفصیلی"
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

    Private Shared m_vb6FormDefInstance As FrmMoroorTafsili
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmMoroorTafsili
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMoroorTafsili
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMoroorTafsili)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region
#Region "Private Variable"
    Public VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
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
        ''Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
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
            .WhereConditionColumnNoeKala = "PaNoeKala.NoeKalaSN"
            .WhereConditionColumnShomarehBarnameh = " abSanad.ShomarehBarnameh "
            .WhereConditionColumnShomarehMashin = " abSanad.Shomarehmashin "
            .SetProperty()
        End With
    End Sub
    Private Sub btnbtnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        txtTimeReport.Text = ""
        Dim _st As TimeSpan = Now.TimeOfDay
        txtTimeReport.Refresh()
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        'Dim vSql, vMainSql As String
        'Dim vFromSql As String
        'Dim vWhereSql, vWhereSqlAll As String
        'Dim vGroupSql As String
        'Dim vOrderSql As String
        Dim WaitFrm As New Anbar.Common.Frmwait
        Try
            WaitFrm.Show()
            WaitFrm.Refresh()
            Dim vFromDate As Object
            Dim vToDate As Object
            Dim vErrMsg As String
            Dim strAnbars As String ', strNoeAnbars
            Dim strTarakoneshs As String
            Dim vStrKalaSN, vStrFilterSelectedGoroohSN As String
            Dim VStrNoeKalaSN As String
            Dim vSanadStatus As String
            Dim vNoeTarakoneshKalaNO As String
            Dim vGoroohBandiTarakonesh As String
            Dim _
                vFromShomarehSefaresh,
                vToShomarehSefaresh,
                vtozih,
                vFromSanadNo,
                vToSanadNo,
                vTafsiliSN,
                vToShomarehBarnameh,
                vFromShomarehBarnameh,
                vFromShomarehMashin,
                vToShomarehMashin As String
            Dim _
                vFromShomarehRahgiri,
                vToShomarehRahgiri,
                vStrFilterSelectedChidemanSN,
                vStrFilterSelectedNoeZayeatSN,
                vStrFilterSelectedNoeMarjooeiSN,
                vStrFilterSelectedTaminKonandehSN As String

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
                ''Add By Dehghani 14000220
                If Trim(VFilterAsnadAnbar.SelectedTaminKonandehSN) <> "" Then
                    vStrFilterSelectedTaminKonandehSN = VFilterAsnadAnbar.SelectedTaminKonandehSN
                End If
                ''Added By Alipour Nooshin 14031206
                If Trim(VFilterAsnadAnbar.SelectedNoeKala) <> "" Then
                    VStrNoeKalaSN = VFilterAsnadAnbar.SelectedNoeKala
                End If
                Me.Cursor = Cursors.WaitCursor
                'add by ghasemi 14010425
                Dim CApp1 As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
                Dim gNamayeshMasahat As Boolean = If(CApp1.GetAppConfig("gNamayeshMasahat") Is System.DBNull.Value, False, True)
                GridEX1.RootTable.Columns("Masahat").Visible = False
                If (gNamayeshMasahat = True) Then
                    If Not GridEX1.RootTable.Columns("Masahat") Is Nothing Then
                        GridEX1.RootTable.Columns("Masahat").Visible = True
                        GridEX1.RootTable.Columns("Masahat").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                        GridEX1.RootTable.Columns("Masahat").FormatString = "#,#.###"
                        GridEX1.RootTable.Columns("Masahat").TotalFormatString = "#,#.###"
                    End If
                End If
                ''add by ghasemi 14010425
                ''ghasemi 14001106
                Dim CApp2 As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
                Dim gNamyeshSabtDarSamaneh As Boolean = If(CApp2.GetAppConfig("gNamyeshSabtDarSamaneh") Is System.DBNull.Value, False, True)

                GridEX1.RootTable.Columns("ESStatus").Visible = False

                If (gNamyeshSabtDarSamaneh = True) Then
                    If Not GridEX1.RootTable.Columns("ESStatus") Is Nothing Then
                        GridEX1.RootTable.Columns("ESStatus").Visible = True
                        GridEX1.RootTable.Columns("ESStatus").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
                    End If
                End If
                ''ghasemi 14001106


                'GridEX1.DataSource = cn.ExecuteQuery("_abSpr_MoroorTafsili  ''," & gVahedeTejariSN.ToString & ",'" & strAnbars & "'" &
                '                                 ",'" & vFromDate & "','" & vToDate & "', '" & vStrKalaSN & "','" & vSanadStatus & "'" &
                '                                 ", '" & vNoeTarakoneshKalaNO & "','" & strTarakoneshs & "', '" & vStrFilterSelectedGoroohSN & "','" & vGoroohBandiTarakonesh & "'" &
                '                                 ",'" & vFromShomarehSefaresh & "','" & vToShomarehSefaresh & "', '" & vtozih & "','" & vFromSanadNo & "'" &
                '                                 ",'" & vToSanadNo & "','" & vTafsiliSN & "', '" & vFromShomarehMashin & "','" & vToShomarehMashin & "'" &
                '                                 ",'" & vFromShomarehBarnameh & "','" & vToShomarehBarnameh & "'" &
                '                                 ",'" & vFromShomarehRahgiri & "','" & vToShomarehRahgiri & "', '" & vStrFilterSelectedChidemanSN & "'" &
                '                                 ",'" & vIsMahaleChideman & "', '" & vStrFilterSelectedNoeZayeatSN & "'" &
                '                                 ",'" & vStrFilterSelectedNoeMarjooeiSN & "', '" & vFromSabtDate & "','" & vToSabtDate & "', '" & vStrFilterSelectedTaminKonandehSN & "'")

                GridEX1.DataSource = cn.SPQuery("_abSpr_MoroorTafsili", gVahedeTejariSN, strAnbars _
                                             , vFromDate, vToDate, vStrKalaSN, vSanadStatus _
                                             , vNoeTarakoneshKalaNO, strTarakoneshs, vStrFilterSelectedGoroohSN,
                                             vGoroohBandiTarakonesh _
                                             , vFromShomarehSefaresh, vToShomarehSefaresh, vtozih, vFromSanadNo,
                                             vToSanadNo, vTafsiliSN, vFromShomarehMashin, vToShomarehMashin,
                                             vFromShomarehBarnameh, vToShomarehBarnameh _
                                             , vFromShomarehRahgiri, vToShomarehRahgiri, vStrFilterSelectedChidemanSN,
                                             vIsMahaleChideman, vStrFilterSelectedNoeZayeatSN,
                                             vStrFilterSelectedNoeMarjooeiSN, vFromSabtDate, vToSabtDate, vStrFilterSelectedTaminKonandehSN)


                RefreshDataSet()
                'GridEX1.RetrieveStructure()
                Me.Cursor = Cursors.Default

            Else
                NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.MsgBoxRight, Me.Text)
            End If

            Dim _et As TimeSpan = Now.TimeOfDay
            txtTimeReport.Text = (_et - _st).ToString.Substring(0, 8)
            txtTimeReport.Refresh()

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        Finally
            WaitFrm.Close()
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN " &
                                        "WHERE T1.ObjectDS='abQuery_TafsiliA' AND ObjectHaNo <> '0' " &
                                        "ORDER BY CAST(ObjectHaNo AS BIGINT)")

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

        GridEX1.RootTable.Columns("MojoodiVazniVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodiVazniVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiVazniVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Box_Out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Box_Out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Box_Out").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Can_Out").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Can_Out").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Can_Out").TotalFormatString = "#,#.###"

        If Not GridEX1.RootTable.Columns("IsRetest") Is Nothing Then
            GridEX1.RootTable.Columns("IsRetest").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
        End If

        If Not GridEX1.RootTable.Columns("IsNewSource") Is Nothing Then
            GridEX1.RootTable.Columns("IsNewSource").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
        End If

        GridEX1.RootTable.Columns("MojoodiVazniSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MojoodiVazniSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MojoodiVazniSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateStandardVaredeh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateStandardVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateStandardVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateTadarokatVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SahmHazineSanadBVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateStandardSadereh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateStandardSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateStandardSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateTadarokatSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("SahmHazineSanadBSadereh").TotalFormatString = "#,#.###"

        'add by ghasemi
        GridEX1.RootTable.Columns("GheymateBarnameh").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("GheymateBarnameh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("GheymateBarnameh").TotalFormatString = "#,#.###"
        'add by ghasemi

        'add by ghasemi 14010425
        Dim CApp1 As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
        Dim gNamayeshMasahat As Boolean = If(CApp1.GetAppConfig("gNamayeshMasahat") Is System.DBNull.Value, False, True)

        GridEX1.RootTable.Columns("Masahat").Visible = False
        If (gNamayeshMasahat = True) Then
            If Not GridEX1.RootTable.Columns("Masahat") Is Nothing Then
                GridEX1.RootTable.Columns("Masahat").Visible = True
                GridEX1.RootTable.Columns("Masahat").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                GridEX1.RootTable.Columns("Masahat").FormatString = "#,#.###"
                GridEX1.RootTable.Columns("Masahat").TotalFormatString = "#,#.###"
            End If
        End If
        ''add by ghasemi 14010425

        ''ghasemi 140108118
        GridEX1.RootTable.Columns("TafsiliSN1").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("TafsiliSN1").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("TafsiliSN1").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn").TotalFormatString = "#,#.###"
        ''ghasemi 140108118

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

        ''ghasemi 14001106
        Dim CApp2 As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)
        Dim gNamyeshSabtDarSamaneh As Boolean = If(CApp2.GetAppConfig("gNamyeshSabtDarSamaneh") Is System.DBNull.Value, False, True)

        GridEX1.RootTable.Columns("ESStatus").Visible = False

        If (gNamyeshSabtDarSamaneh = True) Then
            If Not GridEX1.RootTable.Columns("ESStatus") Is Nothing Then
                GridEX1.RootTable.Columns("ESStatus").Visible = True
                GridEX1.RootTable.Columns("ESStatus").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
            End If
        End If
        ''ghasemi 14001106

        Dim gNamyeshTashimHazineHaml As Boolean = If(CApp1.GetAppConfig("gVahedeTejariHazinehHamlSanad") Is System.DBNull.Value, False, True)
        GridEX1.RootTable.Columns("MablaghHaml").Visible = False
        GridEX1.RootTable.Columns("NerkhHaml").Visible = False

        If (gNamyeshTashimHazineHaml = True) Then
            If Not GridEX1.RootTable.Columns("MablaghHaml") Is Nothing Then
                GridEX1.RootTable.Columns("MablaghHaml").Visible = True
                GridEX1.RootTable.Columns("MablaghHaml").FormatString = "#,###"
            End If
            If Not GridEX1.RootTable.Columns("NerkhHaml") Is Nothing Then
                GridEX1.RootTable.Columns("NerkhHaml").Visible = True
                GridEX1.RootTable.Columns("NerkhHaml").FormatString = "#,###"
            End If
        End If
        'kouhdar14021101
        Dim gNamayeshDaftarForoosh As Boolean = False
        gNamayeshDaftarForoosh = If(CApp1.GetAppConfig("gTafkikByDaftarForoosh") Is System.DBNull.Value, False, True)
        If gNamayeshDaftarForoosh Then
            With GridEX1.RootTable.Columns()
                With .Add("DaftarForooshDS", Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = "دفتر فروش"
                End With
            End With
        End If
        'kouhdar14021101

        If Not GridEX1.RootTable.Columns("SanadMaliStandardStatus") Is Nothing Then
            GridEX1.RootTable.Columns("SanadMaliStandardStatus").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
        End If
        If Not GridEX1.RootTable.Columns("SanadMaliVagheeStatus") Is Nothing Then
            GridEX1.RootTable.Columns("SanadMaliVagheeStatus").ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
        End If

        Dim gNamayeshNoeKala As Boolean = False
        gNamayeshNoeKala = If(CApp1.GetAppConfig("vfgNoeKala") Is System.DBNull.Value, False, True)
        If gNamayeshNoeKala Then
            With GridEX1.RootTable.Columns()
                With .Add("NoeKalaDS", Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = "نوع کالا"
                End With
            End With
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
            .VisibleTaminKonandeh = True
            .VisibleNoeKala = True
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
        GridEX1.RootTable.Columns("").Visible = True

    End Sub

    Private Sub GridEX1_DoubleClick(sender As Object, e As EventArgs) Handles GridEX1.DoubleClick
        Dim sanadDate As String
        Dim taraKoneshSN As String
        Dim _Row As Janus.Windows.GridEX.GridEXRow
        _Row = GridEX1.CurrentRow
        sanadDate = _Row.Cells("MahiatKalaDS").Value
        taraKoneshSN = _Row.Cells("MahiatKalaDS").Value
    End Sub

    Private Sub btnSettingList_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles btnSettingList.ChangeUICues

    End Sub
End Class
