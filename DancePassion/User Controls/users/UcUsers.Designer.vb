<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUsers
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
        Me.GridControlUsers = New DevExpress.XtraGrid.GridControl()
        Me.GridViewUsers = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControlUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlUsers
        '
        Me.GridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlUsers.Location = New System.Drawing.Point(0, 239)
        Me.GridControlUsers.MainView = Me.GridViewUsers
        Me.GridControlUsers.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GridControlUsers.Name = "GridControlUsers"
        Me.GridControlUsers.Size = New System.Drawing.Size(827, 248)
        Me.GridControlUsers.TabIndex = 1
        Me.GridControlUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUsers})
        '
        'GridViewUsers
        '
        Me.GridViewUsers.GridControl = Me.GridControlUsers
        Me.GridViewUsers.Name = "GridViewUsers"
        '
        'UCUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControlUsers)
        Me.Name = "UCUsers"
        Me.Size = New System.Drawing.Size(827, 487)
        Me.Controls.SetChildIndex(Me.GridControlUsers, 0)
        CType(Me.GridControlUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControlUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewUsers As DevExpress.XtraGrid.Views.Grid.GridView
End Class
