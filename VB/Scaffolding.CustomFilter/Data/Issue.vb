Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Namespace Scaffolding.CustomFilter.Model
    Public Class Issue
        Public Property ID() As Integer
        Public Property IssueType() As IssueType
        Public Property Subject() As String
        Public Property IsUrgent() As Boolean
        Public Property CreatedOn() As Date
    End Class
End Namespace