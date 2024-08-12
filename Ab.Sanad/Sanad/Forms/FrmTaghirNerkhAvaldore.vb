
Imports System.Data.SqlClient
Imports C1.Win.C1FlexGrid.Classic
Imports System
Imports System.Data
Imports NetSql.DB.CConnection
Imports vb6 = Microsoft.VisualBasic
Imports System.IO
Imports System.Configuration
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports Janus.Windows.GridEX

Public Class FrmTaghirNerkhAvaldore
    Inherits System.Windows.Forms.Form
    Private WithEvents MasterDataView As CDataView
    Private WithEvents DetailDataView As CDataView
    Private WithEvents CmbSal As New NetSql.Components.DataCombo
    '    'يك کامبو تعريف مي شود كه بتوان با مطابقت با کامبو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد

    Private WithEvents dcbKalaPhiziki As NetSql.Components.DataCombo
    Private WithEvents dcbKala As NetSql.Components.DataCombo
    Public WithEvents dbcSanadStatus As NetSql.Components.DataCombo

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmTaghirNerkhAvaldore
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmTaghirNerkhAvaldore
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmTaghirNerkhAvaldore
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmTaghirNerkhAvaldore)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region
    Dim reportType As Short

    Private Sub FrmTaghirNerkhAvaldore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim reportType As Short

        If rdbkalaNo.Checked Then
            reportType = 1
        ElseIf rdbShomarehRahgiri.Checked Then
            reportType = 2
        End If

        InitDetailDataView()
        If DetailDataView.DataRows <= 0 Then
            btnHazfEntekhabi.Enabled = False
        End If
    End Sub


    Private Sub InitDetailDataView()
        DetailDataView = New CDataView(cn)
        Dim vSql_where As String
        With DetailDataView

            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdExit _
             Or EnumButtonOptions.boCmdPrint)

            .TableName = "abKalaPhizikiTaghirNerkh"
            .AddJoin("abKalaPhizikiTaghirNerkh", EnumTableJoin.tjLeftJoin, "abVw_abKalaPhiziki_Full", "KalaPhizikiSN", "KalaPhizikiSN")
            .AddJoin("abKalaPhizikiTaghirNerkh", EnumTableJoin.tjLeftJoin, "btStatus", "SanadStatus", "StatusSN")

            .Text = Me.Text
            .EditInGrid = True
            .AccessRight = gSM.TableAccessRight(.TableName)
            .InsertSPUserParam = " "
            .AutoFetchCurrentRow = True
            .SQLWhere = "abKalaPhizikiTaghirNerkh.AnbarSN = " & gAnbarSN & " And abVw_abKalaPhiziki_Full.KalaPhizikiMoaserDate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate
            .FlexGrid.AllowBigSelection = True
            .SQLOrderBy = "abKalaPhizikiTaghirNerkh.SanadStatus,abKalaPhizikiTaghirNerkh.SabtDate Desc,abKalaPhizikiTaghirNerkh.KalaSN,abKalaPhizikiTaghirNerkh.KalaPhizikiSN"
            With .Fields
                With .Add("KalaPhizikiNerkhSN", , gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                End With


                '''asli
                'With .Add("KalaPhizikiSN->abVw_ChangeNerkhAvaldore.{abVw_ChangeNerkhAvaldore.KalaNo  + ' _ ' + abVw_ChangeNerkhAvaldore.kalads + ' _ ' + abVw_ChangeNerkhAvaldore.ShomarehRahgiri} AS KalaPhizikiSN", "DataCombo", EnumFieldOptions.foDefault)
                '    .Caption = "کالا _رهگیری"
                '    .ComboLateBinding = True
                '    dcbKala = .Component
                '    .LockUpdate = True
                '    .ComboWhereCondition = " VahedeTejariSN = " + CStr(gVahedeTejariSN) &
                '                           " And AnbarSN = " + CStr(gAnbarSN) &
                '                           " And sanaddate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate &
                '                           " And KalaPhizikiSN not in (select KalaPhizikiSN from abKalaPhizikiTaghirNerkh ) "
                '    '.RefreshCombo()
                'End With
                '''asli
                With .Add("KalaPhizikiSN->abVw_abKalaPhiziki_Full.{abVw_abKalaPhiziki_Full.KalaNo  + '.' + abVw_abKalaPhiziki_Full.kalads + ' _ ' + abVw_abKalaPhiziki_Full.ShomarehRahgiri } AS KalaPhizikiSN", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "کالا _رهگیری"
                    .ComboLateBinding = True
                    dcbKala = .Component
                    .LockUpdate = True
                    .ComboWhereCondition = "KalaPhizikiSN In (Select KalaPhizikiSN from abVw_ChangeNerkhAvaldore Where VahedeTejariSN = " + CStr(gVahedeTejariSN) &
                                           " And AnbarSN = " + CStr(gAnbarSN) &
                                           " And sanaddate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate & ")"

                    '.RefreshCombo()
                End With
                ' end If 
                With .Add("{abVw_abKalaPhiziki_Full.KalaNO + '.' + abVw_abKalaPhiziki_Full.KalaDS} AS KalaSN", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "کالا"
                    .ComboLateBinding = True
                    .LockUpdate = True
                    .ReadOnly = True
                End With
                With .Add("KalaPhizikiSN-> abVw_abKalaPhiziki_Full.ShomarehRahgiri AS ShomarehRahgiri", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "شماره رهگیری"
                    .ComboLateBinding = True
                    .LockUpdate = True
                    .ReadOnly = True
                    .RefreshCombo()
                End With

                With .Add("VahedeTejariSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gVahedeTejariSN
                    .AllowNulls = True
                End With
                With .Add("AnbarSN", , EnumFieldOptions.foHidden)
                    .DefaultValue = gAnbarSN
                End With

                With .Add("UserID_Name",, EnumFieldOptions.foDefault)
                    .DefaultValue = gSM.UserID_Name
                    .Caption = "ثبت کننده"
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)

                With .Add("nerkh", "TextBox", EnumFieldOptions.foDefault)
                    .Caption = "نرخ"
                End With
                With .Add("SabtDate", , EnumFieldOptions.foDefault)
                    .Caption = "تاريخ ثبت"
                    .DateFormat = EnumDateFormat.dfFullYear
                    .DefaultValue = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, .DateFormat)
                End With

                With .Add("SanadStatus-> btStatus.{btStatus.StatusDS} as SanadStatus", "DataCombo", EnumFieldOptions.foDefault)
                    .Caption = "وضعیت"
                    .Component.Enabled = False
                    .ReadOnly = True
                End With
                .Add("RezSN1", , EnumFieldOptions.foHidden)
                .Add("RezSN2", , EnumFieldOptions.foHidden)
                .Add("RezSN3", , EnumFieldOptions.foHidden)
                .Add("SanadStatus AS S", , EnumFieldOptions.foHidden)

            End With
            .Refresh()
        End With

    End Sub
    Private Sub DetailDataView_GetGridProperties() _
        Handles DetailDataView.GetGridProperties
        ' امکان انتخاب گروهي فعال گردد
        With DetailDataView.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With


        If DetailDataView.DataRows > 0 Then
            For i As Integer = 0 To DetailDataView.FlexGrid.ColumnCollection.Count - 1
                DetailDataView.FlexGrid.AutoSizeCol(i)
            Next
        End If
    End Sub

    Private Sub btnGetkala_Click_1(sender As Object, e As EventArgs) Handles btnGetkala.Click

        If rdbkalaNo.Checked Then
            reportType = 1
        ElseIf rdbShomarehRahgiri.Checked Then
            reportType = 2
        End If
        '''  بدست آوردن اطلاعات کالاهای اول دوره با توجه به انبار و واحد تجاری و سال مالی
        Dim _SharedItems As New Minoo.Applications.ProductionPlanning.Common.SharedItems
        Dim query As String
        Try

            If reportType = 2 Then
                query = "Select  kalads, KalaNo, ShomarehRahgiri, cast(Nerkh as varchar) as Nerkh from abVw_ChangeNerkhAvaldore where  VahedeTejariSN = " + CStr(gVahedeTejariSN) &
                                                                                                    " And AnbarSN = " + CStr(gAnbarSN) &
                                                                                                    " And sanaddate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate

            ElseIf reportType = 1 Then
                query = "Select distinct kalads, KalaNo, cast(Nerkh as varchar) as Nerkh from abVw_ChangeNerkhAvaldore where  VahedeTejariSN = " + CStr(gVahedeTejariSN) &
                                                                                                    " And AnbarSN = " + CStr(gAnbarSN) &
                                                                                                    " And sanaddate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate
            End If

            Dim dvReportExcel As DataView = cn.ExecuteQuery(query)
            _SharedItems.ExcellExport(DetailDataView.FieldText("KalaPhizikiSN"), dvReportExcel.ToTable)
        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در ایجاد فایل اکسل " + ex.Message, MsgBoxStyle.MsgBoxRtlReading, " ")
        End Try
        '' بدست آوردن اطلاعات کالاهای اول دوره با توجه به انبار و واحد تجاری و سال مالی
    End Sub

    Private Sub btnExcel_Click_1(sender As Object, e As EventArgs) Handles btnExcel.Click
        ' براي انتقال اطلاعات گريد اقلام سند به اکسل
        Dim vFileName As String
        vFileName = Functions.FTCommonFunctions.GetFileName("Excel Format (*.xls)|*.xls", ".xls")
        If vFileName <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Functions.FTFlexFunctions.ExportExcel(DetailDataView.FlexGrid, vFileName)
            Me.Cursor = System.Windows.Forms.Cursors.Default()
            NetSql.Common.CSystem.MsgBox("فايل ذخيره شد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "EXCEL")
        End If
    End Sub

    Private Sub btnFormatExcel_Click(sender As Object, e As EventArgs) Handles btnFormatExcel.Click
        If rdbkalaNo.Checked Then
            reportType = 1
        ElseIf rdbShomarehRahgiri.Checked Then
            reportType = 2
        End If
        ''ایجاد فایل excel
        Try
            Dim _f As New Minoo.Applications.ProductionPlanning.Common.SharedItems
            Dim _DriveName As String = "D"

            If _DriveName.Length <> 1 Then
                CSystem.MsgBox("فرمت نام درایو اشتباه است", MsgBoxStyle.Exclamation, "نام درایو")
                Exit Sub
            End If
            Select Case 1 = 1
                Case 1 = 1
                    Dim ArrayOfColNames As New ArrayList
                    'ArrayOfColNames.Add("kalads")
                    ArrayOfColNames.Add("Kalano")
                    If reportType = 2 Then
                        ArrayOfColNames.Add("ShomarehRahgiri")
                    End If
                    ArrayOfColNames.Add("Nerkh")

                    _f.CreateExcelFormat(_DriveName, "TaghirNerkhAvaldore", ArrayOfColNames, "TaghirNerkhAvaldore")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine)
        End Try
        '''ایجاد فایل excel
    End Sub

    Private Sub btnGhate_Click_1(sender As Object, e As EventArgs) Handles btnGhate.Click
        Dim i As Short
        Dim V_ar_KalaPhizikiNerkhSN() As String
        Dim VCount_KalaPhizikiNerkhSN As Short
        Dim KalaPhizikiNerkhSNString As String = ""
        Dim KalaPhizikiSN, vKalaPhizikiSN As Object
        Dim vErrMsg As String
        Dim DV As DataView

        With DetailDataView
            ''test
            If (Not .CommandEnabled(EnumCommands.cmEdit)) Or (.State = EnumDataViewState.bsEdit) _
               Or (.State = EnumDataViewState.bsAdd) Then
                Exit Sub
            End If


            If NetSql.Common.CSystem.MsgBox(" آيا برای رکوردهاي انتخاب شده تغییر نرخ انجام گردد ؟ ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text) = MsgBoxResult.Yes Then

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                ''''''ایجاد یک رشته از دریف های سند انتخاب شده 
                With DetailDataView.FlexGrid
                    VCount_KalaPhizikiNerkhSN = .SelectedRows
                    ReDim V_ar_KalaPhizikiNerkhSN(VCount_KalaPhizikiNerkhSN)
                    For i = 0 To VCount_KalaPhizikiNerkhSN - 1
                        V_ar_KalaPhizikiNerkhSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("KalaPhizikiNerkhSN")))
                        KalaPhizikiNerkhSNString = V_ar_KalaPhizikiNerkhSN(i) + ", " + KalaPhizikiNerkhSNString
                    Next
                End With


                ''''''' فراخواني اس پي براي تغییر نرخ برای کالافیزکی های انتخاب شده
                If VCount_KalaPhizikiNerkhSN <> 0 Then
                    Try

                        'cn.CallSP("abSPC_SabtNerkhVagheyAvaldore", CStr(gVahedeTejariSN), CStr(gAnbarSN), KalaPhizikiNerkhSNString, vErrMsg)
                        cn.CallSP("abSPC_SabtNerkhVaghey_TaghriNerkhAvaldore", CStr(gVahedeTejariSN), CStr(gAnbarSN), KalaPhizikiNerkhSNString, vErrMsg)
                        MsgBox("عملیات تغییر نرخ انجام شد", MsgBoxStyle.OkOnly, "پیغام")
                    Catch ex As Exception
                        vErrMsg = ex.Message
                        CSystem.MsgBox("عملیات قطعی سازی انجام نشد " + vbCrLf + ex.Message)
                    End Try
                End If

                DetailDataView.Refresh()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End With
        ''test

    End Sub

    Private Sub DetailDataView_FillDetailsWithData(ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DetailDataView.FillDetailsWithData
        ' جهت کنترل رکوردهاي قطعي شده
        Dim vSanadStatus As Short

        btnGhate.Enabled = False

        ''در صورتيکه گريد خالي است از روتين خارج مي شود 
        If DetailDataView.FlexGrid.Rows = 2 Then Exit Sub

        vSanadStatus = aClip("SanadStatus")


        With DetailDataView
            ''test
            .CommandEnabled(EnumCommands.cmEdit) = (vSanadStatus = 4) Or (vSanadStatus = 1) And (.AccessRight And EnumAccessRight.arUpdate) <> 0
            .CommandEnabled(EnumCommands.cmDelete) = (vSanadStatus = 4) Or (vSanadStatus = 1) And (.AccessRight And EnumAccessRight.arDelete) <> 0
            ''test
            .CommandEnabled(EnumCommands.cmAdd) = True
            btnGhate.Enabled = vSanadStatus
        End With

        If vSanadStatus = 2 Then
            With DetailDataView
                .CommandEnabled(EnumCommands.cmEdit) = False
                .CommandEnabled(EnumCommands.cmDelete) = False
                .CommandEnabled(EnumCommands.cmAdd) = True
                btnGhate.Enabled = False
            End With
        End If
        ''ghasemi14010121

        If DetailDataView.DataRows > 0 Then
            For i As Integer = 0 To DetailDataView.FlexGrid.ColumnCollection.Count - 1
                DetailDataView.FlexGrid.AutoSizeCol(i)
            Next
        End If
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click

        If rdbkalaNo.Checked Then
            reportType = 1
        ElseIf rdbShomarehRahgiri.Checked Then
            reportType = 2
        End If

        Dim fdl As New OpenFileDialog
        Dim DS As System.Data.DataSet
        DS = New System.Data.DataSet
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim IsExcel As Int16 = 1
        fdl.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx"
        fdl.Multiselect = False
        fdl.ShowDialog()

        Dim Address As String = fdl.FileName()
        Dim name As String

        name = Address.Replace(".xlsx", "")
        name = "[" + name.Substring(name.LastIndexOf("\") + 1) + "$]"

        Try
            MyConnection = New System.Data.OleDb.OleDbConnection("provider= Microsoft.ACE.OLEDB.12.0; " &
                "data source=" & Address & ";Extended Properties=Excel 12.0;")
            MyConnection.Open()
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("Select distinct * from [TaghirNerkhAvaldore$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "Table1")
            MyCommand.Fill(DS)
            MyConnection.Close()
        Catch ex As Exception
            tp.MsgBox(": فايل اکسل قابل بازخواني نمي باشد لطفا موارد زير را بررسي نمائيد" + vbCrLf +
                      "مطمئن شويد نام شيت فايل مورد نظر " + "[TaghirNerkhAvaldore]" + " باشد " + vbCrLf +
                      "مطمئن شويد فايل اکسل خارج از برنامه باز مي شود" + vbCrLf +
                      "در صورت عدم رفع مشکل فايل اکسل را باز نموده و با نام ديگري ذخيره نمائيد")
            Exit Sub
        End Try

        Dim dstable As DataTable
        dstable = DS.Tables("Table1").Copy()

        Dim dsKA As DataView = cn.ExecuteQuery("select KalaSN, KalaNo, kalads, KalaPhizikiSN, ShomarehRahgiri, Nerkh  from abVw_ChangeNerkhAvaldore where VahedeTejariSN = " + CStr(gVahedeTejariSN) &
                                                                                                         " And AnbarSN = " + CStr(gAnbarSN) &
                                                                                                         " And sanaddate Between " & gHesabdariSalFDate & " And " & gHesabdariSalTDate)

        'بررسی اکسل و حذف رکوردهای با مقدار خالی


        DS.Tables("Table1").Clear()
        '    'اگر در فایل اکسل ردیف نال وجود داشت 
        For i As Integer = 0 To dstable.Rows.Count - 1
            If dstable.Rows(i).IsNull(0) Then
                dstable.Rows(i).Delete()
            Else
                Dim r As DataRow = DS.Tables("Table1").NewRow

                r("Kalano") = dstable.Rows(i)("Kalano")
                If reportType = 2 Then
                    r("ShomarehRahgiri") = dstable.Rows(i)("ShomarehRahgiri")

                End If

                r("Nerkh") = dstable.Rows(i)("Nerkh")

                If reportType = 2 Then
                    DS.Tables("Table1").Rows.Add(r("KalaNo"), r("ShomarehRahgiri"), r("Nerkh"))
                ElseIf reportType = 1 Then
                    DS.Tables("Table1").Rows.Add(r("KalaNo"), r("Nerkh"))
                End If
            End If
        Next

        ''اضافه کردن ستون به دیتاست
        Dim dc As New DataColumn
        dc.ColumnName = "KalaPhizikiNerkhSN"
        dc.DataType = System.Type.GetType("System.Decimal")
        DS.Tables("Table1").Columns.Add(dc)

        Dim _Col1 As New System.Data.DataColumn
        _Col1.ColumnName = "KalaPhizikiSN"
        DS.Tables("Table1").Columns.Add(_Col1)

        Dim _Col2 As New System.Data.DataColumn
        _Col2.ColumnName = "KalaSN"
        DS.Tables("Table1").Columns.Add(_Col2)

        Dim _Col3 As New System.Data.DataColumn
        _Col3.ColumnName = "SanadStatus"
        DS.Tables("Table1").Columns.Add(_Col3)

        Dim _Col4 As New System.Data.DataColumn
        _Col4.ColumnName = "VahedeTejariSN"
        DS.Tables("Table1").Columns.Add(_Col4)

        Dim _Col5 As New System.Data.DataColumn
        _Col5.ColumnName = "AnbarSN"
        DS.Tables("Table1").Columns.Add(_Col5)

        Dim _Col6 As New System.Data.DataColumn
        _Col6.ColumnName = "SabtDate"
        DS.Tables("Table1").Columns.Add(_Col6)

        Dim _Col7 As New System.Data.DataColumn
        _Col7.ColumnName = "UserID_Name"
        DS.Tables("Table1").Columns.Add(_Col7)

        Dim _Col8 As New System.Data.DataColumn
        _Col8.ColumnName = "Host_Name"
        DS.Tables("Table1").Columns.Add(_Col8)

        Dim _Col15 As New System.Data.DataColumn
        _Col15.ColumnName = "RecChksum"
        DS.Tables("Table1").Columns.Add(_Col15)

        If reportType = 1 Then
            Dim _Col9 As New System.Data.DataColumn
            _Col9.ColumnName = "ShomarehRahgiri"
            DS.Tables("Table1").Columns.Add(_Col9)

        End If

        Dim _Col10 As New System.Data.DataColumn
        _Col10.ColumnName = "TaeedDate"
        DS.Tables("Table1").Columns.Add(_Col10)

        Dim _Col11 As New System.Data.DataColumn
        _Col11.ColumnName = "TaeedTime"
        DS.Tables("Table1").Columns.Add(_Col11)

        Dim _Col12 As New System.Data.DataColumn
        _Col12.ColumnName = "RezSN1"
        DS.Tables("Table1").Columns.Add(_Col12)

        Dim _Col13 As New System.Data.DataColumn
        _Col13.ColumnName = "RezSN2"
        DS.Tables("Table1").Columns.Add(_Col13)

        Dim _Col14 As New System.Data.DataColumn
        _Col14.ColumnName = "RezSN3"
        DS.Tables("Table1").Columns.Add(_Col14)

        Dim _Col16 As New System.Data.DataColumn
        _Col16.ColumnName = "TimeStamp"
        DS.Tables("Table1").Columns.Add(_Col16)


        Dim q As String = "Select Isnull(Max(KalaPhizikiNerkhSN)," & CStr(gSM.Identifier) & ") From abKalaPhizikiTaghirNerkh"
        Dim MaxS As Long = CLng(cn.ExecuteQuery(q)(0)(0) + 1)
        Dim MaxSn As Decimal = MaxS + CStr(gSM.Identifier)
        For i As Long = 0 To DS.Tables("Table1").Rows.Count - 1
            DS.Tables("Table1").DefaultView(i)("KalaPhizikiNerkhSN") = MaxSn + i
        Next


        For Each _row As DataRow In DS.Tables("Table1").Rows

            _row("Host_Name") = SystemInformation.ComputerName
            _row("UserID_Name") = gSM.UserName
            _row("VahedeTejariSN") = gVahedeTejariSN
            _row("AnbarSN") = gAnbarSN
            _row("SanadStatus") = 1 ''وضعیت موقت

            Dim DateFormat As String = EnumDateFormat.dfFullYear

            _row("SabtDate") = NetSql.Common.CShamsiDate.MiladiToShamsi(Today, DateFormat)

            If IsNumeric(_row("Nerkh")) And _row("Nerkh") <= "0" Then

                tp.MsgBox("خطا :  درج مقدار غیر عددی و منفی یا صفر برای نرخ مجاز نمی باشد ", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If dsKA.Count > 0 Then
                dsKA.RowFilter = "KalaNo='" & _row("KalaNo") & "' "
                _row("KalaSN") = dsKA(0)("KalaSN")
            End If
            dsKA.RowFilter = "0=0"


            If reportType = 2 AndAlso dsKA.Count > 0 Then
                dsKA.RowFilter = CType("KalaNo = '" + _row("KalaNo") + "' " + " and ShomarehRahgiri= '" + _row("ShomarehRahgiri") + "' ", String)
                _row("KalaPhizikiSN") = dsKA(0)("KalaPhizikiSN")
            ElseIf reportType = 1 Then
                _row("KalaPhizikiSN") = 0
            End If
            dsKA.RowFilter = "0=0"

        Next

        '//تغيير اس پي قطعي سازي براي برداشتن تراکنش از داخل اس پي

        Try

            If cn.Connection.State = ConnectionState.Closed Then cn.Connection.Open()
            cn.BeginTrans(cn.Connection.BeginTransaction)

            Dim sConnectionString As String = cn.ConnectionString + ";password = " + cn.SQLPassword
            Dim objConn As New SqlConnection(sConnectionString)
            objConn.Open()
            Dim bulkcopy As New SqlBulkCopy(sConnectionString)

            Using bulkcopy
                bulkcopy.DestinationTableName = "abKalaPhizikiTaghirNerkh"
                Dim Dv As DataView = cn.ExecuteQuery("Select Top 1 * From abKalaPhizikiTaghirNerkh")
                Dim dr As SqlDataReader
                Dim myDt As DataTable = DS.Tables("Table1")
                Dim Arr As New ArrayList
                For Each Col As DataColumn In myDt.Columns
                    If IsNothing(Dv.ToTable.Columns(Col.ColumnName)) Then
                        Arr.Add(Col.ColumnName)
                    End If
                Next
                If Arr.Count > 0 Then
                    For Each Item As String In Arr
                        myDt.Columns.Remove(Item)
                    Next
                End If


                bulkcopy.ColumnMappings.Clear()
                For Each myCol As DataColumn In myDt.Columns
                    bulkcopy.ColumnMappings.Add(myCol.ColumnName.Trim(), myCol.ColumnName.Trim())
                Next
                bulkcopy.WriteToServer(DS.Tables("Table1"))
                MessageBox.Show("تعداد" + (DS.Tables("Table1").Rows.Count).ToString() + "ردیف درج شد", "توجه")

            End Using

            If reportType = 1 Then

                'cn.CallSP("abSPC_SabtKalaphizikiINabKalaPhizikiTaghirNerkh", CStr(gVahedeTejariSN), CStr(gAnbarSN))
                cn.CallSP("abSPC_SabtKalaphizikiINabKalaPhiziki_TaghirNerkhAvaldore", CStr(gVahedeTejariSN), CStr(gAnbarSN))

            End If

            cn.CommitTrans()
        Catch ex As Exception
            CSystem.MsgBox(ex.Message)
            cn.RollbackTrans()

        End Try
        DetailDataView.Refresh()
    End Sub

    Private Sub btnHazfEntekhabi_Click(sender As Object, e As EventArgs) Handles btnHazfEntekhabi.Click
        Dim i As Short
        Dim V_ar_KalaPhizikiNerkhSN() As String
        Dim Result As Integer = 0
        Dim VCount_SelectedRows As Short
        Dim KalaPhizikiNerkhSNString As String = String.Empty
        Dim vErrMsg As String = ""

        With DetailDataView

            If (Not .CommandEnabled(EnumCommands.cmEdit)) Or (.State = EnumDataViewState.bsEdit) _
               Or (.State = EnumDataViewState.bsAdd) Then
                Exit Sub
            End If
        End With
        With DetailDataView.FlexGrid
            VCount_SelectedRows = .SelectedRows
            ReDim V_ar_KalaPhizikiNerkhSN(VCount_SelectedRows)
            For i = 0 To VCount_SelectedRows - 1
                If CStr(Val(.TextMatrix(.SelectedRow(i), .ColIndex("S")))) = "1" Then 'فقط ردیف های موقت
                    KalaPhizikiNerkhSNString = KalaPhizikiNerkhSNString + CStr(Val(.TextMatrix(.SelectedRow(i), .ColIndex("KalaPhizikiNerkhSN")))) + ","
                End If
            Next
            If String.IsNullOrEmpty(KalaPhizikiNerkhSNString) Then
                MsgBox("هیچ کدام از موارد انتخاب شده در حالت موقت نیستند", MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If
            If MsgBox("آیا مایل به حذف موارد انتخابی هستید؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "حذف ") = MsgBoxResult.Yes Then

                'Result = cn.CallSP("abSP_DeleteNerkhVagheyAvaldore", CStr(gAnbarSN), CStr(KalaPhizikiNerkhSNString), vErrMsg)
                Result = cn.CallSP("abSPC_DeleteNerkhVaghey_TaghriNerkhAvaldore", CStr(gAnbarSN), CStr(KalaPhizikiNerkhSNString), vErrMsg)
                If Result > 0 Then
                    MsgBox("موارد انتخاب شده  حذف شدند", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Information, "موفق")
                    Me.Cursor = Cursors.WaitCursor
                    DetailDataView.Refresh()
                    Me.Cursor = Cursors.Default
                Else
                    MsgBox("خطا در حذف موارد انتخاب شده ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading, "نا موفق")
                End If
            End If
        End With

    End Sub
End Class
