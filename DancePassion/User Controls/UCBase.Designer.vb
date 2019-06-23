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
        Me.BtnCREATE = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEDIT = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDELETE = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnOK = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCANCEL = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPRINT = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEXCEL = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEMAIL = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnOKANDNEW = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnREFRESH = New DevExpress.XtraBars.BarButtonItem()
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
        Me.RibbonControlBaseOnUserControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControlBaseOnUserControl.ExpandCollapseItem, Me.BtnCREATE, Me.BtnEDIT, Me.BtnDELETE, Me.BtnOK, Me.BtnCANCEL, Me.BtnPRINT, Me.BtnEXCEL, Me.BtnEMAIL, Me.BtnOKANDNEW, Me.BtnREFRESH})
        Me.RibbonControlBaseOnUserControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControlBaseOnUserControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControlBaseOnUserControl.MaxItemId = 11
        Me.RibbonControlBaseOnUserControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.RibbonControlBaseOnUserControl.Name = "RibbonControlBaseOnUserControl"
        Me.RibbonControlBaseOnUserControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RbpChucNang})
        Me.RibbonControlBaseOnUserControl.Size = New System.Drawing.Size(930, 262)
        '
        'BtnCREATE
        '
        Me.BtnCREATE.Caption = "Thêm"
        Me.BtnCREATE.Id = 1
        Me.BtnCREATE.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.addparagraphtotableofcontents1
        Me.BtnCREATE.Name = "BtnCREATE"
        '
        'BtnEDIT
        '
        Me.BtnEDIT.Caption = "Sửa"
        Me.BtnEDIT.Id = 2
        Me.BtnEDIT.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.editquery
        Me.BtnEDIT.Name = "BtnEDIT"
        '
        'BtnDELETE
        '
        Me.BtnDELETE.Caption = "Xóa"
        Me.BtnDELETE.Id = 3
        Me.BtnDELETE.ImageOptions.Image = Global.DancePassion.My.Resources.Resources.deletegroupheader_32x321
        Me.BtnDELETE.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.deletetable
        Me.BtnDELETE.Name = "BtnDELETE"
        '
        'BtnOK
        '
        Me.BtnOK.Caption = "Chấp nhận"
        Me.BtnOK.Hint = "Chấp nhận và thoát"
        Me.BtnOK.Id = 4
        Me.BtnOK.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.markcomplete
        Me.BtnOK.Name = "BtnOK"
        '
        'BtnCANCEL
        '
        Me.BtnCANCEL.Caption = "Bỏ qua"
        Me.BtnCANCEL.Hint = "Thoát màn hình hiện tại"
        Me.BtnCANCEL.Id = 5
        Me.BtnCANCEL.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.delete
        Me.BtnCANCEL.Name = "BtnCANCEL"
        '
        'BtnPRINT
        '
        Me.BtnPRINT.Caption = "Máy In"
        Me.BtnPRINT.Id = 6
        Me.BtnPRINT.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.printlayoutview
        Me.BtnPRINT.Name = "BtnPRINT"
        '
        'BtnEXCEL
        '
        Me.BtnEXCEL.Caption = "Xuất Excel"
        Me.BtnEXCEL.Id = 7
        Me.BtnEXCEL.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.export
        Me.BtnEXCEL.Name = "BtnEXCEL"
        '
        'BtnEMAIL
        '
        Me.BtnEMAIL.Caption = "Gửi Email"
        Me.BtnEMAIL.Id = 8
        Me.BtnEMAIL.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.mailmerge
        Me.BtnEMAIL.Name = "BtnEMAIL"
        '
        'BtnOKANDNEW
        '
        Me.BtnOKANDNEW.Caption = "Tiếp tục"
        Me.BtnOKANDNEW.Hint = "Lưu và thêm mới"
        Me.BtnOKANDNEW.Id = 9
        Me.BtnOKANDNEW.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.actions_add
        Me.BtnOKANDNEW.Name = "BtnOKANDNEW"
        '
        'BtnREFRESH
        '
        Me.BtnREFRESH.Caption = "Làm mới"
        Me.BtnREFRESH.Id = 10
        Me.BtnREFRESH.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.resetlayoutoptions
        Me.BtnREFRESH.Name = "BtnREFRESH"
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
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnCREATE)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnEDIT)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnDELETE)
        Me.RbpGCongCu.ItemLinks.Add(Me.BtnREFRESH)
        Me.RbpGCongCu.Name = "RbpGCongCu"
        Me.RbpGCongCu.ShowCaptionButton = False
        Me.RbpGCongCu.Text = "Công cụ"
        '
        'RbpGMoRong
        '
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnPRINT)
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnEXCEL)
        Me.RbpGMoRong.ItemLinks.Add(Me.BtnEMAIL)
        Me.RbpGMoRong.Name = "RbpGMoRong"
        Me.RbpGMoRong.ShowCaptionButton = False
        Me.RbpGMoRong.Text = "Mở rộng"
        '
        'RbpGXacNhan
        '
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnOK)
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnOKANDNEW)
        Me.RbpGXacNhan.ItemLinks.Add(Me.BtnCANCEL)
        Me.RbpGXacNhan.Name = "RbpGXacNhan"
        Me.RbpGXacNhan.ShowCaptionButton = False
        Me.RbpGXacNhan.Text = "Xác nhận"
        '
        'UCBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonControlBaseOnUserControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UCBase"
        Me.Size = New System.Drawing.Size(930, 294)
        CType(Me.RibbonControlBaseOnUserControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControlBaseOnUserControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RbpChucNang As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RbpGCongCu As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCREATE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEDIT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDELETE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGXacNhan As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCANCEL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGMoRong As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnPRINT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEXCEL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEMAIL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOKANDNEW As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnREFRESH As DevExpress.XtraBars.BarButtonItem
End Class
