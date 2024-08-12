Public Class FrmabTarakoneshGorooh

    Private WithEvents MasterDataView As CDataView
    Private WithEvents DetailDataView As CDataView

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmabTarakoneshGorooh
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmabTarakoneshGorooh
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmabTarakoneshGorooh()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As FrmabTarakoneshGorooh)
            m_vb6FormDefInstance = value
        End Set
    End Property

#End Region

    Private Sub FrmabTarakoneshGorooh_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        InitMasterDataView()
        InitDetailDataView()
        MasterDataView.Refresh()
    End Sub

    Private Sub InitMasterDataView()
        MasterDataView = New CDataView(cn)
        With MasterDataView
            .Init(pnlG1, , pnlC1, pnlN1, EnumButtonOptions.boCmdInsert Or EnumButtonOptions.boCmdUpdate Or EnumButtonOptions.boCmdDelete Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint Or EnumButtonOptions.boCmdRefresh)
            .TableName = "abTarakoneshGorooh"
            .EditInGrid = True
            .AutoFetchCurrentRow = True
            .AccessRight = gSM.TableAccessRight(.TableName)

            With .Fields
                With .Add("TarakoneshGoroohSN", "TextBox", gSNFieldOption)
                    '.DefaultValue = gSM.Identifier
                    .DefaultValue = 0
                    .ReadOnly = True
                    .DataType = "Int"
                End With
                With .Add("TarakoneshGoroohNo", "TextBox")
                    .Caption = "کد گروه تراکنش"
                    .DataType = "Integer"
                End With
                With .Add("TarakoneshGoroohDS", "TextBox")
                    .Caption = "گروه تراکنش"
                End With

                With .Add("UserID_Name", , EnumFieldOptions.foDefault)
                    .Caption = "ثبت كننده"
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With

        End With
    End Sub

    Private Sub InitDetailDataView()
        DetailDataView = New CDataView(cn)
        With DetailDataView
            .Init(pnlG2, , pnlC2, pnlN2, EnumButtonOptions.boCmdModify Or EnumButtonOptions.boCmdFilter Or EnumButtonOptions.boCmdExit Or EnumButtonOptions.boCmdPrint)
            .TableName = "abTarakoneshGoroohHa"
            '.AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "abTarakoneshGorooh", "TarakoneshGoroohSN", "TarakoneshGoroohSN")
            .AccessRight = gSM.TableAccessRight(.TableName)
            .AutoFetchCurrentRow = True
            .EditInGrid = True

            With .Fields
                With .Add("TarakoneshGoroohHaSN", "TextBox", gSNFieldOption)
                    .DefaultValue = gSM.Identifier
                    .ReadOnly = True
                End With
                With .Add("TarakoneshGoroohSN->abTarakoneshGorooh.TarakoneshGoroohSN", "TextBox", EnumFieldOptions.foHidden)
                    .Caption = "TarakoneshGoroohSN"
                End With
                With .Add("TarakoneshSN->{cast(abTarakonesh.TarakoneshNo as varchar(10)) + ' _ ' + abTarakonesh.TarakoneshDS} as TarakoneshDS", "DataCombo")
                    .Caption = "تراکنش انبار"
                    .ComboLateBinding = True
                End With
                With .Add("FromDate", "TextBox")
                    .Caption = "از تاريخ"
                End With
                With .Add("ToDate", "TextBox")
                    .Caption = "تا تاريخ"
                End With
                With .Add("UserID_Name", , EnumFieldOptions.foDefault)
                    .Caption = "ثبت كننده"
                    .DefaultValue = gSM.UserID_Name
                End With
                With .Add("Host_Name", , EnumFieldOptions.foHidden)
                    .DefaultValue = System.Environment.MachineName
                End With
                .Add("RecChksum", , EnumFieldOptions.foHidden)
            End With
            .Parent = MasterDataView

        End With
    End Sub

End Class
