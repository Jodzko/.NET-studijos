using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public interface IUserRepository
    {
        public void AddUser(string name);
        public IEnumerable<User> GetUsersInMemory();
        public User GetUserFromDictionary(Guid id);
        public void CheckAndAddUsers();
    }
}
