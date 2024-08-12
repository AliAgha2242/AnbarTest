' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/09/15
'ModifiedDate::
'Description::  رويه رهگيري کالاهاي هر انبار
' ثبت و بروزآوري رويه رهگيري کالا در هر انبار
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Friend Class frmAnbarNoeRahgiri
    Inherits Minoo.Base.FTBaseForm

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

    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents pnlCommandDet1 As System.Windows.Forms.Panel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationDet1 As System.Windows.Forms.Panel
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlCommandMaster = New System.Windows.Forms.Panel
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel
        Me.pnlGridMaster = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlGridDet1 = New System.Windows.Forms.Panel
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point (795, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size (28, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "انبار"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlCommandDet1
        '
        Me.pnlCommandDet1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet1.Location = New System.Drawing.Point (373, 147)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size (420, 33)
        Me.pnlCommandDet1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point (629, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size (161, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "رويه رهگيري کالاهاي هر انبار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point (0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add (Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add (Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size (826, 549)
        Me.SplitContainer1.SplitterDistance = 361
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add (Me.Label1)
        Me.Panel1.Controls.Add (Me.pnlCommandMaster)
        Me.Panel1.Controls.Add (Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add (Me.pnlGridMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point (0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size (826, 361)
        Me.Panel1.TabIndex = 0
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point (373, 324)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size (420, 33)
        Me.pnlCommandMaster.TabIndex = 12
        Me.pnlCommandMaster.Tag = ""
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point (4, 324)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size (366, 33)
        Me.pnlNavigationMaster.TabIndex = 11
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point (6, 2)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size (789, 318)
        Me.pnlGridMaster.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add (Me.pnlGridDet1)
        Me.Panel2.Controls.Add (Me.pnlNavigationDet1)
        Me.Panel2.Controls.Add (Me.pnlCommandDet1)
        Me.Panel2.Controls.Add (Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point (0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size (826, 184)
        Me.Panel2.TabIndex = 0
        '
        'pnlGridDet1
        '
        Me.pnlGridDet1.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet1.Location = New System.Drawing.Point (4, 20)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size (789, 123)
        Me.pnlGridDet1.TabIndex = 13
        '
        'pnlNavigationDet1
        '
        Me.pnlNavigationDet1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet1.Location = New System.Drawing.Point (4, 146)
        Me.pnlNavigationDet1.Name = "pnlNavigationDet1"
        Me.pnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet1.Size = New System.Drawing.Size (366, 33)
        Me.pnlNavigationDet1.TabIndex = 12
        '
        'frmAnbarNoeRahgiri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (826, 549)
        Me.Controls.Add (Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (11, 65)
        Me.Name = "frmAnbarNoeRahgiri"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "رويه رهگيري کالاهاي هر انبار"
        Me.SplitContainer1.Panel1.ResumeLayout (False)
        Me.SplitContainer1.Panel2.ResumeLayout (False)
        Me.SplitContainer1.ResumeLayout (False)
        Me.Panel1.ResumeLayout (False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout (False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As frmAnbarNoeRahgiri
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmAnbarNoeRahgiri
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmAnbarNoeRahgiri
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As frmAnbarNoeRahgiri)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region


    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Private WithEvents DVVi_abVw_AnbarNoeAnbar As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  رويه رهگيري هر انبار تعريف شده است
    Private WithEvents DVabAnbarNoeRahgiri As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFLX_aAnbaraNoeAnbar As AxVSFlexGrid

    Private WithEvents dcbKalaPhizikiStatus As NetSql.Components.DataCombo
    ' جهت استفاده در عمليات پشتيباني رويدادهاي گريد
    Private pRowNomber As Short

    Private Sub DVabAnbarNoeRahgiri_AfterCommandClick (ByVal aCommand As EnumCommands) _
        Handles DVabAnbarNoeRahgiri.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                ' مقادير مورد نياز از گريد انبارها کپي ميگردد
                With DVVi_abVw_AnbarNoeAnbar.FlexGrid
                    DVabAnbarNoeRahgiri.Fields ("AnbarSN").Value = .TextMatrix (.Row, .ColIndex ("AnbarSN"))
                    DVabAnbarNoeRahgiri.Fields ("NoeAnbarSN").Value = .TextMatrix (.Row, .ColIndex ("NoeAnbarSN"))
                    DVabAnbarNoeRahgiri.Fields ("VahedeTejariSN").Value = _
                        .TextMatrix (.Row, .ColIndex ("VahedeTejariSN"))
                End With
            Case EnumCommands.cmEdit
        End Select
    End Sub

    Private Sub frmAnbarNoeRahgiri_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
    End Sub

    Private Sub frmAnbarNoeRahgiri_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVVi_abVw_AnbarNoeAnbar.Done()
        DVVi_abVw_AnbarNoeAnbar = Nothing
        DVabAnbarNoeRahgiri.Done()
        DVabAnbarNoeRahgiri = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        'Dim vSelect As String
        Dim vSql_where As String

        DVVi_abVw_AnbarNoeAnbar = New CDataView (cn)
        With DVVi_abVw_AnbarNoeAnbar
            .Init (pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdPrint _
                                                                           Or EnumButtonOptions.boCmdFilter Or _
                                                                           EnumButtonOptions.boCmdFind Or _
                                                                           EnumButtonOptions.boCmdRefresh)
            .TableName = "abVw_AnbarNoeAnbar"
            .Text = Me.Text
            .AccessRight = EnumAccessRight.arView
            .SQLOrderBy = " VahedeTejariDS "
            If gIsTajmie <> 1 Then
                .SQLWhere = " VahedeTejariSN =  " & CStr (gVahedeTejariSN)
            End If
            With .Fields
                .Add ("VahedeTejariDS", )
                .Add ("VahedeTejariSN", , EnumFieldOptions.foHidden)
                .Add ("AnbarSN", , EnumFieldOptions.foHidden)
                .Add ("AnbarNO", , EnumFieldOptions.foDefault)
                .Add ("AnbarDS", , EnumFieldOptions.foDefault)
                .Add ("NoeAnbarSN", , EnumFieldOptions.foHidden)
                .Add ("NoeAnbarDS", , EnumFieldOptions.foDefault)
                .Add ("NoeVoroodeAsnadSN", , EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
        pFLX_aAnbaraNoeAnbar = DVVi_abVw_AnbarNoeAnbar.FlexGrid

        ' تهيه شرط ديتا ويو با توجه به اطلاعات گريد انبارها
        With DVVi_abVw_AnbarNoeAnbar.FlexGrid
            If .Rows > 1 Then
                pRowNomber = 1
                vSql_where = " abAnbarNoeRahgiri.VahedeTejariSN = " & .TextMatrix (.Row, .ColIndex ("VahedeTejariSN")) & _
                             " AND abAnbarNoeRahgiri.AnbarSN = " & .TextMatrix (.Row, .ColIndex ("AnbarSN")) & _
                             " AND abAnbarNoeRahgiri.NoeAnbarSN =  " & .TextMatrix (.Row, .ColIndex ("NoeAnbarSN"))
            Else
                vSql_where = " 1 = 2 "
            End If
        End With

        DVabAnbarNoeRahgiri = New CDataView (cn)
        With DVabAnbarNoeRahgiri
            .Init (pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, _
                   EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit)
            .TableName = "abAnbarNoeRahgiri"
            .Text = Me.Text
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "abKalaPhizikiStatus", "KalaPhizikiStatusSN", _
                      "KalaPhizikiStatusSN")
            .AddJoin (.TableName, EnumTableJoin.tjLeftJoin, "paGeneralStatusYN", "Auto", "GeneralStatusYNSN")
            .AccessRight = gSM.TableAccessRight (.TableName)
            .EditInGrid = True
            .SQLWhere = vSql_where
            With .Fields
                With .Add ("AnbarNoeRahgiriSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add ("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add ("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add ("NoeAnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                .Add ("KalaSN", , EnumFieldOptions.foHidden)
                .Add ("AnbarNoeRahgiriDS", "TextBox")
                With _
                    .Add ("KalaPhizikiStatusSN->abKalaPhizikiStatus.KalaPhizikiStatusDs", "DataCombo", _
                          EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abKalaPhizikiStatus.KalaPhizikiStatusDs")
                    dcbKalaPhizikiStatus = .Component
                End With
                With .Add ("Auto->paGeneralStatusYN.GeneralStatusYNDs", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption ("abAnbarNoeRahgiri.Auto")
                End With
                .Add ("Meghdar", "TextBox")
                .Add ("RezDA", "CheckBox")
                .Add ("RezDB", , EnumFieldOptions.foHidden)
                .Add ("RezDC", , EnumFieldOptions.foHidden)
                .Add ("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add ("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add ("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add ("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
    End Sub

    Private Sub DVVi_abVw_AnbarNoeAnbar_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVVi_abVw_AnbarNoeAnbar.FillDetailsWithData
        Dim vSql_where As String

        If aFetched Then
            If DVVi_abVw_AnbarNoeAnbar.FlexGrid.Rows < 2 Then Exit Sub
            If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With DVVi_abVw_AnbarNoeAnbar.FlexGrid
                    pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                    If DVVi_abVw_AnbarNoeAnbar.FlexGrid.Rows > 1 Then
                        ' تهيه شرط ديتا ويو با توجه به اطلاعات گريد انبارها
                        vSql_where = " abAnbarNoeRahgiri.VahedeTejariSN = " & _
                                     .TextMatrix (.Row, .ColIndex ("VahedeTejariSN")) & _
                                     " AND abAnbarNoeRahgiri.AnbarSN = " & .TextMatrix (.Row, .ColIndex ("AnbarSN")) & _
                                     " AND abAnbarNoeRahgiri.NoeAnbarSN =  " & _
                                     .TextMatrix (.Row, .ColIndex ("NoeAnbarSN"))
                    Else
                        vSql_where = " 1 = 2 "
                    End If
                End With
                DVabAnbarNoeRahgiri.SQLWhere = vSql_where
                DVabAnbarNoeRahgiri.Refresh()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        End If
    End Sub

    Private Sub DVabAnbarNoeRahgiri_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVabAnbarNoeRahgiri.FillDetailsWithData
        ' کنترل ثبت وبروزآوري اطلاعات در گريد اطلاعات رويه رهگيري کالا در انبار
        With DVabAnbarNoeRahgiri
            If .DataRows = 1 Then
                .CommandEnabled (EnumCommands.cmAdd) = False
                ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
                .CommandEnabled (EnumCommands.cmEdit) = _
                    (gSM.TableAccessRight ("abAnbarNoeRahgiri") And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled (EnumCommands.cmDelete) = _
                    (gSM.TableAccessRight ("abAnbarNoeRahgiri") And EnumAccessRight.arDelete) <> 0
            Else
                ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
                .CommandEnabled (EnumCommands.cmAdd) = _
                    (gSM.TableAccessRight ("abAnbarNoeRahgiri") And EnumAccessRight.arInsert) <> 0
                .CommandEnabled (EnumCommands.cmEdit) = _
                    (gSM.TableAccessRight ("abAnbarNoeRahgiri") And EnumAccessRight.arUpdate) <> 0
                .CommandEnabled (EnumCommands.cmDelete) = _
                    (gSM.TableAccessRight ("abAnbarNoeRahgiri") And EnumAccessRight.arDelete) <> 0
            End If
        End With

    End Sub

    Private Function DVabAnbarNoeRahgiri_DataValidation() As String
        ' کنترل ثبت اطلاعات در ثبت رويه رهگيري هر انبار
        ' KalaPhizikiStatusSN
        '     1	كارت شناسايي	
        '     2	سري ساخت	
        ' Auto
        '   1	بله	
        '   2	خير	

        DVabAnbarNoeRahgiri_DataValidation = ""
        With DVabAnbarNoeRahgiri
            If _
                Val (DVabAnbarNoeRahgiri.FieldValue ("KalaPhizikiStatusSN")) = 1 And _
                DVabAnbarNoeRahgiri.FieldValue ("Meghdar") = "" Then
                DVabAnbarNoeRahgiri_DataValidation = "مقدار پيش فرض کد رهگيري مشخص نشده است"
                Exit Function
            End If

            If _
                Val (DVabAnbarNoeRahgiri.FieldValue ("KalaPhizikiStatusSN")) = 1 And _
                Val (DVabAnbarNoeRahgiri.FieldValue ("Auto")) = 2 Then
                DVabAnbarNoeRahgiri_DataValidation = "در حالت کد رهگيري ثابت اتوماتيک بايد حتما انتخاب شود"
                Exit Function
            End If
            If _
                Val (DVabAnbarNoeRahgiri.FieldValue ("KalaPhizikiStatusSN")) = 2 And _
                DVabAnbarNoeRahgiri.FieldValue ("Meghdar") <> "" Then
                DVabAnbarNoeRahgiri_DataValidation = "در حالت کد رهگيري متغير نبايد مقدار پيش فرض کد رهگيري وارد شود"
                Exit Function
            End If
        End With
    End Function

    Private Sub DVabAnbarNoeRahgiri_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVabAnbarNoeRahgiri.CommandClick
        Dim vmsg As String
        Select Case aCommand
            Case EnumCommands.cmSave
                ' کنترل خطا ورود اطلاعات
                vmsg = DVabAnbarNoeRahgiri_DataValidation()
                If Trim (vmsg) <> "" Then
                    aCancel = True
                    NetSql.Common.CSystem.MsgBox(vmsg)
                End If
        End Select
    End Sub

    Private Sub dcbKalaPhizikiStatus_Validated (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles dcbKalaPhizikiStatus.Validated
        With DVabAnbarNoeRahgiri
            If Val (.FieldValue ("KalaPhizikiStatusSN")) = 1 Then
                .FieldValue ("Auto") = 1
                .Fields ("Auto").LockInsert = True
                .Fields ("Auto").LockUpdate = True
                .Fields ("Meghdar").LockInsert = False
                .Fields ("Meghdar").LockUpdate = False

            End If

            If Val (.FieldValue ("KalaPhizikiStatusSN")) = 2 Then
                .FieldValue ("Auto") = 2
                .FieldValue ("Meghdar") = ""
                .Fields ("Auto").LockInsert = True
                .Fields ("Auto").LockUpdate = True
                .Fields ("Meghdar").LockInsert = True
                .Fields ("Meghdar").LockUpdate = True
            End If
        End With
    End Sub
End Class
