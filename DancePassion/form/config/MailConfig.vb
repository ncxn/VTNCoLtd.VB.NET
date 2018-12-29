Imports DancePassion.MailConfig
Public Class Mailconfigfrm

    Private Sub ctrMailconfigOK_Click(sender As Object, e As EventArgs) Handles ctrMailconfigOK.Click
        Dim mailconfig As DTO = New DTO(Me.ctrMaiconfigServer.Text,
                                        Convert.ToInt32(Me.ctrMaiconfigPort.Text),
                                        Me.ctrMaiconfigUser.Text, Me.ctrMaiconfigPwd.Text,
                                        Convert.ToBoolean(Me.ctrMailconfigSSL.EditValue))
        Dim fn As New BUS
        fn._add(mailconfig)
    End Sub
End Class