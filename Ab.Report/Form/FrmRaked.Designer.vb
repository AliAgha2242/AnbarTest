<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRaked
    Inherits JanusSimpleReport.frmRptJanusBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cmbAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRaked))
        Me.cmbAnbar = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromSanadDate = New System.Windows.Forms.TextBox()
        Me.txtToSanadDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxByRahgiri = New System.Windows.Forms.CheckBox()
        Me.lblDarsad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxDarsad = New System.Windows.Forms.TextBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.txtBxDarsad)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.lblDarsad)
        Me.pnlF.Controls.Add(Me.cbxByRahgiri)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.cmbAnbar)
        Me.pnlF.Controls.Add(Me.FraSanadDate)
        Me.pnlF.Size = New System.Drawing.Size(839, 72)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cmbAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cbxByRahgiri, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lblDarsad, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtBxDarsad, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(839, 264)
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
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(839, 264)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 336)
        Me.pnlDownJanus.Size = New System.Drawing.Size(839, 36)
        '
        'cmbAnbar
        '
        Me.cmbAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnbar.ButtonCancelText = "انصراف"
        Me.cmbAnbar.ButtonOKText = "تایید"
        cmbAnbar_DesignTimeLayout.LayoutString = resources.GetString("cmbAnbar_DesignTimeLayout.LayoutString")
        Me.cmbAnbar.DesignTimeLayout = cmbAnbar_DesignTimeLayout
        Me.cmbAnbar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbAnbar.Location = New System.Drawing.Point(557, 12)
        Me.cmbAnbar.Name = "cmbAnbar"
        Me.cmbAnbar.SaveSettings = False
        Me.cmbAnbar.Size = New System.Drawing.Size(231, 20)
        Me.cmbAnbar.TabIndex = 2
        Me.cmbAnbar.ValueItemDataMember = "(None)"
        Me.cmbAnbar.ValuesDataMember = Nothing
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(791, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(33, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "انبار :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromSanadDate)
        Me.FraSanadDate.Controls.Add(Me.txtToSanadDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(557, 28)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(232, 39)
        Me.FraSanadDate.TabIndex = 12
        Me.FraSanadDate.TabStop = False
        '
        'txtFromSanadDate
        '
        Me.txtFromSanadDate.AcceptsReturn = True
        Me.txtFromSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromSanadDate.Location = New System.Drawing.Point(94, 10)
        Me.txtFromSanadDate.MaxLength = 0
        Me.txtFromSanadDate.Name = "txtFromSanadDate"
        Me.txtFromSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromSanadDate.TabIndex = 0
        Me.txtFromSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToSanadDate
        '
        Me.txtToSanadDate.AcceptsReturn = True
        Me.txtToSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToSanadDate.Location = New System.Drawing.Point(2, 10)
        Me.txtToSanadDate.MaxLength = 0
        Me.txtToSanadDate.Name = "txtToSanadDate"
        Me.txtToSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToSanadDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToSanadDate.TabIndex = 1
        Me.txtToSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(175, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "از"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(82, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(188, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbxByRahgiri
        '
        Me.cbxByRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxByRahgiri.AutoSize = True
        Me.cbxByRahgiri.Location = New System.Drawing.Point(366, 44)
        Me.cbxByRahgiri.Name = "cbxByRahgiri"
        Me.cbxByRahgiri.Size = New System.Drawing.Size(182, 17)
        Me.cbxByRahgiri.TabIndex = 13
        Me.cbxByRahgiri.Text = "گزارش در سطح رهگیری کالا باشد"
        Me.cbxByRahgiri.UseVisualStyleBackColor = True
        '
        'lblDarsad
        '
        Me.lblDarsad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDarsad.AutoSize = True
        Me.lblDarsad.Location = New System.Drawing.Point(510, 16)
        Me.lblDarsad.Name = "lblDarsad"
        Me.lblDarsad.Size = New System.Drawing.Size(41, 13)
        Me.lblDarsad.TabIndex = 14
        Me.lblDarsad.Text = "تا میزان"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "درصد گردش کالا بعنوان راکد باشد"
        '
        'txtBxDarsad
        '
        Me.txtBxDarsad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxDarsad.Location = New System.Drawing.Point(470, 12)
        Me.txtBxDarsad.MaxLength = 2
        Me.txtBxDarsad.Name = "txtBxDarsad"
        Me.txtBxDarsad.Size = New System.Drawing.Size(34, 21)
        Me.txtBxDarsad.TabIndex = 15
        Me.txtBxDarsad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmRaked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 372)
        Me.Name = "FrmRaked"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش کالاهای راکد"
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbAnbar As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromSanadDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToSanadDate As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxByRahgiri As CheckBox
    Friend WithEvents txtBxDarsad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDarsad As Label
End Class
