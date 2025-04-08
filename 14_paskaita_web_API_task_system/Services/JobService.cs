using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class JobService : IJobService
    {
        private readonly IUserJobDb _userJobDb;

        public JobService(IUserJobDb userJobDb)
        {
            _userJobDb = userJobDb;
        }

        public void AddJob(string name)
        {
            _userJobDb.AddJob(name);
        }
        public IEnumerable<Job> GetJobs()
        {
            return _userJobDb.GetAllJobs();
        }
        public IEnumerable<Job> GetJobsInRecentMemory()
        {
            return _userJobDb.GetJobsInMemory();
        }
    }
}
