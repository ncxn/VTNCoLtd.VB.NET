Imports DevExpress.XtraBars
Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class UCRolesUpdate

    Private _role As Roles

    Public Property Role As Roles
        Get
            Return _role
        End Get
        Set
            _role = Value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

    Private Sub UCRolesUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub BtnOK_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub

#Region " Xử lý dữ liệu"

    Private Sub LoadData()
        txtRole_name.Text = Role.Role_name
        txtRole_name.Enabled = False
        TxtRole_decs.Text = Role.Role_description
    End Sub

    Private Sub UpdateDB()
        _role = New Roles With {
            .Role_name = txtRole_name.Text,
            .Role_description = TxtRole_decs.Text}

        If ClsRoles.GetInstance.Update(Role) Then
            MessageBox.Show("Thành công")
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
    End Sub

#End Region

End Class
