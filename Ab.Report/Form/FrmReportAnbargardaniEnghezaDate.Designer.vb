<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportAnbargardaniEnghezaDate
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
    Private Shared m_vb6FormDefInstance As FrmReportAnbargardaniEnghezaDate
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmReportAnbargardaniEnghezaDate
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmReportAnbargardaniEnghezaDate
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmReportAnbargardaniEnghezaDate)
            m_vb6FormDefInstance = Value
        End Set
    End Property
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbxAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbxShobeh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportAnbargardaniEnghezaDate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxAnbar = New cmpCheckedComboBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxShobeh = New cmpCheckedComboBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFromDate = New NetSql.Components.TextBox(Me.components)
        Me.txtToDate = New NetSql.Components.TextBox(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbNormalReport = New System.Windows.Forms.RadioButton()
        Me.rdbKardexReport = New System.Windows.Forms.RadioButton()
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
        Me.pnlF.Controls.Add(Me.txtToDate)
        Me.pnlF.Controls.Add(Me.txtFromDate)
        Me.pnlF.Controls.Add(Me.cbxShobeh)
        Me.pnlF.Controls.Add(Me.cbxAnbar)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Size = New System.Drawing.Size(1146, 137)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cbxAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cbxShobeh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtFromDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtToDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.GroupBox1, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 137)
        Me.pnlGrid.Size = New System.Drawing.Size(1146, 277)
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
        Me.GridEX1.Size = New System.Drawing.Size(1146, 277)
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
        Me.pnlDownJanus.Size = New System.Drawing.Size(1146, 36)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1075, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ازتاریخ"
        '
        'cbxAnbar
        '
        Me.cbxAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cbxAnbar_DesignTimeLayout.LayoutString = resources.GetString("cbxAnbar_DesignTimeLayout.LayoutString")
        Me.cbxAnbar.DesignTimeLayout = cbxAnbar_DesignTimeLayout
        Me.cbxAnbar.LateBinding = True
        Me.cbxAnbar.LateBindingTop = "100"
        Me.cbxAnbar.Location = New System.Drawing.Point(369, 17)
        Me.cbxAnbar.Name = "cbxAnbar"
        Me.cbxAnbar.SaveSettings = False
        Me.cbxAnbar.Size = New System.Drawing.Size(332, 21)
        Me.cbxAnbar.TabIndex = 38
        Me.cbxAnbar.ValuesDataMember = Nothing
        Me.cbxAnbar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1075, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "شعبه"
        '
        'cbxShobeh
        '
        Me.cbxShobeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cbxShobeh_DesignTimeLayout.LayoutString = resources.GetString("cbxShobeh_DesignTimeLayout.LayoutString")
        Me.cbxShobeh.DesignTimeLayout = cbxShobeh_DesignTimeLayout
        Me.cbxShobeh.LateBinding = True
        Me.cbxShobeh.LateBindingTop = "100"
        Me.cbxShobeh.Location = New System.Drawing.Point(737, 17)
        Me.cbxShobeh.Name = "cbxShobeh"
        Me.cbxShobeh.SaveSettings = False
        Me.cbxShobeh.Size = New System.Drawing.Size(332, 21)
        Me.cbxShobeh.TabIndex = 38
        Me.cbxShobeh.ValuesDataMember = Nothing
        Me.cbxShobeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(707, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "انبار"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(913, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "تا تاریخ"
        '
        'txtFromDate
        '
        Me.txtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromDate.Location = New System.Drawing.Point(969, 75)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDate.Size = New System.Drawing.Size(100, 21)
        Me.txtFromDate.TabIndex = 39
        Me.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToDate
        '
        Me.txtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDate.Location = New System.Drawing.Point(807, 75)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDate.Size = New System.Drawing.Size(100, 21)
        Me.txtToDate.TabIndex = 40
        Me.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rdbKardexReport)
        Me.GroupBox1.Controls.Add(Me.rdbNormalReport)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 66)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "حالت گزارش"
        '
        'rdbNormalReport
        '
        Me.rdbNormalReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbNormalReport.AutoSize = True
        Me.rdbNormalReport.Location = New System.Drawing.Point(391, 20)
        Me.rdbNormalReport.Name = "rdbNormalReport"
        Me.rdbNormalReport.Size = New System.Drawing.Size(109, 17)
        Me.rdbNormalReport.TabIndex = 0
        Me.rdbNormalReport.TabStop = True
        Me.rdbNormalReport.Text = "حالت عادی گزارش"
        Me.rdbNormalReport.UseVisualStyleBackColor = True
        '
        'rdbKardexReport
        '
        Me.rdbKardexReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbKardexReport.AutoSize = True
        Me.rdbKardexReport.Location = New System.Drawing.Point(18, 20)
        Me.rdbKardexReport.Name = "rdbKardexReport"
        Me.rdbKardexReport.Size = New System.Drawing.Size(331, 17)
        Me.rdbKardexReport.TabIndex = 1
        Me.rdbKardexReport.TabStop = True
        Me.rdbKardexReport.Text = "حالت کاردکسی(فقط وضعیت تائید حسابداری نمایش داده می شود)"
        Me.rdbKardexReport.UseVisualStyleBackColor = True
        '
        'FrmReportAnbargardaniEnghezaDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 450)
        Me.Name = "FrmReportAnbargardaniEnghezaDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش انبار گردانی بر اساس تاریخ انقضا "
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

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxShobeh As cmpCheckedComboBox
    Friend WithEvents cbxAnbar As cmpCheckedComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtToDate As NetSql.Components.TextBox
    Friend WithEvents txtFromDate As NetSql.Components.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbKardexReport As RadioButton
    Friend WithEvents rdbNormalReport As RadioButton
End Class
