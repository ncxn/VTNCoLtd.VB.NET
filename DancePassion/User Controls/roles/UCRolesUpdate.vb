Imports DevExpress.XtraBars

Public Class UCRolesUpdate
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RbpGCongCu.Visible = False
        RbpGMoRong.Visible = False
    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnOK.ItemClick

        Select Case UCRoles.DataModeRoles
            Case 0
                MessageBox.Show("Thêm mới")
            Case 1
                MessageBox.Show("Sửa")
            Case 2
                MessageBox.Show("Xem")
            Case Else

        End Select
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnCancel.ItemClick
        FrmMain.RemoveDocumetns()
    End Sub
End Class
