Imports System.Net.Mail
Imports System.Text.RegularExpressions

Namespace BUS

    Public Class SendMail

        Private Shared Singleton As SendMail

        Public Shared Function GetInstance() As SendMail
            If Singleton Is Nothing Then
                Singleton = New SendMail()
            End If
            Return Singleton
        End Function


#Region " Send mail"

        Public Sub Send(ByVal toEmail As String, ByVal body As String, Optional ByVal fromEmail As String = Nothing, Optional ByVal subject As String = Nothing, Optional ByVal attachmentFullPath As List(Of String) = Nothing)
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

            Using SmtpClient As SmtpClient = GetSmtpClient()
                Try
                    SmtpClient.Send(mMailMessage)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            End Using

        End Sub

        ''' <summary>
        ''' Get SmtpClient with userName, passWord, host (smtp host server), smtp port (number)
        ''' </summary>
        ''' <param name="userName"></param>
        ''' <param name="passWord"></param>
        ''' <param name="host"></param>
        ''' <param name="port"></param>
        ''' <returns>SmtpClient</returns>
        Public Function GetSmtpClient(userName As String, passWord As String, host As String, port As Integer) As SmtpClient
            Dim SmtpClient As New SmtpClient With {
                .Host = host,
                .Port = port,
                .Credentials = New Net.NetworkCredential(userName, passWord),
                .EnableSsl = True
            }
            Return SmtpClient
        End Function

        ''' <summary>
        ''' Get SmtpClient by UserName, PassWord, Service (Only Gmail or Outlook (string))
        ''' </summary>
        ''' <param name="userName"></param>
        ''' <param name="passWord"></param>
        ''' <param name="Service"></param>
        ''' <returns>SmtpClient</returns>
        Public Function GetSmtpClient(userName As String, passWord As String, Service As String) As SmtpClient

            Dim SmtpClient As New SmtpClient

            Select Case Service
                Case "Gmail"
                    SmtpClient.Host = "smtp.gmail.com"
                    SmtpClient.Port = 587
                Case "Outlook"
                    SmtpClient.Host = "smtp.outlook.com"
                    SmtpClient.Port = 587
            End Select

            SmtpClient.Credentials = New Net.NetworkCredential(userName, passWord)
            SmtpClient.EnableSsl = True
            Return SmtpClient

        End Function

        ''' <summary>
        '''  Get SmtpClient
        ''' </summary>
        ''' <returns>SmtpClient</returns>
        Public Function GetSmtpClient() As SmtpClient
            Dim ConfigMail = CurrentMail.Mail
            Dim SmtpClient As New SmtpClient With {
                .Host = ConfigMail.Host,
                .Port = ConfigMail.Port,
                .Credentials = New Net.NetworkCredential(ConfigMail.Mail_user, ConfigMail.Mail_password),
                .EnableSsl = True
            }
            Return SmtpClient
        End Function

        ''' <summary>
        ''' Check Valid Email Address
        ''' </summary>
        ''' <param name="emailAddress"></param>
        ''' <returns>True/False</returns>
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

End Namespace
