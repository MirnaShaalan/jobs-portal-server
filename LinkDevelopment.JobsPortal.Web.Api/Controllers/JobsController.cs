using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Service.Interfaces.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LinkDevelopment.JobsPortal.Web.Api.Controllers
{
    [Authorize]
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {

        private readonly IJobService jobService;

        public JobsController(IJobService jobService)
        {
            this.jobService = jobService;

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Get")]
        public IActionResult GetJobs([FromQuery]int page,[FromQuery] string? search="")
        {
            try
            {
                var jobs = jobService.GetJobs(page,search);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("GetById")]
        public IActionResult GetJobById(Guid id)
        {
            try
            {
                var job = jobService.GetJobById(id);
                return Ok(job);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("Add")]
        public IActionResult AddJob(Job job)
        {
             try
            {
                Job insertedJob=jobService.Insert(job);
                return Ok(insertedJob);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        [Route("update")]
        public IActionResult EditJob(Job job)
        {
            try
            {
                Job insertedJob = jobService.Update(job);
                return Ok(insertedJob);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteJob(Guid id)
        {
            try
            {
                jobService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}