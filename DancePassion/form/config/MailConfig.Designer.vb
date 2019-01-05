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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mailconfigfrm))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.ctrMailconfigServer = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigPort = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigUser = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigPwd = New System.Windows.Forms.TextBox()
        Me.ctrMailconfigVdefault = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.ctrMailconfigKey = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        CType(Me.ctrMailconfigVdefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrMailconfigSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctrMailconfigServer
        '
        resources.ApplyResources(Me.ctrMailconfigServer, "ctrMailconfigServer")
        Me.ctrMailconfigServer.Name = "ctrMailconfigServer"
        '
        'ctrMailconfigPort
        '
        resources.ApplyResources(Me.ctrMailconfigPort, "ctrMailconfigPort")
        Me.ctrMailconfigPort.Name = "ctrMailconfigPort"
        '
        'ctrMailconfigUser
        '
        resources.ApplyResources(Me.ctrMailconfigUser, "ctrMailconfigUser")
        Me.ctrMailconfigUser.Name = "ctrMailconfigUser"
        '
        'ctrMailconfigPwd
        '
        resources.ApplyResources(Me.ctrMailconfigPwd, "ctrMailconfigPwd")
        Me.ctrMailconfigPwd.Name = "ctrMailconfigPwd"
        Me.ctrMailconfigPwd.UseSystemPasswordChar = True
        '
        'ctrMailconfigVdefault
        '
        resources.ApplyResources(Me.ctrMailconfigVdefault, "ctrMailconfigVdefault")
        Me.ctrMailconfigVdefault.Name = "ctrMailconfigVdefault"
        Me.ctrMailconfigVdefault.Properties.AccessibleDescription = resources.GetString("ctrMailconfigVdefault.Properties.AccessibleDescription")
        Me.ctrMailconfigVdefault.Properties.AccessibleName = resources.GetString("ctrMailconfigVdefault.Properties.AccessibleName")
        Me.ctrMailconfigVdefault.Properties.AutoHeight = CType(resources.GetObject("ctrMailconfigVdefault.Properties.AutoHeight"), Boolean)
        Me.ctrMailconfigVdefault.Properties.Caption = resources.GetString("ctrMailconfigVdefault.Properties.Caption")
        Me.ctrMailconfigVdefault.Properties.DisplayValueChecked = resources.GetString("ctrMailconfigVdefault.Properties.DisplayValueChecked")
        Me.ctrMailconfigVdefault.Properties.DisplayValueGrayed = resources.GetString("ctrMailconfigVdefault.Properties.DisplayValueGrayed")
        Me.ctrMailconfigVdefault.Properties.DisplayValueUnchecked = resources.GetString("ctrMailconfigVdefault.Properties.DisplayValueUnchecked")
        Me.ctrMailconfigVdefault.Properties.GlyphVerticalAlignment = CType(resources.GetObject("ctrMailconfigVdefault.Properties.GlyphVerticalAlignment"), DevExpress.Utils.VertAlignment)
        '
        'ctrMailconfigSSL
        '
        resources.ApplyResources(Me.ctrMailconfigSSL, "ctrMailconfigSSL")
        Me.ctrMailconfigSSL.Name = "ctrMailconfigSSL"
        Me.ctrMailconfigSSL.Properties.AccessibleDescription = resources.GetString("ctrMailconfigSSL.Properties.AccessibleDescription")
        Me.ctrMailconfigSSL.Properties.AccessibleName = resources.GetString("ctrMailconfigSSL.Properties.AccessibleName")
        Me.ctrMailconfigSSL.Properties.AutoHeight = CType(resources.GetObject("ctrMailconfigSSL.Properties.AutoHeight"), Boolean)
        Me.ctrMailconfigSSL.Properties.Caption = resources.GetString("ctrMailconfigSSL.Properties.Caption")
        Me.ctrMailconfigSSL.Properties.DisplayValueChecked = resources.GetString("ctrMailconfigSSL.Properties.DisplayValueChecked")
        Me.ctrMailconfigSSL.Properties.DisplayValueGrayed = resources.GetString("ctrMailconfigSSL.Properties.DisplayValueGrayed")
        Me.ctrMailconfigSSL.Properties.DisplayValueUnchecked = resources.GetString("ctrMailconfigSSL.Properties.DisplayValueUnchecked")
        Me.ctrMailconfigSSL.Properties.GlyphVerticalAlignment = CType(resources.GetObject("ctrMailconfigSSL.Properties.GlyphVerticalAlignment"), DevExpress.Utils.VertAlignment)
        '
        'ctrMailconfigKey
        '
        resources.ApplyResources(Me.ctrMailconfigKey, "ctrMailconfigKey")
        Me.ctrMailconfigKey.Name = "ctrMailconfigKey"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Appearance.Font = CType(resources.GetObject("LabelControl1.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl1.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl1.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl1.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl1.Appearance.GradientMode = CType(resources.GetObject("LabelControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.ShowToolTips = False
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl2.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl2.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl2.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl2.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl2.Appearance.GradientMode = CType(resources.GetObject("LabelControl2.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.ShowToolTips = False
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Appearance.Font = CType(resources.GetObject("LabelControl3.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl3.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl3.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl3.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl3.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl3.Appearance.GradientMode = CType(resources.GetObject("LabelControl3.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl3.Appearance.Image = CType(resources.GetObject("LabelControl3.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.ShowToolTips = False
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl4.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl4.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl4.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl4.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl4.Appearance.GradientMode = CType(resources.GetObject("LabelControl4.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl4.Appearance.Image = CType(resources.GetObject("LabelControl4.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.ShowToolTips = False
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.Font = CType(resources.GetObject("LabelControl5.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl5.Appearance.FontSizeDelta = CType(resources.GetObject("LabelControl5.Appearance.FontSizeDelta"), Integer)
        Me.LabelControl5.Appearance.FontStyleDelta = CType(resources.GetObject("LabelControl5.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.LabelControl5.Appearance.GradientMode = CType(resources.GetObject("LabelControl5.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.LabelControl5.Appearance.Image = CType(resources.GetObject("LabelControl5.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.ShowToolTips = False
        '
        'WindowsUIButtonPanel1
        '
        resources.ApplyResources(Me.WindowsUIButtonPanel1, "WindowsUIButtonPanel1")
        WindowsUIButtonImageOptions1.EnableTransparency = True
        WindowsUIButtonImageOptions1.Image = Global.DancePassion.My.Resources.Resources.Data_add_WF
        resources.ApplyResources(WindowsUIButtonImageOptions1, "WindowsUIButtonImageOptions1")
        WindowsUIButtonImageOptions2.EnableTransparency = True
        WindowsUIButtonImageOptions2.Image = Global.DancePassion.My.Resources.Resources.Data_delete_WF
        resources.ApplyResources(WindowsUIButtonImageOptions2, "WindowsUIButtonImageOptions2")
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("WindowsUIButtonPanel1.Buttons"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons1"), Boolean), WindowsUIButtonImageOptions1, CType(resources.GetObject("WindowsUIButtonPanel1.Buttons2"), DevExpress.XtraBars.Docking2010.ButtonStyle), resources.GetString("WindowsUIButtonPanel1.Buttons3"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons4"), Integer), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons5"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons6"), DevExpress.Utils.SuperToolTip), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons7"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons8"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons9"), Boolean), resources.GetString("WindowsUIButtonPanel1.Buttons10"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons11"), Integer), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons12"), Boolean)), New DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("WindowsUIButtonPanel1.Buttons13"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons14"), Boolean), WindowsUIButtonImageOptions2, CType(resources.GetObject("WindowsUIButtonPanel1.Buttons15"), DevExpress.XtraBars.Docking2010.ButtonStyle), resources.GetString("WindowsUIButtonPanel1.Buttons16"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons17"), Integer), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons18"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons19"), DevExpress.Utils.SuperToolTip), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons20"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons21"), Boolean), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons22"), Boolean), resources.GetString("WindowsUIButtonPanel1.Buttons23"), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons24"), Integer), CType(resources.GetObject("WindowsUIButtonPanel1.Buttons25"), Boolean))})
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        '
        'Mailconfigfrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ctrMailconfigKey)
        Me.Controls.Add(Me.ctrMailconfigSSL)
        Me.Controls.Add(Me.ctrMailconfigVdefault)
        Me.Controls.Add(Me.ctrMailconfigPwd)
        Me.Controls.Add(Me.ctrMailconfigUser)
        Me.Controls.Add(Me.ctrMailconfigPort)
        Me.Controls.Add(Me.ctrMailconfigServer)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "Mailconfigfrm"
        Me.ShowIcon = False
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
    Friend WithEvents ctrMailconfigKey As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
