using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Contexts;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace LinkDevelopment.JobsPortal.Repository.Repositories
{
    public class UserJobRepository : IUserJobRepository
    {

        private readonly PortalContext context;
        private readonly IJobRepository jobRepository;

        public UserJobRepository(PortalContext context, IJobRepository jobRepository)
        {
            this.context = context;
            this.jobRepository = jobRepository;
        }

        public List<Job> Get(Guid id)
        {
            List<Job> retrivedJobs = new List<Job>();

            User userJobs =  context.User.Include(x => x.UserJob)
                .ThenInclude(xp => xp.Job).AsNoTracking().FirstOrDefault(m => m.Id == id) ;

            List<UserJob> usrJobs = userJobs.UserJob;

            foreach(UserJob uJob in usrJobs)
            {
                uJob.Job.UserJob = null;
                retrivedJobs.Add(uJob.Job);
            }
            return retrivedJobs;
        }

        public UserJob Insert(UserJob entity, Applicant applicant)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.User= context.User.FirstOrDefault(x => x.Id == entity.UserId);

            entity.Job = context.Job.FirstOrDefault(x => x.Id == entity.JobId);

            entity.Job.MaxApplications -= 1;

            if(entity.Job.MaxApplications <= 0) 
            { 
                entity.Job.EndDate = new DateTime(2022, 2, 2, 2, 2, 2);
            }
            jobRepository.Update(entity.Job);
            context.UserJob.Add(entity);
            context.SaveChanges();
            return entity;

        }
    }
}
