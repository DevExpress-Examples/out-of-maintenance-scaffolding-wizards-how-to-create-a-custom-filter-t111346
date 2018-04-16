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
	Public Interface IIssueContextUnitOfWork
	Inherits IUnitOfWork
		Function HasChanges() As Boolean
		ReadOnly Property Issues() As IIssueRepository
	End Interface
End Namespace
