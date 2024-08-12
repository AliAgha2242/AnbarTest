Public Class FrmVardehSamaneJameAnbar

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmVardehSamaneJameAnbar
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmVardehSamaneJameAnbar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmVardehSamaneJameAnbar
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmVardehSamaneJameAnbar)
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
        dbcVahedeTejari.Bind(cn, "select 0 as VahedetejariSN, 'همه موارد' as VahedetejariDS union all select VahedetejariSN, VahedetejariDS from paVahedetejari where OzveGorooh = 1 and PedarVahedeTejariSN=9.935", "VahedetejariSN", "VahedetejariDS")
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
            With .Add("KalaNo", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "کد کالا"
            End With
            With .Add("KalaDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "نام کالا"
            End With
            With .Add("KalaIDTejarat", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "شناسه سامانه تجارت"
            End With
            With .Add("ShomarehRahgiri", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "رهگیری"
            End With
            With .Add("MeghdareVaredeh", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وارده تعدادي"
                .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                .FormatString = "#,###"
                .TotalFormatString = "#,###"
            End With

            With .Add("SanadDate", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تاريخ"
            End With
      
            With .Add("AnbarDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "انبار"
            End With
         
            With .Add("TarakoneshDs", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "تراکنش"
            End With
            With .Add("SanadStatusDS", Janus.Windows.GridEX.ColumnType.Text)
                .Caption = "وضعیت"
            End With

         
         
        End With
    End Sub

    Private Sub FrmMoroorTafsiliTaadil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        InitControls()
        InitJanus()
    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        If Trim(dclFDate.Value) <> "" Then
            mFromDate = Trim(dclFDate.Value)
        Else
            NetSql.Common.CSystem.MsgBox("از تاريخ  مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If
        If Trim(dclTDate.Value) <> "" Then
            mToDate = Trim(dclTDate.Value)
        Else
            NetSql.Common.CSystem.MsgBox("تا تاريخ  مشخص نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        If Not (dbcVahedeTejari.MatchedWithList AndAlso dbcVahedeTejari.BoundText <> "") Then
            Netsql.common.csystem.MsgBox("شعبه انتخاب نشده است" & vbCrLf, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.OkOnly, "خطا")
            Exit Sub
        End If

        GridEX1.DataSource = cn.ExecuteQuery("_abSpr_GardeshVardehSamaneJameAnbar " & _
                        dbcVahedeTejari.BoundText & _
                        "," & _
                        "'" & mFromDate & "'" & _
                        "," & _
                        "'" & mToDate & "'")
        RefreshDataSet()
    End Sub
End Class