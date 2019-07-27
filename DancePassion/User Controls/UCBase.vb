Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Public Class UcBase
    Public AddDocs As ClsDelegate.AddTab
    Public RemoveTab As ClsDelegate.RemoveTab
    Public HidePageGroup As New ClsDelegate.HideGroup(AddressOf HideEmptyGroups)
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

    Private Function IsVisible(ByVal itemLink As BarItemLink) As Boolean
        Return (itemLink.Item.Visibility = BarItemVisibility.Always OrElse itemLink.Item.Visibility = BarItemVisibility.OnlyInRuntime) AndAlso itemLink.Visible
    End Function

    Private Sub HideEmptyGroups(Controls As String, ObjControlsAccess As ControlsAccessCollection)

        Dim listAccess As List(Of String) = ClsControlsAccess.GetInstance.GetAccessByControls(Controls, ObjControlsAccess)

        For Each pag As RibbonPage In BaseRibbon.Pages

            For Each pagGroup As RibbonPageGroup In pag.Groups
                Dim VisibleAll As Boolean = False

                For Each itemLink As BarItemLink In pagGroup.ItemLinks
                    'Set control
                    If listAccess.Contains(itemLink.Item.Name.ToString) Then
                        itemLink.Item.Visibility = BarItemVisibility.Always
                    Else
                        itemLink.Item.Visibility = BarItemVisibility.Never
                    End If
                    'Check control
                    If IsVisible(itemLink) Then
                        VisibleAll = True
                        Continue For
                    End If
                Next

                If Not VisibleAll Then pagGroup.Visible = VisibleAll
            Next
        Next
    End Sub
#End Region

End Class
