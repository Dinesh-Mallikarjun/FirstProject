namespace SchoolApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=StudentDBContext")
        {
        }

        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<subject>()
                .Property(e => e.subname)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .HasMany(e => e.teachers)
                .WithOptional(e => e.subject)
                .HasForeignKey(e => e.subId);

            modelBuilder.Entity<teacher>()
                .Property(e => e.tname)
                .IsUnicode(false);
        }
    }
}
