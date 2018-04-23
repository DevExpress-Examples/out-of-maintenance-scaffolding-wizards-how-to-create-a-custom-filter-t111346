using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;

namespace Scaffolding.CustomFilter.Model {
    public class IssueContextInitializer : DropCreateDatabaseIfModelChanges<IssueContext> {
        protected override void Seed(IssueContext context) {
            base.Seed(context);
            context.Issues.Add(new Issue { IssueType = IssueType.Question, CreatedOn = new DateTime(2014, 4, 14), IsUrgent = true, Subject = "How to add a new row" });
            context.Issues.Add(new Issue { IssueType = IssueType.Question, CreatedOn = new DateTime(2014, 2, 15), IsUrgent = false, Subject = "Application is crashed in some scenarios" });
            context.Issues.Add(new Issue { IssueType = IssueType.Question, CreatedOn = new DateTime(2014, 3, 16), IsUrgent = true, Subject = "When do you plan to release the next version?" });
            context.Issues.Add(new Issue { IssueType = IssueType.Bug, CreatedOn = new DateTime(2014, 3, 12), IsUrgent = false, Subject = "Values are not rendered" });
            context.Issues.Add(new Issue { IssueType = IssueType.Bug, CreatedOn = new DateTime(2014, 1, 23), IsUrgent = true, Subject = "Cell values are not saved properly" });
            context.Issues.Add(new Issue { IssueType = IssueType.Suggestion, CreatedOn = new DateTime(2014, 2, 18), IsUrgent = false, Subject = "Provide the capability to sort data" });
            context.SaveChanges();
        }
    }
}