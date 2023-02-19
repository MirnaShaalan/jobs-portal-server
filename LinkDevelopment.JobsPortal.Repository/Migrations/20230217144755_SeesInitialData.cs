using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeesInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("e02a4301-16ee-463d-94a4-fa17fd3ee15d"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" },
                    { new Guid("ff691d3c-61b8-47e0-a0f0-bcf52ac74183"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e02a4301-16ee-463d-94a4-fa17fd3ee15d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ff691d3c-61b8-47e0-a0f0-bcf52ac74183"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");
        }
    }
}
