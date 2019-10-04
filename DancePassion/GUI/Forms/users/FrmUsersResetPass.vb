Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports VTNcoLtd.BUS
Imports VTNcoLtd.Helper
Imports VTNcoLtd.Model

Public Class FrmUsersResetPass
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region " Xử lý dữ liêu"

    Private Function CheckMatchActiveCode() As Boolean
        Return ClsUsersConfirm.GetInstance.GetActiveCode(TxtUserNameOrEmail.Text, TxtActiveCode.Text)
    End Function

    Private Function GenPassWord() As String
        Return Security.RandomPassWord(8)
    End Function

    Private Sub UpdateActiveCodeStatus()
        ClsUsersConfirm.GetInstance.Update(TxtUserNameOrEmail.Text, TxtActiveCode.Text)
    End Sub

    Private Sub UpdateDB()

        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)

        If CheckMatchActiveCode() Then

            Dim NewPassWord As String = GenPassWord()

            If ClsUsers.GetInstance.UpdatePassWordByUserName(TxtUserNameOrEmail.Text, NewPassWord) Then
                ' Get email of user
                Dim objUser As Users = ClsUsers.GetInstance.GetUserByUserName(TxtUserNameOrEmail.Text)
                ' Send mail or print password (NewPassWord) for user
                SendMail.GetInstance.Send(objUser.User_email, NewPassWord)

                ' Update Status Code to 1 (disabled reset pass by this code)
                UpdateActiveCodeStatus()

                ' Debug.WriteLine(NewPassWord)
            Else
                XtraMessageBox.Show("Không thể cập nhật mật khẩu mới, thử lại sau!", "Thông báo", MessageBoxButtons.OK)
            End If
        Else
            XtraMessageBox.Show("Thông tin không chính xác", "Thông báo", MessageBoxButtons.OK)
        End If

        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnGetPassWord_Click(sender As Object, e As EventArgs) Handles BtnGetPassWord.Click
        UpdateDB()
    End Sub

#End Region

End Class