<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSconfig
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.SuspendLayout()
        '
        'WindowsUIButtonPanel1
        '
        WindowsUIButtonImageOptions1.EnableTransparency = True
        WindowsUIButtonImageOptions1.Image = Global.DancePassion.My.Resources.Resources.Data_add_WF
        WindowsUIButtonImageOptions2.Image = Global.DancePassion.My.Resources.Resources.Data_delete_WF
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Add", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Del", -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.WindowsUIButtonPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(350, 89)
        Me.WindowsUIButtonPanel1.TabIndex = 0
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'SMSconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 348)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SMSconfig"
        Me.Text = "Cấu hình SMS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
