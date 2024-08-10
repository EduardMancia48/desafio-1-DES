using EmployeeManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Interfaces
{
   public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeById(int id);
        Task UpdateEmployeeSalary(int id, decimal newSalary);

    }
}
