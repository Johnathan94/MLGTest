using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MLGTest.Entities;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace MLGTest.DataHelpers
{
    public class MLGDataContext : DbContext
    {
        public MLGDataContext(DbContextOptions<MLGDataContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(s => s.Department_ID);
            SeedTestData(modelBuilder);
        }
        private void SeedTestData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department { ID = 1, Name = $"Engineering" });
            modelBuilder.Entity<Department>().HasData(new Department { ID = 2, Name = $"Accounting" });
            modelBuilder.Entity<Department>().HasData(new Department { ID = 3, Name = $"Managment" });
            modelBuilder.Entity<Department>().HasData(new Department { ID = 4, Name = $"Team Leads" });
            modelBuilder.Entity<Department>().HasData(new Department { ID = 5, Name = $"Businuess Team" });
            modelBuilder.Entity<Employee>().HasData(new Employee { ID = 1, Name = $"Jonathan", Department_ID = 1, Email = "Example@example.com", HireDate = DateTime.Now.AddMonths(-6) });
            modelBuilder.Entity<Employee>().HasData(new Employee { ID = 2, Name = $"Adam", Department_ID = 2, Email = "Example@example.com", HireDate = DateTime.Now.AddMonths(-5) });
            modelBuilder.Entity<Employee>().HasData(new Employee { ID = 3, Name = $"Ahmed", Department_ID = 1, Email = "Example@example.com", HireDate = DateTime.Now.AddMonths(-4) });
            modelBuilder.Entity<Employee>().HasData(new Employee { ID = 4, Name = $"Jon", Department_ID = 1, Email = "Example@example.com", HireDate = DateTime.Now.AddMonths(-2) });
            modelBuilder.Entity<Employee>().HasData(new Employee { ID = 5, Name = $"Nawal", Department_ID = 5, Email = "Example@example.com", HireDate = DateTime.Now.AddMonths(-8) });


        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
