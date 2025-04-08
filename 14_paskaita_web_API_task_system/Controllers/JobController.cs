using _14_paskaita_web_API_task_system.Models;
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
        [HttpGet("Jobs")]
        public IActionResult AllJobs()
        {
            return Ok(_jobService.GetJobsInRecentMemory());
        }
        [HttpPost]
        public IActionResult AddJob([FromForm] string name)
        {
            _jobService.AddJob(name);
            return Ok();
        }
    }
}
