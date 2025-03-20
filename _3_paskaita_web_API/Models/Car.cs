namespace _3_paskaita_web_API.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Id = Guid.NewGuid();
        }
    }
}
