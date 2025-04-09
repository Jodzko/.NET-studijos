using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class UserService : IUserService
    {
        private readonly IUserJobDb _userJobDb;
        private readonly UserJobDbContext _context;

        public UserService(IUserJobDb userJobDb, UserJobDbContext context)
        {
            _userJobDb = userJobDb;
            _context = context;
        }

        public void AddUser(User user)
        {
            var userInDb = _context.Users.FirstOrDefault(x => x.Id == user.Id);
            var userInMemory = _userJobDb.GetUsersInMemory().FirstOrDefault(x => x.Id == user.Id);
            if(userInMemory != null)
            {
                throw new Exception("User is already in memory");
            }
            else if(userInDb != null)
            {
                _userJobDb.AddUserToDictionary(user);
                throw new Exception("User is already in the database, added to memory");
            }
            else
            {
                _userJobDb.AddUser(user);
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
    }
}
