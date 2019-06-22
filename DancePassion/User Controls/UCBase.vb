Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Public Class UCBase
#Region " Khởi tạo"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
    Public Enum DataMode
        Insert
        Edit
        View
    End Enum

#Region " Định nghĩa các sự kiện"
    ' Tạo một hàm ủy thác 
    Public Delegate Sub EventHandler()

    Public Event InsertEvent As EventHandler
    Public Event EditEvent As EventHandler
    Public Event DeleteEvent As EventHandler
    Public Event RefreshEvent As EventHandler

    Public Event OKEvent As EventHandler
    Public Event CancelEvent As EventHandler

    Public Event PrintEvent As EventHandler
    Public Event ReportEvent As EventHandler
    Public Event ExcelEvent As EventHandler

    Public Event CloseEvent As EventHandler

#End Region

#Region " Ribbon"
    Public ReadOnly Property Ribbon() As RibbonControl
        Get
            Return RibbonControlBaseOnUserControl
        End Get
    End Property
#End Region

#Region " Định nghĩa thuộc tính"
    ' Set properties

    Private _InsertVisible As Boolean = True
    ''' <summary>
    ''' Ẩn hiện chức năng thêm dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property InsertVisible As Boolean
        Set(ByVal value As Boolean)
            _InsertVisible = value
            If value = True Then
                BtnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _InsertVisible
        End Get
    End Property

    Private _EditVisible As Boolean = True
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property EditVisible As Boolean
        Set(ByVal value As Boolean)
            _EditVisible = value
            If value = True Then
                BtnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _EditVisible
        End Get
    End Property

    'Private _DeleteVisible As Boolean
    '<Category("ButonVisible")>
    '<Browsable(True)>
    '<Description("Thiết lập ẩn hiện chức năng trên form")>
    'Public Property DeleteVisible As Boolean
    '    Set(ByVal value As Boolean)
    '        _DeleteVisible = value
    '        If value = True Then
    '            BtnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    '        Else
    '            BtnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '        End If
    '    End Set
    '    Get
    '        Return _DeleteVisible
    '    End Get
    'End Property

    'Private _RefreshVisible As Boolean
    '<Category("ButonVisible")>
    '<Browsable(True)>
    '<Description("Thiết lập ẩn hiện chức năng trên form")>
    'Public Property RefreshVisible As Boolean
    '    Set(ByVal value As Boolean)
    '        _RefreshVisible = value
    '        If value = True Then
    '            BtnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    '        Else
    '            BtnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '        End If
    '    End Set
    '    Get
    '        Return _RefreshVisible
    '    End Get
    'End Property

#End Region
    'Public Sub EnableOrDisableButton(control As Control, action As Action, RoleToControls As Roles)
    '    For Each page In Ribbon.Pages

    '        If page.Name = "ribbonPage2" Then

    '            For Each group In page.Groups

    '                For Each link As BarItemLink In group.ItemLinks
    '                    link.Item.Enabled = False
    '                Next
    '            Next
    '        End If
    '    Next
    'End Sub
End Class
