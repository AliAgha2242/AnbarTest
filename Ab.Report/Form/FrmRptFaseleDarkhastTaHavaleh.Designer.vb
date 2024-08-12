<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptFaseleDarkhastTaHavaleh
    ' Inherits System.Windows.Forms.Form

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
        Dim CmbMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptFaseleDarkhastTaHavaleh))
        Dim CmbTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.txtFromDarkhastDate = New System.Windows.Forms.TextBox()
        Me.txtToDarkhastDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbMahsool = New cmpCheckedComboBox(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.dbcVahedeTejari = New NetSql.Components.DataCombo(Me.components)
        Me.CmbTamin = New cmpCheckedComboBox(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.lbl1)
        Me.pnlF.Controls.Add(Me.dbcVahedeTejari)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.CmbMahsool)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.CmbTamin)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.txtFromDarkhastDate)
        Me.pnlF.Controls.Add(Me.txtToDarkhastDate)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label6)
        Me.pnlF.Controls.Add(Me.Label10)
        Me.pnlF.Size = New System.Drawing.Size(1135, 72)
        Me.pnlF.Controls.SetChildIndex(Me.Label10, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtToDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtFromDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsool, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcVahedeTejari, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lbl1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1135, 394)
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
        Me.GridEX1.Size = New System.Drawing.Size(1135, 394)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 466)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1135, 36)
        '
        'txtFromDarkhastDate
        '
        Me.txtFromDarkhastDate.AcceptsReturn = True
        Me.txtFromDarkhastDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromDarkhastDate.Location = New System.Drawing.Point(952, 11)
        Me.txtFromDarkhastDate.MaxLength = 0
        Me.txtFromDarkhastDate.Name = "txtFromDarkhastDate"
        Me.txtFromDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromDarkhastDate.TabIndex = 31
        Me.txtFromDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToDarkhastDate
        '
        Me.txtToDarkhastDate.AcceptsReturn = True
        Me.txtToDarkhastDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDarkhastDate.Location = New System.Drawing.Point(952, 36)
        Me.txtToDarkhastDate.MaxLength = 0
        Me.txtToDarkhastDate.Name = "txtToDarkhastDate"
        Me.txtToDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToDarkhastDate.TabIndex = 32
        Me.txtToDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(1033, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 29
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
        Me.Label6.Location = New System.Drawing.Point(1032, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 30
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
        Me.Label10.Location = New System.Drawing.Point(1046, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "تاریخ درخواست:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(868, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(0, 14)
        Me.Label5.TabIndex = 34
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(868, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "تامین کننده : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(871, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "محصول:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbMahsool
        '
        Me.CmbMahsool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsool_DesignTimeLayout.LayoutString")
        Me.CmbMahsool.DesignTimeLayout = CmbMahsool_DesignTimeLayout
        Me.CmbMahsool.LateBinding = True
        Me.CmbMahsool.LateBindingTop = "100"
        Me.CmbMahsool.Location = New System.Drawing.Point(481, 9)
        Me.CmbMahsool.Name = "CmbMahsool"
        Me.CmbMahsool.SaveSettings = False
        Me.CmbMahsool.ShowSelectAll = True
        Me.CmbMahsool.Size = New System.Drawing.Size(384, 21)
        Me.CmbMahsool.TabIndex = 189
        Me.CmbMahsool.ValuesDataMember = Nothing
        Me.CmbMahsool.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(431, 12)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 13)
        Me.lbl1.TabIndex = 192
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
        Me.dbcVahedeTejari.Location = New System.Drawing.Point(208, 9)
        Me.dbcVahedeTejari.MemFilter = ""
        Me.dbcVahedeTejari.Name = "dbcVahedeTejari"
        Me.dbcVahedeTejari.SeparatedData = Nothing
        Me.dbcVahedeTejari.Size = New System.Drawing.Size(220, 21)
        Me.dbcVahedeTejari.Source = Nothing
        Me.dbcVahedeTejari.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcVahedeTejari.TabIndex = 191
        '
        'CmbTamin
        '
        Me.CmbTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTamin_DesignTimeLayout.LayoutString = resources.GetString("CmbTamin_DesignTimeLayout.LayoutString")
        Me.CmbTamin.DesignTimeLayout = CmbTamin_DesignTimeLayout
        Me.CmbTamin.LateBinding = True
        Me.CmbTamin.LateBindingTop = "100"
        Me.CmbTamin.Location = New System.Drawing.Point(481, 37)
        Me.CmbTamin.Name = "CmbTamin"
        Me.CmbTamin.SaveSettings = False
        Me.CmbTamin.ShowSelectAll = True
        Me.CmbTamin.Size = New System.Drawing.Size(384, 21)
        Me.CmbTamin.TabIndex = 187
        Me.CmbTamin.ValuesDataMember = Nothing
        Me.CmbTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FrmRptFaseleDarkhastTaHavaleh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 502)
        Me.Name = "FrmRptFaseleDarkhastTaHavaleh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فاصله زمانی درخواست تا حواله"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFromDarkhastDate As TextBox
    Friend WithEvents txtToDarkhastDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbMahsool As cmpCheckedComboBox
    Friend WithEvents lbl1 As Label
    Public WithEvents dbcVahedeTejari As NetSql.Components.DataCombo
    Friend WithEvents CmbTamin As cmpCheckedComboBox
End Class
