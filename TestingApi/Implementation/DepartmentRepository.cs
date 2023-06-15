using Microsoft.EntityFrameworkCore;
using TestingApi.Data;
using TestingApi.Models;
using TestingApi.Repositories;

namespace TestingApi.Implmentaion
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            var result = await _appDbContext.Departments
                .FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
            return result;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _appDbContext.Departments.ToListAsync();
        }
    }
}
