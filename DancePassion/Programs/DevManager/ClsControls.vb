Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region " DTO Controls of form"
'table controls
Public Class ControlsDTO
    Private _controls_name As String
    Private _controls_description As String
    Private _controls_parent As String
    Private _controls_type As String
    Private _controls_sort As Integer
    Public Property Controls_name As String
        Get
            Return _controls_name
        End Get
        Set(value As String)
            _controls_name = value
        End Set
    End Property

    Public Property Controls_description As String
        Get
            Return _controls_description
        End Get
        Set(value As String)
            _controls_description = value
        End Set
    End Property

    Public Property Controls_parent As String
        Get
            Return _controls_parent
        End Get
        Set(value As String)
            _controls_parent = value
        End Set
    End Property

    Public Property Controls_type As String
        Get
            Return _controls_type
        End Get
        Set(value As String)
            _controls_type = value
        End Set
    End Property

    Public Property Controls_sort As Integer
        Get
            Return _controls_sort
        End Get
        Set(value As Integer)
            _controls_sort = value
        End Set
    End Property
End Class

#End Region

#Region " Controls Collection"
Public Class ControlsCollection
    Inherits List(Of ControlsDTO)
End Class
#End Region

#Region " Data Access for controls"
Public Class ClsControls
    Private Shared Singleton As ClsControls
    Public Shared Function GetInstance() As ClsControls
        If Singleton Is Nothing Then
            Singleton = New ClsControls()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtControls As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllControls", CommandType.StoredProcedure)
        Return dtControls
    End Function
    Public Function GetDataSet() As DataSet
        Dim dsControls As DataSet = DBHelper.GetInstance.GetDataSet("procGetAllControls", CommandType.StoredProcedure)
        Return dsControls
    End Function
    Public Function GetList() As ControlsCollection
        Dim ControlsList As New ControlsCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllControlsWithTypeMenu", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objUser As New ControlsDTO With {
                .Controls_name = Reader(0).ToString(),
                .Controls_description = Reader(1).ToString(),
                .Controls_parent = Reader(2).ToString(),
                .Controls_type = Reader(3).ToString()
            }
            ControlsList.Add(objUser)
        End While
        Reader.Close()

        Return ControlsList

    End Function

    Public Function Insert(user_id As Integer) As UsersDTO
        Dim ObjectUser As New UsersDTO
        Dim strProc As String = "procGetUserByID"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_user_id", user_id)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        If Reader.Read() Then
            With ObjectUser
                .User_id = Reader("User_id").ToString()
                .User_name = Reader("User_name").ToString()
                .User_first_name = Reader("User_first_name").ToString()
                .User_last_name = Reader("User_last_name").ToString()
                .User_email = Reader("User_email").ToString()
                .User_password = Reader("User_password").ToString()
                .User_status = CInt(Reader("User_password"))
                .User_created_at = CDate(Reader("User_created_at"))
                .User_updated_at = CDate(Reader("User_updated_at"))
            End With
        End If
        Reader.Close()

        Return ObjectUser

    End Function

    Public Function InsertControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procInsertControls"

        Dim paraName() As String = {"p_controls_name", "p_controls_description", "p_controls_parent", "p_controls_type", "p_controls_sort"}
        Dim paraValue As Object = New Object() {Controls.Controls_name, Controls.Controls_description, Controls.Controls_parent, Controls.Controls_type, Controls.Controls_sort}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function BulkInsertControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procInsertControls"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_controls_name", "p_controls_description", "p_controls_parent", "p_controls_type", "p_controls_sort"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Controls_name, Controls(i).Controls_description, Controls(i).Controls_parent, Controls(i).Controls_type, Controls(i).Controls_sort}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function

    Public Function UpdateControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procUpdateControls"
        Dim paraName() As String = {"p_controls_name", "p_controls_description", "p_controls_parent", "p_controls_type", "p_controls_sort"}
        Dim paraValue As Object = New Object() {Controls.Controls_name, Controls.Controls_description, Controls.Controls_parent, Controls.Controls_type, Controls.Controls_sort}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function BulkUpdateControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procUpdateControls"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_controls_name", "p_controls_description", "p_controls_parent", "p_controls_type", "p_controls_sort"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Controls_name, Controls(i).Controls_description, Controls(i).Controls_parent, Controls(i).Controls_type, Controls(i).Controls_sort}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function
    Public Function DeleteControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procDeleteControls"

        Dim paraName() As String = {"p_controls_name"}
        Dim paraValue As Object = New Object() {Controls.Controls_name}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function BulkDeleteControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procDeleteControls"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_controls_name"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Controls_name}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function
End Class
#End Region
