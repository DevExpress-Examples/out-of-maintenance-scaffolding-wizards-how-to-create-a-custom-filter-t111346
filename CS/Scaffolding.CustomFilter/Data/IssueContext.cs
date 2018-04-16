using System.Data.Entity;

namespace Scaffolding.CustomFilter.Model {
    public class IssueContext : DbContext {
        public DbSet<Issue> Issues { get; set; }
    }
}
