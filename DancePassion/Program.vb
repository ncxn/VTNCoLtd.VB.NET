Public Class Program

    ' Check connect to database
    Function ExitsDatabase() As Boolean
        Return True
    End Function

    ' Check exits user
    Function CheckUser() As Boolean
        Return True
    End Function

    Sub RunPro()
        If CheckUser() Then
            FrmMain.Show()
        Else
            FrmUsersLogIn.ShowDialog()
        End If
    End Sub
End Class
