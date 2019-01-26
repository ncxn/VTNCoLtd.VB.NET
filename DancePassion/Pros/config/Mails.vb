Option Explicit On
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Namespace cfgMails
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
            Me.user = user
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
                Dim da As New MySqlDataAdapter("select * from Configs", fn.conn)
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
                Dim da As New MySqlDataAdapter("select * from Configs", fn.conn)
                da.Fill(dt)
                dt.PrimaryKey = New DataColumn() {dt.Columns("Config_key")}
                dr = dt.Rows.Find(key)
            Catch e As Exception
                'MessageBox.Show(e.Message)
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
                Dim da As New MySqlDataAdapter("select * from Configs where vDefault = 1", fn.conn)
                da.Fill(dt)
                dt.PrimaryKey = New DataColumn() {dt.Columns("Config_key")}
                dr = dt.Rows(0)
            Catch e As Exception
                'MessageBox.Show(e.Message)
            Finally
                fn.conn.Close()
            End Try
            Return dr
        End Function

        Public Function _Add(ByVal mailconfig As DTO) As Boolean
            Dim cmd As New MySqlCommand()
            Dim tr As MySqlTransaction = Nothing
            Try
                fn.conn.Open()
                tr = fn.conn.BeginTransaction()
                cmd.Connection = fn.conn
                cmd.Transaction = tr
                cmd.CommandText = "INSERT INTO Configs (Config_key, Config_values) 
                                               VALUES ('" & mailconfig.key & "', 
                                               COLUMN_CREATE('Server', '" & mailconfig.server & "',
                                                                           'Port', '" & mailconfig.port & "',
                                                                           'User', '" & mailconfig.user & "',
                                                                           'Pwd', '" & mailconfig.pwd & "',
                                                                           'SSL', '" & mailconfig.ssl & "',
                                                                           'vdefault', '" & mailconfig.vdefault & "'))"
                'Debug.Print(cmd.CommandText.ToString)
                'cmd.Parameters.AddWithValue("@Config_key", mailconfig.key)
                'cmd.Parameters.AddWithValue("@Config_values",)

                cmd.ExecuteNonQuery()
                tr.Commit()

                fn.conn.Close()

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
    Class Sendmail
        Public Function _ssend(ByVal sto As String, ByVal ssubject As String, ByVal sbody As String, ByVal sAttachment As String) As Boolean
            Dim SmtpServer As New SmtpClient()
            Dim fn As New BUS
            Dim dr As DataRow = fn._findFirst()
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New Net.NetworkCredential(CType(dr("user"), String), CType(dr("pwd"), String))
            SmtpServer.Host = CType(dr("server"), String)
            SmtpServer.Port = CInt(dr("port"))
            SmtpServer.EnableSsl = CBool(dr("ssl").ToString)

            Dim mail As New MailMessage
            mail.From = New MailAddress("nhan.vt@spm.com.vn")
            mail.To.Add(sto)
            mail.Subject = ssubject
            mail.Body = sbody
            mail.BodyEncoding = Text.Encoding.UTF8
            mail.IsBodyHtml = True
            If sAttachment Is Nothing Then
                mail.Attachments.Add(New Attachment(sAttachment))
            End If

            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            Try
                'Debug.Print(CBool(dr("SSL")))
                SmtpServer.Send(mail)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Function
    End Class
#End Region
End Namespace