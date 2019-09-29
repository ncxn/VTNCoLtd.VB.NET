Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model


Namespace BUS

    Public Class ClsAccess
        Private Shared Singleton As ClsAccess
        Public Shared Function GetInstance() As ClsAccess
            If Singleton Is Nothing Then
                Singleton = New ClsAccess()
            End If
            Return Singleton
        End Function
        Public Function GetDataTable() As DataTable
            Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblAccess_Select_All", CommandType.StoredProcedure)
            Return dtControlsAccess
        End Function

        Public Function GetList() As AccessCollection
            Dim AccessList As New AccessCollection
            Dim Reader = DBHelper.GetInstance.GetDataReader("usp_tblAccess_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objAccess As New Access With {
                .Access_name = Reader(0).ToString(),
                .Access_desc = Reader(1).ToString()
            }
                AccessList.Add(objAccess)
            End While
            Reader.Close()

            Return AccessList

        End Function

        Public Function Insert(Model As Access) As Boolean
            Dim strSQL = "usp_tblAccess_Insert"
            Dim result As Integer
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_access_name", Model.Access_name),
                New MySqlParameter("p_access_desc", Model.Access_desc)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function Update(Model As Access) As Boolean
            Dim strSQL = "usp_tblAccess_Update"
            Dim result As Integer
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_access_name", Model.Access_name),
                New MySqlParameter("p_access_desc", Model.Access_desc)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function Delete(Model As Access) As Boolean
            Dim strSQL = "usp_tblAccess_Delete"
            Dim result As Integer
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_access_name", Model.Access_name)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

    End Class

End Namespace