Imports System.Security.Cryptography

#Region "DTO-Users"
'table users
Public Class UsersDTO
    Private _user_name As String
    Private _user_first_name As String
    Private _user_last_name As String
    Private _user_email As String
    Private _user_password As String
    Private _user_status As Boolean
    Private _user_created_at As Date
    Private _user_updated_at As Date

    Public Sub New(user_name As String, user_first_name As String, user_last_name As String, user_email As String, user_password As String, user_status As Boolean, user_created_at As Date, user_updated_at As Date)
        Me.User_email = user_name
        Me.User_first_name = user_first_name
        Me.User_last_name = user_last_name
        Me.User_email = user_email
        Me.User_password = user_password
        Me.User_status = user_status
        Me.User_created_at = user_created_at
        Me.User_updated_at = user_updated_at
    End Sub

    Public Property User_name As String
        Get
            Return _user_name
        End Get
        Set(value As String)
            _user_name = value
        End Set
    End Property

    Public Property User_first_name As String
        Get
            Return _user_first_name
        End Get
        Set(value As String)
            _user_first_name = value
        End Set
    End Property

    Public Property User_last_name As String
        Get
            Return _user_last_name
        End Get
        Set(value As String)
            _user_last_name = value
        End Set
    End Property

    Public Property User_email As String
        Get
            Return _user_email
        End Get
        Set(value As String)
            _user_email = value
        End Set
    End Property

    Public Property User_password As String
        Get
            Return _user_password
        End Get
        Set(value As String)
            _user_password = value
        End Set
    End Property

    Public Property User_status As Boolean
        Get
            Return _user_status
        End Get
        Set(value As Boolean)
            _user_status = value
        End Set
    End Property

    Public Property User_created_at As Date
        Get
            Return _user_created_at
        End Get
        Set(value As Date)
            _user_created_at = value
        End Set
    End Property

    Public Property User_updated_at As Date
        Get
            Return _user_updated_at
        End Get
        Set(value As Date)
            _user_updated_at = value
        End Set
    End Property
End Class
#End Region

#Region "DAL"
Public Class UsersDAL
    Public Function getUsers() As DataTable
        Dim dtUsers As DataTable = DBrun.getInstance.GetDataTable("select * from tblUsers")
        Return dtUsers
    End Function
    Public Function insertUsers(Users As UsersDTO) As Boolean
        Dim SQL As String = String.Format("INSERT INTO tblUsers
	        (user_name, user_first_name, user_last_name, user_email, user_password, user_status, user_created_at, user_updated_at)
	        VALUES (@user_name, @user_first_name, @user_last_name, @user_email, @user_password, @user_status, @user_created_at, @user_updated_at)")
        Dim para As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim result As Int32 = DBrun.getInstance.ExecuteNonQuery(SQL, para)
        Return result > 0
    End Function
    Public Function updateUsers(Users As UsersDTO) As Boolean
        Dim SQL As String = String.Format("INSERT INTO tblUsers
	        (user_name, user_first_name, user_last_name, user_email, user_password, user_status, user_created_at, user_updated_at)
	        VALUES (@user_name, @user_first_name, @user_last_name, @user_email, @user_password, @user_status, @user_created_at, @user_updated_at)")
        Dim para As Object = {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim result As Int32 = DBrun.getInstance.ExecuteNonQuery(SQL, para)
        Return result > 0
    End Function
End Class
#End Region

#Region "User-BUS"
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
        Dim result As DataTable = DBrun.getInstance.GetDataTable(query, New Object() {userName, passWord})
        Return result.Rows.Count > 0
    End Function
End Class
#End Region