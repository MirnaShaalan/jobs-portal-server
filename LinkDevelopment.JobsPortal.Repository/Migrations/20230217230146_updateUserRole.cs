using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("199bdf96-cbb0-47f5-9cfa-7977a51727d3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ad2c86fc-cc8a-4646-8639-1be9e37e2875"));

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("2c3f7e2c-7ceb-4795-b3ed-335a4190354b"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("76d655a7-0a2d-4167-b43c-2d33ebb439c1"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2c3f7e2c-7ceb-4795-b3ed-335a4190354b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d655a7-0a2d-4167-b43c-2d33ebb439c1"));

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("199bdf96-cbb0-47f5-9cfa-7977a51727d3"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("ad2c86fc-cc8a-4646-8639-1be9e37e2875"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }
    }
}
