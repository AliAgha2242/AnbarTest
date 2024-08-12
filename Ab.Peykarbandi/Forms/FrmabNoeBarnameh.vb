Public Class FrmabNoeBarnameh

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabNoeBarnameh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabNoeBarnameh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabNoeBarnameh()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As FrmabNoeBarnameh)
            m_vb6FormDefInstance = value
        End Set
    End Property

#End Region

    Private WithEvents MasterDataView As CDataView

    Private Sub FrmabNoeBarnameh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitMasterDataView()
    End Sub

    Private Sub InitMasterDataView()
        MasterDataView = New CDataView(cn)
        With MasterDataView
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdUpdate Or EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abNoeBarnameh"
            .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abTarakoneshGorooh", "TarakoneshGoroohSN", "TarakoneshGoroohSN")
            .EditInGrid = True
            .AutoFetchCurrentRow = True
            .AccessRight = gSM.TableAccessRight(.TableName)

            With .Fields
                With .Add("NoeBarnamehSN", "TextBox", gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                    .ReadOnly = True
                End With
                With .Add("NoeBarnamehDS", "TextBox", gSNFieldOption)
                    .Caption = "نوع بارنامه"
                End With
                With .Add("TarakoneshGoroohSN->{cast(abTarakoneshGorooh.TarakoneshGoroohNo as varchar(10)) + ' _ ' + abTarakoneshGorooh.TarakoneshGoroohDS} as TarakoneshGorooh", "DataCombo")
                    .Caption = "گروه تراکنش"
                    .ComboLateBinding = True
                End With

                With .Add("UserID_Name", , gSNFieldOption)
                    .Caption = "ثبت كننده"
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With
            .Refresh()
        End With
    End Sub

End Class
