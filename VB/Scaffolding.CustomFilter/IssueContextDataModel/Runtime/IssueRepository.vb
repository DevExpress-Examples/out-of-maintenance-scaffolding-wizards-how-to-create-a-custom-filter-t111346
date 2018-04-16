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
	Public Class IssueRepository
		Inherits DbRepository(Of Issue, Integer, IssueContext)
		Implements IIssueRepository
		Public Sub New(ByVal unitOfWork As DbUnitOfWork(Of IssueContext))
			MyBase.New(unitOfWork, Function(context) context.Set(Of Issue)(), Function(x) x.ID)
		End Sub
	End Class
End Namespace