using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;


namespace LinkDevelopment.JobsPortal.Service.Services
{
    public class UserJobService : IUserJobService
    {
        private IUserJobRepository userjobRepository;


        public UserJobService(IUserJobRepository userjobRepository)
        {
            this.userjobRepository = userjobRepository;
        }

        public UserJob Insert(UserJob userjob, Applicant applicant)
        {
            var userJ = new UserJob
            {
                UserId = userjob.UserId,
                JobId = userjob.JobId
            };

            return userjobRepository.Insert(userJ, applicant);
        }

        public List<Job> GetJobs(Guid userId)
        {
            return userjobRepository.Get(userId);
        }

    }
}
