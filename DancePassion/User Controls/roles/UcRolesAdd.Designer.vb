<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRolesAdd
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtRole_name = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRole_description = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtRole_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRole_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 562)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtRole_name)
        Me.LayoutControl1.Controls.Add(Me.TxtRole_description)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(931, 300)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtRole_name
        '
        Me.TxtRole_name.Location = New System.Drawing.Point(85, 12)
        Me.TxtRole_name.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtRole_name.Name = "TxtRole_name"
        Me.TxtRole_name.Size = New System.Drawing.Size(834, 30)
        Me.TxtRole_name.StyleController = Me.LayoutControl1
        Me.TxtRole_name.TabIndex = 4
        '
        'TxtRole_description
        '
        Me.TxtRole_description.Location = New System.Drawing.Point(85, 46)
        Me.TxtRole_description.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtRole_description.Name = "TxtRole_description"
        Me.TxtRole_description.Size = New System.Drawing.Size(834, 30)
        Me.TxtRole_description.StyleController = Me.LayoutControl1
        Me.TxtRole_description.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(931, 300)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtRole_name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(911, 34)
        Me.LayoutControlItem1.Text = "Tên nhóm"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 21)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtRole_description
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(911, 246)
        Me.LayoutControlItem2.Text = "Mô tả"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(70, 23)
        '
        'UcRolesAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcRolesAdd"
        Me.Size = New System.Drawing.Size(931, 599)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtRole_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRole_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtRole_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRole_description As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
