
#Region " DTO UsersConfirm"
'table users
Imports VTNcoLtd.DAL

Public Class UsersConfirmDTO
    Private _id As Integer
    Private _user_id As String
    Private _activecode As String
    Private _confirmed As Integer
    Private _created_at As Date
    Private _updated_at As Date

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property User_name As String
        Get
            Return _user_id
        End Get
        Set(value As String)
            _user_id = value
        End Set
    End Property

    Public Property Activecode As String
        Get
            Return _activecode
        End Get
        Set(value As String)
            _activecode = value
        End Set
    End Property

    Public Property Confirmed As Integer
        Get
            Return _confirmed
        End Get
        Set(value As Integer)
            _confirmed = value
        End Set
    End Property

    Public Property Created_at As Date
        Get
            Return _created_at
        End Get
        Set(value As Date)
            _created_at = value
        End Set
    End Property

    Public Property Updated_at As Date
        Get
            Return _updated_at
        End Get
        Set(value As Date)
            _updated_at = value
        End Set
    End Property
End Class
#End Region

Public Class ClsUsersConfirm

    Private Shared Singleton As ClsUsersConfirm

    Public Shared Function GetInstance() As ClsUsersConfirm
        If Singleton Is Nothing Then
            Singleton = New ClsUsersConfirm()
        End If
        Return Singleton
    End Function

    Public Function GetActiveCode(User_name As String, ActiveCode As String) As Boolean
        Dim strSQL = "procUsers_email_confirm_GetActiveCode"
        Dim paraName() As String = {"p_user_name", "p_activecode"}
        Dim paraValue As Object = New Object() {User_name, ActiveCode}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.GetScalarValue(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Insert(UsersConfirm As UsersConfirmDTO) As Boolean
        Dim strSQL = "procUsers_email_confirm_Insert"

        Dim paraName() As String = {"p_user_name", "p_activecode", "p_confirmed", "p_created_at", "p_updated_at"}
        Dim paraValue As Object = New Object() {UsersConfirm.User_name, UsersConfirm.Activecode, UsersConfirm.Confirmed, UsersConfirm.Created_at, UsersConfirm.Updated_at}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Update(User_name As String, ActiveCode As String) As Boolean
        Dim strSQL = "procUsers_email_confirm_Update"

        Dim paraName() As String = {"p_user_name", "p_activecode"}
        Dim paraValue As Object = New Object() {User_name, ActiveCode}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

End Class
