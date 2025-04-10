using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class JobService : IJobService
    {
        private readonly IUserJobDb _userJobDb;

        public JobService(IUserJobDb userJobDb)
        {
            _userJobDb = userJobDb;
        }

        public void AddNewJob(string name)
        {
            _userJobDb.AddNewJob(name);
        }
        public IEnumerable<Job> GetJobs()
        {
            return _userJobDb.GetAllJobs();
        }
        public IEnumerable<Job> GetJobsInRecentMemory()
        {
            return _userJobDb.GetJobsInMemory();
        }
        public Job GetJob(Guid id)
        {
            var job = _userJobDb.GetJobFromDictionary(id);
            if(job == null)
            {
                job = _userJobDb.GetJobFromDb(id);
            }
            return job;
        }
        public IEnumerable<Job> GetJobsByStatus(string status)
        {
            var jobs = _userJobDb.GetJobsInMemory();
            if(jobs == null)
            {

            }
            return _userJobDb.GetJobsInMemory();
        }
        public void ChangeJobStatus(Job job)
        {
            var jobToUpdate = _userJobDb.GetJobFromDictionary(job.Id);
            if(jobToUpdate == null)
            {
                jobToUpdate = _userJobDb.GetJobFromDb(job.Id);
                if(jobToUpdate != null)
                {
                    jobToUpdate.Status = "In progress";
                    _userJobDb.UpdateJobStatus(job);
                }
            }
            else
            {
                _userJobDb.AddExistingJobToDictionary(jobToUpdate);
                _userJobDb.UpdateJobStatus(jobToUpdate);
            }

        }
        public void JobIsFinished(Job job)
        {
            var jobToUpdate = _userJobDb.GetJobFromDictionary(job.Id);
            if (jobToUpdate == null)
            {
                jobToUpdate = _userJobDb.GetJobFromDb(job.Id);
                if (jobToUpdate != null)
                {
                    jobToUpdate.Status = "Finished";
                    _userJobDb.UpdateJobStatus(job);
                }
            }
            else
            {
                _userJobDb.AddExistingJobToDictionary(jobToUpdate);
                _userJobDb.UpdateJobStatus(jobToUpdate);
            }
        }
        public void AssignUserToJob(Guid userId, Guid jobId)
        {
            var job = _userJobDb.GetJobFromDictionary(jobId);
            if(job == null)
            {
                job = _userJobDb.GetJobFromDb(jobId);
            }
            var user = _userJobDb.GetUserFromDictionary(userId);
            if(user == null)
            {
                user = _userJobDb.GetUserFromDb(userId);
            }
            if(job != null && user != null)
            {
                _userJobDb.AddUserToJob(user, job);
                if(job.Status != "Waiting")
                {
                ChangeJobStatus(job);
                }
            }
        }
    }
}
