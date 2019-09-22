Imports DevExpress.XtraSplashScreen

Public Class UcRolesManager

    Public Sub New()
        InitializeComponent()
        HasAccess(Me.Name)
        HasRoles(Me.Name)
    End Sub

    Private Sub UcRolesManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcRolesAdd, "Thêm nhóm")
        End If
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        Dim uc As New UCRolesUpdate With {
            .Role = GetSelectedRole()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(uc, "Sửa nhóm")
        End If
    End Sub

    Private Sub BtnDELETE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDELETE.ItemClick
        DeleteRole()
    End Sub

    Private Sub BtnREFRESH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnREFRESH.ItemClick
        LoadData()
    End Sub

    Private Sub BtnCANCEL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#Region " Xử lý dữ liệu"
    Private Sub LoadData()
        GrdRoles.DataSource = ClsRoles.GetInstance.GetDataTable()
    End Sub

    Private Function GetSelectedRole()

        Dim SelectedRow = GrvRoles.GetFocusedDataRow()
        Dim role As RolesDTO = Nothing
        If SelectedRow IsNot Nothing Then
            role = New RolesDTO With {
                .Role_name = SelectedRow(0),
                .Role_description = SelectedRow(1)}
        Else
            MessageBox.Show("Chọn nhóm cần sửa")
        End If

        Return role
    End Function

    Private Sub DeleteRole()
        Dim role As RolesDTO = GetSelectedRole()
        If ClsRoles.GetInstance.Delete(role) Then
            MessageBox.Show("Thành công")
            GrvRoles.DeleteRow(GrvRoles.FocusedRowHandle)
        End If
    End Sub

#End Region

End Class
