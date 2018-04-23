Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports T111346.Scaffolding.CustomFilter.Model

Namespace Global.T111346.ViewModels
    Partial Public Class IssueCollectionViewModel
        Private Shared ReadOnly filters_Renamed As IEnumerable(Of FilterExpressionInfo(Of Issue)) = New FilterExpressionInfo(Of Issue)() {New FilterExpressionInfo(Of Issue)("All", Function(x) True), New FilterExpressionInfo(Of Issue)("For support", Function(x) x.IssueType = IssueType.Question), New FilterExpressionInfo(Of Issue)("For developers", Function(x) x.IssueType = IssueType.Bug OrElse x.IssueType = IssueType.Suggestion)}
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
        Public Sub New(ByVal _displayName As String, ByVal _expression As Expression(Of Func(Of TEntity, Boolean)))
            Expression = _expression
            DisplayName = _displayName
        End Sub
        Public Property Expression() As Expression(Of Func(Of TEntity, Boolean))
        Public Property DisplayName() As String
    End Class
End Namespace