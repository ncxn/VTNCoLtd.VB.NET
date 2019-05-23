Imports System.Threading
Imports DevExpress.XtraBars.Ribbon

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")
        'rbpHeThong.Visible = False
    End Sub

    Private Sub DangNhap_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles DangNhap.ItemClick
        LogIn.ShowDialog()
    End Sub

    Private Sub TaiKhoanCaNhan_SelectedChanged(sender As Object, e As BackstageViewItemEventArgs) Handles TaiKhoanCaNhan.SelectedChanged
        TaiKhoanCaNhan.ContentControl.Controls.Add(New userprofiles)
    End Sub
End Class
