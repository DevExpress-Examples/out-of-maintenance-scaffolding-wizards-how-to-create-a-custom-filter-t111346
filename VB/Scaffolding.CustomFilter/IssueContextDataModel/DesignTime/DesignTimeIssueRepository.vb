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
	Public Class DesignTimeIssueRepository
		Inherits DesignTimeRepository(Of Issue, Integer)
		Implements IIssueRepository
		Public Sub New()
			MyBase.New(Function(x) x.ID)
		End Sub
	End Class
End Namespace