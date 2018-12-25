Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim tb As DataTable
        Dim svr As New MYSQLSERVER
        tb = svr.Get_Table("select * from product_type")
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
