Imports DevExpress.Mvvm.DataAnnotations
Imports Scaffolding.CustomFilter.Localization
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter.IssueContextDataModel

	Public Class IssueContextMetadataProvider
		Public Shared Sub BuildMetadata(ByVal builder As MetadataBuilder(Of Issue))
			builder.DisplayName(IssueContextResources.Issue)
			builder.Property(Function(x) x.ID).DisplayName(IssueContextResources.Issue_ID)
			builder.Property(Function(x) x.IssueType).DisplayName(IssueContextResources.Issue_IssueType)
			builder.Property(Function(x) x.Subject).DisplayName(IssueContextResources.Issue_Subject)
			builder.Property(Function(x) x.IsUrgent).DisplayName(IssueContextResources.Issue_IsUrgent)
			builder.Property(Function(x) x.CreatedOn).DisplayName(IssueContextResources.Issue_CreatedOn)
		End Sub
	End Class
End Namespace