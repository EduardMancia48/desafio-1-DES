using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Salary must be greater than zero.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public string? Description { get; set; }

        // Foreign key for Department
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        // Navigation property for the Department
        public Department Department { get; set; }
    }
}
