Public Class FrmUsersLogIn
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim status As user_status = user_status.NotExists
        Dim sMessage As String = String.Empty

        Dim objUser As UsersDTO = UsersDAL.GetInstance.Login(txtUserName.Text.Trim(), txtPassWord.Text.Trim(), status)

        Select Case status
            Case user_status.NotExists
                sMessage = "Không có người dùng này"
            Case User_status.Wrongpass
                sMessage = "Không đúng mật khẩu"
            Case user_status.Locked
                sMessage = "Người dùng này đã bị khóa"
            Case user_status.OK
                CurrentUsers.CurrentUser = objUser
                sMessage = "Đăng nhập thành công"
                'Return
        End Select

    End Sub
End Class