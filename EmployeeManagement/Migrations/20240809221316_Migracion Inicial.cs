using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Encargado de las relaciones laborales, nóminas, beneficios y capacitación.", "Recursos Humanos" },
                    { 2, "Gestiona la tecnología de la empresa, la infraestructura y la seguridad.", "Tecnología" },
                    { 3, "Responsable de impulsar las ventas y gestionar las relaciones con los clientes.", "Ventas" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "DepartmentId", "Description", "HireDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2010, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 50000m },
                    { 2, new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 70000m },
                    { 3, new DateTime(1992, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2016, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson", 60000m },
                    { 4, new DateTime(1988, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown", 55000m },
                    { 5, new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie Davis", 48000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
