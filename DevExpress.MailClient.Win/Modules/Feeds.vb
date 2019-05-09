Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports System.ServiceModel.Syndication
Imports DevExpress.MailClient.Win.Controls
Imports DevExpress.XtraNavBar
Imports DevExpress.Utils.Text
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.MailClient.Win.Forms
Imports System.Threading
Imports System.ServiceModel.Web
Imports System.Diagnostics
Imports DevExpress.XtraRichEdit

Namespace DevExpress.MailClient.Win
    Partial Public Class Feeds
        Inherits BaseModule

        Private LastFeedFetchTime As Date = Date.MinValue
        Private ReadOnly FeedTTL As TimeSpan = TimeSpan.FromHours(2)
        Private FetchedFeeds As New Dictionary(Of String, SyndicationFeed)()
        Private activeViewCaption_Field As Boolean = False
        Private mainNavBar As NavBarControl = Nothing
        Public Overrides ReadOnly Property ModuleName() As String
            Get
                Return My.Resources.FeedsName
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            SetViewCaption()
        End Sub
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            UpdateButtons()
        End Sub
        Protected Friend Overrides ReadOnly Property CurrentRichEdit() As RichEditControl
            Get
                Return ucMailViewer1.RichEdit
            End Get
        End Property
        Protected Overrides ReadOnly Property Grid() As DevExpress.XtraGrid.GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Friend Overrides Sub InitModule(ByVal manager As DevExpress.Utils.Menu.IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            mainNavBar = TryCast(data, NavBarControl)
            InitNavBar(mainNavBar)
            ucMailViewer1.SetMenuManager(manager)
        End Sub
        Private Sub InitNavBar(ByVal navBar As NavBarControl)
            AddNavBarItem(My.Resources.FeedBlogs, My.Resources.FeedGroupDX, "http://community.devexpress.com/blogs/MainFeed.aspx", navBar)
            AddNavBarItem(My.Resources.FeedVideos, My.Resources.FeedGroupDX, "http://tv.devexpress.com/rss.ashx", navBar)
            AddNavBarItem(My.Resources.FeedWebinars, My.Resources.FeedGroupDX, "http://www.devexpress.com/rss/webinars/", navBar)
            AddNavBarItem(My.Resources.FeedNews, My.Resources.FeedGroupDX, "http://www.devexpress.com/rss/news/news20.xml", navBar)
            AddNavBarItem(My.Resources.FeedBBCNews, My.Resources.FeedGroupMisc, "http://www.bbc.co.uk/news/rss.xml", navBar)
            AddNavBarItem(My.Resources.FeedEngadget, My.Resources.FeedGroupMisc, "http://www.engadget.com/rss.xml", navBar)
            AddNavBarItem(My.Resources.FeedStackOverflow, My.Resources.FeedGroupMisc, "http://stackoverflow.com/feeds/tag?tagnames=devexpress&sort=newest", navBar)
            AddHandler navBar.LinkPressed, AddressOf FeedNavBar_LinkPressed
            mainNavBar.SelectedLink = Nothing
            UpdateSelectedLinkData()
        End Sub
        Private Sub FeedNavBar_LinkPressed(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            Cursor.Current = Cursors.WaitCursor
            Try
                partName_Field = e.Link.Item.Caption
                LoadFeedToGrid(GetFeed(e.Link.Item))
                UpdateCurrentRecord()
            Finally
                Cursor.Current = Cursors.Default
            End Try
        End Sub
        Private Sub AddNavBarItem(ByVal name As String, ByVal groupName As String, ByVal link As String, ByVal navBar As NavBarControl)
            Dim group As NavBarGroup = NavBarHelper.GetGroupByName(groupName, navBar)
            Dim item As New NavBarItem(name)
            NavBarHelper.SetNavBarItemImage(item, link)
            group.ItemLinks.Add(item)
            group.Expanded = True
            item.Tag = link
        End Sub
        Private ReadOnly Property CurrentItem() As NavBarItem
            Get
                If mainNavBar.SelectedLink Is Nothing Then
                    Return Nothing
                End If
                Return mainNavBar.SelectedLink.Item
            End Get
        End Property
        Private ReadOnly Property CurrentUrl() As String
            Get
                If CurrentItem Is Nothing Then
                    Return String.Empty
                End If
                Return String.Format("{0}", CurrentItem.Tag)
            End Get
        End Property
        Private Function GetCurrentFeed() As SyndicationFeed
            If CurrentItem Is Nothing Then
                Return Nothing
            End If
            Return GetFeed(CurrentItem)
        End Function
        Private Function GetFeed(ByVal item As NavBarItem) As SyndicationFeed
            Dim key As String = item.Caption
            Try
                If (Not FetchedFeeds.ContainsKey(key)) OrElse Date.Now.Subtract(LastFeedFetchTime) > FeedTTL Then
                    Using reader As New XmlTextReader(String.Format("{0}", item.Tag))
                        Dim info As New FeedReaderInfo(reader)
                        Dim newThread As New Thread(New ParameterizedThreadStart(AddressOf LoadFeed))
                        newThread.Start(info)
                        newThread.Join(7000)
                        FetchedFeeds(key) = info.Feed
                        newThread.Abort()
                    End Using
                    LastFeedFetchTime = Date.Now
                End If
                Return FetchedFeeds(key)
            Catch
                Return Nothing
            End Try
        End Function
        Private Shared Sub LoadFeed(ByVal data As Object)
            Dim info As FeedReaderInfo = TryCast(data, FeedReaderInfo)
            Try
                info.Feed = SyndicationFeed.Load(info.Reader)
            Catch
                info.Feed = Nothing
            End Try
        End Sub
        Private Sub LoadFeedToGrid(ByVal currentFeed As SyndicationFeed)
            Dim data As System.Collections.IEnumerable = TryCast(SelectData(currentFeed), System.Collections.IEnumerable)
            If data IsNot Nothing Then
                gridControl1.DataSource = data.Cast(Of Object)().ToList()
                gridView1.OptionsView.ShowViewCaption = True
                SetViewCaption(currentFeed)
            Else
                ucMailViewer1.ClearInfo()
                gridView1.OptionsView.ShowViewCaption = False
                gridControl1.DataSource = Nothing
                gridView1.LayoutChanged()
            End If
            ShowInfo()
        End Sub
        Private Function SelectData(ByVal currentFeed As SyndicationFeed) As Object
            Try
                Return From i In currentFeed.Items
                       Where i.Summary IsNot Nothing AndAlso (Not i.Summary.Text.Contains("<object")) AndAlso (Not i.Summary.Text.Contains("<embed"))
                       Select New FeedItem() With {.ID = i.Id, .Date = i.PublishDate.DateTime, .From = GetCreator(currentFeed, i), .Title = i.Title.Text.Trim(), .Description = i.Summary.Text.TrimStart(), .Url = i.Links(0).Uri.AbsoluteUri}
            Catch
                Return Nothing
            End Try
        End Function
        Private Function GetCreator(ByVal feed As SyndicationFeed, ByVal item As SyndicationItem) As String
            If item.Authors.Count > 0 Then
                Return If(item.Authors(0).Name, item.Authors(0).Email)
            End If
            Dim creator = item.ElementExtensions.FirstOrDefault(Function(e) e.OuterName = "creator")
            If creator IsNot Nothing Then
                Return creator.GetReader().ReadInnerXml()
            End If
            Return feed.Title.Text
        End Function
        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            UpdateCurrentRecord()
        End Sub
        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
            UpdateCurrentRecord()
        End Sub
        Private Sub UpdateCurrentRecord()
            Dim current As FeedItem = TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), FeedItem)
            If current IsNot Nothing Then
                ucMailViewer1.ShowFeed(current, True)
            Else
                ucMailViewer1.ClearInfo()
            End If
        End Sub

        Private Sub gridView1_CustomDrawEmptyForeground(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles gridView1.CustomDrawEmptyForeground
            If Not gridView1.OptionsView.ShowViewCaption Then
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center
                e.Appearance.TextOptions.WordWrap = WordWrap.Wrap
                StringPainter.Default.DrawString(e.Cache, e.Appearance, String.Format(My.Resources.FeedError, CurrentUrl), e.Bounds)
            End If
        End Sub
        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
            Dim hInfo As GridHitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
            ActiveViewCaption = hInfo.HitTest = GridHitTest.ViewCaption
        End Sub
        Private Sub gridView1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.MouseLeave
            ActiveViewCaption = False
        End Sub
        Private Sub SetViewCaption()
            SetViewCaption(Nothing)
        End Sub
        Private Sub SetViewCaption(ByVal currentFeed As SyndicationFeed)
            If gridView1.OptionsView.ShowViewCaption Then
                Dim title As String = CurrentFeedTitle
                If currentFeed IsNot Nothing Then
                    title = currentFeed.Title.Text
                End If
                gridView1.ViewCaption = String.Format(My.Resources.FeedNote, title, ColorHelper.HtmlHyperLinkTextColor)
            End If
        End Sub
        Private ReadOnly Property CurrentFeedTitle() As String
            Get
                Dim feed As SyndicationFeed = GetCurrentFeed()
                If feed Is Nothing Then
                    Return String.Empty
                End If
                Dim ret As String = feed.Title.Text
                If ActiveViewCaption Then
                    ret = "<u>" & ret & "</u>"
                End If
                Return ret
            End Get
        End Property
        Private ReadOnly Property CurrentFeedLink() As String
            Get
                Dim feed As SyndicationFeed = GetCurrentFeed()
                If feed Is Nothing Then
                    Return String.Empty
                End If
                Return feed.Links(0).Uri.AbsoluteUri
            End Get
        End Property
        Private Property ActiveViewCaption() As Boolean
            Get
                Return activeViewCaption_Field
            End Get
            Set(ByVal value As Boolean)
                If activeViewCaption_Field = value Then
                    Return
                End If
                activeViewCaption_Field = value
                If activeViewCaption_Field Then
                    gridControl1.Cursor = Cursors.Hand
                Else
                    gridControl1.Cursor = Cursors.Default
                End If
                SetViewCaption()
            End Set
        End Property

        Private Sub gridControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseClick
            If ActiveViewCaption Then
                ObjectHelper.ShowWebSite(CurrentFeedLink)
            End If
        End Sub
        Protected Friend Overrides Sub ButtonClick(ByVal tag As String)
            Select Case tag
                Case TagResources.RotateLayout
                    layoutControl1.Root.RotateLayout()
                Case TagResources.FlipLayout
                    layoutControl1.Root.FlipLayout()
                Case TagResources.FeedDelete
                    DeleteSelectedFeed()
                Case TagResources.FeedEdit
                    EditCurrentFeedInfo()
                Case TagResources.FeedNew
                    AddNewFeedInfo()
                Case TagResources.FeedRefresh
                    If CurrentItem IsNot Nothing Then
                        If FetchedFeeds.ContainsKey(CurrentItem.Caption) Then
                            FetchedFeeds.Remove(CurrentItem.Caption)
                        End If
                        UpdateSelectedLinkData()
                    End If
            End Select
        End Sub
        Private Sub AddNewFeedInfo()
            Using frm As New frmFeed(DialogRole.[New], mainNavBar)
                If frm.ShowDialog(OwnerForm) = DialogResult.OK Then
                    If CurrentItem Is Nothing Then
                        Return
                    End If
                    FetchedFeeds.Remove(CurrentItem.Caption)
                    NavBarHelper.SetNavBarItemImage(CurrentItem, CurrentUrl)
                    UpdateSelectedLinkData()
                End If
            End Using
        End Sub
        Private Sub EditCurrentFeedInfo()
            If CurrentItem Is Nothing Then
                Return
            End If
            Dim frm As New frmFeed(DialogRole.Edit, mainNavBar)
            Dim key As String = CurrentItem.Caption
            Dim url As String = CurrentUrl
            If frm.ShowDialog(OwnerForm) = DialogResult.OK Then
                If url <> CurrentUrl OrElse key <> CurrentItem.Caption Then
                    FetchedFeeds.Remove(key)
                End If
                NavBarHelper.SetNavBarItemImage(CurrentItem, CurrentUrl)
                UpdateSelectedLinkData()
            End If
        End Sub
        Private Sub DeleteSelectedFeed()
            If CurrentItem Is Nothing Then
                Return
            End If
            mainNavBar.Items.Remove(CurrentItem)
            UpdateSelectedLinkData()
            NavBarHelper.DeleteEmptyGroup(mainNavBar)
        End Sub
        Private Sub UpdateSelectedLinkData()
            If CurrentItem Is Nothing Then
                mainNavBar.SelectedLink = NavBarHelper.GetFirstItem(mainNavBar)
            End If
            If mainNavBar.SelectedLink IsNot Nothing Then
                Cursor.Current = Cursors.WaitCursor
                partName_Field = mainNavBar.SelectedLink.Item.Caption
                LoadFeedToGrid(GetCurrentFeed())
                Cursor.Current = Cursors.Default
            Else
                partName_Field = String.Empty
            End If
            UpdateButtons()
            UpdateCurrentRecord()
        End Sub
        Private Sub UpdateButtons()
            Dim isFeedExist As Boolean = mainNavBar.SelectedLink IsNot Nothing
            If OwnerForm IsNot Nothing Then
                OwnerForm.EnableEditFeed(isFeedExist)
                OwnerForm.EnableLayoutButtons(isFeedExist)
            End If
            layoutControl1.Root.Visibility = If(isFeedExist, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
        End Sub
        Protected Overrides ReadOnly Property AllowZoomControl() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides Property ZoomFactor() As Single
            Get
                Return ucMailViewer1.ZoomFactor
            End Get
            Set(ByVal value As Single)
                ucMailViewer1.ZoomFactor = value
            End Set
        End Property
    End Class
End Namespace
