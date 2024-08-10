using AutoMapper;
using EmployeeManagement.Core.DTOs;
using EmployeeManagement.Core.Interfaces;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDto> UpdateEmployeeSalary(int id, decimal newSalary)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null) return null;

            await _employeeRepository.UpdateEmployeeSalary(id, newSalary);

            return _mapper.Map<EmployeeDto>(employee);
        }
    }
}
