Imports VTNcoLtd.Model

Namespace BUS
    Public Class CurrentCustomerGroup
        Private Shared _Customer_Group As CustomerGroup

        Public Shared Property Customer_Group As CustomerGroup
            Get
                Return _Customer_Group
            End Get
            Set(value As CustomerGroup)
                _Customer_Group = value
            End Set
        End Property
    End Class

End Namespace
