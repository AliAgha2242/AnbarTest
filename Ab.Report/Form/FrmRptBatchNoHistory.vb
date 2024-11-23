' Add Form By Bagheri (HB) 14030823
Imports Anbar.BRL
Imports Minoo.Applications.Anbar.Common.dsSanad
Imports System.Data.SqlClient

Public Class FrmRptBatchNoHistory
    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6formdefinstance As FrmRptBatchNoHistory
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents CmbMahsool As cmpCheckedComboBox
    Friend WithEvents Label3 As Label
    Private components As System.ComponentModel.IContainer

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

    Public Shared Property DefInstance() As FrmRptBatchNoHistory

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmRptBatchNoHistory
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmRptBatchNoHistory)
            m_vb6formdefinstance = Value

        End Set

    End Property


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptBatchNoHistory))
        Me.CmbMahsool = New cmpCheckedComboBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.batchNoReportBtn = New System.Windows.Forms.Button()
        Me.EnghezaReposrtBtn = New System.Windows.Forms.Button()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.AutoSize = True
        Me.pnlF.Controls.Add(Me.EnghezaReposrtBtn)
        Me.pnlF.Controls.Add(Me.batchNoReportBtn)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.CmbMahsool)
        Me.pnlF.Size = New System.Drawing.Size(1393, 42)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsool, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.batchNoReportBtn, 0)
        Me.pnlF.Controls.SetChildIndex(Me.EnghezaReposrtBtn, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(12, 5)
        Me.btnViewReport.Visible = False
        '
        'pnlGrid
        '
        Me.pnlGrid.AutoSize = True
        Me.pnlGrid.Location = New System.Drawing.Point(0, 42)
        Me.pnlGrid.Size = New System.Drawing.Size(1393, 339)
        '
        'pnlCommand
        '
        Me.pnlCommand.AutoSize = True
        Me.pnlCommand.Size = New System.Drawing.Size(377, 94)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Lavender
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.Lavender
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.GroupTotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(1393, 339)
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
        Me.btnChart.BackColor = System.Drawing.Color.Pink
        Me.btnChart.Location = New System.Drawing.Point(106, 5)
        Me.btnChart.UseVisualStyleBackColor = False
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.AutoSize = True
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 381)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1393, 94)
        '
        'CmbMahsool
        '
        CmbMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsool_DesignTimeLayout.LayoutString")
        Me.CmbMahsool.DesignTimeLayout = CmbMahsool_DesignTimeLayout
        Me.CmbMahsool.LateBinding = True
        Me.CmbMahsool.LateBindingTop = "100"
        Me.CmbMahsool.Location = New System.Drawing.Point(250, -7)
        Me.CmbMahsool.Name = "CmbMahsool"
        Me.CmbMahsool.SaveSettings = False
        Me.CmbMahsool.Size = New System.Drawing.Size(100, 21)
        Me.CmbMahsool.TabIndex = 192
        Me.CmbMahsool.ValuesDataMember = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(250, -7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 191
        '
        'batchNoReportBtn --Added by Tavakoli
        '
        Me.batchNoReportBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.batchNoReportBtn.Location = New System.Drawing.Point(1420, 9)
        Me.batchNoReportBtn.Name = "batchNoReportBtn"
        Me.batchNoReportBtn.Size = New System.Drawing.Size(133, 30)
        Me.batchNoReportBtn.TabIndex = 193
        Me.batchNoReportBtn.Text = "تاریخچه سری ساخت"
        Me.batchNoReportBtn.UseVisualStyleBackColor = False
        Me.batchNoReportBtn.BackColor = Color.Pink
        '
        'EnghezaReposrtBtn --Added by Tavakoli
        '
        Me.EnghezaReposrtBtn.Location = New System.Drawing.Point(1280, 9)
        Me.EnghezaReposrtBtn.Name = "EnghezaReposrtBtn"
        Me.EnghezaReposrtBtn.Size = New System.Drawing.Size(133, 30)
        Me.EnghezaReposrtBtn.TabIndex = 193
        Me.EnghezaReposrtBtn.Text = "تاریخچه انقضا"
        Me.EnghezaReposrtBtn.UseVisualStyleBackColor = False
        '
        'FrmRptBatchNoHistory
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1393, 475)
        Me.Name = "FrmRptBatchNoHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش تاریخچه تغییرات سری ساخت"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.pnlDownJanus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub FrmRptBatchNoHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tavkoli
        'setColumnProperties()
        Call batchNoReportBtn_Click(sender, e)

    End Sub

    Private Sub setColumnProperties()
        Dim dvTableFooter As DataView
        Dim i As Integer

        'dvTableFooter =
        '    cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_Raked' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        'For i = 0 To dvTableFooter.Count - 1
        '    With GridEX1.RootTable.Columns()
        '        With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
        '            .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

        '        End With

        '    End With
        'Next

    End Sub


    'Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click

    'End Sub

    Friend WithEvents EnghezaReposrtBtn As Button
    Friend WithEvents batchNoReportBtn As Button

    Private Sub batchNoReportBtn_Click(sender As Object, e As EventArgs) Handles batchNoReportBtn.Click
        'برای تاریخچه شماره رهگیری های کالا 
        'Added by aliAsghar Tavakoli

        EnghezaReposrtBtn.BackColor = Color.White
        batchNoReportBtn.BackColor = Color.Pink
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim KalaNo, BatchNoNew As String
        Dim KalaDs As String
        Dim BatchNoOld As String
        Dim VahedeTejariDs As String

        'Dim vFKalaCode As Object
        'Dim vTKalaCode As Object
        Dim TaminVahedeTejariDs As String
        Dim ChangeDateTime As String
        Dim vFromSabtDate As Object
        Dim vToSabtDate As Object
        Dim vStrFilterSelectedTaminKonandehSN As String

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش


        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد


        Me.Cursor = Cursors.WaitCursor

        Dim CheckNoeVahedTejari As Boolean = IsVahedTejariTolidi

        Dim _XmlStr As String = "<DsSanad>"

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsj As New DataSet
        Dim i As Integer
        Dim _ErrMsg As String = ""


        Dim StrSPName As String = "abSpR_BatchNoHistory"


        Cmnd.CommandText = StrSPName
        Cmnd.Connection = cn.Connection 'mcn
        Cmnd.CommandType = CommandType.StoredProcedure
        Cmnd.CommandTimeout = cn.ConnectionTimeout
        da.SelectCommand = Cmnd
        da.Fill(dsj)
        GridEX1.DataSource = dsj.Tables(0)
        GridEX1.RetrieveStructure()
        ' For Performence Added By AliAghar Tavakoli
        If GridEX1.RowCount <= 5000 Then
            GridEX1.AutoSizeColumns()
        End If



        'RefreshDataSet()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EnghezaReposrtBtn_Click(sender As Object, e As EventArgs) Handles EnghezaReposrtBtn.Click
        'برای فرم تاریخچه انقضای کالا
        'Added by aliAsghar Tavakoli
        EnghezaReposrtBtn.BackColor = Color.Pink
        batchNoReportBtn.BackColor = Color.White
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim KalaNo, BatchNoNew As String
        Dim KalaDs As String
        Dim BatchNoOld As String
        Dim VahedeTejariDs As String

        'Dim vFKalaCode As Object
        'Dim vTKalaCode As Object
        Dim TaminVahedeTejariDs As String
        Dim ChangeDateTime As String
        Dim vFromSabtDate As Object
        Dim vToSabtDate As Object
        Dim vStrFilterSelectedTaminKonandehSN As String

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش


        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد


        Me.Cursor = Cursors.WaitCursor

        Dim CheckNoeVahedTejari As Boolean = IsVahedTejariTolidi

        Dim _XmlStr As String = "<DsSanad>"

        Dim da As New SqlDataAdapter
        Dim Cmnd As New SqlCommand
        Dim dsj As New DataSet
        Dim i As Integer
        Dim _ErrMsg As String = ""


        Dim StrSPName As String = "abSpR_EnghezaDateHistory"


        Cmnd.CommandText = StrSPName
        Cmnd.Connection = cn.Connection 'mcn
        Cmnd.CommandType = CommandType.StoredProcedure
        Cmnd.CommandTimeout = cn.ConnectionTimeout
        da.SelectCommand = Cmnd
        da.Fill(dsj)
        GridEX1.DataSource = dsj.Tables(0)
        GridEX1.RetrieveStructure()

        ' For Performence Added By AliAghar Tavakoli
        If GridEX1.RowCount <= 5000 Then
            GridEX1.AutoSizeColumns()
        End If



        'RefreshDataSet()
        Me.Cursor = Cursors.Default
    End Sub
End Class
