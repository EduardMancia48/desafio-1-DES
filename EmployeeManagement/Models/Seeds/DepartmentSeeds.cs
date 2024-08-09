using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Models.Seeds
{
    public class DepartmentSeeds : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    DepartmentId = 1,
                    Name = "Recursos Humanos",
                    Description = "Encargado de las relaciones laborales, nóminas, beneficios y capacitación."
                },
                new Department
                {
                    DepartmentId = 2,
                    Name = "Tecnología",
                    Description = "Gestiona la tecnología de la empresa, la infraestructura y la seguridad."
                },
                new Department
                {
                    DepartmentId = 3,
                    Name = "Ventas",
                    Description = "Responsable de impulsar las ventas y gestionar las relaciones con los clientes."
                }
            );
        }
    }
}
