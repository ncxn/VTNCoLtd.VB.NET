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
    Public Property CREAREVisible As Boolean
        Set(ByVal value As Boolean)
            _InsertVisible = value
            If value = True Then
                BtnCREATE.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnCREATE.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _InsertVisible
        End Get
    End Property

    Private _EditVisible As Boolean = True
    ''' <summary>
    ''' Ẩn hiện chức năng sửa dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property EDITVisible As Boolean
        Set(ByVal value As Boolean)
            _EditVisible = value
            If value = True Then
                BtnEDIT.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnEDIT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _EditVisible
        End Get
    End Property

    Private _DeleteVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng Xóa dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property DELETEVisible As Boolean
        Set(ByVal value As Boolean)
            _DeleteVisible = value
            If value = True Then
                BtnDELETE.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnDELETE.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _DeleteVisible
        End Get
    End Property

    Private _RefreshVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng Làm mới dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property REFRESHVisible As Boolean
        Set(ByVal value As Boolean)
            _RefreshVisible = value
            If value = True Then
                BtnREFRESH.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnREFRESH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _RefreshVisible
        End Get
    End Property

    Private _PrintVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng In(Print) dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property PRINTVisible As Boolean
        Set(ByVal value As Boolean)
            _PrintVisible = value
            If value = True Then
                BtnPRINT.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnPRINT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _PrintVisible
        End Get
    End Property

    Private _ExcelVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng Xuất dữ liệu ra excel
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property EXCELVisible As Boolean
        Set(ByVal value As Boolean)
            _ExcelVisible = value
            If value = True Then
                BtnEXCEL.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnEXCEL.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _ExcelVisible
        End Get
    End Property

    Private _EmailVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng gửi thư diện tử 
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property EMAILVisible As Boolean
        Set(ByVal value As Boolean)
            _EmailVisible = value
            If value = True Then
                BtnEMAIL.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnEMAIL.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _EmailVisible
        End Get
    End Property

    Private _OKVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng chấp nhận thay đổi dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property OKVisible As Boolean
        Set(ByVal value As Boolean)
            _OKVisible = value
            If value = True Then
                BtnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _OKVisible
        End Get
    End Property

    Private _OKAndNewVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng Chấp nhận và tiếp tục
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property OkAndNewVisible As Boolean
        Set(ByVal value As Boolean)
            _OKAndNewVisible = value
            If value = True Then
                BtnOKANDNEW.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnOKANDNEW.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _OKAndNewVisible
        End Get
    End Property

    Private _CancelVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng bỏ qua sự thay đổi dữ liệu
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property CANCELVisible As Boolean
        Set(ByVal value As Boolean)
            _CancelVisible = value
            If value = True Then
                BtnCANCEL.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                BtnCANCEL.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End Set
        Get
            Return _CancelVisible
        End Get
    End Property

    Private _ToolsVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng công cụ
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property ToolsVisible As Boolean
        Set(ByVal value As Boolean)
            _ToolsVisible = value
            If value = True Then
                RbpGCongCu.Visible = True
            Else
                RbpGCongCu.Visible = False
            End If
        End Set
        Get
            Return _ToolsVisible
        End Get
    End Property

    Private _ExtendVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng công cụ
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property ExtendVisible As Boolean
        Set(ByVal value As Boolean)
            _ExtendVisible = value
            If value = True Then
                RbpGMoRong.Visible = True
            Else
                RbpGMoRong.Visible = False
            End If
        End Set
        Get
            Return _ExtendVisible
        End Get
    End Property

    Private _ConfirmVisible As Boolean
    ''' <summary>
    ''' Ẩn hiện chức năng công cụ
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    <Category("ButonVisible")>
    <Browsable(True)>
    <Description("Thiết lập ẩn hiện chức năng trên form")>
    Public Property ConfirmVisible As Boolean
        Set(ByVal value As Boolean)
            _ConfirmVisible = value
            If value = True Then
                RbpGXacNhan.Visible = True
            Else
                RbpGXacNhan.Visible = False
            End If
        End Set
        Get
            Return _ConfirmVisible
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
