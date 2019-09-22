
Public Class UcUsersManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        HasAccess(Me.Name)
        HasRoles(Me.Name)
    End Sub

#Region " Forms"
    Private Sub UcUsersManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loaddata()
    End Sub

    Private Sub BtnCANCEL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UCUsersAdd, "Thêm thành viên")
        End If
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        Dim uc As New UcUsersUpdate With {
            .CurrentUser = GetUserDTO()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(uc, "Cập nhật thông tin")
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"
    Private Sub Loaddata()
        Dim data = ClsUsers.GetInstance.GetDataTableUsers()
        GrdUsers.DataSource = data
        GrvUsers.OptionsBehavior.ReadOnly = True
    End Sub

    Private Function GetUserDTO() As UsersDTO
        Dim SelectedRow = GrvUsers.GetFocusedDataRow()

        Dim UserDTO As New UsersDTO With {
            .User_name = SelectedRow(0).ToString(),
            .User_first_name = SelectedRow(1).ToString(),
            .User_last_name = SelectedRow(2).ToString(),
            .User_email = SelectedRow(3).ToString(),
            .User_status = CInt(SelectedRow(4)),
            .User_created_at = CDate(SelectedRow(5)),
            .User_updated_at = CDate(SelectedRow(6))}
        Return UserDTO
    End Function
#End Region

End Class
