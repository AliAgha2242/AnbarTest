Option Strict Off
Option Explicit On

Imports Anbar.BRL

Friend Class FrmRptQCIntervals
    Inherits JanusSimpleReport.frmRptJanusBase

#Region " Windows Form Designer generated code "

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTamin As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbLastNoeTarakoneshKala As cmpCheckedComboBox
    Friend WithEvents CmbTamin As cmpCheckedComboBox
    Friend WithEvents CmbMahsul As cmpCheckedComboBox
    Friend WithEvents AzTarikh As System.Windows.Forms.TextBox
    Friend WithEvents CmbAnbar As cmpCheckedComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtEnDate As System.Windows.Forms.TextBox
    Public WithEvents TxtFaDate As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbMahsul_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbTamin_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbLastNoeTarakoneshKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbAnbar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptQCIntervals))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTamin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbMahsul = New cmpCheckedComboBox(Me.components)
        Me.CmbTamin = New cmpCheckedComboBox(Me.components)
        Me.CmbLastNoeTarakoneshKala = New cmpCheckedComboBox(Me.components)
        Me.AzTarikh = New System.Windows.Forms.TextBox()
        Me.CmbAnbar = New cmpCheckedComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEnDate = New System.Windows.Forms.TextBox()
        Me.TxtFaDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.TxtEnDate)
        Me.pnlF.Controls.Add(Me.CmbAnbar)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.TxtFaDate)
        Me.pnlF.Controls.Add(Me.CmbMahsul)
        Me.pnlF.Controls.Add(Me.CmbLastNoeTarakoneshKala)
        Me.pnlF.Controls.Add(Me.AzTarikh)
        Me.pnlF.Controls.Add(Me.CmbTamin)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Controls.Add(Me.lblTamin)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Size = New System.Drawing.Size(1164, 124)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.lblTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.AzTarikh, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbLastNoeTarakoneshKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbMahsul, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtFaDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbAnbar, 0)
        Me.pnlF.Controls.SetChildIndex(Me.TxtEnDate, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(8, 74)
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 124)
        Me.pnlGrid.Size = New System.Drawing.Size(1164, 331)
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GridEX1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridEX1.GroupTotalRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEX1.Size = New System.Drawing.Size(1164, 331)
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
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(96, 74)
        Me.btnChart.Visible = True
        '
        'pnlDownJanus
        '
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 455)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1164, 36)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(1019, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "کالا:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTamin
        '
        Me.lblTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTamin.Location = New System.Drawing.Point(1019, 51)
        Me.lblTamin.Name = "lblTamin"
        Me.lblTamin.Size = New System.Drawing.Size(140, 19)
        Me.lblTamin.TabIndex = 152
        Me.lblTamin.Text = "تامين کننده :"
        Me.lblTamin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(1019, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 19)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "وضعیت کنترل کیفیت :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbMahsul
        '
        Me.CmbMahsul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbMahsul_DesignTimeLayout.LayoutString = resources.GetString("CmbMahsul_DesignTimeLayout.LayoutString")
        Me.CmbMahsul.DesignTimeLayout = CmbMahsul_DesignTimeLayout
        Me.CmbMahsul.LateBinding = True
        Me.CmbMahsul.LateBindingTop = "100"
        Me.CmbMahsul.Location = New System.Drawing.Point(727, 78)
        Me.CmbMahsul.Name = "CmbMahsul"
        Me.CmbMahsul.SaveSettings = False
        Me.CmbMahsul.ShowSelectAll = True
        Me.CmbMahsul.Size = New System.Drawing.Size(293, 21)
        Me.CmbMahsul.TabIndex = 168
        Me.CmbMahsul.ValuesDataMember = Nothing
        Me.CmbMahsul.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbTamin
        '
        Me.CmbTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbTamin_DesignTimeLayout.LayoutString = resources.GetString("CmbTamin_DesignTimeLayout.LayoutString")
        Me.CmbTamin.DesignTimeLayout = CmbTamin_DesignTimeLayout
        Me.CmbTamin.LateBinding = True
        Me.CmbTamin.LateBindingTop = "100"
        Me.CmbTamin.Location = New System.Drawing.Point(727, 54)
        Me.CmbTamin.Name = "CmbTamin"
        Me.CmbTamin.SaveSettings = False
        Me.CmbTamin.ShowSelectAll = True
        Me.CmbTamin.Size = New System.Drawing.Size(293, 21)
        Me.CmbTamin.TabIndex = 169
        Me.CmbTamin.ValuesDataMember = Nothing
        Me.CmbTamin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CmbLastNoeTarakoneshKala
        '
        Me.CmbLastNoeTarakoneshKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbLastNoeTarakoneshKala_DesignTimeLayout.LayoutString = resources.GetString("CmbLastNoeTarakoneshKala_DesignTimeLayout.LayoutString")
        Me.CmbLastNoeTarakoneshKala.DesignTimeLayout = CmbLastNoeTarakoneshKala_DesignTimeLayout
        Me.CmbLastNoeTarakoneshKala.LateBinding = True
        Me.CmbLastNoeTarakoneshKala.LateBindingTop = "100"
        Me.CmbLastNoeTarakoneshKala.Location = New System.Drawing.Point(727, 30)
        Me.CmbLastNoeTarakoneshKala.Name = "CmbLastNoeTarakoneshKala"
        Me.CmbLastNoeTarakoneshKala.SaveSettings = False
        Me.CmbLastNoeTarakoneshKala.ShowSelectAll = True
        Me.CmbLastNoeTarakoneshKala.Size = New System.Drawing.Size(293, 21)
        Me.CmbLastNoeTarakoneshKala.TabIndex = 170
        Me.CmbLastNoeTarakoneshKala.ValuesDataMember = Nothing
        Me.CmbLastNoeTarakoneshKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'AzTarikh
        '
        Me.AzTarikh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AzTarikh.Location = New System.Drawing.Point(12, 12)
        Me.AzTarikh.Name = "AzTarikh"
        Me.AzTarikh.Size = New System.Drawing.Size(19, 21)
        Me.AzTarikh.TabIndex = 154
        Me.AzTarikh.Visible = False
        '
        'CmbSanadAnbar
        '
        Me.CmbAnbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbAnbar_DesignTimeLayout.LayoutString = resources.GetString("CmbAnbar_DesignTimeLayout.LayoutString")
        Me.CmbAnbar.DesignTimeLayout = CmbAnbar_DesignTimeLayout
        Me.CmbAnbar.LateBinding = True
        Me.CmbAnbar.LateBindingTop = "100"
        Me.CmbAnbar.Location = New System.Drawing.Point(727, 7)
        Me.CmbAnbar.Name = "CmbSanadAnbar"
        Me.CmbAnbar.SaveSettings = False
        Me.CmbAnbar.ShowSelectAll = True
        Me.CmbAnbar.Size = New System.Drawing.Size(293, 21)
        Me.CmbAnbar.TabIndex = 175
        Me.CmbAnbar.ValuesDataMember = Nothing
        Me.CmbAnbar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(1019, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "انبار :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEnDate
        '
        Me.TxtEnDate.AcceptsReturn = True
        Me.TxtEnDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEnDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEnDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtEnDate.Location = New System.Drawing.Point(479, 33)
        Me.TxtEnDate.MaxLength = 0
        Me.TxtEnDate.Name = "TxtEnDate"
        Me.TxtEnDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtEnDate.Size = New System.Drawing.Size(80, 21)
        Me.TxtEnDate.TabIndex = 25
        Me.TxtEnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFaDate
        '
        Me.TxtFaDate.AcceptsReturn = True
        Me.TxtFaDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFaDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFaDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFaDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFaDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFaDate.Location = New System.Drawing.Point(479, 9)
        Me.TxtFaDate.MaxLength = 0
        Me.TxtFaDate.Name = "TxtFaDate"
        Me.TxtFaDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFaDate.Size = New System.Drawing.Size(80, 21)
        Me.TxtFaDate.TabIndex = 24
        Me.TxtFaDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(565, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(108, 14)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "از تاریخ ورود به انبار :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(564, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(108, 14)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "تا تاریخ ورود به انبار :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmRptQCIntervals
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1164, 491)
        Me.Name = "FrmRptQCIntervals"
        Me.Text = "گزارش فاصله زمانی کنترل کیفیت"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptQCIntervals
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmRptQCIntervals
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptQCIntervals
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptQCIntervals)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub SetCaptions()
        Try
            With GridEX1
                With .RootTable.Columns


                    With .Add("Taminkonande", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تامین کننده"
                    End With

                    With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "کد کالا"
                    End With
                    With .Add("KalaDs", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "شرح کالا"
                    End With
                    With .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "شماره رهگیری"
                    End With
                    With .Add("Producer", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "سازنده"
                    End With
                    With .Add("LabNo", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "Lab No."
                    End With
                    With .Add("IsNewSource", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "سورس جدید؟"
                    End With
                    With .Add("NoeEngheza", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "نوع انقضاء"
                    End With
                    With .Add("VoroodDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ ورود"
                    End With

                    With .Add("AzmayeshState", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "نتیجه آزمایش"
                    End With

                    With .Add("AzmayeshDate", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "تاریخ آزمایش"
                    End With
                    'With .Add("EnghezaDate", Janus.Windows.GridEX.ColumnType.Text)
                    '    .Caption = "تاریخ انقضاء"
                    '    .CellStyle.BackColor = Color.LightYellow
                    '    .CellStyle.ForeColor = Color.DarkBlue
                    '    .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    'End With

                    With .Add("Intervals", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "مدت آزمایش"
                        .FormatString = "0,0"
                        .CellStyle.BackColor = Color.LightYellow
                        .CellStyle.ForeColor = Color.DarkBlue
                        .CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    End With
                    With .Add("LastState", Janus.Windows.GridEX.ColumnType.Text)
                        .Caption = "وضعیت کنونی"
                    End With

                End With
                GridEX1.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub

    Private dclTDate As NetSql.Components.CDateCtrl
    Private dclFDate As NetSql.Components.CDateCtrl

    Enum diagramFieldType
        Key = 0
        Riali = 1
        Tedadi = 2
        Darsadi = 3
        Ineffect = 4
        none = 5
    End Enum

    Sub SetVaziat()
        For index As Integer = 0 To GridEX1.DataSource.Table.Columns.Count - 1
            GridEX1.DataSource.Table.Columns(index).Namespace = diagramFieldType.none
        Next


    End Sub

    Private Sub FrmRptTafrigheBoodjehForoosh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load


        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = TxtEnDate
        dclTDate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfFullYear

        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = TxtFaDate
        dclFDate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfFullYear


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)

        Dim _vtSql As String = "Select AnbarSN,AnbarDS from abAnbar Where VahedetejariSn=" & gVahedeTejariSN
        With CmbAnbar
            .Bind(cn, _vtSql, "AnbarSN", "AnbarDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With
        Dim _vtlSql As String = "select NoeTarakoneshKalaNO ,NoeTarakoneshKalaDS  from paNoeTarakoneshKala "
        With CmbLastNoeTarakoneshKala
            .Bind(cn, _vtlSql, "NoeTarakoneshKalaNO", "NoeTarakoneshKalaDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        Dim _vtkSql As String = "select distinct pakalaTamin.VahedetejariSN TaminKonandehSN,VahedetejariDS TaminKonandehDS from pakalaTamin" & _
        " inner join paVahedetejari on pakalaTamin.VahedetejariSN=paVahedetejari.VahedetejariSN"
        With CmbTamin
            .Bind(cn, _vtkSql, "TaminKonandehSN", "TaminKonandehDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        Dim _vtmSql As String = "select  KalaSN,KalaNo+'.'+KalaDS KalaDS from pakala"
        With CmbMahsul
            .Bind(cn, _vtmSql, "KalaSN", "KalaDS")
            .Enabled = True
            .ShowSelectAll = True
            .CheckedValues = ArrayLst.ToArray
            .DroppedDown = True
        End With

        AzTarikh.Text = MiladiToShamsi(Today()).Substring(0, 4) + "0101"

        SetCaptions()

    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click

        Dim vErrMsg As String
        Dim vTaminKonandehSN, vNoeTaminSN, vAnbarSN, vKalaSN, vFVoroodDate, vtVoroodDate, vLastNoeTarakoneshKalaNO As String

        vErrMsg = ""

        vFVoroodDate = dclFDate.Value
        vtVoroodDate = dclTDate.Value
        If (vFVoroodDate = "") Then
            vFVoroodDate = gHesabdariSalFDate
            dclFDate.Value = gHesabdariSalFDate
        End If
        If (vtVoroodDate = "") Then
            vtVoroodDate = gHesabdariSalTDate
            dclTDate.Value = gHesabdariSalTDate
        End If





        If Trim(CmbTamin.getStringValues) <> "" Then
            vTaminKonandehSN = CmbTamin.getStringValues
            If vTaminKonandehSN = "0.000" Then
                vTaminKonandehSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "تامین کننده مشخص نشده است"
        End If
        If Trim(CmbAnbar.getStringValues) <> "" Then
            vAnbarSN = CmbAnbar.getStringValues
            If vAnbarSN = "0.000" Then
                vAnbarSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "انبار مشخص نشده است"
        End If

        If Trim(CmbLastNoeTarakoneshKala.getStringValues) <> "" Then
            vLastNoeTarakoneshKalaNO = CmbLastNoeTarakoneshKala.getStringValues
            If vLastNoeTarakoneshKalaNO = "0.000" Then
                vLastNoeTarakoneshKalaNO = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "انبار مشخص نشده است"
        End If

        If Trim(CmbLastNoeTarakoneshKala.getStringValues) <> "" Then
            vNoeTaminSN = CmbLastNoeTarakoneshKala.getStringValues
            If vNoeTaminSN = "0.000" Then
                vNoeTaminSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "نوع تامین کننده مشخص نشده است"
        End If

        If Trim(CmbMahsul.getStringValues) <> "" Then
            vKalaSN = CmbMahsul.getStringValues
            If vKalaSN = "0.000" Then
                vKalaSN = "0"
            End If
        Else
            vErrMsg = vErrMsg & Chr(13) & "محصول مشخص نشده است"
        End If


        If vErrMsg = "" Then
            Me.Cursor = Cursors.WaitCursor
            Dim thisWaitFrm As New Anbar.Common.Frmwait
            thisWaitFrm.Show()
            thisWaitFrm.Refresh()
            Try
                Dim _d As New ClsDataAccessRule
                Dim dv As DataView

                dv = _d.GetQCIntervals(gVahedeTejariSN, vAnbarSN, vTaminKonandehSN, vKalaSN, vFVoroodDate, vtVoroodDate, vLastNoeTarakoneshKalaNO, cn, tp)

                If dv Is Nothing Then
                    'MsgBox("اطلاعات مورد نظر دريافت نشد", MsgBoxStyle.OkOnly, "پيغام")
                    thisWaitFrm.Close()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If


                GridEX1.DataSource = dv

                'SetCaptions()

                SetVaziat()

                RefreshDataSet()

                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default

            Catch ex As Exception
                thisWaitFrm.Close()
                Me.Cursor = Cursors.Default
                Netsql.common.csystem.MsgBox("اشكالي در تهيه ي اين گزارش بوجود آمده است. ", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
            End Try


        Else
            Netsql.common.csystem.MsgBox(vErrMsg, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
    End Sub

    Private Sub CmbTamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim _Anbar As Decimal = CDec(CmbNoeMahsool.Text)
            'Dim _Tamin As Decimal = CDec(CmbTamin.Text)
            'If _Anbar <> 0 Then
            '    Dim _str As String = "SELECT DISTINCT TOP (100) PERCENT dbo.paKala.KalaSN," & _
            '    " dbo.paKala.KalaNo + ' _ ' + dbo.paKala.KalaDs AS KalaNoDs" & _
            '    " FROM         dbo.abAnbarKala RIGHT OUTER JOIN  " & _
            '    " dbo.paKala ON dbo.abAnbarKala.KalaSN = dbo.paKala.KalaSN LEFT OUTER JOIN  " & _
            '    " dbo.paKalaTamin ON dbo.paKala.KalaSN = dbo.paKalaTamin.KalaSN  " & _
            '    " GROUP BY dbo.paKala.KalaSN, dbo.paKala.KalaNo + ' _ ' + dbo.paKala.KalaDs, " & _
            '    " dbo.paKalaTamin.VahedeTejariSN, dbo.abAnbarKala.AnbarSN HAVINg" & _
            '    " (dbo.paKalaTamin.VahedeTejariSN = " & _Tamin & " Or " & _Tamin & "=0)   " & _
            '    " ORDER BY KalaNoDs  "

            '    'Cmbmhsul.Bind(cn, _str, "KalaSN", "KalaNODs").Sort = "KalaSN"

            'End If

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CmbNoeTamin_CheckedValuesChanged(sender As System.Object, e As System.EventArgs) _
        Handles CmbLastNoeTarakoneshKala.CheckedValuesChanged
        Dim ArrayLst As New System.Collections.ArrayList
        ArrayLst.Add(0.0)

        Dim _NoeVahedetejarisn As String = CmbLastNoeTarakoneshKala.getStringValues
        If _NoeVahedetejarisn = "" Or _NoeVahedetejarisn = "0.000" Or _NoeVahedetejarisn = "0" Then
            CmbTamin.Clear()
        Else
            Dim _vtkSql As String = "select NoeTarakoneshKalaNO ,NoeTarakoneshKalaDS  from paNoeTarakoneshKala"
            With CmbTamin
                .Bind(cn, _vtkSql, "NoeTarakoneshKalaNO", "NoeTarakoneshKalaDS")
                .Enabled = True
                .ShowSelectAll = True
                .CheckedValues = ArrayLst.ToArray
                .DroppedDown = True
            End With
        End If
    End Sub

    Private Sub rdoTrakonesh_CheckedChanged(sender As System.Object, e As System.EventArgs)


        'If Rdotarakonesh.Checked = True Then
        '    CmbTarakonesh.Enabled = True
        'Else
        '    CmbTarakonesh.Enabled = False
        'End If

    End Sub

    Private Sub btnEslahEnghezaDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If GridEX1.RowCount <= 0 Then
                NetSql.Common.CSystem.MsgBox("ركوردي جهت انجام عمليات وجود ندارد", MsgBoxStyle.OkOnly, "")
                Exit Sub
            End If
            Dim dgrow As Janus.Windows.GridEX.GridEXRow
            dgrow = GridEX1.GetRow()
            If Not dgrow.Cells("EnghezaDate").Value Is DBNull.Value AndAlso Len(dgrow.Cells("EnghezaDate").Value) = 0 AndAlso dgrow.Cells("EnghezaDate").Value = "//" Then
                If NetSql.Common.CSystem.MsgBox("تاريخ انقضاء وجود دارد ،آيا مايل به ويرايش آن مي باشيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Dim _kalasn As Decimal = dgrow.Cells("KalaSN").Value
            Dim _KalaphizikiSN As String = dgrow.Cells("KalaphizikiSN").Value
            Dim _NewEnghezaDate As String = NetSql.Common.CShamsiDate.FormatDate(TxtFaDate.Text, EnumDateFormat.dfFullYear)
            Dim _OperationType As String


            If _kalasn <> 0 And _KalaphizikiSN <> 0 And Len(_NewEnghezaDate) > 0 Then
                cn.CallSP("_abSpC_UpdateEnghezaDatekalaphiziki", _KalaphizikiSN, _NewEnghezaDate, _OperationType, gSM.UserID_Name, System.Environment.MachineName)
            End If

            btnViewReport_Click(sender, e)

        Catch ex As Exception
            Netsql.common.csystem.MsgBox(ex.Message)

        End Try

    End Sub

    'Private Sub TxtFaDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles TxtFaDate.Validated
    '    Try
    '        If TxtFaDate.Text <> "__/__/__" Then
    '            TxtEnDate.Text = NetSql.Common.CShamsiDate.ShamsiToMiladi(TxtFaDate.Text) 'gFromDate
    '            TxtEnDate.BackColor = Color.White
    '        End If
    '    Catch ex As Exception
    '        TxtEnDate.BackColor = Color.Red
    '    End Try


    'End Sub

    'Private Sub TxtEnDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles TxtEnDate.Validated
    '    Try
    '        If Len(TxtEnDate.Text) = 10 Then
    '            TxtFaDate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi(TxtEnDate.Text, NetSql.Common.CShamsiDate.EnumDateFormat.dfWithSlash) 'gFromDate
    '            TxtFaDate.BackColor = Color.White
    '        End If
    '    Catch ex As Exception
    '        TxtFaDate.BackColor = Color.Red
    '    End Try

    'End Sub



End Class
