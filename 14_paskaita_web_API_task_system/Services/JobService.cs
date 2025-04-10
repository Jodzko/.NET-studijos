using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepo;
        private readonly IUserRepository _userRepo;

        public JobService(IJobRepository jobRepo, IUserRepository userRepo)
        {
            _jobRepo = jobRepo;
            _userRepo = userRepo;
        }

        public void AddNewJob(string name)
        {
            _jobRepo.AddNewJob(name);
        }
        public IEnumerable<Job> GetJobs()
        {
            return _jobRepo.GetJobsInMemory();
        }
        public Job GetJob(Guid id)
        {
            return _jobRepo.GetJobFromDictionary(id);
        }
        public IEnumerable<Job> GetJobsByStatus(string status)
        {
            return _jobRepo.GetJobsInMemory().Where(x => x.Status == status);
        }
        public void ChangeJobStatus(Job job)
        {
            var jobToUpdate = _jobRepo.GetJobFromDictionary(job.Id);
            if(jobToUpdate != null)
            {
                jobToUpdate.Status = "In progress";
                _jobRepo.UpdateJobStatus(job);
            }
        }
        public void JobIsFinished(Job job)
        {
            var jobToUpdate = _jobRepo.GetJobFromDictionary(job.Id);
            if (jobToUpdate != null)
            {
                jobToUpdate.Status = "Finished";
                _jobRepo.UpdateJobStatus(job);
            }
        }
        public void AssignUserToJob(Guid userId, Guid jobId)
        {
            var job = _jobRepo.GetJobFromDictionary(jobId);
            var user = _userRepo.GetUserFromDictionary(userId);
            if(job != null && user != null)
            {
                _jobRepo.AddUserToJob(user, job);
                if(job.Status != "In progress")
                {
                    ChangeJobStatus(job);
                }
            }
            else if(job == null)
            {
                throw new Exception("There is no job in the database");
            }
            else if(user == null)
            {
                throw new Exception("There is no user in the database");
            }
        }

    }
}
