using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Bug
    {
        public int id { get; set; }
        public DateTime dateFound { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public enum status
        {
            discovered = 1,
            onHold = 2,
            workInProgress = 3,
            codeReview = 4,
            completed = 5
        }

    }
}