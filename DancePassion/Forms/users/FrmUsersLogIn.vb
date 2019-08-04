Imports DevExpress.XtraSplashScreen
Imports System.Runtime.InteropServices
Public Class FrmUsersLogIn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region " Tính năng mở rộng"


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


        Dim objUser As UsersDTO = ClsUsers.GetInstance.Login(txtUserName.Text.Trim(), txtPassWord.Text.Trim(), status)

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
                CurrentUserRoles.RolesByUserName = ClsUserRoles.GetInstance.GetRolesByCurrentUserName()
                ' Lấy quyền hạn của user hiện tại thông qua roles (multi)
                CurrentRolesControlsAccess.RolesControlsAccess = ClsRoleManager.GetInstance.GetControlsAccessByUserName(CurrentUser.User.User_name)
                ' Lấy tập hợp các chức năng trên form
                CurrentControlsAccess.ControlsAccessColection = ClsControlsAccess.GetInstance.GetList()
                SplashScreenManager.CloseOverlayForm(handle)
                Loading.Show()
                Me.Close()
        End Select
        If sMessage IsNot String.Empty Then
            MessageBox.Show(sMessage)
        End If
    End Sub

    Private Sub TxtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
        If txtUserName.Text = "Tên đăng nhập" Then
            txtUserName.Text = ""
            txtUserName.ForeColor = Color.White
            LineUserName.BorderColor = Color.CadetBlue
        End If
    End Sub

    Private Sub TxtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        If txtUserName.Text = "" Then
            txtUserName.Text = "Tên đăng nhập"
            txtUserName.ForeColor = Color.Silver
            LineUserName.BorderColor = Color.LightGray
        End If
    End Sub

    Private Sub TxtPassWord_Leave(sender As Object, e As EventArgs) Handles txtPassWord.Leave
        If txtPassWord.Text = "" Then
            txtPassWord.Text = "Mật khẩu"
            txtPassWord.ForeColor = Color.Silver
            txtPassWord.Properties.UseSystemPasswordChar = False
            LinePw.BorderColor = Color.LightGray
        End If

    End Sub

    Private Sub TxtPassWord_Enter(sender As Object, e As EventArgs) Handles txtPassWord.Enter
        If txtPassWord.Text = "Mật khẩu" Then
            txtPassWord.Text = ""
            txtPassWord.ForeColor = Color.LightGray
            txtPassWord.Properties.UseSystemPasswordChar = True
            LinePw.BorderColor = Color.CadetBlue
        End If
    End Sub

#End Region

End Class