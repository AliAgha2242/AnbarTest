Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
' 
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid

' OK
'Author ::Zohreh Izadpanah
'CreateDate :: 1387/12/13
'ModifiedDate::
'Description::  درج آسان شمارش هاي انبارگرداني بدون در نظر گرفتن شماره رهگيري
'System ::انبار

Friend Class FrmDarjAsanShomareshHa
    Inherits Minoo.Base.FTBaseForm
    Private pISLoaded As Boolean

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
    Public WithEvents pnlN As System.Windows.Forms.Panel
    Public WithEvents pnlG As System.Windows.Forms.Panel
    Public WithEvents pnlC As System.Windows.Forms.Panel
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnDarjAsan As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDarjAsan = New System.Windows.Forms.Button
        Me.pnlN = New System.Windows.Forms.Panel
        Me.pnlG = New System.Windows.Forms.Panel
        Me.pnlC = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = _
            CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnDarjAsan)
        Me.GroupBox1.Controls.Add(Me.pnlN)
        Me.GroupBox1.Controls.Add(Me.pnlG)
        Me.GroupBox1.Controls.Add(Me.pnlC)
        Me.GroupBox1.Font = _
            New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(773, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ليست  کالاهاي شمارش  : "
        '
        'btnDarjAsan
        '
        Me.btnDarjAsan.Anchor = _
            CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),  _
                System.Windows.Forms.AnchorStyles)
        Me.btnDarjAsan.BackColor = System.Drawing.SystemColors.Control
        Me.btnDarjAsan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDarjAsan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDarjAsan.Font = _
            New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType(0, Byte))
        Me.btnDarjAsan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDarjAsan.Location = New System.Drawing.Point(432, 309)
        Me.btnDarjAsan.Name = "btnDarjAsan"
        Me.btnDarjAsan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDarjAsan.Size = New System.Drawing.Size(75, 29)
        Me.btnDarjAsan.TabIndex = 7
        Me.btnDarjAsan.Tag = ""
        Me.btnDarjAsan.Text = "درج شمارش"
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = _
            New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType(0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 309)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(329, 29)
        Me.pnlN.TabIndex = 3
        '
        'pnlG
        '
        Me.pnlG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                  Or System.Windows.Forms.AnchorStyles.Left) _
                                 Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlG.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlG.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlG.Font = _
            New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType(0, Byte))
        Me.pnlG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlG.Location = New System.Drawing.Point(2, 18)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(767, 286)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = _
            CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),  _
                System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = _
            New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(567, 310)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(195, 29)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'FrmDarjAsanShomareshHa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(781, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmDarjAsanShomareshHa"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "درج آسان شمارش"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmDarjAsanShomareshHa
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmDarjAsanShomareshHa
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmDarjAsanShomareshHa
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmDarjAsanShomareshHa)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    Private WithEvents DvabVw_ShomareshKala As CDataView
    Private WithEvents pFlex_abVw_ShomareshKala As AxVSFlexGrid
    Public vAnbarGardaniSN As Decimal
    Public vShomareshSN As Decimal

