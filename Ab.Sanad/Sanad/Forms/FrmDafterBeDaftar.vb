
' OK
'Author ::Ghafari Saeed 
'CreateDate ::  1399/09/10
'ModifiedDate::
'Description::  سند دفتر به دفتر
'System ::انبار

Option Strict Off
Option Explicit On

Imports Anbar.BRL

Public Class FrmDafterBeDaftar

    Inherits Minoo.Base.FTBaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmDafterBeDaftar
    Friend WithEvents PnlN1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GridKala As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGetMojoudi As Button
    Public WithEvents CmbAzDaftar As NetSql.Components.DataCombo
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbKala As cmpCheckedComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTozihSanad As TextBox
    Public WithEvents CmbToDaftar As NetSql.Components.DataCombo
    Friend WithEvents btnSabtSanad As Button
    Friend WithEvents Label5 As Label
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmDafterBeDaftar
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmDafterBeDaftar()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As FrmDafterBeDaftar)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PnlG1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDafterBeDaftar))
        Dim CmbKala_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridKala = New Janus.Windows.GridEX.GridEX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbKala = New cmpCheckedComboBox(Me.components)
        Me.CmbAzDaftar = New NetSql.Components.DataCombo(Me.components)
        Me.BtnGetMojoudi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PnlN1 = New System.Windows.Forms.Panel()
        Me.PnlG1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTozihSanad = New System.Windows.Forms.TextBox()
        Me.CmbToDaftar = New NetSql.Components.DataCombo(Me.components)
        Me.btnSabtSanad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridKala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.SplitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 404)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridKala)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1331, 404)
        Me.SplitContainer2.SplitterDistance = 734
        Me.SplitContainer2.TabIndex = 0
        '
        'GridKala
        '
        Me.GridKala.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridKala_DesignTimeLayout.LayoutString = resources.GetString("GridKala_DesignTimeLayout.LayoutString")
        Me.GridKala.DesignTimeLayout = GridKala_DesignTimeLayout
        Me.GridKala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridKala.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridKala.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridKala.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridKala.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GridKala.GroupByBoxVisible = False
        Me.GridKala.Location = New System.Drawing.Point(0, 78)
        Me.GridKala.Name = "GridKala"
        Me.GridKala.RecordNavigator = True
        Me.GridKala.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridKala.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKala.Size = New System.Drawing.Size(1331, 326)
        Me.GridKala.TabIndex = 11
        Me.GridKala.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.CmbKala)
        Me.Panel3.Controls.Add(Me.CmbAzDaftar)
        Me.Panel3.Controls.Add(Me.BtnGetMojoudi)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1331, 78)
        Me.Panel3.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1273, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "کالا :"
        '
        'CmbKala
        '
        Me.CmbKala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbKala_DesignTimeLayout.LayoutString = resources.GetString("CmbKala_DesignTimeLayout.LayoutString")
        Me.CmbKala.DesignTimeLayout = CmbKala_DesignTimeLayout
        Me.CmbKala.LateBinding = True
        Me.CmbKala.LateBindingTop = "100"
        Me.CmbKala.Location = New System.Drawing.Point(829, 46)
        Me.CmbKala.Name = "CmbKala"
        Me.CmbKala.SaveSettings = False
        Me.CmbKala.Size = New System.Drawing.Size(413, 22)
        Me.CmbKala.TabIndex = 127
        Me.CmbKala.ValuesDataMember = Nothing
        '
        'CmbAzDaftar
        '
        Me.CmbAzDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbAzDaftar.AutoSelectFirst = False
        Me.CmbAzDaftar.BackColor = System.Drawing.Color.White
        Me.CmbAzDaftar.BoundText = Nothing
        Me.CmbAzDaftar.BypassChangeEvent = False
        Me.CmbAzDaftar.DisplayText = ""
        Me.CmbAzDaftar.LateBindingTop = "100"
        Me.CmbAzDaftar.Location = New System.Drawing.Point(829, 10)
        Me.CmbAzDaftar.MemFilter = ""
        Me.CmbAzDaftar.Name = "CmbAzDaftar"
        Me.CmbAzDaftar.SeparatedData = Nothing
        Me.CmbAzDaftar.Size = New System.Drawing.Size(413, 22)
        Me.CmbAzDaftar.Source = Nothing
        Me.CmbAzDaftar.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbAzDaftar.TabIndex = 126
        '
        'BtnGetMojoudi
        '
        Me.BtnGetMojoudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGetMojoudi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGetMojoudi.Location = New System.Drawing.Point(561, 10)
        Me.BtnGetMojoudi.Name = "BtnGetMojoudi"
        Me.BtnGetMojoudi.Size = New System.Drawing.Size(248, 58)
        Me.BtnGetMojoudi.TabIndex = 1
        Me.BtnGetMojoudi.Text = "مشاهده کالاهای دارای موجودی"
        Me.BtnGetMojoudi.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1273, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "از دفتر:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(807, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "از دفتر:"
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage4)
        Me.TabControl4.Location = New System.Drawing.Point(39, 23)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.RightToLeftLayout = True
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(895, 237)
        Me.TabControl4.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PnlN1)
        Me.TabPage4.Controls.Add(Me.PnlG1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(887, 211)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "لیست کالاها"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PnlN1
        '
        Me.PnlN1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlN1.Location = New System.Drawing.Point(3, 174)
        Me.PnlN1.Name = "PnlN1"
        Me.PnlN1.Size = New System.Drawing.Size(881, 34)
        Me.PnlN1.TabIndex = 4
        '
        'PnlG1
        '
        Me.PnlG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlG1.Location = New System.Drawing.Point(3, 3)
        Me.PnlG1.Name = "PnlG1"
        Me.PnlG1.Size = New System.Drawing.Size(881, 170)
        Me.PnlG1.TabIndex = 0
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1331, 505)
        Me.SplitContainer1.SplitterDistance = 404
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1331, 97)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.TxtTozihSanad)
        Me.Panel4.Controls.Add(Me.CmbToDaftar)
        Me.Panel4.Controls.Add(Me.btnSabtSanad)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1331, 97)
        Me.Panel4.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 14)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "توضیحات سند انتقال :"
        '
        'TxtTozihSanad
        '
        Me.TxtTozihSanad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTozihSanad.Location = New System.Drawing.Point(115, 12)
        Me.TxtTozihSanad.Name = "TxtTozihSanad"
        Me.TxtTozihSanad.Size = New System.Drawing.Size(401, 22)
        Me.TxtTozihSanad.TabIndex = 128
        '
        'CmbToDaftar
        '
        Me.CmbToDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbToDaftar.AutoSelectFirst = False
        Me.CmbToDaftar.BackColor = System.Drawing.SystemColors.Info
        Me.CmbToDaftar.BoundText = Nothing
        Me.CmbToDaftar.BypassChangeEvent = False
        Me.CmbToDaftar.DisplayText = ""
        Me.CmbToDaftar.LateBindingTop = "100"
        Me.CmbToDaftar.Location = New System.Drawing.Point(655, 12)
        Me.CmbToDaftar.MemFilter = ""
        Me.CmbToDaftar.Name = "CmbToDaftar"
        Me.CmbToDaftar.SeparatedData = Nothing
        Me.CmbToDaftar.Size = New System.Drawing.Size(526, 22)
        Me.CmbToDaftar.Source = Nothing
        Me.CmbToDaftar.Style = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbToDaftar.TabIndex = 127
        '
        'btnSabtSanad
        '
        Me.btnSabtSanad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSabtSanad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSabtSanad.Location = New System.Drawing.Point(12, 40)
        Me.btnSabtSanad.Name = "btnSabtSanad"
        Me.btnSabtSanad.Size = New System.Drawing.Size(1307, 34)
        Me.btnSabtSanad.TabIndex = 0
        Me.btnSabtSanad.Text = "ثبت سند دفتر به دفتر"
        Me.btnSabtSanad.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1206, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "انتقال به دفتر:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(597, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 14)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "به دفتر:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "از تاریخ :"
        '
        'FrmDafterBeDaftar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1331, 505)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmDafterBeDaftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فرم ثبت سند دفتر به دفتر"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridKala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim CApp As Configuration.CAppSetting = New Configuration.CAppSetting(9.935, gSM.ApplicationID)
    Dim TarakoneshResid As Integer = IIf(CApp.GetAppConfig("gTarakoneshResidForEnteghlaMojoodi") Is System.DBNull.Value, 0, CApp.GetAppConfig("gTarakoneshResidForEnteghlaMojoodi"))
    Dim TarakoneshHavaleh As Integer = IIf(CApp.GetAppConfig("gTarakoneshHavalehForEnteghlaMojoodi") Is System.DBNull.Value, 0, CApp.GetAppConfig("gTarakoneshHavalehForEnteghlaMojoodi"))
    Dim SanadResid As Decimal = gSM.Identifier
    Dim SanadHavaleh As Decimal = gSM.Identifier


    Dim _Brl As New ClsDataAccessRule

    Private Sub FrmDafterBeDaftar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CmbAzDaftar.Bind(cn, "Select  DaftarForooshSN ,DaftarForooshDS  from paDaftarforoosh Where VahedeTejariSN=" & gVahedeTejariSN.ToString, "DaftarForooshSN", "DaftarForooshDS")
        CmbToDaftar.Bind(cn, "Select  DaftarForooshSN ,DaftarForooshDS  from paDaftarforoosh Where VahedeTejariSN=" & gVahedeTejariSN.ToString, "DaftarForooshSN", "DaftarForooshDS")

        GridKala.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        With CmbKala
            .Bind(cn, "select distinct paKala.kalasn,KalaNo+' . '+KalaDs KalaDS from abSanadha	join abSanad on abSanad.SanadSN=abSanadHa.SanadSN " &
            "Join paKala on paKala.KalaSN=abSanadHa.KalaSN " &
                        "where SanadDate>='" & gHesabdariSalFDate & "' and AnbarSN=" & gAnbarSN.ToString, "kalasn", "kalaDS")
            .ShowSelectAll = True
        End With
    End Sub

    Private Sub BtnGetMojoudi_Click(sender As Object, e As EventArgs) Handles BtnGetMojoudi.Click
        If Not IsNumeric(CmbAzDaftar.BoundText) Then
            CSystem.MsgBox("دفتر مبدا انتقال مشخص نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CmbKala.getStringValues Is Nothing Then
            CSystem.MsgBox("کالایی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CSystem.MsgBox("آیا مایل به مشاهده موجودی کالاهای انتخاب شده در " + CmbAzDaftar.Text + " می باشید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim wfrm As New Anbar.Common.Frmwait

        wfrm.Show()
        wfrm.Label3.Text = "...سیستم در حال دریافت اطلاعات موجودی می باشد..."
        wfrm.Refresh()

        Dim KalaSn As String = CmbKala.getStringValues

        Dim DvR As New DataView
        Try
            DvR = _Brl.GetMojoudiKalaHayeDaftarForoosh(gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, KalaSn, CDec(CmbAzDaftar.BoundText), cn)

            If Not DvR Is Nothing Then
                GridKala.DataSource = DvR
                GridKala.Refresh()
            End If
        Catch ex As Exception
            CSystem.MsgBox("خطا در دریافت موجودی کالاهای دفتر فروش" + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "")
        Finally
            wfrm.Close()
        End Try


    End Sub

    Private Sub btnSabtSanad_Click(sender As Object, e As EventArgs) Handles btnSabtSanad.Click

        If Not IsNumeric(CmbToDaftar.BoundText) Then
            CSystem.MsgBox("دفتر مقصد انتقال مشخص نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim CheckRow As Integer = GridKala.GetCheckedRows().Length
        If CheckRow = 0 Then
            CSystem.MsgBox("ردیف کالایی انتخاب نشده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim DaftarMabdaSn As Decimal = GridKala.GetRow(0).Cells("DaftarForooshSn").Value

        If DaftarMabdaSn.ToString = CmbToDaftar.BoundText Then
            CSystem.MsgBox("دفتر مبدا و مقصد انتقال یکسان انتخاب شده است", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        For Each grow As Janus.Windows.GridEX.GridEXRow In GridKala.GetCheckedRows

            If Not IsNumeric(grow.Cells("MeghdarEnteghal").Value) Then
                CSystem.MsgBox("مقدار انتقال مشخص نشده است" + vbNewLine + grow.Cells("KalaDS").Text, MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If grow.Cells("MeghdarEnteghal").Value <= 0 Then
                CSystem.MsgBox("مقدار انتقال مشخص نشده است" + vbNewLine + grow.Cells("KalaDS").Text, MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If grow.Cells("MeghdarEnteghal").Value > grow.Cells("Mojoudi").Value Then
                CSystem.MsgBox("مقدار انتقال " + grow.Cells("KalaDS").Text + " از موجودی بیشتر است", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If


        Next

        If CSystem.MsgBox("آیا مایل به ثبت سند دفتر به دفتر برای کالاهای انتخابی می باشید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim Wfrm As New Anbar.Common.Frmwait
        Wfrm.Show()

        Dim Today As String = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(
                                   cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)
        Dim vErrMsg As String = ""
        Dim MissionError As String = ""
        SanadHavaleh = gSM.Identifier
        Dim Identifier As Decimal = gSM.Identifier


        Try
            MissionError = "خطا در بررسی درج سند حواله " + CmbAzDaftar.Text
            Wfrm.Label3.Text = "...سیستم در حال بررسی ثبت سند حواله می باشد..."
            Wfrm.Refresh()
            cn.CallSP("_abSPC_abSanadEnter", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, gSM.Identifier _
                   , Today, 4, DBNull.Value, TarakoneshHavaleh, DBNull.Value _
                   , DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value _
                   , 4, 0, vErrMsg, DBNull.Value)
            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(MissionError + vbNewLine + vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                Exit Sub
            End If

            vErrMsg = ""
            MissionError = "خطا در درج سند حواله " + CmbAzDaftar.Text
            Wfrm.Label3.Text = "...سیستم در حال درج سند حواله می باشد..."
            Wfrm.Refresh()

            cn.CallSP("_abSanadc_InsertX", SanadHavaleh, Today, Today, gAnbarSN, gNoeAnbarSN, TarakoneshHavaleh, DBNull.Value, DaftarMabdaSn,
                        4, DBNull.Value, gVahedeTejariSN, DBNull.Value, TxtTozihSanad.Text, gSM.UserID, gSM.UserID_Name,
                      DBNull.Value, DBNull.Value, gSM.UserID_Name, System.Environment.MachineName, Today, 2, DBNull.Value)

            If Trim(vErrMsg) <> "" Then
                NetSql.Common.CSystem.MsgBox(MissionError + vbNewLine + vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                DeleteSanadSn(SanadHavaleh, "حواله")

                Exit Sub
            End If



            vErrMsg = ""

            For Each Grow As Janus.Windows.GridEX.GridEXRow In GridKala.GetCheckedRows()

                MissionError = "دریافت رهگیری های دارای موجودی " + Grow.Cells("KalaDS").Text + vbNewLine + CmbAzDaftar.Text
                Wfrm.Label3.Text = "...سیستم در حال دریافت رهگیری های دارای موجودی " & Grow.Cells("KalaDS").Text & " می باشد..."
                Wfrm.Refresh()

                Dim DVKalaPhiziki As DataView =
                cn.ExecuteQuery(
                                 "_abSPG_SelectRahgiri_DaftarForoosh  " + CStr(gVahedeTejariSN) + "," + CStr(gAnbarSN) + "," +
                                  +CStr(gNoeAnbarSN) + "," + Grow.Cells("KalaSN").Text + "," + gHesabdariSalFDate + "," +
                                 Today + "," + CStr(TarakoneshHavaleh) + "," + CStr(DaftarMabdaSn))

                Dim MeghdarEnteghal As Decimal = Grow.Cells("MeghdarEnteghal").Value
                Dim MeghdarDarjShodeh As Decimal = 0


                If DVKalaPhiziki.Count > 0 Then

                    For Each RowKalaPhiziki As DataRowView In DVKalaPhiziki

                        vErrMsg = ""

                        MissionError = "خطا در بررسی اقلام سند حواله " + CmbAzDaftar.Text +
                                                                vbNewLine + Grow.Cells("KalaDS").Text + vbNewLine + "شماره رهگیری : " + RowKalaPhiziki("ShomarehRahgiri")

                        Wfrm.Label3.Text = "...سیستم در حال بررسی ثبت " & Grow.Cells("KalaDS").Text & " می باشد..."
                        Wfrm.Refresh()

                        Dim Meghdar As Decimal = RowKalaPhiziki("Mojoodi")
                        If Meghdar >= MeghdarEnteghal Then
                            Meghdar = MeghdarEnteghal
                        End If

                        MeghdarDarjShodeh += Meghdar

                        If MeghdarDarjShodeh > MeghdarEnteghal Then
                            Meghdar = MeghdarEnteghal - (MeghdarDarjShodeh - Meghdar)
                        End If

                        If Meghdar > 0 Then
                            cn.CallSP("_abSPC_abSanadHaEnter", gVahedeTejariSN, gAnbarSN, gNoeAnbarSN, SanadHavaleh _
                                                                   , Today, 4, DBNull.Value, TarakoneshHavaleh, DBNull.Value _
                                                                   , DBNull.Value, DBNull.Value, 4, 1, vErrMsg, RowKalaPhiziki("KalaSN"), DBNull.Value _
                                                                   , Meghdar, DBNull.Value, DBNull.Value, DBNull.Value, RowKalaPhiziki("KalaPhizikiSN"), RowKalaPhiziki("ShomarehRahgiri") _
                                                                   , gSM.Identifier, 2, 1, DBNull.Value, DBNull.Value, DBNull.Value)
                            If Trim(vErrMsg) <> "" Then
                                NetSql.Common.CSystem.MsgBox(MissionError + vbNewLine + vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                                DeleteSanadSn(SanadHavaleh, "حواله")

                                Exit Sub
                            End If


                            vErrMsg = ""

                            MissionError = "خطا در درج اقلام سند حواله " + CmbAzDaftar.Text +
                                                                    vbNewLine + Grow.Cells("KalaDS").Text + vbNewLine + "شماره رهگیری : " + RowKalaPhiziki("ShomarehRahgiri")

                            Wfrm.Label3.Text = "...سیستم در حال ثبت " & Grow.Cells("KalaDS").Text & " می باشد..."
                            Wfrm.Refresh()

                            cn.CallSP("_abSanadHa_InsertX", gSM.Identifier, SanadHavaleh, DBNull.Value, DBNull.Value, RowKalaPhiziki("KalaSN"),
                                       DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, Meghdar, DBNull.Value, DBNull.Value,
                                      DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                                       DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, RowKalaPhiziki("KalaPhizikiSN"), DBNull.Value,
                                      gSM.UserID_Name, System.Environment.MachineName, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, vErrMsg)

                            If Trim(vErrMsg) <> "" Then

                                NetSql.Common.CSystem.MsgBox(MissionError + vbNewLine + vErrMsg, MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, Me.Text)
                                DeleteSanadSn(SanadHavaleh, "حواله")

                                Exit Sub
                            End If
                        End If



                    Next

                End If


            Next


            MissionError = "خطا در فرآیند کپی سند "

            Wfrm.Label3.Text = "...سیستم در حال کپی سند می باشد..."
            Wfrm.Refresh()

            Try
                cn.CallSP("abSPC_CopySanadFromSanad", SanadHavaleh, TarakoneshResid, gSM.UserID, gSM.UserID_Name)
                Dim Dv As DataView = cn.ExecuteQuery("Select  SanadSN from abSanad Where RezSN3=" & SanadHavaleh.ToString & " And AnbarSN=" & gAnbarSN.ToString & " And SanadStatus<>8 And UserNameSabt='" & gSM.UserID_Name & "' And SanadDate='" & Today & "' And tarakoneshSn=" & TarakoneshResid.ToString)
                If Dv.Count = 0 Then
                    CSystem.MsgBox("خطا در یافتن سند رسید", MsgBoxStyle.Exclamation, "خطا")
                    Exit Sub
                End If
                SanadResid = Dv(0)(0)
            Catch ex As Exception
                CSystem.MsgBox(MissionError + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "خطا")
                DeleteSanadSn(SanadHavaleh, "حواله")
                DeleteSanadSn(SanadResid, "رسید")
            End Try

            MissionError = "خطا در بروزرسانی رسید "
            Wfrm.Label3.Text = "...سیستم در حال بروزرسانی رسید ثبت شده می باشد..."
            Wfrm.Refresh()

            Try
                MissionError = "خطا در بروزرسانی تیتر رسید "
                cn.ExecuteNoneQuery("Update abSanad Set RezSN2=" & CmbToDaftar.BoundText & " Where SanadSn=" & SanadResid.ToString)
                MissionError = "خطا در بروزرسانی دفاتر فروش در اقلام سند "
                cn.ExecuteNoneQuery("update abSanadHaDaftar Set DaftarForooshSN=" & CmbToDaftar.BoundText & "  Where SanadHaSN In " &
                                                "(Select SanadHaSN From abSanadHa where SanadSN=" & SanadResid.ToString & ")")

            Catch ex As Exception
                CSystem.MsgBox(MissionError + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "خطا")
                DeleteSanadSn(SanadHavaleh, "حواله")
                DeleteSanadSn(SanadResid, "رسید")
            End Try

            CSystem.MsgBox("عملیات با موفقیت انجام شد", MsgBoxStyle.Information, "")


        Catch ex As Exception
            CSystem.MsgBox(MissionError + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "")
            DeleteSanadSn(SanadHavaleh, "حواله")
            DeleteSanadSn(SanadResid, "رسید")

        Finally
            Wfrm.Close()
        End Try


    End Sub

    Sub DeleteSanadSn(SanadSn As Decimal, ByVal NoeSanad As String)
        If SanadSn <> gSM.Identifier Then
            Try
                cn.CallSP("abSPC_DeleteSanadMovaghat", SanadSn)

            Catch ex As Exception
                CSystem.MsgBox("خطا در حذف سند " + NoeSanad, MsgBoxStyle.Information, "")

            End Try
        End If


    End Sub
End Class

