using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces
{
    public interface IUserJobRepository 
    {
        UserJob Insert(UserJob entity,Applicant applicant );

        List<Job> Get(Guid id);
    }
}
