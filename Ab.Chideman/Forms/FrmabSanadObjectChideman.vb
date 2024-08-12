'Author ::دهقانی 
'CreateDate :: 1393/04/21
'Description:: چیدمان آبجکت های فرم های مرتبط با اسناد انبار
'System ::انبار

Public Class FrmabSanadObjectChideman
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

    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlGridDet1 As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationDet1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Public WithEvents PanelGridObject As System.Windows.Forms.Panel
    Public WithEvents PanelObjectCommand As System.Windows.Forms.Panel
    Public WithEvents PanelObjectNavigation As System.Windows.Forms.Panel
    Public WithEvents pnlCommandDet1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCommandMaster = New System.Windows.Forms.Panel()
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel()
        Me.pnlGridMaster = New System.Windows.Forms.Panel()
        Me.pnlGridDet1 = New System.Windows.Forms.Panel()
        Me.pnlNavigationDet1 = New System.Windows.Forms.Panel()
        Me.pnlCommandDet1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PanelGridObject = New System.Windows.Forms.Panel()
        Me.PanelObjectCommand = New System.Windows.Forms.Panel()
        Me.PanelObjectNavigation = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point(240, 302)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size(383, 38)
        Me.pnlCommandMaster.TabIndex = 9
        Me.pnlCommandMaster.Tag = ""
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point(3, 302)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size(187, 38)
        Me.pnlNavigationMaster.TabIndex = 8
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point(3, 3)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size(620, 297)
        Me.pnlGridMaster.TabIndex = 0
        '
        'pnlGridDet1
        '
        Me.pnlGridDet1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlGridDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridDet1.Location = New System.Drawing.Point(3, 3)
        Me.pnlGridDet1.Name = "pnlGridDet1"
        Me.pnlGridDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridDet1.Size = New System.Drawing.Size(619, 284)
        Me.pnlGridDet1.TabIndex = 7
        '
        'pnlNavigationDet1
        '
        Me.pnlNavigationDet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlNavigationDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationDet1.Location = New System.Drawing.Point(3, 288)
        Me.pnlNavigationDet1.Name = "pnlNavigationDet1"
        Me.pnlNavigationDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationDet1.Size = New System.Drawing.Size(187, 38)
        Me.pnlNavigationDet1.TabIndex = 6
        '
        'pnlCommandDet1
        '
        Me.pnlCommandDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCommandDet1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandDet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandDet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandDet1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlCommandDet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandDet1.Location = New System.Drawing.Point(240, 288)
        Me.pnlCommandDet1.Name = "pnlCommandDet1"
        Me.pnlCommandDet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandDet1.Size = New System.Drawing.Size(383, 38)
        Me.pnlCommandDet1.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlGridMaster)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlCommandMaster)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlNavigationMaster)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlGridDet1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCommandDet1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlNavigationDet1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(626, 680)
        Me.SplitContainer1.SplitterDistance = 345
        Me.SplitContainer1.TabIndex = 10
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelGridObject)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelObjectCommand)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelObjectNavigation)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(923, 680)
        Me.SplitContainer2.SplitterDistance = 293
        Me.SplitContainer2.TabIndex = 11
        '
        'PanelGridObject
        '
        Me.PanelGridObject.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGridObject.BackColor = System.Drawing.SystemColors.Control
        Me.PanelGridObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelGridObject.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelGridObject.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PanelGridObject.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelGridObject.Location = New System.Drawing.Point(3, 3)
        Me.PanelGridObject.Name = "PanelGridObject"
        Me.PanelGridObject.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelGridObject.Size = New System.Drawing.Size(287, 633)
        Me.PanelGridObject.TabIndex = 10
        '
        'PanelObjectCommand
        '
        Me.PanelObjectCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelObjectCommand.BackColor = System.Drawing.SystemColors.Control
        Me.PanelObjectCommand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelObjectCommand.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelObjectCommand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PanelObjectCommand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelObjectCommand.Location = New System.Drawing.Point(153, 642)
        Me.PanelObjectCommand.Name = "PanelObjectCommand"
        Me.PanelObjectCommand.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelObjectCommand.Size = New System.Drawing.Size(137, 33)
        Me.PanelObjectCommand.TabIndex = 12
        Me.PanelObjectCommand.Tag = ""
        '
        'PanelObjectNavigation
        '
        Me.PanelObjectNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelObjectNavigation.BackColor = System.Drawing.SystemColors.Control
        Me.PanelObjectNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelObjectNavigation.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelObjectNavigation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PanelObjectNavigation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelObjectNavigation.Location = New System.Drawing.Point(3, 642)
        Me.PanelObjectNavigation.Name = "PanelObjectNavigation"
        Me.PanelObjectNavigation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelObjectNavigation.Size = New System.Drawing.Size(144, 33)
        Me.PanelObjectNavigation.TabIndex = 11
        '
        'FrmabSanadObjectChideman
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(923, 680)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "FrmabSanadObjectChideman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تنظیمات آبجکت های اسناد انبار"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabSanadObjectChideman
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabSanadObjectChideman
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabSanadObjectChideman
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmabSanadObjectChideman)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region


    Private WithEvents DVabTarakonesh As CDataView
    Private WithEvents DVabSanadObject As CDataView
    Private WithEvents DVabSanadObjectDetail As CDataView

    Private WithEvents dcbAnbar As NetSql.Components.DataCombo

    Private Sub FrmabSanadObjectChideman_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitDataView()
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي

        DVabTarakonesh = New CDataView(cn)
        With DVabTarakonesh
            .Init(pnlGridMaster, , pnlCommandMaster, pnlNavigationMaster, EnumButtonOptions.boCmdExit Or _
                                                                           EnumButtonOptions.boCmdPrint Or _
                                                                           EnumButtonOptions.boCmdFilter Or _
                                                                           EnumButtonOptions.boCmdFind)
            .TableName = "abTarakonesh"


            .Text = Me.Text
            .EditInGrid = False
            .SQLOrderBy = "TarakoneshSN"

            With .Fields
                With .Add("TarakoneshSN", "TextBox")
                    .Caption = "کد تراکنش"
                End With

                With .Add("TarakoneshDS", "TextBox")
                    .Caption = "نام تراکنش"
                End With
            End With
        End With


        DVabSanadObjectDetail = New CDataView(cn)
        With DVabSanadObjectDetail
            .Init(pnlGridDet1, , pnlCommandDet1, pnlNavigationDet1, EnumButtonOptions.boCmdModify _
                                                                     Or EnumButtonOptions.boCmdPrint Or _
                                                                     EnumButtonOptions.boCmdFind)
            .TableName = "abSanadObjectDetail"


            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abSanadObject", "ObjectSN", "ObjectSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeTejari", "VahedeTejariSN", "VahedeTejariSN")
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abanbar", "anbarSN", "anbarSN")

            '.AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True

            With .Fields
                With .Add("SanadObjectDetailSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("VahedeTejariSN->PavahedeTejari.VahedeTejariDS", "DataCombo", EnumFieldOptions.foDefault)
                    '.DefaultValue = gVahedeTejariSN
                    .ComboWhereCondition = "VahedeTejariStatus =1 and OzveGorooh =1"
                End With
                With .Add("anbarSN->abanbar.anbarDS", "DataCombo", EnumFieldOptions.foDefault)
                    dcbAnbar = .Component
                End With
                With .Add("TarakoneshSN", "TextBox", EnumFieldOptions.foHidden)
                    .Caption = "کد تراکنش"
                    .ReadOnly = True
                End With
                With .Add("objectSN->abSanadObject.ObjectDS", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "نام آبجکت"
                End With
                With .Add("abSanadObject.ObjectName", "textbox", EnumFieldOptions.foDefault)
                    .Caption = "شرح آبجکت"
                    .ReadOnly = True
                End With
                With .Add("Visibile", "CheckBox")
                    .Caption = "نمایش"
                    .DefaultValue = 1
                End With
                With .Add("Enable", "CheckBox")
                    .Caption = "فعال"
                    .DefaultValue = 1
                End With
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Parent = DVabTarakonesh
        End With

        DVabSanadObject = New CDataView(cn)
        With DVabSanadObject
            .Init(PanelGridObject, , PanelObjectCommand, PanelObjectNavigation, EnumButtonOptions.boCmdModify _
                                                                                Or EnumButtonOptions.boCmdPrint Or _
                                                                                EnumButtonOptions.boCmdFind)
            .TableName = "abSanadObject"
            .EditInGrid = True

            With .Fields
                With .Add("ObjectSN", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = 0
                End With

                With .Add("ObjectDS", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "نام آبجکت"
                End With
                With .Add("ObjectName", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "شرح آبجکت"
                End With

                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
        End With

        DVabTarakonesh.Refresh()
        DVabSanadObjectDetail.Refresh()
        DVabSanadObject.Refresh()

    End Sub

    Private Sub DVabSanadObject_FillDetailsWithData(aClip As Object, aFetched As Boolean) _
        Handles DVabTarakonesh.FillDetailsWithData

        Dim TarakoneshSN As Object = DVabTarakonesh.Fields("TarakoneshSN").Value
        If Not TarakoneshSN Is Nothing Then
            If CStr(TarakoneshSN) <> "" Then
                DVabSanadObjectDetail.SQLWhere = "TarakoneshSN = " & CStr(TarakoneshSN) & ""
                DVabSanadObjectDetail.Refresh()
            End If
        End If

    End Sub

    Private Sub dcbAnbar_Enter(sender As Object, e As System.EventArgs) Handles dcbAnbar.Enter

        With DVabSanadObjectDetail.Fields("AnbarSN")
            .ComboWhereCondition = "VahedetejariSN=" & DVabSanadObjectDetail.Fields("VahedetejariSN").Value
            .RefreshCombo()
        End With

    End Sub

End Class
