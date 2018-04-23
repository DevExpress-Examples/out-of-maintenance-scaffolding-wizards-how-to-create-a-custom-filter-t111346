Imports System.Data.Entity

Namespace Scaffolding.CustomFilter.Model
	Public Class IssueContext
		Inherits DbContext

		Public Property Issues() As DbSet(Of Issue)
	End Class
End Namespace
