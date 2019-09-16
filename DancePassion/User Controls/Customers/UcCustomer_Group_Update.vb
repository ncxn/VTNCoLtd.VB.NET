Imports DancePassion
Imports DevExpress.XtraSplashScreen

Public Class UcCustomer_Group_Update
    Private _Cmodel As Customer_Group_DTO

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property Cmodel As Customer_Group_DTO
        Get
            Return _Cmodel
        End Get
        Set(value As Customer_Group_DTO)
            _Cmodel = value
        End Set
    End Property

#Region " Form"

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsCustomer_Group.GetInstance.Update(GetModel()) Then

        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub Cancel() Handles BtnCANCEL.ItemClick
        If RemoveTab IsNot Nothing Then
            RemoveTab()
        End If
    End Sub

#End Region

#Region " Xử lý dữ liệu"
    Private Function GetModel() As Customer_Group_DTO

        Dim Model As New Customer_Group_DTO

        If ValidateInput Then
            With Model
                .Customer_group_id = ""
                .Customer_group_name = ""
                .Customer_group_parent = ""
            End With
        End If

        Return Model
    End Function

    Private Function ValidateInput() As Boolean
        Throw New NotImplementedException()
    End Function


#End Region
End Class
