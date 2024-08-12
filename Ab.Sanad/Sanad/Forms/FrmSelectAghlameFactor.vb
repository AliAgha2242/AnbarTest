
Option Strict Off
Option Explicit On

' OK
'Author ::سيد محمود قاسمي 
'CreateDate :: 1383/11/13
'ModifiedDate::
'Description::  انتخاب کالاي فيزيکي
'  در ثبت اقلام سند لازم ميشود که کالاي فيزيکي مورد استفاده قرار گيرد 
' بوسيله اين فرم با توجه به کالاي انتخاب شده کليه کالافيزيکي هاي آن براي کاربر به همراه موجودي و ساير اطلاعات ليست ميگردد
' و کاربر ميتواند مورد دلخواه را انتخاب نمايد
'System ::انبار


Imports C1.Win.C1FlexGrid.Classic

Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports C1.Win.C1FlexGrid


Friend Class FrmSelectAghlameFactor
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'If m_vb6FormDefInstance Is Nothing Then
        '    If m_InitializingDefInstance Then
        '        m_vb6FormDefInstance = Me
        '    Else
        '        Try
        '            If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
        '                m_vb6FormDefInstance = Me
        '            End If
        '        Catch
        '        End Try
        '    End If
        'End If
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
    Public WithEvents btnSelectAll As System.Windows.Forms.Button
    Public WithEvents btnDeselectAll As System.Windows.Forms.Button
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnDarjAsan As System.Windows.Forms.Button
    Public IsSanadDaroo As Boolean = False



    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDarjAsan = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnDarjAsan)
        Me.GroupBox1.Controls.Add(Me.btnSelectAll)
        Me.GroupBox1.Controls.Add(Me.btnDeselectAll)
        Me.GroupBox1.Controls.Add(Me.pnlN)
        Me.GroupBox1.Controls.Add(Me.pnlG)
        Me.GroupBox1.Controls.Add(Me.pnlC)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(876, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ليست اقلام فاکتور"
        '
        'btnDarjAsan
        '
        Me.btnDarjAsan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDarjAsan.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjAsan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAsan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAsan.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarjAsan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAsan.Location = New System.Drawing.Point(535, 309)
        Me.btnDarjAsan.Name = "btnDarjAsan"
        Me.btnDarjAsan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAsan.Size = New System.Drawing.Size(75, 29)
        Me.btnDarjAsan.TabIndex = 7
        Me.btnDarjAsan.Tag = ""
        Me.btnDarjAsan.Text = "درج آسان"
        Me.btnDarjAsan.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectAll.Location = New System.Drawing.Point(489, 309)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "همه"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselectAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeselectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeselectAll.Location = New System.Drawing.Point(445, 309)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeselectAll.Size = New System.Drawing.Size(41, 29)
        Me.btnDeselectAll.TabIndex = 5
        Me.btnDeselectAll.Text = "هيچ "
        Me.btnDeselectAll.UseVisualStyleBackColor = False
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 309)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(435, 29)
        Me.pnlN.TabIndex = 3
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(2, 18)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(870, 286)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(670, 310)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(195, 29)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'FrmSelectAghlameFactor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmSelectAghlameFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب کالاي فيزيکي"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmSelectAghlameFactor
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmSelectAghlameFactor
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmSelectAghlameFactor
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmSelectAghlameFactor)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي فيزيکي تعريف شده است
    Private WithEvents DvabVw_KalaKalaPhiziki As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFlex_abVw_KalaKalaPhiziki As AxVSFlexGrid

    ' کالا فيزيکي انتخاب شده
    Private mSelected As String
    ' کالاي مورد نظر جهت نمايش کالافيزيکي ها 
    Private mFactorSN As Decimal
    Private mHavalehForooshSN As Decimal
    Private mMeghdar As Decimal
    Private mMoaserDate As String
    Private mKalaDs As String
    Private mSanadRow As DataRow
    Private mMode As Byte
    Private mNoeMadomiSN As Decimal
    Private mNoeMarjooeiSN As Decimal
    Private mNoeZayeatSN As Decimal
    'Private mdvSanadHa As DataView

    Private DV As DataView

#End Region

