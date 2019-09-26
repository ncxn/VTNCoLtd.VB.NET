Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class UcConfig_Basic
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Forms"

    Private Sub UcConfig_Basic_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetCurentConfig()
    End Sub

    Private Sub BtnOK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOK.ItemClick
        UpdateDB()
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub GetCurentConfig()
        Dim model = ClsConfigBasic.GetInstance.GetCurrentConfig_Basic(1)

        TxtoName.Text = model.Config_basic_oName
        TxtoSologan.Text = model.Config_basic_oSlogan
        TxtoAddress.Text = model.Config_basic_oAddress
        TxtoEmail.Text = model.Config_basic_oEmail
        TxtoTaxCode.Text = model.Config_basic_oTaxCode
    End Sub

    Private Sub UpdateDB()
        If CurrentConfigBasic.ConfigBasic.Config_basic_oName IsNot Nothing Then
            ClsConfigBasic.GetInstance.Update(GetDataForInsertOrUpdate())
        Else
            ClsConfigBasic.GetInstance.Insert(GetDataForInsertOrUpdate())
        End If
    End Sub

    Private Function GetDataForInsertOrUpdate()
        Dim data As New ConfigBasic With {
            .Config_basic_oId = CurrentConfigBasic.ConfigBasic.Config_basic_oId,
            .Config_basic_oName = TxtoName.Text,
            .Config_basic_oSlogan = TxtoSologan.Text,
            .Config_basic_oAddress = TxtoAddress.Text,
            .Config_basic_oEmail = TxtoEmail.Text,
            .Config_basic_oTaxCode = TxtoTaxCode.Text}
        Return data
    End Function

#End Region
End Class
