Public Class UcControlUpdate
    Public CurrentRecord As ControlsDTO
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UcControlUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        TxtControls_name.Enabled = False
    End Sub
    Private Sub LoadData()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                TxtControls_name.Text = .Controls_name.ToString
                TxtControls_description.Text = .Controls_description.ToString
                TxtControls_parent.Text = .Controls_parent.ToString
                TxtControls_type.Text = .Controls_type.ToString
                TxtControls_sort.Text = .Controls_sort.ToString
            End With
        End If
    End Sub
#Region " Test Sub or Function"
    Private Sub Test()
        If CurrentRecord IsNot Nothing Then
            With CurrentRecord
                Debug.WriteLine(.Controls_name.ToString + " : " + .Controls_description.ToString)
            End With
        End If
    End Sub
#End Region
End Class
