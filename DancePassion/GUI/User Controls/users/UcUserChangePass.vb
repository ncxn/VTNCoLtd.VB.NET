Imports DevExpress.XtraEditors
Imports VTNcoLtd.BUS

Public Class UcUserChangePass
    Public CurrentUser As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Forms"
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub

    Private Sub BtnCANCEL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        RemoveTab()
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub UpdateDB()
        Dim userName As String = TxtUserName.Text
        Dim OldPw As String = TxtOldPw.Text
        Dim NewPw As String = TxtNewPw.Text

        If ClsUsers.GetInstance.ChangePassWord(userName, OldPw, NewPw) Then
            XtraMessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK)
        Else
            XtraMessageBox.Show("Thay đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub

#End Region
End Class
