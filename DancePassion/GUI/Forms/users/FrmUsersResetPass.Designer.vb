<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsersResetPass
    ' Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsersResetPass))
        Me.TxtUserNameOrEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LblUserOrEmail = New DevExpress.XtraEditors.LabelControl()
        Me.BtnGetPassWord = New DevExpress.XtraEditors.SimpleButton()
        Me.LblActiveCode = New DevExpress.XtraEditors.LabelControl()
        Me.TxtActiveCode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TxtUserNameOrEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtActiveCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUserNameOrEmail
        '
        Me.TxtUserNameOrEmail.Location = New System.Drawing.Point(20, 32)
        Me.TxtUserNameOrEmail.Name = "TxtUserNameOrEmail"
        Me.TxtUserNameOrEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUserNameOrEmail.Size = New System.Drawing.Size(260, 38)
        Me.TxtUserNameOrEmail.TabIndex = 0
        '
        'LblUserOrEmail
        '
        Me.LblUserOrEmail.Location = New System.Drawing.Point(20, 7)
        Me.LblUserOrEmail.Name = "LblUserOrEmail"
        Me.LblUserOrEmail.Size = New System.Drawing.Size(87, 17)
        Me.LblUserOrEmail.TabIndex = 1
        Me.LblUserOrEmail.Text = "Tên đăng nhập"
        '
        'BtnGetPassWord
        '
        Me.BtnGetPassWord.Appearance.Options.UseBorderColor = True
        Me.BtnGetPassWord.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnGetPassWord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGetPassWord.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.checkbox
        Me.BtnGetPassWord.Location = New System.Drawing.Point(90, 153)
        Me.BtnGetPassWord.Name = "BtnGetPassWord"
        Me.BtnGetPassWord.Size = New System.Drawing.Size(120, 40)
        Me.BtnGetPassWord.TabIndex = 2
        Me.BtnGetPassWord.Text = "Lấy mật khẩu"
        '
        'LblActiveCode
        '
        Me.LblActiveCode.Location = New System.Drawing.Point(20, 82)
        Me.LblActiveCode.Name = "LblActiveCode"
        Me.LblActiveCode.Size = New System.Drawing.Size(176, 17)
        Me.LblActiveCode.TabIndex = 3
        Me.LblActiveCode.Text = "Mã kích hoạt (tìm trong email)"
        '
        'TxtActiveCode
        '
        Me.TxtActiveCode.Location = New System.Drawing.Point(19, 106)
        Me.TxtActiveCode.Name = "TxtActiveCode"
        Me.TxtActiveCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtActiveCode.Size = New System.Drawing.Size(260, 38)
        Me.TxtActiveCode.TabIndex = 4
        '
        'FrmUsersResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 205)
        Me.Controls.Add(Me.TxtActiveCode)
        Me.Controls.Add(Me.LblActiveCode)
        Me.Controls.Add(Me.BtnGetPassWord)
        Me.Controls.Add(Me.LblUserOrEmail)
        Me.Controls.Add(Me.TxtUserNameOrEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsersResetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lấy lại mật khẩu"
        CType(Me.TxtUserNameOrEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtActiveCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUserNameOrEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblUserOrEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnGetPassWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblActiveCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtActiveCode As DevExpress.XtraEditors.TextEdit
End Class
