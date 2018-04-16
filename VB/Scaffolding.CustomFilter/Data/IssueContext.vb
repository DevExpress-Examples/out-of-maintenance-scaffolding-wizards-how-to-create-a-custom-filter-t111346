Imports Microsoft.VisualBasic
Imports System.Data.Entity

Namespace Scaffolding.CustomFilter.Model
	Public Class IssueContext
		Inherits DbContext
		Private privateIssues As DbSet(Of Issue)
		Public Property Issues() As DbSet(Of Issue)
			Get
				Return privateIssues
			End Get
			Set(ByVal value As DbSet(Of Issue))
				privateIssues = value
			End Set
		End Property
	End Class
End Namespace
