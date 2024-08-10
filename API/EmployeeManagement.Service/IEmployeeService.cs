using EmployeeManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
 
        public interface IEmployeeService
        {
            Task<EmployeeDto> UpdateEmployeeSalary(int id, decimal newSalary);
        }
    
}
