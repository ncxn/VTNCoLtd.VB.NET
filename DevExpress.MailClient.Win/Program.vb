Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Skins
Imports DevExpress.Data.Filtering
Imports DevExpress.MailClient.Win.Forms
Imports System.Drawing
Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports System.IO
Imports DevExpress.Tutorials

Namespace DevExpress.MailClient.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main(ByVal arguments() As String)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve
            DataHelper.ApplicationArguments = arguments
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments)
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
            SkinManager.EnableFormSkins()
            EnumProcessingHelper.RegisterEnum(Of TaskStatus)()
            UnpackHelper.Unpack()
            'SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim showDialog As DialogResult = (New LanguageSelectorForm()).ShowDialog()
            If showDialog <> DialogResult.OK Then
                Return
            End If
            Application.Run(New frmMain())
        End Sub
        Private Shared Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
            Dim partialName As String = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()
            If partialName = "entityframework" OrElse partialName = "system.data.sqlite" OrElse partialName = "system.data.sqlite.ef6" Then
                Dim path As String = FilePathUtils.FindFilePath("Dll\\" + partialName + ".dll", False)
                Return System.Reflection.Assembly.LoadFrom(path)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
