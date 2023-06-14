using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ims.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addEmployessView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployessView",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    salariesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployessView", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployessView_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "DId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployessView_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "EId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployessView_Salaries_salariesId",
                        column: x => x.salariesId,
                        principalTable: "Salaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployessView_DepartmentsId",
                table: "EmployessView",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployessView_EmployeesId",
                table: "EmployessView",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployessView_salariesId",
                table: "EmployessView",
                column: "salariesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployessView");
        }
    }
}
