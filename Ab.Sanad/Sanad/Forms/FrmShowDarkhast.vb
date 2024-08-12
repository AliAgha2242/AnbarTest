' OK
'Author ::سعید غفاری 
'CreateDate :: 1389/09/09
'ModifiedDate::
'Description::  انتخاب درخواست کالا و نمایش رسید های ثبت شده با درخواست ها

'System ::انبار

Option Strict Off
Option Explicit On


Imports C1.Win.C1FlexGrid.Classic
Imports AxVSFlexGrid = NetSql.Components.VsFlexGrid
Imports C1.Win.C1FlexGrid

Friend Class FrmShowDarkhast
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
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
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
    Friend WithEvents ChkState0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMandeh As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState4 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState2 As System.Windows.Forms.CheckBox
    Public WithEvents BtnOK As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnlG = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.CheckMandeh = New System.Windows.Forms.CheckBox()
        Me.ChkState4 = New System.Windows.Forms.CheckBox()
        Me.ChkState3 = New System.Windows.Forms.CheckBox()
        Me.ChkState2 = New System.Windows.Forms.CheckBox()
        Me.ChkState0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.pnlN)
        Me.GroupBox1.Controls.Add(Me.pnlG)
        Me.GroupBox1.Controls.Add(Me.pnlC)
        Me.GroupBox1.Controls.Add(Me.BtnOK)
        Me.GroupBox1.Controls.Add(Me.CheckMandeh)
        Me.GroupBox1.Controls.Add(Me.ChkState4)
        Me.GroupBox1.Controls.Add(Me.ChkState3)
        Me.GroupBox1.Controls.Add(Me.ChkState2)
        Me.GroupBox1.Controls.Add(Me.ChkState0)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(779, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "لیست درخواستهای این کالا"
        '
        'pnlN
        '
        Me.pnlN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlN.BackColor = System.Drawing.SystemColors.Control
        Me.pnlN.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlN.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlN.Location = New System.Drawing.Point(4, 312)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlN.Size = New System.Drawing.Size(210, 36)
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
        Me.pnlG.Location = New System.Drawing.Point(2, 15)
        Me.pnlG.Name = "pnlG"
        Me.pnlG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlG.Size = New System.Drawing.Size(773, 293)
        Me.pnlG.TabIndex = 2
        '
        'pnlC
        '
        Me.pnlC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlC.BackColor = System.Drawing.SystemColors.Control
        Me.pnlC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlC.Location = New System.Drawing.Point(574, 314)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlC.Size = New System.Drawing.Size(199, 36)
        Me.pnlC.TabIndex = 1
        Me.pnlC.TabStop = True
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOK.Location = New System.Drawing.Point(6, 8)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(53, 29)
        Me.BtnOK.TabIndex = 13
        Me.BtnOK.Tag = ""
        Me.BtnOK.Text = "انتخاب"
        Me.BtnOK.UseVisualStyleBackColor = False
        Me.BtnOK.Visible = False
        '
        'CheckMandeh
        '
        Me.CheckMandeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckMandeh.AutoSize = True
        Me.CheckMandeh.Checked = True
        Me.CheckMandeh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckMandeh.Location = New System.Drawing.Point(184, 15)
        Me.CheckMandeh.Name = "CheckMandeh"
        Me.CheckMandeh.Size = New System.Drawing.Size(119, 17)
        Me.CheckMandeh.TabIndex = 12
        Me.CheckMandeh.Text = "فقط درخواستهای باز"
        Me.CheckMandeh.UseVisualStyleBackColor = True
        Me.CheckMandeh.Visible = False
        '
        'ChkState4
        '
        Me.ChkState4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState4.AutoSize = True
        Me.ChkState4.Location = New System.Drawing.Point(327, 15)
        Me.ChkState4.Name = "ChkState4"
        Me.ChkState4.Size = New System.Drawing.Size(50, 17)
        Me.ChkState4.TabIndex = 11
        Me.ChkState4.Text = "ابطال"
        Me.ChkState4.UseVisualStyleBackColor = True
        Me.ChkState4.Visible = False
        '
        'ChkState3
        '
        Me.ChkState3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState3.AutoSize = True
        Me.ChkState3.Location = New System.Drawing.Point(406, 16)
        Me.ChkState3.Name = "ChkState3"
        Me.ChkState3.Size = New System.Drawing.Size(56, 17)
        Me.ChkState3.TabIndex = 10
        Me.ChkState3.Text = "تصویب"
        Me.ChkState3.UseVisualStyleBackColor = True
        Me.ChkState3.Visible = False
        '
        'ChkState2
        '
        Me.ChkState2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState2.AutoSize = True
        Me.ChkState2.Location = New System.Drawing.Point(491, 15)
        Me.ChkState2.Name = "ChkState2"
        Me.ChkState2.Size = New System.Drawing.Size(56, 17)
        Me.ChkState2.TabIndex = 9
        Me.ChkState2.Text = "قطعی"
        Me.ChkState2.UseVisualStyleBackColor = True
        Me.ChkState2.Visible = False
        '
        'ChkState0
        '
        Me.ChkState0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState0.AutoSize = True
        Me.ChkState0.Location = New System.Drawing.Point(561, 15)
        Me.ChkState0.Name = "ChkState0"
        Me.ChkState0.Size = New System.Drawing.Size(71, 17)
        Me.ChkState0.TabIndex = 8
        Me.ChkState0.Text = "پیشنویس"
        Me.ChkState0.UseVisualStyleBackColor = True
        Me.ChkState0.Visible = False
        '
        'FrmShowDarkhast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "FrmShowDarkhast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشاهده درخواستها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmShowDarkhast
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmShowDarkhast
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmShowDarkhast
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmShowDarkhast)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "PrivateVariablesDefinition"

    'يك ديتا ويو از نوع ابزار جهت نمايش  کالاهاي فيزيکي تعريف شده است
    Private WithEvents DvabDarkhastkala As CDataView
    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents pFlex_abDarkhastkala As AxVSFlexGrid

    ' کالا فيزيکي انتخاب شده
    Private mSelected As Object
    ' کالاي مورد نظر جهت نمايش کالافيزيکي ها 
    Private mKalaSN, mSanadhaSN As Decimal
    Private mMeghdar As Decimal
    Private mMoaserDate As String
    Private mKalaDs As String
    Private mSanadRow As DataRow
    Private mMode As Byte
    Private mNoeMadomiSN As Decimal
    Private mNoeMarjooeiSN As Decimal
    Private mNoeZayeatSN As Decimal
    Private mDarkhstHaSN As Decimal
    'Private mdvSanadHa As DataView

    Private DV As DataView

