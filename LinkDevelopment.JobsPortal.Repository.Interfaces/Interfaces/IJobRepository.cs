using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces
{
    public interface IJobRepository : ICrudRepository<Job> 
    {
        JobDTO GetByName(int page, string name);
        JobDTO GetAll(int page);
    }
}
