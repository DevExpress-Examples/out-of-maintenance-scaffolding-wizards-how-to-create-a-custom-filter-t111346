Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.IO

Namespace Scaffolding.CustomFilter.Model
	Public Class IssueContextInitializer
		Inherits DropCreateDatabaseIfModelChanges(Of IssueContext)

		Protected Overrides Sub Seed(ByVal context As IssueContext)
			MyBase.Seed(context)
			context.Issues.Add(New Issue With {.IssueType = IssueType.Question, .CreatedOn = New Date(2014, 4, 14), .IsUrgent = True, .Subject = "How to add a new row"})
			context.Issues.Add(New Issue With {.IssueType = IssueType.Question, .CreatedOn = New Date(2014, 2, 15), .IsUrgent = False, .Subject = "Application is crashed in some scenarios"})
			context.Issues.Add(New Issue With {.IssueType = IssueType.Question, .CreatedOn = New Date(2014, 3, 16), .IsUrgent = True, .Subject = "When do you plan to release the next version?"})
			context.Issues.Add(New Issue With {.IssueType = IssueType.Bug, .CreatedOn = New Date(2014, 3, 12), .IsUrgent = False, .Subject = "Values are not rendered"})
			context.Issues.Add(New Issue With {.IssueType = IssueType.Bug, .CreatedOn = New Date(2014, 1, 23), .IsUrgent = True, .Subject = "Cell values are not saved properly"})
			context.Issues.Add(New Issue With {.IssueType = IssueType.Suggestion, .CreatedOn = New Date(2014, 2, 18), .IsUrgent = False, .Subject = "Provide the capability to sort data"})
			context.SaveChanges()
		End Sub
	End Class
End Namespace