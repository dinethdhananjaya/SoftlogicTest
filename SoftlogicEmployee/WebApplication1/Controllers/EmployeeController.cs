using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories.Interface;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmpployeeReadOnlyRepository _empployeeReadOnlyRepository;
        private readonly IEmployeeWriteOnlyRepository _employeeWriteOnlyRepository;

        public EmployeeController(IEmpployeeReadOnlyRepository empployeeReadOnlyRepository, IEmployeeWriteOnlyRepository employeeWriteOnlyRepository)
        {
            _empployeeReadOnlyRepository = empployeeReadOnlyRepository;
            _employeeWriteOnlyRepository = employeeWriteOnlyRepository;
        }

        [HttpGet]
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employee = await _empployeeReadOnlyRepository.GetAllEmployee();
            return employee;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Employee employee)
        {
            await _employeeWriteOnlyRepository.AddEmployee(employee);
            return Ok(employee);
        }
    }
}
