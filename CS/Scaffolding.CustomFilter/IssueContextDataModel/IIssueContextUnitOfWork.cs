using DevExpress.Mvvm.DataModel;
using Scaffolding.CustomFilter.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scaffolding.CustomFilter.IssueContextDataModel {

    /// <summary>
    /// IIssueContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IIssueContextUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Issue entities repository.
        /// </summary>
        IRepository<Issue, int> Issues { get; }
    }
}
