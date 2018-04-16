using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.IssueContextDataModel;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Model;
using Scaffolding.CustomFilter.Common.ViewModel;

namespace Scaffolding.CustomFilter.ViewModels {
    public partial class IssueViewModel : SingleObjectViewModel<Issue, int, IIssueContextUnitOfWork> {
        public IssueViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public IssueViewModel(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Issues) {
        }
    }
}
