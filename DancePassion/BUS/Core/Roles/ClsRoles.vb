Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsRoles

        Private Shared Singleton As ClsRoles

        Public Shared Function GetInstance() As ClsRoles
            If Singleton Is Nothing Then
                Singleton = New ClsRoles()
            End If
            Return Singleton
        End Function

        ''' <summary>
        ''' Return DataTable
        ''' </summary>
        ''' <returns></returns>
        Public Function GetDataTable() As DataTable
            Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblRoles_Select_All", CommandType.StoredProcedure)
            Return DataTable
        End Function

        ''' <summary>
        ''' Return List (of Model)
        ''' </summary>
        ''' <returns></returns>
        Public Function GetList() As RoleCollection
            Dim RolesList As New RoleCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblRoles_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objRoles As New Roles With {
                    .Role_name = Reader(0).ToString(),
                    .Role_description = Reader(1).ToString()
                }
                RolesList.Add(objRoles)
            End While
            Reader.Close()

            Return RolesList

        End Function

        ''' <summary>
        ''' Insert simple Model
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>true or false</returns>
        Public Function Insert(Model As Roles) As Boolean

            Dim result As Integer
            Dim strSQL = "usp_tblRoles_Insert"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_role_name", Model.Role_name),
                New MySqlParameter("p_role_description", Model.Role_description)
            }
            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Return result > 0

        End Function

        ''' <summary>
        ''' Update a Model
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>True/False</returns>
        Public Function Update(Model As Roles) As Boolean
            Dim strSQL = "usp_tblRoles_Update"
            Dim result As Integer

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_role_name", Model.Role_name),
                New MySqlParameter("p_role_description", Model.Role_description)
            }

            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Return result > 0

        End Function

        ''' <summary>
        ''' Delete a Model
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>True/False</returns>
        Public Function Delete(Model As Roles) As Boolean
            Dim strSQL = "usp_tblRoles_Delete"
            Dim result As Integer

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_role_name", Model.Role_name),
                New MySqlParameter("p_role_description", Model.Role_description)
            }

            Try
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Return result > 0

        End Function

    End Class

End Namespace