Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class Setting

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub accordionControl_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs) Handles accordionControl.SelectedElementChanged
        If e.Element Is Nothing Then
            Return
        End If
        Dim form As New Form()
        Select Case e.Element.Text
            Case "Cấu hình Email"
                form = Mails
            Case "Cấu hình SMS"
                form = SMSconfig
            Case "Thông tin doanh nghiệp"
                form = infoOfOrg
        End Select
        tabbedView.AddDocument(form)
        tabbedView.ActivateDocument(form)
    End Sub

    Private Sub infoBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles infoBarButtonItem.ItemClick
        Dim form As New Form()
        form = infoOfOrg
        Dim document As BaseDocument = Nothing
        If tabbedView.Documents.TryGetValue(form, document) Then
            tabbedView.ActivateDocument(form)
        Else
            tabbedView.AddDocument(form)
        End If
    End Sub
    Private Sub eMailBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles emailBarButtonItem.ItemClick
        Dim form As New Form()
        form = Mails
        tabbedView.AddDocument(form)
        tabbedView.ActivateDocument(form)
    End Sub

    Private Sub SMSBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles smsBarButtonItem.ItemClick
        Dim form As New Form()
        form = SMSconfig
        tabbedView.AddDocument(form)
        tabbedView.ActivateDocument(form)
    End Sub
End Class
