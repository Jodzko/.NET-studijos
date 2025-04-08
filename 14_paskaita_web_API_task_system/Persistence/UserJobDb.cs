using _14_paskaita_web_API_task_system.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class UserJobDb : IUserJobDb
    {
        public static Dictionary<Guid, Job> Jobs { get; set; } = new Dictionary<Guid, Job>();
        public static Dictionary<Guid, User> Users { get; set; } = new Dictionary<Guid, User>();
        private readonly UserJobDbContext _context;

        public UserJobDb(UserJobDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _context.Jobs;
        }
        public void AddJob(string name)
        {
            var newEntry = new Job(name);
            Jobs.Add(newEntry.Id, newEntry);
            _context.Add(newEntry);
            _context.SaveChanges();
        }
        public IEnumerable<Job> GetJobsInMemory()
        {
            return Jobs.Values;
        }

        public void AddUser(User user)
        {
            Users.Add(user.Id, user);
            _context.Add(user);
            _context.SaveChanges();
        }
        public IEnumerable<User> GetUsersInMemory()
        {
            return Users.Values;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
    }
}
