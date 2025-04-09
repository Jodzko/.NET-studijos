using _14_paskaita_web_API_task_system.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class UserJobDb : IUserJobDb
    {
        private readonly UserJobDbContext _context;
        private readonly UserJobDictionary _dictionary;

        public UserJobDb(UserJobDbContext context, UserJobDictionary dictionary)
        {
            _context = context;
            _dictionary = dictionary;
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _context.Jobs;
        }
        public void AddNewJob(string name)
        {
            var newEntry = new Job(name);
            _dictionary.Jobs.Add(newEntry.Id, newEntry);
            _context.Add(newEntry);
            _context.SaveChanges();
        }
        public void AddExistingJobToDictionary(Job job)
        {
            _dictionary.Jobs.Add(job.Id, job);
        }
        public IEnumerable<Job> GetJobsInMemory()
        {
            return _dictionary.Jobs.Values;
        }

        public void AddUser(User user)
        {
            _dictionary.Users.Add(user.Id, user);
            _context.Add(user);
            _context.SaveChanges();
        }
        public void AddUserToDictionary(User user)
        {
            _dictionary.Users.Add(user.Id, user);
        }
        public IEnumerable<User> GetUsersInMemory()
        {
            return _dictionary.Users.Values;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
        public Job GetJobFromDb(Guid id)
        {
            return _context.Jobs.FirstOrDefault(x => x.Id == id);
        }
        public Job GetJobFromDictionary(Guid id)
        {
            return _dictionary.Jobs.FirstOrDefault(x => x.Value.Id == id).Value;

        }
        public void UpdateJobStatus(Job job)
        {
            var jobToUpdate = _context.Jobs.FirstOrDefault(x => x.Id == job.Id);
            _dictionary.Jobs.FirstOrDefault(x => x.Value.Id == job.Id).Value.Status = job.Status;
            _context.UpdateRange(jobToUpdate, job);
            _context.SaveChanges();
        }
    }
}
