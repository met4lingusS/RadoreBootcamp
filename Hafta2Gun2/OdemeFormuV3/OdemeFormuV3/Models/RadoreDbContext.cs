using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OdemeFormuV3.Models;

public partial class RadoreDbContext : DbContext
{
    public RadoreDbContext()
    {
    }

    public RadoreDbContext(DbContextOptions<RadoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FormQuestion> FormQuestions { get; set; }

    public virtual DbSet<FormType> FormTypes { get; set; }

    public virtual DbSet<OdemeTipi> OdemeTipis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Connection String");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FormQuestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FORM_QUESTION", "Registering");

            entity.Property(e => e.FormId).HasColumnName("FORM_ID");
            entity.Property(e => e.QuestionClassName)
                .HasMaxLength(50)
                .HasColumnName("QUESTION_CLASS_NAME");
            entity.Property(e => e.QuestionDisplayValue)
                .HasMaxLength(50)
                .HasColumnName("QUESTION_DISPLAY_VALUE");
            entity.Property(e => e.QuestionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("QUESTION_ID");
        });

        modelBuilder.Entity<FormType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FORM_TYPE", "Registering");

            entity.Property(e => e.FClassName)
                .HasMaxLength(50)
                .HasColumnName("F_CLASS_NAME");
            entity.Property(e => e.FDisplayName)
                .HasMaxLength(50)
                .HasColumnName("F_DISPLAY_NAME");
            entity.Property(e => e.FormId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FORM_ID");
        });

        modelBuilder.Entity<OdemeTipi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OdemeTipi");

            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .HasColumnName("CLASS_NAME");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("DISPLAY_NAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
