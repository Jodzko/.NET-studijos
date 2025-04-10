using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public interface IJobRepository
    {
        public IEnumerable<Job> GetJobsInMemory();
        public void AddNewJob(string name);
        public void UpdateJobStatus(Job job);
        public Job GetJobFromDictionary(Guid id);
        public void AddUserToJob(User user, Job job);
        public void CheckAndAddJobs();

    }
}
