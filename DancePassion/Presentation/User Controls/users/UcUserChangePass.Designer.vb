<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUserChangePass
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtOldPw = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtUserName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtNewPw = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOldPw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewPw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 479)
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.LayoutControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 239)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(827, 240)
        Me.PanelControl1.TabIndex = 2
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtOldPw)
        Me.LayoutControl1.Controls.Add(Me.TxtUserName)
        Me.LayoutControl1.Controls.Add(Me.TxtNewPw)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(823, 236)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(823, 236)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtUserName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(803, 44)
        Me.LayoutControlItem1.Text = "Tên đăng nhập"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 17)
        '
        'TxtOldPw
        '
        Me.TxtOldPw.Location = New System.Drawing.Point(117, 56)
        Me.TxtOldPw.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtOldPw.Name = "TxtOldPw"
        Me.TxtOldPw.Size = New System.Drawing.Size(694, 40)
        Me.TxtOldPw.StyleController = Me.LayoutControl1
        Me.TxtOldPw.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtOldPw
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(803, 44)
        Me.LayoutControlItem2.Text = "Mật khẩu cũ"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 17)
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(117, 12)
        Me.TxtUserName.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtUserName.Properties.NullText = ""
        Me.TxtUserName.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.TxtUserName.Size = New System.Drawing.Size(694, 40)
        Me.TxtUserName.StyleController = Me.LayoutControl1
        Me.TxtUserName.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'TxtNewPw
        '
        Me.TxtNewPw.Location = New System.Drawing.Point(117, 100)
        Me.TxtNewPw.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtNewPw.Name = "TxtNewPw"
        Me.TxtNewPw.Size = New System.Drawing.Size(694, 40)
        Me.TxtNewPw.StyleController = Me.LayoutControl1
        Me.TxtNewPw.TabIndex = 6
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtNewPw
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(803, 128)
        Me.LayoutControlItem3.Text = "Mật khẩu mới"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 17)
        '
        'UcUserChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "UcUserChangePass"
        Me.Size = New System.Drawing.Size(827, 519)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOldPw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewPw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtOldPw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUserName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtNewPw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
