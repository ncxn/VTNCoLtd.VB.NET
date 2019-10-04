Namespace Model

    Public Class Mail
        Private _host As String
        Private _port As Integer
        Private _mail_user As String
        Private _mail_password As String

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

        Public Property Mail_user As String
            Get
                Return _mail_user
            End Get
            Set(value As String)
                _mail_user = value
            End Set
        End Property

        Public Property Mail_password As String
            Get
                Return _mail_password
            End Get
            Set(value As String)
                _mail_password = value
            End Set
        End Property


    End Class

End Namespace
