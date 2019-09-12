

Imports System.ComponentModel

Public Class UcEvents_Add
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HasAccess(Me.Name)
    End Sub

#Region " Xử lý dữ liệu"

    'Sub AddLookupEdit()
    '    Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit With {
    '        .DataSource = ClsEvent_Type.GetInstance.GetList(),
    '        .ValueMember = "Event_Type_Id",
    '        .DisplayMember = "Event_Type_Desc"
    '    }
    '    edit.PopulateViewColumns()
    '    edit.View.Columns("Control_name").Caption = "Mã Control"
    '    edit.View.Columns("Control_description").Caption = "Mô tả"
    '    edit.View.Columns(2).Visible = False
    '    edit.View.Columns(3).Visible = False
    '    edit.View.Columns(4).Visible = False

    '    Grd.RepositoryItems.Add(edit)
    '    Grv.Columns("Cấp cha").ColumnEdit = edit
    'End Sub

    Sub AddLookupEdit() Handles Me.Load
        TxtEvent_Type_Id.Properties.DataSource = ClsEvent_Type.GetInstance.GetList()
        TxtEvent_Type_Id.Properties.ValueMember = "Event_Type_Id"
        TxtEvent_Type_Id.Properties.DisplayMember = "Event_Type_Name"

        TxtEvent_Start_Date.Properties.VistaDisplayMode = True
        TxtEvent_Start_Date.Properties.VistaEditTime = True
    End Sub


    Private Function GetModel() As EventsDTO

        'Dim SelectedRow = Grv.GetFocusedDataRow()
        Dim Model As New EventsDTO

        If ValidateData() Then
            With Model
                .Event_Id = 0 'autoInt
                .Event_Type_Id = TxtEvent_Type_Id.EditValue
                .Event_Name = TxtEvent_Name.Text
                .Event_Start_Date = TxtEvent_Start_Date.EditValue
                .Event_End_Date = TxtEvent_End_Date.EditValue
                .Event_Participant_Max = TxtEvent_Participant_Max.EditValue
            End With
        End If

        Return Model

    End Function


    Private Function ValidateData() As Boolean
        Throw New NotImplementedException()
    End Function


    Private Sub TxtEvent_Type_Id_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_Type_Id.Validating
        Dim result As Integer
        If Not Integer.TryParse(TxtEvent_Type_Id.EditValue, result) Then
            e.Cancel = True
        Else
            Debug.WriteLine(TxtEvent_Type_Id.EditValue)
        End If

    End Sub

    Private Sub TxtEvent_Participant_Max_Validating(sender As Object, e As CancelEventArgs) Handles TxtEvent_Participant_Max.Validating
        Dim result As Integer
        If Not Integer.TryParse(TxtEvent_Participant_Max.EditValue, result) Then
            e.Cancel = True
        End If
    End Sub

#End Region

End Class
