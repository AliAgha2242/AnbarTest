'Programmer :: Zohreh Izadpanah     
'CreateDate :: 1385/08/09
'ModifiedDate::
'Description:: فرم ورود تاريخ ابطال 
'System :: سيستم تدارکات داخلي
Public Class frmInputDate
    Inherits Minoo.base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate As NetSql.Components.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtDate = New NetSql.Components.TextBox (Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.txtDate.Location = New System.Drawing.Point (144, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate.Size = New System.Drawing.Size (79, 22)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point (240, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size (152, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "لطفا تاريخ ابطال را وارد کنيد."
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point (141, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size (64, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "انصراف"
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Location = New System.Drawing.Point (211, 64)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size (64, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "تاييد"
        '
        'frmInputDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 15)
        Me.ClientSize = New System.Drawing.Size (416, 104)
        Me.Controls.Add (Me.btnOk)
        Me.Controls.Add (Me.btnCancel)
        Me.Controls.Add (Me.Label2)
        Me.Controls.Add (Me.txtDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputDate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ورود تاريخ ابطال"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "PublicVariablesDefinition"

    Public EbtalDate As String

#End Region

#Region "PrivateVariabledDefinition"

    Private dcldate As NetSql.components.CDateCtrl

#End Region

    '//ناحيه تعريف متغيرهاي Local


    Private Sub frmInputDate_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dcldate = New NetSql.components.CDateCtrl (tp)
        dcldate.TextBox = txtDate
        dcldate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        dcldate.Text = gHesabdariSalFDate

        Me.FirstFocusControl = txtDate

    End Sub

    Private Sub btnCancel_Click (ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel

    End Sub

    Private Sub btnOk_Click (ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If dcldate.Value < gHesabdariSalFDate.Trim Or dcldate.Value > gHesabdariSalTDate.Trim Then
            NetSql.Common.CSystem.MsgBox("تاريخ ابطال خارج از سال مالي انتخاب شده مي باشد", MsgBoxStyle.Critical, _
                       "خطا در ورود تاريخ ابطال")
            txtDate.Focus()
            Exit Sub

        End If


        EbtalDate = txtDate.Text
        DialogResult = DialogResult.OK

    End Sub
End Class
