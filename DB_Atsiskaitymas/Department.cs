namespace DB_Atsiskaitymas;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; } = [];
    public List<Lecture> Lectures { get; set; } = [];

    public Department(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}
