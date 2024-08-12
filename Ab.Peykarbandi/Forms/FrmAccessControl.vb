Imports NetSql.DB
Imports NetSql.DB.CConnection
Imports C1.Win.C1FlexGrid.Classic
Imports SubtotalPositionSettings = C1.Win.C1FlexGrid.SubtotalPositionEnum
Imports SubtotalSettings = C1.Win.C1FlexGrid.AggregateEnum
Imports NetSql.View
Imports System.Data

Public Class FrmAccessControl
    Inherits Minoo.Base.FTBaseForm

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmAccessControl
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmAccessControl
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmAccessControl
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmAccessControl)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer

    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(978, 635)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 326)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Location = New System.Drawing.Point(3, 281)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(348, 42)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Location = New System.Drawing.Point(738, 281)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 42)
        Me.Panel5.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(972, 272)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 305)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "مقدار ورودی : "
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(357, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "بروز رسانی"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(465, 269)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 27)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Location = New System.Drawing.Point(3, 260)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(348, 42)
        Me.Panel7.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Location = New System.Drawing.Point(738, 260)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(237, 42)
        Me.Panel8.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(972, 256)
        Me.Panel4.TabIndex = 1
        '
        'FrmAccessControl
        '
        Me.ClientSize = New System.Drawing.Size(978, 635)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmAccessControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مدیریت دسترسی"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DvMaster As NetSql.View.CDataView
    Private WithEvents DvDetail As NetSql.View.CDataView


    Private Sub FrmAccessControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AppParamByAccess As String = "0"
        If gSM.ActionEnabled("AnbarAccessControlForooshGhaza") Then
            AppParamByAccess += ",242.935"
        End If
        If gSM.ActionEnabled("AnbarAccessControlForooshDaroo") Then
            AppParamByAccess += ",262.935"
        End If
        If gSM.ActionEnabled("AnbarAccessControlMali") Then
            AppParamByAccess += ",142.935,97.935,195.935,264.935,277.935"
        End If


        Try
            DvMaster = New NetSql.View.CDataView(cn)

            With DvMaster
                .Init(Panel3, , Panel5, Panel6, CType(
                      +EnumButtonOptions.boCmdFilter + EnumButtonOptions.boCmdRefresh, EnumButtonOptions))
                .TableName = "imAppParam"

                .AccessRight = EnumAccessRight.arView
                .EditInGrid = True

                .SQLWhere = "AppParamSN in (" & AppParamByAccess & ")"
                With .Fields
                    .Add("AppParamSN",, EnumFieldOptions.foHidden)
                    .Add("AppParamFaDs").Caption = "شرح تنظیمات"
                    .Add("Tozihat").Caption = "توضیحات"
                    .Add("DataTypeSN",, EnumFieldOptions.foHidden)


                End With
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Master" + ex.Message, MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
        End Try


        Try
            DvDetail = New NetSql.View.CDataView(cn)

            With DvDetail
                .Init(Panel4, , Panel8, Panel7, CType(EnumButtonOptions.boCmdFilter + EnumButtonOptions.boCmdRefresh, EnumButtonOptions))
                .TableName = "imAppSetting"
                .AddJoin(.TableName, EnumTableJoin.tjLeftJoin, "paVahedeTejari", "VahedeTejariSN", "VahedeTejariSN")


                .AccessRight = EnumAccessRight.arView
                .EditInGrid = True
                .SQLWhere = "0=1"

                With .Fields
                    .Add("AppSettingSN",, EnumFieldOptions.foHidden)
                    With .Add("VahedeTejariSN->{VahedeTejariDS} as VahedeTejariSN", "DataCombo", EnumFieldOptions.foDefault)
                        .ComboWhereCondition = "VahedeTejariSn In (Select VahedeTejariSN from paVahedetejari where pedarvahedetejarisn=9.935)"
                        .RefreshCombo()
                        .Caption = "شعبه"
                    End With


                    .Add("Value", "Textbox", EnumFieldOptions.foDefault).Caption = "مقدار"


                End With
                .Refresh()
            End With

        Catch ex As Exception
            NetSql.Common.CSystem.MsgBox("خطا در لود پنل Detail" + ex.Message, MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.Exclamation, "خطا")
        End Try

        DvMaster.Refresh()

    End Sub


    Private Sub DvMaster_FillDetailsWithData(aClip As Object, aFetched As Boolean) Handles DvMaster.FillDetailsWithData
        If aFetched Then
            DvDetail.SQLWhere = "AppParamSN=" & DvMaster.FieldText("appParamSN")
            If DvMaster.Fields("DataTypeSN").Value = 2 Then
                DvDetail.Fields("Value").DataType = "Boolean"
            Else
                DvDetail.Fields("Value").DataType = "varchar"
            End If
            DvDetail.Refresh()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim = "" Then
            CSystem.MsgBox("مقداری برای بروزرسانی وارد نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text.Trim) And Not TextBox1.Text.Trim.Contains(",") Then
            CSystem.MsgBox("در صورتیکه چند مقدار انتخاب شده است می بایست با <,> از یکدیگر جدا شوند", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If CSystem.MsgBox("آیا مایل به بروزرسانی مقدار درج شده برای " + If(DvDetail.FlexGrid.SelectedRows >= DvDetail.DataRows, " شعب موجود در لیست ", DvDetail.FlexGrid.SelectedRows.ToString + " شعبه انتخاب شده ") + " می باشید؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
            Exit Sub
        End If


        With DvDetail.FlexGrid
            For i As Integer = 0 To .SelectedRows - 1
                If IsNumeric(.TextMatrix(.SelectedRow(i), .ColIndex("AppSettingSN"))) Then
                    cn.ExecuteNoneQuery("btSPC_UpdateHadafAccess " & .TextMatrix(.SelectedRow(i), .ColIndex("AppSettingSN")) & ",'" & TextBox1.Text.Replace(" ", "") & "'")
                End If
            Next
        End With

        DvDetail.Refresh()



    End Sub

    Private Sub DvDetail_GetGridProperties() Handles DvDetail.GetGridProperties
        With DvDetail.FlexGrid
            .SelectionMode = SelModeSettings.flexSelectionListBox
            .AllowSelection = True
        End With
    End Sub
End Class
