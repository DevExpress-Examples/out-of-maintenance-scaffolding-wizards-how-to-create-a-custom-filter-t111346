Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports T111346.Common.DataModel
Imports T111346.Common.ViewModel
Imports T111346.IssueContextDataModel
Imports T111346.Scaffolding.CustomFilter.Model
Namespace Global.T111346.ViewModels
    ''' <summary>
    ''' Represents the root POCO view model for the IssueContext data model.
    ''' </summary>
    Partial Public Class IssueContextViewModel
        Inherits DocumentsViewModel(Of IssueContextModuleDescription, IIssueContextUnitOfWork)
        Private Const _TablesGroup As String = "Tables"
        Private Const _ViewsGroup As String = "Views"
        ''' <summary>
        ''' Creates a new instance of IssueContextViewModel as a POCO view model.
        ''' </summary>
        Public Shared Function Create() As IssueContextViewModel
            Return ViewModelSource.Create(Function() New IssueContextViewModel())
        End Function
        ''' <summary>
        ''' Initializes a new instance of the IssueContextViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the IssueContextViewModel type without the POCO proxy factory.
        ''' </summary>
        Protected Sub New()
            MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        End Sub
        Protected Overrides Function CreateModules() As IssueContextModuleDescription()
            Return New IssueContextModuleDescription() {New IssueContextModuleDescription("Issues", "IssueCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Issues))}
        End Function
    End Class
    Partial Public Class IssueContextModuleDescription
        Inherits ModuleDescription(Of IssueContextModuleDescription)
        Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of IssueContextModuleDescription, Object) = Nothing)
            MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
        End Sub
    End Class
End Namespace
