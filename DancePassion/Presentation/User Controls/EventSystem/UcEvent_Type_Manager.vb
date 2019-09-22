
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Public Class UcEvent_Type_Manager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
        HasRoles(Me.Name)
    End Sub

#Region " Form"

    Private Sub BtnCreate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcEvent_Type_Add, "Thêm loại sự kiện")
        End If
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEDIT.ItemClick
        Dim Uc As New UcEvent_Type_Update With {
        .Cmodel = GetModel()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa loại sự kiện")
        End If
    End Sub

    Private Sub BtnDELETE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDELETE.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If DeleteModel() Then
            Grv.DeleteRow(Grv.FocusedRowHandle)
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnREFRESH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnREFRESH.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        LoadData()
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub LoadData() Handles Me.Load
        Grd.DataSource = ClsEvent_Type.GetInstance.GetDataTable()
        'Rename columm header
        Grv.Columns(0).Caption = "Mã loại sự kiện"
        Grv.Columns(1).Caption = "Tên loại sự kiện"
        Grv.Columns(2).Caption = "Mô tả loại sự kiện"

    End Sub

    Private Function GetModel() As Event_TypeDTO

        Dim SelectedRow = Grv.GetFocusedDataRow()
        Dim Model As New Event_TypeDTO

        If SelectedRow IsNot Nothing Then
            With Model
                .Event_Type_Id = SelectedRow(0).ToString
                .Event_Type_Name = SelectedRow(1).ToString
                .Event_Type_Desc = SelectedRow(2).ToString
            End With
        End If

        Return Model
    End Function

    Private Function DeleteModel() As Boolean

        Try
            ClsEvent_Type.GetInstance.Delete(GetModel())
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

#End Region
End Class
