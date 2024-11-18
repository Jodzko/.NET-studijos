namespace _4_paskaita_OOP_abstrakcios_klases
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public abstract string Sound { get; }

        public Animal(double weight)
        {
            Weight = weight;
            
        }

        public abstract void MakeNoise();
    }
}
