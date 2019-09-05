<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcEmailManager
    Inherits UcBase

    'UserControl overrides dispose to clean up the component list.
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
        Me.GrdEmailManager = New DevExpress.XtraGrid.GridControl()
        Me.GrvEmailManager = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GrdEmailManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvEmailManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 410)
        '
        'GrdEmailManager
        '
        Me.GrdEmailManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdEmailManager.Location = New System.Drawing.Point(0, 239)
        Me.GrdEmailManager.MainView = Me.GrvEmailManager
        Me.GrdEmailManager.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdEmailManager.Name = "GrdEmailManager"
        Me.GrdEmailManager.Size = New System.Drawing.Size(724, 171)
        Me.GrdEmailManager.TabIndex = 2
        Me.GrdEmailManager.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvEmailManager})
        '
        'GrvEmailManager
        '
        Me.GrvEmailManager.GridControl = Me.GrdEmailManager
        Me.GrvEmailManager.Name = "GrvEmailManager"
        Me.GrvEmailManager.OptionsView.ShowGroupPanel = False
        '
        'UcEmailManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdEmailManager)
        Me.Name = "UcEmailManager"
        Me.Size = New System.Drawing.Size(724, 450)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdEmailManager, 0)
        CType(Me.GrdEmailManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvEmailManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdEmailManager As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvEmailManager As DevExpress.XtraGrid.Views.Grid.GridView
End Class
