Public Class AccessDTO
    Private _access_name As String
    Private _access_desc As String

    Public Property Access_name As String
        Get
            Return _access_name
        End Get
        Set(value As String)
            _access_name = value
        End Set
    End Property

    Public Property Access_desc As String
        Get
            Return _access_desc
        End Get
        Set(value As String)
            _access_desc = value
        End Set
    End Property
End Class
Public Class AccessCollection
    Inherits List(Of AccessDTO)
End Class
Public Class ClsAccess
    Private Shared Singleton As ClsAccess
    Public Shared Function GetInstance() As ClsAccess
        If Singleton Is Nothing Then
            Singleton = New ClsAccess()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable() As DataTable
        Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllAccess", CommandType.StoredProcedure)
        Return dtControlsAccess
    End Function

    Public Function GetList() As AccessCollection
        Dim AccessList As New AccessCollection
        Dim Reader = DBHelper.GetInstance.GetDataReader("procGetAllAccess", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objAccess As New AccessDTO With {
                .access_name = Reader(0).ToString(),
                .access_desc = Reader(1).ToString()
            }
            AccessList.Add(objAccess)
        End While
        Reader.Close()

        Return AccessList

    End Function
End Class
