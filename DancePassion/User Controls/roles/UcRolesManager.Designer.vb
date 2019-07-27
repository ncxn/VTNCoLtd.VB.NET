<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRolesManager
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
        Me.GridControlRoles = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRoles = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControlRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlRoles
        '
        Me.GridControlRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlRoles.Location = New System.Drawing.Point(0, 239)
        Me.GridControlRoles.MainView = Me.GridViewRoles
        Me.GridControlRoles.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GridControlRoles.Name = "GridControlRoles"
        Me.GridControlRoles.Size = New System.Drawing.Size(827, 205)
        Me.GridControlRoles.TabIndex = 1
        Me.GridControlRoles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRoles})
        '
        'GridViewRoles
        '
        Me.GridViewRoles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridViewRoles.GridControl = Me.GridControlRoles
        Me.GridViewRoles.Name = "GridViewRoles"
        '
        'UCRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControlRoles)
        Me.Name = "UcRolesManager"
        Me.Size = New System.Drawing.Size(827, 444)
        Me.Controls.SetChildIndex(Me.GridControlRoles, 0)
        CType(Me.GridControlRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControlRoles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRoles As DevExpress.XtraGrid.Views.Grid.GridView
End Class
