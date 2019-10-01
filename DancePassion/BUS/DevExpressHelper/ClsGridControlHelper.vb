Imports DevExpress.XtraGrid.Views.Grid

Public Class ClsGridControlHelper

    Private ReadOnly _View As GridView

    Public Sub New(ByVal view As GridView)
        _View = view
        AddHandler view.GridControl.EditorKeyDown, AddressOf GridControl_EditorKeyDown
        AddHandler view.GridControl.KeyDown, AddressOf GridControl_KeyDown
    End Sub

    Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        e.Handled = OnKeyDown(e.KeyCode, e.Modifiers)
    End Sub

    Private Sub GridControl_EditorKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        e.Handled = OnKeyDown(e.KeyCode, e.Modifiers)
    End Sub

    Private Function OnKeyDown(ByVal keyCode As Keys, ByVal modifiers As Keys) As Boolean
        If modifiers = Keys.None And (keyCode = Keys.Enter OrElse keyCode = Keys.Tab) Then
            Return CheckAddNewRow()
        End If
        Return False
    End Function

    ' Check the end cell position
    Private Function CheckAddNewRow() As Boolean
        If _View.FocusedColumn.VisibleIndex = _View.VisibleColumns.Count - 1 And _View.IsLastRow Then
            If _View.ActiveEditor Is Nothing Then
                Return AddNewRow()
            End If
        End If
        Return False
    End Function

    Private Function AddNewRow() As Boolean
        _View.AddNewRow()
        _View.FocusedColumn = _View.VisibleColumns(0)
        Return True
    End Function
End Class
