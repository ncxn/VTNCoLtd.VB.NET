Public Class UcControlUpdate
    Public CurrentRecord As ControlsDTO
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Action controls"
    Private Sub UcControlUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnOK.Caption = "Lưu"
        LoadData()
        LookupEdit()
        TxtControls_name.Enabled = False
    End Sub

    Private Sub BtnOk_itemClick() Handles BtnOK.ItemClick
        UpdateDB()
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub
#End Region

#Region " Xử lý dữ liệu"

    Private Sub LoadData()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                TxtControls_name.Text = .Controls_name.ToString
                TxtControls_description.Text = .Controls_description.ToString
                TxtControls_parent.EditValue = .Controls_parent.ToString
                TxtControls_type.Text = .Controls_type.ToString
                TxtControls_sort.Text = .Controls_sort.ToString
            End With
        End If
    End Sub

    Private Sub UpdateDB()
        Dim data As New ControlsDTO With {
            .Controls_name = TxtControls_name.Text.ToString,
            .Controls_description = TxtControls_description.Text.ToString,
            .Controls_parent = TxtControls_parent.EditValue.ToString,
            .Controls_type = TxtControls_type.Text.ToString,
            .Controls_sort = CInt(TxtControls_sort.Text)
        }
        If ClsControls.GetInstance.UpdateControls(data) Then
            MessageBox.Show("Thành công")
        End If
    End Sub

    Private Sub LookupEdit()
        TxtControls_parent.Properties.DataSource = UCControlsManager.controlColection
        TxtControls_parent.Properties.ValueMember = "Controls_name"
        TxtControls_parent.Properties.DisplayMember = "Controls_description"
        TxtControls_parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtControls_parent.Properties.PopulateViewColumns()
        TxtControls_parent.Properties.View.Columns("Controls_name").Caption = "Tên Controls"
        TxtControls_parent.Properties.View.Columns("Controls_description").Caption = "Mô tả"
        TxtControls_parent.Properties.View.Columns("Controls_parent").Caption = "Cấp cha"
        TxtControls_parent.Properties.View.Columns("Controls_type").Caption = "Phân loại"
        TxtControls_parent.Properties.View.Columns("Controls_sort").Caption = "Sắp xếp"
    End Sub
#End Region

#Region " Test Sub or Function"
    Private Sub Test()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                Debug.WriteLine(.Controls_name.ToString + " : " + .Controls_description.ToString)
            End With
        End If
    End Sub
#End Region
End Class
