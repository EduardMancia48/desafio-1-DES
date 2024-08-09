using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EmployeeManagement.Models.Seeds
{
    public class EmployeeSeeds : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "John Doe",
                    BirthDate = DateTime.Parse("1985-05-20"),
                    HireDate = DateTime.Parse("2010-08-15"),
                    Salary = 50000M,
                    DepartmentId = 1,
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Jane Smith",
                    BirthDate = DateTime.Parse("1990-03-10"),
                    HireDate = DateTime.Parse("2015-01-25"),
                    Salary = 70000M,
                    DepartmentId = 2,
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Alice Johnson",
                    BirthDate = DateTime.Parse("1992-07-11"),
                    HireDate = DateTime.Parse("2016-09-05"),
                    Salary = 60000M,
                    DepartmentId = 1,
                },
                new Employee
                {
                    EmployeeId = 4,
                    Name = "Bob Brown",
                    BirthDate = DateTime.Parse("1988-02-18"),
                    HireDate = DateTime.Parse("2012-11-19"),
                    Salary = 55000M,
                    DepartmentId = 3,
                },
                new Employee
                {
                    EmployeeId = 5,
                    Name = "Charlie Davis",
                    BirthDate = DateTime.Parse("1995-12-05"),
                    HireDate = DateTime.Parse("2018-04-20"),
                    Salary = 48000M,
                    DepartmentId = 2,
                }
            );
        }
    }
}
