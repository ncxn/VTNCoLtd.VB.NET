
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region " DTO"
'table Roles
Public Class Event_TypeDTO

    Private _Event_Type_Id As Integer
    Private _Event_Type_Name As String
    Private _Event_Type_Desc As String

    Public Property Event_Type_Id As Integer
        Get
            Return _Event_Type_Id
        End Get
        Set(value As Integer)
            _Event_Type_Id = value
        End Set
    End Property

    Public Property Event_Type_Name As String
        Get
            Return _Event_Type_Name
        End Get
        Set(value As String)
            _Event_Type_Name = value
        End Set
    End Property

    Public Property Event_Type_Desc As String
        Get
            Return _Event_Type_Desc
        End Get
        Set(value As String)
            _Event_Type_Desc = value
        End Set
    End Property
End Class

#End Region

#Region " Current"
''' <summary>
''' None
''' </summary>
#End Region

#Region " Collection"
Public Class Event_TypeCollection
    Inherits List(Of Event_TypeDTO)
End Class
#End Region

#Region " Status"
''' <summary>
''' none
''' </summary>
#End Region

#Region " Business Logic"

Public Class ClsEvent_Type

    Private Shared Singleton As ClsEvent_Type

    Public Shared Function GetInstance() As ClsEvent_Type
        If Singleton Is Nothing Then
            Singleton = New ClsEvent_Type()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Return datatable
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function GetDataTable() As DataTable
        Dim dtRoles As DataTable = DBHelper.GetInstance.GetDataTable("procEvent_Type_GetAll", CommandType.StoredProcedure)
        Return dtRoles
    End Function

    ''' <summary>
    ''' Return List (of Model)
    ''' </summary>
    ''' <returns>Collection of Model</returns>
    Public Function GetList() As RolesCollection
        Dim RolesList As New RolesCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procEvent_Type_GetAll", CommandType.StoredProcedure)

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
