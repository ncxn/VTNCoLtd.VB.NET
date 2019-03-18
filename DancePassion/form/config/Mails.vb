Imports System.ComponentModel
Imports DancePassion.cfgMail
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors

Public Class Mails
    Dim fn As New BUS

    Private Sub Mails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dr As DataRow = fn._findFirst()
        Me.txtKey.Text = dr("Service").ToString
        Me.txtServer.Text = dr("Server").ToString
        Me.txtPort.Text = dr("port").ToString
        Me.txtUser.Text = dr("User").ToString
        Me.txtPwd.Text = dr("Pwd").ToString
        Me.chkSSL.Checked = CBool(CType(dr("SSL"), CheckState))
        Me.ChkVdefault.Checked = CBool(CType(dr("vdefault"), CheckState))
    End Sub
    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Dim Configs As DTO = New DTO(
                                        Me.txtKey.Text,
                                        Me.txtServer.Text,
                                        Convert.ToInt32(Me.txtPort.Text),
                                        Me.txtUser.Text, txtPwd.Text,
                                        Convert.ToBoolean(Me.chkSSL.Checked),
                                        Convert.ToBoolean(Me.ChkVdefault.Checked))

        Dim dr As DataRow = fn._findById(Configs.Service)
        'Try
        If Not (dr Is Nothing) Then
            If fn._update(Configs) = True Then
                FlyMess.ShowPopup()
            End If
        Else
            If fn._add(Configs) = True Then
                FlyMess.ShowPopup()
            End If
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub FlyMess_Showing(sender As Object, e As FlyoutPanelEventArgs)
        FlyMess.FindForm().TopMost = True
    End Sub

    Private Sub FlyMess_Hidden(sender As Object, e As FlyoutPanelEventArgs)
        FlyMess.OwnerControl.FindForm().BringToFront()
    End Sub

    Private Sub FlyMess_ButtonClick(sender As Object, e As FlyoutPanelButtonClickEventArgs) Handles FlyMess.ButtonClick
        Dim tag As String = e.Button.Tag.ToString()
        Select Case tag
            Case "OK"

                FlyMess.HidePopup()
            Case "Cancel"
                ' . . . 
                TryCast(sender, FlyoutPanel).HidePopup()
        End Select
    End Sub
End Class