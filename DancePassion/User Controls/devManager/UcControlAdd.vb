Public Class UcControlAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UcControlAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnOK.Caption = "Lưu"
    End Sub
    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
    End Sub
    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        FrmMain.RemoveDocumetns()
    End Sub
#Region " Thủ tục"
    Private Sub UpdateDB()
        Dim CtrlDTO As New ControlsDTO With {
        .Controls_name = TxtControls_name.Text.ToString(),
        .Controls_description = TxtControls_description.Text.ToString(),
        .Controls_parent = TxtControls_parent.Text.ToString(),
        .Controls_type = TxtControls_type.Text.ToString(),
        .Controls_sort = CInt(TxtControls_sort.ToString)
        }
        ClsControls.GetInstance.InsertControls(CtrlDTO)
    End Sub
#End Region
End Class
