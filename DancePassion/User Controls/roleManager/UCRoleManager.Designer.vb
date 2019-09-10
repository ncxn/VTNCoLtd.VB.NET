<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRoleManager
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UcBase
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcRoleManager))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.TrlControls = New DevExpress.XtraTreeList.TreeList()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ChLAccessControl = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.SearchRoles = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.RolesView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.TrlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ChLAccessControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchRoles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.ItemLinks.Add(Me.BarStaticItem1)
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 492)
        '
        'TrlControls
        '
        Me.TrlControls.Appearance.Caption.Image = CType(resources.GetObject("TrlControls.Appearance.Caption.Image"), System.Drawing.Image)
        Me.TrlControls.Appearance.Caption.Options.UseImage = True
        Me.TrlControls.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TrlControls.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TrlControls.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TrlControls.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TrlControls.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TrlControls.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TrlControls.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TrlControls.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TrlControls.KeyFieldName = ""
        Me.TrlControls.Location = New System.Drawing.Point(11, 66)
        Me.TrlControls.MinWidth = 17
        Me.TrlControls.Name = "TrlControls"
        Me.TrlControls.OptionsView.AllowGlyphSkinning = True
        Me.TrlControls.OptionsView.AllowHtmlDrawHeaders = True
        Me.TrlControls.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFullFocus
        Me.TrlControls.OptionsView.ShowHierarchyIndentationLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.TrlControls.OptionsView.ShowHorzLines = False
        Me.TrlControls.OptionsView.ShowIndicator = False
        Me.TrlControls.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.TrlControls.OptionsView.ShowVertLines = False
        Me.TrlControls.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark
        Me.TrlControls.ParentFieldName = ""
        Me.TrlControls.Size = New System.Drawing.Size(420, 175)
        Me.TrlControls.TabIndex = 2
        Me.TrlControls.TreeLevelWidth = 16
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChLAccessControl)
        Me.LayoutControl1.Controls.Add(Me.SearchRoles)
        Me.LayoutControl1.Controls.Add(Me.TrlControls)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(683, 106, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(724, 253)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ChLAccessControl
        '
        Me.ChLAccessControl.CheckOnClick = True
        Me.ChLAccessControl.Location = New System.Drawing.Point(466, 103)
        Me.ChLAccessControl.MultiColumn = True
        Me.ChLAccessControl.Name = "ChLAccessControl"
        Me.ChLAccessControl.PictureChecked = CType(resources.GetObject("ChLAccessControl.PictureChecked"), System.Drawing.Image)
        Me.ChLAccessControl.PictureUnchecked = CType(resources.GetObject("ChLAccessControl.PictureUnchecked"), System.Drawing.Image)
        Me.ChLAccessControl.Size = New System.Drawing.Size(224, 138)
        Me.ChLAccessControl.StyleController = Me.LayoutControl1
        Me.ChLAccessControl.TabIndex = 3
        '
        'SearchRoles
        '
        Me.SearchRoles.Location = New System.Drawing.Point(140, 12)
        Me.SearchRoles.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.SearchRoles.Name = "SearchRoles"
        Me.SearchRoles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchRoles.Properties.NullText = "Chọn nhóm nhân viên"
        Me.SearchRoles.Properties.NullValuePrompt = "Chưa chọn nhóm nhân viên"
        Me.SearchRoles.Properties.NullValuePromptShowForEmptyValue = True
        Me.SearchRoles.Properties.PopupView = Me.RolesView
        Me.SearchRoles.Properties.ShowNullValuePromptWhenFocused = True
        Me.SearchRoles.Size = New System.Drawing.Size(291, 40)
        Me.SearchRoles.StyleController = Me.LayoutControl1
        Me.SearchRoles.TabIndex = 1
        '
        'RolesView
        '
        Me.RolesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RolesView.Name = "RolesView"
        Me.RolesView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RolesView.OptionsView.ShowGroupPanel = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.SimpleLabelItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(724, 253)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TrlControls
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(424, 179)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchRoles
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(424, 44)
        Me.LayoutControlItem2.Text = "Chọn nhóm nhân viên"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(126, 17)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 44)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(706, 10)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(424, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(282, 44)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(683, 54)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(23, 179)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(424, 54)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(31, 179)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ChLAccessControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(455, 91)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(228, 142)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(455, 54)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(228, 37)
        Me.SimpleLabelItem1.Text = "Cấp quyền"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(126, 17)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Ghi chú"
        Me.BarStaticItem1.Id = 12
        Me.BarStaticItem1.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.warning
        Me.BarStaticItem1.Name = "BarStaticItem1"
        ToolTipTitleItem1.Text = "Về phân quyền"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "1. Chọn nhóm nhân viên" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Chọn chức năng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Chọn cấp quyền"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.BarStaticItem1.SuperTip = SuperToolTip1
        '
        'UcRoleManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcRoleManager"
        Me.Size = New System.Drawing.Size(724, 532)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.TrlControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ChLAccessControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchRoles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrlControls As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents SearchRoles As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents RolesView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ChLAccessControl As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
End Class
