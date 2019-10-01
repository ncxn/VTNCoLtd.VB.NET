Namespace Model

    Public Class Mail
        Private _mail_service As String
        Private _mail_user As String
        Private _mail_password As String

        Public Property Mail_service As String
            Get
                Return _mail_service
            End Get
            Set(value As String)
                _mail_service = value
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
