Imports DevExpress.XtraEditors

Public Class FrmUsersResetPass
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region " Xử lý dữ liêu"
    Private Function CheckMatchActiveCode() As Boolean
        If ClsUsersConfirm.GetInstance.GetActiveCode(TxtUserNameOrEmail.Text, TxtActiveCode.Text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function GenPassWord() As String
        Return Security.RandomPassWord(8)
    End Function

    Private Sub UpdateActiveCodeStatus()
        If ClsUsersConfirm.GetInstance.Update(TxtUserNameOrEmail.Text, TxtActiveCode.Text) Then
        End If
    End Sub

    Private Sub UpdateDB()
        If CheckMatchActiveCode() Then
            Dim NewPassWord As String = GenPassWord()
            If ClsUsers.GetInstance.UpdatePassWordByUserName(TxtUserNameOrEmail.Text, NewPassWord) Then
                ' Send mail or print password (NewPassWord) for user
                ' Update Status Code to 1 (disabled reset pass by this code)
                UpdateActiveCodeStatus()
                Debug.WriteLine(NewPassWord)
            Else
                XtraMessageBox.Show("Không thể cập nhật mật khẩu mới, thử lại sau!", "Thông báo", MessageBoxButtons.OK)
            End If
        Else
            XtraMessageBox.Show("Thông tin không chính xác", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BtnGetPassWord_Click(sender As Object, e As EventArgs) Handles BtnGetPassWord.Click
        UpdateDB()
    End Sub

#End Region
End Class