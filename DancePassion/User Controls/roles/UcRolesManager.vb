Imports DevExpress.XtraSplashScreen

Public Class UcRolesManager

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub UcRolesManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        HidePageGroup(Me.Name.ToString, CurrentControlsAccess.ControlsAccessColection)
        LoadData()
    End Sub

    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UCRolesUpdate, "Thêm nhóm")
        End If
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UCRolesUpdate, "Sửa nhóm")
        End If
    End Sub
    Private Sub LoadData()
        GridControlRoles.DataSource = ClsRoles.GetInstance.GetDataTable()
    End Sub

End Class
