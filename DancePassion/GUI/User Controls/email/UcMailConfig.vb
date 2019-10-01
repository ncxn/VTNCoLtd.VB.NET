Imports DevExpress.XtraEditors
Imports VTNcoLtd.BUS

Public Class UcMailConfig
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region " Form"

    Private Sub UcEmailManager_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub LoadData()

    End Sub

    Private Sub CbMail_service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMail_service.SelectedIndexChanged
        Dim editor As ImageComboBoxEdit = CType(sender, ImageComboBoxEdit)
        Me.Text = "SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
     " / value " + editor.EditValue.ToString() + " / display text " + editor.Text
    End Sub

    Private Sub CbMail_service_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbMail_service.SelectedValueChanged
        Dim editor As ImageComboBoxEdit = CType(sender, ImageComboBoxEdit)
        Debug.WriteLine("SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
     " / value " + editor.EditValue.ToString() + " / display text " + editor.Text)
    End Sub

#End Region
End Class
