Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class Setting

    Private employeesUserControl As XtraUserControl
    Private customersUserControl As XtraUserControl
    Private MailsUserControl As XtraUserControl
    Public Sub New()
        InitializeComponent()
        'employeesUserControl = CreateUserControl("Employees")
        'customersUserControl = CreateUserControl("Customers")
        'MailsUserControl = CreateUserControl("Mails Setting")
        'accordionControl.SelectedElement = employeesAccordionControlElement

    End Sub
    Private Function CreateUserControl(ByVal text As String) As XtraUserControl
        Dim result As New XtraUserControl()
        result.Name = text.ToLower() & "UserControl"
        result.Text = text
        Dim label As New LabelControl()
        label.Parent = result
        'label.Appearance.Font = New Font("Tahoma", 25.25F)
        label.Appearance.ForeColor = Color.Gray
        label.Dock = System.Windows.Forms.DockStyle.Fill
        label.AutoSizeMode = LabelAutoSizeMode.None
        label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        label.Text = text
        Return result
    End Function
    Private Sub accordionControl_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs) Handles accordionControl.SelectedElementChanged
        If e.Element Is Nothing Then
            Return
        End If
        Dim form As New Form()
        Select Case e.Element.Text
            Case "Cấu hình Email"
                form = Mails
            Case "Cấu hình SMS"
                form = SMSconfig
            Case "Thông tin doanh nghiệp"
                form = Form1

        End Select
        tabbedView.AddDocument(form)
        tabbedView.ActivateDocument(form)
    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles infoBarButtonItem.ItemClick, emailBarButtonItem.ItemClick
        Dim childForm As New Form()
        childForm.MdiParent = Me
        If e.Item.Caption = "Mails Setting" Then
            Mails.Show()
            'accordionControl.SelectedElement = employeesAccordionControlElement
        Else
            accordionControl.SelectedElement = infoAccordionControlElement
        End If
    End Sub
    Private Sub tabbedView_DocumentClosed(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView.DocumentClosed
        RecreateUserControls(e)
        SetAccordionSelectedElement(e)
    End Sub
    Private Sub SetAccordionSelectedElement(ByVal e As DocumentEventArgs)
        If tabbedView.Documents.Count <> 0 Then
            Select Case e.Document.Caption
                Case "Employees"
                    accordionControl.SelectedElement = smsAccordionControlElement
                Case "Customers"
                    accordionControl.SelectedElement = infoAccordionControlElement
                Case "Mails Setting"
                    accordionControl.SelectedElement = MailsAccordionControlElement
                    'Case "Clients"
                    'accordionControl.SelectedElement = clientsAccordionControlElement
            End Select
        Else
            accordionControl.SelectedElement = Nothing
        End If
    End Sub
    Private Sub RecreateUserControls(ByVal e As DocumentEventArgs)
        Select Case e.Document.Caption
            Case "Employees"
                employeesUserControl = CreateUserControl("Employees")
            Case "Customers"
                customersUserControl = CreateUserControl("Customers")
            Case "Mails Setting"
                MailsUserControl = CreateUserControl("Mails Setting")
                'Case "Clients"
                'clientsUserControl = CreateUserControl("Clients")
        End Select
    End Sub

End Class
