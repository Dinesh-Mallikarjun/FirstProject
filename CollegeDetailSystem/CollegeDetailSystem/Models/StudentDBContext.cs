using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CollegeDetailSystem.Models
{
    public partial class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {
        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>(entity =>
            {
                entity.ToTable("college");

                entity.Property(e => e.ColegeName)
                    .HasColumnName("colegeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CutOffPercentage)
                    .HasColumnName("cutOffPercentage")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentageObtained).HasColumnType("decimal(10, 0)");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Collegeid)
                    .HasConstraintName("FK__student__College__1273C1CD");
            });
        }
    }
}
