Namespace Model
    Public Class Access
        Private _access_name As String
        Private _access_desc As String

        Public Property Access_name As String
            Get
                Return _access_name
            End Get
            Set(value As String)
                _access_name = value
            End Set
        End Property

        Public Property Access_desc As String
            Get
                Return _access_desc
            End Get
            Set(value As String)
                _access_desc = value
            End Set
        End Property
    End Class
End Namespace

