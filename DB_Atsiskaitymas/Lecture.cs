namespace DB_Atsiskaitymas
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = [];
        public List<Student> Students { get; set; } = [];


        public Lecture(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
