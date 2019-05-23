Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucContactInfo
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucContactInfo))
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.teNotes = New DevExpress.XtraEditors.MemoEdit()
            Me.teAddress = New DevExpress.XtraEditors.TextEdit()
            Me.tePhone = New DevExpress.XtraEditors.TextEdit()
            Me.teEmail = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.teBirthDate = New DevExpress.XtraEditors.TextEdit()
            Me.lbName = New DevExpress.XtraEditors.LabelControl()
            Me.pePhoto = New DevExpress.MailClient.Win.PictureEditSimpleZoom()
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcMain
            '
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.teNotes)
            Me.lcMain.Controls.Add(Me.teAddress)
            Me.lcMain.Controls.Add(Me.tePhone)
            Me.lcMain.Controls.Add(Me.teEmail)
            Me.lcMain.Controls.Add(Me.teBirthDate)
            Me.lcMain.Controls.Add(Me.lbName)
            Me.lcMain.Controls.Add(Me.pePhoto)
            resources.ApplyResources(Me.lcMain, "lcMain")
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(669, 200, 450, 350)
            Me.lcMain.Root = Me.lcgMain
            '
            'teNotes
            '
            resources.ApplyResources(Me.teNotes, "teNotes")
            Me.teNotes.Name = "teNotes"
            Me.teNotes.Properties.ReadOnly = True
            '
            'teAddress
            '
            resources.ApplyResources(Me.teAddress, "teAddress")
            Me.teAddress.Name = "teAddress"
            Me.teAddress.Properties.ReadOnly = True
            '
            'tePhone
            '
            resources.ApplyResources(Me.tePhone, "tePhone")
            Me.tePhone.Name = "tePhone"
            Me.tePhone.Properties.ReadOnly = True
            '
            'teEmail
            '
            resources.ApplyResources(Me.teEmail, "teEmail")
            Me.teEmail.Name = "teEmail"
            Me.teEmail.Properties.ReadOnly = True
            '
            'teBirthDate
            '
            resources.ApplyResources(Me.teBirthDate, "teBirthDate")
            Me.teBirthDate.Name = "teBirthDate"
            Me.teBirthDate.Properties.ReadOnly = True
            '
            'lbName
            '
            Me.lbName.Appearance.Font = CType(resources.GetObject("lbName.Appearance.Font"), System.Drawing.Font)
            Me.lbName.Appearance.Options.UseFont = True
            resources.ApplyResources(Me.lbName, "lbName")
            Me.lbName.Name = "lbName"
            '
            'pePhoto
            '
            resources.ApplyResources(Me.pePhoto, "pePhoto")
            Me.pePhoto.Name = "pePhoto"
            Me.pePhoto.Properties.AllowFocused = False
            Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pePhoto.Properties.ReadOnly = True
            Me.pePhoto.Properties.ShowMenu = False
            Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            '
            'lcgMain
            '
            resources.ApplyResources(Me.lcgMain, "lcgMain")
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciPhoto, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1})
            Me.lcgMain.Name = "Root"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgMain.Size = New System.Drawing.Size(303, 519)
            Me.lcgMain.TextVisible = False
            '
            'lciPhoto
            '
            Me.lciPhoto.Control = Me.pePhoto
            resources.ApplyResources(Me.lciPhoto, "lciPhoto")
            Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
            Me.lciPhoto.Name = "lciPhoto"
            Me.lciPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 3, 0, 0)
            Me.lciPhoto.Size = New System.Drawing.Size(303, 223)
            Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPhoto.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.teBirthDate
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 254)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(303, 46)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(66, 17)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.teEmail
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 300)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(303, 46)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(66, 17)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.tePhone
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 346)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(303, 46)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(66, 17)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.teAddress
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 392)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(303, 67)
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(66, 17)
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.teNotes
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 459)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 0)
            Me.layoutControlItem6.Size = New System.Drawing.Size(303, 60)
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(66, 17)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.lbName
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 223)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(303, 31)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'ucContactInfo
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lcMain)
            Me.Name = "ucContactInfo"
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private lcMain As DevExpress.XtraLayout.LayoutControl
        Private WithEvents pePhoto As PictureEditSimpleZoom
        Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
        Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
        Private teAddress As XtraEditors.TextEdit
        Private tePhone As XtraEditors.TextEdit
        Private WithEvents teEmail As XtraEditors.HyperLinkEdit
        Private teBirthDate As XtraEditors.TextEdit
        Private lbName As XtraEditors.LabelControl
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private teNotes As XtraEditors.MemoEdit
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
    End Class
End Namespace
