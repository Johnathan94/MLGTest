using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MLGTest.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentID = table.Column<int>(name: "Department_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Department_ID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Engineering" },
                    { 2, "Accounting" },
                    { 3, "Managment" },
                    { 4, "Team Leads" },
                    { 5, "Businuess Team" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Department_ID", "Email", "HireDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Example@example.com", new DateTime(2022, 7, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(644), "Jonathan" },
                    { 2, 2, "Example@example.com", new DateTime(2022, 8, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(667), "Adam" },
                    { 3, 1, "Example@example.com", new DateTime(2022, 9, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(676), "Ahmed" },
                    { 4, 1, "Example@example.com", new DateTime(2022, 11, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(684), "Jon" },
                    { 5, 5, "Example@example.com", new DateTime(2022, 5, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(692), "Nawal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Department_ID",
                table: "Employees",
                column: "Department_ID");
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
