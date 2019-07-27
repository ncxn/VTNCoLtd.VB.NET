Imports MySql.Data.MySqlClient

Public Class AccessDTO
    Private _access_name As String
    Private _access_desc As String

    Public Property Access_name As String
        Get
            Return _access_name
        End Get
        Set(value As String)
            _access_name = value
        End Set
    End Property

    Public Property Access_desc As String
        Get
            Return _access_desc
        End Get
        Set(value As String)
            _access_desc = value
        End Set
    End Property
End Class
Public Class AccessCollection
    Inherits List(Of AccessDTO)
End Class
Public Class ClsAccess
    Private Shared Singleton As ClsAccess
    Public Shared Function GetInstance() As ClsAccess
        If Singleton Is Nothing Then
            Singleton = New ClsAccess()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("procAccess_GetAll", CommandType.StoredProcedure)
        Return dtControlsAccess
    End Function

    Public Function GetList() As AccessCollection
        Dim AccessList As New AccessCollection
        Dim Reader = DBHelper.GetInstance.GetDataReader("procAccess_GetAll", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objAccess As New AccessDTO With {
                .Access_name = Reader(0).ToString(),
                .Access_desc = Reader(1).ToString()
            }
            AccessList.Add(objAccess)
        End While
        Reader.Close()

        Return AccessList

    End Function

    Public Function Insert(AccessDTO As AccessDTO) As Boolean
        Dim strSQL = "procAccess_Insert"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_access_name", AccessDTO.Access_name),
            New MySqlParameter("p_access_desc", AccessDTO.Access_desc)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function Update(AccessDTO As AccessDTO) As Boolean
        Dim strSQL = "procAccess_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_access_name", AccessDTO.Access_name),
            New MySqlParameter("@p_access_desc", AccessDTO.Access_desc)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Delete(AccessDTO As AccessDTO) As Boolean
        Dim strSQL = "procAccess_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_access_name", AccessDTO.Access_name),
            New MySqlParameter("@p_access_desc", AccessDTO.Access_desc)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
End Class
