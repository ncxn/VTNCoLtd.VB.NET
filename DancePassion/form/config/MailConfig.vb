Imports DancePassion.MailConfig
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.ButtonPanel

Public Class Mailconfigfrm
    Public ReadOnly Property Buttons As BaseButtonCollection
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
            Me.ctrMailconfigSSL.Checked = Convert.ToBoolean(dr("ssl"))
            Me.ctrMailconfigVdefault.Checked = Convert.ToBoolean(dr("vDefault"))
        End If

    End Sub


    Private Sub WindowsUIButtonPanel1_Click(sender As Object, ByVal e As ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Dim btn As WindowsUIButton = TryCast(e.Button, WindowsUIButton)
        If btn.Tag.ToString = "Add" Then
            Dim mailconfig As DTO = New DTO(Me.ctrMailconfigKey.Text, Me.ctrMailconfigServer.Text,
                                        Convert.ToInt32(Me.ctrMailconfigPort.Text),
                                        Me.ctrMailconfigUser.Text, Me.ctrMailconfigPwd.Text,
                                        Convert.ToBoolean(Me.ctrMailconfigSSL.EditValue),
                                        Convert.ToBoolean(Me.ctrMailconfigVdefault.EditValue))

            Dim fn As New BUS
            Dim dr As DataRow = fn._findById(mailconfig.key)

            If dr Is Nothing Then
                fn._add(mailconfig)
            Else
                fn._update(mailconfig)
            End If
        End If

    End Sub
End Class