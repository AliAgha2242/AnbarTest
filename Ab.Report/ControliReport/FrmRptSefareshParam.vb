Public Class FrmRptSefareshParam

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptSefareshParam
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmRptSefareshParam
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptSefareshParam
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptSefareshParam)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    ' يک نمونه از فيلتر گزارشات انبار براي استفاده در فيلتر گزارش
    Private VFilterAsnadAnbar As New Minoo.Applications.Anbar.Common.FrmFilterAsnadAnbar

    Private Sub CmdSelectAnbars_Click(sender As System.Object, e As System.EventArgs) Handles CmdSelectAnbars.Click
        ShowSelectAnbar(Me)
    End Sub

    Private Sub btnFilterAsnadAnbar_Click(sender As System.Object, e As System.EventArgs) Handles btnFilterAsnadAnbar.Click
        ' با توجه به چگونگي تنظيم فيلتر انبار در لود فرم 
        ' حال از فرم فيلتر انبار استفاده ميشود
        With VFilterAsnadAnbar
            .EnableFromSanadDate = True
            '850607
            .VisibleSanadDate = True
            .VisibleSanadStatus = True
            .VisibleRezerv = True
            .VisibleKala = True
            .VisibleGoroohBandiKala = True
            .VisibleNoeTarakoneshKala = True
            .VisibleKalaWhere = True
            .VisibleChidemanKala = True
            .VisibleTaghazaKonandeh = True
            If Trim(dcbNoeAnbarSN.BoundText) <> "" Then
                .FilterNoeAnbarSN = dcbNoeAnbarSN.BoundText
            End If
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub btnChideman_Click(sender As System.Object, e As System.EventArgs) Handles btnChideman.Click
        'Dim vKalaSN As Object
        'Dim i As Short
        'Dim vSN As Decimal
        'Dim V_ar_KalaSN() As Decimal
        'Dim VCount_KalaSN As Short

        'With DViewer
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '    With DViewer.FlexGrid
        '        VCount_KalaSN = .SelectedRows
        '        ReDim V_ar_KalaSN(VCount_KalaSN)
        '        For i = 0 To VCount_KalaSN - 1
        '            V_ar_KalaSN(i) = Val(.TextMatrix(.SelectedRow(i), .ColIndex("KalaSN")))
        '        Next
        '    End With
        '    ' حذف تک تک رکوردهاي انتخاب شده 
        '    For i = 0 To VCount_KalaSN - 1
        '        vSN = Val(V_ar_KalaSN(i))
        '        If vSN <> 0 Then
        '            vKalaSN = vKalaSN & IIf(vKalaSN Is Nothing, "", ",") & vSN.ToString
        '        End If
        '    Next
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'End With

        'Dim VShowChideman As New Minoo.Applications.Anbar.Common.FrmShowChideman
        'With DViewer.FlexGrid
        '    VShowChideman.vKalaSn = vKalaSN
        '    VShowChideman.ShowDialog(Me)
        'End With
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        ' 	بعد از استفاده از فيلتر گزارش حال مقادير فيلتر بدست مي آيد 
        ' 		گزارش تهيه ميشود و به رويت کاربر ميرسد 
        Dim vFromDate, vToDate As String
        Dim vErrMsg As String
        Dim vStrKalaSN, vStrFilterSelectedGoroohSN, vStrFilterSelectedChidemanSN, vStrFilterSelectedTaghazaKonandehSN As String
        Dim strAnbars, strNoeAnbars As Object
        Dim strTarakoneshs As String
        Dim vSanadStatus, vNoeTarakoneshKalaNO As String
        Dim vRezerv, vIsMahaleChideman As Short

        Dim vKalaGardeshDar, vKalaMandehDar As Decimal
        Dim vKalaGardeshAll As Decimal
        Dim vOnlyKalaWithHavaleh As Decimal

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(VFilterAsnadAnbar.SelectedFromSanadDate) <> "" Then
            vFromDate = Trim(VFilterAsnadAnbar.SelectedFromSanadDate)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(VFilterAsnadAnbar.SelectedToSanadDate) <> "" Then
            vToDate = Trim(VFilterAsnadAnbar.SelectedToSanadDate)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If

        If gAnbarSN = 0 Then
            vErrMsg = vErrMsg & "انبار مشخص نشده است" & vbCrLf
        Else
            strAnbars = CStr(gAnbarSN)
        End If
        If Trim(dcbNoeAnbarSN.BoundText) = "" Then
            vErrMsg = vErrMsg & "نوع انبار مشخص نشده است" & vbCrLf
        Else
            strNoeAnbars = dcbNoeAnbarSN.BoundText
        End If

        ' اگر خطايي در فيلتر گزارش نيست مي توان گزارش را اجرا کرد
        If vErrMsg = "" Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Trim(gAnbarSelected) <> "" Then
                strAnbars = gAnbarSelected
            End If
            If Trim(VFilterAsnadAnbar.SelectedSanadStatus) <> "" Then
                vSanadStatus = VFilterAsnadAnbar.SelectedSanadStatus
            End If
            If Trim(VFilterAsnadAnbar.SelectedKalaSN) <> "" Then
                vStrKalaSN = VFilterAsnadAnbar.SelectedKalaSN
            End If
            If Trim(VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN) <> "" Then
                vStrFilterSelectedGoroohSN = VFilterAsnadAnbar.GoroohBandi_Kala_FilterSelectedGoroohSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedNoeTarakoneshKala) <> "" Then
                vNoeTarakoneshKalaNO = VFilterAsnadAnbar.SelectedNoeTarakoneshKala
            End If
            If Trim(VFilterAsnadAnbar.SelectedRezerv) <> "" Then
                vRezerv = VFilterAsnadAnbar.SelectedRezerv
            End If
            If Trim(VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN) <> "" Then
                vStrFilterSelectedChidemanSN = VFilterAsnadAnbar.Chideman_Kala_FilterSelectedChidemanSN
            End If
            If Trim(VFilterAsnadAnbar.SelectedTaghazaKonandeh) <> "" Then
                vStrFilterSelectedTaghazaKonandehSN = VFilterAsnadAnbar.SelectedTaghazaKonandeh
            End If
            If Trim(VFilterAsnadAnbar.SelectedMahaleChideman) <> "" Then
                vIsMahaleChideman = VFilterAsnadAnbar.SelectedMahaleChideman
            End If

            'شروط کالا
            vKalaGardeshDar = 0
            vKalaMandehDar = 0
            vKalaGardeshAll = 0
            If VFilterAsnadAnbar.SelectedKalaGardeshDar = 1 Then
                vKalaGardeshDar = 1
            ElseIf VFilterAsnadAnbar.SelectedKalaMandehDar = 1 Then
                vKalaMandehDar = 1
            ElseIf Trim(VFilterAsnadAnbar.SelectedKalaGardeshAll) <> "" Then
                vKalaGardeshAll = 1
            End If
            'شروط کالا

            vOnlyKalaWithHavaleh = 0
            If chkOnlyKalaWithHavaleh.Checked Then
                vOnlyKalaWithHavaleh = 1
            End If

            With GridEX1
                ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
                ' اس پي گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
                .DataSource = cn.ExecuteQuery("_abSpr_RptSefareshParam " &
                                              gVahedeTejariSN.ToString & ",'" &
                                              strAnbars & "','" &
                                              strNoeAnbars & "','" &
                                              vFromDate & "','" &
                                              vToDate & "','" &
                                              vStrKalaSN & "','" &
                                              vSanadStatus & "','" &
                                              System.DBNull.Value.ToString & "','" &
                                              vNoeTarakoneshKalaNO & "','" &
                                              vRezerv & "','" &
                                              strTarakoneshs & "','" &
                                              vStrFilterSelectedGoroohSN & "'," &
                                              vKalaGardeshDar & "," &
                                              vKalaMandehDar & "," &
                                              vKalaGardeshAll & "," &
                                              vOnlyKalaWithHavaleh & ",'" &
                                              vStrFilterSelectedChidemanSN & "'," &
                                              vIsMahaleChideman & ",'" &
                                              vStrFilterSelectedTaghazaKonandehSN & "'")
                .Refresh()
            End With

            'btnChideman.Enabled = True
            Me.Cursor = System.Windows.Forms.Cursors.Default()
        Else
            NetSql.Common.CSystem.MsgBox(vErrMsg, _
                       MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly Or _
                       MsgBoxStyle.MsgBoxRight, Me.Text)
        End If
        btnSendToTD.Enabled = True
    End Sub

    Private Sub FrmRptSefareshParam_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        InitControls()
        InitJanus()
    End Sub

    Private Sub InitJanus()
        With GridEX1.RootTable.Columns

            With .Add("Selected")
                .UseHeaderSelector = True
                .ActAsSelector = True
                .Caption = ""
            End With

            With .Add("VahedeTejariDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "واحد تجاری"
            End With
            With .Add("AnbarDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام انبار"
            End With
            With .Add("NoeAnbarDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نوع انبار"
            End With
            With .Add("KalaSN", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "KalaSN"
                .Visible = False
            End With
            With .Add("KalaNO", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام کالا"
            End With
            With .Add("VahedeSanjeshDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "واحد سنجش"
            End With
            With .Add("TedadAjza", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تعداد در کارتن"
            End With
            With .Add("Box_Mojoodi", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کارتن"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Can_Mojoodi", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "بسته"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Mojoodi", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "موجودی"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("MojoodiEtminan", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "موجودی اطمینان"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Kambood", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کمبود"
            End With
            With .Add("MeghdareTaghaza", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "مقدار تقاضا"
            End With
            With .Add("LTMotevaset", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "لید تایم متوسط"
            End With
            With .Add("LTEtminan", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "لید تایم اطمینان"
            End With
            With .Add("HazineSefaresh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "هزینه سفارش"
            End With
            With .Add("HazineNegahdari", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "هزینه نگهداری"
            End With
            With .Add("HazineKambood", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "هزینه کمبود"
            End With
            With .Add("Mojoodi_V", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "موجودی واقعی"
            End With
            With .Add("Mojoodi_Min", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "حداقل موجودی"
            End With
            With .Add("HadeaksarMojoodi", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "حداکثر موجودی"
            End With
            With .Add("MizaneSefaresh_TD", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "میزان سفارش فعلی در تدارکات"
            End With
            With .Add("MizaneSefaresh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "میزان سفارش"
            End With
        End With
    End Sub

    Private Sub InitControls()
        Dim vSql As String

        ' تهيه سلکت براي مقدار دهي کامبو
        vSql = " SELECT NoeAnbarSN, NoeAnbarDS From abNoeAnbar "
        ' با توجه به سلکت و کامبو مورد نظر اطلاعات در کامبو پر ميشود
        dcbNoeAnbarSN.Bind(cn, vSql, "NoeAnbarSN", "NoeAnbarDS")
        With dcbNoeAnbarSN
            If gNoeAnbarSN <> 0 Then
                .BoundText = CStr(gNoeAnbarSN * 1.0)
                .Enabled = False
            Else
                .Enabled = True
            End If
        End With

        ' براي اين نمونه از فيلتر گزارش خصوصيات مورد نظر تنظيم ميشود 
        ' سپس مقدار دهي اوليه ميگردد
        With VFilterAsnadAnbar
            .CheckedSanadStatus_1 = False
            .CheckedSanadStatus_4 = False
            .CheckedSanadStatus_8 = True
            .CheckedNoeTarakoneshKala_1 = False
            .CheckedNoeTarakoneshKala_2 = True
            .CheckedNoeTarakoneshKala_3 = False
            .CheckedNoeTarakoneshKala_4 = True
            .VisibleMahaleChideman = True
            .init()
            .WhereConditionColumnSanadStatus = " abSanad.SanadStatus "
            .WhereConditionColumnSanadDate = " abSanad.MoaserDate "
            .WhereConditionColumnKalaSN = " abSanadHa.KalaSN "
            .WhereConditionColumnGoroohBandiKala = " abSanadHa.KalaSN "
            .WhereConditionColumnChidemanKala = " abSanadHa.KalaPhizikiSN "
            .SetProperty()
        End With
    End Sub

    Private Sub btnSendToTD_Click(sender As System.Object, e As System.EventArgs) Handles btnSendToTD.Click
        Try

            Dim aCheckedRows As Janus.Windows.GridEX.GridEXRow() = GridEX1.GetCheckedRows()
            If (aCheckedRows.Length >= 1) Then
                Dim _frmNoeKharid As New frmNoeKharid
                If _frmNoeKharid.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    For Each row As Janus.Windows.GridEX.GridEXRow In aCheckedRows

                        If row.Cells("MizaneSefaresh").Value Is System.DBNull.Value OrElse Not Convert.ToDecimal(row.Cells("MizaneSefaresh").Value) > 0 Then
                            MsgBox("میزان سفارش باید حداقل یک باشد" & vbCrLf & _
                                   "جهت ادامه ارسال می بایست مجددا گزارش گرفته شود")
                            Exit Sub
                        End If

                        Dim ToDay As String = Strings.Right(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.FullYearWithSlash), 8)
                        cn.ExecuteQuery("tdDarkhastKala_Insert " & gSM.Identifier & "," & _
                                                                gVahedeTejariSN & "," & _
                                                                _frmNoeKharid.NoeKharid & "," & _
                                                                "''" & "," & _
                                                                gVahedeTejariSN & "," & _
                                                                _frmNoeKharid.TaghazaKonandeh & "," & _
                                                                "NULL" & "," & _
                                                                gVahedeTejariSN & "," & _
                                                                "NULL" & "," & _
                                                                "0" & "," & _
                                                                "NULL" & "," & _
                                                                CDec(row.Cells("KalaSN").Value) & "," & _
                                                                "NULL" & ",'" & _
                                                                ToDay & "','" & _
                                                                ToDay & "'," & _
                                                                CDec(row.Cells("MizaneSefaresh").Value) & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & ",'" & _
                                                                gSM.UserID_Name & "','" & _
                                                                System.Environment.MachineName & "'," & _
                                                                "0" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL" & "," & _
                                                                "NULL")
                    Next
                    MsgBox("ارسال با موفقیت انجام شد" & vbCrLf & _
                           "جهت ادامه ارسال می بایست مجددا گزارش گرفته شود")

                    'جهت جلوگیری از تکرار ارسال درخواست خرید
                    btnSendToTD.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
