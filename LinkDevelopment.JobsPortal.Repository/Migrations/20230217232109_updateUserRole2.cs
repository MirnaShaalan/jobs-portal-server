using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2c3f7e2c-7ceb-4795-b3ed-335a4190354b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d655a7-0a2d-4167-b43c-2d33ebb439c1"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("05171583-c186-44b5-984c-e891b20579c1"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("bbe90baf-f34b-455d-80e6-7918c7ea91ea"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("05171583-c186-44b5-984c-e891b20579c1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bbe90baf-f34b-455d-80e6-7918c7ea91ea"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("2c3f7e2c-7ceb-4795-b3ed-335a4190354b"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("76d655a7-0a2d-4167-b43c-2d33ebb439c1"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }
    }
}
