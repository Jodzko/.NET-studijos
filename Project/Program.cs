using Pokemons;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods.Class1.Methods.ConsoleRed();
            Methods.Class1.Methods.Greeting();
            Methods.Class1.Methods.ConsoleOriginal();
            int firstChoice = Methods.Class1.Methods.FirstPath();
            if (firstChoice == 1)
            {

            }
            else
            {

            }
            Pokemon pikachu = new Pokemon();
            pikachu.health = 100;
            pikachu.stamina = 100;
            pikachu.type = "Lightning";
            Console.WriteLine("Your Pikachu has: ");
            Console.WriteLine(pikachu.health + " Health " + pikachu.stamina + " Stamina and his type is " + pikachu.type);
            pikachu.health = pikachu.health - 25;
            Console.WriteLine(pikachu.health);
            Pokemon bulbasaur = new Pokemon();
            bulbasaur.health = 95;
            Console.WriteLine(pikachu.health);

        }
    }
}
