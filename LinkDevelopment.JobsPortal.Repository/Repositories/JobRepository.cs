using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Contexts;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LinkDevelopment.JobsPortal.Repository.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly PortalContext context;
        private DbSet<Job> jobEntity;

        public JobRepository(PortalContext context)
        {
            this.context = context;
            jobEntity = context.Set<Job>();
        }

        public JobDTO GetByName(int page, string name)
        {
            JobDTO jobDTO= new JobDTO();

             List<Job> jobs =jobEntity.Where(s => s.Name.Contains(name))
                .Skip(3 * (page - 1)).Take(3).
                ToList();

            jobDTO.jobs=jobs;
            jobDTO.jobsCount= jobEntity.Count();
            jobDTO.pagesCount= (jobEntity.Count() + 3 - 1) / 3;

            return jobDTO;
        }

        public JobDTO GetAll(int page)
        {
            JobDTO jobDTO = new JobDTO();
            var jobs =jobEntity.Skip(3 * (page - 1)).Take(3).ToList();

            jobDTO.jobs = jobs;
            jobDTO.jobsCount = jobEntity.Count();
            jobDTO.pagesCount = (jobEntity.Count() + 3 - 1) / 3;

            return jobDTO;
        }

        public Job Get(Guid id)
        {
            if (jobEntity == null)
            {
                throw new ArgumentNullException("entity");
            }

            return jobEntity.SingleOrDefault(s => s.Id == id);

        }

        public Job Insert(Job entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            jobEntity.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Job Update(Job entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<Job>().Update(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(Job entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            jobEntity.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(Job entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            jobEntity.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
