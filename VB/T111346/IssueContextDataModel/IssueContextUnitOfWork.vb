Imports System
Imports System.Linq
Imports System.Data
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports T111346.Common.Utils
Imports T111346.Common.DataModel
Imports T111346.Common.DataModel.DesignTime
Imports T111346.Common.DataModel.EntityFramework
Imports T111346.Scaffolding.CustomFilter.Model
Namespace Global.T111346.IssueContextDataModel
    ''' <summary>
    ''' A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
    ''' </summary>
    Public Class IssueContextUnitOfWork
        Inherits DbUnitOfWork(Of IssueContext)
        Implements IIssueContextUnitOfWork
        Public Sub New(ByVal contextFactory As Func(Of IssueContext))
            MyBase.New(contextFactory)
        End Sub
        Private ReadOnly Property Issues As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
            Get
                Return GetRepository(Function(x) x.[Set](Of Issue)(), Function(x As Issue) x.ID)
            End Get
        End Property
    End Class
End Namespace
