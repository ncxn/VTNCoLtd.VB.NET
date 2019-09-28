Namespace Model

    Public Class CustomerGroup
        Private _customer_group_id As Integer
        Private _customer_group_name As String
        Private _customer_group_parent As Integer

        Public Property Customer_group_id As Integer
            Get
                Return _customer_group_id
            End Get
            Set(value As Integer)
                _customer_group_id = value
            End Set
        End Property

        Public Property Customer_group_name As String
            Get
                Return _customer_group_name
            End Get
            Set(value As String)
                _customer_group_name = value
            End Set
        End Property

        Public Property Customer_group_parent As Integer
            Get
                Return _customer_group_parent
            End Get
            Set(value As Integer)
                _customer_group_parent = value
            End Set
        End Property
    End Class
End Namespace
