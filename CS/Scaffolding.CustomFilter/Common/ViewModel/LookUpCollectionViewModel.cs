using System;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Common.DataModel;

namespace Scaffolding.CustomFilter.Common.ViewModel {
    public partial class LookUpCollectionViewModel<TMasterEntity, TEntity, TPrimaryKey, TUnitOfWork> : LookUpCollectionViewModelBase<TMasterEntity, TEntity, TPrimaryKey, TUnitOfWork>
        where TMasterEntity : class
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {
        public LookUpCollectionViewModel(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Expression<Func<TEntity, bool>> filterExpression,
            object masterEntityKey)
            : base(unitOfWorkFactory, getRepositoryFunc, filterExpression, masterEntityKey) {
        }
    }
    public abstract class LookUpCollectionViewModelBase<TMasterEntity, TEntity, TPrimaryKey, TUnitOfWork> : CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork>
        where TMasterEntity : class
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {
        object masterEntityKey;

        public LookUpCollectionViewModelBase(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Expression<Func<TEntity, bool>> filterExpression,
            object masterEntityKey)
            : base(unitOfWorkFactory, getRepositoryFunc, filterExpression) {
            this.masterEntityKey = masterEntityKey;
        }
        public override void New() {
            if(DocumentManagerService == null)
                return;
            IDocument document = CreateDocument(new DetailEntityInfo<TMasterEntity>(masterEntityKey));
            document.Show();
        }
    }
}