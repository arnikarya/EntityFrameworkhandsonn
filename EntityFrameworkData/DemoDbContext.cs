using EntityFrameworkData.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkData
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
       public DemoDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-QQUJ36KT\MSSQLSERVER01;Database=EntityFrameworkDb;Trusted_Connection=True;");


        }
    }
}