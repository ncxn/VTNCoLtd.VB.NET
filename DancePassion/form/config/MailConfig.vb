Imports DancePassion.MailConfig
Public Class Mailconfigfrm
    Private Sub Mailconfigfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim fn As New BUS
        Dim dr As DataRow = fn._findFirst()
        If dr Is Nothing Then
        Else

            Me.ctrMailconfigKey.Text = dr("key").ToString
            Me.ctrMailconfigServer.Text = dr("server").ToString
            Me.ctrMailconfigPort.Text = dr("port").ToString
            Me.ctrMailconfigUser.Text = dr("user").ToString
            Me.ctrMailconfigPwd.Text = dr("pwd").ToString
            Me.ctrMailconfigSSL.Checked = (Convert.ToBoolean(dr("ssl")))
            Me.ctrMailconfigVdefault.Checked = Convert.ToBoolean(dr("vDefault"))
        End If

    End Sub
    Private Sub ctrMailconfigOK_Click(sender As Object, e As EventArgs) Handles ctrMailconfigOK.Click
        Dim mailconfig As DTO = New DTO(Me.ctrMailconfigKey.Text, Me.ctrMailconfigServer.Text,
                                        Convert.ToInt32(Me.ctrMailconfigPort.Text),
                                        Me.ctrMailconfigUser.Text, Me.ctrMailconfigPwd.Text,
                                        Convert.ToBoolean(Me.ctrMailconfigSSL.EditValue),
                                        Convert.ToBoolean(Me.ctrMailconfigVdefault.EditValue))
        Dim fn As New BUS
        'fn._add(mailconfig)
        fn._update(mailconfig)
        Dim dr As DataRow = fn._findById(mailconfig.key)
        MessageBox.Show(dr(1).ToString)
    End Sub


End Class