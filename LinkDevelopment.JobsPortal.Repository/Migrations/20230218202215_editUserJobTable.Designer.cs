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
    [Migration("20230218202215_editUserJobTable")]
    partial class editUserJobTable
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
                            Id = new Guid("0cd1c061-c173-44a7-8d3d-578151b4c316"),
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
                            Id = new Guid("55c639a0-66f7-45d4-9c60-d4417d7a090a"),
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
                            Id = new Guid("2e284682-734e-4ce5-ac27-988af4cfb761"),
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
                            Id = new Guid("31f0d4d0-e0d2-4a43-afa8-2b5f90e1ddb9"),
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
                            Id = new Guid("e45d7cf0-7144-4ee6-8728-5fa668c2e514"),
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
                            Id = new Guid("513e0ff6-337f-473d-9004-f037c426c43a"),
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
                            Id = new Guid("d215dcf1-f727-4d28-a0e5-f069912619d2"),
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
                            Id = new Guid("ddb59dcd-579d-4421-a1a5-178325beb1f2"),
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
                            Id = new Guid("1b791d80-8843-4918-aaa0-a1646d5ea4bd"),
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
                            Id = new Guid("fa2ee9e0-77f5-4b6e-a386-f03c3db399ce"),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "admin",
                            PhoneNumber = 1001001000,
                            Role = "admin"
                        },
                        new
                        {
                            Id = new Guid("a4ddd76f-5a1e-45d2-a607-6c961c3019cb"),
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
