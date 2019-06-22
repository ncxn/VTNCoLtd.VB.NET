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
        Me.RibbonControlBaseOnUserControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnOK = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnOkAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RbpChucNang = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RbpGCongCu = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RbpGMoRong = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RbpGXacNhan = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControlBaseOnUserControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControlBaseOnUserControl
        '
        Me.RibbonControlBaseOnUserControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
        Me.RibbonControlBaseOnUserControl.ExpandCollapseItem.Id = 0
        Me.RibbonControlBaseOnUserControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControlBaseOnUserControl.ExpandCollapseItem, Me.BtnAdd, Me.BtnEdit, Me.BtnDelete, Me.BtnOK, Me.BtnCancel, Me.BtnPrint, Me.BtnExcel, Me.BtnEmail, Me.BtnOkAndNew, Me.BtnRefresh})
        Me.RibbonControlBaseOnUserControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControlBaseOnUserControl.MaxItemId = 11
        Me.RibbonControlBaseOnUserControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.RibbonControlBaseOnUserControl.Name = "RibbonControlBaseOnUserControl"
        Me.RibbonControlBaseOnUserControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RbpChucNang})
        Me.RibbonControlBaseOnUserControl.Size = New System.Drawing.Size(827, 239)
        '
        'BtnAdd
        '
        Me.BtnAdd.Caption = "Thêm"
        Me.BtnAdd.Id = 1
        Me.BtnAdd.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.addparagraphtotableofcontents1
        Me.BtnAdd.Name = "BtnAdd"
        '
        'BtnEdit
        '
        Me.BtnEdit.Caption = "Sửa"
        Me.BtnEdit.Id = 2
        Me.BtnEdit.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.editquery
        Me.BtnEdit.Name = "BtnEdit"
        '
        'BtnDelete
        '
        Me.BtnDelete.Caption = "Xóa"
        Me.BtnDelete.Id = 3
        Me.BtnDelete.ImageOptions.Image = Global.DancePassion.My.Resources.Resources.deletegroupheader_32x321
        Me.BtnDelete.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.deletetable
        Me.BtnDelete.Name = "BtnDelete"
        '
        'BtnOK
        '
        Me.BtnOK.Caption = "Chấp nhận"
        Me.BtnOK.Hint = "Chấp nhận và thoát"
        Me.BtnOK.Id = 4
        Me.BtnOK.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.markcomplete
        Me.BtnOK.Name = "BtnOK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Caption = "Bỏ qua"
        Me.BtnCancel.Hint = "Thoát màn hình hiện tại"
        Me.BtnCancel.Id = 5
        Me.BtnCancel.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.delete
        Me.BtnCancel.Name = "BtnCancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.Caption = "Máy In"
        Me.BtnPrint.Id = 6
        Me.BtnPrint.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.printlayoutview
        Me.BtnPrint.Name = "BtnPrint"
        '
        'BtnExcel
        '
        Me.BtnExcel.Caption = "Xuất Excel"
        Me.BtnExcel.Id = 7
        Me.BtnExcel.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.export
        Me.BtnExcel.Name = "BtnExcel"
        '
        'BtnEmail
        '
        Me.BtnEmail.Caption = "Gửi Email"
        Me.BtnEmail.Id = 8
        Me.BtnEmail.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.mailmerge
        Me.BtnEmail.Name = "BtnEmail"
        '
        'BtnOkAndNew
        '
        Me.BtnOkAndNew.Caption = "Tiếp tục"
        Me.BtnOkAndNew.Hint = "Lưu và thêm mới"
        Me.BtnOkAndNew.Id = 9
        Me.BtnOkAndNew.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.actions_add
        Me.BtnOkAndNew.Name = "BtnOkAndNew"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Caption = "Làm mới"
        Me.BtnRefresh.Id = 10
        Me.BtnRefresh.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.resetlayoutoptions
        Me.BtnRefresh.Name = "BtnRefresh"
        '
        'RbpChucNang
        '
        Me.RbpChucNang.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RbpGCongCu, Me.RbpGMoRong, Me.RbpGXacNhan})
        Me.RbpChucNang.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.pivottablecalculationsfieldsitemssetsgroup
        Me.RbpChucNang.Name = "RbpChucNang"
        Me.RbpChucNang.Text = "Chức năng"
        '
        'RbpGCongCu
        '
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnAdd)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnEdit)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnDelete)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnRefresh)
        Me.RbpGCongCu.Name = "RbpGCongCu"
        Me.RbpGCongCu.ShowCaptionButton = False
        Me.RbpGCongCu.Text = "Công cụ"
        '
        'RbpGMoRong
        '
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnPrint)
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnExcel)
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnEmail)
        Me.RbpGMoRong.Name = "RbpGMoRong"
        Me.RbpGMoRong.ShowCaptionButton = False
        Me.RbpGMoRong.Text = "Mở rộng"
        '
        'RbpGXacNhan
        '
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnOK)
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnOkAndNew)
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnCancel)
        Me.RbpGXacNhan.Name = "RbpGXacNhan"
        Me.RbpGXacNhan.ShowCaptionButton = False
        Me.RbpGXacNhan.Text = "Xác nhận"
        '
        'UCBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonControlBaseOnUserControl)
        Me.Name = "UCBase"
        Me.Size = New System.Drawing.Size(827, 238)
        CType(Me.RibbonControlBaseOnUserControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControlBaseOnUserControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RbpChucNang As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RbpGCongCu As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGXacNhan As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGMoRong As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOkAndNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRefresh As DevExpress.XtraBars.BarButtonItem
End Class
