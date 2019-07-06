Imports DevExpress.XtraBars.Ribbon

Public Class UCBase
#Region " Khởi tạo"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region " Ribbon"
    Public ReadOnly Property BaseRibbon() As RibbonControl
        Get
            Return RibbonControlBaseOnUserControl
        End Get
    End Property
#End Region
End Class
