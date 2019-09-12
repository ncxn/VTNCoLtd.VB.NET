Imports DancePassion

Public Class UcEvents_Update
    Private _cModel As EventsDTO

    Public Property CModel As EventsDTO
        Get
            Return _cModel
        End Get
        Set(value As EventsDTO)
            _cModel = value
        End Set
    End Property
End Class
