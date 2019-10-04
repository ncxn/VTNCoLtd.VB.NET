Imports VTNcoLtd.Model

Namespace BUS

    Public Class CurrentMail
        Private Shared _mail As Mail

        Public Shared Property Mail As Mail
            Get
                Return _mail
            End Get
            Set(value As Mail)
                _mail = value
            End Set
        End Property
    End Class

End Namespace
