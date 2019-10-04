Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports VTNcoLtd.BUS
Imports VTNcoLtd.DevExpressHelper
Imports VTNcoLtd.Model

Public Class UcMailConfig
    Dim Config_Id As Integer = 0
    Dim Config_Key As String = String.Empty

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Form"

    Private Sub UcMailConfig_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If UpdateDB() Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub CbMail_service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMail_service.SelectedIndexChanged
        '    Dim editor As ImageComboBoxEdit = CType(sender, ImageComboBoxEdit)
        '    Me.Text = "SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
        ' " / value " + editor.EditValue.ToString() + " / display text " + editor.Text
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        LoadData()
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    'Private Sub CbMail_service_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbMail_service.SelectedValueChanged
    '    Dim editor As ImageComboBoxEdit = CType(sender, ImageComboBoxEdit)
    '    Debug.WriteLine("SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
    ' " / value " + editor.EditValue.ToString() + " / display text " + editor.Text)
    'End Sub

    Private Sub LoadData()

        Dim ConfigCollection As ConfigCollection = ClsConfig.GetInstance.GetList()
        Dim model As Mail = Nothing

        Try
            Dim Json As String = ClsConfig.GetInstance.GetJsonValue(ClsMail.GetInstance.Key, ConfigCollection, Config_Id, Config_Key)
            model = ClsMail.GetInstance.GetModelFromJsonString(Json)
        Catch ex As Exception

        End Try

        If model IsNot Nothing Then
            If CbMail_service.EditValue = model.Service Then
                TxtHost.Text = model.Host
                TxtPort.Text = model.Port
                TxtMail_user.Text = model.User
                TxtMail_password.Text = model.Password
            Else
                TxtHost.Text = String.Empty
                TxtPort.Text = 0
                TxtMail_user.Text = String.Empty
                TxtMail_password.Text = String.Empty
            End If
        Else
            TxtHost.Text = String.Empty
            TxtPort.Text = 0
            TxtMail_user.Text = String.Empty
            TxtMail_password.Text = String.Empty
        End If

    End Sub

    Private Function GetSubModel()
        Dim SubModel As New Mail With {
            .Service = CbMail_service.EditValue,
            .Host = TxtHost.Text,
            .Port = TxtPort.EditValue,
            .User = TxtMail_user.Text,
            .Password = TxtMail_password.Text
        }
        Return SubModel
    End Function

    Private Function GetModel()
        Dim Config As New Config With {
            .Config_Id = Config_Id,
            .Config_Key = Config_Key,
            .Config_Value = ClsMail.GetInstance.GetJsonValueFromModel(GetSubModel())
        }
        Return Config
    End Function


    Private Function UpdateDB() As Boolean
        Try
            If Config_Id > 0 Then
                ClsConfig.GetInstance.Update(GetModel())
            Else
                ClsConfig.GetInstance.Insert(GetModel())
            End If
            Return True
        Catch ex As Exception
            ShowMessage.GetInstance.ShowError(ex.Message)
            Return False
        End Try

    End Function

#End Region

End Class
