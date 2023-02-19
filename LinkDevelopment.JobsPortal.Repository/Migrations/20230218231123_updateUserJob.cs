using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateUserJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserJob",
                table: "UserJob");

            migrationBuilder.DropIndex(
                name: "IX_UserJob_UserId",
                table: "UserJob");

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("0cd1c061-c173-44a7-8d3d-578151b4c316"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("1b791d80-8843-4918-aaa0-a1646d5ea4bd"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("2e284682-734e-4ce5-ac27-988af4cfb761"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("31f0d4d0-e0d2-4a43-afa8-2b5f90e1ddb9"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("513e0ff6-337f-473d-9004-f037c426c43a"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("55c639a0-66f7-45d4-9c60-d4417d7a090a"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("d215dcf1-f727-4d28-a0e5-f069912619d2"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("ddb59dcd-579d-4421-a1a5-178325beb1f2"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("e45d7cf0-7144-4ee6-8728-5fa668c2e514"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4ddd76f-5a1e-45d2-a607-6c961c3019cb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa2ee9e0-77f5-4b6e-a386-f03c3db399ce"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserJob");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserJob");

            migrationBuilder.AddColumn<string>(
                name: "Responsibilities",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserJob",
                table: "UserJob",
                columns: new[] { "UserId", "JobId" });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "Category", "Description", "EndDate", "MaxApplications", "Name", "Responsibilities", "Skills", "StartDate" },
                values: new object[,]
                {
                    { new Guid("021441fa-4c18-4aa9-8012-babc4d3a1f5c"), "Job2 Category", "Job2 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 21, "Job9", "Res1 kjsdkjgsd", "React,JavaScript,react Native", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("10749fe4-a3c2-4880-ac74-d8817c7f8551"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job5", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("4266bc70-ce59-4c10-9e6b-e3567af78516"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job4", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("4bbcd973-b3a8-435d-b2b3-55007cf67752"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job7", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cc5acda-f84d-4239-b76f-1b25571713aa"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job2", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b0d33f4-aabd-487e-adda-47762ade3b9b"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job1", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9575724-2bf5-4dcc-bf2f-7aa561c0fca0"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job3", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdf4cd66-a37a-440d-a446-8d297d77c886"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job6", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("f77913c2-c4d6-44ab-885c-6f6e943c7fda"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job8", "Res1 kjsdkjgsd", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("17df3af4-4738-4eb2-8c9a-51c133a0020e"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" },
                    { new Guid("d9bed691-c4f1-410e-912a-00aac701278e"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserJob",
                table: "UserJob");

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("021441fa-4c18-4aa9-8012-babc4d3a1f5c"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("10749fe4-a3c2-4880-ac74-d8817c7f8551"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("4266bc70-ce59-4c10-9e6b-e3567af78516"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("4bbcd973-b3a8-435d-b2b3-55007cf67752"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("4cc5acda-f84d-4239-b76f-1b25571713aa"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("9b0d33f4-aabd-487e-adda-47762ade3b9b"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("a9575724-2bf5-4dcc-bf2f-7aa561c0fca0"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("bdf4cd66-a37a-440d-a446-8d297d77c886"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("f77913c2-c4d6-44ab-885c-6f6e943c7fda"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("17df3af4-4738-4eb2-8c9a-51c133a0020e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d9bed691-c4f1-410e-912a-00aac701278e"));

            migrationBuilder.DropColumn(
                name: "Responsibilities",
                table: "Job");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserJob",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserJob",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserJob",
                table: "UserJob",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "Category", "Description", "EndDate", "MaxApplications", "Name", "Skills", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0cd1c061-c173-44a7-8d3d-578151b4c316"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job1", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b791d80-8843-4918-aaa0-a1646d5ea4bd"), "Job2 Category", "Job2 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 21, "Job9", "React,JavaScript,react Native", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e284682-734e-4ce5-ac27-988af4cfb761"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job3", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("31f0d4d0-e0d2-4a43-afa8-2b5f90e1ddb9"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job4", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("513e0ff6-337f-473d-9004-f037c426c43a"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job6", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("55c639a0-66f7-45d4-9c60-d4417d7a090a"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job2", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("d215dcf1-f727-4d28-a0e5-f069912619d2"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job7", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddb59dcd-579d-4421-a1a5-178325beb1f2"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job8", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("e45d7cf0-7144-4ee6-8728-5fa668c2e514"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job5", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("a4ddd76f-5a1e-45d2-a607-6c961c3019cb"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" },
                    { new Guid("fa2ee9e0-77f5-4b6e-a386-f03c3db399ce"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserJob_UserId",
                table: "UserJob",
                column: "UserId");
        }
    }
}
