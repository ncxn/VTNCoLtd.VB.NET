<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUsersManager
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
    'UserControl overrides dispose to clean up the component list.
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
        Me.GrdUsers = New DevExpress.XtraGrid.GridControl()
        Me.GrvUsers = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GrdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 447)
        '
        'GrdUsers
        '
        Me.GrdUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdUsers.Location = New System.Drawing.Point(0, 239)
        Me.GrdUsers.MainView = Me.GrvUsers
        Me.GrdUsers.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdUsers.Name = "GrdUsers"
        Me.GrdUsers.Size = New System.Drawing.Size(827, 208)
        Me.GrdUsers.TabIndex = 1
        Me.GrdUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvUsers})
        '
        'GrvUsers
        '
        Me.GrvUsers.GridControl = Me.GrdUsers
        Me.GrvUsers.Name = "GrvUsers"
        Me.GrvUsers.OptionsView.ShowGroupPanel = False
        '
        'UcUsersManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdUsers)
        Me.Name = "UcUsersManager"
        Me.Size = New System.Drawing.Size(827, 487)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdUsers, 0)
        CType(Me.GrdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvUsers As DevExpress.XtraGrid.Views.Grid.GridView
End Class
