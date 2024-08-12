
Imports VB = Microsoft.VisualBasic

Public Class FrmRptMoghayeratShoab

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmRptMoghayeratShoab
    Private Shared m_InitializingDefInstance As Boolean
    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl


    Public Shared Property DefInstance() As FrmRptMoghayeratShoab
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmRptMoghayeratShoab
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmRptMoghayeratShoab)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub InitControls()
        dbcSanadNo.LateBinding = True
        dbcSanadNo.ShowSelectAll = True
        dbcSanadNo.Bind(cn, "SELECT Top 100 Percent SanadSN,cast(SanadNO as varchar(15)) + '-' +  TafsiliDS  As SanadDS" & _
                            " From abSAnad left join matafsili on absanad.tafsilisn=matafsili.tafsilisn " & _
                            " order by SanadNO", "SanadSN", "SanadDS")

        dbcTarakonesh.LateBinding = True
        dbcTarakonesh.ShowSelectAll = True
        dbcTarakonesh.Bind(cn, "SELECT Top 100 Percent TarakoneshSN, TarakoneshNo + '-' + TarakoneshDs as Tarakonesh " & _
          " From abTarakonesh Where Output=1 order by TarakoneshNo", "TarakoneshSN", "Tarakonesh")

        dbcTafsili.LateBinding = True
        dbcTafsili.ShowSelectAll = True
        dbcTafsili.Bind(cn, "Select distinct Top 100 Percent matafsili.tafsilisn,tafsilids from matafsili inner join absanad on matafsili.tafsilisn=absanad.tafsilisn " & _
          " where absanad.vahedetejarisn= " & gVahedeTejariSN & " and tarakoneshsn>50 order by matafsili.tafsilisn", "TarakoneshSN", "Tarakonesh")


        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFromDarkhastDate
        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtToDarkhastDate

        If Trim(gHesabdariSalFDate) <> "" And Trim(gHesabdariSalTDate) <> "" Then
            dclFDate.Value = gHesabdariSalFDate
            dclTDate.Value = gHesabdariSalTDate

        Else
            ' تهيه تاريخ از سرور
            dclFDate.Value = VB.Left(Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal), 2) & "0101"
            dclTDate.Value = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali( _
                                                                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        End If

        Dim arrList As New Collections.ArrayList
        arrList.Add(0.0)
        With dbcSanadNo
            .CheckedValues = arrList.ToArray()
            .DroppedDown = True
            .Enabled = True
        End With
        With dbcTarakonesh
            .CheckedValues = arrList.ToArray()
            .DroppedDown = True
            .Enabled = True
        End With
        With dbcTafsili
            .CheckedValues = arrList.ToArray()
            .DroppedDown = True
            .Enabled = True
        End With


    End Sub

    Private Sub InitJanus()
        '        Sanadno, Sanaddate, Tarakoneshsn, TarakoneshDS, Tafsilisn, TafsiliDS, Sanadstatus,
        'Vahedetejarisn, VahedeTejariDS, Anbarsn, Anbards, Shomarehsefaresh, SUM(RialeSadereh)
        With GridEX1.RootTable.Columns
            With .Add("Sanadno", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شماره سند"
            End With
            With .Add("Sanaddate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تاریخ"
            End With
            With .Add("TarakoneshDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش"
            End With
            With .Add("TafsiliDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "طرف حساب"
            End With
            With .Add("Sanadstatus", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وضعیت سند"
            End With
            With .Add("VahedeTejariDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "واحد تجاری"
            End With
            With .Add("Anbards", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انبار"
            End With
            With .Add("Shomarehsefaresh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شماره ارجاع"
            End With
            With .Add("RialeSadereh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "ریال"
            End With
        End With

    End Sub

    Private Sub FrmRTarakoneshGorooh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim vFromDate As Object
        Dim vToDate As Object
        Dim vErrMsg As String

        ' کنترل فيلدهاي اجباري مورد نياز گزارش   + لحاظ کردن مقادير فيلتر انبار در پارامترهاي اين گزارش
        If Trim(dclFDate.Text) <> "" Then
            vFromDate = Trim(dclFDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "از تاريخ مشخص نشده است"
        End If
        If Trim(dclTDate.Text) <> "" Then
            vToDate = Trim(dclTDate.Value)
        Else
            vErrMsg = vErrMsg & Chr(13) & "تا تاريخ مشخص نشده است"
        End If


        GridEX1.DataSource = cn.ExecuteQuery("_abSPR_VAzneRialiHavalehha " & _
                IIf(dbcSanadNo.getStringValues() <> "" And dbcSanadNo.MatchedWithList, dbcSanadNo.getStringValues(), "") & "," & _
                IIf(dbcTarakonesh.getStringValues() <> "" And dbcTarakonesh.MatchedWithList, dbcTarakonesh.getStringValues(), "") & "," & _
                IIf(dbcTafsili.getStringValues() <> "" And dbcTafsili.MatchedWithList, dbcTafsili.getStringValues(), "") & ",'" & _
                vFromDate & "','" & vToDate & "'")

        RefreshDataSet()

        Me.Cursor = System.Windows.Forms.Cursors.Default()
    End Sub

End Class
