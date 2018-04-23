using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using Scaffolding.CustomFilter.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scaffolding.CustomFilter.IssueContextDataModel {

    /// <summary>
    /// A IssueContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IIssueContextUnitOfWork interface.
    /// </summary>
    public class IssueContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IIssueContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the IssueContextDesignTimeUnitOfWork class.
        /// </summary>
        public IssueContextDesignTimeUnitOfWork() {
        }

        IRepository<Issue, int> IIssueContextUnitOfWork.Issues
        {
            get { return GetRepository((Issue x) => x.ID); }
        }
    }
}
