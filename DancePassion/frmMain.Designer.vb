<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.dbKhoiTao = New DevExpress.XtraBars.BarButtonItem()
        Me.dbKetNoi = New DevExpress.XtraBars.BarButtonItem()
        Me.dbLuuTru = New DevExpress.XtraBars.BarButtonItem()
        Me.userGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.user = New DevExpress.XtraBars.BarButtonItem()
        Me.roles = New DevExpress.XtraBars.BarButtonItem()
        Me.gmail = New DevExpress.XtraBars.BarButtonItem()
        Me.outlook = New DevExpress.XtraBars.BarButtonItem()
        Me.smsDCOM = New DevExpress.XtraBars.BarButtonItem()
        Me.smsTwilio = New DevExpress.XtraBars.BarButtonItem()
        Me.eSMS = New DevExpress.XtraBars.BarButtonItem()
        Me.rbpHeThong = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.dbs = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Users = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Emails = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbpSuKien = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbpClub = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbpBanHang = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.AutoSizeItems = True
        Me.RibbonControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ForeColor = System.Drawing.Color.White
        Me.RibbonControl.Image = CType(resources.GetObject("RibbonControl.Image"), System.Drawing.Image)
        Me.RibbonControl.ImageAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.dbKhoiTao, Me.dbKetNoi, Me.dbLuuTru, Me.userGroup, Me.user, Me.roles, Me.gmail, Me.outlook, Me.smsDCOM, Me.smsTwilio, Me.eSMS})
        resources.ApplyResources(Me.RibbonControl, "RibbonControl")
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbpHeThong, Me.rbpSuKien, Me.rbpClub, Me.rbpBanHang})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'dbKhoiTao
        '
        resources.ApplyResources(Me.dbKhoiTao, "dbKhoiTao")
        Me.dbKhoiTao.Id = 5
        Me.dbKhoiTao.ImageOptions.SvgImage = CType(resources.GetObject("dbKhoiTao.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.dbKhoiTao.Name = "dbKhoiTao"
        '
        'dbKetNoi
        '
        resources.ApplyResources(Me.dbKetNoi, "dbKetNoi")
        Me.dbKetNoi.Id = 6
        Me.dbKetNoi.ImageOptions.SvgImage = CType(resources.GetObject("dbKetNoi.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.dbKetNoi.Name = "dbKetNoi"
        '
        'dbLuuTru
        '
        resources.ApplyResources(Me.dbLuuTru, "dbLuuTru")
        Me.dbLuuTru.Id = 7
        Me.dbLuuTru.ImageOptions.SvgImage = CType(resources.GetObject("dbLuuTru.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.dbLuuTru.Name = "dbLuuTru"
        '
        'userGroup
        '
        resources.ApplyResources(Me.userGroup, "userGroup")
        Me.userGroup.Id = 9
        Me.userGroup.ImageOptions.SvgImage = CType(resources.GetObject("userGroup.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.userGroup.Name = "userGroup"
        '
        'user
        '
        resources.ApplyResources(Me.user, "user")
        Me.user.Id = 10
        Me.user.ImageOptions.SvgImage = CType(resources.GetObject("user.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.user.Name = "user"
        '
        'roles
        '
        resources.ApplyResources(Me.roles, "roles")
        Me.roles.Id = 11
        Me.roles.ImageOptions.SvgImage = CType(resources.GetObject("roles.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.roles.Name = "roles"
        '
        'gmail
        '
        resources.ApplyResources(Me.gmail, "gmail")
        Me.gmail.Id = 12
        Me.gmail.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.gmail
        Me.gmail.Name = "gmail"
        '
        'outlook
        '
        resources.ApplyResources(Me.outlook, "outlook")
        Me.outlook.Id = 13
        Me.outlook.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.outlook
        Me.outlook.Name = "outlook"
        '
        'smsDCOM
        '
        resources.ApplyResources(Me.smsDCOM, "smsDCOM")
        Me.smsDCOM.Id = 14
        Me.smsDCOM.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.sms
        Me.smsDCOM.Name = "smsDCOM"
        '
        'smsTwilio
        '
        resources.ApplyResources(Me.smsTwilio, "smsTwilio")
        Me.smsTwilio.Id = 15
        Me.smsTwilio.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.twilio
        Me.smsTwilio.Name = "smsTwilio"
        '
        'eSMS
        '
        resources.ApplyResources(Me.eSMS, "eSMS")
        Me.eSMS.Id = 16
        Me.eSMS.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.eSMS
        Me.eSMS.Name = "eSMS"
        '
        'rbpHeThong
        '
        Me.rbpHeThong.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.dbs, Me.Users, Me.Emails, Me.RibbonPageGroup4})
        Me.rbpHeThong.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.properties
        Me.rbpHeThong.Name = "rbpHeThong"
        resources.ApplyResources(Me.rbpHeThong, "rbpHeThong")
        '
        'dbs
        '
        Me.dbs.ImageOptions.SvgImage = CType(resources.GetObject("dbs.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.dbs.ItemLinks.Add(Me.dbKhoiTao)
        Me.dbs.ItemLinks.Add(Me.dbKetNoi)
        Me.dbs.ItemLinks.Add(Me.dbLuuTru)
        Me.dbs.Name = "dbs"
        Me.dbs.ShowCaptionButton = False
        resources.ApplyResources(Me.dbs, "dbs")
        '
        'Users
        '
        Me.Users.ImageOptions.SvgImage = CType(resources.GetObject("Users.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Users.ItemLinks.Add(Me.userGroup)
        Me.Users.ItemLinks.Add(Me.user)
        Me.Users.ItemLinks.Add(Me.roles)
        Me.Users.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows
        Me.Users.Name = "Users"
        Me.Users.ShowCaptionButton = False
        resources.ApplyResources(Me.Users, "Users")
        '
        'Emails
        '
        Me.Emails.ItemLinks.Add(Me.gmail)
        Me.Emails.ItemLinks.Add(Me.outlook)
        Me.Emails.Name = "Emails"
        Me.Emails.ShowCaptionButton = False
        resources.ApplyResources(Me.Emails, "Emails")
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.smsDCOM)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.smsTwilio)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.eSMS)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        resources.ApplyResources(Me.RibbonPageGroup4, "RibbonPageGroup4")
        '
        'rbpSuKien
        '
        Me.rbpSuKien.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.rbpSuKien.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.differentoddevenpages
        Me.rbpSuKien.Name = "rbpSuKien"
        resources.ApplyResources(Me.rbpSuKien, "rbpSuKien")
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        resources.ApplyResources(Me.RibbonPageGroup2, "RibbonPageGroup2")
        '
        'rbpClub
        '
        Me.rbpClub.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.rbpClub.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.groupbyresource
        Me.rbpClub.Name = "rbpClub"
        resources.ApplyResources(Me.rbpClub, "rbpClub")
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        resources.ApplyResources(Me.RibbonPageGroup3, "RibbonPageGroup3")
        '
        'rbpBanHang
        '
        Me.rbpBanHang.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.rbpBanHang.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.bo_sale
        Me.rbpBanHang.Name = "rbpBanHang"
        resources.ApplyResources(Me.rbpBanHang, "rbpBanHang")
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        resources.ApplyResources(Me.RibbonPageGroup1, "RibbonPageGroup1")
        '
        'RibbonStatusBar
        '
        resources.ApplyResources(Me.RibbonStatusBar, "RibbonStatusBar")
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        '
        'BarButtonItem1
        '
        resources.ApplyResources(Me.BarButtonItem1, "BarButtonItem1")
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dbKhoiTao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dbKetNoi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dbLuuTru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbpBanHang As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbpSuKien As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbpClub As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbpHeThong As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents dbs As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents userGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents user As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents roles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Users As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Emails As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents outlook As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents smsDCOM As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents smsTwilio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eSMS As DevExpress.XtraBars.BarButtonItem
End Class
