Imports DevExpress.Mvvm.DataModel
Imports Scaffolding.CustomFilter.Model
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Scaffolding.CustomFilter.IssueContextDataModel

	''' <summary>
	''' IIssueContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
	''' </summary>
	Public Interface IIssueContextUnitOfWork
		Inherits IUnitOfWork

		''' <summary>
		''' The Issue entities repository.
		''' </summary>
		ReadOnly Property Issues() As IRepository(Of Issue, Integer)
	End Interface
End Namespace
