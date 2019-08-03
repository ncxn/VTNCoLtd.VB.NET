Imports System.ComponentModel
Imports DevExpress.XtraEditors

Public Class UcUsersUpdate
    Public CurrentUser As UsersDTO
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'RbpChucNang.Visible = False
        HasAccess(Me.Name)

    End Sub

#Region " Form"
    Private Sub UCUsersUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnCANCEL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub LoadData()
        If CurrentUser IsNot Nothing Then
            txtUser_Name.Text = CurrentUser.User_name
            txtUser_Status.Text = ""
            txtUser_FirstName.Text = CurrentUser.User_first_name
            txtUser_LastName.Text = CurrentUser.User_last_name
            txtUser_Email.Text = CurrentUser.User_email
        End If
    End Sub
    Private Sub UpdateDB()
        Dim user As New UsersDTO With {
            .User_name = txtUser_Name.Text,
            .User_first_name = txtUser_FirstName.Text,
            .User_last_name = txtUser_LastName.Text,
            .User_email = txtUser_Email.Text,
            .User_status = CInt(txtUser_Status.Text),
            .User_created_at = CurrentUser.User_created_at,
            .User_updated_at = Now(),
            .User_id = CurrentUser.User_id
        }
        If ClsUsers.GetInstance.Update(user) Then

        End If
    End Sub

#End Region

#Region " Tiện ích"
    Private Sub txtUser_Status_Validating(sender As Object, e As CancelEventArgs) Handles txtUser_Status.Validating
        Dim edit = TryCast(sender, TextEdit)
        Dim value As Integer
        If Not Integer.TryParse(edit.EditValue.ToString(), value) Then
            txtUser_Status.ErrorText = "Giá trị phải là số 0 -> 3"
            e.Cancel = True
        Else
            Dim x = Convert.ToInt32(txtUser_Status.Text)
            If x < 0 Or x > 3 Then
                txtUser_Status.ErrorText = "Giá trị phải là số 0 -> 3"
                e.Cancel = True
            End If
        End If

    End Sub

#End Region

End Class
