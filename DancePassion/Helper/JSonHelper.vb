Imports Newtonsoft.Json

Namespace Helper

    Public Class JSonHelper

        Private Shared Singleton As JSonHelper
        ''' <summary>
        ''' Use  Singleton Pattern
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetInstance() As JSonHelper
            If Singleton Is Nothing Then
                Singleton = New JSonHelper()
            End If
            Return Singleton
        End Function

        Public Function JsonToString(obj As Object) As String
            Return JsonConvert.SerializeObject(obj, Formatting.Indented)
        End Function

        Public Function StringToModel(str As String) As Object
            Return JsonConvert.DeserializeObject(Of Object)(str)
        End Function

    End Class

End Namespace
