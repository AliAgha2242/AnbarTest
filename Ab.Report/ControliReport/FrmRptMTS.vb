'Programmer ::Zohreh IZadpanah 
'CreateDate ::  1386/06/06
'ModifiedDate::
'Description:: گزارش Mojoodi انبار 
'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Imports VB = Microsoft.VisualBasic

Public Class FrmRptMTS
    Inherits Minoo.Base.FTBaseForm

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
    Public WithEvents Old As System.Windows.Forms.Panel
    Friend WithEvents PnlG As System.Windows.Forms.Panel
    Public WithEvents btnShowHideCols As System.Windows.Forms.Button
    Public WithEvents btnExcel As System.Windows.Forms.Button
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents BtnOk As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtToDate As NetSql.Components.TextBox
    Friend WithEvents lblTDate As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Old = New System.Windows.Forms.Panel
        Me.PnlG = New System.Windows.Forms.Panel
        Me.btnShowHideCols = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.pnlC = New System.Windows.Forms.Panel
        Me.pnlN = New System.Windows.Forms.Panel
        Me.Frame1 = New System.Windows.Forms.Panel
        Me.BtnOk = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.txtToDate = New NetSql.Components.TextBox (Me.components)
        Me.lblTDate = New System.Windows.Forms.Label
        Me.Old.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Old
        '
        Me.Old.BackColor = System.Drawing.SystemColors.Control
        Me.Old.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Old.Controls.Add (Me.PnlG)
        Me.Old.Controls.Add (Me.btnShowHideCols)
        Me.Old.Controls.Add (Me.btnExcel)
        Me.Old.Controls.Add (Me.pnlC)
        Me.Old.Controls.Add (Me.pnlN)
        Me.Old.Cursor = System.Windows.Forms.Cursors.Default
        Me.Old.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Old.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Old.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Old.Location = New System.Drawing.Point (0, 0)
        Me.Old.Name = "Old"
        Me.Old.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Old.Size = New System.Drawing.Size (952, 503)
        Me.Old.TabIndex = 4
        '
        'PnlG
        '
        Me.PnlG.Anchor = CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                  Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG.Location = New System.Drawing.Point (1, 8)
        Me.PnlG.Name = "PnlG"
        Me.PnlG.Size = New System.Drawing.Size (946, 448)
        Me.PnlG.TabIndex = 7
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
        Me.btnShowHideCols.Location = New System.Drawing.Point (491, 461)
        Me.btnShowHideCols.Name = "btnShowHideCols"
        Me.btnShowHideCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowHideCols.Size = New System.Drawing.Size (51, 35)
        Me.btnShowHideCols.TabIndex = 1
        Me.btnShowHideCols.Text = "تنظيم"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.Enabled = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExcel.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point (544, 461)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExcel.Size = New System.Drawing.Size (51, 35)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "EXCEL"
        '
        'pnlC
        '
        Me.pnlC.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point (651, 460)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size (295, 37)
        Me.pnlC.TabIndex = 2
        '
        'pnlN
        '
        Me.pnlN.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point (0, 459)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size (240, 37)
        Me.pnlN.TabIndex = 4
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frame1.Controls.Add (Me.txtToDate)
        Me.Frame1.Controls.Add (Me.lblTDate)
        Me.Frame1.Controls.Add (Me.BtnOk)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point (0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size (952, 57)
        Me.Frame1.TabIndex = 3
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.Transparent
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOk.Font = New System.Drawing.Font ("Tahoma", 9.75!)
        Me.BtnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOk.Location = New System.Drawing.Point (8, 8)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOk.Size = New System.Drawing.Size (68, 35)
        Me.BtnOk.TabIndex = 5
        Me.BtnOk.Text = "مشاهده"
        '
        'txtToDate
        '
        Me.txtToDate.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.txtToDate.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.txtToDate.Location = New System.Drawing.Point (800, 12)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToDate.Size = New System.Drawing.Size (84, 22)
        Me.txtToDate.TabIndex = 25
        Me.txtToDate.Text = ""
        '
        'lblTDate
        '
        Me.lblTDate.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.lblTDate.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.lblTDate.ForeColor = System.Drawing.Color.Black
        Me.lblTDate.Location = New System.Drawing.Point (856, 16)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size (72, 14)
        Me.lblTDate.TabIndex = 26
        Me.lblTDate.Text = "تا تاريخ:"
        '
        'FrmRptMTS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 15)
        Me.ClientSize = New System.Drawing.Size (952, 503)
        Me.Controls.Add (Me.Frame1)
        Me.Controls.Add (Me.Old)
        Me.Name = "FrmRptMTS"
        Me.Text = "گزارش حداقل موجودي"
        Me.Old.ResumeLayout (False)
        Me.Frame1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region


#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptMTS
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptMTS
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptMTS
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmRptMTS)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private WithEvents MasterDataView As CDataView
    Private dclTdate As NetSql.components.CDateCtrl

    Private Sub FrmMojoodiNew_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        '//
        dclTdate = New NetSql.components.CDateCtrl (tp)
        dclTdate.TextBox = txtToDate
        dclTdate.DateFormat = NetSql.Common.CShamsiDate.EnumDateFormat.dfDefault
        dclTdate.Text = NetSql.Common.CShamsiDate.MiladiToShamsi (Today, dclTdate.DateFormat)
        '//

        MasterDataView = New CDataView (cn)
        With MasterDataView
            .Init (PnlG, , pnlC, pnlN, gEnumButtonOptionsReports)
            .FlexGrid.SelectionMode = SelModeSettings.flexSelectionListBox
            .FlexGrid.AllowSelection = True

        End With

    End Sub

    Private Sub FrmMojoodiNew_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed

        MasterDataView.Done()
        MasterDataView = Nothing

    End Sub

    Private Sub cmdShowHideCols_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnShowHideCols.Click
        ' جهت استفاده از کليد تنظيم نمايش ستون هاي گريد اطلاعات
        Dim vstrNoeAnbars As Object
        Minoo.Grid.ShowFormSelectCols(MasterDataView, tp, gSM.UserID, VB6.GetEXEName, gSM.IsProgrammer, _
                                       Me.Name + "/" + vstrNoeAnbars, Me)
    End Sub


    Private Sub MasterDataVIew_GetGridProperties() Handles MasterDataView.GetGridProperties

        With MasterDataView
            .FlexGrid.SelectionMode = SelModeSettings.flexSelectionListBox
            .FlexGrid.AllowSelection = True
        End With
    End Sub


    Private Sub MasterDataVIew_CommandClick (ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles MasterDataView.CommandClick

        Select Case aCommand
            Case EnumCommands.cmRefresh

                BtnOk_Click (Me, New System.EventArgs)

        End Select


    End Sub

    Private Sub BtnOk_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        System.Windows.Forms.Application.DoEvents()

        '//Local Variables Definition

        Dim vErrMsg As String
        '//Local Variables Definition

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش

        If Trim (txtToDate.Text) = "" Then

            vErrMsg = vErrMsg & Chr (13) & "تا تاريخ مشخص نشده است"
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            With MasterDataView
                .AutoFetchCurrentRow = False
                ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                .QueryName = "abQuery_MTS"

                .DataSource = cn.ExecuteQuery ("_abSpr_MTS '" + gHesabdariSalFDate + "','" + dclTdate.Value + "'")

                Minoo.Grid.LoadColsSetting (MasterDataView, Me.Name, tp, gSM.UserID, VB6.GetEXEName)

            End With

            btnExcel.Enabled = True
            btnShowHideCols.Enabled = True
            Me.Cursor = System.Windows.Forms.Cursors.Default()

        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OKOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If

    End Sub

    Private Sub btnExcel_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Minoo.Applications.Anbar.Common.CSharedItem.gSaveToEXCEL (MasterDataView)
    End Sub
End Class
