Imports VTNcoLtd.BUS

Public Class UcEmailManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region " Form"

    Private Sub UcEmailManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
#End Region

#Region " Xử lý dữ liệu"
    Private Sub LoadData()
        GrdEmailManager.DataSource = ClsMailServer.GetInstance.GetDataTable()
    End Sub

#End Region
End Class
