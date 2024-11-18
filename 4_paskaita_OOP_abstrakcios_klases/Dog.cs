namespace _4_paskaita_OOP_abstrakcios_klases
{
    internal class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
            
        }
        public override string Sound => "Woof Woof!";

        public override void MakeNoise()
        {
            Console.WriteLine("Dog says: " + Sound);
        }
    }
}
