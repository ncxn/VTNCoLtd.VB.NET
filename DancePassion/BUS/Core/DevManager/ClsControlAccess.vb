Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

#Region " Data Access for controls Access"
    Public Class ClsControlAccess

        Private Shared Singleton As ClsControlAccess

        Public Shared Function GetInstance() As ClsControlAccess
            If Singleton Is Nothing Then
                Singleton = New ClsControlAccess()
            End If
            Return Singleton
        End Function

        Public Function GetDataTable() As DataTable
            Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblControls_access_Select_All", CommandType.StoredProcedure)
            Return dtControlsAccess
        End Function

        Public Function GetList() As ControlAccessCollection
            Dim ControlsAccessList As New ControlAccessCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblControls_access_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objControlsAccess As New ControlAccess With {
                .Control_name = Reader(0).ToString(),
                .Access_name = Reader(1).ToString()
            }
                ControlsAccessList.Add(objControlsAccess)
            End While
            Reader.Close()

            Return ControlsAccessList

        End Function

        ''' <summary>
        ''' Return acction for each controls, ex : UCUsers{View, Create, Edit, Delele, Print,...on so}
        ''' </summary>
        Public Function GetAccessByControls(Controls_name As String, ControlsAccessList As ControlAccessCollection) As List(Of String)

            Dim ObjAccess As New List(Of String)

            For Each Control In ControlsAccessList
                If Control.Control_name.ToString = Controls_name Then
                    ObjAccess.Add(Control.Access_name.ToString)
                End If
            Next

            Return ObjAccess

        End Function

        '''' <summary>
        '''' Return acction for each controls with desc , ex : UCUsers{(View,"Truy cập") , (Create,"Tạo mới"), (Edit,"Sửa")} 
        '''' </summary>
        Public Function GetAccessByControlsWithDesc(Control_name As String, ControlsAccessList As ControlAccessCollection, ObjAccess As AccessCollection) As AccessCollection
            Dim ObjRS = (From ca In ControlsAccessList
                         Join a In ObjAccess On ca.Access_name Equals a.Access_name
                         Where ca.Control_name = Control_name
                         Select New With
                      {
                      ca.Access_name,
                      a.Access_desc
                      }).ToList()
            Dim AccessCollection As New AccessCollection
            For Each Access In ObjRS
                Dim AccessDTO As New Access With {
                .Access_name = Access.Access_name,
                .Access_desc = Access.Access_desc}
                AccessCollection.Add(AccessDTO)
            Next

            Return AccessCollection

        End Function

        Public Function Insert(Model As ControlAccess) As Boolean
            Dim result As Integer
            Dim strSQL = "usp_tblControls_access_Insert"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_control_name", Model.Control_name),
                New MySqlParameter("@p_access_name", Model.Access_name)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function BulkInsert(ControlsAccess As ControlAccessCollection) As Boolean
            Dim strSQL = "usp_tblControls_access_Insert"
            Dim result As Integer = 0
            Dim paraName() As String = {"p_control_name", "p_access_name"}

            For i As Integer = 0 To ControlsAccess.Count - 1
                Dim paraValue As Object = New Object() {ControlsAccess(i).Control_name, ControlsAccess(i).Access_name}
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result += DBHelper.GetInstance.ExecuteNonQueryWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
            Next

            Return result > 0
        End Function

        Public Function Update(Model As ControlAccess) As Boolean
            Dim result As Integer
            Dim strSQL = "usp_tblControls_access_Insert"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_control_name", Model.Control_name),
                New MySqlParameter("@p_access_name", Model.Access_name)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0

        End Function

        Public Function BulkUpdate(ControlsAccess As ControlAccessCollection) As Boolean
            Dim strSQL = "usp_tblControls_access_Insert"
            Dim result As Integer = 0
            Dim paraName() As String = {"p_control_name", "p_access_name"}

            For i As Integer = 0 To ControlsAccess.Count - 1
                Dim paraValue As Object = New Object() {ControlsAccess(i).Control_name, ControlsAccess(i).Access_name}
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result += DBHelper.GetInstance.ExecuteNonQueryWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
            Next

            Return result > 0
        End Function

        Public Function Delete(Model As ControlAccess) As Boolean
            Dim result As Integer = 0
            Dim strSQL = "usp_tblControls_access_Delete"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_control_name", Model.Control_name),
                New MySqlParameter("@p_access_name", Model.Access_name)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function
    End Class

#End Region
End Namespace