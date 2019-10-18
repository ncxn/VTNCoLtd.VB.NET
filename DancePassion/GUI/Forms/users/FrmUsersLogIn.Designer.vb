<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsersLogIn
    'Inherits DevExpress.XtraEditors.XtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsersLogIn))
        Me.PnLogo = New DevExpress.XtraEditors.PanelControl()
        Me.PicLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.PnDetail = New DevExpress.XtraEditors.PanelControl()
        Me.TxtPassWord = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLostPass = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnLogo.SuspendLayout()
        CType(Me.PicLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnDetail.SuspendLayout()
        CType(Me.TxtPassWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnLogo
        '
        Me.PnLogo.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.PnLogo.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnLogo.Appearance.Options.UseBackColor = True
        Me.PnLogo.Appearance.Options.UseBorderColor = True
        Me.PnLogo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnLogo.Controls.Add(Me.PicLogo)
        Me.PnLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnLogo.Location = New System.Drawing.Point(0, 0)
        Me.PnLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PnLogo.Name = "PnLogo"
        Me.PnLogo.Size = New System.Drawing.Size(150, 400)
        Me.PnLogo.TabIndex = 0
        '
        'PicLogo
        '
        Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicLogo.EditValue = CType(resources.GetObject("PicLogo.EditValue"), Object)
        Me.PicLogo.Location = New System.Drawing.Point(1, 125)
        Me.PicLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Properties.AllowFocused = False
        Me.PicLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PicLogo.Properties.Appearance.Options.UseBackColor = True
        Me.PicLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PicLogo.Properties.ShowMenu = False
        Me.PicLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicLogo.Size = New System.Drawing.Size(148, 148)
        Me.PicLogo.TabIndex = 0
        '
        'PnDetail
        '
        Me.PnDetail.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PnDetail.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnDetail.Appearance.Options.UseBackColor = True
        Me.PnDetail.Appearance.Options.UseBorderColor = True
        Me.PnDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnDetail.Controls.Add(Me.Panel2)
        Me.PnDetail.Controls.Add(Me.Panel1)
        Me.PnDetail.Controls.Add(Me.TxtPassWord)
        Me.PnDetail.Controls.Add(Me.TxtUserName)
        Me.PnDetail.Controls.Add(Me.LblTitle)
        Me.PnDetail.Controls.Add(Me.LinkLostPass)
        Me.PnDetail.Controls.Add(Me.BtnCancel)
        Me.PnDetail.Controls.Add(Me.BtnOK)
        Me.PnDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnDetail.Location = New System.Drawing.Point(150, 0)
        Me.PnDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.PnDetail.Name = "PnDetail"
        Me.PnDetail.Size = New System.Drawing.Size(450, 400)
        Me.PnDetail.TabIndex = 7
        '
        'TxtPassWord
        '
        Me.TxtPassWord.EditValue = "Mật khẩu"
        Me.TxtPassWord.Location = New System.Drawing.Point(75, 160)
        Me.TxtPassWord.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TxtPassWord.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassWord.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.TxtPassWord.Properties.Appearance.Options.UseBackColor = True
        Me.TxtPassWord.Properties.Appearance.Options.UseFont = True
        Me.TxtPassWord.Properties.Appearance.Options.UseForeColor = True
        Me.TxtPassWord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtPassWord.Properties.NullValuePromptShowForEmptyValue = True
        Me.TxtPassWord.Size = New System.Drawing.Size(300, 40)
        Me.TxtPassWord.TabIndex = 2
        '
        'TxtUserName
        '
        Me.TxtUserName.EditValue = "Tên đăng nhập"
        Me.TxtUserName.Location = New System.Drawing.Point(75, 110)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TxtUserName.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.TxtUserName.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.TxtUserName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.TxtUserName.Properties.Appearance.Options.UseBackColor = True
        Me.TxtUserName.Properties.Appearance.Options.UseBorderColor = True
        Me.TxtUserName.Properties.Appearance.Options.UseFont = True
        Me.TxtUserName.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUserName.Properties.Appearance.Options.UseImage = True
        Me.TxtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUserName.Size = New System.Drawing.Size(300, 40)
        Me.TxtUserName.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Appearance.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Appearance.Options.UseFont = True
        Me.LblTitle.Appearance.Options.UseForeColor = True
        Me.LblTitle.Location = New System.Drawing.Point(150, 30)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(136, 32)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "ĐĂNG NHẬP"
        '
        'LinkLostPass
        '
        Me.LinkLostPass.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLostPass.Appearance.Options.UseFont = True
        Me.LinkLostPass.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.LinkLostPass.AppearanceHovered.Options.UseForeColor = True
        Me.LinkLostPass.LineVisible = True
        Me.LinkLostPass.Location = New System.Drawing.Point(175, 330)
        Me.LinkLostPass.Name = "LinkLostPass"
        Me.LinkLostPass.Size = New System.Drawing.Size(117, 21)
        Me.LinkLostPass.TabIndex = 5
        Me.LinkLostPass.Text = "Quên mật khẩu?"
        '
        'BtnCancel
        '
        Me.BtnCancel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Appearance.Options.UseBackColor = True
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.Appearance.Options.UseForeColor = True
        Me.BtnCancel.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCancel.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent
        Me.BtnCancel.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.AppearanceHovered.Options.UseBackColor = True
        Me.BtnCancel.AppearanceHovered.Options.UseBorderColor = True
        Me.BtnCancel.AppearanceHovered.Options.UseFont = True
        Me.BtnCancel.AppearanceHovered.Options.UseForeColor = True
        Me.BtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ImageOptions.SvgImage = CType(resources.GetObject("BtnCancel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCancel.Location = New System.Drawing.Point(235, 240)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(140, 40)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Bỏ qua"
        '
        'BtnOK
        '
        Me.BtnOK.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnOK.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.BtnOK.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Appearance.Options.UseBackColor = True
        Me.BtnOK.Appearance.Options.UseBorderColor = True
        Me.BtnOK.Appearance.Options.UseFont = True
        Me.BtnOK.Appearance.Options.UseForeColor = True
        Me.BtnOK.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnOK.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent
        Me.BtnOK.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.BtnOK.AppearanceHovered.Options.UseBackColor = True
        Me.BtnOK.AppearanceHovered.Options.UseBorderColor = True
        Me.BtnOK.AppearanceHovered.Options.UseFont = True
        Me.BtnOK.AppearanceHovered.Options.UseForeColor = True
        Me.BtnOK.AppearancePressed.BackColor = System.Drawing.Color.Transparent
        Me.BtnOK.AppearancePressed.BackColor2 = System.Drawing.Color.Transparent
        Me.BtnOK.AppearancePressed.BorderColor = System.Drawing.Color.Transparent
        Me.BtnOK.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.AppearancePressed.ForeColor = System.Drawing.Color.White
        Me.BtnOK.AppearancePressed.Options.UseBackColor = True
        Me.BtnOK.AppearancePressed.Options.UseBorderColor = True
        Me.BtnOK.AppearancePressed.Options.UseFont = True
        Me.BtnOK.AppearancePressed.Options.UseForeColor = True
        Me.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.ImageOptions.SvgImage = CType(resources.GetObject("BtnOK.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnOK.Location = New System.Drawing.Point(75, 240)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(140, 40)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "Đăng nhập"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Location = New System.Drawing.Point(75, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 1)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Location = New System.Drawing.Point(76, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 1)
        Me.Panel1.TabIndex = 10
        '
        'FrmUsersLogIn
        '
        Me.AcceptButton = Me.BtnOK
        Me.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.PnLogo)
        Me.Controls.Add(Me.PnDetail)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsersLogIn"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.PnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnLogo.ResumeLayout(False)
        CType(Me.PicLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnDetail.ResumeLayout(False)
        Me.PnDetail.PerformLayout()
        CType(Me.TxtPassWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnLogo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PnDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtPassWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LinkLostPass As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LblTitle As DevExpress.XtraEditors.LabelControl
    Private WithEvents PicLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
