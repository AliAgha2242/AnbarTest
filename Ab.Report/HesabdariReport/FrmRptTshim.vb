'Author :: زهره ايزدپناه
'CreateDate :: 86/04/13
'ModifiedDate::
'Description:: گزارش اسناد تسهيم سالانه
'System :: سيستم انبار


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum

Public Class FrmRptTashim
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
    Friend WithEvents pnlg1 As System.Windows.Forms.Panel
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents pnln1 As System.Windows.Forms.Panel
    Friend WithEvents pnlc1 As System.Windows.Forms.Panel
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents dcbTashimPattern As NetSql.Components.DataCombo
    Public WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents btnShowHideCols As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtToDate As NetSql.Components.TextBox
    Friend WithEvents txtFromDate As NetSql.Components.TextBox
    Friend WithEvents lblFDate As System.Windows.Forms.Label
    Friend WithEvents lblTDate As System.Windows.Forms.Label
    Friend WithEvents RdoByDate As System.Windows.Forms.RadioButton
    Friend WithEvents RdoCurYear As System.Windows.Forms.RadioButton

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlg1 = New System.Windows.Forms.Panel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.pnln1 = New System.Windows.Forms.Panel()
        Me.pnlc1 = New System.Windows.Forms.Panel()
        Me.dcbTashimPattern = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnShowHideCols = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtToDate = New NetSql.Components.TextBox(Me.components)
        Me.txtFromDate = New NetSql.Components.TextBox(Me.components)
        Me.lblFDate = New System.Windows.Forms.Label()
        Me.lblTDate = New System.Windows.Forms.Label()
        Me.RdoByDate = New System.Windows.Forms.RadioButton()
        Me.RdoCurYear = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlg1
        '
        Me.pnlg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlg1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlg1.Location = New System.Drawing.Point(2, 111)
        Me.pnlg1.Name = "pnlg1"
        Me.pnlg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlg1.Size = New System.Drawing.Size(947, 333)
        Me.pnlg1.TabIndex = 28
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Enabled = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(508, 455)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExcel.Size = New System.Drawing.Size(94, 44)
        Me.btnExcel.TabIndex = 11
        Me.btnExcel.Text = "Excel"
        '
        'pnln1
        '
        Me.pnln1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnln1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnln1.Location = New System.Drawing.Point(2, 452)
        Me.pnln1.Name = "pnln1"
        Me.pnln1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnln1.Size = New System.Drawing.Size(280, 47)
        Me.pnln1.TabIndex = 12
        '
        'pnlc1
        '
        Me.pnlc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlc1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlc1.Location = New System.Drawing.Point(606, 454)
        Me.pnlc1.Name = "pnlc1"
        Me.pnlc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlc1.Size = New System.Drawing.Size(344, 47)
        Me.pnlc1.TabIndex = 10
        '
        'dcbTashimPattern
        '
        Me.dcbTashimPattern.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcbTashimPattern.AutoSelectFirst = False
        Me.dcbTashimPattern.BackColor = System.Drawing.Color.White
        Me.dcbTashimPattern.BoundText = Nothing
        Me.dcbTashimPattern.BypassChangeEvent = False
        Me.dcbTashimPattern.DisplayText = ""
        Me.dcbTashimPattern.LateBindingTop = "100"
        Me.dcbTashimPattern.Location = New System.Drawing.Point(-56, 20)
        Me.dcbTashimPattern.MemFilter = ""
        Me.dcbTashimPattern.Name = "dcbTashimPattern"
        Me.dcbTashimPattern.SeparatedData = Nothing
        Me.dcbTashimPattern.Size = New System.Drawing.Size(382, 26)
        Me.dcbTashimPattern.Source = Nothing
        Me.dcbTashimPattern.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbTashimPattern.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(336, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "الگوي تسهيم :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(9, 10)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size(80, 44)
        Me.btnOk.TabIndex = 31
        Me.btnOk.Text = "مشاهده"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnShowHideCols
        '
        Me.btnShowHideCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowHideCols.BackColor = System.Drawing.Color.Transparent
        Me.btnShowHideCols.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowHideCols.Enabled = False
        Me.btnShowHideCols.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowHideCols.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnShowHideCols.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowHideCols.Location = New System.Drawing.Point(411, 455)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size(94, 44)
        Me.btnShowHideCols.TabIndex = 32
        Me.btnShowHideCols.Text = "تنظيم"
        Me.btnShowHideCols.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtToDate)
        Me.GroupBox1.Controls.Add(Me.txtFromDate)
        Me.GroupBox1.Controls.Add(Me.lblFDate)
        Me.GroupBox1.Controls.Add(Me.lblTDate)
        Me.GroupBox1.Controls.Add(Me.RdoByDate)
        Me.GroupBox1.Controls.Add(Me.RdoCurYear)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(445, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 101)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'txtToDate
        '
        Me.txtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToDate.Location = New System.Drawing.Point(19, 60)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDate.Size = New System.Drawing.Size(98, 26)
        Me.txtToDate.TabIndex = 22
        '
        'txtFromDate
        '
        Me.txtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFromDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(196, 60)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFromDate.Size = New System.Drawing.Size(98, 26)
        Me.txtFromDate.TabIndex = 21
        '
        'lblFDate
        '
        Me.lblFDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblFDate.ForeColor = System.Drawing.Color.Black
        Me.lblFDate.Location = New System.Drawing.Point(261, 65)
        Me.lblFDate.Name = "lblFDate"
        Me.lblFDate.Size = New System.Drawing.Size(84, 17)
        Me.lblFDate.TabIndex = 23
        Me.lblFDate.Text = "از تاريخ:"
        '
        'lblTDate
        '
        Me.lblTDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblTDate.ForeColor = System.Drawing.Color.Black
        Me.lblTDate.Location = New System.Drawing.Point(84, 65)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size(84, 17)
        Me.lblTDate.TabIndex = 24
        Me.lblTDate.Text = "تا تاريخ:"
        '
        'RdoByDate
        '
        Me.RdoByDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RdoByDate.ForeColor = System.Drawing.Color.Black
        Me.RdoByDate.Location = New System.Drawing.Point(364, 58)
        Me.RdoByDate.Name = "RdoByDate"
        Me.RdoByDate.Size = New System.Drawing.Size(121, 31)
        Me.RdoByDate.TabIndex = 1
        Me.RdoByDate.Text = "با تاريخ"
        '
        'RdoCurYear
        '
        Me.RdoCurYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RdoCurYear.ForeColor = System.Drawing.Color.Black
        Me.RdoCurYear.Location = New System.Drawing.Point(336, 22)
        Me.RdoCurYear.Name = "RdoCurYear"
        Me.RdoCurYear.Size = New System.Drawing.Size(149, 30)
        Me.RdoCurYear.TabIndex = 0
        Me.RdoCurYear.Text = "سال مالي جاري"
        '
        'FrmRptTashim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.ClientSize = New System.Drawing.Size(952, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnShowHideCols)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dcbTashimPattern)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlg1)
        Me.Controls.Add(Me.pnlc1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.pnln1)
        Me.Name = "FrmRptTashim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش اسناد تسهيم انحراف"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptTashim
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptTashim
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptTashim
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmRptTashim)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariabledDefinition"

    Private WithEvents MasterDataView As NetSql.View.CDataView
    Private LastHesabdariSalToDate As String

    Private dclFdate As NetSql.components.CDateCtrl
    Private dclTdate As NetSql.components.CDateCtrl

