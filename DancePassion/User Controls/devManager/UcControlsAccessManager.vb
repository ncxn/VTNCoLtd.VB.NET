Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSplashScreen

Public Class UcControlsAccessManager

    Private Control As String
    Private ObjControlsAccessList As ControlsAccessCollection
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ObjControlsAccessList = ClsControlsAccess.GetInstance.GetList()
        'HasRoles(Me.Name)
    End Sub
#Region " Form Action"

    Private Sub ControlsAccessManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopularControls()
        PopularAccess()
        SetCheckedItemOnAccessListBox()
    End Sub

    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnREFRESH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnREFRESH.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        PopularControls()
        PopularAccess()
        SetCheckedItemOnAccessListBox()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Grid Control"
    Private Sub GrvControls_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GrvControls.FocusedRowChanged
        SetCheckedItemOnAccessListBox()
    End Sub
#End Region


#Region " Xử lý dữ liệu"
    Private Sub PopularControls()
        Dim soucreControls = ClsControls.GetInstance.GetDataTable()
        GrdControls.DataSource = soucreControls
        GrvControls.Columns(2).Visible = False
        GrvControls.Columns(3).Visible = False
        GrvControls.Columns(4).Visible = False
        GrvControls.OptionsBehavior.ReadOnly = True
    End Sub
    Private Sub PopularAccess()
        ChkAccess.DataSource = ClsAccess.GetInstance.GetList()
        ChkAccess.ValueMember = "Access_name"
        ChkAccess.DisplayMember = "Access_desc"
    End Sub

    Private Sub SetCheckedItemOnAccessListBox()
        Dim ObjAccessByControl = ClsControlsAccess.GetInstance.GetAccessByControls(GrvControls.GetFocusedRowCellValue("Tên Controls").ToString, ObjControlsAccessList)

        ' Duyệt qua từng phần tử trong ListAccess(chức năng) nếu tồn tại trong objAC thì checked, ngược lại thì Unchecked

        For i As Integer = 0 To ChkAccess.ItemCount - 1
            If ObjAccessByControl.Contains(ChkAccess.GetItemValue(i).ToString) Then
                ChkAccess.SetItemChecked(i, True)
            Else
                ChkAccess.SetItemChecked(i, False)
            End If
        Next
    End Sub
    Private Function GetControlsAccessCollection() As ControlsAccessCollection
        Dim ControlsAccessCollection As New ControlsAccessCollection

        For Each item As AccessDTO In ChkAccess.CheckedItems
            Dim ControlsAccessDTO As New ControlsAccessDTO With {
                .Controls_name = GrvControls.GetFocusedRowCellValue("Tên Controls").ToString,
                .Access_name = item.Access_name.ToString()}
            ControlsAccessCollection.Add(ControlsAccessDTO)
        Next
        Return ControlsAccessCollection
    End Function
    Private Function GetControlsAccessDTO() As ControlsAccessDTO
        Dim ControlsAccess As New ControlsAccessDTO With {
            .Controls_name = GrvControls.GetFocusedRowCellValue("Tên Controls").ToString,
            .Access_name = ""}

        Return ControlsAccess
    End Function
    Private Sub UpdateDB()

        ' Xóa hết những chức năng trên control trước khi thêm mới
        ClsControlsAccess.GetInstance.Delete(GetControlsAccessDTO())

        ' Thêm mới vào
        If ClsControlsAccess.GetInstance.BulkInsert(GetControlsAccessCollection()) Then
            Debug.WriteLine("Thành công")
        End If
    End Sub
#End Region
End Class
