using _14_paskaita_web_API_task_system.Cache;
using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Requests;
using _14_paskaita_web_API_task_system.Services;
using _14_paskaita_web_API_task_system.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_paskaita_web_API_task_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet("Jobs")]
        public IActionResult AllJobs()
        {
            return Ok(_jobService.GetJobs());
        }
        [HttpPost]
        public IActionResult AddJob([FromForm] string name)
        {
            _jobService.AddNewJob(name);
            return Ok();
        }
        [HttpPut("StatusChange")]
        public IActionResult ChangeStatus([FromQuery]Guid id)
        {
            var job = _jobService.GetJob(id);
            _jobService.ChangeJobStatus(job);
            return Ok();
        }
        [HttpPut("JobIsFinished")]
        public IActionResult JobIsFinished([FromForm]Guid id)
        {
            var job = _jobService.GetJob(id);
            _jobService.JobIsFinished(job);
            return Ok();
        }
        [HttpGet("ByStatus")]
        public IActionResult GetJobsByStatus([FromQuery]string status)
        {
            return Ok(_jobService.GetJobsByStatus(status));
        }
        [HttpPut("AddUserToJob")]
        public IActionResult AssignUserToJob([FromQuery]Guid userId, [FromQuery]Guid jobId)
        {
            _jobService.AssignUserToJob(userId, jobId);
            return Ok();
        }
    }
}
