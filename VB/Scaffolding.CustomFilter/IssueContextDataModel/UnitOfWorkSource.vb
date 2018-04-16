Imports Microsoft.VisualBasic
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
	Public NotInheritable Class UnitOfWorkSource
		#Region "inner classes"
		Private Class DbUnitOfWorkFactory
			Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
			Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DbUnitOfWorkFactory()
			Private Sub New()
			End Sub
			Private Function CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
				Return New IssueContextUnitOfWork(New IssueContext())
			End Function
		End Class
		Private Class DesignUnitOfWorkFactory
			Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
			Public Shared ReadOnly Instance As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = New DesignUnitOfWorkFactory()

			Private ReadOnly UnitOfWork As IIssueContextUnitOfWork = New IssueContextDesignTimeUnitOfWork()
			Private Sub New()
			End Sub
			Private Function CreateUnitOfWork() As IIssueContextUnitOfWork Implements IUnitOfWorkFactory(Of IIssueContextUnitOfWork).CreateUnitOfWork
				Return UnitOfWork
			End Function
		End Class
		#End Region
		Private Sub New()
		End Sub
		Public Shared Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
			Return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode)
		End Function
		Public Shared Function GetUnitOfWorkFactory(ByVal isInDesignTime As Boolean) As IUnitOfWorkFactory(Of IIssueContextUnitOfWork)
			Return If(isInDesignTime, DesignUnitOfWorkFactory.Instance, DbUnitOfWorkFactory.Instance)
		End Function
		Public Shared Function CreateUnitOfWork(Optional ByVal isInDesignTime As Boolean = False) As IIssueContextUnitOfWork
			Return GetUnitOfWorkFactory(isInDesignTime).CreateUnitOfWork()
		End Function
	End Class
End Namespace