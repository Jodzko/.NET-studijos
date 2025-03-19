namespace _3_paskaita_web_API
{
    public class Car
    {
        public Guid Id;
        public string Model { get; set;}
        public string Color { get; set; }
        

        public Car(string model, string color)
        {
            Id = new Guid();
            Model = model;
            Color = color;
        }
    }
}
