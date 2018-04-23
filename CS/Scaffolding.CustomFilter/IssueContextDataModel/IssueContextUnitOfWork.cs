using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using Scaffolding.CustomFilter.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scaffolding.CustomFilter.IssueContextDataModel {

    /// <summary>
    /// A IssueContextUnitOfWork instance that represents the run-time implementation of the IIssueContextUnitOfWork interface.
    /// </summary>
    public class IssueContextUnitOfWork : DbUnitOfWork<IssueContext>, IIssueContextUnitOfWork {

        public IssueContextUnitOfWork(Func<IssueContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Issue, int> IIssueContextUnitOfWork.Issues
        {
            get { return GetRepository(x => x.Set<Issue>(), (Issue x) => x.ID); }
        }
    }
}
