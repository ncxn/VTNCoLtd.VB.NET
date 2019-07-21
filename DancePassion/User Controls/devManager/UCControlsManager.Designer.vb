<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCControlsManager
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
    'UserControl overrides dispose to clean up the component list.
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCControlsManager))
        Me.GrdControls = New DevExpress.XtraGrid.GridControl()
        Me.GrvControls = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StsDesc = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.ItemLinks.Add(Me.StsDesc)
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 612)
        Me.BaseStatusBar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'GrdControls
        '
        Me.GrdControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdControls.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrdControls.Location = New System.Drawing.Point(0, 262)
        Me.GrdControls.MainView = Me.GrvControls
        Me.GrdControls.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrdControls.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdControls.Name = "GrdControls"
        Me.GrdControls.Size = New System.Drawing.Size(930, 350)
        Me.GrdControls.TabIndex = 1
        Me.GrdControls.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvControls})
        '
        'GrvControls
        '
        Me.GrvControls.DetailHeight = 432
        Me.GrvControls.GridControl = Me.GrdControls
        Me.GrvControls.Name = "GrvControls"


        '
        'StsDesc
        '
        Me.StsDesc.Caption = "Chú thích"
        Me.StsDesc.Id = 12
        Me.StsDesc.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.functionscompatibility
        Me.StsDesc.Name = "StsDesc"
        ToolTipTitleItem1.Text = "Hướng dẫn:"
        ToolTipItem1.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.StsDesc.SuperTip = SuperToolTip1
        '
        'UCControlsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdControls)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "UCControlsManager"
        Me.Size = New System.Drawing.Size(930, 649)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdControls, 0)
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdControls As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvControls As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StsDesc As DevExpress.XtraBars.BarStaticItem
End Class