#End Region

    Private Sub FrmRptTashim_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlStr As String

        pnlg1.RightToLeft = RightToLeft.Yes

        MasterDataView = New NetSql.View.CDataView (cn)

        RdoByDate.Checked = True

        '// براي تاريخ شروع و تاريخ پايان
        dclFdate = New NetSql.components.CDateCtrl (tp)
        dclFdate.TextBox = txtFromDate
        dclFdate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        dclFdate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi (Today, dclFdate.DateFormat)

        dclTdate = New NetSql.components.CDateCtrl (tp)
        dclTdate.TextBox = txtToDate
        dclTdate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        dclTdate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi (Today, dclTdate.DateFormat)
        '// براي تاريخ شروع و تاريخ پايان


        ' تهيه سلکت براي مقدار دهي کامبو
        SqlStr = " SELECT TashimPatternSN, TashimPatternNo+'-'+TashimPatternDS AS TashimPatternDS From abTashimPattern "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbTashimPattern.Bind (cn, SqlStr, "TashimPatternSN", "TashimPatternDS")


        '//Initialize MasterDataView
        With MasterDataView
            .Init (pnlg1, , pnlc1, pnln1, _
                   EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdExit)
            .EditInGrid = False
            .Text = Me.Text
            .QueryName = "abQueryRpt_Tadil"

            '//Initialize MasterDataView
        End With
    End Sub


    Private Sub MasterDataView_GetGridProperties() Handles MasterDataView.GetGridProperties

        With MasterDataView

            'With .Fields("MoinNo")
            '  .Caption = "کد معين"
            'End With

            'With .Fields("GoroohTafsiliNo1")
            '  .Caption = "کد گروه تفصيلي1"
            'End With

            'With .Fields("TafsiliNo1")
            '  .Caption = "تفصيلي1"
            'End With

            'With .Fields("GoroohTafsiliNo2")
            '  .Caption = "کد گروه تفصيلي2"
            'End With

            'With .Fields("TafsiliNo2")
            '  .Caption = "تفصيلي 2"
            'End With

            'With .Fields("GoroohTafsiliNo3")
            '  .Caption = "کد گروه تفصيلي 3"
            'End With

            'With .Fields("TafsiliNo3")
            '  .Caption = "تفصيلي 3"
            'End With

            'With .Fields("GoroohTafsiliNo4")
            '  .Caption = "کد گروه تفصيلي 4"
            'End With

            'With .Fields("TafsiliNo4")
            '  .Caption = "تفصيلي 4"
            'End With

            'With .Fields("GoroohTafsiliNo5")
            '  .Caption = "کد گروه تفصيلي 5"
            'End With

            'With .Fields("TafsiliNo5")
            '  .Caption = "تفصيلي 5"
            'End With

            'With .Fields("Sharh")
            '  .Caption = "شرح سند"
            'End With

            'With .Fields("Bed")
            '  .Caption = "بدهکار"
            'End With

            'With .Fields("Bes")
            '  .Caption = "بستانکار"
            'End With

            'With .Fields("PeigiriNo")
            '  .Caption = "شماره پيگيري"
            'End With

            'With .Fields("PeigiriDate")
            '  .Caption = "تاريخ پيگيري"
            'End With

            'With .Fields("Meghdar")
            '  .Caption = "مقدار/تعداد"
            'End With

            'With .Fields("MeghdarArz")
            '  .Caption = "مبلغ(ارز)"
            'End With


            .FlexGrid.Subtotal(SubtotalSettings.Clear)
            .FlexGrid.SubtotalPosition = SubtotalPositionSettings.BelowData
            .FlexGrid.Subtotal(SubtotalSettings.Sum, -1, .FlexGrid.ColIndex("Bed"), "#,#", _
                                RGB(255, 255, 192), RGB(0, 0, 256), , "مجموع", 0, True)
            .FlexGrid.Subtotal(SubtotalSettings.Sum, -1, .FlexGrid.ColIndex("Bes"), "#,#", _
                                RGB(255, 255, 192), RGB(0, 0, 256), , "مجموع", 0, True)

        End With

    End Sub

    Private Sub btnExcel_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String

        vFileName = Functions.FTCommonFunctions.GetFileName ("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel (MasterDataView.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If

    End Sub

    Private Sub FrmRptTashim_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Not MasterDataView Is Nothing Then
            MasterDataView.Done()
            MasterDataView = Nothing
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim FDate As String
        Dim TDate As String

        '//Validation
        If Val(dcbTashimPattern.SelectedValue) <= 0 Then
            NetSql.Common.CSystem.MsgBox("الگوي تسهيم انتخاب نشده است!", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If


        If RdoCurYear.Checked Then
            FDate = gHesabdariSalFDate
            TDate = gHesabdariSalTDate
        Else
            FDate = dclFdate.Value
            TDate = dclTdate.Value
        End If

        If RdoByDate.Checked AndAlso (FDate < gHesabdariSalFDate Or FDate > gHesabdariSalTDate) Then
            NetSql.Common.CSystem.MsgBox("تاريخ شروع خارج از سال مالي انتخاب شده مي باشد", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If RdoByDate.Checked AndAlso (TDate < gHesabdariSalFDate Or TDate > gHesabdariSalTDate) Then
            NetSql.Common.CSystem.MsgBox("تاريخ پايان خارج از سال مالي انتخاب شده مي باشد", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        '//Validation

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        MasterDataView.DataSource = _
            cn.ExecuteQuery( _
                             "_abSpr_Tashim " + CStr(gVahedeTejariSN) + ",'" + Trim(FDate) + "','" + Trim(TDate) + _
                             "'," + CStr(dcbTashimPattern.SelectedValue))
        MasterDataView.Refresh()
        Me.Cursor = System.Windows.Forms.Cursors.Default()

        btnShowHideCols.Enabled = True
        btnExcel.Enabled = True

    End Sub

    Private Sub btnShowHideCols_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnShowHideCols.Click
        Minoo.Grid.ShowFormSelectCols (MasterDataView, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer, Me.Name, Me)
    End Sub

    Private Sub RdoByDate_CheckedChanged (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RdoByDate.CheckedChanged

        lblFDate.Visible = RdoByDate.Checked
        lblTDate.Visible = RdoByDate.Checked

        txtFromDate.Visible = RdoByDate.Checked
        txtToDate.Visible = RdoByDate.Checked

    End Sub
End Class
