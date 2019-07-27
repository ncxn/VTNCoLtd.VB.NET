<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcControlsAccessManager
    'Inherits System.Windows.Forms.UserControl
    Inherits UcBase
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
        Me.GrdControls = New DevExpress.XtraGrid.GridControl()
        Me.GrvControls = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ChkAccess = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LblAccessHeader = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ChkAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblAccessHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseStatusBar
        '
        Me.BaseStatusBar.Location = New System.Drawing.Point(0, 481)
        '
        'GrdControls
        '
        Me.GrdControls.Location = New System.Drawing.Point(12, 12)
        Me.GrdControls.MainView = Me.GrvControls
        Me.GrdControls.MenuManager = Me.RibbonControlBaseOnUserControl
        Me.GrdControls.Name = "GrdControls"
        Me.GrdControls.Size = New System.Drawing.Size(470, 218)
        Me.GrdControls.TabIndex = 2
        Me.GrdControls.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrvControls})
        '
        'GrvControls
        '
        Me.GrvControls.GridControl = Me.GrdControls
        Me.GrvControls.Name = "GrvControls"
        Me.GrvControls.OptionsBehavior.ReadOnly = True
        Me.GrvControls.OptionsView.ShowGroupPanel = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChkAccess)
        Me.LayoutControl1.Controls.Add(Me.GrdControls)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(827, 242)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ChkAccess
        '
        Me.ChkAccess.Location = New System.Drawing.Point(501, 49)
        Me.ChkAccess.MultiColumn = True
        Me.ChkAccess.Name = "ChkAccess"
        Me.ChkAccess.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ChkAccess.Size = New System.Drawing.Size(314, 181)
        Me.ChkAccess.StyleController = Me.LayoutControl1
        Me.ChkAccess.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LblAccessHeader, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(827, 242)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GrdControls
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(474, 222)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChkAccess
        Me.LayoutControlItem2.Location = New System.Drawing.Point(489, 37)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(318, 185)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LblAccessHeader
        '
        Me.LblAccessHeader.AllowHotTrack = False
        Me.LblAccessHeader.AppearanceItemCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblAccessHeader.AppearanceItemCaption.Options.UseBorderColor = True
        Me.LblAccessHeader.Location = New System.Drawing.Point(511, 0)
        Me.LblAccessHeader.Name = "LblAccessHeader"
        Me.LblAccessHeader.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
        Me.LblAccessHeader.Size = New System.Drawing.Size(296, 37)
        Me.LblAccessHeader.Text = "Chọn chức năng"
        Me.LblAccessHeader.TextSize = New System.Drawing.Size(103, 17)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(474, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(15, 222)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'UcControlsAccessManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcControlsAccessManager"
        Me.Size = New System.Drawing.Size(827, 521)
        Me.Controls.SetChildIndex(Me.BaseStatusBar, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.GrdControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrvControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ChkAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblAccessHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdControls As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrvControls As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChkAccess As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LblAccessHeader As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
