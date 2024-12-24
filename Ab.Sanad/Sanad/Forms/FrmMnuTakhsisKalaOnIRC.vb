

' OK
'Author ::نوشین علیپور و علی اصغر توکلی
'CreateDate :: 14030917
'ModifiedDate:: 14031001
'Description:: تخصیص کالا به بارکد
'System ::انبار


Imports Janus.Windows.GridEX
Imports Anbar.BRL
Imports Janus.Windows.GridEX.Export

Public Class FrmTakhsisKalaOnIRC
    Inherits Minoo.Base.FTBaseForm
    Private components As System.ComponentModel.IContainer
    Private Shared m_vb6formdefinstance As FrmTakhsisKalaOnIRC
    Private Shared m_initializingdefinstance As Boolean
    Private WithEvents dataView As CDataView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPageScanRecords As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridBarcodeMaster As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    '------------------------------------------------------------------------------
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents PanelDetailCom As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDetailNav As Panel

    Public Sub New()
        MyBase.New()

        InitializeComponent()
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

    Public Shared Property DefInstance() As FrmTakhsisKalaOnIRC

        Get

            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmTakhsisKalaOnIRC
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance

        End Get

        Set(ByVal Value As FrmTakhsisKalaOnIRC)
            m_vb6formdefinstance = Value

        End Set

    End Property

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridBarcodeMaster_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTakhsisKalaOnIRC))
        Dim GridBarcodeDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelDetailCom = New System.Windows.Forms.Panel()
        Me.PanelDetailNav = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageScanRecords = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridBarcodeMaster = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageScanRecords.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDetailCom
        '
        Me.PanelDetailCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailCom.Location = New System.Drawing.Point(1140, 160)
        Me.PanelDetailCom.Name = "PanelDetailCom"
        Me.PanelDetailCom.Size = New System.Drawing.Size(214, 40)
        Me.PanelDetailCom.TabIndex = 3
        '
        'PanelDetailNav
        '
        Me.PanelDetailNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailNav.Location = New System.Drawing.Point(0, 158)
        Me.PanelDetailNav.Name = "PanelDetailNav"
        Me.PanelDetailNav.Size = New System.Drawing.Size(214, 38)
        Me.PanelDetailNav.TabIndex = 2
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.Location = New System.Drawing.Point(3, 4)
        Me.PanelDetail.MaximumSize = New System.Drawing.Size(2000, 275)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(1354, 153)
        Me.PanelDetail.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1368, 65)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(200, Byte))
        Me.Label1.Location = New System.Drawing.Point(669, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 34)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "کاربر گرامی" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "لطفا توجه داشته باشید مهلت ویرایش کالای ثبت شده یک روز می باشد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageScanRecords)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1368, 569)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageScanRecords
        '
        Me.TabPageScanRecords.Controls.Add(Me.SplitContainer1)
        Me.TabPageScanRecords.Location = New System.Drawing.Point(4, 23)
        Me.TabPageScanRecords.Name = "TabPageScanRecords"
        Me.TabPageScanRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageScanRecords.Size = New System.Drawing.Size(1360, 542)
        Me.TabPageScanRecords.TabIndex = 1
        Me.TabPageScanRecords.Text = "تخصیص کالا به بارکد "
        Me.TabPageScanRecords.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1354, 536)
        Me.SplitContainer1.SplitterDistance = 339
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GridBarcodeMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(2000, 800)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 339)
        Me.Panel1.TabIndex = 0
        '
        'GridBarcodeMaster
        '
        GridBarcodeMaster_DesignTimeLayout.LayoutString = resources.GetString("GridBarcodeMaster_DesignTimeLayout.LayoutString")
        Me.GridBarcodeMaster.DesignTimeLayout = GridBarcodeMaster_DesignTimeLayout
        Me.GridBarcodeMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcodeMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridBarcodeMaster.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridBarcodeMaster.FlatBorderColor = System.Drawing.SystemColors.WindowText
        Me.GridBarcodeMaster.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridBarcodeMaster.GroupByBoxVisible = False
        Me.GridBarcodeMaster.Location = New System.Drawing.Point(0, 0)
        Me.GridBarcodeMaster.MaximumSize = New System.Drawing.Size(0, 500)
        Me.GridBarcodeMaster.Name = "GridBarcodeMaster"
        Me.GridBarcodeMaster.RecordNavigator = True
        Me.GridBarcodeMaster.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcodeMaster.SelectedFormatStyle.BackColor = System.Drawing.Color.Bisque
        Me.GridBarcodeMaster.Size = New System.Drawing.Size(1354, 339)
        Me.GridBarcodeMaster.TabIndex = 14
        Me.GridBarcodeMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.PanelDetailCom)
        Me.Panel2.Controls.Add(Me.PanelDetailNav)
        Me.Panel2.Controls.Add(Me.PanelDetail)
        Me.Panel2.Controls.Add(Me.TabControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(2000, 600)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1354, 193)
        Me.Panel2.TabIndex = 1
        '
        'TabControl3
        '
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.RightToLeftLayout = True
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1354, 193)
        Me.TabControl3.TabIndex = 3

        '
        'FrmTakhsisKalaOnIRC
        '
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1368, 634)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmTakhsisKalaOnIRC"
        Me.Text = "تخصیص محصول به ثبت های بارکدخوان"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageScanRecords.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridBarcodeMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Dim abRule As New ClsDataAccessRule
    Dim DSCatalogue As New DataView
    Dim DvSourceKala As DataView
    Dim DvSourceDarkhast As DataView
    Dim DvSourceDarkhastHa As DataView
    Dim DvSourceFactor As DataView
    Dim DvSourceFactorHa As DataView
    Public TarakoneshMojaz As String = ""
    Public IsAnbarGardaniActive As Boolean = False
    Public IsSabtResidActive As Boolean = True
    Public NoControlBatchFactorAndMarjooei As Boolean = True
    Dim DtTableBeforeChange As New DataTable
    Public WithEvents DVDetail As CDataView


    Private Sub FrmTakhsisKalaOnIRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each colf As Janus.Windows.GridEX.GridEXColumn In GridBarcodeMaster.RootTable.Columns
            colf.HeaderAlignment = TextAlignment.Center
            colf.TextAlignment = TextAlignment.Center
        Next

        Call BtnRefreshData_Click(sender, e)
    End Sub
    Private Sub BtnRefreshData_Click(sender As Object, e As EventArgs)


        Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(gVahedeTejariSN, gSM.ApplicationID)


        Dim wfrm As New Anbar.Common.Frmwait
        wfrm.Show()
        Try


            wfrm.Label3.Text = "...سیستم در حال بروزرسانی آخرین اطلاعات می باشد..."
            wfrm.Refresh()


            Try
                CInitDetailDataView()
                Dim Test As DataView = abRule.GetBarcodeThatsNotHaveProduct(cn)

                DSCatalogue = Test
                DSCatalogue.AllowEdit = False

                If Not DSCatalogue Is Nothing Then

                    Dim a As DataGridView = New DataGridView()
                    GridBarcodeMaster.DataSource = DSCatalogue
                    GridBarcodeMaster.Refresh()
                    GridBarcodeMaster.AutoSizeColumns()
                    GridBarcodeMaster.FilterMode = FilterMode.None

                    GridBarcodeMaster.AllowAddNew = InheritableBoolean.False
                    GridBarcodeMaster.AllowEdit = InheritableBoolean.False
                    GridBarcodeMaster.AllowDelete = InheritableBoolean.False
                Else
                    Exit Sub

                End If
            Catch ex As Exception
                CSystem.MsgBox(ex.Message, MsgBoxStyle.Critical, "خطا!")
            End Try


            GridBarcodeMaster.AutoSizeColumns()



        Catch ex As Exception
        Finally
            wfrm.Close()
        End Try


    End Sub
    Private Sub GridBarcodeMaster_DoubleClick(sender As Object, e As EventArgs) Handles GridBarcodeMaster.DoubleClick
        GridBarcodeMaster.AutoSizeColumns()
    End Sub
    Private Sub GridBarcodeMaster_SelectionChanged(sender As Object, e As EventArgs) Handles GridBarcodeMaster.SelectionChanged
        Dim SqlWhere As String = "ProductCatalogueSn = "
        Dim productcatalogueSn As Decimal = CDec(GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value)
        If productcatalogueSn = 0 Then
            MsgBox("رکوردی انتخاب نشد", MsgBoxStyle.OkOnly)
        End If
        SqlWhere = String.Concat(SqlWhere, productcatalogueSn.ToString())
        DVDetail.SQLWhere = SqlWhere
        DVDetail.Refresh()
        If DVDetail.DataRows > 0 Then
            DVDetail.CommandEnabled(EnumCommands.cmAdd) = False
        Else
            DVDetail.CommandEnabled(EnumCommands.cmAdd) = True
        End If
    End Sub


    Private Sub CInitDetailDataView()
        DVDetail = New CDataView(cn)
        With DVDetail
            .TableName = "abProductCatalogueKalaIRC"
            .Init(PanelDetail,, PanelDetailCom, PanelDetailNav, EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdInsert _
                  Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdUpdate)
            .AddJoin("abProductCatalogueKalaIRC", EnumTableJoin.tjInnerJoin, "paKala", "KalaSN", "KalaSN")
            .SQLWhere = "productCatalogueSn = 0"
            .EditInGrid = True
            With .Fields
                With .Add("ProductCatalogueNewIRCSN", "", gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With

                With .Add("ProductCatalogueSN", "", EnumFieldOptions.foHidden)
                End With

                With .Add("KalaSN->{paKala.KalaNO + ' _ ' + paKala.KalaDS} AS KalaSN", "DataCombo")
                    .Caption = "نام کالا"
                    .ComboWhereCondition = "Kalasn in (select kalasn from pakala where len(isnull(paKala.IRC,''))>10 And len(isnull(paKala.GTIN,''))>10 )"
                    .RefreshCombo()
                    .ComboLateBinding = True
                End With
                With .Add("abProductCatalogueKalaIRC.NewIRC")
                    .Caption = "جدیدIRC"
                    .ReadOnly = True
                End With
                With .Add("abProductCatalogueKalaIRC.NewGTIN")
                    .Caption = "جدیدGTIN"
                    .ReadOnly = True
                End With

            End With
            .Refresh()
        End With
    End Sub
    Private Sub DVDetail_AfterCommandClick(aCommand As EnumCommands) Handles DVDetail.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd

                DVDetail.Fields("NewIRC").Value = GridBarcodeMaster.CurrentRow.Cells("IRC").Value
                DVDetail.Fields("NewGTIN").Value = GridBarcodeMaster.CurrentRow.Cells("GTIN").Value
                DVDetail.Fields("ProductCatalogueSN").Value = GridBarcodeMaster.CurrentRow.Cells("ProductCatalogueSN").Value
        End Select
    End Sub
End Class
