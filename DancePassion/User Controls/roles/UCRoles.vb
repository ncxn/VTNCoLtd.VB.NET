Public Class UCRoles
    Private Sub BarBtn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtn_Add.ItemClick
        TabbedView1.AddDocument(New UCRolesUpdate)
    End Sub
End Class
