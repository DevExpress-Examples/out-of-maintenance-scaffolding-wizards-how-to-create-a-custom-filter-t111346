using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Common.DataModel.EntityFramework;
using Scaffolding.CustomFilter.Model;

namespace Scaffolding.CustomFilter.IssueContextDataModel {
    public class IssueContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IIssueContextUnitOfWork {
        static DesignTimeIssueRepository issuesRepository = new DesignTimeIssueRepository();

        public IssueContextDesignTimeUnitOfWork() {
        }

        bool IIssueContextUnitOfWork.HasChanges() {
            return false;
        }
        IIssueRepository IIssueContextUnitOfWork.Issues {
            get { return issuesRepository; }
        }
        public void Detach(object entity) {
        }
    }
}
