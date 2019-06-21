<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OKOrCancel
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
        Me.BtnOK = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BtnOK, Me.BtnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(476, 239)
        '
        'BtnOK
        '
        Me.BtnOK.Caption = "Chấp nhận"
        Me.BtnOK.Id = 1
        Me.BtnOK.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.markcomplete1
        Me.BtnOK.Name = "BtnOK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Caption = "Bỏ qua"
        Me.BtnCancel.Id = 2
        Me.BtnCancel.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.delete1
        Me.BtnCancel.Name = "BtnCancel"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.ImageOptions.SvgImage = Global.DancePassion.My.Resources.Resources.addcalculatedfield
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Chức năng"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnOK)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Xác nhận"
        '
        'OKOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "OKOrCancel"
        Me.Size = New System.Drawing.Size(476, 237)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCancel As DevExpress.XtraBars.BarButtonItem
End Class
