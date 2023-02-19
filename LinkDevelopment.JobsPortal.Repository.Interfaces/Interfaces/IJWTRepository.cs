using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces
{
    public interface IJWTRepository
    {
        User ValidateAuthenticate(AuthBaseEntity entity);
    }
}
