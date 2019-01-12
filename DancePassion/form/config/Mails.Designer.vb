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
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.ChkVdefault = New System.Windows.Forms.CheckBox()
        Me.chkSSL = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(99, 30)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 22)
        Me.txtServer.TabIndex = 0
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(99, 2)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 22)
        Me.txtKey.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(99, 86)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 22)
        Me.txtUser.TabIndex = 2
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(99, 114)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(100, 22)
        Me.txtPwd.TabIndex = 3
        '
        'ChkVdefault
        '
        Me.ChkVdefault.AutoSize = True
        Me.ChkVdefault.Location = New System.Drawing.Point(99, 176)
        Me.ChkVdefault.Name = "ChkVdefault"
        Me.ChkVdefault.Size = New System.Drawing.Size(79, 17)
        Me.ChkVdefault.TabIndex = 4
        Me.ChkVdefault.Text = "Mặc định?"
        Me.ChkVdefault.UseVisualStyleBackColor = True
        '
        'chkSSL
        '
        Me.chkSSL.AutoSize = True
        Me.chkSSL.Location = New System.Drawing.Point(99, 153)
        Me.chkSSL.Name = "chkSSL"
        Me.chkSSL.Size = New System.Drawing.Size(51, 17)
        Me.chkSSL.TabIndex = 5
        Me.chkSSL.Text = "SSL ?"
        Me.chkSSL.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(98, 213)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(98, 58)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 22)
        Me.txtPort.TabIndex = 7
        '
        'Mails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 268)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkSSL)
        Me.Controls.Add(Me.ChkVdefault)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtServer)
        Me.Name = "Mails"
        Me.Text = "Mails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents ChkVdefault As CheckBox
    Friend WithEvents chkSSL As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents txtPort As TextBox
End Class
