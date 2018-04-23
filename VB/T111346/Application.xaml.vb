Imports System.Configuration
Imports DevExpress.Xpf.Core
Imports System.Data.Entity
Imports T111346.Scaffolding.CustomFilter.Model

Namespace T111346
    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Partial Public Class App
        Inherits Application
        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            Database.SetInitializer(Of IssueContext)(New IssueContextInitializer())
            MyBase.OnStartup(e)
        End Sub
        Private Sub OnAppStartup_UpdateThemeName(sender As Object, e As StartupEventArgs)
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
