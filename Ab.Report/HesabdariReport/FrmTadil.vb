'Author :: زهره ايزدپناه
'CreateDate :: 86/04/13
'ModifiedDate::
'Description:: گزارش تعديل موجودي اول دوره
'System :: سيستم انبار


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum

Public Class FrmTadil
    Inherits Minoo.base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose (ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pnlg1 As System.Windows.Forms.Panel
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents pnln1 As System.Windows.Forms.Panel
    Friend WithEvents pnlc1 As System.Windows.Forms.Panel
    Public WithEvents btnShowHideCols As System.Windows.Forms.Button
    Public WithEvents btnOk As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlg1 = New System.Windows.Forms.Panel
        Me.btnExcel = New System.Windows.Forms.Button
        Me.pnln1 = New System.Windows.Forms.Panel
        Me.pnlc1 = New System.Windows.Forms.Panel
        Me.btnShowHideCols = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pnlg1
        '
        Me.pnlg1.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                   Or System.Windows.Forms.AnchorStyles.Left) _
                                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlg1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.pnlg1.Location = New System.Drawing.Point (2, 3)
        Me.pnlg1.Name = "pnlg1"
        Me.pnlg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlg1.Size = New System.Drawing.Size (948, 454)
        Me.pnlg1.TabIndex = 28
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Enabled = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = _
            New System.Drawing.Font ("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnExcel.Location = New System.Drawing.Point (571, 463)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExcel.Size = New System.Drawing.Size (80, 35)
        Me.btnExcel.TabIndex = 11
        Me.btnExcel.Text = "Excel"
        '
        'pnln1
        '
        Me.pnln1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnln1.Font = _
            New System.Drawing.Font ("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnln1.Location = New System.Drawing.Point (2, 463)
        Me.pnln1.Name = "pnln1"
        Me.pnln1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnln1.Size = New System.Drawing.Size (240, 37)
        Me.pnln1.TabIndex = 12
        '
        'pnlc1
        '
        Me.pnlc1.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlc1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.pnlc1.Location = New System.Drawing.Point (655, 462)
        Me.pnlc1.Name = "pnlc1"
        Me.pnlc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlc1.Size = New System.Drawing.Size (295, 37)
        Me.pnlc1.TabIndex = 10
        '
        'btnShowHideCols
        '
        Me.btnShowHideCols.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnShowHideCols.BackColor = System.Drawing.Color.Transparent
        Me.btnShowHideCols.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowHideCols.Enabled = False
        Me.btnShowHideCols.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowHideCols.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnShowHideCols.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowHideCols.Location = New System.Drawing.Point (488, 464)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size (80, 35)
        Me.btnShowHideCols.TabIndex = 33
        Me.btnShowHideCols.Text = "تنظيم"
        Me.btnShowHideCols.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Font = New System.Drawing.Font ("Tahoma", 9.75!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point (406, 464)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOk.Size = New System.Drawing.Size (80, 35)
        Me.btnOk.TabIndex = 34
        Me.btnOk.Text = "مشاهده"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'FrmTadil
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 15)
        Me.ClientSize = New System.Drawing.Size (952, 503)
        Me.Controls.Add (Me.btnOk)
        Me.Controls.Add (Me.btnShowHideCols)
        Me.Controls.Add (Me.pnlg1)
        Me.Controls.Add (Me.pnlc1)
        Me.Controls.Add (Me.btnExcel)
        Me.Controls.Add (Me.pnln1)
        Me.Name = "FrmTadil"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " سند تعديل انحراف نرخ استاندارد  ابتداي دوره موجوديهاي انبار"
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmTadil
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmTadil
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmTadil
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmTadil)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariabledDefinition"

    Private WithEvents MasterDataView As NetSql.View.CDataView
    Private LastHesabdariSalToDate As String

#End Region

    Private Sub FrmTadil_Load (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlg1.RightToLeft = RightToLeft.Yes

        MasterDataView = New NetSql.View.CDataView (cn)

        '//Initialize MasterDataView
        With MasterDataView
            .Init (pnlg1, , pnlc1, pnln1, _
                   EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdRefresh Or EnumButtonOptions.boCmdExit)
            .EditInGrid = False
            .Text = Me.Text
            .QueryName = "abQueryRpt_Tadil"
        End With
        '//Initialize MasterDataView

    End Sub


    Private Sub MasterDataView_GetGridProperties() Handles MasterDataView.GetGridProperties

        With MasterDataView

            '  With .Fields("MoinNo")
            '    .Caption = "کد معين"
            '  End With

            '  With .Fields("GoroohTafsiliNo1")
            '    .Caption = "کد گروه تفصيلي1"
            '  End With

            '  With .Fields("TafsiliNo1")
            '    .Caption = "تفصيلي1"
            '  End With

            '  With .Fields("GoroohTafsiliNo2")
            '    .Caption = "کد گروه تفصيلي2"
            '  End With

            '  With .Fields("TafsiliNo2")
            '    .Caption = "تفصيلي 2"
            '  End With

            '  With .Fields("GoroohTafsiliNo3")
            '    .Caption = "کد گروه تفصيلي 3"
            '  End With

            '  With .Fields("TafsiliNo3")
            '    .Caption = "تفصيلي 3"
            '  End With

            '  With .Fields("GoroohTafsiliNo4")
            '    .Caption = "کد گروه تفصيلي 4"
            '  End With

            '  With .Fields("TafsiliNo4")
            '    .Caption = "تفصيلي 4"
            '  End With

            '  With .Fields("GoroohTafsiliNo5")
            '    .Caption = "کد گروه تفصيلي 5"
            '  End With

            '  With .Fields("TafsiliNo5")
            '    .Caption = "تفصيلي 5"
            '  End With

            '  With .Fields("Sharh")
            '    .Caption = "شرح سند"
            '  End With

            '  With .Fields("Bed")
            '    .Caption = "بدهکار"
            '  End With

            '  With .Fields("Bes")
            '    .Caption = "بستانکار"
            '  End With

            '  With .Fields("PeigiriNo")
            '    .Caption = "شماره پيگيري"
            '  End With

            '  With .Fields("PeigiriDate")
            '    .Caption = "تاريخ پيگيري"
            '  End With

            '  With .Fields("Meghdar")
            '    .Caption = "مقدار/تعداد"
            '  End With

            '  With .Fields("MeghdarArz")
            '    .Caption = "مبلغ(ارز)"
            '  End With


            .FlexGrid.Subtotal(SubtotalSettings.Clear)
            .FlexGrid.SubtotalPosition = SubtotalPositionSettings.BelowData
            .FlexGrid.Subtotal(SubtotalSettings.Sum, -1, .FlexGrid.ColIndex("Bed"), "#,#", _
                                RGB(255, 255, 192), RGB(0, 0, 256), , "مجموع", 0, True)
            .FlexGrid.Subtotal(SubtotalSettings.Sum, -1, .FlexGrid.ColIndex("Bes"), "#,#", _
                                RGB(255, 255, 192), RGB(0, 0, 256), , "مجموع", 0, True)

        End With

    End Sub

    Private Sub btnExcel_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ' جهت تهيه مسير و نام فايل براي تبديل خروجي گزارش به فايل اکسل
        Dim vFileName As String

        vFileName = Functions.FTCommonFunctions.GetFileName ("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel (MasterDataView.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If

    End Sub

    Private Sub FrmTadil_Closed (ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Not MasterDataView Is Nothing Then
            MasterDataView.Done()
            MasterDataView = Nothing
        End If
    End Sub

    Private Sub btnShowHideCols_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnShowHideCols.Click
        Minoo.Grid.ShowFormSelectCols (MasterDataView, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer, Me.Name, Me)
    End Sub

    Private Sub btnOk_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        MasterDataView.DataSource = _
            cn.ExecuteQuery ( _
                             "_abSpr_Tadil " + CStr (gAnbarSN) + ",'" + Trim (gHesabdariSalFDate) + "','" + _
                             Trim (gHesabdariSalTDate) + "'")
        MasterDataView.Refresh()

        Me.Cursor = System.Windows.Forms.Cursors.Default()

        btnShowHideCols.Enabled = True
        btnExcel.Enabled = True

    End Sub
End Class
