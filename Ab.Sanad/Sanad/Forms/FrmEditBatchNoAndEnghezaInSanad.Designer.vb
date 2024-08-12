<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBatchNoAndEnghezaInSanad
    Inherits System.Windows.Forms.Form

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
        Me.lblNoeEngheza = New System.Windows.Forms.Label()
        Me.btNupdate = New System.Windows.Forms.Button()
        Me.dbcNoeEnghezaSNB = New NetSql.Components.DataCombo(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTozih = New System.Windows.Forms.TextBox()
        Me.TxtBatchNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblKala = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNoeEngheza
        '
        Me.lblNoeEngheza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoeEngheza.AutoSize = True
        Me.lblNoeEngheza.BackColor = System.Drawing.Color.Transparent
        Me.lblNoeEngheza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoeEngheza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoeEngheza.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoeEngheza.Location = New System.Drawing.Point(287, 92)
        Me.lblNoeEngheza.Name = "lblNoeEngheza"
        Me.lblNoeEngheza.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNoeEngheza.Size = New System.Drawing.Size(66, 14)
        Me.lblNoeEngheza.TabIndex = 0
        Me.lblNoeEngheza.Text = "نوع انقضاء"
        Me.lblNoeEngheza.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btNupdate
        '
        Me.btNupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNupdate.BackColor = System.Drawing.SystemColors.Control
        Me.btNupdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btNupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btNupdate.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btNupdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btNupdate.Location = New System.Drawing.Point(134, 227)
        Me.btNupdate.Name = "btNupdate"
        Me.btNupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btNupdate.Size = New System.Drawing.Size(84, 53)
        Me.btNupdate.TabIndex = 2
        Me.btNupdate.Text = "تاييد"
        Me.btNupdate.UseVisualStyleBackColor = False
        '
        'dbcNoeEnghezaSNB
        '
        Me.dbcNoeEnghezaSNB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbcNoeEnghezaSNB.AutoSelectFirst = False
        Me.dbcNoeEnghezaSNB.BackColor = System.Drawing.SystemColors.Info
        Me.dbcNoeEnghezaSNB.BoundText = Nothing
        Me.dbcNoeEnghezaSNB.BypassChangeEvent = False
        Me.dbcNoeEnghezaSNB.DisplayText = ""
        Me.dbcNoeEnghezaSNB.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dbcNoeEnghezaSNB.LateBindingTop = "100"
        Me.dbcNoeEnghezaSNB.Location = New System.Drawing.Point(8, 89)
        Me.dbcNoeEnghezaSNB.MemFilter = ""
        Me.dbcNoeEnghezaSNB.Name = "dbcNoeEnghezaSNB"
        Me.dbcNoeEnghezaSNB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dbcNoeEnghezaSNB.SeparatedData = Nothing
        Me.dbcNoeEnghezaSNB.Size = New System.Drawing.Size(272, 24)
        Me.dbcNoeEnghezaSNB.Source = Nothing
        Me.dbcNoeEnghezaSNB.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcNoeEnghezaSNB.TabIndex = 1
        Me.dbcNoeEnghezaSNB.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(287, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "توضیح "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtTozih
        '
        Me.TxtTozih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTozih.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTozih.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtTozih.Location = New System.Drawing.Point(8, 192)
        Me.TxtTozih.Name = "TxtTozih"
        Me.TxtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTozih.Size = New System.Drawing.Size(272, 23)
        Me.TxtTozih.TabIndex = 4
        '
        'TxtBatchNo
        '
        Me.TxtBatchNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBatchNo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtBatchNo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBatchNo.Location = New System.Drawing.Point(8, 142)
        Me.TxtBatchNo.Name = "TxtBatchNo"
        Me.TxtBatchNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBatchNo.Size = New System.Drawing.Size(272, 23)
        Me.TxtBatchNo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(287, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "شماره بچ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblKala
        '
        Me.LblKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKala.BackColor = System.Drawing.Color.Transparent
        Me.LblKala.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblKala.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKala.ForeColor = System.Drawing.Color.Maroon
        Me.LblKala.Location = New System.Drawing.Point(8, 9)
        Me.LblKala.Name = "LblKala"
        Me.LblKala.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblKala.Size = New System.Drawing.Size(342, 74)
        Me.LblKala.TabIndex = 7
        Me.LblKala.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmEditBatchNoAndEnghezaInSanad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 292)
        Me.Controls.Add(Me.LblKala)
        Me.Controls.Add(Me.TxtBatchNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTozih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNoeEngheza)
        Me.Controls.Add(Me.btNupdate)
        Me.Controls.Add(Me.dbcNoeEnghezaSNB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmEditBatchNoAndEnghezaInSanad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اصلاح بچ و نوع انقضاء"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents lblNoeEngheza As Label
    Public WithEvents btNupdate As Button
    Public WithEvents dbcNoeEnghezaSNB As NetSql.Components.DataCombo
    Public WithEvents Label1 As Label
    Friend WithEvents TxtTozih As TextBox
    Friend WithEvents TxtBatchNo As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents LblKala As Label
End Class
