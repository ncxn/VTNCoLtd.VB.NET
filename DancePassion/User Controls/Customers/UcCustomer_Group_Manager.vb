Public Class UcCustomer_Group_Manager
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
        .Cmodel = GetModel()
        }
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa nhóm khách hàng")
        End If
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick

    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub LoadData() Handles Me.Load
        Grd.DataSource = ClsCustomer_Group.GetInstance.GetDataTable()
        Grv.Columns(0).Caption = "Mã nhóm khách hàng"
        Grv.Columns(1).Caption = "Tên nhóm khách hàng"
        Grv.Columns(2).Caption = "Thuộc nhóm"
        Grv.OptionsBehavior.ReadOnly = True
    End Sub

    Private Function GetModel() As Customer_Group_DTO

        Dim SelectedRow = Grv.GetFocusedDataRow()
        Dim Model As New Customer_Group_DTO

        If SelectedRow IsNot Nothing Then
            With Model
                .Customer_group_id = SelectedRow(0).ToString
                .Customer_group_name = SelectedRow(1).ToString
                .Customer_group_parent = SelectedRow(2).ToString
            End With
        End If

        Return Model
    End Function

#End Region

End Class
