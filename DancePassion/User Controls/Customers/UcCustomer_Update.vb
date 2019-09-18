Imports DancePassion

Public Class UcCustomer_Update



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub
#Region " Properties"
    Private _Cmodel As Customer_DTO
    Private _Customer As CustomerCollection

    Public Property Cmodel As Customer_DTO
        Get
            Return _Cmodel
        End Get
        Set(value As Customer_DTO)
            _Cmodel = value
        End Set
    End Property

    Public Property Customer As CustomerCollection
        Get
            Return _Customer
        End Get
        Set(value As CustomerCollection)
            _Customer = value
        End Set
    End Property
#End Region

#Region " From"



#End Region

#Region " Xử lý dữ liệu"



#End Region

End Class
