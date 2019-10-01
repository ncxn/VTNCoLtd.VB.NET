Namespace Model

    Public Class Config
        Private _config_Id As Integer
        Private _config_Key As String
        Private _config_Value As String

        Public Property Config_Id As Integer
            Get
                Return _config_Id
            End Get
            Set(value As Integer)
                _config_Id = value
            End Set
        End Property

        Public Property Config_Key As String
            Get
                Return _config_Key
            End Get
            Set(value As String)
                _config_Key = value
            End Set
        End Property

        Public Property Config_Value As String
            Get
                Return _config_Value
            End Get
            Set(value As String)
                _config_Value = value
            End Set
        End Property
    End Class

End Namespace
