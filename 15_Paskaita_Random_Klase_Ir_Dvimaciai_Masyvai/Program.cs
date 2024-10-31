using System.Text;

namespace _15_Paskaita_Random_Klase_Ir_Dvimaciai_Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methods.RandomSkaiciai();
            //Methods.TrueOrFalse();
            //Methods.SlaptazodzioGeneravimas();
            //Methods.GeneratingAndAdding();
            //Methods.Gambling();
            var list = new List<string> {"cc", "c", "Jonas", "Petras", "Vladas", "d", "cc", "5", "11", "4", "aa", "NUL" };
            var answer = Methods.ASCIIPrimeNumber(list);
            Console.WriteLine("Galutinis sarasas: ");
            for (int i = 0; i < answer.Count; i++)
            {
                
                Console.WriteLine(answer[i]);
            }
        }
        public static class Methods
        {
            public static void RandomSkaiciai()
            {
                Random random = new Random();
                int aRandomNumber1 = random.Next();
                int aRandomNumber2 = random.Next();
                Console.WriteLine(aRandomNumber1);
                Console.WriteLine(aRandomNumber2);
            }
            public static void TrueOrFalse()
            {
                bool a = false;
                Random random = new Random();
                int aRandomNumber1 = random.Next(1, 10);
                if(aRandomNumber1 > 5)
                {
                    a = true;
                    Console.WriteLine(a);
                }
                else
                {
                    a = false;
                    Console.WriteLine(a);
                }
                
            }
            public static StringBuilder SlaptazodzioGeneravimas()
            {
                var chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpRrSsTtUuVvWwXxYyZz";
                var slaptazodzioKurimas = new StringBuilder();
                Random random = new Random();
                for (int i = 0; i < 8; i++)
                {
                    slaptazodzioKurimas.Append(chars[random.Next(chars.Length)]);

                }
                for (int i = 0; i < slaptazodzioKurimas.Length; i++)
                {
                    Console.Write(slaptazodzioKurimas[i]);
                }
                return slaptazodzioKurimas;
            }
            public static void GeneratingAndAdding()
            {
                Random random = new Random();
                var sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    int number = random.Next(1, 6);
                    sum += number;
                    Console.WriteLine(sum);
                }
            }
            public static void Gambling()
            {
                Random random = new Random();
                var number = random.Next(1, 101);
                Console.WriteLine("Guess if the number higher than 50:              (Y/N)");
                string guess = Console.ReadLine();
                Console.WriteLine("The number was: " + number);
                if(guess == "Y" && number > 50 || guess == "N" && number < 50)
                {
                    Console.WriteLine("You win!!");
                }
                else if (guess == "Y" && number < 50 || guess == "N" && number > 50)
                {
                    Console.WriteLine("Gamble failed...");
                }
            }
            public static List<string> ASCIIPrimeNumber( List<string> list)
            {
                var primeList = new List<string>();
                foreach (var item in list)
                {
                    int sum = 0;
                    foreach (var character in item)
                    {
                        int value = (int)character;
                        sum += value;
                    }
                    if (sum == 1 || sum == 0)
                    {
                        Console.WriteLine(item + "  raidziu suma nera pirminis skaicius");
                        break;
                    }
                    else
                    {
                        for (int i = 2; i <= sum; i++)
                        {
                            if (sum % i == 0)
                            {
                                Console.WriteLine(item + "  raidziu suma nera pirminis skaicius");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(item + " raidziu suma yra pirminis skaicius");
                                primeList.Add(item);
                                break;
                            }

                        }
                    }
                    
                }
                return primeList;
            }
        }
    }
}
