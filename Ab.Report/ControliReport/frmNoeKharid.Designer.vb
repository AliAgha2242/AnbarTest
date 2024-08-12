<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoeKharid
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
        Me.rdoDakheli = New System.Windows.Forms.RadioButton()
        Me.rdoKhareji = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dbcTaghazaKonandeh = New NetSql.Components.DataCombo(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdoDakheli
        '
        Me.rdoDakheli.AutoSize = True
        Me.rdoDakheli.Checked = True
        Me.rdoDakheli.Location = New System.Drawing.Point(175, 47)
        Me.rdoDakheli.Name = "rdoDakheli"
        Me.rdoDakheli.Size = New System.Drawing.Size(79, 17)
        Me.rdoDakheli.TabIndex = 0
        Me.rdoDakheli.TabStop = True
        Me.rdoDakheli.Text = "خرید داخلی"
        Me.rdoDakheli.UseVisualStyleBackColor = True
        '
        'rdoKhareji
        '
        Me.rdoKhareji.AutoSize = True
        Me.rdoKhareji.Location = New System.Drawing.Point(60, 47)
        Me.rdoKhareji.Name = "rdoKhareji"
        Me.rdoKhareji.Size = New System.Drawing.Size(81, 17)
        Me.rdoKhareji.TabIndex = 1
        Me.rdoKhareji.Text = "خرید خارجی"
        Me.rdoKhareji.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "نوع خرید جهت ارسال به تدارکات"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(201, 126)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "تایــید"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 126)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dbcTaghazaKonandeh
        '
        Me.dbcTaghazaKonandeh.AutoSelectFirst = True
        Me.dbcTaghazaKonandeh.BackColor = System.Drawing.Color.White
        Me.dbcTaghazaKonandeh.BoundText = Nothing
        Me.dbcTaghazaKonandeh.BypassChangeEvent = False
        Me.dbcTaghazaKonandeh.DisplayText = ""
        Me.dbcTaghazaKonandeh.LateBindingTop = "100"
        Me.dbcTaghazaKonandeh.Location = New System.Drawing.Point(13, 86)
        Me.dbcTaghazaKonandeh.MemFilter = ""
        Me.dbcTaghazaKonandeh.Name = "dbcTaghazaKonandeh"
        Me.dbcTaghazaKonandeh.SeparatedData = Nothing
        Me.dbcTaghazaKonandeh.Size = New System.Drawing.Size(193, 21)
        Me.dbcTaghazaKonandeh.Source = Nothing
        Me.dbcTaghazaKonandeh.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dbcTaghazaKonandeh.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "واحد تقاضا کننده:"
        '
        'frmNoeKharid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 161)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dbcTaghazaKonandeh)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdoKhareji)
        Me.Controls.Add(Me.rdoDakheli)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNoeKharid"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نوع خرید"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoDakheli As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKhareji As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents dbcTaghazaKonandeh As NetSql.Components.DataCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
