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
        Me.ctrMaiconfigServer = New System.Windows.Forms.TextBox()
        Me.ctrMaiconfigPort = New System.Windows.Forms.TextBox()
        Me.ctrMaiconfigUser = New System.Windows.Forms.TextBox()
        Me.ctrMaiconfigPwd = New System.Windows.Forms.TextBox()
        Me.CkbMaiconfigSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigOK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.CkbMaiconfigSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrMailconfigSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctrMaiconfigServer
        '
        Me.ctrMaiconfigServer.Location = New System.Drawing.Point(43, 33)
        Me.ctrMaiconfigServer.Name = "ctrMaiconfigServer"
        Me.ctrMaiconfigServer.Size = New System.Drawing.Size(181, 21)
        Me.ctrMaiconfigServer.TabIndex = 0
        '
        'ctrMaiconfigPort
        '
        Me.ctrMaiconfigPort.Location = New System.Drawing.Point(43, 78)
        Me.ctrMaiconfigPort.Name = "ctrMaiconfigPort"
        Me.ctrMaiconfigPort.Size = New System.Drawing.Size(181, 21)
        Me.ctrMaiconfigPort.TabIndex = 1
        '
        'ctrMaiconfigUser
        '
        Me.ctrMaiconfigUser.Location = New System.Drawing.Point(43, 116)
        Me.ctrMaiconfigUser.Name = "ctrMaiconfigUser"
        Me.ctrMaiconfigUser.Size = New System.Drawing.Size(181, 21)
        Me.ctrMaiconfigUser.TabIndex = 2
        '
        'ctrMaiconfigPwd
        '
        Me.ctrMaiconfigPwd.Location = New System.Drawing.Point(43, 157)
        Me.ctrMaiconfigPwd.Name = "ctrMaiconfigPwd"
        Me.ctrMaiconfigPwd.Size = New System.Drawing.Size(181, 21)
        Me.ctrMaiconfigPwd.TabIndex = 3
        '
        'CkbMaiconfigSSL
        '
        Me.CkbMaiconfigSSL.Location = New System.Drawing.Point(268, 161)
        Me.CkbMaiconfigSSL.Name = "CkbMaiconfigSSL"
        Me.CkbMaiconfigSSL.Properties.Caption = "CheckEdit1"
        Me.CkbMaiconfigSSL.Size = New System.Drawing.Size(75, 19)
        Me.CkbMaiconfigSSL.TabIndex = 4
        '
        'ctrMailconfigSSL
        '
        Me.ctrMailconfigSSL.Location = New System.Drawing.Point(43, 196)
        Me.ctrMailconfigSSL.Name = "ctrMailconfigSSL"
        Me.ctrMailconfigSSL.Properties.Caption = "Bật SSL"
        Me.ctrMailconfigSSL.Size = New System.Drawing.Size(75, 19)
        Me.ctrMailconfigSSL.TabIndex = 5
        '
        'ctrMailconfigOK
        '
        Me.ctrMailconfigOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.ctrMailconfigOK.Location = New System.Drawing.Point(43, 221)
        Me.ctrMailconfigOK.Name = "ctrMailconfigOK"
        Me.ctrMailconfigOK.Size = New System.Drawing.Size(75, 23)
        Me.ctrMailconfigOK.TabIndex = 6
        Me.ctrMailconfigOK.Text = "OK"
        '
        'Mailconfigfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 251)
        Me.Controls.Add(Me.ctrMailconfigOK)
        Me.Controls.Add(Me.ctrMailconfigSSL)
        Me.Controls.Add(Me.CkbMaiconfigSSL)
        Me.Controls.Add(Me.ctrMaiconfigPwd)
        Me.Controls.Add(Me.ctrMaiconfigUser)
        Me.Controls.Add(Me.ctrMaiconfigPort)
        Me.Controls.Add(Me.ctrMaiconfigServer)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.Name = "Mailconfigfrm"
        Me.Text = "MailConfig"
        CType(Me.CkbMaiconfigSSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrMailconfigSSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ctrMaiconfigServer As TextBox
    Friend WithEvents ctrMaiconfigPort As TextBox
    Friend WithEvents ctrMaiconfigUser As TextBox
    Friend WithEvents ctrMaiconfigPwd As TextBox
    Friend WithEvents CkbMaiconfigSSL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ctrMailconfigSSL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ctrMailconfigOK As DevExpress.XtraEditors.SimpleButton
End Class
