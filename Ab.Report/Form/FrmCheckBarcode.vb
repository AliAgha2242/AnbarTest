'Author ::زهره ايزدپناه
'CreateDate :: 1387/11/19
'ModifiedDate::
'Description:: گزارش رزرو
'System ::انبار

Public Class FrmCheckBarcode
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
    Friend WithEvents BarCode As System.Windows.Forms.TextBox

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Label5 As System.Windows.Forms.Label


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheckBarcode))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BarCode = New System.Windows.Forms.TextBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.BarCode)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1028, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.BarCode, 0)
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
        Me.btnChart.Location = New System.Drawing.Point(871, 32)
        Me.btnChart.Size = New System.Drawing.Size(10, 10)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 498)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1028, 36)
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
        'BarCode
        '
        Me.BarCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BarCode.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BarCode.Location = New System.Drawing.Point(626, 15)
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Size = New System.Drawing.Size(390, 40)
        Me.BarCode.TabIndex = 8
        '
        'FrmCheckBarcode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Name = "FrmCheckBarcode"
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

    Private Shared m_vb6FormDefInstance As FrmCheckBarcode
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmCheckBarcode
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmCheckBarcode
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmCheckBarcode)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar
#End Region


    Private Sub FrmCheckBarcode_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        setColumnProperties()

        'With VFilterAsnadAnbar
        '    .CheckedSanadStatus_1 = True
        '    .CheckedSanadStatus_4 = True
        '    .CheckedSanadStatus_8 = True
        '    .init()
        '    .SetProperty()
        'End With

    End Sub


    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        dvTableFooter = _
            cn.ExecuteQuery( _
                             "SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_CheckBarcode' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

                End With

            End With
        Next
        

    End Sub

    Private Sub btnFilterAsnadAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        'With VFilterAsnadAnbar
        '    .EnableFromSanadDate = True
        '    .VisibleSanadDate = True
        '    .VisibleKala = True
        '    .VisibleAnbar = True
        '    .ShowDialog(Me)
        'End With

    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click
        Dim vBarcode As String = ""

        vBarcode = CStr(BarCode.Text)
        Me.Cursor = Cursors.WaitCursor
        GridEX1.DataSource = _
            cn.SPQuery("_abSpr_CheckBarcode", vBarcode)
        RefreshDataSet()

        GridEX1.AutoSizeColumns()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarCode_TextChanged(sender As System.Object, e As System.EventArgs) _
        Handles BarCode.TextChanged

        Dim vBarcode As String = ""
        vBarcode = CStr(BarCode.Text)
        Me.Cursor = Cursors.WaitCursor
        GridEX1.DataSource = _
            cn.SPQuery("_abSpr_CheckBarcode", vBarcode)
        RefreshDataSet()

        GridEX1.AutoSizeColumns()

        Me.Cursor = Cursors.Default

    End Sub

End Class
