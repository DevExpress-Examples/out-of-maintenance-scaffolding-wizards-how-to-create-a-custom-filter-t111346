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
Imports DevExpress.Mvvm

Namespace Scaffolding.CustomFilter.IssueContextDataModel
    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public NotInheritable Class UnitOfWorkSource

        Private Sub New()
        End Sub


        #Region "inner classes"
        Private Class DbUnitOfWorkFactory
            Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)

            Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DbUnitOfWorkFactory()
            Private Sub New()
            End Sub
            Private Function IUnitOfWorkFactoryGeneric_CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
                Return New IssueContextUnitOfWork(Function() New IssueContext())
            End Function
        End Class

        Private Class DesignUnitOfWorkFactory
            Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)

            Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DesignUnitOfWorkFactory()
            Private Sub New()
            End Sub
            Private Function IUnitOfWorkFactoryGeneric_CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
                Return New IssueContextDesignTimeUnitOfWork()
            End Function
        End Class
        #End Region

        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        ''' </summary>
        Public Shared Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode)
        End Function

        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        ''' </summary>
        ''' <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        Public Shared Function GetUnitOfWorkFactory(ByVal isInDesignTime As Boolean) As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
            Return If(isInDesignTime, DesignUnitOfWorkFactory.Instance, DbUnitOfWorkFactory.Instance)
        End Function
    End Class
End Namespace