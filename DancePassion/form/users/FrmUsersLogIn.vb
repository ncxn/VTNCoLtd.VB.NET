﻿Public Class FrmUsersLogIn
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmMain.Close()
        Dim f As New frmMain
        Me.Hide()
        f.Show()
    End Sub
End Class