Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    ''' <summary>
    ''' Creating a Business Logic Layer
    ''' </summary>
    Public Class ClsConfigBasic
        Private Shared Singleton As ClsConfigBasic
        ''' <summary>
        ''' Use Singleton Pattern
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetInstance() As ClsConfigBasic
            If Singleton Is Nothing Then
                Singleton = New ClsConfigBasic()
            End If
            Return Singleton
        End Function

        ''' <summary>
        ''' Get Current Basic Config
        ''' </summary>
        ''' <param name="None"></param>
        ''' <returns> Model</returns>
        Public Function GetModelFromJsonString(Json As String) As ConfigBasic
            Return JsonConvert.DeserializeObject(Of ConfigBasic)(Json)
        End Function

        ''' <summary>
        ''' Serialize Model to Json String
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>String Json</returns>
        Public Function GetJsonValueFromModel(Model As ConfigBasic) As String
            Return JsonConvert.SerializeObject(Model, Formatting.Indented)
        End Function

    End Class

End Namespace