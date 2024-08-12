<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptRialiAsnadKAsriEzafeh
    Inherits JanusSimpleReport.frmRptJanusBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cmbVahedeTejari_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptRialiAsnadKAsriEzafeh))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbVahedeTejari = New cmpCheckedComboBox(Me.components)
        Me.CmpFarsiDatePickerFrom = New NetSql.Components.cmpFarsiDatePicker()
        Me.CmpFarsiDatePickerTO = New NetSql.Components.cmpFarsiDatePicker()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.CmpFarsiDatePickerTO)
        Me.pnlF.Controls.Add(Me.CmpFarsiDatePickerFrom)
        Me.pnlF.Controls.Add(Me.cmbVahedeTejari)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label6)
        Me.pnlF.Controls.Add(Me.Label10)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Size = New System.Drawing.Size(1017, 84)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label10, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cmbVahedeTejari, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmpFarsiDatePickerFrom, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmpFarsiDatePickerTO, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 84)
        Me.pnlGrid.Size = New System.Drawing.Size(1017, 332)
        '
        'pnlCommand
        '
        Me.pnlCommand.Size = New System.Drawing.Size(395, 41)
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
        Me.GridEX1.Size = New System.Drawing.Size(1017, 332)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 416)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1017, 41)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(951, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "واحد تجاری"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(925, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "از"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(810, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(951, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbVahedeTejari
        '
        Me.cmbVahedeTejari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbVahedeTejari_DesignTimeLayout.LayoutString = resources.GetString("cmbVahedeTejari_DesignTimeLayout.LayoutString")
        Me.cmbVahedeTejari.DesignTimeLayout = cmbVahedeTejari_DesignTimeLayout
        Me.cmbVahedeTejari.LateBinding = True
        Me.cmbVahedeTejari.LateBindingTop = "100"
        Me.cmbVahedeTejari.Location = New System.Drawing.Point(643, 13)
        Me.cmbVahedeTejari.Name = "cmbVahedeTejari"
        Me.cmbVahedeTejari.SaveSettings = False
        Me.cmbVahedeTejari.Size = New System.Drawing.Size(302, 21)
        Me.cmbVahedeTejari.TabIndex = 123
        Me.cmbVahedeTejari.ValuesDataMember = Nothing
        '
        'CmpFarsiDatePickerFrom
        '
        Me.CmpFarsiDatePickerFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmpFarsiDatePickerFrom.Location = New System.Drawing.Point(829, 51)
        Me.CmpFarsiDatePickerFrom.Mask = "9900/90/90"
        Me.CmpFarsiDatePickerFrom.Name = "CmpFarsiDatePickerFrom"
        Me.CmpFarsiDatePickerFrom.SelectedDateTimeShamsi = "    /  /"
        Me.CmpFarsiDatePickerFrom.Size = New System.Drawing.Size(93, 20)
        Me.CmpFarsiDatePickerFrom.TabIndex = 124
        Me.CmpFarsiDatePickerFrom.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'CmpFarsiDatePickerTO
        '
        Me.CmpFarsiDatePickerTO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmpFarsiDatePickerTO.Location = New System.Drawing.Point(709, 51)
        Me.CmpFarsiDatePickerTO.Mask = "9900/90/90"
        Me.CmpFarsiDatePickerTO.Name = "CmpFarsiDatePickerTO"
        Me.CmpFarsiDatePickerTO.SelectedDateTimeShamsi = "    /  /"
        Me.CmpFarsiDatePickerTO.Size = New System.Drawing.Size(93, 20)
        Me.CmpFarsiDatePickerTO.TabIndex = 125
        Me.CmpFarsiDatePickerTO.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'FrmRptRialiAsnadKAsriEzafeh
        '
        Me.ClientSize = New System.Drawing.Size(1017, 457)
        Me.Name = "FrmRptRialiAsnadKAsriEzafeh"
        Me.Text = "گزارش ریالی اسناد کسری و اضافه انبارگردانی"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbVahedeTejari As cmpCheckedComboBox
    Friend WithEvents CmpFarsiDatePickerFrom As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents CmpFarsiDatePickerTO As NetSql.Components.cmpFarsiDatePicker

End Class
