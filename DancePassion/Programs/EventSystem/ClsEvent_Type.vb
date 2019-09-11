
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
        Dim dtRoles As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblEvent_Type_Select_All", CommandType.StoredProcedure)
        Return dtRoles
    End Function

    ''' <summary>
    ''' Return List (of Model)
    ''' </summary>
    ''' <returns>Collection of Model</returns>
    Public Function GetList() As Event_TypeCollection
        Dim ObjList As New Event_TypeCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblEvent_Type_Select_All", CommandType.StoredProcedure)

        While Reader.Read()
            Dim obj As New Event_TypeDTO With {
                .Event_Type_Id = Reader(0).ToString(),
                .Event_Type_Name = Reader(1).ToString(),
                .Event_Type_Desc = Reader(2).ToString()
            }
            ObjList.Add(obj)
        End While
        Reader.Close()

        Return ObjList

    End Function

    ''' <summary>
    ''' Insert simple Model
    ''' </summary>
    ''' <param name="Model"></param>
    ''' <returns>true or false</returns>
    Public Function Insert(Model As Event_TypeDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvent_Type_Insert"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_Event_Type_Name", Model.Event_Type_Name),
            New MySqlParameter("p_Event_Type_Desc", Model.Event_Type_Desc)
        }
        Try
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result > 0

    End Function

    ''' <summary>
    ''' Update a simple Model
    ''' </summary>
    ''' <param name="Model"></param>
    ''' <returns>True/False</returns>
    Public Function Update(Model As Event_TypeDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvent_Type_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_Event_Type_Id", Model.Event_Type_Id),
            New MySqlParameter("p_Event_Type_Name", Model.Event_Type_Name),
            New MySqlParameter("p_Event_Type_Desc", Model.Event_Type_Desc)
        }

        Try
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result > 0

    End Function

    ''' <summary>
    ''' Delete a Model
    ''' </summary>
    ''' <param name="RolesDTO"></param>
    ''' <returns>True/False</returns>
    Public Function Delete(Model As Event_TypeDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvent_Type_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
             New MySqlParameter("p_Event_Type_Id", Model.Event_Type_Id)
        }

        Try
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result > 0

    End Function

    ''' <summary>
    ''' Delete a Model by Id
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns>True/False</returns>
    Public Function Delete(Id As Integer) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvent_Type_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
             New MySqlParameter("p_Event_Type_Id", Id)
        }

        Try
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result > 0

    End Function

End Class

#End Region
