Partial Public Class MailConfigfrm

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub navBarControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl.ActiveGroupChanged
        navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        navBarControl.ActiveGroup = If(e.Item.Caption = "Dịch vụ Email", navMail, navSMS)
    End Sub

End Class
