using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public interface IUserJobDb
    {
        public IEnumerable<Job> GetAllJobs();
        public IEnumerable<Job> GetJobsInMemory();
        public void AddJob(string name);
        public void AddUser(User user);
        public IEnumerable<User> GetUsersInMemory();
        public IEnumerable<User> GetAllUsers();
    }
}
