Public Class FrmMoroorTafsiliTaadil

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmMoroorTafsiliTaadil
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmMoroorTafsiliTaadil
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMoroorTafsiliTaadil
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMoroorTafsiliTaadil)
            m_vb6FormDefInstance = Value
        End Set

    End Property

#End Region

    Private dclFDate As NetSql.Components.CDateCtrl
    Private dclTDate As NetSql.Components.CDateCtrl
    Private mFromDate As Object
    Private mToDate As Object


    Private Sub InitControls()
        dclFDate = New NetSql.Components.CDateCtrl(tp)
        dclFDate.TextBox = txtFDate
        dclFDate.Value = NetSql.Common.CShamsiDate.MiladiToShamsi(Today)

        dclTDate = New NetSql.Components.CDateCtrl(tp)
        dclTDate.TextBox = txtTDate
        dclTDate.Value = NetSql.Common.CShamsiDate.MiladiToShamsi(Today)

        dbcVahedeTejari.LateBinding = True
        dbcVahedeTejari.Bind(cn, "select 0 as VahedetejariSN, 'همه موارد' as VahedetejariDS union all select VahedetejariSN, VahedetejariDS from paVahedetejari where OzveGorooh = 1", "VahedetejariSN", "VahedetejariDS")
    End Sub

    Private Sub InitJanus()
        With GridEX1.RootTable.Columns
            With .Add("VahedetejariDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شعبه"
            End With

            '-------Add by yekta 920502-------
            With .Add("SanadNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شماره سند"
            End With
            '-------Add by yekta 920502-------

            With .Add("SanadDateMali", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تاريخ"
            End With
            With .Add("SanadDate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تاريخ سند"
            End With
            With .Add("AnbarDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انبار"
            End With
            With .Add("TarakoneshSN_Asli", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش اصلي"
            End With
            With .Add("TarakoneshDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش"
            End With
            With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام کالا"
            End With
            With .Add("Varedeh_T", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وارده تعدادي"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Varedeh_R", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وارده ريالي"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Sadereh_T", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "صادره تعدادي"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            With .Add("Sadereh_R", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "صادره ريالي"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With
            'Add by yekta 920613
            With .Add("TafsiliDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "طرف حساب"
            End With
        End With
    End Sub

    Private Sub FrmMoroorTafsiliTaadil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        If Trim(dclFDate.Value) <> "" Then
            mFromDate = Trim(dclFDate.Value)
        Else
            Netsql.common.csystem.MsgBox("از تاريخ بدهكاري مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If
        If Trim(dclTDate.Value) <> "" Then
            mToDate = Trim(dclTDate.Value)
        Else
            Netsql.common.csystem.MsgBox("تا تاريخ بدهكاري مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If Not (dbcVahedeTejari.MatchedWithList AndAlso dbcVahedeTejari.BoundText <> "") Then
            Netsql.common.csystem.MsgBox("شعبه انتخاب نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        GridEX1.DataSource = cn.ExecuteQuery("_abSpr_MoroorTafsili_Taadil " & _
                        dbcVahedeTejari.BoundText & _
                        "," & _
                        "'" & mFromDate & "'" & _
                        "," & _
                        "'" & mToDate & "'")
        RefreshDataSet()
    End Sub
End Class