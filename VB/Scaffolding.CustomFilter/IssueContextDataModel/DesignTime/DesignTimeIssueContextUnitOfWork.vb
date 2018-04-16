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
	Public Class IssueContextDesignTimeUnitOfWork
		Inherits DesignTimeUnitOfWork
		Implements IIssueContextUnitOfWork
		Private Shared issuesRepository As New DesignTimeIssueRepository()

		Public Sub New()
		End Sub

		Private Function HasChanges() As Boolean Implements IIssueContextUnitOfWork.HasChanges
			Return False
		End Function
		Private ReadOnly Property Issues() As IIssueRepository Implements IIssueContextUnitOfWork.Issues
			Get
				Return issuesRepository
			End Get
		End Property
		Public Overloads Sub Detach(ByVal entity As Object) Implements Scaffolding.CustomFilter.Common.DataModel.IUnitOfWork.Detach
		End Sub
	End Class
End Namespace
