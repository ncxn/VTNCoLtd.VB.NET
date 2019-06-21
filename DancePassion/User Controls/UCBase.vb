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
    Public ReadOnly Property Ribbon() As RibbonControl
        Get
            Return RibbonControlBaseOnUserControl
        End Get
    End Property
    Sub test()
        BtnOK.Visibility = BarItemVisibility.Never
    End Sub

#Region " Định nghĩa thuộc tính"

    Public Property BtnOK_ As Boolean
        Set(ByVal value As Boolean)
            If BtnOK.Visibility = BarItemVisibility.Always Then
                value = True
            Else
                value = False
            End If
        End Set
        Get
            Return BtnOK_
        End Get
    End Property
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
