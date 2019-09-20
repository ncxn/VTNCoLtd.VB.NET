Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraEditors

Public Class ClsMessageHelper

    Private Shared Singleton As ClsMessageHelper

    Public Shared Function GetInstance() As ClsMessageHelper
        If Singleton Is Nothing Then
            Singleton = New ClsMessageHelper()
        End If
        Return Singleton
    End Function

    Public Sub ShowError(mess As String)
        Dim args As New XtraMessageBoxArgs With {
            .Caption = "Thông báo lỗi!",
            .Text = mess,
            .Icon = StockIconHelper.GetWindows8AssociatedIcon(SystemIcons.Error),
            .Buttons = New DialogResult() {DialogResult.OK}
        }
        XtraMessageBox.Show(args).ToString()
    End Sub

    Public Sub ShowInfo(mess As String)
        Dim args As New XtraMessageBoxArgs With {
            .Caption = "Thông báo!",
            .Text = mess,
            .Icon = StockIconHelper.GetWindows8AssociatedIcon(SystemIcons.Information),
            .Buttons = New DialogResult() {DialogResult.OK}
        }
        XtraMessageBox.Show(args).ToString()
    End Sub

    Public Sub ShowConfirm(mess As String)
        Dim args As New XtraMessageBoxArgs With {
            .Caption = "Xác nhận!",
            .Text = mess,
            .Icon = StockIconHelper.GetWindows8AssociatedIcon(SystemIcons.Question),
            .Buttons = New DialogResult() {DialogResult.OK, DialogResult.No}
        }
        XtraMessageBox.Show(args).ToString()
    End Sub

End Class
