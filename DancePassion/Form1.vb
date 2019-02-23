Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Setting.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click
        FlyoutPanel1.Controls.Add(FlyoutPanelControl1)
        FlyoutPanel1.Controls.Add(Label1)
        Label1.Text = "Ông nội mài nà"
        FlyoutPanel1.ShowPopup()
    End Sub
End Class
