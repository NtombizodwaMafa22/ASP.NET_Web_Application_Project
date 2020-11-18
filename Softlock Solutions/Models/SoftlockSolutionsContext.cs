using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Softlock_Solutions.Models
{
    public partial class SoftlockSolutionsContext : DbContext
    {
        public SoftlockSolutionsContext()
        {
        }

        public SoftlockSolutionsContext(DbContextOptions<SoftlockSolutionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailabilityOfEmployee> AvailabilityOfEmployees { get; set; }
        public virtual DbSet<CurrentJobInformation> CurrentJobInformations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeWorkLife> EmployeeWorkLives { get; set; }
        public virtual DbSet<LoginDatum> LoginData { get; set; }
        public virtual DbSet<Perfomance> Perfomances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Softlock Solutions;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailabilityOfEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("AvailabilityOfEmployee");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Attrition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessTravel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DistanceFromHome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EnvironmentSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Over18)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CurrentJobInformation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("CurrentJobInformation");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.EmployeeCount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobInvolvement)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EducationField)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeWorkLife>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("EmployeeWorkLife");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.OverTime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalWorkingYears)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrainingTimesLastYear)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkLifeBalance)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsAtCompany)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsInCurrentRole)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsSinceLastPromotion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsWithCurrManager)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoginDatum>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("loginData");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("employeeId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Joblevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("joblevel");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("role");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Perfomance>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("Perfomance");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.NumCompaniesWorked)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelationshipSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
