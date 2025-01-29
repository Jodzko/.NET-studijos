namespace DB_Atsiskaitymas
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Lecture> Lectures { get; set; } = [];
        public Department? Department { get; set; }
        public Guid? DepartmentId { get; set; }


        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Guid.NewGuid();
        }
    }
}
