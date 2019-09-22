Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
''' <summary>
''' Generate model for basic config 
''' </summary>
Public Class Customer_DTO
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

''' <summary>
''' Share current Customer
''' </summary>
Public Class CurrentCustomer
    Private Shared _Customer As Customer_DTO

    Public Shared Property Customer As Customer_DTO
        Get
            Return _Customer
        End Get
        Set(value As Customer_DTO)
            _Customer = value
        End Set
    End Property
End Class

''' <summary>
''' Get list of Model List(of T)
''' </summary>
Public Class CustomerCollection
    Inherits List(Of Customer_DTO)
End Class

''' <summary>
''' Creating a Business Logic Layer
''' </summary>
Public Class ClsCustomers
    Private Shared Singleton As ClsCustomers
    ''' <summary>
    ''' Use  Singleton Pattern
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As ClsCustomers
        If Singleton Is Nothing Then
            Singleton = New ClsCustomers()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Get DataTable
    ''' </summary>
    ''' <returns>Datatable</returns>
    Public Function GetDataTable() As DataTable
        Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblCustomers_Select_All", CommandType.StoredProcedure)
        Return DataTable
    End Function

    ''' <summary>
    ''' Get list(of Model)
    ''' </summary>
    ''' <returns>Collection</returns>
    Public Function GetList() As CustomerCollection
        Dim ListModel As New CustomerCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblCustomers_Select_All", CommandType.StoredProcedure)

        While Reader.Read()
            Dim Model As New Customer_DTO With {
                .Customer_Id = Reader(0).ToString(),
                .Customer_Name = Reader(1).ToString(),
                .Customer_Address = Reader(2).ToString(),
                .Customer_Phone = Reader(3).ToString(),
                .Customer_Email = Reader(4).ToString(),
                .Customer_Group_Id = Reader(5).ToString(),
                .Customer_Expand_Info_Id = Reader(6).ToString()
            }
            ListModel.Add(Model)
        End While
        Reader.Close()

        Return ListModel

    End Function

    ''' <summary>
    ''' Get current config basic
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns> Current model</returns>
    Public Function GetCurrentModel(id As Integer) As Customer_DTO
        Dim Model As New Customer_DTO
        Dim strProc As String = "usp_tblCustomers_Select_All_By_Id"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_Customer_Id", id)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        If Reader.Read() Then
            With Model
                .Customer_Id = Reader(0).ToString()
                .Customer_Name = Reader(1).ToString()
                .Customer_Address = Reader(2).ToString()
                .Customer_Phone = Reader(3).ToString()
                .Customer_Email = Reader(4).ToString()
                .Customer_Group_Id = Reader(5).ToString()
                .Customer_Expand_Info_Id = Reader(6).ToString()
            End With
        End If
        Reader.Close()
        CurrentCustomer.Customer = Model
        Return Model

    End Function

    Public Function Insert(Model As Customer_DTO) As Boolean
        Dim strSQL = "usp_tblCustomers_Insert"
        Dim result As Integer
        Dim paraName() As String = {
            "p_Customer_Name",
            "p_Customer_Address",
            "p_Customer_Phone",
            "p_Customer_Email",
            "p_Customer_Group_Id",
            "p_Customer_Expand_Info_Id"
        }
        Dim paraValue As Object = New Object() {
            Model.Customer_Name,
            Model.Customer_Address,
            Model.Customer_Phone,
            Model.Customer_Email,
            Model.Customer_Group_Id,
            Model.Customer_Expand_Info_Id
            }
        Try
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return result > 0

    End Function

    Public Function Update(Model As Customer_DTO) As Boolean
        Dim strSQL = "usp_tblCustomers_Update"
        Dim result As Integer
        Dim paraName() As String = {
            "p_Customer_Id",
            "p_Customer_Name",
            "p_Customer_Address",
            "p_Customer_Phone",
            "p_Customer_Email",
            "p_Customer_Group_Id",
            "p_Customer_Expand_Info_Id"
        }
        Dim paraValue As Object = New Object() {
            Model.Customer_Id,
            Model.Customer_Name,
            Model.Customer_Address,
            Model.Customer_Phone,
            Model.Customer_Email,
            Model.Customer_Group_Id,
            Model.Customer_Expand_Info_Id
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
        Dim strSQL = "usp_tblCustomers_Delete"
        Dim result As Integer
        Dim paraName() As String = {"p_Customer_Id"}
        Dim paraValue As Object = New Object() {id}

        Try
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return result > 0

    End Function

    Public Function Delete(Model As Customer_DTO) As Boolean
        Dim strSQL = "usp_tblCustomers_Delete"
        Dim result As Integer
        Dim paraName() As String = {"p_Customer_Id"}
        Dim paraValue As Object = New Object() {Model.Customer_Id}

        Try
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return result > 0

    End Function
End Class
