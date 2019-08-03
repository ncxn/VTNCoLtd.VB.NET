
Imports MySql.Data.MySqlClient

Public Class RolesControlsAccessDTO
    Private _roles_name As String
    Private _controls_name As String
    Private _access_name As String
    Private _allowed As Boolean
    'Public CurrentRole As 
    Public Property Roles_name As String
        Get
            Return _roles_name
        End Get
        Set(value As String)
            _roles_name = value
        End Set
    End Property

    Public Property Controls_name As String
        Get
            Return _controls_name
        End Get
        Set(value As String)
            _controls_name = value
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

    Public Property Allowed As Boolean
        Get
            Return _allowed
        End Get
        Set(value As Boolean)
            _allowed = value
        End Set
    End Property
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
        Dim dtControlsAccess As DataTable = DBHelper.GetInstance.GetDataTable("procGetAllRolesControlsAccess", CommandType.StoredProcedure)
        Return dtControlsAccess
    End Function

    Public Function GetList() As RolesControlsAccessCollection
        Dim RolesControlsAccessList As New RolesControlsAccessCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetAllRolesControlsAccess", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objRolesControlsAccess As New RolesControlsAccessDTO With {
                .Roles_name = Reader(0).ToString(),
                .Controls_name = Reader(1).ToString(),
                .Access_name = Reader(2).ToString(),
                .Allowed = Reader(3)
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
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procGetControlsAccessByUserName", CommandType.StoredProcedure, parameters)

        While Reader.Read()
            Dim objRolesControlsAccess As New RolesControlsAccessDTO With {
                .Roles_name = Reader(0).ToString(),
                .Controls_name = Reader(1).ToString(),
                .Access_name = Reader(2).ToString(),
                .Allowed = Reader(3)
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
        ObjControlsAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Roles_name = Roles_name)
        Return ObjControlsAccess
    End Function
    ''' <summary>
    ''' Return Access Controls by Role name, ex : Role{Ctrl(act1,act2...)}
    ''' </summary>
    Public Function GetAccessByRoleAndControls(Roles_name As String, Controls_name As String, RolesControlsAccessList As RolesControlsAccessCollection) As RolesControlsAccessCollection
        Dim RolesControlsAccess As New RolesControlsAccessCollection
        Dim ObjAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Roles_name = Roles_name And Fx.Controls_name = Controls_name)
        For Each Obj In ObjAccess
            Dim RolesControlsAccessDTO As New RolesControlsAccessDTO With {
             .Roles_name = Obj.Roles_name,
              .Controls_name = Obj.Controls_name,
             .Access_name = Obj.Access_name,
             .Allowed = Obj.Allowed}
            RolesControlsAccess.Add(RolesControlsAccessDTO)
        Next
        Return RolesControlsAccess
    End Function
    ''' <summary>
    ''' Return True if User has a role on menu Item.
    ''' </summary>
    Public Function HasRoleOnMenu(MenuItem As String) As Boolean
        Dim Role = CurrentRolesControlsAccess.RolesControlsAccess
        If Role IsNot Nothing Then
            If Role.Exists(Function(Fx) Fx.Controls_name = MenuItem) Then
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
        Dim Role = CurrentRolesControlsAccess.RolesControlsAccess
        If Role IsNot Nothing Then
            If Role.Exists(Function(Fx) Fx.Controls_name = Control_name And Fx.Access_name = Accese_name) Then
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
            New MySqlParameter("@p_roles_name", RolesControlsAccess.Roles_name),
            New MySqlParameter("@p_controls_name", RolesControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", RolesControlsAccess.Access_name),
            New MySqlParameter("@p_allowed", RolesControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function BulkInsert(RolesControlsAccessCollection As RolesControlsAccessCollection) As Boolean
        Dim strSQL = "procRolesControlsAaccess_Insert"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_roles_name", "p_controls_name", "p_access_name", "p_allowed"}

        For i As Integer = 0 To RolesControlsAccessCollection.Count - 1
            Dim paraValue As Object = New Object() {RolesControlsAccessCollection(i).Roles_name, RolesControlsAccessCollection(i).Controls_name, RolesControlsAccessCollection(i).Access_name, RolesControlsAccessCollection(i).Allowed}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result = DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function
    Public Function Update(RolesControlsAccess As RolesControlsAccessDTO) As Boolean
        Dim strSQL = "procRolesControlsAaccess_Update"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_roles_name", RolesControlsAccess.Roles_name),
            New MySqlParameter("@p_controls_name", RolesControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", RolesControlsAccess.Access_name),
            New MySqlParameter("@p_allowed", RolesControlsAccess.Access_name)
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

    Public Function DeleleByRole(Roles_name As String) As Boolean
        Dim strSQL = "procRolesControlsAaccess_DeleteByRole"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_roles_name", Roles_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function DeleleByRoleAndControl(Roles_name As String, Controls_name As String) As Boolean
        Dim strSQL = "procRolesControlsAaccess_DeleteByRole"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_roles_name", Roles_name),
            New MySqlParameter("@p_controls_name", Controls_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
End Class
