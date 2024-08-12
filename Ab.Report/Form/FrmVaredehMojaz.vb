'Author ::رسول ابوالحسنی یکتا
'CreateDate :: 1397/02/22
'ModifiedDate::
'Description:: گزارش وارده مجاز
'System ::انبار

Imports Anbar.BRL

Public Class FrmVaredehMojaz
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
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtToDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVaredehMojaz))
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.TxtToDate)
        Me.pnlF.Controls.Add(Me.TxtFromDate)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtFromDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtToDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(12, 5)
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
        Me.btnChart.Location = New System.Drawing.Point(106, 5)
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
        Me.dcbKala.Location = New System.Drawing.Point(660, 13)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(328, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1100, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.Location = New System.Drawing.Point(493, 13)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 168
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TxtToDate
        '
        Me.TxtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtToDate.Location = New System.Drawing.Point(320, 12)
        Me.TxtToDate.Mask = "9900/90/90"
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 169
        Me.TxtToDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(596, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "از تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "تا تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(993, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "کالا :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmVaredehMojaz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmVaredehMojaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش وارده مجاز"
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

    Private Shared m_vb6FormDefInstance As FrmVaredehMojaz
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmVaredehMojaz
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmVaredehMojaz
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmVaredehMojaz)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region



    Private Sub FrmVaredehMojaz_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vSql As String
        '' Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
        ' تهيه سلکت براي مقدار دهي کامبو
        vSql =
            " SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN btKalaVaredehMojaz T2 ON T1.KalaSN = T2.KalaSN  "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        setColumnProperties()


        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد

    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        '    ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        '    ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN As String
        Dim strAnbars As Object
        Dim strTarakoneshs As String
        'Dim vFKalaCode As Object
        'Dim vTKalaCode As Object
        Dim vSanadStatus, vNoeTarakoneshKalaNO As String
        Dim vGoroohBandiTarakonesh As String
        Dim vFromSabtDate As Object
        Dim vToSabtDate As Object

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش


        If TxtFromDate.Text <> "" And TxtFromDate.Text <> "[هیج مقداری انتخاب نشده]" And TxtFromDate.Text <> "    /  /" Then
            vFromDate = TxtFromDate.Text.Replace("/", "")
        Else
            vFromDate = ""
        End If
        If TxtToDate.Text <> "" And TxtToDate.Text <> "[هیج مقداری انتخاب نشده]" And TxtToDate.Text <> "    /  /" Then
            vToDate = TxtToDate.Text.Replace("/", "")
        Else
            vToDate = ""
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
            If dcbKala.BoundText <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If Not vStrKalaSN Is Nothing AndAlso vStrKalaSN.Length > 0 Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If
            Else
                vStrKalaSN = ""
            End If



            Me.Cursor = Cursors.WaitCursor


            'GridEX1.DataSource = cn.SPQuery("_abSpr_VaredehMojaz", gVahedeTejariSN, CStr(strAnbars) _
            '                                 , vFromDate, vToDate, vStrKalaSN)
            Dim thisWaitFrm As New Anbar.Common.Frmwait
            thisWaitFrm.Show()
            thisWaitFrm.Refresh()
            Try
                Dim _d As New ClsDataAccessRule
                Dim dv As DataView
                GridEX1.DataSource = Nothing
                dv = _d.GetVaredehMojaz(gVahedeTejariSN, vStrKalaSN, vFromDate, vToDate, cn, tp)

                If dv Is Nothing Then
                    'MsgBox("اطلاعات مورد نظر دريافت نشد", MsgBoxStyle.OkOnly, "پيغام")
                    thisWaitFrm.Close()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                '---------add by yekta 920910-------------change by yekta 921114


                For i As Integer = 0 To dv.Table.Rows.Count - 1
                    'dv.Item(i).Item("FromDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("FromDate").ToString, EnumDateFormat.dfFullYear)
                    'dv.Item(i).Item("FromDate") = dv.Item(i).Item("FromDate").ToString.Substring(0, 4) + "/" + dv.Item(i).Item("FromDate").ToString.Substring(4, 2) + "/" + dv.Item(i).Item("FromDate").ToString.Substring(6, 2)

                    'dv.Item(i).Item("ToDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("ToDate").ToString, EnumDateFormat.dfFullYear)
                    'dv.Item(i).Item("ToDate") = dv.Item(i).Item("ToDate").ToString.Substring(0, 4) + "/" + dv.Item(i).Item("ToDate").ToString.Substring(4, 2) + "/" + dv.Item(i).Item("ToDate").ToString.Substring(6, 2)

                    If dv.Item(i).Item("FromDate").ToString <> "" Then
                        If dv.Item(i).Item("FromDate").length > 8 Then
                            dv.Item(i).Item("FromDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("FromDate").ToString, EnumDateFormat.dfFullYear)
                        End If

                        dv.Item(i).Item("FromDate") = dv.Item(i).Item("FromDate").ToString.Substring(0, 4) + "/" + dv.Item(i).Item("FromDate").ToString.Substring(4, 2) + "/" + dv.Item(i).Item("FromDate").ToString.Substring(6, 2)
                    End If
                    If dv.Item(i).Item("ToDate").ToString <> "" Then
                        If dv.Item(i).Item("ToDate").length > 8 Then
                            dv.Item(i).Item("ToDate") = NetSql.Common.CShamsiDate.FormatDate(dv.Item(i).Item("ToDate").ToString, EnumDateFormat.dfFullYear)
                        End If

                        dv.Item(i).Item("ToDate") = dv.Item(i).Item("ToDate").ToString.Substring(0, 4) + "/" + dv.Item(i).Item("ToDate").ToString.Substring(4, 2) + "/" + dv.Item(i).Item("ToDate").ToString.Substring(6, 2)
                    End If


                Next
                '---------add by yekta 920910-------------change by yekta 921114

                GridEX1.DataSource = dv

                'SetCaptions()

                'SetVaziat()

                RefreshDataSet()

                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default

            Catch ex As Exception
                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default
                NetSql.Common.CSystem.MsgBox("اشكالي در تهيه ي اين گزارش بوجود آمده است. ", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
            End Try
            'RefreshDataSet()
            Me.Cursor = Cursors.Default

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg,
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub setColumnProperties()
        Dim i As Integer
        Dim dvTableFooter As DataView

        dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN " &
                                        "WHERE T1.ObjectDS='abQueryVaredehMojaz' AND ObjectHaNo <> '0' " &
                                        "ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS").ToString, Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS").ToString
                End With
            End With
        Next


        GridEX1.RootTable.Columns("VaredehMojazKalaSN").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("VaredehMojazKalaSN").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("VaredehMojazKalaSN").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("VaredehMojaz").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("VaredehMojaz").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("VaredehMojaz").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("MeghdareResid").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("MeghdareResid").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("MeghdareResid").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Moghayerat").AggregateFunction =
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Moghayerat").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Moghayerat").TotalFormatString = "#,#.###"


    End Sub

    Private Sub btnShowRialiColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        GridEX1.RootTable.Columns("MojoodiAvalDorehGheymate").Visible = True
        'gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
        GridEX1.RootTable.Columns("MojoodiAvalDorehSahmHazine").Visible = True
        GridEX1.RootTable.Columns("MojoodiAvalDorehGheymateStandard").Visible = True

        GridEX1.RootTable.Columns("MojoodiBeforGheymate").Visible = True
        GridEX1.RootTable.Columns("MojoodiBeforSahmHazine").Visible = True
        GridEX1.RootTable.Columns("MojoodiBeforGheymateStandard").Visible = True

        GridEX1.RootTable.Columns("SumGheymateStandardVaredeh").Visible = True
        GridEX1.RootTable.Columns("SumSahmHazineSanadBVaredeh").Visible = True

        GridEX1.RootTable.Columns("SumGheymateStandardSadereh").Visible = True
        GridEX1.RootTable.Columns("SumSahmHazineSanadBSadereh").Visible = True

        GridEX1.RootTable.Columns("SumGheymateStandardMandeh").Visible = True
        GridEX1.RootTable.Columns("SumSahmHazineSanadBMandeh").Visible = True

        GridEX1.RootTable.Columns("LastMojoodiGheymate").Visible = True
        GridEX1.RootTable.Columns("LastMojoodiSahmHazine").Visible = True

        GridEX1.RootTable.Columns("MojoodiAvalDoreh").Visible = True
        'GridEX1.RootTable.Columns("LastNerkhStandard").Visible = gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
        'GridEX1.RootTable.Columns("LastMojoodiGheymateTadarokat").Visible = True

        GridEX1.RootTable.Columns("MojoodiAvalDorehGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns("MojoodiBeforGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns("SumGheymateVagheeVaredeh").Visible = True
        GridEX1.RootTable.Columns("SumGheymateVagheeSadereh").Visible = True
        GridEX1.RootTable.Columns("SumGheymateVagheeMandeh").Visible = True
        GridEX1.RootTable.Columns("LastMojoodiGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns("LastMojoodiGheymateVaghee").Visible = True
    End Sub
End Class
