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
    [Migration("20230217144755_SeesInitialData")]
    partial class SeesInitialData
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaxApplications")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("LinkDevelopment.JobsPortal.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff691d3c-61b8-47e0-a0f0-bcf52ac74183"),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "admin",
                            PhoneNumber = 1001001000,
                            Role = "admin"
                        },
                        new
                        {
                            Id = new Guid("e02a4301-16ee-463d-94a4-fa17fd3ee15d"),
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