' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description::  انتخاب محل چيدمان کالا
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Public Class FrmChidemanTekrari
    Inherits Minoo.Base.FTBaseForm

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If Not System.Reflection.Assembly.GetExecutingAssembly.EntryPoint Is Nothing Then
                        If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                            m_vb6FormDefInstance = Me
                        End If
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents picGrid As System.Windows.Forms.Panel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.picGrid = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point (358, 249)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size (88, 35)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "انتخاب"
        Me.btnSelect.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point (243, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExit.Size = New System.Drawing.Size (84, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "بازگشت"
        '
        'picGrid
        '
        Me.picGrid.BackColor = System.Drawing.SystemColors.Control
        Me.picGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.picGrid.Font = _
            New System.Drawing.Font ("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (0, Byte))
        Me.picGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picGrid.Location = New System.Drawing.Point (0, 0)
        Me.picGrid.Name = "picGrid"
        Me.picGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.picGrid.Size = New System.Drawing.Size (681, 248)
        Me.picGrid.TabIndex = 0
        '
        'FrmChidemanTekrari
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleBaseSize = New System.Drawing.Size (7, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size (690, 288)
        Me.Controls.Add (Me.btnSelect)
        Me.Controls.Add (Me.btnExit)
        Me.Controls.Add (Me.picGrid)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpSectionName = "HelpSelectSalMali.htm"
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChidemanTekrari"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نمايش تخصيص چيدمان تکراري"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmChidemanTekrari
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmChidemanTekrari
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmChidemanTekrari
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmChidemanTekrari)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  محل چيدمان کالا تعريف شده است
    Private WithEvents DViewer As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgGrid As NetSql.Components.VsFlexGrid

    ' آيا فرم قبلا در حافظه وارد شده است
    Private pISLoaded As Boolean

    Public vKalaSn As String

    Public Sub LoadForm()
        MyBase.OnLoad (New System.EventArgs)
    End Sub

    Private Sub btnSelect_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelect.Click
        ' انتخاب محل چيدمان کالا 
        ' مقدار دهي متغييرهاي سراسري محل چيدمان کالا
        'With DViewer.FlexGrid
        '  If (.Rows - .FixedRows) > 0 Then
        '    gHesabdariSal = CShort(Trim(.TextMatrix(.Row, .ColIndex("HesabdariSal"))))
        '    gHesabdariSalFDate = Trim(.TextMatrix(.Row, .ColIndex("FDate")))
        '    gHesabdariSalTDate = Trim(.TextMatrix(.Row, .ColIndex("TDate")))
        '    gHesabdariSalISClosed = CBool(.TextMatrix(.Row, .ColIndex("ISClosed")))
        '    If gAnbarSN > 0 And gHesabdariSal > 0 Then
        '      tp.Settings("AnbarSettings\HesabdariSal\AnbarSN_" & CStr(gAnbarSN) & _
        '              "\LocationID_" & CStr(gSM.SystemLocationSN), "LastHesabdariSal") = CStr(gHesabdariSal)
        '    End If
        '  End If
        'End With
        'btnExit_Click(btnExit, New System.EventArgs)
    End Sub

    Private Sub FrmChidemanTekrari_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'Dim vLastHesabdariSal As Short
        'Dim vLastRow As Integer

        'If pISLoaded Then Exit Sub
        'pISLoaded = True

        DViewer = New CDataView (cn)

        With DViewer
            .Init (picGrid)
            .EditInGrid = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            .QueryName = "abQuery_ChidemanTekrari"
            ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
            ' سلکت  گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد

            .SQLSelect = _
                "Select  KalaNO AS 'کد کالا', KalaDS AS 'شرح کالا', a3.ChidemanDS AS 'محل چيدمان 1', a2.ChidemanDS AS 'محل چيدمان 2', abChideman.ChidemanDS AS 'محل چيدمان 3' " & _
                " from abKalaChideman " & _
                " left join abKalaPhiziki on abKalaPhiziki.KalaPhizikiSn = abKalaChideman.KalaPhizikiSn " & _
                " left join paKala on abKalaPhiziki.KalaSn = paKala.KalaSn " & _
                " left join abChideman on abChideman.ChidemanSn = abKalaChideman.ChidemanSn " & _
                " left join abChideman a2 on abChideman.PedarChidemanSn = a2.ChidemanSn " & _
                " left join abChideman a3 on a2.PedarChidemanSn = a3.ChidemanSn " & _
                " Where abKalaChideman.KalaPhizikiSn in ( " & _
                " Select abKalaChideman.KalaPhizikiSn " & _
                " from abKalaChideman  " & _
                " Group by abKalaChideman.KalaPhizikiSn " & _
                " Having Count(*) > 1 " & _
                " ) " & _
                " order by KalaNO , KalaDS , a3.ChidemanDS, a2.ChidemanDS, abChideman.ChidemanDS "

            vfgGrid = .FlexGrid
            .Refresh()
        End With

    End Sub

    Private Sub btnExit_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DViewer_GetGridProperties() Handles DViewer.GetGridProperties

        ' تنظيم خصوصيات گريد اطلاعات
        With DViewer.FlexGrid
            .WordWrap = True
            .FontBold = True
            .ColAlignment(-1) = AlignmentSettings.flexAlignCenterCenter
            .AutoSize (.FixedCols, .Cols - 1)
            .RowHeight(-1) = 40
        End With

    End Sub

    Private Sub vfgGrid_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles vfgGrid.DoubleClick

        If vfgGrid.Row < vfgGrid.FixedRows Then Exit Sub
        If vfgGrid.MouseRow < vfgGrid.FixedRows Then Exit Sub
        btnSelect_Click(btnSelect, New System.EventArgs)

    End Sub

    Private Sub FrmChidemanTekrari_Closed (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class
