<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBase
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Barbtn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.Barbtn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.Barbtn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.RbpChucNang = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RbpGCongCu = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.Barbtn_Add, Me.Barbtn_Update, Me.Barbtn_Delete})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RbpChucNang})
        Me.RibbonControl1.Size = New System.Drawing.Size(1028, 247)
        '
        'Barbtn_Add
        '
        Me.Barbtn_Add.Caption = "Thêm mới"
        Me.Barbtn_Add.Id = 1
        Me.Barbtn_Add.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.addparagraphtotableofcontents
        Me.Barbtn_Add.Name = "Barbtn_Add"
        '
        'Barbtn_Update
        '
        Me.Barbtn_Update.Caption = "Chỉnh sửa"
        Me.Barbtn_Update.Id = 2
        Me.Barbtn_Update.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.updatetableofcontents
        Me.Barbtn_Update.Name = "Barbtn_Update"
        '
        'Barbtn_Delete
        '
        Me.Barbtn_Delete.Caption = "Xóa"
        Me.Barbtn_Delete.Id = 3
        Me.Barbtn_Delete.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.removegroupheader
        Me.Barbtn_Delete.Name = "Barbtn_Delete"
        '
        'RbpChucNang
        '
        Me.RbpChucNang.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RbpGCongCu})
        Me.RbpChucNang.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.showformulas
        Me.RbpChucNang.Name = "RbpChucNang"
        Me.RbpChucNang.Text = "Chức Năng"
        '
        'RbpGCongCu
        '
        Me.RbpGCongCu.AllowTextClipping = False
        Me.RbpGCongCu.ItemLinks.Add(Me.Barbtn_Add)
        Me.RbpGCongCu.ItemLinks.Add(Me.Barbtn_Update)
        Me.RbpGCongCu.ItemLinks.Add(Me.Barbtn_Delete)
        Me.RbpGCongCu.Name = "RbpGCongCu"
        Me.RbpGCongCu.ShowCaptionButton = False
        Me.RbpGCongCu.Text = "Công cụ"
        '
        'FrmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 385)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmBase"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "FrmBase"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RbpChucNang As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RbpGCongCu As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Barbtn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Barbtn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Barbtn_Delete As DevExpress.XtraBars.BarButtonItem
End Class
