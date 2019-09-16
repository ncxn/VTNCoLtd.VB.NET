Imports DancePassion
Imports DevExpress.XtraSplashScreen

Public Class UcCustomer_Group_Add

    Private _Customer_group_collection As Customer_GroupCollection

    Public Property Customer_group_collection As Customer_GroupCollection
        Get
            Return If(_Customer_group_collection, ClsCustomer_Group.GetInstance.GetList())
        End Get
        Set(value As Customer_GroupCollection)
            _Customer_group_collection = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Form"

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        InsertModel()
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
        With Model
            .Customer_group_id = 0
            .Customer_group_name = TxtCustomer_Group_Name.Text
            .Customer_group_parent = GetParent()
        End With
        Return Model
    End Function

    Private Function GetParent() As Integer
        If String.IsNullOrEmpty(TxtCustomer_Group_Parent.Text) Then
            Return 0
        Else
            Return CInt(TxtCustomer_Group_Parent.Text)
        End If
    End Function

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Group_Name.Text)
    End Function

    Private Sub InsertModel()
        If ValidateInput() Then
            Try
                ClsCustomer_Group.GetInstance.Insert(GetModel())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub LoadSearchLookup() Handles Me.Load
        TxtCustomer_Group_Parent.Properties.DataSource = ClsCustomer_Group.GetInstance.GetList()
        TxtCustomer_Group_Parent.Properties.ValueMember = "Customer_group_id"
        TxtCustomer_Group_Parent.Properties.DisplayMember = "Customer_group_name"
        TxtCustomer_Group_Parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        TxtCustomer_Group_Parent.Properties.PopulateViewColumns()
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_parent").Visible = False
    End Sub

#End Region

End Class
