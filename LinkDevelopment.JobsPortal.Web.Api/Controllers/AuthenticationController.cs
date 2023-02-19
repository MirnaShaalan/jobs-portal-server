using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Domain.Enums;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LinkDevelopment.JobsPortal.Web.Api.Controllers
{
    [Authorize]
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJWTService jWTService;
        private readonly IUserService userService;

        public AuthenticationController(IJWTService jWTService, IUserService userService)
        {
            this.jWTService = jWTService;
            this.userService = userService;
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult Login(AuthBaseEntity user)
        {
            try 
            { 
                var token = jWTService.Authenticate(user);

                if (token == null)
                {
                    return Unauthorized();
                }

                return Ok(token);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message.ToString());
            }
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("signup")]
        public IActionResult SignUp(User user)
        {
            User insertedUser;
            user.Role = RolesEnum.User.ToString();

                try
                {
                    insertedUser=userService.Insert(user);
                    AuthBaseEntity authUser = new AuthBaseEntity()
                    {
                        Name=user.Name,
                        Password=user.Password
                    };
                    var token = jWTService.Authenticate(authUser);

                    if (token == null)
                    {
                        return Unauthorized();
                    }

                    return Ok(token);

                }
                catch(Exception err)
                {
                    return BadRequest(err.Message.ToString());
                }          
        }
    }
}
