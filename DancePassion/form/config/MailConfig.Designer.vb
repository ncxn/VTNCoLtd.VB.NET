<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mailconfigfrm
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
        Me.ctrMailconfigServer = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigPort = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigUser = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigPwd = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigVdefault = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigOK = New DevExpress.XtraEditors.SimpleButton()
        Me.ctrMailconfigKey = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.ctrMailconfigVdefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrMailconfigSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctrMailconfigServer
        '
        Me.ctrMailconfigServer.Location = New System.Drawing.Point(131, 77)
        Me.ctrMailconfigServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigServer.Name = "ctrMailconfigServer"
        Me.ctrMailconfigServer.Size = New System.Drawing.Size(210, 23)
        Me.ctrMailconfigServer.TabIndex = 0
        '
        'ctrMailconfigPort
        '
        Me.ctrMailconfigPort.Location = New System.Drawing.Point(131, 123)
        Me.ctrMailconfigPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigPort.Name = "ctrMailconfigPort"
        Me.ctrMailconfigPort.Size = New System.Drawing.Size(210, 23)
        Me.ctrMailconfigPort.TabIndex = 1
        '
        'ctrMailconfigUser
        '
        Me.ctrMailconfigUser.Location = New System.Drawing.Point(131, 170)
        Me.ctrMailconfigUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigUser.Name = "ctrMailconfigUser"
        Me.ctrMailconfigUser.Size = New System.Drawing.Size(210, 23)
        Me.ctrMailconfigUser.TabIndex = 2
        '
        'ctrMailconfigPwd
        '
        Me.ctrMailconfigPwd.Location = New System.Drawing.Point(131, 220)
        Me.ctrMailconfigPwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigPwd.Name = "ctrMailconfigPwd"
        Me.ctrMailconfigPwd.Size = New System.Drawing.Size(210, 23)
        Me.ctrMailconfigPwd.TabIndex = 3
        '
        'ctrMailconfigVdefault
        '
        Me.ctrMailconfigVdefault.Location = New System.Drawing.Point(254, 269)
        Me.ctrMailconfigVdefault.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigVdefault.Name = "ctrMailconfigVdefault"
        Me.ctrMailconfigVdefault.Properties.Caption = "Mặc định"
        Me.ctrMailconfigVdefault.Size = New System.Drawing.Size(87, 21)
        Me.ctrMailconfigVdefault.TabIndex = 4
        '
        'ctrMailconfigSSL
        '
        Me.ctrMailconfigSSL.Location = New System.Drawing.Point(131, 268)
        Me.ctrMailconfigSSL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigSSL.Name = "ctrMailconfigSSL"
        Me.ctrMailconfigSSL.Properties.Caption = "Bật SSL"
        Me.ctrMailconfigSSL.Size = New System.Drawing.Size(87, 21)
        Me.ctrMailconfigSSL.TabIndex = 5
        '
        'ctrMailconfigOK
        '
        Me.ctrMailconfigOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.ctrMailconfigOK.Location = New System.Drawing.Point(131, 299)
        Me.ctrMailconfigOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigOK.Name = "ctrMailconfigOK"
        Me.ctrMailconfigOK.Size = New System.Drawing.Size(87, 28)
        Me.ctrMailconfigOK.TabIndex = 6
        Me.ctrMailconfigOK.Text = "OK"
        '
        'ctrMailconfigKey
        '
        Me.ctrMailconfigKey.Location = New System.Drawing.Point(131, 28)
        Me.ctrMailconfigKey.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ctrMailconfigKey.Name = "ctrMailconfigKey"
        Me.ctrMailconfigKey.Size = New System.Drawing.Size(210, 23)
        Me.ctrMailconfigKey.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.ShowToolTips = False
        Me.LabelControl1.Size = New System.Drawing.Size(57, 23)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Dịch vụ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.ShowToolTips = False
        Me.LabelControl2.Size = New System.Drawing.Size(47, 23)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Server"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 123)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.ShowToolTips = False
        Me.LabelControl3.Size = New System.Drawing.Size(88, 23)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Cổng (port)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 170)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.ShowToolTips = False
        Me.LabelControl4.Size = New System.Drawing.Size(85, 23)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "User(email)"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 220)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.ShowToolTips = False
        Me.LabelControl5.Size = New System.Drawing.Size(72, 23)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Mật khẩu"
        '
        'Mailconfigfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 376)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ctrMailconfigKey)
        Me.Controls.Add(Me.ctrMailconfigOK)
        Me.Controls.Add(Me.ctrMailconfigSSL)
        Me.Controls.Add(Me.ctrMailconfigVdefault)
        Me.Controls.Add(Me.ctrMailconfigPwd)
        Me.Controls.Add(Me.ctrMailconfigUser)
        Me.Controls.Add(Me.ctrMailconfigPort)
        Me.Controls.Add(Me.ctrMailconfigServer)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Mailconfigfrm"
        Me.Text = "MailConfig"
        CType(Me.ctrMailconfigVdefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrMailconfigSSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ctrMailconfigServer As TextBox
    Friend WithEvents ctrMailconfigPort As TextBox
    Friend WithEvents ctrMailconfigUser As TextBox
    Friend WithEvents ctrMailconfigPwd As TextBox
    Friend WithEvents ctrMailconfigVdefault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ctrMailconfigSSL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ctrMailconfigOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ctrMailconfigKey As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
