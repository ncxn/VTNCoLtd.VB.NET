<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcControlAdd
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
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
        Me.TxtControls_name = New DevExpress.XtraEditors.TextEdit()
        Me.TxtControls_description = New DevExpress.XtraEditors.TextEdit()
        Me.TxtControls_type = New DevExpress.XtraEditors.TextEdit()
        Me.TxtControls_sort = New DevExpress.XtraEditors.TextEdit()
        Me.TxtControls_parent = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtControls_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtControls_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtControls_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtControls_sort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtControls_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 654)
        Me.BaseStatusBar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BaseStatusBar.Size = New System.Drawing.Size(930, 37)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtControls_name)
        Me.LayoutControl1.Controls.Add(Me.TxtControls_description)
        Me.LayoutControl1.Controls.Add(Me.TxtControls_type)
        Me.LayoutControl1.Controls.Add(Me.TxtControls_sort)
        Me.LayoutControl1.Controls.Add(Me.TxtControls_parent)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(930, 392)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtControls_name
        '
        Me.TxtControls_name.Location = New System.Drawing.Point(99, 12)
        Me.TxtControls_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtControls_name.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtControls_name.Name = "TxtControls_name"
        Me.TxtControls_name.Size = New System.Drawing.Size(819, 30)
        Me.TxtControls_name.StyleController = Me.LayoutControl1
        Me.TxtControls_name.TabIndex = 4
        '
        'TxtControls_description
        '
        Me.TxtControls_description.Location = New System.Drawing.Point(99, 46)
        Me.TxtControls_description.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtControls_description.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtControls_description.Name = "TxtControls_description"
        Me.TxtControls_description.Size = New System.Drawing.Size(819, 30)
        Me.TxtControls_description.StyleController = Me.LayoutControl1
        Me.TxtControls_description.TabIndex = 5
        '
        'TxtControls_type
        '
        Me.TxtControls_type.Location = New System.Drawing.Point(99, 114)
        Me.TxtControls_type.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtControls_type.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtControls_type.Name = "TxtControls_type"
        Me.TxtControls_type.Size = New System.Drawing.Size(819, 30)
        Me.TxtControls_type.StyleController = Me.LayoutControl1
        Me.TxtControls_type.TabIndex = 7
        '
        'TxtControls_sort
        '
        Me.TxtControls_sort.EditValue = 0
        Me.TxtControls_sort.Location = New System.Drawing.Point(99, 148)
        Me.TxtControls_sort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtControls_sort.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtControls_sort.Name = "TxtControls_sort"
        Me.TxtControls_sort.Size = New System.Drawing.Size(819, 30)
        Me.TxtControls_sort.StyleController = Me.LayoutControl1
        Me.TxtControls_sort.TabIndex = 8
        '
        'TxtControls_parent
        '
        Me.TxtControls_parent.Location = New System.Drawing.Point(99, 80)
        Me.TxtControls_parent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtControls_parent.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtControls_parent.Name = "TxtControls_parent"
        Me.TxtControls_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtControls_parent.Properties.NullText = ""
        Me.TxtControls_parent.Properties.PopupView = Me.GridLookUpEdit1View
        Me.TxtControls_parent.Size = New System.Drawing.Size(819, 30)
        Me.TxtControls_parent.StyleController = Me.LayoutControl1
        Me.TxtControls_parent.TabIndex = 6
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(930, 392)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtControls_name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(910, 34)
        Me.LayoutControlItem1.Text = "Mã Control:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 21)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtControls_description
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(910, 34)
        Me.LayoutControlItem2.Text = "Tên Control:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 21)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtControls_parent
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 68)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(910, 34)
        Me.LayoutControlItem3.Text = "Control cha:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 21)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtControls_type
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(910, 34)
        Me.LayoutControlItem4.Text = "Phân loại:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtControls_sort
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 136)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(910, 236)
        Me.LayoutControlItem5.Text = "Sắp xếp:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 23)
        '
        'UcControlAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "UcControlAdd"
        Me.Size = New System.Drawing.Size(930, 691)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtControls_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtControls_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtControls_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtControls_sort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtControls_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtControls_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtControls_description As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtControls_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtControls_sort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtControls_parent As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
