Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class UcControlsManager
    Public Shared ControlColection As ControlsCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Mở rộng.
        ' 1. Thêm dòng khi Enter hoặc tab tại cột cuối cùng
        Dim TempGridNewRowHelper As ClsGridControlHelper = New ClsGridControlHelper(GrvControls)
        ControlColection = ClsControls.GetInstance.GetList()
        'HasRoles(Me.Name)
    End Sub

#Region " Forms"
    Private Sub ControlsManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnOK.Caption = "Lưu dữ liệu"
        ' Dữ liệu trên lưới
        LoadData()
        ' Thêm một dropdown cho cột cấp cha
        AddLookUpEdit()
    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
    Private Sub BtnCreate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcControlAdd, "Thêm Control")
        End If
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        Dim uc As New UcControlUpdate With {
            .CurrentRecord = GetCurrentControlDTO()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(uc, "Sửa Control")
        End If
    End Sub
    Private Sub BtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnREFRESH.ItemClick
        LoadData()
    End Sub
#End Region

#Region " Thêm dòng"
    'Thêm 1 dòng mới không có dữ liệu; chỉ thêm khi Grid KHÔNG ở chế độ edit, nếu đang edit thì phải hoàn thành (TAB, ENTER)
    Private Sub InsertRow()
        If GrvControls.ActiveEditor Is Nothing Then
            GrvControls.AddNewRow()
            GrvControls.OptionsNavigation.AutoFocusNewRow = True
            GrvControls.FocusedColumn = GrvControls.VisibleColumns(0)
        Else
            GrvControls.UpdateCurrentRow()
        End If
    End Sub

    ' Thủ tục lấy nhiều dòng được thêm vào Gridview: DataRowState.Added
    Private Function GetNewRowsAdded() As ControlsCollection
        Dim listControls As New ControlsCollection
        Dim dr As DataRow

        For i As Integer = 0 To GrvControls.RowCount - 1
            dr = GrvControls.GetDataRow(i)
            If dr.RowState = DataRowState.Added Then
                Dim ctr As New ControlsDTO With {
                   .Controls_name = dr(0).ToString,
                   .Controls_description = dr(1).ToString,
                   .Controls_parent = dr(2).ToString,
                   .Controls_type = dr(3).ToString,
                   .Controls_sort = CInt(dr(4).ToString)
                }
                listControls.Add(ctr)
            End If
        Next
        Return listControls
    End Function

#End Region

#Region " Sửa dòng"
    ' Thủ tục lấy nhiều dòng được sửa trên Gridview; DataRowState.Modified
    Private Function GetNewRowsEdited() As ControlsCollection
        Dim listControls As New ControlsCollection
        Dim dr As DataRow

        For i As Integer = 0 To GrvControls.RowCount - 1
            dr = GrvControls.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                Dim ctr As New ControlsDTO With {
                   .Controls_name = dr(0).ToString,
                   .Controls_description = dr(1).ToString,
                   .Controls_parent = dr(2).ToString,
                   .Controls_type = dr(3).ToString,
                   .Controls_sort = CInt(dr(4).ToString)
                }
                listControls.Add(ctr)
            End If
        Next
        Return listControls
    End Function
    ' Thủ tục cập nhật khi chỉnh sửa 1 dòng:
    Private Sub UpdateControls()
        If ClsControls.GetInstance.UpdateControls(GetCurrentControlDTO) = True Then
            Debug.WriteLine("Thành công")
        Else
            Debug.WriteLine("Thất bại")
        End If
    End Sub

#End Region

#Region " Xóa dòng"

    ' Thủ tục xóa dòng: chỉ áp dụng khi dùng command builder
    Private Function GetRowsDeleted() As ControlsCollection
        Dim listControls As New ControlsCollection
        Dim dr As DataRow

        For i As Integer = 0 To GrvControls.RowCount - 1
            dr = GrvControls.GetDataRow(i)
            If dr.RowState = DataRowState.Deleted Then
                Dim ctr As New ControlsDTO With {
                   .Controls_name = dr(0).ToString,
                   .Controls_description = dr(1).ToString,
                   .Controls_parent = dr(2).ToString,
                   .Controls_type = dr(3).ToString,
                   .Controls_sort = CInt(dr(4).ToString)
                }
                listControls.Add(ctr)
            End If
        Next
        Return listControls
    End Function

    Private Sub DeleteRow()
        ClsControls.GetInstance.DeleteControls(GetCurrentControlDTO)
        GrvControls.DeleteRow(GrvControls.FocusedRowHandle)
    End Sub

#End Region

#Region " Các thủ tục dùng chung"
    Private Sub GrvControls_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles GrvControls.KeyDown
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            DeleteRow()
        End If
        If (e.KeyCode = Keys.Insert And e.Modifiers = Keys.Control) Then
            InsertRow()
        End If
    End Sub

    'Kiểm tra lỗi cho cột sắp xếp
    Private Sub GrvControls_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GrvControls.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)

        If view.FocusedColumn.Name.ToString = "colSắpxếp" Then
            Dim weight As Integer

            If Not Integer.TryParse(TryCast(e.Value, String), weight) Then
                e.Valid = False
                e.ErrorText = "Nhập số tự nhiên"
            ElseIf weight < 0 Then
                e.Valid = False
                e.ErrorText = "Chỉ nhập số tự nhiên >= 0"
            End If
        End If

    End Sub
    Private Sub GrvControls_ValidateRow(ByVal sender As Object, ByVal e As ValidateRowEventArgs) Handles GrvControls.ValidateRow
        Dim View As GridView = CType(sender, GridView)
        Dim ControlsName As GridColumn = View.Columns(0)

        If String.IsNullOrEmpty(View.GetRowCellValue(e.RowHandle, ControlsName).ToString()) Then
            e.Valid = False
            View.SetColumnError(ControlsName, "Không được để trống cột này")
        End If
    End Sub
    Private Sub GrvControls_InvalidRowException(ByVal sender As Object, ByVal e As InvalidRowExceptionEventArgs) Handles GrvControls.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    ' Không cho edit Khóa chính
    Private Sub GrvControls_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GrvControls.ShowingEditor
        If GrvControls.FocusedColumn Is GrvControls.Columns("Tên Controls") Then
            If GrvControls.IsNewItemRow(GrvControls.FocusedRowHandle) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    ' Load dữ liệu lên gridview.
    Private Sub LoadData()
        GrdControls.DataSource = ClsControls.GetInstance.GetDataTable()
        GrdControls.ForceInitialize()
    End Sub

    ' Lấy record hiện tại trên grid
    Private Function GetCurrentControlDTO() As ControlsDTO

        Dim SelectedRow = GrvControls.GetFocusedDataRow()
        Dim dataControls As New ControlsDTO
        If SelectedRow IsNot Nothing Then
            With dataControls
                .Controls_name = SelectedRow(0).ToString
                .Controls_description = SelectedRow(1).ToString
                .Controls_parent = SelectedRow(2).ToString
                .Controls_type = SelectedRow(3).ToString
                .Controls_sort = SelectedRow(4).ToString
            End With
        End If

        Return dataControls

    End Function

    ' Cập nhật cơ sở dữ liệu sau khi thao tác trên gridviwe 
    Private Sub UpdateDB()
        If GetNewRowsAdded() IsNot Nothing Then
            ClsControls.GetInstance.BulkInsertControls(GetNewRowsAdded())
        End If
        If GetNewRowsEdited() IsNot Nothing Then
            ClsControls.GetInstance.BulkUpdateControls(GetNewRowsEdited())
        End If
    End Sub

    ' Add lookup edit cho cột cấp cha
    Private Sub AddLookUpEdit()
        Dim edit As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit With {
            .DataSource = ClsControls.GetInstance.GetList(),
            .ValueMember = "Controls_name",
            .DisplayMember = "Controls_description"
        }
        edit.PopulateViewColumns()
        edit.View.Columns("Controls_name").Caption = "Mã Controls"
        edit.View.Columns("Controls_description").Caption = "Mô tả"
        edit.View.Columns(2).Visible = False
        edit.View.Columns(3).Visible = False
        edit.View.Columns(4).Visible = False

        GrdControls.RepositoryItems.Add(edit)
        GrvControls.Columns("Cấp cha").ColumnEdit = edit

    End Sub

#End Region

End Class
