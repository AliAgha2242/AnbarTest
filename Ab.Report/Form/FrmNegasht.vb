'Author ::زهره ايزدپناه
'CreateDate :: 1388/01/26
'ModifiedDate::
'Description:: گزارش نگاشت اسناد انبار
'System ::انبار

Public Class FrmNegasht
    Inherits JanusSimpleReport.frmRptJanusBase

    Enum NOE_REPORT
        AsnadGhateeNashodeh = 0
        'اسناد قطعي نشده
        AsnadBedonehNerkhStandard
        'اسناد بدون نرخ استاندارد 
        AsnadBedonehSanadehMali
        'اسناد بدون سند مالي
        'AsnadBedonehNerkhVaghei 'اسناد بدون نرخ واقعي
        'AsnadBedonehSanadMaliTasvie  'اسناد با نرخ واقعي بدون سند مالي تسويه
        AsnadBaSanadMaliTekrari
        'اسناد انبار با بيش از يک سند مالي
        AsnadBaTarikhGhateiKochktar
        'اسناد انبار با تاريخ ثبت سند کوچکتر از آخرين تاريخ قطعي اسناد مالي
        AsnadBaTafsiliNadorost
        'اسناد انبار با مشکل غير فعال بودن طرف حساب و اسناد انبار با تفصیلی نادرست
        AsnadBaTafsiliKalaNadorost
        'اسناد انبار با مشکل غير فعال بودن تفصیلی کالا و اسناد انبار با تفصیلی کالا نادرست
        AsnadBaTikeMaliBedonehSanadMaliStandard
        'اسناد با تيک مالي و بدون سند مالي استاندارد
        AsnadBedonehSanadehMaliBedonehNegasht
        ' اسناد قطعي فاقد سند مالي  _ فاقد نگاشت
    End Enum

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
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNegasht))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dcbNoeReport = New NetSql.Components.DataCombo(Me.components)
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.txtNotes)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.dcbNoeReport)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbNoeReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtNotes, 0)
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
        Me.btnChart.Location = New System.Drawing.Point(190, 32)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1060, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "نوع گزارش :"
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
        Me.dcbNoeReport.Items.AddRange(New Object() {"اسناد قطعي نشده", "اسناد بدون نرخ استاندارد ", "اسناد قطعي بدون سند مالي", "اسناد انبار با بيش از يک سند مالي", "اسناد با تاريخ ثبت کوچکتر از  تاريخ قطعي مالي", "اسناد با طرف حساب داراي تفصیلی نادرست و يا غير فعال", "اسناد انبار با مشکل غير فعال بودن تفصیلی کالا و اسناد انبار با تفصیلی کالا نادرست" &
                "", "اسناد با تيک مالي و بدون سند مالي استاندارد", "اسناد قطعي بدون سند مالي - فاقد نگاشت"})
        Me.dcbNoeReport.LateBindingTop = "100"
        Me.dcbNoeReport.Location = New System.Drawing.Point(731, 23)
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
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(99, 32)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 39
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotes.ForeColor = System.Drawing.Color.Blue
        Me.txtNotes.Location = New System.Drawing.Point(320, 8)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(288, 52)
        Me.txtNotes.TabIndex = 40
        '
        'FrmNegasht
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmNegasht"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش کنترل اسناد مالي"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dcbNoeReport As NetSql.Components.DataCombo

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmNegasht
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmNegasht
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmNegasht
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmNegasht)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region

    Private Sub FrmRptNegasht_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        '' Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
        dcbNoeReport.SelectedIndex = NOE_REPORT.AsnadGhateeNashodeh

        setColumnProperties()

        With VFilterAsnadAnbar
            .SelectedToSanadDate = _
                Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali (cn, _
                                                                            Functions.FTDBCommonFunctions.enmDateFormat. _
                                                                               Normal)
            .init()
            .SetProperty()
        End With

    End Sub

    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            .VisibleSanadDate = True
            .VisibleTarakoneshSN = True
            .VisibleAnbar = True
            .ShowDialog (Me)
        End With
    End Sub

    Private Sub btnViewReport_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        Dim vErrMsg As String
        Dim strAnbars, vFromDate, vToDate As Object
        Dim strTarakoneshSN As String

        If dcbNoeReport.SelectedIndex = - 1 Then
            dcbNoeReport.SelectedIndex = 0
        End If

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
        If Trim (gAnbarSelected) <> "" Then
            strAnbars = gAnbarSelected
        End If

        strTarakoneshSN = VFilterAsnadAnbar.SelectedTarakoneshSN

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then

            Me.Cursor = Cursors.WaitCursor

            With GridEX1

                Select Case dcbNoeReport.SelectedIndex
                    Case NOE_REPORT.AsnadGhateeNashodeh

                        .DataSource = cn.SPQuery ("_abSpr_Negasht_AsnadGhateeNashodeh", vFromDate, vToDate, strAnbars _
                                                  , gVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBedonehNerkhStandard

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBedonehNerkhStandard", vFromDate, vToDate, strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBedonehSanadehMali

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBedonehSanadehMali", vFromDate, vToDate, strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)

                        'Case NOE_REPORT.AsnadBedonehNerkhVaghei

                        '  .DataSource = cn.SPQuery("_abSpr_Negasht_AsnadBedonehNerkhVaghei", vFromDate, vToDate, strAnbars, strNoeAnbars _
                        '                                , vVahedeTejariSN, strTarakoneshSN)

                        'Case NOE_REPORT.AsnadBedonehSanadMaliTasvie

                        '  .DataSource = cn.SPQuery("_abSpr_Negasht_AsnadBedonehSanadMaliTasvie", vFromDate, vToDate, strAnbars, strNoeAnbars _
                        '                                , vVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBaSanadMaliTekrari

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBaSanadMaliTekrari", vFromDate, vToDate, strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBaTarikhGhateiKochktar

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBaTarikhGhateiKochktar", vFromDate, vToDate, strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBaTafsiliNadorost

                        .DataSource = cn.SPQuery ("_abSpr_Negasht_AsnadBaTafsiliNadorost", vFromDate, vToDate, strAnbars _
                                                  , gVahedeTejariSN, strTarakoneshSN)

                    Case NOE_REPORT.AsnadBaTafsiliKalaNadorost

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBaTafsiliKalaNadorost", vFromDate, vToDate, strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)
                    Case NOE_REPORT.AsnadBaTikeMaliBedonehSanadMaliStandard

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBaTikeMaliBedonehSanadMaliStandard", vFromDate, vToDate, _
                                        strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)
                    Case NOE_REPORT.AsnadBedonehSanadehMaliBedonehNegasht

                        .DataSource = _
                            cn.SPQuery ("_abSpr_Negasht_AsnadBedonehSanadehMaliBedonehNegasht", vFromDate, vToDate, _
                                        strAnbars _
                                        , gVahedeTejariSN, strTarakoneshSN)
                    Case Else
                        NetSql.Common.CSystem.MsgBox("نوع گزارش نامشخص است", _
                                   MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                                   MsgBoxStyle.MsgBoxRight, Me.Text)

                End Select

                RefreshDataSet()
                Me.Cursor = Cursors.Default

            End With

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub dcbNoeReport_SelectedIndexChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles dcbNoeReport.SelectedIndexChanged

        Dim vMsg As String
        ' متغيير جهت پرکردن محل توضيحات
        vMsg = "شرايط حاکم بر گزارش :"

        Select Case dcbNoeReport.SelectedIndex
            Case NOE_REPORT.AsnadGhateeNashodeh
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد قطعي نشده"
                vMsg = vMsg & Chr (13) & Chr (10) & "فقط اسنادي که مي بايست سند مالي داشته باشند"

            Case NOE_REPORT.AsnadBedonehNerkhStandard
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد قطعي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست سند مالي داشته باشند"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون نرخ استاندارد"

            Case NOE_REPORT.AsnadBedonehSanadehMali
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد قطعي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست سند مالي داشته باشند"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد با نرخ استاندارد"

                'Case NOE_REPORT.AsnadBedonehNerkhVaghei
                '  vMsg = vMsg & Chr(13) & Chr(10) & "اسناد قطعي"
                '  vMsg = vMsg & Chr(13) & Chr(10) & "نوع اسناد داراي نرخ واقعي"
                '  vMsg = vMsg & Chr(13) & Chr(10) & "اسناد بدون نرخ واقعي"

                'Case NOE_REPORT.AsnadBedonehSanadMaliTasvie
                '  vMsg = vMsg & Chr(13) & Chr(10) & "اسناد قطعي"
                '  vMsg = vMsg & Chr(13) & Chr(10) & "نوع اسناد داراي نرخ واقعي"
                '  vMsg = vMsg & Chr(13) & Chr(10) & "اسناد با نرخ واقعي"
                '  vMsg = vMsg & Chr(13) & Chr(10) & "سند مالي واقعي نخورده"

            Case NOE_REPORT.AsnadBaSanadMaliTekrari
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد انبار با بيش از يک سند مالي"

            Case NOE_REPORT.AsnadBaTarikhGhateiKochktar
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست سند مالي داشته باشند"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد انبار با تاريخ ثبت سند کوچکتر از آخرين تاريخ قطعي اسناد مالي"

            Case NOE_REPORT.AsnadBaTafsiliNadorost
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست سند مالي داشته باشند"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & _
                       " اسناد انبار با مشکل غير فعال بودن طرف حساب و اسناد انبار با تفصیلی نادرست"

            Case NOE_REPORT.AsnadBaTafsiliKalaNadorost
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست سند مالي داشته باشند"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & _
                       "اسناد انبار با مشکل غير فعال بودن تفصیلی کالا و اسناد انبار با تفصیلی کالا نادرست"

            Case NOE_REPORT.AsnadBaTikeMaliBedonehSanadMaliStandard
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد با تيک مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"

            Case NOE_REPORT.AsnadBedonehSanadehMaliBedonehNegasht
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد قطعي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد فاقد نگاشت"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسناد بدون سند مالي"
                vMsg = vMsg & Chr (13) & Chr (10) & "اسنادي که مي بايست داراي سند مالي باشند"

            Case Else
                vMsg = ""

        End Select

        txtNotes.Text = vMsg

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery ( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Negasht' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add (dvTableFooter.Item (i).Item ("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item (i).Item ("ObjectHaFDS")

                End With

            End With
        Next
        GridEX1.RootTable.Columns ("MeghdareVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MeghdareVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MeghdareVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MeghdareSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MeghdareSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MeghdareSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("GheymateStandardVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("GheymateStandardVaredeh").FormatString = "#,#"
        GridEX1.RootTable.Columns ("GheymateStandardVaredeh").TotalFormatString = "#,#"

        GridEX1.RootTable.Columns ("SahmHazineSanadBVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SahmHazineSanadBVaredeh").FormatString = "#,#"
        GridEX1.RootTable.Columns ("SahmHazineSanadBVaredeh").TotalFormatString = "#,#"

        GridEX1.RootTable.Columns ("GheymateStandardSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("GheymateStandardSadereh").FormatString = "#,#"
        GridEX1.RootTable.Columns ("GheymateStandardSadereh").TotalFormatString = "#,#"

        GridEX1.RootTable.Columns ("SahmHazineSanadBSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SahmHazineSanadBSadereh").FormatString = "#,#"
        GridEX1.RootTable.Columns ("SahmHazineSanadBSadereh").TotalFormatString = "#,#"


    End Sub
End Class
