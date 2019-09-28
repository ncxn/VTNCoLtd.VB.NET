Imports DevExpress.XtraSplashScreen
Imports VTNcoLtd.Model
Imports VTNcoLtd.BUS

Public Class UcCustomer_Add
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Properties"

    Private _Customer_Group As New CustomerGroupCollection

    Public Property Customer_Group As CustomerGroupCollection
        Get
            Return _Customer_Group
        End Get
        Set(value As CustomerGroupCollection)
            _Customer_Group = value
        End Set
    End Property

#End Region

#Region " Form"

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If InsertModel() Then
            Cancel()
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub OKAndNew() Handles BtnOKANDNEW.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If InsertModel() Then
            ResetForm()
            GetSourceCustomer()
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub TxtCustomer_Group_Id_GotFocus(sender As Object, e As EventArgs) Handles TxtCustomer_Group_Id.GotFocus
        If Customer_Group.Count > 0 Then
            LoadSearchLookup()
        Else
            Dim handle = SplashScreenManager.ShowOverlayForm(Me)
            GetSourceCustomer()
            SplashScreenManager.CloseOverlayForm(handle)
            LoadSearchLookup()
        End If

    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Function GetModel() As Customer
        Dim Model As New Customer
        With Model
            .Customer_Id = 0
            .Customer_Name = TxtCustomer_Name.Text
            .Customer_Address = TxtCustomer_Address.Text
            .Customer_Phone = TxtCustomer_Phone.Text
            .Customer_Email = TxtCustomer_Email.Text
            .Customer_Group_Id = GetGroupId()
            .Customer_Expand_Info_Id = vbNull
        End With
        Return Model
    End Function

    Private Function GetGroupId() As Integer
        If String.IsNullOrEmpty(TxtCustomer_Group_Id.Text) Then
            Return Nothing
        Else
            Return CInt(TxtCustomer_Group_Id.EditValue)
        End If
    End Function

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Name.Text)
    End Function

    Sub ResetForm()
        TxtCustomer_Name.Text = String.Empty
        TxtCustomer_Group_Id.EditValue = Nothing
    End Sub

    Private Function InsertModel() As Boolean
        If ValidateInput() Then
            Try
                ClsCustomers.GetInstance.Insert(GetModel())
                Return True
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Sub LoadSearchLookup()
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

    Sub GetSourceCustomer()
        _Customer_Group = ClsCustomerGroup.GetInstance.GetList()
    End Sub
#End Region

End Class
