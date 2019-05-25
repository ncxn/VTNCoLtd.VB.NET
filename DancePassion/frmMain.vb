Imports System.Threading
Imports DevExpress.XtraBars.Ribbon

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")
        '    'rbpHeThong.Visible = False
        '    Dim button1 As New BackstageViewButtonItem() With {
        '.Caption = "Save",
        '.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/save/save_32x32.png")}
        '    Dim tab1 As New BackstageViewTabItem() With {
        '        .Caption = "Save As...",
        '        .Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/save/saveas_32x32.png")}
        '    Slide_menu.Items.Add(button1)
        '    Slide_menu.Items.Add(tab1)
        '    Slide_menu.Items.Insert(1, New BackstageViewItemSeparator())
    End Sub

    Private Sub DangNhap_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles DangNhap.ItemClick
        LogIn.ShowDialog()
    End Sub

    Private Sub TaiKhoanCaNhan_SelectedChanged(sender As Object, e As BackstageViewItemEventArgs) Handles TaiKhoanCaNhan.SelectedChanged
        TaiKhoanCaNhan.ContentControl.Controls.Add(New UserProfiles)

    End Sub
End Class
