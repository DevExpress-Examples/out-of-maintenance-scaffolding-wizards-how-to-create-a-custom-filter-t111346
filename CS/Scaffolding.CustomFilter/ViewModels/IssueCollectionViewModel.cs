using System;
using System.Linq;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.IssueContextDataModel;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Model;
using Scaffolding.CustomFilter.Common.ViewModel;

namespace Scaffolding.CustomFilter.ViewModels {
    public partial class IssueCollectionViewModel : CollectionViewModel<Issue, int, IIssueContextUnitOfWork> {
        public IssueCollectionViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public IssueCollectionViewModel(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Issues) {
        }
    }
}