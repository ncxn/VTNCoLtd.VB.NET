Namespace Model

    Public Class Customer
        Private _Customer_Id As Integer
        Private _Customer_Name As String
        Private _Customer_Address As String
        Private _Customer_Phone As String
        Private _Customer_Email As String
        Private _Customer_Group_Id As Integer
        Private _Customer_Expand_Info_Id As Integer

        Public Property Customer_Id As Integer
            Get
                Return _Customer_Id
            End Get
            Set(value As Integer)
                _Customer_Id = value
            End Set
        End Property

        Public Property Customer_Name As String
            Get
                Return _Customer_Name
            End Get
            Set(value As String)
                _Customer_Name = value
            End Set
        End Property

        Public Property Customer_Address As String
            Get
                Return _Customer_Address
            End Get
            Set(value As String)
                _Customer_Address = value
            End Set
        End Property

        Public Property Customer_Phone As String
            Get
                Return _Customer_Phone
            End Get
            Set(value As String)
                _Customer_Phone = value
            End Set
        End Property

        Public Property Customer_Email As String
            Get
                Return _Customer_Email
            End Get
            Set(value As String)
                _Customer_Email = value
            End Set
        End Property

        Public Property Customer_Group_Id As Integer
            Get
                Return _Customer_Group_Id
            End Get
            Set(value As Integer)
                _Customer_Group_Id = value
            End Set
        End Property

        Public Property Customer_Expand_Info_Id As Integer
            Get
                Return _Customer_Expand_Info_Id
            End Get
            Set(value As Integer)
                _Customer_Expand_Info_Id = value
            End Set
        End Property
    End Class

End Namespace