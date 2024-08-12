' OK
'Author ::سيد محمود قاسمي 
'CreateDate ::  1383/03/04
'ModifiedDate::
'Description::  ماهيت كالا
' ثبت و بروزآوري اطلاعات ماهيت کالا در هر واحد تجاري 
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Public Class FrmMahiatKalaVahedeTejari
    Inherits Minoo.Base.FTFormBaseSingleTable

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
        'This form is an MDI child.
        'This code simulates the VB6 
        ' functionality of automatically
        ' loading and showing an MDI
        ' child's parent.
        'The MDI form in the VB6 project had its
        'AutoShowChildren property set to True
        'To simulate the VB6 behavior, we need to
        'automatically Show the form whenever it
        'is loaded.  If you do not want this behavior
        'then delete the following line of code
        'UPGRADE_NOTE: Remove the next line of code to stop form from automatically showing. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2018"'
    End Sub

    'Form overrides dispose to clean up the component list.
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnEslaheMahiat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents dcbMahiatKalaSN As New NetSql.Components.DataCombo

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEslaheMahiat = New System.Windows.Forms.Button
        Me.dcbMahiatKalaSN = New NetSql.Components.DataCombo(Me.components)
        Me.TabP1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        '
        'TabP1
        '
        Me.TabP1.Controls.Add(Me.Panel1)
        Me.TabP1.Name = "TabP1"
        Me.TabP1.Size = New System.Drawing.Size(800, 471)
        Me.TabP1.Text = "ماهيت كالا"
        Me.TabP1.Controls.SetChildIndex(Me.Panel1, 0)
        Me.TabP1.Controls.SetChildIndex(Me.pnlG, 0)
        Me.TabP1.Controls.SetChildIndex(Me.pnlC, 0)
        Me.TabP1.Controls.SetChildIndex(Me.pnlN, 0)
        '
        'pnlN
        '
        Me.pnlN.Location = New System.Drawing.Point(0, 397)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.Size = New System.Drawing.Size(371, 32)
        Me.pnlN.TabIndex = 2
        '
        'pnlG
        '
        Me.pnlG.Font = _
            New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlG.Name = "pnlG"
        Me.pnlG.Size = New System.Drawing.Size(795, 386)
        Me.pnlG.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Size = New System.Drawing.Size(808, 497)
        '
        'pnlC
        '
        Me.pnlC.Location = New System.Drawing.Point(375, 397)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = _
            CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),  _
                System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEslaheMahiat)
        Me.Panel1.Controls.Add(Me.dcbMahiatKalaSN)
        Me.Panel1.Location = New System.Drawing.Point(318, 432)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(390, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ماهيت كالا"
        '
        'btnEslaheMahiat
        '
        Me.btnEslaheMahiat.BackColor = System.Drawing.SystemColors.Control
        Me.btnEslaheMahiat.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEslaheMahiat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEslaheMahiat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEslaheMahiat.Font = _
            New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnEslaheMahiat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEslaheMahiat.Location = New System.Drawing.Point(12, 6)
        Me.btnEslaheMahiat.Name = "btnEslaheMahiat"
        Me.btnEslaheMahiat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnEslaheMahiat.Size = New System.Drawing.Size(84, 21)
        Me.btnEslaheMahiat.TabIndex = 1
        Me.btnEslaheMahiat.Text = "اصلاح ماهيت"
        '
        'dcbMahiatKalaSN
        '
        Me.dcbMahiatKalaSN.AutoSelectFirst = False
        Me.dcbMahiatKalaSN.BackColor = System.Drawing.Color.White
        Me.dcbMahiatKalaSN.BoundText = Nothing
        Me.dcbMahiatKalaSN.DisplayText = ""
        Me.dcbMahiatKalaSN.LateBindingTop = "100"
        Me.dcbMahiatKalaSN.Location = New System.Drawing.Point(116, 6)
        Me.dcbMahiatKalaSN.MemFilter = ""
        Me.dcbMahiatKalaSN.Name = "dcbMahiatKalaSN"
        Me.dcbMahiatKalaSN.Size = New System.Drawing.Size(265, 21)
        Me.dcbMahiatKalaSN.Source = Nothing
        Me.dcbMahiatKalaSN.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.dcbMahiatKalaSN.TabIndex = 0
        '
        'FrmMahiatKalaVahedeTejari
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(808, 497)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Location = New System.Drawing.Point(11, 65)
        Me.Name = "FrmMahiatKalaVahedeTejari"
        Me.Text = "ماهيت كالا"
        Me.TabP1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmMahiatKalaVahedeTejari
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmMahiatKalaVahedeTejari
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMahiatKalaVahedeTejari
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMahiatKalaVahedeTejari)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  ماهيت کالا در هر واحدتجاري تعريف شده است
    Private WithEvents DV_abMahiatKalaVahedeTejari As CDataView

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private dbcKalaSN As NetSql.Components.DataCombo

    Private Sub DV_abMahiatKalaVahedeTejari_AfterCommandClick(ByVal aCommand As EnumCommands) _
        Handles DV_abMahiatKalaVahedeTejari.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                DV_abMahiatKalaVahedeTejari.Fields("VahedeTejariSN").Value = gVahedeTejariSN
            Case EnumCommands.cmEdit
        End Select
    End Sub

    Private Sub FrmMahiatKalaVahedeTejari_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Call InitDataView()
        If DV_abMahiatKalaVahedeTejari.DataRows >= 1 Then
            DV_abMahiatKalaVahedeTejari.FlexGrid.Row = 1
        End If
        Dim vSql As String
        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT MahiatKalaSN, MahiatKalaDS From paMahiatKala "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbMahiatKalaSN.Bind(cn, vSql, "MahiatKalaSN", "MahiatKalaDS")
    End Sub

    Private Sub FrmMahiatKalaVahedeTejari_Closed(ByVal eventSender As System.Object, _
                                                  ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        DV_abMahiatKalaVahedeTejari.Done()
        DV_abMahiatKalaVahedeTejari = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vSql_where As String

        DV_abMahiatKalaVahedeTejari = New CDataView(cn)
        With DV_abMahiatKalaVahedeTejari
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                       Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter)
            .TableName = "abMahiatKalaVahedeTejari"
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            ' اعمال شرط براي اطلاعات واحد تجاري انبار جاري
            vSql_where = " abMahiatKalaVahedeTejari.VahedeTejariSN = " & gVahedeTejariSN
            .SQLWhere = vSql_where
            .SQLOrderBy = " pakala.KalaNO , pakala.MahiatkalaSN "
            With .Fields
                With .Add("MahiatKalaVahedeTejariSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                With .Add("VahedeTejariSN", "DataCombo <DISABLED>", EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                End With
                With .Add("KalaSN->{KalaNO + ' _ ' + KalaDS} AS KalaSN", "DataCombo")
                    dbcKalaSN = .Component
                    .Caption = cn.FieldCaption("paKala.KalaDS")
                    dbcKalaSN.LateBinding = True
                End With
                .Add("MahiatKalaSN", "DataCombo", EnumFieldOptions.foDefault)
                .Add("PayeSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("TafsiliSN", "TextBox", EnumFieldOptions.foHidden)
                .Add("TafsiliSN1", "TextBox", EnumFieldOptions.foHidden)
                .Add("UnqStr", "TextBox", EnumFieldOptions.foHidden)
                With .Add("UserID_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", "TextBox", EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With

    End Sub

    Private Sub DV_abMahiatKalaVahedeTejari_GetGridProperties() Handles DV_abMahiatKalaVahedeTejari.GetGridProperties
        ' امکان انتخاب گروهي فعال گردد
        ' جهت استفاده از انتخاب گروهي در خروجي گزارش
        With DV_abMahiatKalaVahedeTejari.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub

    Private Sub btnEslaheMahiat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnEslaheMahiat.Click
        ' اصلاح ماهيت
        ' باتوجه به انتخاب انجام شده در کامبو و رکوردهاي انتخاب شده اين متد رکوردها را بروزآوري ميکند
        Dim i As Short
        Dim vSN As Decimal
        Dim var_KalaSN() As Decimal
        Dim vCount_KalaSN As Short
        Dim vStrQuery As String

        If (Not DV_abMahiatKalaVahedeTejari.CommandEnabled(EnumCommands.cmEdit)) _
           Or (DV_abMahiatKalaVahedeTejari.State = EnumDataViewState.bsEdit) _
           Or (DV_abMahiatKalaVahedeTejari.State = EnumDataViewState.bsAdd) Then

            Exit Sub
        End If
        If Not (dcbMahiatKalaSN.BoundText <> 0 And dcbMahiatKalaSN.MatchedWithList) Then
            NetSql.Common.CSystem.MsgBox("ماهيت جديد كالا مشخص نشده است")
            Exit Sub
        End If
        If NetSql.Common.CSystem.MsgBox("آيا ماهيت كالاهاي مشخص شده اصلاح گردد ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                                                                 + MsgBoxStyle.DefaultButton2 + _
                                                                 MsgBoxStyle.MsgBoxRtlReading _
                                                                 + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes _
            Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DV_abMahiatKalaVahedeTejari.FlexGrid
                vCount_KalaSN = .SelectedRows
                ReDim var_KalaSN(vCount_KalaSN)
                For i = 0 To vCount_KalaSN - 1
                    var_KalaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("MahiatKalaVahedeTejariSN")))
                Next i
            End With
            For i = 0 To vCount_KalaSN - 1
                vSN = Val(var_KalaSN(i))
                If vSN <> 0 Then
                    vStrQuery = " Update abMahiatKalaVahedeTejari Set MahiatKalaSN = " & dcbMahiatKalaSN.BoundText _
                                & " Where  MahiatKalaVahedeTejariSN  = " & vSN

                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    cn.ExecuteNoneQuery(vStrQuery)
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
            Next
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        DV_abMahiatKalaVahedeTejari.Refresh()

    End Sub

    Private Sub FrmMahiatKalaVahedeTejari_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles MyBase.KeyUp
        ' کنترل کليد اف يک براي راهنماي فرم
        Dim vKeyCode As Short = e.KeyCode
        If vKeyCode = System.Windows.Forms.Keys.F1 Then
            Help.ShowHelp(Me, gHelpFileName, "HelpMahiatKala.htm")
            DBLog.WriteLOG("Help", 0, , "HelpSection", "HelpMahiatKala.htm", Me.Name, Me.Text)
        End If
    End Sub
End Class
