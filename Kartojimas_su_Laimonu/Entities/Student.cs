using Kartojimas_su_Laimonu.Entities.Interfaces;

namespace Kartojimas_su_Laimonu.Entities
{
    public class Student : IEntity
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            StudentId = Guid.NewGuid();
        }
    }
}
