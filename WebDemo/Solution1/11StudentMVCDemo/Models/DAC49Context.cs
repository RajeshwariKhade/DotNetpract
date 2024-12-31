using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _11StudentMVCDemo.Models
{
    public partial class DAC49Context : DbContext
    {
        public DAC49Context()
        {
        }

        public DAC49Context(DbContextOptions<DAC49Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; } = null!;
        public virtual DbSet<StudentPhone> StudentPhones { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=DAC49;Integrated Security=True;Pooling=False");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Summery)
                    .HasMaxLength(1024)
                    .HasColumnName("summery");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(128)
                    .HasColumnName("emailID");

                entity.Property(e => e.Namefirst)
                    .HasMaxLength(45)
                    .HasColumnName("namefirst");

                entity.Property(e => e.Namelast)
                    .HasMaxLength(45)
                    .HasColumnName("namelast");
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.ToTable("student_address");

                entity.HasIndex(e => e.StudentId, "UQ__student___4D11D65D8BE6190E")
                    .IsUnique();

                entity.HasIndex(e => e.Address, "UQ__student___751C8E54B09EE93C")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(128)
                    .HasColumnName("address");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.StudentAddress)
                    .HasForeignKey<StudentAddress>(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_a__stude__3F466844");
            });

            modelBuilder.Entity<StudentPhone>(entity =>
            {
                entity.ToTable("student_phone");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentPhones)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__student_p__stude__3A81B327");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
