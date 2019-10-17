Imports VTNcoLtd.BUS

Namespace Helper

    Public Class DelegateHelper
        ' 
        ' Hướng dẫn: https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/delegates/
        '

        ' Xử lý các sự kiện trên Main Menu từ các form khác, dùng kỹ thuật Delegate:
        Public Delegate Sub RolesMenu()

        ' Add tab(docs)/or remove tab
        Public Delegate Sub AddTab(uc As UserControl, caption As String)
        Public Delegate Sub RemoveTab()

        ' Ẩn Page Group nếu không có item bên trong
        Public Delegate Sub HideGroup(Controls As String, ControlsAccess As ControlAccessCollection)

        'Role
        Public Delegate Sub CheckRole(Controls As String)
    End Class
End Namespace