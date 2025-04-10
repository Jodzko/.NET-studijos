using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Cache
{
    public class UserCache
    {
        public Dictionary<Guid, User> Users { get; set; } = new Dictionary<Guid, User>();
    }
}
