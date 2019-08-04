Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TransparencyKey = Color.Coral
        Me.BackColor = Color.Coral
        CirLoad.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CirLoad.Value += 1
        CirLoad.Text = CirLoad.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If CirLoad.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            FrmMain.Show()
            Me.Close()
        End If
    End Sub
End Class