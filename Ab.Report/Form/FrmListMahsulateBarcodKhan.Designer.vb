<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListMahsulateBarcodKhan
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

#Region "UpgradeSupport"
    Private Shared m_vb6FormDefInstance As FrmListMahsulateBarcodKhan
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmListMahsulateBarcodKhan
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmListMahsulateBarcodKhan
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmListMahsulateBarcodKhan)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cmbKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cmbTaminKonandeh_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListMahsulateBarcodKhan))
        Me.cmbKala = New cmpCheckedComboBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGTIN = New System.Windows.Forms.TextBox()
        Me.txtIRC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTaminKonandeh = New cmpCheckedComboBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.cmbTaminKonandeh)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.txtGTIN)
        Me.pnlF.Controls.Add(Me.txtIRC)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.cmbKala)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Size = New System.Drawing.Size(1087, 72)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cmbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtIRC, 0)
        Me.pnlF.Controls.SetChildIndex(Me.txtGTIN, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cmbTaminKonandeh, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(1087, 342)
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
        Me.GridEX1.Size = New System.Drawing.Size(1087, 342)
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
        Me.pnlDownJanus.Size = New System.Drawing.Size(1087, 36)
        '
        'cmbKala
        '
        Me.cmbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbKala_DesignTimeLayout.LayoutString = resources.GetString("cmbKala_DesignTimeLayout.LayoutString")
        Me.cmbKala.DesignTimeLayout = cmbKala_DesignTimeLayout
        Me.cmbKala.LateBinding = True
        Me.cmbKala.LateBindingTop = "100"
        Me.cmbKala.Location = New System.Drawing.Point(616, 34)
        Me.cmbKala.Name = "cmbKala"
        Me.cmbKala.SaveSettings = False
        Me.cmbKala.Size = New System.Drawing.Size(412, 21)
        Me.cmbKala.TabIndex = 37
        Me.cmbKala.ValuesDataMember = Nothing
        Me.cmbKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1051, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(24, 14)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "کالا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGTIN
        '
        Me.txtGTIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGTIN.Location = New System.Drawing.Point(226, 34)
        Me.txtGTIN.Name = "txtGTIN"
        Me.txtGTIN.Size = New System.Drawing.Size(234, 21)
        Me.txtGTIN.TabIndex = 40
        Me.txtGTIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIRC
        '
        Me.txtIRC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIRC.Location = New System.Drawing.Point(226, 7)
        Me.txtIRC.Name = "txtIRC"
        Me.txtIRC.Size = New System.Drawing.Size(234, 21)
        Me.txtIRC.TabIndex = 41
        Me.txtIRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(493, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(86, 14)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "بخشی از GTIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(503, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "بخشی از IRC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbTaminKonandeh
        '
        Me.cmbTaminKonandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbTaminKonandeh_DesignTimeLayout.LayoutString = resources.GetString("cmbTaminKonandeh_DesignTimeLayout.LayoutString")
        Me.cmbTaminKonandeh.DesignTimeLayout = cmbTaminKonandeh_DesignTimeLayout
        Me.cmbTaminKonandeh.LateBinding = True
        Me.cmbTaminKonandeh.LateBindingTop = "100"
        Me.cmbTaminKonandeh.Location = New System.Drawing.Point(616, 5)
        Me.cmbTaminKonandeh.Name = "cmbTaminKonandeh"
        Me.cmbTaminKonandeh.SaveSettings = False
        Me.cmbTaminKonandeh.Size = New System.Drawing.Size(389, 21)
        Me.cmbTaminKonandeh.TabIndex = 43
        Me.cmbTaminKonandeh.ValuesDataMember = Nothing
        Me.cmbTaminKonandeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1011, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(64, 14)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "تامین کننده"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmListMahsulateBarcodKhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 450)
        Me.Name = "FrmListMahsulateBarcodKhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "لیست محصولات بارکد خوان"
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents cmbKala As cmpCheckedComboBox
    Public WithEvents Label2 As Label
    Public WithEvents txtGTIN As TextBox
    Public WithEvents txtIRC As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents cmbTaminKonandeh As cmpCheckedComboBox
    Public WithEvents Label1 As Label
End Class
