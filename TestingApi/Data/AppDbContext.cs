using Microsoft.EntityFrameworkCore;
using TestingApi.Models;

namespace TestingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        internal Task RemoveAsync(Employee result)
        {
            throw new NotImplementedException();
        }
    }
}
