Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region " DTO Roles"
'table Roles
Public Class RolesDTO

    Private _role_name As String
    Private _role_description As String

    Public Property Role_name As String
        Get
            Return _role_name
        End Get
        Set(value As String)
            _role_name = value
        End Set
    End Property

    Public Property Role_description As String
        Get
            Return _role_description
        End Get
        Set(value As String)
            _role_description = value
        End Set
    End Property
End Class
#End Region
#Region " Current Roles"

#End Region
#Region " Roles Collection"
Public Class RolesCollection
    Inherits List(Of RolesDTO)
End Class
#End Region
#Region " Roles Status"
Public Enum RoleStatus
    Exits = 0
    Active = 1
    Locked = 2
    NotExists = 3
End Enum
#End Region
#Region " Data Access for Roles"
Public Class Roles
    Private Shared Singleton As Roles
    Public Shared Function GetInstance() As Roles
        If Singleton Is Nothing Then
            Singleton = New Roles()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtRoles As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllRoles", CommandType.StoredProcedure)
        Return dtRoles
    End Function
    Public Function GetList() As RolesCollection
        Dim RolesList As New RolesCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllRoles", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objRoles As New RolesDTO With {
                .Role_name = Reader(0).ToString(),
                .Role_description = Reader(1).ToString()
            }
            RolesList.Add(objRoles)
        End While
        Reader.Close()

        Return RolesList

    End Function

    Public Function GetRolesByUserID(user_id As Integer) As RolesCollection
        Dim ObjectRoles As New RolesCollection
        Dim strProc As String = "procGetAllRolesByUserID"

        user_id = CurrentUser.User.User_id

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_user_id", user_id)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        While Reader.Read()
            Dim objRoles As New RolesDTO With {
                .Role_name = Reader(0).ToString(),
                .Role_description = Reader(1).ToString()
            }
            ObjectRoles.Add(objRoles)
        End While
        Reader.Close()

        Return ObjectRoles

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
