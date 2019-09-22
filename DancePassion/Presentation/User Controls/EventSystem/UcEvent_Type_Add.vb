Imports DevExpress.XtraSplashScreen

Public Class UcEvent_Type_Add
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Form"

    Private Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        UpdateDB()
        SplashScreenManager.CloseOverlayForm(handle)
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

    Private Sub OKandNew() Handles BtnOKANDNEW.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        UpdateDB()
        SplashScreenManager.CloseOverlayForm(handle)
        ResetData()
    End Sub

    Private Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liêu"

    Private Sub ResetData()
        TxtEvent_Type_Name.Text = String.Empty
        TxtEvent_Type_Desc.Text = String.Empty
    End Sub

    Private Sub UpdateDB()
        If ValidateData() Then
            If ClsEvent_Type.GetInstance.Insert(GetModel()) Then
                MessageBox.Show("Thành công")
            End If
        Else
            MessageBox.Show("Kiểm tra dữ liệu nhập vào")
        End If
    End Sub

    Private Function GetModel() As Event_TypeDTO
        Dim Model As New Event_TypeDTO With {
            .Event_Type_Id = 0,
            .Event_Type_Name = TxtEvent_Type_Name.Text,
            .Event_Type_Desc = If(TxtEvent_Type_Desc.Text, String.Empty)
        }

        Return Model

    End Function

    Private Function ValidateData() As Boolean
        Return Not String.IsNullOrEmpty(TxtEvent_Type_Name.Text)
    End Function

#End Region
End Class
