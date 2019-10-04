<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcConfig_Basic
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UcBase
    'UserControl overrides dispose to clean up the component list.
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtoName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtoSologan = New DevExpress.XtraEditors.TextEdit()
        Me.TxtoAddress = New DevExpress.XtraEditors.TextEdit()
        Me.TxtoEmail = New DevExpress.XtraEditors.TextEdit()
        Me.TxtoTaxCode = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtoName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtoSologan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtoAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtoEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtoTaxCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 543)
        Me.BaseStatusBar.Margin = New System.Windows.Forms.Padding(5)
        Me.BaseStatusBar.Size = New System.Drawing.Size(887, 30)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtoName)
        Me.LayoutControl1.Controls.Add(Me.TxtoSologan)
        Me.LayoutControl1.Controls.Add(Me.TxtoAddress)
        Me.LayoutControl1.Controls.Add(Me.TxtoEmail)
        Me.LayoutControl1.Controls.Add(Me.TxtoTaxCode)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-9, -9, 1938, 1098)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(887, 281)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtoName
        '
        Me.TxtoName.Location = New System.Drawing.Point(103, 12)
        Me.TxtoName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtoName.Name = "TxtoName"
        Me.TxtoName.Size = New System.Drawing.Size(772, 30)
        Me.TxtoName.StyleController = Me.LayoutControl1
        Me.TxtoName.TabIndex = 9
        '
        'TxtoSologan
        '
        Me.TxtoSologan.Location = New System.Drawing.Point(103, 46)
        Me.TxtoSologan.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtoSologan.Name = "TxtoSologan"
        Me.TxtoSologan.Size = New System.Drawing.Size(772, 30)
        Me.TxtoSologan.StyleController = Me.LayoutControl1
        Me.TxtoSologan.TabIndex = 8
        '
        'TxtoAddress
        '
        Me.TxtoAddress.Location = New System.Drawing.Point(103, 80)
        Me.TxtoAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtoAddress.Name = "TxtoAddress"
        Me.TxtoAddress.Size = New System.Drawing.Size(772, 30)
        Me.TxtoAddress.StyleController = Me.LayoutControl1
        Me.TxtoAddress.TabIndex = 7
        '
        'TxtoEmail
        '
        Me.TxtoEmail.Location = New System.Drawing.Point(103, 114)
        Me.TxtoEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtoEmail.Name = "TxtoEmail"
        Me.TxtoEmail.Size = New System.Drawing.Size(772, 30)
        Me.TxtoEmail.StyleController = Me.LayoutControl1
        Me.TxtoEmail.TabIndex = 6
        '
        'TxtoTaxCode
        '
        Me.TxtoTaxCode.Location = New System.Drawing.Point(103, 148)
        Me.TxtoTaxCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtoTaxCode.Name = "TxtoTaxCode"
        Me.TxtoTaxCode.Size = New System.Drawing.Size(772, 30)
        Me.TxtoTaxCode.StyleController = Me.LayoutControl1
        Me.TxtoTaxCode.TabIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(887, 281)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtoName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(867, 34)
        Me.LayoutControlItem1.Text = "Tên tổ chức"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(88, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtoSologan
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(867, 34)
        Me.LayoutControlItem2.Text = "Khẩu hiệu"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 23)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtoAddress
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 68)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(867, 34)
        Me.LayoutControlItem3.Text = "Địa chỉ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtoEmail
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(867, 34)
        Me.LayoutControlItem4.Text = "Thư điện tử"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtoTaxCode
        Me.LayoutControlItem5.CustomizationFormText = "Thư điện tử"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 136)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(867, 34)
        Me.LayoutControlItem5.Text = "Mã số thuế"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 23)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 170)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(867, 91)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'UcConfig_Basic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UcConfig_Basic"
        Me.Size = New System.Drawing.Size(887, 573)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtoName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtoSologan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtoAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtoEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtoTaxCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtoName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtoSologan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtoAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtoEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtoTaxCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
