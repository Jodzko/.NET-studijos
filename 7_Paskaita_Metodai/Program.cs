﻿namespace _7_Paskaita_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintMenu();
            //Console.WriteLine();
            //int userSelection = GetUserSelection();
            //if(userSelection != -1)
            //{
            //    ProcessSelection(userSelection);

            //}
            //DateTime input = new DateTime(2005, 6, 15);

            //if (isOfLegalAge(input))
            //{
            //    Console.WriteLine("Ivestas legalus amzius");
            //}
            //else
            //{
            //    Console.WriteLine("Ivestas nelegalus amzius");
            //}
            //IsPasswordValid("");
            //Console.WriteLine("Iveskite pasta: ");
            //string pastas = Console.ReadLine();
            //IsEmailValid(pastas);

            //Console.WriteLine("Iveskite doleriu suma: ");
            //double doleriai = double.Parse(Console.ReadLine());
            //ConvertEuros(doleriai);

            //Console.WriteLine("Iveskite varda: ");
            //string vardas = Console.ReadLine();
            //Console.WriteLine("Iveskite pavarde: ");
            //string pavarde = Console.ReadLine();
            //GetInitials(vardas, pavarde);


            //Console.WriteLine("Iveskite r: ");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite h: ");
            //double h = double.Parse(Console.ReadLine());
            //CalculateCylinderVolume(r, h);


            //Console.WriteLine("Iveskite skaiciu: ");
            //int skaicius = int.Parse(Console.ReadLine());
            //IsNumberEven(skaicius);
            //Console.WriteLine("Iveskite skaiciu: ");
            //int n = int.Parse(Console.ReadLine());
            //Recursion(n);
            //Console.WriteLine("Fibonacci skaiciavimo sistemai pradeti - iveskite 1: ");
            //int n = int.Parse(Console.ReadLine());
            //Fibonacci(n);


        }

        public static bool isOfLegalAge(DateTime birthdate)
        {
            return CalculateAge(birthdate) >= 20;
        }
        public static int CalculateAge(DateTime birthdate)
        {
            return DateTime.Now.Year - birthdate.Year;
        }

        private static int ReturnNumber()
        {
            return 100;
        }
        private static void PrintMenu()
        {
            Console.WriteLine("1. Spausdinti prekes");
            Console.WriteLine("2. Ziureti krepseli");
            Console.WriteLine("3. Isvalyti krepseli");
            Console.WriteLine("4. Pirkti");
            Console.WriteLine("5. Isjungti programa");
        }
        private static int GetUserSelection()
        {
            Console.WriteLine("Iveskite pasirinkima");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int result) && (result >= 1 && result <=5))
                {
                    return result;
                }
                Console.WriteLine("Iveskite skaiciu tarp 1 ir 5");
            }
            return -1;
        }
        private static void ProcessSelection(int selection)
        {
            switch (selection) 
            {
                case 1:
                    Console.WriteLine("Pasirinkote spausdinti prekes");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote ziureti krepseli");
                break;
                case 3:
                    Console.WriteLine("Pasirinkote isvalyti krepseli");
                    break;
                case 4:
                    Console.WriteLine("Pasirinktote pirkti");
                    break;
                case 5:
                    Console.WriteLine("Pasirinkote isjungti programa");
                    break;
            }
        }
        private static bool IsPasswordValid(string password)
        {
            Console.WriteLine("Iveskite slaptazodi: ");
            string slaptazodis = Console.ReadLine();
             
            if (slaptazodis.Length > 8)
            {
                Console.WriteLine("Slaptazodis tinka");
                return true;
            }
            
            else
            {
                Console.WriteLine("Slaptazodis per trumpas");
                return false;
            }
            
        }
        private static bool IsEmailValid(string email)
        {
            
            char[] zenklai = email.ToCharArray();
            
            if ( zenklai.Contains<char>('.') && zenklai.Contains<char>('@') )
            {
                Console.WriteLine("Pastas sekmingai ivestas");
                return true;
            }
            else
            {
                Console.WriteLine("Blogai ivedete pasta");
                return false;
            }
        }
        private static double ConvertEuros(double doleriai)
        {
            double eurai = 0;
            if(doleriai > 0)
            {
                eurai = doleriai * 0.85;
                Console.WriteLine(doleriai + " doleriu yra " + eurai + " euru");
            }
            else
            {
                Console.WriteLine("blogai ivedete eurus");
            }
            return eurai;
        }
        private static string GetInitials(string FirstName, string LastName)
        {
            
            Console.WriteLine("Jusu vardas: " + FirstName + " Jusu pavarde: "  + LastName);
            return FirstName;
            return LastName;
           
        }
        private static double CalculateCylinderVolume(double radius, double height)
        {
            double volume = 0;
            if(radius > 0 && height > 0)
            {
                volume = Math.PI * (radius * radius) * height;
                Console.WriteLine("Cilindro turis: " + volume);
            }
            return volume;
        }
        private static bool IsNumberEven(int number)
        {
            bool isEven = false;
            if(number % 2 == 0)
            {
                isEven = true;
                Console.WriteLine("Skaicius lyginis");
            }
            else
            {
                Console.WriteLine("Skaicius nelyginis");
            }
            return isEven;
        }

       public static int Recursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                number = number * Recursion(number - 1);

            }
            Console.WriteLine(number);
            return number;

        }
        //public static int Fibonacci(int sum, int x, int y)
        //{
            
        //    while (sum <= 600)
        //    {

        //        sum = x + y;
                
        //    }
        //    Console.WriteLine(number);
        //    return number;
        //}
    }
}
