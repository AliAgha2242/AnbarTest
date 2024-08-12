' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 
'ModifiedDate::
'Description::  انتخاب انبار ها بصورت درختواره 
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid



Public Class FrmTreeSelectAnbar
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    If Not System.Reflection.Assembly.GetExecutingAssembly.EntryPoint Is Nothing Then
                        If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                            m_vb6FormDefInstance = Me
                        End If
                    End If
                Catch
                End Try
            End If
        End If
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose (ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents tmrResort As System.Windows.Forms.Timer
    Public WithEvents btnSelectAll As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll As System.Windows.Forms.Button
    Public WithEvents PicN As System.Windows.Forms.Panel
    Public WithEvents PicG As System.Windows.Forms.Panel
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents PicC As System.Windows.Forms.Panel
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim _
            resources As System.Resources.ResourceManager = _
                New System.Resources.ResourceManager (GetType (FrmTreeSelectAnbar))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.tmrResort = New System.Windows.Forms.Timer (Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.btnDeselectAll = New System.Windows.Forms.Button
        Me.PicN = New System.Windows.Forms.Panel
        Me.PicG = New System.Windows.Forms.Panel
        Me.PicC = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrResort
        '
        Me.tmrResort.Interval = 1
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                    Or System.Windows.Forms.AnchorStyles.Left) _
                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add (Me.btnSelectAll)
        Me.Frame1.Controls.Add (Me.btnDeselectAll)
        Me.Frame1.Controls.Add (Me.PicN)
        Me.Frame1.Controls.Add (Me.PicG)
        Me.Frame1.Controls.Add (Me.PicC)
        Me.Frame1.Controls.Add (Me.btnSelect)
        Me.Frame1.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point (2, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size (559, 493)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "ليست انبارها"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Image = CType (resources.GetObject ("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.Location = New System.Drawing.Point (250, 460)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size (41, 29)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Image = CType (resources.GetObject ("btnDeselectAll.Image"), System.Drawing.Image)
        Me.btnDeselectAll.Location = New System.Drawing.Point (206, 460)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size (41, 29)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        '
        'PicN
        '
        Me.PicN.Anchor = CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicN.BackColor = System.Drawing.SystemColors.Control
        Me.PicN.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicN.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.PicN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicN.Location = New System.Drawing.Point (4, 460)
        Me.PicN.Name = "PicN"
        Me.PicN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicN.Size = New System.Drawing.Size (175, 29)
        Me.PicN.TabIndex = 3
        '
        'PicG
        '
        Me.PicG.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                  Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicG.BackColor = System.Drawing.SystemColors.Highlight
        Me.PicG.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicG.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.PicG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicG.Location = New System.Drawing.Point (2, 18)
        Me.PicG.Name = "PicG"
        Me.PicG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicG.Size = New System.Drawing.Size (553, 437)
        Me.PicG.TabIndex = 2
        '
        'PicC
        '
        Me.PicC.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.PicC.BackColor = System.Drawing.SystemColors.Control
        Me.PicC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicC.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.PicC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicC.Location = New System.Drawing.Point (369, 461)
        Me.PicC.Name = "PicC"
        Me.PicC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PicC.Size = New System.Drawing.Size (181, 29)
        Me.PicC.TabIndex = 1
        Me.PicC.TabStop = True
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point (295, 460)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size (53, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Tag = ""
        Me.btnSelect.Text = "انتخاب"
        '
        'FrmTreeSelectAnbar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (567, 496)
        Me.Controls.Add (Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTreeSelectAnbar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب انبار ها بصورت درختواره "
        Me.Frame1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmTreeSelectAnbar
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmTreeSelectAnbar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmTreeSelectAnbar
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmTreeSelectAnbar)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Public WithEvents DvTree As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgTree As AxVSFlexGrid

    ' انبار يا انبارهاي انتخاب شده
    Private mSelected As String

    Public Property Selected() As String
        Get
            Selected = mSelected
        End Get
        Set (ByVal Value As String)
            If Trim (Value) = "" Then
                mSelected = gAnbarSN
            Else
                mSelected = Value
            End If
            SelectByStr (mSelected)
        End Set
    End Property

    Private Sub btnDeselectAll_Click (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub btnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelect.Click
        mSelected = _
            Minoo.Functions.FTFlexFunctions.MultiSelectGetSelectedToStrByCheckBox(vfgTree, "AnbarSN", "Selected")
        Me.Hide()
    End Sub

    Private Sub btnSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub DvTree_GetGridProperties() Handles DvTree.GetGridProperties
        Minoo.Functions.FTFlexFunctions.MakeTree(DvTree.FlexGrid, True, "AnbarDs", "AnbarSN" _
                                                  , "SortField", "level")
        DvTree.FlexGrid.FontSize = 10
    End Sub

    Private Sub FrmTreeSelectAnbar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        If pISLoaded Then Exit Sub
        pISLoaded = True
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvTree = New CDataView(cn)
        With DvTree
            .Init(PicG, , PicC, PicN, EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint _
                                       Or EnumButtonOptions.boCmdFilter)
            .CommandVisible(EnumCommands.cmExit) = False
            .TableName = "abVw_TreeAnbar"
            .Text = Me.Text
            .Text = FTDD.GetCaption("abVw_TreeAnbar")
            .EditInGrid = False
            .SQLWhere = " AnbarSN in (Select AnbarSN FROM dbo.abFnt_Req_Get_AnbarSN_Childs ( " & gAnbarSN & "))"
            .SQLOrderBy = "SortField"
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            vfgTree = .FlexGrid
            vfgTree.Editable = EditableSettings.flexEDKbdMouse
            With .Fields
                With .Add("AnbarSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("Selected", "CheckBox")
                End With
                With .Add("AnbarDs", "TextBox")
                End With
                With .Add("VahedeTejariDs", "TextBox", EnumFieldOptions.foHidden)
                End With
                With .Add("AnbarSNParent", "TextBox", EnumFieldOptions.foHidden)
                End With
                With .Add("VahedeTejariSN", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With
                .Add("{dbo.abFn_GetTreeAnbarNodeLevel(AnbarSN)} as Level", , EnumFieldOptions.foHidden)
                .Add("{dbo.abFn_GetTreeAnbarSortField(AnbarSN)} as SortField", , EnumFieldOptions.foHidden)
            End With
        End With
        DvTree.Refresh()
    End Sub

    Private Sub FrmTreeSelectAnbar_Closing(ByVal eventSender As System.Object, _
                                            ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub FrmTreeSelectAnbar_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvTree.Done()
        DvTree = Nothing
    End Sub

    Private Sub tmrResort_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles tmrResort.Tick
        tmrResort.Enabled = False
        Minoo.Functions.FTFlexFunctions.MakeTree(DvTree.FlexGrid, True, "AnbarDs", "AnbarSN" _
                                                  , "SortField", "level", True)
    End Sub

    Private Sub vfgTree_AfterEdit(ByVal eventSender As System.Object, _
                                   ByVal eventArgs As RowColEventArgs) _
        Handles vfgTree.AfterEdit
        If eventArgs.row < vfgTree.FixedRows Then Exit Sub
        If eventArgs.col <> vfgTree.get_ColIndex("Selected") Then Exit Sub
        SelectSubTree(eventArgs.row, vfgTree.GetCellCheck(eventArgs.row, vfgTree.get_ColIndex("Selected")))
    End Sub

    Private Sub vfgTree_BeforeEdit(ByVal eventSender As System.Object, _
                                    ByVal eventArgs As RowColEventArgs) _
        Handles vfgTree.BeforeEdit
        If eventArgs.row < vfgTree.FixedRows Then eventArgs.cancel = True : Exit Sub
        If eventArgs.col <> vfgTree.get_ColIndex("Selected") Then eventArgs.cancel = True : Exit Sub
    End Sub

    Private Sub SelectByStr(ByRef aStr As String)
        Dim i As Short
        Dim J As Short
        Dim vArr() As String
        With vfgTree
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
        vArr = Split(aStr, ",")
        With vfgTree
            For i = .FixedRows To .Rows - 1
                For J = LBound(vArr) To UBound(vArr)
                    If Trim(vArr(J)) = Trim(.get_TextMatrix(i, .get_ColIndex("AnbarSN"))) Then
                        .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
                    End If
                Next J
            Next i
        End With
    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Private Sub SelectSubTree(ByVal arow As Integer, ByVal aSelect As Boolean)
        Dim vFirstChildrow As Integer
        Dim vLastChildrow As Integer
        Dim i As Integer

        vFirstChildrow = vfgTree.GetNodeRow(arow, NodeTypeEnum.FirstChild)
        vLastChildrow = vfgTree.GetNodeRow(arow, NodeTypeEnum.LastChild)

        If vFirstChildrow = -1 Or vLastChildrow = -1 Then Exit Sub

        For i = vFirstChildrow To vLastChildrow
            vfgTree.SetCellCheck(i, vfgTree.get_ColIndex("Selected"), aSelect)
        Next
    End Sub
End Class
