Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen
Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class UcCustomer_Group_Add

    Private _customer_group As New CustomerGroupCollection

    Public Property CustomerGroup As CustomerGroupCollection
        Get
            Return _customer_group
        End Get
        Set(value As CustomerGroupCollection)
            _customer_group = value
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

    Private Sub TxtCustomer_Group_Parent_GotFocus(sender As Object, e As EventArgs) Handles TxtCustomer_Group_Parent.GotFocus
        If CustomerGroup.Count > 0 Then
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

    Private Function GetModel() As CustomerGroup
        Dim Model As New CustomerGroup
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
            Return CInt(TxtCustomer_Group_Parent.EditValue)
        End If
    End Function

    Private Function ValidateInput() As Boolean
        Return Not String.IsNullOrEmpty(TxtCustomer_Group_Name.Text)
    End Function

    Sub ResetForm()
        TxtCustomer_Group_Name.Text = String.Empty
        TxtCustomer_Group_Name.Text = 0
    End Sub

    Private Function InsertModel() As Boolean
        If ValidateInput() Then
            Try
                ClsCustomerGroup.GetInstance.Insert(GetModel())
                Return True
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Sub LoadSearchLookup()
        TxtCustomer_Group_Parent.Properties.DataSource = CustomerGroup
        TxtCustomer_Group_Parent.Properties.ValueMember = "Customer_group_id"
        TxtCustomer_Group_Parent.Properties.DisplayMember = "Customer_group_name"
        TxtCustomer_Group_Parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtCustomer_Group_Parent.Properties.PopulateViewColumns()
        TxtCustomer_Group_Parent.Properties.BestFitMode = BestFitMode.BestFit
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_id").Width = 50
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_id").Caption = "Mã nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_name").Caption = "Tên nhóm khách hàng"
        TxtCustomer_Group_Parent.Properties.View.Columns("Customer_group_parent").Visible = False
    End Sub

    Sub GetSourceCustomer()
        _customer_group = ClsCustomerGroup.GetInstance.GetList()
    End Sub
#End Region

End Class
