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
        Me.GrdRoles = New DevExpress.XtraGrid.GridControl()
        Me.GrvRoles = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GrdRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 511)
        Me.BaseStatusBar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'GrdRoles
        '
        Me.GrdRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdRoles.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrdRoles.Location = New System.Drawing.Point(0, 262)
        Me.GrdRoles.MainView = Me.GrvRoles
        Me.GrdRoles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrdRoles.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdRoles.Name = "GrdRoles"
        Me.GrdRoles.Size = New System.Drawing.Size(931, 249)
        Me.GrdRoles.TabIndex = 1
        Me.GrdRoles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvRoles})
        '
        'GrvRoles
        '
        Me.GrvRoles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GrvRoles.DetailHeight = 432
        Me.GrvRoles.GridControl = Me.GrdRoles
        Me.GrvRoles.Name = "GrvRoles"
        Me.GrvRoles.OptionsView.ShowGroupPanel = False
        '
        'UcRolesManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdRoles)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "UcRolesManager"
        Me.Size = New System.Drawing.Size(931, 548)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdRoles, 0)
        CType(Me.GrdRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdRoles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvRoles As DevExpress.XtraGrid.Views.Grid.GridView
End Class