#Region "PropertyDefinition"

    Public Property FactorSN() As Decimal
        Get
            FactorSN = mFactorSN
        End Get
        Set(ByVal Value As Decimal)
            mFactorSN = Value
        End Set
    End Property

    Public Property HavalehForooshSN() As Decimal
        Get
            HavalehForooshSN = mHavalehForooshSN
        End Get
        Set(ByVal Value As Decimal)
            mHavalehForooshSN = Value
        End Set
    End Property

    Public Property Selected() As String
        Get
            Selected = mSelected
        End Get
        Set(ByVal Value As String)
            mSelected = Value
        End Set
    End Property

    Public Property SanadRow() As DataRow
        Get
            SanadRow = mSanadRow
        End Get
        Set(ByVal Value As DataRow)
            mSanadRow = Value
        End Set
    End Property

    Public Property NoeMarjooeiSN() As Decimal
        Get
            NoeMarjooeiSN = mNoeMarjooeiSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeMarjooeiSN = Value
        End Set
    End Property

    Public Property NoeMadomiSN() As Decimal
        Get
            NoeMadomiSN = mNoeMadomiSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeMadomiSN = Value
        End Set
    End Property

    Public Property NoeZayeatSN() As Decimal
        Get
            NoeZayeatSN = mNoeZayeatSN
        End Get
        Set(ByVal Value As Decimal)
            mNoeZayeatSN = Value
        End Set
    End Property

