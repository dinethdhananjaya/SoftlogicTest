using WebApplication1.Models;

namespace WebApplication1.Repositories.Interface
{
    public interface IEmployeeWriteOnlyRepository
    {
        Task<Employee> AddEmployee(Employee employee);
    }
}
