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
Imports DevExpress.Mvvm
Namespace IssueContextDataModel
    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public Module UnitOfWorkSource
        Friend Class DbUnitOfWorkFactory
            Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DbUnitOfWorkFactory()
            Private Sub New()
            End Sub
            Private Function CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
                Return New IssueContextUnitOfWork(New IssueContext())
            End Function
        End Class
        Friend Class DesignUnitOfWorkFactory
            Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DesignUnitOfWorkFactory()
            Private ReadOnly _UnitOfWork As IIssueContextUnitOfWork = New IssueContextDesignTimeUnitOfWork()
            Private Sub New()
            End Sub
            Private Function CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
                Return _UnitOfWork
            End Function
        End Class
        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        ''' </summary>
        Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode)
        End Function
        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        ''' </summary>
        ''' <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        Public Function GetUnitOfWorkFactory(ByVal isInDesignTime As Boolean) As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Return If(isInDesignTime, DesignUnitOfWorkFactory.Instance, DbUnitOfWorkFactory.Instance)
        End Function
    End Module
End Namespace
