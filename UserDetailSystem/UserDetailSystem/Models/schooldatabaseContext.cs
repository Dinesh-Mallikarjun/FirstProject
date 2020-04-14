using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UserDetailSystem.Models
{
    public partial class schooldatabaseContext : DbContext
    {
        public schooldatabaseContext()
        {
        }

        public schooldatabaseContext(DbContextOptions<schooldatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=schooldatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.ToTable("subjects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Modules).HasColumnName("modules");

                entity.Property(e => e.Subname)
                    .HasColumnName("subname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.ToTable("teachers");

                entity.Property(e => e.Teachersid)
                    .HasColumnName("teachersid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SubId).HasColumnName("subId");

                entity.Property(e => e.Tname)
                    .HasColumnName("tname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.SubId)
                    .HasConstraintName("FK__teachers__subId__1273C1CD");
            });
        }
    }
}
