using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories.Interface;

namespace WebApplication1.Repositories
{
    public class EmployeeWriteOnlyRepository : IEmployeeWriteOnlyRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeWriteOnlyRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();


            var parameters = new[]
            {
                new SqlParameter("@Id", employee.Id),
                new SqlParameter("@Name", employee.Name),
                new SqlParameter("@Email", employee.Email),
                new SqlParameter("@Mobile", employee.Mobile),
                new SqlParameter("@Epf", employee.Epf),
                new SqlParameter("@Address", employee.Address),
            };

            await _employeeDbContext.Database.ExecuteSqlRawAsync("InsertEmployee @Id, @Name, @Email, @Mobile, @Epf, @Address", parameters);

            return employee;
        }

    }
}
