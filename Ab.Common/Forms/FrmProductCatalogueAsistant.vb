Option Strict On
Option Explicit On
Public Class FrmProductCatalogueAsistant
    Inherits Minoo.Base.FTBaseForm

    Private Shared m_vb6formdefinstance As FrmProductCatalogueAsistant
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents Panel1 As Panel
    Public WithEvents GridReport As Janus.Windows.GridEX.GridEX
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


    Private Sub InitializeComponent()
        Dim GridReport_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridReport = New Janus.Windows.GridEX.GridEX()
        Me.Panel1.SuspendLayout()
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1341, 446)
        Me.Panel1.TabIndex = 0
        '
        'GridReport
        '
        Me.GridReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridReport.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DisplayedCellsAndHeader
        Me.GridReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridReport_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><GroupCondition /></Root" &
    "Table></GridEXLayoutData>"
        Me.GridReport.DesignTimeLayout = GridReport_DesignTimeLayout
        Me.GridReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReport.DynamicFiltering = True
        Me.GridReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridReport.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridReport.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridReport.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridReport.GroupByBoxVisible = False
        Me.GridReport.Location = New System.Drawing.Point(0, 0)
        Me.GridReport.Name = "GridReport"
        Me.GridReport.RecordNavigator = True
        Me.GridReport.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReport.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridReport.Size = New System.Drawing.Size(1341, 446)
        Me.GridReport.TabIndex = 15
        Me.GridReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FrmProductCatalogueAsistant
        '
        Me.ClientSize = New System.Drawing.Size(1341, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmProductCatalogueAsistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Public DvSource As DataView
    Public SelectedKalaSN As Decimal
    Public SelectedNerkh As Integer
    Public HideSNColumns As Boolean
    Public SelectedDarkhastSN As Decimal
    Public SelectedFactorSN As Decimal
    Public SelectedFactorAsliSN As Decimal
    Public SelectedSanadSN As Decimal
    Public SelectedBatchNo As String
    Public ArrayOfHideColumns As String()
    Public ArrayOfShowColumns As String()
    Public NoeForm As Integer
    Public FormatCondition1 As Janus.Windows.GridEX.GridEXFormatCondition

    'TakhsisMahsul = 1
    'TakhsisDarkhast = 2
    'TakhsisFactor = 3
    'EditBatch = 4

    Private Sub FrmProductCatalogueAsistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridReport.DataSource = DvSource
        GridReport.RetrieveStructure()
        For Each col As Janus.Windows.GridEX.GridEXColumn In GridReport.RootTable.Columns
            If col.Key.ToUpper.EndsWith("SN") And HideSNColumns Then
                col.Visible = False
            End If
            If ArrayOfHideColumns IsNot Nothing AndAlso ArrayOfHideColumns.Length > 0 Then
                For Each item As String In ArrayOfHideColumns
                    If col.Key.ToUpper = item.ToUpper Then
                        col.Visible = False
                    End If
                Next
            End If
            If ArrayOfShowColumns IsNot Nothing AndAlso ArrayOfShowColumns.Length > 0 Then
                col.Visible = False
                For Each item As String In ArrayOfShowColumns
                    If col.Key.ToUpper = item.ToUpper Then
                        col.Visible = True
                    End If
                Next
            End If

            If col.Key.ToUpper.EndsWith("DS") Then
                col.Width = 200
            End If
        Next

        If FormatCondition1 IsNot Nothing Then
            FormatCondition1.Column = GridReport.RootTable.Columns(FormatCondition1.Column.Key)
            GridReport.RootTable.FormatConditions.Add(FormatCondition1)
        End If


        GridReport.AutoSizeColumns()


    End Sub

    Private Sub GridReport_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GridReport.MouseDoubleClick
        If GridReport.CurrentRow Is Nothing Then
            Exit Sub
        ElseIf GridReport.CurrentRow.RowType <> Janus.Windows.GridEX.RowType.Record Then
            Exit Sub
        Else

            If DvSource.ToTable.Columns("KalaSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("KalaSN").Value) Then
                    SelectedKalaSN = CDec(GridReport.CurrentRow.Cells("KalaSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("Nerkh") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("Nerkh").Value) Then
                    SelectedNerkh = CInt(GridReport.CurrentRow.Cells("Nerkh").Value)
                End If
            End If
            If DvSource.ToTable.Columns("DarkhastSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("DarkhastSN").Value) Then
                    SelectedDarkhastSN = CDec(GridReport.CurrentRow.Cells("DarkhastSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("SanadSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("SanadSN").Value) Then
                    SelectedSanadSN = CDec(GridReport.CurrentRow.Cells("SanadSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("FactorAsliSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("FactorAsliSN").Value) Then
                    SelectedFactorAsliSN = CDec(GridReport.CurrentRow.Cells("FactorAsliSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("FactorSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("FactorSN").Value) Then
                    SelectedFactorSN = CDec(GridReport.CurrentRow.Cells("FactorSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("ShomarehRahgiri") IsNot Nothing Then
                If Not IsNothing(GridReport.CurrentRow.Cells("ShomarehRahgiri").Text) Then
                    SelectedBatchNo = (GridReport.CurrentRow.Cells("ShomarehRahgiri").Text)
                End If
            End If

            If NoeForm = 4 AndAlso GridReport.RowCount > 0 Then
                Dim Grow As Janus.Windows.GridEX.GridEXRow = GridReport.CurrentRow

                If Grow IsNot Nothing AndAlso Grow.RowType = Janus.Windows.GridEX.RowType.Record Then

                    If CSystem.MsgBox("آیا مایل به اصلاح بچ کالا رهگیری " + vbNewLine + Grow.Cells("KalaDS").Text + vbNewLine +
                                      "بچ : " + Grow.Cells("ShomarehRahgiri").Text + vbNewLine + " می باشید؟" + vbNewLine +
                                        "توجه داشته باشید با ادامه عملیات اصلاح بچ سند کسری انبار برای بچ قدیم و سند اضافی انبار برای بچ جدید صادر خواهد شد " + vbNewLine + vbNewLine +
                                        "مشخصه بچ قدیم : " + vbNewLine + "بچ : " + Grow.Cells("ShomarehRahgiri").Text + vbNewLine +
                                       "تاریخ انقضا : " + Grow.Cells("EnghezaDate").Text + vbNewLine +
                                      "تاریخ تولید : " + Grow.Cells("ToolidDate").Text + vbNewLine +
                                      "موجودی سیستمی بچ جهت صدور کسری انبار : " + CInt(Grow.Cells("Mojoudi").Value).ToString + vbNewLine + vbNewLine +
                                       "مشخصه بچ جدید :" + vbNewLine + "بچ : " + Grow.Cells("BatchCode").Text + vbNewLine +
                                      "تاریخ انقضا : " + Grow.Cells("JalaliExpireDate").Text + vbNewLine +
                                      "تاریخ تولید : " + Grow.Cells("JalaliManufacturingDate").Text + vbNewLine +
                                      "موجودی فیزیکی اسکن شده بچ توسط بارکدخوان : " + CInt(Grow.Cells("Amount").Value).ToString, MsgBoxStyle.YesNo, "اصلاح بچ") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        Try
                            Dim Errmsg As String = ""
                            cn.CallSP("abSpC_InsertSanadKasriEzafiForEditBatch_ProductCatalogue", (gVahedeTejariSN),
                                      (gAnbarSN), (gNoeAnbarSN), gSM.Identifier, gSM.UserID_Name, gSM.UserID,
                                      System.Windows.Forms.SystemInformation.ComputerName, (Grow.Cells("KalaSN").Value),
                                        (Grow.Cells("ShomarehRahgiri").Text), (Grow.Cells("EnghezaDate").Text),
                                        (Grow.Cells("BatchCode").Text), (Grow.Cells("JalaliExpireDate").Text), (Grow.Cells("JalaliManufacturingDate").Text), (Errmsg))
                            'cn.ExecuteQuery(" update  abKalaPhiziki set ShomarehRahgiri='" & Grow.Cells("BatchCode").Text & "'," &
                            '                                      "EnghezaDate='" & Grow.Cells("JalaliExpireDate").Text & "', " &
                            '                                      "ToolidDate='" & Grow.Cells("JalaliManufacturingDate").Text & "', " &
                            '                                      "Tozih='اصلاح بچ - اسناد بارکدخوان <'+dbo.JalaliNowDateTime()+'>' " &
                            '                                      "where KalaSN=" & Grow.Cells("KalaSN").Value.ToString & " And " &
                            '                                      "ShomarehRahgiri='" & Grow.Cells("ShomarehRahgiri").Text & "' And " &
                            '                                      "EnghezaDate='" & Grow.Cells("EnghezaDate").Text & "' and " &
                            '                                      "MoaserDate>='" & gHesabdariSalFDate & "'")
                            If Errmsg = "" Then
                                CSystem.MsgBox("ثبت سند کسری اضافی با موفقیت انجام شد", MsgBoxStyle.Information, "")
                                NoeForm = 1000
                            Else
                                CSystem.MsgBox("خطای ثبت سند کسری اضافی" + vbNewLine + Errmsg, MsgBoxStyle.Critical, "")
                            End If
                        Catch ex As Exception
                            CSystem.MsgBox("خطا در بروزرسانی بچ" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "")
                        End Try

                    End If
                End If

            End If

            Me.Close()

        End If
    End Sub

End Class
