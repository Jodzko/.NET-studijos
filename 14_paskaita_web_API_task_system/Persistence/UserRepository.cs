using _14_paskaita_web_API_task_system.Cache;
using _14_paskaita_web_API_task_system.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly UserJobDbContext _context;
        private readonly UserCache _users;
        public UserRepository(UserJobDbContext context, UserCache cache)
        {
            _context = context;
            _users = cache;
        }
        public void AddUser(string name)
        {
            CheckAndAddUsers();
            var userInMemory = GetUsersInMemory().FirstOrDefault(x => x.Name == name);
            if (userInMemory != null)
            {
                throw new Exception("User already exists");
            }
            else
            {
                var user = new User(name);
                _users.Users.Add(user.Id, user);
                _context.Add(user);
                _context.SaveChanges();
            }
            
        }
        public IEnumerable<User> GetUsersInMemory()
        {
            return _users.Users.Values;
        }
        public User GetUserFromDictionary(Guid id)
        {
            CheckAndAddUsers();
            return _users.Users.FirstOrDefault(x => x.Value.Id == id).Value;
        }
        public void CheckAndAddUsers()
        {
            if (GetUsersInMemory().Count() == 0)
            {
                foreach (var item in _context.Users)
                {
                    _users.Users.Add(item.Id, item);
                }
            }
        }
    }
}
