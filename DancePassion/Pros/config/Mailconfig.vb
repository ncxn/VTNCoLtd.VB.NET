Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports DancePassion.MYSQLSERVER

Namespace MailConfig

#Region "DTO"
    Public Class DTO
        Private _key As String
        Private _server As String
        Private _port As Integer
        Private _user As String
        Private _pwd As String
        Private _ssl As Boolean
        Private _vdefault As Boolean

        Public Property key As String
            Get
                Return _key
            End Get
            Set(ByVal value As String)
                _key = value
            End Set
        End Property
        Public Property server As String
            Get
                Return _server
            End Get
            Set(ByVal value As String)
                _server = value
            End Set
        End Property

        Public Property port As Integer
            Get
                Return _port
            End Get
            Set(ByVal value As Integer)
                _port = value
            End Set
        End Property

        Public Property user As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property

        Public Property pwd As String
            Get
                Return _pwd
            End Get
            Set(ByVal value As String)
                _pwd = value
            End Set
        End Property

        Public Property ssl As Boolean
            Get
                Return _ssl
            End Get
            Set(ByVal value As Boolean)
                _ssl = value
            End Set
        End Property
        Public Property vdefault As Boolean
            Get
                Return _vdefault
            End Get
            Set(ByVal value As Boolean)
                _vdefault = value
            End Set
        End Property
        Public Sub New()
        End Sub

        Public Sub New(ByVal key As String, ByVal server As String, ByVal port As Integer, ByVal user As String, ByVal pwd As String, ssl As Boolean, vdefault As Boolean)
            Me.key = key
            Me.server = server
            Me.port = port
            Me.user = server
            Me.pwd = pwd
            Me.ssl = ssl
            Me.vdefault = vdefault
        End Sub
    End Class
#End Region
#Region "DAL"
    Public Class DAL
        Private fn As New MYSQLSERVER

        Public Function _Get() As DataTable

            Dim dt As New DataTable

            Try
                fn.conn.Open()
                Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
                da.Fill(dt)
                fn.conn.Close()
            Catch e As Exception
                MessageBox.Show(e.Message)
            Finally

            End Try

            Return dt
        End Function
        Public Function _findByID(key As String) As DataRow

            Dim dt As New DataTable
            Dim dr As DataRow = Nothing
            Try
                fn.conn.Open()
                Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
                da.Fill(dt)
                dt.PrimaryKey = New DataColumn() {dt.Columns("key")}
                dr = dt.Rows.Find(key)
                If dr Is Nothing Then
                    MessageBox.Show("Không tìm thấy kết quả mong muốn")
                Else
                    Return dr
                End If

            Catch e As Exception
                MessageBox.Show(e.Message)
            Finally
                fn.conn.Close()
            End Try
            Return dr
        End Function
        Public Function _findFirst() As DataRow

            Dim dt As New DataTable
            Dim dr As DataRow = Nothing
            Try
                fn.conn.Open()
                Dim da As New MySqlDataAdapter("select * from mailConfig where vDefault = 1", fn.conn)
                da.Fill(dt)
                dt.PrimaryKey = New DataColumn() {dt.Columns("key")}
                dr = dt.Rows(0)
                If dr Is Nothing Then
                    MessageBox.Show("Không tìm thấy kết quả mong muốn")
                Else
                    Return dr
                End If

            Catch e As Exception
                'MessageBox.Show(e.Message)
            Finally
                fn.conn.Close()
            End Try
            Return dr
        End Function

        Public Function _Add(ByVal mailconfig As DTO) As Boolean
            fn.conn.Open()
            Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim cb As New MySqlCommandBuilder(da)
            Dim ci = cb.GetInsertCommand
            Dim tr As MySqlTransaction = fn.conn.BeginTransaction
            ci.Transaction = tr
            Try
                Dim r As DataRow = dt.NewRow
                r("key") = mailconfig.key
                r("server") = mailconfig.server
                r("port") = mailconfig.port
                r("user") = mailconfig.user
                r("pwd") = mailconfig.pwd
                r("ssl") = mailconfig.ssl
                r("vdefault") = mailconfig.vdefault
                dt.Rows.Add(r)
                da.Update(dt)
                tr.Commit()
                Return True

            Catch e As Exception
                MessageBox.Show(e.Message)
                tr.Rollback()
                Return False
            Finally
                fn.conn.Close()
            End Try

        End Function
        Public Function _update(ByVal mailconfig As DTO) As Boolean
            fn.conn.Open()
            Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim cb As New MySqlCommandBuilder(da)
            Dim cu = cb.GetUpdateCommand
            Dim tr As MySqlTransaction = fn.conn.BeginTransaction
            cu.Transaction = tr
            Try
                For Each r As DataRow In dt.Rows
                    If r("key").ToString = mailconfig.key Then

                        'r("key") = mailconfig.key
                        r("server") = mailconfig.server
                        r("port") = mailconfig.port
                        r("user") = mailconfig.user
                        r("pwd") = mailconfig.pwd
                        r("ssl") = mailconfig.ssl
                        r("vdefault") = mailconfig.vdefault
                    End If
                Next

                da.Update(dt)
                tr.Commit()
                Return True

            Catch e As Exception
                MessageBox.Show(e.Message)
                tr.Rollback()
                Return False
            Finally
                fn.conn.Close()
            End Try

        End Function
    End Class
#End Region
#Region "BUS"
    Public Class BUS
        Private dal As DAL = New DAL()

        Public Function _get() As DataTable
            Return dal._Get()
        End Function
        Public Function _findById(key As String) As DataRow
            Return dal._findByID(key)
        End Function
        Public Function _findFirst() As DataRow
            Return dal._findFirst()

        End Function

        Public Function _add(ByVal mailConfig As DTO) As Boolean
            Return dal._Add(mailConfig)
        End Function
        Public Function _update(ByVal mailConfig As DTO) As Boolean
            Return dal._update(mailConfig)
        End Function
    End Class
#End Region
#Region "Send mail"

#End Region
End Namespace