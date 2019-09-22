<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcEvent_Type_Manager
    'Inherits System.Windows.Forms.UserControl
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
        Me.Grd = New DevExpress.XtraGrid.GridControl()
        Me.Grv = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 413)
        '
        'Grd
        '
        Me.Grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grd.Location = New System.Drawing.Point(0, 239)
        Me.Grd.MainView = Me.Grv
        Me.Grd.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.Grd.Name = "Grd"
        Me.Grd.Size = New System.Drawing.Size(724, 174)
        Me.Grd.TabIndex = 2
        Me.Grd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grv})
        '
        'Grv
        '
        Me.Grv.GridControl = Me.Grd
        Me.Grv.Name = "Grv"
        Me.Grv.OptionsView.ShowGroupPanel = False
        '
        'UcEvent_Type_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Grd)
        Me.Name = "UcEvent_Type_Manager"
        Me.Size = New System.Drawing.Size(724, 453)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.Grd, 0)
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grd As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grv As DevExpress.XtraGrid.Views.Grid.GridView
End Class
