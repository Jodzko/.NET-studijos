namespace _15_paskaita_OOP_interface_tasks
{
    public class Dog : IAnimal, IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} loves eating {food}");
        }

        public void GiveBirth()
        {
            Console.WriteLine("This animal can give birth");
        }
    }
}
