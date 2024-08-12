Imports Anbar.BRL
Public Class FrmZayeatKartablReport
    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6formdefinstance As FrmZayeatKartablReport
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtToDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents TxtFromDate As NetSql.Components.cmpFarsiDatePicker
    Friend WithEvents CmbSanadAnbar As cmpCheckedComboBox
    Friend WithEvents CmbMahsool As cmpCheckedComboBox
    Friend WithEvents CmbZayeatDarkhast As cmpCheckedComboBox
    Friend WithEvents CmbTamin As cmpCheckedComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbRavandErja As RadioButton
    Friend WithEvents RdbGardeshAsnad As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents CmpShobe As cmpCheckedComboBox
    Private components As System.ComponentModel.IContainer

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

    Public Shared Property DefInstance() As FrmZayeatKartablReport

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmZayeatKartablReport
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmZayeatKartablReport)
            m_vb6formdefinstance = Value

        End Set

    End Property


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbSanadAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbMahsool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbZayeatDarkhast_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmpShobe_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmZayeatKartablReport))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtToDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.TxtFromDate = New NetSql.Components.cmpFarsiDatePicker()
        Me.CmbSanadAnbar = New cmpCheckedComboBox(Me.components)
        Me.CmbMahsool = New cmpCheckedComboBox(Me.components)
        Me.CmbZayeatDarkhast = New cmpCheckedComboBox(Me.components)
        Me.CmbTamin = New cmpCheckedComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbRavandErja = New System.Windows.Forms.RadioButton()
        Me.RdbGardeshAsnad = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmpShobe = New cmpCheckedComboBox(Me.components)
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label7)
        Me.pnlF.Controls.Add(Me.CmpShobe)
        Me.pnlF.Controls.Add(Me.GroupBox1)
        Me.pnlF.Controls.Add(Me.Label6)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.CmbSanadAnbar)
        Me.pnlF.Controls.Add(Me.CmbMahsool)
        Me.pnlF.Controls.Add(Me.CmbZayeatDarkhast)
        Me.pnlF.Controls.Add(Me.CmbTamin)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.TxtToDate)
        Me.pnlF.Controls.Add(Me.TxtFromDate)
        Me.pnlF.Size = New System.Drawing.Size(1134, 135)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtFromDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtToDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbZayeatDarkhast, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsool, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbSanadAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label6, 0)
        Me.pnlF.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmpShobe, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label7, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 135)
        Me.pnlGrid.Size = New System.Drawing.Size(1134, 304)
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
        Me.GridEX1.Size = New System.Drawing.Size(1134, 304)
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
        Me.pnlDownJanus.Size = New System.Drawing.Size(1134, 36)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1079, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "تا تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1078, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "از تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtToDate
        '
        Me.TxtToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtToDate.Location = New System.Drawing.Point(975, 29)
        Me.TxtToDate.Mask = "9900/90/90"
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 177
        Me.TxtToDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'TxtFromDate
        '
        Me.TxtFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFromDate.Location = New System.Drawing.Point(975, 3)
        Me.TxtFromDate.Mask = "9900/90/90"
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.SelectedDateTimeShamsi = "    /  /"
        Me.TxtFromDate.Size = New System.Drawing.Size(95, 20)
        Me.TxtFromDate.TabIndex = 176
        Me.TxtFromDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003
        '
        'CmbSanadAnbar
        '
        Me.CmbSanadAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbSanadAnbar_DesignTimeLayout.LayoutString = resources.GetString("CmbSanadAnbar_DesignTimeLayout.LayoutString")
        Me.CmbSanadAnbar.DesignTimeLayout = CmbSanadAnbar_DesignTimeLayout
        Me.CmbSanadAnbar.LateBinding = True
        Me.CmbSanadAnbar.LateBindingTop = "100"
        Me.CmbSanadAnbar.Location = New System.Drawing.Point(226, 27)
        Me.CmbSanadAnbar.Name = "CmbSanadAnbar"
        Me.CmbSanadAnbar.SaveSettings = False
        Me.CmbSanadAnbar.ShowSelectAll = True
        Me.CmbSanadAnbar.Size = New System.Drawing.Size(590, 21)
        Me.CmbSanadAnbar.TabIndex = 183
        Me.CmbSanadAnbar.ValuesDataMember = Nothing
        Me.CmbSanadAnbar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbMahsool
        '
        Me.CmbMahsool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbMahsool_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsool_DesignTimeLayout.LayoutString")
        Me.CmbMahsool.DesignTimeLayout = CmbMahsool_DesignTimeLayout
        Me.CmbMahsool.LateBinding = True
        Me.CmbMahsool.LateBindingTop = "100"
        Me.CmbMahsool.Location = New System.Drawing.Point(226, 97)
        Me.CmbMahsool.Name = "CmbMahsool"
        Me.CmbMahsool.SaveSettings = False
        Me.CmbMahsool.ShowSelectAll = True
        Me.CmbMahsool.Size = New System.Drawing.Size(590, 21)
        Me.CmbMahsool.TabIndex = 180
        Me.CmbMahsool.ValuesDataMember = Nothing
        Me.CmbMahsool.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbZayeatDarkhast
        '
        Me.CmbZayeatDarkhast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbZayeatDarkhast_DesignTimeLayout.LayoutString = resources.GetString("CmbZayeatDarkhast_DesignTimeLayout.LayoutString")
        Me.CmbZayeatDarkhast.DesignTimeLayout = CmbZayeatDarkhast_DesignTimeLayout
        Me.CmbZayeatDarkhast.LateBinding = True
        Me.CmbZayeatDarkhast.LateBindingTop = "100"
        Me.CmbZayeatDarkhast.Location = New System.Drawing.Point(226, 50)
        Me.CmbZayeatDarkhast.Name = "CmbZayeatDarkhast"
        Me.CmbZayeatDarkhast.SaveSettings = False
        Me.CmbZayeatDarkhast.ShowSelectAll = True
        Me.CmbZayeatDarkhast.Size = New System.Drawing.Size(590, 21)
        Me.CmbZayeatDarkhast.TabIndex = 182
        Me.CmbZayeatDarkhast.ValuesDataMember = Nothing
        Me.CmbZayeatDarkhast.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbTamin
        '
        Me.CmbTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTamin_DesignTimeLayout.LayoutString = resources.GetString("CmbTamin_DesignTimeLayout.LayoutString")
        Me.CmbTamin.DesignTimeLayout = CmbTamin_DesignTimeLayout
        Me.CmbTamin.LateBinding = True
        Me.CmbTamin.LateBindingTop = "100"
        Me.CmbTamin.Location = New System.Drawing.Point(226, 74)
        Me.CmbTamin.Name = "CmbTamin"
        Me.CmbTamin.SaveSettings = False
        Me.CmbTamin.ShowSelectAll = True
        Me.CmbTamin.Size = New System.Drawing.Size(590, 21)
        Me.CmbTamin.TabIndex = 181
        Me.CmbTamin.ValuesDataMember = Nothing
        Me.CmbTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(821, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = " سند انبار : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(822, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "محصول :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(819, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "تامین کننده : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(820, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "شماره درخواست ضایعات : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RdbRavandErja)
        Me.GroupBox1.Controls.Add(Me.RdbGardeshAsnad)
        Me.GroupBox1.Location = New System.Drawing.Point(970, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 75)
        Me.GroupBox1.TabIndex = 188
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نوع گزارش"
        '
        'RdbRavandErja
        '
        Me.RdbRavandErja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdbRavandErja.AutoSize = True
        Me.RdbRavandErja.Location = New System.Drawing.Point(60, 47)
        Me.RdbRavandErja.Name = "RdbRavandErja"
        Me.RdbRavandErja.Size = New System.Drawing.Size(82, 17)
        Me.RdbRavandErja.TabIndex = 1
        Me.RdbRavandErja.TabStop = True
        Me.RdbRavandErja.Text = "روند ارجاعات"
        Me.RdbRavandErja.UseVisualStyleBackColor = True
        '
        'RdbGardeshAsnad
        '
        Me.RdbGardeshAsnad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RdbGardeshAsnad.AutoSize = True
        Me.RdbGardeshAsnad.Checked = True
        Me.RdbGardeshAsnad.Location = New System.Drawing.Point(60, 20)
        Me.RdbGardeshAsnad.Name = "RdbGardeshAsnad"
        Me.RdbGardeshAsnad.Size = New System.Drawing.Size(82, 17)
        Me.RdbGardeshAsnad.TabIndex = 0
        Me.RdbGardeshAsnad.TabStop = True
        Me.RdbGardeshAsnad.Text = "گردش اسناد"
        Me.RdbGardeshAsnad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(821, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "شعبه : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmpShobe
        '
        Me.CmpShobe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmpShobe_DesignTimeLayout.LayoutString = resources.GetString("CmpShobe_DesignTimeLayout.LayoutString")
        Me.CmpShobe.DesignTimeLayout = CmpShobe_DesignTimeLayout
        Me.CmpShobe.LateBinding = True
        Me.CmpShobe.LateBindingTop = "100"
        Me.CmpShobe.Location = New System.Drawing.Point(226, 3)
        Me.CmpShobe.Name = "CmpShobe"
        Me.CmpShobe.SaveSettings = False
        Me.CmpShobe.ShowSelectAll = True
        Me.CmpShobe.Size = New System.Drawing.Size(590, 21)
        Me.CmpShobe.TabIndex = 189
        Me.CmpShobe.ValuesDataMember = Nothing
        Me.CmpShobe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'FrmZayeatKartablReport
        '
        Me.ClientSize = New System.Drawing.Size(1134, 475)
        Me.Name = "FrmZayeatKartablReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش اسناد ضایعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub FrmZayeatKartablReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtFromDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear).Substring(0, 4) + "0101"
        TxtToDate.Text = MiladiToShamsi(Today(), EnumDateFormat.dfFullYear)

        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")

        If gVahedeTejariSN = 1.935 Or gVahedeTejariSN = 9.935 Then
            CmpShobe.Bind(cn, "select distinct abSanad.VahedeTejariSN,VahedeTejariDs from abZayeatGardesh " &
                            "join abSanad on abSanad.SanadSN=abZayeatGardesh.SanadSN " &
                            "Join paVahedeTejari on paVahedeTejari.VahedeTejariSN=abSanad.VahedeTejariSN ", "ZayeatGardeshSN", "ZayeatGardeshDS")
        Else
            CmpShobe.Visible = False
            Label7.Visible = False
        End If

        CmbSanadAnbar.Bind(cn, "select ZayeatGardeshSN,Cast(SanadNO as varchar)+' ('+AnbarDs+')' ZayeatGardeshDS from abZayeatGardesh " &
                        "Join abSanad on abSanad.RezSN4=abZayeatGardesh.ZayeatGardeshSN " &
                        "Join abAnbar on abAnbar.AnbarSN=abSanad.AnbarSN " &
                        "where SanadDate between '" & Fdate & "' and '" & Tdate & "'", "ZayeatGardeshSN", "ZayeatGardeshDS")

        CmbZayeatDarkhast.Bind(cn, "select ZayeatGardeshSN,Cast(ZayeatGardeshNo as varchar)+'('+VahedeTejariDs+')' ZayeatGardeshDS from abZayeatGardesh " &
                "Join abSanad on abSanad.SanadSN=abZayeatGardesh.SanadSN " &
                "Join paVahedeTejari on paVahedeTejari.VahedeTejariSN=absanad.VahedeTejariSN " &
                "where SanadDate between '" & Fdate & "' and '" & Tdate & "'", "ZayeatGardeshSN", "ZayeatGardeshDS")

        CmbTamin.Bind(cn, "Select TaminVahedeTejariSN,TaminVahedeTejariNo+'. '+TaminVahedeTejariDs As TaminVahedeTejariDs from paVW_TaminKonandeh", "TaminVahedeTejariSN", "TaminVahedeTejariDs")

        CmbMahsool.Bind(cn, "Select KalaSN,KalaNo+'. ' + KalaDs as KalaDS from paVw_paKalaTaminFull", "KalaSN", "KalaDS")

    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Dim ZayeatGardeshSN As String = ""
        Dim TaminKonandeSn As String = ""
        Dim ShobeSN As String = ""
        Dim KalaSN As String = ""
        Dim reportType As Short

        'If CmbZayeatDarkhast.getStringValues Is Nothing Then
        '    MsgBox("شماره درخواست انتخاب نشده است", MsgBoxStyle.Critical, "")
        '    Exit Sub
        'End If

        'If CmbSanadAnbar.getStringValues Is Nothing Then
        '    MsgBox("شماره سند انبار انتخاب نشده است", MsgBoxStyle.Critical, "")
        '    Exit Sub
        'End If

        'If CmbTamin.getStringValues Is Nothing Then
        '    MsgBox("تامین کننده انتخاب نشده است", MsgBoxStyle.Critical, "")
        '    Exit Sub
        'End If

        'If CmbMahsool.getStringValues Is Nothing Then
        '    MsgBox("محصول انتخاب نشده است", MsgBoxStyle.Critical, "")
        '    Exit Sub
        'End If




        If Not (CmbZayeatDarkhast.getStringValues Is Nothing OrElse CmbZayeatDarkhast.getStringValues = "0" OrElse CmbZayeatDarkhast.getStringValues = "0.000") Then
            ZayeatGardeshSN += CmbZayeatDarkhast.getStringValues
        End If

        If Not (CmbSanadAnbar.getStringValues Is Nothing OrElse CmbSanadAnbar.getStringValues = "0" OrElse CmbSanadAnbar.getStringValues = "0.000") Then
            ZayeatGardeshSN += CmbSanadAnbar.getStringValues
        End If

        If ZayeatGardeshSN.EndsWith(",") Then
            ZayeatGardeshSN = ZayeatGardeshSN.Substring(0, ZayeatGardeshSN.Length - 1)
        End If

        If CmbTamin.getStringValues Is Nothing OrElse CmbTamin.getStringValues = "0" OrElse CmbTamin.getStringValues = "0.000" Then
            TaminKonandeSn = ""
        Else
            TaminKonandeSn = CmbTamin.getStringValues
        End If

        If CmbMahsool.getStringValues Is Nothing OrElse CmbMahsool.getStringValues = "0" OrElse CmbMahsool.getStringValues = "0.000" Then
            KalaSN = ""
        Else
            KalaSN = CmbMahsool.getStringValues
        End If


        If gVahedeTejariSN = 1.935 Or gVahedeTejariSN = 9.935 Then
            If CmpShobe.getStringValues Is Nothing OrElse CmpShobe.getStringValues = "0" OrElse CmpShobe.getStringValues = "0.000" Then
                ShobeSN = ""
            Else
                ShobeSN = CmpShobe.getStringValues
            End If
        Else
            ShobeSN = gVahedeTejariSN.ToString
        End If


        If RdbGardeshAsnad.Checked Then
            reportType = 1
        ElseIf RdbRavandErja.Checked Then
            reportType = 2

        End If


        Dim Fdate, Tdate As String
        Fdate = TxtFromDate.Text.Replace("/", "")
        Tdate = TxtToDate.Text.Replace("/", "")


        Dim AnbarRule As New ClsDataAccessRule
        Dim DvReport As New DataView
        Try
            DvReport = AnbarRule.KartablZayeat_GetReport(ShobeSN, Fdate, Tdate, ZayeatGardeshSN, TaminKonandeSn, KalaSN, reportType, cn)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        GridEX1.DataSource = DvReport
        GridEX1.RetrieveStructure()

        For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            If col.Key.Contains(".") Then
                col.FormatString = "#,###"
                col.TotalFormatString = "#,###"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            ElseIf col.Key.Contains("..") Then
                col.FormatString = "#,###.##"
                col.TotalFormatString = "#,###.##"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            End If
        Next

        GridEX1.AutoSizeColumns()


    End Sub

    Private Sub CmbTamin_CheckedValuesChanged(sender As Object, e As EventArgs) Handles CmbTamin.CheckedValuesChanged
        If CmbTamin.getStringValues Is Nothing Then
            Exit Sub
        End If
        If CmbTamin.getStringValues = "0.000" Or CmbTamin.getStringValues = "0" Then
            CmbMahsool.Bind(cn, "Select KalaSN,KalaNo+'. ' + KalaDs as KalaDS from paVw_paKalaTaminFull", "KalaSN", "KalaDS")
        Else
            CmbMahsool.Bind(cn, "Select KalaSN,KalaNo+'. ' + KalaDs as KalaDS from paVw_paKalaTaminFull Where TaminVahedeTejariSN In (" & CmbTamin.getStringValues & ")", "KalaSN", "KalaDS")
        End If
    End Sub
End Class
