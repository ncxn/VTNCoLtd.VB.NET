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

#Region " Controls Status"
Public Enum Controls_status
    C_TRUE = 1
    C_FALSE = 0
End Enum
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
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllControls", CommandType.StoredProcedure)

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

    Public Function GetUserByID(user_id As Integer) As UsersDTO
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

    Public Function GetUserByUserName(user_name As String) As UsersDTO
        Dim ObjectUser As New UsersDTO
        Dim strProc As String = "procGetUserByUserName"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_user_name", user_name)
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
                .User_status = CInt(Reader("User_status"))
                .User_created_at = CDate(Reader("User_created_at"))
                .User_updated_at = CDate(Reader("User_updated_at"))

            End With
        End If
        Reader.Close()

        Return ObjectUser

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
    Public Function Login(ByVal userName As String, ByVal passWord As String, ByRef status As User_status) As UsersDTO

        Dim objUser As UsersDTO = GetUserByUserName(userName)
        If objUser.User_name IsNot Nothing Then
            If objUser.User_password = passWord Then
                If objUser.User_status = 1 Then
                    status = User_status.Active
                Else
                    status = User_status.Locked
                End If
            Else
                status = User_status.WrongPass
            End If
        Else
            status = User_status.NotExists
        End If

        Return objUser
    End Function
End Class
#End Region
