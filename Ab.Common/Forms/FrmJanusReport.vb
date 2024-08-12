Option Strict On
Option Explicit On
Public Class FrmJanusReport
    Inherits Minoo.Base.FTBaseForm

    Private Shared m_vb6formdefinstance As FrmJanusReport
    Private Shared m_initializingdefinstance As Boolean
    Friend WithEvents Panel1 As Panel
    Public WithEvents GridReport As Janus.Windows.GridEX.GridEX
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
        Me.Panel1.SuspendLayout()
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        'FrmJanusReport
        '
        Me.ClientSize = New System.Drawing.Size(1055, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmJanusReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Public DvSource As DataView
    Public SelectedKalaSN As Decimal
    Public SelectedNerkh As Integer
    Public HideSNColumns As Boolean


    Private Sub FrmJanusReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridReport.DataSource = DvSource
        GridReport.RetrieveStructure()
        For Each col As Janus.Windows.GridEX.GridEXColumn In GridReport.RootTable.Columns
            If col.Key.ToUpper.EndsWith("SN") And HideSNColumns Then
                col.Visible = False
            End If
            If col.Key.ToUpper.EndsWith("DS") Then
                col.Width = 200
            End If
        Next
        GridReport.AutoSizeColumns()


    End Sub

    Private Sub GridReport_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GridReport.MouseDoubleClick
        If GridReport.CurrentRow Is Nothing Then
            Exit Sub
        ElseIf GridReport.CurrentRow.RowType <> Janus.Windows.GridEX.RowType.Record Then
            Exit Sub
        Else

            If DvSource.ToTable.Columns("KalaSN") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("KalaSN").Value) Then
                    SelectedKalaSN = CDec(GridReport.CurrentRow.Cells("KalaSN").Value)
                End If
            End If
            If DvSource.ToTable.Columns("Nerkh") IsNot Nothing Then
                If IsNumeric(GridReport.CurrentRow.Cells("Nerkh").Value) Then
                    SelectedNerkh = CInt(GridReport.CurrentRow.Cells("Nerkh").Value)
                End If
            End If

        End If

        Me.Close()

    End Sub

End Class
