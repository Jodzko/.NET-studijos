namespace Bandymas_SQL_C_
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category{ get; set; }
        public int NumberOfPoints { get; set; }

        public Person(string name, string category, int numberOfPoints)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            NumberOfPoints = numberOfPoints;
        }
    }
}
