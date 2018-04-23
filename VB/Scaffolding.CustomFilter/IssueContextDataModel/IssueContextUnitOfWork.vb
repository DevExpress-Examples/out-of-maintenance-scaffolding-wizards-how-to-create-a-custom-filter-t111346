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
    ''' <summary>
    ''' A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
    ''' </summary>
    Public Class IssueContextUnitOfWork
        Inherits DbUnitOfWork(Of IssueContext)
        Implements IIssueContextUnitOfWork

        Public Sub New(ByVal contextFactory As Func(Of IssueContext))
            MyBase.New(contextFactory)
        End Sub

        Private ReadOnly Property IIssueContextUnitOfWork_Issues() As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
            Get
                Return GetRepository(Function(x) x.Set(Of Issue)(), Function(x) x.ID)
            End Get
        End Property
    End Class
End Namespace
