namespace _15_paskaita_OOP_interface_tasks
{
    public class Carp : IAnimal, IFish
    {
        public string Name { get; set; }
        public int BiggestCaught { get; set; }

        public Carp(string name, int biggestCaught)
        {
            Name = name;
            BiggestCaught = biggestCaught;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} loves eating {food}");
        }

        public void Swim()
        {
            Console.WriteLine("This animal can swim very fast!");
        }
    }
}
