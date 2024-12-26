' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/02/21
'ModifiedDate::
'Description::  تراكنشهاي هر انبار 
' ثبت و بروزآوري تراکنش هاي هر انبار
'System ::انبار

Option Strict Off
Option Explicit On

Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

Imports VB = Microsoft.VisualBasic


Friend Class FrmAnbarTarakonesh
    Inherits Minoo.Base.FTFormBaseMasterDetail
    'Inherits System.Windows.Forms.Form


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

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents picDetDet1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tab2.SuspendLayout()
        Me.Tabp2.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tabp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab2
        '
        Me.Tab2.Location = New System.Drawing.Point(0, 322)
        Me.Tab2.Size = New System.Drawing.Size(902, 252)
        '
        'Tabp2
        '
        Me.Tabp2.Size = New System.Drawing.Size(894, 225)
        '
        'pnlN2
        '
        Me.pnlN2.Size = New System.Drawing.Size(646, 35)
        '
        'pnlC2
        '
        Me.pnlC2.Location = New System.Drawing.Point(650, 188)
        Me.pnlC2.Size = New System.Drawing.Size(241, 35)
        '
        'pnlG2
        '
        Me.pnlG2.Size = New System.Drawing.Size(894, 187)
        '
        'Tab1
        '
        Me.Tab1.Size = New System.Drawing.Size(902, 317)
        '
        'Tabp1
        '
        Me.Tabp1.Size = New System.Drawing.Size(894, 290)
        '
        'pnlN1
        '
        Me.pnlN1.Location = New System.Drawing.Point(0, 252)
        Me.pnlN1.Size = New System.Drawing.Size(646, 35)
        '
        'pnlC1
        '
        Me.pnlC1.Location = New System.Drawing.Point(650, 252)
        Me.pnlC1.Size = New System.Drawing.Size(241, 35)
        '
        'pnlG1
        '
        Me.pnlG1.Size = New System.Drawing.Size(891, 246)
        '
        'FrmAnbarTarakonesh
        '
        Me.ClientSize = New System.Drawing.Size(902, 574)
        Me.Name = "FrmAnbarTarakonesh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tab2.ResumeLayout(False)
        Me.Tabp2.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tabp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmAnbarTarakonesh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmAnbarTarakonesh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAnbarTarakonesh()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As FrmAnbarTarakonesh)
            m_vb6FormDefInstance = value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  انبارها تعريف شده است
    Private WithEvents DVabVw_abAnbarabNoeAnbar_Tran As CDataView

    'يك ديتا ويو از نوع ابزار جهت نمايش  تراکنش هاي هر انبار تعريف شده است
    Private WithEvents DVaAnbarTarakonesh As CDataView

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFLX_aAnbaraNoeAnbar As AxVSFlexGrid

    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents dcbTarakoneshSN As NetSql.Components.DataCombo

    ' جهت استفاده در عمليات پشتيباني رويدادهاي گريد
    Private pRowNomber As Short

    Private Sub dcbTarakoneshSN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles dcbTarakoneshSN.Enter
        ' کنترل روي تراکنشهاي قبلا تعريف شده روي اين انبار
        If Val(DVaAnbarTarakonesh.Fields("NoeAnbarSN").Value) <> 0 Then
            With DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid
                DVaAnbarTarakonesh.Fields("TarakoneshSN").ComboWhereCondition =
                    " TarakoneshSN NOT IN (SELECT TarakoneshSN From abAnbarTarakonesh Where abAnbarTarakonesh.AnbarSN = " &
                    .TextMatrix(.Row, .ColIndex("HiddenAnbarSN")) &
                    " AND abAnbarTarakonesh.NoeAnbarSN =  " &
                    CStr(Val(DVaAnbarTarakonesh.Fields("NoeAnbarSN").Value)) & " )  "
                DVaAnbarTarakonesh.Fields("TarakoneshSN").ComboOrderBy = " TartibA "
            End With
        Else
            DVaAnbarTarakonesh.Fields("TarakoneshSN").ComboWhereCondition = " 1 = 2 "
        End If
        DVaAnbarTarakonesh.Fields("TarakoneshSN").RefreshCombo()
    End Sub

    Private Sub DVaAnbarTarakonesh_AfterCommandClick(ByVal aCommand As EnumCommands) _
        Handles DVaAnbarTarakonesh.AfterCommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                ' مقداردهي فيلدهاي مورد نياز با توجه به گريد انبارها
                With DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid
                    DVaAnbarTarakonesh.Fields("AnbarSN").Value = .TextMatrix(.Row, .ColIndex("HiddenAnbarSN"))
                    DVaAnbarTarakonesh.Fields("VahedeTejariSN").Value =
                        .TextMatrix(.Row, .ColIndex("HiddenVahedeTejariSN"))
                End With
                If DVaAnbarTarakonesh.DataRows > 0 Then
                    DVaAnbarTarakonesh.Fields("NoeAnbarSN").Value =
                        DVaAnbarTarakonesh.FlexGrid.TextMatrix(1, DVaAnbarTarakonesh.FlexGrid.ColIndex("NoeAnbarSN"))
                End If
        End Select
    End Sub

    Private Sub DVaAnbarTarakonesh_CommandClick(ByVal aCommand As EnumCommands, ByRef aCancel As Boolean) _
        Handles DVaAnbarTarakonesh.CommandClick
        Select Case aCommand
            Case EnumCommands.cmAdd
                ' کنترل ثبت نوع انبار
                If DVaAnbarTarakonesh.DataRows > 0 Then
                    DVaAnbarTarakonesh.Fields("NoeAnbarSN").ReadOnly = True
                    DVaAnbarTarakonesh.Fields("NoeAnbarSN").Component.Enabled = False
                Else
                    DVaAnbarTarakonesh.Fields("NoeAnbarSN").ReadOnly = False
                    DVaAnbarTarakonesh.Fields("NoeAnbarSN").Component.Enabled = True
                End If
            Case Else
                DVaAnbarTarakonesh.Fields("TarakoneshSN").ComboWhereCondition = ""
                DVaAnbarTarakonesh.Fields("TarakoneshSN").RefreshCombo()
        End Select

    End Sub

    Private Sub pFLX_aAnbaraNoeAnbar_RowColChange(ByVal eventSender As System.Object,
                                                   ByVal eventArgs As System.EventArgs) _
        Handles pFLX_aAnbaraNoeAnbar.RowColChange
        Dim vSql_where As String
        ' با توجه به اطلاعات گريد انبارها گريد تراکنشها بروز مي گردد
        If DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid.Rows < 2 Then Exit Sub
        If pRowNomber <> pFLX_aAnbaraNoeAnbar.Row Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            With DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid
                pRowNomber = pFLX_aAnbaraNoeAnbar.Row
                If DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid.Rows > 1 Then
                    vSql_where = " abAnbarTarakonesh.AnbarSN = " & .TextMatrix(.Row, .ColIndex("HiddenAnbarSN"))
                Else
                    vSql_where = " 1 = 2 "
                End If

            End With
            DVaAnbarTarakonesh.SQLWhere = vSql_where
            DVaAnbarTarakonesh.Refresh()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub FrmAnbarTarakonesh_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load

        Call InitDataView()
    End Sub

    Private Sub FrmAnbarTarakonesh_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVabVw_abAnbarabNoeAnbar_Tran.Done()
        DVabVw_abAnbarabNoeAnbar_Tran = Nothing
        DVaAnbarTarakonesh.Done()
        DVaAnbarTarakonesh = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        Dim vSql_where As String
        DVabVw_abAnbarabNoeAnbar_Tran = New CDataView(cn)
        With DVabVw_abAnbarabNoeAnbar_Tran
            .Init(pnlG1, , pnlC1, pnlN1, EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdFilter _
                                          Or EnumButtonOptions.boCmdFind Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abVw_abAnbarabNoeAnbar_Tran"
            .Text = Me.Text
            .SQLOrderBy = " HiddenVahedeTejariSN "
            If cn.SQLServerName.ToUpper <> "BIS" Then
                If gIsTajmie = 1 Then
                    .SQLWhere = " HiddenVahedeTejariSN =  " & CStr(gVahedeTejariSN)
                Else
                    .SQLWhere = " HiddenAnbarSN = " & CStr(gAnbarSN)
                End If
            End If

            .Fields.AddAllFields()
            .AccessRight = EnumAccessRight.arView
            .Refresh()
        End With
        pFLX_aAnbaraNoeAnbar = DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid

        With DVabVw_abAnbarabNoeAnbar_Tran.FlexGrid
            If .Rows > 1 Then
                pRowNomber = 1
                vSql_where = " abAnbarTarakonesh.AnbarSN = " & .TextMatrix(.Row, .ColIndex("HiddenAnbarSN"))
            Else
                vSql_where = " 1 = 2 "
            End If
        End With

        DVaAnbarTarakonesh = New CDataView(cn)
        With DVaAnbarTarakonesh
            .Init(pnlG2, , pnlC2, pnlN2, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
                                          Or EnumButtonOptions.boCmdPrint)
            .TableName = "abAnbarTarakonesh"
            .Text = Me.Text
            .AccessRight = gSM.TableAccessRight(.TableName)
            .EditInGrid = True
            .SQLWhere = vSql_where
            .SQLOrderBy = " NoeAnbarSN , abTarakonesh.TartibA "
            With .Fields
                With .Add("AnbarTarakoneshSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With
                .Add("VahedeTejariSN", "DataCombo", EnumFieldOptions.foHidden)
                With .Add("NoeAnbarSN", "DataCombo", EnumFieldOptions.foDefault)
                    .LockUpdate = True
                End With
                With .Add("TarakoneshSN", "DataCombo")
                    'With .Add("TarakoneshSN->{abTarakonesh.TarakoneshNO+'.'+abTarakonesh.TarakoneshDs} As TarakoneshSN", dcbTarakoneshSN)
                    dcbTarakoneshSN = .Component
                    .LockUpdate = False
                End With
                With .Add("TarakoneshSN->{CAst(abTarakonesh.TarakoneshNO As INT)} As TarakoneshNO")
                    .LockUpdate = True
                    .Caption = "کد تراکنش"
                End With
                .Add("AnbarSN", "DataCombo", EnumFieldOptions.foHidden)
                With .Add("MinDateDoreh", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
                End With
                With .Add("MaxDateDoreh", "TextBox", EnumFieldOptions.foDate)
                    ' تهيه تاريخ از سرور
                    .DefaultValue = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "1229"
                End With
                With .Add("MohlatVorood", "TextBox", EnumFieldOptions.foDefault)
                    .DefaultValue = 15
                End With
                With .Add("MohlatNahaee", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = 15
                End With

                With .Add("NumberOfEdit", "TextBox", EnumFieldOptions.foHidden)
                    .DefaultValue = 4
                End With
                With .Add("AnbarTarakoneshStatus", "CheckBox")
                    .DefaultValue = 1
                End With
                With .Add("UnqStr AS QCOK", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.QCOK")
                    .DefaultValue = 0
                End With
                With .Add("SabteRialVaghei", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.SabteRialVaghei")
                    .DefaultValue = 0
                End With
                With .Add("RezDA", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.RezDA")
                    .DefaultValue = 0
                End With
                With .Add("RezDB", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.RezDB")
                    .DefaultValue = 1
                End With
                With .Add("RezDC", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.RezDC")
                    .DefaultValue = 1
                End With
                With .Add("RezDD", "CheckBox")
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.RezDD")
                    .DefaultValue = 1
                End With
                '''''''
                With .Add("RezSA", "CheckBox", EnumFieldOptions.foDefault)
                    .Caption = cn.FieldCaption("abAnbarTarakonesh.RezSA")
                    .DefaultValue = 0
                End With
                '.Add("RezSA", , EnumFieldOptions.foHidden)

                .Add("RezSB", , EnumFieldOptions.foHidden)
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

End Class


