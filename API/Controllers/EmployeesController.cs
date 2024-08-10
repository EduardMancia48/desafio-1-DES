using EmployeeManagement.Core.DTOs;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPut("{id}/salary")]
        public async Task<IActionResult> UpdateSalary(int id, [FromBody] decimal newSalary)
        {
            var updatedEmployee = await _employeeService.UpdateEmployeeSalary(id, newSalary);
            if (updatedEmployee == null)
            {
                return NotFound();
            }

            return Ok(updatedEmployee);
        }
    }
}
