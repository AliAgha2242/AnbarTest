' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description::  تهيه فايل انبار براي مرکز
'System ::انبار

Imports System.IO

Public Class frmDarkhastFile
    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnErsal As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBrows As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Public WithEvents txtTDate As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnErsal = New System.Windows.Forms.Button
        Me.btnBrows = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.txtTDate = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add (Me.txtTDate)
        Me.Panel1.Controls.Add (Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point (508, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size (129, 35)
        Me.Panel1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point (90, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size (33, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "تاريخ :"
        '
        'btnErsal
        '
        Me.btnErsal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnErsal.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnErsal.Location = New System.Drawing.Point (340, 88)
        Me.btnErsal.Name = "btnErsal"
        Me.btnErsal.Size = New System.Drawing.Size (242, 26)
        Me.btnErsal.TabIndex = 1
        Me.btnErsal.Text = "تهيه فايل"
        '
        'btnBrows
        '
        Me.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBrows.Location = New System.Drawing.Point (7, 4)
        Me.btnBrows.Name = "btnBrows"
        Me.btnBrows.Size = New System.Drawing.Size (55, 23)
        Me.btnBrows.TabIndex = 22
        Me.btnBrows.Text = "انتخاب ..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point (548, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size (87, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "محل ذخيره فايل :"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point (66, 6)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFileName.Size = New System.Drawing.Size (477, 21)
        Me.txtFileName.TabIndex = 21
        Me.txtFileName.Text = ""
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnExit.Location = New System.Drawing.Point (59, 88)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size (242, 26)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "خروج"
        '
        'txtTDate
        '
        Me.txtTDate.AcceptsReturn = True
        Me.txtTDate.AutoSize = False
        Me.txtTDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtTDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTDate.Location = New System.Drawing.Point (5, 7)
        Me.txtTDate.MaxLength = 0
        Me.txtTDate.Name = "txtTDate"
        Me.txtTDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTDate.Size = New System.Drawing.Size (77, 21)
        Me.txtTDate.TabIndex = 17
        Me.txtTDate.Text = ""
        Me.txtTDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDarkhastFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.ClientSize = New System.Drawing.Size (637, 122)
        Me.Controls.Add (Me.btnExit)
        Me.Controls.Add (Me.Panel1)
        Me.Controls.Add (Me.btnBrows)
        Me.Controls.Add (Me.Label5)
        Me.Controls.Add (Me.txtFileName)
        Me.Controls.Add (Me.btnErsal)
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDarkhastFile"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "تهيه فايل انبار براي مرکز"
        Me.Panel1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

    '   براي نمايش تاريخ در فيلتر 
    Private dclTDate As NetSql.Components.CDateCtrl

    Private Sub btnBrows_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrows.Click
        SaveFileDialog1.Title = "تعيين فايل و مسير ..."
        SaveFileDialog1.ShowDialog()
        txtFileName.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub frmDarkhastFile_Load (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dclTDate = New NetSql.Components.CDateCtrl (tp)
        dclTDate.TextBox = txtTDate
        ' تهيه تاريخ از سرور
        dclTDate.Value = _
            Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali (cn, _
                                                                        Functions.FTDBCommonFunctions.enmDateFormat. _
                                                                           Normal)
        txtFileName.Text = "D:\spool.ocr\Inv"
    End Sub

    Private Sub btnErsal_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErsal.Click
        ' تهيه فايل خروجي
        Dim vToDate As String
        If Trim (dclTDate.Value) <> "" Then
            vToDate = Trim (dclTDate.Value)
        Else
            MsgBox (" تاريخ مشخص نشده است")
        End If
        Dim vmydir1, vmydir2 As String
        vmydir1 = Dir (txtFileName.Text, vbDirectory)
        If Trim (vmydir1) = "" Then
            vmydir1 = Dir ("D:\spool.ocr", vbDirectory)
        End If
        vmydir2 = Dir ("D:\Inv\Backup", vbDirectory)
        If Trim (vmydir1) = "" Or Trim (vmydir2) = "" Then
            vmydir1 = "مسير يا شاخه مورد نياز براي ساخت فايل خروجي وجود ندارد" + vbCrLf + _
                      " مسير  : D:\spool.ocr " + vbCrLf + _
                      " مسير  : D:\Inv\Backup "
            NetSql.Common.CSystem.MsgBox(vmydir1)
            Exit Sub
        End If

        If MsgBox ("آيا فايل انبار  ساخته شود ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call CAppAnbar.ErsalFile ("ErsalForMahsoul", txtFileName.Text, vToDate)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub


    Private Sub btnExit_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
