﻿// <auto-generated />
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
    [Migration("20230218231123_updateUserJob")]
    partial class updateUserJob
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

                    b.Property<string>("Responsibilities")
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
                            Id = new Guid("9b0d33f4-aabd-487e-adda-47762ade3b9b"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job1",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4cc5acda-f84d-4239-b76f-1b25571713aa"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job2",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a9575724-2bf5-4dcc-bf2f-7aa561c0fca0"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job3",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4266bc70-ce59-4c10-9e6b-e3567af78516"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job4",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("10749fe4-a3c2-4880-ac74-d8817c7f8551"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job5",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("bdf4cd66-a37a-440d-a446-8d297d77c886"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job6",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4bbcd973-b3a8-435d-b2b3-55007cf67752"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job7",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f77913c2-c4d6-44ab-885c-6f6e943c7fda"),
                            Category = "Job Category",
                            Description = "Job1 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 40,
                            Name = "Job8",
                            Responsibilities = "Res1 kjsdkjgsd",
                            Skills = "C#,Dot net,Sql",
                            StartDate = new DateTime(2023, 1, 19, 5, 10, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("021441fa-4c18-4aa9-8012-babc4d3a1f5c"),
                            Category = "Job2 Category",
                            Description = "Job2 Description",
                            EndDate = new DateTime(2023, 1, 25, 5, 10, 40, 0, DateTimeKind.Unspecified),
                            MaxApplications = 21,
                            Name = "Job9",
                            Responsibilities = "Res1 kjsdkjgsd",
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
                            Id = new Guid("d9bed691-c4f1-410e-912a-00aac701278e"),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "admin",
                            PhoneNumber = 1001001000,
                            Role = "admin"
                        },
                        new
                        {
                            Id = new Guid("17df3af4-4738-4eb2-8c9a-51c133a0020e"),
                            Email = "applicant1@applicant1.com",
                            Name = "applicant1",
                            Password = "applicant1",
                            PhoneNumber = 1001001000,
                            Role = "applicant"
                        });
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.UserJob", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "JobId");

                    b.HasIndex("JobId");

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
