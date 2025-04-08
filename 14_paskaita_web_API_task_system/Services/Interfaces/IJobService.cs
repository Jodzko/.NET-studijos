using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Services.Interfaces
{
    public interface IJobService
    {
        public void AddJob(string name);
        public IEnumerable<Job> GetJobs();
        public IEnumerable<Job> GetJobsInRecentMemory();

    }
}
