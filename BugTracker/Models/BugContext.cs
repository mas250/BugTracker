using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BugTracker.Models
{
    public class BugContext : DbContext
    {
        public  BugContext() : base()
        {

        }
    public DbSet<Bug> Bugs { get; set; }

        public System.Data.Entity.DbSet<BugTracker> Tables { get; set; }
    }
}