using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;


namespace LinkDevelopment.JobsPortal.Web.Api.Controllers
{
    [Authorize]
    [Route("api/userjobs")]
    [ApiController]
    public class UserJobController : ControllerBase
    {

        private readonly IUserJobService userJobService;
        private readonly IJWTService jWTService;

        public UserJobController(IUserJobService userJobService, IJWTService jWTService)
        {
            this.userJobService = userJobService;
            this.jWTService = jWTService;
        }


        [Authorize(Roles = "User")]
        [HttpPost]
        [Route("Add")]
        public IActionResult AddJob([FromHeader] string Authorization, Guid jobId, Applicant applicant)
        {   
            StringValues token = Authorization;
            Guid userId = new Guid (jWTService.extractTokenData(token, "userid"));
            try
            {
                var userJob = new UserJob
                {
                    UserId = userId,
                    JobId = jobId
                };

                UserJob insertedJob = userJobService.Insert(userJob, applicant);
                
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Authorize(Roles = "User")]
        [HttpGet]
        [Route("Get")]
        public IActionResult GetJobs([FromHeader] string Authorization)
        {

            StringValues token = Authorization;
            Guid userId = new Guid(jWTService.extractTokenData(token, "userid"));
            try
            {         
                var user = userJobService.GetJobs(userId);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
