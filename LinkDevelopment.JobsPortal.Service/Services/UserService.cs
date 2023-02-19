using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;


namespace LinkDevelopment.JobsPortal.Service.Services
{
    public class UserService : IUserService
    {
        private ICrudRepository<User> userRepository;

        public UserService(ICrudRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUserById(Guid id)
        {
            return userRepository.Get(id);
        }

        public User GetUserByName(string name)
        {
            return userRepository.GetByName(name);
        }

        public User Insert(User user)
        {
            if (userRepository.GetByName(user.Name) != null)
                return null;
            return userRepository.Insert(user);
        }

        public User Update(User user)
        {
            return userRepository.Update(user);
        }

        public void Delete(Guid id)
        {
            User user = GetUserById(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

    }
}
