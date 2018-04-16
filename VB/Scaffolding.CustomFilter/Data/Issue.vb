Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Namespace Scaffolding.CustomFilter.Model
	Public Class Issue
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateIssueType As IssueType
		Public Property IssueType() As IssueType
			Get
				Return privateIssueType
			End Get
			Set(ByVal value As IssueType)
				privateIssueType = value
			End Set
		End Property
		Private privateSubject As String
		Public Property Subject() As String
			Get
				Return privateSubject
			End Get
			Set(ByVal value As String)
				privateSubject = value
			End Set
		End Property
		Private privateIsUrgent As Boolean
		Public Property IsUrgent() As Boolean
			Get
				Return privateIsUrgent
			End Get
			Set(ByVal value As Boolean)
				privateIsUrgent = value
			End Set
		End Property
		Private privateCreatedOn As DateTime
		Public Property CreatedOn() As DateTime
			Get
				Return privateCreatedOn
			End Get
			Set(ByVal value As DateTime)
				privateCreatedOn = value
			End Set
		End Property
	End Class
End Namespace