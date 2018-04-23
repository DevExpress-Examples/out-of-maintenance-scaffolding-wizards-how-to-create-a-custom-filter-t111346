Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.DataModel.DesignTime
Imports DevExpress.Mvvm.DataModel.EF6
Imports Scaffolding.CustomFilter.Model
Imports System
Imports System.Collections
Imports System.Linq

Namespace Scaffolding.CustomFilter.IssueContextDataModel

	''' <summary>
	''' Provides methods to obtain the relevant IUnitOfWorkFactory.
	''' </summary>
	Public NotInheritable Class UnitOfWorkSource

		Private Sub New()
		End Sub


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
			If isInDesignTime Then
				Return New DesignTimeUnitOfWorkFactory(Of IIssueContextUnitOfWork)(Function() New IssueContextDesignTimeUnitOfWork())
			End If
			Return New DbUnitOfWorkFactory(Of IIssueContextUnitOfWork)(Function() New IssueContextUnitOfWork(Function() New IssueContext()))
		End Function
	End Class
End Namespace