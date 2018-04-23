using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Scaffolding.CustomFilter.Model;
using DevExpress.Mvvm;

namespace Scaffolding.CustomFilter.ViewModels {
    public partial class IssueCollectionViewModel : ISupportLogicalLayout<string> {
        static readonly IEnumerable<FilterExpressionInfo<Issue>> filters = new FilterExpressionInfo<Issue>[] {
                        new FilterExpressionInfo<Issue> ("All",  x => true ),
                        new FilterExpressionInfo<Issue> ("For support", x => x.IssueType == IssueType.Question ),
                        new FilterExpressionInfo<Issue> ("For developers", x => x.IssueType == IssueType.Bug || x.IssueType == IssueType.Suggestion ),
                    };
        public IEnumerable<FilterExpressionInfo<Issue>> Filters { get { return filters; } }

        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            FilterExpression = Filters.First().Expression;
        }

        public void RestoreState(string state) {
            FilterExpression = Filters.First(f => f.DisplayName == state).Expression;
        }

        public string SaveState() {
            return Filters.First(f => f.Expression == FilterExpression).DisplayName;
        }
    }
    public class FilterExpressionInfo<TEntity> {
        public FilterExpressionInfo(string displayName, Expression<Func<TEntity, bool>> expression) {
            Expression = expression;
            DisplayName = displayName;
        }
        public Expression<Func<TEntity, bool>> Expression { get; private set; }
        public string DisplayName { get; private set; }
    }
}