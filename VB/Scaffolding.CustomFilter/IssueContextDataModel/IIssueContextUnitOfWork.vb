Imports System
Imports System.Linq
Imports System.Data
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Common.Utils
Imports Common.DataModel
Imports Common.DataModel.DesignTime
Imports Common.DataModel.EntityFramework
Imports Scaffolding.CustomFilter.Model
Namespace IssueContextDataModel
    ''' <summary>
    ''' IIssueContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface IIssueContextUnitOfWork
        Inherits IUnitOfWork
        ''' <summary>
        ''' The Issue entities repository.
        ''' </summary>
        ReadOnly Property Issues As IRepository(Of Issue, Integer)
    End Interface
End Namespace
