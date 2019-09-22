Public Class UcControlUpdate

    Public CurrentRecord As ControlsDTO

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Form"
    Private Sub UcControlUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        LookupEdit()
        TxtControls_name.Enabled = False
    End Sub

    Private Sub BtnOk_itemClick() Handles BtnOK.ItemClick
        If UpdateDB() Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub LoadData()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                TxtControls_name.Text = .Control_name.ToString
                TxtControls_description.Text = .Control_description.ToString
                TxtControls_parent.EditValue = .Control_parent.ToString
                TxtControls_type.Text = .Control_type.ToString
                TxtControls_sort.Text = .Control_sort.ToString
            End With
        End If
    End Sub

    Private Function UpdateDB() As Boolean
        Dim data As New ControlsDTO With {
            .Control_name = TxtControls_name.Text.ToString,
            .Control_description = TxtControls_description.Text.ToString,
            .Control_parent = TxtControls_parent.EditValue,
            .Control_type = TxtControls_type.Text.ToString,
            .Control_sort = CInt(TxtControls_sort.Text)
        }

        Return ClsControls.GetInstance.UpdateControls(data)
    End Function

    Private Sub LookupEdit()
        TxtControls_parent.Properties.DataSource = UCControlsManager.ControlColection
        TxtControls_parent.Properties.ValueMember = "Control_name"
        TxtControls_parent.Properties.DisplayMember = "Control_description"
        TxtControls_parent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        TxtControls_parent.Properties.PopulateViewColumns()
        TxtControls_parent.Properties.View.Columns("Control_name").Caption = "Tên Control"
        TxtControls_parent.Properties.View.Columns("Control_description").Caption = "Mô tả"
        TxtControls_parent.Properties.View.Columns("Control_parent").Caption = "Cấp cha"
        TxtControls_parent.Properties.View.Columns("Control_type").Caption = "Phân loại"
        TxtControls_parent.Properties.View.Columns("Control_sort").Caption = "Sắp xếp"
    End Sub

#End Region

#Region " Test Sub or Function"
    Private Sub Test()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                Debug.WriteLine(.Control_name.ToString + " : " + .Control_description.ToString)
            End With
        End If
    End Sub
#End Region

End Class
