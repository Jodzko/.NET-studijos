using Student_Repository_2._0;

namespace DB_Atsiskaitymas
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Department> Department { get; set; } = [];
        public List<Student> Students { get; set; } = [];


        public Lecture(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
