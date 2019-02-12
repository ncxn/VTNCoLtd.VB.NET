<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mails
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mails))
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.ChkVdefault = New System.Windows.Forms.CheckBox()
        Me.chkSSL = New System.Windows.Forms.CheckBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ServiceLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ServiceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(172, 77)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(510, 25)
        Me.txtServer.TabIndex = 0
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(172, 48)
        Me.txtKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(510, 25)
        Me.txtKey.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(172, 135)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(510, 25)
        Me.txtUser.TabIndex = 2
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(172, 164)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(510, 25)
        Me.txtPwd.TabIndex = 3
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'ChkVdefault
        '
        Me.ChkVdefault.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkVdefault.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVdefault.Location = New System.Drawing.Point(24, 283)
        Me.ChkVdefault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkVdefault.Name = "ChkVdefault"
        Me.ChkVdefault.Size = New System.Drawing.Size(658, 38)
        Me.ChkVdefault.TabIndex = 4
        Me.ChkVdefault.Text = "Mặc định?"
        Me.ChkVdefault.UseVisualStyleBackColor = True
        '
        'chkSSL
        '
        Me.chkSSL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSSL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSL.Location = New System.Drawing.Point(24, 241)
        Me.chkSSL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSSL.Name = "chkSSL"
        Me.chkSSL.Size = New System.Drawing.Size(658, 38)
        Me.chkSSL.TabIndex = 5
        Me.chkSSL.Text = "Bật SSL ?"
        Me.chkSSL.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(172, 106)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(510, 25)
        Me.txtPort.TabIndex = 7
        '
        'WindowsUIButtonPanel1
        '
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu dữ liệu", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Save", -1, False)})
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(24, 373)
        Me.WindowsUIButtonPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(658, 65)
        Me.WindowsUIButtonPanel1.TabIndex = 8
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.WrapButtons = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ServiceLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.LayoutControl1.Controls.Add(Me.ChkVdefault)
        Me.LayoutControl1.Controls.Add(Me.chkSSL)
        Me.LayoutControl1.Controls.Add(Me.txtPort)
        Me.LayoutControl1.Controls.Add(Me.txtPwd)
        Me.LayoutControl1.Controls.Add(Me.txtUser)
        Me.LayoutControl1.Controls.Add(Me.txtKey)
        Me.LayoutControl1.Controls.Add(Me.txtServer)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(0, 0, 1938, 1098)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(706, 626)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ServiceLookUpEdit
        '
        Me.ServiceLookUpEdit.Location = New System.Drawing.Point(116, 454)
        Me.ServiceLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ServiceLookUpEdit.Name = "ServiceLookUpEdit"
        Me.ServiceLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ServiceLookUpEdit.Size = New System.Drawing.Size(578, 42)
        Me.ServiceLookUpEdit.StyleController = Me.LayoutControl1
        Me.ServiceLookUpEdit.TabIndex = 9
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(706, 626)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.AlignControlsWithHiddenText = True
        Me.LayoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(686, 193)
        Me.LayoutControlGroup1.Text = "Thông tin"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.txtKey
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(662, 29)
        Me.LayoutControlItem1.Text = "Dịch vụ mail"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(145, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.txtServer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.OptionsPrint.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.OptionsPrint.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Size = New System.Drawing.Size(662, 29)
        Me.LayoutControlItem2.Text = "Địa chỉ máy chủ"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(145, 23)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.txtPort
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(662, 29)
        Me.LayoutControlItem3.Text = "Cổng kết nối (port)"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(145, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.txtUser
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 87)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(662, 29)
        Me.LayoutControlItem4.Text = "Đăng nhập (user)"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(145, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.Control = Me.txtPwd
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 116)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(662, 29)
        Me.LayoutControlItem5.Text = "Mật khẩu"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(145, 23)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 325)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(686, 117)
        Me.LayoutControlGroup2.Text = " Lưu"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.Control = Me.WindowsUIButtonPanel1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(662, 69)
        Me.LayoutControlItem8.Text = "Lưu dữ liệu"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceItemCaption.Image = CType(resources.GetObject("LayoutControlGroup3.AppearanceItemCaption.Image"), System.Drawing.Image)
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseImage = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(686, 132)
        Me.LayoutControlGroup3.Text = "Lựa chọn"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me.chkSSL
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(662, 42)
        Me.LayoutControlItem6.Text = "Bảo mật"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 38)
        Me.LayoutControlItem6.TextToControlDistance = 0
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.Control = Me.ChkVdefault
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(662, 42)
        Me.LayoutControlItem7.Text = "Mặc định"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 38)
        Me.LayoutControlItem7.TextToControlDistance = 0
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ServiceLookUpEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 442)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(686, 164)
        Me.LayoutControlItem9.Text = "Chọn dịch vụ"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(101, 23)
        '
        'Mails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 626)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Mails"
        Me.Text = "Cấu hình Email"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ServiceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents ChkVdefault As CheckBox
    Friend WithEvents chkSSL As CheckBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ServiceLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
