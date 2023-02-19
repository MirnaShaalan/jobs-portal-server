using LinkDevelopment.JobsPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Repository.Contexts
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions options) : base(options)
        {
        }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserJob>()
            .HasKey(x => new { x.UserId, x.JobId });


            modelBuilder.Entity<UserJob>()
            .HasOne(u => u.User)
            .WithMany(uj => uj.UserJob)
            .HasForeignKey(ui => ui.UserId);

             modelBuilder.Entity<UserJob>()
            .HasOne(u => u.Job)
            .WithMany(uj => uj.UserJob)
            .HasForeignKey(ui => ui.JobId);



            // Data Seeding
                 modelBuilder.Entity<User>()
            .HasData(
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Password = "admin",
                Email = "admin@admin.com",
                PhoneNumber = 01001001000,
                Role = "admin"
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "applicant1",
                Password = "applicant1",
                Email = "applicant1@applicant1.com",
                PhoneNumber = 01001001000,
                Role = "applicant"
            });

                modelBuilder.Entity<Job>()
            .HasData(
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job1",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate =  new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate =  new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job2",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job3",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job4",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job5",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job6",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job7",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job8",
                Description = "Job1 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 40,
                Category = "Job Category",
                Skills = "C#,Dot net,Sql"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Name = "Job9",
                Description = "Job2 Description",
                Responsibilities = "Res1 kjsdkjgsd",
                StartDate = new DateTime(2023, 1, 19, 5, 10, 40),
                EndDate = new DateTime(2023, 1, 25, 5, 10, 40),
                MaxApplications = 21,
                Category = "Job2 Category",
                Skills = "React,JavaScript,react Native"
            });

       
    }
        public DbSet<Job> Job { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserJob> UserJob { get; set; }

    }
}

