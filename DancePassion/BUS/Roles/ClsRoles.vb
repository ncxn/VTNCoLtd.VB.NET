Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL

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
Public Class ClsRoles

    Private Shared Singleton As ClsRoles

    Public Shared Function GetInstance() As ClsRoles
        If Singleton Is Nothing Then
            Singleton = New ClsRoles()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Return datatable
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataTable() As DataTable
        Dim dtRoles As DataTable = DBHelper.GetInstance.GetDataTable("procRoles_GetAll", CommandType.StoredProcedure)
        Return dtRoles
    End Function

    ''' <summary>
    ''' Return List (of Model)
    ''' </summary>
    ''' <returns></returns>
    Public Function GetList() As RolesCollection
        Dim RolesList As New RolesCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procRoles_GetAll", CommandType.StoredProcedure)

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

    ''' <summary>
    ''' Insert simple role(name, description)
    ''' </summary>
    ''' <param name="RolesDTO"></param>
    ''' <returns>true or false</returns>
    Public Function Insert(RolesDTO As RolesDTO) As Boolean

        Dim result As Integer
        Dim strSQL = "procRoles_Insert"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_role_name", RolesDTO.Role_name),
            New MySqlParameter("p_role_description", RolesDTO.Role_description)
        }
        Try
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result > 0

    End Function

    ''' <summary>
    ''' Update a role
    ''' </summary>
    ''' <param name="RolesDTO"></param>
    ''' <returns>True/False</returns>
    Public Function Update(RolesDTO As RolesDTO) As Boolean
        Dim strSQL = "procRoles_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_role_name", RolesDTO.Role_name),
            New MySqlParameter("p_role_description", RolesDTO.Role_description)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    ''' <summary>
    ''' Delete a role
    ''' </summary>
    ''' <param name="RolesDTO"></param>
    ''' <returns>True/False</returns>
    Public Function Delete(RolesDTO As RolesDTO) As Boolean
        Dim strSQL = "procRoles_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_role_name", RolesDTO.Role_name),
            New MySqlParameter("p_role_description", RolesDTO.Role_description)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
End Class
#End Region
