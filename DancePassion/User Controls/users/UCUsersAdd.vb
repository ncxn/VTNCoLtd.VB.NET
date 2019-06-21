Imports DevExpress.XtraBars

Public Class UCUsersAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Thủ tục phân quyền: khi form hiện lên thì lấy định nghĩa các action trong phần phân quyền.
        ' GenerateAction(me)
        'RbpChucNang.Visible = False
        RbpGCongCu.Visible = False
        RbpGMoRong.Visible = False

    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnOK.ItemClick
        Save()
    End Sub
    Private Sub Save()
        Dim user As New UsersDTO With {
            .User_name = TxtUserName.Text,
            .User_first_name = TxtUserFirstName.Text,
            .User_last_name = TxtUserLastName.Text,
            .User_email = TxtUserEmail.Text,
            .User_password = TxtUserPass.Text,
            .User_status = 1,
            .User_created_at = Now(),
            .User_updated_at = Now()
        }

        If Users.GetInstance.InsertUsers(user) Then
            MessageBox.Show("Thành công")
        End If
    End Sub
End Class
