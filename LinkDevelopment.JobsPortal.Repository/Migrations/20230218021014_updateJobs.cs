using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("05171583-c186-44b5-984c-e891b20579c1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bbe90baf-f34b-455d-80e6-7918c7ea91ea"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserJob",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "Category", "Description", "EndDate", "MaxApplications", "Name", "Skills", "StartDate" },
                values: new object[,]
                {
                    { new Guid("33c32c08-6e33-4d0d-8c2f-123da400a92c"), "Job2 Category", "Job2 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 21, "Job2", "React,JavaScript,react Native", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("74002694-863a-42fb-bf8f-e5b2cd39ef64"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job1", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("09107f96-633c-4488-a426-80ffe3e175b2"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" },
                    { new Guid("1eafac6b-1fda-473e-8a4d-cb42ee811b65"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("33c32c08-6e33-4d0d-8c2f-123da400a92c"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("74002694-863a-42fb-bf8f-e5b2cd39ef64"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("09107f96-633c-4488-a426-80ffe3e175b2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1eafac6b-1fda-473e-8a4d-cb42ee811b65"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserJob");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("05171583-c186-44b5-984c-e891b20579c1"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("bbe90baf-f34b-455d-80e6-7918c7ea91ea"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }
    }
}
