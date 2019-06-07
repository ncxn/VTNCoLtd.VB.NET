<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBase
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarBtn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.RbpChucNang = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RbpGCongCu = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarBtn_Add, Me.BarBtn_Update, Me.BarBtn_Delete})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RbpChucNang})
        Me.RibbonControl1.Size = New System.Drawing.Size(827, 239)
        '
        'BarBtn_Add
        '
        Me.BarBtn_Add.Caption = "Thêm"
        Me.BarBtn_Add.Id = 1
        Me.BarBtn_Add.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.addparagraphtotableofcontents1
        Me.BarBtn_Add.Name = "BarBtn_Add"
        '
        'BarBtn_Update
        '
        Me.BarBtn_Update.Caption = "Sửa"
        Me.BarBtn_Update.Id = 2
        Me.BarBtn_Update.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.updatetableofcontents1
        Me.BarBtn_Update.Name = "BarBtn_Update"
        '
        'BarBtn_Delete
        '
        Me.BarBtn_Delete.Caption = "Xóa"
        Me.BarBtn_Delete.Id = 3
        Me.BarBtn_Delete.ImageOptions.Image = Global.DancePassion.My.Resources.Resources.deletegroupheader_32x321
        Me.BarBtn_Delete.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.deletetable
        Me.BarBtn_Delete.Name = "BarBtn_Delete"
        '
        'RbpChucNang
        '
        Me.RbpChucNang.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RbpGCongCu})
        Me.RbpChucNang.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.pivottablecalculationsfieldsitemssetsgroup
        Me.RbpChucNang.Name = "RbpChucNang"
        Me.RbpChucNang.Text = "Chức năng"
        '
        'RbpGCongCu
        '
        Me.RbpGCongCu.ItemLinks.Add(Me.BarBtn_Add)
        Me.RbpGCongCu.ItemLinks.Add(Me.BarBtn_Update)
        Me.RbpGCongCu.ItemLinks.Add(Me.BarBtn_Delete)
        Me.RbpGCongCu.Name = "RbpGCongCu"
        Me.RbpGCongCu.Text = "Công cụ"
        '
        'UCBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "UCBase"
        Me.Size = New System.Drawing.Size(827, 332)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RbpChucNang As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RbpGCongCu As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtn_Delete As DevExpress.XtraBars.BarButtonItem
End Class
