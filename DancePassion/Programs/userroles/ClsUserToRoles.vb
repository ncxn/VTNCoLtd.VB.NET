Imports MySql.Data.MySqlClient

#Region " DTO UserRoles"
'table Roles
Public Class UserRolesDTO

    Private _role_name As String
    Private _user_name As String

    Public Property Role_name As String
        Get
            Return _role_name
        End Get
        Set(value As String)
            _role_name = value
        End Set
    End Property

    Public Property User_name As String
        Get
            Return _user_name
        End Get
        Set(value As String)
            _user_name = value
        End Set
    End Property
End Class
#End Region
#Region " Current UserToRoles"
Public Class CurrentUserRoles
    Private Shared _CurrentUserRoles As UserRolesCollection
    Public Shared Property RolesByUserName As UserRolesCollection
        Get
            Return _CurrentUserRoles
        End Get
        Set(ByVal value As UserRolesCollection)
            _CurrentUserRoles = value
        End Set
    End Property
End Class
#End Region

#Region " CurrentUserToRoles Collection"
Public Class UserRolesCollection
    Inherits List(Of UserRolesDTO)
End Class
#End Region

#Region " Roles Status"

#End Region

#Region " Data Access for Roles"
Public Class ClsUserRoles
    Private Shared Singleton As ClsUserRoles
    Public Shared Function GetInstance() As ClsUserRoles
        If Singleton Is Nothing Then
            Singleton = New ClsUserRoles()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtUserRoles As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllUserRoles", CommandType.StoredProcedure)
        Return dtUserRoles
    End Function
    Public Function GetList() As UserRolesCollection
        Dim UserRolesList As New UserRolesCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllUserRoles", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objRoles As New UserRolesDTO With {
                .User_name = Reader(0).ToString(),
                .Role_name = Reader(1).ToString()
            }
            UserRolesList.Add(objRoles)
        End While
        Reader.Close()

        Return UserRolesList

    End Function

    Public Function GetRolesByUserName(user_name As String) As UserRolesCollection
        Dim ObjUserRoles As New UserRolesCollection
        Dim strProc As String = "procGetRolesByUserName"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_user_name", user_name)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        While Reader.Read()
            Dim objRoles As New UserRolesDTO With {
                .User_name = Reader(0).ToString(),
                .Role_name = Reader(1).ToString()
            }
            ObjUserRoles.Add(objRoles)
        End While
        Reader.Close()

        Return ObjUserRoles

    End Function

    Public Function GetRolesByCurrentUserName() As UserRolesCollection
        Dim ObjUserRoles As New UserRolesCollection
        Dim strProc As String = "procGetRolesByUserName"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_user_name", CurrentUser.User.User_name)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        While Reader.Read()
            Dim objRoles As New UserRolesDTO With {
                .User_name = Reader(0).ToString(),
                .Role_name = Reader(1).ToString()
            }
            ObjUserRoles.Add(objRoles)
        End While
        Reader.Close()

        Return ObjUserRoles

    End Function

    Public Function InsertUsers(Users As UsersDTO) As Boolean
        Dim strSQL = "procInsertUsers"

        Dim paraName() As String = {"p_user_name", "p_user_first_name", "p_user_last_name", "p_user_email", "p_user_password", "p_user_status", "p_user_created_at", "p_user_updated_at"}
        Dim paraValue As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function UpdateUsers(Users As UsersDTO) As Boolean
        Dim strSQL = "procInsertUsers"

        Dim paraName() As String = {"p_user_name", "p_user_first_name", "p_user_last_name", "p_user_email", "p_user_password", "p_user_status", "p_user_created_at", "p_user_updated_at"}
        Dim paraValue As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
        Return result > 0
    End Function

End Class
#End Region

