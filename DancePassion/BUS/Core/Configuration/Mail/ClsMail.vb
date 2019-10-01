Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports VTNcoLtd.Model

Namespace BUS

    Public Class ClsMail

        Private Shared Singleton As ClsMail

        Public Shared Function GetInstance() As ClsMail
            If Singleton Is Nothing Then
                Singleton = New ClsMail()
            End If
            Return Singleton
        End Function


        ''' <summary>
        ''' Get Current Model
        ''' </summary>
        ''' <param name="None"></param>
        ''' <returns> Model</returns>
        Public Function GetModelFromJsonString(Json As String) As Mail
            Return JsonConvert.DeserializeObject(Of Mail)(Json)
        End Function

        ''' <summary>
        ''' Serialize Model to Json String
        ''' </summary>
        ''' <param name="Model"></param>
        ''' <returns>String Json</returns>
        Public Function GetJsonValueFromModel(Model As Mail) As String
            Return JsonConvert.SerializeObject(Model, Formatting.Indented)
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

End Namespace