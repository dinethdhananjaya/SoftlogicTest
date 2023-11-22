using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories.Interface;

namespace WebApplication1.Repositories
{
    public class EmpployeeReadOnlyRepository : IEmpployeeReadOnlyRepository
    {
        private readonly EmployeeDbContext _context;
        public EmpployeeReadOnlyRepository(EmployeeDbContext employeeDbContext)
        {
            _context = employeeDbContext;
        }
        public async Task<List<Employee>> GetAllEmployee()
        {
            var employee = await _context.Employees.ToListAsync();
            return employee;
        }
    }
}
