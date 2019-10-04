Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsConfig
        Private Shared Singleton As ClsConfig
        ''' <summary>
        ''' Use Singleton Pattern
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetInstance() As ClsConfig
            If Singleton Is Nothing Then
                Singleton = New ClsConfig()
            End If
            Return Singleton
        End Function

        ''' <summary>
        ''' Get DataTable of Model
        ''' </summary>
        ''' <returns>DataTable</returns>
        Public Function GetDataTable() As DataTable
            Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblConfig_Select_All", CommandType.StoredProcedure)
            Return DataTable
        End Function

        ''' <summary>
        ''' Get List(of Model)
        ''' </summary>
        ''' <returns>Collection</returns>
        Public Function GetList() As ConfigCollection
            Dim List As New ConfigCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblConfig_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim Model As New Config With {
                    .Config_Id = Reader(0).ToString(),
                    .Config_Key = Reader(1).ToString(),
                    .Config_Value = Reader(2).ToString()
                }
                List.Add(Model)
            End While
            Reader.Close()

            Return List

        End Function

        ''' <summary>
        ''' Get Model by Key
        ''' </summary>
        ''' <param name="Key"></param>
        ''' <returns> Model</returns>
        Public Function GetConfigByKey(Key As String) As Config
            Dim Model As New Config
            Dim strProc As String = "usp_tblConfig_Select_By_Key"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_Config_key", Key)
            }
            Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
            If Reader.Read() Then
                With Model
                    .Config_Id = Reader(0).ToString()
                    .Config_Key = Reader(1).ToString()
                    .Config_Value = Reader(2).ToString()
                End With
            End If
            Reader.Close()

            Return Model

        End Function

        ''' <summary>
        ''' Get Json Format String
        ''' </summary>
        ''' <param name="Key"></param>
        ''' <param name="ListObj"></param>
        ''' <returns> Json String</returns>
        Public Function GetJsonValue(Key As String, ListObj As ConfigCollection, ByRef Config_Id As Integer, ByRef Config_key As String) As String
            Dim JsonString As String = String.Empty
            Try
                Dim Model = ListObj.First(Function(fn) fn.Config_Key = Key)
                JsonString = Model.Config_Value
                Config_Id = Model.Config_Id
                Config_key = Model.Config_Key
            Catch ex As Exception
                Config_Id = 0
                Config_key = Key
                Throw New Exception(ex.Message)
            End Try

            Return JsonString

        End Function

        Public Function Insert(Model As Config) As Boolean
            Dim strSQL = "usp_tblConfig_Insert"
            Dim result As Integer
            Dim paraName() As String = {"p_Config_key", "p_Config_Value"}
            Dim paraValue As Object = New Object() {
                Model.Config_Key,
                Model.Config_Value
            }
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function Update(Model As Config) As Boolean
            Dim strSQL = "usp_tblConfig_Update"
            Dim result As Integer
            Dim paraName() As String = {"p_Config_id", "p_Config_key", "p_Config_Value"}
            Dim paraValue As Object = New Object() {
                Model.Config_Id,
                Model.Config_Key,
                Model.Config_Value
            }
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function Delete(Model As Config) As Boolean
            Dim strSQL = "usp_tblConfig_Delete"
            Dim result As Integer
            Dim paraName() As String = {"p_Config_id", "p_Config_key", "p_Config_Value"}
            Dim paraValue As Object = New Object() {
                Model.Config_Id,
                Model.Config_Key,
                Model.Config_Value
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
            Dim strSQL = "usp_tblConfig_Delete"
            Dim result As Integer
            Dim paraName() As String = {"p_Config_id"}
            Dim paraValue As Object = New Object() {id}
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function
    End Class

End Namespace
