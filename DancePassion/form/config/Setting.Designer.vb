<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Setting
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.officeNavigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.navMail = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.navSMS = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.barSubItemNavigation = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroupNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.employeesNavigationPage = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.employeesLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.customersNavigationPage = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.customersLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navigationFrame.SuspendLayout()
        Me.employeesNavigationPage.SuspendLayout()
        Me.customersNavigationPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.officeNavigationBar
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem, Me.barSubItemNavigation, Me.BarButtonItem1})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl.MaxItemId = 1
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(922, 191)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'officeNavigationBar
        '
        Me.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.officeNavigationBar.Location = New System.Drawing.Point(0, 704)
        Me.officeNavigationBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.officeNavigationBar.Name = "officeNavigationBar"
        Me.officeNavigationBar.NavigationClient = Me.navBarControl
        Me.officeNavigationBar.Size = New System.Drawing.Size(922, 51)
        Me.officeNavigationBar.TabIndex = 1
        Me.officeNavigationBar.Text = "officeNavigationBar"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.navMail
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navMail, Me.navSMS})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7})
        Me.navBarControl.Location = New System.Drawing.Point(0, 191)
        Me.navBarControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 192
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.navBarControl.Size = New System.Drawing.Size(192, 513)
        Me.navBarControl.TabIndex = 0
        Me.navBarControl.Text = "navBarControl"
        Me.navBarControl.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2016 Colorful")
        '
        'navMail
        '
        Me.navMail.Caption = "Dịch vụ Email"
        Me.navMail.Expanded = True
        Me.navMail.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.navMail.Name = "navMail"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Gmail"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Outlook"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Khác"
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'navSMS
        '
        Me.navSMS.Caption = "Dịch vụ SMS"
        Me.navSMS.Expanded = True
        Me.navSMS.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7)})
        Me.navSMS.Name = "navSMS"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "DCom"
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "Phone"
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "Twilio"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "eSMS.vn"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'barSubItemNavigation
        '
        Me.barSubItemNavigation.Caption = "Navigation"
        Me.barSubItemNavigation.Id = 15
        Me.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar"
        Me.barSubItemNavigation.Name = "barSubItemNavigation"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Dịch vụ email"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'ribbonPage
        '
        Me.ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroupNavigation, Me.ribbonPageGroup})
        Me.ribbonPage.Name = "ribbonPage"
        Me.ribbonPage.Text = "View"
        '
        'ribbonPageGroupNavigation
        '
        Me.ribbonPageGroupNavigation.ItemLinks.Add(Me.barSubItemNavigation)
        Me.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation"
        Me.ribbonPageGroupNavigation.Text = "Module"
        '
        'ribbonPageGroup
        '
        Me.ribbonPageGroup.AllowTextClipping = False
        Me.ribbonPageGroup.ItemLinks.Add(Me.skinRibbonGalleryBarItem)
        Me.ribbonPageGroup.Name = "ribbonPageGroup"
        Me.ribbonPageGroup.ShowCaptionButton = False
        Me.ribbonPageGroup.Text = "Appearance"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 755)
        Me.ribbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(922, 28)
        '
        'navigationFrame
        '
        Me.navigationFrame.Appearance.BackColor = System.Drawing.Color.White
        Me.navigationFrame.Appearance.Options.UseBackColor = True
        Me.navigationFrame.Controls.Add(Me.employeesNavigationPage)
        Me.navigationFrame.Controls.Add(Me.customersNavigationPage)
        Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navigationFrame.Location = New System.Drawing.Point(192, 191)
        Me.navigationFrame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navigationFrame.Name = "navigationFrame"
        Me.navigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.employeesNavigationPage, Me.customersNavigationPage})
        Me.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        Me.navigationFrame.SelectedPage = Me.employeesNavigationPage
        Me.navigationFrame.Size = New System.Drawing.Size(730, 513)
        Me.navigationFrame.TabIndex = 0
        Me.navigationFrame.Text = "navigationFrame"
        '
        'employeesNavigationPage
        '
        Me.employeesNavigationPage.Controls.Add(Me.employeesLabelControl)
        Me.employeesNavigationPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.employeesNavigationPage.Name = "employeesNavigationPage"
        Me.employeesNavigationPage.Size = New System.Drawing.Size(730, 513)
        '
        'employeesLabelControl
        '
        Me.employeesLabelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.25!)
        Me.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.employeesLabelControl.Appearance.Options.UseFont = True
        Me.employeesLabelControl.Appearance.Options.UseForeColor = True
        Me.employeesLabelControl.Appearance.Options.UseTextOptions = True
        Me.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeesLabelControl.Location = New System.Drawing.Point(0, 0)
        Me.employeesLabelControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.employeesLabelControl.Name = "employeesLabelControl"
        Me.employeesLabelControl.Size = New System.Drawing.Size(730, 513)
        Me.employeesLabelControl.TabIndex = 0
        Me.employeesLabelControl.Text = "Employees"
        '
        'customersNavigationPage
        '
        Me.customersNavigationPage.Controls.Add(Me.customersLabelControl)
        Me.customersNavigationPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.customersNavigationPage.Name = "customersNavigationPage"
        Me.customersNavigationPage.Size = New System.Drawing.Size(730, 513)
        '
        'customersLabelControl
        '
        Me.customersLabelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.25!)
        Me.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.customersLabelControl.Appearance.Options.UseFont = True
        Me.customersLabelControl.Appearance.Options.UseForeColor = True
        Me.customersLabelControl.Appearance.Options.UseTextOptions = True
        Me.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customersLabelControl.Location = New System.Drawing.Point(0, 0)
        Me.customersLabelControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.customersLabelControl.Name = "customersLabelControl"
        Me.customersLabelControl.Size = New System.Drawing.Size(730, 513)
        Me.customersLabelControl.TabIndex = 1
        Me.customersLabelControl.Text = "Customers"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "Dịch vụ eMail"
        Me.BarButtonGroup1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonGroup1.Id = 1
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'BarButtonGroup2
        '
        Me.BarButtonGroup2.Caption = "Dịch vụ SMS"
        Me.BarButtonGroup2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonGroup2.Id = 2
        Me.BarButtonGroup2.Name = "BarButtonGroup2"
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 783)
        Me.Controls.Add(Me.navigationFrame)
        Me.Controls.Add(Me.navBarControl)
        Me.Controls.Add(Me.officeNavigationBar)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Setting"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navigationFrame.ResumeLayout(False)
        Me.employeesNavigationPage.ResumeLayout(False)
        Me.customersNavigationPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonPageGroupNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents barSubItemNavigation As DevExpress.XtraBars.BarSubItem
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Private WithEvents officeNavigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Private WithEvents navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents employeesNavigationPage As DevExpress.XtraBars.Navigation.NavigationPage
    Private WithEvents employeesLabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents customersNavigationPage As DevExpress.XtraBars.Navigation.NavigationPage
    Private WithEvents customersLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents navMail As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navSMS As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
