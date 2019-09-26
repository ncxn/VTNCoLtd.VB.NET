Imports VTNcoLtd.Model

Namespace BUS

    Public Class CurrentUser
        Private Shared _CurrentUser As Users
        Public Shared Property User As Users
            Get
                Return _CurrentUser
            End Get
            Set(ByVal value As Users)
                _CurrentUser = value
            End Set
        End Property
    End Class

End Namespace
