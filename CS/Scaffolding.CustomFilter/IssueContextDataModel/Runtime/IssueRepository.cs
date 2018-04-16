using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Model;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Common.DataModel.EntityFramework;

namespace Scaffolding.CustomFilter.IssueContextDataModel {
    public class IssueRepository : DbRepository<Issue, int, IssueContext>, IIssueRepository {
        public IssueRepository(DbUnitOfWork<IssueContext> unitOfWork)
            : base(unitOfWork, context => context.Set<Issue>(), x => x.ID) {
        }
    }
}