Imports DancePassion

Public Class UcCustomer_Update

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Properties"
    Private _Cmodel As Customer_DTO
    Private _Customer_Group As Customer_GroupCollection

    Public Property Cmodel As Customer_DTO
        Get
            Return _Cmodel
        End Get
        Set(value As Customer_DTO)
            _Cmodel = value
        End Set
    End Property

    Public Property Customer_Group As Customer_GroupCollection
        Get
            Return _Customer_Group
        End Get
        Set(value As Customer_GroupCollection)
            _Customer_Group = value
        End Set
    End Property

#End Region

#Region " Form"

    Sub LoadData() Handles Me.Load
        TxtCustomer_Name.Text = Cmodel.Customer_Name
        TxtCustomer_Addresss.Text = Cmodel.Customer_Address
        TxtCustomer_Phone.Text = Cmodel.Customer_Phone
        TxtCustomer_Email.Text = Cmodel.Customer_Email
        TxtCustomer_Group_Id.EditValue = Cmodel.Customer_Group_Id

        'Add Search lookup
        SearchLookup()
    End Sub

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me)
        If ClsCustomers.GetInstance.Update(GetModel()) Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Function GetModel() As Customer_DTO

        Dim Model As New Customer_DTO

        If ValidateInput() Then
            With Model
                .Customer_Id = Cmodel.Customer_Group_Id
                .Customer_Name = TxtCustomer_Name.Text
                .Customer_Address = TxtCustomer_Addresss.Text
                .Customer_Phone = TxtCustomer_Phone.Text
                .Customer_Email = TxtCustomer_Email.Text
                .Customer_Group_Id = TxtCustomer_Group_Id.EditValue
                .Customer_Expand_Info_Id = vbNull
            End With
        End If

        Return Model
    End Function

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Name.Text)
    End Function

    Sub SearchLookup()
        TxtCustomer_Group_Id.Properties.DataSource = Customer_Group
        TxtCustomer_Group_Id.Properties.ValueMember = "Customer_group_id"
        TxtCustomer_Group_Id.Properties.DisplayMember = "Customer_group_name"
        TxtCustomer_Group_Id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtCustomer_Group_Id.Properties.PopulateViewColumns()
        TxtCustomer_Group_Id.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_id").Width = 50
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        TxtCustomer_Group_Id.Properties.View.Columns("Customer_group_parent").Visible = False
    End Sub

#End Region

End Class
