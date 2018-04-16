Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.CustomFilter.Common.Utils
Imports Scaffolding.CustomFilter.Model
Imports Scaffolding.CustomFilter.Common.DataModel
Imports Scaffolding.CustomFilter.Common.DataModel.EntityFramework

Namespace Scaffolding.CustomFilter.IssueContextDataModel
	Public Interface IIssueRepository
	Inherits IRepository(Of Issue, Integer)
	End Interface
End Namespace