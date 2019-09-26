Namespace Model

    Public Class ConfigBasic
        Private _config_basic_oId As Integer
        Private _config_basic_oName As String
        Private _config_basic_oSlogan As String
        Private _config_basic_oAddress As String
        Private _config_basic_oEmail As String
        Private _config_basic_oTaxCode As String

        Public Property Config_basic_oId As Integer
            Get
                Return _config_basic_oId
            End Get
            Set(value As Integer)
                _config_basic_oId = value
            End Set
        End Property

        Public Property Config_basic_oName As String
            Get
                Return _config_basic_oName
            End Get
            Set(value As String)
                _config_basic_oName = value
            End Set
        End Property

        Public Property Config_basic_oSlogan As String
            Get
                Return _config_basic_oSlogan
            End Get
            Set(value As String)
                _config_basic_oSlogan = value
            End Set
        End Property

        Public Property Config_basic_oAddress As String
            Get
                Return _config_basic_oAddress
            End Get
            Set(value As String)
                _config_basic_oAddress = value
            End Set
        End Property

        Public Property Config_basic_oEmail As String
            Get
                Return _config_basic_oEmail
            End Get
            Set(value As String)
                _config_basic_oEmail = value
            End Set
        End Property

        Public Property Config_basic_oTaxCode As String
            Get
                Return _config_basic_oTaxCode
            End Get
            Set(value As String)
                _config_basic_oTaxCode = value
            End Set
        End Property
    End Class

End Namespace
