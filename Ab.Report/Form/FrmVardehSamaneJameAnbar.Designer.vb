<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVardehSamaneJameAnbar
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
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.grpTDate = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFDate = New NetSql.Components.TextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTDate = New NetSql.Components.TextBox(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.dbcVahedeTejari = New NetSql.Components.DataCombo(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.grpTDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.lbl1)
        Me.pnlF.Controls.Add(Me.dbcVahedeTejari)
        Me.pnlF.Controls.Add(Me.grpTDate)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.grpTDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcVahedeTejari, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lbl1, 0)
        '
        'btnViewReport
        '
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
        'grpTDate
        '
        Me.grpTDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTDate.Controls.Add(Me.Label2)
        Me.grpTDate.Controls.Add(Me.txtFDate)
        Me.grpTDate.Controls.Add(Me.Label1)
        Me.grpTDate.Controls.Add(Me.txtTDate)
        Me.grpTDate.Location = New System.Drawing.Point(778, 5)
        Me.grpTDate.Name = "grpTDate"
        Me.grpTDate.Size = New System.Drawing.Size(131, 64)
        Me.grpTDate.TabIndex = 27
        Me.grpTDate.TabStop = False
        Me.grpTDate.Text = "تاريخ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "از تاريخ"
        '
        'txtFDate
        '
        Me.txtFDate.AcceptsReturn = True
        Me.txtFDate.AutoSelectAllOnEnter = False
        Me.txtFDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFDate.Location = New System.Drawing.Point(6, 12)
        Me.txtFDate.MaxLength = 0
        Me.txtFDate.Name = "txtFDate"
        Me.txtFDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFDate.Size = New System.Drawing.Size(74, 21)
        Me.txtFDate.TabIndex = 0
        Me.txtFDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "تا تاريخ"
        '
        'txtTDate
        '
        Me.txtTDate.AcceptsReturn = True
        Me.txtTDate.AutoSelectAllOnEnter = False
        Me.txtTDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtTDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtTDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTDate.Location = New System.Drawing.Point(6, 39)
        Me.txtTDate.MaxLength = 0
        Me.txtTDate.Name = "txtTDate"
        Me.txtTDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTDate.Size = New System.Drawing.Size(74, 21)
        Me.txtTDate.TabIndex = 1
        Me.txtTDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(707, 25)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 13)
        Me.lbl1.TabIndex = 29
        Me.lbl1.Text = "شعبه:"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dbcVahedeTejari
        '
        Me.dbcVahedeTejari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcVahedeTejari.AutoCompleteText = False
        Me.dbcVahedeTejari.AutoDropDownList = False
        Me.dbcVahedeTejari.AutoSelectFirst = False
        Me.dbcVahedeTejari.BackColor = System.Drawing.Color.White
        Me.dbcVahedeTejari.BoundText = Nothing
        Me.dbcVahedeTejari.BypassChangeEvent = False
        Me.dbcVahedeTejari.DisplayText = ""
        Me.dbcVahedeTejari.LateBinding = True
        Me.dbcVahedeTejari.LateBindingTop = "1000"
        Me.dbcVahedeTejari.Location = New System.Drawing.Point(484, 22)
        Me.dbcVahedeTejari.MemFilter = ""
        Me.dbcVahedeTejari.Name = "dbcVahedeTejari"
        Me.dbcVahedeTejari.SeparatedData = Nothing
        Me.dbcVahedeTejari.Size = New System.Drawing.Size(220, 21)
        Me.dbcVahedeTejari.Source = Nothing
        Me.dbcVahedeTejari.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcVahedeTejari.TabIndex = 28
        '
        'FrmVardehSamaneJameAnbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 475)
        Me.Name = "FrmVardehSamaneJameAnbar"
        Me.Text = "گزارش وارده سامانه جامع انبارها"
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.grpTDate.ResumeLayout(False)
        Me.grpTDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtFDate As NetSql.Components.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtTDate As NetSql.Components.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Public WithEvents dbcVahedeTejari As NetSql.Components.DataCombo
End Class
