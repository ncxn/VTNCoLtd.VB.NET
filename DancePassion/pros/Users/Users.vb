Imports System.Security.Cryptography

Public Class Users

    Private Shared Singleton As Users
    Public Shared Function getInstance() As Users
        If (Singleton Is Nothing) Then
            Singleton = New Users()
        End If
        Return Singleton
    End Function
    Public Function Login(ByVal userName As String, ByVal passWord As String) As Boolean
        Dim query As String = "Select * from tblUsers where user_name = @userName AND password = @passWord"
        'Dim query As String = "Call Proc_User_Login( @user , @pw)"
        Dim result As DataTable = DBrun.getInstance.GetDataTable(query, New Object() {userName, passWord})
        Return result.Rows.Count > 0
    End Function
End Class
