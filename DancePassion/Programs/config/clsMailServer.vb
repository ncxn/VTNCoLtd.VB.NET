Option Explicit On
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient


#Region "DTO"
Public Class MailDTO
    Private _id As Integer
    Private _mail_service As String
    Private _mail_user As String
    Private _mail_password As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Mail_service As String
        Get
            Return _mail_service
        End Get
        Set(value As String)
            _mail_service = value
        End Set
    End Property

    Public Property Mail_user As String
        Get
            Return _mail_user
        End Get
        Set(value As String)
            _mail_user = value
        End Set
    End Property

    Public Property Mail_password As String
        Get
            Return _mail_password
        End Get
        Set(value As String)
            _mail_password = value
        End Set
    End Property
End Class
#End Region

#Region " Current mail"
Public Class CurrentMail
    Private Shared _CurrentMail As MailDTO
    Public Shared Property Mail As MailDTO
        Get
            Return _CurrentMail
        End Get
        Set(ByVal value As MailDTO)
            _CurrentMail = value
        End Set
    End Property
End Class
#End Region

#Region " User Collection"
Public Class MailCollection
    Inherits List(Of MailDTO)
End Class
#End Region

#Region " Data Access User"
Public Class ClsMailServer

    Private Shared Singleton As ClsMailServer

    Public Shared Function GetInstance() As ClsMailServer
        If Singleton Is Nothing Then
            Singleton = New ClsMailServer()
        End If
        Return Singleton
    End Function

    Public Function GetDataTable() As DataTable
        Dim dtMailServer As DataTable = DBHelper.GetInstance.GetDataTable("procMailServer_GetAll", CommandType.StoredProcedure)
        Return dtMailServer
    End Function

    Public Function GetList() As MailCollection
        Dim MailList As New MailCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procMailServer_GetAll", CommandType.StoredProcedure)

        While Reader.Read()
            Dim objMail As New MailDTO With {
                .Id = Reader(0).ToString(),
                .Mail_service = Reader(1).ToString(),
                .Mail_user = Reader(2).ToString(),
                .Mail_password = Reader(3).ToString()
            }
            MailList.Add(objMail)
        End While
        Reader.Close()

        Return MailList

    End Function

    Public Function GetCurrentMail(Mail_service As String) As MailDTO
        Dim ObjectMail As New MailDTO
        Dim strProc As String = "procMailServer_GetByMailService"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@p_mail_service", Mail_service)
        }
        Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        If Reader.Read() Then
            With ObjectMail
                .Id = Reader(0).ToString()
                .Mail_service = Reader(1).ToString()
                .Mail_user = Reader(2).ToString()
                .Mail_password = Reader(3).ToString()
            End With
        End If
        Reader.Close()

        Return ObjectMail

    End Function

    Public Function Insert(Mail As MailDTO) As Boolean
        Dim strSQL = "procMailServer_Insert"

        Dim paraName() As String = {"p_mail_service", "p_mail_user", "p_mail_password"}
        Dim paraValue As Object = New Object() {Mail.Mail_service, Mail.Mail_user, Mail.Mail_password}
        Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)
        Return result > 0
    End Function

    Public Function Update(Mail As MailDTO) As Boolean
        Dim strSQL = "procMailServer_Update"

        Dim paraName() As String = {"p_mail_service", "p_mail_user", "p_mail_password", "p_id"}
        Dim paraValue As Object = New Object() {Mail.Mail_service, Mail.Mail_user, Mail.Mail_password, Mail.Id}
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

#Region " Send mail"

    Public Sub SendMailMessage(ByVal toEmail As String, ByVal body As String, Optional ByVal fromEmail As String = Nothing, Optional ByVal subject As String = Nothing, Optional ByVal attachmentFullPath As List(Of String) = Nothing)
        Dim mMailMessage As MailMessage = New MailMessage()

        If Not String.IsNullOrEmpty(fromEmail) Then
            mMailMessage.From = New MailAddress(fromEmail)
        Else
            mMailMessage.From = New MailAddress(CurrentMail.Mail.Mail_user)
        End If

        mMailMessage.To.Add(New MailAddress(toEmail))

        If subject IsNot Nothing Then
            mMailMessage.Subject = subject
        Else
            mMailMessage.Subject = "VTNCoLtd Mail Service"
        End If

        mMailMessage.Body = body
        mMailMessage.IsBodyHtml = True
        mMailMessage.Priority = MailPriority.Normal

        If attachmentFullPath IsNot Nothing Then
            For Each attachmentPath In attachmentFullPath
                Dim mailAttachment As Attachment = New Attachment(attachmentPath)
                mMailMessage.Attachments.Add(mailAttachment)
            Next
        End If

        Using SMTP As SmtpClient = GetSMTP()
            SMTP.Send(mMailMessage)
        End Using
    End Sub

    Public Function GetSMTP() As SmtpClient
        Dim SMTP As New SmtpClient
        Select Case CurrentMail.Mail.Mail_service
            Case "Gmail"
                SMTP.Host = "smtp.gmail.com"
                SMTP.Port = 587
            Case "Outlook"
                SMTP.Host = "smtp.outlook.com"
                SMTP.Port = 587
            Case Else
                SMTP.Host = "smtp.outlook.com"
                SMTP.Port = 587
        End Select
        SMTP.Credentials = New Net.NetworkCredential(CurrentMail.Mail.Mail_user, CurrentMail.Mail.Mail_password)
        SMTP.EnableSsl = True
        Return SMTP
    End Function

    Public Function IsValidEmailAddress(ByVal emailAddress As String) As Boolean
        If String.IsNullOrEmpty(emailAddress) Then
            Return False
        End If

        Dim emailRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" & "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" & ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim re As Regex = New Regex(emailRegex)

        If re.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class

#End Region
