using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class Bug
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        public DateTime dateFound { get; set; }
        [Required]
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