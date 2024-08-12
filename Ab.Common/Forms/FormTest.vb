
Imports System.Web.UI.DataVisualization.Charting

Public Class FormTest
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        If Not (components Is Nothing) Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart


    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea1.CursorX.Interval = 2.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(102, 88)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(607, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'FormTest
        '
        Me.ClientSize = New System.Drawing.Size(864, 418)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FormTest"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dv As DataView = cn.ExecuteQuery("select left(sanaddate,6) ll,sum(SanadSN) ss from absanad where SanadDate>=14011101 group by left(SanadDate,6)")

        'Chart1.Titles.Add("Projectile Motion")
        'Chart1.ChartAreas.Clear()
        'Chart1.ChartAreas.Add("Default")

        ''Dim xAxisInterval As Integer = CInt(totalTime / 10)
        ''Dim yAxisInterval As Integer = CInt(heightOfProjectile / 10)

        ''With Chart1.ChartAreas("Default")
        ''    .AxisX.Interval() = xAxisInterval
        ''    .AxisY.Interval() = yAxisInterval

        ''End With

        'Chart1.Series.Add("projection")
        'Chart1.Series("projection").Color = Color.Black
        'Chart1.Series("projection").ChartType = DataVisualization.Charting.SeriesChartType.Column


        'For Each row As DataRow In Dv.ToTable.Rows

        '    Dim xPos As Double = CDbl(row(0))
        '    Dim yPos As Double = CDbl(row(1))

        '    Chart1.Series("projection").Points.AddXY(xPos, yPos)

        'Next

        Chart1.DataSource = Dv

        'Dim seri As DataVisualization.Charting.Series
        'seri = Chart1.Series.Add("Series1")


        Chart1.Series("Series1").XValueMember = "ll"
        Chart1.Series("Series1").YValueMembers = "ss"
        Chart1.Series("Series1").Name = "Employees"

        Chart1.DataBind()
        Chart1.Show()

        Chart1.Show()

    End Sub
End Class
