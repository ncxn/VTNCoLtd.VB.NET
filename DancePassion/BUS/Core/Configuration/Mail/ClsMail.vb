Imports Newtonsoft.Json
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsMail

        Private Shared Singleton As ClsMail

        Public Shared Function GetInstance() As ClsMail
            If Singleton Is Nothing Then
                Singleton = New ClsMail()
            End If
            Return Singleton
        End Function

        Public Property Key As String = "MailConfig"

        ''' <summary>
        ''' Get Current Model
        ''' </summary>
        ''' <param name="None"></param>
        ''' <returns> Model</returns>
        Public Function GetModelFromJsonString(Json As String) As Mail
            Return JsonConvert.DeserializeObject(Of Mail)(Json)
        End Function

        ''' <summary>
        ''' Serialize Model to Json String
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>String Json</returns>
        Public Function GetJsonValueFromModel(Model As Mail) As String
            Return JsonConvert.SerializeObject(Model, Formatting.Indented)
        End Function

        Public Sub GetCurrentMailConfig()
            CurrentMail.Mail = GetModelFromJsonString(ClsConfig.GetInstance.GetConfigByKey(Key).Config_Value)
        End Sub

    End Class

End Namespace