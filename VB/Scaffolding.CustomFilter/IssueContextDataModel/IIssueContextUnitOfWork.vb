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
    ''' IIssueContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface IIssueContextUnitOfWork
        Inherits IUnitOfWork

        ''' <summary>
        ''' The Issue entities repository.
        ''' </summary>
        ReadOnly Property Issues() As IRepository(Of Issue, Integer)
    End Interface
End Namespace
