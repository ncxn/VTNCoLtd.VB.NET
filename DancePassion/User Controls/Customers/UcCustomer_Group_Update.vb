Imports DancePassion
Imports DevExpress.XtraSplashScreen

Public Class UcCustomer_Group_Update

    Private _Cmodel As Customer_Group_DTO
    Private _CustomerGroup As Customer_GroupCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

    Public Property Cmodel As Customer_Group_DTO
        Get
            Return _Cmodel
        End Get
        Set(value As Customer_Group_DTO)
            _Cmodel = value
        End Set
    End Property

    Public Property CustomerGroup As Customer_GroupCollection
        Get
            Return _CustomerGroup
        End Get
        Set(value As Customer_GroupCollection)
            _CustomerGroup = value
        End Set
    End Property

#Region " Form"

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsCustomer_Group.GetInstance.Update(GetModel()) Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Function GetModel() As Customer_Group_DTO

        Dim Model As New Customer_Group_DTO

        If ValidateInput() Then
            With Model
                .Customer_group_id = Cmodel.Customer_group_id
                .Customer_group_name = TxtCustomer_Group_Name.Text
                .Customer_group_parent = TxtCustomer_Group_Parent.EditValue
            End With
        End If

        Return Model
    End Function

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Group_Name.Text)
    End Function

    Sub SearchLookup()
        TxtCustomer_Group_Parent.Properties.DataSource = CustomerGroup
        TxtCustomer_Group_Parent.Properties.ValueMember = "Customer_group_id"
        TxtCustomer_Group_Parent.Properties.DisplayMember = "Customer_group_name"
        TxtCustomer_Group_Parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtCustomer_Group_Parent.Properties.PopulateViewColumns()
        TxtCustomer_Group_Parent.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_id").Width = 50
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_parent").Visible = False
    End Sub

    Sub LoadData() Handles Me.Load
        TxtCustomer_Group_Name.Text = Cmodel.Customer_group_name
        TxtCustomer_Group_Parent.EditValue = Cmodel.Customer_group_parent
        'Add Search lookup
        SearchLookup()
    End Sub

#End Region

End Class
