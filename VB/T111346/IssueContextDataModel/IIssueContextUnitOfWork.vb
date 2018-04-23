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
