Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim tb As DataTable
        Dim svr As New MYSQLSERVER
        tb = svr.Get_tb("select * from event")
        ' Add any initialization after the InitializeComponent() call.
        Setting.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
