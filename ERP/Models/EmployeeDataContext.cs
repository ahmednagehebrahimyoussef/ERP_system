using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP.Models
{
    public partial class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext()
        {
        }

        public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=EmployeeData;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account", "Employee_Data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Account_Name");

                entity.Property(e => e.LineOfBusiness)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line_of_business");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin", "Employee_Data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(100)
                    .HasColumnName("Password_Hash");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language", "Employee_Data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LanguageLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("language_level");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("language_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS", "Employee_Data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Language)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineOfBusiness)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NationalId)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("NationalID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
