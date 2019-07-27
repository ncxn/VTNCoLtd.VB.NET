Imports DevExpress.XtraBars

Public Class UCRolesUpdate
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RbpGTools.Visible = False
        RbpGExtend.Visible = False
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
End Class
