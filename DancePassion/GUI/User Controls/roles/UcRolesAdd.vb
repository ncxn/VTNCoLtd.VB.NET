Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class UcRolesAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub


#Region " Form"

    Private Sub BtnOKANDNEW_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOKANDNEW.ItemClick
        UpdateDB()
        ResetForm()
    End Sub

    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub ResetForm()
        TxtRole_name.Text = String.Empty
        TxtRole_description.Text = String.Empty
    End Sub

    Private Sub UpdateDB()

        Dim role As New Roles With {
            .Role_name = TxtRole_name.Text,
            .Role_description = TxtRole_description.Text}

        If ClsRoles.GetInstance.Insert(role) Then
            MessageBox.Show("Thành công")
        End If
    End Sub
#End Region

End Class
