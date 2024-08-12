'Author ::زهره ايزدپناه
'CreateDate :: 1387/10/10
'ModifiedDate::
'Description:: گزارش ريالي و تعدادي عملکرد انبار
'System ::انبار
Imports System.Data.SqlClient
Public Class FrmAmalkard
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
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShowRialiColumn As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAmalkard))
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShowRialiColumn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.btnShowRialiColumn)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnShowRialiColumn, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
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
        'dcbKala
        '
        Me.dcbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala.AutoSelectFirst = False
        Me.dcbKala.BackColor = System.Drawing.Color.White
        Me.dcbKala.BoundText = Nothing
        Me.dcbKala.BypassChangeEvent = False
        Me.dcbKala.DisplayText = ""
        Me.dcbKala.LateBindingTop = "100"
        Me.dcbKala.Location = New System.Drawing.Point(653, 15)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(327, 21)
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
        'btnShowRialiColumn
        '
        Me.btnShowRialiColumn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowRialiColumn.Location = New System.Drawing.Point(190, 33)
        Me.btnShowRialiColumn.Name = "btnShowRialiColumn"
        Me.btnShowRialiColumn.Size = New System.Drawing.Size(88, 32)
        Me.btnShowRialiColumn.TabIndex = 9
        Me.btnShowRialiColumn.Text = "نمايش ستونهاي ريالي"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(984, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "کالا : "
        '
        'FrmAmalkard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmAmalkard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش عملکرد انبار"
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

    Private Shared m_vb6FormDefInstance As FrmAmalkard
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmAmalkard
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAmalkard
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmAmalkard)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region

    Private Sub FrmRptAmalkardRiali_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql =
            " SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " &
            gAnbarSelected.ToString & "  )  "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        setColumnProperties()

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar

            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = True
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .WhereConditionColumnTarakonesh = " CONVERT(VARCHAR(10),abSanad.TarakoneshSN) "
            .WhereConditionColumnTarakoneshSN = " abSanad.TarakoneshSN "
            .SetProperty()
        End With

    End Sub

    Private Sub cmdOK_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
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
        Dim vStrFilterSelectedTaminKonandehSN As String

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

            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala
            End If

            If Trim(VFilterAsnadAnbar.SelectedTarakoneshSN) <> "" Then
                strTarakoneshs = VFilterAsnadAnbar.SelectedTarakoneshSN
            End If

            If Trim(VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN) <> "" Then
                vGoroohBandiTarakonesh = VFilterAsnadAnbar.GoroohBandi_Tarakonesh_FilterSelectedGoroohSN
            End If

            If dcbKala.BoundText <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If Not vStrKalaSN Is Nothing AndAlso vStrKalaSN.Length > 0 Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If
            End If

            If Trim(VFilterAsnadAnbar.SelectedFromSabtDate) <> "" Then
                vFromSabtDate = Trim(VFilterAsnadAnbar.SelectedFromSabtDate)
            End If
            If Trim(VFilterAsnadAnbar.SelectedToSabtDate) <> "" Then
                vToSabtDate = Trim(VFilterAsnadAnbar.SelectedToSabtDate)

            End If
            If String.IsNullOrEmpty(VFilterAsnadAnbar.VisibleTaminKonandeh) = False Then
                vStrFilterSelectedTaminKonandehSN = VFilterAsnadAnbar.SelectedTaminKonandehSN
            End If

            Me.Cursor = Cursors.WaitCursor

            'Dim CAppSet As Minoo.Configuration.CAppSetting = New Minoo.Configuration.CAppSetting(gVahedeTejariSN, 3)
            'Dim CheckNoeVahedTejari As Boolean = IIf(CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi") Is System.DBNull.Value, False, CAppSet.GetAppConfig("gChkNoeVahedeTejariTolidi"))

            Dim CheckNoeVahedTejari As Boolean = IsVahedTejariTolidi

            Dim _XmlStr As String = "<DsSanad>"
            'Dim mcn As New SqlClient.SqlConnection




            'If mcn.State = ConnectionState.Closed Then
            '        mcn.ConnectionString = cn.ConnectionString + ";password = " + cn.SQLPassword
            '        mcn.Open()
            '    End If


            Dim da As New SqlDataAdapter
            Dim Cmnd As New SqlCommand
            Dim dsj As New DataSet
            Dim i As Integer
            Dim _ErrMsg As String = ""


            'GridEX1.DataSource = cn.SPQuery(If(CheckNoeVahedTejari, "_abSpr_Amalkard", "_abSpr_Amalkard_New"), gVahedeTejariSN, CStr(strAnbars) _
            '                                 , vFromDate, vToDate, vStrKalaSN, vSanadStatus _
            '                                 , strTarakoneshs, vStrFilterSelectedGoroohSN,
            '                                  vGoroohBandiTarakonesh, vFromSabtDate, vToSabtDate, vStrFilterSelectedTaminKonandehSN)

            Dim StrSPName As String

            If (CheckNoeVahedTejari) = True Then
                StrSPName = "_abSpr_Amalkard"

            ElseIf (CheckNoeVahedTejari) = False Then
                StrSPName = "_abSpr_Amalkard_New"


            End If



            Cmnd.CommandText = StrSPName
            Cmnd.Parameters.AddWithValue("@Command", "")
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", gVahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@StrAnbarSN", strAnbars)
            Cmnd.Parameters.AddWithValue("@FDate", (vFromDate))
            Cmnd.Parameters.AddWithValue("@TDate", vToDate)
            Cmnd.Parameters.AddWithValue("@StrKalaSN", vStrKalaSN)
            Cmnd.Parameters.AddWithValue("@SanadStatus", vSanadStatus)
            Cmnd.Parameters.AddWithValue("@StrTarakoneshSN", strTarakoneshs)
            Cmnd.Parameters.AddWithValue("@StrFilterSelectedGoroohSN", vStrFilterSelectedGoroohSN)
            Cmnd.Parameters.AddWithValue("@StrFilterSelectedTarakoneshGoroohSN", vGoroohBandiTarakonesh)
            Cmnd.Parameters.AddWithValue("@FromSabtDate", (vFromSabtDate))
            Cmnd.Parameters.AddWithValue("@ToSabtDate", vToSabtDate)
            Cmnd.Parameters.AddWithValue("@StrTaminKonandehSN", vStrFilterSelectedTaminKonandehSN)
            Cmnd.Connection = cn.Connection 'mcn
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = cn.ConnectionTimeout
            da.SelectCommand = Cmnd
            da.Fill(dsj)
            GridEX1.DataSource = dsj.Tables(0)




            RefreshDataSet()
            Me.Cursor = Cursors.Default

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub setColumnProperties()
        Dim i As Integer
        Dim dvTableFooter As DataView

        dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN " & _
                                        "WHERE T1.ObjectDS='abQueryAmalkard' AND ObjectHaNo <> '0' " & _
                                        "ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS").ToString, Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS").ToString
                End With
            End With
        Next


        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_MojoodiAvalDoreh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_MojoodiAvalDoreh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_MojoodiAvalDoreh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiBefor").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBefor").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBefor").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_MojoodiBefor").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_MojoodiBefor").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_MojoodiBefor").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_MojoodiBefor").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_MojoodiBefor").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_MojoodiBefor").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_MojoodiAvalDoreh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_MojoodiAvalDoreh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_MojoodiAvalDoreh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumMandeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_SumMandeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_SumMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_SumMandeh").TotalFormatString = "#,#.###"


        GridEX1.RootTable.Columns ("Can_SumMandeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_SumMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_SumMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumMandeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("LastMojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("LastMojoodi").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Box_LastMojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_LastMojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_LastMojoodi").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_LastMojoodi").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_LastMojoodi").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_LastMojoodi").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiBeforGheymate").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBeforGheymate").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBeforGheymate").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateStandardSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateStandardSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateStandardSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh").TotalFormatString = "#,#.###"


        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateStandardMandeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateStandardMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateStandardMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("LastMojoodiGheymate").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodiGheymate").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("LastMojoodiGheymate").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("LastMojoodiSahmHazine").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodiSahmHazine").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("LastMojoodiSahmHazine").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("LastMojoodiGheymateStandard").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodiGheymateStandard").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("LastMojoodiGheymateStandard").TotalFormatString = "#,#.###"


        GridEX1.RootTable.Columns ("LastMojoodiGheymateTadarokat").AggregateFunction = _
            Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("LastMojoodiGheymateTadarokat").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("LastMojoodiGheymateTadarokat").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumVaredeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumVaredeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumVaredeh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumSadereh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumSadereh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumSadereh").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns("Vazn_SumMandeh").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns("Vazn_SumMandeh").FormatString = "#,#.###"
        GridEX1.RootTable.Columns("Vazn_SumMandeh").TotalFormatString = "#,#.###"

        If Not (gSM.ActionVisible ("mnuRptAmalKardRiali") And gSM.ActionEnabled ("mnuRptAmalKardRiali")) Then
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiBeforGheymate"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateStandardSadereh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateStandardMandeh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("LastMojoodiGheymate"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("LastMojoodiSahmHazine"))

            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("MojoodiAvalDoreh"))
            'GridEX1.RootTable.Columns("LastNerkhStandard").Visible = gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
            'GridEX1.RootTable.Columns.Remove(GridEX1.RootTable.Columns("LastMojoodiGheymateTadarokat"))
            GridEX1.RootTable.Columns.Remove (GridEX1.RootTable.Columns ("LastMojoodiGheymateStandard"))

        Else
            GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate").Visible = False
            'gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
            GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee").Visible = False
            GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine").Visible = False
            GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard").Visible = False

            GridEX1.RootTable.Columns ("MojoodiBeforGheymate").Visible = False
            GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").Visible = False
            GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine").Visible = False
            GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard").Visible = False

            GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh").Visible = False
            GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh").Visible = False
            GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh").Visible = False

            GridEX1.RootTable.Columns ("SumGheymateStandardSadereh").Visible = False
            GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh").Visible = False
            GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh").Visible = False

            GridEX1.RootTable.Columns ("SumGheymateStandardMandeh").Visible = False
            GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh").Visible = False
            GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh").Visible = False

            GridEX1.RootTable.Columns ("LastMojoodiGheymate").Visible = False
            GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").Visible = False
            GridEX1.RootTable.Columns ("LastMojoodiSahmHazine").Visible = False

            GridEX1.RootTable.Columns ("MojoodiAvalDoreh").Visible = False
            'GridEX1.RootTable.Columns("LastNerkhStandard").Visible = gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
            'GridEX1.RootTable.Columns("LastMojoodiGheymateTadarokat").Visible = False
            GridEX1.RootTable.Columns ("LastMojoodiGheymateStandard").Visible = False
        End If

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
            .VisibleTarakoneshSN = True
            .VisibleTarakonesh = True
            .VisibleAnbar = True
            .VisibleSabtDate = True
            '//By Izadpanah-851208
            .EnableFromSabtDate = True
            .VisibleTaminKonandeh = True

            .ShowDialog (Me)
        End With
    End Sub

    Private Sub btnShowRialiColumn_Click (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnShowRialiColumn.Click

        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymate").Visible = True
        'gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
        GridEX1.RootTable.Columns ("MojoodiAvalDorehSahmHazine").Visible = True
        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateStandard").Visible = True

        GridEX1.RootTable.Columns ("MojoodiBeforGheymate").Visible = True
        GridEX1.RootTable.Columns ("MojoodiBeforSahmHazine").Visible = True
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateStandard").Visible = True

        GridEX1.RootTable.Columns ("SumGheymateStandardVaredeh").Visible = True
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBVaredeh").Visible = True

        GridEX1.RootTable.Columns ("SumGheymateStandardSadereh").Visible = True
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBSadereh").Visible = True

        GridEX1.RootTable.Columns ("SumGheymateStandardMandeh").Visible = True
        GridEX1.RootTable.Columns ("SumSahmHazineSanadBMandeh").Visible = True

        GridEX1.RootTable.Columns ("LastMojoodiGheymate").Visible = True
        GridEX1.RootTable.Columns ("LastMojoodiSahmHazine").Visible = True

        GridEX1.RootTable.Columns ("MojoodiAvalDoreh").Visible = True
        'GridEX1.RootTable.Columns("LastNerkhStandard").Visible = gSM.ActionVisible("mnuRptAmalKardRiali") And gSM.ActionEnabled("mnuRptAmalKardRiali")
        'GridEX1.RootTable.Columns("LastMojoodiGheymateTadarokat").Visible = True

        GridEX1.RootTable.Columns ("MojoodiAvalDorehGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns ("MojoodiBeforGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns ("SumGheymateVagheeVaredeh").Visible = True
        GridEX1.RootTable.Columns ("SumGheymateVagheeSadereh").Visible = True
        GridEX1.RootTable.Columns ("SumGheymateVagheeMandeh").Visible = True
        GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").Visible = True
        GridEX1.RootTable.Columns ("LastMojoodiGheymateVaghee").Visible = True
    End Sub
End Class
