using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Contexts;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace LinkDevelopment.JobsPortal.Repository.Repositories
{
    public class JWTRepository : IJWTRepository
    {

        private DbSet<User> entities;
        public JWTRepository(PortalContext context)
        {
            entities = context.Set<User>();
        }


        public User ValidateAuthenticate(AuthBaseEntity entity)
        {
            User user = entities.FirstOrDefault(x => x.Name == entity.Name && x.Password == entity.Password);
            return user;
        }

    }
}
