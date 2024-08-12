'Author ::زهره ايزدپناه
'CreateDate :: 1387/10/01
'ModifiedDate::
'Description:: گزارش ريالي و تعدادي انبار
'System ::انبار
Imports System.Data.SqlClient

Public Class FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim




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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Size = New System.Drawing.Size(1046, 67)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(7, 32)
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(3, 7)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 67)
        Me.pnlGrid.Size = New System.Drawing.Size(1046, 431)
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
        Me.GridEX1.Size = New System.Drawing.Size(1046, 431)
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
        Me.btnChart.Location = New System.Drawing.Point(0, 0)
        Me.btnChart.Size = New System.Drawing.Size(10, 10)
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
        Me.pnlDownJanus.Size = New System.Drawing.Size(1046, 36)
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
        'FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1046, 534)
        Me.Name = "FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش شماره بچ های ثبت نشده رسیدهای حمل مستقیم مشتری"
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

    Private Shared m_vb6FormDefInstance As FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Private Variable"

    'Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

#End Region

    Private Sub FrmRptShomarehBachhayeSabtNashodehAnbarMostaghim_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        'Dim vSqlVahedTejari As String
        'Dim vSqlAnbar As String
        Me.WindowState = FormWindowState.Maximized

        'vSqlVahedTejari =
        '    " SELECT 'همه موارد' AS VahedeTejariDs , 0 AS VahedeTejariSN UNION  SELECT DISTINCT VahedeTejariNo +'-'+VahedeTejariDs AS VahedeTejariDs ,T1.VahedeTejariSN From paVahedeTejari T1" &
        '     "where PedarVahedeTejariSN = 9.935"


        'dcbVahedeTejari.LateBinding = True
        'dcbVahedeTejari.Bind(cn, vSqlVahedTejari, "VahedeTejariSN", "VahedeTejariDs")
        'dcbVahedeTejari.SelectedValue = 0

        ' SetColumnProperties()


    End Sub

    Private Sub btnViewReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnViewReport.Click



        Dim sda As New SqlDataAdapter
        Dim ds As New DataSet
        Dim Cmnd As New SqlCommand
        If gVahedeTejariSN = 9.935 Then
            gVahedeTejariSN = 0
            gAnbarSN = 0
        End If


        Try

            Cmnd.CommandText = "abSPr_GetAsnadHamleMostaghimDaroo_NotChangeBatch"
            'Cmnd.Parameters.AddWithValue("@Command", "")
            Cmnd.Parameters.AddWithValue("@VahedeTejariSN", gVahedeTejariSN)
            Cmnd.Parameters.AddWithValue("@AnbarSN", gAnbarSN)
            Cmnd.Connection = cn.Connection
            Cmnd.CommandType = CommandType.StoredProcedure
            Cmnd.CommandTimeout = cn.CommandTimeout
            sda.SelectCommand = Cmnd
            sda.Fill(ds)
            ShowGrid(ds.Tables(0).DefaultView, True)

            ' Return ds

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        Finally
        End Try




    End Sub

    Sub ShowGrid(ByVal dv As DataView, ByVal AllLevel As Boolean)
        Try
            With GridEX1
                .DataSource = dv

                .RetrieveStructure()
                .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.False
                .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                .ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .GroupByBoxVisible = True
                .ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.True
                .GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
                .RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
                .RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
                .ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic
                .AcceptsEscape = True
                .AllowColumnDrag = True
                .AutoEdit = False
                .RightToLeft = RightToLeft.Yes
                .RecordNavigator = True
                .HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
                .GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
                .GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
                .TotalRow = Janus.Windows.GridEX.InheritableBoolean.True


                .AutoSizeColumns()
                .Refresh()
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub



End Class
