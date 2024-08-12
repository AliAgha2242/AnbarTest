'Author ::دهقانی
'CreateDate :: 93/07/27
'Description:: گزارش درخواست های خرید کالا
'System ::انبار

Public Class FrmRptDarkhastKharid
    Inherits JanusSimpleReport.frmRptJanusBase

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmRptDarkhastKharid
    Friend WithEvents pnlSanadNO As System.Windows.Forms.Panel
    Friend WithEvents txtToDarkhastNO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromDarkhastNO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Public WithEvents dcbKala As NetSql.Components.DataCombo
    Private components As System.ComponentModel.IContainer
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FraSanadDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromDarkhastDate As System.Windows.Forms.TextBox
    Friend WithEvents txtToDarkhastDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TarakoneshCombo As cmpCheckedComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label


    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmRptDarkhastKharid
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptDarkhastKharid
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptDarkhastKharid)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TarakoneshCombo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptDarkhastKharid))
        Me.pnlSanadNO = New System.Windows.Forms.Panel()
        Me.txtToDarkhastNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromDarkhastNO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.dcbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraSanadDate = New System.Windows.Forms.GroupBox()
        Me.txtFromDarkhastDate = New System.Windows.Forms.TextBox()
        Me.txtToDarkhastDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TarakoneshCombo = New cmpCheckedComboBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.pnlSanadNO.SuspendLayout()
        Me.FraSanadDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.FraSanadDate)
        Me.pnlF.Controls.Add(Me.pnlSanadNO)
        Me.pnlF.Controls.Add(Me.dcbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.TarakoneshCombo)
        Me.pnlF.Controls.SetChildIndex(Me.TarakoneshCombo, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.dcbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.pnlSanadNO, 0)
        Me.pnlF.Controls.SetChildIndex(Me.FraSanadDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
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
        'pnlSanadNO
        '
        Me.pnlSanadNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSanadNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSanadNO.Controls.Add(Me.txtToDarkhastNO)
        Me.pnlSanadNO.Controls.Add(Me.Label2)
        Me.pnlSanadNO.Controls.Add(Me.txtFromDarkhastNO)
        Me.pnlSanadNO.Controls.Add(Me.Label9)
        Me.pnlSanadNO.Controls.Add(Me.lbl1)
        Me.pnlSanadNO.Location = New System.Drawing.Point(190, 30)
        Me.pnlSanadNO.Name = "pnlSanadNO"
        Me.pnlSanadNO.Size = New System.Drawing.Size(488, 33)
        Me.pnlSanadNO.TabIndex = 55
        '
        'txtToDarkhastNO
        '
        Me.txtToDarkhastNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDarkhastNO.Location = New System.Drawing.Point(5, 5)
        Me.txtToDarkhastNO.MaxLength = 15
        Me.txtToDarkhastNO.Name = "txtToDarkhastNO"
        Me.txtToDarkhastNO.Size = New System.Drawing.Size(165, 21)
        Me.txtToDarkhastNO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(170, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "تا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFromDarkhastNO
        '
        Me.txtFromDarkhastNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromDarkhastNO.Location = New System.Drawing.Point(207, 5)
        Me.txtFromDarkhastNO.MaxLength = 15
        Me.txtFromDarkhastNO.Name = "txtFromDarkhastNO"
        Me.txtFromDarkhastNO.Size = New System.Drawing.Size(165, 21)
        Me.txtFromDarkhastNO.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(377, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(15, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "از"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(398, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(80, 18)
        Me.lbl1.TabIndex = 27
        Me.lbl1.Text = "شماره سند"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dcbKala
        '
        Me.dcbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbKala.AutoSelectFirst = False
        Me.dcbKala.BackColor = System.Drawing.Color.White
        Me.dcbKala.BoundText = Nothing
        Me.dcbKala.BypassChangeEvent = False
        Me.dcbKala.DisplayText = ""
        Me.dcbKala.LateBindingTop = "100"
        Me.dcbKala.Location = New System.Drawing.Point(545, 4)
        Me.dcbKala.MemFilter = ""
        Me.dcbKala.Name = "dcbKala"
        Me.dcbKala.SeparatedData = Nothing
        Me.dcbKala.Size = New System.Drawing.Size(327, 21)
        Me.dcbKala.Source = Nothing
        Me.dcbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbKala.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(877, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "کالا :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraSanadDate
        '
        Me.FraSanadDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.FraSanadDate.Controls.Add(Me.txtFromDarkhastDate)
        Me.FraSanadDate.Controls.Add(Me.txtToDarkhastDate)
        Me.FraSanadDate.Controls.Add(Me.Label1)
        Me.FraSanadDate.Controls.Add(Me.Label6)
        Me.FraSanadDate.Controls.Add(Me.Label10)
        Me.FraSanadDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FraSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSanadDate.Location = New System.Drawing.Point(686, 24)
        Me.FraSanadDate.Name = "FraSanadDate"
        Me.FraSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraSanadDate.Size = New System.Drawing.Size(232, 39)
        Me.FraSanadDate.TabIndex = 56
        Me.FraSanadDate.TabStop = False
        '
        'txtFromDarkhastDate
        '
        Me.txtFromDarkhastDate.AcceptsReturn = True
        Me.txtFromDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromDarkhastDate.Location = New System.Drawing.Point(99, 12)
        Me.txtFromDarkhastDate.MaxLength = 0
        Me.txtFromDarkhastDate.Name = "txtFromDarkhastDate"
        Me.txtFromDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtFromDarkhastDate.TabIndex = 5
        Me.txtFromDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToDarkhastDate
        '
        Me.txtToDarkhastDate.AcceptsReturn = True
        Me.txtToDarkhastDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtToDarkhastDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToDarkhastDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToDarkhastDate.Location = New System.Drawing.Point(7, 12)
        Me.txtToDarkhastDate.MaxLength = 0
        Me.txtToDarkhastDate.Name = "txtToDarkhastDate"
        Me.txtToDarkhastDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDarkhastDate.Size = New System.Drawing.Size(77, 21)
        Me.txtToDarkhastDate.TabIndex = 6
        Me.txtToDarkhastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(180, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "از"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(87, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تا"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(193, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "تاريخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TarakoneshCombo
        '
        Me.TarakoneshCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TarakoneshCombo_DesignTimeLayout.LayoutString = resources.GetString("TarakoneshCombo_DesignTimeLayout.LayoutString")
        Me.TarakoneshCombo.DesignTimeLayout = TarakoneshCombo_DesignTimeLayout
        Me.TarakoneshCombo.LateBinding = True
        Me.TarakoneshCombo.LateBindingTop = "100"
        Me.TarakoneshCombo.Location = New System.Drawing.Point(190, 5)
        Me.TarakoneshCombo.Name = "TarakoneshCombo"
        Me.TarakoneshCombo.SaveSettings = False
        Me.TarakoneshCombo.ShowSelectAll = True
        Me.TarakoneshCombo.Size = New System.Drawing.Size(286, 21)
        Me.TarakoneshCombo.TabIndex = 57
        Me.TarakoneshCombo.ValuesDataMember = Nothing
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(482, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "تراکنش :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmRptDarkhastKharid
        '
        Me.ClientSize = New System.Drawing.Size(921, 475)
        Me.Name = "FrmRptDarkhastKharid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش درخواست خرید کالا"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.pnlSanadNO.ResumeLayout(False)
        Me.pnlSanadNO.PerformLayout()
        Me.FraSanadDate.ResumeLayout(False)
        Me.FraSanadDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#Region "Private Variable"
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl

#End Region

    Sub setColumnProperties()
        Dim dvTableFooter As DataView
        dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 ON T1.ObjectSN = T2.ObjectSN WHERE T1.ObjectDS='abQuery_DarkhastKharid' AND ObjectHaNo <> '0' ORDER BY CAST(ObjectHaNo AS BIGINT)")
        For i As Integer = 0 To dvTableFooter.Count - 1
            With GridEX1.RootTable.Columns()
                With .Add(dvTableFooter.Item(i).Item("ObjectHaDS"), Janus.Windows.GridEX.ColumnType.Text)
                    .Caption = dvTableFooter.Item(i).Item("ObjectHaFDS")

                End With

            End With
        Next
    End Sub

    Private Sub FrmRptDarkhastKharid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim vSql As String

        vSql = "SELECT 'همه موارد' AS Kala , 0 AS KalaSN UNION  SELECT DISTINCT KalaNo+'-'+KalaDS AS Kala ,T1.KalaSN From Pakala T1 INNEr JOIN AbanbarKala T2 ON T1.KalaSN = T2.KalaSN   Where  AnbarSN IN ( " & gAnbarSelected.ToString & "  )  "

        dcbKala.LateBinding = True
        dcbKala.Bind(cn, vSql, "KalaSN", "Kala")
        dcbKala.SelectedValue = 0

        Call setColumnProperties()
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = Microsoft.VisualBasic.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        End If

        With TarakoneshCombo
            .Bind(cn, " select  distinct abTarakonesh.TarakoneshSN,TarakoneshDs from absanad " & _
                      "join absanadha on absanad.sanadsn = absanadha.sanadsn " & _
                      "join abSanadHaDarkhast On abSanadHaDarkhast.SanadHaSN = absanadha.SanadHaSN " & _
                      "join abTarakonesh On abSanad.TarakoneshSN = abTarakonesh.TarakoneshSN ", "TarakoneshSN", "TarakoneshDS")
            .ShowSelectAll = True
            .DroppedDown = True
        End With

    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click


        Dim vFromDate As String = ""
        Dim vToDate As String = ""
        Dim vErrMsg As String = ""
        Dim strAnbars As String = ""
        Dim vStrKalaSN As String = ""
        Dim vDarkhastStatus As String = ""
        Dim vFromSanadNo, vToSanadNo As String
        Dim tarakonesh As String

        Dim CCon As New SqlClient.SqlConnection
        Dim ccom As New SqlClient.SqlCommand
        Dim Sda As New SqlClient.SqlDataAdapter
        Dim Ds As New DataSet


        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr(gAnbarSN)
        End If

        If txtToDarkhastNO.Text.Trim <> "" AndAlso Not Long.TryParse(txtToDarkhastNO.Text, Nothing) Then
            vErrMsg = vErrMsg & " فرمت فیلد تا شماره سند صحیح نیست" & vbCrLf
        End If

        If txtFromDarkhastNO.Text.Trim <> "" AndAlso Not Long.TryParse(txtFromDarkhastNO.Text, Nothing) Then
            vErrMsg = vErrMsg & " فرمت فیلد از شماره سند صحیح نیست " & vbCrLf
        End If

        If TarakoneshCombo.getStringValues Is Nothing OrElse TarakoneshCombo.getStringValues = "0" Then
            Dim Dt As DataTable = TarakoneshCombo.DropDownDataSource
            For i As Integer = 1 To Dt.Rows.Count - 1
                tarakonesh += Dt.DefaultView(i)("TarakoneshSN").ToString + ","
            Next
            tarakonesh = tarakonesh.Substring(0, tarakonesh.Length - 1)
        Else
            tarakonesh = TarakoneshCombo.getStringValues
        End If

        If vErrMsg = "" Then

            GridEX1.RootTable.Columns.Clear()

            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If

            vFromSanadNo = txtFromDarkhastNO.Text.Trim
            vToSanadNo = txtToDarkhastNO.Text.Trim

            If Trim(dcbKala.BoundText) <> "" AndAlso Trim(dcbKala.SelectedValue) <> 0 Then
                If vStrKalaSN <> "" Then
                    vStrKalaSN = vStrKalaSN & "," & CStr(dcbKala.SelectedValue)
                Else
                    vStrKalaSN = CStr(dcbKala.SelectedValue)
                End If

            End If

            Try
                Me.Cursor = Cursors.WaitCursor

                CCon.ConnectionString = cn.ConnectionString + "; password=" & cn.SQLPassword
                ccom.Connection = CCon

                ccom.CommandText = "_abSpr_DarkhastKharid"
                ccom.CommandType = CommandType.StoredProcedure
                ccom.Parameters.AddWithValue("@VahedeTejariSN", CStr(gVahedeTejariSN))
                ccom.Parameters.AddWithValue("@AnbarSN", strAnbars)
                ccom.Parameters.AddWithValue("@Fromdate", vFromDate)
                ccom.Parameters.AddWithValue("@ToDate", vToDate)
                ccom.Parameters.AddWithValue("@KalaSn", vStrKalaSN)
                ccom.Parameters.AddWithValue("@FromSanadNo", vFromSanadNo)
                ccom.Parameters.AddWithValue("@ToSanadNo", vToSanadNo)
                ccom.Parameters.AddWithValue("@TarakoneshSN", tarakonesh)

                Sda.SelectCommand = ccom
                Sda.Fill(Ds)


                GridEX1.DataSource = Ds.Tables(0).DefaultView
                GridEX1.RetrieveStructure()


                Dim dvTableFooter As DataView
                dvTableFooter = cn.ExecuteQuery("SELECT ObjectHaDS,ObjectHaFDS FROM PaObject T1 INNER JOIN PaObjectHa T2 " & _
                                                "ON T1.ObjectSN = T2.ObjectSN WHERE " & _
                                                "T1.ObjectDS='abQuery_DarkhastKharid' AND ObjectHaNo <> '0' " & _
                                                "ORDER BY CAST(ObjectHaNo AS BIGINT)")

                For Each jcol As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
                    dvTableFooter.RowFilter = "ObjectHaDS = '" & jcol.Key & "'"
                    If dvTableFooter.Count > 0 Then
                        jcol.Caption = dvTableFooter(0)("ObjectHaFDS")
                    Else
                        jcol.Visible = False
                    End If
                Next

                RefreshDataSet()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                NetSql.Common.CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
            End Try

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

End Class
