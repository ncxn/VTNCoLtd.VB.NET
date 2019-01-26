Imports DancePassion.cfgMails
Imports DevExpress.XtraBars.Docking2010

Public Class Mails
    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Dim Configs As DTO = New DTO(Me.txtKey.Text,
                               Me.txtServer.Text, Convert.ToInt32(Me.txtPort.Text), Me.txtUser.Text, txtPwd.Text,
                               Convert.ToBoolean(Me.chkSSL.Checked), Convert.ToBoolean(Me.ChkVdefault.Checked))
        Dim fn As New BUS
        fn._add(Configs)
    End Sub
End Class