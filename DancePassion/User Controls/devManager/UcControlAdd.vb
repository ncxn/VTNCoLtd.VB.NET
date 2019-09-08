Public Class UcControlAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

    Private Sub UcControlAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridLookupEdit()
        BtnOK.Caption = "Lưu dữ liệu"
    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
#Region " Xử lý dữ liệu"
    Private Sub UpdateDB()
        Dim CtrlDTO As New ControlsDTO With {
        .Control_name = TxtControls_name.Text.ToString(),
        .Control_description = TxtControls_description.Text.ToString(),
        .Control_parent = TxtControls_parent.Text.ToString(),
        .Control_type = TxtControls_type.Text.ToString(),
        .Control_sort = TxtControls_sort.Text
        }
        ClsControls.GetInstance.InsertControls(CtrlDTO)
    End Sub
    Private Sub GridLookupEdit()
        TxtControls_parent.Properties.DataSource = ClsControls.GetInstance.GetList()
        TxtControls_parent.Properties.ValueMember = "Control_name"
        TxtControls_parent.Properties.DisplayMember = "Control_description"
        TxtControls_parent.Properties.PopulateViewColumns()
        TxtControls_parent.Properties.View.Columns("Control_name").Caption = "Tên Control"
        TxtControls_parent.Properties.View.Columns("Control_description").Caption = "Mô tả"
        TxtControls_parent.Properties.View.Columns("Control_type").Visible = False
        TxtControls_parent.Properties.View.Columns("Control_sort").Visible = False
        TxtControls_parent.Properties.View.Columns("Control_parent").Visible = False
        TxtControls_parent.Properties.ImmediatePopup = True
        TxtControls_parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
    End Sub
#End Region
End Class
