<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcUsersUpdate
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
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
        Me.txtUser_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser_Status = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser_LastName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser_FirstName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser_Email = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtUser_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser_LastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser_FirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.BaseStatusBar.Size = New System.Drawing.Size(592, 40)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtUser_Name)
        Me.LayoutControl1.Controls.Add(Me.txtUser_Status)
        Me.LayoutControl1.Controls.Add(Me.txtUser_LastName)
        Me.LayoutControl1.Controls.Add(Me.txtUser_FirstName)
        Me.LayoutControl1.Controls.Add(Me.txtUser_Email)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(624, 42, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(592, 179)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtUser_Name
        '
        Me.txtUser_Name.Location = New System.Drawing.Point(108, 12)
        Me.txtUser_Name.Name = "txtUser_Name"
        Me.txtUser_Name.Size = New System.Drawing.Size(455, 40)
        Me.txtUser_Name.StyleController = Me.LayoutControl1
        Me.txtUser_Name.TabIndex = 4
        '
        'txtUser_Status
        '
        Me.txtUser_Status.Location = New System.Drawing.Point(108, 188)
        Me.txtUser_Status.Name = "txtUser_Status"
        Me.txtUser_Status.Size = New System.Drawing.Size(455, 40)
        Me.txtUser_Status.StyleController = Me.LayoutControl1
        Me.txtUser_Status.TabIndex = 5
        '
        'txtUser_LastName
        '
        Me.txtUser_LastName.Location = New System.Drawing.Point(108, 100)
        Me.txtUser_LastName.Name = "txtUser_LastName"
        Me.txtUser_LastName.Size = New System.Drawing.Size(455, 40)
        Me.txtUser_LastName.StyleController = Me.LayoutControl1
        Me.txtUser_LastName.TabIndex = 6
        '
        'txtUser_FirstName
        '
        Me.txtUser_FirstName.Location = New System.Drawing.Point(108, 144)
        Me.txtUser_FirstName.Name = "txtUser_FirstName"
        Me.txtUser_FirstName.Size = New System.Drawing.Size(455, 40)
        Me.txtUser_FirstName.StyleController = Me.LayoutControl1
        Me.txtUser_FirstName.TabIndex = 7
        '
        'txtUser_Email
        '
        Me.txtUser_Email.Location = New System.Drawing.Point(108, 56)
        Me.txtUser_Email.Name = "txtUser_Email"
        Me.txtUser_Email.Size = New System.Drawing.Size(455, 40)
        Me.txtUser_Email.StyleController = Me.LayoutControl1
        Me.txtUser_Email.TabIndex = 8
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(575, 250)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtUser_Name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem1.Text = "Tên đăng nhập"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 17)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 220)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(555, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtUser_LastName
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem3.Text = "Họ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtUser_FirstName
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 132)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem4.Text = "Tên"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtUser_Email
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem5.Text = "Email"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(93, 17)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUser_Status
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 176)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(555, 44)
        Me.LayoutControlItem2.Text = "Trạng thái"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 17)
        '
        'UcUsersUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcUsersUpdate"
        Me.Size = New System.Drawing.Size(592, 458)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtUser_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser_LastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser_FirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtUser_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser_Status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser_LastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser_FirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser_Email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    ' Friend WithEvents txtUser_Status As DevExpress.XtraEditors.TextEdit
End Class
