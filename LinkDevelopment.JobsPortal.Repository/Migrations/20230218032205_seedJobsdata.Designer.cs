// <auto-generated />
using System;
using LinkDevelopment.JobsPortal.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LinkDevelopment.JobsPortal.Repository.Migrations
{
    [DbContext(typeof(PortalContext))]
    [Migration("20230218032205_seedJobsdata")]
    partial class seedJobsdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxApplications")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Job");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13707f37-23f2-4d13-96ca-70efc7ab424a"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job1",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("179ccd62-ce17-4817-8d26-1fbfaa07a7f0"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job2",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c1d513ec-a774-43be-9c68-1e4c2ac3359c"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job3",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("faa7019d-be89-444e-886b-cda7bcb2d01d"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job4",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("40cf6f1d-c599-47b8-bc7a-e928439f190e"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job5",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3313a0db-3bcf-43ad-a7b6-8f323522e328"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job6",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("08fe9832-f22f-42b4-8125-b1a0fa86f0ac"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job7",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ba811a21-09c0-48cc-8556-82cb73b4aba8"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job8",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c7028fa8-c534-4067-b31a-0100d21448ea"),
                            Category = "Job2 Category",
                            Description = "Job2 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 21,
                            Name = "Job9",
                            Skills = "React,JavaScript,react Native",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0dbb1337-f41c-4139-b6b5-bdd16b91ea12"),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "admin",
                            PhoneNumber = 1001001000,
                            Role = "admin"
                        },
                        new
                        {
                            Id = new Guid("5bad018d-d3a3-4797-bec0-772173b76525"),
                            Email = "applicant1@applicant1.com",
                            Name = "applicant1",
                            Password = "applicant1",
                            PhoneNumber = 1001001000,
                            Role = "applicant"
                        });
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.UserJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("UserJob");
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.UserJob", b =>
                {
                    b.HasOne("LinkDevelopment.JobsPortal.Domain.Entities.Job", "Job")
                        .WithMany("UserJob")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LinkDevelopment.JobsPortal.Domain.Entities.User", "User")
                        .WithMany("UserJob")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.Job", b =>
                {
                    b.Navigation("UserJob");
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.User", b =>
                {
                    b.Navigation("UserJob");
                });
#pragma warning restore 612, 618
        }
    }
}
