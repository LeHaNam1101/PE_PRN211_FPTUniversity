using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Q2.Models;

public partial class PePrnSpr23B5Context : DbContext
{
    public PePrnSpr23B5Context()
    {
    }

    public PePrnSpr23B5Context(DbContextOptions<PePrnSpr23B5Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();
        var connectionString = configuration.GetConnectionString("MyDatabase");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Department");

            entity.Property(e => e.DepartmentId).ValueGeneratedOnAdd();
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Instructor");

            entity.Property(e => e.ContractDate).HasColumnType("date");
            entity.Property(e => e.Fullname).HasMaxLength(200);
            entity.Property(e => e.InstructorId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Major");

            entity.Property(e => e.MajorCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MajorName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.Dob).HasColumnType("date");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.Major)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
