
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

    '
    ' Cái này lười biếng nên lấy data trực tiếp từ server thông qia SQL join 4 table ()
    ' Làm đúng phải là user -> role (multi) -> role access(multi)
    '
    Public Function GetControlsAccessByUserName() As RolesControlsAccessCollection
        Dim RolesControlsAccessList As New RolesControlsAccessCollection
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_user_name", CurrentUser.User.User_name)
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
    Public Function GetControlsAccessByRole(Roles_name As String, RolesControlsAccessList As RolesControlsAccessCollection)

        Dim ObjControlsAccess As New List(Of RolesControlsAccessDTO)

        ObjControlsAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Roles_name = Roles_name)

        Return ObjControlsAccess

    End Function
    ''' <summary>
    ''' Return Access Controls by Role name, ex : Role{Ctrl(act1,act2...)}
    ''' </summary>
    Public Function GetAccessByRoleAndControls(Roles_name As String, Controls_name As String, RolesControlsAccessList As RolesControlsAccessCollection) As List(Of RolesControlsAccessDTO)
        Dim ObjAccess As New List(Of RolesControlsAccessDTO)
        ObjAccess = RolesControlsAccessList.FindAll(Function(Fx) Fx.Roles_name = Roles_name And Fx.Controls_name = Controls_name)
        Return ObjAccess
    End Function
    ''' <summary>
    ''' Return True if User has a role on control.
    ''' </summary>
    Public Function HasRole(Controls_name As String) As Boolean
        Dim Role = CurrentRolesControlsAccess.RolesControlsAccess
        If Role IsNot Nothing Then
            If Role.Exists(Function(Fx) Fx.Controls_name = Controls_name) Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If
    End Function

    Public Function Insert(ControlsAccess As ControlsAccessDTO) As Boolean
        Dim strSQL = "procInsertControlsAccess"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_controls_name", ControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", ControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
    Public Function Update(ControlsAccess As ControlsAccessDTO) As Boolean
        Dim strSQL = "procUpdateControlsAccess"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_controls_name", ControlsAccess.Controls_name),
            New MySqlParameter("@p_access_name", ControlsAccess.Access_name)
        }

        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function
End Class
