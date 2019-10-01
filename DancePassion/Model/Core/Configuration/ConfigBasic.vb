Namespace Model

    Public Class ConfigBasic
        Private _config_basic_Name As String
        Private _config_basic_Slogan As String
        Private _config_basic_Address As String
        Private _config_basic_Email As String
        Private _config_basic_TaxCode As String

        Public Property Config_basic_Name As String
            Get
                Return _config_basic_Name
            End Get
            Set(value As String)
                _config_basic_Name = value
            End Set
        End Property

        Public Property Config_basic_Slogan As String
            Get
                Return _config_basic_Slogan
            End Get
            Set(value As String)
                _config_basic_Slogan = value
            End Set
        End Property

        Public Property Config_basic_Address As String
            Get
                Return _config_basic_Address
            End Get
            Set(value As String)
                _config_basic_Address = value
            End Set
        End Property

        Public Property Config_basic_Email As String
            Get
                Return _config_basic_Email
            End Get
            Set(value As String)
                _config_basic_Email = value
            End Set
        End Property

        Public Property Config_basic_TaxCode As String
            Get
                Return _config_basic_TaxCode
            End Get
            Set(value As String)
                _config_basic_TaxCode = value
            End Set
        End Property
    End Class

End Namespace
