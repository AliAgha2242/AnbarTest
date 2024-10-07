' Add Form By Bagheri (HB) 14030618
Imports Anbar.BRL
Imports Minoo.Applications.Anbar.Common.dsSanad

Public Class FrmMoghayesehSanadRialiMaliVaAnbarReport
    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6formdefinstance As FrmMoghayesehSanadRialiMaliVaAnbarReport
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtToDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents CmbMahsool As cmpCheckedComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TarakoneshCombo As cmpCheckedComboBox
    Friend WithEvents dbcSanadNo As cmpCheckedComboBox
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

    Public Shared Property DefInstance() As FrmMoghayesehSanadRialiMaliVaAnbarReport

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmMoghayesehSanadRialiMaliVaAnbarReport
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmMoghayesehSanadRialiMaliVaAnbarReport)
            m_vb6formdefinstance = Value

        End Set

    End Property


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TarakoneshCombo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim dbcSanadNo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMoghayesehSanadRialiMaliVaAnbarReport))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.CmbMahsool = New cmpCheckedComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TarakoneshCombo = New cmpCheckedComboBox(Me.components)
        Me.dbcSanadNo = New cmpCheckedComboBox(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.dbcSanadNo)
        Me.pnlF.Controls.Add(Me.TarakoneshCombo)
        Me.pnlF.Controls.Add(Me.Label7)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.CmbMahsool)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.TxtToDate)
        Me.pnlF.Controls.Add(Me.TxtFromDate)
        Me.pnlF.Size = New System.Drawing.Size(1252, 62)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtFromDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtToDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsool, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label7, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TarakoneshCombo, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcSanadNo, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(6, 16)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 62)
        Me.pnlGrid.Size = New System.Drawing.Size(1252, 377)
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
        Me.GridEX1.Size = New System.Drawing.Size(1252, 377)
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
        Me.btnChart.Location = New System.Drawing.Point(100, 16)
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Size = New System.Drawing.Size(1252, 36)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1197, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "تا تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1196, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "از تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtToDate
        '
        Me.TxtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtToDate.Location = New System.Drawing.Point(1093, 29)
        Me.TxtToDate.Mask = "9900/90/90"
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 177
        Me.TxtToDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.Location = New System.Drawing.Point(1093, 3)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 176
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'CmbMahsool
        '
        CmbMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsool_DesignTimeLayout.LayoutString")
        Me.CmbMahsool.DesignTimeLayout = CmbMahsool_DesignTimeLayout
        Me.CmbMahsool.LateBinding = True
        Me.CmbMahsool.LateBindingTop = "100"
        Me.CmbMahsool.Location = New System.Drawing.Point(0, -5)
        Me.CmbMahsool.Name = "CmbMahsool"
        Me.CmbMahsool.SaveSettings = False
        Me.CmbMahsool.Size = New System.Drawing.Size(100, 21)
        Me.CmbMahsool.TabIndex = 192
        Me.CmbMahsool.ValuesDataMember = Nothing
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1001, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = " سند انبار : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, -7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 191
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1001, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "تراکنش انبار : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TarakoneshCombo
        '
        Me.TarakoneshCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TarakoneshCombo_DesignTimeLayout.LayoutString = resources.GetString("TarakoneshCombo_DesignTimeLayout.LayoutString")
        Me.TarakoneshCombo.DesignTimeLayout = TarakoneshCombo_DesignTimeLayout
        Me.TarakoneshCombo.LateBinding = True
        Me.TarakoneshCombo.LateBindingTop = "100"
        Me.TarakoneshCombo.Location = New System.Drawing.Point(226, 4)
        Me.TarakoneshCombo.Name = "TarakoneshCombo"
        Me.TarakoneshCombo.SaveSettings = False
        Me.TarakoneshCombo.ShowSelectAll = True
        Me.TarakoneshCombo.Size = New System.Drawing.Size(770, 21)
        Me.TarakoneshCombo.TabIndex = 193
        Me.TarakoneshCombo.ValuesDataMember = Nothing
        '
        'dbcSanadNo
        '
        Me.dbcSanadNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dbcSanadNo_DesignTimeLayout.LayoutString = resources.GetString("dbcSanadNo_DesignTimeLayout.LayoutString")
        Me.dbcSanadNo.DesignTimeLayout = dbcSanadNo_DesignTimeLayout
        Me.dbcSanadNo.LateBinding = True
        Me.dbcSanadNo.LateBindingTop = "100"
        Me.dbcSanadNo.Location = New System.Drawing.Point(226, 29)
        Me.dbcSanadNo.Name = "dbcSanadNo"
        Me.dbcSanadNo.SaveSettings = False
        Me.dbcSanadNo.ShowSelectAll = True
        Me.dbcSanadNo.Size = New System.Drawing.Size(770, 21)
        Me.dbcSanadNo.TabIndex = 194
        Me.dbcSanadNo.ValuesDataMember = Nothing
        '
        'FrmMoghayesehSanadRialiMaliVaAnbarReport
        '
        Me.ClientSize = New System.Drawing.Size(1252, 475)
        Me.Name = "FrmMoghayesehSanadRialiMaliVaAnbarReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش مقایسه اسناد ریالی مالی و انبار"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub FrmMoghayesehSanadRialiMaliVaAnbarReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)

        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")

        dbcSanadNo.LateBinding = True
        dbcSanadNo.ShowSelectAll = True

        dbcSanadNo.Bind(cn,
                         "Select SanadSN   , cast(SanadNO As varchar(15)) + '.' +  TarakoneshDS + '('+ SanadDate + ')'+'('+AnbarDs+')' As SanadDS " &
                         "From abSanad  Join abTarakonesh On abTarakonesh.TarakoneshSN = abSanad.TarakoneshSN " &
                         "Join abAnbar On abAnbar.AnbarSN=abSanad.AnbarSN " &
                         "Where SanadDate between '" & Fdate & "' and '" & Tdate & "'   And abSanad.SanadStatus = 8 And abSanad.TarakoneshSN<>44 and " &
                         "abAnbar.IsNerkhGozari = 1 And (abAnbar.AnbarSN=" & gAnbarSN.ToString & " Or exists(select 1 from abAnbar T where T.IsTajmie=1 And T.AnbarSN=" & gAnbarSN.ToString & ")) ",
                         "SanadSN", "SanadDS")

        TarakoneshCombo.Bind(cn, " Select Distinct abTarakonesh.TarakoneshSN,TarakoneshDs " &
                                 " From absanad " &
                                 " join absanadha on absanad.sanadsn = absanadha.sanadsn " &
                                 " join abTarakonesh On abSanad.TarakoneshSN = abTarakonesh.TarakoneshSN " &
                                 " Where abSanad.AnbarSN = " + (gAnbarSN).ToString() + " And SanadDate Between '" & Fdate & "' And '" & Tdate & "'", "TarakoneshSN", "TarakoneshDS")


    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click


        'If CmbSanadAnbar.getStringValues Is Nothing Then
        '    MsgBox("شماره سند انبار انتخاب نشده است", MsgBoxStyle.Critical, "")
        '    Exit Sub
        'End If

        Dim _FromDate, _ToDate, _AnbarSN, _SanadNo, _TarakoneshSN As String

        _SanadNo = ""
        _TarakoneshSN = ""

        If Not (dbcSanadNo.getStringValues Is Nothing OrElse dbcSanadNo.getStringValues = "0" OrElse dbcSanadNo.getStringValues = "0.000") Then
            _SanadNo = dbcSanadNo.getStringValues
        End If

        If Not (TarakoneshCombo.getStringValues Is Nothing OrElse TarakoneshCombo.getStringValues = "0" OrElse TarakoneshCombo.getStringValues = "0.000") Then
            _TarakoneshSN = TarakoneshCombo.getStringValues
        End If

        _FromDate = TxtFromDate.Text.Replace("/", "")
        _ToDate = TxtToDate.Text.Replace("/", "")
        _AnbarSN = gAnbarSN.ToString()


        Dim AnbarRule As New ClsDataAccessRule
        Dim DvReport As New DataView
        Try
            DvReport = AnbarRule.MoghayesehSanadRialiMaliVaAnbar_GetReport(_FromDate, _ToDate, _AnbarSN, _TarakoneshSN, _SanadNo, cn)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        GridEX1.DataSource = DvReport
        GridEX1.RetrieveStructure()

        For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If col.Key.Contains(".") Then
                col.FormatString = "#,###"
                col.TotalFormatString = "#,###"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            ElseIf col.Key.Contains("..") Then
                col.FormatString = "###.###"
                col.TotalFormatString = "###.###"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            End If
        Next

        GridEX1.AutoSizeColumns()


    End Sub

End Class
