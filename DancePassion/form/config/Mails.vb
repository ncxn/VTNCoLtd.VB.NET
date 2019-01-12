Imports DancePassion.cfgMails
Public Class Mails
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Configs As DTO = New DTO(Me.txtKey.Text,
                                Me.txtServer.Text, Convert.ToInt32(Me.txtPort.Text), Me.txtUser.Text, txtPwd.Text,
                                Convert.ToBoolean(Me.chkSSL.Checked), Convert.ToBoolean(Me.ChkVdefault.Checked))
        Dim fn As New BUS
        fn._add(Configs)
    End Sub
End Class