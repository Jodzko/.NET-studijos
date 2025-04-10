using _14_paskaita_web_API_task_system.Models;

namespace _14_paskaita_web_API_task_system.Cache
{
    public class JobCache
    {
        public Dictionary<Guid, Job> Jobs { get; set; } = new Dictionary<Guid, Job>();

    }
}
