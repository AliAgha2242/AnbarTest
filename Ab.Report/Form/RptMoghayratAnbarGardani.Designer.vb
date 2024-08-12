<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRptMoghayratAnbarGardani
    ''Inherits System.Windows.Forms.Form
    Inherits JanusSimpleReport.frmRptJanusBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.txtFromDarkhastDate = New System.Windows.Forms.TextBox()
        Me.txtToDarkhastDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dcSalemali = New NetSql.Components.DataCombo(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbKala = New System.Windows.Forms.RadioButton()
        Me.RdbRahgiri = New System.Windows.Forms.RadioButton()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.GroupBox1)
        Me.pnlF.Controls.Add(Me.dcSalemali)
        Me.pnlF.Controls.Add(Me.txtFromDarkhastDate)
        Me.pnlF.Controls.Add(Me.txtToDarkhastDate)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label6)
        Me.pnlF.Controls.Add(Me.Label10)
        Me.pnlF.Size = New System.Drawing.Size(800, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label10, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtToDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtFromDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcSalemali, 0)
        Me.pnlF.Controls.SetChildIndex(Me.GroupBox1, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(800, 342)
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
        Me.GridEX1.Size = New System.Drawing.Size(800, 342)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 414)
        Me.pnlDownJanus.Size = New System.Drawing.Size(800, 36)
        '
        'txtFromDarkhastDate
        '
        Me.txtFromDarkhastDate.AcceptsReturn = True
        Me.txtFromDarkhastDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromDarkhastDate.Location = New System.Drawing.Point(221, 12)
        Me.txtFromDarkhastDate.MaxLength = 0
        Me.txtFromDarkhastDate.Name = "txtFromDarkhastDate"
        Me.txtFromDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromDarkhastDate.TabIndex = 26
        Me.txtFromDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFromDarkhastDate.Visible = False
        '
        'txtToDarkhastDate
        '
        Me.txtToDarkhastDate.AcceptsReturn = True
        Me.txtToDarkhastDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDarkhastDate.Location = New System.Drawing.Point(221, 37)
        Me.txtToDarkhastDate.MaxLength = 0
        Me.txtToDarkhastDate.Name = "txtToDarkhastDate"
        Me.txtToDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToDarkhastDate.TabIndex = 27
        Me.txtToDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtToDarkhastDate.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(302, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "از"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(301, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(727, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "سال مالی :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dcSalemali
        '
        Me.dcSalemali.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcSalemali.AutoSelectFirst = False
        Me.dcSalemali.BackColor = System.Drawing.Color.White
        Me.dcSalemali.BoundText = Nothing
        Me.dcSalemali.BypassChangeEvent = False
        Me.dcSalemali.DisplayText = ""
        Me.dcSalemali.LateBindingTop = "100"
        Me.dcSalemali.Location = New System.Drawing.Point(562, 34)
        Me.dcSalemali.MemFilter = ""
        Me.dcSalemali.Name = "dcSalemali"
        Me.dcSalemali.SeparatedData = Nothing
        Me.dcSalemali.Size = New System.Drawing.Size(159, 21)
        Me.dcSalemali.Source = Nothing
        Me.dcSalemali.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcSalemali.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RdbRahgiri)
        Me.GroupBox1.Controls.Add(Me.RdbKala)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 62)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RdbKala
        '
        Me.RdbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdbKala.AutoSize = True
        Me.RdbKala.Checked = True
        Me.RdbKala.Location = New System.Drawing.Point(110, 10)
        Me.RdbKala.Name = "RdbKala"
        Me.RdbKala.Size = New System.Drawing.Size(84, 17)
        Me.RdbKala.TabIndex = 0
        Me.RdbKala.TabStop = True
        Me.RdbKala.Text = "بر اساس کالا"
        Me.RdbKala.UseVisualStyleBackColor = True
        '
        'RdbRahgiri
        '
        Me.RdbRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdbRahgiri.AutoSize = True
        Me.RdbRahgiri.Location = New System.Drawing.Point(55, 33)
        Me.RdbRahgiri.Name = "RdbRahgiri"
        Me.RdbRahgiri.Size = New System.Drawing.Size(139, 17)
        Me.RdbRahgiri.TabIndex = 1
        Me.RdbRahgiri.TabStop = True
        Me.RdbRahgiri.Text = "بر اساس شماره رهگیری"
        Me.RdbRahgiri.UseVisualStyleBackColor = True
        '
        'FrmRptMoghayratAnbarGardani
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "FrmRptMoghayratAnbarGardani"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مغایریت انبار گردانی اول دوره و پایان دوره"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFromDarkhastDate As TextBox
    Friend WithEvents txtToDarkhastDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents dcSalemali As NetSql.Components.DataCombo
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbRahgiri As RadioButton
    Friend WithEvents RdbKala As RadioButton
End Class
