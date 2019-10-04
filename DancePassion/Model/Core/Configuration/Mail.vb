Namespace Model

    Public Class Mail
        Private _service As String
        Private _host As String
        Private _port As Integer
        Private _user As String
        Private _password As String

        Public Property Service As String
            Get
                Return _service
            End Get
            Set(value As String)
                _service = value
            End Set
        End Property

        Public Property Host As String
            Get
                Return _host
            End Get
            Set(value As String)
                _host = value
            End Set
        End Property

        Public Property Port As Integer
            Get
                Return _port
            End Get
            Set(value As Integer)
                _port = value
            End Set
        End Property

        Public Property User As String
            Get
                Return _user
            End Get
            Set(value As String)
                _user = value
            End Set
        End Property

        Public Property Password As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
            End Set
        End Property
    End Class

End Namespace
