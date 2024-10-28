using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentsAPI.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__tbl_Stud__32C52B99F87ECF3C");

            entity.ToTable("tbl_Student");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StudentGrade)
                .HasMaxLength(50)
                .HasColumnName("StudentGrade ");
            entity.Property(e => e.StudentName).HasMaxLength(50);
            entity.Property(e => e.StudentRollNo).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
