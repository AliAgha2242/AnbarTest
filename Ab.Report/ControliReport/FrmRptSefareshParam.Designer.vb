<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptSefareshParam
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
        Me.chkOnlyKalaWithHavaleh = New System.Windows.Forms.CheckBox()
        Me.btnFilterAsnadAnbar = New System.Windows.Forms.Button()
        Me.CmdSelectAnbars = New System.Windows.Forms.Button()
        Me.dcbNoeAnbarSN = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChideman = New System.Windows.Forms.Button()
        Me.btnSendToTD = New System.Windows.Forms.Button()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.chkOnlyKalaWithHavaleh)
        Me.pnlF.Controls.Add(Me.btnFilterAsnadAnbar)
        Me.pnlF.Controls.Add(Me.CmdSelectAnbars)
        Me.pnlF.Controls.Add(Me.dcbNoeAnbarSN)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbNoeAnbarSN, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmdSelectAnbars, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnFilterAsnadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.chkOnlyKalaWithHavaleh, 0)
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
        'pnlDownJanus
        '
        Me.pnlDownJanus.Controls.Add(Me.btnSendToTD)
        Me.pnlDownJanus.Controls.Add(Me.btnChideman)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnModify, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.pnlCommand, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnExcell, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnChideman, 0)
        Me.pnlDownJanus.Controls.SetChildIndex(Me.btnSendToTD, 0)
        '
        'chkOnlyKalaWithHavaleh
        '
        Me.chkOnlyKalaWithHavaleh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOnlyKalaWithHavaleh.AutoSize = True
        Me.chkOnlyKalaWithHavaleh.Location = New System.Drawing.Point(680, 41)
        Me.chkOnlyKalaWithHavaleh.Name = "chkOnlyKalaWithHavaleh"
        Me.chkOnlyKalaWithHavaleh.Size = New System.Drawing.Size(227, 17)
        Me.chkOnlyKalaWithHavaleh.TabIndex = 10
        Me.chkOnlyKalaWithHavaleh.Text = "کالاهاي داراي حواله در محدوده تاريخ انتخابي"
        '
        'btnFilterAsnadAnbar
        '
        Me.btnFilterAsnadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterAsnadAnbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilterAsnadAnbar.Location = New System.Drawing.Point(347, 32)
        Me.btnFilterAsnadAnbar.Name = "btnFilterAsnadAnbar"
        Me.btnFilterAsnadAnbar.Size = New System.Drawing.Size(88, 32)
        Me.btnFilterAsnadAnbar.TabIndex = 9
        Me.btnFilterAsnadAnbar.Text = "فيلتر گزارش"
        '
        'CmdSelectAnbars
        '
        Me.CmdSelectAnbars.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSelectAnbars.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSelectAnbars.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSelectAnbars.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSelectAnbars.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdSelectAnbars.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmdSelectAnbars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSelectAnbars.Location = New System.Drawing.Point(437, 32)
        Me.CmdSelectAnbars.Name = "CmdSelectAnbars"
        Me.CmdSelectAnbars.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmdSelectAnbars.Size = New System.Drawing.Size(88, 32)
        Me.CmdSelectAnbars.TabIndex = 8
        Me.CmdSelectAnbars.Text = "انتخاب انبار"
        Me.CmdSelectAnbars.UseVisualStyleBackColor = False
        '
        'dcbNoeAnbarSN
        '
        Me.dcbNoeAnbarSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbNoeAnbarSN.AutoSelectFirst = True
        Me.dcbNoeAnbarSN.BackColor = System.Drawing.Color.White
        Me.dcbNoeAnbarSN.BoundText = Nothing
        Me.dcbNoeAnbarSN.BypassChangeEvent = False
        Me.dcbNoeAnbarSN.DisplayText = ""
        Me.dcbNoeAnbarSN.LateBindingTop = "100"
        Me.dcbNoeAnbarSN.Location = New System.Drawing.Point(670, 12)
        Me.dcbNoeAnbarSN.MemFilter = ""
        Me.dcbNoeAnbarSN.Name = "dcbNoeAnbarSN"
        Me.dcbNoeAnbarSN.SeparatedData = Nothing
        Me.dcbNoeAnbarSN.Size = New System.Drawing.Size(189, 21)
        Me.dcbNoeAnbarSN.Source = Nothing
        Me.dcbNoeAnbarSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbNoeAnbarSN.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(862, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "نوع انبار "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnChideman
        '
        Me.btnChideman.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChideman.BackColor = System.Drawing.Color.Transparent
        Me.btnChideman.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChideman.Enabled = False
        Me.btnChideman.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChideman.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnChideman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChideman.Location = New System.Drawing.Point(846, 4)
        Me.btnChideman.Name = "btnChideman"
        Me.btnChideman.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnChideman.Size = New System.Drawing.Size(72, 27)
        Me.btnChideman.TabIndex = 17
        Me.btnChideman.Text = "چيدمان"
        Me.btnChideman.UseVisualStyleBackColor = False
        Me.btnChideman.Visible = False
        '
        'btnSendToTD
        '
        Me.btnSendToTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendToTD.BackColor = System.Drawing.Color.Transparent
        Me.btnSendToTD.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSendToTD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSendToTD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSendToTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSendToTD.Location = New System.Drawing.Point(747, 4)
        Me.btnSendToTD.Name = "btnSendToTD"
        Me.btnSendToTD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSendToTD.Size = New System.Drawing.Size(93, 27)
        Me.btnSendToTD.TabIndex = 18
        Me.btnSendToTD.Text = "ارسال به خرید"
        Me.btnSendToTD.UseVisualStyleBackColor = False
        '
        'FrmRptSefareshParam
        '
        Me.ClientSize = New System.Drawing.Size(921, 475)
        Me.Name = "FrmRptSefareshParam"
        Me.Text = "گزارش نقطه سفارش"
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkOnlyKalaWithHavaleh As System.Windows.Forms.CheckBox
    Friend WithEvents btnFilterAsnadAnbar As System.Windows.Forms.Button
    Public WithEvents CmdSelectAnbars As System.Windows.Forms.Button
    Public WithEvents dcbNoeAnbarSN As NetSql.Components.DataCombo
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnChideman As System.Windows.Forms.Button
    Public WithEvents btnSendToTD As System.Windows.Forms.Button

End Class
