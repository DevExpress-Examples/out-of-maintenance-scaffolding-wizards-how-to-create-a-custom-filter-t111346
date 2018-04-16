Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter.ViewModels
	Partial Public Class IssueCollectionViewModel
		Private Shared ReadOnly filters_Renamed As IEnumerable(Of FilterExpressionInfo(Of Issue)) = New FilterExpressionInfo(Of Issue)() { New FilterExpressionInfo(Of Issue) ("All", Function(x) True), New FilterExpressionInfo(Of Issue) ("For support", Function(x) x.IssueType = IssueType.Question), New FilterExpressionInfo(Of Issue) ("For developers", Function(x) x.IssueType = IssueType.Bug OrElse x.IssueType = IssueType.Suggestion) }
		Public ReadOnly Property Filters() As IEnumerable(Of FilterExpressionInfo(Of Issue))
			Get
				Return filters_Renamed
			End Get
		End Property
		Protected Overrides Sub OnInitializeInRuntime()
			MyBase.OnInitializeInRuntime()
			FilterExpression = Filters.First().Expression
		End Sub
	End Class
	Public Class FilterExpressionInfo(Of TEntity)
		Public Sub New(ByVal displayName As String, ByVal expression As Expression(Of Func(Of TEntity, Boolean)))
			Expression = expression
			DisplayName = displayName
		End Sub
		Private privateExpression As Expression(Of Func(Of TEntity, Boolean))
		Public Property Expression() As Expression(Of Func(Of TEntity, Boolean))
			Get
				Return privateExpression
			End Get
			Private Set(ByVal value As Expression(Of Func(Of TEntity, Boolean)))
				privateExpression = value
			End Set
		End Property
		Private privateDisplayName As String
		Public Property DisplayName() As String
			Get
				Return privateDisplayName
			End Get
			Private Set(ByVal value As String)
				privateDisplayName = value
			End Set
		End Property
	End Class
End Namespace