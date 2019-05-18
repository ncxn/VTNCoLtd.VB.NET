Imports System.Threading

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")
    End Sub
End Class