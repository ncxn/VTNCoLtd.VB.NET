<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcCustomer_Add
    'Inherits System.Windows.Forms.UserControl
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtCustomer_Expand_Info_Id = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCustomer_Email = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCustomer_Phone = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCustomer_Address = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCustomer_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtCustomer_Group_Id = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtCustomer_Expand_Info_Id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer_Phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer_Group_Id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 509)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Group_Id)
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Expand_Info_Id)
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Email)
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Phone)
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Address)
        Me.LayoutControl1.Controls.Add(Me.TxtCustomer_Name)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(724, 270)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtCustomer_Expand_Info_Id
        '
        Me.TxtCustomer_Expand_Info_Id.Location = New System.Drawing.Point(125, 232)
        Me.TxtCustomer_Expand_Info_Id.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Expand_Info_Id.Name = "TxtCustomer_Expand_Info_Id"
        Me.TxtCustomer_Expand_Info_Id.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Expand_Info_Id.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Expand_Info_Id.TabIndex = 9
        '
        'TxtCustomer_Email
        '
        Me.TxtCustomer_Email.Location = New System.Drawing.Point(125, 144)
        Me.TxtCustomer_Email.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Email.Name = "TxtCustomer_Email"
        Me.TxtCustomer_Email.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Email.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Email.TabIndex = 7
        '
        'TxtCustomer_Phone
        '
        Me.TxtCustomer_Phone.Location = New System.Drawing.Point(125, 100)
        Me.TxtCustomer_Phone.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Phone.Name = "TxtCustomer_Phone"
        Me.TxtCustomer_Phone.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Phone.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Phone.TabIndex = 6
        '
        'TxtCustomer_Address
        '
        Me.TxtCustomer_Address.Location = New System.Drawing.Point(125, 56)
        Me.TxtCustomer_Address.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Address.Name = "TxtCustomer_Address"
        Me.TxtCustomer_Address.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Address.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Address.TabIndex = 5
        '
        'TxtCustomer_Name
        '
        Me.TxtCustomer_Name.Location = New System.Drawing.Point(125, 12)
        Me.TxtCustomer_Name.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Name.Name = "TxtCustomer_Name"
        Me.TxtCustomer_Name.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Name.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Name.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(707, 284)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtCustomer_Name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem1.Text = "Tên khách hàng"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 17)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtCustomer_Address
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem2.Text = "Địa chỉ"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(110, 17)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtCustomer_Phone
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem3.Text = "Điện thoại"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(110, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtCustomer_Email
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 132)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem4.Text = "Email"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(110, 17)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TxtCustomer_Expand_Info_Id
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem6.Text = "Thông tin mở rộng"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(110, 17)
        '
        'TxtCustomer_Group_Id
        '
        Me.TxtCustomer_Group_Id.EditValue = "Chọn nhóm khách hàng"
        Me.TxtCustomer_Group_Id.Location = New System.Drawing.Point(125, 188)
        Me.TxtCustomer_Group_Id.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.TxtCustomer_Group_Id.Name = "TxtCustomer_Group_Id"
        Me.TxtCustomer_Group_Id.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCustomer_Group_Id.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.TxtCustomer_Group_Id.Size = New System.Drawing.Size(570, 40)
        Me.TxtCustomer_Group_Id.StyleController = Me.LayoutControl1
        Me.TxtCustomer_Group_Id.TabIndex = 10
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TxtCustomer_Group_Id
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 176)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(687, 44)
        Me.LayoutControlItem7.Text = "Thuộc nhóm"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(110, 17)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'UcCustomer_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcCustomer_Add"
        Me.Size = New System.Drawing.Size(724, 549)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtCustomer_Expand_Info_Id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer_Phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer_Group_Id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtCustomer_Email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCustomer_Phone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCustomer_Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCustomer_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtCustomer_Expand_Info_Id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtCustomer_Group_Id As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
