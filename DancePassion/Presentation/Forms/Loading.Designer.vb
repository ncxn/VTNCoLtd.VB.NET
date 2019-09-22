<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PnLoading = New System.Windows.Forms.Panel()
        Me.CirLoad = New CircularProgressBar.CircularProgressBar()
        Me.PnLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 35
        '
        'Timer2
        '
        Me.Timer2.Interval = 35
        '
        'PnLoading
        '
        Me.PnLoading.BackColor = System.Drawing.Color.Transparent
        Me.PnLoading.Controls.Add(Me.CirLoad)
        Me.PnLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnLoading.Location = New System.Drawing.Point(0, 0)
        Me.PnLoading.Margin = New System.Windows.Forms.Padding(0)
        Me.PnLoading.Name = "PnLoading"
        Me.PnLoading.Size = New System.Drawing.Size(200, 200)
        Me.PnLoading.TabIndex = 1
        '
        'CirLoad
        '
        Me.CirLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CirLoad.AnimationSpeed = 500
        Me.CirLoad.BackColor = System.Drawing.Color.Transparent
        Me.CirLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CirLoad.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CirLoad.ForeColor = System.Drawing.Color.White
        Me.CirLoad.InnerColor = System.Drawing.Color.Red
        Me.CirLoad.InnerMargin = 0
        Me.CirLoad.InnerWidth = -1
        Me.CirLoad.Location = New System.Drawing.Point(0, 0)
        Me.CirLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.CirLoad.MarqueeAnimationSpeed = 2000
        Me.CirLoad.Name = "CirLoad"
        Me.CirLoad.OuterColor = System.Drawing.Color.Teal
        Me.CirLoad.OuterMargin = -100
        Me.CirLoad.OuterWidth = 99
        Me.CirLoad.ProgressColor = System.Drawing.Color.DeepSkyBlue
        Me.CirLoad.ProgressWidth = 100
        Me.CirLoad.SecondaryFont = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CirLoad.Size = New System.Drawing.Size(200, 200)
        Me.CirLoad.StartAngle = 0
        Me.CirLoad.Step = 1
        Me.CirLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.CirLoad.SubscriptColor = System.Drawing.Color.White
        Me.CirLoad.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CirLoad.SubscriptText = "%"
        Me.CirLoad.SuperscriptColor = System.Drawing.Color.Black
        Me.CirLoad.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CirLoad.SuperscriptText = ""
        Me.CirLoad.TabIndex = 0
        Me.CirLoad.Text = "0"
        Me.CirLoad.TextMargin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.CirLoad.Value = 68
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.Controls.Add(Me.PnLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.PnLoading.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PnLoading As Panel
    Friend WithEvents CirLoad As CircularProgressBar.CircularProgressBar
End Class
