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
        Me.txtPassWord = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLostPass = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LinePw = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineUserName = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.PnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnLogo.SuspendLayout()
        CType(Me.PicLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnDetail.SuspendLayout()
        CType(Me.txtPassWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnLogo
        '
        Me.PnLogo.Appearance.BackColor = System.Drawing.Color.SkyBlue
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
        Me.PicLogo.Location = New System.Drawing.Point(0, 125)
        Me.PicLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Properties.AllowFocused = False
        Me.PicLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PicLogo.Properties.Appearance.Options.UseBackColor = True
        Me.PicLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PicLogo.Properties.ShowMenu = False
        Me.PicLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicLogo.Size = New System.Drawing.Size(150, 150)
        Me.PicLogo.TabIndex = 0
        '
        'PnDetail
        '
        Me.PnDetail.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PnDetail.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnDetail.Appearance.Options.UseBackColor = True
        Me.PnDetail.Appearance.Options.UseBorderColor = True
        Me.PnDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnDetail.Controls.Add(Me.txtPassWord)
        Me.PnDetail.Controls.Add(Me.txtUserName)
        Me.PnDetail.Controls.Add(Me.LblTitle)
        Me.PnDetail.Controls.Add(Me.LinkLostPass)
        Me.PnDetail.Controls.Add(Me.BtnCancel)
        Me.PnDetail.Controls.Add(Me.BtnOK)
        Me.PnDetail.Controls.Add(Me.ShapeContainer1)
        Me.PnDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnDetail.Location = New System.Drawing.Point(150, 0)
        Me.PnDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.PnDetail.Name = "PnDetail"
        Me.PnDetail.Size = New System.Drawing.Size(450, 400)
        Me.PnDetail.TabIndex = 7
        '
        'txtPassWord
        '
        Me.txtPassWord.EditValue = "Mật khẩu"
        Me.txtPassWord.Location = New System.Drawing.Point(75, 160)
        Me.txtPassWord.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPassWord.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWord.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtPassWord.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassWord.Properties.Appearance.Options.UseFont = True
        Me.txtPassWord.Properties.Appearance.Options.UseForeColor = True
        Me.txtPassWord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPassWord.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtPassWord.Size = New System.Drawing.Size(300, 40)
        Me.txtPassWord.TabIndex = 2
        '
        'txtUserName
        '
        Me.txtUserName.EditValue = "Tên đăng nhập"
        Me.txtUserName.Location = New System.Drawing.Point(75, 110)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUserName.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.txtUserName.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtUserName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUserName.Properties.Appearance.Options.UseBorderColor = True
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.Appearance.Options.UseForeColor = True
        Me.txtUserName.Properties.Appearance.Options.UseImage = True
        Me.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtUserName.Size = New System.Drawing.Size(300, 40)
        Me.txtUserName.TabIndex = 1
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
        Me.BtnCancel.AppearanceHovered.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.AppearanceHovered.Options.UseBackColor = True
        Me.BtnCancel.AppearanceHovered.Options.UseFont = True
        Me.BtnCancel.AppearanceHovered.Options.UseForeColor = True
        Me.BtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
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
        Me.BtnOK.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Appearance.Options.UseBackColor = True
        Me.BtnOK.Appearance.Options.UseFont = True
        Me.BtnOK.Appearance.Options.UseForeColor = True
        Me.BtnOK.AppearanceHovered.BackColor = System.Drawing.Color.Transparent
        Me.BtnOK.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.BtnOK.AppearanceHovered.Options.UseBackColor = True
        Me.BtnOK.AppearanceHovered.Options.UseFont = True
        Me.BtnOK.AppearanceHovered.Options.UseForeColor = True
        Me.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.ImageOptions.SvgImage = CType(resources.GetObject("BtnOK.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnOK.Location = New System.Drawing.Point(75, 240)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(140, 40)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "Đăng nhập"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LinePw, Me.LineUserName})
        Me.ShapeContainer1.Size = New System.Drawing.Size(450, 400)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LinePw
        '
        Me.LinePw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinePw.Name = "LinePw"
        Me.LinePw.X1 = 75
        Me.LinePw.X2 = 375
        Me.LinePw.Y1 = 200
        Me.LinePw.Y2 = 200
        '
        'LineUserName
        '
        Me.LineUserName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineUserName.Name = "LineUserName"
        Me.LineUserName.X1 = 75
        Me.LineUserName.X2 = 375
        Me.LineUserName.Y1 = 150
        Me.LineUserName.Y2 = 150
        '
        'FrmUsersLogIn
        '
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
        CType(Me.txtPassWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnLogo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PnDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPassWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LinkLostPass As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineUserName As PowerPacks.LineShape
    Friend WithEvents LblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LinePw As PowerPacks.LineShape
    Private WithEvents PicLogo As DevExpress.XtraEditors.PictureEdit
End Class
