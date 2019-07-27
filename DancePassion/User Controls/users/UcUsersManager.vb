Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSplashScreen

Public Class UcUsersManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'RbpGConfirm.Visible = False

    End Sub
    Private Sub UcUsersManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        'RoleUserControl()
        HidePageGroup(Me.Name.ToString, CurrentControlsAccess.ControlsAccessColection)
        Loaddata()
    End Sub
    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UCUsersAdd, "Thêm thành viên")
        End If
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UCUsersUpdate, "Sửa thành viên")
        End If
    End Sub
#Region " Xử lý dữ liệu"
    Private Sub Loaddata()
        Dim data = ClsUsers.GetInstance.GetDataTableUsers()
        GridControlUsers.DataSource = data
    End Sub
#End Region

#Region " Kiểm tra quền hạn trên form"
    Private Sub RoleUserControl()

        For Each pag As RibbonPage In BaseRibbon.Pages

            'If ClsRoleManager.GetInstance.HasRoleOnMenu(pag.Name.ToString) Then
            '    pag.Visible = True
            'Else
            '    pag.Visible = False
            'End If

            For Each pagGroup As RibbonPageGroup In pag.Groups
                'If ClsRoleManager.GetInstance.HasRoleOnMenu(pagGroup.Name.ToString) Then
                '    pagGroup.Visible = True
                'Else
                '    pagGroup.Visible = False
                'End If

                For Each itemLink As BarItemLink In pagGroup.ItemLinks

                    If ClsRoleManager.GetInstance.HasRoleOnUserControl(itemLink.Item.Name.ToString) Then
                        itemLink.Item.Visibility = BarItemVisibility.Always
                    Else
                        itemLink.Item.Visibility = BarItemVisibility.Never
                    End If
                Next
            Next
        Next
    End Sub

#End Region
End Class