#End Region

    Private Sub btnDeselectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnDeselectAll.Click
        Dim i As Short
        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Unchecked)
            Next i
        End With
    End Sub

    Private Sub btnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim I As Short
        Dim vSanadHaSelected As String

        vSanadHaSelected = ""
        With pFlex_abVw_KalaKalaPhiziki
            For I = .FixedRows To .Rows - 1
                If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                    vSanadHaSelected = vSanadHaSelected & " , " & .get_TextMatrix(I, .get_ColIndex("ShomarehRahgiri"))
                    Exit For
                End If
            Next
        End With
        If Len(vSanadHaSelected) > 0 Then
            vSanadHaSelected = Mid(vSanadHaSelected, 4, Len(vSanadHaSelected))
        End If
        mSelected = vSanadHaSelected
        mMode = 1
        Me.Hide()
    End Sub

    Private Sub btnSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles btnSelectAll.Click
        Dim i As Short
        With pFlex_abVw_KalaKalaPhiziki
            For i = .FixedRows To .Rows - 1
                .SetCellCheck(i, .get_ColIndex("Selected"), CheckEnum.Checked)
            Next i
        End With
    End Sub

    Private Sub DvabVw_KalaKalaPhiziki_GetGridProperties() Handles DvabVw_KalaKalaPhiziki.GetGridProperties
        DvabVw_KalaKalaPhiziki.FlexGrid.FontSize = 10
        DvabVw_KalaKalaPhiziki.Fields("KalaPhizikiSN").FieldOptions = EnumFieldOptions.foHidden
        DvabVw_KalaKalaPhiziki.Fields("KalaSN").FieldOptions = EnumFieldOptions.foHidden
        DvabVw_KalaKalaPhiziki.Fields("Tedad").FieldOptions = EnumFieldOptions.foHidden
    End Sub

    Private Sub FrmSelectAghlameFactor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        If pISLoaded Then
            Exit Sub
        End If
        pISLoaded = True
        mMode = 0
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvabVw_KalaKalaPhiziki = New CDataView(cn)
        With DvabVw_KalaKalaPhiziki
            ''''''''''''''''''''''''''''
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdExit)
            .CommandVisible(EnumCommands.cmExit) = False
            .QueryName = "abVw_KalaKalaPhiziki"
            .Text = Me.Text
            .Text = FTDD.GetCaption("abVw_KalaKalaPhiziki")
            .EditInGrid = False
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False

            ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
            ' سلکت  گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
            DV = cn.ExecuteQuery("_abSPG_GetFactorhaBatch " & CStr(mFactorSN) + "," + gHesabdariSalFDate & "," + gHesabdariSalTDate + "," & SanadRow.Item("TarakoneshSN").ToString & "," & If(IsNumeric(HavalehForooshSN), HavalehForooshSN, 0))
            .DataSource = DV

            pFlex_abVw_KalaKalaPhiziki = .FlexGrid
            pFlex_abVw_KalaKalaPhiziki.Editable = EditableSettings.flexEDKbdMouse
            '''''''''''''''''''''''''''
            .FlexGrid.ColDataType(1) = GetType(Boolean)
            .FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("KalaPhizikiStatusSn")) = True

            If SanadRow.Item("TarakoneshSN") = 38 Then
                .FlexGrid.ColHidden(DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("FactorAsliSN")) = True
                .Fields("FactorNo").Caption = "شماره فاکتور اصلی"
                If IsNumeric(HavalehForooshSN) Then
                    If HavalehForooshSN > 0 AndAlso DV.Count > 0 Then
                        Me.Text = Me.Text + " - مرجوعی فاکتور اصلی شماره " + DvabVw_KalaKalaPhiziki.FlexGrid.TextMatrix(1, DvabVw_KalaKalaPhiziki.FlexGrid.ColIndex("FactorNo"))
                    End If
                End If
            End If

        End With
        For i As Integer = 0 To DvabVw_KalaKalaPhiziki.FlexGrid.ColumnCollection.Count - 1
            DvabVw_KalaKalaPhiziki.FlexGrid.AutoSizeCol(i)
        Next

        DvabVw_KalaKalaPhiziki.Refresh()

    End Sub

    Private Sub FrmSelectAghlameFactor_Closing(ByVal eventSender As System.Object,
                                                ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub FrmSelectAghlameFactori_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvabVw_KalaKalaPhiziki.Done()
        DvabVw_KalaKalaPhiziki = Nothing
    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Public Sub btnDarjAsan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarjAsan.Click

        Dim IsChecked As Boolean
        Dim SelectedFactor As New ArrayList
        Dim FactorASliSN As Decimal = 0
        Dim FactorAsliNo As String = ""
        Dim I As Short

        '//اگر کالا فقط يک کد رهگيري داشته باشد همان يک عدد انتخاب مي شود ولي اگر بيشتر از يکي بود کاربر بايد انتخاب کند
        With pFlex_abVw_KalaKalaPhiziki
            If .Rows - 1 = 1 Then
                .SetCellCheck(.FixedRows, .get_ColIndex("Selected"), CheckEnum.Checked)
                If SanadRow.Item("TarakoneshSN") = 38 Then
                    FactorASliSN = CDec(.TextMatrix(1, .ColIndex("FactorAsliSN")))
                    FactorAsliNo = CStr(.TextMatrix(1, .ColIndex("FactorNo")))
                End If

            Else
                For I = .FixedRows To .Rows - 1
                    If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                        IsChecked = True
                        If SanadRow.Item("TarakoneshSN") = 38 Then
                            SelectedFactor.Add(.TextMatrix(I, .ColIndex("FactorAsliSN")))
                            FactorASliSN = CDec(.TextMatrix(I, .ColIndex("FactorAsliSN")))
                            FactorAsliNo = CStr(.TextMatrix(I, .ColIndex("FactorNo")))
                        End If
                    End If
                Next
                If Not IsChecked Then
                    NetSql.Common.CSystem.MsgBox("کالا فيزيکي انتخاب نشده است.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If

                If SelectedFactor.Count > 1 Then
                    Dim FactorValue As String = SelectedFactor(0)
                    For k As Integer = 1 To SelectedFactor.Count - 1
                        If FactorValue <> SelectedFactor(k) Then
                            NetSql.Common.CSystem.MsgBox("فاکتورهای مختلف انتخاب شده است!" + vbNewLine + "در رسیدهای مرجوعی از فروش هر فاکتور اصلی می بایست با یک سند انبار مرجوع شود", MsgBoxStyle.Critical, Me.Text)
                            Exit Sub
                        End If
                    Next
                End If
            End If

        End With
        '//

        DarjeAsan()

        If SanadRow.Item("TarakoneshSN") = 38 AndAlso FactorASliSN <> 0 Then
            cn.ExecuteNoneQuery("Update absanad set HavalehForooshSN=" & FactorASliSN & ",Tozih= SanadDate + ' - '+ Case when left(LTRIM(Tozih),8) = SanadDate Then Isnull(REPLACE(Tozih,SanadDate,''),'') Else  ISNULL(Tozih,'') End  + Case when CHARINDEX('شماره فاکتور اصلی : ',Tozih,0)>0 Then '' Else   isnull(' - '+'شماره فاکتور اصلی : ' + '" & FactorAsliNo & "' ,'') End   where SanadSN= " & SanadRow.Item("SanadSN").ToString)
        End If

    End Sub

    Private Function DarjeAsan() As Boolean
        Dim I As Short

        ' انتخاب کليد اوليه کالافيزيکي انتخاب شده توسط کاربر
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        If NetSql.Common.CSystem.MsgBox("آيا کالا فيزيکي هاي انتخاب شده با مقادير مربوطه درج گردند ؟", MsgBoxStyle.Question _
                                                                                     + MsgBoxStyle.YesNo +
                                                                                     MsgBoxStyle.DefaultButton2 +
                                                                                     MsgBoxStyle.MsgBoxRtlReading _
                                                                                     + MsgBoxStyle.MsgBoxRight, Me.Text) =
           MsgBoxResult.Yes Then

            Dim VahedeTejariSN As Decimal,
                AnbarSN As Decimal,
                NoeAnbarSN As Decimal,
                UserID As String,
                UserID_Name As String,
                Host_Name As String
            VahedeTejariSN = gVahedeTejariSN
            AnbarSN = gAnbarSN
            NoeAnbarSN = gNoeAnbarSN
            UserID = gSM.UserID
            UserID_Name = gSM.UserID_Name
            Host_Name = System.Environment.MachineName

            Dim DVSanadHa As Data.DataView, DVSanad As Data.DataView
            Dim vErrorMsg As String = ""


            Dim vSanadHaSelected As String
            vSanadHaSelected = ""

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim Ds_Sanad As New Minoo.Applications.Anbar.Common.dsSanad
            Dim aSanadHaRow As Minoo.Applications.Anbar.Common.dsSanad.SanadHaRow
            Dim aSanadRow As Minoo.Applications.Anbar.Common.dsSanad.SanadRow

            'CType(DataGrid1.DataSource, DataTable).Rows(DataGrid1.CurrentCell.RowNumber)
            'currRow(1, DataRowVersion.Current).ToString()

            DVSanad = Ds_Sanad.Sanad.DefaultView
            aSanadRow = Ds_Sanad.Sanad.NewRow()
            aSanadRow("SanadSN") = SanadRow.Item("SanadSn")
            aSanadRow("SanadDate") = SanadRow.Item("SanadDate")
            aSanadRow("MoaserDate") = SanadRow.Item("MoaserDate")
            aSanadRow("AnbarSN") = SanadRow.Item("AnbarSN")
            'If SanadRow.Item("TarakoneshSN") = 38 Then
            '    With pFlex_abVw_KalaKalaPhiziki
            '        For I = .FixedRows To .Rows - 1
            '            If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
            '                aSanadRow("HavalehForooshSN") = .TextMatrix(I, .ColIndex("FactorAsliSN"))
            '            End If
            '        Next
            '    End With
            'Else
            aSanadRow("ShomarehSefaresh") = SanadRow.Item("ShomarehSefaresh")
            'End If
            aSanadRow("TafsiliSN") = SanadRow.Item("TafsiliSN")
            aSanadRow("TarakoneshSN") = SanadRow.Item("TarakoneshSN")
            aSanadRow("UserID_Name") = SanadRow.Item("UserID_Name")
            aSanadRow("UserNameSabt") = SanadRow.Item("UserNameSabt")
            aSanadRow("VahedeTejariSN") = SanadRow.Item("VahedeTejariSN")
            aSanadRow("Tozih") = SanadRow.Item("Tozih")
            aSanadRow("NoeAnbarSN") = SanadRow.Item("NoeAnbarSN")
            aSanadRow("Host_Name") = SanadRow.Item("Host_Name")
            aSanadRow("SanadStatus") = SanadRow.Item("SanadStatus")
            aSanadRow("NoeSanadID") = SanadRow.Item("NoeSanadID")
            aSanadRow("TafsiliSN2") = SanadRow.Item("TafsiliSN2")

            Ds_Sanad.Sanad.Rows.Add(aSanadRow)
            DVSanad = Ds_Sanad.Sanad.DefaultView

            DVSanadHa = Ds_Sanad.SanadHa.DefaultView

            If DVSanad.Count() > 0 Then
                With pFlex_abVw_KalaKalaPhiziki
                    For I = .FixedRows To .Rows - 1
                        If .GetCellCheck(I, .get_ColIndex("Selected")) = CheckEnum.Checked Then
                            If .get_TextMatrix(I, .get_ColIndex("Tedad")) > 0 Then
                                aSanadHaRow = Ds_Sanad.SanadHa.NewRow()
                                aSanadHaRow.SanadHaSN = I
                                aSanadHaRow.SanadSN = Val(DVSanad(0)("SanadSN").ToString)
                                aSanadHaRow.KalaSN = .get_TextMatrix(I, .get_ColIndex("KalaSN"))
                                aSanadHaRow.KalaPhizikiSN = .get_TextMatrix(I, .get_ColIndex("KalaPhizikiSN"))
                                If IsNumeric(.get_TextMatrix(I, .get_ColIndex("TedadAjza"))) AndAlso IsNumeric(.get_TextMatrix(I, .get_ColIndex("Box"))) AndAlso IsNumeric(.get_TextMatrix(I, .get_ColIndex("Can"))) Then
                                    aSanadHaRow.MeghdareVaredeh = (CDec(.get_TextMatrix(I, .get_ColIndex("TedadAjza"))) * CDec(.get_TextMatrix(I, .get_ColIndex("Box")))) + CDec(.get_TextMatrix(I, .get_ColIndex("Can")))
                                Else
                                    aSanadHaRow.MeghdareVaredeh = CDec(.get_TextMatrix(I, .get_ColIndex("Tedad")))
                                End If
                                aSanadHaRow.MeghdareSadereh = 0
                                aSanadHaRow.UserID_Name = UserID_Name
                                aSanadHaRow.Host_Name = Host_Name
                                aSanadHaRow.ShomarehRahgiri = .get_TextMatrix(I, .get_ColIndex("ShomarehRahgiri"))
                                aSanadHaRow.ToolidDate =
                                        Replace(.get_TextMatrix(I, .get_ColIndex("ToolidDate")), "/", "")
                                aSanadHaRow.EnghezaDate =
                                        Replace(.get_TextMatrix(I, .get_ColIndex("EnghezaDate")), "/", "")

                                '//براي حالتهايي که نوع مرجوعي يا ضايعات يا معدومي بايد وارد شود
                                aSanadHaRow.NoeMadomiSN = mNoeMadomiSN
                                aSanadHaRow.NoeMarjooeiSN = mNoeMarjooeiSN
                                aSanadHaRow.NoeZayeatSN = mNoeZayeatSN
                                '//براي حالتهايي که نوع مرجوعي يا ضايعات يا معدومي بايد وارد شود

                                aSanadHaRow.KalaPhizikiStatusSN = .get_TextMatrix(I, .get_ColIndex("KalaPhizikiStatusSn"))

                                'row.EndEdit()
                                Ds_Sanad.SanadHa.Rows.Add(aSanadHaRow)
                                End If
                            End If
                    Next
                End With
                DVSanadHa = Ds_Sanad.SanadHa.DefaultView
                If DVSanadHa.Count > 0 Then
                    Try
                        vErrorMsg = Minoo.Applications.Anbar.CService.DarjSanadHa(cn _
                                                                                   , tp _
                                                                                   , VahedeTejariSN _
                                                                                   , AnbarSN _
                                                                                   , NoeAnbarSN _
                                                                                   , gSM.Identifier _
                                                                                   , DVSanad _
                                                                                   , DVSanadHa _
                                                                                   , UserID _
                                                                                   , UserID_Name _
                                                                                   , 0
                                                                                   )
                        If vErrorMsg <> "" Then
                            NetSql.Common.CSystem.MsgBox(vErrorMsg, MsgBoxStyle.Critical, Me.Text)
                        End If

                    Catch ex As Exception
                        vErrorMsg = vErrorMsg & " DarjSanad : " & ex.Message
                        tp.LogStr(vErrorMsg)
                    Finally
                    End Try
                Else
                    CSystem.MsgBox("سطری برای درج یافت نشد" + vbNewLine + "کالاهای انتخابی قبلا ثبت شده است یا حد مجاز مرجوعی رعایت نشده است", MsgBoxStyle.Exclamation, "")
                End If


                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

                Me.Hide()

            Else
                MsgBox("اطلاعات سند در دسترس نيست")
            End If
        End If
    End Function

End Class
