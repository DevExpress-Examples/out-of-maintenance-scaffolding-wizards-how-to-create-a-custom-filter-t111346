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
    /// <summary>
    /// Represents the single Issue object view model.
    /// </summary>
    public partial class IssueViewModel : SingleObjectViewModel<Issue, int, IIssueContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of IssueViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static IssueViewModel Create(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new IssueViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the IssueViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the IssueViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected IssueViewModel(IUnitOfWorkFactory<IIssueContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Issues, x => x.Subject) {
        }
    }
}
