Public Class UcControlAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UcControlAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridLookupEdit()
        BtnOK.Caption = "Lưu"
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
        .Controls_name = TxtControls_name.Text.ToString(),
        .Controls_description = TxtControls_description.Text.ToString(),
        .Controls_parent = TxtControls_parent.Text.ToString(),
        .Controls_type = TxtControls_type.Text.ToString(),
        .Controls_sort = CInt(TxtControls_sort.Text)
        }
        ClsControls.GetInstance.InsertControls(CtrlDTO)
    End Sub
    Private Sub GridLookupEdit()
        TxtControls_parent.Properties.DataSource = ClsControls.GetInstance.GetList()
        TxtControls_parent.Properties.ValueMember = "Controls_name"
        TxtControls_parent.Properties.DisplayMember = "Controls_description"
        TxtControls_parent.Properties.PopulateViewColumns()
        TxtControls_parent.Properties.View.Columns("Controls_name").Caption = "Tên Controls"
        TxtControls_parent.Properties.View.Columns("Controls_description").Caption = "Mô tả"
        TxtControls_parent.Properties.View.Columns("Controls_type").Visible = False
        TxtControls_parent.Properties.View.Columns("Controls_sort").Visible = False
        TxtControls_parent.Properties.View.Columns("Controls_parent").Visible = False
        TxtControls_parent.Properties.ImmediatePopup = True
        TxtControls_parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
    End Sub
#End Region
End Class
