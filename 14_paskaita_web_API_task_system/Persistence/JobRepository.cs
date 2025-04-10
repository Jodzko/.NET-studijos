using _14_paskaita_web_API_task_system.Cache;
using _14_paskaita_web_API_task_system.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class JobRepository : IJobRepository
    {
        private readonly UserJobDbContext _context;
        private readonly JobCache _jobs;
        private readonly IUserRepository _users;

        public JobRepository(UserJobDbContext context, JobCache jobs, IUserRepository users)
        {
            _context = context;
            _jobs = jobs;
            _users = users;
        }
        public void AddNewJob(string name)
        {
            CheckAndAddJobs(); 
            var job = _jobs.Jobs.FirstOrDefault(x => x.Value.Name == name).Value;
            if(job == null)
            {
                var newEntry = new Job(name);
                _jobs.Jobs.Add(newEntry.Id, newEntry);
                _context.Add(newEntry);
                _context.SaveChanges();
            }    
            else
            {
                throw new Exception ("The job is already in the database");
            } 
        }
        public IEnumerable<Job> GetJobsInMemory()
        {
            CheckAndAddJobs();
            return _jobs.Jobs.Values;
        }    
        public Job GetJobFromDictionary(Guid id)
        {
            CheckAndAddJobs();
            return _jobs.Jobs.FirstOrDefault(x => x.Value.Id == id).Value;
        }     
        public void UpdateJobStatus(Job job)
        {
            CheckAndAddJobs();
            _context.Update(job);
            _jobs.Jobs.Values.FirstOrDefault(x => x.Id == job.Id).Status.Equals(job.Status);
            _context.SaveChanges();
        }
        public void AddUserToJob(User user, Job job)
        {
            CheckAndAddJobs();
            _users.CheckAndAddUsers();
            var jobToUpdate = _jobs.Jobs.FirstOrDefault(x => x.Value.Id == job.Id);
            jobToUpdate.Value.Users.Add(user);
            UpdateJobStatus(job);
            _context.Update(jobToUpdate.Value);
            _context.SaveChanges();
        }
        public void CheckAndAddJobs()
        {
            if (_jobs.Jobs.Count() == 0)
            {
                foreach (var item in _context.Jobs)
                {
                    _jobs.Jobs.Add(item.Id, item);
                }
            }
        }
    }
}
