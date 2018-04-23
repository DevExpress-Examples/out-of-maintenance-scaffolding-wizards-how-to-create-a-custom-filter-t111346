using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using Scaffolding.CustomFilter.Localization;
using Scaffolding.CustomFilter.IssueContextDataModel;

namespace Scaffolding.CustomFilter.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the IssueContext data model.
    /// </summary>
    public partial class IssueContextViewModel : DocumentsViewModel<IssueContextModuleDescription, IIssueContextUnitOfWork> {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of IssueContextViewModel as a POCO view model.
        /// </summary>
        public static IssueContextViewModel Create() {
            return ViewModelSource.Create(() => new IssueContextViewModel());
        }

        static IssueContextViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<IssueContextMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the IssueContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the IssueContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected IssueContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override IssueContextModuleDescription[] CreateModules() {
            return new IssueContextModuleDescription[] {
                new IssueContextModuleDescription(IssueContextResources.IssuePlural, "IssueCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Issues)),
            };
        }
    }

    public partial class IssueContextModuleDescription : ModuleDescription<IssueContextModuleDescription> {
        public IssueContextModuleDescription(string title, string documentType, string group, Func<IssueContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}