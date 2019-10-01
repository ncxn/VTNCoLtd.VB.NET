Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Public Class ClsDocumentManagerHelper

    Dim Parent As Form = New FrmMain

    Public Sub AddDocumentManager()
        Dim manager As New DocumentManager With {
            .MdiParent = Parent,
            .View = New TabbedView()
        }
    End Sub

    Private Sub AddDocs(uc As UserControl, caption As String)
        Dim docs As BaseDocument
        Dim view As TabbedView = Nothing
        uc.Text = caption
        For Each docs In view.Documents
            If docs.Caption = caption Then
                view.Controller.Activate(docs)
                Return
            End If
        Next
        view.AddDocument(uc)
    End Sub
End Class
