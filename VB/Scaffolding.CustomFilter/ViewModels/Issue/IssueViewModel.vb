Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Common.Utils
Imports IssueContextDataModel
Imports Common.DataModel
Imports Scaffolding.CustomFilter.Model
Imports Common.ViewModel
Namespace ViewModels
    ''' <summary>
    ''' Represents the single Issue object view model.
    ''' </summary>
    Partial Public Class IssueViewModel
        Inherits SingleObjectViewModel(Of Issue, Integer, IIssueContextUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of IssueViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = Nothing) As IssueViewModel
            Return ViewModelSource.Create(Function() New IssueViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the IssueViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the IssueViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Issues, Function(x) x.Subject)
        End Sub
    End Class
End Namespace
