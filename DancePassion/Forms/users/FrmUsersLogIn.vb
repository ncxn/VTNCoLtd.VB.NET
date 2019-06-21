Public Class FrmUsersLogIn
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim status As User_status = User_status.NotExists
        Dim sMessage As String = String.Empty

        Dim objUser As UsersDTO = Users.GetInstance.Login(txtUserName.Text.Trim(), txtPassWord.Text.Trim(), status)

        Select Case status
            Case User_status.NotExists
                sMessage = "Không có người dùng này"
            Case User_status.WrongPass
                sMessage = "Không đúng mật khẩu"
            Case User_status.Locked
                sMessage = "Người dùng này đã bị khóa"
            Case User_status.Active
                CurrentUser.User = objUser
                sMessage = "Đăng nhập thành công"
                'Return
        End Select

    End Sub
End Class