using EmployeeManagement.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicar configuraciones de seeds
            modelBuilder.ApplyConfiguration(new DepartmentSeeds());
            modelBuilder.ApplyConfiguration(new EmployeeSeeds());
        }
    }
}
