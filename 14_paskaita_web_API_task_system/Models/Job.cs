using System.ComponentModel.DataAnnotations;

namespace _14_paskaita_web_API_task_system.Models
{
    public class Job
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartingTime { get; set; }
        public string Status { get; set; }
        public List<User> Users = [];

        public Job(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            StartingTime = DateTime.Now;
            Status = "Waiting";
        }
    }
}
