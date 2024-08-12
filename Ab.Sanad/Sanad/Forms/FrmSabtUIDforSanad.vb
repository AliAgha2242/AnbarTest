Public Class FrmSabtUIDforSanad
    Inherits Minoo.Base.FTBaseForm
    Friend WithEvents TxtUID As TextBox
    Friend WithEvents GridUID As Janus.Windows.GridEX.GridEX
    Private Shared m_initializingdefinstance As Boolean
    Private components As System.ComponentModel.IContainer
    Friend WithEvents BtnSabt As Janus.Windows.EditControls.UIButton
    Friend WithEvents LabelKala As Label
    Friend WithEvents Label1 As Label
    Private Shared m_vb6formdefinstance As FrmSabtUIDforSanad

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public Shared Property DefInstance() As FrmSabtUIDforSanad

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmSabtUIDforSanad
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmSabtUIDforSanad)
            m_vb6formdefinstance = Value

        End Set

    End Property


    Private Sub InitializeComponent()
        Dim GridUID_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSabtUIDforSanad))
        Me.GridUID = New Janus.Windows.GridEX.GridEX()
        Me.TxtUID = New System.Windows.Forms.TextBox()
        Me.BtnSabt = New Janus.Windows.EditControls.UIButton()
        Me.LabelKala = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GridUID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridUID
        '
        Me.GridUID.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridUID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridUID.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridUID_DesignTimeLayout.LayoutString = resources.GetString("GridUID_DesignTimeLayout.LayoutString")
        Me.GridUID.DesignTimeLayout = GridUID_DesignTimeLayout
        Me.GridUID.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridUID.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridUID.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridUID.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridUID.GroupByBoxVisible = False
        Me.GridUID.Location = New System.Drawing.Point(1, 72)
        Me.GridUID.Name = "GridUID"
        Me.GridUID.RecordNavigator = True
        Me.GridUID.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridUID.Size = New System.Drawing.Size(469, 240)
        Me.GridUID.TabIndex = 16
        Me.GridUID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TxtUID
        '
        Me.TxtUID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUID.BackColor = System.Drawing.SystemColors.Info
        Me.TxtUID.Location = New System.Drawing.Point(356, 326)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(10, 22)
        Me.TxtUID.TabIndex = 18
        Me.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUID.Visible = False
        '
        'BtnSabt
        '
        Me.BtnSabt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnSabt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSabt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabt.Location = New System.Drawing.Point(1, 318)
        Me.BtnSabt.Name = "BtnSabt"
        Me.BtnSabt.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.BtnSabt.Office2007CustomColor = System.Drawing.Color.PaleGreen
        Me.BtnSabt.Size = New System.Drawing.Size(469, 35)
        Me.BtnSabt.TabIndex = 209
        Me.BtnSabt.Text = "ثبت نهایی"
        Me.BtnSabt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'LabelKala
        '
        Me.LabelKala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelKala.Location = New System.Drawing.Point(1, 0)
        Me.LabelKala.Name = "LabelKala"
        Me.LabelKala.Size = New System.Drawing.Size(469, 69)
        Me.LabelKala.TabIndex = 210
        Me.LabelKala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "محل درج UID : "
        Me.Label1.Visible = False
        '
        'FrmSabtUIDforSanad
        '
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(471, 356)
        Me.Controls.Add(Me.LabelKala)
        Me.Controls.Add(Me.BtnSabt)
        Me.Controls.Add(Me.TxtUID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridUID)
        Me.Name = "FrmSabtUIDforSanad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت UID "
        CType(Me.GridUID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public KalaRahgiri As String
    Public SanadHaSN As Decimal
    Public MeghdarSanadHa As Decimal
    Public DvData As DataView
    Private Sub FrmSabtUIDforSanad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelKala.Text = KalaRahgiri
        Me.LabelKala.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridUID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DvData = cn.ExecuteQuery("Exec abSpG_GetProductCatalogueOfSanadHaSN " & SanadHaSN.ToString)
        GridUID.DataSource = DvData
        GridUID.Refresh()
        GridUID.AutoSizeColumns()
    End Sub

    Private Sub BtnSabt_Click(sender As Object, e As EventArgs) Handles BtnSabt.Click
        If GridUID.GetCheckedRows.Length = 0 Then
            CSystem.MsgBox("موردی جهت ثبت انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CSystem.MsgBox("آیا مایل به ثبت UID های انتخاب شده برای این سند می باشید؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim SumTedadUID As Decimal = 0
        Dim CatalogueSN As String = ""
        For Each grow As Janus.Windows.GridEX.GridEXRow In GridUID.GetRows
            If grow.Cells("Status").Value = 1 Then
                CSystem.MsgBox("این مورد برای این سند قبلا ثبت شده است" + vbNewLine + "UID : " + grow.Cells("UID").Text, MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            CatalogueSN += If(grow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked, grow.Cells("ProductCatalogueDetailSN").Text + ",", "")
            SumTedadUID += If(grow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked OrElse grow.Cells("Status").Value = 1, CDec(grow.Cells("Amount").Value), 0)
        Next

        If CatalogueSN.Length > 0 And CatalogueSN.EndsWith(",") Then
            CatalogueSN = CatalogueSN.Substring(0, CatalogueSN.Length - 1)
        Else
            CSystem.MsgBox("خطا در تشخیص CatalogueSN", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        If SumTedadUID <> MeghdarSanadHa Then
            CSystem.MsgBox("مجموع تعدادی UID (های) ثبت شده با مقدار ثبت شده سند مغایرت دارد " + vbNewLine +
                           "مقدار سند :" + MeghdarSanadHa.ToString + vbNewLine + "مجموع تعداد  : " + SumTedadUID.ToString, MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        Try
            cn.ExecuteNoneQuery("Exec abSpC_InsertProductCatalogueOfSanadHaSN " & SanadHaSN.ToString & ",'" & CatalogueSN & "','" & gSM.UserID_Name & "'")
            CSystem.MsgBox("عملیات ثبت با موفقیت انجام گردید", MsgBoxStyle.Information, "")
            Me.Close()
        Catch ex As Exception
            CSystem.MsgBox("خطا در اجرای اس پی " + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "")
        End Try
    End Sub

    Private Sub GridUID_RowCheckStateChanged(sender As Object, e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridUID.RowCheckStateChanged
        GridUID.Refresh()
        Dim grow As Janus.Windows.GridEX.GridEXRow
        grow = GridUID.CurrentRow
        If grow Is Nothing Then
            Exit Sub
        End If
        If grow.RowType <> Janus.Windows.GridEX.RowType.Record Then
            Exit Sub
        End If

        If grow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            If grow.Cells("Status").Value = 1 Then
                CSystem.MsgBox("این مورد برای این سند قبلا ثبت شده است", MsgBoxStyle.Exclamation, "")
                grow.BeginEdit()
                grow.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked
                grow.EndEdit()
            Else
                grow.Cells("Status").Value = 2
            End If
        End If
    End Sub

    'Private Sub TxtUID_TextChanged(sender As Object, e As EventArgs) Handles TxtUID.TextChanged
    '    If TxtUID.Text.Length = 20 Then
    '        For Each grow As Janus.Windows.GridEX.GridEXRow In GridUID.GetRows
    '            If grow.Cells("UID").Text = TxtUID.Text Then
    '                If grow.Cells("Status").Value = 1 Then
    '                    CSystem.MsgBox("این مورد برای این سند قبلا ثبت شده است", MsgBoxStyle.Exclamation, "")
    '                    grow.BeginEdit()
    '                    grow.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked
    '                    grow.EndEdit()
    '                Else
    '                    grow.BeginEdit()
    '                    grow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked
    '                    grow.EndEdit()
    '                End If

    '            End If
    '        Next
    '    End If
    'End Sub
End Class
