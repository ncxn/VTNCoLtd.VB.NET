Imports DevExpress.XtraSplashScreen

Public Class UCUsers
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RbpGXacNhan.Visible = False
    End Sub
    Private Sub UCUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loaddata()
    End Sub
    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAdd.ItemClick
        'SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        FrmMain.AddDocs(New UCUsersAdd, "Thêm thành viên")
        'SplashScreenManager.CloseForm()
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEdit.ItemClick
        'SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        FrmMain.AddDocs(New UCUsersUpdate, "Sửa thành viên")
        ' SplashScreenManager.CloseForm()
    End Sub
#Region "data"
    Private Sub Loaddata()
        Dim data = Users.GetInstance.GetDataTableUsers()
        GridControlUsers.DataSource = data
    End Sub
#End Region

End Class
