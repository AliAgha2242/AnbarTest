Imports Anbar.BRL

Public Class FrmUIDtrackingReport
    Inherits JanusSimpleReport.frmRptJanusBase

    Private Shared m_vb6formdefinstance As FrmUIDtrackingReport
    Private Shared m_initializingdefinstance As Boolean
    Public WithEvents CmbTamin As NetSql.Components.DataCombo
    Public WithEvents Label1 As Label
    Public WithEvents cmbKala As NetSql.Components.DataCombo
    Public WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbUID As cmpCheckedComboBox
    Public WithEvents Label3 As Label
    Public WithEvents CmbBatchCode As NetSql.Components.DataCombo
    Public WithEvents Label4 As Label
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

    Public Shared Property DefInstance() As FrmUIDtrackingReport
        Get
            If m_vb6formdefinstance Is Nothing OrElse m_vb6formdefinstance.IsDisposed Then
                m_initializingdefinstance = True
                m_vb6formdefinstance = New FrmUIDtrackingReport
                m_initializingdefinstance = False
            End If
            DefInstance = m_vb6formdefinstance
        End Get
        Set(ByVal Value As FrmUIDtrackingReport)
            m_vb6formdefinstance = Value
        End Set
    End Property
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CmbUID_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUIDtrackingReport))
        Me.cmbKala = New NetSql.Components.DataCombo(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbTamin = New NetSql.Components.DataCombo(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbUID = New cmpCheckedComboBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBatchCode = New NetSql.Components.DataCombo(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlF.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlCommand.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownJanus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlF
        '
        Me.pnlF.Controls.Add(Me.CmbBatchCode)
        Me.pnlF.Controls.Add(Me.Label4)
        Me.pnlF.Controls.Add(Me.Label2)
        Me.pnlF.Controls.Add(Me.CmbUID)
        Me.pnlF.Controls.Add(Me.Label3)
        Me.pnlF.Controls.Add(Me.CmbTamin)
        Me.pnlF.Controls.Add(Me.Label1)
        Me.pnlF.Controls.Add(Me.cmbKala)
        Me.pnlF.Controls.Add(Me.Label5)
        Me.pnlF.Size = New System.Drawing.Size(1106, 102)
        Me.pnlF.Controls.SetChildIndex(Me.btnViewReport, 0)
        Me.pnlF.Controls.SetChildIndex(Me.btnChart, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label5, 0)
        Me.pnlF.Controls.SetChildIndex(Me.cmbKala, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbTamin, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label3, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbUID, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label2, 0)
        Me.pnlF.Controls.SetChildIndex(Me.Label4, 0)
        Me.pnlF.Controls.SetChildIndex(Me.CmbBatchCode, 0)
        '
        'btnViewReport
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(0, 102)
        Me.pnlGrid.Size = New System.Drawing.Size(1106, 389)
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
        Me.GridEX1.Size = New System.Drawing.Size(1106, 389)
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
        Me.pnlDownJanus.Location = New System.Drawing.Point(0, 491)
        Me.pnlDownJanus.Size = New System.Drawing.Size(1106, 36)
        '
        'cmbKala
        '
        Me.cmbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKala.AutoSelectFirst = False
        Me.cmbKala.BackColor = System.Drawing.Color.White
        Me.cmbKala.BoundText = Nothing
        Me.cmbKala.BypassChangeEvent = False
        Me.cmbKala.DisplayText = ""
        Me.cmbKala.LateBindingTop = "100"
        Me.cmbKala.Location = New System.Drawing.Point(545, 39)
        Me.cmbKala.MemFilter = ""
        Me.cmbKala.Name = "cmbKala"
        Me.cmbKala.SeparatedData = Nothing
        Me.cmbKala.Size = New System.Drawing.Size(472, 21)
        Me.cmbKala.Source = Nothing
        Me.cmbKala.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbKala.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1023, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "محصول : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CmbTamin
        '
        Me.CmbTamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbTamin.AutoSelectFirst = False
        Me.CmbTamin.BackColor = System.Drawing.Color.White
        Me.CmbTamin.BoundText = Nothing
        Me.CmbTamin.BypassChangeEvent = False
        Me.CmbTamin.DisplayText = ""
        Me.CmbTamin.LateBindingTop = "100"
        Me.CmbTamin.Location = New System.Drawing.Point(545, 11)
        Me.CmbTamin.MemFilter = ""
        Me.CmbTamin.Name = "CmbTamin"
        Me.CmbTamin.SeparatedData = Nothing
        Me.CmbTamin.Size = New System.Drawing.Size(472, 21)
        Me.CmbTamin.Source = Nothing
        Me.CmbTamin.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbTamin.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1023, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "تامین کننده :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "UID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'CmbUID
        '
        Me.CmbUID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbUID_DesignTimeLayout.LayoutString = resources.GetString("CmbUID_DesignTimeLayout.LayoutString")
        Me.CmbUID.DesignTimeLayout = CmbUID_DesignTimeLayout
        Me.CmbUID.LateBinding = True
        Me.CmbUID.LateBindingTop = "100"
        Me.CmbUID.Location = New System.Drawing.Point(190, 37)
        Me.CmbUID.Name = "CmbUID"
        Me.CmbUID.SaveSettings = False
        Me.CmbUID.ShowSelectAll = True
        Me.CmbUID.Size = New System.Drawing.Size(303, 21)
        Me.CmbUID.TabIndex = 192
        Me.CmbUID.ValuesDataMember = Nothing
        Me.CmbUID.Visible = False
        Me.CmbUID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1065, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 191
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CmbBatchCode
        '
        Me.CmbBatchCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbBatchCode.AutoSelectFirst = False
        Me.CmbBatchCode.BackColor = System.Drawing.Color.White
        Me.CmbBatchCode.BoundText = Nothing
        Me.CmbBatchCode.BypassChangeEvent = False
        Me.CmbBatchCode.DisplayText = ""
        Me.CmbBatchCode.LateBindingTop = "100"
        Me.CmbBatchCode.Location = New System.Drawing.Point(545, 69)
        Me.CmbBatchCode.MemFilter = ""
        Me.CmbBatchCode.Name = "CmbBatchCode"
        Me.CmbBatchCode.SeparatedData = Nothing
        Me.CmbBatchCode.Size = New System.Drawing.Size(472, 21)
        Me.CmbBatchCode.Source = Nothing
        Me.CmbBatchCode.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbBatchCode.TabIndex = 195
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1023, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "شماره بچ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmUIDtrackingReport
        '
        Me.ClientSize = New System.Drawing.Size(1106, 527)
        Me.Name = "FrmUIDtrackingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش ردگیری UID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlF.ResumeLayout(False)
        Me.pnlF.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlCommand.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownJanus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


    Private Sub FrmUIDtrackingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String = "Select * from (select 0 as TaminVahedeTejariSN, 'همه موارد' as TaminVahedeTejariDs union Select distinct TaminVahedeTejariSN,TaminVahedeTejariNo+'. '+TaminVahedeTejariDs As TaminVahedeTejariDs  from abSanadHaProductCatalogue join abSanadHa on abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join paVw_paKalaTaminFull pk on pk.KalaSN=abSanadHa.KalaSN)p order by TaminVahedeTejariSN"

        CmbTamin.Bind(cn, str, "TaminVahedeTejariSN", "TaminVahedeTejariDs")


    End Sub

    Private Sub CmbBatchCode_Enter(sender As Object, e As EventArgs) Handles CmbBatchCode.Enter
        If cmbKala.BoundText Is Nothing Then
            Exit Sub
        Else
            If IsNumeric(cmbKala.BoundText) Then
                If CDec(cmbKala.BoundText) > 0 Then
                    Dim str As String = "select 0 as KalaPhizikiSN, 'همه موارد' as ShomarehRahgiri union Select * from (select 0 as KalaSN, 'همه موارد' as KalaDS union Select distinct abSanadHa.KalaPhizikiSN,ShomarehRahgiri   From abSanadHaProductCatalogue Join abSanadHa On abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join abKalaPhiziki on abKalaPhiziki.KalaPhizikiSN=abSanadHa.KalaPhizikiSN Where MoaserDate between '" & gHesabdariSalFDate & "' and '" & gHesabdariSalTDate & "' And abSanadHa.KalaSN=" & cmbKala.BoundText & ")p Order By KalaPhizikiSN"
                    CmbBatchCode.Bind(cn, str, "KalaPhizikiSN", "ShomarehRahgiri")
                Else
                    If CDec(CmbTamin.BoundText) > 0 Then
                        Dim str As String = "select 0 as KalaPhizikiSN, 'همه موارد' as ShomarehRahgiri union Select * from (select 0 as KalaSN, 'همه موارد' as KalaDS union Select distinct abSanadHa.KalaPhizikiSN,ShomarehRahgiri   From abSanadHaProductCatalogue Join abSanadHa On abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join abKalaPhiziki on abKalaPhiziki.KalaPhizikiSN=abSanadHa.KalaPhizikiSN Join paVw_paKalaTaminFull pk on pk.KalaSN=abSanadHa.KalaSN  Where MoaserDate between '" & gHesabdariSalFDate & "' and '" & gHesabdariSalTDate & "' And TaminVahedeTejariSN=" & CmbTamin.BoundText & ")p Order By KalaPhizikiSN"
                        CmbBatchCode.Bind(cn, str, "KalaPhizikiSN", "ShomarehRahgiri")
                    Else
                        Dim str As String = "select 0 as KalaPhizikiSN, 'همه موارد' as ShomarehRahgiri union Select * from (select 0 as KalaSN, 'همه موارد' as KalaDS union Select distinct abSanadHa.KalaPhizikiSN,ShomarehRahgiri   From abSanadHaProductCatalogue Join abSanadHa On abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join abKalaPhiziki on abKalaPhiziki.KalaPhizikiSN=abSanadHa.KalaPhizikiSN Where MoaserDate between '" & gHesabdariSalFDate & "' and '" & gHesabdariSalTDate & "')p Order By KalaPhizikiSN"
                        CmbBatchCode.Bind(cn, str, "KalaPhizikiSN", "ShomarehRahgiri")
                    End If

                End If
            End If
        End If
    End Sub
    Private Sub cmbKala_Enter(sender As Object, e As EventArgs) Handles cmbKala.Enter
        If CmbTamin.BoundText Is Nothing Then
            Exit Sub
        Else
            If IsNumeric(CmbTamin.BoundText) Then
                If CDec(CmbTamin.BoundText) > 0 Then
                    Dim str As String = "select 0 as KalaSN, 'همه موارد' as KalaDS union  Select * from (select 0 as KalaSN, 'همه موارد' as KalaDS union Select distinct pk.KalaSN, KalaNo+'. '+KalaDs As KalaDs  From abSanadHaProductCatalogue Join abSanadHa On abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join paVw_paKalaTaminFull pk on pk.KalaSN=abSanadHa.KalaSN Where TaminVahedeTejariSN=" & CmbTamin.BoundText & ")p Order By KalaSN"
                    cmbKala.Bind(cn, str, "KalaSN", "KalaDS")
                Else
                    Dim str As String = "select 0 as KalaSN, 'همه موارد' as KalaDS union  Select * from (select 0 as KalaSN, 'همه موارد' as KalaDS union Select distinct pk.KalaSN, KalaNo+'. '+KalaDs As KalaDs  From abSanadHaProductCatalogue Join abSanadHa On abSanadHaProductCatalogue.SanadHaSN=abSanadHa.SanadHaSN Join paVw_paKalaTaminFull pk on pk.KalaSN=abSanadHa.KalaSN)p Order By KalaSN"
                    cmbKala.Bind(cn, str, "KalaSN", "KalaDS")
                End If
            End If
        End If
    End Sub

    Private Sub CmbUID_Enter(sender As Object, e As EventArgs) Handles CmbUID.Enter
        Dim TaminFilter As String = If(CmbTamin.BoundText = "0", "", "TaminVahedeTejariSN=" & CmbTamin.BoundText)
        Dim KalaFilter As String = If(cmbKala.BoundText = "0", "", "KalaSN=" & cmbKala.BoundText)
        Dim KalaPhizikiFilter As String = If(CmbBatchCode.BoundText = "0", "", "KalaPhizikiSN=" & CmbBatchCode.BoundText)

        Dim BindStr As String = "select distinct ProductCatalogueSN, UID from abProductCatalogue " &
                                "Join(Select TaminVahedeTejariSN, KalaSN, IRC, GTIN from paVw_paKalaTaminFull " &
                                "Union select TaminVahedeTejariSN, abProductCatalogueKalaIRC.KalaSN, NewIRC, NewGTIN  " &
                                "From abProductCatalogueKalaIRC Join paVw_paKalaTaminFull On paVw_paKalaTaminFull.KalaSN=abProductCatalogueKalaIRC.KalaSN )p " &
                                "On p.GTIN=abProductCatalogue.GTIN And p.IRC=abProductCatalogue.IRC " &
                                "Join abKalaPhiziki on abKalaPhiziki.KalaSN=p.KalaSN And abKalaPhiziki.ShomarehRahgiri=abProductCatalogue.BatchCode  " &
                                "Where MoaserDate between '" & gHesabdariSalFDate & "' and '" & gHesabdariSalTDate & "' " & If(TaminFilter.Length > 0 Or KalaFilter.Length > 0 Or KalaPhizikiFilter.Length > 0, "And ", "") &
                                 TaminFilter & If(TaminFilter.Length > 0, "And ", "") & KalaFilter & If(TaminFilter.Length > 0 Or KalaFilter.Length > 0, "And ", "") & KalaPhizikiFilter

        CmbBatchCode.Bind(cn, BindStr, "ProductCatalogueSN", "UID")

    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Dim TaminSn As Decimal = If(CmbTamin.BoundText Is Nothing, 0, CDec(CmbTamin.BoundText))
        Dim KalaSn As Decimal = If(cmbKala.BoundText Is Nothing, 0, CDec(cmbKala.BoundText))
        Dim KalaPhizikiSn As Decimal = If(CmbBatchCode.BoundText Is Nothing, 0, CDec(CmbBatchCode.BoundText))


        Dim frmWait As New Anbar.Common.Frmwait
        frmWait.Show()
        frmWait.Label3.Text = "...سیستم در حال گزارش گیری می باشد..."
        frmWait.Refresh()

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim AnbarRule As New ClsDataAccessRule
            Dim DvReport As New DataView
            Try
                DvReport = AnbarRule.RptUIDtracking(TaminSn, KalaSn, KalaPhizikiSn, cn)

            Catch ex As Exception
                Throw ex
            End Try

            GridEX1.DataSource = DvReport
            GridEX1.RetrieveStructure()

            'For Each col As Janus.Windows.GridEX.GridEXColumn In GridEX1.RootTable.Columns
            '    If col.Caption.Contains("ریال") Or col.Caption.Contains("تعداد") Then
            '        col.FormatString = "#,###"
            '    End If
            'Next

            GridEX1.AutoSizeColumns()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmWait.Close()
            Me.Cursor = Cursors.Default
        End Try


    End Sub
End Class