#End Region

    Private WithEvents txtMeghdar As TextBox

    Private Sub DvabVw_ShomareshKala_GetGridProperties() Handles DvabVw_ShomareshKala.GetGridProperties
        DvabVw_ShomareshKala.FlexGrid.FontSize = 10

        With DvabVw_ShomareshKala
            .Fields("KalaNo").Caption = "کد کالا"
            .Fields("KalaDS").Caption = "شرح کالا"
            .Fields("Meghdar").Caption = "مقدار شمارش"

        End With
    End Sub

    Private Sub FrmSelectRahgiri_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim DV As DataView
        If pISLoaded Then
            Exit Sub
        End If
        pISLoaded = True
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvabVw_ShomareshKala = New CDataView(cn)
        With DvabVw_ShomareshKala
            ''''''''''''''''''''''''''''
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdExit)
            .CommandVisible(EnumCommands.cmExit) = False
            .SQLWhere = "ShomareshSN =" & CStr(vShomareshSN)
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arAll
            .AutoFetchCurrentRow = False

            DV = cn.ExecuteQuery(" SELECT " & _
                                  " Pakala.KalaSN " & _
                                  " ,KalaNo " & _
                                  " ,KalaDS " & _
                                  " ,SUM(ISNULL(Meghdar,0)) AS Meghdar " & _
                                  " ,SUM(ISNULL(Meghdar,0)) AS MeghdarShomaresh " & _
                                  " FROM " & _
                                  " abshomareshha " & _
                                  " INNER JOIN	abAnbarGardaniHa 	ON 	abshomareshha.AnbarGardaniHaSN = abAnbarGardaniHa.AnbarGardaniHaSN " & _
                                  " INNER JOIN      abKalaPhiziki 		ON 	abAnbarGardaniHa.KalaPhizikiSN = abKalaPhiziki.KalaPhizikiSN " & _
                                  " INNER JOIN      paKala 			ON 	abKalaPhiziki.KalaSN = paKala.KalaSN " & _
                                  " WHERE ShomareshSN = " & vShomareshSN & " GROUP BY Pakala.KalaSN, KalaDS,KalaNo")
            .DataSource = DV

        End With

        pFlex_abVw_ShomareshKala = DvabVw_ShomareshKala.FlexGrid

        pFlex_abVw_ShomareshKala.Editable = EditableSettings.flexEDKbdMouse
        DvabVw_ShomareshKala.Refresh()
        DvabVw_ShomareshKala.FlexGrid.ColDataType(4) = GetType(Decimal)
        DvabVw_ShomareshKala.FlexGrid.ColHidden(5) = True
        DvabVw_ShomareshKala.FlexGrid.ColHidden(1) = True


    End Sub

    Private Sub FrmSelectRahgiri_Closing(ByVal eventSender As System.Object, _
                                          ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub FrmSelectRahgiri_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvabVw_ShomareshKala.Done()
        DvabVw_ShomareshKala = Nothing
    End Sub

    Private Sub pFlex_abVw_ShomareshKala_AfterEdit(ByVal eventSender As System.Object, _
                                                    ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles pFlex_abVw_ShomareshKala.AfterEdit
        If e.Row < pFlex_abVw_ShomareshKala.FixedRows Then Exit Sub
        If e.Col <> pFlex_abVw_ShomareshKala.get_ColIndex("Meghdar") Then Exit Sub
    End Sub

    Private Sub pFlex_abVw_ShomareshKala_BeforeEdit(ByVal eventSender As System.Object, _
                                                     ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) _
        Handles pFlex_abVw_ShomareshKala.BeforeEdit
        If e.Row < pFlex_abVw_ShomareshKala.FixedRows Then e.Cancel = True : Exit Sub
        If e.Col <> pFlex_abVw_ShomareshKala.get_ColIndex("Meghdar") Then e.Cancel = True : Exit Sub
    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    Public Sub btnDarjAsan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarjAsan.Click

        'Dim IsChecked As Boolean
        Dim j As Short

        With pFlex_abVw_ShomareshKala
            For j = .FixedRows To .Rows - 1
                If _
                    Val(.get_TextMatrix(j, .get_ColIndex("KalaSN"))) <> 0 AndAlso _
                    Val(.get_TextMatrix(j, .get_ColIndex("Meghdar"))) > 0 AndAlso _
                    Val(.get_TextMatrix(j, .get_ColIndex("Meghdar"))) <> _
                    Val(.get_TextMatrix(j, .get_ColIndex("MeghdarShomaresh"))) Then
                    DarjAsan(Val(.get_TextMatrix(j, .get_ColIndex("KalaSN"))), _
                              Val(.get_TextMatrix(j, .get_ColIndex("Meghdar"))), _
                              CStr(.get_TextMatrix(j, .get_ColIndex("KalaNo"))))
                End If
            Next
            Me.Close()
        End With
    End Sub


    Private Sub DarjAsan(ByVal vKalaSN As Decimal, ByVal vMeghdar As Decimal, ByVal vKalaNo As String)
        Dim i As Short
        Dim DV As DataView

        If vKalaSN = 4595.658 Then
            vKalaSN = vKalaSN
        End If

        DV = _
            cn.ExecuteQuery( _
                             "_abSPG_SelectRahgiri_Anbargardani  " + CStr(gVahedeTejariSN) + "," + CStr(gAnbarSN) + "," + _
                             CStr(gNoeAnbarSN) + "," + CStr(vKalaSN) + "," + gHesabdariSalFDate + "," + _
                             gHesabdariSalTDate)
        DV.Sort = "ShomarehRahgiri"

        With DV.Table
            For i = 0 To .Rows.Count - 1
                With .Rows(i)
                    If vMeghdar > 0 Then
                        vMeghdar = vMeghdar - Val(CStr(.Item("Mojoodi")))
                        .Item("Meghdar") = Val(CStr(.Item("Mojoodi"))) + IIf(vMeghdar < 0, vMeghdar, 0)
                    Else
                        .Item("Meghdar") = 0
                    End If
                End With
                If vMeghdar <= 0 Then Exit For
            Next i

            If DV.Table.Rows.Count = 0 Then
                NetSql.Common.CSystem.MsgBox( _
                           "کالاي " & vKalaNo & _
                           "  در سال مالي انتخابي داراي موجودي نمي باشد امکان درج آن از طريق درج آسان وجود ندارد.")
                Exit Sub
            End If

            If vMeghdar > 0 Then
                DV.Table.Rows(i - 1).Item("Meghdar") = Val(CStr(DV.Table.Rows(i - 1).Item("Meghdar"))) + vMeghdar
                'If MsgBox("مقدار درخواستي شما براي کالاي " & vKalaDS & "بيش از تعداد انتخابي مي باشد. به تعداد " & vMeghdar.ToString & " واحد از درخواست شما باقي ماند.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                '  Exit Sub
                'End If
            End If

            '****************درج شمارش ها *********************
            Dim ErrMsg As String = ""
            Try

                If cn.Connection.State = ConnectionState.Closed Then
                    cn.Connection.Open()
                End If

                cn.BeginTrans(cn.Connection.BeginTransaction)

                For i = 0 To .Rows.Count - 1
                    With .Rows(i)
                        If Val(.Item("Meghdar")) > 0 Then

                            cn.CallSP("_abSP_DarjAsan_ShoareshHa", gAnbarSN, vAnbarGardaniSN, vShomareshSN, _
                                       .Item("Meghdar"), .Item("KalaPhizikiSN"), gSM.UserID_Name, _
                                       System.Environment.MachineName, ErrMsg)

                            If ErrMsg <> "" Then
                                Throw New Exception(ErrMsg + "(" & vKalaNo & ")")
                            End If
                        End If
                    End With
                Next

                cn.CommitTrans()

            Catch ex As Exception
                cn.RollbackTrans()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                vMeghdar = 0
            End Try
            '****************درج شمارش ها *********************

        End With
    End Sub

End Class
