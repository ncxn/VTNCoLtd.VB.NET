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
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.ItemLinks.Add(Me.BarStaticItem3)
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 485)
        '
        'GrdControls
        '
        Me.GrdControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdControls.Location = New System.Drawing.Point(0, 239)
        Me.GrdControls.MainView = Me.GrvControls
        Me.GrdControls.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdControls.Name = "GrdControls"
        Me.GrdControls.Size = New System.Drawing.Size(827, 246)
        Me.GrdControls.TabIndex = 1
        Me.GrdControls.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvControls})
        '
        'GrvControls
        '
        Me.GrvControls.GridControl = Me.GrdControls
        Me.GrvControls.Name = "GrvControls"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "kaka"
        Me.BarStaticItem1.Id = 13
        Me.BarStaticItem1.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.about
        Me.BarStaticItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace
        Me.BarStaticItem1.Name = "BarStaticItem1"
        ToolTipTitleItem2.Text = "Các chức năng lưu ý"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "1. Nhấn Insert để thêm dòng mới" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Nhấn Delete để xóa dòng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Khi xong các thao" &
    " tác cần nhấn Chấp nhận để lưu vào cơ sở dữ liệu"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.BarStaticItem1.SuperTip = SuperToolTip2
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Hướng dẫn"
        Me.BarStaticItem2.Id = 12
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Chú thích"
        Me.BarStaticItem3.Id = 12
        Me.BarStaticItem3.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.functionscompatibility
        Me.BarStaticItem3.Name = "BarStaticItem3"
        ToolTipTitleItem1.Text = "Hướng dẫn:"
        ToolTipItem1.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.BarStaticItem3.SuperTip = SuperToolTip1
        '
        'UCControlsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdControls)
        Me.Name = "UCControlsManager"
        Me.Size = New System.Drawing.Size(827, 525)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdControls, 0)
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdControls As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvControls As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
End Class
