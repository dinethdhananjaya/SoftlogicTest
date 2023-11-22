using WebApplication1.Models;

namespace WebApplication1.Repositories.Interface
{
    public interface IEmpployeeReadOnlyRepository
    {
        Task<List<Employee>> GetAllEmployee();
    }
}
