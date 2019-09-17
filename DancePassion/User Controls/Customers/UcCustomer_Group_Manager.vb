Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraSplashScreen

Public Class UcCustomer_Group_Manager

    Private CustomerGroup As Customer_GroupCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
        HasRoles(Me.Name)

    End Sub

#Region " Form"

    Sub Add() Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcCustomer_Group_Add, "Thêm nhóm khách hàng")
        End If
    End Sub

    Sub Edit() Handles BtnEDIT.ItemClick
        Dim Uc As New UcCustomer_Group_Update With {
        .Cmodel = GetModel(),
        .CustomerGroup = CustomerGroup
        }
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa nhóm khách hàng")
        End If
    End Sub

    Sub Delete() Handles BtnDELETE.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsCustomer_Group.GetInstance.Delete(GetModel()) Then
            Grv.DeleteRow(Grv.FocusedRowHandle)
        End If
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
        CustomerGroup = ClsCustomer_Group.GetInstance.GetList()
        Grd.DataSource = CustomerGroup
        Grv.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        Grv.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        Grv.Columns("Customer_group_parent").Caption = "Thuộc nhóm"
        Grv.OptionsBehavior.ReadOnly = True

        'Add lookup edit
        LoadLookupEdit()
    End Sub

    Sub LoadLookupEdit()
        Dim edit As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit With {
           .DataSource = CustomerGroup,
           .ValueMember = "Customer_group_id",
           .DisplayMember = "Customer_group_name"
       }
        edit.PopulateViewColumns()
        edit.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        edit.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        edit.View.Columns("Customer_group_parent").Visible = False

        Grd.RepositoryItems.Add(edit)
        Grv.Columns("Customer_group_parent").ColumnEdit = edit
    End Sub

    Private Function GetModel() As Customer_Group_DTO

        'Dim SelectedRow As DataRow = Grv.GetFocusedRow()

        'Dim Model As New Customer_Group_DTO

        'If SelectedRow IsNot Nothing Then
        '    With Model
        '        .Customer_group_id = SelectedRow(0).ToString
        '        .Customer_group_name = SelectedRow(1).ToString
        '        .Customer_group_parent = SelectedRow(2).ToString
        '    End With
        'End If

        Return Grv.GetFocusedRow()
    End Function

#End Region

End Class
