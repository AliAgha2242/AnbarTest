<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRptMoghayeratShoab
    Inherits JanusSimpleReport.frmRptJanusBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim dbcSanadNo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim dbcTarakonesh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim dbcTafsili_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptMoghayeratShoab))
        Me.dbcSanadNo = New cmpCheckedComboBox(Me.components)
        Me.dbcTarakonesh = New cmpCheckedComboBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromDarkhastDate = New System.Windows.Forms.TextBox()
        Me.txtToDarkhastDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dbcTafsili = New cmpCheckedComboBox(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.dbcTafsili)
        Me.pnlF.Controls.Add(Me.txtFromDarkhastDate)
        Me.pnlF.Controls.Add(Me.txtToDarkhastDate)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label6)
        Me.pnlF.Controls.Add(Me.Label10)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.dbcTarakonesh)
        Me.pnlF.Controls.Add(Me.dbcSanadNo)
        Me.pnlF.Size = New System.Drawing.Size(993, 105)
        Me.pnlF.Controls.SetChildIndex(Me.dbcSanadNo, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcTarakonesh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label10, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtToDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtFromDarkhastDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dbcTafsili, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 105)
        Me.pnlGrid.Size = New System.Drawing.Size(993, 329)
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
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Moccasin
        Me.GridEX1.Size = New System.Drawing.Size(993, 329)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 434)
        Me.pnlDownJanus.Size = New System.Drawing.Size(993, 41)
        '
        'dbcSanadNo
        '
        Me.dbcSanadNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dbcSanadNo_DesignTimeLayout.LayoutString = resources.GetString("dbcSanadNo_DesignTimeLayout.LayoutString")
        Me.dbcSanadNo.DesignTimeLayout = dbcSanadNo_DesignTimeLayout
        Me.dbcSanadNo.LateBinding = True
        Me.dbcSanadNo.LateBindingTop = "100"
        Me.dbcSanadNo.Location = New System.Drawing.Point(508, 13)
        Me.dbcSanadNo.Name = "dbcSanadNo"
        Me.dbcSanadNo.SaveSettings = False
        Me.dbcSanadNo.Size = New System.Drawing.Size(378, 21)
        Me.dbcSanadNo.TabIndex = 2
        Me.dbcSanadNo.ValuesDataMember = Nothing
        '
        'dbcTarakonesh
        '
        Me.dbcTarakonesh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dbcTarakonesh_DesignTimeLayout.LayoutString = resources.GetString("dbcTarakonesh_DesignTimeLayout.LayoutString")
        Me.dbcTarakonesh.DesignTimeLayout = dbcTarakonesh_DesignTimeLayout
        Me.dbcTarakonesh.LateBinding = True
        Me.dbcTarakonesh.LateBindingTop = "100"
        Me.dbcTarakonesh.Location = New System.Drawing.Point(508, 38)
        Me.dbcTarakonesh.Name = "dbcTarakonesh"
        Me.dbcTarakonesh.SaveSettings = False
        Me.dbcTarakonesh.Size = New System.Drawing.Size(378, 21)
        Me.dbcTarakonesh.TabIndex = 3
        Me.dbcTarakonesh.ValuesDataMember = Nothing
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(910, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "شماره حواله"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(910, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "تراکنش"
        '
        'txtFromDarkhastDate
        '
        Me.txtFromDarkhastDate.AcceptsReturn = True
        Me.txtFromDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromDarkhastDate.Location = New System.Drawing.Point(352, 26)
        Me.txtFromDarkhastDate.MaxLength = 0
        Me.txtFromDarkhastDate.Name = "txtFromDarkhastDate"
        Me.txtFromDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromDarkhastDate.TabIndex = 21
        Me.txtFromDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToDarkhastDate
        '
        Me.txtToDarkhastDate.AcceptsReturn = True
        Me.txtToDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDarkhastDate.Location = New System.Drawing.Point(352, 51)
        Me.txtToDarkhastDate.MaxLength = 0
        Me.txtToDarkhastDate.Name = "txtToDarkhastDate"
        Me.txtToDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToDarkhastDate.TabIndex = 22
        Me.txtToDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(433, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "از"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(432, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(446, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(910, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "طرف حساب"
        '
        'dbcTafsili
        '
        Me.dbcTafsili.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dbcTafsili_DesignTimeLayout.LayoutString = resources.GetString("dbcTafsili_DesignTimeLayout.LayoutString")
        Me.dbcTafsili.DesignTimeLayout = dbcTafsili_DesignTimeLayout
        Me.dbcTafsili.LateBinding = True
        Me.dbcTafsili.LateBindingTop = "100"
        Me.dbcTafsili.Location = New System.Drawing.Point(508, 65)
        Me.dbcTafsili.Name = "dbcTafsili"
        Me.dbcTafsili.SaveSettings = False
        Me.dbcTafsili.Size = New System.Drawing.Size(378, 21)
        Me.dbcTafsili.TabIndex = 24
        Me.dbcTafsili.ValuesDataMember = Nothing
        '
        'FrmRptMoghayeratShoab
        '
        Me.ClientSize = New System.Drawing.Size(993, 475)
        Me.Name = "FrmRptMoghayeratShoab"
        Me.Text = "گزارش مقایسه اسناد بین شعب"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dbcTarakonesh As cmpCheckedComboBox
    Friend WithEvents dbcSanadNo As cmpCheckedComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFromDarkhastDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToDarkhastDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dbcTafsili As cmpCheckedComboBox

End Class
