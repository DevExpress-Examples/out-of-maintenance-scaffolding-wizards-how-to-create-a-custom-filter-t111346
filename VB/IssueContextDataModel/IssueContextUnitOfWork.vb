Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Common.Utils
Imports Common.DataModel
Imports Common.DataModel.EntityFramework
Imports Scaffolding.CustomFilter.Model
Namespace IssueContextDataModel
    ''' <summary>
    ''' A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
    ''' </summary>
    Public Class IssueContextUnitOfWork
        Inherits DbUnitOfWork(Of IssueContext)
        Implements IIssueContextUnitOfWork
        ''' <summary>
        ''' Initializes a new instance of the IssueContextUnitOfWork class.
        ''' </summary>
        ''' <param name="context">An underlying DbContext.</param>
        Public Sub New(ByVal context As IssueContext)
            MyBase.New(context)
        End Sub
        Private ReadOnly Property Issues As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
            Get
                Return GetRepository(Function(x) x.[Set](Of Issue)(), Function(x) x.ID)
            End Get
        End Property
    End Class
End Namespace
