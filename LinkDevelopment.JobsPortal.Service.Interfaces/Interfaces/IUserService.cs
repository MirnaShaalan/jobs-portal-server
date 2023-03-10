using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces
{
    public interface IUserService
    {
        User GetUserById(Guid userId);
        User GetUserByName(string name);

        User Insert(User user);

        User Update(User user);

        void Delete(Guid userId);

    }
}