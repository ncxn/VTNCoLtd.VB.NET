Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model
Imports VTNcoLtd.DevExpressHelper
Imports DevExpress.XtraSplashScreen

Public Class UcConfig_Basic
    Dim Config_Id As Integer = 0
    Dim Config_Key As String = String.Empty

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
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If UpdateDB() Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
        SplashScreenManager.CloseOverlayForm(handle)
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
            Dim Json As String = ClsConfig.GetInstance.GetJsonValue(ClsConfigBasic.GetInstance.Key, ConfigCollection, Config_Id, Config_Key)
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
        Return BasicConfig
    End Function

    Private Function GetConfigModel()
        Dim Config As New Config With {
            .Config_Id = Config_Id,
            .Config_Key = Config_Key,
            .Config_Value = ClsConfigBasic.GetInstance.GetJsonValueFromModel(GetConfigBasicModel())
        }
        Return Config
    End Function


    Private Function UpdateDB() As Boolean
        Try
            If Config_Id > 0 Then

                ClsConfig.GetInstance.Update(GetConfigModel())
            Else
                ClsConfig.GetInstance.Insert(GetConfigModel())
            End If
            Return True
        Catch ex As Exception
            ShowMessage.GetInstance.ShowError(ex.Message)
            Return False
        End Try

    End Function

#End Region

End Class
