'Author ::زهره ايزدپناه
'CreateDate :: 1387/11/19
'ModifiedDate::
'Description:: گزارش رزرو
'System ::انبار

Public Class FrmRezerv
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
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents dcbKala As NetSql.Components.DataCombo


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRezerv))
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
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
        Me.btnChart.Location = New System.Drawing.Point(192, 32)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(100, 32)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 5
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1100, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.dcbKala.Location = New System.Drawing.Point(768, 24)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(327, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 8
        '
        'FrmRezerv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmRezerv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش رزرو"
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

    Private Shared m_vb6FormDefInstance As FrmRezerv
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRezerv
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRezerv
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmRezerv)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region


    Private Sub FrmRptRezerv_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        ''Me.Location = New System.Drawing.Size(New System.Drawing.Point(10, 10))
        Me.WindowState = FormWindowState.Maximized
        Dim vSql As String

        vSql = _
            "SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION   SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " & _
            gAnbarSelected.ToString & "  )  "
        dcbKala.LateBinding = True
        dcbKala.Bind (cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        setColumnProperties()

        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = True
            .CheckedSanadStatus_4 = True
            .CheckedSanadStatus_8 = True
            .init()
            .SetProperty()
        End With

    End Sub

    Private Sub btnViewReport_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        Dim vErrMsg, vRezervStatus As String
        Dim strAnbars, strNoeAnbars, vFromDate, vToDate As Object
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN, vStrFilterSelectedChidemanSN As String

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
            If Trim (gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If
            If Trim (VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If

            If dcbKala.BoundText <> "" AndAlso Trim (dcbKala.SelectedValue) <> 0 Then
                If Not vStrKalaSN Is Nothing AndAlso vStrKalaSN.Length > 0 Then
                    vStrKalaSN = vStrKalaSN & "," & CStr (dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr (dcbKala.SelectedValue)
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

            GridEX1.DataSource = _
                cn.SPQuery ("_abSpr_Rezerv", gVahedeTejariSN, strAnbars, vFromDate, vToDate, vStrKalaSN)
            RefreshDataSet()

            Me.Cursor = Cursors.Default
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
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Rezerv' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add (dvTableFooter.Item (i).Item ("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item (i).Item ("ObjectHaFDS")

                End With

            End With
        Next
        GridEX1.RootTable.Columns ("Box_Rezerv").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Box_Rezerv").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Box_Rezerv").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("Can_Rezerv").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("Can_Rezerv").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("Can_Rezerv").TotalFormatString = "#,#.###"

        GridEX1.RootTable.Columns ("MeghdarRezerv").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridEX1.RootTable.Columns ("MeghdarRezerv").FormatString = "#,#.###"
        GridEX1.RootTable.Columns ("MeghdarRezerv").TotalFormatString = "#,#.###"

    End Sub

    Private Sub btnFilterAsnadAnbar_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            .VisibleSanadDate = True
            .VisibleKala = True
            .VisibleAnbar = True
            .ShowDialog (Me)
        End With

    End Sub
End Class
