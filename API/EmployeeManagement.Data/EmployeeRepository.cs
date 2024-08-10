using Dapper;
using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Employees WHERE EmployeeId = @Id";
                return await connection.QueryFirstOrDefaultAsync<Employee>(query, new { Id = id });
            }
        }

        public async Task UpdateEmployeeSalary(int id, decimal newSalary)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "UPDATE Employees SET Salary = @Salary WHERE EmployeeId = @Id";
                await connection.ExecuteAsync(query, new { Salary = newSalary, Id = id });
            }
        }
    }
}
