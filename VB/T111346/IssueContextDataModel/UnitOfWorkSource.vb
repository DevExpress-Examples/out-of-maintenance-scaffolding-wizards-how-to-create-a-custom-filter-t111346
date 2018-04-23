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
Imports DevExpress.Mvvm
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Data.Async.Helpers
Namespace Global.T111346.IssueContextDataModel
    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public Module UnitOfWorkSource
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
            If isInDesignTime Then
                Return New DesignTimeUnitOfWorkFactory(Of IIssueContextUnitOfWork)(Function() New IssueContextDesignTimeUnitOfWork())
            End If
            Return New DbUnitOfWorkFactory(Of IIssueContextUnitOfWork)(Function() New IssueContextUnitOfWork(Function() New IssueContext()))
        End Function
    End Module
End Namespace
