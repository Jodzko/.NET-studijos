using System.ComponentModel.DataAnnotations;

namespace _14_paskaita_web_API_task_system.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Job> Jobs = [];

        public User(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
