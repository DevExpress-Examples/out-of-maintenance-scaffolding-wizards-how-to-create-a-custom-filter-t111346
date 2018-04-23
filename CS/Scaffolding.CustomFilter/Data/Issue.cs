using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Scaffolding.CustomFilter.Model {
    public class Issue {
        public int ID { get; set; }
        public IssueType IssueType { get; set; }
        public string Subject { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}