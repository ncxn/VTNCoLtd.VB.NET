<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMailConfig
    Inherits UcBase

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CbMail_service = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.SvgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
        Me.TxtMail_user = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMail_password = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CbMail_service.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMail_user.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMail_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 568)
        Me.BaseStatusBar.Margin = New System.Windows.Forms.Padding(5)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbMail_service)
        Me.LayoutControl1.Controls.Add(Me.TxtMail_user)
        Me.LayoutControl1.Controls.Add(Me.TxtMail_password)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(931, 306)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbMail_service
        '
        Me.CbMail_service.Location = New System.Drawing.Point(256, 12)
        Me.CbMail_service.Margin = New System.Windows.Forms.Padding(4)
        Me.CbMail_service.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.CbMail_service.Name = "CbMail_service"
        Me.CbMail_service.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbMail_service.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gmail", "Gmail", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Outlook (MicroSoft)", "Outlook", 1)})
        Me.CbMail_service.Properties.SmallImages = Me.SvgImageCollection1
        Me.CbMail_service.Size = New System.Drawing.Size(663, 30)
        Me.CbMail_service.StyleController = Me.LayoutControl1
        Me.CbMail_service.TabIndex = 4
        '
        'SvgImageCollection1
        '
        Me.SvgImageCollection1.Add("gmail", "gmail", GetType(VTNcoLtd.My.Resources.Resources))
        Me.SvgImageCollection1.Add("outlook", "outlook", GetType(VTNcoLtd.My.Resources.Resources))
        '
        'TxtMail_user
        '
        Me.TxtMail_user.Location = New System.Drawing.Point(256, 46)
        Me.TxtMail_user.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMail_user.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtMail_user.Name = "TxtMail_user"
        Me.TxtMail_user.Size = New System.Drawing.Size(663, 30)
        Me.TxtMail_user.StyleController = Me.LayoutControl1
        Me.TxtMail_user.TabIndex = 5
        '
        'TxtMail_password
        '
        Me.TxtMail_password.Location = New System.Drawing.Point(256, 80)
        Me.TxtMail_password.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMail_password.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtMail_password.Name = "TxtMail_password"
        Me.TxtMail_password.Size = New System.Drawing.Size(663, 30)
        Me.TxtMail_password.StyleController = Me.LayoutControl1
        Me.TxtMail_password.TabIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(931, 306)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbMail_service
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(911, 34)
        Me.LayoutControlItem1.Text = "Dịch vụ mail"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(241, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtMail_user
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(911, 34)
        Me.LayoutControlItem2.Text = "Tên đăng nhập (hoặc email)"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(241, 23)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtMail_password
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 68)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(911, 218)
        Me.LayoutControlItem3.Text = "Mật khẩu (hoặc mã đăng nhập)"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(241, 23)
        '
        'UcMailConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UcMailConfig"
        Me.Size = New System.Drawing.Size(931, 605)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CbMail_service.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMail_user.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMail_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbMail_service As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents TxtMail_user As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMail_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SvgImageCollection1 As DevExpress.Utils.SvgImageCollection
End Class
