Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSplashScreen

Public Class UcEvents_Manager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
        HasRoles(Me.Name)

    End Sub

#Region " Forms"

    Sub AddNew() Handles BtnCREATE.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If AddDocs IsNot Nothing Then
            AddDocs(New UcEvents_Add, "Thêm sự kiện")
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Edit() Handles BtnEDIT.ItemClick
        Dim Uc As New UcEvents_Update With {
        .CModel = GetModel()
        }
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa sự kiện")
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Delete() Handles BtnDELETE.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        DeleteModel()
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub ReLoad() Handles BtnREFRESH.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        LoadData()
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub LoadData() Handles Me.Load
        Grd.DataSource = ClsEvents.GetInstance.GetDataTable()
        Grd.ForceInitialize()
        'Rename columm header
        Grv.Columns("Event_Id").Caption = "Mã sự kiện"
        Grv.Columns("Event_Type_Id").Caption = "Tên loại sự kiện"
        Grv.Columns("Event_Name").Caption = "Tên sự kiện"
        Grv.Columns("Event_Start_Date").Caption = "Ngày bắt đầu"
        Grv.Columns("Event_End_Date").Caption = "Ngày kết thúc"
        Grv.Columns("Event_Participant_Max").Caption = "Số lượng khách dự kiến"

        AddLookUpEdit()
    End Sub

    ' Add lookup edit cho cột Loại sự kiện
    Private Sub AddLookUpEdit()
        Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit With {
            .DataSource = ClsEvent_Type.GetInstance.GetList(),
            .ValueMember = "Event_Type_Id",
            .DisplayMember = "Event_Type_Name"
        }
        edit.PopulateViewColumns()
        edit.View.Columns("Event_Type_Id").Caption = "Mã loại sự kiện"
        edit.View.Columns("Event_Type_Name").Caption = "Tên loại sự kiện"
        edit.View.Columns(2).Visible = False

        Grd.RepositoryItems.Add(edit)
        Grv.Columns(1).ColumnEdit = edit

    End Sub

    Private Function GetModel() As EventsDTO

        Dim SelectedRow = Grv.GetFocusedDataRow()
        Dim Model As New EventsDTO

        If SelectedRow IsNot Nothing Then
            With Model
                .Event_Id = SelectedRow(0).ToString
                .Event_Type_Id = SelectedRow(1).ToString
                .Event_Name = SelectedRow(2).ToString
                .Event_Start_Date = SelectedRow(3).ToString
                .Event_End_Date = SelectedRow(4).ToString
                .Event_Participant_Max = SelectedRow(5).ToString
            End With
        End If

        Return Model

    End Function

    Private Sub DeleteModel()

        Dim model = GetModel()

        If String.IsNullOrEmpty(model.Event_Name) Then
            If ClsEvents.GetInstance.Delete(model) Then
                Grv.DeleteRow(Grv.FocusedRowHandle)
            End If
        End If

    End Sub

    ''' <summary>
    ''' Format number of column 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Grv_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles Grv.CustomColumnDisplayText
        If e.Column.FieldName = "Event_Participant_Max" Then e.DisplayText = String.Format("{0:n}", e.Value)
    End Sub

#End Region

End Class
