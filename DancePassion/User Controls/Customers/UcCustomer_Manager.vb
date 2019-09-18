﻿Imports DancePassion
Imports DevExpress.XtraSplashScreen

Public Class UcCustomer_Manager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
        HasRoles(Me.Name)
    End Sub

#Region " Properties"

    Private _Customer As New CustomerCollection

    Public Property Customer As CustomerCollection
        Get
            Return _Customer
        End Get
        Set(value As CustomerCollection)
            _Customer = value
        End Set
    End Property

#End Region

#Region " Form"

    Sub LoadData() Handles Me.Load
        GridLoad()
    End Sub

    Sub Add() Handles BtnCREATE.ItemClick
        If AddDocs IsNot Nothing Then
            AddDocs(New UcCustomer_Add, "Thêm khách hàng")
        End If
    End Sub

    Sub Edit() Handles BtnEDIT.ItemClick
        Dim Uc As New UcCustomer_Update With {
        .Cmodel = GetModel(),
        .Customer = Customer
        }
        If AddDocs IsNot Nothing Then
            AddDocs(Uc, "Sửa khách hàng")
        End If
    End Sub

    Sub Delete() Handles BtnDELETE.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsCustomers.GetInstance.Delete(GetModel()) Then
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

    Sub GridLoad()
        If Customer.Count = 0 Then
            _Customer = ClsCustomers.GetInstance.GetList()
        End If
        Grd.DataSource = Customer
        Grv.Columns("Customer_Id").Caption = "Mã khách hàng"
        Grv.Columns("Customer_Name").Caption = "Tên khách hàng"
        Grv.Columns("Customer_Address").Caption = "Địa chỉ"
        Grv.Columns("Customer_Phone").Caption = "Điện thoại"
        Grv.Columns("Customer_Email").Caption = "Thư điện tử"
        Grv.Columns("Customer_Group_Id").Caption = "Thuộc nhóm"
        Grv.Columns("Customer_Expand_Info_Id").Caption = "Thông tin mở rộng"
        Grv.OptionsBehavior.ReadOnly = True

        'Add lookup edit
        LoadLookupEdit()
    End Sub

    Sub LoadLookupEdit()
        Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit With {
           .DataSource = ClsCustomer_Group.GetInstance.GetList(),
           .ValueMember = "Customer_group_id",
           .DisplayMember = "Customer_group_name"
       }
        edit.PopulateViewColumns()
        edit.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        edit.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        edit.View.Columns("Customer_group_parent").Visible = False

        Grd.RepositoryItems.Add(edit)
        Grv.Columns("Customer_Group_Id").ColumnEdit = edit
    End Sub

    Function GetModel() As Customer_DTO
        Return Grv.GetFocusedRow()
    End Function

#End Region

End Class
