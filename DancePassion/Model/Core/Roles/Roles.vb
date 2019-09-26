Namespace Model

    Public Class Roles

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


End Namespace