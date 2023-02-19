using LinkDevelopment.JobsPortal.Domain.Entities;
using Microsoft.Extensions.Primitives;


namespace LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces
{
    public interface IJWTService
    {
        string Authenticate(AuthBaseEntity user);
        string extractTokenData(StringValues token , string dataName);
        
    }
}
