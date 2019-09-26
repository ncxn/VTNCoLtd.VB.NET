<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcMenuBar
    'Inherits System.Windows.Forms.UserControl
    Inherits DevExpress.XtraEditors.XtraUserControl
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
        Me.MainMenu = New DevExpress.XtraBars.Bar()
        Me.MenuBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        CType(Me.MenuBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BarName = "MainMenu"
        Me.MainMenu.DockCol = 0
        Me.MainMenu.DockRow = 0
        Me.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainMenu.OptionsBar.MultiLine = True
        Me.MainMenu.OptionsBar.UseWholeRow = True
        Me.MainMenu.Text = "Custom 2"
        '
        'MenuBarManager
        '
        Me.MenuBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.MenuBarManager.DockControls.Add(Me.barDockControlTop)
        Me.MenuBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.MenuBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.MenuBarManager.DockControls.Add(Me.barDockControlRight)
        Me.MenuBarManager.Form = Me
        Me.MenuBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3})
        Me.MenuBarManager.MainMenu = Me.Bar2
        Me.MenuBarManager.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.MenuBarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(932, 35)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 59)
        Me.barDockControlBottom.Manager = Me.MenuBarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(932, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
        Me.barDockControlLeft.Manager = Me.MenuBarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 24)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(932, 35)
        Me.barDockControlRight.Manager = Me.MenuBarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 24)
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Config"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Module One"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Module Two"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'UcMenuBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UcMenuBar"
        Me.Size = New System.Drawing.Size(932, 59)
        CType(Me.MenuBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As DevExpress.XtraBars.Bar
    Friend WithEvents MenuBarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
