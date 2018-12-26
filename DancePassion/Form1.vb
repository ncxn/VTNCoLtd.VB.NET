Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim tb As DataTable
        Dim svr As New MYSQLSERVER
        tb = svr.Get_tb("select * from product_type")
        ' Add any initialization after the InitializeComponent() call.
        WaitForm.Show()
    End Sub
End Class
