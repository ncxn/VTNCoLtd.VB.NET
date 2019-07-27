Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class UcAccessManager

    Public Shared AccessDTO As AccessDTO
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Các chức năng trên form"
    Private Sub UcAccessManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Private Sub BtnCreate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcAccessAdd, "Thêm chức năng")
        End If
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        AccessDTO = GetCurrentAccessDTO()
        If AddDocs IsNot Nothing Then
            AddDocs(New UcAccessUpdate, "Sửa chức năng")
        End If
    End Sub
    Private Sub BtnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDELETE.ItemClick
        AccessDTO = GetCurrentAccessDTO()
        ClsAccess.GetInstance.Delete(AccessDTO)
        GrvAccess.DeleteRow(GrvAccess.FocusedRowHandle)
    End Sub
    Private Sub BtnREFRESH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnREFRESH.ItemClick
        LoadData()
    End Sub
#End Region

#Region " Gridview"
    ' Không cho sửa khóa chính
    Private Sub GrvAccess_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GrvAccess.ShowingEditor
        If GrvAccess.FocusedColumn Is GrvAccess.Columns("Tên Access") Then e.Cancel = Not GrvAccess.IsNewItemRow(GrvAccess.FocusedRowHandle)
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub LoadData()
        GrdAccess.DataSource = ClsAccess.GetInstance.GetDataTable()
    End Sub

    Private Function GetCurrentAccessDTO() As AccessDTO

        Dim SelectedRow = GrvAccess.GetFocusedDataRow()
        Dim dataAccess As New AccessDTO

        If SelectedRow IsNot Nothing Then
            With dataAccess
                .Access_name = SelectedRow(0).ToString
                .Access_desc = SelectedRow(1).ToString
            End With
        End If

        Return dataAccess

    End Function
#End Region
End Class
