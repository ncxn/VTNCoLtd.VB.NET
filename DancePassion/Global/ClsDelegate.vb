Public Class ClsDelegate
    ' 
    ' Hướng dẫn: https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/delegates/
    '
    ' Xử lý các sự kiện trên Main Menu từ các form khác, dùng kỹ thuật Delegate:
    Public Delegate Sub MenuDelegate()

    ' Lấy record trên grid để gửi đến các form hoặc user control 
    Public Delegate Function GetCurrentRecord(ByVal Obj As Object) As Object


End Class
