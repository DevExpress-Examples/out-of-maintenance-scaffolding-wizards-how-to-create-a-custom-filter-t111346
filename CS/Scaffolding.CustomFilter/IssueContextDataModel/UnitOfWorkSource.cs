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
using DevExpress.Mvvm;

namespace Scaffolding.CustomFilter.IssueContextDataModel {
    public static class UnitOfWorkSource {
        #region inner classes
        class DbUnitOfWorkFactory : IUnitOfWorkFactory<IIssueContextUnitOfWork> {
            public static readonly IUnitOfWorkFactory<IIssueContextUnitOfWork> Instance = new DbUnitOfWorkFactory();
            DbUnitOfWorkFactory() { }
            IIssueContextUnitOfWork IUnitOfWorkFactory<IIssueContextUnitOfWork>.CreateUnitOfWork() {
                return new IssueContextUnitOfWork(new IssueContext());
            }
        }
        class DesignUnitOfWorkFactory : IUnitOfWorkFactory<IIssueContextUnitOfWork> {
            public static readonly IUnitOfWorkFactory<IIssueContextUnitOfWork> Instance = new DesignUnitOfWorkFactory();

            readonly IIssueContextUnitOfWork UnitOfWork = new IssueContextDesignTimeUnitOfWork();
            DesignUnitOfWorkFactory() { }
            IIssueContextUnitOfWork IUnitOfWorkFactory<IIssueContextUnitOfWork>.CreateUnitOfWork() {
                return UnitOfWork;
            }
        }
        #endregion
        public static IUnitOfWorkFactory<IIssueContextUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }
        public static IUnitOfWorkFactory<IIssueContextUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
            return isInDesignTime ? DesignUnitOfWorkFactory.Instance : DbUnitOfWorkFactory.Instance;
        }
        public static IIssueContextUnitOfWork CreateUnitOfWork(bool isInDesignTime = false) {
            return GetUnitOfWorkFactory(isInDesignTime).CreateUnitOfWork();
        }
    }
}