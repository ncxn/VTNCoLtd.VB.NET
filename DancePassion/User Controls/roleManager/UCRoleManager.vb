Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTreeList

Public Class UCRoleManager

#Region " Dữ liệu dùng chung"
    ' Mịa dùng MySQL server remote qua tới US chậm vãi nồi. Nên cho nó load khi load form
    Private ObjControlsAccessList As New ControlsAccessCollection
    Private ObjAccessList As New AccessCollection
    Private ObjRoleControlsAccessList As New RolesControlsAccessCollection
    ' Tên nhóm được tạo ra khi người dùng chọn nhóm, éo hiểu sao chơi trực tiếp thì nó không work, vứt lên đây thì ngon lành
    Private Role As String
    ' Tên control khi người dùng click vào các chức năng trên treelist
    Private Control As String
#End Region

#Region " Cấu trúc form"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Danh sách controls và các action tương ứng trên controls
        ObjControlsAccessList = ClsControlsAccess.GetInstance.GetList()
        ObjRoleControlsAccessList = ClsRoleManager.GetInstance.GetList()
        ObjAccessList = ClsAccess.GetInstance.GetList()
    End Sub
#End Region

#Region " Khởi động form: Load form"
    Private Sub RoleManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Dữ liệu cho form search nhóm người dùng
        PopularRole()
        ' Dữ liệu chức năng
        PopularTreelist()
        ' Ẩn cái ribbon nào không chứa các item con
        HideEmptyGroups()
    End Sub
#End Region

#Region " Trình đơn : Ribbon Menu"

    Private Function IsVisible(ByVal itemLink As BarItemLink) As Boolean
        Return (itemLink.Item.Visibility = BarItemVisibility.Always OrElse itemLink.Item.Visibility = BarItemVisibility.OnlyInRuntime) AndAlso itemLink.Visible
    End Function

    Private Sub HideEmptyGroups()

        Dim listAccess As List(Of String) = ClsControlsAccess.GetInstance.GetAccessByControls(Name.ToString, ObjControlsAccessList)

        For Each pag As RibbonPage In BaseRibbon.Pages

            For Each pagGroup As RibbonPageGroup In pag.Groups
                Dim VisibleAll As Boolean = False

                For Each itemLink As BarItemLink In pagGroup.ItemLinks
                    'Set control
                    If listAccess.Contains(itemLink.Item.Name.ToString) Then
                        itemLink.Item.Visibility = BarItemVisibility.Always
                    Else
                        itemLink.Item.Visibility = BarItemVisibility.Never
                    End If
                    'Check control
                    If IsVisible(itemLink) Then
                        VisibleAll = True
                        Continue For
                    End If
                Next

                If Not VisibleAll Then pagGroup.Visible = VisibleAll
            Next
        Next
    End Sub
#End Region

#Region "Chọn nhóm: Roles = Search lookup edit"
    Private Sub PopularRole()

        SearchRoles.Properties.DataSource = Roles.GetInstance.GetList()
        SearchRoles.Properties.ValueMember = "Role_name"
        SearchRoles.Properties.DisplayMember = "Role_description"
        SearchRoles.Properties.PopulateViewColumns()
        SearchRoles.Properties.View.Columns("Role_name").Caption = "Tên nhóm"
        SearchRoles.Properties.View.Columns("Role_description").Caption = "Mô tả"

        'Mặc định cho nó khỏi bị lỗi NULL cùi bắp
        SearchRoles.EditValue = "Admin"

    End Sub
    Private Sub SearchRoles_EditValueChanged(sender As Object, e As EventArgs) Handles SearchRoles.EditValueChanged
        Role = SearchRoles.EditValue.ToString
        PopularActions()
    End Sub

#End Region

#Region " Chức năng :TreeList"
    Private Sub PopularTreelist()
        TrlControls.DataSource = clsControls.GetInstance.GetList()
        TrlControls.KeyFieldName = "Controls_name"
        TrlControls.ParentFieldName = "Controls_parent"
        TrlControls.SetFocusedNode(TrlControls.GetNodeByVisibleIndex(0))
        TrlControls.TreeLineStyle = LineStyle.Dark
        TrlControls.OptionsBehavior.Editable = False
        TrlControls.CollapseAll()
        TrlControls.Columns("Controls_type").Visible = False
        TrlControls.Columns("Controls_sort").Visible = False
        TrlControls.Columns("Controls_description").Caption = "Chọn chức năng"
    End Sub

    Private Sub TrlControls_FocusedNodeChanged(sender As Object, e As FocusedNodeChangedEventArgs) Handles TrlControls.FocusedNodeChanged
        Control = TrlControls.FocusedNode.GetValue(TrlControls.KeyFieldName).ToString()
        PopularActions()
    End Sub

#End Region

#Region " Các công cụ trên form : Actions"
    Private Sub PopularActions()

        Dim ObjAccessByRoleAndControl = ClsRoleManager.GetInstance.GetAccessByRoleAndControls(Role, Control, ObjRoleControlsAccessList)
        Dim ObjAccessByControl = ClsControlsAccess.GetInstance.GetAccessByControlsWithDesc(Control, ObjControlsAccessList, ObjAccessList)

        ChLAccessControl.DataSource = ObjAccessByControl
        ChLAccessControl.ValueMember = "Access_name"
        ChLAccessControl.DisplayMember = "Access_desc"

        ' So sánh với các quyền hạn sẵn có trong database (ObjAccessByRoleAndControl); nếu có thì check vào Listbox
        ' Sử dụng kỹ thuật lambda expression: éo hiểu nhưng nó work, kaka (',')
        For i As Integer = 0 To ChLAccessControl.ItemCount - 1
            Dim k As Integer = i
            If ObjAccessByRoleAndControl.Exists(Function(Fx) Fx.Access_name = ChLAccessControl.GetItemValue(k).ToString) Then
                ChLAccessControl.SetItemChecked(k, True)
            End If
        Next

    End Sub

    Private Sub ChLAccessControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChLAccessControl.SelectedIndexChanged
        ' MessageBox.Show(ChLAccessControl.Items.ToString)
    End Sub


#End Region

End Class