Imports DevExpress.XtraSplashScreen

Public Class FrmUsersLogIn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        login()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub Login()
        Dim status As User_status = User_status.NotExists
        Dim sMessage As String = String.Empty

        Dim objUser As UsersDTO = ClsUsers.GetInstance.Login(txtUserName.Text.Trim(), txtPassWord.Text.Trim(), status)

        Select Case status
            Case User_status.NotExists
                sMessage = "Không có người dùng này"
            Case User_status.WrongPass
                sMessage = "Không đúng mật khẩu"
            Case User_status.Locked
                sMessage = "Người dùng này đã bị khóa"
            Case User_status.Active
                'Tất cả các biến đều toàn cục dạng list(Object) colection; muốn lấy giá trị có thể dùng linq hoặc loop throught
                ' Lấy user hiện tại (single)
                CurrentUser.User = objUser
                ' Lấy roles hiện tại của user (multi)
                CurrentUserRoles.RolesByUserName = ClsUserRoles.GetInstance.GetRolesByCurrentUserName()
                ' Lấy quyền hạn của user hiện tại thông qua roles (multi)
                CurrentRolesControlsAccess.RolesControlsAccess = ClsRoleManager.GetInstance.GetControlsAccessByUserName()
                ' Lấy tập hợp các chức năng trên form
                CurrentControlsAccess.ControlsAccessColection = ClsControlsAccess.GetInstance.GetList()
                sMessage = "Đăng nhập thành công"
                ' Refresh Main menu
                RefreshMainMenu()
                Me.Close()
        End Select
    End Sub
    Public Sub RefreshMainMenu()
        FrmMain.Menuhanlder()
    End Sub
End Class