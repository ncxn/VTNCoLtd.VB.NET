Imports System.ComponentModel
Imports System.Reflection
Imports System.Threading
Imports System.Xml.Serialization
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient

Public Class FrmMain

    ' Biến toàn cục cho Private Sub, sử dụng kỹ thuật Delegate, Bên dưới gọi Menuhanlder() bất cứ đâu sẽ trỏ đến RoleMenu()
    Public MenuHanlder As New ClsDelegate.RolesMenu(AddressOf RoleMenu)

#Region " Constructor"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Ngôn ngữ tiếng Việt: cách này bùi bắp nhưng hiệu quả
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")

    End Sub

#End Region

#Region " Menu bar"

#End Region

#Region " Form load"
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoleMenu()
    End Sub
#End Region

#Region " Document manager and Tabled events"
    Public ReadOnly Property DM As DocumentManager
        Get
            Return DocumentManager1
        End Get
    End Property
    Public ReadOnly Property View As TabbedView
        Get
            Return TabbedView1
        End Get
    End Property

    Public Sub AddDocs(uc As UserControl, caption As String)
        Dim docs As BaseDocument
        uc.Text = caption
        For Each docs In View.Documents
            If docs.Caption = caption Then
                View.Controller.Activate(docs)
                Return
            End If
        Next
        View.AddDocument(uc)
    End Sub

    Public Sub RemoveDocs()
        ' BeginInvoke(New Action(Sub() Message()))
        View.Controller.Close(View.ActiveDocument)
    End Sub
    Private Sub Message()
        'MessageBox.Show("Đã đóng cử sổ" & " :" & View.ActiveDocument.Caption.ToString())
    End Sub

#End Region

#Region " Merge Ribbon/ Stausbar"
    Private Sub TabbedView1_DocumentActivated(sender As Object, e As DocumentEventArgs) Handles TabbedView1.DocumentActivated
        If Not e.Document.IsFloating Then
            MergeMainRibbon(TryCast(e.Document.Control, UcBase))
        End If
    End Sub
    Private Sub MergeMainRibbon(ByVal child As UcBase)
        If child IsNot Nothing Then
            MainControlRibbon.MergeRibbon(child.BaseRibbon)
        End If
    End Sub

    Private Sub MainControlRibbon_Merge(sender As Object, e As RibbonMergeEventArgs) Handles MainControlRibbon.Merge
        e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages("Chức năng")

        Dim parentRRibbon As RibbonControl = TryCast(sender, RibbonControl)
        Dim childRibbon As RibbonControl = e.MergedChild
        parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar)
    End Sub

    Private Sub MainControlRibbon_UnMerge(sender As Object, e As RibbonMergeEventArgs) Handles MainControlRibbon.UnMerge
        Dim parentRRibbon As RibbonControl = TryCast(sender, RibbonControl)
        Dim childRibbon As RibbonControl = e.MergedChild
        parentRRibbon.StatusBar.UnMergeStatusBar()
    End Sub

#End Region

#Region " BackstageView"

    Private Sub DangNhap_ItemClick(sender As Object, e As BackstageViewItemEventArgs) Handles DangNhap.ItemClick
        FrmUsersLogIn.ShowDialog()
    End Sub

    Private Sub TaiKhoanCaNhan_SelectedChanged(sender As Object, e As BackstageViewItemEventArgs) Handles TaiKhoanCaNhan.SelectedChanged
        Dim ucUser As New UcUserProfiles With {
            .Parent = BackstageViewClientControl1,
            .Dock = DockStyle.Fill
        }
        TaiKhoanCaNhan.ContentControl.Controls.Add(New UcUserProfiles)

    End Sub
#End Region

#Region " Ribbon Button"

#Region " Hệ thống"

#Region " Cấu hình doanh nghiệp"

    Private Sub UcConfig_Basic_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcConfig_Basic.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcConfig_Basic
        AddDocs(uc, "Thiết lập cơ bản")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

#End Region

#Region " Nhân sự"

    Private Sub BtnHumanGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UcRolesManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcRolesManager
        AddDocs(uc, "Nhóm nhân viên")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnHuman_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UcUsersManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcUsersManager
        AddDocs(uc, "Nhân viên")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnRoles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UcRoleManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcRoleManager
        AddDocs(uc, "Phân quyền")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

#End Region

#Region " Phát triển"
    Private Sub BtnControls_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcControlsManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcControlsManager
        AddDocs(uc, "Quản lý Controls")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnFunctions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcAccessManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcAccessManager
        AddDocs(uc, "Quản lý Action")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Private Sub BtnFunctionsOnControl_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcControlsAccessManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcControlsAccessManager
        AddDocs(uc, "Quản lý chức năng")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

#End Region

#Region " Cấu hình"

    Private Sub UcEmailManager_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcEmailManager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcEmailManager
        AddDocs(uc, "Cấu hình email")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

#End Region

#End Region

#Region " Sự kiện"
    Private Sub UcEvent_Type_Manager_ItemClick(sender As Object, e As ItemClickEventArgs) Handles UcEvent_Type_Manager.ItemClick
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Dim uc As New UcEvent_Type_Manager
        AddDocs(uc, "Quản lý loại sự kiện")
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

#End Region

#End Region

#Region " Role manager"
    Private Sub RoleMenu()

        For Each pag As RibbonPage In MainControlRibbon.Pages

            If ClsRoleManager.GetInstance.HasRoleOnMenu(pag.Name.ToString) Then
                pag.Visible = True
            Else
                pag.Visible = False
            End If

            For Each pagGroup As RibbonPageGroup In pag.Groups
                If ClsRoleManager.GetInstance.HasRoleOnMenu(pagGroup.Name.ToString) Then
                    pagGroup.Visible = True
                Else
                    pagGroup.Visible = False
                End If

                For Each itemLink As BarItemLink In pagGroup.ItemLinks

                    If ClsRoleManager.GetInstance.HasRoleOnMenu(itemLink.Item.Name.ToString) Then
                        itemLink.Item.Visibility = BarItemVisibility.Always
                    Else
                        itemLink.Item.Visibility = BarItemVisibility.Never
                    End If
                Next
            Next
        Next
    End Sub

#End Region

End Class
