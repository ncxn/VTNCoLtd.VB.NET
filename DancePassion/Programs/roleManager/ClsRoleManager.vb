
Imports MySql.Data.MySqlClient

Public Class RolesControlsAccessDTO
    Private _role_name As String
    Private _control_name As String
    Private _access_name As String
    'Private _allowed As Boolean
    'Public CurrentRole As 
    Public Property Role_name As String
        Get
            Return _role_name
        End Get
        Set(value As String)
            _role_name = value
        End Set
    End Property

    Public Property Control_name As String
        Get
            Return _control_name
        End Get
        Set(value As String)
            _control_name = value
        End Set
    End Property

    Public Property Access_name As String
        Get
            Return _access_name
        End Get
        Set(value As String)
            _access_name = value
        End Set
    End Property

    'Public Property Allowed As Boolean
    '    Get
    '        Return _allowed
    '    End Get
    '    Set(value As Boolean)
    '        _allowed = value
    '    End Set
    'End Property
End Class
Public Class RolesControlsAccessCollection
    Inherits List(Of RolesControlsAccessDTO)
End Class
#Region " Current Current Roles Controls Access By UserName"
Public Class CurrentRolesControlsAccess
    Private Shared _CurrentCurrentRolesControlsAccess As RolesControlsAccessCollection
    Public Shared Property RolesControlsAccess As RolesControlsAccessCollection
        Get
            Return _CurrentCurrentRolesControlsAccess
        End Get
        Set(ByVal value As RolesControlsAccessCollection)
            _CurrentCurrentRolesControlsAccess = value
        End Set
    End Property
End Class
#End Region

Public Class ClsRoleManager

    Private Shared Singleton As ClsRoleManager

    Public Shared Function GetInstance() As ClsRoleManager
        If Singleton Is Nothing Then
            Singleton = New ClsRoleManager()
        End If
        Return Singleton
    End Function

    Public Function GetDataTable() As DataTable
        Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("procRolesControlsAccess_GetAll", CommandType.StoredProcedure)
        Return dtControlsAccess
    End Function

    Public Function GetList() As RolesControlsAccessCollection
        Dim RolesControlsAccessList As New RolesControlsAccessCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procRolesControlsAccess_GetAll", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objRolesControlsAccess As New RolesControlsAccessDTO With {
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
    Public Function GetControlsAccessByUserName(UserName As String) As RolesControlsAccessCollection
        Dim RolesControlsAccessList As New RolesControlsAccessCollection
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_user_name", UserName)
        }
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procControlsAccess_GetByUserName", CommandType.StoredProcedure, parameters)

        While Reader.Read()
            Dim objRolesControlsAccess As New RolesControlsAccessDTO With {
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
    Public Function GetControlsAccessByRole(Roles_name As String, RolesControlsAccessList As RolesControlsAccessCollection) As RolesControlsAccessCollection
        Dim ObjControlsAccess As New RolesControlsAccessCollection
        ObjControlsAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Role_name = Roles_name)
        Return ObjControlsAccess
    End Function

    ''' <summary>
    ''' Return Access Controls by Role name, ex : Role{Ctrl(act1,act2...)}
    ''' </summary>
    Public Function GetAccessByRoleAndControls(Roles_name As String, Controls_name As String, RolesControlsAccessList As RolesControlsAccessCollection) As RolesControlsAccessCollection
        Dim RolesControlsAccess As New RolesControlsAccessCollection
        Dim ObjAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Role_name = Roles_name And Fx.Control_name = Controls_name)
        For Each Obj In ObjAccess
            Dim RolesControlsAccessDTO As New RolesControlsAccessDTO With {
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

        Dim cRole = CurrentUserRoles.RolesByUserName
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

        Dim cRole = CurrentUserRoles.RolesByUserName
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

    Public Function Insert(RolesControlsAccess As RolesControlsAccessDTO) As Boolean
        Dim strSQL = "procRolesControlsAaccess_Insert"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_role_name", RolesControlsAccess.Role_name),
            New MySqlParameter("@p_control_name", RolesControlsAccess.Control_name),
            New MySqlParameter("@p_access_name", RolesControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function BulkInsert(RolesControlsAccessCollection As RolesControlsAccessCollection) As Boolean
        Dim strSQL = "procRolesControlsAaccess_Insert"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_role_name", "p_control_name", "p_access_name"}

        For i As Integer = 0 To RolesControlsAccessCollection.Count - 1
            Dim paraValue As Object = New Object() {RolesControlsAccessCollection(i).Role_name, RolesControlsAccessCollection(i).Control_name, RolesControlsAccessCollection(i).Access_name}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function

    Public Function Update(RolesControlsAccess As RolesControlsAccessDTO) As Boolean
        Dim strSQL = "procRolesControlsAaccess_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_role_name", RolesControlsAccess.Role_name),
            New MySqlParameter("@p_control_name", RolesControlsAccess.Control_name),
            New MySqlParameter("@p_access_name", RolesControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Delele() As Boolean
        Dim strSQL = "procRolesControlsAaccess_Delete"
        'Dim parameters As New List(Of MySqlParameter) From {
        '    New MySqlParameter("@p_roles_name", RolesControlsAccess.Controls_name),
        '    New MySqlParameter("@p_controls_name", RolesControlsAccess.Controls_name),
        '    New MySqlParameter("@p_access_name", RolesControlsAccess.Access_name),
        '    New MySqlParameter("@p_allowed", RolesControlsAccess.Access_name)
        '}

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure)
        Return result > 0
    End Function

    Public Function DeleleByRole(Role_name As String) As Boolean
        Dim strSQL = "procRolesControlsAaccess_DeleteByRole"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_role_name", Role_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function DeleleByRoleAndControl(Role_name As String, Control_name As String) As Boolean
        Dim strSQL = "procRolesControlsAaccess_DeleteByRole"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_role_name", Role_name),
            New MySqlParameter("@p_control_name", Control_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
End Class
