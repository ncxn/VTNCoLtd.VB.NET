<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCControlsManager
    'Inherits DevExpress.XtraEditors.XtraUserControl
    Inherits UCBase
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GrdControls = New DevExpress.XtraGrid.GridControl()
        Me.GrvControls = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdControls
        '
        Me.GrdControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdControls.Location = New System.Drawing.Point(0, 239)
        Me.GrdControls.MainView = Me.GrvControls
        Me.GrdControls.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdControls.Name = "GrdControls"
        Me.GrdControls.Size = New System.Drawing.Size(827, 249)
        Me.GrdControls.TabIndex = 1
        Me.GrdControls.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvControls})
        '
        'GrvControls
        '
        Me.GrvControls.GridControl = Me.GrdControls
        Me.GrvControls.Name = "GrvControls"
        '
        'UCControlsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdControls)
        Me.Name = "UCControlsManager"
        Me.Size = New System.Drawing.Size(827, 488)
        Me.Controls.SetChildIndex(Me.GrdControls, 0)
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdControls As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvControls As DevExpress.XtraGrid.Views.Grid.GridView

End Class
