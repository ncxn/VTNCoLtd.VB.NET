Imports DevExpress.XtraSplashScreen

Public Class UCRoles
    Public Shared DataModeRoles As DataMode
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RbpGXacNhan.Visible = False
    End Sub

    Private Sub UCRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAdd.ItemClick
        FrmMain.AddDocs(New UCRolesUpdate, "Thêm nhóm")
        DataModeRoles = 0
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEdit.ItemClick
        FrmMain.AddDocs(New UCRolesUpdate, "Sửa nhóm")
        DataModeRoles = 1
    End Sub
    Private Sub LoadData()
        Dim data = DBHelper.GetInstance.GetDataTable("procGetAllRoles", CommandType.StoredProcedure)
        GridControlRoles.DataSource = data
    End Sub

End Class
