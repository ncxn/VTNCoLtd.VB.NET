Imports MySql.Data.MySqlClient
Imports VTNcoLtd.BUS
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsRoleManager

        Private Shared Singleton As ClsRoleManager

        Public Shared Function GetInstance() As ClsRoleManager
            If Singleton Is Nothing Then
                Singleton = New ClsRoleManager()
            End If
            Return Singleton
        End Function

        Public Function GetDataTable() As DataTable
            Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("usp_tblRoles_controls_access_Select_All", CommandType.StoredProcedure)
            Return DataTable
        End Function

        Public Function GetList() As RoleControlAccessCollection
            Dim RolesControlsAccessList As New RoleControlAccessCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("usp_tblRoles_controls_access_Select_All", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objRolesControlsAccess As New RolesControlsAccess With {
                .Role_name = Reader(0).ToString(),
                .Control_name = Reader(1).ToString(),
                .Access_name = Reader(2).ToString()
             }
                RolesControlsAccessList.Add(objRolesControlsAccess)
            End While
            Reader.Close()

            Return RolesControlsAccessList

        End Function

        ''' <summary>
        ''' Return Access Controls by User name.
        ''' </summary>
        Public Function GetControlsAccessByUserName(UserName As String) As RoleControlAccessCollection
            Dim RolesControlsAccessList As New RoleControlAccessCollection
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("p_user_name", UserName)
            }
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procControlsAccess_GetByUserName", CommandType.StoredProcedure, parameters)

            While Reader.Read()
                Dim objRolesControlsAccess As New RolesControlsAccess With {
                    .Role_name = Reader(0).ToString(),
                    .Control_name = Reader(1).ToString(),
                    .Access_name = Reader(2).ToString()
                }
                RolesControlsAccessList.Add(objRolesControlsAccess)
            End While
            Reader.Close()

            Return RolesControlsAccessList

        End Function

        ''' <summary>
        ''' Return Access Controls by Role name, ex : Role{(ctr1, act1),(ctr1,act2),(ctr2,act1)}
        ''' </summary>
        Public Function GetControlsAccessByRole(Roles_name As String, RolesControlsAccessList As RoleControlAccessCollection) As RoleControlAccessCollection
            Dim ObjControlsAccess As New RoleControlAccessCollection
            ObjControlsAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Role_name = Roles_name)
            Return ObjControlsAccess
        End Function

        ''' <summary>
        ''' Return Access Controls by Role name, ex : Role{Ctrl(act1,act2...)}
        ''' </summary>
        Public Function GetAccessByRoleAndControls(Roles_name As String, Controls_name As String, RolesControlsAccessList As RoleControlAccessCollection) As RoleControlAccessCollection
            Dim RolesControlsAccess As New RoleControlAccessCollection
            Dim ObjAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Role_name = Roles_name And Fx.Control_name = Controls_name)
            For Each Obj In ObjAccess
                Dim RolesControlsAccessDTO As New RolesControlsAccess With {
                    .Role_name = Obj.Role_name,
                    .Control_name = Obj.Control_name,
                    .Access_name = Obj.Access_name
                    }
                RolesControlsAccess.Add(RolesControlsAccessDTO)
            Next
            Return RolesControlsAccess
        End Function

        ''' <summary>
        ''' Return True if User has a role on menu Item.
        ''' </summary>
        Public Function HasRoleOnMenu(MenuItem As String) As Boolean

            Dim cRole = CurrentUserRole.RolesByUserName
            If cRole.Exists(Function(Fx) Fx.Role_name = "Dev") Then Return True

            Dim Role = CurrentRolesControlsAccess.RolesControlsAccess

            If Role IsNot Nothing Then
                If Role.Exists(Function(Fx) Fx.Control_name = MenuItem) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Return True if User has a role on User Controls or form.
        ''' </summary>
        Public Function HasRoleOnUserControl(Control_name As String, Accese_name As String) As Boolean

            Dim cRole = CurrentUserRole.RolesByUserName
            If cRole.Exists(Function(Fx) Fx.Role_name = "Dev") Then Return True

            Dim Role = CurrentRolesControlsAccess.RolesControlsAccess

            If Role IsNot Nothing Then
                If Role.Exists(Function(Fx) Fx.Control_name = Control_name And Fx.Access_name = Accese_name) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Function

        Public Function Insert(Model As RolesControlsAccess) As Boolean
            Dim strSQL = "usp_tblRoles_controls_access_Insert"
            Dim result As Integer

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_role_name", Model.Role_name),
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

        Public Function BulkInsert(RolesControlsAccessCollection As RoleControlAccessCollection) As Boolean
            Dim strSQL = "usp_tblRoles_controls_access_Insert"
            Dim result As Integer = 0
            Dim paraName() As String = {"p_role_name", "p_control_name", "p_access_name"}

            For i As Integer = 0 To RolesControlsAccessCollection.Count - 1
                Dim paraValue As Object = New Object() {RolesControlsAccessCollection(i).Role_name, RolesControlsAccessCollection(i).Control_name, RolesControlsAccessCollection(i).Access_name}
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)

                result = DBHelper.GetInstance.ExecuteNonQueryWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
            Next

            Return result > 0
        End Function

        Public Function Delele(Model As RolesControlsAccess) As Boolean

            Dim strSQL = "usp_tblRoles_controls_access_Delete"
            Dim result As Integer

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_role_name", Model.Role_name),
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

        Public Function DeleleByRole(Role_name As String) As Boolean
            Dim strSQL = "usp_tblRoles_controls_access_Delete_Delete_By_Role"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_role_name", Role_name)
            }

            Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Return result > 0
        End Function

        Public Function DeleleByRoleAndControl(Role_name As String, Control_name As String) As Boolean
            Dim strSQL = "usp_tblRoles_controls_access_Delete_Delete_By_Role_And_Control"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@p_role_name", Role_name),
                New MySqlParameter("@p_control_name", Control_name)
            }

            Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
            Return result > 0
        End Function

    End Class

End Namespace