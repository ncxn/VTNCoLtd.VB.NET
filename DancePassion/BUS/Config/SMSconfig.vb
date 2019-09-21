Option Explicit On
'SMS DCOM
Imports System
Imports System.Threading
Imports System.ComponentModel
Imports System.IO.Ports
' SMS API
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Namespace SMS
#Region "DCOM"
    Public Class DCOM
        Private WithEvents SMSPort As SerialPort

        Private ReadOnly SMSThread As Thread
        Private ReadThread As Thread
        Shared _Continue As Boolean = False
        Shared _ContSMS As Boolean = False
        Private _Wait As Boolean = False
        Shared ReadOnly _ReadPort As Boolean = False
        Public Event Sending(ByVal Done As Boolean)
        Public Event DataReceived(ByVal Message As String)

        Public Sub New(ByRef COMMPORT As String)
            SMSPort = New SerialPort
            With SMSPort
                .PortName = COMMPORT
                .BaudRate = 115200
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
            End With
            ReadThread = New Thread(AddressOf ReadPort)
        End Sub

        Public Function SendSMS(ByVal CellNumber As String,
            ByVal SMSMessage As String) As Boolean
            Dim MyMessage As String = Nothing
            'Check if Message Length <= 160
            If SMSMessage.Length <= 160 Then
                MyMessage = SMSMessage
            Else
                MyMessage = Mid(SMSMessage, 1, 160)
            End If
            If IsOpen = True Then
                SMSPort.WriteLine("AT+CMGS=" & CellNumber & vbCr)
                _ContSMS = False
                SMSPort.WriteLine(MyMessage & vbCrLf & Chr(26))
                _Continue = False
                RaiseEvent Sending(False)
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub ReadPort()
            Dim SerialIn As String = Nothing
            Dim RXBuffer(SMSPort.ReadBufferSize) As Byte
            Dim SMSMessage As String = Nothing
            Dim Strpos As Integer = 0
            Dim TmpStr As String = Nothing

            While SMSPort.IsOpen = True
                If (SMSPort.BytesToRead <> 0) And (
                    SMSPort.IsOpen = True) Then
                    While SMSPort.BytesToRead <> 0
                        SMSPort.Read(RXBuffer, 0, SMSPort.ReadBufferSize)
                        SerialIn =
                            SerialIn & Text.Encoding.ASCII.GetString(
                            RXBuffer)
                        If SerialIn.Contains(">") = True Then
                            _ContSMS = True
                        End If
                        If SerialIn.Contains("+CMGS:") = True Then
                            _Continue = True
                            RaiseEvent Sending(True)
                            _Wait = False
                            SerialIn = String.Empty
                            ReDim RXBuffer(SMSPort.ReadBufferSize)
                        End If
                    End While
                    RaiseEvent DataReceived(SerialIn)
                    SerialIn = String.Empty
                    ReDim RXBuffer(SMSPort.ReadBufferSize)
                End If
            End While
        End Sub

        Public ReadOnly Property IsOpen() As Boolean
            Get
                If SMSPort.IsOpen = True Then
                    IsOpen = True
                Else
                    IsOpen = False
                End If
            End Get
        End Property

        Public Sub Open()
            If IsOpen = False Then
                SMSPort.Open()
                ReadThread.Start()
            End If
        End Sub

        Public Sub Close()
            If IsOpen = True Then
                SMSPort.Close()
            End If
        End Sub
        Public Function Test() As Boolean
            Dim _sms As DCOM = New DCOM("COMM1")
            _sms.Open()
            _sms.SendSMS("84972501502", "SMS Testing")
            _sms.Close()
            Return True
        End Function
    End Class
#End Region
#Region "twilio"
    Public Class Twilio
        Private Const accountSid = ""
        Private Const authToken = ""
        Public Function SendSMS(fromNum As PhoneNumber, toNum As PhoneNumber, body As String) As String
            TwilioClient.Init(accountSid, authToken)
            'Dim frNum As New PhoneNumber(fromNum)
            'Dim tNum As New PhoneNumber(toNum)
            Dim sms = MessageResource.Create(
            fromNum,,
            toNum,,
            body)
            Return sms.Status.ToString
        End Function
    End Class
#End Region
End Namespace