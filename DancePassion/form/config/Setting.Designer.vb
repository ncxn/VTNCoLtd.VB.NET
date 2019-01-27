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

#Region "Component Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.barSubItemNavigation = New DevExpress.XtraBars.BarSubItem()
        Me.infoBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.emailBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.smsBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroupNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.dockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanel_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.accordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.mainAccordionGroup = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.infoAccordionControlElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MailsAccordionControlElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.smsAccordionControlElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanel.SuspendLayout()
        Me.dockPanel_Container.SuspendLayout()
        CType(Me.accordionControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem, Me.barSubItemNavigation, Me.infoBarButtonItem, Me.emailBarButtonItem, Me.smsBarButtonItem})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ribbonControl.MaxItemId = 1
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(1125, 274)
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'barSubItemNavigation
        '
        Me.barSubItemNavigation.Caption = "Danh mục"
        Me.barSubItemNavigation.Id = 15
        Me.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar"
        Me.barSubItemNavigation.ImageOptions.SvgImage = CType(resources.GetObject("barSubItemNavigation.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.barSubItemNavigation.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.infoBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.emailBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.smsBarButtonItem)})
        Me.barSubItemNavigation.Name = "barSubItemNavigation"
        Me.barSubItemNavigation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'infoBarButtonItem
        '
        Me.infoBarButtonItem.Caption = "Doanh nghiệp"
        Me.infoBarButtonItem.Id = 46
        Me.infoBarButtonItem.Name = "infoBarButtonItem"
        '
        'emailBarButtonItem
        '
        Me.emailBarButtonItem.Caption = "Cấu hình Email"
        Me.emailBarButtonItem.Id = 47
        Me.emailBarButtonItem.Name = "emailBarButtonItem"
        '
        'smsBarButtonItem
        '
        Me.smsBarButtonItem.Caption = "Cấu hình SMS"
        Me.smsBarButtonItem.Id = 48
        Me.smsBarButtonItem.Name = "smsBarButtonItem"
        '
        'ribbonPage
        '
        Me.ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroupNavigation, Me.ribbonPageGroup})
        Me.ribbonPage.Name = "ribbonPage"
        Me.ribbonPage.Text = "View"
        '
        'ribbonPageGroupNavigation
        '
        Me.ribbonPageGroupNavigation.AllowTextClipping = False
        Me.ribbonPageGroupNavigation.ItemLinks.Add(Me.barSubItemNavigation)
        Me.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation"
        Me.ribbonPageGroupNavigation.Text = "Chức năng"
        '
        'ribbonPageGroup
        '
        Me.ribbonPageGroup.AllowTextClipping = False
        Me.ribbonPageGroup.ItemLinks.Add(Me.skinRibbonGalleryBarItem)
        Me.ribbonPageGroup.Name = "ribbonPageGroup"
        Me.ribbonPageGroup.ShowCaptionButton = False
        Me.ribbonPageGroup.Text = "Chọn Skin"
        '
        'dockManager
        '
        Me.dockManager.Form = Me
        Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel})
        Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'dockPanel
        '
        Me.dockPanel.BackgroundImage = Global.DancePassion.My.Resources.Resources.Data_setting_WF
        Me.dockPanel.Controls.Add(Me.dockPanel_Container)
        Me.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanel.ID = New System.Guid("a045df26-1503-4d9a-99c1-a531310af22b")
        Me.dockPanel.ImageOptions.Image = CType(resources.GetObject("dockPanel.ImageOptions.Image"), System.Drawing.Image)
        Me.dockPanel.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.dockPanel.Location = New System.Drawing.Point(0, 274)
        Me.dockPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dockPanel.Name = "dockPanel"
        Me.dockPanel.Options.ShowCloseButton = False
        Me.dockPanel.Options.ShowMaximizeButton = False
        Me.dockPanel.OriginalSize = New System.Drawing.Size(283, 200)
        Me.dockPanel.Size = New System.Drawing.Size(283, 780)
        Me.dockPanel.Text = "Mục lục"
        '
        'dockPanel_Container
        '
        Me.dockPanel_Container.Controls.Add(Me.accordionControl)
        Me.dockPanel_Container.Location = New System.Drawing.Point(4, 38)
        Me.dockPanel_Container.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dockPanel_Container.Name = "dockPanel_Container"
        Me.dockPanel_Container.Size = New System.Drawing.Size(268, 740)
        Me.dockPanel_Container.TabIndex = 0
        '
        'accordionControl
        '
        Me.accordionControl.AllowItemSelection = True
        Me.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.accordionControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.mainAccordionGroup})
        Me.accordionControl.Location = New System.Drawing.Point(0, 0)
        Me.accordionControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.accordionControl.Name = "accordionControl"
        Me.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.[Auto]
        Me.accordionControl.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.[Auto]
        Me.accordionControl.Size = New System.Drawing.Size(268, 740)
        Me.accordionControl.TabIndex = 0
        Me.accordionControl.Text = "accordionControl"
        Me.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'mainAccordionGroup
        '
        Me.mainAccordionGroup.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.infoAccordionControlElement, Me.MailsAccordionControlElement, Me.smsAccordionControlElement})
        Me.mainAccordionGroup.Expanded = True
        Me.mainAccordionGroup.HeaderVisible = False
        Me.mainAccordionGroup.Name = "mainAccordionGroup"
        Me.mainAccordionGroup.Text = "mainGroup"
        '
        'infoAccordionControlElement
        '
        Me.infoAccordionControlElement.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.infoAccordionControlElement.ImageOptions.Image = CType(resources.GetObject("infoAccordionControlElement.ImageOptions.Image"), System.Drawing.Image)
        Me.infoAccordionControlElement.Name = "infoAccordionControlElement"
        Me.infoAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.infoAccordionControlElement.Text = "Thông tin doanh nghiệp"
        '
        'MailsAccordionControlElement
        '
        Me.MailsAccordionControlElement.ImageOptions.Image = CType(resources.GetObject("MailsAccordionControlElement.ImageOptions.Image"), System.Drawing.Image)
        Me.MailsAccordionControlElement.Name = "MailsAccordionControlElement"
        Me.MailsAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.MailsAccordionControlElement.Text = "Cấu hình Email"
        '
        'smsAccordionControlElement
        '
        Me.smsAccordionControlElement.Expanded = True
        Me.smsAccordionControlElement.ImageOptions.Image = CType(resources.GetObject("smsAccordionControlElement.ImageOptions.Image"), System.Drawing.Image)
        Me.smsAccordionControlElement.Name = "smsAccordionControlElement"
        Me.smsAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.smsAccordionControlElement.Text = "Cấu hình SMS"
        '
        'tabbedView
        '
        '
        'documentManager
        '
        Me.documentManager.MdiParent = Me
        Me.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        Me.documentManager.View = Me.tabbedView
        Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
        '
        'Setting
        '
        Me.Appearance.Image = CType(resources.GetObject("Setting.Appearance.Image"), System.Drawing.Image)
        Me.Appearance.Options.UseImage = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 1054)
        Me.Controls.Add(Me.dockPanel)
        Me.Controls.Add(Me.ribbonControl)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Setting"
        Me.Ribbon = Me.ribbonControl
        Me.Text = "Hệ thống"
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanel.ResumeLayout(False)
        Me.dockPanel_Container.ResumeLayout(False)
        CType(Me.accordionControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Private WithEvents dockManager As DevExpress.XtraBars.Docking.DockManager
    Private WithEvents dockPanel As DevExpress.XtraBars.Docking.DockPanel
    Private WithEvents dockPanel_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private WithEvents accordionControl As DevExpress.XtraBars.Navigation.AccordionControl
    Private WithEvents ribbonPageGroupNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents infoBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents emailBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barSubItemNavigation As DevExpress.XtraBars.BarSubItem
    Private WithEvents smsAccordionControlElement As DevExpress.XtraBars.Navigation.AccordionControlElement
    Private WithEvents infoAccordionControlElement As DevExpress.XtraBars.Navigation.AccordionControlElement
    Private WithEvents mainAccordionGroup As DevExpress.XtraBars.Navigation.AccordionControlElement
    Private WithEvents tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private WithEvents documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents MailsAccordionControlElement As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents smsBarButtonItem As DevExpress.XtraBars.BarButtonItem
End Class
