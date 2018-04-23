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
    ''' A IssueContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IIssueContextUnitOfWork interface.
    ''' </summary>
    Public Class IssueContextDesignTimeUnitOfWork
        Inherits DesignTimeUnitOfWork
        Implements IIssueContextUnitOfWork
        ''' <summary>
        ''' Initializes a new instance of the IssueContextDesignTimeUnitOfWork class.
        ''' </summary>
        Public Sub New()
        End Sub
        Private ReadOnly Property Issues As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
            Get
                Return GetRepository(Function(x As Issue) x.ID)
            End Get
        End Property
    End Class
End Namespace
