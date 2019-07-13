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
    Public MenuHanlder As New ClsDelegate.MenuDelegate(AddressOf RoleMenu)

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

#Region " Main form load"
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoleMenu()
    End Sub
#End Region

#Region " Document manager and Tabled events"
    Private ReadOnly Property DM As DocumentManager
        Get
            Return DocumentManager1
        End Get
    End Property
    Private ReadOnly Property View As TabbedView
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

    Public Sub RemoveDocumetns()
        BeginInvoke(New Action(Sub() Message()))
        View.Controller.Close(View.ActiveDocument)
    End Sub
    Private Sub Message()
        'MessageBox.Show("Đã đóng cử sổ" & " :" & View.ActiveDocument.Caption.ToString())
    End Sub

    Private Sub TabbedView1_DocumentActivated(sender As Object, e As DocumentEventArgs) Handles TabbedView1.DocumentActivated
        If Not e.Document.IsFloating Then
            MergeMainRibbon(TryCast(e.Document.Control, UCBase))
        End If
    End Sub

#End Region

#Region " Merge Ribbon/ Stausbar"
    ' Phải set MainControlRibbon.MdiMergeStyle = Always; DocumentManager.RibbonAndBarsMergeStyle = Always
    ' Không được dùng SplashScreenManager trong các user control cấp 2, nếu dùng thì không thể active new docs
    ' -> Do đó merge không có hiệu lực: merge đang thực hiện dựa trên dự kiện activated của documents (éo biết lỗi giề)
    ' -------------------
    ' Mô hình:  1. Documents manager trên main form
    '           2. Một base User Control chứa action (event): New/Edit/Del/Print/Export/View...
    '           3. Một user Control cấp 2 kế thừa từ base : tùy theo chức năng mà enabled/Disabled các action
    '           4. Một user Control cấp 3 cũng kế thừa từ base nhưng được gọi từ user control cấp 2
    '           => tất cả đều gọi trực tiếp trên Documents Manager từ thủ tục AddDocs()
    Private Sub MergeMainRibbon(ByVal child As UCBase)
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
        Dim ucUser As New UserProfiles With {
            .Parent = BackstageViewClientControl1,
            .Dock = DockStyle.Fill
        }
        TaiKhoanCaNhan.ContentControl.Controls.Add(New UserProfiles)

    End Sub
#End Region

#Region " Ribbon Item (Button/Group Pages) "
    Private Sub NhomNhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHumanGroup.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCRoles, "Nhóm nhân viên")
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub NhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHuman.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCUsers, "Nhân viên")
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BtnRoles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoles.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCRoleManager, "Phân quyền")
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BtnControls_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnControls.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCControlsManager, "Quản lý controls")
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BtnFunctions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnFunctions.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UcAccess, "Chức năng trên Form")
        SplashScreenManager.CloseForm()
    End Sub
#End Region

#Region " Role manager"
    Private Sub RoleMenu()

        For Each pag As RibbonPage In MainControlRibbon.Pages
            If ClsRoleManager.GetInstance.HasRole(pag.Name.ToString) Then
                pag.Visible = True
            Else
                pag.Visible = False
            End If

            For Each pagGroup As RibbonPageGroup In pag.Groups
                If ClsRoleManager.GetInstance.HasRole(pagGroup.Name.ToString) Then
                    pagGroup.Visible = True
                Else
                    pagGroup.Visible = False
                End If

                For Each itemLink As BarItemLink In pagGroup.ItemLinks

                    If ClsRoleManager.GetInstance.HasRole(itemLink.Item.Name.ToString) Then
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
