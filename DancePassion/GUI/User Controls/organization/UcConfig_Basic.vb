Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model
Imports VTNcoLtd.DevExpressHelper

Public Class UcConfig_Basic
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Forms"

    Private Sub UcConfig_Basic_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
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

    Private Sub LoadData()
        Dim ConfigCollection As ConfigCollection = ClsConfig.GetInstance.GetList()
        Dim model As ConfigBasic = Nothing
        Try
            Dim Json As String = ClsConfig.GetInstance.GetJsonValue("BasicConfig", ConfigCollection)
            model = ClsConfigBasic.GetInstance.GetModelFromJsonString(Json)
        Catch ex As Exception

        End Try

        If model IsNot Nothing Then
            TxtoName.Text = model.Config_basic_Name
            TxtoSologan.Text = model.Config_basic_Slogan
            TxtoAddress.Text = model.Config_basic_Address
            TxtoEmail.Text = model.Config_basic_Email
            TxtoTaxCode.Text = model.Config_basic_TaxCode
        End If

    End Sub

    Private Function GetConfigBasicModel()
        Dim BasicConfig As New ConfigBasic With {
            .Config_basic_Name = TxtoName.Text,
            .Config_basic_Slogan = TxtoSologan.Text,
            .Config_basic_Address = TxtoAddress.Text,
            .Config_basic_Email = TxtoEmail.Text,
            .Config_basic_TaxCode = TxtoTaxCode.Text
        }

    End Function


    Private Sub UpdateDB()


    End Sub


#End Region

End Class
