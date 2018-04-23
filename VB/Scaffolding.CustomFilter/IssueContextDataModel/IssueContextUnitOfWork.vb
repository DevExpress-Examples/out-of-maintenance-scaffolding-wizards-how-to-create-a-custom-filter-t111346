Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.DataModel.EF6
Imports Scaffolding.CustomFilter.Model
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Scaffolding.CustomFilter.IssueContextDataModel

	''' <summary>
	''' A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
	''' </summary>
	Public Class IssueContextUnitOfWork
		Inherits DbUnitOfWork(Of IssueContext)
		Implements IIssueContextUnitOfWork

		Public Sub New(ByVal contextFactory As Func(Of IssueContext))
			MyBase.New(contextFactory)
		End Sub

		Private ReadOnly Property IIssueContextUnitOfWork_Issues() As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
			Get
				Return GetRepository(Function(x) x.Set(Of Issue)(), Function(x As Issue) x.ID)
			End Get
		End Property
	End Class
End Namespace
