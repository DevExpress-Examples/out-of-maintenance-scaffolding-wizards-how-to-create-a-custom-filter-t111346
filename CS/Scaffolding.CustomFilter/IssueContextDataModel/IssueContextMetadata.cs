using DevExpress.Mvvm.DataAnnotations;
using Scaffolding.CustomFilter.Localization;
using Scaffolding.CustomFilter.Model;

namespace Scaffolding.CustomFilter.IssueContextDataModel {

    public class IssueContextMetadataProvider {
        public static void BuildMetadata(MetadataBuilder<Issue> builder) {
            builder.DisplayName(IssueContextResources.Issue);
            builder.Property(x => x.ID).DisplayName(IssueContextResources.Issue_ID);
            builder.Property(x => x.IssueType).DisplayName(IssueContextResources.Issue_IssueType);
            builder.Property(x => x.Subject).DisplayName(IssueContextResources.Issue_Subject);
            builder.Property(x => x.IsUrgent).DisplayName(IssueContextResources.Issue_IsUrgent);
            builder.Property(x => x.CreatedOn).DisplayName(IssueContextResources.Issue_CreatedOn);
        }
    }
}