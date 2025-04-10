using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public interface IUserJobDb
    {
        public IEnumerable<Job> GetAllJobs();
        public IEnumerable<Job> GetJobsInMemory();
        public void AddNewJob(string name);
        public void AddExistingJobToDictionary(Job job);
        public void UpdateJobStatus(Job job);
        public Job GetJobFromDictionary(Guid id);
        public Job GetJobFromDb(Guid id);
        public void AddUser(User user);
        public void AddUserToDictionary(User user);
        public IEnumerable<User> GetUsersInMemory();
        public IEnumerable<User> GetAllUsers();
        public User GetUserFromDb(Guid id);
        public User GetUserFromDictionary(Guid id);
        public void AddUserToJob(User user, Job job);
        public void AddJobsFromDictionaryToDb();
    }
}
