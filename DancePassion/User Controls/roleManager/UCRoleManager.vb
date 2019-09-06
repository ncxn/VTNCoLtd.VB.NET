Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList

Public Class UcRoleManager

#Region " Dữ liệu dùng chung"
    ' Mịa dùng MySQL server remote qua tới US chậm vãi nồi. Nên cho nó load khi load form
    Private ObjControlsAccessList As ControlsAccessCollection
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
        ObjControlsAccessList = CurrentControlsAccess.ControlsAccessColection
        ObjRoleControlsAccessList = ClsRoleManager.GetInstance.GetList()
        ObjAccessList = ClsAccess.GetInstance.GetList()
    End Sub
#End Region

#Region " Form"
    Private Sub RoleManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Dữ liệu cho form search nhóm người dùng
        PopularRole()
        ' Dữ liệu chức năng
        PopularAction()
        ' Ẩn cái ribbon nào không chứa các item
        HasRoles(Me.Name)

    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
#End Region

#Region " Chọn nhóm: Roles = Search lookup edit"
    Private Sub PopularRole()

        SearchRoles.Properties.DataSource = ClsRoles.GetInstance.GetList()
        SearchRoles.Properties.ValueMember = "Role_name"
        SearchRoles.Properties.DisplayMember = "Role_description"
        SearchRoles.Properties.PopulateViewColumns()
        SearchRoles.Properties.View.Columns("Role_name").Caption = "Tên nhóm"
        SearchRoles.Properties.View.Columns("Role_description").Caption = "Mô tả"

        'Mặc định cho nó khỏi bị lỗi NULL cùi bắp
        SearchRoles.EditValue = "Admin"

    End Sub
    Private Sub SearchRoles_EditValueChanged(sender As Object, e As EventArgs) Handles SearchRoles.EditValueChanged
        If SearchRoles.EditValue IsNot Nothing Then
            Role = SearchRoles.EditValue.ToString
        End If
        PopularActions()
    End Sub

#End Region

#Region " Chức năng :TreeList"
    Private Sub PopularAction()
        TrlControls.DataSource = ClsControls.GetInstance.GetList()
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

#Region " Xử lý dữ liệu"
    Private Sub UpdateDB()
        ' Xóa tất cả action by control trước khi thêm mới (ở đây không dùng update mà là xóa toàn bộ rồi thêm mới)
        ClsRoleManager.GetInstance.DeleleByRoleAndControl(Role, Control)
        ClsRoleManager.GetInstance.BulkInsert(GetRolesControlsAccessCollection)
    End Sub

    Private Function GetRolesControlsAccessCollection() As RolesControlsAccessCollection
        Dim RolesControlsAccessCollection As New RolesControlsAccessCollection

        For Each Access As AccessDTO In ChLAccessControl.CheckedItems

            Dim RolesControlsAccessDTO As New RolesControlsAccessDTO With {
                .Role_name = Role,
                .Control_name = Control,
                .Access_name = Access.Access_name
            }
            RolesControlsAccessCollection.Add(RolesControlsAccessDTO)

        Next
        Return RolesControlsAccessCollection
    End Function
#End Region

#Region " Quyền hạn"
    'Private Sub RoleUserControl()

    '    For Each pag As RibbonPage In BaseRibbon.Pages

    '        'If ClsRoleManager.GetInstance.HasRoleOnMenu(pag.Name.ToString) Then
    '        '    pag.Visible = True
    '        'Else
    '        '    pag.Visible = False
    '        'End If

    '        For Each pagGroup As RibbonPageGroup In pag.Groups
    '            'If ClsRoleManager.GetInstance.HasRoleOnMenu(pagGroup.Name.ToString) Then
    '            '    pagGroup.Visible = True
    '            'Else
    '            '    pagGroup.Visible = False
    '            'End If

    '            For Each itemLink As BarItemLink In pagGroup.ItemLinks

    '                If ClsRoleManager.GetInstance.HasRoleOnUserControl(Me.Name.ToString, itemLink.Item.Name.ToString) Then
    '                    itemLink.Item.Visibility = BarItemVisibility.Always
    '                Else
    '                    itemLink.Item.Visibility = BarItemVisibility.Never
    '                End If
    '            Next
    '        Next
    '    Next
    'End Sub
#End Region
End Class