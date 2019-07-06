Imports System.Security.Cryptography
Imports System.Text

Public Class Security
    Public Shared Function GetMD5(ByVal input As String) As String
        Dim md5Hash As MD5 = MD5.Create()
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As StringBuilder = New StringBuilder()

        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next

        Return sBuilder.ToString()
    End Function
End Class
