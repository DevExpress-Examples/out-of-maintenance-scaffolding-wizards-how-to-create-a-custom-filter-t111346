using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Common.DataModel.DesignTime;
using Scaffolding.CustomFilter.Common.DataModel.EntityFramework;
using Scaffolding.CustomFilter.Model;

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

        IRepository<Issue, int> IIssueContextUnitOfWork.Issues {
            get { return GetRepository((Issue x) => x.ID); }
        }
    }
}
