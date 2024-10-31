using Pokemons;

namespace Methods
{
    public class Class1
    {
        public static class Methods
        {
            //public static List<List<string> PokemonAdding(List<List<string>> pokedex, List<string> pokemon)
            //{
            //    pokedex.Add(pokemon);               
            //    return pokedex;
            //}
            public static void ConsoleGreen()
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            public static void ConsoleYellow()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            public static void ConsoleDarkGray()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            public static void ConsoleRed()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            public static void ConsoleOriginal()
            {
                Console.ResetColor();
            }
            public static void Greeting()
            {
                Console.WriteLine("Get ready to embark on an exciting journey through the vibrant world of Pokémon!");
                Console.WriteLine("Capture, train, and battle alongside your favorite Pokémon as you strive to become a Pokémon Master.");
                Console.WriteLine("Explore lush landscapes, challenge Gym Leaders, and uncover the mysteries of the Pokémon universe.");
                Console.WriteLine("Your adventure begins now—let the quest for glory start! \r\n\r\n");
                Console.WriteLine("Input any key to start...");
                Console.ReadLine();
            }
            public static int FirstPath()
            {
                Console.Clear();
                Console.WriteLine("Choose one of two paths: ");
                Console.WriteLine("1 - Into the green forest");
                Console.WriteLine("2 - Into the dungeons");
                string path1 = Console.ReadLine();
                if (string.IsNullOrEmpty(path1) || string.IsNullOrWhiteSpace(path1))
                {
                    Console.WriteLine("Incorrect selection.");
                    Console.ReadLine();
                    FirstPath();
                }               
                int choice = 0;
                if (path1 == "1" )
                {
                    Console.Clear();
                    ConsoleGreen();
                    Console.WriteLine("As the sun peers through the thick canopy of emerald leaves, the Pokémon Trainer steps into the heart of the Green Forest.");
                    Console.WriteLine("The sound of rustling branches and distant Pokémon cries fills the air, creating a magical atmosphere.");
                    ConsoleOriginal();
                    choice = 1;
                }
                else if (path1 == "2")
                {
                    Console.Clear();
                    ConsoleDarkGray();
                    Console.WriteLine("The Pokémon Trainer steps into the chilling darkness of the dungeons, where shadows dance along the damp stone walls.");
                    Console.WriteLine("The air is thick with mystery, and echoes of distant Pokémon growls send shivers down his spine");
                    ConsoleOriginal();
                    choice = 2;
                }
                else if(path1 == "3")
                {
                    Console.Clear();
                    ConsoleRed();
                    Console.WriteLine("You decided to turn around without even getting the chance to explore the world in front of you.");
                    Console.WriteLine("You were met with the shaming gazes of your fellow trainers...");
                    Console.WriteLine("Your journey is over before it even started....\r\n\r\n\n\n\n");
                    Console.WriteLine("                                                    GAME OVER");
                }
                else if (path1 != "1" || path1 != "2"  )
                {
                    Console.WriteLine("Incorrect selection.");
                    Console.ReadLine();
                    FirstPath();
                }
                
                return choice;
            }
            public static int ForestStart()
            {
                Console.Clear();
                Console.WriteLine("As you set foot into the forest you see three paths ahead of you: ");
                //Console.WriteLine(pikachu.type);
                return 1;

            }
        }
    }
}
