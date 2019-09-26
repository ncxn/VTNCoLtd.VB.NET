Namespace Model

    Public Class UserRole
        Private _role_name As String
        Private _user_name As String

        Public Property Role_name As String
            Get
                Return _role_name
            End Get
            Set(value As String)
                _role_name = value
            End Set
        End Property

        Public Property User_name As String
            Get
                Return _user_name
            End Get
            Set(value As String)
                _user_name = value
            End Set
        End Property
    End Class

End Namespace
