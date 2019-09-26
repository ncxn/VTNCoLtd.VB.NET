Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    ''' <summary>
    ''' Creating a Business Logic Layer
    ''' </summary>
    Public Class ClsConfigBasic
        Private Shared Singleton As ClsConfigBasic
        ''' <summary>
        ''' Use  Singleton Pattern
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetInstance() As ClsConfigBasic
            If Singleton Is Nothing Then
                Singleton = New ClsConfigBasic()
            End If
            Return Singleton
        End Function

        ''' <summary>
        ''' Get datatable of Config_Basic
        ''' </summary>
        ''' <returns>Datatable</returns>
        Public Function GetDataTable() As DataTable
            Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("procConfig_basic_GetAll", CommandType.StoredProcedure)
            Return DataTable
        End Function

        ''' <summary>
        ''' Get list(of Model)
        ''' </summary>
        ''' <returns>Collection</returns>
        Public Function GetList() As ConfigBasicCollection
            Dim List As New ConfigBasicCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procConfig_basic_GetAll", CommandType.StoredProcedure)

            While Reader.Read()
                Dim Model As New ConfigBasic With {
                .Config_basic_oId = Reader(0).ToString(),
                .Config_basic_oName = Reader(1).ToString(),
                .Config_basic_oSlogan = Reader(2).ToString(),
                .Config_basic_oAddress = Reader(3).ToString(),
                .Config_basic_oEmail = Reader(4).ToString(),
                .Config_basic_oTaxCode = Reader(5).ToString()
            }
                List.Add(Model)
            End While
            Reader.Close()

            Return List

        End Function

        ''' <summary>
        ''' Get current config basic
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns> Current config as model</returns>
        Public Function GetCurrentConfig_Basic(id As Integer) As ConfigBasic
            Dim Model As New ConfigBasic
            Dim strProc As String = "usp_tblConfig_basic_Select"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_config_basic_oId", id)
        }
            Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
            If Reader.Read() Then
                With Model
                    .Config_basic_oId = Reader(0).ToString()
                    .Config_basic_oName = Reader(1).ToString()
                    .Config_basic_oSlogan = Reader(2).ToString()
                    .Config_basic_oAddress = Reader(3).ToString()
                    .Config_basic_oEmail = Reader(4).ToString()
                    .Config_basic_oTaxCode = Reader(5).ToString()
                End With
            End If
            Reader.Close()

            Return Model

        End Function


        Public Function Insert(Model As ConfigBasic) As Boolean
            Dim strSQL = "usp_tblConfig_basic_Insert"
            Dim result As Integer
            Dim paraName() As String = {"p_config_basic_oName", "p_config_basic_oAddress", "p_config_basic_oSlogan", "p_config_basic_oEmail", "p_config_basic_oTaxCode"}
            Dim paraValue As Object = New Object() {
            Model.Config_basic_oName,
            Model.Config_basic_oSlogan,
            Model.Config_basic_oAddress,
            Model.Config_basic_oEmail,
            Model.Config_basic_oTaxCode
            }
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function Update(Model As ConfigBasic) As Boolean
            Dim strSQL = "usp_tblConfig_basic_Update"
            Dim result As Integer
            Dim paraName() As String = {"p_config_basic_oId", "p_config_basic_oName", "p_config_basic_oSlogan", "p_config_basic_oAddress", "p_config_basic_oEmail", "p_config_basic_oTaxCode"}
            Dim paraValue As Object = New Object() {
            Model.Config_basic_oId,
            Model.Config_basic_oName,
            Model.Config_basic_oSlogan,
            Model.Config_basic_oAddress,
            Model.Config_basic_oEmail,
            Model.Config_basic_oTaxCode
            }
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return result > 0
        End Function

        Public Function Delete(Model As ConfigBasic) As Boolean
            Dim strSQL = "usp_tblConfig_basic_Delete"
            Dim result As Integer
            Dim paraName() As String = {"p_id"}
            Dim paraValue As Object = New Object() {Model.Config_basic_oId}
            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return result > 0

        End Function

        Public Function Delete(id As Integer) As Boolean
            Dim strSQL = "usp_tblConfig_basic_Delete"
            Dim result As Integer
            Dim paraName() As String = {"p_id"}
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