using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Persistence
{
    public class UserJobDictionary
    {
        public Dictionary<Guid, Job> Jobs { get; set; } = new Dictionary<Guid, Job>();
        public Dictionary<Guid, User> Users { get; set; } = new Dictionary<Guid, User>();
    }
}
