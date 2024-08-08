using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public string? Description { get; set; }

        // Navigation property for related Employees
        public ICollection<Employee> Employees
        {
            get; set;
                }

    }
}
