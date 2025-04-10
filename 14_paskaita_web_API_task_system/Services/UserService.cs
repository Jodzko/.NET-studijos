using _14_paskaita_web_API_task_system.Models;
using _14_paskaita_web_API_task_system.Persistence;
using _14_paskaita_web_API_task_system.Services.Interfaces;

namespace _14_paskaita_web_API_task_system.Services
{
    public class UserService : IUserService
    {
        private readonly IUserJobDb _userJobDb;
        private readonly UserJobDbContext _context;
        private readonly UserJobDictionary _dictionary;

        public UserService(IUserJobDb userJobDb, UserJobDbContext context, UserJobDictionary dictionary)
        {
            _userJobDb = userJobDb;
            _context = context;
            _dictionary = dictionary;
        }

        public void AddUser(string name)
        {
            var userInMemory = _userJobDb.GetUsersInMemory().FirstOrDefault(x => x.Name == name);
            if(userInMemory != null)
            {
                throw new Exception("User is already in memory");
            }
            else
            {
                var userInDb = _context.Users.FirstOrDefault(x => x.Name == name);
                if(userInDb != null)
                {
                _userJobDb.AddUserToDictionary(userInDb);
                throw new Exception("User is already in the database, added to memory");
                }
                else
                {
                _userJobDb.AddUser(new User(name));
                }
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userJobDb.GetAllUsers();
        }
        public User GetUserFromDictionary(Guid id)
        {
            return _userJobDb.GetUserFromDictionary(id);
        }
        public User GetUserFromDb(Guid id)
        {
            return _userJobDb.GetUserFromDb(id);
        }
        public void AddUserToDbFromDictionary()
        {

        }
    }
}
