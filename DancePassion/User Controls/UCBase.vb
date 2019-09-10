Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Public Class UcBase
    Public AddDocs As New ClsDelegate.AddTab(AddressOf FrmMain.AddDocs)
    Public RemoveTab As New ClsDelegate.RemoveTab(AddressOf FrmMain.RemoveDocs)
    Public HasAccess As New ClsDelegate.CheckRole(AddressOf HasAccessOnControl)
    Public HasRoles As New ClsDelegate.CheckRole(AddressOf CheckRole)

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

#Region " Role and Controls"
    ''' <summary>
    ''' Check BarItemLink Is Visible
    ''' </summary>
    ''' <param name="itemLink"></param>
    ''' <returns>Boolean</returns>
    Private Function IsVisible(ByVal itemLink As BarItemLink) As Boolean
        Return (itemLink.Item.Visibility = BarItemVisibility.Always OrElse itemLink.Item.Visibility = BarItemVisibility.OnlyInRuntime) AndAlso itemLink.Visible
    End Function

    Private Sub HasAccessOnControl(Control As String)
        Dim listAccess As List(Of String) = ClsControlsAccess.GetInstance.GetAccessByControls(Control, CurrentControlsAccess.ControlsAccessColection)
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

    Private Sub CheckRole(Control As String)

        For Each pag As RibbonPage In BaseRibbon.Pages
            For Each pagGroup As RibbonPageGroup In pag.Groups
                Dim VisibleAll As Boolean = False
                For Each itemLink As BarItemLink In pagGroup.ItemLinks
                    'Set control
                    If itemLink.Item.Visibility = BarItemVisibility.Always Then
                        If ClsRoleManager.GetInstance.HasRoleOnUserControl(Control, itemLink.Item.Name.ToString) Then
                            itemLink.Item.Visibility = BarItemVisibility.Always
                        Else
                            itemLink.Item.Visibility = BarItemVisibility.Never
                        End If
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
