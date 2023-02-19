using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;


namespace LinkDevelopment.JobsPortal.Service.Services
{
    public class JobService : IJobService
    {
        private IJobRepository jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public JobDTO GetJobs(int page, string search = "")
        {
            if (search == "" || search == null)
                return jobRepository.GetAll(page);
            else
                return jobRepository.GetByName(page, search);
        }

        public Job GetJobById(Guid id)
        {
            return jobRepository.Get(id);
        }

        public Job Insert(Job job)
        {
            return jobRepository.Insert(job);
        }

        public Job Update(Job job)
        {
            return jobRepository.Update(job);
        }

        public void Delete(Guid id)
        {
            Job job = GetJobById(id);
            jobRepository.Remove(job);
            jobRepository.SaveChanges();
        }
    }
}
