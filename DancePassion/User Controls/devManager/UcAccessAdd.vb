Public Class UcAccessAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Form action"
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        FrmMain.RemoveDocumetns()
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub UpdateDB()
        Dim data As New AccessDTO With {
            .Access_name = TxtAccess_name.Text.ToString,
            .Access_desc = TxtAccess_desc.Text.ToString
        }
        If ClsAccess.GetInstance.insert(data) Then

        End If
    End Sub
#End Region
End Class
