using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Services.Interfaces
{
    public interface IJobService
    {
        public void AddNewJob(string name);
        public IEnumerable<Job> GetJobs();
        public IEnumerable<Job> GetJobsInRecentMemory();
        public Job GetJob(Guid id);
        public IEnumerable<Job> GetJobsByStatus(string status);
        public void ChangeJobStatus(Job job);
        public void JobIsFinished(Job job);
        public void AssignUserToJob(Guid userId, Guid jobId);

    }
}
