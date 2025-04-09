using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Services.Interfaces
{
    public interface IJobService
    {
        public void AddNewJob(string name);
        public IEnumerable<Job> GetJobs();
        public IEnumerable<Job> GetJobsInRecentMemory();
        public void ChangeJobStatus(Job job);
        public void JobIsFinished(Job job);

    }
}
