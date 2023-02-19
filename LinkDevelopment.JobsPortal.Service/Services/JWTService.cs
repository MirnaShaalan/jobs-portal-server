using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LinkDevelopment.JobsPortal.Service.Services
{
    public class JWTService : IJWTService
    {

        private readonly IConfiguration iconfiguration;
        private IJWTRepository jWTRepository;

        public JWTService(IConfiguration iconfiguration, IJWTRepository jWTRepository)
        {
            this.iconfiguration = iconfiguration;
            this.jWTRepository = jWTRepository;
        }

        public string Authenticate(AuthBaseEntity user)
        {
            User systemUser = jWTRepository.ValidateAuthenticate(user);
            if (systemUser == null)
            {
                return null;
            }

            var claims = new[] {
                         new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                         new Claim("userid", systemUser.Id.ToString()),
                         new Claim("username", systemUser.Name),
                         new Claim("usermail", systemUser.Email ),
                         new Claim("userrole", systemUser.Role ),
                         new Claim(ClaimTypes.Role,systemUser.Role)
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(iconfiguration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                iconfiguration["Jwt:Issuer"],
                iconfiguration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(50),
                signingCredentials: signIn
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public string extractTokenData(StringValues token, string dataName)
        {
            var jwtTokenn = token.ToString().Replace("Bearer ", string.Empty);
            var verfiedToken = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtTokenn);

            var userData = verfiedToken.Claims.First(x => x.Type == dataName).Value;
            return userData;
        }
    }
}
