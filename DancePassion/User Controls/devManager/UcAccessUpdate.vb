Public Class UcAccessUpdate
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Các control trên form"
    Private Sub UcAccessUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtAccess_name.Enabled = False
        '
        LoadData()
    End Sub

    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        FrmMain.RemoveDocumetns()
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub LoadData()
        Dim data = UcAccessManager.AccessDTO
        TxtAccess_name.Text = data.Access_name.ToString()
        TxtAccess_desc.Text = data.Access_desc.ToString
    End Sub
    Private Sub UpdateDB()
        Dim AccessDTO As New AccessDTO With {
            .Access_name = TxtAccess_name.Text.ToString,
            .Access_desc = TxtAccess_desc.Text.ToString}

        If ClsAccess.GetInstance.Update(AccessDTO) Then

        End If
    End Sub
#End Region
End Class
