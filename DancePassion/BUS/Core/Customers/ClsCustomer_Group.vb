Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
''' <summary>
''' Generate model
''' </summary>
Public Class Customer_Group_DTO
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

''' <summary>
''' Share current Model
''' </summary>
Public Class Current_Customer_Group
    Private Shared _Customer_Group As Customer_Group_DTO

    Public Shared Property Customer_Group As Customer_Group_DTO
        Get
            Return _Customer_Group
        End Get
        Set(value As Customer_Group_DTO)
            _Customer_Group = value
        End Set
    End Property
End Class

''' <summary>
''' Get list of Model (Collection)
''' </summary>
Public Class Customer_GroupCollection
    Inherits List(Of Customer_Group_DTO)
End Class

''' <summary>
''' Creating a Business Logic Layer
''' </summary>
Public Class ClsCustomer_Group
    Private Shared Singleton As ClsCustomer_Group
    ''' <summary>
    ''' Use Singleton Pattern
    ''' </summary>
    ''' <returns>Singleton New Class</returns>
    Public Shared Function GetInstance() As ClsCustomer_Group
        If Singleton Is Nothing Then
            Singleton = New ClsCustomer_Group()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Get DataTable of Model
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function GetDataTable() As DataTable
        Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblCustomer_groups_Select_All", CommandType.StoredProcedure)
        Return DataTable
    End Function

    ''' <summary>
    ''' Get list(of Model)
    ''' </summary>
    ''' <returns>Collection</returns>
    Public Function GetList() As Customer_GroupCollection
        Dim ListModel As New Customer_GroupCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblCustomer_groups_Select_All", CommandType.StoredProcedure)

        While Reader.Read()
            Dim Model As New Customer_Group_DTO With {
                .Customer_group_id = Reader(0).ToString(),
                .Customer_group_name = Reader(1).ToString(),
                .Customer_group_parent = Reader(2).ToString()
            }
            ListModel.Add(Model)
        End While
        Reader.Close()

        Return ListModel

    End Function

    ''' <summary>
    ''' Get Model by Id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns> Model</returns>
    Public Function GetModelById(id As Integer) As Customer_Group_DTO
        Dim Model As New Customer_Group_DTO
        Dim strProc As String = "usp_tblCustomer_groups_Select_By_Id"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_customer_group_id", id)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        If Reader.Read() Then
            With Model
                .Customer_group_id = Reader(0).ToString()
                .Customer_group_name = Reader(1).ToString()
                .Customer_group_parent = Reader(2).ToString()
            End With
        End If
        Reader.Close()

        Return Model

    End Function

    Public Function Insert(Model As Customer_Group_DTO) As Boolean
        Dim strSQL = "usp_tblCustomer_groups_Insert"

        Dim paraName() As String = {"p_customer_group_name", "p_customer_group_parent"}
        Dim paraValue As Object = New Object() {
            Model.Customer_group_name,
            Model.Customer_group_parent
        }
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Update(Model As Customer_Group_DTO) As Boolean

        Dim strSQL = "usp_tblCustomer_groups_Update"
        Dim result As Integer
        Dim paraName() As String = {"p_customer_group_id", "p_customer_group_name", "p_customer_group_parent"}
        Dim paraValue As Object = New Object() {
            Model.Customer_group_id,
            Model.Customer_group_name,
            Model.Customer_group_parent
        }

        Try
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return result > 0

    End Function

    Public Function Delete(id As Integer) As Boolean
        Dim strSQL = "usp_tblCustomer_groups_Delete"

        Dim paraName() As String = {"p_customer_group_id"}
        Dim paraValue As Object = New Object() {id}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0

    End Function

    Public Function Delete(Model As Customer_Group_DTO) As Boolean
        Dim strSQL = "usp_tblCustomer_groups_Delete"

        Dim paraName() As String = {"p_customer_group_id"}
        Dim paraValue As Object = New Object() {Model.Customer_group_id}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0

    End Function

End Class
