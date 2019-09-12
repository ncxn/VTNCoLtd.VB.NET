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
        If AddDocs IsNot Nothing Then
            AddDocs(New UcEvents_Add, "Thêm sự kiện")
        End If
    End Sub

    Sub Edit() Handles BtnEDIT.ItemClick
        Dim Uc As New UcEvents_Update With {
        .CModel = GetModel()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa sự kiện")
        End If
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

#Region "Xử lý dữ liệu"

    Private Sub LoadData() Handles Me.Load
        Grd.DataSource = ClsEvents.GetInstance.GetDataTable()
        'Rename columm header
        Grv.Columns(0).Caption = "Mã sự kiện"
        Grv.Columns(1).Caption = "Tên loại sự kiện"
        Grv.Columns(2).Caption = "Tên sự kiện"
        Grv.Columns(3).Caption = "Ngày bắt đầu"
        Grv.Columns(4).Caption = "Ngày kết thúc"
        Grv.Columns(5).Caption = "Số lượng khách dự kiến"

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

#End Region

End Class
