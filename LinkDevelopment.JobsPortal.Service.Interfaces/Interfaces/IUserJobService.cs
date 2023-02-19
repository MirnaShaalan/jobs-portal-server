using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces
{
    public interface IUserJobService
    {
        UserJob Insert(UserJob userjob, Applicant applicant);
        List<Job> GetJobs(Guid userId);
     
    }
}
