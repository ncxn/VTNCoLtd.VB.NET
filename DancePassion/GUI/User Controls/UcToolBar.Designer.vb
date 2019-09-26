<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcToolBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.ToolsBar = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ToolBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarManager
        '
        Me.ToolBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.ToolsBar})
        Me.ToolBarManager.DockControls.Add(Me.barDockControlTop)
        Me.ToolBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.ToolBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.ToolBarManager.DockControls.Add(Me.barDockControlRight)
        Me.ToolBarManager.Form = Me
        Me.ToolBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.ToolBarManager.MaxItemId = 4
        '
        'ToolsBar
        '
        Me.ToolsBar.BarName = "ToolBar"
        Me.ToolsBar.DockCol = 0
        Me.ToolsBar.DockRow = 0
        Me.ToolsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ToolsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.ToolsBar.Text = "Tools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&New"
        Me.BarButtonItem1.Hint = "Add New"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.actions_add1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Edit"
        Me.BarButtonItem2.Hint = "Edit"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.actions_edit
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&Del"
        Me.BarButtonItem3.Hint = "Delete"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.actions_remove
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Refresh"
        Me.BarButtonItem4.Hint = "Refresh"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.resetlayoutoptions1
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.ToolBarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(673, 35)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 52)
        Me.barDockControlBottom.Manager = Me.ToolBarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(673, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
        Me.barDockControlLeft.Manager = Me.ToolBarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 17)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(673, 35)
        Me.barDockControlRight.Manager = Me.ToolBarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 17)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Refresh"
        Me.BarButtonItem5.Id = 3
        Me.BarButtonItem5.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.resetlayoutoptions1
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Refresh"
        Me.BarButtonItem6.Id = 3
        Me.BarButtonItem6.ImageOptions.SvgImage = Global.VTNcoLtd.My.Resources.Resources.resetlayoutoptions1
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'UcToolBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UcToolBar"
        Me.Size = New System.Drawing.Size(673, 52)
        CType(Me.ToolBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolBarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents ToolsBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
End Class
