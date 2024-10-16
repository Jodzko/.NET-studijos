using System.Runtime.CompilerServices;

namespace _6_Paskaita_Ciklai_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++; // po kiekvieno ciklo prideda 1

            //int i = 1;
            //string result = "";
            //while (i <= 5)
            //{
            //    Console.WriteLine("Iveskite teksta: ");
            //    string input = Console.ReadLine();
            //    result += " " + input;
            //    i++;
            //}
            //Console.WriteLine(result);


            //int x = 1;
            //int y = 1;
            //while(x <= 3)
            //{
            //    Console.WriteLine("Outer scope:  " + x);

            //    while(y <=3)
            //    {
            //        Console.WriteLine("Inner scope:  " + y);
            //        y++;
            //    }
            //    y = 1;//Nustatom vidinio ciklo skaitliuka i pradine reiksme, kad galetume sukti is naujo
            //    x++;
            //}

            //1 uzduotis
            //int i = 1;
            //while (i <=5)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}
            //int k = 5;
            //while (k >= 1)
            //{
            //    Console.WriteLine(k);
            //    k--;
            //}
            //2 uzduotis
            //int i = 2;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //        i++;
            //    }
            //}
            //int k = 9;
            //while (k >= 1)
            //{
            //    if (k % 2 != 0)
            //    {
            //        Console.WriteLine(k);
            //        k--;
            //        k--;

            //    }
            //}
            //Pirmos uzduoties trecia dalis
            //Console.WriteLine("Iveskite skaiciu");
            //int i = int.Parse(Console.ReadLine());
            //while (i > 100)
            //{
            //    Console.WriteLine("Iveskite skaiciu");
            //    i = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Iveskite teigiama skaiciu: ");
            //int k = int.Parse(Console.ReadLine());
            //while (k > 0)
            //{
            //    Console.WriteLine("Iveskite teigiama skaiciu");
            //    k = int.Parse(Console.ReadLine());
            //}

            // Kaip paprasyti ivesti BUTENT skaiciu
            //bool isNumber = false;
            //while (!isNumber)
            //{
            //    Console.WriteLine("Iveskite skaiciu");
            //    string input = Console.ReadLine();
            //    // bool success = int.TryParse(value, out number);
            //    isNumber = double.TryParse(input, out double result);

            //    if (isNumber)
            //    {
            //        Console.WriteLine("Success Parse, number is: " + result);
            //    }

            //}
            //Antra uzduotis
            //Console.WriteLine("Iveskite skaiciu");
            //double i = int.Parse(Console.ReadLine());
            //double sum = 1;
            //while (i != 1)
            //{
            //    sum = sum * i;
            //    i--;
            //    Console.WriteLine(sum);
            //}
            //sum = 1;
            //    Console.WriteLine("Iveskite skaiciu: ");
            //    double k = int.Parse(Console.ReadLine());
            //bool isMoreThanZero = false;
            //    if (k > 0)
            //{
            //    isMoreThanZero = true;
            //}
            //    while (isMoreThanZero)
            //    {
            //    while (k >= 1)
            //    {
            //        sum = sum * k;
            //        k--;
            //    }
            //        Console.WriteLine(sum);
            //    sum = 1;
            //        Console.WriteLine("Iveskite skaiciu: ");
            //    k = int.Parse(Console.ReadLine());
            //    if (k < 0)
            //    {
            //        isMoreThanZero = false;
            //        Console.WriteLine("Your number is negative.");
            //    }


            //    }
            ////// Antros antra dalis

            //Console.WriteLine("Iveskite skaiciu:");
            //string skaicius = Console.ReadLine();
            //int i = 0;
            //char[] skaiciuNumeris = skaicius.ToCharArray();
            //string result = "";
            //while (i <= skaiciuNumeris.Length - 1)
            //{
            //    char digit = skaiciuNumeris[i];

            //    result += digit + ", ";
            //    i++;
            //}
            //Console.WriteLine(result);

            //Do while pavyzdys
            //int number;
            //bool isNumber = false;
            //do
            //{
            //    Console.WriteLine("Iveskite skaiciu: ");
            //    string input = Console.ReadLine();
            //    isNumber = int.TryParse(input, out number);
            //    if (isNumber)
            //    {
            //        Console.WriteLine(input);
            //    }
            //} while (!isNumber);


            // 2 uzduotis 3 dalis
            //Console.WriteLine("Iveskite skaiciu: ");
            //int n = int.Parse(Console.ReadLine());

            //string rezultatas = "";
            //int k = 1;
            //while (k <= n)
            //{
            //    Console.WriteLine(rezultatas += "*");
            //    k++;
            //}

            //5 uzduotis 1 dalis

            //int number;
            //bool isNumber;
            //string input;
            //int suma = 0;
            //do
            //{
            //    Console.WriteLine("Iveskite skaiciu: ");
            //    input = Console.ReadLine();
            //    isNumber = int.TryParse(input, out number);

            //    if (isNumber)
            //    {
            //        suma = suma + number;
            //        Console.WriteLine("Suma: " + suma);

            //    }

            //} while (isNumber || input.ToLower() != "baigti");
            //Console.WriteLine("Galutinis rezultatas: " + suma);
            //Console.WriteLine("Isjungiame programa!");
            // 5 uzduotis 2 dalis






        }
    }
    }

