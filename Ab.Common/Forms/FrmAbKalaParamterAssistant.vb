Option Strict On
Option Explicit On
Imports Janus.Windows.GridEX

Public Class FrmAbKalaParamterAssistant
    Inherits Minoo.Base.FTBaseForm

    Private Shared m_vb6formdefinstance As FrmAbKalaParamterAssistant
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents Panel1 As Panel
    Public WithEvents GridReport As Janus.Windows.GridEX.GridEX
    Public WithEvents BtnInsertZaribDaftar As Button
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


    Private Sub InitializeComponent()
        Dim GridReport_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridReport = New Janus.Windows.GridEX.GridEX()
        Me.BtnInsertZaribDaftar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnInsertZaribDaftar)
        Me.Panel1.Controls.Add(Me.GridReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 446)
        Me.Panel1.TabIndex = 0
        '
        'GridReport
        '
        Me.GridReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridReport_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><GroupCondition /></Root" &
    "Table></GridEXLayoutData>"
        Me.GridReport.DesignTimeLayout = GridReport_DesignTimeLayout
        Me.GridReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridReport.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridReport.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridReport.GroupByBoxVisible = False
        Me.GridReport.Location = New System.Drawing.Point(0, 0)
        Me.GridReport.Name = "GridReport"
        Me.GridReport.RecordNavigator = True
        Me.GridReport.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReport.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.Size = New System.Drawing.Size(1055, 446)
        Me.GridReport.TabIndex = 15
        Me.GridReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BtnInsertZaribDaftar
        '
        Me.BtnInsertZaribDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnInsertZaribDaftar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnInsertZaribDaftar.Location = New System.Drawing.Point(3, 385)
        Me.BtnInsertZaribDaftar.Name = "BtnInsertZaribDaftar"
        Me.BtnInsertZaribDaftar.Size = New System.Drawing.Size(177, 39)
        Me.BtnInsertZaribDaftar.TabIndex = 239
        Me.BtnInsertZaribDaftar.Text = "درج ضرایب"
        Me.BtnInsertZaribDaftar.UseVisualStyleBackColor = False
        '
        'FrmAbKalaParamterAssistant
        '
        Me.ClientSize = New System.Drawing.Size(1055, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAbKalaParamterAssistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Public DvSource As DataView
    Public SelectedKalaSN As Decimal
    Public SelectedNerkh As Integer
    Public HideSNColumns As Boolean




    Private Sub FrmAbKalaParamterAssistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        GridReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        GridReport.DataSource = DvSource
        GridReport.RetrieveStructure()
        'GridReport.RootTable.Groups.Add(GridReport.RootTable.Columns("VahedeTejariDS"))

        'GridReport.AutoSizeColumns()
        For Each col As Janus.Windows.GridEX.GridEXColumn In GridReport.RootTable.Columns
            col.EditType = Janus.Windows.GridEX.EditType.NoEdit
            If col.Key.ToUpper.EndsWith("SN") And HideSNColumns Then
                col.Visible = False
            End If
            If col.Key.ToUpper.EndsWith("DS") Then
                col.Width = 300
            End If
            If col.Key.ToString.ToUpper = "ZARIBTAKHSIS" Then
                col.FormatString = "#,###.##"
                col.TotalFormatString = "#,###.##"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                col.EditType = Janus.Windows.GridEX.EditType.TextBox
                col.Caption = "ضریب تخصیص دفتر فروش"
            End If
            If col.Key.ToString.ToUpper = "SUMZARIBTAKHSIS" Then
                col.FormatString = "#,###.##"
                col.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.None
                col.EditType = Janus.Windows.GridEX.EditType.NoEdit
                col.Caption = "مجموع ضریب تخصیص شعبه"
            End If
        Next
    End Sub


    Private Sub BtnInsertZaribDaftar_Click(sender As Object, e As EventArgs) Handles BtnInsertZaribDaftar.Click
        For Each rowMain As Janus.Windows.GridEX.GridEXRow In GridReport.GetRows()
            Dim VahedTejari As Decimal = CDec(rowMain.Cells("VahedeTejariSN").Value)
            Dim SumDarsadVahedTEjari As Decimal = 0
            For Each row_Daftar As Janus.Windows.GridEX.GridEXRow In GridReport.GetRows()
                If CDec(row_Daftar.Cells("VahedeTejariSN").Value) = VahedTejari Then
                    SumDarsadVahedTEjari += CDec(row_Daftar.Cells("ZaribTakhsis").Value)
                End If
            Next
            If SumDarsadVahedTEjari <> 100 OrElse SumDarsadVahedTEjari <> 0 Then
                CSystem.MsgBox("مجموع ضرایب تخصیص یافته برای هر شعبه می بایست صفر یا صد باشد ", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        Next
    End Sub

    Private Sub GridReport_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles GridReport.CellUpdated

        Dim Grow As Janus.Windows.GridEX.GridEXRow = GridReport.CurrentRow
        If Grow Is Nothing OrElse Grow.RowType <> RowType.Record Then
            Exit Sub
        End If
        Dim VahedTejari As Decimal = CDec(Grow.Cells("VahedeTejariSN").Value)
        Dim SumDarsadVahedTEjari As Decimal = 0

        For Each row_Daftar As Janus.Windows.GridEX.GridEXRow In GridReport.GetRows()
            If IsNumeric(VahedTejari) Then
                If VahedTejari > 0 Then
                    If CDec(row_Daftar.Cells("VahedeTejariSN").Value) = VahedTejari Then
                        SumDarsadVahedTEjari += CDec(row_Daftar.Cells("ZaribTakhsis").Value)

                    End If
                End If
            End If

        Next

        For Each row_Daftar As Janus.Windows.GridEX.GridEXRow In GridReport.GetRows()
            If CDec(row_Daftar.Cells("VahedeTejariSN").Value) = VahedTejari Then
                row_Daftar.BeginEdit()
                row_Daftar.Cells("SumZaribTakhsis").Value = SumDarsadVahedTEjari
                row_Daftar.EndEdit()
            End If

        Next

    End Sub
End Class
