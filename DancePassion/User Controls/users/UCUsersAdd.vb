Imports DevExpress.XtraBars

Public Class UcUsersAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        HasAccess(Me.Name)

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

        If ClsUsers.GetInstance.Insert(user) Then
            MessageBox.Show("Thành công")
        End If
    End Sub
End Class
