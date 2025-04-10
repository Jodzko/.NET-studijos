using _14_paskaita_web_API_task_system.Cache;
using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class UserService : IUserService
    {
        private readonly IJobRepository _jobRepo;
        private readonly IUserRepository _userRepo;
        private readonly UserCache _users;
        private readonly UserJobDbContext _context;

        public UserService(IJobRepository userJobDb, UserJobDbContext context, IUserRepository userRepo, UserCache users)
        {
            _jobRepo = userJobDb;
            _context = context;
            _userRepo = userRepo;
            _users = users;
        }

        public void AddUser(string name)
        {
           _userRepo.AddUser(name); 
        }
        public IEnumerable<User> GetAllUsers()
        {
            _userRepo.CheckAndAddUsers();
            return _userRepo.GetUsersInMemory();
        }
        public User GetUserFromDictionary(Guid id)
        {
            return _userRepo.GetUserFromDictionary(id);
        }
        
    }
}
