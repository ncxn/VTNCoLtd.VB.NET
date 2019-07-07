Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class UCControlsManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Mở rộng.
        ' 1. Thêm dòng khi Enter hoặc tab tại cột cuối cùng
        'Dim TempGridNewRowHelper As ClsGridControlHelper = New ClsGridControlHelper(GrvControls)
    End Sub
    Private Sub ControlsManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
#Region " Thêm dòng"
    Private Sub InsertRow()
        GrvControls.AddNewRow()
        GrvControls.OptionsNavigation.AutoFocusNewRow = True
        GrvControls.FocusedColumn = GrvControls.VisibleColumns(0)
    End Sub
    Private Sub GetNewRowsAdded()
        Dim dr As DataRow
        For i As Integer = 0 To GrvControls.RowCount - 1
            dr = GrvControls.GetDataRow(i)
            If dr.RowState = DataRowState.Added Then
                Debug.WriteLine(dr(0).ToString + dr(1).ToString + dr(2).ToString + dr(3).ToString)
            End If
        Next
    End Sub

    Private Sub GrvControls_LostFocus(sender As Object, e As EventArgs) Handles GrvControls.LostFocus
        SendKeys.Send("{ENTER}")
    End Sub
    Private Sub GrvControls_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GrvControls.BeforeLeaveRow
        GrvControls.CloseEditor()
    End Sub
#End Region
#Region " Sửa dòng"
    Private Sub GetNewRowsModified()
        Dim dr As DataRow
        For i As Integer = 0 To GrvControls.RowCount - 1
            dr = GrvControls.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                Debug.WriteLine(dr(0).ToString + dr(1).ToString + dr(2).ToString + dr(3).ToString)
            End If
        Next
    End Sub
#End Region
    Private Sub GrdControls_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles GrdControls.ProcessGridKey
        Select Case e.KeyData
            Case Keys.Insert
                SendKeys.Send("{ENTER}")
                InsertRow()
            Case Keys.Delete
                DeleteRow()
            Case Else

        End Select
    End Sub
    Private Sub LoadData()
        GrdControls.DataSource = ClsControls.GetInstance.GetDataSet().Tables(0)
        GrdControls.ForceInitialize()
    End Sub

    Private Sub DeleteRow()
        Dim SelectedRow = GrvControls.GetFocusedDataRow()
        If SelectedRow IsNot Nothing Then
            MessageBox.Show(SelectedRow(0).ToString)
        End If
    End Sub

End Class
