Imports System.Threading
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Ribbon
Imports MySql.Data.MySqlClient

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")
        Me.MainControlRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always
        Test()
    End Sub

    Private Sub DangNhap_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles DangNhap.ItemClick
        FrmUsersLogIn.ShowDialog()
    End Sub

    Private Sub TaiKhoanCaNhan_SelectedChanged(sender As Object, e As BackstageViewItemEventArgs) Handles TaiKhoanCaNhan.SelectedChanged
        Dim ucUser As New UserProfiles With {
            .Parent = BackstageViewClientControl1,
            .Dock = DockStyle.Fill
        }
        TaiKhoanCaNhan.ContentControl.Controls.Add(New UserProfiles)

    End Sub
    Private Sub NhomNhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NhomNhanVien_NhanVien_btn.ItemClick

        Dim uc As New UCRoles With {
            .Text = "Nhóm người dùng"}

        For Each docs As BaseDocument In Me.TabbedViewOnMain.Documents
            If docs.Caption = "Nhóm người dùng" Then
                TabbedViewOnMain.Controller.Activate(docs)
                Return
            End If
        Next

        TabbedViewOnMain.AddDocument(uc)

    End Sub
    Private Sub NhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NhanVien_NhanVien_btn.ItemClick

        Dim uc As New UcUsers With {
            .Text = "Nhân viên"}

        For Each docs As BaseDocument In Me.TabbedViewOnMain.Documents
            If docs.Caption = "Nhân viên" Then
                TabbedViewOnMain.Controller.Activate(docs)
                Return
            End If
        Next

        TabbedViewOnMain.AddDocument(uc)
    End Sub
    Private Sub TabbedView1_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles TabbedViewOnMain.DocumentActivated
        MergeMainRibbon(TryCast(e.Document.Control, UCBase))
    End Sub
    Private Sub MergeMainRibbon(ByVal child As UCBase)
        Ribbon.MergeRibbon(child.Ribbon)
    End Sub

    Private Sub MainControlRibbon_Merge(sender As Object, e As RibbonMergeEventArgs) Handles MainControlRibbon.Merge
        e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages("Chức năng")
    End Sub

    Private Sub Test()


    End Sub
End Class
