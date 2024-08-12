<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnbargardaniMoghayeratBeyneShomaresh
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




    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dbcAnbargardani = New NetSql.Components.DataCombo(Me.components)
        Me.lbl_SaleMali = New System.Windows.Forms.Label()
        Me.ChkCustomizeForPrint = New System.Windows.Forms.CheckBox()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.ChkCustomizeForPrint)
        Me.pnlF.Controls.Add(Me.lbl_SaleMali)
        Me.pnlF.Controls.Add(Me.dbcAnbargardani)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1018, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcAnbargardani, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lbl_SaleMali, 0)
        Me.pnlF.Controls.SetChildIndex(Me.ChkCustomizeForPrint, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1018, 342)
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
        Me.GridEX1.Size = New System.Drawing.Size(1018, 342)
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
        Me.pnlDownJanus.Size = New System.Drawing.Size(1018, 36)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(913, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(93, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "دوره انبار گردانی:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dbcAnbargardani
        '
        Me.dbcAnbargardani.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcAnbargardani.AutoSelectFirst = False
        Me.dbcAnbargardani.BackColor = System.Drawing.Color.White
        Me.dbcAnbargardani.BoundText = Nothing
        Me.dbcAnbargardani.BypassChangeEvent = False
        Me.dbcAnbargardani.DisplayText = ""
        Me.dbcAnbargardani.LateBindingTop = "100"
        Me.dbcAnbargardani.Location = New System.Drawing.Point(314, 9)
        Me.dbcAnbargardani.MemFilter = ""
        Me.dbcAnbargardani.Name = "dbcAnbargardani"
        Me.dbcAnbargardani.SeparatedData = Nothing
        Me.dbcAnbargardani.Size = New System.Drawing.Size(598, 21)
        Me.dbcAnbargardani.Source = Nothing
        Me.dbcAnbargardani.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcAnbargardani.TabIndex = 9
        '
        'lbl_SaleMali
        '
        Me.lbl_SaleMali.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SaleMali.AutoSize = True
        Me.lbl_SaleMali.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_SaleMali.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_SaleMali.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_SaleMali.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_SaleMali.Location = New System.Drawing.Point(622, 39)
        Me.lbl_SaleMali.Name = "lbl_SaleMali"
        Me.lbl_SaleMali.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_SaleMali.Size = New System.Drawing.Size(24, 19)
        Me.lbl_SaleMali.TabIndex = 10
        Me.lbl_SaleMali.Text = "..."
        Me.lbl_SaleMali.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_SaleMali.Visible = False
        '
        'ChkCustomizeForPrint
        '
        Me.ChkCustomizeForPrint.AutoSize = True
        Me.ChkCustomizeForPrint.Location = New System.Drawing.Point(190, 41)
        Me.ChkCustomizeForPrint.Name = "ChkCustomizeForPrint"
        Me.ChkCustomizeForPrint.Size = New System.Drawing.Size(242, 17)
        Me.ChkCustomizeForPrint.TabIndex = 11
        Me.ChkCustomizeForPrint.Text = "فقط ستون های مخصوص چاپ نمایش داده شود"
        Me.ChkCustomizeForPrint.UseVisualStyleBackColor = True
        '
        'FrmAnbargardaniMoghayeratBeyneShomaresh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 450)
        Me.Name = "FrmAnbargardaniMoghayeratBeyneShomaresh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش مغایرت بین شمارش های انبار گردانی"
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Label5 As Label
    Public WithEvents dbcAnbargardani As NetSql.Components.DataCombo
    Public WithEvents lbl_SaleMali As Label
    Friend WithEvents ChkCustomizeForPrint As CheckBox
End Class
