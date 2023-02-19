using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class editUserJobTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("08fe9832-f22f-42b4-8125-b1a0fa86f0ac"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("13707f37-23f2-4d13-96ca-70efc7ab424a"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("179ccd62-ce17-4817-8d26-1fbfaa07a7f0"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("3313a0db-3bcf-43ad-a7b6-8f323522e328"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("40cf6f1d-c599-47b8-bc7a-e928439f190e"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("ba811a21-09c0-48cc-8556-82cb73b4aba8"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("c1d513ec-a774-43be-9c68-1e4c2ac3359c"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("c7028fa8-c534-4067-b31a-0100d21448ea"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: new Guid("faa7019d-be89-444e-886b-cda7bcb2d01d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0dbb1337-f41c-4139-b6b5-bdd16b91ea12"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5bad018d-d3a3-4797-bec0-772173b76525"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "Category", "Description", "EndDate", "MaxApplications", "Name", "Skills", "StartDate" },
                values: new object[,]
                {
                    { new Guid("08fe9832-f22f-42b4-8125-b1a0fa86f0ac"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job7", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("13707f37-23f2-4d13-96ca-70efc7ab424a"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job1", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("179ccd62-ce17-4817-8d26-1fbfaa07a7f0"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job2", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("3313a0db-3bcf-43ad-a7b6-8f323522e328"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job6", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("40cf6f1d-c599-47b8-bc7a-e928439f190e"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job5", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba811a21-09c0-48cc-8556-82cb73b4aba8"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job8", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1d513ec-a774-43be-9c68-1e4c2ac3359c"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job3", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7028fa8-c534-4067-b31a-0100d21448ea"), "Job2 Category", "Job2 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 21, "Job9", "React,JavaScript,react Native", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("faa7019d-be89-444e-886b-cda7bcb2d01d"), "Job Category", "Job1 Description", new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified), 40, "Job4", "C#,Dot net,Sql", new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { new Guid("0dbb1337-f41c-4139-b6b5-bdd16b91ea12"), "admin@admin.com", "Admin", "admin", 1001001000, "admin" },
                    { new Guid("5bad018d-d3a3-4797-bec0-772173b76525"), "applicant1@applicant1.com", "applicant1", "applicant1", 1001001000, "applicant" }
                });
        }
    }
}
