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
            var job = _dictionary.Jobs.FirstOrDefault(x => x.Value.Name == name).Value;
            if(job == null)
            {
                job = _context.Jobs.FirstOrDefault(x => x.Name == name);
                if(job == null)
                {
                    var newEntry = new Job(name);
                    _dictionary.Jobs.Add(newEntry.Id, newEntry);
                    _context.Add(newEntry);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception ("The job is already in the database");
                }
            }
            else
            {
                throw new Exception ("The job is already in the dictionary");
            }
        }
        public void AddJobsFromDictionaryToDb()
        {
            foreach (var item in _context.Jobs)
            {
                _dictionary.Jobs.Add(item.Id, item);
            }
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
        public User GetUserFromDictionary(Guid id)
        {
            return _dictionary.Users.FirstOrDefault(x => x.Value.Id == id).Value;
        }
        public User GetUserFromDb(Guid id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateJobStatus(Job job)
        {
            var jobToUpdate = _context.Jobs.FirstOrDefault(x => x.Id == job.Id);
            _dictionary.Jobs.FirstOrDefault(x => x.Value.Id == job.Id).Value.Status = job.Status;
            _context.UpdateRange(jobToUpdate, job);
            _context.SaveChanges();
        }
        public void AddUserToJob(User user, Job job)
        {
            var jobToUpdate = _dictionary.Jobs.FirstOrDefault(x => x.Value.Id == job.Id);
            jobToUpdate.Value.Users.Add(user);
            _context.Update(jobToUpdate);
            _context.SaveChanges();
        }
    }
}
