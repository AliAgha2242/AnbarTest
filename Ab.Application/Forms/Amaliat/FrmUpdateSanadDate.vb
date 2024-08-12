' OK
'Author ::عليرضا اشعري
'CreateDate :: 1385/10/03
'ModifiedDate::
'Description:: بروزرساني تاريخ اسناد پيشنويس و موقت
'System ::انبار

Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic

Friend Class FrmUpdateSanadDate
    Inherits Minoo.Base.FTBaseForm

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

    Protected Overloads Overrides Sub Dispose (ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose (Disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents pnlGridMaster As System.Windows.Forms.Panel
    Public WithEvents pnlNavigationMaster As System.Windows.Forms.Panel
    Public WithEvents pnlCommandMaster As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnUpdateSanadDate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtSanadDate As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtTozih As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnReport As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip (Me.components)
        Me.pnlGridMaster = New System.Windows.Forms.Panel
        Me.pnlNavigationMaster = New System.Windows.Forms.Panel
        Me.pnlCommandMaster = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnUpdateSanadDate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSanadDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTozih = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGridMaster
        '
        Me.pnlGridMaster.Anchor = _
            CType ((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                     Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGridMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGridMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, _
                                     CType (0, Byte))
        Me.pnlGridMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlGridMaster.Location = New System.Drawing.Point (2, 23)
        Me.pnlGridMaster.Name = "pnlGridMaster"
        Me.pnlGridMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlGridMaster.Size = New System.Drawing.Size (857, 228)
        Me.pnlGridMaster.TabIndex = 2
        '
        'pnlNavigationMaster
        '
        Me.pnlNavigationMaster.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigationMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavigationMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlNavigationMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlNavigationMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlNavigationMaster.Location = New System.Drawing.Point (2, 301)
        Me.pnlNavigationMaster.Name = "pnlNavigationMaster"
        Me.pnlNavigationMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlNavigationMaster.Size = New System.Drawing.Size (211, 33)
        Me.pnlNavigationMaster.TabIndex = 1
        '
        'pnlCommandMaster
        '
        Me.pnlCommandMaster.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.pnlCommandMaster.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCommandMaster.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCommandMaster.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.pnlCommandMaster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCommandMaster.Location = New System.Drawing.Point (468, 301)
        Me.pnlCommandMaster.Name = "pnlCommandMaster"
        Me.pnlCommandMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCommandMaster.Size = New System.Drawing.Size (391, 33)
        Me.pnlCommandMaster.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = _
            New System.Drawing.Font ("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point (2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size (812, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Tag = ""
        Me.Label1.Text = "ليست اسناد پيشنويس و موقت"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnUpdateSanadDate
        '
        Me.btnUpdateSanadDate.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnUpdateSanadDate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateSanadDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdateSanadDate.Enabled = False
        Me.btnUpdateSanadDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateSanadDate.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnUpdateSanadDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateSanadDate.Location = New System.Drawing.Point (330, 301)
        Me.btnUpdateSanadDate.Name = "btnUpdateSanadDate"
        Me.btnUpdateSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdateSanadDate.Size = New System.Drawing.Size (132, 33)
        Me.btnUpdateSanadDate.TabIndex = 58
        Me.btnUpdateSanadDate.Text = "برروزرساني تاريخ اسناد"
        Me.btnUpdateSanadDate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = _
            CType (((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add (Me.txtSanadDate)
        Me.GroupBox1.Controls.Add (Me.Label2)
        Me.GroupBox1.Controls.Add (Me.txtTozih)
        Me.GroupBox1.Controls.Add (Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point (2, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size (857, 48)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'txtSanadDate
        '
        Me.txtSanadDate.AcceptsReturn = True
        Me.txtSanadDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSanadDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSanadDate.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.txtSanadDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSanadDate.Location = New System.Drawing.Point (630, 12)
        Me.txtSanadDate.MaxLength = 0
        Me.txtSanadDate.Name = "txtSanadDate"
        Me.txtSanadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSanadDate.Size = New System.Drawing.Size (72, 24)
        Me.txtSanadDate.TabIndex = 19
        Me.txtSanadDate.Tag = ""
        Me.txtSanadDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point (714, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size (139, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "بروزرساني اسناد تا تاريخ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTozih
        '
        Me.txtTozih.AcceptsReturn = True
        Me.txtTozih.BackColor = System.Drawing.SystemColors.Window
        Me.txtTozih.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTozih.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.txtTozih.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTozih.Location = New System.Drawing.Point (30, 12)
        Me.txtTozih.MaxLength = 0
        Me.txtTozih.Name = "txtTozih"
        Me.txtTozih.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTozih.Size = New System.Drawing.Size (453, 24)
        Me.txtTozih.TabIndex = 19
        Me.txtTozih.Tag = ""
        Me.txtTozih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTozih.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, _
                                     CType (178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point (489, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size (86, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "توضيحات اسناد"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = _
            CType ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), _
                System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.SystemColors.Control
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReport.Enabled = False
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReport.Font = _
            New System.Drawing.Font ("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReport.Location = New System.Drawing.Point (216, 302)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnReport.Size = New System.Drawing.Size (111, 33)
        Me.btnReport.TabIndex = 60
        Me.btnReport.Text = "گزارش مغايرت"
        Me.btnReport.UseVisualStyleBackColor = False
        Me.btnReport.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add (Me.btnReport)
        Me.Panel1.Controls.Add (Me.GroupBox1)
        Me.Panel1.Controls.Add (Me.btnUpdateSanadDate)
        Me.Panel1.Controls.Add (Me.pnlGridMaster)
        Me.Panel1.Controls.Add (Me.pnlNavigationMaster)
        Me.Panel1.Controls.Add (Me.pnlCommandMaster)
        Me.Panel1.Controls.Add (Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point (0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size (862, 337)
        Me.Panel1.TabIndex = 61
        '
        'FrmUpdateSanadDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size (6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size (862, 337)
        Me.Controls.Add (Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = _
            New System.Drawing.Font ("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, _
                                     System.Drawing.GraphicsUnit.Point, CType (178, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point (4, 30)
        Me.Name = "FrmUpdateSanadDate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بروزرساني تاريخ اسناد پيشنويس و موقت"
        Me.GroupBox1.ResumeLayout (False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout (False)
        Me.ResumeLayout (False)

    End Sub

#End Region

#Region "Upgrade Support "

    Private Shared m_vb6FormDefInstance As FrmUpdateSanadDate
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As FrmUpdateSanadDate
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmUpdateSanadDate
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set (ByVal Value As FrmUpdateSanadDate)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#End Region

    'يك ديتا ويو از نوع ابزار جهت نمايش  تعاريف انبارگرداني تعريف شده است
    Private WithEvents DVListAsnad As CDataView
    '   براي نمايش تاريخ در فيلتر 
    Private dclSanadDate As NetSql.Components.CDateCtrl

    'يك گريد تعريف مي شود كه بتوان با مطابقت با ديتاويو ابزار از رويدادهاي آن براي عمليات خاص مورد انجام استفاده كرد
    Private WithEvents vfgGrid As NetSql.Components.VsFlexGrid

    Dim vMaxSanadGhatei As String
    Dim todayDate As String = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)


    Private Sub FrmUpdateSanadDate_Load (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Load
        Dim vResult As DataView

        Try
            vResult = _
                cn.ExecuteQuery ( _
                                 "	Select ISNULL(max(MoaserDate),'" & Trim (gHesabdariSalFDate) & _
                                 "') AS MaxSanadGhatei " & _
                                 " From abSanad  " & _
                                 " Where SanadStatus = 8  " & _
                                 " and AnbarSn = " & gAnbarSN & _
                                 " and NoeAnbarSn = " & gNoeAnbarSN & _
                                 " and MoaserDate between '" & Trim (gHesabdariSalFDate) & "' and '" & _
                                 Trim (gHesabdariSalTDate) & "' ")

            vMaxSanadGhatei = vResult.Item(0)("MaxSanadGhatei")
            todayDate = Minoo.Functions.FTDBCommonFunctions.Get_Date_Server_Jalali(cn, Functions.FTDBCommonFunctions.enmDateFormat.Normal)

        Catch ex As Exception
            MsgBox ("اطلاعات آخرين تاريخ قطعي اسناد انبار قابل دسترسي نيست")
        End Try

        dclSanadDate = New NetSql.Components.CDateCtrl (tp)
        dclSanadDate.TextBox = txtSanadDate
        dclSanadDate.Value = vMaxSanadGhatei
        Call InitDataView()

        ' با توجه به کليد دسترسي دسترسي تنظيم ميگردد
        btnUpdateSanadDate.Enabled = (gSM.TableAccessRight ("btnUpdateSanadDate") = EnumAccessRight.arAll)
        '    btnReport.Enabled = btnUpdateSanadDate.Enabled

    End Sub

    Private Sub FrmUpdateSanadDate_Closed (ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
        Handles MyBase.Closed
        DVListAsnad.Done()
        DVListAsnad = Nothing
    End Sub

    Private Sub InitDataView()
        ' تنظيم ديتاويو ابزار با جدول مربوطه و فيلدهاي آن به همراه شروط احتمالي
        DVListAsnad = New CDataView (cn)

        With DVListAsnad
            .Init (pnlGridMaster)
            .EditInGrid = False
            .AccessRight = EnumAccessRight.arView
            .AutoFetchCurrentRow = False
            .QueryName = "abQuery_ShowEslahie"
            ' جهت تهيه گزارش با توجه به پارامترهاي مورد نياز 
            ' سلکت  گزارش اجرا ميگردد و خروجي در اختيار گريد قرار ميگيرد
            .SQLSelect =
                "Select abSanad.SanadNo AS 'شماره سند',abTarakonesh.TarakoneshDS AS 'تراکنش',abSanad.MoaserDate AS 'تاريخ سند',abSanad.SabtDate AS 'تاريخ ثبت',abSanad.TaeedDate AS 'تاريخ قطعي',abVw_NoeSanad.NoeSanadDS AS 'نوع سند',abSanad.Tozih AS 'توضيحات'  " &
                " from abSanad " &
                " JOIN abTarakonesh ON abSanad.TarakoneshSn = abTarakonesh.TarakoneshSn " &
                " LEFT JOIN  abVw_NoeSanad ON abSanad.NoeSanadID = abVw_NoeSanad.NoeSanadID " &
                " Where SanadStatus <> 8  " &
                " and MoaserDate < '" & vMaxSanadGhatei & "' " &
                " and AnbarSn = " & gAnbarSN &
                " and NoeAnbarSn = " & gNoeAnbarSN &
                " and MoaserDate between '" & Trim(gHesabdariSalFDate) & "' and '" & Trim(gHesabdariSalTDate) & "' " &
                " ORDER BY abSanad.MoaserDate "

            vfgGrid = .FlexGrid
            .Refresh()
        End With

    End Sub

    Private Sub btnUpdateSanadDate_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnUpdateSanadDate.Click
        ' ثبت اسناد اصلاحيه انبارگرداني
        Dim vErrMsg As String
        Dim vSanadDate As String ', vTozih

        If _
            NetSql.Common.CSystem.MsgBox( _
                       "آيا تاريخ اسناد بروز گردد؟ با اينکار تاريخ تمامي اسناد پيشنويس و موقت قبل از تاريخ مشخص شده، به آن تاريخ بروزرساني مي شوند", _
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                       + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                       , Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If


        If todayDate IsNot Nothing Then
            If todayDate < vMaxSanadGhatei Then
                Dim res As MsgBoxResult = NetSql.Common.CSystem.MsgBox(
                       "مقدار انتخاب شده برای بروز رسانی تاریخ اسناد پیش نویس و موقت جلوتر تاریخ روز می باشد / آیا مایل به ادامه کار می باشید؟",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo _
                       + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight _
                       , Me.Text)
                If res = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If

        vSanadDate = dclSanadDate.Value
        If Trim(vSanadDate) = "" Then
            NetSql.Common.CSystem.MsgBox("تاريخ بروزرساني اسناد مشخص نشده است")
            Exit Sub
        End If

        '      vTozih = Trim(txtTozih.Text)
        ' فراخواني اس پي براي ثبت اسناد اصلاحيه انبارگرداني
        Dim vExecuteNoneQueryResult As Integer
        Try
            vExecuteNoneQueryResult = cn.ExecuteNoneQuery(" Update abSanad " &
                                                           " SET SanadDate = '" & vMaxSanadGhatei & "', " &
                                                           " MoaserDate = '" & vMaxSanadGhatei & "' " &
                                                           " Where SanadStatus <> 8  " &
                                                           " and MoaserDate < '" & vMaxSanadGhatei & "' " &
                                                           " and AnbarSn = " & gAnbarSN &
                                                           " and NoeAnbarSn = " & gNoeAnbarSN &
                                                           " and MoaserDate between '" & Trim(gHesabdariSalFDate) &
                                                           "' and '" & Trim(gHesabdariSalTDate) & "'" &
                                                           "and abSanad.TarakoneshSN NOT IN (Select TarakoneshSN From abTarakoneshGoroohHa Where TarakoneshGoroohSN = 90)")
        Catch ex As Exception
            MsgBox("خطا در بروزآوري تاريخ اسناد" + vbCrLf + ex.Message)
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If vExecuteNoneQueryResult > 0 Then
            vErrMsg = "تاريخ " & Trim(vExecuteNoneQueryResult) & " سند بروزرساني شد"
        Else
            vErrMsg = "سندي براي بروزآوري يافت نشد"
        End If
        NetSql.Common.CSystem.MsgBox(vErrMsg, _
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, _
                   Me.Text)
        DVListAsnad.Refresh()

    End Sub

    Private Sub DVListAsnad_FillDetailsWithData (ByVal aClip As Object, ByVal aFetched As Boolean) _
        Handles DVListAsnad.FillDetailsWithData

        If (gSM.TableAccessRight ("btnUpdateSanadDate") = EnumAccessRight.arAll) Then
            btnUpdateSanadDate.Enabled = True
        Else
            btnUpdateSanadDate.Enabled = False
        End If
        If aFetched Then
            If (gSM.TableAccessRight ("btnUpdateSanadDate") = EnumAccessRight.arAll) Then
                btnUpdateSanadDate.Enabled = True
            Else
                btnUpdateSanadDate.Enabled = False
            End If
        End If
        'If DVListAsnad.Fields("AnbarGardaniNO").Value <> "" Then
        'txtTozih.Text = " اسناد انبارگرداني " & _
        '  DVListAsnad.Fields("AnbarGardaniNO").Value + " _ " + DVListAsnad.Fields("AnbarGardaniDS").Value & _
        '  " به تاريخ انبارگرداني " + " : " + DVListAsnad.Fields("StartDate").Value
        'End If
    End Sub

    Private Sub btnReport_Click (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        ' به توجه به انتهاب انبارگرداني مورد نظر گزارش مغايرت تهيه ميگردد 
        'If DVListAsnad.Fields("AnbarGardaniSN").Value <> "" Then
        '  Minoo.Applications.Anbar.AnbarGardani.CAnbarGardani.ShowRptMoghayratAnbarGardani(Me.MdiParent, DVListAsnad.Fields("AnbarGardaniSN").Value)
        'End If
    End Sub

    Private Sub txtSanadDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtSanadDate.TextChanged

        If Trim(dclSanadDate.Value) <> "" Then
            vMaxSanadGhatei = dclSanadDate.Value
        End If

    End Sub
End Class
