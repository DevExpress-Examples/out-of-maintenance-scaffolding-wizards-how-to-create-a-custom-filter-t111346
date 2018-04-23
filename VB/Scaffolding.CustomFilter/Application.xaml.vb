Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports System.Data.Entity
Imports Scaffolding.CustomFilter.Model
Imports DevExpress.Internal

Namespace Scaffolding.CustomFilter
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)
			ApplicationThemeHelper.UpdateApplicationThemeName()
			DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory()
			Database.SetInitializer(Of IssueContext)(New IssueContextInitializer())
		End Sub
		Protected Overrides Sub OnExit(ByVal e As ExitEventArgs)
			ApplicationThemeHelper.SaveApplicationThemeName()
		End Sub
	End Class
End Namespace
