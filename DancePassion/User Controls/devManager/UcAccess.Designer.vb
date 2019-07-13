<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcAccess
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GrdAccess = New DevExpress.XtraGrid.GridControl()
        Me.GrvAccess = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GrdAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 440)
        '
        'GrdAccess
        '
        Me.GrdAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdAccess.Location = New System.Drawing.Point(0, 239)
        Me.GrdAccess.MainView = Me.GrvAccess
        Me.GrdAccess.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdAccess.Name = "GrdAccess"
        Me.GrdAccess.Size = New System.Drawing.Size(827, 201)
        Me.GrdAccess.TabIndex = 2
        Me.GrdAccess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvAccess})
        '
        'GrvAccess
        '
        Me.GrvAccess.GridControl = Me.GrdAccess
        Me.GrvAccess.Name = "GrvAccess"
        '
        'UcAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrdAccess)
        Me.Name = "UcAccess"
        Me.Size = New System.Drawing.Size(827, 480)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.GrdAccess, 0)
        CType(Me.GrdAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdAccess As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvAccess As DevExpress.XtraGrid.Views.Grid.GridView
End Class
