Imports Anbar.BRL
Public Class FrmRptMoghayeratSanadMaliStandard
    Inherits JanusSimpleReport.frmRptJanusBase

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

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptMoghayeratSanadMaliStandard
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatePickerTodate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents DatePickerFromdate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbShobe As cmpCheckedComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbTarakonesh As cmpCheckedComboBox
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptMoghayeratSanadMaliStandard
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptMoghayeratSanadMaliStandard
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptMoghayeratSanadMaliStandard)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbShobe_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbTarakonesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptMoghayeratSanadMaliStandard))
        Me.DatePickerFromdate = New NetSql.Components.cmpFarsiDatePicker()
        Me.DatePickerTodate = New NetSql.Components.cmpFarsiDatePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbShobe = New cmpCheckedComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbTarakonesh = New cmpCheckedComboBox(Me.components)
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
        Me.pnlF.Controls.Add(Me.CmbShobe)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.CmbTarakonesh)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.DatePickerTodate)
        Me.pnlF.Controls.Add(Me.DatePickerFromdate)
        Me.pnlF.Size = New System.Drawing.Size(1204, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.DatePickerFromdate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.DatePickerTodate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTarakonesh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbShobe, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1204, 437)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.GridEX1.Size = New System.Drawing.Size(1204, 437)
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
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 509)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1204, 36)
        '
        'DatePickerFromdate
        '
        Me.DatePickerFromdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePickerFromdate.Location = New System.Drawing.Point(623, 9)
        Me.DatePickerFromdate.Mask = "9900/90/90"
        Me.DatePickerFromdate.Name = "DatePickerFromdate"
        Me.DatePickerFromdate.SelectedDateTimeShamsi = "    /  /"
        Me.DatePickerFromdate.Size = New System.Drawing.Size(96, 20)
        Me.DatePickerFromdate.TabIndex = 168
        Me.DatePickerFromdate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'DatePickerTodate
        '
        Me.DatePickerTodate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePickerTodate.Location = New System.Drawing.Point(623, 35)
        Me.DatePickerTodate.Mask = "9900/90/90"
        Me.DatePickerTodate.Name = "DatePickerTodate"
        Me.DatePickerTodate.SelectedDateTimeShamsi = "    /  /"
        Me.DatePickerTodate.Size = New System.Drawing.Size(96, 20)
        Me.DatePickerTodate.TabIndex = 169
        Me.DatePickerTodate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(736, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "از تاریخ :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(736, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "تا تاریخ :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1147, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "تراکنش:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbShobe
        '
        Me.CmbShobe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbShobe_DesignTimeLayout.LayoutString = resources.GetString("CmbShobe_DesignTimeLayout.LayoutString")
        Me.CmbShobe.DesignTimeLayout = CmbShobe_DesignTimeLayout
        Me.CmbShobe.LateBinding = True
        Me.CmbShobe.LateBindingTop = "100"
        Me.CmbShobe.Location = New System.Drawing.Point(811, 4)
        Me.CmbShobe.Name = "CmbShobe"
        Me.CmbShobe.SaveSettings = False
        Me.CmbShobe.ShowSelectAll = True
        Me.CmbShobe.Size = New System.Drawing.Size(330, 21)
        Me.CmbShobe.TabIndex = 179
        Me.CmbShobe.ValuesDataMember = Nothing
        Me.CmbShobe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1148, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "شعبه :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbTarakonesh
        '
        Me.CmbTarakonesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTarakonesh_DesignTimeLayout.LayoutString = resources.GetString("CmbTarakonesh_DesignTimeLayout.LayoutString")
        Me.CmbTarakonesh.DesignTimeLayout = CmbTarakonesh_DesignTimeLayout
        Me.CmbTarakonesh.LateBinding = True
        Me.CmbTarakonesh.LateBindingTop = "100"
        Me.CmbTarakonesh.Location = New System.Drawing.Point(811, 37)
        Me.CmbTarakonesh.Name = "CmbTarakonesh"
        Me.CmbTarakonesh.SaveSettings = False
        Me.CmbTarakonesh.ShowSelectAll = True
        Me.CmbTarakonesh.Size = New System.Drawing.Size(330, 21)
        Me.CmbTarakonesh.TabIndex = 177
        Me.CmbTarakonesh.ValuesDataMember = Nothing
        Me.CmbTarakonesh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FrmRptMoghayeratSanadMaliStandard
        '
        Me.ClientSize = New System.Drawing.Size(1204, 545)
        Me.Name = "FrmRptMoghayeratSanadMaliStandard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مغایرت سند استاندارد مالی و انبار"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub FrmRptMoghayeratSanadMaliStandard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbShobe.Bind(cn, "Select 0 VahedeTejariSN,'همه موارد' VahedeTejariDS Union Select VahedeTejariSN,VahedeTejariDS from paVahedeTejari Where PedarVahedeTejariSN=9.935 And VahedeTejariStatus=1", "VahedeTejariSN", "VahedeTejariDS")
        CmbTarakonesh.Bind(cn, "Select 0 TarakoneshSN,'همه موارد' TarakoneshDS Union Select TarakoneshSN,TarakoneshNo+'. '+TarakoneshDS As TarakoneshDS from abTarakonesh ", "TarakoneshSN", "TarakoneshDS")

        If gVahedeTejariSN >= 15.935 Then
            CmbShobe.BoundText = gVahedeTejariSN.ToString
            CmbShobe.ReadOnly = True
        End If

        Dim funCal As New ProductionPlanning.Calender.CCalender


        Dim Today As String = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date, NetSql.Common.CShamsiDate.EnumDateFormat.dfFullYear)
        Dim NextMonth As String = NetSql.Common.CShamsiDate.MiladiToShamsi(Now.Date.AddMonths(1), NetSql.Common.CShamsiDate.EnumDateFormat.dfFullYear)


        DatePickerFromdate.Text = funCal.DateWithSlash(Today.Substring(0, 6) + "01")

        Dim TedadRooz As String = funCal.GetTedadRoozeMah(Today.Substring(0, 4), Today.Substring(4, 2))
        DatePickerTodate.Text = funCal.DateWithSlash(Today.Substring(0, 6) + TedadRooz)


    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click

        Dim thisWaitFrm As New Anbar.Common.Frmwait
        thisWaitFrm.Show()
        thisWaitFrm.Label3.Text = "...سیستم در حال تهیه گزارش می باشد..."
        thisWaitFrm.Refresh()

        Dim _Tarakonesh As String = "0"
        If Not (CmbTarakonesh.getStringValues Is Nothing OrElse CmbTarakonesh.getStringValues = "0.000") Then
            _Tarakonesh = CmbTarakonesh.getStringValues
        End If

        Dim _Shobe As String = "0"
        If Not (CmbShobe.getStringValues Is Nothing OrElse CmbShobe.getStringValues = "0.000") AndAlso gVahedeTejariSN < 15.935 Then
            _Shobe = CmbShobe.getStringValues
        End If

        Dim Fromdate As String = DatePickerFromdate.Text.Substring(2, 8).Replace("/", "")
        Dim Todate As String = DatePickerTodate.Text.Substring(2, 8).Replace("/", "")

        Dim AnbarRule As New ClsDataAccessRule
        Dim DvReport As New DataView

        Try
            DvReport = AnbarRule.GetRptMoghyeratEstandardMaliVaAnbar(_Shobe, _Tarakonesh, Fromdate, Todate, cn)
        Catch ex As Exception
            MsgBox(ex.Message)
            thisWaitFrm.Close()
        End Try


        GridEX1.DataSource = DvReport
        GridEX1.RetrieveStructure()
        GridEX1.Refresh()

        For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If col.Key.StartsWith(".") Then
                col.FormatMode = Janus.Windows.GridEX.FormatMode.UseIFormattable
                col.FormatString = "#,###.###"
                col.TotalFormatMode = Janus.Windows.GridEX.FormatMode.UseIFormattable
                col.TotalFormatString = "#,###.###"
            End If
        Next
        GridEX1.AutoSizeColumns()

        thisWaitFrm.Close()

    End Sub

End Class
