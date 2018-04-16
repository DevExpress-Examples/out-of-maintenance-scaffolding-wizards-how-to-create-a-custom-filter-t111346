Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.CustomFilter.Common.Utils
Imports Scaffolding.CustomFilter.Common.DataModel
Imports Scaffolding.CustomFilter.Common.DataModel.EntityFramework
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter.IssueContextDataModel
	Public Class IssueContextUnitOfWork
		Inherits DbUnitOfWork(Of IssueContext)
		Implements IIssueContextUnitOfWork
		Private issuesRepository As Lazy(Of IIssueRepository)

		Public Sub New(ByVal context As IssueContext)
			MyBase.New(context)
			issuesRepository = New Lazy(Of IIssueRepository)(Function() New IssueRepository(Me))
		End Sub
		Private Function HasChanges() As Boolean Implements IIssueContextUnitOfWork.HasChanges
			Return Context.ChangeTracker.HasChanges()
		End Function
		Private ReadOnly Property Issues() As IIssueRepository Implements IIssueContextUnitOfWork.Issues
			Get
				Return issuesRepository.Value
			End Get
		End Property
	End Class
End Namespace
