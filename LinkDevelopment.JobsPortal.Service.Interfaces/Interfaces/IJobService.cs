using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces
{
    public interface IJobService
    {
        JobDTO GetJobs(int page, string search);

        Job GetJobById(Guid jobId);

        Job Insert(Job job);

        Job Update(Job job);

        void Delete(Guid jobId);

    }
}