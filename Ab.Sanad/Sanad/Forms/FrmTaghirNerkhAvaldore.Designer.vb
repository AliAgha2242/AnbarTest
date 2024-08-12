<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTaghirNerkhAvaldore
    Inherits System.Windows.Forms.Form
    'Inherits Minoo.Base.FTBaseForm
    'Inherits Minoo.Base.FTFormBaseSingleTable
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbShomarehRahgiri = New System.Windows.Forms.RadioButton()
        Me.rdbkalaNo = New System.Windows.Forms.RadioButton()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.TxtDrive = New System.Windows.Forms.TextBox()
        Me.btnGhate = New System.Windows.Forms.Button()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.btnFormatExcel = New System.Windows.Forms.Button()
        Me.btnGetkala = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnHazfEntekhabi = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(804, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "توجه: برای هر کالا _رهگیری، حداکثر 2 بار مجاز به تغییر نرخ می باشید."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnHazfEntekhabi)
        Me.Panel1.Controls.Add(Me.rdbShomarehRahgiri)
        Me.Panel1.Controls.Add(Me.rdbkalaNo)
        Me.Panel1.Controls.Add(Me.btnImportExcel)
        Me.Panel1.Controls.Add(Me.TxtDrive)
        Me.Panel1.Controls.Add(Me.btnGhate)
        Me.Panel1.Controls.Add(Me.pnlG)
        Me.Panel1.Controls.Add(Me.pnlC)
        Me.Panel1.Controls.Add(Me.pnlN)
        Me.Panel1.Controls.Add(Me.btnFormatExcel)
        Me.Panel1.Controls.Add(Me.btnGetkala)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1291, 623)
        Me.Panel1.TabIndex = 21
        '
        'rdbShomarehRahgiri
        '
        Me.rdbShomarehRahgiri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbShomarehRahgiri.AutoSize = True
        Me.rdbShomarehRahgiri.Location = New System.Drawing.Point(235, 599)
        Me.rdbShomarehRahgiri.Name = "rdbShomarehRahgiri"
        Me.rdbShomarehRahgiri.Size = New System.Drawing.Size(95, 17)
        Me.rdbShomarehRahgiri.TabIndex = 208
        Me.rdbShomarehRahgiri.TabStop = True
        Me.rdbShomarehRahgiri.Text = "شماره رهگیری"
        Me.rdbShomarehRahgiri.UseVisualStyleBackColor = True
        '
        'rdbkalaNo
        '
        Me.rdbkalaNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbkalaNo.AutoSize = True
        Me.rdbkalaNo.Location = New System.Drawing.Point(273, 576)
        Me.rdbkalaNo.Name = "rdbkalaNo"
        Me.rdbkalaNo.Size = New System.Drawing.Size(57, 17)
        Me.rdbkalaNo.TabIndex = 198
        Me.rdbkalaNo.TabStop = True
        Me.rdbkalaNo.Text = "کد کالا"
        Me.rdbkalaNo.UseVisualStyleBackColor = True
        '
        'btnImportExcel
        '
        Me.btnImportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportExcel.Location = New System.Drawing.Point(348, 583)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(111, 33)
        Me.btnImportExcel.TabIndex = 207
        Me.btnImportExcel.Text = "دریافت از اکسل"
        Me.btnImportExcel.UseVisualStyleBackColor = True
        '
        'TxtDrive
        '
        Me.TxtDrive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDrive.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDrive.Location = New System.Drawing.Point(561, 593)
        Me.TxtDrive.Name = "TxtDrive"
        Me.TxtDrive.Size = New System.Drawing.Size(20, 20)
        Me.TxtDrive.TabIndex = 206
        Me.TxtDrive.Text = "D"
        Me.TxtDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGhate
        '
        Me.btnGhate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGhate.Location = New System.Drawing.Point(843, 583)
        Me.btnGhate.Name = "btnGhate"
        Me.btnGhate.Size = New System.Drawing.Size(75, 33)
        Me.btnGhate.TabIndex = 199
        Me.btnGhate.Text = "قطعی"
        Me.btnGhate.UseVisualStyleBackColor = True
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.Location = New System.Drawing.Point(7, 38)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.Size = New System.Drawing.Size(1277, 532)
        Me.pnlG.TabIndex = 205
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.Location = New System.Drawing.Point(1056, 577)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.Size = New System.Drawing.Size(228, 41)
        Me.pnlC.TabIndex = 203
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(7, 576)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.Size = New System.Drawing.Size(220, 40)
        Me.pnlN.TabIndex = 204
        '
        'btnFormatExcel
        '
        Me.btnFormatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFormatExcel.Location = New System.Drawing.Point(465, 583)
        Me.btnFormatExcel.Name = "btnFormatExcel"
        Me.btnFormatExcel.Size = New System.Drawing.Size(90, 33)
        Me.btnFormatExcel.TabIndex = 202
        Me.btnFormatExcel.Text = "فرمت اکسل"
        Me.btnFormatExcel.UseVisualStyleBackColor = True
        '
        'btnGetkala
        '
        Me.btnGetkala.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetkala.Cursor = System.Windows.Forms.Cursors.PanSW
        Me.btnGetkala.Location = New System.Drawing.Point(587, 583)
        Me.btnGetkala.Name = "btnGetkala"
        Me.btnGetkala.Size = New System.Drawing.Size(133, 33)
        Me.btnGetkala.TabIndex = 201
        Me.btnGetkala.Text = "دریافت اطلاعات کالاها"
        Me.btnGetkala.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Location = New System.Drawing.Point(726, 583)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(111, 33)
        Me.btnExcel.TabIndex = 200
        Me.btnExcel.Text = "ارسال به اکسل"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnHazfEntekhabi
        '
        Me.btnHazfEntekhabi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHazfEntekhabi.Location = New System.Drawing.Point(924, 583)
        Me.btnHazfEntekhabi.Name = "btnHazfEntekhabi"
        Me.btnHazfEntekhabi.Size = New System.Drawing.Size(126, 33)
        Me.btnHazfEntekhabi.TabIndex = 209
        Me.btnHazfEntekhabi.Text = "حذف موارد انتخابی"
        Me.btnHazfEntekhabi.UseVisualStyleBackColor = True
        '
        'FrmTaghirNerkhAvaldore
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1291, 623)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "FrmTaghirNerkhAvaldore"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغییر نرخ اول دوره"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbShomarehRahgiri As RadioButton
    Friend WithEvents rdbkalaNo As RadioButton
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents TxtDrive As TextBox
    Friend WithEvents btnGhate As Button
    Public WithEvents pnlG As Panel
    Public WithEvents pnlC As Panel
    Public WithEvents pnlN As Panel
    Friend WithEvents btnFormatExcel As Button
    Friend WithEvents btnGetkala As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnHazfEntekhabi As Button
End Class
