Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region " DTO Controls of form"
'table controls
Public Class ControlsDTO

    Private _control_name As String
    Private _control_description As String
    Private _control_parent As String
    Private _control_type As String
    Private _control_sort As Integer

    Public Property Control_name As String
        Get
            Return _control_name
        End Get
        Set(value As String)
            _control_name = value
        End Set
    End Property

    Public Property Control_description As String
        Get
            Return _control_description
        End Get
        Set(value As String)
            _control_description = value
        End Set
    End Property

    Public Property Control_parent As String
        Get
            Return _control_parent
        End Get
        Set(value As String)
            _control_parent = value
        End Set
    End Property

    Public Property Control_type As String
        Get
            Return _control_type
        End Get
        Set(value As String)
            _control_type = value
        End Set
    End Property

    Public Property Control_sort As Integer
        Get
            Return _control_sort
        End Get
        Set(value As Integer)
            _control_sort = value
        End Set
    End Property
End Class

#End Region

#Region " Controls Collection"
Public Class ControlsCollection
    Inherits List(Of ControlsDTO)
End Class
#End Region

#Region " Data Access for controls"
Public Class ClsControls

    Private Shared Singleton As ClsControls

    Public Shared Function GetInstance() As ClsControls
        If Singleton Is Nothing Then
            Singleton = New ClsControls()
        End If
        Return Singleton
    End Function

    Public Function GetDataTable() As DataTable
        Dim dtControls As DataTable = DBHelper.GetInstance.GetDataTable("procControls_GetAll", CommandType.StoredProcedure)
        Return dtControls
    End Function

    Public Function GetDataSet() As DataSet
        Dim dsControls As DataSet = DBHelper.GetInstance.GetDataSet("procControls_GetAll", CommandType.StoredProcedure)
        Return dsControls
    End Function

    Public Function GetList() As ControlsCollection
        Dim ControlsList As New ControlsCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procControls_GetWithTypeMenu", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objUser As New ControlsDTO With {
                .Control_name = Reader(0).ToString(),
                .Control_description = Reader(1).ToString(),
                .Control_parent = Reader(2).ToString(),
                .Control_type = Reader(3).ToString()
            }
            ControlsList.Add(objUser)
        End While
        Reader.Close()

        Return ControlsList

    End Function

    Public Function InsertControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procControls_Insert"

        Dim paraName() As String = {"p_control_name", "p_control_description", "p_control_parent", "p_control_type", "p_control_sort"}
        Dim paraValue As Object = New Object() {Controls.Control_name, Controls.Control_description, Controls.Control_parent, Controls.Control_type, Controls.Control_sort}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function BulkInsertControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procControls_Insert"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_control_name", "p_control_description", "p_control_parent", "p_control_type", "p_control_sort"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Control_name, Controls(i).Control_description, Controls(i).Control_parent, Controls(i).Control_type, Controls(i).Control_sort}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function

    Public Function UpdateControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procControls_Update"
        Dim paraName() As String = {"p_control_name", "p_control_description", "p_control_parent", "p_control_type", "p_control_sort"}
        Dim paraValue As Object = New Object() {Controls.Control_name, Controls.Control_description, Controls.Control_parent, Controls.Control_type, Controls.Control_sort}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function BulkUpdateControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procControls_Update"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_control_name", "p_control_description", "p_control_parent", "p_control_type", "p_control_sort"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Control_name, Controls(i).Control_description, Controls(i).Control_parent, Controls(i).Control_type, Controls(i).Control_sort}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function

    Public Function DeleteControls(Controls As ControlsDTO) As Boolean
        Dim strSQL = "procControls_DeleteByName"

        Dim paraName() As String = {"p_control_name"}
        Dim paraValue As Object = New Object() {Controls.Control_name}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function BulkDeleteControls(Controls As ControlsCollection) As Boolean
        Dim strSQL = "procControls_DeleteByName"
        Dim result As Integer = 0
        Dim paraName() As String = {"p_control_name"}

        For i As Integer = 0 To Controls.Count - 1
            Dim paraValue As Object = New Object() {Controls(i).Control_name}
            Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
            result += DBHelper.GetInstance.ExecuteNonQuerytWithTransaction(strSQL, CommandType.StoredProcedure, parameters)
        Next

        Return result > 0
    End Function
End Class
#End Region
