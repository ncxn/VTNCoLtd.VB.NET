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
        ClsConfig_Basic.GetInstance.GetCurrentConfig_Basic(1)

        TxtoName.Text = Current_Config_Basic.Config_basic.Config_basic_oName
        TxtoSologan.Text = Current_Config_Basic.Config_basic.Config_basic_oSlogan
        TxtoAddress.Text = Current_Config_Basic.Config_basic.Config_basic_oAddress
        TxtoEmail.Text = Current_Config_Basic.Config_basic.Config_basic_oEmail
        TxtoTaxCode.Text = Current_Config_Basic.Config_basic.Config_basic_oTaxCode
    End Sub

    Private Sub UpdateDB()
        If Current_Config_Basic.Config_basic.Config_basic_oName IsNot Nothing Then
            ClsConfig_Basic.GetInstance.Update(GetDataForInsertOrUpdate())
        Else
            ClsConfig_Basic.GetInstance.Insert(GetDataForInsertOrUpdate())
        End If
    End Sub

    Private Function GetDataForInsertOrUpdate()
        Dim data As New Config_Basic_DTO With {
            .Config_basic_oId = Current_Config_Basic.Config_basic.Config_basic_oId,
            .Config_basic_oName = TxtoName.Text,
            .Config_basic_oSlogan = TxtoSologan.Text,
            .Config_basic_oAddress = TxtoAddress.Text,
            .Config_basic_oEmail = TxtoEmail.Text,
            .Config_basic_oTaxCode = TxtoTaxCode.Text}
        Return data
    End Function

#End Region
End Class
