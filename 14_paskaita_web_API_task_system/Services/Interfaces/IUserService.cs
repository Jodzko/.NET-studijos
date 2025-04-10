using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Services.Interfaces
{
    public interface IUserService
    {
        public void AddUser(string name);
        public IEnumerable<User> GetAllUsers();
        public User GetUserFromDictionary(Guid id);

    }
}
