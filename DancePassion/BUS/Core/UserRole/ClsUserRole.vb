Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsUserRole
        Private Shared Singleton As ClsUserRole

        Public Shared Function GetInstance() As ClsUserRole
            If Singleton Is Nothing Then
                Singleton = New ClsUserRole()
            End If
            Return Singleton
        End Function

        Public Function GetDataTable() As DataTable
            Dim dtUserRoles As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblUsers_Roles_Select_All", CommandType.StoredProcedure)
            Return dtUserRoles
        End Function

        Public Function GetList() As UserRoleCollection
            Dim UserRolesList As New UserRoleCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblUsers_Roles_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objRoles As New UserRole With {
                    .User_name = Reader(0).ToString(),
                    .Role_name = Reader(1).ToString()
                }
                UserRolesList.Add(objRoles)
            End While
            Reader.Close()

            Return UserRolesList

        End Function

        Public Function GetRolesByUserName(user_name As String) As UserRoleCollection
            Dim ObjUserRoles As New UserRoleCollection
            Dim strProc As String = "usp_tblUsers_Roles_Select_By_UserName"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_user_name", user_name)
            }
            Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
            While Reader.Read()
                Dim objRoles As New UserRole With {
                    .User_name = Reader(0).ToString(),
                    .Role_name = Reader(1).ToString()
                }
                ObjUserRoles.Add(objRoles)
            End While
            Reader.Close()

            Return ObjUserRoles

        End Function

        Public Function Insert(UserRole As UserRole) As Boolean
            Dim strSQL = "usp_tblUsers_Roles_Insert"
            Dim result As Integer
            Dim paraName() As String = {"p_user_name", "p_role_name"}
            Dim paraValue As Object = New Object() {UserRole.User_name, UserRole.Role_name}

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function Update(UserRole As UserRole) As Boolean
            Dim strSQL = "usp_tblUsers_Roles_Update"
            Dim result As Integer
            Dim paraName() As String = {"p_user_name", "p_role_name"}
            Dim paraValue As Object = New Object() {UserRole.User_name, UserRole.Role_name}

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function Delete(UserRole As UserRole) As Boolean
            Dim strSQL = "usp_tblUsers_Roles_Delete"
            Dim result As Integer
            Dim paraName() As String = {"p_user_name", "p_role_name"}
            Dim paraValue As Object = New Object() {UserRole.User_name, UserRole.Role_name}

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