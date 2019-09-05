Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Public Class FrmUsersGetActiveCode
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        InitializeComponent()
    End Sub
#Region " Thiết kế"


    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsersGetActiveCode))
        Me.TxtUserOrEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnGetActiveCode = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtUserOrEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUserOrEmail
        '
        Me.TxtUserOrEmail.Location = New System.Drawing.Point(10, 40)
        Me.TxtUserOrEmail.Name = "TxtUserOrEmail"
        Me.TxtUserOrEmail.Size = New System.Drawing.Size(280, 40)
        Me.TxtUserOrEmail.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(163, 17)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tên đăng nhập hoặc email.?"
        '
        'BtnGetActiveCode
        '
        Me.BtnGetActiveCode.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnGetActiveCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGetActiveCode.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.actions_send
        Me.BtnGetActiveCode.Location = New System.Drawing.Point(50, 100)
        Me.BtnGetActiveCode.Name = "BtnGetActiveCode"
        Me.BtnGetActiveCode.Size = New System.Drawing.Size(200, 40)
        Me.BtnGetActiveCode.TabIndex = 2
        Me.BtnGetActiveCode.Text = "Lấy mã kích hoạt"
        '
        'FrmUsersGetActiveCode
        '
        Me.ClientSize = New System.Drawing.Size(298, 150)
        Me.Controls.Add(Me.BtnGetActiveCode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TxtUserOrEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsersGetActiveCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lấy mã kích hoạt mật khẩu"
        CType(Me.TxtUserOrEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtUserOrEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnGetActiveCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
#End Region
    Private Sub BtnGetActiveCode_Click(sender As Object, e As EventArgs) Handles BtnGetActiveCode.Click
        GenActiveCode(TxtUserOrEmail.Text, TxtUserOrEmail.Text)
    End Sub

#Region " Xử lý dữ liệu"
    Private Sub GenActiveCode(User_name As String, User_email As String)
        Dim status As User_status = User_status.NotExists
        Dim sMessage As String = String.Empty
        Dim ActiveCode As String = String.Empty

        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)

        Dim objUser As UsersDTO = ClsUsers.GetInstance.CheckUser(status, User_name, User_email)

        Select Case status
            Case User_status.NotExists
                sMessage = "Không có người dùng này"
                SplashScreenManager.CloseOverlayForm(handle)
            Case User_status.Locked
                sMessage = "Người dùng này đã bị khóa"
                SplashScreenManager.CloseOverlayForm(handle)
            Case User_status.Active
                'Get code
                ActiveCode = Security.RandomPassWord(16)
                'Send email
                ClsMailServer.GetInstance.SendMailMessage("ncxn.pp@gmail.com", ActiveCode)
                'Insert to Users_email_confim
                UpdateDB(ActiveCode)
                Me.Close()
                SplashScreenManager.CloseOverlayForm(handle)
                FrmUsersResetPass.Show()
        End Select
        If sMessage IsNot String.Empty Then
            XtraMessageBox.Show(sMessage, "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub UpdateDB(ActiveCode As String)
        Dim UsersConfirm As New UsersConfirmDTO With {
            .User_name = TxtUserOrEmail.Text,
            .Activecode = ActiveCode,
            .Confirmed = 0,
            .Created_at = Now(),
            .Updated_at = Now()}
        ClsUsersConfirm.GetInstance.Insert(UsersConfirm)
    End Sub
#End Region
End Class
