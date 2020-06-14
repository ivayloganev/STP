using Microsoft.EntityFrameworkCore;
using STP.Models;

namespace STP.Data
{
    public class STPContext : DbContext
    {
        protected STPContext()
        {
        }
        public STPContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Office>().ToTable("Office");
            modelBuilder.Entity<Employee>().ToTable("Employee");

            modelBuilder.Entity<Company>(entity =>
            {
                entity
                    .HasKey(c => c.Id);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(c => c.CreationDate)
                    .IsRequired(true);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity
                    .HasKey(o => o.Id);

                entity
                    .Property(o => o.Country)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(o => o.City)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(o => o.Street)
                    .HasMaxLength(100)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(o => o.StreetNumber)
                    .IsRequired(true);

                entity
                    .Property(o => o.IsHeadquarters)
                    .IsRequired(true);

                entity
                    .HasOne(o => o.Company)
                    .WithMany(c => c.Offices)
                    .HasForeignKey(o => o.CompanyId);

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity
                    .HasKey(e => e.Id);

                entity
                    .Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(e => e.StartingDate)
                    .IsRequired(true);

                entity
                    .Property(e => e.Salary)
                    .IsRequired(true);

                entity
                    .Property(e => e.VacationDays)
                    .IsRequired(true);

                entity
                    .Property(e => e.Experience)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.Office)
                    .WithMany(o => o.Employees)
                    .HasForeignKey(e => e.OfficeId);

            });
        }
    }
}
