Namespace Model

    Public Class RolesControlsAccess
        Private _role_name As String
        Private _control_name As String
        Private _access_name As String

        Public Property Role_name As String
            Get
                Return _role_name
            End Get
            Set(value As String)
                _role_name = value
            End Set
        End Property

        Public Property Control_name As String
            Get
                Return _control_name
            End Get
            Set(value As String)
                _control_name = value
            End Set
        End Property

        Public Property Access_name As String
            Get
                Return _access_name
            End Get
            Set(value As String)
                _access_name = value
            End Set
        End Property
    End Class

End Namespace