
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL

#Region " DTO"
'table Roles
Public Class EventsDTO
    Private _Event_Id As Integer
    Private _Event_Type_Id As Integer
    Private _Event_Name As String
    Private _Event_Start_Date As Date
    Private _Event_End_Date As Date
    Private _Event_Participant_Max As Integer

    Public Property Event_Id As Integer
        Get
            Return _Event_Id
        End Get
        Set(value As Integer)
            _Event_Id = value
        End Set
    End Property

    Public Property Event_Type_Id As Integer
        Get
            Return _Event_Type_Id
        End Get
        Set(value As Integer)
            _Event_Type_Id = value
        End Set
    End Property

    Public Property Event_Name As String
        Get
            Return _Event_Name
        End Get
        Set(value As String)
            _Event_Name = value
        End Set
    End Property

    Public Property Event_Start_Date As Date
        Get
            Return _Event_Start_Date
        End Get
        Set(value As Date)
            _Event_Start_Date = value
        End Set
    End Property

    Public Property Event_End_Date As Date
        Get
            Return _Event_End_Date
        End Get
        Set(value As Date)
            _Event_End_Date = value
        End Set
    End Property

    Public Property Event_Participant_Max As Integer
        Get
            Return _Event_Participant_Max
        End Get
        Set(value As Integer)
            _Event_Participant_Max = value
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
Public Class EventsCollection
    Inherits List(Of EventsDTO)
End Class
#End Region

#Region " Status"
''' <summary>
''' Stutus for Model
''' </summary>
Public Enum Event_status
    Open = 1
    Closed = 0
End Enum
#End Region

#Region " Business Logic"

Public Class ClsEvents

    Private Shared Singleton As ClsEvents

    Public Shared Function GetInstance() As ClsEvents
        If Singleton Is Nothing Then
            Singleton = New ClsEvents()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Return datatable
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function GetDataTable() As DataTable

        Dim DataTable As DataTable = Nothing
        Dim strProc As String = "usp_tblEvents_Select_All"

        Try
            DataTable = DBHelper.GetInstance.GetDataTable(strProc, CommandType.StoredProcedure)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return DataTable

    End Function

    ''' <summary>
    ''' Return List (of Model)
    ''' </summary>
    ''' <returns>Collection of Model</returns>
    Public Function GetList() As EventsCollection
        Dim ObjList As New EventsCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblEvents_Select_All", CommandType.StoredProcedure)

        While Reader.Read()
            Dim obj As New EventsDTO With {
                .Event_Id = Reader(0).ToString(),
                .Event_Type_Id = Reader(1).ToString(),
                .Event_Name = Reader(2).ToString(),
                .Event_Start_Date = Reader(3).ToString(),
                .Event_End_Date = Reader(4).ToString(),
                .Event_Participant_Max = Reader(5).ToString()
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
    Public Function Insert(Model As EventsDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvents_Insert"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_Event_Type_Id", Model.Event_Type_Id),
            New MySqlParameter("p_Event_Name", Model.Event_Name),
            New MySqlParameter("p_Event_Start_Date", Model.Event_Start_Date),
            New MySqlParameter("p_Event_End_Date", Model.Event_End_Date),
            New MySqlParameter("p_Event_Participant_Max", Model.Event_Participant_Max)
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
    Public Function Update(Model As EventsDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvents_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_Event_Id", Model.Event_Id),
            New MySqlParameter("p_Event_Type_Id", Model.Event_Type_Id),
            New MySqlParameter("p_Event_Name", Model.Event_Name),
            New MySqlParameter("p_Event_Start_Date", Model.Event_Start_Date),
            New MySqlParameter("p_Event_End_Date", Model.Event_End_Date),
            New MySqlParameter("p_Event_Participant_Max", Model.Event_Participant_Max)
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
    Public Function Delete(Model As EventsDTO) As Boolean

        Dim result As Integer = 0
        Dim strSQL = "usp_tblEvents_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
             New MySqlParameter("p_Event_Id", Model.Event_Id)
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
        Dim strSQL = "usp_tblEvents_Delete"
        Dim parameters As New List(Of MySqlParameter) From {
             New MySqlParameter("p_Event_Id", Id)
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
