<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcBase
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
        Me.RbpFunction = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RbpGTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RbpGExtend = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RbpGConfirm = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BaseStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.RibbonControlBaseOnUserControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControlBaseOnUserControl
        '
        Me.RibbonControlBaseOnUserControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
        Me.RibbonControlBaseOnUserControl.ExpandCollapseItem.Id = 0
        Me.RibbonControlBaseOnUserControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControlBaseOnUserControl.ExpandCollapseItem, Me.BtnCREATE, Me.BtnEDIT, Me.BtnDELETE, Me.BtnOK, Me.BtnCANCEL, Me.BtnPRINT, Me.BtnEXCEL, Me.BtnEMAIL, Me.BtnOKANDNEW, Me.BtnREFRESH})
        Me.RibbonControlBaseOnUserControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControlBaseOnUserControl.MaxItemId = 12
        Me.RibbonControlBaseOnUserControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.RibbonControlBaseOnUserControl.Name = "RibbonControlBaseOnUserControl"
        Me.RibbonControlBaseOnUserControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RbpFunction})
        Me.RibbonControlBaseOnUserControl.Size = New System.Drawing.Size(827, 239)
        Me.RibbonControlBaseOnUserControl.StatusBar = Me.BaseStatusBar
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
        'RbpFunction
        '
        Me.RbpFunction.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RbpGTools, Me.RbpGExtend, Me.RbpGConfirm})
        Me.RbpFunction.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.pivottablecalculationsfieldsitemssetsgroup
        Me.RbpFunction.Name = "RbpFunction"
        Me.RbpFunction.Text = "Chức năng"
        '
        'RbpGTools
        '
        Me.RbpGTools.ItemLinks.Add(Me.BtnCREATE)
        Me.RbpGTools.ItemLinks.Add(Me.BtnEDIT)
        Me.RbpGTools.ItemLinks.Add(Me.BtnDELETE)
        Me.RbpGTools.ItemLinks.Add(Me.BtnREFRESH)
        Me.RbpGTools.Name = "RbpGTools"
        Me.RbpGTools.ShowCaptionButton = False
        Me.RbpGTools.Text = "Công cụ"
        '
        'RbpGExtend
        '
        Me.RbpGExtend.ItemLinks.Add(Me.BtnPRINT)
        Me.RbpGExtend.ItemLinks.Add(Me.BtnEXCEL)
        Me.RbpGExtend.ItemLinks.Add(Me.BtnEMAIL)
        Me.RbpGExtend.Name = "RbpGExtend"
        Me.RbpGExtend.ShowCaptionButton = False
        Me.RbpGExtend.Text = "Mở rộng"
        '
        'RbpGConfirm
        '
        Me.RbpGConfirm.ItemLinks.Add(Me.BtnOK)
        Me.RbpGConfirm.ItemLinks.Add(Me.BtnOKANDNEW)
        Me.RbpGConfirm.ItemLinks.Add(Me.BtnCANCEL)
        Me.RbpGConfirm.Name = "RbpGConfirm"
        Me.RbpGConfirm.ShowCaptionButton = False
        Me.RbpGConfirm.Text = "Xác nhận"
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 243)
        Me.BaseStatusBar.Name = "BaseStatusBar"
        Me.BaseStatusBar.Ribbon = Me.RibbonControlBaseOnUserControl
        Me.BaseStatusBar.Size = New System.Drawing.Size(827, 40)
        '
        'UCBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BaseStatusBar)
        Me.Controls.Add(Me.RibbonControlBaseOnUserControl)
        Me.Name = "UCBase"
        Me.Size = New System.Drawing.Size(827, 283)
        CType(Me.RibbonControlBaseOnUserControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControlBaseOnUserControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RbpFunction As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RbpGTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCREATE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEDIT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDELETE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGConfirm As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCANCEL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RbpGExtend As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnPRINT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEXCEL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEMAIL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOKANDNEW As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnREFRESH As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BaseStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
End Class
