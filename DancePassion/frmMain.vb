Imports System.Threading
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient

Public Class FrmMain
#Region " Constructor"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Ngôn ngữ tiếng Việt: cách này bùi bắp nhưng hiệu quả
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")

    End Sub
#End Region

#Region " Main form"

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

#Region " Merge Ribbon"
    ' Phải set MainControlRibbon.MdiMergeStyle = Always; DocumentManager.RibbonAndBarsMergeStyle = Always
    ' Không được dùng SplashScreenManager trong các user control cấp 2, nếu dùng thì không thể active new docs
    ' -> Do đó merge không có hiệu lực: merge đang thực hiện dựa trên dự kiện activated của documents
    ' -------------------
    ' Mô hình:  1. Documents manager trên main form
    '           2. Một base User Control chứa action (event): New/Edit/Del/Print/Export/View...
    '           3. Một user Control cấp 2 kế thừa từ base : tuy theo chức năng mà enabled/Disabled các action trên
    '           4. Một user Control cấp 3 cũng kế thừa từ base nhưng được gọi từ user control cấp 2
    '           => tất cả đều gọi trực tiếp trên Documents Manager từ thủ tục AddDocs()
    Private Sub MergeMainRibbon(ByVal child As UCBase)
        If child IsNot Nothing Then
            MainControlRibbon.MergeRibbon(child.Ribbon)
        End If
    End Sub

    Private Sub MainControlRibbon_Merge(sender As Object, e As RibbonMergeEventArgs) Handles MainControlRibbon.Merge
        e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages("Chức năng")
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
    Private Sub NhomNhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NhomNhanVien_NhanVien_btn.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCRoles, "Nhóm nhân viên")
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub NhanVien_NhanVien_btn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NhanVien_NhanVien_btn.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        AddDocs(New UCUsers, "Nhân viên")
        SplashScreenManager.CloseForm()
    End Sub



#End Region

End Class
