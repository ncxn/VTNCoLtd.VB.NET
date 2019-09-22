Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen

Public Class UcEvents_Update
    Private _cModel As EventsDTO

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

    Public Property CModel As EventsDTO
        Get
            Return _cModel
        End Get
        Set(value As EventsDTO)
            _cModel = value
        End Set
    End Property

#Region " Form"

    Sub OK() Handles BtnOK.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsEvents.GetInstance.Update(GetModel()) Then
            If RemoveTab IsNot Nothing Then
                RemoveTab()
            End If
        End If
        SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Sub OKAndNew() Handles BtnOKANDNEW.ItemClick
        Dim handle = SplashScreenManager.ShowOverlayForm(Me)
        If ClsEvents.GetInstance.Insert(GetModel()) Then
            Reset()
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

    Sub LoadData() Handles Me.Load
        TxtEvent_Type_Id.EditValue = CModel.Event_Type_Id
        TxtEvent_Name.Text = CModel.Event_Name
        TxtEvent_Start_Date.EditValue = CModel.Event_Start_Date
        TxtEvent_End_Date.EditValue = CModel.Event_End_Date
        TxtEvent_Participant_Max.EditValue = CModel.Event_Participant_Max
        ' Định dạng số
        TxtEvent_Participant_Max.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        TxtEvent_Participant_Max.Properties.Mask.EditMask = "N0"
        TxtEvent_Participant_Max.Properties.Mask.UseMaskAsDisplayFormat = True

        AddLookUpEdit()
    End Sub

    Private Function GetModel() As EventsDTO

        Dim Model As New EventsDTO

        If ValidateData() Then
            With Model
                .Event_Id = CModel.Event_Id
                .Event_Type_Id = TxtEvent_Type_Id.EditValue
                .Event_Name = TxtEvent_Name.Text
                .Event_Start_Date = TxtEvent_Start_Date.EditValue
                .Event_End_Date = TxtEvent_End_Date.EditValue
                .Event_Participant_Max = TxtEvent_Participant_Max.EditValue
            End With
        End If

        Return Model

    End Function

    Private Sub AddLookUpEdit()
        TxtEvent_Type_Id.Properties.DataSource = ClsEvent_Type.GetInstance.GetList()
        TxtEvent_Type_Id.Properties.ValueMember = "Event_Type_Id"
        TxtEvent_Type_Id.Properties.DisplayMember = "Event_Type_Name"
        TxtEvent_Type_Id.Properties.PopulateViewColumns()
        TxtEvent_Type_Id.Properties.View.Columns(0).Caption = "Mã"
        TxtEvent_Type_Id.Properties.View.Columns(1).Caption = "Tên"
        TxtEvent_Type_Id.Properties.View.Columns(2).Caption = "Mô tả"

        TxtEvent_Start_Date.Properties.VistaDisplayMode = True
        TxtEvent_Start_Date.Properties.VistaEditTime = True
    End Sub

#End Region

#Region " Kiểm tra dữ liệu"

    ''' <summary>
    ''' Validating data input; event name must not empty
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateData() As Boolean
        Return Not String.IsNullOrEmpty(TxtEvent_Name.Text)
    End Function

    ''' <summary>
    ''' Check if Id of Type is Interger
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtEvent_Type_Id_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_Type_Id.Validating
        Dim result As Integer
        If Not Integer.TryParse(TxtEvent_Type_Id.EditValue, result) Then
            e.Cancel = True
            TxtEvent_Type_Id.ErrorText = "Hãy chọn từ danh sách để đảm bảo dữ liệu đúng"
        End If
    End Sub

    ''' <summary>
    ''' Check if Id of Type is Interger
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtEvent_Participant_Max_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_Participant_Max.Validating
        Dim result As Integer
        If Not Integer.TryParse(TxtEvent_Participant_Max.EditValue, result) Then
            e.Cancel = True
            TxtEvent_Participant_Max.ErrorText = "Số khách dự kiến phải là số tự nhiên"
        End If
    End Sub

    ''' <summary>
    ''' Data type and date must be after today!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtEvent_Start_Date_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_Start_Date.Validating
        Dim currentValue As DateTime = CType(sender, DevExpress.XtraEditors.DateEdit).DateTime
        If currentValue < Now() Then
            TxtEvent_Start_Date.ErrorText = "Ngày phải sau hôm nay!"
        End If
    End Sub

    ''' <summary>
    ''' Data type and date must be after start date!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtEvent_End_Date_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_End_Date.Validating
        Dim currentValue As DateTime = CType(sender, DevExpress.XtraEditors.DateEdit).DateTime
        If currentValue < TxtEvent_Start_Date.EditValue Then
            TxtEvent_End_Date.ErrorText = "Ngày kết thúc phải sau Ngày bắt đầu!"
        End If
    End Sub

    'Private Sub TxtEvent_Participant_Max_ParseEditValue(sender As Object, e As ConvertEditValueEventArgs) Handles TxtEvent_Participant_Max.ParseEditValue
    '    TxtEvent_Participant_Max.Properties.Mask.EditMask = "N0"
    '    TxtEvent_Participant_Max.Properties.Mask.UseMaskAsDisplayFormat = True
    'End Sub

#End Region

End Class
