namespace BugTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BugTracker : DbContext
    {
        public BugTracker()
            : base("name=BugTracker")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
