Imports DevExpress.XtraSplashScreen
Imports System.Runtime.InteropServices
Imports VTNcoLtd.BUS
Imports VTNcoLtd.Model

Public Class FrmUsersLogIn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region " Tính năng mở rộng"

    ' Dùng để tạo header form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr)
    End Sub

    Const WM_SYSCOMMAND As Integer = &H112
    Dim SC_ARRASTRAR As IntPtr = CType(&HF012, IntPtr)

    Private Sub PnDetail_MouseDown(sender As Object, e As MouseEventArgs) Handles PnDetail.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_ARRASTRAR, IntPtr.Zero)
    End Sub
#End Region

#Region " Forms"

    Private Sub FrmUsersLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblTitle.Select()
    End Sub


    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Login()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

#End Region

#Region " Xử lý dữ liệu"

    Private Sub Login()
        Dim status As User_status = User_status.NotExists
        Dim sMessage As String = String.Empty

        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)

        Dim objUser As Users = ClsUsers.GetInstance.Login(TxtUserName.Text.Trim(), TxtPassWord.Text.Trim(), status)

        Select Case status
            Case User_status.NotExists
                sMessage = "Không có người dùng này"
                SplashScreenManager.CloseOverlayForm(handle)

            Case User_status.WrongPass
                sMessage = "Không đúng mật khẩu"
                SplashScreenManager.CloseOverlayForm(handle)

            Case User_status.Locked
                sMessage = "Người dùng này đã bị khóa"
                SplashScreenManager.CloseOverlayForm(handle)

            Case User_status.Active
                CurrentUser.User = objUser
                ' Lấy roles hiện tại của user (multi)
                CurrentUserRole.RolesByUserName = ClsUserRole.GetInstance.GetRolesByUserName(CurrentUser.User.User_name)
                ' Lấy quyền hạn của user hiện tại thông qua roles (multi)
                CurrentRolesControlsAccess.RolesControlsAccess = ClsRoleManager.GetInstance.GetControlsAccessByUserName(CurrentUser.User.User_name)
                ' Lấy tập hợp các chức năng trên form
                CurrentControlAccess.ControlAccessCollection = ClsControlAccess.GetInstance.GetList()

                SplashScreenManager.CloseOverlayForm(handle)
                Loading.Show()
                Me.Close()
        End Select

        If sMessage IsNot String.Empty Then
            MessageBox.Show(sMessage)
        End If

    End Sub

    Private Sub TxtUserName_Enter(sender As Object, e As EventArgs) Handles TxtUserName.Enter
        If TxtUserName.Text = "Tên đăng nhập" Then
            TxtUserName.Text = ""
            TxtUserName.ForeColor = Color.White
            LineUserName.BorderColor = Color.CadetBlue
        End If
    End Sub

    Private Sub TxtUserName_MouseHover(sender As Object, e As EventArgs) Handles TxtUserName.MouseHover
        LineUserName.BorderColor = Color.CadetBlue
    End Sub

    Private Sub TxtUserName_Leave(sender As Object, e As EventArgs) Handles TxtUserName.Leave
        If TxtUserName.Text = "" Then
            TxtUserName.Text = "Tên đăng nhập"
            TxtUserName.ForeColor = Color.Silver
            LineUserName.BorderColor = Color.LightGray
        End If
    End Sub

    Private Sub TxtUserName_MouseLeave(sender As Object, e As EventArgs) Handles TxtUserName.MouseLeave
        LineUserName.BorderColor = Color.LightGray
    End Sub

    Private Sub TxtPassWord_Leave(sender As Object, e As EventArgs) Handles TxtPassWord.Leave
        If TxtPassWord.Text = "" Then
            TxtPassWord.Text = "Mật khẩu"
            TxtPassWord.ForeColor = Color.Silver
            TxtPassWord.Properties.UseSystemPasswordChar = False
            LinePw.BorderColor = Color.LightGray
        End If

    End Sub

    Private Sub TxtPassWord_Enter(sender As Object, e As EventArgs) Handles TxtPassWord.Enter
        If TxtPassWord.Text = "Mật khẩu" Then
            TxtPassWord.Text = ""
            TxtPassWord.ForeColor = Color.LightGray
            TxtPassWord.Properties.UseSystemPasswordChar = True
            LinePw.BorderColor = Color.CadetBlue
        End If
    End Sub

    Private Sub FrmUsersLogIn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub LinkLostPass_Click(sender As Object, e As EventArgs) Handles LinkLostPass.Click
        FrmUsersGetActiveCode.ShowDialog()
    End Sub




#End Region

End Class