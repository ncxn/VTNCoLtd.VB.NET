Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    ''' <summary>
    ''' Creating a Business Logic Layer
    ''' </summary>
    Public Class ClsCustomerGroup
        Private Shared Singleton As ClsCustomerGroup
        ''' <summary>
        ''' Use Singleton Pattern
        ''' </summary>
        ''' <returns>Singleton New Class</returns>
        Public Shared Function GetInstance() As ClsCustomerGroup
            If Singleton Is Nothing Then
                Singleton = New ClsCustomerGroup()
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
        Public Function GetList() As CustomerGroupCollection
            Dim ListModel As New CustomerGroupCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblCustomer_groups_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim Model As New CustomerGroup With {
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
        Public Function GetModelById(id As Integer) As CustomerGroup
            Dim Model As New CustomerGroup
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

        Public Function Insert(Model As CustomerGroup) As Boolean
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

        Public Function Update(Model As CustomerGroup) As Boolean

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

        Public Function Delete(Model As CustomerGroup) As Boolean
            Dim strSQL = "usp_tblCustomer_groups_Delete"

            Dim paraName() As String = {"p_customer_group_id"}
            Dim paraValue As Object = New Object() {Model.Customer_group_id}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Return result > 0

        End Function

    End Class
End Namespace