#End Region

#Region "PropertyDefinition"

    Public Property SanadhaSN() As Decimal
        Get
            SanadhaSN = mSanadhaSN
        End Get
        Set(ByVal Value As Decimal)
            mSanadhaSN = Value
        End Set
    End Property

#End Region

    Private Sub DvabVw_KalaKalaPhiziki_GetGridProperties() Handles DvabDarkhastkala.GetGridProperties
        With DvabDarkhastkala
            .Refresh()
            With .Fields
                With .Item("KalaNO")
                    .Caption = "کد کالا"
                End With
                With .Item("KalaDS")
                    .Caption = "نام کالا"
                End With
                With .Item("DarkhastKalaNO")
                    .Caption = "شماره درخواست"
                End With
                With .Item("DarkhastKalaDate")
                    .Caption = "تاریخ درخواست"
                End With
                With .Item("MeghdareVAredeh")
                    .Caption = "مقدار کل رسید"
                End With
                With .Item("Tedad")
                    .Caption = "مقدار درخواست"
                End With
            End With
        End With
    End Sub

    Private Sub FrmSelectDarkhast_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        If pISLoaded Then
            Exit Sub
        End If
        pISLoaded = True
        mMode = 0
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DvabDarkhastkala = New CDataView(cn)
        With DvabDarkhastkala
            ''''''''''''''''''''''''''''
            .Init(pnlG, , pnlC, pnlN, EnumButtonOptions.boCmdExit)
            '.TableName = "abSanadhaDarkhast"

            '.AddJoin("_abVw_GetDarkhasthayeSanadha", EnumTableJoin.tjLeftJoin, "SanadhaSN", "SanadhaSN", "SanadStatusSN")

            .DataSource = cn.ExecuteQuery("Exec _abspG_GetDarkhasthayeSanadha " & SanadhaSN & "")
            .Text = Me.Text
            .EditInGrid = False
            .NextRowAfterSave = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            .Refresh()

            .SQLOrderBy = "DarkhastKalaDate"

            pFlex_abDarkhastkala = .FlexGrid
            pFlex_abDarkhastkala.Editable = EditableSettings.flexEDKbdMouse
            '.FlexGrid.ColDataType(1) = GetType(Boolean)

        End With

        DvabDarkhastkala.Refresh()

    End Sub

    Private Sub FrmSelectDarkhast_Closing(ByVal eventSender As System.Object, _
                                          ByVal eventArgs As System.ComponentModel.CancelEventArgs) _
        Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        eventArgs.Cancel = True
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub FrmSelectDarkhast_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DvabDarkhastkala.Done()
        DvabDarkhastkala = Nothing
    End Sub

    Public Sub LoadForm()
        MyBase.OnLoad(New System.EventArgs)
    End Sub

    
End Class
