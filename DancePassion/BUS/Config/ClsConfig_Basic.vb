Imports DancePassion
Imports MySql.Data.MySqlClient
''' <summary>
''' Generate model for basic config 
''' </summary>
Public Class Config_Basic_DTO
    Private _config_basic_oId As Integer
    Private _config_basic_oName As String
    Private _config_basic_oSlogan As String
    Private _config_basic_oAddress As String
    Private _config_basic_oEmail As String
    Private _config_basic_oTaxCode As String

    Public Property Config_basic_oId As Integer
        Get
            Return _config_basic_oId
        End Get
        Set(value As Integer)
            _config_basic_oId = value
        End Set
    End Property

    Public Property Config_basic_oName As String
        Get
            Return _config_basic_oName
        End Get
        Set(value As String)
            _config_basic_oName = value
        End Set
    End Property

    Public Property Config_basic_oSlogan As String
        Get
            Return _config_basic_oSlogan
        End Get
        Set(value As String)
            _config_basic_oSlogan = value
        End Set
    End Property

    Public Property Config_basic_oAddress As String
        Get
            Return _config_basic_oAddress
        End Get
        Set(value As String)
            _config_basic_oAddress = value
        End Set
    End Property

    Public Property Config_basic_oEmail As String
        Get
            Return _config_basic_oEmail
        End Get
        Set(value As String)
            _config_basic_oEmail = value
        End Set
    End Property

    Public Property Config_basic_oTaxCode As String
        Get
            Return _config_basic_oTaxCode
        End Get
        Set(value As String)
            _config_basic_oTaxCode = value
        End Set
    End Property
End Class

''' <summary>
''' Share current config basic
''' </summary>
Public Class Current_Config_Basic
    Private Shared _config_basic As Config_Basic_DTO

    Public Shared Property Config_basic As Config_Basic_DTO
        Get
            Return _config_basic
        End Get
        Set(value As Config_Basic_DTO)
            _config_basic = value
        End Set
    End Property
End Class

''' <summary>
''' Get list of Config_Basic (Collection)
''' </summary>
Public Class Config_BasicCollection
    Inherits List(Of Config_Basic_DTO)
End Class

''' <summary>
''' Creating a Business Logic Layer
''' </summary>
Public Class ClsConfig_Basic
    Private Shared Singleton As ClsConfig_Basic
    ''' <summary>
    ''' Use  Singleton Pattern
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As ClsConfig_Basic
        If Singleton Is Nothing Then
            Singleton = New ClsConfig_Basic()
        End If
        Return Singleton
    End Function

    ''' <summary>
    ''' Get datatable of Config_Basic
    ''' </summary>
    ''' <returns>Datatable</returns>
    Public Function GetDataTable() As DataTable
        Dim Config_Basic As DataTable = DBHelper.GetInstance.GetDataTable("procConfig_basic_GetAll", CommandType.StoredProcedure)
        Return Config_Basic
    End Function

    ''' <summary>
    ''' Get list(of Model)
    ''' </summary>
    ''' <returns>Collection</returns>
    Public Function GetList() As Config_BasicCollection
        Dim Config_Basic_List As New Config_BasicCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procConfig_basic_GetAll", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objConfig_Basic As New Config_Basic_DTO With {
                .Config_basic_oId = Reader(0).ToString(),
                .Config_basic_oName = Reader(1).ToString(),
                .Config_basic_oSlogan = Reader(2).ToString(),
                .Config_basic_oAddress = Reader(3).ToString(),
                .Config_basic_oEmail = Reader(4).ToString(),
                .Config_basic_oTaxCode = Reader(5).ToString()
            }
            Config_Basic_List.Add(objConfig_Basic)
        End While
        Reader.Close()

        Return Config_Basic_List

    End Function

    ''' <summary>
    ''' Get current config basic
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns> Current config as model</returns>
    Public Function GetCurrentConfig_Basic(id As Integer) As Config_Basic_DTO
        Dim Config_Basic As New Config_Basic_DTO
        Dim strProc As String = "procConfig_basic_GetAll"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_config_basic_oId", id)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        If Reader.Read() Then
            With Config_Basic
                .Config_basic_oId = Reader(0).ToString()
                .Config_basic_oName = Reader(1).ToString()
                .Config_basic_oSlogan = Reader(2).ToString()
                .Config_basic_oAddress = Reader(3).ToString()
                .Config_basic_oEmail = Reader(4).ToString()
                .Config_basic_oTaxCode = Reader(5).ToString()
            End With
        End If
        Reader.Close()
        Current_Config_Basic.Config_basic = Config_Basic
        Return Config_Basic

    End Function

    Public Function Insert(Config_Basic As Config_Basic_DTO) As Boolean
        Dim strSQL = "procConfig_basic_Insert"

        Dim paraName() As String = {"p_config_basic_oName", "p_config_basic_oSlogan", "p_config_basic_oAddress", "p_config_basic_oEmail", "p_config_basic_oTaxCode"}
        Dim paraValue As Object = New Object() {
            Config_Basic.Config_basic_oName,
            Config_Basic.Config_basic_oSlogan,
            Config_Basic.Config_basic_oAddress,
            Config_Basic.Config_basic_oEmail,
            Config_Basic.Config_basic_oTaxCode
            }
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Update(Config_Basic As Config_Basic_DTO) As Boolean
        Dim strSQL = "procConfig_basic_Update"

        Dim paraName() As String = {"p_config_basic_oId", "p_config_basic_oName", "p_config_basic_oSlogan", "p_config_basic_oAddress", "p_config_basic_oEmail", "p_config_basic_oTaxCode"}
        Dim paraValue As Object = New Object() {
            Config_Basic.Config_basic_oId,
            Config_Basic.Config_basic_oName,
            Config_Basic.Config_basic_oSlogan,
            Config_Basic.Config_basic_oAddress,
            Config_Basic.Config_basic_oEmail,
            Config_Basic.Config_basic_oTaxCode
            }
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Delete(id As Integer) As Boolean
        Dim strSQL = "procMailServer_Delete"

        Dim paraName() As String = {"p_id"}
        Dim paraValue As Object = New Object() {id}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0

    End Function
End Class
